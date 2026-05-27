/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Beyond;
using Beyond.Audio;
using Beyond.GEnums;
using Beyond.I18n;
using Beyond.Input;
using Beyond.MemoryPack;
using Beyond.Playables;
using Beyond.PoolCore;
using Beyond.Resource;
using Beyond.UI;
using Beyond.UI.GPUI;
using Beyond.UI.UIState;
using Cinemachine;
using Cysharp.Text;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HG.Rendering.Runtime;
using IFix.Core;
using JetBrains.Annotations;
using MagicaCloth;
using TMPro;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.InputSystem.UI;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;
using ZSimpleJSON;

// Image 17: UI.Beyond.dll - Assembly: UI.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 49129-49485
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Beyond.Editor")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public class UIMinSizeAdjust : MonoBehaviour // TypeDefIndex: 49130
{
	// Fields
	[FormerlySerializedAs("m_panelRect")]
	[SerializeField]
	private RectTransform _panelRect; // 0x18

	// Constructors
	public UIMinSizeAdjust() {} // 0x000000018426FE60-0x000000018426FE68

	// Methods
	private void Start() {} // 0x0000000189AB04D4-0x0000000189AB04DC
	private void _SetTextureScaleByWidth() {} // 0x0000000189AB04DC-0x0000000189AB06E4
}

namespace Beyond.Gameplay.UI
{
	public class UIScrollCellCircleEffect : TickableUIMono // TypeDefIndex: 49140
	{
		// Fields
		[SerializeField]
		private Transform _target; // 0x68
		[SerializeField]
		private float _radius; // 0x70
		[SerializeField]
		private Transform _effectNode; // 0x78
		[SerializeField]
		private bool _faceToUICamera; // 0x80
		[SerializeField]
		private bool _alwaysFaceToCamera; // 0x81
		private Vector3 m_lastPosition; // 0x84
		private LuaPanel m_panel; // 0x90
		private bool m_left; // 0xA0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55740-0x0000000183D55750 
		public LuaPanel panel { get => default; } // 0x0000000189AB13F0-0x0000000189AB14B0 
		public Transform lookAtCamera { get; private set; } // 0x00000001811AC510-0x00000001811AC520 0x00000001851417AC-0x00000001851417C0
	
		// Constructors
		public UIScrollCellCircleEffect() {} // 0x0000000189AB13E0-0x0000000189AB13F0
	
		// Methods
		private void _InitState() {} // 0x0000000189AB0F44-0x0000000189AB1008
		private void _UpdatePos() {} // 0x0000000189AB1220-0x0000000189AB13E0
		private void _UpdateLookAtCamera() {} // 0x0000000189AB1008-0x0000000189AB1220
		public void SetLookAtCamera(Transform faceCamera, bool update = true /* Metadata: 0x01FBC37B */) {} // 0x0000000189AB0DA4-0x0000000189AB0E40
		protected override void OnEnable() {} // 0x0000000189AB0D4C-0x0000000189AB0DA4
		private void Start() {} // 0x0000000189AB0E40-0x0000000189AB0EE8
		public override void Tick(float deltaTime) {} // 0x0000000189AB0EE8-0x0000000189AB0F44
		public void ForceUpdate() {} // 0x0000000189AB0CA0-0x0000000189AB0CF0
		public override void LateTick(float deltaTime) {} // 0x0000000189AB0CF0-0x0000000189AB0D4C
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class UIScrollCellSlantEffect : TickableUIMono // TypeDefIndex: 49141
	{
		// Fields
		[SerializeField]
		private float _topY; // 0x68
		[SerializeField]
		private float _bottomY; // 0x6C
		[SerializeField]
		private float _leftX; // 0x70
		[SerializeField]
		private float _maxWidth; // 0x74
		[SerializeField]
		private AnimationCurve _curve; // 0x78
		[SerializeField]
		private Transform[] _cells; // 0x80
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public UIScrollCellSlantEffect() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		public override void Tick(float deltaTime) {} // 0x00000001832B98D0-0x00000001832B9B70
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_UI_Beyond // TypeDefIndex: 49133
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime() {} // 0x0000000183C8B2A0-0x0000000183C8B2D0
		private static void Initialize() {} // 0x0000000183C8B2D0-0x0000000183C8B380
	}
}

namespace Beyond.Scripts.UI.Tools
{
	[RequireComponent(typeof(GridLayoutGroup))]
	public class UIGridLayoutElement : MonoBehaviour, ILayoutElement // TypeDefIndex: 49139
	{
		// Fields
		private GridLayoutGroup m_gridLayoutGroup; // 0x18
	
		// Properties
		public float minWidth { get => default; } // 0x0000000189AB02C4-0x0000000189AB0374 
		public float preferredWidth { get => default; } // 0x0000000189AB0424-0x0000000189AB04D4 
		public float flexibleWidth { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public float minHeight { get => default; } // 0x0000000189AB0214-0x0000000189AB02C4 
		public float preferredHeight { get => default; } // 0x0000000189AB0374-0x0000000189AB0424 
		public float flexibleHeight { get => default; } // 0x0000000183D751A0-0x0000000183D751B0 
		public int layoutPriority { get => default; } // 0x0000000181168950-0x0000000181168960 
	
		// Constructors
		public UIGridLayoutElement() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void CalculateLayoutInputHorizontal() {} // 0x0000000189AAFF78-0x0000000189AAFFB8
		public void CalculateLayoutInputVertical() {} // 0x0000000189AAFFB8-0x0000000189AAFFF8
		private float _GetPreferredSize(bool widthOrHeight) => default; // 0x0000000189AAFFF8-0x0000000189AB0214
	}
}

namespace Beyond.SourceGenerator
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 49134
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 49135
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 49136
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 49137
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 49138
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
	[AddComponentMenu("UI/UIText", 100)]
	public class UIText : TextMeshProUGUI, IPointerClickHandler, IUIClearable, ISerializationCallbackReceiver, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 49158
	{
		// Fields
		public RichTextStyleSeq richTextStyleSeq; // 0xBC8
		private bool m_textHasHyperlink; // 0xBCC
		private static readonly Regex RICH_TEXT_INNERMOST_REGEX; // 0x00
		private const int RICH_TEXT_RESOLVE_MAX_ITERATIONS = 128; // Metadata: 0x01FBC37C
		private static readonly Regex HYPERLINK_TEXT_REGEX; // 0x08
		private static readonly Regex PHONETIC_REGEX; // 0x10
		[SerializeField]
		private bool _loadByCode; // 0xBCD
		[SerializeField]
		private string _textId; // 0xBD0
		[SerializeField]
		private bool _devOnly; // 0xBD8
		[SerializeField]
		private int _externalStaticWidth; // 0xBDC
		[SerializeField]
		private int _externalStaticHeight; // 0xBE0
		private bool m_firstSetByCode; // 0xBE4
		private static readonly HashSet<EnvLang> s_forceLeftAlignLanguage; // 0x18
		private List<RichTextInfo> m_richTextInfos; // 0xBE8
		private TickFunction m_updateFunction; // 0xBF0
		[Obsolete("\u4F7F\u7528processRichTextEntryFunc\u5C5E\u6027\u4EE3\u66FF")]
		private RichTextAnalyzer.ProcessRichTextEntryFunc m_processRichTextEntryFunc; // 0xBF8
		[HideInInspector]
		public UnityEvent<string> onClickLink; // 0xC00
		[HideInInspector]
		public UnityEvent<string, bool> onHoverLinkChange; // 0xC08
		private bool m_isPointerInside; // 0xC10
		private string m_curHoverLinkId; // 0xC18
		private List<string> m_linkList; // 0xC20
		private bool m_linkShrunk; // 0xC28
		[SerializeField]
		private string _hyperlinkUITextGroupId; // 0xC30
		[SerializeField]
		private int _hyperlinkUITextOrder; // 0xC38
		private HyperlinkUITextWrap m_hyperlinkUITextWrap; // 0xC40
		private LuaPanel m_panel; // 0xC48
		public int sourceCNFontId; // 0xC50
		private TMP_FontAsset m_i18nFontAsset; // 0xC58
		private static StringBuilder s_stringBuilder; // 0x20
		private readonly Queue<GameObject> m_inlineImagePool; // 0xC60
		private readonly Dictionary<int, ImageGOInfo> m_indexToImageGo; // 0xC68
		private const string INLINE_IMAGE_FOLDER_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/"; // Metadata: 0x01FBC37E
		private const string KEY_HINT_ICON_COMMON_FOLDER = "Assets/Beyond/InitialAssets/UI/Sprites/"; // Metadata: 0x01FBC3AF
		private readonly Dictionary<string, FAssetProxyHandle> m_imageCache; // 0xC70
		private readonly Dictionary<int, bool> m_delayedActiveChangeImageGOIndexes; // 0xC78
	
		// Properties
		public string textId { get => default; } // 0x0000000183D75FC0-0x0000000183D75FD0 
		public override string text { get => default; set {} } // 0x00000001831E6FF0-0x00000001831E7010 0x00000001830CAAC0-0x00000001830CAB10
		private RichTextAnalyzer.ProcessRichTextEntryFunc processRichTextEntryFunc { get => default; } // 0x00000001825E0100-0x00000001825E01F0 
		public LuaPanel panel { get => default; } // 0x0000000189AB4130-0x0000000189AB41F0 
		public override TMP_FontAsset m_fontAsset { get => default; set {} } // 0x000000018285FD90-0x000000018285FF80 0x0000000189AB42A8-0x0000000189AB4454
		public override Material fontSharedMaterial { get => default; set {} } // 0x0000000183D56F00-0x0000000183D56F10 0x0000000189AB41F0-0x0000000189AB42A8
	
		// Nested types
		private abstract class RichTextInfo // TypeDefIndex: 49142
		{
			// Fields
			public int index; // 0x10
	
			// Constructors
			protected RichTextInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class InlineImageInfo : RichTextInfo // TypeDefIndex: 49143
		{
			// Fields
			public string path; // 0x18
			public float width; // 0x20
			public float height; // 0x24
			public UnityEngine.Color color; // 0x28
	
			// Constructors
			public InlineImageInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private enum RichTextTagType // TypeDefIndex: 49144
		{
			Image = 1,
			Width = 2,
			Height = 3,
			Scale = 4,
			Color = 5
		}
	
		public enum RichTextStyleSeq // TypeDefIndex: 49145
		{
			NORMAL = 0,
			DARK_BACKGROUND = 1,
			LIGHT_BACKGROUND = 2
		}
	
		private static class RichTextAnalyzer // TypeDefIndex: 49151
		{
			// Fields
			private const char CUSTOM_RICH_TEXT_LEFT_BRACKET = '<'; // Metadata: 0x01FBC3DF
			private const char CUSTOM_RICH_TEXT_RIGHT_BRACKET = '>'; // Metadata: 0x01FBC3E1
			private static readonly Dictionary<int, RichTextTag> s_tagToTypeDic; // 0x00
			private static readonly Dictionary<int, RichTextTag> s_tagAttributeToTypeDic; // 0x08
			public const string FONT_SHADOW_OPENING_TAG = "<shadow>"; // Metadata: 0x01FBC3E3
			public const string FONT_SHADOW_CLOSING_TAG = "</shadow>"; // Metadata: 0x01FBC3EC
			public const string FONT_MAT_OPENING_TAG = "<material=\"DefaultFont_3500_RichText_Shadow\">"; // Metadata: 0x01FBC3F6
			public const string FONT_MAT_CLOSING_TAG = "</material>"; // Metadata: 0x01FBC424
			private static readonly List<RichTextParam> s_subParams; // 0x10
	
			// Nested types
			public enum ParamValueType // TypeDefIndex: 49146
			{
				None = 0,
				String = 1,
				Int = 2,
				Float = 3,
				Color = 4
			}
	
			public struct RichTextTag // TypeDefIndex: 49147
			{
				// Fields
				public RichTextTagType richTextTagType; // 0x00
				public Beyond.UI.UIText.RichTextAnalyzer.ParamValueType paramValueType; // 0x04
			}
	
			public struct RichTextParam // TypeDefIndex: 49148
			{
				// Fields
				public RichTextTagType richTextTagType; // 0x00
				public AnyTypeStruct value; // 0x08
			}
	
			public struct AnyTypeStruct // TypeDefIndex: 49149
			{
				// Fields
				public int intValue; // 0x00
				public float floatValue; // 0x00
				public string stringValue; // 0x00
				public UnityEngine.Color colorValue; // 0x00
			}
	
			public delegate RichTextInfo ProcessRichTextEntryFunc(RichTextParam mainParam, List<RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder); // TypeDefIndex: 49150; 0x000000018500C9D0-0x000000018500CA08
	
			// Constructors
			static RichTextAnalyzer() {} // 0x0000000182EB7BD0-0x0000000182EB7ED0
	
			// Methods
			public static string PreAnalyzeRichText(string text, bool needParseActionId) => default; // 0x00000001825DEA10-0x00000001825DEBA0
			public static string AnalyzeRichText(string text, ProcessRichTextEntryFunc processFunc, out List<RichTextInfo> infos) {
				infos = default;
				return default;
			} // 0x00000001825E01F0-0x00000001825E0850
			private static bool _TryParseRichTextEntry(ReadOnlySpan<char> span, ref Utf16ValueStringBuilder stringBuilder, ProcessRichTextEntryFunc processFunc, out RichTextInfo richTextInfo) {
				richTextInfo = default;
				return default;
			} // 0x0000000182EB7ED0-0x0000000182EB8120
			private static bool _TryParseParam(ReadOnlySpan<char> span, out bool isMain, out RichTextParam param) {
				isMain = default;
				param = default;
				return default;
			} // 0x0000000182EB9AC0-0x0000000182EB9EF0
			public static RichTextInfo ProcessRichTextEntryFallback(RichTextParam mainParam, List<RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder) => default; // 0x0000000189AAF650-0x0000000189AAF6CC
			public static int GetCharacterCountWithoutRichText(ReadOnlySpan<char> str) => default; // 0x0000000189AAF3E4-0x0000000189AAF650
			private static int _GetHashCode(ReadOnlySpan<char> str) => default; // 0x0000000182EB9A40-0x0000000182EB9AC0
		}
	
		private class HyperlinkUITextWrap // TypeDefIndex: 49152
		{
			// Fields
			public UIText uiText; // 0x10
			public string hyperlinkUITextGroupId; // 0x18
			public int order; // 0x20
			public bool isDisplayable; // 0x24
	
			// Constructors
			public HyperlinkUITextWrap() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Clear() {} // 0x0000000189AAE844-0x0000000189AAE8DC
		}
	
		private class HyperlinkUITextGroup // TypeDefIndex: 49153
		{
			// Fields
			public HashSet<HyperlinkUITextWrap> wrapSet; // 0x10
			public string groupId; // 0x18
			public int displayableCount; // 0x20
	
			// Constructors
			public HyperlinkUITextGroup() {} // 0x0000000189AADF9C-0x0000000189AAE03C
	
			// Methods
			public void Add(HyperlinkUITextWrap wrap) {} // 0x0000000189AADC60-0x0000000189AADCFC
			public void Remove(HyperlinkUITextWrap wrap) {} // 0x0000000189AADD80-0x0000000189AADE1C
			public void ChangeDisplayable(HyperlinkUITextWrap wrap, bool displayable) {} // 0x0000000189AADCFC-0x0000000189AADD80
			private void _AddDisplayableCount() {} // 0x0000000189AADE1C-0x0000000189AADE78
			private void _SubDisplayableCount() {} // 0x0000000189AADF44-0x0000000189AADF9C
			private void _NotifyDisplayableChanged() {} // 0x0000000189AADE78-0x0000000189AADF44
		}
	
		private class HyperlinkUITextManager // TypeDefIndex: 49155
		{
			// Fields
			private Dictionary<string, HyperlinkUITextGroup> m_hyperlinkUITextGroupMap; // 0x10
			private ObjectPool<HyperlinkUITextGroup> m_hyperlinkUITextGroupPool; // 0x18
			private ObjectPool<HyperlinkUITextWrap> m_hyperlinkUITextWrapPool; // 0x20
			private static HyperlinkUITextManager s_instance; // 0x00
			private static readonly List<HyperlinkUITextWrap> SORT_WRAP_TEMP_LIST; // 0x08
	
			// Properties
			public static HyperlinkUITextManager instance { get => default; } // 0x000000018239EF30-0x000000018239F030 
	
			// Constructors
			public HyperlinkUITextManager() {} // 0x00000001839281D0-0x00000001839284C0
			static HyperlinkUITextManager() {} // 0x0000000183CDF6E0-0x0000000183CDF780
	
			// Methods
			public void AddWrap(UIText uiText, string groupId, int order) {} // 0x0000000189AAE03C-0x0000000189AAE188
			public void RemoveWrap(UIText uiText) {} // 0x000000018285F940-0x000000018285F9F0
			public void ChangeWrapGroup(HyperlinkUITextWrap wrap, string newGroupId, int newOrder) {} // 0x0000000189AAE188-0x0000000189AAE2EC
			public void ChangeWrapOrder(HyperlinkUITextWrap wrap, int newOrder) {} // 0x0000000189AAE2EC-0x0000000189AAE358
			public void UpdateWrapDisplayable(UIText uiText) {} // 0x000000018239F030-0x000000018239F180
			public bool IsGroupDisplayable(string groupId) => default; // 0x0000000183A4E270-0x0000000183A4E2C0
			public List<UIText> GetGroupDisplayableUIText(string groupId) => default; // 0x0000000189AAE358-0x0000000189AAE844
			private HyperlinkUITextGroup _GetGroup(string groupId, bool autoCreate = false /* Metadata: 0x01FBC435 */) => default; // 0x0000000183A4E2C0-0x0000000183A4E380
			private bool _IsUITextDisplayable(UIText uiText) => default; // 0x000000018239F180-0x000000018239F230
		}
	
		private struct ImageGOInfo // TypeDefIndex: 49156
		{
			// Fields
			public GameObject go; // 0x00
			public RectTransform rectTransform; // 0x08
			public Image image; // 0x10
		}
	
		// Constructors
		public UIText() {} // 0x0000000182845350-0x0000000182845660
		static UIText() {} // 0x0000000183496650-0x00000001834968A0
	
		// Methods
		public void SetAndResolveTextStyle(string targetText) {} // 0x00000001830823B0-0x00000001830824B0
		public static string GetPhoneticText(PhoneticType phoneticType, string id) => default; // 0x0000000182CDF860-0x0000000182CDFAA0
		public void SetPhoneticText(PhoneticType phoneticType, string id) {} // 0x0000000182CDF7D0-0x0000000182CDF860
		private static string _ResolveTextStyle(string text, int richSeqIndex, out bool hasLink) {
			hasLink = default;
			return default;
		} // 0x00000001830824B0-0x0000000183083FB0
		public static void OnEnvLangChanged(EnvLang lang) {} // 0x0000000182954240-0x0000000182954310
		private void _CreateUpdateFunction() {} // 0x000000018348A3B0-0x000000018348A4E0
		private void _ReleaseUpdateFunction() {} // 0x000000018239E610-0x000000018239E670
		public override void ClearMesh() {} // 0x0000000183535D10-0x0000000183536010
		public override void RefreshPopulateText() {} // 0x00000001825DF9D0-0x00000001825DFB30
		protected override Material LoadMaterial(string materialName) => default; // 0x0000000189AB185C-0x0000000189AB1968
		protected override void OnDestroy() {} // 0x000000018285F5C0-0x000000018285F610
		protected override void Awake() {} // 0x000000018285FB00-0x000000018285FC60
		protected TMP_FontAsset GetFontAsset() => default; // 0x000000018285FF80-0x0000000182860000
		private void _GenerateRuntimeText() {} // 0x000000018285FC60-0x000000018285FD90
		private void _ProcessRichTextInfo() {} // 0x00000001825DFB30-0x00000001825DFE30
		private void _OnPreRenderText(TMP_TextInfo textInfo) {} // 0x0000000183191780-0x0000000183191B50
		private RichTextInfo _ProcessRichTextEntry(RichTextAnalyzer.RichTextParam mainParam, List<RichTextAnalyzer.RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder) => default; // 0x0000000189AB355C-0x0000000189AB3CD4
		public void OnPointerClick(PointerEventData eventData) {} // 0x0000000189AB1B4C-0x0000000189AB1FE4
		public void OnPointerEnter(PointerEventData eventData) {} // 0x0000000189AB1FE4-0x0000000189AB20D0
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000189AB20D0-0x0000000189AB2210
		protected override void Start() {} // 0x00000001833B7E00-0x00000001833B7E30
		protected override void OnEnable() {} // 0x000000018239EE90-0x000000018239EF30
		protected override void OnDisable() {} // 0x000000018239E670-0x000000018239EE90
		private void _UpdateTick(float deltaTime) {} // 0x0000000189AB3D90-0x0000000189AB4130
		public void ShrinkLinkTags() {} // 0x0000000189AB2520-0x0000000189AB2898
		[IDTag(0)]
		public bool TryGetLinkId(Vector3 position, out string linkId) {
			linkId = default;
			return default;
		} // 0x0000000189AB2BD8-0x0000000189AB2D98
		[IDTag(1)]
		public bool TryGetLinkId(int linkIndex, out string linkId) {
			linkId = default;
			return default;
		} // 0x0000000189AB2D98-0x0000000189AB2EF4
		public bool TryGetOriginalLinkId(string linkId, out string originalLinkId) {
			originalLinkId = default;
			return default;
		} // 0x0000000189AB2EF4-0x0000000189AB2FD4
		public bool TryGetCharacterStartPosAndHeight(int charIndex, out Vector3 worldPos, out float charHeight) {
			worldPos = default;
			charHeight = default;
			return default;
		} // 0x0000000189AB2A38-0x0000000189AB2BD8
		public bool TryGetCharacterEndPosAndHeight(int charIndex, out Vector3 worldPos, out float charHeight) {
			worldPos = default;
			charHeight = default;
			return default;
		} // 0x0000000189AB2898-0x0000000189AB2A38
		public void CombineStringWithLanguageSpilt<T1, T2>(T1 t1, T2 t2) {}
		public void CombineStringWithLanguageSpilt(string t1, string t2) {} // 0x0000000189AB14B0-0x0000000189AB155C
		public void CombineStringReverseForIndonesianAndVietnamese<T1, T2>(T1 t1, T2 t2) {}
		public void CombineStringReverseForIndonesianAndVietnamese(string t1, string t2) {} // 0x000000018228C6F0-0x000000018228CD50
		public void SetHyperlinkUITextGroup(string groupId, int order) {} // 0x0000000189AB2210-0x0000000189AB236C
		public static bool IsHyperlinkUITextGroupDisplayable(string groupId) => default; // 0x0000000183A4E1F0-0x0000000183A4E270
		public static List<UIText> GetGroupDisplayableHyperlinkUIText(string groupId) => default; // 0x0000000189AB155C-0x0000000189AB15E4
		public void ClearComponent() {} // 0x000000018285F9F0-0x000000018285FB00
		public void UpdateI18NFontAsset() {} // 0x0000000189AB305C-0x0000000189AB30F0
		private void _RefreshMatTexture() {} // 0x0000000182860B20-0x0000000182860E30
		protected override void SetSharedMaterial(Material mat) {} // 0x0000000189AB236C-0x0000000189AB2520
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x0000000183172370-0x00000001831724A0
		public void OnAfterDeserialize() {} // 0x0000000183242FD0-0x0000000183243050
		protected override TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) => default; // 0x00000001825158D0-0x00000001825159C0
		public static string LocalStringCombineFormat(int count) => default; // 0x0000000189AB1968-0x0000000189AB1B4C
		protected Sprite GetOrLoadSprite(string path) => default; // 0x0000000189AB15E4-0x0000000189AB185C
		protected void DisposeInlineImageCache() {} // 0x000000018285F610-0x000000018285F940
		private void _ClearInlineImage() {} // 0x00000001825DFE30-0x00000001825E0100
		private ImageGOInfo _GetImageGoByIndex(int index) => default; // 0x0000000189AB317C-0x0000000189AB3354
		private GameObject _GetOrCreateImageGO() => default; // 0x0000000189AB3354-0x0000000189AB355C
		private void _ReturnImageGO(GameObject go) {} // 0x0000000189AB3CD4-0x0000000189AB3D90
		[IteratorStateMachine(typeof(__DelayedChangeActiveImageGo_d__110))]
		private IEnumerator _DelayedChangeActiveImageGo() => default; // 0x0000000189AB30F0-0x0000000189AB317C
		public void __iFixBaseProxy_set_text(string P0) {} // 0x0000000189AB3054-0x0000000189AB305C
		public void __iFixBaseProxy_ClearMesh() {} // 0x0000000189AB301C-0x0000000189AB3024
		public void __iFixBaseProxy_RefreshPopulateText() {} // 0x0000000189AB303C-0x0000000189AB3044
		public Material __iFixBaseProxy_LoadMaterial(string P0) => default; // 0x0000000181002730-0x0000000181002740
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000189AB3024-0x0000000189AB302C
		public void __iFixBaseProxy_Awake() {} // 0x0000000189AB3014-0x0000000189AB301C
		public void __iFixBaseProxy_Start() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000189AB3034-0x0000000189AB303C
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000189AB302C-0x0000000189AB3034
		public TMP_FontAsset __iFixBaseProxy_get_m_fontAsset() => default; // 0x0000000183D56CF0-0x0000000183D56D00
		public void __iFixBaseProxy_set_m_fontAsset(TMP_FontAsset P0) {} // 0x0000000184275CF4-0x0000000184275D08
		public void __iFixBaseProxy_set_fontSharedMaterial(Material P0) {} // 0x0000000189AB304C-0x0000000189AB3054
		public void __iFixBaseProxy_SetSharedMaterial(Material P0) {} // 0x0000000189AB3044-0x0000000189AB304C
		public TMP_SubMeshUI __iFixBaseProxy_AddSubTextObject(TextMeshProUGUI P0, MaterialReference P1) => default; // 0x0000000189AB2FD4-0x0000000189AB3014
	}

	public static class UIConst // TypeDefIndex: 49161
	{
		// Fields
		public static bool IS_PC_OR_CONSOLE; // 0x00
		public const float PC_REFERENCE_RESOLUTION_SCALE = 1.25f; // Metadata: 0x01FBC436
		public const float MOBILE_PAD_DEVICE_REFERENCE_RESOLUTION_SCALE = 1.1f; // Metadata: 0x01FBC43A
		public static readonly Vector3 OUT_OF_SCREEN_POS; // 0x04
		public const float STANDARD_HORIZONTAL_RESOLUTION = 1920f; // Metadata: 0x01FBC43E
		public const float STANDARD_VERTICAL_RESOLUTION = 1080f; // Metadata: 0x01FBC442
		public const int INVALID_FINGER_ID = 2147483647; // Metadata: 0x01FBC446
		public static float STANDARD_RATIO; // 0x10
		public const float SCREEN_SPACE_CAMERA_PANEL_DISTANCE = 30f; // Metadata: 0x01FBC447
		public const string UI_BLUR_MATERIAL = "Assets/Beyond/Arts/UI/Materials/M_ui_blur.mat"; // Metadata: 0x01FBC44B
		public const string CS_POPUP_PANEL_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/CSPrefabs/CSPopupPanel.prefab"; // Metadata: 0x01FBC479
		public const string NAVIGATION_TARGET_CLICK_NO_HINT_ACTION_ID = "navigation_target_click_no_hint"; // Metadata: 0x01FBC4C0
		public const string NAVIGATION_TARGET_CLICK_ACTION_ID = "navigation_target_click"; // Metadata: 0x01FBC4E0
		public const string UI_SPRITE_CHAR_HEAD_RECTANGLE = "CharIcon"; // Metadata: 0x01FBC4F8
		public const string UI_SPRITE_DIALOG_OPTION_ICON = "Dialog/Option"; // Metadata: 0x01FBC501
		public const string SLIDER_STICK_SCROLL_HORI_ACTION_ID = "slider_stick_scroll_hori"; // Metadata: 0x01FBC50F
	
		// Properties
		public static int STANDARD_HORIZONTAL_RESOLUTION_INT { get; } // 0x0000000189AAFF08-0x0000000189AAFF18 
		public static int STANDARD_VERTICAL_RESOLUTION_INT { get; } // 0x0000000189AAFF18-0x0000000189AAFF28 
		public static float CUR_STANDARD_HORIZONTAL_RESOLUTION { get; } // 0x00000001828AADA0-0x00000001828AADF0 
		public static float CUR_STANDARD_VERTICAL_RESOLUTION { get; } // 0x00000001828AAD50-0x00000001828AADA0 
		public static int dragThreshold { get; } // 0x0000000189AAFF28-0x0000000189AAFF78 
	
		// Nested types
		public enum AnimationState // TypeDefIndex: 49159
		{
			Stop = 1,
			In = 2,
			Loop = 3,
			Out = 4,
			InEasing = 5,
			Others = 6
		}
	
		public enum CommonUISegment // TypeDefIndex: 49160
		{
			InteractiveEntity = 1,
			LevelScriptModule = 2
		}
	
		// Constructors
		static UIConst() {} // 0x0000000183A38140-0x0000000183A381C0
	
		// Methods
		public static float GetResolutionScale() => default; // 0x0000000182800340-0x00000001828003C0
		public static bool IsPadDevice() => default; // 0x0000000189AAFDC4-0x0000000189AAFF08
	}

	public class UIModelLoader : IDisposable // TypeDefIndex: 49163
	{
		// Fields
		private Dictionary<GameObject, FAssetProxyHandle> m_instance2AssetHandle; // 0x10
		private int m_requestCounter; // 0x18
		private HashSet<int> m_requestIds; // 0x20
		private bool m_disposed; // 0x28
		private static List<MagicaBoneCloth> s_magicaBoneCloths; // 0x00
	
		// Constructors
		public UIModelLoader() {} // 0x0000000182F2F1B0-0x0000000182F2F280
		static UIModelLoader() {} // 0x0000000183CE2BC0-0x0000000183CE2C50
	
		// Methods
		public GameObject LoadModel(string modelPath, Transform parent) => default; // 0x0000000189AB094C-0x0000000189AB0B2C
		public int LoadModelAsync(string modelPath, Transform parent, Action<GameObject> callback) => default; // 0x0000000189AB0768-0x0000000189AB094C
		public void Cancel(int requestId) {} // 0x0000000189AB06E4-0x0000000189AB0768
		public void UnloadModel(GameObject modelGo) {} // 0x0000000189AB0B2C-0x0000000189AB0CA0
		private void _Clear() {} // 0x0000000183219C50-0x000000018321A290
		public void Dispose() {} // 0x0000000183219C10-0x0000000183219C50
	}

	public static class UIUtils // TypeDefIndex: 49164
	{
		// Fields
		private const int MAX_SHARED_INT_STRING = 255; // Metadata: 0x01FBC530
		private static readonly string[] s_sharedIntStringPool; // 0x00
		private static Vector3[] s_worldCorners; // 0x08
	
		// Constructors
		static UIUtils() {} // 0x0000000183CB67A0-0x0000000183CB6850
	
		// Methods
		public static string GetSharedIntString(int value) => default; // 0x0000000182B79EA0-0x0000000182B79FF0
		[IDTag(0)]
		public static bool IsScreenPosInRectTransform(Vector3 screenPos, RectTransform rectTransform, Camera uiCamera) => default; // 0x000000018284E8F0-0x000000018284EB10
		[IDTag(1)]
		public static bool IsScreenPosInRectTransform(Vector2 screenPos, RectTransform rectTransform, Camera uiCamera) => default; // 0x0000000182F63750-0x0000000182F63910
		public static Bounds CalcBoundOfRectTransform(RectTransform transform, RectTransform local) => default; // 0x0000000189AB4454-0x0000000189AB47A0
		public static bool TryGetTouch(int touchId, out UnityEngine.InputSystem.EnhancedTouch.Touch touch) {
			touch = default;
			return default;
		} // 0x0000000189AB4BD0-0x0000000189AB4DEC
		public static void ClearUIComponents(GameObject gameObject) {} // 0x0000000182C71370-0x0000000182C71810
		public static Rect RectTransformToScreenRect(RectTransform rectTransform, Camera uiCamera) => default; // 0x00000001827FEEC0-0x00000001827FF130
		public static Vector3 GetNodeScaleOffset(RectTransform referenceTransform, RectTransform selfTransform) => default; // 0x0000000183989560-0x00000001839896C0
		public static UnityEngine.Color GetColorByString(string strColor) => default; // 0x0000000189AB47A0-0x0000000189AB49BC
		public static float GetCursorTipOffsetX(float defaultOffset) => default; // 0x0000000189AB49BC-0x0000000189AB4A64
		public static float GetCursorTipOffsetInScreen(float defaultOffsetInScreen) => default; // 0x00000001827FF690-0x00000001827FF6C0
	
		// Extension methods
		public static void SetAlpha(this Graphic image, float alpha) {} // 0x00000001825C1550-0x00000001825C1600
		public static void SetColorWithoutAlpha(this Graphic image, UnityEngine.Color color) {} // 0x0000000189AB4A64-0x0000000189AB4AFC
		public static void SetMaskRatio(this RectMask2D mask, float r) {} // 0x0000000189AB4AFC-0x0000000189AB4BD0
	}

	public class ActiveSyncHelper : MonoBehaviour // TypeDefIndex: 49165
	{
		// Fields
		[SerializeField]
		private List<GameObject> _objs; // 0x18
		[SerializeField]
		private bool _isInverse; // 0x20
	
		// Constructors
		public ActiveSyncHelper() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x0000000183633CA0-0x0000000183633CE0
		private void OnEnable() {} // 0x0000000183633D20-0x0000000183633D60
		private void OnDisable() {} // 0x0000000183633CE0-0x0000000183633D20
		public void Sync() {} // 0x0000000183633D60-0x0000000183633F00
	}

	public class Billboard : TickableUIMono // TypeDefIndex: 49166
	{
		// Fields
		public Camera sceneCamera; // 0x68
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public Billboard() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		protected override void OnEnable() {} // 0x0000000189AACA3C-0x0000000189AACAE8
		public override void Tick(float deltaTime) {} // 0x0000000189AACAE8-0x0000000189AACBC8
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	[AddComponentMenu("")]
	[ExecuteAlways]
	[SaveDuringPlay]
	public class CinemachineGyroscopeEffect : CinemachineExtension // TypeDefIndex: 49167
	{
		// Fields
		public float offsetX; // 0x28
		public float offsetY; // 0x2C
	
		// Constructors
		public CinemachineGyroscopeEffect() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x0000000189AACBC8-0x0000000189AACEDC
	}

	public class CommonItemToastList : UIScrollList // TypeDefIndex: 49168
	{
		// Constructors
		public CommonItemToastList() {} // 0x0000000183D00A30-0x0000000183D00A80
	
		// Methods
		public new void ScrollToIndex(int index = -1 /* Metadata: 0x01FBC532 */, bool fastMode = false /* Metadata: 0x01FBC533 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x01FBC534 */, bool graduallyShowInFastMode = false /* Metadata: 0x01FBC535 */) {} // 0x0000000189AAD098-0x0000000189AAD160
		protected void AdjustContainerPos(int index = -1 /* Metadata: 0x01FBC536 */, bool fastMode = false /* Metadata: 0x01FBC537 */) {} // 0x0000000189AACEDC-0x0000000189AAD098
		private Vector2 _GetUnConstraintTargetPos(int index = -1 /* Metadata: 0x01FBC538 */) => default; // 0x0000000189AAD1B4-0x0000000189AAD2A0
	}

	public class ControllerSideMenuItemList : MonoBehaviour // TypeDefIndex: 49170
	{
		// Fields
		[SerializeField]
		public List<MeunItemInfo> menuItems; // 0x18
		public Sprite icon; // 0x20
		public string title; // 0x28
		[Space]
		public RectTransform contentPosTrans; // 0x30
		public bool isFullScreen; // 0x38
		private static readonly HashSet<string> s_forceValidItemList; // 0x00
	
		// Nested types
		[Serializable]
		public class MeunItemInfo // TypeDefIndex: 49169
		{
			// Fields
			public UIButton button; // 0x10
			public UIToggle toggle; // 0x18
			public bool showIcon; // 0x20
			public Sprite sprite; // 0x28
			public UIText text; // 0x30
			public string textId; // 0x38
			public string textIdForToggleOff; // 0x40
			[NonSerialized]
			public int priority; // 0x48
	
			// Properties
			public bool isForceValid { get => default; } // 0x0000000189AAEFD4-0x0000000189AAF024 
	
			// Constructors
			public MeunItemInfo() {} // 0x0000000183D59690-0x0000000183D596A0
	
			// Methods
			public bool IsValid() => default; // 0x0000000189AAEEB8-0x0000000189AAEFD4
			public string GetText() => default; // 0x0000000189AAED88-0x0000000189AAEEB8
			public Sprite GetSprite() => default; // 0x0000000189AAEC78-0x0000000189AAED88
			public void Execute() {} // 0x0000000189AAE9D4-0x0000000189AAEB50
			public string GetItemName() => default; // 0x0000000189AAEB50-0x0000000189AAEC78
		}
	
		// Constructors
		public ControllerSideMenuItemList() {} // 0x0000000183B319A0-0x0000000183B31A30
		static ControllerSideMenuItemList() {} // 0x0000000183CE4D80-0x0000000183CE4E10
	
		// Methods
		public static void ToggleItemForceValid(string itemName, bool forceValid) {} // 0x0000000189AAD3D8-0x0000000189AAD4F4
		public static bool IsItemForceValid(string itemName) => default; // 0x0000000189AAD334-0x0000000189AAD3D8
		public static void ClearForceValidItemList() {} // 0x0000000189AAD2A0-0x0000000189AAD334
	}

	public sealed class CustomNotchAdapt : MonoBehaviour // TypeDefIndex: 49171
	{
		// Fields
		public bool isLeft; // 0x18
		public bool isRight; // 0x19
		public bool isBottom; // 0x1A
		public bool isFullHorizontalStretch; // 0x1B
	
		// Constructors
		public CustomNotchAdapt() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public enum UIStyleInputValidType // TypeDefIndex: 49172
	{
		All = 0,
		Keyboard = 1,
		Touch = 2,
		Controller = 3,
		KeyboardAndTouch = 4,
		KeyboardAndController = 5,
		TouchAndController = 6
	}

	[Flags]
	public enum UIStyleInputValidTypeMask // TypeDefIndex: 49173
	{
		Keyboard = 2,
		Touch = 4,
		Controller = 8,
		All = 14
	}

	public enum ActiveType // TypeDefIndex: 49174
	{
		UseGameObjectActive = 0,
		UseScale = 1
	}

	public class CustomUIStyle : MonoBehaviour // TypeDefIndex: 49176
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		[Space]
		public UIStyleInputValidType inputValidType; // 0x18
		public ActiveType activeType; // 0x1C
		[SerializeField]
		private LayoutElement _layoutElement; // 0x20
		[SerializeField]
		private Animator _animator; // 0x28
		private OverrideValidState m_overrideValidState; // 0x30
	
		// Properties
		public UIStyleInputValidTypeMask inputValidTypeMask { get => default; set {} } // 0x0000000189AAD5F8-0x0000000189AAD6AC 0x0000000189AAD6AC-0x0000000189AAD760
		public OverrideValidState overrideValidState { get => default; set {} } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000189AAD760-0x0000000189AAD76C
		public bool isValid { get => default; } // 0x0000000183271250-0x0000000183271290 
	
		// Nested types
		public enum OverrideValidState // TypeDefIndex: 49175
		{
			None = 0,
			ForceValid = 1,
			ForceNotValid = 2
		}
	
		// Constructors
		public CustomUIStyle() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void _OnActiveTypeChanged() {} // 0x0000000189AAD4F4-0x0000000189AAD5F8
		private void OnDestroy() {} // 0x0000000182CD0EE0-0x0000000182CD0FE0
		private void OnEnable() {} // 0x0000000183271180-0x00000001832711C0
		private void Awake() {} // 0x0000000182CD2060-0x0000000182CD2160
		public void CheckState() {} // 0x00000001832711C0-0x0000000183271250
		public void ToggleActiveState(bool isActive) {} // 0x0000000183271360-0x00000001832715D0
		public static bool IsShowTypeValid(UIStyleInputValidType inputValidType) => default; // 0x0000000183271290-0x0000000183271360
		public static bool IsValidInput(UIStyleInputValidTypeMask inputValidTypeMask) => default; // 0x0000000182CD2C80-0x0000000182CD2CF0
	}

	public class DeactivateNaviOnEnable : MonoBehaviour // TypeDefIndex: 49177
	{
		// Fields
		public string key; // 0x18
	
		// Constructors
		public DeactivateNaviOnEnable() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnEnable() {} // 0x0000000189AAD7FC-0x0000000189AAD88C
		private void OnDisable() {} // 0x0000000189AAD76C-0x0000000189AAD7FC
	}

	[RequireComponent(typeof(LayoutElement))]
	public class DecoLineActiveHelper : TickableUIMono // TypeDefIndex: 49178
	{
		// Fields
		[FormerlySerializedAs("_checkTargets")]
		[SerializeField]
		public List<GameObject> checkTargets; // 0x68
		[FormerlySerializedAs("_secondCheckTargets")]
		[SerializeField]
		[Space]
		public List<GameObject> secondCheckTargets; // 0x70
		[SerializeField]
		[Space]
		private LayoutElement _layoutElement; // 0x78
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Constructors
		public DecoLineActiveHelper() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		private void Reset() {} // 0x0000000189AAD88C-0x0000000189AAD904
		protected override void OnEnable() {} // 0x000000018380EC70-0x000000018380ECB0
		public override void LateTick(float deltaTime) {} // 0x00000001822BF720-0x00000001822BF9B0
		public void Sync() {} // 0x0000000189AAD904-0x0000000189AAD938
		private bool _HasActiveTarget(List<GameObject> targets) => default; // 0x0000000189AAD938-0x0000000189AADA04
		private void _ToggleVisible(bool isVisible) {} // 0x0000000189AADA04-0x0000000189AADAD0
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class Empty4Raycast : MaskableGraphic // TypeDefIndex: 49179
	{
		// Constructors
		protected Empty4Raycast() {} // 0x0000000189AADB3C-0x0000000189AADB5C
	
		// Methods
		protected override void OnPopulateMesh(VertexHelper vh) {} // 0x0000000189AADAD0-0x0000000189AADB34
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0) {} // 0x0000000189AADB34-0x0000000189AADB3C
	}

	public class FitAspectRatioByFOV : MonoBehaviour, DeviceInfoManager.IScreenSizeListener // TypeDefIndex: 49180
	{
		// Fields
		public float referenceAspect; // 0x18
		private float m_referenceVerticalFOV; // 0x1C
		private CinemachineVirtualCamera m_virtualCamera; // 0x20
		private float m_currentAspect; // 0x28
		[SerializeField]
		private float _maxFov; // 0x2C
		private float m_overrideMaxFov; // 0x30
	
		// Properties
		public float maxFov { get => default; set {} } // 0x0000000189AADBF4-0x0000000189AADC54 0x0000000189AADC54-0x0000000189AADC60
	
		// Constructors
		public FitAspectRatioByFOV() {} // 0x0000000183D07BC0-0x0000000183D07BD0
	
		// Methods
		private void Start() {} // 0x0000000189AADB5C-0x0000000189AADBF4
		private void OnEnable() {} // 0x0000000182CD14D0-0x0000000182CD1540
		private void OnDisable() {} // 0x0000000182CD1540-0x0000000182CD15B0
		public void OnScreenSizeChanged(int width, int height) {} // 0x0000000182CD1480-0x0000000182CD14D0
		private void _AdjustFOV() {} // 0x0000000182CD1320-0x0000000182CD13B0
	}

	public class FixRotation : TickableUIMono // TypeDefIndex: 49181
	{
		// Fields
		public Vector3 rotation; // 0x68
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Constructors
		public FixRotation() {} // 0x0000000183CB5C50-0x0000000183CB5C70
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x0000000183414F90-0x0000000183415000
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class FullScreenSceneBlurMarker : MonoBehaviour // TypeDefIndex: 49183
	{
		// Fields
		private static int s_nextId; // 0x00
		public static Action<int, State, bool, bool> s_onFullScreenSceneBlurMarkerStateChanged; // 0x08
		[FormerlySerializedAs("fromUIBlur")]
		public bool useWhiteBlur; // 0x1C
		public bool useSceneColorPS; // 0x1D
	
		// Properties
		public int id { get; private set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
	
		// Nested types
		public enum State // TypeDefIndex: 49182
		{
			OnEnable = 0,
			OnDisable = 1,
			OnDestroy = 2
		}
	
		// Constructors
		public FullScreenSceneBlurMarker() {} // 0x0000000183CFE7E0-0x0000000183CFE7F0
		static FullScreenSceneBlurMarker() {} // 0x0000000183D44720-0x0000000183D44760
	
		// Methods
		private static int _GetNextId() => default; // 0x0000000183B13460-0x0000000183B134D0
		private void Awake() {} // 0x0000000183B13400-0x0000000183B13460
		private void OnEnable() {} // 0x00000001838A4F30-0x00000001838A4FD0
		private void OnDisable() {} // 0x00000001838A4E90-0x00000001838A4F30
		private void OnDestroy() {} // 0x00000001838A4DF0-0x00000001838A4E90
	}

	[RequireComponent(typeof(InputBindingGroupMonoTarget))]
	public class InputBindingGroupNaviDecorator : Selectable, IUIClearable // TypeDefIndex: 49184
	{
		// Fields
		private InputBindingGroupMonoTarget m_inputBindingGroup; // 0x180
		public UnityEvent<bool> onGroupSetAsNaviTarget; // 0x188
	
		// Constructors
		public InputBindingGroupNaviDecorator() {} // 0x0000000182849830-0x00000001828498E0
	
		// Methods
		private void _SetSelfEnabledStateIfNecessary() {} // 0x000000018384BAC0-0x000000018384BB70
		protected override void Awake() {} // 0x0000000182A72990-0x0000000182A72A10
		protected override void OnEnable() {} // 0x000000018384BA40-0x000000018384BAC0
		protected override void OnDestroy() {} // 0x0000000183B137E0-0x0000000183B13820
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode) {} // 0x0000000189AAE8F4-0x0000000189AAE9D4
		public void ClearComponent() {} // 0x0000000183B13820-0x0000000183B13880
		public void __iFixBaseProxy_Awake() {} // 0x0000000189AAE8DC-0x0000000189AAE8E4
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000189AAE8EC-0x0000000189AAE8F4
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000189AAE8E4-0x0000000189AAE8EC
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1) {} // 0x000000018350B670-0x000000018350B680
	}

	public interface IUIClearable : ILuaCallCSharp // TypeDefIndex: 49185
	{
		// Methods
		void ClearComponent();
	}

	[ExecuteInEditMode]
	public class LuaPanel : MonoBehaviour, IUIClearable // TypeDefIndex: 49187
	{
		// Fields
		public static Dictionary<string, LuaPanel> s_openedLuaPanels; // 0x00
		[SerializeField]
		private bool _isPCOnlyPanel; // 0x18
		[SerializeField]
		private bool _isControllerPanel; // 0x19
		[NonSerialized]
		public bool inited; // 0x1A
		[SerializeField]
		private bool _isWorldUI; // 0x1B
		[SerializeField]
		private Vector3 _uiRot; // 0x1C
		[SerializeField]
		private bool _blockWhileAnim; // 0x28
		[FormerlySerializedAs("_animationWrapper")]
		public UIAnimationWrapper animationWrapper; // 0x30
		[SerializeField]
		private AudioUIUtil.UIAudioType _uiAudioType; // 0x38
		public HashSet<UISortingOrder> sortingOrderComps; // 0x50
		private bool m_showRot; // 0x70
		private InputBindingGroupMonoTarget m_inputBindingGroupMonoTarget; // 0x78
		private GraphicRaycaster[] m_graphicRaycasters; // 0x80
		private bool m_started; // 0x88
		private Coroutine m_animationInCoroutine; // 0x90
		private bool m_waitAutoAnimInFinished; // 0x98
		[HideInInspector]
		public DisposedUnityEvent onAnimationInFinished; // 0xA0
		private bool m_animationInFinished; // 0xA8
		private HashSet<GameObject> m_animationInWaitTargets; // 0xB0
	
		// Properties
		public bool blockWhileAnim { get => default; } // 0x0000000183D4ED50-0x0000000183D4ED60 
		public int panelLevel { get; set; } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000183D4EDE0-0x0000000183D4EDF0
		public RectTransform rectTransform { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public Canvas canvas { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public Camera uiCamera { get; set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public float planeDistance { get; set; } // 0x0000000183D50D50-0x0000000183D50D60 0x0000000183D50D80-0x0000000183D50D90
		public int panelId { get; set; } // 0x0000000183D50B30-0x0000000183D50B40 0x0000000183D50B40-0x0000000183D50B50
		public string panelName { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public bool IsWorldUI { get => default; set {} } // 0x0000000183D52270-0x0000000183D52280 0x0000000183D522A0-0x0000000183D522B0
		public bool isPCOnlyPanel { get => default; } // 0x0000000181002A50-0x0000000181002A60 
		public bool isControllerPanel { get => default; } // 0x0000000183D4EF80-0x0000000183D4EF90 
		public bool animationInFinished { get => default; } // 0x00000001811B9C10-0x00000001811B9C20 
	
		// Constructors
		public LuaPanel() {} // 0x00000001828484F0-0x0000000182848630
		static LuaPanel() {} // 0x0000000183CE3A60-0x0000000183CE3AF0
	
		// Methods
		private void Awake() {} // 0x0000000182A72C50-0x0000000182A72D50
		private void _TrySetRot() {} // 0x0000000182A72D50-0x0000000182A72DD0
		public void AddSortingOrderComp(UISortingOrder comp) {} // 0x0000000182A73240-0x0000000182A732B0
		public void RemoveSortingOrderComp(UISortingOrder comp) {} // 0x0000000183A41290-0x0000000183A41330
		private void Start() {} // 0x00000001836CDB20-0x00000001836CDB60
		private void OnEnable() {} // 0x0000000182EA2AF0-0x0000000182EA2BD0
		private void OnDisable() {} // 0x0000000182EA28C0-0x0000000182EA2930
		private void OnDestroy() {} // 0x0000000183858BE0-0x0000000183858C20
		[IteratorStateMachine(typeof(__AutoAnimationInFinish_d__61))]
		private IEnumerator _AutoAnimationInFinish() => default; // 0x0000000182EA2BD0-0x0000000182EA2C50
		public bool InformAnimationInStart(GameObject target) => default; // 0x00000001825CB810-0x00000001825CB8D0
		public void InformAnimationInEnd(GameObject target, bool forceEnd = false /* Metadata: 0x01FBC54C */) {} // 0x00000001828725D0-0x0000000182872670
		private void _TryCallAnimationInFinished(bool forceFinished) {} // 0x0000000182872670-0x00000001828727D0
		public void BlockAllInput() {} // 0x0000000182BA02F0-0x0000000182BA03E0
		public void RecoverAllInput() {} // 0x0000000182BA03E0-0x0000000182BA04D0
		public void ClearComponent() {} // 0x0000000183858C20-0x0000000183858C70
	}

	public class MouseHoverTipsPosHelper : TickableUIMono // TypeDefIndex: 49188
	{
		// Fields
		[SerializeField]
		[Tooltip("\u5047\u8BBEUI\u7684\u5206\u8FA8\u7387\u662F1920*1080\u7684\u60C5\u51B5\uFF0C\u4F1A\u81EA\u52A8\u52A0\u4E0A\u5218\u6D77\u5C4F\u7684\u504F\u79FB")]
		private RectOffset _padding; // 0x68
		private LuaPanel m_panel; // 0x70
		private RectTransform m_rectTransform; // 0x78
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public LuaPanel panel { get => default; } // 0x00000001827FF5E0-0x00000001827FF690 
	
		// Constructors
		public MouseHoverTipsPosHelper() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		protected override void OnAwake() {} // 0x0000000183B2E880-0x0000000183B2E970
		protected override void OnEnable() {} // 0x0000000183B26EF0-0x0000000183B26F30
		public override void LateTick(float deltaTime) {} // 0x00000001837E9A20-0x00000001837E9A60
		public void UpdatePosition() {} // 0x00000001827FF1B0-0x00000001827FF5E0
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class NaviToThisGroupOnEnable : MonoBehaviour // TypeDefIndex: 49189
	{
		// Fields
		public UISelectableNaviGroup target; // 0x18
	
		// Constructors
		public NaviToThisGroupOnEnable() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Reset() {} // 0x0000000189AAF170-0x0000000189AAF1F0
		private void Awake() {} // 0x0000000189AAF024-0x0000000189AAF0D4
		private void OnEnable() {} // 0x0000000189AAF0D4-0x0000000189AAF170
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class NonDrawingGraphic : Graphic, ICanvasRaycastFilter // TypeDefIndex: 49191
	{
		// Fields
		public ShapeType shapeType; // 0xB0
	
		// Properties
		public float Radius { get => default; } // 0x0000000182516C10-0x0000000182516CA0 
	
		// Nested types
		public enum ShapeType // TypeDefIndex: 49190
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public NonDrawingGraphic() {} // 0x0000000182700690-0x00000001827006E0
	
		// Methods
		public override void SetMaterialDirty() {} // 0x0000000183577A50-0x0000000183577A80
		public override void SetVerticesDirty() {} // 0x00000001834D64F0-0x00000001834D6520
		protected override void OnPopulateMesh(VertexHelper vh) {} // 0x0000000189AAF1F0-0x0000000189AAF254
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) => default; // 0x00000001825174B0-0x0000000182517520
		private bool _IsRaycastLocationValidCircle(Vector2 sp, Camera eventCamera) => default; // 0x0000000182516B00-0x0000000182516C10
		public void __iFixBaseProxy_SetMaterialDirty() {} // 0x0000000189AAF254-0x0000000189AAF25C
		public void __iFixBaseProxy_SetVerticesDirty() {} // 0x0000000189AAF25C-0x0000000189AAF264
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0) {} // 0x0000000189AADB34-0x0000000189AADB3C
	}

	[DisallowMultipleComponent]
	public sealed class NotchAdapter : MonoBehaviour // TypeDefIndex: 49193
	{
		// Fields
		[NonSerialized]
		public Vector2 selfMarginSize; // 0x18
		public List<RectTransform> leftSideUIList; // 0x20
		public List<RectTransform> rightSideUIList; // 0x28
		public List<RectTransform> bottomSideUIList; // 0x30
		public List<RectTransform> fullHorizontalStretchUIList; // 0x38
		public bool alwaysFindSideUI; // 0x40
		private CanvasScaler m_canvasScaler; // 0x48
		private UICanvasScaleHelper m_notchHost; // 0x50
	
		// Constructors
		public NotchAdapter() {} // 0x00000001828494C0-0x00000001828495F0
	
		// Methods
		private void Awake() {} // 0x00000001827FCE40-0x00000001827FCEF0
		private void OnDestroy() {} // 0x000000018381BA00-0x000000018381BB10
		public void FindAllSideUI(bool needClear) {} // 0x00000001827FCD00-0x00000001827FCD80
		[IDTag(1)]
		public void ApplyNotch() {} // 0x0000000189AAF264-0x0000000189AAF2CC
		[IDTag(0)]
		public void ApplyNotch(Vector2 curMarginSize) {} // 0x00000001827FE830-0x00000001827FEE20
		public void ClearList() {} // 0x00000001827FCC60-0x00000001827FCD00
		public void ClearNullRef() {} // 0x00000001827FEE20-0x00000001827FEEC0
		public void UnApplyNotch() {} // 0x0000000189AAF2CC-0x0000000189AAF33C
		public void ApplyNewNotch() {} // 0x00000001827FCDC0-0x00000001827FCE40
		private void _UpdateMargeSizeFromNotchInfo(bool forceUpdate = false /* Metadata: 0x01FBC54F */) {} // 0x00000001827FCEF0-0x00000001827FD1E0
		private void _OnCanvasChanged() {} // 0x00000001827FCD80-0x00000001827FCDC0
		private void _RemoveNullRef<T>(List<T> list) {}
		private void _TraverseUI(RectTransform root) {} // 0x00000001827FC420-0x00000001827FC7D0
		private void _TryAddToSideUI(RectTransform rect, CustomNotchAdapt custom = null) {} // 0x00000001827FC7D0-0x00000001827FCA90
	}

	public class ParallaxHelper : MonoBehaviour // TypeDefIndex: 49195
	{
		// Fields
		[SerializeField]
		private List<ParallaxConfig> _configs; // 0x18
		[SerializeField]
		private float _maxOffset; // 0x20
		private float m_curValue; // 0x24
	
		// Properties
		public float curValue { get => default; set {} } // 0x0000000183D524F0-0x0000000183D52500 0x0000000189AC06E8-0x0000000189AC06F4
	
		// Nested types
		[Serializable]
		public class ParallaxConfig // TypeDefIndex: 49194
		{
			// Fields
			public RectTransform target; // 0x10
			public float ratio; // 0x18
			[NonSerialized]
			public Vector2 oriPosition; // 0x1C
	
			// Constructors
			public ParallaxConfig() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public ParallaxHelper() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void InitConfigs() {} // 0x0000000189AC0330-0x0000000189AC04B8
		public void ResetValue() {} // 0x0000000189AC0690-0x0000000189AC06E8
		public void RefreshPos() {} // 0x0000000189AC04B8-0x0000000189AC0690
	}

	public class PercentNumberTweener : TickableUIMono // TypeDefIndex: 49196
	{
		// Fields
		[SerializeField]
		private UIText _text; // 0x68
		[SerializeField]
		private string _format; // 0x70
		[SerializeField]
		private UIImage _progressImg; // 0x78
		private int m_cacheValue; // 0x80
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Constructors
		public PercentNumberTweener() {} // 0x0000000189AC08EC-0x0000000189AC093C
	
		// Methods
		private void Reset() {} // 0x0000000189AC086C-0x0000000189AC08EC
		protected override void OnEnable() {} // 0x0000000189AC080C-0x0000000189AC086C
		public override void LateTick(float deltaTime) {} // 0x0000000189AC06F4-0x0000000189AC080C
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public abstract class UIRecycleLayoutAdapter // TypeDefIndex: 49201
	{
		// Properties
		public UIRecycleLayoutGroup.IViewHandler viewHandler { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Nested types
		public interface ICustomViewType // TypeDefIndex: 49197
		{
			// Properties
			int viewType { get; }
		}
	
		public interface ICustomSpacing // TypeDefIndex: 49198
		{
			// Methods
			float GetCustomSpacing();
		}
	
		public interface IVirtualView : IHotfixable // TypeDefIndex: 49199
		{
			// Methods
			void AttachView(GameObject view);
			void DetachView();
			GameObject GetAttachedView();
			int GetViewID();
			GameObject GetPrefab();
			float GetPreferSize();
		}
	
		public abstract class VirtualView : IVirtualView // TypeDefIndex: 49200
		{
			// Fields
			protected GameObject m_gameObj; // 0x10
	
			// Properties
			public bool isAttached { get; } // 0x0000000189ACA6F8-0x0000000189ACA748 
	
			// Constructors
			protected VirtualView() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void AttachView(GameObject gameObj) {} // 0x0000000189ACA540-0x0000000189ACA5EC
			public void DetachView() {} // 0x0000000189ACA5EC-0x0000000189ACA650
			public GameObject GetAttachedView() => default; // 0x0000000189ACA650-0x0000000189ACA6A0
			public int GetViewID() => default; // 0x0000000189ACA6A0-0x0000000189ACA6F8
			protected abstract void OnViewAttached();
			protected abstract void OnViewDetached();
			public abstract GameObject GetPrefab();
			public abstract float GetPreferSize();
		}
	
		// Constructors
		protected UIRecycleLayoutAdapter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Init(UIRecycleLayoutGroup.IViewHandler handler) {} // 0x0000000189AC6794-0x0000000189AC6804
		public virtual IList<IVirtualView> GenerateViewsForRebuild() => default; // 0x0000000189AC6748-0x0000000189AC6794
		public abstract void OnInit();
	}

	[RequireComponent(typeof(UIRecycleLayoutGroup))]
	public abstract class UIRecycleLayoutSimpleHolder<TVirtualView> : TickableUIMono // TypeDefIndex: 49204
		where TVirtualView : UIRecycleLayoutAdapter.VirtualView
	{
		// Fields
		[SerializeField]
		private UIScrollRect _scrollRect;
		[SerializeField]
		protected float _scrollDuration;
		[SerializeField]
		protected Ease _scrollEase;
		[SerializeField]
		protected bool _enableLoopWrappedNavigation;
		private bool m_isInited;
		protected SimpleAdapter m_simpleAdapter;
		protected UIRecycleLayoutGroup m_layoutGroup;
		[NonSerialized]
		public DisposedUnityEvent doOnceAfterLayout;
		private List<Selectable> m_wrapNaviSelectables;
		protected DG.Tweening.Tween m_scrollTween;
	
		// Nested types
		public class SimpleAdapter : UIRecycleLayoutAdapter // TypeDefIndex: 49202
		{
			// Fields
			private UIRecycleLayoutSimpleHolder<TVirtualView> m_holder;
			private List<IVirtualView> m_virtualViews;
	
			// Constructors
			public SimpleAdapter() {} // Dummy constructor
			public SimpleAdapter(UIRecycleLayoutSimpleHolder<TVirtualView> holder) {}
	
			// Methods
			public override IList<IVirtualView> GenerateViewsForRebuild() => default;
			public void NotifyRebuild() {}
			public void InsertView(int index, TVirtualView virtualView) {}
			public void AppendView(TVirtualView virtualView) {}
			public void AddView(TVirtualView virtualView) {}
			public void RemoveView(int index) {}
			public void RemoveAllViews(bool dontRebuild = false /* Metadata: 0x01FBC552 */) {}
			public int GetCount() => default;
			public TVirtualView GetVirtualView(int index) => default;
			public GameObject GetView(int index) => default;
			public void NotifySizeChanged(TVirtualView virtualView) {}
			public void NotifyAllSizeChanged() {}
			public void NotifySizeChanged(int index) {}
			public override void OnInit() {}
			public void OnDisposed() {}
		}
	
		// Constructors
		protected UIRecycleLayoutSimpleHolder() {}
	
		// Methods
		private void _InitIfNot() {}
		protected override void OnAwake() {}
		private void _AfterLayout() {}
		private void _WrapNavigation(NaviDirection dir) {}
		public abstract void OnAdapterInit();
		public void ScrollTo(int index, bool fastMode = false /* Metadata: 0x01FBC550 */) {}
		protected void ClearScrollTweenIfNeeded() {}
		protected virtual void ScrollToInternal(float normalizedPosition, bool fastMode = false /* Metadata: 0x01FBC551 */) {}
		public GameObject GetView(int index) => default;
		public void NotifyAllSizeChanged() {}
		public void NotifySizeChanged(int index) {}
		public void NotifySizeChanged(TVirtualView virtualView) {}
		public void RemoveView(int index) {}
		public void RemoveAllViews() {}
	}

	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class UIRecycleLayoutGroup : TickableUIMono, ILayoutElement, IUIClearable // TypeDefIndex: 49213
	{
		// Fields
		[SerializeField]
		private Direction _direction; // 0x68
		[SerializeField]
		private RectTransform _viewport; // 0x70
		[SerializeField]
		private RectTransform _content; // 0x78
		[SerializeField]
		private float _notCachedBufferSize; // 0x80
		[SerializeField]
		private int _layoutPriority; // 0x84
		[SerializeField]
		private Padding _padding; // 0x88
		[SerializeField]
		private float _spacing; // 0x98
		private Dictionary<int, LayoutMeta> m_layoutMetaMap; // 0xA0
		private UIRecycleLayoutAdapter m_adapter; // 0xA8
		private ViewMgr m_viewMgr; // 0xB0
		[NonSerialized]
		public DisposedUnityEvent onLayoutUpdated; // 0xC0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public UIRecycleLayoutAdapter adapter { get => default; } // 0x0000000189AC7F3C-0x0000000189AC7FD8 
		protected ViewMgr viewMgr { get => default; } // 0x0000000189AC80D8-0x0000000189AC8188 
		protected float sizeOnAxis { get; private set; } // 0x0000000183D599C0-0x0000000183D599D0 0x0000000183D50850-0x0000000183D50860
		protected float spacing { get => default; } // 0x0000000183D57D90-0x0000000183D57DA0 
		protected Padding padding { get => default; } // 0x0000000183D5C7E0-0x0000000183D5C7F0 
		public float minWidth { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public float minHeight { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public float flexibleWidth { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public float flexibleHeight { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
		public int layoutPriority { get => default; } // 0x0000000183D4F370-0x0000000183D4F380 
		public float preferredWidth { get => default; } // 0x0000000189AC80C4-0x0000000189AC80D8 
		public float preferredHeight { get => default; } // 0x0000000189AC80B0-0x0000000189AC80C4 
		protected float paddingFront { get => default; } // 0x0000000189AC8044-0x0000000189AC80B0 
		protected float paddingBack { get => default; } // 0x0000000189AC7FD8-0x0000000189AC8044 
		protected RectTransform content { get => default; } // 0x0000000183D4EB20-0x0000000183D4EB30 
	
		// Nested types
		public enum Direction // TypeDefIndex: 49205
		{
			Vertical = 0,
			Horizontal = 1
		}
	
		public enum AdaptMode // TypeDefIndex: 49206
		{
			Normal = 0,
			MultiPrefab = 1
		}
	
		public interface IViewHandler // TypeDefIndex: 49207
		{
			// Methods
			UIRecycleLayoutAdapter.IVirtualView GetView(int index);
			int GetViewCount();
			bool InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view);
			bool AddView(UIRecycleLayoutAdapter.IVirtualView view);
			void NotifyViewSizeChanged(UIRecycleLayoutAdapter.IVirtualView view);
			void NotifyAllViewSizeChanged();
			void NotifyRebuild();
			bool RemoveView(UIRecycleLayoutAdapter.IVirtualView view);
			float GetElementPosByIndex(int index);
			Bounds GetElementBoundsByIndex(int index);
			Direction GetDirection();
			float GetSizeOnAxis();
			float GetViewportSizeOnAxis();
			int GetElementIndex(UIRecycleLayoutAdapter.IVirtualView view);
		}
	
		protected struct LayoutMeta // TypeDefIndex: 49208
		{
			// Fields
			public float pos; // 0x00
			public float size; // 0x04
			public int index; // 0x08
			public float curTotalSize; // 0x0C
		}
	
		private class ViewPool // TypeDefIndex: 49209
		{
			// Fields
			private GameObject m_prefab; // 0x10
			private Transform m_container; // 0x18
			private List<GameObject> m_activeObjs; // 0x20
			private List<GameObject> m_pooledObjs; // 0x28
	
			// Properties
			public int viewType { get; private set; } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
	
			// Constructors
			public ViewPool() {} // Dummy constructor
			public ViewPool(int viewType, GameObject prefab, Transform container) {} // 0x0000000189ACA450-0x0000000189ACA540
	
			// Methods
			public GameObject Alloc(out bool isNewlyCreated) {
				isNewlyCreated = default;
				return default;
			} // 0x0000000189AC9FD8-0x0000000189ACA168
			public bool Recycle(GameObject obj) => default; // 0x0000000189ACA2A4-0x0000000189ACA450
			public void RecycleAll() {} // 0x0000000189ACA168-0x0000000189ACA2A4
		}
	
		protected class ViewMgr : IHotfixable, IViewHandler // TypeDefIndex: 49210
		{
			// Fields
			private UIRecycleLayoutGroup m_closure; // 0x10
			private ListDict<int, ViewPool> m_viewPools; // 0x18
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views; // 0x20
	
			// Constructors
			public ViewMgr() {} // Dummy constructor
			public ViewMgr(UIRecycleLayoutGroup closure) {} // 0x0000000189AC9F00-0x0000000189AC9FD8
	
			// Methods
			public void RebuildAll(UIRecycleLayoutAdapter adapter) {} // 0x0000000189AC9A24-0x0000000189AC9C78
			public IList<UIRecycleLayoutAdapter.IVirtualView> GetViews() => default; // 0x0000000189AC9828-0x0000000189AC9878
			public void DetachView(UIRecycleLayoutAdapter.IVirtualView view, GameObject curView) {} // 0x0000000189AC93DC-0x0000000189AC9474
			public void AttachView(UIRecycleLayoutAdapter.IVirtualView view) {} // 0x0000000189AC92F0-0x0000000189AC93DC
			public UIRecycleLayoutAdapter.IVirtualView GetView(int index) => default; // 0x0000000189AC9708-0x0000000189AC9790
			public int GetViewCount() => default; // 0x0000000189AC9694-0x0000000189AC9708
			public bool InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x0000000189AC9878-0x0000000189AC9900
			public bool AddView(UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x0000000189AC9254-0x0000000189AC92F0
			public bool RemoveView(UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x0000000189AC9C78-0x0000000189AC9CEC
			public void NotifyViewSizeChanged(UIRecycleLayoutAdapter.IVirtualView view) {} // 0x0000000189AC99B4-0x0000000189AC9A24
			public void NotifyAllViewSizeChanged() {} // 0x0000000189AC9900-0x0000000189AC995C
			public void NotifyRebuild() {} // 0x0000000189AC995C-0x0000000189AC99B4
			public float GetElementPosByIndex(int index) => default; // 0x0000000189AC95D0-0x0000000189AC9638
			public Bounds GetElementBoundsByIndex(int index) => default; // 0x0000000189AC94CC-0x0000000189AC9564
			public Direction GetDirection() => default; // 0x0000000189AC9474-0x0000000189AC94CC
			public float GetSizeOnAxis() => default; // 0x0000000189AC9638-0x0000000189AC9694
			public float GetViewportSizeOnAxis() => default; // 0x0000000189AC9790-0x0000000189AC9828
			public int GetElementIndex(UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x0000000189AC9564-0x0000000189AC95D0
			private ViewPool _EnsureViewPool(UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x0000000189AC9CEC-0x0000000189AC9E6C
			private void _NotifyLayoutChanged(int fromIndex) {} // 0x0000000189AC9E6C-0x0000000189AC9F00
		}
	
		[Serializable]
		protected struct Padding // TypeDefIndex: 49211
		{
			// Fields
			public int top; // 0x00
			public int left; // 0x04
			public int bottom; // 0x08
			public int right; // 0x0C
		}
	
		public class EmptyAdapter : UIRecycleLayoutAdapter // TypeDefIndex: 49212
		{
			// Constructors
			public EmptyAdapter() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override IList<IVirtualView> GenerateViewsForRebuild() => default; // 0x0000000189ABFF90-0x0000000189ABFFDC
			public override void OnInit() {} // 0x0000000189ABFFDC-0x0000000189AC0020
			public IList<IVirtualView> __iFixBaseProxy_GenerateViewsForRebuild() => default; // 0x0000000189AC0020-0x0000000189AC0028
		}
	
		// Constructors
		public UIRecycleLayoutGroup() {} // 0x0000000189AC7E70-0x0000000189AC7F3C
	
		// Methods
		public void CalculateLayoutInputHorizontal() {} // 0x0000000189AC6804-0x0000000189AC6848
		public void CalculateLayoutInputVertical() {} // 0x0000000189AC6848-0x0000000189AC688C
		private void _ApplyLayoutMeta(UIRecycleLayoutAdapter.IVirtualView view, LayoutMeta meta) {} // 0x0000000189AC6D64-0x0000000189AC70F0
		private Vector2 _GetVisibleRange(Bounds viewBound) => default; // 0x0000000189AC7580-0x0000000189AC7690
		private Bounds _GetElementBoundsFromMeta(LayoutMeta meta) => default; // 0x0000000189AC7224-0x0000000189AC73FC
		public UIRecycleLayoutAdapter SetAdapter(UIRecycleLayoutAdapter adapter) => default; // 0x0000000189AC6CB4-0x0000000189AC6D64
		public void ClearComponent() {} // 0x0000000189AC688C-0x0000000189AC691C
		public override void LateTick(float deltaTime) {} // 0x0000000189AC691C-0x0000000189AC697C
		protected void OnLateTick() {} // 0x0000000189AC697C-0x0000000189AC6CB4
		private void _RebuildAllViews() {} // 0x0000000189AC7818-0x0000000189AC78D0
		private void _UpdateViews(int fromIndex) {} // 0x0000000189AC7B90-0x0000000189AC7E70
		private bool _InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x0000000189AC7690-0x0000000189AC7818
		private bool _RemoveView(UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x0000000189AC7928-0x0000000189AC7ACC
		private void _UpdateViewsFrom(UIRecycleLayoutAdapter.IVirtualView view) {} // 0x0000000189AC7ACC-0x0000000189AC7B90
		private float _GetElementPosByIndex(int index) => default; // 0x0000000189AC74B0-0x0000000189AC7580
		private Bounds _GetElementBoundsByIndex(int index) => default; // 0x0000000189AC70F0-0x0000000189AC7224
		private int _GetElementIndex(UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x0000000189AC73FC-0x0000000189AC74B0
		private void _RefreshLayout() {} // 0x0000000189AC78D0-0x0000000189AC7928
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class UIRecycleMultiHolder : UIRecycleLayoutSimpleHolder<UIRecycleMultiHolder.MultiVirtualView>, IUIClearable // TypeDefIndex: 49216
	{
		// Fields
		[SerializeField]
		private List<Config> _configs; // 0xA8
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onUpdateCell; // 0xB0
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onDetachCell; // 0xB8
		public Func<int, float> getCellDefaultSize; // 0xC0
		public Func<int, string> getCellPrefabKey; // 0xC8
		private Dictionary<string, GameObject> m_prefabMap; // 0xD0
	
		// Nested types
		public class MultiVirtualView : UIRecycleLayoutAdapter.VirtualView // TypeDefIndex: 49214
		{
			// Fields
			private UIRecycleMultiHolder m_closure; // 0x18
			public float preferSize; // 0x20
			public string prefabKey; // 0x28
	
			// Constructors
			public MultiVirtualView() {} // Dummy constructor
			public MultiVirtualView(float initSize, string key, UIRecycleMultiHolder closure) {} // 0x0000000189AC0300-0x0000000189AC0330
	
			// Methods
			public int GetIndex() => default; // 0x0000000189AC0028-0x0000000189AC00F4
			public override GameObject GetPrefab() => default; // 0x0000000189AC00F4-0x0000000189AC0178
			public override float GetPreferSize() => default; // 0x0000000189AC0178-0x0000000189AC01C8
			protected override void OnViewDetached() {} // 0x0000000189AC0264-0x0000000189AC0300
			protected override void OnViewAttached() {} // 0x0000000189AC01C8-0x0000000189AC0264
		}
	
		[Serializable]
		public class Config // TypeDefIndex: 49215
		{
			// Fields
			public string key; // 0x10
			public GameObject cellTemplate; // 0x18
	
			// Constructors
			public Config() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public UIRecycleMultiHolder() {} // 0x0000000189AC8A7C-0x0000000189AC8BEC
	
		// Methods
		public MultiVirtualView GetVirtualView(int index) => default; // 0x0000000189AC8368-0x0000000189AC83F4
		[IDTag(1)]
		public void UpdateCount(int newCount, bool setTop = false /* Metadata: 0x01FBC557 */) {} // 0x0000000189AC8818-0x0000000189AC8898
		[IDTag(0)]
		public void UpdateCount(int newCount, int fastScrollToIndex) {} // 0x0000000189AC8898-0x0000000189AC8A7C
		public void InsertView(int index, string key, float initSize) {} // 0x0000000189AC83F4-0x0000000189AC84E8
		public void AddView(string key, float initSize) {} // 0x0000000189AC8188-0x0000000189AC8268
		public override void OnAdapterInit() {} // 0x0000000189AC84E8-0x0000000189AC8818
		public void ClearComponent() {} // 0x0000000189AC8268-0x0000000189AC8368
	}

	public class UIRecycleSingleHolder : UIRecycleLayoutSimpleHolder<UIRecycleSingleHolder.SimpleVirtualView>, IUIClearable // TypeDefIndex: 49218
	{
		// Fields
		private int m_count; // 0xA8
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onUpdateCell; // 0xB0
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onDetachCell; // 0xB8
		public Func<int, float> getCellDefaultSize; // 0xC0
		[SerializeField]
		[Tooltip("\u53EF\u4EE5\u662FPrefab\u6216\u8005\u9762\u677F\u4E0A\u7684\u8282\u70B9")]
		private GameObject _cellTemplate; // 0xC8
	
		// Nested types
		public class SimpleVirtualView : UIRecycleLayoutAdapter.VirtualView // TypeDefIndex: 49217
		{
			// Fields
			private UIRecycleSingleHolder m_holder; // 0x18
			public float preferSize; // 0x20
	
			// Constructors
			public SimpleVirtualView() {} // Dummy constructor
			public SimpleVirtualView(float initSize, UIRecycleSingleHolder holder) {} // 0x0000000189AC1278-0x0000000189AC1298
	
			// Methods
			public int GetIndex() => default; // 0x0000000189AC0FA4-0x0000000189AC105C
			public override GameObject GetPrefab() => default; // 0x0000000189AC105C-0x0000000189AC10B8
			public override float GetPreferSize() => default; // 0x0000000189AC10B8-0x0000000189AC1108
			protected override void OnViewDetached() {} // 0x0000000189AC11C0-0x0000000189AC1278
			protected override void OnViewAttached() {} // 0x0000000189AC1108-0x0000000189AC11C0
		}
	
		// Constructors
		public UIRecycleSingleHolder() {} // 0x0000000189AC9188-0x0000000189AC9254
	
		// Methods
		public SimpleVirtualView GetVirtualView(int index) => default; // 0x0000000189AC8DA4-0x0000000189AC8E30
		[IDTag(1)]
		public void UpdateCount(int newCount, bool setTop = false /* Metadata: 0x01FBC558 */) {} // 0x0000000189AC8F74-0x0000000189AC8FF4
		[IDTag(0)]
		public void UpdateCount(int newCount, int fastScrollToIndex = -1 /* Metadata: 0x01FBC559 */) {} // 0x0000000189AC8FF4-0x0000000189AC9188
		public void InsertView(int index, string key, float initSize) {} // 0x0000000189AC8E30-0x0000000189AC8F14
		public void AddView(string key, float initSize) {} // 0x0000000189AC8BEC-0x0000000189AC8CBC
		public override void OnAdapterInit() {} // 0x0000000189AC8F14-0x0000000189AC8F74
		public void ClearComponent() {} // 0x0000000189AC8CBC-0x0000000189AC8DA4
	}

	public class SimpleUITextSingleLine : UIText // TypeDefIndex: 49219
	{
		// Fields
		private static ProfilerMarker s_GenerateTextMarker; // 0x00
		private static ProfilerMarker s_GenerateTextPhaseIMarker; // 0x08
		private static ProfilerMarker s_CharacterLookupMarker; // 0x10
		private static ProfilerMarker s_HandleGPOSFeaturesMarker; // 0x18
		private static ProfilerMarker s_CalculateVerticesPositionMarker; // 0x20
		private static ProfilerMarker s_ComputeTextMetricsMarker; // 0x28
		private static ProfilerMarker s_HandleVisibleCharacterMarker; // 0x30
		private static ProfilerMarker s_HandleVisibleCharacterMarker_1; // 0x38
		private static ProfilerMarker s_HandleVisibleCharacterMarker_2; // 0x40
		private static ProfilerMarker s_HandleVisibleCharacterMarker_3; // 0x48
		private static ProfilerMarker s_HandleVisibleCharacterMarker_4; // 0x50
		private static ProfilerMarker s_HandleWhiteSpacesMarker; // 0x58
		private static ProfilerMarker s_HandleHorizontalLineBreakingMarker; // 0x60
		private static ProfilerMarker s_HandleVerticalLineBreakingMarker; // 0x68
		private static ProfilerMarker s_SaveGlyphVertexDataMarker; // 0x70
		private static ProfilerMarker s_ComputeCharacterAdvanceMarker; // 0x78
		private static ProfilerMarker s_HandleCarriageReturnMarker; // 0x80
		private static ProfilerMarker s_HandleLineTerminationMarker; // 0x88
		private static ProfilerMarker s_SavePageInfoMarker; // 0x90
		private static ProfilerMarker s_SaveProcessingStatesMarker; // 0x98
		private static ProfilerMarker s_GenerateTextPhaseIIMarker; // 0xA0
		private static ProfilerMarker s_GenerateTextPhaseIIIMarker; // 0xA8
		public bool m_b; // 0xC80
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText;
	
		// Constructors
		public SimpleUITextSingleLine() {} // 0x0000000189AC0E34-0x0000000189AC0E84
		static SimpleUITextSingleLine() {} // 0x0000000189AC0944-0x0000000189AC0E34
	
		// Methods
		protected override void GenerateTextMesh() {} // 0x0000000189AB4DEC-0x0000000189ABFEEC
		public void __iFixBaseProxy_GenerateTextMesh() {} // 0x0000000189AC093C-0x0000000189AC0944
	}

	[RequireComponent(typeof(VerticalLayoutGroup))]
	public class ToastList : MonoBehaviour, IUIClearable // TypeDefIndex: 49222
	{
		// Fields
		[SerializeField]
		private GameObject _cellTemplate; // 0x18
		[SerializeField]
		private float _showDuration; // 0x20
		[SerializeField]
		private float _delay; // 0x24
		[SerializeField]
		private int _maxShowingCount; // 0x28
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onUpdateCell; // 0x30
		[NonSerialized]
		public DisposedUnityEvent onAllToastFinished; // 0x38
		private int m_totalCount; // 0x40
		private int m_maxFinishedIndex; // 0x44
		private int m_maxShowingIndex; // 0x48
		private int m_waitingCount; // 0x4C
		private Dictionary<int, CellInfo> m_showingCells; // 0x50
		private List<CellInfo> m_cachedCells; // 0x58
	
		// Properties
		public bool inAnimation { get; private set; } // 0x0000000183D4F1A0-0x0000000183D4F1B0 0x0000000183D4F1B0-0x0000000183D4F1C0
	
		// Nested types
		private class CellInfo // TypeDefIndex: 49220
		{
			// Fields
			public int index; // 0x10
			public GameObject obj; // 0x18
			public UIAnimationWrapper animationWrapper; // 0x20
			public Coroutine cor; // 0x28
	
			// Constructors
			public CellInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public ToastList() {} // 0x0000000189AC1E8C-0x0000000189AC1FF0
	
		// Methods
		private void Awake() {} // 0x0000000189AC13EC-0x0000000189AC144C
		private void OnDisable() {} // 0x0000000189AC1684-0x0000000189AC16D4
		private CellInfo _GetCell() => default; // 0x0000000189AC17A0-0x0000000189AC1914
		private void _CacheCell(CellInfo cell) {} // 0x0000000189AC16D4-0x0000000189AC17A0
		public void AddToast(int count, int startIndex = 0 /* Metadata: 0x01FBC55A */) {} // 0x0000000189AC1298-0x0000000189AC13EC
		private void _StartBatch(int batchCount) {} // 0x0000000189AC1B88-0x0000000189AC1C90
		[IteratorStateMachine(typeof(__ShowCell_d__23))]
		private IEnumerator _ShowCell(int delayIndex, CellInfo cell) => default; // 0x0000000189AC1ACC-0x0000000189AC1B88
		private void _TryShowNewCell() {} // 0x0000000189AC1C90-0x0000000189AC1E8C
		private void _OnCellFinished(CellInfo cell) {} // 0x0000000189AC1914-0x0000000189AC1ACC
		public void ClearAllToast() {} // 0x0000000189AC144C-0x0000000189AC1614
		public void ClearComponent() {} // 0x0000000189AC1614-0x0000000189AC1684
	}

	public class UI3DScrollList : UIScrollList // TypeDefIndex: 49223
	{
		// Constructors
		public UI3DScrollList() {} // 0x0000000189AC2704-0x0000000189AC2750
	
		// Methods
		protected override void MoveCellTo(Cell cell, int index) {} // 0x0000000189AC2644-0x0000000189AC26FC
		public void __iFixBaseProxy_MoveCellTo(Cell P0, int P1) {} // 0x0000000189AC26FC-0x0000000189AC2704
	}

	public class UIActionKeyHint : MonoBehaviour, IUIClearable // TypeDefIndex: 49224
	{
		// Fields
		private static readonly UnityEngine.Color NORMAL_COLOR; // 0x00
		private static readonly UnityEngine.Color HIDE_COLOR; // 0x10
		private static readonly UnityEngine.Color DISABLED_COLOR; // 0x20
		private static List<UIActionKeyHint> s_keyHintCache; // 0x30
		private static bool s_inited; // 0x38
		public static bool s_stopCheckBindingEnabledForGuide; // 0x39
		private const string INVALID_KEY_STR = "none"; // Metadata: 0x01FBC563
		private IBindingView m_target; // 0x18
		public string actionId; // 0x20
		public Component btnTarget; // 0x28
		public BindingViewActionType bindingViewActionType; // 0x30
		[SerializeField]
		private bool _useCustomText; // 0x34
		[SerializeField]
		private bool _showSecondAction; // 0x35
		[SerializeField]
		private bool _onlyShowOnLongPress; // 0x36
		[SerializeField]
		private bool _adaptForceGrayState; // 0x37
		[HideInInspector]
		[SerializeField]
		private Transform _content; // 0x38
		[FormerlySerializedAs("_pressHintCanvasGroup")]
		[HideInInspector]
		[SerializeField]
		private CanvasGroup _contentCanvasGroup; // 0x40
		[HideInInspector]
		[SerializeField]
		private UIImage _icon; // 0x48
		[HideInInspector]
		[SerializeField]
		private UIImage _longPressIcon; // 0x50
		[HideInInspector]
		[SerializeField]
		private RectTransform _pressHintNode; // 0x58
		[HideInInspector]
		[SerializeField]
		private UIImage _pressHintProgressImg; // 0x60
		[HideInInspector]
		[SerializeField]
		private UIText _text; // 0x68
		[HideInInspector]
		[SerializeField]
		private UIImage _secondIcon; // 0x70
		[HideInInspector]
		[SerializeField]
		private RectTransform _secondNode; // 0x78
		[HideInInspector]
		[SerializeField]
		private UIImage _modifyIcon; // 0x80
		[SerializeField]
		[Tooltip("\u4E00\u822C\u662F\u6309\u94AE\u4E0A\u540C\u4F4D\u7F6E\u7684Icon\uFF0C\u5728KeyHint\u6D88\u5931\u65F6\u4F1A\u663E\u793A\uFF0C\u5426\u5219\u9690\u85CF")]
		private GameObject _mutexGameObject; // 0x88
		[SerializeField]
		[Tooltip("\u52FE\u9009\u5219\u5728KeyHint\u6D88\u5931\u65F6\uFF08alpha\u4E3A0\uFF09\u6539\u53D8Scale\uFF0C\u8FD9\u6837Layout\u4E2D\u5C31\u4E0D\u4F1A\u5360\u4F4D\u7F6E\u4E86")]
		private bool _changeScaleOnHide; // 0x90
		[NonSerialized]
		public int bindingId; // 0x94
		public Func<bool> checkVirtualMouseClickHintFunc; // 0x98
		[FormerlySerializedAs("m_canvasGroup")]
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0xA0
		public bool autoUpdate; // 0xA8
		private int m_cachedBindingId; // 0xAC
		private bool m_isLongPressAction; // 0xB0
		private float m_lastPressStartTime; // 0xB4
		private const float LONG_PRESS_HINT_HIDE_TIME = 0.2f; // Metadata: 0x01FBC568
		private const float LONG_PRESS_HINT_SHOW_MIN_VALUE = 0f; // Metadata: 0x01FBC56C
	
		// Properties
		private IBindingView target { get => default; } // 0x000000018251A320-0x000000018251A3C0 
		private bool showCanvasGroup { get => default; } // 0x0000000189AC3160-0x0000000189AC31B4 
		public bool hintHidden { get; private set; } // 0x0000000183D5AB90-0x0000000183D5ABA0 0x0000000183D5ABB0-0x0000000183D5ABC0
	
		// Constructors
		public UIActionKeyHint() {} // 0x0000000183539A60-0x0000000183539B50
		static UIActionKeyHint() {} // 0x0000000183B5DE90-0x0000000183B5DFA0
	
		// Methods
		private static void _TryInit() {} // 0x000000018270CB90-0x000000018270CE20
		private static void _RefreshAllKeyHints() {} // 0x0000000189AC2E68-0x0000000189AC2F74
		private static void _OnInputLateTickAll() {} // 0x0000000182517BA0-0x0000000182517DC0
		private static void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType) {} // 0x0000000189AC2D48-0x0000000189AC2DC4
		private void Awake() {} // 0x000000018270CA20-0x000000018270CB90
		private void OnEnable() {} // 0x0000000182C72990-0x0000000182C72B10
		private void OnDisable() {} // 0x0000000182C726C0-0x0000000182C728B0
		private void OnDestroy() {} // 0x0000000183988E50-0x0000000183988EC0
		private void Reset() {} // 0x0000000189AC2750-0x0000000189AC2868
		private void _OnInputLateTick() {} // 0x0000000189AC2E40-0x0000000189AC2E68
		public void UpdateKeyHint() {} // 0x0000000182C72B10-0x0000000182C72E50
		public void SetActionId(string id, bool forceUpdate = false /* Metadata: 0x01FBC55B */) {} // 0x0000000182BDE5C0-0x0000000182BDE620
		public void SetKeyHint(string actId, IBindingView hintTarget, bool forceUpdate = false /* Metadata: 0x01FBC55C */) {} // 0x0000000182BDE620-0x0000000182BDE6C0
		[IDTag(0)]
		public void SetBindingId(int bId, bool forceUpdate = false /* Metadata: 0x01FBC55D */) {} // 0x0000000182BDE6C0-0x0000000182BDE780
		[IDTag(1)]
		public void SetBindingId(int bId, string actId, IBindingView hintTarget, bool forceUpdate = false /* Metadata: 0x01FBC55E */) {} // 0x0000000189AC2868-0x0000000189AC292C
		private void _OnChangeTarget() {} // 0x0000000182BDE780-0x0000000182BDE7F0
		private void _OnInputActionKeyUpdated([IsReadOnly] in EventData<string> data) {} // 0x0000000189AC2DC4-0x0000000189AC2E40
		public void SetSecondActionId(string id, bool isPrimary = false /* Metadata: 0x01FBC55F */) {} // 0x0000000182C72F80-0x0000000182C73040
		private void _SetSecondIcon(PlayerActionInfo actionInfo, bool isPrimary = false /* Metadata: 0x01FBC560 */) {} // 0x0000000182C73040-0x0000000182C731B0
		private void _CheckInteractable(bool isInit) {} // 0x0000000182519A10-0x000000018251A320
		private bool _IsInputEnabled() => default; // 0x00000001829E3020-0x00000001829E3570
		private bool _IsInputGray() => default; // 0x0000000189AC2AF8-0x0000000189AC2D48
		public string GetTextStr() => default; // 0x0000000182BDF930-0x0000000182BDFD80
		public void SetText(string text) {} // 0x0000000189AC292C-0x0000000189AC2998
		public bool GetAndSetActionIcon(UIImage iconImage, PlayerActionInfo actionInfo, bool usingController, out bool isLongPressAction, bool isPrimary = true /* Metadata: 0x01FBC561 */) {
			isLongPressAction = default;
			return default;
		} // 0x0000000182C731B0-0x0000000182C732D0
		public bool GetAndSetActionModifyIcon(PlayerActionInfo actionInfo, bool usingController, bool isPrimary = true /* Metadata: 0x01FBC562 */) => default; // 0x0000000182C728B0-0x0000000182C72990
		private bool _SetKeyCodeSprite(UIImage iconImage, string iconPath) => default; // 0x0000000182C73610-0x0000000182C73750
		private void _CheckVirtualMouseClickHint() {} // 0x0000000189AC2998-0x0000000189AC2A48
		private void _UpdatePressHint() {} // 0x0000000189AC2F74-0x0000000189AC3160
		private void _GetLongPressInfo(out float startTime, out float longPressTime) {
			startTime = default;
			longPressTime = default;
		} // 0x0000000189AC2A48-0x0000000189AC2AF8
		public string GetActionId() => default; // 0x00000001829E2C00-0x00000001829E2D20
		public PlayerActionInfo GetActionInfo() => default; // 0x0000000182C72EE0-0x0000000182C72F80
		public void ClearComponent() {} // 0x0000000182C72570-0x0000000182C726C0
		public void SetContentState(bool contentState) {} // 0x0000000182C72E50-0x0000000182C72EE0
	}

	public class UIAnimationHolder : MonoBehaviour, IAnimationClipSource // TypeDefIndex: 49226
	{
		// Fields
		[SerializeField]
		private List<ClipHolder> _clips; // 0x18
	
		// Nested types
		[Serializable]
		private class ClipHolder // TypeDefIndex: 49225
		{
			// Fields
			public AnimationClip clip; // 0x10
			public string alias; // 0x18
	
			// Constructors
			public ClipHolder() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public UIAnimationHolder() {} // 0x0000000183C8AFC0-0x0000000183C8B040
	
		// Methods
		public AnimationClip FindByName(string name) => default; // 0x0000000189AC321C-0x0000000189AC3284
		public AnimationClip FindByNameOrAlias(string nameOrAlias) => default; // 0x0000000189AC31B4-0x0000000189AC321C
		private AnimationClip _FindByString(string id, bool useAlias) => default; // 0x0000000189AC32D8-0x0000000189AC34EC
		public void GetAnimationClips(List<AnimationClip> results) {} // 0x0000000189AC3284-0x0000000189AC32D8
	}

	public class UIAnimationLoopSynchronizer : MonoBehaviour // TypeDefIndex: 49227
	{
		// Fields
		public string syncLoopAnimKey; // 0x18
		private readonly List<UIAnimationWrapper> m_children; // 0x20
	
		// Constructors
		public UIAnimationLoopSynchronizer() {} // 0x0000000183C8AF40-0x0000000183C8AFC0
	
		// Methods
		public void RegisterChild(UIAnimationWrapper child) {} // 0x0000000183726CB0-0x0000000183726D50
		public void UnregisterChild(UIAnimationWrapper child) {} // 0x0000000189AC34EC-0x0000000189AC3578
		public float GetLoopStartPosition() => default; // 0x00000001832886A0-0x00000001832887B0
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(Animation))]
	public class UIAnimationWrapper : MonoBehaviour, IUIClearable // TypeDefIndex: 49235
	{
		// Fields
		[SerializeField]
		[Tooltip("onEnable\u65F6\u5C31\u4F1A\u89E6\u53D1\u7684\u5165\u573A\u52A8\u6548")]
		private AnimationClip _animationIn; // 0x18
		[SerializeField]
		[Tooltip("\u5165\u573A\u52A8\u6548\u7684\u7F13\u52A8\u90E8\u5206\uFF0C\u4E0D\u4F1A\u88AB\u5F53\u505A In \u72B6\u6001\uFF0C\u540E\u63A5 Loop")]
		private AnimationClip _animationInEasing; // 0x20
		[SerializeField]
		[Tooltip("\u5165\u573A\u52A8\u6548\u8FC7\u540E\u7684loop\u52A8\u6548")]
		private AnimationClip _animationLoop; // 0x28
		[SerializeField]
		[Tooltip("\u624B\u52A8\u64AD\u7684out\u52A8\u6548")]
		private AnimationClip _animationOut; // 0x30
		[FormerlySerializedAs("_autoPlay")]
		[SerializeField]
		[Tooltip("enable\u65F6\u9ED8\u8BA4\u6267\u884C")]
		public bool autoPlay; // 0x38
		[SerializeField]
		[Tooltip("in\u52A8\u6548\u53EA\u6709\u5728\u7B2C\u4E00\u6B21\u64AD\u653E")]
		private bool _onlyOnce; // 0x39
		[SerializeField]
		private bool _needSyncLoopAnim; // 0x3A
		[SerializeField]
		private string _syncLoopAnimKey; // 0x40
		[SerializeField]
		private FOptions _options; // 0x48
		private Animation m_animation; // 0x50
		private Dictionary<string, AnimationRuntime> m_animPool; // 0x58
		private UIAnimationTween m_curTween; // 0x60
		private bool m_isInAutoPlayed; // 0x68
		private UIAnimationLoopSynchronizer m_loopSynchronizer; // 0x70
		private static readonly List<UIAnimationLoopSynchronizer> s_tempSyncList; // 0x00
		[NonSerialized]
		public string curStateName; // 0x78
		[NonSerialized]
		public UIConst.AnimationState curState; // 0x80
		private float m_lastPlayAnimationInStartTime; // 0x84
		private bool m_started; // 0x88
		private CachedSampleClipInfo m_cachedSampleClipInfo; // 0x90
		private bool m_needInformAnimationInEnd; // 0xA0
		private LuaPanel m_panel; // 0xA8
		[AudioString]
		[SerializeField]
		private string _audioOnOpen; // 0xB0
		[AudioString]
		[SerializeField]
		private string _audioOnClose; // 0xB8
	
		// Properties
		public AnimationClip animationIn { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public AnimationClip animationInEasing { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public AnimationClip animationLoop { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public AnimationClip animationOut { get => default; } // 0x0000000181003830-0x0000000181003840 
		public UIAnimationTween curTween { get => default; } // 0x0000000183D4EB00-0x0000000183D4EB10 
		public LuaPanel panel { get => default; } // 0x00000001825CBD80-0x00000001825CBE40 
	
		// Nested types
		private class AnimationRuntime // TypeDefIndex: 49228
		{
			// Fields
			public UIAnimationTween.Options option; // 0x10
			public UnityEngine.AnimationState state; // 0x18
			public bool isPlaying; // 0x20
	
			// Constructors
			public AnimationRuntime() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public float GetClipLength() => default; // 0x00000001825CF420-0x00000001825CF4F0
		}
	
		[Serializable]
		public struct FOptions : ILuaCallCSharp // TypeDefIndex: 49229
		{
			// Fields
			public Ease animEase; // 0x00
	
			// Methods
			public static FOptions GetDefault() => default; // 0x00000001828159A0-0x00000001828159D0
		}
	
		private struct CachedSampleClipInfo // TypeDefIndex: 49230
		{
			// Fields
			public AnimationRuntime runtime; // 0x00
			public float position; // 0x08
			public bool isDirty; // 0x0C
	
			// Constructors
			public CachedSampleClipInfo(bool isDirty) {
				runtime = default;
				position = default;
				this.isDirty = default;
			} // 0x0000000184271BD0-0x0000000184271BF0
		}
	
		// Constructors
		public UIAnimationWrapper() {} // 0x0000000182815830-0x00000001828159A0
		static UIAnimationWrapper() {} // 0x0000000183CE2CE0-0x0000000183CE2D70
	
		// Methods
		public void SetOptions(FOptions options) {} // 0x0000000183D43920-0x0000000183D43960
		private void _InitAnimation() {} // 0x00000001825CCEC0-0x00000001825CD470
		private void _AnimationInLoopCheck() {} // 0x0000000189AC3EF8-0x0000000189AC4118
		private void _AnimationAutomaticallyCheck() {} // 0x0000000189AC3E20-0x0000000189AC3EF8
		private void Awake() {} // 0x00000001825CC7C0-0x00000001825CCD80
		public bool IsStarted() => default; // 0x0000000189AC3AA0-0x0000000189AC3AF0
		public void PlayOutAnimation(TweenCallback callback = null) {} // 0x000000018260AE30-0x000000018260AFB0
		public void SetAnimationInClip(string clipName) {} // 0x000000018228D240-0x000000018228D6B0
		public void SetAnimationInEasingClip(string clipName) {} // 0x000000018228D6B0-0x000000018228DB20
		public void SetAnimationLoopClip(string clipName) {} // 0x000000018228DB20-0x000000018228DF90
		public void SetAnimationOutClip(string clipName) {} // 0x0000000189AC3C64-0x0000000189AC3CDC
		public float GetInClipLength() => default; // 0x0000000189AC38C0-0x0000000189AC3960
		public float GetOutClipLength() => default; // 0x0000000189AC3A00-0x0000000189AC3AA0
		public float GetLoopClipLength() => default; // 0x0000000189AC3960-0x0000000189AC3A00
		public void PlayLoopAnimation() {} // 0x0000000183288580-0x00000001832886A0
		public void PlayInAnimation(TweenCallback callback = null, bool autoPlayLoop = true /* Metadata: 0x01FBC570 */) {} // 0x00000001825CBA80-0x00000001825CBC90
		public void SkipInAnimation() {} // 0x0000000189AC3CDC-0x0000000189AC3E20
		public void SampleToInAnimationBegin() {} // 0x000000018309A180-0x000000018309A240
		public void SampleToInAnimationEnd() {} // 0x0000000182B771E0-0x0000000182B772B0
		public void SampleToOutAnimationBegin() {} // 0x0000000189AC3BA8-0x0000000189AC3C64
		public void SampleToOutAnimationEnd() {} // 0x0000000182B797F0-0x0000000182B79930
		private void _OnInAnimationFinished(bool autoPlayLoop = true /* Metadata: 0x01FBC571 */) {} // 0x00000001832882F0-0x00000001832884D0
		private void _OnInEasingAnimationFinished(bool autoPlayLoop) {} // 0x00000001832884D0-0x0000000183288580
		public UnityEngine.AnimationState GetClip(string aniName) => default; // 0x00000001825CCE20-0x00000001825CCEC0
		public float GetClipLength(string aniName) => default; // 0x0000000182B78A90-0x0000000182B78B40
		private void _SampleClipAtLength(AnimationRuntime runtime, float position) {} // 0x00000001825CDE10-0x00000001825CE210
		public void SampleClipAtPercent(string clipName, float percent, bool clearTween = true /* Metadata: 0x01FBC572 */) {} // 0x0000000182B78A10-0x0000000182B78A90
		public void SampleClip(string clipName, float position, bool clearTween = true /* Metadata: 0x01FBC573 */) {} // 0x00000001825CD8C0-0x00000001825CDE10
		public void ClearTween(bool executeOnComplete = true /* Metadata: 0x01FBC574 */) {} // 0x00000001825CE410-0x00000001825CE5A0
		private bool _CheckShouldAutoPlayAnimationIn() => default; // 0x00000001825CB9F0-0x00000001825CBA30
		private void Start() {} // 0x000000018341C330-0x000000018341C3A0
		private void OnEnable() {} // 0x00000001825CB8D0-0x00000001825CB9F0
		private void OnDisable() {} // 0x00000001825CCD80-0x00000001825CCE20
		private void OnDestroy() {} // 0x00000001834A9200-0x00000001834A92E0
		public bool CheckStopped() => default; // 0x0000000189AC37F4-0x0000000189AC3848
		[IDTag(0)]
		public void Play(AnimationClip animationClip, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x01FBC575 */, float startPlayTime = 0f /* Metadata: 0x01FBC576 */) {} // 0x0000000189AC3AF0-0x0000000189AC3BA8
		[IDTag(1)]
		public void Play(string stateName, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x01FBC57A */, float startPlayTime = 0f /* Metadata: 0x01FBC57B */) {} // 0x0000000183D08600-0x0000000183D08670
		[IDTag(1)]
		public void PlayWithTween(AnimationClip animationClip, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x01FBC57F */, float startPlayTime = 0f /* Metadata: 0x01FBC580 */) {} // 0x00000001825CBCF0-0x00000001825CBD80
		[IDTag(0)]
		public void PlayWithTween(string stateName, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x01FBC584 */, float startPlayTime = 0f /* Metadata: 0x01FBC585 */) {} // 0x00000001825CC330-0x00000001825CC780
		public float GetCurPlayingTime() => default; // 0x0000000189AC3848-0x0000000189AC38C0
		public void PlayOpenAudio() {} // 0x00000001825CBC90-0x00000001825CBCF0
		public void PlayCloseAudio() {} // 0x000000018260AFB0-0x000000018260B010
		public void ClearComponent() {} // 0x00000001825CE620-0x00000001825CE6A0
	}

	public class UIAnimationTween // TypeDefIndex: 49239
	{
		// Fields
		public static readonly Options DEFAULT_OPTION; // 0x00
		private DG.Tweening.Tween m_handler; // 0x10
		private float m_tweenValue; // 0x18
		private GameObject m_animTarget; // 0x20
	
		// Properties
		public DG.Tweening.Tween handler { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public float tweenValue { get => default; } // 0x0000000183D4EBF0-0x0000000183D4EC00 
		public float clipLength { get; private set; } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
	
		// Nested types
		public struct Options // TypeDefIndex: 49236
		{
			// Fields
			public bool isInverse; // 0x00
			public float startPosition; // 0x04
		}
	
		// Constructors
		public UIAnimationTween() {} // Dummy constructor
		public UIAnimationTween(GameObject target, UIAnimationWrapper wrapper, string name) {} // 0x0000000189AC3768-0x0000000189AC37F4
		public UIAnimationTween(GameObject target, UIAnimationWrapper wrapper, string name, Options options) {} // 0x00000001825CBF90-0x00000001825CC330
		static UIAnimationTween() {} // 0x0000000183D2C800-0x0000000183D2C840
	
		// Methods
		public float GetValue() => default; // 0x00000001834E6250-0x00000001834E6280
		private void _SetValue(UIAnimationWrapper wrapper, string name, float value) {} // 0x00000001825CD6F0-0x00000001825CD8C0
	}

	public class UIAnimationSwitchTween : UISwitchTween // TypeDefIndex: 49242
	{
		// Fields
		private UIAnimationWrapper m_animWrapper; // 0x30
		private bool m_dontDisableGameObject; // 0x38
	
		// Nested types
		private class TweenHandler : UISwitchTween.ITweenHandler // TypeDefIndex: 49240
		{
			// Fields
			private UIAnimationSwitchTween m_closure; // 0x10
			private bool m_isIn; // 0x18
			private bool m_pendingClear; // 0x19
			private TweenCallback m_pendingCallback; // 0x20
			private bool m_isComplete; // 0x28
	
			// Constructors
			public TweenHandler() {} // Dummy constructor
			public TweenHandler(UIAnimationSwitchTween closure, bool isIn) {} // 0x0000000189AC22B4-0x0000000189AC23A4
	
			// Methods
			public bool IsPlaying() => default; // 0x0000000189AC1FF0-0x0000000189AC20B8
			public void KillIfNecessary() {} // 0x0000000189AC20B8-0x0000000189AC2178
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback) => default; // 0x0000000189AC2178-0x0000000189AC21F4
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill) => default; // 0x0000000189AC21F4-0x0000000189AC224C
			private void _OnComplete() {} // 0x0000000189AC224C-0x0000000189AC22B4
		}
	
		public struct Builder // TypeDefIndex: 49241
		{
			// Fields
			public UIAnimationWrapper animWrapper; // 0x00
			public bool dontDisableGameObject; // 0x08
	
			// Methods
			public UIAnimationSwitchTween Build() => default; // 0x0000000189ABFEEC-0x0000000189ABFF90
		}
	
		// Constructors
		public UIAnimationSwitchTween() {} // Dummy constructor
		public UIAnimationSwitchTween(UIAnimationWrapper animWrapper) {} // 0x0000000184270470-0x0000000184270480
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide() => default; // 0x0000000189AC3628-0x0000000189AC36BC
		protected override ITweenHandler GenerateTweenOfShow() => default; // 0x0000000189AC36BC-0x0000000189AC3750
		protected override void BeforeShowEffect() {} // 0x0000000189AC35D0-0x0000000189AC3628
		protected override void AfterHideEffect() {} // 0x0000000189AC3578-0x0000000189AC35D0
		protected override void ResetToState(bool isShow) {} // 0x0000000183B2B4C0-0x0000000183B2B580
		private void _SetGameObjectActive(bool isActive) {} // 0x0000000183B2B580-0x0000000183B2B5E0
		public void __iFixBaseProxy_BeforeShowEffect() {} // 0x0000000189AC3758-0x0000000189AC3760
		public void __iFixBaseProxy_AfterHideEffect() {} // 0x0000000189AC3750-0x0000000189AC3758
		public void __iFixBaseProxy_ResetToState(bool P0) {} // 0x0000000189AC3760-0x0000000189AC3768
	}

	public class UIArea : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IUIClearable // TypeDefIndex: 49243
	{
		// Fields
		[HideInInspector]
		public UnityEvent<PointerEventData> onPointerEnter; // 0x18
		[HideInInspector]
		public UnityEvent<PointerEventData> onPointerExit; // 0x20
		private bool m_pointerInArea; // 0x28
		public GameObject _highlightNode; // 0x30
	
		// Properties
		public bool pointerInArea { get => default; } // 0x0000000183D4ED50-0x0000000183D4ED60 
	
		// Constructors
		public UIArea() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void _SetHighlightNodeActive(bool active) {} // 0x0000000189AC43CC-0x0000000189AC447C
		public void OnPointerEnter(PointerEventData eventData) {} // 0x0000000189AC4294-0x0000000189AC4330
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000189AC4330-0x0000000189AC43CC
		private void OnEnable() {} // 0x0000000189AC423C-0x0000000189AC4294
		private void OnDisable() {} // 0x0000000189AC41E0-0x0000000189AC423C
		private void OnDestroy() {} // 0x0000000189AC4184-0x0000000189AC41E0
		public void ClearComponent() {} // 0x0000000189AC4118-0x0000000189AC4184
	}

	public class UIAutoCloseArea : TickableUIMono, IUIClearable, IBindingGroupTarget // TypeDefIndex: 49244
	{
		// Fields
		public static bool s_stopCheckShouldClose; // 0x00
		[FormerlySerializedAs("safeAreas")]
		public List<RectTransform> fixedSafeAreas; // 0x68
		[Tooltip("\u4E34\u65F6\u7684\u5B89\u5168\u533A\uFF0C\u4E00\u822C\u8BBE\u7F6E\u4E3ATips\u7684\u76EE\u6807\uFF0C\u4F1A\u5728Tips\u5173\u95ED\u65F6\u6E05\u9664\u6389")]
		public RectTransform tmpSafeArea; // 0x70
		[Tooltip("\u5982\u679C\u52FE\u9009\uFF0C\u90A3\u4E48\u4EFB\u610F\u952E\u76D8\u8F93\u51FA\u4E5F\u4F1A\u89E6\u53D1\u81EA\u52A8\u5173\u95ED")]
		public bool alsoBlockKeyBoardInput; // 0x78
		[SerializeField]
		private bool _includeInAutoCloseLayer; // 0x79
		private Camera m_fallbackUICamera; // 0x80
		public GameObject toggleObj; // 0x88
		[NonSerialized]
		public DisposedUnityEvent onTriggerAutoClose; // 0x90
		[SerializeField]
		private string _closeActionId; // 0x98
		[SerializeField]
		private bool _enableCloseActionOnController; // 0xA0
		private UIAnimationWrapper m_animationWrapper; // 0xA8
		private static LinkedList<GameObject> s_autoCloseLayerList; // 0x08
		private LuaPanel m_panel; // 0xB0
		private bool m_bindingInit; // 0xC8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public bool includeInAutoCloseLayer { get => default; set {} } // 0x0000000183D51AE0-0x0000000183D51AF0 0x0000000189AC48E0-0x0000000189AC4990
		public LuaPanel panel { get => default; } // 0x000000018284E730-0x000000018284E7F0 
		public int groupId { get; private set; } // 0x0000000183D57DA0-0x0000000183D57DB0 0x0000000183D57DC0-0x0000000183D57DD0
		public IBindingGroupTarget parentTarget { get; private set; } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
		public bool groupEnabled { get => default; } // 0x0000000189AC488C-0x0000000189AC48E0 
	
		// Constructors
		public UIAutoCloseArea() {} // 0x00000001828493C0-0x00000001828494C0
		static UIAutoCloseArea() {} // 0x0000000183CE07A0-0x0000000183CE0830
	
		// Methods
		private void Start() {} // 0x000000018398AF20-0x000000018398AFC0
		private void Reset() {} // 0x0000000189AC4680-0x0000000189AC473C
		public override void LateTick(float deltaTime) {} // 0x000000018284F680-0x000000018284F730
		protected override void OnEnable() {} // 0x00000001836B97A0-0x00000001836B9840
		protected override void OnDisable() {} // 0x00000001836B9650-0x00000001836B9700
		public void ChangeEnableCloseActionOnController(bool enabled) {} // 0x0000000189AC447C-0x0000000189AC44EC
		public void CloseSelf() {} // 0x000000018284E7F0-0x000000018284E8C0
		public void TryCloseSelf() {} // 0x0000000189AC473C-0x0000000189AC47E8
		public void OpenSelf(bool executeOnComplete = true /* Metadata: 0x01FBC589 */) {} // 0x0000000189AC4590-0x0000000189AC4680
		public bool ShouldClose() => default; // 0x0000000182850340-0x0000000182851190
		public void ClearComponent() {} // 0x0000000183D4BEA0-0x0000000183D4BEE0
		private void _AutoCloseToggleObjWhenOut() {} // 0x0000000189AC47E8-0x0000000189AC488C
		public static void AddToAutoCloseLayer(GameObject go) {} // 0x00000001836B9840-0x00000001836B9920
		public static void RemoveFromAutoCloseLayer(GameObject go) {} // 0x00000001836B9700-0x00000001836B97A0
		public static bool IsTopAutoCloseLayer(GameObject go) => default; // 0x000000018284E520-0x000000018284E660
		private Camera _GetUICamera() => default; // 0x000000018284E660-0x000000018284E730
		public void InitBinding() {} // 0x000000018398AFC0-0x000000018398B090
		private void _UpdateState() {} // 0x00000001836B9920-0x00000001836B9A40
		protected override void OnDestroy() {} // 0x0000000189AC44EC-0x0000000189AC4590
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185F2CFD8-0x0000000185F2CFE0
	}

	public class UIBigLogo : MonoBehaviour // TypeDefIndex: 49245
	{
		// Fields
		[SerializeField]
		private GameObject _rootNode; // 0x18
		[SerializeField]
		public UIImage _bigLogoImage; // 0x20
		[SerializeField]
		private GameObject _stretchNode; // 0x28
		[SerializeField]
		public UIImage _stretchImageTop; // 0x30
		[SerializeField]
		public UIImage _stretchImageBottom; // 0x38
		[SerializeField]
		public UIImage _bg; // 0x40
		[SerializeField]
		public UIImage _originalImage; // 0x48
		[SerializeField]
		public UIImage _backgroundMask; // 0x50
		[SerializeField]
		public CanvasGroup _originalImageMain; // 0x58
	
		// Constructors
		public UIBigLogo() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void SetBigLogoEditor(string bigLogoPath, bool useStretchImage, bool showOnTop, bool hideBackground, bool useOriginalImage = false /* Metadata: 0x01FBC58A */) {} // 0x0000000189AC4D4C-0x0000000189AC4DD4
		public void ShowBigLogo(bool useStretchImage, bool showOnTop, bool useOriginalImage = false /* Metadata: 0x01FBC58B */, float originalImageScale = 1f /* Metadata: 0x01FBC58C */) {} // 0x0000000189AC4FB0-0x0000000189AC5170
		public void SetBigLogoMask(UnityEngine.Color maskColor) {} // 0x0000000189AC4DD4-0x0000000189AC4EE8
		public void ClearBigLogoMask() {} // 0x0000000189AC4990-0x0000000189AC4A40
		public void ClearBigLogo(bool showOnTop) {} // 0x0000000189AC4A40-0x0000000189AC4B88
		public void SetAlpha(float alpha, bool showOnTop) {} // 0x0000000189AC4B88-0x0000000189AC4D4C
		public void SetMaskAlpha(float alpha) {} // 0x0000000189AC4EE8-0x0000000189AC4FB0
	}

	public class UIBigRectButton : UIButton, IDragHandler, IBeginDragHandler, IEndDragHandler, UnityEngine.EventSystems.IScrollHandler // TypeDefIndex: 49246
	{
		// Fields
		[SerializeField]
		private UIBigRectHelper _bigRectHelper; // 0x2D8
	
		// Constructors
		public UIBigRectButton() {} // 0x0000000182848630-0x0000000182848640
	
		// Methods
		private void _TryThroughEventDataToBigRectTouchPanelRaycast<T>(PointerEventData eventData, ExecuteEvents.EventFunction<T> eventFunction)
			where T : IEventSystemHandler {}
		public override void OnPointerDown(PointerEventData eventData) {} // 0x00000001822C3B40-0x00000001822C3BE0
		public override void OnPointerUp(PointerEventData eventData) {} // 0x00000001822C3AA0-0x00000001822C3B40
		public void OnDrag(PointerEventData eventData) {} // 0x0000000189AC5214-0x0000000189AC52B8
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189AC5170-0x0000000189AC5214
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000189AC52B8-0x0000000189AC535C
		public void OnScroll(PointerEventData eventData) {} // 0x0000000189AC535C-0x0000000189AC5400
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0) {} // 0x0000000189AC5400-0x0000000189AC5408
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0) {} // 0x0000000189AC5408-0x0000000189AC5410
	}

	public class UIBigRectHelper : TickableUIMono, IUIClearable // TypeDefIndex: 49248
	{
		// Fields
		private bool m_inited; // 0x68
		private bool m_openTweenFinished; // 0x69
		private DisposedUnityEvent m_onOpenTweenFinished; // 0x70
		private float m_zoom; // 0x78
		private float m_zoomValue; // 0x7C
		private Vector2 m_oriSize; // 0x80
		private TweenerCore<Vector3, Vector3, VectorOptions> m_zoomTween; // 0x88
		private TweenerCore<Vector2, Vector2, VectorOptions> m_focusTween; // 0x90
		private Vector2 m_anchoredPosOffset; // 0x98
		private float m_horizontalOffset; // 0xA0
		private float m_verticalOffset; // 0xA4
		private Vector2 m_lastScale; // 0xA8
		private Vector2 m_nodesOffsetWithContainerNode; // 0xB0
		private LuaPanel m_luaPanel; // 0xB8
		private RectTransform m_rootRectTransform; // 0xC0
		private float m_zoomRangeMin; // 0xC8
		private bool m_useOverrideMinZoomRange; // 0xCC
		private float m_zoomRangeOverrideMin; // 0xD0
		[SerializeField]
		private UITouchPanel _touchPanel; // 0xD8
		[SerializeField]
		private RectTransform _containerBigRectTransform; // 0xE0
		[SerializeField]
		private RectTransform _nodes; // 0xE8
		[SerializeField]
		private float _moveSpeed; // 0xF0
		[SerializeField]
		private float _zoomSpeed; // 0xF4
		[SerializeField]
		private float _zoomRangeMax; // 0xF8
		[SerializeField]
		private bool _needResetPositionAndScale; // 0xFC
		[SerializeField]
		private bool _needCenterZoomMobile; // 0xFD
		[SerializeField]
		[Space]
		private List<float> _zoomThresholds; // 0x100
		private DisposedUnityEvent<int, bool> m_zoomEvent; // 0x108
		[SerializeField]
		[Space]
		private float _zoomTweenTime; // 0x110
		[SerializeField]
		private float _moveNodeXOffset; // 0x114
		[SerializeField]
		private float _moveNodeYOffset; // 0x118
		[SerializeField]
		private float _openZoomTweenTime; // 0x11C
		[SerializeField]
		private AnimationCurve _openZoomCurve; // 0x120
		[SerializeField]
		private float _focusNodeTime; // 0x128
		[SerializeField]
		private AnimationCurve _focusNodeCurve; // 0x130
		[SerializeField]
		private bool _containerEdgeAlignLeft; // 0x138
		[SerializeField]
		private RectOffset _padding; // 0x140
		[SerializeField]
		private float _paddingBottomIncludeControllerHintBar; // 0x148
		[SerializeField]
		[Space]
		private float _controllerContainerHorizontalMoveSpeed; // 0x14C
		[SerializeField]
		private float _controllerContainerVerticalMoveSpeed; // 0x150
		[SerializeField]
		private float _controllerZoomRate; // 0x154
		[SerializeField]
		private GameObject _controllerZoomKeyHint; // 0x158
		[SerializeField]
		private bool _useFocusRect; // 0x160
		[SerializeField]
		private bool _useClickKeyHint; // 0x161
		[SerializeField]
		private Transform _raycastRoot; // 0x168
		[SerializeField]
		private RectTransform _controllerFocusRect; // 0x170
		[SerializeField]
		private float _controllerFocusRectHorizontalMoveSpeed; // 0x178
		[SerializeField]
		private float _controllerFocusRectVerticalMoveSpeed; // 0x17C
		[SerializeField]
		private float _controllerFocusLeftBoundPadding; // 0x180
		[SerializeField]
		private float _controllerFocusRightBoundPadding; // 0x184
		[SerializeField]
		private float _controllerFocusBottomBoundPadding; // 0x188
		[SerializeField]
		private float _controllerFocusTopBoundPadding; // 0x18C
		private Vector2 m_lastStickValue; // 0x190
		private PointerEventData m_controllerFocusEventData; // 0x198
		private readonly List<RaycastResult> m_raycastResults; // 0x1A0
		private Selectable m_lastHitSelectable; // 0x1A8
		private int m_bindingGroupId; // 0x1B0
		private const string CLICK_ACTION_ID = "big_rect_click"; // Metadata: 0x01FBC596
		private const string CLICK_NO_HINT_ACTION_ID = "big_rect_click_no_hint"; // Metadata: 0x01FBC5A5
		private const float DELTA_TIME_TO_STICK_VALUE_RATIO = 100f; // Metadata: 0x01FBC5BC
		[NonSerialized]
		public readonly DisposedUnityEvent onControllerMoveStart; // 0x1C0
		[NonSerialized]
		public readonly DisposedUnityEvent onControllerMoveStop; // 0x1C8
		[NonSerialized]
		public readonly DisposedUnityEvent onControllerZoom; // 0x1D0
		[NonSerialized]
		public readonly DisposedUnityEvent onControllerFocusEnterSelectable; // 0x1D8
		[NonSerialized]
		public readonly DisposedUnityEvent onControllerFocusExitSelectable; // 0x1E0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55740-0x0000000183D55750 
		public DisposedUnityEvent OnOpenTweenFinished { get => default; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		private float zoomRangeMin { get => default; } // 0x00000001822C4DD0-0x00000001822C4DF0 
		public DisposedUnityEvent<int, bool> zoomEvent { get => default; } // 0x0000000189AC66F8-0x0000000189AC6748 
		public UITouchPanel touchPanel { get => default; } // 0x0000000183D4E7B0-0x0000000183D4E7C0 
		public int clickBindingId { get; private set; } // 0x0000000183D75FD0-0x0000000183D75FE0 0x0000000183D75FE0-0x0000000183D75FF0
		public bool controllerMoveEnabled { get; set; } // 0x0000000183D58E30-0x0000000183D58E40 0x0000000183D5B920-0x0000000183D5B930
		public bool controllerZoomEnabled { get; set; } // 0x0000000183D5DB70-0x0000000183D5DB80 0x0000000183D75FF0-0x0000000183D76000
	
		// Constructors
		public UIBigRectHelper() {} // 0x0000000182849F90-0x000000018284A270
	
		// Methods
		protected override void OnAwake() {} // 0x0000000182BDBF00-0x0000000182BDC0D0
		public override void Tick(float deltaTime) {} // 0x00000001831EB0C0-0x00000001831EB110
		public override void LateTick(float deltaTime) {} // 0x00000001822C4770-0x00000001822C47C0
		protected override void OnRelease() {} // 0x0000000183D46240-0x0000000183D462A0
		private void _OnDrag(Vector2 value) {} // 0x00000001822C3DB0-0x00000001822C3E60
		public void ManuallyZoom(float value, bool needTween) {} // 0x0000000189AC5814-0x0000000189AC5890
		[IDTag(1)]
		private void _RefreshPivotPosition() {} // 0x0000000189AC6478-0x0000000189AC6520
		private void _OnZoom(float value, bool needTween) {} // 0x0000000189AC5CAC-0x0000000189AC5D38
		private void _SetZoomValueAndScale(float value, bool needTween) {} // 0x00000001822C4A00-0x00000001822C4B40
		private void _SetScale(bool needTween, float zoomTweenTime = 0f /* Metadata: 0x01FBC590 */, AnimationCurve curve = null, TweenCallback onFinish = null) {} // 0x00000001822C4DF0-0x00000001822C4F80
		private void _GetContainerRectBounds(out Vector2 leftBottom, out Vector2 rightTop) {
			leftBottom = default;
			rightTop = default;
		} // 0x00000001822C4470-0x00000001822C45E0
		private Vector2 _GetAdjustedPosition(Vector2 position) => default; // 0x00000001822C42A0-0x00000001822C4470
		private void _PosAdjust() {} // 0x00000001822C3E60-0x00000001822C3ED0
		private void _RefreshPivotPositionToMousePosition() {} // 0x0000000189AC6278-0x0000000189AC6478
		[IDTag(0)]
		private void _RefreshPivotPosition(Vector3 targetScreenPosition) {} // 0x0000000182F63400-0x0000000182F63750
		private void _UpdatePositionOffsetAfterZoomed() {} // 0x00000001822C48F0-0x00000001822C4A00
		private void _TryAlignWhenInit() {} // 0x0000000189AC6520-0x0000000189AC66F8
		public void Init() {} // 0x00000001822C4B40-0x00000001822C4DD0
		[IDTag(0)]
		public void FocusNode(float nodeX, float nodeY, TweenCallback onComplete) {} // 0x0000000189AC5598-0x0000000189AC5748
		[IDTag(1)]
		public void FocusNode(RectTransform nodeRect, bool needTween = true /* Metadata: 0x01FBC594 */, TweenCallback onComplete = null) {} // 0x00000001822C3ED0-0x00000001822C42A0
		public void ZoomToFullRect(TweenCallback onComplete = null) {} // 0x0000000189AC5A58-0x0000000189AC5AE0
		public void ChangePaddingRight(int right) {} // 0x0000000189AC5410-0x0000000189AC5484
		public void SetZoomRangeMax(float maxValue) {} // 0x0000000183D4CE60-0x0000000183D4CEA0
		public void OverrideZoomRangeMin(float minValue) {} // 0x0000000183D4CAC0-0x0000000183D4CB00
		public void SyncZoomValue(float zoomValue, bool needTween = true /* Metadata: 0x01FBC595 */) {} // 0x00000001822C4890-0x00000001822C48F0
		public void GetZoomRange(out float rangeMin, out float rangeMax) {
			rangeMin = default;
			rangeMax = default;
		} // 0x0000000189AC5798-0x0000000189AC5814
		public float GetCurrentZoomValue() => default; // 0x0000000189AC5748-0x0000000189AC5798
		public void ChangePivotPositionToTarget(RectTransform target) {} // 0x0000000189AC5484-0x0000000189AC5598
		public void ResetPivotPositionToScreenCenter() {} // 0x0000000182F63370-0x0000000182F63400
		public void ClearComponent() {} // 0x0000000183C79D70-0x0000000183C79E50
		public void ClearAllTween() {} // 0x0000000183C79E50-0x0000000183C79ED0
		private void _InitControllerBindings() {} // 0x0000000182BDBD60-0x0000000182BDBF00
		private bool _GetIsControllerMoveEnabled() => default; // 0x00000001831EB420-0x00000001831EB4A0
		private bool _GetIsControllerZoomEnabled() => default; // 0x00000001831EB280-0x00000001831EB300
		private void _ResetControllerState() {} // 0x00000001822C3C70-0x00000001822C3DB0
		private void _TickRefreshController(float deltaTime) {} // 0x00000001831EB110-0x00000001831EB170
		private void _TickRefreshControllerStickMove(float deltaTime) {} // 0x00000001831EB300-0x00000001831EB420
		private void _RefreshControllerFocusRaycastResults(bool ignoreTouchPanel, out Selectable hitSelectable, out UITouchPanel hitTouchPanel) {
			hitSelectable = default;
			hitTouchPanel = default;
		} // 0x0000000189AC5D38-0x0000000189AC6278
		private void _TickCheckControllerFocusRaycastTargets() {} // 0x00000001822C47C0-0x00000001822C4890
		private void _OnControllerClick() {} // 0x0000000189AC5AE0-0x0000000189AC5CAC
		private void _TickRefreshControllerStickZoom(float deltaTime) {} // 0x00000001831EB170-0x00000001831EB1D0
		private void _TickRefreshControllerZoomKeyHint() {} // 0x00000001831EB1D0-0x00000001831EB280
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	public class UIBlendImage : UIImage // TypeDefIndex: 49249
	{
		// Fields
		private static Dictionary<string, Material> s_materials; // 0x00
		private Material m_originalMaterial; // 0x228
		private bool m_initialized; // 0x230
	
		// Constructors
		public UIBlendImage() {} // 0x0000000189ACB144-0x0000000189ACB14C
		static UIBlendImage() {} // 0x0000000183CE2C50-0x0000000183CE2CE0
	
		// Methods
		public void SetMaterialKey(string key) {} // 0x0000000189ACAE28-0x0000000189ACB0B8
		public void SetColor(string materialId, UnityEngine.Color c) {} // 0x0000000189ACAD84-0x0000000189ACAE28
		public void SetTexture(string materialId, Texture t) {} // 0x0000000189ACB0B8-0x0000000189ACB144
		public static void ClearMaterialCache() {} // 0x0000000183CE0710-0x0000000183CE07A0
	}

	public class UIBlurMono : TickableUIMono // TypeDefIndex: 49250
	{
		// Fields
		private Canvas m_canvas; // 0x68
		private LuaPanel m_panel; // 0x70
		private int m_sortingOrder; // 0x78
		private HGCamera m_camera; // 0x80
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		public Canvas canvas { get => default; } // 0x0000000182A728E0-0x0000000182A72990 
		private LuaPanel panel { get => default; } // 0x0000000182A727C0-0x0000000182A728E0 
	
		// Constructors
		public UIBlurMono() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		protected override void OnEnable() {} // 0x0000000182A726C0-0x0000000182A727C0
		protected override void OnDisable() {} // 0x0000000182A724F0-0x0000000182A72550
		public override void Tick(float deltaTime) {} // 0x0000000189ACB14C-0x0000000189ACB258
		public void UpdateSortingOrder(int order) {} // 0x0000000189ACB258-0x0000000189ACB2E4
		private HGCamera _GetCamera() => default; // 0x0000000182A72550-0x0000000182A726C0
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	[RequireComponent(typeof(RawImage))]
	public class UIBlurRT : MonoBehaviour // TypeDefIndex: 49251
	{
		// Fields
		[SerializeField]
		private RawImage _rawImage; // 0x18
		[SerializeField]
		private bool _autoUpdate; // 0x20
		[SerializeField]
		private RTExtractionType _rtExtractionType; // 0x24
		[SerializeField]
		private RTExtractionDuration _rtExtractionDuration; // 0x28
		private RTHandle m_rtHandle; // 0x30
		[SerializeField]
		private bool _needUseSceneColorPS; // 0x38
		private RTHandle m_useSceneColorPsRtHandle; // 0x40
		private bool m_curIsUseSceneColorPS; // 0x48
	
		// Properties
		public RawImage rawImage { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public Texture customBlurTexture { get; private set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
	
		// Constructors
		public UIBlurRT() {} // 0x0000000183D1F3A0-0x0000000183D1F3C0
	
		// Methods
		private void Reset() {} // 0x0000000189ACB334-0x0000000189ACB3B4
		public void InitRT() {} // 0x00000001835ED100-0x00000001835ED400
		public void Register() {} // 0x00000001835ED4A0-0x00000001835EE400
		public void UnRegister() {} // 0x0000000189ACB4DC-0x0000000189ACB5BC
		public void UpdateRT() {} // 0x0000000189ACB5BC-0x0000000189ACB690
		private void OnEnable() {} // 0x00000001835ECF30-0x00000001835ECF80
		private void OnDisable() {} // 0x00000001835ECC10-0x00000001835ECC50
		private void OnDestroy() {} // 0x0000000189ACB2E4-0x0000000189ACB334
		private void _Clear() {} // 0x00000001835ECC50-0x00000001835ECD80
		public void SetUseSceneColorPS(bool useSceneColorPS, bool forceUpdate = false /* Metadata: 0x01FBC5C0 */) {} // 0x000000018228DF90-0x000000018228EEB0
		public void SetCustomBlurImg(Texture texture) {} // 0x0000000189ACB3B4-0x0000000189ACB4DC
	}

	public class UIButton : Selectable, IPointerClickHandler, IBindingGroupTarget, IBindingView, IUIClearable // TypeDefIndex: 49254
	{
		// Fields
		[AudioString]
		[FormerlySerializedAs("_audioClick")]
		[SerializeField]
		private string _audioPressStart; // 0x180
		[AudioString]
		[SerializeField]
		private string _audioOnClick; // 0x188
		[AudioString]
		[SerializeField]
		private string _audioRelease; // 0x190
		[AudioString]
		[SerializeField]
		private string _audioLongPress; // 0x198
		[AudioString]
		[SerializeField]
		private string _audioInvalid; // 0x1A0
		[SerializeField]
		[Tooltip("AutoTriggerOnClick\u65F6\u4E0D\u89E6\u53D1PressStart\u548COnClick\u7684\u97F3\u6548")]
		private bool _noAudioWhenAutoTriggerOnClick; // 0x1A8
		private const float MIN_DRAG_DIST = 10f; // Metadata: 0x01FBC5C2
		private const float DOUBLE_CLICK_MAX_INTERVAL = 0.3f; // Metadata: 0x01FBC5C6
		public UIEvent<PointerEventData> onClick; // 0x1B0
		public UIEvent<PointerEventData> onDoubleClick; // 0x1B8
		[SerializeField]
		public bool _ignoreClickOnDrag; // 0x1C0
		[SerializeField]
		public bool _clickThrough; // 0x1C1
		[SerializeField]
		[Tooltip("\u53EA\u662F\u4E24\u6B21\u5355\u51FB\u89E6\u53D1\u7684CD")]
		private float _clickCd; // 0x1C4
		[SerializeField]
		[Tooltip("\u4E0D\u53EF\u70B9\u51FB\u65F6\u5F39\u51FA\u7684Toast\u6587\u672CKey")]
		private LangKey _invalidClickLangKey; // 0x1C8
		private float m_lastValidClickTime; // 0x1D8
		private float m_lastClickTime; // 0x1DC
		[SerializeField]
		private bool _useClickAnimation; // 0x1E0
		[SerializeField]
		private AnimationCurve _clickAnimationCurve; // 0x1E8
		[SerializeField]
		private float _clickAnimationDuration; // 0x1F0
		private Vector3 m_oriScale; // 0x1F4
		private Coroutine m_clickCor; // 0x200
		private bool m_scaled; // 0x208
		public UIEvent<PointerEventData> onLongPress; // 0x210
		public UIEvent<PointerEventData> onPressStart; // 0x218
		public UIEvent<PointerEventData> onPressEnd; // 0x220
		[SerializeField]
		private float _longPressTime; // 0x228
		[SerializeField]
		public bool _ignoreClickOnLongPress; // 0x22C
		[FormerlySerializedAs("_longPressImg")]
		public UIImage longPressImg; // 0x230
		[SerializeField]
		private float _longPressImgShowDelay; // 0x238
		[SerializeField]
		private float _longPressMaxDragDist; // 0x23C
		[SerializeField]
		private bool _forceEnableButtonPressAudio; // 0x240
		private bool m_pressDownWaitClick; // 0x241
		private Coroutine m_longPressCor; // 0x250
		private bool m_triggeredLongPress; // 0x258
		public bool noTextBtn; // 0x259
		private UIText m_autoFindLabel; // 0x260
		[SerializeField]
		private UIText _label; // 0x268
		private int m_groupId; // 0x270
		private bool m_bindingInit; // 0x274
		private string m_customBindingViewLabelText; // 0x280
		public string hintTextId; // 0x288
		[SerializeField]
		private RectTransform _redDotTrans; // 0x298
		[AudioString]
		[SerializeField]
		private string _audioGamePadLongPress; // 0x2A0
		private LuaPanel m_panel; // 0x2A8
		private int m_hoverBindingGroupId; // 0x2B0
		[NonSerialized]
		public string clickHintTextId; // 0x2B8
		[NonSerialized]
		public string longPressHintTextId; // 0x2C0
		[FormerlySerializedAs("actionOnSetNaviTarget")]
		[SerializeField]
		private ActionOnSetNaviTarget _actionOnSetNaviTarget; // 0x2C8
		[FormerlySerializedAs("useNoHintAction")]
		[SerializeField]
		private bool _useNoHintAction; // 0x2CC
	
		// Properties
		public Vector2 startPressPos { get; private set; } // 0x0000000183D76030-0x0000000183D76050 0x0000000183D76070-0x0000000183D76080
		public int pressTouchId { get; private set; } // 0x0000000183D76020-0x0000000183D76030 0x0000000183D76060-0x0000000183D76070
		public float longPressTime { get => default; } // 0x0000000183D76010-0x0000000183D76020 
		public Vector2 curPressPos { get => default; } // 0x0000000189ACBC8C-0x0000000189ACBCE4 
		public bool triggeredLongPress { get => default; } // 0x0000000183D59820-0x0000000183D59830 
		public string text { get => default; set {} } // 0x0000000189ACBCE4-0x0000000189ACBDBC 0x0000000183822480-0x0000000183822590
		public UIText label { get => default; } // 0x0000000183822590-0x00000001838226D0 
		public bool groupEnabled { get => default; } // 0x00000001833BE090-0x00000001833BE100 
		public int groupId { get => default; } // 0x00000001822B0E50-0x00000001822B0E70 
		public IBindingGroupTarget parentTarget { get => default; } // 0x0000000183D57270-0x0000000183D57280 
		public InputBindingGroupMonoTarget parent { get; private set; } // 0x0000000183D57270-0x0000000183D57280 0x00000001858B3EC0-0x00000001858B3ED4
		public string bindingViewActionId { get => default; } // 0x0000000183342280-0x0000000183342360 
		public string customBindingViewLabelText { get => default; set {} } // 0x0000000183D573B0-0x0000000183D573C0 0x0000000183C8A840-0x0000000183C8A900
		public string bindingViewLabelText { get => default; } // 0x0000000184272C90-0x0000000184272C98 
		public string hintText { get => default; } // 0x00000001836AFB90-0x00000001836AFC70 
		public DisposedUnityEvent bindingViewUpdateEvent { get; } // 0x0000000183D57040-0x0000000183D57050 
		public RectTransform redDotTrans { get => default; } // 0x0000000183D57180-0x0000000183D57190 
		public bool bindingEnabled { get => default; } // 0x0000000189ACBC84-0x0000000189ACBC8C 
		public BindingViewState bindingViewState { get => default; } // 0x000000018251B0F0-0x000000018251B890 
		public LuaPanel panel { get => default; } // 0x000000018284D6C0-0x000000018284D780 
		public int hoverBindingGroupId { get => default; } // 0x00000001824B2330-0x00000001824B2350 
		public ActionOnSetNaviTarget actionOnSetNaviTarget { get => default; } // 0x0000000183D76000-0x0000000183D76010 
		public int hoverConfirmBindingId { get; private set; } // 0x0000000182A18C40-0x0000000182A18C50 0x0000000183D76050-0x0000000183D76060
		bool IBindingView.interactable { get => default; } // 0x0000000189ACB690-0x0000000189ACB6E0 
	
		// Constructors
		public UIButton() {} // 0x0000000182848640-0x00000001828488B0
	
		// Methods
		protected override void Awake() {} // 0x0000000182C70580-0x0000000182C705D0
		protected override void OnEnable() {} // 0x00000001822B08B0-0x00000001822B0950
		protected override void OnDisable() {} // 0x00000001822B0780-0x00000001822B07F0
		protected override void OnDestroy() {} // 0x0000000182C71A00-0x0000000182C71AF0
		protected override void _NotifyIsHover(bool isHover) {} // 0x0000000182C6F4F0-0x0000000182C6F620
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x000000018284C860-0x000000018284D3E0
		private void _Press(PointerEventData eventData = null) {} // 0x000000018284D3E0-0x000000018284D6C0
		private void _PlayClickAnimation(bool reverse = false /* Metadata: 0x01FBC5C1 */) {} // 0x000000018284E470-0x000000018284E4B0
		[IteratorStateMachine(typeof(__DoClickAnimation_d__30))]
		private IEnumerator _DoClickAnimation() => default; // 0x0000000189ACB9D0-0x0000000189ACBA60
		public override void OnPointerDown(PointerEventData eventData) {} // 0x000000018284E1A0-0x000000018284E3E0
		public override void OnPointerUp(PointerEventData eventData) {} // 0x000000018284E0B0-0x000000018284E1A0
		[IteratorStateMachine(typeof(__OnPress_d__59))]
		private IEnumerator _OnPress(PointerEventData eventData) => default; // 0x000000018284E3E0-0x000000018284E470
		private void _StopLongPressCor() {} // 0x00000001822B07F0-0x00000001822B08B0
		public void ClearComponent() {} // 0x0000000182C71C50-0x0000000182C71D50
		public void InitBinding() {} // 0x00000001822B0F30-0x00000001822B1470
		public override void OnInteractableChanged() {} // 0x0000000183CF0040-0x0000000183CF0080
		private void _UpdateState() {} // 0x00000001822B0C40-0x00000001822B0DC0
		public string GetBindingViewActionId(BindingViewActionType actionType) => default; // 0x0000000183342200-0x0000000183342280
		void IBindingView.OnInputKeyDown(bool isActionTrigger) {} // 0x00000001839D5E80-0x00000001839D5FB0
		void IBindingView.OnInputKeyUp(bool isActionTrigger) {} // 0x0000000183973430-0x0000000183973540
		private void _OnUpdateKey() {} // 0x0000000183544090-0x0000000183544120
		private string _GetUIButtonKeyHintActionId(UIEvent<PointerEventData> buttonEvent) => default; // 0x0000000183342360-0x00000001833423D0
		protected override void _RefreshHoverEnableNode(bool active) {} // 0x00000001824B1F30-0x00000001824B2200
		public override bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId) {
			clickHintTextId = default;
			longPressHintTextId = default;
			return default;
		} // 0x0000000189ACB79C-0x0000000189ACB82C
		public override void OnNaviTargetEnabledAgain() {} // 0x0000000189ACB82C-0x0000000189ACB8BC
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode) {} // 0x0000000189ACBA60-0x0000000189ACBBEC
		private void _InitActionOnSetNaviTarget() {} // 0x0000000182C6D420-0x0000000182C6D570
		private void _ToggleNaviInputBinding(bool active) {} // 0x0000000189ACBBEC-0x0000000189ACBC84
		public void ChangeActionOnSetNaviTarget(ActionOnSetNaviTarget action) {} // 0x0000000189ACB6E0-0x0000000189ACB79C
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0) {} // 0x0000000189ACB964-0x0000000189ACB96C
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0) {} // 0x0000000189ACB96C-0x0000000189ACB974
		public void __iFixBaseProxy_Awake() {} // 0x0000000189AAE8DC-0x0000000189AAE8E4
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000189AAE8EC-0x0000000189AAE8F4
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018361D5F0-0x000000018361D600
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000189AAE8E4-0x0000000189AAE8EC
		public void __iFixBaseProxy__NotifyIsHover(bool P0) {} // 0x0000000189ACB974-0x0000000189ACB97C
		public void __iFixBaseProxy_OnInteractableChanged() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy__RefreshHoverEnableNode(bool P0) {} // 0x0000000189ACB97C-0x0000000189ACB984
		public bool __iFixBaseProxy_GetMouseActionHints(out string P0, out string P1) {
			P0 = default;
			P1 = default;
			return default;
		} // 0x0000000189ACB954-0x0000000189ACB95C
		public void __iFixBaseProxy_OnNaviTargetEnabledAgain() {} // 0x0000000189ACB95C-0x0000000189ACB964
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1) {} // 0x000000018350B670-0x000000018350B680
	}

	public enum CanvasMatchMode // TypeDefIndex: 49255
	{
		Width = 0,
		Height = 1
	}

	public class UICanvasScaleHelper : MonoBehaviour, DeviceInfoManager.IScreenSizeListener, IUIClearable // TypeDefIndex: 49258
	{
		// Fields
		[SerializeField]
		private bool _useCustomStandardResolution; // 0x18
		[SerializeField]
		private Vector2 _customStandardResolution; // 0x1C
		[SerializeField]
		private float _customPCReferenceResolutionScale; // 0x24
		private HashSet<Canvas> m_canvasList; // 0x28
		private HashSet<CanvasScaler> m_canvasScalerList; // 0x30
		private bool m_isCanvasChanged; // 0x38
		public bool isSingleCanvas; // 0x39
		public Camera uiCamera; // 0x40
		public DisposedUnityEvent onScreenSizeChanged; // 0x48
		public DisposedUnityEvent onCanvasChanged; // 0x50
	
		// Properties
		public float standardHorizontalResolution { get => default; } // 0x00000001827FF8D0-0x00000001827FF910 
		public float standardVerticalResolution { get => default; } // 0x00000001827FF890-0x00000001827FF8D0 
		public float standardResolutionScale { get => default; } // 0x00000001827FF910-0x00000001827FF970 
		public HashSet<CanvasScaler> canvasScalerList { get => default; } // 0x0000000189ACBFCC-0x0000000189ACC01C 
	
		// Nested types
		public struct FWorldCanvasParams // TypeDefIndex: 49256
		{
			// Fields
			public float screenRatio; // 0x00
			public Vector2 screenSize; // 0x04
			public Vector2 uiRootSize; // 0x0C
			public Vector3 uiRootScale; // 0x14
		}
	
		public struct FScreenCanvasParams // TypeDefIndex: 49257
		{
			// Fields
			public float screenRatio; // 0x00
			public Vector2 screenSize; // 0x04
			public CanvasMatchMode matchMode; // 0x0C
			public float matchWidthOrHeight; // 0x10
		}
	
		// Constructors
		public UICanvasScaleHelper() {} // 0x0000000182847080-0x00000001828471E0
	
		// Methods
		private void Awake() {} // 0x000000018380FB70-0x000000018380FBB0
		private void _OnInit() {} // 0x000000018380FBB0-0x000000018380FCB0
		private void Start() {} // 0x0000000182CD1A00-0x0000000182CD1B80
		private void OnDestroy() {} // 0x0000000182CD0FE0-0x0000000182CD1160
		public void UpdateCanvas() {} // 0x00000001828A9E10-0x00000001828AAB40
		public void OnScreenSizeChanged(int width, int height) {} // 0x0000000182CD18F0-0x0000000182CD1950
		public void AddCanvas(Canvas c, CanvasScaler s) {} // 0x00000001827FF710-0x00000001827FF820
		public void RemoveCanvas(Canvas c, CanvasScaler s) {} // 0x000000018397EA50-0x000000018397EAF0
		private void _OnInputTypeChanged() {} // 0x0000000189ACBE18-0x0000000189ACBFCC
		private void _CanvasOnWillRenderCanvases() {} // 0x0000000183079A10-0x0000000183079CE0
		public static FWorldCanvasParams CalcWorldCanvasParams(Camera camera, Transform uiRoot, bool useLocalPos = false /* Metadata: 0x01FBC5CC */) => default; // 0x00000001828AAB40-0x00000001828AAD50
		public static FScreenCanvasParams CalcScreenCanvasParams() => default; // 0x00000001828AC370-0x00000001828AC440
		public static float CalcCurrentScreenRatio(out Vector2 screenSize) {
			screenSize = default;
			return default;
		} // 0x00000001828AC5A0-0x00000001828AC600
		public Vector2 GetProperCanvasResolution() => default; // 0x00000001827FF820-0x00000001827FF890
		public void ForceCanvasUpdate() {} // 0x0000000189ACBDBC-0x0000000189ACBE18
		public void ClearComponent() {} // 0x0000000182CD0D20-0x0000000182CD0D70
	}

	public class UIColorGroup : NonDrawingGraphic // TypeDefIndex: 49262
	{
		// Fields
		[SerializeField]
		private Graphic[] _colorElements; // 0xB8
		[HideInInspector]
		[SerializeField]
		private UnityEngine.Color _color; // 0xC0
		private bool m_isOperating; // 0xD0
		private List<DynEle> m_dynList; // 0xD8
	
		// Properties
		public override UnityEngine.Color color { get => default; set {} } // 0x0000000183D6C030-0x0000000183D6C040 0x0000000189ACCA9C-0x0000000189ACCBA4
	
		// Nested types
		private struct CommonParams // TypeDefIndex: 49259
		{
			// Fields
			public float alpha; // 0x00
			public float duration; // 0x04
			public bool ignoreTimeScale; // 0x08
			public UnityEngine.Color targetColor; // 0x0C
			public bool useAlpha; // 0x1C
			public bool useRGB; // 0x1D
			public bool isStaticColorOpt; // 0x1E
		}
	
		private delegate void GraphicOpt(Graphic graphic, CommonParams param); // TypeDefIndex: 49260; 0x0000000185015A50-0x0000000185015A80
	
		private struct DynEle // TypeDefIndex: 49261
		{
			// Fields
			public string groupId; // 0x00
			public Graphic graphic; // 0x08
			public bool useStaticColor; // 0x10
		}
	
		// Constructors
		public UIColorGroup() {} // 0x00000001827006E0-0x0000000182700700
	
		// Methods
		public void AttachGraphic(Graphic graphic, bool useStaticColor = true /* Metadata: 0x01FBC5CD */) {} // 0x0000000189ACC01C-0x0000000189ACC27C
		public void AttachGraphicsWithGroup(List<Graphic> graphic, string groupId) {} // 0x0000000189ACC27C-0x0000000189ACC598
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) {} // 0x0000000189ACC598-0x0000000189ACC6B4
		[IDTag(0)]
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) {} // 0x0000000189ACC6B4-0x0000000189ACC7F4
		[IDTag(1)]
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) {} // 0x00000001836F87F0-0x00000001836F88F0
		private void _ApplyOptToGraphics(GraphicOpt opt, CommonParams param) {} // 0x00000001836F8980-0x00000001836F8BD0
		private static void _CrossFadeAlpha(Graphic graphic, CommonParams param) {} // 0x0000000189ACC890-0x0000000189ACC924
		private static void _CrossFadeColorRGB(Graphic graphic, CommonParams param) {} // 0x0000000189ACC924-0x0000000189ACCA00
		private static void _CrossFadeColorAlpha(Graphic graphic, CommonParams param) {} // 0x00000001838C6D30-0x00000001838C6DC0
		private static void _SetColor(Graphic graphic, CommonParams param) {} // 0x0000000189ACCA00-0x0000000189ACCA9C
		public void __iFixBaseProxy_set_color(UnityEngine.Color P0) {} // 0x0000000189ACC870-0x0000000189ACC890
		public void __iFixBaseProxy_CrossFadeAlpha(float P0, float P1, bool P2) {} // 0x0000000189ACC7F4-0x0000000189ACC804
		public void __iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, float P1, bool P2, bool P3, bool P4) {} // 0x0000000189ACC834-0x0000000189ACC870
		public void __iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, float P1, bool P2, bool P3) {} // 0x0000000189ACC804-0x0000000189ACC834
	}

	public class UIControllerKeyIcon : MonoBehaviour // TypeDefIndex: 49263
	{
		// Fields
		[SerializeField]
		[Tooltip("\u65E0\u9700\u586B\u5199\u56FE\u7247\u5B8C\u6574\u540D\u79F0\uFF0C\u53EA\u9700\u586B\u5199\u5DEE\u5206\u90E8\u5206\uFF0C\u4F8B\u5982icon_playstation_arrowdown\uFF0C\u5219\u53EA\u9700\u586B\u5199arrowdown")]
		private string _keyIconName; // 0x18
		private UIImage m_image; // 0x20
		private static List<UIControllerKeyIcon> s_iconCache; // 0x00
		private static bool s_initialized; // 0x08
	
		// Constructors
		public UIControllerKeyIcon() {} // 0x000000018426FE60-0x000000018426FE68
		static UIControllerKeyIcon() {} // 0x0000000183CBCD70-0x0000000183CBCE10
	
		// Methods
		private static void _TryStaticInit() {} // 0x0000000189ACD0B4-0x0000000189ACD23C
		private static void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType) {} // 0x0000000189ACCF18-0x0000000189ACD0B4
		private void Awake() {} // 0x0000000189ACCBA4-0x0000000189ACCC50
		private void OnEnable() {} // 0x0000000189ACCCF4-0x0000000189ACCDA0
		private void OnDisable() {} // 0x0000000189ACCC50-0x0000000189ACCCF4
		public void SetKeyIconName(GamepadKeyCode keyCode) {} // 0x0000000189ACCE7C-0x0000000189ACCF18
		public void RefreshKeyIcon() {} // 0x0000000189ACCDA0-0x0000000189ACCE7C
	}

	public class UICustomLayout : UIBehaviour // TypeDefIndex: 49264
	{
		// Fields
		[SerializeField]
		private RectTransform _dragArea; // 0x18
		public List<UICustomLayoutHandle> layoutHandles; // 0x20
		private JSONArray m_eventLog; // 0x28
	
		// Properties
		public RectTransform dragArea { get => default; } // 0x0000000181041090-0x00000001810410A0 
	
		// Constructors
		public UICustomLayout() {} // 0x0000000189AD0058-0x0000000189AD0110
	
		// Methods
		protected override void Awake() {} // 0x0000000189ACF448-0x0000000189ACF590
		public bool IsDirty() => default; // 0x0000000189ACF590-0x0000000189ACF6EC
		public void ResetToDefault(bool saveChanges) {} // 0x0000000189ACF6EC-0x0000000189ACF878
		public void Save(int ratio = 0 /* Metadata: 0x01FBC5CE */) {} // 0x0000000189ACF878-0x0000000189ACFB28
		private void _LogEvent(Dictionary<UICustomLayoutElement, UICustomLayoutElement.LayoutData> layoutDataMap) {} // 0x0000000189ACFB28-0x0000000189AD0058
		public void __iFixBaseProxy_Awake() {} // 0x000000018350B670-0x000000018350B680
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UICustomLayoutElement : UIBehaviour, IUIClearable // TypeDefIndex: 49267
	{
		// Fields
		[SerializeField]
		private int _verNum; // 0x18
		[SerializeField]
		private string _elementKey; // 0x20
		[SerializeField]
		private Transform _overrideScaleTransform; // 0x28
		[SerializeField]
		private CanvasGroup _overrideCanvasGroup; // 0x30
		[SerializeField]
		private RectTransform _overrideHighlightRect; // 0x38
		public DisposedUnityEvent onLayoutDataLoaded; // 0x40
		private LuaPanel m_panel; // 0x48
		private float m_scale; // 0x50
		private float m_alpha; // 0x54
		private Vector2 m_position; // 0x58
		private LayoutType m_layoutType; // 0x60
		private float m_defaultScale; // 0x64
		private float m_defaultAlpha; // 0x68
		private Vector2 m_defaultPosition; // 0x6C
		private RectTransform m_rectTransform; // 0x78
	
		// Properties
		public string elementKey { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public RectTransform highlightRect { get => default; } // 0x0000000189ACDD68-0x0000000189ACDE00 
		public float scale { get => default; set {} } // 0x0000000183D51C90-0x0000000183D51CA0 0x0000000189ACDE18-0x0000000189ACDE24
		public float alpha { get => default; set {} } // 0x0000000183D4F670-0x0000000183D4F680 0x0000000189ACDE00-0x0000000189ACDE0C
		public Vector2 position { get => default; set {} } // 0x0000000183D72FD0-0x0000000183D72FF0 0x0000000189ACDE0C-0x0000000189ACDE18
		public LayoutType layoutType { get => default; set {} } // 0x0000000183D4F050-0x0000000183D4F060 0x0000000183D4F5A0-0x0000000183D4F5B0
		public LuaPanel panel { get => default; } // 0x00000001827FCBB0-0x00000001827FCC60 
	
		// Nested types
		public enum LayoutType // TypeDefIndex: 49265
		{
			None = 0,
			LeftToRight = 1
		}
	
		public class LayoutData // TypeDefIndex: 49266
		{
			// Fields
			public int verNum; // 0x10
			public float scale; // 0x14
			public float alpha; // 0x18
			public Vector2 position; // 0x1C
			public int layoutType; // 0x24
	
			// Constructors
			public LayoutData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public UICustomLayoutElement() {} // 0x0000000182849790-0x0000000182849830
	
		// Methods
		protected override void Awake() {} // 0x00000001827FC130-0x00000001827FC260
		protected override void Start() {} // 0x0000000183A21200-0x0000000183A21270
		protected override void OnDestroy() {} // 0x0000000189ACD5C0-0x0000000189ACD6B4
		public void ResetToDefault() {} // 0x0000000189ACD748-0x0000000189ACD810
		private void _ApplyPosition() {} // 0x0000000189ACDAD4-0x0000000189ACDB40
		private void _ApplyAlpha() {} // 0x0000000189ACD9F0-0x0000000189ACDAD4
		private void _ApplyScale() {} // 0x0000000189ACDB40-0x0000000189ACDC14
		private void _SetDefaultValues() {} // 0x00000001827FC260-0x00000001827FC420
		public string GetElementKeyWithRatio(int ratio = 0 /* Metadata: 0x01FBC5CF */) => default; // 0x0000000189ACD294-0x0000000189ACD370
		private bool _CheckElementKeyIsValid() => default; // 0x0000000189ACDC14-0x0000000189ACDD18
		public bool SaveData(out LayoutData layoutData, bool isResetToDefault = false /* Metadata: 0x01FBC5D0 */, int ratio = 0 /* Metadata: 0x01FBC5D1 */) {
			layoutData = default;
			return default;
		} // 0x0000000189ACD810-0x0000000189ACD9F0
		public void LoadData() {} // 0x0000000189ACD370-0x0000000189ACD5C0
		private void _OnHudLayoutSaved() {} // 0x0000000189ACDD18-0x0000000189ACDD68
		private Vector2 _GetMarginSize() => default; // 0x00000001827FCA90-0x00000001827FCBB0
		public void ClearComponent() {} // 0x0000000189ACD23C-0x0000000189ACD294
		public static void RefreshAll() {} // 0x0000000189ACD6B4-0x0000000189ACD748
		public void __iFixBaseProxy_Awake() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_Start() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018350B670-0x000000018350B680
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UICustomLayoutHandle : UIBehaviour, IPointerClickHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 49268
	{
		// Fields
		public DisposedUnityEvent onClick; // 0x18
		public DisposedUnityEvent<PointerEventData> onBeginDrag; // 0x20
		public DisposedUnityEvent<PointerEventData> onDrag; // 0x28
		public DisposedUnityEvent<PointerEventData> onEndDrag; // 0x30
		public string hintTextId; // 0x38
		private LuaPanel m_panel; // 0x40
		private float m_scale; // 0x48
		private float m_alpha; // 0x4C
		private Vector2 m_position; // 0x50
		private UICustomLayoutElement.LayoutType m_layoutType; // 0x58
		private Vector2 m_defaultPosition; // 0x5C
		private bool m_isChanged; // 0x64
		private bool m_isResetToDefault; // 0x65
		private RectTransform m_rectTransform; // 0x68
		private RectTransform m_parentRectTransform; // 0x70
		private UICustomLayoutElement m_element; // 0x78
		private UICustomLayout m_layout; // 0x80
		private Vector2 m_dragPosMin; // 0x88
		private Vector2 m_dragPosMax; // 0x90
		private Vector3[] m_dragAreaCorners; // 0x98
		private Vector3[] m_highlightCorners; // 0xA0
		private bool m_isPosRangeDirty; // 0xA8
		private Vector2 m_dragOffset; // 0xAC
	
		// Properties
		public float scale { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000189ACF3B4-0x0000000189ACF448
		public float alpha { get => default; set {} } // 0x0000000183D50200-0x0000000183D50210 0x0000000189ACF1D0-0x0000000189ACF244
		public Vector2 position { get => default; set {} } // 0x0000000183D76080-0x0000000183D760A0 0x0000000189ACF2D4-0x0000000189ACF3B4
		public UICustomLayoutElement.LayoutType layoutType { get => default; set {} } // 0x0000000183D4EF00-0x0000000183D4EF10 0x0000000189ACF244-0x0000000189ACF2D4
		public LuaPanel panel { get => default; } // 0x0000000189ACF118-0x0000000189ACF1D0 
		public UICustomLayoutElement Element { get => default; } // 0x0000000189ACF064-0x0000000189ACF118 
	
		// Constructors
		public UICustomLayoutHandle() {} // 0x0000000189ACEED4-0x0000000189ACF064
	
		// Methods
		protected override void Awake() {} // 0x0000000189ACDE24-0x0000000189ACE030
		protected override void OnDestroy() {} // 0x0000000189ACE288-0x0000000189ACE3EC
		private void _OnElementDataLoaded() {} // 0x0000000189ACED28-0x0000000189ACEDD4
		private void _CalculatePositionRange() {} // 0x0000000189ACE98C-0x0000000189ACED28
		private void _ApplyPosition() {} // 0x0000000189ACE8A8-0x0000000189ACE91C
		private void _ApplyAlpha() {} // 0x0000000189ACE7DC-0x0000000189ACE844
		private void _ApplyScale() {} // 0x0000000189ACE91C-0x0000000189ACE98C
		private void _ApplyLayoutType() {} // 0x0000000189ACE844-0x0000000189ACE8A8
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189ACE130-0x0000000189ACE288
		public void OnDrag(PointerEventData eventData) {} // 0x0000000189ACE3EC-0x0000000189ACE538
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000189ACE538-0x0000000189ACE5C4
		public bool Save(out UICustomLayoutElement.LayoutData layoutData, int ratio = 0 /* Metadata: 0x01FBC5D4 */) {
			layoutData = default;
			return default;
		} // 0x0000000189ACE70C-0x0000000189ACE7DC
		public void ResetToDefault() {} // 0x0000000189ACE62C-0x0000000189ACE70C
		public bool IsDirty() => default; // 0x0000000189ACE0E4-0x0000000189ACE130
		private void _SetChanged(bool changed) {} // 0x0000000189ACEE24-0x0000000189ACEED4
		public void OnPointerClick(PointerEventData eventData) {} // 0x0000000189ACE5C4-0x0000000189ACE62C
		private void _OnSystemDisplaySizeChanged() {} // 0x0000000189ACEDD4-0x0000000189ACEE24
		public void ClearComponent() {} // 0x0000000189ACE030-0x0000000189ACE0E4
		public void __iFixBaseProxy_Awake() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018350B670-0x000000018350B680
	}

	public class UIDialogText : TickableUIMono // TypeDefIndex: 49270
	{
		// Fields
		[SerializeField]
		protected UIText _uiText; // 0x68
		[SerializeField]
		[Tooltip("1\u79D2\u949F\u663E\u793A\u591A\u5C11\u4E2A\u5B57")]
		private float _textRevealSpeed; // 0x70
		[SerializeField]
		[Tooltip("\u662F\u5426\u81EA\u52A8\u6FC0\u6D3B\u65F6\u81EA\u52A8\u64AD\u653E")]
		private bool _autoPlay; // 0x74
		[SerializeField]
		private UpdateMode _updateMode; // 0x78
		[SerializeField]
		private bool _useAutoScroll; // 0x7C
		[SerializeField]
		[Tooltip("\u521D\u59CB\u9AD8\u5EA6")]
		private float _originalHeight; // 0x80
		[SerializeField]
		private bool _useAspectRatio; // 0x84
		[SerializeField]
		[Tooltip("\u5355\u4F4D\u662F \u957F\u5EA6/s")]
		private float _autoScrollSpeed; // 0x88
		[SerializeField]
		private float _autoWaitTime; // 0x8C
		[SerializeField]
		private float _maxAspectRatio; // 0x90
		[SerializeField]
		private float _minAspectRatio; // 0x94
		[SerializeField]
		private float _maxAspectRatioScrollSpeed; // 0x98
		[SerializeField]
		private float _minAspectRatioScrollSpeed; // 0x9C
		[SerializeField]
		private float _maxAspectRatioWaitTime; // 0xA0
		[SerializeField]
		private float _minAspectRatioWaitTime; // 0xA4
		private bool m_playing; // 0xA8
		private int m_revealedCharNum; // 0xAC
		private int m_totalCharNum; // 0xB0
		private float m_timeToNextCharacter; // 0xB4
		protected string m_curText; // 0xB8
		private bool m_hasScrolled; // 0xC0
		private float m_startTime; // 0xC4
		private bool m_scrollHasEnd; // 0xC8
		private bool m_needAutoScroll; // 0xC9
		private Vector2 m_targetPos; // 0xCC
		private Vector2 m_originalPos; // 0xD4
		private float m_percent; // 0xDC
		private bool m_locked; // 0xE0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		private bool useAspectRatio { get => default; } // 0x0000000189AD0D48-0x0000000189AD0D5C 
		private bool notUseAspectRatio { get => default; } // 0x0000000189AD0CC4-0x0000000189AD0CD8 
		public bool playing { get => default; } // 0x0000000189AD0CD8-0x0000000189AD0D48 
		public UIText uiText { get => default; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 
		public int totalCharacterNum { get => default; } // 0x0000000183D59C80-0x0000000183D59C90 
		public float textRevealSpeed { get => default; set {} } // 0x0000000183D56C00-0x0000000183D56C10 0x0000000183D5BD20-0x0000000183D5BD30
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 49269
		{
			Auto = 0,
			Manual = 1
		}
	
		// Constructors
		public UIDialogText() {} // 0x0000000183A20AC0-0x0000000183A20B80
	
		// Methods
		protected override void OnAwake() {} // 0x0000000183D2AB30-0x0000000183D2AB70
		protected void Start() {} // 0x000000018398ECD0-0x000000018398ED80
		protected override void OnDisable() {} // 0x0000000189AD0AD0-0x0000000189AD0B28
		protected override void OnEnable() {} // 0x0000000183CF4E80-0x0000000183CF4EC0
		public override void Tick(float deltaTime) {} // 0x0000000182A35AA0-0x0000000182A35B00
		protected virtual void OnVisibleCharactersChanged(int count) {} // 0x0000000189AD0B28-0x0000000189AD0B7C
		protected float GetScrollSpeed() => default; // 0x0000000189AD06B0-0x0000000189AD0794
		protected float GetAutoWaitTime() => default; // 0x0000000189AD051C-0x0000000189AD0600
		private void _UpdateTextAuto() {} // 0x0000000182A35B00-0x0000000182A35C10
		private void _TryAutoScroll() {} // 0x0000000182A35C10-0x0000000182A35C80
		public void RefreshAutoScrollData() {} // 0x000000018398EED0-0x000000018398EF70
		public void SetText(string text, bool resetPlay = true /* Metadata: 0x01FBC5D5 */) {} // 0x000000018398EDF0-0x000000018398EED0
		private void _RefreshPosY() {} // 0x0000000189AD0C18-0x0000000189AD0CC4
		public void SeekToEnd() {} // 0x0000000189AD0B7C-0x0000000189AD0C18
		public void RefreshText() {} // 0x0000000183CF4EC0-0x0000000183CF4F10
		public void Play() {} // 0x000000018398ED80-0x000000018398EDF0
		public virtual void ResetPlay() {} // 0x0000000183B3CDB0-0x0000000183B3CE20
		public void StopPlay() {} // 0x0000000182A35C80-0x0000000182A35D30
		public void ManualUpdateByPercent(float percent) {} // 0x0000000189AD0794-0x0000000189AD08E0
		public void ManualUpdateByTime(float time) {} // 0x0000000189AD08E0-0x0000000189AD0AD0
		public virtual float GetDisplayAllCharactersTime() => default; // 0x0000000189AD0600-0x0000000189AD06B0
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	public class UIDialogTextWithCursor : UIDialogText // TypeDefIndex: 49271
	{
		// Fields
		[SerializeField]
		private float _textGapTime; // 0xE8
		[SerializeField]
		private UIAnimationWrapper _cursorAnimation; // 0xF0
		[SerializeField]
		private RectTransform _cursorLoopHide; // 0xF8
		[SerializeField]
		private RectTransform _cursorGroup; // 0x100
		[SerializeField]
		private UIImage _background; // 0x108
		[NonSerialized]
		public bool isLastTextLine; // 0x110
		private int m_lastCount; // 0x114
	
		// Constructors
		public UIDialogTextWithCursor() {} // 0x0000000189AD0500-0x0000000189AD051C
	
		// Methods
		public override void ResetPlay() {} // 0x0000000189AD0490-0x0000000189AD04E8
		protected override void OnVisibleCharactersChanged(int count) {} // 0x0000000189AD016C-0x0000000189AD0490
		public override float GetDisplayAllCharactersTime() => default; // 0x0000000189AD0110-0x0000000189AD016C
		public void __iFixBaseProxy_ResetPlay() {} // 0x0000000189AD04F8-0x0000000189AD0500
		public void __iFixBaseProxy_OnVisibleCharactersChanged(int P0) {} // 0x0000000189AD04F0-0x0000000189AD04F8
		public float __iFixBaseProxy_GetDisplayAllCharactersTime() => default; // 0x0000000189AD04E8-0x0000000189AD04F0
	}

	public class EasyUIOptionData // TypeDefIndex: 49272
	{
		// Fields
		public int index; // 0x10
		public string optionIcon; // 0x18
		public string optionText; // 0x20
	
		// Constructors
		public EasyUIOptionData() {} // 0x000000018350B670-0x000000018350B680
	}

	public class UIDialogTimelineOptionCell : MonoBehaviour // TypeDefIndex: 49273
	{
		// Fields
		[SerializeField]
		private UIImage _optionIcon; // 0x18
		[SerializeField]
		private UIText _optionText; // 0x20
	
		// Constructors
		public UIDialogTimelineOptionCell() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public class UIDialogTimelineText : MonoBehaviour // TypeDefIndex: 49274
	{
		// Fields
		[SerializeField]
		private UIDialogText _dialogText; // 0x18
		[SerializeField]
		private UIText _actorName; // 0x20
		[SerializeField]
		private GameObject _waitNode; // 0x28
		[SerializeField]
		private UIAnimationWrapper _radioNode; // 0x30
		[SerializeField]
		private UIImage _iconImage; // 0x38
		[SerializeField]
		private UIImage _iconBlueMask; // 0x40
		public UIText centerText; // 0x48
		private string m_currentRadioIcon; // 0x50
		private CanvasGroup m_canvasGroup; // 0x58
	
		// Properties
		private CanvasGroup canvasGroup { get => default; } // 0x0000000189AD10A0-0x0000000189AD1130 
		public UIDialogText dialogText { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public UIText actorName { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public GameObject waitNode { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
	
		// Constructors
		public UIDialogTimelineText() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void UpdateAlpha(float alpha) {} // 0x0000000189AD0ED4-0x0000000189AD0F94
		public void SetRadioIcon(bool useRadio, string radioIcon) {} // 0x0000000189AD0D5C-0x0000000189AD0E90
		private void _ClearRadioIcon() {} // 0x0000000189AD0F94-0x0000000189AD10A0
	}

	public class UIDrag : UIBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 49275
	{
		// Fields
		[SerializeField]
		private RectTransform _dragArea; // 0x18
		public DisposedUnityEvent<PointerEventData> onBeginDrag; // 0x20
		public DisposedUnityEvent<PointerEventData> onEndDrag; // 0x28
		public DisposedUnityEvent<PointerEventData> onDrag; // 0x30
		private RectTransform m_rectTransform; // 0x38
		private RectTransform m_parentRectTransform; // 0x40
		private Vector2 m_dragOffset; // 0x48
		private Vector2 m_dragPosMin; // 0x50
		private Vector2 m_dragPosMax; // 0x58
		private Vector3[] m_dragAreaCorners; // 0x60
		private Canvas m_canvas; // 0x68
	
		// Constructors
		public UIDrag() {} // 0x0000000189AD2F8C-0x0000000189AD309C
	
		// Methods
		protected override void Awake() {} // 0x0000000189AD26C4-0x0000000189AD27BC
		public void OnDrag(PointerEventData eventData) {} // 0x0000000189AD2CFC-0x0000000189AD2F00
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189AD2860-0x0000000189AD2CFC
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000189AD2F00-0x0000000189AD2F8C
		public void ApplyDragArea() {} // 0x0000000189AD2284-0x0000000189AD26C4
		public void ClearComponent() {} // 0x0000000189AD27BC-0x0000000189AD2860
		public void __iFixBaseProxy_Awake() {} // 0x000000018350B670-0x000000018350B680
	}

	public class UIDragHandler : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 49276
	{
		// Fields
		[SerializeField]
		private int _dragThreshold; // 0x18
		private Vector2 m_startPressPos; // 0x1C
		private bool m_isDragThresholdMet; // 0x24
		private bool m_isDragging; // 0x25
		public UIButton button; // 0x28
		public bool ignoreDragOnLongPress; // 0x30
		public UIEvent<PointerEventData> onBeginDrag; // 0x38
		public UIEvent<PointerEventData> onDrag; // 0x40
		public UIEvent<PointerEventData> onEndDrag; // 0x48
	
		// Properties
		public int dragThreshold { get => default; } // 0x0000000189AD14D8-0x0000000189AD1520 
	
		// Constructors
		public UIDragHandler() {} // 0x00000001828472A0-0x00000001828473A0
	
		// Methods
		public void ClearComponent() {} // 0x0000000189AD1130-0x0000000189AD11D4
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000189AD1464-0x0000000189AD14D8
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189AD11D4-0x0000000189AD1268
		public void OnDrag(PointerEventData eventData) {} // 0x0000000189AD1268-0x0000000189AD13D0
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000189AD13D0-0x0000000189AD1464
	}

	public class UIDragItem : UIBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 49278
	{
		// Fields
		public static RectTransform s_commonDragObjectParent; // 0x00
		[NonSerialized]
		public UnityEvent<PointerEventData> onBeginDragEvent; // 0x20
		[NonSerialized]
		public UnityEvent<PointerEventData> onDragEvent; // 0x28
		[NonSerialized]
		public UnityEvent<PointerEventData> onDragEventWhenCantStartDrag; // 0x30
		[NonSerialized]
		public UnityEvent<PointerEventData> onEndDragEvent; // 0x38
		[NonSerialized]
		public UnityEvent<GameObject, GameObject> onUpdateDragObject; // 0x40
		[NonSerialized]
		public bool canStartDrag; // 0x48
		[SerializeField]
		private bool _endDragOnDisable; // 0x49
		[NonSerialized]
		public bool disableDrag; // 0x4A
		[SerializeField]
		private bool _isInScrollList; // 0x4B
		[SerializeField]
		private bool _hideDragObjectInScrollList; // 0x4C
		[SerializeField]
		private GameObject _dragPrefab; // 0x50
		[SerializeField]
		[Tooltip("\u5982\u679C\u4E0D\u8BBE\u7F6E\u5C31\u4F1A\u4F7F\u7528 s_commonDragObjectParent\uFF0C\u5373\u901A\u7528\u7684\u62D6\u62FD\u5C42")]
		private RectTransform _dragObjectParent; // 0x58
		[FormerlySerializedAs("_dragPivot")]
		public Vector2 dragPivot; // 0x60
		[SerializeField]
		[Tooltip("\u5728\u62D6\u62FD\u7684\u65F6\u5019\u4F1A\u534A\u900F")]
		private Image _draggingHintImage; // 0x68
		[SerializeField]
		[Tooltip("\u5728\u62D6\u62FD\u7684\u65F6\u5019\u4F1A\u534A\u900F")]
		private CanvasGroup _draggingHintCanvasGroup; // 0x70
		[SerializeField]
		[Tooltip("\u5728\u62D6\u62FD\u7684\u65F6\u5019\u4F1A\u663E\u793A")]
		private GameObject _draggingHintObject; // 0x78
		private LuaPanel m_panel; // 0x80
		private RectTransform m_rect; // 0x88
		private UIScrollRect m_scrollRect; // 0x90
		private bool m_isInScroll; // 0x98
		private GameObject m_curDragObj; // 0xA0
		private bool m_inDragging; // 0xA8
		private UnityEngine.Color m_draggingHintImageOriColor; // 0xAC
		private Coroutine m_dragOnDisableCoroutine; // 0xC0
	
		// Properties
		public LuaTable luaTable { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public bool inDragging { get => default; } // 0x00000001811B9C10-0x00000001811B9C20 
		public LuaPanel panel { get => default; } // 0x0000000189AD21C0-0x0000000189AD2284 
		private RectTransform m_dragParentRect { get => default; } // 0x0000000189AD2110-0x0000000189AD21C0 
		public GameObject curDragObj { get => default; } // 0x0000000183D4EA80-0x0000000183D4EA90 
	
		// Constructors
		public UIDragItem() {} // 0x0000000182848DD0-0x0000000182848F50
	
		// Methods
		protected override void Awake() {} // 0x000000018388F250-0x000000018388F2C0
		protected override void Start() {} // 0x00000001837B10F0-0x00000001837B11F0
		protected override void OnDisable() {} // 0x00000001836EE670-0x00000001836EE6E0
		[IteratorStateMachine(typeof(__ContinueDragOnDisable_d__40))]
		private IEnumerator _ContinueDragOnDisable() => default; // 0x0000000189AD1ED8-0x0000000189AD1F68
		protected override void OnDestroy() {} // 0x0000000189AD1B20-0x0000000189AD1B80
		protected override void OnEnable() {} // 0x000000018388DA70-0x000000018388DAB0
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189AD15C0-0x0000000189AD1B20
		public void OnDrag(PointerEventData eventData) {} // 0x0000000189AD1B80-0x0000000189AD1ED8
		public void OnEndDrag(PointerEventData eventData) {} // 0x00000001836EE6E0-0x00000001836EE770
		private void _StopDragView() {} // 0x0000000189AD1F68-0x0000000189AD2110
		public void ClearComponent() {} // 0x0000000189AD1520-0x0000000189AD15C0
		public void ClearEvents() {} // 0x0000000182C712E0-0x0000000182C71370
		public void __iFixBaseProxy_Awake() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_Start() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018350B670-0x000000018350B680
	}

	[AddComponentMenu("UI/UI Dropdown", 102)]
	public class UIDropdown : Selectable, IPointerClickHandler, IUIClearable, IBindingGroupTarget, IBindingView // TypeDefIndex: 49281
	{
		// Fields
		[HideInInspector]
		public UnityEvent<int> onSelectCell; // 0x180
		[HideInInspector]
		public UnityEvent<int, UIDropdownOption, bool> onUpdateCell; // 0x188
		[HideInInspector]
		public UnityEvent<int, UIDropdown> onUpdateCaption; // 0x190
		[FormerlySerializedAs("onToggleList")]
		[HideInInspector]
		public UnityEvent<bool> onToggleOptList; // 0x198
		public Func<int, int, bool> onValidateSelectCell; // 0x1A0
		public UIText captionText; // 0x1A8
		public UIImage captionIcon; // 0x1B0
		[SerializeField]
		private UIDropdownOption _optionTemplate; // 0x1C8
		[SerializeField]
		private Transform _arrowImageTrans; // 0x1D0
		[SerializeField]
		private RectTransform _listContainer; // 0x1D8
		[SerializeField]
		private float _listContainerMaxHeight; // 0x1E0
		[SerializeField]
		private float _animationTime; // 0x1E4
		[SerializeField]
		private RectTransform _selfArea; // 0x1E8
		[SerializeField]
		[Tooltip("\u8FD9\u91CC\u4E3A\u7A7A\u7684\u8BDD\uFF0C\u70B9\u5F00Dropdown\u65F6\u70B9\u51FB\u4EFB\u610F\u975EDropdown\u533A\u57DF\u4F1A\u6536\u8D77\uFF0C\u6709\u7684\u8BDD\u53EA\u4F1A\u54CD\u5E94mask\u533A\u57DF\u5185\u7684")]
		private RectTransform _maskRect; // 0x1F0
		[SerializeField]
		private bool _autoCloseOnSelect; // 0x1F8
		[AudioString]
		[SerializeField]
		private string _audioToggleOn; // 0x200
		[AudioString]
		[SerializeField]
		private string _audioToggleOff; // 0x208
		[AudioString]
		[SerializeField]
		private string _audioInvalid; // 0x210
		[AudioString]
		[SerializeField]
		private string _audioNavigation; // 0x218
		private List<UIDropdownOption> m_options; // 0x220
		private LuaPanel m_panel; // 0x228
		private LayoutGroup m_content; // 0x230
		private Camera m_fallbackUICamera; // 0x238
		private UIScrollRect m_listScrollRect; // 0x240
		private CanvasGroup m_listContainerCanvasGroup; // 0x248
		[FormerlySerializedAs("_openDropDownActionId")]
		public string openDropDownActionId; // 0x250
		public string openDropDownBindingTextId; // 0x258
		private int m_bindingGroupId; // 0x260
		private int m_naviBindingGroupId; // 0x264
		private LuaPanel m_luaPanel; // 0x268
		private UISelectableNaviGroup m_listNaviGroup; // 0x270
	
		// Properties
		public int selectedIndex { get; private set; } // 0x0000000183D58520-0x0000000183D58530 0x0000000183D58620-0x0000000183D58630
		public int optionCount { get; private set; } // 0x0000000183D58580-0x0000000183D58590 0x0000000183D58630-0x0000000183D58640
		public bool isListActive { get; private set; } // 0x0000000183D57BF0-0x0000000183D57C00 0x0000000183D760A0-0x0000000183D760B0
		public LuaPanel panel { get => default; } // 0x000000018284ECA0-0x000000018284ED60 
		public int groupId { get => default; } // 0x0000000183D5ADD0-0x0000000183D5ADE0 
		public IBindingGroupTarget parentTarget { get; private set; } // 0x0000000183D57270-0x0000000183D57280 0x00000001858B3EC0-0x00000001858B3ED4
		public bool groupEnabled { get => default; } // 0x0000000189AD36D0-0x0000000189AD3B88 
		public string bindingViewActionId { get => default; } // 0x0000000183D57350-0x0000000183D57360 
		public string bindingViewLabelText { get => default; } // 0x0000000189AD3554-0x0000000189AD35EC 
		public DisposedUnityEvent bindingViewUpdateEvent { get; } // 0x0000000183D573B0-0x0000000183D573C0 
		public RectTransform redDotTrans { get => default; } // 0x0000000181002730-0x0000000181002740 
		public bool bindingEnabled { get => default; } // 0x0000000189AD354C-0x0000000189AD3554 
		public BindingViewState bindingViewState { get => default; } // 0x0000000189AD35EC-0x0000000189AD36D0 
		bool IBindingView.interactable { get => default; } // 0x0000000189AD3144-0x0000000189AD3194 
	
		// Constructors
		public UIDropdown() {} // 0x000000018284A270-0x000000018284A3C0
	
		// Methods
		protected override void Awake() {} // 0x0000000182A71E60-0x0000000182A71FE0
		protected override void _NotifyIsHover(bool isHover) {} // 0x0000000183989990-0x0000000183989A10
		public void OnPointerClick(PointerEventData eventData) {} // 0x0000000182D99F90-0x0000000182D9A040
		public void Init(UnityAction<int, UIDropdownOption, bool> onUpdateCell, UnityAction<int> onSelectCell, UnityAction<int, UIDropdown> onUpdateCaption = null) {} // 0x0000000183C9B180-0x0000000183C9B250
		public void ToggleOptions(bool activeList) {} // 0x0000000182D9A040-0x0000000182D9A090
		private void _ToggleOptions(bool activeList, bool isInit) {} // 0x0000000182D9A090-0x0000000182D9A5A0
		private void Update() {} // 0x000000018284F410-0x000000018284F640
		public void SetSelected(int index, bool forceUpdate = false /* Metadata: 0x01FBC5D8 */, bool needNotifySelect = true /* Metadata: 0x01FBC5D9 */, bool validateSelect = false /* Metadata: 0x01FBC5DA */) {} // 0x0000000182D9A5A0-0x0000000182D9A8E0
		public void ScrollToSelected() {} // 0x0000000189AD3250-0x0000000189AD338C
		public void Refresh(int count, int newSelectedIndex = -1 /* Metadata: 0x01FBC5DB */, bool needNotifySelect = true /* Metadata: 0x01FBC5DC */) {} // 0x000000018270F0C0-0x000000018270F510
		public void ClearComponent() {} // 0x0000000183A46E40-0x0000000183A46EF0
		private Camera _GetUICamera() => default; // 0x000000018284EB10-0x000000018284ECA0
		public string GetBindingViewActionId(BindingViewActionType actionType) => default; // 0x0000000189AD3194-0x0000000189AD3250
		void IBindingView.OnInputKeyDown(bool isActionTrigger) {} // 0x0000000189AD309C-0x0000000189AD30F0
		void IBindingView.OnInputKeyUp(bool isActionTrigger) {} // 0x0000000189AD30F0-0x0000000189AD3144
		private void _InitBinding() {} // 0x0000000182A73B40-0x0000000182A73CE0
		private void _ControllerToggle() {} // 0x0000000189AD33F8-0x0000000189AD3470
		private void _ControllerCancel() {} // 0x0000000189AD338C-0x0000000189AD33F8
		private Selectable _GetDefaultNaviTarget() => default; // 0x0000000189AD3470-0x0000000189AD354C
		protected override void OnEnable() {} // 0x0000000183B38150-0x0000000183B381E0
		protected override void OnDisable() {} // 0x0000000183B381E0-0x0000000183B38270
		protected override void OnDestroy() {} // 0x0000000183A46DA0-0x0000000183A46E40
		public void __iFixBaseProxy_Awake() {} // 0x0000000189AAE8DC-0x0000000189AAE8E4
		public void __iFixBaseProxy__NotifyIsHover(bool P0) {} // 0x0000000189ACB974-0x0000000189ACB97C
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000189AAE8EC-0x0000000189AAE8F4
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018361D5F0-0x000000018361D600
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000189AAE8E4-0x0000000189AAE8EC
	}

	public class UIDropdownOption : MonoBehaviour // TypeDefIndex: 49282
	{
		// Fields
		public UIButton button; // 0x18
		public UIText label; // 0x20
		public UIText secondLabel; // 0x28
		public UIImage icon; // 0x30
		public GameObject selectedNode; // 0x38
		public GameObject notSelectedNode; // 0x40
		public UIStateController stateController; // 0x48
		public GameObject stripeNode; // 0x50
		public bool stripeIsTop; // 0x58
	
		// Constructors
		public UIDropdownOption() {} // 0x0000000182813CB0-0x0000000182813CC0
	
		// Methods
		public void SetText(string text) {} // 0x00000001828E1380-0x00000001828E1460
		public void SetState(string stateName) {} // 0x0000000189AD4F6C-0x0000000189AD5020
	}

	public enum CommonDropHintType // TypeDefIndex: 49283
	{
		None = 0,
		Square = 1,
		Circle = 2
	}

	public class UIDropItem : UIBehaviour, IDropHandler, IUIClearable // TypeDefIndex: 49284
	{
		// Fields
		[NonSerialized]
		public UnityEvent<PointerEventData> onDropEvent; // 0x20
		[NonSerialized]
		public UnityEvent<bool> onToggleHighlight; // 0x28
		public Action onDestroy; // 0x30
		public CommonDropHintType commonDropHintType; // 0x38
		[SerializeField]
		private GameObject _highlightHint; // 0x40
		[SerializeField]
		private bool _scaleWhenHighlight; // 0x48
		[SerializeField]
		private float _scaleWhenActive; // 0x4C
		[SerializeField]
		private bool _useUIState; // 0x50
		[SerializeField]
		private UIStyleByState.StateConfig _stateConfigNormal; // 0x58
		[SerializeField]
		private UIStyleByState.StateConfig _stateConfigHilight; // 0x60
		private Selectable m_selectable; // 0x68
		private RectTransform m_rectTransform; // 0x70
		private float m_oriScale; // 0x78
		private bool m_isInHighlight; // 0x7C
	
		// Properties
		public LuaTable luaTable { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public UIDropItem() {} // 0x0000000182848CA0-0x0000000182848DD0
	
		// Methods
		public void ClearEvents() {} // 0x0000000182C71290-0x0000000182C712E0
		protected override void Awake() {} // 0x00000001837E73A0-0x00000001837E7460
		protected override void OnEnable() {} // 0x000000018364BBF0-0x000000018364BC50
		protected override void OnDisable() {} // 0x000000018364BBB0-0x000000018364BBF0
		protected override void OnDestroy() {} // 0x0000000189AD4DB0-0x0000000189AD4E50
		public void ToggleHighlight(bool active, bool forceToggle = false /* Metadata: 0x01FBC5E0 */) {} // 0x000000018364BC50-0x000000018364BE40
		public void OnDrop(PointerEventData eventData) {} // 0x0000000189AD4E50-0x0000000189AD4F6C
		public void ClearComponent() {} // 0x0000000189AD4D18-0x0000000189AD4DB0
		public void __iFixBaseProxy_Awake() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018350B670-0x000000018350B680
	}

	public class UIElementFollower : TickableUIMono // TypeDefIndex: 49285
	{
		// Fields
		[SerializeField]
		private bool _followMouse; // 0x68
		[FormerlySerializedAs("_followFixedPos")]
		[Tooltip("\u4E0D\u52FE\u9009\u5219\u8DDF\u968F\u5355\u4F4D")]
		public bool followFixedPos; // 0x69
		[SerializeField]
		private Transform _targetTransform; // 0x70
		[SerializeField]
		private Vector3 _followPosition; // 0x78
		[SerializeField]
		private bool _changeScale; // 0x84
		[SerializeField]
		[Tooltip("\u6A2A\u8F74\u662F\u76EE\u6807\u548C\u76F8\u673A\u7684\u8DDD\u79BB\uFF0C\u7EB5\u8F74\u662FScale")]
		private AnimationCurve _scaleCurve; // 0x88
		public Vector3 displayOffset; // 0x90
		public Vector3 displayUIOffset; // 0x9C
		private static readonly ProfilerMarker UPDATE_POSITION_MARKER; // 0x00
		[HideInInspector]
		public DisposedUnityEvent onExitScreen; // 0xA8
		[HideInInspector]
		public DisposedUnityEvent onEnterScreen; // 0xB0
		private LuaPanel m_panel; // 0xC0
		private RectTransform m_rectTransform; // 0xC8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public Vector3 followPosition { get => default; set {} } // 0x0000000183D5E3C0-0x0000000183D5E3E0 0x000000018398F430-0x000000018398F450
		public Transform targetTransform { get => default; set {} } // 0x0000000183D4EB30-0x0000000183D4EB40 0x0000000189AD5020-0x0000000189AD5044
		public bool inScreen { get; private set; } // 0x0000000183D51F80-0x0000000183D51F90 0x0000000183D51FD0-0x0000000183D51FE0
		public LuaPanel panel { get => default; } // 0x00000001828AEF10-0x00000001828AF0D0 
	
		// Constructors
		public UIElementFollower() {} // 0x0000000182847EA0-0x0000000182847F80
		static UIElementFollower() {} // 0x0000000183D06B30-0x0000000183D06B90
	
		// Methods
		protected override void OnAwake() {} // 0x00000001837B3D10-0x00000001837B3D90
		protected override void OnEnable() {} // 0x0000000183700750-0x00000001837007A0
		public override void LateTick(float deltaTime) {} // 0x00000001828AE9D0-0x00000001828AEA10
		[IDTag(1)]
		public void UpdatePosition() {} // 0x00000001828AEA10-0x00000001828AEC00
		[IDTag(0)]
		public void UpdatePosition(Vector3 worldPos) {} // 0x00000001828AEC00-0x00000001828AEF10
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class UIExtendScrollRect : MonoBehaviour, UnityEngine.EventSystems.IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 49286
	{
		// Fields
		public UIScrollRect baseScrollRect; // 0x18
		[SerializeField]
		private bool _enableDrag; // 0x20
		[SerializeField]
		private UIScrollList _extendScrollList; // 0x28
	
		// Constructors
		public UIExtendScrollRect() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void OnScroll(PointerEventData eventData) {} // 0x0000000189AD5308-0x0000000189AD53B4
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189AD5044-0x0000000189AD5130
		public void OnDrag(PointerEventData eventData) {} // 0x0000000189AD5130-0x0000000189AD521C
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000189AD521C-0x0000000189AD5308
	}

	public interface IUIFoldoutComp // TypeDefIndex: 49287
	{
		// Properties
		bool defaultFoldOut { get; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Methods
		void Refresh(int index);
		void OnFoldOut(bool fastMode = false /* Metadata: 0x01FBC5E1 */);
		void OnFoldIn(bool fastMode = false /* Metadata: 0x01FBC5E2 */);
	}

	public class UIFoldoutComponent : MonoBehaviour, IUIFoldoutComp // TypeDefIndex: 49290
	{
		// Fields
		[SerializeField]
		protected GameObject _foldContent; // 0x18
		[SerializeField]
		protected UINonUnifiedScrollList _nonUnifiedScrollList; // 0x20
		public float foldInSize; // 0x28
		public float duration; // 0x2C
		public Ease easeType; // 0x30
		protected bool m_isFoldOut; // 0x34
		private Tweener m_tween; // 0x38
		protected int m_index; // 0x40
	
		// Properties
		public virtual bool defaultFoldOut { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Constructors
		public UIFoldoutComponent() {} // 0x0000000189AD5A04-0x0000000189AD5A24
	
		// Methods
		public void Refresh(int index) {} // 0x0000000189AD5988-0x0000000189AD5A04
		public virtual void OnFoldOut(bool fastMode = false /* Metadata: 0x01FBC5E3 */) {} // 0x0000000189AD56D0-0x0000000189AD5988
		public virtual void OnFoldIn(bool fastMode = false /* Metadata: 0x01FBC5E4 */) {} // 0x0000000189AD5420-0x0000000189AD56D0
		private void OnDestroy() {} // 0x0000000189AD53B4-0x0000000189AD5420
	}

	[ExecuteAlways]
	public class UIGraphicAnimation : TickableUIMono // TypeDefIndex: 49291
	{
		// Fields
		private static int s_vfxMainTextSTId; // 0x00
		private static int s_tintColorAlpha; // 0x04
		[SerializeField]
		private MaskableGraphic _graphic; // 0x68
		[SerializeField]
		private Material _material; // 0x70
		[SerializeField]
		private float _alpha; // 0x78
		[SerializeField]
		private Vector2 _scale; // 0x7C
		private Material m_materialInstance; // 0x88
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public Material MaterialInstance { get => default; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
		// Constructors
		public UIGraphicAnimation() {} // 0x0000000182845FF0-0x0000000182846010
		static UIGraphicAnimation() {} // 0x0000000183CF2060-0x0000000183CF20E0
	
		// Methods
		protected override void OnAwake() {} // 0x0000000182E80910-0x0000000182E80950
		protected override void OnRelease() {} // 0x0000000189AD5A24-0x0000000189AD5B44
		public override void LateTick(float deltaTime) {} // 0x0000000182802DD0-0x0000000182803320
		private void _Init() {} // 0x0000000182E80950-0x0000000182E80A90
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	[ExecuteInEditMode]
	public class UIGridLayoutGroup : GridLayoutGroup // TypeDefIndex: 49292
	{
		// Constructors
		public UIGridLayoutGroup() {} // 0x0000000189AD5B44-0x0000000189AD5B4C
	}

	public class UIGridLayoutNaviWrapper : UIBehaviour, UIScrollList.IScrollListNaviWrapper // TypeDefIndex: 49294
	{
		// Fields
		[SerializeField]
		private GridLayoutGroup _gridLayoutGroup; // 0x18
		[SerializeField]
		private LayoutGroup _layoutGroup; // 0x20
		[SerializeField]
		private WrapMode _wrapMode; // 0x28
		[SerializeField]
		private UIScrollRect _scrollRect; // 0x30
		[SerializeField]
		private UISelectableNaviGroup _naviGroup; // 0x38
		[SerializeField]
		private bool _enableCircleWrapNavigation; // 0x40
		private bool m_isInited; // 0x41
		private bool m_isVertical; // 0x42
		private LayoutGroup m_layoutGroup; // 0x48
		private List<Selectable> m_wrapNaviSelectables; // 0x50
	
		// Nested types
		public enum WrapMode // TypeDefIndex: 49293
		{
			NaviGroup = 0,
			ScrollRect = 1,
			ScrollList = 2,
			LayoutNaviWrapper = 3
		}
	
		// Constructors
		public UIGridLayoutNaviWrapper() {} // 0x0000000183CFEDB0-0x0000000183CFEE30
	
		// Methods
		private void _InitIfNot() {} // 0x0000000182D99B50-0x0000000182D99C20
		protected override void Start() {} // 0x0000000182D99C20-0x0000000182D99C60
		public bool TryWrapNavigate(NaviDirection dir) => default; // 0x0000000189AD5B4C-0x0000000189AD5BB0
		private void _InitWrapNavigation() {} // 0x0000000182D99D40-0x0000000182D99E10
		private void _NaviGridLayout(NaviDirection dir) {} // 0x0000000189AD635C-0x0000000189AD63C4
		private bool _NaviGridLayoutImpl(NaviDirection dir, bool enableCircleWrapNavigation = false /* Metadata: 0x01FBC5E5 */) => default; // 0x0000000189AD5FA0-0x0000000189AD622C
		private bool _NaviGridLayoutInit(bool isBefore, bool enableCircleWrapNavigation = false /* Metadata: 0x01FBC5E6 */) => default; // 0x0000000189AD622C-0x0000000189AD635C
		private bool _NaviChildren(int curIndex, int childCount, bool isBefore, bool enableCircleWrapNavigation) => default; // 0x0000000189AD5D18-0x0000000189AD5FA0
		private Selectable _FindValidSelectable(bool isBefore) => default; // 0x0000000189AD5BB0-0x0000000189AD5D18
		private void _SetCircleWrapScroll(bool isBefore) {} // 0x0000000189AD63C4-0x0000000189AD64C4
		public void __iFixBaseProxy_Start() {} // 0x000000018350B670-0x000000018350B680
	}

	public class UIGyroscopeEffect : TickableUIMono // TypeDefIndex: 49296
	{
		// Fields
		public bool enableDetect; // 0x68
		public float mobileGravityScaler; // 0x6C
		public float controllerGravityScaler; // 0x70
		public float controllerAccSmoothFactor; // 0x74
		public Param x; // 0x78
		public Param y; // 0x80
		public Ease ease; // 0x88
		public float time; // 0x8C
		private Vector3 m_lastValue; // 0x90
		private CinemachineVirtualCamera m_vcam; // 0xA0
		private CinemachineGyroscopeEffect m_vcamGyroscopeEffect; // 0xA8
		private bool m_isVcamMode; // 0xB0
		private float m_baseGravityY; // 0xB4
		private float m_baseGravityYAccumulatedTime; // 0xB8
		private float m_lastGravityY; // 0xBC
		private Vector3 m_smoothedControllerAccValue; // 0xC0
		public TweenerCore<Quaternion, Quaternion, NoOptions> handler; // 0xD0
		public TweenerCore<Vector3, Vector3, VectorOptions> tween; // 0xD8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Nested types
		[Serializable]
		public class Param // TypeDefIndex: 49295
		{
			// Fields
			public float maxAngle; // 0x10
			[Space(10f)]
			public AnimationCurve valueCurve; // 0x18
	
			// Constructors
			public Param() {} // 0x0000000183D47CC0-0x0000000183D47CD0
		}
	
		// Constructors
		public UIGyroscopeEffect() {} // 0x0000000183988FA0-0x0000000183989000
	
		// Methods
		protected override void OnAwake() {} // 0x0000000183C8AEC0-0x0000000183C8AF40
		public override void Tick(float deltaTime) {} // 0x000000018284EE00-0x000000018284F320
		protected override void OnRelease() {} // 0x0000000189AD64C4-0x0000000189AD656C
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	public class UIHighlightMask : TickableUIMono // TypeDefIndex: 49297
	{
		// Fields
		[SerializeField]
		private RectTransform _up; // 0x68
		[SerializeField]
		private RectTransform _down; // 0x70
		[SerializeField]
		private RectTransform _left; // 0x78
		[SerializeField]
		private RectTransform _right; // 0x80
		private RectTransform m_rect; // 0x88
		private LuaPanel m_panel; // 0x90
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		public LuaPanel panel { get => default; } // 0x0000000189AD6A60-0x0000000189AD6B24 
	
		// Constructors
		public UIHighlightMask() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		protected override void OnAwake() {} // 0x0000000189AD65C8-0x0000000189AD6658
		protected override void OnEnable() {} // 0x0000000189AD6658-0x0000000189AD66B4
		public override void Tick(float deltaTime) {} // 0x0000000189AD66B4-0x0000000189AD6714
		public void TrySyncRect() {} // 0x0000000189AD6714-0x0000000189AD6A60
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	[AddComponentMenu("UI/UI Image", 11)]
	public class UIImage : Image // TypeDefIndex: 49298
	{
		// Fields
		[SerializeField]
		private int _atlasHandleId; // 0x190
		[SerializeField]
		private List<UIImage> _referencedImages; // 0x198
		private UIAtlasManager.UIAtlasHandle m_atlasHandle; // 0x1A0
		private Action m_onEnableRuntimeAtlas; // 0x1C8
		private LuaPanel m_panel; // 0x1D0
		private bool m_hasBeenEnabled; // 0x1D8
		private string m_cachedSpritePath; // 0x1E0
		protected FAssetProxyHandle m_spriteResHandle; // 0x1E8
		protected FAssetProxyHandle m_matResHandle; // 0x1FC
		public const string SPRITE_PATH_FORMAT = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}/{1}.png"; // Metadata: 0x01FBC5EE
		public const string SPRITE_ROOT_PATH_FORMAT = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}.png"; // Metadata: 0x01FBC62A
		public bool enableAutoImgUsePathReference; // 0x210
		public bool imgUsePathReference; // 0x211
		public string imgRefPath; // 0x218
		private bool m_imgIsPathReference; // 0x220
	
		// Properties
		public bool packIntoRuntimeAtlas { get => default; set {} } // 0x0000000183D760D0-0x0000000183D760E0 0x0000000183D760F0-0x0000000183D76100
		public int atlasHandleId { get => default; set {} } // 0x0000000183D760B0-0x0000000183D760C0 0x0000000183D760E0-0x0000000183D760F0
		public LuaPanel panel { get => default; } // 0x00000001825CB310-0x00000001825CB4D0 
		public ref UIAtlasManager.UIAtlasHandle atlasHandle { get => default; } // 0x0000000183D760C0-0x0000000183D760D0 
		public int panelLevel { get => default; } // 0x0000000183D59F30-0x0000000183D59F40 
		public override UnityEngine.Color color { get => default; set {} } // 0x0000000183D54E00-0x0000000183D54E10 0x00000001825C1BE0-0x00000001825C1E20
		public override Texture mainTexture { get => default; } // 0x00000001825C4980-0x00000001825C4A10 
	
		// Constructors
		public UIImage() {} // 0x00000001824342B0-0x00000001824347C0
	
		// Methods
		public void RegisterOnEnableRuntimeAtlas(Action callBack) {} // 0x0000000182529CE0-0x0000000182529DA0
		public void UnregisterOnEnableRuntimeAtlas(Action callBack) {} // 0x000000018252A2D0-0x000000018252A390
		public void OnEnableRuntimeAtlas() {} // 0x0000000189AD7DB0-0x0000000189AD7E0C
		protected override void _OnSpriteChanged(Sprite lastOne) {} // 0x00000001825CA510-0x00000001825CA680
		protected override void OnPopulateMesh(VertexHelper toFill) {} // 0x00000001825C42F0-0x00000001825C4680
		protected override void Awake() {} // 0x00000001825CA830-0x00000001825CA950
		protected override void OnEnable() {} // 0x00000001825CAF40-0x00000001825CB310
		protected override void OnDisable() {} // 0x000000018239F230-0x000000018239F2E0
		protected override void OnDestroy() {} // 0x00000001825CB590-0x00000001825CB5E0
		public override void SetNativeSize() {} // 0x00000001825CB690-0x00000001825CB7B0
		public void SetNativeSizeIgnoreRefScale() {} // 0x0000000189AD7E0C-0x0000000189AD7E5C
		[IDTag(0)]
		public void LoadSprite(string folder, string spriteName) {} // 0x00000001829FA2B0-0x00000001829FA490
		[IDTag(1)]
		public void LoadSprite(string path) {} // 0x0000000182BE0080-0x0000000182BE0100
		public void LoadSpriteWithOutFormat(string path, bool ignoreEnable = false /* Metadata: 0x01FBC5EB */) {} // 0x0000000182C73750-0x0000000182C737A0
		private void _LoadSprite(string path, bool ignoreEnable = false /* Metadata: 0x01FBC5EC */) {} // 0x00000001825C1ED0-0x00000001825C36F0
		public void LoadMaterial(string path, bool newInstance = false /* Metadata: 0x01FBC5ED */) {} // 0x0000000189AD7B74-0x0000000189AD7DB0
		public override void ReleaseSprite() {} // 0x0000000183C84710-0x0000000183C84750
		public void DisposeSpriteHandle() {} // 0x00000001825CB5E0-0x00000001825CB630
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void _V2AtlasInitialize() {} // 0x00000001830F0910-0x00000001830F0AE0
		public void __iFixBaseProxy_set_color(UnityEngine.Color P0) {} // 0x0000000189ACC870-0x0000000189ACC890
		public void __iFixBaseProxy__OnSpriteChanged(Sprite P0) {} // 0x0000000189AD7E94-0x0000000189AD7E9C
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0) {} // 0x0000000189AD7E7C-0x0000000189AD7E84
		public void __iFixBaseProxy_Awake() {} // 0x0000000189AD7E5C-0x0000000189AD7E64
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000189AD7E74-0x0000000189AD7E7C
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000189AD7E6C-0x0000000189AD7E74
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000189AD7E64-0x0000000189AD7E6C
		public void __iFixBaseProxy_SetNativeSize() {} // 0x0000000189AD7E8C-0x0000000189AD7E94
		public void __iFixBaseProxy_ReleaseSprite() {} // 0x0000000189AD7E84-0x0000000189AD7E8C
		public Texture __iFixBaseProxy_get_mainTexture() => default; // 0x0000000189AD7E9C-0x0000000189AD7EA4
	}

	[RequireComponent(typeof(UIImage))]
	public class UIImageBlur : TickableUIMono // TypeDefIndex: 49299
	{
		// Fields
		public float scale; // 0x68
		private RectTransform m_rect; // 0x70
		private float m_lastScale; // 0x78
		private UIImage m_image; // 0x80
		private Texture2D m_srcTex; // 0x88
		private RenderTexture m_tarTex; // 0x90
		private int m_uiImageBlurTexId; // 0x98
		private Rect m_atlasRect; // 0x9C
		private Action m_dynamicCallback; // 0xB0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public UIImageBlur() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		protected override void OnAwake() {} // 0x0000000182529040-0x00000001825291F0
		public void OnChangeSprite() {} // 0x0000000182528830-0x0000000182528AF0
		public override void Tick(float deltaTime) {} // 0x0000000189AD6BA8-0x0000000189AD6D04
		protected override void OnDisable() {} // 0x00000001832FA1A0-0x00000001832FA2B0
		protected override void OnRelease() {} // 0x0000000189AD6B24-0x0000000189AD6BA8
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	[RequireComponent(typeof(UIImage))]
	public class UIImageFillAmountOffset : MonoBehaviour // TypeDefIndex: 49300
	{
		// Fields
		private UIImage m_followImage; // 0x18
		public float fillOffset; // 0x20
		private float m_fillAmount; // 0x24
	
		// Properties
		public float fillAmount { get => default; set {} } // 0x0000000183D524F0-0x0000000183D52500 0x0000000189AD6E90-0x0000000189AD6FC8
	
		// Constructors
		public UIImageFillAmountOffset() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public TweenerCore<float, float, FloatOptions> DOFillAmount(float endValue, float duration) => default; // 0x0000000189AD6D04-0x0000000189AD6E88
	}

	public class UIImageFillFollower : TickableUIMono // TypeDefIndex: 49301
	{
		// Fields
		private const float BACK_FOLLOW_THRESHOLD = 0.02f; // Metadata: 0x01FBC662
		[SerializeField]
		private UIImage _frontFill; // 0x68
		[SerializeField]
		private float _followSpeed; // 0x70
		private UIImage m_image; // 0x78
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public UIImageFillFollower() {} // 0x0000000189AD7250-0x0000000189AD7260
	
		// Methods
		protected override void OnAwake() {} // 0x0000000189AD6FC8-0x0000000189AD706C
		protected override void OnEnable() {} // 0x0000000189AD706C-0x0000000189AD70E0
		public override void Tick(float deltaTime) {} // 0x0000000189AD714C-0x0000000189AD7250
		public void RefreshFillAmount() {} // 0x0000000189AD70E0-0x0000000189AD714C
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	[AddComponentMenu("UI/UI Image Filled Tail Follower", 34)]
	[ExecuteInEditMode]
	[Tooltip("\u81EA\u8EAB\u5FC5\u987B\u662F\u8981\u8DDF\u968F\u7684Follow Image\u7684\u5B50\u8282\u70B9\uFF1B\u4EC5\u5904\u7406Fill Method\u4E3A\u6C34\u5E73\u6216\u5782\u76F4\u7684\u60C5\u51B5")]
	public class UIImageFillTailFollower : TickableUIMono // TypeDefIndex: 49302
	{
		// Fields
		[SerializeField]
		private UIImage _followImage; // 0x68
		public float followOffset; // 0x70
		private RectTransform m_selfRectTransform; // 0x78
		private RectTransform m_followImageRectTransform; // 0x80
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public UIImageFillTailFollower() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		protected override void OnAwake() {} // 0x0000000189AD7260-0x0000000189AD7324
		protected override void OnEnable() {} // 0x0000000189AD7324-0x0000000189AD738C
		public override void Tick(float deltaTime) {} // 0x0000000189AD763C-0x0000000189AD76A8
		public void RefreshFollower() {} // 0x0000000189AD738C-0x0000000189AD763C
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	[Obsolete("\u8FD9\u4E2A\u7EC4\u4EF6\u7684\u529F\u80FD\u53EF\u4EE5\u76F4\u63A5\u653E\u5230UIImage\u91CC\u4E86\uFF0C\u4E4B\u540E\u6709\u65F6\u95F4\u53EF\u4EE5\u628A\u5B83\u8FC1\u79FB\u8FC7\u53BB")]
	public class UIImagePair : MonoBehaviour // TypeDefIndex: 49303
	{
		// Fields
		public List<UIImage> referencedImages; // 0x18
	
		// Properties
		public UnityEngine.Color color { set {} } // 0x0000000189AD79E4-0x0000000189AD7B74
		public UIImage first { get => default; } // 0x0000000189AD794C-0x0000000189AD79E4 
	
		// Constructors
		public UIImagePair() {} // 0x0000000189AD78CC-0x0000000189AD794C
	
		// Methods
		[IDTag(1)]
		public void LoadSprite(string folder, string spriteName) {} // 0x0000000189AD7814-0x0000000189AD78CC
		[IDTag(0)]
		public void LoadSprite(string path) {} // 0x0000000189AD76A8-0x0000000189AD7814
	}

	public class UIInertiaViewPager : TickableUIMono, IUIClearable // TypeDefIndex: 49317
	{
		// Fields
		[SerializeField]
		private UIScrollRect _scrollRect; // 0x68
		[Range(0f, 2f)]
		[SerializeField]
		private float _animationDuration; // 0x70
		[SerializeField]
		[Tooltip("When the scrolling speed is slower than this value, treat it as stopped")]
		private float _endScrollSpd; // 0x74
		[SerializeField]
		private ScrollEffectConfig.Timing _timing; // 0x78
		[SerializeField]
		private float _minScrollInterval; // 0x7C
		[AudioString]
		[SerializeField]
		private string _audioGear; // 0x80
		[AudioString]
		[SerializeField]
		private string _audioGearLock; // 0x88
		[SerializeField]
		[Tooltip("If set, a fling with speed in the range would fling to the next page.")]
		public bool flingToNextEnable; // 0x90
		[SerializeField]
		[Tooltip("If set, a fling with speed in the range would fling to the next page.")]
		public float flingToNextMinSpd; // 0x94
		[SerializeField]
		[Tooltip("If set, a fling with speed in the range would fling to the next page.")]
		public float flingToNextMaxSpd; // 0x98
		private int m_currentPage; // 0x9C
		private State m_state; // 0xA0
		private IScrollHandler m_scrollHandler; // 0xA8
		private ScrollEffectTrigger m_effectTrigger; // 0xB0
		private BlockerManager m_blockers; // 0xB8
		private DragContext m_dragContext; // 0xC0
		private int m_fromPage; // 0xC8
		private int m_toPage; // 0xCC
		private float m_tweenStartTime; // 0xD0
		private float m_tweenStartValue; // 0xD4
		private float m_tweenTargetValue; // 0xD8
		private bool m_isInited; // 0xDC
		[NonSerialized]
		public DisposedUnityEvent<int> onStateChanged; // 0xE8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		public bool isUpdating { get => default; } // 0x0000000189AD8DA0-0x0000000189AD8DAC 
		public int pageCount { get; private set; } // 0x0000000183D50ED0-0x0000000183D50EE0 0x0000000183D50FB0-0x0000000183D50FC0
		public int currentPage { get => default; set {} } // 0x0000000183D51960-0x0000000183D51970 0x0000000189AD8DAC-0x0000000189AD8DB8
		public float currentScrollIndex { get => default; } // 0x0000000189AD8D6C-0x0000000189AD8DA0 
	
		// Nested types
		public enum State // TypeDefIndex: 49304
		{
			IDLE = 0,
			DRAGING = 1,
			INERTIA = 2,
			ALIGNING = 3
		}
	
		private interface IScrollHandler : IHotfixable // TypeDefIndex: 49305
		{
			// Properties
			float velocity { get; }
			bool isDragging { get; }
			float scrollProgress { get; set; }
	
			// Methods
			void OnClear();
			void StopMoving();
		}
	
		private class CustomScrollHandler : Beyond.UI.UIInertiaViewPager.IScrollHandler // TypeDefIndex: 49306
		{
			// Fields
			private bool m_isScrolling; // 0x10
			private UIScrollRect m_scrollRect; // 0x18
	
			// Properties
			public float velocity { get => default; } // 0x0000000189AD442C-0x0000000189AD44AC 
			public float scrollProgress { get => default; set {} } // 0x0000000189AD43A0-0x0000000189AD442C 0x0000000189AD44AC-0x0000000189AD4540
			public bool isDragging { get => default; } // 0x0000000189AD4378-0x0000000189AD43A0 
	
			// Constructors
			public CustomScrollHandler() {} // Dummy constructor
			public CustomScrollHandler(UIScrollRect scrollRect) {} // 0x0000000189AD4258-0x0000000189AD4378
	
			// Methods
			public void OnClear() {} // 0x0000000189AD3FF4-0x0000000189AD4138
			public void StopMoving() {} // 0x0000000189AD4138-0x0000000189AD4198
			private void _OnScrollBegin(Vector2 delta) {} // 0x0000000189AD4198-0x0000000189AD41F8
			private void _OnScrollEnd(Vector2 delta) {} // 0x0000000189AD41F8-0x0000000189AD4258
		}
	
		private struct EmptyScrollHandler : Beyond.UI.UIInertiaViewPager.IScrollHandler // TypeDefIndex: 49307
		{
			// Properties
			public float velocity { get => default; } // 0x0000000183D503F0-0x0000000183D50400 
			public bool isDragging { get => default; } // 0x000000018115F4C0-0x000000018115F530 
			public float scrollProgress { get => default; set {} } // 0x0000000183D503F0-0x0000000183D50400 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void StopMoving() {} // 0x0000000189AD47C4-0x0000000189AD4808
			public void OnClear() {} // 0x0000000189AD4780-0x0000000189AD47C4
		}
	
		public struct FlingToNext // TypeDefIndex: 49308
		{
			// Fields
			public bool enable; // 0x00
			public float minSpd; // 0x04
			public float maxSpd; // 0x08
		}
	
		public struct ScrollOptions // TypeDefIndex: 49309
		{
			// Fields
			public FlingToNext flingToNext; // 0x00
		}
	
		private class DragContext // TypeDefIndex: 49310
		{
			// Fields
			public float startPos; // 0x10
	
			// Constructors
			public DragContext() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void BeginDrag(UIInertiaViewPager pager) {} // 0x0000000189AD4540-0x0000000189AD45B0
			public State EndDrag(UIInertiaViewPager pager) => default; // 0x0000000189AD45B0-0x0000000189AD461C
			private bool _TryFlingToNext(UIInertiaViewPager pager) => default; // 0x0000000189AD461C-0x0000000189AD4780
		}
	
		private enum BlockerDir // TypeDefIndex: 49311
		{
			UPWARD = 0,
			DOWNNWARD = 1,
			BOTH = 2
		}
	
		private struct InertiaBlocker : IHotfixable // TypeDefIndex: 49312
		{
			// Fields
			public BlockerDir dir; // 0x00
			public int index; // 0x04
	
			// Methods
			public bool IsDirMatch(float vec) => default; // 0x0000000189AD4808-0x0000000189AD4890
		}
	
		private class BlockerManager : IHotfixable // TypeDefIndex: 49313
		{
			// Fields
			private const float INERTIA_BIAS = 0.49f; // Metadata: 0x01FBC66D
			private List<InertiaBlocker> m_inertiaBlockers; // 0x10
			private float m_lastIndex; // 0x18
	
			// Properties
			public bool isInertiaing { get; private set; } // 0x0000000183D4E9A0-0x0000000183D4E9B0 0x0000000183D4E9B0-0x0000000183D4E9C0
	
			// Constructors
			public BlockerManager() {} // 0x0000000189AD3F7C-0x0000000189AD3FF4
	
			// Methods
			public void Init(int pageCount, List<int> blockFrames) {} // 0x0000000189AD3D84-0x0000000189AD3F1C
			public void StartInertia(float fromIndex) {} // 0x0000000189AD3F1C-0x0000000189AD3F7C
			public bool HitInertiaBlock(float curIndex, out float preferTo) {
				preferTo = default;
				return default;
			} // 0x0000000189AD3B88-0x0000000189AD3D84
		}
	
		public struct ScrollEffectConfig // TypeDefIndex: 49315
		{
			// Fields
			public Action onScrollToItem; // 0x00
			public Action onAlignedToItem; // 0x08
			public float minScrollInterval; // 0x10
			public Timing timing; // 0x14
	
			// Nested types
			public enum Timing // TypeDefIndex: 49314
			{
				HALF_VALUE = 0,
				FULL_VALUE = 1
			}
	
			// Methods
			public bool IsEmpty() => default; // 0x0000000189AD4890-0x0000000189AD48F0
		}
	
		public class ScrollEffectTrigger : IHotfixable // TypeDefIndex: 49316
		{
			// Fields
			private const float DFT_MIN_INTERVAL = 0.1f; // Metadata: 0x01FBC673
			private bool m_isValid; // 0x10
			private ScrollEffectConfig m_config; // 0x18
			private int m_lastFocusIndex; // 0x30
			private float m_curTime; // 0x34
			private float m_lastScrollTime; // 0x38
			private bool m_hasScrolled; // 0x3C
	
			// Constructors
			public ScrollEffectTrigger() {} // Dummy constructor
			public ScrollEffectTrigger(ScrollEffectConfig config) {} // 0x0000000189AD4B08-0x0000000189AD4B58
	
			// Methods
			public void NotifyScrolling(float curIndex, float deltaTime) {} // 0x0000000189AD49A8-0x0000000189AD4A98
			public void MarkHasScrolled() {} // 0x0000000189AD48F0-0x0000000189AD4944
			public void NotifyAlignFinish() {} // 0x0000000189AD4944-0x0000000189AD49A8
			public void Reset(int curIndex) {} // 0x0000000189AD4A98-0x0000000189AD4B08
		}
	
		// Constructors
		public UIInertiaViewPager() {} // 0x0000000189AD8C30-0x0000000189AD8D6C
	
		// Methods
		private void _PlayAudioGear() {} // 0x0000000189AD8924-0x0000000189AD89A0
		private void _PlayAudioGearLock() {} // 0x0000000189AD88A8-0x0000000189AD8924
		private void _InitIfNot() {} // 0x0000000189AD854C-0x0000000189AD875C
		public void ClearComponent() {} // 0x0000000189AD7EA4-0x0000000189AD7F98
		public override void Tick(float deltaTime) {} // 0x0000000189AD817C-0x0000000189AD84D4
		public void SetPageCount(int pageCount, List<int> segmentFrames = null) {} // 0x0000000189AD80F4-0x0000000189AD817C
		public void MoveToPage(int pageIndex) {} // 0x0000000189AD7F98-0x0000000189AD8028
		protected override void OnAwake() {} // 0x0000000189AD8028-0x0000000189AD8084
		protected override void OnEnable() {} // 0x0000000189AD8084-0x0000000189AD80F4
		private float _ScrollValue2PageIndex(float value) => default; // 0x0000000189AD89A0-0x0000000189AD8A18
		private float _PageIndex2ScrollValue(float index) => default; // 0x0000000189AD882C-0x0000000189AD88A8
		private int _ScrollValueAlignToPage(float value) => default; // 0x0000000189AD8A18-0x0000000189AD8A9C
		private void _SwitchToPage(int targetIndex, bool useTween) {} // 0x0000000189AD8A9C-0x0000000189AD8C30
		private void _AutoAlign() {} // 0x0000000189AD84D4-0x0000000189AD854C
		private void _OnStateChanged(State from, State to) {} // 0x0000000189AD875C-0x0000000189AD882C
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
	}

	[AddComponentMenu("UI/UI Input Field", 103)]
	public class UIInputField : TMP_InputField, IUIClearable // TypeDefIndex: 49319
	{
		// Fields
		public string activeInputActionId; // 0x388
		public string deactivateInputActionId; // 0x390
		private LuaPanel m_panel; // 0x3A0
		public bool isDebugInputField; // 0x3A8
		private Camera m_fallbackUICamera; // 0x3B0
		private GameObject m_fallbackUIRoot; // 0x3B8
		private RectTransform m_fallbackRectTransform; // 0x3C0
		private int m_activateBindingGroupId; // 0x3C8
		private bool m_isNaviFocused; // 0x3CC
		[SerializeField]
		private UIStateController _uiStateController; // 0x3D0
		[SerializeField]
		private string _onFocusStateName; // 0x3D8
		[SerializeField]
		private string _onFocusLostStateName; // 0x3E0
		[AudioString]
		[SerializeField]
		private string _audioPressStart; // 0x3E8
		public RectTransform m_keyboardOffsetTarget; // 0x3F0
		public RectTransform m_offsetTargetParent; // 0x3F8
		public RectTransform m_inputFieldRect; // 0x400
		public int m_pcDebug; // 0x408
		public float m_keyboardExtraOffsetY; // 0x40C
		private Vector2 m_baseKeyboardOffsetTarget; // 0x410
		private Vector2 m_baseKeyboardLocalPos; // 0x418
		private float m_inputFieldOffsetY; // 0x420
		private bool m_enableKeyboardOffsetCal; // 0x424
		private Coroutine m_heightChangeCoroutine; // 0x428
		private int m_lastHeight; // 0x430
		private int m_nowHeight; // 0x434
		[AudioString]
		public string audioOnActive; // 0x438
		private static UIInputField s_mFocusedInputField; // 0x00
	
		// Properties
		public int activeInputBindingId { get; private set; } // 0x0000000183D76100-0x0000000183D76110 0x0000000183D76120-0x0000000183D76130
		public int deactivateInputBindingId { get; private set; } // 0x0000000183D76110-0x0000000183D76120 0x0000000183D76130-0x0000000183D76140
		public LuaPanel panel { get => default; } // 0x0000000189AD91CC-0x0000000189AD9290 
		private bool isControllerInputValid { get => default; } // 0x0000000183683B80-0x0000000183683C00 
		public static UIInputField s_focusedInputField { get => default; private set {} } // 0x0000000189AD9290-0x0000000189AD92C8 0x0000000182B56B00-0x0000000182B56CA0
	
		// Constructors
		public UIInputField() {} // 0x0000000182849EC0-0x0000000182849F60
	
		// Methods
		protected override void SendOnFocus() {} // 0x0000000183CC4AA0-0x0000000183CC4B60
		protected override void SendOnFocusLost() {} // 0x0000000183CFB4E0-0x0000000183CFB570
		protected override void Awake() {} // 0x0000000183779290-0x00000001837795C0
		public override void OnSelect(BaseEventData eventData) {} // 0x0000000183CDD0A0-0x0000000183CDD0F0
		public override void OnDeselect(BaseEventData eventData) {} // 0x0000000183CBAAE0-0x0000000183CBAB30
		public override void ActivateInputField() {} // 0x0000000183683900-0x0000000183683A00
		public override void DeactivateInputField(bool clearSelection = false /* Metadata: 0x01FBC677 */) {} // 0x0000000183683A00-0x0000000183683B80
		protected override void OnDestroy() {} // 0x000000018304D600-0x000000018304D710
		protected override void OnEnable() {} // 0x0000000182CD8110-0x0000000182CD8150
		protected override void OnDisable() {} // 0x0000000182CD8150-0x0000000182CD8190
		protected override void _NotifyIsHover(bool isHover) {} // 0x000000018386D1D0-0x000000018386D250
		public override void OnInteractableChanged() {} // 0x0000000189AD8DB8-0x0000000189AD8E08
		private void _UpdateBindingEnable() {} // 0x0000000182CD8190-0x0000000182CD8300
		public void ClearComponent() {} // 0x0000000182C70800-0x0000000182C70940
		private Camera _GetCamera() => default; // 0x0000000189AD8E9C-0x0000000189AD90DC
		private void _VirtualKeyboardOnDestroy() {} // 0x0000000183D07970-0x0000000183D079A0
		private void _VirtualKeyboardSelect() {} // 0x0000000183CDD0F0-0x0000000183CDD120
		private void _VirtualKeyboardDeselect() {} // 0x0000000183CBAB30-0x0000000183CBAB60
		private void _VirtualKeyboardAwake() {} // 0x00000001837795C0-0x0000000183779600
		private void _UpdateKeyboardOffset(int offsetHeight) {} // 0x0000000189AD9178-0x0000000189AD91CC
		private void _CleanupAndroidObjects() {} // 0x0000000189AD8E58-0x0000000189AD8E9C
		private void _VirtualKeyboardInitJavaObj() {} // 0x0000000183779600-0x0000000183779630
		[IteratorStateMachine(typeof(__KeyboardHeightChange_d__59))]
		private IEnumerator _KeyboardHeightChange(Action<int> onHeightChanged) => default; // 0x0000000189AD90DC-0x0000000189AD9178
		public void __iFixBaseProxy_SendOnFocus() {} // 0x0000000189AD8E50-0x0000000189AD8E58
		public void __iFixBaseProxy_SendOnFocusLost() {} // 0x0000000189AD8E48-0x0000000189AD8E50
		public void __iFixBaseProxy_Awake() {} // 0x0000000189AAE8DC-0x0000000189AAE8E4
		public void __iFixBaseProxy_OnSelect(BaseEventData P0) {} // 0x0000000189AD8E40-0x0000000189AD8E48
		public void __iFixBaseProxy_OnDeselect(BaseEventData P0) {} // 0x0000000189AD8E28-0x0000000189AD8E30
		public void __iFixBaseProxy_ActivateInputField() {} // 0x0000000189AD8E18-0x0000000189AD8E20
		public void __iFixBaseProxy_DeactivateInputField(bool P0) {} // 0x0000000189AD8E20-0x0000000189AD8E28
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000189AAE8E4-0x0000000189AAE8EC
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000189AD8E38-0x0000000189AD8E40
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000189AD8E30-0x0000000189AD8E38
		public void __iFixBaseProxy__NotifyIsHover(bool P0) {} // 0x0000000189ACB974-0x0000000189ACB97C
		public void __iFixBaseProxy_OnInteractableChanged() {} // 0x000000018350B670-0x000000018350B680
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UIJoystick : MonoBehaviour, IBeginDragHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler, IUIClearable, IBindingGroupTarget // TypeDefIndex: 49320
	{
		// Fields
		[SerializeField]
		private RectTransform _runBg; // 0x18
		[SerializeField]
		private RectTransform _walkBg; // 0x20
		[SerializeField]
		private RectTransform _thumb; // 0x28
		[SerializeField]
		private RectTransform _directionIndicate; // 0x30
		[SerializeField]
		private RectTransform _walkDirectionIndicate; // 0x38
		[SerializeField]
		private RectTransform _rootCanvas; // 0x40
		[SerializeField]
		private RectTransform _triggerArea; // 0x48
		[SerializeField]
		private GraphicRaycaster _raycaster; // 0x50
		[SerializeField]
		private float _walkRation; // 0x58
		[Range(1f, 10f)]
		[SerializeField]
		private float _autoSprintStartLength; // 0x5C
		[Range(1f, 10f)]
		[SerializeField]
		private float _autoSprintStopLength; // 0x60
		[Range(0f, 360f)]
		[SerializeField]
		private float _autoSprintStartAngle; // 0x64
		[Range(0f, 360f)]
		[SerializeField]
		private float _autoSprintStopAngle; // 0x68
		public float margin; // 0x6C
		public float bgVisibleTimeWhenEnable; // 0x70
		private float m_bgHideTime; // 0x74
		[SerializeField]
		private bool _isDynamic; // 0x78
		private LuaPanel m_panel; // 0x80
		[SerializeField]
		private UITouchPanel _dynamicArea; // 0x90
		[SerializeField]
		private bool _dynamicButDontMove; // 0x98
		[SerializeField]
		private bool _useRewiredPlayerInput; // 0x99
		[SerializeField]
		private string _controllerRewiredActionX; // 0xA0
		[SerializeField]
		private string _controllerRewiredActionY; // 0xA8
		[SerializeField]
		private string _keyboardRewiredActionX; // 0xB0
		[SerializeField]
		private string _keyboardRewiredActionY; // 0xB8
		private bool m_active; // 0xC0
		private bool m_activatedByTouch; // 0xC1
		[NonSerialized]
		public DisposedUnityEvent onTouchStart; // 0xC8
		[NonSerialized]
		public DisposedUnityEvent onTouchEnd; // 0xD0
		[NonSerialized]
		public DisposedUnityEvent onMoveStart; // 0xD8
		[NonSerialized]
		public DisposedUnityEvent<Vector2> onMove; // 0xE0
		[NonSerialized]
		public DisposedUnityEvent<PointerEventData> onDrag; // 0xE8
		[NonSerialized]
		public DisposedUnityEvent<bool> onToggleAutoSprint; // 0xF0
		private CanvasGroup m_canvasGroup; // 0xF8
		private RectTransform m_rect; // 0x100
		private Vector2 m_oriAnchorMin; // 0x108
		private Vector2 m_oriAnchorMax; // 0x110
		private Vector2 m_oriAnchorPos; // 0x118
		private Vector2 m_oriPivot; // 0x120
		private bool m_isWalking; // 0x128
		private bool m_isRunning; // 0x129
		private bool m_isSprinting; // 0x12A
		private UIAnimationWrapper m_walkBgAnim; // 0x130
		private UIAnimationWrapper m_runBgAnim; // 0x138
		private bool m_isWalkBgVisible; // 0x140
		private bool m_isRunBgVisible; // 0x141
		private List<ExtendedPointerEventData> m_exPointers; // 0x148
		private ExtendedPointerEventData m_fakePointerEventData; // 0x150
		private ExtendedPointerEventData m_activePointerEventData; // 0x158
		private UICustomLayoutElement m_customLayoutElement; // 0x160
		private Vector2 m_lastFrameActiveStickVal; // 0x168
		private int m_groupId; // 0x178
		private bool m_bindingInit; // 0x17C
	
		// Properties
		public LuaPanel panel { get => default; } // 0x0000000189AD9990-0x0000000189AD9A54 
		public bool isDynamic { get => default; set {} } // 0x0000000183D4F800-0x0000000183D4F810 0x0000000189AD9A54-0x0000000189AD9A60
		public float walkRation { get => default; set {} } // 0x0000000183D51080-0x0000000183D51090 0x0000000182BDC0D0-0x0000000182BDC130
		public bool active { get => default; } // 0x0000000183D583F0-0x0000000183D58400 
		public int activeTouchId { get => default; } // 0x0000000189AD9958-0x0000000189AD9974 
		public Vector2 jsValue { get; private set; } // 0x0000000183D696E0-0x0000000183D69700 0x0000000183D4E740-0x0000000183D4E750
		private float m_thumbPosMaxLength { get => default; } // 0x00000001829130A0-0x0000000182913100 
		public PointerEventData curDragEventData { get; private set; } // 0x0000000183D574A0-0x0000000183D574B0 0x0000000184275C18-0x0000000184275C2C
		public bool groupEnabled { get => default; } // 0x0000000182913170-0x00000001829131D0 
		public bool shouldCheckInput { get => default; } // 0x0000000182913100-0x0000000182913170 
		public int groupId { get => default; } // 0x0000000189AD9974-0x0000000189AD9990 
		public IBindingGroupTarget parentTarget { get => default; } // 0x0000000183D56B50-0x0000000183D56B60 
		public InputBindingGroupMonoTarget parent { get; private set; } // 0x0000000183D56B50-0x0000000183D56B60 0x0000000184275C40-0x0000000184275C54
	
		// Constructors
		public UIJoystick() {} // 0x00000001828490A0-0x00000001828493C0
	
		// Methods
		private void Reset() {} // 0x0000000189AD9788-0x0000000189AD9858
		private void Awake() {} // 0x0000000182BDCE00-0x0000000182BDD480
		protected void OnEnable() {} // 0x0000000183B3E800-0x0000000183B3E930
		private void Start() {} // 0x0000000183CB4140-0x0000000183CB41F0
		protected void OnDestroy() {} // 0x0000000189AD93D0-0x0000000189AD9600
		private void _Tick() {} // 0x00000001829131D0-0x0000000182913DC0
		protected void OnDisable() {} // 0x0000000189AD9600-0x0000000189AD9788
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000182BDC8B0-0x0000000182BDC9F0
		public void OnPointerUp(PointerEventData eventData) {} // 0x00000001838DEC00-0x00000001838DED60
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000183CA3FA0-0x0000000183CA3FF0
		public void OnDrag(PointerEventData eventData) {} // 0x0000000182912E20-0x00000001829130A0
		public void CheckShouldActive() {} // 0x0000000182CAD100-0x0000000182CAD700
		private void _SetVisible(bool visible) {} // 0x0000000182BDC850-0x0000000182BDC8B0
		private void _ChangeDynamic(bool dynamic, bool force = false /* Metadata: 0x01FBC678 */) {} // 0x0000000182BDC540-0x0000000182BDC690
		private void _SetRectTransform(bool toOri) {} // 0x0000000182BDCAC0-0x0000000182BDCBE0
		private void _UpdateWalkBgScale() {} // 0x0000000182BDC130-0x0000000182BDC300
		private void _Activate(bool fromTouch, Vector2 showPos, Vector2 initJsValue) {} // 0x0000000182BDC9F0-0x0000000182BDCAC0
		private void _UpdateGait() {} // 0x0000000182912D50-0x0000000182912E20
		private void _UpdateIndicator() {} // 0x0000000182912970-0x0000000182912B40
		private void _UpdateBg() {} // 0x0000000182912B40-0x0000000182912C20
		private void _SetWalkBgVisible(bool visible, bool ignoreAnim = false /* Metadata: 0x01FBC679 */) {} // 0x0000000182912C20-0x0000000182912CA0
		private void _SetRunBgVisible(bool visible, bool ignoreAnim = false /* Metadata: 0x01FBC67A */) {} // 0x0000000182912CA0-0x0000000182912D50
		private void _OnHudLayoutLoaded([IsReadOnly] in EventData<string> eventData) {} // 0x0000000189AD9864-0x0000000189AD9958
		public void ClearComponent() {} // 0x0000000189AD92C8-0x0000000189AD93D0
		public void InitBinding() {} // 0x0000000182BDC300-0x0000000182BDC460
		private void _UpdateState() {} // 0x0000000182BDC460-0x0000000182BDC540
	}

	public class UILayoutDimensionListener : UIBehaviour, IHotfixable, ICanvasElement // TypeDefIndex: 49323
	{
		// Fields
		private ListSet<IAction> m_actionsWhenLayoutReady; // 0x18
		[NonSerialized]
		public DisposedUnityEvent eventOnPostLayout; // 0x20
	
		// Properties
		Transform ICanvasElement.transform { get => default; } // 0x0000000189AD9D30-0x0000000189AD9D80 
	
		// Nested types
		public interface IAction // TypeDefIndex: 49321
		{
			// Methods
			void DoAction();
		}
	
		// Constructors
		public UILayoutDimensionListener() {} // 0x0000000183D018C0-0x0000000183D01980
	
		// Methods
		public void GraphicUpdateComplete() {} // 0x0000000189AD9AF0-0x0000000189AD9B34
		public void LayoutComplete() {} // 0x0000000189AD9B34-0x0000000189AD9B78
		public void Rebuild(CanvasUpdate executing) {} // 0x0000000189AD9CB0-0x0000000189AD9D30
		[IteratorStateMachine(typeof(__NextFrameCoroutine_d__6))]
		private IEnumerator _NextFrameCoroutine() => default; // 0x0000000189AD9F94-0x0000000189ADA024
		public void DoOnceOnPostLayout(IAction action) {} // 0x0000000189AD9A60-0x0000000189AD9AF0
		protected override void OnEnable() {} // 0x0000000189AD9C10-0x0000000189AD9C60
		protected override void OnRectTransformDimensionsChange() {} // 0x0000000189AD9C60-0x0000000189AD9CB0
		protected override void OnDestroy() {} // 0x0000000189AD9B78-0x0000000189AD9C10
		private void _SetDirty() {} // 0x0000000189ADA024-0x0000000189ADA0B0
		private void _InvokePostLayoutCallback() {} // 0x0000000189AD9D80-0x0000000189AD9F94
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnRectTransformDimensionsChange() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018350B670-0x000000018350B680
	}

	public class UILeftSubtitle : TickableUIMono // TypeDefIndex: 49324
	{
		// Fields
		[SerializeField]
		private UIDialogTextWithCursor _dialogText1; // 0x68
		[SerializeField]
		private UIDialogTextWithCursor _dialogText2; // 0x70
		[SerializeField]
		private UIDialogTextWithCursor _dialogText3; // 0x78
		[SerializeField]
		private UIDialogTextWithCursor _dialogText4; // 0x80
		[SerializeField]
		private UIAnimationWrapper _panelAnimation; // 0x88
		private int m_maxDisplayIndex; // 0x90
		private readonly List<UIDialogTextWithCursor> m_dialogTextList; // 0x98
		private bool m_isDisplaying; // 0xA0
		private float m_currTime; // 0xA4
		private float m_textStayTime; // 0xA8
		private bool m_isAutoPlay; // 0xAC
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public UILeftSubtitle() {} // 0x0000000189ADA8BC-0x0000000189ADA950
	
		// Methods
		public override void Tick(float deltaTime) {} // 0x0000000189ADA6F8-0x0000000189ADA7B0
		public void StartAutoPlay(float textStayTime) {} // 0x0000000189ADA688-0x0000000189ADA6F8
		public void SetLeftSubTitle(string text1, string text2, string text3, string text4) {} // 0x0000000189ADA1A8-0x0000000189ADA618
		public float UpdateByPlayTime(float currTime) => default; // 0x0000000189ADA7BC-0x0000000189ADA8BC
		public void Exit() {} // 0x0000000189ADA0B0-0x0000000189ADA1A8
		public void SetVisible(bool visible) {} // 0x0000000189ADA618-0x0000000189ADA688
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	[ExecuteInEditMode]
	public class UIMaterialAnimation : TickableUIMono // TypeDefIndex: 49325
	{
		// Fields
		[FormerlySerializedAs("_rawImage")]
		[SerializeField]
		private MaskableGraphic _maskableGraphic; // 0x68
		[SerializeField]
		private Material _material; // 0x70
		[SerializeField]
		private string _propertiesName1; // 0x78
		[SerializeField]
		private float _propertiesSet1; // 0x80
		[SerializeField]
		private string _propertiesName2; // 0x88
		[SerializeField]
		private float _propertiesSet2; // 0x90
		[SerializeField]
		private string _propertiesName3; // 0x98
		[SerializeField]
		private float _propertiesSet3; // 0xA0
		[SerializeField]
		private string _propertiesName4; // 0xA8
		[SerializeField]
		private float _propertiesSet4; // 0xB0
		[SerializeField]
		private string _propertiesName5; // 0xB8
		[SerializeField]
		private float _propertiesSet5; // 0xC0
		[SerializeField]
		private string _propertiesName6; // 0xC8
		[SerializeField]
		private float _propertiesSet6; // 0xD0
		[SerializeField]
		private string _propertiesName7; // 0xD8
		[SerializeField]
		private float _propertiesSet7; // 0xE0
		[SerializeField]
		private string _propertiesName8; // 0xE8
		[SerializeField]
		private float _propertiesSet8; // 0xF0
		[SerializeField]
		private string _propertiesName9; // 0xF8
		[SerializeField]
		private float _propertiesSet9; // 0x100
		[SerializeField]
		private string _propertiesName10; // 0x108
		[SerializeField]
		private float _propertiesSet10; // 0x110
		[SerializeField]
		private string _propertiesVectorName1; // 0x118
		[SerializeField]
		private Vector4 _propertiesVector1; // 0x120
		[SerializeField]
		private string _propertiesVectorName2; // 0x130
		[SerializeField]
		private Vector4 _propertiesVector2; // 0x138
		[SerializeField]
		private string _propertiesVectorName3; // 0x148
		[SerializeField]
		private Vector4 _propertiesVector3; // 0x150
		[SerializeField]
		private string _propertiesVectorName4; // 0x160
		[SerializeField]
		private Vector4 _propertiesVector4; // 0x168
		[SerializeField]
		private string _propertiesVectorName5; // 0x178
		[SerializeField]
		private Vector4 _propertiesVector5; // 0x180
		[SerializeField]
		private string _propertiesColorName1; // 0x190
		[SerializeField]
		private UnityEngine.Color _propertiesColor1; // 0x198
		[SerializeField]
		private string _propertiesColorName2; // 0x1A8
		[SerializeField]
		private UnityEngine.Color _propertiesColor2; // 0x1B0
		[SerializeField]
		private string _propertiesColorName3; // 0x1C0
		[SerializeField]
		private UnityEngine.Color _propertiesColor3; // 0x1C8
		private Material m_matIns; // 0x1D8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Constructors
		public UIMaterialAnimation() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x0000000182861160-0x0000000182861200
		protected override void OnAwake() {} // 0x00000001837D3C20-0x00000001837D3D60
		protected override void OnRelease() {} // 0x0000000183A28FF0-0x0000000183A290A0
		private void _TryUpdate() {} // 0x0000000182861200-0x00000001828617D0
		public void ForceUpdate() {} // 0x0000000189ADA950-0x0000000189ADA9A0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	public class UINonUnifiedScrollList : UIScrollList // TypeDefIndex: 49327
	{
		// Fields
		public GetCellSizeMode getCellSizeMode; // 0x278
		[SerializeField]
		private bool _recalculateAfterSizeChange; // 0x27C
		[SerializeField]
		private bool _forceUpdateCellSizeCache; // 0x27D
		public Func<int, int> getSubCellCount; // 0x280
		public Func<int, float> getCellSize; // 0x288
		[NonSerialized]
		public float overrideContainSize; // 0x290
		private GridLayoutGroup m_templateCellGridLayoutGroup; // 0x298
		private Dictionary<int, float> m_cellSizeCache; // 0x2A0
		private int m_containerTopIndex; // 0x2A8
		private const float CONTAINER_SIZE_BUFFER = 50f; // Metadata: 0x01FBC68D
		[NonSerialized]
		public float additiveContainerSizeBuffer; // 0x2AC
		private float m_lastScrollStep; // 0x2B0
		private bool m_isRecalculatingSize; // 0x2B4
		private bool m_isCalculatingContainerSize; // 0x2B5
		private int m_averageCount; // 0x2B8
		private float m_averageCellSize; // 0x2BC
		private bool m_needRecalculateAverage; // 0x2C0
		private Dictionary<int, bool> m_cellFoldStateDic; // 0x2C8
		private IUIFoldoutComp m_cellTemplateFoldoutComp; // 0x2D0
	
		// Properties
		public override float currentStep { get => default; set {} } // 0x0000000189ADD894-0x0000000189ADDA4C 0x0000000189ADDA4C-0x0000000189ADDA78
	
		// Nested types
		public enum GetCellSizeMode // TypeDefIndex: 49326
		{
			ByGetCellSizeFunc = 0,
			ByLayoutGroup = 1,
			GetAfterCellCreated = 2
		}
	
		// Constructors
		public UINonUnifiedScrollList() {} // 0x0000000183B73140-0x0000000183B73250
	
		// Methods
		protected override void InitBasicInfo() {} // 0x0000000189ADBEA4-0x0000000189ADBF6C
		protected override void CalcSomeCountNum() {} // 0x0000000189ADA9A0-0x0000000189ADAA08
		protected override float GetLeftLength(bool checkVertical, int checkCount = -1 /* Metadata: 0x01FBC67B */) => default; // 0x0000000189ADB6A0-0x0000000189ADB758
		[IDTag(0)]
		public override void UpdateCount(int newCount) {} // 0x0000000189ADD388-0x0000000189ADD3FC
		[IDTag(1)]
		public override void UpdateCount(int newCount, bool setTop, bool forceRecalculate = false /* Metadata: 0x01FBC67C */, bool onlyUpdateNewCellContent = false /* Metadata: 0x01FBC67D */, bool skipGraduallyShow = false /* Metadata: 0x01FBC67E */) {} // 0x0000000189ADD0A8-0x0000000189ADD168
		[IDTag(2)]
		public override void UpdateCount(int newCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x01FBC67F */, bool onlyUpdateNewCellContent = false /* Metadata: 0x01FBC680 */, bool skipGraduallyShow = false /* Metadata: 0x01FBC681 */, ScrollAlignType alignType = ScrollAlignType.Top /* Metadata: 0x01FBC682 */) {} // 0x0000000189ADD168-0x0000000189ADD388
		public override void LateTick(float deltaTime) {} // 0x0000000189ADBF6C-0x0000000189ADBFE8
		protected override void OnScroll(Vector2 v) {} // 0x0000000189ADC180-0x0000000189ADC208
		public static Vector2 GetGridLayoutSize(GridLayoutGroup grid, int count) => default; // 0x0000000189ADB340-0x0000000189ADB520
		private float _GetCellSize(int index) => default; // 0x0000000189ADD458-0x0000000189ADD7C4
		protected override float GetContainerSize(bool ignoreAutoLayout = false /* Metadata: 0x01FBC683 */) => default; // 0x0000000189ADAED0-0x0000000189ADB340
		public override float GetCenterIndex() => default; // 0x0000000189ADACE4-0x0000000189ADAED0
		public override Vector2Int GetShowRange(float bufferSize = 0f /* Metadata: 0x01FBC684 */, bool ignoreGraduallyShow = false /* Metadata: 0x01FBC688 */) => default; // 0x0000000189ADBA20-0x0000000189ADBC9C
		protected override Vector2Int GetNotCacheRange() => default; // 0x0000000189ADB7E4-0x0000000189ADB8BC
		protected override void MoveCellTo(Cell cell, int index) {} // 0x0000000189ADBFE8-0x0000000189ADC0B4
		protected override void OnUpdateCell(Cell cell, int index) {} // 0x0000000189ADC208-0x0000000189ADC484
		protected override float GetTargetPosByIndex(int index, ScrollAlignType alignType = ScrollAlignType.Top /* Metadata: 0x01FBC689 */) => default; // 0x0000000189ADBC9C-0x0000000189ADBEA4
		private float _GetCellsSizeTo(int index) => default; // 0x0000000189ADD7C4-0x0000000189ADD894
		protected override void ScrollTo(int index, bool fastMode = false /* Metadata: 0x01FBC68A */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x01FBC68B */) {} // 0x0000000189ADC484-0x0000000189ADC714
		public override void ClearComponent() {} // 0x0000000189ADAA08-0x0000000189ADAAB4
		public override void SetStepTo(float step) {} // 0x0000000189ADC994-0x0000000189ADCA08
		public void SetCurrentStep(float currentStep) {} // 0x0000000189ADC714-0x0000000189ADC8FC
		public float GetScrollBarSize() => default; // 0x0000000189ADB8BC-0x0000000189ADBA20
		public float GetLastScrollStep() => default; // 0x0000000189ADB520-0x0000000189ADB6A0
		public void UpdateLastScrollStep() {} // 0x0000000189ADD3FC-0x0000000189ADD458
		public float GetNormalizedPosition() => default; // 0x0000000189ADB758-0x0000000189ADB7E4
		public void SetNormalizedPosition(float normalizedPosition) {} // 0x0000000189ADC8FC-0x0000000189ADC994
		public void ToggleByState(int index, bool isFoldOut, bool fastMode) {} // 0x0000000189ADCA08-0x0000000189ADCBEC
		public void Toggle(int index, bool fastMode = false /* Metadata: 0x01FBC68C */) {} // 0x0000000189ADCBEC-0x0000000189ADCE14
		public void FoldAll(bool isFoldOut) {} // 0x0000000189ADAAB4-0x0000000189ADACE4
		public void NotifyCellSizeChange(int index, float size) {} // 0x0000000189ADC0B4-0x0000000189ADC180
		public void __iFixBaseProxy_InitBasicInfo() {} // 0x0000000189ADD020-0x0000000189ADD028
		public void __iFixBaseProxy_CalcSomeCountNum() {} // 0x0000000189ADCFE0-0x0000000189ADCFE8
		public float __iFixBaseProxy_GetLeftLength(bool P0, int P1) => default; // 0x0000000189ADD000-0x0000000189ADD008
		public void __iFixBaseProxy_UpdateCount(int P0) {} // 0x0000000189ADD098-0x0000000189ADD0A0
		public void __iFixBaseProxy_UpdateCount(int P0, bool P1, bool P2, bool P3, bool P4) {} // 0x0000000189ADD078-0x0000000189ADD098
		public void __iFixBaseProxy_UpdateCount(int P0, int P1, bool P2, bool P3, bool P4, ScrollAlignType P5) {} // 0x0000000189ADD058-0x0000000189ADD078
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000189ADD028-0x0000000189ADD030
		public void __iFixBaseProxy_OnScroll(Vector2 P0) {} // 0x0000000189ADD030-0x0000000189ADD038
		public float __iFixBaseProxy_GetContainerSize(bool P0) => default; // 0x0000000189ADCFF8-0x0000000189ADD000
		public float __iFixBaseProxy_GetCenterIndex() => default; // 0x0000000189ADCFF0-0x0000000189ADCFF8
		public Vector2Int __iFixBaseProxy_GetShowRange(float P0, bool P1) => default; // 0x0000000189ADD010-0x0000000189ADD018
		public Vector2Int __iFixBaseProxy_GetNotCacheRange() => default; // 0x0000000189ADD008-0x0000000189ADD010
		public void __iFixBaseProxy_MoveCellTo(Cell P0, int P1) {} // 0x0000000189AC26FC-0x0000000189AC2704
		public void __iFixBaseProxy_OnUpdateCell(Cell P0, int P1) {} // 0x0000000189ADD038-0x0000000189ADD040
		public float __iFixBaseProxy_GetTargetPosByIndex(int P0, ScrollAlignType P1) => default; // 0x0000000189ADD018-0x0000000189ADD020
		public void __iFixBaseProxy_ScrollTo(int P0, bool P1, ScrollAlignType P2) {} // 0x0000000189ADD040-0x0000000189ADD050
		public void __iFixBaseProxy_ClearComponent() {} // 0x0000000189ADCFE8-0x0000000189ADCFF0
		public float __iFixBaseProxy_get_currentStep() => default; // 0x0000000189ADD0A0-0x0000000189ADD0A8
		public void __iFixBaseProxy_SetStepTo(float P0) {} // 0x0000000189ADD050-0x0000000189ADD058
	}

	[RequireComponent(typeof(UINonUnifiedScrollList))]
	public class UINonUnifiedScrollRect : UIScrollRect // TypeDefIndex: 49328
	{
		// Fields
		private bool m_isInited; // 0x1D8
		private bool m_isRebuilding; // 0x1D9
		private UINonUnifiedScrollList m_scrollList; // 0x1E0
		private UILayoutDimensionListener m_dimensionListener; // 0x1E8
	
		// Constructors
		public UINonUnifiedScrollRect() {} // 0x0000000183D4D8F0-0x0000000183D4D900
	
		// Methods
		private void _InitIfNot() {} // 0x0000000189ADDEB0-0x0000000189ADDFF8
		protected override void UpdateScrollbars(Vector2 offset) {} // 0x0000000189ADDDCC-0x0000000189ADDEB0
		public override void Rebuild(CanvasUpdate executing) {} // 0x0000000189ADDACC-0x0000000189ADDB3C
		private void _UpdateNonUnifiedScrollbars() {} // 0x0000000189ADE0B0-0x0000000189ADE228
		protected override void SetHorizontalNormalizedPosition(float value) {} // 0x0000000189ADDB3C-0x0000000189ADDC7C
		protected override void SetVerticalNormalizedPosition(float value) {} // 0x0000000189ADDC7C-0x0000000189ADDDBC
		private void _OnPostLayout() {} // 0x0000000189ADDFF8-0x0000000189ADE0B0
		public void __iFixBaseProxy_UpdateScrollbars(Vector2 P0) {} // 0x0000000189ADDDC4-0x0000000189ADDDCC
		public void __iFixBaseProxy_Rebuild(CanvasUpdate P0) {} // 0x0000000189ADDDBC-0x0000000189ADDDC4
		public void __iFixBaseProxy_SetHorizontalNormalizedPosition(float P0) {} // 0x0000000184274DE0-0x0000000184274DEC
		public void __iFixBaseProxy_SetVerticalNormalizedPosition(float P0) {} // 0x0000000184274DEC-0x0000000184274DFC
	}

	[ExecuteAlways]
	[RequireComponent(typeof(UIText))]
	public class UINumberScrollTween : TickableUIMono // TypeDefIndex: 49329
	{
		// Fields
		public UIText bindingUIText; // 0x68
		public float tweenDuration; // 0x70
		public bool useCustomNumberTweenCurve; // 0x74
		public AnimationCurve numberTweenCurve; // 0x78
		private string m_tweenToText; // 0x80
		private float m_tweenStartTime; // 0x88
		private float m_curTime; // 0x8C
		private bool m_inTransition; // 0x90
		private float m_fromNumber; // 0x94
		private float m_toNumber; // 0x98
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		public string tweenToText { get => default; set {} } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x0000000189ADE788-0x0000000189ADE790
		public string text { get => default; set {} } // 0x0000000189ADE620-0x0000000189ADE6D4 0x0000000189ADE6D4-0x0000000189ADE788
	
		// Constructors
		public UINumberScrollTween() {} // 0x0000000189ADE5D4-0x0000000189ADE620
	
		// Methods
		private void Start() {} // 0x0000000189ADE228-0x0000000189ADE2B8
		public override void Tick(float deltaTime) {} // 0x0000000189ADE2B8-0x0000000189ADE388
		private void _TweenToTarget(string targetText) {} // 0x0000000189ADE4D0-0x0000000189ADE5D4
		private void _CleanupBeforeTween() {} // 0x0000000189ADE388-0x0000000189ADE3D8
		private void _HandleNumberScrollTween(float fromNumber, float toNumber, float curTime) {} // 0x0000000189ADE3D8-0x0000000189ADE4D0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	public class UIPCScaleHelper : MonoBehaviour // TypeDefIndex: 49330
	{
		// Fields
		public Vector3 baseScale; // 0x18
	
		// Constructors
		public UIPCScaleHelper() {} // 0x00000001838567F0-0x0000000183856810
	
		// Methods
		private void OnEnable() {} // 0x00000001837E5E00-0x00000001837E5F00
	}

	[AddComponentMenu("UI/UI Raw Image", 12)]
	public class UIRawImage : RawImage // TypeDefIndex: 49331
	{
		// Constructors
		public UIRawImage() {} // 0x0000000182700700-0x0000000182700710
	}

	[ExecuteInEditMode]
	public class UIRegionBuildingTexManager : MonoBehaviour // TypeDefIndex: 49332
	{
		// Fields
		[SerializeField]
		private Shader _regionMapShader; // 0x18
		public Texture2D minimapOutlineTex; // 0x20
		private static int s_buildingOutlineTex; // 0x00
		private Renderer m_meshRenderer; // 0x28
		private static MaterialPropertyBlock s_materialPropertyBlock; // 0x08
	
		// Properties
		private static MaterialPropertyBlock materialPropertyBlock { get => default; } // 0x0000000182D14AF0-0x0000000182D14C10 
	
		// Constructors
		public UIRegionBuildingTexManager() {} // 0x000000018426FE60-0x000000018426FE68
		static UIRegionBuildingTexManager() {} // 0x0000000183D22A30-0x0000000183D22A80
	
		// Methods
		private void OnEnable() {} // 0x0000000182D147A0-0x0000000182D14920
		private void OnValidate() {} // 0x0000000189ADE790-0x0000000189ADE880
		private void OnDisable() {} // 0x0000000182D146C0-0x0000000182D147A0
		private void _UpdateTexture(Renderer meshRenderer, Shader minimapTerrainShader, Texture2D buildingTex) {} // 0x0000000182D14920-0x0000000182D14AF0
	}

	public class UIScaleHolder : TickableUIMono // TypeDefIndex: 49333
	{
		// Fields
		private RectTransform m_rectTransform; // 0x68
		private RectTransform m_parentTransform; // 0x70
		private bool m_holdValid; // 0x78
		[SerializeField]
		private Vector3 _extraScale; // 0x7C
		[SerializeField]
		private bool _onlyHoldOnEnable; // 0x88
		public RectTransform referenceTransform; // 0x90
		public float animationExtraScale; // 0x98
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Constructors
		public UIScaleHolder() {} // 0x00000001828461E0-0x0000000182846210
	
		// Methods
		protected override void OnAwake() {} // 0x00000001824A45B0-0x00000001824A4780
		protected override void OnEnable() {} // 0x0000000183476030-0x0000000183476070
		public override void LateTick(float deltaTime) {} // 0x0000000182E53340-0x0000000182E53430
		private bool _IsValidScale(Vector3 scale) => default; // 0x0000000182342F90-0x0000000182343070
		private void _HoldScale() {} // 0x0000000182342A70-0x0000000182342F90
		public void SetExtraScale(Vector3 extraScale) {} // 0x0000000189ADE880-0x0000000189ADE904
		public Vector3 GetExtraScale() => default; // 0x000000018338E990-0x000000018338E9E0
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	[AddComponentMenu("UI/UI Scrollbar", 36)]
	public class UIScrollbar : Scrollbar // TypeDefIndex: 49334
	{
		// Constructors
		public UIScrollbar() {} // 0x0000000182849090-0x00000001828490A0
	
		// Methods
		protected override void Awake() {} // 0x0000000183D1C370-0x0000000183D1C3B0
		public void __iFixBaseProxy_Awake() {} // 0x0000000189AAE8DC-0x0000000189AAE8E4
	}

	public class UIScrollbarKeyHint : TickableUIMono // TypeDefIndex: 49335
	{
		// Fields
		private UIScrollRect m_scrollRect; // 0x68
		private UIImage m_image; // 0x70
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public UIScrollbarKeyHint() {} // 0x0000000182846010-0x0000000182846020
	
		// Methods
		protected override void OnAwake() {} // 0x0000000189AE4DA0-0x0000000189AE4E50
		public override void Tick(float deltaTime) {} // 0x0000000189AE4E50-0x0000000189AE50D8
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	public class UIScrollCircle : TickableUIMono, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, ICanvasElement, IUIClearable // TypeDefIndex: 49337
	{
		// Fields
		[FormerlySerializedAs("_cellPrefab")]
		[SerializeField]
		[Tooltip("\u53EF\u4EE5\u662FPrefab\u6216\u8005\u9762\u677F\u4E0A\u7684\u8282\u70B9")]
		private GameObject _cellTemplate; // 0x68
		[SerializeField]
		[Tooltip("\u4E00\u5708\u6709\u591A\u5C11\u4E2A")]
		private int _totalNum; // 0x70
		[SerializeField]
		[Tooltip("\u81EA\u52A8\u6ED1\u52A8\u65F6\u95F4")]
		private float _tweenTime; // 0x74
		[SerializeField]
		private RectTransform m_Viewport; // 0x78
		[SerializeField]
		private float m_Elasticity; // 0x80
		[SerializeField]
		private float _speedFactor; // 0x84
		[NonSerialized]
		public UnityEvent<int, int, bool> onCenterIndexChanged; // 0x90
		[NonSerialized]
		public UnityEvent<GameObject, int> onUpdateCell; // 0x98
		private Vector2 m_PointerStartLocalCursor; // 0xA0
		private Vector2 m_tmpDragPosition; // 0xA8
		private bool m_Dragging; // 0xB0
		private bool m_inited; // 0xB1
		private float m_Velocity; // 0xB4
		private Vector2 m_curScreenPos; // 0xB8
		private RectTransform m_ViewRect; // 0xC0
		private LuaPanel m_panel; // 0xC8
		private float m_radius; // 0xD0
		private float m_cellAngle; // 0xD4
		private List<Cell> m_showingCells; // 0xD8
		private float m_rangeMax; // 0xE0
		private float m_curAngle; // 0xE4
		private float m_lastAngle; // 0xE8
		private int m_curCenterIndex; // 0xEC
		private DG.Tweening.Tween m_tween; // 0xF0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public float elasticity { get => default; set {} } // 0x0000000183D51B00-0x0000000183D51B10 0x0000000183D56E80-0x0000000183D56E90
		public int count { get; set; } // 0x0000000183D4F0B0-0x0000000183D4F0C0 0x0000000183D4F0E0-0x0000000183D4F0F0
		public float velocity { get => default; set {} } // 0x0000000183D57F30-0x0000000183D57F40 0x0000000183D57FB0-0x0000000183D57FC0
		public LuaPanel panel { get => default; } // 0x0000000189AE0618-0x0000000189AE06DC 
		protected RectTransform viewRect { get => default; } // 0x0000000189AE06DC-0x0000000189AE0814 
		Transform ICanvasElement.transform { get => default; } // 0x0000000189ADF408-0x0000000189ADF458 
	
		// Nested types
		public class Cell // TypeDefIndex: 49336
		{
			// Fields
			public GameObject gameObject; // 0x10
			public RectTransform rectTransform; // 0x18
			public GameObject realGameObject; // 0x20
	
			// Constructors
			public Cell() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void SetSelect(bool select) {} // 0x0000000189ADDA78-0x0000000189ADDACC
		}
	
		// Constructors
		public UIScrollCircle() {} // 0x0000000189AE04A0-0x0000000189AE0618
	
		// Methods
		public void OnInitializePotentialDrag(PointerEventData eventData) {} // 0x0000000189ADF150-0x0000000189ADF1BC
		public virtual bool IsActive() => default; // 0x0000000189ADEA64-0x0000000189ADEAB4
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189ADEC48-0x0000000189ADEDA8
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000189ADF0E4-0x0000000189ADF150
		public void OnDrag(PointerEventData eventData) {} // 0x0000000189ADEE00-0x0000000189ADF060
		private void _UpdateSpeed() {} // 0x0000000189AE03E8-0x0000000189AE04A0
		private bool _CheckCanMove(float deltaAngle) => default; // 0x0000000189ADF514-0x0000000189ADF598
		private void _TryUpdateCells() {} // 0x0000000189ADFE6C-0x0000000189ADFEF0
		private void _UpdateAuto() {} // 0x0000000189ADFEF0-0x0000000189AE0064
		protected override void OnRelease() {} // 0x0000000189ADF1BC-0x0000000189ADF22C
		private float _GetDeltaAngle(Vector2 position) => default; // 0x0000000189ADF77C-0x0000000189ADF944
		private void _InitCells() {} // 0x0000000189ADF9B8-0x0000000189ADFC64
		private void _Init() {} // 0x0000000189ADFC64-0x0000000189ADFD58
		private void _OnAwakeInit() {} // 0x0000000189ADFD58-0x0000000189ADFE6C
		private void _UpdateScrollRange() {} // 0x0000000189AE01A0-0x0000000189AE0208
		private int _GetRealIndex(int index) => default; // 0x0000000189ADF944-0x0000000189ADF9B8
		private void _UpdateShowingCells() {} // 0x0000000189AE0208-0x0000000189AE03E8
		private void _UpdateCenterIndex(bool forceUpdate = false /* Metadata: 0x01FBC694 */) {} // 0x0000000189AE0064-0x0000000189AE01A0
		private void _DoScroll(float tmpAngle, bool direct = false /* Metadata: 0x01FBC695 */) {} // 0x0000000189ADF598-0x0000000189ADF77C
		public void OnScroll(PointerEventData eventData) {} // 0x0000000189ADF22C-0x0000000189ADF280
		public void Rebuild(CanvasUpdate executing) {} // 0x0000000189ADF280-0x0000000189ADF2D4
		public void LayoutComplete() {} // 0x0000000189ADEBA8-0x0000000189ADEBEC
		public void GraphicUpdateComplete() {} // 0x0000000189ADEA20-0x0000000189ADEA64
		public bool IsDestroyed() => default; // 0x0000000189ADEAB4-0x0000000189ADEB34
		protected override void OnEnable() {} // 0x0000000189ADF060-0x0000000189ADF0E4
		protected override void OnDisable() {} // 0x0000000189ADEDA8-0x0000000189ADEE00
		protected void Start() {} // 0x0000000189ADF3A0-0x0000000189ADF3F0
		protected override void OnAwake() {} // 0x0000000189ADEBEC-0x0000000189ADEC48
		public override void LateTick(float deltaTime) {} // 0x0000000189ADEB34-0x0000000189ADEBA8
		public void UpdateCount(int newCount, bool setTop = true /* Metadata: 0x01FBC696 */) {} // 0x0000000189ADF458-0x0000000189ADF514
		public void ScrollToIndex(int index, bool direct = false /* Metadata: 0x01FBC697 */) {} // 0x0000000189ADF2D4-0x0000000189ADF3A0
		public GameObject Get(int index) => default; // 0x0000000189ADE974-0x0000000189ADEA20
		public void ClearComponent() {} // 0x0000000189ADE904-0x0000000189ADE974
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class UIScrollContainerFollower : TickableUIMono // TypeDefIndex: 49338
	{
		// Fields
		[SerializeField]
		private UIScrollList _followTargetList; // 0x68
		[SerializeField]
		private UIScrollRect _followTargetRect; // 0x70
		private RectTransform m_rectTransform; // 0x78
		private float m_currentSize; // 0x80
		private bool m_targetSizeChanged; // 0x84
		private Vector2 m_currentPos; // 0x88
		private bool m_targetPosChanged; // 0x90
		private bool m_setValid; // 0x91
		private bool m_isFollowContent; // 0x92
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Constructors
		public UIScrollContainerFollower() {} // 0x0000000183CF5340-0x0000000183CF5360
	
		// Methods
		protected override void OnAwake() {} // 0x0000000189AE0A80-0x0000000189AE0B68
		public override void LateTick(float deltaTime) {} // 0x0000000189AE0814-0x0000000189AE0A80
		private void _RefreshSizeAndPositionToTargetContainer() {} // 0x0000000189AE0B68-0x0000000189AE0EAC
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public enum ScrollDirection // TypeDefIndex: 49339
	{
		Vertical = 0,
		Horizontal = 1
	}

	[ExecuteInEditMode]
	public class UIScrollList : TickableUIMono, IBeginDragHandler, IDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 49346
	{
		// Fields
		[FormerlySerializedAs("_cellPrefab")]
		[SerializeField]
		[Tooltip("\u53EF\u4EE5\u662FPrefab\u6216\u8005\u9762\u677F\u4E0A\u7684\u8282\u70B9")]
		protected GameObject _cellTemplate; // 0x68
		[SerializeField]
		private Beyond.UI.ScrollDirection _scrollDirection; // 0x70
		[SerializeField]
		private bool _expandCellSize; // 0x74
		[SerializeField]
		private bool _alsoExpandCellSizeInAnotherDirection; // 0x75
		[SerializeField]
		protected Vector2 _space; // 0x78
		[SerializeField]
		protected Padding _padding; // 0x80
		[SerializeField]
		protected bool _ignorePaddingWhenScroll; // 0x90
		[FormerlySerializedAs("_cacheBufferSize")]
		[SerializeField]
		protected float _notCacheBufferSize; // 0x94
		[SerializeField]
		protected float _extraCacheBufferSize; // 0x98
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onUpdateCell; // 0xA0
		[NonSerialized]
		public DisposedUnityEvent onGraduallyShowFinish; // 0xA8
		[NonSerialized]
		public DisposedUnityEvent onScrollEnd; // 0xB0
		[NonSerialized]
		public DisposedUnityEvent<int> onUpdateCount; // 0xB8
		[NonSerialized]
		public Func<int, string> getCellName; // 0xC0
		public static DisposedUnityEvent<string> s_onGraduallyShowFinish; // 0x00
		[SerializeField]
		protected bool _inverse; // 0xC8
		[FormerlySerializedAs("_autoCenterWhenFew")]
		[SerializeField]
		[Tooltip("\u5982\u679C\u6570\u91CF\u5C0F\u4E8E\u663E\u793A\u6570\u91CF\u5219\u7279\u6B8A\u6392\u7248")]
		protected bool _autoLayoutWhenFew; // 0xC9
		[SerializeField]
		protected AutoLayoutWhenFewType _autoLayoutWhenFewType; // 0xCC
		[SerializeField]
		[Tooltip("\u975E\u6EDA\u52A8\u65B9\u5411\u81EA\u52A8\u5C45\u4E2D")]
		protected bool _autoCenterInOtherDir; // 0xD0
		[SerializeField]
		private Transform _centerNode; // 0xD8
		[SerializeField]
		private bool _hideRayCastWhenLessThanOnePage; // 0xE0
		[SerializeField]
		private bool _clampWhenLessThanOnePage; // 0xE1
		private ScrollRect.MovementType m_lastScrollRectMovementType; // 0xE4
		[SerializeField]
		[Space]
		protected RectTransform _container; // 0xE8
		[SerializeField]
		protected UIScrollRect _scrollRect; // 0xF0
		protected RectTransform m_rect; // 0x100
		protected int m_countPerLine; // 0x108
		protected int m_maxShowingLine; // 0x10C
		protected int m_maxShowingCellCount; // 0x110
		protected int m_maxCellCountWhenNoScroll; // 0x114
		protected float m_viewWidth; // 0x118
		protected float m_viewHeight; // 0x11C
		protected float m_cellWidth; // 0x120
		protected float m_cellHeight; // 0x124
		protected Graphic m_graphic; // 0x128
		protected Padding m_realPadding; // 0x130
		private Vector3[] m_cellCorners; // 0x140
		protected Dictionary<int, Cell> m_showingCells; // 0x148
		private Stack<Cell> m_cellCache; // 0x150
		private const string CACHED_CELL_GAME_OBJECT_NAME = "Cached"; // Metadata: 0x01FBC6B5
		[NonSerialized]
		public UnityEvent onBeginDrag; // 0x158
		[NonSerialized]
		public UnityEvent<PointerEventData> onDrag; // 0x160
		[NonSerialized]
		public UnityEvent onEndDrag; // 0x168
		[SerializeField]
		[Space]
		private GameObject _moveTipsLeftOrTop; // 0x170
		[SerializeField]
		private GameObject _moveTipsRightOrBottom; // 0x178
		private float m_moveTipsIgnoredRange; // 0x180
		[SerializeField]
		private bool _useViewEffect; // 0x184
		[SerializeField]
		private bool _symmetricViewEffect; // 0x185
		[SerializeField]
		private bool _needDummyParent; // 0x186
		[SerializeField]
		[Tooltip("\u8868\u73B0\u7528\u7684\u52A8\u753B\u66F2\u7EBF\uFF0C\u53EF\u7528\u4E8E\u5B9E\u73B0\u8BF8\u5982 \'\u5F27\u5F62\u6ED1\u52A8\' \u7B49\u6548\u679C\uFF0C\u5177\u4F53\u914D\u7F6E\u65B9\u6CD5\u8BF7\u54A8\u8BE2\u5BF9\u5E94\u7A0B\u5E8F")]
		private AnimationCurve _viewEffectAnimation; // 0x188
		[SerializeField]
		private Vector2 _effectAnchorPoint; // 0x190
		[SerializeField]
		private bool _useDefaultScaleEffect; // 0x198
		[SerializeField]
		private AnimationCurve _scaleEffectAnimation; // 0x1A0
		[SerializeField]
		private bool _useDefaultArcEffect; // 0x1A8
		[SerializeField]
		private AnimationCurve _arcEffectAnimation; // 0x1B0
		[NonSerialized]
		public UnityEvent<GameObject, int, float> onChangeView; // 0x1B8
		[SerializeField]
		protected float _tweenDuration; // 0x1C0
		[SerializeField]
		protected Ease _tweenEase; // 0x1C4
		[SerializeField]
		protected float _changeStepRatio; // 0x1C8
		protected DG.Tweening.Tween m_adjustTween; // 0x1D0
		protected float m_totalLength; // 0x1D8
		protected float m_cellLength; // 0x1DC
		protected Vector2 m_centerPos; // 0x1E0
		public bool enableAutoScroll; // 0x1E8
		[SerializeField]
		private float _startAutoScrollTime; // 0x1EC
		[SerializeField]
		[Tooltip("\u5355\u4F4D\uFF1Acell/s")]
		private float _autoScrollSpeed; // 0x1F0
		public UIArea autoScrollUpArea; // 0x1F8
		public UIArea autoScrollDownArea; // 0x200
		private float m_curAutoScrollSpd; // 0x208
		private int m_autoScrollTimerKey; // 0x20C
		[SerializeField]
		private bool _enableGraduallyShow; // 0x210
		[SerializeField]
		private float _graduallyShowTime; // 0x214
		[SerializeField]
		private float _graduallyShowDelayTime; // 0x218
		protected bool m_inGraduallyShow; // 0x21C
		private float m_graduallyShowedMaxIndex; // 0x220
		protected float m_curGraduallyCanShowMaxIndex; // 0x224
		private bool m_needInformAnimationInEnd; // 0x228
		private const float GRADUALLY_SHOW_UPDATE_MAX_INTERVAL = 0.033333335f; // Metadata: 0x01FBC6BC
		public static int s_maxGraduallyShowAddCountPerFrame; // 0x08
		[SerializeField]
		private bool _enableSelectedNavigation; // 0x229
		[SerializeField]
		private bool _noNavigationKeyHint; // 0x22A
		[SerializeField]
		private bool _enableNavigationLoop; // 0x22B
		[SerializeField]
		private bool _customNavigationActionId; // 0x22C
		[SerializeField]
		private string _customNavigationPreviousActionId; // 0x230
		[SerializeField]
		private string _customNavigationNextActionId; // 0x238
		[NonSerialized]
		public UnityEvent<GameObject, int> onSelectedCell; // 0x240
		[NonSerialized]
		public UnityEvent<GameObject, int, bool> onCellSelectedChanged; // 0x248
		[NonSerialized]
		public Func<int> getCurSelectedIndex; // 0x250
		private int m_curSelectedIndex; // 0x258
		private int m_bindingGroupId; // 0x25C
		private int m_naviBindingGroupId; // 0x260
		[SerializeField]
		[Tooltip("\u4E00\u884C\u7684\u6700\u540E\u4E00\u4E2A\u5143\u7D20\u662F\u5426\u53EF\u4EE5\u5FAA\u73AF\u5230\u4E0B\u4E00\u884C\u7684\u7B2C\u4E00\u4E2A\u5143\u7D20")]
		protected bool _enableWrapNavigation; // 0x264
		[SerializeField]
		[Tooltip("\u6700\u540E\u4E00\u4E2A\u5143\u7D20\u662F\u5426\u53EF\u4EE5\u5FAA\u73AF\u5230\u7B2C\u4E00\u4E2A\u5143\u7D20")]
		protected bool _enableCircleWrapNavigation; // 0x265
		[FormerlySerializedAs("_clearNaviGroupOnUpdate")]
		[SerializeField]
		private bool _clearNaviGroupOnUpdateCount; // 0x266
		private List<Selectable> m_wrapNaviSelectables; // 0x268
		private LuaPanel m_panel; // 0x270
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55740-0x0000000183D55750 
		public Vector2 space { get => default; } // 0x0000000183D588C0-0x0000000183D588E0 
		public bool autoLayoutWhenFew { get => default; } // 0x0000000183D58400-0x0000000183D58410 
		public bool isHorizontal { get => default; } // 0x00000001828C2600-0x00000001828C2610 
		public bool isVertical { get => default; } // 0x00000001828C30B0-0x00000001828C30C0 
		public int count { get; protected set; } // 0x0000000183D6C5F0-0x0000000183D6C600 0x0000000183D6C600-0x0000000183D6C610
		public float containerSizeWithoutAutoLayout { get; private set; } // 0x0000000183D56ED0-0x0000000183D56EE0 0x0000000183D56F50-0x0000000183D56F60
		protected bool isMultiPage { get => default; } // 0x00000001828C29B0-0x00000001828C29C0 
		public int maxShowingCellCount { get => default; } // 0x0000000183D5D640-0x0000000183D5D650 
		public int countPerLine { get => default; } // 0x0000000183D5CB40-0x0000000183D5CB50 
		public float cellWidth { get => default; } // 0x0000000183D583D0-0x0000000183D583E0 
		public float cellHeight { get => default; } // 0x0000000183D578F0-0x0000000183D57900 
		public virtual float currentStep { get => default; set {} } // 0x00000001828C2520-0x00000001828C2600 0x0000000189AE4098-0x0000000189AE40D4
		private MoveTipsType moveTips { get => default; } // 0x00000001828C2CC0-0x00000001828C2DD0 
		public int curSelectedIndex { get => default; protected set {} } // 0x0000000189AE3F60-0x0000000189AE3FCC 0x0000000189AE3FF0-0x0000000189AE4098
		public GameObject curSelectedObj { get => default; } // 0x0000000189AE3FCC-0x0000000189AE3FF0 
		public bool enableSelectedNavigation { get => default; } // 0x0000000183D76140-0x0000000183D76150 
		public int naviBindingGroupId { get => default; } // 0x0000000183D5ADD0-0x0000000183D5ADE0 
		public LuaPanel panel { get => default; } // 0x0000000183080C00-0x0000000183080CB0 
	
		// Nested types
		protected enum AutoLayoutWhenFewType // TypeDefIndex: 49340
		{
			Center = 0,
			LeftOrTop = 1,
			RightOrBottom = 2
		}
	
		public class Cell // TypeDefIndex: 49341
		{
			// Fields
			public GameObject gameObject; // 0x10
			public RectTransform rectTransform; // 0x18
			public UIAnimationWrapper animationWrapper; // 0x20
			public IUIFoldoutComp UIFoldoutComp; // 0x28
			public bool canCache; // 0x30
			public GameObject realGameObject; // 0x38
	
			// Constructors
			public Cell() {} // 0x0000000183D56870-0x0000000183D56880
		}
	
		private enum MoveTipsType // TypeDefIndex: 49342
		{
			None = 0,
			Higher = 1,
			Lower = 2,
			Both = 3
		}
	
		[Serializable]
		public struct Padding // TypeDefIndex: 49343
		{
			// Fields
			public float top; // 0x00
			public float left; // 0x04
			public float right; // 0x08
			public float bottom; // 0x0C
		}
	
		public enum ScrollAlignType // TypeDefIndex: 49344
		{
			Center = 0,
			Top = 1,
			Bottom = 2
		}
	
		public interface IScrollListNaviWrapper // TypeDefIndex: 49345
		{
			// Methods
			bool TryWrapNavigate(NaviDirection dir);
		}
	
		// Constructors
		public UIScrollList() {} // 0x0000000182847980-0x0000000182847EA0
		static UIScrollList() {} // 0x0000000183CBC740-0x0000000183CBC7F0
	
		// Methods
		protected override void OnAwake() {} // 0x0000000183B33DB0-0x0000000183B33DF0
		public override void Tick(float deltaTime) {} // 0x000000018307F5E0-0x000000018307F640
		public override void LateTick(float deltaTime) {} // 0x00000001830FE560-0x00000001830FE5B0
		protected override void OnEnable() {} // 0x000000018307F540-0x000000018307F5E0
		protected override void OnDisable() {} // 0x00000001830807B0-0x00000001830808E0
		public void TryRecalculateSize() {} // 0x00000001830FE5B0-0x00000001830FE690
		private void _InGameAwake() {} // 0x0000000182D9D090-0x0000000182D9D220
		private void _EditorAwake() {} // 0x0000000189AE3448-0x0000000189AE3968
		protected virtual void Init(bool isPreview = false /* Metadata: 0x01FBC69A */) {} // 0x0000000182D9B5B0-0x0000000182D9B7C0
		protected virtual void InitConfig() {} // 0x00000001838014A0-0x00000001838015A0
		protected virtual void InitBasicInfo() {} // 0x0000000182D9AC60-0x0000000182D9ACA0
		protected void SyncViewSize() {} // 0x0000000182D9ACA0-0x0000000182D9AF40
		protected virtual void CalcSomeCountNum() {} // 0x00000001836D16A0-0x00000001836D1720
		private int _GetLineCount(bool calcVertical) => default; // 0x00000001836D1720-0x00000001836D17D0
		protected virtual void OnScroll(Vector2 v) {} // 0x00000001828C1F00-0x00000001828C1F70
		public virtual void SetTop(bool needUpdate = true /* Metadata: 0x01FBC69B */) {} // 0x0000000189AE3138-0x0000000189AE31F8
		[IDTag(1)]
		public virtual void UpdateCount(int newCount, bool setTop, bool forceRecalculate = false /* Metadata: 0x01FBC69C */, bool onlyUpdateNewCellContent = false /* Metadata: 0x01FBC69D */, bool skipGraduallyShow = false /* Metadata: 0x01FBC69E */) {} // 0x0000000182D9AB80-0x0000000182D9AC20
		[IDTag(0)]
		public virtual void UpdateCount(int newCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x01FBC69F */, bool onlyUpdateNewCellContent = false /* Metadata: 0x01FBC6A0 */, bool skipGraduallyShow = false /* Metadata: 0x01FBC6A1 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x01FBC6A2 */) {} // 0x0000000182D9AF40-0x0000000182D9B1A0
		[IDTag(2)]
		public virtual void UpdateCount(int newCount) {} // 0x0000000182D99C60-0x0000000182D99CC0
		[IDTag(1)]
		public void UpdateShowingCells(Action<int, GameObject> updateFunc) {} // 0x00000001838C0380-0x00000001838C0500
		protected virtual float GetLeftLength(bool checkVertical, int checkCount = -1 /* Metadata: 0x01FBC6A3 */) => default; // 0x0000000182D9B4F0-0x0000000182D9B5B0
		private void _SetRealPadding(bool isVerticalPadding, float firstAddedLength, float secondAddedLength) {} // 0x0000000182D9B380-0x0000000182D9B410
		protected void UpdateContainerSize() {} // 0x0000000182D9B1A0-0x0000000182D9B380
		protected virtual float GetContainerSize(bool ignoreAutoLayout = false /* Metadata: 0x01FBC6A4 */) => default; // 0x0000000182D9B410-0x0000000182D9B4F0
		protected void SetContainerSize(float size) {} // 0x0000000182D9B7C0-0x0000000182D9B8A0
		protected void ClearShowingCells() {} // 0x0000000182D999C0-0x0000000182D99B50
		[IDTag(0)]
		protected virtual void UpdateShowingCells(bool forceUpdateContent, bool forceClearShowingCells = false /* Metadata: 0x01FBC6A5 */, bool ignoreListActive = false /* Metadata: 0x01FBC6A6 */) {} // 0x00000001828C30C0-0x00000001828C53A0
		protected void UpdateCell(int index, bool forceUpdateContent, bool ignoreListActive) {} // 0x00000001828C29C0-0x00000001828C2CC0
		public virtual Vector2Int GetShowRange(float bufferSize = 0f /* Metadata: 0x01FBC6A7 */, bool ignoreGraduallyShow = false /* Metadata: 0x01FBC6AB */) => default; // 0x00000001828C2EC0-0x00000001828C30B0
		public virtual Vector2Int GetRangeInView() => default; // 0x0000000189AE1424-0x0000000189AE18D8
		protected virtual Vector2Int GetNotCacheRange() => default; // 0x00000001828C2050-0x00000001828C2090
		protected virtual void MoveCellTo(Cell cell, int index) {} // 0x00000001828C2DD0-0x00000001828C2EC0
		public void SetCellCanCache(int index, bool canCache) {} // 0x0000000189AE27D0-0x0000000189AE28FC
		protected virtual void OnUpdateCell(Cell cell, int index) {} // 0x000000018382FBE0-0x000000018382FC80
		[IDTag(0)]
		protected Cell GetCell() => default; // 0x0000000182BDD480-0x0000000182BDD880
		protected void CacheShowingCell(int index) {} // 0x0000000189AE0F74-0x0000000189AE1044
		protected void CacheCell(Cell cell) {} // 0x0000000189AE0EAC-0x0000000189AE0F74
		public virtual void SetStepTo(float step) {} // 0x0000000189AE2F0C-0x0000000189AE3138
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189AE2370-0x0000000189AE23D8
		public virtual void OnDrag(PointerEventData eventData) {} // 0x0000000189AE23D8-0x0000000189AE2464
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x0000000189AE2464-0x0000000189AE24CC
		private void _UpdateMoveTips() {} // 0x00000001828C1F70-0x00000001828C2050
		public void UpdateViewEffect() {} // 0x00000001828C18D0-0x00000001828C1F00
		public GameObject Get(int index) => default; // 0x0000000189AE1A14-0x0000000189AE1AD8
		[IDTag(1)]
		protected Cell GetCell(int index) => default; // 0x0000000189AE1044-0x0000000189AE10FC
		protected int GetRealIndex(int index) => default; // 0x0000000182D9AC20-0x0000000182D9AC60
		protected override void OnRelease() {} // 0x0000000183D07E00-0x0000000183D07EC0
		public virtual void ClearComponent() {} // 0x00000001839C0540-0x00000001839C0690
		public void SetPaddingBottom(float value) {} // 0x0000000189AE28FC-0x0000000189AE2974
		public void SetPaddingTop(float value) {} // 0x0000000189AE2A64-0x0000000189AE2ADC
		public void SetPaddingRight(float value) {} // 0x0000000189AE29EC-0x0000000189AE2A64
		public void SetPaddingLeft(float value) {} // 0x0000000189AE2974-0x0000000189AE29EC
		public void SetPadding(Rect value) {} // 0x0000000189AE2ADC-0x0000000189AE2BD0
		public Padding GetPadding() => default; // 0x0000000183A1A490-0x0000000183A1A4D0
		public void GetShowingCellsIndexRange(out int firstIndex, out int lastIndex) {
			firstIndex = default;
			lastIndex = default;
		} // 0x0000000189AE18D8-0x0000000189AE1A14
		public void SetSpace(Vector2 newSpace) {} // 0x0000000189AE2E54-0x0000000189AE2F0C
		public virtual void ScrollToIndex(int index, bool fastMode = false /* Metadata: 0x01FBC6AC */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x01FBC6AD */, bool graduallyShowInFastMode = false /* Metadata: 0x01FBC6AE */) {} // 0x0000000189AE26DC-0x0000000189AE27D0
		protected virtual void ScrollTo(int index, bool fastMode = false /* Metadata: 0x01FBC6AF */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x01FBC6B0 */) {} // 0x0000000183080420-0x0000000183080490
		private void _ScrollToPos(float targetPos, bool fastMode) {} // 0x0000000183080640-0x00000001830807B0
		protected void TryClearAdjustTween() {} // 0x00000001830808E0-0x0000000183080920
		public virtual float GetCenterIndex() => default; // 0x00000001828C17A0-0x00000001828C18D0
		protected virtual float GetTargetPosByIndex(int index, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x01FBC6B1 */) => default; // 0x0000000183080490-0x0000000183080640
		private void _InitAutoScroll() {} // 0x0000000182D9B8A0-0x0000000182D9B9D0
		private void _OnEnterAutoScrollUp(PointerEventData eventData) {} // 0x0000000189AE3C88-0x0000000189AE3DB0
		private void _OnExitAutoScrollUp(PointerEventData eventData) {} // 0x0000000189AE3E54-0x0000000189AE3EF8
		private void _OnEnterAutoScrollDown(PointerEventData eventData) {} // 0x0000000189AE3B60-0x0000000189AE3C88
		private void _OnExitAutoScrollDown(PointerEventData eventData) {} // 0x0000000189AE3DB0-0x0000000189AE3E54
		private void _SetAutoScrollSpd(float spd) {} // 0x0000000189AE3EF8-0x0000000189AE3F60
		private void _UpdateAutoScroll(float deltaTime) {} // 0x000000018307F640-0x000000018307F6A0
		protected void RestartGraduallyShow() {} // 0x0000000182D99CC0-0x0000000182D99D40
		private void _StartGraduallyShow() {} // 0x0000000183080AF0-0x0000000183080C00
		private void _UpdateGraduallyShow(float deltaTime) {} // 0x000000018307F6A0-0x000000018307F820
		public void SkipGraduallyShow() {} // 0x0000000189AE31F8-0x0000000189AE3254
		public void StopGraduallyShow() {} // 0x0000000183080920-0x0000000183080AF0
		private void _InitNavigation() {} // 0x00000001839D1210-0x00000001839D13A0
		public void NavigateSelected(NaviDirection dir) {} // 0x0000000189AE22D8-0x0000000189AE2370
		public int GetNaviOffset(NaviDirection dir) => default; // 0x0000000189AE12D4-0x0000000189AE1424
		public int GetNaviNewIndex(int oldIndex, NaviDirection dir) => default; // 0x0000000189AE1230-0x0000000189AE12D4
		public void SetSelectedIndex(int index, bool needNotify = true /* Metadata: 0x01FBC6B2 */, bool forceUpdate = false /* Metadata: 0x01FBC6B3 */, bool needScroll = false /* Metadata: 0x01FBC6B4 */) {} // 0x0000000189AE2BD0-0x0000000189AE2E54
		public void ListWrapNavigate(NaviDirection dir) {} // 0x0000000189AE1AD8-0x0000000189AE22D8
		private void _InitControllerNavi() {} // 0x0000000182D9B9D0-0x0000000182D9BAA0
		private void _ClearRelatedNaviGroup() {} // 0x0000000189AE3390-0x0000000189AE3448
		public int GetMousePosIndex(NaviDirection dir) => default; // 0x0000000189AE117C-0x0000000189AE1230
		public int ScreenPos2Index(Vector2 targetScreenPos, NaviDirection dir) => default; // 0x0000000189AE24CC-0x0000000189AE26DC
		private void _GetScreenPosLineColumnInfo(Vector2 targetScreenPos, out int line, out int column) {
			line = default;
			column = default;
		} // 0x0000000189AE3968-0x0000000189AE3B60
		public int GetIndexOf(int column, int line) => default; // 0x0000000189AE10FC-0x0000000189AE117C
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	public enum AutoScrollStrategy // TypeDefIndex: 49347
	{
		None = 0,
		AlignNearbyBound = 1,
		AlignCenter = 2
	}

	[AddComponentMenu("UI/UI Scroll Rect", 37)]
	public class UIScrollRect : ScrollRect, IUIClearable // TypeDefIndex: 49350
	{
		// Fields
		private TweenerCore<Vector2, Vector2, VectorOptions> m_scrollTween; // 0x150
		public float smoothScrollTweenSpd; // 0x158
		public Ease smoothScrollTweenEase; // 0x15C
		private bool m_lastUpdateIsDragging; // 0x160
		private LuaPanel m_panel; // 0x168
		[SerializeField]
		protected float _stickScrollSpeed; // 0x170
		[SerializeField]
		protected float _stickScrollTolerance; // 0x174
		[SerializeField]
		protected UISelectableNaviGroup _naviGroup; // 0x178
		[SerializeField]
		protected bool _enableWrapNavigation; // 0x180
		[SerializeField]
		protected InputBindingGroupMonoTarget _scrollBindingGroup; // 0x188
		[NonSerialized]
		public bool controllerScrollEnabled; // 0x190
		private bool m_controllerInited; // 0x191
		private bool m_navigationWrapped; // 0x192
		[SerializeField]
		protected AutoScrollStrategy _autoScrollStrategy; // 0x194
		[SerializeField]
		protected float _alignBoundPaddingX; // 0x198
		[SerializeField]
		protected float _alignBoundPaddingY; // 0x19C
		[SerializeField]
		[Space]
		private GameObject _moveTipsLeftOrTop; // 0x1A0
		[SerializeField]
		private GameObject _moveTipsRightOrBottom; // 0x1A8
		private Camera m_fallbackUICamera; // 0x1B0
		[Header("Over Scroll Effect")]
		[SerializeField]
		private bool _enableOverScrollEffect; // 0x1B8
		[SerializeField]
		[Tooltip("\u5217\u8868\u957F\u5EA6\u7684\u767E\u5206\u6BD4")]
		private float _overScrollTriggerValue; // 0x1BC
		[SerializeField]
		private GameObject _overScrollEffectPrevNode; // 0x1C0
		[SerializeField]
		private GameObject _overScrollEffectNextNode; // 0x1C8
		[NonSerialized]
		public DisposedUnityEvent<bool> onOverScrollEffect; // 0x1D0
	
		// Properties
		public bool inScrollTween { get => default; } // 0x0000000189AE4B28-0x0000000189AE4B9C 
		public Vector2 contentStartPosition { get => default; set {} } // 0x0000000183D6B170-0x0000000183D6B190 0x0000000183D50F10-0x0000000183D50F20
		public bool dragging { get => default; } // 0x0000000183D58140-0x0000000183D58150 
		public bool controllerStickScrollEnabled { get => default; } // 0x0000000189AE4A7C-0x0000000189AE4B28 
		public LuaPanel panel { get => default; } // 0x0000000189AE4CDC-0x0000000189AE4DA0 
		public UISelectableNaviGroup naviGroup { get => default; } // 0x0000000183D56A70-0x0000000183D56A80 
		private MoveTipsType moveTips { get => default; } // 0x0000000189AE4B9C-0x0000000189AE4CDC 
	
		// Nested types
		private enum MoveTipsType // TypeDefIndex: 49348
		{
			None = 0,
			Higher = 1,
			Lower = 2,
			Both = 3
		}
	
		// Constructors
		public UIScrollRect() {} // 0x000000018284A3C0-0x000000018284A4A0
	
		// Methods
		protected override void Awake() {} // 0x0000000182D9D3B0-0x0000000182D9D470
		protected override void OnEnable() {} // 0x00000001834CF9E0-0x00000001834CFA20
		private void Update() {} // 0x0000000183005DA0-0x0000000183005DF0
		public void ScrollTo(Vector2 position, bool noTween = false /* Metadata: 0x01FBC6CD */) {} // 0x00000001834E4FB0-0x00000001834E5020
		public bool IsCellViewed(RectTransform cell) => default; // 0x0000000189AE40D4-0x0000000189AE41C0
		protected override void OnDestroy() {} // 0x0000000183C8B720-0x0000000183C8B780
		protected override void _CustomSetPosOnScroll(Vector2 position) {} // 0x00000001828C0DB0-0x00000001828C1330
		protected override void UpdateScrollEnableNode() {} // 0x00000001830C0F80-0x00000001830C1010
		public override void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189AE41C0-0x0000000189AE4250
		public override void OnDrag(PointerEventData eventData) {} // 0x0000000189AE4250-0x0000000189AE42E0
		public override void OnEndDrag(PointerEventData eventData) {} // 0x0000000189AE42E0-0x0000000189AE4388
		public void ClearComponent() {} // 0x000000018397B840-0x000000018397B980
		protected override void LateUpdate() {} // 0x000000018284F320-0x000000018284F410
		private void _TickRefreshControllerStickScroll() {} // 0x0000000183005DF0-0x0000000183005EB0
		public void ScrollToNaviTarget(Selectable target) {} // 0x00000001834E51B0-0x00000001834E5280
		public void RectWrapNavigate(NaviDirection dir) {} // 0x0000000189AE4388-0x0000000189AE4624
		private void _InitController() {} // 0x00000001834CFA20-0x00000001834CFB80
		public void WrapNavigation(UnityAction<NaviDirection> wrapper) {} // 0x0000000182D99E10-0x0000000182D99F90
		public void AutoScrollToRectTransform(RectTransform target, bool noTween = false /* Metadata: 0x01FBC6CE */) {} // 0x00000001834E5280-0x00000001834E5530
		private void _UpdateMoveTips() {} // 0x0000000183005EB0-0x0000000183006100
		private Camera _GetUICamera() => default; // 0x0000000189AE4838-0x0000000189AE4A7C
		private void _CheckOverScrollEffect(Vector2 value) {} // 0x000000018358C870-0x000000018358C8D0
		private void _CheckOverScrollOnEndDrag(Vector2 value) {} // 0x0000000189AE465C-0x0000000189AE4838
		public void __iFixBaseProxy_Awake() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000189AE463C-0x0000000189AE4644
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy__CustomSetPosOnScroll(Vector2 P0) {} // 0x0000000189AE4654-0x0000000189AE465C
		public void __iFixBaseProxy_UpdateScrollEnableNode() {} // 0x0000000189AE464C-0x0000000189AE4654
		public void __iFixBaseProxy_OnBeginDrag(PointerEventData P0) {} // 0x0000000189AE462C-0x0000000189AE4634
		public void __iFixBaseProxy_OnDrag(PointerEventData P0) {} // 0x0000000189AE4634-0x0000000189AE463C
		public void __iFixBaseProxy_OnEndDrag(PointerEventData P0) {} // 0x0000000189AE4644-0x0000000189AE464C
		public void __iFixBaseProxy_LateUpdate() {} // 0x0000000189AE4624-0x0000000189AE462C
	}

	public class UIScrollRectEdgeRedDot : TickableUIMono, IUIClearable // TypeDefIndex: 49354
	{
		// Fields
		private UIScrollRect m_uiScrollRect; // 0x68
		private RectTransform m_uiScrollRectTransform; // 0x70
		private UIScrollList m_uiScrollList; // 0x78
		private RectMask2D m_rectMask2D; // 0x80
		private Dictionary<GameObject, RedDotInfo> m_redDotInfoDict; // 0x88
		private Dictionary<int, ERedDotState> m_redDotStateDict; // 0x90
		private Vector2Int m_scrollListShowRange; // 0x98
		public Func<int, int> getRedDotStateAt; // 0xA0
		private ERedDotState m_upRedDotState; // 0xA8
		private ERedDotState m_downRedDotState; // 0xAC
		[Header("\u5F15\u7528\u8BBE\u7F6E\u3002\u8BF7\u4E0D\u8981\u52A8\u4E0B\u9762\u7684\u5185\u5BB9\uFF01\uFF01\uFF01")]
		[SerializeField]
		[Tooltip("\u4E0A\u65B9\u7EA2\u70B9\u7684 Normal GameObject\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private GameObject _upNormal; // 0xB0
		[SerializeField]
		[Tooltip("\u4E0A\u65B9\u7EA2\u70B9\u7684 New GameObject\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private GameObject _upNew; // 0xB8
		[SerializeField]
		[Tooltip("\u4E0B\u65B9\u7EA2\u70B9\u7684 Normal GameObject\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private GameObject _downNormal; // 0xC0
		[SerializeField]
		[Tooltip("\u4E0B\u65B9\u7EA2\u70B9\u7684 New GameObject\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private GameObject _downNew; // 0xC8
		[SerializeField]
		[Tooltip("\u4E0A\u65B9\u7EA2\u70B9\u7684\u7236\u7269\u4F53\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private RectTransform _upParent; // 0xD0
		[SerializeField]
		[Tooltip("\u4E0B\u65B9\u7EA2\u70B9\u7684\u7236\u7269\u4F53\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private RectTransform _downParent; // 0xD8
		[Header("\u5224\u5B9A\u7EA2\u70B9\u662F\u5426\u51FA\u6846\u7684\u504F\u79FB\u91CF")]
		[SerializeField]
		private float _upEdgeOffset; // 0xE0
		[SerializeField]
		private float _downEdgeOffset; // 0xE4
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Nested types
		public enum ERedDotState // TypeDefIndex: 49351
		{
			DISABLED = 0,
			NEW = 1,
			NORMAL = 2
		}
	
		public enum ERedDotDir // TypeDefIndex: 49352
		{
			UP = 0,
			RIGHT = 1,
			DOWN = 2,
			LEFT = 3
		}
	
		public class RedDotInfo // TypeDefIndex: 49353
		{
			// Fields
			public readonly GameObject redDotRoot; // 0x10
			public readonly GameObject redDotNormal; // 0x18
			public readonly GameObject redDotNew; // 0x20
	
			// Properties
			public ERedDotState state { get => default; } // 0x0000000189AE6334-0x0000000189AE6424 
			public Vector2 normalPos { get => default; } // 0x0000000189AE615C-0x0000000189AE6238 
			public Vector2 newPos { get => default; } // 0x0000000189AE5F84-0x0000000189AE6060 
			public Rect normalRect { get => default; } // 0x0000000189AE6238-0x0000000189AE6334 
			public Rect newRect { get => default; } // 0x0000000189AE6060-0x0000000189AE615C 
	
			// Constructors
			public RedDotInfo() {} // Dummy constructor
			public RedDotInfo(GameObject redDotRoot, GameObject redDotNormal, GameObject redDotNew) {} // 0x0000000189AE5F4C-0x0000000189AE5F84
		}
	
		// Constructors
		public UIScrollRectEdgeRedDot() {} // 0x0000000189AE83C0-0x0000000189AE83E4
	
		// Methods
		protected override void OnAwake() {} // 0x0000000189AE6A70-0x0000000189AE6ACC
		protected override void OnEnable() {} // 0x0000000189AE6ACC-0x0000000189AE6C98
		protected override void OnRelease() {} // 0x0000000189AE6C98-0x0000000189AE6DC4
		public override void Tick(float deltaTime) {} // 0x0000000189AE7548-0x0000000189AE76B4
		public void ResetReferences() {} // 0x0000000189AE738C-0x0000000189AE7548
		public void ResetRedDotPosition() {} // 0x0000000189AE7108-0x0000000189AE738C
		private void _UpdateCacheDictForRangeChange(Vector2Int newRange) {} // 0x0000000189AE8030-0x0000000189AE8220
		private void _OnScrollListUpdateCount(int newCount) {} // 0x0000000189AE7F98-0x0000000189AE8030
		public void RegisterRedDot(GameObject redDotRoot, GameObject redDotNormal, GameObject redDotNew) {} // 0x0000000189AE6F50-0x0000000189AE7108
		public void UnregisterRedDot(GameObject redDotRoot) {} // 0x0000000189AE76B4-0x0000000189AE7774
		public void RegisterRedDotStatesForScrollList() {} // 0x0000000189AE6DC4-0x0000000189AE6F50
		public void UpdateRedDotStateInDir() {} // 0x0000000189AE7774-0x0000000189AE7840
		private void _CalculateRedDotStateInDir(out ERedDotState upState, out ERedDotState downState) {
			upState = default;
			downState = default;
		} // 0x0000000189AE7840-0x0000000189AE7F98
		private void _UpdateRedDotGameObjects(GameObject normal, GameObject newer, ERedDotState state) {} // 0x0000000189AE8220-0x0000000189AE83C0
		public bool IsRedDotInDir(ERedDotState state, ERedDotDir dir, RedDotInfo redDotInfo) => default; // 0x0000000189AE684C-0x0000000189AE6A70
		public void ClearComponent() {} // 0x0000000189AE67F0-0x0000000189AE684C
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	[RequireComponent(typeof(UIText))]
	public class UIScrollText : TickableUIMono // TypeDefIndex: 49362
	{
		// Fields
		[SerializeField]
		private float _speed; // 0x68
		[SerializeField]
		private float _stayTime; // 0x6C
		[SerializeField]
		private float _fadeTime; // 0x70
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0x78
		[SerializeField]
		private ScrollMode _scrollMode; // 0x80
		[SerializeField]
		private bool _disableClipping; // 0x84
		private bool m_isInited; // 0x85
		private UIText m_tmp; // 0x88
		private RectTransform m_rect; // 0x90
		private RectTransform m_parentRect; // 0x98
		private IScrollHandler m_scrollHandler; // 0xA0
		private IAlphaHandler m_alphaHandler; // 0xA8
		private ScrollState m_state; // 0xB0
		private float m_scrollOffset; // 0xB4
		private float m_currStateTime; // 0xB8
		private bool m_needScroll; // 0xBC
		private float m_textDiff; // 0xC0
		private TextAlignmentOptions m_originalAlignment; // 0xC4
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
	
		// Nested types
		private enum ScrollMode // TypeDefIndex: 49355
		{
			Mesh = 0,
			AnchoredPosition = 1
		}
	
		private enum ScrollState // TypeDefIndex: 49356
		{
			Scrolling = 0,
			Idle = 1,
			FadingOut = 2,
			FadingIn = 3
		}
	
		private interface IAlphaHandler // TypeDefIndex: 49357
		{
			// Methods
			void HandleAlpha(float alpha);
		}
	
		private class CanvasGroupHandler : IAlphaHandler // TypeDefIndex: 49358
		{
			// Fields
			private CanvasGroup m_canvasGroup; // 0x10
	
			// Constructors
			public CanvasGroupHandler() {} // Dummy constructor
			public CanvasGroupHandler(CanvasGroup canvasGroup) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public void HandleAlpha(float alpha) {} // 0x0000000189AE50D8-0x0000000189AE5144
		}
	
		private interface IScrollHandler // TypeDefIndex: 49359
		{
			// Methods
			void ApplyScroll(float scrollOffset);
			void ResetScroll();
			void UpdateScrollStatus(bool isScroll);
		}
	
		private class PositionScrollHandler : Beyond.UI.UIScrollText.IScrollHandler // TypeDefIndex: 49360
		{
			// Fields
			private UIScrollText m_closure; // 0x10
	
			// Constructors
			public PositionScrollHandler() {} // Dummy constructor
			public PositionScrollHandler(UIScrollText scrollText) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public void ApplyScroll(float scrollOffset) {} // 0x0000000189AE5D48-0x0000000189AE5DF4
			public void ResetScroll() {} // 0x0000000189AE5DF4-0x0000000189AE5E68
			public void UpdateScrollStatus(bool isScroll) {} // 0x0000000189AE5E68-0x0000000189AE5F4C
		}
	
		private class MeshScrollHandler : Beyond.UI.UIScrollText.IScrollHandler // TypeDefIndex: 49361
		{
			// Fields
			private UIScrollText m_closure; // 0x10
	
			// Constructors
			public MeshScrollHandler() {} // Dummy constructor
			public MeshScrollHandler(UIScrollText uiScrollText) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public void ApplyScroll(float scrollOffset) {} // 0x0000000189AE5144-0x0000000189AE51A8
			public void ResetScroll() {} // 0x0000000189AE51A8-0x0000000189AE5200
			public void UpdateScrollStatus(bool isScroll) {} // 0x0000000189AE5200-0x0000000189AE52BC
			private void _ApplyScroll(float scrollOffset) {} // 0x0000000189AE52BC-0x0000000189AE5538
			private void _UpdateMeshClipping(TMP_TextInfo textInfo) {} // 0x0000000189AE5538-0x0000000189AE5D48
		}
	
		// Constructors
		public UIScrollText() {} // 0x0000000189AE8ED8-0x0000000189AE8F00
	
		// Methods
		private void _InitIfNot() {} // 0x0000000189AE88A0-0x0000000189AE8B3C
		public void ResetTextScroll() {} // 0x0000000189AE8628-0x0000000189AE8764
		private void _ResetTextScrollInternal(bool needScroll, float textDiff) {} // 0x0000000189AE8B3C-0x0000000189AE8BF4
		protected override void OnAwake() {} // 0x0000000189AE85CC-0x0000000189AE8628
		public override void LateTick(float deltaTime) {} // 0x0000000189AE83E4-0x0000000189AE85CC
		private void _UpdateScrollState(float deltaTime, float textDiff) {} // 0x0000000189AE8C58-0x0000000189AE8ED8
		private void _ResetTextScroll() {} // 0x0000000189AE8BF4-0x0000000189AE8C58
		private void _ApplyTextAlignment(bool isScroll) {} // 0x0000000189AE8764-0x0000000189AE8834
		private void _ApplyTextScroll(float scrollOffset) {} // 0x0000000189AE8834-0x0000000189AE88A0
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	public class UISelectableNaviGroup : SelectableNaviGroup, IUIClearable // TypeDefIndex: 49364
	{
		// Fields
		public List<InputBindingGroupMonoTarget> relatedInputBindingGroups; // 0xA0
		public Func<Selectable> getDefaultSelectableFunc; // 0xA8
		public Func<bool> canFocusFun; // 0xB0
		public string focusActionId; // 0xB8
		public string stopFocusActionId; // 0xC0
		[Space]
		[Tooltip("\u8BED\u6CD5\u7CD6\uFF1A\u9000\u51FA\u805A\u7126\u65F6\u9690\u85CFItemTips")]
		public bool hideItemTipsOnUnFocus; // 0xC8
		public bool useDefaultTargetOnFocus; // 0xC9
		[Space]
		public bool useFocusHighlight; // 0xCA
		public bool focusHighlightMask; // 0xCB
		public bool focusHighlightNormalFrame; // 0xCC
		public bool focusHighlightDarkFrame; // 0xCD
		public RectTransform focusOverrideHighlightRect; // 0xD0
		[NonSerialized]
		public int focusPanelSortingOrder; // 0xD8
		public UIActionKeyHint focusActionKeyHint; // 0xE0
		public UIActionKeyHint stopFocusActionKeyHint; // 0xE8
		public UnityEvent<bool> onIsFocusedChange; // 0xF0
		private LuaPanel m_luaPanel; // 0xF8
		private InputBindingGroupMonoTarget m_bindingMonoGroup; // 0x100
		private RectTransform m_rectTransform; // 0x108
		private Selectable m_lastFocusNaviTarget; // 0x110
		private string m_focusBindingText; // 0x118
		private int m_focusBindingId; // 0x120
		private int m_stopFocusBindingId; // 0x124
		private bool m_focusBindingCreated; // 0x128
		private bool m_isInFocusHighlight; // 0x129
		private const int INVALID_BINDING_ID = -1; // Metadata: 0x01FBC6E3
	
		// Properties
		public int FocusBindingId { get => default; } // 0x0000000183D5D890-0x0000000183D5D8A0 
		public int StopFocusBindingId { get => default; } // 0x0000000183D6DED0-0x0000000183D6DEE0 
		public Selectable lastFocusNaviTarget { get => default; } // 0x0000000183D56CF0-0x0000000183D56D00 
	
		// Nested types
		public struct FocusBlockMessageData // TypeDefIndex: 49363
		{
			// Fields
			public int panelId; // 0x00
			public bool isGroup; // 0x04
			public int id; // 0x08
			public RectTransform rectTransform; // 0x10
			public bool noHighlight; // 0x18
			public bool useNormalFrame; // 0x19
			public bool useDarkFrame; // 0x1A
			public int panelSortingOrder; // 0x1C
		}
	
		// Constructors
		public UISelectableNaviGroup() {} // 0x000000018283A400-0x000000018283A510
	
		// Methods
		private void Awake() {} // 0x0000000182A72B70-0x0000000182A72C50
		protected override void OnEnable() {} // 0x0000000182C6F970-0x0000000182C6F9C0
		protected override void OnDisable() {} // 0x0000000182C6D3E0-0x0000000182C6D420
		protected override void _OnIsTopLayerChanged() {} // 0x0000000182C6F040-0x0000000182C6F090
		protected override void _OnSelectableNaviGroupDisabled() {} // 0x00000001836B6330-0x00000001836B6370
		protected override void _BeforeSelectableNaviGroupDestroy() {} // 0x00000001836B6370-0x00000001836B63B0
		protected override void _OnSetLayerSelectedTarget(Selectable value) {} // 0x0000000189AE958C-0x0000000189AE95F4
		protected override void _OnRemoveFromLayerStack() {} // 0x0000000182C6FC40-0x0000000182C6FC90
		public void NaviToThisGroup(bool forceDefault = false /* Metadata: 0x01FBC6E0 */) {} // 0x00000001836BE780-0x00000001836BE8A0
		private void _RefreshRelatedBindingGroupsState() {} // 0x0000000182C6F800-0x0000000182C6F970
		private Selectable _FindDefaultSelectable() => default; // 0x00000001836BE8A0-0x00000001836BECB0
		protected override void OnDestroy() {} // 0x000000018304D710-0x000000018304D760
		public void ClearComponent() {} // 0x000000018304D850-0x000000018304D9A0
		public void TryChangeNaviPartnerOnUp(UISelectableNaviGroup partner, bool isAdd) {} // 0x0000000189AE91EC-0x0000000189AE926C
		public void TryChangeNaviPartnerOnDown(UISelectableNaviGroup partner, bool isAdd) {} // 0x0000000189AE906C-0x0000000189AE90EC
		public void TryChangeNaviPartnerOnLeft(UISelectableNaviGroup partner, bool isAdd) {} // 0x0000000189AE90EC-0x0000000189AE916C
		public void TryChangeNaviPartnerOnRight(UISelectableNaviGroup partner, bool isAdd) {} // 0x0000000189AE916C-0x0000000189AE91EC
		private void _TryChangeNaviPartner(List<SelectableNaviGroup> list, UISelectableNaviGroup partner, bool isAdd) {} // 0x0000000189AE95F4-0x0000000189AE96E4
		private void _InitFocusBinding() {} // 0x0000000182A72DD0-0x0000000182A730E0
		private void _RefreshFocusBindings() {} // 0x0000000182C6EDC0-0x0000000182C6EF00
		public void RefreshFocusBindings() {} // 0x0000000189AE8F64-0x0000000189AE8FB4
		private void _OnFocus(bool onlyStartHighlight) {} // 0x0000000189AE92A0-0x0000000189AE958C
		private void _OnStopFocus(bool onlyStopHighlight, bool ignoreTopLayerCheck) {} // 0x0000000182C6FFA0-0x0000000182C700D0
		private void _RefreshFocusActionKeyHint() {} // 0x0000000182C6FA70-0x0000000182C6FB50
		private void _RefreshStopFocusActionKeyHint() {} // 0x0000000182C6F9F0-0x0000000182C6FA70
		public void ManuallyFocus(bool onlyStartHighlight = false /* Metadata: 0x01FBC6E1 */) {} // 0x0000000189AE8F00-0x0000000189AE8F64
		public void ManuallyStopFocus(bool onlyStopHighlight = false /* Metadata: 0x01FBC6E2 */) {} // 0x00000001836B63B0-0x00000001836B6400
		public void SetFocusBindingText(string bindingText) {} // 0x0000000189AE8FB4-0x0000000189AE906C
		public void ClearLastFocusNaviTarget() {} // 0x0000000183D3B220-0x0000000183D3B260
		public void ManuallyRefreshRelatedBindingGroups() {} // 0x0000000183D00CB0-0x0000000183D00CF0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000189AE9274-0x0000000189AE927C
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000184272FC0-0x0000000184272FD0
		public void __iFixBaseProxy__OnIsTopLayerChanged() {} // 0x0000000189AE927C-0x0000000189AE9284
		public void __iFixBaseProxy__OnSelectableNaviGroupDisabled() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy__BeforeSelectableNaviGroupDestroy() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy__OnSetLayerSelectedTarget(Selectable P0) {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy__OnRemoveFromLayerStack() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000189AE926C-0x0000000189AE9274
	}

	[ExecuteInEditMode]
	public class UISemiCircleScrollList : TickableUIMono, IDragHandler, IUIClearable, IBeginDragHandler, IEndDragHandler // TypeDefIndex: 49366
	{
		// Fields
		[SerializeField]
		public RectTransform content; // 0x68
		[SerializeField]
		private float _innerRadius; // 0x70
		[SerializeField]
		private float _outerRadius; // 0x74
		[SerializeField]
		private float _padding; // 0x78
		[SerializeField]
		private int _cellCount; // 0x7C
		[SerializeField]
		private GameObject _cellPrefab; // 0x80
		[SerializeField]
		private float _startAngle; // 0x88
		[SerializeField]
		private bool _reverseDirection; // 0x8C
		private RectTransform m_rectTransform; // 0x90
		[NonSerialized]
		public float currentAngleOffset; // 0x98
		private float m_targetAngleOffset; // 0x9C
		[SerializeField]
		private float _hideAngel; // 0xA0
		[SerializeField]
		private float _duration; // 0xA4
		private List<GameObject> m_cells; // 0xA8
		private bool m_inEndDragAnim; // 0xB0
		private bool m_inDragging; // 0xB1
		[SerializeField]
		protected InputBindingGroupMonoTarget _scrollBindingGroup; // 0xB8
		[SerializeField]
		protected float _stickScrollTolerance; // 0xC0
		[SerializeField]
		protected float _stickScrollSpeed; // 0xC4
		private int m_lastClosestCellIndex; // 0xC8
		private int m_currentCellCount; // 0xCC
		public DisposedUnityEvent<GameObject, int> onCellShow; // 0xD0
		public DisposedUnityEvent<int> onClosestCellChanged; // 0xD8
		public DisposedUnityEvent onDrag; // 0xE0
		public DisposedUnityEvent onEndDrag; // 0xE8
		private Coroutine m_dampingCoroutine; // 0xF0
		[AudioString]
		[SerializeField]
		private string _audioHoldStart; // 0xF8
		[AudioString]
		[SerializeField]
		private string _audioHoldEnd; // 0x100
		[AudioString]
		[SerializeField]
		private string _audioAlignment; // 0x108
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		public bool controllerStickScrollEnabled { get => default; } // 0x0000000189AEACBC-0x0000000189AEAD5C 
	
		// Constructors
		public UISemiCircleScrollList() {} // 0x0000000189AEAB70-0x0000000189AEACBC
	
		// Methods
		protected override void OnAwake() {} // 0x0000000189AE9E6C-0x0000000189AE9F10
		protected override void OnDisable() {} // 0x0000000189AE9F94-0x0000000189AEA018
		public override void Tick(float deltaTime) {} // 0x0000000189AEA2D8-0x0000000189AEA344
		private void _TickRefreshControllerStickScroll() {} // 0x0000000189AEA974-0x0000000189AEAB70
		private void _InitializeCells() {} // 0x0000000189AEA80C-0x0000000189AEA974
		public void RefreshLayout(int newCellCount, int targetCellIndex) {} // 0x0000000189AEA238-0x0000000189AEA2D8
		public void UpdateLayout() {} // 0x0000000189AEA344-0x0000000189AEA77C
		public void OnDrag(PointerEventData eventData) {} // 0x0000000189AEA018-0x0000000189AEA150
		public void ClearComponent() {} // 0x0000000189AE9D58-0x0000000189AE9E6C
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189AE9F10-0x0000000189AE9F94
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000189AEA150-0x0000000189AEA238
		[IteratorStateMachine(typeof(__ApplyDamping_d__44))]
		private IEnumerator _ApplyDamping() => default; // 0x0000000189AEA77C-0x0000000189AEA80C
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	public class UISemiCircleScrollListPair : MonoBehaviour // TypeDefIndex: 49367
	{
		// Fields
		public UISemiCircleScrollList m_scrollListMaster; // 0x18
		public UISemiCircleScrollList[] m_scrollLists; // 0x20
		public DisposedUnityEvent<GameObject, int> onCellShow; // 0x28
		public DisposedUnityEvent<int> onClosestCellChanged; // 0x30
	
		// Constructors
		public UISemiCircleScrollListPair() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x0000000189AE96E4-0x0000000189AE9A58
		private void _OnCellShow(GameObject go, int index) {} // 0x0000000189AE9B14-0x0000000189AE9BB4
		private void _OnClosestCellChanged(int index) {} // 0x0000000189AE9BB4-0x0000000189AE9C3C
		private void _OnDrag() {} // 0x0000000189AE9C3C-0x0000000189AE9CD8
		private void _OnEndDrag() {} // 0x0000000189AE9CD8-0x0000000189AE9D58
		public void RefreshLayout(int newCellCount, int targetCellIndex) {} // 0x0000000189AE9A58-0x0000000189AE9B14
	}

	[ExecuteAlways]
	[RequireComponent(typeof(UIImage))]
	public class UISequenceImage : TickableUIMono // TypeDefIndex: 49368
	{
		// Fields
		public bool autoPlay; // 0x68
		public float frameRate; // 0x6C
		public List<Sprite> sprites; // 0x70
		private UIImage m_image; // 0x80
		private float m_curFrameCount; // 0x88
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		public bool isPlaying { get; private set; } // 0x0000000183D4F800-0x0000000183D4F810 0x0000000183D4F810-0x0000000183D4F820
	
		// Constructors
		public UISequenceImage() {} // 0x00000001837CAF60-0x00000001837CAFF0
	
		// Methods
		protected override void OnAwake() {} // 0x0000000183B74360-0x0000000183B743E0
		protected override void OnEnable() {} // 0x0000000183A53100-0x0000000183A53150
		protected override void OnDisable() {} // 0x0000000183C944F0-0x0000000183C94540
		public override void Tick(float deltaTime) {} // 0x00000001825C36F0-0x00000001825C3780
		public void Play() {} // 0x0000000183A53150-0x0000000183A531A0
		public void Stop(bool resetToFirstFrame = false /* Metadata: 0x01FBC6E4 */) {} // 0x0000000183C94540-0x0000000183C94580
		public void SetSprite(int index) {} // 0x00000001825C3780-0x00000001825C3980
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	[RequireComponent(typeof(Animation))]
	public class UISimpleActiveAnimationHelper : TickableUIMono // TypeDefIndex: 49369
	{
		// Fields
		public bool isActive; // 0x68
		public string toActiveAnimationName; // 0x70
		private Animation m_animation; // 0x78
		private UnityEngine.AnimationState m_animationState; // 0x80
		private float m_animationTime; // 0x88
		private float m_curAnimationTime; // 0x8C
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
	
		// Constructors
		public UISimpleActiveAnimationHelper() {} // 0x0000000183CDD650-0x0000000183CDD6B0
	
		// Methods
		private void Start() {} // 0x0000000189AEAE70-0x0000000189AEAF4C
		protected override void OnEnable() {} // 0x0000000189AEAD5C-0x0000000189AEADCC
		public void Skip() {} // 0x0000000189AEADCC-0x0000000189AEAE70
		public override void Tick(float deltaTime) {} // 0x0000000189AEAF4C-0x0000000189AEB074
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	[ExecuteInEditMode]
	public class UISimpleStateController : MonoBehaviour // TypeDefIndex: 49371
	{
		// Fields
		[SerializeField]
		private List<StateInfo> _states; // 0x18
		private string m_curStateName; // 0x20
	
		// Properties
		public string curStateName { get => default; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
		// Nested types
		[Serializable]
		public class StateInfo // TypeDefIndex: 49370
		{
			// Fields
			public string name; // 0x10
			public List<GameObject> activeObjects; // 0x18
	
			// Constructors
			public StateInfo() {} // 0x00000001828480E0-0x0000000182848160
	
			// Methods
			public override string ToString() => default; // 0x0000000189AE6424-0x0000000189AE6474
			public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
		}
	
		// Constructors
		public UISimpleStateController() {} // 0x0000000183577DE0-0x0000000183577E70
	
		// Methods
		public void SetState(string stateName) {} // 0x00000001833595F0-0x000000018335A4B0
	}

	public class UISizeFollower : TickableUIMono // TypeDefIndex: 49372
	{
		// Fields
		public RectTransform target; // 0x68
		public Vector2 addedSize; // 0x70
		[Tooltip("\u662F\u5426\u662F\u8DDF\u76EE\u6807\u7684\u6570\u503C\u52A0\u8D77\u6765\u662F\u4E2A\u5B9A\u503C")]
		public bool isSumSize; // 0x78
		public bool followWidth; // 0x79
		public bool followHeight; // 0x7A
		public bool regulateAnchoredPosition; // 0x7B
		[Space(10f)]
		public Vector2 minSize; // 0x7C
		public Vector2 maxSize; // 0x84
		private RectTransform m_rectTransform; // 0x90
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public RectTransform rectTransform { get => default; } // 0x0000000182F7AE60-0x0000000182F7B000 
	
		// Constructors
		public UISizeFollower() {} // 0x0000000182846E00-0x0000000182846E10
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x0000000182F7AB40-0x0000000182F7AB80
		public void SyncSize() {} // 0x0000000182F7AB80-0x0000000182F7AE60
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	[AddComponentMenu("UI/UI Slider", 34)]
	public class UISlider : Slider, IUIClearable, IBeginDragHandler, IEndDragHandler, IBindingGroupTarget, IBindingView // TypeDefIndex: 49373
	{
		// Fields
		public float snapCenterRange; // 0x1E8
		[AudioString]
		public string audioSlide; // 0x1F0
		[AudioString]
		public string audioClickHandle; // 0x1F8
		private bool m_dragging; // 0x200
		public SliderEvent onEndDragSlider; // 0x208
		public SliderEvent onClickSlider; // 0x210
		public SliderEvent onClickSliderHandle; // 0x218
		public string sliderAddActionId; // 0x220
		public string sliderReduceActionId; // 0x228
		private int m_bindingGroupId; // 0x238
		public bool snapStep; // 0x248
		public float stepValue; // 0x24C
		[SerializeField]
		protected bool _enableStickScroll; // 0x250
		[Range(0.001f, 1f)]
		[SerializeField]
		protected float _stickScrollTolerance; // 0x254
		[Range(0.001f, 0.9f)]
		[SerializeField]
		protected float _stickOverPushThreshold; // 0x258
		[SerializeField]
		protected int _stickOverPushMultiplier; // 0x25C
		[SerializeField]
		protected int _stickScrollBatchCount; // 0x260
		private int m_stickScrollHoriBindingId; // 0x264
	
		// Properties
		public string bindingViewActionId { get => default; } // 0x0000000183D57430-0x0000000183D57440 
		public string bindingViewLabelText { get => default; } // 0x0000000189AEB854-0x0000000189AEB88C 
		public DisposedUnityEvent bindingViewUpdateEvent { get; } // 0x0000000183D57210-0x0000000183D57220 
		public RectTransform redDotTrans { get => default; } // 0x0000000181002730-0x0000000181002740 
		public bool bindingEnabled { get => default; } // 0x0000000189AEB84C-0x0000000189AEB854 
		public BindingViewState bindingViewState { get => default; } // 0x0000000189AEB88C-0x0000000189AEB988 
		public int groupId { get => default; } // 0x0000000183D76180-0x0000000183D76190 
		public IBindingGroupTarget parentTarget { get; private set; } // 0x0000000183D56B10-0x0000000183D56B20 0x000000018586F120-0x000000018586F134
		public bool groupEnabled { get => default; } // 0x0000000189AEB988-0x0000000189AEB9DC 
		bool IBindingView.interactable { get => default; } // 0x0000000189AEB11C-0x0000000189AEB16C 
	
		// Constructors
		public UISlider() {} // 0x0000000182848300-0x00000001828484B0
	
		// Methods
		private void _TryPostSlideAudioEvent() {} // 0x000000018346C960-0x000000018346C9C0
		protected override float ClampValue(float input) => default; // 0x00000001831EB4A0-0x00000001831EB520
		protected override float CustomProcessNormalizedValue(float val) => default; // 0x0000000189AEB16C-0x0000000189AEB1F8
		protected override void OnValueChanged() {} // 0x000000018346C920-0x000000018346C960
		protected override void OnClickSliderBar() {} // 0x0000000189AEB340-0x0000000189AEB3C4
		protected override void OnClickSliderHandle() {} // 0x0000000189AEB3C4-0x0000000189AEB47C
		protected override void _NotifyIsHover(bool isHover) {} // 0x0000000182C6F160-0x0000000182C6F1D0
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189AEB2E4-0x0000000189AEB340
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x0000000189AEB47C-0x0000000189AEB51C
		protected override void Awake() {} // 0x0000000182C70370-0x0000000182C703C0
		protected override void OnEnable() {} // 0x00000001825294F0-0x0000000182529580
		protected override void OnDisable() {} // 0x000000018361D540-0x000000018361D5F0
		public void ClearComponent() {} // 0x0000000183B721E0-0x0000000183B72250
		protected override void OnDestroy() {} // 0x0000000183A07BD0-0x0000000183A07C60
		public string GetBindingViewActionId(BindingViewActionType actionType) => default; // 0x0000000189AEB1F8-0x0000000189AEB2E4
		void IBindingView.OnInputKeyDown(bool isActionTrigger) {} // 0x0000000189AEB074-0x0000000189AEB0C8
		void IBindingView.OnInputKeyUp(bool isActionTrigger) {} // 0x0000000189AEB0C8-0x0000000189AEB11C
		private void _InitBinding() {} // 0x0000000182C703C0-0x0000000182C704F0
		private void _AddValue() {} // 0x0000000189AEB52C-0x0000000189AEB598
		private void _ReduceValue() {} // 0x0000000189AEB718-0x0000000189AEB784
		private void _InitStickScroll() {} // 0x0000000182C704F0-0x0000000182C70580
		private void _StickScrollHoriValue() {} // 0x0000000189AEB784-0x0000000189AEB84C
		private void _ApplyStickScroll(float deltaConcern) {} // 0x0000000189AEB598-0x0000000189AEB718
		public float __iFixBaseProxy_ClampValue(float P0) => default; // 0x0000000189AEB51C-0x0000000189AEB524
		public float __iFixBaseProxy_CustomProcessNormalizedValue(float P0) => default; // 0x0000000183D65EB0-0x0000000183D65EC0
		public void __iFixBaseProxy_OnValueChanged() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnClickSliderBar() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnClickSliderHandle() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy__NotifyIsHover(bool P0) {} // 0x0000000189ACB974-0x0000000189ACB97C
		public void __iFixBaseProxy_Awake() {} // 0x0000000189AAE8DC-0x0000000189AAE8E4
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000189AEB524-0x0000000189AEB52C
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018361D5F0-0x000000018361D600
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000189AAE8E4-0x0000000189AAE8EC
	}

	[ExecuteInEditMode]
	public class UISoftMask : TickableUIMono // TypeDefIndex: 49375
	{
		// Fields
		private Vector3[] m_fourCornersArray; // 0x68
		private Vector3[] m_fourCornersArrayWorld; // 0x70
		private List<UISoftMaskable> m_cacheSoftMaskables; // 0x78
		private static List<Canvas> s_cacheCanvas; // 0x00
		private static Image s_image; // 0x08
		[SerializeField]
		private Shader _maskableDefaultShader; // 0x80
		[SerializeField]
		private Shader _maskableTextShader; // 0x88
		private static int s_SoftMaskTexId; // 0x10
		private static int s_SoftMaskTexSTId; // 0x14
		private static int s_WorldToSoftMaskId; // 0x18
		private static int s_InnerSoftMaskId; // 0x1C
		private static int s_InnerSoftMaskUVId; // 0x20
		private static int s_SpriteSlicedFlag; // 0x24
		private Texture m_mainTexture; // 0x90
		private Vector4 m_spriteTillingOffset; // 0x98
		private Matrix4x4 m_worldToSoftMask; // 0xA8
		private Vector4 m_innerSoftMask; // 0xE8
		private Vector4 m_innerSoftMaskUV; // 0xF8
		private SlicedSpriteParams m_slicedSpriteParams; // 0x108
		private Material m_softMaskDefaultMaterial; // 0x130
		private Dictionary<Material, Material> m_softMaskTextMaterials; // 0x138
		private Dictionary<Material, Material> m_softMaskUIVFXMaterials; // 0x140
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D567A0-0x0000000183D567B0 
		public Material softMaskDefaultMaterial { get => default; } // 0x0000000183D56D00-0x0000000183D56D10 
	
		// Nested types
		public struct SlicedSpriteParams // TypeDefIndex: 49374
		{
			// Fields
			public int slicedEnabled; // 0x00
			public Vector2 inner_PosMin; // 0x04
			public Vector2 inner_PosMax; // 0x0C
			public Vector2 inner_UVMin; // 0x14
			public Vector2 inner_UVMax; // 0x1C
	
			// Constructors
			public SlicedSpriteParams(int slicedEnabled, Vector2 inner_PosMin, Vector2 inner_PosMax, Vector2 inner_UVMin, Vector2 inner_UVMax) {
				this.slicedEnabled = default;
				this.inner_PosMin = default;
				this.inner_PosMax = default;
				this.inner_UVMin = default;
				this.inner_UVMax = default;
			} // 0x0000000183D76150-0x0000000183D76180
		}
	
		// Constructors
		public UISoftMask() {} // 0x0000000182846030-0x00000001828461E0
		static UISoftMask() {} // 0x0000000183A43080-0x0000000183A43210
	
		// Methods
		public Material GetTextSoftMaskMaterial(Material baseMaterial) => default; // 0x00000001825B8940-0x00000001825B8BF0
		public Material GetUIVFXSoftMaskMaterial(Material baseMaterial) => default; // 0x0000000189AEBACC-0x0000000189AEBD88
		public Vector3 GetCornerCanvas(int i) => default; // 0x0000000189AEB9DC-0x0000000189AEBA7C
		public Vector3[] GetFourCornnerArrayWorld() => default; // 0x0000000189AEBA7C-0x0000000189AEBACC
		protected override void OnEnable() {} // 0x0000000182529A90-0x0000000182529CE0
		protected override void OnDisable() {} // 0x0000000182529940-0x0000000182529A90
		public override void TailLateTick(float deltaTime) {} // 0x000000018262D2D0-0x000000018262D5D0
		private void _Clear() {} // 0x0000000182529EC0-0x000000018252A1C0
		private void _DestroyMaterial(Material material) {} // 0x000000018252A1C0-0x000000018252A230
		private void _UpdateParam() {} // 0x00000001828033D0-0x0000000182804F60
		private void _UpdateChildren(bool markVertices, bool markMaterial) {} // 0x00000001828051C0-0x0000000182805DE0
		private void _OnEnableRuntimeAtlas() {} // 0x00000001838C4F60-0x00000001838C4FA0
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x0000000185826E68-0x0000000185826E70
	}

	[ExecuteInEditMode]
	public class UISoftMaskable : TickableUIMono, IMaterialModifier, IMeshModifier // TypeDefIndex: 49378
	{
		// Fields
		[SerializeField]
		[Tooltip("\u5F00\u542F\u540E\u4F1A\u88C1\u5207Mesh\u5230\u53EA\u6709SoftMask\u7684\u8303\u56F4\uFF0C\u51CF\u5C11OverDraw\u4F46\u4F1A\u589E\u52A0\u9876\u70B9\u751F\u6210\u7684\u8BA1\u7B97\u6D88\u8017\u3002\u5EFA\u8BAESoftMask\u5F88\u5C0F\u4F46SoftMaskable\u5F88\u5927\u65F6\u5F00\u542F\u3002\u4E0D\u652F\u6301Text")]
		public bool _clipMeshToSaveOverDraw; // 0x68
		private List<UIVertex> m_cacheVertexSteram; // 0x70
		private List<UIVertex> m_cacheDstVertexSteram; // 0x78
		protected static readonly string UI_MINIMAP_MIST_KEYWORD; // 0x00
		protected static readonly string UI_VFX_PARAM; // 0x08
		private TestLine[] m_testLinesCache; // 0x80
		private Material m_softMaskModefiedMat; // 0x88
		private Graphic m_graphic; // 0x90
		private UISoftMask m_softMask; // 0x98
		private UIText m_uiText; // 0xA0
		private UIType m_uiType; // 0xA8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public Material softMaskModefiedMat { get => default; } // 0x0000000183D4EA60-0x0000000183D4EA70 
		public Graphic graphic { get => default; } // 0x0000000182806650-0x0000000182806730 
		public UISoftMask softMask { get => default; } // 0x00000001825B8880-0x00000001825B8940 
		public UIText uiText { get => default; } // 0x0000000189AED668-0x0000000189AED730 
	
		// Nested types
		private enum UIType // TypeDefIndex: 49376
		{
			Default = 0,
			Text = 1,
			UIVFX = 2
		}
	
		private struct TestLine // TypeDefIndex: 49377
		{
			// Fields
			public UIVertex v0; // 0x00
			public UIVertex v1; // 0x6C
			public Vector2 p0; // 0xD8
			public Vector2 p1; // 0xE0
			public Vector2 t0; // 0xE8
			public Vector2 t1; // 0xF0
			public Vector2 dir; // 0xF8
			public Vector2 normal; // 0x100
		}
	
		// Constructors
		public UISoftMaskable() {} // 0x00000001828463E0-0x00000001828464D0
		static UISoftMaskable() {} // 0x0000000183CDF1E0-0x0000000183CDF280
	
		// Methods
		public Material GetModifiedMaterial(Material baseMaterial) => default; // 0x00000001825B8740-0x00000001825B8880
		protected override void OnEnable() {} // 0x0000000182806130-0x0000000182806650
		protected override void OnDisable() {} // 0x0000000182806030-0x0000000182806130
		public override void LateTick(float deltaTime) {} // 0x000000018280A340-0x000000018280A490
		public void MarkGraphicVerticesDirty() {} // 0x0000000182805DE0-0x0000000182805EA0
		public void MarkGraphicMaterialDirty() {} // 0x0000000182805EF0-0x0000000182805FA0
		[IDTag(0)]
		public void ModifyMesh(Mesh mesh) {} // 0x0000000189AEBD88-0x0000000189AEBDDC
		private bool _Equal(float a, float b) => default; // 0x0000000189AED528-0x0000000189AED5AC
		private Vector2 _ComputeLineCross(Vector2 line0p0, Vector2 line0p1, Vector2 line1p0, Vector2 line1p1) => default; // 0x0000000189AED168-0x0000000189AED3A8
		private void _ComputePointAtTriangleUV(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 q, out float u, out float v) {
			u = default;
			v = default;
		} // 0x0000000189AED3A8-0x0000000189AED528
		private void _ClipTriangleByClampSoftMaskUV(UIVertex[] vertices, UIVertex[] resultPoint, out bool canSkip) {
			canSkip = default;
		} // 0x0000000189AEC0BC-0x0000000189AED168
		private void _ClipRect() {} // 0x0000000189AEBDDC-0x0000000189AEC0BC
		[IDTag(1)]
		public void ModifyMesh(VertexHelper vertHelper) {} // 0x00000001825B8670-0x00000001825B8740
		private static void _SetUIVertexUV(ref UIVertex uiVertex, Vector2 uv0, Vector2 uv1, Vector2 softMaskUV) {} // 0x0000000189AED5AC-0x0000000189AED668
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
	}

	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class UISortingOrder : MonoBehaviour // TypeDefIndex: 49380
	{
		// Fields
		[Range(-20f, 20f)]
		[SerializeField]
		[Tooltip("\u76F8\u5BF9\u4E8E\u9762\u677F\u7684 SortingOrder \u504F\u79FB\uFF0C0 \u4EE3\u8868\u548C\u9762\u677F\u540C\u7EA7\uFF0C\u8D1F\u6570\u4F4E\u4E8E\u9762\u677F\uFF0C\u6B63\u6570\u9AD8\u4E8E\u9762\u677F")]
		private int _sortingOrderOffset; // 0x18
		[SerializeField]
		[Tooltip("\u4E0D\u540CRender\u7684\u7C7B\u578B\u533A\u5206")]
		private RenderType _renderType; // 0x1C
		private Renderer m_renderer; // 0x20
		private Renderer[] m_childrenRenderers; // 0x28
		private Canvas m_canvas; // 0x30
		private LuaPanel m_luaPanel; // 0x38
	
		// Nested types
		[Serializable]
		public enum RenderType // TypeDefIndex: 49379
		{
			Effect = 0,
			UI = 1
		}
	
		// Constructors
		public UISortingOrder() {} // 0x00000001838A8970-0x00000001838A8980
	
		// Methods
		private void OnEnable() {} // 0x00000001836E7FB0-0x00000001836E8090
		private void _GetRenderer() {} // 0x0000000182A73870-0x0000000182A73920
		private void _GetChildrenRenderers() {} // 0x0000000182A73800-0x0000000182A73870
		private void _GetCanvas() {} // 0x0000000182A73660-0x0000000182A73710
		public void SetOrder(int baseOrder) {} // 0x0000000182A732B0-0x0000000182A734A0
		private void Awake() {} // 0x0000000182A72A10-0x0000000182A72B70
		private void OnDestroy() {} // 0x0000000183A411F0-0x0000000183A41290
	}

	public class UIStepScrollList : UIScrollList // TypeDefIndex: 49381
	{
		// Fields
		[NonSerialized]
		public DisposedUnityEvent<int, int> onCenterIndexChanged; // 0x278
		[NonSerialized]
		public DisposedUnityEvent onScrollOrDragEnd; // 0x280
		[NonSerialized]
		public DisposedUnityEvent onScrollOrDragStart; // 0x288
		[SerializeField]
		protected float _easyDragSpdThreshold; // 0x290
		[SerializeField]
		protected float _easyDragDistPercentThreshold; // 0x294
		private int m_startDragCenterIndex; // 0x298
		private int m_centerIndex; // 0x29C
		private Vector2 m_scrollStartNormalizedPos; // 0x2A0
	
		// Properties
		public int centerIndex { get => default; } // 0x0000000182A18F10-0x0000000182A18F20 
	
		// Constructors
		public UIStepScrollList() {} // 0x000000018284A630-0x000000018284A770
	
		// Methods
		protected override void Init(bool isPreview = false /* Metadata: 0x01FBC6EA */) {} // 0x0000000182D9CE80-0x0000000182D9D090
		protected override void InitConfig() {} // 0x0000000183801380-0x00000001838014A0
		protected override void OnScroll(Vector2 v) {} // 0x00000001828C15F0-0x00000001828C1660
		public override void OnBeginDrag(PointerEventData eventData) {} // 0x0000000189AED7B4-0x0000000189AED840
		public override void OnEndDrag(PointerEventData eventData) {} // 0x0000000189AED8B0-0x0000000189AEDA90
		public override void SetTop(bool needUpdate = true /* Metadata: 0x01FBC6EB */) {} // 0x0000000189AEDA90-0x0000000189AEDB24
		protected override void UpdateShowingCells(bool forceUpdateContent, bool forceClearShowingCells = false /* Metadata: 0x01FBC6EC */, bool ignoreListActive = false /* Metadata: 0x01FBC6ED */) {} // 0x00000001828C1660-0x00000001828C1740
		public override void ClearComponent() {} // 0x0000000189AED730-0x0000000189AED7B4
		private void _OnScrollStart(Vector2 normalizedPos) {} // 0x0000000189AEDC6C-0x0000000189AEDCF0
		private void _OnScrollEnd(Vector2 normalizedPos) {} // 0x0000000189AEDB64-0x0000000189AEDC6C
		private void _TryAutoScroll(bool isEasyDrag, bool goNext) {} // 0x0000000189AEDCF0-0x0000000189AEDDB4
		private int _GetClampedIndex() => default; // 0x00000001828C1740-0x00000001828C17A0
		protected override void OnDisable() {} // 0x0000000189AED840-0x0000000189AED8B0
		public void __iFixBaseProxy_Init(bool P0) {} // 0x0000000189AEDB2C-0x0000000189AEDB34
		public void __iFixBaseProxy_InitConfig() {} // 0x0000000189AEDB24-0x0000000189AEDB2C
		public void __iFixBaseProxy_OnScroll(Vector2 P0) {} // 0x0000000189ADD030-0x0000000189ADD038
		public void __iFixBaseProxy_OnBeginDrag(PointerEventData P0) {} // 0x0000000189AEDB34-0x0000000189AEDB3C
		public void __iFixBaseProxy_OnEndDrag(PointerEventData P0) {} // 0x0000000189AEDB44-0x0000000189AEDB4C
		public void __iFixBaseProxy_SetTop(bool P0) {} // 0x0000000189AEDB4C-0x0000000189AEDB54
		public void __iFixBaseProxy_UpdateShowingCells(bool P0, bool P1, bool P2) {} // 0x0000000189AEDB54-0x0000000189AEDB64
		public void __iFixBaseProxy_ClearComponent() {} // 0x0000000189ADCFE8-0x0000000189ADCFF0
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000189AEDB3C-0x0000000189AEDB44
	}

	public class UIStyleByState : MonoBehaviour // TypeDefIndex: 49384
	{
		// Fields
		public List<StyleConfig> styleConfigs; // 0x18
	
		// Nested types
		[Serializable]
		public class StateConfig // TypeDefIndex: 49382
		{
			// Fields
			public UIStateController stateController; // 0x10
			public string stateName; // 0x18
	
			// Constructors
			public StateConfig() {} // 0x000000018350B670-0x000000018350B680
		}
	
		[Serializable]
		public class StyleConfig // TypeDefIndex: 49383
		{
			// Fields
			public UIStyleInputValidTypeMask inputValidType; // 0x10
			public List<StateConfig> stateConfigs; // 0x18
	
			// Constructors
			public StyleConfig() {} // 0x0000000183595760-0x00000001835957E0
		}
	
		// Constructors
		public UIStyleByState() {} // 0x000000018367EB10-0x000000018367EBA0
	
		// Methods
		private void Awake() {} // 0x0000000182CD1F50-0x0000000182CD2060
		private void OnDestroy() {} // 0x0000000182CD0D70-0x0000000182CD0E60
		public void UpdateStyle() {} // 0x0000000182CD2160-0x0000000182CD2C30
		private bool _IsValidStyle(StyleConfig styleConfig) => default; // 0x0000000182CD2C30-0x0000000182CD2C80
	}

	public class UISubtitle : MonoBehaviour // TypeDefIndex: 49385
	{
		// Fields
		[SerializeField]
		private UIText _topText; // 0x18
		[SerializeField]
		private UIText _bottomText; // 0x20
	
		// Constructors
		public UISubtitle() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void Start() {} // 0x0000000189AF691C-0x0000000189AF696C
		private void _SetAsDefault() {} // 0x0000000189AF6A4C-0x0000000189AF6B7C
		public void SetSubtitle(string subtitle, bool showOnTop) {} // 0x0000000189AF6818-0x0000000189AF691C
		public void UpdateAlpha(float alpha, bool isTop) {} // 0x0000000189AF696C-0x0000000189AF6A4C
	}

	public class UITextPair : MonoBehaviour // TypeDefIndex: 49386
	{
		// Fields
		public List<UIText> referencedTexts; // 0x18
	
		// Properties
		public string text { get => default; set {} } // 0x0000000189AF7130-0x0000000189AF71EC 0x0000000189AF737C-0x0000000189AF74E8
		public UnityEngine.Color color { set {} } // 0x0000000189AF71EC-0x0000000189AF737C
		public UIText first { get => default; } // 0x0000000189AF7098-0x0000000189AF7130 
	
		// Constructors
		public UITextPair() {} // 0x000000018397CDE0-0x000000018397CE70
	
		// Methods
		public void SetAndResolveTextStyle(string targetText) {} // 0x0000000189AF6DA8-0x0000000189AF6F14
		public void SetPhoneticText(PhoneticType phoneticType, string id) {} // 0x0000000189AF6F14-0x0000000189AF7098
	}

	[AddComponentMenu("UI/UI Toggle", 30)]
	public class UIToggle : Toggle, IUIClearable // TypeDefIndex: 49387
	{
		// Fields
		[SerializeField]
		private List<GameObject> _onObjects; // 0x1A8
		[SerializeField]
		private List<GameObject> _offObjects; // 0x1B0
		[SerializeField]
		private UIStateController _uiStateController; // 0x1B8
		[SerializeField]
		private string _onStateName; // 0x1C0
		[SerializeField]
		private string _offStateName; // 0x1C8
		[SerializeField]
		private string _onAnimation; // 0x1D0
		[SerializeField]
		private string _offAnimation; // 0x1D8
		[AudioString]
		[SerializeField]
		private string _audioToggleOn; // 0x1E0
		[AudioString]
		[SerializeField]
		private string _audioToggleOff; // 0x1E8
		[AudioString]
		[SerializeField]
		private string _audioInvalid; // 0x1F0
		[SerializeField]
		public bool _ignoreClickOnDrag; // 0x1F8
		[SerializeField]
		[Tooltip("\u4E0D\u53EF\u70B9\u51FB\u65F6\u5F39\u51FA\u7684Toast\u6587\u672CKey")]
		private LangKey _invalidClickLangKey; // 0x208
		public Func<bool, bool> checkIsValueValid; // 0x218
		private Animation m_animation; // 0x220
		private int m_groupId; // 0x228
		[FormerlySerializedAs("_toggleActionId")]
		public string toggleActionId; // 0x230
		private bool m_started; // 0x23C
		[NonSerialized]
		public string clickOnHintTextId; // 0x240
		[NonSerialized]
		public string clickOffHintTextId; // 0x248
		[FormerlySerializedAs("actionOnSetNaviTarget")]
		[SerializeField]
		private ActionOnSetNaviTarget _actionOnSetNaviTarget; // 0x250
		[SerializeField]
		private bool _useNoHintAction; // 0x254
		public string onHintTextId; // 0x258
		public string offHintTextId; // 0x260
	
		// Properties
		public Vector2 startPressPos { get; private set; } // 0x0000000183D761F0-0x0000000183D76210 0x0000000183D76220-0x0000000183D76230
		public int toggleBindingId { get; private set; } // 0x0000000183D76180-0x0000000183D76190 0x0000000183D76230-0x0000000183D76240
		public int hoverConfirmBindingId { get; private set; } // 0x0000000183D761E0-0x0000000183D761F0 0x0000000183D76210-0x0000000183D76220
	
		// Constructors
		public UIToggle() {} // 0x0000000182847F80-0x00000001828480E0
	
		// Methods
		protected override void Awake() {} // 0x0000000182C6B820-0x0000000182C6B8B0
		protected override void OnEnable() {} // 0x0000000182C6C0A0-0x0000000182C6C100
		protected override void OnDisable() {} // 0x0000000182C6C030-0x0000000182C6C070
		private void _UpdateBindingEnable() {} // 0x0000000182C6C200-0x0000000182C6C2F0
		protected override void OnDestroy() {} // 0x0000000189AF7AEC-0x0000000189AF7BAC
		protected override void Start() {} // 0x0000000182C6BF60-0x0000000182C6BFB0
		protected override void InternalToggle() {} // 0x0000000182C6AC20-0x0000000182C6ACA0
		private void _InitToggleBinding() {} // 0x0000000182C6B8B0-0x0000000182C6BA50
		private bool _OnToggleFail() => default; // 0x0000000189AF7FE0-0x0000000189AF8130
		public void PlayAudio() {} // 0x0000000182C6AB90-0x0000000182C6AC20
		protected override void OnValueChange() {} // 0x0000000182C6B770-0x0000000182C6B7D0
		protected override void _NotifyIsHover(bool isHover) {} // 0x0000000182C6F0F0-0x0000000182C6F160
		private void _UpdateObjects() {} // 0x0000000182C6C4E0-0x0000000182C6CCA0
		private void _PlayAnimation(bool skipToEnd) {} // 0x0000000182C6CCA0-0x0000000182C6CE10
		public void ClearComponent() {} // 0x0000000183CE5950-0x0000000183CE59D0
		public override void OnInteractableChanged() {} // 0x0000000189AF7BAC-0x0000000189AF7BFC
		public override bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId) {
			clickHintTextId = default;
			longPressHintTextId = default;
			return default;
		} // 0x0000000189AF7A50-0x0000000189AF7AEC
		public override void OnPointerDown(PointerEventData eventData) {} // 0x0000000189AF7D80-0x0000000189AF7E14
		public override void OnPointerClick(PointerEventData eventData) {} // 0x0000000189AF7C68-0x0000000189AF7D80
		public override void OnSubmit(BaseEventData eventData) {} // 0x0000000189AF7E14-0x0000000189AF7E74
		public void TryInternalToggle() {} // 0x0000000183D2AFD0-0x0000000183D2B040
		public override void OnNaviTargetEnabledAgain() {} // 0x0000000189AF7BFC-0x0000000189AF7C68
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode) {} // 0x0000000189AF7E9C-0x0000000189AF7FE0
		private void _InitActionOnSetNaviTarget() {} // 0x0000000182C6BBA0-0x0000000182C6BCF0
		private void _ToggleNaviInputBinding(bool active) {} // 0x0000000189AF8130-0x0000000189AF81C8
		private void _TryRefreshToggleBindingText() {} // 0x0000000182C6BA50-0x0000000182C6BA90
		private void _TryRefreshHoverConfirmBindingText() {} // 0x0000000182C6B7D0-0x0000000182C6B820
		private void _TryRefreshBindingText(int bindingId) {} // 0x0000000182C6BA90-0x0000000182C6BBA0
		public void __iFixBaseProxy_Awake() {} // 0x0000000189AAE8DC-0x0000000189AAE8E4
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000189AF7E8C-0x0000000189AF7E94
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000189AF7E84-0x0000000189AF7E8C
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000189AF7E7C-0x0000000189AF7E84
		public void __iFixBaseProxy_Start() {} // 0x0000000184272FA8-0x0000000184272FB4
		public void __iFixBaseProxy_InternalToggle() {} // 0x0000000189AF7E74-0x0000000189AF7E7C
		public void __iFixBaseProxy_OnValueChange() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy__NotifyIsHover(bool P0) {} // 0x0000000189ACB974-0x0000000189ACB97C
		public void __iFixBaseProxy_OnInteractableChanged() {} // 0x000000018350B670-0x000000018350B680
		public bool __iFixBaseProxy_GetMouseActionHints(out string P0, out string P1) {
			P0 = default;
			P1 = default;
			return default;
		} // 0x0000000189ACB954-0x0000000189ACB95C
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0) {} // 0x0000000189ACB964-0x0000000189ACB96C
		public void __iFixBaseProxy_OnPointerClick(PointerEventData P0) {} // 0x0000000189AF7E94-0x0000000189AF7E9C
		public void __iFixBaseProxy_OnSubmit(BaseEventData P0) {} // 0x000000018968FA40-0x000000018968FA50
		public void __iFixBaseProxy_OnNaviTargetEnabledAgain() {} // 0x0000000189ACB95C-0x0000000189ACB964
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1) {} // 0x000000018350B670-0x000000018350B680
	}

	public class UIToggleGroup : ToggleGroup // TypeDefIndex: 49388
	{
		// Fields
		[SerializeField]
		private string _moveToNextActionId; // 0x28
		[SerializeField]
		private string _moveToPreviousActionId; // 0x30
		[SerializeField]
		private bool _inverse; // 0x38
	
		// Properties
		public int moveToNextBindingId { get; private set; } // 0x0000000183D4ED90-0x0000000183D4EDA0 0x0000000183D4EDC0-0x0000000183D4EDD0
		public int moveToPreviousBindingId { get; private set; } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
	
		// Constructors
		public UIToggleGroup() {} // 0x0000000183726B80-0x0000000183726C20
	
		// Methods
		protected override void Awake() {} // 0x00000001838EA450-0x00000001838EA650
		protected override void OnEnable() {} // 0x0000000182C6D2E0-0x0000000182C6D3E0
		protected override void OnDisable() {} // 0x0000000182C6D1F0-0x0000000182C6D2E0
		protected override void OnDestroy() {} // 0x0000000189AF7598-0x0000000189AF7674
		public void MoveToNext() {} // 0x0000000189AF74E8-0x0000000189AF7540
		public void MoveToPrevious() {} // 0x0000000189AF7540-0x0000000189AF7598
		private void _MoveTo(bool isNext) {} // 0x0000000189AF7674-0x0000000189AF7A50
		public void __iFixBaseProxy_Awake() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000182C6AE20-0x0000000182C6AE30
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018350B670-0x000000018350B680
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018350B670-0x000000018350B680
	}

	public enum FingerMoveDirection // TypeDefIndex: 49389
	{
		None = 0,
		Anisotropy = 1,
		Same = 2
	}

	[RequireComponent(typeof(Graphic))]
	public class UITouchPanel : TickableUIMono, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IUIClearable, IBindingGroupTarget // TypeDefIndex: 49390
	{
		// Fields
		[SerializeField]
		private float _gestureZoomSensitivity; // 0x68
		[SerializeField]
		private float _dragThreshold; // 0x6C
		[SerializeField]
		private float _longPressTime; // 0x70
		[SerializeField]
		private float _longPressMaxDist; // 0x74
		[SerializeField]
		private float _mouseZoomSensitivity; // 0x78
		[SerializeField]
		private float _scrollZoomSensitivity; // 0x7C
		[SerializeField]
		private bool _useGesturePixelSizeAdjustment; // 0x80
		[SerializeField]
		private float _multiClickInterval; // 0x84
		[SerializeField]
		private int _multiClickPixelOffset; // 0x88
		[SerializeField]
		private bool _ignoreClickOnLongPress; // 0x8C
		[SerializeField]
		private bool _clickThrough; // 0x8D
		[SerializeField]
		private bool _preventPressWhenClickThrough; // 0x8E
		private bool m_triggeredLongPress; // 0x8F
		private int m_clickCount; // 0x90
		private float m_lastClickTime; // 0x94
		private Vector2 m_lastClickPos; // 0x98
		private bool m_isPress; // 0xA0
		private bool m_isInGestureZoom; // 0xA1
		private bool m_isActionLongPress; // 0xA2
		private bool m_dragStarted; // 0xA3
		private Vector2 m_dragPosition; // 0xA4
		private RectTransform m_rect; // 0xB0
		private float m_deltaX; // 0xB8
		private float m_deltaY; // 0xBC
		private Vector2 m_lastFrameTouchPos; // 0xC0
		private PointerEventData m_touch; // 0xC8
		private int m_touchId; // 0xD0
		private int m_touchId1; // 0xD4
		private int m_touchId2; // 0xD8
		private float m_actionLongPressStartTime; // 0xDC
		private Vector2 m_actionLongPressStartPos; // 0xE0
		private float m_pixelSizeAdjustment; // 0xE8
		private Vector2 m_touch1Pos; // 0xEC
		private Vector2 m_touch1LastPos; // 0xF4
		private Vector2 m_touch2Pos; // 0xFC
		private Vector2 m_touch2LastPos; // 0x104
		private Vector3 m_lastMousePos; // 0x10C
		private bool m_lastFrameIsRightMouseButtonPress; // 0x118
		public UIEvent<PointerEventData> onClick; // 0x120
		public UIEvent<PointerEventData> onRightClick; // 0x128
		public DisposedUnityEvent<PointerEventData> onPress; // 0x130
		public DisposedUnityEvent<PointerEventData> onLongPress; // 0x138
		public DisposedUnityEvent<PointerEventData> onDoubleClick; // 0x140
		public DisposedUnityEvent<PointerEventData> onRelease; // 0x148
		public DisposedUnityEvent<PointerEventData> onDrag; // 0x150
		public DisposedUnityEvent<Vector2> onDragBegin; // 0x158
		public DisposedUnityEvent<Vector2> onDragEnd; // 0x160
		public DisposedUnityEvent<float> onZoom; // 0x168
		public DisposedUnityEvent<Vector2, FingerMoveDirection> onHorizonAndVerticalZoom; // 0x170
		public DisposedUnityEvent onDragToLeft; // 0x178
		public DisposedUnityEvent onDragToRight; // 0x180
		public DisposedUnityEvent onPointerEnter; // 0x188
		public DisposedUnityEvent onPointerExit; // 0x190
		public DisposedUnityEvent onDragToUp; // 0x198
		public DisposedUnityEvent onDragToDown; // 0x1A0
		public DisposedUnityEvent<Vector2> onRightMouseButtonPress; // 0x1A8
		public DisposedUnityEvent<float> onScroll; // 0x1B0
		public bool enableZoom; // 0x1C1
		public DisposedUnityEvent<PointerEventData> rawOnDrag; // 0x1C8
		private float m_leftMousePressDownTimeWithNoCursor; // 0x1D0
		private float m_rightMousePressDownTimeWithNoCursor; // 0x1D4
		private int m_groupId; // 0x1D8
		private bool m_bindingInit; // 0x1DC
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55740-0x0000000183D55750 
		public Vector2 touchPos { get => default; } // 0x0000000189AF8438-0x0000000189AF8470 
		public Vector2 curPressPos { get; set; } // 0x0000000183D76240-0x0000000183D76260 0x0000000183D76260-0x0000000183D76270
		public bool isPointerEntered { get; private set; } // 0x0000000183D57BF0-0x0000000183D57C00 0x0000000183D760A0-0x0000000183D760B0
		public bool isDragging { get => default; } // 0x0000000183D5B380-0x0000000183D5B390 
		public bool groupEnabled { get => default; } // 0x00000001833BE100-0x00000001833BE160 
		public int groupId { get => default; } // 0x00000001842760E8-0x0000000184276104 
		public IBindingGroupTarget parentTarget { get => default; } // 0x0000000183D56B80-0x0000000183D56B90 
		public InputBindingGroupMonoTarget parent { get; private set; } // 0x0000000183D56B80-0x0000000183D56B90 0x0000000185871130-0x0000000185871144
	
		// Constructors
		public UITouchPanel() {} // 0x00000001828473A0-0x0000000182847980
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData) {} // 0x00000001839766E0-0x00000001839767B0
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000183126350-0x00000001831263D0
		public void DoEndDrag(Vector2 dragPos) {} // 0x00000001831263D0-0x00000001831265D0
		public void OnDrag(PointerEventData eventData) {} // 0x0000000182912830-0x0000000182912970
		public void OnPointerDown(PointerEventData eventData) {} // 0x000000018284C110-0x000000018284C280
		public void OnPointerUp(PointerEventData eventData) {} // 0x000000018284BF70-0x000000018284C110
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018284BB10-0x000000018284BF70
		public void OnPointerEnter(PointerEventData eventData) {} // 0x0000000183743670-0x00000001837436C0
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000183743620-0x0000000183743670
		private void _OnActionPress(PointerEventData eventData) {} // 0x000000018284B350-0x000000018284BA00
		private void _OnActionRelease(PointerEventData eventData) {} // 0x000000018284BA00-0x000000018284BB10
		private bool _IsSameTouchFromPress(PointerEventData eventData) => default; // 0x0000000182911FB0-0x0000000182912010
		public void ClearTouchInfo() {} // 0x0000000183125E30-0x0000000183125EA0
		public void OnScroll(PointerEventData eventData) {} // 0x0000000189AF827C-0x0000000189AF833C
		public void SimulateClick(PointerEventData eventData) {} // 0x0000000189AF833C-0x0000000189AF83A0
		public void DeActiveTouch(int touchId) {} // 0x0000000189AF81C8-0x0000000189AF827C
		protected override void OnAwake() {} // 0x0000000183125EA0-0x0000000183125F20
		public override void Tick(float deltaTime) {} // 0x000000018284F730-0x000000018284FE00
		public override void LateTick(float deltaTime) {} // 0x00000001824B0D70-0x00000001824B0EF0
		protected override void OnEnable() {} // 0x0000000183125F20-0x0000000183125F60
		protected override void OnDisable() {} // 0x0000000183125DC0-0x0000000183125E30
		protected override void OnDestroy() {} // 0x000000018331B6F0-0x000000018331B790
		protected override void OnRelease() {} // 0x0000000183927ED0-0x0000000183927F10
		public void InitBinding() {} // 0x0000000183125F60-0x00000001831261B0
		private void _UpdateState() {} // 0x00000001831261B0-0x0000000183126290
		public void ClearComponent() {} // 0x0000000183927F10-0x0000000183928190
		public void __iFixBaseProxy_OnAwake() {} // 0x00000001858E2A30-0x00000001858E2A38
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185F2CFD8-0x0000000185F2CFE0
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018577D7B4-0x000000018577D7BC
	}

	[DefaultExecutionOrder(10)]
	[ExecuteInEditMode]
	public class UIVFXManager : TickableUIMono, IMaterialModifier // TypeDefIndex: 49391
	{
		// Fields
		private static int s_vfxMainTexSTId; // 0x00
		private Vector4 m_spriteTillingOffset; // 0x68
		private Material m_uiDefaultVFXMaterial; // 0x78
		private Dictionary<Material, Material> m_UIVfxMaterials; // 0x80
		private Shader m_uiDefaultShader; // 0x88
		private Graphic m_graphic; // 0x90
		private UISoftMaskable m_softMaskable; // 0x98
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55B70-0x0000000183D55B80 
		public Graphic graphic { get => default; } // 0x0000000189AF8CC4-0x0000000189AF8D8C 
		public UISoftMaskable softMaskable { get => default; } // 0x0000000189AF8D8C-0x0000000189AF8E54 
	
		// Constructors
		public UIVFXManager() {} // 0x00000001839AA090-0x00000001839AA130
		static UIVFXManager() {} // 0x0000000183D229E0-0x0000000183D22A30
	
		// Methods
		protected override void OnEnable() {} // 0x0000000189AF8664-0x0000000189AF87EC
		public override void LateTick(float deltaTime) {} // 0x0000000189AF8470-0x0000000189AF8508
		private void _OnEnableRuntimeAtlas() {} // 0x0000000189AF8A24-0x0000000189AF8A74
		protected override void OnDisable() {} // 0x0000000189AF8508-0x0000000189AF8664
		private void _Clear() {} // 0x0000000189AF87EC-0x0000000189AF899C
		private void _DestroyMaterial(Material material) {} // 0x0000000189AF899C-0x0000000189AF8A24
		private void _UpdateParam() {} // 0x0000000189AF8A74-0x0000000189AF8CC4
		public Material GetModifiedMaterial(Material baseMaterial) => default; // 0x0000000183B0E4F0-0x0000000183B0E5B0
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001858DD8AC-0x00000001858DD8B4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018589E548-0x000000018589E550
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001858DD8A4-0x00000001858DD8AC
	}

	public class UIWorldLevelScrollListAnimCtrl : MonoBehaviour // TypeDefIndex: 49394
	{
		// Fields
		public ScrollListLayoutInfo upLayoutGroup; // 0x18
		public ScrollListLayoutInfo downLayoutGroup; // 0x20
		public ScrollListLayoutInfo middleLayoutGroup; // 0x28
		public AnimationCurve speedCurve; // 0x30
		private IEnumerator m_enumerator; // 0x38
		[AudioString]
		[SerializeField]
		private string _audioEnd; // 0x40
	
		// Nested types
		[Serializable]
		public class ScrollListLayoutInfo // TypeDefIndex: 49392
		{
			// Fields
			public VerticalLayoutGroup layoutGroup; // 0x10
			public RectTransform layoutRectTransform; // 0x18
			public LayoutElement cell; // 0x20
	
			// Properties
			public float cellHeight { get => default; } // 0x0000000189AF023C-0x0000000189AF031C 
	
			// Constructors
			public ScrollListLayoutInfo() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public UIWorldLevelScrollListAnimCtrl() {} // 0x0000000189AF92B0-0x0000000189AF92F8
	
		// Methods
		public void UpdateUpPos(int current) {} // 0x0000000189AF9094-0x0000000189AF9150
		public void UpdateDownPos(int current) {} // 0x0000000189AF8EC4-0x0000000189AF8FA8
		public void UpdateMidPos(int current) {} // 0x0000000189AF8FA8-0x0000000189AF9094
		public void UpdateWorldLevelScrollList(bool isUp, int count) {} // 0x0000000189AF9150-0x0000000189AF91FC
		private void OnDisable() {} // 0x0000000189AF8E54-0x0000000189AF8EC4
		[IteratorStateMachine(typeof(__ScrollLayouts_d__12))]
		private IEnumerator _ScrollLayouts(bool isUp, int count) => default; // 0x0000000189AF91FC-0x0000000189AF92B0
	}

	public class VirtualMouseInitPos : MonoBehaviour // TypeDefIndex: 49395
	{
		// Fields
		private LuaPanel m_panel; // 0x18
	
		// Properties
		public LuaPanel panel { get => default; } // 0x0000000189AF9474-0x0000000189AF952C 
	
		// Constructors
		public VirtualMouseInitPos() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnEnable() {} // 0x0000000189AF92F8-0x0000000189AF9474
	}

	public class CSPopupPanel : MonoBehaviour // TypeDefIndex: 49396
	{
		// Fields
		public const string KEY = "CSPopupPanel"; // Metadata: 0x01FBC6F3
		public UIButton confirmBtn; // 0x18
		public UIButton cancelBtn; // 0x20
		public UIText contentTxt; // 0x28
		public GameObject bg1; // 0x30
		public GameObject bg2; // 0x38
		public GameObject warningImg; // 0x40
		public UIScrollRect scrollRect; // 0x48
		private Action m_onConfirm; // 0x50
		private Action m_onCancel; // 0x58
		private static FAssetProxyHandle s_handle; // 0x00
		public static HashSet<CSPopupPanel> s_instances; // 0x18
		public int timeScaleKey; // 0x60
	
		// Constructors
		public CSPopupPanel() {} // 0x000000018426FE60-0x000000018426FE68
		static CSPopupPanel() {} // 0x0000000189AEE888-0x0000000189AEE91C
	
		// Methods
		private void Awake() {} // 0x0000000189AEDDB4-0x0000000189AEDEF8
		private void _OnConfirm(PointerEventData p) {} // 0x0000000189AEE7E4-0x0000000189AEE888
		private void _OnCancel(PointerEventData p) {} // 0x0000000189AEE740-0x0000000189AEE7E4
		private void OnDestroy() {} // 0x0000000189AEE0EC-0x0000000189AEE2B0
		public static void Show(string content, Action onConfirm, bool showCancel = false /* Metadata: 0x01FBC6F1 */, Action onCancel = null, string confirmTxt = null, string cancelTxt = null, bool showWarning = false /* Metadata: 0x01FBC6F2 */) {} // 0x0000000189AEE2B0-0x0000000189AEE740
		public static void ClearAllPanels() {} // 0x0000000189AEDEF8-0x0000000189AEE0EC
	}

	public class LuaUIRoot : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 49397
	{
		// Fields
		public SerializeReferenceDictionary<string, LuaUIRootNode> nodeDic; // 0x18
	
		// Constructors
		public LuaUIRoot() {} // 0x0000000189AEFF4C-0x0000000189AEFFCC
	}

	public class LuaUIRootNode : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 49398
	{
		// Fields
		public string panelName; // 0x18
		public string panelFolder; // 0x20
	
		// Constructors
		public LuaUIRootNode() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public class MobileMotionManager : BaseManager // TypeDefIndex: 49400
	{
		// Fields
		private const string COMMON_MOTION_SHORT = "au_vibration_common_short"; // Metadata: 0x01FBC700
		private const string COMMON_MOTION_OPERATE_SUCCESS = "au_vibration_common_action_success"; // Metadata: 0x01FBC71A
		private const string COMMON_MOTION_OPERATE_FAILURE = "au_vibration_common_action_fail"; // Metadata: 0x01FBC73D
		private const string MOTION_LEVEL_LOW = "au_motion_resolution_state_low"; // Metadata: 0x01FBC75D
		private const string MOTION_LEVEL_MEDIUM = "au_motion_resolution_state_medium"; // Metadata: 0x01FBC77C
		private const string MOTION_LEVEL_HIGH = "au_motion_resolution_state_high"; // Metadata: 0x01FBC79E
		private MotionLevel m_currMotionLevel; // 0x18
	
		// Nested types
		private enum MotionLevel // TypeDefIndex: 49399
		{
			NONE = 0,
			LOW = 1,
			MEDIUM = 2,
			HIGH = 3
		}
	
		// Constructors
		public MobileMotionManager() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override void OnInit() {} // 0x0000000182CD09D0-0x0000000182CD0AE0
		protected override void OnRelease() {} // 0x0000000189AEFFCC-0x0000000189AF00DC
		public uint PostEventCommonShort() => default; // 0x0000000183CF76A0-0x0000000183CF77D0
		public uint PostEventCommonOperateSuccess() => default; // 0x0000000189AF0150-0x0000000189AF01C4
		public uint PostEventCommonOperateFailure() => default; // 0x0000000189AF00DC-0x0000000189AF0150
		public uint PostEvent(string eventName) => default; // 0x0000000189AF01C4-0x0000000189AF023C
		private void _CheckMotionLevelAndPostIfChange() {} // 0x0000000182CD0800-0x0000000182CD08B0
	}

	public static class I18nFontLoader // TypeDefIndex: 49401
	{
		// Fields
		private static Dictionary<int, FAssetProxyHandle> s_id2FontDic; // 0x00
		private static Dictionary<string, FAssetProxyHandle> s_name2MaterialDic; // 0x08
		private static FAssetProxyHandle s_fontSearchDataHandle; // 0x10
	
		// Properties
		public static I18nFontSearchData fontSearchData { get; } // 0x0000000182860380-0x0000000182860540 
	
		// Constructors
		static I18nFontLoader() {} // 0x0000000183C7B060-0x0000000183C7B150
	
		// Methods
		public static bool IsInvalid() => default; // 0x0000000182860540-0x0000000182860660
		public static Material GetMaterial(string matName) => default; // 0x0000000189AEFD00-0x0000000189AEFF4C
		public static TMP_FontAsset GetI18nFont(int cnFontId) => default; // 0x0000000182860000-0x0000000182860380
		public static int GetCNFontId(TMP_FontAsset font) => default; // 0x0000000189AEFC60-0x0000000189AEFD00
		public static bool IsFontDefaultMaterial(Material mat) => default; // 0x0000000183113EA0-0x0000000183113F40
	}

	public class DynamicFontAssetLoader : IFontAssetLoader // TypeDefIndex: 49403
	{
		// Fields
		private static HashSet<uint> s_notFoundUnicodes; // 0x00
	
		// Properties
		public List<FontAssetRef> fontAssets { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Nested types
		public class FontAssetRef // TypeDefIndex: 49402
		{
			// Fields
			public I18nFontSearchData.FontAssetInfo fontAssetInfo; // 0x10
			private HashSet<TMP_Text> m_refTexts; // 0x18
			private FAssetProxyHandle m_assetHandle; // 0x20
			private TMP_FontAsset m_fontAsset; // 0x38
	
			// Constructors
			public FontAssetRef() {} // 0x000000018370AB20-0x000000018370ABA0
	
			// Methods
			public TMP_FontAsset GetFontAsset(TMP_Text refText) => default; // 0x0000000189AEF9D0-0x0000000189AEFB68
			public void RemoveRefText(TMP_Text refText) {} // 0x0000000189AEFB68-0x0000000189AEFC60
			public void Dispose() {} // 0x0000000189AEF920-0x0000000189AEF9D0
		}
	
		// Constructors
		public DynamicFontAssetLoader() {} // 0x000000018370A950-0x000000018370AB20
		static DynamicFontAssetLoader() {} // 0x0000000183CE4A20-0x0000000183CE4AB0
	
		// Methods
		public static void AddNotFoundUnicode(uint unicode, bool forceLog = false /* Metadata: 0x01FBC7C2 */) {} // 0x0000000183A14990-0x0000000183A14B50
		public bool TryGetFontAsset(TMP_Text refText, uint unicode, out TMP_FontAsset fontAsset) {
			fontAsset = default;
			return default;
		} // 0x0000000189AEEAC0-0x0000000189AEEF18
		public void TryRemoveRefText(TMP_Text refText) {} // 0x0000000189AEEF18-0x0000000189AEF084
		public void Dispose() {} // 0x0000000189AEE91C-0x0000000189AEEAC0
	}

	public static class TweenUtils // TypeDefIndex: 49405
	{
		// Nested types
		public struct FLerpByTime // TypeDefIndex: 49404
		{
			// Fields
			public static FLerpByTime EMPTY; // 0x00
			private FScaledStopwatch m_timer; // 0x08
			public float startValue; // 0x20
			public float endValue; // 0x24
			public float duration; // 0x28
	
			// Properties
			public bool isEmpty { [IsReadOnly] get; private set; } // 0x0000000183D51020-0x0000000183D51030 0x0000000183D4F9D0-0x0000000183D4F9E0
	
			// Constructors
			static FLerpByTime() {
				EMPTY = default;
			} // 0x0000000189AEF1D0-0x0000000189AEF238
	
			// Methods
			public void Start(ITickOwner timeScaleProvider = null) {} // 0x0000000189AEF16C-0x0000000189AEF1D0
			public float GetValue(out bool isTweenFinished) {
				isTweenFinished = default;
				return default;
			} // 0x0000000189AEF084-0x0000000189AEF16C
		}
	
		// Methods
		public static bool TickAsCountDown(ref float countDown, float timeDelta) => default; // 0x000000018262E4C0-0x000000018262E590
	}

	public class UIAnimationLayerMixPlayer : SingleMixerAssetPlayer<AnimationClip, AnimationClipPlayable, AnimationLayerMixerPlayable, AnimationPlayableOutput> // TypeDefIndex: 49406
	{
		// Fields
		private Animator m_target; // 0x60
		private string m_outputName; // 0x68
	
		// Constructors
		public UIAnimationLayerMixPlayer() {} // Dummy constructor
		public UIAnimationLayerMixPlayer(Animator target, string outputName) {} // 0x0000000183099F80-0x0000000183099FF0
	
		// Methods
		public void LockToClip(AnimationClip clip, float clipPos) {} // 0x00000001830995A0-0x00000001830996A0
		protected override PlayableGraph CreateGraph() => default; // 0x0000000182967810-0x0000000182967860
		protected override AnimationLayerMixerPlayable CreateMixer(PlayableGraph graph, out FMixerOptions<AnimationClip> options) {
			options = default;
			return default;
		} // 0x0000000182967990-0x0000000182967A80
		protected override AnimationPlayableOutput CreateOutput(PlayableGraph graph) => default; // 0x0000000182967860-0x00000001829678D0
		protected override AnimationClipPlayable CreateSourceFromAsset(AnimationClip clip, PlayableGraph graph, out FPlayableMeta<AnimationClip> meta) {
			meta = default;
			return default;
		} // 0x0000000182967640-0x0000000182967720
	}

	public class UIAnimationMixPlayer : SingleMixerAssetPlayer<AnimationClip, AnimationClipPlayable, AnimationMixerPlayable, AnimationPlayableOutput> // TypeDefIndex: 49407
	{
		// Fields
		private Animator m_target; // 0x60
		private string m_outputName; // 0x68
	
		// Constructors
		public UIAnimationMixPlayer() {} // Dummy constructor
		public UIAnimationMixPlayer(Animator target, string outputName) {} // 0x0000000183099CE0-0x0000000183099D50
	
		// Methods
		public void LockToClip(AnimationClip clip, float clipPos) {} // 0x0000000183099D50-0x0000000183099E60
		protected override PlayableGraph CreateGraph() => default; // 0x0000000182966AF0-0x0000000182966B40
		protected override AnimationMixerPlayable CreateMixer(PlayableGraph graph, out FMixerOptions<AnimationClip> options) {
			options = default;
			return default;
		} // 0x0000000182966FD0-0x0000000182967090
		protected override AnimationPlayableOutput CreateOutput(PlayableGraph graph) => default; // 0x0000000182966C20-0x0000000182966C90
		protected override AnimationClipPlayable CreateSourceFromAsset(AnimationClip clip, PlayableGraph graph, out FPlayableMeta<AnimationClip> meta) {
			meta = default;
			return default;
		} // 0x0000000182966540-0x0000000182966620
	}

	public class UIListCache<TComp> // TypeDefIndex: 49410
		where TComp : Component
	{
		// Fields
		private FOptions m_options;
		private List<ItemWrapper> m_items;
		private int m_count;
	
		// Nested types
		public struct FOptions // TypeDefIndex: 49408
		{
			// Fields
			public TComp cellTemplate;
			public Transform parent;
			public Action<TComp> onItemCreated;
		}
	
		private class ItemWrapper // TypeDefIndex: 49409
		{
			// Fields
			public TComp comp;
	
			// Constructors
			public ItemWrapper() {}
		}
	
		// Constructors
		public UIListCache() {} // Dummy constructor
		public UIListCache(FOptions options) {}
	
		// Methods
		public void Refresh(int count, Action<TComp, int> refreshFunc, bool shouldHide = false /* Metadata: 0x01FBC7C3 */, Action<TComp, int> onDisableFunc = null) {}
		public TComp GetItem(int index) => default;
		private ItemWrapper _CreateNewItem() => default;
	}

	public class UILoadImageSprite : MonoBehaviour // TypeDefIndex: 49412
	{
		// Fields
		public bool isAsync; // 0x18
		public bool setNativeSize; // 0x19
		protected string m_spritePath; // 0x20
		protected Image m_imageComp; // 0x28
		protected FAssetProxyHandle m_handle; // 0x30
	
		// Properties
		public string spritePath { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000189AF65DC-0x0000000189AF6660
	
		// Constructors
		public UILoadImageSprite() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnDestroy() {} // 0x0000000189AF6250-0x0000000189AF62B0
		private void _LoadSprite(string path) {} // 0x0000000189AF62B0-0x0000000189AF65DC
	}

	public class UILoadImageSpriteByName : UILoadImageSprite // TypeDefIndex: 49413
	{
		// Fields
		[SerializeField]
		private string _folderPath; // 0x48
	
		// Properties
		public string spriteName { set {} } // 0x0000000189AF61A8-0x0000000189AF6250
	
		// Constructors
		public UILoadImageSpriteByName() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public abstract class UISwitchTween // TypeDefIndex: 49420
	{
		// Fields
		private Options m_options; // 0x10
		private ITweenHandler m_tween; // 0x20
		private bool m_isInited; // 0x28
		private bool m_isShowing; // 0x29
		private TweenContext m_context; // 0x2C
	
		// Properties
		public bool isTweening { get; } // 0x0000000182C3C750-0x0000000182C3C7D0 
		public bool isShow { get; set; } // 0x0000000183D4F2A0-0x0000000183D4F2B0 0x0000000182C3B950-0x0000000182C3B980
	
		// Nested types
		public struct Options // TypeDefIndex: 49414
		{
			// Properties
			public Action onShown { [IsReadOnly] get; set; } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
			public Action onHiden { [IsReadOnly] get; set; } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		}
	
		protected struct TweenContext // TypeDefIndex: 49415
		{
			// Fields
			public float lastStopPos; // 0x00
	
			// Methods
			public bool IsInterapted() => default; // 0x0000000189AF3420-0x0000000189AF3484
			public void OnReset() {} // 0x0000000182C3C3C0-0x0000000182C3C450
			public void OnTweenStop(ITweenProgress tweenProgress) {} // 0x0000000182C3C360-0x0000000182C3C3C0
		}
	
		public interface ITweenHandler : IHotfixable // TypeDefIndex: 49416
		{
			// Methods
			ITweenHandler SetAutoKill(bool autoKill);
			ITweenHandler OnComplete(TweenCallback callback);
			bool IsPlaying();
			void KillIfNecessary();
		}
	
		public interface ITweenProgress : IHotfixable // TypeDefIndex: 49417
		{
			// Methods
			float GetCurrPos();
		}
	
		public class TweenWrapper : ITweenHandler // TypeDefIndex: 49418
		{
			// Fields
			private DG.Tweening.Tween m_tween; // 0x10
	
			// Constructors
			public TweenWrapper() {} // Dummy constructor
			public TweenWrapper(DG.Tweening.Tween tween) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			public bool IsActive() => default; // 0x0000000189AF3698-0x0000000189AF36FC
			public bool IsPlaying() => default; // 0x0000000182C3C7D0-0x0000000182C3C820
			public void KillIfNecessary() {} // 0x0000000182C3C450-0x0000000182C3C490
			public ITweenHandler OnComplete(TweenCallback callback) => default; // 0x0000000182C3C0A0-0x0000000182C3C170
			public ITweenHandler SetAutoKill(bool autoKill) => default; // 0x0000000182C3C170-0x0000000182C3C1E0
		}
	
		// Constructors
		protected UISwitchTween() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected abstract ITweenHandler GenerateTweenOfShow();
		protected abstract ITweenHandler GenerateTweenOfHide();
		protected virtual void BeforeShowEffect() {} // 0x0000000189AF6BC0-0x0000000189AF6C04
		protected virtual void BeforeHideEffect() {} // 0x0000000182C3C1E0-0x0000000182C3C210
		protected virtual void AfterShowEffect() {} // 0x0000000183A4EA30-0x0000000183A4EA60
		protected virtual void AfterHideEffect() {} // 0x0000000189AF6B7C-0x0000000189AF6BC0
		protected virtual void ResetToState(bool isShow) {} // 0x0000000189AF6C50-0x0000000189AF6CA4
		public void Show() {} // 0x0000000182C3BC90-0x0000000182C3BDB0
		public void Hide() {} // 0x0000000182C3B980-0x0000000182C3BAB0
		[IteratorStateMachine(typeof(_WaitForTweening_d__19))]
		public IEnumerator WaitForTweening() => default; // 0x0000000189AF6D18-0x0000000189AF6DA8
		public void SetOptions(Options options) {} // 0x0000000189AF6CA4-0x0000000189AF6D18
		public void Reset(bool isShow) {} // 0x0000000182C3C210-0x0000000182C3C270
		public void Clear() {} // 0x0000000182C3DF40-0x0000000182C3DF80
		private void _ClearTweenInternal(bool isReset) {} // 0x0000000182C3C270-0x0000000182C3C310
		protected TweenContext GetContext() => default; // 0x0000000189AF6C04-0x0000000189AF6C50
		protected void ClearTween() {} // 0x0000000182C3C310-0x0000000182C3C360
	}

	public class FadeSwitchTween : UISwitchTween // TypeDefIndex: 49423
	{
		// Fields
		public const float DEFAULT_TWEEN_DURATION = 0.16f; // Metadata: 0x01FBC7C9
		private CanvasGroup m_alphaHandler; // 0x30
		private bool m_ignoreTimeScale; // 0x38
		private float m_activeAlpha; // 0x3C
	
		// Properties
		protected bool dontDisableGameObject { get; private set; } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		protected bool controlBlockRaycast { get; private set; } // 0x0000000183D4F7B0-0x0000000183D4F7C0 0x0000000183D4F7D0-0x0000000183D4F7E0
		protected Durations complexDuration { get; private set; } // 0x0000000183D76190-0x0000000183D761A0 0x0000000183D761A0-0x0000000183D761B0
		public float duration { get; set; } // 0x0000000183D4F670-0x0000000183D4F680 0x0000000183D4F680-0x0000000183D4F690
		public CanvasGroup alphaHandler { get => default; } // 0x0000000181003830-0x0000000181003840 
		public float activeAlpha { get => default; set {} } // 0x0000000183D4EC60-0x0000000183D4EC70 0x0000000189AEF2AC-0x0000000189AEF328
	
		// Nested types
		public struct Durations // TypeDefIndex: 49421
		{
			// Fields
			public float show; // 0x00
			public float showDelay; // 0x04
			public float hide; // 0x08
			public float hideDelay; // 0x0C
	
			// Methods
			public float GetShowDuration(float defaultDuration) => default; // 0x00000001836765D0-0x0000000183676610
			public float GetHideDuration(float defaultDuration) => default; // 0x0000000183676610-0x0000000183676650
		}
	
		public struct Builder // TypeDefIndex: 49422
		{
			// Fields
			public CanvasGroup alphaHandler; // 0x00
			public bool useTimeScale; // 0x08
			public bool dontDisableGameObject; // 0x09
			public bool controlBlockRaycast; // 0x0A
			public float duration; // 0x0C
			public Durations complexDuration; // 0x10
	
			// Methods
			public FadeSwitchTween Build() => default; // 0x0000000183653270-0x0000000183653350
		}
	
		// Constructors
		public FadeSwitchTween() {} // Dummy constructor
		public FadeSwitchTween(CanvasGroup alphaHandler, bool ignoreTimeScale) {} // 0x0000000189AEF288-0x0000000189AEF2AC
		public FadeSwitchTween(CanvasGroup alphaHandler, float duration = 0.16f /* Metadata: 0x01FBC7C4 */, bool ignoreTimeScale = true /* Metadata: 0x01FBC7C8 */) {} // 0x0000000183653350-0x0000000183653410
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide() => default; // 0x0000000183676350-0x0000000183676490
		protected override ITweenHandler GenerateTweenOfShow() => default; // 0x0000000183676490-0x00000001836765D0
		protected sealed override void BeforeShowEffect() {} // 0x00000001835FFC60-0x00000001835FFCC0
		protected sealed override void AfterHideEffect() {} // 0x00000001835FFCC0-0x00000001835FFD00
		protected sealed override void ResetToState(bool isShow) {} // 0x00000001835FFD00-0x00000001835FFD70
		protected virtual void SetObjectActive(CanvasGroup alphaHandler, bool isActive) {} // 0x00000001835FFD70-0x00000001835FFDE0
		public void Release() {} // 0x0000000189AEF238-0x0000000189AEF288
		public void __iFixBaseProxy_BeforeShowEffect() {} // 0x0000000189AC3758-0x0000000189AC3760
		public void __iFixBaseProxy_AfterHideEffect() {} // 0x0000000189AC3750-0x0000000189AC3758
		public void __iFixBaseProxy_ResetToState(bool P0) {} // 0x0000000189AC3760-0x0000000189AC3768
	}

	public class FadeTranslationSwitchTween : UISwitchTween // TypeDefIndex: 49425
	{
		// Fields
		private const float DEFAULT_TWEEN_DURATION = 0.16f; // Metadata: 0x01FBC7D9
		private CanvasGroup m_alphaHandler; // 0x30
		private RectTransform m_posHandler; // 0x38
		private Vector2 m_hidePos; // 0x40
		private Vector2 m_showPos; // 0x48
		private float m_duration; // 0x50
		private float m_hideDelay; // 0x54
		private float m_showDelay; // 0x58
	
		// Nested types
		private class TweenHandler : UISwitchTween.ITweenHandler // TypeDefIndex: 49424
		{
			// Fields
			private DG.Tweening.Tween m_alphaTweener; // 0x10
			private DG.Tweening.Tween m_posTweener; // 0x18
	
			// Constructors
			public TweenHandler() {} // Dummy constructor
			public TweenHandler(DG.Tweening.Tween alpha, DG.Tweening.Tween pos) {} // 0x0000000182676770-0x00000001826767A0
	
			// Methods
			public bool IsPlaying() => default; // 0x0000000189AF3484-0x0000000189AF34EC
			public void KillIfNecessary() {} // 0x0000000189AF34EC-0x0000000189AF3574
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback) => default; // 0x0000000189AF3574-0x0000000189AF35FC
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill) => default; // 0x0000000189AF35FC-0x0000000189AF3698
		}
	
		// Constructors
		public FadeTranslationSwitchTween() {} // Dummy constructor
		public FadeTranslationSwitchTween(CanvasGroup alphaHandler, RectTransform posHandler, Vector2 hidePos, Vector2 showPos, float duration = 0.16f /* Metadata: 0x01FBC7CD */, float hideDelay = 0f /* Metadata: 0x01FBC7D1 */, float showDelay = 0f /* Metadata: 0x01FBC7D5 */) {} // 0x0000000189AEF814-0x0000000189AEF920
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide() => default; // 0x0000000189AEF3F0-0x0000000189AEF530
		protected override ITweenHandler GenerateTweenOfShow() => default; // 0x0000000189AEF530-0x0000000189AEF670
		protected override void BeforeShowEffect() {} // 0x0000000189AEF38C-0x0000000189AEF3F0
		protected override void AfterHideEffect() {} // 0x0000000189AEF328-0x0000000189AEF38C
		protected override void ResetToState(bool isShow) {} // 0x0000000189AEF670-0x0000000189AEF734
		private float _GetTargetAlpha(bool isShow) => default; // 0x0000000189AEF734-0x0000000189AEF79C
		private Vector2 _GetTargetPos(bool isShow) => default; // 0x0000000189AEF79C-0x0000000189AEF814
		public void __iFixBaseProxy_BeforeShowEffect() {} // 0x0000000189AC3758-0x0000000189AC3760
		public void __iFixBaseProxy_AfterHideEffect() {} // 0x0000000189AC3750-0x0000000189AC3758
		public void __iFixBaseProxy_ResetToState(bool P0) {} // 0x0000000189AC3760-0x0000000189AC3768
	}

	public class UIAtlasManager : Singleton<UIAtlasManager> // TypeDefIndex: 49431
	{
		// Fields
		private TickFunction m_lateTickFunction; // 0x10
		public const int ATLAS_PAGE_WIDTH = 2048; // Metadata: 0x01FBC7DD
		public const int ATLAS_PAGE_HEIGHT = 1024; // Metadata: 0x01FBC7DF
		public const int IMAGE_USING_ATLAS_MAX_SIZE = 512; // Metadata: 0x01FBC7E1
		public const int UI_IMAGE_BLOCK_ALIGNMENT = 4; // Metadata: 0x01FBC7E3
		public const int PANEL_LEVEL_COUNT = 4; // Metadata: 0x01FBC7E4
		public const int MAX_ATLAS_PER_PANEL_LEVEL = 4; // Metadata: 0x01FBC7E5
		public const int PROCESS_COUNT_PER_FRAME = 3; // Metadata: 0x01FBC7E6
		public const GraphicsFormat ATLAS_PAGE_FORMAT = GraphicsFormat.RGBA_BC7_UNorm; // Metadata: 0x01FBC7E7
		private bool m_enableRuntimeAtlas; // 0x18
		private Dictionary<int, UIImage> m_imageDict; // 0x20
		private UIAtlasPage[,] m_atlasPagePool; // 0x28
		private Queue<UIImage> m_insertQueue; // 0x30
		private Queue<UIAtlasHandle> m_freeQueue; // 0x38
		private CommandBuffer m_commandBuffer; // 0x40
		private GraphicsFormat m_atlasPageFormat; // 0x48
	
		// Properties
		public static bool enableRuntimeAtlas { get => default; } // 0x00000001825CB4D0-0x00000001825CB590 
		public static bool enableRuntimeAtlasFromScript { get; set; } // 0x0000000189AF5BD8-0x0000000189AF5C10 0x0000000189AF5C10-0x0000000189AF5C4C
		public static bool releaseImageSpriteAfterInsert { get => default; } // 0x000000018232EB60-0x000000018232EB70 
	
		// Nested types
		public enum UIAtlasProcessStatus // TypeDefIndex: 49426
		{
			Invalid = 0,
			InsertWaiting = 1,
			InsertDone = 2
		}
	
		public enum UIAtlasProcessFailureCause // TypeDefIndex: 49427
		{
			NoFailure = 0,
			FailureCauseImageHasNullMainTexture = 1,
			FailureCauseImageHasNullSprite = 2,
			FailureCauseTextureWidthExceedLimit = 3,
			FailureCauseTextureHeightExceedLimit = 4,
			FailureCauseTextureASTCNotSupportedUnderEditor = 5,
			FailureLevelInfo = 6,
			FailureCauseSpriteHasNonQuadMesh = 7,
			FailureCauseSpriteHasAssociatedAlphaSplitTexture = 8,
			FailureLevelWarning = 9,
			FailureCauseAtlasTextureHasNoSpaceLeft = 10,
			FailureCauseSpriteRectHasNoPadding = 11,
			FailureLevelError = 12,
			FailureCauseTextureFormatNotCompatible = 13,
			FailureCauseTextureSizeNotAlignedForCopyTexture = 14
		}
	
		public struct UIAtlasHandle // TypeDefIndex: 49428
		{
			// Fields
			public UIAtlasProcessStatus status; // 0x00
			public UIAtlasProcessFailureCause failureCause; // 0x04
			public int panelLevel; // 0x08
			public int atlasIndex; // 0x0C
			public RectInt atlasRect; // 0x10
			public int textureId; // 0x20
	
			// Constructors
			public UIAtlasHandle(UIAtlasProcessStatus status, UIAtlasProcessFailureCause failureCause, int panelLevel, int atlasIndex, RectInt atlasRect, int textureId) {
				this.status = default;
				this.failureCause = default;
				this.panelLevel = default;
				this.atlasIndex = default;
				this.atlasRect = default;
				this.textureId = default;
			} // 0x0000000183D761B0-0x0000000183D761E0
	
			// Methods
			public bool IsValid() => default; // 0x0000000189AF418C-0x0000000189AF41DC
			public static UIAtlasHandle CreateInvalidHandle(UIAtlasProcessFailureCause cause = UIAtlasProcessFailureCause.NoFailure /* Metadata: 0x01FBC7FB */) => default; // 0x00000001824347C0-0x0000000182434870
		}
	
		public class UIAtlasPage // TypeDefIndex: 49430
		{
			// Properties
			public int maxFreeRectWidth { get => default; } // 0x0000000189AF618C-0x0000000189AF61A8 
			public int maxFreeRectHeight { get => default; } // 0x000000018943FA1C-0x000000018943FA38 
			public Texture2D pageTexture { get; } // 0x00000001820B7B20-0x00000001820B7B30 
			public Dictionary<int, TextureRefHandle> textureRefDict { get; } // 0x0000000181041090-0x00000001810410A0 
			public AtlasMaxRect rectBinPack { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
	
			// Nested types
			public struct TextureRefHandle // TypeDefIndex: 49429
			{
				// Fields
				public int refCount; // 0x00
				public RectInt rect; // 0x04
	
				// Constructors
				public TextureRefHandle(int refCount, RectInt rect) {
					this.refCount = default;
					this.rect = default;
				} // 0x0000000183D675C0-0x0000000183D675D0
			}
	
			// Constructors
			public UIAtlasPage() {} // Dummy constructor
			public UIAtlasPage(int panelDepth, int index, GraphicsFormat atlasFormat) {} // 0x0000000189AF5FFC-0x0000000189AF618C
	
			// Methods
			public RectInt InsertRect(int width, int height) => default; // 0x0000000189AF5ED0-0x0000000189AF5F74
			public void CopyIntoAtlas(CommandBuffer cmd, Texture texture, [IsReadOnly] in RectInt rect) {} // 0x0000000189AF5C4C-0x0000000189AF5DF8
			public void InsertRects(List<RectInt> rects, List<RectInt> dst) {} // 0x0000000189AF5F74-0x0000000189AF5FFC
			public void FreeRect([IsReadOnly] in RectInt rect) {} // 0x0000000189AF5DF8-0x0000000189AF5E64
			public void FreeRects([IsReadOnly] in List<RectInt> rects) {} // 0x0000000189AF5E64-0x0000000189AF5ED0
		}
	
		// Constructors
		private UIAtlasManager() {} // 0x0000000189AF5BA0-0x0000000189AF5BD8
	
		// Methods
		protected void OnInit() {} // 0x0000000189AF438C-0x0000000189AF458C
		protected void OnUnInit() {} // 0x0000000189AF458C-0x0000000189AF45DC
		public void Release() {} // 0x0000000189AF4660-0x0000000189AF46B0
		private void _CreateTickFunction() {} // 0x0000000189AF4AB0-0x0000000189AF4BD8
		private void _ClearTickFunction() {} // 0x0000000189AF4A48-0x0000000189AF4AB0
		public static void AddUIImageToManager(UIImage image) {} // 0x0000000189AF41DC-0x0000000189AF4260
		public static void ReProcessInsertForUIImage(UIImage image) {} // 0x0000000189AF45DC-0x0000000189AF4660
		public static void RemoveUIImageFromManager(UIImage image) {} // 0x00000001825CB630-0x00000001825CB690
		public static void AddUIImageToManagerOnInstantiate(UIImage image) {} // 0x00000001825CB7B0-0x00000001825CB810
		public int GetAtlasCount() => default; // 0x0000000189AF4260-0x0000000189AF4324
		public void LateTick(float deltaTime) {} // 0x0000000189AF4324-0x0000000189AF438C
		private void _AddUIImageToManager(UIImage image) {} // 0x0000000189AF494C-0x0000000189AF4A48
		private void _ReProcessInsertForUIImage(UIImage image) {} // 0x0000000189AF58D4-0x0000000189AF5A38
		private void _RemoveUIImageFromManager(UIImage image) {} // 0x0000000189AF5A38-0x0000000189AF5BA0
		private void _AddUIImageToManagerOnInstantiate(UIImage image) {} // 0x0000000189AF46B0-0x0000000189AF494C
		private bool _IsRuntimeAtlasCompatible(UIImage image, out UIAtlasProcessFailureCause failureCause) {
			failureCause = default;
			return default;
		} // 0x0000000189AF4BD8-0x0000000189AF4EEC
		private void _ProcessInsertQueue() {} // 0x0000000189AF4EEC-0x0000000189AF561C
		private void _ProcessRemoveQueue() {} // 0x0000000189AF561C-0x0000000189AF58D4
	}

	public class UIRedDotAnimation : Singleton<UIRedDotAnimation> // TypeDefIndex: 49432
	{
		// Fields
		private UIGraphicAnimation m_uiGraphicAnimation; // 0x10
		private Material m_materialInstance; // 0x18
		private HashSet<UIImage> m_redDotImages; // 0x20
		private GameObject m_root; // 0x28
	
		// Constructors
		private UIRedDotAnimation() {} // 0x0000000183CF1170-0x0000000183CF1200
	
		// Methods
		public void Init(GameObject redDotAnimationRoot) {} // 0x000000018399BA90-0x000000018399BD40
		public void UnInit() {} // 0x0000000189AF6660-0x0000000189AF6818
		public void AddRedDotImage(UIImage img) {} // 0x0000000182E80D30-0x0000000182E80E10
		public void RemoveRedDotImage(UIImage img) {} // 0x0000000182E80B40-0x0000000182E80BD0
		private void _UpdateRedDotAnimation() {} // 0x0000000182E80E10-0x0000000182E80E80
	}

	public class UIRedDotAnimationNode : MonoBehaviour // TypeDefIndex: 49433
	{
		// Fields
		private UIImage m_image; // 0x18
	
		// Constructors
		public UIRedDotAnimationNode() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void Awake() {} // 0x00000001836A3DA0-0x00000001836A3E10
		private void OnEnable() {} // 0x0000000182E80C80-0x0000000182E80D30
		private void OnDisable() {} // 0x0000000182E80BD0-0x0000000182E80C80
	}

	public static class WebApplication // TypeDefIndex: 49435
	{
		// Methods
		public static void Start(string url, Action onClose = null) {} // 0x0000000189AF952C-0x0000000189AF96F8
	}
}

namespace Beyond.UI.GPUI
{
	[Flags]
	internal enum ChangeState // TypeDefIndex: 49454
	{
		Stable = 0,
		New = 1,
		ChangeSize = 2,
		ChangeData = 4
	}

	internal struct RuntimeNodeInfo // TypeDefIndex: 49455
	{
		// Fields
		public Beyond.UI.GPUI.NodeType nodeType; // 0x00
		public SimpleTextAlignment textAlignment; // 0x04
		public int nodeIndex; // 0x08
		public int childNodeCount; // 0x0C
		public uint color; // 0x10
		public Vector2 position; // 0x14
		public string textOverride; // 0x20
		public bool changed; // 0x28
		public bool hide; // 0x29
	}

	internal class RuntimeAnimationData // TypeDefIndex: 49456
	{
		// Fields
		public string name; // 0x10
		public float duration; // 0x18
		public List<GPUInstanceData> template; // 0x20
	
		// Constructors
		public RuntimeAnimationData() {} // 0x0000000182AD9170-0x0000000182AD91F0
	}

	internal class RuntimePrefabData // TypeDefIndex: 49457
	{
		// Fields
		public int templateNodeCount; // 0x10
		public List<RuntimeNodeInfo> nodes; // 0x18
		public Dictionary<string, int> nodesNameMap; // 0x20
		public List<RuntimeAnimationData> animations; // 0x28
	
		// Constructors
		public RuntimePrefabData() {} // 0x0000000182AD9750-0x0000000182AD9870
	}

	public struct GPUPrefabData // TypeDefIndex: 49458
	{
		// Fields
		public Vector4 uv; // 0x00
		public Vector4 aniPosScaleMinMax; // 0x10
		public Vector4 aniPosAddMinMax; // 0x20
		public Vector2 aniURange; // 0x30
		public float aniPosScaleV; // 0x38
		public float aniPosAddV; // 0x3C
		public float aniColorV; // 0x40
		public float aniDurationInv; // 0x44
		public int materialType; // 0x48
		public uint materialParam1; // 0x4C
	
		// Constructors
		public GPUPrefabData(NodeSerializeData data) {
			uv = default;
			aniPosScaleMinMax = default;
			aniPosAddMinMax = default;
			aniURange = default;
			aniPosScaleV = default;
			aniPosAddV = default;
			aniColorV = default;
			aniDurationInv = default;
			materialType = default;
			materialParam1 = default;
		} // 0x0000000182AD9430-0x0000000182AD94D0
		public GPUPrefabData(Vector4 uv, Vector4 scale) {
			this.uv = default;
			aniPosScaleMinMax = default;
			aniPosAddMinMax = default;
			aniURange = default;
			aniPosScaleV = default;
			aniPosAddV = default;
			aniColorV = default;
			aniDurationInv = default;
			materialType = default;
			materialParam1 = default;
		} // 0x00000001834F73A0-0x00000001834F73D0
	
		// Methods
		public static GPUPrefabData CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv) => default; // 0x00000001834F7300-0x00000001834F73A0
	}

	public struct GPUPrefabDataLite // TypeDefIndex: 49459
	{
		// Fields
		public short uvX; // 0x00
		public short uvY; // 0x02
		public short uvZ; // 0x04
		public short uvW; // 0x06
		public ushort aniPosScaleMinX; // 0x08
		public ushort aniPosScaleMinY; // 0x0A
		public ushort aniPosScaleMaxX; // 0x0C
		public ushort aniPosScaleMaxY; // 0x0E
		public ushort aniPosAddMinX; // 0x10
		public ushort aniPosAddMinY; // 0x12
		public ushort aniPosAddMaxX; // 0x14
		public ushort aniPosAddMaxY; // 0x16
		public short aniURangeX; // 0x18
		public short aniURangeY; // 0x1A
		public short aniPosScaleV; // 0x1C
		public short aniPosAddV; // 0x1E
		public short aniColorV; // 0x20
		public short aniDuration; // 0x22
		public ushort materialType; // 0x24
		public ushort materialParam1; // 0x26
		public uint padding; // 0x28
		public uint padding2; // 0x2C
	
		// Constructors
		public GPUPrefabDataLite(NodeSerializeData data, Vector2 texelSizeInv, Vector2 aniTexelSizeInv) {
			uvX = default;
			uvY = default;
			uvZ = default;
			uvW = default;
			aniPosScaleMinX = default;
			aniPosScaleMinY = default;
			aniPosScaleMaxX = default;
			aniPosScaleMaxY = default;
			aniPosAddMinX = default;
			aniPosAddMinY = default;
			aniPosAddMaxX = default;
			aniPosAddMaxY = default;
			aniURangeX = default;
			aniURangeY = default;
			aniPosScaleV = default;
			aniPosAddV = default;
			aniColorV = default;
			aniDuration = default;
			materialType = default;
			materialParam1 = default;
			padding = default;
			padding2 = default;
		} // 0x0000000189B0AE8C-0x0000000189B0B0E4
		public GPUPrefabDataLite(Vector4 uv, Vector4 scale, Vector2 texelSizeInv) {
			uvX = default;
			uvY = default;
			uvZ = default;
			uvW = default;
			aniPosScaleMinX = default;
			aniPosScaleMinY = default;
			aniPosScaleMaxX = default;
			aniPosScaleMaxY = default;
			aniPosAddMinX = default;
			aniPosAddMinY = default;
			aniPosAddMaxX = default;
			aniPosAddMaxY = default;
			aniURangeX = default;
			aniURangeY = default;
			aniPosScaleV = default;
			aniPosAddV = default;
			aniColorV = default;
			aniDuration = default;
			materialType = default;
			materialParam1 = default;
			padding = default;
			padding2 = default;
		} // 0x0000000189B0B0E4-0x0000000189B0B1DC
	
		// Methods
		public static GPUPrefabDataLite CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv) => default; // 0x0000000189B0AD98-0x0000000189B0AE8C
	}

	public struct GPUInstanceData // TypeDefIndex: 49460
	{
		// Fields
		public float animeTime; // 0x00
		public uint color; // 0x04
		public Vector2 pos; // 0x08
		public ushort prefabId; // 0x10
		public ushort parentId; // 0x12
		public ushort grandParentId; // 0x14
		public byte matType; // 0x16
		public byte drawType; // 0x17
		public uint padding0; // 0x18
		public uint padding1; // 0x1C
	}

	public enum NodeType // TypeDefIndex: 49461
	{
		Root = 0,
		Image = 1,
		Text = 2
	}

	public enum SimpleTextAlignment // TypeDefIndex: 49462
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	[Serializable]
	public class NodeSerializeData // TypeDefIndex: 49463
	{
		// Fields
		public Vector4 uv; // 0x10
		public Vector4 aniPosScaleMinMax; // 0x20
		public Vector4 aniPosAddMinMax; // 0x30
		public Vector2 aniURange; // 0x40
		public float aniPosScaleV; // 0x48
		public float aniPosAddV; // 0x4C
		public float aniColorV; // 0x50
		public float aniDurationInv; // 0x54
		public int materialType; // 0x58
		public uint materialParam1; // 0x5C
	
		// Constructors
		public NodeSerializeData() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class NodeMetadata // TypeDefIndex: 49464
	{
		// Fields
		public string nodeName; // 0x10
		public Beyond.UI.GPUI.NodeType nodeType; // 0x18
		public string nodeTextId; // 0x20
		public string nodeText; // 0x28
		public SimpleTextAlignment textAlignment; // 0x30
		public float nodeTextSize; // 0x34
	
		// Constructors
		public NodeMetadata() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class AnimationSerializeData // TypeDefIndex: 49465
	{
		// Fields
		public string animationName; // 0x10
		public float animationTime; // 0x18
		public int totalFrames; // 0x1C
		public UnityEngine.WrapMode wrapMode; // 0x20
		public int renderNodesOffset; // 0x24
	
		// Constructors
		public AnimationSerializeData() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class PrefabSerializeData // TypeDefIndex: 49466
	{
		// Fields
		public string prefabName; // 0x10
		public int nodeCount; // 0x18
		public bool animationOnly; // 0x1C
		public List<NodeMetadata> nodeMetas; // 0x20
		public List<NodeSerializeData> renderNodes; // 0x28
		public List<AnimationSerializeData> animations; // 0x30
	
		// Constructors
		public PrefabSerializeData() {} // 0x000000018354E040-0x000000018354E160
	}

	[Serializable]
	public class PrefabGroupSerializeData : IMemoryPackSerialize // TypeDefIndex: 49467
	{
		// Fields
		public StringPathHash spriteTexturePath; // 0x10
		public StringPathHash vatTexturePath; // 0x18
		public List<PrefabSerializeData> prefabs; // 0x20
		public List<string> textIds; // 0x28
		public string importantChars; // 0x30
	
		// Constructors
		public PrefabGroupSerializeData() {} // 0x00000001839A00F0-0x00000001839A01B0
	}

	public struct GPUIHandle : IEquatable<GPUIHandle> // TypeDefIndex: 49468
	{
		// Fields
		public int index; // 0x00
		public int version; // 0x04
	
		// Methods
		[IDTag(0)]
		public bool Equals(GPUIHandle other) => default; // 0x0000000189B09030-0x0000000189B0909C
		[IDTag(1)]
		public override bool Equals(object obj) => default; // 0x0000000189B0909C-0x0000000189B09138
		public override int GetHashCode() => default; // 0x0000000189B09138-0x0000000189B09188
		public static bool operator ==(GPUIHandle left, GPUIHandle right) => default; // 0x0000000189B09238-0x0000000189B092A4
		public static bool operator !=(GPUIHandle left, GPUIHandle right) => default; // 0x0000000189B092A4-0x0000000189B09310
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x0000000189B09188-0x0000000189B091E8
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000189B091E8-0x0000000189B09238
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class GPUISystem : MaskableGraphic // TypeDefIndex: 49470
	{
		// Fields
		public static readonly string CONFIG_JSON_PATH_FORMAT; // 0x00
		public static readonly int RENDER_GROUP_SIZE; // 0x08
		public static readonly int RENDER_GROUP_SIZE_GL; // 0x0C
		public List<Material> materialTemplates; // 0xE8
		public string configGroupName; // 0xF0
		public int sourceCNFontId; // 0xF8
		private TMP_FontAsset m_i18NFontAsset; // 0x100
		public bool noSortingOrder; // 0x108
		private bool m_liteMode; // 0x109
		private bool m_inited; // 0x10A
		private bool m_rendererDisabled; // 0x10B
		private List<Material> m_instancedMaterials; // 0x110
		private Texture m_vatTexture; // 0x118
		private Texture m_spriteTexture; // 0x120
		private FAssetProxyHandle m_vatTextureHandle; // 0x128
		private FAssetProxyHandle m_spriteTextureHandle; // 0x13C
		private float m_timeForShader; // 0x150
		private Dictionary<string, RuntimePrefabData> m_prefabMap; // 0x158
		private Transform m_targetCanvasTransform; // 0x160
		private Matrix4x4 m_canvasObjectToWorldMatrix; // 0x168
		private List<RuntimeInstance> m_instances; // 0x1A8
		private Queue<int> m_recyclePool; // 0x1B0
		private List<KeyValuePair<float, GPUIHandle>> m_destroyQueue; // 0x1B8
		private ITextSystem m_simpleTextSystem; // 0x1C0
		[CanBeNull]
		private InstanceBufferManager m_instanceBufferManager; // 0x1C8
		[CanBeNull]
		private SimpleBufferManager<GPUPrefabData> m_prefabBufferManager; // 0x1D0
		[CanBeNull]
		private SimpleBufferManager<GPUPrefabDataLite> m_litePrefabBufferManager; // 0x1D8
	
		// Properties
		public TMP_FontAsset fontAsset { get => default; set {} } // 0x0000000183614580-0x0000000183614650 0x0000000189B0A774-0x0000000189B0A868
	
		// Nested types
		private static class ShaderIDs // TypeDefIndex: 49469
		{
			// Fields
			internal static readonly int CANVAS_OBJECT_TO_WORLD_MATRIX; // 0x00
			internal static readonly int VAT_TEX; // 0x04
			internal static readonly int MAIN_TEX; // 0x08
			internal static readonly int SPRITE_TEX; // 0x0C
	
			// Constructors
			static ShaderIDs() {} // 0x0000000183C85500-0x0000000183C855D0
		}
	
		// Constructors
		public GPUISystem() {} // 0x0000000182E12010-0x0000000182E12260
		static GPUISystem() {} // 0x0000000183CF7FA0-0x0000000183CF8030
	
		// Methods
		public bool CreateInstance(string prefabName, Vector3 initialPosition, out GPUIHandle handle, int sortingOrder = 0 /* Metadata: 0x01FBC847 */) {
			handle = default;
			return default;
		} // 0x0000000189B09310-0x0000000189B09404
		public bool DestroyInstance(GPUIHandle handle) => default; // 0x0000000189B09404-0x0000000189B09494
		public bool IsInstanceValid(GPUIHandle handle) => default; // 0x0000000189B09494-0x0000000189B094FC
		public bool SetRootPosition(GPUIHandle handle, Vector3 position) => default; // 0x0000000189B09764-0x0000000189B09868
		public bool SetRootScale(GPUIHandle handle, Vector2 scale) => default; // 0x0000000189B09868-0x0000000189B0994C
		[IDTag(0)]
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, string animationName, bool resetDestroy = false /* Metadata: 0x01FBC848 */) => default; // 0x0000000189B09B80-0x0000000189B09F84
		[IDTag(1)]
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, int animationIndex = 0 /* Metadata: 0x01FBC849 */, bool resetDestroy = false /* Metadata: 0x01FBC84A */) => default; // 0x0000000189B09F84-0x0000000189B0A1A4
		public bool SetVisibility(GPUIHandle handle, string nodeName, bool visible) => default; // 0x0000000189B09A80-0x0000000189B09B80
		public bool SetColor(GPUIHandle handle, string nodeName, UnityEngine.Color color) => default; // 0x0000000189B0960C-0x0000000189B09764
		public bool SetText(GPUIHandle handle, string nodeName, string text) => default; // 0x0000000189B0994C-0x0000000189B09A80
		protected override void OnDestroy() {} // 0x0000000189B094FC-0x0000000189B09558
		protected override void OnEnable() {} // 0x0000000183613B80-0x0000000183613C90
		protected override void OnDisable() {} // 0x0000000189B09558-0x0000000189B0960C
		protected override void OnPopulateMesh(VertexHelper vh) {} // 0x000000018398A460-0x000000018398A6C0
		protected override void UpdateMaterial() {} // 0x00000001837E2240-0x00000001837E2360
		private void _PreWillRenderCanvases() {} // 0x000000018289C290-0x000000018289C2D0
		private void _Init(string jsonPath) {} // 0x0000000183613CD0-0x0000000183614230
		protected TMP_FontAsset GetFontAsset() => default; // 0x0000000183614650-0x00000001836146D0
		private void _DoLateUpdate() {} // 0x000000018289C2D0-0x000000018289C390
		private void _DoOnDestroy() {} // 0x0000000189B0A3DC-0x0000000189B0A4E0
		private void _RefreshMaterials() {} // 0x0000000183614230-0x0000000183614580
		private void _InitMaterials() {} // 0x0000000183614B40-0x0000000183614E40
		private void _CleanMaterials() {} // 0x00000001836149B0-0x0000000183614B40
		private void _RenderNodes() {} // 0x000000018289C430-0x000000018289C520
		private void _DestroyAnimatedInstance() {} // 0x000000018289C390-0x000000018289C430
		private void _UpdateWorldMat() {} // 0x0000000183614E40-0x0000000183615180
		private void _PreloadTextInGroupData(PrefabGroupSerializeData data) {} // 0x0000000182AD7250-0x0000000182AD79D0
		private void _LoadGroupData(PrefabGroupSerializeData data) {} // 0x0000000182AD79D0-0x0000000182AD7FF0
		private RuntimePrefabData _LoadPrefabData(PrefabSerializeData prefab) => default; // 0x0000000182AD82F0-0x0000000182AD9170
		private int _LoadPrefabNodeBuffer(PrefabSerializeData prefab, int totalNodeCount) => default; // 0x0000000182AD91F0-0x0000000182AD9430
		private bool _CreateInstance(string prefabName, out GPUIHandle handle, int sortingOrder) {
			handle = default;
			return default;
		} // 0x0000000189B0A1C4-0x0000000189B0A300
		private bool _DestroyInstance(GPUIHandle handle) => default; // 0x0000000189B0A300-0x0000000189B0A3DC
		private GPUIHandle _GetOneHandle() => default; // 0x0000000189B0A4E0-0x0000000189B0A62C
		private bool _IsHandleInvalid(GPUIHandle handle) => default; // 0x0000000189B0A62C-0x0000000189B0A6E8
		private void _RecycleOneHandle(GPUIHandle handle) {} // 0x0000000189B0A6E8-0x0000000189B0A774
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000189B0A1A4-0x0000000189B0A1AC
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000189B0A1B4-0x0000000189B0A1BC
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000189B0A1AC-0x0000000189B0A1B4
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0) {} // 0x0000000189AADB34-0x0000000189AADB3C
		public void __iFixBaseProxy_UpdateMaterial() {} // 0x0000000189B0A1BC-0x0000000189B0A1C4
	}

	public static class GPUIUtils // TypeDefIndex: 49471
	{
		// Fields
		public static readonly Vector3 DEFAULT_NORMAL; // 0x00
		public static readonly Vector4 DEFAULT_TANGENT; // 0x0C
	
		// Constructors
		static GPUIUtils() {} // 0x0000000189B0AD30-0x0000000189B0AD98
	
		// Methods
		public static Mesh CreateQuadMesh() => default; // 0x0000000189B0A8F8-0x0000000189B0AD30
		public static uint ColorToRGBAUint32(UnityEngine.Color color) => default; // 0x0000000189B0A868-0x0000000189B0A8F8
	}

	internal class InstanceBufferManager : IDisposable // TypeDefIndex: 49473
	{
		// Fields
		private static readonly ProfilerMarker MARKER_UPDATE_PERF; // 0x00
		private NativeArray<CanvasRenderer.InstanceRange> m_gpuGroups; // 0x10
		private List<RuntimeInstance> m_runtimeInstanceView; // 0x20
		private List<BufferInternalNode> m_bufferInternalNodes; // 0x28
		private List<BufferInternalNode> m_pendingNodes; // 0x30
		private List<BufferInternalNode> m_addNodes; // 0x38
		private HashSet<GPUIHandle> m_removeNodes; // 0x40
		private bool m_hasAnyChanges; // 0x48
		private bool m_updateBufferOnly; // 0x49
		private int m_currentStartIndex; // 0x4C
		private int m_currentLength; // 0x50
		private int m_capacity; // 0x54
		private int m_maxCapacity; // 0x58
		private int m_nodeStride; // 0x5C
		private int m_gpuGroupCapacity; // 0x60
		private int m_groupCount; // 0x64
		private bool m_noSortingOrder; // 0x68
	
		// Properties
		public int startIndex { get => default; } // 0x0000000183D4EDF0-0x0000000183D4EE00 
		public int nodeCount { get => default; } // 0x0000000183D4EED0-0x0000000183D4EEE0 
		public int capacity { get => default; } // 0x0000000183D4EEC0-0x0000000183D4EED0 
		public NativeArray<CanvasRenderer.InstanceRange> gpuGroups { get => default; } // 0x0000000183D30AF0-0x0000000183D30B30 
		public int gpuGroupCount { get => default; } // 0x0000000183D50B30-0x0000000183D50B40 
	
		// Nested types
		private struct BufferInternalNode // TypeDefIndex: 49472
		{
			// Fields
			public GPUIHandle handle; // 0x00
			public int startIndex; // 0x08
			public int previousLength; // 0x0C
			public int sortingOrder; // 0x10
		}
	
		// Constructors
		public InstanceBufferManager() {} // Dummy constructor
		public InstanceBufferManager(int initCapacity, int maxCapacity, int nodeStride, int gpuGroupCapacity, bool noSortingOrder) {} // 0x0000000183614710-0x0000000183614880
		static InstanceBufferManager() {} // 0x0000000183D06F50-0x0000000183D06FB0
	
		// Methods
		public void BindInstanceList(List<RuntimeInstance> runtimeInstanceView) {} // 0x00000001836146D0-0x0000000183614710
		public void MarkNeedUpdate() {} // 0x0000000189B0B6C0-0x0000000189B0B710
		private void _FillInstanceQueue(ref NativeArray<GPUInstanceData> oldBuffer, out int newTotalLength, out int newTotalLengthWithEmptySlot, out int fullUpdateIndex) {
			newTotalLength = default;
			newTotalLengthWithEmptySlot = default;
			fullUpdateIndex = default;
		} // 0x0000000189B0B7A0-0x0000000189B0BE48
		public void DoUpdate(CanvasRenderer canvasRenderer) {} // 0x000000018289B0D0-0x000000018289C290
		private void _NewGpuGroup(int start, int end) {} // 0x0000000189B08FA8-0x0000000189B08FD0
		public void Add(GPUIHandle instance) {} // 0x0000000189B0B410-0x0000000189B0B638
		public void Remove(GPUIHandle instance) {} // 0x0000000189B0B710-0x0000000189B0B7A0
		private void _AllocBuffer(int capacity) {} // 0x0000000183614880-0x0000000183614950
		public void Dispose() {} // 0x0000000189B0B638-0x0000000189B0B6C0
	}

	internal class RuntimeInstance // TypeDefIndex: 49474
	{
		// Fields
		public const int ROOT_NODE_INDEX = 0; // Metadata: 0x01FBC84C
		public int version; // 0x10
		public ChangeState state; // 0x14
		public int length; // 0x18
		public int sortingOrder; // 0x1C
		private ITextSystem m_textSystem; // 0x20
		private RuntimePrefabData m_prefab; // 0x28
		private RuntimeAnimationData m_animationData; // 0x30
		private int m_prefabNodeOffset; // 0x38
		private RuntimeNodeInfo[] m_nodeInfo; // 0x40
		private int m_nodeInfoCount; // 0x48
		private float m_animationDuration; // 0x4C
		private float m_animationTime; // 0x50
		private Vector2 m_rootScale; // 0x54
	
		// Properties
		public RuntimePrefabData Prefab { get => default; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		public float AnimationDuration { get => default; } // 0x0000000183D50200-0x0000000183D50210 
	
		// Constructors
		public RuntimeInstance() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Create(RuntimePrefabData prefab, ITextSystem textSystem) {} // 0x0000000189B0BE48-0x0000000189B0BFF0
		public void Recycle() {} // 0x0000000189B0C354-0x0000000189B0C3A8
		public void DoUpdate(ref NativeArray<GPUInstanceData> buffer, int startIndexInBuffer, bool full) {} // 0x0000000189B0BFF0-0x0000000189B0C354
		public void SetRootScale(Vector2 rootScale) {} // 0x0000000189B0C548-0x0000000189B0C5AC
		public void SetPosition(int index, Vector3 position) {} // 0x0000000189B0C480-0x0000000189B0C548
		public void StartAnimation(float animationTime, int animationIndex = 0 /* Metadata: 0x01FBC84B */) {} // 0x0000000189B0C7BC-0x0000000189B0C888
		public void SetVisibility(int index, bool visible) {} // 0x0000000189B0C738-0x0000000189B0C7BC
		public void SetColor(int index, UnityEngine.Color newColor) {} // 0x0000000189B0C3A8-0x0000000189B0C480
		public void SetText(int index, string text) {} // 0x0000000189B0C5AC-0x0000000189B0C738
	}

	internal class SimpleBufferManager<T> : IDisposable // TypeDefIndex: 49475
		where T : struct
	{
		// Fields
		private int m_objectSize;
		private int m_count;
		private int m_capacity;
		private bool m_isFrozen;
		private int m_writingRef;
		private CanvasRenderer m_canvasRenderer;
		private NativeArray<T> m_cpuArray;
	
		// Properties
		public NativeArray<T> cpuArray { get => default; }
	
		// Constructors
		public SimpleBufferManager() {} // Dummy constructor
		public SimpleBufferManager(int initCapacity, CanvasRenderer canvasRenderer) {}
	
		// Methods
		public void Dispose() {}
		public void Reset() {}
		public void OpenWrite() {}
		public void Freeze() {}
		public bool Allocate(int size, out int index) {
			index = default;
			return default;
		}
		private void _Resize(int desiredCapacity) {}
	}

	internal class CodePoint // TypeDefIndex: 49476
	{
		// Fields
		public const uint HIGH_SURROGATE_START = 55296; // Metadata: 0x01FBC84D
		public const uint HIGH_SURROGATE_END = 56319; // Metadata: 0x01FBC851
		public const uint LOW_SURROGATE_START = 56320; // Metadata: 0x01FBC855
		public const uint LOW_SURROGATE_END = 57343; // Metadata: 0x01FBC859
		public const uint UNICODE_PLANE01_START = 65536; // Metadata: 0x01FBC85D
	
		// Constructors
		public CodePoint() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) => default; // 0x0000000189B08FD0-0x0000000189B09030
	}

	internal interface ITextSystem // TypeDefIndex: 49477
	{
		// Methods
		void RegisterCharacterToPrefabBuffer(string text);
		void UploadBufferIfNeeded();
		int GetNodeCount(string text);
		void CreateTextNodes(string text, NativeArray<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment);
		void CreateTextNodes(string text, List<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment);
	}

	internal class SimpleTextSystem<T> : ITextSystem // TypeDefIndex: 49479
		where T : struct
	{
		// Fields
		public const float DEFAULT_WHITESPACE_SPACING = 0.27f; // Metadata: 0x01FBC861
		private TMP_FontAsset m_fontAsset;
		private Material m_tmpMaterial;
		private SimpleBufferManager<T> m_prefabBufferManager;
		private float m_padding;
		private Vector2 m_texelSizeInv;
		private readonly List<T> m_dynamicBufferCache;
		private readonly Dictionary<uint, int> m_charCodeToIndexMap;
		private readonly List<CharOffsetData> m_tempOffsetCache;
		private readonly Dictionary<uint, CharOffsetData> m_charaOffsetCache;
		private readonly int m_fontBufferCapacity;
		private readonly bool m_liteMode;
		private bool m_isThaiMode;
		private int m_prefabDestIndex;
		private int m_fontBufferCount;
		private readonly Func<Vector4, Vector4, Vector2, T> m_creatorFunc;
	
		// Nested types
		private struct CharOffsetData // TypeDefIndex: 49478
		{
			// Fields
			public float scale;
			public float xAdvance;
			public float xOffset;
			public float yOffset;
			public int prefabIndex;
		}
	
		// Constructors
		public SimpleTextSystem() {} // Dummy constructor
		public SimpleTextSystem(int fontBufferCapacity, Func<Vector4, Vector4, Vector2, T> creatorFunc) {}
	
		// Methods
		public void Init(TMP_FontAsset fontAsset, Material tmpMaterial, SimpleBufferManager<T> simpleBufferManager, bool isThaiMode) {}
		public void RegisterCharacterToPrefabBuffer(string text) {}
		public int GetNodeCount(string text) => default;
		public void UploadBufferIfNeeded() {}
		public void CreateTextNodes(string text, NativeArray<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment) {}
		public void CreateTextNodes(string text, List<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment) {}
		private void _DoTextAlignAndDynamicBuffer(string text, SimpleTextAlignment alignment, out float currentX) {
			currentX = default;
		}
		private void _LoadAllCharacterToPrefabBuffer(string text) {}
		private int _PutOneCharacterToPrefabBufferDynamic(uint c) => default;
		private void _UploadBufferIfNeeded() {}
		private void _InitPrefabDataByTMPCharacter(TMP_Character character, out ref T prefabData) {
			prefabData = default;
		}
		protected static bool IsUpVowel(char c) => default;
		protected static bool IsLowVowel(char c) => default;
		protected static bool IsToneMark(char c) => default;
		protected static bool IsAscenderThai(char c) => default;
		protected static bool IsDescenderThai(char c) => default;
	}
}

namespace Beyond.UI.UIState
{
	internal class OnValueChangedAttribute : PropertyAttribute // TypeDefIndex: 49436
	{
		// Properties
		public string actionName { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public OnValueChangedAttribute() {} // Dummy constructor
		public OnValueChangedAttribute(string name) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public class StateAnimationInfo // TypeDefIndex: 49437
	{
		// Fields
		private readonly float m_duration; // 0x2C
	
		// Properties
		public bool IsFinished { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		public AnimationClip Clip { get; } // 0x0000000181041090-0x00000001810410A0 
		public GameObject Target { get; } // 0x0000000183D4EB40-0x0000000183D4EB50 
		public float StartTime { get; private set; } // 0x0000000183D4F480-0x0000000183D4F490 0x0000000183D4F490-0x0000000183D4F4A0
	
		// Constructors
		public StateAnimationInfo() {} // Dummy constructor
		public StateAnimationInfo(AnimationClip clip, GameObject target) {} // 0x0000000182CD1CB0-0x0000000182CD1D10
	
		// Methods
		public void OnUpdate() {} // 0x0000000189AF031C-0x0000000189AF03CC
	}

	public enum AnimationImpactType // TypeDefIndex: 49438
	{
		StartAnimation = 0,
		StopAnimation = 1
	}

	[Serializable]
	public class StateDescription // TypeDefIndex: 49439
	{
		// Fields
		public AnimationImpactType animationImpactType; // 0x10
		public AnimationClip animationClip; // 0x18
		public GameObject animationTarget; // 0x20
		public Animator animator; // 0x28
		public AnimatorImpactType animImpact; // 0x30
		public string animParamSetBoolTrue; // 0x38
		public string animParamSetBoolFalse; // 0x40
		public string animParamSetTrigger; // 0x48
		public string animParamResetTrigger; // 0x50
		public string animParamSetInteger; // 0x58
		public int animParamSetIntegerValue; // 0x60
		public string animParamSetFloat; // 0x68
		public int animParamSetFloatValue; // 0x70
		public UIButton button; // 0x78
		public bool buttonInteractable; // 0x80
		public CanvasGroup canvasGroup; // 0x88
		public CanvasGroupImpactType canvasGroupImpactType; // 0x90
		public float canvasGroupAlpha; // 0x94
		public bool canvasGroupInteractable; // 0x98
		public UnityEngine.Color canvasGroupColor; // 0x9C
		public UnityEngine.Behaviour component; // 0xB0
		public bool componentIsEnabled; // 0xB8
		public StateDescriptionTargetType targetType; // 0xBC
		public GameObject gameObject; // 0xC0
		public bool gameObjectIsActive; // 0xC8
		public Graphic graphic; // 0xD0
		public Material graphicMaterial; // 0xD8
		[OnValueChanged("_OnGridLayoutGroupChanged")]
		public GridLayoutGroup gridLayoutGroup; // 0xE0
		public GridLayoutGroupImpactType gridLayoutGroupImpactType; // 0xE8
		public RectOffset gridLayoutGroupPadding; // 0xF0
		public Vector2 gridLayoutGroupSpacing; // 0xF8
		public Vector2 gridLayoutGroupCellSize; // 0x100
		public int gridLayoutConstraintCount; // 0x108
		[OnValueChanged("_OnImageChanged")]
		public UIImage image; // 0x110
		public ImageImpactType imageImpact; // 0x118
		public bool imageEnabled; // 0x11C
		public Sprite imageSetSprite; // 0x120
		public UnityEngine.Color imageSetColor; // 0x128
		public string imageSetMaterialFloatParam; // 0x138
		public float imageSetMaterialFloatValue; // 0x140
		[OnValueChanged("_OnLayoutElementChanged")]
		public LayoutElement layoutElement; // 0x150
		public LayoutElementImpactType layoutElementImpactType; // 0x158
		public float layoutElementPreferredWidth; // 0x15C
		public float layoutElementPreferredHeight; // 0x160
		public float layoutElementMinWidth; // 0x164
		public float layoutElementMinHeight; // 0x168
		public float layoutElementFlexibleWidth; // 0x16C
		public float layoutElementFlexibleHeight; // 0x170
		[OnValueChanged("_OnLayoutGroupChanged")]
		public HorizontalOrVerticalLayoutGroup layoutGroup; // 0x178
		public LayoutGroupImpactType layoutGroupImpactType; // 0x180
		public RectOffset layoutGroupPadding; // 0x188
		public float layoutGroupSpacing; // 0x190
		public TextAnchor layoutGroupChildAlignment; // 0x194
		public bool layoutGroupReverseArrangement; // 0x198
		[OnValueChanged("_OnRectTransformChanged")]
		public RectTransform rectTransform; // 0x1A0
		public RectTransformImpactType rectTransformImpactType; // 0x1A8
		public Vector2 rectTransformPosition; // 0x1AC
		public Vector2 rectTransformSize; // 0x1B4
		public Vector3 rectTransformRotation; // 0x1BC
		public Vector3 rectTransformScale; // 0x1C8
		public float rectTransformWidth; // 0x1D4
		public float rectTransformHeight; // 0x1D8
		public float rectTransformTop; // 0x1DC
		public float rectTransformBottom; // 0x1E0
		public float rectTransformLeft; // 0x1E4
		public float rectTransformRight; // 0x1E8
		public Vector2 rectTransformAnchorMin; // 0x1EC
		public Vector2 rectTransformAnchorMax; // 0x1F4
		public Vector2 rectTransformPivot; // 0x1FC
		[OnValueChanged("_OnScrollListChanged")]
		public UIScrollList scrollList; // 0x208
		public ScrollListImpactType scrollListImpactType; // 0x210
		public UIScrollList.Padding scrollListPadding; // 0x214
		public UIStateController uiStateController; // 0x228
		public string stateName; // 0x230
		[OnValueChanged("_OnTextChanged")]
		public UIText text; // 0x238
		public TextImpactType textImpact; // 0x240
		public UnityEngine.Color textColor; // 0x244
		public string textId; // 0x258
		public float textFontSize; // 0x260
		public float textMaxFontSize; // 0x264
		public HorizontalAlignmentOptions textHorizontalAlignment; // 0x268
	
		// Properties
		public bool IsEmpty { get => default; } // 0x0000000182CD47B0-0x0000000182CD49C0 
		public string ReadableDescription { get => default; } // 0x0000000189AF21D0-0x0000000189AF333C 
		public Material ImageMaterialClone { get; set; } // 0x0000000183D571B0-0x0000000183D571C0 0x00000001858B3DA8-0x00000001858B3DBC
	
		// Constructors
		public StateDescription() {} // 0x0000000183162130-0x0000000183162170
	
		// Methods
		public bool EqualsAnimation(StateDescription other) => default; // 0x0000000189AF08F0-0x0000000189AF0988
		public float ApplyAnimation(StateReference state) => default; // 0x0000000182CD1D10-0x0000000182CD1E00
		public bool EqualsAnimator(StateDescription other) => default; // 0x0000000189AF0988-0x0000000189AF0A20
		public void ApplyAnimator() {} // 0x0000000189AF03CC-0x0000000189AF04F0
		public bool EqualsButton(StateDescription other) => default; // 0x0000000189AF0A20-0x0000000189AF0AB8
		public void ApplyButton() {} // 0x0000000189AF04F0-0x0000000189AF0550
		public bool EqualsCanvasGroup(StateDescription other) => default; // 0x0000000189AF0AB8-0x0000000189AF0B58
		public void ApplyCanvasGroup() {} // 0x0000000183D06C50-0x0000000183D06CB0
		public bool EqualsComponent(StateDescription other) => default; // 0x0000000189AF0B58-0x0000000189AF0BF8
		public void ApplyComponent() {} // 0x0000000189AF0550-0x0000000189AF05B4
		public override string ToString() => default; // 0x0000000189AF13B8-0x0000000189AF144C
		public static bool operator ==(StateDescription left, StateDescription right) => default; // 0x0000000189AF333C-0x0000000189AF33B8
		public static bool operator !=(StateDescription left, StateDescription right) => default; // 0x0000000189AF33B8-0x0000000189AF3420
		[IDTag(1)]
		public override bool Equals(object obj) => default; // 0x0000000189AF12C4-0x0000000189AF1354
		public override int GetHashCode() => default; // 0x0000000189AF1354-0x0000000189AF13B8
		[IDTag(0)]
		public bool Equals(StateDescription other) => default; // 0x0000000189AF1238-0x0000000189AF12C4
		private bool _EqualsByTargetType(StateDescription other) => default; // 0x0000000189AF144C-0x0000000189AF1678
		private int _GetTargetHashCode() => default; // 0x0000000189AF1678-0x0000000189AF1758
		public bool EqualsGameObject(StateDescription other) => default; // 0x0000000189AF0BF8-0x0000000189AF0C98
		public void ApplyGameObject() {} // 0x0000000182CD49C0-0x0000000182CD4A10
		public bool EqualsGraphic(StateDescription other) => default; // 0x0000000189AF0C98-0x0000000189AF0D38
		public void ApplyGraphic() {} // 0x0000000189AF05B4-0x0000000189AF061C
		public bool EqualsGridLayoutGroup(StateDescription other) => default; // 0x0000000189AF0D38-0x0000000189AF0DD8
		public void ApplyGridLayoutGroup() {} // 0x0000000189AF061C-0x0000000189AF0770
		private void _OnGridLayoutGroupChanged() {} // 0x0000000189AF1758-0x0000000189AF1868
		public bool EqualsImage(StateDescription other) => default; // 0x0000000189AF0DD8-0x0000000189AF0E78
		public void ApplyImage() {} // 0x0000000182CD4D70-0x0000000182CD4E60
		private void _OnImageChanged() {} // 0x0000000189AF1868-0x0000000189AF19BC
		public bool EqualsLayoutElement(StateDescription other) => default; // 0x0000000189AF0E78-0x0000000189AF0F18
		public void ApplyLayoutElement() {} // 0x0000000182CD1950-0x0000000182CD1A00
		private void _OnLayoutElementChanged() {} // 0x0000000189AF19BC-0x0000000189AF1A88
		public bool EqualsLayoutGroup(StateDescription other) => default; // 0x0000000189AF0F18-0x0000000189AF0FB8
		public void ApplyLayoutGroup() {} // 0x0000000182CD1160-0x0000000182CD1220
		private void _OnLayoutGroupChanged() {} // 0x0000000189AF1A88-0x0000000189AF1B80
		public bool EqualsRectTransform(StateDescription other) => default; // 0x0000000189AF0FB8-0x0000000189AF1058
		public void ApplyRectTransform() {} // 0x0000000182CD4A10-0x0000000182CD4D70
		private void _OnRectTransformChanged() {} // 0x0000000189AF1B80-0x0000000189AF203C
		public bool EqualsScrollList(StateDescription other) => default; // 0x0000000189AF1058-0x0000000189AF10F8
		public void ApplyScrollList() {} // 0x0000000189AF07D8-0x0000000189AF08F0
		private void _OnScrollListChanged() {} // 0x0000000189AF203C-0x0000000189AF20F0
		public bool EqualsState(StateDescription other) => default; // 0x0000000189AF10F8-0x0000000189AF1198
		public float ApplyInnerState() => default; // 0x0000000189AF0770-0x0000000189AF07D8
		public bool EqualsText(StateDescription other) => default; // 0x0000000189AF1198-0x0000000189AF1238
		public void ApplyText() {} // 0x0000000182CD1E00-0x0000000182CD1F50
		private void _OnTextChanged() {} // 0x0000000189AF20F0-0x0000000189AF21D0
		public string __iFixBaseProxy_ToString() => default; // 0x0000000185459F38-0x0000000185459F40
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018232CE30-0x000000018232CE40
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000183D4F970-0x0000000183D4F980
	}

	public enum AnimatorImpactType // TypeDefIndex: 49440
	{
		SetBoolTrue = 0,
		SetBoolFalse = 1,
		SetTrigger = 2,
		ResetTrigger = 3,
		SetInteger = 4,
		SetFloat = 5
	}

	public enum CanvasGroupImpactType // TypeDefIndex: 49441
	{
		SetAlpha = 0,
		SetInteractable = 1,
		SetColor = 2
	}

	public enum StateDescriptionTargetType // TypeDefIndex: 49442
	{
		GameObject = 0,
		Animator = 1,
		Image = 2,
		Text = 3,
		RectTransform = 4,
		Button = 5,
		CanvasGroup = 6,
		Animation = 7,
		State = 8,
		LayoutElement = 9,
		Component = 10,
		Graphic = 11,
		LayoutGroup = 12,
		ScrollList = 13,
		GridLayoutGroup = 14
	}

	public enum GridLayoutGroupImpactType // TypeDefIndex: 49443
	{
		Padding = 0,
		Spacing = 1,
		CellSize = 2,
		ConstraintCount = 3
	}

	public enum ImageImpactType // TypeDefIndex: 49444
	{
		SetEnabled = 0,
		SetSprite = 1,
		SetColor = 2,
		SetMaterialFloatValue = 3
	}

	public enum LayoutElementImpactType // TypeDefIndex: 49445
	{
		LayoutElementPreferredWidth = 0,
		LayoutElementPreferredHeight = 1,
		LayoutElementMinWidth = 2,
		LayoutElementMinHeight = 3,
		LayoutElementFlexibleWidth = 4,
		LayoutElementFlexibleHeight = 5
	}

	public enum LayoutGroupImpactType // TypeDefIndex: 49446
	{
		Padding = 0,
		Spacing = 1,
		ChildAlignment = 2,
		ReverseArrangement = 3
	}

	public enum RectTransformImpactType // TypeDefIndex: 49447
	{
		Undefined = -1,
		SetPosition = 0,
		SetSize = 1,
		SetRotation = 2,
		SetScale = 3,
		SetWidth = 4,
		SetHeight = 5,
		SetTop = 6,
		SetBottom = 7,
		SetLeft = 8,
		SetRight = 9,
		SetAnchors = 10,
		SetPivot = 11,
		ForceRebuildLayout = 12
	}

	public enum ScrollListImpactType // TypeDefIndex: 49448
	{
		Padding = 0
	}

	public enum TextImpactType // TypeDefIndex: 49449
	{
		SetColor = 0,
		SetTextById = 1,
		SetFontSize = 2,
		SetHorizontalAlignment = 3,
		SetMaxFontSize = 4
	}

	[Serializable]
	public class StateReference // TypeDefIndex: 49450
	{
		// Fields
		public string stateName; // 0x10
		public List<StateDescription> descriptions; // 0x18
		private List<StateAnimationInfo> m_scheduledForPlaying; // 0x20
		private List<StateAnimationInfo> m_scheduledForStopping; // 0x28
		private UIStateController m_controller; // 0x30
		private bool m_isDirty; // 0x38
	
		// Constructors
		public StateReference() {} // 0x00000001828462E0-0x00000001828463E0
	
		// Methods
		public void SetController(UIStateController controller) {} // 0x0000000182CD2CF0-0x0000000182CD2D30
		public void ScheduleForPlaying(StateAnimationInfo stateAnimationInfo) {} // 0x0000000189B0C888-0x0000000189B0C928
		public void ScheduleForStopping(StateAnimationInfo stateAnimationInfo) {} // 0x0000000182CD1C00-0x0000000182CD1C80
		public void HandleScheduledStates() {} // 0x0000000183304130-0x00000001833043B0
	}

	[ExecuteAlways]
	public class UIStateController : TickableUIMono // TypeDefIndex: 49452
	{
		// Fields
		public List<StateReference> states; // 0x68
		private readonly List<StateAnimationInfo> m_animations; // 0x78
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000183D55800-0x0000000183D55810 
		public string currentStateName { get; private set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
	
		// Constructors
		public UIStateController() {} // 0x0000000182846210-0x00000001828462E0
	
		// Methods
		public void OnStateReferenceDirty() {} // 0x0000000182CD1C80-0x0000000182CD1CB0
		public float SetState(string stateName, bool forceUpdate = true /* Metadata: 0x01FBC83C */) => default; // 0x0000000182CD2D30-0x0000000182CD2E50
		private float _ApplyState(StateReference state) => default; // 0x0000000182CD2E50-0x0000000182CD47B0
		public override void Tick(float deltaTime) {} // 0x00000001833030C0-0x00000001833040E0
		private void _HandleStateAnimations(StateReference stateReference) {} // 0x00000001833040E0-0x0000000183304130
		public void Run(StateAnimationInfo newInfo) {} // 0x0000000189B0CB38-0x0000000189B0CD6C
		public void Stop(StateAnimationInfo newInfo) {} // 0x0000000183302D90-0x00000001833030C0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018577D7BC-0x000000018577D7C4
	}

	public static class UIStateControllerUtils // TypeDefIndex: 49453
	{
		// Fields
		private static float s_updateFinishTime; // 0x00
	
		// Methods
		public static void StartEditorUpdateLoop(float duration) {} // 0x0000000189B0CAEC-0x0000000189B0CB38
	
		// Extension methods
		public static void ForceRebuildLayout(this GameObject gameObject) {} // 0x0000000189B0C940-0x0000000189B0CA40
		public static void SetLeft(this RectTransform rt, float left) {} // 0x0000000182CD4E60-0x0000000182CD4ED0
		public static void SetRight(this RectTransform rt, float right) {} // 0x0000000182CD5060-0x0000000182CD50D0
		public static void SetTop(this RectTransform rt, float top) {} // 0x0000000182CD5580-0x0000000182CD55F0
		public static void SetBottom(this RectTransform rt, float bottom) {} // 0x0000000182CD5290-0x0000000182CD5300
		public static string GetName(this UnityEngine.Object obj) => default; // 0x0000000189B0CA40-0x0000000189B0CAEC
	}
}

namespace Cysharp.Text
{
	public static class TextMeshProExtensions // TypeDefIndex: 49132
	{
		// Extension methods
		public static void SetText<T>(this TMP_Text text, T arg0) {}
		public static void SetTextFormat<T0>(this TMP_Text text, string format, T0 arg0) {}
		public static void SetTextFormat<T0, T1>(this TMP_Text text, string format, T0 arg0, T1 arg1) {}
		public static void SetTextFormat<T0, T1, T2>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2) {}
		public static void SetTextFormat<T0, T1, T2, T3>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) {}
		public static void SetText(this TMP_Text text, Utf16ValueStringBuilder stringBuilder) {} // 0x0000000189AAF6CC-0x0000000189AAF7A4
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 49131
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 49482
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000183020510-0x0000000183020540
		static ILFixDynamicMethodWrapper() {} // 0x0000000183D06050-0x0000000183D060C0
	
		// Methods
		public void __Gen_Wrap_0() {} // 0x00000001850F3444-0x00000001850F34E0
		public void __Gen_Wrap_1(object P0) {} // 0x0000000184274234-0x00000001842742F4
		public float __Gen_Wrap_2(object P0, bool P1) => default; // 0x00000001888B576C-0x00000001888B5858
		public float __Gen_Wrap_3(object P0) => default; // 0x00000001854AB08C-0x00000001854AB15C
		public LuaPanel __Gen_Wrap_4(object P0) => default; // 0x0000000189B067AC-0x0000000189B0689C
		public void __Gen_Wrap_5(object P0, object P1, bool P2) {} // 0x00000001854790D0-0x00000001854791C8
		public void __Gen_Wrap_6(object P0, float P1) {} // 0x00000001850F0008-0x00000001850F00E8
		public string __Gen_Wrap_7(object P0, int P1, out bool P2) {
			P2 = default;
			return default;
		} // 0x0000000189B08018-0x0000000189B08160
		public bool __Gen_Wrap_8(object P0, object P1) => default; // 0x0000000185153920-0x0000000185153A0C
		public UIText.HyperlinkUITextGroup __Gen_Wrap_9(object P0, object P1, bool P2) => default; // 0x0000000189B08E80-0x0000000189B08FA8
		public void __Gen_Wrap_10(object P0, object P1) {} // 0x0000000185163BA0-0x0000000185163C7C
		public string __Gen_Wrap_11(PhoneticType P0, object P1) => default; // 0x0000000189AFA534-0x0000000189AFA62C
		public void __Gen_Wrap_12(object P0, PhoneticType P1, object P2) {} // 0x000000018560138C-0x0000000185601470
		public void __Gen_Wrap_13(EnvLang P0) {} // 0x000000018514E3FC-0x000000018514E4BC
		public bool __Gen_Wrap_14(object P0, object P1, out string P2) {
			P2 = default;
			return default;
		} // 0x0000000189AFBE98-0x0000000189AFBFE8
		public bool __Gen_Wrap_15(object P0, Vector3 P1, out string P2) {
			P2 = default;
			return default;
		} // 0x0000000189AFC9B8-0x0000000189AFCB34
		public IEnumerator __Gen_Wrap_16(object P0) => default; // 0x0000000189AFD430-0x0000000189AFD520
		public string __Gen_Wrap_17(object P0, bool P1) => default; // 0x0000000189AFDA54-0x0000000189AFDB60
		public Sprite __Gen_Wrap_18(object P0, object P1) => default; // 0x0000000189AFE234-0x0000000189AFE340
		public int __Gen_Wrap_19(ReadOnlySpan<char> P0) => default; // 0x0000000189AFE9D0-0x0000000189AFEAD8
		public UIText.RichTextInfo __Gen_Wrap_20(UIText.RichTextAnalyzer.RichTextParam P0, object P1, ref Utf16ValueStringBuilder P2) => default; // 0x0000000189AFF02C-0x0000000189AFF1EC
		public UIText.RichTextInfo __Gen_Wrap_21(object P0, UIText.RichTextAnalyzer.RichTextParam P1, object P2, ref Utf16ValueStringBuilder P3) => default; // 0x0000000189AFF990-0x0000000189AFFB50
		public UIText.RichTextAnalyzer.ProcessRichTextEntryFunc __Gen_Wrap_22(object P0) => default; // 0x0000000189B000D0-0x0000000189B001C0
		public bool __Gen_Wrap_23(ReadOnlySpan<char> P0, out bool P1, out UIText.RichTextAnalyzer.RichTextParam P2) {
			P1 = default;
			P2 = default;
			return default;
		} // 0x0000000189B00A68-0x0000000189B00C10
		public bool __Gen_Wrap_24(ReadOnlySpan<char> P0, ref Utf16ValueStringBuilder P1, object P2, out UIText.RichTextInfo P3) {
			P3 = default;
			return default;
		} // 0x0000000189B016B8-0x0000000189B018A8
		public string __Gen_Wrap_25(object P0, object P1, out List<UIText.RichTextInfo> P2) {
			P2 = default;
			return default;
		} // 0x0000000189B0264C-0x0000000189B027B0
		public GameObject __Gen_Wrap_26(object P0) => default; // 0x0000000189B031F4-0x0000000189B032E4
		public UIText.ImageGOInfo __Gen_Wrap_27(object P0, int P1) => default; // 0x0000000189B03D64-0x0000000189B03E94
		public Material __Gen_Wrap_28(object P0) => default; // 0x0000000189B04AC4-0x0000000189B04BA0
		public Material __Gen_Wrap_29(object P0, object P1) => default; // 0x0000000189B05754-0x0000000189B05860
		public bool __Gen_Wrap_30() => default; // 0x000000018514F380-0x000000018514F42C
		public I18nFontSearchData __Gen_Wrap_31() => default; // 0x0000000189B05B1C-0x0000000189B05BE8
		public bool __Gen_Wrap_32(object P0) => default; // 0x000000018514EF5C-0x000000018514F02C
		public TMP_FontAsset __Gen_Wrap_33(int P0) => default; // 0x0000000189B05BE8-0x0000000189B05CD4
		public TMP_FontAsset __Gen_Wrap_34(object P0) => default; // 0x0000000189B05CD4-0x0000000189B05DC4
		public void __Gen_Wrap_35(object P0, object P1, object P2, int P3) {} // 0x00000001856479C0-0x0000000185647AB8
		public void __Gen_Wrap_36(object P0, object P1, int P2) {} // 0x00000001854A1028-0x00000001854A1120
		public bool __Gen_Wrap_37(object P0, int P1, out string P2) {
			P2 = default;
			return default;
		} // 0x0000000189B05DC4-0x0000000189B05F04
		public bool __Gen_Wrap_38(object P0, int P1, out Vector3 P2, out float P3) {
			P2 = default;
			P3 = default;
			return default;
		} // 0x0000000189B05F04-0x0000000189B06084
		public void __Gen_Wrap_39(object P0, object P1, object P2) {} // 0x0000000185150B1C-0x0000000185150C14
		public int __Gen_Wrap_40(UIText.HyperlinkUITextWrap P0, UIText.HyperlinkUITextWrap P1) => default; // 0x00000001850EF354-0x00000001850EF42C
		public List<UIText> __Gen_Wrap_41(object P0, object P1) => default; // 0x0000000189B06084-0x0000000189B0617C
		public List<UIText> __Gen_Wrap_42(object P0) => default; // 0x0000000189B0617C-0x0000000189B06258
		public int __Gen_Wrap_43(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public TMP_SubMeshUI __Gen_Wrap_44(object P0, object P1, MaterialReference P2) => default; // 0x0000000189B06258-0x0000000189B063BC
		public string __Gen_Wrap_45(int P0) => default; // 0x0000000189B063BC-0x0000000189B064A8
		public float __Gen_Wrap_46() => default; // 0x00000001856409AC-0x0000000185640A58
		public GameObject __Gen_Wrap_47(object P0, object P1, object P2) => default; // 0x0000000189B064A8-0x0000000189B065BC
		public void __Gen_Wrap_48(FAssetProxyUntrackedHandle P0) {} // 0x0000000189B065BC-0x0000000189B066A4
		public int __Gen_Wrap_49(object P0, object P1, object P2, object P3) => default; // 0x0000000189B066A4-0x0000000189B067AC
		public void __Gen_Wrap_50(object P0, int P1) {} // 0x000000018549D548-0x000000018549D624
		public bool __Gen_Wrap_51(Vector3 P0, object P1, object P2) => default; // 0x0000000189B0689C-0x0000000189B069E0
		public bool __Gen_Wrap_52(Vector2 P0, object P1, object P2) => default; // 0x0000000189B069E0-0x0000000189B06B1C
		public Bounds __Gen_Wrap_53(object P0, object P1) => default; // 0x0000000189B06B1C-0x0000000189B06C3C
		public bool __Gen_Wrap_54(int P0, out UnityEngine.InputSystem.EnhancedTouch.Touch P1) {
			P1 = default;
			return default;
		} // 0x0000000189B06C3C-0x0000000189B06D84
		public void __Gen_Wrap_55(object P0, UnityEngine.Color P1) {} // 0x0000000189B06D84-0x0000000189B06E98
		public Rect __Gen_Wrap_56(object P0, object P1) => default; // 0x0000000189B06E98-0x0000000189B06FC0
		public Vector3 __Gen_Wrap_57(object P0, object P1) => default; // 0x0000000189B06FC0-0x0000000189B070E0
		public UnityEngine.Color __Gen_Wrap_58(object P0) => default; // 0x0000000189B070E0-0x0000000189B071D8
		public float __Gen_Wrap_59(float P0) => default; // 0x000000018871ACD8-0x000000018871ADA8
		public void __Gen_Wrap_60(object P0, object P1, CinemachineCore.Stage P2, ref CameraState P3, float P4) {} // 0x0000000189B071D8-0x0000000189B0743C
		public int __Gen_Wrap_61(object P0, int P1) => default; // 0x00000001854761A8-0x0000000185476294
		public Vector2 __Gen_Wrap_62(object P0, int P1) => default; // 0x0000000189B0743C-0x0000000189B07534
		public Vector2 __Gen_Wrap_63() => default; // 0x0000000189B07534-0x0000000189B075EC
		public void __Gen_Wrap_64(Vector2 P0) {} // 0x0000000189B075EC-0x0000000189B076D4
		public void __Gen_Wrap_65(object P0, int P1, bool P2) {} // 0x0000000185610058-0x000000018561013C
		public Vector2Int __Gen_Wrap_66(object P0, float P1, bool P2) => default; // 0x0000000189B076D4-0x0000000189B077FC
		public Vector2Int __Gen_Wrap_67(object P0) => default; // 0x0000000189B077FC-0x0000000189B078EC
		public UIScrollList.Cell __Gen_Wrap_68(object P0) => default; // 0x0000000189B078EC-0x0000000189B079DC
		public void __Gen_Wrap_69(object P0, bool P1) {} // 0x0000000185477860-0x000000018547793C
		public UnityEngine.AnimationState __Gen_Wrap_70(object P0, object P1) => default; // 0x0000000189B079DC-0x0000000189B07AE8
		public void __Gen_Wrap_71(object P0, object P1, float P2) {} // 0x0000000185E7B3B0-0x0000000185E7B4AC
		public void __Gen_Wrap_72(object P0, object P1, float P2, bool P3) {} // 0x0000000185E612B8-0x0000000185E613C0
		public void __Gen_Wrap_73(object P0, object P1, object P2, UIConst.AnimationState P3, float P4) {} // 0x0000000189B07AE8-0x0000000189B07C00
		public void __Gen_Wrap_74(object P0, int P1, bool P2, bool P3) {} // 0x0000000189B07C00-0x0000000189B07D08
		public void __Gen_Wrap_75(object P0, bool P1, bool P2, bool P3) {} // 0x0000000185E5ABBC-0x0000000185E5ACC4
		public UIScrollList.MoveTipsType __Gen_Wrap_76(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public void __Gen_Wrap_77(object P0, Vector2 P1) {} // 0x0000000189B07D08-0x0000000189B07E1C
		public void __Gen_Wrap_78(object P0, int P1, bool P2, UIScrollList.ScrollAlignType P3, bool P4) {} // 0x0000000189B07E1C-0x0000000189B07F28
		public UIText __Gen_Wrap_79(object P0) => default; // 0x0000000189B07F28-0x0000000189B08018
		public string __Gen_Wrap_80(object P0) => default; // 0x0000000189B08160-0x0000000189B08250
		public Sprite __Gen_Wrap_81(object P0) => default; // 0x0000000189B08250-0x0000000189B0832C
		public UIStyleInputValidTypeMask __Gen_Wrap_82(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public void __Gen_Wrap_83(object P0, UIStyleInputValidTypeMask P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public bool __Gen_Wrap_84(UIStyleInputValidType P0) => default; // 0x000000018514DE88-0x000000018514DF54
		public bool __Gen_Wrap_85(UIStyleInputValidTypeMask P0) => default; // 0x0000000185151D64-0x0000000185151E1C
		public void __Gen_Wrap_86(object P0, int P1, int P2) {} // 0x00000001854772E8-0x00000001854773E0
		public int __Gen_Wrap_87() => default; // 0x00000001850F1DD4-0x00000001850F1E6C
		public void __Gen_Wrap_88(object P0, bool P1, bool P2) {} // 0x0000000185E3DBF4-0x0000000185E3DCEC
		public Selectable __Gen_Wrap_89(object P0) => default; // 0x0000000189B0832C-0x0000000189B0841C
		public bool __Gen_Wrap_90(object P0, Vector2 P1, object P2) => default; // 0x0000000189B0841C-0x0000000189B08558
		public IList<UIRecycleLayoutAdapter.IVirtualView> __Gen_Wrap_91(object P0) => default; // 0x0000000189B08558-0x0000000189B08634
		public UIRecycleLayoutAdapter __Gen_Wrap_92(object P0) => default; // 0x0000000189B08634-0x0000000189B08710
		public UIRecycleLayoutGroup.ViewMgr __Gen_Wrap_93(object P0) => default; // 0x0000000189B08710-0x0000000189B087EC
		public void __Gen_Wrap_94(object P0, object P1, UIRecycleLayoutGroup.LayoutMeta P2) {} // 0x0000000189B087EC-0x0000000189B08908
		public Vector2 __Gen_Wrap_95(object P0, Bounds P1) => default; // 0x0000000189B08908-0x0000000189B08A30
		public Bounds __Gen_Wrap_96(object P0, UIRecycleLayoutGroup.LayoutMeta P1) => default; // 0x0000000189B08A30-0x0000000189B08B74
		public UIRecycleLayoutAdapter __Gen_Wrap_97(object P0, object P1) => default; // 0x0000000189B08B74-0x0000000189B08C6C
		public UIRecycleLayoutGroup.ViewPool __Gen_Wrap_98(object P0, object P1) => default; // 0x0000000189B08C6C-0x0000000189B08D64
		public GameObject __Gen_Wrap_99(object P0, out bool P1) {
			P1 = default;
			return default;
		} // 0x0000000189B08D64-0x0000000189B08E80
		public bool __Gen_Wrap_100(object P0, int P1, object P2) => default; // 0x0000000189AF96F8-0x0000000189AF97EC
		public UIRecycleLayoutAdapter.IVirtualView __Gen_Wrap_101(object P0, int P1) => default; // 0x0000000189AF97EC-0x0000000189AF98E4
		public float __Gen_Wrap_102(object P0, int P1) => default; // 0x0000000189AF98E4-0x0000000189AF99BC
		public Bounds __Gen_Wrap_103(object P0, int P1) => default; // 0x0000000189AF99BC-0x0000000189AF9ADC
		public int __Gen_Wrap_104(object P0, object P1) => default; // 0x00000001850EF354-0x00000001850EF42C
		public UIRecycleLayoutGroup.Direction __Gen_Wrap_105(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public UIRecycleMultiHolder.MultiVirtualView __Gen_Wrap_106(object P0, int P1) => default; // 0x0000000189AF9ADC-0x0000000189AF9BD4
		public void __Gen_Wrap_107(object P0, int P1, object P2, float P3) {} // 0x0000000189AF9BD4-0x0000000189AF9CCC
		public UIRecycleSingleHolder.SimpleVirtualView __Gen_Wrap_108(object P0, int P1) => default; // 0x0000000189AF9CCC-0x0000000189AF9DC4
		public ToastList.CellInfo __Gen_Wrap_109(object P0) => default; // 0x0000000189AF9DC4-0x0000000189AF9EA0
		public IEnumerator __Gen_Wrap_110(object P0, int P1, object P2) => default; // 0x0000000189AF9EA0-0x0000000189AF9FB4
		public bool __Gen_Wrap_111(object P0, object P1, object P2) => default; // 0x000000018562978C-0x0000000185629894
		public bool __Gen_Wrap_112(object P0, object P1, object P2, bool P3, out bool P4, bool P5) {
			P4 = default;
			return default;
		} // 0x0000000189AF9FB4-0x0000000189AFA10C
		public PlayerActionInfo __Gen_Wrap_113(object P0) => default; // 0x0000000189AFA10C-0x0000000189AFA1FC
		public bool __Gen_Wrap_114(object P0, object P1, bool P2, bool P3) => default; // 0x0000000185E7902C-0x0000000185E79140
		public void __Gen_Wrap_115(Beyond.DeviceInfo.ControllerType P0) {} // 0x00000001850EE9C4-0x00000001850EEA70
		public void __Gen_Wrap_116(object P0, in EventData<string> P1) {} // 0x0000000189AFA1FC-0x0000000189AFA314
		public void __Gen_Wrap_117(object P0, object P1, object P2, bool P3) {} // 0x0000000185648770-0x0000000185648868
		public void __Gen_Wrap_118(object P0, int P1, object P2, object P3, bool P4) {} // 0x0000000189AFA314-0x0000000189AFA420
		public AnimationClip __Gen_Wrap_119(object P0, object P1, bool P2) => default; // 0x0000000189AFA420-0x0000000189AFA534
		public AnimationClip __Gen_Wrap_120(object P0, object P1) => default; // 0x0000000189AFA62C-0x0000000189AFA724
		public void __Gen_Wrap_121(object P0, UIAnimationWrapper.FOptions P1) {} // 0x0000000189AFA724-0x0000000189AFA830
		public float __Gen_Wrap_122(object P0, object P1) => default; // 0x00000001854AB15C-0x00000001854AB248
		public UIAnimationWrapper.FOptions __Gen_Wrap_123() => default; // 0x0000000189AFA830-0x0000000189AFA8E8
		public void __Gen_Wrap_124(object P0, object P1, object P2, float P3) {} // 0x0000000185E57990-0x0000000185E57A98
		public UISwitchTween.ITweenHandler __Gen_Wrap_125(object P0) => default; // 0x0000000189AFA8E8-0x0000000189AFA9D8
		public UISwitchTween.ITweenHandler __Gen_Wrap_126(object P0, object P1) => default; // 0x0000000189AFA9D8-0x0000000189AFAAE4
		public UISwitchTween.ITweenHandler __Gen_Wrap_127(object P0, bool P1) => default; // 0x0000000189AFAAE4-0x0000000189AFABF0
		public UIAnimationSwitchTween __Gen_Wrap_128(ref UIAnimationSwitchTween.Builder P0) => default; // 0x0000000189AFABF0-0x0000000189AFAD3C
		public Camera __Gen_Wrap_129(object P0) => default; // 0x0000000189AFAD3C-0x0000000189AFAE2C
		public void __Gen_Wrap_130(object P0, object P1, bool P2, bool P3, bool P4, bool P5) {} // 0x0000000189AFAE2C-0x0000000189AFAF40
		public void __Gen_Wrap_131(object P0, bool P1, bool P2, bool P3, float P4) {} // 0x0000000189AFAF40-0x0000000189AFB050
		public void __Gen_Wrap_132(object P0, float P1, bool P2) {} // 0x0000000185E5ED40-0x0000000185E5EE3C
		public IEnumerator __Gen_Wrap_133(object P0, object P1) => default; // 0x0000000189AFB050-0x0000000189AFB15C
		public DisposedUnityEvent<int, bool> __Gen_Wrap_134(object P0) => default; // 0x0000000189AFB15C-0x0000000189AFB238
		public void __Gen_Wrap_135(object P0, out Vector2 P1, out Vector2 P2) {
			P1 = default;
			P2 = default;
		} // 0x0000000189AFB238-0x0000000189AFB398
		public Vector2 __Gen_Wrap_136(object P0, Vector2 P1) => default; // 0x0000000189AFB398-0x0000000189AFB4C8
		public void __Gen_Wrap_137(PointerEventData P0) {} // 0x00000001850EE850-0x00000001850EE8FC
		public void __Gen_Wrap_138(object P0, Vector3 P1) {} // 0x0000000189AFB4C8-0x0000000189AFB5E4
		public void __Gen_Wrap_139(object P0, bool P1, float P2, object P3, object P4) {} // 0x0000000189AFB5E4-0x0000000189AFB700
		public void __Gen_Wrap_140(float P0) {} // 0x0000000185784998-0x0000000185784A58
		public void __Gen_Wrap_141(object P0, bool P1, out Selectable P2, out UITouchPanel P3) {
			P2 = default;
			P3 = default;
		} // 0x0000000189AFB700-0x0000000189AFB88C
		public void __Gen_Wrap_142(object P0, float P1, float P2, object P3) {} // 0x0000000189AFB88C-0x0000000189AFB988
		public void __Gen_Wrap_143(object P0, object P1, bool P2, object P3) {} // 0x0000000188743618-0x0000000188743710
		public void __Gen_Wrap_144(object P0, out float P1, out float P2) {
			P1 = default;
			P2 = default;
		} // 0x0000000189AFB988-0x0000000189AFBAB8
		public void __Gen_Wrap_145(object P0, object P1, UnityEngine.Color P2) {} // 0x0000000189AFBAB8-0x0000000189AFBBD4
		public Canvas __Gen_Wrap_146(object P0) => default; // 0x0000000189AFBBD4-0x0000000189AFBCB0
		public HGCamera __Gen_Wrap_147(object P0) => default; // 0x0000000189AFBCB0-0x0000000189AFBD8C
		public string __Gen_Wrap_148(object P0, object P1) => default; // 0x0000000189AFBD8C-0x0000000189AFBE98
		public BindingViewState __Gen_Wrap_149(object P0) => default; // 0x00000001850EF614-0x00000001850EF6E4
		public string __Gen_Wrap_150(object P0, BindingViewActionType P1) => default; // 0x0000000189AFBFE8-0x0000000189AFC0F4
		public bool __Gen_Wrap_151(object P0, out string P1, out string P2) {
			P1 = default;
			P2 = default;
			return default;
		} // 0x0000000189AFC0F4-0x0000000189AFC260
		public void __Gen_Wrap_152(object P0, ActionOnSetNaviTarget P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public HashSet<CanvasScaler> __Gen_Wrap_153(object P0) => default; // 0x0000000189AFC260-0x0000000189AFC33C
		public Vector2 __Gen_Wrap_154(object P0) => default; // 0x0000000189AFC33C-0x0000000189AFC42C
		public float __Gen_Wrap_155(out Vector2 P0) {
			P0 = default;
			return default;
		} // 0x0000000189AFC42C-0x0000000189AFC540
		public UICanvasScaleHelper.FWorldCanvasParams __Gen_Wrap_156(object P0, object P1, bool P2) => default; // 0x0000000189AFC540-0x0000000189AFC67C
		public UICanvasScaleHelper.FScreenCanvasParams __Gen_Wrap_157() => default; // 0x0000000189AFC67C-0x0000000189AFC76C
		public void __Gen_Wrap_158(object P0, UIColorGroup.CommonParams P1) {} // 0x0000000189AFC76C-0x0000000189AFC884
		public void __Gen_Wrap_159(object P0, object P1, UIColorGroup.CommonParams P2) {} // 0x0000000189AFC884-0x0000000189AFC9B8
		public void __Gen_Wrap_160(object P0, float P1, float P2, bool P3) {} // 0x0000000189AFCB34-0x0000000189AFCC30
		public void __Gen_Wrap_161(object P0, UnityEngine.Color P1, float P2, bool P3, bool P4, bool P5) {} // 0x0000000189AFCC30-0x0000000189AFCD7C
		public void __Gen_Wrap_162(object P0, UnityEngine.Color P1, float P2, bool P3, bool P4) {} // 0x0000000189AFCD7C-0x0000000189AFCEC8
		public void __Gen_Wrap_163(object P0, GamepadKeyCode P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public UICustomLayoutElement __Gen_Wrap_164(object P0) => default; // 0x0000000189AFCEC8-0x0000000189AFCFB8
		public string __Gen_Wrap_165(object P0, int P1) => default; // 0x0000000189AFCFB8-0x0000000189AFD0B0
		public bool __Gen_Wrap_166(object P0, out UICustomLayoutElement.LayoutData P1, bool P2, int P3) {
			P1 = default;
			return default;
		} // 0x0000000189AFD0B0-0x0000000189AFD200
		public bool __Gen_Wrap_167(object P0, out UICustomLayoutElement.LayoutData P1, int P2) {
			P1 = default;
			return default;
		} // 0x0000000189AFD200-0x0000000189AFD340
		public RectTransform __Gen_Wrap_168(object P0) => default; // 0x0000000189AFD340-0x0000000189AFD430
		public void __Gen_Wrap_169(object P0, UICustomLayoutElement.LayoutType P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public CanvasGroup __Gen_Wrap_170(object P0) => default; // 0x0000000189AFD520-0x0000000189AFD5FC
		public void __Gen_Wrap_171(object P0, bool P1, object P2) {} // 0x00000001855FE324-0x00000001855FE408
		public void __Gen_Wrap_172(object P0, object P1, object P2, object P3) {} // 0x0000000185496D84-0x0000000185496E8C
		public void __Gen_Wrap_173(object P0, int P1, bool P2, bool P3, bool P4) {} // 0x0000000189AFD5FC-0x0000000189AFD710
		public void __Gen_Wrap_174(object P0, Vector2 P1, bool P2) {} // 0x0000000189AFD710-0x0000000189AFD83C
		public void __Gen_Wrap_175(object P0, int P1, int P2, bool P3) {} // 0x000000018871664C-0x0000000188716750
		public float __Gen_Wrap_176(object P0, bool P1, int P2) => default; // 0x0000000189AFD83C-0x0000000189AFD940
		public void __Gen_Wrap_177(object P0, bool P1, float P2, float P3) {} // 0x0000000185E62488-0x0000000185E62594
		public void __Gen_Wrap_178(object P0, Rect P1) {} // 0x0000000189AFD940-0x0000000189AFDA54
		public float __Gen_Wrap_179(object P0, object P1, bool P2) => default; // 0x000000018871FD10-0x000000018871FE18
		public void __Gen_Wrap_180(object P0, int P1, float P2) {} // 0x0000000185E616F8-0x0000000185E617DC
		public bool __Gen_Wrap_181(object P0, bool P1, bool P2) => default; // 0x0000000189AFDB60-0x0000000189AFDC54
		public Selectable __Gen_Wrap_182(object P0, bool P1) => default; // 0x0000000189AFDC54-0x0000000189AFDD4C
		public bool __Gen_Wrap_183(object P0, int P1, int P2, bool P3, bool P4) => default; // 0x0000000189AFDD4C-0x0000000189AFDE5C
		public bool __Gen_Wrap_184(object P0, NaviDirection P1, bool P2) => default; // 0x0000000189AFDE5C-0x0000000189AFDF50
		public void __Gen_Wrap_185(object P0, NaviDirection P1) {} // 0x00000001855FFD60-0x00000001855FFE28
		public bool __Gen_Wrap_186(object P0, NaviDirection P1) => default; // 0x0000000185E7433C-0x0000000185E74414
		public Vector3 __Gen_Wrap_187() => default; // 0x0000000189AFDF50-0x0000000189AFE030
		public void __Gen_Wrap_188(Vector3 P0) {} // 0x0000000189AFE030-0x0000000189AFE11C
		public UIAtlasManager.UIAtlasHandle __Gen_Wrap_189(UIAtlasManager.UIAtlasProcessFailureCause P0) => default; // 0x0000000189AFE11C-0x0000000189AFE234
		public Texture __Gen_Wrap_190(object P0) => default; // 0x0000000189AFE340-0x0000000189AFE430
		public TweenerCore<float, float, FloatOptions> __Gen_Wrap_191(object P0, float P1, float P2) => default; // 0x0000000189AFE430-0x0000000189AFE548
		public UIImage __Gen_Wrap_192(object P0) => default; // 0x0000000189AFE548-0x0000000189AFE624
		public bool __Gen_Wrap_193(ref UIInertiaViewPager.ScrollEffectConfig P0) => default; // 0x0000000189AFE624-0x0000000189AFE770
		public int __Gen_Wrap_194(object P0, float P1) => default; // 0x00000001886F21C8-0x00000001886F22A0
		public float __Gen_Wrap_195(object P0, float P1) => default; // 0x0000000185481690-0x0000000185481780
		public UIInertiaViewPager.State __Gen_Wrap_196(object P0, object P1) => default; // 0x00000001850EF354-0x00000001850EF42C
		public bool __Gen_Wrap_197(ref UIInertiaViewPager.InertiaBlocker P0, float P1) => default; // 0x0000000189AFE770-0x0000000189AFE8B4
		public bool __Gen_Wrap_198(object P0, float P1, out float P2) {
			P2 = default;
			return default;
		} // 0x0000000189AFE8B4-0x0000000189AFE9D0
		public void __Gen_Wrap_199(object P0, float P1, float P2) {} // 0x00000001854A1120-0x00000001854A1208
		public void __Gen_Wrap_200(object P0, UIInertiaViewPager.State P1, UIInertiaViewPager.State P2) {} // 0x00000001887040F0-0x00000001887041D4
		public void __Gen_Wrap_201(object P0, int P1, object P2) {} // 0x000000018514F720-0x000000018514F818
		public void __Gen_Wrap_202(ref UIInertiaViewPager.EmptyScrollHandler P0) {} // 0x0000000189AFEAD8-0x0000000189AFEBFC
		public void __Gen_Wrap_203(object P0, bool P1, Vector2 P2, Vector2 P3) {} // 0x0000000189AFEBFC-0x0000000189AFED48
		public void __Gen_Wrap_204(object P0, CanvasUpdate P1) {} // 0x000000018549D548-0x000000018549D624
		public Transform __Gen_Wrap_205(object P0) => default; // 0x0000000189AFED48-0x0000000189AFEE38
		public void __Gen_Wrap_206(object P0, object P1, object P2, object P3, object P4) {} // 0x0000000185160F3C-0x000000018516104C
		public int __Gen_Wrap_207(object P0, bool P1) => default; // 0x0000000189AFEE38-0x0000000189AFEF24
		public float __Gen_Wrap_208(object P0, int P1, UIScrollList.ScrollAlignType P2) => default; // 0x0000000185E5EF50-0x0000000185E5F054
		public void __Gen_Wrap_209(object P0, int P1, bool P2, UIScrollList.ScrollAlignType P3) {} // 0x0000000189AFEF24-0x0000000189AFF02C
		public void __Gen_Wrap_210(object P0, int P1, int P2, bool P3, bool P4, bool P5, UIScrollList.ScrollAlignType P6) {} // 0x0000000189AFF1EC-0x0000000189AFF320
		public void __Gen_Wrap_211(object P0, int P1, bool P2, bool P3, bool P4, bool P5) {} // 0x0000000189AFF320-0x0000000189AFF444
		public GameObject __Gen_Wrap_212(object P0, int P1) => default; // 0x0000000189AFF444-0x0000000189AFF53C
		public UIScrollList.Cell __Gen_Wrap_213(object P0, int P1) => default; // 0x0000000189AFF53C-0x0000000189AFF634
		public int __Gen_Wrap_214(object P0, NaviDirection P1) => default; // 0x0000000185613324-0x00000001856133FC
		public int __Gen_Wrap_215(object P0, int P1, NaviDirection P2) => default; // 0x000000018561B0C4-0x000000018561B1B4
		public void __Gen_Wrap_216(object P0, float P1, float P2, float P3) {} // 0x00000001854792E4-0x00000001854793E0
		public bool __Gen_Wrap_217(object P0, Vector3 P1) => default; // 0x0000000189AFF634-0x0000000189AFF75C
		public Vector3 __Gen_Wrap_218(object P0) => default; // 0x0000000189AFF75C-0x0000000189AFF870
		public float __Gen_Wrap_219(object P0, Vector2 P1) => default; // 0x0000000189AFF870-0x0000000189AFF990
		public bool __Gen_Wrap_220(object P0, float P1) => default; // 0x0000000189AFFB50-0x0000000189AFFC40
		public UIScrollList.Padding __Gen_Wrap_221(object P0) => default; // 0x0000000189AFFC40-0x0000000189AFFD38
		public void __Gen_Wrap_222(object P0, out int P1, out int P2) {
			P1 = default;
			P2 = default;
		} // 0x0000000185637930-0x0000000185637A58
		public int __Gen_Wrap_223(object P0, int P1, int P2) => default; // 0x000000018561B0C4-0x000000018561B1B4
		public int __Gen_Wrap_224(object P0, Vector2 P1, NaviDirection P2) => default; // 0x0000000189AFFD38-0x0000000189AFFE60
		public void __Gen_Wrap_225(object P0, Vector2 P1, out int P2, out int P3) {
			P2 = default;
			P3 = default;
		} // 0x0000000189AFFE60-0x0000000189AFFFD0
		public UIScrollRect.MoveTipsType __Gen_Wrap_226(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public void __Gen_Wrap_227(object P0, object P1, object P2, UIScrollRectEdgeRedDot.ERedDotState P3) {} // 0x00000001856479C0-0x0000000185647AB8
		public void __Gen_Wrap_228(object P0, Vector2Int P1) {} // 0x0000000189AFFFD0-0x0000000189B000D0
		public UIScrollRectEdgeRedDot.ERedDotState __Gen_Wrap_229(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public Rect __Gen_Wrap_230(object P0) => default; // 0x0000000189B001C0-0x0000000189B002B8
		public bool __Gen_Wrap_231(object P0, UIScrollRectEdgeRedDot.ERedDotState P1, UIScrollRectEdgeRedDot.ERedDotDir P2, object P3) => default; // 0x0000000189B002B8-0x0000000189B003C0
		public void __Gen_Wrap_232(object P0, out UIScrollRectEdgeRedDot.ERedDotState P1, out UIScrollRectEdgeRedDot.ERedDotState P2) {
			P1 = default;
			P2 = default;
		} // 0x0000000185637930-0x0000000185637A58
		public void __Gen_Wrap_233(object P0, bool P1, float P2) {} // 0x0000000185477B68-0x0000000185477C4C
		public Vector3 __Gen_Wrap_234(object P0, int P1) => default; // 0x0000000189B003C0-0x0000000189B004DC
		public Vector3[] __Gen_Wrap_235(object P0) => default; // 0x0000000189B004DC-0x0000000189B005CC
		public Graphic __Gen_Wrap_236(object P0) => default; // 0x0000000189B005CC-0x0000000189B006BC
		public UISoftMask __Gen_Wrap_237(object P0) => default; // 0x0000000189B006BC-0x0000000189B007AC
		public bool __Gen_Wrap_238(object P0, float P1, float P2) => default; // 0x0000000189B007AC-0x0000000189B008B4
		public Vector2 __Gen_Wrap_239(object P0, Vector2 P1, Vector2 P2, Vector2 P3, Vector2 P4) => default; // 0x0000000189B008B4-0x0000000189B00A68
		public void __Gen_Wrap_240(object P0, Vector2 P1, Vector2 P2, Vector2 P3, Vector2 P4, out float P5, out float P6) {
			P5 = default;
			P6 = default;
		} // 0x0000000189B00C10-0x0000000189B00E14
		public void __Gen_Wrap_241(ref UIVertex P0, Vector2 P1, Vector2 P2, Vector2 P3) {} // 0x0000000189B00E14-0x0000000189B01068
		public void __Gen_Wrap_242(object P0, object P1, object P2, out bool P3) {
			P3 = default;
		} // 0x0000000189B01068-0x0000000189B01194
		public UISoftMaskable __Gen_Wrap_243(object P0) => default; // 0x0000000189B01194-0x0000000189B01284
		public IEnumerator __Gen_Wrap_244(object P0, bool P1, int P2) => default; // 0x0000000189B01284-0x0000000189B01398
		public void __Gen_Wrap_245(object P0, bool P1, int P2) {} // 0x000000018872224C-0x0000000188722330
		public void __Gen_Wrap_246(object P0, object P1, bool P2, object P3, object P4, object P5, bool P6) {} // 0x0000000189B01398-0x0000000189B014D0
		public uint __Gen_Wrap_247(object P0) => default; // 0x0000000185477F10-0x0000000185477FCC
		public void __Gen_Wrap_248(uint P0, bool P1) {} // 0x0000000189B014D0-0x0000000189B015AC
		public TMP_FontAsset __Gen_Wrap_249(object P0, object P1) => default; // 0x0000000189B015AC-0x0000000189B016B8
		public bool __Gen_Wrap_250(object P0, object P1, uint P2, out TMP_FontAsset P3) {
			P3 = default;
			return default;
		} // 0x0000000189B018A8-0x0000000189B01A08
		public bool __Gen_Wrap_251(ref float P0, float P1) => default; // 0x0000000189B01A08-0x0000000189B01B1C
		public void __Gen_Wrap_252(ref TweenUtils.FLerpByTime P0, object P1) {} // 0x0000000189B01B1C-0x0000000189B01C80
		public float __Gen_Wrap_253(ref TweenUtils.FLerpByTime P0, out bool P1) {
			P1 = default;
			return default;
		} // 0x0000000189B01C80-0x0000000189B01E18
		public PlayableGraph __Gen_Wrap_254(object P0) => default; // 0x0000000189B01E18-0x0000000189B01F24
		public AnimationLayerMixerPlayable __Gen_Wrap_255(object P0, PlayableGraph P1, out GenericShareSingleMixerAssetPlayer<AnimationClip> P2) {
			P2 = default;
			return default;
		} // 0x0000000189B01F24-0x0000000189B020B8
		public AnimationPlayableOutput __Gen_Wrap_256(object P0, PlayableGraph P1) => default; // 0x0000000189B020B8-0x0000000189B02204
		public AnimationClipPlayable __Gen_Wrap_257(object P0, object P1, PlayableGraph P2, out GenericShareSingleMixerAssetPlayer<AnimationClip> P3) {
			P3 = default;
			return default;
		} // 0x0000000189B02204-0x0000000189B023B4
		public AnimationMixerPlayable __Gen_Wrap_258(object P0, PlayableGraph P1, out GenericShareSingleMixerAssetPlayer<AnimationClip> P2) {
			P2 = default;
			return default;
		} // 0x0000000189B023B4-0x0000000189B02548
		public void __Gen_Wrap_259(bool P0, FAssetProxyHandle P1) {} // 0x0000000189B02548-0x0000000189B0264C
		public void __Gen_Wrap_260(ref UISwitchTween.TweenContext P0) {} // 0x0000000189B027B0-0x0000000189B028D8
		public void __Gen_Wrap_261(ref UISwitchTween.TweenContext P0, object P1) {} // 0x0000000189B028D8-0x0000000189B02A1C
		public void __Gen_Wrap_262(object P0, UISwitchTween.Options P1) {} // 0x0000000189B02A1C-0x0000000189B02B1C
		public UISwitchTween.TweenContext __Gen_Wrap_263(object P0) => default; // 0x0000000189B02B1C-0x0000000189B02BF8
		public bool __Gen_Wrap_264(ref UISwitchTween.TweenContext P0) => default; // 0x0000000189B02BF8-0x0000000189B02D20
		public float __Gen_Wrap_265(ref FadeSwitchTween.Durations P0, float P1) => default; // 0x0000000189B02D20-0x0000000189B02E80
		public FadeSwitchTween __Gen_Wrap_266(ref FadeSwitchTween.Builder P0) => default; // 0x0000000189B02E80-0x0000000189B02FEC
		public Vector2 __Gen_Wrap_267(object P0, bool P1) => default; // 0x0000000189B02FEC-0x0000000189B030E4
		public void __Gen_Wrap_268(object P0, in RectInt P1) {} // 0x0000000189B030E4-0x0000000189B031F4
		public bool __Gen_Wrap_269(object P0, object P1, out UIAtlasManager.UIAtlasProcessFailureCause P2) {
			P2 = default;
			return default;
		} // 0x00000001888B5978-0x00000001888B5A90
		public RectInt __Gen_Wrap_270(object P0, int P1, int P2) => default; // 0x0000000189B032E4-0x0000000189B03408
		public void __Gen_Wrap_271(object P0, object P1, object P2, in RectInt P3) {} // 0x0000000189B03408-0x0000000189B03548
		public bool __Gen_Wrap_272(ref UIAtlasManager.UIAtlasHandle P0) => default; // 0x0000000189B03548-0x0000000189B03694
		public void __Gen_Wrap_273(object P0, in List<RectInt> P1) {} // 0x0000000189B03694-0x0000000189B03770
		public void __Gen_Wrap_274(int P0, string P1) {} // 0x00000001850F1370-0x00000001850F1438
		public bool __Gen_Wrap_275(StateAnimationInfo P0) => default; // 0x00000001850EF298-0x00000001850EF354
		public GPUPrefabData __Gen_Wrap_276(Vector4 P0, Vector4 P1, Vector2 P2) => default; // 0x0000000189B03770-0x0000000189B03920
		public GPUPrefabDataLite __Gen_Wrap_277(Vector4 P0, Vector4 P1, Vector2 P2) => default; // 0x0000000189B03920-0x0000000189B03AB8
		public bool __Gen_Wrap_278(ref GPUIHandle P0, GPUIHandle P1) => default; // 0x0000000189B03AB8-0x0000000189B03C20
		public bool __Gen_Wrap_279(ref GPUIHandle P0, object P1) => default; // 0x0000000189B03C20-0x0000000189B03D64
		public int __Gen_Wrap_280(ref GPUIHandle P0) => default; // 0x0000000189B03E94-0x0000000189B03FBC
		public bool __Gen_Wrap_281(GPUIHandle P0, GPUIHandle P1) => default; // 0x0000000189B03FBC-0x0000000189B040E0
		public GPUIHandle __Gen_Wrap_282(object P0) => default; // 0x0000000189B040E0-0x0000000189B041D0
		public void __Gen_Wrap_283(object P0, GPUIHandle P1) {} // 0x0000000189B041D0-0x0000000189B042E0
		public bool __Gen_Wrap_284(object P0, object P1, out GPUIHandle P2, int P3) {
			P2 = default;
			return default;
		} // 0x0000000189B042E0-0x0000000189B04438
		public bool __Gen_Wrap_285(object P0, GPUIHandle P1) => default; // 0x0000000189B04438-0x0000000189B04554
		public void __Gen_Wrap_286(object P0, int P1, Vector3 P2) {} // 0x0000000189B04554-0x0000000189B04688
		public bool __Gen_Wrap_287(object P0, GPUIHandle P1, Vector3 P2) => default; // 0x0000000189B04688-0x0000000189B047E0
		public bool __Gen_Wrap_288(object P0, object P1, Vector3 P2, out GPUIHandle P3, int P4) {
			P3 = default;
			return default;
		} // 0x0000000189B047E0-0x0000000189B04978
		public bool __Gen_Wrap_289(object P0, GPUIHandle P1, Vector2 P2) => default; // 0x0000000189B04978-0x0000000189B04AC4
		public void __Gen_Wrap_290(object P0, float P1, int P2) {} // 0x0000000185E4DA84-0x0000000185E4DB7C
		public bool __Gen_Wrap_291(object P0, GPUIHandle P1, bool P2, object P3, bool P4) => default; // 0x0000000189B04BA0-0x0000000189B04CEC
		public bool __Gen_Wrap_292(object P0, GPUIHandle P1, bool P2, int P3, bool P4) => default; // 0x0000000189B04CEC-0x0000000189B04E24
		public bool __Gen_Wrap_293(object P0, GPUIHandle P1, object P2, bool P3) => default; // 0x0000000189B04E24-0x0000000189B04F4C
		public uint __Gen_Wrap_294(UnityEngine.Color P0) => default; // 0x0000000189B04F4C-0x0000000189B0503C
		public void __Gen_Wrap_295(object P0, int P1, UnityEngine.Color P2) {} // 0x0000000189B0503C-0x0000000189B05158
		public bool __Gen_Wrap_296(object P0, GPUIHandle P1, object P2, UnityEngine.Color P3) => default; // 0x0000000189B05158-0x0000000189B052AC
		public bool __Gen_Wrap_297(object P0, GPUIHandle P1, object P2, object P3) => default; // 0x0000000189B052AC-0x0000000189B053E8
		public void __Gen_Wrap_298(object P0, ref NativeArray<GPUInstanceData> P1, out int P2, out int P3, out int P4) {
			P2 = default;
			P3 = default;
			P4 = default;
		} // 0x0000000189B053E8-0x0000000189B055DC
		public void __Gen_Wrap_299(object P0, ref NativeArray<GPUInstanceData> P1, int P2, bool P3) {} // 0x0000000189B055DC-0x0000000189B05754
		public NativeArray<CanvasRenderer.InstanceRange> __Gen_Wrap_300(object P0) => default; // 0x0000000189B05860-0x0000000189B0596C
		public int __Gen_Wrap_301(object P0, object P1, int P2) => default; // 0x00000001850F1FFC-0x00000001850F20F0
		public RuntimePrefabData __Gen_Wrap_302(object P0, object P1) => default; // 0x0000000189B0596C-0x0000000189B05A64
		public Mesh __Gen_Wrap_303() => default; // 0x0000000189B05A64-0x0000000189B05B1C
		public uint __Gen_Wrap_304(uint P0, uint P1) => default; // 0x000000018561A558-0x000000018561A640
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 49483
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get => default; } // 0x0000000189B0B1DC-0x0000000189B0B288 
		object IEnumerator.Current { [IDTag(4)] get => default; } // 0x0000000189B0B288-0x0000000189B0B334 
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x0000000189B0B334-0x0000000189B0B410
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose() {} // 0x0000000185152EA8-0x0000000185152F24
		[IDTag(1)]
		private bool MoveNext() => default; // 0x0000000185152C48-0x0000000185152CD4
		[IDTag(3)]
		void IEnumerator.Reset() {} // 0x0000000185152D80-0x0000000185152DFC
		public void RefAsyncBuilderStartMethod() {} // 0x000000018350B670-0x000000018350B680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 49484
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x0000000189B0CF54-0x0000000189B0CFB8
		public static bool IsPatched(int id) => default; // 0x0000000182343070-0x0000000182343120
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x0000000189B0CE10-0x0000000189B0CEDC
		public object CreateWrapper(int id) => default; // 0x0000000189B0CEDC-0x0000000189B0CF54
		public object InitWrapperArray(int len) => default; // 0x0000000189B0CFB8-0x0000000189B0D164
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x0000000189B0CD6C-0x0000000189B0CE10
	}

	public enum IDMAP0 // TypeDefIndex: 49485
	{
		Beyond-PoolCore-ListPoolInitializer_UI_Beyond-InitializeAtRuntime0 = 0,
		Beyond-PoolCore-ListPoolInitializer_UI_Beyond-Initialize0 = 1,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputHorizontal0 = 2,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputVertical0 = 3,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minWidth0 = 4,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-_GetPreferredSize0 = 5,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredWidth0 = 6,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minHeight0 = 7,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredHeight0 = 8,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-get_panel0 = 9,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-_InitState0 = 10,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdatePos0 = 11,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdateLookAtCamera0 = 12,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-SetLookAtCamera0 = 14,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-OnEnable0 = 16,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-Start0 = 17,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-Tick0 = 19,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-ForceUpdate0 = 20,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-LateTick0 = 21,
		Beyond-Gameplay-UI-UIScrollCellSlantEffect-Tick0 = 22,
		Beyond-UI-UIText-SetAndResolveTextStyle0 = 23,
		Beyond-UI-UIText-_ResolveTextStyle0 = 24,
		Beyond-UI-UIText-HyperlinkUITextManager-UpdateWrapDisplayable0 = 25,
		Beyond-UI-UIText-HyperlinkUITextManager-_IsUITextDisplayable0 = 26,
		Beyond-UI-UIText-HyperlinkUITextManager-_GetGroup0 = 27,
		Beyond-UI-UIText-HyperlinkUITextGroup-ChangeDisplayable0 = 28,
		Beyond-UI-UIText-HyperlinkUITextGroup-_AddDisplayableCount0 = 29,
		Beyond-UI-UIText-HyperlinkUITextGroup-_NotifyDisplayableChanged0 = 30,
		Beyond-UI-UIText-HyperlinkUITextGroup-_SubDisplayableCount0 = 31,
		Beyond-UI-UIText-GetPhoneticText0 = 32,
		Beyond-UI-UIText-SetPhoneticText0 = 33,
		Beyond-UI-UIText-OnEnvLangChanged0 = 34,
		Beyond-UI-UIText-set_text0 = 35,
		Beyond-UI-UIText-_CreateUpdateFunction0 = 36,
		Beyond-UI-UIText-_ReleaseUpdateFunction0 = 37,
		Beyond-UI-UIText-_UpdateTick0 = 38,
		Beyond-UI-UIText-TryGetLinkId0 = 39,
		Beyond-UI-UIText-get_panel0 = 40,
		Beyond-UI-UIText-TryGetOriginalLinkId0 = 41,
		Beyond-UI-UIText-ClearMesh0 = 42,
		Beyond-UI-UIText-_DelayedChangeActiveImageGo0 = 43,
		Beyond-UI-UIText-RefreshPopulateText0 = 50,
		Beyond-UI-UIText-RichTextAnalyzer-PreAnalyzeRichText0 = 51,
		Beyond-UI-UIText-get_processRichTextEntryFunc0 = 52,
		Beyond-UI-UIText-_ProcessRichTextEntry0 = 53,
		Beyond-UI-UIText-GetOrLoadSprite0 = 54,
		Beyond-UI-UIText-RichTextAnalyzer-GetCharacterCountWithoutRichText0 = 55,
		Beyond-UI-UIText-RichTextAnalyzer-ProcessRichTextEntryFallback0 = 56,
		Beyond-UI-UIText-RichTextAnalyzer-AnalyzeRichText0 = 57,
		Beyond-UI-UIText-RichTextAnalyzer-_TryParseRichTextEntry0 = 58,
		Beyond-UI-UIText-RichTextAnalyzer-_TryParseParam0 = 59,
		Beyond-UI-UIText-RichTextAnalyzer-_GetHashCode0 = 60,
		Beyond-UI-UIText-_ProcessRichTextInfo0 = 61,
		Beyond-UI-UIText-_ClearInlineImage0 = 62,
		Beyond-UI-UIText-_ReturnImageGO0 = 63,
		Beyond-UI-UIText-_GetImageGoByIndex0 = 64,
		Beyond-UI-UIText-_GetOrCreateImageGO0 = 65,
		Beyond-UI-UIText-LoadMaterial0 = 66,
		Beyond-UI-I18nFontLoader-GetMaterial0 = 67,
		Beyond-UI-UIText-OnDestroy0 = 68,
		Beyond-UI-UIText-ClearComponent0 = 69,
		Beyond-UI-UIText-HyperlinkUITextManager-RemoveWrap0 = 70,
		Beyond-UI-UIText-HyperlinkUITextGroup-Remove0 = 71,
		Beyond-UI-UIText-_OnPreRenderText0 = 72,
		Beyond-UI-UIText-DisposeInlineImageCache0 = 73,
		Beyond-UI-UIText-Awake0 = 74,
		Beyond-UI-UIText-_GenerateRuntimeText0 = 75,
		Beyond-UI-UIText-_RefreshMatTexture0 = 76,
		Beyond-UI-I18nFontLoader-IsFontDefaultMaterial0 = 77,
		Beyond-UI-I18nFontLoader-get_fontSearchData0 = 78,
		Beyond-UI-I18nFontLoader-IsInvalid0 = 79,
		Beyond-UI-UIText-GetFontAsset0 = 80,
		Beyond-UI-I18nFontLoader-GetI18nFont0 = 81,
		Beyond-UI-UIText-OnPointerClick0 = 82,
		Beyond-UI-UIText-OnPointerEnter0 = 83,
		Beyond-UI-UIText-OnPointerExit0 = 84,
		Beyond-UI-UIText-Start0 = 85,
		Beyond-UI-UIText-SetHyperlinkUITextGroup0 = 86,
		Beyond-UI-UIText-HyperlinkUITextManager-AddWrap0 = 87,
		Beyond-UI-UIText-HyperlinkUITextWrap-Clear0 = 88,
		Beyond-UI-UIText-HyperlinkUITextGroup-Add0 = 89,
		Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapGroup0 = 90,
		Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapOrder0 = 91,
		Beyond-UI-UIText-OnEnable0 = 92,
		Beyond-UI-UIText-OnDisable0 = 93,
		Beyond-UI-UIText-ShrinkLinkTags0 = 94,
		Beyond-UI-UIText-TryGetLinkId1 = 95,
		Beyond-UI-UIText-TryGetCharacterStartPosAndHeight0 = 96,
		Beyond-UI-UIText-TryGetCharacterEndPosAndHeight0 = 97,
		Beyond-UI-UIText-CombineStringWithLanguageSpilt0 = 98,
		Beyond-UI-UIText-CombineStringReverseForIndonesianAndVietnamese0 = 99,
		Beyond-UI-UIText-IsHyperlinkUITextGroupDisplayable0 = 100,
		Beyond-UI-UIText-HyperlinkUITextManager-IsGroupDisplayable0 = 101,
		Beyond-UI-UIText-GetGroupDisplayableHyperlinkUIText0 = 102,
		Beyond-UI-UIText-HyperlinkUITextManager-GetGroupDisplayableUIText0 = 103,
		Beyond-UI-UIText-UpdateI18NFontAsset0 = 109,
		Beyond-UI-UIText-get_m_fontAsset0 = 110,
		Beyond-UI-UIText-set_m_fontAsset0 = 111,
		Beyond-UI-I18nFontLoader-GetCNFontId0 = 112,
		Beyond-UI-UIText-set_fontSharedMaterial0 = 113,
		Beyond-UI-UIText-SetSharedMaterial0 = 114,
		Beyond-UI-UIText-UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize0 = 115,
		Beyond-UI-UIText-OnAfterDeserialize0 = 116,
		Beyond-UI-UIText-AddSubTextObject0 = 117,
		Beyond-UI-UIText-LocalStringCombineFormat0 = 118,
		Beyond-UI-UIConst-GetResolutionScale0 = 119,
		Beyond-UI-UIConst-IsPadDevice0 = 120,
		Beyond-UI-UIModelLoader-LoadModel0 = 121,
		Beyond-UI-UIModelLoader-LoadModelAsync0 = 122,
		Beyond-UI-UIModelLoader-Cancel0 = 125,
		Beyond-UI-UIModelLoader-UnloadModel0 = 126,
		Beyond-UI-UIModelLoader-_Clear0 = 127,
		Beyond-UI-UIModelLoader-Dispose0 = 128,
		Beyond-UI-UIUtils-GetSharedIntString0 = 129,
		Beyond-UI-UIUtils-IsScreenPosInRectTransform0 = 130,
		Beyond-UI-UIUtils-IsScreenPosInRectTransform1 = 131,
		Beyond-UI-UIUtils-CalcBoundOfRectTransform0 = 132,
		Beyond-UI-UIUtils-TryGetTouch0 = 133,
		Beyond-UI-UIUtils-SetAlpha0 = 134,
		Beyond-UI-UIUtils-SetColorWithoutAlpha0 = 135,
		Beyond-UI-UIUtils-ClearUIComponents0 = 136,
		Beyond-UI-UIUtils-RectTransformToScreenRect0 = 137,
		Beyond-UI-UIUtils-GetNodeScaleOffset0 = 138,
		Beyond-UI-UIUtils-GetColorByString0 = 139,
		Beyond-UI-UIUtils-SetMaskRatio0 = 140,
		Beyond-UI-UIUtils-GetCursorTipOffsetX0 = 141,
		Beyond-UI-UIUtils-GetCursorTipOffsetInScreen0 = 142,
		Beyond-UI-ActiveSyncHelper-Awake0 = 143,
		Beyond-UI-ActiveSyncHelper-Sync0 = 144,
		Beyond-UI-ActiveSyncHelper-OnEnable0 = 145,
		Beyond-UI-ActiveSyncHelper-OnDisable0 = 146,
		Beyond-UI-Billboard-OnEnable0 = 147,
		Beyond-UI-Billboard-Tick0 = 148,
		Beyond-UI-CinemachineGyroscopeEffect-PostPipelineStageCallback0 = 149,
		Beyond-UI-CommonItemToastList-ScrollToIndex0 = 150,
		Beyond-UI-UIScrollList-GetRealIndex0 = 151,
		Beyond-UI-CommonItemToastList-AdjustContainerPos0 = 153,
		Beyond-UI-CommonItemToastList-_GetUnConstraintTargetPos0 = 154,
		Beyond-UI-UIScrollList-OnScroll0 = 157,
		Beyond-UI-UIScrollList-UpdateShowingCells0 = 158,
		Beyond-UI-UIScrollList-ClearShowingCells0 = 159,
		Beyond-UI-UIScrollList-CacheCell0 = 160,
		Beyond-UI-UIScrollList-GetShowRange0 = 161,
		Beyond-UI-UIScrollList-GetNotCacheRange0 = 162,
		Beyond-UI-UIScrollList-UpdateCell0 = 163,
		Beyond-UI-UIScrollList-MoveCellTo0 = 164,
		Beyond-UI-UIScrollList-OnUpdateCell0 = 165,
		Beyond-UI-UIScrollList-GetCell0 = 166,
		Beyond-UI-UIAnimationWrapper-ClearTween0 = 167,
		Beyond-UI-UIAnimationWrapper-get_panel0 = 168,
		Beyond-UI-LuaPanel-InformAnimationInEnd0 = 169,
		Beyond-UI-LuaPanel-_TryCallAnimationInFinished0 = 170,
		Beyond-UI-LuaPanel-RecoverAllInput0 = 172,
		Beyond-UI-UIAnimationWrapper-PlayInAnimation0 = 173,
		Beyond-UI-UIAnimationWrapper-_OnInAnimationFinished0 = 176,
		Beyond-UI-UIAnimationWrapper-_OnInEasingAnimationFinished0 = 179,
		Beyond-UI-UIAnimationWrapper-PlayLoopAnimation0 = 180,
		Beyond-UI-UIAnimationLoopSynchronizer-GetLoopStartPosition0 = 181,
		Beyond-UI-UIAnimationWrapper-PlayWithTween0 = 183,
		Beyond-UI-UIAnimationWrapper-GetClip0 = 186,
		Beyond-UI-UIAnimationWrapper-_InitAnimation0 = 187,
		Beyond-UI-UIAnimationWrapper-SampleClip0 = 188,
		Beyond-UI-UIAnimationWrapper-_SampleClipAtLength0 = 189,
		Beyond-UI-LuaPanel-InformAnimationInStart0 = 190,
		Beyond-UI-UIAnimationWrapper-PlayWithTween1 = 191,
		Beyond-UI-UIAnimationWrapper-PlayOpenAudio0 = 192,
		Beyond-UI-UIScrollList-_UpdateMoveTips0 = 193,
		Beyond-UI-UIScrollList-get_moveTips0 = 194,
		Beyond-UI-UIScrollList-UpdateViewEffect0 = 195,
		Beyond-UI-ControllerSideMenuItemList-ToggleItemForceValid0 = 196,
		Beyond-UI-ControllerSideMenuItemList-IsItemForceValid0 = 197,
		Beyond-UI-ControllerSideMenuItemList-ClearForceValidItemList0 = 198,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-IsValid0 = 199,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetText0 = 200,
		Beyond-UI-UIButton-get_text0 = 201,
		Beyond-UI-UIButton-get_label0 = 202,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetSprite0 = 203,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-Execute0 = 204,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetItemName0 = 205,
		Beyond-UI-CustomUIStyle-get_inputValidTypeMask0 = 206,
		Beyond-UI-CustomUIStyle-set_inputValidTypeMask0 = 207,
		Beyond-UI-CustomUIStyle-_OnActiveTypeChanged0 = 208,
		Beyond-UI-CustomUIStyle-get_isValid0 = 209,
		Beyond-UI-CustomUIStyle-IsShowTypeValid0 = 210,
		Beyond-UI-CustomUIStyle-OnDestroy0 = 211,
		Beyond-UI-CustomUIStyle-CheckState0 = 212,
		Beyond-UI-CustomUIStyle-ToggleActiveState0 = 213,
		Beyond-UI-CustomUIStyle-OnEnable0 = 214,
		Beyond-UI-CustomUIStyle-Awake0 = 215,
		Beyond-UI-CustomUIStyle-IsValidInput0 = 216,
		Beyond-UI-DeactivateNaviOnEnable-OnEnable0 = 217,
		Beyond-UI-DeactivateNaviOnEnable-OnDisable0 = 218,
		Beyond-UI-DecoLineActiveHelper-Reset0 = 219,
		Beyond-UI-DecoLineActiveHelper-OnEnable0 = 220,
		Beyond-UI-DecoLineActiveHelper-LateTick0 = 221,
		Beyond-UI-DecoLineActiveHelper-_HasActiveTarget0 = 222,
		Beyond-UI-Empty4Raycast-OnPopulateMesh0 = 223,
		Beyond-UI-FitAspectRatioByFOV-get_maxFov0 = 224,
		Beyond-UI-FitAspectRatioByFOV-Start0 = 225,
		Beyond-UI-FitAspectRatioByFOV-_AdjustFOV0 = 226,
		Beyond-UI-FitAspectRatioByFOV-OnEnable0 = 227,
		Beyond-UI-FitAspectRatioByFOV-OnDisable0 = 228,
		Beyond-UI-FitAspectRatioByFOV-OnScreenSizeChanged0 = 229,
		Beyond-UI-FixRotation-LateTick0 = 230,
		Beyond-UI-FullScreenSceneBlurMarker-_GetNextId0 = 231,
		Beyond-UI-FullScreenSceneBlurMarker-Awake0 = 232,
		Beyond-UI-FullScreenSceneBlurMarker-OnEnable0 = 234,
		Beyond-UI-FullScreenSceneBlurMarker-OnDisable0 = 236,
		Beyond-UI-FullScreenSceneBlurMarker-OnDestroy0 = 237,
		Beyond-UI-InputBindingGroupNaviDecorator-_SetSelfEnabledStateIfNecessary0 = 238,
		Beyond-UI-InputBindingGroupNaviDecorator-Awake0 = 239,
		Beyond-UI-InputBindingGroupNaviDecorator-OnEnable0 = 240,
		Beyond-UI-InputBindingGroupNaviDecorator-OnDestroy0 = 241,
		Beyond-UI-InputBindingGroupNaviDecorator-ClearComponent0 = 242,
		Beyond-UI-InputBindingGroupNaviDecorator-_OnSetAsNaviTarget0 = 243,
		Beyond-UI-LuaPanel-Awake0 = 244,
		Beyond-UI-LuaPanel-_TrySetRot0 = 247,
		Beyond-UI-LuaPanel-AddSortingOrderComp0 = 248,
		Beyond-UI-LuaPanel-RemoveSortingOrderComp0 = 249,
		Beyond-UI-LuaPanel-Start0 = 250,
		Beyond-UI-LuaPanel-OnEnable0 = 251,
		Beyond-UI-LuaPanel-BlockAllInput0 = 252,
		Beyond-UI-LuaPanel-_AutoAnimationInFinish0 = 253,
		Beyond-UI-LuaPanel-OnDisable0 = 260,
		Beyond-UI-LuaPanel-OnDestroy0 = 261,
		Beyond-UI-LuaPanel-ClearComponent0 = 262,
		Beyond-UI-MouseHoverTipsPosHelper-get_panel0 = 263,
		Beyond-UI-MouseHoverTipsPosHelper-OnAwake0 = 264,
		Beyond-UI-MouseHoverTipsPosHelper-OnEnable0 = 265,
		Beyond-UI-MouseHoverTipsPosHelper-UpdatePosition0 = 266,
		Beyond-UI-MouseHoverTipsPosHelper-LateTick0 = 268,
		Beyond-UI-NaviToThisGroupOnEnable-Reset0 = 269,
		Beyond-UI-NaviToThisGroupOnEnable-Awake0 = 270,
		Beyond-UI-NaviToThisGroupOnEnable-OnEnable0 = 271,
		Beyond-UI-UISelectableNaviGroup-NaviToThisGroup0 = 272,
		Beyond-UI-UISelectableNaviGroup-_FindDefaultSelectable0 = 273,
		Beyond-UI-NonDrawingGraphic-get_Radius0 = 274,
		Beyond-UI-NonDrawingGraphic-SetMaterialDirty0 = 275,
		Beyond-UI-NonDrawingGraphic-SetVerticesDirty0 = 276,
		Beyond-UI-NonDrawingGraphic-OnPopulateMesh0 = 277,
		Beyond-UI-NonDrawingGraphic-IsRaycastLocationValid0 = 278,
		Beyond-UI-NonDrawingGraphic-_IsRaycastLocationValidCircle0 = 279,
		Beyond-UI-NotchAdapter-Awake0 = 280,
		Beyond-UI-NotchAdapter-_UpdateMargeSizeFromNotchInfo0 = 281,
		Beyond-UI-NotchAdapter-_OnCanvasChanged0 = 282,
		Beyond-UI-NotchAdapter-ApplyNewNotch0 = 283,
		Beyond-UI-NotchAdapter-ApplyNotch0 = 284,
		Beyond-UI-NotchAdapter-ClearNullRef0 = 285,
		Beyond-UI-NotchAdapter-FindAllSideUI0 = 286,
		Beyond-UI-NotchAdapter-ClearList0 = 287,
		Beyond-UI-NotchAdapter-_TraverseUI0 = 288,
		Beyond-UI-NotchAdapter-_TryAddToSideUI0 = 289,
		Beyond-UI-NotchAdapter-OnDestroy0 = 290,
		Beyond-UI-NotchAdapter-ApplyNotch1 = 291,
		Beyond-UI-NotchAdapter-UnApplyNotch0 = 292,
		Beyond-UI-ParallaxHelper-InitConfigs0 = 293,
		Beyond-UI-ParallaxHelper-ResetValue0 = 294,
		Beyond-UI-ParallaxHelper-RefreshPos0 = 295,
		Beyond-UI-PercentNumberTweener-Reset0 = 296,
		Beyond-UI-PercentNumberTweener-OnEnable0 = 297,
		Beyond-UI-PercentNumberTweener-LateTick0 = 298,
		Beyond-UI-UIRecycleLayoutAdapter-Init0 = 299,
		Beyond-UI-UIRecycleLayoutAdapter-GenerateViewsForRebuild0 = 301,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-AttachView0 = 302,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-DetachView0 = 303,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetAttachedView0 = 304,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetViewID0 = 305,
		Beyond-UI-UIRecycleLayoutGroup-get_adapter0 = 306,
		Beyond-UI-UIRecycleLayoutGroup-get_viewMgr0 = 307,
		Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputHorizontal0 = 308,
		Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputVertical0 = 309,
		Beyond-UI-UIRecycleLayoutGroup-get_paddingFront0 = 310,
		Beyond-UI-UIRecycleLayoutGroup-get_paddingBack0 = 311,
		Beyond-UI-UIRecycleLayoutGroup-_ApplyLayoutMeta0 = 312,
		Beyond-UI-UIRecycleLayoutGroup-_GetVisibleRange0 = 313,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsFromMeta0 = 314,
		Beyond-UI-UIRecycleLayoutGroup-SetAdapter0 = 316,
		Beyond-UI-UIRecycleLayoutGroup-_RebuildAllViews0 = 317,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RebuildAll0 = 318,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-RecycleAll0 = 319,
		Beyond-UI-UIRecycleLayoutGroup-_UpdateViews0 = 320,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViews0 = 321,
		Beyond-UI-UIRecycleLayoutGroup-ClearComponent0 = 323,
		Beyond-UI-UIRecycleLayoutGroup-LateTick0 = 324,
		Beyond-UI-UIRecycleLayoutGroup-OnLateTick0 = 325,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-DetachView0 = 326,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_EnsureViewPool0 = 327,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-Recycle0 = 328,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AttachView0 = 329,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-Alloc0 = 330,
		Beyond-UI-UIRecycleLayoutGroup-_InsertView0 = 331,
		Beyond-UI-UIRecycleLayoutGroup-_RemoveView0 = 332,
		Beyond-UI-UIRecycleLayoutGroup-_UpdateViewsFrom0 = 333,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementPosByIndex0 = 334,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetView0 = 335,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsByIndex0 = 336,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementIndex0 = 337,
		Beyond-UI-UIRecycleLayoutGroup-_RefreshLayout0 = 338,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewCount0 = 339,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-InsertView0 = 340,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AddView0 = 341,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RemoveView0 = 342,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyViewSizeChanged0 = 343,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyAllViewSizeChanged0 = 344,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyRebuild0 = 345,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementPosByIndex0 = 346,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementBoundsByIndex0 = 347,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetDirection0 = 348,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetSizeOnAxis0 = 349,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewportSizeOnAxis0 = 350,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementIndex0 = 351,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_NotifyLayoutChanged0 = 352,
		Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-GenerateViewsForRebuild0 = 353,
		Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-OnInit0 = 354,
		Beyond-UI-UIRecycleMultiHolder-GetVirtualView0 = 355,
		Beyond-UI-UIRecycleMultiHolder-UpdateCount1 = 356,
		Beyond-UI-UIRecycleMultiHolder-UpdateCount0 = 357,
		Beyond-UI-UIRecycleMultiHolder-InsertView0 = 358,
		Beyond-UI-UIRecycleMultiHolder-AddView0 = 359,
		Beyond-UI-UIRecycleMultiHolder-OnAdapterInit0 = 360,
		Beyond-UI-UIRecycleMultiHolder-ClearComponent0 = 361,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetIndex0 = 362,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPrefab0 = 364,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPreferSize0 = 365,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewDetached0 = 366,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewAttached0 = 367,
		Beyond-UI-UIRecycleSingleHolder-GetVirtualView0 = 368,
		Beyond-UI-UIRecycleSingleHolder-UpdateCount1 = 369,
		Beyond-UI-UIRecycleSingleHolder-UpdateCount0 = 370,
		Beyond-UI-UIRecycleSingleHolder-InsertView0 = 371,
		Beyond-UI-UIRecycleSingleHolder-AddView0 = 372,
		Beyond-UI-UIRecycleSingleHolder-OnAdapterInit0 = 373,
		Beyond-UI-UIRecycleSingleHolder-ClearComponent0 = 374,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetIndex0 = 375,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPrefab0 = 376,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPreferSize0 = 377,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewDetached0 = 378,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewAttached0 = 379,
		Beyond-UI-SimpleUITextSingleLine-GenerateTextMesh0 = 380,
		Beyond-UI-ToastList-Awake0 = 381,
		Beyond-UI-ToastList-OnDisable0 = 383,
		Beyond-UI-ToastList-ClearAllToast0 = 384,
		Beyond-UI-ToastList-_CacheCell0 = 386,
		Beyond-UI-ToastList-_GetCell0 = 387,
		Beyond-UI-ToastList-AddToast0 = 388,
		Beyond-UI-ToastList-_StartBatch0 = 389,
		Beyond-UI-ToastList-_ShowCell0 = 390,
		Beyond-UI-UIAnimationWrapper-PlayOutAnimation0 = 394,
		Beyond-UI-UIAnimationWrapper-PlayCloseAudio0 = 397,
		Beyond-UI-ToastList-_TryShowNewCell0 = 398,
		Beyond-UI-UIAnimationWrapper-GetOutClipLength0 = 399,
		Beyond-UI-ToastList-_OnCellFinished0 = 400,
		Beyond-UI-ToastList-ClearComponent0 = 404,
		Beyond-UI-UI3DScrollList-MoveCellTo0 = 405,
		Beyond-UI-UIActionKeyHint-_TryInit0 = 406,
		Beyond-UI-UIActionKeyHint-_OnControllerTypeChange0 = 407,
		Beyond-UI-UIActionKeyHint-_RefreshAllKeyHints0 = 408,
		Beyond-UI-UIActionKeyHint-UpdateKeyHint0 = 409,
		Beyond-UI-UIActionKeyHint-SetSecondActionId0 = 410,
		Beyond-UI-UIActionKeyHint-_SetSecondIcon0 = 411,
		Beyond-UI-UIActionKeyHint-GetAndSetActionIcon0 = 412,
		Beyond-UI-UIActionKeyHint-_SetKeyCodeSprite0 = 413,
		Beyond-UI-UIImage-LoadSpriteWithOutFormat0 = 414,
		Beyond-UI-UIImage-_LoadSprite0 = 415,
		Beyond-UI-UIImage-DisposeSpriteHandle0 = 416,
		Beyond-UI-UIActionKeyHint-GetActionInfo0 = 417,
		Beyond-UI-UIActionKeyHint-GetActionId0 = 418,
		Beyond-UI-UIActionKeyHint-SetContentState0 = 419,
		Beyond-UI-UIActionKeyHint-GetAndSetActionModifyIcon0 = 420,
		Beyond-UI-UIActionKeyHint-GetTextStr0 = 421,
		Beyond-UI-UIActionKeyHint-_CheckInteractable0 = 422,
		Beyond-UI-UIActionKeyHint-_IsInputGray0 = 424,
		Beyond-UI-UIActionKeyHint-_IsInputEnabled0 = 425,
		Beyond-UI-UIActionKeyHint-_OnInputLateTickAll0 = 426,
		Beyond-UI-UIActionKeyHint-Awake0 = 427,
		Beyond-UI-UIActionKeyHint-OnEnable0 = 428,
		Beyond-UI-UIActionKeyHint-_OnInputActionKeyUpdated0 = 429,
		Beyond-UI-UIActionKeyHint-OnDisable0 = 430,
		Beyond-UI-UIActionKeyHint-OnDestroy0 = 431,
		Beyond-UI-UIActionKeyHint-ClearComponent0 = 432,
		Beyond-UI-UIActionKeyHint-Reset0 = 433,
		Beyond-UI-UIActionKeyHint-SetActionId0 = 434,
		Beyond-UI-UIActionKeyHint-SetKeyHint0 = 435,
		Beyond-UI-UIActionKeyHint-_OnChangeTarget0 = 436,
		Beyond-UI-UIActionKeyHint-SetBindingId0 = 437,
		Beyond-UI-UIActionKeyHint-SetBindingId1 = 438,
		Beyond-UI-UIActionKeyHint-SetText0 = 439,
		Beyond-UI-UIAnimationHolder-FindByName0 = 440,
		Beyond-UI-UIAnimationHolder-_FindByString0 = 441,
		Beyond-UI-UIAnimationHolder-FindByNameOrAlias0 = 442,
		Beyond-UI-UIAnimationHolder-GetAnimationClips0 = 443,
		Beyond-UI-UIAnimationLoopSynchronizer-RegisterChild0 = 444,
		Beyond-UI-UIAnimationLoopSynchronizer-UnregisterChild0 = 445,
		Beyond-UI-UIAnimationWrapper-SetOptions0 = 446,
		Beyond-UI-UIAnimationWrapper-_AnimationInLoopCheck0 = 447,
		Beyond-UI-UIAnimationWrapper-_AnimationAutomaticallyCheck0 = 448,
		Beyond-UI-UIAnimationWrapper-Awake0 = 449,
		Beyond-UI-UIAnimationWrapper-IsStarted0 = 450,
		Beyond-UI-UIAnimationWrapper-SetAnimationInClip0 = 451,
		Beyond-UI-UIAnimationWrapper-SetAnimationInEasingClip0 = 452,
		Beyond-UI-UIAnimationWrapper-SetAnimationLoopClip0 = 453,
		Beyond-UI-UIAnimationWrapper-SetAnimationOutClip0 = 454,
		Beyond-UI-UIAnimationWrapper-GetInClipLength0 = 455,
		Beyond-UI-UIAnimationWrapper-GetLoopClipLength0 = 456,
		Beyond-UI-UIAnimationWrapper-SkipInAnimation0 = 457,
		Beyond-UI-UIAnimationWrapper-SampleToInAnimationBegin0 = 458,
		Beyond-UI-UIAnimationWrapper-SampleToInAnimationEnd0 = 459,
		Beyond-UI-UIAnimationWrapper-SampleToOutAnimationBegin0 = 460,
		Beyond-UI-UIAnimationWrapper-SampleToOutAnimationEnd0 = 461,
		Beyond-UI-UIAnimationWrapper-GetClipLength0 = 462,
		Beyond-UI-UIAnimationWrapper-AnimationRuntime-GetClipLength0 = 463,
		Beyond-UI-UIAnimationWrapper-SampleClipAtPercent0 = 464,
		Beyond-UI-UIAnimationWrapper-_CheckShouldAutoPlayAnimationIn0 = 465,
		Beyond-UI-UIAnimationWrapper-Start0 = 466,
		Beyond-UI-UIAnimationWrapper-OnEnable0 = 467,
		Beyond-UI-UIAnimationWrapper-OnDisable0 = 468,
		Beyond-UI-UIAnimationWrapper-OnDestroy0 = 469,
		Beyond-UI-UIAnimationWrapper-ClearComponent0 = 470,
		Beyond-UI-UIAnimationWrapper-CheckStopped0 = 471,
		Beyond-UI-UIAnimationWrapper-Play0 = 472,
		Beyond-UI-UIAnimationWrapper-Play1 = 473,
		Beyond-UI-UIAnimationWrapper-GetCurPlayingTime0 = 474,
		Beyond-UI-UIAnimationTween-GetValue0 = 475,
		Beyond-UI-UIAnimationWrapper-FOptions-GetDefault0 = 476,
		Beyond-UI-UIAnimationTween-_SetValue0 = 477,
		Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfHide0 = 478,
		Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfShow0 = 479,
		Beyond-UI-UIAnimationSwitchTween-BeforeShowEffect0 = 480,
		Beyond-UI-UIAnimationSwitchTween-_SetGameObjectActive0 = 481,
		Beyond-UI-UIAnimationSwitchTween-AfterHideEffect0 = 482,
		Beyond-UI-UIAnimationSwitchTween-ResetToState0 = 483,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-IsPlaying0 = 484,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-KillIfNecessary0 = 485,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-OnComplete0 = 486,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-SetAutoKill0 = 487,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-_OnComplete0 = 488,
		Beyond-UI-UIAnimationSwitchTween-Builder-Build0 = 489,
		Beyond-UI-UIArea-_SetHighlightNodeActive0 = 490,
		Beyond-UI-UIArea-OnPointerEnter0 = 491,
		Beyond-UI-UIArea-OnPointerExit0 = 492,
		Beyond-UI-UIArea-OnEnable0 = 493,
		Beyond-UI-UIArea-OnDisable0 = 494,
		Beyond-UI-UIArea-OnDestroy0 = 495,
		Beyond-UI-UIArea-ClearComponent0 = 496,
		Beyond-UI-UIAutoCloseArea-set_includeInAutoCloseLayer0 = 497,
		Beyond-UI-UIAutoCloseArea-AddToAutoCloseLayer0 = 498,
		Beyond-UI-UIAutoCloseArea-RemoveFromAutoCloseLayer0 = 499,
		Beyond-UI-UIAutoCloseArea-get_panel0 = 500,
		Beyond-UI-UIAutoCloseArea-Start0 = 501,
		Beyond-UI-UIAutoCloseArea-InitBinding0 = 502,
		Beyond-UI-UIAutoCloseArea-TryCloseSelf0 = 505,
		Beyond-UI-UIAutoCloseArea-CloseSelf0 = 506,
		Beyond-UI-UIAutoCloseArea-_AutoCloseToggleObjWhenOut0 = 507,
		Beyond-UI-UIAutoCloseArea-_UpdateState0 = 509,
		Beyond-UI-UIAutoCloseArea-Reset0 = 510,
		Beyond-UI-UIAutoCloseArea-LateTick0 = 511,
		Beyond-UI-UIAutoCloseArea-ShouldClose0 = 512,
		Beyond-UI-UIAutoCloseArea-_GetUICamera0 = 513,
		Beyond-UI-UIAutoCloseArea-IsTopAutoCloseLayer0 = 514,
		Beyond-UI-UIAutoCloseArea-OnEnable0 = 515,
		Beyond-UI-UIAutoCloseArea-OnDisable0 = 516,
		Beyond-UI-UIAutoCloseArea-ChangeEnableCloseActionOnController0 = 517,
		Beyond-UI-UIAutoCloseArea-OpenSelf0 = 518,
		Beyond-UI-UIAutoCloseArea-ClearComponent0 = 519,
		Beyond-UI-UIAutoCloseArea-OnDestroy0 = 520,
		Beyond-UI-UIBigLogo-SetBigLogoEditor0 = 521,
		Beyond-UI-UIBigLogo-ShowBigLogo0 = 522,
		Beyond-UI-UIBigLogo-SetBigLogoMask0 = 523,
		Beyond-UI-UIBigLogo-ClearBigLogoMask0 = 524,
		Beyond-UI-UIBigLogo-ClearBigLogo0 = 525,
		Beyond-UI-UIBigLogo-SetAlpha0 = 526,
		Beyond-UI-UIBigLogo-SetMaskAlpha0 = 527,
		Beyond-UI-UIBigRectButton-OnPointerDown0 = 528,
		Beyond-UI-UIButton-OnPointerDown0 = 529,
		Beyond-UI-UIButton-_StopLongPressCor0 = 530,
		Beyond-UI-UIButton-_PlayClickAnimation0 = 531,
		Beyond-UI-UIButton-_DoClickAnimation0 = 532,
		Beyond-UI-UIButton-_OnPress0 = 539,
		Beyond-UI-UIBigRectButton-OnPointerUp0 = 549,
		Beyond-UI-UIButton-OnPointerUp0 = 550,
		Beyond-UI-UIBigRectButton-OnDrag0 = 551,
		Beyond-UI-UIBigRectButton-OnBeginDrag0 = 552,
		Beyond-UI-UIBigRectButton-OnEndDrag0 = 553,
		Beyond-UI-UIBigRectButton-OnScroll0 = 554,
		Beyond-UI-UIBigRectHelper-get_zoomEvent0 = 555,
		Beyond-UI-UIBigRectHelper-OnAwake0 = 556,
		Beyond-UI-UIBigRectHelper-_OnDrag0 = 558,
		Beyond-UI-UIBigRectHelper-_GetAdjustedPosition0 = 559,
		Beyond-UI-UIBigRectHelper-_GetContainerRectBounds0 = 560,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPosition1 = 562,
		Beyond-UI-UIBigRectHelper-ResetPivotPositionToScreenCenter0 = 563,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPosition0 = 564,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPositionToMousePosition0 = 565,
		Beyond-UI-UIBigRectHelper-_OnZoom0 = 566,
		Beyond-UI-UIBigRectHelper-_SetZoomValueAndScale0 = 567,
		Beyond-UI-UIBigRectHelper-_SetScale0 = 568,
		Beyond-UI-UIBigRectHelper-_UpdatePositionOffsetAfterZoomed0 = 570,
		Beyond-UI-UIBigRectHelper-_PosAdjust0 = 571,
		Beyond-UI-UIBigRectHelper-_InitControllerBindings0 = 572,
		Beyond-UI-UIBigRectHelper-_OnControllerClick0 = 573,
		Beyond-UI-UIBigRectHelper-_RefreshControllerFocusRaycastResults0 = 574,
		Beyond-UI-UIBigRectHelper-Tick0 = 577,
		Beyond-UI-UIBigRectHelper-_TickRefreshController0 = 578,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickMove0 = 579,
		Beyond-UI-UIBigRectHelper-_GetIsControllerMoveEnabled0 = 580,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickZoom0 = 582,
		Beyond-UI-UIBigRectHelper-_GetIsControllerZoomEnabled0 = 583,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerZoomKeyHint0 = 585,
		Beyond-UI-UIBigRectHelper-LateTick0 = 586,
		Beyond-UI-UIBigRectHelper-_TickCheckControllerFocusRaycastTargets0 = 587,
		Beyond-UI-UIBigRectHelper-OnRelease0 = 588,
		Beyond-UI-UIBigRectHelper-ManuallyZoom0 = 589,
		Beyond-UI-UIBigRectHelper-_TryAlignWhenInit0 = 590,
		Beyond-UI-UIBigRectHelper-Init0 = 591,
		Beyond-UI-UIBigRectHelper-_ResetControllerState0 = 593,
		Beyond-UI-UIBigRectHelper-FocusNode0 = 594,
		Beyond-UI-UIBigRectHelper-FocusNode1 = 595,
		Beyond-UI-UIBigRectHelper-ZoomToFullRect0 = 598,
		Beyond-UI-UIBigRectHelper-ChangePaddingRight0 = 599,
		Beyond-UI-UIBigRectHelper-SetZoomRangeMax0 = 600,
		Beyond-UI-UIBigRectHelper-OverrideZoomRangeMin0 = 601,
		Beyond-UI-UIBigRectHelper-SyncZoomValue0 = 602,
		Beyond-UI-UIBigRectHelper-GetZoomRange0 = 603,
		Beyond-UI-UIBigRectHelper-GetCurrentZoomValue0 = 604,
		Beyond-UI-UIBigRectHelper-ChangePivotPositionToTarget0 = 605,
		Beyond-UI-UIBigRectHelper-ClearComponent0 = 606,
		Beyond-UI-UIBigRectHelper-ClearAllTween0 = 607,
		Beyond-UI-UIBlendImage-SetMaterialKey0 = 608,
		Beyond-UI-UIBlendImage-SetColor0 = 609,
		Beyond-UI-UIBlendImage-SetTexture0 = 610,
		Beyond-UI-UIBlendImage-ClearMaterialCache0 = 611,
		Beyond-UI-UIBlurMono-get_canvas0 = 612,
		Beyond-UI-UIBlurMono-get_panel0 = 613,
		Beyond-UI-UIBlurMono-OnEnable0 = 614,
		Beyond-UI-UIBlurMono-_GetCamera0 = 615,
		Beyond-UI-UIBlurMono-OnDisable0 = 616,
		Beyond-UI-UIBlurMono-Tick0 = 617,
		Beyond-UI-UIBlurMono-UpdateSortingOrder0 = 618,
		Beyond-UI-UIBlurRT-Reset0 = 619,
		Beyond-UI-UIBlurRT-InitRT0 = 620,
		Beyond-UI-UIBlurRT-Register0 = 622,
		Beyond-UI-UIBlurRT-SetUseSceneColorPS0 = 624,
		Beyond-UI-UIBlurRT-UnRegister0 = 625,
		Beyond-UI-UIBlurRT-UpdateRT0 = 626,
		Beyond-UI-UIBlurRT-OnEnable0 = 627,
		Beyond-UI-UIBlurRT-OnDisable0 = 628,
		Beyond-UI-UIBlurRT-_Clear0 = 629,
		Beyond-UI-UIBlurRT-OnDestroy0 = 630,
		Beyond-UI-UIBlurRT-SetCustomBlurImg0 = 631,
		Beyond-UI-UIButton-Awake0 = 633,
		Beyond-UI-UIButton-InitBinding0 = 634,
		Beyond-UI-UIButton-_UpdateState0 = 637,
		Beyond-UI-UIButton-OnPointerClick0 = 639,
		Beyond-UI-UIButton-_Press0 = 640,
		Beyond-UI-UIButton-get_panel0 = 642,
		Beyond-UI-UIButton-_OnUpdateKey0 = 643,
		Beyond-UI-UIButton-_InitActionOnSetNaviTarget0 = 649,
		Beyond-UI-UIButton-OnEnable0 = 653,
		Beyond-UI-UIButton-OnDisable0 = 654,
		Beyond-UI-UIButton-OnDestroy0 = 655,
		Beyond-UI-UIButton-ClearComponent0 = 656,
		Beyond-UI-UIButton-_NotifyIsHover0 = 657,
		Beyond-UI-UIButton-set_text0 = 658,
		Beyond-UI-UIButton-OnInteractableChanged0 = 659,
		Beyond-UI-UIButton-get_bindingViewActionId0 = 660,
		Beyond-UI-UIButton-_GetUIButtonKeyHintActionId0 = 661,
		Beyond-UI-UIButton-set_customBindingViewLabelText0 = 662,
		Beyond-UI-UIButton-get_hintText0 = 663,
		Beyond-UI-UIButton-get_bindingViewState0 = 664,
		Beyond-UI-UIButton-GetBindingViewActionId0 = 665,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyDown0 = 666,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyUp0 = 667,
		Beyond-UI-UIButton-_RefreshHoverEnableNode0 = 668,
		Beyond-UI-UIButton-GetMouseActionHints0 = 669,
		Beyond-UI-UIButton-OnNaviTargetEnabledAgain0 = 670,
		Beyond-UI-UIButton-_OnSetAsNaviTarget0 = 671,
		Beyond-UI-UIButton-_ToggleNaviInputBinding0 = 672,
		Beyond-UI-UIButton-ChangeActionOnSetNaviTarget0 = 673,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.get_interactable0 = 674,
		Beyond-UI-UICanvasScaleHelper-get_standardHorizontalResolution0 = 675,
		Beyond-UI-UICanvasScaleHelper-get_standardVerticalResolution0 = 676,
		Beyond-UI-UICanvasScaleHelper-get_canvasScalerList0 = 677,
		Beyond-UI-UICanvasScaleHelper-Awake0 = 678,
		Beyond-UI-UICanvasScaleHelper-_OnInit0 = 679,
		Beyond-UI-UICanvasScaleHelper-GetProperCanvasResolution0 = 680,
		Beyond-UI-UICanvasScaleHelper-Start0 = 681,
		Beyond-UI-UICanvasScaleHelper-_OnInputTypeChanged0 = 682,
		Beyond-UI-UICanvasScaleHelper-_CanvasOnWillRenderCanvases0 = 683,
		Beyond-UI-UICanvasScaleHelper-OnDestroy0 = 684,
		Beyond-UI-UICanvasScaleHelper-ClearComponent0 = 685,
		Beyond-UI-UICanvasScaleHelper-UpdateCanvas0 = 686,
		Beyond-UI-UICanvasScaleHelper-CalcWorldCanvasParams0 = 687,
		Beyond-UI-UICanvasScaleHelper-CalcCurrentScreenRatio0 = 688,
		Beyond-UI-UICanvasScaleHelper-CalcScreenCanvasParams0 = 689,
		Beyond-UI-UICanvasScaleHelper-OnScreenSizeChanged0 = 690,
		Beyond-UI-UICanvasScaleHelper-AddCanvas0 = 691,
		Beyond-UI-UICanvasScaleHelper-RemoveCanvas0 = 692,
		Beyond-UI-UICanvasScaleHelper-ForceCanvasUpdate0 = 693,
		Beyond-UI-UIColorGroup-set_color0 = 694,
		Beyond-UI-UIColorGroup-_SetColor0 = 695,
		Beyond-UI-UIColorGroup-_ApplyOptToGraphics0 = 696,
		Beyond-UI-UIColorGroup-AttachGraphic0 = 697,
		Beyond-UI-UIColorGroup-AttachGraphicsWithGroup0 = 698,
		Beyond-UI-UIColorGroup-CrossFadeAlpha0 = 699,
		Beyond-UI-UIColorGroup-_CrossFadeAlpha0 = 700,
		Beyond-UI-UIColorGroup-CrossFadeColor0 = 701,
		Beyond-UI-UIColorGroup-_CrossFadeColorRGB0 = 702,
		Beyond-UI-UIColorGroup-CrossFadeColor1 = 703,
		Beyond-UI-UIColorGroup-_CrossFadeColorAlpha0 = 704,
		Beyond-UI-UIControllerKeyIcon-_TryStaticInit0 = 705,
		Beyond-UI-UIControllerKeyIcon-_OnControllerTypeChange0 = 706,
		Beyond-UI-UIControllerKeyIcon-RefreshKeyIcon0 = 707,
		Beyond-UI-UIControllerKeyIcon-Awake0 = 708,
		Beyond-UI-UIControllerKeyIcon-OnEnable0 = 709,
		Beyond-UI-UIControllerKeyIcon-OnDisable0 = 710,
		Beyond-UI-UIControllerKeyIcon-SetKeyIconName0 = 711,
		Beyond-UI-UICustomLayout-Awake0 = 712,
		Beyond-UI-UICustomLayout-IsDirty0 = 713,
		Beyond-UI-UICustomLayoutHandle-IsDirty0 = 714,
		Beyond-UI-UICustomLayout-ResetToDefault0 = 715,
		Beyond-UI-UICustomLayoutHandle-ResetToDefault0 = 716,
		Beyond-UI-UICustomLayoutHandle-_SetChanged0 = 717,
		Beyond-UI-UICustomLayoutHandle-get_Element0 = 718,
		Beyond-UI-UICustomLayoutElement-ResetToDefault0 = 719,
		Beyond-UI-UICustomLayoutElement-_GetMarginSize0 = 720,
		Beyond-UI-UICustomLayoutElement-get_panel0 = 721,
		Beyond-UI-UICustomLayoutElement-_ApplyScale0 = 722,
		Beyond-UI-UICustomLayoutElement-_ApplyAlpha0 = 723,
		Beyond-UI-UICustomLayoutElement-_ApplyPosition0 = 724,
		Beyond-UI-UICustomLayout-Save0 = 725,
		Beyond-UI-UICustomLayoutHandle-Save0 = 726,
		Beyond-UI-UICustomLayoutElement-SaveData0 = 727,
		Beyond-UI-UICustomLayoutElement-_CheckElementKeyIsValid0 = 728,
		Beyond-UI-UICustomLayoutElement-GetElementKeyWithRatio0 = 729,
		Beyond-UI-UICustomLayout-_LogEvent0 = 730,
		Beyond-UI-UICustomLayoutElement-get_highlightRect0 = 731,
		Beyond-UI-UICustomLayoutElement-Awake0 = 732,
		Beyond-UI-UICustomLayoutElement-_SetDefaultValues0 = 733,
		Beyond-UI-UICustomLayoutElement-_OnHudLayoutSaved0 = 734,
		Beyond-UI-UICustomLayoutElement-LoadData0 = 735,
		Beyond-UI-UICustomLayoutElement-Start0 = 736,
		Beyond-UI-UICustomLayoutElement-OnDestroy0 = 737,
		Beyond-UI-UICustomLayoutElement-ClearComponent0 = 738,
		Beyond-UI-UICustomLayoutElement-RefreshAll0 = 739,
		Beyond-UI-UICustomLayoutHandle-set_scale0 = 740,
		Beyond-UI-UICustomLayoutHandle-_ApplyScale0 = 741,
		Beyond-UI-UICustomLayoutHandle-set_position0 = 742,
		Beyond-UI-UICustomLayoutHandle-_CalculatePositionRange0 = 743,
		Beyond-UI-UICustomLayoutHandle-_ApplyPosition0 = 744,
		Beyond-UI-UICustomLayoutHandle-set_alpha0 = 745,
		Beyond-UI-UICustomLayoutHandle-_ApplyAlpha0 = 746,
		Beyond-UI-UICustomLayoutHandle-set_layoutType0 = 747,
		Beyond-UI-UICustomLayoutHandle-_ApplyLayoutType0 = 748,
		Beyond-UI-UICustomLayoutHandle-get_panel0 = 749,
		Beyond-UI-UICustomLayoutHandle-Awake0 = 750,
		Beyond-UI-UICustomLayoutHandle-_OnElementDataLoaded0 = 751,
		Beyond-UI-UICustomLayoutHandle-_OnSystemDisplaySizeChanged0 = 752,
		Beyond-UI-UICustomLayoutHandle-OnDestroy0 = 753,
		Beyond-UI-UICustomLayoutHandle-OnBeginDrag0 = 754,
		Beyond-UI-UICustomLayoutHandle-OnDrag0 = 755,
		Beyond-UI-UICustomLayoutHandle-OnEndDrag0 = 756,
		Beyond-UI-UICustomLayoutHandle-OnPointerClick0 = 757,
		Beyond-UI-UICustomLayoutHandle-ClearComponent0 = 758,
		Beyond-UI-UIDialogText-get_playing0 = 759,
		Beyond-UI-UIDialogText-OnAwake0 = 760,
		Beyond-UI-UIDialogText-ResetPlay0 = 761,
		Beyond-UI-UIDialogText-Start0 = 762,
		Beyond-UI-UIDialogText-SetText0 = 763,
		Beyond-UI-UIDialogText-_RefreshPosY0 = 764,
		Beyond-UI-UIDialogText-RefreshAutoScrollData0 = 765,
		Beyond-UI-UIDialogText-Play0 = 766,
		Beyond-UI-UIDialogText-OnDisable0 = 767,
		Beyond-UI-UIDialogText-OnEnable0 = 768,
		Beyond-UI-UIDialogText-RefreshText0 = 769,
		Beyond-UI-UIDialogText-Tick0 = 770,
		Beyond-UI-UIDialogText-_UpdateTextAuto0 = 771,
		Beyond-UI-UIDialogText-OnVisibleCharactersChanged0 = 772,
		Beyond-UI-UIDialogText-StopPlay0 = 773,
		Beyond-UI-UIDialogText-_TryAutoScroll0 = 774,
		Beyond-UI-UIDialogText-GetAutoWaitTime0 = 775,
		Beyond-UI-UIDialogText-GetScrollSpeed0 = 776,
		Beyond-UI-UIDialogText-SeekToEnd0 = 777,
		Beyond-UI-UIDialogText-ManualUpdateByPercent0 = 778,
		Beyond-UI-UIDialogText-ManualUpdateByTime0 = 779,
		Beyond-UI-UIDialogText-GetDisplayAllCharactersTime0 = 780,
		Beyond-UI-UIDialogTextWithCursor-ResetPlay0 = 781,
		Beyond-UI-UIDialogTextWithCursor-OnVisibleCharactersChanged0 = 782,
		Beyond-UI-UIDialogTextWithCursor-GetDisplayAllCharactersTime0 = 783,
		Beyond-UI-UIDialogTimelineText-get_canvasGroup0 = 784,
		Beyond-UI-UIDialogTimelineText-UpdateAlpha0 = 785,
		Beyond-UI-UIDialogTimelineText-SetRadioIcon0 = 786,
		Beyond-UI-UIImage-LoadSprite0 = 787,
		Beyond-UI-UIDialogTimelineText-_ClearRadioIcon0 = 788,
		Beyond-UI-UIDrag-Awake0 = 790,
		Beyond-UI-UIDrag-OnDrag0 = 791,
		Beyond-UI-UIDrag-OnBeginDrag0 = 792,
		Beyond-UI-UIDrag-OnEndDrag0 = 793,
		Beyond-UI-UIDrag-ApplyDragArea0 = 794,
		Beyond-UI-UIDrag-ClearComponent0 = 795,
		Beyond-UI-UIDragHandler-ClearComponent0 = 796,
		Beyond-UI-UIDragHandler-OnPointerDown0 = 797,
		Beyond-UI-UIDragHandler-OnBeginDrag0 = 798,
		Beyond-UI-UIDragHandler-OnDrag0 = 799,
		Beyond-UI-UIDragHandler-OnEndDrag0 = 800,
		Beyond-UI-UIDragItem-get_panel0 = 801,
		Beyond-UI-UIDragItem-get_m_dragParentRect0 = 802,
		Beyond-UI-UIDragItem-Awake0 = 803,
		Beyond-UI-UIDragItem-Start0 = 804,
		Beyond-UI-UIDragItem-OnDisable0 = 805,
		Beyond-UI-UIDragItem-OnEndDrag0 = 806,
		Beyond-UI-UIDragItem-_StopDragView0 = 807,
		Beyond-UI-UIDragItem-_ContinueDragOnDisable0 = 808,
		Beyond-UI-UIDragItem-OnDrag0 = 812,
		Beyond-UI-UIDragItem-OnDestroy0 = 817,
		Beyond-UI-UIDragItem-ClearComponent0 = 818,
		Beyond-UI-UIDragItem-ClearEvents0 = 821,
		Beyond-UI-UIDragItem-OnEnable0 = 822,
		Beyond-UI-UIDragItem-OnBeginDrag0 = 823,
		Beyond-UI-UIDropdown-get_panel0 = 824,
		Beyond-UI-UIDropdown-Awake0 = 825,
		Beyond-UI-UIDropdown-_InitBinding0 = 826,
		Beyond-UI-UIDropdown-_GetDefaultNaviTarget0 = 829,
		Beyond-UI-UIDropdown-_ControllerToggle0 = 831,
		Beyond-UI-UIDropdown-_ToggleOptions0 = 833,
		Beyond-UI-UISelectableNaviGroup-ManuallyFocus0 = 837,
		Beyond-UI-UISelectableNaviGroup-_OnFocus0 = 838,
		Beyond-UI-UIDropdown-_ControllerCancel0 = 840,
		Beyond-UI-UISelectableNaviGroup-ManuallyStopFocus0 = 841,
		Beyond-UI-UISelectableNaviGroup-_OnStopFocus0 = 842,
		Beyond-UI-UIDropdown-ToggleOptions0 = 843,
		Beyond-UI-UIDropdown-_NotifyIsHover0 = 844,
		Beyond-UI-UIDropdown-OnPointerClick0 = 845,
		Beyond-UI-UIDropdown-Init0 = 846,
		Beyond-UI-UIDropdown-Update0 = 847,
		Beyond-UI-UIDropdown-_GetUICamera0 = 848,
		Beyond-UI-UIDropdown-SetSelected0 = 849,
		Beyond-UI-UIDropdown-ScrollToSelected0 = 852,
		Beyond-UI-UIScrollRect-AutoScrollToRectTransform0 = 853,
		Beyond-UI-UIScrollRect-_GetUICamera0 = 854,
		Beyond-UI-UIScrollRect-get_panel0 = 855,
		Beyond-UI-UIScrollRect-ScrollTo0 = 856,
		Beyond-UI-UIDropdown-Refresh0 = 857,
		Beyond-UI-UIDropdown-ClearComponent0 = 861,
		Beyond-UI-UIDropdown-get_bindingViewLabelText0 = 862,
		Beyond-UI-UIDropdown-get_bindingViewState0 = 863,
		Beyond-UI-UIDropdown-GetBindingViewActionId0 = 864,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyDown0 = 865,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyUp0 = 866,
		Beyond-UI-UIDropdown-OnEnable0 = 867,
		Beyond-UI-UIDropdown-OnDisable0 = 868,
		Beyond-UI-UIDropdown-OnDestroy0 = 869,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.get_interactable0 = 870,
		Beyond-UI-UIDropdownOption-SetText0 = 871,
		Beyond-UI-UIDropdownOption-SetState0 = 872,
		Beyond-UI-UIState-UIStateController-SetState0 = 873,
		Beyond-UI-UIState-StateReference-SetController0 = 876,
		Beyond-UI-UIState-UIStateController-_ApplyState0 = 877,
		Beyond-UI-UIState-StateDescription-get_IsEmpty0 = 878,
		Beyond-UI-UIState-StateDescription-ApplyGameObject0 = 879,
		Beyond-UI-UIState-StateDescription-ApplyComponent0 = 880,
		Beyond-UI-UIState-StateDescription-ApplyGraphic0 = 881,
		Beyond-UI-UIState-StateDescription-ApplyRectTransform0 = 882,
		Beyond-UI-UIState-UIStateControllerUtils-SetTop0 = 883,
		Beyond-UI-UIState-UIStateControllerUtils-SetBottom0 = 884,
		Beyond-UI-UIState-UIStateControllerUtils-SetLeft0 = 885,
		Beyond-UI-UIState-UIStateControllerUtils-SetRight0 = 886,
		Beyond-UI-UIState-UIStateControllerUtils-ForceRebuildLayout0 = 887,
		Beyond-UI-UIState-StateDescription-ApplyImage0 = 888,
		Beyond-UI-UIState-StateDescription-ApplyText0 = 891,
		Beyond-UI-UIState-StateDescription-ApplyCanvasGroup0 = 892,
		Beyond-UI-UIState-StateDescription-ApplyButton0 = 893,
		Beyond-UI-UIState-StateDescription-ApplyAnimator0 = 894,
		Beyond-UI-UIState-StateDescription-ApplyLayoutElement0 = 895,
		Beyond-UI-UIState-StateDescription-ApplyInnerState0 = 896,
		Beyond-UI-UIState-StateDescription-ApplyAnimation0 = 897,
		Beyond-UI-UIState-StateReference-ScheduleForPlaying0 = 898,
		Beyond-UI-UIState-UIStateController-OnStateReferenceDirty0 = 899,
		Beyond-UI-UIState-UIStateControllerUtils-StartEditorUpdateLoop0 = 900,
		Beyond-UI-UIState-StateAnimationInfo-OnUpdate0 = 901,
		Beyond-UI-UIState-StateReference-ScheduleForStopping0 = 908,
		Beyond-UI-UIState-StateDescription-ApplyLayoutGroup0 = 909,
		Beyond-UI-UIState-StateDescription-ApplyScrollList0 = 910,
		Beyond-UI-UIScrollList-SetPadding0 = 911,
		Beyond-UI-UIScrollList-UpdateContainerSize0 = 912,
		Beyond-UI-UIScrollList-GetLeftLength0 = 913,
		Beyond-UI-UIScrollList-_SetRealPadding0 = 914,
		Beyond-UI-UIScrollList-SetContainerSize0 = 916,
		Beyond-UI-UIScrollList-GetContainerSize0 = 917,
		Beyond-UI-UIState-StateDescription-ApplyGridLayoutGroup0 = 918,
		Beyond-UI-UIDropItem-ClearEvents0 = 919,
		Beyond-UI-UIDropItem-Awake0 = 920,
		Beyond-UI-UIDropItem-OnEnable0 = 921,
		Beyond-UI-UIDropItem-ToggleHighlight0 = 922,
		Beyond-UI-UIDropItem-OnDisable0 = 923,
		Beyond-UI-UIDropItem-OnDestroy0 = 924,
		Beyond-UI-UIDropItem-ClearComponent0 = 926,
		Beyond-UI-UIDropItem-OnDrop0 = 927,
		Beyond-UI-UIElementFollower-get_panel0 = 928,
		Beyond-UI-UIElementFollower-OnAwake0 = 929,
		Beyond-UI-UIElementFollower-OnEnable0 = 930,
		Beyond-UI-UIElementFollower-UpdatePosition1 = 932,
		Beyond-UI-UIElementFollower-UpdatePosition0 = 933,
		Beyond-UI-UIElementFollower-LateTick0 = 935,
		Beyond-UI-UIExtendScrollRect-OnScroll0 = 936,
		Beyond-UI-UIExtendScrollRect-OnBeginDrag0 = 937,
		Beyond-UI-UIScrollList-OnBeginDrag0 = 938,
		Beyond-UI-UIExtendScrollRect-OnDrag0 = 939,
		Beyond-UI-UIScrollList-OnDrag0 = 940,
		Beyond-UI-UIExtendScrollRect-OnEndDrag0 = 941,
		Beyond-UI-UIScrollList-OnEndDrag0 = 942,
		Beyond-UI-UIFoldoutComponent-Refresh0 = 943,
		Beyond-UI-UIFoldoutComponent-OnFoldOut0 = 944,
		Beyond-UI-UINonUnifiedScrollList-NotifyCellSizeChange0 = 948,
		Beyond-UI-UIFoldoutComponent-OnFoldIn0 = 949,
		Beyond-UI-UIFoldoutComponent-OnDestroy0 = 953,
		Beyond-UI-UIGraphicAnimation-OnAwake0 = 954,
		Beyond-UI-UIGraphicAnimation-_Init0 = 955,
		Beyond-UI-UIGraphicAnimation-OnRelease0 = 956,
		Beyond-UI-UIGraphicAnimation-LateTick0 = 957,
		Beyond-UI-UIGridLayoutNaviWrapper-_InitIfNot0 = 958,
		Beyond-UI-UIGridLayoutNaviWrapper-Start0 = 959,
		Beyond-UI-UIGridLayoutNaviWrapper-_InitWrapNavigation0 = 960,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayout0 = 961,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutImpl0 = 962,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviChildren0 = 963,
		Beyond-UI-UIGridLayoutNaviWrapper-_SetCircleWrapScroll0 = 964,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutInit0 = 965,
		Beyond-UI-UIGridLayoutNaviWrapper-_FindValidSelectable0 = 966,
		Beyond-UI-UIScrollRect-WrapNavigation0 = 967,
		Beyond-UI-UIScrollRect-RectWrapNavigate0 = 968,
		Beyond-UI-UIGridLayoutNaviWrapper-TryWrapNavigate0 = 969,
		Beyond-UI-UIGyroscopeEffect-OnAwake0 = 970,
		Beyond-UI-UIGyroscopeEffect-Tick0 = 971,
		Beyond-UI-UIGyroscopeEffect-OnRelease0 = 974,
		Beyond-UI-UIHighlightMask-get_panel0 = 975,
		Beyond-UI-UIHighlightMask-OnAwake0 = 976,
		Beyond-UI-UIHighlightMask-OnEnable0 = 977,
		Beyond-UI-UIHighlightMask-TrySyncRect0 = 978,
		Beyond-UI-UIHighlightMask-Tick0 = 979,
		Beyond-UI-UIImage-get_panel0 = 980,
		Beyond-UI-UIImage-RegisterOnEnableRuntimeAtlas0 = 981,
		Beyond-UI-UIImage-UnregisterOnEnableRuntimeAtlas0 = 982,
		Beyond-UI-UIImage-OnEnableRuntimeAtlas0 = 983,
		Beyond-UI-UIImage-set_color0 = 984,
		Beyond-UI-UIImage-_OnSpriteChanged0 = 985,
		Beyond-UI-UIAtlasManager-get_enableRuntimeAtlas0 = 986,
		Beyond-UI-UIAtlasManager-ReProcessInsertForUIImage0 = 988,
		Beyond-UI-UIAtlasManager-_ReProcessInsertForUIImage0 = 989,
		Beyond-UI-UIAtlasManager-UIAtlasHandle-CreateInvalidHandle0 = 990,
		Beyond-UI-UIImage-OnPopulateMesh0 = 991,
		Beyond-UI-UIImage-Awake0 = 992,
		Beyond-UI-UIAtlasManager-AddUIImageToManagerOnInstantiate0 = 993,
		Beyond-UI-UIAtlasManager-_AddUIImageToManagerOnInstantiate0 = 994,
		Beyond-UI-UIImage-OnEnable0 = 996,
		Beyond-UI-UIAtlasManager-AddUIImageToManager0 = 998,
		Beyond-UI-UIAtlasManager-_AddUIImageToManager0 = 999,
		Beyond-UI-UIImage-OnDisable0 = 1000,
		Beyond-UI-UIImage-OnDestroy0 = 1001,
		Beyond-UI-UIAtlasManager-RemoveUIImageFromManager0 = 1002,
		Beyond-UI-UIAtlasManager-_RemoveUIImageFromManager0 = 1003,
		Beyond-UI-UIImage-SetNativeSize0 = 1004,
		Beyond-UI-UIImage-SetNativeSizeIgnoreRefScale0 = 1005,
		Beyond-UI-UIImage-LoadSprite1 = 1006,
		Beyond-UI-UIImage-LoadMaterial0 = 1007,
		Beyond-UI-UIImage-ReleaseSprite0 = 1008,
		Beyond-UI-UIImage-get_mainTexture0 = 1009,
		Beyond-UI-UIImage-_V2AtlasInitialize0 = 1010,
		Beyond-UI-UIImageBlur-OnAwake0 = 1012,
		Beyond-UI-UIImageBlur-OnChangeSprite0 = 1013,
		Beyond-UI-UIImageBlur-Tick0 = 1014,
		Beyond-UI-UIImageBlur-OnDisable0 = 1015,
		Beyond-UI-UIImageBlur-OnRelease0 = 1016,
		Beyond-UI-UIImageFillAmountOffset-set_fillAmount0 = 1017,
		Beyond-UI-UIImageFillAmountOffset-DOFillAmount0 = 1018,
		Beyond-UI-UIImageFillFollower-OnAwake0 = 1021,
		Beyond-UI-UIImageFillFollower-OnEnable0 = 1022,
		Beyond-UI-UIImageFillFollower-Tick0 = 1023,
		Beyond-UI-UIImageFillFollower-RefreshFillAmount0 = 1024,
		Beyond-UI-UIImageFillTailFollower-OnAwake0 = 1025,
		Beyond-UI-UIImageFillTailFollower-OnEnable0 = 1026,
		Beyond-UI-UIImageFillTailFollower-RefreshFollower0 = 1027,
		Beyond-UI-UIImageFillTailFollower-Tick0 = 1028,
		Beyond-UI-UIImagePair-LoadSprite1 = 1029,
		Beyond-UI-UIImagePair-LoadSprite0 = 1030,
		Beyond-UI-UIImagePair-set_color0 = 1031,
		Beyond-UI-UIImagePair-get_first0 = 1032,
		Beyond-UI-UIInertiaViewPager-_PlayAudioGear0 = 1033,
		Beyond-UI-UIInertiaViewPager-_PlayAudioGearLock0 = 1034,
		Beyond-UI-UIInertiaViewPager-_InitIfNot0 = 1035,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-Reset0 = 1036,
		Beyond-UI-UIInertiaViewPager-ScrollEffectConfig-IsEmpty0 = 1037,
		Beyond-UI-UIInertiaViewPager-ClearComponent0 = 1038,
		Beyond-UI-UIInertiaViewPager-Tick0 = 1039,
		Beyond-UI-UIInertiaViewPager-DragContext-BeginDrag0 = 1040,
		Beyond-UI-UIInertiaViewPager-DragContext-EndDrag0 = 1041,
		Beyond-UI-UIInertiaViewPager-DragContext-_TryFlingToNext0 = 1042,
		Beyond-UI-UIInertiaViewPager-_ScrollValueAlignToPage0 = 1043,
		Beyond-UI-UIInertiaViewPager-_SwitchToPage0 = 1045,
		Beyond-UI-UIInertiaViewPager-_ScrollValue2PageIndex0 = 1046,
		Beyond-UI-UIInertiaViewPager-_PageIndex2ScrollValue0 = 1047,
		Beyond-UI-UIInertiaViewPager-BlockerManager-StartInertia0 = 1049,
		Beyond-UI-UIInertiaViewPager-BlockerManager-HitInertiaBlock0 = 1051,
		Beyond-UI-UIInertiaViewPager-InertiaBlocker-IsDirMatch0 = 1052,
		Beyond-UI-UIInertiaViewPager-_AutoAlign0 = 1053,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyScrolling0 = 1054,
		Beyond-UI-UIInertiaViewPager-_OnStateChanged0 = 1055,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyAlignFinish0 = 1056,
		Beyond-UI-UIInertiaViewPager-SetPageCount0 = 1057,
		Beyond-UI-UIInertiaViewPager-BlockerManager-Init0 = 1059,
		Beyond-UI-UIInertiaViewPager-MoveToPage0 = 1060,
		Beyond-UI-UIInertiaViewPager-OnAwake0 = 1061,
		Beyond-UI-UIInertiaViewPager-OnEnable0 = 1062,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-OnClear0 = 1063,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollBegin0 = 1064,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollEnd0 = 1065,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_velocity0 = 1066,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_scrollProgress0 = 1067,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-set_scrollProgress0 = 1068,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-StopMoving0 = 1069,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-StopMoving0 = 1070,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-OnClear0 = 1071,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-MarkHasScrolled0 = 1072,
		Beyond-UI-UIInputField-get_panel0 = 1073,
		Beyond-UI-UIInputField-get_isControllerInputValid0 = 1074,
		Beyond-UI-UIInputField-SendOnFocus0 = 1077,
		Beyond-UI-UIInputField-SendOnFocusLost0 = 1078,
		Beyond-UI-UIInputField-Awake0 = 1079,
		Beyond-UI-UIInputField-_VirtualKeyboardAwake0 = 1083,
		Beyond-UI-UIInputField-_VirtualKeyboardInitJavaObj0 = 1084,
		Beyond-UI-UIInputField-OnSelect0 = 1085,
		Beyond-UI-UIInputField-_VirtualKeyboardSelect0 = 1086,
		Beyond-UI-UIInputField-OnDeselect0 = 1087,
		Beyond-UI-UIInputField-_VirtualKeyboardDeselect0 = 1088,
		Beyond-UI-UIInputField-ActivateInputField0 = 1089,
		Beyond-UI-UIInputField-set_s_focusedInputField0 = 1090,
		Beyond-UI-UIInputField-DeactivateInputField0 = 1091,
		Beyond-UI-UIInputField-OnDestroy0 = 1092,
		Beyond-UI-UIInputField-ClearComponent0 = 1093,
		Beyond-UI-UIInputField-_VirtualKeyboardOnDestroy0 = 1094,
		Beyond-UI-UIInputField-OnEnable0 = 1095,
		Beyond-UI-UIInputField-_UpdateBindingEnable0 = 1096,
		Beyond-UI-UIInputField-OnDisable0 = 1097,
		Beyond-UI-UIInputField-_NotifyIsHover0 = 1098,
		Beyond-UI-UIInputField-OnInteractableChanged0 = 1099,
		Beyond-UI-UIInputField-_GetCamera0 = 1100,
		Beyond-UI-UIInputField-_UpdateKeyboardOffset0 = 1101,
		Beyond-UI-UIInputField-_CleanupAndroidObjects0 = 1102,
		Beyond-UI-UIInputField-_KeyboardHeightChange0 = 1103,
		Beyond-UI-UIJoystick-get_panel0 = 1110,
		Beyond-UI-UIJoystick-set_walkRation0 = 1111,
		Beyond-UI-UIJoystick-_UpdateWalkBgScale0 = 1112,
		Beyond-UI-UIJoystick-get_m_thumbPosMaxLength0 = 1113,
		Beyond-UI-UIJoystick-Reset0 = 1114,
		Beyond-UI-UIJoystick-Awake0 = 1115,
		Beyond-UI-UIJoystick-InitBinding0 = 1116,
		Beyond-UI-UIJoystick-_UpdateState0 = 1119,
		Beyond-UI-UIJoystick-OnPointerDown0 = 1120,
		Beyond-UI-UIJoystick-_SetRectTransform0 = 1121,
		Beyond-UI-UIJoystick-_Activate0 = 1122,
		Beyond-UI-UIJoystick-_SetVisible0 = 1123,
		Beyond-UI-UIJoystick-_UpdateGait0 = 1125,
		Beyond-UI-UIJoystick-_UpdateIndicator0 = 1127,
		Beyond-UI-UIJoystick-_UpdateBg0 = 1128,
		Beyond-UI-UIJoystick-_SetWalkBgVisible0 = 1129,
		Beyond-UI-UIJoystick-_SetRunBgVisible0 = 1130,
		Beyond-UI-UIJoystick-OnPointerUp0 = 1131,
		Beyond-UI-UIJoystick-OnBeginDrag0 = 1132,
		Beyond-UI-UIJoystick-OnDrag0 = 1134,
		Beyond-UI-UIJoystick-_ChangeDynamic0 = 1136,
		Beyond-UI-UIJoystick-_OnHudLayoutLoaded0 = 1137,
		Beyond-UI-UIJoystick-OnEnable0 = 1138,
		Beyond-UI-UIJoystick-_Tick0 = 1139,
		Beyond-UI-UIJoystick-Start0 = 1140,
		Beyond-UI-UIJoystick-OnDestroy0 = 1141,
		Beyond-UI-UIJoystick-ClearComponent0 = 1142,
		Beyond-UI-UIJoystick-OnDisable0 = 1143,
		Beyond-UI-UIJoystick-CheckShouldActive0 = 1144,
		Beyond-UI-UILayoutDimensionListener-GraphicUpdateComplete0 = 1145,
		Beyond-UI-UILayoutDimensionListener-LayoutComplete0 = 1146,
		Beyond-UI-UILayoutDimensionListener-Rebuild0 = 1147,
		Beyond-UI-UILayoutDimensionListener-_NextFrameCoroutine0 = 1148,
		Beyond-UI-UILayoutDimensionListener-_InvokePostLayoutCallback0 = 1152,
		Beyond-UI-UILayoutDimensionListener-DoOnceOnPostLayout0 = 1156,
		Beyond-UI-UILayoutDimensionListener-OnEnable0 = 1157,
		Beyond-UI-UILayoutDimensionListener-_SetDirty0 = 1158,
		Beyond-UI-UILayoutDimensionListener-OnRectTransformDimensionsChange0 = 1159,
		Beyond-UI-UILayoutDimensionListener-OnDestroy0 = 1160,
		Beyond-UI-UILayoutDimensionListener-UnityEngine.UI.ICanvasElement.get_transform0 = 1161,
		Beyond-UI-UILeftSubtitle-Tick0 = 1162,
		Beyond-UI-UILeftSubtitle-UpdateByPlayTime0 = 1163,
		Beyond-UI-UILeftSubtitle-Exit0 = 1164,
		Beyond-UI-UILeftSubtitle-SetVisible0 = 1166,
		Beyond-UI-UILeftSubtitle-StartAutoPlay0 = 1167,
		Beyond-UI-UILeftSubtitle-SetLeftSubTitle0 = 1168,
		Beyond-UI-UIMaterialAnimation-LateTick0 = 1169,
		Beyond-UI-UIMaterialAnimation-_TryUpdate0 = 1170,
		Beyond-UI-UIMaterialAnimation-OnAwake0 = 1171,
		Beyond-UI-UIMaterialAnimation-OnRelease0 = 1172,
		Beyond-UI-UIMaterialAnimation-ForceUpdate0 = 1173,
		Beyond-UI-UINonUnifiedScrollList-InitBasicInfo0 = 1174,
		Beyond-UI-UIScrollList-InitBasicInfo0 = 1175,
		Beyond-UI-UIScrollList-SyncViewSize0 = 1176,
		Beyond-UI-UIScrollList-CalcSomeCountNum0 = 1177,
		Beyond-UI-UIScrollList-_GetLineCount0 = 1178,
		Beyond-UI-UINonUnifiedScrollList-CalcSomeCountNum0 = 1179,
		Beyond-UI-UINonUnifiedScrollList-GetLeftLength0 = 1180,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount0 = 1181,
		Beyond-UI-UIScrollList-UpdateCount1 = 1182,
		Beyond-UI-UIScrollList-UpdateCount0 = 1183,
		Beyond-UI-UIScrollList-InitConfig0 = 1184,
		Beyond-UI-UIScrollList-_StartGraduallyShow0 = 1186,
		Beyond-UI-UIScrollList-get_currentStep0 = 1187,
		Beyond-UI-UIScrollList-get_panel0 = 1188,
		Beyond-UI-UIScrollList-SkipGraduallyShow0 = 1189,
		Beyond-UI-UIScrollList-StopGraduallyShow0 = 1190,
		Beyond-UI-UIScrollList-ScrollTo0 = 1191,
		Beyond-UI-UIScrollList-GetTargetPosByIndex0 = 1192,
		Beyond-UI-UIScrollList-_ScrollToPos0 = 1193,
		Beyond-UI-UIScrollList-TryClearAdjustTween0 = 1194,
		Beyond-UI-UIScrollList-RestartGraduallyShow0 = 1201,
		Beyond-UI-UIScrollList-_ClearRelatedNaviGroup0 = 1202,
		Beyond-UI-UISelectableNaviGroup-ClearLastFocusNaviTarget0 = 1203,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount1 = 1204,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount2 = 1205,
		Beyond-UI-UINonUnifiedScrollList-LateTick0 = 1206,
		Beyond-UI-UIScrollList-TryRecalculateSize0 = 1207,
		Beyond-UI-UIScrollList-_InitNavigation0 = 1208,
		Beyond-UI-UIScrollList-NavigateSelected0 = 1210,
		Beyond-UI-UIScrollList-get_curSelectedIndex0 = 1211,
		Beyond-UI-UIScrollList-SetSelectedIndex0 = 1212,
		Beyond-UI-UIScrollList-set_curSelectedIndex0 = 1213,
		Beyond-UI-UIScrollList-Get0 = 1214,
		Beyond-UI-UIScrollList-GetCell1 = 1215,
		Beyond-UI-UIScrollList-ScrollToIndex0 = 1216,
		Beyond-UI-UIScrollList-GetNaviNewIndex0 = 1217,
		Beyond-UI-UIScrollList-GetNaviOffset0 = 1218,
		Beyond-UI-UINonUnifiedScrollList-OnScroll0 = 1226,
		Beyond-UI-UINonUnifiedScrollList-GetGridLayoutSize0 = 1227,
		Beyond-UI-UINonUnifiedScrollList-_GetCellSize0 = 1228,
		Beyond-UI-UINonUnifiedScrollList-GetContainerSize0 = 1229,
		Beyond-UI-UIScrollRect-get_inScrollTween0 = 1230,
		Beyond-UI-UINonUnifiedScrollList-GetCenterIndex0 = 1231,
		Beyond-UI-UINonUnifiedScrollList-GetShowRange0 = 1232,
		Beyond-UI-UINonUnifiedScrollList-GetNotCacheRange0 = 1233,
		Beyond-UI-UINonUnifiedScrollList-MoveCellTo0 = 1234,
		Beyond-UI-UINonUnifiedScrollList-_GetCellsSizeTo0 = 1235,
		Beyond-UI-UINonUnifiedScrollList-OnUpdateCell0 = 1236,
		Beyond-UI-UISizeFollower-SyncSize0 = 1237,
		Beyond-UI-UISizeFollower-get_rectTransform0 = 1238,
		Beyond-UI-UINonUnifiedScrollList-GetTargetPosByIndex0 = 1239,
		Beyond-UI-UINonUnifiedScrollList-ScrollTo0 = 1240,
		Beyond-UI-UINonUnifiedScrollList-ClearComponent0 = 1241,
		Beyond-UI-UIScrollList-ClearComponent0 = 1242,
		Beyond-UI-UINonUnifiedScrollList-get_currentStep0 = 1243,
		Beyond-UI-UINonUnifiedScrollList-SetStepTo0 = 1244,
		Beyond-UI-UINonUnifiedScrollList-SetCurrentStep0 = 1245,
		Beyond-UI-UINonUnifiedScrollList-GetScrollBarSize0 = 1246,
		Beyond-UI-UINonUnifiedScrollList-GetLastScrollStep0 = 1248,
		Beyond-UI-UINonUnifiedScrollList-UpdateLastScrollStep0 = 1249,
		Beyond-UI-UINonUnifiedScrollList-GetNormalizedPosition0 = 1250,
		Beyond-UI-UINonUnifiedScrollList-SetNormalizedPosition0 = 1251,
		Beyond-UI-UINonUnifiedScrollList-ToggleByState0 = 1252,
		Beyond-UI-UINonUnifiedScrollList-Toggle0 = 1253,
		Beyond-UI-UINonUnifiedScrollList-FoldAll0 = 1254,
		Beyond-UI-UINonUnifiedScrollRect-_InitIfNot0 = 1255,
		Beyond-UI-UINonUnifiedScrollRect-_OnPostLayout0 = 1256,
		Beyond-UI-UINonUnifiedScrollRect-_UpdateNonUnifiedScrollbars0 = 1257,
		Beyond-UI-UINonUnifiedScrollRect-UpdateScrollbars0 = 1258,
		Beyond-UI-UINonUnifiedScrollRect-Rebuild0 = 1259,
		Beyond-UI-UINonUnifiedScrollRect-SetHorizontalNormalizedPosition0 = 1260,
		Beyond-UI-UINonUnifiedScrollRect-SetVerticalNormalizedPosition0 = 1261,
		Beyond-UI-UINumberScrollTween-get_text0 = 1262,
		Beyond-UI-UINumberScrollTween-set_text0 = 1263,
		Beyond-UI-UINumberScrollTween-Start0 = 1264,
		Beyond-UI-UINumberScrollTween-Tick0 = 1265,
		Beyond-UI-UINumberScrollTween-_HandleNumberScrollTween0 = 1266,
		Beyond-UI-UINumberScrollTween-_TweenToTarget0 = 1267,
		Beyond-UI-UINumberScrollTween-_CleanupBeforeTween0 = 1268,
		Beyond-UI-UIPCScaleHelper-OnEnable0 = 1269,
		Beyond-UI-UIRegionBuildingTexManager-OnEnable0 = 1270,
		Beyond-UI-UIRegionBuildingTexManager-_UpdateTexture0 = 1271,
		Beyond-UI-UIRegionBuildingTexManager-OnValidate0 = 1272,
		Beyond-UI-UIRegionBuildingTexManager-OnDisable0 = 1273,
		Beyond-UI-UIScaleHolder-OnAwake0 = 1274,
		Beyond-UI-UIScaleHolder-OnEnable0 = 1275,
		Beyond-UI-UIScaleHolder-_HoldScale0 = 1276,
		Beyond-UI-UIScaleHolder-_IsValidScale0 = 1277,
		Beyond-UI-UIScaleHolder-LateTick0 = 1278,
		Beyond-UI-UIScaleHolder-SetExtraScale0 = 1279,
		Beyond-UI-UIScaleHolder-GetExtraScale0 = 1280,
		Beyond-UI-UIScrollbar-Awake0 = 1281,
		Beyond-UI-UIScrollbarKeyHint-OnAwake0 = 1282,
		Beyond-UI-UIScrollbarKeyHint-Tick0 = 1283,
		Beyond-UI-UIScrollRect-get_controllerStickScrollEnabled0 = 1284,
		Beyond-UI-UIScrollCircle-get_panel0 = 1285,
		Beyond-UI-UIScrollCircle-get_viewRect0 = 1286,
		Beyond-UI-UIScrollCircle-OnInitializePotentialDrag0 = 1287,
		Beyond-UI-UIScrollCircle-IsActive0 = 1288,
		Beyond-UI-UIScrollCircle-OnBeginDrag0 = 1289,
		Beyond-UI-UIScrollCircle-OnEndDrag0 = 1290,
		Beyond-UI-UIScrollCircle-OnDrag0 = 1291,
		Beyond-UI-UIScrollCircle-_GetDeltaAngle0 = 1292,
		Beyond-UI-UIScrollCircle-_CheckCanMove0 = 1293,
		Beyond-UI-UIScrollCircle-_UpdateSpeed0 = 1294,
		Beyond-UI-UIScrollCircle-_TryUpdateCells0 = 1295,
		Beyond-UI-UIScrollCircle-_UpdateCenterIndex0 = 1296,
		Beyond-UI-UIScrollCircle-_UpdateShowingCells0 = 1298,
		Beyond-UI-UIScrollCircle-_GetRealIndex0 = 1299,
		Beyond-UI-UIScrollCircle-_UpdateAuto0 = 1300,
		Beyond-UI-UIScrollCircle-OnRelease0 = 1301,
		Beyond-UI-UIScrollCircle-_InitCells0 = 1302,
		Beyond-UI-UIScrollCircle-_Init0 = 1303,
		Beyond-UI-UIScrollCircle-_OnAwakeInit0 = 1304,
		Beyond-UI-UIScrollCircle-_UpdateScrollRange0 = 1305,
		Beyond-UI-UIScrollCircle-_DoScroll0 = 1306,
		Beyond-UI-UIScrollCircle-OnScroll0 = 1308,
		Beyond-UI-UIScrollCircle-Rebuild0 = 1309,
		Beyond-UI-UIScrollCircle-LayoutComplete0 = 1310,
		Beyond-UI-UIScrollCircle-GraphicUpdateComplete0 = 1311,
		Beyond-UI-UIScrollCircle-IsDestroyed0 = 1312,
		Beyond-UI-UIScrollCircle-OnEnable0 = 1313,
		Beyond-UI-UIScrollCircle-OnDisable0 = 1314,
		Beyond-UI-UIScrollCircle-Start0 = 1315,
		Beyond-UI-UIScrollCircle-OnAwake0 = 1316,
		Beyond-UI-UIScrollCircle-LateTick0 = 1317,
		Beyond-UI-UIScrollCircle-UpdateCount0 = 1318,
		Beyond-UI-UIScrollCircle-ScrollToIndex0 = 1320,
		Beyond-UI-UIScrollCircle-Get0 = 1321,
		Beyond-UI-UIScrollCircle-ClearComponent0 = 1322,
		Beyond-UI-UIScrollCircle-UnityEngine.UI.ICanvasElement.get_transform0 = 1323,
		Beyond-UI-UIScrollCircle-Cell-SetSelect0 = 1324,
		Beyond-UI-UIScrollContainerFollower-OnAwake0 = 1325,
		Beyond-UI-UIScrollContainerFollower-LateTick0 = 1326,
		Beyond-UI-UIScrollContainerFollower-_RefreshSizeAndPositionToTargetContainer0 = 1328,
		Beyond-UI-UIScrollList-OnAwake0 = 1329,
		Beyond-UI-UIScrollList-Init0 = 1330,
		Beyond-UI-UIScrollList-_InGameAwake0 = 1331,
		Beyond-UI-UIScrollList-_InitAutoScroll0 = 1332,
		Beyond-UI-UIScrollList-_OnEnterAutoScrollUp0 = 1333,
		Beyond-UI-UIScrollList-_SetAutoScrollSpd0 = 1335,
		Beyond-UI-UIScrollList-_OnExitAutoScrollUp0 = 1336,
		Beyond-UI-UIScrollList-_OnEnterAutoScrollDown0 = 1337,
		Beyond-UI-UIScrollList-_OnExitAutoScrollDown0 = 1339,
		Beyond-UI-UIScrollList-_InitControllerNavi0 = 1340,
		Beyond-UI-UIScrollList-ListWrapNavigate0 = 1341,
		Beyond-UI-UIScrollList-_EditorAwake0 = 1342,
		Beyond-UI-UIScrollList-Tick0 = 1343,
		Beyond-UI-UIScrollList-_UpdateGraduallyShow0 = 1344,
		Beyond-UI-UIScrollList-_UpdateAutoScroll0 = 1345,
		Beyond-UI-UIScrollList-SetStepTo0 = 1346,
		Beyond-UI-UIScrollList-LateTick0 = 1347,
		Beyond-UI-UIScrollList-OnEnable0 = 1348,
		Beyond-UI-UIScrollList-OnDisable0 = 1349,
		Beyond-UI-UIScrollList-SetTop0 = 1350,
		Beyond-UI-UIScrollList-UpdateCount2 = 1351,
		Beyond-UI-UIScrollList-UpdateShowingCells1 = 1352,
		Beyond-UI-UIScrollList-GetRangeInView0 = 1353,
		Beyond-UI-UIScrollList-SetCellCanCache0 = 1354,
		Beyond-UI-UIScrollList-CacheShowingCell0 = 1355,
		Beyond-UI-UIScrollList-OnRelease0 = 1356,
		Beyond-UI-UIScrollList-SetPaddingBottom0 = 1357,
		Beyond-UI-UIScrollList-SetPaddingTop0 = 1358,
		Beyond-UI-UIScrollList-SetPaddingRight0 = 1359,
		Beyond-UI-UIScrollList-SetPaddingLeft0 = 1360,
		Beyond-UI-UIScrollList-GetPadding0 = 1361,
		Beyond-UI-UIScrollList-GetShowingCellsIndexRange0 = 1362,
		Beyond-UI-UIScrollList-SetSpace0 = 1363,
		Beyond-UI-UIScrollList-GetCenterIndex0 = 1364,
		Beyond-UI-UIScrollList-GetMousePosIndex0 = 1365,
		Beyond-UI-UIScrollList-ScreenPos2Index0 = 1366,
		Beyond-UI-UIScrollList-GetIndexOf0 = 1367,
		Beyond-UI-UIScrollList-_GetScreenPosLineColumnInfo0 = 1368,
		Beyond-UI-UIScrollRect-Awake0 = 1369,
		Beyond-UI-UIScrollRect-_CheckOverScrollEffect0 = 1370,
		Beyond-UI-UIScrollRect-OnEnable0 = 1371,
		Beyond-UI-UIScrollRect-_InitController0 = 1372,
		Beyond-UI-UIScrollRect-ScrollToNaviTarget0 = 1373,
		Beyond-UI-UIScrollRect-Update0 = 1374,
		Beyond-UI-UIScrollRect-_TickRefreshControllerStickScroll0 = 1375,
		Beyond-UI-UIScrollRect-_UpdateMoveTips0 = 1376,
		Beyond-UI-UIScrollRect-get_moveTips0 = 1377,
		Beyond-UI-UIScrollRect-IsCellViewed0 = 1378,
		Beyond-UI-UIScrollRect-OnDestroy0 = 1379,
		Beyond-UI-UIScrollRect-_CustomSetPosOnScroll0 = 1380,
		Beyond-UI-UIScrollRect-UpdateScrollEnableNode0 = 1384,
		Beyond-UI-UIScrollRect-OnBeginDrag0 = 1385,
		Beyond-UI-UIScrollRect-OnDrag0 = 1386,
		Beyond-UI-UIScrollRect-OnEndDrag0 = 1387,
		Beyond-UI-UIScrollRect-_CheckOverScrollOnEndDrag0 = 1388,
		Beyond-UI-UIScrollRect-ClearComponent0 = 1389,
		Beyond-UI-UIScrollRect-LateUpdate0 = 1390,
		Beyond-UI-UIScrollRectEdgeRedDot-OnAwake0 = 1391,
		Beyond-UI-UIScrollRectEdgeRedDot-ResetReferences0 = 1392,
		Beyond-UI-UIScrollRectEdgeRedDot-OnEnable0 = 1393,
		Beyond-UI-UIScrollRectEdgeRedDot-_UpdateRedDotGameObjects0 = 1394,
		Beyond-UI-UIScrollRectEdgeRedDot-_OnScrollListUpdateCount0 = 1395,
		Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDotStatesForScrollList0 = 1396,
		Beyond-UI-UIScrollRectEdgeRedDot-OnRelease0 = 1397,
		Beyond-UI-UIScrollRectEdgeRedDot-Tick0 = 1398,
		Beyond-UI-UIScrollRectEdgeRedDot-_UpdateCacheDictForRangeChange0 = 1399,
		Beyond-UI-UIScrollRectEdgeRedDot-UpdateRedDotStateInDir0 = 1400,
		Beyond-UI-UIScrollRectEdgeRedDot-_CalculateRedDotStateInDir0 = 1401,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_state0 = 1402,
		Beyond-UI-UIScrollRectEdgeRedDot-IsRedDotInDir0 = 1403,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newPos0 = 1404,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalPos0 = 1405,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newRect0 = 1406,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalRect0 = 1407,
		Beyond-UI-UIScrollRectEdgeRedDot-ResetRedDotPosition0 = 1408,
		Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDot0 = 1409,
		Beyond-UI-UIScrollRectEdgeRedDot-UnregisterRedDot0 = 1410,
		Beyond-UI-UIScrollRectEdgeRedDot-ClearComponent0 = 1411,
		Beyond-UI-UIScrollText-_InitIfNot0 = 1412,
		Beyond-UI-UIScrollText-ResetTextScroll0 = 1413,
		Beyond-UI-UIScrollText-_ResetTextScrollInternal0 = 1414,
		Beyond-UI-UIScrollText-_ApplyTextAlignment0 = 1415,
		Beyond-UI-UIScrollText-_ResetTextScroll0 = 1416,
		Beyond-UI-UIScrollText-OnAwake0 = 1417,
		Beyond-UI-UIScrollText-LateTick0 = 1418,
		Beyond-UI-UIScrollText-_UpdateScrollState0 = 1419,
		Beyond-UI-UIScrollText-_ApplyTextScroll0 = 1420,
		Beyond-UI-UIScrollText-CanvasGroupHandler-HandleAlpha0 = 1421,
		Beyond-UI-UIScrollText-PositionScrollHandler-ApplyScroll0 = 1422,
		Beyond-UI-UIScrollText-PositionScrollHandler-ResetScroll0 = 1423,
		Beyond-UI-UIScrollText-PositionScrollHandler-UpdateScrollStatus0 = 1424,
		Beyond-UI-UIScrollText-MeshScrollHandler-ApplyScroll0 = 1425,
		Beyond-UI-UIScrollText-MeshScrollHandler-_ApplyScroll0 = 1426,
		Beyond-UI-UIScrollText-MeshScrollHandler-_UpdateMeshClipping0 = 1427,
		Beyond-UI-UIScrollText-MeshScrollHandler-ResetScroll0 = 1428,
		Beyond-UI-UIScrollText-MeshScrollHandler-UpdateScrollStatus0 = 1429,
		Beyond-UI-UISelectableNaviGroup-Awake0 = 1430,
		Beyond-UI-UISelectableNaviGroup-_InitFocusBinding0 = 1431,
		Beyond-UI-UISelectableNaviGroup-_RefreshFocusBindings0 = 1434,
		Beyond-UI-UISelectableNaviGroup-OnEnable0 = 1435,
		Beyond-UI-UISelectableNaviGroup-_RefreshRelatedBindingGroupsState0 = 1436,
		Beyond-UI-UISelectableNaviGroup-_RefreshFocusActionKeyHint0 = 1437,
		Beyond-UI-UISelectableNaviGroup-_RefreshStopFocusActionKeyHint0 = 1438,
		Beyond-UI-UISelectableNaviGroup-OnDisable0 = 1439,
		Beyond-UI-UISelectableNaviGroup-_OnIsTopLayerChanged0 = 1440,
		Beyond-UI-UISelectableNaviGroup-_OnSelectableNaviGroupDisabled0 = 1441,
		Beyond-UI-UISelectableNaviGroup-_BeforeSelectableNaviGroupDestroy0 = 1442,
		Beyond-UI-UISelectableNaviGroup-_OnSetLayerSelectedTarget0 = 1443,
		Beyond-UI-UISelectableNaviGroup-_OnRemoveFromLayerStack0 = 1444,
		Beyond-UI-UISelectableNaviGroup-OnDestroy0 = 1445,
		Beyond-UI-UISelectableNaviGroup-ClearComponent0 = 1446,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnUp0 = 1447,
		Beyond-UI-UISelectableNaviGroup-_TryChangeNaviPartner0 = 1448,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnDown0 = 1449,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnLeft0 = 1450,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnRight0 = 1451,
		Beyond-UI-UISelectableNaviGroup-RefreshFocusBindings0 = 1452,
		Beyond-UI-UISelectableNaviGroup-SetFocusBindingText0 = 1453,
		Beyond-UI-UISelectableNaviGroup-ManuallyRefreshRelatedBindingGroups0 = 1454,
		Beyond-UI-UISemiCircleScrollList-get_controllerStickScrollEnabled0 = 1455,
		Beyond-UI-UISemiCircleScrollList-OnAwake0 = 1456,
		Beyond-UI-UISemiCircleScrollList-ClearComponent0 = 1457,
		Beyond-UI-UISemiCircleScrollList-UpdateLayout0 = 1458,
		Beyond-UI-UISemiCircleScrollList-_InitializeCells0 = 1459,
		Beyond-UI-UISemiCircleScrollList-OnDisable0 = 1460,
		Beyond-UI-UISemiCircleScrollList-Tick0 = 1461,
		Beyond-UI-UISemiCircleScrollList-_TickRefreshControllerStickScroll0 = 1462,
		Beyond-UI-UISemiCircleScrollList-OnEndDrag0 = 1463,
		Beyond-UI-UISemiCircleScrollList-_ApplyDamping0 = 1464,
		Beyond-UI-UISemiCircleScrollList-OnDrag0 = 1471,
		Beyond-UI-UISemiCircleScrollList-RefreshLayout0 = 1472,
		Beyond-UI-UISemiCircleScrollList-OnBeginDrag0 = 1473,
		Beyond-UI-UISemiCircleScrollListPair-Awake0 = 1474,
		Beyond-UI-UISemiCircleScrollListPair-_OnCellShow0 = 1475,
		Beyond-UI-UISemiCircleScrollListPair-_OnClosestCellChanged0 = 1476,
		Beyond-UI-UISemiCircleScrollListPair-_OnDrag0 = 1477,
		Beyond-UI-UISemiCircleScrollListPair-_OnEndDrag0 = 1478,
		Beyond-UI-UISemiCircleScrollListPair-RefreshLayout0 = 1479,
		Beyond-UI-UISequenceImage-OnAwake0 = 1480,
		Beyond-UI-UISequenceImage-OnEnable0 = 1481,
		Beyond-UI-UISequenceImage-Play0 = 1482,
		Beyond-UI-UISequenceImage-SetSprite0 = 1484,
		Beyond-UI-UISequenceImage-OnDisable0 = 1485,
		Beyond-UI-UISequenceImage-Stop0 = 1486,
		Beyond-UI-UISequenceImage-Tick0 = 1488,
		Beyond-UI-UISimpleActiveAnimationHelper-Start0 = 1489,
		Beyond-UI-UISimpleActiveAnimationHelper-Skip0 = 1490,
		Beyond-UI-UISimpleActiveAnimationHelper-OnEnable0 = 1491,
		Beyond-UI-UISimpleActiveAnimationHelper-Tick0 = 1492,
		Beyond-UI-UISimpleStateController-SetState0 = 1493,
		Beyond-UI-UISimpleStateController-StateInfo-ToString0 = 1494,
		Beyond-UI-UISizeFollower-LateTick0 = 1495,
		Beyond-UI-UISlider-_TryPostSlideAudioEvent0 = 1496,
		Beyond-UI-UISlider-ClampValue0 = 1497,
		Beyond-UI-UISlider-CustomProcessNormalizedValue0 = 1498,
		Beyond-UI-UISlider-OnValueChanged0 = 1499,
		Beyond-UI-UISlider-OnClickSliderBar0 = 1500,
		Beyond-UI-UISlider-OnClickSliderHandle0 = 1501,
		Beyond-UI-UISlider-_NotifyIsHover0 = 1502,
		Beyond-UI-UISlider-OnBeginDrag0 = 1503,
		Beyond-UI-UISlider-OnEndDrag0 = 1504,
		Beyond-UI-UISlider-Awake0 = 1505,
		Beyond-UI-UISlider-_InitBinding0 = 1506,
		Beyond-UI-UISlider-_InitStickScroll0 = 1509,
		Beyond-UI-UISlider-_StickScrollHoriValue0 = 1510,
		Beyond-UI-UISlider-_ApplyStickScroll0 = 1511,
		Beyond-UI-UISlider-_AddValue0 = 1512,
		Beyond-UI-UISlider-_ReduceValue0 = 1513,
		Beyond-UI-UISlider-OnEnable0 = 1514,
		Beyond-UI-UISlider-OnDisable0 = 1515,
		Beyond-UI-UISlider-ClearComponent0 = 1516,
		Beyond-UI-UISlider-OnDestroy0 = 1517,
		Beyond-UI-UISlider-get_bindingViewState0 = 1518,
		Beyond-UI-UISlider-GetBindingViewActionId0 = 1519,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyDown0 = 1520,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyUp0 = 1521,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.get_interactable0 = 1522,
		Beyond-UI-UISoftMask-GetTextSoftMaskMaterial0 = 1523,
		Beyond-UI-UISoftMask-GetUIVFXSoftMaskMaterial0 = 1524,
		Beyond-UI-UISoftMask-GetCornerCanvas0 = 1525,
		Beyond-UI-UISoftMask-GetFourCornnerArrayWorld0 = 1526,
		Beyond-UI-UISoftMask-OnEnable0 = 1527,
		Beyond-UI-UISoftMask-_OnEnableRuntimeAtlas0 = 1528,
		Beyond-UI-UISoftMask-_UpdateParam0 = 1529,
		Beyond-UI-UISoftMask-_UpdateChildren0 = 1530,
		Beyond-UI-UISoftMaskable-MarkGraphicVerticesDirty0 = 1531,
		Beyond-UI-UISoftMaskable-get_graphic0 = 1532,
		Beyond-UI-UISoftMaskable-MarkGraphicMaterialDirty0 = 1533,
		Beyond-UI-UISoftMask-OnDisable0 = 1534,
		Beyond-UI-UISoftMask-_Clear0 = 1535,
		Beyond-UI-UISoftMask-_DestroyMaterial0 = 1536,
		Beyond-UI-UISoftMask-TailLateTick0 = 1537,
		Beyond-UI-UISoftMaskable-get_softMask0 = 1538,
		Beyond-UI-UISoftMaskable-get_uiText0 = 1539,
		Beyond-UI-UISoftMaskable-GetModifiedMaterial0 = 1540,
		Beyond-UI-UISoftMaskable-OnEnable0 = 1541,
		Beyond-UI-UISoftMaskable-OnDisable0 = 1542,
		Beyond-UI-UISoftMaskable-LateTick0 = 1543,
		Beyond-UI-UISoftMaskable-ModifyMesh0 = 1544,
		Beyond-UI-UISoftMaskable-_Equal0 = 1545,
		Beyond-UI-UISoftMaskable-_ComputeLineCross0 = 1546,
		Beyond-UI-UISoftMaskable-_ComputePointAtTriangleUV0 = 1547,
		Beyond-UI-UISoftMaskable-_ClipTriangleByClampSoftMaskUV0 = 1548,
		Beyond-UI-UISoftMaskable-_SetUIVertexUV0 = 1549,
		Beyond-UI-UISoftMaskable-_ClipRect0 = 1550,
		Beyond-UI-UISoftMaskable-ModifyMesh1 = 1551,
		Beyond-UI-UISortingOrder-OnEnable0 = 1552,
		Beyond-UI-UISortingOrder-_GetRenderer0 = 1553,
		Beyond-UI-UISortingOrder-_GetChildrenRenderers0 = 1554,
		Beyond-UI-UISortingOrder-_GetCanvas0 = 1555,
		Beyond-UI-UISortingOrder-SetOrder0 = 1556,
		Beyond-UI-UISortingOrder-Awake0 = 1557,
		Beyond-UI-UISortingOrder-OnDestroy0 = 1558,
		Beyond-UI-UIStepScrollList-Init0 = 1559,
		Beyond-UI-UIStepScrollList-_OnScrollEnd0 = 1560,
		Beyond-UI-UIStepScrollList-_TryAutoScroll0 = 1561,
		Beyond-UI-UIStepScrollList-_GetClampedIndex0 = 1562,
		Beyond-UI-UIStepScrollList-_OnScrollStart0 = 1563,
		Beyond-UI-UIStepScrollList-InitConfig0 = 1564,
		Beyond-UI-UIStepScrollList-OnScroll0 = 1565,
		Beyond-UI-UIStepScrollList-OnBeginDrag0 = 1566,
		Beyond-UI-UIStepScrollList-OnEndDrag0 = 1567,
		Beyond-UI-UIStepScrollList-SetTop0 = 1569,
		Beyond-UI-UIStepScrollList-UpdateShowingCells0 = 1570,
		Beyond-UI-UIStepScrollList-ClearComponent0 = 1571,
		Beyond-UI-UIStepScrollList-OnDisable0 = 1572,
		Beyond-UI-UIStyleByState-Awake0 = 1573,
		Beyond-UI-UIStyleByState-UpdateStyle0 = 1574,
		Beyond-UI-UIStyleByState-_IsValidStyle0 = 1575,
		Beyond-UI-UIStyleByState-OnDestroy0 = 1576,
		Beyond-UI-UISubtitle-Start0 = 1577,
		Beyond-UI-UISubtitle-_SetAsDefault0 = 1578,
		Beyond-UI-UISubtitle-SetSubtitle0 = 1579,
		Beyond-UI-UISubtitle-UpdateAlpha0 = 1580,
		Beyond-UI-UITextPair-get_text0 = 1581,
		Beyond-UI-UITextPair-set_text0 = 1582,
		Beyond-UI-UITextPair-set_color0 = 1583,
		Beyond-UI-UITextPair-get_first0 = 1584,
		Beyond-UI-UITextPair-SetAndResolveTextStyle0 = 1585,
		Beyond-UI-UITextPair-SetPhoneticText0 = 1586,
		Beyond-UI-UIToggle-Awake0 = 1587,
		Beyond-UI-UIToggle-_InitToggleBinding0 = 1588,
		Beyond-UI-UIToggle-TryInternalToggle0 = 1589,
		Beyond-UI-UIToggle-_OnToggleFail0 = 1590,
		Beyond-UI-UIToggle-_TryRefreshToggleBindingText0 = 1592,
		Beyond-UI-UIToggle-_TryRefreshBindingText0 = 1594,
		Beyond-UI-UIToggle-_InitActionOnSetNaviTarget0 = 1595,
		Beyond-UI-UIToggle-_TryRefreshHoverConfirmBindingText0 = 1597,
		Beyond-UI-UIToggle-OnEnable0 = 1599,
		Beyond-UI-UIToggle-_UpdateObjects0 = 1600,
		Beyond-UI-UIToggle-_PlayAnimation0 = 1601,
		Beyond-UI-UIToggle-_UpdateBindingEnable0 = 1602,
		Beyond-UI-UIToggle-OnDisable0 = 1603,
		Beyond-UI-UIToggle-OnDestroy0 = 1604,
		Beyond-UI-UIToggle-ClearComponent0 = 1605,
		Beyond-UI-UIToggle-Start0 = 1606,
		Beyond-UI-UIToggle-InternalToggle0 = 1607,
		Beyond-UI-UIToggle-PlayAudio0 = 1608,
		Beyond-UI-UIToggle-OnValueChange0 = 1609,
		Beyond-UI-UIToggle-_NotifyIsHover0 = 1610,
		Beyond-UI-UIToggle-OnInteractableChanged0 = 1611,
		Beyond-UI-UIToggle-GetMouseActionHints0 = 1612,
		Beyond-UI-UIToggle-OnPointerDown0 = 1613,
		Beyond-UI-UIToggle-OnPointerClick0 = 1615,
		Beyond-UI-UIToggle-OnSubmit0 = 1617,
		Beyond-UI-UIToggle-OnNaviTargetEnabledAgain0 = 1618,
		Beyond-UI-UIToggle-_OnSetAsNaviTarget0 = 1619,
		Beyond-UI-UIToggle-_ToggleNaviInputBinding0 = 1620,
		Beyond-UI-UIToggleGroup-Awake0 = 1621,
		Beyond-UI-UIToggleGroup-MoveToNext0 = 1622,
		Beyond-UI-UIToggleGroup-_MoveTo0 = 1623,
		Beyond-UI-UIToggleGroup-MoveToPrevious0 = 1625,
		Beyond-UI-UIToggleGroup-OnEnable0 = 1627,
		Beyond-UI-UIToggleGroup-OnDisable0 = 1630,
		Beyond-UI-UIToggleGroup-OnDestroy0 = 1631,
		Beyond-UI-UITouchPanel-OnBeginDrag0 = 1632,
		Beyond-UI-UITouchPanel-_IsSameTouchFromPress0 = 1633,
		Beyond-UI-UITouchPanel-OnEndDrag0 = 1634,
		Beyond-UI-UITouchPanel-DoEndDrag0 = 1635,
		Beyond-UI-UITouchPanel-OnDrag0 = 1636,
		Beyond-UI-UITouchPanel-OnPointerDown0 = 1638,
		Beyond-UI-UITouchPanel-_OnActionPress0 = 1639,
		Beyond-UI-UITouchPanel-OnPointerUp0 = 1640,
		Beyond-UI-UITouchPanel-_OnActionRelease0 = 1641,
		Beyond-UI-UITouchPanel-OnPointerClick0 = 1642,
		Beyond-UI-UITouchPanel-OnPointerEnter0 = 1643,
		Beyond-UI-UITouchPanel-OnPointerExit0 = 1645,
		Beyond-UI-UITouchPanel-ClearTouchInfo0 = 1646,
		Beyond-UI-UITouchPanel-OnScroll0 = 1647,
		Beyond-UI-UITouchPanel-SimulateClick0 = 1648,
		Beyond-UI-UITouchPanel-DeActiveTouch0 = 1649,
		Beyond-UI-UITouchPanel-OnAwake0 = 1650,
		Beyond-UI-UITouchPanel-InitBinding0 = 1651,
		Beyond-UI-UITouchPanel-_UpdateState0 = 1654,
		Beyond-UI-UITouchPanel-Tick0 = 1657,
		Beyond-UI-UITouchPanel-LateTick0 = 1660,
		Beyond-UI-UITouchPanel-OnEnable0 = 1661,
		Beyond-UI-UITouchPanel-OnDisable0 = 1662,
		Beyond-UI-UITouchPanel-OnDestroy0 = 1663,
		Beyond-UI-UITouchPanel-OnRelease0 = 1664,
		Beyond-UI-UITouchPanel-ClearComponent0 = 1665,
		Beyond-UI-UIVFXManager-get_graphic0 = 1666,
		Beyond-UI-UIVFXManager-get_softMaskable0 = 1667,
		Beyond-UI-UIVFXManager-OnEnable0 = 1668,
		Beyond-UI-UIVFXManager-_OnEnableRuntimeAtlas0 = 1669,
		Beyond-UI-UIVFXManager-_UpdateParam0 = 1670,
		Beyond-UI-UIVFXManager-LateTick0 = 1671,
		Beyond-UI-UIVFXManager-OnDisable0 = 1672,
		Beyond-UI-UIVFXManager-_Clear0 = 1673,
		Beyond-UI-UIVFXManager-_DestroyMaterial0 = 1674,
		Beyond-UI-UIVFXManager-GetModifiedMaterial0 = 1675,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateUpPos0 = 1676,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-ScrollListLayoutInfo-get_cellHeight0 = 1677,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateDownPos0 = 1678,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateMidPos0 = 1679,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateWorldLevelScrollList0 = 1680,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-_ScrollLayouts0 = 1681,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-OnDisable0 = 1688,
		Beyond-UI-VirtualMouseInitPos-get_panel0 = 1689,
		Beyond-UI-VirtualMouseInitPos-OnEnable0 = 1690,
		Beyond-UI-CSPopupPanel-Awake0 = 1691,
		Beyond-UI-CSPopupPanel-_OnConfirm0 = 1692,
		Beyond-UI-CSPopupPanel-_OnCancel0 = 1693,
		Beyond-UI-CSPopupPanel-OnDestroy0 = 1694,
		Beyond-UI-CSPopupPanel-Show0 = 1695,
		Beyond-UI-CSPopupPanel-ClearAllPanels0 = 1696,
		Beyond-UI-MobileMotionManager-OnInit0 = 1697,
		Beyond-UI-MobileMotionManager-_CheckMotionLevelAndPostIfChange0 = 1698,
		Beyond-UI-MobileMotionManager-OnRelease0 = 1699,
		Beyond-UI-MobileMotionManager-PostEventCommonShort0 = 1700,
		Beyond-UI-MobileMotionManager-PostEventCommonOperateSuccess0 = 1701,
		Beyond-UI-MobileMotionManager-PostEventCommonOperateFailure0 = 1702,
		Beyond-UI-DynamicFontAssetLoader-AddNotFoundUnicode0 = 1703,
		Beyond-UI-DynamicFontAssetLoader-TryGetFontAsset0 = 1704,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-GetFontAsset0 = 1706,
		Beyond-UI-DynamicFontAssetLoader-TryRemoveRefText0 = 1707,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-RemoveRefText0 = 1708,
		Beyond-UI-DynamicFontAssetLoader-Dispose0 = 1709,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-Dispose0 = 1710,
		Beyond-UI-TweenUtils-TickAsCountDown0 = 1711,
		Beyond-UI-TweenUtils-FLerpByTime-Start0 = 1712,
		Beyond-UI-TweenUtils-FLerpByTime-GetValue0 = 1713,
		Beyond-UI-UIAnimationLayerMixPlayer-LockToClip0 = 1714,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateGraph0 = 1715,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateMixer0 = 1716,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateOutput0 = 1717,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateSourceFromAsset0 = 1718,
		Beyond-UI-UIAnimationMixPlayer-LockToClip0 = 1719,
		Beyond-UI-UIAnimationMixPlayer-CreateGraph0 = 1720,
		Beyond-UI-UIAnimationMixPlayer-CreateMixer0 = 1721,
		Beyond-UI-UIAnimationMixPlayer-CreateOutput0 = 1722,
		Beyond-UI-UIAnimationMixPlayer-CreateSourceFromAsset0 = 1723,
		Beyond-UI-UILoadImageSprite-set_spritePath0 = 1724,
		Beyond-UI-UILoadImageSprite-_LoadSprite0 = 1725,
		Beyond-UI-UILoadImageSprite-OnDestroy0 = 1728,
		Beyond-UI-UILoadImageSpriteByName-set_spriteName0 = 1729,
		Beyond-UI-UISwitchTween-BeforeShowEffect0 = 1730,
		Beyond-UI-UISwitchTween-BeforeHideEffect0 = 1731,
		Beyond-UI-UISwitchTween-AfterShowEffect0 = 1732,
		Beyond-UI-UISwitchTween-AfterHideEffect0 = 1733,
		Beyond-UI-UISwitchTween-ResetToState0 = 1734,
		Beyond-UI-UISwitchTween-Show0 = 1735,
		Beyond-UI-UISwitchTween-_ClearTweenInternal0 = 1736,
		Beyond-UI-UISwitchTween-TweenContext-OnReset0 = 1737,
		Beyond-UI-UISwitchTween-TweenContext-OnTweenStop0 = 1738,
		Beyond-UI-UISwitchTween-ClearTween0 = 1739,
		Beyond-UI-UISwitchTween-Hide0 = 1742,
		Beyond-UI-UISwitchTween-WaitForTweening0 = 1745,
		Beyond-UI-UISwitchTween-SetOptions0 = 1752,
		Beyond-UI-UISwitchTween-Reset0 = 1753,
		Beyond-UI-UISwitchTween-Clear0 = 1754,
		Beyond-UI-UISwitchTween-GetContext0 = 1755,
		Beyond-UI-UISwitchTween-TweenContext-IsInterapted0 = 1756,
		Beyond-UI-UISwitchTween-TweenWrapper-IsActive0 = 1757,
		Beyond-UI-UISwitchTween-TweenWrapper-IsPlaying0 = 1758,
		Beyond-UI-UISwitchTween-TweenWrapper-KillIfNecessary0 = 1759,
		Beyond-UI-UISwitchTween-TweenWrapper-OnComplete0 = 1760,
		Beyond-UI-UISwitchTween-TweenWrapper-SetAutoKill0 = 1761,
		Beyond-UI-FadeSwitchTween-set_activeAlpha0 = 1762,
		Beyond-UI-FadeSwitchTween-GenerateTweenOfHide0 = 1763,
		Beyond-UI-FadeSwitchTween-Durations-GetHideDuration0 = 1766,
		Beyond-UI-FadeSwitchTween-GenerateTweenOfShow0 = 1767,
		Beyond-UI-FadeSwitchTween-Durations-GetShowDuration0 = 1768,
		Beyond-UI-FadeSwitchTween-BeforeShowEffect0 = 1769,
		Beyond-UI-FadeSwitchTween-SetObjectActive0 = 1770,
		Beyond-UI-FadeSwitchTween-AfterHideEffect0 = 1773,
		Beyond-UI-FadeSwitchTween-ResetToState0 = 1774,
		Beyond-UI-FadeSwitchTween-Release0 = 1775,
		Beyond-UI-FadeSwitchTween-Builder-Build0 = 1776,
		Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfHide0 = 1780,
		Beyond-UI-FadeTranslationSwitchTween-_GetTargetAlpha0 = 1781,
		Beyond-UI-FadeTranslationSwitchTween-_GetTargetPos0 = 1782,
		Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfShow0 = 1783,
		Beyond-UI-FadeTranslationSwitchTween-BeforeShowEffect0 = 1784,
		Beyond-UI-FadeTranslationSwitchTween-AfterHideEffect0 = 1785,
		Beyond-UI-FadeTranslationSwitchTween-ResetToState0 = 1786,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-IsPlaying0 = 1787,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-KillIfNecessary0 = 1788,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-OnComplete0 = 1789,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-SetAutoKill0 = 1790,
		Beyond-UI-UIAtlasManager-OnInit0 = 1791,
		Beyond-UI-UIAtlasManager-_CreateTickFunction0 = 1792,
		Beyond-UI-UIAtlasManager-LateTick0 = 1793,
		Beyond-UI-UIAtlasManager-_ProcessRemoveQueue0 = 1794,
		Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRect0 = 1795,
		Beyond-UI-UIAtlasManager-_ProcessInsertQueue0 = 1798,
		Beyond-UI-UIAtlasManager-_IsRuntimeAtlasCompatible0 = 1799,
		Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRect0 = 1800,
		Beyond-UI-UIAtlasManager-UIAtlasPage-CopyIntoAtlas0 = 1801,
		Beyond-UI-UIAtlasManager-OnUnInit0 = 1802,
		Beyond-UI-UIAtlasManager-_ClearTickFunction0 = 1803,
		Beyond-UI-UIAtlasManager-Release0 = 1804,
		Beyond-UI-UIAtlasManager-GetAtlasCount0 = 1805,
		Beyond-UI-UIAtlasManager-UIAtlasHandle-IsValid0 = 1806,
		Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRects0 = 1807,
		Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRects0 = 1808,
		Beyond-UI-UIRedDotAnimation-Init0 = 1809,
		Beyond-UI-UIRedDotAnimation-_UpdateRedDotAnimation0 = 1810,
		Beyond-UI-UIRedDotAnimation-UnInit0 = 1811,
		Beyond-UI-UIRedDotAnimation-AddRedDotImage0 = 1812,
		Beyond-UI-UIRedDotAnimation-RemoveRedDotImage0 = 1813,
		Beyond-UI-UIRedDotAnimationNode-Awake0 = 1814,
		Beyond-UI-UIRedDotAnimationNode-OnEnable0 = 1815,
		Beyond-UI-UIRedDotAnimationNode-OnDisable0 = 1816,
		Beyond-UI-WebApplication-Start0 = 1817,
		Beyond-UI-UIState-StateDescription-EqualsAnimation0 = 1820,
		Beyond-UI-UIState-StateDescription-EqualsAnimator0 = 1821,
		Beyond-UI-UIState-StateDescription-EqualsButton0 = 1822,
		Beyond-UI-UIState-StateDescription-EqualsCanvasGroup0 = 1823,
		Beyond-UI-UIState-StateDescription-EqualsComponent0 = 1824,
		Beyond-UI-UIState-StateDescription-get_ReadableDescription0 = 1825,
		Beyond-UI-UIState-UIStateControllerUtils-GetName0 = 1826,
		Beyond-UI-UIState-StateDescription-ToString0 = 1827,
		Beyond-UI-UIState-StateDescription-op_Equality0 = 1828,
		Beyond-UI-UIState-StateDescription-Equals0 = 1829,
		Beyond-UI-UIState-StateDescription-_EqualsByTargetType0 = 1830,
		Beyond-UI-UIState-StateDescription-EqualsGameObject0 = 1831,
		Beyond-UI-UIState-StateDescription-EqualsState0 = 1832,
		Beyond-UI-UIState-StateDescription-EqualsImage0 = 1833,
		Beyond-UI-UIState-StateDescription-EqualsText0 = 1834,
		Beyond-UI-UIState-StateDescription-EqualsRectTransform0 = 1835,
		Beyond-UI-UIState-StateDescription-EqualsLayoutElement0 = 1836,
		Beyond-UI-UIState-StateDescription-EqualsGraphic0 = 1837,
		Beyond-UI-UIState-StateDescription-EqualsLayoutGroup0 = 1838,
		Beyond-UI-UIState-StateDescription-EqualsScrollList0 = 1839,
		Beyond-UI-UIState-StateDescription-EqualsGridLayoutGroup0 = 1840,
		Beyond-UI-UIState-StateDescription-op_Inequality0 = 1841,
		Beyond-UI-UIState-StateDescription-Equals1 = 1842,
		Beyond-UI-UIState-StateDescription-GetHashCode0 = 1843,
		Beyond-UI-UIState-StateDescription-_GetTargetHashCode0 = 1844,
		Beyond-UI-UIState-StateDescription-_OnGridLayoutGroupChanged0 = 1845,
		Beyond-UI-UIState-StateDescription-_OnImageChanged0 = 1846,
		Beyond-UI-UIState-StateDescription-_OnLayoutElementChanged0 = 1847,
		Beyond-UI-UIState-StateDescription-_OnLayoutGroupChanged0 = 1848,
		Beyond-UI-UIState-StateDescription-_OnRectTransformChanged0 = 1849,
		Beyond-UI-UIState-StateDescription-_OnScrollListChanged0 = 1850,
		Beyond-UI-UIState-StateDescription-_OnTextChanged0 = 1851,
		Beyond-UI-UIState-StateReference-HandleScheduledStates0 = 1852,
		Beyond-UI-UIState-UIStateController-Run0 = 1853,
		Beyond-UI-UIState-UIStateController-Stop0 = 1854,
		Beyond-UI-UIState-UIStateController-Tick0 = 1855,
		Beyond-UI-UIState-UIStateController-_HandleStateAnimations0 = 1856,
		Beyond-UI-GPUI-GPUPrefabData-CreateFontNode0 = 1860,
		Beyond-UI-GPUI-GPUPrefabDataLite-CreateFontNode0 = 1861,
		Beyond-UI-GPUI-GPUIHandle-Equals0 = 1862,
		Beyond-UI-GPUI-GPUIHandle-Equals1 = 1863,
		Beyond-UI-GPUI-GPUIHandle-GetHashCode0 = 1864,
		Beyond-UI-GPUI-GPUIHandle-op_Equality0 = 1865,
		Beyond-UI-GPUI-GPUIHandle-op_Inequality0 = 1866,
		Beyond-UI-GPUI-GPUISystem-get_fontAsset0 = 1867,
		Beyond-UI-GPUI-GPUISystem-GetFontAsset0 = 1868,
		Beyond-UI-GPUI-GPUISystem-set_fontAsset0 = 1869,
		Beyond-UI-GPUI-GPUISystem-CreateInstance0 = 1870,
		Beyond-UI-GPUI-GPUISystem-_CreateInstance0 = 1871,
		Beyond-UI-GPUI-GPUISystem-_GetOneHandle0 = 1872,
		Beyond-UI-GPUI-RuntimeInstance-Create0 = 1873,
		Beyond-UI-GPUI-InstanceBufferManager-Add0 = 1874,
		Beyond-UI-GPUI-GPUISystem-SetRootPosition0 = 1875,
		Beyond-UI-GPUI-GPUISystem-_IsHandleInvalid0 = 1876,
		Beyond-UI-GPUI-RuntimeInstance-SetPosition0 = 1877,
		Beyond-UI-GPUI-InstanceBufferManager-MarkNeedUpdate0 = 1878,
		Beyond-UI-GPUI-GPUISystem-DestroyInstance0 = 1879,
		Beyond-UI-GPUI-GPUISystem-_DestroyInstance0 = 1880,
		Beyond-UI-GPUI-InstanceBufferManager-Remove0 = 1881,
		Beyond-UI-GPUI-RuntimeInstance-Recycle0 = 1882,
		Beyond-UI-GPUI-GPUISystem-_RecycleOneHandle0 = 1883,
		Beyond-UI-GPUI-GPUISystem-IsInstanceValid0 = 1884,
		Beyond-UI-GPUI-GPUISystem-SetRootScale0 = 1885,
		Beyond-UI-GPUI-RuntimeInstance-SetRootScale0 = 1886,
		Beyond-UI-GPUI-GPUISystem-StartAnimation0 = 1887,
		Beyond-UI-GPUI-RuntimeInstance-StartAnimation0 = 1888,
		Beyond-UI-GPUI-GPUISystem-StartAnimation1 = 1889,
		Beyond-UI-GPUI-GPUISystem-SetVisibility0 = 1890,
		Beyond-UI-GPUI-GPUISystem-SetColor0 = 1891,
		Beyond-UI-GPUI-RuntimeInstance-SetColor0 = 1892,
		Beyond-UI-GPUI-GPUIUtils-ColorToRGBAUint320 = 1893,
		Beyond-UI-GPUI-GPUISystem-SetText0 = 1894,
		Beyond-UI-GPUI-RuntimeInstance-SetText0 = 1895,
		Beyond-UI-GPUI-GPUISystem-OnDestroy0 = 1896,
		Beyond-UI-GPUI-GPUISystem-_DoOnDestroy0 = 1897,
		Beyond-UI-GPUI-InstanceBufferManager-Dispose0 = 1898,
		Beyond-UI-GPUI-GPUISystem-_CleanMaterials0 = 1899,
		Beyond-UI-GPUI-GPUISystem-OnEnable0 = 1900,
		Beyond-UI-GPUI-GPUISystem-_PreWillRenderCanvases0 = 1901,
		Beyond-UI-GPUI-GPUISystem-_DoLateUpdate0 = 1902,
		Beyond-UI-GPUI-GPUISystem-_DestroyAnimatedInstance0 = 1903,
		Beyond-UI-GPUI-InstanceBufferManager-DoUpdate0 = 1904,
		Beyond-UI-GPUI-InstanceBufferManager-_FillInstanceQueue0 = 1905,
		Beyond-UI-GPUI-InstanceBufferManager-_AllocBuffer0 = 1906,
		Beyond-UI-GPUI-RuntimeInstance-DoUpdate0 = 1907,
		Beyond-UI-GPUI-GPUISystem-_RenderNodes0 = 1908,
		Beyond-UI-GPUI-InstanceBufferManager-get_gpuGroups0 = 1909,
		Beyond-UI-GPUI-GPUISystem-_UpdateWorldMat0 = 1910,
		Beyond-UI-GPUI-GPUISystem-_Init0 = 1911,
		Beyond-UI-GPUI-GPUISystem-_InitMaterials0 = 1912,
		Beyond-UI-GPUI-GPUISystem-_PreloadTextInGroupData0 = 1913,
		Beyond-UI-GPUI-InstanceBufferManager-BindInstanceList0 = 1914,
		Beyond-UI-GPUI-GPUISystem-_LoadGroupData0 = 1915,
		Beyond-UI-GPUI-GPUISystem-_LoadPrefabData0 = 1916,
		Beyond-UI-GPUI-GPUISystem-_LoadPrefabNodeBuffer0 = 1917,
		Beyond-UI-GPUI-GPUISystem-_RefreshMaterials0 = 1918,
		Beyond-UI-GPUI-GPUISystem-OnDisable0 = 1919,
		Beyond-UI-GPUI-GPUISystem-OnPopulateMesh0 = 1920,
		Beyond-UI-GPUI-GPUISystem-UpdateMaterial0 = 1921,
		Beyond-UI-GPUI-GPUIUtils-CreateQuadMesh0 = 1922,
		Beyond-UI-GPUI-RuntimeInstance-SetVisibility0 = 1923,
		Beyond-UI-GPUI-CodePoint-ConvertToUTF320 = 1924
	}
}
