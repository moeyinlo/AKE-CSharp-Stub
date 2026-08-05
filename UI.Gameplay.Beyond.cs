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

// Image 21: UI.Gameplay.Beyond.dll - Assembly: UI.Gameplay.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 54041-54273
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public class UIEquipRotHelper : TickableUIMono // TypeDefIndex: 54042
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
	protected override TickType tickOption { get; } // 0x0000000184D8D060-0x0000000184D8D070 
	public bool playing { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8E640-0x0000000184D8E650 0x0000000184D8E670-0x0000000184D8E680

	// Constructors
	public UIEquipRotHelper(); // 0x000000018B114A14-0x000000018B114A28

	// Methods
	private Vector3 _ClampRot(Vector3 rot); // 0x000000018B11484C-0x000000018B1148D4
	private Vector3 _GetNearZero(Vector3 rot); // 0x000000018B1148D4-0x000000018B114930
	private void _Init(); // 0x000000018B114930-0x000000018B114A14
	protected override void OnAwake(); // 0x000000018B114130-0x000000018B114150
	public override void Tick(float deltaTime); // 0x000000018B11430C-0x000000018B11484C
	public void SelectPart(int index); // 0x000000018B114178-0x000000018B11430C
	protected override void OnRelease(); // 0x000000018B114150-0x000000018B114178
	[CompilerGenerated]
	private void _SelectPart_b__22_0(); // 0x0000000184DAB010-0x0000000184DAB020
}

[ExecuteAlways]
public class UIWatchPanelCut : TickableUIMono // TypeDefIndex: 54043
{
	// Fields
	private Vector3 m_watchpanelPos; // 0x68
	private Vector3 m_watchpanelDir; // 0x74
	private Vector3 m_watchpanelRadius; // 0x80
	public float minimapRadius; // 0x8C
	public float eclosionRange; // 0x90

	// Properties
	protected override TickType tickOption { get; } // 0x0000000184D8D060-0x0000000184D8D070 

	// Constructors
	public UIWatchPanelCut(); // 0x00000001839C2B00-0x00000001839C2B10

	// Methods
	public void Start(); // 0x0000000184422590-0x0000000184422620
	public Vector3 GetIntersectWithLineAndPlane(Vector3 point, Vector3 direct, Vector3 planeNormal, Vector3 planePoint); // 0x000000018B114A28-0x000000018B114B8C
	public override void Tick(float deltaTime); // 0x0000000184422620-0x00000001844226D0
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 54269
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_12 _11328A8F924E37E9332EFD9B6E621017D16D4199479DF8ADFCC16A5EB52CB3EB; // 0x00 // Static value (base64): CgAAAAMAAAADAAAA - Metadata: 0x02343B54

	// Nested types
	private struct __StaticArrayInitTypeSize_12 // TypeDefIndex: 54268
	{
	}

	// Methods
	internal static uint ComputeStringHash(string s); // 0x000000018687A850-0x000000018687A8A4
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_UI_Gameplay_Beyond // TypeDefIndex: 54045
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime(); // 0x0000000184CE2100-0x0000000184CE2130
		private static void Initialize(); // 0x0000000184CE2130-0x0000000184CE21B0
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 54046
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 54047
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 54048
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 54049
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 54050
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Beyond.UI
{
	public abstract class UICharPassiveBase : MonoBehaviour // TypeDefIndex: 54051
	{
		// Fields
		private ObjectPtr<AbilitySystem> m_boundAbilityPtr; // 0x18
		private bool m_buffIconListenerRegistered; // 0x28
		private bool m_destroying; // 0x29
	
		// Properties
		protected virtual bool listenBuffIconChange { get; } // 0x0000000184CDBE60-0x0000000184CDBE90 
	
		// Constructors
		protected UICharPassiveBase(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public virtual void OnCharPassiveNumChanged(float num); // 0x000000018B1128B8-0x000000018B112908
		protected virtual void OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x000000018B112838-0x000000018B1128B8
		protected virtual void OnBound(AbilitySystem ability); // 0x0000000184CEB8F0-0x0000000184CEB920
		protected virtual void OnBeforeUnbind(AbilitySystem ability); // 0x00000001838C8BB0-0x00000001838C8BE0
		public void Bind(AbilitySystem ability); // 0x00000001838C8BE0-0x00000001838C8D30
		public void Unbind(); // 0x00000001838C8D30-0x00000001838C8DF0
		protected virtual void OnDestroy(); // 0x000000018B112908-0x000000018B11295C
	}

	public class UICharPassiveCounter : UICharPassiveBase // TypeDefIndex: 54052
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
		public UICharPassiveCounter(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public override void OnCharPassiveNumChanged(float num); // 0x000000018B11295C-0x000000018B112ADC
		public void __iFixBaseProxy_OnCharPassiveNumChanged(float P0); // 0x000000018B112ADC-0x000000018B112AE4
	}

	public class UICharPassiveLiino : UICharPassiveBase // TypeDefIndex: 54055
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
		protected override bool listenBuffIconChange { get; } // 0x000000018B113E10-0x000000018B113E58 
	
		// Nested types
		[Serializable]
		public struct AnimStateInfo // TypeDefIndex: 54053
		{
			// Fields
			public int fillAmount; // 0x00
			public string animName; // 0x08
		}
	
		private enum DisplayState // TypeDefIndex: 54054
		{
			Idle = 0,
			Normal = 1,
			Ultimate = 2
		}
	
		// Constructors
		public UICharPassiveLiino(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x000000018B112AE4-0x000000018B112C20
		protected override void OnDestroy(); // 0x000000018B113098-0x000000018B113124
		protected override void OnBound(AbilitySystem ability); // 0x000000018B112C90-0x000000018B112ED0
		protected override void OnBeforeUnbind(AbilitySystem ability); // 0x000000018B112C20-0x000000018B112C90
		protected override void OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x000000018B112ED0-0x000000018B113098
		private void _TryTrackBuff(ObjectPtr<Buff> buffPtr, string id); // 0x000000018B113B58-0x000000018B113C20
		private void _ForceIdle(); // 0x000000018B113278-0x000000018B113368
		private void _RefreshDisplay(); // 0x000000018B11375C-0x000000018B1139C8
		private void _OnLateTick(float deltaTime); // 0x000000018B11369C-0x000000018B11375C
		private void _CheckLoopThreshold(Buff activeBuff); // 0x000000018B1131B0-0x000000018B113278
		private void _InitDecoThresholds(Buff activeBuff); // 0x000000018B11344C-0x000000018B1135E0
		private void _UpdateDecoThresholds(float progress); // 0x000000018B113C20-0x000000018B113E10
		private Buff _GetActiveBuffForDisplay(); // 0x000000018B113368-0x000000018B113428
		private bool _IsBuffValid(ObjectPtr<Buff> ptr); // 0x000000018B1135E0-0x000000018B11369C
		private static float _CalcProgress(Buff buff); // 0x000000018B106E00-0x000000018B106FC8
		private void _SetProgress(Buff activeBuff); // 0x000000018B1139C8-0x000000018B113ABC
		private void _SetTickRunning(bool running); // 0x000000018B113ABC-0x000000018B113B58
		private UIAnimationWrapper _GetAnimWrapper(DisplayState state); // 0x000000018B113428-0x000000018B113438
		private UIAnimationWrapper _GetDecoWrapper(DisplayState state); // 0x000000018B113438-0x000000018B11344C
		[CompilerGenerated]
		private void __RefreshDisplay_b__35_0(); // 0x000000018B113168-0x000000018B1131B0
		public bool __iFixBaseProxy_get_listenBuffIconChange(); // 0x000000018B113160-0x000000018B113168
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B113158-0x000000018B113160
		public void __iFixBaseProxy_OnBound(AbilitySystem P0); // 0x000000018B11312C-0x000000018B113134
		public void __iFixBaseProxy_OnBeforeUnbind(AbilitySystem P0); // 0x000000018B113124-0x000000018B11312C
		public void __iFixBaseProxy_OnBuffIconChange(ObjectPtr<Buff> P0, bool P1, Buff.FinishReason P2); // 0x000000018B113134-0x000000018B113158
	}

	public class UICharPassiveLizhiyan : UICharPassiveBase // TypeDefIndex: 54056
	{
		// Fields
		public UIStateController stateController; // 0x30
		public UIText countText; // 0x38
		public UICharPassiveMultiStates.StateInfo[] states; // 0x40
		public int fullCount; // 0x48
		private int m_currentCount; // 0x4C
	
		// Constructors
		public UICharPassiveLizhiyan(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public override void OnCharPassiveNumChanged(float num); // 0x000000018B113E58-0x000000018B113FA0
		public void __iFixBaseProxy_OnCharPassiveNumChanged(float P0); // 0x000000018B112ADC-0x000000018B112AE4
	}

	public class UICharPassiveMultiStates : UICharPassiveBase // TypeDefIndex: 54058
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
		public struct StateInfo // TypeDefIndex: 54057
		{
			// Fields
			public int count; // 0x00
			public string stateName; // 0x08
		}
	
		// Constructors
		public UICharPassiveMultiStates(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public override void OnCharPassiveNumChanged(float num); // 0x000000018B113FA0-0x000000018B114130
		public void __iFixBaseProxy_OnCharPassiveNumChanged(float P0); // 0x000000018B112ADC-0x000000018B112AE4
	}

	public class UICharPassiveZhuangfy : UICharPassiveBase // TypeDefIndex: 54059
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
		public UICharPassiveZhuangfy(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		public override void OnCharPassiveNumChanged(float num); // 0x0000000183CEBCC0-0x0000000183CEBEB0
		public void __iFixBaseProxy_OnCharPassiveNumChanged(float P0); // 0x000000018B112ADC-0x000000018B112AE4
	}

	public class LiinoRandomLikeEffect : TickableUIMono // TypeDefIndex: 54062
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
		protected override TickType tickOption { get; } // 0x000000018B1127BC-0x000000018B112808 
	
		// Nested types
		private struct PendingEffect // TypeDefIndex: 54060
		{
			// Fields
			public UIAnimationWrapper anim; // 0x00
			public Vector3 worldPos; // 0x08
			public float triggerTime; // 0x14
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 54061
		{
			// Fields
			public UIAnimationWrapper cached; // 0x10
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __CacheHideCallbacks_b__0(); // 0x000000018B112808-0x000000018B112838
		}
	
		// Constructors
		public LiinoRandomLikeEffect(); // 0x000000018B11263C-0x000000018B1127BC
	
		// Methods
		protected override void OnAwake(); // 0x000000018B11167C-0x000000018B111704
		private void _CacheHideCallbacks(UIAnimationWrapper[] anims); // 0x000000018B111D0C-0x000000018B111E64
		public void PlayEffect(); // 0x000000018B1117D4-0x000000018B111B64
		public override void Tick(float deltaTime); // 0x000000018B111B64-0x000000018B111D0C
		public void OnHide(); // 0x000000018B111704-0x000000018B1117D4
		private static void _ClearAnims(UIAnimationWrapper[] anims); // 0x000000018B111E64-0x000000018B111F08
		private UIAnimationWrapper _GetNextAvailableBig(); // 0x000000018B111F08-0x000000018B111FEC
		private UIAnimationWrapper _GetNextAvailableSmall(); // 0x000000018B111FEC-0x000000018B112144
		private RectTransform _SelectArea(); // 0x000000018B112464-0x000000018B112578
		private bool _SelectHalf(); // 0x000000018B112578-0x000000018B11263C
		private Vector3 _GetRandomPointInArea(RectTransform area, bool isUpper); // 0x000000018B112144-0x000000018B1122D0
		private void _PlayEffectAt(UIAnimationWrapper anim, Vector3 worldPos); // 0x000000018B1122D0-0x000000018B112464
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public abstract class ComboSpecialNodeBase : MonoBehaviour // TypeDefIndex: 54063
	{
		// Fields
		protected ComboSkillHint m_owner; // 0x18
	
		// Properties
		public abstract bool needTick { get; }
	
		// Constructors
		protected ComboSpecialNodeBase(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public virtual void OnAssignData(ComboSkillHint owner); // 0x000000018B106FC8-0x000000018B107028
		public virtual void OnReady(); // 0x000000018B107068-0x000000018B1070A8
		public virtual void OnTick(float deltaTime); // 0x000000018B1070E8-0x000000018B107138
		public virtual void OnCast(); // 0x000000018B107028-0x000000018B107068
		public virtual void OnRemove(); // 0x000000018B1070A8-0x000000018B1070E8
		public abstract void OnRelease();
	}

	public class ComboSpecialNodeRingQte : ComboSpecialNodeBase // TypeDefIndex: 54065
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
		public override bool needTick { get; } // 0x000000018B108018-0x000000018B108060 
	
		// Nested types
		private enum RingState // TypeDefIndex: 54064
		{
			None = 0,
			EarlyState = 1,
			PerfectState = 2,
			MissState = 3,
			PressedState = 4
		}
	
		// Constructors
		public ComboSpecialNodeRingQte(); // 0x000000018B107FEC-0x000000018B108018
	
		// Methods
		public override void OnAssignData(ComboSkillHint owner); // 0x000000018B107138-0x000000018B1076C4
		public override void OnCast(); // 0x000000018B1076C4-0x000000018B1078B0
		public override void OnRemove(); // 0x000000018B1079E0-0x000000018B107A30
		public override void OnTick(float deltaTime); // 0x000000018B107A30-0x000000018B107CFC
		public override void OnRelease(); // 0x000000018B1078B0-0x000000018B1079E0
		private void _OnComboSkillRingQte([IsReadOnly] in EventData<int, float, float> evtData); // 0x000000018B107DE0-0x000000018B107F60
		private float _GetRemainTime(); // 0x000000018B107D1C-0x000000018B107DE0
		private void _Reset(); // 0x000000018B107F60-0x000000018B107FEC
		public void __iFixBaseProxy_OnAssignData(ComboSkillHint P0); // 0x000000018B107CFC-0x000000018B107D04
		public void __iFixBaseProxy_OnCast(); // 0x000000018B107D04-0x000000018B107D0C
		public void __iFixBaseProxy_OnRemove(); // 0x000000018B107D0C-0x000000018B107D14
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018B107D14-0x000000018B107D1C
	}

	public enum DamageTextType // TypeDefIndex: 54066
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

	public class DamageTextCtrl : UIPanelBase // TypeDefIndex: 54068
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
		private const string GUARD_OVERWRITE_COALITION_KEY = "guard_overwrite"; // Metadata: 0x023433C7
		private const string CRYST_BREAK_TEXT_ID = "ui_bat_elemental_cryst_break"; // Metadata: 0x023433D7
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
		protected override TickType tickOption { get; } // 0x0000000184A799C0-0x0000000184A799F0 
		private static Vector3 outOfScreenPos { get; } // 0x000000018B10ED84-0x000000018B10EE10 
	
		// Nested types
		private struct CoalitionDetail // TypeDefIndex: 54067
		{
			// Fields
			public DamageTextBase instance; // 0x00
			public float time; // 0x08
			public double value; // 0x10
		}
	
		// Constructors
		public DamageTextCtrl(); // 0x0000000184607D10-0x0000000184608010
		static DamageTextCtrl(); // 0x00000001849C12D0-0x00000001849C14A0
	
		// Methods
		public void OnCreate(); // 0x000000018B10BAB4-0x000000018B10C304
		public void OnClose(); // 0x000000018B10B670-0x000000018B10BAB4
		public void DebugChangeImpl(bool disableThis); // 0x000000018B10AEDC-0x000000018B10B670
		public void OnShow(); // 0x000000018B10C350-0x000000018B10C584
		public void OnHide(); // 0x000000018B10C304-0x000000018B10C350
		public override void Tick(float deltaTime); // 0x0000000184CDF3D0-0x0000000184CDF490
		private void _OnHpChanged([IsReadOnly] in EventData<AbilitySystem.Modifier> eventData); // 0x000000018B10CEA4-0x000000018B10E4C0
		private void _OnIgniteBuffText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> eventData); // 0x000000018B10E4C0-0x000000018B10E764
		private void _OnPhysicalInflictionApplied([IsReadOnly] in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> eventData); // 0x000000018B10E984-0x000000018B10EACC
		private void _OnImmuneText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string> eventData); // 0x000000018B10E764-0x000000018B10E984
		private void _OnSquadInFightChanged([IsReadOnly] in EventData<bool> eventData); // 0x000000018B10EACC-0x000000018B10EB7C
		private void _OnCreateFlowText([IsReadOnly] in EventData<Vector3, string, UnityEngine.Color> eventData); // 0x000000018B10CD70-0x000000018B10CEA4
		private void _OnCharLevelUp([IsReadOnly] in EventData<ulong, int> eventData); // 0x000000018B10CAEC-0x000000018B10CD70
		private Vector2 _GetRandomTextOffset(float width, float height); // 0x000000018B10C738-0x000000018B10C800
		private bool _IsTextPosValid(Vector3 newPos); // 0x000000018B10C8F4-0x000000018B10CAEC
		private DamageTextBase _CreateTextInstance(DamageTextType textType); // 0x000000018B10C584-0x000000018B10C738
		private DamageTextBase _InstantiateTextInstance(DamageTextType textType); // 0x000000018B10C800-0x000000018B10C8F4
		private void _RecycleTextInstance(DamageTextBase textInstance); // 0x000000018B10EB7C-0x000000018B10ED84
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class DamageTextCtrlV2 : UIPanelBase // TypeDefIndex: 54071
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
		[Header("\u4E3B\u63A7\u4F24\u5BB3\u8DF3\u5B57")]
		public Vector2 mainChrDmgTxtSpawnOffset; // 0x11C
		public Vector2 mainChrDmgTxtMoveSpawnOffset; // 0x124
		public int mainChrDmgTxtMoveNum; // 0x12C
		public float mainChrDmgTxtMoveSpawnWaitTime; // 0x130
		public float dmgTxtCoalitionMaxTime; // 0x134
		[Header("\u961F\u53CB\u4F24\u5BB3\u8DF3\u5B57")]
		public Vector2 guardDmgTxtSpawnOffset; // 0x138
		public Vector2 guardDmgTxtSpawnAreaSize; // 0x140
		public bool enableGuardDmgTxtOverwrite; // 0x148
		[Header("\u5F02\u5E38\u8DF3\u5B57")]
		public Vector2 physicalInflictionTextOffset; // 0x14C
		public Vector2 spellInflictionTextOffset; // 0x154
		private const string GUARD_OVERWRITE_COALITION_KEY = "guard_overwrite"; // Metadata: 0x023433F5
		private const string CRYST_BREAK_TEXT_ID = "ui_bat_elemental_cryst_break"; // Metadata: 0x02343405
		private bool m_isShow; // 0x15C
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
		protected override TickType tickOption { get; } // 0x0000000184A799F0-0x0000000184A79A20 
		private static Vector3 outOfScreenPos { get; } // 0x000000018B10AE50-0x000000018B10AEDC 
	
		// Nested types
		private struct CoalitionDetail // TypeDefIndex: 54069
		{
			// Fields
			public DamageTextBaseV2 instance; // 0x00
			public float time; // 0x08
			public double value; // 0x10
		}
	
		[Serializable]
		public class IgnitePrefabOverride // TypeDefIndex: 54070
		{
			// Fields
			public EnergyShardType energyShardType; // 0x10
			public string overrideName; // 0x18
			public bool isCrystBreak; // 0x20
	
			// Constructors
			public IgnitePrefabOverride(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public DamageTextCtrlV2(); // 0x0000000184608010-0x0000000184608460
	
		// Methods
		public void OnCreate(); // 0x000000018424A520-0x000000018424C7C0
		public void OnClose(); // 0x000000018B109F84-0x000000018B10A3CC
		public void DebugChangeImpl(bool disableThis); // 0x000000018B109864-0x000000018B109F84
		public void OnShow(); // 0x00000001848904D0-0x00000001848906E0
		public void OnHide(); // 0x0000000184CA3070-0x0000000184CA30A0
		public override void Tick(float deltaTime); // 0x0000000183098560-0x00000001830987B0
		private void _OnHpChanged([IsReadOnly] in EventData<AbilitySystem.Modifier> eventData); // 0x0000000183AAA9B0-0x0000000183AAD2B0
		private void _OnIgniteBuffText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> eventData); // 0x000000018B10A74C-0x000000018B10AB0C
		private void _OnPhysicalInflictionApplied([IsReadOnly] in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> eventData); // 0x000000018B10AD04-0x000000018B10AE50
		private void _OnImmuneText([IsReadOnly] in EventData<AbilitySystem, Vector3, Vector2, string> eventData); // 0x000000018B10AB0C-0x000000018B10AD04
		private void _OnSquadInFightChanged([IsReadOnly] in EventData<bool> eventData); // 0x0000000183CD55F0-0x0000000183CD5690
		private void _OnCreateFlowText([IsReadOnly] in EventData<Vector3, string, UnityEngine.Color> eventData); // 0x000000018B10A61C-0x000000018B10A74C
		private void _OnCharLevelUp([IsReadOnly] in EventData<ulong, int> eventData); // 0x000000018B10A3D4-0x000000018B10A61C
		private bool _UseWorldSpaceRandomArea(Vector3 textWorldPos); // 0x0000000184608B90-0x0000000184609260
		private Vector2 _GetRandomTextOffset(float width, float height, bool useWorldOffset = false /* Metadata: 0x023433F4 */, Vector3 textWorldPos = default); // 0x0000000183772E50-0x0000000183774200
		private bool _IsTextPosValid(Vector3 newPos); // 0x000000018443F0A0-0x000000018443F2F0
		private DamageTextBaseV2 _CreateTextInstance(DamageTextType textType, string overrideName = null); // 0x0000000183AAA840-0x0000000183AAA950
		private void _RecycleTextInstance(DamageTextBaseV2 textInstance); // 0x0000000183AAA400-0x0000000183AAA4D0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class DamageTextBase : TickableUIMono // TypeDefIndex: 54073
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
		protected override TickType tickOption { get; } // 0x00000001844EBAE0-0x00000001844EBB10 
		public bool isFollowingTransform { get; } // 0x000000018B10935C-0x000000018B1093A8 
		public Vector3 worldPosition { get; } // 0x000000018B109408-0x000000018B1094EC 
		public Vector2 uiOffset { get; } // 0x000000018B1093A8-0x000000018B109408 
	
		// Nested types
		[Serializable]
		public class SpawnPointConfig // TypeDefIndex: 54072
		{
			// Fields
			public Beyond.Gameplay.Core.ObjectType objectType; // 0x10
			public bool followTarget; // 0x14
			public bool useHitPoint; // 0x15
			[Tooltip("\u5982\u679C\u9009\u62E9\u751F\u6210\u5728\u6253\u51FB\u70B9\uFF0C\u6253\u51FB\u70B9\u4E0D\u5B58\u5728\u65F6\u4E5F\u4F1A\u5728\u6B64\u9AA8\u9ABC\u751F\u6210")]
			public Beyond.Gameplay.MountPoint targetMountPoint; // 0x18
	
			// Constructors
			public SpawnPointConfig(); // 0x0000000184DAB000-0x0000000184DAB010
		}
	
		// Constructors
		public DamageTextBase(); // 0x00000001839C3430-0x00000001839C3550
	
		// Methods
		protected override void OnAwake(); // 0x00000001844F4CB0-0x00000001844F4D70
		protected override void OnRelease(); // 0x000000018B1085BC-0x000000018B10867C
		public override void TailLateTick(float deltaTime); // 0x000000018B109064-0x000000018B1090E4
		public void SetFollowTarget(AbilitySystem target, AbilitySystem textTargetWhenTransferred, Vector3? hitPoint); // 0x000000018B1087AC-0x000000018B108D68
		public void SetUIOffset(Vector2 offset); // 0x000000018B109004-0x000000018B109064
		public void Clear(); // 0x000000018B10855C-0x000000018B1085BC
		public virtual void SetColor(UnityEngine.Color color); // 0x000000018B10872C-0x000000018B1087AC
		public virtual void PlayAnimation(); // 0x000000018B10867C-0x000000018B10872C
		private void _UpdatePosition(); // 0x000000018B1090E4-0x000000018B10935C
		[IDTag(2)]
		public void SetText(string newText); // 0x000000018B108E5C-0x000000018B108F30
		[IDTag(1)]
		public void SetText(int newValue); // 0x000000018B108F30-0x000000018B109004
		[IDTag(0)]
		public void SetText(string prefix, int newValue); // 0x000000018B108D68-0x000000018B108E5C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000186C37238-0x0000000186C37240
	}

	public class DamageTextBaseV2 // TypeDefIndex: 54077
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
		[CompilerGenerated]
		private ulong _targetCharInst_k__BackingField; // 0x50
		protected UnSafeString.UnSafeStringHandle m_textHandle; // 0x58
	
		// Properties
		public ulong targetCharInst { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000184D867A0-0x0000000184D867B0
		public float textNodeAlpha { get; } // 0x0000000183AAA800-0x0000000183AAA840 
		public float showDuration { get; } // 0x0000000184CAE170-0x0000000184CAE1B0 
		public bool isFollowingTransform { get; } // 0x00000001830983A0-0x00000001830983D0 
		public bool isActive { get; } // 0x00000001830987B0-0x0000000183098800 
		public Vector3 worldPosition { get; } // 0x0000000183098340-0x00000001830983A0 
		public Vector2 uiOffset { get; } // 0x00000001848B5F10-0x00000001848B5F50 
	
		// Nested types
		[Serializable]
		public class SpawnPointConfig // TypeDefIndex: 54074
		{
			// Fields
			public Beyond.Gameplay.Core.ObjectType objectType; // 0x10
			public bool followTarget; // 0x14
			public bool useHitPoint; // 0x15
			[Tooltip("\u5982\u679C\u9009\u62E9\u751F\u6210\u5728\u6253\u51FB\u70B9\uFF0C\u6253\u51FB\u70B9\u4E0D\u5B58\u5728\u65F6\u4E5F\u4F1A\u5728\u6B64\u9AA8\u9ABC\u751F\u6210")]
			public Beyond.Gameplay.MountPoint targetMountPoint; // 0x18
	
			// Constructors
			public SpawnPointConfig(); // 0x0000000184DAB000-0x0000000184DAB010
		}
	
		public enum DamageTextSortingPriority // TypeDefIndex: 54075
		{
			Level0 = 0,
			Level1 = 1,
			Level2 = 2
		}
	
		[Serializable]
		public class DamageTextBaseConfig // TypeDefIndex: 54076
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
			public DamageTextBaseConfig(); // 0x000000018448A9D0-0x000000018448AB30
		}
	
		// Constructors
		public DamageTextBaseV2(GPUISystem uiSystem); // 0x00000001844F4C70-0x00000001844F4CB0
		static DamageTextBaseV2(); // 0x0000000184D75B00-0x0000000184D75B40
	
		// Methods
		public void OnRelease(); // 0x000000018B1080BC-0x000000018B108124
		public void Assign(DamageTextBaseConfig config, string overrideName = null); // 0x0000000183AAA5A0-0x0000000183AAA690
		public void Tick(Vector2 screenCenter, float scaleFactor); // 0x0000000183098840-0x00000001830988A0
		public void SetFollowTarget(AbilitySystem target, AbilitySystem textTargetWhenTransferred, Vector3? hitPoint); // 0x0000000184410220-0x0000000184410AC0
		public void SetUIOffset(Vector2 offset); // 0x0000000183AAA7C0-0x0000000183AAA800
		public void Clear(); // 0x0000000183AAA4D0-0x0000000183AAA520
		public void DestroyDisplay(); // 0x000000018B108060-0x000000018B1080BC
		public virtual void SetColor(UnityEngine.Color color); // 0x000000018363A4D0-0x000000018363B350
		public virtual void PlayAnimation(bool isLeft = true /* Metadata: 0x02343422 */); // 0x0000000183AAA740-0x0000000183AAA7C0
		private void _UpdatePosition(Vector2 screenCenter, float scaleFactor); // 0x0000000183097620-0x0000000183098340
		[IDTag(2)]
		public void SetText(string newText); // 0x000000018B108354-0x000000018B10855C
		[IDTag(1)]
		public void SetText(int newValue); // 0x000000018363B350-0x000000018363B6C0
		[IDTag(0)]
		public void SetText(string prefix, int newValue); // 0x000000018B108124-0x000000018B108354
	}

	public class DamageTextBlock : DamageTextDamageBase // TypeDefIndex: 54078
	{
		// Fields
		public UIImage blockIcon; // 0xC0
	
		// Constructors
		public DamageTextBlock(); // 0x00000001839C21D0-0x00000001839C21E0
	
		// Methods
		public override void SetColor(UnityEngine.Color color); // 0x000000018B1094EC-0x000000018B109594
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0); // 0x000000018B109594-0x000000018B1095B4
	}

	public class DamageTextCriticalLevel0 : DamageTextDamageBase // TypeDefIndex: 54079
	{
		// Fields
		public UIText criticalIcon; // 0xC0
	
		// Constructors
		public DamageTextCriticalLevel0(); // 0x00000001839C21D0-0x00000001839C21E0
	
		// Methods
		public override void SetColor(UnityEngine.Color color); // 0x000000018B1095B4-0x000000018B109654
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0); // 0x000000018B109594-0x000000018B1095B4
	}

	public class DamageTextCriticalLevel1 : DamageTextDamageBase // TypeDefIndex: 54080
	{
		// Fields
		public UIText criticalIcon; // 0xC0
		public UIText criticalIconShadow; // 0xC8
		public UIImage bg01; // 0xD0
		public UIImage bg02; // 0xD8
		private const string ANIM_NAME_CRITICAL_LEFT = "battletext_critical_left"; // Metadata: 0x02343426
		private const string ANIM_NAME_CRITICAL_RIGHT = "battletext_critical_right"; // Metadata: 0x0234343F
	
		// Constructors
		public DamageTextCriticalLevel1(); // 0x00000001839C21D0-0x00000001839C21E0
	
		// Methods
		public override void SetColor(UnityEngine.Color color); // 0x000000018B109748-0x000000018B10985C
		public override void PlayAnimation(bool isLeft); // 0x000000018B109654-0x000000018B109748
		public void __iFixBaseProxy_SetColor(UnityEngine.Color P0); // 0x000000018B109594-0x000000018B1095B4
		public void __iFixBaseProxy_PlayAnimation(bool P0); // 0x000000018B10985C-0x000000018B109864
	}

	public class DamageTextDamageBase : DamageTextBase // TypeDefIndex: 54081
	{
		// Constructors
		public DamageTextDamageBase(); // 0x00000001839C21D0-0x00000001839C21E0
	
		// Methods
		public virtual void PlayAnimation(bool isLeft); // 0x000000018B10EE10-0x000000018B10EEC4
	}

	public class DamageTextIgniteBuff : DamageTextBase // TypeDefIndex: 54082
	{
		// Fields
		public UIImage bg; // 0xC0
		public UIText textDuplication; // 0xC8
		public UIStateController stateController; // 0xD0
	
		// Constructors
		public DamageTextIgniteBuff(); // 0x00000001839C21D0-0x00000001839C21E0
	
		// Methods
		protected override void OnAwake(); // 0x00000001844F4840-0x00000001844F48F0
		protected override void OnRelease(); // 0x000000018B10EEC4-0x000000018B10EF7C
		public void SetUIState(EnergyShardType energyShardType, bool isCrystBreak = false /* Metadata: 0x02343459 */); // 0x000000018B10F07C-0x000000018B10F1C0
		public void SetTextAndDuplication(string newText); // 0x000000018B10EF7C-0x000000018B10F07C
		public void __iFixBaseProxy_OnAwake(); // 0x000000018B10F1C0-0x000000018B10F1C8
		public void __iFixBaseProxy_OnRelease(); // 0x000000018B10F1C8-0x000000018B10F1D0
	}

	public class DamageTextLevelUp : DamageTextBase // TypeDefIndex: 54083
	{
		// Fields
		[CompilerGenerated]
		private ulong _targetCharInst_k__BackingField; // 0xC0
	
		// Properties
		public ulong targetCharInst { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000184D89340-0x0000000184D89350
	
		// Constructors
		public DamageTextLevelUp(); // 0x00000001839C21D0-0x00000001839C21E0
	}

	public class DamageTextNormalLevel1 : DamageTextDamageBase // TypeDefIndex: 54084
	{
		// Fields
		private const string ANIM_NAME_NORMAL_LEFT = "battletext_normal_left"; // Metadata: 0x0234345A
		private const string ANIM_NAME_NORMAL_RIGHT = "battletext_normal_right"; // Metadata: 0x02343471
	
		// Constructors
		public DamageTextNormalLevel1(); // 0x00000001839C21D0-0x00000001839C21E0
	
		// Methods
		public override void PlayAnimation(bool isLeft); // 0x000000018B10F1D0-0x000000018B10F2C4
		public void __iFixBaseProxy_PlayAnimation(bool P0); // 0x000000018B10985C-0x000000018B109864
	}

	public class FootBarDashCell : MonoBehaviour // TypeDefIndex: 54085
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
		private const int MAX_DASH_COUNT_IN_RING = 8; // Metadata: 0x02343489
		private const float FILL_AMOUNT_PER_CELL = 0.125f; // Metadata: 0x0234348A
		private const float ANGLE_PER_CELL = 45f; // Metadata: 0x0234348E
		private const float ANGLE_PER_HALF_CELL = 22.5f; // Metadata: 0x02343492
		private const float ANGLE_PER_QUARTER_CELL = 11.25f; // Metadata: 0x02343496
	
		// Constructors
		public FootBarDashCell(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void SetIndex(int index); // 0x000000018B10F4A0-0x000000018B10F564
		public void SetDashCount(float dashFillCount); // 0x000000018B10F2C4-0x000000018B10F4A0
		public void StartPlayNotEnoughAnim(); // 0x000000018B10F564-0x000000018B10F614
		public void StopPlayNotEnoughAnim(); // 0x000000018B10F614-0x000000018B10F6C4
	}

	public class HeadBarCtrl : UIPanelBase // TypeDefIndex: 54091
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
		private const float TICK_SURROUNDING_INTERVAL = 0.2f; // Metadata: 0x0234349D
		private const string HEAD_BAR_BROKEN_ANIM = "headbar_broken_in"; // Metadata: 0x023434A1
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
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000184658830-0x0000000184658860 
		private bool forceHide { get; } // 0x00000001838C9480-0x00000001838C9500 
	
		// Nested types
		public enum HeadBarType // TypeDefIndex: 54086
		{
			Mob = 0,
			Elite = 1,
			EnemyPart = 2,
			CNT = 3
		}
	
		private enum HeadBarRefreshReason // TypeDefIndex: 54087
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
		private sealed class __c__DisplayClass55_0 // TypeDefIndex: 54088
		{
			// Fields
			public ObjectPtr<AbilitySystem> abilitySystemPtr; // 0x10
			public UIHeadBarFollower bar; // 0x20
			public HeadBarCtrl __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass55_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __RefreshHeadBar_b__1(); // 0x00000001839C22A0-0x00000001839C2380
			internal void __RefreshHeadBar_b__2(); // 0x000000018B117E6C-0x000000018B117EF4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0 // TypeDefIndex: 54089
		{
			// Fields
			public ObjectPtr<AbilitySystem> abilitySystemPtr; // 0x10
			public UILvInfoBar bar; // 0x20
			public HeadBarCtrl __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass59_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __UpdateLevelInfoBar_b__0(); // 0x0000000184693550-0x00000001846935E0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0 // TypeDefIndex: 54090
		{
			// Fields
			public ObjectPtr<AbilitySystem> abilitySystemPtr; // 0x10
			public UITacticalItemBar bar; // 0x20
			public HeadBarCtrl __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass61_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __UpdateTacticalItemBar_b__0(); // 0x000000018B117EF4-0x000000018B117F7C
		}
	
		// Constructors
		public HeadBarCtrl(); // 0x0000000183ECC370-0x0000000183ECC920
		static HeadBarCtrl(); // 0x0000000183ECC920-0x0000000183ECCAB0
	
		// Methods
		public void OnCreate(Transform worldObjectRoot); // 0x0000000184249710-0x0000000184249C20
		public void OnClose(); // 0x000000018B10F6C4-0x000000018B1106EC
		public void OnShow(); // 0x0000000184514590-0x0000000184514BD0
		public void OnHide(); // 0x0000000184CD9700-0x0000000184CD9730
		public override void LateTick(float deltaTime); // 0x00000001838C8DF0-0x00000001838C8EA0
		private void _OnAddHeadBar([IsReadOnly] in EventData<AbilitySystem> eventData); // 0x0000000183F45C50-0x0000000183F45C90
		private void _OnRemoveHeadBar([IsReadOnly] in EventData<AbilitySystem, bool> eventData); // 0x0000000183F45C90-0x0000000183F45CD0
		private void _OnHeadBarShowConfigChanged(); // 0x0000000184D2BB30-0x0000000184D2BB70
		private void _OnHpChanged([IsReadOnly] in EventData<AbilitySystem.Modifier> eventData); // 0x0000000184242F60-0x0000000184244320
		private void _OnEnemyPartEnableChanged([IsReadOnly] in EventData<AbilitySystemForEnemyPart, bool> eventData); // 0x000000018B110B24-0x000000018B110C30
		private void _RefreshHeadBar(HeadBarRefreshReason reason); // 0x0000000183F45CD0-0x0000000183F47CB0
		private void _PrewarmHeadBar(); // 0x00000001839C2430-0x00000001839C2AB0
		private static HeadBarType _GetHeadBarType(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x000000018375CCB0-0x000000018375CDF0
		private void _UpdateHeadBar(float deltaTime); // 0x00000001838CB040-0x00000001838CC7E0
		private void _UpdateLevelInfoBar(float deltaTime); // 0x00000001838C9500-0x00000001838CA4F0
		private void _UpdateVigilanceBar(float deltaTime); // 0x00000001838CA4F0-0x00000001838CB040
		private void _UpdateTacticalItemBar(float deltaTime); // 0x0000000182F53D60-0x0000000182F54C60
		private void _OnBountyEnemyChanged(); // 0x000000018B1109E4-0x000000018B110A34
		private void _RefreshHeadBuff(); // 0x000000018B110CA4-0x000000018B111620
		private string _FindBountyBuffIcon(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x000000018B1106EC-0x000000018B1109E4
		private void _UpdateSurroundingEnemies(float deltaTime); // 0x00000001838C8EA0-0x00000001838C9480
		private T _CreateBar<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x0234349A */)
			where T : UIAbilityTargetFollower;
		private void _RecycleBar<T>(T bar)
			where T : UIAbilityTargetFollower;
		private List<T> _GetBarPool<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x0234349B */)
			where T : UIAbilityTargetFollower;
		private GameObject _GetBarPrefab<T>(HeadBarType headBarType = HeadBarType.Mob /* Metadata: 0x0234349C */)
			where T : UIAbilityTargetFollower;
		private void _OnInteractNpc([IsReadOnly] in EventData<string, Entity> eventData); // 0x000000018B110C30-0x000000018B110CA4
		private void _OnDialogStart([IsReadOnly] in EventData<bool, DialogEnums.DialogType> eventData); // 0x000000018B110AA8-0x000000018B110B24
		private void _OnDialogFinish([IsReadOnly] in EventData<bool> eventData); // 0x000000018B110A34-0x000000018B110AA8
		private void _SetInDialog(bool inDialog); // 0x000000018B111620-0x000000018B11167C
		[CompilerGenerated]
		internal static bool __RefreshHeadBar_g__ToShow_55_0(AbilitySystem abilitySystem); // 0x0000000183F47CB0-0x0000000183F47CF0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	[Serializable]
	public class HpChangeDisplayData // TypeDefIndex: 54092
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
		public HpChangeDisplayData(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class UIHeadBar : MonoBehaviour // TypeDefIndex: 54094
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
		private int _lvFontSize; // 0x44
		[SerializeField]
		private UIAnimationWrapper _barRootAnim; // 0x48
		[SerializeField]
		private UIStateController _lvNodeState; // 0x50
		[SerializeField]
		private UIText _lvText; // 0x58
		[SerializeField]
		private UIText _dangerousLvText; // 0x60
		[SerializeField]
		private UIText _extremeDangerousLvText; // 0x68
		[SerializeField]
		private UIAnimationWrapper _extremeDangerousLvAnim; // 0x70
		[SerializeField]
		private CanvasGroup _focusHighlight; // 0x78
		[SerializeField]
		private List<UIImage> _hpFastFillList; // 0x80
		[SerializeField]
		private List<UIImage> _hpSlowFillList; // 0x88
		[SerializeField]
		private Transform _hpNumberNode; // 0x90
		[SerializeField]
		private UIText _curHpText; // 0x98
		[SerializeField]
		private UIText _maxHpText; // 0xA0
		[SerializeField]
		private RectTransform _hpParentRect; // 0xA8
		[SerializeField]
		private RectTransform _hpEffectRect; // 0xB0
		[SerializeField]
		private CanvasGroup _hpEffectCanvasGroup; // 0xB8
		[SerializeField]
		private GameObject _hpBrokenNode; // 0xC0
		[SerializeField]
		private UIPoiseBar _poiseBar; // 0xC8
		[SerializeField]
		private UIWeaknessNode _weaknessBar; // 0xD0
		[SerializeField]
		private UIBuffNode _attachedBuffNode; // 0xD8
		[SerializeField]
		private UIBuffNode _normalBuffNode; // 0xE0
		private readonly LuaResourceLoader m_loader; // 0xE8
		private ObjectPtr<AbilitySystem> m_target; // 0xF0
		private bool m_hasPoise; // 0x100
		private HpChangeDisplayData m_currentHpChangeData; // 0x108
		private HpDisplayState m_hpDisplayState; // 0x110
		private readonly PeriodicTimer m_hpStayTimer; // 0x118
		private float? m_targetFillValue; // 0x120
		private float? m_transferToHighlightScaleTime; // 0x128
		private float? m_transferToOriginalScaleTime; // 0x130
		private Vector3 m_beforeTransferScale; // 0x138
		public const float EFFECT_OFFSET = -0.5f; // Metadata: 0x023434C0
	
		// Nested types
		public enum HpDisplayState // TypeDefIndex: 54093
		{
			Normal = 0,
			Stay = 1,
			Decrease = 2
		}
	
		// Constructors
		public UIHeadBar(); // 0x00000001839C49E0-0x00000001839C4AD0
	
		// Methods
		private void OnDestroy(); // 0x000000018B118034-0x000000018B118090
		public void OnPreWarm(); // 0x00000001839C32A0-0x00000001839C3300
		public void SetTarget(AbilitySystem target); // 0x0000000183A9EE50-0x0000000183A9F970
		public void ShowModifierAfterSetTarget([IsReadOnly] in AbilitySystem.Modifier modifier); // 0x0000000183B4FDD0-0x0000000183B4FEF0
		public void Clear(); // 0x0000000183A9FD20-0x0000000183AA0130
		public void Refresh(); // 0x0000000183AA2250-0x0000000183AA22D0
		private void _OnHpChange(Entity entity, double change, bool isMaxHpChanged); // 0x0000000183B50FD0-0x0000000183B51DC0
		private void _OnForceSetHp(Entity entity); // 0x000000018B118090-0x000000018B118258
		private void _CalculateHpChangeDisplay(AbilitySystem target, double deltaValue); // 0x0000000183B52130-0x0000000183B52DA0
		private void _UpdateHpDisplay(float deltaTime); // 0x00000001835F85D0-0x00000001835F8D80
		private void _OnPoiseChange(Entity entity, float change, bool hideUIEffect); // 0x0000000184A1D4E0-0x0000000184A1D560
		private void _OnMultiTimeWeaknessActivate(Entity entity, bool active, int count); // 0x000000018B118258-0x000000018B1183CC
		private void _OnWeaknessCountChanged(Entity entity, int total, int count); // 0x000000018B1183CC-0x000000018B118498
		private void _OnMainTargetChanged([IsReadOnly] in EventData<AbilitySystem, bool> eventData); // 0x000000018464D8F0-0x000000018464DA50
		private void _UpdateScale(float deltaTime); // 0x00000001835F7D60-0x00000001835F85D0
		private void _SetImageFill(List<UIImage> imageList, float fillValue); // 0x00000001835F7C40-0x00000001835F7D60
		public void UpdateData(float deltaTime); // 0x00000001835F9450-0x00000001835F94E0
		public void OnBeforeHpBroken(); // 0x00000001849CDC60-0x00000001849CDCB0
		public void OnAfterHpBroken(); // 0x00000001839C2250-0x00000001839C22A0
	}

	public class UIHeadBarFollower : UIAbilityTargetFollower // TypeDefIndex: 54095
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
		protected override bool actualVisible { get; } // 0x0000000183EC1440-0x0000000183EC1480 
	
		// Constructors
		public UIHeadBarFollower(); // 0x00000001839C2B10-0x00000001839C2B20
	
		// Methods
		public void OnPreWarm(); // 0x00000001839C2AB0-0x00000001839C2B00
		public override void SetTarget(AbilitySystem target); // 0x00000001833D24E0-0x00000001833D2550
		public void ShowModifierAfterSetTarget([IsReadOnly] in AbilitySystem.Modifier modifier); // 0x0000000183B4FD80-0x0000000183B4FDD0
		public override void Clear(); // 0x0000000183A9F9B0-0x0000000183A9FA10
		public void Refresh(); // 0x000000018B117F7C-0x000000018B11800C
		public void SetHeadBarVisible(bool visible); // 0x00000001844C80D0-0x00000001844C8140
		protected override void UpdateData(float deltaTime); // 0x00000001835F93F0-0x00000001835F9450
		private void _UpdateGuideLine(); // 0x00000001844E5DD0-0x00000001844E68A0
		public override bool TryGetOriginalFollowPos(out Vector3 followPos); // 0x00000001833D4DC0-0x00000001833D4E90
		public void OnBeforeHpBroken(); // 0x00000001849CDC10-0x00000001849CDC60
		public void OnAfterHpBroken(); // 0x00000001839C2200-0x00000001839C2250
		public bool __iFixBaseProxy_get_actualVisible(); // 0x000000018B11802C-0x000000018B118034
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0); // 0x000000018B118014-0x000000018B11801C
		public void __iFixBaseProxy_Clear(); // 0x000000018B11800C-0x000000018B118014
		public void __iFixBaseProxy_UpdateData(float P0); // 0x000000018B118024-0x000000018B11802C
		public bool __iFixBaseProxy_TryGetOriginalFollowPos(out Vector3 P0); // 0x000000018B11801C-0x000000018B118024
	}

	public class UIHeadBuff : UIAbilityTargetFollower // TypeDefIndex: 54096
	{
		// Fields
		[SerializeField]
		private UIStateController _stateController; // 0x110
	
		// Constructors
		public UIHeadBuff(); // 0x00000001839C1E70-0x00000001839C1E80
	
		// Methods
		public void SetBuffIcon(string iconName); // 0x000000018B118498-0x000000018B118514
		public override bool TryGetOriginalFollowPos(out Vector3 followPos); // 0x000000018B118514-0x000000018B118620
		public bool __iFixBaseProxy_TryGetOriginalFollowPos(out Vector3 P0); // 0x000000018B11801C-0x000000018B118024
	}

	public class UIHeadLabel : TickableUIMono // TypeDefIndex: 54102
	{
		// Fields
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
		protected override TickType tickOption { get; } // 0x0000000184281220-0x0000000184281250 
		public Transform iconHolder { get; } // 0x000000018B118A30-0x000000018B118AD0 
		public Beyond.Gameplay.Core.ObjectType targetType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D863C0-0x0000000184D863D0 0x0000000184D86440-0x0000000184D86450
		public ulong entityLogicId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86260-0x0000000184D86270 0x0000000184D862E0-0x0000000184D862F0
		public string headLabelIcon { get; set; } // 0x0000000184790910-0x0000000184790940 0x00000001836D21F0-0x00000001836D2240
		public string missionHeadLabelIcon { get; set; } // 0x00000001847908E0-0x0000000184790910 0x00000001836D21A0-0x00000001836D21F0
	
		// Nested types
		public enum HeadLabelType // TypeDefIndex: 54097
		{
			Root = 0,
			Bubble = 1,
			Text = 2,
			Icon = 3,
			Count = 4
		}
	
		public enum VisibleSource // TypeDefIndex: 54098
		{
			Comp = 0,
			System = 1,
			FloatingUI = 2,
			Count = 3
		}
	
		[Serializable]
		public class HeadLabelRootData // TypeDefIndex: 54099
		{
			// Fields
			public Transform root; // 0x10
			public HeadLabelType headLabelType; // 0x18
	
			// Constructors
			public HeadLabelRootData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class HeadLabelRootVisibleData // TypeDefIndex: 54100
		{
			// Fields
			public Vector3 originalPosition; // 0x10
			public Dictionary<VisibleSource, bool> visibleSource; // 0x20
	
			// Properties
			public bool realVisible { get; } // 0x00000001836D0280-0x00000001836D0430 
	
			// Constructors
			public HeadLabelRootVisibleData(); // 0x00000001836CF830-0x00000001836CF940
	
			// Methods
			public void Init(Vector3 position); // 0x00000001836CF7F0-0x00000001836CF830
			public void UpdateVisible(VisibleSource source, bool visible); // 0x00000001836CFDA0-0x00000001836CFE00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0 // TypeDefIndex: 54101
		{
			// Fields
			public HeadLabelType headLabelType; // 0x10
			public UIHeadLabel __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass49_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __UpdateFloatingUIVisibleCallback_b__0(bool visible); // 0x00000001836CFCB0-0x00000001836CFCF0
		}
	
		// Constructors
		public UIHeadLabel(); // 0x00000001839C3300-0x00000001839C3430
	
		// Methods
		private void _OnSubRootsCollectionChanged(); // 0x000000018B1188A8-0x000000018B118A30
		private void _TryInitRootData(); // 0x00000001836CE7B0-0x00000001836CF7F0
		public void SetVisibleDirty(); // 0x00000001836D0D10-0x00000001836D0D40
		private void _UpdateVisible(); // 0x00000001836CFE00-0x00000001836D0280
		public void SetSubRootVisible(HeadLabelType type, VisibleSource source, bool visible, bool updateNow); // 0x00000001836CFCF0-0x00000001836CFDA0
		public void SetTarget(Entity target); // 0x00000001836CF980-0x00000001836CFBF0
		private void _TryUpdateVisibleCallback(); // 0x00000001836D0ED0-0x00000001836D0F90
		private void _ClearVisibleCallback(); // 0x00000001845BAAE0-0x00000001845BABA0
		public void Clear(); // 0x00000001836D2240-0x00000001836D2360
		public void SetActive(bool active); // 0x000000018B118684-0x000000018B118764
		public void ClearEmojis(); // 0x00000001836D0D40-0x00000001836D0DF0
		private void _UpdateFloatingUIVisibleCallback(); // 0x0000000183962710-0x0000000183962D70
		private void _ClearFloatingUIVisibleCallback(); // 0x0000000183961DB0-0x00000001839620B0
		private void _OnMissionTypeIconChanged([IsReadOnly] in EventData<string> data); // 0x000000018B118764-0x000000018B1188A8
		private void _BindMissionTracking(); // 0x00000001836D26B0-0x00000001836D27C0
		private void _UnBindMissionTracking(); // 0x00000001836D23C0-0x00000001836D24D0
		private void _BindTargetEvent(); // 0x00000001836D2590-0x00000001836D2650
		private void _UnBindTargetEvent(); // 0x00000001836D24D0-0x00000001836D2590
		private void _OnNpcVisibleChanged([IsReadOnly] in EventData<string> eventData); // 0x0000000183C1AE50-0x0000000183C1AFF0
		private void _UpdatePos(); // 0x0000000182F451B0-0x0000000182F45660
		private void _RefreshVisible(bool bubbleRoot, bool textNode, bool iconHolderNode); // 0x00000001836CFBF0-0x00000001836CFCB0
		private void _TryUpdateVisible(); // 0x0000000182F44E30-0x0000000182F450F0
		protected override void OnAwake(); // 0x00000001836CE6B0-0x00000001836CE6F0
		public override void LateTick(float deltaTime); // 0x0000000182F450F0-0x0000000182F451B0
		protected override void OnEnable(); // 0x00000001836D2650-0x00000001836D26B0
		protected override void OnDisable(); // 0x00000001836D2360-0x00000001836D23C0
		protected override void OnRelease(); // 0x000000018B118620-0x000000018B118684
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	public class UILvInfoBar : UIAbilityTargetFollower // TypeDefIndex: 54103
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
		public UILvInfoBar(); // 0x00000001839C1E70-0x00000001839C1E80
	
		// Methods
		public override void SetTarget(AbilitySystem target); // 0x0000000183CEA140-0x0000000183CEA2B0
		public override bool TryGetOriginalFollowPos(out Vector3 followPos); // 0x00000001833D4E90-0x00000001833D4F60
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0); // 0x000000018B118014-0x000000018B11801C
		public bool __iFixBaseProxy_TryGetOriginalFollowPos(out Vector3 P0); // 0x000000018B11801C-0x000000018B118024
	}

	public class UIPoiseBar : MonoBehaviour // TypeDefIndex: 54105
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
		public const float EFFECT_OFFSET = -0.5f; // Metadata: 0x023434D0
	
		// Properties
		public AbilitySystem owner { get; } // 0x00000001835F9590-0x00000001835F95D0 
		public float maxPoise { get; } // 0x0000000183CEFD70-0x0000000183CEFDC0 
		public float realPoise { get; } // 0x0000000183CEED80-0x0000000183CEEDD0 
		private bool hidePoiseBar { get; } // 0x0000000183CEEDD0-0x0000000183CEFD70 
	
		// Nested types
		public enum PoiseDisplayState // TypeDefIndex: 54104
		{
			Normal = 0,
			Stay = 1,
			Increase = 2
		}
	
		// Constructors
		public UIPoiseBar(); // 0x0000000184563E40-0x0000000184563F60
	
		// Methods
		public void Init(AbilitySystem owner, bool hidePoiseBarWhenEmpty, bool showPoiseChangeEffect, List<HpChangeDisplayData> poiseChangeConfig); // 0x0000000183CECEB0-0x0000000183CED1D0
		public void Clear(); // 0x0000000183A9FC70-0x0000000183A9FD20
		public void OnPoiseChange(Entity entity, float change, bool hideUIEffect); // 0x0000000183CED1D0-0x0000000183CEED80
		public void Refresh(); // 0x0000000183AA2370-0x0000000183AA23C0
		public void UpdatePoiseBar(float deltaTime); // 0x00000001835F94E0-0x00000001835F9590
		private void _CalculatePoiseChangeDisplay(double deltaValue); // 0x0000000183CEFDC0-0x0000000183CF12C0
		private void _UpdatePoiseDisplay(float deltaTime); // 0x00000001835F8D80-0x00000001835F93F0
		private void _TryInitPoiseKnot(AbilitySystem owner); // 0x0000000183B1AB70-0x0000000183B1AF90
		private void _ClearPoiseKnot(); // 0x0000000183A9FAC0-0x0000000183A9FC70
		private UIPoiseKnot _CreatePoiseKnot(); // 0x000000018B118AD0-0x000000018B118C88
	}

	public class UITacticalItemBar : UIAbilityTargetFollower // TypeDefIndex: 54106
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
		private const string UI_SPRITE_ITEM = "ItemIcon"; // Metadata: 0x023434D7
		private string m_itemId; // 0x130
	
		// Constructors
		public UITacticalItemBar(); // 0x00000001839C1E80-0x00000001839C1EA0
	
		// Methods
		public override void SetTarget(AbilitySystem target); // 0x000000018B118DF8-0x000000018B119004
		public override void Clear(); // 0x000000018B118C88-0x000000018B118D10
		protected override void UpdateData(float deltaTime); // 0x000000018B119004-0x000000018B1190BC
		public bool IsTacticalItemActive(); // 0x000000018B118D10-0x000000018B118DF8
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0); // 0x000000018B118014-0x000000018B11801C
		public void __iFixBaseProxy_Clear(); // 0x000000018B11800C-0x000000018B118014
		public void __iFixBaseProxy_UpdateData(float P0); // 0x000000018B118024-0x000000018B11802C
	}

	public class UIVigilanceBar : UIAbilityTargetFollower // TypeDefIndex: 54107
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
		protected override bool actualVisible { get; } // 0x0000000183EC1480-0x0000000183EC1520 
		protected override bool needUpdateTransform { get; } // 0x0000000183FC21F0-0x0000000183FC2230 
	
		// Constructors
		public UIVigilanceBar(); // 0x00000001839C1E70-0x00000001839C1E80
	
		// Methods
		public override void SetTarget(AbilitySystem target); // 0x00000001833D2550-0x00000001833D26C0
		public override void Clear(); // 0x0000000183A9F970-0x0000000183A9F9B0
		public void Refresh(); // 0x000000018B1190BC-0x000000018B1191E8
		protected override void UpdateData(float deltaTime); // 0x00000001837FCE70-0x00000001837FCEB0
		private void _UpdateVigilanceNode(); // 0x00000001837FD200-0x00000001837FD510
		private void _SetVigilanceActive(bool active); // 0x000000018464C940-0x000000018464C9C0
		public override bool TryGetOriginalFollowPos(out Vector3 followPos); // 0x00000001833D4F60-0x00000001833D5030
		[CompilerGenerated]
		private void __UpdateVigilanceNode_b__15_0(); // 0x0000000184D84A80-0x0000000184D84A90
		[CompilerGenerated]
		private void __UpdateVigilanceNode_b__15_1(); // 0x0000000184D84EF0-0x0000000184D84F00
		public bool __iFixBaseProxy_get_actualVisible(); // 0x000000018B11802C-0x000000018B118034
		public bool __iFixBaseProxy_get_needUpdateTransform(); // 0x000000018B1191E8-0x000000018B1191F0
		public void __iFixBaseProxy_SetTarget(AbilitySystem P0); // 0x000000018B118014-0x000000018B11801C
		public void __iFixBaseProxy_Clear(); // 0x000000018B11800C-0x000000018B118014
		public void __iFixBaseProxy_UpdateData(float P0); // 0x000000018B118024-0x000000018B11802C
		public bool __iFixBaseProxy_TryGetOriginalFollowPos(out Vector3 P0); // 0x000000018B11801C-0x000000018B118024
	}

	public class UIWeaknessNode : MonoBehaviour // TypeDefIndex: 54108
	{
		// Fields
		public CanvasGroup weaknessCell; // 0x18
		private readonly List<CanvasGroup> m_weaknessCells; // 0x20
	
		// Constructors
		public UIWeaknessNode(); // 0x00000001846D9FD0-0x00000001846DA060
	
		// Methods
		private void Awake(); // 0x000000018B1191F0-0x000000018B119290
		public void SetTotalCellNum(int num); // 0x000000018B11935C-0x000000018B1195FC
		public void SetCurrentCellNum(int num); // 0x000000018B119290-0x000000018B11935C
	}

	public class AtbCell : MonoBehaviour // TypeDefIndex: 54109
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
		public AtbCell(); // 0x0000000183695570-0x0000000183695590
	}

	public class AtbNode : UIPanelBase // TypeDefIndex: 54111
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
		private const float ATB_PRESS_THRESHOLD = 0.03f; // Metadata: 0x023434E0
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000184A79A80-0x0000000184A79AB0 
		private BattleManager battleManager { get; } // 0x0000000182F587A0-0x0000000182F58830 
		private SkillSetting skillSetting { get; } // 0x0000000183CD5D60-0x0000000183CD5DD0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 54110
		{
			// Fields
			public AtbCell cell; // 0x10
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _OnGainAtb_b__0(); // 0x000000018B117E50-0x000000018B117E6C
		}
	
		// Constructors
		public AtbNode(); // 0x0000000184CB67A0-0x0000000184CB6830
	
		// Methods
		public void OnCreate(); // 0x0000000183CD4D40-0x0000000183CD5350
		public void OnClose(); // 0x000000018B114B8C-0x000000018B114D10
		public override void LateTick(float deltaTime); // 0x0000000182F57CD0-0x0000000182F587A0
		public void CheckAtbLoopAnim(); // 0x0000000183CD3A50-0x0000000183CD4CA0
		private void _RefreshAtbShowing(); // 0x0000000183CD5690-0x0000000183CD5D60
		private void _OnAtbCellOutAnimCallback(); // 0x0000000184D33140-0x0000000184D33190
		public void OnInFightChanged([IsReadOnly] in EventData<bool> eventData); // 0x0000000183CD5520-0x0000000183CD5560
		public void OnGainAtb([IsReadOnly] in EventData<float> eventData); // 0x000000018B114D10-0x000000018B1151A4
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class ComboSkillHint : MonoBehaviour // TypeDefIndex: 54112
	{
		// Fields
		public const string SPECIAL_NODE_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Battle/Widgets/ComboSkillSpecialNode/"; // Metadata: 0x023434E4
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
		public ComboSkillHint(); // 0x0000000184A27CC0-0x0000000184A27DE0
	
		// Methods
		public void Init(ComboSkillPanel owner, int charIndex, bool isDefaultPanel); // 0x0000000183C42990-0x0000000183C42B10
		public void OnReady(); // 0x000000018B115210-0x000000018B115278
		public void OnCast(); // 0x000000018B1151A4-0x000000018B115210
		public void OnTick(float deltaTime); // 0x000000018B1152E4-0x000000018B115350
		public void OnRemove(); // 0x000000018B115278-0x000000018B1152E4
		public void Release(); // 0x000000018B115350-0x000000018B1153BC
		public void AssignData(AbilitySystem abilityCom); // 0x0000000183C42800-0x0000000183C42990
		public void SetVisible(bool visible); // 0x000000018B1153BC-0x000000018B115418
	}

	public class ComboSkillPanel : UIPanelBase // TypeDefIndex: 54116
	{
		// Fields
		public const string UI_SPRITE_ROUND_CHAR_HEAD = "CharRoundIcon"; // Metadata: 0x0234353B
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
		protected override TickType tickOption { get; } // 0x0000000184A79A50-0x0000000184A79A80 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0 // TypeDefIndex: 54113
		{
			// Fields
			public ComboSkillHint hint; // 0x10
			public ComboSkillPanel __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass22_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __RemoveComboSkill_b__0(); // 0x000000018B117DC8-0x000000018B117DFC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0 // TypeDefIndex: 54114
		{
			// Fields
			public ComboSkillHint hint; // 0x10
	
			// Constructors
			public __c__DisplayClass23_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __OnComboSkillClearAll_b__0(); // 0x000000018B117DFC-0x000000018B117E1C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0 // TypeDefIndex: 54115
		{
			// Fields
			public ComboSkillPanel __4__this; // 0x10
			public ComboSkillHint hint; // 0x18
	
			// Constructors
			public __c__DisplayClass24_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _CastComboSkill_b__0(); // 0x000000018B117E1C-0x000000018B117E50
		}
	
		// Constructors
		public ComboSkillPanel(); // 0x0000000184CAB300-0x0000000184CAB3A0
	
		// Methods
		public void OnCreate(bool isDefaultPanel, bool isControllerPanel); // 0x0000000183C421B0-0x0000000183C425E0
		public void OnShow(); // 0x0000000183C425E0-0x0000000183C42620
		protected override void OnRelease(); // 0x000000018B115778-0x000000018B115828
		private void _UnbindListeners(); // 0x0000000183C42CD0-0x0000000183C43060
		public override void PreTick(float deltaTime); // 0x000000018B115828-0x000000018B115A04
		private void _CheckUpdate(); // 0x0000000183409BF0-0x0000000183409D20
		private void _OnBattleTeamChanged(); // 0x0000000183C426C0-0x0000000183C42800
		private void _OnActiveSkillDataRefreshed([IsReadOnly] in EventData<ulong, string> eventData); // 0x000000018B115A84-0x000000018B115C00
		private void _OnComboSkillReady([IsReadOnly] in EventData<int> eventData); // 0x000000018B115C00-0x000000018B115DB4
		private void _OnComboSkillRemove([IsReadOnly] in EventData<int> eventData); // 0x000000018B115DB4-0x000000018B115E18
		private void _RemoveComboSkill(int charIndex); // 0x000000018B115E18-0x000000018B115FDC
		private void _OnComboSkillClearAll(); // 0x0000000183409E30-0x000000018340A180
		public void CastComboSkill(PointerEventData eventData = null); // 0x000000018B115418-0x000000018B115778
		private void _ResortSiblingIndex(); // 0x0000000183C42620-0x0000000183C426C0
		[CompilerGenerated]
		private void _OnCreate_b__12_0(); // 0x000000018B115A04-0x000000018B115A7C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_OnRelease(); // 0x000000018B115A7C-0x000000018B115A84
		public void __iFixBaseProxy_PreTick(float P0); // 0x0000000186FF4E4C-0x0000000186FF4E54
	}

	public class GPUIAttachedBuffCell : GPUIBuffCell // TypeDefIndex: 54117
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
		private const string BUFF_ANIM_IGNITE = "headbar_buff_cell_ignite"; // Metadata: 0x02343549
		private int m_maxStackCount; // 0xF4
		private float m_currentStackRingFillAmount; // 0xF8
		private float? m_targetStackRingFillAmount; // 0xFC
		private PeriodicTimer m_igniteFillDelayTimer; // 0x108
		private bool m_isInConsumeAnim; // 0x110
		private float m_consumeAnimEndTime; // 0x114
	
		// Properties
		protected override string defaultBuffIconNodeName { get; } // 0x000000018B1168A4-0x000000018B116910 
	
		// Constructors
		public GPUIAttachedBuffCell(); // 0x000000018419E480-0x000000018419E610
	
		// Methods
		protected override void DataInit(ObjectPtr<Buff> buffPtr); // 0x000000018B11603C-0x000000018B116144
		public override void OnTick(float deltaTime); // 0x000000018B116204-0x000000018B1163E8
		public override void BeforePlayOutAnim(); // 0x000000018B115FDC-0x000000018B11603C
		public override void SetStackCount(int stackCount, bool playAnim); // 0x000000018B1163E8-0x000000018B1165D4
		public override void OnBuffIgnite(); // 0x000000018B116144-0x000000018B116204
		protected override bool SetBuffIcon(Sprite sprite); // 0x0000000182E99490-0x0000000182E998B0
		protected override void ClearBuffIconOverride(); // 0x0000000182E990B0-0x0000000182E99490
		protected override void SetStackElementActive(bool showStackCount); // 0x000000018B1165D4-0x000000018B116668
		private void _PlayConsumeAnimations(int stackCount); // 0x000000018B1166B8-0x000000018B1168A4
		public string __iFixBaseProxy_get_defaultBuffIconNodeName(); // 0x000000018B1166B0-0x000000018B1166B8
		public void __iFixBaseProxy_DataInit(ObjectPtr<Buff> P0); // 0x000000018B116670-0x000000018B116690
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018B116698-0x000000018B1166A0
		public void __iFixBaseProxy_BeforePlayOutAnim(); // 0x000000018B116668-0x000000018B116670
		public void __iFixBaseProxy_SetStackCount(int P0, bool P1); // 0x000000018B1166A0-0x000000018B1166A8
		public void __iFixBaseProxy_OnBuffIgnite(); // 0x000000018B116690-0x000000018B116698
		public bool __iFixBaseProxy_SetBuffIcon(Sprite P0); // 0x0000000182E998C0-0x0000000182E998D0
		public void __iFixBaseProxy_ClearBuffIconOverride(); // 0x0000000182E998B0-0x0000000182E998C0
		public void __iFixBaseProxy_SetStackElementActive(bool P0); // 0x000000018B1166A8-0x000000018B1166B0
	}

	public class GPUIBuffCell : MonoBehaviour // TypeDefIndex: 54119
	{
		// Fields
		private const string BUFF_ICON_SET_FAILED_MESSAGE = "BuffIcon\u8BBE\u7F6E\u56FE\u6807\u5931\u8D25\uFF0C\u9700\u8981\u8054\u7CFB\u7A0B\u5E8F\u6269\u5145\u9884\u7559\u5927\u5C0F"; // Metadata: 0x02343563
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
		protected virtual string defaultBuffIconNodeName { get; } // 0x000000018464CFC0-0x000000018464CFF0 
		public bool isVisualInited { get; } // 0x0000000183AA2DD0-0x0000000183AA2E00 
		protected bool canUpdateVisual { get; } // 0x0000000182F45840-0x0000000182F458D0 
		public ulong nextInstanceId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86250-0x0000000184D86260 0x0000000184D92630-0x0000000184D92640
		public string curSpritePath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85EF0-0x0000000184D85F00 0x0000000186AC5AF4-0x0000000186AC5B08
		public BuffData buffData { get; } // 0x0000000182F49770-0x0000000182F497C0 
		public int orderPriority { get; } // 0x0000000182F49650-0x0000000182F496A0 
		public ulong buffInstanceUid { get; } // 0x0000000184505A30-0x0000000184505A80 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass45_0 // TypeDefIndex: 54118
		{
			// Fields
			public ulong cachedLoadKey; // 0x10
			public GPUIBuffCell __4__this; // 0x18
			public string inputSpritePath; // 0x20
			public Action onSpriteLoaded; // 0x28
	
			// Constructors
			public __c__DisplayClass45_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Init_b__0(Sprite sprite); // 0x0000000182E9BA30-0x0000000182E9BB60
		}
	
		// Constructors
		public GPUIBuffCell(); // 0x000000018419E690-0x000000018419E830
	
		// Methods
		public void SetSyncManager(GPUIProxySyncManager syncManager); // 0x0000000183AA5CD0-0x0000000183AA5D30
		public void Init(ObjectPtr<Buff> buffPtr, LuaResourceLoader loader, Action onSpriteLoaded = null); // 0x00000001831D7EF0-0x00000001831D8130
		public void Clear(); // 0x0000000183AA6090-0x0000000183AA6110
		public virtual void BeforePlayOutAnim(); // 0x000000018B116910-0x000000018B116954
		public virtual void OnTick(float deltaTime); // 0x0000000182F45A80-0x0000000182F45B80
		public virtual void SetVisible(bool visible); // 0x0000000182F47F60-0x0000000182F47FC0
		public virtual void SetBuffIconOverrideActive(bool active); // 0x0000000182E9A080-0x0000000182E9A7D0
		public virtual void SetStackCount(int stackCount, bool playAnim); // 0x00000001838487D0-0x0000000183848850
		public virtual void OnBuffIgnite(); // 0x000000018B116954-0x000000018B116998
		public void ClearAnimation(bool executeOnComplete = false /* Metadata: 0x02343562 */); // 0x0000000183AA6160-0x0000000183AA61C0
		public void PlayInAnimation(Action callback = null); // 0x0000000183AA28A0-0x0000000183AA28F0
		public void PlayOutAnimation(Action callback = null); // 0x0000000184D1A430-0x0000000184D1A480
		public void PlayStrongInAnimation(Action callback = null); // 0x000000018B116A00-0x000000018B116A68
		public void PlayIgniteOutAnimation(Action callback = null); // 0x000000018B116998-0x000000018B116A00
		public void SampleToInAnimationEnd(); // 0x0000000183AA4360-0x0000000183AA43A0
		public void PlayWithAnimation(string animationName, Action callback = null); // 0x0000000183AA23C0-0x0000000183AA2490
		protected virtual void DataInit(ObjectPtr<Buff> buffPtr); // 0x00000001846DD4B0-0x00000001846DD4E0
		protected virtual void VisualInit(Sprite sprite); // 0x0000000184234550-0x00000001842355A0
		protected virtual bool SetBuffIcon(Sprite sprite); // 0x0000000182E9A7D0-0x0000000182E9AFB0
		protected virtual void ClearBuffIconOverride(); // 0x0000000182E998D0-0x0000000182E9A080
		private void _LogSetBuffIconFailure(Sprite sprite); // 0x0000000182E9AFB0-0x0000000182E9B370
		protected virtual void SetStackElementActive(bool isActive); // 0x0000000184558630-0x0000000184558680
		protected virtual void SetWarningState(bool isWarning); // 0x000000018363C0D0-0x000000018363C120
		protected bool TrySetSprite(string nodeName, Sprite sprite); // 0x000000018357AB70-0x000000018357AC10
		protected bool TrySetText(string nodeName, string text); // 0x0000000183848960-0x0000000183848A00
		protected bool TrySetColor(string nodeName, UnityEngine.Color color); // 0x000000018363C120-0x000000018363C1D0
		protected bool TrySetNodeRotZ(string subRoot, float rotz); // 0x000000018B116A68-0x000000018B116B48
		[IDTag(0)]
		protected bool TrySetNodeVisibility(string nodeName, bool visible); // 0x0000000182F480C0-0x0000000182F48160
		[IDTag(1)]
		protected void TrySetNodeVisibility(List<string> nodeNames, bool visible); // 0x0000000182F48040-0x0000000182F480C0
		protected bool TrySetImageFillAmount(string nodeName, float fillAmount); // 0x00000001833C12A0-0x00000001833C14C0
		protected bool TryStartRootAnimation(string animationName, out float duration); // 0x0000000183AA2490-0x0000000183AA2560
		protected bool TryStartSubrootAnimation(string subrootName, string animationName, out float duration); // 0x000000018B116B48-0x000000018B116C54
		protected bool TryEnsureGPUIInstance(); // 0x0000000182F45D40-0x0000000182F46080
		private bool _TryCreateGPUIInstance(); // 0x00000001842355F0-0x0000000184235660
		private bool _TryDestroyGpuiInstance(); // 0x0000000183AA6110-0x0000000183AA6160
		private bool _TryResolveGpui(out GPUIExtendedSystem targetSystem, out GPUIHandle handle); // 0x0000000182F46490-0x0000000182F46D50
		private bool _TryResolveGPUIProxy(); // 0x0000000182F45C80-0x0000000182F45D40
		private bool _TrySetRootScale(Vector2 scale); // 0x0000000182F47FC0-0x0000000182F48040
		private void _UpdateAnimationComplete(); // 0x0000000182F45B80-0x0000000182F45C30
		private string _ResolveNodeName(string configuredNodeName, string defaultNodeName); // 0x0000000184558150-0x00000001845581B0
	}

	public class GPUIBuffNode : TickableUIMono // TypeDefIndex: 54128
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
		protected override TickType tickOption { get; } // 0x00000001845C5FF0-0x00000001845C6020 
	
		// Nested types
		public enum BuffNodeType // TypeDefIndex: 54120
		{
			HeadBarCommon = 0,
			HeadBarAttached = 1,
			SquadIconCommon = 2,
			MainCharHpBarCommon = 3
		}
	
		public class BuffCellGroup // TypeDefIndex: 54121
		{
			// Fields
			public BuffIconConfig.BuffIconStyle buffIconStyle; // 0x10
			public GPUIBuffCell buffCellTemplate; // 0x18
			public List<GPUIBuffCell> buffCellPool; // 0x20
			public DynamicFastLookupCollection<ulong, GPUIBuffCell> buffCellDict; // 0x28
			public DynamicFastLookupCollection<ulong, GPUIBuffCell> buffCellWithOutAnim; // 0x30
	
			// Constructors
			public BuffCellGroup(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public GPUIBuffCell CreateBuffCell(Transform transform, GPUIProxySyncManager syncManager); // 0x0000000183AA4690-0x0000000183AA4740
			public void RemoveBuffCell(GPUIBuffCell buffCell); // 0x0000000183AA2BB0-0x0000000183AA2C30
			public void ClearAllBuffCells(); // 0x0000000183AA2AD0-0x0000000183AA2BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 54122
		{
			// Fields
			public GPUIBuffNode __4__this; // 0x10
			public GPUIBuffCell buffCell; // 0x18
			public BuffData buffData; // 0x20
			public bool playAnim; // 0x28
			public int enhanceCnt; // 0x2C
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __AddBuffIconInternal_b__0(); // 0x0000000183AA3290-0x0000000183AA3300
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0 // TypeDefIndex: 54123
		{
			// Fields
			public GPUIBuffNode __4__this; // 0x10
			public BuffData buffData; // 0x18
			public List<ObjectPtr<Buff>> stackBuffList; // 0x20
			public bool playAnim; // 0x28
	
			// Constructors
			public __c__DisplayClass28_0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_1 // TypeDefIndex: 54124
		{
			// Fields
			public GPUIBuffCell newBuffCell; // 0x10
			public __c__DisplayClass28_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass28_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __AddStackBuffIconInternal_b__0(); // 0x000000018B11E4F4-0x000000018B11E59C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_2 // TypeDefIndex: 54125
		{
			// Fields
			public GPUIBuffCell buffCell; // 0x10
			public __c__DisplayClass28_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass28_2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __AddStackBuffIconInternal_b__1(); // 0x000000018B11E59C-0x000000018B11E640
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0 // TypeDefIndex: 54126
		{
			// Fields
			public List<ObjectPtr<Buff>> stackBuffList; // 0x10
			public ObjectPtr<Buff> buffPtr; // 0x18
	
			// Constructors
			public __c__DisplayClass30_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __RemoveStackBuffIconInternal_b__0(); // 0x000000018B11E640-0x000000018B11E690
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0 // TypeDefIndex: 54127
		{
			// Fields
			public Action extraRecycleAction; // 0x10
			public BuffCellGroup buffCellGroup; // 0x18
			public ulong buffUid; // 0x20
			public GPUIBuffCell buffCell; // 0x28
			public GPUIBuffNode __4__this; // 0x30
	
			// Constructors
			public __c__DisplayClass31_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __RemoveSingleBuffCell_b__0(); // 0x0000000184A1C240-0x0000000184A1C300
			internal void __RemoveSingleBuffCell_b__1(); // 0x000000018B11E690-0x000000018B11E748
		}
	
		// Constructors
		public GPUIBuffNode(); // 0x0000000184664C90-0x0000000184664E60
	
		// Methods
		private void _OnFirstInit(); // 0x0000000183A9CF00-0x0000000183A9D630
		public void OnPreWarm(GPUIProxySyncManager syncManager); // 0x0000000183AA5040-0x0000000183AA5CD0
		public void Init(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x0000000183A9B7D0-0x0000000183A9B8C0
		public void Refresh(); // 0x0000000182F4A050-0x0000000182F4B160
		public void Clear(); // 0x0000000183AA28F0-0x0000000183AA2AD0
		public override void TailLateTick(float deltaTime); // 0x0000000183308790-0x0000000183308EC0
		protected override void OnRelease(); // 0x000000018B116C54-0x000000018B116D1C
		public void OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x0000000183AA2E00-0x0000000183AA2E90
		private bool _IsBuffIconInThisNode(ObjectPtr<Buff> buffPtr); // 0x0000000183AA2E90-0x0000000183AA2F60
		private void _OnAddBuff(ObjectPtr<Buff> buffPtr); // 0x0000000183AA2F60-0x0000000183AA2FD0
		private void _OnRemoveBuff(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason); // 0x0000000183AA2FD0-0x0000000183AA3060
		private void _AddBuffIconInternal(ObjectPtr<Buff> buffPtr, bool playAnim); // 0x0000000183AA43F0-0x0000000183AA4690
		private void _AddStackBuffIconInternal(ObjectPtr<Buff> buffPtr, bool playAnim, BuffData buffData, BuffCellGroup buffCellGroup); // 0x000000018B116D1C-0x000000018B1176A8
		private void _RemoveBuffIconInternal(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason); // 0x0000000183AA3060-0x0000000183AA31E0
		private void _RemoveStackBuffIconInternal(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason, BuffData buffData, BuffCellGroup buffCellGroup); // 0x000000018B117964-0x000000018B117DC8
		private void _RemoveSingleBuffCell(ulong buffUid, GPUIBuffCell buffCell, Buff.FinishReason finishReason, BuffCellGroup buffCellGroup, Action extraRecycleAction); // 0x0000000183AA2C30-0x0000000183AA2DD0
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr); // 0x000000018B1176A8-0x000000018B11781C
		private void _OnBuffIgnite(ObjectPtr<Buff> buffPtr); // 0x000000018B11781C-0x000000018B117964
		private void _RegisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x0000000183A9BA20-0x0000000183A9BBF0
		private void _UnregisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x0000000183A9B8C0-0x0000000183A9BA20
		private BuffIconConfig.BuffIconStyle _GetIconStyle(Buff buff); // 0x0000000183AA4770-0x0000000183AA4F50
		private void _SetBuffCellSiblingInOrder(GPUIBuffCell buffCell); // 0x0000000182F49410-0x0000000182F49620
		private void _DealWithBuffCellVisible(); // 0x0000000182F482A0-0x0000000182F49410
		private void _PlayInAnimation(GPUIBuffCell buffCell, BuffData buffData, bool playAnim); // 0x0000000183AA3300-0x0000000183AA4360
		private bool _IsBuffCellVisibleByLimit(GPUIBuffCell buffCell); // 0x0000000182E9B370-0x0000000182E9BA30
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000186C37238-0x0000000186C37240
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	public class GPUILifeTimeBuffCell : GPUIBuffCell // TypeDefIndex: 54129
	{
		// Fields
		[SerializeField]
		private string _buffLifeTimeBarNodeName; // 0xC0
		[SerializeField]
		private UnityEngine.Color _normalLifeTimeBarColor; // 0xC8
		[SerializeField]
		private UnityEngine.Color _warningLifeTimeBarColor; // 0xD8
	
		// Constructors
		public GPUILifeTimeBuffCell(); // 0x000000018419E610-0x000000018419E690
	
		// Methods
		protected override void VisualInit(Sprite sprite); // 0x0000000184234500-0x0000000184234550
		public override void OnTick(float deltaTime); // 0x0000000182F458D0-0x0000000182F45A80
		protected override void SetWarningState(bool isWarning); // 0x000000018363C060-0x000000018363C0D0
		private void _UpdateFillAmount(); // 0x00000001833C0B80-0x00000001833C1040
		public void __iFixBaseProxy_VisualInit(Sprite P0); // 0x000000018B119604-0x000000018B11960C
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018B116698-0x000000018B1166A0
		public void __iFixBaseProxy_SetWarningState(bool P0); // 0x000000018B1195FC-0x000000018B119604
	}

	public class HpBarComboNode : MonoBehaviour // TypeDefIndex: 54130
	{
		// Fields
		public GameObject comboCountLayout; // 0x18
		public UIText comboCountText; // 0x20
		private UIAnimationWrapper m_animationWrapper; // 0x28
		private int m_lastCount; // 0x30
		private const string COMMON_COMBO_GLOBAL_BUFF_ID = "global_buff_combo_trigger"; // Metadata: 0x023435AB
	
		// Constructors
		public HpBarComboNode(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x0000000184248B60-0x0000000184248D30
		private void OnDestroy(); // 0x000000018B11960C-0x000000018B119790
		private void _OnGlobalBuffStart([IsReadOnly] in EventData<GlobalBuff, string> eventData); // 0x000000018B1198F4-0x000000018B11998C
		private void _OnGlobalBuffFinish([IsReadOnly] in EventData<GlobalBuff, string, GlobalBuff.FinishReason> eventData); // 0x000000018B119858-0x000000018B1198F4
		private void _RefreshComboCount(bool isEarly = false /* Metadata: 0x023435AA */); // 0x00000001842485D0-0x00000001842486D0
		private void _AnimInCallback(); // 0x000000018B119790-0x000000018B1197F4
		private void _AnimOutCallback(); // 0x000000018B1197F4-0x000000018B119858
	}

	public class MainCharHpBar : TickableUIMono // TypeDefIndex: 54132
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
		private const string HP_BLINK_ANIM = "characterfootbar_warninginternal"; // Metadata: 0x023435C5
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
		protected override TickType tickOption { get; } // 0x0000000184A79900-0x0000000184A79930 
	
		// Nested types
		[Serializable]
		public struct HpScreenEffectConfig // TypeDefIndex: 54131
		{
			// Fields
			public float minHpPercent; // 0x00
			public float maxHpPercent; // 0x04
			public string effectName; // 0x08
		}
	
		// Constructors
		public MainCharHpBar(); // 0x0000000183ECBF00-0x0000000183ECC150
		static MainCharHpBar(); // 0x0000000184CA3FC0-0x0000000184CA40B0
	
		// Methods
		protected override void OnAwake(); // 0x00000001844F48F0-0x00000001844F4C70
		public void SetGPUIBuffSync(GPUIProxySyncManager gpuiProxySyncManager); // 0x0000000184D613A0-0x0000000184D613F0
		public void SetGPUIBuffMode(bool enabled); // 0x0000000184B382A0-0x0000000184B38400
		protected override void OnEnable(); // 0x0000000183CCEC90-0x0000000183CCED70
		protected override void OnRelease(); // 0x000000018B11998C-0x000000018B119E94
		public void OnShow(); // 0x0000000184850E80-0x0000000184850F60
		public void OnHide(); // 0x00000001849856C0-0x0000000184985720
		private void _ClearMainChar(); // 0x0000000183E252E0-0x0000000183E256F0
		public override void LateTick(float deltaTime); // 0x0000000183CCEE30-0x0000000183CCEF30
		private bool _CheckHpBarShowing(); // 0x0000000183CCEF30-0x0000000183CCEFA0
		private void _SetHpBarShowing(bool showing, bool animate); // 0x0000000183CCF0C0-0x0000000183CCF290
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data); // 0x000000018B11A470-0x000000018B11A4D4
		private void _ProcessOnMainCharChange(Entity newMainChar); // 0x0000000183E26F10-0x0000000183E27E90
		private void _OnTeamChanged(); // 0x0000000183E27E90-0x0000000183E28CB0
		private void _OnHpChange(Entity entity, double change, bool isMaxHpChanged); // 0x0000000183639BF0-0x0000000183639F50
		private void _SetHpFillAmount(float hpPct); // 0x00000001836399D0-0x0000000183639B30
		private void _CalculateHpChangeDisplay(AbilitySystem target, double deltaValue); // 0x0000000183638570-0x00000001836399D0
		private void _UpdateHpDisplay(float deltaTime); // 0x0000000183CCF290-0x0000000183CD0500
		private void _OnTakeDamage(Entity entity, bool hideMainCharHpScreenEffect); // 0x000000018B11A4D4-0x000000018B11A8CC
		private void _OnMainCharHpActiveChange(); // 0x0000000183CD0500-0x0000000183CD0590
		private void _EnsureBuffNodePreWarmed(); // 0x0000000183E26C20-0x0000000183E26E40
		private void _InitCurrentBuffNode(AbilitySystem abilitySystem); // 0x0000000183E26B70-0x0000000183E26C20
		[IDTag(1)]
		private void _ClearBuffNode(); // 0x0000000183E256F0-0x0000000183E25730
		[IDTag(0)]
		private void _ClearBuffNode(bool useGPUIBuff); // 0x0000000183E25730-0x0000000183E25780
		private bool _IsCharHpBarVfxBuffValid(ObjectPtr<Buff> buffPtr); // 0x000000018B11A17C-0x000000018B11A23C
		private void _RebuildCharHpBarVfxBuffCache(); // 0x0000000184426DB0-0x0000000184427400
		private ObjectPtr<Buff> _GetLatestValidCharHpBarVfxBuffPtrFromCache(); // 0x0000000183E26E70-0x0000000183E26F10
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x0000000183E26A50-0x0000000183E26B70
		private void _RefreshBuffChangeCharHpBarVfx(); // 0x0000000183E258B0-0x0000000183E25B30
		private void _HpVfxOutAnimCallback(); // 0x0000000184D32C20-0x0000000184D32C80
		private void _OnCharPassiveNumChanged(float newNum); // 0x0000000184A30790-0x0000000184A30870
		private UICharPassiveBase _GetOrCreateCharPassiveBase(string prefabName); // 0x0000000183E28E90-0x0000000183E29240
		private void _OnProgressBarBuffChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x0000000183E26730-0x0000000183E26830
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr); // 0x000000018B11A34C-0x000000018B11A470
		private void _BlinkBuffIcon(string spritePath); // 0x000000018B11A08C-0x000000018B11A17C
		private void _SetUltimateBuff(ObjectPtr<Buff> buffPtr); // 0x0000000183E26270-0x0000000183E264A0
		private void _UltimateBuffProgressOutAnimCallback(); // 0x000000018B11AA98-0x000000018B11AAF8
		private void _RebuildUltimateBuffTracking(); // 0x0000000183A9BBF0-0x0000000183A9CF00
		private bool _IsUltimateBuffValid(ObjectPtr<Buff> buffPtr); // 0x000000018B11A23C-0x000000018B11A34C
		private ObjectPtr<Buff> _GetUltimateBuffForAbility(AbilitySystem ability); // 0x0000000183E26080-0x0000000183E26270
		private void _SelectUltimateBuff(); // 0x0000000183E25E00-0x0000000183E26080
		private void _RefreshUltimateBuffProgress(float deltaTime); // 0x000000018B11A8CC-0x000000018B11AA54
		private void _SetUltimateProgressFill(float realFillAmount, float totalDuration); // 0x000000018B11AA54-0x000000018B11AA98
		[CompilerGenerated]
		private void __SetHpBarShowing_b__76_0(); // 0x000000018B11A05C-0x000000018B11A08C
		[CompilerGenerated]
		private void __BlinkBuffIcon_b__100_0(Sprite sprite); // 0x000000018B119E94-0x000000018B119F94
		[CompilerGenerated]
		private void __BlinkBuffIcon_b__100_1(); // 0x000000018B119F94-0x000000018B11A028
		[CompilerGenerated]
		private void __BlinkBuffIcon_b__100_2(); // 0x000000018B11A028-0x000000018B11A05C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class OutOfScreenTargetArrow : MonoBehaviour // TypeDefIndex: 54133
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
		public OutOfScreenTargetArrow(); // 0x0000000185393520-0x0000000185393538
	}

	public class OutOfScreenTargetsCtrl : UIPanelBase // TypeDefIndex: 54135
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
		protected override TickType tickOption { get; } // 0x0000000184A797B0-0x0000000184A797E0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 54134
		{
			// Fields
			public OutOfScreenTargetArrow arrow; // 0x10
			public OutOfScreenTargetsCtrl __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __InitArrowCallbacks_b__0(); // 0x000000018B11E398-0x000000018B11E440
			internal void __InitArrowCallbacks_b__1(); // 0x000000018B11E440-0x000000018B11E4B8
			internal void __InitArrowCallbacks_b__2(); // 0x000000018B11E4B8-0x000000018B11E4F4
		}
	
		// Constructors
		public OutOfScreenTargetsCtrl(); // 0x00000001849E4BC0-0x00000001849E4CE0
		static OutOfScreenTargetsCtrl(); // 0x0000000183ECB9E0-0x0000000183ECBB20
	
		// Methods
		public void OnCreate(); // 0x000000018B11B458-0x000000018B11B58C
		public void OnClose(); // 0x000000018B11B354-0x000000018B11B458
		public void OnShow(); // 0x000000018B11B58C-0x000000018B11B6D4
		public void DebugChangeImpl(bool disableThis); // 0x000000018B11B0CC-0x000000018B11B354
		public override void LateTick(float deltaTime); // 0x0000000183F2A240-0x0000000183F2AFD0
		private OutOfScreenTargetArrow _CreateOneArrow(); // 0x000000018B11B6D4-0x000000018B11B8EC
		private void _InitArrowCallbacks(OutOfScreenTargetArrow arrow); // 0x000000018B11B8EC-0x000000018B11BA94
		private ValueTuple<Vector2, float> _ScreenPosToUIPos(Vector3 screenPos); // 0x000000018B11BC08-0x000000018B11BD60
		private void _OnEnemyCastSkillToMainChar([IsReadOnly] in EventData<AbilitySystem> eventData); // 0x000000018B11BA94-0x000000018B11BC08
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class OutOfScreenTargetsCtrlV2 : UIPanelBase // TypeDefIndex: 54137
	{
		// Fields
		private const string ROOT_ANIMATION_IN = "outofscreentargets_in"; // Metadata: 0x023435E6
		private const string ROOT_ANIMATION_OUT = "outofscreentargets_out"; // Metadata: 0x023435FC
		private const string ROOT_ANIMATION_LOOP = "outofscreentargets_loop"; // Metadata: 0x02343613
		private const string SKILL_SUBROOT = "DecoOff-screen"; // Metadata: 0x0234362B
		private const string SKILL_ANIMATION_IN = "DecoOff-screen_in"; // Metadata: 0x0234363A
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
		protected override TickType tickOption { get; } // 0x0000000184A797E0-0x0000000184A79810 
	
		// Nested types
		private sealed class ArrowRuntimeState // TypeDefIndex: 54136
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
			public ArrowRuntimeState(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public OutOfScreenTargetsCtrlV2(); // 0x0000000184B0B740-0x0000000184B0B830
		static OutOfScreenTargetsCtrlV2(); // 0x0000000183ECBB20-0x0000000183ECBC60
	
		// Methods
		public void OnCreate(); // 0x0000000184249D20-0x0000000184249F50
		public void OnClose(); // 0x000000018B11AB60-0x000000018B11AC6C
		public void OnShow(); // 0x0000000184B513F0-0x0000000184B51420
		public void OnHide(); // 0x0000000184CA2E00-0x0000000184CA2E30
		public void DebugChangeImpl(bool disableThis); // 0x000000018B11AAF8-0x000000018B11AB60
		public override void LateTick(float deltaTime); // 0x00000001838CC850-0x00000001838CE6C0
		private bool _CreateArrowState(out ArrowRuntimeState state); // 0x0000000183AB6A40-0x0000000183AB6C30
		private void _RestartVisibleState(ArrowRuntimeState state); // 0x0000000183AB6930-0x0000000183AB6A40
		private void _ScheduleDestroy(ArrowRuntimeState state); // 0x0000000183AB6C30-0x0000000183AB6D50
		private void _UpdateRuntimeStates(); // 0x00000001838CE6C0-0x00000001838CEDF0
		private void _RecycleAll(); // 0x000000018B11AEA0-0x000000018B11B0CC
		private ValueTuple<Vector2, float> _ScreenPosToUIPos(Vector3 screenPos); // 0x00000001842EA300-0x00000001842EA3F0
		private void _OnEnemyCastSkillToMainChar([IsReadOnly] in EventData<AbilitySystem> eventData); // 0x000000018B11AC6C-0x000000018B11AEA0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class SkillButton : UIPanelBase // TypeDefIndex: 54143
	{
		// Fields
		public const string UI_SPRITE_SKILL_ICON = "SkillIcon"; // Metadata: 0x0234364D
		private const float HIGHLIGHT_CHECK_INTERVAL = 0.1f; // Metadata: 0x02343657
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
		public UnityEngine.Color normalCountdownFillWeakColor; // 0x170
		public RectTransform normalCountdownFillTrail; // 0x180
		public UIAnimationWrapper contentAnimWrapper; // 0x188
		public UIButton ultimateButton; // 0x190
		public UIImage ultimateIcon; // 0x198
		public UIImage ultimateIconShadow; // 0x1A0
		public UIImage ultimateColorBg; // 0x1A8
		public UIImage uspRing; // 0x1B0
		public UIImage uspRingSmall; // 0x1B8
		public UIImage centerImage; // 0x1C0
		public UIImage glow01; // 0x1C8
		public UIImage outRing; // 0x1D0
		public CanvasGroup ultimateCanvasGroup; // 0x1D8
		public UIImage pressFill; // 0x1E0
		public UIAnimationWrapper ultimateButtonAnim; // 0x1E8
		public UIImage ultKeyIcon; // 0x1F0
		public Transform ultKeyHint; // 0x1F8
		public float uspFillSpeed; // 0x200
		public UIImage ultimateFillCompleteImage; // 0x208
		public GameObject ultimateBar; // 0x210
		public UIImage ultimateBarFill; // 0x218
		public float ultimateBarFillMin; // 0x220
		public float ultimateBarFillMax; // 0x224
		public UIImage ultimateCdFill; // 0x228
		public UIImage ultimateBarFillFrame; // 0x230
		public GameObject ultimateCountdownNode; // 0x238
		public UIImage ultimateCountdownFill; // 0x240
		public UIImage ultimateCountdownFillBg; // 0x248
		public UIImage ultimateCountdownBarFill; // 0x250
		public UIImage touchPressUspRing; // 0x258
		public RectTransform touchPressIndicator; // 0x260
		private int m_charIndex; // 0x268
		private Beyond.DeviceInfo.InputType m_panelType; // 0x26C
		private Beyond.Gameplay.CharInfo m_charInfo; // 0x270
		private Beyond.Gameplay.Core.SkillData m_ultimateSkillData; // 0x278
		private Beyond.Gameplay.Core.SkillData m_normalSkillData; // 0x280
		private ObjectPtr<AbilitySystem> m_charAbilityPtr; // 0x288
		private Skill m_normalSkill; // 0x298
		private Skill m_ultimateSkill; // 0x2A0
		private bool m_isEmpty; // 0x2A8
		private float m_ultimatePressingTime; // 0x2AC
		private bool m_isDeadState; // 0x2B0
		private bool m_normalSkillReady; // 0x2B1
		private float m_lastHighlightCheckTime; // 0x2B4
		private float m_uspTargetFill; // 0x2B8
		private bool m_ultimateReady; // 0x2BC
		private UnityEngine.Color m_normalIconShadowDefaultColor; // 0x2C0
		private bool m_showNotRecommendState; // 0x2D0
		private PressHandler m_pressHandler; // 0x2D8
		private bool m_hasNotRecommendIcon; // 0x2E0
		private UIAnimationWrapper m_ultimateBarAnim; // 0x2E8
		private UIAnimationWrapper m_ultimateCountdownAnim; // 0x2F0
		private HudFadeType m_hudFadeType; // 0x2F8
		private string m_actionId; // 0x300
		private string m_curNormalIconName; // 0x308
		private string m_curUltimateIconName; // 0x310
		private ObjectPtr<Buff> m_normalProgressBuffPtr; // 0x318
		private float m_normalProgressOutDuration; // 0x328
		private TweenCallback m_normalProgressOutCallback; // 0x330
		private TweenCallback m_ultCountDownOutCallback; // 0x338
		private UnityEngine.Color m_normalCountdownFillDefaultColor; // 0x340
		private bool m_isNormalCountdownFillWeakStyle; // 0x350
		private ObjectPtr<Buff> m_ultimateProgressBuffPtr; // 0x358
		private static Action<int> s_onPressSkillButtonStart; // 0x00
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000184422970-0x00000001844229A0 
		private SkillSetting skillSetting { get; } // 0x000000018B11E304-0x000000018B11E398 
	
		// Nested types
		private enum PressingMode // TypeDefIndex: 54138
		{
			None = 0,
			Normal = 1,
			Ultimate = 2
		}
	
		private abstract class PressHandler // TypeDefIndex: 54139
		{
			// Fields
			protected SkillButton m_owner; // 0x10
	
			// Properties
			protected SkillSetting skillSetting { get; } // 0x0000000183671B90-0x0000000183671C00 
			public virtual bool needUpdate { get; } // 0x000000018B11CF50-0x000000018B11CF9C 
	
			// Constructors
			public PressHandler(SkillButton owner); // 0x00000001853908C0-0x00000001853908D0
	
			// Methods
			public abstract void OnPressStart();
			public abstract void OnUpdate(float deltaTime);
			public abstract void OnPressEnd();
			public abstract void OnPressCancel();
			public virtual void OnOtherPressSkillButtonStart(); // 0x000000018B11CEC8-0x000000018B11CF0C
			public virtual void OnUltimateSkillChanged(); // 0x000000018B11CF0C-0x000000018B11CF50
		}
	
		private class PressHandlerLongPress : PressHandler // TypeDefIndex: 54140
		{
			// Fields
			private PressingMode m_pressingMode; // 0x18
			private float m_pressingSkillTime; // 0x1C
	
			// Properties
			public override bool needUpdate { get; } // 0x0000000183EE22D0-0x0000000183EE2460 
	
			// Constructors
			public PressHandlerLongPress(SkillButton owner); // 0x00000001853908C0-0x00000001853908D0
	
			// Methods
			public override void OnPressStart(); // 0x0000000183C250F0-0x0000000183C25280
			public override void OnUpdate(float deltaTime); // 0x0000000183671A00-0x0000000183671B90
			public override void OnPressEnd(); // 0x0000000183671810-0x0000000183671A00
			public override void OnPressCancel(); // 0x000000018384A880-0x000000018384A900
			public override void OnOtherPressSkillButtonStart(); // 0x0000000184A79750-0x0000000184A79780
			public override void OnUltimateSkillChanged(); // 0x000000018B11CE64-0x000000018B11CEC0
			public bool __iFixBaseProxy_get_needUpdate(); // 0x000000018B11C6DC-0x000000018B11C6E4
			public void __iFixBaseProxy_OnOtherPressSkillButtonStart(); // 0x000000018B11CEC0-0x000000018B11CEC8
			public void __iFixBaseProxy_OnUltimateSkillChanged(); // 0x000000018B11C6D4-0x000000018B11C6DC
		}
	
		private class PressHandlerIndividualUltimate : PressHandler // TypeDefIndex: 54141
		{
			// Fields
			private PressingMode m_pressingMode; // 0x18
			private float m_pressingSkillTime; // 0x1C
	
			// Properties
			public override bool needUpdate { get; } // 0x000000018B11CE14-0x000000018B11CE64 
	
			// Constructors
			public PressHandlerIndividualUltimate(SkillButton owner); // 0x00000001853908C0-0x00000001853908D0
	
			// Methods
			public override void OnPressStart(); // 0x000000018B11CC74-0x000000018B11CD54
			public override void OnUpdate(float deltaTime); // 0x000000018B11CD54-0x000000018B11CE14
			public override void OnPressEnd(); // 0x000000018B11CB7C-0x000000018B11CC74
			public override void OnPressCancel(); // 0x000000018B11CAC8-0x000000018B11CB7C
			public bool __iFixBaseProxy_get_needUpdate(); // 0x000000018B11C6DC-0x000000018B11C6E4
		}
	
		private class PressHandlerDrag : PressHandler // TypeDefIndex: 54142
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
			public override bool needUpdate { get; } // 0x000000018B11CA78-0x000000018B11CAC8 
	
			// Constructors
			public PressHandlerDrag(SkillButton owner); // 0x000000018B11C77C-0x000000018B11CA78
	
			// Methods
			public override void OnPressStart(); // 0x000000018B11C06C-0x000000018B11C2B8
			public override void OnUpdate(float deltaTime); // 0x000000018B11C314-0x000000018B11C6D4
			private bool _InCancelArea(); // 0x000000018B11C6E4-0x000000018B11C77C
			public override void OnPressEnd(); // 0x000000018B11BE28-0x000000018B11C06C
			public override void OnPressCancel(); // 0x000000018B11BD60-0x000000018B11BE28
			public override void OnUltimateSkillChanged(); // 0x000000018B11C2B8-0x000000018B11C314
			public bool __iFixBaseProxy_get_needUpdate(); // 0x000000018B11C6DC-0x000000018B11C6E4
			public void __iFixBaseProxy_OnUltimateSkillChanged(); // 0x000000018B11C6D4-0x000000018B11C6DC
		}
	
		// Constructors
		public SkillButton(); // 0x00000001847C3910-0x00000001847C39D0
	
		// Methods
		protected override void OnAwake(); // 0x0000000183D2ADC0-0x0000000183D2AFA0
		protected override void OnEnable(); // 0x00000001845F6FD0-0x00000001845F7050
		public void Close(); // 0x000000018B11CF9C-0x000000018B11D7D0
		public void FirstTimeInit(int charIndex, bool isDefaultPanel, bool isControllerPanel); // 0x0000000183C43890-0x0000000183C47FB0
		public void RefreshSkillButton(); // 0x000000018384B8B0-0x000000018384E5D0
		private bool _TryGetAliveAbilitySystem(out AbilitySystem abilitySys); // 0x000000018B11E298-0x000000018B11E304
		private bool _MustUpdate(); // 0x000000018B11DA40-0x000000018B11DB04
		public override void PreTick(float deltaTime); // 0x0000000183C81880-0x0000000183C81FA0
		private void _InitSkillData(); // 0x0000000183C5DBC0-0x0000000183C5E640
		private void _UpdateMainUI(float deltaTime); // 0x00000001830452D0-0x0000000183046300
		private void _RefreshNormalSkillCd(); // 0x0000000182E9C0A0-0x0000000182E9D050
		private void _RefreshUltimateSkillCd(bool costAvailable); // 0x0000000182E9D050-0x0000000182E9D930
		private void _CheckNormalSkillHighlight(); // 0x000000018384AD10-0x000000018384AE70
		private void _SetNotRecommendState(bool active); // 0x000000018B11E090-0x000000018B11E11C
		public void OnCharacterDie(); // 0x000000018B11D7D0-0x000000018B11D82C
		private void _RefreshDeadState(bool anim); // 0x000000018384B760-0x000000018384B800
		private void _SetUspFillAmount(float fillAmount); // 0x000000018B11E18C-0x000000018B11E298
		private void _SetPressFillActive(bool active); // 0x000000018384AB50-0x000000018384AC40
		private void _SetPressFillAmount(float fillAmount); // 0x0000000183671520-0x0000000183671600
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x0000000183E26670-0x0000000183E26730
		private void _SetNormalCountdownFillVisible(bool visible); // 0x000000018B11DE44-0x000000018B11E090
		private void _ResetNormalCountdownFillStyle(); // 0x000000018B11DDDC-0x000000018B11DE44
		private void _SetUltimateCountdownFillVisible(bool visible, bool playOutAnim = true /* Metadata: 0x0234364C */); // 0x000000018B11E11C-0x000000018B11E18C
		private void _RefreshNormalProgressBuff(); // 0x0000000183046ED0-0x0000000183047500
		private void _RefreshUltimateProgressBuff(); // 0x00000001830469C0-0x0000000183046ED0
		public void OnUspChange(Entity entity = null); // 0x0000000183D40940-0x0000000183D414D0
		private bool _CanCastSkill(Skill skill); // 0x000000018B11D9E4-0x000000018B11DA00
		public void CastSkill(Skill skill); // 0x0000000183671C00-0x0000000183671E50
		public void OnPressSkillStart(PointerEventData eventData = null); // 0x0000000184701980-0x0000000184701A40
		private void _OnOtherPressSkillButtonStart(int charIndex); // 0x00000001848E30A0-0x00000001848E3100
		public void OnPressSkillEnd(PointerEventData eventData = null); // 0x00000001847CED80-0x00000001847CEE20
		public void OnPressCancelled(); // 0x00000001836D0AF0-0x00000001836D0B60
		private void _CastUltimateSkill(); // 0x000000018B11DA00-0x000000018B11DA40
		public void OnPressUltimateSkillStart(PointerEventData eventData); // 0x000000018B11D82C-0x000000018B11D930
		public void ToggleControllerSkillIndicator(bool active); // 0x000000018B11D930-0x000000018B11D9E4
		private void _OnCharPotentialUnlock([IsReadOnly] in EventData<ulong, uint> eventData); // 0x000000018B11DB88-0x000000018B11DC04
		private void _OnCharSkillChange([IsReadOnly] in EventData<ulong, string> eventData); // 0x0000000184B39B70-0x0000000184B39BE0
		private void _OnCharUltimateSkillChange([IsReadOnly] in EventData<ulong, string> eventData); // 0x000000018B11DC04-0x000000018B11DC98
		private void _OnSkillUpgradeSuccess([IsReadOnly] in EventData<ulong, string, int> eventData); // 0x000000018B11DD60-0x000000018B11DDDC
		private void _OnActiveSkillDataRefreshed([IsReadOnly] in EventData<ulong, string> eventData); // 0x000000018B11DB04-0x000000018B11DB88
		private void _OnSkillCdChanged([IsReadOnly] in EventData<Skill> eventData); // 0x0000000182E9BC80-0x0000000182E9C0A0
		private void _OnSkillButtonActiveConfigChanged(); // 0x000000018384AC40-0x000000018384AD10
		private void _OnInputActionKeyUpdated([IsReadOnly] in EventData<string> eventData); // 0x000000018B11DC98-0x000000018B11DD10
		private void _OnKeyboardTypeChanged(); // 0x000000018B11DD10-0x000000018B11DD60
		private void _UpdateLongPressKeyHint(); // 0x0000000183C43060-0x0000000183C431B0
		private void _SetGoActive(bool active); // 0x0000000183849B30-0x0000000183849CA0
		public void SetEmpty(bool isEmpty); // 0x0000000183069EE0-0x0000000183069F70
		public void ClearBtnClick(); // 0x00000001836D0A50-0x00000001836D0AF0
		[CompilerGenerated]
		private void _OnAwake_b__98_0(); // 0x0000000182E9BB60-0x0000000182E9BBC0
		[CompilerGenerated]
		private void _OnAwake_b__98_1(); // 0x0000000182E9BBC0-0x0000000182E9BC80
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
	}

	public class SquadIcon : UIPanelBase // TypeDefIndex: 54144
	{
		// Fields
		private const string UI_CHAR_HEAD_PREFIX = "icon_"; // Metadata: 0x02343661
		private const string UI_SPRITE_DIR_CHAR_HEAD = "CharBattleIcon"; // Metadata: 0x02343667
		private const string UI_SPRITE_DIR_ITEM = "ItemIcon"; // Metadata: 0x02343676
		private const float HP_CHANGE_TOLERANCE = 0.0001f; // Metadata: 0x0234367F
		public const string CHAR_PASSIVE_UI_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Battle/Widgets/CharPassiveUI/"; // Metadata: 0x02343683
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
		public GPUIBuffNode gpuiBuffNode; // 0x180
		public CanvasGroup tacticalCanvasGroup; // 0x188
		public GameObject tacticalCdNode; // 0x190
		public GameObject tacticalCastBar; // 0x198
		public GameObject tacticalDotNode; // 0x1A0
		public GameObject tacticalProhibitNode; // 0x1A8
		public GameObject tacticalEmptyNode; // 0x1B0
		public UIImage tacticalIcon; // 0x1B8
		public UIImage tacticalCastFill; // 0x1C0
		public float tacticalDeadAlpha; // 0x1C8
		public float tacticalItemUsedUpAlpha; // 0x1CC
		public GameObject fixedIcon; // 0x1D0
		public GameObject trailIcon; // 0x1D8
		public GameObject indieTrailIcon; // 0x1E0
		public CanvasGroup igniteBuffTextNode; // 0x1E8
		public Animation igniteBuffTextAnim; // 0x1F0
		public UIText igniteBuffText; // 0x1F8
		public UnityEngine.Color igniteBuffColorPulse; // 0x200
		public UnityEngine.Color igniteBuffColorCryst; // 0x210
		public UnityEngine.Color igniteBuffColorNatural; // 0x220
		public UnityEngine.Color igniteBuffColorFire; // 0x230
		public Transform charPassiveNode; // 0x240
		[CompilerGenerated]
		private bool _isEmpty_k__BackingField; // 0x248
		private Beyond.DeviceInfo.InputType m_panelType; // 0x24C
		private bool m_isMainCharacter; // 0x250
		private bool m_teamSwitchUnlocked; // 0x251
		private int m_charIndex; // 0x254
		private string m_charIndexStr; // 0x258
		private Beyond.Gameplay.CharInfo m_charInfo; // 0x260
		private ObjectPtr<AbilitySystem> m_charAbilityPtr; // 0x268
		private List<TacticalDotCell> m_tacticalDots; // 0x278
		private float m_tacticalCastFillMax; // 0x280
		private int m_lastLevel; // 0x284
		private bool m_indicatorShowing; // 0x288
		private bool m_lastComboCdReady; // 0x289
		private bool m_comboReadyAnimShowing; // 0x28A
		private bool m_comboIconShowing; // 0x28B
		private UIHudFadeController m_hudFadeController; // 0x290
		private UIAnimationWrapper m_hpVfxAnimWrapper; // 0x298
		private string m_lastCharPassiveName; // 0x2A0
		private UICharPassiveBase m_charPassiveBase; // 0x2A8
		private DG.Tweening.Sequence m_keyHintFadeSequence; // 0x2B0
		private bool m_inDeadState; // 0x2B8
		private UIAnimationWrapper m_tacticalSwitchAnim; // 0x2C0
		private bool? m_tacticalInProgress; // 0x2C8
		private int m_tacticalItemLastDisplayCount; // 0x2CC
		private float m_comboCdNodeHeight; // 0x2D0
		private readonly List<ObjectPtr<Buff>> m_activeCharHpBarVfxBuffs; // 0x2D8
		private ObjectPtr<Buff> m_charHpBarVfxBuffPtr; // 0x2E0
		private GPUIProxySyncManager m_gpuiProxySyncManager; // 0x2F0
		private bool m_gpuiBuffNodePreWarmed; // 0x2F8
		private bool m_normalBuffNodePreWarmed; // 0x2F9
		private bool m_buffModeInitialized; // 0x2FA
		private bool m_useGPUIBuff; // 0x2FB
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000184422940-0x0000000184422970 
		public bool isEmpty { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D90930-0x0000000184D90940 0x0000000184D90960-0x0000000184D90970
	
		// Constructors
		public SquadIcon(); // 0x0000000183ECC150-0x0000000183ECC280
	
		// Methods
		protected override void OnAwake(); // 0x000000018396C800-0x000000018396C910
		public void SetGPUIBuffSync(GPUIProxySyncManager gpuiProxySyncManager); // 0x0000000184CADDE0-0x0000000184CADE30
		public void SetGPUIBuffMode(bool enableGPUIBuff); // 0x000000018306A950-0x000000018306AB00
		public void FirstTimeInit(int index, bool isDefaultPanel, bool isControllerPanel); // 0x0000000183C43230-0x0000000183C43790
		public void Close(); // 0x000000018B11EE10-0x000000018B11F364
		public void InitSquadIcon(bool showFixed = false /* Metadata: 0x0234365E */, bool showTrail = false /* Metadata: 0x0234365F */); // 0x0000000183849CA0-0x000000018384A880
		private bool _MustUpdate(); // 0x0000000182F550E0-0x0000000182F55510
		public override void LateTick(float deltaTime); // 0x0000000182F53890-0x0000000182F53C40
		private bool _TryGetAliveAbilitySystem(out AbilitySystem abilitySys); // 0x000000018B11FCCC-0x000000018B11FD38
		private void _UpdateComboSkillIcon(bool showAnim = true /* Metadata: 0x02343660 */); // 0x0000000183C5F7C0-0x0000000183C5FB10
		public void SetEmpty(bool empty); // 0x0000000183069F70-0x000000018306A000
		public void ToggleIndicator(bool isShow); // 0x000000018B11F748-0x000000018B11F7A4
		public void InformKeyHint(); // 0x000000018B11F364-0x000000018B11F514
		private void _OnHpChange(Entity entity, double change, bool isMaxHpChanged); // 0x0000000183847E70-0x00000001838481A0
		private void _SetLevelText(); // 0x0000000183848600-0x00000001838487D0
		private void _OnIgniteBuffText([IsReadOnly] in EventData<ulong, string, EnergyShardType> eventData); // 0x000000018B11F984-0x000000018B11FB34
		public void OnLevelChange(); // 0x000000018B11F514-0x000000018B11F570
		private void _TryShowLevelUpAnim(); // 0x0000000184665560-0x0000000184665600
		public void SetDeadState(bool dead); // 0x0000000183544320-0x0000000183544530
		private void _EnsureBuffNodePreWarmed(); // 0x0000000183848450-0x0000000183848600
		private void _InitCurrentBuffNode(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x0000000183848D10-0x0000000183848D80
		private void _ClearBuffNode(); // 0x000000018B11F7D8-0x000000018B11F854
		private void _UpdateIconAlpha(); // 0x0000000183047570-0x0000000183047640
		public bool CanSwitchToCenter(bool showTip); // 0x000000018B11EC64-0x000000018B11EE10
		public void OnPressCharIconStart(PointerEventData eventData); // 0x000000018B11F570-0x000000018B11F6EC
		public void OnTacticalItemChange(); // 0x0000000183849210-0x00000001838494F0
		private void _UpdateTacticalItemStatus(); // 0x000000018339FF90-0x00000001833A0540
		public void OnTeamSwitchUnlocked(); // 0x000000018B11F6EC-0x000000018B11F748
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data); // 0x000000018B11FB34-0x000000018B11FCCC
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x0000000183E265C0-0x0000000183E26670
		private void _RefreshBuffChangeCharHpBarVfx(); // 0x0000000183848210-0x0000000183848450
		private void _HpVfxOutAnimCallback(); // 0x000000018B11F854-0x000000018B11F8C4
		private void _OnCharPassiveNumChanged(float newNum); // 0x0000000184735700-0x00000001847357E0
		private bool _IsCharHpBarVfxBuffValid(ObjectPtr<Buff> buffPtr); // 0x000000018B11F8C4-0x000000018B11F984
		private void _RebuildCharHpBarVfxBuffCache(); // 0x0000000182F497C0-0x0000000182F4A050
		private ObjectPtr<Buff> _GetLatestValidCharHpBarVfxBuffPtrFromCache(); // 0x00000001838496B0-0x00000001838497B0
		[CompilerGenerated]
		private void __UpdateComboSkillIcon_b__108_0(); // 0x00000001835425F0-0x0000000183542620
		[CompilerGenerated]
		private void __UpdateComboSkillIcon_b__108_1(); // 0x00000001849D6EF0-0x00000001849D6F30
		[CompilerGenerated]
		private void __OnHpChange_b__112_0(); // 0x0000000184A3A260-0x0000000184A3A2A0
		[CompilerGenerated]
		private void __TryShowLevelUpAnim_b__116_0(); // 0x000000018B11F7A4-0x000000018B11F7D8
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class TacticalDotCell : MonoBehaviour // TypeDefIndex: 54145
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
		public TacticalDotCell(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		public void Init(); // 0x00000001838494F0-0x0000000183849520
		public void SetDotActive(bool isActive, bool playAnim = true /* Metadata: 0x023436D2 */); // 0x00000001833A0540-0x00000001833A0610
		public void SetDotUsedUp(bool isUsedUp); // 0x000000018339FEF0-0x000000018339FF90
		[CompilerGenerated]
		private void _SetDotActive_b__8_0(); // 0x000000018B11FD38-0x000000018B11FD68
	}

	public class UIAbnormalBuffCell : UIBuffCell // TypeDefIndex: 54146
	{
		// Fields
		[SerializeField]
		private UIImage _buffLifeTimeBar; // 0x78
		[SerializeField]
		private UIStateController _abnormalLevelState; // 0x80
	
		// Constructors
		public UIAbnormalBuffCell(); // 0x000000018432B600-0x000000018432B610
	
		// Methods
		public override void OnTick(float deltaTime); // 0x000000018B120528-0x000000018B1205F4
		protected override void VisualInit(Sprite sprite); // 0x000000018B1206A8-0x000000018B120908
		protected override void SetWarningState(bool isWarning); // 0x000000018B1205F4-0x000000018B120690
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018B120690-0x000000018B120698
		public void __iFixBaseProxy_VisualInit(Sprite P0); // 0x000000018B1206A0-0x000000018B1206A8
		public void __iFixBaseProxy_SetWarningState(bool P0); // 0x000000018B120698-0x000000018B1206A0
	}

	public class UIAttachedBuffCell : UIBuffCell // TypeDefIndex: 54147
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
		private const string BUFF_ANIM_IGNITE = "headbar_buff_cell_ignite"; // Metadata: 0x023436D3
		private int m_maxStackCount; // 0x98
		private float? m_targetStackRingFillAmount; // 0x9C
		private PeriodicTimer m_igniteFillDelayTimer; // 0xA8
		private bool m_isInConsumeAnim; // 0xB0
	
		// Constructors
		public UIAttachedBuffCell(); // 0x000000018432B610-0x000000018432B6A0
	
		// Methods
		protected override void DataInit(ObjectPtr<Buff> buffPtr); // 0x000000018450F160-0x000000018450F240
		public override void OnTick(float deltaTime); // 0x00000001844B3940-0x00000001844B39D0
		public override void BeforePlayOutAnim(); // 0x000000018B120908-0x000000018B120A6C
		protected override void SetBuffIcon(Sprite sprite); // 0x000000018B120B78-0x000000018B120BF8
		protected override void SetStackElementActive(bool showStackCount); // 0x000000018B120BF8-0x000000018B120C80
		public override void SetStackCount(int stackCount, bool playAnim); // 0x00000001845D1C80-0x00000001845D3B70
		public override void OnBuffIgnite(); // 0x000000018B120A6C-0x000000018B120B78
		[CompilerGenerated]
		private void _SetStackCount_b__15_0(); // 0x0000000184DA6460-0x0000000184DA6470
		public void __iFixBaseProxy_DataInit(ObjectPtr<Buff> P0); // 0x000000018B120C88-0x000000018B120CA8
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018B120690-0x000000018B120698
		public void __iFixBaseProxy_BeforePlayOutAnim(); // 0x000000018B120C80-0x000000018B120C88
		public void __iFixBaseProxy_SetBuffIcon(Sprite P0); // 0x000000018B120CB0-0x000000018B120CB8
		public void __iFixBaseProxy_SetStackElementActive(bool P0); // 0x000000018B120CC0-0x000000018B120CC8
		public void __iFixBaseProxy_SetStackCount(int P0, bool P1); // 0x000000018B120CB8-0x000000018B120CC0
		public void __iFixBaseProxy_OnBuffIgnite(); // 0x000000018B120CA8-0x000000018B120CB0
	}

	public class UIBuffCell : MonoBehaviour // TypeDefIndex: 54149
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
		public ulong nextInstanceId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86230-0x0000000184D86240 0x0000000184D86700-0x0000000184D86710
		public string curSpritePath { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
		public UIAnimationWrapper anim { get; } // 0x000000018B121094-0x000000018B1210E4 
		public BuffData buffData { get; } // 0x000000018B1210E4-0x000000018B121170 
		public int orderPriority { get; } // 0x000000018B1211FC-0x000000018B121268 
		public ulong buffInstanceUid { get; } // 0x000000018B121170-0x000000018B1211FC 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0 // TypeDefIndex: 54148
		{
			// Fields
			public UIBuffCell __4__this; // 0x10
			public string inputSpritePath; // 0x18
			public Action onSpriteLoaded; // 0x20
			public ulong cachedLoadKey; // 0x28
	
			// Constructors
			public __c__DisplayClass25_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Init_b__0(Sprite sprite); // 0x0000000184CE50D0-0x0000000184CE5100
		}
	
		// Constructors
		public UIBuffCell(); // 0x000000018432B6A0-0x000000018432B6E0
	
		// Methods
		public void Init(ObjectPtr<Buff> buffPtr, LuaResourceLoader loader, Action onSpriteLoaded = null); // 0x00000001831D68D0-0x00000001831D6AD0
		protected virtual void DataInit(ObjectPtr<Buff> buffPtr); // 0x000000018450F2A0-0x000000018450F2D0
		protected virtual void VisualInit(Sprite sprite); // 0x000000018B120F58-0x000000018B121094
		public void Clear(); // 0x00000001839C3D80-0x00000001839C3DF0
		public virtual void BeforePlayOutAnim(); // 0x000000018B120CC8-0x000000018B120D0C
		public virtual void OnTick(float deltaTime); // 0x00000001844B39D0-0x00000001844B3A00
		public virtual void SetVisible(bool visible); // 0x000000018B120E2C-0x000000018B120EE0
		public virtual void SetStackCount(int stackCount, bool playAnim); // 0x00000001845D3B70-0x00000001845D3BE0
		public virtual void OnBuffIgnite(); // 0x000000018B120D0C-0x000000018B120D50
		protected virtual void SetBuffIcon(Sprite sprite); // 0x000000018B120D50-0x000000018B120DBC
		protected virtual void SetStackElementActive(bool isActive); // 0x000000018B120DBC-0x000000018B120E2C
		protected virtual void SetWarningState(bool isWarning); // 0x000000018B120EE0-0x000000018B120F58
	}

	public class UIBuffNode : TickableUIMono // TypeDefIndex: 54159
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
		private const string BUFF_ANIM_STRONG_IN = "headbar_buff_cell_strong_in"; // Metadata: 0x023436EC
		private const string BUFF_ANIM_IGNITE_OUT = "headbar_buff_cell_ignite_out"; // Metadata: 0x02343708
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018440A540-0x000000018440A570 
	
		// Nested types
		public enum BuffNodeType // TypeDefIndex: 54150
		{
			HeadBarCommon = 0,
			HeadBarAttached = 1,
			SquadIconCommon = 2,
			MainCharHpBarCommon = 3
		}
	
		public class BuffCellGroup // TypeDefIndex: 54151
		{
			// Fields
			public BuffIconConfig.BuffIconStyle buffIconStyle; // 0x10
			public UIBuffCell buffCellTemplate; // 0x18
			public List<UIBuffCell> buffCellPool; // 0x20
			public DynamicFastLookupCollection<ulong, UIBuffCell> buffCellDict; // 0x28
			public DynamicFastLookupCollection<ulong, UIBuffCell> buffCellWithOutAnim; // 0x30
	
			// Constructors
			public BuffCellGroup(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public UIBuffCell CreateBuffCell(Transform transform); // 0x00000001831D5D50-0x00000001831D5E40
			public void RemoveBuffCell(UIBuffCell buffCell); // 0x00000001839C2380-0x00000001839C2430
			public void ClearAllBuffCells(LuaResourceLoader loader); // 0x0000000183AA0E20-0x0000000183AA0F00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0 // TypeDefIndex: 54152
		{
			// Fields
			public UIBuffNode __4__this; // 0x10
			public bool playAnim; // 0x18
			public BuffData buffData; // 0x20
	
			// Constructors
			public __c__DisplayClass27_0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_1 // TypeDefIndex: 54153
		{
			// Fields
			public UIBuffCell newBuffCell; // 0x10
			public __c__DisplayClass27_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass27_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __AddBuffIconInternal_b__0(); // 0x000000018B11FE20-0x000000018B11FE74
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_2 // TypeDefIndex: 54154
		{
			// Fields
			public UIBuffCell buffCell; // 0x10
			public __c__DisplayClass27_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass27_2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __AddBuffIconInternal_b__1(); // 0x000000018B11FE74-0x000000018B11FFB4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_3 // TypeDefIndex: 54155
		{
			// Fields
			public UIBuffCell buffCell; // 0x10
			public __c__DisplayClass27_0 CS___8__locals3; // 0x18
	
			// Constructors
			public __c__DisplayClass27_3(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __AddBuffIconInternal_b__2(); // 0x000000018B11FFB4-0x000000018B1200F4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0 // TypeDefIndex: 54156
		{
			// Fields
			public ObjectPtr<Buff> buffPtr; // 0x10
			public BuffCellGroup buffCellGroup; // 0x20
			public UIBuffNode __4__this; // 0x28
	
			// Constructors
			public __c__DisplayClass28_0(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_1 // TypeDefIndex: 54157
		{
			// Fields
			public List<ObjectPtr<Buff>> stackBuffList; // 0x10
			public UIBuffCell buffCell; // 0x18
			public __c__DisplayClass28_0 CS___8__locals1; // 0x20
	
			// Constructors
			public __c__DisplayClass28_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __RemoveBuffIconInternal_b__0(); // 0x000000018B1200F4-0x000000018B120208
			internal void __RemoveBuffIconInternal_b__1(); // 0x000000018B120208-0x000000018B12031C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_2 // TypeDefIndex: 54158
		{
			// Fields
			public UIBuffCell buffCell; // 0x10
			public __c__DisplayClass28_0 CS___8__locals2; // 0x18
	
			// Constructors
			public __c__DisplayClass28_2(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __RemoveBuffIconInternal_b__2(); // 0x000000018B12031C-0x000000018B1203F0
			internal void __RemoveBuffIconInternal_b__3(); // 0x000000018B1203F0-0x000000018B1204C4
		}
	
		// Constructors
		public UIBuffNode(); // 0x00000001839C4290-0x00000001839C4460
	
		// Methods
		private void _OnFirstInit(); // 0x00000001839C3DF0-0x00000001839C4290
		public void OnPreWarm(); // 0x00000001839C3600-0x00000001839C3D80
		public void Init(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x0000000183A99950-0x0000000183A99A30
		public void Refresh(); // 0x0000000183AA0F00-0x0000000183AA21C0
		public void Clear(); // 0x0000000183AA0130-0x0000000183AA0270
		public override void TailLateTick(float deltaTime); // 0x0000000183AA0270-0x0000000183AA0E20
		protected override void OnRelease(); // 0x000000018B121268-0x000000018B121330
		public void OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x00000001831D53F0-0x00000001831D5480
		private bool _IsBuffIconInThisNode(ObjectPtr<Buff> buffPtr); // 0x0000000183AA22D0-0x0000000183AA2370
		private void _OnAddBuff(ObjectPtr<Buff> buffPtr); // 0x000000018B121330-0x000000018B1213D4
		private void _OnRemoveBuff(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason); // 0x00000001831D5480-0x00000001831D5520
		private void _AddBuffIconInternal(ObjectPtr<Buff> buffPtr, bool playAnim); // 0x00000001831D5910-0x00000001831D5D50
		private void _RemoveBuffIconInternal(ObjectPtr<Buff> buffPtr, Buff.FinishReason finishReason); // 0x00000001831D5590-0x00000001831D5910
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr); // 0x000000018B1213D4-0x000000018B121548
		private void _OnBuffIgnite(ObjectPtr<Buff> buffPtr); // 0x000000018B121548-0x000000018B1216B0
		private void _RegisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x0000000183A9B430-0x0000000183A9B600
		private void _UnregisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x0000000183A9B600-0x0000000183A9B7D0
		private BuffIconConfig.BuffIconStyle _GetIconStyle(Buff buff); // 0x00000001831D5E40-0x00000001831D68D0
		private void _SetBuffCellSiblingInOrder(UIBuffCell buffCell); // 0x000000018B1216B0-0x000000018B12191C
		private void _DealWithBuffCellVisible(); // 0x00000001831D5520-0x00000001831D5590
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000186C37238-0x0000000186C37240
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	public class UILifeTimeBuffCell : UIBuffCell // TypeDefIndex: 54160
	{
		// Fields
		[SerializeField]
		private UIImage _buffLifeTimeBar; // 0x78
	
		// Constructors
		public UILifeTimeBuffCell(); // 0x000000018432B600-0x000000018432B610
	
		// Methods
		public override void OnTick(float deltaTime); // 0x000000018B122C50-0x000000018B122D44
		protected override void SetWarningState(bool isWarning); // 0x000000018B122D44-0x000000018B122DE0
		public void __iFixBaseProxy_OnTick(float P0); // 0x000000018B120690-0x000000018B120698
		public void __iFixBaseProxy_SetWarningState(bool P0); // 0x000000018B120698-0x000000018B1206A0
	}

	public class UISpellInflictionOnCharCell : MonoBehaviour // TypeDefIndex: 54161
	{
		// Fields
		[SerializeField]
		private UIStateController _stateController; // 0x18
		[SerializeField]
		private UIAnimationWrapper _animationWrapper; // 0x20
		private bool m_isActive; // 0x28
	
		// Constructors
		public UISpellInflictionOnCharCell(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void SetCellActive(bool active, bool forceRefresh = false /* Metadata: 0x02343729 */); // 0x000000018B12310C-0x000000018B123244
	}

	public class UISpellInflictionOnCharNode : MonoBehaviour // TypeDefIndex: 54166
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
		private bool isInCcDungeon { get; } // 0x0000000183E26950-0x0000000183E269D0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0 // TypeDefIndex: 54162
		{
			// Fields
			public Buff attachBuff; // 0x10
	
			// Constructors
			public __c__DisplayClass19_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __DoRefreshUI_b__0(UISpellInflictionOnCharCell cell, int index); // 0x000000018B11FD90-0x000000018B11FDD8
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 54163
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Action<UISpellInflictionOnCharCell, int> __9__19_1; // 0x08
	
			// Constructors
			static __c(); // 0x000000018B1204C4-0x000000018B120528
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __DoRefreshUI_b__19_1(UISpellInflictionOnCharCell cell, int index); // 0x000000018B11FD68-0x000000018B11FD90
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0 // TypeDefIndex: 54164
		{
			// Fields
			public Buff buff; // 0x10
	
			// Constructors
			public __c__DisplayClass20_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __OnBuffIconChange_b__0(UISpellInflictionOnCharCell cell, int index); // 0x000000018B11FDD8-0x000000018B11FE20
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 54165
		{
			// Fields
			public Buff buff; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __OnBuffEnhanceChanged_b__0(UISpellInflictionOnCharCell cell, int index); // 0x000000018B11FDD8-0x000000018B11FE20
		}
	
		// Constructors
		public UISpellInflictionOnCharNode(); // 0x0000000184A30210-0x0000000184A30330
		static UISpellInflictionOnCharNode(); // 0x0000000184B32F20-0x0000000184B33050
	
		// Methods
		private void _OnFirstInit(); // 0x0000000183E25CA0-0x0000000183E25E00
		public void OnInit(ObjectPtr<AbilitySystem> abilitySystemPtr); // 0x0000000183E264A0-0x0000000183E265C0
		public void OnTick(float deltaTime); // 0x0000000183CCEFA0-0x0000000183CCF0C0
		public void OnClear(); // 0x0000000183E25780-0x0000000183E258B0
		private void _RegisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x0000000183E25B30-0x0000000183E25CA0
		private void _UnregisterAbilityBuffEvent(AbilitySystem abilitySystem); // 0x0000000183E25170-0x0000000183E252E0
		private void _DoRefreshUI(); // 0x000000018B123244-0x000000018B1235A8
		private void _OnBuffIconChange(ObjectPtr<Buff> buffPtr, bool applied, Buff.FinishReason finishReason); // 0x0000000183E26830-0x0000000183E26950
		private void _OnBuffEnhanceChanged(ObjectPtr<Buff> buffPtr); // 0x000000018B1235A8-0x000000018B123770
	}

	public class UIHudFadeBase : MonoBehaviour // TypeDefIndex: 54167
	{
		// Fields
		public UIStyleInputValidType validType; // 0x18
	
		// Properties
		protected bool globalNeedShow { get; } // 0x0000000183968D40-0x0000000183968DA0 
	
		// Constructors
		public UIHudFadeBase(); // 0x0000000185397DA0-0x0000000185397DBC
	}

	[RequireComponent(typeof(Animator))]
	public class UIHudFadeConsoleController : UIHudFadeBase // TypeDefIndex: 54168
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
		public UIHudFadeConsoleController(); // 0x000000018B122130-0x000000018B12219C
	
		// Methods
		private void Awake(); // 0x000000018B12191C-0x000000018B121AD8
		private void OnDestroy(); // 0x000000018B121C68-0x000000018B121DFC
		public void OnShow(); // 0x000000018B121DFC-0x000000018B121EAC
		private void _CheckNeedShow(); // 0x000000018B121ED4-0x000000018B122074
		private void _OnFadeHud(); // 0x000000018B122074-0x000000018B1220C4
		private void _OnInformShow([IsReadOnly] in EventData<UIStyleInputValidTypeMask> eventData); // 0x000000018B1220C4-0x000000018B122130
		public void InformShow(); // 0x000000018B121AD8-0x000000018B121C68
		[CompilerGenerated]
		private void __CheckNeedShow_b__10_0(); // 0x000000018B121EAC-0x000000018B121ED4
		[CompilerGenerated]
		private void _InformShow_b__13_0(); // 0x000000018B121EAC-0x000000018B121ED4
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UIHudFadeController : UIHudFadeBase // TypeDefIndex: 54169
	{
		// Fields
		private CanvasGroup m_canvasGroup; // 0x20
		private bool m_curShowing; // 0x28
		private DG.Tweening.Sequence m_fadeSequence; // 0x30
		private readonly HashSet<string> m_hudPreventFadeState; // 0x38
	
		// Properties
		private bool needShow { get; } // 0x0000000183968CF0-0x0000000183968D40 
		private GameplayMiscSetting setting { get; } // 0x0000000183968FC0-0x0000000183969030 
	
		// Constructors
		public UIHudFadeController(); // 0x00000001848AD370-0x00000001848AD400
	
		// Methods
		private void Awake(); // 0x0000000184792F50-0x0000000184793100
		private void OnDestroy(); // 0x000000018B12219C-0x000000018B122330
		private void _OnFadeHud(); // 0x0000000183967990-0x00000001839679D0
		private void _CheckNeedShow(); // 0x00000001839679D0-0x0000000183968CF0
		public void SetLocalNeedShow(string state, bool needShowHud); // 0x00000001838481A0-0x0000000183848210
		private void _OnInformShow([IsReadOnly] in EventData<UIStyleInputValidTypeMask> eventData); // 0x000000018396B660-0x000000018396B6B0
		public void InformShow(); // 0x000000018396B6B0-0x000000018396C530
	}

	[RequireComponent(typeof(UIAnimationWrapper))]
	public class UIHudFadeTouchSkill : UIHudFadeBase // TypeDefIndex: 54170
	{
		// Fields
		private UIAnimationWrapper m_animationWrapper; // 0x20
		private bool m_curShowing; // 0x28
		private bool m_animInOrLoop; // 0x29
		private DG.Tweening.Sequence m_fadeSequence; // 0x30
	
		// Constructors
		public UIHudFadeTouchSkill(); // 0x000000018B122C44-0x000000018B122C50
	
		// Methods
		private void Awake(); // 0x000000018B122330-0x000000018B1224D0
		private void OnDestroy(); // 0x000000018B1225E4-0x000000018B122778
		public void OnShow(); // 0x000000018B122778-0x000000018B122834
		private void _CheckNeedShow(); // 0x000000018B12299C-0x000000018B122B88
		private void _OnFadeHud(); // 0x000000018B122B88-0x000000018B122BD8
		private void _OnInformShow([IsReadOnly] in EventData<UIStyleInputValidTypeMask> eventData); // 0x000000018B122BD8-0x000000018B122C44
		public void InformShow(); // 0x000000018B1224D0-0x000000018B1225E4
		[CompilerGenerated]
		private void __CheckNeedShow_b__7_0(); // 0x000000018B122970-0x000000018B12299C
		[CompilerGenerated]
		private void _InformShow_b__10_0(); // 0x000000018B122834-0x000000018B122948
		[CompilerGenerated]
		private void _InformShow_b__10_1(); // 0x000000018B122948-0x000000018B122970
	}

	public class BattleControllerInputController : IDisposable // TypeDefIndex: 54172
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
		public static BattleControllerInputController instance { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184890DE0-0x0000000184890E20 0x000000018B11EC14-0x000000018B11EC64
		public GamepadKeyCode comboSkillButtonKey { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0 // TypeDefIndex: 54171
		{
			// Fields
			public int charIndex; // 0x10
	
			// Constructors
			public __c__DisplayClass21_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __RegisterAllCombos_b__0(); // 0x0000000182E9D930-0x0000000182E9E1B0
		}
	
		// Constructors
		private BattleControllerInputController(); // 0x000000018448E9E0-0x000000018448EAF0
	
		// Methods
		public static void Create(); // 0x000000018448E8C0-0x000000018448E9E0
		public static void DestroyInstance(); // 0x000000018B11E748-0x000000018B11E7A0
		public void Dispose(); // 0x000000018B11E7A0-0x000000018B11E8AC
		public bool GetControllerIndicatorState(); // 0x00000001845E0770-0x00000001845E0810
		public bool CheckNormalAttackBtn(); // 0x0000000184790090-0x0000000184790180
		public int TryPressControllerIndicatorWhenSkillButtonJustPressed(); // 0x000000018B11E8AC-0x000000018B11E980
		private void _RefreshCachedKeys(); // 0x000000018448EAF0-0x000000018448EC10
		private void _RefreshUltimateMode2Available(); // 0x000000018448EC10-0x000000018448ED80
		private void _RegisterAllCombos(); // 0x000000018448ED80-0x0000000184490250
		private void _UnregisterAllCombos(); // 0x000000018B11EAE8-0x000000018B11EC14
		private void _OnInputActionKeyUpdated([IsReadOnly] in EventData<string> data); // 0x000000018B11E980-0x000000018B11EAE8
	}

	public class UIAbilityTargetFollower : UIPanelBase // TypeDefIndex: 54173
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
		protected override TickType tickOption { get; } // 0x00000001843D5FA0-0x00000001843D5FD0 
		protected virtual bool actualVisible { get; } // 0x0000000183EC1520-0x0000000183EC1580 
		protected virtual bool needUpdateTransform { get; } // 0x0000000183FC2230-0x0000000183FC2290 
	
		// Constructors
		public UIAbilityTargetFollower(); // 0x00000001839C3550-0x00000001839C3600
	
		// Methods
		protected override void OnAwake(); // 0x0000000184248FC0-0x0000000184249030
		public override void TailLateTick(float deltaTime); // 0x00000001833D28C0-0x00000001833D2A60
		public virtual void SetTarget(AbilitySystem target); // 0x00000001833D26C0-0x00000001833D2850
		public virtual void Clear(); // 0x0000000183A9FA10-0x0000000183A9FAC0
		public virtual bool TryGetOriginalFollowPos(out Vector3 followPos); // 0x00000001833D50E0-0x00000001833D5220
		protected virtual void UpdateData(float deltaTime); // 0x00000001841E31F0-0x00000001841E3220
		private void _TryRefreshFollowTransform(); // 0x00000001833D2A60-0x00000001833D2B50
		private void _TryRefreshHeightFollowTransform(); // 0x00000001833D2850-0x00000001833D28C0
		private void _UpdateSelfTransform(); // 0x00000001833D2B50-0x00000001833D3010
		private void _CalculatePosition(); // 0x00000001833D30B0-0x00000001833D3A90
		private void _UpdatePosition(); // 0x00000001833D3A90-0x00000001833D3C60
		private void _UpdateScale(); // 0x00000001833D3C60-0x00000001833D4320
		private void _SetDistanceVisible(bool visible); // 0x00000001833D3010-0x00000001833D30B0
		protected void OnActualVisibleChange(bool visible, bool forceUpdate = false /* Metadata: 0x0234372A */); // 0x000000018464C9C0-0x000000018464CB80
		protected Vector3 GetAdjustedHeightOffset(AbilitySystem target); // 0x00000001833D5030-0x00000001833D50E0
		[CompilerGenerated]
		private void _OnActualVisibleChange_b__45_0(); // 0x0000000184D84AA0-0x0000000184D84AB0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000186C37238-0x0000000186C37240
	}

	public class UILockAim : UIAbilityTargetFollower // TypeDefIndex: 54174
	{
		// Fields
		public float showCancelProgressRatio; // 0x110
		public CanvasGroup aimGroup; // 0x118
		public UIImage aimRingImage; // 0x120
		public UIImage rotateImage; // 0x128
		public CanvasGroup breakingAttackGroup; // 0x130
		private UIAnimationWrapper m_aimGroupAnimWrapper; // 0x138
	
		// Constructors
		public UILockAim(); // 0x00000001839C21E0-0x00000001839C2200
	
		// Methods
		protected override void OnAwake(); // 0x0000000184248D30-0x0000000184248FC0
		protected override void OnRelease(); // 0x000000018B122DE0-0x000000018B123068
		protected void Start(); // 0x00000001849BA3A0-0x00000001849BA3F0
		protected override void UpdateData(float deltaTime); // 0x0000000184B6B5E0-0x0000000184B6B680
		private void _OnLockTargetFromAutoToManual(); // 0x000000018B123070-0x000000018B12310C
		private void _RefreshTarget(AbilitySystem _ = null); // 0x00000001849BA3F0-0x00000001849BA540
		public void __iFixBaseProxy_OnAwake(); // 0x000000018B123068-0x000000018B123070
		public void __iFixBaseProxy_OnRelease(); // 0x000000018B115A7C-0x000000018B115A84
		public void __iFixBaseProxy_UpdateData(float P0); // 0x000000018B118024-0x000000018B11802C
	}

	public class UIMainCharFootBar : TickableUIMono // TypeDefIndex: 54175
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
		protected override TickType tickOption { get; } // 0x000000018B131668-0x000000018B1316B8 
	
		// Constructors
		public UIMainCharFootBar(); // 0x000000018B131584-0x000000018B131668
		static UIMainCharFootBar(); // 0x000000018B131524-0x000000018B131584
	
		// Methods
		protected override void OnAwake(); // 0x000000018B1304EC-0x000000018B1308CC
		protected override void OnEnable(); // 0x000000018B1308CC-0x000000018B130A54
		protected override void OnRelease(); // 0x000000018B130A54-0x000000018B130DE8
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data); // 0x000000018B131300-0x000000018B1313A4
		private void _ProcessOnMainCharChange(); // 0x000000018B1313F4-0x000000018B13148C
		public override void LateTick(float deltaTime); // 0x000000018B12FB70-0x000000018B1304EC
		private void _OnDashCountChanged(float curCount); // 0x000000018B130DE8-0x000000018B131114
		private void _OnDashFailed(); // 0x000000018B131114-0x000000018B1311CC
		private void _OnInteractNpc([IsReadOnly] in EventData<string, Entity> eventData); // 0x000000018B13129C-0x000000018B131300
		private void _OnDialogStart([IsReadOnly] in EventData<bool, DialogEnums.DialogType> eventData); // 0x000000018B131230-0x000000018B13129C
		private void _OnDialogFinish([IsReadOnly] in EventData<bool> eventData); // 0x000000018B1311CC-0x000000018B131230
		private void _SetInDialog(bool inDialog); // 0x000000018B13148C-0x000000018B131524
		private void _OnOutAnimCallback(); // 0x000000018B1313A4-0x000000018B1313F4
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class UIMainCharFootBarArc : TickableUIMono // TypeDefIndex: 54176
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
		private TweenCallback m_cachedOnOutAnimCallback; // 0x138
		private float m_curDashCellCount; // 0x140
		private float m_curDashFillAmount; // 0x144
		private UIHeadBar.HpDisplayState m_dashWhiteState; // 0x148
		private Dictionary<int, string> m_dashCountStateNames; // 0x150
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001846587D0-0x0000000184658800 
	
		// Constructors
		public UIMainCharFootBarArc(); // 0x000000018476CE20-0x000000018476D100
	
		// Methods
		protected override void OnAwake(); // 0x0000000184249F50-0x000000018424A520
		protected override void OnEnable(); // 0x00000001845136A0-0x00000001845138E0
		protected override void OnRelease(); // 0x000000018B12F27C-0x000000018B12F770
		private void _OnMainCharChange([IsReadOnly] in EventData<SetLeaderReason, Entity, Entity> data); // 0x000000018B12F9C0-0x000000018B12FA38
		private void _ProcessOnMainCharChange(); // 0x00000001845138E0-0x0000000184513960
		public override void TailLateTick(float deltaTime); // 0x000000018364D9B0-0x000000018364EE80
		private void _OnDashCountChanged(float curCount); // 0x0000000184CB1530-0x0000000184CB1600
		private void _OnDashFailed(); // 0x000000018B12F770-0x000000018B12F828
		private void _OnInteractNpc([IsReadOnly] in EventData<string, Entity> eventData); // 0x000000018B12F95C-0x000000018B12F9C0
		private void _OnDialogStart([IsReadOnly] in EventData<bool, DialogEnums.DialogType> eventData); // 0x000000018B12F88C-0x000000018B12F8F8
		private void _OnDialogFinish([IsReadOnly] in EventData<bool> eventData); // 0x000000018B12F828-0x000000018B12F88C
		private void _OnPlayCutscene([IsReadOnly] in EventData<CinematicTimelineManagerBase.TimelineHandle> eventData); // 0x000000018B12FA38-0x000000018B12FA9C
		private void _OnFinishCutscene([IsReadOnly] in EventData<bool> eventData); // 0x000000018B12F8F8-0x000000018B12F95C
		private void _OnForbidSystemChanged([IsReadOnly] in EventData<ForbidType, bool> eventData); // 0x000000018415CBE0-0x000000018415CC20
		private void _SetInDialog(bool inDialog); // 0x000000018B12FA9C-0x000000018B12FB70
		public void SetUIDisable(string key, bool disable); // 0x000000018458D110-0x000000018458D1E0
		private void _RefreshDisableState(); // 0x000000018458D1E0-0x000000018458E080
		private void _OnOutAnimCallback(); // 0x00000001849B1340-0x00000001849B1390
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000186C37238-0x0000000186C37240
	}

	public class UIPoiseKnot : MonoBehaviour // TypeDefIndex: 54177
	{
		// Fields
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0x18
		[SerializeField]
		private UIAnimationWrapper _animationWrapper; // 0x20
	
		// Constructors
		public UIPoiseKnot(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		public void SetVisible(bool visible); // 0x0000000183CECE50-0x0000000183CECEB0
		public void KnotBreak(); // 0x000000018B1316B8-0x000000018B131724
	}

	public class UIWeakLockAim : UIAbilityTargetFollower // TypeDefIndex: 54178
	{
		// Fields
		public CanvasGroup aimGroup; // 0x110
	
		// Constructors
		public UIWeakLockAim(); // 0x00000001839C1E70-0x00000001839C1E80
	
		// Methods
		protected override void OnAwake(); // 0x0000000184249C20-0x0000000184249D20
		protected void Start(); // 0x00000001838C89F0-0x00000001838C8A40
		protected override void OnRelease(); // 0x000000018B131724-0x000000018B131830
		private void _OnMainTargetChanged([IsReadOnly] in EventData<AbilitySystem, bool> data); // 0x00000001838C8A40-0x00000001838C8A80
		private void _RefreshTarget(); // 0x00000001838C8A80-0x00000001838C8BB0
		public void __iFixBaseProxy_OnAwake(); // 0x000000018B123068-0x000000018B123070
		public void __iFixBaseProxy_OnRelease(); // 0x000000018B115A7C-0x000000018B115A84
	}

	public class BlueprintPreviewHelper // TypeDefIndex: 54179
	{
		// Fields
		private ushort[][] m_data; // 0x10
		private int m_width; // 0x18
		private int m_height; // 0x1C
	
		// Constructors
		public BlueprintPreviewHelper(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void SetSize(int width, int height); // 0x000000018B123B90-0x000000018B123D10
		public void AddGridValue(int x, int y, byte value); // 0x000000018B123770-0x000000018B1238E8
		public void BatchAddGridValue(int xMin, int yMin, int width, int height, byte value); // 0x000000018B1238E8-0x000000018B123AC0
		public byte GetGridValue(int x, int y, out byte value2); // 0x000000018B123AC0-0x000000018B123B90
	}

	public class CommonTrackerNodeComp : MonoBehaviour // TypeDefIndex: 54180
	{
		// Fields
		public UIBlackboxTracker blackboxTracker; // 0x18
		public UICampfireTracker campfireTracker; // 0x20
		public UICommonTracker commonTracker; // 0x28
		public UICommonLevelTracker commonLevelTracker; // 0x30
		private const float TOO_FAR_DISTANCE = 15f; // Metadata: 0x0234372B
	
		// Constructors
		public CommonTrackerNodeComp(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void ShowStyleType(CommonTrackingPointStyleType styleType, CommonTrackingPointInfoBase trackerData); // 0x000000018B123DB0-0x000000018B124000
		public void PlayOutAnimation(CommonTrackingPointStyleType styleType); // 0x000000018B123D10-0x000000018B123DB0
		public void UpdatePosition(CommonTrackingPointInfoBase trackerData); // 0x000000018B124000-0x000000018B12419C
	}

	public class CommonTrackerUpdate : MonoBehaviour // TypeDefIndex: 54185
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
		private bool _inFactoryTopView { get; } // 0x00000001834E0C60-0x00000001834E0DC0 
	
		// Nested types
		public enum CommonTrackItemState // TypeDefIndex: 54181
		{
			Show = 0,
			Hide = 1,
			ShowToHide = 2
		}
	
		public enum CommonTrackerDataState // TypeDefIndex: 54182
		{
			Active = 0,
			InActive = 1
		}
	
		public class CommonTrackerData // TypeDefIndex: 54183
		{
			// Fields
			public CommonTrackerDataState activeState; // 0x10
			public CommonTrackingPointInfoBase trackData; // 0x18
			public string key; // 0x20
	
			// Constructors
			public CommonTrackerData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		public class CommonTrackerItem // TypeDefIndex: 54184
		{
			// Fields
			public CommonTrackItemState showState; // 0x10
			public GameObject obj; // 0x18
			public CommonTrackerNodeComp commonTrackerNodeComp; // 0x20
	
			// Constructors
			public CommonTrackerItem(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public CommonTrackerUpdate(); // 0x0000000184A1BDD0-0x0000000184A1BEE0
		static CommonTrackerUpdate(); // 0x0000000184D7AA90-0x0000000184D7AAD0
	
		// Methods
		public void UpdateCommonTrackers(bool missionHudOpen, int onShowSignal); // 0x00000001834E0EC0-0x00000001834E0FF0
		public void AllTrackersPlayOutAnimation(); // 0x0000000184A34A60-0x0000000184A34AF0
		private bool _InitTrackInfoByIndex(int trackerIdx, string key, CommonTrackingPointInfoBase trackData); // 0x000000018B124458-0x000000018B124584
		private CommonTrackerItem _CreateNewMissionTracker(); // 0x000000018B12419C-0x000000018B124340
		private void _DeleteInvalidTracker(); // 0x00000001834E0E40-0x00000001834E0EC0
		private void _ShowTrackerGo(CommonTrackerItem trackerItem, CommonTrackingPointInfoBase trackerData); // 0x000000018B124584-0x000000018B124624
		private void _HideTrackerGo(CommonTrackerItem trackerItem); // 0x000000018B1243E4-0x000000018B124458
		private int _FindTrackIndexByKey(string key); // 0x000000018B124340-0x000000018B1243E4
	}

	public class UIBlackboxTracker : MonoBehaviour // TypeDefIndex: 54186
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIText distanceTxt; // 0x30
	
		// Constructors
		public UIBlackboxTracker(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound, float distance, bool needShowDistance); // 0x000000018B12CAFC-0x000000018B12CD58
	}

	public class UICampfireTracker : MonoBehaviour // TypeDefIndex: 54187
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIImage image; // 0x30
		private const string ORG_ICON = "Map/MarkIconSmall/campfire_icon"; // Metadata: 0x02343734
	
		// Constructors
		public UICampfireTracker(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound, float distance, bool needShowDistance); // 0x000000018B12CE18-0x000000018B12CF28
		public void UpdateImage(CommonTrackingPointInfoBase trackerData); // 0x000000018B12CD58-0x000000018B12CE18
	}

	public class UICommonLevelTracker : MonoBehaviour // TypeDefIndex: 54188
	{
		// Fields
		public RectTransform rectTransform; // 0x18
		public RectTransform arrowRotator; // 0x20
		public UIAnimationWrapper animationWrapper; // 0x28
		public UIText distanceTxt; // 0x30
	
		// Constructors
		public UICommonLevelTracker(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void UpdatePosition(PosValueState posValueState, bool needShowDistance, Vector2 uiPos, float uiAngle, bool isOutBound, float distance, CommonTrackMapTier mapTier = CommonTrackMapTier.Current /* Metadata: 0x02343754 */); // 0x000000018B12CF28-0x000000018B12D194
	}

	public class UICommonTracker : MonoBehaviour // TypeDefIndex: 54189
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
		private const string ORG_ICON = "Map/MarkIconSmall/general_track_other_level"; // Metadata: 0x02343756
	
		// Constructors
		public UICommonTracker(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void UpdateImage(CommonTrackingPointInfoBase trackerData); // 0x000000018B12D194-0x000000018B12D284
		public void UpdatePosition(PosValueState posValueState, bool needShowDistance, Vector2 uiPos, float uiAngle, bool isOutBound, float distance, CommonTrackMapTier mapTier = CommonTrackMapTier.Current /* Metadata: 0x02343755 */); // 0x000000018B12D284-0x000000018B12D5D0
	}

	public class CoolerUnitProgressBarUI : WorldUIController // TypeDefIndex: 54190
	{
		// Fields
		private Entity m_targetEntity; // 0xC0
		private CoolerUnitComponent m_coolerUnitComponent; // 0xC8
		private float m_displayProgress; // 0xD0
		private const float LERP_SPEED = 5f; // Metadata: 0x02343782
		private const float MAX_STEP = 0.07f; // Metadata: 0x02343786
		public UIText progressDesc; // 0xD8
		public UIText progressText; // 0xE0
		public UIImage progressImage; // 0xE8
		public Transform progressUIRoot; // 0xF0
		private CanvasGroup m_canvasGroup; // 0xF8
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B124E94-0x000000018B124EE4 
	
		// Constructors
		public CoolerUnitProgressBarUI(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018B124624-0x000000018B124880
		public override void SetUIForward(); // 0x000000018B1249AC-0x000000018B124B2C
		public override void SetPos(); // 0x000000018B124880-0x000000018B1249AC
		public override void TickUI(float deltaTime); // 0x000000018B124B2C-0x000000018B124BA8
		private void _TickCanvasGroup(float deltaTime); // 0x000000018B124BD8-0x000000018B124D08
		private void _UpdateProgress(float deltaTime); // 0x000000018B124D08-0x000000018B124E94
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B124BD0-0x000000018B124BD8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018B124BA8-0x000000018B124BB8
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018B124BC0-0x000000018B124BC8
		public void __iFixBaseProxy_SetPos(); // 0x000000018B124BB8-0x000000018B124BC0
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018B124BC8-0x000000018B124BD0
	}

	public class CoolerUnitTemperatureCircleUI : WorldUIController // TypeDefIndex: 54193
	{
		// Fields
		private const string AUDIO_EVENT_SUCCEED = "au_int_forge_iron_success"; // Metadata: 0x0234378A
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
		protected override TickType tickOption { get; } // 0x000000018B125B90-0x000000018B125BE0 
	
		// Nested types
		public enum ETemperatureState // TypeDefIndex: 54191
		{
			None = 0,
			Low = 1,
			Safe = 2,
			High = 3,
			Finish = 4
		}
	
		public static class CoolerUnitLangKeys // TypeDefIndex: 54192
		{
			// Fields
			public const string TOO_COLD = "lang_int_forgeiron_TempTooCold"; // Metadata: 0x023437A9
			public const string GOOD = "lang_int_forgeiron_TempGood"; // Metadata: 0x023437C8
			public const string TOO_HOT = "lang_int_forgeiron_TempTooHot"; // Metadata: 0x023437E4
			public const string FINISH = "lang_int_forgeiron_Finish"; // Metadata: 0x02343802
		}
	
		// Constructors
		public CoolerUnitTemperatureCircleUI(); // 0x00000001839C2B00-0x00000001839C2B10
		static CoolerUnitTemperatureCircleUI(); // 0x000000018B125B18-0x000000018B125B90
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018B124EE4-0x000000018B125234
		public override void SetUIForward(); // 0x000000018B125360-0x000000018B1254E0
		public override void SetPos(); // 0x000000018B125234-0x000000018B125360
		public override void TickUI(float deltaTime); // 0x000000018B1254E0-0x000000018B125580
		private void _TickCanvasGroup(float deltaTime); // 0x000000018B1258E4-0x000000018B125A14
		private void _UpdateUIState(); // 0x000000018B125A14-0x000000018B125B18
		private void _SetState(ETemperatureState state); // 0x000000018B125604-0x000000018B1258E4
		private string _GetLangKeyOrDefault(LangKey customKey, string defaultKey); // 0x000000018B125580-0x000000018B125604
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B124BD0-0x000000018B124BD8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018B124BA8-0x000000018B124BB8
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018B124BC0-0x000000018B124BC8
		public void __iFixBaseProxy_SetPos(); // 0x000000018B124BB8-0x000000018B124BC0
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018B124BC8-0x000000018B124BD0
	}

	public class CoolerUnitTemperatureUI : WorldUIController // TypeDefIndex: 54195
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
		private const float COLOR_EPS = 0.02f; // Metadata: 0x0234381C
		private const float SNAP_THRESHOLD = 0.25f; // Metadata: 0x02343820
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B126CBC-0x000000018B126D0C 
	
		// Nested types
		private enum TempColorState // TypeDefIndex: 54194
		{
			Blue = 0,
			Green = 1,
			Red = 2
		}
	
		// Constructors
		public CoolerUnitTemperatureUI(); // 0x000000018B126CA8-0x000000018B126CBC
		static CoolerUnitTemperatureUI(); // 0x000000018B126C08-0x000000018B126CA8
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018B125C50-0x000000018B125DE8
		public override void Clear(); // 0x000000018B125BE0-0x000000018B125C50
		public override void SetUIForward(); // 0x000000018B125F90-0x000000018B126110
		public override void SetPos(); // 0x000000018B125E64-0x000000018B125F90
		public override void TickUI(float deltaTime); // 0x000000018B126110-0x000000018B12619C
		private void _TickCanvasGroup(float deltaTime); // 0x000000018B1261A4-0x000000018B1262D4
		public void NormalizeRange(ref float min, ref float max); // 0x000000018B125DE8-0x000000018B125E64
		private void _UpdateUIInfo(float deltaTime); // 0x000000018B1262D4-0x000000018B126760
		private void _UpdateUIPos(float deltaTime); // 0x000000018B126760-0x000000018B126C08
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B124BD0-0x000000018B124BD8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018B124BA8-0x000000018B124BB8
		public void __iFixBaseProxy_Clear(); // 0x000000018B12619C-0x000000018B1261A4
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018B124BC0-0x000000018B124BC8
		public void __iFixBaseProxy_SetPos(); // 0x000000018B124BB8-0x000000018B124BC0
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018B124BC8-0x000000018B124BD0
	}

	public class CoolerUnitTotalProgressBarUI : WorldUIController // TypeDefIndex: 54196
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
		protected override TickType tickOption { get; } // 0x000000018B1276B4-0x000000018B127704 
	
		// Constructors
		public CoolerUnitTotalProgressBarUI(); // 0x000000018B1276A0-0x000000018B1276B4
		static CoolerUnitTotalProgressBarUI(); // 0x000000018B127650-0x000000018B1276A0
	
		// Methods
		private static string[] _GeneratePercentStrings(); // 0x000000018B127044-0x000000018B12711C
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018B126D0C-0x000000018B126DDC
		private void _ResetUI(); // 0x000000018B1271AC-0x000000018B127228
		private void _GetCanvas(); // 0x000000018B12711C-0x000000018B1271AC
		private bool _TryGetModule(ulong id); // 0x000000018B12743C-0x000000018B127554
		public override void SetUIForward(); // 0x000000018B126E88-0x000000018B126FC8
		public override void SetPos(); // 0x000000018B126DDC-0x000000018B126E88
		public override void TickUI(float deltaTime); // 0x000000018B126FC8-0x000000018B127044
		private void _TickCanvasGroup(float deltaTime); // 0x000000018B12730C-0x000000018B12743C
		private void _UpdateProgress(float deltaTime); // 0x000000018B127554-0x000000018B127650
		private void _SetProgressText(int percent); // 0x000000018B127228-0x000000018B12730C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B124BD0-0x000000018B124BD8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018B124BA8-0x000000018B124BB8
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018B124BC0-0x000000018B124BC8
		public void __iFixBaseProxy_SetPos(); // 0x000000018B124BB8-0x000000018B124BC0
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018B124BC8-0x000000018B124BD0
	}

	public class DoodadFactoryGasCoreScanUI : WorldUIController // TypeDefIndex: 54197
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
		public const int LEVEL_ONE = 1; // Metadata: 0x02343827
		public const int LEVEL_TWO = 2; // Metadata: 0x02343828
		public const int LEVEL_THREE = 3; // Metadata: 0x02343829
		public const int LEVEL_FOUR = 4; // Metadata: 0x0234382A
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B128500-0x000000018B128550 
	
		// Constructors
		public DoodadFactoryGasCoreScanUI(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018B127A38-0x000000018B127AF0
		public override void DoRelease(); // 0x000000018B127704-0x000000018B1277DC
		public override void SetUIForward(); // 0x000000018B128068-0x000000018B1281F8
		public override void SetPos(); // 0x000000018B127E4C-0x000000018B128068
		public override void TickUI(float deltaTime); // 0x000000018B1281F8-0x000000018B128258
		public override void InitUI(); // 0x000000018B1277DC-0x000000018B127A38
		public override void RefreshUI(); // 0x000000018B127AF0-0x000000018B127E4C
		private void _BindDomainChange(); // 0x000000018B128270-0x000000018B128374
		private void _UnbindDomainChange(); // 0x000000018B1283FC-0x000000018B128500
		private void _OnDomainDevelopmentChange([IsReadOnly] in EventData<string, uint, ulong> data); // 0x000000018B128374-0x000000018B1283FC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B124BD0-0x000000018B124BD8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018B124BA8-0x000000018B124BB8
		public void __iFixBaseProxy_DoRelease(); // 0x000000018B128258-0x000000018B128260
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018B124BC0-0x000000018B124BC8
		public void __iFixBaseProxy_SetPos(); // 0x000000018B124BB8-0x000000018B124BC0
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018B124BC8-0x000000018B124BD0
		public void __iFixBaseProxy_InitUI(); // 0x000000018B128260-0x000000018B128268
		public void __iFixBaseProxy_RefreshUI(); // 0x000000018B128268-0x000000018B128270
	}

	public class DoodadFactoryGasScanUI : WorldUIController // TypeDefIndex: 54198
	{
		// Fields
		private Entity m_targetEntity; // 0xC0
		private FactoryGasComponent m_coreComponent; // 0xC8
		public UIText gasName; // 0xD0
		private static readonly string X_OFFSET; // 0x00
		private static readonly string Z_OFFSET; // 0x08
		private static readonly string Y_OFFSET; // 0x10
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B128D68-0x000000018B128DB8 
	
		// Constructors
		public DoodadFactoryGasScanUI(); // 0x00000001839C2B00-0x00000001839C2B10
		static DoodadFactoryGasScanUI(); // 0x000000018B128C94-0x000000018B128D68
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018B128698-0x000000018B128748
		public override void DoRelease(); // 0x000000018B128550-0x000000018B1285CC
		public override void SetUIForward(); // 0x000000018B128AA4-0x000000018B128C34
		public override void SetPos(); // 0x000000018B128748-0x000000018B128AA4
		public override void TickUI(float deltaTime); // 0x000000018B128C34-0x000000018B128C94
		public override void InitUI(); // 0x000000018B1285CC-0x000000018B128698
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B124BD0-0x000000018B124BD8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018B124BA8-0x000000018B124BB8
		public void __iFixBaseProxy_DoRelease(); // 0x000000018B128258-0x000000018B128260
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018B124BC0-0x000000018B124BC8
		public void __iFixBaseProxy_SetPos(); // 0x000000018B124BB8-0x000000018B124BC0
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018B124BC8-0x000000018B124BD0
		public void __iFixBaseProxy_InitUI(); // 0x000000018B128260-0x000000018B128268
	}

	public class FacLineCell : MonoBehaviour // TypeDefIndex: 54200
	{
		// Fields
		private const float HSV_VALUE_RATIO = 1.6f; // Metadata: 0x0234382B
		[SerializeField]
		private RectTransform _rectTransform; // 0x18
		public RectTransform topAgent; // 0x20
		public RectTransform bottomAgent; // 0x28
		public UIAnimationWrapper lineAnimationWrapper; // 0x30
		public UIAnimationWrapper decoAnimationWrapper; // 0x38
		private List<UIImage> m_imageList; // 0x40
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 54199
		{
			// Fields
			public FacLineCell __4__this; // 0x10
			public TweenCallback callback; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _PlayLineDecoAnimation_b__0(); // 0x000000018B12CAAC-0x000000018B12CAFC
		}
	
		// Constructors
		public FacLineCell(); // 0x00000001848AC280-0x00000001848AC310
	
		// Methods
		private void Awake(); // 0x000000018B128DB8-0x000000018B128EFC
		public void PlayLineAnimation(string animationName, TweenCallback callback = null); // 0x000000018B1291E0-0x000000018B1292CC
		public void PlayLineDecoAnimation(string animationName, TweenCallback callback = null); // 0x000000018B1292CC-0x000000018B12946C
		public void ChangeLineColor(UnityEngine.Color color); // 0x000000018B128EFC-0x000000018B12914C
		public void ChangeLineWidth(float width); // 0x000000018B12914C-0x000000018B1291E0
	}

	public class FacLineDrawer : MonoBehaviour, IUIClearable // TypeDefIndex: 54202
	{
		// Fields
		private RectTransform m_rectTransform; // 0x18
		private readonly Dictionary<uint, LineData> m_lineCache; // 0x20
		private readonly List<GameObject> m_instantiatedLineCell; // 0x28
		private uint m_nextLineId; // 0x30
		private const uint INVALID_LINE_ID = 0; // Metadata: 0x0234382F
		public RectTransform startDrawAgent; // 0x38
		public RectTransform endDrawAgent; // 0x40
		public GameObject linkLinePrefab; // 0x48
	
		// Nested types
		private struct LineData // TypeDefIndex: 54201
		{
			// Fields
			public FacLineCell start; // 0x00
			public FacLineCell end; // 0x08
			public FacLineCell link; // 0x10
		}
	
		// Constructors
		public FacLineDrawer(); // 0x0000000184A7DBF0-0x0000000184A7DCD0
	
		// Methods
		private void Awake(); // 0x000000018B12946C-0x000000018B1294EC
		private void OnDestroy(); // 0x000000018B129DAC-0x000000018B129DFC
		private void _Clear(); // 0x000000018B12A0CC-0x000000018B12A288
		private GameObject _CloneLineObject(GameObject sourceObject, Transform locateTransform); // 0x000000018B12A288-0x000000018B12A3C4
		private void _RefreshCopyLineObjectColor(GameObject lineObject, UnityEngine.Color color); // 0x000000018B12A3C4-0x000000018B12A4C0
		public void ClearComponent(); // 0x000000018B129618-0x000000018B129668
		public uint DrawLine(FacLineCell start, FacLineCell end); // 0x000000018B1296B8-0x000000018B129DAC
		public void PlayLineAnimation(uint lineId, string animationName, TweenCallback callback = null); // 0x000000018B129DFC-0x000000018B129F84
		public void PlayPortLineDecoAnimation(uint lineId, string animationName, bool isStart, TweenCallback callback = null); // 0x000000018B129F84-0x000000018B12A0CC
		public void ChangeLineColor(uint lineId, UnityEngine.Color color); // 0x000000018B1294EC-0x000000018B129618
		public void ClearDrawer(); // 0x000000018B129668-0x000000018B1296B8
	}

	public class FacPipeAnimationSetting : MonoBehaviour // TypeDefIndex: 54203
	{
		// Fields
		private const string PIPE_ANIMATION_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Animations/Factory/pipecell"; // Metadata: 0x02343830
		public string decoInAnimation; // 0x18
		public string decoOutAnimation; // 0x20
		public string itemAnimation; // 0x28
		public bool needBoldAnimations; // 0x30
		public string boldDecoInAnimation; // 0x38
		public string boldDecoOutAnimation; // 0x40
		public string boldItemAnimation; // 0x48
	
		// Constructors
		public FacPipeAnimationSetting(); // 0x0000000183695570-0x0000000183695590
	}

	public class FacRegionUpgradeEffectController : MonoBehaviour // TypeDefIndex: 54204
	{
		// Fields
		[SerializeField]
		private GameObject _waitUpgradeNode; // 0x18
		[SerializeField]
		private GameObject _upgradedRegionNode; // 0x20
		[SerializeField]
		private GameObject _waitUpgradeSelectNode; // 0x28
	
		// Constructors
		public FacRegionUpgradeEffectController(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void _RefreshNodeState(GameObject node, bool active); // 0x000000018B12A640-0x000000018B12A6F4
		public void SetUpgradeState(bool isUpgraded); // 0x000000018B12A540-0x000000018B12A5D0
		public void SetSelectState(bool isSelected); // 0x000000018B12A4C0-0x000000018B12A540
		public void SetVisibleState(bool isVisible); // 0x000000018B12A5D0-0x000000018B12A640
	}

	public class UIFacTechTreePanel : UIPanelBase // TypeDefIndex: 54205
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
		protected override TickType tickOption { get; } // 0x000000018B12F22C-0x000000018B12F27C 
	
		// Constructors
		public UIFacTechTreePanel(); // 0x000000018B12F1D4-0x000000018B12F22C
	
		// Methods
		protected override void OnRelease(); // 0x000000018B12DA5C-0x000000018B12DADC
		public override void Tick(float deltaTime); // 0x000000018B12DBDC-0x000000018B12DC60
		public void InitData(); // 0x000000018B12D674-0x000000018B12D88C
		private void _OnDrag(Vector2 value); // 0x000000018B12E220-0x000000018B12E2C8
		private void _OnZoom(float value, bool needTween); // 0x000000018B12E42C-0x000000018B12E5D4
		private void _SetScale(bool needTween, float zoomTweenTime = 0f /* Metadata: 0x02343875 */, AnimationCurve curve = null, TweenCallback onFinish = null); // 0x000000018B12EC94-0x000000018B12EFD4
		private void _RefreshAll(); // 0x000000018B12E838-0x000000018B12E8C4
		private void _PosAdjust(); // 0x000000018B12E5D4-0x000000018B12E838
		private void _RefreshPivotPosition(); // 0x000000018B12E8C4-0x000000018B12EC94
		private void _UpdatePositionOffsetAfterZoomed(); // 0x000000018B12EFD4-0x000000018B12F1D4
		public void MoveNode(float dis, float nodeX, float nodeY, bool ignorePos = false /* Metadata: 0x02343879 */); // 0x000000018B12D88C-0x000000018B12DA5C
		public void FocusNode(float nodeX, float nodeY, TweenCallback onComplete); // 0x000000018B12D5D0-0x000000018B12D674
		public void OnUnlockTech(float nodeX, float nodeY, TweenCallback onComplete); // 0x000000018B12DADC-0x000000018B12DB80
		public void ZoomToFullTechTree(TweenCallback onComplete); // 0x000000018B12DDD0-0x000000018B12DE54
		private void _OnUnlockMoveNode(float nodeX, float nodeY); // 0x000000018B12E2C8-0x000000018B12E42C
		private void _ControllerUpdate(); // 0x000000018B12E03C-0x000000018B12E0E0
		private void _ControllerZoomUpdate(); // 0x000000018B12E0E0-0x000000018B12E220
		private void _ControllerDragUpdate(); // 0x000000018B12DE54-0x000000018B12E03C
		public void SetDetailShownState(bool isShown); // 0x000000018B12DB80-0x000000018B12DBDC
		[CompilerGenerated]
		private void _InitData_b__39_0(PointerEventData eventData); // 0x000000018B12DC60-0x000000018B12DCEC
		[CompilerGenerated]
		private void _InitData_b__39_1(float zoomValue); // 0x000000018B12DCEC-0x000000018B12DD5C
		[CompilerGenerated]
		private void _InitData_b__39_2(); // 0x000000018B12DD5C-0x000000018B12DDD0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_OnRelease(); // 0x000000018B115A7C-0x000000018B115A84
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class ForgeIronProgressBarUI : WorldUIController // TypeDefIndex: 54206
	{
		// Fields
		public UIText progressDesc; // 0xC0
		public UIText progressText; // 0xC8
		public UIImage progressImage; // 0xD0
		public Transform progressUIRoot; // 0xD8
		private InteractiveLogicForgeIron m_logic; // 0xE0
		private CanvasGroup m_canvasGroup; // 0xE8
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B12AFD8-0x000000018B12B028 
	
		// Constructors
		public ForgeIronProgressBarUI(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018B12A6F4-0x000000018B12A818
		public override void SetPos(); // 0x000000018B12A818-0x000000018B12A954
		public override void SetUIForward(); // 0x000000018B12A954-0x000000018B12AB90
		public override void TickUI(float deltaTime); // 0x000000018B12AB90-0x000000018B12ACA4
		public void UpdateProgress(); // 0x000000018B12ACA4-0x000000018B12AFD8
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B124BD0-0x000000018B124BD8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018B124BA8-0x000000018B124BB8
		public void __iFixBaseProxy_SetPos(); // 0x000000018B124BB8-0x000000018B124BC0
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018B124BC0-0x000000018B124BC8
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018B124BC8-0x000000018B124BD0
	}

	public class ForgeIronTemperatureCircleUI : WorldUIController // TypeDefIndex: 54208
	{
		// Fields
		private const string AUDIO_EVENT_SUCCEED = "au_int_forge_iron_success"; // Metadata: 0x0234387A
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
		protected override TickType tickOption { get; } // 0x000000018B12BD54-0x000000018B12BDA4 
	
		// Nested types
		public enum ETemperatureState // TypeDefIndex: 54207
		{
			None = 0,
			Low = 1,
			Safe = 2,
			High = 3,
			Finish = 4
		}
	
		// Constructors
		public ForgeIronTemperatureCircleUI(); // 0x00000001839C2B00-0x00000001839C2B10
		static ForgeIronTemperatureCircleUI(); // 0x000000018B12BCDC-0x000000018B12BD54
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018B12B080-0x000000018B12B178
		public override void Clear(); // 0x000000018B12B028-0x000000018B12B080
		public override void SetPos(); // 0x000000018B12B178-0x000000018B12B2D0
		public override void SetUIForward(); // 0x000000018B12B2D0-0x000000018B12B628
		public override void TickUI(float deltaTime); // 0x000000018B12B628-0x000000018B12B7B4
		public void UpdateUIState(); // 0x000000018B12B7B4-0x000000018B12B90C
		private void _SetState(bool max, bool low, bool high, ETemperatureState state); // 0x000000018B12B90C-0x000000018B12BCDC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B124BD0-0x000000018B124BD8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018B124BA8-0x000000018B124BB8
		public void __iFixBaseProxy_Clear(); // 0x000000018B12619C-0x000000018B1261A4
		public void __iFixBaseProxy_SetPos(); // 0x000000018B124BB8-0x000000018B124BC0
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018B124BC0-0x000000018B124BC8
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018B124BC8-0x000000018B124BD0
	}

	public class ForgeIronTemperatureUI : WorldUIController // TypeDefIndex: 54209
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
		protected override TickType tickOption { get; } // 0x000000018B12CA5C-0x000000018B12CAAC 
	
		// Constructors
		public ForgeIronTemperatureUI(); // 0x000000018B12CA48-0x000000018B12CA5C
		static ForgeIronTemperatureUI(); // 0x000000018B12C9D0-0x000000018B12CA48
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018B12BDA4-0x000000018B12BE9C
		public override void SetPos(); // 0x000000018B12BE9C-0x000000018B12BFD8
		public override void SetUIForward(); // 0x000000018B12BFD8-0x000000018B12C144
		public override void TickUI(float deltaTime); // 0x000000018B12C144-0x000000018B12C264
		public void UpdateUIInfo(); // 0x000000018B12C264-0x000000018B12C554
		public void UpdateUIPos(); // 0x000000018B12C554-0x000000018B12C9D0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B124BD0-0x000000018B124BD8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018B124BA8-0x000000018B124BB8
		public void __iFixBaseProxy_SetPos(); // 0x000000018B124BB8-0x000000018B124BC0
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018B124BC0-0x000000018B124BC8
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018B124BC8-0x000000018B124BD0
	}

	public class GuideFakeButton : Selectable, IPointerClickHandler, IUIClearable // TypeDefIndex: 54210
	{
		// Fields
		public UIButton targetButton; // 0x188
		public UIToggle targetToggle; // 0x190
		public UIDropdown targetDropdown; // 0x198
		public string targetKeyHintActionId; // 0x1A0
		private string m_targetActionId; // 0x1A8
		public Action onClick; // 0x1B0
		private InputBindingGroupMonoTarget m_parent; // 0x1B8
	
		// Constructors
		public GuideFakeButton(); // 0x0000000184D5DE60-0x0000000184D5DEB0
	
		// Methods
		public void ForceToggleTargetBinding(bool active, bool forDrag = false /* Metadata: 0x02343899 */); // 0x000000018B1322C0-0x000000018B132490
		public void CopyTargetBinding(); // 0x000000018B131FD8-0x000000018B1322C0
		private void _OnTriggerPlayerAction([IsReadOnly] in EventData<string> actionId); // 0x000000018B132D20-0x000000018B132DAC
		public void ClearTarget(); // 0x000000018B131EC8-0x000000018B131FD8
		public void ClearBinding(); // 0x000000018B131D28-0x000000018B131E78
		protected override void Awake(); // 0x000000018B131C90-0x000000018B131D28
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018B132730-0x000000018B13287C
		public override void OnPointerUp(PointerEventData eventData); // 0x000000018B132B14-0x000000018B132C60
		public override void OnPointerEnter(PointerEventData eventData); // 0x000000018B13287C-0x000000018B1329C8
		public override void OnPointerExit(PointerEventData eventData); // 0x000000018B1329C8-0x000000018B132B14
		public void OnPointerClick(PointerEventData eventData); // 0x000000018B132490-0x000000018B132730
		public void ClearComponent(); // 0x000000018B131E78-0x000000018B131EC8
		private void _ClearOnClick(); // 0x000000018B132C70-0x000000018B132D20
		public void __iFixBaseProxy_Awake(); // 0x000000018B0869D4-0x000000018B0869DC
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0); // 0x000000018B0C580C-0x000000018B0C5814
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0); // 0x000000018B0C5814-0x000000018B0C581C
		public void __iFixBaseProxy_OnPointerEnter(PointerEventData P0); // 0x000000018B132C60-0x000000018B132C68
		public void __iFixBaseProxy_OnPointerExit(PointerEventData P0); // 0x000000018B132C68-0x000000018B132C70
	}

	[Serializable]
	public class RegionMap3DCfg // TypeDefIndex: 54211
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
		[CompilerGenerated]
		private bool _isLoaded_k__BackingField; // 0x58
	
		// Properties
		public bool isLoaded { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86F70-0x0000000184D86F80 0x0000000184D86F80-0x0000000184D86F90
	
		// Constructors
		public RegionMap3DCfg(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Load(RegionMapSetting regionMapSetting); // 0x0000000183D2A790-0x0000000183D2AB50
	}

	public enum RegionMapShowType // TypeDefIndex: 54212
	{
		Map = 0,
		Watch = 1
	}

	public class RegionMapSetting : UIPanelBase // TypeDefIndex: 54213
	{
		// Fields
		public const string UI_REGION_MAP_TRACK_ICON = "Assets/Beyond/DynamicAssets/Gameplay/UI/Prefabs/Map/Widgets/RegionMapTrackIcon.prefab"; // Metadata: 0x023438A0
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
		private const string OUTER_COLOR_PROPERTY_NAME = "_OuterColor"; // Metadata: 0x023438F7
		private static MaterialPropertyBlock s_materialPropertyBlock; // 0x00
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000184D25FB0-0x0000000184D25FE0 
		public Dictionary<string, RegionMap3DCfg> cfg { get; } // 0x0000000183D2A6A0-0x0000000183D2A6D0 
		private static MaterialPropertyBlock m_materialPropertyBlock { get; } // 0x000000018B134BD8-0x000000018B134CAC 
	
		// Constructors
		public RegionMapSetting(); // 0x0000000184B0B830-0x0000000184B0B910
	
		// Methods
		protected override void OnDestroy(); // 0x000000018B1344DC-0x000000018B134664
		private void _InitUI(); // 0x0000000183D2B8B0-0x0000000183D2BE00
		private void _InitPlayerIcon(); // 0x00000001836CCE40-0x00000001836CD1E0
		private void _InitTrackIcon(); // 0x0000000183D2CC60-0x0000000183D2F800
		private void _InitSelect(); // 0x0000000183D2BE00-0x0000000183D2C0F0
		private void _SetMapPos(RectTransform rect, Vector3 pos, BasicLoadConfigInfo uiLevelMapConfig); // 0x00000001836CB4E0-0x00000001836CB650
		private void _RefreshMaterials(); // 0x00000001837D6C20-0x00000001837D6E00
		private void _ClearMaterials(); // 0x000000018B1349D8-0x000000018B134BD8
		public void InitData(RegionMapShowType shotType, Transform center = null, Transform moveRoot = null, float watchRadius = 0f /* Metadata: 0x0234389C */); // 0x0000000183D2C0F0-0x0000000183D2CC60
		public void MoveToPlayer(Transform center, Transform moveRoot); // 0x00000001836CD1E0-0x00000001836CD400
		public Transform GetNodeTransform(string levelId); // 0x000000018B134420-0x000000018B1344DC
		public Vector3 GetNodeMoveTargetLocalPosition(string levelId, Camera uiCamera, Transform moveRoot); // 0x000000018B1340C4-0x000000018B134420
		public RegionMap3DCfg GetCfg(string levelId); // 0x000000018B13403C-0x000000018B1340C4
		public static bool IsCircleIntersectingRectangle(Vector2 circleCenter, float circleRadius, UnityEngine.Rect rectangle); // 0x0000000183D2A6D0-0x0000000183D2A790
		public void SetLoadedRegionTransform(Transform regionTransform); // 0x000000018B134850-0x000000018B1348B8
		public TweenerCore<Quaternion, Quaternion, NoOptions> StartRegionRectTransformMoveRotationTween(float tweenDuration, AnimationCurve tweenCurve); // 0x000000018B1348B8-0x000000018B1349D8
		public void SetControllerLevelSelectedState(string levelId, bool isSelected); // 0x000000018B134664-0x000000018B134850
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000181538B20-0x0000000181538B30
	}

	[Serializable]
	public class UIFacMainRegionConfig // TypeDefIndex: 54214
	{
		// Fields
		public string levelId; // 0x10
		public int panelIndex; // 0x18
		public List<Sprite> levelSprites; // 0x20
		public List<Vector3> levelPositions; // 0x28
	
		// Constructors
		public UIFacMainRegionConfig(); // 0x00000001845A3970-0x00000001845A3A40
	}

	public class UIFacMainRegion : MonoBehaviour, IUIClearable // TypeDefIndex: 54215
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
		public UIFacMainRegion(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		private void _OnMainRegionLevelChanged(string levelId, int panelIndex); // 0x000000018B139A40-0x000000018B139ACC
		private void _RefreshRegionState(); // 0x0000000183B77F30-0x0000000183B78810
		private void OnDestroy(); // 0x0000000183B77CB0-0x0000000183B77CF0
		public void InitMainRegion(string levelId, int panelIndex); // 0x0000000183B77CF0-0x0000000183B77E20
		public void ClearComponent(); // 0x0000000183B77E20-0x0000000183B77F30
	}

	public class UILevelMapCommonStaticElement : MonoBehaviour, IUIClearable // TypeDefIndex: 54216
	{
		// Fields
		private const string SPRITE_FOLDER = "Map/CommonStaticElement/"; // Metadata: 0x02343903
		private UIImage m_image; // 0x18
		private MapStaticElementData m_elementData; // 0x20
		private List<int> m_conditionHandles; // 0x28
		private int m_activeVisibilityIndex; // 0x30
		private int m_activeImageIndex; // 0x34
		private bool m_visibilityInitialized; // 0x38
		private bool m_imageInitialized; // 0x39
	
		// Constructors
		public UILevelMapCommonStaticElement(); // 0x0000000184CAE1F0-0x0000000184CAE220
	
		// Methods
		public void InitCommonStaticElement(MapStaticElementData elementData); // 0x000000018400CF80-0x000000018400D0E0
		[IDTag(0)]
		private void _RegisterPhaseConditions(MapManager mapManager, List<CommonElementVisibilityPhaseData> phases); // 0x000000018400D7F0-0x000000018400DB90
		[IDTag(1)]
		private void _RegisterPhaseConditions(MapManager mapManager, List<CommonElementImagePhaseData> phases); // 0x000000018400CD60-0x000000018400CF80
		private void _OnAnyConditionChanged(int handle, bool _); // 0x000000018B139FAC-0x000000018B13A01C
		private void _ReevaluateAndApply(); // 0x000000018400D0E0-0x000000018400D2C0
		[IDTag(0)]
		private static int _FindMatchingPhaseIndex(MapManager mapManager, List<CommonElementVisibilityPhaseData> phases); // 0x000000018400D340-0x000000018400D400
		[IDTag(1)]
		private static int _FindMatchingPhaseIndex(MapManager mapManager, List<CommonElementImagePhaseData> phases); // 0x000000018400D2C0-0x000000018400D340
		private void _LoadImage(string imgPath, float imgScale); // 0x000000018B139DA8-0x000000018B139FAC
		private void _UnloadImage(); // 0x000000018400D6A0-0x000000018400D7F0
		public void ClearComponent(); // 0x000000018400D400-0x000000018400D6A0
		private void OnDestroy(); // 0x000000018400CD20-0x000000018400CD60
		public static bool EvaluateInitialVisibility(MapStaticElementData elementData); // 0x000000018B139C74-0x000000018B139DA8
	}

	public class UILevelMapCrane : MonoBehaviour, IUIClearable // TypeDefIndex: 54218
	{
		// Fields
		private CombineKey m_eventKey; // 0x18
		private CachedPathAssetLoader m_assetLoader; // 0x20
		private const string CRANE_SPRITE_FOLDER = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/Map/Crane/"; // Metadata: 0x0234391C
		private const string CRANE_GAME_VAR_KEY = "lv003_crane_state"; // Metadata: 0x02343957
		[SerializeField]
		private SerializeReferenceDictionary<long, CraneSpritePath> _stateSpriteDict; // 0x28
		[SerializeField]
		private RectTransform _rectTransform; // 0x30
		[SerializeField]
		private UIImage _image; // 0x38
	
		// Nested types
		[Serializable]
		public class CraneSpritePath // TypeDefIndex: 54217
		{
			// Fields
			public string stateSpritePath; // 0x10
	
			// Constructors
			public CraneSpritePath(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public UILevelMapCrane(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		private void OnDestroy(); // 0x000000018B13A078-0x000000018B13A0D4
		private void _RefreshCraneState(); // 0x000000018B13A33C-0x000000018B13A5C0
		private void _ClearSpriteAsset(); // 0x000000018B13A274-0x000000018B13A2DC
		private void _OnCraneStateChanged([IsReadOnly] in EventData<long, long> eventData); // 0x000000018B13A2DC-0x000000018B13A33C
		private void _BindAll(); // 0x000000018B13A0D4-0x000000018B13A274
		private void _UnBindAll(); // 0x0000000183D87B40-0x0000000183D87C20
		public void InitCrane(); // 0x000000018B13A01C-0x000000018B13A078
		public void ClearComponent(); // 0x0000000183D87B00-0x0000000183D87B40
	}

	public class UILevelMapGameplayArea : MonoBehaviour, IUIClearable // TypeDefIndex: 54219
	{
		// Fields
		private bool m_initialized; // 0x18
		[SerializeField]
		private RectTransform _rectTransform; // 0x20
		[SerializeField]
		private RectTransform _circleRectTransform; // 0x28
	
		// Constructors
		public UILevelMapGameplayArea(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		private void _RefreshGameplayArea(GameplayAreaInstRuntimeData areaData); // 0x000000018B13A624-0x000000018B13A75C
		public void Init(GameplayAreaInstRuntimeData areaData); // 0x000000018B13A5C0-0x000000018B13A624
		public void ClearComponent(); // 0x0000000184CE5040-0x0000000184CE5070
	}

	public class UILevelMapLimitInRect : TickableUIMono, IUIClearable // TypeDefIndex: 54221
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
		protected override TickType tickOption { get; } // 0x00000001845B1FA0-0x00000001845B1FD0 
	
		// Nested types
		public enum MaskShapeType // TypeDefIndex: 54220
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public UILevelMapLimitInRect(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		public override void LateTick(float deltaTime); // 0x000000018378F250-0x000000018378F2A0
		protected override void OnEnable(); // 0x000000018378E6D0-0x000000018378E710
		protected override void OnRelease(); // 0x0000000184751340-0x0000000184751380
		private void _LimitInRect(); // 0x000000018378F840-0x00000001837901B0
		public void ClearComponent(); // 0x0000000184751380-0x00000001847513C0
		public void StartLimitMarkInRect(); // 0x0000000184976190-0x0000000184976220
		public void StopLimitMarkInRect(); // 0x0000000184A3D6F0-0x0000000184A3D750
		public void ForceRefreshLimitState(); // 0x000000018B13A75C-0x000000018B13A7AC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	public class UILevelMapLine : TickableUIMono, IUIClearable // TypeDefIndex: 54222
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
		protected override TickType tickOption { get; } // 0x0000000184006900-0x0000000184006960 
	
		// Constructors
		public UILevelMapLine(); // 0x00000001839C44F0-0x00000001839C4500
	
		// Methods
		protected override void OnEnable(); // 0x000000018364D290-0x000000018364D4E0
		private void _HoldLineSize(); // 0x000000018364EF20-0x000000018364F110
		public override void LateTick(float deltaTime); // 0x000000018364EE80-0x000000018364EF20
		public void Init(float basicLength); // 0x00000001840E3510-0x00000001840E36B0
		public void ClearComponent(); // 0x00000001844362D0-0x0000000184436300
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class UILevelMapMissionArea : TickableUIMono, IUIClearable // TypeDefIndex: 54224
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
		protected override TickType tickOption { get; } // 0x000000018B13B204-0x000000018B13B254 
		public bool needCheckMissionTrackCoexist { get; } // 0x000000018B13B13C-0x000000018B13B1A8 
		public bool coexistWithMissionTrack { get; } // 0x000000018B13B0EC-0x000000018B13B13C 
		public bool notNeedCheckCoexistBecauseOfRadius { get; } // 0x000000018B13B1A8-0x000000018B13B204 
	
		// Nested types
		public enum DisappearRectShapeType // TypeDefIndex: 54223
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public UILevelMapMissionArea(); // 0x00000001849709F0-0x0000000184970A70
	
		// Methods
		public override void LateTick(float deltaTime); // 0x000000018B13A8CC-0x000000018B13A92C
		private void _RefreshMissionArea(MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData); // 0x000000018B13AFD4-0x000000018B13B0EC
		private bool _IsCircleOutsideDisappearRect(); // 0x000000018B13A9D8-0x000000018B13AFD4
		private void _DisappearIfOutRect(); // 0x000000018B13A92C-0x000000018B13A9D8
		public void Init(MissionTrackingMarkInstRuntimeDate missionMarkInstRuntimeData, GameObject associatedTrackingMark); // 0x000000018B13A7FC-0x000000018B13A8CC
		public void ClearComponent(); // 0x0000000184CADF70-0x0000000184CADFB0
		public void ForceRefreshDisappearIfOutRect(); // 0x000000018B13A7AC-0x000000018B13A7FC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class UILevelMapMisty : MonoBehaviour, IUIClearable // TypeDefIndex: 54225
	{
		// Fields
		private CombineKey m_eventKey; // 0x18
		private bool m_needBind; // 0x1C
		private const long INVISIBLE_STATE_VALUE = 1; // Metadata: 0x0234396D
		private const string MISTY_GAME_VAR_KEY = "huanzhuline_game_finish"; // Metadata: 0x02343975
	
		// Constructors
		public UILevelMapMisty(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		private void OnDestroy(); // 0x000000018B13B370-0x000000018B13B3C0
		private void _RefreshMistyState(); // 0x000000018B13B5D0-0x000000018B13B64C
		private void _OnMistyStateChanged([IsReadOnly] in EventData<long, long> eventData); // 0x000000018B13B560-0x000000018B13B5D0
		private void _BindAll(); // 0x000000018B13B3C0-0x000000018B13B560
		private void _UnBindAll(); // 0x000000018B13B64C-0x000000018B13B730
		public void InitMisty(); // 0x000000018B13B254-0x000000018B13B2B8
		public static bool IsMistyVisible(); // 0x000000018B13B2B8-0x000000018B13B370
		public void ClearComponent(); // 0x0000000184CE5010-0x0000000184CE5040
	}

	public class UILevelMapNarrativeAreaText : MonoBehaviour, IUIClearable // TypeDefIndex: 54226
	{
		// Fields
		private UIText m_text; // 0x18
		private MapStaticElementData m_elementData; // 0x20
		private int m_conditionHandle; // 0x28
		private string m_currentTextId; // 0x30
		private bool m_initialized; // 0x38
	
		// Constructors
		public UILevelMapNarrativeAreaText(); // 0x00000001845DACD0-0x00000001845DAD00
	
		// Methods
		public void InitNarrativeAreaText(MapStaticElementData elementData); // 0x00000001840243C0-0x0000000184024460
		private void _OnAnyConditionChanged(int handle, bool _); // 0x000000018B13B9A4-0x000000018B13BA14
		private void _ReevaluateAndApply(); // 0x0000000184024460-0x0000000184024650
		public void ClearComponent(); // 0x0000000184256330-0x0000000184256380
		private void OnDestroy(); // 0x00000001842562F0-0x0000000184256330
		private static MapStaticElementConditionExpression _MergeAllConditionExpressions(List<MapNarrativeTextPhaseData> phases); // 0x000000018B13B730-0x000000018B13B9A4
	}

	public class UILevelMapSwitchBtn : MonoBehaviour, IUIClearable // TypeDefIndex: 54228
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
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 54227
		{
			// Fields
			public string targetLevelId; // 0x10
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _InitSwitchButton_b__0(PointerEventData eventData); // 0x000000018B1371E4-0x000000018B137270
		}
	
		// Constructors
		public UILevelMapSwitchBtn(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		public void InitSwitchButton(string targetLevelId, float directionAngle); // 0x0000000183D2B190-0x0000000183D2B6C0
		public void ClearComponent(); // 0x000000018443CFF0-0x000000018443D180
	}

	public class UILevelMapTouchPanelWrapper : TickableUIMono // TypeDefIndex: 54229
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
		protected override TickType tickOption { get; } // 0x000000018B13C464-0x000000018B13C4B4 
	
		// Constructors
		public UILevelMapTouchPanelWrapper(); // 0x000000018B13C3DC-0x000000018B13C464
	
		// Methods
		protected override void OnAwake(); // 0x000000018B13BA14-0x000000018B13BB6C
		public override void Tick(float deltaTime); // 0x000000018B13BB6C-0x000000018B13BC78
		private bool _IsFirstRaycastSelectable(PointerEventData pointerEventData); // 0x000000018B13C168-0x000000018B13C3DC
		private void _CheckDrag(); // 0x000000018B13BC78-0x000000018B13BFC0
		private void _CheckScroll(); // 0x000000018B13BFC0-0x000000018B13C168
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class UIRegionMap3DPanel : UIPanelBase // TypeDefIndex: 54230
	{
		// Fields
		public const string HOVER_ANIM_NAME = "regionmap3d_map_hover"; // Metadata: 0x0234398D
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
		protected override TickType tickOption { get; } // 0x000000018B13D250-0x000000018B13D29C 
	
		// Constructors
		public UIRegionMap3DPanel(); // 0x000000018B13D234-0x000000018B13D250
	
		// Methods
		private Transform _GetNodeTransform(string levelId); // 0x000000018B13D048-0x000000018B13D0B4
		private Vector3 _GetMoveTargetLocalPosition(string levelId); // 0x000000018B13CF94-0x000000018B13D048
		private void _OnDoMoveTween(); // 0x000000018B13D0B4-0x000000018B13D234
		public void InitPanel(RegionMapSetting regionMapSetting); // 0x000000018B13C9B0-0x000000018B13CAC8
		public void OnClickLevelBtn(string levelId, string insId); // 0x000000018B13CAC8-0x000000018B13CE10
		public void OnLevelHoverChanged(string levelId, bool isHover); // 0x000000018B13CE10-0x000000018B13CF94
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B10A3CC-0x000000018B10A3D4
	}

	public class UIRegionMap3DUICell : UIPanelBase // TypeDefIndex: 54231
	{
		// Fields
		public UIText showName; // 0x70
		public RectTransform iconRoot; // 0x78
		public UIButton btn; // 0x80
	
		// Constructors
		public UIRegionMap3DUICell(); // 0x0000000184D526C0-0x0000000184D526D0
	}

	public class UIRegionMapTrackIcon : UIPanelBase // TypeDefIndex: 54232
	{
		// Fields
		[SerializeField]
		private UIImage _icon; // 0x70
		[SerializeField]
		private UIImage _track; // 0x78
	
		// Constructors
		public UIRegionMapTrackIcon(); // 0x0000000184D526C0-0x0000000184D526D0
	
		// Methods
		public void InitData(MissionTrackingMarkInstRuntimeDate data); // 0x000000018B13D29C-0x000000018B13D424
	}

	public class UISettlementRegion : MonoBehaviour, IUIClearable // TypeDefIndex: 54235
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
		public const string SETTLEMENT_REGION_SPRITE_FOLDER = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/Map/SettlementRegion/"; // Metadata: 0x023439A4
	
		// Nested types
		[Serializable]
		public class SettlementRegionSpritePath // TypeDefIndex: 54233
		{
			// Fields
			public string path; // 0x10
	
			// Constructors
			public SettlementRegionSpritePath(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		public class SettlementRegionSpriteData // TypeDefIndex: 54234
		{
			// Fields
			public SerializeFieldDictionary<int, SettlementRegionSpritePath> spriteWithTier; // 0x10
	
			// Constructors
			public SettlementRegionSpriteData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public UISettlementRegion(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		private void OnDestroy(); // 0x0000000183091320-0x0000000183091360
		private void _RefreshSpriteWithTier(int tier = 0 /* Metadata: 0x023439A3 */); // 0x00000001835836E0-0x0000000183583800
		private void _RefreshSettlementRegionState(); // 0x00000001835835A0-0x00000001835836E0
		private void _OnSettlementUnlocked([IsReadOnly] in EventData<string> param); // 0x000000018B13D584-0x000000018B13D5F4
		private void _BindAll(); // 0x000000018B13D488-0x000000018B13D584
		private void _UnBindAll(); // 0x000000018B13D5F4-0x000000018B13D6E8
		public void InitSettlementRegion(string settlementId, Vector3 centerPos); // 0x0000000183583540-0x00000001835835A0
		public bool GetNeedRefreshSettlementRegionTier(); // 0x00000001846270E0-0x0000000184627150
		public void RefreshSettlementRegionWithTier(int tier); // 0x000000018B13D424-0x000000018B13D488
		public void ClearComponent(); // 0x0000000183092CE0-0x0000000183092D80
	}

	public class ChessboardDrop : UIBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler, IUIClearable // TypeDefIndex: 54236
	{
		// Fields
		[NonSerialized]
		public UnityEvent<PointerEventData> onDropEvent; // 0x18
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerEnterEvent; // 0x20
		[NonSerialized]
		public UnityEvent<PointerEventData> onPointerExitEvent; // 0x28
	
		// Constructors
		public ChessboardDrop(); // 0x000000018B131BAC-0x000000018B131C90
	
		// Methods
		public void OnDrop(PointerEventData eventData); // 0x000000018B1318F8-0x000000018B131994
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018B131994-0x000000018B131A30
		public void OnPointerExit(PointerEventData eventData); // 0x000000018B131A30-0x000000018B131ACC
		private bool _CheckEventValid(PointerEventData eventData); // 0x000000018B131ACC-0x000000018B131BAC
		public void ClearComponent(); // 0x000000018B131830-0x000000018B1318A8
		protected override void OnDestroy(); // 0x000000018B1318A8-0x000000018B1318F8
		public void __iFixBaseProxy_OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class PuzzleCellDrag : UIBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 54237
	{
		// Fields
		private PuzzleDrag m_parent; // 0x18
		[SerializeField]
		private bool _needHovering; // 0x20
	
		// Constructors
		public PuzzleCellDrag(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void Init(PuzzleDrag puzzleDrag); // 0x000000018B132DAC-0x000000018B132E10
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018B132E10-0x000000018B132E7C
		public void OnDrag(PointerEventData eventData); // 0x000000018B132E7C-0x000000018B132EE8
		public void OnEndDrag(PointerEventData eventData); // 0x000000018B132EE8-0x000000018B132F54
		public void OnPointerDown(PointerEventData eventData); // 0x000000018B132FC0-0x000000018B13302C
		public void OnPointerUp(PointerEventData eventData); // 0x000000018B13310C-0x000000018B133178
		public void OnPointerClick(PointerEventData eventData); // 0x000000018B132F54-0x000000018B132FC0
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018B13302C-0x000000018B13309C
		public void OnPointerExit(PointerEventData eventData); // 0x000000018B13309C-0x000000018B13310C
	}

	public class PuzzleControllerHelper : UIBehaviour // TypeDefIndex: 54238
	{
		// Fields
		private LuaPanel m_luaPanel; // 0x18
		private PointerEventData m_controllerFocusEventData; // 0x20
		private readonly List<RaycastResult> m_raycastResults; // 0x28
	
		// Properties
		public List<RaycastResult> raycastResults { get; } // 0x000000018B13365C-0x000000018B1336AC 
	
		// Constructors
		public PuzzleControllerHelper(); // 0x000000018B1335DC-0x000000018B13365C
	
		// Methods
		protected override void Awake(); // 0x000000018B133178-0x000000018B133268
		public int TryGetPuzzleSlotIndexByPos(RectTransform gridCell); // 0x000000018B133268-0x000000018B1335DC
		public void __iFixBaseProxy_Awake(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class PuzzleDrag : UIBehaviour, IUIClearable, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 54239
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
		public LuaPanel panel { get; } // 0x000000018B133F84-0x000000018B13403C 
		public int luaIndex { get; } // 0x000000018B133F38-0x000000018B133F84 
	
		// Constructors
		public PuzzleDrag(); // 0x000000018B133D50-0x000000018B133F38
	
		// Methods
		protected override void Awake(); // 0x000000018B1336AC-0x000000018B13372C
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018B1337FC-0x000000018B1338A8
		public void OnDrag(PointerEventData eventData); // 0x000000018B1338F8-0x000000018B133990
		public void OnEndDrag(PointerEventData eventData); // 0x000000018B133990-0x000000018B133A3C
		public void OnPointerDown(PointerEventData eventData); // 0x000000018B133AC8-0x000000018B133B54
		public void OnPointerUp(PointerEventData eventData); // 0x000000018B133C6C-0x000000018B133CF8
		public void OnPointerClick(PointerEventData eventData); // 0x000000018B133A3C-0x000000018B133AC8
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018B133B54-0x000000018B133BE0
		public void OnPointerExit(PointerEventData eventData); // 0x000000018B133BE0-0x000000018B133C6C
		public void ClearComponent(); // 0x000000018B13372C-0x000000018B1337FC
		protected override void OnDestroy(); // 0x000000018B1338A8-0x000000018B1338F8
		public void SetIndex(int index); // 0x000000018B133CF8-0x000000018B133D50
		public void __iFixBaseProxy_Awake(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class ScratchOffLotteryCoating : MonoBehaviour // TypeDefIndex: 54241
	{
		// Fields
		public Texture brushTexture; // 0x18
		public Material renderMat; // 0x20
		public RectTransform rectTransform; // 0x28
		public Canvas canvas; // 0x30
		public int lotteryColumn; // 0x38
		private const float MARK_FIRST = 0.4f; // Metadata: 0x023439EB
		private const float MARK_SECOND = 0.8f; // Metadata: 0x023439EF
		private int[][] m_pixelArray; // 0x40
		private Dictionary<int, bool> m_texPixelDic; // 0x48
		private int m_pixelAccount; // 0x50
		private RenderTexture m_renderTexture; // 0x58
		private const int RENDER_TEXTURE_WIDTH = 1024; // Metadata: 0x023439F3
		private const int RENDER_TEXTURE_HEIGHT = 512; // Metadata: 0x023439F5
		private Vector2 m_lastFramePos; // 0x60
		private Vector2 m_thisFramePos; // 0x68
		private List<AwardMarkPoint> m_awardMarkPoints; // 0x70
	
		// Nested types
		private class AwardMarkPoint // TypeDefIndex: 54240
		{
			// Fields
			public Vector2 markPoint; // 0x10
			public bool markValue; // 0x18
	
			// Constructors
			public AwardMarkPoint(Vector2 point, bool value); // 0x0000000184DAB020-0x0000000184DAB030
		}
	
		// Constructors
		public ScratchOffLotteryCoating(); // 0x000000018B137104-0x000000018B1371E4
	
		// Methods
		private void Awake(); // 0x000000018B135E78-0x000000018B135EDC
		private void OnDestroy(); // 0x000000018B1363AC-0x000000018B136410
		private void _DrawBlank(); // 0x000000018B136718-0x000000018B136834
		private void _InitPixelDic(); // 0x000000018B136C84-0x000000018B136DE0
		private void _InitMarkPoint(); // 0x000000018B136B34-0x000000018B136C84
		public void Draw(float x, float y); // 0x000000018B135F40-0x000000018B1361D8
		private static UnityEngine.Rect _ClampDrawRect(float x, float y, float width, float height); // 0x0000000182E9E1B0-0x0000000182E9E650
		private void _MarkScratchPos(int x, int y, int width, int height); // 0x000000018B136DE0-0x000000018B137020
		private void _AwardMarkScratchPos(int x, int y, int width, int height); // 0x000000018B13646C-0x000000018B136614
		public float OutputCompletePercent(); // 0x000000018B136410-0x000000018B13646C
		public bool FlagCompleteMarkPoint(); // 0x000000018B136230-0x000000018B1363AC
		private List<Vector2> _FigureUpCreateRouteLinePoints(Vector2 start, Vector2 end, float thickness); // 0x000000018B136834-0x000000018B136B34
		private Vector2 _ComputeBrushUV(Vector2 localPos); // 0x000000018B136614-0x000000018B136718
		public void ApplyScratch(Vector2 position); // 0x000000018B135BE4-0x000000018B135E78
		public void BeginScratch(Vector2 position); // 0x000000018B135EDC-0x000000018B135F40
		public void EndScratch(Vector2 position); // 0x000000018B1361D8-0x000000018B136230
		private Vector2 _ScreenPosToUiLocalPos(Vector2 screenPos, RectTransform transform, Camera cam); // 0x000000018B137020-0x000000018B137104
	}

	public class UIMusicVolumeVisual : TickableUIMono // TypeDefIndex: 54242
	{
		// Fields
		private static readonly int FREQUENCY_DATA_ID; // 0x00
		private static readonly int ENABLE_RANDOM_GRAM_ID; // 0x04
		private const int BAND_COUNT = 8; // Metadata: 0x023439F7
		private UIImage m_uiImage; // 0x68
		private Material m_material; // 0x70
		private float[] m_bandValues; // 0x78
		private Vector4[] m_bandVectors; // 0x80
		private Graphic m_graphic; // 0x88
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B13C960-0x000000018B13C9B0 
		public Graphic graphic { get; } // 0x000000018B13C898-0x000000018B13C960 
	
		// Constructors
		public UIMusicVolumeVisual(); // 0x000000018B13C814-0x000000018B13C898
		static UIMusicVolumeVisual(); // 0x000000018B13C798-0x000000018B13C814
	
		// Methods
		protected void Start(); // 0x000000018B13C554-0x000000018B13C5F4
		protected override void OnEnable(); // 0x000000018B13C504-0x000000018B13C554
		protected override void OnDisable(); // 0x000000018B13C4B4-0x000000018B13C504
		public override void Tick(float deltaTime); // 0x000000018B13C5F4-0x000000018B13C798
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class RiftScanUI : WorldUIController // TypeDefIndex: 54243
	{
		// Fields
		public const string CONTROLLER_STATE_RELEASE = "Release"; // Metadata: 0x023439F8
		public const string CONTROLLER_STATE_SUPPRESS = "Suppress"; // Metadata: 0x02343A00
		public const string CONTROLLER_STATE_PROCESSED = "Processed"; // Metadata: 0x02343A09
		public const float RIGHT_OFFSET = 1f; // Metadata: 0x02343A13
		public const float RIFT_CIRCLE_RADIUS = 11f; // Metadata: 0x02343A17
		private Entity m_targetEntity; // 0xC0
		private InteractiveRiftComponent m_riftComponent; // 0xC8
		private InteractiveRiftComponentData m_instanceData; // 0xD0
		public Transform pendingLayout; // 0xD8
		public UIText typeNameText; // 0xE0
		public UIText typePercentageTxtText; // 0xE8
		public UIStateController ctrlState; // 0xF0
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B135B94-0x000000018B135BE4 
	
		// Constructors
		public RiftScanUI(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		public override void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018B134E4C-0x000000018B134EFC
		public override void DoRelease(); // 0x000000018B134CAC-0x000000018B134D3C
		public override void SetUIForward(); // 0x000000018B1353FC-0x000000018B13558C
		public override void SetPos(); // 0x000000018B134FB0-0x000000018B1353FC
		public override void TickUI(float deltaTime); // 0x000000018B13558C-0x000000018B1355EC
		public override void InitUI(); // 0x000000018B134D3C-0x000000018B134E4C
		public override void RefreshUI(); // 0x000000018B134EFC-0x000000018B134FB0
		private void _UpdateUI(int currentState); // 0x000000018B13592C-0x000000018B135B94
		private string _GetStateName(); // 0x000000018B1355EC-0x000000018B135718
		private string _GetTypeDesText(int currentState, int state, int amount, int amountMax); // 0x000000018B135718-0x000000018B13583C
		private string _GetTypePercentText(int amount, int amountMax); // 0x000000018B13583C-0x000000018B13592C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x000000018B124BD0-0x000000018B124BD8
		public void __iFixBaseProxy_Init(Entity P0, string P1, ulong P2, int P3); // 0x000000018B124BA8-0x000000018B124BB8
		public void __iFixBaseProxy_DoRelease(); // 0x000000018B128258-0x000000018B128260
		public void __iFixBaseProxy_SetUIForward(); // 0x000000018B124BC0-0x000000018B124BC8
		public void __iFixBaseProxy_SetPos(); // 0x000000018B124BB8-0x000000018B124BC0
		public void __iFixBaseProxy_TickUI(float P0); // 0x000000018B124BC8-0x000000018B124BD0
		public void __iFixBaseProxy_InitUI(); // 0x000000018B128260-0x000000018B128268
		public void __iFixBaseProxy_RefreshUI(); // 0x000000018B128268-0x000000018B128270
	}

	[RequireComponent(typeof(UIImage))]
	public class UIBrokenLine : MonoBehaviour // TypeDefIndex: 54244
	{
		// Fields
		private Material m_material; // 0x18
		private const int MAX_SET_VALUE_COUNT = 21; // Metadata: 0x02343A1D
		private const string UI_BROKEN_LINE_SHADER_NAME = "HGRP/UI/BrokenLine"; // Metadata: 0x02343A1E
		private const string Y_VALUE_PROPERTY_NAME_FORMAT = "_YValue{0}"; // Metadata: 0x02343A31
		private const string X_SCALE_PROPERTY_NAME = "_XScale"; // Metadata: 0x02343A3C
		private const string LINE_WEIGHT_PROPERTY_NAME = "_LineWidth"; // Metadata: 0x02343A44
		private List<float> m_tmpList; // 0x20
		private bool m_isInit; // 0x28
		[SerializeField]
		private float _lineWeight; // 0x2C
	
		// Constructors
		public UIBrokenLine(); // 0x000000018B137928-0x000000018B1379B0
	
		// Methods
		private void Awake(); // 0x000000018B137270-0x000000018B1372C8
		private void _Init(); // 0x000000018B13772C-0x000000018B137928
		private void OnDestroy(); // 0x000000018B1372C8-0x000000018B137348
		public void SetYValueByArray(float[] yValue, int count = 21 /* Metadata: 0x02343A1B */); // 0x000000018B137348-0x000000018B137440
		public void SetYValue(List<float> yValue, int count = 21 /* Metadata: 0x02343A1C */); // 0x000000018B137440-0x000000018B13772C
	}

	public class UICommonScanController : TickableUIMono // TypeDefIndex: 54245
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
		public const int MAX_HP_RATIO = 10000; // Metadata: 0x02343A4F
		public const float TICK_REFRESH_NEED = 0.1f; // Metadata: 0x02343A53
		public const int DONT_REFRESH = 0; // Metadata: 0x02343A57
		private bool m_uiActive; // 0x94
		protected long m_nextRefreshTime; // 0x98
		protected float m_hpRatio; // 0xA0
		protected Vector3 m_fixedPoint; // 0xA4
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B1381F8-0x000000018B138248 
		public ulong entityLogicId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86230-0x0000000184D86240 0x0000000184D86700-0x0000000184D86710
		protected bool uiActive { get; set; } // 0x000000018B138248-0x000000018B138298 0x000000018B138298-0x000000018B13830C
	
		// Constructors
		public UICommonScanController(); // 0x00000001839C2B00-0x00000001839C2B10
		static UICommonScanController(); // 0x000000018B1381A8-0x000000018B1381F8
	
		// Methods
		public virtual void SetTarget(Entity target, long nextRefresh, float hpRatio); // 0x000000018B137C80-0x000000018B137DDC
		private void _UpdatePos(); // 0x000000018B138008-0x000000018B1381A8
		public void SetFixPoint(Vector3 pos, ulong waterVolume); // 0x000000018B137AA0-0x000000018B137C80
		public override void Tick(float deltaTime); // 0x000000018B137DDC-0x000000018B137E5C
		private void _FaceToCamera(); // 0x000000018B137E5C-0x000000018B138008
		public virtual void Clear(); // 0x000000018B1379B0-0x000000018B137AA0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class UICountDownBar : TickableUIMono // TypeDefIndex: 54246
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
		protected override TickType tickOption { get; } // 0x000000018B13886C-0x000000018B1388BC 
		private bool update { get; set; } // 0x000000018B1388BC-0x000000018B13890C 0x000000018B13890C-0x000000018B138980
	
		// Constructors
		public UICountDownBar(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		public void InitData(int id, AbilitySystem target, CountDownShowAction.Data data); // 0x000000018B13839C-0x000000018B1384EC
		public void Clear(); // 0x000000018B13830C-0x000000018B13839C
		public override void LateTick(float deltaTime); // 0x000000018B1384EC-0x000000018B138574
		private void _UpdateData(float deltaTime); // 0x000000018B138574-0x000000018B138630
		private void _UpdatePos(); // 0x000000018B138630-0x000000018B13886C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class UIDoodadMineCoreScanController : UICommonScanController // TypeDefIndex: 54247
	{
		// Fields
		public GameObject canMineIcon; // 0xB0
		public UIText formingText; // 0xB8
		public UIText purityText; // 0xC0
	
		// Constructors
		public UIDoodadMineCoreScanController(); // 0x000000018B138B5C-0x000000018B138BA8
	
		// Methods
		public void SyncConditonInfo(bool forming, string condition); // 0x000000018B138A64-0x000000018B138AE0
		public void SetPurity(bool forming, string conditionText); // 0x000000018B138980-0x000000018B138A64
		public void UpdateUI(bool forming, string condition); // 0x000000018B138AE0-0x000000018B138B5C
	}

	public class UIDoodadPlantCoreScanController : UICommonScanController // TypeDefIndex: 54248
	{
		// Fields
		private const uint OFF = 0; // Metadata: 0x02343A60
		private const uint DARK = 1; // Metadata: 0x02343A61
		private const uint LIGHT = 2; // Metadata: 0x02343A62
		private const uint GROW = 4; // Metadata: 0x02343A63
		public UIText coreNameText; // 0xB0
		public UIText coreSizeText; // 0xB8
		public GameObject refreshTimeRoot; // 0xC0
		public UIText refreshTimeText; // 0xC8
		public List<GameObject> flowerDark; // 0xD0
		public List<GameObject> flowerLight; // 0xD8
		public List<GameObject> flowerGrow; // 0xE0
		private float m_tickTimeSum; // 0xE8
	
		// Constructors
		public UIDoodadPlantCoreScanController(); // 0x000000018B1392BC-0x000000018B1393CC
	
		// Methods
		public override void Tick(float deltaTime); // 0x000000018B138F6C-0x000000018B139034
		public void SetCoreInfo(string coreName, string coreSize); // 0x000000018B138BF8-0x000000018B138C94
		public void SetRefreshInfo(long nextRefreshTime = 0 /* Metadata: 0x02343A58 */); // 0x000000018B138DF4-0x000000018B138E64
		public void RefreshTextNow(); // 0x000000018B138BA8-0x000000018B138BF8
		public void SetQuantityInfo(int current, int nextRefresh, int maxCount); // 0x000000018B138C94-0x000000018B138DF4
		public void SetSingle(int index, uint state); // 0x000000018B138E64-0x000000018B138F6C
		private void _SyncTimeText(); // 0x000000018B13903C-0x000000018B1392BC
		public void __iFixBaseProxy_Tick(float P0); // 0x000000018B139034-0x000000018B13903C
	}

	public class UIDoodadScanController : UICommonScanController // TypeDefIndex: 54249
	{
		// Fields
		public UIText timeCom; // 0xB0
		public Transform refreshFull; // 0xB8
		public Transform refreshProgress; // 0xC0
		private float m_tickTimeSum; // 0xC8
	
		// Constructors
		public UIDoodadScanController(); // 0x000000018B1399EC-0x000000018B139A40
	
		// Methods
		public void SyncRefreshInfo(long nextRefresh, float hpRatio); // 0x000000018B1393CC-0x000000018B1394DC
		public override void Tick(float deltaTime); // 0x000000018B1394DC-0x000000018B1395A4
		private void _RefreshCountDown(); // 0x000000018B139654-0x000000018B1399EC
		public void UpdateUI(long nextRefresh, float hpRatio); // 0x000000018B1395A4-0x000000018B139654
		public void __iFixBaseProxy_Tick(float P0); // 0x000000018B139034-0x000000018B13903C
	}

	public class UIGeneralTracker : MonoBehaviour // TypeDefIndex: 54250
	{
		// Fields
		[SerializeField]
		private Transform _arrowRotator; // 0x18
		private RectTransform m_rect; // 0x20
	
		// Properties
		private RectTransform rect { get; } // 0x000000018B139BC8-0x000000018B139C74 
	
		// Constructors
		public UIGeneralTracker(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void UpdatePosition(Vector2 uiPos, float uiAngle, bool isOutBound); // 0x000000018B139ACC-0x000000018B139BC8
	}

	public class UILiquidPoolScanController : UICommonScanController // TypeDefIndex: 54251
	{
		// Fields
		public GameObject unLimitGroup; // 0xB0
		public GameObject limitedGroup; // 0xB8
		public UIText currentAmountText; // 0xC0
		public UIText maxAmountText; // 0xC8
		public UIText waterNameText; // 0xD0
		private const string EMPTY_LIQUID = "ui_liquid_pool_scan_text_empty"; // Metadata: 0x02343A64
		private LangKey m_key; // 0xD8
	
		// Constructors
		public UILiquidPoolScanController(); // 0x000000018B142750-0x000000018B1427D4
	
		// Methods
		public void SetWaterInfo(ulong waterId, int x, int y, int z); // 0x000000018B1421E0-0x000000018B142750
	}

	public class UIPanelBase : TickableUIMono // TypeDefIndex: 54252
	{
		// Fields
		public const string UI_SPRITE_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}.png"; // Metadata: 0x02343A83
		private LuaResourceLoader m_loader; // 0x68
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001849E6B10-0x00000001849E6B40 
	
		// Constructors
		public UIPanelBase(); // 0x00000001839C4460-0x00000001839C44C0
	
		// Methods
		protected override void OnRelease(); // 0x000000018B1427D4-0x000000018B142838
		public Sprite LoadSprite(string path, string name); // 0x0000000183849520-0x00000001838495D0
		public Sprite LoadSpriteWithOutFormat(string path); // 0x0000000183C431B0-0x0000000183C43230
		public GameObject LoadGameObject(string path); // 0x0000000183D2AB50-0x0000000183D2ABD0
		protected string GetSpritePath(string path, string name); // 0x0000000183849630-0x00000001838496B0
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
	}

	public class UIPowerPoleAutoConnectTracker : UIGeneralTracker // TypeDefIndex: 54255
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
		public class IconGroup // TypeDefIndex: 54253
		{
			// Fields
			public GameObject root; // 0x10
			public Image normal; // 0x18
			public Image error; // 0x20
	
			// Properties
			public bool activeSelf { get; } // 0x000000018B142024-0x000000018B142084 
	
			// Constructors
			public IconGroup(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void SetActiveIfNecessary(bool active); // 0x000000018B141E3C-0x000000018B141EA4
			public void Switch(bool err); // 0x000000018B141F04-0x000000018B141F94
		}
	
		[Serializable]
		public class StatusHintGroup // TypeDefIndex: 54254
		{
			// Fields
			public GameObject root; // 0x10
			public GameObject localLinkHint; // 0x18
			public GameObject globalLinkHint; // 0x20
			public GameObject outageHint; // 0x28
			public GameObject distLimitHint; // 0x30
	
			// Constructors
			public StatusHintGroup(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Switch(PowerAutoConnectStatus status); // 0x000000018B14213C-0x000000018B1421E0
		}
	
		// Constructors
		public UIPowerPoleAutoConnectTracker(); // 0x000000018B143240-0x000000018B14329C
	
		// Methods
		public void UpdateDistance(float distance); // 0x000000018B142898-0x000000018B142964
		public void SetDistanceTextVisible(bool value); // 0x000000018B142838-0x000000018B142898
		private void _ActualUpdateStatus(PowerAutoConnectStatus status); // 0x000000018B142FC4-0x000000018B143240
		public void UpdateStatus(PowerAutoConnectStatus status); // 0x000000018B142B00-0x000000018B142BA8
		public void UpdateStatusNormal(); // 0x000000018B142A50-0x000000018B142AA8
		public void UpdateStatusTooFar(); // 0x000000018B142AA8-0x000000018B142B00
		private void _ActualUdpipeError(bool error); // 0x000000018B142C54-0x000000018B142E9C
		public void UpdateUdpipeError(bool error); // 0x000000018B142BA8-0x000000018B142C54
		private void _ActualUpdateIcon(IconGroup img); // 0x000000018B142E9C-0x000000018B142FC4
		public void UpdateNodeType(int nodeType); // 0x000000018B142964-0x000000018B142A50
	}

	public class UIPowerPoleFastTravelTracker : UIGeneralTracker // TypeDefIndex: 54257
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
		private bool isWarning { get; } // 0x000000018B1441C0-0x000000018B144224 
		private bool isDisabled { get; } // 0x000000018B144148-0x000000018B1441C0 
		public bool allowToHighlight { get; } // 0x000000018B143CF4-0x000000018B143D60 
		private TravelPoleBrain.TravelPoleIcon iconStatus { get; set; } // 0x000000018B143DE0-0x000000018B143E30 0x000000018B144274-0x000000018B144314
		private TravelPoleBrain.TravelPoleStatus status { get; set; } // 0x000000018B144224-0x000000018B144274 0x000000018B144314-0x000000018B144380
		private UIAnimationWrapper animationWrapper { get; } // 0x000000018B143D60-0x000000018B143DE0 
		private GameObject imageNormal { get; } // 0x000000018B144040-0x000000018B1440C4 
		private GameObject imageWarning { get; } // 0x000000018B1440C4-0x000000018B144148 
		private GameObject imageDisabled { get; } // 0x000000018B143E30-0x000000018B143EB4 
		private GameObject imageHighlighted { get; } // 0x000000018B143F38-0x000000018B143FBC 
		private GameObject imageNormalOther { get; } // 0x000000018B143FBC-0x000000018B144040 
		private GameObject imageHighlightedOther { get; } // 0x000000018B143EB4-0x000000018B143F38 
	
		// Nested types
		[Serializable]
		private struct TravelPoleStatusSetting // TypeDefIndex: 54256
		{
			// Fields
			[SerializeField]
			public bool showTextInfoBg; // 0x00
			[SerializeField]
			public GameObject textToShow; // 0x08
		}
	
		// Constructors
		public UIPowerPoleFastTravelTracker(); // 0x000000018B143C8C-0x000000018B143CF4
	
		// Methods
		public void PlayFocus(); // 0x000000018B1432FC-0x000000018B143370
		public void UpdateIconStatus(TravelPoleBrain.TravelPoleIcon value); // 0x000000018B143450-0x000000018B1434B4
		public void UpdateStatus(TravelPoleBrain.TravelPoleStatus value); // 0x000000018B14357C-0x000000018B1435E0
		public void UpdateIsHighlighted(bool value); // 0x000000018B1434B4-0x000000018B143518
		public void UpdateIsOtherSocial(bool value); // 0x000000018B143518-0x000000018B14357C
		public void UpdateDistance(Vector3 value); // 0x000000018B143370-0x000000018B143450
		private void _OnStatusChanged(); // 0x000000018B1435E0-0x000000018B14386C
		private void _UpdateIcon(); // 0x000000018B14386C-0x000000018B143C8C
		private void OnEnable(); // 0x000000018B14329C-0x000000018B1432FC
	}

	public class UIRaceModuleRankController : TickableUIMono // TypeDefIndex: 54259
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
		public const string FIRST_ICON = "icon_racemodule_rank_1.png"; // Metadata: 0x02343ABC
		public const string SECOND_ICON = "icon_racemodule_rank_2.png"; // Metadata: 0x02343AD7
		public const string THIRD_ICON = "icon_racemodule_rank_3.png"; // Metadata: 0x02343AF2
		public const string FOURTH_ICON = "icon_racemodule_rank_4.png"; // Metadata: 0x02343B0D
		public const string FIFTH_ICON = "icon_racemodule_rank_5.png"; // Metadata: 0x02343B28
		private Sprite m_sprite1; // 0x90
		private Sprite m_sprite2; // 0x98
		private Sprite m_sprite3; // 0xA0
		private Sprite m_sprite4; // 0xA8
		private Sprite m_sprite5; // 0xB0
		private ERank m_rankEnum; // 0xB8
		private float m_restTime; // 0xBC
		private bool m_begin; // 0xC0
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B144E30-0x000000018B144E80 
	
		// Nested types
		public enum ERank // TypeDefIndex: 54258
		{
			None = 0,
			First = 1,
			Second = 2,
			Third = 3,
			Fourth = 4,
			Fifth = 5
		}
	
		// Constructors
		public UIRaceModuleRankController(); // 0x000000018B144DC0-0x000000018B144E30
	
		// Methods
		private void _ResetData(); // 0x000000018B144B08-0x000000018B144B68
		protected override void OnAwake(); // 0x000000018B144380-0x000000018B1444B4
		protected override void OnRelease(); // 0x000000018B1444B4-0x000000018B1445EC
		private void _ShowBaseTrans(bool show = true /* Metadata: 0x02343ABB */); // 0x000000018B144B68-0x000000018B144C24
		private void _LoadAllSprite(); // 0x000000018B1448A8-0x000000018B144B08
		private void _UpdateRaceModuleRank([IsReadOnly] in EventData<int, float> rankData); // 0x000000018B144C24-0x000000018B144DC0
		public override void Tick(float deltaTime); // 0x000000018B1445EC-0x000000018B1448A8
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class UIUdpipeConnectTracker : UIGeneralTracker // TypeDefIndex: 54262
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
		public class IconGroup // TypeDefIndex: 54260
		{
			// Fields
			public GameObject root; // 0x10
			public Image normal; // 0x18
			public Image error; // 0x20
	
			// Properties
			public bool activeSelf { get; } // 0x000000018B142084-0x000000018B1420DC 
	
			// Constructors
			public IconGroup(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void SetActiveIfNecessary(bool active); // 0x000000018B141EA4-0x000000018B141F04
			public void Switch(bool err); // 0x000000018B141F94-0x000000018B142024
		}
	
		[Serializable]
		public class StatusHintGroup // TypeDefIndex: 54261
		{
			// Fields
			public GameObject root; // 0x10
	
			// Constructors
			public StatusHintGroup(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Switch(bool outOfRange); // 0x000000018B1420DC-0x000000018B14213C
		}
	
		// Constructors
		public UIUdpipeConnectTracker(); // 0x000000018B145224-0x000000018B145274
	
		// Methods
		public void UpdateDistance(float distance); // 0x000000018B144E80-0x000000018B144F4C
		private void _ActualUpdateStatus(bool outOfRange); // 0x000000018B145124-0x000000018B145224
		public void UpdateStatus(bool outOfRange); // 0x000000018B144FDC-0x000000018B145088
		private void _ActualUpdateIcon(IconGroup img); // 0x000000018B145088-0x000000018B145124
		public void UpdateNodeType(int nodeType); // 0x000000018B144F4C-0x000000018B144FDC
	}

	public class UIVideoHelper : MonoBehaviour // TypeDefIndex: 54263
	{
		// Fields
		public CriManaMovieControllerForUI criMovieController; // 0x18
		public string videoPath; // 0x20
		public bool restartOnEnable; // 0x28
		private UIImage m_image; // 0x30
	
		// Constructors
		public UIVideoHelper(); // 0x000000018B1454A0-0x000000018B1454EC
	
		// Methods
		private void Reset(); // 0x000000018B145420-0x000000018B1454A0
		public void ResetVideo(); // 0x000000018B1453A4-0x000000018B145420
		private void Awake(); // 0x000000018B145274-0x000000018B14533C
		private void OnEnable(); // 0x000000018B14533C-0x000000018B1453A4
	}

	public class UIWaterDroneBar : TickableUIMono // TypeDefIndex: 54264
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
		public const float SLIDER_MAX_VALUE = 0.8277f; // Metadata: 0x02343B49
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
		protected override TickType tickOption { get; } // 0x000000018B146E44-0x000000018B146E94 
	
		// Constructors
		public UIWaterDroneBar(); // 0x0000000184D35770-0x0000000184D357B0
		static UIWaterDroneBar(); // 0x0000000184D38B40-0x0000000184D38BA0
	
		// Methods
		protected override void OnAwake(); // 0x000000018B145A90-0x000000018B145FE4
		private void _OnWaterDroneInfinityLiquidChanged([IsReadOnly] in EventData<bool> data); // 0x000000018B146808-0x000000018B146874
		private void _OnWaterDroneEmptyChanged([IsReadOnly] in EventData<bool> data); // 0x000000018B146674-0x000000018B1466E0
		private void _OnWaterDroneInteractiveChanged([IsReadOnly] in EventData<string> data); // 0x000000018B146874-0x000000018B1468E0
		private void _OnWaterDroneSourceTypeChanged([IsReadOnly] in EventData<WaterDroneSourceType> data); // 0x000000018B146954-0x000000018B1469C0
		private void _OnWaterDroneRelaxChanged([IsReadOnly] in EventData<bool> data); // 0x000000018B1468E0-0x000000018B146954
		[IDTag(1)]
		private void _OnWaterDroneHydrantStateChanged([IsReadOnly] in EventData<CustomAbilityComponent.WaterDroneByHydrantState> data); // 0x000000018B1467A4-0x000000018B146808
		[IDTag(0)]
		private void _OnWaterDroneHydrantStateChanged(CustomAbilityComponent.WaterDroneByHydrantState state); // 0x000000018B1466E0-0x000000018B1467A4
		protected override void OnEnable(); // 0x000000018B145FE4-0x000000018B146130
		protected override void OnRelease(); // 0x000000018B146130-0x000000018B14649C
		private void _OnWaterDroneChange(ObjectPtr<Entity> waterDronePtr); // 0x000000018B146524-0x000000018B146674
		private void _ClearWaterDrone(); // 0x000000018B14649C-0x000000018B146524
		public override void LateTick(float deltaTime); // 0x000000018B1454EC-0x000000018B145A90
		private void _UpdateState(); // 0x000000018B146B20-0x000000018B146E44
		private void _SetIconStateController(string stateName); // 0x000000018B1469C0-0x000000018B146A6C
		private void _UpdateSlider(); // 0x000000018B146A6C-0x000000018B146B20
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class WaterDroneJoystickCtrl : MonoBehaviour // TypeDefIndex: 54265
	{
		// Fields
		[SerializeField]
		private UIJoystick _joystick; // 0x18
		public float cameraInputScaleX; // 0x20
		public float cameraInputScaleY; // 0x24
	
		// Constructors
		public WaterDroneJoystickCtrl(); // 0x0000000184D848C0-0x0000000184D848F0
	}

	public class WorldUIController : TickableMono // TypeDefIndex: 54266
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
		public ulong entityLogicId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86230-0x0000000184D86240 0x0000000184D86700-0x0000000184D86710
		protected override TickType tickOption { get; } // 0x000000018B14755C-0x000000018B1475AC 
		protected bool uiActive { get; set; } // 0x000000018B1475AC-0x000000018B1475FC 0x000000018B1475FC-0x000000018B147670
	
		// Constructors
		public WorldUIController(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		public virtual void Init(Entity target, string path, ulong id, int typeSegment); // 0x000000018B147120-0x000000018B147280
		public virtual void TryGetNeedComponent(); // 0x000000018B147490-0x000000018B14755C
		public virtual void SetPos(); // 0x000000018B147330-0x000000018B147374
		public virtual void SetUIForward(); // 0x000000018B147374-0x000000018B1473B8
		public virtual void FaceToCamera(); // 0x000000018B146F30-0x000000018B1470DC
		public virtual void InitUI(); // 0x000000018B1470DC-0x000000018B147120
		public virtual void RefreshUI(); // 0x000000018B1472EC-0x000000018B147330
		public override void Tick(float deltaTime); // 0x000000018B14740C-0x000000018B147490
		public virtual void TickUI(float deltaTime); // 0x000000018B1473B8-0x000000018B14740C
		public virtual void Clear(); // 0x000000018B146E94-0x000000018B146EEC
		protected override void OnRelease(); // 0x000000018B147280-0x000000018B1472EC
		public virtual void DoRelease(); // 0x000000018B146EEC-0x000000018B146F30
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}
}

namespace Beyond.UI.Mission
{
	public class MissionHudBGSizeUpdater : TickableUIMono // TypeDefIndex: 54267
	{
		// Fields
		public RectTransform bgTransform; // 0x68
		public RectTransform objectiveList; // 0x70
		public RectTransform objectiveContent; // 0x78
		public RectTransform leftLayoutTransform; // 0x80
		public VerticalLayoutGroup leftNodeVerticalLayoutGroup; // 0x88
		public float bgSizeGetterDeltaY; // 0x90
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000184A79840-0x0000000184A79870 
	
		// Constructors
		public MissionHudBGSizeUpdater(); // 0x0000000184D830D0-0x0000000184D830F0
	
		// Methods
		public override void LateTick(float deltaTime); // 0x0000000183FE7A80-0x0000000183FE7AF0
		public void UpdateBgSize(); // 0x00000001833F7740-0x00000001833F78A0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 54044
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 54270
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D37640-0x0000000184D376B0
	
		// Methods
		public void __Gen_Wrap_0(); // 0x00000001863625A4-0x0000000186362640
		public bool __Gen_Wrap_1(object P0); // 0x00000001863632E4-0x00000001863633B4
		public void __Gen_Wrap_2(object P0, float P1); // 0x00000001866C288C-0x00000001866C296C
		public void __Gen_Wrap_3(object P0, ObjectPtr<Buff> P1, bool P2, Buff.FinishReason P3); // 0x000000018B13F208-0x000000018B13F344
		public void __Gen_Wrap_4(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
		public void __Gen_Wrap_5(object P0); // 0x00000001863633B4-0x0000000186363474
		public bool __Gen_Wrap_6(object P0, ObjectPtr<Buff> P1); // 0x000000018B14099C-0x000000018B140ABC
		public Buff __Gen_Wrap_7(object P0); // 0x000000018B14110C-0x000000018B1411E8
		public void __Gen_Wrap_8(object P0, bool P1); // 0x00000001866C2B40-0x00000001866C2C1C
		public void __Gen_Wrap_9(object P0, ObjectPtr<Buff> P1, object P2); // 0x000000018B141D20-0x000000018B141E3C
		public TickType __Gen_Wrap_10(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public RectTransform __Gen_Wrap_11(object P0); // 0x000000018B13D6E8-0x000000018B13D7C4
		public Vector3 __Gen_Wrap_12(object P0, object P1, bool P2); // 0x000000018B13D7C4-0x000000018B13D8F0
		public UIAnimationWrapper __Gen_Wrap_13(object P0); // 0x000000018B13D8F0-0x000000018B13D9E0
		public void __Gen_Wrap_14(object P0, object P1, Vector3 P2); // 0x000000018B13D9E0-0x000000018B13DB04
		public void __Gen_Wrap_15(object P0, in EventData<int, float, float> P1); // 0x000000018B13DB04-0x000000018B13DC20
		public Vector3 __Gen_Wrap_16(); // 0x000000018B13DC20-0x000000018B13DD14
		public DamageTextBase __Gen_Wrap_17(object P0, DamageTextType P1); // 0x000000018B13DD14-0x000000018B13DE0C
		public void __Gen_Wrap_18(object P0, object P1, int P2); // 0x00000001866F4838-0x00000001866F4930
		public void __Gen_Wrap_19(object P0, int P1); // 0x00000001866F3838-0x00000001866F3914
		public void __Gen_Wrap_20(object P0, UnityEngine.Color P1); // 0x000000018B13DE0C-0x000000018B13DF20
		public void __Gen_Wrap_21(object P0, object P1, object P2, Vector3? P3); // 0x000000018B13DF20-0x000000018B13E060
		public Vector2 __Gen_Wrap_22(object P0); // 0x000000018B13E060-0x000000018B13E150
		public void __Gen_Wrap_23(object P0, Vector2 P1); // 0x000000018B13E150-0x000000018B13E264
		public Vector3 __Gen_Wrap_24(object P0); // 0x000000018B13E264-0x000000018B13E378
		public Vector2 __Gen_Wrap_25(object P0, float P1, float P2); // 0x000000018B13E378-0x000000018B13E490
		public bool __Gen_Wrap_26(object P0, Vector3 P1); // 0x000000018B13E490-0x000000018B13E5B8
		public void __Gen_Wrap_27(object P0, in EventData<AbilitySystem.Modifier> P1); // 0x000000018B13E5B8-0x000000018B13E770
		public void __Gen_Wrap_28(object P0, EnergyShardType P1, bool P2); // 0x0000000189C8E3F8-0x0000000189C8E4DC
		public void __Gen_Wrap_29(object P0, in EventData<AbilitySystem, Vector3, Vector2, string, EnergyShardType> P1); // 0x000000018B13E770-0x000000018B13E894
		public void __Gen_Wrap_30(object P0, in EventData<AbilitySystem, Vector3, Vector2, string> P1); // 0x000000018B13E894-0x000000018B13E9B8
		public void __Gen_Wrap_31(object P0, in EventData<AbilitySystem, AbilitySystemForEnemyPart, PhysicalInflictionType> P1); // 0x000000018B13E9B8-0x000000018B13EAD4
		public void __Gen_Wrap_32(object P0, in EventData<bool> P1); // 0x000000018B13EAD4-0x000000018B13EBF4
		public void __Gen_Wrap_33(object P0, in EventData<Vector3, string, UnityEngine.Color> P1); // 0x000000018B13EBF4-0x000000018B13ED18
		public void __Gen_Wrap_34(object P0, in EventData<ulong, int> P1); // 0x000000018B13ED18-0x000000018B13EE3C
		public void __Gen_Wrap_35(object P0, object P1, object P2); // 0x0000000186364290-0x0000000186364388
		public DamageTextBaseV2 __Gen_Wrap_36(object P0, DamageTextType P1, object P2); // 0x000000018B13EE3C-0x000000018B13EF60
		public float __Gen_Wrap_37(object P0); // 0x00000001866C0730-0x00000001866C0800
		public Vector2 __Gen_Wrap_38(object P0, float P1, float P2, bool P3, Vector3 P4); // 0x000000018B13EF60-0x000000018B13F0D8
		public void __Gen_Wrap_39(object P0, Vector2 P1, float P2); // 0x000000018B13F0D8-0x000000018B13F208
		public HeadBarCtrl.HeadBarType __Gen_Wrap_40(ObjectPtr<AbilitySystem> P0); // 0x000000018B13F344-0x000000018B13F44C
		public bool __Gen_Wrap_41(object P0, out Vector3 P1); // 0x000000018B13F44C-0x000000018B13F58C
		public void __Gen_Wrap_42(object P0, bool P1, bool P2); // 0x0000000187199240-0x0000000187199338
		public void __Gen_Wrap_43(object P0, object P1, float P2); // 0x00000001871C15C8-0x00000001871C16C4
		public void __Gen_Wrap_44(object P0, object P1, double P2); // 0x00000001871C13A4-0x00000001871C14A0
		public void __Gen_Wrap_45(object P0, object P1, double P2, bool P3); // 0x000000018B13F58C-0x000000018B13F694
		public void __Gen_Wrap_46(object P0, in AbilitySystem.Modifier P1); // 0x000000018B13F694-0x000000018B13F84C
		public void __Gen_Wrap_47(object P0, HeadBarCtrl.HeadBarRefreshReason P1); // 0x00000001866F3838-0x00000001866F3914
		public void __Gen_Wrap_48(object P0, in EventData<string, Entity> P1); // 0x000000018B13F84C-0x000000018B13F95C
		public void __Gen_Wrap_49(object P0, in EventData<bool, DialogEnums.DialogType> P1); // 0x000000018B13F95C-0x000000018B13FA74
		public void __Gen_Wrap_50(object P0, in EventData<AbilitySystem> P1); // 0x000000018B13FA74-0x000000018B13FB98
		public void __Gen_Wrap_51(object P0, in EventData<AbilitySystem, bool> P1); // 0x000000018B13FB98-0x000000018B13FCBC
		public void __Gen_Wrap_52(object P0, in EventData<AbilitySystemForEnemyPart, bool> P1); // 0x000000018B13FCBC-0x000000018B13FDCC
		public string __Gen_Wrap_53(object P0, ObjectPtr<AbilitySystem> P1); // 0x000000018B13FDCC-0x000000018B13FEEC
		public BuffIconConfig.BuffIconStyle __Gen_Wrap_54(object P0, object P1); // 0x0000000186360610-0x00000001863606FC
		public BuffData __Gen_Wrap_55(object P0); // 0x000000018B13FEEC-0x000000018B13FFDC
		public void __Gen_Wrap_56(object P0, ObjectPtr<Buff> P1); // 0x000000018B13FFDC-0x000000018B1400F0
		public void __Gen_Wrap_57(Sprite P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_58(object P0, ObjectPtr<Buff> P1, object P2, object P3); // 0x000000018B1400F0-0x000000018B14022C
		public void __Gen_Wrap_59(object P0, int P1, bool P2); // 0x00000001866C44C0-0x00000001866C45B8
		public int __Gen_Wrap_60(object P0); // 0x0000000186360E84-0x0000000186360F54
		public ulong __Gen_Wrap_61(object P0); // 0x00000001867CDAC0-0x00000001867CDB90
		public UIBuffCell __Gen_Wrap_62(object P0, object P1); // 0x000000018B14022C-0x000000018B140338
		public void __Gen_Wrap_63(object P0, ObjectPtr<Buff> P1, bool P2); // 0x000000018B140338-0x000000018B140464
		public UIPoiseKnot __Gen_Wrap_64(object P0); // 0x000000018B140464-0x000000018B140554
		public AbilitySystem __Gen_Wrap_65(object P0); // 0x000000018B140554-0x000000018B140644
		public void __Gen_Wrap_66(object P0, object P1, bool P2, bool P3, object P4); // 0x000000018B140644-0x000000018B14075C
		public void __Gen_Wrap_67(object P0, ObjectPtr<Buff> P1, Buff.FinishReason P2); // 0x000000018B14075C-0x000000018B140888
		public void __Gen_Wrap_68(object P0, ObjectPtr<AbilitySystem> P1); // 0x000000018B140888-0x000000018B14099C
		public void __Gen_Wrap_69(object P0, double P1); // 0x00000001871BAFA8-0x00000001871BB088
		public void __Gen_Wrap_70(object P0, object P1, float P2, bool P3); // 0x000000018B0B306C-0x000000018B0B3174
		public void __Gen_Wrap_71(object P0, object P1, bool P2, int P3); // 0x0000000189CA8840-0x0000000189CA8938
		public void __Gen_Wrap_72(object P0, object P1, int P2, int P3); // 0x0000000189CBA2C4-0x0000000189CBA3BC
		public Vector3 __Gen_Wrap_73(object P0, object P1); // 0x000000018B140ABC-0x000000018B140BEC
		public Transform __Gen_Wrap_74(object P0); // 0x000000018B140BEC-0x000000018B140CC8
		public string __Gen_Wrap_75(object P0); // 0x000000018B140CC8-0x000000018B140DB8
		public void __Gen_Wrap_76(object P0, Vector3 P1); // 0x000000018B140DB8-0x000000018B140ED4
		public void __Gen_Wrap_77(object P0, UIHeadLabel.VisibleSource P1, bool P2); // 0x00000001866C44C0-0x00000001866C45B8
		public void __Gen_Wrap_78(object P0, UIHeadLabel.HeadLabelType P1, UIHeadLabel.VisibleSource P2, bool P3, bool P4); // 0x000000018B140ED4-0x000000018B140FE8
		public void __Gen_Wrap_79(object P0, in EventData<string> P1); // 0x000000018B140FE8-0x000000018B14110C
		public void __Gen_Wrap_80(bool P0); // 0x00000001866DCC44-0x00000001866DCCF0
		public void __Gen_Wrap_81(object P0, bool P1, bool P2, bool P3); // 0x000000018B0B35B4-0x000000018B0B36BC
		public string __Gen_Wrap_82(object P0, object P1, object P2); // 0x000000018B1411E8-0x000000018B141310
		public Sprite __Gen_Wrap_83(object P0, object P1, object P2); // 0x000000018B141310-0x000000018B141438
		public BattleManager __Gen_Wrap_84(object P0); // 0x000000018B141438-0x000000018B141528
		public SkillSetting __Gen_Wrap_85(object P0); // 0x000000018B141528-0x000000018B141618
		public void __Gen_Wrap_86(object P0, in EventData<float> P1); // 0x000000018B141618-0x000000018B141730
		public void __Gen_Wrap_87(object P0, object P1, int P2, bool P3); // 0x00000001866C48C8-0x00000001866C49C0
		public GameObject __Gen_Wrap_88(object P0, object P1); // 0x000000018B141730-0x000000018B14183C
		public void __Gen_Wrap_89(object P0, in EventData<int> P1); // 0x000000018B14183C-0x000000018B141950
		public void __Gen_Wrap_90(object P0, in EventData<ulong, string> P1); // 0x000000018B141950-0x000000018B141A74
		public bool __Gen_Wrap_91(object P0, out GPUIExtendedSystem P1, out GPUIHandle P2); // 0x000000018B141A74-0x000000018B141BF4
		public bool __Gen_Wrap_92(object P0, object P1, float P2); // 0x0000000187198A94-0x0000000187198B9C
		public bool __Gen_Wrap_93(object P0, object P1, object P2); // 0x0000000187195DFC-0x0000000187195F04
		public bool __Gen_Wrap_94(object P0, object P1, out float P2); // 0x000000018719628C-0x00000001871963B8
		public bool __Gen_Wrap_95(object P0, object P1, object P2, out float P3); // 0x000000018B141BF4-0x000000018B141D20
		public bool __Gen_Wrap_96(object P0, object P1); // 0x0000000181367100-0x00000001813674C0
		public bool __Gen_Wrap_97(object P0, object P1, bool P2); // 0x00000001814AB310-0x00000001814AB6E0
		public void __Gen_Wrap_98(object P0, object P1, bool P2); // 0x00000001812C0160-0x00000001812C0520
		public bool __Gen_Wrap_99(object P0, Vector2 P1); // 0x0000000182EC0350-0x0000000182EC09F0
		public bool __Gen_Wrap_100(object P0, object P1, UnityEngine.Color P2); // 0x0000000182E9E650-0x0000000182E9EDD0
		public void __Gen_Wrap_101(object P0, ulong P1, object P2, Buff.FinishReason P3, object P4, object P5); // 0x0000000182E9EDD0-0x0000000182E9F3B0
		public void __Gen_Wrap_102(object P0, ObjectPtr<Buff> P1, Buff.FinishReason P2, object P3, object P4); // 0x0000000182E9F3B0-0x0000000182E9FC40
		public void __Gen_Wrap_103(object P0, object P1, object P2, bool P3); // 0x0000000181B58F50-0x0000000181B59400
		public GPUIBuffCell __Gen_Wrap_104(object P0, object P1, object P2); // 0x0000000182E9FC40-0x0000000182EA0760
		public void __Gen_Wrap_105(object P0, ObjectPtr<Buff> P1, bool P2, object P3, object P4); // 0x0000000182EA0760-0x0000000182EA0FF0
		public void __Gen_Wrap_106(object P0, in EventData<GlobalBuff, string> P1); // 0x0000000182EA0FF0-0x0000000182EA1670
		public void __Gen_Wrap_107(object P0, in EventData<GlobalBuff, string, GlobalBuff.FinishReason> P1); // 0x0000000182EA1670-0x0000000182EA1CF0
		public GameplayMiscSetting __Gen_Wrap_108(object P0); // 0x0000000182EA1CF0-0x0000000182EA2630
		public ObjectPtr<Buff> __Gen_Wrap_109(object P0); // 0x0000000182EA2630-0x0000000182EA2F10
		public void __Gen_Wrap_110(UISpellInflictionOnCharCell P0, int P1); // 0x00000001812A0D50-0x00000001812A1020
		public ObjectPtr<Buff> __Gen_Wrap_111(object P0, object P1); // 0x0000000182EA2F10-0x0000000182EA38F0
		public UICharPassiveBase __Gen_Wrap_112(object P0, object P1); // 0x0000000182EA38F0-0x0000000182EA4320
		public void __Gen_Wrap_113(object P0, in EventData<SetLeaderReason, Entity, Entity> P1); // 0x0000000182EA4320-0x0000000182EA49A0
		public OutOfScreenTargetArrow __Gen_Wrap_114(object P0); // 0x0000000182EA49A0-0x0000000182EA52E0
		public ValueTuple<Vector2, float> __Gen_Wrap_115(object P0, Vector3 P1); // 0x0000000182EA52E0-0x0000000182EA5F80
		public bool __Gen_Wrap_116(object P0, out OutOfScreenTargetsCtrlV2.ArrowRuntimeState P1); // 0x0000000182EA5F80-0x0000000182EA69B0
		public void __Gen_Wrap_117(object P0, in EventData<ulong, uint> P1); // 0x0000000182EA69B0-0x0000000182EA7030
		public void __Gen_Wrap_118(object P0, in EventData<ulong, string, int> P1); // 0x0000000182EA7030-0x0000000182EA76B0
		public void __Gen_Wrap_119(object P0, in EventData<Skill> P1); // 0x0000000182EA76B0-0x0000000182EA7D30
		public Sprite __Gen_Wrap_120(object P0, object P1); // 0x0000000182EA7D30-0x0000000182EA8750
		public void __Gen_Wrap_121(object P0, int P1, bool P2, bool P3); // 0x00000001814A7B10-0x00000001814A7E20
		public bool __Gen_Wrap_122(object P0, bool P1); // 0x0000000182EA8750-0x0000000182EA8A40
		public void __Gen_Wrap_123(object P0, in EventData<ulong, string, EnergyShardType> P1); // 0x0000000182EA8A40-0x0000000182EA90C0
		public void __Gen_Wrap_124(object P0, in EventData<UIStyleInputValidTypeMask> P1); // 0x0000000182EA90C0-0x0000000182EA9750
		public void __Gen_Wrap_125(object P0, in EventData<CinematicTimelineManagerBase.TimelineHandle> P1); // 0x0000000182EA9750-0x0000000182EA9DD0
		public void __Gen_Wrap_126(object P0, in EventData<ForbidType, bool> P1); // 0x0000000182EA9DD0-0x0000000182EAA460
		public void __Gen_Wrap_127(object P0, int P1, int P2); // 0x0000000181992E90-0x0000000181993180
		public void __Gen_Wrap_128(object P0, int P1, int P2, byte P3); // 0x0000000182EAA460-0x0000000182EAA760
		public void __Gen_Wrap_129(object P0, int P1, int P2, int P3, int P4, byte P5); // 0x0000000182EAA760-0x0000000182EAAA90
		public byte __Gen_Wrap_130(object P0, int P1, int P2, out byte P3); // 0x0000000182EAAA90-0x0000000182EAADB0
		public void __Gen_Wrap_131(object P0, CommonTrackingPointStyleType P1, object P2); // 0x00000001812ABC50-0x00000001812ABFE0
		public void __Gen_Wrap_132(object P0, CommonTrackingPointStyleType P1); // 0x000000018133CDE0-0x000000018133D0C0
		public void __Gen_Wrap_133(object P0, Vector2 P1, float P2, bool P3, float P4, bool P5); // 0x0000000182EAADB0-0x0000000182EAB4B0
		public void __Gen_Wrap_134(object P0, PosValueState P1, bool P2, Vector2 P3, float P4, bool P5, float P6, CommonTrackMapTier P7); // 0x0000000182EAB4B0-0x0000000182EABBF0
		public int __Gen_Wrap_135(object P0, object P1); // 0x000000018137AF60-0x000000018137B310
		public CommonTrackerUpdate.CommonTrackerItem __Gen_Wrap_136(object P0); // 0x0000000182EABBF0-0x0000000182EAC520
		public bool __Gen_Wrap_137(object P0, int P1, object P2, object P3); // 0x00000001823FDBB0-0x00000001823FE020
		public void __Gen_Wrap_138(object P0, bool P1, int P2); // 0x0000000181921E20-0x0000000181922110
		public void __Gen_Wrap_139(object P0, object P1, object P2, ulong P3, int P4); // 0x0000000182EAC520-0x0000000182EAC9A0
		public string __Gen_Wrap_140(object P0, LangKey P1, object P2); // 0x0000000182EAC9A0-0x0000000182EAD720
		public void __Gen_Wrap_141(object P0, CoolerUnitTemperatureCircleUI.ETemperatureState P1); // 0x00000001812A0D50-0x00000001812A1020
		public void __Gen_Wrap_142(object P0, ref float P1, ref float P2); // 0x00000001826772F0-0x0000000182677620
		public string[] __Gen_Wrap_143(); // 0x0000000182EAD720-0x0000000182EADF60
		public bool __Gen_Wrap_144(object P0, ulong P1); // 0x00000001823C52D0-0x00000001823C55B0
		public void __Gen_Wrap_145(object P0, in EventData<string, uint, ulong> P1); // 0x0000000182EADF60-0x0000000182EAE5E0
		public GameObject __Gen_Wrap_146(object P0, object P1, object P2); // 0x0000000182EAE5E0-0x0000000182EAF0E0
		public void __Gen_Wrap_147(object P0, object P1, UnityEngine.Color P2); // 0x0000000182EAF0E0-0x0000000182EAF820
		public uint __Gen_Wrap_148(object P0, object P1, object P2); // 0x00000001813816E0-0x0000000181381B40
		public void __Gen_Wrap_149(object P0, uint P1, object P2, object P3); // 0x0000000181B51BD0-0x0000000181B52030
		public void __Gen_Wrap_150(object P0, uint P1, object P2, bool P3, object P4); // 0x0000000181D88760-0x0000000181D88BF0
		public void __Gen_Wrap_151(object P0, uint P1, UnityEngine.Color P2); // 0x0000000182EAF820-0x0000000182EAFE90
		public void __Gen_Wrap_152(object P0, bool P1, float P2, object P3, object P4); // 0x0000000182EAFE90-0x0000000182EB0320
		public void __Gen_Wrap_153(object P0, float P1, bool P2); // 0x0000000182E82400-0x0000000182E85650
		public void __Gen_Wrap_154(PointerEventData P0); // 0x00000001812A5970-0x00000001812A5C30
		public void __Gen_Wrap_155(float P0); // 0x0000000181494100-0x00000001814942F0
		public void __Gen_Wrap_156(object P0, float P1, float P2, float P3, bool P4); // 0x00000001822A7A00-0x00000001822A7D40
		public void __Gen_Wrap_157(object P0, float P1, float P2); // 0x0000000182D4D1A0-0x0000000182D4D4A0
		public void __Gen_Wrap_158(object P0, float P1, float P2, object P3); // 0x0000000182EB0320-0x0000000182EB06F0
		public void __Gen_Wrap_159(object P0, bool P1, bool P2, bool P3, ForgeIronTemperatureCircleUI.ETemperatureState P4); // 0x0000000182EB06F0-0x0000000182EB0A20
		public Dictionary<string, RegionMap3DCfg> __Gen_Wrap_160(object P0); // 0x0000000182EB0A20-0x0000000182EB1360
		public void __Gen_Wrap_161(object P0, object P1, Vector3 P2, object P3); // 0x0000000182EB1360-0x0000000182EB1B70
		public bool __Gen_Wrap_162(Vector2 P0, float P1, UnityEngine.Rect P2); // 0x0000000182EB1B70-0x0000000182EB24B0
		public void __Gen_Wrap_163(object P0, RegionMapShowType P1, object P2, object P3, float P4); // 0x0000000182EB24B0-0x0000000182EB2930
		public Transform __Gen_Wrap_164(object P0, object P1); // 0x0000000182EB2930-0x0000000182EB3350
		public Vector3 __Gen_Wrap_165(object P0, object P1, object P2, object P3); // 0x0000000182EB3350-0x0000000182EB3EE0
		public RegionMap3DCfg __Gen_Wrap_166(object P0, object P1); // 0x0000000182EB3EE0-0x0000000182EB4900
		public TweenerCore<Quaternion, Quaternion, NoOptions> __Gen_Wrap_167(object P0, float P1, object P2); // 0x0000000182EB4900-0x0000000182EB5340
		public MaterialPropertyBlock __Gen_Wrap_168(); // 0x0000000182EB5340-0x0000000182EB5B80
		public void __Gen_Wrap_169(object P0, in EventData<long, long> P1); // 0x0000000182EB5B80-0x0000000182EB6200
		public bool __Gen_Wrap_170(); // 0x0000000182EB6200-0x0000000182EB63E0
		public MapStaticElementConditionExpression __Gen_Wrap_171(object P0); // 0x0000000182EB63E0-0x0000000182EB6D20
		public List<RaycastResult> __Gen_Wrap_172(object P0); // 0x0000000182EB6D20-0x0000000182EB7650
		public LuaPanel __Gen_Wrap_173(object P0); // 0x0000000182EB7650-0x0000000182EB7F80
		public void __Gen_Wrap_174(object P0, int P1, int P2, int P3, int P4); // 0x0000000181DFDB20-0x0000000181DFDE30
		public UnityEngine.Rect __Gen_Wrap_175(float P0, float P1, float P2, float P3); // 0x0000000182EB7F80-0x0000000182EB8830
		public List<Vector2> __Gen_Wrap_176(object P0, Vector2 P1, Vector2 P2, float P3); // 0x0000000182EB8830-0x0000000182EB9600
		public Vector2 __Gen_Wrap_177(object P0, Vector2 P1); // 0x0000000182EB9600-0x0000000182EBA260
		public Vector2 __Gen_Wrap_178(object P0, Vector2 P1, object P2, object P3); // 0x0000000182EBA260-0x0000000182EBB050
		public Graphic __Gen_Wrap_179(object P0); // 0x0000000182EBB050-0x0000000182EBB980
		public string __Gen_Wrap_180(object P0, int P1, int P2, int P3, int P4); // 0x0000000182EBB980-0x0000000182EBC360
		public string __Gen_Wrap_181(object P0, int P1, int P2); // 0x0000000182EBC360-0x0000000182EBCCD0
		public void __Gen_Wrap_182(object P0, object P1, long P2, float P3); // 0x000000018253AE10-0x000000018253B1D0
		public void __Gen_Wrap_183(object P0, Vector3 P1, ulong P2); // 0x0000000182EBCCD0-0x0000000182EBD360
		public void __Gen_Wrap_184(object P0, int P1, object P2, object P3); // 0x0000000181B51BD0-0x0000000181B52030
		public void __Gen_Wrap_185(object P0, bool P1, object P2); // 0x00000001812918C0-0x0000000181291C60
		public void __Gen_Wrap_186(object P0, long P1); // 0x00000001812F70E0-0x00000001812F73B0
		public void __Gen_Wrap_187(object P0, int P1, uint P2); // 0x0000000181992E90-0x0000000181993180
		public void __Gen_Wrap_188(object P0, int P1, int P2, int P3); // 0x0000000181A13EB0-0x0000000181A141B0
		public void __Gen_Wrap_189(object P0, long P1, float P2); // 0x0000000182EBD360-0x0000000182EBD650
		public void __Gen_Wrap_190(object P0, Vector2 P1, float P2, bool P3); // 0x0000000182EBD650-0x0000000182EBDD10
		public void __Gen_Wrap_191(object P0, ulong P1, int P2, int P3, int P4); // 0x0000000182EBDD10-0x0000000182EBE030
		public void __Gen_Wrap_192(object P0, PowerAutoConnectStatus P1); // 0x00000001812A0D50-0x00000001812A1020
		public TravelPoleBrain.TravelPoleIcon __Gen_Wrap_193(object P0); // 0x0000000181298AE0-0x0000000181298DA0
		public GameObject __Gen_Wrap_194(object P0); // 0x0000000182EBE030-0x0000000182EBE960
		public void __Gen_Wrap_195(object P0, TravelPoleBrain.TravelPoleIcon P1); // 0x00000001812A0D50-0x00000001812A1020
		public TravelPoleBrain.TravelPoleStatus __Gen_Wrap_196(object P0); // 0x0000000181298AE0-0x0000000181298DA0
		public void __Gen_Wrap_197(object P0, TravelPoleBrain.TravelPoleStatus P1); // 0x00000001812A0D50-0x00000001812A1020
		public void __Gen_Wrap_198(object P0, in EventData<int, float> P1); // 0x0000000182EBE960-0x0000000182EBEFE0
		public void __Gen_Wrap_199(object P0, in EventData<WaterDroneSourceType> P1); // 0x0000000182EBEFE0-0x0000000182EBF660
		public void __Gen_Wrap_200(object P0, CustomAbilityComponent.WaterDroneByHydrantState P1); // 0x00000001812A0D50-0x00000001812A1020
		public void __Gen_Wrap_201(object P0, in EventData<CustomAbilityComponent.WaterDroneByHydrantState> P1); // 0x0000000182EBF660-0x0000000182EBFCE0
		public void __Gen_Wrap_202(object P0, ObjectPtr<Entity> P1); // 0x0000000182EBFCE0-0x0000000182EC0350
	}

	public class ILFixInterfaceBridge : AnonymousStorey // TypeDefIndex: 54271
	{
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018B147670-0x000000018B147704
	
		// Methods
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 54272
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018B1478EC-0x000000018B147950
		public static bool IsPatched(int id); // 0x0000000182F45C30-0x0000000182F45C80
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018B1477A8-0x000000018B147874
		public object CreateWrapper(int id); // 0x000000018B147874-0x000000018B1478EC
		public object InitWrapperArray(int len); // 0x000000018B147950-0x000000018B147D90
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018B147704-0x000000018B1477A8
	}

	public enum IDMAP0 // TypeDefIndex: 54273
	{
		Beyond-PoolCore-ListPoolInitializer_UI_Gameplay_Beyond-InitializeAtRuntime0 = 0,
		Beyond-PoolCore-ListPoolInitializer_UI_Gameplay_Beyond-Initialize0 = 1,
		Beyond-UI-UICharPassiveBase-get_listenBuffIconChange0 = 2,
		Beyond-UI-UICharPassiveBase-OnCharPassiveNumChanged0 = 3,
		Beyond-UI-UICharPassiveBase-OnBuffIconChange0 = 4,
		Beyond-UI-UICharPassiveBase-OnBound0 = 5,
		Beyond-UI-UICharPassiveBase-OnBeforeUnbind0 = 6,
		Beyond-UI-UICharPassiveBase-Bind0 = 7,
		Beyond-UI-UICharPassiveBase-Unbind0 = 8,
		Beyond-UI-UICharPassiveBase-OnDestroy0 = 9,
		Beyond-UI-UICharPassiveCounter-OnCharPassiveNumChanged0 = 10,
		Beyond-UI-UICharPassiveLiino-get_listenBuffIconChange0 = 11,
		Beyond-UI-UICharPassiveLiino-Awake0 = 12,
		Beyond-UI-UICharPassiveLiino-_OnLateTick0 = 13,
		Beyond-UI-UICharPassiveLiino-_GetActiveBuffForDisplay0 = 14,
		Beyond-UI-UICharPassiveLiino-_IsBuffValid0 = 15,
		Beyond-UI-UICharPassiveLiino-_SetProgress0 = 16,
		Beyond-UI-UICharPassiveLiino-_SetTickRunning0 = 17,
		Beyond-UI-UICharPassiveLiino-_UpdateDecoThresholds0 = 18,
		Beyond-UI-UICharPassiveLiino-_CheckLoopThreshold0 = 19,
		Beyond-UI-UICharPassiveLiino-OnDestroy0 = 20,
		Beyond-UI-UICharPassiveLiino-OnBound0 = 21,
		Beyond-UI-UICharPassiveLiino-_ForceIdle0 = 22,
		Beyond-UI-UICharPassiveLiino-_TryTrackBuff0 = 23,
		Beyond-UI-UICharPassiveLiino-_RefreshDisplay0 = 24,
		Beyond-UI-UICharPassiveLiino-_InitDecoThresholds0 = 26,
		Beyond-UI-UICharPassiveLiino-OnBeforeUnbind0 = 27,
		Beyond-UI-UICharPassiveLiino-OnBuffIconChange0 = 28,
		Beyond-UI-UICharPassiveLizhiyan-OnCharPassiveNumChanged0 = 29,
		Beyond-UI-UICharPassiveMultiStates-OnCharPassiveNumChanged0 = 30,
		Beyond-UI-UICharPassiveZhuangfy-OnCharPassiveNumChanged0 = 31,
		Beyond-UI-LiinoRandomLikeEffect-get_tickOption0 = 32,
		Beyond-UI-LiinoRandomLikeEffect-OnAwake0 = 33,
		Beyond-UI-LiinoRandomLikeEffect-_CacheHideCallbacks0 = 34,
		Beyond-UI-LiinoRandomLikeEffect-PlayEffect0 = 37,
		Beyond-UI-LiinoRandomLikeEffect-_SelectArea0 = 38,
		Beyond-UI-LiinoRandomLikeEffect-_SelectHalf0 = 39,
		Beyond-UI-LiinoRandomLikeEffect-_GetRandomPointInArea0 = 40,
		Beyond-UI-LiinoRandomLikeEffect-_GetNextAvailableBig0 = 41,
		Beyond-UI-LiinoRandomLikeEffect-_PlayEffectAt0 = 42,
		Beyond-UI-LiinoRandomLikeEffect-_GetNextAvailableSmall0 = 43,
		Beyond-UI-LiinoRandomLikeEffect-Tick0 = 44,
		Beyond-UI-LiinoRandomLikeEffect-OnHide0 = 45,
		Beyond-UI-LiinoRandomLikeEffect-_ClearAnims0 = 46,
		Beyond-UI-ComboSpecialNodeBase-OnAssignData0 = 47,
		Beyond-UI-ComboSpecialNodeBase-OnReady0 = 48,
		Beyond-UI-ComboSpecialNodeBase-OnTick0 = 49,
		Beyond-UI-ComboSpecialNodeBase-OnCast0 = 50,
		Beyond-UI-ComboSpecialNodeBase-OnRemove0 = 51,
		Beyond-UI-ComboSpecialNodeRingQte-get_needTick0 = 52,
		Beyond-UI-ComboSpecialNodeRingQte-OnAssignData0 = 53,
		Beyond-UI-ComboSpecialNodeRingQte-_OnComboSkillRingQte0 = 54,
		Beyond-UI-ComboSpecialNodeRingQte-OnCast0 = 55,
		Beyond-UI-ComboSpecialNodeRingQte-_Reset0 = 56,
		Beyond-UI-ComboSpecialNodeRingQte-OnRemove0 = 57,
		Beyond-UI-ComboSpecialNodeRingQte-OnTick0 = 58,
		Beyond-UI-ComboSpecialNodeRingQte-OnRelease0 = 59,
		Beyond-UI-DamageTextCtrl-get_tickOption0 = 60,
		Beyond-UI-DamageTextCtrl-get_outOfScreenPos0 = 61,
		Beyond-UI-DamageTextCtrl-OnCreate0 = 62,
		Beyond-UI-DamageTextCtrl-_InstantiateTextInstance0 = 63,
		Beyond-UI-DamageTextCtrl-_RecycleTextInstance0 = 64,
		Beyond-UI-DamageTextBase-Clear0 = 66,
		Beyond-UI-DamageTextCtrl-_OnHpChanged0 = 67,
		Beyond-UI-DamageTextCtrl-_CreateTextInstance0 = 68,
		Beyond-UI-DamageTextBase-SetText0 = 69,
		Beyond-UI-DamageTextBase-SetText1 = 70,
		Beyond-UI-DamageTextBase-SetColor0 = 71,
		Beyond-UI-DamageTextBase-SetFollowTarget0 = 72,
		Beyond-UI-DamageTextBase-get_uiOffset0 = 73,
		Beyond-UI-DamageTextBase-SetUIOffset0 = 74,
		Beyond-UI-DamageTextBase-get_worldPosition0 = 75,
		Beyond-UI-DamageTextBase-get_isFollowingTransform0 = 76,
		Beyond-UI-DamageTextDamageBase-PlayAnimation0 = 77,
		Beyond-UI-DamageTextCtrl-_GetRandomTextOffset0 = 78,
		Beyond-UI-DamageTextCtrl-_IsTextPosValid0 = 79,
		Beyond-UI-DamageTextBase-PlayAnimation0 = 80,
		Beyond-UI-DamageTextCtrl-_OnIgniteBuffText0 = 81,
		Beyond-UI-DamageTextIgniteBuff-SetUIState0 = 82,
		Beyond-UI-DamageTextIgniteBuff-SetTextAndDuplication0 = 83,
		Beyond-UI-DamageTextCtrl-_OnImmuneText0 = 84,
		Beyond-UI-DamageTextBase-SetText2 = 85,
		Beyond-UI-DamageTextCtrl-_OnPhysicalInflictionApplied0 = 86,
		Beyond-UI-DamageTextCtrl-_OnSquadInFightChanged0 = 87,
		Beyond-UI-DamageTextCtrl-_OnCreateFlowText0 = 88,
		Beyond-UI-DamageTextCtrl-_OnCharLevelUp0 = 89,
		Beyond-UI-DamageTextCtrl-OnClose0 = 91,
		Beyond-UI-DamageTextCtrl-DebugChangeImpl0 = 92,
		Beyond-UI-DamageTextCtrl-OnShow0 = 93,
		Beyond-UI-DamageTextCtrl-OnHide0 = 94,
		Beyond-UI-DamageTextCtrl-Tick0 = 95,
		Beyond-UI-DamageTextCtrlV2-get_tickOption0 = 96,
		Beyond-UI-DamageTextCtrlV2-get_outOfScreenPos0 = 97,
		Beyond-UI-DamageTextCtrlV2-OnCreate0 = 98,
		Beyond-UI-DamageTextCtrlV2-_OnHpChanged0 = 99,
		Beyond-UI-DamageTextCtrlV2-_CreateTextInstance0 = 100,
		Beyond-UI-DamageTextBaseV2-Assign0 = 101,
		Beyond-UI-DamageTextBaseV2-get_showDuration0 = 102,
		Beyond-UI-DamageTextBaseV2-SetText0 = 103,
		Beyond-UI-DamageTextBaseV2-SetText1 = 104,
		Beyond-UI-DamageTextBaseV2-get_textNodeAlpha0 = 105,
		Beyond-UI-DamageTextBaseV2-SetColor0 = 106,
		Beyond-UI-DamageTextBaseV2-SetFollowTarget0 = 107,
		Beyond-UI-DamageTextBaseV2-get_worldPosition0 = 108,
		Beyond-UI-DamageTextBaseV2-get_isFollowingTransform0 = 109,
		Beyond-UI-DamageTextBaseV2-get_uiOffset0 = 110,
		Beyond-UI-DamageTextBaseV2-SetUIOffset0 = 111,
		Beyond-UI-DamageTextBaseV2-PlayAnimation0 = 112,
		Beyond-UI-DamageTextCtrlV2-_UseWorldSpaceRandomArea0 = 113,
		Beyond-UI-DamageTextCtrlV2-_GetRandomTextOffset0 = 114,
		Beyond-UI-DamageTextCtrlV2-_IsTextPosValid0 = 115,
		Beyond-UI-DamageTextBaseV2-DestroyDisplay0 = 116,
		Beyond-UI-DamageTextCtrlV2-_OnIgniteBuffText0 = 117,
		Beyond-UI-DamageTextBaseV2-SetText2 = 118,
		Beyond-UI-DamageTextCtrlV2-_OnImmuneText0 = 119,
		Beyond-UI-DamageTextCtrlV2-_OnPhysicalInflictionApplied0 = 120,
		Beyond-UI-DamageTextCtrlV2-_OnSquadInFightChanged0 = 121,
		Beyond-UI-DamageTextCtrlV2-_OnCreateFlowText0 = 122,
		Beyond-UI-DamageTextCtrlV2-_OnCharLevelUp0 = 123,
		Beyond-UI-DamageTextCtrlV2-_RecycleTextInstance0 = 124,
		Beyond-UI-DamageTextBaseV2-Clear0 = 126,
		Beyond-UI-DamageTextCtrlV2-OnClose0 = 128,
		Beyond-UI-DamageTextCtrlV2-DebugChangeImpl0 = 129,
		Beyond-UI-DamageTextCtrlV2-OnShow0 = 130,
		Beyond-UI-DamageTextCtrlV2-OnHide0 = 131,
		Beyond-UI-DamageTextCtrlV2-Tick0 = 132,
		Beyond-UI-DamageTextBaseV2-Tick0 = 133,
		Beyond-UI-DamageTextBaseV2-_UpdatePosition0 = 134,
		Beyond-UI-DamageTextBaseV2-get_isActive0 = 135,
		Beyond-UI-DamageTextBase-get_tickOption0 = 136,
		Beyond-UI-DamageTextBase-OnAwake0 = 137,
		Beyond-UI-DamageTextBase-OnRelease0 = 138,
		Beyond-UI-DamageTextBase-TailLateTick0 = 139,
		Beyond-UI-DamageTextBase-_UpdatePosition0 = 140,
		Beyond-UI-DamageTextBaseV2-OnRelease0 = 141,
		Beyond-UI-DamageTextBlock-SetColor0 = 142,
		Beyond-UI-DamageTextCriticalLevel0-SetColor0 = 143,
		Beyond-UI-DamageTextCriticalLevel1-SetColor0 = 144,
		Beyond-UI-DamageTextCriticalLevel1-PlayAnimation0 = 145,
		Beyond-UI-DamageTextIgniteBuff-OnAwake0 = 146,
		Beyond-UI-DamageTextIgniteBuff-OnRelease0 = 147,
		Beyond-UI-DamageTextNormalLevel1-PlayAnimation0 = 148,
		Beyond-UI-FootBarDashCell-SetIndex0 = 149,
		Beyond-UI-FootBarDashCell-SetDashCount0 = 150,
		Beyond-UI-FootBarDashCell-StartPlayNotEnoughAnim0 = 151,
		Beyond-UI-FootBarDashCell-StopPlayNotEnoughAnim0 = 152,
		Beyond-UI-HeadBarCtrl-get_tickOption0 = 153,
		Beyond-UI-HeadBarCtrl-get_forceHide0 = 154,
		Beyond-UI-HeadBarCtrl-OnCreate0 = 155,
		Beyond-UI-HeadBarCtrl-_OnInteractNpc0 = 156,
		Beyond-UI-HeadBarCtrl-_SetInDialog0 = 157,
		Beyond-UI-HeadBarCtrl-_RefreshHeadBar0 = 158,
		Beyond-UI-HeadBarCtrl-_GetHeadBarType0 = 160,
		Beyond-UI-UIAbilityTargetFollower-SetTarget0 = 161,
		Beyond-UI-UIAbilityTargetFollower-get_actualVisible0 = 162,
		Beyond-UI-UIAbilityTargetFollower-_TryRefreshFollowTransform0 = 163,
		Beyond-UI-UIAbilityTargetFollower-_TryRefreshHeightFollowTransform0 = 164,
		Beyond-UI-UIAbilityTargetFollower-_UpdateSelfTransform0 = 165,
		Beyond-UI-UIAbilityTargetFollower-_CalculatePosition0 = 166,
		Beyond-UI-UIAbilityTargetFollower-TryGetOriginalFollowPos0 = 167,
		Beyond-UI-UIAbilityTargetFollower-_SetDistanceVisible0 = 168,
		Beyond-UI-UIAbilityTargetFollower-OnActualVisibleChange0 = 169,
		Beyond-UI-UIAbilityTargetFollower-get_needUpdateTransform0 = 171,
		Beyond-UI-UIAbilityTargetFollower-_UpdatePosition0 = 172,
		Beyond-UI-UIAbilityTargetFollower-_UpdateScale0 = 173,
		Beyond-UI-UIHeadBarFollower-ShowModifierAfterSetTarget0 = 174,
		Beyond-UI-UIHeadBar-ShowModifierAfterSetTarget0 = 175,
		Beyond-UI-UIHeadBar-_SetImageFill0 = 176,
		Beyond-UI-UIHeadBar-_OnHpChange0 = 177,
		Beyond-UI-UIHeadBar-_CalculateHpChangeDisplay0 = 178,
		Beyond-UI-UIHeadBarFollower-OnAfterHpBroken0 = 181,
		Beyond-UI-UIHeadBar-OnAfterHpBroken0 = 182,
		Beyond-UI-UIHeadBarFollower-OnBeforeHpBroken0 = 184,
		Beyond-UI-UIHeadBar-OnBeforeHpBroken0 = 185,
		Beyond-UI-HeadBarCtrl-_OnDialogStart0 = 186,
		Beyond-UI-HeadBarCtrl-_OnDialogFinish0 = 187,
		Beyond-UI-HeadBarCtrl-_OnAddHeadBar0 = 188,
		Beyond-UI-HeadBarCtrl-_OnRemoveHeadBar0 = 189,
		Beyond-UI-HeadBarCtrl-_OnHeadBarShowConfigChanged0 = 190,
		Beyond-UI-HeadBarCtrl-_OnHpChanged0 = 191,
		Beyond-UI-HeadBarCtrl-_OnEnemyPartEnableChanged0 = 192,
		Beyond-UI-HeadBarCtrl-_OnBountyEnemyChanged0 = 193,
		Beyond-UI-HeadBarCtrl-_RefreshHeadBuff0 = 194,
		Beyond-UI-HeadBarCtrl-_FindBountyBuffIcon0 = 195,
		Beyond-UI-UIHeadBuff-SetBuffIcon0 = 196,
		Beyond-UI-HeadBarCtrl-_PrewarmHeadBar0 = 197,
		Beyond-UI-UIHeadBarFollower-OnPreWarm0 = 198,
		Beyond-UI-UIHeadBar-OnPreWarm0 = 199,
		Beyond-UI-UIBuffNode-OnPreWarm0 = 200,
		Beyond-UI-UIBuffNode-_OnFirstInit0 = 201,
		Beyond-UI-UIBuffCell-Clear0 = 202,
		Beyond-UI-HeadBarCtrl-OnClose0 = 205,
		Beyond-UI-HeadBarCtrl-OnShow0 = 206,
		Beyond-UI-UIHeadBarFollower-Refresh0 = 207,
		Beyond-UI-UIHeadBar-Refresh0 = 208,
		Beyond-UI-UIPoiseBar-Refresh0 = 209,
		Beyond-UI-UIBuffNode-Refresh0 = 210,
		Beyond-UI-UIBuffNode-BuffCellGroup-ClearAllBuffCells0 = 211,
		Beyond-UI-UIBuffNode-BuffCellGroup-RemoveBuffCell0 = 212,
		Beyond-UI-UIBuffNode-_IsBuffIconInThisNode0 = 213,
		Beyond-UI-UIBuffNode-_AddBuffIconInternal0 = 214,
		Beyond-UI-UIBuffNode-_GetIconStyle0 = 216,
		Beyond-UI-UIBuffCell-get_anim0 = 217,
		Beyond-UI-UIBuffCell-Init0 = 218,
		Beyond-UI-UIBuffCell-VisualInit0 = 221,
		Beyond-UI-UIBuffCell-SetBuffIcon0 = 222,
		Beyond-UI-UIBuffCell-get_buffData0 = 223,
		Beyond-UI-UIBuffCell-SetStackElementActive0 = 224,
		Beyond-UI-UIBuffCell-SetWarningState0 = 225,
		Beyond-UI-UIBuffCell-SetVisible0 = 226,
		Beyond-UI-UIBuffCell-DataInit0 = 228,
		Beyond-UI-UIBuffCell-SetStackCount0 = 230,
		Beyond-UI-UIBuffNode-_SetBuffCellSiblingInOrder0 = 233,
		Beyond-UI-UIBuffCell-get_orderPriority0 = 234,
		Beyond-UI-UIBuffCell-get_buffInstanceUid0 = 235,
		Beyond-UI-UIBuffNode-_DealWithBuffCellVisible0 = 236,
		Beyond-UI-UIBuffNode-BuffCellGroup-CreateBuffCell0 = 237,
		Beyond-UI-UIVigilanceBar-Refresh0 = 242,
		Beyond-UI-HeadBarCtrl-OnHide0 = 243,
		Beyond-UI-HeadBarCtrl-LateTick0 = 244,
		Beyond-UI-HeadBarCtrl-_UpdateSurroundingEnemies0 = 245,
		Beyond-UI-HeadBarCtrl-_UpdateHeadBar0 = 246,
		Beyond-UI-UIHeadBarFollower-SetHeadBarVisible0 = 247,
		Beyond-UI-HeadBarCtrl-_UpdateLevelInfoBar0 = 248,
		Beyond-UI-HeadBarCtrl-_UpdateVigilanceBar0 = 251,
		Beyond-UI-HeadBarCtrl-_UpdateTacticalItemBar0 = 252,
		Beyond-UI-UITacticalItemBar-IsTacticalItemActive0 = 255,
		Beyond-UI-UIHeadBar-OnDestroy0 = 256,
		Beyond-UI-UIHeadBar-SetTarget0 = 257,
		Beyond-UI-UIPoiseBar-Init0 = 258,
		Beyond-UI-UIPoiseKnot-SetVisible0 = 259,
		Beyond-UI-UIPoiseBar-_ClearPoiseKnot0 = 260,
		Beyond-UI-UIPoiseBar-_TryInitPoiseKnot0 = 261,
		Beyond-UI-UIPoiseBar-_CreatePoiseKnot0 = 262,
		Beyond-UI-UIPoiseBar-get_hidePoiseBar0 = 263,
		Beyond-UI-UIPoiseBar-get_realPoise0 = 264,
		Beyond-UI-UIPoiseBar-get_owner0 = 265,
		Beyond-UI-UIPoiseBar-get_maxPoise0 = 266,
		Beyond-UI-UIBuffNode-Init0 = 267,
		Beyond-UI-UIBuffNode-_UnregisterAbilityBuffEvent0 = 268,
		Beyond-UI-UIBuffNode-OnBuffIconChange0 = 269,
		Beyond-UI-UIBuffNode-_OnAddBuff0 = 270,
		Beyond-UI-UIBuffNode-_OnRemoveBuff0 = 271,
		Beyond-UI-UIBuffNode-_RemoveBuffIconInternal0 = 272,
		Beyond-UI-UIBuffCell-BeforePlayOutAnim0 = 277,
		Beyond-UI-UIBuffNode-_OnBuffEnhanceChanged0 = 281,
		Beyond-UI-UIBuffNode-_OnBuffIgnite0 = 282,
		Beyond-UI-UIBuffCell-OnBuffIgnite0 = 283,
		Beyond-UI-UIBuffNode-_RegisterAbilityBuffEvent0 = 284,
		Beyond-UI-UIHeadBar-_OnForceSetHp0 = 285,
		Beyond-UI-UIHeadBar-_OnPoiseChange0 = 286,
		Beyond-UI-UIPoiseBar-OnPoiseChange0 = 287,
		Beyond-UI-UIPoiseKnot-KnotBreak0 = 288,
		Beyond-UI-UIPoiseBar-_CalculatePoiseChangeDisplay0 = 289,
		Beyond-UI-UIHeadBar-_OnMultiTimeWeaknessActivate0 = 290,
		Beyond-UI-UIWeaknessNode-SetTotalCellNum0 = 291,
		Beyond-UI-UIHeadBar-_OnWeaknessCountChanged0 = 292,
		Beyond-UI-UIWeaknessNode-SetCurrentCellNum0 = 293,
		Beyond-UI-UIHeadBar-_OnMainTargetChanged0 = 294,
		Beyond-UI-UIHeadBar-Clear0 = 295,
		Beyond-UI-UIPoiseBar-Clear0 = 296,
		Beyond-UI-UIBuffNode-Clear0 = 297,
		Beyond-UI-UIHeadBar-_UpdateHpDisplay0 = 298,
		Beyond-UI-UIHeadBar-_UpdateScale0 = 299,
		Beyond-UI-UIHeadBar-UpdateData0 = 300,
		Beyond-UI-UIPoiseBar-UpdatePoiseBar0 = 301,
		Beyond-UI-UIPoiseBar-_UpdatePoiseDisplay0 = 302,
		Beyond-UI-UIHeadBarFollower-get_actualVisible0 = 303,
		Beyond-UI-UIHeadBarFollower-SetTarget0 = 304,
		Beyond-UI-UIHeadBarFollower-_UpdateGuideLine0 = 305,
		Beyond-UI-UIHeadBarFollower-Clear0 = 306,
		Beyond-UI-UIAbilityTargetFollower-Clear0 = 307,
		Beyond-UI-UIHeadBarFollower-UpdateData0 = 308,
		Beyond-UI-UIHeadBarFollower-TryGetOriginalFollowPos0 = 309,
		Beyond-UI-UIAbilityTargetFollower-GetAdjustedHeightOffset0 = 310,
		Beyond-UI-UIHeadBuff-TryGetOriginalFollowPos0 = 311,
		Beyond-UI-UIHeadLabel-get_tickOption0 = 312,
		Beyond-UI-UIHeadLabel-get_iconHolder0 = 313,
		Beyond-UI-UIHeadLabel-_OnSubRootsCollectionChanged0 = 314,
		Beyond-UI-UIHeadLabel-get_headLabelIcon0 = 315,
		Beyond-UI-UIHeadLabel-set_headLabelIcon0 = 316,
		Beyond-UI-UIHeadLabel-SetVisibleDirty0 = 317,
		Beyond-UI-UIHeadLabel-get_missionHeadLabelIcon0 = 318,
		Beyond-UI-UIHeadLabel-set_missionHeadLabelIcon0 = 319,
		Beyond-UI-UIHeadLabel-_TryInitRootData0 = 320,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-Init0 = 321,
		Beyond-UI-UIHeadLabel-_UpdateVisible0 = 322,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-get_realVisible0 = 323,
		Beyond-UI-UIHeadLabel-SetSubRootVisible0 = 324,
		Beyond-UI-UIHeadLabel-HeadLabelRootVisibleData-UpdateVisible0 = 325,
		Beyond-UI-UIHeadLabel-SetTarget0 = 326,
		Beyond-UI-UIHeadLabel-_BindTargetEvent0 = 328,
		Beyond-UI-UIHeadLabel-_OnNpcVisibleChanged0 = 329,
		Beyond-UI-UIHeadLabel-_TryUpdateVisibleCallback0 = 331,
		Beyond-UI-UIHeadLabel-_UpdateFloatingUIVisibleCallback0 = 332,
		Beyond-UI-UIHeadLabel-_UpdatePos0 = 335,
		Beyond-UI-UIHeadLabel-_BindMissionTracking0 = 336,
		Beyond-UI-UIHeadLabel-_OnMissionTypeIconChanged0 = 337,
		Beyond-UI-UIHeadLabel-_ClearVisibleCallback0 = 339,
		Beyond-UI-UIHeadLabel-_ClearFloatingUIVisibleCallback0 = 340,
		Beyond-UI-UIHeadLabel-Clear0 = 341,
		Beyond-UI-UIHeadLabel-_RefreshVisible0 = 342,
		Beyond-UI-UIHeadLabel-ClearEmojis0 = 343,
		Beyond-UI-UIHeadLabel-_UnBindMissionTracking0 = 344,
		Beyond-UI-UIHeadLabel-_UnBindTargetEvent0 = 345,
		Beyond-UI-UIHeadLabel-SetActive0 = 346,
		Beyond-UI-UIHeadLabel-_TryUpdateVisible0 = 347,
		Beyond-UI-UIHeadLabel-OnAwake0 = 348,
		Beyond-UI-UIHeadLabel-LateTick0 = 349,
		Beyond-UI-UIHeadLabel-OnEnable0 = 350,
		Beyond-UI-UIHeadLabel-OnDisable0 = 351,
		Beyond-UI-UIHeadLabel-OnRelease0 = 352,
		Beyond-UI-UILvInfoBar-SetTarget0 = 353,
		Beyond-UI-UILvInfoBar-TryGetOriginalFollowPos0 = 354,
		Beyond-UI-UITacticalItemBar-SetTarget0 = 355,
		Beyond-UI-UIPanelBase-LoadSprite0 = 356,
		Beyond-UI-UIPanelBase-GetSpritePath0 = 357,
		Beyond-UI-UITacticalItemBar-Clear0 = 358,
		Beyond-UI-UITacticalItemBar-UpdateData0 = 359,
		Beyond-UI-UIVigilanceBar-get_actualVisible0 = 360,
		Beyond-UI-UIVigilanceBar-get_needUpdateTransform0 = 361,
		Beyond-UI-UIVigilanceBar-SetTarget0 = 362,
		Beyond-UI-UIVigilanceBar-Clear0 = 363,
		Beyond-UI-UIVigilanceBar-UpdateData0 = 364,
		Beyond-UI-UIVigilanceBar-_UpdateVigilanceNode0 = 365,
		Beyond-UI-UIVigilanceBar-_SetVigilanceActive0 = 366,
		Beyond-UI-UIVigilanceBar-TryGetOriginalFollowPos0 = 369,
		Beyond-UI-UIWeaknessNode-Awake0 = 370,
		Beyond-UI-AtbNode-get_tickOption0 = 371,
		Beyond-UI-AtbNode-get_battleManager0 = 372,
		Beyond-UI-AtbNode-get_skillSetting0 = 373,
		Beyond-UI-AtbNode-OnCreate0 = 374,
		Beyond-UI-AtbNode-OnInFightChanged0 = 375,
		Beyond-UI-AtbNode-_RefreshAtbShowing0 = 376,
		Beyond-UI-AtbNode-_OnAtbCellOutAnimCallback0 = 377,
		Beyond-UI-AtbNode-CheckAtbLoopAnim0 = 378,
		Beyond-UI-AtbNode-OnGainAtb0 = 379,
		Beyond-UI-AtbNode-OnClose0 = 382,
		Beyond-UI-AtbNode-LateTick0 = 383,
		Beyond-UI-ComboSkillHint-Init0 = 384,
		Beyond-UI-ComboSkillPanel-CastComboSkill0 = 385,
		Beyond-UI-ComboSkillPanel-_ResortSiblingIndex0 = 388,
		Beyond-UI-BattleControllerInputController-GetControllerIndicatorState0 = 390,
		Beyond-UI-ComboSkillHint-OnCast0 = 391,
		Beyond-UI-ComboSkillPanel-_CheckUpdate0 = 392,
		Beyond-UI-ComboSkillHint-OnReady0 = 393,
		Beyond-UI-ComboSkillHint-OnTick0 = 394,
		Beyond-UI-ComboSkillHint-OnRemove0 = 395,
		Beyond-UI-ComboSkillHint-Release0 = 396,
		Beyond-UI-ComboSkillHint-AssignData0 = 397,
		Beyond-UI-UIPanelBase-LoadGameObject0 = 398,
		Beyond-UI-ComboSkillPanel-get_tickOption0 = 399,
		Beyond-UI-ComboSkillPanel-OnCreate0 = 400,
		Beyond-UI-ComboSkillPanel-_UnbindListeners0 = 401,
		Beyond-UI-ComboSkillPanel-_OnComboSkillReady0 = 402,
		Beyond-UI-ComboSkillPanel-_OnComboSkillRemove0 = 403,
		Beyond-UI-ComboSkillPanel-_RemoveComboSkill0 = 404,
		Beyond-UI-ComboSkillPanel-_OnBattleTeamChanged0 = 407,
		Beyond-UI-ComboSkillPanel-_OnComboSkillClearAll0 = 408,
		Beyond-UI-ComboSkillPanel-_OnActiveSkillDataRefreshed0 = 411,
		Beyond-UI-ComboSkillPanel-OnShow0 = 413,
		Beyond-UI-ComboSkillPanel-OnRelease0 = 414,
		Beyond-UI-UIPanelBase-OnRelease0 = 415,
		Beyond-UI-ComboSkillPanel-PreTick0 = 416,
		Beyond-UI-GPUIAttachedBuffCell-get_defaultBuffIconNodeName0 = 417,
		Beyond-UI-GPUIAttachedBuffCell-DataInit0 = 418,
		Beyond-UI-GPUIBuffCell-DataInit0 = 419,
		Beyond-UI-GPUIAttachedBuffCell-OnTick0 = 420,
		Beyond-UI-GPUIBuffCell-OnTick0 = 421,
		Beyond-UI-GPUIBuffCell-_UpdateAnimationComplete0 = 422,
		Beyond-UI-GPUIBuffCell-get_canUpdateVisual0 = 423,
		Beyond-UI-GPUIBuffCell-TrySetImageFillAmount0 = 424,
		Beyond-UI-GPUIBuffCell-_TryResolveGpui0 = 425,
		Beyond-UI-GPUIBuffCell-TryEnsureGPUIInstance0 = 426,
		Beyond-UI-GPUIBuffCell-_TryResolveGPUIProxy0 = 427,
		Beyond-UI-GPUIAttachedBuffCell-BeforePlayOutAnim0 = 428,
		Beyond-UI-GPUIBuffCell-BeforePlayOutAnim0 = 429,
		Beyond-UI-GPUIAttachedBuffCell-SetStackCount0 = 430,
		Beyond-UI-GPUIBuffCell-SetStackCount0 = 431,
		Beyond-UI-GPUIBuffCell-TrySetText0 = 432,
		Beyond-UI-GPUIBuffCell-PlayWithAnimation0 = 433,
		Beyond-UI-GPUIBuffCell-ClearAnimation0 = 434,
		Beyond-UI-GPUIBuffCell-TryStartRootAnimation0 = 435,
		Beyond-UI-GPUIAttachedBuffCell-_PlayConsumeAnimations0 = 436,
		Beyond-UI-GPUIBuffCell-TryStartSubrootAnimation0 = 437,
		Beyond-UI-GPUIAttachedBuffCell-OnBuffIgnite0 = 438,
		Beyond-UI-GPUIAttachedBuffCell-SetBuffIcon0 = 439,
		Beyond-UI-GPUIBuffCell-SetBuffIcon0 = 440,
		Beyond-UI-GPUIBuffCell-get_defaultBuffIconNodeName0 = 441,
		Beyond-UI-GPUIBuffCell-_ResolveNodeName0 = 442,
		Beyond-UI-GPUIBuffCell-TrySetSprite0 = 443,
		Beyond-UI-GPUIBuffCell-_LogSetBuffIconFailure0 = 444,
		Beyond-UI-GPUIBuffCell-ClearBuffIconOverride0 = 445,
		Beyond-UI-GPUIAttachedBuffCell-ClearBuffIconOverride0 = 446,
		Beyond-UI-GPUIAttachedBuffCell-SetStackElementActive0 = 447,
		Beyond-UI-GPUIBuffCell-SetStackElementActive0 = 448,
		Beyond-UI-GPUIBuffCell-TrySetNodeVisibility1 = 449,
		Beyond-UI-GPUIBuffCell-TrySetNodeVisibility0 = 450,
		Beyond-UI-GPUIBuffCell-TrySetNodeRotZ0 = 451,
		Beyond-UI-GPUIBuffCell-get_isVisualInited0 = 452,
		Beyond-UI-GPUIBuffCell-get_buffData0 = 453,
		Beyond-UI-GPUIBuffCell-get_orderPriority0 = 454,
		Beyond-UI-GPUIBuffCell-get_buffInstanceUid0 = 455,
		Beyond-UI-GPUIBuffCell-SetSyncManager0 = 456,
		Beyond-UI-GPUIBuffCell-Init0 = 457,
		Beyond-UI-GPUIBuffCell-VisualInit0 = 461,
		Beyond-UI-GPUIBuffCell-_TryCreateGPUIInstance0 = 462,
		Beyond-UI-GPUIBuffCell-SetWarningState0 = 463,
		Beyond-UI-GPUIBuffCell-SetVisible0 = 464,
		Beyond-UI-GPUIBuffCell-_TrySetRootScale0 = 465,
		Beyond-UI-GPUIBuffCell-Clear0 = 468,
		Beyond-UI-GPUIBuffCell-_TryDestroyGpuiInstance0 = 470,
		Beyond-UI-GPUIBuffCell-SetBuffIconOverrideActive0 = 471,
		Beyond-UI-GPUIBuffCell-OnBuffIgnite0 = 472,
		Beyond-UI-GPUIBuffCell-PlayInAnimation0 = 473,
		Beyond-UI-GPUIBuffCell-PlayOutAnimation0 = 474,
		Beyond-UI-GPUIBuffCell-PlayStrongInAnimation0 = 475,
		Beyond-UI-GPUIBuffCell-PlayIgniteOutAnimation0 = 476,
		Beyond-UI-GPUIBuffCell-SampleToInAnimationEnd0 = 477,
		Beyond-UI-GPUIBuffCell-TrySetColor0 = 478,
		Beyond-UI-GPUIBuffNode-get_tickOption0 = 479,
		Beyond-UI-GPUIBuffNode-_OnFirstInit0 = 480,
		Beyond-UI-GPUIBuffNode-OnPreWarm0 = 481,
		Beyond-UI-GPUIBuffNode-Init0 = 482,
		Beyond-UI-GPUIBuffNode-_UnregisterAbilityBuffEvent0 = 483,
		Beyond-UI-GPUIBuffNode-OnBuffIconChange0 = 484,
		Beyond-UI-GPUIBuffNode-_IsBuffIconInThisNode0 = 485,
		Beyond-UI-GPUIBuffNode-_OnAddBuff0 = 486,
		Beyond-UI-GPUIBuffNode-_OnRemoveBuff0 = 487,
		Beyond-UI-GPUIBuffNode-_RemoveBuffIconInternal0 = 488,
		Beyond-UI-GPUIBuffNode-_GetIconStyle0 = 489,
		Beyond-UI-GPUIBuffNode-_RemoveStackBuffIconInternal0 = 490,
		Beyond-UI-GPUIBuffNode-_RemoveSingleBuffCell0 = 493,
		Beyond-UI-GPUIBuffNode-BuffCellGroup-RemoveBuffCell0 = 496,
		Beyond-UI-GPUIBuffNode-_DealWithBuffCellVisible0 = 497,
		Beyond-UI-GPUIBuffNode-_OnBuffEnhanceChanged0 = 499,
		Beyond-UI-GPUIBuffNode-_OnBuffIgnite0 = 500,
		Beyond-UI-GPUIBuffNode-_RegisterAbilityBuffEvent0 = 501,
		Beyond-UI-GPUIBuffNode-Refresh0 = 502,
		Beyond-UI-GPUIBuffNode-BuffCellGroup-ClearAllBuffCells0 = 503,
		Beyond-UI-GPUIBuffNode-_AddBuffIconInternal0 = 504,
		Beyond-UI-GPUIBuffNode-_SetBuffCellSiblingInOrder0 = 507,
		Beyond-UI-GPUIBuffNode-_PlayInAnimation0 = 508,
		Beyond-UI-GPUIBuffNode-_IsBuffCellVisibleByLimit0 = 509,
		Beyond-UI-GPUIBuffNode-_AddStackBuffIconInternal0 = 510,
		Beyond-UI-GPUIBuffNode-BuffCellGroup-CreateBuffCell0 = 514,
		Beyond-UI-GPUIBuffNode-Clear0 = 517,
		Beyond-UI-GPUIBuffNode-TailLateTick0 = 518,
		Beyond-UI-GPUIBuffNode-OnRelease0 = 519,
		Beyond-UI-GPUILifeTimeBuffCell-VisualInit0 = 520,
		Beyond-UI-GPUILifeTimeBuffCell-_UpdateFillAmount0 = 521,
		Beyond-UI-GPUILifeTimeBuffCell-OnTick0 = 522,
		Beyond-UI-GPUILifeTimeBuffCell-SetWarningState0 = 523,
		Beyond-UI-HpBarComboNode-Awake0 = 524,
		Beyond-UI-HpBarComboNode-_OnGlobalBuffStart0 = 525,
		Beyond-UI-HpBarComboNode-_RefreshComboCount0 = 526,
		Beyond-UI-HpBarComboNode-_AnimOutCallback0 = 527,
		Beyond-UI-HpBarComboNode-_AnimInCallback0 = 528,
		Beyond-UI-HpBarComboNode-_OnGlobalBuffFinish0 = 529,
		Beyond-UI-HpBarComboNode-OnDestroy0 = 530,
		Beyond-UI-MainCharHpBar-get_tickOption0 = 531,
		Beyond-UI-MainCharHpBar-OnAwake0 = 532,
		Beyond-UI-MainCharHpBar-_OnMainCharChange0 = 533,
		Beyond-UI-MainCharHpBar-_ProcessOnMainCharChange0 = 534,
		Beyond-UI-MainCharHpBar-_ClearMainChar0 = 535,
		Beyond-UI-MainCharHpBar-_OnHpChange0 = 536,
		Beyond-UI-MainCharHpBar-_SetHpFillAmount0 = 537,
		Beyond-UI-MainCharHpBar-_CalculateHpChangeDisplay0 = 538,
		Beyond-UI-UIHudFadeController-SetLocalNeedShow0 = 539,
		Beyond-UI-UIHudFadeController-_CheckNeedShow0 = 540,
		Beyond-UI-UIHudFadeController-get_needShow0 = 541,
		Beyond-UI-UIHudFadeBase-get_globalNeedShow0 = 542,
		Beyond-UI-UIHudFadeController-get_setting0 = 543,
		Beyond-UI-UIHudFadeController-InformShow0 = 544,
		Beyond-UI-MainCharHpBar-_OnTakeDamage0 = 545,
		Beyond-UI-MainCharHpBar-_OnCharPassiveNumChanged0 = 546,
		Beyond-UI-MainCharHpBar-_OnBuffIconChange0 = 547,
		Beyond-UI-MainCharHpBar-_BlinkBuffIcon0 = 548,
		Beyond-UI-MainCharHpBar-_RefreshBuffChangeCharHpBarVfx0 = 552,
		Beyond-UI-MainCharHpBar-_IsCharHpBarVfxBuffValid0 = 553,
		Beyond-UI-MainCharHpBar-_HpVfxOutAnimCallback0 = 554,
		Beyond-UI-MainCharHpBar-_GetLatestValidCharHpBarVfxBuffPtrFromCache0 = 555,
		Beyond-UI-MainCharHpBar-_OnBuffEnhanceChanged0 = 556,
		Beyond-UI-MainCharHpBar-_ClearBuffNode1 = 557,
		Beyond-UI-MainCharHpBar-_ClearBuffNode0 = 558,
		Beyond-UI-UISpellInflictionOnCharNode-OnClear0 = 559,
		Beyond-UI-UISpellInflictionOnCharNode-_UnregisterAbilityBuffEvent0 = 560,
		Beyond-UI-UISpellInflictionOnCharNode-_OnBuffIconChange0 = 561,
		Beyond-UI-UISpellInflictionOnCharCell-SetCellActive0 = 564,
		Beyond-UI-UISpellInflictionOnCharNode-get_isInCcDungeon0 = 565,
		Beyond-UI-UISpellInflictionOnCharNode-_OnBuffEnhanceChanged0 = 566,
		Beyond-UI-MainCharHpBar-_RebuildCharHpBarVfxBuffCache0 = 569,
		Beyond-UI-MainCharHpBar-_InitCurrentBuffNode0 = 570,
		Beyond-UI-MainCharHpBar-_EnsureBuffNodePreWarmed0 = 571,
		Beyond-UI-UISpellInflictionOnCharNode-OnInit0 = 572,
		Beyond-UI-UISpellInflictionOnCharNode-_OnFirstInit0 = 573,
		Beyond-UI-UISpellInflictionOnCharNode-_RegisterAbilityBuffEvent0 = 574,
		Beyond-UI-UISpellInflictionOnCharNode-_DoRefreshUI0 = 575,
		Beyond-UI-MainCharHpBar-_SelectUltimateBuff0 = 581,
		Beyond-UI-MainCharHpBar-_GetUltimateBuffForAbility0 = 582,
		Beyond-UI-MainCharHpBar-_IsUltimateBuffValid0 = 583,
		Beyond-UI-MainCharHpBar-_SetUltimateBuff0 = 584,
		Beyond-UI-MainCharHpBar-_UltimateBuffProgressOutAnimCallback0 = 585,
		Beyond-UI-MainCharHpBar-_GetOrCreateCharPassiveBase0 = 586,
		Beyond-UI-MainCharHpBar-_OnTeamChanged0 = 587,
		Beyond-UI-MainCharHpBar-_RebuildUltimateBuffTracking0 = 588,
		Beyond-UI-MainCharHpBar-_OnProgressBarBuffChange0 = 589,
		Beyond-UI-MainCharHpBar-_OnMainCharHpActiveChange0 = 590,
		Beyond-UI-MainCharHpBar-SetGPUIBuffSync0 = 591,
		Beyond-UI-MainCharHpBar-SetGPUIBuffMode0 = 592,
		Beyond-UI-MainCharHpBar-OnEnable0 = 593,
		Beyond-UI-MainCharHpBar-_CheckHpBarShowing0 = 594,
		Beyond-UI-MainCharHpBar-_SetHpBarShowing0 = 595,
		Beyond-UI-MainCharHpBar-OnRelease0 = 597,
		Beyond-UI-MainCharHpBar-OnShow0 = 598,
		Beyond-UI-MainCharHpBar-OnHide0 = 599,
		Beyond-UI-MainCharHpBar-LateTick0 = 600,
		Beyond-UI-MainCharHpBar-_UpdateHpDisplay0 = 601,
		Beyond-UI-UISpellInflictionOnCharNode-OnTick0 = 602,
		Beyond-UI-OutOfScreenTargetsCtrl-get_tickOption0 = 603,
		Beyond-UI-OutOfScreenTargetsCtrl-OnCreate0 = 604,
		Beyond-UI-OutOfScreenTargetsCtrl-_OnEnemyCastSkillToMainChar0 = 605,
		Beyond-UI-OutOfScreenTargetsCtrl-OnClose0 = 606,
		Beyond-UI-OutOfScreenTargetsCtrl-OnShow0 = 607,
		Beyond-UI-OutOfScreenTargetsCtrl-DebugChangeImpl0 = 608,
		Beyond-UI-OutOfScreenTargetsCtrl-LateTick0 = 609,
		Beyond-UI-OutOfScreenTargetsCtrl-_CreateOneArrow0 = 610,
		Beyond-UI-OutOfScreenTargetsCtrl-_InitArrowCallbacks0 = 611,
		Beyond-UI-OutOfScreenTargetsCtrl-_ScreenPosToUIPos0 = 616,
		Beyond-UI-OutOfScreenTargetsCtrlV2-get_tickOption0 = 617,
		Beyond-UI-OutOfScreenTargetsCtrlV2-OnCreate0 = 618,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_OnEnemyCastSkillToMainChar0 = 619,
		Beyond-UI-OutOfScreenTargetsCtrlV2-OnClose0 = 620,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_RecycleAll0 = 621,
		Beyond-UI-OutOfScreenTargetsCtrlV2-OnShow0 = 622,
		Beyond-UI-OutOfScreenTargetsCtrlV2-OnHide0 = 623,
		Beyond-UI-OutOfScreenTargetsCtrlV2-DebugChangeImpl0 = 624,
		Beyond-UI-OutOfScreenTargetsCtrlV2-LateTick0 = 625,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_UpdateRuntimeStates0 = 626,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_ScheduleDestroy0 = 627,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_CreateArrowState0 = 628,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_RestartVisibleState0 = 629,
		Beyond-UI-OutOfScreenTargetsCtrlV2-_ScreenPosToUIPos0 = 630,
		Beyond-UI-SkillButton-get_tickOption0 = 631,
		Beyond-UI-SkillButton-get_skillSetting0 = 632,
		Beyond-UI-SkillButton-OnAwake0 = 633,
		Beyond-UI-SkillButton-OnEnable0 = 636,
		Beyond-UI-SkillButton-Close0 = 637,
		Beyond-UI-SkillButton-_OnOtherPressSkillButtonStart0 = 638,
		Beyond-UI-SkillButton-PressHandler-OnOtherPressSkillButtonStart0 = 639,
		Beyond-UI-SkillButton-OnUspChange0 = 640,
		Beyond-UI-SkillButton-_OnBuffIconChange0 = 641,
		Beyond-UI-SkillButton-_RefreshNormalProgressBuff0 = 642,
		Beyond-UI-SkillButton-_RefreshUltimateProgressBuff0 = 643,
		Beyond-UI-SkillButton-_OnCharPotentialUnlock0 = 644,
		Beyond-UI-SkillButton-RefreshSkillButton0 = 645,
		Beyond-UI-SkillButton-_InitSkillData0 = 646,
		Beyond-UI-SkillButton-_UpdateMainUI0 = 647,
		Beyond-UI-SkillButton-_RefreshDeadState0 = 648,
		Beyond-UI-SkillButton-OnPressCancelled0 = 649,
		Beyond-UI-SkillButton-_RefreshNormalSkillCd0 = 650,
		Beyond-UI-SkillButton-_CheckNormalSkillHighlight0 = 651,
		Beyond-UI-SkillButton-_RefreshUltimateSkillCd0 = 652,
		Beyond-UI-SkillButton-_SetPressFillActive0 = 653,
		Beyond-UI-SkillButton-_OnSkillButtonActiveConfigChanged0 = 654,
		Beyond-UI-SkillButton-_SetGoActive0 = 655,
		Beyond-UI-SkillButton-_OnCharSkillChange0 = 656,
		Beyond-UI-SkillButton-_OnCharUltimateSkillChange0 = 657,
		Beyond-UI-SkillButton-PressHandler-OnUltimateSkillChanged0 = 658,
		Beyond-UI-SkillButton-_OnSkillUpgradeSuccess0 = 659,
		Beyond-UI-SkillButton-_OnActiveSkillDataRefreshed0 = 660,
		Beyond-UI-SkillButton-_OnSkillCdChanged0 = 661,
		Beyond-UI-SkillButton-_OnInputActionKeyUpdated0 = 662,
		Beyond-UI-SkillButton-_UpdateLongPressKeyHint0 = 663,
		Beyond-UI-UIPanelBase-LoadSpriteWithOutFormat0 = 664,
		Beyond-UI-SkillButton-_OnKeyboardTypeChanged0 = 665,
		Beyond-UI-SkillButton-FirstTimeInit0 = 666,
		Beyond-UI-SkillButton-OnPressSkillStart0 = 667,
		Beyond-UI-SkillButton-OnPressSkillEnd0 = 668,
		Beyond-UI-SkillButton-OnPressUltimateSkillStart0 = 669,
		Beyond-UI-SkillButton-OnCharacterDie0 = 670,
		Beyond-UI-SkillButton-_SetPressFillAmount0 = 671,
		Beyond-UI-SkillButton-CastSkill0 = 672,
		Beyond-UI-SkillButton-ToggleControllerSkillIndicator0 = 673,
		Beyond-UI-SkillButton-SetEmpty0 = 674,
		Beyond-UI-SkillButton-ClearBtnClick0 = 675,
		Beyond-UI-SkillButton-PressHandler-get_skillSetting0 = 676,
		Beyond-UI-SkillButton-PressHandler-get_needUpdate0 = 677,
		Beyond-UI-SkillButton-PressHandlerLongPress-get_needUpdate0 = 678,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressStart0 = 679,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnUpdate0 = 681,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressEnd0 = 682,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnPressCancel0 = 683,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnOtherPressSkillButtonStart0 = 684,
		Beyond-UI-SkillButton-PressHandlerLongPress-OnUltimateSkillChanged0 = 685,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-get_needUpdate0 = 686,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressStart0 = 687,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnUpdate0 = 688,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressEnd0 = 689,
		Beyond-UI-SkillButton-PressHandlerIndividualUltimate-OnPressCancel0 = 690,
		Beyond-UI-SkillButton-PressHandlerDrag-get_needUpdate0 = 691,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressStart0 = 692,
		Beyond-UI-SkillButton-PressHandlerDrag-OnUpdate0 = 693,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressEnd0 = 694,
		Beyond-UI-SkillButton-PressHandlerDrag-OnPressCancel0 = 695,
		Beyond-UI-SkillButton-PressHandlerDrag-OnUltimateSkillChanged0 = 696,
		Beyond-UI-SquadIcon-get_tickOption0 = 697,
		Beyond-UI-SquadIcon-OnAwake0 = 698,
		Beyond-UI-SquadIcon-SetGPUIBuffSync0 = 699,
		Beyond-UI-SquadIcon-SetGPUIBuffMode0 = 700,
		Beyond-UI-SquadIcon-_ClearBuffNode0 = 701,
		Beyond-UI-SquadIcon-_EnsureBuffNodePreWarmed0 = 702,
		Beyond-UI-SquadIcon-_InitCurrentBuffNode0 = 703,
		Beyond-UI-SquadIcon-FirstTimeInit0 = 704,
		Beyond-UI-SquadIcon-OnPressCharIconStart0 = 705,
		Beyond-UI-SquadIcon-CanSwitchToCenter0 = 706,
		Beyond-UI-SquadIcon-_OnMainCharChange0 = 709,
		Beyond-UI-SquadIcon-_OnIgniteBuffText0 = 710,
		Beyond-UI-SquadIcon-Close0 = 711,
		Beyond-UI-SquadIcon-_OnHpChange0 = 712,
		Beyond-UI-SquadIcon-_OnBuffIconChange0 = 714,
		Beyond-UI-SquadIcon-_RefreshBuffChangeCharHpBarVfx0 = 715,
		Beyond-UI-SquadIcon-_IsCharHpBarVfxBuffValid0 = 716,
		Beyond-UI-SquadIcon-_HpVfxOutAnimCallback0 = 717,
		Beyond-UI-SquadIcon-_GetLatestValidCharHpBarVfxBuffPtrFromCache0 = 718,
		Beyond-UI-SquadIcon-_OnCharPassiveNumChanged0 = 719,
		Beyond-UI-SquadIcon-InitSquadIcon0 = 720,
		Beyond-UI-SquadIcon-SetDeadState0 = 721,
		Beyond-UI-SquadIcon-_RebuildCharHpBarVfxBuffCache0 = 722,
		Beyond-UI-SquadIcon-_UpdateComboSkillIcon0 = 723,
		Beyond-UI-SquadIcon-_TryShowLevelUpAnim0 = 726,
		Beyond-UI-SquadIcon-_SetLevelText0 = 728,
		Beyond-UI-SquadIcon-OnTacticalItemChange0 = 729,
		Beyond-UI-TacticalDotCell-Init0 = 730,
		Beyond-UI-SquadIcon-_MustUpdate0 = 731,
		Beyond-UI-SquadIcon-LateTick0 = 732,
		Beyond-UI-SquadIcon-_UpdateIconAlpha0 = 733,
		Beyond-UI-SquadIcon-_UpdateTacticalItemStatus0 = 734,
		Beyond-UI-TacticalDotCell-SetDotActive0 = 735,
		Beyond-UI-TacticalDotCell-SetDotUsedUp0 = 737,
		Beyond-UI-SquadIcon-SetEmpty0 = 738,
		Beyond-UI-SquadIcon-ToggleIndicator0 = 739,
		Beyond-UI-SquadIcon-InformKeyHint0 = 740,
		Beyond-UI-SquadIcon-OnLevelChange0 = 741,
		Beyond-UI-SquadIcon-OnTeamSwitchUnlocked0 = 742,
		Beyond-UI-UIAbnormalBuffCell-OnTick0 = 743,
		Beyond-UI-UIBuffCell-OnTick0 = 744,
		Beyond-UI-UIAbnormalBuffCell-VisualInit0 = 745,
		Beyond-UI-UIAbnormalBuffCell-SetWarningState0 = 746,
		Beyond-UI-UIAttachedBuffCell-DataInit0 = 747,
		Beyond-UI-UIAttachedBuffCell-OnTick0 = 748,
		Beyond-UI-UIAttachedBuffCell-BeforePlayOutAnim0 = 749,
		Beyond-UI-UIAttachedBuffCell-SetBuffIcon0 = 750,
		Beyond-UI-UIAttachedBuffCell-SetStackElementActive0 = 751,
		Beyond-UI-UIAttachedBuffCell-SetStackCount0 = 752,
		Beyond-UI-UIAttachedBuffCell-OnBuffIgnite0 = 754,
		Beyond-UI-UIBuffNode-get_tickOption0 = 755,
		Beyond-UI-UIBuffNode-TailLateTick0 = 756,
		Beyond-UI-UIBuffNode-OnRelease0 = 757,
		Beyond-UI-UILifeTimeBuffCell-OnTick0 = 758,
		Beyond-UI-UILifeTimeBuffCell-SetWarningState0 = 759,
		Beyond-UI-UIHudFadeConsoleController-Awake0 = 760,
		Beyond-UI-UIHudFadeConsoleController-_OnFadeHud0 = 761,
		Beyond-UI-UIHudFadeConsoleController-_CheckNeedShow0 = 762,
		Beyond-UI-UIHudFadeConsoleController-_OnInformShow0 = 764,
		Beyond-UI-UIHudFadeConsoleController-InformShow0 = 765,
		Beyond-UI-UIHudFadeConsoleController-OnDestroy0 = 767,
		Beyond-UI-UIHudFadeConsoleController-OnShow0 = 768,
		Beyond-UI-UIHudFadeController-Awake0 = 769,
		Beyond-UI-UIHudFadeController-_OnFadeHud0 = 770,
		Beyond-UI-UIHudFadeController-_OnInformShow0 = 771,
		Beyond-UI-UIHudFadeController-OnDestroy0 = 772,
		Beyond-UI-UIHudFadeTouchSkill-Awake0 = 773,
		Beyond-UI-UIHudFadeTouchSkill-_OnFadeHud0 = 774,
		Beyond-UI-UIHudFadeTouchSkill-_CheckNeedShow0 = 775,
		Beyond-UI-UIHudFadeTouchSkill-_OnInformShow0 = 777,
		Beyond-UI-UIHudFadeTouchSkill-InformShow0 = 778,
		Beyond-UI-UIHudFadeTouchSkill-OnDestroy0 = 781,
		Beyond-UI-UIHudFadeTouchSkill-OnShow0 = 782,
		Beyond-UI-BattleControllerInputController-Create0 = 783,
		Beyond-UI-BattleControllerInputController-DestroyInstance0 = 785,
		Beyond-UI-BattleControllerInputController-Dispose0 = 786,
		Beyond-UI-BattleControllerInputController-_OnInputActionKeyUpdated0 = 787,
		Beyond-UI-BattleControllerInputController-_RefreshCachedKeys0 = 789,
		Beyond-UI-BattleControllerInputController-_RefreshUltimateMode2Available0 = 791,
		Beyond-UI-BattleControllerInputController-_UnregisterAllCombos0 = 792,
		Beyond-UI-BattleControllerInputController-CheckNormalAttackBtn0 = 793,
		Beyond-UI-BattleControllerInputController-TryPressControllerIndicatorWhenSkillButtonJustPressed0 = 794,
		Beyond-UI-BattleControllerInputController-_RegisterAllCombos0 = 795,
		Beyond-UI-UIAbilityTargetFollower-get_tickOption0 = 798,
		Beyond-UI-UIAbilityTargetFollower-OnAwake0 = 799,
		Beyond-UI-UIAbilityTargetFollower-TailLateTick0 = 800,
		Beyond-UI-UIAbilityTargetFollower-UpdateData0 = 801,
		Beyond-UI-UILockAim-OnAwake0 = 802,
		Beyond-UI-UILockAim-_RefreshTarget0 = 803,
		Beyond-UI-UILockAim-_OnLockTargetFromAutoToManual0 = 804,
		Beyond-UI-UILockAim-OnRelease0 = 805,
		Beyond-UI-UILockAim-Start0 = 806,
		Beyond-UI-UILockAim-UpdateData0 = 807,
		Beyond-UI-UIMainCharFootBar-get_tickOption0 = 808,
		Beyond-UI-UIMainCharFootBar-OnAwake0 = 809,
		Beyond-UI-UIMainCharFootBar-_OnDashFailed0 = 810,
		Beyond-UI-UIMainCharFootBar-_OnMainCharChange0 = 811,
		Beyond-UI-UIMainCharFootBar-_ProcessOnMainCharChange0 = 812,
		Beyond-UI-UIMainCharFootBar-_OnInteractNpc0 = 813,
		Beyond-UI-UIMainCharFootBar-_SetInDialog0 = 814,
		Beyond-UI-UIMainCharFootBar-_OnDialogStart0 = 815,
		Beyond-UI-UIMainCharFootBar-_OnDialogFinish0 = 816,
		Beyond-UI-UIMainCharFootBar-OnEnable0 = 817,
		Beyond-UI-UIMainCharFootBar-OnRelease0 = 818,
		Beyond-UI-UIMainCharFootBar-LateTick0 = 819,
		Beyond-UI-UIMainCharFootBar-_OnDashCountChanged0 = 820,
		Beyond-UI-UIMainCharFootBar-_OnOutAnimCallback0 = 821,
		Beyond-UI-UIMainCharFootBarArc-get_tickOption0 = 822,
		Beyond-UI-UIMainCharFootBarArc-OnAwake0 = 823,
		Beyond-UI-UIMainCharFootBarArc-_OnOutAnimCallback0 = 824,
		Beyond-UI-UIMainCharFootBarArc-_OnDashFailed0 = 825,
		Beyond-UI-UIMainCharFootBarArc-_OnMainCharChange0 = 826,
		Beyond-UI-UIMainCharFootBarArc-_ProcessOnMainCharChange0 = 827,
		Beyond-UI-UIMainCharFootBarArc-_OnInteractNpc0 = 828,
		Beyond-UI-UIMainCharFootBarArc-_SetInDialog0 = 829,
		Beyond-UI-UIMainCharFootBarArc-_RefreshDisableState0 = 830,
		Beyond-UI-UIMainCharFootBarArc-_OnDialogStart0 = 831,
		Beyond-UI-UIMainCharFootBarArc-_OnDialogFinish0 = 832,
		Beyond-UI-UIMainCharFootBarArc-_OnPlayCutscene0 = 833,
		Beyond-UI-UIMainCharFootBarArc-_OnFinishCutscene0 = 834,
		Beyond-UI-UIMainCharFootBarArc-_OnForbidSystemChanged0 = 835,
		Beyond-UI-UIMainCharFootBarArc-OnEnable0 = 836,
		Beyond-UI-UIMainCharFootBarArc-OnRelease0 = 837,
		Beyond-UI-UIMainCharFootBarArc-TailLateTick0 = 838,
		Beyond-UI-UIMainCharFootBarArc-_OnDashCountChanged0 = 839,
		Beyond-UI-UIMainCharFootBarArc-SetUIDisable0 = 840,
		Beyond-UI-UIWeakLockAim-OnAwake0 = 841,
		Beyond-UI-UIWeakLockAim-_OnMainTargetChanged0 = 842,
		Beyond-UI-UIWeakLockAim-_RefreshTarget0 = 843,
		Beyond-UI-UIWeakLockAim-Start0 = 844,
		Beyond-UI-UIWeakLockAim-OnRelease0 = 845,
		Beyond-UI-BlueprintPreviewHelper-SetSize0 = 846,
		Beyond-UI-BlueprintPreviewHelper-AddGridValue0 = 847,
		Beyond-UI-BlueprintPreviewHelper-BatchAddGridValue0 = 848,
		Beyond-UI-BlueprintPreviewHelper-GetGridValue0 = 849,
		Beyond-UI-CommonTrackerNodeComp-ShowStyleType0 = 850,
		Beyond-UI-UICampfireTracker-UpdateImage0 = 851,
		Beyond-UI-UICommonTracker-UpdateImage0 = 852,
		Beyond-UI-CommonTrackerNodeComp-PlayOutAnimation0 = 853,
		Beyond-UI-CommonTrackerNodeComp-UpdatePosition0 = 854,
		Beyond-UI-UIBlackboxTracker-UpdatePosition0 = 855,
		Beyond-UI-UICampfireTracker-UpdatePosition0 = 856,
		Beyond-UI-UICommonLevelTracker-UpdatePosition0 = 857,
		Beyond-UI-UICommonTracker-UpdatePosition0 = 858,
		Beyond-UI-CommonTrackerUpdate-get__inFactoryTopView0 = 859,
		Beyond-UI-CommonTrackerUpdate-UpdateCommonTrackers0 = 860,
		Beyond-UI-CommonTrackerUpdate-_FindTrackIndexByKey0 = 861,
		Beyond-UI-CommonTrackerUpdate-_InitTrackInfoByIndex0 = 862,
		Beyond-UI-CommonTrackerUpdate-_CreateNewMissionTracker0 = 863,
		Beyond-UI-CommonTrackerUpdate-_DeleteInvalidTracker0 = 864,
		Beyond-UI-CommonTrackerUpdate-_HideTrackerGo0 = 865,
		Beyond-UI-CommonTrackerUpdate-_ShowTrackerGo0 = 866,
		Beyond-UI-CommonTrackerUpdate-AllTrackersPlayOutAnimation0 = 867,
		Beyond-UI-CoolerUnitProgressBarUI-get_tickOption0 = 868,
		Beyond-UI-CoolerUnitProgressBarUI-Init0 = 869,
		Beyond-UI-WorldUIController-Init0 = 870,
		Beyond-UI-WorldUIController-TryGetNeedComponent0 = 872,
		Beyond-UI-WorldUIController-SetUIForward0 = 873,
		Beyond-UI-WorldUIController-SetPos0 = 874,
		Beyond-UI-CoolerUnitProgressBarUI-SetUIForward0 = 875,
		Beyond-UI-CoolerUnitProgressBarUI-SetPos0 = 876,
		Beyond-UI-CoolerUnitProgressBarUI-TickUI0 = 877,
		Beyond-UI-CoolerUnitProgressBarUI-_TickCanvasGroup0 = 878,
		Beyond-UI-CoolerUnitProgressBarUI-_UpdateProgress0 = 879,
		Beyond-UI-CoolerUnitTemperatureCircleUI-get_tickOption0 = 880,
		Beyond-UI-CoolerUnitTemperatureCircleUI-Init0 = 881,
		Beyond-UI-CoolerUnitTemperatureCircleUI-SetUIForward0 = 882,
		Beyond-UI-CoolerUnitTemperatureCircleUI-SetPos0 = 883,
		Beyond-UI-CoolerUnitTemperatureCircleUI-TickUI0 = 884,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_TickCanvasGroup0 = 885,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_SetState0 = 886,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_GetLangKeyOrDefault0 = 887,
		Beyond-UI-CoolerUnitTemperatureCircleUI-_UpdateUIState0 = 888,
		Beyond-UI-CoolerUnitTemperatureUI-get_tickOption0 = 889,
		Beyond-UI-CoolerUnitTemperatureUI-Init0 = 890,
		Beyond-UI-WorldUIController-Clear0 = 891,
		Beyond-UI-WorldUIController-set_uiActive0 = 892,
		Beyond-UI-CoolerUnitTemperatureUI-Clear0 = 893,
		Beyond-UI-CoolerUnitTemperatureUI-SetUIForward0 = 894,
		Beyond-UI-CoolerUnitTemperatureUI-SetPos0 = 895,
		Beyond-UI-CoolerUnitTemperatureUI-TickUI0 = 896,
		Beyond-UI-CoolerUnitTemperatureUI-_TickCanvasGroup0 = 897,
		Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIInfo0 = 898,
		Beyond-UI-CoolerUnitTemperatureUI-NormalizeRange0 = 899,
		Beyond-UI-CoolerUnitTemperatureUI-_UpdateUIPos0 = 900,
		Beyond-UI-CoolerUnitTotalProgressBarUI-get_tickOption0 = 901,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_GeneratePercentStrings0 = 902,
		Beyond-UI-CoolerUnitTotalProgressBarUI-Init0 = 903,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_ResetUI0 = 904,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_GetCanvas0 = 905,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_TryGetModule0 = 906,
		Beyond-UI-CoolerUnitTotalProgressBarUI-SetUIForward0 = 907,
		Beyond-UI-CoolerUnitTotalProgressBarUI-SetPos0 = 908,
		Beyond-UI-CoolerUnitTotalProgressBarUI-TickUI0 = 909,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_TickCanvasGroup0 = 910,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_UpdateProgress0 = 911,
		Beyond-UI-CoolerUnitTotalProgressBarUI-_SetProgressText0 = 912,
		Beyond-UI-DoodadFactoryGasCoreScanUI-get_tickOption0 = 913,
		Beyond-UI-DoodadFactoryGasCoreScanUI-Init0 = 914,
		Beyond-UI-DoodadFactoryGasCoreScanUI-_BindDomainChange0 = 915,
		Beyond-UI-DoodadFactoryGasCoreScanUI-_OnDomainDevelopmentChange0 = 916,
		Beyond-UI-WorldUIController-RefreshUI0 = 917,
		Beyond-UI-WorldUIController-InitUI0 = 918,
		Beyond-UI-DoodadFactoryGasCoreScanUI-DoRelease0 = 919,
		Beyond-UI-DoodadFactoryGasCoreScanUI-_UnbindDomainChange0 = 920,
		Beyond-UI-WorldUIController-DoRelease0 = 921,
		Beyond-UI-DoodadFactoryGasCoreScanUI-SetUIForward0 = 922,
		Beyond-UI-DoodadFactoryGasCoreScanUI-SetPos0 = 923,
		Beyond-UI-DoodadFactoryGasCoreScanUI-TickUI0 = 924,
		Beyond-UI-WorldUIController-FaceToCamera0 = 925,
		Beyond-UI-DoodadFactoryGasCoreScanUI-InitUI0 = 926,
		Beyond-UI-DoodadFactoryGasCoreScanUI-RefreshUI0 = 927,
		Beyond-UI-DoodadFactoryGasScanUI-get_tickOption0 = 928,
		Beyond-UI-DoodadFactoryGasScanUI-Init0 = 929,
		Beyond-UI-DoodadFactoryGasScanUI-DoRelease0 = 930,
		Beyond-UI-DoodadFactoryGasScanUI-SetUIForward0 = 931,
		Beyond-UI-DoodadFactoryGasScanUI-SetPos0 = 932,
		Beyond-UI-DoodadFactoryGasScanUI-TickUI0 = 933,
		Beyond-UI-DoodadFactoryGasScanUI-InitUI0 = 934,
		Beyond-UI-FacLineCell-Awake0 = 935,
		Beyond-UI-FacLineCell-PlayLineAnimation0 = 936,
		Beyond-UI-FacLineCell-PlayLineDecoAnimation0 = 937,
		Beyond-UI-FacLineCell-ChangeLineColor0 = 940,
		Beyond-UI-FacLineCell-ChangeLineWidth0 = 941,
		Beyond-UI-FacLineDrawer-Awake0 = 942,
		Beyond-UI-FacLineDrawer-OnDestroy0 = 943,
		Beyond-UI-FacLineDrawer-_Clear0 = 944,
		Beyond-UI-FacLineDrawer-_CloneLineObject0 = 945,
		Beyond-UI-FacLineDrawer-_RefreshCopyLineObjectColor0 = 946,
		Beyond-UI-FacLineDrawer-ClearComponent0 = 947,
		Beyond-UI-FacLineDrawer-DrawLine0 = 948,
		Beyond-UI-FacLineDrawer-PlayLineAnimation0 = 949,
		Beyond-UI-FacLineDrawer-PlayPortLineDecoAnimation0 = 950,
		Beyond-UI-FacLineDrawer-ChangeLineColor0 = 951,
		Beyond-UI-FacLineDrawer-ClearDrawer0 = 952,
		Beyond-UI-FacRegionUpgradeEffectController-_RefreshNodeState0 = 953,
		Beyond-UI-FacRegionUpgradeEffectController-SetUpgradeState0 = 954,
		Beyond-UI-FacRegionUpgradeEffectController-SetSelectState0 = 955,
		Beyond-UI-FacRegionUpgradeEffectController-SetVisibleState0 = 956,
		Beyond-UI-UIFacTechTreePanel-get_tickOption0 = 957,
		Beyond-UI-UIFacTechTreePanel-OnRelease0 = 958,
		Beyond-UI-UIFacTechTreePanel-Tick0 = 959,
		Beyond-UI-UIFacTechTreePanel-_PosAdjust0 = 960,
		Beyond-UI-UIFacTechTreePanel-_UpdatePositionOffsetAfterZoomed0 = 961,
		Beyond-UI-UIFacTechTreePanel-_ControllerUpdate0 = 962,
		Beyond-UI-UIFacTechTreePanel-_ControllerZoomUpdate0 = 963,
		Beyond-UI-UIFacTechTreePanel-_OnZoom0 = 964,
		Beyond-UI-UIFacTechTreePanel-_RefreshPivotPosition0 = 965,
		Beyond-UI-UIFacTechTreePanel-_SetScale0 = 966,
		Beyond-UI-UIFacTechTreePanel-_ControllerDragUpdate0 = 967,
		Beyond-UI-UIFacTechTreePanel-InitData0 = 968,
		Beyond-UI-UIFacTechTreePanel-_OnDrag0 = 970,
		Beyond-UI-UIFacTechTreePanel-_RefreshAll0 = 972,
		Beyond-UI-UIFacTechTreePanel-MoveNode0 = 974,
		Beyond-UI-UIFacTechTreePanel-FocusNode0 = 975,
		Beyond-UI-UIFacTechTreePanel-_OnUnlockMoveNode0 = 976,
		Beyond-UI-UIFacTechTreePanel-OnUnlockTech0 = 977,
		Beyond-UI-UIFacTechTreePanel-ZoomToFullTechTree0 = 978,
		Beyond-UI-UIFacTechTreePanel-SetDetailShownState0 = 979,
		Beyond-UI-ForgeIronProgressBarUI-get_tickOption0 = 980,
		Beyond-UI-ForgeIronProgressBarUI-Init0 = 981,
		Beyond-UI-ForgeIronProgressBarUI-SetPos0 = 982,
		Beyond-UI-ForgeIronProgressBarUI-SetUIForward0 = 983,
		Beyond-UI-ForgeIronProgressBarUI-TickUI0 = 984,
		Beyond-UI-ForgeIronProgressBarUI-UpdateProgress0 = 985,
		Beyond-UI-ForgeIronTemperatureCircleUI-get_tickOption0 = 986,
		Beyond-UI-ForgeIronTemperatureCircleUI-Init0 = 987,
		Beyond-UI-ForgeIronTemperatureCircleUI-Clear0 = 988,
		Beyond-UI-ForgeIronTemperatureCircleUI-SetPos0 = 989,
		Beyond-UI-ForgeIronTemperatureCircleUI-SetUIForward0 = 990,
		Beyond-UI-ForgeIronTemperatureCircleUI-TickUI0 = 991,
		Beyond-UI-ForgeIronTemperatureCircleUI-_SetState0 = 992,
		Beyond-UI-ForgeIronTemperatureCircleUI-UpdateUIState0 = 993,
		Beyond-UI-ForgeIronTemperatureUI-get_tickOption0 = 994,
		Beyond-UI-ForgeIronTemperatureUI-Init0 = 995,
		Beyond-UI-ForgeIronTemperatureUI-SetPos0 = 996,
		Beyond-UI-ForgeIronTemperatureUI-SetUIForward0 = 997,
		Beyond-UI-ForgeIronTemperatureUI-TickUI0 = 998,
		Beyond-UI-ForgeIronTemperatureUI-UpdateUIInfo0 = 999,
		Beyond-UI-ForgeIronTemperatureUI-UpdateUIPos0 = 1000,
		Beyond-UI-GuideFakeButton-ForceToggleTargetBinding0 = 1001,
		Beyond-UI-GuideFakeButton-CopyTargetBinding0 = 1002,
		Beyond-UI-GuideFakeButton-_OnTriggerPlayerAction0 = 1003,
		Beyond-UI-GuideFakeButton-ClearTarget0 = 1004,
		Beyond-UI-GuideFakeButton-ClearBinding0 = 1005,
		Beyond-UI-GuideFakeButton-_ClearOnClick0 = 1006,
		Beyond-UI-GuideFakeButton-Awake0 = 1007,
		Beyond-UI-GuideFakeButton-OnPointerDown0 = 1008,
		Beyond-UI-GuideFakeButton-OnPointerUp0 = 1009,
		Beyond-UI-GuideFakeButton-OnPointerEnter0 = 1010,
		Beyond-UI-GuideFakeButton-OnPointerExit0 = 1011,
		Beyond-UI-GuideFakeButton-OnPointerClick0 = 1012,
		Beyond-UI-GuideFakeButton-ClearComponent0 = 1013,
		Beyond-UI-RegionMap3DCfg-Load0 = 1014,
		Beyond-UI-RegionMapSetting-get_tickOption0 = 1017,
		Beyond-UI-RegionMapSetting-get_cfg0 = 1018,
		Beyond-UI-RegionMapSetting-OnDestroy0 = 1019,
		Beyond-UI-RegionMapSetting-_ClearMaterials0 = 1020,
		Beyond-UI-RegionMapSetting-_InitUI0 = 1021,
		Beyond-UI-RegionMapSetting-_InitTrackIcon0 = 1022,
		Beyond-UI-UIRegionMapTrackIcon-InitData0 = 1023,
		Beyond-UI-RegionMapSetting-_SetMapPos0 = 1024,
		Beyond-UI-RegionMapSetting-_InitPlayerIcon0 = 1025,
		Beyond-UI-RegionMapSetting-_InitSelect0 = 1026,
		Beyond-UI-RegionMapSetting-_RefreshMaterials0 = 1027,
		Beyond-UI-RegionMapSetting-InitData0 = 1028,
		Beyond-UI-RegionMapSetting-MoveToPlayer0 = 1029,
		Beyond-UI-RegionMapSetting-IsCircleIntersectingRectangle0 = 1030,
		Beyond-UI-RegionMapSetting-GetNodeTransform0 = 1031,
		Beyond-UI-RegionMapSetting-GetNodeMoveTargetLocalPosition0 = 1032,
		Beyond-UI-RegionMapSetting-GetCfg0 = 1033,
		Beyond-UI-RegionMapSetting-SetLoadedRegionTransform0 = 1034,
		Beyond-UI-RegionMapSetting-StartRegionRectTransformMoveRotationTween0 = 1035,
		Beyond-UI-RegionMapSetting-get_m_materialPropertyBlock0 = 1036,
		Beyond-UI-RegionMapSetting-SetControllerLevelSelectedState0 = 1037,
		Beyond-UI-UIFacMainRegion-_OnMainRegionLevelChanged0 = 1038,
		Beyond-UI-UIFacMainRegion-_RefreshRegionState0 = 1039,
		Beyond-UI-UIFacMainRegion-OnDestroy0 = 1040,
		Beyond-UI-UIFacMainRegion-ClearComponent0 = 1041,
		Beyond-UI-UIFacMainRegion-InitMainRegion0 = 1042,
		Beyond-UI-UILevelMapCommonStaticElement-InitCommonStaticElement0 = 1043,
		Beyond-UI-UILevelMapCommonStaticElement-_RegisterPhaseConditions0 = 1044,
		Beyond-UI-UILevelMapCommonStaticElement-_OnAnyConditionChanged0 = 1045,
		Beyond-UI-UILevelMapCommonStaticElement-_ReevaluateAndApply0 = 1046,
		Beyond-UI-UILevelMapCommonStaticElement-_FindMatchingPhaseIndex0 = 1047,
		Beyond-UI-UILevelMapCommonStaticElement-_FindMatchingPhaseIndex1 = 1048,
		Beyond-UI-UILevelMapCommonStaticElement-_UnloadImage0 = 1049,
		Beyond-UI-UILevelMapCommonStaticElement-_LoadImage0 = 1050,
		Beyond-UI-UILevelMapCommonStaticElement-_RegisterPhaseConditions1 = 1051,
		Beyond-UI-UILevelMapCommonStaticElement-ClearComponent0 = 1052,
		Beyond-UI-UILevelMapCommonStaticElement-OnDestroy0 = 1053,
		Beyond-UI-UILevelMapCommonStaticElement-EvaluateInitialVisibility0 = 1054,
		Beyond-UI-UILevelMapCrane-OnDestroy0 = 1055,
		Beyond-UI-UILevelMapCrane-_ClearSpriteAsset0 = 1056,
		Beyond-UI-UILevelMapCrane-ClearComponent0 = 1057,
		Beyond-UI-UILevelMapCrane-_UnBindAll0 = 1058,
		Beyond-UI-UILevelMapCrane-_OnCraneStateChanged0 = 1059,
		Beyond-UI-UILevelMapCrane-_RefreshCraneState0 = 1060,
		Beyond-UI-UILevelMapCrane-_BindAll0 = 1061,
		Beyond-UI-UILevelMapCrane-InitCrane0 = 1062,
		Beyond-UI-UILevelMapGameplayArea-_RefreshGameplayArea0 = 1063,
		Beyond-UI-UILevelMapGameplayArea-Init0 = 1064,
		Beyond-UI-UILevelMapGameplayArea-ClearComponent0 = 1065,
		Beyond-UI-UILevelMapLimitInRect-get_tickOption0 = 1066,
		Beyond-UI-UILevelMapLimitInRect-LateTick0 = 1067,
		Beyond-UI-UILevelMapLimitInRect-_LimitInRect0 = 1068,
		Beyond-UI-UILevelMapLimitInRect-OnEnable0 = 1069,
		Beyond-UI-UILevelMapLimitInRect-OnRelease0 = 1070,
		Beyond-UI-UILevelMapLimitInRect-ClearComponent0 = 1071,
		Beyond-UI-UILevelMapLimitInRect-StartLimitMarkInRect0 = 1072,
		Beyond-UI-UILevelMapLimitInRect-StopLimitMarkInRect0 = 1073,
		Beyond-UI-UILevelMapLimitInRect-ForceRefreshLimitState0 = 1074,
		Beyond-UI-UILevelMapLine-get_tickOption0 = 1075,
		Beyond-UI-UILevelMapLine-OnEnable0 = 1076,
		Beyond-UI-UILevelMapLine-_HoldLineSize0 = 1077,
		Beyond-UI-UILevelMapLine-LateTick0 = 1078,
		Beyond-UI-UILevelMapLine-Init0 = 1079,
		Beyond-UI-UILevelMapLine-ClearComponent0 = 1080,
		Beyond-UI-UILevelMapMissionArea-get_tickOption0 = 1081,
		Beyond-UI-UILevelMapMissionArea-get_needCheckMissionTrackCoexist0 = 1082,
		Beyond-UI-UILevelMapMissionArea-get_coexistWithMissionTrack0 = 1083,
		Beyond-UI-UILevelMapMissionArea-get_notNeedCheckCoexistBecauseOfRadius0 = 1084,
		Beyond-UI-UILevelMapMissionArea-LateTick0 = 1085,
		Beyond-UI-UILevelMapMissionArea-_DisappearIfOutRect0 = 1086,
		Beyond-UI-UILevelMapMissionArea-_IsCircleOutsideDisappearRect0 = 1087,
		Beyond-UI-UILevelMapMissionArea-_RefreshMissionArea0 = 1088,
		Beyond-UI-UILevelMapMissionArea-Init0 = 1089,
		Beyond-UI-UILevelMapMissionArea-ClearComponent0 = 1090,
		Beyond-UI-UILevelMapMissionArea-ForceRefreshDisappearIfOutRect0 = 1091,
		Beyond-UI-UILevelMapMisty-OnDestroy0 = 1092,
		Beyond-UI-UILevelMapMisty-ClearComponent0 = 1093,
		Beyond-UI-UILevelMapMisty-_UnBindAll0 = 1094,
		Beyond-UI-UILevelMapMisty-_OnMistyStateChanged0 = 1095,
		Beyond-UI-UILevelMapMisty-_RefreshMistyState0 = 1096,
		Beyond-UI-UILevelMapMisty-IsMistyVisible0 = 1097,
		Beyond-UI-UILevelMapMisty-_BindAll0 = 1098,
		Beyond-UI-UILevelMapMisty-InitMisty0 = 1099,
		Beyond-UI-UILevelMapNarrativeAreaText-InitNarrativeAreaText0 = 1100,
		Beyond-UI-UILevelMapNarrativeAreaText-_MergeAllConditionExpressions0 = 1101,
		Beyond-UI-UILevelMapNarrativeAreaText-_OnAnyConditionChanged0 = 1102,
		Beyond-UI-UILevelMapNarrativeAreaText-_ReevaluateAndApply0 = 1103,
		Beyond-UI-UILevelMapNarrativeAreaText-ClearComponent0 = 1104,
		Beyond-UI-UILevelMapNarrativeAreaText-OnDestroy0 = 1105,
		Beyond-UI-UILevelMapSwitchBtn-InitSwitchButton0 = 1106,
		Beyond-UI-UILevelMapSwitchBtn-ClearComponent0 = 1109,
		Beyond-UI-UILevelMapTouchPanelWrapper-get_tickOption0 = 1110,
		Beyond-UI-UILevelMapTouchPanelWrapper-OnAwake0 = 1111,
		Beyond-UI-UILevelMapTouchPanelWrapper-Tick0 = 1112,
		Beyond-UI-UILevelMapTouchPanelWrapper-_CheckDrag0 = 1113,
		Beyond-UI-UILevelMapTouchPanelWrapper-_IsFirstRaycastSelectable0 = 1114,
		Beyond-UI-UILevelMapTouchPanelWrapper-_CheckScroll0 = 1115,
		Beyond-UI-UIRegionMap3DPanel-get_tickOption0 = 1116,
		Beyond-UI-UIRegionMap3DPanel-_GetNodeTransform0 = 1117,
		Beyond-UI-UIRegionMap3DPanel-_GetMoveTargetLocalPosition0 = 1118,
		Beyond-UI-UIRegionMap3DPanel-_OnDoMoveTween0 = 1119,
		Beyond-UI-UIRegionMap3DPanel-InitPanel0 = 1120,
		Beyond-UI-UIRegionMap3DPanel-OnClickLevelBtn0 = 1121,
		Beyond-UI-UIRegionMap3DPanel-OnLevelHoverChanged0 = 1122,
		Beyond-UI-UISettlementRegion-OnDestroy0 = 1123,
		Beyond-UI-UISettlementRegion-ClearComponent0 = 1124,
		Beyond-UI-UISettlementRegion-_UnBindAll0 = 1125,
		Beyond-UI-UISettlementRegion-_OnSettlementUnlocked0 = 1126,
		Beyond-UI-UISettlementRegion-_RefreshSettlementRegionState0 = 1127,
		Beyond-UI-UISettlementRegion-_RefreshSpriteWithTier0 = 1128,
		Beyond-UI-UISettlementRegion-_BindAll0 = 1129,
		Beyond-UI-UISettlementRegion-InitSettlementRegion0 = 1130,
		Beyond-UI-UISettlementRegion-GetNeedRefreshSettlementRegionTier0 = 1131,
		Beyond-UI-UISettlementRegion-RefreshSettlementRegionWithTier0 = 1132,
		Beyond-UI-ChessboardDrop-OnDrop0 = 1133,
		Beyond-UI-ChessboardDrop-_CheckEventValid0 = 1134,
		Beyond-UI-ChessboardDrop-OnPointerEnter0 = 1135,
		Beyond-UI-ChessboardDrop-OnPointerExit0 = 1136,
		Beyond-UI-ChessboardDrop-ClearComponent0 = 1137,
		Beyond-UI-ChessboardDrop-OnDestroy0 = 1138,
		Beyond-UI-PuzzleCellDrag-Init0 = 1139,
		Beyond-UI-PuzzleCellDrag-OnBeginDrag0 = 1140,
		Beyond-UI-PuzzleDrag-OnBeginDrag0 = 1141,
		Beyond-UI-PuzzleCellDrag-OnDrag0 = 1142,
		Beyond-UI-PuzzleDrag-OnDrag0 = 1143,
		Beyond-UI-PuzzleCellDrag-OnEndDrag0 = 1144,
		Beyond-UI-PuzzleDrag-OnEndDrag0 = 1145,
		Beyond-UI-PuzzleCellDrag-OnPointerDown0 = 1146,
		Beyond-UI-PuzzleDrag-OnPointerDown0 = 1147,
		Beyond-UI-PuzzleCellDrag-OnPointerUp0 = 1148,
		Beyond-UI-PuzzleDrag-OnPointerUp0 = 1149,
		Beyond-UI-PuzzleCellDrag-OnPointerClick0 = 1150,
		Beyond-UI-PuzzleDrag-OnPointerClick0 = 1151,
		Beyond-UI-PuzzleCellDrag-OnPointerEnter0 = 1152,
		Beyond-UI-PuzzleDrag-OnPointerEnter0 = 1153,
		Beyond-UI-PuzzleCellDrag-OnPointerExit0 = 1154,
		Beyond-UI-PuzzleDrag-OnPointerExit0 = 1155,
		Beyond-UI-PuzzleControllerHelper-get_raycastResults0 = 1156,
		Beyond-UI-PuzzleControllerHelper-Awake0 = 1157,
		Beyond-UI-PuzzleControllerHelper-TryGetPuzzleSlotIndexByPos0 = 1158,
		Beyond-UI-PuzzleDrag-get_luaIndex0 = 1159,
		Beyond-UI-PuzzleDrag-get_panel0 = 1160,
		Beyond-UI-PuzzleDrag-Awake0 = 1161,
		Beyond-UI-PuzzleDrag-ClearComponent0 = 1162,
		Beyond-UI-PuzzleDrag-OnDestroy0 = 1163,
		Beyond-UI-PuzzleDrag-SetIndex0 = 1164,
		Beyond-UI-ScratchOffLotteryCoating-Awake0 = 1165,
		Beyond-UI-ScratchOffLotteryCoating-_DrawBlank0 = 1166,
		Beyond-UI-ScratchOffLotteryCoating-_InitPixelDic0 = 1167,
		Beyond-UI-ScratchOffLotteryCoating-_InitMarkPoint0 = 1168,
		Beyond-UI-ScratchOffLotteryCoating-OnDestroy0 = 1169,
		Beyond-UI-ScratchOffLotteryCoating-Draw0 = 1170,
		Beyond-UI-ScratchOffLotteryCoating-_MarkScratchPos0 = 1171,
		Beyond-UI-ScratchOffLotteryCoating-_AwardMarkScratchPos0 = 1172,
		Beyond-UI-ScratchOffLotteryCoating-_ClampDrawRect0 = 1173,
		Beyond-UI-ScratchOffLotteryCoating-OutputCompletePercent0 = 1174,
		Beyond-UI-ScratchOffLotteryCoating-FlagCompleteMarkPoint0 = 1175,
		Beyond-UI-ScratchOffLotteryCoating-_FigureUpCreateRouteLinePoints0 = 1176,
		Beyond-UI-ScratchOffLotteryCoating-_ComputeBrushUV0 = 1177,
		Beyond-UI-ScratchOffLotteryCoating-ApplyScratch0 = 1178,
		Beyond-UI-ScratchOffLotteryCoating-_ScreenPosToUiLocalPos0 = 1179,
		Beyond-UI-ScratchOffLotteryCoating-BeginScratch0 = 1180,
		Beyond-UI-ScratchOffLotteryCoating-EndScratch0 = 1181,
		Beyond-UI-UIMusicVolumeVisual-get_tickOption0 = 1182,
		Beyond-UI-UIMusicVolumeVisual-get_graphic0 = 1183,
		Beyond-UI-UIMusicVolumeVisual-Start0 = 1184,
		Beyond-UI-UIMusicVolumeVisual-OnEnable0 = 1185,
		Beyond-UI-UIMusicVolumeVisual-OnDisable0 = 1186,
		Beyond-UI-UIMusicVolumeVisual-Tick0 = 1187,
		Beyond-UI-RiftScanUI-get_tickOption0 = 1188,
		Beyond-UI-RiftScanUI-Init0 = 1189,
		Beyond-UI-RiftScanUI-DoRelease0 = 1190,
		Beyond-UI-RiftScanUI-SetUIForward0 = 1191,
		Beyond-UI-RiftScanUI-SetPos0 = 1192,
		Beyond-UI-RiftScanUI-TickUI0 = 1193,
		Beyond-UI-RiftScanUI-InitUI0 = 1194,
		Beyond-UI-RiftScanUI-RefreshUI0 = 1195,
		Beyond-UI-RiftScanUI-_GetStateName0 = 1196,
		Beyond-UI-RiftScanUI-_UpdateUI0 = 1197,
		Beyond-UI-RiftScanUI-_GetTypeDesText0 = 1198,
		Beyond-UI-RiftScanUI-_GetTypePercentText0 = 1199,
		Beyond-UI-UIBrokenLine-Awake0 = 1200,
		Beyond-UI-UIBrokenLine-_Init0 = 1201,
		Beyond-UI-UIBrokenLine-OnDestroy0 = 1202,
		Beyond-UI-UIBrokenLine-SetYValueByArray0 = 1203,
		Beyond-UI-UIBrokenLine-SetYValue0 = 1204,
		Beyond-UI-UICommonScanController-get_tickOption0 = 1205,
		Beyond-UI-UICommonScanController-get_uiActive0 = 1206,
		Beyond-UI-UICommonScanController-set_uiActive0 = 1207,
		Beyond-UI-UICommonScanController-SetTarget0 = 1208,
		Beyond-UI-UICommonScanController-_UpdatePos0 = 1210,
		Beyond-UI-UICommonScanController-SetFixPoint0 = 1211,
		Beyond-UI-UICommonScanController-Tick0 = 1212,
		Beyond-UI-UICommonScanController-_FaceToCamera0 = 1213,
		Beyond-UI-UICommonScanController-Clear0 = 1214,
		Beyond-UI-UICountDownBar-get_tickOption0 = 1215,
		Beyond-UI-UICountDownBar-get_update0 = 1216,
		Beyond-UI-UICountDownBar-set_update0 = 1217,
		Beyond-UI-UICountDownBar-InitData0 = 1218,
		Beyond-UI-UICountDownBar-_UpdateData0 = 1219,
		Beyond-UI-UICountDownBar-_UpdatePos0 = 1220,
		Beyond-UI-UICountDownBar-Clear0 = 1221,
		Beyond-UI-UICountDownBar-LateTick0 = 1222,
		Beyond-UI-UIDoodadMineCoreScanController-SyncConditonInfo0 = 1223,
		Beyond-UI-UIDoodadMineCoreScanController-SetPurity0 = 1224,
		Beyond-UI-UIDoodadMineCoreScanController-UpdateUI0 = 1225,
		Beyond-UI-UIDoodadPlantCoreScanController-Tick0 = 1226,
		Beyond-UI-UIDoodadPlantCoreScanController-_SyncTimeText0 = 1227,
		Beyond-UI-UIDoodadPlantCoreScanController-SetCoreInfo0 = 1228,
		Beyond-UI-UIDoodadPlantCoreScanController-SetRefreshInfo0 = 1229,
		Beyond-UI-UIDoodadPlantCoreScanController-RefreshTextNow0 = 1230,
		Beyond-UI-UIDoodadPlantCoreScanController-SetQuantityInfo0 = 1231,
		Beyond-UI-UIDoodadPlantCoreScanController-SetSingle0 = 1232,
		Beyond-UI-UIDoodadScanController-SyncRefreshInfo0 = 1233,
		Beyond-UI-UIDoodadScanController-Tick0 = 1234,
		Beyond-UI-UIDoodadScanController-_RefreshCountDown0 = 1235,
		Beyond-UI-UIDoodadScanController-UpdateUI0 = 1236,
		Beyond-UI-UIGeneralTracker-get_rect0 = 1237,
		Beyond-UI-UIGeneralTracker-UpdatePosition0 = 1238,
		Beyond-UI-UILiquidPoolScanController-SetWaterInfo0 = 1239,
		Beyond-UI-UIPanelBase-get_tickOption0 = 1240,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateDistance0 = 1241,
		Beyond-UI-UIPowerPoleAutoConnectTracker-SetDistanceTextVisible0 = 1242,
		Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateStatus0 = 1243,
		Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-Switch0 = 1244,
		Beyond-UI-UIPowerPoleAutoConnectTracker-StatusHintGroup-Switch0 = 1245,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateStatus0 = 1246,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateStatusNormal0 = 1247,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateStatusTooFar0 = 1248,
		Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUdpipeError0 = 1249,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateUdpipeError0 = 1250,
		Beyond-UI-UIPowerPoleAutoConnectTracker-_ActualUpdateIcon0 = 1251,
		Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-SetActiveIfNecessary0 = 1252,
		Beyond-UI-UIPowerPoleAutoConnectTracker-UpdateNodeType0 = 1253,
		Beyond-UI-UIPowerPoleAutoConnectTracker-IconGroup-get_activeSelf0 = 1254,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_isWarning0 = 1255,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_isDisabled0 = 1256,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_allowToHighlight0 = 1257,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_iconStatus0 = 1258,
		Beyond-UI-UIPowerPoleFastTravelTracker-set_iconStatus0 = 1259,
		Beyond-UI-UIPowerPoleFastTravelTracker-_UpdateIcon0 = 1260,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageNormal0 = 1261,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageNormalOther0 = 1262,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageWarning0 = 1263,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageHighlighted0 = 1264,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageHighlightedOther0 = 1265,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_imageDisabled0 = 1266,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_status0 = 1267,
		Beyond-UI-UIPowerPoleFastTravelTracker-set_status0 = 1268,
		Beyond-UI-UIPowerPoleFastTravelTracker-_OnStatusChanged0 = 1269,
		Beyond-UI-UIPowerPoleFastTravelTracker-get_animationWrapper0 = 1270,
		Beyond-UI-UIPowerPoleFastTravelTracker-PlayFocus0 = 1271,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIconStatus0 = 1272,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateStatus0 = 1273,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIsHighlighted0 = 1274,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateIsOtherSocial0 = 1275,
		Beyond-UI-UIPowerPoleFastTravelTracker-UpdateDistance0 = 1276,
		Beyond-UI-UIPowerPoleFastTravelTracker-OnEnable0 = 1277,
		Beyond-UI-UIRaceModuleRankController-get_tickOption0 = 1278,
		Beyond-UI-UIRaceModuleRankController-_ResetData0 = 1279,
		Beyond-UI-UIRaceModuleRankController-OnAwake0 = 1280,
		Beyond-UI-UIRaceModuleRankController-_ShowBaseTrans0 = 1281,
		Beyond-UI-UIRaceModuleRankController-_LoadAllSprite0 = 1282,
		Beyond-UI-UIRaceModuleRankController-_UpdateRaceModuleRank0 = 1283,
		Beyond-UI-UIRaceModuleRankController-OnRelease0 = 1284,
		Beyond-UI-UIRaceModuleRankController-Tick0 = 1285,
		Beyond-UI-UIUdpipeConnectTracker-UpdateDistance0 = 1286,
		Beyond-UI-UIUdpipeConnectTracker-_ActualUpdateStatus0 = 1287,
		Beyond-UI-UIUdpipeConnectTracker-IconGroup-Switch0 = 1288,
		Beyond-UI-UIUdpipeConnectTracker-StatusHintGroup-Switch0 = 1289,
		Beyond-UI-UIUdpipeConnectTracker-UpdateStatus0 = 1290,
		Beyond-UI-UIUdpipeConnectTracker-_ActualUpdateIcon0 = 1291,
		Beyond-UI-UIUdpipeConnectTracker-IconGroup-SetActiveIfNecessary0 = 1292,
		Beyond-UI-UIUdpipeConnectTracker-UpdateNodeType0 = 1293,
		Beyond-UI-UIUdpipeConnectTracker-IconGroup-get_activeSelf0 = 1294,
		Beyond-UI-UIVideoHelper-Reset0 = 1295,
		Beyond-UI-UIVideoHelper-ResetVideo0 = 1296,
		Beyond-UI-UIVideoHelper-Awake0 = 1297,
		Beyond-UI-UIVideoHelper-OnEnable0 = 1298,
		Beyond-UI-UIWaterDroneBar-get_tickOption0 = 1299,
		Beyond-UI-UIWaterDroneBar-OnAwake0 = 1300,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneInfinityLiquidChanged0 = 1301,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneEmptyChanged0 = 1302,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneInteractiveChanged0 = 1303,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneSourceTypeChanged0 = 1304,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneRelaxChanged0 = 1305,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged1 = 1306,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneHydrantStateChanged0 = 1307,
		Beyond-UI-UIWaterDroneBar-OnEnable0 = 1308,
		Beyond-UI-UIWaterDroneBar-_OnWaterDroneChange0 = 1309,
		Beyond-UI-UIWaterDroneBar-_ClearWaterDrone0 = 1310,
		Beyond-UI-UIWaterDroneBar-OnRelease0 = 1311,
		Beyond-UI-UIWaterDroneBar-LateTick0 = 1312,
		Beyond-UI-UIWaterDroneBar-_UpdateState0 = 1313,
		Beyond-UI-UIWaterDroneBar-_SetIconStateController0 = 1314,
		Beyond-UI-UIWaterDroneBar-_UpdateSlider0 = 1315,
		Beyond-UI-WorldUIController-get_tickOption0 = 1316,
		Beyond-UI-WorldUIController-get_uiActive0 = 1317,
		Beyond-UI-WorldUIController-Tick0 = 1318,
		Beyond-UI-WorldUIController-TickUI0 = 1319,
		Beyond-UI-WorldUIController-OnRelease0 = 1320,
		Beyond-UI-Mission-MissionHudBGSizeUpdater-get_tickOption0 = 1321,
		Beyond-UI-Mission-MissionHudBGSizeUpdater-LateTick0 = 1322,
		Beyond-UI-Mission-MissionHudBGSizeUpdater-UpdateBgSize0 = 1323
	}
}
