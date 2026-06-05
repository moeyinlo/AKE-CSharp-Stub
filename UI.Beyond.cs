/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
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
using MagicaCloth;
using TMPro;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.InputSystem.UI;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.UI;
using XLua;
using ZSimpleJSON;

// Image 17: UI.Beyond.dll - Assembly: UI.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 50096-50456

public class UIMinSizeAdjust : MonoBehaviour // TypeDefIndex: 50097
{
	// Fields
	private RectTransform _panelRect; // 0x18

	// Constructors
	public UIMinSizeAdjust() {} // 0x000000018646DB20-0x000000018646DB28

	// Methods
	private void Start() {} // 0x000000018BBD7620-0x000000018BBD7628
	private void _SetTextureScaleByWidth() {} // 0x000000018BBD7628-0x000000018BBD7830
}

internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 50452
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_24 FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE; // 0x00 // Static value (base64): AAAAAAEAAAACAAAAAAAAAAIAAAADAAAA - Metadata: 0x02061F54

	// Nested types
	private struct __StaticArrayInitTypeSize_24 // TypeDefIndex: 50451
	{
	}

	// Constructors
	public _PrivateImplementationDetails_() {} // Dummy constructor
}

namespace Beyond.Gameplay.UI
{
	public class UIScrollCellCircleEffect : TickableUIMono // TypeDefIndex: 50107
	{
		// Fields
		private Transform _target; // 0x68
		private float _radius; // 0x70
		private Transform _effectNode; // 0x78
		private bool _faceToUICamera; // 0x80
		private bool _alwaysFaceToCamera; // 0x81
		private Vector3 m_lastPosition; // 0x84
		private LuaPanel m_panel; // 0x90
		private Transform _lookAtCamera_k__BackingField; // 0x98
		private bool m_left; // 0xA0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6A10-0x0000000185FB6A20 
		public LuaPanel panel { get => default; } // 0x000000018BBD853C-0x000000018BBD85FC 
		public Transform lookAtCamera { get; private set; } // 0x0000000181E336C0-0x0000000181E336D0 0x00000001873350D4-0x00000001873350E8
	
		// Constructors
		public UIScrollCellCircleEffect() {} // 0x000000018BBD852C-0x000000018BBD853C
	
		// Methods
		private void _InitState() {} // 0x000000018BBD8090-0x000000018BBD8154
		private void _UpdatePos() {} // 0x000000018BBD836C-0x000000018BBD852C
		private void _UpdateLookAtCamera() {} // 0x000000018BBD8154-0x000000018BBD836C
		public void SetLookAtCamera(Transform faceCamera, bool update = true /* Metadata: 0x02061A3A */) {} // 0x000000018BBD7EF0-0x000000018BBD7F8C
		protected override void OnEnable() {} // 0x000000018BBD7E98-0x000000018BBD7EF0
		private void Start() {} // 0x000000018BBD7F8C-0x000000018BBD8034
		public override void Tick(float deltaTime) {} // 0x000000018BBD8034-0x000000018BBD8090
		public void ForceUpdate() {} // 0x000000018BBD7DEC-0x000000018BBD7E3C
		public override void LateTick(float deltaTime) {} // 0x000000018BBD7E3C-0x000000018BBD7E98
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class UIScrollCellSlantEffect : TickableUIMono // TypeDefIndex: 50108
	{
		// Fields
		private float _topY; // 0x68
		private float _bottomY; // 0x6C
		private float _leftX; // 0x70
		private float _maxWidth; // 0x74
		private AnimationCurve _curve; // 0x78
		private Transform[] _cells; // 0x80
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public UIScrollCellSlantEffect() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		public override void Tick(float deltaTime) {} // 0x00000001852273C0-0x0000000185227660
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_UI_Beyond // TypeDefIndex: 50100
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		private static void InitializeAtRuntime() {} // 0x0000000185ECB300-0x0000000185ECB330
		private static void Initialize() {} // 0x0000000185ECB330-0x0000000185ECB3E0
	}
}

namespace Beyond.Scripts.UI.Tools
{
	public class UIGridLayoutElement : MonoBehaviour, ILayoutElement // TypeDefIndex: 50106
	{
		// Fields
		private GridLayoutGroup m_gridLayoutGroup; // 0x18
	
		// Properties
		public float minWidth { get => default; } // 0x000000018BBD7410-0x000000018BBD74C0 
		public float preferredWidth { get => default; } // 0x000000018BBD7570-0x000000018BBD7620 
		public float flexibleWidth { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public float minHeight { get => default; } // 0x000000018BBD7360-0x000000018BBD7410 
		public float preferredHeight { get => default; } // 0x000000018BBD74C0-0x000000018BBD7570 
		public float flexibleHeight { get => default; } // 0x0000000185FD5E00-0x0000000185FD5E10 
		public int layoutPriority { get => default; } // 0x0000000181B87DE0-0x0000000181B87DF0 
	
		// Constructors
		public UIGridLayoutElement() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void CalculateLayoutInputHorizontal() {} // 0x000000018BBD70C4-0x000000018BBD7104
		public void CalculateLayoutInputVertical() {} // 0x000000018BBD7104-0x000000018BBD7144
		private float _GetPreferredSize(bool widthOrHeight) => default; // 0x000000018BBD7144-0x000000018BBD7360
	}
}

namespace Beyond.SourceGenerator
{
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 50101
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 50102
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 50103
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal static class AnimatorBlackboardUtility // TypeDefIndex: 50104
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 50105
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Beyond.UI
{
	public class UIText : TextMeshProUGUI, IPointerClickHandler, IUIClearable, ISerializationCallbackReceiver, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 50125
	{
		// Fields
		public RichTextStyleSeq richTextStyleSeq; // 0xBC0
		private bool m_textHasHyperlink; // 0xBC4
		private static readonly Regex RICH_TEXT_INNERMOST_REGEX; // 0x00
		private const int RICH_TEXT_RESOLVE_MAX_ITERATIONS = 128; // Metadata: 0x02061A3B
		private static readonly Regex HYPERLINK_TEXT_REGEX; // 0x08
		private static readonly Regex PHONETIC_REGEX; // 0x10
		private bool _loadByCode; // 0xBC5
		private string _textId; // 0xBC8
		private bool _devOnly; // 0xBD0
		private int _externalStaticWidth; // 0xBD4
		private int _externalStaticHeight; // 0xBD8
		private bool m_firstSetByCode; // 0xBDC
		private static readonly HashSet<EnvLang> s_forceLeftAlignLanguage; // 0x18
		private List<RichTextInfo> m_richTextInfos; // 0xBE0
		private TickFunction m_updateFunction; // 0xBE8
		private RichTextAnalyzer.ProcessRichTextEntryFunc m_processRichTextEntryFunc; // 0xBF0
		public UnityEvent<string> onClickLink; // 0xBF8
		public UnityEvent<string, bool> onHoverLinkChange; // 0xC00
		private bool m_isPointerInside; // 0xC08
		private string m_curHoverLinkId; // 0xC10
		private List<string> m_linkList; // 0xC18
		private bool m_linkShrunk; // 0xC20
		private string _hyperlinkUITextGroupId; // 0xC28
		private int _hyperlinkUITextOrder; // 0xC30
		private HyperlinkUITextWrap m_hyperlinkUITextWrap; // 0xC38
		private LuaPanel m_panel; // 0xC40
		public int sourceCNFontId; // 0xC48
		private TMP_FontAsset m_i18nFontAsset; // 0xC50
		private static StringBuilder s_stringBuilder; // 0x20
		private readonly Queue<GameObject> m_inlineImagePool; // 0xC58
		private readonly Dictionary<int, ImageGOInfo> m_indexToImageGo; // 0xC60
		private const string INLINE_IMAGE_FOLDER_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/"; // Metadata: 0x02061A3D
		private const string KEY_HINT_ICON_COMMON_FOLDER = "Assets/Beyond/InitialAssets/UI/Sprites/"; // Metadata: 0x02061A6E
		private readonly Dictionary<string, FAssetProxyHandle> m_imageCache; // 0xC68
		private readonly Dictionary<int, bool> m_delayedActiveChangeImageGOIndexes; // 0xC70
	
		// Properties
		public string textId { get => default; } // 0x00000001850DF000-0x00000001850DF130 
		public override string text { get => default; set {} } // 0x0000000183FCA3E0-0x0000000183FCA4D0 0x000000018BBD8AB4-0x000000018BBD8C98
		private RichTextAnalyzer.ProcessRichTextEntryFunc processRichTextEntryFunc { get => default; } // 0x000000018BBDA188-0x000000018BBDA190 
		public LuaPanel panel { get => default; } // 0x0000000183FB3D20-0x0000000183FB3D90 
		public override TMP_FontAsset m_fontAsset { get => default; set {} } // 0x00000001872076D8-0x00000001872076F4 0x000000018BBD5948-0x000000018BBD59E0
		public override Material fontSharedMaterial { get => default; set {} } // 0x0000000185492010-0x0000000185492020 0x000000018BBD4D64-0x000000018BBD4E00
	
		// Nested types
		private abstract class RichTextInfo // TypeDefIndex: 50109
		{
			// Fields
			public int index; // 0x10
	
			// Constructors
			protected RichTextInfo() {} // 0x000000018504E140-0x000000018504E240
		}
	
		private class InlineImageInfo : RichTextInfo // TypeDefIndex: 50110
		{
			// Fields
			public string path; // 0x18
			public float width; // 0x20
			public float height; // 0x24
			public UnityEngine.Color color; // 0x28
	
			// Constructors
			public InlineImageInfo() {} // 0x000000018494C550-0x000000018494C790
		}
	
		private enum RichTextTagType // TypeDefIndex: 50111
		{
			Image = 1,
			Width = 2,
			Height = 3,
			Scale = 4,
			Color = 5
		}
	
		public enum RichTextStyleSeq // TypeDefIndex: 50112
		{
			NORMAL = 0,
			DARK_BACKGROUND = 1,
			LIGHT_BACKGROUND = 2
		}
	
		private static class RichTextAnalyzer // TypeDefIndex: 50118
		{
			// Fields
			private const char CUSTOM_RICH_TEXT_LEFT_BRACKET = '<'; // Metadata: 0x02061A9E
			private const char CUSTOM_RICH_TEXT_RIGHT_BRACKET = '>'; // Metadata: 0x02061AA0
			private static readonly Dictionary<int, RichTextTag> s_tagToTypeDic; // 0x00
			private static readonly Dictionary<int, RichTextTag> s_tagAttributeToTypeDic; // 0x08
			public const string FONT_SHADOW_OPENING_TAG = "<shadow>"; // Metadata: 0x02061AA2
			public const string FONT_SHADOW_CLOSING_TAG = "</shadow>"; // Metadata: 0x02061AAB
			public const string FONT_MAT_OPENING_TAG = "<material=\"DefaultFont_3500_RichText_Shadow\">"; // Metadata: 0x02061AB5
			public const string FONT_MAT_CLOSING_TAG = "</material>"; // Metadata: 0x02061AE3
			private static readonly List<RichTextParam> s_subParams; // 0x10
	
			// Nested types
			public enum ParamValueType // TypeDefIndex: 50113
			{
				None = 0,
				String = 1,
				Int = 2,
				Float = 3,
				Color = 4
			}
	
			public struct RichTextTag // TypeDefIndex: 50114
			{
				// Fields
				public RichTextTagType richTextTagType; // 0x00
				public Beyond.UI.UIText.RichTextAnalyzer.ParamValueType paramValueType; // 0x04
			}
	
			public struct RichTextParam // TypeDefIndex: 50115
			{
				// Fields
				public RichTextTagType richTextTagType; // 0x00
				public AnyTypeStruct value; // 0x08
			}
	
			public struct AnyTypeStruct // TypeDefIndex: 50116
			{
				// Fields
				public int intValue; // 0x00
				public float floatValue; // 0x00
				public string stringValue; // 0x00
				public UnityEngine.Color colorValue; // 0x00
			}
	
			public delegate RichTextInfo ProcessRichTextEntryFunc(RichTextParam mainParam, List<RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder); // TypeDefIndex: 50117; 0x000000018504E240-0x000000018504FD40
	
			// Constructors
			static RichTextAnalyzer() {} // 0x00000001842430F0-0x0000000184243140
	
			// Methods
			public static string PreAnalyzeRichText(string text, bool needParseActionId) => default; // 0x000000018515D210-0x000000018515D230
			public static string AnalyzeRichText(string text, ProcessRichTextEntryFunc processFunc, out List<RichTextInfo> infos) {
				infos = default;
				return default;
			} // 0x0000000184FB7880-0x0000000184FB78D0
			private static bool _TryParseRichTextEntry(ReadOnlySpan<char> span, ref Utf16ValueStringBuilder stringBuilder, ProcessRichTextEntryFunc processFunc, out RichTextInfo richTextInfo) {
				richTextInfo = default;
				return default;
			} // 0x0000000185489AC0-0x0000000185489BF0
			private static bool _TryParseParam(ReadOnlySpan<char> span, out bool isMain, out RichTextParam param) {
				isMain = default;
				param = default;
				return default;
			} // 0x0000000184241760-0x00000001842417C0
			public static RichTextInfo ProcessRichTextEntryFallback(RichTextParam mainParam, List<RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder) => default; // 0x000000018557C040-0x000000018557C340
			public static int GetCharacterCountWithoutRichText(ReadOnlySpan<char> str) => default; // 0x0000000184399710-0x0000000184399870
			private static int _GetHashCode(ReadOnlySpan<char> str) => default; // 0x000000018BBD89A8-0x000000018BBD8AB4
		}
	
		private class HyperlinkUITextWrap // TypeDefIndex: 50119
		{
			// Fields
			public UIText uiText; // 0x10
			public string hyperlinkUITextGroupId; // 0x18
			public int order; // 0x20
			public bool isDisplayable; // 0x24
	
			// Constructors
			public HyperlinkUITextWrap() {} // 0x0000000184246F20-0x0000000184246FA0
	
			// Methods
			public void Clear() {} // 0x0000000184245D10-0x0000000184245E20
		}
	
		private class HyperlinkUITextGroup // TypeDefIndex: 50120
		{
			// Fields
			public HashSet<HyperlinkUITextWrap> wrapSet; // 0x10
			public string groupId; // 0x18
			public int displayableCount; // 0x20
	
			// Constructors
			public HyperlinkUITextGroup() {} // 0x000000018BBD9130-0x000000018BBD921C
	
			// Methods
			public void Add(HyperlinkUITextWrap wrap) {} // 0x0000000184245E20-0x0000000184245F50
			public void Remove(HyperlinkUITextWrap wrap) {} // 0x0000000184399870-0x0000000184399B70
			public void ChangeDisplayable(HyperlinkUITextWrap wrap, bool displayable) {} // 0x000000018510ADD0-0x000000018510B1A0
			private void _AddDisplayableCount() {} // 0x0000000184399E40-0x0000000184399F30
			private void _SubDisplayableCount() {} // 0x000000018BBDA6A8-0x000000018BBDAE20
			private void _NotifyDisplayableChanged() {} // 0x000000018BBD8C98-0x000000018BBD9130
		}
	
		private class HyperlinkUITextManager // TypeDefIndex: 50122
		{
			// Fields
			private Dictionary<string, HyperlinkUITextGroup> m_hyperlinkUITextGroupMap; // 0x10
			private ObjectPool<HyperlinkUITextGroup> m_hyperlinkUITextGroupPool; // 0x18
			private ObjectPool<HyperlinkUITextWrap> m_hyperlinkUITextWrapPool; // 0x20
			private static HyperlinkUITextManager s_instance; // 0x00
			private static readonly List<HyperlinkUITextWrap> SORT_WRAP_TEMP_LIST; // 0x08
	
			// Properties
			public static HyperlinkUITextManager instance { get => default; } // 0x000000018BBD966C-0x000000018BBD99E4 
	
			// Nested types
			[Serializable]
			private sealed class __c // TypeDefIndex: 50121
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Comparison<HyperlinkUITextWrap> __9__13_0; // 0x08
				public static Action<HyperlinkUITextGroup> __9__16_0; // 0x10
				public static Action<HyperlinkUITextWrap> __9__16_1; // 0x18
	
				// Constructors
				static __c() {} // 0x000000018BBD921C-0x000000018BBD935C
				public __c() {} // 0x000000018538CF70-0x000000018538CFA0
	
				// Methods
				internal int _GetGroupDisplayableUIText_b__13_0(HyperlinkUITextWrap a, HyperlinkUITextWrap b) => default; // 0x0000000184240700-0x00000001842407A0
				internal void _.ctor_b__16_0(HyperlinkUITextGroup group) {} // 0x000000018423FEE0-0x0000000184240700
				internal void _.ctor_b__16_1(HyperlinkUITextWrap wrap) {} // 0x000000018BBDAEDC-0x000000018BBDB27C
			}
	
			// Constructors
			public HyperlinkUITextManager() {} // 0x000000018BBD935C-0x000000018BBD94B8
			static HyperlinkUITextManager() {} // 0x0000000185C54C10-0x0000000185C54C90
	
			// Methods
			public void AddWrap(UIText uiText, string groupId, int order) {} // 0x000000018BBD9D24-0x000000018BBD9EE4
			public void RemoveWrap(UIText uiText) {} // 0x000000018BBD9EE4-0x000000018BBDA040
			public void ChangeWrapGroup(HyperlinkUITextWrap wrap, string newGroupId, int newOrder) {} // 0x000000018BBDA040-0x000000018BBDA120
			public void ChangeWrapOrder(HyperlinkUITextWrap wrap, int newOrder) {} // 0x000000018BBD9B84-0x000000018BBD9D24
			public void UpdateWrapDisplayable(UIText uiText) {} // 0x000000018BBD99E4-0x000000018BBD9B84
			public bool IsGroupDisplayable(string groupId) => default;
			public List<UIText> GetGroupDisplayableUIText(string groupId) => default; // 0x000000018BBD85FC-0x000000018BBD86A8
			private HyperlinkUITextGroup _GetGroup(string groupId, bool autoCreate = false /* Metadata: 0x02061AF4 */) => default;
			private bool _IsUITextDisplayable(UIText uiText) => default; // 0x0000000183EBED20-0x0000000183EBF380
		}
	
		private struct ImageGOInfo // TypeDefIndex: 50123
		{
			// Fields
			public GameObject go; // 0x00
			public RectTransform rectTransform; // 0x08
			public Image image; // 0x10
		}
	
		private sealed class __DelayedChangeActiveImageGo_d__110 : IEnumerator<object> // TypeDefIndex: 50124
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIText __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BBDA1A8-0x000000018BBDA23C 
			object IEnumerator.Current { get => default; } // 0x000000018BBDB3F4-0x000000018BBDB5A0 
	
			// Constructors
			public __DelayedChangeActiveImageGo_d__110() {} // Dummy constructor
			public __DelayedChangeActiveImageGo_d__110(int __1__state) {} // 0x000000018BBD86A8-0x000000018BBD8730
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BBDB27C-0x000000018BBDB33C
			private bool MoveNext() => default; // 0x0000000184241970-0x0000000184242D10
			void IEnumerator.Reset() {} // 0x0000000184246D30-0x0000000184246F20
		}
	
		// Constructors
		public UIText() {} // 0x000000018BBD545C-0x000000018BBD5948
		static UIText() {} // 0x0000000185C54CE0-0x0000000185C54DA0
	
		// Methods
		public void SetAndResolveTextStyle(string targetText) {} // 0x0000000185FB8550-0x0000000185FB8560
		public static string GetPhoneticText(PhoneticType phoneticType, string id) => default; // 0x000000018BBDB33C-0x000000018BBDB3F4
		public void SetPhoneticText(PhoneticType phoneticType, string id) {} // 0x0000000184245F50-0x0000000184246260
		private static string _ResolveTextStyle(string text, int richSeqIndex, out bool hasLink) {
			hasLink = default;
			return default;
		} // 0x000000018BBD94B8-0x000000018BBD966C
		public static void OnEnvLangChanged(EnvLang lang) {} // 0x000000018519DA10-0x000000018519DA90
		private void _CreateUpdateFunction() {} // 0x000000018BBD8730-0x000000018BBD89A8
		private void _ReleaseUpdateFunction() {} // 0x0000000184242DC0-0x00000001842430F0
		public override void ClearMesh() {} // 0x0000000184399B70-0x0000000184399E40
		public override void RefreshPopulateText() {} // 0x000000018BBDA2C8-0x000000018BBDA4A0
		protected override Material LoadMaterial(string materialName) => default; // 0x000000018BBDA4A0-0x000000018BBDA6A8
		protected override void OnDestroy() {} // 0x000000018BBDAE20-0x000000018BBDAEDC
		protected override void Awake() {} // 0x000000018BBDA23C-0x000000018BBDA2C8
		protected TMP_FontAsset GetFontAsset() => default; // 0x00000001848133D0-0x00000001848136E0
		private void _GenerateRuntimeText() {} // 0x000000018549A870-0x000000018549AAC0
		private void _ProcessRichTextInfo() {} // 0x000000018BBDA1A0-0x000000018BBDA1A8
		private void _OnPreRenderText(TMP_TextInfo textInfo) {} // 0x000000018BBDA168-0x000000018BBDA170
		private RichTextInfo _ProcessRichTextEntry(RichTextAnalyzer.RichTextParam mainParam, List<RichTextAnalyzer.RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder) => default; // 0x00000001813AE580-0x00000001813AE590
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018BBDA170-0x000000018BBDA178
		public void OnPointerEnter(PointerEventData eventData) {} // 0x000000018BBDA160-0x000000018BBDA168
		public void OnPointerExit(PointerEventData eventData) {} // 0x0000000185492010-0x0000000185492020
		protected override void Start() {} // 0x000000018BBDA180-0x000000018BBDA188
		protected override void OnEnable() {} // 0x000000018BBDA178-0x000000018BBDA180
		protected override void OnDisable() {} // 0x0000000185FB8600-0x0000000185FB8610
		private void _UpdateTick(float deltaTime) {} // 0x00000001864735E0-0x00000001864735F4
		public void ShrinkLinkTags() {} // 0x000000018BBDA198-0x000000018BBDA1A0
		public bool TryGetLinkId(Vector3 position, out string linkId) {
			linkId = default;
			return default;
		} // 0x000000018BBDA190-0x000000018BBDA198
		public bool TryGetLinkId(int linkIndex, out string linkId) {
			linkId = default;
			return default;
		} // 0x000000018BBDA120-0x000000018BBDA160
		public bool TryGetOriginalLinkId(string linkId, out string originalLinkId) {
			originalLinkId = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public bool TryGetCharacterStartPosAndHeight(int charIndex, out Vector3 worldPos, out float charHeight) {
			worldPos = default;
			charHeight = default;
			return default;
		} // 0x0000000185492010-0x0000000185492020
		public bool TryGetCharacterEndPosAndHeight(int charIndex, out Vector3 worldPos, out float charHeight) {
			worldPos = default;
			charHeight = default;
			return default;
		} // 0x00000001843987D0-0x00000001843988E0
		public void CombineStringWithLanguageSpilt<T1, T2>(T1 t1, T2 t2) {} // 0x0000000184399F30-0x000000018439A590
		public void CombineStringWithLanguageSpilt(string t1, string t2) {} // 0x0000000184BFADE0-0x0000000184BFB030
		public void CombineStringReverseForIndonesianAndVietnamese<T1, T2>(T1 t1, T2 t2) {} // 0x0000000184BFC9D0-0x0000000184BFCE00
		public void CombineStringReverseForIndonesianAndVietnamese(string t1, string t2) {} // 0x000000018BBD678C-0x000000018BBD6808
		public void SetHyperlinkUITextGroup(string groupId, int order) {} // 0x000000018BBD6520-0x000000018BBD678C
		public static bool IsHyperlinkUITextGroupDisplayable(string groupId) => default; // 0x0000000184BFC950-0x0000000184BFC9D0
		public static List<UIText> GetGroupDisplayableHyperlinkUIText(string groupId) => default; // 0x0000000184BFAAE0-0x0000000184BFADE0
		public void ClearComponent() {} // 0x0000000187213EA0-0x0000000187213ED8
		public void UpdateI18NFontAsset() {} // 0x000000018BBD6478-0x000000018BBD6520
		private void _RefreshMatTexture() {} // 0x000000018BBD4E84-0x000000018BBD4F20
		protected override void SetSharedMaterial(Material mat) {} // 0x000000018BBD4E00-0x000000018BBD4E84
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018BBD4F20-0x000000018BBD4F7C
		public void OnAfterDeserialize() {} // 0x000000018BBD5048-0x000000018BBD50A0
		protected override TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) => default; // 0x000000018BBD4F7C-0x000000018BBD5048
		public static string LocalStringCombineFormat(int count) => default; // 0x000000018BBD50A0-0x000000018BBD5140
		protected Sprite GetOrLoadSprite(string path) => default; // 0x00000001842407A0-0x00000001842408A0
		protected void DisposeInlineImageCache() {} // 0x000000018BBD5140-0x000000018BBD528C
		private void _ClearInlineImage() {} // 0x0000000184242D10-0x0000000184242DC0
		private ImageGOInfo _GetImageGoByIndex(int index) => default; // 0x000000018BBD528C-0x000000018BBD53F0
		private GameObject _GetOrCreateImageGO() => default; // 0x000000018BBD53F0-0x000000018BBD545C
		private void _ReturnImageGO(GameObject go) {} // 0x00000001842408A0-0x00000001842409F0
		private IEnumerator _DelayedChangeActiveImageGo() => default; // 0x0000000185C54C90-0x0000000185C54CE0
		public void __iFixBaseProxy_set_text(string P0) {} // 0x00000001842409F0-0x0000000184240AA0
		public void __iFixBaseProxy_ClearMesh() {} // 0x0000000185AE9D00-0x0000000185AE9FF0
		public void __iFixBaseProxy_RefreshPopulateText() {} // 0x0000000185F3A910-0x0000000185F3A9B0
		public Material __iFixBaseProxy_LoadMaterial(string P0) => default; // 0x0000000185F73690-0x0000000185F736F0
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_Awake() {} // 0x000000018BBD68E0-0x000000018BBD6A00
		public void __iFixBaseProxy_Start() {} // 0x000000018BBD6A00-0x000000018BBD6A54
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BBD6A54-0x000000018BBD6A74
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000181378230-0x0000000181378240
		public TMP_FontAsset __iFixBaseProxy_get_m_fontAsset() => default; // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_set_m_fontAsset(TMP_FontAsset P0) {} // 0x0000000183EBD720-0x0000000183EBECD0
		public void __iFixBaseProxy_set_fontSharedMaterial(Material P0) {} // 0x0000000181377E40-0x0000000181377E50
		public void __iFixBaseProxy_SetSharedMaterial(Material P0) {} // 0x0000000183EBECD0-0x0000000183EBED20
		public TMP_SubMeshUI __iFixBaseProxy_AddSubTextObject(TextMeshProUGUI P0, MaterialReference P1) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public static class UIConst // TypeDefIndex: 50128
	{
		// Fields
		public const float PC_REFERENCE_RESOLUTION_SCALE = 1.25f; // Metadata: 0x02061AF5
		public const float MOBILE_PAD_DEVICE_REFERENCE_RESOLUTION_SCALE = 1.1f; // Metadata: 0x02061AF9
		public static readonly Vector3 OUT_OF_SCREEN_POS; // 0x00
		public const float STANDARD_HORIZONTAL_RESOLUTION = 1920f; // Metadata: 0x02061AFD
		public const float STANDARD_VERTICAL_RESOLUTION = 1080f; // Metadata: 0x02061B01
		public const int INVALID_FINGER_ID = 2147483647; // Metadata: 0x02061B05
		public static float STANDARD_RATIO; // 0x0C
		public const float SCREEN_SPACE_CAMERA_PANEL_DISTANCE = 30f; // Metadata: 0x02061B06
		public const string UI_BLUR_MATERIAL = "Assets/Beyond/Arts/UI/Materials/M_ui_blur.mat"; // Metadata: 0x02061B0A
		public const string CS_POPUP_PANEL_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/CSPrefabs/CSPopupPanel.prefab"; // Metadata: 0x02061B38
		public const string NAVIGATION_TARGET_CLICK_NO_HINT_ACTION_ID = "navigation_target_click_no_hint"; // Metadata: 0x02061B7F
		public const string NAVIGATION_TARGET_CLICK_ACTION_ID = "navigation_target_click"; // Metadata: 0x02061B9F
		public const string UI_SPRITE_CHAR_HEAD_RECTANGLE = "CharIcon"; // Metadata: 0x02061BB7
		public const string UI_SPRITE_CHAR_REMOTE_ICON = "CharRemoteIcon"; // Metadata: 0x02061BC0
		public const string UI_SPRITE_CHAR_REMOTE_ICON_700 = "CharRemoteIcon700"; // Metadata: 0x02061BCF
		public const string UI_SPRITE_DIALOG_BG = "Dialog/BG"; // Metadata: 0x02061BE1
		public const string UI_SPRITE_DIALOG_OPTION_ICON = "Dialog/Option"; // Metadata: 0x02061BEB
		public const string SLIDER_STICK_SCROLL_HORI_ACTION_ID = "slider_stick_scroll_hori"; // Metadata: 0x02061BF9
	
		// Properties
		public static int STANDARD_HORIZONTAL_RESOLUTION_INT { get; } // 0x000000018BBD7054-0x000000018BBD7064 
		public static int STANDARD_VERTICAL_RESOLUTION_INT { get; } // 0x000000018BBD7064-0x000000018BBD7074 
		public static float CUR_STANDARD_HORIZONTAL_RESOLUTION { get; } // 0x00000001845E4510-0x00000001845E4560 
		public static float CUR_STANDARD_VERTICAL_RESOLUTION { get; } // 0x00000001845E4770-0x00000001845E47C0 
		public static int dragThreshold { get; } // 0x000000018BBD7074-0x000000018BBD70C4 
	
		// Nested types
		public enum AnimationState // TypeDefIndex: 50126
		{
			Stop = 1,
			In = 2,
			Loop = 3,
			Out = 4,
			InEasing = 5,
			Others = 6
		}
	
		public enum CommonUISegment // TypeDefIndex: 50127
		{
			InteractiveEntity = 1,
			LevelScriptModule = 2
		}
	
		// Constructors
		static UIConst() {} // 0x0000000185F5D490-0x0000000185F5D880
	
		// Methods
		public static float GetResolutionScale() => default; // 0x00000001845E6A40-0x00000001845E6AC0
		public static bool IsPadDevice() => default; // 0x000000018BBD6F00-0x000000018BBD7054
	}

	public class UIModelLoader : IDisposable // TypeDefIndex: 50130
	{
		// Fields
		private Dictionary<GameObject, FAssetProxyHandle> m_instance2AssetHandle; // 0x10
		private int m_requestCounter; // 0x18
		private HashSet<int> m_requestIds; // 0x20
		private bool m_disposed; // 0x28
		private static List<MagicaBoneCloth> s_magicaBoneCloths; // 0x00
	
		// Nested types
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 50129
		{
			// Fields
			public UIModelLoader __4__this; // 0x10
			public int requestId; // 0x18
			public FAssetProxyHandle handle; // 0x1C
			public string modelPath; // 0x30
			public Transform parent; // 0x38
			public Action<GameObject> callback; // 0x40
	
			// Constructors
			public __c__DisplayClass7_0() {} // 0x00000001850E5DC0-0x00000001850E5E90
	
			// Methods
			internal void _LoadModelAsync_b__0(FAssetProxyUntrackedHandle proxy) {} // 0x000000018BBD7A98-0x000000018BBD7C78
		}
	
		// Constructors
		public UIModelLoader() {} // 0x000000018BBD78B4-0x000000018BBD7A98
		static UIModelLoader() {} // 0x000000018BBD6A74-0x000000018BBD6EB4
	
		// Methods
		public GameObject LoadModel(string modelPath, Transform parent) => default; // 0x000000018BBD7830-0x000000018BBD78B4
		public int LoadModelAsync(string modelPath, Transform parent, Action<GameObject> callback) => default; // 0x000000018BBD7C78-0x000000018BBD7DEC
		public void Cancel(int requestId) {} // 0x0000000185179AE0-0x000000018517A240
		public void UnloadModel(GameObject modelGo) {} // 0x0000000185179AA0-0x0000000185179AE0
		private void _Clear() {} // 0x0000000185F3E7A0-0x0000000185F3E830
		public void Dispose() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class UIUtils // TypeDefIndex: 50131
	{
		// Fields
		private const int MAX_SHARED_INT_STRING = 255; // Metadata: 0x02061C1A
		private static readonly string[] s_sharedIntStringPool; // 0x00
		private static Vector3[] s_worldCorners; // 0x08
	
		// Constructors
		static UIUtils() {} // 0x0000000185F094E0-0x0000000185F09590
	
		// Methods
		public static string GetSharedIntString(int value) => default; // 0x00000001850AF070-0x00000001850AF1C0
		public static bool IsScreenPosInRectTransform(Vector3 screenPos, RectTransform rectTransform, Camera uiCamera) => default; // 0x0000000184CD2B60-0x0000000184CD2D80
		public static bool IsScreenPosInRectTransform(Vector2 screenPos, RectTransform rectTransform, Camera uiCamera) => default; // 0x0000000184D82770-0x0000000184D82930
		public static Bounds CalcBoundOfRectTransform(RectTransform transform, RectTransform local) => default; // 0x000000018BBDB5A0-0x000000018BBDB8EC
		public static bool TryGetTouch(int touchId, out UnityEngine.InputSystem.EnhancedTouch.Touch touch) {
			touch = default;
			return default;
		} // 0x000000018BBDBD1C-0x000000018BBDBF38
		public static void SetAlpha(Graphic image, float alpha) {} // 0x0000000184042410-0x00000001840424C0
		public static void SetColorWithoutAlpha(Graphic image, UnityEngine.Color color) {} // 0x000000018BBDBBB0-0x000000018BBDBC48
		public static void ClearUIComponents(GameObject gameObject) {} // 0x00000001849D5180-0x00000001849D5620
		public static Rect RectTransformToScreenRect(RectTransform rectTransform, Camera uiCamera) => default; // 0x00000001842325D0-0x0000000184232840
		public static Vector3 GetNodeScaleOffset(RectTransform referenceTransform, RectTransform selfTransform) => default; // 0x0000000185B50A50-0x0000000185B50BB0
		public static UnityEngine.Color GetColorByString(string strColor) => default; // 0x000000018BBDB8EC-0x000000018BBDBB08
		public static void SetMaskRatio(RectMask2D mask, float r) {} // 0x000000018BBDBC48-0x000000018BBDBD1C
		public static float GetCursorTipOffsetX(float defaultOffset) => default; // 0x000000018BBDBB08-0x000000018BBDBBB0
		public static float GetCursorTipOffsetInScreen(float defaultOffsetInScreen) => default; // 0x00000001845E5C60-0x00000001845E5C90
	}

	public class ActiveSyncHelper : MonoBehaviour // TypeDefIndex: 50132
	{
		// Fields
		private List<GameObject> _objs; // 0x18
		private bool _isInverse; // 0x20
	
		// Constructors
		public ActiveSyncHelper() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Awake() {} // 0x00000001856EF4A0-0x00000001856EF4E0
		private void OnEnable() {} // 0x00000001856EF520-0x00000001856EF560
		private void OnDisable() {} // 0x00000001856EF4E0-0x00000001856EF520
		public void Sync() {} // 0x00000001856EF560-0x00000001856F0500
	}

	public class Billboard : TickableUIMono // TypeDefIndex: 50133
	{
		// Fields
		public Camera sceneCamera; // 0x68
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public Billboard() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		protected override void OnEnable() {} // 0x000000018BBD3B40-0x000000018BBD3BEC
		public override void Tick(float deltaTime) {} // 0x000000018BBD3BEC-0x000000018BBD3CCC
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class CinemachineGyroscopeEffect : CinemachineExtension // TypeDefIndex: 50134
	{
		// Fields
		public float offsetX; // 0x28
		public float offsetY; // 0x2C
	
		// Constructors
		public CinemachineGyroscopeEffect() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) {} // 0x000000018BBD3CCC-0x000000018BBD3FE0
	}

	public class CommonItemToastList : UIScrollList // TypeDefIndex: 50135
	{
		// Constructors
		public CommonItemToastList() {} // 0x0000000185F5F7A0-0x0000000185F5F7F0
	
		// Methods
		public new void ScrollToIndex(int index = -1 /* Metadata: 0x02061C1C */, bool fastMode = false /* Metadata: 0x02061C1D */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02061C1E */, bool graduallyShowInFastMode = false /* Metadata: 0x02061C1F */) {} // 0x000000018BBD419C-0x000000018BBD4264
		protected void AdjustContainerPos(int index = -1 /* Metadata: 0x02061C20 */, bool fastMode = false /* Metadata: 0x02061C21 */) {} // 0x000000018BBD3FE0-0x000000018BBD419C
		private Vector2 _GetUnConstraintTargetPos(int index = -1 /* Metadata: 0x02061C22 */) => default; // 0x000000018BBD42B8-0x000000018BBD43A4
		private Vector2 _AdjustContainerPos_b__1_0() => default; // 0x000000018BBD4264-0x000000018BBD4288
		private void _AdjustContainerPos_b__1_1(Vector2 x) {} // 0x000000018BBD4288-0x000000018BBD42B8
	}

	public class ControllerSideMenuItemList : MonoBehaviour // TypeDefIndex: 50137
	{
		// Fields
		public List<MeunItemInfo> menuItems; // 0x18
		public Sprite icon; // 0x20
		public string title; // 0x28
		public RectTransform contentPosTrans; // 0x30
		public bool isFullScreen; // 0x38
		private static readonly HashSet<string> s_forceValidItemList; // 0x00
	
		// Nested types
		[Serializable]
		public class MeunItemInfo // TypeDefIndex: 50136
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
			public bool isForceValid { get => default; } // 0x000000018BBD44DC-0x000000018BBD45F8 
	
			// Constructors
			public MeunItemInfo() {} // 0x000000018BBD5FF4-0x000000018BBD6110
	
			// Methods
			public bool IsValid() => default; // 0x000000018BBD4438-0x000000018BBD44DC
			public string GetText() => default; // 0x000000018BBD43A4-0x000000018BBD4438
			public Sprite GetSprite() => default; // 0x0000000185D63560-0x0000000185D635F0
			public void Execute() {} // 0x0000000185F40840-0x0000000185F408D0
			public string GetItemName() => default; // 0x000000018BBD6110-0x000000018BBD6160
		}
	
		// Constructors
		public ControllerSideMenuItemList() {} // 0x000000018BBD5C8C-0x000000018BBD5DB4
		static ControllerSideMenuItemList() {} // 0x0000000185FBB160-0x0000000185FBB170
	
		// Methods
		public static void ToggleItemForceValid(string itemName, bool forceValid) {} // 0x000000018BBD5EC4-0x000000018BBD5FF4
		public static bool IsItemForceValid(string itemName) => default; // 0x000000018BBD5DB4-0x000000018BBD5EC4
		public static void ClearForceValidItemList() {} // 0x000000018BBD5B10-0x000000018BBD5C8C
	}

	public sealed class CustomNotchAdapt : MonoBehaviour // TypeDefIndex: 50138
	{
		// Fields
		public bool isLeft; // 0x18
		public bool isRight; // 0x19
		public bool isBottom; // 0x1A
		public bool isFullHorizontalStretch; // 0x1B
	
		// Constructors
		public CustomNotchAdapt() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public enum UIStyleInputValidType // TypeDefIndex: 50139
	{
		All = 0,
		Keyboard = 1,
		Touch = 2,
		Controller = 3,
		KeyboardAndTouch = 4,
		KeyboardAndController = 5,
		TouchAndController = 6
	}

	public enum UIStyleInputValidTypeMask // TypeDefIndex: 50140
	{
		Keyboard = 2,
		Touch = 4,
		Controller = 8,
		All = 14
	}

	public enum ActiveType // TypeDefIndex: 50141
	{
		UseGameObjectActive = 0,
		UseScale = 1
	}

	public class CustomUIStyle : MonoBehaviour // TypeDefIndex: 50143
	{
		// Fields
		public UIStyleInputValidType inputValidType; // 0x18
		public ActiveType activeType; // 0x1C
		private LayoutElement _layoutElement; // 0x20
		private Animator _animator; // 0x28
		private OverrideValidState m_overrideValidState; // 0x30
	
		// Properties
		public UIStyleInputValidTypeMask inputValidTypeMask { get => default; set {} } // 0x000000018BBD46FC-0x000000018BBD47B0 0x000000018BBD47B0-0x000000018BBD4864
		public OverrideValidState overrideValidState { get => default; set {} } // 0x00000001813CFF60-0x00000001813CFF70 0x000000018BBD4864-0x000000018BBD4870
		public bool isValid { get => default; } // 0x00000001851D1BE0-0x00000001851D1C20 
	
		// Nested types
		public enum OverrideValidState // TypeDefIndex: 50142
		{
			None = 0,
			ForceValid = 1,
			ForceNotValid = 2
		}
	
		// Constructors
		public CustomUIStyle() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void _OnActiveTypeChanged() {} // 0x000000018BBD45F8-0x000000018BBD46FC
		private void OnDestroy() {} // 0x00000001845A3370-0x00000001845A3470
		private void OnEnable() {} // 0x00000001851D1B10-0x00000001851D1B50
		private void Awake() {} // 0x00000001845A4340-0x00000001845A4440
		public void CheckState() {} // 0x00000001851D1B50-0x00000001851D1BE0
		public void ToggleActiveState(bool isActive) {} // 0x00000001851D1CF0-0x00000001851D1F60
		public static bool IsShowTypeValid(UIStyleInputValidType inputValidType) => default; // 0x00000001851D1C20-0x00000001851D1CF0
		public static bool IsValidInput(UIStyleInputValidTypeMask inputValidTypeMask) => default; // 0x00000001845A4F60-0x00000001845A4FD0
	}

	public class DeactivateNaviOnEnable : MonoBehaviour // TypeDefIndex: 50144
	{
		// Fields
		public string key; // 0x18
	
		// Constructors
		public DeactivateNaviOnEnable() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void OnEnable() {} // 0x000000018BBD4900-0x000000018BBD4990
		private void OnDisable() {} // 0x000000018BBD4870-0x000000018BBD4900
	}

	public class DecoLineActiveHelper : TickableUIMono // TypeDefIndex: 50145
	{
		// Fields
		public List<GameObject> checkTargets; // 0x68
		public List<GameObject> secondCheckTargets; // 0x70
		private LayoutElement _layoutElement; // 0x78
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Constructors
		public DecoLineActiveHelper() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		private void Reset() {} // 0x000000018BBD4990-0x000000018BBD4A08
		protected override void OnEnable() {} // 0x000000018420FD90-0x000000018420FE30
		public override void LateTick(float deltaTime) {} // 0x00000001842102A0-0x00000001842106D0
		public void Sync() {} // 0x000000018BBD4A08-0x000000018BBD4A3C
		private bool _HasActiveTarget(List<GameObject> targets) => default; // 0x000000018BBD4A3C-0x000000018BBD4B08
		private void _ToggleVisible(bool isVisible) {} // 0x000000018BBD4B08-0x000000018BBD4BD4
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class Empty4Raycast : MaskableGraphic // TypeDefIndex: 50146
	{
		// Constructors
		protected Empty4Raycast() {} // 0x000000018BBD4C40-0x000000018BBD4C60
	
		// Methods
		protected override void OnPopulateMesh(VertexHelper vh) {} // 0x000000018BBD4BD4-0x000000018BBD4C38
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0) {} // 0x000000018BBD4C38-0x000000018BBD4C40
	}

	public class FitAspectRatioByFOV : MonoBehaviour, DeviceInfoManager.IScreenSizeListener // TypeDefIndex: 50147
	{
		// Fields
		public float referenceAspect; // 0x18
		private float m_referenceVerticalFOV; // 0x1C
		private CinemachineVirtualCamera m_virtualCamera; // 0x20
		private float m_currentAspect; // 0x28
		private float _maxFov; // 0x2C
		private float m_overrideMaxFov; // 0x30
	
		// Properties
		public float maxFov { get => default; set {} } // 0x000000018BBD4CF8-0x000000018BBD4D58 0x000000018BBD4D58-0x000000018BBD4D64
	
		// Constructors
		public FitAspectRatioByFOV() {} // 0x0000000185F66730-0x0000000185F66740
	
		// Methods
		private void Start() {} // 0x000000018BBD4C60-0x000000018BBD4CF8
		private void OnEnable() {} // 0x00000001845A38B0-0x00000001845A3920
		private void OnDisable() {} // 0x00000001845A3920-0x00000001845A3990
		public void OnScreenSizeChanged(int width, int height) {} // 0x00000001845A3860-0x00000001845A38B0
		private void _AdjustFOV() {} // 0x00000001845A3700-0x00000001845A3790
	}

	public class FixRotation : TickableUIMono // TypeDefIndex: 50148
	{
		// Fields
		public Vector3 rotation; // 0x68
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Constructors
		public FixRotation() {} // 0x0000000185F089C0-0x0000000185F089E0
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x00000001853EF580-0x00000001853EF5F0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class FullScreenSceneBlurMarker : MonoBehaviour // TypeDefIndex: 50150
	{
		// Fields
		private static int s_nextId; // 0x00
		public static Action<int, State, bool, bool> s_onFullScreenSceneBlurMarkerStateChanged; // 0x08
		private int _id_k__BackingField; // 0x18
		public bool useWhiteBlur; // 0x1C
		public bool useSceneColorPS; // 0x1D
	
		// Properties
		public int id { get; private set; } // 0x00000001813AE560-0x00000001813AE570 0x00000001813AE9C0-0x00000001813AE9D0
	
		// Nested types
		public enum State // TypeDefIndex: 50149
		{
			OnEnable = 0,
			OnDisable = 1,
			OnDestroy = 2
		}
	
		// Constructors
		public FullScreenSceneBlurMarker() {} // 0x0000000185F5A9B0-0x0000000185F5A9C0
		static FullScreenSceneBlurMarker() {} // 0x0000000185FA4B60-0x0000000185FA4BA0
	
		// Methods
		private static int _GetNextId() => default; // 0x0000000185D2A400-0x0000000185D2A470
		private void Awake() {} // 0x0000000185D2A3A0-0x0000000185D2A400
		private void OnEnable() {} // 0x0000000185A31620-0x0000000185A316C0
		private void OnDisable() {} // 0x0000000185A31580-0x0000000185A31620
		private void OnDestroy() {} // 0x0000000185A314E0-0x0000000185A31580
	}

	public class InputBindingGroupNaviDecorator : Selectable, IUIClearable // TypeDefIndex: 50151
	{
		// Fields
		private InputBindingGroupMonoTarget m_inputBindingGroup; // 0x180
		public UnityEvent<bool> onGroupSetAsNaviTarget; // 0x188
	
		// Constructors
		public InputBindingGroupNaviDecorator() {} // 0x0000000185A1D8A0-0x0000000185A1D950
	
		// Methods
		private void _SetSelfEnabledStateIfNecessary() {} // 0x00000001859BCF70-0x00000001859BD020
		protected override void Awake() {} // 0x0000000185C20CE0-0x0000000185C20D60
		protected override void OnEnable() {} // 0x00000001859BCEF0-0x00000001859BCF70
		protected override void OnDestroy() {} // 0x0000000185D2A870-0x0000000185D2A8B0
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode) {} // 0x000000018BBD59F8-0x000000018BBD5B10
		public void ClearComponent() {} // 0x0000000185D2A8B0-0x0000000185D2AC80
		public void __iFixBaseProxy_Awake() {} // 0x000000018BBD59E0-0x000000018BBD59E8
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BBD59F0-0x000000018BBD59F8
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018BBD59E8-0x000000018BBD59F0
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1) {} // 0x0000000185492010-0x0000000185492020
	}

	public interface IUIClearable : ILuaCallCSharp // TypeDefIndex: 50152
	{
		// Methods
		void ClearComponent();
	}

	public class LuaPanel : MonoBehaviour, IUIClearable // TypeDefIndex: 50154
	{
		// Fields
		public static Dictionary<string, LuaPanel> s_openedLuaPanels; // 0x00
		private bool _isPCOnlyPanel; // 0x18
		private bool _isControllerPanel; // 0x19
		[NonSerialized]
		public bool inited; // 0x1A
		private bool _isWorldUI; // 0x1B
		private Vector3 _uiRot; // 0x1C
		private bool _blockWhileAnim; // 0x28
		private int _panelLevel_k__BackingField; // 0x2C
		public UIAnimationWrapper animationWrapper; // 0x30
		private AudioUIUtil.UIAudioType _uiAudioType; // 0x38
		private RectTransform _rectTransform_k__BackingField; // 0x40
		private Canvas _canvas_k__BackingField; // 0x48
		public HashSet<UISortingOrder> sortingOrderComps; // 0x50
		private Camera _uiCamera_k__BackingField; // 0x58
		private float _planeDistance_k__BackingField; // 0x60
		private int _panelId_k__BackingField; // 0x64
		private string _panelName_k__BackingField; // 0x68
		private bool m_showRot; // 0x70
		private InputBindingGroupMonoTarget m_inputBindingGroupMonoTarget; // 0x78
		private GraphicRaycaster[] m_graphicRaycasters; // 0x80
		private bool m_started; // 0x88
		private Coroutine m_animationInCoroutine; // 0x90
		private bool m_waitAutoAnimInFinished; // 0x98
		public DisposedUnityEvent onAnimationInFinished; // 0xA0
		private bool m_animationInFinished; // 0xA8
		private HashSet<GameObject> m_animationInWaitTargets; // 0xB0
	
		// Properties
		public bool blockWhileAnim { get => default; } // 0x000000018571FEC0-0x000000018571FED0 
		public int panelLevel { get; set; } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		public RectTransform rectTransform { get; private set; } // 0x0000000185FB2200-0x0000000185FB2210 0x0000000185FB2230-0x0000000185FB2240
		public Canvas canvas { get; private set; } // 0x0000000185FB2020-0x0000000185FB2030 0x0000000185FB2030-0x0000000185FB2040
		public Camera uiCamera { get; set; } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		public float planeDistance { get; set; } // 0x0000000185FB35C0-0x0000000185FB35D0 0x0000000185FB3590-0x0000000185FB35A0
		public int panelId { get; set; } // 0x00000001813C0430-0x00000001813C0440 0x0000000181A73E90-0x0000000181A73EA0
		public string panelName { get; set; } // 0x00000001849CDB90-0x00000001849CDC90 0x00000001849CDB10-0x00000001849CDB90
		public bool IsWorldUI { get => default; set {} } // 0x0000000185C45E20-0x0000000185C45EC0 0x0000000184CD1D30-0x0000000184CD1DA0
		public bool isPCOnlyPanel { get => default; } // 0x00000001857BBD90-0x00000001857BBDD0 
		public bool isControllerPanel { get => default; } // 0x0000000184A7D010-0x0000000184A7D0F0 
		public bool animationInFinished { get => default; } // 0x00000001849D7F10-0x00000001849D7F60 
	
		// Nested types
		private sealed class __AutoAnimationInFinish_d__61 : IEnumerator<object> // TypeDefIndex: 50153
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LuaPanel __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001813FF010-0x00000001813FF020 
			object IEnumerator.Current { get => default; } // 0x00000001813ECF20-0x00000001813ECF30 
	
			// Constructors
			public __AutoAnimationInFinish_d__61() {} // Dummy constructor
			public __AutoAnimationInFinish_d__61(int __1__state) {} // 0x00000001813B31B0-0x00000001813B31C0
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FB0630-0x0000000185FB0640
			private bool MoveNext() => default; // 0x0000000185FB0640-0x0000000185FB0650
			void IEnumerator.Reset() {} // 0x0000000185F05C80-0x0000000185F05C90
		}
	
		// Constructors
		public LuaPanel() {} // 0x000000018BBD6EB4-0x000000018BBD6F00
		static LuaPanel() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		private void Awake() {} // 0x0000000184A7CDE0-0x0000000184A7CE50
		private void _TrySetRot() {} // 0x00000001849D8010-0x00000001849D8050
		public void AddSortingOrderComp(UISortingOrder comp) {} // 0x0000000184A7D0F0-0x0000000184A7D170
		public void RemoveSortingOrderComp(UISortingOrder comp) {} // 0x0000000185FB8C10-0x0000000185FB8C20
		private void Start() {} // 0x0000000184B43A60-0x0000000184B43B20
		private void OnEnable() {} // 0x00000001844A7490-0x00000001844A7530
		private void OnDisable() {} // 0x00000001844A7530-0x00000001844A7690
		private void OnDestroy() {} // 0x00000001848D2130-0x00000001848D2220
		private IEnumerator _AutoAnimationInFinish() => default; // 0x00000001848D2220-0x00000001848D2310
		public bool InformAnimationInStart(GameObject target) => default; // 0x00000001848172C0-0x0000000184817400
		public void InformAnimationInEnd(GameObject target, bool forceEnd = false /* Metadata: 0x02061C36 */) {} // 0x0000000185F3F640-0x0000000185F3F6D0
		private void _TryCallAnimationInFinished(bool forceFinished) {} // 0x0000000181378230-0x0000000181378240
		public void BlockAllInput() {} // 0x0000000185492010-0x0000000185492020
		public void RecoverAllInput() {} // 0x00000001844A73E0-0x00000001844A7490
		public void ClearComponent() {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class MouseHoverTipsPosHelper : TickableUIMono // TypeDefIndex: 50155
	{
		// Fields
		private RectOffset _padding; // 0x68
		private LuaPanel m_panel; // 0x70
		private RectTransform m_rectTransform; // 0x78
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
		public LuaPanel panel { get => default; } // 0x00000001845E5BB0-0x00000001845E5C60 
	
		// Constructors
		public MouseHoverTipsPosHelper() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		protected override void OnAwake() {} // 0x0000000185D5C650-0x0000000185D5C740
		protected override void OnEnable() {} // 0x00000001845E4470-0x00000001845E44B0
		public override void LateTick(float deltaTime) {} // 0x00000001845E5280-0x00000001845E52C0
		public void UpdatePosition() {} // 0x00000001845E5780-0x00000001845E5BB0
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class NaviToThisGroupOnEnable : MonoBehaviour // TypeDefIndex: 50156
	{
		// Fields
		public UISelectableNaviGroup target; // 0x18
	
		// Constructors
		public NaviToThisGroupOnEnable() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Reset() {} // 0x000000018BBD62AC-0x000000018BBD632C
		private void Awake() {} // 0x000000018BBD6160-0x000000018BBD6210
		private void OnEnable() {} // 0x000000018BBD6210-0x000000018BBD62AC
	}

	public class NonDrawingGraphic : Graphic, ICanvasRaycastFilter // TypeDefIndex: 50158
	{
		// Fields
		public ShapeType shapeType; // 0xB0
	
		// Properties
		public float Radius { get => default; } // 0x0000000183FCAF70-0x0000000183FCB000 
	
		// Nested types
		public enum ShapeType // TypeDefIndex: 50157
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public NonDrawingGraphic() {} // 0x0000000184B37D60-0x0000000184B37DB0
	
		// Methods
		public override void SetMaterialDirty() {} // 0x00000001855F1110-0x00000001855F1140
		public override void SetVerticesDirty() {} // 0x00000001855046F0-0x0000000185504720
		protected override void OnPopulateMesh(VertexHelper vh) {} // 0x000000018BBD632C-0x000000018BBD6390
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) => default; // 0x0000000183FCB810-0x0000000183FCB880
		private bool _IsRaycastLocationValidCircle(Vector2 sp, Camera eventCamera) => default; // 0x0000000183FCAE60-0x0000000183FCAF70
		public void __iFixBaseProxy_SetMaterialDirty() {} // 0x000000018BBD6390-0x000000018BBD6398
		public void __iFixBaseProxy_SetVerticesDirty() {} // 0x000000018BBD6398-0x000000018BBD63A0
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0) {} // 0x000000018BBD4C38-0x000000018BBD4C40
	}

	public sealed class NotchAdapter : MonoBehaviour // TypeDefIndex: 50160
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
	
		// Nested types
		[Serializable]
		private sealed class __c__19<T> // TypeDefIndex: 50159
		{
			// Fields
			public static readonly __c__19<T> __9;
			public static Predicate<T> __9__19_0;
	
			// Constructors
			static __c__19() {} // 0x0000000185383CC0-0x0000000185383D70
			public __c__19() {}
	
			// Methods
			internal bool __RemoveNullRef_b__19_0(T x) => default; // 0x0000000185384400-0x0000000185384480
		}
	
		// Constructors
		public NotchAdapter() {}
	
		// Methods
		private void Awake() {} // 0x000000018BBD63A0-0x000000018BBD6408
		private void OnDestroy() {} // 0x0000000185383D70-0x0000000185384360
		public void FindAllSideUI(bool needClear) {} // 0x0000000185384480-0x0000000185384520
		public void ApplyNotch() {} // 0x0000000185384360-0x0000000185384400
		public void ApplyNotch(Vector2 curMarginSize) {} // 0x000000018BBD6408-0x000000018BBD6478
		public void ClearList() {} // 0x0000000185383C40-0x0000000185383CC0
		public void ClearNullRef() {} // 0x00000001849D1930-0x00000001849D1C20
		public void UnApplyNotch() {} // 0x0000000185383C00-0x0000000185383C40
		public void ApplyNewNotch() {}
		private void _UpdateMargeSizeFromNotchInfo(bool forceUpdate = false /* Metadata: 0x02061C39 */) {} // 0x0000000185384810-0x0000000185384BC0
		private void _OnCanvasChanged() {} // 0x0000000185384BC0-0x0000000185384E80
		private void _RemoveNullRef<T>(List<T> list) {} // 0x0000000184DBE900-0x0000000184DBEA30
		private void _TraverseUI(RectTransform root) {}
		private void _TryAddToSideUI(RectTransform rect, CustomNotchAdapt custom = null) {}
	}

	public class ParallaxHelper : MonoBehaviour // TypeDefIndex: 50162
	{
		// Fields
		private List<ParallaxConfig> _configs; // 0x18
		private float _maxOffset; // 0x20
		private float m_curValue; // 0x24
	
		// Properties
		public float curValue { get => default; set {} } // 0x000000018BBE87E0-0x000000018BBE87EC 0x000000018BBE8428-0x000000018BBE85B0
	
		// Nested types
		[Serializable]
		public class ParallaxConfig // TypeDefIndex: 50161
		{
			// Fields
			public RectTransform target; // 0x10
			public float ratio; // 0x18
			[NonSerialized]
			public Vector2 oriPosition; // 0x1C
	
			// Constructors
			public ParallaxConfig() {} // 0x0000000185FB3810-0x0000000185FB3820
		}
	
		// Constructors
		public ParallaxHelper() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void InitConfigs() {} // 0x000000018BBE8788-0x000000018BBE87E0
		public void ResetValue() {} // 0x000000018BBE85B0-0x000000018BBE8788
		public void RefreshPos() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class PercentNumberTweener : TickableUIMono // TypeDefIndex: 50163
	{
		// Fields
		private UIText _text; // 0x68
		private string _format; // 0x70
		private UIImage _progressImg; // 0x78
		private int m_cacheValue; // 0x80
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Constructors
		public PercentNumberTweener() {} // 0x000000018BBE89E4-0x000000018BBE8A34
	
		// Methods
		private void Reset() {} // 0x000000018BBE8964-0x000000018BBE89E4
		protected override void OnEnable() {} // 0x000000018BBE8904-0x000000018BBE8964
		public override void LateTick(float deltaTime) {} // 0x000000018BBE87EC-0x000000018BBE8904
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public abstract class UIRecycleLayoutAdapter // TypeDefIndex: 50168
	{
		// Fields
		private UIRecycleLayoutGroup.IViewHandler _viewHandler_k__BackingField; // 0x10
	
		// Properties
		public UIRecycleLayoutGroup.IViewHandler viewHandler { get; private set; }
	
		// Nested types
		public interface ICustomViewType // TypeDefIndex: 50164
		{
			// Properties
			int viewType { get; } // 0x000000018BBEE504-0x000000018BBEE574 
		}
	
		public interface ICustomSpacing // TypeDefIndex: 50165
		{
			// Methods
			float GetCustomSpacing(); // 0x000000018346D130-0x000000018346D140
		}
	
		public interface IVirtualView : IHotfixable // TypeDefIndex: 50166
		{
			// Methods
			void AttachView(GameObject view); // 0x0000000184096E30-0x0000000184096EF0
			void DetachView(); // 0x000000018BBEE4B8-0x000000018BBEE504
			GameObject GetAttachedView();
			int GetViewID(); // 0x0000000185492010-0x0000000185492020
			GameObject GetPrefab();
			float GetPreferSize();
		}
	
		public abstract class VirtualView : IVirtualView // TypeDefIndex: 50167
		{
			// Fields
			protected GameObject m_gameObj; // 0x10
	
			// Properties
			public bool isAttached { get; }
	
			// Constructors
			protected VirtualView() {} // 0x000000018BBF23C0-0x000000018BBF2410
	
			// Methods
			public void AttachView(GameObject gameObj) {}
			public void DetachView() {}
			public GameObject GetAttachedView() => default;
			public int GetViewID() => default;
			protected abstract void OnViewAttached();
			protected abstract void OnViewDetached(); // 0x000000018BBF2468-0x000000018BBF24B8
			public abstract GameObject GetPrefab(); // 0x000000018BBF22B0-0x000000018BBF235C
			public abstract float GetPreferSize(); // 0x000000018BBF235C-0x000000018BBF23C0
		}
	
		// Constructors
		protected UIRecycleLayoutAdapter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Init(UIRecycleLayoutGroup.IViewHandler handler) {} // 0x000000018BBF2410-0x000000018BBF2468
		public virtual IList<IVirtualView> GenerateViewsForRebuild() => default;
		public abstract void OnInit();
	}

	public abstract class UIRecycleLayoutSimpleHolder<TVirtualView> : TickableUIMono // TypeDefIndex: 50171
		where TVirtualView : UIRecycleLayoutAdapter.VirtualView
	{
		// Fields
		private UIScrollRect _scrollRect;
		protected float _scrollDuration;
		protected Ease _scrollEase;
		protected bool _enableLoopWrappedNavigation;
		private bool m_isInited;
		protected SimpleAdapter m_simpleAdapter;
		protected UIRecycleLayoutGroup m_layoutGroup;
		[NonSerialized]
		public DisposedUnityEvent doOnceAfterLayout;
		private List<Selectable> m_wrapNaviSelectables;
		protected DG.Tweening.Tween m_scrollTween;
	
		// Nested types
		public class SimpleAdapter : UIRecycleLayoutAdapter // TypeDefIndex: 50169
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
			public void RemoveAllViews(bool dontRebuild = false /* Metadata: 0x02061C3C */) {}
			public int GetCount() => default;
			public TVirtualView GetVirtualView(int index) => default;
			public GameObject GetView(int index) => default;
			public void NotifySizeChanged(TVirtualView virtualView) {}
			public void NotifyAllSizeChanged() {}
			public void NotifySizeChanged(int index) {}
			public override void OnInit() {}
			public void OnDisposed() {}
		}
	
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 50170
		{
			// Fields
			public UIRecycleLayoutSimpleHolder<TVirtualView> __4__this;
			public int naviIndex;
			public bool isBefore;
	
			// Constructors
			public __c__DisplayClass13_0() {}
	
			// Methods
			internal void __WrapNavigation_b__0() {}
		}
	
		// Constructors
		protected UIRecycleLayoutSimpleHolder() {}
	
		// Methods
		private void _InitIfNot() {}
		protected override void OnAwake() {}
		private void _AfterLayout() {}
		private void _WrapNavigation(NaviDirection dir) {}
		public abstract void OnAdapterInit();
		public void ScrollTo(int index, bool fastMode = false /* Metadata: 0x02061C3A */) {}
		protected void ClearScrollTweenIfNeeded() {}
		protected virtual void ScrollToInternal(float normalizedPosition, bool fastMode = false /* Metadata: 0x02061C3B */) {}
		public GameObject GetView(int index) => default;
		public void NotifyAllSizeChanged() {}
		public void NotifySizeChanged(int index) {}
		public void NotifySizeChanged(TVirtualView virtualView) {}
		public void RemoveView(int index) {}
		public void RemoveAllViews() {}
	}

	public class UIRecycleLayoutGroup : TickableUIMono, ILayoutElement, IUIClearable // TypeDefIndex: 50180
	{
		// Fields
		private Direction _direction; // 0x68
		private RectTransform _viewport; // 0x70
		private RectTransform _content; // 0x78
		private float _notCachedBufferSize; // 0x80
		private int _layoutPriority; // 0x84
		private Padding _padding; // 0x88
		private float _spacing; // 0x98
		private Dictionary<int, LayoutMeta> m_layoutMetaMap; // 0xA0
		private UIRecycleLayoutAdapter m_adapter; // 0xA8
		private ViewMgr m_viewMgr; // 0xB0
		private float _sizeOnAxis_k__BackingField; // 0xB8
		[NonSerialized]
		public DisposedUnityEvent onLayoutUpdated; // 0xC0
	
		// Properties
		protected override TickType tickOption { get => default; }
		public UIRecycleLayoutAdapter adapter { get => default; }
		protected ViewMgr viewMgr { get => default; }
		protected float sizeOnAxis { get; private set; }
		protected float spacing { get => default; }
		protected Padding padding { get => default; } // 0x00000001813CFF60-0x00000001813CFF70 
		public float minWidth { get => default; } // 0x00000001813D0A90-0x00000001813D0AA0 
		public float minHeight { get => default; } // 0x000000018BBF21C0-0x000000018BBF22B0 
		public float flexibleWidth { get => default; } // 0x000000018BBF1D48-0x000000018BBF1ED8 
		public float flexibleHeight { get => default; } // 0x000000018BBF2014-0x000000018BBF21C0 
		public int layoutPriority { get => default; } // 0x000000018BBF1ED8-0x000000018BBF2014 
		public float preferredWidth { get => default; } // 0x000000018BBF1598-0x000000018BBF15E8 
		public float preferredHeight { get => default; } // 0x000000018BBF114C-0x000000018BBF11E4 
		protected float paddingFront { get => default; } // 0x000000018BBF1060-0x000000018BBF114C 
		protected float paddingBack { get => default; } // 0x000000018BBF1478-0x000000018BBF1500 
		protected RectTransform content { get => default; } // 0x000000018BBE8088-0x000000018BBE80D4 
	
		// Nested types
		public enum Direction // TypeDefIndex: 50172
		{
			Vertical = 0,
			Horizontal = 1
		}
	
		public enum AdaptMode // TypeDefIndex: 50173
		{
			Normal = 0,
			MultiPrefab = 1
		}
	
		public interface IViewHandler // TypeDefIndex: 50174
		{
			// Methods
			UIRecycleLayoutAdapter.IVirtualView GetView(int index); // 0x0000000185FB6DA0-0x0000000185FB6DB0
			int GetViewCount(); // 0x000000018BBEFCAC-0x000000018BBEFD48
			bool InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018BBEFE48-0x000000018BBEFEF8
			bool AddView(UIRecycleLayoutAdapter.IVirtualView view); // 0x0000000185FBAC60-0x0000000185FBAC70
			void NotifyViewSizeChanged(UIRecycleLayoutAdapter.IVirtualView view); // 0x0000000185FB1D90-0x0000000185FB1DA0
			void NotifyAllViewSizeChanged(); // 0x0000000181B74C40-0x0000000181B74C50
			void NotifyRebuild(); // 0x0000000185FBDE50-0x0000000185FBDE60
			bool RemoveView(UIRecycleLayoutAdapter.IVirtualView view); // 0x0000000183908D00-0x0000000183908D10
			float GetElementPosByIndex(int index); // 0x0000000183908D00-0x0000000183908D10
			Bounds GetElementBoundsByIndex(int index); // 0x0000000183908D00-0x0000000183908D10
			Direction GetDirection(); // 0x0000000183908D00-0x0000000183908D10
			float GetSizeOnAxis(); // 0x0000000182FB0000-0x0000000182FB0010
			float GetViewportSizeOnAxis(); // 0x000000018BBEE574-0x000000018BBEE5B8
			int GetElementIndex(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018BBEE5B8-0x000000018BBEE5FC
		}
	
		protected struct LayoutMeta // TypeDefIndex: 50175
		{
			// Fields
			public float pos; // 0x00
			public float size; // 0x04
			public int index; // 0x08
			public float curTotalSize; // 0x0C
		}
	
		private class ViewPool // TypeDefIndex: 50176
		{
			// Fields
			private GameObject m_prefab; // 0x10
			private Transform m_container; // 0x18
			private List<GameObject> m_activeObjs; // 0x20
			private List<GameObject> m_pooledObjs; // 0x28
			private int _viewType_k__BackingField; // 0x30
	
			// Properties
			public int viewType { get; private set; } // 0x000000018BBEFE34-0x000000018BBEFE48 0x000000018BBEFE20-0x000000018BBEFE34
	
			// Constructors
			public ViewPool() {} // Dummy constructor
			public ViewPool(int viewType, GameObject prefab, Transform container) {} // 0x000000018BBEFDB4-0x000000018BBEFE20
	
			// Methods
			public GameObject Alloc(out bool isNewlyCreated) {
				isNewlyCreated = default;
				return default;
			} // 0x000000018BBEFD48-0x000000018BBEFDB4
			public bool Recycle(GameObject obj) => default; // 0x000000018BBEEAD4-0x000000018BBEEE60
			public void RecycleAll() {} // 0x000000018BBEF2F0-0x000000018BBEF400
		}
	
		protected class ViewMgr : IHotfixable, IViewHandler // TypeDefIndex: 50177
		{
			// Fields
			private UIRecycleLayoutGroup m_closure; // 0x10
			private ListDict<int, ViewPool> m_viewPools; // 0x18
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views; // 0x20
	
			// Constructors
			public ViewMgr() {} // Dummy constructor
			public ViewMgr(UIRecycleLayoutGroup closure) {} // 0x000000018BBEEF94-0x000000018BBEF16C
	
			// Methods
			public void RebuildAll(UIRecycleLayoutAdapter adapter) {} // 0x000000018BBEEA24-0x000000018BBEEAD4
			public IList<UIRecycleLayoutAdapter.IVirtualView> GetViews() => default; // 0x000000018BBEE5FC-0x000000018BBEE68C
			public void DetachView(UIRecycleLayoutAdapter.IVirtualView view, GameObject curView) {} // 0x000000018BBEE68C-0x000000018BBEE6EC
			public void AttachView(UIRecycleLayoutAdapter.IVirtualView view) {} // 0x000000018BBEE6EC-0x000000018BBEEA24
			public UIRecycleLayoutAdapter.IVirtualView GetView(int index) => default; // 0x000000018BBEF588-0x000000018BBEF640
			public int GetViewCount() => default; // 0x000000018BBEF900-0x000000018BBEFBE0
			public bool InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x000000018BBEF400-0x000000018BBEF588
			public bool AddView(UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x000000018BBEF698-0x000000018BBEF83C
			public bool RemoveView(UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x000000018BBEF83C-0x000000018BBEF900
			public void NotifyViewSizeChanged(UIRecycleLayoutAdapter.IVirtualView view) {} // 0x000000018BBEF220-0x000000018BBEF2F0
			public void NotifyAllViewSizeChanged() {} // 0x000000018BBEEE60-0x000000018BBEEF94
			public void NotifyRebuild() {} // 0x000000018BBEF16C-0x000000018BBEF220
			public float GetElementPosByIndex(int index) => default; // 0x0000000183060C50-0x0000000183060C60
			public Bounds GetElementBoundsByIndex(int index) => default; // 0x000000018BBEF640-0x000000018BBEF698
			public Direction GetDirection() => default; // 0x000000018BBEFBE0-0x000000018BBEFCAC
			public float GetSizeOnAxis() => default; // 0x0000000187A742A0-0x0000000187A742A8
			public float GetViewportSizeOnAxis() => default;
			public int GetElementIndex(UIRecycleLayoutAdapter.IVirtualView view) => default;
			private ViewPool _EnsureViewPool(UIRecycleLayoutAdapter.IVirtualView view) => default;
			private void _NotifyLayoutChanged(int fromIndex) {}
		}
	
		[Serializable]
		protected struct Padding // TypeDefIndex: 50178
		{
			// Fields
			public int top; // 0x00
			public int left; // 0x04
			public int bottom; // 0x08
			public int right; // 0x0C
		}
	
		public class EmptyAdapter : UIRecycleLayoutAdapter // TypeDefIndex: 50179
		{
			// Constructors
			public EmptyAdapter() {}
	
			// Methods
			public override IList<IVirtualView> GenerateViewsForRebuild() => default;
			public override void OnInit() {}
			public IList<IVirtualView> __iFixBaseProxy_GenerateViewsForRebuild() => default;
		}
	
		// Constructors
		public UIRecycleLayoutGroup() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void CalculateLayoutInputHorizontal() {} // 0x000000018BBF1C70-0x000000018BBF1D48
		public void CalculateLayoutInputVertical() {} // 0x000000018BBF1794-0x000000018BBF19E8
		private void _ApplyLayoutMeta(UIRecycleLayoutAdapter.IVirtualView view, LayoutMeta meta) {} // 0x000000018BBF1404-0x000000018BBF1478
		private Vector2 _GetVisibleRange(Bounds viewBound) => default; // 0x000000018BBF15E8-0x000000018BBF1670
		private Bounds _GetElementBoundsFromMeta(LayoutMeta meta) => default; // 0x000000018BBF0FC4-0x000000018BBF1060
		public UIRecycleLayoutAdapter SetAdapter(UIRecycleLayoutAdapter adapter) => default; // 0x000000018BBF19E8-0x000000018BBF1A5C
		public void ClearComponent() {} // 0x000000018BBF1724-0x000000018BBF1794
		public override void LateTick(float deltaTime) {} // 0x000000018BBF1670-0x000000018BBF16CC
		protected void OnLateTick() {} // 0x000000018BBF16CC-0x000000018BBF1724
		private void _RebuildAllViews() {} // 0x000000018BBF1340-0x000000018BBF13A8
		private void _UpdateViews(int fromIndex) {} // 0x000000018BBF123C-0x000000018BBF12D4
		private bool _InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x000000018BBF11E4-0x000000018BBF123C
		private bool _RemoveView(UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x000000018BBF13A8-0x000000018BBF1404
		private void _UpdateViewsFrom(UIRecycleLayoutAdapter.IVirtualView view) {} // 0x000000018BBF1500-0x000000018BBF1598
		private float _GetElementPosByIndex(int index) => default; // 0x000000018BBF12D4-0x000000018BBF1340
		private Bounds _GetElementBoundsByIndex(int index) => default; // 0x000000018BBF1A5C-0x000000018BBF1BDC
		private int _GetElementIndex(UIRecycleLayoutAdapter.IVirtualView view) => default; // 0x000000018BBF1BDC-0x000000018BBF1C70
		private void _RefreshLayout() {} // 0x000000018BBE80D4-0x000000018BBE8118
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018BBE8118-0x000000018BBE8120
	}

	public class UIRecycleMultiHolder : UIRecycleLayoutSimpleHolder<UIRecycleMultiHolder.MultiVirtualView>, IUIClearable // TypeDefIndex: 50183
	{
		// Fields
		private List<Config> _configs; // 0xA8
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onUpdateCell; // 0xB0
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onDetachCell; // 0xB8
		public Func<int, float> getCellDefaultSize; // 0xC0
		public Func<int, string> getCellPrefabKey; // 0xC8
		private Dictionary<string, GameObject> m_prefabMap; // 0xD0
	
		// Nested types
		public class MultiVirtualView : UIRecycleLayoutAdapter.VirtualView // TypeDefIndex: 50181
		{
			// Fields
			private UIRecycleMultiHolder m_closure; // 0x18
			public float preferSize; // 0x20
			public string prefabKey; // 0x28
	
			// Constructors
			public MultiVirtualView() {} // Dummy constructor
			public MultiVirtualView(float initSize, string key, UIRecycleMultiHolder closure) {} // 0x000000018BBF0588-0x000000018BBF0608
	
			// Methods
			public int GetIndex() => default; // 0x000000018BBF00D8-0x000000018BBF0164
			public override GameObject GetPrefab() => default; // 0x000000018BBF0608-0x000000018BBF07EC
			public override float GetPreferSize() => default; // 0x000000018BBF0164-0x000000018BBF0258
			protected override void OnViewDetached() {} // 0x000000018BBEFEF8-0x000000018BBEFFD8
			protected override void OnViewAttached() {} // 0x000000018BBF0258-0x000000018BBF0588
		}
	
		[Serializable]
		public class Config // TypeDefIndex: 50182
		{
			// Fields
			public string key; // 0x10
			public GameObject cellTemplate; // 0x18
	
			// Constructors
			public Config() {} // 0x000000018BBEFFD8-0x000000018BBF00D8
		}
	
		// Constructors
		public UIRecycleMultiHolder() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public MultiVirtualView GetVirtualView(int index) => default; // 0x000000018BBF07EC-0x000000018BBF095C
		public void UpdateCount(int newCount, bool setTop = false /* Metadata: 0x02061C41 */) {} // 0x000000018BBE8120-0x000000018BBE81EC
		public void UpdateCount(int newCount, int fastScrollToIndex) {} // 0x000000018BBE83F8-0x000000018BBE8428
		public void InsertView(int index, string key, float initSize) {} // 0x000000018BBE81EC-0x000000018BBE8270
		public void AddView(string key, float initSize) {} // 0x000000018BBE8270-0x000000018BBE82C0
		public override void OnAdapterInit() {} // 0x000000018BBE835C-0x000000018BBE83F8
		public void ClearComponent() {} // 0x000000018BBE82C0-0x000000018BBE835C
	}

	public class UIRecycleSingleHolder : UIRecycleLayoutSimpleHolder<UIRecycleSingleHolder.SimpleVirtualView>, IUIClearable // TypeDefIndex: 50185
	{
		// Fields
		private int m_count; // 0xA8
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onUpdateCell; // 0xB0
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onDetachCell; // 0xB8
		public Func<int, float> getCellDefaultSize; // 0xC0
		private GameObject _cellTemplate; // 0xC8
	
		// Nested types
		public class SimpleVirtualView : UIRecycleLayoutAdapter.VirtualView // TypeDefIndex: 50184
		{
			// Fields
			private UIRecycleSingleHolder m_holder; // 0x18
			public float preferSize; // 0x20
	
			// Constructors
			public SimpleVirtualView() {} // Dummy constructor
			public SimpleVirtualView(float initSize, UIRecycleSingleHolder holder) {} // 0x000000018BBF0CE4-0x000000018BBF0D64
	
			// Methods
			public int GetIndex() => default; // 0x000000018BBF0B14-0x000000018BBF0BA0
			public override GameObject GetPrefab() => default; // 0x000000018BBF0D64-0x000000018BBF0EF8
			public override float GetPreferSize() => default; // 0x000000018BBF0BA0-0x000000018BBF0C84
			protected override void OnViewDetached() {} // 0x000000018BBF095C-0x000000018BBF0A2C
			protected override void OnViewAttached() {} // 0x000000018BBF0C84-0x000000018BBF0CE4
		}
	
		// Constructors
		public UIRecycleSingleHolder() {} // 0x000000018BBE9200-0x000000018BBE92B8
	
		// Methods
		public SimpleVirtualView GetVirtualView(int index) => default; // 0x000000018BBF0A2C-0x000000018BBF0B14
		public void UpdateCount(int newCount, bool setTop = false /* Metadata: 0x02061C42 */) {} // 0x000000018BBF0EF8-0x000000018BBF0FC4
		public void UpdateCount(int newCount, int fastScrollToIndex = -1 /* Metadata: 0x02061C43 */) {} // 0x000000018BBE909C-0x000000018BBE9154
		public void InsertView(int index, string key, float initSize) {} // 0x000000018BBE9370-0x000000018BBE9390
		public void AddView(string key, float initSize) {} // 0x000000018BBE9154-0x000000018BBE91B0
		public override void OnAdapterInit() {} // 0x000000018BBE91B0-0x000000018BBE9200
		public void ClearComponent() {} // 0x000000018BBE92B8-0x000000018BBE9370
	}

	public class SimpleUITextSingleLine : UIText // TypeDefIndex: 50186
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
		public bool m_b; // 0xC78
		private Action<TMP_TextInfo> OnPreRenderText; // 0xC80
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText;
	
		// Constructors
		public SimpleUITextSingleLine() {} // 0x000000018BBE8F2C-0x000000018BBE8F7C
		static SimpleUITextSingleLine() {} // 0x000000018BBE8A3C-0x000000018BBE8F2C
	
		// Methods
		protected override void GenerateTextMesh() {} // 0x000000018BBDBF38-0x000000018BBE6CE4
		public void __iFixBaseProxy_GenerateTextMesh() {} // 0x000000018BBE8A34-0x000000018BBE8A3C
	}

	public class ToastList : MonoBehaviour, IUIClearable // TypeDefIndex: 50189
	{
		// Fields
		private GameObject _cellTemplate; // 0x18
		private float _showDuration; // 0x20
		private float _delay; // 0x24
		private int _maxShowingCount; // 0x28
		private bool _inAnimation_k__BackingField; // 0x2C
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
		public bool inAnimation { get; private set; } // 0x000000018BBE9CA4-0x000000018BBE9DAC 0x000000018BBE9BE8-0x000000018BBE9CA4
	
		// Nested types
		private class CellInfo // TypeDefIndex: 50187
		{
			// Fields
			public int index; // 0x10
			public GameObject obj; // 0x18
			public UIAnimationWrapper animationWrapper; // 0x20
			public Coroutine cor; // 0x28
	
			// Constructors
			public CellInfo() {} // 0x0000000185FB08C0-0x0000000185FB08D0
		}
	
		private sealed class __ShowCell_d__23 : IEnumerator<object> // TypeDefIndex: 50188
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public int delayIndex; // 0x20
			public CellInfo cell; // 0x28
			public ToastList __4__this; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BBE98BC-0x000000018BBE9A30 
			object IEnumerator.Current { get => default; } // 0x000000018BBE9390-0x000000018BBE94E4 
	
			// Constructors
			public __ShowCell_d__23() {} // Dummy constructor
			public __ShowCell_d__23(int __1__state) {} // 0x0000000185FB08D0-0x0000000185FB08E0
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BBE94E4-0x000000018BBE9544
			private bool MoveNext() => default; // 0x000000018BBE97A0-0x000000018BBE97F0
			void IEnumerator.Reset() {} // 0x000000018BBE97F0-0x000000018BBE98BC
		}
	
		// Constructors
		public ToastList() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		private void Awake() {} // 0x000000018BBE9DAC-0x000000018BBE9FA8
		private void OnDisable() {} // 0x000000018BBE9A30-0x000000018BBE9BE8
		private CellInfo _GetCell() => default; // 0x000000018BBE9544-0x000000018BBE970C
		private void _CacheCell(CellInfo cell) {} // 0x000000018BBE970C-0x000000018BBE97A0
		public void AddToast(int count, int startIndex = 0 /* Metadata: 0x02061C44 */) {} // 0x000000018BBE9FA8-0x000000018BBEA10C
		private void _StartBatch(int batchCount) {} // 0x0000000185492010-0x0000000185492020
		private IEnumerator _ShowCell(int delayIndex, CellInfo cell) => default; // 0x0000000181378230-0x0000000181378240
		private void _TryShowNewCell() {} // 0x0000000185492010-0x0000000185492020
		private void _OnCellFinished(CellInfo cell) {} // 0x000000018BBEA4C0-0x000000018BBEA714
		public void ClearAllToast() {} // 0x0000000181377E40-0x0000000181377E50
		public void ClearComponent() {} // 0x000000018BBEA714-0x000000018BBEA760
	}

	public class UI3DScrollList : UIScrollList // TypeDefIndex: 50190
	{
		// Constructors
		public UI3DScrollList() {} // 0x000000018BBEA820-0x000000018BBEA86C
	
		// Methods
		protected override void MoveCellTo(Cell cell, int index) {} // 0x000000018BBEA760-0x000000018BBEA818
		public void __iFixBaseProxy_MoveCellTo(Cell P0, int P1) {} // 0x000000018BBEA818-0x000000018BBEA820
	}

	public class UIActionKeyHint : MonoBehaviour, IUIClearable // TypeDefIndex: 50191
	{
		// Fields
		private static readonly UnityEngine.Color NORMAL_COLOR; // 0x00
		private static readonly UnityEngine.Color HIDE_COLOR; // 0x10
		private static readonly UnityEngine.Color DISABLED_COLOR; // 0x20
		private static List<UIActionKeyHint> s_keyHintCache; // 0x30
		private static bool s_inited; // 0x38
		public static bool s_stopCheckBindingEnabledForGuide; // 0x39
		private const string INVALID_KEY_STR = "none"; // Metadata: 0x02061C4D
		private IBindingView m_target; // 0x18
		public string actionId; // 0x20
		public Component btnTarget; // 0x28
		public BindingViewActionType bindingViewActionType; // 0x30
		private bool _useCustomText; // 0x34
		private bool _showSecondAction; // 0x35
		private bool _onlyShowOnLongPress; // 0x36
		private bool _adaptForceGrayState; // 0x37
		private Transform _content; // 0x38
		private CanvasGroup _contentCanvasGroup; // 0x40
		private UIImage _icon; // 0x48
		private UIImage _longPressIcon; // 0x50
		private RectTransform _pressHintNode; // 0x58
		private UIImage _pressHintProgressImg; // 0x60
		private UIText _text; // 0x68
		private UIImage _secondIcon; // 0x70
		private RectTransform _secondNode; // 0x78
		private UIImage _modifyIcon; // 0x80
		private GameObject _mutexGameObject; // 0x88
		private bool _changeScaleOnHide; // 0x90
		[NonSerialized]
		public int bindingId; // 0x94
		public Func<bool> checkVirtualMouseClickHintFunc; // 0x98
		private CanvasGroup _canvasGroup; // 0xA0
		public bool autoUpdate; // 0xA8
		private bool _hintHidden_k__BackingField; // 0xA9
		private int m_cachedBindingId; // 0xAC
		private bool m_isLongPressAction; // 0xB0
		private float m_lastPressStartTime; // 0xB4
		private const float LONG_PRESS_HINT_HIDE_TIME = 0.2f; // Metadata: 0x02061C52
		private const float LONG_PRESS_HINT_SHOW_MIN_VALUE = 0f; // Metadata: 0x02061C56
	
		// Properties
		private IBindingView target { get => default; } // 0x0000000183FCF940-0x0000000183FCF9E0 
		private bool showCanvasGroup { get => default; } // 0x000000018BBEB27C-0x000000018BBEB2D0 
		public bool hintHidden { get; private set; } // 0x0000000185FBC1B0-0x0000000185FBC1C0 0x0000000185FBC1D0-0x0000000185FBC1E0
	
		// Constructors
		public UIActionKeyHint() {} // 0x00000001845608A0-0x00000001845608D0
		static UIActionKeyHint() {} // 0x0000000185D9ABB0-0x0000000185D9ACC0
	
		// Methods
		private static void _TryInit() {} // 0x00000001849D2AE0-0x00000001849D4320
		private static void _RefreshAllKeyHints() {} // 0x000000018BBEAF84-0x000000018BBEB090
		private static void _OnInputLateTickAll() {} // 0x0000000183FCBF00-0x0000000183FCC120
		private static void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType) {} // 0x000000018BBEAE64-0x000000018BBEAEE0
		private void Awake() {} // 0x00000001849D2970-0x00000001849D2AE0
		private void OnEnable() {} // 0x0000000183FE5CA0-0x0000000183FE5E20
		private void OnDisable() {} // 0x0000000183FE5810-0x0000000183FE5AB0
		private void OnDestroy() {} // 0x0000000185B47DB0-0x0000000185B48C50
		private void Reset() {} // 0x000000018BBEA86C-0x000000018BBEA984
		private void _OnInputLateTick() {} // 0x000000018BBEAF5C-0x000000018BBEAF84
		public void UpdateKeyHint() {} // 0x0000000183FE5E20-0x0000000183FE6160
		public void SetActionId(string id, bool forceUpdate = false /* Metadata: 0x02061C45 */) {} // 0x000000018527B510-0x000000018527B570
		public void SetKeyHint(string actId, IBindingView hintTarget, bool forceUpdate = false /* Metadata: 0x02061C46 */) {} // 0x000000018527B570-0x000000018527B610
		public void SetBindingId(int bId, bool forceUpdate = false /* Metadata: 0x02061C47 */) {} // 0x000000018527B610-0x000000018527B6D0
		public void SetBindingId(int bId, string actId, IBindingView hintTarget, bool forceUpdate = false /* Metadata: 0x02061C48 */) {} // 0x000000018BBEA984-0x000000018BBEAA48
		private void _OnChangeTarget() {} // 0x000000018527B6D0-0x000000018527B740
		private void _OnInputActionKeyUpdated(in EventData<string> data) {} // 0x000000018BBEAEE0-0x000000018BBEAF5C
		public void SetSecondActionId(string id, bool isPrimary = false /* Metadata: 0x02061C49 */) {} // 0x0000000183FE6290-0x0000000183FE6350
		private void _SetSecondIcon(PlayerActionInfo actionInfo, bool isPrimary = false /* Metadata: 0x02061C4A */) {} // 0x0000000183FE6350-0x0000000183FE64C0
		private void _CheckInteractable(bool isInit) {} // 0x0000000183FCDD70-0x0000000183FCF940
		private bool _IsInputEnabled() => default; // 0x000000018427B5A0-0x000000018427BAF0
		private bool _IsInputGray() => default; // 0x000000018BBEAC14-0x000000018BBEAE64
		public string GetTextStr() => default; // 0x000000018527B840-0x000000018527BC90
		public void SetText(string text) {} // 0x000000018BBEAA48-0x000000018BBEAAB4
		public bool GetAndSetActionIcon(UIImage iconImage, PlayerActionInfo actionInfo, bool usingController, out bool isLongPressAction, bool isPrimary = true /* Metadata: 0x02061C4B */) {
			isLongPressAction = default;
			return default;
		} // 0x0000000183FE78C0-0x0000000183FE79E0
		public bool GetAndSetActionModifyIcon(PlayerActionInfo actionInfo, bool usingController, bool isPrimary = true /* Metadata: 0x02061C4C */) => default; // 0x0000000183FE5BC0-0x0000000183FE5CA0
		private bool _SetKeyCodeSprite(UIImage iconImage, string iconPath) => default; // 0x0000000183FE8B90-0x0000000183FE8CD0
		private void _CheckVirtualMouseClickHint() {} // 0x000000018BBEAAB4-0x000000018BBEAB64
		private void _UpdatePressHint() {} // 0x000000018BBEB090-0x000000018BBEB27C
		private void _GetLongPressInfo(out float startTime, out float longPressTime) {
			startTime = default;
			longPressTime = default;
		} // 0x000000018BBEAB64-0x000000018BBEAC14
		public string GetActionId() => default; // 0x000000018427B180-0x000000018427B2A0
		public PlayerActionInfo GetActionInfo() => default; // 0x0000000183FE61F0-0x0000000183FE6290
		public void ClearComponent() {} // 0x00000001849D4480-0x00000001849D50A0
		public void SetContentState(bool contentState) {} // 0x0000000183FE6160-0x0000000183FE61F0
	}

	public class UIAnimationHolder : MonoBehaviour, IAnimationClipSource // TypeDefIndex: 50193
	{
		// Fields
		private List<ClipHolder> _clips; // 0x18
	
		// Nested types
		[Serializable]
		private class ClipHolder // TypeDefIndex: 50192
		{
			// Fields
			public AnimationClip clip; // 0x10
			public string alias; // 0x18
	
			// Constructors
			public ClipHolder() {} // 0x000000018BBEB338-0x000000018BBEB3A0
		}
	
		// Constructors
		public UIAnimationHolder() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public AnimationClip FindByName(string name) => default; // 0x000000018BBEB2D0-0x000000018BBEB338
		public AnimationClip FindByNameOrAlias(string nameOrAlias) => default; // 0x000000018BBEB3F4-0x000000018BBEB608
		private AnimationClip _FindByString(string id, bool useAlias) => default; // 0x000000018BBEB3A0-0x000000018BBEB3F4
		public void GetAnimationClips(List<AnimationClip> results) {} // 0x0000000185ECB020-0x0000000185ECB0A0
	}

	public class UIAnimationLoopSynchronizer : MonoBehaviour // TypeDefIndex: 50194
	{
		// Fields
		public string syncLoopAnimKey; // 0x18
		private readonly List<UIAnimationWrapper> m_children; // 0x20
	
		// Constructors
		public UIAnimationLoopSynchronizer() {} // 0x0000000185ECAFA0-0x0000000185ECB020
	
		// Methods
		public void RegisterChild(UIAnimationWrapper child) {} // 0x000000018582C6A0-0x000000018582C740
		public void UnregisterChild(UIAnimationWrapper child) {} // 0x000000018BBEB608-0x000000018BBEB694
		public float GetLoopStartPosition() => default; // 0x000000018454A260-0x000000018454A320
	}

	public class UIAnimationWrapper : MonoBehaviour, IUIClearable // TypeDefIndex: 50202
	{
		// Fields
		private AnimationClip _animationIn; // 0x18
		private AnimationClip _animationInEasing; // 0x20
		private AnimationClip _animationLoop; // 0x28
		private AnimationClip _animationOut; // 0x30
		public bool autoPlay; // 0x38
		private bool _onlyOnce; // 0x39
		private bool _needSyncLoopAnim; // 0x3A
		private string _syncLoopAnimKey; // 0x40
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
		public DisposedUnityEvent onAnimationInEasingFinished; // 0x88
		private bool m_needNotifyAnimationInEasingFinished; // 0x90
		private float m_lastPlayAnimationInStartTime; // 0x94
		private bool m_started; // 0x98
		private CachedSampleClipInfo m_cachedSampleClipInfo; // 0xA0
		private bool m_needInformAnimationInEnd; // 0xB0
		private LuaPanel m_panel; // 0xB8
		private string _audioOnOpen; // 0xC0
		private string _audioOnClose; // 0xC8
	
		// Properties
		public AnimationClip animationIn { get => default; } // 0x0000000183EC26B0-0x0000000183EC2B20 
		public AnimationClip animationInEasing { get => default; } // 0x0000000183EC2B20-0x0000000183EC2F90 
		public AnimationClip animationLoop { get => default; } // 0x0000000183EC2F90-0x0000000183EC3400 
		public AnimationClip animationOut { get => default; } // 0x000000018BBEBCC8-0x000000018BBEBD40 
		public UIAnimationTween curTween { get => default; } // 0x000000018BBEBB1C-0x000000018BBEBBBC 
		public LuaPanel panel { get => default; } // 0x0000000185492010-0x0000000185492020 
	
		// Nested types
		private class AnimationRuntime // TypeDefIndex: 50195
		{
			// Fields
			public UIAnimationTween.Options option; // 0x10
			public UnityEngine.AnimationState state; // 0x18
			public bool isPlaying; // 0x20
	
			// Constructors
			public AnimationRuntime() {} // 0x00000001813B31A0-0x00000001813B31B0
	
			// Methods
			public float GetClipLength() => default; // 0x0000000181377E40-0x0000000181377E50
		}
	
		[Serializable]
		public struct FOptions : ILuaCallCSharp // TypeDefIndex: 50196
		{
			// Fields
			public Ease animEase; // 0x00
	
			// Methods
			public static FOptions GetDefault() => default; // 0x00000001813B8590-0x00000001813B85A0
		}
	
		private struct CachedSampleClipInfo // TypeDefIndex: 50197
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
			} // 0x00000001813B51D0-0x00000001813B51E0
		}
	
		private sealed class __c__DisplayClass37_0 // TypeDefIndex: 50198
		{
			// Fields
			public UIAnimationWrapper __4__this; // 0x10
			public TweenCallback callback; // 0x18
	
			// Constructors
			public __c__DisplayClass37_0() {} // 0x0000000185FA3D20-0x0000000185FA3D60
	
			// Methods
			internal void _PlayOutAnimation_b__0() {} // 0x0000000185FB0530-0x0000000185FB0540
		}
	
		private sealed class __c__DisplayClass46_0 // TypeDefIndex: 50199
		{
			// Fields
			public TweenCallback callback; // 0x10
			public UIAnimationWrapper __4__this; // 0x18
			public bool autoPlayLoop; // 0x20
	
			// Constructors
			public __c__DisplayClass46_0() {} // 0x00000001844A84C0-0x00000001844A8A70
	
			// Methods
			internal void _PlayInAnimation_b__0() {} // 0x000000018BBEBF5C-0x000000018BBEC17C
		}
	
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 50200
		{
			// Fields
			public UIAnimationWrapper __4__this; // 0x10
			public bool autoPlayLoop; // 0x18
	
			// Constructors
			public __c__DisplayClass53_0() {} // 0x000000018BBEBE84-0x000000018BBEBF5C
	
			// Methods
			internal void __OnInAnimationFinished_b__0() {} // 0x00000001844A7DB0-0x00000001844A8370
		}
	
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 50201
		{
			// Fields
			public UIAnimationWrapper __4__this; // 0x10
			public TweenCallback onComplete; // 0x18
			public UIAnimationTween animTween; // 0x20
	
			// Constructors
			public __c__DisplayClass74_0() {} // 0x000000018BBEBBBC-0x000000018BBEBC0C
	
			// Methods
			internal void _PlayWithTween_b__0() {} // 0x000000018454C5A0-0x000000018454C730
		}
	
		// Constructors
		public UIAnimationWrapper() {} // 0x0000000185492010-0x0000000185492020
		static UIAnimationWrapper() {} // 0x0000000183EBF430-0x0000000183EBF930
	
		// Methods
		public void SetOptions(FOptions options) {} // 0x000000018BBEB9DC-0x000000018BBEBA7C
		private void _InitAnimation() {} // 0x000000018BBEBA7C-0x000000018BBEBB1C
		private void _AnimationInLoopCheck() {} // 0x000000018454A320-0x000000018454A440
		private void _AnimationAutomaticallyCheck() {} // 0x000000018454B340-0x000000018454C3C0
		private void Awake() {} // 0x000000018BBEBD40-0x000000018BBEBE84
		public bool IsStarted() => default; // 0x00000001848F8C80-0x00000001848F8D40
		public void PlayOutAnimation(TweenCallback callback = null) {} // 0x00000001850AEE20-0x00000001850AEEF0
		public void SetAnimationInClip(string clipName) {} // 0x000000018BBEBC0C-0x000000018BBEBCC8
		public void SetAnimationInEasingClip(string clipName) {} // 0x00000001844A7310-0x00000001844A73E0
		public void SetAnimationLoopClip(string clipName) {} // 0x00000001845499B0-0x0000000184549BA0
		public void SetAnimationOutClip(string clipName) {} // 0x0000000184549BA0-0x000000018454A260
		public float GetInClipLength() => default; // 0x00000001844A8420-0x00000001844A84C0
		public float GetOutClipLength() => default; // 0x00000001844A77D0-0x00000001844A7880
		public float GetLoopClipLength() => default; // 0x00000001844A9410-0x00000001844A9810
		public void PlayLoopAnimation() {} // 0x00000001844A7750-0x00000001844A77D0
		public void PlayInAnimation(TweenCallback callback = null, bool autoPlayLoop = true /* Metadata: 0x02061C5A */) {} // 0x00000001844A8EC0-0x00000001844A9410
		public void SkipInAnimation() {} // 0x00000001844A9A10-0x00000001844A9BA0
		public void SampleToInAnimationBegin() {} // 0x000000018454B2B0-0x000000018454B2F0
		public void SampleToInAnimationEnd() {} // 0x00000001844A7880-0x00000001844A78F0
		public void SampleToOutAnimationBegin() {} // 0x000000018454A440-0x000000018454B2B0
		public void SampleToOutAnimationEnd() {} // 0x00000001844A8370-0x00000001844A8420
		private void _OnInAnimationFinished(bool autoPlayLoop = true /* Metadata: 0x02061C5B */) {} // 0x00000001854B7F80-0x00000001854B8060
		private void _OnInEasingAnimationFinished(bool autoPlayLoop) {} // 0x000000018BBEB910-0x000000018BBEB964
		public UnityEngine.AnimationState GetClip(string aniName) => default; // 0x0000000183EC22D0-0x0000000183EC26B0
		public float GetClipLength(string aniName) => default; // 0x0000000183EC1F00-0x0000000183EC22D0
		private void _SampleClipAtLength(AnimationRuntime runtime, float position) {} // 0x0000000183EBF930-0x0000000183EBFD10
		public void SampleClipAtPercent(string clipName, float percent, bool clearTween = true /* Metadata: 0x02061C5C */) {} // 0x0000000183EBFD10-0x0000000183EC1F00
		public void SampleClip(string clipName, float position, bool clearTween = true /* Metadata: 0x02061C5D */) {} // 0x000000018BBEB964-0x000000018BBEB9DC
		public void ClearTween(bool executeOnComplete = true /* Metadata: 0x02061C5E */) {} // 0x00000001844A7690-0x00000001844A7750
		private bool _CheckShouldAutoPlayAnimationIn() => default; // 0x0000000183EC3400-0x0000000183EC37B0
		private void Start() {} // 0x000000018454C3C0-0x000000018454C420
		private void OnEnable() {} // 0x000000018454C730-0x000000018454C790
		private void OnDisable() {} // 0x00000001844A9C20-0x00000001844AA2D0
		private void OnDestroy() {} // 0x0000000183EC37B0-0x0000000183EC3B80
		public bool CheckStopped() => default; // 0x0000000184561120-0x0000000184562670
		public void Play(AnimationClip animationClip, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x02061C5F */, float startPlayTime = 0f /* Metadata: 0x02061C60 */, bool clearTween = true /* Metadata: 0x02061C64 */) {} // 0x0000000185F3E8C0-0x0000000185F3E950
		public void Play(string stateName, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x02061C65 */, float startPlayTime = 0f /* Metadata: 0x02061C66 */, bool clearTween = true /* Metadata: 0x02061C6A */) {} // 0x00000001844AB050-0x00000001844AB120
		public void PlayWithTween(AnimationClip animationClip, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x02061C6B */, float startPlayTime = 0f /* Metadata: 0x02061C6C */, bool clearTween = true /* Metadata: 0x02061C70 */) {} // 0x0000000185492010-0x0000000185492020
		public void PlayWithTween(string stateName, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x02061C71 */, float startPlayTime = 0f /* Metadata: 0x02061C72 */, bool clearTween = true /* Metadata: 0x02061C76 */) {} // 0x0000000184562670-0x00000001845626A0
		public float GetCurPlayingTime() => default; // 0x000000018646F380-0x000000018646F3A0
		public void SetAudioOnOpen(string audioOnOpen) {} // 0x0000000183EBF380-0x0000000183EBF3C0
		public void PlayOpenAudio() {} // 0x0000000185492010-0x0000000185492020
		public void PlayCloseAudio() {} // 0x0000000183EBF3C0-0x0000000183EBF400
		public void ClearComponent() {} // 0x0000000185492010-0x0000000185492020
		private void _NotifyAnimationInEasingFinished() {} // 0x0000000183EBF400-0x0000000183EBF430
	}

	public class UIAnimationTween // TypeDefIndex: 50206
	{
		// Fields
		public static readonly Options DEFAULT_OPTION; // 0x00
		private DG.Tweening.Tween m_handler; // 0x10
		private float m_tweenValue; // 0x18
		private GameObject m_animTarget; // 0x20
		private float _clipLength_k__BackingField; // 0x28
	
		// Properties
		public DG.Tweening.Tween handler { get => default; } // 0x0000000185523CA0-0x0000000185523CD0 
		public float tweenValue { get => default; } // 0x00000001844A8CF0-0x00000001844A8EC0 
		public float clipLength { get; private set; } // 0x0000000185F8BB40-0x0000000185F8BB80 0x0000000185492010-0x0000000185492020
	
		// Nested types
		public struct Options // TypeDefIndex: 50203
		{
			// Fields
			public bool isInverse; // 0x00
			public float startPosition; // 0x04
		}
	
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 50204
		{
			// Fields
			public UIAnimationTween __4__this; // 0x10
			public UIAnimationWrapper wrapper; // 0x18
			public string name; // 0x20
	
			// Constructors
			public __c__DisplayClass14_0() {} // 0x000000018346D130-0x000000018346D140
	
			// Methods
			internal void _.ctor_b__0(float value) {} // 0x0000000181C9AC50-0x0000000181C9AC60
			internal void _.ctor_b__2(float value) {} // 0x0000000185FB0A50-0x0000000185FB0A60
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 50205
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static DOGetter<float> __9__14_1; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000185FB0A60-0x0000000185FB0A70
			public __c() {} // 0x000000018BBEB884-0x000000018BBEB910
	
			// Methods
			internal float _.ctor_b__14_1() => default; // 0x00000001844A7A10-0x00000001844A7DB0
		}
	
		// Constructors
		public UIAnimationTween() {} // Dummy constructor
		public UIAnimationTween(GameObject target, UIAnimationWrapper wrapper, string name) {} // 0x00000001844A8AD0-0x00000001844A8B10
		public UIAnimationTween(GameObject target, UIAnimationWrapper wrapper, string name, Options options) {} // 0x00000001844A8B10-0x00000001844A8CF0
		static UIAnimationTween() {} // 0x0000000183908D00-0x0000000183908D10
	
		// Methods
		public float GetValue() => default; // 0x0000000185F6F730-0x0000000185F6F790
		private void _SetValue(UIAnimationWrapper wrapper, string name, float value) {} // 0x0000000185492010-0x0000000185492020
	}

	public class UIAnimationSwitchTween : UISwitchTween // TypeDefIndex: 50209
	{
		// Fields
		private UIAnimationWrapper m_animWrapper; // 0x30
		private bool m_dontDisableGameObject; // 0x38
	
		// Nested types
		private class TweenHandler : UISwitchTween.ITweenHandler // TypeDefIndex: 50207
		{
			// Fields
			private UIAnimationSwitchTween m_closure; // 0x10
			private bool m_isIn; // 0x18
			private bool m_pendingClear; // 0x19
			private TweenCallback m_pendingCallback; // 0x20
			private bool m_isComplete; // 0x28
	
			// Constructors
			public TweenHandler() {} // Dummy constructor
			public TweenHandler(UIAnimationSwitchTween closure, bool isIn) {} // 0x00000001864721F0-0x0000000186472200
	
			// Methods
			public bool IsPlaying() => default; // 0x000000018BBEB744-0x000000018BBEB7D8
			public void KillIfNecessary() {} // 0x000000018BBEB7D8-0x000000018BBEB86C
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback) => default; // 0x000000018BBEB6EC-0x000000018BBEB744
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill) => default; // 0x000000018BBEB694-0x000000018BBEB6EC
			private void _OnComplete() {} // 0x0000000185D56780-0x0000000185D56840
		}
	
		public struct Builder // TypeDefIndex: 50208
		{
			// Fields
			public UIAnimationWrapper animWrapper; // 0x00
			public bool dontDisableGameObject; // 0x08
	
			// Methods
			public UIAnimationSwitchTween Build() => default; // 0x0000000185D56840-0x0000000185D568A0
		}
	
		// Constructors
		public UIAnimationSwitchTween() {} // Dummy constructor
		public UIAnimationSwitchTween(UIAnimationWrapper animWrapper) {} // 0x000000018BBEB874-0x000000018BBEB87C
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide() => default; // 0x000000018BBEB86C-0x000000018BBEB874
		protected override ITweenHandler GenerateTweenOfShow() => default; // 0x000000018BBEB87C-0x000000018BBEB884
		protected override void BeforeShowEffect() {} // 0x000000018BBEA3D0-0x000000018BBEA4C0
		protected override void AfterHideEffect() {} // 0x000000018BBEA10C-0x000000018BBEA1D4
		protected override void ResetToState(bool isShow) {} // 0x000000018BBEA1D4-0x000000018BBEA294
		private void _SetGameObjectActive(bool isActive) {} // 0x000000018BBEA294-0x000000018BBEA310
		public void __iFixBaseProxy_BeforeShowEffect() {} // 0x000000018BBEA310-0x000000018BBEA368
		public void __iFixBaseProxy_AfterHideEffect() {} // 0x000000018BBEA368-0x000000018BBEA3D0
		public void __iFixBaseProxy_ResetToState(bool P0) {} // 0x000000018BBE7FE4-0x000000018BBE8088
	}

	public class UIArea : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IUIClearable // TypeDefIndex: 50210
	{
		// Fields
		public UnityEvent<PointerEventData> onPointerEnter; // 0x18
		public UnityEvent<PointerEventData> onPointerExit; // 0x20
		private bool m_pointerInArea; // 0x28
		public GameObject _highlightNode; // 0x30
	
		// Properties
		public bool pointerInArea { get => default; } // 0x00000001813B31B0-0x00000001813B31C0 
	
		// Constructors
		public UIArea() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void _SetHighlightNodeActive(bool active) {} // 0x000000018BBEC430-0x000000018BBEC4E0
		public void OnPointerEnter(PointerEventData eventData) {} // 0x000000018BBEC2F8-0x000000018BBEC394
		public void OnPointerExit(PointerEventData eventData) {} // 0x000000018BBEC394-0x000000018BBEC430
		private void OnEnable() {} // 0x000000018BBEC2A0-0x000000018BBEC2F8
		private void OnDisable() {} // 0x000000018BBEC244-0x000000018BBEC2A0
		private void OnDestroy() {} // 0x000000018BBEC1E8-0x000000018BBEC244
		public void ClearComponent() {} // 0x000000018BBEC17C-0x000000018BBEC1E8
	}

	public class UIAutoCloseArea : TickableUIMono, IUIClearable, IBindingGroupTarget // TypeDefIndex: 50211
	{
		// Fields
		public static bool s_stopCheckShouldClose; // 0x00
		public List<RectTransform> fixedSafeAreas; // 0x68
		public RectTransform tmpSafeArea; // 0x70
		public bool alsoBlockKeyBoardInput; // 0x78
		private bool _includeInAutoCloseLayer; // 0x79
		private Camera m_fallbackUICamera; // 0x80
		public GameObject toggleObj; // 0x88
		[NonSerialized]
		public DisposedUnityEvent onTriggerAutoClose; // 0x90
		private string _closeActionId; // 0x98
		private bool _enableCloseActionOnController; // 0xA0
		private UIAnimationWrapper m_animationWrapper; // 0xA8
		private static LinkedList<GameObject> s_autoCloseLayerList; // 0x08
		private LuaPanel m_panel; // 0xB0
		private int _groupId_k__BackingField; // 0xB8
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0xC0
		private bool m_bindingInit; // 0xC8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
		public bool includeInAutoCloseLayer { get => default; set {} } // 0x0000000185FB2E50-0x0000000185FB2E60 0x000000018BBEC944-0x000000018BBEC9F4
		public LuaPanel panel { get => default; } // 0x0000000184CD29D0-0x0000000184CD2A90 
		public int groupId { get; private set; } // 0x0000000185FB9570-0x0000000185FB9580 0x0000000185FB9590-0x0000000185FB95A0
		public IBindingGroupTarget parentTarget { get; private set; } // 0x0000000181B388F0-0x0000000181B38900 0x0000000187A47C1C-0x0000000187A47C30
		public bool groupEnabled { get => default; } // 0x000000018BBEC8F0-0x000000018BBEC944 
	
		// Constructors
		public UIAutoCloseArea() {} // 0x0000000184DBE800-0x0000000184DBE900
		static UIAutoCloseArea() {} // 0x0000000185F3B7F0-0x0000000185F3B880
	
		// Methods
		private void Start() {} // 0x0000000185B54630-0x0000000185B546D0
		private void Reset() {} // 0x000000018BBEC6E4-0x000000018BBEC7A0
		public override void LateTick(float deltaTime) {} // 0x0000000184CD32A0-0x0000000184CD3350
		protected override void OnEnable() {} // 0x00000001857A5FC0-0x00000001857A6060
		protected override void OnDisable() {} // 0x00000001857A5E70-0x00000001857A5F20
		public void ChangeEnableCloseActionOnController(bool enabled) {} // 0x000000018BBEC4E0-0x000000018BBEC550
		public void CloseSelf() {} // 0x0000000184CD2A90-0x0000000184CD2B60
		public void TryCloseSelf() {} // 0x000000018BBEC7A0-0x000000018BBEC84C
		public void OpenSelf(bool executeOnComplete = true /* Metadata: 0x02061C77 */) {} // 0x000000018BBEC5F4-0x000000018BBEC6E4
		public bool ShouldClose() => default; // 0x0000000184CD4210-0x0000000184CD5060
		public void ClearComponent() {} // 0x0000000185FAD0F0-0x0000000185FAD5C0
		private void _AutoCloseToggleObjWhenOut() {} // 0x000000018BBEC84C-0x000000018BBEC8F0
		public static void AddToAutoCloseLayer(GameObject go) {} // 0x00000001857A6060-0x00000001857A6140
		public static void RemoveFromAutoCloseLayer(GameObject go) {} // 0x00000001857A5F20-0x00000001857A5FC0
		public static bool IsTopAutoCloseLayer(GameObject go) => default; // 0x0000000184CD27C0-0x0000000184CD2900
		private Camera _GetUICamera() => default; // 0x0000000184CD2900-0x0000000184CD29D0
		public void InitBinding() {} // 0x0000000185B546D0-0x0000000185B547A0
		private void _UpdateState() {} // 0x00000001857A6140-0x00000001857A6260
		protected override void OnDestroy() {} // 0x000000018BBEC550-0x000000018BBEC5F4
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000187AAA404-0x0000000187AAA40C
		public void __iFixBaseProxy_OnDestroy() {} // 0x00000001880AA28C-0x00000001880AA294
	}

	public class UIBigLogo : MonoBehaviour // TypeDefIndex: 50212
	{
		// Fields
		private GameObject _rootNode; // 0x18
		public UIImage _bigLogoImage; // 0x20
		private GameObject _stretchNode; // 0x28
		public UIImage _stretchImageTop; // 0x30
		public UIImage _stretchImageBottom; // 0x38
		public UIImage _bg; // 0x40
		public UIImage _originalImage; // 0x48
		public UIImage _backgroundMask; // 0x50
		public CanvasGroup _originalImageMain; // 0x58
		public RectTransform _fitImageMain; // 0x60
		public UIImage _fitImageTop; // 0x68
		public CanvasGroup _fitImageTopBg; // 0x70
		public UIImage _fitImageBottom; // 0x78
		public CanvasGroup _fitImageBottomBg; // 0x80
	
		// Constructors
		public UIBigLogo() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void SetBigLogoEditor(string bigLogoPath, bool useStretchImage, bool showOnTop, bool hideBackground, bool useOriginalImage, bool useFitImage) {} // 0x0000000183EC3B80-0x0000000183EC3F30
		public void ShowBigLogo(bool useStretchImage, bool showOnTop, bool useOriginalImage, bool useFitImage, float originalImageScale) {} // 0x0000000183EC3F30-0x0000000183EC4DA0
		public void SetBigLogoMask(UnityEngine.Color maskColor) {} // 0x000000018BBECECC-0x000000018BBECFE0
		public void ClearBigLogoMask() {} // 0x000000018BBEC9F4-0x000000018BBECAA4
		public void ClearBigLogo(bool showOnTop) {} // 0x000000018BBECAA4-0x000000018BBECC98
		public void SetAlpha(float alpha, bool showOnTop) {} // 0x000000018BBECC98-0x000000018BBECECC
		public void SetMaskAlpha(float alpha) {} // 0x000000018BBECFE0-0x000000018BBED0A8
	}

	public class UIBigRectButton : UIButton, IDragHandler, IBeginDragHandler, IEndDragHandler, UnityEngine.EventSystems.IScrollHandler // TypeDefIndex: 50213
	{
		// Fields
		private UIBigRectHelper _bigRectHelper; // 0x2D8
	
		// Constructors
		public UIBigRectButton() {} // 0x0000000184817400-0x0000000184817410
	
		// Methods
		private void _TryThroughEventDataToBigRectTouchPanelRaycast<T>(PointerEventData eventData, ExecuteEvents.EventFunction<T> eventFunction)
			where T : IEventSystemHandler {}
		public override void OnPointerDown(PointerEventData eventData) {} // 0x0000000185A742F0-0x0000000185A743F0
		public override void OnPointerUp(PointerEventData eventData) {} // 0x0000000185A741F0-0x0000000185A742F0
		public void OnDrag(PointerEventData eventData) {} // 0x000000018BBED14C-0x000000018BBED1F0
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BBED0A8-0x000000018BBED14C
		public void OnEndDrag(PointerEventData eventData) {} // 0x000000018BBED1F0-0x000000018BBED294
		public void OnScroll(PointerEventData eventData) {} // 0x000000018BBED294-0x000000018BBED338
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0) {} // 0x000000018BBED338-0x000000018BBED340
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0) {} // 0x000000018BBED340-0x000000018BBED348
	}

	public class UIBigRectHelper : TickableUIMono, IUIClearable // TypeDefIndex: 50216
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
		private UITouchPanel _touchPanel; // 0xD8
		private RectTransform _containerBigRectTransform; // 0xE0
		private RectTransform _nodes; // 0xE8
		private float _moveSpeed; // 0xF0
		private float _zoomSpeed; // 0xF4
		private float _zoomRangeMax; // 0xF8
		private bool _needResetPositionAndScale; // 0xFC
		private bool _needCenterZoomMobile; // 0xFD
		private List<float> _zoomThresholds; // 0x100
		private DisposedUnityEvent<int, bool> m_zoomEvent; // 0x108
		private float _zoomTweenTime; // 0x110
		private float _moveNodeXOffset; // 0x114
		private float _moveNodeYOffset; // 0x118
		private float _openZoomTweenTime; // 0x11C
		private AnimationCurve _openZoomCurve; // 0x120
		private float _focusNodeTime; // 0x128
		private AnimationCurve _focusNodeCurve; // 0x130
		private bool _containerEdgeAlignLeft; // 0x138
		private RectOffset _padding; // 0x140
		private float _paddingBottomIncludeControllerHintBar; // 0x148
		private float _controllerContainerHorizontalMoveSpeed; // 0x14C
		private float _controllerContainerVerticalMoveSpeed; // 0x150
		private float _controllerZoomRate; // 0x154
		private GameObject _controllerZoomKeyHint; // 0x158
		private bool _useFocusRect; // 0x160
		private bool _useClickKeyHint; // 0x161
		private Transform _raycastRoot; // 0x168
		private RectTransform _controllerFocusRect; // 0x170
		private float _controllerFocusRectHorizontalMoveSpeed; // 0x178
		private float _controllerFocusRectVerticalMoveSpeed; // 0x17C
		private float _controllerFocusLeftBoundPadding; // 0x180
		private float _controllerFocusRightBoundPadding; // 0x184
		private float _controllerFocusBottomBoundPadding; // 0x188
		private float _controllerFocusTopBoundPadding; // 0x18C
		private Vector2 m_lastStickValue; // 0x190
		private PointerEventData m_controllerFocusEventData; // 0x198
		private readonly List<RaycastResult> m_raycastResults; // 0x1A0
		private Selectable m_lastHitSelectable; // 0x1A8
		private int m_bindingGroupId; // 0x1B0
		private const string CLICK_ACTION_ID = "big_rect_click"; // Metadata: 0x02061C7E
		private const string CLICK_NO_HINT_ACTION_ID = "big_rect_click_no_hint"; // Metadata: 0x02061C8D
		private const float DELTA_TIME_TO_STICK_VALUE_RATIO = 100f; // Metadata: 0x02061CA4
		private int _clickBindingId_k__BackingField; // 0x1B4
		private bool _controllerMoveEnabled_k__BackingField; // 0x1B8
		private bool _controllerZoomEnabled_k__BackingField; // 0x1B9
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
		protected override TickType tickOption { get => default; } // 0x000000018BBEE468-0x000000018BBEE4B8 
		public DisposedUnityEvent OnOpenTweenFinished { get => default; } // 0x0000000185FB02F0-0x0000000185FB0300 
		private float zoomRangeMin { get => default; } // 0x0000000185C1BD50-0x0000000185C1BF20 
		public DisposedUnityEvent<int, bool> zoomEvent { get => default; } // 0x000000018515DFA0-0x000000018515DFF0 
		public UITouchPanel touchPanel { get => default; } // 0x00000001845E33F0-0x00000001845E3440 
		public int clickBindingId { get; private set; } // 0x0000000185FBBBD0-0x0000000185FBBBE0 0x0000000185FBF090-0x0000000185FBF0A0
		public bool controllerMoveEnabled { get; set; } // 0x0000000185FD6C30-0x0000000185FD6C40 0x0000000185C1BF20-0x0000000185C1C0C0
		public bool controllerZoomEnabled { get; set; } // 0x000000018515E300-0x000000018515E380 0x000000018515E160-0x000000018515E1E0
	
		// Nested types
		public sealed class BigRectRecoverState // TypeDefIndex: 50214
		{
			// Fields
			public Vector2 anchoredPosition; // 0x10
			public Vector2 anchorMin; // 0x18
			public Vector2 anchorMax; // 0x20
			public Vector2 pivot; // 0x28
			public Vector3 localScale; // 0x30
			public float zoomValue; // 0x3C
			public Vector2 anchoredPosOffset; // 0x40
			public float horizontalOffset; // 0x48
			public float verticalOffset; // 0x4C
	
			// Constructors
			public BigRectRecoverState() {} // 0x0000000185FB6A10-0x0000000185FB6A20
		}
	
		private sealed class __c__DisplayClass82_0 // TypeDefIndex: 50215
		{
			// Fields
			public TweenCallback onComplete; // 0x10
	
			// Constructors
			public __c__DisplayClass82_0() {} // 0x0000000181460F70-0x0000000181460F80
	
			// Methods
			internal void _FocusNode_b__0() {} // 0x00000001845E2B20-0x00000001845E2B40
		}
	
		// Constructors
		public UIBigRectHelper() {} // 0x0000000183EC7290-0x0000000183EC72B0
	
		// Methods
		protected override void OnAwake() {} // 0x0000000185FA66F0-0x0000000185FA6750
		public override void Tick(float deltaTime) {} // 0x00000001845E3650-0x00000001845E3700
		public override void LateTick(float deltaTime) {} // 0x000000018BBED74C-0x000000018BBED7C8
		protected override void OnRelease() {} // 0x000000018BBEE1E8-0x000000018BBEE290
		private void _OnDrag(Vector2 value) {} // 0x000000018BBEDA1C-0x000000018BBEDAA8
		public void ManuallyZoom(float value, bool needTween) {} // 0x00000001845E2750-0x00000001845E2890
		private void _RefreshPivotPosition() {} // 0x00000001845E2450-0x00000001845E25E0
		private void _OnZoom(float value, bool needTween) {} // 0x00000001845E3DB0-0x00000001845E3F20
		private void _SetZoomValueAndScale(float value, bool needTween) {} // 0x00000001845E3F20-0x00000001845E40F0
		private void _SetScale(bool needTween, float zoomTweenTime = 0f /* Metadata: 0x02061C78 */, AnimationCurve curve = null, TweenCallback onFinish = null) {} // 0x00000001845E3700-0x00000001845E3770
		private void _GetContainerRectBounds(out Vector2 leftBottom, out Vector2 rightTop) {
			leftBottom = default;
			rightTop = default;
		} // 0x000000018BBEDFE8-0x000000018BBEE1E8
		private Vector2 _GetAdjustedPosition(Vector2 position) => default; // 0x0000000184D82420-0x0000000184D82770
		private void _PosAdjust() {} // 0x00000001845E2640-0x00000001845E2750
		private void _RefreshPivotPositionToMousePosition() {} // 0x000000018BBEE290-0x000000018BBEE468
		private void _RefreshPivotPosition(Vector3 targetScreenPosition) {} // 0x00000001845E2890-0x00000001845E2B20
		private void _UpdatePositionOffsetAfterZoomed() {} // 0x000000018BBED4D0-0x000000018BBED680
		private void _TryAlignWhenInit() {} // 0x00000001845E3900-0x00000001845E3CD0
		public void Init() {} // 0x000000018BBED7C8-0x000000018BBED850
		public void FocusNode(float nodeX, float nodeY, TweenCallback onComplete) {} // 0x000000018BBED348-0x000000018BBED3BC
		public void FocusNode(RectTransform nodeRect, bool needTween = true /* Metadata: 0x02061C7C */, TweenCallback onComplete = null) {} // 0x0000000185FAE8A0-0x0000000185FAE8E0
		public void ZoomToFullRect(TweenCallback onComplete = null) {} // 0x0000000185FAE510-0x0000000185FAE550
		public void ChangePaddingRight(int right) {} // 0x00000001845E25E0-0x00000001845E2640
		public void SetZoomRangeMax(float maxValue) {} // 0x0000000183EC4DA0-0x0000000183EC5650
		public void OverrideZoomRangeMin(float minValue) {} // 0x000000018BBED6D0-0x000000018BBED74C
		public void SyncZoomValue(float zoomValue, bool needTween = true /* Metadata: 0x02061C7D */) {} // 0x000000018BBED680-0x000000018BBED6D0
		public BigRectRecoverState GetRecoverState() => default; // 0x000000018BBED3BC-0x000000018BBED4D0
		public void GetZoomRange(out float rangeMin, out float rangeMax) {
			rangeMin = default;
			rangeMax = default;
		} // 0x0000000184D82390-0x0000000184D82420
		public float GetCurrentZoomValue() => default; // 0x0000000183EC5650-0x0000000183EC5CD0
		public void ChangePivotPositionToTarget(RectTransform target) {} // 0x0000000185EB6C20-0x0000000185EB6D00
		public void ResetPivotPositionToScreenCenter() {} // 0x0000000185EB6D00-0x0000000185EB6D80
		public void RecoverContainerState(BigRectRecoverState state) {} // 0x0000000185FD6C10-0x0000000185FD6C20
		public void ClearComponent() {} // 0x0000000185FD6C20-0x0000000185FD6C30
		public void ClearAllTween() {} // 0x0000000185FBA3B0-0x0000000185FBA3C0
		private void _InitControllerBindings() {} // 0x00000001845E3510-0x00000001845E3650
		private bool _GetIsControllerMoveEnabled() => default; // 0x000000018515DFF0-0x000000018515E050
		private bool _GetIsControllerZoomEnabled() => default; // 0x000000018515E1E0-0x000000018515E300
		private void _ResetControllerState() {} // 0x000000018BBEDAA8-0x000000018BBEDFE8
		private void _TickRefreshController(float deltaTime) {} // 0x00000001845E3440-0x00000001845E3510
		private void _TickRefreshControllerStickMove(float deltaTime) {} // 0x000000018BBED850-0x000000018BBEDA1C
		private void _RefreshControllerFocusRaycastResults(bool ignoreTouchPanel, out Selectable hitSelectable, out UITouchPanel hitTouchPanel) {
			hitSelectable = default;
			hitTouchPanel = default;
		} // 0x000000018515E050-0x000000018515E0B0
		private void _TickCheckControllerFocusRaycastTargets() {} // 0x000000018515E0B0-0x000000018515E160
		private void _OnControllerClick() {} // 0x00000001857EEE60-0x00000001857EF140
		private void _TickRefreshControllerStickZoom(float deltaTime) {} // 0x0000000183EC6660-0x0000000183EC6C80
		private void _TickRefreshControllerZoomKeyHint() {} // 0x0000000183EC6C80-0x0000000183EC7290
		private void _OnAwake_b__63_0(PointerEventData eventData) {} // 0x0000000183EC5CD0-0x0000000183EC6660
		private void _OnAwake_b__63_1(float zoomValue) {} // 0x0000000187AB03B8-0x0000000187AB03C0
		private void __SetScale_b__72_0() {} // 0x000000018311B6C0-0x000000018311B6D0
		private void _Init_b__80_0() {} // 0x0000000187A742A0-0x0000000187A742A8
		public void __iFixBaseProxy_OnAwake() {} // 0x000000018792FE0C-0x000000018792FE14
		public void __iFixBaseProxy_Tick(float P0) {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnRelease() {} // 0x0000000183EC72B0-0x0000000183EC72C0
	}

	public class UIBlendImage : UIImage // TypeDefIndex: 50217
	{
		// Fields
		private static Dictionary<string, Material> s_materials; // 0x00
		private Material m_originalMaterial; // 0x228
		private bool m_initialized; // 0x230
	
		// Constructors
		public UIBlendImage() {} // 0x000000018BBF2EB4-0x000000018BBF2EBC
		static UIBlendImage() {} // 0x0000000185F3E830-0x0000000185F3E8C0
	
		// Methods
		public void SetMaterialKey(string key) {} // 0x000000018BBF2B98-0x000000018BBF2E28
		public void SetColor(string materialId, UnityEngine.Color c) {} // 0x000000018BBF2AF4-0x000000018BBF2B98
		public void SetTexture(string materialId, Texture t) {} // 0x000000018BBF2E28-0x000000018BBF2EB4
		public static void ClearMaterialCache() {} // 0x0000000185F3B760-0x0000000185F3B7F0
	}

	public class UIBlurMono : TickableUIMono // TypeDefIndex: 50218
	{
		// Fields
		private Canvas m_canvas; // 0x68
		private LuaPanel m_panel; // 0x70
		private int m_sortingOrder; // 0x78
		private HGCamera m_camera; // 0x80
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
		public Canvas canvas { get => default; } // 0x0000000184CD19C0-0x0000000184CD1A70 
		private LuaPanel panel { get => default; } // 0x0000000184CD18A0-0x0000000184CD19C0 
	
		// Constructors
		public UIBlurMono() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		protected override void OnEnable() {} // 0x0000000184CD17A0-0x0000000184CD18A0
		protected override void OnDisable() {} // 0x0000000184CD15D0-0x0000000184CD1630
		public override void Tick(float deltaTime) {} // 0x000000018BBF2EBC-0x000000018BBF2FC8
		public void UpdateSortingOrder(int order) {} // 0x000000018BBF2FC8-0x000000018BBF3054
		private HGCamera _GetCamera() => default; // 0x0000000184CD1630-0x0000000184CD17A0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000187AAA404-0x0000000187AAA40C
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UIBlurRT : MonoBehaviour // TypeDefIndex: 50219
	{
		// Fields
		private RawImage _rawImage; // 0x18
		private bool _autoUpdate; // 0x20
		private RTExtractionType _rtExtractionType; // 0x24
		private RTExtractionDuration _rtExtractionDuration; // 0x28
		private RTHandle m_rtHandle; // 0x30
		private bool _needUseSceneColorPS; // 0x38
		private RTHandle m_useSceneColorPsRtHandle; // 0x40
		private bool m_curIsUseSceneColorPS; // 0x48
		private Texture _customBlurTexture_k__BackingField; // 0x50
	
		// Properties
		public RawImage rawImage { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public Texture customBlurTexture { get; private set; } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
	
		// Constructors
		public UIBlurRT() {} // 0x0000000185F7E230-0x0000000185F7E250
	
		// Methods
		private void Reset() {} // 0x000000018BBF30A4-0x000000018BBF3124
		public void InitRT() {} // 0x00000001852C9350-0x00000001852C9650
		public void Register() {} // 0x00000001852C96F0-0x00000001852CA650
		public void UnRegister() {} // 0x000000018BBF324C-0x000000018BBF332C
		public void UpdateRT() {} // 0x000000018BBF332C-0x000000018BBF3400
		private void OnEnable() {} // 0x00000001852C9180-0x00000001852C91D0
		private void OnDisable() {} // 0x00000001852C8050-0x00000001852C8090
		private void OnDestroy() {} // 0x000000018BBF3054-0x000000018BBF30A4
		private void _Clear() {} // 0x00000001852C8D10-0x00000001852C8E40
		public void SetUseSceneColorPS(bool useSceneColorPS, bool forceUpdate = false /* Metadata: 0x02061CA8 */) {} // 0x0000000183EC72C0-0x0000000183EC81E0
		public void SetCustomBlurImg(Texture texture) {} // 0x000000018BBF3124-0x000000018BBF324C
		private void _Register_b__12_0() {} // 0x0000000185F5A880-0x0000000185F5A8B0
	}

	public class UIButton : Selectable, IPointerClickHandler, IBindingGroupTarget, IBindingView, IUIClearable // TypeDefIndex: 50222
	{
		// Fields
		private string _audioPressStart; // 0x180
		private string _audioOnClick; // 0x188
		private string _audioRelease; // 0x190
		private string _audioLongPress; // 0x198
		private string _audioInvalid; // 0x1A0
		private bool _noAudioWhenAutoTriggerOnClick; // 0x1A8
		private const float MIN_DRAG_DIST = 10f; // Metadata: 0x02061CAA
		private const float DOUBLE_CLICK_MAX_INTERVAL = 0.3f; // Metadata: 0x02061CAE
		public UIEvent<PointerEventData> onClick; // 0x1B0
		public UIEvent<PointerEventData> onDoubleClick; // 0x1B8
		public bool _ignoreClickOnDrag; // 0x1C0
		public bool _clickThrough; // 0x1C1
		private float _clickCd; // 0x1C4
		private LangKey _invalidClickLangKey; // 0x1C8
		private float m_lastValidClickTime; // 0x1D8
		private float m_lastClickTime; // 0x1DC
		private bool _useClickAnimation; // 0x1E0
		private AnimationCurve _clickAnimationCurve; // 0x1E8
		private float _clickAnimationDuration; // 0x1F0
		private Vector3 m_oriScale; // 0x1F4
		private Coroutine m_clickCor; // 0x200
		private bool m_scaled; // 0x208
		public UIEvent<PointerEventData> onLongPress; // 0x210
		public UIEvent<PointerEventData> onPressStart; // 0x218
		public UIEvent<PointerEventData> onPressEnd; // 0x220
		private float _longPressTime; // 0x228
		public bool _ignoreClickOnLongPress; // 0x22C
		public UIImage longPressImg; // 0x230
		private float _longPressImgShowDelay; // 0x238
		private float _longPressMaxDragDist; // 0x23C
		private bool _forceEnableButtonPressAudio; // 0x240
		private bool m_pressDownWaitClick; // 0x241
		private Vector2 _startPressPos_k__BackingField; // 0x244
		private int _pressTouchId_k__BackingField; // 0x24C
		private Coroutine m_longPressCor; // 0x250
		private bool m_triggeredLongPress; // 0x258
		public bool noTextBtn; // 0x259
		private UIText m_autoFindLabel; // 0x260
		private UIText _label; // 0x268
		private int m_groupId; // 0x270
		private bool m_bindingInit; // 0x274
		private InputBindingGroupMonoTarget _parent_k__BackingField; // 0x278
		private string m_customBindingViewLabelText; // 0x280
		public string hintTextId; // 0x288
		private readonly DisposedUnityEvent _bindingViewUpdateEvent_k__BackingField; // 0x290
		private RectTransform _redDotTrans; // 0x298
		private string _audioGamePadLongPress; // 0x2A0
		private LuaPanel m_panel; // 0x2A8
		private int m_hoverBindingGroupId; // 0x2B0
		[NonSerialized]
		public string clickHintTextId; // 0x2B8
		[NonSerialized]
		public string longPressHintTextId; // 0x2C0
		private ActionOnSetNaviTarget _actionOnSetNaviTarget; // 0x2C8
		private bool _useNoHintAction; // 0x2CC
		private int _hoverConfirmBindingId_k__BackingField; // 0x2D0
	
		// Properties
		public Vector2 startPressPos { get; private set; } // 0x000000018BBF3A54-0x000000018BBF3B2C 0x00000001859922A0-0x00000001859923E0
		public int pressTouchId { get; private set; } // 0x00000001849D5A60-0x00000001849D5B60 0x0000000185391EC0-0x0000000185391F30
		public float longPressTime { get => default; } // 0x0000000183FB1700-0x0000000183FB1720 
		public Vector2 curPressPos { get => default; } // 0x0000000185FB8480-0x0000000185FB8490 
		public bool triggeredLongPress { get => default; } // 0x0000000185FB8480-0x0000000185FB8490 
		public string text { get => default; set {} } // 0x0000000185FB8460-0x0000000185FB8470 0x00000001852E1170-0x00000001852E1250
		public UIText label { get => default; } // 0x0000000185ECA8A0-0x0000000185ECA960 
		public bool groupEnabled { get => default; } // 0x000000018579B0B0-0x000000018579B190 
		public int groupId { get => default; } // 0x0000000185FB8560-0x0000000185FB8570 
		public IBindingGroupTarget parentTarget { get => default; } // 0x0000000185FB8880-0x0000000185FB8890 
		public InputBindingGroupMonoTarget parent { get; private set; } // 0x000000018BBF39F4-0x000000018BBF39FC 0x0000000183FCFA90-0x0000000183FD0230
		public string bindingViewActionId { get => default; } // 0x00000001855917F0-0x0000000185591880 
		public string customBindingViewLabelText { get => default; set {} } // 0x00000001852E1250-0x00000001852E12C0 0x0000000184FC0760-0x0000000184FC0820
		public string bindingViewLabelText { get => default; } // 0x0000000184330960-0x0000000184330980 
		public string hintText { get => default; } // 0x0000000184330560-0x0000000184330830 
		public DisposedUnityEvent bindingViewUpdateEvent { get; } // 0x000000018BBF350C-0x000000018BBF359C 
		public RectTransform redDotTrans { get => default; } // 0x000000018BBF359C-0x000000018BBF362C 
		public bool bindingEnabled { get => default; } // 0x0000000185FD6C40-0x0000000185FD6C50 
		public BindingViewState bindingViewState { get => default; } // 0x000000018BBF37D0-0x000000018BBF395C 
		public LuaPanel panel { get => default; } // 0x0000000184817410-0x0000000184817680 
		public int hoverBindingGroupId { get => default; } // 0x000000018BBF3400-0x000000018BBF3450 
		public ActionOnSetNaviTarget actionOnSetNaviTarget { get => default; } // 0x0000000184FBF8F0-0x0000000184FBF900 
		public int hoverConfirmBindingId { get; private set; } // 0x000000018BBF36F4-0x000000018BBF3740 0x000000018BBF36D4-0x000000018BBF36DC
		bool IBindingView.interactable { get => default; } // 0x000000018BBD59E8-0x000000018BBD59F0 
	
		// Nested types
		private sealed class __DoClickAnimation_d__30 : IEnumerator<object> // TypeDefIndex: 50220
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIButton __4__this; // 0x20
			private float _currentTime_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x00000001849D5810-0x00000001849D5900 
			object IEnumerator.Current { get => default; } // 0x0000000184FBF900-0x0000000184FC0480 
	
			// Constructors
			public __DoClickAnimation_d__30() {} // Dummy constructor
			public __DoClickAnimation_d__30(int __1__state) {} // 0x000000018422C4F0-0x000000018422C540
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000183FB1160-0x0000000183FB1200
			private bool MoveNext() => default; // 0x0000000183FB1030-0x0000000183FB10A0
			void IEnumerator.Reset() {} // 0x000000018422D550-0x000000018422DBD0
		}
	
		private sealed class __OnPress_d__59 : IEnumerator<object> // TypeDefIndex: 50221
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIButton __4__this; // 0x20
			public PointerEventData eventData; // 0x28
			private float _finishTime_5__2; // 0x30
			private Vector2 _pressPos_5__3; // 0x34
			private float __longPressMaxDragDistSq_5__4; // 0x3C
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FD6C70-0x0000000185FD6C90 
			object IEnumerator.Current { get => default; } // 0x0000000185FD6C60-0x0000000185FD6C70 
	
			// Constructors
			public __OnPress_d__59() {} // Dummy constructor
			public __OnPress_d__59(int __1__state) {} // 0x0000000184FC0480-0x0000000184FC0760
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184FC1510-0x0000000184FC1550
			private bool MoveNext() => default; // 0x000000018BBF3740-0x000000018BBF37D0
			void IEnumerator.Reset() {} // 0x0000000185FD6CB0-0x0000000185FD6CC0
		}
	
		// Constructors
		public UIButton() {} // 0x00000001856CD2A0-0x00000001856CD2B0
	
		// Methods
		protected override void Awake() {} // 0x0000000185FD6CA0-0x0000000185FD6CB0
		protected override void OnEnable() {} // 0x0000000185FD6C50-0x0000000185FD6C60
		protected override void OnDisable() {} // 0x000000018BBF39FC-0x000000018BBF3A54
		protected override void OnDestroy() {} // 0x0000000185FBAAC0-0x0000000185FBAAD0
		protected override void _NotifyIsHover(bool isHover) {} // 0x0000000184FC1240-0x0000000184FC1480
		public virtual void OnPointerClick(PointerEventData eventData) {} // 0x0000000184FC1150-0x0000000184FC1240
		private void _Press(PointerEventData eventData = null) {} // 0x0000000184FC1480-0x0000000184FC1510
		private void _PlayClickAnimation(bool reverse = false /* Metadata: 0x02061CA9 */) {} // 0x0000000183FB10A0-0x0000000183FB1160
		private IEnumerator _DoClickAnimation() => default; // 0x0000000185992190-0x00000001859922A0
		public override void OnPointerDown(PointerEventData eventData) {} // 0x0000000187A47564-0x0000000187A47578
		public override void OnPointerUp(PointerEventData eventData) {} // 0x0000000183FB17E0-0x0000000183FB1D30
		private IEnumerator _OnPress(PointerEventData eventData) => default; // 0x0000000185F4C710-0x0000000185F4C750
		private void _StopLongPressCor() {} // 0x0000000183FB14F0-0x0000000183FB1670
		public void ClearComponent() {} // 0x0000000186473900-0x0000000186473908
		public void InitBinding() {} // 0x00000001852E10F0-0x00000001852E1170
		public override void OnInteractableChanged() {} // 0x0000000185BBE490-0x0000000185BBE620
		private void _UpdateState() {} // 0x0000000185B35040-0x0000000185B35150
		public string GetBindingViewActionId(BindingViewActionType actionType) => default; // 0x0000000184E094D0-0x0000000184E094E0
		void IBindingView.OnInputKeyDown(bool isActionTrigger) {} // 0x0000000185FD6C90-0x0000000185FD6CA0
		void IBindingView.OnInputKeyUp(bool isActionTrigger) {} // 0x000000018422DDB0-0x000000018422DF00
		private void _OnUpdateKey() {} // 0x000000018BBF395C-0x000000018BBF39F4
		private string _GetUIButtonKeyHintActionId(UIEvent<PointerEventData> buttonEvent) => default; // 0x000000018BBF3450-0x000000018BBF350C
		protected override void _RefreshHoverEnableNode(bool active) {} // 0x0000000185FA8800-0x0000000185FA8960
		public override bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId) {
			clickHintTextId = default;
			longPressHintTextId = default;
			return default;
		} // 0x000000018BBF362C-0x000000018BBF3678
		public override void OnNaviTargetEnabledAgain() {} // 0x000000018BBF3678-0x000000018BBF36C4
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode) {} // 0x0000000184FC1620-0x0000000184FC1630
		private void _InitActionOnSetNaviTarget() {} // 0x000000018BBF36DC-0x000000018BBF36E4
		private void _ToggleNaviInputBinding(bool active) {} // 0x000000018BBD59E0-0x000000018BBD59E8
		public void ChangeActionOnSetNaviTarget(ActionOnSetNaviTarget action) {} // 0x000000018BBD59F0-0x000000018BBD59F8
		private void _InitBinding_b__82_0() {} // 0x000000018BBF36E4-0x000000018BBF36EC
		private void _InitBinding_b__82_1() {} // 0x0000000185492010-0x0000000185492020
		private void _InitBinding_b__82_2() {} // 0x000000018BBF36EC-0x000000018BBF36F4
		private void _InitBinding_b__82_3() {} // 0x000000018BBF36C4-0x000000018BBF36CC
		private void _InitBinding_b__82_4() {} // 0x000000018BBF36CC-0x000000018BBF36D4
		private void __InitActionOnSetNaviTarget_b__132_0() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0) {} // 0x0000000181378230-0x0000000181378240
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0) {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_Awake() {} // 0x000000018BBF291C-0x000000018BBF2A5C
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000181377E40-0x0000000181377E50
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018BBF2A5C-0x000000018BBF2AA8
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000181377E40-0x0000000181377E50
		public void __iFixBaseProxy__NotifyIsHover(bool P0) {} // 0x0000000181378230-0x0000000181378240
		public void __iFixBaseProxy_OnInteractableChanged() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy__RefreshHoverEnableNode(bool P0) {} // 0x0000000184FC3260-0x0000000184FC3530
		public bool __iFixBaseProxy_GetMouseActionHints(out string P0, out string P1) {
			P0 = default;
			P1 = default;
			return default;
		} // 0x0000000181377E40-0x0000000181377E50
		public void __iFixBaseProxy_OnNaviTargetEnabledAgain() {} // 0x000000018BBF2AA8-0x000000018BBF2AF4
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public enum CanvasMatchMode // TypeDefIndex: 50223
	{
		Width = 0,
		Height = 1
	}

	public class UICanvasScaleHelper : MonoBehaviour, DeviceInfoManager.IScreenSizeListener, IUIClearable // TypeDefIndex: 50226
	{
		// Fields
		private bool _useCustomStandardResolution; // 0x18
		private Vector2 _customStandardResolution; // 0x1C
		private float _customPCReferenceResolutionScale; // 0x24
		private HashSet<Canvas> m_canvasList; // 0x28
		private HashSet<CanvasScaler> m_canvasScalerList; // 0x30
		private bool m_isCanvasChanged; // 0x38
		public bool isSingleCanvas; // 0x39
		public Camera uiCamera; // 0x40
		public DisposedUnityEvent onScreenSizeChanged; // 0x48
		public DisposedUnityEvent onCanvasChanged; // 0x50
	
		// Properties
		public float standardHorizontalResolution { get => default; } // 0x00000001845E5FD0-0x00000001845E6010 
		public float standardVerticalResolution { get => default; } // 0x00000001845E5F90-0x00000001845E5FD0 
		public float standardResolutionScale { get => default; } // 0x00000001845E6010-0x00000001845E6070 
		public HashSet<CanvasScaler> canvasScalerList { get => default; } // 0x000000018BBF3D3C-0x000000018BBF3D8C 
	
		// Nested types
		public struct FWorldCanvasParams // TypeDefIndex: 50224
		{
			// Fields
			public float screenRatio; // 0x00
			public Vector2 screenSize; // 0x04
			public Vector2 uiRootSize; // 0x0C
			public Vector3 uiRootScale; // 0x14
		}
	
		public struct FScreenCanvasParams // TypeDefIndex: 50225
		{
			// Fields
			public float screenRatio; // 0x00
			public Vector2 screenSize; // 0x04
			public CanvasMatchMode matchMode; // 0x0C
			public float matchWidthOrHeight; // 0x10
		}
	
		// Constructors
		public UICanvasScaleHelper() {} // 0x0000000184815E50-0x0000000184815FB0
	
		// Methods
		private void Awake() {} // 0x00000001845E4330-0x00000001845E4370
		private void _OnInit() {} // 0x00000001845E4370-0x00000001845E4470
		private void Start() {} // 0x00000001845A3CE0-0x00000001845A3E60
		private void OnDestroy() {} // 0x00000001845A3470-0x00000001845A35F0
		public void UpdateCanvas() {} // 0x00000001845E47C0-0x00000001845E4F70
		public void OnScreenSizeChanged(int width, int height) {} // 0x00000001845A3BD0-0x00000001845A3C30
		public void AddCanvas(Canvas c, CanvasScaler s) {} // 0x00000001845E5E10-0x00000001845E5F20
		public void RemoveCanvas(Canvas c, CanvasScaler s) {} // 0x0000000185B402C0-0x0000000185B40360
		private void _OnInputTypeChanged() {} // 0x000000018BBF3B88-0x000000018BBF3D3C
		private void _CanvasOnWillRenderCanvases() {} // 0x0000000184F1D170-0x0000000184F1D440
		public static FWorldCanvasParams CalcWorldCanvasParams(Camera camera, Transform uiRoot, bool useLocalPos = false /* Metadata: 0x02061CB4 */) => default; // 0x00000001845E4560-0x00000001845E4770
		public static FScreenCanvasParams CalcScreenCanvasParams() => default; // 0x00000001845E5CE0-0x00000001845E5DB0
		public static float CalcCurrentScreenRatio(out Vector2 screenSize) {
			screenSize = default;
			return default;
		} // 0x00000001845E5DB0-0x00000001845E5E10
		public Vector2 GetProperCanvasResolution() => default; // 0x00000001845E5F20-0x00000001845E5F90
		public void ForceCanvasUpdate() {} // 0x000000018BBF3B2C-0x000000018BBF3B88
		public void ClearComponent() {} // 0x00000001845A31B0-0x00000001845A3200
	}

	public class UIColorGroup : NonDrawingGraphic // TypeDefIndex: 50230
	{
		// Fields
		private Graphic[] _colorElements; // 0xB8
		private UnityEngine.Color _color; // 0xC0
		private bool m_isOperating; // 0xD0
		private List<DynEle> m_dynList; // 0xD8
	
		// Properties
		public override UnityEngine.Color color { get => default; set {} } // 0x000000018BBF4308-0x000000018BBF4424 0x000000018BBF4424-0x000000018BBF4564
	
		// Nested types
		private struct CommonParams // TypeDefIndex: 50227
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
	
		private delegate void GraphicOpt(Graphic graphic, CommonParams param); // TypeDefIndex: 50228; 0x000000018BBF480C-0x000000018BBF4914
	
		private struct DynEle // TypeDefIndex: 50229
		{
			// Fields
			public string groupId; // 0x00
			public Graphic graphic; // 0x08
			public bool useStaticColor; // 0x10
		}
	
		// Constructors
		public UIColorGroup() {} // 0x000000018BBF4574-0x000000018BBF45A4
	
		// Methods
		public void AttachGraphic(Graphic graphic, bool useStaticColor = true /* Metadata: 0x02061CB5 */) {} // 0x00000001857F0A10-0x00000001857F0B10
		public void AttachGraphicsWithGroup(List<Graphic> graphic, string groupId) {} // 0x00000001857F0BA0-0x00000001857F0DF0
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) {} // 0x000000018BBF4600-0x000000018BBF4694
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) {} // 0x000000018BBF4694-0x000000018BBF4770
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) {} // 0x0000000185A65CA0-0x0000000185A65D30
		private void _ApplyOptToGraphics(GraphicOpt opt, CommonParams param) {} // 0x000000018BBF4770-0x000000018BBF480C
		private static void _CrossFadeAlpha(Graphic graphic, CommonParams param) {} // 0x0000000184B37DB0-0x0000000184B37DD0
		private static void _CrossFadeColorRGB(Graphic graphic, CommonParams param) {} // 0x000000018BBF45E0-0x000000018BBF4600
		private static void _CrossFadeColorAlpha(Graphic graphic, CommonParams param) {} // 0x000000018BBF4564-0x000000018BBF4574
		private static void _SetColor(Graphic graphic, CommonParams param) {} // 0x000000018BBF45A4-0x000000018BBF45E0
		public void __iFixBaseProxy_set_color(UnityEngine.Color P0) {} // 0x00000001857F0B10-0x00000001857F0BA0
		public void __iFixBaseProxy_CrossFadeAlpha(float P0, float P1, bool P2) {} // 0x00000001836AEC40-0x00000001836AEC70
		public void __iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, float P1, bool P2, bool P3, bool P4) {} // 0x000000018BBF24B8-0x000000018BBF2540
		public void __iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, float P1, bool P2, bool P3) {} // 0x00000001864BB614-0x00000001864BB734
	}

	public class UIControllerKeyIcon : MonoBehaviour // TypeDefIndex: 50231
	{
		// Fields
		private string _keyIconName; // 0x18
		private UIImage m_image; // 0x20
		private static List<UIControllerKeyIcon> s_iconCache; // 0x00
		private static bool s_initialized; // 0x08
	
		// Constructors
		public UIControllerKeyIcon() {} // 0x000000018646DB20-0x000000018646DB28
		static UIControllerKeyIcon() {} // 0x0000000185F13C90-0x0000000185F13D30
	
		// Methods
		private static void _TryStaticInit() {} // 0x000000018BBF4E24-0x000000018BBF4FAC
		private static void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType) {} // 0x000000018BBF4C88-0x000000018BBF4E24
		private void Awake() {} // 0x000000018BBF4914-0x000000018BBF49C0
		private void OnEnable() {} // 0x000000018BBF4A64-0x000000018BBF4B10
		private void OnDisable() {} // 0x000000018BBF49C0-0x000000018BBF4A64
		public void SetKeyIconName(GamepadKeyCode keyCode) {} // 0x000000018BBF4BEC-0x000000018BBF4C88
		public void RefreshKeyIcon() {} // 0x000000018BBF4B10-0x000000018BBF4BEC
	}

	public class UICustomLayout : UIBehaviour // TypeDefIndex: 50232
	{
		// Fields
		private RectTransform _dragArea; // 0x18
		public List<UICustomLayoutHandle> layoutHandles; // 0x20
		private JSONArray m_eventLog; // 0x28
	
		// Properties
		public RectTransform dragArea { get => default; } // 0x0000000181377E40-0x0000000181377E50 
	
		// Constructors
		public UICustomLayout() {} // 0x000000018BBF7DCC-0x000000018BBF7E84
	
		// Methods
		protected override void Awake() {} // 0x000000018BBF71B8-0x000000018BBF7300
		public bool IsDirty() => default; // 0x000000018BBF7300-0x000000018BBF745C
		public void ResetToDefault(bool saveChanges) {} // 0x000000018BBF745C-0x000000018BBF75E8
		public void Save(int ratio = 0 /* Metadata: 0x02061CB6 */) {} // 0x000000018BBF75E8-0x000000018BBF7898
		private void _LogEvent(Dictionary<UICustomLayoutElement, UICustomLayoutElement.LayoutData> layoutDataMap) {} // 0x000000018BBF7898-0x000000018BBF7DCC
		public void __iFixBaseProxy_Awake() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UICustomLayoutElement : UIBehaviour, IUIClearable // TypeDefIndex: 50235
	{
		// Fields
		private int _verNum; // 0x18
		private string _elementKey; // 0x20
		private Transform _overrideScaleTransform; // 0x28
		private CanvasGroup _overrideCanvasGroup; // 0x30
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
		public string elementKey { get => default; } // 0x000000018BBF5AD8-0x000000018BBF5B70 
		public RectTransform highlightRect { get => default; } // 0x0000000185FB3000-0x0000000185FB3010 
		public float scale { get => default; set {} } // 0x000000018BBF5B88-0x000000018BBF5B94 0x0000000183F80440-0x0000000183F80450
		public float alpha { get => default; set {} } // 0x000000018BBF5B70-0x000000018BBF5B7C 0x0000000185FD3C20-0x0000000185FD3C40
		public Vector2 position { get => default; set {} } // 0x000000018BBF5B7C-0x000000018BBF5B88 0x000000018143E3B0-0x000000018143E3C0
		public LayoutType layoutType { get => default; set {} } // 0x000000018143E3C0-0x000000018143E3D0 0x0000000185384FA0-0x0000000185385050
		public LuaPanel panel { get => default; } // 0x0000000185384520-0x0000000185384650 
	
		// Nested types
		public enum LayoutType // TypeDefIndex: 50233
		{
			None = 0,
			LeftToRight = 1
		}
	
		public class LayoutData // TypeDefIndex: 50234
		{
			// Fields
			public int verNum; // 0x10
			public float scale; // 0x14
			public float alpha; // 0x18
			public Vector2 position; // 0x1C
			public int layoutType; // 0x24
	
			// Constructors
			public LayoutData() {} // 0x00000001813B31A0-0x00000001813B31B0
		}
	
		// Constructors
		public UICustomLayoutElement() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Awake() {} // 0x0000000185C25390-0x0000000185C25400
		protected override void Start() {} // 0x000000018BBF5330-0x000000018BBF5424
		protected override void OnDestroy() {} // 0x000000018BBF54B8-0x000000018BBF5580
		public void ResetToDefault() {} // 0x000000018BBF5844-0x000000018BBF58B0
		private void _ApplyPosition() {} // 0x000000018BBF5760-0x000000018BBF5844
		private void _ApplyAlpha() {} // 0x000000018BBF58B0-0x000000018BBF5984
		private void _ApplyScale() {} // 0x0000000185384650-0x0000000185384810
		private void _SetDefaultValues() {} // 0x000000018BBF5004-0x000000018BBF50E0
		public string GetElementKeyWithRatio(int ratio = 0 /* Metadata: 0x02061CB7 */) => default; // 0x000000018BBF5984-0x000000018BBF5A88
		private bool _CheckElementKeyIsValid() => default; // 0x000000018BBF5580-0x000000018BBF5760
		public bool SaveData(out LayoutData layoutData, bool isResetToDefault = false /* Metadata: 0x02061CB8 */, int ratio = 0 /* Metadata: 0x02061CB9 */) {
			layoutData = default;
			return default;
		} // 0x000000018BBF50E0-0x000000018BBF5330
		public void LoadData() {} // 0x000000018BBF5A88-0x000000018BBF5AD8
		private void _OnHudLayoutSaved() {} // 0x0000000185384E80-0x0000000185384FA0
		private Vector2 _GetMarginSize() => default; // 0x000000018BBF4FAC-0x000000018BBF5004
		public void ClearComponent() {} // 0x000000018BBF5424-0x000000018BBF54B8
		public static void RefreshAll() {} // 0x00000001859639C0-0x0000000185963A60
		public void __iFixBaseProxy_Awake() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_Start() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UICustomLayoutHandle : UIBehaviour, IPointerClickHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 50236
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
		public float scale { get => default; set {} } // 0x0000000185FB80E0-0x0000000185FB80F0 0x000000018BBF7124-0x000000018BBF71B8
		public float alpha { get => default; set {} } // 0x0000000185FB1750-0x0000000185FB1760 0x000000018BBF6F40-0x000000018BBF6FB4
		public Vector2 position { get => default; set {} } // 0x0000000185FD6CC0-0x0000000185FD6CE0 0x000000018BBF7044-0x000000018BBF7124
		public UICustomLayoutElement.LayoutType layoutType { get => default; set {} } // 0x0000000183F80450-0x0000000183F80460 0x000000018BBF6FB4-0x000000018BBF7044
		public LuaPanel panel { get => default; } // 0x000000018BBF6E88-0x000000018BBF6F40 
		public UICustomLayoutElement Element { get => default; } // 0x000000018BBF6DD4-0x000000018BBF6E88 
	
		// Constructors
		public UICustomLayoutHandle() {} // 0x000000018BBF6C44-0x000000018BBF6DD4
	
		// Methods
		protected override void Awake() {} // 0x000000018BBF5B94-0x000000018BBF5DA0
		protected override void OnDestroy() {} // 0x000000018BBF5FF8-0x000000018BBF615C
		private void _OnElementDataLoaded() {} // 0x000000018BBF6A98-0x000000018BBF6B44
		private void _CalculatePositionRange() {} // 0x000000018BBF66FC-0x000000018BBF6A98
		private void _ApplyPosition() {} // 0x000000018BBF6618-0x000000018BBF668C
		private void _ApplyAlpha() {} // 0x000000018BBF654C-0x000000018BBF65B4
		private void _ApplyScale() {} // 0x000000018BBF668C-0x000000018BBF66FC
		private void _ApplyLayoutType() {} // 0x000000018BBF65B4-0x000000018BBF6618
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BBF5EA0-0x000000018BBF5FF8
		public void OnDrag(PointerEventData eventData) {} // 0x000000018BBF615C-0x000000018BBF62A8
		public void OnEndDrag(PointerEventData eventData) {} // 0x000000018BBF62A8-0x000000018BBF6334
		public bool Save(out UICustomLayoutElement.LayoutData layoutData, int ratio = 0 /* Metadata: 0x02061CBC */) {
			layoutData = default;
			return default;
		} // 0x000000018BBF647C-0x000000018BBF654C
		public void ResetToDefault() {} // 0x000000018BBF639C-0x000000018BBF647C
		public bool IsDirty() => default; // 0x000000018BBF5E54-0x000000018BBF5EA0
		private void _SetChanged(bool changed) {} // 0x000000018BBF6B94-0x000000018BBF6C44
		public void OnPointerClick(PointerEventData eventData) {} // 0x000000018BBF6334-0x000000018BBF639C
		private void _OnSystemDisplaySizeChanged() {} // 0x000000018BBF6B44-0x000000018BBF6B94
		public void ClearComponent() {} // 0x000000018BBF5DA0-0x000000018BBF5E54
		public void __iFixBaseProxy_Awake() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UIDialogText : TickableUIMono // TypeDefIndex: 50238
	{
		// Fields
		protected UIText _uiText; // 0x68
		private float _textRevealSpeed; // 0x70
		private bool _autoPlay; // 0x74
		private UpdateMode _updateMode; // 0x78
		private bool _useAutoScroll; // 0x7C
		private float _originalHeight; // 0x80
		private bool _useAspectRatio; // 0x84
		private float _autoScrollSpeed; // 0x88
		private float _autoWaitTime; // 0x8C
		private float _maxAspectRatio; // 0x90
		private float _minAspectRatio; // 0x94
		private float _maxAspectRatioScrollSpeed; // 0x98
		private float _minAspectRatioScrollSpeed; // 0x9C
		private float _maxAspectRatioWaitTime; // 0xA0
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
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
		private bool useAspectRatio { get => default; } // 0x000000018BBF8ABC-0x000000018BBF8AD0 
		private bool notUseAspectRatio { get => default; } // 0x000000018BBF8A38-0x000000018BBF8A4C 
		public bool playing { get => default; } // 0x000000018BBF8A4C-0x000000018BBF8ABC 
		public UIText uiText { get => default; } // 0x00000001813AC280-0x00000001813AC290 
		public int totalCharacterNum { get => default; } // 0x0000000185FBB310-0x0000000185FBB320 
		public float textRevealSpeed { get => default; set {} } // 0x0000000185FB89C0-0x0000000185FB89D0 0x0000000185FBD310-0x0000000185FBD320
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 50237
		{
			Auto = 0,
			Manual = 1
		}
	
		// Constructors
		public UIDialogText() {} // 0x0000000185C24C40-0x0000000185C24D00
	
		// Methods
		protected override void OnAwake() {} // 0x0000000185F8A080-0x0000000185F8A0C0
		protected void Start() {} // 0x000000018504C280-0x000000018504C330
		protected override void OnDisable() {} // 0x000000018BBF8844-0x000000018BBF889C
		protected override void OnEnable() {} // 0x0000000185F51380-0x0000000185F513C0
		public override void Tick(float deltaTime) {} // 0x0000000184E6C540-0x0000000184E6C5A0
		protected virtual void OnVisibleCharactersChanged(int count) {} // 0x000000018BBF889C-0x000000018BBF88F0
		protected float GetScrollSpeed() => default; // 0x000000018BBF8424-0x000000018BBF8508
		protected float GetAutoWaitTime() => default; // 0x000000018BBF8290-0x000000018BBF8374
		private void _UpdateTextAuto() {} // 0x0000000184E6C5A0-0x0000000184E6C6B0
		private void _TryAutoScroll() {} // 0x0000000184E6C6B0-0x0000000184E6C720
		public void RefreshAutoScrollData() {} // 0x000000018504C480-0x000000018504C520
		public void SetText(string text, bool resetPlay = true /* Metadata: 0x02061CBD */) {} // 0x000000018504C3A0-0x000000018504C480
		private void _RefreshPosY() {} // 0x000000018BBF898C-0x000000018BBF8A38
		public void SeekToEnd() {} // 0x000000018BBF88F0-0x000000018BBF898C
		public void RefreshText() {} // 0x0000000185F513C0-0x0000000185F51410
		public void Play() {} // 0x000000018504C330-0x000000018504C3A0
		public virtual void ResetPlay() {} // 0x0000000185D6F3C0-0x0000000185D6F430
		public void StopPlay() {} // 0x0000000184E6C490-0x0000000184E6C540
		public void ManualUpdateByPercent(float percent) {} // 0x000000018BBF8508-0x000000018BBF8654
		public void ManualUpdateByTime(float time) {} // 0x000000018BBF8654-0x000000018BBF8844
		public virtual float GetDisplayAllCharactersTime() => default; // 0x000000018BBF8374-0x000000018BBF8424
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000187AAA404-0x0000000187AAA40C
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UIDialogTextWithCursor : UIDialogText // TypeDefIndex: 50239
	{
		// Fields
		private float _textGapTime; // 0xE8
		private UIAnimationWrapper _cursorAnimation; // 0xF0
		private RectTransform _cursorLoopHide; // 0xF8
		private RectTransform _cursorGroup; // 0x100
		private UIImage _background; // 0x108
		[NonSerialized]
		public bool isLastTextLine; // 0x110
		private int m_lastCount; // 0x114
	
		// Constructors
		public UIDialogTextWithCursor() {} // 0x000000018BBF8274-0x000000018BBF8290
	
		// Methods
		public override void ResetPlay() {} // 0x000000018BBF8204-0x000000018BBF825C
		protected override void OnVisibleCharactersChanged(int count) {} // 0x000000018BBF7EE0-0x000000018BBF8204
		public override float GetDisplayAllCharactersTime() => default; // 0x000000018BBF7E84-0x000000018BBF7EE0
		public void __iFixBaseProxy_ResetPlay() {} // 0x000000018BBF826C-0x000000018BBF8274
		public void __iFixBaseProxy_OnVisibleCharactersChanged(int P0) {} // 0x000000018BBF8264-0x000000018BBF826C
		public float __iFixBaseProxy_GetDisplayAllCharactersTime() => default; // 0x000000018BBF825C-0x000000018BBF8264
	}

	public class EasyUIOptionData // TypeDefIndex: 50240
	{
		// Fields
		public int index; // 0x10
		public string optionIcon; // 0x18
		public string optionText; // 0x20
	
		// Constructors
		public EasyUIOptionData() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UIDialogTimelineOptionCell : MonoBehaviour // TypeDefIndex: 50241
	{
		// Fields
		private UIImage _optionIcon; // 0x18
		private UIText _optionText; // 0x20
	
		// Constructors
		public UIDialogTimelineOptionCell() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class UIDialogTimelineText : MonoBehaviour // TypeDefIndex: 50242
	{
		// Fields
		private UIDialogText _dialogText; // 0x18
		private UIText _actorName; // 0x20
		private GameObject _waitNode; // 0x28
		private UIAnimationWrapper _radioNode; // 0x30
		private UIImage _iconImage; // 0x38
		private UIImage _iconBlueMask; // 0x40
		public UIText centerText; // 0x48
		private string m_currentRadioIcon; // 0x50
		private CanvasGroup m_canvasGroup; // 0x58
	
		// Properties
		private CanvasGroup canvasGroup { get => default; } // 0x000000018BBF8E14-0x000000018BBF8EA4 
		public UIDialogText dialogText { get => default; } // 0x0000000181377E40-0x0000000181377E50 
		public UIText actorName { get => default; } // 0x00000001813B31A0-0x00000001813B31B0 
		public GameObject waitNode { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
	
		// Constructors
		public UIDialogTimelineText() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void UpdateAlpha(float alpha) {} // 0x000000018BBF8C48-0x000000018BBF8D08
		public void SetRadioIcon(bool useRadio, string radioIcon) {} // 0x000000018BBF8AD0-0x000000018BBF8C04
		private void _ClearRadioIcon() {} // 0x000000018BBF8D08-0x000000018BBF8E14
		private void __ClearRadioIcon_b__19_0() {} // 0x000000018BBF8C04-0x000000018BBF8C48
	}

	public class UIDrag : UIBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 50243
	{
		// Fields
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
		public UIDrag() {} // 0x000000018BBFAD00-0x000000018BBFAE10
	
		// Methods
		protected override void Awake() {} // 0x000000018BBFA438-0x000000018BBFA530
		public void OnDrag(PointerEventData eventData) {} // 0x000000018BBFAA70-0x000000018BBFAC74
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BBFA5D4-0x000000018BBFAA70
		public void OnEndDrag(PointerEventData eventData) {} // 0x000000018BBFAC74-0x000000018BBFAD00
		public void ApplyDragArea() {} // 0x000000018BBF9FF8-0x000000018BBFA438
		public void ClearComponent() {} // 0x000000018BBFA530-0x000000018BBFA5D4
		public void __iFixBaseProxy_Awake() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UIDragHandler : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 50244
	{
		// Fields
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
		public int dragThreshold { get => default; } // 0x000000018BBF924C-0x000000018BBF9294 
	
		// Constructors
		public UIDragHandler() {} // 0x0000000184816070-0x0000000184816170
	
		// Methods
		public void ClearComponent() {} // 0x000000018BBF8EA4-0x000000018BBF8F48
		public void OnPointerDown(PointerEventData eventData) {} // 0x000000018BBF91D8-0x000000018BBF924C
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BBF8F48-0x000000018BBF8FDC
		public void OnDrag(PointerEventData eventData) {} // 0x000000018BBF8FDC-0x000000018BBF9144
		public void OnEndDrag(PointerEventData eventData) {} // 0x000000018BBF9144-0x000000018BBF91D8
	}

	public class UIDragItem : UIBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 50246
	{
		// Fields
		public static RectTransform s_commonDragObjectParent; // 0x00
		private LuaTable _luaTable_k__BackingField; // 0x18
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
		private bool _endDragOnDisable; // 0x49
		[NonSerialized]
		public bool disableDrag; // 0x4A
		private bool _isInScrollList; // 0x4B
		private bool _hideDragObjectInScrollList; // 0x4C
		private GameObject _dragPrefab; // 0x50
		private RectTransform _dragObjectParent; // 0x58
		public Vector2 dragPivot; // 0x60
		private Image _draggingHintImage; // 0x68
		private CanvasGroup _draggingHintCanvasGroup; // 0x70
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
		public LuaTable luaTable { get; set; } // 0x0000000185A13900-0x0000000185A13970 0x00000001858D8EC0-0x00000001858D8FC0
		public bool inDragging { get => default; } // 0x00000001857E1600-0x00000001857E1670 
		public LuaPanel panel { get => default; } // 0x000000018BBF9C4C-0x000000018BBF9CDC 
		private RectTransform m_dragParentRect { get => default; } // 0x000000018BBF9894-0x000000018BBF98F4 
		public GameObject curDragObj { get => default; } // 0x0000000185A12B00-0x0000000185A12B40 
	
		// Nested types
		private sealed class __ContinueDragOnDisable_d__40 : IEnumerator<object> // TypeDefIndex: 50245
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIDragItem __4__this; // 0x20
			private PointerEventData _eData_5__2; // 0x28
			private PooledList<RaycastResult> _raycastResults_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BBF9F34-0x000000018BBF9FF8 
			object IEnumerator.Current { get => default; } // 0x0000000185FB0520-0x0000000185FB0530 
	
			// Constructors
			public __ContinueDragOnDisable_d__40() {} // Dummy constructor
			public __ContinueDragOnDisable_d__40(int __1__state) {} // 0x0000000181377E40-0x0000000181377E50
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000184088E70-0x0000000184088E80
			private bool MoveNext() => default; // 0x0000000185FB8C10-0x0000000185FB8C20
			void IEnumerator.Reset() {} // 0x000000018BBF9E84-0x000000018BBF9F34
		}
	
		// Constructors
		public UIDragItem() {} // 0x0000000181378230-0x0000000181378240
	
		// Methods
		protected override void Awake() {} // 0x000000018BBF9334-0x000000018BBF9894
		protected override void Start() {} // 0x000000018BBF98F4-0x000000018BBF9C4C
		protected override void OnDisable() {} // 0x00000001857E1670-0x00000001857E1700
		private IEnumerator _ContinueDragOnDisable() => default; // 0x000000018BBF9CDC-0x000000018BBF9E84
		protected override void OnDestroy() {} // 0x000000018BBF9294-0x000000018BBF9334
		protected override void OnEnable() {} // 0x00000001849D50F0-0x00000001849D5180
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000184817BA0-0x0000000184817D20
		public void OnDrag(PointerEventData eventData) {} // 0x0000000185492010-0x0000000185492020
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000185492010-0x0000000185492020
		private void _StopDragView() {} // 0x0000000185492010-0x0000000185492020
		public void ClearComponent() {} // 0x0000000185492010-0x0000000185492020
		public void ClearEvents() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_Awake() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_Start() {} // 0x000000018BBF2540-0x000000018BBF28D0
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000181377E40-0x0000000181377E50
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018BBF28D0-0x000000018BBF291C
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class UIDropdown : Selectable, IPointerClickHandler, IUIClearable, IBindingGroupTarget, IBindingView // TypeDefIndex: 50249
	{
		// Fields
		public UnityEvent<int> onSelectCell; // 0x180
		public UnityEvent<int, UIDropdownOption, bool> onUpdateCell; // 0x188
		public UnityEvent<int, UIDropdown> onUpdateCaption; // 0x190
		public UnityEvent<bool> onToggleOptList; // 0x198
		public Func<int, int, bool> onValidateSelectCell; // 0x1A0
		public UIText captionText; // 0x1A8
		public UIImage captionIcon; // 0x1B0
		private int _selectedIndex_k__BackingField; // 0x1B8
		private int _optionCount_k__BackingField; // 0x1BC
		private bool _isListActive_k__BackingField; // 0x1C0
		private UIDropdownOption _optionTemplate; // 0x1C8
		private Transform _arrowImageTrans; // 0x1D0
		private RectTransform _listContainer; // 0x1D8
		private float _listContainerMaxHeight; // 0x1E0
		private float _animationTime; // 0x1E4
		private RectTransform _selfArea; // 0x1E8
		private RectTransform _maskRect; // 0x1F0
		private bool _autoCloseOnSelect; // 0x1F8
		private string _audioToggleOn; // 0x200
		private string _audioToggleOff; // 0x208
		private string _audioInvalid; // 0x210
		private string _audioNavigation; // 0x218
		private List<UIDropdownOption> m_options; // 0x220
		private LuaPanel m_panel; // 0x228
		private LayoutGroup m_content; // 0x230
		private Camera m_fallbackUICamera; // 0x238
		private UIScrollRect m_listScrollRect; // 0x240
		private CanvasGroup m_listContainerCanvasGroup; // 0x248
		public string openDropDownActionId; // 0x250
		public string openDropDownBindingTextId; // 0x258
		private int m_bindingGroupId; // 0x260
		private int m_naviBindingGroupId; // 0x264
		private LuaPanel m_luaPanel; // 0x268
		private UISelectableNaviGroup m_listNaviGroup; // 0x270
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0x278
		private readonly DisposedUnityEvent _bindingViewUpdateEvent_k__BackingField; // 0x280
	
		// Properties
		public int selectedIndex { get; private set; } // 0x0000000185FB93C0-0x0000000185FB93D0 0x0000000185FD6CE0-0x0000000185FD6CF0
		public int optionCount { get; private set; } // 0x0000000184CD2F10-0x0000000184CD2FD0 0x0000000185192130-0x00000001851922B0
		public bool isListActive { get; private set; } // 0x0000000185B50E50-0x0000000185B50ED0 0x0000000184A04F60-0x0000000184A05010
		public LuaPanel panel { get => default; } // 0x0000000185047A70-0x0000000185047B40 
		public int groupId { get => default; } // 0x0000000185FB8470-0x0000000185FB8480 
		public IBindingGroupTarget parentTarget { get; private set; } // 0x000000018BBFB2C8-0x000000018BBFB360 0x0000000185FB8460-0x0000000185FB8470
		public bool groupEnabled { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public string bindingViewActionId { get => default; } // 0x000000018BBFB2C0-0x000000018BBFB2C8 
		public string bindingViewLabelText { get => default; } // 0x000000018BBFB360-0x000000018BBFB444 
		public DisposedUnityEvent bindingViewUpdateEvent { get; } // 0x000000018BBFAF08-0x000000018BBFAFC4 
		public RectTransform redDotTrans { get => default; } // 0x000000018BBFAE10-0x000000018BBFAE64 
		public bool bindingEnabled { get => default; } // 0x000000018BBFAE64-0x000000018BBFAEB8 
		public BindingViewState bindingViewState { get => default; } // 0x00000001851922B0-0x0000000185192450 
		bool IBindingView.interactable { get => default; } // 0x00000001856CD2A0-0x00000001856CD2B0 
	
		// Nested types
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 50247
		{
			// Fields
			public UIDropdown __4__this; // 0x10
			public bool activeList; // 0x18
	
			// Constructors
			public __c__DisplayClass44_0() {} // 0x0000000185FBED00-0x0000000185FBED10
	
			// Methods
			internal void __ToggleOptions_b__0() {} // 0x0000000185FD6CF0-0x0000000185FD6D00
		}
	
		private sealed class __c__DisplayClass48_0 // TypeDefIndex: 50248
		{
			// Fields
			public int index; // 0x10
			public UIDropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass48_0() {} // 0x0000000185FBCFC0-0x0000000185FBCFD0
	
			// Methods
			internal void _Refresh_b__0(PointerEventData evt) {} // 0x0000000185FBCFD0-0x0000000185FBCFE0
		}
	
		// Constructors
		public UIDropdown() {} // 0x000000018BBD59F0-0x000000018BBD59F8
	
		// Methods
		protected override void Awake() {} // 0x0000000184A05010-0x0000000184A05060
		protected override void _NotifyIsHover(bool isHover) {} // 0x0000000184A05060-0x0000000184A05570
		public void OnPointerClick(PointerEventData eventData) {} // 0x0000000184CD3070-0x0000000184CD32A0
		public void Init(UnityAction<int, UIDropdownOption, bool> onUpdateCell, UnityAction<int> onSelectCell, UnityAction<int, UIDropdown> onUpdateCaption = null) {} // 0x0000000184A05570-0x0000000184A058B0
		public void ToggleOptions(bool activeList) {} // 0x000000018BBFAFC4-0x000000018BBFB100
		private void _ToggleOptions(bool activeList, bool isInit) {} // 0x0000000184B44D60-0x0000000184B451B0
		private void Update() {} // 0x0000000185C4DA90-0x0000000185C4DB40
		public void SetSelected(int index, bool forceUpdate = false /* Metadata: 0x02061CC0 */, bool needNotifySelect = true /* Metadata: 0x02061CC1 */, bool validateSelect = false /* Metadata: 0x02061CC2 */) {} // 0x0000000184CD2D80-0x0000000184CD2F10
		public void ScrollToSelected() {} // 0x0000000185FBC540-0x0000000185FBC550
		public void Refresh(int count, int newSelectedIndex = -1 /* Metadata: 0x02061CC3 */, bool needNotifySelect = true /* Metadata: 0x02061CC4 */) {} // 0x0000000185FB8480-0x0000000185FB8490
		public void ClearComponent() {} // 0x0000000187A47564-0x0000000187A47578
		private Camera _GetUICamera() => default; // 0x000000018BBFB444-0x000000018BBFB75C
		public string GetBindingViewActionId(BindingViewActionType actionType) => default; // 0x000000018BBFB16C-0x000000018BBFB1E4
		void IBindingView.OnInputKeyDown(bool isActionTrigger) {} // 0x000000018BBFB100-0x000000018BBFB16C
		void IBindingView.OnInputKeyUp(bool isActionTrigger) {} // 0x000000018BBFB1E4-0x000000018BBFB2C0
		private void _InitBinding() {} // 0x0000000185D69C70-0x0000000185D69D00
		private void _ControllerToggle() {} // 0x0000000185D69D00-0x0000000185D69D90
		private void _ControllerCancel() {} // 0x0000000185C4D9F0-0x0000000185C4DA90
		private Selectable _GetDefaultNaviTarget() => default; // 0x00000001859DFF40-0x00000001859E0090
		protected override void OnEnable() {} // 0x000000018BBFAEB8-0x000000018BBFAF08
		protected override void OnDisable() {} // 0x000000018BBD59E0-0x000000018BBD59E8
		protected override void OnDestroy() {} // 0x000000018BBF36E4-0x000000018BBF36EC
		public void __iFixBaseProxy_Awake() {} // 0x000000018BBD59E8-0x000000018BBD59F0
		public void __iFixBaseProxy__NotifyIsHover(bool P0) {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BBFC9CC-0x000000018BBFCA10
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185FACEC0-0x0000000185FACF00
	}

	public class UIDropdownOption : MonoBehaviour // TypeDefIndex: 50250
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
		public UIDropdownOption() {} // 0x00000001845609A0-0x00000001845609B0
	
		// Methods
		public void SetText(string text) {} // 0x0000000184BC6260-0x0000000184BC6340
		public void SetState(string stateName) {} // 0x000000018BBFCD08-0x000000018BBFCDBC
	}

	public enum CommonDropHintType // TypeDefIndex: 50251
	{
		None = 0,
		Square = 1,
		Circle = 2
	}

	public class UIDropItem : UIBehaviour, IDropHandler, IUIClearable // TypeDefIndex: 50252
	{
		// Fields
		private LuaTable _luaTable_k__BackingField; // 0x18
		[NonSerialized]
		public UnityEvent<PointerEventData> onDropEvent; // 0x20
		[NonSerialized]
		public UnityEvent<bool> onToggleHighlight; // 0x28
		public Action onDestroy; // 0x30
		public CommonDropHintType commonDropHintType; // 0x38
		private GameObject _highlightHint; // 0x40
		private bool _scaleWhenHighlight; // 0x48
		private float _scaleWhenActive; // 0x4C
		private bool _useUIState; // 0x50
		private UIStyleByState.StateConfig _stateConfigNormal; // 0x58
		private UIStyleByState.StateConfig _stateConfigHilight; // 0x60
		private Selectable m_selectable; // 0x68
		private RectTransform m_rectTransform; // 0x70
		private float m_oriScale; // 0x78
		private bool m_isInHighlight; // 0x7C
	
		// Properties
		public LuaTable luaTable { get; set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public UIDropItem() {} // 0x0000000184817A70-0x0000000184817BA0
	
		// Methods
		public void ClearEvents() {} // 0x00000001849D50A0-0x00000001849D50F0
		protected override void Awake() {} // 0x000000018592D1B0-0x000000018592D270
		protected override void OnEnable() {} // 0x000000018570AE70-0x000000018570AED0
		protected override void OnDisable() {} // 0x000000018570AE30-0x000000018570AE70
		protected override void OnDestroy() {} // 0x000000018BBFCB4C-0x000000018BBFCBEC
		public void ToggleHighlight(bool active, bool forceToggle = false /* Metadata: 0x02061CC8 */) {} // 0x000000018570AED0-0x000000018570B0C0
		public void OnDrop(PointerEventData eventData) {} // 0x000000018BBFCBEC-0x000000018BBFCD08
		public void ClearComponent() {} // 0x000000018BBFCAB4-0x000000018BBFCB4C
		public void __iFixBaseProxy_Awake() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UIElementFollower : TickableUIMono // TypeDefIndex: 50253
	{
		// Fields
		private bool _followMouse; // 0x68
		public bool followFixedPos; // 0x69
		private Transform _targetTransform; // 0x70
		private Vector3 _followPosition; // 0x78
		private bool _changeScale; // 0x84
		private AnimationCurve _scaleCurve; // 0x88
		public Vector3 displayOffset; // 0x90
		public Vector3 displayUIOffset; // 0x9C
		private static readonly ProfilerMarker UPDATE_POSITION_MARKER; // 0x00
		public DisposedUnityEvent onExitScreen; // 0xA8
		public DisposedUnityEvent onEnterScreen; // 0xB0
		private bool _inScreen_k__BackingField; // 0xB8
		private LuaPanel m_panel; // 0xC0
		private RectTransform m_rectTransform; // 0xC8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
		public Vector3 followPosition { get => default; set {} } // 0x0000000185FBF940-0x0000000185FBF960 0x0000000185B59CB0-0x0000000185B59CD0
		public Transform targetTransform { get => default; set {} } // 0x0000000181460F70-0x0000000181460F80 0x000000018BBFCDBC-0x000000018BBFCDE0
		public bool inScreen { get; private set; } // 0x0000000181EB1570-0x0000000181EB1580 0x0000000181EB1580-0x0000000181EB1590
		public LuaPanel panel { get => default; } // 0x0000000184233CB0-0x0000000184233E70 
	
		// Constructors
		public UIElementFollower() {} // 0x0000000184816C70-0x0000000184816D50
		static UIElementFollower() {} // 0x0000000185F65810-0x0000000185F65870
	
		// Methods
		protected override void OnAwake() {} // 0x00000001858E3050-0x00000001858E30D0
		protected override void OnEnable() {} // 0x00000001857FB830-0x00000001857FB880
		public override void LateTick(float deltaTime) {} // 0x00000001842335E0-0x0000000184233620
		public void UpdatePosition() {} // 0x00000001842337B0-0x00000001842339A0
		public void UpdatePosition(Vector3 worldPos) {} // 0x00000001842339A0-0x0000000184233CB0
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class UIExtendScrollRect : MonoBehaviour, UnityEngine.EventSystems.IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 50254
	{
		// Fields
		public UIScrollRect baseScrollRect; // 0x18
		private bool _enableDrag; // 0x20
		private UIScrollList _extendScrollList; // 0x28
	
		// Constructors
		public UIExtendScrollRect() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void OnScroll(PointerEventData eventData) {} // 0x000000018BBFD0A4-0x000000018BBFD150
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BBFCDE0-0x000000018BBFCECC
		public void OnDrag(PointerEventData eventData) {} // 0x000000018BBFCECC-0x000000018BBFCFB8
		public void OnEndDrag(PointerEventData eventData) {} // 0x000000018BBFCFB8-0x000000018BBFD0A4
	}

	public interface IUIFoldoutComp // TypeDefIndex: 50255
	{
		// Properties
		bool defaultFoldOut { get; } // 0x00000001840A27C0-0x00000001840A27D0 
	
		// Methods
		void Refresh(int index);
		void OnFoldOut(bool fastMode = false /* Metadata: 0x02061CC9 */);
		void OnFoldIn(bool fastMode = false /* Metadata: 0x02061CCA */);
	}

	public class UIFoldoutComponent : MonoBehaviour, IUIFoldoutComp // TypeDefIndex: 50258
	{
		// Fields
		protected GameObject _foldContent; // 0x18
		protected UINonUnifiedScrollList _nonUnifiedScrollList; // 0x20
		public float foldInSize; // 0x28
		public float duration; // 0x2C
		public Ease easeType; // 0x30
		protected bool m_isFoldOut; // 0x34
		private Tweener m_tween; // 0x38
		protected int m_index; // 0x40
	
		// Properties
		public virtual bool defaultFoldOut { get => default; } // 0x0000000181DCCCE0-0x0000000181DCCCF0 
	
		// Nested types
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 50256
		{
			// Fields
			public float startSize; // 0x10
			public UIFoldoutComponent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0() {} // 0x000000018BBFD724-0x000000018BBFD7A0
	
			// Methods
			internal float _OnFoldOut_b__0() => default; // 0x00000001840A27C0-0x00000001840A27D0
			internal void _OnFoldOut_b__1(float value) {} // 0x000000018BBFD46C-0x000000018BBFD724
		}
	
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 50257
		{
			// Fields
			public float startSize; // 0x10
			public UIFoldoutComponent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass12_0() {} // 0x000000018BBFD1BC-0x000000018BBFD46C
	
			// Methods
			internal float _OnFoldIn_b__0() => default; // 0x000000018BBFD150-0x000000018BBFD1BC
			internal void _OnFoldIn_b__1(float value) {} // 0x000000018BBFD7A0-0x000000018BBFD7C0
		}
	
		// Constructors
		public UIFoldoutComponent() {} // 0x000000018BBFC998-0x000000018BBFC9CC
	
		// Methods
		public void Refresh(int index) {} // 0x0000000185492010-0x0000000185492020
		public virtual void OnFoldOut(bool fastMode = false /* Metadata: 0x02061CCB */) {} // 0x000000018BBFC998-0x000000018BBFC9CC
		public virtual void OnFoldIn(bool fastMode = false /* Metadata: 0x02061CCC */) {} // 0x0000000185492010-0x0000000185492020
		private void OnDestroy() {} // 0x0000000181DCCCE0-0x0000000181DCCCF0
	}

	public class UIGraphicAnimation : TickableUIMono // TypeDefIndex: 50259
	{
		// Fields
		private static int s_vfxMainTextSTId; // 0x00
		private static int s_tintColorAlpha; // 0x04
		private MaskableGraphic _graphic; // 0x68
		private Material _material; // 0x70
		private float _alpha; // 0x78
		private Vector2 _scale; // 0x7C
		private Material m_materialInstance; // 0x88
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
		public Material MaterialInstance { get => default; } // 0x0000000185FB0510-0x0000000185FB0520 
	
		// Constructors
		public UIGraphicAnimation() {} // 0x0000000184814DC0-0x0000000184814DE0
		static UIGraphicAnimation() {} // 0x0000000185F4E6B0-0x0000000185F4E730
	
		// Methods
		protected override void OnAwake() {} // 0x0000000184513EC0-0x0000000184513F00
		protected override void OnRelease() {} // 0x000000018BBFD7C0-0x000000018BBFD8E0
		public override void LateTick(float deltaTime) {} // 0x00000001845EA1E0-0x00000001845EA730
		private void _Init() {} // 0x0000000184513F00-0x0000000184514040
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class UIGridLayoutGroup : GridLayoutGroup // TypeDefIndex: 50260
	{
		// Constructors
		public UIGridLayoutGroup() {} // 0x000000018BBFD8E0-0x000000018BBFD8E8
	}

	public class UIGridLayoutNaviWrapper : UIBehaviour, UIScrollList.IScrollListNaviWrapper // TypeDefIndex: 50262
	{
		// Fields
		private GridLayoutGroup _gridLayoutGroup; // 0x18
		private LayoutGroup _layoutGroup; // 0x20
		private WrapMode _wrapMode; // 0x28
		private UIScrollRect _scrollRect; // 0x30
		private UISelectableNaviGroup _naviGroup; // 0x38
		private bool _enableCircleWrapNavigation; // 0x40
		private bool m_isInited; // 0x41
		private bool m_isVertical; // 0x42
		private LayoutGroup m_layoutGroup; // 0x48
		private List<Selectable> m_wrapNaviSelectables; // 0x50
	
		// Nested types
		public enum WrapMode // TypeDefIndex: 50261
		{
			NaviGroup = 0,
			ScrollRect = 1,
			ScrollList = 2,
			LayoutNaviWrapper = 3
		}
	
		// Constructors
		public UIGridLayoutNaviWrapper() {} // 0x0000000185F5B050-0x0000000185F5B0D0
	
		// Methods
		private void _InitIfNot() {} // 0x0000000184B5BAE0-0x0000000184B5BBB0
		protected override void Start() {} // 0x0000000184B5BBB0-0x0000000184B5BBF0
		public bool TryWrapNavigate(NaviDirection dir) => default; // 0x000000018BBFD8E8-0x000000018BBFD94C
		private void _InitWrapNavigation() {} // 0x0000000184B5BBF0-0x0000000184B5BCC0
		private void _NaviGridLayout(NaviDirection dir) {} // 0x000000018BBFE0F8-0x000000018BBFE160
		private bool _NaviGridLayoutImpl(NaviDirection dir, bool enableCircleWrapNavigation = false /* Metadata: 0x02061CCD */) => default; // 0x000000018BBFDD3C-0x000000018BBFDFC8
		private bool _NaviGridLayoutInit(bool isBefore, bool enableCircleWrapNavigation = false /* Metadata: 0x02061CCE */) => default; // 0x000000018BBFDFC8-0x000000018BBFE0F8
		private bool _NaviChildren(int curIndex, int childCount, bool isBefore, bool enableCircleWrapNavigation) => default; // 0x000000018BBFDAB4-0x000000018BBFDD3C
		private Selectable _FindValidSelectable(bool isBefore) => default; // 0x000000018BBFD94C-0x000000018BBFDAB4
		private void _SetCircleWrapScroll(bool isBefore) {} // 0x000000018BBFE160-0x000000018BBFE260
		public void __iFixBaseProxy_Start() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UIGyroscopeEffect : TickableUIMono // TypeDefIndex: 50264
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
		protected override TickType tickOption { get => default; } // 0x0000000185ECAF20-0x0000000185ECAFA0 
	
		// Nested types
		[Serializable]
		public class Param // TypeDefIndex: 50263
		{
			// Fields
			public float maxAngle; // 0x10
			public AnimationCurve valueCurve; // 0x18
	
			// Constructors
			public Param() {} // 0x0000000181E1B510-0x0000000181E1B520
		}
	
		// Constructors
		public UIGyroscopeEffect() {} // 0x000000018BBFE308-0x000000018BBFE33C
	
		// Methods
		protected override void OnAwake() {} // 0x0000000184B8E4B0-0x0000000184B8E9D0
		public override void Tick(float deltaTime) {} // 0x000000018BBFE260-0x000000018BBFE308
		protected override void OnRelease() {} // 0x0000000185B50430-0x0000000185B50490
		private Vector3 _Tick_b__22_0() => default; // 0x000000018BBFE33C-0x000000018BBFE364
		private void _Tick_b__22_1(Vector3 value) {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnAwake() {} // 0x000000018311B6C0-0x000000018311B6D0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018792FE0C-0x000000018792FE14
		public void __iFixBaseProxy_OnRelease() {} // 0x0000000185FA80B0-0x0000000185FA80C0
	}

	public class UIHighlightMask : TickableUIMono // TypeDefIndex: 50265
	{
		// Fields
		private RectTransform _up; // 0x68
		private RectTransform _down; // 0x70
		private RectTransform _left; // 0x78
		private RectTransform _right; // 0x80
		private RectTransform m_rect; // 0x88
		private LuaPanel m_panel; // 0x90
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
		public LuaPanel panel { get => default; } // 0x000000018BBFE7FC-0x000000018BBFE8C0 
	
		// Constructors
		public UIHighlightMask() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BBFE364-0x000000018BBFE3F4
		protected override void OnEnable() {} // 0x000000018BBFE3F4-0x000000018BBFE450
		public override void Tick(float deltaTime) {} // 0x000000018BBFE450-0x000000018BBFE4B0
		public void TrySyncRect() {} // 0x000000018BBFE4B0-0x000000018BBFE7FC
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UIImage : Image // TypeDefIndex: 50266
	{
		// Fields
		private int _atlasHandleId; // 0x190
		private List<UIImage> _referencedImages; // 0x198
		private UIAtlasManager.UIAtlasHandle m_atlasHandle; // 0x1A0
		private Action m_onEnableRuntimeAtlas; // 0x1C8
		private LuaPanel m_panel; // 0x1D0
		private bool m_hasBeenEnabled; // 0x1D8
		private string m_cachedSpritePath; // 0x1E0
		protected FAssetProxyHandle m_spriteResHandle; // 0x1E8
		protected FAssetProxyHandle m_matResHandle; // 0x1FC
		public const string SPRITE_PATH_FORMAT = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}/{1}.png"; // Metadata: 0x02061CD6
		public const string SPRITE_ROOT_PATH_FORMAT = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}.png"; // Metadata: 0x02061D12
		public bool enableAutoImgUsePathReference; // 0x210
		public bool imgUsePathReference; // 0x211
		public string imgRefPath; // 0x218
		private bool m_imgIsPathReference; // 0x220
	
		// Properties
		public bool packIntoRuntimeAtlas { get => default; set {} } // 0x0000000185FD6D20-0x0000000185FD6D30 0x0000000185FD6D40-0x0000000185FD6D50
		public int atlasHandleId { get => default; set {} } // 0x0000000185FD6D00-0x0000000185FD6D10 0x0000000185FD6D30-0x0000000185FD6D40
		public LuaPanel panel { get => default; } // 0x000000018404C1D0-0x000000018404C390 
		public ref UIAtlasManager.UIAtlasHandle atlasHandle { get => default; } // 0x0000000185FD6D10-0x0000000185FD6D20 
		public int panelLevel { get => default; } // 0x0000000185FBB6B0-0x0000000185FBB6C0 
		public override UnityEngine.Color color { get => default; set {} } // 0x0000000185FB6120-0x0000000185FB6130 0x0000000184042AA0-0x0000000184042CE0
		public override Texture mainTexture { get => default; } // 0x0000000184045840-0x00000001840458D0 
	
		// Constructors
		public UIImage() {} // 0x00000001840BF310-0x00000001840BF820
	
		// Methods
		public void RegisterOnEnableRuntimeAtlas(Action callBack) {} // 0x00000001849D1F90-0x00000001849D2050
		public void UnregisterOnEnableRuntimeAtlas(Action callBack) {} // 0x00000001849D2810-0x00000001849D28D0
		public void OnEnableRuntimeAtlas() {} // 0x000000018BBFFB4C-0x000000018BBFFBA8
		protected override void _OnSpriteChanged(Sprite lastOne) {} // 0x000000018404B3D0-0x000000018404B540
		protected override void OnPopulateMesh(VertexHelper toFill) {} // 0x00000001840451B0-0x0000000184045540
		protected override void Awake() {} // 0x000000018404B6F0-0x000000018404B810
		protected override void OnEnable() {} // 0x000000018404BE00-0x000000018404C1D0
		protected override void OnDisable() {} // 0x0000000184241190-0x0000000184241240
		protected override void OnDestroy() {} // 0x000000018404C450-0x000000018404C4A0
		public override void SetNativeSize() {} // 0x0000000185292A40-0x0000000185292C10
		public void SetNativeSizeIgnoreRefScale() {} // 0x000000018BBFFBA8-0x000000018BBFFBF8
		public void LoadSprite(string folder, string spriteName) {} // 0x000000018446BDE0-0x000000018446BFC0
		public void LoadSprite(string path) {} // 0x000000018572EB80-0x000000018572EC00
		public void LoadSpriteWithOutFormat(string path, bool ignoreEnable = false /* Metadata: 0x02061CD3 */) {} // 0x0000000183FE8CD0-0x0000000183FE8D20
		private void _LoadSprite(string path, bool ignoreEnable = false /* Metadata: 0x02061CD4 */) {} // 0x0000000184042D90-0x00000001840445B0
		public void LoadMaterial(string path, bool newInstance = false /* Metadata: 0x02061CD5 */) {} // 0x000000018BBFF910-0x000000018BBFFB4C
		public override void ReleaseSprite() {} // 0x0000000185EC24C0-0x0000000185EC2500
		public void DisposeSpriteHandle() {} // 0x000000018404C560-0x000000018404C5B0
		private static void _V2AtlasInitialize() {} // 0x0000000183FC2040-0x0000000183FC2210
		public void __iFixBaseProxy_set_color(UnityEngine.Color P0) {} // 0x000000018BBF45E0-0x000000018BBF4600
		public void __iFixBaseProxy__OnSpriteChanged(Sprite P0) {} // 0x000000018BBFFC30-0x000000018BBFFC38
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0) {} // 0x000000018BBFFC18-0x000000018BBFFC20
		public void __iFixBaseProxy_Awake() {} // 0x000000018BBFFBF8-0x000000018BBFFC00
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BBFFC10-0x000000018BBFFC18
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018BBFFC08-0x000000018BBFFC10
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018BBFFC00-0x000000018BBFFC08
		public void __iFixBaseProxy_SetNativeSize() {} // 0x000000018BBFFC28-0x000000018BBFFC30
		public void __iFixBaseProxy_ReleaseSprite() {} // 0x000000018BBFFC20-0x000000018BBFFC28
		public Texture __iFixBaseProxy_get_mainTexture() => default; // 0x000000018BBFFC38-0x000000018BBFFC40
	}

	public class UIImageBlur : TickableUIMono // TypeDefIndex: 50267
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
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public UIImageBlur() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		protected override void OnAwake() {} // 0x0000000185BC5DD0-0x0000000185BC5F80
		public void OnChangeSprite() {} // 0x0000000184013900-0x0000000184013BC0
		public override void Tick(float deltaTime) {} // 0x000000018BBFE944-0x000000018BBFEAA0
		protected override void OnDisable() {} // 0x0000000184F212A0-0x0000000184F213B0
		protected override void OnRelease() {} // 0x000000018BBFE8C0-0x000000018BBFE944
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000187AAA404-0x0000000187AAA40C
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
	}

	public class UIImageFillAmountOffset : MonoBehaviour // TypeDefIndex: 50268
	{
		// Fields
		private UIImage m_followImage; // 0x18
		public float fillOffset; // 0x20
		private float m_fillAmount; // 0x24
	
		// Properties
		public float fillAmount { get => default; set {} } // 0x0000000185FB3810-0x0000000185FB3820 0x000000018BBFEC2C-0x000000018BBFED64
	
		// Constructors
		public UIImageFillAmountOffset() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public TweenerCore<float, float, FloatOptions> DOFillAmount(float endValue, float duration) => default; // 0x000000018BBFEAA0-0x000000018BBFEC24
		private float _DOFillAmount_b__6_0() => default; // 0x0000000185FB3810-0x0000000185FB3820
		private void _DOFillAmount_b__6_1(float x) {} // 0x000000018BBFEC24-0x000000018BBFEC2C
	}

	public class UIImageFillFollower : TickableUIMono // TypeDefIndex: 50269
	{
		// Fields
		private const float BACK_FOLLOW_THRESHOLD = 0.02f; // Metadata: 0x02061D4A
		private UIImage _frontFill; // 0x68
		private float _followSpeed; // 0x70
		private UIImage m_image; // 0x78
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public UIImageFillFollower() {} // 0x000000018BBFEFEC-0x000000018BBFEFFC
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BBFED64-0x000000018BBFEE08
		protected override void OnEnable() {} // 0x000000018BBFEE08-0x000000018BBFEE7C
		public override void Tick(float deltaTime) {} // 0x000000018BBFEEE8-0x000000018BBFEFEC
		public void RefreshFillAmount() {} // 0x000000018BBFEE7C-0x000000018BBFEEE8
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UIImageFillTailFollower : TickableUIMono // TypeDefIndex: 50270
	{
		// Fields
		private UIImage _followImage; // 0x68
		public float followOffset; // 0x70
		private RectTransform m_selfRectTransform; // 0x78
		private RectTransform m_followImageRectTransform; // 0x80
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public UIImageFillTailFollower() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BBFEFFC-0x000000018BBFF0C0
		protected override void OnEnable() {} // 0x000000018BBFF0C0-0x000000018BBFF128
		public override void Tick(float deltaTime) {} // 0x000000018BBFF3D8-0x000000018BBFF444
		public void RefreshFollower() {} // 0x000000018BBFF128-0x000000018BBFF3D8
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UIImagePair : MonoBehaviour // TypeDefIndex: 50271
	{
		// Fields
		public List<UIImage> referencedImages; // 0x18
	
		// Properties
		public UnityEngine.Color color { set {} } // 0x000000018BBFF780-0x000000018BBFF910
		public UIImage first { get => default; } // 0x000000018BBFF6E8-0x000000018BBFF780 
	
		// Constructors
		public UIImagePair() {} // 0x000000018BBFF668-0x000000018BBFF6E8
	
		// Methods
		public void LoadSprite(string folder, string spriteName) {} // 0x000000018BBFF5B0-0x000000018BBFF668
		public void LoadSprite(string path) {} // 0x000000018BBFF444-0x000000018BBFF5B0
	}

	public class UIInertiaViewPager : TickableUIMono, IUIClearable // TypeDefIndex: 50285
	{
		// Fields
		private UIScrollRect _scrollRect; // 0x68
		private float _animationDuration; // 0x70
		private float _endScrollSpd; // 0x74
		private ScrollEffectConfig.Timing _timing; // 0x78
		private float _minScrollInterval; // 0x7C
		private string _audioGear; // 0x80
		private string _audioGearLock; // 0x88
		public bool flingToNextEnable; // 0x90
		public float flingToNextMinSpd; // 0x94
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
		private int _pageCount_k__BackingField; // 0xE0
		[NonSerialized]
		public DisposedUnityEvent<int> onStateChanged; // 0xE8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x000000018BBFBE64-0x000000018BBFBEC4 
		public bool isUpdating { get => default; } // 0x00000001814A81B0-0x00000001814A81C0 
		public int pageCount { get; private set; } // 0x0000000183908D00-0x0000000183908D10 0x0000000185492010-0x0000000185492020
		public int currentPage { get => default; set {} } // 0x000000018BBFC604-0x000000018BBFC648 0x000000018BBFC5C0-0x000000018BBFC604
		public float currentScrollIndex { get => default; } // 0x000000018BBFC380-0x000000018BBFC3F0 
	
		// Nested types
		public enum State // TypeDefIndex: 50272
		{
			IDLE = 0,
			DRAGING = 1,
			INERTIA = 2,
			ALIGNING = 3
		}
	
		private interface IScrollHandler : IHotfixable // TypeDefIndex: 50273
		{
			// Properties
			float velocity { get; } // 0x000000018BC006C0-0x000000018BC0073C 
			bool isDragging { get; } // 0x000000018BC00644-0x000000018BC006C0 
			float scrollProgress { get; set; } // 0x000000018BC002E8-0x000000018BC004F8 0x000000018BC00B3C-0x000000018BC00B48
	
			// Methods
			void OnClear(); // 0x0000000181E1B510-0x0000000181E1B520
			void StopMoving(); // 0x0000000185FB2390-0x0000000185FB23A0
		}
	
		private class CustomScrollHandler : Beyond.UI.UIInertiaViewPager.IScrollHandler // TypeDefIndex: 50274
		{
			// Fields
			private bool m_isScrolling; // 0x10
			private UIScrollRect m_scrollRect; // 0x18
	
			// Properties
			public float velocity { get => default; } // 0x000000018BC00B48-0x000000018BC00B54 
			public float scrollProgress { get => default; set {} } // 0x000000018BC00B08-0x000000018BC00B3C 0x000000018BBFFC40-0x000000018BBFFD34
			public bool isDragging { get => default; } // 0x000000018BBFFF18-0x000000018BC00270 
	
			// Constructors
			public CustomScrollHandler() {} // Dummy constructor
			public CustomScrollHandler(UIScrollRect scrollRect) {} // 0x0000000185FB2460-0x0000000185FB2470
	
			// Methods
			public void OnClear() {} // 0x00000001834A0D60-0x00000001834A0D70
			public void StopMoving() {} // 0x000000018BBFFE90-0x000000018BBFFF18
			private void _OnScrollBegin(Vector2 delta) {} // 0x000000018BBFFD34-0x000000018BBFFDC4
			private void _OnScrollEnd(Vector2 delta) {} // 0x000000018BBFFDC4-0x000000018BBFFE20
		}
	
		private struct EmptyScrollHandler : Beyond.UI.UIInertiaViewPager.IScrollHandler // TypeDefIndex: 50275
		{
			// Properties
			public float velocity { get => default; } // 0x000000018BBFFE20-0x000000018BBFFE90 
			public bool isDragging { get => default; } // 0x000000018BC0073C-0x000000018BC007B4 
			public float scrollProgress { get => default; set {} } // 0x000000018BC005C8-0x000000018BC00644 0x000000018BC007B4-0x000000018BC00838
	
			// Methods
			public void StopMoving() {} // 0x000000018BC00838-0x000000018BC009CC
			public void OnClear() {} // 0x000000018BC00270-0x000000018BC002E8
		}
	
		public struct FlingToNext // TypeDefIndex: 50276
		{
			// Fields
			public bool enable; // 0x00
			public float minSpd; // 0x04
			public float maxSpd; // 0x08
		}
	
		public struct ScrollOptions // TypeDefIndex: 50277
		{
			// Fields
			public FlingToNext flingToNext; // 0x00
		}
	
		private class DragContext // TypeDefIndex: 50278
		{
			// Fields
			public float startPos; // 0x10
	
			// Constructors
			public DragContext() {} // 0x0000000187AB03B8-0x0000000187AB03C0
	
			// Methods
			public void BeginDrag(UIInertiaViewPager pager) {} // 0x000000018BC004F8-0x000000018BC005C8
			public State EndDrag(UIInertiaViewPager pager) => default; // 0x000000018BC009CC-0x000000018BC00B08
			private bool _TryFlingToNext(UIInertiaViewPager pager) => default; // 0x000000018311B6C0-0x000000018311B6D0
		}
	
		private enum BlockerDir // TypeDefIndex: 50279
		{
			UPWARD = 0,
			DOWNNWARD = 1,
			BOTH = 2
		}
	
		private struct InertiaBlocker : IHotfixable // TypeDefIndex: 50280
		{
			// Fields
			public BlockerDir dir; // 0x00
			public int index; // 0x04
	
			// Methods
			public bool IsDirMatch(float vec) => default; // 0x0000000187AAA40C-0x0000000187AAA414
		}
	
		private class BlockerManager : IHotfixable // TypeDefIndex: 50281
		{
			// Fields
			private const float INERTIA_BIAS = 0.49f; // Metadata: 0x02061D55
			private List<InertiaBlocker> m_inertiaBlockers; // 0x10
			private float m_lastIndex; // 0x18
			private bool _isInertiaing_k__BackingField; // 0x1C
	
			// Properties
			public bool isInertiaing { get; private set; }
	
			// Constructors
			public BlockerManager() {}
	
			// Methods
			public void Init(int pageCount, List<int> blockFrames) {}
			public void StartInertia(float fromIndex) {}
			public bool HitInertiaBlock(float curIndex, out float preferTo) {
				preferTo = default;
				return default;
			}
		}
	
		public struct ScrollEffectConfig // TypeDefIndex: 50283
		{
			// Fields
			public Action onScrollToItem; // 0x00
			public Action onAlignedToItem; // 0x08
			public float minScrollInterval; // 0x10
			public Timing timing; // 0x14
	
			// Nested types
			public enum Timing // TypeDefIndex: 50282
			{
				HALF_VALUE = 0,
				FULL_VALUE = 1
			}
	
			// Methods
			public bool IsEmpty() => default; // 0x000000018BBFBF84-0x000000018BBFC1B8
		}
	
		public class ScrollEffectTrigger : IHotfixable // TypeDefIndex: 50284
		{
			// Fields
			private const float DFT_MIN_INTERVAL = 0.1f; // Metadata: 0x02061D5B
			private bool m_isValid; // 0x10
			private ScrollEffectConfig m_config; // 0x18
			private int m_lastFocusIndex; // 0x30
			private float m_curTime; // 0x34
			private float m_lastScrollTime; // 0x38
			private bool m_hasScrolled; // 0x3C
	
			// Constructors
			public ScrollEffectTrigger() {} // Dummy constructor
			public ScrollEffectTrigger(ScrollEffectConfig config) {} // 0x000000018BBFBBC8-0x000000018BBFBE64
	
			// Methods
			public void NotifyScrolling(float curIndex, float deltaTime) {} // 0x000000018BBFC26C-0x000000018BBFC2EC
			public void MarkHasScrolled() {} // 0x000000018BBFC1E0-0x000000018BBFC26C
			public void NotifyAlignFinish() {} // 0x000000018BBFC2EC-0x000000018BBFC380
			public void Reset(int curIndex) {} // 0x000000018BBFC1B8-0x000000018BBFC1E0
		}
	
		// Constructors
		public UIInertiaViewPager() {} // 0x000000018BBFC7E8-0x000000018BBFC8D8
	
		// Methods
		private void _PlayAudioGear() {} // 0x000000018BBFBEC4-0x000000018BBFBF24
		private void _PlayAudioGearLock() {} // 0x000000018BBFBF24-0x000000018BBFBF84
		private void _InitIfNot() {} // 0x0000000183908D00-0x0000000183908D10
		public void ClearComponent() {} // 0x000000018BBFC3F0-0x000000018BBFC45C
		public override void Tick(float deltaTime) {} // 0x000000018BBFC45C-0x000000018BBFC5C0
		public void SetPageCount(int pageCount, List<int> segmentFrames = null) {} // 0x0000000185492010-0x0000000185492020
		public void MoveToPage(int pageIndex) {} // 0x000000018BBFC648-0x000000018BBFC6D0
		protected override void OnAwake() {} // 0x00000001814088D0-0x00000001814088E0
		protected override void OnEnable() {} // 0x0000000181408D10-0x0000000181408D20
		private float _ScrollValue2PageIndex(float value) => default; // 0x000000018BBFB958-0x000000018BBFBAF0
		private float _PageIndex2ScrollValue(float index) => default; // 0x000000018BBFBAF0-0x000000018BBFBB50
		private int _ScrollValueAlignToPage(float value) => default; // 0x000000018BBFB75C-0x000000018BBFB958
		private void _SwitchToPage(int targetIndex, bool useTween) {} // 0x000000018BBFBB50-0x000000018BBFBBC8
		private void _AutoAlign() {} // 0x000000018BBFC6D0-0x000000018BBFC730
		private void _OnStateChanged(State from, State to) {} // 0x000000018BBFC948-0x000000018BBFC998
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018BBFC730-0x000000018BBFC784
		public void __iFixBaseProxy_OnAwake() {} // 0x000000018BBFC784-0x000000018BBFC7E8
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BBFC8D8-0x000000018BBFC948
	}

	public class UIInputField : TMP_InputField, IUIClearable // TypeDefIndex: 50287
	{
		// Fields
		public string activeInputActionId; // 0x388
		public string deactivateInputActionId; // 0x390
		private int _activeInputBindingId_k__BackingField; // 0x398
		private int _deactivateInputBindingId_k__BackingField; // 0x39C
		private LuaPanel m_panel; // 0x3A0
		public bool isDebugInputField; // 0x3A8
		private Camera m_fallbackUICamera; // 0x3B0
		private GameObject m_fallbackUIRoot; // 0x3B8
		private RectTransform m_fallbackRectTransform; // 0x3C0
		private int m_activateBindingGroupId; // 0x3C8
		private bool m_isNaviFocused; // 0x3CC
		private bool m_isCloudInputting; // 0x3CD
		private UIStateController _uiStateController; // 0x3D0
		private string _onFocusStateName; // 0x3D8
		private string _onFocusLostStateName; // 0x3E0
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
		public string audioOnActive; // 0x438
		private static UIInputField s_mFocusedInputField; // 0x00
	
		// Properties
		public int activeInputBindingId { get; private set; } // 0x0000000185F1D660-0x0000000185F1D720 0x0000000185F575E0-0x0000000185F57670
		public int deactivateInputBindingId { get; private set; } // 0x00000001849D8140-0x00000001849D8470 0x0000000185F38840-0x0000000185F38890
		public LuaPanel panel { get => default; } // 0x0000000185F10980-0x0000000185F109D0 
		private bool isControllerInputValid { get => default; } // 0x0000000183EC82D0-0x0000000183EC8650 
		public static UIInputField s_focusedInputField { get => default; private set {} } // 0x000000018BBD59E0-0x000000018BBD59E8 0x000000018BC00BCC-0x000000018BC00BD4
	
		// Nested types
		private sealed class __KeyboardHeightChange_d__63 : IEnumerator<object> // TypeDefIndex: 50286
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIInputField __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185FD6D80-0x0000000185FD6D90 
			object IEnumerator.Current { get => default; } // 0x0000000185732CC0-0x0000000185732D40 
	
			// Constructors
			public __KeyboardHeightChange_d__63() {} // Dummy constructor
			public __KeyboardHeightChange_d__63(int __1__state) {} // 0x0000000185FD6D50-0x0000000185FD6D60
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185FD6D70-0x0000000185FD6D80
			private bool MoveNext() => default; // 0x0000000185FD6D60-0x0000000185FD6D70
			void IEnumerator.Reset() {} // 0x000000018BC00F58-0x000000018BC0101C
		}
	
		// Constructors
		public UIInputField() {} // 0x000000018BC00BB4-0x000000018BC00BBC
	
		// Methods
		protected override void SendOnFocus() {} // 0x0000000185733040-0x0000000185734960
		protected override void SendOnFocusLost() {} // 0x0000000183EC8650-0x0000000183EC9800
		protected override void Awake() {} // 0x00000001857313D0-0x0000000185732CC0
		public override void OnSelect(BaseEventData eventData) {} // 0x0000000184228D30-0x0000000184229FB0
		public override void OnDeselect(BaseEventData eventData) {} // 0x0000000184A137D0-0x0000000184A13810
		public override void OnUpdateSelected(BaseEventData eventData) {} // 0x0000000184A13810-0x0000000184A13850
		public override void ActivateInputField() {} // 0x00000001859E4B60-0x00000001859E4BE0
		protected override bool TryActivateInputFieldCustom() => default; // 0x000000018BC00B54-0x000000018BC00BA4
		public override void DeactivateInputField(bool clearSelection = false /* Metadata: 0x02061D5F */) {} // 0x0000000184A13850-0x0000000184A139C0
		protected override void OnDestroy() {} // 0x00000001849D4340-0x00000001849D4480
		protected override void OnEnable() {} // 0x0000000183EC9820-0x0000000183ECA6A0
		protected override void OnDisable() {} // 0x000000018BC00C28-0x000000018BC00E68
		protected override void _NotifyIsHover(bool isHover) {} // 0x0000000185F66510-0x0000000185F66540
		public override void OnInteractableChanged() {} // 0x0000000185F38890-0x0000000185F388C0
		private void _UpdateBindingEnable() {} // 0x0000000185F109D0-0x0000000185F10A00
		public void ClearComponent() {} // 0x00000001849D87E0-0x00000001849D8820
		private void _OnCloudGameKeyboardComplete(string value, bool submit) {} // 0x000000018BC00F04-0x000000018BC00F58
		private Camera _GetCamera() => default; // 0x000000018BC00BE4-0x000000018BC00C28
		private void _VirtualKeyboardOnDestroy() {} // 0x00000001849D8820-0x00000001849D8850
		private void _VirtualKeyboardSelect() {} // 0x000000018BC00E68-0x000000018BC00F04
		private void _VirtualKeyboardDeselect() {} // 0x000000018BC0101C-0x000000018BC01054
		private void _VirtualKeyboardAwake() {} // 0x0000000185734A50-0x0000000185734BF0
		private void _UpdateKeyboardOffset(int offsetHeight) {} // 0x0000000184D70EF0-0x0000000184D70F90
		private void _CleanupAndroidObjects() {} // 0x0000000183EC9800-0x0000000183EC9810
		private void _VirtualKeyboardInitJavaObj() {} // 0x000000018BC00BDC-0x000000018BC00BE4
		private IEnumerator _KeyboardHeightChange(Action<int> onHeightChanged) => default; // 0x000000018BC00BD4-0x000000018BC00BDC
		private void _Awake_b__28_0() {} // 0x0000000183EC9810-0x0000000183EC9820
		public void __iFixBaseProxy_SendOnFocus() {} // 0x000000018BC00BA4-0x000000018BC00BAC
		public void __iFixBaseProxy_SendOnFocusLost() {} // 0x00000001814A81B0-0x00000001814A81C0
		public void __iFixBaseProxy_Awake() {} // 0x000000018BC00BAC-0x000000018BC00BB4
		public void __iFixBaseProxy_OnSelect(BaseEventData P0) {} // 0x000000018BBD59E8-0x000000018BBD59F0
		public void __iFixBaseProxy_OnDeselect(BaseEventData P0) {} // 0x000000018BC00BC4-0x000000018BC00BCC
		public void __iFixBaseProxy_OnUpdateSelected(BaseEventData P0) {} // 0x000000018BC00BBC-0x000000018BC00BC4
		public void __iFixBaseProxy_ActivateInputField() {} // 0x000000018BBF36E4-0x000000018BBF36EC
		public bool __iFixBaseProxy_TryActivateInputFieldCustom() => default; // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_DeactivateInputField(bool P0) {} // 0x0000000181378230-0x0000000181378240
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000183EC81E0-0x0000000183EC8280
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000181377E40-0x0000000181377E50
		public void __iFixBaseProxy__NotifyIsHover(bool P0) {} // 0x0000000183EC8280-0x0000000183EC82D0
		public void __iFixBaseProxy_OnInteractableChanged() {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class UIJoystick : MonoBehaviour, IBeginDragHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler, IUIClearable, IBindingGroupTarget // TypeDefIndex: 50288
	{
		// Fields
		private RectTransform _runBg; // 0x18
		private RectTransform _walkBg; // 0x20
		private RectTransform _thumb; // 0x28
		private RectTransform _directionIndicate; // 0x30
		private RectTransform _walkDirectionIndicate; // 0x38
		private RectTransform _rootCanvas; // 0x40
		private RectTransform _triggerArea; // 0x48
		private GraphicRaycaster _raycaster; // 0x50
		private float _walkRation; // 0x58
		private float _autoSprintStartLength; // 0x5C
		private float _autoSprintStopLength; // 0x60
		private float _autoSprintStartAngle; // 0x64
		private float _autoSprintStopAngle; // 0x68
		public float margin; // 0x6C
		public float bgVisibleTimeWhenEnable; // 0x70
		private float m_bgHideTime; // 0x74
		private bool _isDynamic; // 0x78
		private LuaPanel m_panel; // 0x80
		private Vector2 _jsValue_k__BackingField; // 0x88
		private UITouchPanel _dynamicArea; // 0x90
		private bool _dynamicButDontMove; // 0x98
		private bool _useRewiredPlayerInput; // 0x99
		private string _controllerRewiredActionX; // 0xA0
		private string _controllerRewiredActionY; // 0xA8
		private KeyboardKeyCode _keyboardUp; // 0xB0
		private KeyboardKeyCode _keyboardDown; // 0xB4
		private KeyboardKeyCode _keyboardLeft; // 0xB8
		private KeyboardKeyCode _keyboardRight; // 0xBC
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
		private PointerEventData _curDragEventData_k__BackingField; // 0x170
		private int m_groupId; // 0x178
		private bool m_bindingInit; // 0x17C
		private InputBindingGroupMonoTarget _parent_k__BackingField; // 0x180
	
		// Properties
		public LuaPanel panel { get => default; } // 0x000000018BC01710-0x000000018BC017D4 
		public bool isDynamic { get => default; set {} } // 0x0000000185FB0DA0-0x0000000185FB0DB0 0x000000018BC017D4-0x000000018BC017E0
		public float walkRation { get => default; set {} } // 0x0000000181DE2580-0x0000000181DE2590 0x0000000184B5D120-0x0000000184B5D180
		public bool active { get => default; } // 0x0000000185FB9C20-0x0000000185FB9C30 
		public int activeTouchId { get => default; } // 0x000000018BC016D8-0x000000018BC016F4 
		public Vector2 jsValue { get; private set; } // 0x0000000185FCA370-0x0000000185FCA390 0x0000000185FB02A0-0x0000000185FB02B0
		private float m_thumbPosMaxLength { get => default; } // 0x000000018467A850-0x000000018467A8B0 
		public PointerEventData curDragEventData { get; private set; } // 0x0000000185FB88C0-0x0000000185FB88D0 0x0000000186473504-0x0000000186473518
		public bool groupEnabled { get => default; } // 0x000000018467A570-0x000000018467A5D0 
		public bool shouldCheckInput { get => default; } // 0x000000018467A500-0x000000018467A570 
		public int groupId { get => default; } // 0x000000018BC016F4-0x000000018BC01710 
		public IBindingGroupTarget parentTarget { get => default; } // 0x0000000185FB8280-0x0000000185FB8290 
		public InputBindingGroupMonoTarget parent { get; private set; } // 0x0000000185FB8280-0x0000000185FB8290 0x000000018647352C-0x0000000186473540
	
		// Constructors
		public UIJoystick() {} // 0x0000000184817E70-0x0000000184819880
	
		// Methods
		private void Reset() {} // 0x000000018BC01514-0x000000018BC015E4
		private void Awake() {} // 0x0000000184B5D9F0-0x0000000184B5E070
		protected void OnEnable() {} // 0x0000000185D71160-0x0000000185D71290
		private void Start() {} // 0x0000000185F07170-0x0000000185F07220
		protected void OnDestroy() {} // 0x000000018BC0115C-0x000000018BC0138C
		private void _Tick() {} // 0x0000000184678540-0x000000018467A500
		protected void OnDisable() {} // 0x000000018BC0138C-0x000000018BC01514
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000184B5D6C0-0x0000000184B5D800
		public void OnPointerUp(PointerEventData eventData) {} // 0x0000000185A82990-0x0000000185A82AF0
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000185EF5460-0x0000000185EF54B0
		public void OnDrag(PointerEventData eventData) {} // 0x000000018467A5D0-0x000000018467A850
		public void CheckShouldActive() {} // 0x0000000184FC38B0-0x0000000184FC3EB0
		private void _SetVisible(bool visible) {} // 0x0000000184B5D660-0x0000000184B5D6C0
		private void _ChangeDynamic(bool dynamic, bool force = false /* Metadata: 0x02061D60 */) {} // 0x0000000184B5D350-0x0000000184B5D4A0
		private void _SetRectTransform(bool toOri) {} // 0x0000000184B5D8D0-0x0000000184B5D9F0
		private void _UpdateWalkBgScale() {} // 0x0000000184B5D180-0x0000000184B5D350
		private void _Activate(bool fromTouch, Vector2 showPos, Vector2 initJsValue) {} // 0x0000000184B5D800-0x0000000184B5D8D0
		private void _UpdateGait() {} // 0x000000018467A8B0-0x000000018467A980
		private void _UpdateIndicator() {} // 0x000000018467AB90-0x000000018467AD60
		private void _UpdateBg() {} // 0x000000018467A980-0x000000018467AA60
		private void _SetWalkBgVisible(bool visible, bool ignoreAnim = false /* Metadata: 0x02061D61 */) {} // 0x000000018467AA60-0x000000018467AAE0
		private void _SetRunBgVisible(bool visible, bool ignoreAnim = false /* Metadata: 0x02061D62 */) {} // 0x000000018467AAE0-0x000000018467AB90
		private void _OnHudLayoutLoaded(in EventData<string> eventData) {} // 0x000000018BC015E4-0x000000018BC016D8
		public void ClearComponent() {} // 0x000000018BC01054-0x000000018BC0115C
		public void InitBinding() {} // 0x00000001849D90D0-0x00000001849D9230
		private void _UpdateState() {} // 0x0000000185DAD7A0-0x0000000185DAD960
		private void _Awake_b__76_0(Vector2 _) {} // 0x0000000183ECA6A0-0x0000000183ECAA10
	}

	public class UILayoutDimensionListener : UIBehaviour, IHotfixable, ICanvasElement // TypeDefIndex: 50291
	{
		// Fields
		private ListSet<IAction> m_actionsWhenLayoutReady; // 0x18
		[NonSerialized]
		public DisposedUnityEvent eventOnPostLayout; // 0x20
	
		// Properties
		Transform ICanvasElement.transform { get => default; } // 0x000000018BBFCA10-0x000000018BBFCA68 
	
		// Nested types
		public interface IAction // TypeDefIndex: 50289
		{
			// Methods
			void DoAction(); // 0x000000018BC01870-0x000000018BC018B4
		}
	
		private sealed class __NextFrameCoroutine_d__6 : IEnumerator<object> // TypeDefIndex: 50290
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UILayoutDimensionListener __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BC017E0-0x000000018BC01870 
			object IEnumerator.Current { get => default; } // 0x000000018BC019E0-0x000000018BC01A30 
	
			// Constructors
			public __NextFrameCoroutine_d__6() {} // Dummy constructor
			public __NextFrameCoroutine_d__6(int __1__state) {} // 0x000000018BC018B4-0x000000018BC018F8
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BC01A30-0x000000018BC01AB0
			private bool MoveNext() => default; // 0x000000018BC01D14-0x000000018BC01DA4
			void IEnumerator.Reset() {} // 0x000000018BC01990-0x000000018BC019E0
		}
	
		// Constructors
		public UILayoutDimensionListener() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void GraphicUpdateComplete() {} // 0x000000018BC018F8-0x000000018BC01990
		public void LayoutComplete() {} // 0x000000018BC01DA4-0x000000018BC01E30
		public void Rebuild(CanvasUpdate executing) {} // 0x000000018BC01B00-0x000000018BC01D14
		private IEnumerator _NextFrameCoroutine() => default; // 0x0000000185F60420-0x0000000185F604E0
		public void DoOnceOnPostLayout(IAction action) {} // 0x000000018BC01AB0-0x000000018BC01B00
		protected override void OnEnable() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnRectTransformDimensionsChange() {} // 0x0000000185492010-0x0000000185492020
		protected override void OnDestroy() {} // 0x0000000185492010-0x0000000185492020
		private void _SetDirty() {}
		private void _InvokePostLayoutCallback() {} // 0x0000000181378230-0x0000000181378240
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000181377E40-0x0000000181377E50
		public void __iFixBaseProxy_OnRectTransformDimensionsChange() {} // 0x000000018BBFCA68-0x000000018BBFCAB4
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class UILeftSubtitle : TickableUIMono // TypeDefIndex: 50292
	{
		// Fields
		private UIDialogTextWithCursor _dialogText1; // 0x68
		private UIDialogTextWithCursor _dialogText2; // 0x70
		private UIDialogTextWithCursor _dialogText3; // 0x78
		private UIDialogTextWithCursor _dialogText4; // 0x80
		private UIAnimationWrapper _panelAnimation; // 0x88
		private int m_maxDisplayIndex; // 0x90
		private readonly List<UIDialogTextWithCursor> m_dialogTextList; // 0x98
		private bool m_isDisplaying; // 0xA0
		private float m_currTime; // 0xA4
		private float m_textStayTime; // 0xA8
		private bool m_isAutoPlay; // 0xAC
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public UILeftSubtitle() {} // 0x000000018BC0263C-0x000000018BC026D0
	
		// Methods
		public override void Tick(float deltaTime) {} // 0x000000018BC02478-0x000000018BC02530
		public void StartAutoPlay(float textStayTime) {} // 0x000000018BC02408-0x000000018BC02478
		public void SetLeftSubTitle(string text1, string text2, string text3, string text4) {} // 0x000000018BC01F28-0x000000018BC02398
		public float UpdateByPlayTime(float currTime) => default; // 0x000000018BC0253C-0x000000018BC0263C
		public void Exit() {} // 0x000000018BC01E30-0x000000018BC01F28
		public void SetVisible(bool visible) {} // 0x000000018BC02398-0x000000018BC02408
		private void _Exit_b__17_0() {} // 0x000000018BC02530-0x000000018BC0253C
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UIMaterialAnimation : TickableUIMono // TypeDefIndex: 50293
	{
		// Fields
		private MaskableGraphic _maskableGraphic; // 0x68
		private Material _material; // 0x70
		private string _propertiesName1; // 0x78
		private float _propertiesSet1; // 0x80
		private string _propertiesName2; // 0x88
		private float _propertiesSet2; // 0x90
		private string _propertiesName3; // 0x98
		private float _propertiesSet3; // 0xA0
		private string _propertiesName4; // 0xA8
		private float _propertiesSet4; // 0xB0
		private string _propertiesName5; // 0xB8
		private float _propertiesSet5; // 0xC0
		private string _propertiesName6; // 0xC8
		private float _propertiesSet6; // 0xD0
		private string _propertiesName7; // 0xD8
		private float _propertiesSet7; // 0xE0
		private string _propertiesName8; // 0xE8
		private float _propertiesSet8; // 0xF0
		private string _propertiesName9; // 0xF8
		private float _propertiesSet9; // 0x100
		private string _propertiesName10; // 0x108
		private float _propertiesSet10; // 0x110
		private string _propertiesVectorName1; // 0x118
		private Vector4 _propertiesVector1; // 0x120
		private string _propertiesVectorName2; // 0x130
		private Vector4 _propertiesVector2; // 0x138
		private string _propertiesVectorName3; // 0x148
		private Vector4 _propertiesVector3; // 0x150
		private string _propertiesVectorName4; // 0x160
		private Vector4 _propertiesVector4; // 0x168
		private string _propertiesVectorName5; // 0x178
		private Vector4 _propertiesVector5; // 0x180
		private string _propertiesColorName1; // 0x190
		private UnityEngine.Color _propertiesColor1; // 0x198
		private string _propertiesColorName2; // 0x1A8
		private UnityEngine.Color _propertiesColor2; // 0x1B0
		private string _propertiesColorName3; // 0x1C0
		private UnityEngine.Color _propertiesColor3; // 0x1C8
		private Material m_matIns; // 0x1D8
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Constructors
		public UIMaterialAnimation() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x0000000184246590-0x0000000184246630
		protected override void OnAwake() {} // 0x0000000184513D80-0x0000000184513EC0
		protected override void OnRelease() {} // 0x0000000185C2CAB0-0x0000000185C2CB60
		private void _TryUpdate() {} // 0x0000000184246630-0x0000000184246C00
		public void ForceUpdate() {} // 0x000000018BC026D0-0x000000018BC028C0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
	}

	public class UINonUnifiedScrollList : UIScrollList // TypeDefIndex: 50295
	{
		// Fields
		public GetCellSizeMode getCellSizeMode; // 0x278
		private bool _recalculateAfterSizeChange; // 0x27C
		private bool _forceUpdateCellSizeCache; // 0x27D
		public Func<int, int> getSubCellCount; // 0x280
		public Func<int, float> getCellSize; // 0x288
		[NonSerialized]
		public float overrideContainSize; // 0x290
		private GridLayoutGroup m_templateCellGridLayoutGroup; // 0x298
		private Dictionary<int, float> m_cellSizeCache; // 0x2A0
		private int m_containerTopIndex; // 0x2A8
		private const float CONTAINER_SIZE_BUFFER = 50f; // Metadata: 0x02061D75
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
		public override float currentStep { get => default; set {} } // 0x000000018BC05808-0x000000018BC059C0 0x000000018BC059C0-0x000000018BC059EC
	
		// Nested types
		public enum GetCellSizeMode // TypeDefIndex: 50294
		{
			ByGetCellSizeFunc = 0,
			ByLayoutGroup = 1,
			GetAfterCellCreated = 2
		}
	
		// Constructors
		public UINonUnifiedScrollList() {} // 0x0000000185DB00A0-0x0000000185DB01B0
	
		// Methods
		protected override void InitBasicInfo() {} // 0x000000018BC03E18-0x000000018BC03EE0
		protected override void CalcSomeCountNum() {} // 0x000000018BC02914-0x000000018BC0297C
		protected override float GetLeftLength(bool checkVertical, int checkCount = -1 /* Metadata: 0x02061D63 */) => default; // 0x000000018BC03614-0x000000018BC036CC
		public override void UpdateCount(int newCount) {} // 0x000000018BC052FC-0x000000018BC05370
		public override void UpdateCount(int newCount, bool setTop, bool forceRecalculate = false /* Metadata: 0x02061D64 */, bool onlyUpdateNewCellContent = false /* Metadata: 0x02061D65 */, bool skipGraduallyShow = false /* Metadata: 0x02061D66 */) {} // 0x000000018BC0501C-0x000000018BC050DC
		public override void UpdateCount(int newCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x02061D67 */, bool onlyUpdateNewCellContent = false /* Metadata: 0x02061D68 */, bool skipGraduallyShow = false /* Metadata: 0x02061D69 */, ScrollAlignType alignType = ScrollAlignType.Top /* Metadata: 0x02061D6A */) {} // 0x000000018BC050DC-0x000000018BC052FC
		public override void LateTick(float deltaTime) {} // 0x000000018BC03EE0-0x000000018BC03F5C
		protected override void OnScroll(Vector2 v) {} // 0x000000018BC040F4-0x000000018BC0417C
		public static Vector2 GetGridLayoutSize(GridLayoutGroup grid, int count) => default; // 0x000000018BC032B4-0x000000018BC03494
		private float _GetCellSize(int index) => default; // 0x000000018BC053CC-0x000000018BC05738
		protected override float GetContainerSize(bool ignoreAutoLayout = false /* Metadata: 0x02061D6B */) => default; // 0x000000018BC02E44-0x000000018BC032B4
		public override float GetCenterIndex() => default; // 0x000000018BC02C58-0x000000018BC02E44
		public override Vector2Int GetShowRange(float bufferSize = 0f /* Metadata: 0x02061D6C */, bool ignoreGraduallyShow = false /* Metadata: 0x02061D70 */) => default; // 0x000000018BC03994-0x000000018BC03C10
		protected override Vector2Int GetNotCacheRange() => default; // 0x000000018BC03758-0x000000018BC03830
		protected override void MoveCellTo(Cell cell, int index) {} // 0x000000018BC03F5C-0x000000018BC04028
		protected override void OnUpdateCell(Cell cell, int index) {} // 0x000000018BC0417C-0x000000018BC043F8
		protected override float GetTargetPosByIndex(int index, ScrollAlignType alignType = ScrollAlignType.Top /* Metadata: 0x02061D71 */) => default; // 0x000000018BC03C10-0x000000018BC03E18
		private float _GetCellsSizeTo(int index) => default; // 0x000000018BC05738-0x000000018BC05808
		protected override void ScrollTo(int index, bool fastMode = false /* Metadata: 0x02061D72 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02061D73 */) {} // 0x000000018BC043F8-0x000000018BC04688
		public override void ClearComponent() {} // 0x000000018BC0297C-0x000000018BC02A28
		public override void SetStepTo(float step) {} // 0x000000018BC04908-0x000000018BC0497C
		public void SetCurrentStep(float currentStep) {} // 0x000000018BC04688-0x000000018BC04870
		public float GetScrollBarSize() => default; // 0x000000018BC03830-0x000000018BC03994
		public float GetLastScrollStep() => default; // 0x000000018BC03494-0x000000018BC03614
		public void UpdateLastScrollStep() {} // 0x000000018BC05370-0x000000018BC053CC
		public float GetNormalizedPosition() => default; // 0x000000018BC036CC-0x000000018BC03758
		public void SetNormalizedPosition(float normalizedPosition) {} // 0x000000018BC04870-0x000000018BC04908
		public void ToggleByState(int index, bool isFoldOut, bool fastMode) {} // 0x000000018BC0497C-0x000000018BC04B60
		public void Toggle(int index, bool fastMode = false /* Metadata: 0x02061D74 */) {} // 0x000000018BC04B60-0x000000018BC04D88
		public void FoldAll(bool isFoldOut) {} // 0x000000018BC02A28-0x000000018BC02C58
		public void NotifyCellSizeChange(int index, float size) {} // 0x000000018BC04028-0x000000018BC040F4
		private void _GetScrollBarSize_g__RecalculateAverageCellSize_43_0() {} // 0x000000018BC04D88-0x000000018BC04F54
		public void __iFixBaseProxy_InitBasicInfo() {} // 0x000000018BC04F94-0x000000018BC04F9C
		public void __iFixBaseProxy_CalcSomeCountNum() {} // 0x000000018BC04F54-0x000000018BC04F5C
		public float __iFixBaseProxy_GetLeftLength(bool P0, int P1) => default; // 0x000000018BC04F74-0x000000018BC04F7C
		public void __iFixBaseProxy_UpdateCount(int P0) {} // 0x000000018BC0500C-0x000000018BC05014
		public void __iFixBaseProxy_UpdateCount(int P0, bool P1, bool P2, bool P3, bool P4) {} // 0x000000018BC04FEC-0x000000018BC0500C
		public void __iFixBaseProxy_UpdateCount(int P0, int P1, bool P2, bool P3, bool P4, ScrollAlignType P5) {} // 0x000000018BC04FCC-0x000000018BC04FEC
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018BC04F9C-0x000000018BC04FA4
		public void __iFixBaseProxy_OnScroll(Vector2 P0) {} // 0x000000018BC04FA4-0x000000018BC04FAC
		public float __iFixBaseProxy_GetContainerSize(bool P0) => default; // 0x000000018BC04F6C-0x000000018BC04F74
		public float __iFixBaseProxy_GetCenterIndex() => default; // 0x000000018BC04F64-0x000000018BC04F6C
		public Vector2Int __iFixBaseProxy_GetShowRange(float P0, bool P1) => default; // 0x000000018BC04F84-0x000000018BC04F8C
		public Vector2Int __iFixBaseProxy_GetNotCacheRange() => default; // 0x000000018BC04F7C-0x000000018BC04F84
		public void __iFixBaseProxy_MoveCellTo(Cell P0, int P1) {} // 0x000000018BBEA818-0x000000018BBEA820
		public void __iFixBaseProxy_OnUpdateCell(Cell P0, int P1) {} // 0x000000018BC04FAC-0x000000018BC04FB4
		public float __iFixBaseProxy_GetTargetPosByIndex(int P0, ScrollAlignType P1) => default; // 0x000000018BC04F8C-0x000000018BC04F94
		public void __iFixBaseProxy_ScrollTo(int P0, bool P1, ScrollAlignType P2) {} // 0x000000018BC04FB4-0x000000018BC04FC4
		public void __iFixBaseProxy_ClearComponent() {} // 0x000000018BC04F5C-0x000000018BC04F64
		public float __iFixBaseProxy_get_currentStep() => default; // 0x000000018BC05014-0x000000018BC0501C
		public void __iFixBaseProxy_SetStepTo(float P0) {} // 0x000000018BC04FC4-0x000000018BC04FCC
	}

	public class UINonUnifiedScrollRect : UIScrollRect // TypeDefIndex: 50296
	{
		// Fields
		private bool m_isInited; // 0x1D8
		private bool m_isRebuilding; // 0x1D9
		private UINonUnifiedScrollList m_scrollList; // 0x1E0
		private UILayoutDimensionListener m_dimensionListener; // 0x1E8
	
		// Constructors
		public UINonUnifiedScrollRect() {} // 0x0000000184819B00-0x0000000184819B10
	
		// Methods
		private void _InitIfNot() {} // 0x000000018BC05DD0-0x000000018BC05F18
		protected override void UpdateScrollbars(Vector2 offset) {} // 0x000000018BC05CEC-0x000000018BC05DD0
		public override void Rebuild(CanvasUpdate executing) {} // 0x000000018BC059EC-0x000000018BC05A5C
		private void _UpdateNonUnifiedScrollbars() {} // 0x000000018BC05FD0-0x000000018BC06148
		protected override void SetHorizontalNormalizedPosition(float value) {} // 0x000000018BC05A5C-0x000000018BC05B9C
		protected override void SetVerticalNormalizedPosition(float value) {} // 0x000000018BC05B9C-0x000000018BC05CDC
		private void _OnPostLayout() {} // 0x000000018BC05F18-0x000000018BC05FD0
		public void __iFixBaseProxy_UpdateScrollbars(Vector2 P0) {} // 0x000000018BC05CE4-0x000000018BC05CEC
		public void __iFixBaseProxy_Rebuild(CanvasUpdate P0) {} // 0x000000018BC05CDC-0x000000018BC05CE4
		public void __iFixBaseProxy_SetHorizontalNormalizedPosition(float P0) {} // 0x00000001864716EC-0x00000001864716F8
		public void __iFixBaseProxy_SetVerticalNormalizedPosition(float P0) {} // 0x0000000186475090-0x00000001864750A0
	}

	public class UINumberScrollTween : TickableUIMono // TypeDefIndex: 50297
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
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
		public string tweenToText { get => default; set {} } // 0x000000018140CF50-0x000000018140CF60 0x000000018BC066A8-0x000000018BC066B0
		public string text { get => default; set {} } // 0x000000018BC06540-0x000000018BC065F4 0x000000018BC065F4-0x000000018BC066A8
	
		// Constructors
		public UINumberScrollTween() {} // 0x000000018BC064F4-0x000000018BC06540
	
		// Methods
		private void Start() {} // 0x000000018BC06148-0x000000018BC061D8
		public override void Tick(float deltaTime) {} // 0x000000018BC061D8-0x000000018BC062A8
		private void _TweenToTarget(string targetText) {} // 0x000000018BC063F0-0x000000018BC064F4
		private void _CleanupBeforeTween() {} // 0x000000018BC062A8-0x000000018BC062F8
		private void _HandleNumberScrollTween(float fromNumber, float toNumber, float curTime) {} // 0x000000018BC062F8-0x000000018BC063F0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UIPCScaleHelper : MonoBehaviour // TypeDefIndex: 50298
	{
		// Fields
		public Vector3 baseScale; // 0x18
	
		// Constructors
		public UIPCScaleHelper() {} // 0x00000001859CAD30-0x00000001859CAD50
	
		// Methods
		private void OnEnable() {} // 0x000000018592BE20-0x000000018592BF20
	}

	public class UIRawImage : RawImage // TypeDefIndex: 50299
	{
		// Constructors
		public UIRawImage() {} // 0x0000000184B37DD0-0x0000000184B37DE0
	}

	public class UIRegionBuildingTexManager : MonoBehaviour // TypeDefIndex: 50300
	{
		// Fields
		private Shader _regionMapShader; // 0x18
		public Texture2D minimapOutlineTex; // 0x20
		private static int s_buildingOutlineTex; // 0x00
		private Renderer m_meshRenderer; // 0x28
		private static MaterialPropertyBlock s_materialPropertyBlock; // 0x08
	
		// Properties
		private static MaterialPropertyBlock materialPropertyBlock { get => default; } // 0x00000001855578E0-0x0000000185557A00 
	
		// Constructors
		public UIRegionBuildingTexManager() {} // 0x000000018646DB20-0x000000018646DB28
		static UIRegionBuildingTexManager() {} // 0x0000000185F81E70-0x0000000185F81EC0
	
		// Methods
		private void OnEnable() {} // 0x0000000185557590-0x0000000185557710
		private void OnValidate() {} // 0x000000018BC066B0-0x000000018BC067A0
		private void OnDisable() {} // 0x00000001855574B0-0x0000000185557590
		private void _UpdateTexture(Renderer meshRenderer, Shader minimapTerrainShader, Texture2D buildingTex) {} // 0x0000000185557710-0x00000001855578E0
	}

	public class UIScaleHolder : TickableUIMono // TypeDefIndex: 50301
	{
		// Fields
		private RectTransform m_rectTransform; // 0x68
		private RectTransform m_parentTransform; // 0x70
		private bool m_holdValid; // 0x78
		private Vector3 _extraScale; // 0x7C
		private bool _onlyHoldOnEnable; // 0x88
		public RectTransform referenceTransform; // 0x90
		public float animationExtraScale; // 0x98
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Constructors
		public UIScaleHolder() {} // 0x0000000184814FB0-0x0000000184814FE0
	
		// Methods
		protected override void OnAwake() {} // 0x000000018442FEE0-0x00000001844300B0
		protected override void OnEnable() {} // 0x00000001854679E0-0x0000000185467A20
		public override void LateTick(float deltaTime) {} // 0x0000000184C55840-0x0000000184C55930
		private bool _IsValidScale(Vector3 scale) => default; // 0x00000001840E6D60-0x00000001840E6E40
		private void _HoldScale() {} // 0x00000001840E6840-0x00000001840E6D60
		public void SetExtraScale(Vector3 extraScale) {} // 0x000000018BC067A0-0x000000018BC06824
		public Vector3 GetExtraScale() => default; // 0x0000000185350CB0-0x0000000185350D00
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class UIScrollbar : Scrollbar // TypeDefIndex: 50302
	{
		// Constructors
		public UIScrollbar() {} // 0x0000000184817E60-0x0000000184817E70
	
		// Methods
		protected override void Awake() {} // 0x0000000185F7AE40-0x0000000185F7AE80
		public void __iFixBaseProxy_Awake() {} // 0x000000018BBD59E0-0x000000018BBD59E8
	}

	public class UIScrollbarKeyHint : TickableUIMono // TypeDefIndex: 50303
	{
		// Fields
		private UIScrollRect m_scrollRect; // 0x68
		private UIImage m_image; // 0x70
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public UIScrollbarKeyHint() {} // 0x0000000184814DE0-0x0000000184814DF0
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BC0BFF4-0x000000018BC0C0A4
		public override void Tick(float deltaTime) {} // 0x000000018BC0C0A4-0x000000018BC0C32C
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UIScrollCircle : TickableUIMono, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, ICanvasElement, IUIClearable // TypeDefIndex: 50305
	{
		// Fields
		private GameObject _cellTemplate; // 0x68
		private int _totalNum; // 0x70
		private float _tweenTime; // 0x74
		private RectTransform m_Viewport; // 0x78
		private float m_Elasticity; // 0x80
		private float _speedFactor; // 0x84
		private int _count_k__BackingField; // 0x88
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
		protected override TickType tickOption { get => default; } // 0x0000000185FB8BD0-0x0000000185FB8BE0 
		public float elasticity { get => default; set {} } // 0x00000001834A1F30-0x00000001834A1F40 0x00000001834A2280-0x00000001834A2290
		public int count { get; set; } // 0x0000000185FB9BA0-0x0000000185FB9BB0 0x0000000185FBE100-0x0000000185FBE110
		public float velocity { get => default; set {} } // 0x000000018BC08538-0x000000018BC085FC 0x000000018BC085FC-0x000000018BC08734
		public LuaPanel panel { get => default; } // 0x000000018BC07070-0x000000018BC070DC 
		protected RectTransform viewRect { get => default; } // 0x000000018BC06984-0x000000018BC069D4 
		Transform ICanvasElement.transform { get => default; } // 0x000000018792FE0C-0x000000018792FE14 
	
		// Nested types
		public class Cell // TypeDefIndex: 50304
		{
			// Fields
			public GameObject gameObject; // 0x10
			public RectTransform rectTransform; // 0x18
			public GameObject realGameObject; // 0x20
	
			// Constructors
			public Cell() {} // 0x0000000185FB2E70-0x0000000185FB2E80
	
			// Methods
			public void SetSelect(bool select) {} // 0x0000000185FB6DA0-0x0000000185FB6DB0
		}
	
		// Constructors
		public UIScrollCircle() {} // 0x000000018BC07310-0x000000018BC07328
	
		// Methods
		public void OnInitializePotentialDrag(PointerEventData eventData) {} // 0x000000018BC06B68-0x000000018BC06CC8
		public virtual bool IsActive() => default; // 0x000000018BC07004-0x000000018BC07070
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BC06D20-0x000000018BC06F80
		public void OnEndDrag(PointerEventData eventData) {} // 0x000000018BC08308-0x000000018BC083C0
		public void OnDrag(PointerEventData eventData) {} // 0x000000018BC07434-0x000000018BC074B8
		private void _UpdateSpeed() {} // 0x000000018BC07D8C-0x000000018BC07E10
		private bool _CheckCanMove(float deltaAngle) => default; // 0x000000018BC07E10-0x000000018BC07F84
		private void _TryUpdateCells() {} // 0x000000018BC070DC-0x000000018BC0714C
		private void _UpdateAuto() {} // 0x000000018BC0769C-0x000000018BC07864
		protected override void OnRelease() {} // 0x000000018BC078D8-0x000000018BC07B84
		private float _GetDeltaAngle(Vector2 position) => default; // 0x000000018BC07B84-0x000000018BC07C78
		private void _InitCells() {} // 0x000000018BC07C78-0x000000018BC07D8C
		private void _Init() {} // 0x000000018BC080C0-0x000000018BC08128
		private void _OnAwakeInit() {} // 0x000000018BC07864-0x000000018BC078D8
		private void _UpdateScrollRange() {} // 0x000000018BC08128-0x000000018BC08308
		private int _GetRealIndex(int index) => default; // 0x000000018BC07F84-0x000000018BC080C0
		private void _UpdateShowingCells() {} // 0x000000018BC074B8-0x000000018BC0769C
		private void _UpdateCenterIndex(bool forceUpdate = false /* Metadata: 0x02061D7C */) {} // 0x000000018BC0714C-0x000000018BC071A0
		private void _DoScroll(float tmpAngle, bool direct = false /* Metadata: 0x02061D7D */) {} // 0x000000018BC071A0-0x000000018BC071F4
		public void OnScroll(PointerEventData eventData) {} // 0x000000018BC06AC8-0x000000018BC06B0C
		public void Rebuild(CanvasUpdate executing) {} // 0x000000018BC06940-0x000000018BC06984
		public void LayoutComplete() {} // 0x000000018BC069D4-0x000000018BC06A54
		public void GraphicUpdateComplete() {} // 0x000000018BC06F80-0x000000018BC07004
		public bool IsDestroyed() => default; // 0x000000018BC06CC8-0x000000018BC06D20
		protected override void OnEnable() {} // 0x000000018BC072C0-0x000000018BC07310
		protected override void OnDisable() {} // 0x000000018BC06B0C-0x000000018BC06B68
		protected void Start() {} // 0x000000018BC06A54-0x000000018BC06AC8
		protected override void OnAwake() {} // 0x000000018BC07378-0x000000018BC07434
		public override void LateTick(float deltaTime) {} // 0x000000018BC071F4-0x000000018BC072C0
		public void UpdateCount(int newCount, bool setTop = true /* Metadata: 0x02061D7E */) {} // 0x000000018BC06894-0x000000018BC06940
		public void ScrollToIndex(int index, bool direct = false /* Metadata: 0x02061D7F */) {} // 0x000000018BC06824-0x000000018BC06894
		public GameObject Get(int index) => default; // 0x000000018BC083C0-0x000000018BC08538
		public void ClearComponent() {} // 0x000000018BC07328-0x000000018BC07378
		private void __DoScroll_b__59_0() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_OnRelease() {} // 0x0000000187AAA404-0x0000000187AAA40C
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000187A742A0-0x0000000187A742A8
		public void __iFixBaseProxy_OnAwake() {} // 0x000000018BC028C0-0x000000018BC02914
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000185492010-0x0000000185492020
	}

	public class UIScrollContainerFollower : TickableUIMono // TypeDefIndex: 50306
	{
		// Fields
		private UIScrollList _followTargetList; // 0x68
		private UIScrollRect _followTargetRect; // 0x70
		private RectTransform m_rectTransform; // 0x78
		private float m_currentSize; // 0x80
		private bool m_targetSizeChanged; // 0x84
		private Vector2 m_currentPos; // 0x88
		private bool m_targetPosChanged; // 0x90
		private bool m_setValid; // 0x91
		private bool m_isFollowContent; // 0x92
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
	
		// Constructors
		public UIScrollContainerFollower() {} // 0x0000000185F51840-0x0000000185F51860
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BC089A0-0x000000018BC08A88
		public override void LateTick(float deltaTime) {} // 0x000000018BC08734-0x000000018BC089A0
		private void _RefreshSizeAndPositionToTargetContainer() {} // 0x000000018BC08A88-0x000000018BC08DCC
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public enum ScrollDirection // TypeDefIndex: 50307
	{
		Vertical = 0,
		Horizontal = 1
	}

	public class UIScrollList : TickableUIMono, IBeginDragHandler, IDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 50314
	{
		// Fields
		protected GameObject _cellTemplate; // 0x68
		private ScrollDirection _scrollDirection; // 0x70
		private bool _expandCellSize; // 0x74
		private bool _alsoExpandCellSizeInAnotherDirection; // 0x75
		protected Vector2 _space; // 0x78
		protected Padding _padding; // 0x80
		protected bool _ignorePaddingWhenScroll; // 0x90
		protected float _notCacheBufferSize; // 0x94
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
		protected bool _inverse; // 0xC8
		protected bool _autoLayoutWhenFew; // 0xC9
		protected AutoLayoutWhenFewType _autoLayoutWhenFewType; // 0xCC
		protected bool _autoCenterInOtherDir; // 0xD0
		private Transform _centerNode; // 0xD8
		private bool _hideRayCastWhenLessThanOnePage; // 0xE0
		private bool _clampWhenLessThanOnePage; // 0xE1
		private ScrollRect.MovementType m_lastScrollRectMovementType; // 0xE4
		protected RectTransform _container; // 0xE8
		protected UIScrollRect _scrollRect; // 0xF0
		private int _count_k__BackingField; // 0xF8
		private float _containerSizeWithoutAutoLayout_k__BackingField; // 0xFC
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
		private const string CACHED_CELL_GAME_OBJECT_NAME = "Cached"; // Metadata: 0x02061D9D
		[NonSerialized]
		public UnityEvent onBeginDrag; // 0x158
		[NonSerialized]
		public UnityEvent<PointerEventData> onDrag; // 0x160
		[NonSerialized]
		public UnityEvent onEndDrag; // 0x168
		private GameObject _moveTipsLeftOrTop; // 0x170
		private GameObject _moveTipsRightOrBottom; // 0x178
		private float m_moveTipsIgnoredRange; // 0x180
		private bool _useViewEffect; // 0x184
		private bool _symmetricViewEffect; // 0x185
		private bool _needDummyParent; // 0x186
		private AnimationCurve _viewEffectAnimation; // 0x188
		private Vector2 _effectAnchorPoint; // 0x190
		private bool _useDefaultScaleEffect; // 0x198
		private AnimationCurve _scaleEffectAnimation; // 0x1A0
		private bool _useDefaultArcEffect; // 0x1A8
		private AnimationCurve _arcEffectAnimation; // 0x1B0
		[NonSerialized]
		public UnityEvent<GameObject, int, float> onChangeView; // 0x1B8
		protected float _tweenDuration; // 0x1C0
		protected Ease _tweenEase; // 0x1C4
		protected float _changeStepRatio; // 0x1C8
		protected DG.Tweening.Tween m_adjustTween; // 0x1D0
		protected float m_totalLength; // 0x1D8
		protected float m_cellLength; // 0x1DC
		protected Vector2 m_centerPos; // 0x1E0
		public bool enableAutoScroll; // 0x1E8
		private float _startAutoScrollTime; // 0x1EC
		private float _autoScrollSpeed; // 0x1F0
		public UIArea autoScrollUpArea; // 0x1F8
		public UIArea autoScrollDownArea; // 0x200
		private float m_curAutoScrollSpd; // 0x208
		private int m_autoScrollTimerKey; // 0x20C
		private bool _enableGraduallyShow; // 0x210
		private float _graduallyShowTime; // 0x214
		private float _graduallyShowDelayTime; // 0x218
		protected bool m_inGraduallyShow; // 0x21C
		private float m_graduallyShowedMaxIndex; // 0x220
		protected float m_curGraduallyCanShowMaxIndex; // 0x224
		private bool m_needInformAnimationInEnd; // 0x228
		private const float GRADUALLY_SHOW_UPDATE_MAX_INTERVAL = 0.033333335f; // Metadata: 0x02061DA4
		public static int s_maxGraduallyShowAddCountPerFrame; // 0x08
		private bool _enableSelectedNavigation; // 0x229
		private bool _noNavigationKeyHint; // 0x22A
		private bool _enableNavigationLoop; // 0x22B
		private bool _customNavigationActionId; // 0x22C
		private string _customNavigationPreviousActionId; // 0x230
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
		protected bool _enableWrapNavigation; // 0x264
		protected bool _enableCircleWrapNavigation; // 0x265
		private bool _clearNaviGroupOnUpdateCount; // 0x266
		private List<Selectable> m_wrapNaviSelectables; // 0x268
		private LuaPanel m_panel; // 0x270
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB9C30-0x0000000185FB9C40 
		public Vector2 space { get => default; } // 0x0000000184A07BB0-0x0000000184A07BC0 
		public bool autoLayoutWhenFew { get => default; } // 0x0000000184A083A0-0x0000000184A083B0 
		public bool isHorizontal { get => default; } // 0x0000000185FCD270-0x0000000185FCD280 
		public bool isVertical { get => default; } // 0x0000000185FCD280-0x0000000185FCD290 
		public int count { get; protected set; } // 0x0000000185FB8C20-0x0000000185FB8C30 0x0000000185FB8C80-0x0000000185FB8C90
		public float containerSizeWithoutAutoLayout { get; private set; } // 0x0000000184A07CA0-0x0000000184A07CB0 0x0000000185FBEB60-0x0000000185FBEB70
		protected bool isMultiPage { get => default; } // 0x0000000185FBE070-0x0000000185FBE080 
		public int maxShowingCellCount { get => default; } // 0x0000000185FB9C00-0x0000000185FB9C10 
		public int countPerLine { get => default; } // 0x0000000185FB9100-0x0000000185FB9110 
		public float cellWidth { get => default; } // 0x0000000185D65B30-0x0000000185D65B70 
		public float cellHeight { get => default; } // 0x0000000184060CF0-0x0000000184060D50 
		public virtual float currentStep { get => default; set {} } // 0x000000018BC0AE2C-0x000000018BC0B058 0x000000018BC0A290-0x000000018BC0A2F8
		private MoveTipsType moveTips { get => default; } // 0x0000000184A073F0-0x0000000184A07A20 
		public int curSelectedIndex { get => default; protected set {} } // 0x000000018BC0BEEC-0x000000018BC0BF10 0x0000000185FD6D90-0x0000000185FD6DA0
		public GameObject curSelectedObj { get => default; } // 0x0000000185FBC540-0x0000000185FBC550 
		public bool enableSelectedNavigation { get => default; } // 0x0000000184B5E190-0x0000000184B5E320 
		public int naviBindingGroupId { get => default; } // 0x000000018BC0A1F8-0x000000018BC0A290 
		public LuaPanel panel { get => default; } // 0x000000018BC0A3EC-0x000000018BC0A5FC 
	
		// Nested types
		protected enum AutoLayoutWhenFewType // TypeDefIndex: 50308
		{
			Center = 0,
			LeftOrTop = 1,
			RightOrBottom = 2
		}
	
		public class Cell // TypeDefIndex: 50309
		{
			// Fields
			public GameObject gameObject; // 0x10
			public RectTransform rectTransform; // 0x18
			public UIAnimationWrapper animationWrapper; // 0x20
			public IUIFoldoutComp UIFoldoutComp; // 0x28
			public bool canCache; // 0x30
			public GameObject realGameObject; // 0x38
	
			// Constructors
			public Cell() {} // 0x0000000185FB6A10-0x0000000185FB6A20
		}
	
		private enum MoveTipsType // TypeDefIndex: 50310
		{
			None = 0,
			Higher = 1,
			Lower = 2,
			Both = 3
		}
	
		[Serializable]
		public struct Padding // TypeDefIndex: 50311
		{
			// Fields
			public float top; // 0x00
			public float left; // 0x04
			public float right; // 0x08
			public float bottom; // 0x0C
		}
	
		public enum ScrollAlignType // TypeDefIndex: 50312
		{
			Center = 0,
			Top = 1,
			Bottom = 2
		}
	
		public interface IScrollListNaviWrapper // TypeDefIndex: 50313
		{
			// Methods
			bool TryWrapNavigate(NaviDirection dir); // 0x0000000185FB9980-0x0000000185FB99A0
		}
	
		// Constructors
		public UIScrollList() {} // 0x000000018BC0B1DC-0x000000018BC0B200
		static UIScrollList() {} // 0x000000018BC0B200-0x000000018BC0B228
	
		// Methods
		protected override void OnAwake() {} // 0x000000018502BD70-0x000000018502BDC0
		public override void Tick(float deltaTime) {} // 0x0000000184060AC0-0x0000000184060B60
		public override void LateTick(float deltaTime) {} // 0x0000000184A05B40-0x0000000184A05C70
		protected override void OnEnable() {} // 0x000000018502BDC0-0x000000018502BEA0
		protected override void OnDisable() {} // 0x0000000184B5F8A0-0x0000000184B60CE0
		public void TryRecalculateSize() {} // 0x000000018BC0B368-0x000000018BC0B888
		private void _InGameAwake() {} // 0x0000000184A06A20-0x0000000184A06C30
		private void _EditorAwake() {} // 0x0000000184A06C30-0x0000000184A06D30
		protected virtual void Init(bool isPreview = false /* Metadata: 0x02061D82 */) {} // 0x0000000184A06210-0x0000000184A06250
		protected virtual void InitConfig() {} // 0x0000000184A06250-0x0000000184A064F0
		protected virtual void InitBasicInfo() {} // 0x0000000184A06F50-0x0000000184A06FD0
		protected void SyncViewSize() {} // 0x0000000184A06FD0-0x0000000184A07080
		protected virtual void CalcSomeCountNum() {} // 0x0000000184A07A20-0x0000000184A07A90
		private int _GetLineCount(bool calcVertical) => default; // 0x000000018BC0B058-0x000000018BC0B118
		protected virtual void OnScroll(Vector2 v) {} // 0x0000000184A05F50-0x0000000184A05FF0
		public virtual void SetTop(bool needUpdate = true /* Metadata: 0x02061D83 */) {} // 0x0000000184A064F0-0x0000000184A06750
		public virtual void UpdateCount(int newCount, bool setTop, bool forceRecalculate = false /* Metadata: 0x02061D84 */, bool onlyUpdateNewCellContent = false /* Metadata: 0x02061D85 */, bool skipGraduallyShow = false /* Metadata: 0x02061D86 */) {} // 0x0000000185FA56C0-0x0000000185FA5720
		public virtual void UpdateCount(int newCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x02061D87 */, bool onlyUpdateNewCellContent = false /* Metadata: 0x02061D88 */, bool skipGraduallyShow = false /* Metadata: 0x02061D89 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02061D8A */) {} // 0x0000000184A06810-0x0000000184A06990
		public virtual void UpdateCount(int newCount) {} // 0x0000000184A06750-0x0000000184A06810
		public void UpdateShowingCells(Action<int, GameObject> updateFunc) {} // 0x0000000184A06990-0x0000000184A06A20
		protected virtual float GetLeftLength(bool checkVertical, int checkCount = -1 /* Metadata: 0x02061D8B */) => default; // 0x0000000184A06D30-0x0000000184A06F10
		private void _SetRealPadding(bool isVerticalPadding, float firstAddedLength, float secondAddedLength) {} // 0x0000000184A07080-0x0000000184A07160
		protected void UpdateContainerSize() {} // 0x0000000184A07160-0x0000000184A07240
		protected virtual float GetContainerSize(bool ignoreAutoLayout = false /* Metadata: 0x02061D8C */) => default; // 0x0000000185B894B0-0x0000000185B89640
		protected void SetContainerSize(float size) {} // 0x0000000184A083B0-0x0000000184A0A690
		protected void ClearShowingCells() {} // 0x0000000184A07CB0-0x0000000184A07FB0
		protected virtual void UpdateShowingCells(bool forceUpdateContent, bool forceClearShowingCells = false /* Metadata: 0x02061D8D */, bool ignoreListActive = false /* Metadata: 0x02061D8E */) {} // 0x0000000184A081B0-0x0000000184A083A0
		protected void UpdateCell(int index, bool forceUpdateContent, bool ignoreListActive) {} // 0x000000018BC09344-0x000000018BC097F8
		public virtual Vector2Int GetShowRange(float bufferSize = 0f /* Metadata: 0x02061D8F */, bool ignoreGraduallyShow = false /* Metadata: 0x02061D93 */) => default; // 0x0000000184A07B70-0x0000000184A07BB0
		public virtual Vector2Int GetRangeInView() => default; // 0x0000000184A080C0-0x0000000184A081B0
		protected virtual Vector2Int GetNotCacheRange() => default; // 0x000000018BC0A6F0-0x000000018BC0A81C
		protected virtual void MoveCellTo(Cell cell, int index) {} // 0x00000001859A7770-0x00000001859A7810
		public void SetCellCanCache(int index, bool canCache) {} // 0x00000001845A8580-0x00000001845A8980
		protected virtual void OnUpdateCell(Cell cell, int index) {} // 0x000000018BC08E94-0x000000018BC08F64
		protected Cell GetCell() => default; // 0x000000018BC08DCC-0x000000018BC08E94
		protected void CacheShowingCell(int index) {} // 0x0000000184A07BC0-0x0000000184A07CA0
		protected void CacheCell(Cell cell) {} // 0x000000018BC0BFB8-0x000000018BC0BFF4
		public virtual void SetStepTo(float step) {} // 0x000000018BC0A2F8-0x000000018BC0A384
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BC0A384-0x000000018BC0A3EC
		public virtual void OnDrag(PointerEventData eventData) {} // 0x0000000184A07FB0-0x0000000184A080C0
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x0000000184A07A90-0x0000000184A07B70
		private void _UpdateMoveTips() {} // 0x000000018BC09934-0x000000018BC099F8
		public void UpdateViewEffect() {} // 0x000000018BC08F64-0x000000018BC0901C
		public GameObject Get(int index) => default; // 0x0000000184A06F10-0x0000000184A06F50
		protected Cell GetCell(int index) => default; // 0x0000000185F66970-0x0000000185F66A30
		protected int GetRealIndex(int index) => default; // 0x0000000185BA47B0-0x0000000185BA4900
		protected override void OnRelease() {} // 0x000000018BC0A81C-0x000000018BC0A894
		public virtual void ClearComponent() {} // 0x000000018BC0A984-0x000000018BC0A9FC
		public void SetPaddingBottom(float value) {} // 0x000000018BC0A90C-0x000000018BC0A984
		public void SetPaddingTop(float value) {} // 0x000000018BC0A894-0x000000018BC0A90C
		public void SetPaddingRight(float value) {} // 0x000000018BC0A9FC-0x000000018BC0AAF0
		public void SetPaddingLeft(float value) {} // 0x0000000185C1BD00-0x0000000185C1BD40
		public void SetPadding(Rect value) {} // 0x000000018BC097F8-0x000000018BC09934
		public Padding GetPadding() => default; // 0x000000018BC0AD74-0x000000018BC0AE2C
		public void GetShowingCellsIndexRange(out int firstIndex, out int lastIndex) {
			firstIndex = default;
			lastIndex = default;
		} // 0x000000018BC0A5FC-0x000000018BC0A6F0
		public void SetSpace(Vector2 newSpace) {} // 0x0000000184A05FF0-0x0000000184A06060
		public virtual void ScrollToIndex(int index, bool fastMode = false /* Metadata: 0x02061D94 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02061D95 */, bool graduallyShowInFastMode = false /* Metadata: 0x02061D96 */) {} // 0x0000000184A059D0-0x0000000184A05B40
		protected virtual void ScrollTo(int index, bool fastMode = false /* Metadata: 0x02061D97 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02061D98 */) {} // 0x0000000184A05C70-0x0000000184A05CB0
		private void _ScrollToPos(float targetPos, bool fastMode) {} // 0x00000001840DEF50-0x00000001840DF080
		protected void TryClearAdjustTween() {} // 0x0000000184A06060-0x0000000184A06210
		public virtual float GetCenterIndex() => default; // 0x0000000184B5E320-0x0000000184B5E450
		protected virtual float GetTargetPosByIndex(int index, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02061D99 */) => default; // 0x000000018BC0BBA8-0x000000018BC0BCD0
		private void _InitAutoScroll() {} // 0x000000018BC0BD74-0x000000018BC0BE18
		private void _OnEnterAutoScrollUp(PointerEventData eventData) {} // 0x000000018BC0BA80-0x000000018BC0BBA8
		private void _OnExitAutoScrollUp(PointerEventData eventData) {} // 0x000000018BC0BCD0-0x000000018BC0BD74
		private void _OnEnterAutoScrollDown(PointerEventData eventData) {} // 0x000000018BC0BE18-0x000000018BC0BE80
		private void _OnExitAutoScrollDown(PointerEventData eventData) {} // 0x0000000184060D50-0x0000000184060DB0
		private void _SetAutoScrollSpd(float spd) {} // 0x0000000185B89430-0x0000000185B894B0
		private void _UpdateAutoScroll(float deltaTime) {} // 0x000000018504CA20-0x000000018504CB30
		protected void RestartGraduallyShow() {} // 0x0000000184060DB0-0x0000000184060F30
		private void _StartGraduallyShow() {} // 0x000000018BC0B118-0x000000018BC0B174
		private void _UpdateGraduallyShow(float deltaTime) {} // 0x000000018504C850-0x000000018504CA20
		public void SkipGraduallyShow() {} // 0x000000018BC0BE80-0x000000018BC0BEEC
		public void StopGraduallyShow() {} // 0x000000018BC0BF10-0x000000018BC0BFB8
		private void _InitNavigation() {} // 0x000000018BC091F4-0x000000018BC09344
		public void NavigateSelected(NaviDirection dir) {} // 0x000000018BC09150-0x000000018BC091F4
		public int GetNaviOffset(NaviDirection dir) => default; // 0x000000018BC0AAF0-0x000000018BC0AD74
		public int GetNaviNewIndex(int oldIndex, NaviDirection dir) => default; // 0x000000018BC099F8-0x000000018BC0A1F8
		public void SetSelectedIndex(int index, bool needNotify = true /* Metadata: 0x02061D9A */, bool forceUpdate = false /* Metadata: 0x02061D9B */, bool needScroll = false /* Metadata: 0x02061D9C */) {} // 0x0000000184B5E450-0x0000000184B5E520
		public void ListWrapNavigate(NaviDirection dir) {} // 0x000000018BC0B2B0-0x000000018BC0B368
		private void _InitControllerNavi() {} // 0x000000018504CB30-0x000000018504CBE0
		private void _ClearRelatedNaviGroup() {} // 0x000000018BC0909C-0x000000018BC09150
		public int GetMousePosIndex(NaviDirection dir) => default; // 0x000000018BC0B888-0x000000018BC0BA80
		public int ScreenPos2Index(Vector2 targetScreenPos, NaviDirection dir) => default; // 0x000000018BC0901C-0x000000018BC0909C
		private void _GetScreenPosLineColumnInfo(Vector2 targetScreenPos, out int line, out int column) {
			line = default;
			column = default;
		} // 0x0000000184816750-0x0000000184816C70
		public int GetIndexOf(int column, int line) => default; // 0x0000000185F13660-0x0000000185F13710
		private float __ScrollToPos_b__158_0() => default; // 0x000000018BC0B228-0x000000018BC0B264
		private void __ScrollToPos_b__158_1(float x) {} // 0x000000018BC0B264-0x000000018BC0B288
		private void __ScrollToPos_b__158_2() {} // 0x000000018BC0B288-0x000000018BC0B2B0
		private float __ScrollToPos_b__158_3() => default; // 0x000000018BC0B228-0x000000018BC0B264
		private void __ScrollToPos_b__158_4(float y) {} // 0x000000018BC0B1C4-0x000000018BC0B1DC
		private void __ScrollToPos_b__158_5() {} // 0x000000018BC0B1B4-0x000000018BC0B1C4
		private void __OnEnterAutoScrollUp_b__171_0() {} // 0x000000018BC0B174-0x000000018BC0B184
		private void __OnEnterAutoScrollDown_b__173_0() {} // 0x000000018BC0B184-0x000000018BC0B194
		private void __InitNavigation_b__212_0() {} // 0x000000018BC0B194-0x000000018BC0B1A4
		private void __InitNavigation_b__212_1() {} // 0x000000018BC0B1A4-0x000000018BC0B1B4
		private void __InitNavigation_b__212_2() {} // 0x000000018BC0B194-0x000000018BC0B1A4
		private void __InitNavigation_b__212_3() {} // 0x000000018BC0B1A4-0x000000018BC0B1B4
		private void __InitNavigation_b__212_4() {} // 0x000000018BC0B174-0x000000018BC0B184
		private void __InitNavigation_b__212_5() {} // 0x000000018BC0B184-0x000000018BC0B194
		private void __InitNavigation_b__212_6() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		private void __InitNavigation_b__212_7() {} // 0x000000018311B6C0-0x000000018311B6D0
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187A742A0-0x0000000187A742A8
		public void __iFixBaseProxy_Tick(float P0) {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187AAA404-0x0000000187AAA40C
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018792FE0C-0x000000018792FE14
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000185FB7E70-0x0000000185FB7E80
		public void __iFixBaseProxy_OnRelease() {}
	}

	public enum AutoScrollStrategy // TypeDefIndex: 50315
	{
		None = 0,
		AlignNearbyBound = 1,
		AlignCenter = 2
	}

	public class UIScrollRect : ScrollRect, IUIClearable // TypeDefIndex: 50318
	{
		// Fields
		private TweenerCore<Vector2, Vector2, VectorOptions> m_scrollTween; // 0x150
		public float smoothScrollTweenSpd; // 0x158
		public Ease smoothScrollTweenEase; // 0x15C
		public float smoothScrollTweenMaxDur; // 0x160
		private bool m_lastUpdateIsDragging; // 0x164
		private LuaPanel m_panel; // 0x168
		protected float _stickScrollSpeed; // 0x170
		protected float _stickScrollTolerance; // 0x174
		protected UISelectableNaviGroup _naviGroup; // 0x178
		protected bool _enableWrapNavigation; // 0x180
		protected InputBindingGroupMonoTarget _scrollBindingGroup; // 0x188
		[NonSerialized]
		public bool controllerScrollEnabled; // 0x190
		private bool m_controllerInited; // 0x191
		private bool m_navigationWrapped; // 0x192
		protected AutoScrollStrategy _autoScrollStrategy; // 0x194
		protected float _alignBoundPaddingX; // 0x198
		protected float _alignBoundPaddingY; // 0x19C
		private GameObject _moveTipsLeftOrTop; // 0x1A0
		private GameObject _moveTipsRightOrBottom; // 0x1A8
		private Camera m_fallbackUICamera; // 0x1B0
		private bool _enableOverScrollEffect; // 0x1B8
		private float _overScrollTriggerValue; // 0x1BC
		private GameObject _overScrollEffectPrevNode; // 0x1C0
		private GameObject _overScrollEffectNextNode; // 0x1C8
		[NonSerialized]
		public DisposedUnityEvent<bool> onOverScrollEffect; // 0x1D0
	
		// Properties
		public bool inScrollTween { get => default; } // 0x0000000184B5E9B0-0x0000000184B5F8A0 
		public Vector2 contentStartPosition { get => default; set {} } // 0x00000001854F9CA0-0x00000001854F9CE0 0x0000000184E52380-0x0000000184E523D0
		public bool dragging { get => default; } // 0x000000018BC10510-0x000000018BC105D4 
		public bool controllerStickScrollEnabled { get => default; } // 0x0000000184E523D0-0x0000000184E52490 
		public LuaPanel panel { get => default; } // 0x0000000184549610-0x00000001845496E0 
		public UISelectableNaviGroup naviGroup { get => default; } // 0x000000018BC0FBBC-0x000000018BC0FE58 
		private MoveTipsType moveTips { get => default; } // 0x000000018560C650-0x000000018560C6B0 
	
		// Nested types
		private enum MoveTipsType // TypeDefIndex: 50316
		{
			None = 0,
			Higher = 1,
			Lower = 2,
			Both = 3
		}
	
		private sealed class __c__DisplayClass15_0 // TypeDefIndex: 50317
		{
			// Fields
			public Vector2 contentPos; // 0x10
			public UIScrollRect __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass15_0() {} // 0x000000018BC1035C-0x000000018BC103D0
	
			// Methods
			internal Vector2 __CustomSetPosOnScroll_b__0() => default; // 0x0000000185FCBE00-0x0000000185FCBE20
			internal void __CustomSetPosOnScroll_b__1(Vector2 pos) {} // 0x0000000185FB23D0-0x0000000185FB23E0
		}
	
		// Constructors
		public UIScrollRect() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void Awake() {} // 0x000000018557AF60-0x000000018557AFD0
		protected override void OnEnable() {} // 0x000000018BC0F908-0x000000018BC0F9F4
		private void Update() {} // 0x0000000185ECB510-0x0000000185ECB570
		public void ScrollTo(Vector2 position, bool noTween = false /* Metadata: 0x02061DB5 */) {} // 0x0000000184B8C760-0x0000000184B8E1B0
		public bool IsCellViewed(RectTransform cell) => default; // 0x0000000184F9DAA0-0x0000000184F9DB30
		protected override void OnDestroy() {} // 0x000000018BC0F9F4-0x000000018BC0FA84
		protected override void _CustomSetPosOnScroll(Vector2 position) {} // 0x000000018BC0FA84-0x000000018BC0FB14
		protected override void UpdateScrollEnableNode() {} // 0x000000018BC0FB14-0x000000018BC0FBBC
		public override void OnBeginDrag(PointerEventData eventData) {} // 0x0000000185B3B000-0x0000000185B3B8F0
		public override void OnDrag(PointerEventData eventData) {} // 0x0000000185FB98E0-0x0000000185FB98F0
		public override void OnEndDrag(PointerEventData eventData) {} // 0x0000000184EBF8A0-0x0000000184EBF990
		public void ClearComponent() {} // 0x000000018BC102B0-0x000000018BC1035C
		protected override void LateUpdate() {} // 0x0000000185FB88B0-0x0000000185FB88C0
		private void _TickRefreshControllerStickScroll() {} // 0x00000001854F9FE0-0x00000001854FB2A0
		public void ScrollToNaviTarget(Selectable target) {} // 0x0000000184B5BCC0-0x0000000184B5D120
		public void RectWrapNavigate(NaviDirection dir) {} // 0x00000001845496E0-0x00000001845498D0
		private void _InitController() {} // 0x000000018BC103D0-0x000000018BC10510
		public void WrapNavigation(UnityAction<NaviDirection> wrapper) {} // 0x0000000184E52490-0x0000000184E526E0
		public void AutoScrollToRectTransform(RectTransform target, bool noTween = false /* Metadata: 0x02061DB6 */) {} // 0x000000018BC1006C-0x000000018BC102B0
		private void _UpdateMoveTips() {} // 0x000000018BC0FE90-0x000000018BC1006C
		private Camera _GetUICamera() => default; // 0x0000000184819880-0x0000000184819970
		private void _CheckOverScrollEffect(Vector2 value) {} // 0x0000000185492010-0x0000000185492020
		private void _CheckOverScrollOnEndDrag(Vector2 value) {} // 0x000000018BC0FE70-0x000000018BC0FE78
		public void __iFixBaseProxy_Awake() {} // 0x000000018BC0FE88-0x000000018BC0FE90
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BC0FE80-0x000000018BC0FE88
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018BC0FE60-0x000000018BC0FE68
		public void __iFixBaseProxy__CustomSetPosOnScroll(Vector2 P0) {} // 0x000000018BC0FE68-0x000000018BC0FE70
		public void __iFixBaseProxy_UpdateScrollEnableNode() {} // 0x000000018BC0FE78-0x000000018BC0FE80
		public void __iFixBaseProxy_OnBeginDrag(PointerEventData P0) {} // 0x000000018BC0FE58-0x000000018BC0FE60
		public void __iFixBaseProxy_OnDrag(PointerEventData P0) {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnEndDrag(PointerEventData P0) {} // 0x0000000183ECAA10-0x0000000183ECAA30
		public void __iFixBaseProxy_LateUpdate() {} // 0x0000000183ECAA30-0x0000000183ECAA70
	}

	public class UIScrollRectEdgeRedDot : TickableUIMono, IUIClearable // TypeDefIndex: 50322
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
		private bool _isHorizontal; // 0xB0
		private GameObject _upNormal; // 0xB8
		private GameObject _upNew; // 0xC0
		private GameObject _downNormal; // 0xC8
		private GameObject _downNew; // 0xD0
		private RectTransform _upParent; // 0xD8
		private RectTransform _downParent; // 0xE0
		private float _upEdgeOffset; // 0xE8
		private float _downEdgeOffset; // 0xEC
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x000000018BC0E148-0x000000018BC0E4F0 
	
		// Nested types
		public enum ERedDotState // TypeDefIndex: 50319
		{
			DISABLED = 0,
			NEW = 1,
			NORMAL = 2
		}
	
		public enum ERedDotDir // TypeDefIndex: 50320
		{
			UP = 0,
			RIGHT = 1,
			DOWN = 2,
			LEFT = 3
		}
	
		public class RedDotInfo // TypeDefIndex: 50321
		{
			// Fields
			public readonly GameObject redDotRoot; // 0x10
			public readonly GameObject redDotNormal; // 0x18
			public readonly GameObject redDotNew; // 0x20
	
			// Properties
			public ERedDotState state { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
			public Vector2 normalPos { get => default; } // 0x000000018BC0DA94-0x000000018BC0DAF0 
			public Vector2 newPos { get => default; } // 0x000000018BC0DAF0-0x000000018BC0DCE0 
			public Rect normalRect { get => default; } // 0x000000018BC0DCE0-0x000000018BC0DE04 
			public Rect newRect { get => default; } // 0x000000018BC0E884-0x000000018BC0EAB8 
	
			// Constructors
			public RedDotInfo() {} // Dummy constructor
			public RedDotInfo(GameObject redDotRoot, GameObject redDotNormal, GameObject redDotNew) {} // 0x000000018BC0E4F0-0x000000018BC0E884
		}
	
		// Constructors
		public UIScrollRectEdgeRedDot() {} // 0x000000018BC0D460-0x000000018BC0D53C
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BC0F554-0x000000018BC0F744
		protected override void OnEnable() {} // 0x000000018BC0F4BC-0x000000018BC0F554
		protected override void OnRelease() {} // 0x000000018BC0DF90-0x000000018BC0E148
		public override void Tick(float deltaTime) {} // 0x000000018BC0EAB8-0x000000018BC0EB78
		public void ResetReferences() {} // 0x000000018BC0DE04-0x000000018BC0DF90
		public void ResetRedDotPosition() {} // 0x000000018BC0EB78-0x000000018BC0EC40
		private void _UpdateCacheDictForRangeChange(Vector2Int newRange) {} // 0x000000018BC0EC40-0x000000018BC0F4BC
		private void _OnScrollListUpdateCount(int newCount) {} // 0x000000018BC0F744-0x000000018BC0F8E4
		public void RegisterRedDot(GameObject redDotRoot, GameObject redDotNormal, GameObject redDotNew) {} // 0x000000018BC0D7D4-0x000000018BC0DA94
		public void UnregisterRedDot(GameObject redDotRoot) {} // 0x000000018BC0D778-0x000000018BC0D7D4
		public void RegisterRedDotStatesForScrollList() {} // 0x000000018BC0F8E4-0x000000018BC0F908
		public void UpdateRedDotStateInDir() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		private void _CalculateRedDotStateInDir(out ERedDotState upState, out ERedDotState downState) {
			upState = default;
			downState = default;
		} // 0x0000000187AAA40C-0x0000000187AAA414
		private void _UpdateRedDotGameObjects(GameObject normal, GameObject newer, ERedDotState state) {} // 0x000000018792FE0C-0x000000018792FE14
		public bool IsRedDotInDir(ERedDotState state, ERedDotDir dir, RedDotInfo redDotInfo) => default; // 0x000000018311B6C0-0x000000018311B6D0
		public void ClearComponent() {} // 0x000000018BC0D638-0x000000018BC0D728
		public void __iFixBaseProxy_OnAwake() {} // 0x000000018BC0D288-0x000000018BC0D364
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BC0D53C-0x000000018BC0D638
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018BC0D364-0x000000018BC0D460
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018BC0D250-0x000000018BC0D288
	}

	public class UIScrollText : TickableUIMono // TypeDefIndex: 50330
	{
		// Fields
		private float _speed; // 0x68
		private float _stayTime; // 0x6C
		private float _fadeTime; // 0x70
		private CanvasGroup _canvasGroup; // 0x78
		private ScrollMode _scrollMode; // 0x80
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
		protected override TickType tickOption { get => default; } // 0x0000000184096E30-0x0000000184096EF0 
	
		// Nested types
		private enum ScrollMode // TypeDefIndex: 50323
		{
			Mesh = 0,
			AnchoredPosition = 1
		}
	
		private enum ScrollState // TypeDefIndex: 50324
		{
			Scrolling = 0,
			Idle = 1,
			FadingOut = 2,
			FadingIn = 3
		}
	
		private interface IAlphaHandler // TypeDefIndex: 50325
		{
			// Methods
			void HandleAlpha(float alpha); // 0x0000000185FB6DA0-0x0000000185FB6DB0
		}
	
		private class CanvasGroupHandler : IAlphaHandler // TypeDefIndex: 50326
		{
			// Fields
			private CanvasGroup m_canvasGroup; // 0x10
	
			// Constructors
			public CanvasGroupHandler() {} // Dummy constructor
			public CanvasGroupHandler(CanvasGroup canvasGroup) {} // 0x000000018BC10A90-0x000000018BC10D2C
	
			// Methods
			public void HandleAlpha(float alpha) {} // 0x000000018BC10818-0x000000018BC10954
		}
	
		private interface IScrollHandler // TypeDefIndex: 50327
		{
			// Methods
			void ApplyScroll(float scrollOffset); // 0x0000000183ECC490-0x0000000183ECC810
			void ResetScroll(); // 0x0000000183ECBCB0-0x0000000183ECC490
			void UpdateScrollStatus(bool isScroll); // 0x000000018BC10D2C-0x000000018BC10DE4
		}
	
		private class PositionScrollHandler : Beyond.UI.UIScrollText.IScrollHandler // TypeDefIndex: 50328
		{
			// Fields
			private UIScrollText m_closure; // 0x10
	
			// Constructors
			public PositionScrollHandler() {} // Dummy constructor
			public PositionScrollHandler(UIScrollText scrollText) {} // 0x000000018BC107BC-0x000000018BC10818
	
			// Methods
			public void ApplyScroll(float scrollOffset) {} // 0x000000018BC105D4-0x000000018BC107BC
			public void ResetScroll() {} // 0x000000018BC10E48-0x000000018BC110C8
			public void UpdateScrollStatus(bool isScroll) {} // 0x000000018BC10DE4-0x000000018BC10E48
		}
	
		private class MeshScrollHandler : Beyond.UI.UIScrollText.IScrollHandler // TypeDefIndex: 50329
		{
			// Fields
			private UIScrollText m_closure; // 0x10
	
			// Constructors
			public MeshScrollHandler() {} // Dummy constructor
			public MeshScrollHandler(UIScrollText uiScrollText) {} // 0x000000018BC10954-0x000000018BC10A24
	
			// Methods
			public void ApplyScroll(float scrollOffset) {} // 0x000000018BC10A24-0x000000018BC10A90
			public void ResetScroll() {} // 0x000000018BC110C8-0x000000018BC110F0
			public void UpdateScrollStatus(bool isScroll) {} // 0x0000000187AB03B8-0x0000000187AB03C0
			private void _ApplyScroll(float scrollOffset) {} // 0x0000000187A742A0-0x0000000187A742A8
			private void _UpdateMeshClipping(TMP_TextInfo textInfo) {}
		}
	
		// Constructors
		public UIScrollText() {} // 0x000000018BC0C454-0x000000018BC0C510
	
		// Methods
		private void _InitIfNot() {} // 0x000000018BC0C32C-0x000000018BC0C398
		public void ResetTextScroll() {}
		public void ResetToStatic() {}
		public float GetSingleScrollDuration() => default;
		private void _ResetTextScrollInternal(bool needScroll, float textDiff) {} // 0x0000000184096E30-0x0000000184096EF0
		protected override void OnAwake() {} // 0x000000018BC0D04C-0x000000018BC0D0F8
		public override void LateTick(float deltaTime) {} // 0x000000018BC0D0F8-0x000000018BC0D16C
		private void _UpdateScrollState(float deltaTime, float textDiff) {} // 0x000000018BC0D16C-0x000000018BC0D250
		private void _ResetTextScroll() {} // 0x0000000184096E30-0x0000000184096EF0
		private void _ApplyTextAlignment(bool isScroll) {} // 0x000000018BC0C398-0x000000018BC0C3FC
		private void _ApplyTextScroll(float scrollOffset) {} // 0x000000018BC0C3FC-0x000000018BC0C454
		public void __iFixBaseProxy_OnAwake() {} // 0x000000018BC0C510-0x000000018BC0C7F0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x000000018BC0C7F0-0x000000018BC0D04C
	}

	public class UISelectableNaviGroup : SelectableNaviGroup, IUIClearable // TypeDefIndex: 50332
	{
		// Fields
		public List<InputBindingGroupMonoTarget> relatedInputBindingGroups; // 0xA0
		public Func<Selectable> getDefaultSelectableFunc; // 0xA8
		public Func<bool> canFocusFun; // 0xB0
		public string focusActionId; // 0xB8
		public string stopFocusActionId; // 0xC0
		public bool hideItemTipsOnUnFocus; // 0xC8
		public bool useDefaultTargetOnFocus; // 0xC9
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
		private const int INVALID_BINDING_ID = -1; // Metadata: 0x02061DCB
	
		// Properties
		public int FocusBindingId { get => default; } // 0x0000000185FBED30-0x0000000185FBED40 
		public int StopFocusBindingId { get => default; } // 0x0000000185FCEAF0-0x0000000185FCEB00 
		public Selectable lastFocusNaviTarget { get => default; } // 0x0000000185FB8600-0x0000000185FB8610 
	
		// Nested types
		public struct FocusBlockMessageData // TypeDefIndex: 50331
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
		public UISelectableNaviGroup() {} // 0x0000000185263F20-0x0000000185264030
	
		// Methods
		private void Awake() {} // 0x00000001849CCD20-0x00000001849CCE00
		protected override void OnEnable() {} // 0x000000018422CDD0-0x000000018422CE20
		protected override void OnDisable() {} // 0x000000018422C750-0x000000018422C790
		protected override void _OnIsTopLayerChanged() {} // 0x000000018422D0A0-0x000000018422D0F0
		protected override void _OnSelectableNaviGroupDisabled() {} // 0x0000000185087F10-0x0000000185087F50
		protected override void _BeforeSelectableNaviGroupDestroy() {} // 0x0000000185088480-0x00000001850884C0
		protected override void _OnSetLayerSelectedTarget(Selectable value) {} // 0x000000018BC1177C-0x000000018BC117E4
		protected override void _OnRemoveFromLayerStack() {} // 0x000000018422C790-0x000000018422C7E0
		public void NaviToThisGroup(bool forceDefault = false /* Metadata: 0x02061DC8 */) {} // 0x0000000185087F50-0x0000000185088070
		private void _RefreshRelatedBindingGroupsState() {} // 0x000000018422ED70-0x000000018422FCB0
		private Selectable _FindDefaultSelectable() => default; // 0x0000000185088070-0x0000000185088480
		protected override void OnDestroy() {} // 0x0000000184229FB0-0x000000018422A000
		public void ClearComponent() {} // 0x000000018422A380-0x000000018422AD90
		public void TryChangeNaviPartnerOnUp(UISelectableNaviGroup partner, bool isAdd) {} // 0x000000018BC113DC-0x000000018BC1145C
		public void TryChangeNaviPartnerOnDown(UISelectableNaviGroup partner, bool isAdd) {} // 0x000000018BC1125C-0x000000018BC112DC
		public void TryChangeNaviPartnerOnLeft(UISelectableNaviGroup partner, bool isAdd) {} // 0x000000018BC112DC-0x000000018BC1135C
		public void TryChangeNaviPartnerOnRight(UISelectableNaviGroup partner, bool isAdd) {} // 0x000000018BC1135C-0x000000018BC113DC
		private void _TryChangeNaviPartner(List<SelectableNaviGroup> list, UISelectableNaviGroup partner, bool isAdd) {} // 0x000000018BC117E4-0x000000018BC118D4
		private void _InitFocusBinding() {} // 0x00000001849CCA10-0x00000001849CCD20
		private void _RefreshFocusBindings() {} // 0x000000018422DF00-0x000000018422E040
		public void RefreshFocusBindings() {} // 0x000000018BC11154-0x000000018BC111A4
		private void _OnFocus(bool onlyStartHighlight) {} // 0x000000018BC11490-0x000000018BC1177C
		private void _OnStopFocus(bool onlyStopHighlight, bool ignoreTopLayerCheck) {} // 0x000000018422CAF0-0x000000018422CC20
		private void _RefreshFocusActionKeyHint() {} // 0x000000018422CED0-0x000000018422CFB0
		private void _RefreshStopFocusActionKeyHint() {} // 0x000000018422CE50-0x000000018422CED0
		public void ManuallyFocus(bool onlyStartHighlight = false /* Metadata: 0x02061DC9 */) {} // 0x000000018BC110F0-0x000000018BC11154
		public void ManuallyStopFocus(bool onlyStopHighlight = false /* Metadata: 0x02061DCA */) {} // 0x00000001850884C0-0x0000000185088510
		public void SetFocusBindingText(string bindingText) {} // 0x000000018BC111A4-0x000000018BC1125C
		public void ClearLastFocusNaviTarget() {} // 0x0000000185F9B1F0-0x0000000185F9B230
		public void ManuallyRefreshRelatedBindingGroups() {} // 0x0000000185F5F980-0x0000000185F5F9C0
		private void __InitFocusBinding_b__51_0() {} // 0x000000018BC11474-0x000000018BC11480
		private void __InitFocusBinding_b__51_1() {} // 0x000000018BC11480-0x000000018BC11490
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BC11464-0x000000018BC1146C
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018646E3D4-0x000000018646E3E4
		public void __iFixBaseProxy__OnIsTopLayerChanged() {} // 0x000000018BC1146C-0x000000018BC11474
		public void __iFixBaseProxy__OnSelectableNaviGroupDisabled() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy__BeforeSelectableNaviGroupDestroy() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy__OnSetLayerSelectedTarget(Selectable P0) {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy__OnRemoveFromLayerStack() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018BC1145C-0x000000018BC11464
	}

	public class UISemiCircleScrollList : TickableUIMono, IDragHandler, IUIClearable, IBeginDragHandler, IEndDragHandler // TypeDefIndex: 50334
	{
		// Fields
		public RectTransform content; // 0x68
		private float _innerRadius; // 0x70
		private float _outerRadius; // 0x74
		private float _padding; // 0x78
		private int _cellCount; // 0x7C
		private GameObject _cellPrefab; // 0x80
		private float _startAngle; // 0x88
		private bool _reverseDirection; // 0x8C
		private RectTransform m_rectTransform; // 0x90
		[NonSerialized]
		public float currentAngleOffset; // 0x98
		private float m_targetAngleOffset; // 0x9C
		private float _hideAngel; // 0xA0
		private float _duration; // 0xA4
		private List<GameObject> m_cells; // 0xA8
		private bool m_inEndDragAnim; // 0xB0
		private bool m_inDragging; // 0xB1
		protected InputBindingGroupMonoTarget _scrollBindingGroup; // 0xB8
		protected float _stickScrollTolerance; // 0xC0
		protected float _stickScrollSpeed; // 0xC4
		private int m_lastClosestCellIndex; // 0xC8
		private int m_currentCellCount; // 0xCC
		public DisposedUnityEvent<GameObject, int> onCellShow; // 0xD0
		public DisposedUnityEvent<int> onClosestCellChanged; // 0xD8
		public DisposedUnityEvent onDrag; // 0xE0
		public DisposedUnityEvent onEndDrag; // 0xE8
		private Coroutine m_dampingCoroutine; // 0xF0
		private string _audioHoldStart; // 0xF8
		private string _audioHoldEnd; // 0x100
		private string _audioAlignment; // 0x108
		protected bool _dpadScrollEnabled; // 0x110
		protected float _dpadScrollSpeed; // 0x114
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x000000018BC129FC-0x000000018BC12B64 
		public bool controllerStickScrollEnabled { get => default; } // 0x000000018BC12428-0x000000018BC124C8 
	
		// Nested types
		private sealed class __ApplyDamping_d__46 : IEnumerator<object> // TypeDefIndex: 50333
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UISemiCircleScrollList __4__this; // 0x20
			private float _targetOffset_5__2; // 0x28
			private float _elapsed_5__3; // 0x2C
			private float _initialOffset_5__4; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BC12184-0x000000018BC12208 
			object IEnumerator.Current { get => default; } // 0x000000018BC12B64-0x000000018BC12EEC 
	
			// Constructors
			public __ApplyDamping_d__46() {} // Dummy constructor
			public __ApplyDamping_d__46(int __1__state) {} // 0x0000000181E1B510-0x0000000181E1B520
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BC1304C-0x000000018BC130EC
			private bool MoveNext() => default; // 0x000000018BC1205C-0x000000018BC12100
			void IEnumerator.Reset() {} // 0x000000018BC124C8-0x000000018BC12534
		}
	
		// Constructors
		public UISemiCircleScrollList() {} // 0x0000000183ECAA70-0x0000000183ECBC60
	
		// Methods
		protected override void OnAwake() {} // 0x000000018BC12534-0x000000018BC1296C
		protected override void OnDisable() {} // 0x000000018BC12208-0x000000018BC12340
		public override void Tick(float deltaTime) {} // 0x000000018BC11F48-0x000000018BC1205C
		private void _TickRefreshControllerStickScroll() {} // 0x000000018BC12100-0x000000018BC12184
		private void _InitializeCells() {} // 0x000000018BC12340-0x000000018BC12428
		public void RefreshLayout(int newCellCount, int targetCellIndex) {} // 0x000000018BC1296C-0x000000018BC129FC
		public void UpdateLayout() {} // 0x000000018BC12EEC-0x000000018BC1304C
		public void OnDrag(PointerEventData eventData) {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void ClearComponent() {} // 0x0000000187AAA404-0x0000000187AAA40C
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018311B6C0-0x000000018311B6D0
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000181378230-0x0000000181378240
		private IEnumerator _ApplyDamping() => default; // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000181377E40-0x0000000181377E50
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000183ECBC60-0x0000000183ECBCB0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class UISemiCircleScrollListPair : MonoBehaviour // TypeDefIndex: 50335
	{
		// Fields
		public UISemiCircleScrollList m_scrollListMaster; // 0x18
		public UISemiCircleScrollList[] m_scrollLists; // 0x20
		public DisposedUnityEvent<GameObject, int> onCellShow; // 0x28
		public DisposedUnityEvent<int> onClosestCellChanged; // 0x30
	
		// Constructors
		public UISemiCircleScrollListPair() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Awake() {} // 0x000000018BC118D4-0x000000018BC11C48
		private void _OnCellShow(GameObject go, int index) {} // 0x000000018BC11D04-0x000000018BC11DA4
		private void _OnClosestCellChanged(int index) {} // 0x000000018BC11DA4-0x000000018BC11E2C
		private void _OnDrag() {} // 0x000000018BC11E2C-0x000000018BC11EC8
		private void _OnEndDrag() {} // 0x000000018BC11EC8-0x000000018BC11F48
		public void RefreshLayout(int newCellCount, int targetCellIndex) {} // 0x000000018BC11C48-0x000000018BC11D04
	}

	public class UISequenceImage : TickableUIMono // TypeDefIndex: 50336
	{
		// Fields
		public bool autoPlay; // 0x68
		public float frameRate; // 0x6C
		public List<Sprite> sprites; // 0x70
		private bool _isPlaying_k__BackingField; // 0x78
		private UIImage m_image; // 0x80
		private float m_curFrameCount; // 0x88
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
		public bool isPlaying { get; private set; } // 0x0000000185FB0DA0-0x0000000185FB0DB0 0x0000000185FB0DB0-0x0000000185FB0DC0
	
		// Constructors
		public UISequenceImage() {} // 0x0000000185908430-0x00000001859084C0
	
		// Methods
		protected override void OnAwake() {} // 0x0000000185DB13D0-0x0000000185DB1450
		protected override void OnEnable() {} // 0x0000000185C5E990-0x0000000185C5E9E0
		protected override void OnDisable() {} // 0x0000000185EE01C0-0x0000000185EE0210
		public override void Tick(float deltaTime) {} // 0x00000001840445B0-0x0000000184044640
		public void Play() {} // 0x0000000185C5E9E0-0x0000000185C5EA30
		public void Stop(bool resetToFirstFrame = false /* Metadata: 0x02061DCC */) {} // 0x0000000185EE0210-0x0000000185EE0250
		public void SetSprite(int index) {} // 0x0000000184044640-0x0000000184044840
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000187AAA404-0x0000000187AAA40C
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UISimpleActiveAnimationHelper : TickableUIMono // TypeDefIndex: 50337
	{
		// Fields
		public bool isActive; // 0x68
		public string toActiveAnimationName; // 0x70
		private Animation m_animation; // 0x78
		private UnityEngine.AnimationState m_animationState; // 0x80
		private float m_animationTime; // 0x88
		private float m_curAnimationTime; // 0x8C
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000181E1B510-0x0000000181E1B520 
	
		// Constructors
		public UISimpleActiveAnimationHelper() {} // 0x0000000185F36F60-0x0000000185F36FC0
	
		// Methods
		private void Start() {} // 0x000000018BC13200-0x000000018BC132DC
		protected override void OnEnable() {} // 0x000000018BC130EC-0x000000018BC1315C
		public void Skip() {} // 0x000000018BC1315C-0x000000018BC13200
		public override void Tick(float deltaTime) {} // 0x000000018BC132DC-0x000000018BC13404
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
	}

	public class UISimpleStateController : MonoBehaviour // TypeDefIndex: 50339
	{
		// Fields
		private List<StateInfo> _states; // 0x18
		private string m_curStateName; // 0x20
	
		// Properties
		public string curStateName { get => default; } // 0x000000018BC0D728-0x000000018BC0D778 
	
		// Nested types
		[Serializable]
		public class StateInfo // TypeDefIndex: 50338
		{
			// Fields
			public string name; // 0x10
			public List<GameObject> activeObjects; // 0x18
	
			// Constructors
			public StateInfo() {} // 0x000000018530F730-0x00000001853105F0
	
			// Methods
			public override string ToString() => default; // 0x00000001813B31A0-0x00000001813B31B0
			public string __iFixBaseProxy_ToString() => default; // 0x00000001855F14A0-0x00000001855F1530
		}
	
		// Constructors
		public UISimpleStateController() {} // 0x000000018765AF34-0x000000018765AF3C
	
		// Methods
		public void SetState(string stateName) {} // 0x0000000184816EB0-0x0000000184816F30
	}

	public class UISizeFollower : TickableUIMono // TypeDefIndex: 50340
	{
		// Fields
		public RectTransform target; // 0x68
		public Vector2 addedSize; // 0x70
		public bool isSumSize; // 0x78
		public bool followWidth; // 0x79
		public bool followHeight; // 0x7A
		public bool regulateAnchoredPosition; // 0x7B
		public Vector2 minSize; // 0x7C
		public Vector2 maxSize; // 0x84
		private RectTransform m_rectTransform; // 0x90
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
		public RectTransform rectTransform { get => default; } // 0x0000000184DB07E0-0x0000000184DB0920 
	
		// Constructors
		public UISizeFollower() {} // 0x0000000184815BD0-0x0000000184815BE0
	
		// Methods
		public override void LateTick(float deltaTime) {} // 0x0000000184DB04C0-0x0000000184DB0500
		public void SyncSize() {} // 0x0000000184DB0500-0x0000000184DB07E0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class UISlider : Slider, IUIClearable, IBeginDragHandler, IEndDragHandler, IBindingGroupTarget, IBindingView // TypeDefIndex: 50341
	{
		// Fields
		public float snapCenterRange; // 0x1E8
		public string audioSlide; // 0x1F0
		public string audioClickHandle; // 0x1F8
		private bool m_dragging; // 0x200
		private bool m_gamepadStickScrolling; // 0x201
		public SliderEvent onEndDragSlider; // 0x208
		public SliderEvent onClickSlider; // 0x210
		public SliderEvent onClickSliderHandle; // 0x218
		private TickFunction m_gamepadStickScrollTickFunction; // 0x220
		public string sliderAddActionId; // 0x228
		public string sliderReduceActionId; // 0x230
		private readonly DisposedUnityEvent _bindingViewUpdateEvent_k__BackingField; // 0x238
		private int m_bindingGroupId; // 0x240
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0x248
		public bool snapStep; // 0x250
		public float stepValue; // 0x254
		protected bool _enableGamepadStickScroll; // 0x258
		protected float _gamepadStickScrollTolerance; // 0x25C
		protected float _gamepadStickOverPushThreshold; // 0x260
		protected int _gamepadStickOverPushMultiplier; // 0x264
		protected int _gamepadStickScrollBatchCount; // 0x268
		private int m_gamepadStickScrollHoriBindingId; // 0x26C
	
		// Properties
		public string bindingViewActionId { get => default; } // 0x0000000185FB8620-0x0000000185FB8630 
		public string bindingViewLabelText { get => default; } // 0x000000018BC1399C-0x000000018BC139D4 
		public DisposedUnityEvent bindingViewUpdateEvent { get; } // 0x0000000185FB8850-0x0000000185FB8860 
		public RectTransform redDotTrans { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public bool bindingEnabled { get => default; } // 0x000000018BC13994-0x000000018BC1399C 
		public BindingViewState bindingViewState { get => default; } // 0x000000018BC139D4-0x000000018BC13AD0 
		public int groupId { get => default; } // 0x0000000185FD6DA0-0x0000000185FD6DB0 
		public IBindingGroupTarget parentTarget { get; private set; } // 0x0000000185FB8840-0x0000000185FB8850 0x0000000187A47B40-0x0000000187A47B54
		public bool groupEnabled { get => default; } // 0x000000018BC13AD0-0x000000018BC13B24 
		bool IBindingView.interactable { get => default; } // 0x000000018BC134AC-0x000000018BC134FC 
	
		// Constructors
		public UISlider() {} // 0x00000001848170D0-0x0000000184817280
	
		// Methods
		private void _TryPostSlideAudioEvent() {} // 0x000000018545B320-0x000000018545B380
		protected override float ClampValue(float input) => default; // 0x000000018515E380-0x000000018515E400
		protected override float CustomProcessNormalizedValue(float val) => default; // 0x000000018BC134FC-0x000000018BC13588
		protected override void OnValueChanged() {} // 0x000000018545B2E0-0x000000018545B320
		protected override void OnClickSliderBar() {} // 0x000000018BC136D0-0x000000018BC13754
		protected override void OnClickSliderHandle() {} // 0x000000018BC13754-0x000000018BC1380C
		protected override void _NotifyIsHover(bool isHover) {} // 0x000000018422D1C0-0x000000018422D230
		public virtual void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BC13674-0x000000018BC136D0
		public virtual void OnEndDrag(PointerEventData eventData) {} // 0x000000018BC1380C-0x000000018BC138AC
		protected override void Awake() {} // 0x000000018422C370-0x000000018422C3C0
		protected override void OnEnable() {} // 0x0000000184231510-0x0000000184232150
		protected override void OnDisable() {} // 0x00000001856CC910-0x00000001856CD2A0
		private void _CreateGamepadStickScrollTickFunction() {} // 0x0000000183ECCFF0-0x0000000183ECDFC0
		private void _ReleaseGamepadStickScrollTickFunction() {} // 0x0000000183ED0310-0x0000000183ED06E0
		private void _GamepadStickScrollTick(float deltaTime) {} // 0x0000000183ECDFC0-0x0000000183ECEBC0
		public void ClearComponent() {} // 0x0000000185DAECD0-0x0000000185DAED40
		protected override void OnDestroy() {} // 0x0000000185C06590-0x0000000185C06620
		public string GetBindingViewActionId(BindingViewActionType actionType) => default; // 0x000000018BC13588-0x000000018BC13674
		void IBindingView.OnInputKeyDown(bool isActionTrigger) {} // 0x000000018BC13404-0x000000018BC13458
		void IBindingView.OnInputKeyUp(bool isActionTrigger) {} // 0x000000018BC13458-0x000000018BC134AC
		private void _InitBinding() {} // 0x000000018422C3C0-0x000000018422C4F0
		private void _AddValue() {} // 0x000000018BC138BC-0x000000018BC13928
		private void _ReduceValue() {} // 0x000000018BC13928-0x000000018BC13994
		private void _InitGamepadStickScroll() {} // 0x0000000183ECEBC0-0x0000000183ECFA00
		private void _OnGamepadStickScrollHoriValue() {} // 0x0000000183ECFA00-0x0000000183ED0310
		private void _ApplyGamepadStickScroll(float deltaConcern) {} // 0x0000000183ECC810-0x0000000183ECCFF0
		public float __iFixBaseProxy_ClampValue(float P0) => default; // 0x000000018BC138AC-0x000000018BC138B4
		public float __iFixBaseProxy_CustomProcessNormalizedValue(float P0) => default; // 0x0000000183667B80-0x0000000183667B90
		public void __iFixBaseProxy_OnValueChanged() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnClickSliderBar() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnClickSliderHandle() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy__NotifyIsHover(bool P0) {} // 0x000000018BBF36E4-0x000000018BBF36EC
		public void __iFixBaseProxy_Awake() {} // 0x000000018BBD59E0-0x000000018BBD59E8
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BC138B4-0x000000018BC138BC
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001856CD2A0-0x00000001856CD2B0
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018BBD59E8-0x000000018BBD59F0
	}

	public class UISoftMask : TickableUIMono // TypeDefIndex: 50343
	{
		// Fields
		private Vector3[] m_fourCornersArray; // 0x68
		private Vector3[] m_fourCornersArrayWorld; // 0x70
		private List<UISoftMaskable> m_cacheSoftMaskables; // 0x78
		private static List<Canvas> s_cacheCanvas; // 0x00
		private static Image s_image; // 0x08
		private Shader _maskableDefaultShader; // 0x80
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
		protected override TickType tickOption { get => default; } // 0x0000000185FB84E0-0x0000000185FB84F0 
		public Material softMaskDefaultMaterial { get => default; } // 0x0000000184515C70-0x0000000184515F20 
	
		// Nested types
		public struct SlicedSpriteParams // TypeDefIndex: 50342
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
			} // 0x0000000185FB7DE0-0x0000000185FB7DF0
		}
	
		// Constructors
		public UISoftMask() {} // 0x0000000185C47A20-0x0000000185C47BB0
		static UISoftMask() {} // 0x0000000187AAA40C-0x0000000187AAA414
	
		// Methods
		public Material GetTextSoftMaskMaterial(Material baseMaterial) => default; // 0x000000018BC13C14-0x000000018BC13ED0
		public Material GetUIVFXSoftMaskMaterial(Material baseMaterial) => default; // 0x000000018BC13B24-0x000000018BC13BC4
		public Vector3 GetCornerCanvas(int i) => default; // 0x000000018BC13BC4-0x000000018BC13C14
		public Vector3[] GetFourCornnerArrayWorld() => default; // 0x00000001849D2050-0x00000001849D22A0
		protected override void OnEnable() {} // 0x00000001849D2350-0x00000001849D24A0
		protected override void OnDisable() {} // 0x00000001844C3380-0x00000001844C3680
		public override void TailLateTick(float deltaTime) {} // 0x00000001849D24A0-0x00000001849D27A0
		private void _Clear() {} // 0x00000001849D27A0-0x00000001849D2810
		private void _DestroyMaterial(Material material) {} // 0x00000001845EA7E0-0x00000001845EC370
		private void _UpdateParam() {} // 0x00000001845EC5D0-0x00000001845ED1F0
		private void _UpdateChildren(bool markVertices, bool markMaterial) {} // 0x0000000185A62380-0x0000000185A623C0
		private void _OnEnableRuntimeAtlas() {} // 0x0000000184814E00-0x0000000184814FB0
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA404-0x0000000187AAA40C
		public void __iFixBaseProxy_OnDisable() {} // 0x00000001879BDE2C-0x00000001879BDE34
		public void __iFixBaseProxy_TailLateTick(float P0) {} // 0x0000000185FD6DD0-0x0000000185FD6E00
	}

	public class UISoftMaskable : TickableUIMono, IMaterialModifier, IMeshModifier // TypeDefIndex: 50346
	{
		// Fields
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
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
		public Material softMaskModefiedMat { get => default; } // 0x0000000185FB0510-0x0000000185FB0520 
		public Graphic graphic { get => default; } // 0x00000001845EDA60-0x00000001845EDB40 
		public UISoftMask softMask { get => default; } // 0x0000000184515BB0-0x0000000184515C70 
		public UIText uiText { get => default; } // 0x000000018BC18C30-0x000000018BC18CF8 
	
		// Nested types
		private enum UIType // TypeDefIndex: 50344
		{
			Default = 0,
			Text = 1,
			UIVFX = 2
		}
	
		private struct TestLine // TypeDefIndex: 50345
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
		public UISoftMaskable() {} // 0x00000001848151B0-0x00000001848152A0
		static UISoftMaskable() {} // 0x0000000185F3A410-0x0000000185F3A4B0
	
		// Methods
		public Material GetModifiedMaterial(Material baseMaterial) => default; // 0x0000000184515A70-0x0000000184515BB0
		protected override void OnEnable() {} // 0x00000001845ED540-0x00000001845EDA60
		protected override void OnDisable() {} // 0x00000001845ED440-0x00000001845ED540
		public override void LateTick(float deltaTime) {} // 0x00000001847A8AE0-0x00000001847A8C30
		public void MarkGraphicVerticesDirty() {} // 0x00000001845ED1F0-0x00000001845ED2B0
		public void MarkGraphicMaterialDirty() {} // 0x00000001845ED300-0x00000001845ED3B0
		public void ModifyMesh(Mesh mesh) {} // 0x000000018BC17350-0x000000018BC173A4
		private bool _Equal(float a, float b) => default; // 0x000000018BC18AF0-0x000000018BC18B74
		private Vector2 _ComputeLineCross(Vector2 line0p0, Vector2 line0p1, Vector2 line1p0, Vector2 line1p1) => default; // 0x000000018BC18730-0x000000018BC18970
		private void _ComputePointAtTriangleUV(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 q, out float u, out float v) {
			u = default;
			v = default;
		} // 0x000000018BC18970-0x000000018BC18AF0
		private void _ClipTriangleByClampSoftMaskUV(UIVertex[] vertices, UIVertex[] resultPoint, out bool canSkip) {
			canSkip = default;
		} // 0x000000018BC17684-0x000000018BC18730
		private void _ClipRect() {} // 0x000000018BC173A4-0x000000018BC17684
		public void ModifyMesh(VertexHelper vertHelper) {} // 0x00000001845159A0-0x0000000184515A70
		private static void _SetUIVertexUV(ref UIVertex uiVertex, Vector2 uv0, Vector2 uv1, Vector2 softMaskUV) {} // 0x000000018BC18B74-0x000000018BC18C30
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000187AAA404-0x0000000187AAA40C
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
	}

	public class UISortingOrder : MonoBehaviour // TypeDefIndex: 50348
	{
		// Fields
		private int _sortingOrderOffset; // 0x18
		private RenderType _renderType; // 0x1C
		private Renderer m_renderer; // 0x20
		private Renderer[] m_childrenRenderers; // 0x28
		private Canvas m_canvas; // 0x30
		private LuaPanel m_luaPanel; // 0x38
	
		// Nested types
		[Serializable]
		public enum RenderType // TypeDefIndex: 50347
		{
			Effect = 0,
			UI = 1
		}
	
		// Constructors
		public UISortingOrder() {} // 0x0000000185A36230-0x0000000185A36240
	
		// Methods
		private void OnEnable() {} // 0x00000001857D9190-0x00000001857D9270
		private void _GetRenderer() {} // 0x0000000184CD2360-0x0000000184CD2410
		private void _GetChildrenRenderers() {} // 0x0000000184CD22F0-0x0000000184CD2360
		private void _GetCanvas() {} // 0x0000000184CD2150-0x0000000184CD2200
		public void SetOrder(int baseOrder) {} // 0x0000000184CD1DA0-0x0000000184CD1F90
		private void Awake() {} // 0x0000000184CD1A70-0x0000000184CD1BD0
		private void OnDestroy() {} // 0x0000000185C45D80-0x0000000185C45E20
	}

	public class UIStepScrollList : UIScrollList // TypeDefIndex: 50349
	{
		// Fields
		[NonSerialized]
		public DisposedUnityEvent<int, int> onCenterIndexChanged; // 0x278
		[NonSerialized]
		public DisposedUnityEvent onScrollOrDragEnd; // 0x280
		[NonSerialized]
		public DisposedUnityEvent onScrollOrDragStart; // 0x288
		protected float _easyDragSpdThreshold; // 0x290
		protected float _easyDragDistPercentThreshold; // 0x294
		private int m_startDragCenterIndex; // 0x298
		private int m_centerIndex; // 0x29C
		private Vector2 m_scrollStartNormalizedPos; // 0x2A0
	
		// Properties
		public int centerIndex { get => default; } // 0x0000000185FAFC00-0x0000000185FAFC10 
	
		// Constructors
		public UIStepScrollList() {} // 0x0000000185BBF8B0-0x0000000185BBF9F0
	
		// Methods
		protected override void Init(bool isPreview = false /* Metadata: 0x02061DD2 */) {} // 0x0000000184B5E610-0x0000000184B5E820
		protected override void InitConfig() {} // 0x0000000184A058B0-0x0000000184A059D0
		protected override void OnScroll(Vector2 v) {} // 0x0000000184A07240-0x0000000184A072B0
		public override void OnBeginDrag(PointerEventData eventData) {} // 0x000000018BC18D7C-0x000000018BC18E08
		public override void OnEndDrag(PointerEventData eventData) {} // 0x000000018BC18E78-0x000000018BC19058
		public override void SetTop(bool needUpdate = true /* Metadata: 0x02061DD3 */) {} // 0x000000018BC19058-0x000000018BC190EC
		protected override void UpdateShowingCells(bool forceUpdateContent, bool forceClearShowingCells = false /* Metadata: 0x02061DD4 */, bool ignoreListActive = false /* Metadata: 0x02061DD5 */) {} // 0x0000000184A072B0-0x0000000184A07390
		public override void ClearComponent() {} // 0x000000018BC18CF8-0x000000018BC18D7C
		private void _OnScrollStart(Vector2 normalizedPos) {} // 0x000000018BC19234-0x000000018BC192B8
		private void _OnScrollEnd(Vector2 normalizedPos) {} // 0x000000018BC1912C-0x000000018BC19234
		private void _TryAutoScroll(bool isEasyDrag, bool goNext) {} // 0x000000018BC192B8-0x000000018BC1937C
		private int _GetClampedIndex() => default; // 0x0000000184A07390-0x0000000184A073F0
		protected override void OnDisable() {} // 0x000000018BC18E08-0x000000018BC18E78
		public void __iFixBaseProxy_Init(bool P0) {} // 0x000000018BC190F4-0x000000018BC190FC
		public void __iFixBaseProxy_InitConfig() {} // 0x000000018BC190EC-0x000000018BC190F4
		public void __iFixBaseProxy_OnScroll(Vector2 P0) {} // 0x000000018BC04FA4-0x000000018BC04FAC
		public void __iFixBaseProxy_OnBeginDrag(PointerEventData P0) {} // 0x000000018BC190FC-0x000000018BC19104
		public void __iFixBaseProxy_OnEndDrag(PointerEventData P0) {} // 0x000000018BC1910C-0x000000018BC19114
		public void __iFixBaseProxy_SetTop(bool P0) {} // 0x000000018BC19114-0x000000018BC1911C
		public void __iFixBaseProxy_UpdateShowingCells(bool P0, bool P1, bool P2) {} // 0x000000018BC1911C-0x000000018BC1912C
		public void __iFixBaseProxy_ClearComponent() {} // 0x000000018BC04F5C-0x000000018BC04F64
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018BC19104-0x000000018BC1910C
	}

	public class UIStyleByState : MonoBehaviour // TypeDefIndex: 50352
	{
		// Fields
		public List<StyleConfig> styleConfigs; // 0x18
	
		// Nested types
		[Serializable]
		public class StateConfig // TypeDefIndex: 50350
		{
			// Fields
			public UIStateController stateController; // 0x10
			public string stateName; // 0x18
	
			// Constructors
			public StateConfig() {} // 0x00000001845A4230-0x00000001845A4340
		}
	
		[Serializable]
		public class StyleConfig // TypeDefIndex: 50351
		{
			// Fields
			public UIStyleInputValidTypeMask inputValidType; // 0x10
			public List<StateConfig> stateConfigs; // 0x18
	
			// Constructors
			public StyleConfig() {} // 0x00000001845A3200-0x00000001845A32F0
		}
	
		// Constructors
		public UIStyleByState() {} // 0x00000001856160D0-0x0000000185616150
	
		// Methods
		private void Awake() {} // 0x00000001845A4440-0x00000001845A4F10
		private void OnDestroy() {} // 0x00000001845A4F10-0x00000001845A4F60
		public void UpdateStyle() {} // 0x0000000185755390-0x0000000185755420
		private bool _IsValidStyle(StyleConfig styleConfig) => default; // 0x0000000185492010-0x0000000185492020
	}

	public class UISubtitle : MonoBehaviour // TypeDefIndex: 50353
	{
		// Fields
		private UIText _topText; // 0x18
		private UIText _bottomText; // 0x20
	
		// Constructors
		public UISubtitle() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public void Start() {} // 0x000000018BC19480-0x000000018BC194D0
		private void _SetAsDefault() {} // 0x000000018BC195B0-0x000000018BC196E0
		public void SetSubtitle(string subtitle, bool showOnTop) {} // 0x000000018BC1937C-0x000000018BC19480
		public void UpdateAlpha(float alpha, bool isTop) {} // 0x000000018BC194D0-0x000000018BC195B0
	}

	public class UITextPair : MonoBehaviour // TypeDefIndex: 50354
	{
		// Fields
		public List<UIText> referencedTexts; // 0x18
	
		// Properties
		public string text { get => default; set {} } // 0x000000018BC19C94-0x000000018BC19D50 0x000000018BC19EE0-0x000000018BC1A04C
		public UnityEngine.Color color { set {} } // 0x000000018BC19D50-0x000000018BC19EE0
		public UIText first { get => default; } // 0x000000018BC19BFC-0x000000018BC19C94 
	
		// Constructors
		public UITextPair() {} // 0x0000000185B3E7F0-0x0000000185B3E880
	
		// Methods
		public void SetAndResolveTextStyle(string targetText) {} // 0x000000018BC1990C-0x000000018BC19A78
		public void SetPhoneticText(PhoneticType phoneticType, string id) {} // 0x000000018BC19A78-0x000000018BC19BFC
	}

	public enum TimelineUIBindingType // TypeDefIndex: 50355
	{
		None = 0,
		Mask = 1
	}

	public class UITimelineBindingTarget : MonoBehaviour // TypeDefIndex: 50356
	{
		// Fields
		public TimelineUIBindingType bindingType; // 0x18
	
		// Constructors
		public UITimelineBindingTarget() {} // 0x000000018317B060-0x000000018317B360
	}

	public class UIToggle : Toggle, IUIClearable // TypeDefIndex: 50357
	{
		// Fields
		private List<GameObject> _onObjects; // 0x1A8
		private List<GameObject> _offObjects; // 0x1B0
		private UIStateController _uiStateController; // 0x1B8
		private string _onStateName; // 0x1C0
		private string _offStateName; // 0x1C8
		private string _onAnimation; // 0x1D0
		private string _offAnimation; // 0x1D8
		private string _audioToggleOn; // 0x1E0
		private string _audioToggleOff; // 0x1E8
		private string _audioInvalid; // 0x1F0
		public bool _ignoreClickOnDrag; // 0x1F8
		private Vector2 _startPressPos_k__BackingField; // 0x1FC
		private LangKey _invalidClickLangKey; // 0x208
		public Func<bool, bool> checkIsValueValid; // 0x218
		private Animation m_animation; // 0x220
		private int m_groupId; // 0x228
		public string toggleActionId; // 0x230
		private int _toggleBindingId_k__BackingField; // 0x238
		private bool m_started; // 0x23C
		[NonSerialized]
		public string clickOnHintTextId; // 0x240
		[NonSerialized]
		public string clickOffHintTextId; // 0x248
		private ActionOnSetNaviTarget _actionOnSetNaviTarget; // 0x250
		private bool _useNoHintAction; // 0x254
		public string onHintTextId; // 0x258
		public string offHintTextId; // 0x260
		private int _hoverConfirmBindingId_k__BackingField; // 0x268
	
		// Properties
		public Vector2 startPressPos { get; private set; } // 0x0000000185FD6E10-0x0000000185FD6E30 0x0000000185FD6E50-0x0000000185FD6E60
		public int toggleBindingId { get; private set; } // 0x0000000185FD6E30-0x0000000185FD6E40 0x0000000185FD6E60-0x0000000185FD6E70
		public int hoverConfirmBindingId { get; private set; } // 0x0000000185FD6E00-0x0000000185FD6E10 0x0000000185FD6E40-0x0000000185FD6E50
	
		// Constructors
		public UIToggle() {} // 0x0000000184816D50-0x0000000184816EB0
	
		// Methods
		protected override void Awake() {} // 0x00000001849D7E80-0x00000001849D7F10
		protected override void OnEnable() {} // 0x000000018422FDA0-0x000000018422FE00
		protected override void OnDisable() {} // 0x000000018422FD30-0x000000018422FD70
		private void _UpdateBindingEnable() {} // 0x000000018422FF00-0x000000018422FFF0
		protected override void OnDestroy() {} // 0x000000018BC1A650-0x000000018BC1A710
		protected override void Start() {} // 0x0000000184230BD0-0x0000000184230C20
		protected override void InternalToggle() {} // 0x0000000185EF8150-0x0000000185EF81D0
		private void _InitToggleBinding() {} // 0x00000001849D7A40-0x00000001849D7BE0
		private bool _OnToggleFail() => default; // 0x000000018BC1AB44-0x000000018BC1AC94
		public void PlayAudio() {} // 0x0000000185EF8230-0x0000000185EF82C0
		protected override void OnValueChange() {} // 0x00000001849D7FB0-0x00000001849D8010
		protected override void _NotifyIsHover(bool isHover) {} // 0x000000018422D150-0x000000018422D1C0
		private void _UpdateObjects() {} // 0x00000001842301E0-0x00000001842309A0
		private void _PlayAnimation(bool skipToEnd) {} // 0x00000001842309A0-0x0000000184230B10
		public void ClearComponent() {} // 0x0000000185F41410-0x0000000185F41490
		public override void OnInteractableChanged() {} // 0x000000018BC1A710-0x000000018BC1A760
		public override bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId) {
			clickHintTextId = default;
			longPressHintTextId = default;
			return default;
		} // 0x000000018BC1A5B4-0x000000018BC1A650
		public override void OnPointerDown(PointerEventData eventData) {} // 0x000000018BC1A8E4-0x000000018BC1A978
		public override void OnPointerClick(PointerEventData eventData) {} // 0x000000018BC1A7CC-0x000000018BC1A8E4
		public override void OnSubmit(BaseEventData eventData) {} // 0x000000018BC1A978-0x000000018BC1A9D8
		public void TryInternalToggle() {} // 0x0000000185F8A3D0-0x0000000185F8A440
		public override void OnNaviTargetEnabledAgain() {} // 0x000000018BC1A760-0x000000018BC1A7CC
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode) {} // 0x000000018BC1AA00-0x000000018BC1AB44
		private void _InitActionOnSetNaviTarget() {} // 0x00000001849D7D30-0x00000001849D7E80
		private void _ToggleNaviInputBinding(bool active) {} // 0x000000018BC1AC94-0x000000018BC1AD2C
		private void _TryRefreshToggleBindingText() {} // 0x00000001849D7BE0-0x00000001849D7C20
		private void _TryRefreshHoverConfirmBindingText() {} // 0x00000001849D7F60-0x00000001849D7FB0
		private void _TryRefreshBindingText(int bindingId) {} // 0x00000001849D7C20-0x00000001849D7D30
		public void RefreshHintText() {} // 0x0000000183ED2A10-0x0000000183ED33D0
		public void __iFixBaseProxy_Awake() {} // 0x000000018BBD59E0-0x000000018BBD59E8
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BC1A9F0-0x000000018BC1A9F8
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018BC1A9E8-0x000000018BC1A9F0
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018BC1A9E0-0x000000018BC1A9E8
		public void __iFixBaseProxy_Start() {} // 0x000000018646E3F0-0x000000018646E3FC
		public void __iFixBaseProxy_InternalToggle() {} // 0x000000018BC1A9D8-0x000000018BC1A9E0
		public void __iFixBaseProxy_OnValueChange() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy__NotifyIsHover(bool P0) {} // 0x000000018BBF36E4-0x000000018BBF36EC
		public void __iFixBaseProxy_OnInteractableChanged() {} // 0x0000000185492010-0x0000000185492020
		public bool __iFixBaseProxy_GetMouseActionHints(out string P0, out string P1) {
			P0 = default;
			P1 = default;
			return default;
		} // 0x000000018BBF36C4-0x000000018BBF36CC
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0) {} // 0x000000018BBF36D4-0x000000018BBF36DC
		public void __iFixBaseProxy_OnPointerClick(PointerEventData P0) {} // 0x000000018BC1A9F8-0x000000018BC1AA00
		public void __iFixBaseProxy_OnSubmit(BaseEventData P0) {} // 0x000000018B7B5B4C-0x000000018B7B5B5C
		public void __iFixBaseProxy_OnNaviTargetEnabledAgain() {} // 0x000000018BBF36CC-0x000000018BBF36D4
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1) {} // 0x0000000185492010-0x0000000185492020
	}

	public class UIToggleGroup : ToggleGroup // TypeDefIndex: 50358
	{
		// Fields
		private string _moveToNextActionId; // 0x28
		private string _moveToPreviousActionId; // 0x30
		private bool _inverse; // 0x38
		private int _moveToNextBindingId_k__BackingField; // 0x3C
		private int _moveToPreviousBindingId_k__BackingField; // 0x40
	
		// Properties
		public int moveToNextBindingId { get; private set; } // 0x0000000185FB0790-0x0000000185FB07A0 0x0000000185FB07A0-0x0000000185FB07B0
		public int moveToPreviousBindingId { get; private set; } // 0x00000001813ECF10-0x00000001813ECF20 0x00000001813EE9C0-0x00000001813EE9D0
	
		// Constructors
		public UIToggleGroup() {} // 0x000000018582C570-0x000000018582C610
	
		// Methods
		protected override void Awake() {} // 0x00000001849D8D30-0x00000001849D8F30
		protected override void OnEnable() {} // 0x00000001857DCA50-0x00000001857DCB50
		protected override void OnDisable() {} // 0x0000000185C2B540-0x0000000185C2B630
		protected override void OnDestroy() {} // 0x000000018BC1A0FC-0x000000018BC1A1D8
		public void MoveToNext() {} // 0x000000018BC1A04C-0x000000018BC1A0A4
		public void MoveToPrevious() {} // 0x000000018BC1A0A4-0x000000018BC1A0FC
		private void _MoveTo(bool isNext) {} // 0x000000018BC1A1D8-0x000000018BC1A5B4
		public void __iFixBaseProxy_Awake() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnEnable() {} // 0x00000001857DCA40-0x00000001857DCA50
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000185492010-0x0000000185492020
		public void __iFixBaseProxy_OnDestroy() {} // 0x0000000185492010-0x0000000185492020
	}

	public enum FingerMoveDirection // TypeDefIndex: 50359
	{
		None = 0,
		Anisotropy = 1,
		Same = 2
	}

	public class UITouchPanel : TickableUIMono, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IUIClearable, IBindingGroupTarget // TypeDefIndex: 50360
	{
		// Fields
		private float _gestureZoomSensitivity; // 0x68
		private float _dragThreshold; // 0x6C
		private float _longPressTime; // 0x70
		private float _longPressMaxDist; // 0x74
		private float _mouseZoomSensitivity; // 0x78
		private float _scrollZoomSensitivity; // 0x7C
		private bool _useGesturePixelSizeAdjustment; // 0x80
		private float _multiClickInterval; // 0x84
		private int _multiClickPixelOffset; // 0x88
		private bool _ignoreClickOnLongPress; // 0x8C
		private bool _clickThrough; // 0x8D
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
		private Vector2 _curPressPos_k__BackingField; // 0x1B8
		private bool _isPointerEntered_k__BackingField; // 0x1C0
		public bool enableZoom; // 0x1C1
		public DisposedUnityEvent<PointerEventData> rawOnDrag; // 0x1C8
		private float m_leftMousePressDownTimeWithNoCursor; // 0x1D0
		private float m_rightMousePressDownTimeWithNoCursor; // 0x1D4
		private int m_groupId; // 0x1D8
		private bool m_bindingInit; // 0x1DC
		private InputBindingGroupMonoTarget _parent_k__BackingField; // 0x1E0
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x0000000185FB6A10-0x0000000185FB6A20 
		public Vector2 touchPos { get => default; } // 0x000000018BC1AFC0-0x000000018BC1AFF8 
		public Vector2 curPressPos { get; set; } // 0x0000000185FD6E70-0x0000000185FD6E90 0x0000000185FD6E90-0x0000000185FD6EA0
		public bool isPointerEntered { get; private set; } // 0x0000000185FB93C0-0x0000000185FB93D0 0x0000000185FD6CE0-0x0000000185FD6CF0
		public bool isDragging { get => default; } // 0x000000018349D740-0x000000018349D750 
		public bool groupEnabled { get => default; } // 0x0000000185391F30-0x0000000185391F90 
		public int groupId { get => default; } // 0x00000001864753F4-0x0000000186475410 
		public IBindingGroupTarget parentTarget { get => default; } // 0x0000000185FB8570-0x0000000185FB8580 
		public InputBindingGroupMonoTarget parent { get; private set; } // 0x0000000185FB8570-0x0000000185FB8580 0x0000000187A47668-0x0000000187A4767C
	
		// Constructors
		public UITouchPanel() {} // 0x0000000184816170-0x0000000184816750
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000185B36F00-0x0000000185B37850
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000185BA6700-0x0000000185BA6780
		public void DoEndDrag(Vector2 dragPos) {} // 0x000000018457C850-0x000000018457C9E0
		public void OnDrag(PointerEventData eventData) {} // 0x0000000185727EB0-0x0000000185727FF0
		public void OnPointerDown(PointerEventData eventData) {} // 0x0000000184680910-0x0000000184681350
		public void OnPointerUp(PointerEventData eventData) {} // 0x00000001858F3210-0x00000001858F33B0
		public void OnPointerClick(PointerEventData eventData) {} // 0x0000000184FC1630-0x0000000184FC3260
		public void OnPointerEnter(PointerEventData eventData) {} // 0x000000018467D300-0x000000018467D350
		public void OnPointerExit(PointerEventData eventData) {} // 0x000000018467D2B0-0x000000018467D300
		private void _OnActionPress(PointerEventData eventData) {} // 0x0000000184681350-0x0000000184681A00
		private void _OnActionRelease(PointerEventData eventData) {} // 0x00000001858F33B0-0x00000001858F34C0
		private bool _IsSameTouchFromPress(PointerEventData eventData) => default; // 0x000000018457B0D0-0x000000018457B130
		public void ClearTouchInfo() {} // 0x0000000185F60190-0x0000000185F60200
		public void OnScroll(PointerEventData eventData) {} // 0x000000018BC1ADE0-0x000000018BC1AEC4
		public void SimulateClick(PointerEventData eventData) {} // 0x000000018BC1AEC4-0x000000018BC1AF28
		public void DeActiveTouch(int touchId) {} // 0x000000018BC1AD2C-0x000000018BC1ADE0
		protected override void OnAwake() {} // 0x00000001849D9050-0x00000001849D90D0
		public override void Tick(float deltaTime) {} // 0x000000018432E7D0-0x000000018432EEA0
		public override void LateTick(float deltaTime) {} // 0x000000018457CE00-0x000000018457CF80
		protected override void OnEnable() {} // 0x00000001849D9010-0x00000001849D9050
		protected override void OnDisable() {} // 0x0000000185F60120-0x0000000185F60190
		protected override void OnDestroy() {} // 0x0000000185F5D940-0x0000000185F5D9E0
		protected override void OnRelease() {} // 0x0000000185AE9A00-0x0000000185AE9A40
		public void InitBinding() {} // 0x00000001849D8AE0-0x00000001849D8D30
		private void _UpdateState() {} // 0x00000001849D8F30-0x00000001849D9010
		public void ClearComponent() {} // 0x0000000185AE9A40-0x0000000185AE9CC0
		private void _InitBinding_b__110_0() {} // 0x000000018BC1AF28-0x000000018BC1AF74
		private void _InitBinding_b__110_1() {} // 0x000000018BC1AF74-0x000000018BC1AFC0
		public void __iFixBaseProxy_OnAwake() {} // 0x0000000187AB03B8-0x0000000187AB03C0
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018311B6C0-0x000000018311B6D0
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000187AAA404-0x0000000187AAA40C
		public void __iFixBaseProxy_OnDestroy() {} // 0x00000001880AA28C-0x00000001880AA294
		public void __iFixBaseProxy_OnRelease() {} // 0x000000018792FE0C-0x000000018792FE14
	}

	public class UIVFXManager : TickableUIMono, IMaterialModifier // TypeDefIndex: 50361
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
		protected override TickType tickOption { get => default; } // 0x0000000185FB6DA0-0x0000000185FB6DB0 
		public Graphic graphic { get => default; } // 0x000000018BC1B84C-0x000000018BC1B914 
		public UISoftMaskable softMaskable { get => default; } // 0x000000018BC1B914-0x000000018BC1B9DC 
	
		// Constructors
		public UIVFXManager() {} // 0x0000000185B888B0-0x0000000185B88950
		static UIVFXManager() {} // 0x0000000185F81E20-0x0000000185F81E70
	
		// Methods
		protected override void OnEnable() {} // 0x000000018BC1B1EC-0x000000018BC1B374
		public override void LateTick(float deltaTime) {} // 0x000000018BC1AFF8-0x000000018BC1B090
		private void _OnEnableRuntimeAtlas() {} // 0x000000018BC1B5AC-0x000000018BC1B5FC
		protected override void OnDisable() {} // 0x000000018BC1B090-0x000000018BC1B1EC
		private void _Clear() {} // 0x000000018BC1B374-0x000000018BC1B524
		private void _DestroyMaterial(Material material) {} // 0x000000018BC1B524-0x000000018BC1B5AC
		private void _UpdateParam() {} // 0x000000018BC1B5FC-0x000000018BC1B84C
		public Material GetModifiedMaterial(Material baseMaterial) => default; // 0x0000000185D21BB0-0x0000000185D21C70
		public void __iFixBaseProxy_OnEnable() {} // 0x0000000187AAA40C-0x0000000187AAA414
		public void __iFixBaseProxy_LateTick(float P0) {} // 0x0000000187A742A0-0x0000000187A742A8
		public void __iFixBaseProxy_OnDisable() {} // 0x0000000187AAA404-0x0000000187AAA40C
	}

	public class UIWorldLevelScrollListAnimCtrl : MonoBehaviour // TypeDefIndex: 50364
	{
		// Fields
		public ScrollListLayoutInfo upLayoutGroup; // 0x18
		public ScrollListLayoutInfo downLayoutGroup; // 0x20
		public ScrollListLayoutInfo middleLayoutGroup; // 0x28
		public AnimationCurve speedCurve; // 0x30
		private IEnumerator m_enumerator; // 0x38
		private string _audioEnd; // 0x40
	
		// Nested types
		[Serializable]
		public class ScrollListLayoutInfo // TypeDefIndex: 50362
		{
			// Fields
			public VerticalLayoutGroup layoutGroup; // 0x10
			public RectTransform layoutRectTransform; // 0x18
			public LayoutElement cell; // 0x20
	
			// Properties
			public float cellHeight { get => default; } // 0x000000018BC1BC1C-0x000000018BC1BCD8 
	
			// Constructors
			public ScrollListLayoutInfo() {} // 0x000000018BC1BA4C-0x000000018BC1BB30
		}
	
		private sealed class __ScrollLayouts_d__12 : IEnumerator<object> // TypeDefIndex: 50363
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIWorldLevelScrollListAnimCtrl __4__this; // 0x20
			public bool isUp; // 0x28
			public int count; // 0x2C
			private float _elapsedTime_5__2; // 0x30
			private float _duration_5__3; // 0x34
			private Vector2 _upStartPos_5__4; // 0x38
			private Vector2 _downStartPos_5__5; // 0x40
			private Vector2 _middleStartPos_5__6; // 0x48
			private Vector2 _upEndPos_5__7; // 0x50
			private Vector2 _downEndPos_5__8; // 0x58
			private Vector2 _middleEndPos_5__9; // 0x60
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BC1BD84-0x000000018BC1BE38 
			object IEnumerator.Current { get => default; } // 0x000000018BC16358-0x000000018BC16438 
	
			// Constructors
			public __ScrollLayouts_d__12() {} // Dummy constructor
			public __ScrollLayouts_d__12(int __1__state) {} // 0x000000018BC1BB30-0x000000018BC1BC1C
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BC1BCD8-0x000000018BC1BD84
			private bool MoveNext() => default; // 0x000000018BC1B9DC-0x000000018BC1BA4C
			void IEnumerator.Reset() {} // 0x000000018BC1BE38-0x000000018BC1BE80
		}
	
		// Constructors
		public UIWorldLevelScrollListAnimCtrl() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public void UpdateUpPos(int current) {} // 0x0000000185492010-0x0000000185492020
		public void UpdateDownPos(int current) {} // 0x0000000181378230-0x0000000181378240
		public void UpdateMidPos(int current) {} // 0x0000000185492010-0x0000000185492020
		public void UpdateWorldLevelScrollList(bool isUp, int count) {} // 0x000000018BC16718-0x000000018BC16E4C
		private void OnDisable() {} // 0x0000000181377E40-0x0000000181377E50
		private IEnumerator _ScrollLayouts(bool isUp, int count) => default; // 0x000000018BC16E4C-0x000000018BC16E98
	}

	public class VirtualMouseInitPos : MonoBehaviour // TypeDefIndex: 50365
	{
		// Fields
		private LuaPanel m_panel; // 0x18
	
		// Properties
		public LuaPanel panel { get => default; } // 0x000000018BC1BFFC-0x000000018BC1C0B4 
	
		// Constructors
		public VirtualMouseInitPos() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void OnEnable() {} // 0x000000018BC1BE80-0x000000018BC1BFFC
	}

	public class CSPopupPanel : MonoBehaviour // TypeDefIndex: 50366
	{
		// Fields
		public const string KEY = "CSPopupPanel"; // Metadata: 0x02061DDD
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
		public CSPopupPanel() {} // 0x000000018646DB20-0x000000018646DB28
		static CSPopupPanel() {} // 0x000000018BC149A4-0x000000018BC14A38
	
		// Methods
		private void Awake() {} // 0x000000018BC13ED0-0x000000018BC14014
		private void _OnConfirm(PointerEventData p) {} // 0x000000018BC14900-0x000000018BC149A4
		private void _OnCancel(PointerEventData p) {} // 0x000000018BC1485C-0x000000018BC14900
		private void OnDestroy() {} // 0x000000018BC14208-0x000000018BC143CC
		public static void Show(string content, Action onConfirm, bool showCancel = false /* Metadata: 0x02061DDB */, Action onCancel = null, string confirmTxt = null, string cancelTxt = null, bool showWarning = false /* Metadata: 0x02061DDC */) {} // 0x000000018BC143CC-0x000000018BC1485C
		public static void ClearAllPanels() {} // 0x000000018BC14014-0x000000018BC14208
	}

	public class LuaUIRoot : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 50367
	{
		// Fields
		public SerializeReferenceDictionary<string, LuaUIRootNode> nodeDic; // 0x18
	
		// Constructors
		public LuaUIRoot() {} // 0x000000018BC16068-0x000000018BC160E8
	}

	public class LuaUIRootNode : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 50368
	{
		// Fields
		public string panelName; // 0x18
		public string panelFolder; // 0x20
	
		// Constructors
		public LuaUIRootNode() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class MobileMotionManager : BaseManager // TypeDefIndex: 50370
	{
		// Fields
		private const string COMMON_MOTION_SHORT = "au_vibration_common_short"; // Metadata: 0x02061DEA
		private const string COMMON_MOTION_OPERATE_SUCCESS = "au_vibration_common_action_success"; // Metadata: 0x02061E04
		private const string COMMON_MOTION_OPERATE_FAILURE = "au_vibration_common_action_fail"; // Metadata: 0x02061E27
		private const string MOTION_LEVEL_LOW = "au_motion_resolution_state_low"; // Metadata: 0x02061E47
		private const string MOTION_LEVEL_MEDIUM = "au_motion_resolution_state_medium"; // Metadata: 0x02061E66
		private const string MOTION_LEVEL_HIGH = "au_motion_resolution_state_high"; // Metadata: 0x02061E88
		private MotionLevel m_currMotionLevel; // 0x18
	
		// Nested types
		private enum MotionLevel // TypeDefIndex: 50369
		{
			NONE = 0,
			LOW = 1,
			MEDIUM = 2,
			HIGH = 3
		}
	
		// Constructors
		public MobileMotionManager() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected override void OnInit() {} // 0x00000001845A2E60-0x00000001845A2F70
		protected override void OnRelease() {} // 0x000000018BC160E8-0x000000018BC161F8
		public uint PostEventCommonShort() => default; // 0x0000000185F538C0-0x0000000185F539F0
		public uint PostEventCommonOperateSuccess() => default; // 0x000000018BC1626C-0x000000018BC162E0
		public uint PostEventCommonOperateFailure() => default; // 0x000000018BC161F8-0x000000018BC1626C
		public uint PostEvent(string eventName) => default; // 0x000000018BC162E0-0x000000018BC16358
		private void _CheckMotionLevelAndPostIfChange() {} // 0x00000001845A2C90-0x00000001845A2D40
	}

	public static class I18nFontLoader // TypeDefIndex: 50371
	{
		// Fields
		private static Dictionary<int, FAssetProxyHandle> s_id2FontDic; // 0x00
		private static Dictionary<string, FAssetProxyHandle> s_name2MaterialDic; // 0x08
		private static FAssetProxyHandle s_fontSearchDataHandle; // 0x10
	
		// Properties
		public static I18nFontSearchData fontSearchData { get; } // 0x0000000184248BD0-0x0000000184248D90 
	
		// Constructors
		static I18nFontLoader() {} // 0x0000000185EB7DF0-0x0000000185EB7EE0
	
		// Methods
		public static bool IsInvalid() => default; // 0x0000000184248D90-0x0000000184248EB0
		public static Material GetMaterial(string matName) => default; // 0x000000018BC15E1C-0x000000018BC16068
		public static TMP_FontAsset GetI18nFont(int cnFontId) => default; // 0x0000000184247C30-0x0000000184248BD0
		public static TMP_FontAsset GetCNFont(int cnFontId) => default; // 0x0000000183ED06E0-0x0000000183ED0D10
		private static TMP_FontAsset _GetFontById(int fontId) => default; // 0x0000000183ED0D10-0x0000000183ED2A10
		public static int GetCNFontId(TMP_FontAsset font) => default; // 0x000000018BC15D7C-0x000000018BC15E1C
		public static bool IsFontDefaultMaterial(Material mat) => default; // 0x0000000185040310-0x00000001850403B0
	}

	public class DynamicFontAssetLoader : IFontAssetLoader // TypeDefIndex: 50373
	{
		// Fields
		private List<FontAssetRef> _fontAssets_k__BackingField; // 0x10
		private static HashSet<uint> s_notFoundUnicodes; // 0x00
	
		// Properties
		public List<FontAssetRef> fontAssets { get; private set; } // 0x000000018BC14BDC-0x000000018BC15034 0x000000018BC15034-0x000000018BC151A0
	
		// Nested types
		public class FontAssetRef // TypeDefIndex: 50372
		{
			// Fields
			public I18nFontSearchData.FontAssetInfo fontAssetInfo; // 0x10
			private HashSet<TMP_Text> m_refTexts; // 0x18
			private FAssetProxyHandle m_assetHandle; // 0x20
			private TMP_FontAsset m_fontAsset; // 0x38
	
			// Constructors
			public FontAssetRef() {} // 0x0000000185C16200-0x0000000185C163C0
	
			// Methods
			public TMP_FontAsset GetFontAsset(TMP_Text refText) => default; // 0x000000018346D130-0x000000018346D140
			public void RemoveRefText(TMP_Text refText) {} // 0x0000000184096E30-0x0000000184096EF0
			public void Dispose() {} // 0x000000018580E110-0x000000018580E2E0
		}
	
		// Constructors
		public DynamicFontAssetLoader() {} // 0x000000018BC14A38-0x000000018BC14BDC
		static DynamicFontAssetLoader() {} // 0x000000018580E2E0-0x000000018580E360
	
		// Methods
		public static void AddNotFoundUnicode(uint unicode, bool forceLog = false /* Metadata: 0x02061EAC */) {} // 0x0000000185F404E0-0x0000000185F40570
		public bool TryGetFontAsset(TMP_Text refText, uint unicode, out TMP_FontAsset fontAsset) {
			fontAsset = default;
			return default;
		} // 0x000000018BC15AEC-0x000000018BC15C84
		public void TryRemoveRefText(TMP_Text refText) {} // 0x000000018BC15C84-0x000000018BC15D7C
		public void Dispose() {} // 0x000000018BC15A3C-0x000000018BC15AEC
	}

	public static class TweenUtils // TypeDefIndex: 50375
	{
		// Nested types
		public struct FLerpByTime // TypeDefIndex: 50374
		{
			// Fields
			public static FLerpByTime EMPTY; // 0x00
			private bool _isEmpty_k__BackingField; // 0x00
			private FScaledStopwatch m_timer; // 0x08
			public float startValue; // 0x20
			public float endValue; // 0x24
			public float duration; // 0x28
	
			// Properties
			public bool isEmpty { get; private set; } // 0x00000001844C1EE0-0x00000001844C1FB0 0x00000001835E3010-0x00000001835E3020
	
			// Constructors
			static FLerpByTime() {
				EMPTY = default;
			} // 0x000000018BC151A0-0x000000018BC15288
	
			// Methods
			public void Start(ITickOwner timeScaleProvider = null) {} // 0x0000000185FB0F60-0x0000000185FB0F70
			public float GetValue(out bool isTweenFinished) {
				isTweenFinished = default;
				return default;
			} // 0x000000018BC15288-0x000000018BC152EC
		}
	
		// Methods
		public static bool TickAsCountDown(ref float countDown, float timeDelta) => default; // 0x000000018BC152EC-0x000000018BC15354
	}

	public class UIAnimationLayerMixPlayer : SingleMixerAssetPlayer<AnimationClip, AnimationClipPlayable, AnimationLayerMixerPlayable, AnimationPlayableOutput> // TypeDefIndex: 50376
	{
		// Fields
		private Animator m_target; // 0x60
		private string m_outputName; // 0x68
	
		// Constructors
		public UIAnimationLayerMixPlayer() {} // Dummy constructor
		public UIAnimationLayerMixPlayer(Animator target, string outputName) {} // 0x0000000184F42B20-0x0000000184F42B90
	
		// Methods
		public void LockToClip(AnimationClip clip, float clipPos) {} // 0x0000000184F41DA0-0x0000000184F41EA0
		protected override PlayableGraph CreateGraph() => default; // 0x0000000184D40A60-0x0000000184D40AB0
		protected override AnimationLayerMixerPlayable CreateMixer(PlayableGraph graph, out GenericShareSingleMixerAssetPlayer<AnimationClip> options) {
			options = default;
			return default;
		} // 0x0000000184D40B20-0x0000000184D40C10
		protected override AnimationPlayableOutput CreateOutput(PlayableGraph graph) => default; // 0x0000000184D40AB0-0x0000000184D40B20
		protected override AnimationClipPlayable CreateSourceFromAsset(AnimationClip clip, PlayableGraph graph, out GenericShareSingleMixerAssetPlayer<AnimationClip> meta) {
			meta = default;
			return default;
		} // 0x0000000184D40980-0x0000000184D40A60
	}

	public class UIAnimationMixPlayer : SingleMixerAssetPlayer<AnimationClip, AnimationClipPlayable, AnimationMixerPlayable, AnimationPlayableOutput> // TypeDefIndex: 50377
	{
		// Fields
		private Animator m_target; // 0x60
		private string m_outputName; // 0x68
	
		// Constructors
		public UIAnimationMixPlayer() {} // Dummy constructor
		public UIAnimationMixPlayer(Animator target, string outputName) {} // 0x0000000184F42880-0x0000000184F428F0
	
		// Methods
		public void LockToClip(AnimationClip clip, float clipPos) {} // 0x0000000184F428F0-0x0000000184F42A00
		protected override PlayableGraph CreateGraph() => default; // 0x0000000184D403E0-0x0000000184D40430
		protected override AnimationMixerPlayable CreateMixer(PlayableGraph graph, out GenericShareSingleMixerAssetPlayer<AnimationClip> options) {
			options = default;
			return default;
		} // 0x0000000184D408C0-0x0000000184D40980
		protected override AnimationPlayableOutput CreateOutput(PlayableGraph graph) => default; // 0x0000000184D40510-0x0000000184D40580
		protected override AnimationClipPlayable CreateSourceFromAsset(AnimationClip clip, PlayableGraph graph, out GenericShareSingleMixerAssetPlayer<AnimationClip> meta) {
			meta = default;
			return default;
		} // 0x0000000184D3FE30-0x0000000184D3FF10
	}

	public class UIListCache<TComp> // TypeDefIndex: 50380
		where TComp : Component
	{
		// Fields
		private FOptions m_options;
		private List<ItemWrapper> m_items;
		private int m_count;
	
		// Nested types
		public struct FOptions // TypeDefIndex: 50378
		{
			// Fields
			public TComp cellTemplate;
			public Transform parent;
			public Action<TComp> onItemCreated;
		}
	
		private class ItemWrapper // TypeDefIndex: 50379
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
		public void Refresh(int count, Action<TComp, int> refreshFunc, bool shouldHide = false /* Metadata: 0x02061EAD */, Action<TComp, int> onDisableFunc = null) {}
		public TComp GetItem(int index) => default;
		private ItemWrapper _CreateNewItem() => default;
	}

	public class UILoadImageSprite : MonoBehaviour // TypeDefIndex: 50382
	{
		// Fields
		public bool isAsync; // 0x18
		public bool setNativeSize; // 0x19
		protected string m_spritePath; // 0x20
		protected Image m_imageComp; // 0x28
		protected FAssetProxyHandle m_handle; // 0x30
	
		// Properties
		public string spritePath { get => default; set {} } // 0x000000018BC16F40-0x000000018BC16FA0 0x000000018BC16FA0-0x000000018BC172CC
	
		// Nested types
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 50381
		{
			// Fields
			public UILoadImageSprite __4__this; // 0x10
			public string path; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0() {} // 0x00000001813B31A0-0x00000001813B31B0
	
			// Methods
			internal void __LoadSprite_b__0(bool isOk, FAssetProxyHandle handle) {} // 0x000000018BC172CC-0x000000018BC17350
		}
	
		// Constructors
		public UILoadImageSprite() {} // 0x000000018BC16500-0x000000018BC1667C
	
		// Methods
		private void OnDestroy() {} // 0x000000018646DB20-0x000000018646DB28
		private void _LoadSprite(string path) {} // 0x0000000185492010-0x0000000185492020
	}

	public class UILoadImageSpriteByName : UILoadImageSprite // TypeDefIndex: 50383
	{
		// Fields
		private string _folderPath; // 0x48
	
		// Properties
		public string spriteName { set {} } // 0x000000018BC16E98-0x000000018BC16F40
	
		// Constructors
		public UILoadImageSpriteByName() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public abstract class UISwitchTween // TypeDefIndex: 50390
	{
		// Fields
		private Options m_options; // 0x10
		private ITweenHandler m_tween; // 0x20
		private bool m_isInited; // 0x28
		private bool m_isShowing; // 0x29
		private TweenContext m_context; // 0x2C
	
		// Properties
		public bool isTweening { get; } // 0x000000018BC1649C-0x000000018BC16500 
		public bool isShow { get; set; } // 0x0000000184B8EA00-0x0000000184B8EAB0 0x0000000184B8C720-0x0000000184B8C760
	
		// Nested types
		public struct Options // TypeDefIndex: 50384
		{
			// Fields
			private Action _onShown_k__BackingField; // 0x00
			private Action _onHiden_k__BackingField; // 0x08
	
			// Properties
			public Action onShown { get; set; }
			public Action onHiden { get; set; } // 0x000000018BC19724-0x000000018BC19768 0x0000000185EC52E0-0x0000000185EC5310
		}
	
		protected struct TweenContext // TypeDefIndex: 50385
		{
			// Fields
			public float lastStopPos; // 0x00
	
			// Methods
			public bool IsInterapted() => default; // 0x0000000185D227E0-0x0000000185D22810
			public void OnReset() {} // 0x000000018BC196E0-0x000000018BC19724
			public void OnTweenStop(ITweenProgress tweenProgress) {} // 0x000000018BC197B4-0x000000018BC19808
		}
	
		public interface ITweenHandler : IHotfixable // TypeDefIndex: 50386
		{
			// Methods
			ITweenHandler SetAutoKill(bool autoKill); // 0x0000000184B8C220-0x0000000184B8C3A0
			ITweenHandler OnComplete(TweenCallback callback); // 0x000000018420F9D0-0x000000018420FB00
			bool IsPlaying(); // 0x000000018BC1987C-0x000000018BC1990C
			void KillIfNecessary(); // 0x000000018BC19808-0x000000018BC1987C
		}
	
		public interface ITweenProgress : IHotfixable // TypeDefIndex: 50387
		{
			// Methods
			float GetCurrPos(); // 0x0000000184B8EAB0-0x0000000184B8EAD0
		}
	
		public class TweenWrapper : ITweenHandler // TypeDefIndex: 50388
		{
			// Fields
			private DG.Tweening.Tween m_tween; // 0x10
	
			// Constructors
			public TweenWrapper() {} // Dummy constructor
			public TweenWrapper(DG.Tweening.Tween tween) {} // 0x00000001813B34D0-0x00000001813B34E0
	
			// Methods
			public bool IsActive() => default; // 0x000000018420F9A0-0x000000018420F9D0
			public bool IsPlaying() => default; // 0x0000000184B8C4E0-0x0000000184B8C540
			public void KillIfNecessary() {} // 0x0000000184B8BE60-0x0000000184B8BEA0
			public ITweenHandler OnComplete(TweenCallback callback) => default; // 0x0000000184B8C540-0x0000000184B8C5E0
			public ITweenHandler SetAutoKill(bool autoKill) => default; // 0x000000018BC19768-0x000000018BC197B4
		}
	
		private sealed class _WaitForTweening_d__19 : IEnumerator<object> // TypeDefIndex: 50389
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UISwitchTween __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x0000000185EF8DD0-0x0000000185EF8E00 
			object IEnumerator.Current { get => default; } // 0x000000018646FE2C-0x000000018646FE34 
	
			// Constructors
			public _WaitForTweening_d__19() {} // Dummy constructor
			public _WaitForTweening_d__19(int __1__state) {} // 0x0000000184B8C5E0-0x0000000184B8C630
	
			// Methods
			void IDisposable.Dispose() {} // 0x0000000185492010-0x0000000185492020
			private bool MoveNext() => default; // 0x0000000185D227B0-0x0000000185D227E0
			void IEnumerator.Reset() {} // 0x00000001834AFB60-0x00000001834AFB70
		}
	
		// Constructors
		protected UISwitchTween() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		protected abstract ITweenHandler GenerateTweenOfShow(); // 0x000000018357A260-0x000000018357A270
		protected abstract ITweenHandler GenerateTweenOfHide(); // 0x00000001877900A4-0x00000001877900B4
		protected virtual void BeforeShowEffect() {} // 0x000000018BC16438-0x000000018BC1649C
		protected virtual void BeforeHideEffect() {} // 0x0000000184B8C690-0x0000000184B8C720
		protected virtual void AfterShowEffect() {} // 0x0000000184B8C630-0x0000000184B8C690
		protected virtual void AfterHideEffect() {}
		protected virtual void ResetToState(bool isShow) {}
		public void Show() {}
		public void Hide() {}
		public IEnumerator WaitForTweening() => default;
		public void SetOptions(Options options) {} // 0x0000000184096E30-0x0000000184096EF0
		public void Reset(bool isShow) {} // 0x0000000184B8C3A0-0x0000000184B8C470
		public void Clear() {} // 0x0000000184B8C470-0x0000000184B8C4E0
		private void _ClearTweenInternal(bool isReset) {} // 0x0000000181378230-0x0000000181378240
		protected TweenContext GetContext() => default; // 0x0000000185492010-0x0000000185492020
		protected void ClearTween() {} // 0x000000018BC1667C-0x000000018BC166CC
		private void _Show_b__17_0() {} // 0x000000018BC166CC-0x000000018BC16718
		private void _Hide_b__18_0() {} // 0x0000000181377E40-0x0000000181377E50
	}

	public class FadeSwitchTween : UISwitchTween // TypeDefIndex: 50393
	{
		// Fields
		public const float DEFAULT_TWEEN_DURATION = 0.16f; // Metadata: 0x02061EB3
		private CanvasGroup m_alphaHandler; // 0x30
		private bool m_ignoreTimeScale; // 0x38
		private float m_activeAlpha; // 0x3C
		private bool _dontDisableGameObject_k__BackingField; // 0x40
		private bool _controlBlockRaycast_k__BackingField; // 0x41
		private Durations _complexDuration_k__BackingField; // 0x44
		private float _duration_k__BackingField; // 0x54
	
		// Properties
		protected bool dontDisableGameObject { get; private set; } // 0x0000000185FB0D90-0x0000000185FB0DA0 0x0000000185FD6DB0-0x0000000185FD6DC0
		protected bool controlBlockRaycast { get; private set; } // 0x0000000185FD6DC0-0x0000000185FD6DD0 0x000000018BC153A4-0x000000018BC153C8
		protected Durations complexDuration { get; private set; } // 0x0000000184B8BD50-0x0000000184B8BE10 0x0000000183F80440-0x0000000183F80450
		public float duration { get; set; } // 0x0000000185FB0580-0x0000000185FB0590 0x000000018BC153C8-0x000000018BC15444
		public CanvasGroup alphaHandler { get => default; } // 0x0000000185749260-0x00000001857493A0 
		public float activeAlpha { get => default; set {} } // 0x00000001857493A0-0x00000001857494E0 0x00000001856A4DA0-0x00000001856A4E00
	
		// Nested types
		public struct Durations // TypeDefIndex: 50391
		{
			// Fields
			public float show; // 0x00
			public float showDelay; // 0x04
			public float hide; // 0x08
			public float hideDelay; // 0x0C
	
			// Methods
			public float GetShowDuration(float defaultDuration) => default; // 0x0000000185FB0650-0x0000000185FB0660
			public float GetHideDuration(float defaultDuration) => default; // 0x0000000185FB0660-0x0000000185FB0670
		}
	
		public struct Builder // TypeDefIndex: 50392
		{
			// Fields
			public CanvasGroup alphaHandler; // 0x00
			public bool useTimeScale; // 0x08
			public bool dontDisableGameObject; // 0x09
			public bool controlBlockRaycast; // 0x0A
			public float duration; // 0x0C
			public Durations complexDuration; // 0x10
	
			// Methods
			public FadeSwitchTween Build() => default; // 0x0000000185FB0D70-0x0000000185FB0D80
		}
	
		// Constructors
		public FadeSwitchTween() {} // Dummy constructor
		public FadeSwitchTween(CanvasGroup alphaHandler, bool ignoreTimeScale) {} // 0x0000000183F804D0-0x0000000183F804E0
		public FadeSwitchTween(CanvasGroup alphaHandler, float duration = 0.16f /* Metadata: 0x02061EAE */, bool ignoreTimeScale = true /* Metadata: 0x02061EB2 */) {} // 0x00000001813B51D0-0x00000001813B51E0
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide() => default; // 0x00000001856A4E00-0x00000001856A4E40
		protected override ITweenHandler GenerateTweenOfShow() => default; // 0x00000001856A4E40-0x00000001856A4EB0
		protected sealed override void BeforeShowEffect() {} // 0x00000001856A4EB0-0x00000001856A4F20
		protected sealed override void AfterHideEffect() {} // 0x000000018BC15354-0x000000018BC153A4
		protected sealed override void ResetToState(bool isShow) {} // 0x000000018BBEB874-0x000000018BBEB87C
		protected virtual void SetObjectActive(CanvasGroup alphaHandler, bool isActive) {} // 0x000000018BBEB86C-0x000000018BBEB874
		public void Release() {} // 0x000000018BBEB87C-0x000000018BBEB884
		public void __iFixBaseProxy_BeforeShowEffect() {} // 0x00000001857494E0-0x0000000185749520
		public void __iFixBaseProxy_AfterHideEffect() {} // 0x0000000185749520-0x0000000185749560
		public void __iFixBaseProxy_ResetToState(bool P0) {} // 0x0000000184B8C140-0x0000000184B8C220
	}

	public class FadeTranslationSwitchTween : UISwitchTween // TypeDefIndex: 50395
	{
		// Fields
		private const float DEFAULT_TWEEN_DURATION = 0.16f; // Metadata: 0x02061EC3
		private CanvasGroup m_alphaHandler; // 0x30
		private RectTransform m_posHandler; // 0x38
		private Vector2 m_hidePos; // 0x40
		private Vector2 m_showPos; // 0x48
		private float m_duration; // 0x50
		private float m_hideDelay; // 0x54
		private float m_showDelay; // 0x58
	
		// Nested types
		private class TweenHandler : UISwitchTween.ITweenHandler // TypeDefIndex: 50394
		{
			// Fields
			private DG.Tweening.Tween m_alphaTweener; // 0x10
			private DG.Tweening.Tween m_posTweener; // 0x18
	
			// Constructors
			public TweenHandler() {} // Dummy constructor
			public TweenHandler(DG.Tweening.Tween alpha, DG.Tweening.Tween pos) {} // 0x000000018BC15930-0x000000018BC15A3C
	
			// Methods
			public bool IsPlaying() => default; // 0x000000018BC1550C-0x000000018BC1564C
			public void KillIfNecessary() {} // 0x000000018BC1564C-0x000000018BC1578C
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback) => default; // 0x000000018BC154A8-0x000000018BC1550C
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill) => default; // 0x000000018BC15444-0x000000018BC154A8
		}
	
		// Constructors
		public FadeTranslationSwitchTween() {} // Dummy constructor
		public FadeTranslationSwitchTween(CanvasGroup alphaHandler, RectTransform posHandler, Vector2 hidePos, Vector2 showPos, float duration = 0.16f /* Metadata: 0x02061EB7 */, float hideDelay = 0f /* Metadata: 0x02061EBB */, float showDelay = 0f /* Metadata: 0x02061EBF */) {} // 0x000000018BC1578C-0x000000018BC15850
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide() => default; // 0x000000018BC15850-0x000000018BC158B8
		protected override ITweenHandler GenerateTweenOfShow() => default; // 0x000000018BC158B8-0x000000018BC15930
		protected override void BeforeShowEffect() {} // 0x000000018BBEB874-0x000000018BBEB87C
		protected override void AfterHideEffect() {} // 0x000000018BBEB86C-0x000000018BBEB874
		protected override void ResetToState(bool isShow) {} // 0x000000018BBEB87C-0x000000018BBEB884
		private float _GetTargetAlpha(bool isShow) => default; // 0x00000001841BC230-0x00000001841BC260
		private Vector2 _GetTargetPos(bool isShow) => default; // 0x000000018BC21F08-0x000000018BC21F70
		public void __iFixBaseProxy_BeforeShowEffect() {} // 0x000000018BC21F70-0x000000018BC21FF8
		public void __iFixBaseProxy_AfterHideEffect() {} // 0x000000018BC21FF8-0x000000018BC22080
		public void __iFixBaseProxy_ResetToState(bool P0) {} // 0x000000018BC22080-0x000000018BC2211C
	}

	public class UIAtlasManager : Singleton<UIAtlasManager> // TypeDefIndex: 50401
	{
		// Fields
		private TickFunction m_lateTickFunction; // 0x10
		public const int ATLAS_PAGE_WIDTH = 2048; // Metadata: 0x02061EC7
		public const int ATLAS_PAGE_HEIGHT = 1024; // Metadata: 0x02061EC9
		public const int IMAGE_USING_ATLAS_MAX_SIZE = 512; // Metadata: 0x02061ECB
		public const int UI_IMAGE_BLOCK_ALIGNMENT = 4; // Metadata: 0x02061ECD
		public const int PANEL_LEVEL_COUNT = 4; // Metadata: 0x02061ECE
		public const int MAX_ATLAS_PER_PANEL_LEVEL = 4; // Metadata: 0x02061ECF
		public const int PROCESS_COUNT_PER_FRAME = 3; // Metadata: 0x02061ED0
		public const GraphicsFormat ATLAS_PAGE_FORMAT = GraphicsFormat.RGBA_BC7_UNorm; // Metadata: 0x02061ED1
		private bool m_enableRuntimeAtlas; // 0x18
		private Dictionary<int, UIImage> m_imageDict; // 0x20
		private UIAtlasPage[,] m_atlasPagePool; // 0x28
		private Queue<UIImage> m_insertQueue; // 0x30
		private Queue<UIAtlasHandle> m_freeQueue; // 0x38
		private CommandBuffer m_commandBuffer; // 0x40
		private GraphicsFormat m_atlasPageFormat; // 0x48
		private static bool _enableRuntimeAtlasFromScript_k__BackingField; // 0x00
	
		// Properties
		public static bool enableRuntimeAtlas { get => default; } // 0x000000018BC223C4-0x000000018BC2242C 
		public static bool enableRuntimeAtlasFromScript { get; set; } // 0x000000018BC229EC-0x000000018BC22AE8 0x000000018BC23974-0x000000018BC23AD8
		public static bool releaseImageSpriteAfterInsert { get => default; } // 0x000000018BC23AD8-0x000000018BC23C40 
	
		// Nested types
		public enum UIAtlasProcessStatus // TypeDefIndex: 50396
		{
			Invalid = 0,
			InsertWaiting = 1,
			InsertDone = 2
		}
	
		public enum UIAtlasProcessFailureCause // TypeDefIndex: 50397
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
	
		public struct UIAtlasHandle // TypeDefIndex: 50398
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
			} // 0x000000018404C390-0x000000018404C450
	
			// Methods
			public bool IsValid() => default; // 0x000000018BC23C78-0x000000018BC23CB0
			public static UIAtlasHandle CreateInvalidHandle(UIAtlasProcessFailureCause cause = UIAtlasProcessFailureCause.NoFailure /* Metadata: 0x02061EE5 */) => default; // 0x000000018BC23CB0-0x000000018BC23CEC
		}
	
		public class UIAtlasPage // TypeDefIndex: 50400
		{
			// Fields
			private readonly Texture2D _pageTexture_k__BackingField; // 0x10
			private readonly Dictionary<int, TextureRefHandle> _textureRefDict_k__BackingField; // 0x18
			private readonly AtlasMaxRect _rectBinPack_k__BackingField; // 0x20
	
			// Properties
			public int maxFreeRectWidth { get => default; } // 0x000000018BC2242C-0x000000018BC2262C 
			public int maxFreeRectHeight { get => default; } // 0x000000018BC2262C-0x000000018BC2267C 
			public Texture2D pageTexture { get; } // 0x000000018BC22700-0x000000018BC22750 
			public Dictionary<int, TextureRefHandle> textureRefDict { get; } // 0x000000018BC22B50-0x000000018BC22C78 
			public AtlasMaxRect rectBinPack { get; } // 0x000000018BC22AE8-0x000000018BC22B50 
	
			// Nested types
			public struct TextureRefHandle // TypeDefIndex: 50399
			{
				// Fields
				public int refCount; // 0x00
				public RectInt rect; // 0x04
	
				// Constructors
				public TextureRefHandle(int refCount, RectInt rect) {
					this.refCount = default;
					this.rect = default;
				} // 0x00000001840A27C0-0x00000001840A27D0
			}
	
			// Constructors
			public UIAtlasPage() {} // Dummy constructor
			public UIAtlasPage(int panelDepth, int index, GraphicsFormat atlasFormat) {} // 0x000000018BC23C40-0x000000018BC23C78
	
			// Methods
			public RectInt InsertRect(int width, int height) => default; // 0x000000018BC2227C-0x000000018BC22300
			public void CopyIntoAtlas(CommandBuffer cmd, Texture texture, in RectInt rect) {} // 0x000000018BC2267C-0x000000018BC22700
			public void InsertRects(List<RectInt> rects, List<RectInt> dst) {} // 0x0000000185280C40-0x0000000185280CA0
			public void FreeRect(in RectInt rect) {} // 0x0000000185280BE0-0x0000000185280C40
			public void FreeRects(in List<RectInt> rects) {} // 0x000000018BC22300-0x000000018BC223C4
		}
	
		// Constructors
		private UIAtlasManager() {} // 0x000000018BC22750-0x000000018BC229EC
	
		// Methods
		protected void OnInit() {} // 0x000000018BC22C78-0x000000018BC22F8C
		protected void OnUnInit() {} // 0x000000018BC22F8C-0x000000018BC236BC
		public void Release() {} // 0x000000018BC236BC-0x000000018BC23974
		private void _CreateTickFunction() {} // 0x0000000185FD6EA0-0x0000000185FD6ED0
		private void _ClearTickFunction() {} // 0x000000018BC2222C-0x000000018BC2227C
		public static void AddUIImageToManager(UIImage image) {} // 0x00000001840BF820-0x00000001840BF8D0
		public static void ReProcessInsertForUIImage(UIImage image) {} // 0x000000018BC2409C-0x000000018BC2422C
		public static void RemoveUIImageFromManager(UIImage image) {} // 0x000000018BC2422C-0x000000018BC24248
		public static void AddUIImageToManagerOnInstantiate(UIImage image) {} // 0x000000018B565A74-0x000000018B565A90
		public int GetAtlasCount() => default; // 0x000000018346D130-0x000000018346D140
		public void LateTick(float deltaTime) {} // 0x0000000181377E40-0x0000000181377E50
		private void _AddUIImageToManager(UIImage image) {} // 0x00000001813B31A0-0x00000001813B31B0
		private void _ReProcessInsertForUIImage(UIImage image) {} // 0x000000018BC23F70-0x000000018BC24014
		private void _RemoveUIImageFromManager(UIImage image) {} // 0x000000018BC23CEC-0x000000018BC23E98
		private void _AddUIImageToManagerOnInstantiate(UIImage image) {} // 0x000000018BC24014-0x000000018BC2409C
		private bool _IsRuntimeAtlasCompatible(UIImage image, out UIAtlasProcessFailureCause failureCause) {
			failureCause = default;
			return default;
		} // 0x000000018BC23E98-0x000000018BC23F04
		private void _ProcessInsertQueue() {} // 0x000000018BC23F04-0x000000018BC23F70
		private void _ProcessRemoveQueue() {} // 0x0000000185FC8390-0x0000000185FC83A0
	}

	public class UIRedDotAnimation : Singleton<UIRedDotAnimation> // TypeDefIndex: 50402
	{
		// Fields
		private UIGraphicAnimation m_uiGraphicAnimation; // 0x10
		private Material m_materialInstance; // 0x18
		private HashSet<UIImage> m_redDotImages; // 0x20
		private GameObject m_root; // 0x28
	
		// Constructors
		private UIRedDotAnimation() {} // 0x0000000185F4D7C0-0x0000000185F4D850
	
		// Methods
		public void Init(GameObject redDotAnimationRoot) {} // 0x0000000184512FF0-0x00000001845132A0
		public void UnInit() {} // 0x000000018BC24248-0x000000018BC24400
		public void AddRedDotImage(UIImage img) {} // 0x00000001845142E0-0x00000001845143C0
		public void RemoveRedDotImage(UIImage img) {} // 0x00000001845140F0-0x0000000184514180
		private void _UpdateRedDotAnimation() {} // 0x00000001845143C0-0x0000000184514430
	}

	public class UIRedDotAnimationNode : MonoBehaviour // TypeDefIndex: 50403
	{
		// Fields
		private UIImage m_image; // 0x18
	
		// Constructors
		public UIRedDotAnimationNode() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void Awake() {} // 0x00000001857851D0-0x0000000185785240
		private void OnEnable() {} // 0x0000000184514230-0x00000001845142E0
		private void OnDisable() {} // 0x0000000184514180-0x0000000184514230
	}

	public static class WebApplication // TypeDefIndex: 50406
	{
		// Nested types
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 50404
		{
			// Fields
			public string url; // 0x10
			public Action onClose; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0() {} // 0x000000018BC2482C-0x000000018BC249F8
	
			// Methods
			internal void _Start_b__0(int i, string s) {} // 0x0000000183ED52E0-0x0000000183ED6790
		}
	
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 50405
		{
			// Fields
			public string url; // 0x10
			public Action onClose; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0() {} // 0x0000000185492010-0x0000000185492020
	
			// Methods
			internal void _StartHGBrowser_b__0(string s) {} // 0x000000018BC22134-0x000000018BC2222C
		}
	
		// Methods
		public static void Start(string url, Action onClose = null) {} // 0x0000000185492010-0x0000000185492020
		public static void StartHGBrowser(string url, Action onClose = null) {} // 0x0000000183ED4370-0x0000000183ED52E0
	}
}

namespace Beyond.UI.GPUI
{
	internal enum ChangeState // TypeDefIndex: 50425
	{
		Stable = 0,
		New = 1,
		ChangeSize = 2,
		ChangeData = 4
	}

	internal struct RuntimeNodeInfo // TypeDefIndex: 50426
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

	internal class RuntimeAnimationData // TypeDefIndex: 50427
	{
		// Fields
		public string name; // 0x10
		public float duration; // 0x18
		public List<GPUInstanceData> template; // 0x20
	
		// Constructors
		public RuntimeAnimationData() {} // 0x0000000184ECBE70-0x0000000184ECBEF0
	}

	internal class RuntimePrefabData // TypeDefIndex: 50428
	{
		// Fields
		public int templateNodeCount; // 0x10
		public List<RuntimeNodeInfo> nodes; // 0x18
		public Dictionary<string, int> nodesNameMap; // 0x20
		public List<RuntimeAnimationData> animations; // 0x28
	
		// Constructors
		public RuntimePrefabData() {} // 0x0000000184ECC450-0x0000000184ECC570
	}

	public struct GPUPrefabData // TypeDefIndex: 50429
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
		} // 0x0000000184ECC130-0x0000000184ECC1D0
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
		} // 0x0000000185533E70-0x0000000185533EA0
	
		// Methods
		public static GPUPrefabData CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv) => default; // 0x0000000185533DD0-0x0000000185533E70
	}

	public struct GPUPrefabDataLite // TypeDefIndex: 50430
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
		} // 0x000000018BC1DF38-0x000000018BC1E190
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
		} // 0x000000018BC1E190-0x000000018BC1E288
	
		// Methods
		public static GPUPrefabDataLite CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv) => default; // 0x000000018BC1DE44-0x000000018BC1DF38
	}

	public struct GPUInstanceData // TypeDefIndex: 50431
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

	public enum NodeType // TypeDefIndex: 50432
	{
		Root = 0,
		Image = 1,
		Text = 2
	}

	public enum SimpleTextAlignment // TypeDefIndex: 50433
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	[Serializable]
	public class NodeSerializeData // TypeDefIndex: 50434
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
		public NodeSerializeData() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class NodeMetadata // TypeDefIndex: 50435
	{
		// Fields
		public string nodeName; // 0x10
		public Beyond.UI.GPUI.NodeType nodeType; // 0x18
		public string nodeTextId; // 0x20
		public string nodeText; // 0x28
		public SimpleTextAlignment textAlignment; // 0x30
		public float nodeTextSize; // 0x34
	
		// Constructors
		public NodeMetadata() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class AnimationSerializeData // TypeDefIndex: 50436
	{
		// Fields
		public string animationName; // 0x10
		public float animationTime; // 0x18
		public int totalFrames; // 0x1C
		public UnityEngine.WrapMode wrapMode; // 0x20
		public int renderNodesOffset; // 0x24
	
		// Constructors
		public AnimationSerializeData() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class PrefabSerializeData // TypeDefIndex: 50437
	{
		// Fields
		public string prefabName; // 0x10
		public int nodeCount; // 0x18
		public bool animationOnly; // 0x1C
		public List<NodeMetadata> nodeMetas; // 0x20
		public List<NodeSerializeData> renderNodes; // 0x28
		public List<AnimationSerializeData> animations; // 0x30
	
		// Constructors
		public PrefabSerializeData() {} // 0x00000001855ABF50-0x00000001855AC070
	}

	[Serializable]
	public class PrefabGroupSerializeData : IMemoryPackSerialize // TypeDefIndex: 50438
	{
		// Fields
		public StringPathHash spriteTexturePath; // 0x10
		public StringPathHash vatTexturePath; // 0x18
		public List<PrefabSerializeData> prefabs; // 0x20
		public List<string> textIds; // 0x28
		public string importantChars; // 0x30
	
		// Constructors
		public PrefabGroupSerializeData() {} // 0x0000000185B71DF0-0x0000000185B71EB0
	}

	public struct GPUIHandle : IEquatable<GPUIHandle> // TypeDefIndex: 50439
	{
		// Fields
		public int index; // 0x00
		public int version; // 0x04
	
		// Methods
		public bool Equals(GPUIHandle other) => default; // 0x000000018BC1C0DC-0x000000018BC1C148
		public override bool Equals(object obj) => default; // 0x000000018BC1C148-0x000000018BC1C1E4
		public override int GetHashCode() => default; // 0x000000018BC1C1E4-0x000000018BC1C234
		public static bool operator ==(GPUIHandle left, GPUIHandle right) => default; // 0x000000018BC1C2E4-0x000000018BC1C350
		public static bool operator !=(GPUIHandle left, GPUIHandle right) => default; // 0x000000018BC1C350-0x000000018BC1C3BC
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018BC1C234-0x000000018BC1C294
		public int __iFixBaseProxy_GetHashCode() => default; // 0x000000018BC1C294-0x000000018BC1C2E4
	}

	public class GPUISystem : MaskableGraphic // TypeDefIndex: 50441
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
		private InstanceBufferManager m_instanceBufferManager; // 0x1C8
		private SimpleBufferManager<GPUPrefabData> m_prefabBufferManager; // 0x1D0
		private SimpleBufferManager<GPUPrefabDataLite> m_litePrefabBufferManager; // 0x1D8
	
		// Properties
		public TMP_FontAsset fontAsset { get => default; set {} } // 0x000000018BC1D820-0x000000018BC1D914 0x000000018BC1C3BC-0x000000018BC1C4B0
	
		// Nested types
		private static class ShaderIDs // TypeDefIndex: 50440
		{
			// Fields
			internal static readonly int CANVAS_OBJECT_TO_WORLD_MATRIX; // 0x00
			internal static readonly int VAT_TEX; // 0x04
			internal static readonly int MAIN_TEX; // 0x08
			internal static readonly int SPRITE_TEX; // 0x0C
	
			// Constructors
			static ShaderIDs() {} // 0x000000018473D100-0x000000018473D1D0
		}
	
		// Constructors
		public GPUISystem() {} // 0x0000000185F54430-0x0000000185F544C0
		static GPUISystem() {} // 0x000000018BC1D250-0x000000018BC1D258
	
		// Methods
		public bool CreateInstance(string prefabName, Vector3 initialPosition, out GPUIHandle handle, int sortingOrder = 0 /* Metadata: 0x02061F33 */) {
			handle = default;
			return default;
		} // 0x000000018BC1C4B0-0x000000018BC1C540
		public bool DestroyInstance(GPUIHandle handle) => default; // 0x000000018BC1C540-0x000000018BC1C5A8
		public bool IsInstanceValid(GPUIHandle handle) => default; // 0x000000018BC1C810-0x000000018BC1C914
		public bool SetRootPosition(GPUIHandle handle, Vector3 position) => default; // 0x000000018BC1C914-0x000000018BC1C9F8
		public bool SetRootScale(GPUIHandle handle, Vector2 scale) => default; // 0x000000018BC1CC2C-0x000000018BC1D030
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, string animationName, bool resetDestroy = false /* Metadata: 0x02061F34 */) => default; // 0x000000018BC1D030-0x000000018BC1D250
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, int animationIndex = 0 /* Metadata: 0x02061F35 */, bool resetDestroy = false /* Metadata: 0x02061F36 */) => default; // 0x000000018BC1CB2C-0x000000018BC1CC2C
		public bool SetVisibility(GPUIHandle handle, string nodeName, bool visible) => default; // 0x000000018BC1C6B8-0x000000018BC1C810
		public bool SetColor(GPUIHandle handle, string nodeName, UnityEngine.Color color) => default; // 0x000000018BC1C9F8-0x000000018BC1CB2C
		public bool SetText(GPUIHandle handle, string nodeName, string text) => default; // 0x000000018BC1C5A8-0x000000018BC1C604
		protected override void OnDestroy() {} // 0x000000018473BE20-0x000000018473BF30
		protected override void OnEnable() {} // 0x000000018BC1C604-0x000000018BC1C6B8
		protected override void OnDisable() {} // 0x0000000185B53D00-0x0000000185B53F60
		protected override void OnPopulateMesh(VertexHelper vh) {} // 0x00000001859255D0-0x00000001859256F0
		protected override void UpdateMaterial() {} // 0x00000001846342A0-0x00000001846342E0
		private void _PreWillRenderCanvases() {} // 0x000000018473C850-0x000000018473CDB0
		private void _Init(string jsonPath) {} // 0x000000018473D1D0-0x000000018473D250
		protected TMP_FontAsset GetFontAsset() => default; // 0x00000001846342E0-0x00000001846343A0
		private void _DoLateUpdate() {} // 0x000000018BC1D488-0x000000018BC1D58C
		private void _DoOnDestroy() {} // 0x000000018473CDB0-0x000000018473D100
		private void _RefreshMaterials() {} // 0x00000001845132A0-0x00000001845135A0
		private void _InitMaterials() {} // 0x000000018473DE40-0x000000018473DFD0
		private void _CleanMaterials() {} // 0x0000000184634440-0x0000000184634530
		private void _RenderNodes() {} // 0x00000001846343A0-0x0000000184634440
		private void _DestroyAnimatedInstance() {} // 0x000000018473BF70-0x000000018473C2B0
		private void _UpdateWorldMat() {} // 0x0000000184EC9F50-0x0000000184ECA6D0
		private void _PreloadTextInGroupData(PrefabGroupSerializeData data) {} // 0x0000000184ECA6D0-0x0000000184ECACF0
		private void _LoadGroupData(PrefabGroupSerializeData data) {} // 0x0000000184ECAFF0-0x0000000184ECBE70
		private RuntimePrefabData _LoadPrefabData(PrefabSerializeData prefab) => default; // 0x0000000184ECBEF0-0x0000000184ECC130
		private int _LoadPrefabNodeBuffer(PrefabSerializeData prefab, int totalNodeCount) => default; // 0x000000018BC1D270-0x000000018BC1D3AC
		private bool _CreateInstance(string prefabName, out GPUIHandle handle, int sortingOrder) {
			handle = default;
			return default;
		} // 0x000000018BC1D3AC-0x000000018BC1D488
		private bool _DestroyInstance(GPUIHandle handle) => default; // 0x000000018BC1D58C-0x000000018BC1D6D8
		private GPUIHandle _GetOneHandle() => default; // 0x000000018BC1D6D8-0x000000018BC1D794
		private bool _IsHandleInvalid(GPUIHandle handle) => default; // 0x000000018BC1D794-0x000000018BC1D820
		private void _RecycleOneHandle(GPUIHandle handle) {} // 0x0000000184B33EA0-0x0000000184B340F0
		public void __iFixBaseProxy_OnDestroy() {} // 0x000000018BC1D260-0x000000018BC1D268
		public void __iFixBaseProxy_OnEnable() {} // 0x000000018BC1D258-0x000000018BC1D260
		public void __iFixBaseProxy_OnDisable() {} // 0x000000018BBD4C38-0x000000018BBD4C40
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0) {} // 0x000000018BC1D268-0x000000018BC1D270
		public void __iFixBaseProxy_UpdateMaterial() {} // 0x0000000185EC33F0-0x0000000185EC34C0
	}

	public static class GPUIUtils // TypeDefIndex: 50442
	{
		// Fields
		public static readonly Vector3 DEFAULT_NORMAL; // 0x00
		public static readonly Vector4 DEFAULT_TANGENT; // 0x0C
	
		// Constructors
		static GPUIUtils() {} // 0x000000018BC1DDDC-0x000000018BC1DE44
	
		// Methods
		public static Mesh CreateQuadMesh() => default; // 0x000000018BC1D9A4-0x000000018BC1DDDC
		public static uint ColorToRGBAUint32(UnityEngine.Color color) => default; // 0x000000018BC1D914-0x000000018BC1D9A4
	}

	internal class InstanceBufferManager : IDisposable // TypeDefIndex: 50444
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
		public int startIndex { get => default; } // 0x0000000185FB06E0-0x0000000185FB06F0 
		public int nodeCount { get => default; } // 0x0000000185FB0680-0x0000000185FB0690 
		public int capacity { get => default; } // 0x0000000185FB0670-0x0000000185FB0680 
		public NativeArray<CanvasRenderer.InstanceRange> gpuGroups { get => default; } // 0x0000000184632F70-0x00000001846330E0 
		public int gpuGroupCount { get => default; } // 0x0000000185FB2020-0x0000000185FB2030 
	
		// Nested types
		private struct BufferInternalNode // TypeDefIndex: 50443
		{
			// Fields
			public GPUIHandle handle; // 0x00
			public int startIndex; // 0x08
			public int previousLength; // 0x0C
			public int sortingOrder; // 0x10
		}
	
		// Constructors
		public InstanceBufferManager() {} // Dummy constructor
		public InstanceBufferManager(int initCapacity, int maxCapacity, int nodeStride, int gpuGroupCapacity, bool noSortingOrder) {} // 0x000000018473D290-0x000000018473D400
		static InstanceBufferManager() {} // 0x0000000185F65C30-0x0000000185F65C90
	
		// Methods
		public void BindInstanceList(List<RuntimeInstance> runtimeInstanceView) {} // 0x000000018473D250-0x000000018473D290
		public void MarkNeedUpdate() {} // 0x000000018BC1E538-0x000000018BC1E588
		private void _FillInstanceQueue(ref NativeArray<GPUInstanceData> oldBuffer, out int newTotalLength, out int newTotalLengthWithEmptySlot, out int fullUpdateIndex) {
			newTotalLength = default;
			newTotalLengthWithEmptySlot = default;
			fullUpdateIndex = default;
		} // 0x000000018BC1E618-0x000000018BC1ECC0
		public void DoUpdate(CanvasRenderer canvasRenderer) {} // 0x00000001846330E0-0x00000001846342A0
		private void _NewGpuGroup(int start, int end) {} // 0x000000018BC1C0B4-0x000000018BC1C0DC
		public void Add(GPUIHandle instance) {} // 0x000000018BC1E288-0x000000018BC1E4B0
		public void Remove(GPUIHandle instance) {} // 0x000000018BC1E588-0x000000018BC1E618
		private void _AllocBuffer(int capacity) {} // 0x000000018473D400-0x000000018473D4D0
		public void Dispose() {} // 0x000000018BC1E4B0-0x000000018BC1E538
	}

	internal class RuntimeInstance // TypeDefIndex: 50445
	{
		// Fields
		public const int ROOT_NODE_INDEX = 0; // Metadata: 0x02061F38
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
		public RuntimePrefabData Prefab { get => default; } // 0x00000001813B8590-0x00000001813B85A0 
		public float AnimationDuration { get => default; } // 0x0000000185FB1750-0x0000000185FB1760 
	
		// Constructors
		public RuntimeInstance() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void Create(RuntimePrefabData prefab, ITextSystem textSystem) {} // 0x000000018BBE6F78-0x000000018BBE7120
		public void Recycle() {} // 0x000000018BBE7484-0x000000018BBE74D8
		public void DoUpdate(ref NativeArray<GPUInstanceData> buffer, int startIndexInBuffer, bool full) {} // 0x000000018BBE7120-0x000000018BBE7484
		public void SetRootScale(Vector2 rootScale) {} // 0x000000018BBE7678-0x000000018BBE76DC
		public void SetPosition(int index, Vector3 position) {} // 0x000000018BBE75B0-0x000000018BBE7678
		public void StartAnimation(float animationTime, int animationIndex = 0 /* Metadata: 0x02061F37 */) {} // 0x000000018BBE78EC-0x000000018BBE79B8
		public void SetVisibility(int index, bool visible) {} // 0x000000018BBE7868-0x000000018BBE78EC
		public void SetColor(int index, UnityEngine.Color newColor) {} // 0x000000018BBE74D8-0x000000018BBE75B0
		public void SetText(int index, string text) {} // 0x000000018BBE76DC-0x000000018BBE7868
	}

	internal class SimpleBufferManager<T> : IDisposable // TypeDefIndex: 50446
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

	internal class CodePoint // TypeDefIndex: 50447
	{
		// Fields
		public const uint HIGH_SURROGATE_START = 55296; // Metadata: 0x02061F39
		public const uint HIGH_SURROGATE_END = 56319; // Metadata: 0x02061F3D
		public const uint LOW_SURROGATE_START = 56320; // Metadata: 0x02061F41
		public const uint LOW_SURROGATE_END = 57343; // Metadata: 0x02061F45
		public const uint UNICODE_PLANE01_START = 65536; // Metadata: 0x02061F49
	
		// Constructors
		public CodePoint() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) => default; // 0x000000018BBE6CE4-0x000000018BBE6D44
	}

	internal interface ITextSystem // TypeDefIndex: 50448
	{
		// Methods
		void RegisterCharacterToPrefabBuffer(string text);
		void UploadBufferIfNeeded();
		int GetNodeCount(string text);
		void CreateTextNodes(string text, NativeArray<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment);
		void CreateTextNodes(string text, List<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment);
	}

	internal class SimpleTextSystem<T> : ITextSystem // TypeDefIndex: 50450
		where T : struct
	{
		// Fields
		public const float DEFAULT_WHITESPACE_SPACING = 0.27f; // Metadata: 0x02061F4D
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
		private struct CharOffsetData // TypeDefIndex: 50449
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
	internal class OnValueChangedAttribute : PropertyAttribute // TypeDefIndex: 50407
	{
		// Fields
		private readonly string _actionName_k__BackingField; // 0x10
	
		// Properties
		public string actionName { get; } // 0x000000018346D130-0x000000018346D140 
	
		// Constructors
		public OnValueChangedAttribute() {} // Dummy constructor
		public OnValueChangedAttribute(string name) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	public class StateAnimationInfo // TypeDefIndex: 50408
	{
		// Fields
		private bool _IsFinished_k__BackingField; // 0x10
		private readonly AnimationClip _Clip_k__BackingField; // 0x18
		private readonly GameObject _Target_k__BackingField; // 0x20
		private float _StartTime_k__BackingField; // 0x28
		private readonly float m_duration; // 0x2C
	
		// Properties
		public bool IsFinished { get; set; } // 0x0000000181C2FD60-0x0000000181C2FD70 0x000000018184FBD0-0x000000018184FBE0
		public AnimationClip Clip { get; } // 0x0000000181377E40-0x0000000181377E50 
		public GameObject Target { get; } // 0x00000001813B31A0-0x00000001813B31B0 
		public float StartTime { get; private set; } // 0x0000000185FB0A50-0x0000000185FB0A60 0x0000000185FB0A60-0x0000000185FB0A70
	
		// Constructors
		public StateAnimationInfo() {} // Dummy constructor
		public StateAnimationInfo(AnimationClip clip, GameObject target) {} // 0x00000001845A3F90-0x00000001845A3FF0
	
		// Methods
		public void OnUpdate() {} // 0x000000018BC1ECC0-0x000000018BC1ED70
	}

	public enum AnimationImpactType // TypeDefIndex: 50409
	{
		StartAnimation = 0,
		StopAnimation = 1
	}

	[Serializable]
	public class StateDescription // TypeDefIndex: 50410
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
		public GridLayoutGroup gridLayoutGroup; // 0xE0
		public GridLayoutGroupImpactType gridLayoutGroupImpactType; // 0xE8
		public RectOffset gridLayoutGroupPadding; // 0xF0
		public Vector2 gridLayoutGroupSpacing; // 0xF8
		public Vector2 gridLayoutGroupCellSize; // 0x100
		public int gridLayoutConstraintCount; // 0x108
		public UIImage image; // 0x110
		public ImageImpactType imageImpact; // 0x118
		public bool imageEnabled; // 0x11C
		public Sprite imageSetSprite; // 0x120
		public UnityEngine.Color imageSetColor; // 0x128
		public string imageSetMaterialFloatParam; // 0x138
		public float imageSetMaterialFloatValue; // 0x140
		private Material _ImageMaterialClone_k__BackingField; // 0x148
		public LayoutElement layoutElement; // 0x150
		public LayoutElementImpactType layoutElementImpactType; // 0x158
		public float layoutElementPreferredWidth; // 0x15C
		public float layoutElementPreferredHeight; // 0x160
		public float layoutElementMinWidth; // 0x164
		public float layoutElementMinHeight; // 0x168
		public float layoutElementFlexibleWidth; // 0x16C
		public float layoutElementFlexibleHeight; // 0x170
		public HorizontalOrVerticalLayoutGroup layoutGroup; // 0x178
		public LayoutGroupImpactType layoutGroupImpactType; // 0x180
		public RectOffset layoutGroupPadding; // 0x188
		public float layoutGroupSpacing; // 0x190
		public TextAnchor layoutGroupChildAlignment; // 0x194
		public bool layoutGroupReverseArrangement; // 0x198
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
		public UIScrollList scrollList; // 0x208
		public ScrollListImpactType scrollListImpactType; // 0x210
		public UIScrollList.Padding scrollListPadding; // 0x214
		public Vector2 scrollListSpace; // 0x224
		public Selectable selectable; // 0x230
		public bool selectableInteractable; // 0x238
		public UIStateController uiStateController; // 0x240
		public string stateName; // 0x248
		public UIText text; // 0x250
		public TextImpactType textImpact; // 0x258
		public UnityEngine.Color textColor; // 0x25C
		public string textId; // 0x270
		public float textFontSize; // 0x278
		public float textMaxFontSize; // 0x27C
		public HorizontalAlignmentOptions textHorizontalAlignment; // 0x280
	
		// Properties
		public bool IsEmpty { get => default; } // 0x00000001845A62F0-0x00000001845A7020 
		public string ReadableDescription { get => default; } // 0x000000018BC20BD0-0x000000018BC21D84 
		public Material ImageMaterialClone { get; set; } // 0x0000000185FB8610-0x0000000185FB8620 0x0000000187A47780-0x0000000187A47794
	
		// Constructors
		public StateDescription() {} // 0x00000001850B6C90-0x00000001850B6CD0
	
		// Methods
		public bool EqualsAnimation(StateDescription other) => default; // 0x000000018BC1F2B8-0x000000018BC1F350
		public float ApplyAnimation(StateReference state) => default; // 0x00000001845A3FF0-0x00000001845A40E0
		public bool EqualsAnimator(StateDescription other) => default; // 0x000000018BC1F350-0x000000018BC1F3E8
		public void ApplyAnimator() {} // 0x000000018BC1ED70-0x000000018BC1EE94
		public bool EqualsButton(StateDescription other) => default; // 0x000000018BC1F3E8-0x000000018BC1F480
		public void ApplyButton() {} // 0x000000018BC1EE94-0x000000018BC1EEF4
		public bool EqualsCanvasGroup(StateDescription other) => default; // 0x000000018BC1F480-0x000000018BC1F520
		public void ApplyCanvasGroup() {} // 0x0000000185F65930-0x0000000185F65990
		public bool EqualsComponent(StateDescription other) => default; // 0x000000018BC1F520-0x000000018BC1F5C0
		public void ApplyComponent() {} // 0x000000018BC1EEF4-0x000000018BC1EF58
		public override string ToString() => default; // 0x000000018BC1FD80-0x000000018BC1FE14
		public static bool operator ==(StateDescription left, StateDescription right) => default; // 0x000000018BC21D84-0x000000018BC21E00
		public static bool operator !=(StateDescription left, StateDescription right) => default; // 0x000000018BC21E00-0x000000018BC21E68
		public override bool Equals(object obj) => default; // 0x000000018BC1FC8C-0x000000018BC1FD1C
		public override int GetHashCode() => default; // 0x000000018BC1FD1C-0x000000018BC1FD80
		public bool Equals(StateDescription other) => default; // 0x000000018BC1FC00-0x000000018BC1FC8C
		private bool _EqualsByTargetType(StateDescription other) => default; // 0x000000018BC1FE14-0x000000018BC20050
		private int _GetTargetHashCode() => default; // 0x000000018BC20050-0x000000018BC20130
		public bool EqualsGameObject(StateDescription other) => default; // 0x000000018BC1F5C0-0x000000018BC1F660
		public void ApplyGameObject() {} // 0x00000001845A7020-0x00000001845A7070
		public bool EqualsGraphic(StateDescription other) => default; // 0x000000018BC1F660-0x000000018BC1F700
		public void ApplyGraphic() {} // 0x000000018BC1EF58-0x000000018BC1EFC0
		public bool EqualsGridLayoutGroup(StateDescription other) => default; // 0x000000018BC1F700-0x000000018BC1F7A0
		public void ApplyGridLayoutGroup() {} // 0x000000018BC1EFC0-0x000000018BC1F114
		private void _OnGridLayoutGroupChanged() {} // 0x000000018BC20130-0x000000018BC20240
		public bool EqualsImage(StateDescription other) => default; // 0x000000018BC1F7A0-0x000000018BC1F840
		public void ApplyImage() {} // 0x00000001845A4FD0-0x00000001845A50C0
		private void _OnImageChanged() {} // 0x000000018BC20240-0x000000018BC20394
		public bool EqualsLayoutElement(StateDescription other) => default; // 0x000000018BC1F840-0x000000018BC1F8E0
		public void ApplyLayoutElement() {} // 0x00000001845A3C30-0x00000001845A3CE0
		private void _OnLayoutElementChanged() {} // 0x000000018BC20394-0x000000018BC20460
		public bool EqualsLayoutGroup(StateDescription other) => default; // 0x000000018BC1F8E0-0x000000018BC1F980
		public void ApplyLayoutGroup() {} // 0x00000001845A35F0-0x00000001845A36B0
		private void _OnLayoutGroupChanged() {} // 0x000000018BC20460-0x000000018BC20558
		public bool EqualsRectTransform(StateDescription other) => default; // 0x000000018BC1F980-0x000000018BC1FA20
		public void ApplyRectTransform() {} // 0x00000001845A7070-0x00000001845A73D0
		private void _OnRectTransformChanged() {} // 0x000000018BC20558-0x000000018BC20A14
		public bool EqualsScrollList(StateDescription other) => default; // 0x000000018BC1FA20-0x000000018BC1FAC0
		public void ApplyScrollList() {} // 0x000000018BC1F17C-0x000000018BC1F2B8
		private void _OnScrollListChanged() {} // 0x000000018BC20A14-0x000000018BC20AF0
		public bool EqualsSelectable(StateDescription other) => default; // 0x0000000183ED3740-0x0000000183ED4370
		public void ApplySelectable() {} // 0x0000000183ED33D0-0x0000000183ED3740
		public bool EqualsState(StateDescription other) => default; // 0x000000018BC1FAC0-0x000000018BC1FB60
		public float ApplyInnerState() => default; // 0x000000018BC1F114-0x000000018BC1F17C
		public bool EqualsText(StateDescription other) => default; // 0x000000018BC1FB60-0x000000018BC1FC00
		public void ApplyText() {} // 0x00000001845A40E0-0x00000001845A4230
		private void _OnTextChanged() {} // 0x000000018BC20AF0-0x000000018BC20BD0
		public string __iFixBaseProxy_ToString() => default; // 0x000000018765AF34-0x000000018765AF3C
		public bool __iFixBaseProxy_Equals(object P0) => default; // 0x000000018406FBE0-0x000000018406FBF0
		public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000185FB0F10-0x0000000185FB0F20
	}

	public enum AnimatorImpactType // TypeDefIndex: 50411
	{
		SetBoolTrue = 0,
		SetBoolFalse = 1,
		SetTrigger = 2,
		ResetTrigger = 3,
		SetInteger = 4,
		SetFloat = 5
	}

	public enum CanvasGroupImpactType // TypeDefIndex: 50412
	{
		SetAlpha = 0,
		SetInteractable = 1,
		SetColor = 2
	}

	public enum StateDescriptionTargetType // TypeDefIndex: 50413
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
		GridLayoutGroup = 14,
		Selectable = 15
	}

	public enum GridLayoutGroupImpactType // TypeDefIndex: 50414
	{
		Padding = 0,
		Spacing = 1,
		CellSize = 2,
		ConstraintCount = 3
	}

	public enum ImageImpactType // TypeDefIndex: 50415
	{
		SetEnabled = 0,
		SetSprite = 1,
		SetColor = 2,
		SetMaterialFloatValue = 3
	}

	public enum LayoutElementImpactType // TypeDefIndex: 50416
	{
		LayoutElementPreferredWidth = 0,
		LayoutElementPreferredHeight = 1,
		LayoutElementMinWidth = 2,
		LayoutElementMinHeight = 3,
		LayoutElementFlexibleWidth = 4,
		LayoutElementFlexibleHeight = 5
	}

	public enum LayoutGroupImpactType // TypeDefIndex: 50417
	{
		Padding = 0,
		Spacing = 1,
		ChildAlignment = 2,
		ReverseArrangement = 3
	}

	public enum RectTransformImpactType // TypeDefIndex: 50418
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

	public enum ScrollListImpactType // TypeDefIndex: 50419
	{
		Padding = 0,
		Space = 1
	}

	public enum TextImpactType // TypeDefIndex: 50420
	{
		SetColor = 0,
		SetTextById = 1,
		SetFontSize = 2,
		SetHorizontalAlignment = 3,
		SetMaxFontSize = 4
	}

	[Serializable]
	public class StateReference // TypeDefIndex: 50421
	{
		// Fields
		public string stateName; // 0x10
		public List<StateDescription> descriptions; // 0x18
		private List<StateAnimationInfo> m_scheduledForPlaying; // 0x20
		private List<StateAnimationInfo> m_scheduledForStopping; // 0x28
		private UIStateController m_controller; // 0x30
		private bool m_isDirty; // 0x38
	
		// Constructors
		public StateReference() {} // 0x00000001848150B0-0x00000001848151B0
	
		// Methods
		public void SetController(UIStateController controller) {} // 0x00000001845A50C0-0x00000001845A5100
		public void ScheduleForPlaying(StateAnimationInfo stateAnimationInfo) {} // 0x000000018BC21E68-0x000000018BC21F08
		public void ScheduleForStopping(StateAnimationInfo stateAnimationInfo) {} // 0x00000001845A3EE0-0x00000001845A3F60
		public void HandleScheduledStates() {} // 0x0000000185265B40-0x0000000185265DC0
	}

	public class UIStateController : TickableUIMono // TypeDefIndex: 50423
	{
		// Fields
		public List<StateReference> states; // 0x68
		private string _currentStateName_k__BackingField; // 0x70
		private readonly List<StateAnimationInfo> m_animations; // 0x78
	
		// Properties
		protected override TickType tickOption { get => default; } // 0x00000001845A3F60-0x00000001845A3F90 
		public string currentStateName { get; private set; } // 0x00000001845A5100-0x00000001845A5220 0x00000001845A5220-0x00000001845A62F0
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 50422
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<StateAnimationInfo> __9__10_0; // 0x08
	
			// Constructors
			static __c() {} // 0x0000000181E1B510-0x0000000181E1B520
			public __c() {} // 0x0000000181460F70-0x0000000181460F80
	
			// Methods
			internal bool _Tick_b__10_0(StateAnimationInfo info) => default; // 0x00000001874BE90C-0x00000001874BE91C
		}
	
		// Constructors
		public UIStateController() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public void OnStateReferenceDirty() {} // 0x0000000185264AD0-0x0000000185265AF0
		public float SetState(string stateName, bool forceUpdate = true /* Metadata: 0x02061F28 */) => default; // 0x0000000185265AF0-0x0000000185265B40
		private float _ApplyState(StateReference state) => default; // 0x000000018BC245F8-0x000000018BC2482C
		public override void Tick(float deltaTime) {} // 0x00000001852647A0-0x0000000185264AD0
		private void _HandleStateAnimations(StateReference stateReference) {} // 0x0000000184814FE0-0x00000001848150B0
		public void Run(StateAnimationInfo newInfo) {} // 0x000000018311B6C0-0x000000018311B6D0
		public void Stop(StateAnimationInfo newInfo) {} // 0x0000000185F785B0-0x0000000185F78610
		public void __iFixBaseProxy_Tick(float P0) {} // 0x000000018BC2211C-0x000000018BC22134
	}

	public static class UIStateControllerUtils // TypeDefIndex: 50424
	{
		// Fields
		private static float s_updateFinishTime; // 0x00
	
		// Methods
		public static void ForceRebuildLayout(GameObject gameObject) {} // 0x000000018BC24400-0x000000018BC24500
		public static void SetLeft(RectTransform rt, float left) {} // 0x00000001845A73D0-0x00000001845A7440
		public static void SetRight(RectTransform rt, float right) {} // 0x00000001845A75D0-0x00000001845A7640
		public static void SetTop(RectTransform rt, float top) {} // 0x0000000185EBB560-0x0000000185EBB5D0
		public static void SetBottom(RectTransform rt, float bottom) {} // 0x0000000185D4B230-0x0000000185D4B2A0
		public static string GetName(UnityEngine.Object obj) => default; // 0x000000018BC24500-0x000000018BC245AC
		public static void StartEditorUpdateLoop(float duration) {} // 0x000000018BC245AC-0x000000018BC245F8
	}
}

namespace Cysharp.Text
{
	public static class TextMeshProExtensions // TypeDefIndex: 50099
	{
		// Methods
		public static void SetText<T>(TMP_Text text, T arg0) {}
		public static void SetTextFormat<T0>(TMP_Text text, string format, T0 arg0) {}
		public static void SetTextFormat<T0, T1>(TMP_Text text, string format, T0 arg0, T1 arg1) {}
		public static void SetTextFormat<T0, T1, T2>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2) {}
		public static void SetTextFormat<T0, T1, T2, T3>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) {}
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) {}
		public static void SetText(TMP_Text text, Utf16ValueStringBuilder stringBuilder) {} // 0x000000018BBD6808-0x000000018BBD68E0
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 50098
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 50453
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper() {} // Dummy constructor
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj) {} // 0x0000000184E6FCD0-0x0000000184E6FD00
		static ILFixDynamicMethodWrapper() {} // 0x0000000185F64940-0x0000000185F649B0
	
		// Methods
		public void __Gen_Wrap_0() {} // 0x0000000187678160-0x00000001876781FC
		public void __Gen_Wrap_1(object P0) {} // 0x000000018646FFC0-0x0000000186470080
		public float __Gen_Wrap_2(object P0, bool P1) => default; // 0x000000018BC27FB0-0x000000018BC2809C
		public float __Gen_Wrap_3(object P0) => default; // 0x00000001876AC634-0x00000001876AC704
		public LuaPanel __Gen_Wrap_4(object P0) => default; // 0x000000018BC28DD8-0x000000018BC28EC8
		public void __Gen_Wrap_5(object P0, object P1, bool P2) {} // 0x000000018767A33C-0x000000018767A434
		public void __Gen_Wrap_6(object P0, float P1) {} // 0x0000000187678884-0x0000000187678964
		public string __Gen_Wrap_7(object P0, int P1, out bool P2) {
			P2 = default;
			return default;
		} // 0x000000018BC2A73C-0x000000018BC2A884
		public bool __Gen_Wrap_8(object P0, object P1) => default; // 0x0000000187342174-0x0000000187342260
		public UIText.HyperlinkUITextGroup __Gen_Wrap_9(object P0, object P1, bool P2) => default; // 0x000000018BC2B670-0x000000018BC2B8B8
		public void __Gen_Wrap_10(object P0, object P1) {} // 0x00000001873527E8-0x00000001873528C4
		public string __Gen_Wrap_11(PhoneticType P0, object P1) => default; // 0x000000018BC25834-0x000000018BC2592C
		public void __Gen_Wrap_12(object P0, PhoneticType P1, object P2) {} // 0x000000018A81C9C4-0x000000018A81CAA8
		public void __Gen_Wrap_13(EnvLang P0) {} // 0x0000000187937E4C-0x0000000187937F0C
		public bool __Gen_Wrap_14(object P0, object P1, out string P2) {
			P2 = default;
			return default;
		} // 0x000000018BC26B60-0x000000018BC26CB0
		public bool __Gen_Wrap_15(object P0, Vector3 P1, out string P2) {
			P2 = default;
			return default;
		} // 0x000000018BC26CB0-0x000000018BC26E2C
		public IEnumerator __Gen_Wrap_16(object P0) => default; // 0x000000018BC26E2C-0x000000018BC26F1C
		public string __Gen_Wrap_17(object P0, bool P1) => default; // 0x000000018BC26F1C-0x000000018BC27028
		public Sprite __Gen_Wrap_18(object P0, object P1) => default; // 0x000000018BC27028-0x000000018BC27134
		public int __Gen_Wrap_19(ReadOnlySpan<char> P0) => default; // 0x000000018BC27134-0x000000018BC2723C
		public UIText.RichTextInfo __Gen_Wrap_20(UIText.RichTextAnalyzer.RichTextParam P0, object P1, ref Utf16ValueStringBuilder P2) => default; // 0x000000018BC2723C-0x000000018BC273FC
		public UIText.RichTextInfo __Gen_Wrap_21(object P0, UIText.RichTextAnalyzer.RichTextParam P1, object P2, ref Utf16ValueStringBuilder P3) => default; // 0x000000018BC273FC-0x000000018BC275BC
		public UIText.RichTextAnalyzer.ProcessRichTextEntryFunc __Gen_Wrap_22(object P0) => default; // 0x000000018BC275BC-0x000000018BC276AC
		public bool __Gen_Wrap_23(ReadOnlySpan<char> P0, out bool P1, out UIText.RichTextAnalyzer.RichTextParam P2) {
			P1 = default;
			P2 = default;
			return default;
		} // 0x000000018BC276AC-0x000000018BC27854
		public bool __Gen_Wrap_24(ReadOnlySpan<char> P0, ref Utf16ValueStringBuilder P1, object P2, out UIText.RichTextInfo P3) {
			P3 = default;
			return default;
		} // 0x000000018BC27854-0x000000018BC27A44
		public string __Gen_Wrap_25(object P0, object P1, out List<UIText.RichTextInfo> P2) {
			P2 = default;
			return default;
		} // 0x000000018BC27A44-0x000000018BC27BA8
		public GameObject __Gen_Wrap_26(object P0) => default; // 0x000000018BC27BA8-0x000000018BC27C98
		public UIText.ImageGOInfo __Gen_Wrap_27(object P0, int P1) => default; // 0x000000018BC27C98-0x000000018BC27DC8
		public Material __Gen_Wrap_28(object P0) => default; // 0x000000018BC27DC8-0x000000018BC27EA4
		public Material __Gen_Wrap_29(object P0, object P1) => default; // 0x000000018BC27EA4-0x000000018BC27FB0
		public bool __Gen_Wrap_30() => default; // 0x000000018735B3F8-0x000000018735B4A4
		public I18nFontSearchData __Gen_Wrap_31() => default; // 0x000000018BC2809C-0x000000018BC28168
		public bool __Gen_Wrap_32(object P0) => default; // 0x000000018735B960-0x000000018735BA30
		public TMP_FontAsset __Gen_Wrap_33(int P0) => default; // 0x000000018BC28168-0x000000018BC28254
		public TMP_FontAsset __Gen_Wrap_34(object P0) => default; // 0x000000018BC28254-0x000000018BC28344
		public void __Gen_Wrap_35(object P0, object P1, object P2, int P3) {} // 0x000000018A8517E4-0x000000018A8518DC
		public void __Gen_Wrap_36(object P0, object P1, int P2) {} // 0x00000001876A23EC-0x00000001876A24E4
		public bool __Gen_Wrap_37(object P0, int P1, out string P2) {
			P2 = default;
			return default;
		} // 0x000000018BC28344-0x000000018BC28484
		public bool __Gen_Wrap_38(object P0, int P1, out Vector3 P2, out float P3) {
			P2 = default;
			P3 = default;
			return default;
		} // 0x000000018BC28484-0x000000018BC28604
		public void __Gen_Wrap_39(object P0, object P1, object P2) {} // 0x0000000187340E48-0x0000000187340F40
		public int __Gen_Wrap_40(UIText.HyperlinkUITextWrap P0, UIText.HyperlinkUITextWrap P1) => default; // 0x000000018A812784-0x000000018A81285C
		public List<UIText> __Gen_Wrap_41(object P0, object P1) => default; // 0x000000018BC28604-0x000000018BC286FC
		public List<UIText> __Gen_Wrap_42(object P0) => default; // 0x000000018BC286FC-0x000000018BC287D8
		public int __Gen_Wrap_43(object P0) => default; // 0x00000001873408C8-0x0000000187340998
		public TMP_SubMeshUI __Gen_Wrap_44(object P0, object P1, MaterialReference P2) => default; // 0x000000018BC287D8-0x000000018BC2893C
		public string __Gen_Wrap_45(int P0) => default; // 0x000000018BC2893C-0x000000018BC28A28
		public float __Gen_Wrap_46() => default; // 0x000000018BC28A28-0x000000018BC28AD4
		public GameObject __Gen_Wrap_47(object P0, object P1, object P2) => default; // 0x000000018BC28AD4-0x000000018BC28BE8
		public void __Gen_Wrap_48(FAssetProxyUntrackedHandle P0) {} // 0x000000018BC28BE8-0x000000018BC28CD0
		public int __Gen_Wrap_49(object P0, object P1, object P2, object P3) => default; // 0x000000018BC28CD0-0x000000018BC28DD8
		public void __Gen_Wrap_50(object P0, int P1) {} // 0x000000018769E90C-0x000000018769E9E8
		public bool __Gen_Wrap_51(Vector3 P0, object P1, object P2) => default; // 0x000000018BC28EC8-0x000000018BC2900C
		public bool __Gen_Wrap_52(Vector2 P0, object P1, object P2) => default; // 0x000000018BC2900C-0x000000018BC29148
		public Bounds __Gen_Wrap_53(object P0, object P1) => default; // 0x000000018BC29148-0x000000018BC29268
		public bool __Gen_Wrap_54(int P0, out UnityEngine.InputSystem.EnhancedTouch.Touch P1) {
			P1 = default;
			return default;
		} // 0x000000018BC29268-0x000000018BC293B0
		public void __Gen_Wrap_55(object P0, UnityEngine.Color P1) {} // 0x000000018BC293B0-0x000000018BC294C4
		public Rect __Gen_Wrap_56(object P0, object P1) => default; // 0x000000018BC294C4-0x000000018BC295EC
		public Vector3 __Gen_Wrap_57(object P0, object P1) => default; // 0x000000018BC295EC-0x000000018BC2970C
		public UnityEngine.Color __Gen_Wrap_58(object P0) => default; // 0x000000018BC2970C-0x000000018BC29804
		public float __Gen_Wrap_59(float P0) => default; // 0x000000018A82DE78-0x000000018A82DF48
		public void __Gen_Wrap_60(object P0, object P1, CinemachineCore.Stage P2, ref CameraState P3, float P4) {} // 0x000000018BC29804-0x000000018BC29A68
		public int __Gen_Wrap_61(object P0, int P1) => default; // 0x0000000187677130-0x000000018767721C
		public Vector2 __Gen_Wrap_62(object P0, int P1) => default; // 0x000000018BC29A68-0x000000018BC29B60
		public Vector2 __Gen_Wrap_63() => default; // 0x000000018BC29B60-0x000000018BC29C18
		public void __Gen_Wrap_64(Vector2 P0) {} // 0x000000018BC29C18-0x000000018BC29D00
		public void __Gen_Wrap_65(object P0, int P1, bool P2) {} // 0x000000018A82F260-0x000000018A82F344
		public Vector2Int __Gen_Wrap_66(object P0, float P1, bool P2) => default; // 0x000000018BC29D00-0x000000018BC29E28
		public Vector2Int __Gen_Wrap_67(object P0) => default; // 0x000000018BC29E28-0x000000018BC29F18
		public UIScrollList.Cell __Gen_Wrap_68(object P0) => default; // 0x000000018BC29F18-0x000000018BC2A008
		public void __Gen_Wrap_69(object P0, bool P1) {} // 0x0000000187678A10-0x0000000187678AEC
		public UnityEngine.AnimationState __Gen_Wrap_70(object P0, object P1) => default; // 0x000000018BC2A008-0x000000018BC2A114
		public void __Gen_Wrap_71(object P0, object P1, float P2) {} // 0x0000000188011018-0x0000000188011114
		public void __Gen_Wrap_72(object P0, object P1, float P2, bool P3) {} // 0x000000018BC2A114-0x000000018BC2A21C
		public void __Gen_Wrap_73(object P0, object P1, object P2, UIConst.AnimationState P3, float P4, bool P5) {} // 0x0000000183F17CB0-0x0000000183F18E00
		public void __Gen_Wrap_74(object P0, int P1, bool P2, bool P3) {} // 0x000000018BC2A21C-0x000000018BC2A324
		public void __Gen_Wrap_75(object P0, bool P1, bool P2, bool P3) {} // 0x000000018BC2A324-0x000000018BC2A42C
		public UIScrollList.MoveTipsType __Gen_Wrap_76(object P0) => default; // 0x00000001873408C8-0x0000000187340998
		public void __Gen_Wrap_77(object P0, Vector2 P1) {} // 0x000000018BC2A42C-0x000000018BC2A540
		public void __Gen_Wrap_78(object P0, int P1, bool P2, UIScrollList.ScrollAlignType P3, bool P4) {} // 0x000000018BC2A540-0x000000018BC2A64C
		public UIText __Gen_Wrap_79(object P0) => default; // 0x000000018BC2A64C-0x000000018BC2A73C
		public string __Gen_Wrap_80(object P0) => default; // 0x000000018BC2A884-0x000000018BC2A974
		public Sprite __Gen_Wrap_81(object P0) => default; // 0x000000018BC2A974-0x000000018BC2AA50
		public UIStyleInputValidTypeMask __Gen_Wrap_82(object P0) => default; // 0x000000018767917C-0x0000000187679238
		public void __Gen_Wrap_83(object P0, UIStyleInputValidTypeMask P1) {} // 0x000000018A80A9F8-0x000000018A80AAC0
		public bool __Gen_Wrap_84(UIStyleInputValidType P0) => default; // 0x000000018BC2AA50-0x000000018BC2AB1C
		public bool __Gen_Wrap_85(UIStyleInputValidTypeMask P0) => default; // 0x000000018A80C970-0x000000018A80CA28
		public void __Gen_Wrap_86(object P0, int P1, int P2) {} // 0x000000018767830C-0x0000000187678404
		public int __Gen_Wrap_87() => default; // 0x0000000187352750-0x00000001873527E8
		public void __Gen_Wrap_88(object P0, bool P1, bool P2) {} // 0x000000018800BD1C-0x000000018800BE14
		public Selectable __Gen_Wrap_89(object P0) => default; // 0x000000018BC2AB1C-0x000000018BC2AC0C
		public bool __Gen_Wrap_90(object P0, Vector2 P1, object P2) => default; // 0x000000018BC2AC0C-0x000000018BC2AD48
		public IList<UIRecycleLayoutAdapter.IVirtualView> __Gen_Wrap_91(object P0) => default; // 0x000000018BC2AD48-0x000000018BC2AE24
		public UIRecycleLayoutAdapter __Gen_Wrap_92(object P0) => default; // 0x000000018BC2AE24-0x000000018BC2AF00
		public UIRecycleLayoutGroup.ViewMgr __Gen_Wrap_93(object P0) => default; // 0x000000018BC2AF00-0x000000018BC2AFDC
		public void __Gen_Wrap_94(object P0, object P1, UIRecycleLayoutGroup.LayoutMeta P2) {} // 0x000000018BC2AFDC-0x000000018BC2B0F8
		public Vector2 __Gen_Wrap_95(object P0, Bounds P1) => default; // 0x000000018BC2B0F8-0x000000018BC2B220
		public Bounds __Gen_Wrap_96(object P0, UIRecycleLayoutGroup.LayoutMeta P1) => default; // 0x000000018BC2B220-0x000000018BC2B364
		public UIRecycleLayoutAdapter __Gen_Wrap_97(object P0, object P1) => default; // 0x000000018BC2B364-0x000000018BC2B45C
		public UIRecycleLayoutGroup.ViewPool __Gen_Wrap_98(object P0, object P1) => default; // 0x000000018BC2B45C-0x000000018BC2B554
		public GameObject __Gen_Wrap_99(object P0, out bool P1) {
			P1 = default;
			return default;
		} // 0x000000018BC2B554-0x000000018BC2B670
		public bool __Gen_Wrap_100(object P0, int P1, object P2) => default; // 0x000000018BC249F8-0x000000018BC24AEC
		public UIRecycleLayoutAdapter.IVirtualView __Gen_Wrap_101(object P0, int P1) => default; // 0x000000018BC24AEC-0x000000018BC24BE4
		public float __Gen_Wrap_102(object P0, int P1) => default; // 0x000000018BC24BE4-0x000000018BC24CBC
		public Bounds __Gen_Wrap_103(object P0, int P1) => default; // 0x000000018BC24CBC-0x000000018BC24DDC
		public int __Gen_Wrap_104(object P0, object P1) => default; // 0x000000018A812784-0x000000018A81285C
		public UIRecycleLayoutGroup.Direction __Gen_Wrap_105(object P0) => default; // 0x000000018767917C-0x0000000187679238
		public UIRecycleMultiHolder.MultiVirtualView __Gen_Wrap_106(object P0, int P1) => default; // 0x000000018BC24DDC-0x000000018BC24ED4
		public void __Gen_Wrap_107(object P0, int P1, object P2, float P3) {} // 0x000000018BC24ED4-0x000000018BC24FCC
		public UIRecycleSingleHolder.SimpleVirtualView __Gen_Wrap_108(object P0, int P1) => default; // 0x000000018BC24FCC-0x000000018BC250C4
		public ToastList.CellInfo __Gen_Wrap_109(object P0) => default; // 0x000000018BC250C4-0x000000018BC251A0
		public IEnumerator __Gen_Wrap_110(object P0, int P1, object P2) => default; // 0x000000018BC251A0-0x000000018BC252B4
		public bool __Gen_Wrap_111(object P0, object P1, object P2) => default; // 0x00000001880103C0-0x00000001880104C8
		public bool __Gen_Wrap_112(object P0, object P1, object P2, bool P3, out bool P4, bool P5) {
			P4 = default;
			return default;
		} // 0x000000018BC252B4-0x000000018BC2540C
		public PlayerActionInfo __Gen_Wrap_113(object P0) => default; // 0x000000018BC2540C-0x000000018BC254FC
		public bool __Gen_Wrap_114(object P0, object P1, bool P2, bool P3) => default; // 0x0000000188010CD4-0x0000000188010DE8
		public void __Gen_Wrap_115(Beyond.DeviceInfo.ControllerType P0) {} // 0x00000001872E71D4-0x00000001872E7280
		public void __Gen_Wrap_116(object P0, in EventData<string> P1) {} // 0x000000018BC254FC-0x000000018BC25614
		public void __Gen_Wrap_117(object P0, object P1, object P2, bool P3) {} // 0x000000018A830C98-0x000000018A830D90
		public void __Gen_Wrap_118(object P0, int P1, object P2, object P3, bool P4) {} // 0x000000018BC25614-0x000000018BC25720
		public AnimationClip __Gen_Wrap_119(object P0, object P1, bool P2) => default; // 0x000000018BC25720-0x000000018BC25834
		public AnimationClip __Gen_Wrap_120(object P0, object P1) => default; // 0x000000018BC2592C-0x000000018BC25A24
		public void __Gen_Wrap_121(object P0, UIAnimationWrapper.FOptions P1) {} // 0x000000018BC25A24-0x000000018BC25B30
		public float __Gen_Wrap_122(object P0, object P1) => default; // 0x00000001876AC704-0x00000001876AC7F0
		public UIAnimationWrapper.FOptions __Gen_Wrap_123() => default; // 0x000000018BC25B30-0x000000018BC25BE8
		public void __Gen_Wrap_124(object P0, object P1, object P2, float P3) {} // 0x000000018800DF7C-0x000000018800E084
		public UISwitchTween.ITweenHandler __Gen_Wrap_125(object P0) => default; // 0x000000018BC25BE8-0x000000018BC25CD8
		public UISwitchTween.ITweenHandler __Gen_Wrap_126(object P0, object P1) => default; // 0x000000018BC25CD8-0x000000018BC25DE4
		public UISwitchTween.ITweenHandler __Gen_Wrap_127(object P0, bool P1) => default; // 0x000000018BC25DE4-0x000000018BC25EF0
		public UIAnimationSwitchTween __Gen_Wrap_128(ref UIAnimationSwitchTween.Builder P0) => default; // 0x000000018BC25EF0-0x000000018BC2603C
		public Camera __Gen_Wrap_129(object P0) => default; // 0x000000018BC2603C-0x000000018BC2612C
		public void __Gen_Wrap_130(object P0, object P1, bool P2, bool P3, bool P4, bool P5, bool P6) {} // 0x0000000182C428E0-0x0000000182C42CF0
		public void __Gen_Wrap_131(object P0, bool P1, bool P2, bool P3, bool P4, float P5) {} // 0x0000000183ED6790-0x0000000183ED6AF0
		public void __Gen_Wrap_132(object P0, float P1, bool P2) {} // 0x000000018BC2612C-0x000000018BC26228
		public IEnumerator __Gen_Wrap_133(object P0, object P1) => default; // 0x000000018BC26228-0x000000018BC26334
		public DisposedUnityEvent<int, bool> __Gen_Wrap_134(object P0) => default; // 0x000000018BC26334-0x000000018BC26410
		public void __Gen_Wrap_135(object P0, out Vector2 P1, out Vector2 P2) {
			P1 = default;
			P2 = default;
		} // 0x000000018BC26410-0x000000018BC26570
		public Vector2 __Gen_Wrap_136(object P0, Vector2 P1) => default; // 0x000000018BC26570-0x000000018BC266A0
		public void __Gen_Wrap_137(PointerEventData P0) {} // 0x0000000187678964-0x0000000187678A10
		public void __Gen_Wrap_138(object P0, Vector3 P1) {} // 0x000000018BC266A0-0x000000018BC267BC
		public void __Gen_Wrap_139(object P0, bool P1, float P2, object P3, object P4) {} // 0x000000018BC267BC-0x000000018BC268D8
		public void __Gen_Wrap_140(float P0) {} // 0x0000000187937D8C-0x0000000187937E4C
		public void __Gen_Wrap_141(object P0, bool P1, out Selectable P2, out UITouchPanel P3) {
			P2 = default;
			P3 = default;
		} // 0x000000018BC268D8-0x000000018BC26A64
		public void __Gen_Wrap_142(object P0, float P1, float P2, object P3) {} // 0x000000018BC26A64-0x000000018BC26B60
		public void __Gen_Wrap_143(object P0, object P1, bool P2, object P3) {} // 0x000000018A8578C4-0x000000018A8579BC
		public UIBigRectHelper.BigRectRecoverState __Gen_Wrap_144(object P0) => default; // 0x0000000183ED6AF0-0x0000000183ED7420
		public void __Gen_Wrap_145(object P0, out float P1, out float P2) {
			P1 = default;
			P2 = default;
		} // 0x0000000183ED7420-0x0000000183ED7750
		public void __Gen_Wrap_146(object P0, object P1, UnityEngine.Color P2) {} // 0x0000000183ED7750-0x0000000183ED7E90
		public Canvas __Gen_Wrap_147(object P0) => default; // 0x0000000183ED7E90-0x0000000183ED87C0
		public HGCamera __Gen_Wrap_148(object P0) => default; // 0x0000000183ED87C0-0x0000000183ED90F0
		public string __Gen_Wrap_149(object P0, object P1) => default; // 0x0000000183ED90F0-0x0000000183ED9B20
		public BindingViewState __Gen_Wrap_150(object P0) => default; // 0x0000000181375C70-0x0000000181375F30
		public string __Gen_Wrap_151(object P0, BindingViewActionType P1) => default; // 0x0000000183ED9B20-0x0000000183EDA480
		public bool __Gen_Wrap_152(object P0, out string P1, out string P2) {
			P1 = default;
			P2 = default;
			return default;
		} // 0x0000000183EDA480-0x0000000183EDB050
		public void __Gen_Wrap_153(object P0, ActionOnSetNaviTarget P1) {} // 0x000000018155EB40-0x000000018155EE10
		public HashSet<CanvasScaler> __Gen_Wrap_154(object P0) => default; // 0x0000000183EDB050-0x0000000183EDB980
		public Vector2 __Gen_Wrap_155(object P0) => default; // 0x0000000183EDB980-0x0000000183EDC270
		public float __Gen_Wrap_156(out Vector2 P0) {
			P0 = default;
			return default;
		} // 0x0000000183EDC270-0x0000000183EDCB10
		public UICanvasScaleHelper.FWorldCanvasParams __Gen_Wrap_157(object P0, object P1, bool P2) => default; // 0x0000000183EDCB10-0x0000000183EDD520
		public UICanvasScaleHelper.FScreenCanvasParams __Gen_Wrap_158() => default; // 0x0000000183EDD520-0x0000000183EDDD30
		public void __Gen_Wrap_159(object P0, UIColorGroup.CommonParams P1) {} // 0x0000000183EDDD30-0x0000000183EDE3C0
		public void __Gen_Wrap_160(object P0, object P1, UIColorGroup.CommonParams P2) {} // 0x0000000183EDE3C0-0x0000000183EDEB40
		public void __Gen_Wrap_161(object P0, float P1, float P2, bool P3) {} // 0x0000000183EDEB40-0x0000000183EDEE60
		public void __Gen_Wrap_162(object P0, UnityEngine.Color P1, float P2, bool P3, bool P4, bool P5) {} // 0x0000000183EDEE60-0x0000000183EDF550
		public void __Gen_Wrap_163(object P0, UnityEngine.Color P1, float P2, bool P3, bool P4) {} // 0x0000000183EDF550-0x0000000183EDFC60
		public void __Gen_Wrap_164(object P0, GamepadKeyCode P1) {} // 0x000000018155EB40-0x000000018155EE10
		public UICustomLayoutElement __Gen_Wrap_165(object P0) => default; // 0x0000000183EDFC60-0x0000000183EE05A0
		public string __Gen_Wrap_166(object P0, int P1) => default; // 0x0000000183EE05A0-0x0000000183EE0F40
		public bool __Gen_Wrap_167(object P0, out UICustomLayoutElement.LayoutData P1, bool P2, int P3) {
			P1 = default;
			return default;
		} // 0x0000000183EE0F40-0x0000000183EE1990
		public bool __Gen_Wrap_168(object P0, out UICustomLayoutElement.LayoutData P1, int P2) {
			P1 = default;
			return default;
		} // 0x0000000183EE1990-0x0000000183EE23C0
		public RectTransform __Gen_Wrap_169(object P0) => default; // 0x0000000183EE23C0-0x0000000183EE2D00
		public void __Gen_Wrap_170(object P0, UICustomLayoutElement.LayoutType P1) {} // 0x000000018155EB40-0x000000018155EE10
		public CanvasGroup __Gen_Wrap_171(object P0) => default; // 0x0000000183EE2D00-0x0000000183EE3630
		public void __Gen_Wrap_172(object P0, bool P1, object P2) {} // 0x00000001815521B0-0x0000000181552550
		public void __Gen_Wrap_173(object P0, object P1, object P2, object P3) {} // 0x00000001815B7830-0x00000001815B7DA0
		public void __Gen_Wrap_174(object P0, int P1, bool P2, bool P3, bool P4) {} // 0x000000018222FA70-0x000000018222FDB0
		public void __Gen_Wrap_175(object P0, Vector2 P1, bool P2) {} // 0x0000000183EE3630-0x0000000183EE3D00
		public void __Gen_Wrap_176(object P0, int P1, int P2, bool P3) {} // 0x00000001821C7A50-0x00000001821C7D70
		public float __Gen_Wrap_177(object P0, bool P1, int P2) => default; // 0x0000000183EE3D00-0x0000000183EE4010
		public void __Gen_Wrap_178(object P0, bool P1, float P2, float P3) {} // 0x0000000182A81170-0x0000000182A814B0
		public void __Gen_Wrap_179(object P0, Rect P1) {} // 0x0000000183EE4010-0x0000000183EE4690
		public float __Gen_Wrap_180(object P0, object P1, bool P2) => default; // 0x00000001821D3370-0x00000001821D3740
		public void __Gen_Wrap_181(object P0, int P1, float P2) {} // 0x00000001821E10F0-0x00000001821E13E0
		public bool __Gen_Wrap_182(object P0, bool P1, bool P2) => default; // 0x0000000183EE4690-0x0000000183EE49A0
		public Selectable __Gen_Wrap_183(object P0, bool P1) => default; // 0x0000000183EE49A0-0x0000000183EE5340
		public bool __Gen_Wrap_184(object P0, int P1, int P2, bool P3, bool P4) => default; // 0x0000000183EE5340-0x0000000183EE5680
		public bool __Gen_Wrap_185(object P0, NaviDirection P1, bool P2) => default; // 0x00000001823DA180-0x00000001823DA480
		public void __Gen_Wrap_186(object P0, NaviDirection P1) {} // 0x000000018155EB40-0x000000018155EE10
		public bool __Gen_Wrap_187(object P0, NaviDirection P1) => default; // 0x0000000181889FD0-0x000000018188A2B0
		public Vector3 __Gen_Wrap_188() => default; // 0x0000000183EE5680-0x0000000183EE5E90
		public void __Gen_Wrap_189(Vector3 P0) {} // 0x0000000183EE5E90-0x0000000183EE6430
		public UIAtlasManager.UIAtlasHandle __Gen_Wrap_190(UIAtlasManager.UIAtlasProcessFailureCause P0) => default; // 0x0000000183EE6430-0x0000000183EE6C80
		public Texture __Gen_Wrap_191(object P0) => default; // 0x0000000183EE6C80-0x0000000183EE75C0
		public TweenerCore<float, float, FloatOptions> __Gen_Wrap_192(object P0, float P1, float P2) => default; // 0x0000000183EE75C0-0x0000000183EE7F50
		public UIImage __Gen_Wrap_193(object P0) => default; // 0x0000000183EE7F50-0x0000000183EE8880
		public bool __Gen_Wrap_194(ref UIInertiaViewPager.ScrollEffectConfig P0) => default; // 0x0000000183EE8880-0x0000000183EE94A0
		public int __Gen_Wrap_195(object P0, float P1) => default; // 0x00000001815E37C0-0x00000001815E3AB0
		public float __Gen_Wrap_196(object P0, float P1) => default; // 0x00000001816F3F20-0x00000001816F4210
		public UIInertiaViewPager.State __Gen_Wrap_197(object P0, object P1) => default; // 0x000000018135A390-0x000000018135A720
		public bool __Gen_Wrap_198(ref UIInertiaViewPager.InertiaBlocker P0, float P1) => default; // 0x0000000183EE94A0-0x0000000183EEA080
		public bool __Gen_Wrap_199(object P0, float P1, out float P2) {
			P2 = default;
			return default;
		} // 0x0000000183EEA080-0x0000000183EEA3A0
		public void __Gen_Wrap_200(object P0, float P1, float P2) {} // 0x00000001817989E0-0x0000000181798CE0
		public void __Gen_Wrap_201(object P0, UIInertiaViewPager.State P1, UIInertiaViewPager.State P2) {} // 0x0000000181F55370-0x0000000181F55660
		public void __Gen_Wrap_202(object P0, int P1, object P2) {} // 0x0000000181391570-0x0000000181391940
		public void __Gen_Wrap_203(ref UIInertiaViewPager.EmptyScrollHandler P0) {} // 0x0000000183EEA3A0-0x0000000183EEAF60
		public void __Gen_Wrap_204(object P0, bool P1, Vector2 P2, Vector2 P3) {} // 0x0000000183EEAF60-0x0000000183EEB720
		public void __Gen_Wrap_205(object P0, CanvasUpdate P1) {} // 0x0000000181566ED0-0x00000001815671B0
		public Transform __Gen_Wrap_206(object P0) => default; // 0x0000000183EEB720-0x0000000183EEC060
		public void __Gen_Wrap_207(object P0, object P1, object P2, object P3, object P4) {} // 0x00000001816072A0-0x0000000181607880
		public int __Gen_Wrap_208(object P0, bool P1) => default; // 0x0000000182162840-0x0000000182162B30
		public float __Gen_Wrap_209(object P0, int P1, UIScrollList.ScrollAlignType P2) => default; // 0x0000000182E3A850-0x0000000182E3AB50
		public void __Gen_Wrap_210(object P0, int P1, bool P2, UIScrollList.ScrollAlignType P3) {} // 0x000000018218CB30-0x000000018218CE50
		public void __Gen_Wrap_211(object P0, int P1, int P2, bool P3, bool P4, bool P5, UIScrollList.ScrollAlignType P6) {} // 0x0000000183EEC060-0x0000000183EEC3F0
		public void __Gen_Wrap_212(object P0, int P1, bool P2, bool P3, bool P4, bool P5) {} // 0x0000000183EEC3F0-0x0000000183EEC760
		public GameObject __Gen_Wrap_213(object P0, int P1) => default; // 0x0000000183EEC760-0x0000000183EED100
		public UIScrollList.Cell __Gen_Wrap_214(object P0, int P1) => default; // 0x0000000183EED100-0x0000000183EEDAA0
		public int __Gen_Wrap_215(object P0, NaviDirection P1) => default; // 0x0000000181600DE0-0x00000001816010C0
		public int __Gen_Wrap_216(object P0, int P1, NaviDirection P2) => default; // 0x000000018163A7A0-0x000000018163AA90
		public void __Gen_Wrap_217(object P0, float P1, float P2, float P3) {} // 0x0000000183EEDAA0-0x0000000183EEDDC0
		public bool __Gen_Wrap_218(object P0, Vector3 P1) => default; // 0x0000000183EEDDC0-0x0000000183EEE460
		public Vector3 __Gen_Wrap_219(object P0) => default; // 0x0000000183EEE460-0x0000000183EEED50
		public float __Gen_Wrap_220(object P0, Vector2 P1) => default; // 0x0000000183EEED50-0x0000000183EEF400
		public bool __Gen_Wrap_221(object P0, float P1) => default; // 0x0000000181FDFBC0-0x0000000181FDFEC0
		public UIScrollList.Padding __Gen_Wrap_222(object P0) => default; // 0x0000000183EEF400-0x0000000183EEFCF0
		public void __Gen_Wrap_223(object P0, out int P1, out int P2) {
			P1 = default;
			P2 = default;
		} // 0x0000000182490620-0x0000000182490940
		public int __Gen_Wrap_224(object P0, int P1, int P2) => default; // 0x000000018163A7A0-0x000000018163AA90
		public int __Gen_Wrap_225(object P0, Vector2 P1, NaviDirection P2) => default; // 0x0000000183EEFCF0-0x0000000183EF0390
		public void __Gen_Wrap_226(object P0, Vector2 P1, out int P2, out int P3) {
			P2 = default;
			P3 = default;
		} // 0x0000000183EF0390-0x0000000183EF0A80
		public UIScrollRect.MoveTipsType __Gen_Wrap_227(object P0) => default; // 0x00000001815570F0-0x00000001815573B0
		public void __Gen_Wrap_228(object P0, object P1, object P2, UIScrollRectEdgeRedDot.ERedDotState P3) {} // 0x0000000181549A10-0x0000000181549E70
		public void __Gen_Wrap_229(object P0, Vector2Int P1) {} // 0x0000000183EF0A80-0x0000000183EF1110
		public UIScrollRectEdgeRedDot.ERedDotState __Gen_Wrap_230(object P0) => default; // 0x00000001815570F0-0x00000001815573B0
		public Rect __Gen_Wrap_231(object P0) => default; // 0x0000000183EF1110-0x0000000183EF1A00
		public bool __Gen_Wrap_232(object P0, UIScrollRectEdgeRedDot.ERedDotState P1, UIScrollRectEdgeRedDot.ERedDotDir P2, object P3) => default; // 0x0000000182CFA1F0-0x0000000182CFA5C0
		public void __Gen_Wrap_233(object P0, out UIScrollRectEdgeRedDot.ERedDotState P1, out UIScrollRectEdgeRedDot.ERedDotState P2) {
			P1 = default;
			P2 = default;
		} // 0x0000000182490620-0x0000000182490940
		public void __Gen_Wrap_234(object P0, bool P1, float P2) {} // 0x0000000183EF1A00-0x0000000183EF1CF0
		public Vector3 __Gen_Wrap_235(object P0, int P1) => default; // 0x0000000183EF1CF0-0x0000000183EF25F0
		public Vector3[] __Gen_Wrap_236(object P0) => default; // 0x0000000183EF25F0-0x0000000183EF2F30
		public Graphic __Gen_Wrap_237(object P0) => default; // 0x0000000183EF2F30-0x0000000183EF3870
		public UISoftMask __Gen_Wrap_238(object P0) => default; // 0x0000000183EF3870-0x0000000183EF41B0
		public bool __Gen_Wrap_239(object P0, float P1, float P2) => default; // 0x0000000182966480-0x00000001829667B0
		public Vector2 __Gen_Wrap_240(object P0, Vector2 P1, Vector2 P2, Vector2 P3, Vector2 P4) => default; // 0x0000000183EF41B0-0x0000000183EF4F40
		public void __Gen_Wrap_241(object P0, Vector2 P1, Vector2 P2, Vector2 P3, Vector2 P4, out float P5, out float P6) {
			P5 = default;
			P6 = default;
		} // 0x0000000183EF4F40-0x0000000183EF59C0
		public void __Gen_Wrap_242(ref UIVertex P0, Vector2 P1, Vector2 P2, Vector2 P3) {} // 0x0000000183EF59C0-0x0000000183EF6890
		public void __Gen_Wrap_243(object P0, object P1, object P2, out bool P3) {
			P3 = default;
		} // 0x0000000183EF6890-0x0000000183EF6D70
		public UISoftMaskable __Gen_Wrap_244(object P0) => default; // 0x0000000183EF6D70-0x0000000183EF76B0
		public IEnumerator __Gen_Wrap_245(object P0, bool P1, int P2) => default; // 0x0000000183EF76B0-0x0000000183EF8020
		public void __Gen_Wrap_246(object P0, bool P1, int P2) {} // 0x00000001821369B0-0x0000000182136CA0
		public void __Gen_Wrap_247(object P0, object P1, bool P2, object P3, object P4, object P5, bool P6) {} // 0x0000000183EF8020-0x0000000183EF86D0
		public uint __Gen_Wrap_248(object P0) => default; // 0x00000001815570F0-0x00000001815573B0
		public void __Gen_Wrap_249(uint P0, bool P1) {} // 0x00000001824C7E20-0x00000001824C8030
		public TMP_FontAsset __Gen_Wrap_250(object P0, object P1) => default; // 0x0000000183EF86D0-0x0000000183EF9100
		public bool __Gen_Wrap_251(object P0, object P1, uint P2, out TMP_FontAsset P3) {
			P3 = default;
			return default;
		} // 0x0000000183EF9100-0x0000000183EF9C50
		public bool __Gen_Wrap_252(ref float P0, float P1) => default; // 0x0000000183EF9C50-0x0000000183EF9EC0
		public void __Gen_Wrap_253(ref TweenUtils.FLerpByTime P0, object P1) {} // 0x0000000183EF9EC0-0x0000000183EFABC0
		public float __Gen_Wrap_254(ref TweenUtils.FLerpByTime P0, out bool P1) {
			P1 = default;
			return default;
		} // 0x0000000183EFABC0-0x0000000183EFB7A0
		public PlayableGraph __Gen_Wrap_255(object P0) => default; // 0x0000000183EFB7A0-0x0000000183EFC080
		public AnimationLayerMixerPlayable __Gen_Wrap_256(object P0, PlayableGraph P1, out GenericShareSingleMixerAssetPlayer<AnimationClip> P2) {
			P2 = default;
			return default;
		} // 0x0000000183EFC080-0x0000000183EFD0B0
		public AnimationPlayableOutput __Gen_Wrap_257(object P0, PlayableGraph P1) => default; // 0x0000000183EFD0B0-0x0000000183EFDD50
		public AnimationClipPlayable __Gen_Wrap_258(object P0, object P1, PlayableGraph P2, out GenericShareSingleMixerAssetPlayer<AnimationClip> P3) {
			P3 = default;
			return default;
		} // 0x0000000183EFDD50-0x0000000183EFECA0
		public AnimationMixerPlayable __Gen_Wrap_259(object P0, PlayableGraph P1, out GenericShareSingleMixerAssetPlayer<AnimationClip> P2) {
			P2 = default;
			return default;
		} // 0x0000000183EFECA0-0x0000000183EFFCD0
		public void __Gen_Wrap_260(bool P0, FAssetProxyHandle P1) {} // 0x0000000183EFFCD0-0x0000000183F00280
		public void __Gen_Wrap_261(ref UISwitchTween.TweenContext P0) {} // 0x0000000183F00280-0x0000000183F00E40
		public void __Gen_Wrap_262(ref UISwitchTween.TweenContext P0, object P1) {} // 0x0000000183F00E40-0x0000000183F01B00
		public void __Gen_Wrap_263(object P0, UISwitchTween.Options P1) {} // 0x0000000183F01B00-0x0000000183F02170
		public UISwitchTween.TweenContext __Gen_Wrap_264(object P0) => default; // 0x0000000183F02170-0x0000000183F02A50
		public bool __Gen_Wrap_265(ref UISwitchTween.TweenContext P0) => default; // 0x0000000183F02A50-0x0000000183F03600
		public float __Gen_Wrap_266(ref FadeSwitchTween.Durations P0, float P1) => default; // 0x0000000183F03600-0x0000000183F04210
		public FadeSwitchTween __Gen_Wrap_267(ref FadeSwitchTween.Builder P0) => default; // 0x0000000183F04210-0x0000000183F05110
		public Vector2 __Gen_Wrap_268(object P0, bool P1) => default; // 0x0000000183F05110-0x0000000183F05A30
		public void __Gen_Wrap_269(object P0, in RectInt P1) {} // 0x0000000183F05A30-0x0000000183F060B0
		public bool __Gen_Wrap_270(object P0, object P1, out UIAtlasManager.UIAtlasProcessFailureCause P2) {
			P2 = default;
			return default;
		} // 0x000000018252FE10-0x00000001825301E0
		public RectInt __Gen_Wrap_271(object P0, int P1, int P2) => default; // 0x0000000183F060B0-0x0000000183F069D0
		public void __Gen_Wrap_272(object P0, object P1, object P2, in RectInt P3) {} // 0x0000000183F069D0-0x0000000183F071F0
		public bool __Gen_Wrap_273(ref UIAtlasManager.UIAtlasHandle P0) => default; // 0x0000000183F071F0-0x0000000183F07DC0
		public void __Gen_Wrap_274(object P0, in List<RectInt> P1) {} // 0x0000000182AF3640-0x0000000182AF39D0
		public void __Gen_Wrap_275(int P0, string P1) {} // 0x0000000181366C10-0x0000000181366EE0
		public void __Gen_Wrap_276(string P0) {} // 0x0000000181354D40-0x0000000181355000
		public bool __Gen_Wrap_277(StateAnimationInfo P0) => default; // 0x00000001813541F0-0x00000001813544C0
		public GPUPrefabData __Gen_Wrap_278(Vector4 P0, Vector4 P1, Vector2 P2) => default; // 0x0000000183F07DC0-0x0000000183F08E40
		public GPUPrefabDataLite __Gen_Wrap_279(Vector4 P0, Vector4 P1, Vector2 P2) => default; // 0x0000000183F08E40-0x0000000183F09E40
		public bool __Gen_Wrap_280(ref GPUIHandle P0, GPUIHandle P1) => default; // 0x0000000183F09E40-0x0000000183F0AB30
		public bool __Gen_Wrap_281(ref GPUIHandle P0, object P1) => default; // 0x0000000183F0AB30-0x0000000183F0B7D0
		public int __Gen_Wrap_282(ref GPUIHandle P0) => default; // 0x0000000183F0B7D0-0x0000000183F0C380
		public bool __Gen_Wrap_283(GPUIHandle P0, GPUIHandle P1) => default; // 0x0000000183F0C380-0x0000000183F0CA30
		public GPUIHandle __Gen_Wrap_284(object P0) => default; // 0x0000000183F0CA30-0x0000000183F0D310
		public void __Gen_Wrap_285(object P0, GPUIHandle P1) {} // 0x0000000183F0D310-0x0000000183F0D990
		public bool __Gen_Wrap_286(object P0, object P1, out GPUIHandle P2, int P3) {
			P2 = default;
			return default;
		} // 0x0000000183F0D990-0x0000000183F0E440
		public bool __Gen_Wrap_287(object P0, GPUIHandle P1) => default; // 0x0000000183F0E440-0x0000000183F0EAD0
		public void __Gen_Wrap_288(object P0, int P1, Vector3 P2) {} // 0x0000000183F0EAD0-0x0000000183F0F190
		public bool __Gen_Wrap_289(object P0, GPUIHandle P1, Vector3 P2) => default; // 0x0000000183F0F190-0x0000000183F0FBC0
		public bool __Gen_Wrap_290(object P0, object P1, Vector3 P2, out GPUIHandle P3, int P4) {
			P3 = default;
			return default;
		} // 0x0000000183F0FBC0-0x0000000183F10930
		public bool __Gen_Wrap_291(object P0, GPUIHandle P1, Vector2 P2) => default; // 0x0000000183F10930-0x0000000183F11310
		public void __Gen_Wrap_292(object P0, float P1, int P2) {} // 0x0000000182355EE0-0x00000001823561F0
		public bool __Gen_Wrap_293(object P0, GPUIHandle P1, bool P2, object P3, bool P4) => default; // 0x0000000183F11310-0x0000000183F11AE0
		public bool __Gen_Wrap_294(object P0, GPUIHandle P1, bool P2, int P3, bool P4) => default; // 0x0000000183F11AE0-0x0000000183F121D0
		public bool __Gen_Wrap_295(object P0, GPUIHandle P1, object P2, bool P3) => default; // 0x0000000183F121D0-0x0000000183F12940
		public uint __Gen_Wrap_296(UnityEngine.Color P0) => default; // 0x0000000183F12940-0x0000000183F12EF0
		public void __Gen_Wrap_297(object P0, int P1, UnityEngine.Color P2) {} // 0x0000000183F12EF0-0x0000000183F13560
		public bool __Gen_Wrap_298(object P0, GPUIHandle P1, object P2, UnityEngine.Color P3) => default; // 0x0000000183F13560-0x0000000183F14020
		public bool __Gen_Wrap_299(object P0, GPUIHandle P1, object P2, object P3) => default; // 0x0000000183F14020-0x0000000183F14890
		public void __Gen_Wrap_300(object P0, ref NativeArray<GPUInstanceData> P1, out int P2, out int P3, out int P4) {
			P2 = default;
			P3 = default;
			P4 = default;
		} // 0x0000000183F14890-0x0000000183F15470
		public void __Gen_Wrap_301(object P0, ref NativeArray<GPUInstanceData> P1, int P2, bool P3) {} // 0x0000000183F15470-0x0000000183F16170
		public NativeArray<CanvasRenderer.InstanceRange> __Gen_Wrap_302(object P0) => default; // 0x0000000183F16170-0x0000000183F16A50
		public int __Gen_Wrap_303(object P0, object P1, int P2) => default; // 0x00000001815F5F10-0x00000001815F62B0
		public RuntimePrefabData __Gen_Wrap_304(object P0, object P1) => default; // 0x0000000183F16A50-0x0000000183F17470
		public Mesh __Gen_Wrap_305() => default; // 0x0000000183F17470-0x0000000183F17CB0
		public uint __Gen_Wrap_306(uint P0, uint P1) => default; // 0x0000000181637130-0x0000000181637350
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 50454
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BBE6D44-0x000000018BBE6DF0 
		object IEnumerator.Current { get => default; } // 0x000000018BBE6DF0-0x000000018BBE6E9C 
	
		// Constructors
		public ILFixInterfaceBridge() {} // Dummy constructor
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine) {} // 0x000000018BBE6E9C-0x000000018BBE6F78
	
		// Methods
		void IDisposable.Dispose() {} // 0x00000001873416FC-0x0000000187341778
		private bool MoveNext() => default; // 0x0000000187341518-0x00000001873415A4
		void IEnumerator.Reset() {} // 0x00000001872E7280-0x00000001872E72FC
		public void RefAsyncBuilderStartMethod() {} // 0x0000000185492010-0x0000000185492020
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 50455
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl() {} // Dummy constructor
		public WrappersManagerImpl(VirtualMachine virtualMachine) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id) => default; // 0x000000018BBE7BA0-0x000000018BBE7C04
		public static bool IsPatched(int id) => default; // 0x00000001840E6E40-0x00000001840E6EF0
		public Delegate CreateDelegate(System.Type type, int id, object anon) => default; // 0x000000018BBE7A5C-0x000000018BBE7B28
		public object CreateWrapper(int id) => default; // 0x000000018BBE7B28-0x000000018BBE7BA0
		public object InitWrapperArray(int len) => default; // 0x000000018BBE7C04-0x000000018BBE7FE4
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine) => default; // 0x000000018BBE79B8-0x000000018BBE7A5C
	}

	public enum IDMAP0 // TypeDefIndex: 50456
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
		Beyond-UI-I18nFontLoader-_GetFontById0 = 82,
		Beyond-UI-UIText-OnPointerClick0 = 83,
		Beyond-UI-UIText-OnPointerEnter0 = 84,
		Beyond-UI-UIText-OnPointerExit0 = 85,
		Beyond-UI-UIText-Start0 = 86,
		Beyond-UI-UIText-SetHyperlinkUITextGroup0 = 87,
		Beyond-UI-UIText-HyperlinkUITextManager-AddWrap0 = 88,
		Beyond-UI-UIText-HyperlinkUITextWrap-Clear0 = 89,
		Beyond-UI-UIText-HyperlinkUITextGroup-Add0 = 90,
		Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapGroup0 = 91,
		Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapOrder0 = 92,
		Beyond-UI-UIText-OnEnable0 = 93,
		Beyond-UI-UIText-OnDisable0 = 94,
		Beyond-UI-UIText-ShrinkLinkTags0 = 95,
		Beyond-UI-UIText-TryGetLinkId1 = 96,
		Beyond-UI-UIText-TryGetCharacterStartPosAndHeight0 = 97,
		Beyond-UI-UIText-TryGetCharacterEndPosAndHeight0 = 98,
		Beyond-UI-UIText-CombineStringWithLanguageSpilt0 = 99,
		Beyond-UI-UIText-CombineStringReverseForIndonesianAndVietnamese0 = 100,
		Beyond-UI-UIText-IsHyperlinkUITextGroupDisplayable0 = 101,
		Beyond-UI-UIText-HyperlinkUITextManager-IsGroupDisplayable0 = 102,
		Beyond-UI-UIText-GetGroupDisplayableHyperlinkUIText0 = 103,
		Beyond-UI-UIText-HyperlinkUITextManager-GetGroupDisplayableUIText0 = 104,
		Beyond-UI-UIText-UpdateI18NFontAsset0 = 110,
		Beyond-UI-UIText-get_m_fontAsset0 = 111,
		Beyond-UI-UIText-set_m_fontAsset0 = 112,
		Beyond-UI-I18nFontLoader-GetCNFontId0 = 113,
		Beyond-UI-UIText-set_fontSharedMaterial0 = 114,
		Beyond-UI-UIText-SetSharedMaterial0 = 115,
		Beyond-UI-UIText-UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize0 = 116,
		Beyond-UI-UIText-OnAfterDeserialize0 = 117,
		Beyond-UI-UIText-AddSubTextObject0 = 118,
		Beyond-UI-UIText-LocalStringCombineFormat0 = 119,
		Beyond-UI-UIConst-GetResolutionScale0 = 120,
		Beyond-UI-UIConst-IsPadDevice0 = 121,
		Beyond-UI-UIModelLoader-LoadModel0 = 122,
		Beyond-UI-UIModelLoader-LoadModelAsync0 = 123,
		Beyond-UI-UIModelLoader-Cancel0 = 126,
		Beyond-UI-UIModelLoader-UnloadModel0 = 127,
		Beyond-UI-UIModelLoader-_Clear0 = 128,
		Beyond-UI-UIModelLoader-Dispose0 = 129,
		Beyond-UI-UIUtils-GetSharedIntString0 = 130,
		Beyond-UI-UIUtils-IsScreenPosInRectTransform0 = 131,
		Beyond-UI-UIUtils-IsScreenPosInRectTransform1 = 132,
		Beyond-UI-UIUtils-CalcBoundOfRectTransform0 = 133,
		Beyond-UI-UIUtils-TryGetTouch0 = 134,
		Beyond-UI-UIUtils-SetAlpha0 = 135,
		Beyond-UI-UIUtils-SetColorWithoutAlpha0 = 136,
		Beyond-UI-UIUtils-ClearUIComponents0 = 137,
		Beyond-UI-UIUtils-RectTransformToScreenRect0 = 138,
		Beyond-UI-UIUtils-GetNodeScaleOffset0 = 139,
		Beyond-UI-UIUtils-GetColorByString0 = 140,
		Beyond-UI-UIUtils-SetMaskRatio0 = 141,
		Beyond-UI-UIUtils-GetCursorTipOffsetX0 = 142,
		Beyond-UI-UIUtils-GetCursorTipOffsetInScreen0 = 143,
		Beyond-UI-ActiveSyncHelper-Awake0 = 144,
		Beyond-UI-ActiveSyncHelper-Sync0 = 145,
		Beyond-UI-ActiveSyncHelper-OnEnable0 = 146,
		Beyond-UI-ActiveSyncHelper-OnDisable0 = 147,
		Beyond-UI-Billboard-OnEnable0 = 148,
		Beyond-UI-Billboard-Tick0 = 149,
		Beyond-UI-CinemachineGyroscopeEffect-PostPipelineStageCallback0 = 150,
		Beyond-UI-CommonItemToastList-ScrollToIndex0 = 151,
		Beyond-UI-UIScrollList-GetRealIndex0 = 152,
		Beyond-UI-CommonItemToastList-AdjustContainerPos0 = 154,
		Beyond-UI-CommonItemToastList-_GetUnConstraintTargetPos0 = 155,
		Beyond-UI-UIScrollList-OnScroll0 = 158,
		Beyond-UI-UIScrollList-UpdateShowingCells0 = 159,
		Beyond-UI-UIScrollList-ClearShowingCells0 = 160,
		Beyond-UI-UIScrollList-CacheCell0 = 161,
		Beyond-UI-UIScrollList-GetShowRange0 = 162,
		Beyond-UI-UIScrollList-GetNotCacheRange0 = 163,
		Beyond-UI-UIScrollList-UpdateCell0 = 164,
		Beyond-UI-UIScrollList-MoveCellTo0 = 165,
		Beyond-UI-UIScrollList-OnUpdateCell0 = 166,
		Beyond-UI-UIScrollList-GetCell0 = 167,
		Beyond-UI-UIAnimationWrapper-ClearTween0 = 168,
		Beyond-UI-UIAnimationWrapper-get_panel0 = 169,
		Beyond-UI-LuaPanel-InformAnimationInEnd0 = 170,
		Beyond-UI-LuaPanel-_TryCallAnimationInFinished0 = 171,
		Beyond-UI-LuaPanel-RecoverAllInput0 = 173,
		Beyond-UI-UIAnimationWrapper-PlayInAnimation0 = 174,
		Beyond-UI-UIAnimationWrapper-_OnInAnimationFinished0 = 177,
		Beyond-UI-UIAnimationWrapper-_OnInEasingAnimationFinished0 = 180,
		Beyond-UI-UIAnimationWrapper-_NotifyAnimationInEasingFinished0 = 181,
		Beyond-UI-UIAnimationWrapper-PlayLoopAnimation0 = 182,
		Beyond-UI-UIAnimationLoopSynchronizer-GetLoopStartPosition0 = 183,
		Beyond-UI-UIAnimationWrapper-PlayWithTween0 = 185,
		Beyond-UI-UIAnimationWrapper-GetClip0 = 188,
		Beyond-UI-UIAnimationWrapper-_InitAnimation0 = 189,
		Beyond-UI-UIAnimationWrapper-SampleClip0 = 190,
		Beyond-UI-UIAnimationWrapper-_SampleClipAtLength0 = 191,
		Beyond-UI-LuaPanel-InformAnimationInStart0 = 192,
		Beyond-UI-UIAnimationWrapper-PlayWithTween1 = 193,
		Beyond-UI-UIAnimationWrapper-PlayOpenAudio0 = 194,
		Beyond-UI-UIScrollList-_UpdateMoveTips0 = 195,
		Beyond-UI-UIScrollList-get_moveTips0 = 196,
		Beyond-UI-UIScrollList-UpdateViewEffect0 = 197,
		Beyond-UI-ControllerSideMenuItemList-ToggleItemForceValid0 = 198,
		Beyond-UI-ControllerSideMenuItemList-IsItemForceValid0 = 199,
		Beyond-UI-ControllerSideMenuItemList-ClearForceValidItemList0 = 200,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-IsValid0 = 201,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetText0 = 202,
		Beyond-UI-UIButton-get_text0 = 203,
		Beyond-UI-UIButton-get_label0 = 204,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetSprite0 = 205,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-Execute0 = 206,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetItemName0 = 207,
		Beyond-UI-CustomUIStyle-get_inputValidTypeMask0 = 208,
		Beyond-UI-CustomUIStyle-set_inputValidTypeMask0 = 209,
		Beyond-UI-CustomUIStyle-_OnActiveTypeChanged0 = 210,
		Beyond-UI-CustomUIStyle-get_isValid0 = 211,
		Beyond-UI-CustomUIStyle-IsShowTypeValid0 = 212,
		Beyond-UI-CustomUIStyle-OnDestroy0 = 213,
		Beyond-UI-CustomUIStyle-CheckState0 = 214,
		Beyond-UI-CustomUIStyle-ToggleActiveState0 = 215,
		Beyond-UI-CustomUIStyle-OnEnable0 = 216,
		Beyond-UI-CustomUIStyle-Awake0 = 217,
		Beyond-UI-CustomUIStyle-IsValidInput0 = 218,
		Beyond-UI-DeactivateNaviOnEnable-OnEnable0 = 219,
		Beyond-UI-DeactivateNaviOnEnable-OnDisable0 = 220,
		Beyond-UI-DecoLineActiveHelper-Reset0 = 221,
		Beyond-UI-DecoLineActiveHelper-OnEnable0 = 222,
		Beyond-UI-DecoLineActiveHelper-LateTick0 = 223,
		Beyond-UI-DecoLineActiveHelper-_HasActiveTarget0 = 224,
		Beyond-UI-Empty4Raycast-OnPopulateMesh0 = 225,
		Beyond-UI-FitAspectRatioByFOV-get_maxFov0 = 226,
		Beyond-UI-FitAspectRatioByFOV-Start0 = 227,
		Beyond-UI-FitAspectRatioByFOV-_AdjustFOV0 = 228,
		Beyond-UI-FitAspectRatioByFOV-OnEnable0 = 229,
		Beyond-UI-FitAspectRatioByFOV-OnDisable0 = 230,
		Beyond-UI-FitAspectRatioByFOV-OnScreenSizeChanged0 = 231,
		Beyond-UI-FixRotation-LateTick0 = 232,
		Beyond-UI-FullScreenSceneBlurMarker-_GetNextId0 = 233,
		Beyond-UI-FullScreenSceneBlurMarker-Awake0 = 234,
		Beyond-UI-FullScreenSceneBlurMarker-OnEnable0 = 236,
		Beyond-UI-FullScreenSceneBlurMarker-OnDisable0 = 238,
		Beyond-UI-FullScreenSceneBlurMarker-OnDestroy0 = 239,
		Beyond-UI-InputBindingGroupNaviDecorator-_SetSelfEnabledStateIfNecessary0 = 240,
		Beyond-UI-InputBindingGroupNaviDecorator-Awake0 = 241,
		Beyond-UI-InputBindingGroupNaviDecorator-OnEnable0 = 242,
		Beyond-UI-InputBindingGroupNaviDecorator-OnDestroy0 = 243,
		Beyond-UI-InputBindingGroupNaviDecorator-ClearComponent0 = 244,
		Beyond-UI-InputBindingGroupNaviDecorator-_OnSetAsNaviTarget0 = 245,
		Beyond-UI-LuaPanel-Awake0 = 246,
		Beyond-UI-LuaPanel-_TrySetRot0 = 249,
		Beyond-UI-LuaPanel-AddSortingOrderComp0 = 250,
		Beyond-UI-LuaPanel-RemoveSortingOrderComp0 = 251,
		Beyond-UI-LuaPanel-Start0 = 252,
		Beyond-UI-LuaPanel-OnEnable0 = 253,
		Beyond-UI-LuaPanel-BlockAllInput0 = 254,
		Beyond-UI-LuaPanel-_AutoAnimationInFinish0 = 255,
		Beyond-UI-LuaPanel-OnDisable0 = 262,
		Beyond-UI-LuaPanel-OnDestroy0 = 263,
		Beyond-UI-LuaPanel-ClearComponent0 = 264,
		Beyond-UI-MouseHoverTipsPosHelper-get_panel0 = 265,
		Beyond-UI-MouseHoverTipsPosHelper-OnAwake0 = 266,
		Beyond-UI-MouseHoverTipsPosHelper-OnEnable0 = 267,
		Beyond-UI-MouseHoverTipsPosHelper-UpdatePosition0 = 268,
		Beyond-UI-MouseHoverTipsPosHelper-LateTick0 = 270,
		Beyond-UI-NaviToThisGroupOnEnable-Reset0 = 271,
		Beyond-UI-NaviToThisGroupOnEnable-Awake0 = 272,
		Beyond-UI-NaviToThisGroupOnEnable-OnEnable0 = 273,
		Beyond-UI-UISelectableNaviGroup-NaviToThisGroup0 = 274,
		Beyond-UI-UISelectableNaviGroup-_FindDefaultSelectable0 = 275,
		Beyond-UI-NonDrawingGraphic-get_Radius0 = 276,
		Beyond-UI-NonDrawingGraphic-SetMaterialDirty0 = 277,
		Beyond-UI-NonDrawingGraphic-SetVerticesDirty0 = 278,
		Beyond-UI-NonDrawingGraphic-OnPopulateMesh0 = 279,
		Beyond-UI-NonDrawingGraphic-IsRaycastLocationValid0 = 280,
		Beyond-UI-NonDrawingGraphic-_IsRaycastLocationValidCircle0 = 281,
		Beyond-UI-NotchAdapter-Awake0 = 282,
		Beyond-UI-NotchAdapter-_UpdateMargeSizeFromNotchInfo0 = 283,
		Beyond-UI-NotchAdapter-_OnCanvasChanged0 = 284,
		Beyond-UI-NotchAdapter-ApplyNewNotch0 = 285,
		Beyond-UI-NotchAdapter-ApplyNotch0 = 286,
		Beyond-UI-NotchAdapter-ClearNullRef0 = 287,
		Beyond-UI-NotchAdapter-FindAllSideUI0 = 288,
		Beyond-UI-NotchAdapter-ClearList0 = 289,
		Beyond-UI-NotchAdapter-_TraverseUI0 = 290,
		Beyond-UI-NotchAdapter-_TryAddToSideUI0 = 291,
		Beyond-UI-NotchAdapter-OnDestroy0 = 292,
		Beyond-UI-NotchAdapter-ApplyNotch1 = 293,
		Beyond-UI-NotchAdapter-UnApplyNotch0 = 294,
		Beyond-UI-ParallaxHelper-InitConfigs0 = 295,
		Beyond-UI-ParallaxHelper-ResetValue0 = 296,
		Beyond-UI-ParallaxHelper-RefreshPos0 = 297,
		Beyond-UI-PercentNumberTweener-Reset0 = 298,
		Beyond-UI-PercentNumberTweener-OnEnable0 = 299,
		Beyond-UI-PercentNumberTweener-LateTick0 = 300,
		Beyond-UI-UIRecycleLayoutAdapter-Init0 = 301,
		Beyond-UI-UIRecycleLayoutAdapter-GenerateViewsForRebuild0 = 303,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-AttachView0 = 304,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-DetachView0 = 305,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetAttachedView0 = 306,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetViewID0 = 307,
		Beyond-UI-UIRecycleLayoutGroup-get_adapter0 = 308,
		Beyond-UI-UIRecycleLayoutGroup-get_viewMgr0 = 309,
		Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputHorizontal0 = 310,
		Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputVertical0 = 311,
		Beyond-UI-UIRecycleLayoutGroup-get_paddingFront0 = 312,
		Beyond-UI-UIRecycleLayoutGroup-get_paddingBack0 = 313,
		Beyond-UI-UIRecycleLayoutGroup-_ApplyLayoutMeta0 = 314,
		Beyond-UI-UIRecycleLayoutGroup-_GetVisibleRange0 = 315,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsFromMeta0 = 316,
		Beyond-UI-UIRecycleLayoutGroup-SetAdapter0 = 318,
		Beyond-UI-UIRecycleLayoutGroup-_RebuildAllViews0 = 319,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RebuildAll0 = 320,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-RecycleAll0 = 321,
		Beyond-UI-UIRecycleLayoutGroup-_UpdateViews0 = 322,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViews0 = 323,
		Beyond-UI-UIRecycleLayoutGroup-ClearComponent0 = 325,
		Beyond-UI-UIRecycleLayoutGroup-LateTick0 = 326,
		Beyond-UI-UIRecycleLayoutGroup-OnLateTick0 = 327,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-DetachView0 = 328,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_EnsureViewPool0 = 329,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-Recycle0 = 330,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AttachView0 = 331,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-Alloc0 = 332,
		Beyond-UI-UIRecycleLayoutGroup-_InsertView0 = 333,
		Beyond-UI-UIRecycleLayoutGroup-_RemoveView0 = 334,
		Beyond-UI-UIRecycleLayoutGroup-_UpdateViewsFrom0 = 335,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementPosByIndex0 = 336,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetView0 = 337,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsByIndex0 = 338,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementIndex0 = 339,
		Beyond-UI-UIRecycleLayoutGroup-_RefreshLayout0 = 340,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewCount0 = 341,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-InsertView0 = 342,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AddView0 = 343,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RemoveView0 = 344,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyViewSizeChanged0 = 345,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyAllViewSizeChanged0 = 346,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyRebuild0 = 347,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementPosByIndex0 = 348,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementBoundsByIndex0 = 349,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetDirection0 = 350,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetSizeOnAxis0 = 351,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewportSizeOnAxis0 = 352,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementIndex0 = 353,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_NotifyLayoutChanged0 = 354,
		Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-GenerateViewsForRebuild0 = 355,
		Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-OnInit0 = 356,
		Beyond-UI-UIRecycleMultiHolder-GetVirtualView0 = 357,
		Beyond-UI-UIRecycleMultiHolder-UpdateCount1 = 358,
		Beyond-UI-UIRecycleMultiHolder-UpdateCount0 = 359,
		Beyond-UI-UIRecycleMultiHolder-InsertView0 = 360,
		Beyond-UI-UIRecycleMultiHolder-AddView0 = 361,
		Beyond-UI-UIRecycleMultiHolder-OnAdapterInit0 = 362,
		Beyond-UI-UIRecycleMultiHolder-ClearComponent0 = 363,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetIndex0 = 364,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPrefab0 = 366,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPreferSize0 = 367,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewDetached0 = 368,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewAttached0 = 369,
		Beyond-UI-UIRecycleSingleHolder-GetVirtualView0 = 370,
		Beyond-UI-UIRecycleSingleHolder-UpdateCount1 = 371,
		Beyond-UI-UIRecycleSingleHolder-UpdateCount0 = 372,
		Beyond-UI-UIRecycleSingleHolder-InsertView0 = 373,
		Beyond-UI-UIRecycleSingleHolder-AddView0 = 374,
		Beyond-UI-UIRecycleSingleHolder-OnAdapterInit0 = 375,
		Beyond-UI-UIRecycleSingleHolder-ClearComponent0 = 376,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetIndex0 = 377,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPrefab0 = 378,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPreferSize0 = 379,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewDetached0 = 380,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewAttached0 = 381,
		Beyond-UI-SimpleUITextSingleLine-GenerateTextMesh0 = 382,
		Beyond-UI-ToastList-Awake0 = 383,
		Beyond-UI-ToastList-OnDisable0 = 385,
		Beyond-UI-ToastList-ClearAllToast0 = 386,
		Beyond-UI-ToastList-_CacheCell0 = 388,
		Beyond-UI-ToastList-_GetCell0 = 389,
		Beyond-UI-ToastList-AddToast0 = 390,
		Beyond-UI-ToastList-_StartBatch0 = 391,
		Beyond-UI-ToastList-_ShowCell0 = 392,
		Beyond-UI-UIAnimationWrapper-PlayOutAnimation0 = 396,
		Beyond-UI-UIAnimationWrapper-PlayCloseAudio0 = 399,
		Beyond-UI-ToastList-_TryShowNewCell0 = 400,
		Beyond-UI-UIAnimationWrapper-GetOutClipLength0 = 401,
		Beyond-UI-ToastList-_OnCellFinished0 = 402,
		Beyond-UI-ToastList-ClearComponent0 = 406,
		Beyond-UI-UI3DScrollList-MoveCellTo0 = 407,
		Beyond-UI-UIActionKeyHint-_TryInit0 = 408,
		Beyond-UI-UIActionKeyHint-_OnControllerTypeChange0 = 409,
		Beyond-UI-UIActionKeyHint-_RefreshAllKeyHints0 = 410,
		Beyond-UI-UIActionKeyHint-UpdateKeyHint0 = 411,
		Beyond-UI-UIActionKeyHint-SetSecondActionId0 = 412,
		Beyond-UI-UIActionKeyHint-_SetSecondIcon0 = 413,
		Beyond-UI-UIActionKeyHint-GetAndSetActionIcon0 = 414,
		Beyond-UI-UIActionKeyHint-_SetKeyCodeSprite0 = 415,
		Beyond-UI-UIImage-LoadSpriteWithOutFormat0 = 416,
		Beyond-UI-UIImage-_LoadSprite0 = 417,
		Beyond-UI-UIImage-DisposeSpriteHandle0 = 418,
		Beyond-UI-UIActionKeyHint-GetActionInfo0 = 419,
		Beyond-UI-UIActionKeyHint-GetActionId0 = 420,
		Beyond-UI-UIActionKeyHint-SetContentState0 = 421,
		Beyond-UI-UIActionKeyHint-GetAndSetActionModifyIcon0 = 422,
		Beyond-UI-UIActionKeyHint-GetTextStr0 = 423,
		Beyond-UI-UIActionKeyHint-_CheckInteractable0 = 424,
		Beyond-UI-UIActionKeyHint-_IsInputGray0 = 426,
		Beyond-UI-UIActionKeyHint-_IsInputEnabled0 = 427,
		Beyond-UI-UIActionKeyHint-_OnInputLateTickAll0 = 428,
		Beyond-UI-UIActionKeyHint-Awake0 = 429,
		Beyond-UI-UIActionKeyHint-OnEnable0 = 430,
		Beyond-UI-UIActionKeyHint-_OnInputActionKeyUpdated0 = 431,
		Beyond-UI-UIActionKeyHint-OnDisable0 = 432,
		Beyond-UI-UIActionKeyHint-OnDestroy0 = 433,
		Beyond-UI-UIActionKeyHint-ClearComponent0 = 434,
		Beyond-UI-UIActionKeyHint-Reset0 = 435,
		Beyond-UI-UIActionKeyHint-SetActionId0 = 436,
		Beyond-UI-UIActionKeyHint-SetKeyHint0 = 437,
		Beyond-UI-UIActionKeyHint-_OnChangeTarget0 = 438,
		Beyond-UI-UIActionKeyHint-SetBindingId0 = 439,
		Beyond-UI-UIActionKeyHint-SetBindingId1 = 440,
		Beyond-UI-UIActionKeyHint-SetText0 = 441,
		Beyond-UI-UIAnimationHolder-FindByName0 = 442,
		Beyond-UI-UIAnimationHolder-_FindByString0 = 443,
		Beyond-UI-UIAnimationHolder-FindByNameOrAlias0 = 444,
		Beyond-UI-UIAnimationHolder-GetAnimationClips0 = 445,
		Beyond-UI-UIAnimationLoopSynchronizer-RegisterChild0 = 446,
		Beyond-UI-UIAnimationLoopSynchronizer-UnregisterChild0 = 447,
		Beyond-UI-UIAnimationWrapper-SetOptions0 = 448,
		Beyond-UI-UIAnimationWrapper-_AnimationInLoopCheck0 = 449,
		Beyond-UI-UIAnimationWrapper-_AnimationAutomaticallyCheck0 = 450,
		Beyond-UI-UIAnimationWrapper-Awake0 = 451,
		Beyond-UI-UIAnimationWrapper-IsStarted0 = 452,
		Beyond-UI-UIAnimationWrapper-SetAnimationInClip0 = 453,
		Beyond-UI-UIAnimationWrapper-SetAnimationInEasingClip0 = 454,
		Beyond-UI-UIAnimationWrapper-SetAnimationLoopClip0 = 455,
		Beyond-UI-UIAnimationWrapper-SetAnimationOutClip0 = 456,
		Beyond-UI-UIAnimationWrapper-GetInClipLength0 = 457,
		Beyond-UI-UIAnimationWrapper-GetLoopClipLength0 = 458,
		Beyond-UI-UIAnimationWrapper-SkipInAnimation0 = 459,
		Beyond-UI-UIAnimationWrapper-SampleToInAnimationBegin0 = 460,
		Beyond-UI-UIAnimationWrapper-SampleToInAnimationEnd0 = 461,
		Beyond-UI-UIAnimationWrapper-SampleToOutAnimationBegin0 = 462,
		Beyond-UI-UIAnimationWrapper-SampleToOutAnimationEnd0 = 463,
		Beyond-UI-UIAnimationWrapper-GetClipLength0 = 464,
		Beyond-UI-UIAnimationWrapper-AnimationRuntime-GetClipLength0 = 465,
		Beyond-UI-UIAnimationWrapper-SampleClipAtPercent0 = 466,
		Beyond-UI-UIAnimationWrapper-_CheckShouldAutoPlayAnimationIn0 = 467,
		Beyond-UI-UIAnimationWrapper-Start0 = 468,
		Beyond-UI-UIAnimationWrapper-OnEnable0 = 469,
		Beyond-UI-UIAnimationWrapper-OnDisable0 = 470,
		Beyond-UI-UIAnimationWrapper-OnDestroy0 = 471,
		Beyond-UI-UIAnimationWrapper-ClearComponent0 = 472,
		Beyond-UI-UIAnimationWrapper-CheckStopped0 = 473,
		Beyond-UI-UIAnimationWrapper-Play0 = 474,
		Beyond-UI-UIAnimationWrapper-Play1 = 475,
		Beyond-UI-UIAnimationWrapper-GetCurPlayingTime0 = 476,
		Beyond-UI-UIAnimationTween-GetValue0 = 477,
		Beyond-UI-UIAnimationWrapper-SetAudioOnOpen0 = 478,
		Beyond-UI-UIAnimationWrapper-FOptions-GetDefault0 = 479,
		Beyond-UI-UIAnimationTween-_SetValue0 = 480,
		Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfHide0 = 481,
		Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfShow0 = 482,
		Beyond-UI-UIAnimationSwitchTween-BeforeShowEffect0 = 483,
		Beyond-UI-UIAnimationSwitchTween-_SetGameObjectActive0 = 484,
		Beyond-UI-UIAnimationSwitchTween-AfterHideEffect0 = 485,
		Beyond-UI-UIAnimationSwitchTween-ResetToState0 = 486,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-IsPlaying0 = 487,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-KillIfNecessary0 = 488,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-OnComplete0 = 489,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-SetAutoKill0 = 490,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-_OnComplete0 = 491,
		Beyond-UI-UIAnimationSwitchTween-Builder-Build0 = 492,
		Beyond-UI-UIArea-_SetHighlightNodeActive0 = 493,
		Beyond-UI-UIArea-OnPointerEnter0 = 494,
		Beyond-UI-UIArea-OnPointerExit0 = 495,
		Beyond-UI-UIArea-OnEnable0 = 496,
		Beyond-UI-UIArea-OnDisable0 = 497,
		Beyond-UI-UIArea-OnDestroy0 = 498,
		Beyond-UI-UIArea-ClearComponent0 = 499,
		Beyond-UI-UIAutoCloseArea-set_includeInAutoCloseLayer0 = 500,
		Beyond-UI-UIAutoCloseArea-AddToAutoCloseLayer0 = 501,
		Beyond-UI-UIAutoCloseArea-RemoveFromAutoCloseLayer0 = 502,
		Beyond-UI-UIAutoCloseArea-get_panel0 = 503,
		Beyond-UI-UIAutoCloseArea-Start0 = 504,
		Beyond-UI-UIAutoCloseArea-InitBinding0 = 505,
		Beyond-UI-UIAutoCloseArea-TryCloseSelf0 = 508,
		Beyond-UI-UIAutoCloseArea-CloseSelf0 = 509,
		Beyond-UI-UIAutoCloseArea-_AutoCloseToggleObjWhenOut0 = 510,
		Beyond-UI-UIAutoCloseArea-_UpdateState0 = 512,
		Beyond-UI-UIAutoCloseArea-Reset0 = 513,
		Beyond-UI-UIAutoCloseArea-LateTick0 = 514,
		Beyond-UI-UIAutoCloseArea-ShouldClose0 = 515,
		Beyond-UI-UIAutoCloseArea-_GetUICamera0 = 516,
		Beyond-UI-UIAutoCloseArea-IsTopAutoCloseLayer0 = 517,
		Beyond-UI-UIAutoCloseArea-OnEnable0 = 518,
		Beyond-UI-UIAutoCloseArea-OnDisable0 = 519,
		Beyond-UI-UIAutoCloseArea-ChangeEnableCloseActionOnController0 = 520,
		Beyond-UI-UIAutoCloseArea-OpenSelf0 = 521,
		Beyond-UI-UIAutoCloseArea-ClearComponent0 = 522,
		Beyond-UI-UIAutoCloseArea-OnDestroy0 = 523,
		Beyond-UI-UIBigLogo-SetBigLogoEditor0 = 524,
		Beyond-UI-UIBigLogo-ShowBigLogo0 = 525,
		Beyond-UI-UIBigLogo-SetBigLogoMask0 = 526,
		Beyond-UI-UIBigLogo-ClearBigLogoMask0 = 527,
		Beyond-UI-UIBigLogo-ClearBigLogo0 = 528,
		Beyond-UI-UIBigLogo-SetAlpha0 = 529,
		Beyond-UI-UIBigLogo-SetMaskAlpha0 = 530,
		Beyond-UI-UIBigRectButton-OnPointerDown0 = 531,
		Beyond-UI-UIButton-OnPointerDown0 = 532,
		Beyond-UI-UIButton-_StopLongPressCor0 = 533,
		Beyond-UI-UIButton-_PlayClickAnimation0 = 534,
		Beyond-UI-UIButton-_DoClickAnimation0 = 535,
		Beyond-UI-UIButton-_OnPress0 = 542,
		Beyond-UI-UIBigRectButton-OnPointerUp0 = 552,
		Beyond-UI-UIButton-OnPointerUp0 = 553,
		Beyond-UI-UIBigRectButton-OnDrag0 = 554,
		Beyond-UI-UIBigRectButton-OnBeginDrag0 = 555,
		Beyond-UI-UIBigRectButton-OnEndDrag0 = 556,
		Beyond-UI-UIBigRectButton-OnScroll0 = 557,
		Beyond-UI-UIBigRectHelper-get_zoomEvent0 = 558,
		Beyond-UI-UIBigRectHelper-OnAwake0 = 559,
		Beyond-UI-UIBigRectHelper-_OnDrag0 = 561,
		Beyond-UI-UIBigRectHelper-_GetAdjustedPosition0 = 562,
		Beyond-UI-UIBigRectHelper-_GetContainerRectBounds0 = 563,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPosition1 = 565,
		Beyond-UI-UIBigRectHelper-ResetPivotPositionToScreenCenter0 = 566,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPosition0 = 567,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPositionToMousePosition0 = 568,
		Beyond-UI-UIBigRectHelper-_OnZoom0 = 569,
		Beyond-UI-UIBigRectHelper-_SetZoomValueAndScale0 = 570,
		Beyond-UI-UIBigRectHelper-_SetScale0 = 571,
		Beyond-UI-UIBigRectHelper-_UpdatePositionOffsetAfterZoomed0 = 573,
		Beyond-UI-UIBigRectHelper-_PosAdjust0 = 574,
		Beyond-UI-UIBigRectHelper-_InitControllerBindings0 = 575,
		Beyond-UI-UIBigRectHelper-_OnControllerClick0 = 576,
		Beyond-UI-UIBigRectHelper-_RefreshControllerFocusRaycastResults0 = 577,
		Beyond-UI-UIBigRectHelper-Tick0 = 580,
		Beyond-UI-UIBigRectHelper-_TickRefreshController0 = 581,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickMove0 = 582,
		Beyond-UI-UIBigRectHelper-_GetIsControllerMoveEnabled0 = 583,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickZoom0 = 585,
		Beyond-UI-UIBigRectHelper-_GetIsControllerZoomEnabled0 = 586,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerZoomKeyHint0 = 588,
		Beyond-UI-UIBigRectHelper-LateTick0 = 589,
		Beyond-UI-UIBigRectHelper-_TickCheckControllerFocusRaycastTargets0 = 590,
		Beyond-UI-UIBigRectHelper-OnRelease0 = 591,
		Beyond-UI-UIBigRectHelper-ManuallyZoom0 = 592,
		Beyond-UI-UIBigRectHelper-_TryAlignWhenInit0 = 593,
		Beyond-UI-UIBigRectHelper-Init0 = 594,
		Beyond-UI-UIBigRectHelper-_ResetControllerState0 = 596,
		Beyond-UI-UIBigRectHelper-FocusNode0 = 597,
		Beyond-UI-UIBigRectHelper-FocusNode1 = 598,
		Beyond-UI-UIBigRectHelper-ZoomToFullRect0 = 601,
		Beyond-UI-UIBigRectHelper-ChangePaddingRight0 = 602,
		Beyond-UI-UIBigRectHelper-SetZoomRangeMax0 = 603,
		Beyond-UI-UIBigRectHelper-OverrideZoomRangeMin0 = 604,
		Beyond-UI-UIBigRectHelper-SyncZoomValue0 = 605,
		Beyond-UI-UIBigRectHelper-GetRecoverState0 = 606,
		Beyond-UI-UIBigRectHelper-GetZoomRange0 = 607,
		Beyond-UI-UIBigRectHelper-GetCurrentZoomValue0 = 608,
		Beyond-UI-UIBigRectHelper-ChangePivotPositionToTarget0 = 609,
		Beyond-UI-UIBigRectHelper-RecoverContainerState0 = 610,
		Beyond-UI-UIBigRectHelper-ClearAllTween0 = 611,
		Beyond-UI-UIBigRectHelper-ClearComponent0 = 612,
		Beyond-UI-UIBlendImage-SetMaterialKey0 = 613,
		Beyond-UI-UIBlendImage-SetColor0 = 614,
		Beyond-UI-UIBlendImage-SetTexture0 = 615,
		Beyond-UI-UIBlendImage-ClearMaterialCache0 = 616,
		Beyond-UI-UIBlurMono-get_canvas0 = 617,
		Beyond-UI-UIBlurMono-get_panel0 = 618,
		Beyond-UI-UIBlurMono-OnEnable0 = 619,
		Beyond-UI-UIBlurMono-_GetCamera0 = 620,
		Beyond-UI-UIBlurMono-OnDisable0 = 621,
		Beyond-UI-UIBlurMono-Tick0 = 622,
		Beyond-UI-UIBlurMono-UpdateSortingOrder0 = 623,
		Beyond-UI-UIBlurRT-Reset0 = 624,
		Beyond-UI-UIBlurRT-InitRT0 = 625,
		Beyond-UI-UIBlurRT-Register0 = 627,
		Beyond-UI-UIBlurRT-SetUseSceneColorPS0 = 629,
		Beyond-UI-UIBlurRT-UnRegister0 = 630,
		Beyond-UI-UIBlurRT-UpdateRT0 = 631,
		Beyond-UI-UIBlurRT-OnEnable0 = 632,
		Beyond-UI-UIBlurRT-OnDisable0 = 633,
		Beyond-UI-UIBlurRT-_Clear0 = 634,
		Beyond-UI-UIBlurRT-OnDestroy0 = 635,
		Beyond-UI-UIBlurRT-SetCustomBlurImg0 = 636,
		Beyond-UI-UIButton-Awake0 = 638,
		Beyond-UI-UIButton-InitBinding0 = 639,
		Beyond-UI-UIButton-_UpdateState0 = 642,
		Beyond-UI-UIButton-OnPointerClick0 = 644,
		Beyond-UI-UIButton-_Press0 = 645,
		Beyond-UI-UIButton-get_panel0 = 647,
		Beyond-UI-UIButton-_OnUpdateKey0 = 648,
		Beyond-UI-UIButton-_InitActionOnSetNaviTarget0 = 654,
		Beyond-UI-UIButton-OnEnable0 = 658,
		Beyond-UI-UIButton-OnDisable0 = 659,
		Beyond-UI-UIButton-OnDestroy0 = 660,
		Beyond-UI-UIButton-ClearComponent0 = 661,
		Beyond-UI-UIButton-_NotifyIsHover0 = 662,
		Beyond-UI-UIButton-set_text0 = 663,
		Beyond-UI-UIButton-OnInteractableChanged0 = 664,
		Beyond-UI-UIButton-get_bindingViewActionId0 = 665,
		Beyond-UI-UIButton-_GetUIButtonKeyHintActionId0 = 666,
		Beyond-UI-UIButton-set_customBindingViewLabelText0 = 667,
		Beyond-UI-UIButton-get_hintText0 = 668,
		Beyond-UI-UIButton-get_bindingViewState0 = 669,
		Beyond-UI-UIButton-GetBindingViewActionId0 = 670,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyDown0 = 671,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyUp0 = 672,
		Beyond-UI-UIButton-_RefreshHoverEnableNode0 = 673,
		Beyond-UI-UIButton-GetMouseActionHints0 = 674,
		Beyond-UI-UIButton-OnNaviTargetEnabledAgain0 = 675,
		Beyond-UI-UIButton-_OnSetAsNaviTarget0 = 676,
		Beyond-UI-UIButton-_ToggleNaviInputBinding0 = 677,
		Beyond-UI-UIButton-ChangeActionOnSetNaviTarget0 = 678,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.get_interactable0 = 679,
		Beyond-UI-UICanvasScaleHelper-get_standardHorizontalResolution0 = 680,
		Beyond-UI-UICanvasScaleHelper-get_standardVerticalResolution0 = 681,
		Beyond-UI-UICanvasScaleHelper-get_canvasScalerList0 = 682,
		Beyond-UI-UICanvasScaleHelper-Awake0 = 683,
		Beyond-UI-UICanvasScaleHelper-_OnInit0 = 684,
		Beyond-UI-UICanvasScaleHelper-GetProperCanvasResolution0 = 685,
		Beyond-UI-UICanvasScaleHelper-Start0 = 686,
		Beyond-UI-UICanvasScaleHelper-_OnInputTypeChanged0 = 687,
		Beyond-UI-UICanvasScaleHelper-_CanvasOnWillRenderCanvases0 = 688,
		Beyond-UI-UICanvasScaleHelper-OnDestroy0 = 689,
		Beyond-UI-UICanvasScaleHelper-ClearComponent0 = 690,
		Beyond-UI-UICanvasScaleHelper-UpdateCanvas0 = 691,
		Beyond-UI-UICanvasScaleHelper-CalcWorldCanvasParams0 = 692,
		Beyond-UI-UICanvasScaleHelper-CalcCurrentScreenRatio0 = 693,
		Beyond-UI-UICanvasScaleHelper-CalcScreenCanvasParams0 = 694,
		Beyond-UI-UICanvasScaleHelper-OnScreenSizeChanged0 = 695,
		Beyond-UI-UICanvasScaleHelper-AddCanvas0 = 696,
		Beyond-UI-UICanvasScaleHelper-RemoveCanvas0 = 697,
		Beyond-UI-UICanvasScaleHelper-ForceCanvasUpdate0 = 698,
		Beyond-UI-UIColorGroup-set_color0 = 699,
		Beyond-UI-UIColorGroup-_SetColor0 = 700,
		Beyond-UI-UIColorGroup-_ApplyOptToGraphics0 = 701,
		Beyond-UI-UIColorGroup-AttachGraphic0 = 702,
		Beyond-UI-UIColorGroup-AttachGraphicsWithGroup0 = 703,
		Beyond-UI-UIColorGroup-CrossFadeAlpha0 = 704,
		Beyond-UI-UIColorGroup-_CrossFadeAlpha0 = 705,
		Beyond-UI-UIColorGroup-CrossFadeColor0 = 706,
		Beyond-UI-UIColorGroup-_CrossFadeColorRGB0 = 707,
		Beyond-UI-UIColorGroup-CrossFadeColor1 = 708,
		Beyond-UI-UIColorGroup-_CrossFadeColorAlpha0 = 709,
		Beyond-UI-UIControllerKeyIcon-_TryStaticInit0 = 710,
		Beyond-UI-UIControllerKeyIcon-_OnControllerTypeChange0 = 711,
		Beyond-UI-UIControllerKeyIcon-RefreshKeyIcon0 = 712,
		Beyond-UI-UIControllerKeyIcon-Awake0 = 713,
		Beyond-UI-UIControllerKeyIcon-OnEnable0 = 714,
		Beyond-UI-UIControllerKeyIcon-OnDisable0 = 715,
		Beyond-UI-UIControllerKeyIcon-SetKeyIconName0 = 716,
		Beyond-UI-UICustomLayout-Awake0 = 717,
		Beyond-UI-UICustomLayout-IsDirty0 = 718,
		Beyond-UI-UICustomLayoutHandle-IsDirty0 = 719,
		Beyond-UI-UICustomLayout-ResetToDefault0 = 720,
		Beyond-UI-UICustomLayoutHandle-ResetToDefault0 = 721,
		Beyond-UI-UICustomLayoutHandle-_SetChanged0 = 722,
		Beyond-UI-UICustomLayoutHandle-get_Element0 = 723,
		Beyond-UI-UICustomLayoutElement-ResetToDefault0 = 724,
		Beyond-UI-UICustomLayoutElement-_GetMarginSize0 = 725,
		Beyond-UI-UICustomLayoutElement-get_panel0 = 726,
		Beyond-UI-UICustomLayoutElement-_ApplyScale0 = 727,
		Beyond-UI-UICustomLayoutElement-_ApplyAlpha0 = 728,
		Beyond-UI-UICustomLayoutElement-_ApplyPosition0 = 729,
		Beyond-UI-UICustomLayout-Save0 = 730,
		Beyond-UI-UICustomLayoutHandle-Save0 = 731,
		Beyond-UI-UICustomLayoutElement-SaveData0 = 732,
		Beyond-UI-UICustomLayoutElement-_CheckElementKeyIsValid0 = 733,
		Beyond-UI-UICustomLayoutElement-GetElementKeyWithRatio0 = 734,
		Beyond-UI-UICustomLayout-_LogEvent0 = 735,
		Beyond-UI-UICustomLayoutElement-get_highlightRect0 = 736,
		Beyond-UI-UICustomLayoutElement-Awake0 = 737,
		Beyond-UI-UICustomLayoutElement-_SetDefaultValues0 = 738,
		Beyond-UI-UICustomLayoutElement-_OnHudLayoutSaved0 = 739,
		Beyond-UI-UICustomLayoutElement-LoadData0 = 740,
		Beyond-UI-UICustomLayoutElement-Start0 = 741,
		Beyond-UI-UICustomLayoutElement-OnDestroy0 = 742,
		Beyond-UI-UICustomLayoutElement-ClearComponent0 = 743,
		Beyond-UI-UICustomLayoutElement-RefreshAll0 = 744,
		Beyond-UI-UICustomLayoutHandle-set_scale0 = 745,
		Beyond-UI-UICustomLayoutHandle-_ApplyScale0 = 746,
		Beyond-UI-UICustomLayoutHandle-set_position0 = 747,
		Beyond-UI-UICustomLayoutHandle-_CalculatePositionRange0 = 748,
		Beyond-UI-UICustomLayoutHandle-_ApplyPosition0 = 749,
		Beyond-UI-UICustomLayoutHandle-set_alpha0 = 750,
		Beyond-UI-UICustomLayoutHandle-_ApplyAlpha0 = 751,
		Beyond-UI-UICustomLayoutHandle-set_layoutType0 = 752,
		Beyond-UI-UICustomLayoutHandle-_ApplyLayoutType0 = 753,
		Beyond-UI-UICustomLayoutHandle-get_panel0 = 754,
		Beyond-UI-UICustomLayoutHandle-Awake0 = 755,
		Beyond-UI-UICustomLayoutHandle-_OnElementDataLoaded0 = 756,
		Beyond-UI-UICustomLayoutHandle-_OnSystemDisplaySizeChanged0 = 757,
		Beyond-UI-UICustomLayoutHandle-OnDestroy0 = 758,
		Beyond-UI-UICustomLayoutHandle-OnBeginDrag0 = 759,
		Beyond-UI-UICustomLayoutHandle-OnDrag0 = 760,
		Beyond-UI-UICustomLayoutHandle-OnEndDrag0 = 761,
		Beyond-UI-UICustomLayoutHandle-OnPointerClick0 = 762,
		Beyond-UI-UICustomLayoutHandle-ClearComponent0 = 763,
		Beyond-UI-UIDialogText-get_playing0 = 764,
		Beyond-UI-UIDialogText-OnAwake0 = 765,
		Beyond-UI-UIDialogText-ResetPlay0 = 766,
		Beyond-UI-UIDialogText-Start0 = 767,
		Beyond-UI-UIDialogText-SetText0 = 768,
		Beyond-UI-UIDialogText-_RefreshPosY0 = 769,
		Beyond-UI-UIDialogText-RefreshAutoScrollData0 = 770,
		Beyond-UI-UIDialogText-Play0 = 771,
		Beyond-UI-UIDialogText-OnDisable0 = 772,
		Beyond-UI-UIDialogText-OnEnable0 = 773,
		Beyond-UI-UIDialogText-RefreshText0 = 774,
		Beyond-UI-UIDialogText-Tick0 = 775,
		Beyond-UI-UIDialogText-_UpdateTextAuto0 = 776,
		Beyond-UI-UIDialogText-OnVisibleCharactersChanged0 = 777,
		Beyond-UI-UIDialogText-StopPlay0 = 778,
		Beyond-UI-UIDialogText-_TryAutoScroll0 = 779,
		Beyond-UI-UIDialogText-GetAutoWaitTime0 = 780,
		Beyond-UI-UIDialogText-GetScrollSpeed0 = 781,
		Beyond-UI-UIDialogText-SeekToEnd0 = 782,
		Beyond-UI-UIDialogText-ManualUpdateByPercent0 = 783,
		Beyond-UI-UIDialogText-ManualUpdateByTime0 = 784,
		Beyond-UI-UIDialogText-GetDisplayAllCharactersTime0 = 785,
		Beyond-UI-UIDialogTextWithCursor-ResetPlay0 = 786,
		Beyond-UI-UIDialogTextWithCursor-OnVisibleCharactersChanged0 = 787,
		Beyond-UI-UIDialogTextWithCursor-GetDisplayAllCharactersTime0 = 788,
		Beyond-UI-UIDialogTimelineText-get_canvasGroup0 = 789,
		Beyond-UI-UIDialogTimelineText-UpdateAlpha0 = 790,
		Beyond-UI-UIDialogTimelineText-SetRadioIcon0 = 791,
		Beyond-UI-UIImage-LoadSprite0 = 792,
		Beyond-UI-UIDialogTimelineText-_ClearRadioIcon0 = 793,
		Beyond-UI-UIDrag-Awake0 = 795,
		Beyond-UI-UIDrag-OnDrag0 = 796,
		Beyond-UI-UIDrag-OnBeginDrag0 = 797,
		Beyond-UI-UIDrag-OnEndDrag0 = 798,
		Beyond-UI-UIDrag-ApplyDragArea0 = 799,
		Beyond-UI-UIDrag-ClearComponent0 = 800,
		Beyond-UI-UIDragHandler-ClearComponent0 = 801,
		Beyond-UI-UIDragHandler-OnPointerDown0 = 802,
		Beyond-UI-UIDragHandler-OnBeginDrag0 = 803,
		Beyond-UI-UIDragHandler-OnDrag0 = 804,
		Beyond-UI-UIDragHandler-OnEndDrag0 = 805,
		Beyond-UI-UIDragItem-get_panel0 = 806,
		Beyond-UI-UIDragItem-get_m_dragParentRect0 = 807,
		Beyond-UI-UIDragItem-Awake0 = 808,
		Beyond-UI-UIDragItem-Start0 = 809,
		Beyond-UI-UIDragItem-OnDisable0 = 810,
		Beyond-UI-UIDragItem-OnEndDrag0 = 811,
		Beyond-UI-UIDragItem-_StopDragView0 = 812,
		Beyond-UI-UIDragItem-_ContinueDragOnDisable0 = 813,
		Beyond-UI-UIDragItem-OnDrag0 = 817,
		Beyond-UI-UIDragItem-OnDestroy0 = 822,
		Beyond-UI-UIDragItem-ClearComponent0 = 823,
		Beyond-UI-UIDragItem-ClearEvents0 = 826,
		Beyond-UI-UIDragItem-OnEnable0 = 827,
		Beyond-UI-UIDragItem-OnBeginDrag0 = 828,
		Beyond-UI-UIDropdown-get_panel0 = 829,
		Beyond-UI-UIDropdown-Awake0 = 830,
		Beyond-UI-UIDropdown-_InitBinding0 = 831,
		Beyond-UI-UIDropdown-_GetDefaultNaviTarget0 = 834,
		Beyond-UI-UIDropdown-_ControllerToggle0 = 836,
		Beyond-UI-UIDropdown-_ToggleOptions0 = 838,
		Beyond-UI-UISelectableNaviGroup-ManuallyFocus0 = 842,
		Beyond-UI-UISelectableNaviGroup-_OnFocus0 = 843,
		Beyond-UI-UIDropdown-_ControllerCancel0 = 845,
		Beyond-UI-UISelectableNaviGroup-ManuallyStopFocus0 = 846,
		Beyond-UI-UISelectableNaviGroup-_OnStopFocus0 = 847,
		Beyond-UI-UIDropdown-ToggleOptions0 = 848,
		Beyond-UI-UIDropdown-_NotifyIsHover0 = 849,
		Beyond-UI-UIDropdown-OnPointerClick0 = 850,
		Beyond-UI-UIDropdown-Init0 = 851,
		Beyond-UI-UIDropdown-Update0 = 852,
		Beyond-UI-UIDropdown-_GetUICamera0 = 853,
		Beyond-UI-UIDropdown-SetSelected0 = 854,
		Beyond-UI-UIDropdown-ScrollToSelected0 = 857,
		Beyond-UI-UIScrollRect-AutoScrollToRectTransform0 = 858,
		Beyond-UI-UIScrollRect-_GetUICamera0 = 859,
		Beyond-UI-UIScrollRect-get_panel0 = 860,
		Beyond-UI-UIScrollRect-ScrollTo0 = 861,
		Beyond-UI-UIDropdown-Refresh0 = 862,
		Beyond-UI-UIDropdown-ClearComponent0 = 866,
		Beyond-UI-UIDropdown-get_bindingViewLabelText0 = 867,
		Beyond-UI-UIDropdown-get_bindingViewState0 = 868,
		Beyond-UI-UIDropdown-GetBindingViewActionId0 = 869,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyDown0 = 870,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyUp0 = 871,
		Beyond-UI-UIDropdown-OnEnable0 = 872,
		Beyond-UI-UIDropdown-OnDisable0 = 873,
		Beyond-UI-UIDropdown-OnDestroy0 = 874,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.get_interactable0 = 875,
		Beyond-UI-UIDropdownOption-SetText0 = 876,
		Beyond-UI-UIDropdownOption-SetState0 = 877,
		Beyond-UI-UIState-UIStateController-SetState0 = 878,
		Beyond-UI-UIState-StateReference-SetController0 = 881,
		Beyond-UI-UIState-UIStateController-_ApplyState0 = 882,
		Beyond-UI-UIState-StateDescription-get_IsEmpty0 = 883,
		Beyond-UI-UIState-StateDescription-ApplyGameObject0 = 884,
		Beyond-UI-UIState-StateDescription-ApplyComponent0 = 885,
		Beyond-UI-UIState-StateDescription-ApplyGraphic0 = 886,
		Beyond-UI-UIState-StateDescription-ApplyRectTransform0 = 887,
		Beyond-UI-UIState-UIStateControllerUtils-SetTop0 = 888,
		Beyond-UI-UIState-UIStateControllerUtils-SetBottom0 = 889,
		Beyond-UI-UIState-UIStateControllerUtils-SetLeft0 = 890,
		Beyond-UI-UIState-UIStateControllerUtils-SetRight0 = 891,
		Beyond-UI-UIState-UIStateControllerUtils-ForceRebuildLayout0 = 892,
		Beyond-UI-UIState-StateDescription-ApplyImage0 = 893,
		Beyond-UI-UIState-StateDescription-ApplyText0 = 896,
		Beyond-UI-UIState-StateDescription-ApplyCanvasGroup0 = 897,
		Beyond-UI-UIState-StateDescription-ApplyButton0 = 898,
		Beyond-UI-UIState-StateDescription-ApplyAnimator0 = 899,
		Beyond-UI-UIState-StateDescription-ApplyLayoutElement0 = 900,
		Beyond-UI-UIState-StateDescription-ApplyInnerState0 = 901,
		Beyond-UI-UIState-StateDescription-ApplyAnimation0 = 902,
		Beyond-UI-UIState-StateReference-ScheduleForPlaying0 = 903,
		Beyond-UI-UIState-UIStateController-OnStateReferenceDirty0 = 904,
		Beyond-UI-UIState-UIStateControllerUtils-StartEditorUpdateLoop0 = 905,
		Beyond-UI-UIState-StateAnimationInfo-OnUpdate0 = 906,
		Beyond-UI-UIState-StateReference-ScheduleForStopping0 = 913,
		Beyond-UI-UIState-StateDescription-ApplyLayoutGroup0 = 914,
		Beyond-UI-UIState-StateDescription-ApplyScrollList0 = 915,
		Beyond-UI-UIScrollList-SetPadding0 = 916,
		Beyond-UI-UIScrollList-UpdateContainerSize0 = 917,
		Beyond-UI-UIScrollList-GetLeftLength0 = 918,
		Beyond-UI-UIScrollList-_SetRealPadding0 = 919,
		Beyond-UI-UIScrollList-SetContainerSize0 = 921,
		Beyond-UI-UIScrollList-GetContainerSize0 = 922,
		Beyond-UI-UIScrollList-SetSpace0 = 923,
		Beyond-UI-UIState-StateDescription-ApplyGridLayoutGroup0 = 924,
		Beyond-UI-UIState-StateDescription-ApplySelectable0 = 925,
		Beyond-UI-UIDropItem-ClearEvents0 = 926,
		Beyond-UI-UIDropItem-Awake0 = 927,
		Beyond-UI-UIDropItem-OnEnable0 = 928,
		Beyond-UI-UIDropItem-ToggleHighlight0 = 929,
		Beyond-UI-UIDropItem-OnDisable0 = 930,
		Beyond-UI-UIDropItem-OnDestroy0 = 931,
		Beyond-UI-UIDropItem-ClearComponent0 = 933,
		Beyond-UI-UIDropItem-OnDrop0 = 934,
		Beyond-UI-UIElementFollower-get_panel0 = 935,
		Beyond-UI-UIElementFollower-OnAwake0 = 936,
		Beyond-UI-UIElementFollower-OnEnable0 = 937,
		Beyond-UI-UIElementFollower-UpdatePosition1 = 939,
		Beyond-UI-UIElementFollower-UpdatePosition0 = 940,
		Beyond-UI-UIElementFollower-LateTick0 = 942,
		Beyond-UI-UIExtendScrollRect-OnScroll0 = 943,
		Beyond-UI-UIExtendScrollRect-OnBeginDrag0 = 944,
		Beyond-UI-UIScrollList-OnBeginDrag0 = 945,
		Beyond-UI-UIExtendScrollRect-OnDrag0 = 946,
		Beyond-UI-UIScrollList-OnDrag0 = 947,
		Beyond-UI-UIExtendScrollRect-OnEndDrag0 = 948,
		Beyond-UI-UIScrollList-OnEndDrag0 = 949,
		Beyond-UI-UIFoldoutComponent-Refresh0 = 950,
		Beyond-UI-UIFoldoutComponent-OnFoldOut0 = 951,
		Beyond-UI-UINonUnifiedScrollList-NotifyCellSizeChange0 = 955,
		Beyond-UI-UIFoldoutComponent-OnFoldIn0 = 956,
		Beyond-UI-UIFoldoutComponent-OnDestroy0 = 960,
		Beyond-UI-UIGraphicAnimation-OnAwake0 = 961,
		Beyond-UI-UIGraphicAnimation-_Init0 = 962,
		Beyond-UI-UIGraphicAnimation-OnRelease0 = 963,
		Beyond-UI-UIGraphicAnimation-LateTick0 = 964,
		Beyond-UI-UIGridLayoutNaviWrapper-_InitIfNot0 = 965,
		Beyond-UI-UIGridLayoutNaviWrapper-Start0 = 966,
		Beyond-UI-UIGridLayoutNaviWrapper-_InitWrapNavigation0 = 967,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayout0 = 968,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutImpl0 = 969,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviChildren0 = 970,
		Beyond-UI-UIGridLayoutNaviWrapper-_SetCircleWrapScroll0 = 971,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutInit0 = 972,
		Beyond-UI-UIGridLayoutNaviWrapper-_FindValidSelectable0 = 973,
		Beyond-UI-UIScrollRect-WrapNavigation0 = 974,
		Beyond-UI-UIScrollRect-RectWrapNavigate0 = 975,
		Beyond-UI-UIGridLayoutNaviWrapper-TryWrapNavigate0 = 976,
		Beyond-UI-UIGyroscopeEffect-OnAwake0 = 977,
		Beyond-UI-UIGyroscopeEffect-Tick0 = 978,
		Beyond-UI-UIGyroscopeEffect-OnRelease0 = 981,
		Beyond-UI-UIHighlightMask-get_panel0 = 982,
		Beyond-UI-UIHighlightMask-OnAwake0 = 983,
		Beyond-UI-UIHighlightMask-OnEnable0 = 984,
		Beyond-UI-UIHighlightMask-TrySyncRect0 = 985,
		Beyond-UI-UIHighlightMask-Tick0 = 986,
		Beyond-UI-UIImage-get_panel0 = 987,
		Beyond-UI-UIImage-RegisterOnEnableRuntimeAtlas0 = 988,
		Beyond-UI-UIImage-UnregisterOnEnableRuntimeAtlas0 = 989,
		Beyond-UI-UIImage-OnEnableRuntimeAtlas0 = 990,
		Beyond-UI-UIImage-set_color0 = 991,
		Beyond-UI-UIImage-_OnSpriteChanged0 = 992,
		Beyond-UI-UIAtlasManager-get_enableRuntimeAtlas0 = 993,
		Beyond-UI-UIAtlasManager-ReProcessInsertForUIImage0 = 995,
		Beyond-UI-UIAtlasManager-_ReProcessInsertForUIImage0 = 996,
		Beyond-UI-UIAtlasManager-UIAtlasHandle-CreateInvalidHandle0 = 997,
		Beyond-UI-UIImage-OnPopulateMesh0 = 998,
		Beyond-UI-UIImage-Awake0 = 999,
		Beyond-UI-UIAtlasManager-AddUIImageToManagerOnInstantiate0 = 1000,
		Beyond-UI-UIAtlasManager-_AddUIImageToManagerOnInstantiate0 = 1001,
		Beyond-UI-UIImage-OnEnable0 = 1003,
		Beyond-UI-UIAtlasManager-AddUIImageToManager0 = 1005,
		Beyond-UI-UIAtlasManager-_AddUIImageToManager0 = 1006,
		Beyond-UI-UIImage-OnDisable0 = 1007,
		Beyond-UI-UIImage-OnDestroy0 = 1008,
		Beyond-UI-UIAtlasManager-RemoveUIImageFromManager0 = 1009,
		Beyond-UI-UIAtlasManager-_RemoveUIImageFromManager0 = 1010,
		Beyond-UI-UIImage-SetNativeSize0 = 1011,
		Beyond-UI-UIImage-SetNativeSizeIgnoreRefScale0 = 1012,
		Beyond-UI-UIImage-LoadSprite1 = 1013,
		Beyond-UI-UIImage-LoadMaterial0 = 1014,
		Beyond-UI-UIImage-ReleaseSprite0 = 1015,
		Beyond-UI-UIImage-get_mainTexture0 = 1016,
		Beyond-UI-UIImage-_V2AtlasInitialize0 = 1017,
		Beyond-UI-UIImageBlur-OnAwake0 = 1019,
		Beyond-UI-UIImageBlur-OnChangeSprite0 = 1020,
		Beyond-UI-UIImageBlur-Tick0 = 1021,
		Beyond-UI-UIImageBlur-OnDisable0 = 1022,
		Beyond-UI-UIImageBlur-OnRelease0 = 1023,
		Beyond-UI-UIImageFillAmountOffset-set_fillAmount0 = 1024,
		Beyond-UI-UIImageFillAmountOffset-DOFillAmount0 = 1025,
		Beyond-UI-UIImageFillFollower-OnAwake0 = 1028,
		Beyond-UI-UIImageFillFollower-OnEnable0 = 1029,
		Beyond-UI-UIImageFillFollower-Tick0 = 1030,
		Beyond-UI-UIImageFillFollower-RefreshFillAmount0 = 1031,
		Beyond-UI-UIImageFillTailFollower-OnAwake0 = 1032,
		Beyond-UI-UIImageFillTailFollower-OnEnable0 = 1033,
		Beyond-UI-UIImageFillTailFollower-RefreshFollower0 = 1034,
		Beyond-UI-UIImageFillTailFollower-Tick0 = 1035,
		Beyond-UI-UIImagePair-LoadSprite1 = 1036,
		Beyond-UI-UIImagePair-LoadSprite0 = 1037,
		Beyond-UI-UIImagePair-set_color0 = 1038,
		Beyond-UI-UIImagePair-get_first0 = 1039,
		Beyond-UI-UIInertiaViewPager-_PlayAudioGear0 = 1040,
		Beyond-UI-UIInertiaViewPager-_PlayAudioGearLock0 = 1041,
		Beyond-UI-UIInertiaViewPager-_InitIfNot0 = 1042,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-Reset0 = 1043,
		Beyond-UI-UIInertiaViewPager-ScrollEffectConfig-IsEmpty0 = 1044,
		Beyond-UI-UIInertiaViewPager-ClearComponent0 = 1045,
		Beyond-UI-UIInertiaViewPager-Tick0 = 1046,
		Beyond-UI-UIInertiaViewPager-DragContext-BeginDrag0 = 1047,
		Beyond-UI-UIInertiaViewPager-DragContext-EndDrag0 = 1048,
		Beyond-UI-UIInertiaViewPager-DragContext-_TryFlingToNext0 = 1049,
		Beyond-UI-UIInertiaViewPager-_ScrollValueAlignToPage0 = 1050,
		Beyond-UI-UIInertiaViewPager-_SwitchToPage0 = 1052,
		Beyond-UI-UIInertiaViewPager-_ScrollValue2PageIndex0 = 1053,
		Beyond-UI-UIInertiaViewPager-_PageIndex2ScrollValue0 = 1054,
		Beyond-UI-UIInertiaViewPager-BlockerManager-StartInertia0 = 1056,
		Beyond-UI-UIInertiaViewPager-BlockerManager-HitInertiaBlock0 = 1058,
		Beyond-UI-UIInertiaViewPager-InertiaBlocker-IsDirMatch0 = 1059,
		Beyond-UI-UIInertiaViewPager-_AutoAlign0 = 1060,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyScrolling0 = 1061,
		Beyond-UI-UIInertiaViewPager-_OnStateChanged0 = 1062,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyAlignFinish0 = 1063,
		Beyond-UI-UIInertiaViewPager-SetPageCount0 = 1064,
		Beyond-UI-UIInertiaViewPager-BlockerManager-Init0 = 1066,
		Beyond-UI-UIInertiaViewPager-MoveToPage0 = 1067,
		Beyond-UI-UIInertiaViewPager-OnAwake0 = 1068,
		Beyond-UI-UIInertiaViewPager-OnEnable0 = 1069,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-OnClear0 = 1070,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollBegin0 = 1071,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollEnd0 = 1072,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_velocity0 = 1073,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_scrollProgress0 = 1074,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-set_scrollProgress0 = 1075,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-StopMoving0 = 1076,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-StopMoving0 = 1077,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-OnClear0 = 1078,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-MarkHasScrolled0 = 1079,
		Beyond-UI-UIInputField-get_panel0 = 1080,
		Beyond-UI-UIInputField-get_isControllerInputValid0 = 1081,
		Beyond-UI-UIInputField-SendOnFocus0 = 1084,
		Beyond-UI-UIInputField-SendOnFocusLost0 = 1085,
		Beyond-UI-UIInputField-Awake0 = 1086,
		Beyond-UI-UIInputField-_VirtualKeyboardAwake0 = 1090,
		Beyond-UI-UIInputField-_VirtualKeyboardInitJavaObj0 = 1091,
		Beyond-UI-UIInputField-OnSelect0 = 1092,
		Beyond-UI-UIInputField-_VirtualKeyboardSelect0 = 1093,
		Beyond-UI-UIInputField-OnDeselect0 = 1094,
		Beyond-UI-UIInputField-_VirtualKeyboardDeselect0 = 1095,
		Beyond-UI-UIInputField-OnUpdateSelected0 = 1096,
		Beyond-UI-UIInputField-ActivateInputField0 = 1097,
		Beyond-UI-UIInputField-set_s_focusedInputField0 = 1098,
		Beyond-UI-UIInputField-TryActivateInputFieldCustom0 = 1099,
		Beyond-UI-UIInputField-_OnCloudGameKeyboardComplete0 = 1100,
		Beyond-UI-UIInputField-DeactivateInputField0 = 1101,
		Beyond-UI-UIInputField-_UpdateBindingEnable0 = 1102,
		Beyond-UI-UIInputField-OnDestroy0 = 1103,
		Beyond-UI-UIInputField-ClearComponent0 = 1104,
		Beyond-UI-UIInputField-_VirtualKeyboardOnDestroy0 = 1105,
		Beyond-UI-UIInputField-OnEnable0 = 1106,
		Beyond-UI-UIInputField-OnDisable0 = 1107,
		Beyond-UI-UIInputField-_NotifyIsHover0 = 1108,
		Beyond-UI-UIInputField-OnInteractableChanged0 = 1109,
		Beyond-UI-UIInputField-_GetCamera0 = 1110,
		Beyond-UI-UIInputField-_UpdateKeyboardOffset0 = 1111,
		Beyond-UI-UIInputField-_CleanupAndroidObjects0 = 1112,
		Beyond-UI-UIInputField-_KeyboardHeightChange0 = 1113,
		Beyond-UI-UIJoystick-get_panel0 = 1120,
		Beyond-UI-UIJoystick-set_walkRation0 = 1121,
		Beyond-UI-UIJoystick-_UpdateWalkBgScale0 = 1122,
		Beyond-UI-UIJoystick-get_m_thumbPosMaxLength0 = 1123,
		Beyond-UI-UIJoystick-Reset0 = 1124,
		Beyond-UI-UIJoystick-Awake0 = 1125,
		Beyond-UI-UIJoystick-InitBinding0 = 1126,
		Beyond-UI-UIJoystick-_UpdateState0 = 1129,
		Beyond-UI-UIJoystick-OnPointerDown0 = 1130,
		Beyond-UI-UIJoystick-_SetRectTransform0 = 1131,
		Beyond-UI-UIJoystick-_Activate0 = 1132,
		Beyond-UI-UIJoystick-_SetVisible0 = 1133,
		Beyond-UI-UIJoystick-_UpdateGait0 = 1135,
		Beyond-UI-UIJoystick-_UpdateIndicator0 = 1137,
		Beyond-UI-UIJoystick-_UpdateBg0 = 1138,
		Beyond-UI-UIJoystick-_SetWalkBgVisible0 = 1139,
		Beyond-UI-UIJoystick-_SetRunBgVisible0 = 1140,
		Beyond-UI-UIJoystick-OnPointerUp0 = 1141,
		Beyond-UI-UIJoystick-OnBeginDrag0 = 1142,
		Beyond-UI-UIJoystick-OnDrag0 = 1144,
		Beyond-UI-UIJoystick-_ChangeDynamic0 = 1146,
		Beyond-UI-UIJoystick-_OnHudLayoutLoaded0 = 1147,
		Beyond-UI-UIJoystick-OnEnable0 = 1148,
		Beyond-UI-UIJoystick-_Tick0 = 1149,
		Beyond-UI-UIJoystick-Start0 = 1150,
		Beyond-UI-UIJoystick-OnDestroy0 = 1151,
		Beyond-UI-UIJoystick-ClearComponent0 = 1152,
		Beyond-UI-UIJoystick-OnDisable0 = 1153,
		Beyond-UI-UIJoystick-CheckShouldActive0 = 1154,
		Beyond-UI-UILayoutDimensionListener-GraphicUpdateComplete0 = 1155,
		Beyond-UI-UILayoutDimensionListener-LayoutComplete0 = 1156,
		Beyond-UI-UILayoutDimensionListener-Rebuild0 = 1157,
		Beyond-UI-UILayoutDimensionListener-_NextFrameCoroutine0 = 1158,
		Beyond-UI-UILayoutDimensionListener-_InvokePostLayoutCallback0 = 1162,
		Beyond-UI-UILayoutDimensionListener-DoOnceOnPostLayout0 = 1166,
		Beyond-UI-UILayoutDimensionListener-OnEnable0 = 1167,
		Beyond-UI-UILayoutDimensionListener-_SetDirty0 = 1168,
		Beyond-UI-UILayoutDimensionListener-OnRectTransformDimensionsChange0 = 1169,
		Beyond-UI-UILayoutDimensionListener-OnDestroy0 = 1170,
		Beyond-UI-UILayoutDimensionListener-UnityEngine.UI.ICanvasElement.get_transform0 = 1171,
		Beyond-UI-UILeftSubtitle-Tick0 = 1172,
		Beyond-UI-UILeftSubtitle-UpdateByPlayTime0 = 1173,
		Beyond-UI-UILeftSubtitle-Exit0 = 1174,
		Beyond-UI-UILeftSubtitle-SetVisible0 = 1176,
		Beyond-UI-UILeftSubtitle-StartAutoPlay0 = 1177,
		Beyond-UI-UILeftSubtitle-SetLeftSubTitle0 = 1178,
		Beyond-UI-UIMaterialAnimation-LateTick0 = 1179,
		Beyond-UI-UIMaterialAnimation-_TryUpdate0 = 1180,
		Beyond-UI-UIMaterialAnimation-OnAwake0 = 1181,
		Beyond-UI-UIMaterialAnimation-OnRelease0 = 1182,
		Beyond-UI-UIMaterialAnimation-ForceUpdate0 = 1183,
		Beyond-UI-UINonUnifiedScrollList-InitBasicInfo0 = 1184,
		Beyond-UI-UIScrollList-InitBasicInfo0 = 1185,
		Beyond-UI-UIScrollList-SyncViewSize0 = 1186,
		Beyond-UI-UIScrollList-CalcSomeCountNum0 = 1187,
		Beyond-UI-UIScrollList-_GetLineCount0 = 1188,
		Beyond-UI-UINonUnifiedScrollList-CalcSomeCountNum0 = 1189,
		Beyond-UI-UINonUnifiedScrollList-GetLeftLength0 = 1190,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount0 = 1191,
		Beyond-UI-UIScrollList-UpdateCount1 = 1192,
		Beyond-UI-UIScrollList-UpdateCount0 = 1193,
		Beyond-UI-UIScrollList-InitConfig0 = 1194,
		Beyond-UI-UIScrollList-_StartGraduallyShow0 = 1196,
		Beyond-UI-UIScrollList-get_currentStep0 = 1197,
		Beyond-UI-UIScrollList-get_panel0 = 1198,
		Beyond-UI-UIScrollList-SkipGraduallyShow0 = 1199,
		Beyond-UI-UIScrollList-StopGraduallyShow0 = 1200,
		Beyond-UI-UIScrollList-ScrollTo0 = 1201,
		Beyond-UI-UIScrollList-GetTargetPosByIndex0 = 1202,
		Beyond-UI-UIScrollList-_ScrollToPos0 = 1203,
		Beyond-UI-UIScrollList-TryClearAdjustTween0 = 1204,
		Beyond-UI-UIScrollList-RestartGraduallyShow0 = 1211,
		Beyond-UI-UIScrollList-_ClearRelatedNaviGroup0 = 1212,
		Beyond-UI-UISelectableNaviGroup-ClearLastFocusNaviTarget0 = 1213,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount1 = 1214,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount2 = 1215,
		Beyond-UI-UINonUnifiedScrollList-LateTick0 = 1216,
		Beyond-UI-UIScrollList-TryRecalculateSize0 = 1217,
		Beyond-UI-UIScrollList-_InitNavigation0 = 1218,
		Beyond-UI-UIScrollList-NavigateSelected0 = 1220,
		Beyond-UI-UIScrollList-get_curSelectedIndex0 = 1221,
		Beyond-UI-UIScrollList-SetSelectedIndex0 = 1222,
		Beyond-UI-UIScrollList-set_curSelectedIndex0 = 1223,
		Beyond-UI-UIScrollList-Get0 = 1224,
		Beyond-UI-UIScrollList-GetCell1 = 1225,
		Beyond-UI-UIScrollList-ScrollToIndex0 = 1226,
		Beyond-UI-UIScrollList-GetNaviNewIndex0 = 1227,
		Beyond-UI-UIScrollList-GetNaviOffset0 = 1228,
		Beyond-UI-UINonUnifiedScrollList-OnScroll0 = 1236,
		Beyond-UI-UINonUnifiedScrollList-GetGridLayoutSize0 = 1237,
		Beyond-UI-UINonUnifiedScrollList-_GetCellSize0 = 1238,
		Beyond-UI-UINonUnifiedScrollList-GetContainerSize0 = 1239,
		Beyond-UI-UIScrollRect-get_inScrollTween0 = 1240,
		Beyond-UI-UINonUnifiedScrollList-GetCenterIndex0 = 1241,
		Beyond-UI-UINonUnifiedScrollList-GetShowRange0 = 1242,
		Beyond-UI-UINonUnifiedScrollList-GetNotCacheRange0 = 1243,
		Beyond-UI-UINonUnifiedScrollList-MoveCellTo0 = 1244,
		Beyond-UI-UINonUnifiedScrollList-_GetCellsSizeTo0 = 1245,
		Beyond-UI-UINonUnifiedScrollList-OnUpdateCell0 = 1246,
		Beyond-UI-UISizeFollower-SyncSize0 = 1247,
		Beyond-UI-UISizeFollower-get_rectTransform0 = 1248,
		Beyond-UI-UINonUnifiedScrollList-GetTargetPosByIndex0 = 1249,
		Beyond-UI-UINonUnifiedScrollList-ScrollTo0 = 1250,
		Beyond-UI-UINonUnifiedScrollList-ClearComponent0 = 1251,
		Beyond-UI-UIScrollList-ClearComponent0 = 1252,
		Beyond-UI-UINonUnifiedScrollList-get_currentStep0 = 1253,
		Beyond-UI-UINonUnifiedScrollList-SetStepTo0 = 1254,
		Beyond-UI-UINonUnifiedScrollList-SetCurrentStep0 = 1255,
		Beyond-UI-UINonUnifiedScrollList-GetScrollBarSize0 = 1256,
		Beyond-UI-UINonUnifiedScrollList-GetLastScrollStep0 = 1258,
		Beyond-UI-UINonUnifiedScrollList-UpdateLastScrollStep0 = 1259,
		Beyond-UI-UINonUnifiedScrollList-GetNormalizedPosition0 = 1260,
		Beyond-UI-UINonUnifiedScrollList-SetNormalizedPosition0 = 1261,
		Beyond-UI-UINonUnifiedScrollList-ToggleByState0 = 1262,
		Beyond-UI-UINonUnifiedScrollList-Toggle0 = 1263,
		Beyond-UI-UINonUnifiedScrollList-FoldAll0 = 1264,
		Beyond-UI-UINonUnifiedScrollRect-_InitIfNot0 = 1265,
		Beyond-UI-UINonUnifiedScrollRect-_OnPostLayout0 = 1266,
		Beyond-UI-UINonUnifiedScrollRect-_UpdateNonUnifiedScrollbars0 = 1267,
		Beyond-UI-UINonUnifiedScrollRect-UpdateScrollbars0 = 1268,
		Beyond-UI-UINonUnifiedScrollRect-Rebuild0 = 1269,
		Beyond-UI-UINonUnifiedScrollRect-SetHorizontalNormalizedPosition0 = 1270,
		Beyond-UI-UINonUnifiedScrollRect-SetVerticalNormalizedPosition0 = 1271,
		Beyond-UI-UINumberScrollTween-get_text0 = 1272,
		Beyond-UI-UINumberScrollTween-set_text0 = 1273,
		Beyond-UI-UINumberScrollTween-Start0 = 1274,
		Beyond-UI-UINumberScrollTween-Tick0 = 1275,
		Beyond-UI-UINumberScrollTween-_HandleNumberScrollTween0 = 1276,
		Beyond-UI-UINumberScrollTween-_TweenToTarget0 = 1277,
		Beyond-UI-UINumberScrollTween-_CleanupBeforeTween0 = 1278,
		Beyond-UI-UIPCScaleHelper-OnEnable0 = 1279,
		Beyond-UI-UIRegionBuildingTexManager-OnEnable0 = 1280,
		Beyond-UI-UIRegionBuildingTexManager-_UpdateTexture0 = 1281,
		Beyond-UI-UIRegionBuildingTexManager-OnValidate0 = 1282,
		Beyond-UI-UIRegionBuildingTexManager-OnDisable0 = 1283,
		Beyond-UI-UIScaleHolder-OnAwake0 = 1284,
		Beyond-UI-UIScaleHolder-OnEnable0 = 1285,
		Beyond-UI-UIScaleHolder-_HoldScale0 = 1286,
		Beyond-UI-UIScaleHolder-_IsValidScale0 = 1287,
		Beyond-UI-UIScaleHolder-LateTick0 = 1288,
		Beyond-UI-UIScaleHolder-SetExtraScale0 = 1289,
		Beyond-UI-UIScaleHolder-GetExtraScale0 = 1290,
		Beyond-UI-UIScrollbar-Awake0 = 1291,
		Beyond-UI-UIScrollbarKeyHint-OnAwake0 = 1292,
		Beyond-UI-UIScrollbarKeyHint-Tick0 = 1293,
		Beyond-UI-UIScrollRect-get_controllerStickScrollEnabled0 = 1294,
		Beyond-UI-UIScrollCircle-get_panel0 = 1295,
		Beyond-UI-UIScrollCircle-get_viewRect0 = 1296,
		Beyond-UI-UIScrollCircle-OnInitializePotentialDrag0 = 1297,
		Beyond-UI-UIScrollCircle-IsActive0 = 1298,
		Beyond-UI-UIScrollCircle-OnBeginDrag0 = 1299,
		Beyond-UI-UIScrollCircle-OnEndDrag0 = 1300,
		Beyond-UI-UIScrollCircle-OnDrag0 = 1301,
		Beyond-UI-UIScrollCircle-_GetDeltaAngle0 = 1302,
		Beyond-UI-UIScrollCircle-_CheckCanMove0 = 1303,
		Beyond-UI-UIScrollCircle-_UpdateSpeed0 = 1304,
		Beyond-UI-UIScrollCircle-_TryUpdateCells0 = 1305,
		Beyond-UI-UIScrollCircle-_UpdateCenterIndex0 = 1306,
		Beyond-UI-UIScrollCircle-_UpdateShowingCells0 = 1308,
		Beyond-UI-UIScrollCircle-_GetRealIndex0 = 1309,
		Beyond-UI-UIScrollCircle-_UpdateAuto0 = 1310,
		Beyond-UI-UIScrollCircle-OnRelease0 = 1311,
		Beyond-UI-UIScrollCircle-_InitCells0 = 1312,
		Beyond-UI-UIScrollCircle-_Init0 = 1313,
		Beyond-UI-UIScrollCircle-_OnAwakeInit0 = 1314,
		Beyond-UI-UIScrollCircle-_UpdateScrollRange0 = 1315,
		Beyond-UI-UIScrollCircle-_DoScroll0 = 1316,
		Beyond-UI-UIScrollCircle-OnScroll0 = 1318,
		Beyond-UI-UIScrollCircle-Rebuild0 = 1319,
		Beyond-UI-UIScrollCircle-LayoutComplete0 = 1320,
		Beyond-UI-UIScrollCircle-GraphicUpdateComplete0 = 1321,
		Beyond-UI-UIScrollCircle-IsDestroyed0 = 1322,
		Beyond-UI-UIScrollCircle-OnEnable0 = 1323,
		Beyond-UI-UIScrollCircle-OnDisable0 = 1324,
		Beyond-UI-UIScrollCircle-Start0 = 1325,
		Beyond-UI-UIScrollCircle-OnAwake0 = 1326,
		Beyond-UI-UIScrollCircle-LateTick0 = 1327,
		Beyond-UI-UIScrollCircle-UpdateCount0 = 1328,
		Beyond-UI-UIScrollCircle-ScrollToIndex0 = 1330,
		Beyond-UI-UIScrollCircle-Get0 = 1331,
		Beyond-UI-UIScrollCircle-ClearComponent0 = 1332,
		Beyond-UI-UIScrollCircle-UnityEngine.UI.ICanvasElement.get_transform0 = 1333,
		Beyond-UI-UIScrollCircle-Cell-SetSelect0 = 1334,
		Beyond-UI-UIScrollContainerFollower-OnAwake0 = 1335,
		Beyond-UI-UIScrollContainerFollower-LateTick0 = 1336,
		Beyond-UI-UIScrollContainerFollower-_RefreshSizeAndPositionToTargetContainer0 = 1338,
		Beyond-UI-UIScrollList-OnAwake0 = 1339,
		Beyond-UI-UIScrollList-Init0 = 1340,
		Beyond-UI-UIScrollList-_InGameAwake0 = 1341,
		Beyond-UI-UIScrollList-_InitAutoScroll0 = 1342,
		Beyond-UI-UIScrollList-_OnEnterAutoScrollUp0 = 1343,
		Beyond-UI-UIScrollList-_SetAutoScrollSpd0 = 1345,
		Beyond-UI-UIScrollList-_OnExitAutoScrollUp0 = 1346,
		Beyond-UI-UIScrollList-_OnEnterAutoScrollDown0 = 1347,
		Beyond-UI-UIScrollList-_OnExitAutoScrollDown0 = 1349,
		Beyond-UI-UIScrollList-_InitControllerNavi0 = 1350,
		Beyond-UI-UIScrollList-ListWrapNavigate0 = 1351,
		Beyond-UI-UIScrollList-_EditorAwake0 = 1352,
		Beyond-UI-UIScrollList-Tick0 = 1353,
		Beyond-UI-UIScrollList-_UpdateGraduallyShow0 = 1354,
		Beyond-UI-UIScrollList-_UpdateAutoScroll0 = 1355,
		Beyond-UI-UIScrollList-SetStepTo0 = 1356,
		Beyond-UI-UIScrollList-LateTick0 = 1357,
		Beyond-UI-UIScrollList-OnEnable0 = 1358,
		Beyond-UI-UIScrollList-OnDisable0 = 1359,
		Beyond-UI-UIScrollList-SetTop0 = 1360,
		Beyond-UI-UIScrollList-UpdateCount2 = 1361,
		Beyond-UI-UIScrollList-UpdateShowingCells1 = 1362,
		Beyond-UI-UIScrollList-GetRangeInView0 = 1363,
		Beyond-UI-UIScrollList-SetCellCanCache0 = 1364,
		Beyond-UI-UIScrollList-CacheShowingCell0 = 1365,
		Beyond-UI-UIScrollList-OnRelease0 = 1366,
		Beyond-UI-UIScrollList-SetPaddingBottom0 = 1367,
		Beyond-UI-UIScrollList-SetPaddingTop0 = 1368,
		Beyond-UI-UIScrollList-SetPaddingRight0 = 1369,
		Beyond-UI-UIScrollList-SetPaddingLeft0 = 1370,
		Beyond-UI-UIScrollList-GetPadding0 = 1371,
		Beyond-UI-UIScrollList-GetShowingCellsIndexRange0 = 1372,
		Beyond-UI-UIScrollList-GetCenterIndex0 = 1373,
		Beyond-UI-UIScrollList-GetMousePosIndex0 = 1374,
		Beyond-UI-UIScrollList-ScreenPos2Index0 = 1375,
		Beyond-UI-UIScrollList-GetIndexOf0 = 1376,
		Beyond-UI-UIScrollList-_GetScreenPosLineColumnInfo0 = 1377,
		Beyond-UI-UIScrollRect-Awake0 = 1378,
		Beyond-UI-UIScrollRect-_CheckOverScrollEffect0 = 1379,
		Beyond-UI-UIScrollRect-OnEnable0 = 1380,
		Beyond-UI-UIScrollRect-_InitController0 = 1381,
		Beyond-UI-UIScrollRect-ScrollToNaviTarget0 = 1382,
		Beyond-UI-UIScrollRect-Update0 = 1383,
		Beyond-UI-UIScrollRect-_TickRefreshControllerStickScroll0 = 1384,
		Beyond-UI-UIScrollRect-_UpdateMoveTips0 = 1385,
		Beyond-UI-UIScrollRect-get_moveTips0 = 1386,
		Beyond-UI-UIScrollRect-IsCellViewed0 = 1387,
		Beyond-UI-UIScrollRect-OnDestroy0 = 1388,
		Beyond-UI-UIScrollRect-_CustomSetPosOnScroll0 = 1389,
		Beyond-UI-UIScrollRect-UpdateScrollEnableNode0 = 1393,
		Beyond-UI-UIScrollRect-OnBeginDrag0 = 1394,
		Beyond-UI-UIScrollRect-OnDrag0 = 1395,
		Beyond-UI-UIScrollRect-OnEndDrag0 = 1396,
		Beyond-UI-UIScrollRect-_CheckOverScrollOnEndDrag0 = 1397,
		Beyond-UI-UIScrollRect-ClearComponent0 = 1398,
		Beyond-UI-UIScrollRect-LateUpdate0 = 1399,
		Beyond-UI-UIScrollRectEdgeRedDot-OnAwake0 = 1400,
		Beyond-UI-UIScrollRectEdgeRedDot-ResetReferences0 = 1401,
		Beyond-UI-UIScrollRectEdgeRedDot-OnEnable0 = 1402,
		Beyond-UI-UIScrollRectEdgeRedDot-_UpdateRedDotGameObjects0 = 1403,
		Beyond-UI-UIScrollRectEdgeRedDot-_OnScrollListUpdateCount0 = 1404,
		Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDotStatesForScrollList0 = 1405,
		Beyond-UI-UIScrollRectEdgeRedDot-OnRelease0 = 1406,
		Beyond-UI-UIScrollRectEdgeRedDot-Tick0 = 1407,
		Beyond-UI-UIScrollRectEdgeRedDot-_UpdateCacheDictForRangeChange0 = 1408,
		Beyond-UI-UIScrollRectEdgeRedDot-UpdateRedDotStateInDir0 = 1409,
		Beyond-UI-UIScrollRectEdgeRedDot-_CalculateRedDotStateInDir0 = 1410,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_state0 = 1411,
		Beyond-UI-UIScrollRectEdgeRedDot-IsRedDotInDir0 = 1412,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newPos0 = 1413,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalPos0 = 1414,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newRect0 = 1415,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalRect0 = 1416,
		Beyond-UI-UIScrollRectEdgeRedDot-ResetRedDotPosition0 = 1417,
		Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDot0 = 1418,
		Beyond-UI-UIScrollRectEdgeRedDot-UnregisterRedDot0 = 1419,
		Beyond-UI-UIScrollRectEdgeRedDot-ClearComponent0 = 1420,
		Beyond-UI-UIScrollText-_InitIfNot0 = 1421,
		Beyond-UI-UIScrollText-ResetTextScroll0 = 1422,
		Beyond-UI-UIScrollText-_ResetTextScrollInternal0 = 1423,
		Beyond-UI-UIScrollText-_ApplyTextAlignment0 = 1424,
		Beyond-UI-UIScrollText-_ResetTextScroll0 = 1425,
		Beyond-UI-UIScrollText-ResetToStatic0 = 1426,
		Beyond-UI-UIScrollText-GetSingleScrollDuration0 = 1427,
		Beyond-UI-UIScrollText-OnAwake0 = 1428,
		Beyond-UI-UIScrollText-LateTick0 = 1429,
		Beyond-UI-UIScrollText-_UpdateScrollState0 = 1430,
		Beyond-UI-UIScrollText-_ApplyTextScroll0 = 1431,
		Beyond-UI-UIScrollText-CanvasGroupHandler-HandleAlpha0 = 1432,
		Beyond-UI-UIScrollText-PositionScrollHandler-ApplyScroll0 = 1433,
		Beyond-UI-UIScrollText-PositionScrollHandler-ResetScroll0 = 1434,
		Beyond-UI-UIScrollText-PositionScrollHandler-UpdateScrollStatus0 = 1435,
		Beyond-UI-UIScrollText-MeshScrollHandler-ApplyScroll0 = 1436,
		Beyond-UI-UIScrollText-MeshScrollHandler-_ApplyScroll0 = 1437,
		Beyond-UI-UIScrollText-MeshScrollHandler-_UpdateMeshClipping0 = 1438,
		Beyond-UI-UIScrollText-MeshScrollHandler-ResetScroll0 = 1439,
		Beyond-UI-UIScrollText-MeshScrollHandler-UpdateScrollStatus0 = 1440,
		Beyond-UI-UISelectableNaviGroup-Awake0 = 1441,
		Beyond-UI-UISelectableNaviGroup-_InitFocusBinding0 = 1442,
		Beyond-UI-UISelectableNaviGroup-_RefreshFocusBindings0 = 1445,
		Beyond-UI-UISelectableNaviGroup-OnEnable0 = 1446,
		Beyond-UI-UISelectableNaviGroup-_RefreshRelatedBindingGroupsState0 = 1447,
		Beyond-UI-UISelectableNaviGroup-_RefreshFocusActionKeyHint0 = 1448,
		Beyond-UI-UISelectableNaviGroup-_RefreshStopFocusActionKeyHint0 = 1449,
		Beyond-UI-UISelectableNaviGroup-OnDisable0 = 1450,
		Beyond-UI-UISelectableNaviGroup-_OnIsTopLayerChanged0 = 1451,
		Beyond-UI-UISelectableNaviGroup-_OnSelectableNaviGroupDisabled0 = 1452,
		Beyond-UI-UISelectableNaviGroup-_BeforeSelectableNaviGroupDestroy0 = 1453,
		Beyond-UI-UISelectableNaviGroup-_OnSetLayerSelectedTarget0 = 1454,
		Beyond-UI-UISelectableNaviGroup-_OnRemoveFromLayerStack0 = 1455,
		Beyond-UI-UISelectableNaviGroup-OnDestroy0 = 1456,
		Beyond-UI-UISelectableNaviGroup-ClearComponent0 = 1457,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnUp0 = 1458,
		Beyond-UI-UISelectableNaviGroup-_TryChangeNaviPartner0 = 1459,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnDown0 = 1460,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnLeft0 = 1461,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnRight0 = 1462,
		Beyond-UI-UISelectableNaviGroup-RefreshFocusBindings0 = 1463,
		Beyond-UI-UISelectableNaviGroup-SetFocusBindingText0 = 1464,
		Beyond-UI-UISelectableNaviGroup-ManuallyRefreshRelatedBindingGroups0 = 1465,
		Beyond-UI-UISemiCircleScrollList-get_controllerStickScrollEnabled0 = 1466,
		Beyond-UI-UISemiCircleScrollList-OnAwake0 = 1467,
		Beyond-UI-UISemiCircleScrollList-ClearComponent0 = 1468,
		Beyond-UI-UISemiCircleScrollList-UpdateLayout0 = 1469,
		Beyond-UI-UISemiCircleScrollList-_InitializeCells0 = 1470,
		Beyond-UI-UISemiCircleScrollList-OnDisable0 = 1471,
		Beyond-UI-UISemiCircleScrollList-Tick0 = 1472,
		Beyond-UI-UISemiCircleScrollList-_TickRefreshControllerStickScroll0 = 1473,
		Beyond-UI-UISemiCircleScrollList-OnEndDrag0 = 1474,
		Beyond-UI-UISemiCircleScrollList-_ApplyDamping0 = 1475,
		Beyond-UI-UISemiCircleScrollList-OnDrag0 = 1482,
		Beyond-UI-UISemiCircleScrollList-RefreshLayout0 = 1483,
		Beyond-UI-UISemiCircleScrollList-OnBeginDrag0 = 1484,
		Beyond-UI-UISemiCircleScrollListPair-Awake0 = 1485,
		Beyond-UI-UISemiCircleScrollListPair-_OnCellShow0 = 1486,
		Beyond-UI-UISemiCircleScrollListPair-_OnClosestCellChanged0 = 1487,
		Beyond-UI-UISemiCircleScrollListPair-_OnDrag0 = 1488,
		Beyond-UI-UISemiCircleScrollListPair-_OnEndDrag0 = 1489,
		Beyond-UI-UISemiCircleScrollListPair-RefreshLayout0 = 1490,
		Beyond-UI-UISequenceImage-OnAwake0 = 1491,
		Beyond-UI-UISequenceImage-OnEnable0 = 1492,
		Beyond-UI-UISequenceImage-Play0 = 1493,
		Beyond-UI-UISequenceImage-SetSprite0 = 1495,
		Beyond-UI-UISequenceImage-OnDisable0 = 1496,
		Beyond-UI-UISequenceImage-Stop0 = 1497,
		Beyond-UI-UISequenceImage-Tick0 = 1499,
		Beyond-UI-UISimpleActiveAnimationHelper-Start0 = 1500,
		Beyond-UI-UISimpleActiveAnimationHelper-Skip0 = 1501,
		Beyond-UI-UISimpleActiveAnimationHelper-OnEnable0 = 1502,
		Beyond-UI-UISimpleActiveAnimationHelper-Tick0 = 1503,
		Beyond-UI-UISimpleStateController-SetState0 = 1504,
		Beyond-UI-UISimpleStateController-StateInfo-ToString0 = 1505,
		Beyond-UI-UISizeFollower-LateTick0 = 1506,
		Beyond-UI-UISlider-_TryPostSlideAudioEvent0 = 1507,
		Beyond-UI-UISlider-ClampValue0 = 1508,
		Beyond-UI-UISlider-CustomProcessNormalizedValue0 = 1509,
		Beyond-UI-UISlider-OnValueChanged0 = 1510,
		Beyond-UI-UISlider-OnClickSliderBar0 = 1511,
		Beyond-UI-UISlider-OnClickSliderHandle0 = 1512,
		Beyond-UI-UISlider-_NotifyIsHover0 = 1513,
		Beyond-UI-UISlider-OnBeginDrag0 = 1514,
		Beyond-UI-UISlider-OnEndDrag0 = 1515,
		Beyond-UI-UISlider-Awake0 = 1516,
		Beyond-UI-UISlider-_InitBinding0 = 1517,
		Beyond-UI-UISlider-_InitGamepadStickScroll0 = 1520,
		Beyond-UI-UISlider-_OnGamepadStickScrollHoriValue0 = 1521,
		Beyond-UI-UISlider-_ApplyGamepadStickScroll0 = 1522,
		Beyond-UI-UISlider-_AddValue0 = 1523,
		Beyond-UI-UISlider-_ReduceValue0 = 1524,
		Beyond-UI-UISlider-OnEnable0 = 1525,
		Beyond-UI-UISlider-_CreateGamepadStickScrollTickFunction0 = 1526,
		Beyond-UI-UISlider-_ReleaseGamepadStickScrollTickFunction0 = 1527,
		Beyond-UI-UISlider-_GamepadStickScrollTick0 = 1528,
		Beyond-UI-UISlider-OnDisable0 = 1529,
		Beyond-UI-UISlider-ClearComponent0 = 1530,
		Beyond-UI-UISlider-OnDestroy0 = 1531,
		Beyond-UI-UISlider-get_bindingViewState0 = 1532,
		Beyond-UI-UISlider-GetBindingViewActionId0 = 1533,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyDown0 = 1534,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyUp0 = 1535,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.get_interactable0 = 1536,
		Beyond-UI-UISoftMask-GetTextSoftMaskMaterial0 = 1537,
		Beyond-UI-UISoftMask-GetUIVFXSoftMaskMaterial0 = 1538,
		Beyond-UI-UISoftMask-GetCornerCanvas0 = 1539,
		Beyond-UI-UISoftMask-GetFourCornnerArrayWorld0 = 1540,
		Beyond-UI-UISoftMask-OnEnable0 = 1541,
		Beyond-UI-UISoftMask-_OnEnableRuntimeAtlas0 = 1542,
		Beyond-UI-UISoftMask-_UpdateParam0 = 1543,
		Beyond-UI-UISoftMask-_UpdateChildren0 = 1544,
		Beyond-UI-UISoftMaskable-MarkGraphicVerticesDirty0 = 1545,
		Beyond-UI-UISoftMaskable-get_graphic0 = 1546,
		Beyond-UI-UISoftMaskable-MarkGraphicMaterialDirty0 = 1547,
		Beyond-UI-UISoftMask-OnDisable0 = 1548,
		Beyond-UI-UISoftMask-_Clear0 = 1549,
		Beyond-UI-UISoftMask-_DestroyMaterial0 = 1550,
		Beyond-UI-UISoftMask-TailLateTick0 = 1551,
		Beyond-UI-UISoftMaskable-get_softMask0 = 1552,
		Beyond-UI-UISoftMaskable-get_uiText0 = 1553,
		Beyond-UI-UISoftMaskable-GetModifiedMaterial0 = 1554,
		Beyond-UI-UISoftMaskable-OnEnable0 = 1555,
		Beyond-UI-UISoftMaskable-OnDisable0 = 1556,
		Beyond-UI-UISoftMaskable-LateTick0 = 1557,
		Beyond-UI-UISoftMaskable-ModifyMesh0 = 1558,
		Beyond-UI-UISoftMaskable-_Equal0 = 1559,
		Beyond-UI-UISoftMaskable-_ComputeLineCross0 = 1560,
		Beyond-UI-UISoftMaskable-_ComputePointAtTriangleUV0 = 1561,
		Beyond-UI-UISoftMaskable-_ClipTriangleByClampSoftMaskUV0 = 1562,
		Beyond-UI-UISoftMaskable-_SetUIVertexUV0 = 1563,
		Beyond-UI-UISoftMaskable-_ClipRect0 = 1564,
		Beyond-UI-UISoftMaskable-ModifyMesh1 = 1565,
		Beyond-UI-UISortingOrder-OnEnable0 = 1566,
		Beyond-UI-UISortingOrder-_GetRenderer0 = 1567,
		Beyond-UI-UISortingOrder-_GetChildrenRenderers0 = 1568,
		Beyond-UI-UISortingOrder-_GetCanvas0 = 1569,
		Beyond-UI-UISortingOrder-SetOrder0 = 1570,
		Beyond-UI-UISortingOrder-Awake0 = 1571,
		Beyond-UI-UISortingOrder-OnDestroy0 = 1572,
		Beyond-UI-UIStepScrollList-Init0 = 1573,
		Beyond-UI-UIStepScrollList-_OnScrollEnd0 = 1574,
		Beyond-UI-UIStepScrollList-_TryAutoScroll0 = 1575,
		Beyond-UI-UIStepScrollList-_GetClampedIndex0 = 1576,
		Beyond-UI-UIStepScrollList-_OnScrollStart0 = 1577,
		Beyond-UI-UIStepScrollList-InitConfig0 = 1578,
		Beyond-UI-UIStepScrollList-OnScroll0 = 1579,
		Beyond-UI-UIStepScrollList-OnBeginDrag0 = 1580,
		Beyond-UI-UIStepScrollList-OnEndDrag0 = 1581,
		Beyond-UI-UIStepScrollList-SetTop0 = 1583,
		Beyond-UI-UIStepScrollList-UpdateShowingCells0 = 1584,
		Beyond-UI-UIStepScrollList-ClearComponent0 = 1585,
		Beyond-UI-UIStepScrollList-OnDisable0 = 1586,
		Beyond-UI-UIStyleByState-Awake0 = 1587,
		Beyond-UI-UIStyleByState-UpdateStyle0 = 1588,
		Beyond-UI-UIStyleByState-_IsValidStyle0 = 1589,
		Beyond-UI-UIStyleByState-OnDestroy0 = 1590,
		Beyond-UI-UISubtitle-Start0 = 1591,
		Beyond-UI-UISubtitle-_SetAsDefault0 = 1592,
		Beyond-UI-UISubtitle-SetSubtitle0 = 1593,
		Beyond-UI-UISubtitle-UpdateAlpha0 = 1594,
		Beyond-UI-UITextPair-get_text0 = 1595,
		Beyond-UI-UITextPair-set_text0 = 1596,
		Beyond-UI-UITextPair-set_color0 = 1597,
		Beyond-UI-UITextPair-get_first0 = 1598,
		Beyond-UI-UITextPair-SetAndResolveTextStyle0 = 1599,
		Beyond-UI-UITextPair-SetPhoneticText0 = 1600,
		Beyond-UI-UIToggle-Awake0 = 1601,
		Beyond-UI-UIToggle-_InitToggleBinding0 = 1602,
		Beyond-UI-UIToggle-TryInternalToggle0 = 1603,
		Beyond-UI-UIToggle-_OnToggleFail0 = 1604,
		Beyond-UI-UIToggle-_TryRefreshToggleBindingText0 = 1606,
		Beyond-UI-UIToggle-_TryRefreshBindingText0 = 1608,
		Beyond-UI-UIToggle-_InitActionOnSetNaviTarget0 = 1609,
		Beyond-UI-UIToggle-_TryRefreshHoverConfirmBindingText0 = 1611,
		Beyond-UI-UIToggle-OnEnable0 = 1613,
		Beyond-UI-UIToggle-_UpdateObjects0 = 1614,
		Beyond-UI-UIToggle-_PlayAnimation0 = 1615,
		Beyond-UI-UIToggle-_UpdateBindingEnable0 = 1616,
		Beyond-UI-UIToggle-OnDisable0 = 1617,
		Beyond-UI-UIToggle-OnDestroy0 = 1618,
		Beyond-UI-UIToggle-ClearComponent0 = 1619,
		Beyond-UI-UIToggle-Start0 = 1620,
		Beyond-UI-UIToggle-InternalToggle0 = 1621,
		Beyond-UI-UIToggle-PlayAudio0 = 1622,
		Beyond-UI-UIToggle-OnValueChange0 = 1623,
		Beyond-UI-UIToggle-_NotifyIsHover0 = 1624,
		Beyond-UI-UIToggle-OnInteractableChanged0 = 1625,
		Beyond-UI-UIToggle-GetMouseActionHints0 = 1626,
		Beyond-UI-UIToggle-OnPointerDown0 = 1627,
		Beyond-UI-UIToggle-OnPointerClick0 = 1629,
		Beyond-UI-UIToggle-OnSubmit0 = 1631,
		Beyond-UI-UIToggle-OnNaviTargetEnabledAgain0 = 1632,
		Beyond-UI-UIToggle-_OnSetAsNaviTarget0 = 1633,
		Beyond-UI-UIToggle-_ToggleNaviInputBinding0 = 1634,
		Beyond-UI-UIToggle-RefreshHintText0 = 1635,
		Beyond-UI-UIToggleGroup-Awake0 = 1636,
		Beyond-UI-UIToggleGroup-MoveToNext0 = 1637,
		Beyond-UI-UIToggleGroup-_MoveTo0 = 1638,
		Beyond-UI-UIToggleGroup-MoveToPrevious0 = 1640,
		Beyond-UI-UIToggleGroup-OnEnable0 = 1642,
		Beyond-UI-UIToggleGroup-OnDisable0 = 1645,
		Beyond-UI-UIToggleGroup-OnDestroy0 = 1646,
		Beyond-UI-UITouchPanel-OnBeginDrag0 = 1647,
		Beyond-UI-UITouchPanel-_IsSameTouchFromPress0 = 1648,
		Beyond-UI-UITouchPanel-OnEndDrag0 = 1649,
		Beyond-UI-UITouchPanel-DoEndDrag0 = 1650,
		Beyond-UI-UITouchPanel-OnDrag0 = 1651,
		Beyond-UI-UITouchPanel-OnPointerDown0 = 1653,
		Beyond-UI-UITouchPanel-_OnActionPress0 = 1654,
		Beyond-UI-UITouchPanel-OnPointerUp0 = 1655,
		Beyond-UI-UITouchPanel-_OnActionRelease0 = 1656,
		Beyond-UI-UITouchPanel-OnPointerClick0 = 1657,
		Beyond-UI-UITouchPanel-OnPointerEnter0 = 1658,
		Beyond-UI-UITouchPanel-OnPointerExit0 = 1660,
		Beyond-UI-UITouchPanel-ClearTouchInfo0 = 1661,
		Beyond-UI-UITouchPanel-OnScroll0 = 1662,
		Beyond-UI-UITouchPanel-SimulateClick0 = 1663,
		Beyond-UI-UITouchPanel-DeActiveTouch0 = 1664,
		Beyond-UI-UITouchPanel-OnAwake0 = 1665,
		Beyond-UI-UITouchPanel-InitBinding0 = 1666,
		Beyond-UI-UITouchPanel-_UpdateState0 = 1669,
		Beyond-UI-UITouchPanel-Tick0 = 1672,
		Beyond-UI-UITouchPanel-LateTick0 = 1675,
		Beyond-UI-UITouchPanel-OnEnable0 = 1676,
		Beyond-UI-UITouchPanel-OnDisable0 = 1677,
		Beyond-UI-UITouchPanel-OnDestroy0 = 1678,
		Beyond-UI-UITouchPanel-OnRelease0 = 1679,
		Beyond-UI-UITouchPanel-ClearComponent0 = 1680,
		Beyond-UI-UIVFXManager-get_graphic0 = 1681,
		Beyond-UI-UIVFXManager-get_softMaskable0 = 1682,
		Beyond-UI-UIVFXManager-OnEnable0 = 1683,
		Beyond-UI-UIVFXManager-_OnEnableRuntimeAtlas0 = 1684,
		Beyond-UI-UIVFXManager-_UpdateParam0 = 1685,
		Beyond-UI-UIVFXManager-LateTick0 = 1686,
		Beyond-UI-UIVFXManager-OnDisable0 = 1687,
		Beyond-UI-UIVFXManager-_Clear0 = 1688,
		Beyond-UI-UIVFXManager-_DestroyMaterial0 = 1689,
		Beyond-UI-UIVFXManager-GetModifiedMaterial0 = 1690,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateUpPos0 = 1691,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-ScrollListLayoutInfo-get_cellHeight0 = 1692,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateDownPos0 = 1693,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateMidPos0 = 1694,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateWorldLevelScrollList0 = 1695,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-_ScrollLayouts0 = 1696,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-OnDisable0 = 1703,
		Beyond-UI-VirtualMouseInitPos-get_panel0 = 1704,
		Beyond-UI-VirtualMouseInitPos-OnEnable0 = 1705,
		Beyond-UI-CSPopupPanel-Awake0 = 1706,
		Beyond-UI-CSPopupPanel-_OnConfirm0 = 1707,
		Beyond-UI-CSPopupPanel-_OnCancel0 = 1708,
		Beyond-UI-CSPopupPanel-OnDestroy0 = 1709,
		Beyond-UI-CSPopupPanel-Show0 = 1710,
		Beyond-UI-CSPopupPanel-ClearAllPanels0 = 1711,
		Beyond-UI-MobileMotionManager-OnInit0 = 1712,
		Beyond-UI-MobileMotionManager-_CheckMotionLevelAndPostIfChange0 = 1713,
		Beyond-UI-MobileMotionManager-OnRelease0 = 1714,
		Beyond-UI-MobileMotionManager-PostEventCommonShort0 = 1715,
		Beyond-UI-MobileMotionManager-PostEventCommonOperateSuccess0 = 1716,
		Beyond-UI-MobileMotionManager-PostEventCommonOperateFailure0 = 1717,
		Beyond-UI-I18nFontLoader-GetCNFont0 = 1718,
		Beyond-UI-DynamicFontAssetLoader-AddNotFoundUnicode0 = 1719,
		Beyond-UI-DynamicFontAssetLoader-TryGetFontAsset0 = 1720,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-GetFontAsset0 = 1722,
		Beyond-UI-DynamicFontAssetLoader-TryRemoveRefText0 = 1723,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-RemoveRefText0 = 1724,
		Beyond-UI-DynamicFontAssetLoader-Dispose0 = 1725,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-Dispose0 = 1726,
		Beyond-UI-TweenUtils-TickAsCountDown0 = 1727,
		Beyond-UI-TweenUtils-FLerpByTime-Start0 = 1728,
		Beyond-UI-TweenUtils-FLerpByTime-GetValue0 = 1729,
		Beyond-UI-UIAnimationLayerMixPlayer-LockToClip0 = 1730,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateGraph0 = 1731,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateMixer0 = 1732,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateOutput0 = 1733,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateSourceFromAsset0 = 1734,
		Beyond-UI-UIAnimationMixPlayer-LockToClip0 = 1735,
		Beyond-UI-UIAnimationMixPlayer-CreateGraph0 = 1736,
		Beyond-UI-UIAnimationMixPlayer-CreateMixer0 = 1737,
		Beyond-UI-UIAnimationMixPlayer-CreateOutput0 = 1738,
		Beyond-UI-UIAnimationMixPlayer-CreateSourceFromAsset0 = 1739,
		Beyond-UI-UILoadImageSprite-set_spritePath0 = 1740,
		Beyond-UI-UILoadImageSprite-_LoadSprite0 = 1741,
		Beyond-UI-UILoadImageSprite-OnDestroy0 = 1744,
		Beyond-UI-UILoadImageSpriteByName-set_spriteName0 = 1745,
		Beyond-UI-UISwitchTween-BeforeShowEffect0 = 1746,
		Beyond-UI-UISwitchTween-BeforeHideEffect0 = 1747,
		Beyond-UI-UISwitchTween-AfterShowEffect0 = 1748,
		Beyond-UI-UISwitchTween-AfterHideEffect0 = 1749,
		Beyond-UI-UISwitchTween-ResetToState0 = 1750,
		Beyond-UI-UISwitchTween-Show0 = 1751,
		Beyond-UI-UISwitchTween-_ClearTweenInternal0 = 1752,
		Beyond-UI-UISwitchTween-TweenContext-OnReset0 = 1753,
		Beyond-UI-UISwitchTween-TweenContext-OnTweenStop0 = 1754,
		Beyond-UI-UISwitchTween-ClearTween0 = 1755,
		Beyond-UI-UISwitchTween-Hide0 = 1758,
		Beyond-UI-UISwitchTween-WaitForTweening0 = 1761,
		Beyond-UI-UISwitchTween-SetOptions0 = 1768,
		Beyond-UI-UISwitchTween-Reset0 = 1769,
		Beyond-UI-UISwitchTween-Clear0 = 1770,
		Beyond-UI-UISwitchTween-GetContext0 = 1771,
		Beyond-UI-UISwitchTween-TweenContext-IsInterapted0 = 1772,
		Beyond-UI-UISwitchTween-TweenWrapper-IsActive0 = 1773,
		Beyond-UI-UISwitchTween-TweenWrapper-IsPlaying0 = 1774,
		Beyond-UI-UISwitchTween-TweenWrapper-KillIfNecessary0 = 1775,
		Beyond-UI-UISwitchTween-TweenWrapper-OnComplete0 = 1776,
		Beyond-UI-UISwitchTween-TweenWrapper-SetAutoKill0 = 1777,
		Beyond-UI-FadeSwitchTween-set_activeAlpha0 = 1778,
		Beyond-UI-FadeSwitchTween-GenerateTweenOfHide0 = 1779,
		Beyond-UI-FadeSwitchTween-Durations-GetHideDuration0 = 1782,
		Beyond-UI-FadeSwitchTween-GenerateTweenOfShow0 = 1783,
		Beyond-UI-FadeSwitchTween-Durations-GetShowDuration0 = 1784,
		Beyond-UI-FadeSwitchTween-BeforeShowEffect0 = 1785,
		Beyond-UI-FadeSwitchTween-SetObjectActive0 = 1786,
		Beyond-UI-FadeSwitchTween-AfterHideEffect0 = 1789,
		Beyond-UI-FadeSwitchTween-ResetToState0 = 1790,
		Beyond-UI-FadeSwitchTween-Release0 = 1791,
		Beyond-UI-FadeSwitchTween-Builder-Build0 = 1792,
		Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfHide0 = 1796,
		Beyond-UI-FadeTranslationSwitchTween-_GetTargetAlpha0 = 1797,
		Beyond-UI-FadeTranslationSwitchTween-_GetTargetPos0 = 1798,
		Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfShow0 = 1799,
		Beyond-UI-FadeTranslationSwitchTween-BeforeShowEffect0 = 1800,
		Beyond-UI-FadeTranslationSwitchTween-AfterHideEffect0 = 1801,
		Beyond-UI-FadeTranslationSwitchTween-ResetToState0 = 1802,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-IsPlaying0 = 1803,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-KillIfNecessary0 = 1804,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-OnComplete0 = 1805,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-SetAutoKill0 = 1806,
		Beyond-UI-UIAtlasManager-OnInit0 = 1807,
		Beyond-UI-UIAtlasManager-_CreateTickFunction0 = 1808,
		Beyond-UI-UIAtlasManager-LateTick0 = 1809,
		Beyond-UI-UIAtlasManager-_ProcessRemoveQueue0 = 1810,
		Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRect0 = 1811,
		Beyond-UI-UIAtlasManager-_ProcessInsertQueue0 = 1814,
		Beyond-UI-UIAtlasManager-_IsRuntimeAtlasCompatible0 = 1815,
		Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRect0 = 1816,
		Beyond-UI-UIAtlasManager-UIAtlasPage-CopyIntoAtlas0 = 1817,
		Beyond-UI-UIAtlasManager-OnUnInit0 = 1818,
		Beyond-UI-UIAtlasManager-_ClearTickFunction0 = 1819,
		Beyond-UI-UIAtlasManager-Release0 = 1820,
		Beyond-UI-UIAtlasManager-GetAtlasCount0 = 1821,
		Beyond-UI-UIAtlasManager-UIAtlasHandle-IsValid0 = 1822,
		Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRects0 = 1823,
		Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRects0 = 1824,
		Beyond-UI-UIRedDotAnimation-Init0 = 1825,
		Beyond-UI-UIRedDotAnimation-_UpdateRedDotAnimation0 = 1826,
		Beyond-UI-UIRedDotAnimation-UnInit0 = 1827,
		Beyond-UI-UIRedDotAnimation-AddRedDotImage0 = 1828,
		Beyond-UI-UIRedDotAnimation-RemoveRedDotImage0 = 1829,
		Beyond-UI-UIRedDotAnimationNode-Awake0 = 1830,
		Beyond-UI-UIRedDotAnimationNode-OnEnable0 = 1831,
		Beyond-UI-UIRedDotAnimationNode-OnDisable0 = 1832,
		Beyond-UI-WebApplication-Start0 = 1833,
		Beyond-UI-WebApplication-StartHGBrowser0 = 1836,
		Beyond-UI-UIState-StateDescription-EqualsAnimation0 = 1839,
		Beyond-UI-UIState-StateDescription-EqualsAnimator0 = 1840,
		Beyond-UI-UIState-StateDescription-EqualsButton0 = 1841,
		Beyond-UI-UIState-StateDescription-EqualsCanvasGroup0 = 1842,
		Beyond-UI-UIState-StateDescription-EqualsComponent0 = 1843,
		Beyond-UI-UIState-StateDescription-get_ReadableDescription0 = 1844,
		Beyond-UI-UIState-UIStateControllerUtils-GetName0 = 1845,
		Beyond-UI-UIState-StateDescription-ToString0 = 1846,
		Beyond-UI-UIState-StateDescription-op_Equality0 = 1847,
		Beyond-UI-UIState-StateDescription-Equals0 = 1848,
		Beyond-UI-UIState-StateDescription-_EqualsByTargetType0 = 1849,
		Beyond-UI-UIState-StateDescription-EqualsGameObject0 = 1850,
		Beyond-UI-UIState-StateDescription-EqualsState0 = 1851,
		Beyond-UI-UIState-StateDescription-EqualsImage0 = 1852,
		Beyond-UI-UIState-StateDescription-EqualsText0 = 1853,
		Beyond-UI-UIState-StateDescription-EqualsRectTransform0 = 1854,
		Beyond-UI-UIState-StateDescription-EqualsLayoutElement0 = 1855,
		Beyond-UI-UIState-StateDescription-EqualsGraphic0 = 1856,
		Beyond-UI-UIState-StateDescription-EqualsLayoutGroup0 = 1857,
		Beyond-UI-UIState-StateDescription-EqualsScrollList0 = 1858,
		Beyond-UI-UIState-StateDescription-EqualsGridLayoutGroup0 = 1859,
		Beyond-UI-UIState-StateDescription-EqualsSelectable0 = 1860,
		Beyond-UI-UIState-StateDescription-op_Inequality0 = 1861,
		Beyond-UI-UIState-StateDescription-Equals1 = 1862,
		Beyond-UI-UIState-StateDescription-GetHashCode0 = 1863,
		Beyond-UI-UIState-StateDescription-_GetTargetHashCode0 = 1864,
		Beyond-UI-UIState-StateDescription-_OnGridLayoutGroupChanged0 = 1865,
		Beyond-UI-UIState-StateDescription-_OnImageChanged0 = 1866,
		Beyond-UI-UIState-StateDescription-_OnLayoutElementChanged0 = 1867,
		Beyond-UI-UIState-StateDescription-_OnLayoutGroupChanged0 = 1868,
		Beyond-UI-UIState-StateDescription-_OnRectTransformChanged0 = 1869,
		Beyond-UI-UIState-StateDescription-_OnScrollListChanged0 = 1870,
		Beyond-UI-UIState-StateDescription-_OnTextChanged0 = 1871,
		Beyond-UI-UIState-StateReference-HandleScheduledStates0 = 1872,
		Beyond-UI-UIState-UIStateController-Run0 = 1873,
		Beyond-UI-UIState-UIStateController-Stop0 = 1874,
		Beyond-UI-UIState-UIStateController-Tick0 = 1875,
		Beyond-UI-UIState-UIStateController-_HandleStateAnimations0 = 1876,
		Beyond-UI-GPUI-GPUPrefabData-CreateFontNode0 = 1880,
		Beyond-UI-GPUI-GPUPrefabDataLite-CreateFontNode0 = 1881,
		Beyond-UI-GPUI-GPUIHandle-Equals0 = 1882,
		Beyond-UI-GPUI-GPUIHandle-Equals1 = 1883,
		Beyond-UI-GPUI-GPUIHandle-GetHashCode0 = 1884,
		Beyond-UI-GPUI-GPUIHandle-op_Equality0 = 1885,
		Beyond-UI-GPUI-GPUIHandle-op_Inequality0 = 1886,
		Beyond-UI-GPUI-GPUISystem-get_fontAsset0 = 1887,
		Beyond-UI-GPUI-GPUISystem-GetFontAsset0 = 1888,
		Beyond-UI-GPUI-GPUISystem-set_fontAsset0 = 1889,
		Beyond-UI-GPUI-GPUISystem-CreateInstance0 = 1890,
		Beyond-UI-GPUI-GPUISystem-_CreateInstance0 = 1891,
		Beyond-UI-GPUI-GPUISystem-_GetOneHandle0 = 1892,
		Beyond-UI-GPUI-RuntimeInstance-Create0 = 1893,
		Beyond-UI-GPUI-InstanceBufferManager-Add0 = 1894,
		Beyond-UI-GPUI-GPUISystem-SetRootPosition0 = 1895,
		Beyond-UI-GPUI-GPUISystem-_IsHandleInvalid0 = 1896,
		Beyond-UI-GPUI-RuntimeInstance-SetPosition0 = 1897,
		Beyond-UI-GPUI-InstanceBufferManager-MarkNeedUpdate0 = 1898,
		Beyond-UI-GPUI-GPUISystem-DestroyInstance0 = 1899,
		Beyond-UI-GPUI-GPUISystem-_DestroyInstance0 = 1900,
		Beyond-UI-GPUI-InstanceBufferManager-Remove0 = 1901,
		Beyond-UI-GPUI-RuntimeInstance-Recycle0 = 1902,
		Beyond-UI-GPUI-GPUISystem-_RecycleOneHandle0 = 1903,
		Beyond-UI-GPUI-GPUISystem-IsInstanceValid0 = 1904,
		Beyond-UI-GPUI-GPUISystem-SetRootScale0 = 1905,
		Beyond-UI-GPUI-RuntimeInstance-SetRootScale0 = 1906,
		Beyond-UI-GPUI-GPUISystem-StartAnimation0 = 1907,
		Beyond-UI-GPUI-RuntimeInstance-StartAnimation0 = 1908,
		Beyond-UI-GPUI-GPUISystem-StartAnimation1 = 1909,
		Beyond-UI-GPUI-GPUISystem-SetVisibility0 = 1910,
		Beyond-UI-GPUI-GPUISystem-SetColor0 = 1911,
		Beyond-UI-GPUI-RuntimeInstance-SetColor0 = 1912,
		Beyond-UI-GPUI-GPUIUtils-ColorToRGBAUint320 = 1913,
		Beyond-UI-GPUI-GPUISystem-SetText0 = 1914,
		Beyond-UI-GPUI-RuntimeInstance-SetText0 = 1915,
		Beyond-UI-GPUI-GPUISystem-OnDestroy0 = 1916,
		Beyond-UI-GPUI-GPUISystem-_DoOnDestroy0 = 1917,
		Beyond-UI-GPUI-InstanceBufferManager-Dispose0 = 1918,
		Beyond-UI-GPUI-GPUISystem-_CleanMaterials0 = 1919,
		Beyond-UI-GPUI-GPUISystem-OnEnable0 = 1920,
		Beyond-UI-GPUI-GPUISystem-_PreWillRenderCanvases0 = 1921,
		Beyond-UI-GPUI-GPUISystem-_DoLateUpdate0 = 1922,
		Beyond-UI-GPUI-GPUISystem-_DestroyAnimatedInstance0 = 1923,
		Beyond-UI-GPUI-InstanceBufferManager-DoUpdate0 = 1924,
		Beyond-UI-GPUI-InstanceBufferManager-_FillInstanceQueue0 = 1925,
		Beyond-UI-GPUI-InstanceBufferManager-_AllocBuffer0 = 1926,
		Beyond-UI-GPUI-RuntimeInstance-DoUpdate0 = 1927,
		Beyond-UI-GPUI-GPUISystem-_RenderNodes0 = 1928,
		Beyond-UI-GPUI-InstanceBufferManager-get_gpuGroups0 = 1929,
		Beyond-UI-GPUI-GPUISystem-_UpdateWorldMat0 = 1930,
		Beyond-UI-GPUI-GPUISystem-_Init0 = 1931,
		Beyond-UI-GPUI-GPUISystem-_InitMaterials0 = 1932,
		Beyond-UI-GPUI-GPUISystem-_PreloadTextInGroupData0 = 1933,
		Beyond-UI-GPUI-InstanceBufferManager-BindInstanceList0 = 1934,
		Beyond-UI-GPUI-GPUISystem-_LoadGroupData0 = 1935,
		Beyond-UI-GPUI-GPUISystem-_LoadPrefabData0 = 1936,
		Beyond-UI-GPUI-GPUISystem-_LoadPrefabNodeBuffer0 = 1937,
		Beyond-UI-GPUI-GPUISystem-_RefreshMaterials0 = 1938,
		Beyond-UI-GPUI-GPUISystem-OnDisable0 = 1939,
		Beyond-UI-GPUI-GPUISystem-OnPopulateMesh0 = 1940,
		Beyond-UI-GPUI-GPUISystem-UpdateMaterial0 = 1941,
		Beyond-UI-GPUI-GPUIUtils-CreateQuadMesh0 = 1942,
		Beyond-UI-GPUI-RuntimeInstance-SetVisibility0 = 1943,
		Beyond-UI-GPUI-CodePoint-ConvertToUTF320 = 1944
	}
}
