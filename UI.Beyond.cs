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

// Image 15: UI.Beyond.dll - Assembly: UI.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 50201-50614
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Beyond.Editor")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

public class UIMinSizeAdjust : MonoBehaviour // TypeDefIndex: 50202
{
	// Fields
	[FormerlySerializedAs("m_panelRect")]
	[SerializeField]
	private RectTransform _panelRect; // 0x18

	// Constructors
	public UIMinSizeAdjust(); // 0x0000000185393520-0x0000000185393538

	// Methods
	private void Start(); // 0x000000018B08A864-0x000000018B08A86C
	private void _SetTextureScaleByWidth(); // 0x000000018B08A86C-0x000000018B08AA74
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 50610
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_24 FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE; // 0x00 // Static value (base64): AAAAAAEAAAACAAAAAAAAAAIAAAADAAAA - Metadata: 0x0232FF8C

	// Nested types
	private struct __StaticArrayInitTypeSize_24 // TypeDefIndex: 50609
	{
	}
}

namespace Beyond.Gameplay.UI
{
	public class UIScrollCellCircleEffect : TickableUIMono // TypeDefIndex: 50212
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
		[CompilerGenerated]
		private Transform _lookAtCamera_k__BackingField; // 0x98
		private bool m_left; // 0xA0
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B08B848-0x000000018B08B894 
		public LuaPanel panel { get; } // 0x000000018B08B788-0x000000018B08B848 
		public Transform lookAtCamera { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85EE0-0x0000000184D85EF0 0x0000000186352D0C-0x0000000186352D20
	
		// Constructors
		public UIScrollCellCircleEffect(); // 0x000000018B08B778-0x000000018B08B788
	
		// Methods
		private void _InitState(); // 0x000000018B08B2DC-0x000000018B08B3A0
		private void _UpdatePos(); // 0x000000018B08B5B8-0x000000018B08B778
		private void _UpdateLookAtCamera(); // 0x000000018B08B3A0-0x000000018B08B5B8
		public void SetLookAtCamera(Transform faceCamera, bool update = true /* Metadata: 0x0232F986 */); // 0x000000018B08B13C-0x000000018B08B1D8
		protected override void OnEnable(); // 0x000000018B08B0E4-0x000000018B08B13C
		private void Start(); // 0x000000018B08B1D8-0x000000018B08B280
		public override void Tick(float deltaTime); // 0x000000018B08B280-0x000000018B08B2DC
		public void ForceUpdate(); // 0x000000018B08B038-0x000000018B08B088
		public override void LateTick(float deltaTime); // 0x000000018B08B088-0x000000018B08B0E4
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class UIScrollCellSlantEffect : TickableUIMono // TypeDefIndex: 50213
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
		protected override TickType tickOption { get; } // 0x0000000184A79630-0x0000000184A79660 
	
		// Constructors
		public UIScrollCellSlantEffect(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		public override void Tick(float deltaTime); // 0x000000018364C480-0x000000018364C760
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_UI_Beyond // TypeDefIndex: 50210
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime(); // 0x0000000184CB6B40-0x0000000184CB6B70
		private static void Initialize(); // 0x0000000184CB6B70-0x0000000184CB6C20
	}
}

namespace Beyond.Scripts.UI.Tools
{
	[RequireComponent(typeof(GridLayoutGroup))]
	public class UIGridLayoutElement : MonoBehaviour, ILayoutElement // TypeDefIndex: 50211
	{
		// Fields
		private GridLayoutGroup m_gridLayoutGroup; // 0x18
	
		// Properties
		public float minWidth { get; } // 0x000000018B0884B4-0x000000018B088564 
		public float preferredWidth { get; } // 0x000000018B088614-0x000000018B0886C4 
		public float flexibleWidth { get; } // 0x000000018B088368-0x000000018B0883B8 
		public float minHeight { get; } // 0x000000018B088404-0x000000018B0884B4 
		public float preferredHeight { get; } // 0x000000018B088564-0x000000018B088614 
		public float flexibleHeight { get; } // 0x000000018B088318-0x000000018B088368 
		public int layoutPriority { get; } // 0x000000018B0883B8-0x000000018B088404 
	
		// Constructors
		public UIGridLayoutElement(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void CalculateLayoutInputHorizontal(); // 0x000000018B08807C-0x000000018B0880BC
		public void CalculateLayoutInputVertical(); // 0x000000018B0880BC-0x000000018B0880FC
		private float _GetPreferredSize(bool widthOrHeight); // 0x000000018B0880FC-0x000000018B088318
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 50205
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 50206
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 50207
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 50208
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 50209
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Beyond.UI
{
	[AddComponentMenu("UI/UIText", 100)]
	public class UIText : TextMeshProUGUI, IPointerClickHandler, IUIClearable, ISerializationCallbackReceiver, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 50230
	{
		// Fields
		public RichTextStyleSeq richTextStyleSeq; // 0xBC8
		private bool m_textHasHyperlink; // 0xBCC
		private static readonly Regex RICH_TEXT_INNERMOST_REGEX; // 0x00
		private const int RICH_TEXT_RESOLVE_MAX_ITERATIONS = 128; // Metadata: 0x0232F987
		private static readonly Regex HYPERLINK_TEXT_REGEX; // 0x08
		private static readonly Regex PHONETIC_REGEX; // 0x10
		public const string HYPERLINK_ID_PREFIX = "HPLK_"; // Metadata: 0x0232F989
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
		public bool useMinMaxSize; // 0xC60
		public Vector2 maxSize; // 0xC64
		public Vector2 minSize; // 0xC6C
		private readonly Queue<GameObject> m_inlineImagePool; // 0xC78
		private readonly Dictionary<int, ImageGOInfo> m_indexToImageGo; // 0xC80
		private const string INLINE_IMAGE_FOLDER_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/"; // Metadata: 0x0232F98F
		private const string KEY_HINT_ICON_COMMON_FOLDER = "Assets/Beyond/InitialAssets/UI/Sprites/"; // Metadata: 0x0232F9C0
		private readonly Dictionary<string, FAssetProxyHandle> m_imageCache; // 0xC88
		private readonly Dictionary<int, bool> m_delayedActiveChangeImageGOIndexes; // 0xC90
	
		// Properties
		public string textId { get; } // 0x000000018B08EF14-0x000000018B08EF60 
		public override string text { get; set; } // 0x0000000183E60EB0-0x0000000183E60F20 0x0000000183E866B0-0x0000000183E86700
		private RichTextAnalyzer.ProcessRichTextEntryFunc processRichTextEntryFunc { get; } // 0x0000000182F27B70-0x0000000182F27C70 
		public LuaPanel panel { get; } // 0x000000018B08EE54-0x000000018B08EF14 
		public override TMP_FontAsset m_fontAsset { get; set; } // 0x000000018351DFC0-0x000000018351E150 0x000000018B08F018-0x000000018B08F1C4
		public override Material fontSharedMaterial { get; set; } // 0x00000001840B60F0-0x00000001840B6120 0x000000018B08EF60-0x000000018B08F018
	
		// Nested types
		private abstract class RichTextInfo // TypeDefIndex: 50214
		{
			// Fields
			public int index; // 0x10
	
			// Constructors
			protected RichTextInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class InlineImageInfo : RichTextInfo // TypeDefIndex: 50215
		{
			// Fields
			public string path; // 0x18
			public float width; // 0x20
			public float height; // 0x24
			public UnityEngine.Color color; // 0x28
	
			// Constructors
			public InlineImageInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private enum RichTextTagType // TypeDefIndex: 50216
		{
			Image = 1,
			Width = 2,
			Height = 3,
			Scale = 4,
			Color = 5
		}
	
		public enum RichTextStyleSeq // TypeDefIndex: 50217
		{
			NORMAL = 0,
			DARK_BACKGROUND = 1,
			LIGHT_BACKGROUND = 2
		}
	
		private static class RichTextAnalyzer // TypeDefIndex: 50223
		{
			// Fields
			private const char CUSTOM_RICH_TEXT_LEFT_BRACKET = '<'; // Metadata: 0x0232F9F0
			private const char CUSTOM_RICH_TEXT_RIGHT_BRACKET = '>'; // Metadata: 0x0232F9F2
			private static readonly Dictionary<int, RichTextTag> s_tagToTypeDic; // 0x00
			private static readonly Dictionary<int, RichTextTag> s_tagAttributeToTypeDic; // 0x08
			public const string FONT_SHADOW_OPENING_TAG = "<shadow>"; // Metadata: 0x0232F9F4
			public const string FONT_SHADOW_CLOSING_TAG = "</shadow>"; // Metadata: 0x0232F9FD
			public const string FONT_MAT_OPENING_TAG = "<material=\"DefaultFont_3500_RichText_Shadow\">"; // Metadata: 0x0232FA07
			public const string FONT_MAT_CLOSING_TAG = "</material>"; // Metadata: 0x0232FA35
			private static readonly List<RichTextParam> s_subParams; // 0x10
	
			// Nested types
			public enum ParamValueType // TypeDefIndex: 50218
			{
				None = 0,
				String = 1,
				Int = 2,
				Float = 3,
				Color = 4
			}
	
			public struct RichTextTag // TypeDefIndex: 50219
			{
				// Fields
				public RichTextTagType richTextTagType; // 0x00
				public Beyond.UI.UIText.RichTextAnalyzer.ParamValueType paramValueType; // 0x04
			}
	
			public struct RichTextParam // TypeDefIndex: 50220
			{
				// Fields
				public RichTextTagType richTextTagType; // 0x00
				public AnyTypeStruct value; // 0x08
			}
	
			public struct AnyTypeStruct // TypeDefIndex: 50221
			{
				// Fields
				public int intValue; // 0x00
				public float floatValue; // 0x00
				public string stringValue; // 0x00
				public UnityEngine.Color colorValue; // 0x00
			}
	
			public delegate RichTextInfo ProcessRichTextEntryFunc(RichTextParam mainParam, List<RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder); // TypeDefIndex: 50222; 0x00000001862213C0-0x00000001862213F8
	
			// Constructors
			static RichTextAnalyzer(); // 0x0000000184865A10-0x0000000184865D10
	
			// Methods
			public static string PreAnalyzeRichText(string text, bool needParseActionId); // 0x0000000182F27A80-0x0000000182F27B70
			public static string AnalyzeRichText(string text, ProcessRichTextEntryFunc processFunc, out List<RichTextInfo> infos); // 0x0000000182F27370-0x0000000182F27920
			private static bool _TryParseRichTextEntry(ReadOnlySpan<char> span, ref Utf16ValueStringBuilder stringBuilder, ProcessRichTextEntryFunc processFunc, out RichTextInfo richTextInfo); // 0x0000000183524C70-0x0000000183524E40
			private static bool _TryParseParam(ReadOnlySpan<char> span, out bool isMain, out RichTextParam param); // 0x00000001835248E0-0x0000000183524C70
			public static RichTextInfo ProcessRichTextEntryFallback(RichTextParam mainParam, List<RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder); // 0x000000018B087480-0x000000018B0874FC
			public static int GetCharacterCountWithoutRichText(ReadOnlySpan<char> str); // 0x000000018B087214-0x000000018B087480
			private static int _GetHashCode(ReadOnlySpan<char> str); // 0x0000000183525BA0-0x0000000183525C10
		}
	
		private class HyperlinkUITextWrap // TypeDefIndex: 50224
		{
			// Fields
			public UIText uiText; // 0x10
			public string hyperlinkUITextGroupId; // 0x18
			public int order; // 0x20
			public bool isDisplayable; // 0x24
	
			// Constructors
			public HyperlinkUITextWrap(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Clear(); // 0x000000018B08693C-0x000000018B0869D4
		}
	
		private class HyperlinkUITextGroup // TypeDefIndex: 50225
		{
			// Fields
			public HashSet<HyperlinkUITextWrap> wrapSet; // 0x10
			public string groupId; // 0x18
			public int displayableCount; // 0x20
	
			// Constructors
			public HyperlinkUITextGroup(); // 0x000000018B086094-0x000000018B086134
	
			// Methods
			public void Add(HyperlinkUITextWrap wrap); // 0x000000018B085D58-0x000000018B085DF4
			public void Remove(HyperlinkUITextWrap wrap); // 0x000000018B085E78-0x000000018B085F14
			public void ChangeDisplayable(HyperlinkUITextWrap wrap, bool displayable); // 0x000000018B085DF4-0x000000018B085E78
			private void _AddDisplayableCount(); // 0x000000018B085F14-0x000000018B085F70
			private void _SubDisplayableCount(); // 0x000000018B08603C-0x000000018B086094
			private void _NotifyDisplayableChanged(); // 0x000000018B085F70-0x000000018B08603C
		}
	
		private class HyperlinkUITextManager // TypeDefIndex: 50227
		{
			// Fields
			private Dictionary<string, HyperlinkUITextGroup> m_hyperlinkUITextGroupMap; // 0x10
			private ObjectPool<HyperlinkUITextGroup> m_hyperlinkUITextGroupPool; // 0x18
			private ObjectPool<HyperlinkUITextWrap> m_hyperlinkUITextWrapPool; // 0x20
			private static HyperlinkUITextManager s_instance; // 0x00
			private static readonly List<HyperlinkUITextWrap> SORT_WRAP_TEMP_LIST; // 0x08
	
			// Properties
			public static HyperlinkUITextManager instance { get; } // 0x000000018351CAF0-0x000000018351CC20 
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 50226
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Comparison<HyperlinkUITextWrap> __9__13_0; // 0x08
				public static Action<HyperlinkUITextGroup> __9__16_0; // 0x10
				public static Action<HyperlinkUITextWrap> __9__16_1; // 0x18
	
				// Constructors
				static __c(); // 0x0000000184D47110-0x0000000184D47170
				public __c(); // 0x00000001841E1670-0x00000001841E1680
	
				// Methods
				internal int _GetGroupDisplayableUIText_b__13_0(HyperlinkUITextWrap a, HyperlinkUITextWrap b); // 0x000000018B0875DC-0x000000018B0876FC
				internal void _.ctor_b__16_0(HyperlinkUITextGroup group); // 0x000000018B0876FC-0x000000018B087750
				internal void _.ctor_b__16_1(HyperlinkUITextWrap wrap); // 0x000000018B087750-0x000000018B087770
			}
	
			// Constructors
			public HyperlinkUITextManager(); // 0x00000001848F8260-0x00000001848F8550
			static HyperlinkUITextManager(); // 0x0000000184D12770-0x0000000184D12810
	
			// Methods
			public void AddWrap(UIText uiText, string groupId, int order); // 0x000000018B086134-0x000000018B086280
			public void RemoveWrap(UIText uiText); // 0x000000018351CC20-0x000000018351CC90
			public void ChangeWrapGroup(HyperlinkUITextWrap wrap, string newGroupId, int newOrder); // 0x000000018B086280-0x000000018B0863E4
			public void ChangeWrapOrder(HyperlinkUITextWrap wrap, int newOrder); // 0x000000018B0863E4-0x000000018B086450
			public void UpdateWrapDisplayable(UIText uiText); // 0x000000018351D8E0-0x000000018351D9E0
			public bool IsGroupDisplayable(string groupId); // 0x000000018390F700-0x000000018390F750
			public List<UIText> GetGroupDisplayableUIText(string groupId); // 0x000000018B086450-0x000000018B08693C
			private HyperlinkUITextGroup _GetGroup(string groupId, bool autoCreate = false /* Metadata: 0x0232FA46 */); // 0x000000018390F750-0x000000018390F810
			private bool _IsUITextDisplayable(UIText uiText); // 0x000000018351D9E0-0x000000018351DA80
		}
	
		private struct ImageGOInfo // TypeDefIndex: 50228
		{
			// Fields
			public GameObject go; // 0x00
			public RectTransform rectTransform; // 0x08
			public Image image; // 0x10
		}
	
		[CompilerGenerated]
		private sealed class __DelayedChangeActiveImageGo_d__116 : IEnumerator<object> // TypeDefIndex: 50229
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIText __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __DelayedChangeActiveImageGo_d__116(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B087BB0-0x000000018B087DD8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B087DD8-0x000000018B087E24
		}
	
		// Constructors
		public UIText(); // 0x0000000183695650-0x0000000183695970
		static UIText(); // 0x000000018432B870-0x000000018432BAC0
	
		// Methods
		public void SetAndResolveTextStyle(string targetText); // 0x0000000184488730-0x00000001844887F0
		public static string GetPhoneticText(PhoneticType phoneticType, string id); // 0x0000000183D2B040-0x0000000183D2B190
		public void SetPhoneticText(PhoneticType phoneticType, string id); // 0x0000000183D2AFD0-0x0000000183D2B040
		private static string _ResolveTextStyle(string text, int richSeqIndex); // 0x00000001835CCDD0-0x00000001835CD250
		private static string _GetHyperlinkText(string text, out bool hasLink); // 0x000000018B08D7C4-0x000000018B08DFB8
		public static void OnEnvLangChanged(EnvLang lang); // 0x0000000183329F10-0x0000000183329FE0
		private void _CreateUpdateFunction(); // 0x000000018382AA20-0x000000018382AB40
		private void _ReleaseUpdateFunction(); // 0x0000000183519BC0-0x0000000183519C60
		public override void ClearMesh(); // 0x00000001844042B0-0x0000000184404550
		public override void RefreshPopulateText(); // 0x0000000182F27920-0x0000000182F27A80
		protected override Material LoadMaterial(string materialName); // 0x000000018B08BE40-0x000000018B08BF4C
		protected override void OnDestroy(); // 0x0000000183519750-0x00000001835197A0
		protected override void Awake(); // 0x000000018351DDA0-0x000000018351DEC0
		protected TMP_FontAsset GetFontAsset(); // 0x000000018351E150-0x000000018351E1B0
		private void _GenerateRuntimeText(); // 0x000000018351DEC0-0x000000018351DFC0
		private void _ProcessRichTextInfo(); // 0x0000000182F27C70-0x0000000182F27FA0
		private void _OnPreRenderText(TMP_TextInfo textInfo); // 0x0000000184006240-0x0000000184006800
		private RichTextInfo _ProcessRichTextEntry(RichTextAnalyzer.RichTextParam mainParam, List<RichTextAnalyzer.RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder); // 0x000000018B08E398-0x000000018B08E9CC
		public void OnPointerClick(PointerEventData eventData); // 0x000000018B08C134-0x000000018B08C5C0
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018B08C5C0-0x000000018B08C6AC
		public void OnPointerExit(PointerEventData eventData); // 0x000000018B08C6AC-0x000000018B08C808
		protected override void Start(); // 0x0000000184128720-0x0000000184128750
		protected override void OnEnable(); // 0x000000018351C9B0-0x000000018351CA30
		protected override void OnDisable(); // 0x0000000183519820-0x0000000183519BC0
		private void _UpdateTick(float deltaTime); // 0x000000018B08EA88-0x000000018B08EE54
		public void ShrinkLinkTags(); // 0x000000018B08CB18-0x000000018B08CE90
		[IDTag(0)]
		public bool TryGetLinkId(Vector3 position, out string linkId); // 0x000000018B08D1D0-0x000000018B08D3BC
		[IDTag(1)]
		public bool TryGetLinkId(int linkIndex, out string linkId); // 0x000000018B08D3BC-0x000000018B08D518
		public bool TryGetOriginalLinkId(string linkId, out string originalLinkId); // 0x000000018B08D518-0x000000018B08D5F8
		public bool TryGetCharacterStartPosAndHeight(int charIndex, out Vector3 worldPos, out float charHeight); // 0x000000018B08D030-0x000000018B08D1D0
		public bool TryGetCharacterEndPosAndHeight(int charIndex, out Vector3 worldPos, out float charHeight); // 0x000000018B08CE90-0x000000018B08D030
		public void CombineStringWithLanguageSpilt<T1, T2>(T1 t1, T2 t2);
		public void CombineStringWithLanguageSpilt(string t1, string t2); // 0x000000018B08BA94-0x000000018B08BB40
		public void CombineStringReverseForIndonesianAndVietnamese<T1, T2>(T1 t1, T2 t2);
		public void CombineStringReverseForIndonesianAndVietnamese(string t1, string t2); // 0x000000018B08B9E8-0x000000018B08BA94
		public void SetHyperlinkUITextGroup(string groupId, int order); // 0x000000018B08C808-0x000000018B08C964
		public static bool IsHyperlinkUITextGroupDisplayable(string groupId); // 0x000000018390F680-0x000000018390F700
		public static List<UIText> GetGroupDisplayableHyperlinkUIText(string groupId); // 0x000000018B08BB40-0x000000018B08BBC8
		public void ClearComponent(); // 0x000000018351CA30-0x000000018351CAF0
		public void UpdateI18NFontAsset(); // 0x000000018B08D6A0-0x000000018B08D738
		private void _RefreshMatTexture(); // 0x000000018351EA50-0x000000018351ECB0
		protected override void SetSharedMaterial(Material mat); // 0x000000018B08C964-0x000000018B08CB18
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x0000000183F709E0-0x0000000183F70A70
		public void OnAfterDeserialize(); // 0x0000000184032550-0x00000001840325B0
		protected override TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference); // 0x000000018B08B894-0x000000018B08B9E8
		public static string LocalStringCombineFormat(int count); // 0x000000018B08BF4C-0x000000018B08C134
		protected override Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled); // 0x0000000183E64370-0x0000000183E64410
		protected Sprite GetOrLoadSprite(string path); // 0x000000018B08BBC8-0x000000018B08BE40
		protected void DisposeInlineImageCache(); // 0x000000018351D600-0x000000018351D8E0
		private void _ClearInlineImage(); // 0x0000000182F27FA0-0x0000000182F283E0
		private ImageGOInfo _GetImageGoByIndex(int index); // 0x000000018B08DFB8-0x000000018B08E190
		private GameObject _GetOrCreateImageGO(); // 0x000000018B08E190-0x000000018B08E398
		private void _ReturnImageGO(GameObject go); // 0x000000018B08E9CC-0x000000018B08EA88
		[IteratorStateMachine(typeof(__DelayedChangeActiveImageGo_d__116))]
		private IEnumerator _DelayedChangeActiveImageGo(); // 0x000000018B08D738-0x000000018B08D7C4
		public string __iFixBaseProxy_get_text(); // 0x000000018B08D688-0x000000018B08D690
		public void __iFixBaseProxy_set_text(string P0); // 0x000000018B08D698-0x000000018B08D6A0
		public void __iFixBaseProxy_ClearMesh(); // 0x000000018B08D658-0x000000018B08D660
		public void __iFixBaseProxy_RefreshPopulateText(); // 0x000000018B08D678-0x000000018B08D680
		public Material __iFixBaseProxy_LoadMaterial(string P0); // 0x00000001811EC580-0x00000001811EC590
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B08D660-0x000000018B08D668
		public void __iFixBaseProxy_Awake(); // 0x000000018B08D638-0x000000018B08D640
		public void __iFixBaseProxy_Start(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B08D670-0x000000018B08D678
		public void __iFixBaseProxy_OnDisable(); // 0x000000018B08D668-0x000000018B08D670
		public TMP_FontAsset __iFixBaseProxy_get_m_fontAsset(); // 0x0000000184D8D1B0-0x0000000184D8D1C0
		public void __iFixBaseProxy_set_m_fontAsset(TMP_FontAsset P0); // 0x0000000185397170-0x0000000185397184
		public Material __iFixBaseProxy_get_fontSharedMaterial(); // 0x0000000184D8D910-0x0000000184D8D920
		public void __iFixBaseProxy_set_fontSharedMaterial(Material P0); // 0x000000018B08D690-0x000000018B08D698
		public void __iFixBaseProxy_SetSharedMaterial(Material P0); // 0x000000018B08D680-0x000000018B08D688
		public TMP_SubMeshUI __iFixBaseProxy_AddSubTextObject(TextMeshProUGUI P0, MaterialReference P1); // 0x000000018B08D5F8-0x000000018B08D638
		public Vector2 __iFixBaseProxy_CalculatePreferredValues(ref float P0, Vector2 P1, bool P2, bool P3); // 0x000000018B08D640-0x000000018B08D658
	}

	public static class UIConst // TypeDefIndex: 50233
	{
		// Fields
		public const float PC_REFERENCE_RESOLUTION_SCALE = 1.25f; // Metadata: 0x0232FA47
		public const float MOBILE_PAD_DEVICE_REFERENCE_RESOLUTION_SCALE = 1.1f; // Metadata: 0x0232FA4B
		public static readonly Vector3 OUT_OF_SCREEN_POS; // 0x00
		public const float STANDARD_HORIZONTAL_RESOLUTION = 1920f; // Metadata: 0x0232FA4F
		public const float STANDARD_VERTICAL_RESOLUTION = 1080f; // Metadata: 0x0232FA53
		public const int INVALID_FINGER_ID = 2147483647; // Metadata: 0x0232FA57
		public static float STANDARD_RATIO; // 0x0C
		public const float SCREEN_SPACE_CAMERA_PANEL_DISTANCE = 30f; // Metadata: 0x0232FA58
		public const string UI_BLUR_MATERIAL = "Assets/Beyond/Arts/UI/Materials/M_ui_blur.mat"; // Metadata: 0x0232FA5C
		public const string CS_POPUP_PANEL_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/CSPrefabs/CSPopupPanel.prefab"; // Metadata: 0x0232FA8A
		public const string NAVIGATION_TARGET_CLICK_NO_HINT_ACTION_ID = "navigation_target_click_no_hint"; // Metadata: 0x0232FAD1
		public const string NAVIGATION_TARGET_CLICK_ACTION_ID = "navigation_target_click"; // Metadata: 0x0232FAF1
		public const string UI_SPRITE_CHAR_HEAD_RECTANGLE = "CharIcon"; // Metadata: 0x0232FB09
		public const string UI_SPRITE_CHAR_REMOTE_ICON = "CharRemoteIcon"; // Metadata: 0x0232FB12
		public const string UI_SPRITE_CHAR_REMOTE_ICON_700 = "CharRemoteIcon700"; // Metadata: 0x0232FB21
		public const string UI_SPRITE_DIALOG_BG = "Dialog/BG"; // Metadata: 0x0232FB33
		public const string UI_SPRITE_DIALOG_OPTION_ICON = "Dialog/Option"; // Metadata: 0x0232FB3D
		public const string SLIDER_STICK_SCROLL_HORI_ACTION_ID = "slider_stick_scroll_hori"; // Metadata: 0x0232FB4B
	
		// Properties
		public static int STANDARD_HORIZONTAL_RESOLUTION_INT { get; } // 0x000000018B087F6C-0x000000018B087FB8 
		public static int STANDARD_VERTICAL_RESOLUTION_INT { get; } // 0x000000018B087FB8-0x000000018B088004 
		public static float CUR_STANDARD_HORIZONTAL_RESOLUTION { get; } // 0x0000000183C00930-0x0000000183C009A0 
		public static float CUR_STANDARD_VERTICAL_RESOLUTION { get; } // 0x0000000183C008C0-0x0000000183C00930 
		public static int dragThreshold { get; } // 0x000000018B088004-0x000000018B08807C 
	
		// Nested types
		public enum AnimationState // TypeDefIndex: 50231
		{
			Stop = 1,
			In = 2,
			Loop = 3,
			Out = 4,
			InEasing = 5,
			Others = 6
		}
	
		public enum CommonUISegment // TypeDefIndex: 50232
		{
			InteractiveEntity = 1,
			LevelScriptModule = 2
		}
	
		// Constructors
		static UIConst(); // 0x0000000184D3A030-0x0000000184D3A0A0
	
		// Methods
		public static float GetResolutionScale(); // 0x0000000183C004D0-0x0000000183C00520
		public static bool IsPadDevice(); // 0x000000018B087E24-0x000000018B087F6C
	}

	public class UIModelLoader : IDisposable // TypeDefIndex: 50235
	{
		// Fields
		private Dictionary<GameObject, FAssetProxyHandle> m_instance2AssetHandle; // 0x10
		private int m_requestCounter; // 0x18
		private HashSet<int> m_requestIds; // 0x20
		private bool m_disposed; // 0x28
		private static List<MagicaBoneCloth> s_magicaBoneCloths; // 0x00
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 50234
		{
			// Fields
			public UIModelLoader __4__this; // 0x10
			public int requestId; // 0x18
			public FAssetProxyHandle handle; // 0x1C
			public string modelPath; // 0x30
			public Transform parent; // 0x38
			public Action<GameObject> callback; // 0x40
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _LoadModelAsync_b__0(FAssetProxyUntrackedHandle proxy); // 0x000000018B087770-0x000000018B087BB0
		}
	
		// Constructors
		public UIModelLoader(); // 0x00000001840E52D0-0x00000001840E53A0
		static UIModelLoader(); // 0x0000000184D16830-0x0000000184D168C0
	
		// Methods
		public GameObject LoadModel(string modelPath, Transform parent); // 0x000000018B08ACE0-0x000000018B08AEC0
		public int LoadModelAsync(string modelPath, Transform parent, Action<GameObject> callback); // 0x000000018B08AAFC-0x000000018B08ACE0
		public void Cancel(int requestId); // 0x000000018B08AA74-0x000000018B08AAFC
		public void UnloadModel(GameObject modelGo); // 0x000000018B08AEC0-0x000000018B08B038
		private void _Clear(); // 0x0000000182F65460-0x0000000182F659E0
		public void Dispose(); // 0x0000000182F65420-0x0000000182F65460
	}

	public static class UIUtils // TypeDefIndex: 50236
	{
		// Fields
		private const int MAX_SHARED_INT_STRING = 255; // Metadata: 0x0232FB6C
		private static readonly string[] s_sharedIntStringPool; // 0x00
		private const int MAX_SHARED_INT_ROMAN_STRING = 16; // Metadata: 0x0232FB6E
		private static readonly string[] s_sharedIntStringRomanPool; // 0x08
		private static Vector3[] s_worldCorners; // 0x10
		private const string RICH_TEXT_PATTERN = "<.*?>"; // Metadata: 0x0232FB6F
	
		// Constructors
		static UIUtils(); // 0x0000000184CB4840-0x0000000184CB4930
	
		// Methods
		public static string GetSharedIntString(int value); // 0x0000000183848850-0x0000000183848960
		public static string GetSharedIntStringRoman(int value); // 0x000000018B08F9E8-0x000000018B08FB64
		[IDTag(0)]
		public static bool IsScreenPosInRectTransform(Vector3 screenPos, RectTransform rectTransform, Camera uiCamera); // 0x0000000183098A60-0x0000000183098CB0
		[IDTag(1)]
		public static bool IsScreenPosInRectTransform(Vector2 screenPos, RectTransform rectTransform, Camera uiCamera); // 0x000000018B08FB64-0x000000018B08FCF8
		public static Bounds CalcBoundOfRectTransform(RectTransform transform, RectTransform local); // 0x000000018B08F1C4-0x000000018B08F510
		public static bool TryGetTouch(int touchId, out UnityEngine.InputSystem.EnhancedTouch.Touch touch); // 0x000000018B09019C-0x000000018B0903B8
		public static void ClearUIComponents(GameObject gameObject); // 0x00000001832EE4D0-0x00000001832EE8F0
		public static Rect RectTransformToScreenRect(RectTransform rectTransform, Camera uiCamera); // 0x000000018B08FCF8-0x000000018B08FF14
		public static Vector2 ClampPointInRectTransform(RectTransform source, RectTransform target, Vector2 sourcePoint); // 0x000000018B08F510-0x000000018B08F6CC
		public static Vector3 GetNodeScaleOffset(RectTransform referenceTransform, RectTransform selfTransform); // 0x000000018468BDB0-0x000000018468BF10
		public static UnityEngine.Color GetColorByString(string strColor); // 0x000000018B08F6CC-0x000000018B08F8E8
		public static float GetCursorTipOffsetX(float defaultOffset); // 0x000000018B08F940-0x000000018B08F9E8
		public static float GetCursorTipOffsetInScreen(float defaultOffsetInScreen); // 0x000000018B08F8E8-0x000000018B08F940
		public static bool TryGetTextWithoutRichStyle(string richText, out string rawText); // 0x000000018B090080-0x000000018B09019C
	
		// Extension methods
		public static void SetAlpha(this Graphic image, float alpha); // 0x00000001830477E0-0x0000000183047890
		public static void SetColorWithoutAlpha(this Graphic image, UnityEngine.Color color); // 0x000000018B08FF14-0x000000018B08FFAC
		public static void SetMaskRatio(this RectMask2D mask, float r); // 0x000000018B08FFAC-0x000000018B090080
	}

	public class ActiveSyncHelper : MonoBehaviour // TypeDefIndex: 50237
	{
		// Fields
		[SerializeField]
		private List<GameObject> _objs; // 0x18
		[SerializeField]
		private bool _isInverse; // 0x20
	
		// Constructors
		public ActiveSyncHelper(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		private void Awake(); // 0x000000018378E780-0x000000018378E7C0
		private void OnEnable(); // 0x000000018378EBC0-0x000000018378EC00
		private void OnDisable(); // 0x000000018378EB80-0x000000018378EBC0
		public void Sync(); // 0x000000018378F030-0x000000018378F250
	}

	public class Billboard : TickableUIMono // TypeDefIndex: 50238
	{
		// Fields
		public Camera sceneCamera; // 0x68
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B084F50-0x000000018B084FA0 
	
		// Constructors
		public Billboard(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		protected override void OnEnable(); // 0x000000018B084DC4-0x000000018B084E70
		public override void Tick(float deltaTime); // 0x000000018B084E70-0x000000018B084F50
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	[AddComponentMenu("")]
	[ExecuteAlways]
	[SaveDuringPlay]
	public class CinemachineGyroscopeEffect : CinemachineExtension // TypeDefIndex: 50239
	{
		// Fields
		public float offsetX; // 0x28
		public float offsetY; // 0x2C
	
		// Constructors
		public CinemachineGyroscopeEffect(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x000000018B084FA0-0x000000018B085298
	}

	public class CommonItemToastList : UIScrollList // TypeDefIndex: 50240
	{
		// Constructors
		public CommonItemToastList(); // 0x00000001839C1F30-0x00000001839C1F80
	
		// Methods
		public new void ScrollToIndex(int index = -1 /* Metadata: 0x0232FB75 */, bool fastMode = false /* Metadata: 0x0232FB76 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0232FB77 */, bool graduallyShowInFastMode = false /* Metadata: 0x0232FB78 */); // 0x000000018396C790-0x000000018396C800
		protected void AdjustContainerPos(int index = -1 /* Metadata: 0x0232FB79 */, bool fastMode = false /* Metadata: 0x0232FB7A */); // 0x000000018396C530-0x000000018396C6D0
		private Vector2 _GetUnConstraintTargetPos(int index = -1 /* Metadata: 0x0232FB7B */); // 0x000000018396C6D0-0x000000018396C790
		[CompilerGenerated]
		private Vector2 _AdjustContainerPos_b__1_0(); // 0x0000000184CC5EE0-0x0000000184CC5F10
		[CompilerGenerated]
		private void _AdjustContainerPos_b__1_1(Vector2 x); // 0x00000001847C3FC0-0x00000001847C3FF0
	}

	public class ControllerSideMenuItemList : MonoBehaviour // TypeDefIndex: 50242
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
		public class MeunItemInfo // TypeDefIndex: 50241
		{
			// Fields
			[Tooltip("\u53EF\u9009\uFF0C\u663E\u5F0F\u6307\u5B9A item \u6807\u8BC6\u540D\uFF08\u7528\u4E8E\u5F15\u5BFC\u7B49\u7CFB\u7EDF\u5339\u914D\uFF09\u3002\u4E3A\u7A7A\u65F6\u81EA\u52A8\u53D6 button/toggle \u7684 gameObject.name")]
			public string itemName; // 0x10
			public UIButton button; // 0x18
			public UIToggle toggle; // 0x20
			public bool showIcon; // 0x28
			public Sprite sprite; // 0x30
			public UIText text; // 0x38
			public string textId; // 0x40
			public string textIdForToggleOff; // 0x48
			[NonSerialized]
			public int priority; // 0x50
	
			// Properties
			public bool isForceValid { get; } // 0x000000018B0870E4-0x000000018B08716C 
	
			// Constructors
			public MeunItemInfo(); // 0x0000000184D8E3B0-0x0000000184D8E3C0
	
			// Methods
			public bool IsValid(); // 0x000000018B086FC8-0x000000018B0870E4
			public string GetText(); // 0x000000018B086E98-0x000000018B086FC8
			public Sprite GetSprite(); // 0x000000018B086D88-0x000000018B086E98
			public void Execute(); // 0x000000018B086B04-0x000000018B086C80
			public string GetItemName(); // 0x000000018B086C80-0x000000018B086D88
		}
	
		// Constructors
		public ControllerSideMenuItemList(); // 0x0000000184B37520-0x0000000184B375C0
		static ControllerSideMenuItemList(); // 0x0000000184D18720-0x0000000184D187B0
	
		// Methods
		public static void ToggleItemForceValid(string itemName, bool forceValid); // 0x000000018B0853D0-0x000000018B0854EC
		public static bool IsItemForceValid(string itemName); // 0x000000018B08532C-0x000000018B0853D0
		public static void ClearForceValidItemList(); // 0x000000018B085298-0x000000018B08532C
	}

	public sealed class CustomNotchAdapt : MonoBehaviour // TypeDefIndex: 50243
	{
		// Fields
		public bool isLeft; // 0x18
		public bool isRight; // 0x19
		public bool isBottom; // 0x1A
		public bool isFullHorizontalStretch; // 0x1B
	
		// Constructors
		public CustomNotchAdapt(); // 0x0000000183695570-0x0000000183695590
	}

	public enum UIStyleInputValidType // TypeDefIndex: 50244
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
	public enum UIStyleInputValidTypeMask // TypeDefIndex: 50245
	{
		Keyboard = 2,
		Touch = 4,
		Controller = 8,
		All = 14
	}

	public enum ActiveType // TypeDefIndex: 50246
	{
		UseGameObjectActive = 0,
		UseScale = 1
	}

	public class CustomUIStyle : MonoBehaviour // TypeDefIndex: 50248
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
		public UIStyleInputValidTypeMask inputValidTypeMask { get; set; } // 0x000000018B0855F0-0x000000018B0856A4 0x000000018B0856F0-0x000000018B0857A4
		public OverrideValidState overrideValidState { get; set; } // 0x000000018B0856A4-0x000000018B0856F0 0x000000018B0857A4-0x000000018B085804
		public bool isValid { get; } // 0x00000001840F34C0-0x00000001840F3500 
	
		// Nested types
		public enum OverrideValidState // TypeDefIndex: 50247
		{
			None = 0,
			ForceValid = 1,
			ForceNotValid = 2
		}
	
		// Constructors
		public CustomUIStyle(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		private void _OnActiveTypeChanged(); // 0x000000018B0854EC-0x000000018B0855F0
		private void OnDestroy(); // 0x00000001839D27E0-0x00000001839D2890
		private void OnEnable(); // 0x00000001840F3410-0x00000001840F3450
		private void Awake(); // 0x0000000183CECD20-0x0000000183CECDD0
		public void CheckState(); // 0x00000001840F3450-0x00000001840F34C0
		public void ToggleActiveState(bool isActive); // 0x00000001840F35D0-0x00000001840F3750
		public static bool IsShowTypeValid(UIStyleInputValidType inputValidType); // 0x00000001840F3500-0x00000001840F35D0
		public static bool IsValidInput(UIStyleInputValidTypeMask inputValidTypeMask); // 0x0000000183CEC790-0x0000000183CEC7E0
	}

	public class DeactivateNaviOnEnable : MonoBehaviour // TypeDefIndex: 50249
	{
		// Fields
		public string key; // 0x18
	
		// Constructors
		public DeactivateNaviOnEnable(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnEnable(); // 0x000000018B085894-0x000000018B085924
		private void OnDisable(); // 0x000000018B085804-0x000000018B085894
	}

	[RequireComponent(typeof(LayoutElement))]
	public class DecoLineActiveHelper : TickableUIMono // TypeDefIndex: 50250
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
		private bool m_oriIgnoreLayout; // 0x80
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000184413130-0x0000000184413160 
	
		// Constructors
		public DecoLineActiveHelper(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		private void Reset(); // 0x000000018B085924-0x000000018B08599C
		protected override void OnEnable(); // 0x00000001845E6330-0x00000001845E63C0
		public override void LateTick(float deltaTime); // 0x00000001833F0700-0x00000001833F0D30
		public void Sync(); // 0x000000018B08599C-0x000000018B0859D0
		private bool _HasActiveTarget(List<GameObject> targets); // 0x000000018B0859D0-0x000000018B085A9C
		private void _ToggleVisible(bool isVisible); // 0x000000018B085A9C-0x000000018B085B70
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class Empty4Raycast : MaskableGraphic // TypeDefIndex: 50251
	{
		// Constructors
		protected Empty4Raycast(); // 0x000000018B085BDC-0x000000018B085BFC
	
		// Methods
		protected override void OnPopulateMesh(VertexHelper vh); // 0x000000018B085B70-0x000000018B085BD4
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0); // 0x000000018B085BD4-0x000000018B085BDC
	}

	public class FitAspectRatioByFOV : MonoBehaviour, DeviceInfoManager.IScreenSizeListener // TypeDefIndex: 50252
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
		public float maxFov { get; set; } // 0x000000018B085C94-0x000000018B085CF4 0x000000018B085CF4-0x000000018B085D58
	
		// Constructors
		public FitAspectRatioByFOV(); // 0x0000000184D398A0-0x0000000184D398D0
	
		// Methods
		private void Start(); // 0x000000018B085BFC-0x000000018B085C94
		private void OnEnable(); // 0x0000000183C035D0-0x0000000183C03640
		private void OnDisable(); // 0x0000000183C03560-0x0000000183C035D0
		public void OnScreenSizeChanged(int width, int height); // 0x0000000183C03640-0x0000000183C03690
		private void _AdjustFOV(); // 0x0000000183C03700-0x0000000183C037A0
	}

	public class FixRotation : TickableUIMono // TypeDefIndex: 50253
	{
		// Fields
		public Vector3 rotation; // 0x68
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018465E4E0-0x0000000184660360 
	
		// Constructors
		public FixRotation(); // 0x0000000184CE63F0-0x0000000184CE6410
	
		// Methods
		public override void LateTick(float deltaTime); // 0x0000000183160F10-0x0000000183160F80
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class FullScreenSceneBlurMarker : MonoBehaviour // TypeDefIndex: 50255
	{
		// Fields
		private static int s_nextId; // 0x00
		public static Action<int, State, bool, bool> s_onFullScreenSceneBlurMarkerStateChanged; // 0x08
		[CompilerGenerated]
		private int _id_k__BackingField; // 0x18
		[FormerlySerializedAs("fromUIBlur")]
		public bool useWhiteBlur; // 0x1C
		public bool useSceneColorPS; // 0x1D
		[Tooltip("\u4EC5\u5F53 useSceneColorPS=true \u65F6\u6709\u610F\u4E49\u3002\ntrue\uFF1A\u6240\u5728 LuaPanel \u662F hideCamera \u7684\u5168\u5C4F\u9762\u677F\uFF0Cblur \u5FC5\u987B\u51FA\u73B0\uFF0C\u65E0\u6761\u4EF6\u6FC0\u6D3B\u3002\nfalse\uFF1A\u6240\u5728 LuaPanel \u662F\u53E0\u5728\u5176\u4ED6 UI \u4E0A\u7684\u5F39\u7A97\uFF08UIBlur \u5F39\u7A97\u578B\uFF09\uFF0CSceneBlur \u4EC5\u4F5C\u4E3A\u6CA1\u6709\u5E95\u5C42 UI \u65F6\u7684\u515C\u5E95\u3002\nOnEnable \u65F6\u82E5\u4E3B\u76F8\u673A\u5DF2\u88AB\u5173\u95ED\uFF08cullingMask==0\uFF09\uFF0C\u8BF4\u660E\u5DF2\u6709\u522B\u7684 hideCamera \u9762\u677F\u6321\u4F4F\u573A\u666F\uFF0CSceneBlur \u770B\u4E0D\u5230\uFF0C\u89C6\u4E3A\u6CA1\u53D1\u751F\u3002")]
		public bool thisLuaPanelHidesCamera; // 0x1E
		private bool m_didNotifyEnable; // 0x1F
	
		// Properties
		public int id { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001811EF5B0-0x00000001811EF5C0 0x00000001811EF9B0-0x00000001811EF9C0
	
		// Nested types
		public enum State // TypeDefIndex: 50254
		{
			OnEnable = 0,
			OnDisable = 1,
			OnDestroy = 2
		}
	
		// Constructors
		public FullScreenSceneBlurMarker(); // 0x0000000184CD97C0-0x0000000184CD97F0
		static FullScreenSceneBlurMarker(); // 0x0000000184D7A790-0x0000000184D7A7D0
	
		// Methods
		private static int _GetNextId(); // 0x00000001848AE840-0x00000001848AE8B0
		private void Awake(); // 0x00000001848AE7D0-0x00000001848AE840
		private void OnEnable(); // 0x0000000184701DA0-0x0000000184701E60
		private void OnDisable(); // 0x0000000184701D00-0x0000000184701DA0
		private void OnDestroy(); // 0x0000000184CADED0-0x0000000184CADF20
	}

	[RequireComponent(typeof(InputBindingGroupMonoTarget))]
	public class InputBindingGroupNaviDecorator : Selectable, IUIClearable // TypeDefIndex: 50256
	{
		// Fields
		private InputBindingGroupMonoTarget m_inputBindingGroup; // 0x188
		public UnityEvent<bool> onGroupSetAsNaviTarget; // 0x190
	
		// Constructors
		public InputBindingGroupNaviDecorator(); // 0x00000001847D96D0-0x00000001847D9750
	
		// Methods
		private void _SetSelfEnabledStateIfNecessary(); // 0x00000001846B4BA0-0x00000001846B4C50
		protected override void Awake(); // 0x00000001837D5880-0x00000001837D58E0
		protected override void OnEnable(); // 0x00000001846B4B20-0x00000001846B4BA0
		protected override void OnDestroy(); // 0x000000018485C6F0-0x000000018485C730
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode); // 0x000000018B0869EC-0x000000018B086B04
		public void ClearComponent(); // 0x000000018485C730-0x000000018485CB50
		public void __iFixBaseProxy_Awake(); // 0x000000018B0869D4-0x000000018B0869DC
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0869E4-0x000000018B0869EC
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0869DC-0x000000018B0869E4
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1); // 0x00000001841E1670-0x00000001841E1680
	}

	public interface IUIClearable : ILuaCallCSharp // TypeDefIndex: 50257
	{
		// Methods
		void ClearComponent();
	}

	public class UILoopScrollRect : TickableUIMono, IPointerUpHandler, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, IUIClearable // TypeDefIndex: 50261
	{
		// Fields
		[SerializeField]
		private RectTransform _viewport; // 0x68
		[SerializeField]
		private Beyond.UI.ScrollDirection _scrollDirection; // 0x70
		[SerializeField]
		private ScrollRect.MovementType _movementType; // 0x74
		[SerializeField]
		private float _elasticity; // 0x78
		[SerializeField]
		private float _scrollSensitivity; // 0x7C
		[SerializeField]
		private float _dragSensitivity; // 0x80
		[SerializeField]
		private bool _inertia; // 0x84
		[SerializeField]
		private float _decelerationRate; // 0x88
		[SerializeField]
		private Snap _snap; // 0x90
		[SerializeField]
		private UIToggle _scrollToggle; // 0x98
		[AudioString]
		[SerializeField]
		private string _audioOnClick; // 0xA0
		[AudioString]
		[SerializeField]
		private string _audioOnScrollTo; // 0xA8
		[AudioString]
		[SerializeField]
		private string _audioAutoBack; // 0xB0
		private readonly AutoScrollState m_autoScrollState; // 0xB8
		private Action<float> m_onValueChanged; // 0xC0
		private Action<int> m_onSelectionChanged; // 0xC8
		private Vector2 m_beginDragPointerPosition; // 0xD0
		private float m_scrollStartPosition; // 0xD8
		private float m_prevPosition; // 0xDC
		private float m_currentPosition; // 0xE0
		private int m_totalCount; // 0xE4
		private int m_currentIndex; // 0xE8
		private bool m_hold; // 0xEC
		private bool m_scrolling; // 0xED
		private bool m_dragging; // 0xEE
		private bool m_hasPlayStartAudio; // 0xEF
		private float m_velocity; // 0xF0
		private int m_lastScrollIndex; // 0xF4
		private List<UIToggle> m_scrollToggles; // 0xF8
	
		// Properties
		public Beyond.UI.ScrollDirection scrollDirection { get; } // 0x000000018B08A5D4-0x000000018B08A620 
		public float viewportSize { get; } // 0x000000018B08A6C0-0x000000018B08A780 
		public float scrollSensitivity { get; set; } // 0x000000018B08A620-0x000000018B08A670 0x000000018B08A808-0x000000018B08A864
		public float Position { get; set; } // 0x000000018B08A530-0x000000018B08A584 0x000000018B08A780-0x000000018B08A808
		protected override TickType tickOption { get; } // 0x000000018B08A670-0x000000018B08A6C0 
		public int currentIndex { get; } // 0x000000018B08A584-0x000000018B08A5D4 
	
		// Nested types
		[Serializable]
		public class Snap // TypeDefIndex: 50258
		{
			// Fields
			public bool enable; // 0x10
			public float velocityThreshold; // 0x14
			public float duration; // 0x18
			public Interpolator.EEaseType easing; // 0x1C
	
			// Constructors
			public Snap(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		private class AutoScrollState // TypeDefIndex: 50259
		{
			// Fields
			public bool enable; // 0x10
			public bool elastic; // 0x11
			public float duration; // 0x14
			public Interpolator.EasingFunction easingFunction; // 0x18
			public float startTime; // 0x20
			public float endPosition; // 0x24
			public Action onComplete; // 0x28
	
			// Constructors
			public AutoScrollState(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void Reset(); // 0x000000018B0B619C-0x000000018B0B62C8
			public void Complete(); // 0x000000018B0B613C-0x000000018B0B619C
		}
	
		public enum MovementDirection // TypeDefIndex: 50260
		{
			Left = 0,
			Right = 1,
			Up = 2,
			Down = 3
		}
	
		// Constructors
		public UILoopScrollRect(); // 0x000000018B08A454-0x000000018B08A530
	
		// Methods
		public void ScrollTo(float position, float duration, Interpolator.EEaseType easing, Action onComplete = null); // 0x000000018B088A4C-0x000000018B088B28
		public void ScrollToMultiLoop(float position, float duration, Interpolator.EEaseType easing, Action onComplete = null); // 0x000000018B088970-0x000000018B088A4C
		public void OnValueChanged(Action<float> callback); // 0x000000018B088908-0x000000018B088970
		public void OnSelectionChanged(Action<int> callback); // 0x000000018B0888A0-0x000000018B088908
		public void JumpTo(int index); // 0x000000018B0887CC-0x000000018B0888A0
		public void SetTotalCount(int totalCount); // 0x000000018B088B28-0x000000018B088B90
		public MovementDirection GetMovementDirection(int sourceIndex, int destIndex); // 0x000000018B088708-0x000000018B0887CC
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x000000018B089554-0x000000018B0895D8
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x000000018B0895D8-0x000000018B0896A0
		void IScrollHandler.OnScroll(PointerEventData eventData); // 0x000000018B0896A0-0x000000018B089820
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData); // 0x000000018B0891B4-0x000000018B08931C
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x000000018B08931C-0x000000018B0894E8
		void IEndDragHandler.OnEndDrag(PointerEventData eventData); // 0x000000018B0894E8-0x000000018B089554
		public override void Tick(float deltaTime); // 0x000000018B088B90-0x000000018B0891B4
		public void ClearComponent(); // 0x000000018B0886C4-0x000000018B088708
		private float _CalculateOffset(float position); // 0x000000018B08993C-0x000000018B0899D4
		private void _ScrollTo(float position, float duration, Interpolator.EasingFunction easingFunction, Action onComplete = null); // 0x000000018B08A0CC-0x000000018B08A2C4
		private void _ScrollToMultiLoop(float position, float duration, Interpolator.EasingFunction easingFunction, Action onComplete = null); // 0x000000018B089F24-0x000000018B08A0CC
		private void _UpdatePosition(float position); // 0x000000018B08A2C4-0x000000018B08A3BC
		private void _PlayEndAudio(); // 0x000000018B089A78-0x000000018B089AFC
		private float _CalculateMovementAmount(float sourcePosition, float destPosition); // 0x000000018B089820-0x000000018B08993C
		private float _CircularPosition(float p, int size); // 0x000000018B0899D4-0x000000018B089A78
		private float _RubberDelta(float overStretching, float viewSize); // 0x000000018B089E80-0x000000018B089F24
		private void _UpdateSelection(int index); // 0x000000018B08A3BC-0x000000018B08A454
		private void _RefreshScrollToggleCount(int count); // 0x000000018B089AFC-0x000000018B089D9C
		private void _RefreshToggle(); // 0x000000018B089D9C-0x000000018B089E80
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class UILoopScrollView : TickableUIMono // TypeDefIndex: 50263
	{
		// Fields
		[SerializeField]
		private GameObject _cellTemplate; // 0x68
		[SerializeField]
		private UILoopScrollRect _scrollRect; // 0x70
		[SerializeField]
		private RectTransform _cellContainer; // 0x78
		[SerializeField]
		private bool _animPosition; // 0x80
		[SerializeField]
		private string _scrollClipName; // 0x88
		[Range(0.01f, 1f)]
		[SerializeField]
		private float _cellInterval; // 0x90
		[Range(0f, 1f)]
		[SerializeField]
		private float _scrollOffset; // 0x94
		[SerializeField]
		private float _notChooseScale; // 0x98
		[SerializeField]
		private float _fixInterval; // 0x9C
		[SerializeField]
		protected float _tweenDuration; // 0xA0
		[SerializeField]
		protected Interpolator.EEaseType _tweenEase; // 0xA4
		[SerializeField]
		protected InputBindingGroupMonoTarget _scrollBindingGroup; // 0xA8
		[SerializeField]
		protected bool _stickScrollIsLeft; // 0xB0
		[SerializeField]
		protected bool _stickScrollEnableArrow; // 0xB1
		[SerializeField]
		protected float _stickScrollTolerance; // 0xB4
		[SerializeField]
		private UISelectableNaviGroup _naviGroup; // 0xB8
		private bool m_initialized; // 0xC0
		private float m_currentPosition; // 0xC4
		private float m_cellSize; // 0xC8
		private float m_notChooseCellSize; // 0xCC
		private float m_notChooseInterval; // 0xD0
		private List<Cell> m_pool; // 0xD8
		private bool m_controllerInited; // 0xE0
		private float m_stickScrollTime; // 0xE4
		private float m_nextStickStepTime; // 0xE8
		private int m_nextStickStepTimeIndex; // 0xEC
		private static float[] s_stickScrollDuration; // 0x00
		[CompilerGenerated]
		private int _count_k__BackingField; // 0xF0
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onUpdateCell; // 0xF8
		[NonSerialized]
		public DisposedUnityEvent<int> onScrollEnd; // 0x100
	
		// Properties
		public int count { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184D885B0-0x0000000184D885C0 0x0000000184D88610-0x0000000184D88620
		public bool controllerStickScrollEnabled { get; } // 0x000000018B0BCD74-0x000000018B0BCE14 
		protected override TickType tickOption { get; } // 0x000000018B0BCE14-0x000000018B0BCE64 
	
		// Nested types
		public class Cell // TypeDefIndex: 50262
		{
			// Fields
			public GameObject gameObject; // 0x10
			public RectTransform rectTransform; // 0x18
			public UIAnimationWrapper animationWrapper; // 0x20
			[CompilerGenerated]
			private int _index_k__BackingField; // 0x28
			[CompilerGenerated]
			private int _realIndex_k__BackingField; // 0x2C
			[CompilerGenerated]
			private float _position_k__BackingField; // 0x30
	
			// Properties
			public int index { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F2A90-0x00000001811F2AA0 0x00000001811F2AA0-0x00000001811F2AB0
			public int realIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
			public float position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86E20-0x0000000184D86E30 0x0000000184D86E30-0x0000000184D86E40
			public bool isVisible { get; } // 0x000000018B0B63C0-0x000000018B0B6418 
	
			// Constructors
			public Cell(); // 0x0000000184DA7B20-0x0000000184DA7B30
	
			// Methods
			public void SetVisible(bool active); // 0x000000018B0B62C8-0x000000018B0B6328
			public void UpdatePosition(string clipName, float position); // 0x000000018B0B6328-0x000000018B0B63C0
		}
	
		// Constructors
		public UILoopScrollView(); // 0x000000018B0BCC0C-0x000000018B0BCD74
		static UILoopScrollView(); // 0x000000018B0BCAFC-0x000000018B0BCC0C
	
		// Methods
		protected virtual void UpdatePosition(float position); // 0x000000018B0BB6A8-0x000000018B0BB710
		protected virtual void OnScrollEnd(int index); // 0x000000018B0BB264-0x000000018B0BB2C8
		public virtual void ScrollToIndex(int index, bool fastMode = false /* Metadata: 0x0232FB93 */); // 0x000000018B0BB370-0x000000018B0BB414
		public virtual void UpdateCount(int newCount); // 0x000000018B0BB624-0x000000018B0BB6A8
		public override void Tick(float deltaTime); // 0x000000018B0BB5C0-0x000000018B0BB624
		public GameObject GetCurrentCell(); // 0x000000018B0BAE68-0x000000018B0BAFF0
		protected override void OnRelease(); // 0x000000018B0BB208-0x000000018B0BB264
		protected void ClearComponent(); // 0x000000018B0BADC8-0x000000018B0BAE68
		protected override void OnEnable(); // 0x000000018B0BB1AC-0x000000018B0BB208
		protected void Initialize(); // 0x000000018B0BAFF0-0x000000018B0BB1AC
		private void _UpdatePosition(float position, bool forceRefresh); // 0x000000018B0BC8B8-0x000000018B0BCAFC
		private void _OnScrollEnd(int index); // 0x000000018B0BB9A0-0x000000018B0BBA2C
		protected virtual void OnUpdateCell(Cell cell, int index); // 0x000000018B0BB2C8-0x000000018B0BB370
		private void _ResizePool(float firstPosition); // 0x000000018B0BBA2C-0x000000018B0BBCDC
		private int _GetNeedCount(float firstPosition); // 0x000000018B0BB79C-0x000000018B0BB87C
		private void _UpdateCells(float firstPosition, int firstIndex, bool forceRefresh); // 0x000000018B0BC440-0x000000018B0BC8B8
		private void _UpdateCellsAnimationPosition(float firstPosition, int firstIndex, bool forceRefresh); // 0x000000018B0BC274-0x000000018B0BC440
		private void _InitController(); // 0x000000018B0BB87C-0x000000018B0BB9A0
		private void _ScrollToNaviTarget(Selectable target); // 0x000000018B0BBE00-0x000000018B0BBEB4
		public void ScrollToObject(GameObject go); // 0x000000018B0BB414-0x000000018B0BB5C0
		private void _ScrollToCell(Cell cell); // 0x000000018B0BBCDC-0x000000018B0BBE00
		private void _TickRefreshControllerStickScroll(float deltaTime); // 0x000000018B0BBF50-0x000000018B0BC274
		private void _ScrollToNext(bool positive); // 0x000000018B0BBEB4-0x000000018B0BBF50
		private int _CircularIndex(int i, int size); // 0x000000018B0BB710-0x000000018B0BB79C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
	}

	[ExecuteInEditMode]
	public class LuaPanel : MonoBehaviour, IUIClearable // TypeDefIndex: 50265
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
		[CompilerGenerated]
		private int _panelLevel_k__BackingField; // 0x2C
		[FormerlySerializedAs("_animationWrapper")]
		public UIAnimationWrapper animationWrapper; // 0x30
		[SerializeField]
		private AudioUIUtil.UIAudioType _uiAudioType; // 0x38
		[CompilerGenerated]
		private RectTransform _rectTransform_k__BackingField; // 0x40
		[CompilerGenerated]
		private Canvas _canvas_k__BackingField; // 0x48
		public HashSet<UISortingOrder> sortingOrderComps; // 0x50
		[CompilerGenerated]
		private Camera _uiCamera_k__BackingField; // 0x58
		[CompilerGenerated]
		private float _planeDistance_k__BackingField; // 0x60
		[CompilerGenerated]
		private int _panelId_k__BackingField; // 0x64
		[CompilerGenerated]
		private string _panelName_k__BackingField; // 0x68
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
		public bool blockWhileAnim { get; } // 0x0000000184505A80-0x0000000184505AB0 
		public int panelLevel { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86710-0x0000000184D86720 0x0000000184D86720-0x0000000184D86730
		public RectTransform rectTransform { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public Canvas canvas { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public Camera uiCamera { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public float planeDistance { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88480-0x0000000184D88490 0x0000000184D884A0-0x0000000184D884B0
		public int panelId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88110-0x0000000184D88120 0x0000000184D88120-0x0000000184D88130
		public string panelName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		public bool IsWorldUI { get; set; } // 0x000000018B0B64B0-0x000000018B0B64FC 0x000000018B0B6598-0x000000018B0B65F0
		public bool isPCOnlyPanel { get; } // 0x00000001831E9FC0-0x00000001831E9FF0 
		public bool isControllerPanel { get; } // 0x000000018B0B654C-0x000000018B0B6598 
		public bool animationInFinished { get; } // 0x000000018B0B64FC-0x000000018B0B654C 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __AutoAnimationInFinish_d__61 : IEnumerator<object> // TypeDefIndex: 50264
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LuaPanel __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __AutoAnimationInFinish_d__61(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000183545A40-0x0000000183545AF0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B0B9014-0x000000018B0B9060
		}
	
		// Constructors
		public LuaPanel(); // 0x0000000183EE9E50-0x0000000183EE9F50
		static LuaPanel(); // 0x0000000184D17910-0x0000000184D179A0
	
		// Methods
		private void Awake(); // 0x00000001837D3920-0x00000001837D39E0
		private void _TrySetRot(); // 0x00000001837D39E0-0x00000001837D3A60
		public void AddSortingOrderComp(UISortingOrder comp); // 0x00000001837D4BA0-0x00000001837D4C10
		public void RemoveSortingOrderComp(UISortingOrder comp); // 0x00000001845ECD00-0x00000001845ECDA0
		private void Start(); // 0x00000001845C5170-0x00000001845C51B0
		private void OnEnable(); // 0x00000001838D3A20-0x00000001838D3AD0
		private void OnDisable(); // 0x00000001838D39B0-0x00000001838D3A20
		private void OnDestroy(); // 0x00000001846581C0-0x0000000184658200
		[IteratorStateMachine(typeof(__AutoAnimationInFinish_d__61))]
		private IEnumerator _AutoAnimationInFinish(); // 0x00000001838D3AD0-0x00000001838D3B30
		public bool InformAnimationInStart(GameObject target); // 0x00000001832E9FB0-0x00000001832EA020
		public void InformAnimationInEnd(GameObject target, bool forceEnd = false /* Metadata: 0x0232FB94 */); // 0x0000000183545CC0-0x0000000183545D40
		private void _TryCallAnimationInFinished(bool forceFinished); // 0x0000000183545D40-0x0000000183545ED0
		public void BlockAllInput(); // 0x00000001834366E0-0x00000001834367E0
		public void RecoverAllInput(); // 0x00000001834365E0-0x00000001834366E0
		public void ClearComponent(); // 0x0000000184658200-0x0000000184658250
	}

	public class MouseHoverTipsPosHelper : TickableUIMono // TypeDefIndex: 50266
	{
		// Fields
		[SerializeField]
		[Tooltip("\u5047\u8BBEUI\u7684\u5206\u8FA8\u7387\u662F1920*1080\u7684\u60C5\u51B5\uFF0C\u4F1A\u81EA\u52A8\u52A0\u4E0A\u5218\u6D77\u5C4F\u7684\u504F\u79FB")]
		private RectOffset _padding; // 0x68
		private LuaPanel m_panel; // 0x70
		private RectTransform m_rectTransform; // 0x78
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B0B6BAC-0x000000018B0B6BFC 
		public LuaPanel panel { get; } // 0x000000018B0B6B1C-0x000000018B0B6BAC 
	
		// Constructors
		public MouseHoverTipsPosHelper(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		protected override void OnAwake(); // 0x000000018B0B6650-0x000000018B0B6740
		protected override void OnEnable(); // 0x000000018B0B6740-0x000000018B0B679C
		public override void LateTick(float deltaTime); // 0x000000018B0B65F0-0x000000018B0B6650
		public void UpdatePosition(); // 0x000000018B0B679C-0x000000018B0B6B1C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class NaviToThisGroupOnEnable : MonoBehaviour // TypeDefIndex: 50267
	{
		// Fields
		public UISelectableNaviGroup target; // 0x18
	
		// Constructors
		public NaviToThisGroupOnEnable(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Reset(); // 0x000000018B0B7050-0x000000018B0B70D0
		private void Awake(); // 0x000000018B0B6F04-0x000000018B0B6FB4
		private void OnEnable(); // 0x000000018B0B6FB4-0x000000018B0B7050
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class NonDrawingGraphic : Graphic, ICanvasRaycastFilter // TypeDefIndex: 50269
	{
		// Fields
		public ShapeType shapeType; // 0xB0
	
		// Properties
		public float Radius { get; } // 0x0000000183094480-0x0000000183094510 
	
		// Nested types
		public enum ShapeType // TypeDefIndex: 50268
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public NonDrawingGraphic(); // 0x0000000183695540-0x0000000183695570
	
		// Methods
		public override void SetMaterialDirty(); // 0x000000018440A720-0x000000018440A750
		public override void SetVerticesDirty(); // 0x000000018430BC30-0x000000018430BC60
		protected override void OnPopulateMesh(VertexHelper vh); // 0x000000018B0B70D0-0x000000018B0B7134
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera); // 0x0000000183093330-0x00000001830933E0
		private bool _IsRaycastLocationValidCircle(Vector2 sp, Camera eventCamera); // 0x00000001830943A0-0x0000000183094480
		public void __iFixBaseProxy_SetMaterialDirty(); // 0x000000018B0B7134-0x000000018B0B713C
		public void __iFixBaseProxy_SetVerticesDirty(); // 0x000000018B0B713C-0x000000018B0B7144
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0); // 0x000000018B085BD4-0x000000018B085BDC
	}

	[DisallowMultipleComponent]
	public sealed class NotchAdapter : MonoBehaviour // TypeDefIndex: 50271
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
		[CompilerGenerated]
		private sealed class __c__19<T> // TypeDefIndex: 50270
		{
			// Fields
			public static readonly __c__19<T> __9;
			public static Predicate<T> __9__19_0;
	
			// Constructors
			static __c__19();
			public __c__19();
	
			// Methods
			internal bool __RemoveNullRef_b__19_0(T x);
		}
	
		// Constructors
		public NotchAdapter(); // 0x0000000183694470-0x0000000183694580
	
		// Methods
		private void Awake(); // 0x0000000183BFD4E0-0x0000000183BFD570
		private void OnDestroy(); // 0x0000000183BFD3D0-0x0000000183BFD4E0
		public void FindAllSideUI(bool needClear); // 0x0000000183BFCF90-0x0000000183BFD010
		[IDTag(1)]
		public void ApplyNotch(); // 0x000000018B0B7144-0x000000018B0B71AC
		[IDTag(0)]
		public void ApplyNotch(Vector2 curMarginSize); // 0x0000000183BFD570-0x0000000183BFDB20
		public void ClearList(); // 0x0000000183BFCEF0-0x0000000183BFCF90
		public void ClearNullRef(); // 0x0000000183BFDB20-0x0000000183BFDBA0
		public void UnApplyNotch(); // 0x000000018B0B71AC-0x000000018B0B721C
		public void ApplyNewNotch(); // 0x0000000183BFD350-0x0000000183BFD3D0
		private void _UpdateMargeSizeFromNotchInfo(bool forceUpdate = false /* Metadata: 0x0232FB97 */); // 0x0000000183BFDCC0-0x0000000183BFED60
		private void _OnCanvasChanged(); // 0x0000000183BFD310-0x0000000183BFD350
		private void _RemoveNullRef<T>(List<T> list);
		private void _TraverseUI(RectTransform root); // 0x0000000183BFC330-0x0000000183BFC7D0
		private void _TryAddToSideUI(RectTransform rect, CustomNotchAdapt custom = null); // 0x0000000183BFC7D0-0x0000000183BFCB10
	}

	public class ParallaxHelper : MonoBehaviour // TypeDefIndex: 50273
	{
		// Fields
		[SerializeField]
		private List<ParallaxConfig> _configs; // 0x18
		[SerializeField]
		private float _maxOffset; // 0x20
		private float m_curValue; // 0x24
	
		// Properties
		public float curValue { get; set; } // 0x000000018B0B75F0-0x000000018B0B7640 0x000000018B0B7640-0x000000018B0B76A4
	
		// Nested types
		[Serializable]
		public class ParallaxConfig // TypeDefIndex: 50272
		{
			// Fields
			public RectTransform target; // 0x10
			public float ratio; // 0x18
			[NonSerialized]
			public Vector2 oriPosition; // 0x1C
	
			// Constructors
			public ParallaxConfig(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public ParallaxHelper(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void InitConfigs(); // 0x000000018B0B721C-0x000000018B0B73A4
		public void ResetValue(); // 0x000000018B0B7598-0x000000018B0B75F0
		public void RefreshPos(); // 0x000000018B0B73A4-0x000000018B0B7598
	}

	public class PercentNumberTweener : TickableUIMono // TypeDefIndex: 50274
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
		protected override TickType tickOption { get; } // 0x000000018B0B78EC-0x000000018B0B793C 
	
		// Constructors
		public PercentNumberTweener(); // 0x000000018B0B789C-0x000000018B0B78EC
	
		// Methods
		private void Reset(); // 0x000000018B0B781C-0x000000018B0B789C
		protected override void OnEnable(); // 0x000000018B0B77BC-0x000000018B0B781C
		public override void LateTick(float deltaTime); // 0x000000018B0B76A4-0x000000018B0B77BC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public abstract class UIRecycleLayoutAdapter // TypeDefIndex: 50279
	{
		// Fields
		[CompilerGenerated]
		private UIRecycleLayoutGroup.IViewHandler _viewHandler_k__BackingField; // 0x10
	
		// Properties
		public UIRecycleLayoutGroup.IViewHandler viewHandler { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
		// Nested types
		public interface ICustomViewType // TypeDefIndex: 50275
		{
			// Properties
			int viewType { get; }
		}
	
		public interface ICustomSpacing // TypeDefIndex: 50276
		{
			// Methods
			float GetCustomSpacing();
		}
	
		public interface IVirtualView : IHotfixable // TypeDefIndex: 50277
		{
			// Methods
			void AttachView(GameObject view);
			void DetachView();
			GameObject GetAttachedView();
			int GetViewID();
			GameObject GetPrefab();
			float GetPreferSize();
		}
	
		public abstract class VirtualView : IVirtualView // TypeDefIndex: 50278
		{
			// Fields
			protected GameObject m_gameObj; // 0x10
	
			// Properties
			public bool isAttached { get; } // 0x000000018B0C1200-0x000000018B0C1284 
	
			// Constructors
			protected VirtualView(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void AttachView(GameObject gameObj); // 0x000000018B0C1048-0x000000018B0C10F4
			public void DetachView(); // 0x000000018B0C10F4-0x000000018B0C1158
			public GameObject GetAttachedView(); // 0x000000018B0C1158-0x000000018B0C11A8
			public int GetViewID(); // 0x000000018B0C11A8-0x000000018B0C1200
			protected abstract void OnViewAttached();
			protected abstract void OnViewDetached();
			public abstract GameObject GetPrefab();
			public abstract float GetPreferSize();
		}
	
		// Constructors
		protected UIRecycleLayoutAdapter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void Init(UIRecycleLayoutGroup.IViewHandler handler); // 0x000000018B0BCEB0-0x000000018B0BCF20
		public virtual IList<IVirtualView> GenerateViewsForRebuild(); // 0x000000018B0BCE64-0x000000018B0BCEB0
		public abstract void OnInit();
	}

	[RequireComponent(typeof(UIRecycleLayoutGroup))]
	public abstract class UIRecycleLayoutSimpleHolder<TVirtualView> : TickableUIMono // TypeDefIndex: 50282
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
		public class SimpleAdapter : UIRecycleLayoutAdapter // TypeDefIndex: 50280
		{
			// Fields
			private UIRecycleLayoutSimpleHolder<TVirtualView> m_holder;
			private List<IVirtualView> m_virtualViews;
	
			// Constructors
			public SimpleAdapter(UIRecycleLayoutSimpleHolder<TVirtualView> holder);
	
			// Methods
			public override IList<IVirtualView> GenerateViewsForRebuild();
			public void NotifyRebuild();
			public void InsertView(int index, TVirtualView virtualView);
			public void AppendView(TVirtualView virtualView);
			public void AddView(TVirtualView virtualView);
			public void RemoveView(int index);
			public void RemoveAllViews(bool dontRebuild = false /* Metadata: 0x0232FB9A */);
			public int GetCount();
			public TVirtualView GetVirtualView(int index);
			public GameObject GetView(int index);
			public void NotifySizeChanged(TVirtualView virtualView);
			public void NotifyAllSizeChanged();
			public void NotifySizeChanged(int index);
			public override void OnInit();
			public void OnDisposed();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 50281
		{
			// Fields
			public UIRecycleLayoutSimpleHolder<TVirtualView> __4__this;
			public int naviIndex;
			public bool isBefore;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void __WrapNavigation_b__0();
		}
	
		// Constructors
		protected UIRecycleLayoutSimpleHolder();
	
		// Methods
		private void _InitIfNot();
		protected override void OnAwake();
		private void _AfterLayout();
		private void _WrapNavigation(NaviDirection dir);
		public abstract void OnAdapterInit();
		public void ScrollTo(int index, bool fastMode = false /* Metadata: 0x0232FB98 */);
		protected void ClearScrollTweenIfNeeded();
		protected virtual void ScrollToInternal(float normalizedPosition, bool fastMode = false /* Metadata: 0x0232FB99 */);
		public GameObject GetView(int index);
		public void NotifyAllSizeChanged();
		public void NotifySizeChanged(int index);
		public void NotifySizeChanged(TVirtualView virtualView);
		public void RemoveView(int index);
		public void RemoveAllViews();
	}

	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class UIRecycleLayoutGroup : TickableUIMono, ILayoutElement, IUIClearable // TypeDefIndex: 50291
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
		[CompilerGenerated]
		private float _sizeOnAxis_k__BackingField; // 0xB8
		[NonSerialized]
		public DisposedUnityEvent onLayoutUpdated; // 0xC0
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B0BEBB0-0x000000018B0BEC00 
		public UIRecycleLayoutAdapter adapter { get; } // 0x000000018B0BE6E0-0x000000018B0BE77C 
		protected ViewMgr viewMgr { get; } // 0x000000018B0BEC00-0x000000018B0BECB0 
		protected float sizeOnAxis { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA32D0-0x0000000184DA32E0 0x0000000184D87E30-0x0000000184D87E40
		protected float spacing { get; } // 0x000000018B0BEB5C-0x000000018B0BEBB0 
		protected Padding padding { get; } // 0x000000018B0BEA34-0x000000018B0BEA9C 
		public float minWidth { get; } // 0x000000018B0BE900-0x000000018B0BE94C 
		public float minHeight { get; } // 0x000000018B0BE8B4-0x000000018B0BE900 
		public float flexibleWidth { get; } // 0x000000018B0BE818-0x000000018B0BE864 
		public float flexibleHeight { get; } // 0x000000018B0BE7CC-0x000000018B0BE818 
		public int layoutPriority { get; } // 0x000000018B0BE864-0x000000018B0BE8B4 
		public float preferredWidth { get; } // 0x000000018B0BEAFC-0x000000018B0BEB5C 
		public float preferredHeight { get; } // 0x000000018B0BEA9C-0x000000018B0BEAFC 
		protected float paddingFront { get; } // 0x000000018B0BE9C0-0x000000018B0BEA34 
		protected float paddingBack { get; } // 0x000000018B0BE94C-0x000000018B0BE9C0 
		protected RectTransform content { get; } // 0x000000018B0BE77C-0x000000018B0BE7CC 
	
		// Nested types
		public enum Direction // TypeDefIndex: 50283
		{
			Vertical = 0,
			Horizontal = 1
		}
	
		public enum AdaptMode // TypeDefIndex: 50284
		{
			Normal = 0,
			MultiPrefab = 1
		}
	
		public interface IViewHandler // TypeDefIndex: 50285
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
	
		protected struct LayoutMeta // TypeDefIndex: 50286
		{
			// Fields
			public float pos; // 0x00
			public float size; // 0x04
			public int index; // 0x08
			public float curTotalSize; // 0x0C
		}
	
		private class ViewPool // TypeDefIndex: 50287
		{
			// Fields
			private GameObject m_prefab; // 0x10
			private Transform m_container; // 0x18
			private List<GameObject> m_activeObjs; // 0x20
			private List<GameObject> m_pooledObjs; // 0x28
			[CompilerGenerated]
			private int _viewType_k__BackingField; // 0x30
	
			// Properties
			public int viewType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
	
			// Constructors
			public ViewPool(int viewType, GameObject prefab, Transform container); // 0x000000018B0C0F58-0x000000018B0C1048
	
			// Methods
			public GameObject Alloc(out bool isNewlyCreated); // 0x000000018B0C0AE0-0x000000018B0C0C70
			public bool Recycle(GameObject obj); // 0x000000018B0C0DAC-0x000000018B0C0F58
			public void RecycleAll(); // 0x000000018B0C0C70-0x000000018B0C0DAC
		}
	
		protected class ViewMgr : IHotfixable, IViewHandler // TypeDefIndex: 50288
		{
			// Fields
			private UIRecycleLayoutGroup m_closure; // 0x10
			private ListDict<int, ViewPool> m_viewPools; // 0x18
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views; // 0x20
	
			// Constructors
			public ViewMgr(UIRecycleLayoutGroup closure); // 0x000000018B0C0A08-0x000000018B0C0AE0
	
			// Methods
			public void RebuildAll(UIRecycleLayoutAdapter adapter); // 0x000000018B0C0528-0x000000018B0C077C
			public IList<UIRecycleLayoutAdapter.IVirtualView> GetViews(); // 0x000000018B0C032C-0x000000018B0C037C
			public void DetachView(UIRecycleLayoutAdapter.IVirtualView view, GameObject curView); // 0x000000018B0BFEE0-0x000000018B0BFF78
			public void AttachView(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018B0BFE18-0x000000018B0BFEE0
			public UIRecycleLayoutAdapter.IVirtualView GetView(int index); // 0x000000018B0C020C-0x000000018B0C0294
			public int GetViewCount(); // 0x000000018B0C0198-0x000000018B0C020C
			public bool InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018B0C037C-0x000000018B0C0404
			public bool AddView(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018B0BFD7C-0x000000018B0BFE18
			public bool RemoveView(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018B0C077C-0x000000018B0C07F0
			public void NotifyViewSizeChanged(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018B0C04B8-0x000000018B0C0528
			public void NotifyAllViewSizeChanged(); // 0x000000018B0C0404-0x000000018B0C0460
			public void NotifyRebuild(); // 0x000000018B0C0460-0x000000018B0C04B8
			public float GetElementPosByIndex(int index); // 0x000000018B0C00D4-0x000000018B0C013C
			public Bounds GetElementBoundsByIndex(int index); // 0x000000018B0BFFD0-0x000000018B0C0068
			public Direction GetDirection(); // 0x000000018B0BFF78-0x000000018B0BFFD0
			public float GetSizeOnAxis(); // 0x000000018B0C013C-0x000000018B0C0198
			public float GetViewportSizeOnAxis(); // 0x000000018B0C0294-0x000000018B0C032C
			public int GetElementIndex(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018B0C0068-0x000000018B0C00D4
			private ViewPool _EnsureViewPool(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018B0C07F0-0x000000018B0C0974
			private void _NotifyLayoutChanged(int fromIndex); // 0x000000018B0C0974-0x000000018B0C0A08
		}
	
		[Serializable]
		protected struct Padding // TypeDefIndex: 50289
		{
			// Fields
			public int top; // 0x00
			public int left; // 0x04
			public int bottom; // 0x08
			public int right; // 0x0C
		}
	
		public class EmptyAdapter : UIRecycleLayoutAdapter // TypeDefIndex: 50290
		{
			// Constructors
			public EmptyAdapter(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public override IList<IVirtualView> GenerateViewsForRebuild(); // 0x000000018B0B6418-0x000000018B0B6464
			public override void OnInit(); // 0x000000018B0B6464-0x000000018B0B64A8
			public IList<IVirtualView> __iFixBaseProxy_GenerateViewsForRebuild(); // 0x000000018B0B64A8-0x000000018B0B64B0
		}
	
		// Constructors
		public UIRecycleLayoutGroup(); // 0x000000018B0BE614-0x000000018B0BE6E0
	
		// Methods
		public void CalculateLayoutInputHorizontal(); // 0x000000018B0BCF20-0x000000018B0BCF64
		public void CalculateLayoutInputVertical(); // 0x000000018B0BCF64-0x000000018B0BCFA8
		private void _ApplyLayoutMeta(UIRecycleLayoutAdapter.IVirtualView view, LayoutMeta meta); // 0x000000018B0BD480-0x000000018B0BD880
		private Vector2 _GetVisibleRange(Bounds viewBound); // 0x000000018B0BDD20-0x000000018B0BDE30
		private Bounds _GetElementBoundsFromMeta(LayoutMeta meta); // 0x000000018B0BD9B4-0x000000018B0BDB9C
		public UIRecycleLayoutAdapter SetAdapter(UIRecycleLayoutAdapter adapter); // 0x000000018B0BD3D0-0x000000018B0BD480
		public void ClearComponent(); // 0x000000018B0BCFA8-0x000000018B0BD038
		public override void LateTick(float deltaTime); // 0x000000018B0BD038-0x000000018B0BD098
		protected void OnLateTick(); // 0x000000018B0BD098-0x000000018B0BD3D0
		private void _RebuildAllViews(); // 0x000000018B0BDFB8-0x000000018B0BE070
		private void _UpdateViews(int fromIndex); // 0x000000018B0BE330-0x000000018B0BE614
		private bool _InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018B0BDE30-0x000000018B0BDFB8
		private bool _RemoveView(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018B0BE0C8-0x000000018B0BE26C
		private void _UpdateViewsFrom(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018B0BE26C-0x000000018B0BE330
		private float _GetElementPosByIndex(int index); // 0x000000018B0BDC50-0x000000018B0BDD20
		private Bounds _GetElementBoundsByIndex(int index); // 0x000000018B0BD880-0x000000018B0BD9B4
		private int _GetElementIndex(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018B0BDB9C-0x000000018B0BDC50
		private void _RefreshLayout(); // 0x000000018B0BE070-0x000000018B0BE0C8
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class UIRecycleMultiHolder : UIRecycleLayoutSimpleHolder<UIRecycleMultiHolder.MultiVirtualView>, IUIClearable // TypeDefIndex: 50294
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
		public class MultiVirtualView : UIRecycleLayoutAdapter.VirtualView // TypeDefIndex: 50292
		{
			// Fields
			private UIRecycleMultiHolder m_closure; // 0x18
			public float preferSize; // 0x20
			public string prefabKey; // 0x28
	
			// Constructors
			public MultiVirtualView(float initSize, string key, UIRecycleMultiHolder closure); // 0x000000018B0B6ED4-0x000000018B0B6F04
	
			// Methods
			public int GetIndex(); // 0x000000018B0B6BFC-0x000000018B0B6CC8
			public override GameObject GetPrefab(); // 0x000000018B0B6CC8-0x000000018B0B6D4C
			public override float GetPreferSize(); // 0x000000018B0B6D4C-0x000000018B0B6D9C
			protected override void OnViewDetached(); // 0x000000018B0B6E38-0x000000018B0B6ED4
			protected override void OnViewAttached(); // 0x000000018B0B6D9C-0x000000018B0B6E38
		}
	
		[Serializable]
		public class Config // TypeDefIndex: 50293
		{
			// Fields
			public string key; // 0x10
			public GameObject cellTemplate; // 0x18
	
			// Constructors
			public Config(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public UIRecycleMultiHolder(); // 0x000000018B0BF5A4-0x000000018B0BF714
	
		// Methods
		public MultiVirtualView GetVirtualView(int index); // 0x000000018B0BEE90-0x000000018B0BEF1C
		[IDTag(1)]
		public void UpdateCount(int newCount, bool setTop = false /* Metadata: 0x0232FB9F */); // 0x000000018B0BF340-0x000000018B0BF3C0
		[IDTag(0)]
		public void UpdateCount(int newCount, int fastScrollToIndex); // 0x000000018B0BF3C0-0x000000018B0BF5A4
		public void InsertView(int index, string key, float initSize); // 0x000000018B0BEF1C-0x000000018B0BF010
		public void AddView(string key, float initSize); // 0x000000018B0BECB0-0x000000018B0BED90
		public override void OnAdapterInit(); // 0x000000018B0BF010-0x000000018B0BF340
		public void ClearComponent(); // 0x000000018B0BED90-0x000000018B0BEE90
	}

	public class UIRecycleSingleHolder : UIRecycleLayoutSimpleHolder<UIRecycleSingleHolder.SimpleVirtualView>, IUIClearable // TypeDefIndex: 50296
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
		public class SimpleVirtualView : UIRecycleLayoutAdapter.VirtualView // TypeDefIndex: 50295
		{
			// Fields
			private UIRecycleSingleHolder m_holder; // 0x18
			public float preferSize; // 0x20
	
			// Constructors
			public SimpleVirtualView(float initSize, UIRecycleSingleHolder holder); // 0x000000018B0B8278-0x000000018B0B8298
	
			// Methods
			public int GetIndex(); // 0x000000018B0B7FA4-0x000000018B0B805C
			public override GameObject GetPrefab(); // 0x000000018B0B805C-0x000000018B0B80B8
			public override float GetPreferSize(); // 0x000000018B0B80B8-0x000000018B0B8108
			protected override void OnViewDetached(); // 0x000000018B0B81C0-0x000000018B0B8278
			protected override void OnViewAttached(); // 0x000000018B0B8108-0x000000018B0B81C0
		}
	
		// Constructors
		public UIRecycleSingleHolder(); // 0x000000018B0BFCB0-0x000000018B0BFD7C
	
		// Methods
		public SimpleVirtualView GetVirtualView(int index); // 0x000000018B0BF8CC-0x000000018B0BF958
		[IDTag(1)]
		public void UpdateCount(int newCount, bool setTop = false /* Metadata: 0x0232FBA0 */); // 0x000000018B0BFA9C-0x000000018B0BFB1C
		[IDTag(0)]
		public void UpdateCount(int newCount, int fastScrollToIndex = -1 /* Metadata: 0x0232FBA1 */); // 0x000000018B0BFB1C-0x000000018B0BFCB0
		public void InsertView(int index, string key, float initSize); // 0x000000018B0BF958-0x000000018B0BFA3C
		public void AddView(string key, float initSize); // 0x000000018B0BF714-0x000000018B0BF7E4
		public override void OnAdapterInit(); // 0x000000018B0BFA3C-0x000000018B0BFA9C
		public void ClearComponent(); // 0x000000018B0BF7E4-0x000000018B0BF8CC
	}

	public class SimpleUITextSingleLine : UIText // TypeDefIndex: 50297
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
		public bool m_b; // 0xC98
		[CompilerGenerated]
		private Action<TMP_TextInfo> OnPreRenderText; // 0xCA0
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText {
			add; // 0x000000018B0B7E84-0x000000018B0B7F14
			remove; // 0x000000018B0B7F14-0x000000018B0B7FA4
		}
	
		// Constructors
		public SimpleUITextSingleLine(); // 0x000000018B0B7E34-0x000000018B0B7E84
		static SimpleUITextSingleLine(); // 0x000000018B0B7944-0x000000018B0B7E34
	
		// Methods
		protected override void GenerateTextMesh(); // 0x000000018B0903B8-0x000000018B09B164
		public void __iFixBaseProxy_GenerateTextMesh(); // 0x000000018B0B793C-0x000000018B0B7944
	}

	[RequireComponent(typeof(VerticalLayoutGroup))]
	public class ToastList : MonoBehaviour, IUIClearable // TypeDefIndex: 50300
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
		[CompilerGenerated]
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
		public bool inAnimation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D869F0-0x0000000184D86A00 0x0000000184D86A00-0x0000000184D86A10
	
		// Nested types
		private class CellInfo // TypeDefIndex: 50298
		{
			// Fields
			public int index; // 0x10
			public GameObject obj; // 0x18
			public UIAnimationWrapper animationWrapper; // 0x20
			public Coroutine cor; // 0x28
	
			// Constructors
			public CellInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __ShowCell_d__23 : IEnumerator<object> // TypeDefIndex: 50299
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public int delayIndex; // 0x20
			public CellInfo cell; // 0x28
			public ToastList __4__this; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __ShowCell_d__23(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B0B9060-0x000000018B0B92C0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B0B92C0-0x000000018B0B930C
		}
	
		// Constructors
		public ToastList(); // 0x000000018B0B8EB0-0x000000018B0B9014
	
		// Methods
		private void Awake(); // 0x000000018B0B83EC-0x000000018B0B844C
		private void OnDisable(); // 0x000000018B0B86A8-0x000000018B0B86F8
		private CellInfo _GetCell(); // 0x000000018B0B87C4-0x000000018B0B8938
		private void _CacheCell(CellInfo cell); // 0x000000018B0B86F8-0x000000018B0B87C4
		public void AddToast(int count, int startIndex = 0 /* Metadata: 0x0232FBA2 */); // 0x000000018B0B8298-0x000000018B0B83EC
		private void _StartBatch(int batchCount); // 0x000000018B0B8BAC-0x000000018B0B8CB4
		[IteratorStateMachine(typeof(__ShowCell_d__23))]
		private IEnumerator _ShowCell(int delayIndex, CellInfo cell); // 0x000000018B0B8AF0-0x000000018B0B8BAC
		private void _TryShowNewCell(); // 0x000000018B0B8CB4-0x000000018B0B8EB0
		private void _OnCellFinished(CellInfo cell); // 0x000000018B0B8938-0x000000018B0B8AF0
		public void ClearAllToast(); // 0x000000018B0B844C-0x000000018B0B8614
		public void ClearComponent(); // 0x000000018B0B8614-0x000000018B0B86A8
	}

	public class UI3DScrollList : UIScrollList // TypeDefIndex: 50301
	{
		// Constructors
		public UI3DScrollList(); // 0x000000018B0B93CC-0x000000018B0B9418
	
		// Methods
		protected override void MoveCellTo(Cell cell, int index); // 0x000000018B0B930C-0x000000018B0B93C4
		public void __iFixBaseProxy_MoveCellTo(Cell P0, int P1); // 0x000000018B0B93C4-0x000000018B0B93CC
	}

	public class UIActionKeyHint : MonoBehaviour, IUIClearable // TypeDefIndex: 50302
	{
		// Fields
		private static readonly UnityEngine.Color NORMAL_COLOR; // 0x00
		private static readonly UnityEngine.Color HIDE_COLOR; // 0x10
		private static readonly UnityEngine.Color DISABLED_COLOR; // 0x20
		private static List<UIActionKeyHint> s_keyHintCache; // 0x30
		private static bool s_inited; // 0x38
		public static bool s_stopCheckBindingEnabledForGuide; // 0x39
		private const string INVALID_KEY_STR = "none"; // Metadata: 0x0232FBAB
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
		[CompilerGenerated]
		private bool _hintHidden_k__BackingField; // 0xA9
		private int m_cachedBindingId; // 0xAC
		private bool m_isLongPressAction; // 0xB0
		private float m_lastPressStartTime; // 0xB4
		private const float LONG_PRESS_HINT_HIDE_TIME = 0.2f; // Metadata: 0x0232FBB0
		private const float LONG_PRESS_HINT_SHOW_MIN_VALUE = 0f; // Metadata: 0x0232FBB4
	
		// Properties
		private IBindingView target { get; } // 0x0000000182FA9540-0x0000000182FA9650 
		private bool showCanvasGroup { get; } // 0x000000018B0B9E6C-0x000000018B0B9EF0 
		public bool hintHidden { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182ED0880-0x0000000182ED0890 0x0000000184D90740-0x0000000184D90750
	
		// Constructors
		public UIActionKeyHint(); // 0x0000000183698F40-0x0000000183698F80
		static UIActionKeyHint(); // 0x0000000184B699F0-0x0000000184B69B00
	
		// Methods
		private static void _TryInit(); // 0x00000001833EC440-0x00000001833EC6A0
		private static void _RefreshAllKeyHints(); // 0x00000001849C6740-0x00000001849C6860
		private static void _OnInputLateTickAll(); // 0x0000000182FA7780-0x0000000182FA7940
		private static void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType); // 0x000000018B0B9B60-0x000000018B0B9BDC
		private void Awake(); // 0x00000001833EC2E0-0x00000001833EC440
		private void OnEnable(); // 0x00000001836D2960-0x00000001836D2A60
		private void OnDisable(); // 0x00000001836D27C0-0x00000001836D2960
		private void OnDestroy(); // 0x00000001836D4A00-0x00000001836D4B80
		private void Reset(); // 0x000000018B0B9418-0x000000018B0B9530
		private void _OnInputLateTick(); // 0x000000018B0B9C58-0x000000018B0B9C80
		public void UpdateKeyHint(); // 0x00000001836D2B50-0x00000001836D3DC0
		public void SetActionId(string id, bool forceUpdate = false /* Metadata: 0x0232FBA3 */); // 0x000000018B0B9530-0x000000018B0B95B0
		public void SetKeyHint(string actId, IBindingView hintTarget, bool forceUpdate = false /* Metadata: 0x0232FBA4 */); // 0x000000018B0B9674-0x000000018B0B9744
		[IDTag(0)]
		public void SetBindingId(int bId, bool forceUpdate = false /* Metadata: 0x0232FBA5 */); // 0x00000001837D5110-0x00000001837D51D0
		[IDTag(1)]
		public void SetBindingId(int bId, string actId, IBindingView hintTarget, bool forceUpdate = false /* Metadata: 0x0232FBA6 */); // 0x000000018B0B95B0-0x000000018B0B9674
		private void _OnChangeTarget(); // 0x00000001837D51D0-0x00000001837D5240
		private void _OnInputActionKeyUpdated([IsReadOnly] in EventData<string> data); // 0x000000018B0B9BDC-0x000000018B0B9C58
		public void SetSecondActionId(string id, bool isPrimary = false /* Metadata: 0x0232FBA7 */); // 0x00000001836D3ED0-0x00000001836D3FA0
		private void _SetSecondIcon(PlayerActionInfo actionInfo, bool isPrimary = false /* Metadata: 0x0232FBA8 */); // 0x00000001836D3FA0-0x00000001836D40E0
		private void _CheckInteractable(bool isInit); // 0x0000000182FA8C80-0x0000000182FA9540
		private bool _IsInputEnabled(); // 0x00000001837CD3A0-0x00000001837CD9C0
		private bool _IsInputGray(); // 0x000000018B0B9910-0x000000018B0B9B60
		public string GetTextStr(); // 0x0000000184814240-0x00000001848145D0
		public void SetText(string text); // 0x000000018B0B9744-0x000000018B0B97B0
		public bool GetAndSetActionIcon(UIImage iconImage, PlayerActionInfo actionInfo, bool usingController, out bool isLongPressAction, bool isPrimary = true /* Metadata: 0x0232FBA9 */); // 0x00000001836D40E0-0x00000001836D41E0
		public bool GetAndSetActionModifyIcon(PlayerActionInfo actionInfo, bool usingController, bool isPrimary = true /* Metadata: 0x0232FBAA */); // 0x00000001836D2AB0-0x00000001836D2B50
		private bool _SetKeyCodeSprite(UIImage iconImage, string iconPath); // 0x00000001836D4690-0x00000001836D4790
		private void _CheckVirtualMouseClickHint(); // 0x000000018B0B97B0-0x000000018B0B9860
		private void _UpdatePressHint(); // 0x000000018B0B9C80-0x000000018B0B9E6C
		private void _GetLongPressInfo(out float startTime, out float longPressTime); // 0x000000018B0B9860-0x000000018B0B9910
		public string GetActionId(); // 0x00000001837CE280-0x00000001837CE370
		public PlayerActionInfo GetActionInfo(); // 0x00000001836D3E50-0x00000001836D3ED0
		public void ClearComponent(); // 0x00000001836D2A60-0x00000001836D2AB0
		public void SetContentState(bool contentState); // 0x00000001836D3DC0-0x00000001836D3E50
	}

	public class UIAnimationHolder : MonoBehaviour, IAnimationClipSource // TypeDefIndex: 50304
	{
		// Fields
		[SerializeField]
		private List<ClipHolder> _clips; // 0x18
	
		// Nested types
		[Serializable]
		private class ClipHolder // TypeDefIndex: 50303
		{
			// Fields
			public AnimationClip clip; // 0x10
			public string alias; // 0x18
	
			// Constructors
			public ClipHolder(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public UIAnimationHolder(); // 0x0000000184CB6680-0x0000000184CB6710
	
		// Methods
		public AnimationClip FindByName(string name); // 0x000000018B0B9F58-0x000000018B0B9FC0
		public AnimationClip FindByNameOrAlias(string nameOrAlias); // 0x000000018B0B9EF0-0x000000018B0B9F58
		private AnimationClip _FindByString(string id, bool useAlias); // 0x000000018B0BA014-0x000000018B0BA228
		public void GetAnimationClips(List<AnimationClip> results); // 0x000000018B0B9FC0-0x000000018B0BA014
	}

	public class UIAnimationLoopSynchronizer : MonoBehaviour // TypeDefIndex: 50305
	{
		// Fields
		public string syncLoopAnimKey; // 0x18
		private readonly List<UIAnimationWrapper> m_children; // 0x20
	
		// Constructors
		public UIAnimationLoopSynchronizer(); // 0x0000000184CB65F0-0x0000000184CB6680
	
		// Methods
		public void RegisterChild(UIAnimationWrapper child); // 0x000000018466FA60-0x000000018466FB00
		public void UnregisterChild(UIAnimationWrapper child); // 0x000000018B0BA228-0x000000018B0BA2B4
		public float GetLoopStartPosition(); // 0x0000000183543CE0-0x0000000183543DA0
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(Animation))]
	public class UIAnimationWrapper : MonoBehaviour, IUIClearable // TypeDefIndex: 50313
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
		[HideInInspector]
		public DisposedUnityEvent onAnimationInEasingFinished; // 0x88
		private bool m_needNotifyAnimationInEasingFinished; // 0x90
		private float m_lastPlayAnimationInStartTime; // 0x94
		private bool m_started; // 0x98
		private CachedSampleClipInfo m_cachedSampleClipInfo; // 0xA0
		private bool m_needInformAnimationInEnd; // 0xB0
		private LuaPanel m_panel; // 0xB8
		[AudioString]
		[SerializeField]
		private string _audioOnOpen; // 0xC0
		[AudioString]
		[SerializeField]
		private string _audioOnClose; // 0xC8
	
		// Properties
		public AnimationClip animationIn { get; } // 0x00000001835425C0-0x00000001835425F0 
		public AnimationClip animationInEasing { get; } // 0x000000018B0BAD28-0x000000018B0BAD78 
		public AnimationClip animationLoop { get; } // 0x000000018B0BAD78-0x000000018B0BADC8 
		public AnimationClip animationOut { get; } // 0x0000000183D2AFA0-0x0000000183D2AFD0 
		public UIAnimationTween curTween { get; } // 0x0000000183543DA0-0x0000000183543DD0 
		public LuaPanel panel { get; } // 0x00000001832EA2C0-0x00000001832EA350 
	
		// Nested types
		private class AnimationRuntime // TypeDefIndex: 50306
		{
			// Fields
			public UIAnimationTween.Options option; // 0x10
			public UnityEngine.AnimationState state; // 0x20
			public bool isPlaying; // 0x28
	
			// Constructors
			public AnimationRuntime(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public float GetClipLength(); // 0x000000018384AA80-0x000000018384AB50
		}
	
		[Serializable]
		public struct FOptions : ILuaCallCSharp // TypeDefIndex: 50307
		{
			// Fields
			public Ease animEase; // 0x00
	
			// Methods
			public static FOptions GetDefault(); // 0x0000000183698310-0x0000000183698340
		}
	
		private struct CachedSampleClipInfo // TypeDefIndex: 50308
		{
			// Fields
			public AnimationRuntime runtime; // 0x00
			public float position; // 0x08
			public bool isDirty; // 0x0C
	
			// Constructors
			public CachedSampleClipInfo(bool isDirty); // 0x0000000185393540-0x0000000185393560
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0 // TypeDefIndex: 50309
		{
			// Fields
			public UIAnimationWrapper __4__this; // 0x10
			public TweenCallback callback; // 0x18
	
			// Constructors
			public __c__DisplayClass37_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _PlayOutAnimation_b__0(); // 0x00000001835447D0-0x0000000183544810
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0 // TypeDefIndex: 50310
		{
			// Fields
			public TweenCallback callback; // 0x10
			public UIAnimationWrapper __4__this; // 0x18
			public bool autoPlayLoop; // 0x20
	
			// Constructors
			public __c__DisplayClass46_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _PlayInAnimation_b__0(); // 0x0000000183543880-0x00000001835438C0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 50311
		{
			// Fields
			public UIAnimationWrapper __4__this; // 0x10
			public bool autoPlayLoop; // 0x18
	
			// Constructors
			public __c__DisplayClass53_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __OnInAnimationFinished_b__0(); // 0x0000000183542590-0x00000001835425C0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 50312
		{
			// Fields
			public UIAnimationWrapper __4__this; // 0x10
			public TweenCallback onComplete; // 0x18
			public UIAnimationTween animTween; // 0x20
	
			// Constructors
			public __c__DisplayClass74_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _PlayWithTween_b__0(); // 0x0000000183545240-0x0000000183545A40
		}
	
		// Constructors
		public UIAnimationWrapper(); // 0x00000001836981B0-0x0000000183698310
		static UIAnimationWrapper(); // 0x0000000184D16950-0x0000000184D169E0
	
		// Methods
		public void SetOptions(FOptions options); // 0x0000000184D79890-0x0000000184D798D0
		private void _InitAnimation(); // 0x00000001832ECD90-0x00000001832ED360
		private void _AnimationInLoopCheck(); // 0x000000018B0BAB08-0x000000018B0BAD28
		private void _AnimationAutomaticallyCheck(); // 0x000000018B0BAA30-0x000000018B0BAB08
		private void Awake(); // 0x00000001832EB7B0-0x00000001832EBD10
		public bool IsStarted(); // 0x000000018B0BA560-0x000000018B0BA5B0
		public void PlayOutAnimation(TweenCallback callback = null); // 0x0000000183544530-0x0000000183544680
		public void SetAnimationInClip(string clipName); // 0x000000018B0BA688-0x000000018B0BA700
		public void SetAnimationInEasingClip(string clipName); // 0x000000018B0BA700-0x000000018B0BA778
		public void SetAnimationLoopClip(string clipName); // 0x000000018B0BA778-0x000000018B0BA7F0
		public void SetAnimationOutClip(string clipName); // 0x000000018B0BA7F0-0x000000018B0BA868
		public float GetInClipLength(); // 0x000000018B0BA380-0x000000018B0BA420
		public float GetOutClipLength(); // 0x000000018B0BA4C0-0x000000018B0BA560
		public float GetLoopClipLength(); // 0x000000018B0BA420-0x000000018B0BA4C0
		public void PlayLoopAnimation(float speed = 1f /* Metadata: 0x0232FBB8 */, bool preserveStartPosition = false /* Metadata: 0x0232FBBC */); // 0x0000000183543B90-0x0000000183543CE0
		public void PlayInAnimation(TweenCallback callback = null, bool autoPlayLoop = true /* Metadata: 0x0232FBBD */, float speed = 1f /* Metadata: 0x0232FBBE */); // 0x00000001832EA020-0x00000001832EA1B0
		public void SkipInAnimation(); // 0x000000018B0BA8D0-0x000000018B0BAA30
		public void SampleToInAnimationBegin(); // 0x0000000183CCED70-0x0000000183CCEE30
		public void SampleToInAnimationEnd(); // 0x0000000183848BE0-0x0000000183848C90
		public void SampleToOutAnimationBegin(); // 0x0000000184CDC520-0x0000000184CDC5D0
		public void SampleToOutAnimationEnd(); // 0x000000018384B800-0x000000018384B8B0
		private void _OnInAnimationFinished(bool autoPlayLoop = true /* Metadata: 0x0232FBC2 */); // 0x00000001835438C0-0x0000000183543A90
		private void _OnInEasingAnimationFinished(bool autoPlayLoop); // 0x0000000183543A90-0x0000000183543B30
		public UnityEngine.AnimationState GetClip(string aniName); // 0x00000001832EBDE0-0x00000001832EBEE0
		public float GetClipLength(string aniName); // 0x000000018384A980-0x000000018384AA80
		private void _SampleClipAtLength(AnimationRuntime runtime, float position); // 0x00000001832EC900-0x00000001832ECBE0
		public void SampleClipAtPercent(string clipName, float percent, bool clearTween = true /* Metadata: 0x0232FBC3 */); // 0x000000018384A900-0x000000018384A980
		public void SampleClip(string clipName, float position, bool clearTween = true /* Metadata: 0x0232FBC4 */); // 0x00000001832EC6E0-0x00000001832EC900
		public void ClearTween(bool executeOnComplete = true /* Metadata: 0x0232FBC5 */); // 0x00000001832ED470-0x00000001832ED660
		private bool _CheckShouldAutoPlayAnimationIn(); // 0x00000001832E9F20-0x00000001832E9F60
		private void Start(); // 0x00000001841CE700-0x00000001841CE770
		private void OnEnable(); // 0x00000001832E9D80-0x00000001832E9F20
		private void OnDisable(); // 0x00000001832EBD10-0x00000001832EBDC0
		private void OnDestroy(); // 0x00000001832EE8F0-0x00000001832EE950
		public bool CheckStopped(); // 0x000000018B0BA2B4-0x000000018B0BA308
		[IDTag(0)]
		public void Play(AnimationClip animationClip, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x0232FBC6 */, float startPlayTime = 0f /* Metadata: 0x0232FBC7 */, bool clearTween = true /* Metadata: 0x0232FBCB */); // 0x000000018B0BA5B0-0x000000018B0BA688
		[IDTag(1)]
		public void Play(string stateName, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x0232FBCC */, float startPlayTime = 0f /* Metadata: 0x0232FBCD */, bool clearTween = true /* Metadata: 0x0232FBD1 */); // 0x0000000183CD5DD0-0x0000000183CD5E60
		[IDTag(1)]
		public void PlayWithTween(AnimationClip animationClip, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x0232FBD2 */, float startPlayTime = 0f /* Metadata: 0x0232FBD3 */, bool clearTween = true /* Metadata: 0x0232FBD7 */, float speed = 1f /* Metadata: 0x0232FBD8 */); // 0x00000001832EA210-0x00000001832EA2C0
		[IDTag(0)]
		public void PlayWithTween(string stateName, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x0232FBDC */, float startPlayTime = 0f /* Metadata: 0x0232FBDD */, bool clearTween = true /* Metadata: 0x0232FBE1 */, float speed = 1f /* Metadata: 0x0232FBE2 */); // 0x00000001832EA350-0x00000001832EB770
		public float GetCurPlayingTime(); // 0x000000018B0BA308-0x000000018B0BA380
		public void SetAudioOnOpen(string audioOnOpen); // 0x000000018B0BA868-0x000000018B0BA8D0
		public void PlayOpenAudio(); // 0x00000001832EA1B0-0x00000001832EA210
		public void PlayCloseAudio(); // 0x0000000183544680-0x00000001835446E0
		public void ClearComponent(); // 0x00000001832ED3F0-0x00000001832ED470
		private void _NotifyAnimationInEasingFinished(); // 0x0000000183543B30-0x0000000183543B90
	}

	public class UIAnimationTween // TypeDefIndex: 50317
	{
		// Fields
		public static readonly Options DEFAULT_OPTION; // 0x00
		private DG.Tweening.Tween m_handler; // 0x10
		private float m_tweenValue; // 0x18
		private GameObject m_animTarget; // 0x20
		[CompilerGenerated]
		private float _clipLength_k__BackingField; // 0x28
	
		// Properties
		public DG.Tweening.Tween handler { get; } // 0x00000001832ED660-0x00000001832ED690 
		public float tweenValue { get; } // 0x0000000183543DD0-0x0000000183543E00 
		public float clipLength { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
	
		// Nested types
		public struct Options // TypeDefIndex: 50314
		{
			// Fields
			public bool isInverse; // 0x00
			public float startPosition; // 0x04
			public float speed; // 0x08
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 50315
		{
			// Fields
			public UIAnimationTween __4__this; // 0x10
			public UIAnimationWrapper wrapper; // 0x18
			public string name; // 0x20
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _.ctor_b__0(float value); // 0x00000001832EBEE0-0x00000001832EBF20
			internal void _.ctor_b__2(float value); // 0x00000001832EBF20-0x00000001832EC3A0
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 50316
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static DOGetter<float> __9__14_1; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D431B0-0x0000000184D43210
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _.ctor_b__14_1(); // 0x0000000184D879D0-0x0000000184D879E0
		}
	
		// Constructors
		public UIAnimationTween(GameObject target, UIAnimationWrapper wrapper, string name); // 0x000000018B0C1AB0-0x000000018B0C1B50
		public UIAnimationTween(GameObject target, UIAnimationWrapper wrapper, string name, Options options); // 0x00000001832ED9C0-0x00000001832EE410
		static UIAnimationTween(); // 0x0000000184D53780-0x0000000184D537E0
	
		// Methods
		public float GetValue(); // 0x0000000184255010-0x0000000184255040
		private void _SetValue(UIAnimationWrapper wrapper, string name, float value); // 0x00000001832EC3A0-0x00000001832EC6E0
	}

	public class UIAnimationSwitchTween : UISwitchTween // TypeDefIndex: 50320
	{
		// Fields
		private UIAnimationWrapper m_animWrapper; // 0x30
		private bool m_dontDisableGameObject; // 0x38
	
		// Nested types
		private class TweenHandler : UISwitchTween.ITweenHandler // TypeDefIndex: 50318
		{
			// Fields
			private UIAnimationSwitchTween m_closure; // 0x10
			private bool m_isIn; // 0x18
			private bool m_pendingClear; // 0x19
			private TweenCallback m_pendingCallback; // 0x20
			private bool m_isComplete; // 0x28
	
			// Constructors
			public TweenHandler(UIAnimationSwitchTween closure, bool isIn); // 0x000000018B0C15EC-0x000000018B0C16E8
	
			// Methods
			public bool IsPlaying(); // 0x000000018B0C1328-0x000000018B0C13F0
			public void KillIfNecessary(); // 0x000000018B0C13F0-0x000000018B0C14B0
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback); // 0x000000018B0C14B0-0x000000018B0C152C
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill); // 0x000000018B0C152C-0x000000018B0C1584
			private void _OnComplete(); // 0x000000018B0C1584-0x000000018B0C15EC
		}
	
		public struct Builder // TypeDefIndex: 50319
		{
			// Fields
			public UIAnimationWrapper animWrapper; // 0x00
			public bool dontDisableGameObject; // 0x08
	
			// Methods
			public UIAnimationSwitchTween Build(); // 0x000000018B0C1284-0x000000018B0C1328
		}
	
		// Constructors
		public UIAnimationSwitchTween(UIAnimationWrapper animWrapper); // 0x0000000185396200-0x0000000185396210
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide(); // 0x000000018B0C1970-0x000000018B0C1A04
		protected override ITweenHandler GenerateTweenOfShow(); // 0x000000018B0C1A04-0x000000018B0C1A98
		protected override void BeforeShowEffect(); // 0x000000018B0C1918-0x000000018B0C1970
		protected override void AfterHideEffect(); // 0x000000018B0C18C0-0x000000018B0C1918
		protected override void ResetToState(bool isShow); // 0x0000000184B30370-0x0000000184B30460
		private void _SetGameObjectActive(bool isActive); // 0x0000000184B30460-0x0000000184B304C0
		public void __iFixBaseProxy_BeforeShowEffect(); // 0x000000018B0C1AA0-0x000000018B0C1AA8
		public void __iFixBaseProxy_AfterHideEffect(); // 0x000000018B0C1A98-0x000000018B0C1AA0
		public void __iFixBaseProxy_ResetToState(bool P0); // 0x000000018B0C1AA8-0x000000018B0C1AB0
	}

	public class UIArea : TickableUIMono, IPointerEnterHandler, IPointerExitHandler, IUIClearable // TypeDefIndex: 50321
	{
		// Fields
		[HideInInspector]
		public UnityEvent<PointerEventData> onPointerEnter; // 0x68
		[HideInInspector]
		public UnityEvent<PointerEventData> onPointerExit; // 0x70
		private bool m_pointerInArea; // 0x78
		public GameObject _highlightNode; // 0x80
		[SerializeField]
		[Tooltip("\u542F\u7528\u65F6\u5728 Tick \u4E2D\u6839\u636E\u6307\u9488\u4F4D\u7F6E\u662F\u5426\u5728 Rect \u5185\u89E6\u53D1 enter/exit\uFF0C\u9002\u7528\u4E8E\u88AB\u4E0A\u5C42 RaycastTarget \u906E\u6321\u65F6")]
		private bool _usePositionCheckMode; // 0x88
		private RectTransform m_rectTransform; // 0x90
		private Canvas m_canvas; // 0x98
	
		// Properties
		public bool pointerInArea { get; } // 0x000000018B0C21F8-0x000000018B0C2244 
		public bool usePositionCheckMode { get; } // 0x000000018B0C2294-0x000000018B0C22E4 
		protected override TickType tickOption { get; } // 0x000000018B0C2244-0x000000018B0C2294 
	
		// Constructors
		public UIArea(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		private void _SetHighlightNodeActive(bool active); // 0x000000018B0C2140-0x000000018B0C21F8
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018B0C1DBC-0x000000018B0C1E58
		public void OnPointerExit(PointerEventData eventData); // 0x000000018B0C1E58-0x000000018B0C1EF4
		protected override void OnAwake(); // 0x000000018B0C1BBC-0x000000018B0C1C94
		public override void Tick(float deltaTime); // 0x000000018B0C1EF4-0x000000018B0C2094
		private static Vector2 _GetPointerScreenPosition(); // 0x000000018B0C2094-0x000000018B0C2140
		protected override void OnEnable(); // 0x000000018B0C1D5C-0x000000018B0C1DBC
		protected override void OnDisable(); // 0x000000018B0C1CF8-0x000000018B0C1D5C
		protected override void OnDestroy(); // 0x000000018B0C1C94-0x000000018B0C1CF8
		public void ClearComponent(); // 0x000000018B0C1B50-0x000000018B0C1BBC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000181538B20-0x0000000181538B30
	}

	public class UIAutoCloseArea : TickableUIMono, IUIClearable, IBindingGroupTarget // TypeDefIndex: 50322
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
		[CompilerGenerated]
		private int _groupId_k__BackingField; // 0xB8
		[CompilerGenerated]
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0xC0
		private bool m_bindingInit; // 0xC8
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001846DBBC0-0x00000001846DBBF0 
		public bool includeInAutoCloseLayer { get; set; } // 0x00000001844F4560-0x00000001844F4590 0x000000018B0C277C-0x000000018B0C282C
		public LuaPanel panel { get; } // 0x00000001844552D0-0x0000000184455360 
		public int groupId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E580-0x0000000184D8E590 0x0000000184D8E5A0-0x0000000184D8E5B0
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D892F0-0x0000000184D89300 0x0000000186AC5ACC-0x0000000186AC5AE0
		public bool groupEnabled { get; } // 0x000000018B0C26F4-0x000000018B0C277C 
	
		// Constructors
		public UIAutoCloseArea(); // 0x00000001845F98E0-0x00000001845F99E0
		static UIAutoCloseArea(); // 0x0000000184D13DE0-0x0000000184D13E70
	
		// Methods
		private void Start(); // 0x00000001848B9860-0x00000001848B9930
		private void Reset(); // 0x000000018B0C24E8-0x000000018B0C25A4
		public override void LateTick(float deltaTime); // 0x00000001837CEB00-0x00000001837CEBC0
		protected override void OnEnable(); // 0x00000001844F44B0-0x00000001844F4560
		protected override void OnDisable(); // 0x00000001844F4360-0x00000001844F4410
		public void ChangeEnableCloseActionOnController(bool enabled); // 0x000000018B0C22E4-0x000000018B0C2354
		public void CloseSelf(); // 0x00000001843B3250-0x00000001843B3310
		public void TryCloseSelf(); // 0x000000018B0C25A4-0x000000018B0C2650
		public void OpenSelf(bool executeOnComplete = true /* Metadata: 0x0232FBE6 */); // 0x000000018B0C23F8-0x000000018B0C24E8
		public bool ShouldClose(); // 0x00000001837CEBC0-0x00000001837CF460
		public void ClearComponent(); // 0x0000000184B3A270-0x0000000184B3A2B0
		private void _AutoCloseToggleObjWhenOut(); // 0x000000018B0C2650-0x000000018B0C26F4
		public static void AddToAutoCloseLayer(GameObject go); // 0x00000001844F4590-0x00000001844F4670
		public static void RemoveFromAutoCloseLayer(GameObject go); // 0x00000001844F4410-0x00000001844F44B0
		public static bool IsTopAutoCloseLayer(GameObject go); // 0x000000018447E100-0x000000018447E1E0
		private Camera _GetUICamera(); // 0x0000000184455210-0x00000001844552D0
		public void InitBinding(); // 0x00000001848B9930-0x00000001848B9A00
		private void _UpdateState(); // 0x00000001844F4670-0x00000001844F4840
		protected override void OnDestroy(); // 0x000000018B0C2354-0x000000018B0C23F8
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000181538B20-0x0000000181538B30
	}

	public class UIBigLogo : MonoBehaviour // TypeDefIndex: 50323
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
		[SerializeField]
		public RectTransform _fitImageMain; // 0x60
		[SerializeField]
		public UIImage _fitImageTop; // 0x68
		[SerializeField]
		public CanvasGroup _fitImageTopBg; // 0x70
		[SerializeField]
		public UIImage _fitImageBottom; // 0x78
		[SerializeField]
		public CanvasGroup _fitImageBottomBg; // 0x80
	
		// Constructors
		public UIBigLogo(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void SetBigLogoEditor(string bigLogoPath, bool useStretchImage, bool showOnTop, bool hideBackground, bool useOriginalImage, bool useFitImage); // 0x000000018B0C2CFC-0x000000018B0C2D94
		public void ShowBigLogo(bool useStretchImage, bool showOnTop, bool useOriginalImage, bool useFitImage, float originalImageScale); // 0x000000018B0C2F70-0x000000018B0C322C
		public void SetBigLogoMask(UnityEngine.Color maskColor); // 0x000000018B0C2D94-0x000000018B0C2EA8
		public void ClearBigLogoMask(); // 0x000000018B0C282C-0x000000018B0C28DC
		public void ClearBigLogo(bool showOnTop); // 0x000000018B0C28DC-0x000000018B0C2ACC
		public void SetAlpha(float alpha, bool showOnTop); // 0x000000018B0C2ACC-0x000000018B0C2CFC
		public void SetMaskAlpha(float alpha); // 0x000000018B0C2EA8-0x000000018B0C2F70
	}

	public class UIBigRectButton : UIButton, IDragHandler, IBeginDragHandler, IEndDragHandler, UnityEngine.EventSystems.IScrollHandler // TypeDefIndex: 50324
	{
		// Fields
		[SerializeField]
		private UIBigRectHelper _bigRectHelper; // 0x2E0
	
		// Constructors
		public UIBigRectButton(); // 0x0000000183698EC0-0x0000000183698ED0
	
		// Methods
		private void _TryThroughEventDataToBigRectTouchPanelRaycast<T>(PointerEventData eventData, ExecuteEvents.EventFunction<T> eventFunction)
			where T : IEventSystemHandler;
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018463DB40-0x000000018463DC20
		public override void OnPointerUp(PointerEventData eventData); // 0x00000001845FC110-0x00000001845FC1F0
		public void OnDrag(PointerEventData eventData); // 0x000000018B0C32D0-0x000000018B0C3374
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018B0C322C-0x000000018B0C32D0
		public void OnEndDrag(PointerEventData eventData); // 0x000000018B0C3374-0x000000018B0C3418
		public void OnScroll(PointerEventData eventData); // 0x000000018B0C3418-0x000000018B0C34BC
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0); // 0x000000018B0C34BC-0x000000018B0C34C4
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0); // 0x000000018B0C34C4-0x000000018B0C34CC
	}

	public class UIBigRectHelper : TickableUIMono, IUIClearable // TypeDefIndex: 50327
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
		private const string CLICK_ACTION_ID = "big_rect_click"; // Metadata: 0x0232FBED
		private const string CLICK_NO_HINT_ACTION_ID = "big_rect_click_no_hint"; // Metadata: 0x0232FBFC
		private const float DELTA_TIME_TO_STICK_VALUE_RATIO = 100f; // Metadata: 0x0232FC13
		[CompilerGenerated]
		private int _clickBindingId_k__BackingField; // 0x1B4
		[CompilerGenerated]
		private bool _controllerMoveEnabled_k__BackingField; // 0x1B8
		[CompilerGenerated]
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
		protected override TickType tickOption { get; } // 0x0000000184733320-0x0000000184733350 
		public DisposedUnityEvent OnOpenTweenFinished { get; } // 0x000000018B0C4B64-0x000000018B0C4BB4 
		private float zoomRangeMin { get; } // 0x0000000183E9AC30-0x0000000183E9AC70 
		public DisposedUnityEvent<int, bool> zoomEvent { get; } // 0x000000018B0C4BB4-0x000000018B0C4C04 
		public UITouchPanel touchPanel { get; } // 0x000000018445E920-0x000000018445E950 
		public int clickBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D84A90-0x0000000184D84AA0 0x0000000184DAAE00-0x0000000184DAAE10
		public bool controllerMoveEnabled { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D90170-0x0000000184D90180 0x0000000184D90180-0x0000000184D90190
		public bool controllerZoomEnabled { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAADF0-0x0000000184DAAE00 0x0000000184DAAE10-0x0000000184DAAE20
	
		// Nested types
		public sealed class BigRectRecoverState // TypeDefIndex: 50325
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
			public BigRectRecoverState(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0 // TypeDefIndex: 50326
		{
			// Fields
			public TweenCallback onComplete; // 0x10
	
			// Constructors
			public __c__DisplayClass82_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _FocusNode_b__0(); // 0x0000000184D30F10-0x0000000184D30F30
		}
	
		// Constructors
		public UIBigRectHelper(); // 0x000000018445D560-0x000000018445D850
	
		// Methods
		protected override void OnAwake(); // 0x00000001839D2F90-0x00000001839D3170
		public override void Tick(float deltaTime); // 0x0000000183FD45D0-0x0000000183FD4620
		public override void LateTick(float deltaTime); // 0x0000000183E9AE60-0x0000000183E9AEB0
		protected override void OnRelease(); // 0x0000000184B2CD70-0x0000000184B2CDD0
		private void _OnDrag(Vector2 value); // 0x0000000183E9AF20-0x0000000183E9AFD0
		public void ManuallyZoom(float value, bool needTween); // 0x000000018B0C3A88-0x000000018B0C3B04
		[IDTag(1)]
		private void _RefreshPivotPosition(); // 0x000000018B0C48DC-0x000000018B0C4984
		private void _OnZoom(float value, bool needTween); // 0x000000018B0C4110-0x000000018B0C419C
		private void _SetZoomValueAndScale(float value, bool needTween); // 0x0000000183E9A810-0x0000000183E9A960
		private void _SetScale(bool needTween, float zoomTweenTime = 0f /* Metadata: 0x0232FBE7 */, AnimationCurve curve = null, TweenCallback onFinish = null); // 0x0000000183E9BAC0-0x0000000183E9BC60
		private void _GetContainerRectBounds(out Vector2 leftBottom, out Vector2 rightTop); // 0x0000000183E9B840-0x0000000183E9B9B0
		private Vector2 _GetAdjustedPosition(Vector2 position); // 0x0000000183E9B570-0x0000000183E9B740
		private void _PosAdjust(); // 0x0000000183E9AFD0-0x0000000183E9B040
		private void _RefreshPivotPositionToMousePosition(); // 0x000000018B0C46DC-0x000000018B0C48DC
		[IDTag(0)]
		private void _RefreshPivotPosition(Vector3 targetScreenPosition); // 0x000000018315F0C0-0x000000018315F410
		private void _UpdatePositionOffsetAfterZoomed(); // 0x0000000183E9A700-0x0000000183E9A810
		private void _TryAlignWhenInit(); // 0x000000018B0C4984-0x000000018B0C4B64
		public void Init(); // 0x0000000183E9A960-0x0000000183E9AC30
		[IDTag(0)]
		public void FocusNode(float nodeX, float nodeY, TweenCallback onComplete); // 0x000000018B0C3654-0x000000018B0C3804
		[IDTag(1)]
		public void FocusNode(RectTransform nodeRect, bool needTween = true /* Metadata: 0x0232FBEB */, TweenCallback onComplete = null); // 0x0000000183E9B040-0x0000000183E9B460
		public void ZoomToFullRect(TweenCallback onComplete = null); // 0x000000018B0C3EBC-0x000000018B0C3F44
		public void ChangePaddingRight(int right); // 0x000000018B0C34CC-0x000000018B0C3540
		public void SetZoomRangeMax(float maxValue); // 0x0000000184D11310-0x0000000184D11350
		public void OverrideZoomRangeMin(float minValue); // 0x0000000184CE4B80-0x0000000184CE4BC0
		public void SyncZoomValue(float zoomValue, bool needTween = true /* Metadata: 0x0232FBEC */); // 0x0000000183E9A6A0-0x0000000183E9A700
		public BigRectRecoverState GetRecoverState(); // 0x000000018B0C3854-0x000000018B0C3A0C
		public void GetZoomRange(out float rangeMin, out float rangeMax); // 0x000000018B0C3A0C-0x000000018B0C3A88
		public float GetCurrentZoomValue(); // 0x000000018B0C3804-0x000000018B0C3854
		public void ChangePivotPositionToTarget(RectTransform target); // 0x000000018B0C3540-0x000000018B0C3654
		public void ResetPivotPositionToScreenCenter(); // 0x000000018315F030-0x000000018315F0C0
		public void RecoverContainerState(BigRectRecoverState state); // 0x000000018B0C3B04-0x000000018B0C3CF4
		public void ClearComponent(); // 0x00000001846EA510-0x00000001846EA5F0
		public void ClearAllTween(); // 0x00000001846EA5F0-0x00000001846EA670
		private void _InitControllerBindings(); // 0x00000001837D5DB0-0x00000001837D5FA0
		private bool _GetIsControllerMoveEnabled(); // 0x0000000183FD4860-0x0000000183FD48B0
		private bool _GetIsControllerZoomEnabled(); // 0x0000000183FD4760-0x0000000183FD47B0
		private void _ResetControllerState(); // 0x0000000183E9AD00-0x0000000183E9AE60
		private void _TickRefreshController(float deltaTime); // 0x0000000183FD4620-0x0000000183FD4680
		private void _TickRefreshControllerStickMove(float deltaTime); // 0x0000000183FD47B0-0x0000000183FD4860
		private void _RefreshControllerFocusRaycastResults(bool ignoreTouchPanel, out Selectable hitSelectable, out UITouchPanel hitTouchPanel); // 0x000000018B0C419C-0x000000018B0C46DC
		private void _TickCheckControllerFocusRaycastTargets(); // 0x0000000183E9AEB0-0x0000000183E9AF20
		private void _OnControllerClick(); // 0x000000018B0C3F44-0x000000018B0C4110
		private void _TickRefreshControllerStickZoom(float deltaTime); // 0x0000000183FD4680-0x0000000183FD46D0
		private void _TickRefreshControllerZoomKeyHint(); // 0x0000000183FD46D0-0x0000000183FD4760
		[CompilerGenerated]
		private void _OnAwake_b__63_0(PointerEventData eventData); // 0x0000000183E9AC70-0x0000000183E9AD00
		[CompilerGenerated]
		private void _OnAwake_b__63_1(float zoomValue); // 0x000000018B0C3E1C-0x000000018B0C3E9C
		[CompilerGenerated]
		private void __SetScale_b__72_0(); // 0x000000018B0C3E9C-0x000000018B0C3EBC
		[CompilerGenerated]
		private void _Init_b__80_0(); // 0x000000018B0C3CF4-0x000000018B0C3E1C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	public class UIBlendImage : UIImage // TypeDefIndex: 50328
	{
		// Fields
		private static Dictionary<string, Material> s_materials; // 0x00
		private Material m_originalMaterial; // 0x228
		private bool m_initialized; // 0x230
	
		// Constructors
		public UIBlendImage(); // 0x000000018B0C4FC4-0x000000018B0C4FCC
		static UIBlendImage(); // 0x0000000184D168C0-0x0000000184D16950
	
		// Methods
		public void SetMaterialKey(string key); // 0x000000018B0C4CA8-0x000000018B0C4F38
		public void SetColor(string materialId, UnityEngine.Color c); // 0x000000018B0C4C04-0x000000018B0C4CA8
		public void SetTexture(string materialId, Texture t); // 0x000000018B0C4F38-0x000000018B0C4FC4
		public static void ClearMaterialCache(); // 0x0000000183C11520-0x0000000183C115B0
	}

	public class UIBlurMono : TickableUIMono // TypeDefIndex: 50329
	{
		// Fields
		private Canvas m_canvas; // 0x68
		private LuaPanel m_panel; // 0x70
		private int m_sortingOrder; // 0x78
		private HGCamera m_camera; // 0x80
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000184A355E0-0x0000000184A35610 
		public Canvas canvas { get; } // 0x0000000183F02FB0-0x0000000183F03060 
		private LuaPanel panel { get; } // 0x0000000183F02E50-0x0000000183F02FB0 
	
		// Constructors
		public UIBlurMono(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		protected override void OnEnable(); // 0x0000000183F02D60-0x0000000183F02E50
		protected override void OnDisable(); // 0x0000000183F02B50-0x0000000183F02BB0
		public override void Tick(float deltaTime); // 0x000000018B0C4FCC-0x000000018B0C50BC
		public void UpdateSortingOrder(int order); // 0x000000018B0C50BC-0x000000018B0C5148
		private HGCamera _GetCamera(); // 0x0000000183F02BB0-0x0000000183F02D60
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	[RequireComponent(typeof(RawImage))]
	public class UIBlurRT : MonoBehaviour // TypeDefIndex: 50330
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
		[CompilerGenerated]
		private Texture _customBlurTexture_k__BackingField; // 0x50
	
		// Properties
		public RawImage rawImage { get; } // 0x000000018B0C5504-0x000000018B0C5554 
		public Texture customBlurTexture { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
	
		// Constructors
		public UIBlurRT(); // 0x0000000184D516C0-0x0000000184D516F0
	
		// Methods
		private void Reset(); // 0x000000018B0C5198-0x000000018B0C5218
		public void InitRT(); // 0x00000001837DE9F0-0x00000001837DED20
		public void Register(); // 0x00000001837DD390-0x00000001837DD4D0
		public void UnRegister(); // 0x000000018B0C5340-0x000000018B0C5430
		public void UpdateRT(); // 0x000000018B0C5430-0x000000018B0C5504
		private void OnEnable(); // 0x0000000184A06D90-0x0000000184A06DE0
		private void OnDisable(); // 0x0000000184CA2BD0-0x0000000184CA2C10
		private void OnDestroy(); // 0x000000018B0C5148-0x000000018B0C5198
		private void _Clear(); // 0x00000001837DD120-0x00000001837DD260
		public void SetUseSceneColorPS(bool useSceneColorPS, bool forceUpdate = false /* Metadata: 0x0232FC17 */); // 0x00000001837DBF40-0x00000001837DC090
		public void SetCustomBlurImg(Texture texture); // 0x000000018B0C5218-0x000000018B0C5340
	}

	public class UIButton : Selectable, IPointerClickHandler, IBindingGroupTarget, IBindingView, IUIClearable // TypeDefIndex: 50333
	{
		// Fields
		[AudioString]
		[FormerlySerializedAs("_audioClick")]
		[SerializeField]
		private string _audioPressStart; // 0x188
		[AudioString]
		[SerializeField]
		private string _audioOnClick; // 0x190
		[AudioString]
		[SerializeField]
		private string _audioRelease; // 0x198
		[AudioString]
		[SerializeField]
		private string _audioLongPress; // 0x1A0
		[AudioString]
		[SerializeField]
		private string _audioInvalid; // 0x1A8
		[SerializeField]
		[Tooltip("AutoTriggerOnClick\u65F6\u4E0D\u89E6\u53D1PressStart\u548COnClick\u7684\u97F3\u6548")]
		private bool _noAudioWhenAutoTriggerOnClick; // 0x1B0
		private const float MIN_DRAG_DIST = 10f; // Metadata: 0x0232FC19
		private const float DOUBLE_CLICK_MAX_INTERVAL = 0.3f; // Metadata: 0x0232FC1D
		public UIEvent<PointerEventData> onClick; // 0x1B8
		public UIEvent<PointerEventData> onDoubleClick; // 0x1C0
		[SerializeField]
		public bool _ignoreClickOnDrag; // 0x1C8
		[SerializeField]
		public bool _clickThrough; // 0x1C9
		[SerializeField]
		[Tooltip("\u53EA\u662F\u4E24\u6B21\u5355\u51FB\u89E6\u53D1\u7684CD")]
		private float _clickCd; // 0x1CC
		[SerializeField]
		[Tooltip("\u4E0D\u53EF\u70B9\u51FB\u65F6\u5F39\u51FA\u7684Toast\u6587\u672CKey")]
		private LangKey _invalidClickLangKey; // 0x1D0
		private float m_lastValidClickTime; // 0x1E0
		private float m_lastClickTime; // 0x1E4
		[SerializeField]
		private bool _useClickAnimation; // 0x1E8
		[SerializeField]
		private AnimationCurve _clickAnimationCurve; // 0x1F0
		[SerializeField]
		private float _clickAnimationDuration; // 0x1F8
		private Vector3 m_oriScale; // 0x1FC
		private Coroutine m_clickCor; // 0x208
		private bool m_scaled; // 0x210
		public UIEvent<PointerEventData> onLongPress; // 0x218
		public UIEvent<PointerEventData> onPressStart; // 0x220
		public UIEvent<PointerEventData> onPressEnd; // 0x228
		[SerializeField]
		private float _longPressTime; // 0x230
		[SerializeField]
		public bool _ignoreClickOnLongPress; // 0x234
		[FormerlySerializedAs("_longPressImg")]
		public UIImage longPressImg; // 0x238
		[SerializeField]
		private float _longPressImgShowDelay; // 0x240
		[SerializeField]
		private float _longPressMaxDragDist; // 0x244
		[SerializeField]
		private bool _forceEnableButtonPressAudio; // 0x248
		private bool m_pressDownWaitClick; // 0x249
		[CompilerGenerated]
		private Vector2 _startPressPos_k__BackingField; // 0x24C
		[CompilerGenerated]
		private int _pressTouchId_k__BackingField; // 0x254
		private Coroutine m_longPressCor; // 0x258
		private bool m_triggeredLongPress; // 0x260
		public bool noTextBtn; // 0x261
		private UIText m_autoFindLabel; // 0x268
		[SerializeField]
		private UIText _label; // 0x270
		private int m_groupId; // 0x278
		private bool m_bindingInit; // 0x27C
		[CompilerGenerated]
		private InputBindingGroupMonoTarget _parent_k__BackingField; // 0x280
		private string m_customBindingViewLabelText; // 0x288
		public string hintTextId; // 0x290
		[CompilerGenerated]
		private readonly DisposedUnityEvent _bindingViewUpdateEvent_k__BackingField; // 0x298
		[SerializeField]
		private RectTransform _redDotTrans; // 0x2A0
		[AudioString]
		[SerializeField]
		private string _audioGamePadLongPress; // 0x2A8
		private LuaPanel m_panel; // 0x2B0
		private int m_hoverBindingGroupId; // 0x2B8
		[NonSerialized]
		public string clickHintTextId; // 0x2C0
		[NonSerialized]
		public string longPressHintTextId; // 0x2C8
		[FormerlySerializedAs("actionOnSetNaviTarget")]
		[SerializeField]
		private ActionOnSetNaviTarget _actionOnSetNaviTarget; // 0x2D0
		[FormerlySerializedAs("useNoHintAction")]
		[SerializeField]
		private bool _useNoHintAction; // 0x2D4
		[CompilerGenerated]
		private int _hoverConfirmBindingId_k__BackingField; // 0x2D8
	
		// Properties
		public Vector2 startPressPos { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DAAE30-0x0000000184DAAE50 0x0000000184DAAE70-0x0000000184DAAE80
		public int pressTouchId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DAAE20-0x0000000184DAAE30 0x0000000184DAAE60-0x0000000184DAAE70
		public float longPressTime { get; } // 0x000000018B0C5C60-0x000000018B0C5CB4 
		public Vector2 curPressPos { get; } // 0x000000018B0C5BCC-0x000000018B0C5C60 
		public bool triggeredLongPress { get; } // 0x000000018B0C5E2C-0x000000018B0C5E7C 
		public string text { get; set; } // 0x000000018B0C5D54-0x000000018B0C5E2C 0x00000001848587A0-0x00000001848588D0
		public UIText label { get; } // 0x00000001848588D0-0x00000001848589E0 
		public bool groupEnabled { get; } // 0x0000000184175BD0-0x0000000184175C30 
		public int groupId { get; } // 0x0000000182FA7AB0-0x0000000182FA7B20 
		public IBindingGroupTarget parentTarget { get; } // 0x000000018B0C5CB4-0x000000018B0C5D04 
		public InputBindingGroupMonoTarget parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8DD90-0x0000000184D8DDA0 0x0000000186B8B7B0-0x0000000186B8B7C4
		public string bindingViewActionId { get; } // 0x0000000184300180-0x0000000184300230 
		public string customBindingViewLabelText { get; set; } // 0x00000001848146C0-0x00000001848146F0 0x0000000184750CE0-0x0000000184750D80
		public string bindingViewLabelText { get; } // 0x00000001848145D0-0x0000000184814610 
		public string hintText { get; } // 0x0000000184814610-0x00000001848146C0 
		public DisposedUnityEvent bindingViewUpdateEvent { [CompilerGenerated] get; } // 0x0000000184D8DA30-0x0000000184D8DA40 
		public RectTransform redDotTrans { get; } // 0x000000018B0C5D04-0x000000018B0C5D54 
		public bool bindingEnabled { get; } // 0x000000018B0C5B7C-0x000000018B0C5BCC 
		public BindingViewState bindingViewState { get; } // 0x0000000182FAA1C0-0x0000000182FAA770 
		public LuaPanel panel { get; } // 0x0000000183799EC0-0x0000000183799F50 
		public int hoverBindingGroupId { get; } // 0x0000000183793AC0-0x0000000183793B30 
		public ActionOnSetNaviTarget actionOnSetNaviTarget { get; } // 0x000000018B0C5B2C-0x000000018B0C5B7C 
		public int hoverConfirmBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184CE6410-0x0000000184CE6420 0x0000000184DAAE50-0x0000000184DAAE60
		bool IBindingView.interactable { get; } // 0x000000018B0C5554-0x000000018B0C55A4 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __DoClickAnimation_d__30 : IEnumerator<object> // TypeDefIndex: 50331
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIButton __4__this; // 0x20
			private float _currentTime_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __DoClickAnimation_d__30(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B0C16E8-0x000000018B0C1828
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B0C1828-0x000000018B0C1874
		}
	
		[CompilerGenerated]
		private sealed class __OnPress_d__59 : IEnumerator<object> // TypeDefIndex: 50332
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __OnPress_d__59(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x00000001842EE3D0-0x00000001842EE640
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B0C1874-0x000000018B0C18C0
		}
	
		// Constructors
		public UIButton(); // 0x0000000183697780-0x0000000183697990
	
		// Methods
		protected override void Awake(); // 0x00000001837D4910-0x00000001837D4960
		protected override void OnEnable(); // 0x0000000183794DE0-0x0000000183794E90
		protected override void OnDisable(); // 0x00000001837963D0-0x0000000183796440
		protected override void OnDestroy(); // 0x000000018351DA80-0x000000018351DB80
		protected override void _NotifyIsHover(bool isHover); // 0x00000001831EAC10-0x00000001831EAD80
		public virtual void OnPointerClick(PointerEventData eventData); // 0x000000018379A830-0x000000018379AC50
		private void _Press(PointerEventData eventData = null); // 0x0000000183798DF0-0x0000000183799EC0
		private void _PlayClickAnimation(bool reverse = false /* Metadata: 0x0232FC18 */); // 0x0000000183798130-0x0000000183798170
		[IteratorStateMachine(typeof(__DoClickAnimation_d__30))]
		private IEnumerator _DoClickAnimation(); // 0x000000018B0C5878-0x000000018B0C5908
		public override void OnPointerDown(PointerEventData eventData); // 0x0000000183797EA0-0x00000001837980C0
		public override void OnPointerUp(PointerEventData eventData); // 0x0000000183798180-0x0000000183798250
		[IteratorStateMachine(typeof(__OnPress_d__59))]
		private IEnumerator _OnPress(PointerEventData eventData); // 0x00000001837980C0-0x0000000183798130
		private void _StopLongPressCor(); // 0x0000000183796440-0x0000000183796500
		public void ClearComponent(); // 0x000000018351CC90-0x000000018351D140
		public void InitBinding(); // 0x0000000182FA7B20-0x0000000182FA8060
		public override void OnInteractableChanged(); // 0x0000000184A1DCC0-0x0000000184A1DD00
		private void _UpdateState(); // 0x0000000183793450-0x0000000183793730
		private bool _IsAnyButtonEventActionInGuideUse(); // 0x00000001833FD550-0x00000001833FDBF0
		public string GetBindingViewActionId(BindingViewActionType actionType); // 0x0000000184300130-0x0000000184300180
		void IBindingView.OnInputKeyDown(bool isActionTrigger); // 0x0000000184B09D00-0x0000000184B09E50
		void IBindingView.OnInputKeyUp(bool isActionTrigger); // 0x0000000184B42580-0x0000000184B426B0
		private void _OnUpdateKey(); // 0x00000001843DF550-0x00000001843DF590
		private string _GetUIButtonKeyHintActionId(UIEvent<PointerEventData> buttonEvent); // 0x00000001833FDBF0-0x00000001833FDC80
		protected override void _RefreshHoverEnableNode(bool active); // 0x0000000183793730-0x0000000183793A20
		public override bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId); // 0x000000018B0C5644-0x000000018B0C56D4
		public override void OnNaviTargetEnabledAgain(); // 0x000000018B0C56D4-0x000000018B0C5764
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode); // 0x000000018B0C5908-0x000000018B0C5A94
		private void _InitActionOnSetNaviTarget(); // 0x00000001837D1500-0x00000001837D1600
		private void _ToggleNaviInputBinding(bool active); // 0x000000018B0C5A94-0x000000018B0C5B2C
		public void ChangeActionOnSetNaviTarget(ActionOnSetNaviTarget action); // 0x000000018B0C55A4-0x000000018B0C5644
		[CompilerGenerated]
		private void _InitBinding_b__82_0(); // 0x0000000184D84D90-0x0000000184D84DA0
		[CompilerGenerated]
		private void _InitBinding_b__82_1(); // 0x000000018B0C5764-0x000000018B0C57B0
		[CompilerGenerated]
		private void _InitBinding_b__82_2(); // 0x000000018B0C57B0-0x000000018B0C57FC
		[CompilerGenerated]
		private void _InitBinding_b__82_3(); // 0x0000000183798170-0x0000000183798180
		[CompilerGenerated]
		private void _InitBinding_b__82_4(); // 0x00000001837986A0-0x00000001837986B0
		[CompilerGenerated]
		private void __InitActionOnSetNaviTarget_b__133_0(); // 0x000000018B0C582C-0x000000018B0C5878
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0); // 0x000000018B0C580C-0x000000018B0C5814
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0); // 0x000000018B0C5814-0x000000018B0C581C
		public void __iFixBaseProxy_Awake(); // 0x000000018B0869D4-0x000000018B0869DC
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0869E4-0x000000018B0869EC
		public void __iFixBaseProxy_OnDisable(); // 0x000000018447EC90-0x000000018447ECA0
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0869DC-0x000000018B0869E4
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018B0C581C-0x000000018B0C5824
		public void __iFixBaseProxy_OnInteractableChanged(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy__RefreshHoverEnableNode(bool P0); // 0x000000018B0C5824-0x000000018B0C582C
		public bool __iFixBaseProxy_GetMouseActionHints(out string P0, out string P1); // 0x000000018B0C57FC-0x000000018B0C5804
		public void __iFixBaseProxy_OnNaviTargetEnabledAgain(); // 0x000000018B0C5804-0x000000018B0C580C
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1); // 0x00000001841E1670-0x00000001841E1680
	}

	public enum CanvasMatchMode // TypeDefIndex: 50334
	{
		Width = 0,
		Height = 1
	}

	public class UICanvasScaleHelper : MonoBehaviour, DeviceInfoManager.IScreenSizeListener, IUIClearable // TypeDefIndex: 50337
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
		public float standardHorizontalResolution { get; } // 0x0000000183C00430-0x0000000183C00470 
		public float standardVerticalResolution { get; } // 0x0000000183C003F0-0x0000000183C00430 
		public float standardResolutionScale { get; } // 0x0000000183C00470-0x0000000183C004D0 
		public HashSet<CanvasScaler> canvasScalerList { get; } // 0x000000018B0C608C-0x000000018B0C60DC 
	
		// Nested types
		public struct FWorldCanvasParams // TypeDefIndex: 50335
		{
			// Fields
			public float screenRatio; // 0x00
			public Vector2 screenSize; // 0x04
			public Vector2 uiRootSize; // 0x0C
			public Vector3 uiRootScale; // 0x14
		}
	
		public struct FScreenCanvasParams // TypeDefIndex: 50336
		{
			// Fields
			public float screenRatio; // 0x00
			public Vector2 screenSize; // 0x04
			public CanvasMatchMode matchMode; // 0x0C
			public float matchWidthOrHeight; // 0x10
		}
	
		// Constructors
		public UICanvasScaleHelper(); // 0x00000001845D0960-0x00000001845D0AD0
	
		// Methods
		private void Awake(); // 0x00000001847B2810-0x00000001847B2850
		private void _OnInit(); // 0x00000001847B2850-0x00000001847B2950
		private void Start(); // 0x0000000183C03270-0x0000000183C033F0
		private void OnDestroy(); // 0x0000000183C037A0-0x0000000183C03910
		public void UpdateCanvas(); // 0x0000000183C017D0-0x0000000183C03270
		public void OnScreenSizeChanged(int width, int height); // 0x0000000183C03500-0x0000000183C03560
		public void AddCanvas(Canvas c, CanvasScaler s); // 0x0000000183C006A0-0x0000000183C00770
		public void RemoveCanvas(Canvas c, CanvasScaler s); // 0x000000018479C450-0x000000018479C4D0
		private void _OnInputTypeChanged(); // 0x000000018B0C5ED8-0x000000018B0C608C
		private void _CanvasOnWillRenderCanvases(); // 0x0000000183DB8A80-0x0000000183DB8B00
		public static FWorldCanvasParams CalcWorldCanvasParams(Camera camera, Transform uiRoot, bool useLocalPos = false /* Metadata: 0x0232FC23 */); // 0x0000000183C009A0-0x0000000183C00BB0
		public static FScreenCanvasParams CalcScreenCanvasParams(); // 0x0000000183C00770-0x0000000183C00810
		public static float CalcCurrentScreenRatio(out Vector2 screenSize); // 0x0000000183C00810-0x0000000183C00870
		public Vector2 GetProperCanvasResolution(); // 0x0000000183C00380-0x0000000183C003F0
		public void ForceCanvasUpdate(); // 0x000000018B0C5E7C-0x000000018B0C5ED8
		public void ClearComponent(); // 0x0000000183C03910-0x0000000183C03960
	}

	public class UIColorGroup : NonDrawingGraphic // TypeDefIndex: 50341
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
		public override UnityEngine.Color color { get; set; } // 0x000000018B0C6B5C-0x000000018B0C6BC4 0x000000018B0C6BC4-0x000000018B0C6CCC
	
		// Nested types
		private struct CommonParams // TypeDefIndex: 50338
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
	
		private delegate void GraphicOpt(Graphic graphic, CommonParams param); // TypeDefIndex: 50339; 0x0000000186229908-0x0000000186229938
	
		private struct DynEle // TypeDefIndex: 50340
		{
			// Fields
			public string groupId; // 0x00
			public Graphic graphic; // 0x08
			public bool useStaticColor; // 0x10
		}
	
		// Constructors
		public UIColorGroup(); // 0x00000001839C4AD0-0x00000001839C4AF0
	
		// Methods
		public void AttachGraphic(Graphic graphic, bool useStaticColor = true /* Metadata: 0x0232FC24 */); // 0x000000018B0C60DC-0x000000018B0C633C
		public void AttachGraphicsWithGroup(List<Graphic> graphic, string groupId); // 0x000000018B0C633C-0x000000018B0C6658
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x000000018B0C6658-0x000000018B0C6774
		[IDTag(0)]
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB); // 0x000000018B0C6774-0x000000018B0C68B4
		[IDTag(1)]
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x0000000184640320-0x0000000184640420
		private void _ApplyOptToGraphics(GraphicOpt opt, CommonParams param); // 0x00000001846404B0-0x0000000184640740
		private static void _CrossFadeAlpha(Graphic graphic, CommonParams param); // 0x000000018B0C6950-0x000000018B0C69E4
		private static void _CrossFadeColorRGB(Graphic graphic, CommonParams param); // 0x000000018B0C69E4-0x000000018B0C6AC0
		private static void _CrossFadeColorAlpha(Graphic graphic, CommonParams param); // 0x0000000184891630-0x00000001848916C0
		private static void _SetColor(Graphic graphic, CommonParams param); // 0x000000018B0C6AC0-0x000000018B0C6B5C
		public UnityEngine.Color __iFixBaseProxy_get_color(); // 0x0000000184D8C200-0x0000000184D8C210
		public void __iFixBaseProxy_set_color(UnityEngine.Color P0); // 0x000000018B0C6930-0x000000018B0C6950
		public void __iFixBaseProxy_CrossFadeAlpha(float P0, float P1, bool P2); // 0x000000018B0C68B4-0x000000018B0C68C4
		public void __iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, float P1, bool P2, bool P3, bool P4); // 0x000000018B0C68F4-0x000000018B0C6930
		public void __iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, float P1, bool P2, bool P3); // 0x000000018B0C68C4-0x000000018B0C68F4
	}

	public class UIControllerKeyIcon : MonoBehaviour // TypeDefIndex: 50342
	{
		// Fields
		[SerializeField]
		[Tooltip("\u65E0\u9700\u586B\u5199\u56FE\u7247\u5B8C\u6574\u540D\u79F0\uFF0C\u53EA\u9700\u586B\u5199\u5DEE\u5206\u90E8\u5206\uFF0C\u4F8B\u5982icon_playstation_arrowdown\uFF0C\u5219\u53EA\u9700\u586B\u5199arrowdown")]
		private string _keyIconName; // 0x18
		private UIImage m_image; // 0x20
		private static List<UIControllerKeyIcon> s_iconCache; // 0x00
		private static bool s_initialized; // 0x08
	
		// Constructors
		public UIControllerKeyIcon(); // 0x0000000183695570-0x0000000183695590
		static UIControllerKeyIcon(); // 0x0000000184CECCD0-0x0000000184CECD70
	
		// Methods
		private static void _TryStaticInit(); // 0x000000018B0C72DC-0x000000018B0C7464
		private static void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType); // 0x000000018B0C7140-0x000000018B0C72DC
		private void Awake(); // 0x000000018B0C6DCC-0x000000018B0C6E78
		private void OnEnable(); // 0x000000018B0C6F1C-0x000000018B0C6FC8
		private void OnDisable(); // 0x000000018B0C6E78-0x000000018B0C6F1C
		public void SetKeyIconName(GamepadKeyCode keyCode); // 0x000000018B0C70A4-0x000000018B0C7140
		public void RefreshKeyIcon(); // 0x000000018B0C6FC8-0x000000018B0C70A4
	}

	public class UICustomLayout : UIBehaviour // TypeDefIndex: 50343
	{
		// Fields
		[SerializeField]
		private RectTransform _dragArea; // 0x18
		public List<UICustomLayoutHandle> layoutHandles; // 0x20
		private JSONArray m_eventLog; // 0x28
	
		// Properties
		public RectTransform dragArea { get; } // 0x000000018B0CA7E8-0x000000018B0CA838 
	
		// Constructors
		public UICustomLayout(); // 0x000000018B0CA730-0x000000018B0CA7E8
	
		// Methods
		protected override void Awake(); // 0x000000018B0C9B10-0x000000018B0C9C58
		public bool IsDirty(); // 0x000000018B0C9C58-0x000000018B0C9DB4
		public void ResetToDefault(bool saveChanges); // 0x000000018B0C9DB4-0x000000018B0C9F40
		public void Save(int ratio = 0 /* Metadata: 0x0232FC25 */); // 0x000000018B0C9F40-0x000000018B0CA1F0
		private void _LogEvent(Dictionary<UICustomLayoutElement, UICustomLayoutElement.LayoutData> layoutDataMap); // 0x000000018B0CA1F0-0x000000018B0CA730
		public void __iFixBaseProxy_Awake(); // 0x00000001841E1670-0x00000001841E1680
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UICustomLayoutElement : UIBehaviour, IUIClearable // TypeDefIndex: 50346
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
		public string elementKey { get; } // 0x000000018B0C7FE0-0x000000018B0C8030 
		public RectTransform highlightRect { get; } // 0x000000018B0C8030-0x000000018B0C80C8 
		public float scale { get; set; } // 0x000000018B0C8170-0x000000018B0C81C0 0x000000018B0C82E4-0x000000018B0C8348
		public float alpha { get; set; } // 0x000000018B0C7F90-0x000000018B0C7FE0 0x000000018B0C81C0-0x000000018B0C8224
		public Vector2 position { get; set; } // 0x000000018B0C8114-0x000000018B0C8170 0x000000018B0C827C-0x000000018B0C82E4
		public LayoutType layoutType { get; set; } // 0x000000018B0C80C8-0x000000018B0C8114 0x000000018B0C8224-0x000000018B0C827C
		public LuaPanel panel { get; } // 0x0000000183BFCC30-0x0000000183BFCCE0 
	
		// Nested types
		public enum LayoutType // TypeDefIndex: 50344
		{
			None = 0,
			LeftToRight = 1
		}
	
		public class LayoutData // TypeDefIndex: 50345
		{
			// Fields
			public int verNum; // 0x10
			public float scale; // 0x14
			public float alpha; // 0x18
			public Vector2 position; // 0x1C
			public int layoutType; // 0x24
	
			// Constructors
			public LayoutData(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public UICustomLayoutElement(); // 0x00000001847A2460-0x00000001847A2510
	
		// Methods
		protected override void Awake(); // 0x0000000183BFBFF0-0x0000000183BFC110
		protected override void Start(); // 0x0000000184A21300-0x0000000184A21370
		protected override void OnDestroy(); // 0x000000018B0C77E8-0x000000018B0C78DC
		public void ResetToDefault(); // 0x000000018B0C7970-0x000000018B0C7A38
		private void _ApplyPosition(); // 0x000000018B0C7CFC-0x000000018B0C7D68
		private void _ApplyAlpha(); // 0x000000018B0C7C18-0x000000018B0C7CFC
		private void _ApplyScale(); // 0x000000018B0C7D68-0x000000018B0C7E3C
		private void _SetDefaultValues(); // 0x0000000183BFC110-0x0000000183BFC330
		public string GetElementKeyWithRatio(int ratio = 0 /* Metadata: 0x0232FC26 */); // 0x000000018B0C74BC-0x000000018B0C7598
		private bool _CheckElementKeyIsValid(); // 0x000000018B0C7E3C-0x000000018B0C7F40
		public bool SaveData(out LayoutData layoutData, bool isResetToDefault = false /* Metadata: 0x0232FC27 */, int ratio = 0 /* Metadata: 0x0232FC28 */); // 0x000000018B0C7A38-0x000000018B0C7C18
		public void LoadData(); // 0x000000018B0C7598-0x000000018B0C77E8
		private void _OnHudLayoutSaved(); // 0x000000018B0C7F40-0x000000018B0C7F90
		private Vector2 _GetMarginSize(); // 0x0000000183BFCB10-0x0000000183BFCC30
		public void ClearComponent(); // 0x000000018B0C7464-0x000000018B0C74BC
		public static void RefreshAll(); // 0x000000018B0C78DC-0x000000018B0C7970
		public void __iFixBaseProxy_Awake(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_Start(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UICustomLayoutHandle : UIBehaviour, IPointerClickHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 50347
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
		public float scale { get; set; } // 0x000000018B0C9858-0x000000018B0C98A8 0x000000018B0C9A84-0x000000018B0C9B10
		public float alpha { get; set; } // 0x000000018B0C96A8-0x000000018B0C96F8 0x000000018B0C98A8-0x000000018B0C991C
		public Vector2 position { get; set; } // 0x000000018B0C97FC-0x000000018B0C9858 0x000000018B0C99A4-0x000000018B0C9A84
		public UICustomLayoutElement.LayoutType layoutType { get; set; } // 0x000000018B0C96F8-0x000000018B0C9744 0x000000018B0C991C-0x000000018B0C99A4
		public LuaPanel panel { get; } // 0x000000018B0C9744-0x000000018B0C97FC 
		public UICustomLayoutElement Element { get; } // 0x000000018B0C95F4-0x000000018B0C96A8 
	
		// Constructors
		public UICustomLayoutHandle(); // 0x000000018B0C9464-0x000000018B0C95F4
	
		// Methods
		protected override void Awake(); // 0x000000018B0C8348-0x000000018B0C8554
		protected override void OnDestroy(); // 0x000000018B0C87AC-0x000000018B0C8910
		private void _OnElementDataLoaded(); // 0x000000018B0C9288-0x000000018B0C9364
		private void _CalculatePositionRange(); // 0x000000018B0C8EE4-0x000000018B0C9288
		private void _ApplyPosition(); // 0x000000018B0C8E00-0x000000018B0C8E74
		private void _ApplyAlpha(); // 0x000000018B0C8D2C-0x000000018B0C8D94
		private void _ApplyScale(); // 0x000000018B0C8E74-0x000000018B0C8EE4
		private void _ApplyLayoutType(); // 0x000000018B0C8D94-0x000000018B0C8E00
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018B0C8654-0x000000018B0C87AC
		public void OnDrag(PointerEventData eventData); // 0x000000018B0C8910-0x000000018B0C8A5C
		public void OnEndDrag(PointerEventData eventData); // 0x000000018B0C8A5C-0x000000018B0C8AE8
		public bool Save(out UICustomLayoutElement.LayoutData layoutData, int ratio = 0 /* Metadata: 0x0232FC2B */); // 0x000000018B0C8C5C-0x000000018B0C8D2C
		public void ResetToDefault(); // 0x000000018B0C8B50-0x000000018B0C8C5C
		public bool IsDirty(); // 0x000000018B0C8608-0x000000018B0C8654
		private void _SetChanged(bool changed); // 0x000000018B0C93B4-0x000000018B0C9464
		public void OnPointerClick(PointerEventData eventData); // 0x000000018B0C8AE8-0x000000018B0C8B50
		private void _OnSystemDisplaySizeChanged(); // 0x000000018B0C9364-0x000000018B0C93B4
		public void ClearComponent(); // 0x000000018B0C8554-0x000000018B0C8608
		public void __iFixBaseProxy_Awake(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class UIDialogText : TickableUIMono // TypeDefIndex: 50349
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
		protected override TickType tickOption { get; } // 0x0000000184A79660-0x0000000184A79690 
		private bool useAspectRatio { get; } // 0x000000018B0CB5DC-0x000000018B0CB638 
		private bool notUseAspectRatio { get; } // 0x000000018B0CB41C-0x000000018B0CB47C 
		public bool playing { get; } // 0x000000018B0CB47C-0x000000018B0CB4EC 
		public UIText uiText { get; } // 0x000000018B0CB58C-0x000000018B0CB5DC 
		public int totalCharacterNum { get; } // 0x000000018B0CB53C-0x000000018B0CB58C 
		public float textRevealSpeed { get; set; } // 0x000000018B0CB4EC-0x000000018B0CB53C 0x000000018B0CB638-0x000000018B0CB694
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 50348
		{
			Auto = 0,
			Manual = 1
		}
	
		// Constructors
		public UIDialogText(); // 0x0000000184A209B0-0x0000000184A20A70
	
		// Methods
		protected override void OnAwake(); // 0x0000000184D5A080-0x0000000184D5A0C0
		protected void Start(); // 0x0000000184488480-0x0000000184488540
		protected override void OnDisable(); // 0x000000018B0CB228-0x000000018B0CB280
		protected override void OnEnable(); // 0x0000000184D25A60-0x0000000184D25AA0
		public override void Tick(float deltaTime); // 0x0000000183E61060-0x0000000183E610C0
		protected virtual void OnVisibleCharactersChanged(int count); // 0x000000018B0CB280-0x000000018B0CB2D4
		protected float GetScrollSpeed(); // 0x000000018B0CAE00-0x000000018B0CAEE4
		protected float GetAutoWaitTime(); // 0x000000018B0CAC6C-0x000000018B0CAD50
		private void _UpdateTextAuto(); // 0x0000000183E610C0-0x0000000183E611B0
		private void _TryAutoScroll(); // 0x0000000183E611B0-0x0000000183E61200
		public void RefreshAutoScrollData(); // 0x0000000184488690-0x0000000184488730
		public void SetText(string text, bool resetPlay = true /* Metadata: 0x0232FC2C */); // 0x00000001844885B0-0x0000000184488690
		private void _RefreshPosY(); // 0x000000018B0CB370-0x000000018B0CB41C
		public void SeekToEnd(); // 0x000000018B0CB2D4-0x000000018B0CB370
		public void RefreshText(); // 0x0000000184D25AA0-0x0000000184D25AF0
		public void Play(); // 0x0000000184488540-0x00000001844885B0
		public virtual void ResetPlay(); // 0x0000000184B4A7A0-0x0000000184B4A810
		public void StopPlay(); // 0x0000000183E61200-0x0000000183E612B0
		public void ManualUpdateByPercent(float percent); // 0x000000018B0CAEE4-0x000000018B0CB034
		public void ManualUpdateByTime(float time); // 0x000000018B0CB034-0x000000018B0CB228
		public virtual float GetDisplayAllCharactersTime(); // 0x000000018B0CAD50-0x000000018B0CAE00
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class UIDialogTextWithCursor : UIDialogText // TypeDefIndex: 50350
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
		public UIDialogTextWithCursor(); // 0x000000018B0CAC50-0x000000018B0CAC6C
	
		// Methods
		public override void ResetPlay(); // 0x000000018B0CABE0-0x000000018B0CAC38
		protected override void OnVisibleCharactersChanged(int count); // 0x000000018B0CA894-0x000000018B0CABE0
		public override float GetDisplayAllCharactersTime(); // 0x000000018B0CA838-0x000000018B0CA894
		public void __iFixBaseProxy_ResetPlay(); // 0x000000018B0CAC48-0x000000018B0CAC50
		public void __iFixBaseProxy_OnVisibleCharactersChanged(int P0); // 0x000000018B0CAC40-0x000000018B0CAC48
		public float __iFixBaseProxy_GetDisplayAllCharactersTime(); // 0x000000018B0CAC38-0x000000018B0CAC40
	}

	public class EasyUIOptionData // TypeDefIndex: 50351
	{
		// Fields
		public int index; // 0x10
		public string optionIcon; // 0x18
		public string optionText; // 0x20
	
		// Constructors
		public EasyUIOptionData(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class UIDialogTimelineOptionCell : MonoBehaviour // TypeDefIndex: 50352
	{
		// Fields
		[SerializeField]
		private UIImage _optionIcon; // 0x18
		[SerializeField]
		private UIText _optionText; // 0x20
	
		// Constructors
		public UIDialogTimelineOptionCell(); // 0x0000000185393520-0x0000000185393538
	}

	public class UIDialogTimelineText : MonoBehaviour // TypeDefIndex: 50353
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
		private CanvasGroup canvasGroup { get; } // 0x000000018B0CBA34-0x000000018B0CBAC4 
		public UIDialogText dialogText { get; } // 0x000000018B0CBAC4-0x000000018B0CBB14 
		public UIText actorName { get; } // 0x000000018B0CB9E4-0x000000018B0CBA34 
		public GameObject waitNode { get; } // 0x000000018B0CBB14-0x000000018B0CBB64 
	
		// Constructors
		public UIDialogTimelineText(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void UpdateAlpha(float alpha); // 0x000000018B0CB818-0x000000018B0CB8D8
		public void SetRadioIcon(bool useRadio, string radioIcon); // 0x000000018B0CB694-0x000000018B0CB7D4
		private void _ClearRadioIcon(); // 0x000000018B0CB8D8-0x000000018B0CB9E4
		[CompilerGenerated]
		private void __ClearRadioIcon_b__19_0(); // 0x000000018B0CB7D4-0x000000018B0CB818
	}

	public class UIDrag : UIBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 50354
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
		public UIDrag(); // 0x000000018B0CDA10-0x000000018B0CDB20
	
		// Methods
		protected override void Awake(); // 0x000000018B0CD1B8-0x000000018B0CD2B0
		public void OnDrag(PointerEventData eventData); // 0x000000018B0CD780-0x000000018B0CD984
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018B0CD354-0x000000018B0CD780
		public void OnEndDrag(PointerEventData eventData); // 0x000000018B0CD984-0x000000018B0CDA10
		public void ApplyDragArea(); // 0x000000018B0CCD78-0x000000018B0CD1B8
		public void ClearComponent(); // 0x000000018B0CD2B0-0x000000018B0CD354
		public void __iFixBaseProxy_Awake(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class UIDragHandler : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 50355
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
		public int dragThreshold { get; } // 0x000000018B0CBF10-0x000000018B0CBF90 
	
		// Constructors
		public UIDragHandler(); // 0x00000001845F07D0-0x00000001845F08E0
	
		// Methods
		public void ClearComponent(); // 0x000000018B0CBB64-0x000000018B0CBC08
		public void OnPointerDown(PointerEventData eventData); // 0x000000018B0CBE9C-0x000000018B0CBF10
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018B0CBC08-0x000000018B0CBC9C
		public void OnDrag(PointerEventData eventData); // 0x000000018B0CBC9C-0x000000018B0CBE08
		public void OnEndDrag(PointerEventData eventData); // 0x000000018B0CBE08-0x000000018B0CBE9C
	}

	public class UIDragItem : UIBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 50357
	{
		// Fields
		public static RectTransform s_commonDragObjectParent; // 0x00
		[CompilerGenerated]
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
		public LuaTable luaTable { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
		public bool inDragging { get; } // 0x000000018B0CCBB4-0x000000018B0CCC04 
		public LuaPanel panel { get; } // 0x000000018B0CCCB4-0x000000018B0CCD78 
		public RectTransform dragObjectParent { get; set; } // 0x0000000182E968A0-0x0000000182E96C00 0x0000000182E96C00-0x0000000182E97340
		private RectTransform m_dragParentRect { get; } // 0x000000018B0CCC04-0x000000018B0CCCB4 
		public GameObject curDragObj { get; } // 0x000000018B0CCB64-0x000000018B0CCBB4 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __ContinueDragOnDisable_d__43 : IEnumerator<object> // TypeDefIndex: 50356
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIDragItem __4__this; // 0x20
			private PointerEventData _eData_5__2; // 0x28
			private PooledList<RaycastResult> _raycastResults_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __ContinueDragOnDisable_d__43(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x0000000182E94D20-0x0000000182E96850
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000182E96850-0x0000000182E968A0
		}
	
		// Constructors
		public UIDragItem(); // 0x00000001839C2D00-0x00000001839C2EA0
	
		// Methods
		protected override void Awake(); // 0x0000000184950ED0-0x0000000184950F40
		protected override void Start(); // 0x0000000184845B50-0x0000000184845C60
		protected override void OnDisable(); // 0x0000000184D1A6F0-0x0000000184D1A730
		[IteratorStateMachine(typeof(__ContinueDragOnDisable_d__43))]
		private IEnumerator _ContinueDragOnDisable(); // 0x000000018B0CC92C-0x000000018B0CC9BC
		protected override void OnDestroy(); // 0x000000018B0CC574-0x000000018B0CC5D4
		protected override void OnEnable(); // 0x0000000184A79500-0x0000000184A79540
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018B0CC014-0x000000018B0CC574
		public void OnDrag(PointerEventData eventData); // 0x000000018B0CC5D4-0x000000018B0CC92C
		public void OnEndDrag(PointerEventData eventData); // 0x0000000184D1A730-0x0000000184D1A790
		private void _StopDragView(); // 0x000000018B0CC9BC-0x000000018B0CCB64
		public void ClearComponent(); // 0x000000018B0CBF90-0x000000018B0CC014
		public void ClearEvents(); // 0x00000001836D0E40-0x00000001836D0ED0
		public void __iFixBaseProxy_Awake(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_Start(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnDisable(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnEnable(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AddComponentMenu("UI/UI Dropdown", 102)]
	public class UIDropdown : Selectable, IPointerClickHandler, IUIClearable, IBindingGroupTarget, IBindingView // TypeDefIndex: 50360
	{
		// Fields
		[HideInInspector]
		public UnityEvent<int> onSelectCell; // 0x188
		[HideInInspector]
		public UnityEvent<int, UIDropdownOption, bool> onUpdateCell; // 0x190
		[HideInInspector]
		public UnityEvent<int, UIDropdown> onUpdateCaption; // 0x198
		[FormerlySerializedAs("onToggleList")]
		[HideInInspector]
		public UnityEvent<bool> onToggleOptList; // 0x1A0
		public Func<int, int, bool> onValidateSelectCell; // 0x1A8
		public UIText captionText; // 0x1B0
		public UIImage captionIcon; // 0x1B8
		[CompilerGenerated]
		private int _selectedIndex_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private int _optionCount_k__BackingField; // 0x1C4
		[CompilerGenerated]
		private bool _isListActive_k__BackingField; // 0x1C8
		[SerializeField]
		private UIDropdownOption _optionTemplate; // 0x1D0
		[SerializeField]
		private Transform _arrowImageTrans; // 0x1D8
		[SerializeField]
		private RectTransform _listContainer; // 0x1E0
		[SerializeField]
		private float _listContainerMaxHeight; // 0x1E8
		[SerializeField]
		private float _animationTime; // 0x1EC
		[SerializeField]
		private RectTransform _selfArea; // 0x1F0
		[SerializeField]
		[Tooltip("\u8FD9\u91CC\u4E3A\u7A7A\u7684\u8BDD\uFF0C\u70B9\u5F00Dropdown\u65F6\u70B9\u51FB\u4EFB\u610F\u975EDropdown\u533A\u57DF\u4F1A\u6536\u8D77\uFF0C\u6709\u7684\u8BDD\u53EA\u4F1A\u54CD\u5E94mask\u533A\u57DF\u5185\u7684")]
		private RectTransform _maskRect; // 0x1F8
		[SerializeField]
		private bool _autoCloseOnSelect; // 0x200
		[AudioString]
		[SerializeField]
		private string _audioToggleOn; // 0x208
		[AudioString]
		[SerializeField]
		private string _audioToggleOff; // 0x210
		[AudioString]
		[SerializeField]
		private string _audioInvalid; // 0x218
		[AudioString]
		[SerializeField]
		private string _audioNavigation; // 0x220
		private List<UIDropdownOption> m_options; // 0x228
		private LuaPanel m_panel; // 0x230
		private LayoutGroup m_content; // 0x238
		private Camera m_fallbackUICamera; // 0x240
		private UIScrollRect m_listScrollRect; // 0x248
		private CanvasGroup m_listContainerCanvasGroup; // 0x250
		[FormerlySerializedAs("_openDropDownActionId")]
		public string openDropDownActionId; // 0x258
		public string openDropDownBindingTextId; // 0x260
		private int m_bindingGroupId; // 0x268
		private int m_naviBindingGroupId; // 0x26C
		private LuaPanel m_luaPanel; // 0x270
		private UISelectableNaviGroup m_listNaviGroup; // 0x278
		[CompilerGenerated]
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0x280
		[CompilerGenerated]
		private readonly DisposedUnityEvent _bindingViewUpdateEvent_k__BackingField; // 0x288
	
		// Properties
		public int selectedIndex { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E9A0-0x0000000184D8E9B0 0x0000000184D8EA50-0x0000000184D8EA60
		public int optionCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E9B0-0x0000000184D8E9C0 0x0000000184D8EA60-0x0000000184D8EA70
		public bool isListActive { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DA3320-0x0000000184DA3330 0x0000000184DAAE80-0x0000000184DAAE90
		public LuaPanel panel { get; } // 0x0000000183F03420-0x0000000183F034D0 
		public int groupId { get; } // 0x000000018B0CE604-0x000000018B0CE654 
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8DD90-0x0000000184D8DDA0 0x0000000186B8B7B0-0x0000000186B8B7C4
		public bool groupEnabled { get; } // 0x000000018B0CE57C-0x000000018B0CE604 
		public string bindingViewActionId { get; } // 0x000000018B0CE334-0x000000018B0CE384 
		public string bindingViewLabelText { get; } // 0x000000018B0CE384-0x000000018B0CE41C 
		public DisposedUnityEvent bindingViewUpdateEvent { [CompilerGenerated] get; } // 0x0000000184D8D820-0x0000000184D8D830 
		public RectTransform redDotTrans { get; } // 0x000000018B0CE654-0x000000018B0CE6A0 
		public bool bindingEnabled { get; } // 0x000000018B0CE2E4-0x000000018B0CE334 
		public BindingViewState bindingViewState { get; } // 0x000000018B0CE41C-0x000000018B0CE57C 
		bool IBindingView.interactable { get; } // 0x000000018B0CDED8-0x000000018B0CDF28 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 50358
		{
			// Fields
			public UIDropdown __4__this; // 0x10
			public bool activeList; // 0x18
	
			// Constructors
			public __c__DisplayClass44_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __ToggleOptions_b__0(); // 0x000000018B0C6D88-0x000000018B0C6DCC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0 // TypeDefIndex: 50359
		{
			// Fields
			public int index; // 0x10
			public UIDropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass48_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Refresh_b__0(PointerEventData evt); // 0x0000000183F01B90-0x0000000183F01BD0
		}
	
		// Constructors
		public UIDropdown(); // 0x00000001847599C0-0x0000000184759B10
	
		// Methods
		protected override void Awake(); // 0x0000000183EAD500-0x0000000183EAD680
		protected override void _NotifyIsHover(bool isHover); // 0x00000001847F9CD0-0x00000001847F9D50
		public void OnPointerClick(PointerEventData eventData); // 0x0000000183F02AA0-0x0000000183F02B50
		public void Init(UnityAction<int, UIDropdownOption, bool> onUpdateCell, UnityAction<int> onSelectCell, UnityAction<int, UIDropdown> onUpdateCaption = null); // 0x0000000184CCE880-0x0000000184CCE950
		public void ToggleOptions(bool activeList); // 0x0000000183F03740-0x0000000183F03790
		private void _ToggleOptions(bool activeList, bool isInit); // 0x0000000183F03790-0x0000000183F03CB0
		private void Update(); // 0x0000000183F03060-0x0000000183F03230
		public void SetSelected(int index, bool forceUpdate = false /* Metadata: 0x0232FC2F */, bool needNotifySelect = true /* Metadata: 0x0232FC30 */, bool validateSelect = false /* Metadata: 0x0232FC31 */); // 0x0000000183F034D0-0x0000000183F03740
		public void ScrollToSelected(); // 0x000000018B0CDFE8-0x000000018B0CE124
		public void Refresh(int count, int newSelectedIndex = -1 /* Metadata: 0x0232FC32 */, bool needNotifySelect = true /* Metadata: 0x0232FC33 */); // 0x000000018356CED0-0x000000018356D320
		public void ClearComponent(); // 0x0000000184A37E10-0x0000000184A38290
		private Camera _GetUICamera(); // 0x0000000183F03230-0x0000000183F03420
		public string GetBindingViewActionId(BindingViewActionType actionType); // 0x000000018B0CDF28-0x000000018B0CDFE8
		void IBindingView.OnInputKeyDown(bool isActionTrigger); // 0x000000018B0CDE30-0x000000018B0CDE84
		void IBindingView.OnInputKeyUp(bool isActionTrigger); // 0x000000018B0CDE84-0x000000018B0CDED8
		private void _InitBinding(); // 0x0000000183EAD680-0x0000000183EAD820
		private void _ControllerToggle(); // 0x000000018B0CE190-0x000000018B0CE208
		private void _ControllerCancel(); // 0x000000018B0CE124-0x000000018B0CE190
		private Selectable _GetDefaultNaviTarget(); // 0x000000018B0CE208-0x000000018B0CE2E4
		protected override void OnEnable(); // 0x0000000184B450E0-0x0000000184B45170
		protected override void OnDisable(); // 0x0000000184B45170-0x0000000184B45200
		protected override void OnDestroy(); // 0x0000000184A37D70-0x0000000184A37E10
		public void __iFixBaseProxy_Awake(); // 0x000000018B0869D4-0x000000018B0869DC
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018B0C581C-0x000000018B0C5824
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0869E4-0x000000018B0869EC
		public void __iFixBaseProxy_OnDisable(); // 0x000000018447EC90-0x000000018447ECA0
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0869DC-0x000000018B0869E4
	}

	public class UIDropdownOption : MonoBehaviour // TypeDefIndex: 50361
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
		public UIDropdownOption(); // 0x0000000183698DF0-0x0000000183698E20
	
		// Methods
		public void SetText(string text); // 0x0000000183F4AC10-0x0000000183F4AD40
		public void SetState(string stateName); // 0x000000018B0CDD7C-0x000000018B0CDE30
	}

	public enum CommonDropHintType // TypeDefIndex: 50362
	{
		None = 0,
		Square = 1,
		Circle = 2
	}

	public class UIDropItem : UIBehaviour, IDropHandler, IUIClearable // TypeDefIndex: 50363
	{
		// Fields
		[CompilerGenerated]
		private LuaTable _luaTable_k__BackingField; // 0x18
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
		public LuaTable luaTable { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public UIDropItem(); // 0x00000001839C2BB0-0x00000001839C2D00
	
		// Methods
		public void ClearEvents(); // 0x00000001836D0DF0-0x00000001836D0E40
		protected override void Awake(); // 0x00000001847750F0-0x00000001847751B0
		protected override void OnEnable(); // 0x000000018456EF00-0x000000018456EF60
		protected override void OnDisable(); // 0x000000018456EEC0-0x000000018456EF00
		protected override void OnDestroy(); // 0x000000018B0CDBB8-0x000000018B0CDC58
		public void ToggleHighlight(bool active, bool forceToggle = false /* Metadata: 0x0232FC37 */); // 0x000000018456EF60-0x000000018456F0D0
		public void OnDrop(PointerEventData eventData); // 0x000000018B0CDC58-0x000000018B0CDD7C
		public void ClearComponent(); // 0x000000018B0CDB20-0x000000018B0CDBB8
		public void __iFixBaseProxy_Awake(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnDisable(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class UIElementFollower : TickableUIMono // TypeDefIndex: 50364
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
		[CompilerGenerated]
		private bool _inScreen_k__BackingField; // 0xB8
		private LuaPanel m_panel; // 0xC0
		private RectTransform m_rectTransform; // 0xC8
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018460F810-0x000000018460F840 
		public Vector3 followPosition { get; set; } // 0x000000018B0CEA54-0x000000018B0CEAC8 0x000000018B0CEB18-0x000000018B0CEB9C
		public Transform targetTransform { get; set; } // 0x000000018B0CEAC8-0x000000018B0CEB18 0x000000018B0CEB9C-0x000000018B0CEC08
		public bool inScreen { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D892C0-0x0000000184D892D0 0x0000000184D89320-0x0000000184D89330
		public LuaPanel panel { get; } // 0x0000000183E4DC20-0x0000000183E4DCE0 
	
		// Constructors
		public UIElementFollower(); // 0x0000000184735620-0x0000000184735700
		static UIElementFollower(); // 0x0000000184D38BA0-0x0000000184D38C00
	
		// Methods
		protected override void OnAwake(); // 0x0000000184CC4BB0-0x0000000184CC4C20
		protected override void OnEnable(); // 0x0000000183E4D9C0-0x0000000183E4DA10
		public override void LateTick(float deltaTime); // 0x0000000183E4DA10-0x0000000183E4DA50
		[IDTag(1)]
		public void UpdatePosition(); // 0x0000000183E4DA50-0x0000000183E4DC20
		[IDTag(0)]
		public void UpdatePosition(Vector3 worldPos); // 0x000000018B0CE6A0-0x000000018B0CEA54
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class UIExtendScrollRect : MonoBehaviour, UnityEngine.EventSystems.IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 50365
	{
		// Fields
		public UIScrollRect baseScrollRect; // 0x18
		[SerializeField]
		private bool _enableDrag; // 0x20
		[SerializeField]
		private UIScrollList _extendScrollList; // 0x28
	
		// Constructors
		public UIExtendScrollRect(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		public void OnScroll(PointerEventData eventData); // 0x000000018B0CEECC-0x000000018B0CEF78
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018B0CEC08-0x000000018B0CECF4
		public void OnDrag(PointerEventData eventData); // 0x000000018B0CECF4-0x000000018B0CEDE0
		public void OnEndDrag(PointerEventData eventData); // 0x000000018B0CEDE0-0x000000018B0CEECC
	}

	public interface IUIFoldoutComp // TypeDefIndex: 50366
	{
		// Properties
		bool defaultFoldOut { get; } // 0x0000000182FFF600-0x0000000182FFF610 
	
		// Methods
		void Refresh(int index);
		void OnFoldOut(bool fastMode = false /* Metadata: 0x0232FC38 */);
		void OnFoldIn(bool fastMode = false /* Metadata: 0x0232FC39 */);
	}

	public class UIFoldoutComponent : MonoBehaviour, IUIFoldoutComp // TypeDefIndex: 50369
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
		public virtual bool defaultFoldOut { get; } // 0x000000018B0CF5C8-0x000000018B0CF614 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 50367
		{
			// Fields
			public float startSize; // 0x10
			public UIFoldoutComponent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _OnFoldOut_b__0(); // 0x0000000184D85F70-0x0000000184D85F80
			internal void _OnFoldOut_b__1(float value); // 0x000000018B0C6D54-0x000000018B0C6D88
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 50368
		{
			// Fields
			public float startSize; // 0x10
			public UIFoldoutComponent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal float _OnFoldIn_b__0(); // 0x0000000184D85F70-0x0000000184D85F80
			internal void _OnFoldIn_b__1(float value); // 0x000000018B0C6D54-0x000000018B0C6D88
		}
	
		// Constructors
		public UIFoldoutComponent(); // 0x0000000184D80BD0-0x0000000184D80C00
	
		// Methods
		public void Refresh(int index); // 0x000000018B0CF54C-0x000000018B0CF5C8
		public virtual void OnFoldOut(bool fastMode = false /* Metadata: 0x0232FC3A */); // 0x000000018B0CF294-0x000000018B0CF54C
		public virtual void OnFoldIn(bool fastMode = false /* Metadata: 0x0232FC3B */); // 0x000000018B0CEFE4-0x000000018B0CF294
		private void OnDestroy(); // 0x000000018B0CEF78-0x000000018B0CEFE4
	}

	[ExecuteAlways]
	public class UIGraphicAnimation : TickableUIMono // TypeDefIndex: 50370
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
		protected override TickType tickOption { get; } // 0x000000018416CC10-0x000000018416CC40 
		public Material MaterialInstance { get; } // 0x00000001849585B0-0x00000001849585E0 
	
		// Constructors
		public UIGraphicAnimation(); // 0x00000001839C44C0-0x00000001839C44E0
		static UIGraphicAnimation(); // 0x0000000184D22560-0x0000000184D225E0
	
		// Methods
		protected override void OnAwake(); // 0x00000001835763F0-0x0000000183576430
		protected override void OnRelease(); // 0x000000018B0CF614-0x000000018B0CF718
		public override void LateTick(float deltaTime); // 0x00000001833A0760-0x00000001833A0AE0
		private void _Init(); // 0x0000000183576430-0x00000001835765B0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	[ExecuteInEditMode]
	public class UIGridLayoutGroup : GridLayoutGroup // TypeDefIndex: 50371
	{
		// Constructors
		public UIGridLayoutGroup(); // 0x000000018B0CF718-0x000000018B0CF720
	}

	public class UIGridLayoutNaviWrapper : UIBehaviour, UIScrollList.IScrollListNaviWrapper // TypeDefIndex: 50373
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
		public enum WrapMode // TypeDefIndex: 50372
		{
			NaviGroup = 0,
			ScrollRect = 1,
			ScrollList = 2,
			LayoutNaviWrapper = 3
		}
	
		// Constructors
		public UIGridLayoutNaviWrapper(); // 0x00000001839C1EA0-0x00000001839C1F30
	
		// Methods
		private void _InitIfNot(); // 0x000000018B0CF948-0x000000018B0CFACC
		protected override void Start(); // 0x000000018B0CF720-0x000000018B0CF77C
		public bool TryWrapNavigate(NaviDirection dir); // 0x000000018B0CF77C-0x000000018B0CF7E0
		private void _InitWrapNavigation(); // 0x000000018B0CFACC-0x000000018B0CFC70
		private void _NaviGridLayout(NaviDirection dir); // 0x000000018B0D02B4-0x000000018B0D031C
		private bool _NaviGridLayoutImpl(NaviDirection dir, bool enableCircleWrapNavigation = false /* Metadata: 0x0232FC3C */); // 0x000000018B0CFEF8-0x000000018B0D0184
		private bool _NaviGridLayoutInit(bool isBefore, bool enableCircleWrapNavigation = false /* Metadata: 0x0232FC3D */); // 0x000000018B0D0184-0x000000018B0D02B4
		private bool _NaviChildren(int curIndex, int childCount, bool isBefore, bool enableCircleWrapNavigation); // 0x000000018B0CFC70-0x000000018B0CFEF8
		private Selectable _FindValidSelectable(bool isBefore); // 0x000000018B0CF7E0-0x000000018B0CF948
		private void _SetCircleWrapScroll(bool isBefore); // 0x000000018B0D031C-0x000000018B0D041C
		public void __iFixBaseProxy_Start(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class UIGroupScrollList : UIScrollList // TypeDefIndex: 50374
	{
		// Fields
		[FormerlySerializedAs("_groupTitlePrefab")]
		[SerializeField]
		[Tooltip("\u5206\u7EC4\u6807\u9898\u6A21\u677F\uFF0C\u53EF\u4EE5\u662FPrefab\u6216\u8005\u9762\u677F\u4E0A\u7684\u8282\u70B9")]
		protected GameObject _groupTitleTemplate; // 0x278
		[SerializeField]
		[Tooltip("\u5206\u7EC4\u80CC\u666F\u6A21\u677F\uFF0C\u53EF\u4E3A\u7A7A\u3002\u4E3A\u7A7A\u65F6\u4E0D\u542F\u7528 GroupBG \u903B\u8F91")]
		protected GameObject _groupBGCell; // 0x280
		[SerializeField]
		[Tooltip("\u76F8\u90BB\u4E24\u7EC4\u4E4B\u95F4\u989D\u5916\u589E\u52A0\u7684\u95F4\u8DDD\uFF08\u5728\u6EDA\u52A8\u65B9\u5411\u4E0A\uFF0C\u53E0\u52A0\u5728 Space \u4E4B\u4E0A\uFF09")]
		private float _groupSpace; // 0x288
		[NonSerialized]
		public Func<int, int> getCellCountInGroup; // 0x290
		[NonSerialized]
		public Func<int, float> getGroupTitleSize; // 0x298
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onUpdateGroupTitle; // 0x2A0
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onUpdateGroupBG; // 0x2A8
		private int m_groupCount; // 0x2B0
		private int[] m_cellCountPerGroup; // 0x2B8
		private int[] m_groupFirstRow; // 0x2C0
		private int m_totalRows; // 0x2C8
		private float m_defaultGroupTitleHeight; // 0x2CC
		private float m_defaultGroupTitleWidth; // 0x2D0
		private readonly List<float> m_groupTitleSizeList; // 0x2D8
		private Stack<Cell> m_titleCellCache; // 0x2E0
		private Dictionary<int, Cell> m_showingTitles; // 0x2E8
		private Stack<Cell> m_groupBGCellCache; // 0x2F0
		private Dictionary<int, Cell> m_showingGroupBGs; // 0x2F8
		private bool m_isMultiPage; // 0x300
		private const string CACHED_TITLE_GAME_OBJECT_NAME = "CachedTitle"; // Metadata: 0x0232FC5E
		private const string CACHED_GROUP_BG_GAME_OBJECT_NAME = "CachedGroupBG"; // Metadata: 0x0232FC6A
	
		// Properties
		public int totalCellCount { get; } // 0x000000018B0D86F0-0x000000018B0D88E4 
		protected override bool isMultiPage { get; } // 0x000000018B0D86A0-0x000000018B0D86F0 
	
		// Constructors
		public UIGroupScrollList(); // 0x000000018B0D8460-0x000000018B0D86A0
	
		// Methods
		private void _BuildGroupLayout(); // 0x000000018B0D324C-0x000000018B0D3508
		private void _EnsureGroupTitleSizeCacheCount(int groupCount); // 0x000000018B0D443C-0x000000018B0D457C
		private float _GetDefaultGroupTitleSize(); // 0x000000018B0D46D8-0x000000018B0D4744
		private float _CalcGroupTitleSize(int groupIndex); // 0x000000018B0D4314-0x000000018B0D43A0
		private void _RefreshAllGroupTitleSizes(); // 0x000000018B0D5F58-0x000000018B0D5FDC
		private void _RefreshGroupTitleSizeWithoutEnsure(int groupIndex); // 0x000000018B0D5FDC-0x000000018B0D6084
		private void _RefreshGroupTitleSize(int groupIndex); // 0x000000018B0D6084-0x000000018B0D6104
		private float _GetGroupTitleSize(int groupIndex); // 0x000000018B0D5020-0x000000018B0D50D0
		private bool _GetRowInfo(int row, out int groupIndex, out bool isTitleRow, out int cellRowInGroup); // 0x000000018B0D5224-0x000000018B0D537C
		private float _GetRowHeight(int row); // 0x000000018B0D5164-0x000000018B0D5224
		private float _GetCumulativeSizeBeforeRow(int row); // 0x000000018B0D4620-0x000000018B0D46D8
		private int _GetRowForCell(int groupIndex, int cellIndexInGroup); // 0x000000018B0D50D0-0x000000018B0D5164
		private int _GetCellIndexForGroupCell(int groupIndex, int cellIndexInGroup); // 0x000000018B0D457C-0x000000018B0D4620
		private bool _GetGroupAndCellFromCellIndex(int cellIndex, out int groupIndex, out int cellIndexInGroup); // 0x000000018B0D4744-0x000000018B0D481C
		private void _GetGroupCellIndexRange(int groupIndex, out int startCellIndex, out int endCellIndex); // 0x000000018B0D4A84-0x000000018B0D4B54
		private Vector2Int _GetGroupRangeFromScrollOffset(float scrollOffset, float viewSize, float bufferSize); // 0x000000018B0D4D64-0x000000018B0D4F90
		private Vector2Int _GetGroupRangeFromCellIndexRange(Vector2Int cellIndexRange); // 0x000000018B0D4C8C-0x000000018B0D4D64
		private Vector2Int _MergeGroupRange(Vector2Int lhs, Vector2Int rhs); // 0x000000018B0D58B0-0x000000018B0D5954
		private ValueTuple<float, float> _GetScrollInfo(); // 0x000000018B0D537C-0x000000018B0D54B0
		protected override void SyncViewSize(); // 0x000000018B0D259C-0x000000018B0D2664
		protected override void InGameAwake(); // 0x000000018B0D1810-0x000000018B0D18D4
		[IDTag(0)]
		[Obsolete("UIGroupScrollList \u8BF7\u4F7F\u7528 UpdateGroup \u7CFB\u5217\u65B9\u6CD5")]
		public new void UpdateCount(int newCount); // 0x000000018B0D2A74-0x000000018B0D2AC8
		[IDTag(1)]
		[Obsolete("UIGroupScrollList \u8BF7\u4F7F\u7528 UpdateGroup \u7CFB\u5217\u65B9\u6CD5")]
		public new void UpdateCount(int newCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x0232FC42 */, bool onlyUpdateNewCellContent = false /* Metadata: 0x0232FC43 */, bool skipGraduallyShow = false /* Metadata: 0x0232FC44 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0232FC45 */); // 0x000000018B0D2AC8-0x000000018B0D2B60
		[IDTag(2)]
		public void UpdateGroup(int groupCount); // 0x000000018B0D2CD4-0x000000018B0D2D48
		[IDTag(1)]
		public void UpdateGroup(int groupCount, bool setTop, bool forceRecalculate = false /* Metadata: 0x0232FC46 */, bool onlyUpdateNewCellContent = false /* Metadata: 0x0232FC47 */, bool skipGraduallyShow = false /* Metadata: 0x0232FC48 */); // 0x000000018B0D2D48-0x000000018B0D2E04
		[IDTag(0)]
		public void UpdateGroup(int groupCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x0232FC49 */, bool onlyUpdateNewCellContent = false /* Metadata: 0x0232FC4A */, bool skipGraduallyShow = false /* Metadata: 0x0232FC4B */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0232FC4C */); // 0x000000018B0D2B60-0x000000018B0D2CD4
		public void UpdateSingleGroup(int groupIndex, int? newCellCount = default); // 0x000000018B0D2F70-0x000000018B0D324C
		public void NotifyGroupTitleSizeChange(int groupIndex); // 0x000000018B0D1980-0x000000018B0D1A28
		public int AppendCellToGroup(int groupIndex); // 0x000000018B0D041C-0x000000018B0D052C
		public bool RemoveLastCellFromGroup(int groupIndex); // 0x000000018B0D1AF0-0x000000018B0D1BF0
		private int _GetGroupStartCellIndex(int groupIndex); // 0x000000018B0D4F90-0x000000018B0D5020
		private void _RemapShowingCellIndicesAfterGroupResize(int groupIndex, int oldCellCount, int newCellCount); // 0x000000018B0D61A8-0x000000018B0D6548
		private int _GetScrollTargetRow(int groupIndex, int cellIndexInGroup, ScrollAlignType alignType); // 0x000000018B0D54B0-0x000000018B0D5560
		private void _ScrollToRow(int row, bool fastMode, ScrollAlignType alignType); // 0x000000018B0D65FC-0x000000018B0D6688
		private void _ScrollToGroup(int groupIndex, bool fastMode, ScrollAlignType alignType); // 0x000000018B0D6548-0x000000018B0D65FC
		public void ScrollToGroup(int groupIndex, bool fastMode = false /* Metadata: 0x0232FC4D */, ScrollAlignType alignType = ScrollAlignType.Top /* Metadata: 0x0232FC4E */, bool graduallyShowInFastMode = false /* Metadata: 0x0232FC4F */); // 0x000000018B0D20B8-0x000000018B0D21B4
		[IDTag(1)]
		public override void ScrollToIndex(int index, bool fastMode = false /* Metadata: 0x0232FC50 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0232FC51 */, bool graduallyShowInFastMode = false /* Metadata: 0x0232FC52 */); // 0x000000018B0D21B4-0x000000018B0D2288
		[IDTag(0)]
		public void ScrollToIndex(int groupIndex, int cellIndexInGroup, bool fastMode = false /* Metadata: 0x0232FC53 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0232FC54 */, bool graduallyShowInFastMode = false /* Metadata: 0x0232FC55 */); // 0x000000018B0D2288-0x000000018B0D23DC
		public Vector2Int GetGroupRangeInView(float bufferSize = 0f /* Metadata: 0x0232FC56 */); // 0x000000018B0D1018-0x000000018B0D10F4
		private void _RefreshIsMultiPage(); // 0x000000018B0D6104-0x000000018B0D61A8
		protected override void UpdateContainerSize(); // 0x000000018B0D2A18-0x000000018B0D2A74
		protected override float GetContainerSize(bool ignoreAutoLayout = false /* Metadata: 0x0232FC5A */); // 0x000000018B0D0E54-0x000000018B0D1018
		protected override Vector2Int GetIndexRangeFromScrollOffset(float scrollOffset, float viewSize, float bufferSize); // 0x000000018B0D11AC-0x000000018B0D141C
		private bool _IsGroupInCellRange(int groupIndex, int startCellIndex, int endCellIndex); // 0x000000018B0D5804-0x000000018B0D58B0
		private void _MoveTitleTo(Cell cell, int groupIndex); // 0x000000018B0D5C94-0x000000018B0D5E24
		private void _MoveCellTo(Cell cell, int groupIndex, int cellIndexInGroup); // 0x000000018B0D5954-0x000000018B0D5AD8
		protected override void MoveCellTo(Cell cell, int index); // 0x000000018B0D18D4-0x000000018B0D1980
		protected override float GetTargetPosByIndex(int index, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0232FC5B */); // 0x000000018B0D141C-0x000000018B0D1664
		private Cell _GetTitleCell(); // 0x000000018B0D5560-0x000000018B0D5804
		private void _CacheTitleCell(Cell cell); // 0x000000018B0D424C-0x000000018B0D4314
		private Cell _GetGroupBGCell(); // 0x000000018B0D481C-0x000000018B0D4A84
		private void _CacheGroupBGCell(Cell cell); // 0x000000018B0D4184-0x000000018B0D424C
		private float _GetGroupLength(int groupIndex); // 0x000000018B0D4B54-0x000000018B0D4C8C
		private void _MoveGroupBGTo(Cell cell, int groupIndex); // 0x000000018B0D5AD8-0x000000018B0D5C94
		private void _UpdateGroupBGByRange(Vector2Int groupRange, bool forceUpdateContent, bool ignoreListActive); // 0x000000018B0D6688-0x000000018B0D68F8
		protected override void UpdateShowingCells(bool forceUpdateContent, bool forceClearShowingCells = false /* Metadata: 0x0232FC5C */, bool ignoreListActive = false /* Metadata: 0x0232FC5D */); // 0x000000018B0D2E04-0x000000018B0D2F70
		protected override void CacheOutOfRangeCells(Vector2Int showRange, Vector2Int notCacheRange); // 0x000000018B0D052C-0x000000018B0D0A60
		protected override void ProcessCellAtIndex(int index, bool forceUpdateContent, bool ignoreListActive); // 0x000000018B0D1A28-0x000000018B0D1AF0
		protected override void RepositionOutOfRangeCells(Vector2Int showRange); // 0x000000018B0D1BF0-0x000000018B0D20B8
		private void _UpdateTitleOrCell(bool isTitle, int groupIndex, int cellIndexInGroup, int cellIndex, bool forceUpdateContent, bool ignoreListActive); // 0x000000018B0D7F88-0x000000018B0D8460
		private void _OnUpdateTitleOrCell(Cell cell, bool isTitle, int groupIndex, int cellIndexInGroup); // 0x000000018B0D5E24-0x000000018B0D5F58
		private void _UpdateShowingCellsForGroup(int dirtyGroupIndex); // 0x000000018B0D68F8-0x000000018B0D7F88
		protected override bool TryResolveWrapDirection(NaviDirection dir, out bool isBefore); // 0x000000018B0D2868-0x000000018B0D2968
		protected override bool TryGetWrapTargetIndex(NaviDirection dir, int currentIndex, bool isBefore, out int targetIndex); // 0x000000018B0D2664-0x000000018B0D2868
		private int _CellsInGroupRow(int row, int totalRowsInGroup, int cellCount); // 0x000000018B0D43A0-0x000000018B0D443C
		protected override void ClearShowingCells(); // 0x000000018B0D0B48-0x000000018B0D0DF0
		public override void ClearComponent(); // 0x000000018B0D0A60-0x000000018B0D0B48
		[IDTag(1)]
		public new GameObject Get(int cellIndex); // 0x000000018B0D1664-0x000000018B0D1714
		[IDTag(0)]
		public GameObject Get(int groupIndex, int cellIndexInGroup); // 0x000000018B0D1714-0x000000018B0D1810
		public GameObject GetGroupTitle(int groupIndex); // 0x000000018B0D10F4-0x000000018B0D11AC
		[IDTag(1)]
		public new void SetCellCanCache(int cellIndex, bool canCache); // 0x000000018B0D23DC-0x000000018B0D2484
		[IDTag(0)]
		public void SetCellCanCache(int groupIndex, int cellIndexInGroup, bool canCache); // 0x000000018B0D2484-0x000000018B0D259C
		public string DebugDumpLayoutToConsoleAndClipboard(); // 0x000000018B0D0DF0-0x000000018B0D0E54
		private string _BuildLayoutDebugDumpText(); // 0x000000018B0D3508-0x000000018B0D4184
		public void __iFixBaseProxy_SyncViewSize(); // 0x000000018B0D29D8-0x000000018B0D29E0
		public void __iFixBaseProxy_InGameAwake(); // 0x000000018B0D29A0-0x000000018B0D29A8
		public void __iFixBaseProxy_ScrollToIndex(int P0, bool P1, ScrollAlignType P2, bool P3); // 0x000000018B0D29C0-0x000000018B0D29D8
		public bool __iFixBaseProxy_get_isMultiPage(); // 0x000000018B0D2A10-0x000000018B0D2A18
		public void __iFixBaseProxy_UpdateContainerSize(); // 0x000000018B0D29F8-0x000000018B0D2A00
		public float __iFixBaseProxy_GetContainerSize(bool P0); // 0x000000018B0D2980-0x000000018B0D2988
		public Vector2Int __iFixBaseProxy_GetIndexRangeFromScrollOffset(float P0, float P1, float P2); // 0x000000018B0D2988-0x000000018B0D2998
		public void __iFixBaseProxy_MoveCellTo(Cell P0, int P1); // 0x000000018B0B93C4-0x000000018B0B93CC
		public float __iFixBaseProxy_GetTargetPosByIndex(int P0, ScrollAlignType P1); // 0x000000018B0D2998-0x000000018B0D29A0
		public void __iFixBaseProxy_UpdateShowingCells(bool P0, bool P1, bool P2); // 0x000000018B0D2A00-0x000000018B0D2A10
		public void __iFixBaseProxy_CacheOutOfRangeCells(Vector2Int P0, Vector2Int P1); // 0x000000018B0D2968-0x000000018B0D2970
		public void __iFixBaseProxy_ProcessCellAtIndex(int P0, bool P1, bool P2); // 0x000000018B0D29A8-0x000000018B0D29B8
		public void __iFixBaseProxy_RepositionOutOfRangeCells(Vector2Int P0); // 0x000000018B0D29B8-0x000000018B0D29C0
		public bool __iFixBaseProxy_TryResolveWrapDirection(NaviDirection P0, out bool P1); // 0x000000018B0D29F0-0x000000018B0D29F8
		public bool __iFixBaseProxy_TryGetWrapTargetIndex(NaviDirection P0, int P1, bool P2, out int P3); // 0x000000018B0D29E0-0x000000018B0D29F0
		public void __iFixBaseProxy_ClearShowingCells(); // 0x000000018B0D2978-0x000000018B0D2980
		public void __iFixBaseProxy_ClearComponent(); // 0x000000018B0D2970-0x000000018B0D2978
	}

	public class UIGyroscopeEffect : TickableUIMono // TypeDefIndex: 50376
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
		protected override TickType tickOption { get; } // 0x00000001848B9F30-0x00000001848B9F60 
	
		// Nested types
		[Serializable]
		public class Param // TypeDefIndex: 50375
		{
			// Fields
			public float maxAngle; // 0x10
			[Space(10f)]
			public AnimationCurve valueCurve; // 0x18
	
			// Constructors
			public Param(); // 0x0000000184D7F870-0x0000000184D7F880
		}
	
		// Constructors
		public UIGyroscopeEffect(); // 0x000000018496E710-0x000000018496E770
	
		// Methods
		protected override void OnAwake(); // 0x0000000184CB6830-0x0000000184CB68B0
		public override void Tick(float deltaTime); // 0x0000000183403E30-0x0000000183405760
		protected override void OnRelease(); // 0x000000018B0D9E2C-0x000000018B0D9ED4
		[CompilerGenerated]
		private Vector3 _Tick_b__22_0(); // 0x000000018B0D9ED4-0x000000018B0D9F08
		[CompilerGenerated]
		private void _Tick_b__22_1(Vector3 value); // 0x000000018B0D9F08-0x000000018B0D9F30
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	public class UIHighlightMask : TickableUIMono // TypeDefIndex: 50377
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
		protected override TickType tickOption { get; } // 0x000000018B0DA48C-0x000000018B0DA4DC 
		public LuaPanel panel { get; } // 0x000000018B0DA3C8-0x000000018B0DA48C 
	
		// Constructors
		public UIHighlightMask(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		protected override void OnAwake(); // 0x000000018B0D9F30-0x000000018B0D9FC0
		protected override void OnEnable(); // 0x000000018B0D9FC0-0x000000018B0DA01C
		public override void Tick(float deltaTime); // 0x000000018B0DA01C-0x000000018B0DA07C
		public void TrySyncRect(); // 0x000000018B0DA07C-0x000000018B0DA3C8
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	[AddComponentMenu("UI/UI Image", 11)]
	public class UIImage : HGImage // TypeDefIndex: 50378
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
		public const string SPRITE_PATH_FORMAT = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}/{1}.png"; // Metadata: 0x0232FC7B
		public const string SPRITE_ROOT_PATH_FORMAT = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}.png"; // Metadata: 0x0232FCB7
		public bool enableAutoImgUsePathReference; // 0x210
		public bool imgUsePathReference; // 0x211
		public string imgRefPath; // 0x218
		private bool m_imgIsPathReference; // 0x220
	
		// Properties
		public bool packIntoRuntimeAtlas { get; set; } // 0x000000018B0DB984-0x000000018B0DB9D4 0x000000018B0DBA24-0x000000018B0DBA80
		public int atlasHandleId { get; set; } // 0x000000018B0DB8E4-0x000000018B0DB934 0x00000001830938F0-0x0000000183093960
		public LuaPanel panel { get; } // 0x00000001831EBBA0-0x00000001831EBCB0 
		public ref UIAtlasManager.UIAtlasHandle atlasHandle { get; } // 0x000000018B0DB934-0x000000018B0DB984 
		public int panelLevel { get; } // 0x000000018B0DB9D4-0x000000018B0DBA24 
		public override UnityEngine.Color color { get; set; } // 0x00000001831BABD0-0x00000001831BAC50 0x00000001830466A0-0x0000000183046910
		public override Texture mainTexture { get; } // 0x00000001831EDB00-0x00000001831EDF80 
	
		// Constructors
		public UIImage(); // 0x0000000183695F50-0x0000000183696CD0
	
		// Methods
		public void RegisterOnEnableRuntimeAtlas(Action callBack); // 0x000000018309A110-0x000000018309A1A0
		public void UnregisterOnEnableRuntimeAtlas(Action callBack); // 0x000000018309BFF0-0x000000018309C080
		public void OnEnableRuntimeAtlas(); // 0x000000018B0DB7F8-0x000000018B0DB854
		protected override void _OnSpriteChanged(Sprite lastOne); // 0x0000000183093770-0x00000001830938F0
		protected override void OnPopulateMeshFallback(VertexHelper toFill); // 0x0000000183FC41E0-0x0000000183FC4250
		protected override void Awake(); // 0x0000000183093A70-0x0000000183093B40
		protected override void OnEnable(); // 0x00000001831EB820-0x00000001831EBBA0
		protected override void OnDisable(); // 0x000000018351A0A0-0x000000018351A210
		protected override void OnDestroy(); // 0x0000000183093F30-0x0000000183094090
		public override void SetNativeSize(); // 0x00000001831EB3E0-0x00000001831EB530
		public void SetNativeSizeIgnoreRefScale(); // 0x000000018B0DB854-0x000000018B0DB8A4
		[IDTag(0)]
		public void LoadSprite(string folder, string spriteName); // 0x0000000183914E50-0x0000000183914ED0
		[IDTag(1)]
		public void LoadSprite(string path); // 0x00000001845F23B0-0x00000001845F2410
		public void LoadSpriteWithOutFormat(string path, bool ignoreEnable = false /* Metadata: 0x0232FC78 */); // 0x00000001836D4790-0x00000001836D47E0
		private void _LoadSprite(string path, bool ignoreEnable = false /* Metadata: 0x0232FC79 */); // 0x00000001830486F0-0x0000000183049230
		public void LoadMaterial(string path, bool newInstance = false /* Metadata: 0x0232FC7A */); // 0x000000018B0DB5BC-0x000000018B0DB7F8
		public override void ReleaseSprite(); // 0x0000000184695BB0-0x0000000184695BF0
		public void DisposeSpriteHandle(); // 0x0000000183094090-0x0000000183094110
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void _V2AtlasInitialize(); // 0x00000001841A6140-0x00000001841A6310
		public UnityEngine.Color __iFixBaseProxy_get_color(); // 0x0000000184D8C200-0x0000000184D8C210
		public void __iFixBaseProxy_set_color(UnityEngine.Color P0); // 0x000000018B0C6930-0x000000018B0C6950
		public void __iFixBaseProxy__OnSpriteChanged(Sprite P0); // 0x000000018B0DB8D4-0x000000018B0DB8DC
		public void __iFixBaseProxy_OnPopulateMeshFallback(VertexHelper P0); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_Awake(); // 0x000000018B0DB8A4-0x000000018B0DB8AC
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0DB8BC-0x000000018B0DB8C4
		public void __iFixBaseProxy_OnDisable(); // 0x000000018B0DB8B4-0x000000018B0DB8BC
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0DB8AC-0x000000018B0DB8B4
		public void __iFixBaseProxy_SetNativeSize(); // 0x000000018B0DB8CC-0x000000018B0DB8D4
		public void __iFixBaseProxy_ReleaseSprite(); // 0x000000018B0DB8C4-0x000000018B0DB8CC
		public Texture __iFixBaseProxy_get_mainTexture(); // 0x000000018B0DB8DC-0x000000018B0DB8E4
	}

	[RequireComponent(typeof(UIImage))]
	public class UIImageBlur : TickableUIMono // TypeDefIndex: 50379
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
		protected override TickType tickOption { get; } // 0x0000000184A355B0-0x0000000184A355E0 
	
		// Constructors
		public UIImageBlur(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		protected override void OnAwake(); // 0x00000001837E33F0-0x00000001837E35D0
		public void OnChangeSprite(); // 0x00000001837E1FD0-0x00000001837E22D0
		public override void Tick(float deltaTime); // 0x000000018B0DA560-0x000000018B0DA6BC
		protected override void OnDisable(); // 0x000000018484FBD0-0x000000018484FD10
		protected override void OnRelease(); // 0x000000018B0DA4DC-0x000000018B0DA560
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	[RequireComponent(typeof(UIImage))]
	public class UIImageFillAmountOffset : MonoBehaviour // TypeDefIndex: 50380
	{
		// Fields
		private UIImage m_followImage; // 0x18
		public float fillOffset; // 0x20
		private float m_fillAmount; // 0x24
	
		// Properties
		public float fillAmount { get; set; } // 0x000000018B0DA850-0x000000018B0DA8A0 0x000000018B0DA8A0-0x000000018B0DA9D8
	
		// Constructors
		public UIImageFillAmountOffset(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public TweenerCore<float, float, FloatOptions> DOFillAmount(float endValue, float duration); // 0x000000018B0DA6BC-0x000000018B0DA840
		[CompilerGenerated]
		private float _DOFillAmount_b__6_0(); // 0x000000018B0DA840-0x000000018B0DA848
		[CompilerGenerated]
		private void _DOFillAmount_b__6_1(float x); // 0x000000018B0DA848-0x000000018B0DA850
	}

	public class UIImageFillFollower : TickableUIMono // TypeDefIndex: 50381
	{
		// Fields
		private const float BACK_FOLLOW_THRESHOLD = 0.02f; // Metadata: 0x0232FCEF
		[SerializeField]
		private UIImage _frontFill; // 0x68
		[SerializeField]
		private float _followSpeed; // 0x70
		private UIImage m_image; // 0x78
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B0DAC70-0x000000018B0DACC0 
	
		// Constructors
		public UIImageFillFollower(); // 0x000000018B0DAC60-0x000000018B0DAC70
	
		// Methods
		protected override void OnAwake(); // 0x000000018B0DA9D8-0x000000018B0DAA7C
		protected override void OnEnable(); // 0x000000018B0DAA7C-0x000000018B0DAAF0
		public override void Tick(float deltaTime); // 0x000000018B0DAB5C-0x000000018B0DAC60
		public void RefreshFillAmount(); // 0x000000018B0DAAF0-0x000000018B0DAB5C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	[AddComponentMenu("UI/UI Image Filled Tail Follower", 34)]
	[ExecuteInEditMode]
	[Tooltip("\u81EA\u8EAB\u5FC5\u987B\u662F\u8981\u8DDF\u968F\u7684Follow Image\u7684\u5B50\u8282\u70B9\uFF1B\u4EC5\u5904\u7406Fill Method\u4E3A\u6C34\u5E73\u6216\u5782\u76F4\u7684\u60C5\u51B5")]
	public class UIImageFillTailFollower : TickableUIMono // TypeDefIndex: 50382
	{
		// Fields
		[SerializeField]
		private UIImage _followImage; // 0x68
		public float followOffset; // 0x70
		private RectTransform m_selfRectTransform; // 0x78
		private RectTransform m_followImageRectTransform; // 0x80
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B0DB108-0x000000018B0DB158 
	
		// Constructors
		public UIImageFillTailFollower(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		protected override void OnAwake(); // 0x000000018B0DACC0-0x000000018B0DAD84
		protected override void OnEnable(); // 0x000000018B0DAD84-0x000000018B0DADEC
		public override void Tick(float deltaTime); // 0x000000018B0DB09C-0x000000018B0DB108
		public void RefreshFollower(); // 0x000000018B0DADEC-0x000000018B0DB09C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	[Obsolete("\u8FD9\u4E2A\u7EC4\u4EF6\u7684\u529F\u80FD\u53EF\u4EE5\u76F4\u63A5\u653E\u5230UIImage\u91CC\u4E86\uFF0C\u4E4B\u540E\u6709\u65F6\u95F4\u53EF\u4EE5\u628A\u5B83\u8FC1\u79FB\u8FC7\u53BB")]
	public class UIImagePair : MonoBehaviour // TypeDefIndex: 50383
	{
		// Fields
		public List<UIImage> referencedImages; // 0x18
	
		// Properties
		public UnityEngine.Color color { set; } // 0x000000018B0DB42C-0x000000018B0DB5BC
		public UIImage first { get; } // 0x000000018B0DB394-0x000000018B0DB42C 
	
		// Constructors
		public UIImagePair(); // 0x000000018B0DB314-0x000000018B0DB394
	
		// Methods
		[IDTag(1)]
		public void LoadSprite(string folder, string spriteName); // 0x000000018B0DB284-0x000000018B0DB314
		[IDTag(0)]
		public void LoadSprite(string path); // 0x000000018B0DB158-0x000000018B0DB284
	}

	public class UIInertiaViewPager : TickableUIMono, IUIClearable // TypeDefIndex: 50397
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
		[CompilerGenerated]
		private int _pageCount_k__BackingField; // 0xE0
		[NonSerialized]
		public DisposedUnityEvent<int> onStateChanged; // 0xE8
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B0DCA94-0x000000018B0DCAE4 
		public bool isUpdating { get; } // 0x000000018B0DCA40-0x000000018B0DCA94 
		public int pageCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D9A880-0x0000000184D9A890 0x0000000184DA3470-0x0000000184DA3480
		public int currentPage { get; set; } // 0x000000018B0DC988-0x000000018B0DC9D8 0x000000018B0DCAE4-0x000000018B0DCB48
		public float currentScrollIndex { get; } // 0x000000018B0DC9D8-0x000000018B0DCA40 
	
		// Nested types
		public enum State // TypeDefIndex: 50384
		{
			IDLE = 0,
			DRAGING = 1,
			INERTIA = 2,
			ALIGNING = 3
		}
	
		private interface IScrollHandler : IHotfixable // TypeDefIndex: 50385
		{
			// Properties
			float velocity { get; }
			bool isDragging { get; }
			float scrollProgress { get; set; }
	
			// Methods
			void OnClear();
			void StopMoving();
		}
	
		private class CustomScrollHandler : Beyond.UI.UIInertiaViewPager.IScrollHandler // TypeDefIndex: 50386
		{
			// Fields
			private bool m_isScrolling; // 0x10
			private UIScrollRect m_scrollRect; // 0x18
	
			// Properties
			public float velocity { get; } // 0x000000018B0D93E8-0x000000018B0D9468 
			public float scrollProgress { get; set; } // 0x000000018B0D935C-0x000000018B0D93E8 0x000000018B0D9468-0x000000018B0D94FC
			public bool isDragging { get; } // 0x000000018B0D92F4-0x000000018B0D935C 
	
			// Constructors
			public CustomScrollHandler(UIScrollRect scrollRect); // 0x000000018B0D91C4-0x000000018B0D92F4
	
			// Methods
			public void OnClear(); // 0x000000018B0D8F50-0x000000018B0D90A4
			public void StopMoving(); // 0x000000018B0D90A4-0x000000018B0D9104
			private void _OnScrollBegin(Vector2 delta); // 0x000000018B0D9104-0x000000018B0D9164
			private void _OnScrollEnd(Vector2 delta); // 0x000000018B0D9164-0x000000018B0D91C4
		}
	
		private struct EmptyScrollHandler : Beyond.UI.UIInertiaViewPager.IScrollHandler // TypeDefIndex: 50387
		{
			// Properties
			public float velocity { get; } // 0x000000018B0D985C-0x000000018B0D98A8 
			public bool isDragging { get; } // 0x000000018B0D97C4-0x000000018B0D9810 
			public float scrollProgress { get; set; } // 0x000000018B0D9810-0x000000018B0D985C 0x000000018B0D98A8-0x000000018B0D98FC
	
			// Methods
			public void StopMoving(); // 0x000000018B0D9780-0x000000018B0D97C4
			public void OnClear(); // 0x000000018B0D973C-0x000000018B0D9780
		}
	
		public struct FlingToNext // TypeDefIndex: 50388
		{
			// Fields
			public bool enable; // 0x00
			public float minSpd; // 0x04
			public float maxSpd; // 0x08
		}
	
		public struct ScrollOptions // TypeDefIndex: 50389
		{
			// Fields
			public FlingToNext flingToNext; // 0x00
		}
	
		private class DragContext // TypeDefIndex: 50390
		{
			// Fields
			public float startPos; // 0x10
	
			// Constructors
			public DragContext(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void BeginDrag(UIInertiaViewPager pager); // 0x000000018B0D94FC-0x000000018B0D956C
			public State EndDrag(UIInertiaViewPager pager); // 0x000000018B0D956C-0x000000018B0D95D8
			private bool _TryFlingToNext(UIInertiaViewPager pager); // 0x000000018B0D95D8-0x000000018B0D973C
		}
	
		private enum BlockerDir // TypeDefIndex: 50391
		{
			UPWARD = 0,
			DOWNNWARD = 1,
			BOTH = 2
		}
	
		private struct InertiaBlocker : IHotfixable // TypeDefIndex: 50392
		{
			// Fields
			public BlockerDir dir; // 0x00
			public int index; // 0x04
	
			// Methods
			public bool IsDirMatch(float vec); // 0x000000018B0D98FC-0x000000018B0D9984
		}
	
		private class BlockerManager : IHotfixable // TypeDefIndex: 50393
		{
			// Fields
			private const float INERTIA_BIAS = 0.49f; // Metadata: 0x0232FCFA
			private List<InertiaBlocker> m_inertiaBlockers; // 0x10
			private float m_lastIndex; // 0x18
			[CompilerGenerated]
			private bool _isInertiaing_k__BackingField; // 0x1C
	
			// Properties
			public bool isInertiaing { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86150-0x0000000184D86160 0x0000000184D86160-0x0000000184D86170
	
			// Constructors
			public BlockerManager(); // 0x000000018B0D8ED8-0x000000018B0D8F50
	
			// Methods
			public void Init(int pageCount, List<int> blockFrames); // 0x000000018B0D8CE0-0x000000018B0D8E78
			public void StartInertia(float fromIndex); // 0x000000018B0D8E78-0x000000018B0D8ED8
			public bool HitInertiaBlock(float curIndex, out float preferTo); // 0x000000018B0D8AB4-0x000000018B0D8CE0
		}
	
		public struct ScrollEffectConfig // TypeDefIndex: 50395
		{
			// Fields
			public Action onScrollToItem; // 0x00
			public Action onAlignedToItem; // 0x08
			public float minScrollInterval; // 0x10
			public Timing timing; // 0x14
	
			// Nested types
			public enum Timing // TypeDefIndex: 50394
			{
				HALF_VALUE = 0,
				FULL_VALUE = 1
			}
	
			// Methods
			public bool IsEmpty(); // 0x000000018B0D9984-0x000000018B0D99E4
		}
	
		public class ScrollEffectTrigger : IHotfixable // TypeDefIndex: 50396
		{
			// Fields
			private const float DFT_MIN_INTERVAL = 0.1f; // Metadata: 0x0232FD00
			private bool m_isValid; // 0x10
			private ScrollEffectConfig m_config; // 0x18
			private int m_lastFocusIndex; // 0x30
			private float m_curTime; // 0x34
			private float m_lastScrollTime; // 0x38
			private bool m_hasScrolled; // 0x3C
	
			// Constructors
			public ScrollEffectTrigger(ScrollEffectConfig config); // 0x000000018B0D9C24-0x000000018B0D9CE4
	
			// Methods
			public void NotifyScrolling(float curIndex, float deltaTime); // 0x000000018B0D9A9C-0x000000018B0D9BB4
			public void MarkHasScrolled(); // 0x000000018B0D99E4-0x000000018B0D9A38
			public void NotifyAlignFinish(); // 0x000000018B0D9A38-0x000000018B0D9A9C
			public void Reset(int curIndex); // 0x000000018B0D9BB4-0x000000018B0D9C24
		}
	
		// Constructors
		public UIInertiaViewPager(); // 0x000000018B0DC84C-0x000000018B0DC988
	
		// Methods
		private void _PlayAudioGear(); // 0x000000018B0DC508-0x000000018B0DC584
		private void _PlayAudioGearLock(); // 0x000000018B0DC48C-0x000000018B0DC508
		private void _InitIfNot(); // 0x000000018B0DC11C-0x000000018B0DC338
		public void ClearComponent(); // 0x000000018B0DBA80-0x000000018B0DBB48
		public override void Tick(float deltaTime); // 0x000000018B0DBD2C-0x000000018B0DC0A4
		public void SetPageCount(int pageCount, List<int> segmentFrames = null); // 0x000000018B0DBCA4-0x000000018B0DBD2C
		public void MoveToPage(int pageIndex); // 0x000000018B0DBB48-0x000000018B0DBBD8
		protected override void OnAwake(); // 0x000000018B0DBBD8-0x000000018B0DBC34
		protected override void OnEnable(); // 0x000000018B0DBC34-0x000000018B0DBCA4
		private float _ScrollValue2PageIndex(float value); // 0x000000018B0DC584-0x000000018B0DC5FC
		private float _PageIndex2ScrollValue(float index); // 0x000000018B0DC410-0x000000018B0DC48C
		private int _ScrollValueAlignToPage(float value); // 0x000000018B0DC5FC-0x000000018B0DC680
		private void _SwitchToPage(int targetIndex, bool useTween); // 0x000000018B0DC680-0x000000018B0DC84C
		private void _AutoAlign(); // 0x000000018B0DC0A4-0x000000018B0DC11C
		private void _OnStateChanged(State from, State to); // 0x000000018B0DC338-0x000000018B0DC410
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
	}

	[AddComponentMenu("UI/UI Input Field", 103)]
	public class UIInputField : TMP_InputField, IUIClearable // TypeDefIndex: 50399
	{
		// Fields
		public string activeInputActionId; // 0x390
		public string deactivateInputActionId; // 0x398
		[CompilerGenerated]
		private int _activeInputBindingId_k__BackingField; // 0x3A0
		[CompilerGenerated]
		private int _deactivateInputBindingId_k__BackingField; // 0x3A4
		private LuaPanel m_panel; // 0x3A8
		public bool isDebugInputField; // 0x3B0
		private Camera m_fallbackUICamera; // 0x3B8
		private GameObject m_fallbackUIRoot; // 0x3C0
		private RectTransform m_fallbackRectTransform; // 0x3C8
		private int m_activateBindingGroupId; // 0x3D0
		private bool m_isNaviFocused; // 0x3D4
		private bool m_isCloudInputting; // 0x3D5
		[SerializeField]
		private UIStateController _uiStateController; // 0x3D8
		[SerializeField]
		private string _onFocusStateName; // 0x3E0
		[SerializeField]
		private string _onFocusLostStateName; // 0x3E8
		[AudioString]
		[SerializeField]
		private string _audioPressStart; // 0x3F0
		public RectTransform m_keyboardOffsetTarget; // 0x3F8
		public RectTransform m_offsetTargetParent; // 0x400
		public RectTransform m_inputFieldRect; // 0x408
		public int m_pcDebug; // 0x410
		public float m_keyboardExtraOffsetY; // 0x414
		private Vector2 m_baseKeyboardOffsetTarget; // 0x418
		private Vector2 m_baseKeyboardLocalPos; // 0x420
		private float m_inputFieldOffsetY; // 0x428
		private bool m_enableKeyboardOffsetCal; // 0x42C
		private Coroutine m_heightChangeCoroutine; // 0x430
		private int m_lastHeight; // 0x438
		private int m_nowHeight; // 0x43C
		[AudioString]
		public string audioOnActive; // 0x440
		private static UIInputField s_mFocusedInputField; // 0x00
	
		// Properties
		public int activeInputBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DAAE90-0x0000000184DAAEA0 0x0000000184DAAEB0-0x0000000184DAAEC0
		public int deactivateInputBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DAAEA0-0x0000000184DAAEB0 0x0000000184DAAEC0-0x0000000184DAAED0
		public LuaPanel panel { get; } // 0x000000018B0DD0C8-0x000000018B0DD18C 
		private bool isControllerInputValid { get; } // 0x0000000183BA8140-0x0000000183BA81C0 
		public static UIInputField s_focusedInputField { get; private set; } // 0x0000000183BA80F0-0x0000000183BA8140 0x0000000183BA86F0-0x0000000183BA88C0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __KeyboardHeightChange_d__63 : IEnumerator<object> // TypeDefIndex: 50398
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIInputField __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __KeyboardHeightChange_d__63(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B0D9CE4-0x000000018B0D9D3C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B0D9D3C-0x000000018B0D9D88
		}
	
		// Constructors
		public UIInputField(); // 0x000000018405B310-0x000000018405B3D0
	
		// Methods
		protected override void SendOnFocus(); // 0x0000000184B47C70-0x0000000184B47D60
		protected override void SendOnFocusLost(); // 0x0000000184CB1920-0x0000000184CB19D0
		protected override void Awake(); // 0x00000001837D5FA0-0x00000001837D6230
		public override void OnSelect(BaseEventData eventData); // 0x0000000184CA2A60-0x0000000184CA2AB0
		public override void OnDeselect(BaseEventData eventData); // 0x0000000184B6C8C0-0x0000000184B6C910
		public override void OnUpdateSelected(BaseEventData eventData); // 0x00000001837987D0-0x0000000183798820
		public override void ActivateInputField(); // 0x0000000183BA7EB0-0x0000000183BA7FB0
		protected override bool TryActivateInputFieldCustom(); // 0x0000000184CC9BB0-0x0000000184CC9C70
		public override void DeactivateInputField(bool clearSelection = false /* Metadata: 0x0232FD04 */); // 0x0000000183BA7FB0-0x0000000183BA80F0
		protected override void OnDestroy(); // 0x00000001847A96A0-0x00000001847A9790
		protected override void OnEnable(); // 0x0000000182EDCBD0-0x0000000182EDCC10
		protected override void OnDisable(); // 0x0000000182EDCC10-0x0000000182EDCC50
		protected override void _NotifyIsHover(bool isHover); // 0x00000001846B5530-0x00000001846B55B0
		public override void OnInteractableChanged(); // 0x000000018B0DCB48-0x000000018B0DCB98
		private void _UpdateBindingEnable(); // 0x0000000182EDCC50-0x0000000182EDCD20
		public void ClearComponent(); // 0x00000001847A9790-0x00000001847A98C0
		private void _OnCloudGameKeyboardComplete(string value, bool submit); // 0x000000018B0DCF10-0x000000018B0DD074
		private Camera _GetCamera(); // 0x000000018B0DCC34-0x000000018B0DCE74
		private void _VirtualKeyboardOnDestroy(); // 0x00000001847A98C0-0x00000001847A98F0
		private void _VirtualKeyboardSelect(); // 0x0000000184CA2AB0-0x0000000184CA2AE0
		private void _VirtualKeyboardDeselect(); // 0x0000000184B6C910-0x0000000184B6C940
		private void _VirtualKeyboardAwake(); // 0x00000001837D6430-0x00000001837D6470
		private void _UpdateKeyboardOffset(int offsetHeight); // 0x000000018B0DD074-0x000000018B0DD0C8
		private void _CleanupAndroidObjects(); // 0x000000018B0DCBF0-0x000000018B0DCC34
		private void _VirtualKeyboardInitJavaObj(); // 0x00000001837D6470-0x00000001837D64A0
		[IteratorStateMachine(typeof(__KeyboardHeightChange_d__63))]
		private IEnumerator _KeyboardHeightChange(Action<int> onHeightChanged); // 0x000000018B0DCE74-0x000000018B0DCF10
		[CompilerGenerated]
		private void _Awake_b__28_0(); // 0x000000018B0DCB98-0x000000018B0DCBA8
		public void __iFixBaseProxy_SendOnFocus(); // 0x000000018B0DCBE8-0x000000018B0DCBF0
		public void __iFixBaseProxy_SendOnFocusLost(); // 0x000000018B0DCBE0-0x000000018B0DCBE8
		public void __iFixBaseProxy_Awake(); // 0x000000018B0869D4-0x000000018B0869DC
		public void __iFixBaseProxy_OnSelect(BaseEventData P0); // 0x000000018B0DCBD0-0x000000018B0DCBD8
		public void __iFixBaseProxy_OnDeselect(BaseEventData P0); // 0x000000018B0DCBB8-0x000000018B0DCBC0
		public void __iFixBaseProxy_OnUpdateSelected(BaseEventData P0); // 0x000000018B0DCBD8-0x000000018B0DCBE0
		public void __iFixBaseProxy_ActivateInputField(); // 0x000000018B0DCBA8-0x000000018B0DCBB0
		public bool __iFixBaseProxy_TryActivateInputFieldCustom(); // 0x00000001812081B0-0x0000000181208610
		public void __iFixBaseProxy_DeactivateInputField(bool P0); // 0x000000018B0DCBB0-0x000000018B0DCBB8
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0869DC-0x000000018B0869E4
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0DCBC8-0x000000018B0DCBD0
		public void __iFixBaseProxy_OnDisable(); // 0x000000018B0DCBC0-0x000000018B0DCBC8
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018B0C581C-0x000000018B0C5824
		public void __iFixBaseProxy_OnInteractableChanged(); // 0x00000001841E1670-0x00000001841E1680
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UIJoystick : MonoBehaviour, IBeginDragHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler, IUIClearable, IBindingGroupTarget // TypeDefIndex: 50400
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
		[CompilerGenerated]
		private Vector2 _jsValue_k__BackingField; // 0x88
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
		private KeyboardKeyCode _keyboardUp; // 0xB0
		[SerializeField]
		private KeyboardKeyCode _keyboardDown; // 0xB4
		[SerializeField]
		private KeyboardKeyCode _keyboardLeft; // 0xB8
		[SerializeField]
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
		[CompilerGenerated]
		private PointerEventData _curDragEventData_k__BackingField; // 0x170
		private int m_groupId; // 0x178
		private bool m_bindingInit; // 0x17C
		[CompilerGenerated]
		private InputBindingGroupMonoTarget _parent_k__BackingField; // 0x180
	
		// Properties
		public LuaPanel panel { get; } // 0x000000018B0DD8E4-0x000000018B0DD9A8 
		public bool isDynamic { get; set; } // 0x0000000183092CB0-0x0000000183092CE0 0x000000018B0DDA48-0x000000018B0DDAAC
		public float walkRation { get; set; } // 0x000000018B0DD9F8-0x000000018B0DDA48 0x00000001839D4DF0-0x00000001839D4E50
		public bool active { get; } // 0x0000000184CC5A60-0x0000000184CC5A90 
		public int activeTouchId { get; } // 0x000000018B0DD828-0x000000018B0DD88C 
		public Vector2 jsValue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D9E750-0x0000000184D9E770 0x0000000184D85ED0-0x0000000184D85EE0
		private float m_thumbPosMaxLength { get; } // 0x0000000183790D10-0x0000000183790D90 
		public PointerEventData curDragEventData { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8DEF0-0x0000000184D8DF00 0x0000000186B8B940-0x0000000186B8B954
		public bool groupEnabled { get; } // 0x0000000183792ED0-0x0000000183792F20 
		public bool shouldCheckInput { get; } // 0x0000000183792E40-0x0000000183792ED0 
		public int groupId { get; } // 0x000000018B0DD88C-0x000000018B0DD8E4 
		public IBindingGroupTarget parentTarget { get; } // 0x000000018B0DD9A8-0x000000018B0DD9F8 
		public InputBindingGroupMonoTarget parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8DD60-0x0000000184D8DD70 0x0000000186B8B774-0x0000000186B8B788
	
		// Constructors
		public UIJoystick(); // 0x0000000183EB2780-0x0000000183EB2AA0
	
		// Methods
		private void Reset(); // 0x000000018B0DD64C-0x000000018B0DD71C
		private void Awake(); // 0x00000001839D3170-0x00000001839D37F0
		protected void OnEnable(); // 0x0000000184B4B8D0-0x0000000184B4BA00
		private void Start(); // 0x0000000184CE2A30-0x0000000184CE2AE0
		protected void OnDestroy(); // 0x000000018B0DD294-0x000000018B0DD4C4
		private void _Tick(); // 0x00000001837913E0-0x0000000183792E40
		protected void OnDisable(); // 0x000000018B0DD4C4-0x000000018B0DD64C
		public void OnPointerDown(PointerEventData eventData); // 0x0000000183091360-0x0000000183092BD0
		public void OnPointerUp(PointerEventData eventData); // 0x00000001844C0620-0x00000001844C0780
		public void OnBeginDrag(PointerEventData eventData); // 0x00000001846FDA20-0x00000001846FDA70
		public void OnDrag(PointerEventData eventData); // 0x00000001837901B0-0x0000000183790D10
		public void CheckShouldActive(); // 0x00000001842EE960-0x00000001842EEF60
		private void _SetVisible(bool visible); // 0x00000001839D4BE0-0x00000001839D4C40
		private void _ChangeDynamic(bool dynamic, bool force = false /* Metadata: 0x0232FD05 */); // 0x00000001839D48D0-0x00000001839D4A20
		private void _SetRectTransform(bool toOri); // 0x0000000183092D80-0x0000000183093020
		private void _UpdateWalkBgScale(); // 0x00000001839D4C40-0x00000001839D4DF0
		private void _Activate(bool fromTouch, Vector2 showPos, Vector2 initJsValue); // 0x0000000183092BD0-0x0000000183092CB0
		private void _UpdateGait(); // 0x0000000183791310-0x00000001837913E0
		private void _UpdateIndicator(); // 0x0000000183790D90-0x0000000183790F40
		private void _UpdateBg(); // 0x0000000183791120-0x00000001837911D0
		private void _SetWalkBgVisible(bool visible, bool ignoreAnim = false /* Metadata: 0x0232FD06 */); // 0x00000001837911D0-0x0000000183791250
		private void _SetRunBgVisible(bool visible, bool ignoreAnim = false /* Metadata: 0x0232FD07 */); // 0x0000000183791250-0x0000000183791310
		private void _OnHudLayoutLoaded([IsReadOnly] in EventData<string> eventData); // 0x000000018B0DD728-0x000000018B0DD828
		public void ClearComponent(); // 0x000000018B0DD18C-0x000000018B0DD294
		public void InitBinding(); // 0x00000001839D46A0-0x00000001839D47F0
		private void _UpdateState(); // 0x00000001839D47F0-0x00000001839D48D0
		[CompilerGenerated]
		private void _Awake_b__76_0(Vector2 _); // 0x000000018B0DD71C-0x000000018B0DD728
	}

	public class UILayoutDimensionListener : UIBehaviour, IHotfixable, ICanvasElement // TypeDefIndex: 50403
	{
		// Fields
		private ListSet<IAction> m_actionsWhenLayoutReady; // 0x18
		[NonSerialized]
		public DisposedUnityEvent eventOnPostLayout; // 0x20
	
		// Properties
		Transform ICanvasElement.transform { get; } // 0x000000018B0DDD7C-0x000000018B0DDDCC 
	
		// Nested types
		public interface IAction // TypeDefIndex: 50401
		{
			// Methods
			void DoAction();
		}
	
		[CompilerGenerated]
		private sealed class __NextFrameCoroutine_d__6 : IEnumerator<object> // TypeDefIndex: 50402
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UILayoutDimensionListener __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __NextFrameCoroutine_d__6(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B0D9D88-0x000000018B0D9DE0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B0D9DE0-0x000000018B0D9E2C
		}
	
		// Constructors
		public UILayoutDimensionListener(); // 0x0000000184B21870-0x0000000184B21940
	
		// Methods
		public void GraphicUpdateComplete(); // 0x000000018B0DDB3C-0x000000018B0DDB80
		public void LayoutComplete(); // 0x000000018B0DDB80-0x000000018B0DDBC4
		public void Rebuild(CanvasUpdate executing); // 0x000000018B0DDCFC-0x000000018B0DDD7C
		[IteratorStateMachine(typeof(__NextFrameCoroutine_d__6))]
		private IEnumerator _NextFrameCoroutine(); // 0x000000018B0DDFE0-0x000000018B0DE070
		public void DoOnceOnPostLayout(IAction action); // 0x000000018B0DDAAC-0x000000018B0DDB3C
		protected override void OnEnable(); // 0x000000018B0DDC5C-0x000000018B0DDCAC
		protected override void OnRectTransformDimensionsChange(); // 0x000000018B0DDCAC-0x000000018B0DDCFC
		protected override void OnDestroy(); // 0x000000018B0DDBC4-0x000000018B0DDC5C
		private void _SetDirty(); // 0x000000018B0DE070-0x000000018B0DE0FC
		private void _InvokePostLayoutCallback(); // 0x000000018B0DDDCC-0x000000018B0DDFE0
		public void __iFixBaseProxy_OnEnable(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnRectTransformDimensionsChange(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class UILeftSubtitle : TickableUIMono // TypeDefIndex: 50404
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
		protected override TickType tickOption { get; } // 0x000000018B0DE9A8-0x000000018B0DE9F8 
	
		// Constructors
		public UILeftSubtitle(); // 0x000000018B0DE914-0x000000018B0DE9A8
	
		// Methods
		public override void Tick(float deltaTime); // 0x000000018B0DE750-0x000000018B0DE808
		public void StartAutoPlay(float textStayTime); // 0x000000018B0DE6E0-0x000000018B0DE750
		public void SetLeftSubTitle(string text1, string text2, string text3, string text4); // 0x000000018B0DE1F4-0x000000018B0DE670
		public float UpdateByPlayTime(float currTime); // 0x000000018B0DE814-0x000000018B0DE914
		public void Exit(); // 0x000000018B0DE0FC-0x000000018B0DE1F4
		public void SetVisible(bool visible); // 0x000000018B0DE670-0x000000018B0DE6E0
		[CompilerGenerated]
		private void _Exit_b__17_0(); // 0x000000018B0DE808-0x000000018B0DE814
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	[ExecuteInEditMode]
	public class UIMaterialAnimation : TickableUIMono // TypeDefIndex: 50405
	{
		// Fields
		private const float FLOAT_SET_EPS = 1E-06f; // Metadata: 0x0232FD08
		private const float VECTOR_SET_EPS = 1E-06f; // Metadata: 0x0232FD0C
		private const float COLOR_SET_EPS = 1E-06f; // Metadata: 0x0232FD10
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
		private Material m_cachedMaterial; // 0x1E0
		private string m_cachedFloatName1; // 0x1E8
		private string m_cachedFloatName2; // 0x1F0
		private string m_cachedFloatName3; // 0x1F8
		private string m_cachedVectorName1; // 0x200
		private string m_cachedColorName1; // 0x208
		private float m_cachedFloatValue1; // 0x210
		private float m_cachedFloatValue2; // 0x214
		private float m_cachedFloatValue3; // 0x218
		private Vector4 m_cachedVectorValue1; // 0x21C
		private UnityEngine.Color m_cachedColorValue1; // 0x22C
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001844DA7C0-0x00000001844DA7F0 
	
		// Constructors
		public UIMaterialAnimation(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		public override void LateTick(float deltaTime); // 0x0000000183B70D30-0x0000000183B70DB0
		protected override void OnAwake(); // 0x00000001845E18D0-0x00000001845E1A90
		protected override void OnRelease(); // 0x0000000183B70C70-0x0000000183B70D30
		private void _ResetSetCache(); // 0x0000000183B71650-0x0000000183B71710
		private static bool _NearlyEqual(float left, float right); // 0x000000018B0DEA48-0x000000018B0DEA64
		private static bool _NearlyEqual(Vector4 left, Vector4 right); // 0x000000018B0D88E4-0x000000018B0D8AB4
		private static bool _NearlyEqual(UnityEngine.Color left, UnityEngine.Color right); // 0x000000018B0D88E4-0x000000018B0D8AB4
		private void _TrySetFloatCached(Material material, string propertyName, float newValue, ref string cachedPropertyName, ref float cachedValue); // 0x000000018B0DEB2C-0x000000018B0DEBC4
		private void _TrySetVectorCached(Material material, string propertyName, Vector4 newValue, ref string cachedPropertyName, ref Vector4 cachedValue); // 0x000000018B0DEBC4-0x000000018B0DEC70
		private void _TrySetColorCached(Material material, string propertyName, UnityEngine.Color newValue, ref string cachedPropertyName, ref UnityEngine.Color cachedValue); // 0x000000018B0DEA64-0x000000018B0DEB2C
		private void _TryUpdate(); // 0x0000000183B70DB0-0x0000000183B71650
		public void ForceUpdate(); // 0x000000018B0DE9F8-0x000000018B0DEA48
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	[AddComponentMenu("UI/UI Multi Select Dropdown", 103)]
	public class UIMultiSelectDropdown : Selectable, IPointerClickHandler, IUIClearable, IBindingGroupTarget, IBindingView // TypeDefIndex: 50408
	{
		// Fields
		[HideInInspector]
		public UnityEvent<int, bool> onValueChanged; // 0x188
		[HideInInspector]
		public UnityEvent<int, UIDropdownOption, bool> onUpdateCell; // 0x190
		[HideInInspector]
		public UnityEvent<int, UIMultiSelectDropdown> onUpdateCaption; // 0x198
		[FormerlySerializedAs("onToggleList")]
		[HideInInspector]
		public UnityEvent<bool> onToggleOptList; // 0x1A0
		public Func<int, bool, bool> onValidateValueChanged; // 0x1A8
		public UIText captionText; // 0x1B0
		public UIImage captionIcon; // 0x1B8
		[CompilerGenerated]
		private int _optionCount_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private int _selectedCount_k__BackingField; // 0x1C4
		[CompilerGenerated]
		private int _lastSelectedIndex_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private bool _isListActive_k__BackingField; // 0x1CC
		[SerializeField]
		private UIDropdownOption _optionTemplate; // 0x1D0
		[SerializeField]
		private Transform _arrowImageTrans; // 0x1D8
		[SerializeField]
		private RectTransform _listContainer; // 0x1E0
		[SerializeField]
		private float _listContainerMaxHeight; // 0x1E8
		[SerializeField]
		private float _animationTime; // 0x1EC
		[SerializeField]
		private RectTransform _selfArea; // 0x1F0
		[SerializeField]
		[Tooltip("\u8FD9\u91CC\u4E3A\u7A7A\u7684\u8BDD\uFF0C\u70B9\u5F00Dropdown\u65F6\u70B9\u51FB\u4EFB\u610F\u975EDropdown\u533A\u57DF\u4F1A\u6536\u8D77\uFF0C\u6709\u7684\u8BDD\u53EA\u4F1A\u54CD\u5E94mask\u533A\u57DF\u5185\u7684")]
		private RectTransform _maskRect; // 0x1F8
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
		private readonly List<UIDropdownOption> m_options; // 0x220
		private readonly List<bool> m_selectedStates; // 0x228
		private LuaPanel m_panel; // 0x230
		private LayoutGroup m_content; // 0x238
		private Camera m_fallbackUICamera; // 0x240
		private UIScrollRect m_listScrollRect; // 0x248
		private CanvasGroup m_listContainerCanvasGroup; // 0x250
		[FormerlySerializedAs("_openDropDownActionId")]
		public string openDropDownActionId; // 0x258
		public string openDropDownBindingTextId; // 0x260
		private int m_bindingGroupId; // 0x268
		private int m_naviBindingGroupId; // 0x26C
		private LuaPanel m_luaPanel; // 0x270
		private UISelectableNaviGroup m_listNaviGroup; // 0x278
		[CompilerGenerated]
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0x280
		[CompilerGenerated]
		private readonly DisposedUnityEvent _bindingViewUpdateEvent_k__BackingField; // 0x288
	
		// Properties
		public int optionCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E9A0-0x0000000184D8E9B0 0x0000000184D8EA50-0x0000000184D8EA60
		public int selectedCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E9B0-0x0000000184D8E9C0 0x0000000184D8EA60-0x0000000184D8EA70
		public int lastSelectedIndex { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DAAEE0-0x0000000184DAAEF0 0x0000000184DAAF00-0x0000000184DAAF10
		public bool isListActive { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DAAED0-0x0000000184DAAEE0 0x0000000184DAAEF0-0x0000000184DAAF00
		public LuaPanel panel { get; } // 0x000000018B0E1D08-0x000000018B0E1DCC 
		public int groupId { get; } // 0x000000018B0E1CB8-0x000000018B0E1D08 
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8DD90-0x0000000184D8DDA0 0x0000000186B8B7B0-0x0000000186B8B7C4
		public bool groupEnabled { get; } // 0x000000018B0E1C30-0x000000018B0E1CB8 
		public string bindingViewActionId { get; } // 0x000000018B0E19E8-0x000000018B0E1A38 
		public string bindingViewLabelText { get; } // 0x000000018B0E1A38-0x000000018B0E1AD0 
		public DisposedUnityEvent bindingViewUpdateEvent { [CompilerGenerated] get; } // 0x0000000184D8D820-0x0000000184D8D830 
		public RectTransform redDotTrans { get; } // 0x000000018B0E1DCC-0x000000018B0E1ED8 
		public bool bindingEnabled { get; } // 0x000000018B0E1998-0x000000018B0E19E8 
		public BindingViewState bindingViewState { get; } // 0x000000018B0E1AD0-0x000000018B0E1C30 
		bool IBindingView.interactable { get; } // 0x000000018B0DEEB4-0x000000018B0DEF04 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0 // TypeDefIndex: 50406
		{
			// Fields
			public UIMultiSelectDropdown __4__this; // 0x10
			public bool activeList; // 0x18
	
			// Constructors
			public __c__DisplayClass48_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __ToggleOptions_b__0(); // 0x000000018B0C6D88-0x000000018B0C6DCC
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0 // TypeDefIndex: 50407
		{
			// Fields
			public int index; // 0x10
			public UIMultiSelectDropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass59_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Refresh_b__0(PointerEventData evt); // 0x000000018B0E1F2C-0x000000018B0E1F84
		}
	
		// Constructors
		public UIMultiSelectDropdown(); // 0x000000018B0E16CC-0x000000018B0E1998
	
		// Methods
		protected override void Awake(); // 0x000000018B0DEC70-0x000000018B0DEE0C
		protected override void _NotifyIsHover(bool isHover); // 0x000000018B0E1008-0x000000018B0E10BC
		public void OnPointerClick(PointerEventData eventData); // 0x000000018B0DF7A8-0x000000018B0DF88C
		public void Init(UnityAction<int, UIDropdownOption, bool> onUpdateCell, UnityAction<int, bool> onValueChanged, UnityAction<int, UIMultiSelectDropdown> onUpdateCaption = null); // 0x000000018B0DF40C-0x000000018B0DF510
		public void ToggleOptions(bool activeList); // 0x000000018B0E0484-0x000000018B0E04E8
		private void _ToggleOptions(bool activeList, bool isInit); // 0x000000018B0E1190-0x000000018B0E16CC
		private void Update(); // 0x000000018B0E04E8-0x000000018B0E071C
		public void SetSelected(int index, bool isOn, bool forceUpdate = false /* Metadata: 0x0232FD14 */, bool needNotifySelect = true /* Metadata: 0x0232FD15 */, bool validateSelect = false /* Metadata: 0x0232FD16 */); // 0x000000018B0E0154-0x000000018B0E0484
		public void SetSelectedList(IEnumerable<int> indices, bool isOn, bool needNotifySelect = true /* Metadata: 0x0232FD17 */, bool validateSelect = false /* Metadata: 0x0232FD18 */); // 0x000000018B0DFF94-0x000000018B0E0154
		public void ClearSelected(bool notify = true /* Metadata: 0x0232FD19 */); // 0x000000018B0DF06C-0x000000018B0DF148
		public bool IsSelected(int index); // 0x000000018B0DF510-0x000000018B0DF5B0
		public List<int> GetSelectedIndices(); // 0x000000018B0DF208-0x000000018B0DF30C
		public List<bool> GetSelectedStates(); // 0x000000018B0DF30C-0x000000018B0DF40C
		public void ScrollToLastSelected(); // 0x000000018B0DFF38-0x000000018B0DFF94
		public void ScrollToIndex(int index); // 0x000000018B0DFDFC-0x000000018B0DFF38
		[IDTag(1)]
		public void Refresh(int count); // 0x000000018B0DFD90-0x000000018B0DFDFC
		[IDTag(0)]
		public void Refresh(int count, IEnumerable<int> selectedIndices, bool needNotifyValueChanged = true /* Metadata: 0x0232FD1A */); // 0x000000018B0DF88C-0x000000018B0DFD90
		public void ClearComponent(); // 0x000000018B0DEF04-0x000000018B0DF06C
		private bool _IsValidIndex(int index); // 0x000000018B0E0FA4-0x000000018B0E1008
		private void _ResizeSelectedStates(int count); // 0x000000018B0E10BC-0x000000018B0E1190
		private int _GetLastSelectedIndex(); // 0x000000018B0E096C-0x000000018B0E0A08
		private Camera _GetUICamera(); // 0x000000018B0E0A08-0x000000018B0E0C4C
		public string GetBindingViewActionId(BindingViewActionType actionType); // 0x000000018B0DF148-0x000000018B0DF208
		void IBindingView.OnInputKeyDown(bool isActionTrigger); // 0x000000018B0DEE0C-0x000000018B0DEE60
		void IBindingView.OnInputKeyUp(bool isActionTrigger); // 0x000000018B0DEE60-0x000000018B0DEEB4
		private void _InitBinding(); // 0x000000018B0E0C4C-0x000000018B0E0FA4
		private void _ControllerToggle(); // 0x000000018B0E0788-0x000000018B0E0800
		private void _ControllerCancel(); // 0x000000018B0E071C-0x000000018B0E0788
		private Selectable _GetDefaultNaviTarget(); // 0x000000018B0E0800-0x000000018B0E096C
		protected override void OnEnable(); // 0x000000018B0DF708-0x000000018B0DF7A8
		protected override void OnDisable(); // 0x000000018B0DF668-0x000000018B0DF708
		protected override void OnDestroy(); // 0x000000018B0DF5B0-0x000000018B0DF668
		public void __iFixBaseProxy_Awake(); // 0x000000018B0869D4-0x000000018B0869DC
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018B0C581C-0x000000018B0C5824
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0869E4-0x000000018B0869EC
		public void __iFixBaseProxy_OnDisable(); // 0x000000018447EC90-0x000000018447ECA0
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0869DC-0x000000018B0869E4
	}

	public class UINonUnifiedScrollList : UIScrollList // TypeDefIndex: 50410
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
		private const float CONTAINER_SIZE_BUFFER = 50f; // Metadata: 0x0232FD2D
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
		public override float currentStep { get; set; } // 0x000000018B0E50E0-0x000000018B0E52A4 0x000000018B0E52A4-0x000000018B0E5318
	
		// Nested types
		public enum GetCellSizeMode // TypeDefIndex: 50409
		{
			ByGetCellSizeFunc = 0,
			ByLayoutGroup = 1,
			GetAfterCellCreated = 2
		}
	
		// Constructors
		public UINonUnifiedScrollList(); // 0x00000001839C1F80-0x00000001839C2090
	
		// Methods
		protected override void InitBasicInfo(); // 0x000000018B0E3668-0x000000018B0E3730
		protected override void CalcSomeCountNum(); // 0x000000018B0E1F84-0x000000018B0E1FEC
		protected override float GetLeftLength(bool checkVertical, int checkCount = -1 /* Metadata: 0x0232FD1B */); // 0x000000018B0E2D94-0x000000018B0E2E4C
		[IDTag(0)]
		public override void UpdateCount(int newCount); // 0x000000018B0E4C30-0x000000018B0E4CA4
		[IDTag(1)]
		public override void UpdateCount(int newCount, bool setTop, bool forceRecalculate = false /* Metadata: 0x0232FD1C */, bool onlyUpdateNewCellContent = false /* Metadata: 0x0232FD1D */, bool skipGraduallyShow = false /* Metadata: 0x0232FD1E */); // 0x000000018B0E494C-0x000000018B0E4A0C
		[IDTag(2)]
		public override void UpdateCount(int newCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x0232FD1F */, bool onlyUpdateNewCellContent = false /* Metadata: 0x0232FD20 */, bool skipGraduallyShow = false /* Metadata: 0x0232FD21 */, ScrollAlignType alignType = ScrollAlignType.Top /* Metadata: 0x0232FD22 */); // 0x000000018B0E4A0C-0x000000018B0E4C30
		public override void LateTick(float deltaTime); // 0x000000018B0E3730-0x000000018B0E37AC
		protected override void OnScroll(Vector2 v); // 0x000000018B0E3978-0x000000018B0E3A00
		public static Vector2 GetGridLayoutSize(GridLayoutGroup grid, int count); // 0x000000018B0E29CC-0x000000018B0E2BAC
		private float _GetCellSize(int index); // 0x000000018B0E4D00-0x000000018B0E5008
		protected override float GetContainerSize(bool ignoreAutoLayout = false /* Metadata: 0x0232FD23 */); // 0x000000018B0E252C-0x000000018B0E29CC
		public override float GetCenterIndex(); // 0x000000018B0E22C8-0x000000018B0E252C
		public override Vector2Int GetShowRange(float bufferSize = 0f /* Metadata: 0x0232FD24 */, bool ignoreGraduallyShow = false /* Metadata: 0x0232FD28 */); // 0x000000018B0E3174-0x000000018B0E3430
		protected override Vector2Int GetNotCacheRange(); // 0x000000018B0E2F04-0x000000018B0E2FDC
		protected override void MoveCellTo(Cell cell, int index); // 0x000000018B0E37AC-0x000000018B0E38AC
		protected override void OnUpdateCell(Cell cell, int index); // 0x000000018B0E3A00-0x000000018B0E3CB4
		protected override float GetTargetPosByIndex(int index, ScrollAlignType alignType = ScrollAlignType.Top /* Metadata: 0x0232FD29 */); // 0x000000018B0E3430-0x000000018B0E3668
		private float _GetCellsSizeTo(int index); // 0x000000018B0E5008-0x000000018B0E50E0
		protected override void ScrollTo(int index, bool fastMode = false /* Metadata: 0x0232FD2A */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0232FD2B */); // 0x000000018B0E3CB4-0x000000018B0E3F80
		public override void ClearComponent(); // 0x000000018B0E1FEC-0x000000018B0E2098
		public override void SetStepTo(float step); // 0x000000018B0E4248-0x000000018B0E42BC
		public void SetCurrentStep(float currentStep); // 0x000000018B0E3F80-0x000000018B0E4180
		public float GetScrollBarSize(); // 0x000000018B0E2FDC-0x000000018B0E3174
		public float GetLastScrollStep(); // 0x000000018B0E2BAC-0x000000018B0E2D94
		public void UpdateLastScrollStep(); // 0x000000018B0E4CA4-0x000000018B0E4D00
		public float GetNormalizedPosition(); // 0x000000018B0E2E4C-0x000000018B0E2F04
		public void SetNormalizedPosition(float normalizedPosition); // 0x000000018B0E4180-0x000000018B0E4248
		public void ToggleByState(int index, bool isFoldOut, bool fastMode); // 0x000000018B0E42BC-0x000000018B0E44A0
		public void Toggle(int index, bool fastMode = false /* Metadata: 0x0232FD2C */); // 0x000000018B0E44A0-0x000000018B0E46C8
		public void FoldAll(bool isFoldOut); // 0x000000018B0E2098-0x000000018B0E22C8
		public void NotifyCellSizeChange(int index, float size); // 0x000000018B0E38AC-0x000000018B0E3978
		[CompilerGenerated]
		private void _GetScrollBarSize_g__RecalculateAverageCellSize_43_0(); // 0x000000018B0E46C8-0x000000018B0E4894
		public void __iFixBaseProxy_InitBasicInfo(); // 0x000000018B0E48BC-0x000000018B0E48C4
		public void __iFixBaseProxy_CalcSomeCountNum(); // 0x000000018B0E4894-0x000000018B0E489C
		public float __iFixBaseProxy_GetLeftLength(bool P0, int P1); // 0x000000018B0E48A4-0x000000018B0E48AC
		public void __iFixBaseProxy_UpdateCount(int P0); // 0x000000018B0E4934-0x000000018B0E493C
		public void __iFixBaseProxy_UpdateCount(int P0, bool P1, bool P2, bool P3, bool P4); // 0x000000018B0E4914-0x000000018B0E4934
		public void __iFixBaseProxy_UpdateCount(int P0, int P1, bool P2, bool P3, bool P4, ScrollAlignType P5); // 0x000000018B0E48F4-0x000000018B0E4914
		public void __iFixBaseProxy_LateTick(float P0); // 0x000000018B0E48C4-0x000000018B0E48CC
		public void __iFixBaseProxy_OnScroll(Vector2 P0); // 0x000000018B0E48CC-0x000000018B0E48D4
		public float __iFixBaseProxy_GetContainerSize(bool P0); // 0x000000018B0D2980-0x000000018B0D2988
		public float __iFixBaseProxy_GetCenterIndex(); // 0x000000018B0E489C-0x000000018B0E48A4
		public Vector2Int __iFixBaseProxy_GetShowRange(float P0, bool P1); // 0x000000018B0E48B4-0x000000018B0E48BC
		public Vector2Int __iFixBaseProxy_GetNotCacheRange(); // 0x000000018B0E48AC-0x000000018B0E48B4
		public void __iFixBaseProxy_MoveCellTo(Cell P0, int P1); // 0x000000018B0B93C4-0x000000018B0B93CC
		public void __iFixBaseProxy_OnUpdateCell(Cell P0, int P1); // 0x000000018B0E48D4-0x000000018B0E48DC
		public float __iFixBaseProxy_GetTargetPosByIndex(int P0, ScrollAlignType P1); // 0x000000018B0D2998-0x000000018B0D29A0
		public void __iFixBaseProxy_ScrollTo(int P0, bool P1, ScrollAlignType P2); // 0x000000018B0E48DC-0x000000018B0E48EC
		public void __iFixBaseProxy_ClearComponent(); // 0x000000018B0D2970-0x000000018B0D2978
		public float __iFixBaseProxy_get_currentStep(); // 0x000000018B0E493C-0x000000018B0E4944
		public void __iFixBaseProxy_set_currentStep(float P0); // 0x000000018B0E4944-0x000000018B0E494C
		public void __iFixBaseProxy_SetStepTo(float P0); // 0x000000018B0E48EC-0x000000018B0E48F4
	}

	[RequireComponent(typeof(UINonUnifiedScrollList))]
	public class UINonUnifiedScrollRect : UIScrollRect // TypeDefIndex: 50411
	{
		// Fields
		private bool m_isInited; // 0x1E0
		private bool m_isRebuilding; // 0x1E1
		private UINonUnifiedScrollList m_scrollList; // 0x1E8
		private UILayoutDimensionListener m_dimensionListener; // 0x1F0
	
		// Constructors
		public UINonUnifiedScrollRect(); // 0x0000000183EB34B0-0x0000000183EB34C0
	
		// Methods
		private void _InitIfNot(); // 0x000000018B0E56FC-0x000000018B0E5844
		protected override void UpdateScrollbars(Vector2 offset); // 0x000000018B0E5618-0x000000018B0E56FC
		public override void Rebuild(CanvasUpdate executing); // 0x000000018B0E5318-0x000000018B0E5388
		private void _UpdateNonUnifiedScrollbars(); // 0x000000018B0E58FC-0x000000018B0E5A74
		protected override void SetHorizontalNormalizedPosition(float value); // 0x000000018B0E5388-0x000000018B0E54C8
		protected override void SetVerticalNormalizedPosition(float value); // 0x000000018B0E54C8-0x000000018B0E5608
		private void _OnPostLayout(); // 0x000000018B0E5844-0x000000018B0E58FC
		public void __iFixBaseProxy_UpdateScrollbars(Vector2 P0); // 0x000000018B0E5610-0x000000018B0E5618
		public void __iFixBaseProxy_Rebuild(CanvasUpdate P0); // 0x000000018B0E5608-0x000000018B0E5610
		public void __iFixBaseProxy_SetHorizontalNormalizedPosition(float P0); // 0x0000000185397FA8-0x0000000185397FB4
		public void __iFixBaseProxy_SetVerticalNormalizedPosition(float P0); // 0x00000001853945E8-0x00000001853945F8
	}

	[ExecuteAlways]
	[RequireComponent(typeof(UIText))]
	public class UINumberScrollTween : TickableUIMono // TypeDefIndex: 50412
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
		protected override TickType tickOption { get; } // 0x000000018B0E5F60-0x000000018B0E5FB0 
		public string tweenToText { get; set; } // 0x000000018B0E5FB0-0x000000018B0E6000 0x000000018B0E60B4-0x000000018B0E6118
		public string text { get; set; } // 0x000000018B0E5EAC-0x000000018B0E5F60 0x000000018B0E6000-0x000000018B0E60B4
	
		// Constructors
		public UINumberScrollTween(); // 0x000000018B0E5E60-0x000000018B0E5EAC
	
		// Methods
		private void Start(); // 0x000000018B0E5A74-0x000000018B0E5B04
		public override void Tick(float deltaTime); // 0x000000018B0E5B04-0x000000018B0E5BD4
		private void _TweenToTarget(string targetText); // 0x000000018B0E5D5C-0x000000018B0E5E60
		private void _CleanupBeforeTween(); // 0x000000018B0E5BD4-0x000000018B0E5C24
		private void _HandleNumberScrollTween(float fromNumber, float toNumber, float curTime); // 0x000000018B0E5C24-0x000000018B0E5D5C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class UIPCScaleHelper : MonoBehaviour // TypeDefIndex: 50413
	{
		// Fields
		public Vector3 baseScale; // 0x18
	
		// Constructors
		public UIPCScaleHelper(); // 0x00000001848AC930-0x00000001848AC970
	
		// Methods
		private void OnEnable(); // 0x00000001847009D0-0x0000000184700AD0
	}

	[AddComponentMenu("UI/UI Raw Image", 12)]
	public class UIRawImage : RawImage // TypeDefIndex: 50414
	{
		// Constructors
		public UIRawImage(); // 0x00000001839C4AF0-0x00000001839C4B00
	}

	[ExecuteInEditMode]
	public class UIRegionBuildingTexManager : MonoBehaviour // TypeDefIndex: 50415
	{
		// Fields
		[SerializeField]
		private Shader _regionMapShader; // 0x18
		public Texture2D minimapOutlineTex; // 0x20
		private static int s_buildingOutlineTex; // 0x00
		private Renderer m_meshRenderer; // 0x28
		private static MaterialPropertyBlock s_materialPropertyBlock; // 0x08
	
		// Properties
		private static MaterialPropertyBlock materialPropertyBlock { get; } // 0x0000000183521DE0-0x0000000183521EE0 
	
		// Constructors
		public UIRegionBuildingTexManager(); // 0x0000000183695570-0x0000000183695590
		static UIRegionBuildingTexManager(); // 0x0000000184D54AD0-0x0000000184D54B20
	
		// Methods
		private void OnEnable(); // 0x0000000183521990-0x0000000183521BF0
		private void OnValidate(); // 0x000000018B0E6118-0x000000018B0E6208
		private void OnDisable(); // 0x00000001846AA5F0-0x00000001846AA6C0
		private void _UpdateTexture(Renderer meshRenderer, Shader minimapTerrainShader, Texture2D buildingTex); // 0x0000000183521BF0-0x0000000183521DE0
	}

	public class UIScaleHolder : TickableUIMono // TypeDefIndex: 50416
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
		protected override TickType tickOption { get; } // 0x0000000183E63EE0-0x0000000183E63F50 
	
		// Constructors
		public UIScaleHolder(); // 0x00000001839C47A0-0x00000001839C47D0
	
		// Methods
		protected override void OnAwake(); // 0x00000001831E77C0-0x00000001831E7A40
		protected override void OnEnable(); // 0x00000001833EF340-0x00000001833EF380
		public override void LateTick(float deltaTime); // 0x00000001833F0D30-0x00000001833F0DD0
		private bool _IsValidScale(Vector3 scale); // 0x00000001833F1190-0x00000001833F1220
		private void _HoldScale(); // 0x00000001833F0DD0-0x00000001833F1190
		public void SetExtraScale(Vector3 extraScale); // 0x000000018B0E6208-0x000000018B0E628C
		public Vector3 GetExtraScale(); // 0x00000001840E36B0-0x00000001840E3700
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	[AddComponentMenu("UI/UI Scrollbar", 36)]
	public class UIScrollbar : Scrollbar // TypeDefIndex: 50417
	{
		// Constructors
		public UIScrollbar(); // 0x000000018453A540-0x000000018453A550
	
		// Methods
		protected override void Awake(); // 0x0000000184D2B9F0-0x0000000184D2BA30
		public void __iFixBaseProxy_Awake(); // 0x000000018B0869D4-0x000000018B0869DC
	}

	public class UIScrollbarKeyHint : TickableUIMono // TypeDefIndex: 50418
	{
		// Fields
		private UIScrollRect m_scrollRect; // 0x68
		private UIImage m_image; // 0x70
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B0ECD3C-0x000000018B0ECE0C 
	
		// Constructors
		public UIScrollbarKeyHint(); // 0x00000001839C2B00-0x00000001839C2B10
	
		// Methods
		protected override void OnAwake(); // 0x000000018B0ECB70-0x000000018B0ECC20
		public override void Tick(float deltaTime); // 0x000000018B0ECC20-0x000000018B0ECD3C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class UIScrollCircle : TickableUIMono, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, ICanvasElement, IUIClearable // TypeDefIndex: 50420
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
		[CompilerGenerated]
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
		protected override TickType tickOption { get; } // 0x000000018B0E812C-0x000000018B0E817C 
		public float elasticity { get; set; } // 0x000000018B0E8014-0x000000018B0E8068 0x000000018B0E8308-0x000000018B0E8368
		public int count { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86890-0x0000000184D868A0 0x0000000184D868C0-0x0000000184D868D0
		public float velocity { get; set; } // 0x000000018B0E817C-0x000000018B0E81D0 0x000000018B0E8368-0x000000018B0E83C8
		public LuaPanel panel { get; } // 0x000000018B0E8068-0x000000018B0E812C 
		protected RectTransform viewRect { get; } // 0x000000018B0E81D0-0x000000018B0E8308 
		Transform ICanvasElement.transform { get; } // 0x000000018B0E6DC0-0x000000018B0E6E10 
	
		// Nested types
		public class Cell // TypeDefIndex: 50419
		{
			// Fields
			public GameObject gameObject; // 0x10
			public RectTransform rectTransform; // 0x18
			public GameObject realGameObject; // 0x20
	
			// Constructors
			public Cell(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			public void SetSelect(bool select); // 0x000000018B0E1ED8-0x000000018B0E1F2C
		}
	
		// Constructors
		public UIScrollCircle(); // 0x000000018B0E7E9C-0x000000018B0E8014
	
		// Methods
		public void OnInitializePotentialDrag(PointerEventData eventData); // 0x000000018B0E6AD8-0x000000018B0E6B44
		public virtual bool IsActive(); // 0x000000018B0E63EC-0x000000018B0E643C
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018B0E65D0-0x000000018B0E6730
		public void OnEndDrag(PointerEventData eventData); // 0x000000018B0E6A6C-0x000000018B0E6AD8
		public void OnDrag(PointerEventData eventData); // 0x000000018B0E6788-0x000000018B0E69E8
		private void _UpdateSpeed(); // 0x000000018B0E7DE4-0x000000018B0E7E9C
		private bool _CheckCanMove(float deltaAngle); // 0x000000018B0E6ECC-0x000000018B0E6F50
		private void _TryUpdateCells(); // 0x000000018B0E7824-0x000000018B0E78A8
		private void _UpdateAuto(); // 0x000000018B0E78A8-0x000000018B0E7A1C
		protected override void OnRelease(); // 0x000000018B0E6B44-0x000000018B0E6BB4
		private float _GetDeltaAngle(Vector2 position); // 0x000000018B0E7134-0x000000018B0E72FC
		private void _InitCells(); // 0x000000018B0E7370-0x000000018B0E761C
		private void _Init(); // 0x000000018B0E761C-0x000000018B0E7710
		private void _OnAwakeInit(); // 0x000000018B0E7710-0x000000018B0E7824
		private void _UpdateScrollRange(); // 0x000000018B0E7B9C-0x000000018B0E7C04
		private int _GetRealIndex(int index); // 0x000000018B0E72FC-0x000000018B0E7370
		private void _UpdateShowingCells(); // 0x000000018B0E7C04-0x000000018B0E7DE4
		private void _UpdateCenterIndex(bool forceUpdate = false /* Metadata: 0x0232FD34 */); // 0x000000018B0E7A1C-0x000000018B0E7B9C
		private void _DoScroll(float tmpAngle, bool direct = false /* Metadata: 0x0232FD35 */); // 0x000000018B0E6F50-0x000000018B0E7134
		public void OnScroll(PointerEventData eventData); // 0x000000018B0E6BB4-0x000000018B0E6C08
		public void Rebuild(CanvasUpdate executing); // 0x000000018B0E6C08-0x000000018B0E6C5C
		public void LayoutComplete(); // 0x000000018B0E6530-0x000000018B0E6574
		public void GraphicUpdateComplete(); // 0x000000018B0E63A8-0x000000018B0E63EC
		public bool IsDestroyed(); // 0x000000018B0E643C-0x000000018B0E64BC
		protected override void OnEnable(); // 0x000000018B0E69E8-0x000000018B0E6A6C
		protected override void OnDisable(); // 0x000000018B0E6730-0x000000018B0E6788
		protected void Start(); // 0x000000018B0E6D58-0x000000018B0E6DA8
		protected override void OnAwake(); // 0x000000018B0E6574-0x000000018B0E65D0
		public override void LateTick(float deltaTime); // 0x000000018B0E64BC-0x000000018B0E6530
		public void UpdateCount(int newCount, bool setTop = true /* Metadata: 0x0232FD36 */); // 0x000000018B0E6E10-0x000000018B0E6ECC
		public void ScrollToIndex(int index, bool direct = false /* Metadata: 0x0232FD37 */); // 0x000000018B0E6C5C-0x000000018B0E6D58
		public GameObject Get(int index); // 0x000000018B0E62FC-0x000000018B0E63A8
		public void ClearComponent(); // 0x000000018B0E628C-0x000000018B0E62FC
		[CompilerGenerated]
		private void __DoScroll_b__59_0(); // 0x000000018B0E6DA8-0x000000018B0E6DC0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class UIScrollContainerFollower : TickableUIMono // TypeDefIndex: 50421
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
		protected override TickType tickOption { get; } // 0x000000018B0E8BDC-0x000000018B0E8C2C 
	
		// Constructors
		public UIScrollContainerFollower(); // 0x0000000184D26580-0x0000000184D265A0
	
		// Methods
		protected override void OnAwake(); // 0x000000018B0E8768-0x000000018B0E8850
		public override void LateTick(float deltaTime); // 0x000000018B0E83C8-0x000000018B0E8768
		private void _RefreshSizeAndPositionToTargetContainer(); // 0x000000018B0E8850-0x000000018B0E8BDC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public enum ScrollDirection // TypeDefIndex: 50422
	{
		Vertical = 0,
		Horizontal = 1
	}

	[ExecuteInEditMode]
	public class UIScrollList : TickableUIMono, IBeginDragHandler, IDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 50429
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
		protected bool _hideRayCastWhenLessThanOnePage; // 0xE0
		[SerializeField]
		protected bool _clampWhenLessThanOnePage; // 0xE1
		protected ScrollRect.MovementType m_lastScrollRectMovementType; // 0xE4
		[SerializeField]
		[Space]
		protected RectTransform _container; // 0xE8
		[SerializeField]
		protected UIScrollRect _scrollRect; // 0xF0
		[CompilerGenerated]
		private int _count_k__BackingField; // 0xF8
		[CompilerGenerated]
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
		private const string CACHED_CELL_GAME_OBJECT_NAME = "Cached"; // Metadata: 0x0232FD56
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
		protected bool _enableGraduallyShow; // 0x210
		[SerializeField]
		private float _graduallyShowTime; // 0x214
		[SerializeField]
		private float _graduallyShowDelayTime; // 0x218
		protected bool m_inGraduallyShow; // 0x21C
		protected float m_graduallyShowedMaxIndex; // 0x220
		protected float m_curGraduallyCanShowMaxIndex; // 0x224
		private bool m_needInformAnimationInEnd; // 0x228
		private const float GRADUALLY_SHOW_UPDATE_MAX_INTERVAL = 0.033333335f; // Metadata: 0x0232FD5D
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
		protected override TickType tickOption { get; } // 0x00000001847513C0-0x00000001847513F0 
		public Vector2 space { get; } // 0x00000001848AC4B0-0x00000001848AC4F0 
		public bool autoLayoutWhenFew { get; } // 0x000000018B0EC790-0x000000018B0EC7E0 
		public bool isHorizontal { get; } // 0x000000018396EF60-0x000000018396EF90 
		public bool isVertical { get; } // 0x000000018396EF30-0x000000018396EF60 
		public int count { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x0000000184DA61F0-0x0000000184DA6200 0x0000000184DA6220-0x0000000184DA6230
		public float containerSizeWithoutAutoLayout { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8E1A0-0x0000000184D8E1B0 0x0000000184D8E1F0-0x0000000184D8E200
		protected virtual bool isMultiPage { get; } // 0x000000018436E810-0x000000018436E850 
		public int maxShowingCellCount { get; } // 0x00000001836F3780-0x00000001836F37B0 
		public int countPerLine { get; } // 0x000000018B0EC888-0x000000018B0EC8D8 
		public float cellWidth { get; } // 0x000000018B0EC834-0x000000018B0EC888 
		public float cellHeight { get; } // 0x000000018B0EC7E0-0x000000018B0EC834 
		public virtual float currentStep { get; set; } // 0x000000018396E250-0x000000018396E370 0x000000018B0ECAEC-0x000000018B0ECB70
		private MoveTipsType moveTips { get; } // 0x000000018396E910-0x000000018396EAB0 
		public int curSelectedIndex { get; protected set; } // 0x000000018B0EC8D8-0x000000018B0EC944 0x000000018B0ECA44-0x000000018B0ECAEC
		public GameObject curSelectedObj { get; } // 0x000000018B0EC944-0x000000018B0EC9A4 
		public bool enableSelectedNavigation { get; } // 0x000000018B0EC9A4-0x000000018B0EC9F4 
		public int naviBindingGroupId { get; } // 0x000000018B0EC9F4-0x000000018B0ECA44 
		public LuaPanel panel { get; } // 0x0000000183972670-0x0000000183972720 
	
		// Nested types
		protected enum AutoLayoutWhenFewType // TypeDefIndex: 50423
		{
			Center = 0,
			LeftOrTop = 1,
			RightOrBottom = 2
		}
	
		public class Cell // TypeDefIndex: 50424
		{
			// Fields
			public GameObject gameObject; // 0x10
			public RectTransform rectTransform; // 0x18
			public UIAnimationWrapper animationWrapper; // 0x20
			public IUIFoldoutComp UIFoldoutComp; // 0x28
			public bool canCache; // 0x30
			public GameObject realGameObject; // 0x38
	
			// Constructors
			public Cell(); // 0x0000000184D8D3B0-0x0000000184D8D3C0
		}
	
		private enum MoveTipsType // TypeDefIndex: 50425
		{
			None = 0,
			Higher = 1,
			Lower = 2,
			Both = 3
		}
	
		[Serializable]
		public struct Padding // TypeDefIndex: 50426
		{
			// Fields
			public float top; // 0x00
			public float left; // 0x04
			public float right; // 0x08
			public float bottom; // 0x0C
		}
	
		public enum ScrollAlignType // TypeDefIndex: 50427
		{
			Center = 0,
			Top = 1,
			Bottom = 2
		}
	
		public interface IScrollListNaviWrapper // TypeDefIndex: 50428
		{
			// Methods
			bool TryWrapNavigate(NaviDirection dir);
		}
	
		// Constructors
		public UIScrollList(); // 0x00000001839C2EA0-0x00000001839C32A0
		static UIScrollList(); // 0x0000000184CEC340-0x0000000184CEC3F0
	
		// Methods
		protected override void OnAwake(); // 0x0000000184B3A230-0x0000000184B3A270
		public override void Tick(float deltaTime); // 0x00000001836F3530-0x00000001836F35C0
		public override void LateTick(float deltaTime); // 0x0000000183E31E80-0x0000000183E31ED0
		protected override void OnEnable(); // 0x00000001836F3890-0x00000001836F3940
		protected override void OnDisable(); // 0x0000000183972440-0x0000000183972560
		public void TryRecalculateSize(); // 0x0000000183E31ED0-0x0000000183E31FB0
		protected virtual void InGameAwake(); // 0x00000001839D0BE0-0x00000001839D0D90
		private void _EditorAwake(); // 0x000000018B0EBC74-0x000000018B0EC194
		protected virtual void Init(bool isPreview = false /* Metadata: 0x0232FD3A */); // 0x0000000183970500-0x0000000183970720
		protected virtual void InitConfig(); // 0x0000000183970320-0x0000000183970440
		protected virtual void InitBasicInfo(); // 0x0000000184B83790-0x0000000184B837D0
		protected virtual void SyncViewSize(); // 0x0000000184553710-0x0000000184553970
		protected virtual void CalcSomeCountNum(); // 0x000000018396D350-0x000000018396D3E0
		private int _GetLineCount(bool calcVertical); // 0x000000018396D3E0-0x000000018396D490
		protected virtual void OnScroll(Vector2 v); // 0x000000018396E1E0-0x000000018396E250
		public virtual void SetTop(bool needUpdate = true /* Metadata: 0x0232FD3B */); // 0x000000018B0EAB64-0x000000018B0EAC2C
		[IDTag(1)]
		public virtual void UpdateCount(int newCount, bool setTop, bool forceRecalculate = false /* Metadata: 0x0232FD3C */, bool onlyUpdateNewCellContent = false /* Metadata: 0x0232FD3D */, bool skipGraduallyShow = false /* Metadata: 0x0232FD3E */); // 0x000000018396CCC0-0x000000018396CD50
		[IDTag(0)]
		public virtual void UpdateCount(int newCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x0232FD3F */, bool onlyUpdateNewCellContent = false /* Metadata: 0x0232FD40 */, bool skipGraduallyShow = false /* Metadata: 0x0232FD41 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0232FD42 */); // 0x000000018396CD50-0x000000018396CFA0
		[IDTag(2)]
		public virtual void UpdateCount(int newCount); // 0x0000000184D3EA10-0x0000000184D3EA70
		[IDTag(1)]
		public void UpdateShowingCells(Action<int, GameObject> updateFunc); // 0x000000018B0EBA08-0x000000018B0EBBB8
		protected virtual float GetLeftLength(bool checkVertical, int checkCount = -1 /* Metadata: 0x0232FD43 */); // 0x0000000183970440-0x0000000183970500
		private void _SetRealPadding(bool isVerticalPadding, float firstAddedLength, float secondAddedLength); // 0x0000000183970290-0x0000000183970320
		protected virtual void UpdateContainerSize(); // 0x0000000183970070-0x0000000183970290
		protected virtual float GetContainerSize(bool ignoreAutoLayout = false /* Metadata: 0x0232FD44 */); // 0x000000018396E0B0-0x000000018396E1E0
		protected void SetContainerSize(float size); // 0x000000018396DF80-0x000000018396E0B0
		protected virtual void ClearShowingCells(); // 0x00000001845F1AC0-0x00000001845F1E60
		[IDTag(0)]
		protected virtual void UpdateShowingCells(bool forceUpdateContent, bool forceClearShowingCells = false /* Metadata: 0x0232FD45 */, bool ignoreListActive = false /* Metadata: 0x0232FD46 */); // 0x000000018396E370-0x000000018396E470
		protected virtual void CacheOutOfRangeCells(Vector2Int showRange, Vector2Int notCacheRange); // 0x000000018396F610-0x000000018396FA90
		protected virtual void ProcessCellAtIndex(int index, bool forceUpdateContent, bool ignoreListActive); // 0x000000018396E5E0-0x000000018396E650
		protected virtual void RepositionOutOfRangeCells(Vector2Int showRange); // 0x000000018396F410-0x000000018396F610
		protected void UpdateCell(int index, bool forceUpdateContent, bool ignoreListActive); // 0x000000018396E650-0x000000018396E910
		public virtual Vector2Int GetShowRange(float bufferSize = 0f /* Metadata: 0x0232FD47 */, bool ignoreGraduallyShow = false /* Metadata: 0x0232FD4B */); // 0x000000018396EAB0-0x000000018396EC80
		protected virtual Vector2Int GetIndexRangeFromScrollOffset(float scrollOffset, float viewSize, float bufferSize); // 0x000000018396EDA0-0x000000018396EF30
		public virtual Vector2Int GetRangeInView(); // 0x000000018B0E9410-0x000000018B0E98C4
		protected virtual Vector2Int GetNotCacheRange(); // 0x000000018396E470-0x000000018396E4B0
		protected virtual void MoveCellTo(Cell cell, int index); // 0x000000018396EC80-0x000000018396EDA0
		public void SetCellCanCache(int index, bool canCache); // 0x000000018B0EA1B0-0x000000018B0EA2DC
		protected virtual void OnUpdateCell(Cell cell, int index); // 0x00000001846BAFA0-0x00000001846BB020
		[IDTag(0)]
		protected Cell GetCell(); // 0x000000018396CFE0-0x000000018396D350
		protected void CacheShowingCell(int index); // 0x000000018B0E8C2C-0x000000018B0E8CFC
		protected void CacheCell(Cell cell); // 0x00000001845F1E60-0x00000001845F1EE0
		public virtual void SetStepTo(float step); // 0x000000018B0EA904-0x000000018B0EAB64
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x000000018B0E9C9C-0x000000018B0E9D04
		public virtual void OnDrag(PointerEventData eventData); // 0x000000018B0E9D04-0x000000018B0E9D90
		public virtual void OnEndDrag(PointerEventData eventData); // 0x000000018B0E9D90-0x000000018B0E9DF8
		protected void UpdateMoveTips(); // 0x000000018396E4B0-0x000000018396E5E0
		public void UpdateViewEffect(); // 0x000000018396FA90-0x0000000183970070
		public GameObject Get(int index); // 0x000000018B0E9A00-0x000000018B0E9AA8
		[IDTag(1)]
		protected Cell GetCell(int index); // 0x000000018B0E8CFC-0x000000018B0E8DB4
		protected int GetRealIndex(int index); // 0x000000018396CFA0-0x000000018396CFE0
		protected override void OnRelease(); // 0x00000001839729B0-0x0000000183972A70
		public virtual void ClearComponent(); // 0x00000001846926D0-0x0000000184692830
		public void SetPaddingBottom(float value); // 0x000000018B0EA2DC-0x000000018B0EA358
		public void SetPaddingTop(float value); // 0x000000018B0EA450-0x000000018B0EA4CC
		public void SetPaddingRight(float value); // 0x000000018B0EA3D4-0x000000018B0EA450
		public void SetPaddingLeft(float value); // 0x000000018B0EA358-0x000000018B0EA3D4
		public void SetPadding(Rect value); // 0x000000018B0EA4CC-0x000000018B0EA5C4
		public Padding GetPadding(bool isRealPadding = false /* Metadata: 0x0232FD4C */); // 0x000000018481B180-0x000000018481B1E0
		public void GetShowingCellsIndexRange(out int firstIndex, out int lastIndex); // 0x000000018B0E98C4-0x000000018B0E9A00
		public void SetSpace(Vector2 newSpace); // 0x000000018B0EA848-0x000000018B0EA904
		public virtual void ScrollToIndex(int index, bool fastMode = false /* Metadata: 0x0232FD4D */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0232FD4E */, bool graduallyShowInFastMode = false /* Metadata: 0x0232FD4F */); // 0x000000018B0EA0BC-0x000000018B0EA1B0
		protected virtual void ScrollTo(int index, bool fastMode = false /* Metadata: 0x0232FD50 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0232FD51 */); // 0x00000001839708B0-0x0000000183970920
		private void _ScrollToPos(float targetPos, bool fastMode); // 0x0000000183970720-0x00000001839708B0
		protected void TryClearAdjustTween(); // 0x00000001839723E0-0x0000000183972440
		public virtual float GetCenterIndex(); // 0x000000018396D610-0x000000018396DF80
		protected virtual float GetTargetPosByIndex(int index, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0232FD52 */); // 0x0000000183970920-0x0000000183971780
		private void _InitAutoScroll(); // 0x00000001839D0640-0x00000001839D07D0
		private void _OnEnterAutoScrollUp(PointerEventData eventData); // 0x000000018B0EC4B8-0x000000018B0EC5E0
		private void _OnExitAutoScrollUp(PointerEventData eventData); // 0x000000018B0EC684-0x000000018B0EC728
		private void _OnEnterAutoScrollDown(PointerEventData eventData); // 0x000000018B0EC390-0x000000018B0EC4B8
		private void _OnExitAutoScrollDown(PointerEventData eventData); // 0x000000018B0EC5E0-0x000000018B0EC684
		private void _SetAutoScrollSpd(float spd); // 0x000000018B0EC728-0x000000018B0EC790
		private void _UpdateAutoScroll(float deltaTime); // 0x00000001836F35C0-0x00000001836F3620
		protected void RestartGraduallyShow(); // 0x000000018B0E9DF8-0x000000018B0E9EA0
		protected void StartGraduallyShow(); // 0x0000000183972560-0x0000000183972670
		private void _UpdateGraduallyShow(float deltaTime); // 0x00000001836F3620-0x00000001836F3780
		public void SkipGraduallyShow(); // 0x000000018B0EAC2C-0x000000018B0EAC88
		public void StopGraduallyShow(); // 0x0000000183972720-0x0000000183972890
		private void _InitNavigation(); // 0x00000001839D07D0-0x00000001839D0960
		public void NavigateSelected(NaviDirection dir); // 0x000000018B0E9C04-0x000000018B0E9C9C
		public int GetNaviOffset(NaviDirection dir); // 0x000000018B0E92AC-0x000000018B0E9410
		public int GetNaviNewIndex(int oldIndex, NaviDirection dir); // 0x000000018B0E9208-0x000000018B0E92AC
		public void SetSelectedIndex(int index, bool needNotify = true /* Metadata: 0x0232FD53 */, bool forceUpdate = false /* Metadata: 0x0232FD54 */, bool needScroll = false /* Metadata: 0x0232FD55 */); // 0x000000018B0EA5C4-0x000000018B0EA848
		public virtual void ListWrapNavigate(NaviDirection dir); // 0x000000018B0E9AA8-0x000000018B0E9C04
		protected virtual bool TryResolveWrapDirection(NaviDirection dir, out bool isBefore); // 0x000000018B0EB684-0x000000018B0EB798
		protected bool TryGetCurrentFocusedCell(out int currentIndex, out Cell currentCell); // 0x000000018B0EAC88-0x000000018B0EAF74
		protected bool TryNavigateInsideCell(Cell cell, NaviDirection dir); // 0x000000018B0EB4D4-0x000000018B0EB5C0
		protected virtual bool TryGetWrapTargetIndex(NaviDirection dir, int currentIndex, bool isBefore, out int targetIndex); // 0x000000018B0EB324-0x000000018B0EB3B0
		protected bool TrySetNaviTargetByIndex(int index, bool isBefore); // 0x000000018B0EB798-0x000000018B0EB8CC
		protected bool TryGetSelectableFromCell(Cell cell, bool isBefore, out Selectable selectable); // 0x000000018B0EAF74-0x000000018B0EB324
		private static bool _IsValidWrapNaviTarget(Selectable selectable); // 0x0000000182E97340-0x0000000182E976D0
		protected bool TryNormalizeFirstWrapIndex(ref int nextIndex, bool isBefore); // 0x000000018B0EB5C0-0x000000018B0EB684
		protected bool TryNavigateBySequentialIndex(int startIndex, bool isBefore); // 0x000000018B0EB3B0-0x000000018B0EB4D4
		public int GetNaviManagerTargetIndex(); // 0x000000018B0E8F08-0x000000018B0E9208
		private void _InitControllerNavi(); // 0x00000001839D0960-0x00000001839D09D0
		private void _ClearRelatedNaviGroup(); // 0x000000018B0EBBB8-0x000000018B0EBC74
		public int GetMousePosIndex(NaviDirection dir); // 0x000000018B0E8E3C-0x000000018B0E8F08
		public int ScreenPos2Index(Vector2 targetScreenPos, NaviDirection dir); // 0x000000018B0E9EA0-0x000000018B0EA0BC
		private void _GetScreenPosLineColumnInfo(Vector2 targetScreenPos, out int line, out int column); // 0x000000018B0EC194-0x000000018B0EC390
		public int GetIndexOf(int column, int line); // 0x000000018B0E8DB4-0x000000018B0E8E3C
		[CompilerGenerated]
		private float __ScrollToPos_b__162_0(); // 0x000000018B0EB934-0x000000018B0EB958
		[CompilerGenerated]
		private void __ScrollToPos_b__162_1(float x); // 0x000000018B0EB958-0x000000018B0EB980
		[CompilerGenerated]
		private void __ScrollToPos_b__162_2(); // 0x000000018B0EB980-0x000000018B0EB9BC
		[CompilerGenerated]
		private float __ScrollToPos_b__162_3(); // 0x000000018B0EB9BC-0x000000018B0EB9E0
		[CompilerGenerated]
		private void __ScrollToPos_b__162_4(float y); // 0x000000018B0EB9E0-0x000000018B0EBA08
		[CompilerGenerated]
		private void __ScrollToPos_b__162_5(); // 0x000000018B0EB980-0x000000018B0EB9BC
		[CompilerGenerated]
		private void __OnEnterAutoScrollUp_b__175_0(); // 0x000000018B0EB91C-0x000000018B0EB934
		[CompilerGenerated]
		private void __OnEnterAutoScrollDown_b__177_0(); // 0x000000018B0EB90C-0x000000018B0EB91C
		[CompilerGenerated]
		private void __InitNavigation_b__216_0(); // 0x000000018B0EB8CC-0x000000018B0EB8DC
		[CompilerGenerated]
		private void __InitNavigation_b__216_1(); // 0x000000018B0EB8DC-0x000000018B0EB8EC
		[CompilerGenerated]
		private void __InitNavigation_b__216_2(); // 0x000000018B0EB8EC-0x000000018B0EB8FC
		[CompilerGenerated]
		private void __InitNavigation_b__216_3(); // 0x000000018B0EB8FC-0x000000018B0EB90C
		[CompilerGenerated]
		private void __InitNavigation_b__216_4(); // 0x000000018B0EB8EC-0x000000018B0EB8FC
		[CompilerGenerated]
		private void __InitNavigation_b__216_5(); // 0x000000018B0EB8FC-0x000000018B0EB90C
		[CompilerGenerated]
		private void __InitNavigation_b__216_6(); // 0x000000018B0EB8CC-0x000000018B0EB8DC
		[CompilerGenerated]
		private void __InitNavigation_b__216_7(); // 0x000000018B0EB8DC-0x000000018B0EB8EC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	public enum AutoScrollStrategy // TypeDefIndex: 50430
	{
		None = 0,
		AlignNearbyBound = 1,
		AlignCenter = 2
	}

	[AddComponentMenu("UI/UI Scroll Rect", 37)]
	public class UIScrollRect : ScrollRect, IUIClearable // TypeDefIndex: 50433
	{
		// Fields
		private TweenerCore<Vector2, Vector2, VectorOptions> m_scrollTween; // 0x150
		public float smoothScrollTweenSpd; // 0x158
		public Ease smoothScrollTweenEase; // 0x15C
		public float smoothScrollTweenMaxDur; // 0x160
		private bool m_lastUpdateIsDragging; // 0x164
		private LuaPanel m_panel; // 0x168
		[SerializeField]
		protected bool _useLeftStick; // 0x170
		[SerializeField]
		protected float _stickScrollSpeed; // 0x174
		[SerializeField]
		protected float _stickScrollTolerance; // 0x178
		[SerializeField]
		protected UISelectableNaviGroup _naviGroup; // 0x180
		[SerializeField]
		protected bool _enableWrapNavigation; // 0x188
		[SerializeField]
		protected InputBindingGroupMonoTarget _scrollBindingGroup; // 0x190
		[NonSerialized]
		public bool controllerScrollEnabled; // 0x198
		private bool m_controllerInited; // 0x199
		private bool m_navigationWrapped; // 0x19A
		[SerializeField]
		protected AutoScrollStrategy _autoScrollStrategy; // 0x19C
		[SerializeField]
		protected float _alignBoundPaddingX; // 0x1A0
		[SerializeField]
		protected float _alignBoundPaddingY; // 0x1A4
		[SerializeField]
		[Space]
		private GameObject _moveTipsLeftOrTop; // 0x1A8
		[SerializeField]
		private GameObject _moveTipsRightOrBottom; // 0x1B0
		private Camera m_fallbackUICamera; // 0x1B8
		[Header("Over Scroll Effect")]
		[SerializeField]
		private bool _enableOverScrollEffect; // 0x1C0
		[SerializeField]
		[Tooltip("\u5217\u8868\u957F\u5EA6\u7684\u767E\u5206\u6BD4")]
		private float _overScrollTriggerValue; // 0x1C4
		[SerializeField]
		private GameObject _overScrollEffectPrevNode; // 0x1C8
		[SerializeField]
		private GameObject _overScrollEffectNextNode; // 0x1D0
		[NonSerialized]
		public DisposedUnityEvent<bool> onOverScrollEffect; // 0x1D8
	
		// Properties
		public bool inScrollTween { get; } // 0x000000018B0F19DC-0x000000018B0F1A50 
		public Vector2 contentStartPosition { get; set; } // 0x000000018B0F187C-0x000000018B0F18E0 0x000000018B0F1CA4-0x000000018B0F1D08
		public bool dragging { get; } // 0x000000018B0F198C-0x000000018B0F19DC 
		public bool controllerStickScrollEnabled { get; } // 0x000000018B0F18E0-0x000000018B0F198C 
		public LuaPanel panel { get; } // 0x000000018B0F1BE0-0x000000018B0F1CA4 
		public UISelectableNaviGroup naviGroup { get; } // 0x000000018B0F1B90-0x000000018B0F1BE0 
		private MoveTipsType moveTips { get; } // 0x000000018B0F1A50-0x000000018B0F1B90 
	
		// Nested types
		private enum MoveTipsType // TypeDefIndex: 50431
		{
			None = 0,
			Higher = 1,
			Lower = 2,
			Both = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 50432
		{
			// Fields
			public Vector2 contentPos; // 0x10
			public UIScrollRect __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal Vector2 __CustomSetPosOnScroll_b__0(); // 0x0000000184D95390-0x0000000184D953B0
			internal void __CustomSetPosOnScroll_b__1(Vector2 pos); // 0x000000018B0EE260-0x000000018B0EE2A0
		}
	
		// Constructors
		public UIScrollRect(); // 0x0000000183EB2AA0-0x0000000183EB2B60
	
		// Methods
		protected override void Awake(); // 0x00000001839D2680-0x00000001839D2760
		protected override void OnEnable(); // 0x00000001839D39B0-0x00000001839D39F0
		private void Update(); // 0x0000000183C94D90-0x0000000183C94E20
		public void ScrollTo(Vector2 position, bool noTween = false /* Metadata: 0x0232FD6E */); // 0x0000000183972230-0x00000001839722A0
		public void KillScrollTween(); // 0x00000001839722A0-0x00000001839722E0
		public bool IsCellViewed(RectTransform cell); // 0x000000018B0F05BC-0x000000018B0F06A8
		public void ClampContentToBounds(); // 0x000000018B0F0490-0x000000018B0F05BC
		protected override void OnDestroy(); // 0x0000000184A1C730-0x0000000184A1C780
		protected override void _CustomSetPosOnScroll(Vector2 position); // 0x000000018B0F0F04-0x000000018B0F1638
		protected override void UpdateScrollEnableNode(); // 0x0000000183E0B630-0x0000000183E0B730
		public override void OnBeginDrag(PointerEventData eventData); // 0x000000018B0F06A8-0x000000018B0F0738
		public override void OnDrag(PointerEventData eventData); // 0x000000018B0F0738-0x000000018B0F07C8
		public override void OnEndDrag(PointerEventData eventData); // 0x000000018B0F07C8-0x000000018B0F0870
		public void ClearComponent(); // 0x00000001839CFC90-0x00000001839CFD30
		protected override void LateUpdate(); // 0x00000001833F6770-0x00000001833F6850
		private void _TickRefreshControllerStickScroll(); // 0x0000000183C94E20-0x0000000183C94EE0
		public void ScrollToNaviTarget(Selectable target); // 0x00000001844013B0-0x00000001844014B0
		public void RectWrapNavigate(NaviDirection dir); // 0x000000018B0F0870-0x000000018B0F0B0C
		private void _InitController(); // 0x00000001839D3CD0-0x00000001839D3E40
		public void WrapNavigation(UnityAction<NaviDirection> wrapper); // 0x000000018B0F0B44-0x000000018B0F0D28
		public void AutoScrollToRectTransform(RectTransform target, bool noTween = false /* Metadata: 0x0232FD6F */); // 0x00000001844014B0-0x00000001844016D0
		private void _UpdateMoveTips(); // 0x0000000183C94EE0-0x0000000183C95040
		private Camera _GetUICamera(); // 0x000000018B0F1638-0x000000018B0F187C
		private void _CheckOverScrollEffect(Vector2 value); // 0x0000000184476210-0x0000000184476260
		private void _CheckOverScrollOnEndDrag(Vector2 value); // 0x000000018B0F0D28-0x000000018B0F0F04
		public void __iFixBaseProxy_Awake(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0F0B24-0x000000018B0F0B2C
		public void __iFixBaseProxy_OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy__CustomSetPosOnScroll(Vector2 P0); // 0x000000018B0F0B3C-0x000000018B0F0B44
		public void __iFixBaseProxy_UpdateScrollEnableNode(); // 0x000000018B0F0B34-0x000000018B0F0B3C
		public void __iFixBaseProxy_OnBeginDrag(PointerEventData P0); // 0x000000018B0F0B14-0x000000018B0F0B1C
		public void __iFixBaseProxy_OnDrag(PointerEventData P0); // 0x000000018B0F0B1C-0x000000018B0F0B24
		public void __iFixBaseProxy_OnEndDrag(PointerEventData P0); // 0x000000018B0F0B2C-0x000000018B0F0B34
		public void __iFixBaseProxy_LateUpdate(); // 0x000000018B0F0B0C-0x000000018B0F0B14
	}

	public class UIScrollRectEdgeRedDot : TickableUIMono, IUIClearable // TypeDefIndex: 50437
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
		[SerializeField]
		[Tooltip("\u662F\u5426\u6309\u6C34\u5E73\u65B9\u5411\u5224\u65AD\uFF08true \u65F6\u7528\u4E0A\u7EA2\u70B9\u5F53\u5DE6\u7EA2\u70B9\u3001\u4E0B\u7EA2\u70B9\u5F53\u53F3\u7EA2\u70B9\uFF09")]
		private bool _isHorizontal; // 0xB0
		[Header("\u5F15\u7528\u8BBE\u7F6E\u3002\u8BF7\u4E0D\u8981\u52A8\u4E0B\u9762\u7684\u5185\u5BB9\uFF01\uFF01\uFF01")]
		[SerializeField]
		[Tooltip("\u4E0A/\u5DE6\u65B9\u7EA2\u70B9\u7684 Normal GameObject\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private GameObject _upNormal; // 0xB8
		[SerializeField]
		[Tooltip("\u4E0A/\u5DE6\u65B9\u7EA2\u70B9\u7684 New GameObject\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private GameObject _upNew; // 0xC0
		[SerializeField]
		[Tooltip("\u4E0B/\u53F3\u65B9\u7EA2\u70B9\u7684 Normal GameObject\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private GameObject _downNormal; // 0xC8
		[SerializeField]
		[Tooltip("\u4E0B/\u53F3\u65B9\u7EA2\u70B9\u7684 New GameObject\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private GameObject _downNew; // 0xD0
		[SerializeField]
		[Tooltip("\u4E0A/\u5DE6\u65B9\u7EA2\u70B9\u7684\u7236\u7269\u4F53\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private RectTransform _upParent; // 0xD8
		[SerializeField]
		[Tooltip("\u4E0B/\u5DE6\u65B9\u7EA2\u70B9\u7684\u7236\u7269\u4F53\uFF08\u62D6\u52A8\u8BBE\u7F6E\uFF09")]
		private RectTransform _downParent; // 0xE0
		[Header("\u5224\u5B9A\u7EA2\u70B9\u662F\u5426\u51FA\u6846\u7684\u504F\u79FB\u91CF")]
		[SerializeField]
		private float _upEdgeOffset; // 0xE8
		[SerializeField]
		private float _downEdgeOffset; // 0xEC
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B0F0440-0x000000018B0F0490 
	
		// Nested types
		public enum ERedDotState // TypeDefIndex: 50434
		{
			DISABLED = 0,
			NEW = 1,
			NORMAL = 2
		}
	
		public enum ERedDotDir // TypeDefIndex: 50435
		{
			UP = 0,
			RIGHT = 1,
			DOWN = 2,
			LEFT = 3
		}
	
		public class RedDotInfo // TypeDefIndex: 50436
		{
			// Fields
			public readonly GameObject redDotRoot; // 0x10
			public readonly GameObject redDotNormal; // 0x18
			public readonly GameObject redDotNew; // 0x20
	
			// Properties
			public ERedDotState state { get; } // 0x000000018B0EE120-0x000000018B0EE210 
			public Vector2 normalPos { get; } // 0x000000018B0EDF48-0x000000018B0EE024 
			public Vector2 newPos { get; } // 0x000000018B0EDD70-0x000000018B0EDE4C 
			public Rect normalRect { get; } // 0x000000018B0EE024-0x000000018B0EE120 
			public Rect newRect { get; } // 0x000000018B0EDE4C-0x000000018B0EDF48 
	
			// Constructors
			public RedDotInfo(GameObject redDotRoot, GameObject redDotNormal, GameObject redDotNew); // 0x000000018B0EDD38-0x000000018B0EDD70
		}
	
		// Constructors
		public UIScrollRectEdgeRedDot(); // 0x0000000184D83030-0x0000000184D83050
	
		// Methods
		protected override void OnAwake(); // 0x000000018B0EE950-0x000000018B0EE9AC
		protected override void OnEnable(); // 0x000000018B0EE9AC-0x000000018B0EEB78
		protected override void OnRelease(); // 0x000000018B0EEB78-0x000000018B0EECA4
		public override void Tick(float deltaTime); // 0x000000018B0EF620-0x000000018B0EF83C
		public void ResetReferences(); // 0x000000018B0EF3CC-0x000000018B0EF620
		public void ResetRedDotPosition(); // 0x000000018B0EEFE8-0x000000018B0EF3CC
		private void _UpdateCacheDictForRangeChange(Vector2Int newRange); // 0x000000018B0F00B0-0x000000018B0F02A0
		private void _OnScrollListUpdateCount(int newCount); // 0x000000018B0F0018-0x000000018B0F00B0
		public void RegisterRedDot(GameObject redDotRoot, GameObject redDotNormal, GameObject redDotNew); // 0x000000018B0EEE30-0x000000018B0EEFE8
		public void UnregisterRedDot(GameObject redDotRoot); // 0x000000018B0EF83C-0x000000018B0EF8FC
		public void RegisterRedDotStatesForScrollList(); // 0x000000018B0EECA4-0x000000018B0EEE30
		public void UpdateRedDotStateInDir(); // 0x000000018B0EF8FC-0x000000018B0EF9C4
		private void _CalculateRedDotStateInDir(out ERedDotState upState, out ERedDotState downState); // 0x000000018B0EF9C4-0x000000018B0F0018
		private void _UpdateRedDotGameObjects(GameObject normal, GameObject newer, ERedDotState state); // 0x000000018B0F02A0-0x000000018B0F0440
		public bool IsRedDotInDir(ERedDotState state, ERedDotDir dir, RedDotInfo redDotInfo); // 0x000000018B0EE678-0x000000018B0EE950
		public void ClearComponent(); // 0x000000018B0EE61C-0x000000018B0EE678
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	[RequireComponent(typeof(UIText))]
	public class UIScrollText : TickableUIMono // TypeDefIndex: 50445
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
		protected override TickType tickOption { get; } // 0x0000000184A35580-0x0000000184A355B0 
	
		// Nested types
		private enum ScrollMode // TypeDefIndex: 50438
		{
			Mesh = 0,
			AnchoredPosition = 1
		}
	
		private enum ScrollState // TypeDefIndex: 50439
		{
			Scrolling = 0,
			Idle = 1,
			FadingOut = 2,
			FadingIn = 3
		}
	
		private interface IAlphaHandler // TypeDefIndex: 50440
		{
			// Methods
			void HandleAlpha(float alpha);
		}
	
		private class CanvasGroupHandler : IAlphaHandler // TypeDefIndex: 50441
		{
			// Fields
			private CanvasGroup m_canvasGroup; // 0x10
	
			// Constructors
			public CanvasGroupHandler(CanvasGroup canvasGroup); // 0x00000001853908C0-0x00000001853908D0
	
			// Methods
			public void HandleAlpha(float alpha); // 0x000000018B0ECE0C-0x000000018B0ECE78
		}
	
		private interface IScrollHandler // TypeDefIndex: 50442
		{
			// Methods
			void ApplyScroll(float scrollOffset);
			void ResetScroll();
			void UpdateScrollStatus(bool isScroll);
		}
	
		private class PositionScrollHandler : Beyond.UI.UIScrollText.IScrollHandler // TypeDefIndex: 50443
		{
			// Fields
			private UIScrollText m_closure; // 0x10
	
			// Constructors
			public PositionScrollHandler(UIScrollText scrollText); // 0x00000001853908C0-0x00000001853908D0
	
			// Methods
			public void ApplyScroll(float scrollOffset); // 0x000000018B0EDB34-0x000000018B0EDBE0
			public void ResetScroll(); // 0x000000018B0EDBE0-0x000000018B0EDC54
			public void UpdateScrollStatus(bool isScroll); // 0x000000018B0EDC54-0x000000018B0EDD38
		}
	
		private class MeshScrollHandler : Beyond.UI.UIScrollText.IScrollHandler // TypeDefIndex: 50444
		{
			// Fields
			private UIScrollText m_closure; // 0x10
	
			// Constructors
			public MeshScrollHandler(UIScrollText uiScrollText); // 0x00000001853908C0-0x00000001853908D0
	
			// Methods
			public void ApplyScroll(float scrollOffset); // 0x000000018B0ECE78-0x000000018B0ECEDC
			public void ResetScroll(); // 0x000000018B0ECEDC-0x000000018B0ECF34
			public void UpdateScrollStatus(bool isScroll); // 0x000000018B0ECF34-0x000000018B0ECFF0
			private void _ApplyScroll(float scrollOffset); // 0x000000018B0ECFF0-0x000000018B0ED2B4
			private void _UpdateMeshClipping(TMP_TextInfo textInfo); // 0x000000018B0ED2B4-0x000000018B0EDB34
		}
	
		// Constructors
		public UIScrollText(); // 0x0000000184D25E90-0x0000000184D25EC0
	
		// Methods
		private void _InitIfNot(); // 0x00000001849BC050-0x00000001849BC2A0
		public void ResetTextScroll(); // 0x000000018B0F20AC-0x000000018B0F2220
		public void ResetToStatic(); // 0x000000018B0F2220-0x000000018B0F2280
		public float GetSingleScrollDuration(); // 0x000000018B0F1D08-0x000000018B0F1E90
		private void _ResetTextScrollInternal(bool needScroll, float textDiff); // 0x000000018B0F23DC-0x000000018B0F2494
		protected override void OnAwake(); // 0x00000001849BC010-0x00000001849BC050
		public override void LateTick(float deltaTime); // 0x000000018B0F1E90-0x000000018B0F20AC
		private void _UpdateScrollState(float deltaTime, float textDiff); // 0x000000018B0F24F8-0x000000018B0F2810
		private void _ResetTextScroll(); // 0x000000018B0F2494-0x000000018B0F24F8
		private void _ApplyTextAlignment(bool isScroll); // 0x000000018B0F2280-0x000000018B0F232C
		private void _ApplyTextScroll(float scrollOffset); // 0x000000018B0F232C-0x000000018B0F23DC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	public class UISelectableNaviGroup : SelectableNaviGroup, IUIClearable // TypeDefIndex: 50447
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
		private const int INVALID_BINDING_ID = -1; // Metadata: 0x0232FD84
	
		// Properties
		public int FocusBindingId { get; } // 0x000000018B0F2FF4-0x000000018B0F3044 
		public int StopFocusBindingId { get; } // 0x000000018B0F3044-0x000000018B0F3094 
		public Selectable lastFocusNaviTarget { get; } // 0x000000018B0F3094-0x000000018B0F30E4 
	
		// Nested types
		public struct FocusBlockMessageData // TypeDefIndex: 50446
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
		public UISelectableNaviGroup(); // 0x00000001840F9920-0x00000001840F99E0
	
		// Methods
		private void Awake(); // 0x00000001837D3880-0x00000001837D3920
		protected override void OnEnable(); // 0x00000001837D3D40-0x00000001837D3D90
		protected override void OnDisable(); // 0x00000001845F41D0-0x00000001845F4210
		protected override void _OnIsTopLayerChanged(); // 0x00000001837D3F90-0x00000001837D3FE0
		protected override void _OnSelectableNaviGroupDisabled(); // 0x00000001846B1ED0-0x00000001846B1F10
		protected override void _BeforeSelectableNaviGroupDestroy(); // 0x00000001837D2E40-0x00000001837D2E80
		protected override void _OnSetLayerSelectedTarget(Selectable value); // 0x000000018B0F2E9C-0x000000018B0F2F04
		protected override void _OnRemoveFromLayerStack(); // 0x00000001837D1010-0x00000001837D1060
		public void NaviToThisGroup(bool forceDefault = false /* Metadata: 0x0232FD81 */); // 0x000000018306A3A0-0x000000018306A540
		private void _RefreshRelatedBindingGroupsState(); // 0x00000001837D4010-0x00000001837D4180
		private Selectable _FindDefaultSelectable(); // 0x000000018306A540-0x000000018306A950
		protected override void OnDestroy(); // 0x00000001839CFBA0-0x00000001839CFBF0
		public void ClearComponent(); // 0x00000001839CFD30-0x00000001839CFE70
		public void TryChangeNaviPartnerOnUp(UISelectableNaviGroup partner, bool isAdd); // 0x000000018B0F2AFC-0x000000018B0F2B7C
		public void TryChangeNaviPartnerOnDown(UISelectableNaviGroup partner, bool isAdd); // 0x000000018B0F297C-0x000000018B0F29FC
		public void TryChangeNaviPartnerOnLeft(UISelectableNaviGroup partner, bool isAdd); // 0x000000018B0F29FC-0x000000018B0F2A7C
		public void TryChangeNaviPartnerOnRight(UISelectableNaviGroup partner, bool isAdd); // 0x000000018B0F2A7C-0x000000018B0F2AFC
		private void _TryChangeNaviPartner(List<SelectableNaviGroup> list, UISelectableNaviGroup partner, bool isAdd); // 0x000000018B0F2F04-0x000000018B0F2FF4
		private void _InitFocusBinding(); // 0x00000001837D3A60-0x00000001837D3D00
		private void _RefreshFocusBindings(); // 0x00000001837D0DF0-0x00000001837D0EF0
		public void RefreshFocusBindings(); // 0x000000018B0F2874-0x000000018B0F28C4
		private void _OnFocus(bool onlyStartHighlight); // 0x000000018B0F2BB0-0x000000018B0F2E9C
		private void _OnStopFocus(bool onlyStopHighlight, bool ignoreTopLayerCheck); // 0x00000001837D12E0-0x00000001837D1390
		private void _RefreshFocusActionKeyHint(); // 0x00000001837D3ED0-0x00000001837D3F90
		private void _RefreshStopFocusActionKeyHint(); // 0x00000001837D3DC0-0x00000001837D3E20
		public void ManuallyFocus(bool onlyStartHighlight = false /* Metadata: 0x0232FD82 */); // 0x000000018B0F2810-0x000000018B0F2874
		public void ManuallyStopFocus(bool onlyStopHighlight = false /* Metadata: 0x0232FD83 */); // 0x00000001837D2DF0-0x00000001837D2E40
		public void SetFocusBindingText(string bindingText); // 0x000000018B0F28C4-0x000000018B0F297C
		public void ClearLastFocusNaviTarget(); // 0x0000000184B87E20-0x0000000184B87E60
		public void ManuallyRefreshRelatedBindingGroups(); // 0x00000001837D2E80-0x00000001837D2EC0
		[CompilerGenerated]
		private void __InitFocusBinding_b__51_0(); // 0x000000018B0F2B94-0x000000018B0F2BA0
		[CompilerGenerated]
		private void __InitFocusBinding_b__51_1(); // 0x000000018B0F2BA0-0x000000018B0F2BB0
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0F2B84-0x000000018B0F2B8C
		public void __iFixBaseProxy_OnDisable(); // 0x00000001853979C0-0x00000001853979D0
		public void __iFixBaseProxy__OnIsTopLayerChanged(); // 0x000000018B0F2B8C-0x000000018B0F2B94
		public void __iFixBaseProxy__OnSelectableNaviGroupDisabled(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy__BeforeSelectableNaviGroupDestroy(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy__OnSetLayerSelectedTarget(Selectable P0); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy__OnRemoveFromLayerStack(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0F2B7C-0x000000018B0F2B84
	}

	[ExecuteInEditMode]
	public class UISemiCircleScrollList : TickableUIMono, IDragHandler, IUIClearable, IBeginDragHandler, IEndDragHandler // TypeDefIndex: 50449
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
		[SerializeField]
		protected bool _dpadScrollEnabled; // 0x110
		[SerializeField]
		protected float _dpadScrollSpeed; // 0x114
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B0F4830-0x000000018B0F4880 
		public bool controllerStickScrollEnabled { get; } // 0x000000018B0F4790-0x000000018B0F4830 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __ApplyDamping_d__46 : IEnumerator<object> // TypeDefIndex: 50448
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UISemiCircleScrollList __4__this; // 0x20
			private float _targetOffset_5__2; // 0x28
			private float _elapsed_5__3; // 0x2C
			private float _initialOffset_5__4; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __ApplyDamping_d__46(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B0EE2A0-0x000000018B0EE5D0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B0EE5D0-0x000000018B0EE61C
		}
	
		// Constructors
		public UISemiCircleScrollList(); // 0x000000018B0F4630-0x000000018B0F4790
	
		// Methods
		protected override void OnAwake(); // 0x000000018B0F386C-0x000000018B0F3910
		protected override void OnDisable(); // 0x000000018B0F3994-0x000000018B0F3A18
		public override void Tick(float deltaTime); // 0x000000018B0F3CD8-0x000000018B0F3D44
		private void _TickRefreshControllerStickScroll(); // 0x000000018B0F4374-0x000000018B0F4630
		private void _InitializeCells(); // 0x000000018B0F420C-0x000000018B0F4374
		public void RefreshLayout(int newCellCount, int targetCellIndex); // 0x000000018B0F3C38-0x000000018B0F3CD8
		public void UpdateLayout(); // 0x000000018B0F3D44-0x000000018B0F417C
		public void OnDrag(PointerEventData eventData); // 0x000000018B0F3A18-0x000000018B0F3B50
		public void ClearComponent(); // 0x000000018B0F3758-0x000000018B0F386C
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018B0F3910-0x000000018B0F3994
		public void OnEndDrag(PointerEventData eventData); // 0x000000018B0F3B50-0x000000018B0F3C38
		[IteratorStateMachine(typeof(__ApplyDamping_d__46))]
		private IEnumerator _ApplyDamping(); // 0x000000018B0F417C-0x000000018B0F420C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public class UISemiCircleScrollListPair : MonoBehaviour // TypeDefIndex: 50450
	{
		// Fields
		public UISemiCircleScrollList m_scrollListMaster; // 0x18
		public UISemiCircleScrollList[] m_scrollLists; // 0x20
		public DisposedUnityEvent<GameObject, int> onCellShow; // 0x28
		public DisposedUnityEvent<int> onClosestCellChanged; // 0x30
	
		// Constructors
		public UISemiCircleScrollListPair(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void Awake(); // 0x000000018B0F30E4-0x000000018B0F3458
		private void _OnCellShow(GameObject go, int index); // 0x000000018B0F3514-0x000000018B0F35B4
		private void _OnClosestCellChanged(int index); // 0x000000018B0F35B4-0x000000018B0F363C
		private void _OnDrag(); // 0x000000018B0F363C-0x000000018B0F36D8
		private void _OnEndDrag(); // 0x000000018B0F36D8-0x000000018B0F3758
		public void RefreshLayout(int newCellCount, int targetCellIndex); // 0x000000018B0F3458-0x000000018B0F3514
	}

	[ExecuteAlways]
	[RequireComponent(typeof(UIImage))]
	public class UISequenceImage : TickableUIMono // TypeDefIndex: 50451
	{
		// Fields
		public bool autoPlay; // 0x68
		public float frameRate; // 0x6C
		public List<Sprite> sprites; // 0x70
		[CompilerGenerated]
		private bool _isPlaying_k__BackingField; // 0x78
		private UIImage m_image; // 0x80
		private float m_curFrameCount; // 0x88
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001846BEFA0-0x00000001846BEFD0 
		public bool isPlaying { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86F90-0x0000000184D86FA0 0x0000000184D86FA0-0x0000000184D86FB0
	
		// Constructors
		public UISequenceImage(); // 0x00000001845A38E0-0x00000001845A3970
	
		// Methods
		protected override void OnAwake(); // 0x0000000184A05750-0x0000000184A057D0
		protected override void OnEnable(); // 0x00000001848BD7C0-0x00000001848BD810
		protected override void OnDisable(); // 0x00000001849D6D30-0x00000001849D6D80
		public override void Tick(float deltaTime); // 0x00000001831E9FF0-0x00000001831EA080
		public void Play(); // 0x00000001848BD810-0x00000001848BD860
		public void Stop(bool resetToFirstFrame = false /* Metadata: 0x0232FD85 */); // 0x00000001849D6D80-0x00000001849D6DC0
		public void SetSprite(int index); // 0x00000001831EA080-0x00000001831EA1B0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	[RequireComponent(typeof(Animation))]
	public class UISimpleActiveAnimationHelper : TickableUIMono // TypeDefIndex: 50452
	{
		// Fields
		public bool isActive; // 0x68
		public string toActiveAnimationName; // 0x70
		private Animation m_animation; // 0x78
		private UnityEngine.AnimationState m_animationState; // 0x80
		private float m_animationTime; // 0x88
		private float m_curAnimationTime; // 0x8C
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018B0F4B98-0x000000018B0F4BE8 
	
		// Constructors
		public UISimpleActiveAnimationHelper(); // 0x0000000184D10E70-0x0000000184D10ED0
	
		// Methods
		private void Start(); // 0x000000018B0F4994-0x000000018B0F4A70
		protected override void OnEnable(); // 0x000000018B0F4880-0x000000018B0F48F0
		public void Skip(); // 0x000000018B0F48F0-0x000000018B0F4994
		public override void Tick(float deltaTime); // 0x000000018B0F4A70-0x000000018B0F4B98
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	[ExecuteInEditMode]
	public class UISimpleStateController : MonoBehaviour // TypeDefIndex: 50454
	{
		// Fields
		[SerializeField]
		private List<StateInfo> _states; // 0x18
		private string m_curStateName; // 0x20
	
		// Properties
		public string curStateName { get; } // 0x000000018B0F4BE8-0x000000018B0F4C38 
	
		// Nested types
		[Serializable]
		public class StateInfo // TypeDefIndex: 50453
		{
			// Fields
			public string name; // 0x10
			public List<GameObject> activeObjects; // 0x18
	
			// Constructors
			public StateInfo(); // 0x00000001835735B0-0x0000000183573600
	
			// Methods
			public override string ToString(); // 0x000000018B0EE210-0x000000018B0EE260
			public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
		}
	
		// Constructors
		public UISimpleStateController(); // 0x000000018446CA60-0x000000018446CAD0
	
		// Methods
		public void SetState(string stateName); // 0x000000018378F2A0-0x000000018378F840
	}

	public class UISizeFollower : TickableUIMono // TypeDefIndex: 50455
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
		protected override TickType tickOption { get; } // 0x00000001842D2570-0x00000001842D25A0 
		public RectTransform rectTransform { get; } // 0x0000000183BCDC90-0x0000000183BCDD90 
	
		// Constructors
		public UISizeFollower(); // 0x00000001839C44E0-0x00000001839C44F0
	
		// Methods
		public override void LateTick(float deltaTime); // 0x0000000183BCD960-0x0000000183BCD9E0
		public void SyncSize(); // 0x0000000183BCD9E0-0x0000000183BCDC90
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	[AddComponentMenu("UI/UI Slider", 34)]
	public class UISlider : Slider, IUIClearable, IBeginDragHandler, IEndDragHandler, IBindingGroupTarget, IBindingView // TypeDefIndex: 50456
	{
		// Fields
		public float snapCenterRange; // 0x1F0
		[AudioString]
		public string audioSlide; // 0x1F8
		[AudioString]
		public string audioClickHandle; // 0x200
		private bool m_dragging; // 0x208
		private bool m_gamepadStickScrolling; // 0x209
		public SliderEvent onEndDragSlider; // 0x210
		public SliderEvent onClickSlider; // 0x218
		public SliderEvent onClickSliderHandle; // 0x220
		private TickFunction m_gamepadStickScrollTickFunction; // 0x228
		public string sliderAddActionId; // 0x230
		public string sliderReduceActionId; // 0x238
		[CompilerGenerated]
		private readonly DisposedUnityEvent _bindingViewUpdateEvent_k__BackingField; // 0x240
		private int m_bindingGroupId; // 0x248
		[CompilerGenerated]
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0x250
		public bool snapStep; // 0x258
		public float stepValue; // 0x25C
		[FormerlySerializedAs("_enableStickScroll")]
		[SerializeField]
		protected bool _enableGamepadStickScroll; // 0x260
		[FormerlySerializedAs("_stickScrollTolerance")]
		[Range(0.001f, 1f)]
		[SerializeField]
		protected float _gamepadStickScrollTolerance; // 0x264
		[FormerlySerializedAs("_stickOverPushThreshold")]
		[Range(0.001f, 0.9f)]
		[SerializeField]
		protected float _gamepadStickOverPushThreshold; // 0x268
		[FormerlySerializedAs("_stickOverPushMultiplier")]
		[SerializeField]
		protected int _gamepadStickOverPushMultiplier; // 0x26C
		[FormerlySerializedAs("_stickScrollBatchCount")]
		[SerializeField]
		protected int _gamepadStickScrollBatchCount; // 0x270
		private int m_gamepadStickScrollHoriBindingId; // 0x274
	
		// Properties
		public string bindingViewActionId { get; } // 0x000000018B0F5744-0x000000018B0F5794 
		public string bindingViewLabelText { get; } // 0x000000018B0F5794-0x000000018B0F580C 
		public DisposedUnityEvent bindingViewUpdateEvent { [CompilerGenerated] get; } // 0x0000000184D8DE80-0x0000000184D8DE90 
		public RectTransform redDotTrans { get; } // 0x000000018B0F5A20-0x000000018B0F5A6C 
		public bool bindingEnabled { get; } // 0x000000018B0F56F4-0x000000018B0F5744 
		public BindingViewState bindingViewState { get; } // 0x000000018B0F580C-0x000000018B0F5998 
		public int groupId { get; } // 0x000000018465E310-0x000000018465E340 
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8DCE0-0x0000000184D8DCF0 0x0000000186B8B6E8-0x0000000186B8B6FC
		public bool groupEnabled { get; } // 0x000000018B0F5998-0x000000018B0F5A20 
		bool IBindingView.interactable { get; } // 0x000000018B0F4CE0-0x000000018B0F4D30 
	
		// Constructors
		public UISlider(); // 0x000000018435C390-0x000000018435C550
	
		// Methods
		private void _TryPostSlideAudioEvent(); // 0x00000001842B6E80-0x00000001842B6EE0
		protected override float ClampValue(float input); // 0x0000000183F714B0-0x0000000183F71560
		protected override float CustomProcessNormalizedValue(float val); // 0x000000018B0F4D30-0x000000018B0F4DBC
		protected override void OnValueChanged(); // 0x00000001842B6E40-0x00000001842B6E80
		protected override void OnClickSliderBar(); // 0x000000018B0F4F10-0x000000018B0F4F94
		protected override void OnClickSliderHandle(); // 0x000000018B0F4F94-0x000000018B0F504C
		protected override void _NotifyIsHover(bool isHover); // 0x0000000184535700-0x0000000184535750
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x000000018B0F4EB4-0x000000018B0F4F10
		public virtual void OnEndDrag(PointerEventData eventData); // 0x000000018B0F504C-0x000000018B0F50EC
		protected override void Awake(); // 0x00000001837D3510-0x00000001837D3560
		protected override void OnEnable(); // 0x0000000183935580-0x0000000183935610
		protected override void OnDisable(); // 0x000000018447EBD0-0x000000018447EC90
		private void _CreateGamepadStickScrollTickFunction(); // 0x000000018B0F5350-0x000000018B0F5474
		private void _ReleaseGamepadStickScrollTickFunction(); // 0x000000018447ECA0-0x000000018447ECF0
		private void _GamepadStickScrollTick(float deltaTime); // 0x000000018B0F5474-0x000000018B0F55C0
		public void ClearComponent(); // 0x0000000184845F60-0x0000000184845FD0
		protected override void OnDestroy(); // 0x000000018465E270-0x000000018465E310
		public string GetBindingViewActionId(BindingViewActionType actionType); // 0x000000018B0F4DBC-0x000000018B0F4EB4
		void IBindingView.OnInputKeyDown(bool isActionTrigger); // 0x000000018B0F4C38-0x000000018B0F4C8C
		void IBindingView.OnInputKeyUp(bool isActionTrigger); // 0x000000018B0F4C8C-0x000000018B0F4CE0
		private void _InitBinding(); // 0x00000001837D3560-0x00000001837D3690
		private void _AddValue(); // 0x000000018B0F50FC-0x000000018B0F5168
		private void _ReduceValue(); // 0x000000018B0F5688-0x000000018B0F56F4
		private void _InitGamepadStickScroll(); // 0x00000001837D3690-0x00000001837D3720
		private void _OnGamepadStickScrollHoriValue(); // 0x000000018B0F55C0-0x000000018B0F5688
		private void _ApplyGamepadStickScroll(float deltaConcern); // 0x000000018B0F5168-0x000000018B0F5350
		public float __iFixBaseProxy_ClampValue(float P0); // 0x000000018B0F50EC-0x000000018B0F50F4
		public float __iFixBaseProxy_CustomProcessNormalizedValue(float P0); // 0x0000000184D9A920-0x0000000184D9A930
		public void __iFixBaseProxy_OnValueChanged(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnClickSliderBar(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnClickSliderHandle(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018B0C581C-0x000000018B0C5824
		public void __iFixBaseProxy_Awake(); // 0x000000018B0869D4-0x000000018B0869DC
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0F50F4-0x000000018B0F50FC
		public void __iFixBaseProxy_OnDisable(); // 0x000000018447EC90-0x000000018447ECA0
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0869DC-0x000000018B0869E4
	}

	[ExecuteInEditMode]
	public class UISoftMask : TickableUIMono // TypeDefIndex: 50458
	{
		// Fields
		private Vector3[] m_fourCornersArray; // 0x68
		private Vector3[] m_fourCornersArrayWorld; // 0x70
		private List<UISoftMaskable> m_cacheSoftMaskables; // 0x78
		private static List<Canvas> s_cacheCanvas; // 0x00
		private Image m_image; // 0x80
		private bool m_registeredWillRenderCanvases; // 0x88
		[SerializeField]
		private Shader _maskableDefaultShader; // 0x90
		[SerializeField]
		private Shader _maskableTextShader; // 0x98
		private static int s_SoftMaskTexId; // 0x08
		private static int s_SoftMaskTexSTId; // 0x0C
		private static int s_WorldToSoftMaskId; // 0x10
		private static int s_InnerSoftMaskId; // 0x14
		private static int s_InnerSoftMaskUVId; // 0x18
		private static int s_SpriteSlicedFlag; // 0x1C
		private Texture m_mainTexture; // 0xA0
		private Vector4 m_spriteTillingOffset; // 0xA8
		private Matrix4x4 m_worldToSoftMask; // 0xB8
		private Vector4 m_innerSoftMask; // 0xF8
		private Vector4 m_innerSoftMaskUV; // 0x108
		private Image.Type m_lastImageType; // 0x118
		private Sprite m_lastSprite; // 0x120
		private Rect m_lastPixelAdjustedRect; // 0x128
		private float m_lastPixelsPerUnit; // 0x138
		private float m_lastPixelsPerUnitMultiplier; // 0x13C
		private bool m_lastEnableRuntimeAtlas; // 0x140
		private Texture m_lastRuntimeAtlasTexture; // 0x148
		private Rect m_lastRuntimeAtlasRect; // 0x150
		private Rect m_lastRuntimeAtlasTextureRect; // 0x160
		private Vector4 m_lastRuntimeAtlasBorder; // 0x170
		private SlicedSpriteParams m_slicedSpriteParams; // 0x180
		private Material m_softMaskDefaultMaterial; // 0x1A8
		private Dictionary<Material, Material> m_softMaskTextMaterials; // 0x1B0
		private Dictionary<Material, Material> m_softMaskUIVFXMaterials; // 0x1B8
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000184111830-0x0000000184111860 
		public Material softMaskDefaultMaterial { get; } // 0x00000001839409B0-0x00000001839409E0 
	
		// Nested types
		public struct SlicedSpriteParams // TypeDefIndex: 50457
		{
			// Fields
			public int slicedEnabled; // 0x00
			public Vector2 inner_PosMin; // 0x04
			public Vector2 inner_PosMax; // 0x0C
			public Vector2 inner_UVMin; // 0x14
			public Vector2 inner_UVMax; // 0x1C
	
			// Constructors
			public SlicedSpriteParams(int slicedEnabled, Vector2 inner_PosMin, Vector2 inner_PosMax, Vector2 inner_UVMin, Vector2 inner_UVMax); // 0x0000000184DAAF30-0x0000000184DAAF60
		}
	
		// Constructors
		public UISoftMask(); // 0x00000001839C4500-0x00000001839C4650
		static UISoftMask(); // 0x0000000184A33210-0x0000000184A33520
	
		// Methods
		private Texture _GetSoftMaskTexture(); // 0x0000000183940CA0-0x0000000183940D70
		public Material GetTextSoftMaskMaterial(Material baseMaterial); // 0x0000000183940420-0x00000001839406E0
		public Material GetUIVFXSoftMaskMaterial(Material baseMaterial); // 0x00000001839409E0-0x0000000183940CA0
		public Vector3 GetCornerCanvas(int i); // 0x000000018B0F5A6C-0x000000018B0F5B0C
		public Vector3[] GetFourCornnerArrayWorld(); // 0x000000018B0F5B0C-0x000000018B0F5B5C
		protected override void OnEnable(); // 0x000000018309A280-0x000000018309A530
		protected override void OnDisable(); // 0x0000000183099ED0-0x000000018309A050
		public override void TailLateTick(float deltaTime); // 0x00000001831C4710-0x00000001831C4890
		private void _OnWillRenderCanvases(); // 0x0000000183B58FA0-0x0000000183B590F0
		private void _Clear(); // 0x0000000183099BF0-0x0000000183099E80
		private void _DestroyMaterial(Material material); // 0x0000000183099E80-0x0000000183099ED0
		private void _UpdateParam(); // 0x00000001833A0B90-0x00000001833A28D0
		private void _UpdateChildren(bool markVertices, bool markMaterial); // 0x00000001831DF530-0x00000001831DFA00
		private bool _IsImageParamChanged(Image image); // 0x00000001831C2FD0-0x00000001831C39B0
		private void _UpdateImageCache(Image image); // 0x0000000183EE49C0-0x0000000183EE4AC0
		private static SlicedSpriteParams _CalculateSlicedSpriteParams(Image image); // 0x00000001831CD8D0-0x00000001831CDCF0
		private static Vector4 _GetAdjustedBorders(Vector4 border, Rect adjustedRect, Rect originalRect); // 0x00000001831CDF30-0x00000001831CE170
		private static Vector4 _GetRuntimeAtlasSpriteInnerUV(Image image); // 0x000000018B0F5B5C-0x000000018B0F5DE4
		private static Vector4 _GetRuntimeAtlasSpritePadding(Image image); // 0x000000018B0F5DE4-0x000000018B0F5FE0
		private void _OnEnableRuntimeAtlas(); // 0x0000000184485580-0x00000001844856A0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000186C37238-0x0000000186C37240
	}

	[ExecuteInEditMode]
	public class UISoftMaskable : TickableUIMono, IMaterialModifier, IMeshModifier // TypeDefIndex: 50461
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
		protected override TickType tickOption { get; } // 0x0000000183E1DBB0-0x0000000183E1DC20 
		public Material softMaskModefiedMat { get; } // 0x000000018B0FA97C-0x000000018B0FA9CC 
		public Graphic graphic { get; } // 0x00000001831E0600-0x00000001831E0740 
		public UISoftMask softMask { get; } // 0x00000001839408E0-0x00000001839409B0 
		public UIText uiText { get; } // 0x000000018B0FA9CC-0x000000018B0FAA94 
	
		// Nested types
		private enum UIType // TypeDefIndex: 50459
		{
			Default = 0,
			Text = 1,
			UIVFX = 2
		}
	
		private struct TestLine // TypeDefIndex: 50460
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
		public UISoftMaskable(); // 0x00000001839C47D0-0x00000001839C4880
		static UISoftMaskable(); // 0x0000000184D11EB0-0x0000000184D11F50
	
		// Methods
		public Material GetModifiedMaterial(Material baseMaterial); // 0x0000000183940790-0x00000001839408E0
		protected override void OnEnable(); // 0x00000001831E0040-0x00000001831E0600
		protected override void OnDisable(); // 0x00000001831DFF40-0x00000001831E0040
		public override void LateTick(float deltaTime); // 0x00000001831DEB00-0x00000001831DEC60
		public void MarkGraphicVerticesDirty(); // 0x00000001831DFA00-0x00000001831DFAD0
		public void MarkGraphicMaterialDirty(); // 0x00000001831DEC60-0x00000001831DED10
		[IDTag(0)]
		public void ModifyMesh(Mesh mesh); // 0x000000018B0F909C-0x000000018B0F90F0
		private bool _Equal(float a, float b); // 0x000000018B0FA83C-0x000000018B0FA8C0
		private Vector2 _ComputeLineCross(Vector2 line0p0, Vector2 line0p1, Vector2 line1p0, Vector2 line1p1); // 0x000000018B0FA47C-0x000000018B0FA6BC
		private void _ComputePointAtTriangleUV(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 q, out float u, out float v); // 0x000000018B0FA6BC-0x000000018B0FA83C
		private void _ClipTriangleByClampSoftMaskUV(UIVertex[] vertices, UIVertex[] resultPoint, out bool canSkip); // 0x000000018B0F93D0-0x000000018B0FA47C
		private void _ClipRect(); // 0x000000018B0F90F0-0x000000018B0F93D0
		[IDTag(1)]
		public void ModifyMesh(VertexHelper vertHelper); // 0x00000001839406E0-0x0000000183940790
		private static void _SetUIVertexUV(ref UIVertex uiVertex, Vector2 uv0, Vector2 uv1, Vector2 softMaskUV); // 0x000000018B0FA8C0-0x000000018B0FA97C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
	}

	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class UISortingOrder : MonoBehaviour // TypeDefIndex: 50463
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
		private ParticleSystemRenderer[] m_childrenParticleRenderers; // 0x30
		private Canvas m_canvas; // 0x38
		private LuaPanel m_luaPanel; // 0x40
	
		// Nested types
		[Serializable]
		public enum RenderType // TypeDefIndex: 50462
		{
			Effect = 0,
			UI = 1,
			Particle = 2
		}
	
		// Constructors
		public UISortingOrder(); // 0x00000001847C82B0-0x00000001847C82E0
	
		// Methods
		private void OnEnable(); // 0x00000001845A6830-0x00000001845A6890
		private void _GetRenderer(); // 0x00000001837D56D0-0x00000001837D5780
		private void _GetChildrenRenderers(); // 0x00000001837D5660-0x00000001837D56D0
		private void _GetChildrenParticleRenderers(); // 0x000000018B0FAA94-0x000000018B0FAB1C
		private void _GetCanvas(); // 0x00000001837D4F60-0x00000001837D5010
		public void SetOrder(int baseOrder); // 0x00000001837D4C10-0x00000001837D4DF0
		private void Awake(); // 0x00000001837D3720-0x00000001837D3880
		private void OnDestroy(); // 0x00000001845ECC60-0x00000001845ECD00
	}

	public class UIStepScrollList : UIScrollList // TypeDefIndex: 50464
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
		public int centerIndex { get; } // 0x0000000184D7C710-0x0000000184D7C740 
	
		// Constructors
		public UIStepScrollList(); // 0x00000001839C2090-0x00000001839C21D0
	
		// Methods
		protected override void Init(bool isPreview = false /* Metadata: 0x0232FD8C */); // 0x00000001839D09D0-0x00000001839D0BE0
		protected override void InitConfig(); // 0x0000000184B335D0-0x0000000184B33680
		protected override void OnScroll(Vector2 v); // 0x000000018396D490-0x000000018396D4F0
		public override void OnBeginDrag(PointerEventData eventData); // 0x000000018B0FABA0-0x000000018B0FAC30
		public override void OnEndDrag(PointerEventData eventData); // 0x000000018B0FACA0-0x000000018B0FAEB8
		public override void SetTop(bool needUpdate = true /* Metadata: 0x0232FD8D */); // 0x000000018B0FAEB8-0x000000018B0FAF50
		protected override void UpdateShowingCells(bool forceUpdateContent, bool forceClearShowingCells = false /* Metadata: 0x0232FD8E */, bool ignoreListActive = false /* Metadata: 0x0232FD8F */); // 0x000000018396D4F0-0x000000018396D5B0
		public override void ClearComponent(); // 0x000000018B0FAB1C-0x000000018B0FABA0
		private void _OnScrollStart(Vector2 normalizedPos); // 0x000000018B0FB08C-0x000000018B0FB110
		private void _OnScrollEnd(Vector2 normalizedPos); // 0x000000018B0FAF80-0x000000018B0FB08C
		private void _TryAutoScroll(bool isEasyDrag, bool goNext); // 0x000000018B0FB110-0x000000018B0FB1D4
		private int _GetClampedIndex(); // 0x000000018396D5B0-0x000000018396D610
		protected override void OnDisable(); // 0x000000018B0FAC30-0x000000018B0FACA0
		public void __iFixBaseProxy_Init(bool P0); // 0x000000018B0FAF58-0x000000018B0FAF60
		public void __iFixBaseProxy_InitConfig(); // 0x000000018B0FAF50-0x000000018B0FAF58
		public void __iFixBaseProxy_OnScroll(Vector2 P0); // 0x000000018B0E48CC-0x000000018B0E48D4
		public void __iFixBaseProxy_OnBeginDrag(PointerEventData P0); // 0x000000018B0FAF60-0x000000018B0FAF68
		public void __iFixBaseProxy_OnEndDrag(PointerEventData P0); // 0x000000018B0FAF70-0x000000018B0FAF78
		public void __iFixBaseProxy_SetTop(bool P0); // 0x000000018B0FAF78-0x000000018B0FAF80
		public void __iFixBaseProxy_UpdateShowingCells(bool P0, bool P1, bool P2); // 0x000000018B0D2A00-0x000000018B0D2A10
		public void __iFixBaseProxy_ClearComponent(); // 0x000000018B0D2970-0x000000018B0D2978
		public void __iFixBaseProxy_OnDisable(); // 0x000000018B0FAF68-0x000000018B0FAF70
	}

	public class UIStyleByState : MonoBehaviour // TypeDefIndex: 50467
	{
		// Fields
		public List<StyleConfig> styleConfigs; // 0x18
	
		// Nested types
		[Serializable]
		public class StateConfig // TypeDefIndex: 50465
		{
			// Fields
			public UIStateController stateController; // 0x10
			public string stateName; // 0x18
	
			// Constructors
			public StateConfig(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[Serializable]
		public class StyleConfig // TypeDefIndex: 50466
		{
			// Fields
			public UIStyleInputValidTypeMask inputValidType; // 0x10
			public List<StateConfig> stateConfigs; // 0x18
	
			// Constructors
			public StyleConfig(); // 0x00000001844B1860-0x00000001844B18C0
		}
	
		// Constructors
		public UIStyleByState(); // 0x00000001845A5FE0-0x00000001845A6050
	
		// Methods
		private void Awake(); // 0x0000000183CECC10-0x0000000183CECD20
		private void OnDestroy(); // 0x00000001839D4470-0x00000001839D4560
		public void UpdateStyle(); // 0x0000000183CEBEB0-0x0000000183CEC740
		private bool _IsValidStyle(StyleConfig styleConfig); // 0x0000000183CEC740-0x0000000183CEC790
	}

	public class UISubtitle : MonoBehaviour // TypeDefIndex: 50468
	{
		// Fields
		[SerializeField]
		private UIText _topText; // 0x18
		[SerializeField]
		private UIText _bottomText; // 0x20
	
		// Constructors
		public UISubtitle(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void Start(); // 0x000000018B0FB2D8-0x000000018B0FB328
		private void _SetAsDefault(); // 0x000000018B0FB408-0x000000018B0FB538
		public void SetSubtitle(string subtitle, bool showOnTop); // 0x000000018B0FB1D4-0x000000018B0FB2D8
		public void UpdateAlpha(float alpha, bool isTop); // 0x000000018B0FB328-0x000000018B0FB408
	}

	public class UITextPair : MonoBehaviour // TypeDefIndex: 50469
	{
		// Fields
		public List<UIText> referencedTexts; // 0x18
	
		// Properties
		public string text { get; set; } // 0x000000018B0FBAEC-0x000000018B0FBBA8 0x000000018B0FBD38-0x000000018B0FBE64
		public UnityEngine.Color color { set; } // 0x000000018B0FBBA8-0x000000018B0FBD38
		public UIText first { get; } // 0x000000018B0FBA54-0x000000018B0FBAEC 
	
		// Constructors
		public UITextPair(); // 0x00000001849D3620-0x00000001849D3690
	
		// Methods
		public void SetAndResolveTextStyle(string targetText); // 0x000000018B0FB764-0x000000018B0FB8D0
		public void SetPhoneticText(PhoneticType phoneticType, string id); // 0x000000018B0FB8D0-0x000000018B0FBA54
	}

	public enum TimelineUIBindingType // TypeDefIndex: 50470
	{
		None = 0,
		Mask = 1,
		BigLogoFitImageTop = 2,
		BigLogoFitImageBottom = 3
	}

	public class UITimelineBindingTarget : MonoBehaviour // TypeDefIndex: 50471
	{
		// Fields
		public TimelineUIBindingType bindingType; // 0x18
	
		// Constructors
		public UITimelineBindingTarget(); // 0x0000000185393520-0x0000000185393538
	}

	[AddComponentMenu("UI/UI Toggle", 30)]
	public class UIToggle : Toggle, IUIClearable // TypeDefIndex: 50472
	{
		// Fields
		[SerializeField]
		private List<GameObject> _onObjects; // 0x1B0
		[SerializeField]
		private List<GameObject> _offObjects; // 0x1B8
		[SerializeField]
		private UIStateController _uiStateController; // 0x1C0
		[SerializeField]
		private string _onStateName; // 0x1C8
		[SerializeField]
		private string _offStateName; // 0x1D0
		[SerializeField]
		private string _onAnimation; // 0x1D8
		[SerializeField]
		private string _offAnimation; // 0x1E0
		[AudioString]
		[SerializeField]
		private string _audioToggleOn; // 0x1E8
		[AudioString]
		[SerializeField]
		private string _audioToggleOff; // 0x1F0
		[AudioString]
		[SerializeField]
		private string _audioInvalid; // 0x1F8
		[SerializeField]
		public bool _ignoreClickOnDrag; // 0x200
		[CompilerGenerated]
		private Vector2 _startPressPos_k__BackingField; // 0x204
		[SerializeField]
		[Tooltip("\u4E0D\u53EF\u70B9\u51FB\u65F6\u5F39\u51FA\u7684Toast\u6587\u672CKey")]
		private LangKey _invalidClickLangKey; // 0x210
		public Func<bool, bool> checkIsValueValid; // 0x220
		private Animation m_animation; // 0x228
		private int m_groupId; // 0x230
		[FormerlySerializedAs("_toggleActionId")]
		public string toggleActionId; // 0x238
		[CompilerGenerated]
		private int _toggleBindingId_k__BackingField; // 0x240
		private bool m_started; // 0x244
		[NonSerialized]
		public string clickOnHintTextId; // 0x248
		[NonSerialized]
		public string clickOffHintTextId; // 0x250
		private string m_customBindingViewLabelText; // 0x258
		[FormerlySerializedAs("actionOnSetNaviTarget")]
		[SerializeField]
		private ActionOnSetNaviTarget _actionOnSetNaviTarget; // 0x260
		[SerializeField]
		private bool _useNoHintAction; // 0x264
		public string onHintTextId; // 0x268
		public string offHintTextId; // 0x270
		[CompilerGenerated]
		private int _hoverConfirmBindingId_k__BackingField; // 0x278
	
		// Properties
		public Vector2 startPressPos { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D928D0-0x0000000184D928F0 0x0000000184D92960-0x0000000184D92970
		public int toggleBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DAAF70-0x0000000184DAAF80 0x0000000184DAAF90-0x0000000184DAAFA0
		public string customBindingViewLabelText { get; set; } // 0x0000000182E98080-0x0000000182E983E0 0x0000000182E983E0-0x0000000182E990B0
		public int hoverConfirmBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DAAF60-0x0000000184DAAF70 0x0000000184DAAF80-0x0000000184DAAF90
	
		// Constructors
		public UIToggle(); // 0x000000018435DDD0-0x000000018435DEF0
	
		// Methods
		protected override void Awake(); // 0x00000001837D2EC0-0x00000001837D2F50
		protected override void OnEnable(); // 0x000000018378E7C0-0x000000018378E820
		protected override void OnDisable(); // 0x000000018378E710-0x000000018378E750
		private void _UpdateBindingEnable(); // 0x000000018378E860-0x000000018378E920
		protected override void OnDestroy(); // 0x000000018B0FC5FC-0x000000018B0FC6C4
		protected override void Start(); // 0x000000018378E2D0-0x000000018378E320
		protected override void InternalToggle(); // 0x000000018B0FC564-0x000000018B0FC5FC
		private void _InitToggleBinding(); // 0x00000001837D3190-0x00000001837D3370
		private bool _OnToggleFail(); // 0x000000018B0FCC84-0x000000018B0FCDD4
		public void PlayAudio(); // 0x000000018B0FC98C-0x000000018B0FCA28
		protected override void OnValueChange(); // 0x000000018378E220-0x000000018378E280
		protected override void _NotifyIsHover(bool isHover); // 0x00000001847DC570-0x00000001847DC5C0
		private void _UpdateObjects(); // 0x000000018378EC00-0x000000018378F030
		private void _PlayAnimation(bool skipToEnd); // 0x000000018378E320-0x000000018378E4B0
		public void ClearComponent(); // 0x000000018481F770-0x000000018481FC00
		public override void OnInteractableChanged(); // 0x000000018B0FC6C4-0x000000018B0FC714
		public override bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId); // 0x000000018B0FC4C8-0x000000018B0FC564
		public override void OnPointerDown(PointerEventData eventData); // 0x000000018B0FC898-0x000000018B0FC92C
		public override void OnPointerClick(PointerEventData eventData); // 0x000000018B0FC780-0x000000018B0FC898
		public override void OnSubmit(BaseEventData eventData); // 0x000000018B0FC92C-0x000000018B0FC98C
		public void TryInternalToggle(); // 0x000000018B0FCA84-0x000000018B0FCB18
		public override void OnNaviTargetEnabledAgain(); // 0x000000018B0FC714-0x000000018B0FC780
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode); // 0x000000018B0FCB40-0x000000018B0FCC84
		private void _InitActionOnSetNaviTarget(); // 0x00000001837D2F50-0x00000001837D30A0
		private void _ToggleNaviInputBinding(bool active); // 0x000000018B0FCDD4-0x000000018B0FCE6C
		private void _TryRefreshToggleBindingText(); // 0x00000001837D3150-0x00000001837D3190
		private void _TryRefreshHoverConfirmBindingText(); // 0x000000018378E280-0x000000018378E2D0
		private void _TryRefreshBindingText(int bindingId, bool useCustomBindingViewLabelText = false /* Metadata: 0x0232FD94 */); // 0x0000000182E976D0-0x0000000182E98080
		public void RefreshHintText(); // 0x000000018B0FCA28-0x000000018B0FCA84
		public void __iFixBaseProxy_Awake(); // 0x000000018B0869D4-0x000000018B0869DC
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0FCB30-0x000000018B0FCB38
		public void __iFixBaseProxy_OnDisable(); // 0x000000018B0FCB28-0x000000018B0FCB30
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0FCB20-0x000000018B0FCB28
		public void __iFixBaseProxy_Start(); // 0x0000000185393868-0x0000000185393874
		public void __iFixBaseProxy_InternalToggle(); // 0x000000018B0FCB18-0x000000018B0FCB20
		public void __iFixBaseProxy_OnValueChange(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018B0C581C-0x000000018B0C5824
		public void __iFixBaseProxy_OnInteractableChanged(); // 0x00000001841E1670-0x00000001841E1680
		public bool __iFixBaseProxy_GetMouseActionHints(out string P0, out string P1); // 0x000000018B0C57FC-0x000000018B0C5804
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0); // 0x000000018B0C580C-0x000000018B0C5814
		public void __iFixBaseProxy_OnPointerClick(PointerEventData P0); // 0x000000018B0FCB38-0x000000018B0FCB40
		public void __iFixBaseProxy_OnSubmit(BaseEventData P0); // 0x000000018AC6E908-0x000000018AC6E918
		public void __iFixBaseProxy_OnNaviTargetEnabledAgain(); // 0x000000018B0C5804-0x000000018B0C580C
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1); // 0x00000001841E1670-0x00000001841E1680
	}

	public class UIToggleGroup : ToggleGroup // TypeDefIndex: 50473
	{
		// Fields
		[SerializeField]
		private string _moveToNextActionId; // 0x28
		[SerializeField]
		private string _moveToPreviousActionId; // 0x30
		[SerializeField]
		private bool _inverse; // 0x38
		[CompilerGenerated]
		private int _moveToNextBindingId_k__BackingField; // 0x3C
		[CompilerGenerated]
		private int _moveToPreviousBindingId_k__BackingField; // 0x40
	
		// Properties
		public int moveToNextBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86640-0x0000000184D86650 0x0000000184D86670-0x0000000184D86680
		public int moveToPreviousBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D865E0-0x0000000184D865F0 0x0000000184D86610-0x0000000184D86620
	
		// Constructors
		public UIToggleGroup(); // 0x00000001845C5DC0-0x00000001845C5E70
	
		// Methods
		protected override void Awake(); // 0x00000001849CE2A0-0x00000001849CE4C0
		protected override void OnEnable(); // 0x000000018481BF00-0x000000018481BFF0
		protected override void OnDisable(); // 0x000000018B0FBFFC-0x000000018B0FC0EC
		protected override void OnDestroy(); // 0x000000018B0FBF14-0x000000018B0FBFFC
		public void MoveToNext(); // 0x000000018B0FBE64-0x000000018B0FBEBC
		public void MoveToPrevious(); // 0x000000018B0FBEBC-0x000000018B0FBF14
		private void _MoveTo(bool isNext); // 0x000000018B0FC0EC-0x000000018B0FC4C8
		public void __iFixBaseProxy_Awake(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnEnable(); // 0x000000018481BFF0-0x000000018481C000
		public void __iFixBaseProxy_OnDisable(); // 0x00000001841E1670-0x00000001841E1680
		public void __iFixBaseProxy_OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
	}

	public enum FingerMoveDirection // TypeDefIndex: 50474
	{
		None = 0,
		Anisotropy = 1,
		Same = 2
	}

	[RequireComponent(typeof(Graphic))]
	public class UITouchPanel : TickableUIMono, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IUIClearable, IBindingGroupTarget // TypeDefIndex: 50475
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
		[CompilerGenerated]
		private Vector2 _curPressPos_k__BackingField; // 0x1B8
		[CompilerGenerated]
		private bool _isPointerEntered_k__BackingField; // 0x1C0
		public bool enableZoom; // 0x1C1
		public DisposedUnityEvent<PointerEventData> rawOnDrag; // 0x1C8
		private float m_leftMousePressDownTimeWithNoCursor; // 0x1D0
		private float m_rightMousePressDownTimeWithNoCursor; // 0x1D4
		private int m_groupId; // 0x1D8
		private bool m_bindingInit; // 0x1DC
		[CompilerGenerated]
		private InputBindingGroupMonoTarget _parent_k__BackingField; // 0x1E0
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001846BEF70-0x00000001846BEFA0 
		public Vector2 touchPos { get; } // 0x000000018B0FD1F0-0x000000018B0FD270 
		public Vector2 curPressPos { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184DAAFA0-0x0000000184DAAFC0 0x0000000184DAAFC0-0x0000000184DAAFD0
		public bool isPointerEntered { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8FB30-0x0000000184D8FB40 0x0000000184D8FC00-0x0000000184D8FC10
		public bool isDragging { get; } // 0x000000018B0FD100-0x000000018B0FD150 
		public bool isInGestureZoom { get; } // 0x000000018B0FD150-0x000000018B0FD1A0 
		public bool groupEnabled { get; } // 0x0000000183796660-0x00000001837966B0 
		public int groupId { get; } // 0x00000001837D5980-0x00000001837D59C0 
		public IBindingGroupTarget parentTarget { get; } // 0x000000018B0FD1A0-0x000000018B0FD1F0 
		public InputBindingGroupMonoTarget parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D8D930-0x0000000184D8D940 0x0000000186B8B2C4-0x0000000186B8B2D8
	
		// Constructors
		public UITouchPanel(); // 0x0000000183EB2CB0-0x0000000183EB3290
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData); // 0x00000001837D65E0-0x00000001837D66D0
		public void OnEndDrag(PointerEventData eventData); // 0x00000001837D66D0-0x00000001837D6750
		public void DoEndDrag(Vector2 dragPos); // 0x00000001837D6310-0x00000001837D6430
		public void OnDrag(PointerEventData eventData); // 0x00000001837D67E0-0x00000001837D6920
		public void OnPointerDown(PointerEventData eventData); // 0x00000001845D0D60-0x00000001845D0EA0
		public void OnPointerUp(PointerEventData eventData); // 0x00000001837D6920-0x00000001837D6A80
		public void OnPointerClick(PointerEventData eventData); // 0x0000000184A1A6D0-0x0000000184A1AAF0
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018379B570-0x000000018379B5C0
		public void OnPointerExit(PointerEventData eventData); // 0x000000018379B520-0x000000018379B570
		private void _OnActionPress(PointerEventData eventData); // 0x00000001845D0EA0-0x00000001845D14E0
		private void _OnActionRelease(PointerEventData eventData); // 0x00000001837D6A80-0x00000001837D6B90
		private bool _IsSameTouchFromPress(PointerEventData eventData); // 0x00000001837D6B90-0x00000001837D6BE0
		public void ClearTouchInfo(); // 0x00000001837D62A0-0x00000001837D6310
		public void OnScroll(PointerEventData eventData); // 0x000000018B0FCF20-0x000000018B0FD004
		public void SimulateClick(PointerEventData eventData); // 0x000000018B0FD004-0x000000018B0FD068
		public void DeActiveTouch(int touchId); // 0x000000018B0FCE6C-0x000000018B0FCF20
		protected override void OnAwake(); // 0x00000001837D5D30-0x00000001837D5DB0
		public override void Tick(float deltaTime); // 0x00000001833FEA50-0x00000001833FF0C0
		public override void LateTick(float deltaTime); // 0x00000001833FF0C0-0x00000001833FF1F0
		protected override void OnEnable(); // 0x00000001837D5CF0-0x00000001837D5D30
		protected override void OnDisable(); // 0x00000001837D6230-0x00000001837D62A0
		protected override void OnDestroy(); // 0x00000001837D58E0-0x00000001837D5980
		protected override void OnRelease(); // 0x000000018451EEB0-0x000000018451EEF0
		public void InitBinding(); // 0x00000001837D59C0-0x00000001837D5C10
		private void _UpdateState(); // 0x00000001837D5C10-0x00000001837D5CF0
		public void ClearComponent(); // 0x000000018451EEF0-0x000000018451F180
		[CompilerGenerated]
		private void _InitBinding_b__112_0(); // 0x000000018B0FD068-0x000000018B0FD0B4
		[CompilerGenerated]
		private void _InitBinding_b__112_1(); // 0x000000018B0FD0B4-0x000000018B0FD100
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnAwake(); // 0x0000000186C294C4-0x0000000186C294CC
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000181538B20-0x0000000181538B30
		public void __iFixBaseProxy_OnRelease(); // 0x00000001869AFD04-0x00000001869AFD0C
	}

	[DefaultExecutionOrder(10)]
	[ExecuteInEditMode]
	public class UIVFXManager : TickableUIMono, IMaterialModifier // TypeDefIndex: 50476
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
		protected override TickType tickOption { get; } // 0x000000018B0FDC54-0x000000018B0FDCA4 
		public Graphic graphic { get; } // 0x000000018B0FDAC4-0x000000018B0FDB8C 
		public UISoftMaskable softMaskable { get; } // 0x000000018B0FDB8C-0x000000018B0FDC54 
	
		// Constructors
		public UIVFXManager(); // 0x00000001849AF5D0-0x00000001849AF670
		static UIVFXManager(); // 0x0000000184D54A80-0x0000000184D54AD0
	
		// Methods
		protected override void OnEnable(); // 0x000000018B0FD464-0x000000018B0FD5EC
		public override void LateTick(float deltaTime); // 0x000000018B0FD270-0x000000018B0FD308
		private void _OnEnableRuntimeAtlas(); // 0x000000018B0FD824-0x000000018B0FD874
		protected override void OnDisable(); // 0x000000018B0FD308-0x000000018B0FD464
		private void _Clear(); // 0x000000018B0FD5EC-0x000000018B0FD79C
		private void _DestroyMaterial(Material material); // 0x000000018B0FD79C-0x000000018B0FD824
		private void _UpdateParam(); // 0x000000018B0FD874-0x000000018B0FDAC4
		public Material GetModifiedMaterial(Material baseMaterial); // 0x0000000184B093A0-0x0000000184B09460
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_OnEnable(); // 0x0000000181538B40-0x0000000181538B50
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000186BD8710-0x0000000186BD8718
		public void __iFixBaseProxy_OnDisable(); // 0x0000000181538B30-0x0000000181538B40
	}

	public class UIWorldLevelScrollListAnimCtrl : MonoBehaviour // TypeDefIndex: 50479
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
		public class ScrollListLayoutInfo // TypeDefIndex: 50477
		{
			// Fields
			public VerticalLayoutGroup layoutGroup; // 0x10
			public RectTransform layoutRectTransform; // 0x18
			public LayoutElement cell; // 0x20
	
			// Properties
			public float cellHeight { get; } // 0x000000018B0F801C-0x000000018B0F80FC 
	
			// Constructors
			public ScrollListLayoutInfo(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		[CompilerGenerated]
		private sealed class __ScrollLayouts_d__12 : IEnumerator<object> // TypeDefIndex: 50478
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public __ScrollLayouts_d__12(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B0F8414-0x000000018B0F8B48
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B0F8B48-0x000000018B0F8B94
		}
	
		// Constructors
		public UIWorldLevelScrollListAnimCtrl(); // 0x000000018B0FE100-0x000000018B0FE15C
	
		// Methods
		public void UpdateUpPos(int current); // 0x000000018B0FDEE4-0x000000018B0FDFA0
		public void UpdateDownPos(int current); // 0x000000018B0FDD14-0x000000018B0FDDF8
		public void UpdateMidPos(int current); // 0x000000018B0FDDF8-0x000000018B0FDEE4
		public void UpdateWorldLevelScrollList(bool isUp, int count); // 0x000000018B0FDFA0-0x000000018B0FE04C
		private void OnDisable(); // 0x000000018B0FDCA4-0x000000018B0FDD14
		[IteratorStateMachine(typeof(__ScrollLayouts_d__12))]
		private IEnumerator _ScrollLayouts(bool isUp, int count); // 0x000000018B0FE04C-0x000000018B0FE100
	}

	public class VirtualMouseInitPos : MonoBehaviour // TypeDefIndex: 50480
	{
		// Fields
		private LuaPanel m_panel; // 0x18
	
		// Properties
		public LuaPanel panel { get; } // 0x000000018B0FE2D8-0x000000018B0FE390 
	
		// Constructors
		public VirtualMouseInitPos(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnEnable(); // 0x000000018B0FE15C-0x000000018B0FE2D8
	}

	public class CSPopupPanel : MonoBehaviour // TypeDefIndex: 50481
	{
		// Fields
		public const string KEY = "CSPopupPanel"; // Metadata: 0x0232FD9A
		public UIButton confirmBtn; // 0x18
		public UIButton cancelBtn; // 0x20
		public UIText contentTxt; // 0x28
		public GameObject bg1; // 0x30
		public GameObject bg2; // 0x38
		public GameObject warningImg; // 0x40
		public UIScrollRect scrollRect; // 0x48
		private Action m_onConfirm; // 0x50
		private Action m_onCancel; // 0x58
		private FAssetProxyHandle m_handle; // 0x60
		public static HashSet<CSPopupPanel> s_instances; // 0x00
		public int timeScaleKey; // 0x74
	
		// Constructors
		public CSPopupPanel(); // 0x0000000185393520-0x0000000185393538
		static CSPopupPanel(); // 0x000000018B0F6AA0-0x000000018B0F6B2C
	
		// Methods
		private void Awake(); // 0x000000018B0F5FE0-0x000000018B0F6124
		private void _OnConfirm(PointerEventData p); // 0x000000018B0F69FC-0x000000018B0F6AA0
		private void _OnCancel(PointerEventData p); // 0x000000018B0F6958-0x000000018B0F69FC
		private void OnDestroy(); // 0x000000018B0F6318-0x000000018B0F64D4
		public static void Show(string content, Action onConfirm, bool showCancel = false /* Metadata: 0x0232FD98 */, Action onCancel = null, string confirmTxt = null, string cancelTxt = null, bool showWarning = false /* Metadata: 0x0232FD99 */); // 0x000000018B0F64D4-0x000000018B0F6958
		public static void ClearAllPanels(); // 0x000000018B0F6124-0x000000018B0F6318
	}

	public class LuaUIRoot : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 50482
	{
		// Fields
		public SerializeReferenceDictionary<string, LuaUIRootNode> nodeDic; // 0x18
	
		// Constructors
		public LuaUIRoot(); // 0x000000018B0F7CB8-0x000000018B0F7D38
	}

	public class LuaUIRootNode : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 50483
	{
		// Fields
		public string panelName; // 0x18
		public string panelFolder; // 0x20
	
		// Constructors
		public LuaUIRootNode(); // 0x0000000185393520-0x0000000185393538
	}

	public class MobileMotionManager : BaseManager // TypeDefIndex: 50485
	{
		// Fields
		private const string COMMON_MOTION_SHORT = "au_vibration_common_short"; // Metadata: 0x0232FDA7
		private const string COMMON_MOTION_OPERATE_SUCCESS = "au_vibration_common_action_success"; // Metadata: 0x0232FDC1
		private const string COMMON_MOTION_OPERATE_FAILURE = "au_vibration_common_action_fail"; // Metadata: 0x0232FDE4
		private const string MOTION_LEVEL_LOW = "au_motion_resolution_state_low"; // Metadata: 0x0232FE04
		private const string MOTION_LEVEL_MEDIUM = "au_motion_resolution_state_medium"; // Metadata: 0x0232FE23
		private const string MOTION_LEVEL_HIGH = "au_motion_resolution_state_high"; // Metadata: 0x0232FE45
		private MotionLevel m_currMotionLevel; // 0x18
	
		// Nested types
		private enum MotionLevel // TypeDefIndex: 50484
		{
			NONE = 0,
			LOW = 1,
			MEDIUM = 2,
			HIGH = 3
		}
	
		// Constructors
		public MobileMotionManager(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected override void OnInit(); // 0x0000000184A30330-0x0000000184A30440
		protected override void OnRelease(); // 0x000000018B0F7D38-0x000000018B0F7E48
		public uint PostEventCommonShort(); // 0x000000018B0F7F30-0x000000018B0F7FA4
		public uint PostEventCommonOperateSuccess(); // 0x000000018B0F7EBC-0x000000018B0F7F30
		public uint PostEventCommonOperateFailure(); // 0x000000018B0F7E48-0x000000018B0F7EBC
		public uint PostEvent(string eventName); // 0x000000018B0F7FA4-0x000000018B0F801C
		private void _CheckMotionLevelAndPostIfChange(); // 0x0000000184A30440-0x0000000184A304F0
	}

	public static class I18nFontLoader // TypeDefIndex: 50486
	{
		// Fields
		private static Dictionary<int, FAssetProxyHandle> s_id2FontDic; // 0x00
		private static Dictionary<string, FAssetProxyHandle> s_name2MaterialDic; // 0x08
		private static FAssetProxyHandle s_fontSearchDataHandle; // 0x10
	
		// Properties
		public static I18nFontSearchData fontSearchData { get; } // 0x000000018351E260-0x000000018351E3F0 
	
		// Constructors
		static I18nFontLoader(); // 0x0000000184CA41A0-0x0000000184CA4290
	
		// Methods
		public static bool IsInvalid(); // 0x000000018351E3F0-0x000000018351E520
		public static Material GetMaterial(string matName); // 0x000000018B0F7A6C-0x000000018B0F7CB8
		public static TMP_FontAsset GetI18nFont(int cnFontId); // 0x000000018351E1B0-0x000000018351E260
		public static TMP_FontAsset GetCNFont(int cnFontId); // 0x000000018B0F79F4-0x000000018B0F7A6C
		private static TMP_FontAsset _GetFontById(int fontId); // 0x000000018351E520-0x000000018351E890
		public static int GetCNFontId(TMP_FontAsset font); // 0x000000018B0F7954-0x000000018B0F79F4
		public static bool IsFontDefaultMaterial(Material mat); // 0x00000001846BB800-0x00000001846BB8A0
	}

	public class DynamicFontAssetLoader : IFontAssetLoader // TypeDefIndex: 50488
	{
		// Fields
		[CompilerGenerated]
		private List<FontAssetRef> _fontAssets_k__BackingField; // 0x10
		private static HashSet<uint> s_notFoundUnicodes; // 0x00
	
		// Properties
		public List<FontAssetRef> fontAssets { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
		// Nested types
		public class FontAssetRef // TypeDefIndex: 50487
		{
			// Fields
			public I18nFontSearchData.FontAssetInfo fontAssetInfo; // 0x10
			private HashSet<TMP_Text> m_refTexts; // 0x18
			private FAssetProxyHandle m_assetHandle; // 0x20
			private TMP_FontAsset m_fontAsset; // 0x38
	
			// Constructors
			public FontAssetRef(); // 0x0000000184659420-0x00000001846594A0
	
			// Methods
			public TMP_FontAsset GetFontAsset(TMP_Text refText); // 0x000000018B0F76C4-0x000000018B0F785C
			public void RemoveRefText(TMP_Text refText); // 0x000000018B0F785C-0x000000018B0F7954
			public void Dispose(); // 0x000000018B0F7614-0x000000018B0F76C4
		}
	
		// Constructors
		public DynamicFontAssetLoader(); // 0x0000000184659250-0x0000000184659420
		static DynamicFontAssetLoader(); // 0x0000000184D18450-0x0000000184D184E0
	
		// Methods
		public static void AddNotFoundUnicode(uint unicode, bool forceLog = false /* Metadata: 0x0232FE69 */); // 0x0000000184A12CA0-0x0000000184A12E60
		public bool TryGetFontAsset(TMP_Text refText, uint unicode, out TMP_FontAsset fontAsset); // 0x000000018B0F6CD0-0x000000018B0F7128
		public void TryRemoveRefText(TMP_Text refText); // 0x000000018B0F7128-0x000000018B0F7294
		public void Dispose(); // 0x000000018B0F6B2C-0x000000018B0F6CD0
	}

	public static class TweenUtils // TypeDefIndex: 50490
	{
		// Nested types
		public struct FLerpByTime // TypeDefIndex: 50489
		{
			// Fields
			public static FLerpByTime EMPTY; // 0x00
			[CompilerGenerated]
			private bool _isEmpty_k__BackingField; // 0x00
			private FScaledStopwatch m_timer; // 0x08
			public float startValue; // 0x20
			public float endValue; // 0x24
			public float duration; // 0x28
	
			// Properties
			public bool isEmpty { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D883E0-0x0000000184D883F0 0x0000000184D87180-0x0000000184D87190
	
			// Constructors
			static FLerpByTime(); // 0x000000018B0F741C-0x000000018B0F7484
	
			// Methods
			public void Start(ITickOwner timeScaleProvider = null); // 0x000000018B0F73B8-0x000000018B0F741C
			public float GetValue(out bool isTweenFinished); // 0x000000018B0F7294-0x000000018B0F73B8
		}
	
		// Methods
		public static bool TickAsCountDown(ref float countDown, float timeDelta); // 0x0000000182F44780-0x0000000182F44DE0
	}

	public class UIAnimationLayerMixPlayer : SingleMixerAssetPlayer<AnimationClip, AnimationClipPlayable, AnimationLayerMixerPlayable, AnimationPlayableOutput> // TypeDefIndex: 50491
	{
		// Fields
		private Animator m_target; // 0x60
		private string m_outputName; // 0x68
	
		// Constructors
		public UIAnimationLayerMixPlayer(Animator target, string outputName); // 0x0000000183D502F0-0x0000000183D50360
	
		// Methods
		public void LockToClip(AnimationClip clip, float clipPos); // 0x0000000183D4F830-0x0000000183D4F930
		protected override PlayableGraph CreateGraph(); // 0x000000018421E7C0-0x000000018421E810
		protected override AnimationLayerMixerPlayable CreateMixer(PlayableGraph graph, out FMixerOptions<AnimationClip> options); // 0x0000000184398AF0-0x0000000184398BE0
		protected override AnimationPlayableOutput CreateOutput(PlayableGraph graph); // 0x0000000184D31C50-0x0000000184D31CC0
		protected override AnimationClipPlayable CreateSourceFromAsset(AnimationClip clip, PlayableGraph graph, out FPlayableMeta<AnimationClip> meta); // 0x0000000183431700-0x00000001834317E0
	}

	public class UIAnimationMixPlayer : SingleMixerAssetPlayer<AnimationClip, AnimationClipPlayable, AnimationMixerPlayable, AnimationPlayableOutput> // TypeDefIndex: 50492
	{
		// Fields
		private Animator m_target; // 0x60
		private string m_outputName; // 0x68
	
		// Constructors
		public UIAnimationMixPlayer(Animator target, string outputName); // 0x0000000183D50170-0x0000000183D501E0
	
		// Methods
		public void LockToClip(AnimationClip clip, float clipPos); // 0x0000000183D501E0-0x0000000183D502F0
		protected override PlayableGraph CreateGraph(); // 0x000000018421E810-0x000000018421E860
		protected override AnimationMixerPlayable CreateMixer(PlayableGraph graph, out FMixerOptions<AnimationClip> options); // 0x0000000183E0FD50-0x0000000183E0FE10
		protected override AnimationPlayableOutput CreateOutput(PlayableGraph graph); // 0x0000000183FC8990-0x0000000183FC8A00
		protected override AnimationClipPlayable CreateSourceFromAsset(AnimationClip clip, PlayableGraph graph, out FPlayableMeta<AnimationClip> meta); // 0x00000001834319D0-0x0000000183431AB0
	}

	public class UIListCache<TComp> // TypeDefIndex: 50495
		where TComp : Component
	{
		// Fields
		private FOptions m_options;
		private List<ItemWrapper> m_items;
		private int m_count;
	
		// Nested types
		public struct FOptions // TypeDefIndex: 50493
		{
			// Fields
			public TComp cellTemplate;
			public Transform parent;
			public Action<TComp> onItemCreated;
		}
	
		private class ItemWrapper // TypeDefIndex: 50494
		{
			// Fields
			public TComp comp;
	
			// Constructors
			public ItemWrapper();
		}
	
		// Constructors
		public UIListCache(FOptions options);
	
		// Methods
		public void Refresh(int count, Action<TComp, int> refreshFunc, bool shouldHide = false /* Metadata: 0x0232FE6A */, Action<TComp, int> onDisableFunc = null);
		public TComp GetItem(int index);
		private ItemWrapper _CreateNewItem();
	}

	public class UILoadImageSprite : MonoBehaviour // TypeDefIndex: 50497
	{
		// Fields
		public bool isAsync; // 0x18
		public bool setNativeSize; // 0x19
		protected string m_spritePath; // 0x20
		protected Image m_imageComp; // 0x28
		protected FAssetProxyHandle m_handle; // 0x30
	
		// Properties
		public string spritePath { get; set; } // 0x000000018B0F8FC8-0x000000018B0F9018 0x000000018B0F9018-0x000000018B0F909C
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 50496
		{
			// Fields
			public UILoadImageSprite __4__this; // 0x10
			public string path; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void __LoadSprite_b__0(bool isOk, FAssetProxyHandle handle); // 0x000000018B0F81F4-0x000000018B0F8378
		}
	
		// Constructors
		public UILoadImageSprite(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnDestroy(); // 0x000000018B0F8C3C-0x000000018B0F8C9C
		private void _LoadSprite(string path); // 0x000000018B0F8C9C-0x000000018B0F8FC8
	}

	public class UILoadImageSpriteByName : UILoadImageSprite // TypeDefIndex: 50498
	{
		// Fields
		[SerializeField]
		private string _folderPath; // 0x48
	
		// Properties
		public string spriteName { set; } // 0x000000018B0F8B94-0x000000018B0F8C3C
	
		// Constructors
		public UILoadImageSpriteByName(); // 0x0000000183695570-0x0000000183695590
	}

	public abstract class UISwitchTween // TypeDefIndex: 50505
	{
		// Fields
		private Options m_options; // 0x10
		private ITweenHandler m_tween; // 0x20
		private bool m_isInited; // 0x28
		private bool m_isShowing; // 0x29
		private TweenContext m_context; // 0x2C
	
		// Properties
		public bool isTweening { get; } // 0x0000000183405A30-0x0000000183405A90 
		public bool isShow { get; set; } // 0x0000000184B48120-0x0000000184B48210 0x0000000183406FE0-0x0000000183407030
	
		// Nested types
		public struct Options // TypeDefIndex: 50499
		{
			// Fields
			[CompilerGenerated]
			private Action _onShown_k__BackingField; // 0x00
			[CompilerGenerated]
			private Action _onHiden_k__BackingField; // 0x08
	
			// Properties
			public Action onShown { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B76770-0x0000000182B76780 0x0000000185392320-0x0000000185392328
			public Action onHiden { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D88320-0x0000000184D88330 0x00000001867D5E9C-0x00000001867D5EAC
		}
	
		protected struct TweenContext // TypeDefIndex: 50500
		{
			// Fields
			public float lastStopPos; // 0x00
	
			// Methods
			public bool IsInterapted(); // 0x000000018B0F80FC-0x000000018B0F8190
			public void OnReset(); // 0x00000001834059B0-0x00000001834059E0
			public void OnTweenStop(ITweenProgress tweenProgress); // 0x0000000183405950-0x00000001834059B0
		}
	
		public interface ITweenHandler : IHotfixable // TypeDefIndex: 50501
		{
			// Methods
			ITweenHandler SetAutoKill(bool autoKill);
			ITweenHandler OnComplete(TweenCallback callback);
			bool IsPlaying();
			void KillIfNecessary();
		}
	
		public interface ITweenProgress : IHotfixable // TypeDefIndex: 50502
		{
			// Methods
			float GetCurrPos();
		}
	
		public class TweenWrapper : ITweenHandler // TypeDefIndex: 50503
		{
			// Fields
			private DG.Tweening.Tween m_tween; // 0x10
	
			// Constructors
			public TweenWrapper(DG.Tweening.Tween tween); // 0x00000001853908C0-0x00000001853908D0
	
			// Methods
			public bool IsActive(); // 0x000000018B0F8190-0x000000018B0F81F4
			public bool IsPlaying(); // 0x00000001834059E0-0x0000000183405A30
			public void KillIfNecessary(); // 0x00000001834057A0-0x00000001834057E0
			public ITweenHandler OnComplete(TweenCallback callback); // 0x0000000183405BA0-0x0000000183405C10
			public ITweenHandler SetAutoKill(bool autoKill); // 0x0000000183405B00-0x0000000183405BA0
		}
	
		[CompilerGenerated]
		private sealed class _WaitForTweening_d__19 : IEnumerator<object> // TypeDefIndex: 50504
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UISwitchTween __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForTweening_d__19(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B0F8378-0x000000018B0F83C8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B0F83C8-0x000000018B0F8414
		}
	
		// Constructors
		protected UISwitchTween(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected abstract ITweenHandler GenerateTweenOfShow();
		protected abstract ITweenHandler GenerateTweenOfHide();
		protected virtual void BeforeShowEffect(); // 0x000000018B0FB57C-0x000000018B0FB5C0
		protected virtual void BeforeHideEffect(); // 0x0000000183405A90-0x0000000183405B00
		protected virtual void AfterShowEffect(); // 0x0000000184A3B9B0-0x0000000184A3B9E0
		protected virtual void AfterHideEffect(); // 0x000000018B0FB538-0x000000018B0FB57C
		protected virtual void ResetToState(bool isShow); // 0x000000018B0FB60C-0x000000018B0FB660
		public void Show(); // 0x0000000183405CC0-0x0000000183405DE0
		public void Hide(); // 0x0000000183407030-0x0000000183407160
		[IteratorStateMachine(typeof(_WaitForTweening_d__19))]
		public IEnumerator WaitForTweening(); // 0x000000018B0FB6D4-0x000000018B0FB764
		public void SetOptions(Options options); // 0x000000018B0FB660-0x000000018B0FB6D4
		public void Reset(bool isShow); // 0x00000001834057E0-0x0000000183405840
		public void Clear(); // 0x00000001848AB730-0x00000001848AB770
		private void _ClearTweenInternal(bool isReset); // 0x0000000183405840-0x00000001834058E0
		protected TweenContext GetContext(); // 0x000000018B0FB5C0-0x000000018B0FB60C
		protected void ClearTween(); // 0x00000001834058E0-0x0000000183405950
		[CompilerGenerated]
		private void _Show_b__17_0(); // 0x0000000184A3B980-0x0000000184A3B9B0
		[CompilerGenerated]
		private void _Hide_b__18_0(); // 0x0000000184CB2740-0x0000000184CB2770
	}

	public class FadeSwitchTween : UISwitchTween // TypeDefIndex: 50508
	{
		// Fields
		public const float DEFAULT_TWEEN_DURATION = 0.16f; // Metadata: 0x0232FE70
		private CanvasGroup m_alphaHandler; // 0x30
		private bool m_ignoreTimeScale; // 0x38
		private float m_activeAlpha; // 0x3C
		[CompilerGenerated]
		private bool _dontDisableGameObject_k__BackingField; // 0x40
		[CompilerGenerated]
		private bool _controlBlockRaycast_k__BackingField; // 0x41
		[CompilerGenerated]
		private Durations _complexDuration_k__BackingField; // 0x44
		[CompilerGenerated]
		private float _duration_k__BackingField; // 0x54
	
		// Properties
		protected bool dontDisableGameObject { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182D480A0-0x0000000182D480B0 0x0000000182D480B0-0x0000000182D480C0
		protected bool controlBlockRaycast { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86F40-0x0000000184D86F50 0x0000000184D86F60-0x0000000184D86F70
		protected Durations complexDuration { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184DAAF10-0x0000000184DAAF20 0x0000000184DAAF20-0x0000000184DAAF30
		public float duration { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86E00-0x0000000184D86E10 0x0000000184D86E10-0x0000000184D86E20
		public CanvasGroup alphaHandler { get; } // 0x000000018B0F7548-0x000000018B0F7598 
		public float activeAlpha { get; set; } // 0x000000018B0F74F8-0x000000018B0F7548 0x000000018B0F7598-0x000000018B0F7614
	
		// Nested types
		public struct Durations // TypeDefIndex: 50506
		{
			// Fields
			public float show; // 0x00
			public float showDelay; // 0x04
			public float hide; // 0x08
			public float hideDelay; // 0x0C
	
			// Methods
			public float GetShowDuration(float defaultDuration); // 0x00000001845924A0-0x00000001845924E0
			public float GetHideDuration(float defaultDuration); // 0x00000001845924E0-0x0000000184592520
		}
	
		public struct Builder // TypeDefIndex: 50507
		{
			// Fields
			public CanvasGroup alphaHandler; // 0x00
			public bool useTimeScale; // 0x08
			public bool dontDisableGameObject; // 0x09
			public bool controlBlockRaycast; // 0x0A
			public float duration; // 0x0C
			public Durations complexDuration; // 0x10
	
			// Methods
			public FadeSwitchTween Build(); // 0x0000000183F0F420-0x0000000183F0F500
		}
	
		// Constructors
		public FadeSwitchTween(CanvasGroup alphaHandler, bool ignoreTimeScale); // 0x000000018B0F74D4-0x000000018B0F74F8
		public FadeSwitchTween(CanvasGroup alphaHandler, float duration = 0.16f /* Metadata: 0x0232FE6B */, bool ignoreTimeScale = true /* Metadata: 0x0232FE6F */); // 0x0000000183F0F500-0x0000000183F0F600
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide(); // 0x0000000184590660-0x0000000184591580
		protected override ITweenHandler GenerateTweenOfShow(); // 0x0000000184591580-0x00000001845924A0
		protected sealed override void BeforeShowEffect(); // 0x000000018450BA10-0x000000018450BA70
		protected sealed override void AfterHideEffect(); // 0x000000018450BA70-0x000000018450BAB0
		protected sealed override void ResetToState(bool isShow); // 0x000000018450BAB0-0x000000018450BB20
		protected virtual void SetObjectActive(CanvasGroup alphaHandler, bool isActive); // 0x000000018450BB20-0x000000018450BB90
		public void Release(); // 0x000000018B0F7484-0x000000018B0F74D4
		public void __iFixBaseProxy_BeforeShowEffect(); // 0x000000018B0C1AA0-0x000000018B0C1AA8
		public void __iFixBaseProxy_AfterHideEffect(); // 0x000000018B0C1A98-0x000000018B0C1AA0
		public void __iFixBaseProxy_ResetToState(bool P0); // 0x000000018B0C1AA8-0x000000018B0C1AB0
	}

	public class FadeTranslationSwitchTween : UISwitchTween // TypeDefIndex: 50510
	{
		// Fields
		private const float DEFAULT_TWEEN_DURATION = 0.16f; // Metadata: 0x0232FE80
		private CanvasGroup m_alphaHandler; // 0x30
		private RectTransform m_posHandler; // 0x38
		private Vector2 m_hidePos; // 0x40
		private Vector2 m_showPos; // 0x48
		private float m_duration; // 0x50
		private float m_hideDelay; // 0x54
		private float m_showDelay; // 0x58
	
		// Nested types
		private class TweenHandler : UISwitchTween.ITweenHandler // TypeDefIndex: 50509
		{
			// Fields
			private DG.Tweening.Tween m_alphaTweener; // 0x10
			private DG.Tweening.Tween m_posTweener; // 0x18
	
			// Constructors
			public TweenHandler(DG.Tweening.Tween alpha, DG.Tweening.Tween pos); // 0x00000001832AF420-0x00000001832AF450
	
			// Methods
			public bool IsPlaying(); // 0x000000018B103BBC-0x000000018B103C24
			public void KillIfNecessary(); // 0x000000018B103C24-0x000000018B103CAC
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback); // 0x000000018B103CAC-0x000000018B103D34
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill); // 0x000000018B103D34-0x000000018B103DD0
		}
	
		// Constructors
		public FadeTranslationSwitchTween(CanvasGroup alphaHandler, RectTransform posHandler, Vector2 hidePos, Vector2 showPos, float duration = 0.16f /* Metadata: 0x0232FE74 */, float hideDelay = 0f /* Metadata: 0x0232FE78 */, float showDelay = 0f /* Metadata: 0x0232FE7C */); // 0x000000018B0FEA50-0x000000018B0FEB5C
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide(); // 0x000000018B0FE62C-0x000000018B0FE76C
		protected override ITweenHandler GenerateTweenOfShow(); // 0x000000018B0FE76C-0x000000018B0FE8AC
		protected override void BeforeShowEffect(); // 0x000000018B0FE5C8-0x000000018B0FE62C
		protected override void AfterHideEffect(); // 0x000000018B0FE564-0x000000018B0FE5C8
		protected override void ResetToState(bool isShow); // 0x000000018B0FE8AC-0x000000018B0FE970
		private float _GetTargetAlpha(bool isShow); // 0x000000018B0FE970-0x000000018B0FE9D8
		private Vector2 _GetTargetPos(bool isShow); // 0x000000018B0FE9D8-0x000000018B0FEA50
		public void __iFixBaseProxy_BeforeShowEffect(); // 0x000000018B0C1AA0-0x000000018B0C1AA8
		public void __iFixBaseProxy_AfterHideEffect(); // 0x000000018B0C1A98-0x000000018B0C1AA0
		public void __iFixBaseProxy_ResetToState(bool P0); // 0x000000018B0C1AA8-0x000000018B0C1AB0
	}

	public class UIAtlasManager : Singleton<UIAtlasManager> // TypeDefIndex: 50516
	{
		// Fields
		private TickFunction m_lateTickFunction; // 0x10
		public const int ATLAS_PAGE_WIDTH = 2048; // Metadata: 0x0232FE84
		public const int ATLAS_PAGE_HEIGHT = 1024; // Metadata: 0x0232FE86
		public const int IMAGE_USING_ATLAS_MAX_SIZE = 512; // Metadata: 0x0232FE88
		public const int UI_IMAGE_BLOCK_ALIGNMENT = 4; // Metadata: 0x0232FE8A
		public const int PANEL_LEVEL_COUNT = 4; // Metadata: 0x0232FE8B
		public const int MAX_ATLAS_PER_PANEL_LEVEL = 4; // Metadata: 0x0232FE8C
		public const int PROCESS_COUNT_PER_FRAME = 3; // Metadata: 0x0232FE8D
		public const GraphicsFormat ATLAS_PAGE_FORMAT = GraphicsFormat.RGBA_BC7_UNorm; // Metadata: 0x0232FE8E
		private bool m_enableRuntimeAtlas; // 0x18
		private Dictionary<int, UIImage> m_imageDict; // 0x20
		private UIAtlasPage[,] m_atlasPagePool; // 0x28
		private Queue<UIImage> m_insertQueue; // 0x30
		private Queue<UIAtlasHandle> m_freeQueue; // 0x38
		private CommandBuffer m_commandBuffer; // 0x40
		private GraphicsFormat m_atlasPageFormat; // 0x48
		[CompilerGenerated]
		private static bool _enableRuntimeAtlasFromScript_k__BackingField; // 0x00
	
		// Properties
		public static bool enableRuntimeAtlas { get; } // 0x00000001831EB7B0-0x00000001831EB820 
		public static bool enableRuntimeAtlasFromScript { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018B105ADC-0x000000018B105B14 0x000000018B105B54-0x000000018B105B90
		public static bool releaseImageSpriteAfterInsert { get; } // 0x000000018B105B14-0x000000018B105B54 
	
		// Nested types
		public enum UIAtlasProcessStatus // TypeDefIndex: 50511
		{
			Invalid = 0,
			InsertWaiting = 1,
			InsertDone = 2
		}
	
		public enum UIAtlasProcessFailureCause // TypeDefIndex: 50512
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
	
		public struct UIAtlasHandle // TypeDefIndex: 50513
		{
			// Fields
			public UIAtlasProcessStatus status; // 0x00
			public UIAtlasProcessFailureCause failureCause; // 0x04
			public int panelLevel; // 0x08
			public int atlasIndex; // 0x0C
			public RectInt atlasRect; // 0x10
			public int textureId; // 0x20
	
			// Constructors
			public UIAtlasHandle(UIAtlasProcessStatus status, UIAtlasProcessFailureCause failureCause, int panelLevel, int atlasIndex, RectInt atlasRect, int textureId); // 0x0000000184DAAFD0-0x0000000184DAB000
	
			// Methods
			public bool IsValid(); // 0x000000018B103FD0-0x000000018B104020
			public static UIAtlasHandle CreateInvalidHandle(UIAtlasProcessFailureCause cause = UIAtlasProcessFailureCause.NoFailure /* Metadata: 0x0232FEA2 */); // 0x0000000183696CD0-0x0000000183696D70
		}
	
		public class UIAtlasPage // TypeDefIndex: 50515
		{
			// Fields
			[CompilerGenerated]
			private readonly Texture2D _pageTexture_k__BackingField; // 0x10
			[CompilerGenerated]
			private readonly Dictionary<int, TextureRefHandle> _textureRefDict_k__BackingField; // 0x18
			[CompilerGenerated]
			private readonly AtlasMaxRect _rectBinPack_k__BackingField; // 0x20
	
			// Properties
			public int maxFreeRectWidth { get; } // 0x000000018B106128-0x000000018B106180 
			public int maxFreeRectHeight { get; } // 0x000000018B1060D0-0x000000018B106128 
			public Texture2D pageTexture { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
			public Dictionary<int, TextureRefHandle> textureRefDict { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
			public AtlasMaxRect rectBinPack { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
	
			// Nested types
			public struct TextureRefHandle // TypeDefIndex: 50514
			{
				// Fields
				public int refCount; // 0x00
				public RectInt rect; // 0x04
	
				// Constructors
				public TextureRefHandle(int refCount, RectInt rect); // 0x0000000184D9C150-0x0000000184D9C160
			}
	
			// Constructors
			public UIAtlasPage(int panelDepth, int index, GraphicsFormat atlasFormat); // 0x000000018B105F40-0x000000018B1060D0
	
			// Methods
			public RectInt InsertRect(int width, int height); // 0x000000018B105E14-0x000000018B105EB8
			public void CopyIntoAtlas(CommandBuffer cmd, Texture texture, [IsReadOnly] in RectInt rect); // 0x000000018B105B90-0x000000018B105D3C
			public void InsertRects(List<RectInt> rects, List<RectInt> dst); // 0x000000018B105EB8-0x000000018B105F40
			public void FreeRect([IsReadOnly] in RectInt rect); // 0x000000018B105D3C-0x000000018B105DA8
			public void FreeRects([IsReadOnly] in List<RectInt> rects); // 0x000000018B105DA8-0x000000018B105E14
		}
	
		// Constructors
		private UIAtlasManager(); // 0x000000018B105AA4-0x000000018B105ADC
	
		// Methods
		protected void OnInit(); // 0x000000018B1041D0-0x000000018B1043D0
		protected void OnUnInit(); // 0x000000018B1043D0-0x000000018B104420
		public void Release(); // 0x000000018B1044A4-0x000000018B1044F4
		private void _CreateTickFunction(); // 0x000000018B104948-0x000000018B104A70
		private void _ClearTickFunction(); // 0x000000018B1048E0-0x000000018B104948
		public static void AddUIImageToManager(UIImage image); // 0x000000018B104020-0x000000018B1040A4
		public static void ReProcessInsertForUIImage(UIImage image); // 0x000000018B104420-0x000000018B1044A4
		public static void RemoveUIImageFromManager(UIImage image); // 0x00000001830942B0-0x0000000183094330
		public static void AddUIImageToManagerOnInstantiate(UIImage image); // 0x0000000183093730-0x0000000183093770
		public int GetAtlasCount(); // 0x000000018B1040A4-0x000000018B104168
		public void LateTick(float deltaTime); // 0x000000018B104168-0x000000018B1041D0
		private void _AddUIImageToManager(UIImage image); // 0x000000018B1047E0-0x000000018B1048E0
		private void _ReProcessInsertForUIImage(UIImage image); // 0x000000018B1057B8-0x000000018B105930
		private void _RemoveUIImageFromManager(UIImage image); // 0x000000018B105930-0x000000018B105AA4
		private void _AddUIImageToManagerOnInstantiate(UIImage image); // 0x000000018B1044F4-0x000000018B1047E0
		private bool _IsRuntimeAtlasCompatible(UIImage image, out UIAtlasProcessFailureCause failureCause); // 0x000000018B104A70-0x000000018B104D84
		private void _ProcessInsertQueue(); // 0x000000018B104D84-0x000000018B1054F8
		private void _ProcessRemoveQueue(); // 0x000000018B1054F8-0x000000018B1057B8
	}

	public class UIRedDotAnimation : Singleton<UIRedDotAnimation> // TypeDefIndex: 50517
	{
		// Fields
		private UIGraphicAnimation m_uiGraphicAnimation; // 0x10
		private Material m_materialInstance; // 0x18
		private HashSet<UIImage> m_redDotImages; // 0x20
		private GameObject m_root; // 0x28
	
		// Constructors
		private UIRedDotAnimation(); // 0x0000000184D216F0-0x0000000184D21780
	
		// Methods
		public void Init(GameObject redDotAnimationRoot); // 0x0000000184958250-0x00000001849585B0
		public void UnInit(); // 0x000000018B106180-0x000000018B106338
		public void AddRedDotImage(UIImage img); // 0x00000001835766D0-0x0000000183576770
		public void RemoveRedDotImage(UIImage img); // 0x0000000183576170-0x00000001835761E0
		private void _UpdateRedDotAnimation(); // 0x0000000183576770-0x00000001835767C0
	}

	public class UIRedDotAnimationNode : MonoBehaviour // TypeDefIndex: 50518
	{
		// Fields
		private UIImage m_image; // 0x18
	
		// Constructors
		public UIRedDotAnimationNode(); // 0x0000000183695570-0x0000000183695590
	
		// Methods
		private void Awake(); // 0x000000018459E060-0x000000018459E0B0
		private void OnEnable(); // 0x0000000183576640-0x00000001835766D0
		private void OnDisable(); // 0x00000001835761E0-0x0000000183576270
	}

	public static class WebApplication // TypeDefIndex: 50521
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 50519
		{
			// Fields
			public string url; // 0x10
			public Action onClose; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _Start_b__0(int i, string s); // 0x000000018B103DE8-0x000000018B103EE0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 50520
		{
			// Fields
			public string url; // 0x10
			public Action onClose; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _StartHGBrowser_b__0(string s); // 0x000000018B103EE0-0x000000018B103FD0
		}
	
		// Methods
		public static void Start(string url, Action onClose = null); // 0x000000018B106B6C-0x000000018B106E00
		public static void StartHGBrowser(string url, Action onClose = null); // 0x000000018B1069A0-0x000000018B106B6C
	}
}

namespace Beyond.UI.GPUI
{
	[Flags]
	internal enum ChangeState // TypeDefIndex: 50540
	{
		Stable = 0,
		New = 1,
		ChangeSize = 2,
		ChangeData = 4
	}

	internal struct RuntimeNodeInfo // TypeDefIndex: 50541
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

	internal class RuntimeAnimationData // TypeDefIndex: 50542
	{
		// Fields
		public string name; // 0x10
		public float duration; // 0x18
		public List<GPUInstanceData> template; // 0x20
	
		// Constructors
		public RuntimeAnimationData(); // 0x000000018363C7C0-0x000000018363C860
	}

	internal class RuntimePrefabData // TypeDefIndex: 50543
	{
		// Fields
		public int templateNodeCount; // 0x10
		public List<RuntimeNodeInfo> nodes; // 0x18
		public Dictionary<string, int> nodesNameMap; // 0x20
		public List<RuntimeAnimationData> animations; // 0x28
	
		// Constructors
		public RuntimePrefabData(); // 0x00000001845ABD20-0x00000001845ABE40
	}

	public struct GPUIExtendedPrefabData // TypeDefIndex: 50544
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
		public int materialParam1; // 0x4C
		public float aniFillV; // 0x50
		public byte fillType; // 0x54
		public byte fillOriginFlags; // 0x55
		public byte wrapMode; // 0x56
		public byte fillReserved; // 0x57
		public Vector2 padding; // 0x58
		public const float INVALID_ANI_FILL_V = -1f; // Metadata: 0x0232FEEC
		public const byte WRAP_MODE_CLAMP = 0; // Metadata: 0x0232FEF0
		public const byte WRAP_MODE_LOOP = 1; // Metadata: 0x0232FEF1
		public const byte FILL_ORIGIN_MASK = 15; // Metadata: 0x0232FEF2
		public const byte FILL_CLOCKWISE_BIT = 16; // Metadata: 0x0232FEF3
	
		// Constructors
		public GPUIExtendedPrefabData(ExtendedNodeSerializeData data); // 0x000000018357E0C0-0x000000018357E1B0
	
		// Methods
		private static byte _NormalizeWrapMode(UnityEngine.WrapMode wrapMode); // 0x000000018357E1B0-0x000000018357E1E0
		private static byte _PackFillOriginFlags(int fillOrigin, bool fillClockwise); // 0x000000018357E1E0-0x000000018357E230
		public static GPUIExtendedPrefabData CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x0000000184460600-0x00000001844606C0
	}

	public struct GPUIExtendedPrefabDataLite // TypeDefIndex: 50545
	{
		// Fields
		public uint pack0; // 0x00
		public uint pack1; // 0x04
		public uint pack2; // 0x08
		public uint pack3; // 0x0C
		public uint pack4; // 0x10
		public uint pack5; // 0x14
		public uint pack6; // 0x18
		public uint pack7; // 0x1C
		public uint pack8; // 0x20
		public uint pack9; // 0x24
		public uint pack10; // 0x28
		public uint padding; // 0x2C
		private const int FILL_TYPE_SHIFT = 0; // Metadata: 0x0232FEF4
		private const int FILL_ORIGIN_SHIFT = 4; // Metadata: 0x0232FEF5
		private const int FILL_CLOCKWISE_SHIFT = 8; // Metadata: 0x0232FEF6
		private const int WRAP_MODE_SHIFT = 9; // Metadata: 0x0232FEF7
		private const ushort FILL_META_MASK = 15; // Metadata: 0x0232FEF8
	
		// Constructors
		public GPUIExtendedPrefabDataLite(ExtendedNodeSerializeData data, Vector2 texelSizeInv, Vector2 aniTexelSizeInv); // 0x000000018B0FF4FC-0x000000018B0FF87C
		public GPUIExtendedPrefabDataLite(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x000000018B0FF3D0-0x000000018B0FF4FC
	
		// Methods
		private static byte _NormalizeWrapMode(UnityEngine.WrapMode wrapMode); // 0x000000018B0FF380-0x000000018B0FF3D0
		public static GPUIExtendedPrefabDataLite CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x000000018B0FF28C-0x000000018B0FF380
	}

	public struct GPUIExtendedInstanceData // TypeDefIndex: 50546
	{
		// Fields
		public float timingOrScaleX; // 0x00
		public uint colorOrScaleYPacked; // 0x04
		public Vector2 position; // 0x08
		public ushort prefabId; // 0x10
		public ushort parentId; // 0x12
		public ushort grandParentId; // 0x14
		public byte matType; // 0x16
		public byte drawType; // 0x17
		public int auxiliaryData0; // 0x18
		public int auxiliaryData1; // 0x1C
		public const ushort INVALID_NODE_ID = 65535; // Metadata: 0x0232FEFA
		public const byte INVALID_FILL_OVERRIDE = 255; // Metadata: 0x0232FEFC
	}

	public struct GPUIRootTransformState // TypeDefIndex: 50547
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Vector3 scale; // 0x1C
	
		// Properties
		public static GPUIRootTransformState Default { get; } // 0x0000000183AA9D50-0x0000000183AA9DD0 
	}

	public struct GPUISubrootDomainState // TypeDefIndex: 50548
	{
		// Fields
		public Vector2 position; // 0x00
		public Vector2 scale; // 0x08
		public float rotationZ; // 0x10
		public bool visible; // 0x14
	
		// Properties
		public static GPUISubrootDomainState Default { get; } // 0x0000000182FA9C00-0x0000000182FA9CA0 
	}

	public struct GPUIExtendedAnimationState // TypeDefIndex: 50549
	{
		// Fields
		public int animationIndex; // 0x00
		public float animationTime; // 0x04
		public float animationDuration; // 0x08
		public bool initialized; // 0x0C
	
		// Properties
		public static GPUIExtendedAnimationState Default { get; } // 0x0000000184CA29C0-0x0000000184CA2A10 
	}

	public struct GPUIExtendedSubrootInfo // TypeDefIndex: 50550
	{
		// Fields
		public string subrootName; // 0x00
		public int anchorNodeIndex; // 0x08
	}

	public struct GPUIResolvedSubrootState // TypeDefIndex: 50551
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Vector3 scale; // 0x1C
		public bool visible; // 0x28
	}

	public static class GPUIExtendedTransformUtility // TypeDefIndex: 50552
	{
		// Methods
		public static GPUIResolvedSubrootState ResolveSubroot([IsReadOnly] in GPUIRootTransformState root, [IsReadOnly] in GPUISubrootDomainState subroot); // 0x0000000183AB7310-0x0000000183AB7740
	}

	public struct GPUIExtendedRuntimeNodeInfo // TypeDefIndex: 50553
	{
		// Fields
		public Beyond.UI.GPUI.NodeType nodeType; // 0x00
		public SimpleTextAlignment textAlignment; // 0x04
		public int nodeIndex; // 0x08
		public int childNodeCount; // 0x0C
		public int subrootIndex; // 0x10
		public uint color; // 0x14
		public Vector2 position; // 0x18
		public Vector2 scale; // 0x20
		public float rotationZ; // 0x28
		public float fillAmount; // 0x2C
		public float nodeTextSize; // 0x30
		public float textAutoSizeWidth; // 0x34
		public float textAutoSizeMinScale; // 0x38
		public int textAutoSizeMaxGlyphCount; // 0x3C
		public bool nodeTextBold; // 0x40
		public string textOverride; // 0x48
		public bool hide; // 0x50
	}

	public class GPUIExtendedRuntimeAnimationData // TypeDefIndex: 50554
	{
		// Fields
		public string name; // 0x10
		public int subrootIndex; // 0x18
		public float duration; // 0x1C
		public List<GPUIExtendedInstanceData> template; // 0x20
	
		// Constructors
		public GPUIExtendedRuntimeAnimationData(); // 0x000000018463BE70-0x000000018463BEF0
	}

	public class GPUIExtendedRuntimePrefabData // TypeDefIndex: 50555
	{
		// Fields
		public int templateNodeCount; // 0x10
		public List<GPUIExtendedRuntimeNodeInfo> nodes; // 0x18
		public List<GPUIExtendedSubrootInfo> subroots; // 0x20
		public Dictionary<string, int> nodesNameMap; // 0x28
		public Dictionary<string, int> subrootNameMap; // 0x30
		public Dictionary<string, int> rootAnimationNameMap; // 0x38
		public Dictionary<string, Dictionary<string, int>> subrootAnimationNameMaps; // 0x40
		public List<GPUIExtendedRuntimeAnimationData> animations; // 0x48
	
		// Constructors
		public GPUIExtendedRuntimePrefabData(); // 0x00000001845F96C0-0x00000001845F98E0
	}

	public static class GPUIExtendedPackingUtility // TypeDefIndex: 50556
	{
		// Fields
		private const float SNORM16_SCALE = 32767f; // Metadata: 0x0232FEFD
	
		// Methods
		public static uint PackPrefabAndParent(ushort prefabId, ushort parentId); // 0x000000018B0FF1CC-0x000000018B0FF22C
		public static uint PackGrandParentMatTypeAndDrawType(ushort grandParentId, byte matType, byte drawType); // 0x000000018B0FF154-0x000000018B0FF1CC
		public static uint PackRootScaleY(float scaleY); // 0x0000000183AB72A0-0x0000000183AB7310
		public static uint PackUInt16Pair(ushort low, ushort high); // 0x000000018B0FF22C-0x000000018B0FF28C
		public static int PackFillOverrideByte(byte fillOverride); // 0x000000018B0FF108-0x000000018B0FF154
		public static int PackTextScale(float scale); // 0x0000000183BB9900-0x0000000183BB9A30
		public static void PackQuaternion(Quaternion rotation, out int packedAuxiliary0, out int packedAuxiliary1); // 0x0000000182F3E2C0-0x0000000182F3E900
		private static short _PackSnorm16(float value); // 0x0000000182F3E900-0x0000000182F3EC90
	}

	public static class GPUILayoutInfo // TypeDefIndex: 50557
	{
		// Properties
		public static int LegacyPrefabStride { get; } // 0x000000018B100068-0x000000018B1000D0 
		public static int LegacyPrefabLiteStride { get; } // 0x000000018B100000-0x000000018B100068 
		public static int LegacyInstanceStride { get; } // 0x000000018B0FFF98-0x000000018B100000 
		public static int ExtendedPrefabStride { get; } // 0x000000018B0FFE78-0x000000018B0FFEE0 
		public static int ExtendedPrefabLiteStride { get; } // 0x000000018B0FFE10-0x000000018B0FFE78 
		public static int ExtendedInstanceStride { get; } // 0x000000018B0FFDA8-0x000000018B0FFE10 
		public static bool IsLegacyLayoutAligned { get; } // 0x000000018B0FFF3C-0x000000018B0FFF98 
		public static bool IsExtendedLayoutAligned { get; } // 0x000000018B0FFEE0-0x000000018B0FFF3C 
	}

	public struct GPUPrefabData // TypeDefIndex: 50558
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
		public GPUPrefabData(NodeSerializeData data); // 0x00000001840FB5C0-0x00000001840FB660
		public GPUPrefabData(Vector4 uv, Vector4 scale); // 0x00000001843EA580-0x00000001843EA5B0
	
		// Methods
		public static GPUPrefabData CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x00000001843EA4E0-0x00000001843EA580
	}

	public struct GPUPrefabDataLite // TypeDefIndex: 50559
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
		public GPUPrefabDataLite(NodeSerializeData data, Vector2 texelSizeInv, Vector2 aniTexelSizeInv); // 0x000000018B1001C4-0x000000018B10041C
		public GPUPrefabDataLite(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x000000018B10041C-0x000000018B100514
	
		// Methods
		public static GPUPrefabDataLite CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x000000018B1000D0-0x000000018B1001C4
	}

	public struct GPUInstanceData // TypeDefIndex: 50560
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

	public enum GPUILayoutType // TypeDefIndex: 50561
	{
		Legacy = 0,
		Extended = 1
	}

	public enum GPUIImageFillType // TypeDefIndex: 50562
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		Radial360 = 3
	}

	public enum NodeType // TypeDefIndex: 50563
	{
		Root = 0,
		Image = 1,
		Text = 2,
		Fill = 3
	}

	public enum SimpleTextAlignment // TypeDefIndex: 50564
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	[Serializable]
	public class NodeSerializeData // TypeDefIndex: 50565
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
		public NodeSerializeData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class ExtendedNodeSerializeData // TypeDefIndex: 50566
	{
		// Fields
		public Vector4 uv; // 0x10
		public Vector4 aniPosScaleMinMax; // 0x20
		public Vector4 aniPosAddMinMax; // 0x30
		public float aniPosScaleV; // 0x40
		public float aniPosAddV; // 0x44
		public float aniColorV; // 0x48
		public float aniFillV; // 0x4C
		public Vector2 aniURange; // 0x50
		public float aniDurationInv; // 0x58
		public int materialType; // 0x5C
		public uint materialParam1; // 0x60
		public UnityEngine.WrapMode wrapMode; // 0x64
		public GPUIImageFillType fillType; // 0x68
		public int fillOrigin; // 0x6C
		public bool fillClockwise; // 0x70
	
		// Constructors
		public ExtendedNodeSerializeData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class NodeMetadata // TypeDefIndex: 50567
	{
		// Fields
		public string nodeName; // 0x10
		public Beyond.UI.GPUI.NodeType nodeType; // 0x18
		public string nodeTextId; // 0x20
		public string nodeText; // 0x28
		public SimpleTextAlignment textAlignment; // 0x30
		public float nodeTextSize; // 0x34
		public bool nodeTextBold; // 0x38
		public int textAutoSizeMaxGlyphCount; // 0x3C
		public float textAutoSizeWidth; // 0x40
		public float textAutoSizeMinScale; // 0x44
		public string subrootName; // 0x48
		public int subrootIndex; // 0x50
	
		// Constructors
		public NodeMetadata(); // 0x0000000182B92810-0x0000000182B92820
	}

	[Serializable]
	public class SubrootSerializeData // TypeDefIndex: 50568
	{
		// Fields
		public string subrootName; // 0x10
		public int anchorNodeIndex; // 0x18
	
		// Constructors
		public SubrootSerializeData(); // 0x0000000184D87910-0x0000000184D87920
	}

	[Serializable]
	public class AnimationSerializeData // TypeDefIndex: 50569
	{
		// Fields
		public string animationName; // 0x10
		public float animationTime; // 0x18
		public int totalFrames; // 0x1C
		public UnityEngine.WrapMode wrapMode; // 0x20
		public int renderNodesOffset; // 0x24
	
		// Constructors
		public AnimationSerializeData(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class ExtendedAnimationSerializeData // TypeDefIndex: 50570
	{
		// Fields
		public string animationName; // 0x10
		public string subrootName; // 0x18
		public int subrootIndex; // 0x20
		public float animationTime; // 0x24
		public int totalFrames; // 0x28
		public UnityEngine.WrapMode wrapMode; // 0x2C
		public int renderNodesOffset; // 0x30
		public List<int> affectedNodeIndices; // 0x38
	
		// Constructors
		public ExtendedAnimationSerializeData(); // 0x00000001843E7750-0x00000001843E77D0
	}

	[Serializable]
	public class PrefabSerializeData // TypeDefIndex: 50571
	{
		// Fields
		public string prefabName; // 0x10
		public int nodeCount; // 0x18
		public bool animationOnly; // 0x1C
		public List<NodeMetadata> nodeMetas; // 0x20
		public List<NodeSerializeData> renderNodes; // 0x28
		public List<AnimationSerializeData> animations; // 0x30
	
		// Constructors
		public PrefabSerializeData(); // 0x00000001843DABD0-0x00000001843DADB0
	}

	[Serializable]
	public class ExtendedPrefabSerializeData // TypeDefIndex: 50572
	{
		// Fields
		public string prefabName; // 0x10
		public int nodeCount; // 0x18
		public bool animationOnly; // 0x1C
		public List<SubrootSerializeData> subroots; // 0x20
		public List<NodeMetadata> nodeMetas; // 0x28
		public List<ExtendedNodeSerializeData> renderNodes; // 0x30
		public List<ExtendedAnimationSerializeData> animations; // 0x38
	
		// Constructors
		public ExtendedPrefabSerializeData(); // 0x00000001843DA8F0-0x00000001843DAA50
	}

	[Serializable]
	public class PrefabGroupSerializeData : IMemoryPackSerialize // TypeDefIndex: 50573
	{
		// Fields
		public GPUILayoutType layoutType; // 0x10
		public StringPathHash spriteTexturePath; // 0x18
		public StringPathHash vatTexturePath; // 0x20
		public List<PrefabSerializeData> prefabs; // 0x28
		public List<string> textIds; // 0x30
		public string importantChars; // 0x38
	
		// Constructors
		public PrefabGroupSerializeData(); // 0x00000001849935D0-0x0000000184993690
	}

	[Serializable]
	public class ExtendedPrefabGroupSerializeData : IMemoryPackSerialize // TypeDefIndex: 50574
	{
		// Fields
		public GPUILayoutType layoutType; // 0x10
		public StringPathHash spriteTexturePath; // 0x18
		public StringPathHash vatTexturePath; // 0x20
		public bool hasTextNodes; // 0x28
		public int prefabBufferSize; // 0x2C
		public int fontPrefabBufferSize; // 0x30
		public bool simpleInstanceBuffer; // 0x34
		public bool enableDynamicSpriteAtlas; // 0x35
		public int dynamicSpriteAtlasX; // 0x38
		public int dynamicSpriteAtlasY; // 0x3C
		public int dynamicSpriteAtlasW; // 0x40
		public int dynamicSpriteAtlasH; // 0x44
		public int dynamicPrefabBufferCapacity; // 0x48
		public List<ExtendedPrefabSerializeData> prefabs; // 0x50
		public List<string> textIds; // 0x58
		public string importantChars; // 0x60
	
		// Constructors
		public ExtendedPrefabGroupSerializeData(); // 0x000000018472E7D0-0x000000018472E8C0
	}

	internal abstract class BaseRuntimeInstance<TData> // TypeDefIndex: 50575
		where TData : struct
	{
		// Fields
		public int version;
		public ChangeState state;
		public int length;
		public int sortingOrder;
	
		// Constructors
		protected BaseRuntimeInstance();
	
		// Methods
		public abstract void Recycle();
		public abstract void DoUpdate(ref NativeArray<TData> buffer, int startIndexInBuffer, bool full);
		protected void MarkChangeData();
		protected void MarkChangeSize();
		protected void MarkStable();
	}

	internal class CodePoint // TypeDefIndex: 50576
	{
		// Fields
		public const uint HIGH_SURROGATE_START = 55296; // Metadata: 0x0232FF0E
		public const uint HIGH_SURROGATE_END = 56319; // Metadata: 0x0232FF12
		public const uint LOW_SURROGATE_START = 56320; // Metadata: 0x0232FF16
		public const uint LOW_SURROGATE_END = 57343; // Metadata: 0x0232FF1A
		public const uint UNICODE_PLANE01_START = 65536; // Metadata: 0x0232FF1E
	
		// Constructors
		public CodePoint(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate); // 0x000000018B0FE390-0x000000018B0FE3F0
	}

	internal abstract class BaseTextSystem<T> // TypeDefIndex: 50578
		where T : struct
	{
		// Fields
		protected const float DEFAULT_WHITESPACE_SPACING = 0.27f; // Metadata: 0x0232FF22
		protected TMP_FontAsset m_fontAsset;
		protected Material m_tmpMaterial;
		protected SimpleBufferManager<T> m_prefabBufferManager;
		protected float m_padding;
		protected Vector2 m_texelSizeInv;
		protected bool m_isThaiMode;
		protected int m_prefabDestIndex;
		protected int m_fontBufferCount;
		protected readonly int m_fontBufferCapacity;
		protected readonly Func<Vector4, Vector4, Vector2, T> m_prefabCreatorFunc;
		protected readonly List<T> m_dynamicBufferCache;
		protected readonly Dictionary<uint, int> m_charCodeToIndexMap;
		protected readonly List<CharOffsetData> m_tempOffsetCache;
		protected readonly Dictionary<uint, CharOffsetData> m_charaOffsetCache;
	
		// Nested types
		protected struct CharOffsetData // TypeDefIndex: 50577
		{
			// Fields
			public float scale;
			public float xAdvance;
			public float xOffset;
			public float yOffset;
			public int prefabIndex;
		}
	
		// Constructors
		protected BaseTextSystem(int fontBufferCapacity, Func<Vector4, Vector4, Vector2, T> prefabCreatorFunc);
	
		// Methods
		public void Init(TMP_FontAsset fontAsset, Material tmpMaterial, SimpleBufferManager<T> simpleBufferManager, bool isThaiMode);
		public void RegisterCharacterToPrefabBuffer(string text);
		public int GetNodeCount(string text);
		public void UploadBufferIfNeeded();
		protected static float CalculateAutoSizeScale(float totalWidth, float autoSizeWidth, float nodeTextSize, float autoSizeMinScale);
		protected void DoTextAlignAndDynamicBuffer(string text, SimpleTextAlignment alignment, out float currentX);
		protected void DoTextAlignAndDynamicBuffer(string text, SimpleTextAlignment alignment, out float currentX, out float totalWidth);
		protected int PutOneCharacterToPrefabBufferDynamic(uint c);
		private void _LoadAllCharacterToPrefabBuffer(string text);
		private void _InitPrefabDataByTMPCharacter(TMP_Character character, out ref T prefabData);
		protected virtual void OnFontBufferCapacityExceeded();
		protected virtual void OnCharacterMissing(uint c);
		protected static bool IsUpVowel(char c);
		protected static bool IsLowVowel(char c);
		protected static bool IsToneMark(char c);
		protected static bool IsAscenderThai(char c);
	}

	internal sealed class ExInstanceBufferManager<TInstance, TData> : InstanceBufferManagerBase<TInstance, TData> // TypeDefIndex: 50580
		where TInstance : BaseRuntimeInstance<TData>
		where TData : struct
	{
		// Fields
		private static readonly ProfilerMarker MARKER_UPDATE_PERF;
		private NativeArray<CanvasRenderer.InstanceRange> m_gpuGroups;
		private List<TInstance> m_runtimeInstanceView;
		private List<BufferInternalNode> m_bufferInternalNodes;
		private List<BufferInternalNode> m_pendingNodes;
		private List<BufferInternalNode> m_addNodes;
		private HashSet<GPUIHandle> m_removeNodes;
		private bool m_hasAnyChanges;
		private bool m_updateBufferOnly;
		private int m_currentStartIndex;
		private int m_currentLength;
		private int m_capacity;
		private readonly int m_maxCapacity;
		private readonly int m_gpuGroupCapacity;
		private int m_groupCount;
		private readonly bool m_noSortingOrder;
	
		// Properties
		public int startIndex { get; }
		public override int nodeCount { get; }
		public int capacity { get; }
		public override NativeArray<CanvasRenderer.InstanceRange> gpuGroups { get; }
		public override int gpuGroupCount { get; }
	
		// Nested types
		private struct BufferInternalNode // TypeDefIndex: 50579
		{
			// Fields
			public GPUIHandle handle;
			public int startIndex;
			public int previousLength;
			public int sortingOrder;
		}
	
		// Constructors
		public ExInstanceBufferManager(int initCapacity, int maxCapacity, int gpuGroupCapacity, bool noSortingOrder);
		static ExInstanceBufferManager();
	
		// Methods
		public override void BindInstanceList(List<TInstance> runtimeInstanceView);
		public override void MarkNeedUpdate();
		private void _FillInstanceQueue(ref NativeArray<TData> oldBuffer, out int newTotalLength, out int newTotalLengthWithEmptySlot, out int fullUpdateIndex);
		public override void DoUpdate(CanvasRenderer canvasRenderer);
		private void _NewGpuGroup(int start, int end);
		public override void Add(GPUIHandle instance);
		public override void Remove(GPUIHandle instance);
		private void _AllocBuffer(int capacity);
		public override void Dispose();
	}

	public sealed class GPUIExtendedDynamicAtlas : IDisposable // TypeDefIndex: 50584
	{
		// Fields
		public const int DEFAULT_PADDING = 0; // Metadata: 0x0232FF27
		public const int IMAGE_USING_ATLAS_MAX_SIZE = 512; // Metadata: 0x0232FF28
		private readonly Dictionary<int, SpriteRecord> m_spriteRecords; // 0x10
		private UICustomAtlasHandle m_atlasHandle; // 0x18
		private Texture2D m_runtimeTexture; // 0x20
		private RectInt m_dynamicRect; // 0x28
		private bool m_initialized; // 0x38
	
		// Properties
		public Texture2D runtimeTexture { get; } // 0x00000001833C42C0-0x00000001833C43E0 
		public RectInt dynamicAtlasRect { get; } // 0x000000018B0FECF0-0x000000018B0FED58 
		public bool isInitialized { get; } // 0x0000000183944C90-0x0000000183944CC0 
	
		// Nested types
		public enum DynamicAtlasFailureCause // TypeDefIndex: 50581
		{
			NoFailure = 0,
			FailureCauseInvalidStaticAtlas = 1,
			FailureCauseInvalidDynamicAtlasRect = 2,
			FailureCauseSpriteHasNullTexture = 3,
			FailureCauseSpriteHasAssociatedAlphaSplitTexture = 4,
			FailureCauseTextureWidthExceedLimit = 5,
			FailureCauseTextureHeightExceedLimit = 6,
			FailureCauseEngineAtlasCreateFailed = 7,
			FailureCauseEngineAtlasAllocateFailed = 8
		}
	
		public struct DynamicSpriteHandle // TypeDefIndex: 50582
		{
			// Fields
			public Sprite sprite; // 0x00
			public int spriteInstanceId; // 0x08
	
			// Methods
			public bool IsValid(); // 0x000000018357C1F0-0x000000018357C220
			public static DynamicSpriteHandle CreateInvalidHandle(); // 0x000000018357B2E0-0x000000018357B330
		}
	
		private sealed class SpriteRecord // TypeDefIndex: 50583
		{
			// Fields
			public Sprite sprite; // 0x10
			public int spriteInstanceId; // 0x18
			public int refCount; // 0x1C
			public Vector4 uv; // 0x20
	
			// Constructors
			public SpriteRecord(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public GPUIExtendedDynamicAtlas(Texture staticTexture, RectInt dynamicRect, int padding = 0 /* Metadata: 0x0232FF26 */); // 0x0000000183944CC0-0x0000000183944D70
	
		// Methods
		[IDTag(1)]
		public void Initialize(Texture staticTexture, RectInt dynamicRect); // 0x0000000183944D70-0x0000000183944E00
		[IDTag(0)]
		public void Initialize(Texture2D staticTexture, RectInt dynamicRect); // 0x0000000183944E00-0x0000000183944F10
		public bool Acquire(Sprite sprite, out DynamicSpriteHandle handle, out Vector4 uv); // 0x000000018357B080-0x000000018357B2E0
		[IDTag(1)]
		public bool Release(DynamicSpriteHandle handle); // 0x000000018B0FEB5C-0x000000018B0FEBE0
		[IDTag(0)]
		public bool Release(DynamicSpriteHandle handle, out bool fullyReleased); // 0x000000018357A870-0x000000018357A980
		public void Dispose(); // 0x0000000183944F10-0x0000000183944FC0
		public UICustomAtlasCopyStatus GetAtlasStatus(); // 0x00000001839451A0-0x0000000183945260
		private bool _TryValidateSprite(Sprite sprite, out DynamicAtlasFailureCause failureCause); // 0x000000018357BB90-0x000000018357BD90
		private bool _IsValidStaticTexture(Texture2D staticTexture); // 0x0000000183945380-0x0000000183945480
		private bool _IsValidDynamicAtlasRect(Texture2D staticTexture, RectInt dynamicRect); // 0x0000000183945280-0x0000000183945380
		private bool _IsAtlasCreationValid(UICustomAtlasCopyStatus status); // 0x0000000183944FC0-0x0000000183945010
		private static Vector2Int _GetSpriteContentSize(Sprite sprite); // 0x000000018357BD90-0x000000018357BE00
		private static int _GetSpriteInstanceId(Sprite sprite); // 0x000000018357B330-0x000000018357B370
		private static void _LogFailure(Sprite sprite, DynamicAtlasFailureCause failureCause); // 0x000000018B0FEBE0-0x000000018B0FECF0
	}

	internal sealed class GPUIExtendedDynamicPrefabNodeManager : IDisposable // TypeDefIndex: 50587
	{
		// Fields
		private readonly bool m_liteMode; // 0x10
		private readonly SimpleBufferManager<GPUIExtendedPrefabData> m_prefabBufferManager; // 0x18
		private readonly SimpleBufferManager<GPUIExtendedPrefabDataLite> m_litePrefabBufferManager; // 0x20
		private readonly GPUIExtendedPrefabData[] m_prefabMirror; // 0x28
		private readonly GPUIExtendedPrefabDataLite[] m_litePrefabMirror; // 0x30
		private readonly Vector2 m_spriteTexelSizeInv; // 0x38
		private readonly Stack<int> m_freeSlots; // 0x40
		private readonly Dictionary<DynamicPrefabNodeKey, DynamicPrefabNodeEntry> m_entries; // 0x48
		private readonly Dictionary<int, Vector4> m_spriteUvMap; // 0x50
		private readonly HashSet<int> m_dirtySlots; // 0x58
		private bool m_disposed; // 0x60
	
		// Nested types
		[IsReadOnly]
		public struct DynamicPrefabNodeKey : IEquatable<DynamicPrefabNodeKey> // TypeDefIndex: 50585
		{
			// Fields
			public readonly int basePrefabOffset; // 0x00
			public readonly Sprite sprite; // 0x08
			public readonly int spriteInstanceId; // 0x10
	
			// Constructors
			public DynamicPrefabNodeKey(int basePrefabOffset, Sprite sprite); // 0x000000018357D700-0x000000018357DAD0
	
			// Methods
			[IDTag(0)]
			public bool Equals(DynamicPrefabNodeKey other); // 0x000000018357D660-0x000000018357D700
			[IDTag(1)]
			public override bool Equals(object obj); // 0x000000018B0FE3F0-0x000000018B0FE4A4
			public override int GetHashCode(); // 0x00000001840DEC60-0x00000001840DEC90
			private static int _GetSpriteInstanceId(Sprite sprite); // 0x000000018357DAD0-0x000000018357DBB0
			public bool __iFixBaseProxy_Equals(object P0); // 0x000000018B0FE4A4-0x000000018B0FE50C
			public int __iFixBaseProxy_GetHashCode(); // 0x000000018B0FE50C-0x000000018B0FE564
		}
	
		private sealed class DynamicPrefabNodeEntry // TypeDefIndex: 50586
		{
			// Fields
			public DynamicPrefabNodeKey key; // 0x10
			public ushort dynamicPrefabId; // 0x28
			public int refCount; // 0x2C
	
			// Constructors
			public DynamicPrefabNodeEntry(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public GPUIExtendedDynamicPrefabNodeManager(SimpleBufferManager<GPUIExtendedPrefabData> prefabBufferManager, GPUIExtendedPrefabData[] prefabMirror, int capacity); // 0x0000000183945680-0x0000000183945840
		public GPUIExtendedDynamicPrefabNodeManager(SimpleBufferManager<GPUIExtendedPrefabDataLite> prefabBufferManager, GPUIExtendedPrefabDataLite[] prefabMirror, Vector2 spriteTexelSizeInv, int capacity); // 0x000000018B0FEF40-0x000000018B0FF108
	
		// Methods
		public void Dispose(); // 0x000000018B0FED58-0x000000018B0FEE3C
		public void RegisterSpriteUV(Sprite sprite, Vector4 spriteUv); // 0x000000018357B370-0x000000018357B3F0
		public void UnregisterSpriteUV(Sprite sprite); // 0x000000018357E230-0x000000018357E2B0
		public bool TryAcquire(int basePrefabOffset, Sprite sprite, out DynamicPrefabNodeKey key, out ushort dynamicPrefabId); // 0x000000018357C320-0x000000018357C630
		public void Release(DynamicPrefabNodeKey key); // 0x000000018357AA20-0x000000018357AB70
		public void FlushIfNeeded(); // 0x00000001833C43E0-0x00000001833C4A80
		private void _ReserveSlots<T>(SimpleBufferManager<T> bufferManager, int capacity)
			where T : struct;
		private static void _SetLiteUV(ref GPUIExtendedPrefabDataLite data, Vector4 spriteUv, Vector2 spriteTexelSizeInv); // 0x000000018B0FEE3C-0x000000018B0FEF40
		private static int _GetSpriteInstanceId(Sprite sprite); // 0x000000018357B3F0-0x000000018357B470
	}

	internal sealed class GPUIExtendedDynamicSpriteOverrideManager // TypeDefIndex: 50588
	{
		// Fields
		private readonly GPUIExtendedDynamicAtlas m_dynamicAtlas; // 0x10
		private readonly GPUIExtendedDynamicPrefabNodeManager m_dynamicPrefabNodeManager; // 0x18
	
		// Constructors
		public GPUIExtendedDynamicSpriteOverrideManager(GPUIExtendedDynamicAtlas dynamicAtlas, GPUIExtendedDynamicPrefabNodeManager dynamicPrefabNodeManager); // 0x00000001832AF420-0x00000001832AF450
	
		// Methods
		public bool TryAcquireDynamicSprite(Sprite sprite, out GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle); // 0x000000018357AF90-0x000000018357B080
		[IDTag(0)]
		public bool TryAcquireDynamicPrefabNode(int basePrefabOffset, Sprite sprite, out GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey key, out ushort dynamicPrefabId); // 0x000000018357C290-0x000000018357C320
		[IDTag(1)]
		public bool TryAcquireDynamicPrefabNode(int basePrefabOffset, GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle, out GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey key, out ushort dynamicPrefabId); // 0x000000018357C220-0x000000018357C290
		public bool MatchesDynamicPrefabNode(GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey key, int basePrefabOffset, GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle); // 0x000000018357C670-0x000000018357D660
		public void ReleaseDynamicPrefabNode(GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey key); // 0x000000018357A9C0-0x000000018357AA20
		public void ReleaseDynamicSprite(GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle); // 0x000000018357DDB0-0x000000018357DE30
	}

	internal sealed class GPUIExtendedRuntimeInstance : BaseRuntimeInstance<GPUIExtendedInstanceData> // TypeDefIndex: 50590
	{
		// Fields
		public const int ROOT_NODE_INDEX = 0; // Metadata: 0x0232FF34
		public const uint INVALID_NODE_ID = 4294967295; // Metadata: 0x0232FF35
		private GPUIExtendedRuntimePrefabData m_prefab; // 0x20
		private GPUIExtendedRuntimeNodeInfo[] m_nodeInfo; // 0x28
		private GPUISubrootDomainState[] m_subroots; // 0x30
		private GPUIExtendedAnimationState m_rootAnimationState; // 0x38
		private GPUIExtendedAnimationState[] m_subrootAnimationStates; // 0x48
		private int[] m_subrootProxyNodeIndices; // 0x50
		private int m_subrootProxyNodeCount; // 0x58
		private IExtendedTextSystem m_textSystem; // 0x60
		private GPUIExtendedDynamicSpriteOverrideManager m_dynamicSpriteOverrideManager; // 0x68
		private SpriteOverrideState[] m_spriteOverrides; // 0x70
		private int m_nodeInfoCount; // 0x78
		private float m_animationDuration; // 0x7C
		private GPUIRootTransformState m_rootTransform; // 0x80
		private bool m_needsSpriteOverrideRetry; // 0xA8
	
		// Properties
		public GPUIExtendedRuntimePrefabData Prefab { get; } // 0x0000000182F47CC0-0x0000000182F47D30 
		public float AnimationDuration { get; } // 0x000000018B0FFD58-0x000000018B0FFDA8 
	
		// Nested types
		private struct SpriteOverrideState // TypeDefIndex: 50589
		{
			// Fields
			public bool enabled; // 0x00
			public GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle; // 0x08
			public GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey activeKey; // 0x18
			public ushort dynamicPrefabId; // 0x30
		}
	
		// Constructors
		public GPUIExtendedRuntimeInstance(); // 0x0000000184CB2850-0x0000000184CB2880
	
		// Methods
		public void Create(GPUIExtendedRuntimePrefabData prefab, IExtendedTextSystem textSystem, GPUIExtendedDynamicSpriteOverrideManager dynamicSpriteOverrideManager = null); // 0x0000000183AA9900-0x0000000183AA9D50
		public override void Recycle(); // 0x000000018357A980-0x000000018357A9C0
		public override void DoUpdate(ref NativeArray<GPUIExtendedInstanceData> buffer, int startIndexInBuffer, bool full); // 0x0000000182FA80A0-0x0000000182FA8BD0
		public void SetRootPosition(Vector3 position); // 0x0000000182F47DF0-0x0000000182F47E40
		public void SetRootScale(Vector2 scale); // 0x0000000182F47EF0-0x0000000182F47F60
		public void SetRootRotation(Quaternion rotation); // 0x00000001842E49B0-0x00000001842E49F0
		public void StartAnimation(float animationTime, int animationIndex = 0 /* Metadata: 0x0232FF33 */); // 0x0000000183AA2720-0x0000000183AA2790
		public bool StartSubrootAnimation(int subrootIndex, float animationTime, int animationIndex); // 0x000000018B0FFA38-0x000000018B0FFB7C
		public void SetNodeVisibility(int index, bool visible); // 0x0000000182F48230-0x0000000182F482A0
		public void SetNodeColor(int index, UnityEngine.Color color); // 0x000000018363C2A0-0x000000018363C340
		public void SetNodeFillAmount(int index, float fillAmount); // 0x00000001833C1660-0x00000001833C1720
		public void SetSubrootState(int subrootIndex, Vector2 position, Vector2 scale, float rotationZ); // 0x000000018B0FF93C-0x000000018B0FFA38
		public void SetSubrootVisibility(int subrootIndex, bool visible); // 0x0000000183AB6E80-0x0000000183AB6F00
		public void SetText(int index, string text); // 0x0000000183848AD0-0x0000000183848BE0
		public bool SetSpriteOverride(int index, GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle); // 0x000000018357BE00-0x000000018357C000
		public bool ClearSpriteOverride(int index); // 0x000000018357AE10-0x000000018357AE60
		public void ClearDynamicSpriteOverrides(); // 0x000000018B0FF87C-0x000000018B0FF93C
		public void UpdateDynamicSpriteContext(GPUIExtendedDynamicSpriteOverrideManager dynamicSpriteOverrideManager); // 0x000000018B0FFB7C-0x000000018B0FFBE0
		private void _WriteRootNode(ref NativeArray<GPUIExtendedInstanceData> buffer, int startIndexInBuffer, ref int indexInBuffer, GPUIExtendedInstanceData templateNode); // 0x0000000183AB7110-0x0000000183AB72A0
		private void _WriteSubrootProxyNodes(ref NativeArray<GPUIExtendedInstanceData> buffer, int startIndexInBuffer, ref int indexInBuffer); // 0x0000000183AB6F00-0x0000000183AB7110
		private void _InitializeAnimationStates(); // 0x0000000183AA9DD0-0x0000000183AA9F10
		private GPUIExtendedAnimationState _GetAnimationStateForNode([IsReadOnly] in GPUIExtendedRuntimeNodeInfo node); // 0x0000000182FA96E0-0x0000000182FA97C0
		private int _FindPreferredRootAnimationIndex(); // 0x000000018331E560-0x000000018331E7D0
		private GPUIExtendedRuntimeAnimationData _GetAnimationData(int animationIndex); // 0x0000000182FA8BD0-0x0000000182FA8C80
		private int _FindFirstAnimationIndex(int subrootIndex); // 0x000000018443E790-0x000000018443E810
		private int _FindDefaultSubrootAnimationIndex(int subrootIndex); // 0x00000001845B3EA0-0x00000001845B3F90
		private void _ApplySpriteOverride(int nodeIndex, ref GPUIExtendedInstanceData templateNode); // 0x0000000182FA98E0-0x0000000182FA9C00
		private bool _TryPrimeSpriteOverride(int index, ref SpriteOverrideState overrideState); // 0x000000018357C0B0-0x000000018357C1F0
		private bool _TryPrimeSpriteOverrideWithReleasedSlot(int index, ref SpriteOverrideState previousState, ref SpriteOverrideState nextState); // 0x000000018B0FFBE0-0x000000018B0FFD58
		private bool _TryResolveCurrentBasePrefabOffset(int index, out int basePrefabOffset); // 0x000000018357DBB0-0x000000018357DD40
		private void _ReleaseSpriteOverrideResources([IsReadOnly] in SpriteOverrideState overrideState); // 0x000000018357C000-0x000000018357C0B0
		private void _ClearSpriteOverride(int index); // 0x000000018357AEB0-0x000000018357AF90
		private void _ClearAllSpriteOverrides(); // 0x000000018357AE60-0x000000018357AEB0
		private static uint _UnpackPrefabId(uint packedPrefabParent); // 0x0000000182FA7720-0x0000000182FA7780
		private static bool _HasActivePrefabNode([IsReadOnly] in SpriteOverrideState overrideState); // 0x000000018357DD40-0x000000018357DDB0
		private static byte _PackFillOverride(float fillAmount); // 0x0000000182FA9840-0x0000000182FA98E0
	}

	public class GPUIExtendedSystem : GPUISharedGraphicBase // TypeDefIndex: 50591
	{
		// Fields
		private const string DEFAULT_SHADER_NAME = "HGRP/UI/GPUUI/TextV3Extended"; // Metadata: 0x0232FF38
		private const int MAX_PREFAB_BUFFER_SIZE = 328; // Metadata: 0x0232FF55
		private const int SIMPLE_INSTANCE_INIT_CAPACITY = 256; // Metadata: 0x0232FF57
		public int sourceCNFontId; // 0x150
		private TMP_FontAsset m_i18NFontAsset; // 0x158
		public bool noSortingOrder; // 0x160
		private Texture m_vatTexture; // 0x168
		private Texture m_spriteTexture; // 0x170
		private FAssetProxyHandle m_vatTextureHandle; // 0x178
		private FAssetProxyHandle m_spriteTextureHandle; // 0x18C
		private float m_timeForShader; // 0x1A0
		private readonly Dictionary<string, GPUIExtendedRuntimePrefabData> m_prefabMap; // 0x1A8
		private readonly List<GPUIExtendedRuntimeInstance> m_instances; // 0x1B0
		private readonly Queue<int> m_recyclePool; // 0x1B8
		private readonly List<KeyValuePair<float, GPUIHandle>> m_destroyQueue; // 0x1C0
		private bool m_liteMode; // 0x1C8
		[CompilerGenerated]
		private Action m_beforeRenderSync; // 0x1D0
		private GPUIExtendedDynamicAtlas m_dynamicAtlas; // 0x1D8
		private GPUIExtendedDynamicPrefabNodeManager m_dynamicPrefabNodeManager; // 0x1E0
		private GPUIExtendedDynamicSpriteOverrideManager m_dynamicSpriteOverrideManager; // 0x1E8
		private GPUIExtendedPrefabData[] m_prefabMirror; // 0x1F0
		private GPUIExtendedPrefabDataLite[] m_litePrefabMirror; // 0x1F8
		[CanBeNull]
		private InstanceBufferManagerBase<GPUIExtendedRuntimeInstance, GPUIExtendedInstanceData> m_instanceBufferManager; // 0x200
		[CanBeNull]
		private SimpleBufferManager<GPUIExtendedPrefabData> m_prefabBufferManager; // 0x208
		[CanBeNull]
		private SimpleBufferManager<GPUIExtendedPrefabDataLite> m_litePrefabBufferManager; // 0x210
		[CanBeNull]
		private IExtendedTextSystem m_textSystem; // 0x218
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x0000000183942950-0x0000000183942AA0 0x000000018B0B4374-0x000000018B0B4468
	
		// Events
		private event Action m_beforeRenderSync {
			add; // 0x0000000183329940-0x00000001833299E0
			remove; // 0x00000001833299E0-0x0000000183329A80
		}
	
		// Constructors
		public GPUIExtendedSystem(); // 0x0000000183B96050-0x0000000183B96210
	
		// Methods
		protected TMP_FontAsset GetFontAsset(); // 0x0000000184CCAC20-0x0000000184CCACA0
		protected override void InitMaterials(); // 0x000000018474F750-0x000000018474FB60
		public void RegisterBeforeRenderSync(Action callback); // 0x00000001833298F0-0x0000000183329940
		public void UnregisterBeforeRenderSync(Action callback); // 0x000000018B0B430C-0x000000018B0B4374
		public bool CreateInstance(string prefabName, Vector3 initialPosition, out GPUIHandle handle, int sortingOrder = 0 /* Metadata: 0x0232FF36 */); // 0x0000000183AA96A0-0x0000000183AA97F0
		public bool DestroyInstance(GPUIHandle handle); // 0x0000000183AAA030-0x0000000183AAA100
		public bool IsInstanceValid(GPUIHandle handle); // 0x0000000182F462A0-0x0000000182F463C0
		public bool SetRootPosition(GPUIHandle handle, Vector3 position); // 0x0000000182F47D30-0x0000000182F47DF0
		public bool SetRootScale(GPUIHandle handle, Vector2 scale); // 0x0000000182F47E40-0x0000000182F47EF0
		public bool SetRootRotation(GPUIHandle handle, Quaternion rotation); // 0x00000001842E48F0-0x00000001842E49B0
		public bool SetNodeVisibility(GPUIHandle handle, string nodeName, bool visible); // 0x0000000182F48160-0x0000000182F48230
		public bool SetSubrootVisibility(GPUIHandle handle, string subrootName, bool visible); // 0x0000000183AB6D50-0x0000000183AB6E80
		public bool SetSubrootTransform(GPUIHandle handle, string subrootName, Vector2 position, Vector2 scale, float rotationZ); // 0x000000018B0B3DBC-0x000000018B0B3F44
		public bool SetColor(GPUIHandle handle, string nodeName, UnityEngine.Color color); // 0x000000018363C1D0-0x000000018363C2A0
		public bool SetImageFillAmount(GPUIHandle handle, string nodeName, float fillAmount); // 0x00000001833C14C0-0x00000001833C1660
		public bool SetText(GPUIHandle handle, string nodeName, string text); // 0x0000000183848A00-0x0000000183848AD0
		public bool SetSprite(GPUIHandle handle, string nodeName, Sprite sprite); // 0x000000018357AC10-0x000000018357AE10
		[IDTag(1)]
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, string animationName); // 0x0000000183AA2560-0x0000000183AA2650
		[IDTag(0)]
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, int animationIndex = 0 /* Metadata: 0x0232FF37 */); // 0x0000000183AA2650-0x0000000183AA2720
		public bool TryGetAnimationDuration(GPUIHandle handle, string animationName, out float duration); // 0x0000000183AA2790-0x0000000183AA28A0
		public bool StartSubrootAnimation(GPUIHandle handle, string subrootName, string animationName); // 0x000000018B0B3F44-0x000000018B0B412C
		public bool TryGetSubrootAnimationDuration(GPUIHandle handle, string subrootName, string animationName, out float duration); // 0x000000018B0B412C-0x000000018B0B42EC
		private void _DisposeLoadedTextures(); // 0x0000000183944800-0x0000000183944850
		protected override void OnDestroy(); // 0x000000018B0B3BD8-0x000000018B0B3D08
		protected override void OnEnable(); // 0x0000000183941720-0x0000000183941830
		protected override void OnDisable(); // 0x000000018B0B3D08-0x000000018B0B3DBC
		private void _OnPreWillRenderCanvases(); // 0x00000001833C3BB0-0x00000001833C3C50
		private void _Init(string jsonPath); // 0x0000000183942650-0x0000000183942950
		private void _EnsureInstanceBufferManager(bool useSimpleInstanceBuffer); // 0x0000000183941870-0x0000000183941A50
		private bool _TryResolveAndValidateGroupBufferConfig(ExtendedPrefabGroupSerializeData groupData, out int prefabBufferSize, out int fontPrefabBufferSize); // 0x0000000183942AA0-0x0000000183942C00
		private static int _CalculateRequiredPrefabBufferSize(List<ExtendedPrefabSerializeData> prefabs); // 0x0000000183943C60-0x0000000183943DD0
		private void _DoLateUpdate(); // 0x00000001833C3C50-0x00000001833C3DC0
		private void _RenderNodes(); // 0x00000001833C4030-0x00000001833C4280
		private void _DestroyAnimatedInstance(); // 0x00000001833C3DC0-0x00000001833C3E40
		private void _PreloadText(ExtendedPrefabGroupSerializeData data); // 0x0000000183942C00-0x00000001839430E0
		private void _LoadGroupData(ExtendedPrefabGroupSerializeData data); // 0x0000000183943DD0-0x0000000183944800
		private GPUIExtendedRuntimePrefabData _LoadPrefabData(ExtendedPrefabSerializeData prefab); // 0x000000018363F680-0x00000001836411E0
		private void _InitPrefabBufferManager(bool hasTextNodes, int prefabBufferSize, int fontPrefabBufferSize); // 0x00000001846BC380-0x00000001846BC7E0
		private static int _FindAnchorNodeIndex(List<NodeMetadata> nodeMetas, string subrootName); // 0x0000000184563A60-0x0000000184563B90
		private int _LoadPrefabNodeBuffer(ExtendedPrefabSerializeData prefab, int totalNodeCount); // 0x000000018357DE30-0x000000018357E0C0
		private void _InitDynamicPrefabNodeManager(ExtendedPrefabGroupSerializeData data); // 0x0000000183944AE0-0x0000000183944C90
		private bool _CanSubmitInstanceRange(); // 0x00000001839450A0-0x00000001839451A0
		private void _ResetLiveDynamicSpriteState(); // 0x0000000183944850-0x00000001839449B0
		private void _UpdateLiveDynamicSpriteContext(); // 0x00000001839449B0-0x0000000183944AE0
		private void _SyncDynamicAtlasRuntimeTexture(); // 0x00000001833C3E40-0x00000001833C4030
		private GPUIHandle _GetOneHandle(); // 0x0000000183AA97F0-0x0000000183AA9900
		private bool _IsHandleInvalid(GPUIHandle handle); // 0x0000000182F463C0-0x0000000182F46490
		private bool _TryResolveNode(GPUIHandle handle, string nodeName, out GPUIExtendedRuntimeInstance instance, out int nodeIndex); // 0x0000000182F46E30-0x0000000182F47CC0
		public void __iFixBaseProxy_InitMaterials(); // 0x000000018B0B42EC-0x000000018B0B42F4
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0B42F4-0x000000018B0B42FC
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0B4304-0x000000018B0B430C
		public void __iFixBaseProxy_OnDisable(); // 0x000000018B0B42FC-0x000000018B0B4304
	}

	internal interface IExtendedTextSystem // TypeDefIndex: 50592
	{
		// Methods
		void RegisterCharacterToPrefabBuffer(string text);
		void UploadBufferIfNeeded();
		int GetNodeCount(string text);
		void CreateTextNodes(string text, NativeArray<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float textScale = 1f /* Metadata: 0x0232FF59 */, bool isBold = false /* Metadata: 0x0232FF5D */);
		void CreateTextNodes(string text, List<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float textScale = 1f /* Metadata: 0x0232FF5E */, bool isBold = false /* Metadata: 0x0232FF62 */);
		void CreateTextNodesAutoSize(string text, NativeArray<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float autoSizeWidth, float nodeTextSize, float autoSizeMinScale, bool isBold = false /* Metadata: 0x0232FF63 */);
		void CreateTextNodesAutoSize(string text, List<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float autoSizeWidth, float nodeTextSize, float autoSizeMinScale, bool isBold = false /* Metadata: 0x0232FF64 */);
	}

	internal sealed class GPUIExtendedTextSystem<T> : BaseTextSystem<T>, IExtendedTextSystem // TypeDefIndex: 50593
		where T : struct
	{
		// Constructors
		public GPUIExtendedTextSystem(int fontBufferCapacity, Func<Vector4, Vector4, Vector2, T> prefabCreatorFunc);
	
		// Methods
		public void CreateTextNodes(string text, NativeArray<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float textScale = 1f /* Metadata: 0x0232FF65 */, bool isBold = false /* Metadata: 0x0232FF69 */);
		public void CreateTextNodes(string text, List<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float textScale = 1f /* Metadata: 0x0232FF6A */, bool isBold = false /* Metadata: 0x0232FF6E */);
		public void CreateTextNodesAutoSize(string text, NativeArray<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float autoSizeWidth, float nodeTextSize, float autoSizeMinScale, bool isBold = false /* Metadata: 0x0232FF6F */);
		public void CreateTextNodesAutoSize(string text, List<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float autoSizeWidth, float nodeTextSize, float autoSizeMinScale, bool isBold = false /* Metadata: 0x0232FF70 */);
		private GPUIExtendedInstanceData _CreateGlyphInstance(CharOffsetData<T> textWidth, float currentX, int parentId, int secondaryParentId, float textScale, bool isBold);
	}

	public struct GPUIHandle : IEquatable<GPUIHandle> // TypeDefIndex: 50594
	{
		// Fields
		public int index; // 0x00
		public int version; // 0x04
	
		// Methods
		[IDTag(0)]
		public bool Equals(GPUIHandle other); // 0x0000000183AA6330-0x0000000183AA6380
		[IDTag(1)]
		public override bool Equals(object obj); // 0x000000018B0B4468-0x000000018B0B4504
		public override int GetHashCode(); // 0x0000000183E00C00-0x0000000183E00C70
		public static bool operator ==(GPUIHandle left, GPUIHandle right); // 0x0000000183AA62E0-0x0000000183AA6330
		public static bool operator !=(GPUIHandle left, GPUIHandle right); // 0x0000000183AA6040-0x0000000183AA6090
		public bool __iFixBaseProxy_Equals(object P0); // 0x000000018B0B4504-0x000000018B0B4564
		public int __iFixBaseProxy_GetHashCode(); // 0x000000018B0B4564-0x000000018B0B45B4
	}

	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public class GPUIPrefabProxyBase : MonoBehaviour // TypeDefIndex: 50595
	{
		// Fields
		private const float POSITION_SYNC_EPSILON = 0.01f; // Metadata: 0x0232FF72
		private const float POSITION_SYNC_EPSILON_SQR = 0.0001f; // Metadata: 0x0232FF76
		[SerializeField]
		private string _prefabName; // 0x18
		[SerializeField]
		private bool _autoCreate; // 0x20
		[SerializeField]
		private bool _autoResolveSyncManager; // 0x21
		[SerializeField]
		private int _sortingOrder; // 0x24
		private RectTransform m_rectTransform; // 0x28
		private GPUIHandle m_handle; // 0x30
		private GPUIExtendedSystem m_targetSystem; // 0x38
		private GPUIExtendedSystem m_instanceOwnerSystem; // 0x40
		private GPUIProxySyncManager m_syncManager; // 0x48
		private bool m_syncManagerExplicitlySet; // 0x50
		private bool m_missingSyncManagerLogged; // 0x51
		private bool m_missingTargetSystemLogged; // 0x52
		private bool m_positionDirty; // 0x53
		private bool m_hasSyncedPosition; // 0x54
		private Vector2 m_lastCanvasLocalPosition; // 0x58
	
		// Properties
		public string prefabName { get; } // 0x000000018B0B4A64-0x000000018B0B4AB4 
		public bool autoCreate { get; } // 0x000000018B0B49C8-0x000000018B0B4A14 
		public int sortingOrder { get; } // 0x000000018B0B4AB4-0x000000018B0B4B00 
		public GPUIExtendedSystem targetSystem { get; } // 0x0000000182F46D50-0x0000000182F46DC0 
		public GPUIProxySyncManager syncManager { get; } // 0x000000018B0B4B00-0x000000018B0B4B50 
		public GPUIHandle handle { get; } // 0x0000000182F46DC0-0x0000000182F46E30 
		public bool hasInstance { get; } // 0x000000018B0B4A14-0x000000018B0B4A64 
	
		// Constructors
		public GPUIPrefabProxyBase(); // 0x000000018461E660-0x000000018461E690
	
		// Methods
		public void SetSyncManager(GPUIProxySyncManager syncManager); // 0x0000000183AA5D30-0x0000000183AA5EF0
		public bool TryCreateInstance(); // 0x0000000183AA82A0-0x0000000183AA9520
		public bool TryDestroyInstance(); // 0x0000000183AA61C0-0x0000000183AA62E0
		[IDTag(1)]
		public bool TrySyncPosition(); // 0x000000018B0B4748-0x000000018B0B47D4
		public void MarkPositionDirty(); // 0x0000000183AA5F30-0x0000000183AA5F60
		public bool IsHandleValid(); // 0x0000000182F46080-0x0000000182F462A0
		protected virtual void OnInstanceCreated(); // 0x0000000183AA9520-0x0000000183AA9550
		protected virtual void OnInstanceDestroyed(); // 0x0000000184776CA0-0x0000000184776CD0
		internal void TryPrepareForBeforeRender(); // 0x0000000183096830-0x00000001830968A0
		[IDTag(0)]
		internal bool TrySyncPosition(RectTransform targetCanvasRect, Camera targetCamera, bool forceSync = false /* Metadata: 0x0232FF71 */); // 0x00000001830968A0-0x0000000183096AB0
		protected virtual void Awake(); // 0x0000000184695C70-0x0000000184695CB0
		protected virtual void OnEnable(); // 0x0000000183AA4FA0-0x0000000183AA5010
		protected virtual void OnDisable(); // 0x0000000183AA43A0-0x0000000183AA43F0
		protected virtual void OnRectTransformDimensionsChange(); // 0x0000000183AA5EF0-0x0000000183AA5F30
		protected virtual void OnTransformParentChanged(); // 0x000000018B0B4604-0x000000018B0B4748
		protected virtual void OnDidApplyAnimationProperties(); // 0x000000018B0B45B4-0x000000018B0B4604
		private void _CacheRectTransform(); // 0x0000000183AA6620-0x0000000183AA6680
		private bool _TryResolveRuntimeReferences(); // 0x000000018B0B47D4-0x000000018B0B4848
		private bool _TryResolveSyncManager(); // 0x0000000183AA6680-0x0000000183AA6720
		private bool _TryResolveTargetSystem(); // 0x0000000183AA6380-0x0000000183AA64C0
		private void _HandleTargetSystemChanged(GPUIExtendedSystem oldTargetSystem); // 0x0000000183AA5F60-0x0000000183AA6040
		private bool _TryResolveTargetCanvas(out RectTransform targetCanvasRect, out Camera targetCamera); // 0x000000018B0B4848-0x000000018B0B49C8
		private bool _TryGetCanvasLocalPosition(RectTransform targetCanvasRect, Camera targetCamera, out Vector2 canvasLocalPosition); // 0x0000000183096250-0x0000000183096560
	}

	[DisallowMultipleComponent]
	[RequireComponent(typeof(GPUIExtendedSystem))]
	public class GPUIProxySyncManager : MonoBehaviour // TypeDefIndex: 50597
	{
		// Fields
		private GPUIExtendedSystem m_targetSystem; // 0x18
		private GPUIExtendedSystem m_boundSystem; // 0x20
		private readonly List<GPUIPrefabProxyBase> m_activeProxies; // 0x28
		private CanvasSnapshot m_lastSnapshot; // 0x30
	
		// Properties
		public GPUIExtendedSystem targetSystem { get; } // 0x000000018B0B4C40-0x000000018B0B4C90 
	
		// Nested types
		private struct CanvasSnapshot // TypeDefIndex: 50596
		{
			// Fields
			public Matrix4x4 matrix; // 0x00
			public float scaleFactor; // 0x40
			public UnityEngine.RenderMode renderMode; // 0x44
			public Camera camera; // 0x48
			public int screenWidth; // 0x50
			public int screenHeight; // 0x54
		}
	
		// Constructors
		public GPUIProxySyncManager(); // 0x00000001848E2670-0x00000001848E2760
	
		// Methods
		public bool TryResolveTargetSystem(out GPUIExtendedSystem targetSystem); // 0x0000000183AA64C0-0x0000000183AA6570
		public void RegisterProxy(GPUIPrefabProxyBase proxy); // 0x0000000183AA81B0-0x0000000183AA82A0
		public void UnregisterProxy(GPUIPrefabProxyBase proxy); // 0x0000000183AA31E0-0x0000000183AA3290
		public void MarkDirty(GPUIPrefabProxyBase proxy); // 0x000000018B0B4B50-0x000000018B0B4BF0
		public void FlushBeforeRender(); // 0x0000000183096560-0x0000000183096830
		private void OnEnable(); // 0x0000000184D1A850-0x0000000184D1A890
		private void OnDisable(); // 0x000000018B0B4BF0-0x000000018B0B4C40
		private void _AutoAssignTargetSystem(); // 0x0000000183AA6570-0x0000000183AA6620
		private void _RegisterToSystem(); // 0x0000000183AA9550-0x0000000183AA96A0
		private void _UnregisterFromSystem(); // 0x0000000184CACF00-0x0000000184CACFD0
		private static bool _TryResolveCanvasContext(Canvas canvas, out RectTransform canvasRect, out Camera camera); // 0x0000000183096AB0-0x0000000183096CF0
		private bool _SnapshotAndCheckChanged(Canvas canvas, RectTransform canvasRect, Camera camera); // 0x0000000183096EF0-0x0000000183097530
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public abstract class GPUISharedGraphicBase : MaskableGraphic // TypeDefIndex: 50599
	{
		// Fields
		public static readonly string CONFIG_JSON_PATH_FORMAT; // 0x00
		public const int RENDER_BUFFER_INIT_CAPACITY = 400; // Metadata: 0x0232FF7B
		public const int RENDER_BUFFER_MAX_CAPACITY = 65535; // Metadata: 0x0232FF7D
		public static readonly int RENDER_GROUP_SIZE; // 0x08
		public static readonly int RENDER_GROUP_SIZE_GL; // 0x0C
		public List<Material> materialTemplates; // 0xE8
		public string configGroupName; // 0xF0
		protected readonly List<Material> m_instancedMaterials; // 0xF8
		protected Transform m_targetCanvasTransform; // 0x100
		protected Matrix4x4 m_canvasObjectToWorldMatrix; // 0x108
		protected bool m_inited; // 0x148
		protected bool m_rendererDisabled; // 0x149
	
		// Nested types
		protected static class ShaderIDs // TypeDefIndex: 50598
		{
			// Fields
			internal static readonly int CANVAS_OBJECT_TO_WORLD_MATRIX; // 0x00
			internal static readonly int VAT_TEX; // 0x04
			internal static readonly int MAIN_TEX; // 0x08
			internal static readonly int SPRITE_TEX; // 0x0C
	
			// Constructors
			static ShaderIDs(); // 0x0000000184CB1600-0x0000000184CB16D0
		}
	
		// Constructors
		protected GPUISharedGraphicBase(); // 0x0000000183B96820-0x0000000183B96930
		static GPUISharedGraphicBase(); // 0x0000000184D28180-0x0000000184D28210
	
		// Methods
		protected void InitializeSharedState(); // 0x0000000183941B20-0x0000000183941D00
		protected void UpdateSharedTextures(Texture vatTexture, Texture fontTexture, Texture spriteTexture); // 0x0000000183940D70-0x00000001839410E0
		protected void UpdateWorldMat(bool force = false /* Metadata: 0x0232FF7A */); // 0x0000000183AA7D30-0x0000000183AA81B0
		protected virtual void InitMaterials(); // 0x00000001849CDE20-0x00000001849CE070
		protected void CleanMaterials(); // 0x00000001839424C0-0x0000000183942650
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000184624990-0x0000000184624BF0
		protected override void UpdateMaterial(); // 0x00000001837DCB40-0x00000001837DCC60
		protected override void OnDestroy(); // 0x000000018B0B4C90-0x000000018B0B4CEC
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0B4CEC-0x000000018B0B4CF4
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0); // 0x000000018B085BD4-0x000000018B085BDC
		public void __iFixBaseProxy_UpdateMaterial(); // 0x000000018B0B4CF4-0x000000018B0B4CFC
	}

	[DisallowMultipleComponent]
	public class GPUISubrootTag : MonoBehaviour // TypeDefIndex: 50600
	{
		// Fields
		[SerializeField]
		private string _subrootName; // 0x18
	
		// Properties
		public string subrootName { get; } // 0x000000018B0B4D58-0x000000018B0B4DA8 
	
		// Constructors
		public GPUISubrootTag(); // 0x000000018B0B4CFC-0x000000018B0B4D58
	}

	public class GPUISystem : GPUISharedGraphicBase // TypeDefIndex: 50601
	{
		// Fields
		public static readonly int PREFAB_BUFFER_SIZE; // 0x00
		public static readonly int PREFAB_BUFFER_FONT_SIZE; // 0x04
		public int sourceCNFontId; // 0x150
		private TMP_FontAsset m_i18NFontAsset; // 0x158
		public bool noSortingOrder; // 0x160
		private bool m_liteMode; // 0x161
		private Texture m_vatTexture; // 0x168
		private Texture m_spriteTexture; // 0x170
		private FAssetProxyHandle m_vatTextureHandle; // 0x178
		private FAssetProxyHandle m_spriteTextureHandle; // 0x18C
		private float m_timeForShader; // 0x1A0
		private Dictionary<string, RuntimePrefabData> m_prefabMap; // 0x1A8
		private List<RuntimeInstance> m_instances; // 0x1B0
		private Queue<int> m_recyclePool; // 0x1B8
		private List<KeyValuePair<float, GPUIHandle>> m_destroyQueue; // 0x1C0
		private ITextSystem m_simpleTextSystem; // 0x1C8
		[CanBeNull]
		private ExInstanceBufferManager<RuntimeInstance, GPUInstanceData> m_instanceBufferManager; // 0x1D0
		[CanBeNull]
		private SimpleBufferManager<GPUPrefabData> m_prefabBufferManager; // 0x1D8
		[CanBeNull]
		private SimpleBufferManager<GPUPrefabDataLite> m_litePrefabBufferManager; // 0x1E0
	
		// Properties
		public TMP_FontAsset fontAsset { get; set; } // 0x000000018465A480-0x000000018465A5D0 0x000000018B0B53B4-0x000000018B0B54A8
	
		// Constructors
		public GPUISystem(); // 0x00000001849598B0-0x0000000184959A60
		static GPUISystem(); // 0x0000000184D5DF50-0x0000000184D5DFA0
	
		// Methods
		public bool CreateInstance(string prefabName, Vector3 initialPosition, out GPUIHandle handle, int sortingOrder = 0 /* Metadata: 0x0232FF81 */); // 0x0000000183AAA690-0x0000000183AAA740
		public bool DestroyInstance(GPUIHandle handle); // 0x0000000183AAA520-0x0000000183AAA5A0
		public bool IsInstanceValid(GPUIHandle handle); // 0x0000000183098800-0x0000000183098840
		public bool SetRootPosition(GPUIHandle handle, Vector3 position); // 0x00000001830988A0-0x0000000183098960
		public bool SetRootScale(GPUIHandle handle, Vector2 scale); // 0x000000018B0B4EB8-0x000000018B0B4FA0
		[IDTag(0)]
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, string animationName, bool resetDestroy = false /* Metadata: 0x0232FF82 */); // 0x0000000183AA6720-0x0000000183AA7910
		[IDTag(1)]
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, int animationIndex = 0 /* Metadata: 0x0232FF83 */, bool resetDestroy = false /* Metadata: 0x0232FF84 */); // 0x000000018B0B50A8-0x000000018B0B52E4
		public bool SetVisibility(GPUIHandle handle, string nodeName, bool visible); // 0x000000018B0B4FA0-0x000000018B0B50A8
		public bool SetColor(GPUIHandle handle, string nodeName, UnityEngine.Color color); // 0x000000018363BD90-0x000000018363BE90
		public bool SetText(GPUIHandle handle, string nodeName, string text); // 0x000000018363BE90-0x000000018363BF90
		protected override void OnDestroy(); // 0x000000018B0B4DA8-0x000000018B0B4E04
		protected override void OnEnable(); // 0x0000000184659D90-0x0000000184659EA0
		protected override void OnDisable(); // 0x000000018B0B4E04-0x000000018B0B4EB8
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000184624950-0x0000000184624990
		protected override void UpdateMaterial(); // 0x00000001837DC750-0x00000001837DC790
		private void _PreWillRenderCanvases(); // 0x0000000183AA7910-0x0000000183AA7950
		private void _Init(string jsonPath); // 0x0000000184659EA0-0x000000018465A480
		protected TMP_FontAsset GetFontAsset(); // 0x000000018465A5D0-0x000000018465A650
		private void _DoLateUpdate(); // 0x0000000183AA7950-0x0000000183AA7A00
		private void _DisposeLoadedTextures(); // 0x0000000184D50C00-0x0000000184D50C50
		private void _DoOnDestroy(); // 0x000000018B0B52F4-0x000000018B0B53B4
		private void _RenderNodes(); // 0x0000000183AA7AE0-0x0000000183AA7C70
		private void _DestroyAnimatedInstance(); // 0x0000000183AA7A00-0x0000000183AA7AE0
		private void _PreloadTextInGroupData(PrefabGroupSerializeData data); // 0x00000001839430E0-0x00000001839435F0
		private void _LoadGroupData(PrefabGroupSerializeData data); // 0x00000001839435F0-0x0000000183943C60
		private RuntimePrefabData _LoadPrefabData(PrefabSerializeData prefab); // 0x000000018363DF90-0x000000018363ED30
		private int _LoadPrefabNodeBuffer(PrefabSerializeData prefab, int totalNodeCount); // 0x00000001840FB390-0x00000001840FB5C0
		private bool _CreateInstance(string prefabName, out GPUIHandle handle, int sortingOrder); // 0x0000000183AAA150-0x0000000183AAA240
		private bool _DestroyInstance(GPUIHandle handle); // 0x0000000183AAA350-0x0000000183AAA400
		private GPUIHandle _GetOneHandle(); // 0x0000000183AAA240-0x0000000183AAA350
		private bool _IsHandleInvalid(GPUIHandle handle); // 0x0000000183098960-0x00000001830989E0
		private void _RecycleOneHandle(GPUIHandle handle); // 0x0000000183AAA100-0x0000000183AAA150
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018B0B42F4-0x000000018B0B42FC
		public void __iFixBaseProxy_OnEnable(); // 0x000000018B0B4304-0x000000018B0B430C
		public void __iFixBaseProxy_OnDisable(); // 0x000000018B0B42FC-0x000000018B0B4304
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0); // 0x000000018B0B52E4-0x000000018B0B52EC
		public void __iFixBaseProxy_UpdateMaterial(); // 0x000000018B0B52EC-0x000000018B0B52F4
	}

	public static class GPUIUtils // TypeDefIndex: 50602
	{
		// Fields
		public static readonly Vector3 DEFAULT_NORMAL; // 0x00
		public static readonly Vector4 DEFAULT_TANGENT; // 0x0C
	
		// Constructors
		static GPUIUtils(); // 0x0000000184B52960-0x0000000184B529D0
	
		// Methods
		public static Mesh CreateQuadMesh(); // 0x000000018B0B54A8-0x000000018B0B58E0
		public static uint ColorToRGBAUint32(UnityEngine.Color color); // 0x000000018363C340-0x000000018363C3A0
	}

	internal abstract class InstanceBufferManagerBase<TInstance, TData> : IDisposable // TypeDefIndex: 50603
		where TInstance : BaseRuntimeInstance<TData>
		where TData : struct
	{
		// Properties
		public abstract int nodeCount { get; }
		public abstract NativeArray<CanvasRenderer.InstanceRange> gpuGroups { get; }
		public abstract int gpuGroupCount { get; }
	
		// Constructors
		protected InstanceBufferManagerBase();
	
		// Methods
		public abstract void BindInstanceList(List<TInstance> runtimeInstanceView);
		public abstract void MarkNeedUpdate();
		public abstract void Add(GPUIHandle handle);
		public abstract void Remove(GPUIHandle handle);
		public abstract void DoUpdate(CanvasRenderer canvasRenderer);
		public abstract void Dispose();
	}

	internal sealed class RuntimeInstance : BaseRuntimeInstance<GPUInstanceData> // TypeDefIndex: 50604
	{
		// Fields
		public const int ROOT_NODE_INDEX = 0; // Metadata: 0x0232FF86
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
		public RuntimePrefabData Prefab { get; } // 0x000000018363BF90-0x000000018363BFC0 
		public float AnimationDuration { get; } // 0x00000001848ACC20-0x00000001848ACC50 
	
		// Constructors
		public RuntimeInstance(); // 0x0000000184D33C40-0x0000000184D33C70
	
		// Methods
		public void Create(RuntimePrefabData prefab, ITextSystem textSystem); // 0x00000001844299D0-0x0000000184429B20
		public override void Recycle(); // 0x00000001847D8430-0x00000001847D8460
		public override void DoUpdate(ref NativeArray<GPUInstanceData> buffer, int startIndexInBuffer, bool full); // 0x000000018363ED70-0x000000018363F060
		public void SetRootScale(Vector2 rootScale); // 0x000000018B0B5B14-0x000000018B0B5B94
		public void SetPosition(int index, Vector3 position); // 0x00000001830989E0-0x0000000183098A60
		public void StartAnimation(float animationTime, int animationIndex = 0 /* Metadata: 0x0232FF85 */); // 0x0000000184429B20-0x0000000184429BB0
		public void SetVisibility(int index, bool visible); // 0x000000018B0B5B94-0x000000018B0B5C34
		public void SetColor(int index, UnityEngine.Color newColor); // 0x000000018363BFC0-0x000000018363C060
		public void SetText(int index, string text); // 0x000000018363C550-0x000000018363C6B0
	}

	internal class SimpleBufferManager<T> : IDisposable // TypeDefIndex: 50605
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
		public NativeArray<T> cpuArray { get; }
	
		// Constructors
		public SimpleBufferManager(int initCapacity, CanvasRenderer canvasRenderer);
	
		// Methods
		public void Dispose();
		public void Reset();
		public void OpenWrite();
		public void Freeze();
		public bool Allocate(int size, out int index);
	}

	internal sealed class SimpleInstanceBufferManager<TInstance, TData> : InstanceBufferManagerBase<TInstance, TData> // TypeDefIndex: 50606
		where TInstance : BaseRuntimeInstance<TData>
		where TData : struct
	{
		// Fields
		private readonly int m_gpuGroupCapacity;
		private readonly List<GPUIHandle> m_handles;
		private NativeArray<CanvasRenderer.InstanceRange> m_gpuGroups;
		private List<TInstance> m_runtimeInstanceView;
		private bool m_hasAnyChanges;
		private int m_capacity;
		private int m_groupCount;
		private int m_currentLength;
	
		// Properties
		public override int nodeCount { get; }
		public override NativeArray<CanvasRenderer.InstanceRange> gpuGroups { get; }
		public override int gpuGroupCount { get; }
	
		// Constructors
		public SimpleInstanceBufferManager(int initCapacity, int gpuGroupCapacity);
	
		// Methods
		public override void BindInstanceList(List<TInstance> runtimeInstanceView);
		public override void MarkNeedUpdate();
		public override void Add(GPUIHandle handle);
		public override void Remove(GPUIHandle handle);
		public override void DoUpdate(CanvasRenderer canvasRenderer);
		private void _AddGroup(int start, int end);
		private void _EnsureGroupCapacity(int capacity);
		public override void Dispose();
	}

	internal interface ITextSystem // TypeDefIndex: 50607
	{
		// Methods
		void RegisterCharacterToPrefabBuffer(string text);
		void UploadBufferIfNeeded();
		int GetNodeCount(string text);
		void CreateTextNodes(string text, NativeArray<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment);
		void CreateTextNodes(string text, List<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment);
	}

	internal sealed class SimpleTextSystem<T> : BaseTextSystem<T>, ITextSystem // TypeDefIndex: 50608
		where T : struct
	{
		// Constructors
		public SimpleTextSystem(int fontBufferCapacity, Func<Vector4, Vector4, Vector2, T> creatorFunc);
	
		// Methods
		public void CreateTextNodes(string text, NativeArray<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment);
		public void CreateTextNodes(string text, List<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment);
		private GPUInstanceData _CreateGlyphInstance(CharOffsetData<T> textWidth, float currentX, int parentId, int grandParentId);
	}
}

namespace Beyond.UI.UIState
{
	internal class OnValueChangedAttribute : PropertyAttribute // TypeDefIndex: 50522
	{
		// Fields
		[CompilerGenerated]
		private readonly string _actionName_k__BackingField; // 0x10
	
		// Properties
		public string actionName { [CompilerGenerated] get; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 
	
		// Constructors
		public OnValueChangedAttribute(string name); // 0x00000001853908C0-0x00000001853908D0
	}

	public class StateAnimationInfo // TypeDefIndex: 50523
	{
		// Fields
		[CompilerGenerated]
		private bool _IsFinished_k__BackingField; // 0x10
		[CompilerGenerated]
		private readonly AnimationClip _Clip_k__BackingField; // 0x18
		[CompilerGenerated]
		private readonly GameObject _Target_k__BackingField; // 0x20
		[CompilerGenerated]
		private float _StartTime_k__BackingField; // 0x28
		private readonly float m_duration; // 0x2C
	
		// Properties
		public bool IsFinished { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001815EFCE0-0x00000001815EFCF0 0x0000000184D86130-0x0000000184D86140
		public AnimationClip Clip { [CompilerGenerated] get; } // 0x000000018385B100-0x000000018385B110 
		public GameObject Target { [CompilerGenerated] get; } // 0x0000000184D862C0-0x0000000184D862D0 
		public float StartTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86BF0-0x0000000184D86C00 0x0000000184D86C00-0x0000000184D86C10
	
		// Constructors
		public StateAnimationInfo(AnimationClip clip, GameObject target); // 0x000000018B1005C4-0x000000018B100618
	
		// Methods
		public void OnUpdate(); // 0x000000018B100514-0x000000018B1005C4
	}

	public enum AnimationImpactType // TypeDefIndex: 50524
	{
		StartAnimation = 0,
		StopAnimation = 1
	}

	[Serializable]
	public class StateDescription // TypeDefIndex: 50525
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
		[CompilerGenerated]
		private Material _ImageMaterialClone_k__BackingField; // 0x148
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
		public Vector2 scrollListSpace; // 0x224
		public Selectable selectable; // 0x230
		public bool selectableInteractable; // 0x238
		public UIStateController uiStateController; // 0x240
		public string stateName; // 0x248
		[OnValueChanged("_OnTextChanged")]
		public UIText text; // 0x250
		public TextImpactType textImpact; // 0x258
		public UnityEngine.Color textColor; // 0x25C
		public string textId; // 0x270
		public float textFontSize; // 0x278
		public float textMaxFontSize; // 0x27C
		public Vector2 textMaxSize; // 0x280
		public Vector2 textMinSize; // 0x288
		public HorizontalAlignmentOptions textHorizontalAlignment; // 0x290
	
		// Properties
		public bool IsEmpty { get; } // 0x0000000183CEB110-0x0000000183CEB2E0 
		public string ReadableDescription { get; } // 0x000000018B102740-0x000000018B103998 
		public Material ImageMaterialClone { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D8DAC0-0x0000000184D8DAD0 0x0000000186B8B468-0x0000000186B8B47C
	
		// Constructors
		public StateDescription(); // 0x0000000183F09B90-0x0000000183F09BE0
	
		// Methods
		public bool EqualsAnimation(StateDescription other); // 0x000000018B100D4C-0x000000018B100DE4
		public float ApplyAnimation(StateReference state); // 0x000000018B100618-0x000000018B100794
		public bool EqualsAnimator(StateDescription other); // 0x000000018B100DE4-0x000000018B100E7C
		public void ApplyAnimator(); // 0x000000018B100794-0x000000018B1008B8
		public bool EqualsButton(StateDescription other); // 0x000000018B100E7C-0x000000018B100F14
		public void ApplyButton(); // 0x000000018B1008B8-0x000000018B100918
		public bool EqualsCanvasGroup(StateDescription other); // 0x000000018B100F14-0x000000018B100FB4
		public void ApplyCanvasGroup(); // 0x00000001848F6D00-0x00000001848F6D60
		public bool EqualsComponent(StateDescription other); // 0x000000018B100FB4-0x000000018B101054
		public void ApplyComponent(); // 0x000000018B100918-0x000000018B10097C
		public override string ToString(); // 0x000000018B1018B4-0x000000018B101948
		public static bool operator ==(StateDescription left, StateDescription right); // 0x000000018B103998-0x000000018B103A14
		public static bool operator !=(StateDescription left, StateDescription right); // 0x000000018B103A14-0x000000018B103A7C
		[IDTag(1)]
		public override bool Equals(object obj); // 0x000000018B1017C0-0x000000018B101850
		public override int GetHashCode(); // 0x000000018B101850-0x000000018B1018B4
		[IDTag(0)]
		public bool Equals(StateDescription other); // 0x000000018B101734-0x000000018B1017C0
		private bool _EqualsByTargetType(StateDescription other); // 0x000000018B101948-0x000000018B101B90
		private int _GetTargetHashCode(); // 0x000000018B101B90-0x000000018B101C70
		public bool EqualsGameObject(StateDescription other); // 0x000000018B101054-0x000000018B1010F4
		public void ApplyGameObject(); // 0x0000000183CEB2E0-0x0000000183CEB330
		public bool EqualsGraphic(StateDescription other); // 0x000000018B1010F4-0x000000018B101194
		public void ApplyGraphic(); // 0x000000018B10097C-0x000000018B1009E4
		public bool EqualsGridLayoutGroup(StateDescription other); // 0x000000018B101194-0x000000018B101234
		public void ApplyGridLayoutGroup(); // 0x000000018B1009E4-0x000000018B100B38
		private void _OnGridLayoutGroupChanged(); // 0x000000018B101C70-0x000000018B101D80
		public bool EqualsImage(StateDescription other); // 0x000000018B101234-0x000000018B1012D4
		public void ApplyImage(); // 0x0000000183CEB8D0-0x0000000183CEB970
		private void _OnImageChanged(); // 0x000000018B101D80-0x000000018B101ED4
		public bool EqualsLayoutElement(StateDescription other); // 0x000000018B1012D4-0x000000018B101374
		public void ApplyLayoutElement(); // 0x000000018344CAC0-0x000000018344CB70
		private void _OnLayoutElementChanged(); // 0x000000018B101ED4-0x000000018B101FA0
		public bool EqualsLayoutGroup(StateDescription other); // 0x000000018B101374-0x000000018B101414
		public void ApplyLayoutGroup(); // 0x00000001849955D0-0x00000001849956B0
		private void _OnLayoutGroupChanged(); // 0x000000018B101FA0-0x000000018B102098
		public bool EqualsRectTransform(StateDescription other); // 0x000000018B101414-0x000000018B1014B4
		public void ApplyRectTransform(); // 0x0000000183CEB970-0x0000000183CEBCC0
		private void _OnRectTransformChanged(); // 0x000000018B102098-0x000000018B10256C
		public bool EqualsScrollList(StateDescription other); // 0x000000018B1014B4-0x000000018B101554
		public void ApplyScrollList(); // 0x000000018B100BA0-0x000000018B100CE8
		private void _OnScrollListChanged(); // 0x000000018B10256C-0x000000018B102660
		public bool EqualsSelectable(StateDescription other); // 0x000000018B101554-0x000000018B1015F4
		public void ApplySelectable(); // 0x000000018B100CE8-0x000000018B100D4C
		public bool EqualsState(StateDescription other); // 0x000000018B1015F4-0x000000018B101694
		public float ApplyInnerState(); // 0x000000018B100B38-0x000000018B100BA0
		public bool EqualsText(StateDescription other); // 0x000000018B101694-0x000000018B101734
		public void ApplyText(); // 0x0000000183CEB370-0x0000000183CEB8D0
		private void _OnTextChanged(); // 0x000000018B102660-0x000000018B102740
		public string __iFixBaseProxy_ToString(); // 0x000000018669AD6C-0x000000018669AD74
		public bool __iFixBaseProxy_Equals(object P0); // 0x0000000182FB1840-0x0000000182FB1850
		public int __iFixBaseProxy_GetHashCode(); // 0x0000000184D87100-0x0000000184D87110
	}

	public enum AnimatorImpactType // TypeDefIndex: 50526
	{
		SetBoolTrue = 0,
		SetBoolFalse = 1,
		SetTrigger = 2,
		ResetTrigger = 3,
		SetInteger = 4,
		SetFloat = 5
	}

	public enum CanvasGroupImpactType // TypeDefIndex: 50527
	{
		SetAlpha = 0,
		SetInteractable = 1,
		SetColor = 2
	}

	public enum StateDescriptionTargetType // TypeDefIndex: 50528
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

	public enum GridLayoutGroupImpactType // TypeDefIndex: 50529
	{
		Padding = 0,
		Spacing = 1,
		CellSize = 2,
		ConstraintCount = 3
	}

	public enum ImageImpactType // TypeDefIndex: 50530
	{
		SetEnabled = 0,
		SetSprite = 1,
		SetColor = 2,
		SetMaterialFloatValue = 3
	}

	public enum LayoutElementImpactType // TypeDefIndex: 50531
	{
		LayoutElementPreferredWidth = 0,
		LayoutElementPreferredHeight = 1,
		LayoutElementMinWidth = 2,
		LayoutElementMinHeight = 3,
		LayoutElementFlexibleWidth = 4,
		LayoutElementFlexibleHeight = 5
	}

	public enum LayoutGroupImpactType // TypeDefIndex: 50532
	{
		Padding = 0,
		Spacing = 1,
		ChildAlignment = 2,
		ReverseArrangement = 3
	}

	public enum RectTransformImpactType // TypeDefIndex: 50533
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

	public enum ScrollListImpactType // TypeDefIndex: 50534
	{
		Padding = 0,
		Space = 1
	}

	public enum TextImpactType // TypeDefIndex: 50535
	{
		SetColor = 0,
		SetTextById = 1,
		SetFontSize = 2,
		SetHorizontalAlignment = 3,
		SetMaxFontSize = 4,
		SetMaxSize = 5,
		SetMinSize = 6
	}

	[Serializable]
	public class StateReference // TypeDefIndex: 50536
	{
		// Fields
		public string stateName; // 0x10
		public List<StateDescription> descriptions; // 0x18
		private List<StateAnimationInfo> m_scheduledForPlaying; // 0x20
		private List<StateAnimationInfo> m_scheduledForStopping; // 0x28
		private UIStateController m_controller; // 0x30
		private bool m_isDirty; // 0x38
	
		// Constructors
		public StateReference(); // 0x00000001839C46E0-0x00000001839C47A0
	
		// Methods
		public void SetController(UIStateController controller); // 0x0000000183CEB330-0x0000000183CEB370
		public void ScheduleForPlaying(StateAnimationInfo stateAnimationInfo); // 0x000000018B103A7C-0x000000018B103B1C
		public void ScheduleForStopping(StateAnimationInfo stateAnimationInfo); // 0x000000018B103B1C-0x000000018B103BBC
		public void HandleScheduledStates(); // 0x000000018401F580-0x000000018401F8F0
	}

	[ExecuteAlways]
	public class UIStateController : TickableUIMono // TypeDefIndex: 50538
	{
		// Fields
		public List<StateReference> states; // 0x68
		[CompilerGenerated]
		private string _currentStateName_k__BackingField; // 0x70
		private readonly List<StateAnimationInfo> m_animations; // 0x78
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001840CAFF0-0x00000001840CB020 
		public string currentStateName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D862B0-0x0000000184D862C0 0x00000001863AD760-0x00000001863AD770
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 50537
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<StateAnimationInfo> __9__10_0; // 0x08
	
			// Constructors
			static __c(); // 0x0000000184D4C690-0x0000000184D4C6F0
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _Tick_b__10_0(StateAnimationInfo info); // 0x000000018B103DD0-0x000000018B103DE8
		}
	
		// Constructors
		public UIStateController(); // 0x00000001839C4650-0x00000001839C46E0
	
		// Methods
		public void OnStateReferenceDirty(); // 0x000000018B106530-0x000000018B106580
		public float SetState(string stateName, bool forceUpdate = true /* Metadata: 0x0232FEE7 */); // 0x0000000183CEA2B0-0x0000000183CEA380
		private float _ApplyState(StateReference state); // 0x0000000183CEA380-0x0000000183CEB110
		public override void Tick(float deltaTime); // 0x000000018401E450-0x000000018401F530
		private void _HandleStateAnimations(StateReference stateReference); // 0x000000018401F530-0x000000018401F580
		public void Run(StateAnimationInfo newInfo); // 0x000000018B106580-0x000000018B1067B4
		public void Stop(StateAnimationInfo newInfo); // 0x000000018B1067B4-0x000000018B1069A0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x00000001869AFD0C-0x00000001869AFD14
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000181538B50-0x0000000181538B60
	}

	public static class UIStateControllerUtils // TypeDefIndex: 50539
	{
		// Fields
		private static float s_updateFinishTime; // 0x00
	
		// Methods
		public static void StartEditorUpdateLoop(float duration); // 0x000000018B1064E4-0x000000018B106530
	
		// Extension methods
		public static void ForceRebuildLayout(this GameObject gameObject); // 0x000000018B106338-0x000000018B106438
		public static void SetLeft(this RectTransform rt, float left); // 0x0000000183CEC7E0-0x0000000183CEC850
		public static void SetRight(this RectTransform rt, float right); // 0x0000000183CEC8C0-0x0000000183CEC930
		public static void SetTop(this RectTransform rt, float top); // 0x0000000184CA6FE0-0x0000000184CA7050
		public static void SetBottom(this RectTransform rt, float bottom); // 0x0000000184CAD810-0x0000000184CAD880
		public static string GetName(this UnityEngine.Object obj); // 0x000000018B106438-0x000000018B1064E4
	}
}

namespace Cysharp.Text
{
	public static class TextMeshProExtensions // TypeDefIndex: 50204
	{
		// Extension methods
		public static void SetText<T>(this TMP_Text text, T arg0);
		public static void SetTextFormat<T0>(this TMP_Text text, string format, T0 arg0);
		public static void SetTextFormat<T0, T1>(this TMP_Text text, string format, T0 arg0, T1 arg1);
		public static void SetTextFormat<T0, T1, T2>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2);
		public static void SetTextFormat<T0, T1, T2, T3>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3);
		public static void SetTextFormat<T0, T1, T2, T3, T4>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4);
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);
		public static void SetTextFormat<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this TMP_Text text, string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
		public static void SetText(this TMP_Text text, Utf16ValueStringBuilder stringBuilder); // 0x000000018B0874FC-0x000000018B0875DC
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 50203
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 50611
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x00000001832B2C30-0x00000001832B2C60
		static ILFixDynamicMethodWrapper(); // 0x0000000184D379C0-0x0000000184D37A30
	
		// Methods
		public void __Gen_Wrap_0(); // 0x00000001863625A4-0x0000000186362640
		public void __Gen_Wrap_1(object P0); // 0x00000001863633B4-0x0000000186363474
		public float __Gen_Wrap_2(object P0, bool P1); // 0x0000000189E3D9AC-0x0000000189E3DA98
		public float __Gen_Wrap_3(object P0); // 0x00000001866C0730-0x00000001866C0800
		public int __Gen_Wrap_4(object P0); // 0x0000000186360E84-0x0000000186360F54
		public TickType __Gen_Wrap_5(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public LuaPanel __Gen_Wrap_6(object P0); // 0x000000018B0B2484-0x000000018B0B2574
		public void __Gen_Wrap_7(object P0, object P1, bool P2); // 0x00000001866C43C8-0x00000001866C44C0
		public void __Gen_Wrap_8(object P0, float P1); // 0x00000001866C288C-0x00000001866C296C
		public string __Gen_Wrap_9(object P0, out bool P1); // 0x000000018B0B3AA8-0x000000018B0B3BD8
		public string __Gen_Wrap_10(object P0, int P1); // 0x000000018B09B4A4-0x000000018B09B5B0
		public UIText.HyperlinkUITextManager __Gen_Wrap_11(); // 0x000000018B09BB68-0x000000018B09BC34
		public bool __Gen_Wrap_12(object P0, object P1); // 0x0000000186366BC4-0x0000000186366CB0
		public UIText.HyperlinkUITextGroup __Gen_Wrap_13(object P0, object P1, bool P2); // 0x000000018B09CC78-0x000000018B09CDA0
		public void __Gen_Wrap_14(object P0, object P1); // 0x0000000186377B18-0x0000000186377BF4
		public string __Gen_Wrap_15(PhoneticType P0, object P1); // 0x000000018B09DE30-0x000000018B09DF28
		public void __Gen_Wrap_16(object P0, PhoneticType P1, object P2); // 0x0000000189C81AB0-0x0000000189C81B94
		public string __Gen_Wrap_17(object P0); // 0x000000018B09F148-0x000000018B09F238
		public void __Gen_Wrap_18(EnvLang P0); // 0x000000018635FF24-0x000000018635FFE4
		public bool __Gen_Wrap_19(object P0, object P1, out string P2); // 0x000000018B0A0350-0x000000018B0A04A0
		public bool __Gen_Wrap_20(object P0, Vector3 P1, out string P2); // 0x000000018B0A0B28-0x000000018B0A0CA4
		public IEnumerator __Gen_Wrap_21(object P0); // 0x000000018B0A15B4-0x000000018B0A16A4
		public string __Gen_Wrap_22(object P0, bool P1); // 0x000000018B0A1EAC-0x000000018B0A1FB8
		public Sprite __Gen_Wrap_23(object P0, object P1); // 0x000000018B0A2614-0x000000018B0A2720
		public int __Gen_Wrap_24(ReadOnlySpan<char> P0); // 0x000000018B0A2F24-0x000000018B0A302C
		public UIText.RichTextInfo __Gen_Wrap_25(UIText.RichTextAnalyzer.RichTextParam P0, object P1, ref Utf16ValueStringBuilder P2); // 0x000000018B0A369C-0x000000018B0A385C
		public UIText.RichTextInfo __Gen_Wrap_26(object P0, UIText.RichTextAnalyzer.RichTextParam P1, object P2, ref Utf16ValueStringBuilder P3); // 0x000000018B0A41A4-0x000000018B0A4364
		public UIText.RichTextAnalyzer.ProcessRichTextEntryFunc __Gen_Wrap_27(object P0); // 0x000000018B0A4B40-0x000000018B0A4C30
		public bool __Gen_Wrap_28(ReadOnlySpan<char> P0, out bool P1, out UIText.RichTextAnalyzer.RichTextParam P2); // 0x000000018B0A52EC-0x000000018B0A5494
		public bool __Gen_Wrap_29(ReadOnlySpan<char> P0, ref Utf16ValueStringBuilder P1, object P2, out UIText.RichTextInfo P3); // 0x000000018B0A5C5C-0x000000018B0A5E4C
		public string __Gen_Wrap_30(object P0, object P1, out List<UIText.RichTextInfo> P2); // 0x000000018B0A6700-0x000000018B0A6864
		public GameObject __Gen_Wrap_31(object P0); // 0x000000018B0A73B0-0x000000018B0A74A0
		public UIText.ImageGOInfo __Gen_Wrap_32(object P0, int P1); // 0x000000018B0A824C-0x000000018B0A837C
		public Material __Gen_Wrap_33(object P0); // 0x000000018B0A8EC0-0x000000018B0A8FB0
		public Material __Gen_Wrap_34(object P0, object P1); // 0x000000018B0A9514-0x000000018B0A9620
		public bool __Gen_Wrap_35(); // 0x00000001863623A8-0x0000000186362454
		public I18nFontSearchData __Gen_Wrap_36(); // 0x000000018B0AA978-0x000000018B0AAA44
		public bool __Gen_Wrap_37(object P0); // 0x00000001863632E4-0x00000001863633B4
		public TMP_FontAsset __Gen_Wrap_38(int P0); // 0x000000018B0AC144-0x000000018B0AC230
		public TMP_FontAsset __Gen_Wrap_39(object P0); // 0x000000018B0ACD1C-0x000000018B0ACE0C
		public void __Gen_Wrap_40(object P0, object P1, object P2, int P3); // 0x0000000189C808B0-0x0000000189C809A8
		public void __Gen_Wrap_41(object P0, object P1, int P2); // 0x00000001866F4838-0x00000001866F4930
		public bool __Gen_Wrap_42(object P0, int P1, out string P2); // 0x000000018B0AF3B0-0x000000018B0AF4F0
		public bool __Gen_Wrap_43(object P0, int P1, out Vector3 P2, out float P3); // 0x000000018B0B00CC-0x000000018B0B024C
		public void __Gen_Wrap_44(object P0, object P1, object P2); // 0x0000000186364290-0x0000000186364388
		public int __Gen_Wrap_45(UIText.HyperlinkUITextWrap P0, UIText.HyperlinkUITextWrap P1); // 0x00000001871AD678-0x00000001871AD750
		public List<UIText> __Gen_Wrap_46(object P0, object P1); // 0x000000018B0B0ED0-0x000000018B0B0FC8
		public List<UIText> __Gen_Wrap_47(object P0); // 0x000000018B0B0FC8-0x000000018B0B10A4
		public TMP_SubMeshUI __Gen_Wrap_48(object P0, object P1, MaterialReference P2); // 0x000000018B0B10A4-0x000000018B0B11F8
		public string __Gen_Wrap_49(int P0); // 0x000000018B0B11F8-0x000000018B0B12E4
		public Vector2 __Gen_Wrap_50(object P0, ref float P1, Vector2 P2, bool P3, bool P4); // 0x000000018B0B12E4-0x000000018B0B1474
		public int __Gen_Wrap_51(); // 0x00000001863621C4-0x0000000186362270
		public float __Gen_Wrap_52(); // 0x0000000189CB4A30-0x0000000189CB4ADC
		public GameObject __Gen_Wrap_53(object P0, object P1, object P2); // 0x000000018B0B1474-0x000000018B0B1588
		public void __Gen_Wrap_54(FAssetProxyUntrackedHandle P0); // 0x000000018B0B1588-0x000000018B0B1670
		public int __Gen_Wrap_55(object P0, object P1, object P2, object P3); // 0x00000001871B1424-0x00000001871B152C
		public void __Gen_Wrap_56(object P0, int P1); // 0x00000001866F3838-0x00000001866F3914
		public bool __Gen_Wrap_57(Vector3 P0, object P1, object P2); // 0x000000018B0B1670-0x000000018B0B17B4
		public bool __Gen_Wrap_58(Vector2 P0, object P1, object P2); // 0x000000018B0B17B4-0x000000018B0B18F0
		public Bounds __Gen_Wrap_59(object P0, object P1); // 0x000000018B0B18F0-0x000000018B0B1A10
		public bool __Gen_Wrap_60(int P0, out UnityEngine.InputSystem.EnhancedTouch.Touch P1); // 0x000000018B0B1A10-0x000000018B0B1B58
		public void __Gen_Wrap_61(object P0, UnityEngine.Color P1); // 0x000000018B0B1B58-0x000000018B0B1C6C
		public Rect __Gen_Wrap_62(object P0, object P1); // 0x000000018B0B1C6C-0x000000018B0B1D94
		public Vector2 __Gen_Wrap_63(object P0, object P1, Vector2 P2); // 0x000000018B0B1D94-0x000000018B0B1ED0
		public Vector3 __Gen_Wrap_64(object P0, object P1); // 0x000000018B0B1ED0-0x000000018B0B1FF0
		public UnityEngine.Color __Gen_Wrap_65(object P0); // 0x000000018B0B1FF0-0x000000018B0B20FC
		public float __Gen_Wrap_66(float P0); // 0x0000000189E20CFC-0x0000000189E20DB8
		public bool __Gen_Wrap_67(object P0, out string P1); // 0x000000018B0B20FC-0x000000018B0B2220
		public void __Gen_Wrap_68(object P0, object P1, CinemachineCore.Stage P2, ref CameraState P3, float P4); // 0x000000018B0B2220-0x000000018B0B2484
		public int __Gen_Wrap_69(object P0, int P1); // 0x00000001866C13F0-0x00000001866C14DC
		public Vector2 __Gen_Wrap_70(object P0, int P1); // 0x000000018B0B2574-0x000000018B0B266C
		public Vector2 __Gen_Wrap_71(); // 0x000000018B0B266C-0x000000018B0B2724
		public void __Gen_Wrap_72(Vector2 P0); // 0x000000018B0B2724-0x000000018B0B280C
		public void __Gen_Wrap_73(object P0, int P1, bool P2); // 0x00000001866C44C0-0x00000001866C45B8
		public Vector2Int __Gen_Wrap_74(object P0, float P1, float P2, float P3); // 0x000000018B0B280C-0x000000018B0B2948
		public Vector2Int __Gen_Wrap_75(object P0, float P1, bool P2); // 0x000000018B0B2948-0x000000018B0B2A70
		public Vector2Int __Gen_Wrap_76(object P0); // 0x000000018B0B2A70-0x000000018B0B2B60
		public void __Gen_Wrap_77(object P0, Vector2Int P1, Vector2Int P2); // 0x000000018B0B2B60-0x000000018B0B2C90
		public UIScrollList.Cell __Gen_Wrap_78(object P0); // 0x000000018B0B2C90-0x000000018B0B2D80
		public void __Gen_Wrap_79(object P0, bool P1); // 0x00000001866C2B40-0x00000001866C2C1C
		public DG.Tweening.Tween __Gen_Wrap_80(object P0); // 0x000000018B0B2D80-0x000000018B0B2E70
		public UIAnimationTween __Gen_Wrap_81(object P0); // 0x000000018B0B2E70-0x000000018B0B2F60
		public UnityEngine.AnimationState __Gen_Wrap_82(object P0, object P1); // 0x000000018B0B2F60-0x000000018B0B306C
		public void __Gen_Wrap_83(object P0, object P1, float P2); // 0x00000001871C15C8-0x00000001871C16C4
		public void __Gen_Wrap_84(object P0, object P1, float P2, bool P3); // 0x000000018B0B306C-0x000000018B0B3174
		public void __Gen_Wrap_85(object P0, object P1, object P2, UIConst.AnimationState P3, float P4, bool P5, float P6); // 0x000000018B0B3174-0x000000018B0B32AC
		public void __Gen_Wrap_86(object P0, float P1, bool P2); // 0x00000001871C0948-0x00000001871C0A44
		public AnimationClip __Gen_Wrap_87(object P0); // 0x000000018B0B32AC-0x000000018B0B339C
		public void __Gen_Wrap_88(object P0, object P1, bool P2, float P3); // 0x00000001871B8250-0x00000001871B8358
		public void __Gen_Wrap_89(object P0, int P1, bool P2, bool P3); // 0x000000018B0B339C-0x000000018B0B34A4
		public void __Gen_Wrap_90(object P0, Vector2Int P1); // 0x000000018B0B34A4-0x000000018B0B35B4
		public void __Gen_Wrap_91(object P0, bool P1, bool P2, bool P3); // 0x000000018B0B35B4-0x000000018B0B36BC
		public UIScrollList.MoveTipsType __Gen_Wrap_92(object P0); // 0x0000000186360E84-0x0000000186360F54
		public void __Gen_Wrap_93(object P0, Vector2 P1); // 0x000000018B0B36BC-0x000000018B0B37D0
		public void __Gen_Wrap_94(object P0, int P1, bool P2, UIScrollList.ScrollAlignType P3, bool P4); // 0x000000018B0B37D0-0x000000018B0B38DC
		public UIText __Gen_Wrap_95(object P0); // 0x000000018B0B38DC-0x000000018B0B39CC
		public Sprite __Gen_Wrap_96(object P0); // 0x000000018B0B39CC-0x000000018B0B3AA8
		public UIStyleInputValidTypeMask __Gen_Wrap_97(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public void __Gen_Wrap_98(object P0, UIStyleInputValidTypeMask P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public CustomUIStyle.OverrideValidState __Gen_Wrap_99(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public bool __Gen_Wrap_100(UIStyleInputValidType P0); // 0x0000000186361FA4-0x0000000186362070
		public void __Gen_Wrap_101(object P0, CustomUIStyle.OverrideValidState P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public bool __Gen_Wrap_102(UIStyleInputValidTypeMask P0); // 0x00000001863655AC-0x0000000186365664
		public void __Gen_Wrap_103(object P0, int P1, int P2); // 0x00000001866C2400-0x00000001866C24F8
		public void __Gen_Wrap_104(object P0, bool P1, bool P2); // 0x0000000187199240-0x0000000187199338
		public Beyond.UI.ScrollDirection __Gen_Wrap_105(object P0); // 0x0000000186360E84-0x0000000186360F54
		public float __Gen_Wrap_106(object P0, float P1, int P2); // 0x000000018B09B164-0x000000018B09B26C
		public float __Gen_Wrap_107(object P0, float P1, float P2); // 0x0000000189CBD694-0x0000000189CBD79C
		public void __Gen_Wrap_108(object P0, float P1, float P2, object P3, object P4); // 0x000000018B09B26C-0x000000018B09B388
		public void __Gen_Wrap_109(object P0, float P1, float P2, Interpolator.EEaseType P3, object P4); // 0x000000018B09B388-0x000000018B09B4A4
		public UILoopScrollRect.MovementDirection __Gen_Wrap_110(object P0, int P1, int P2); // 0x00000001871AFE44-0x00000001871AFF34
		public float __Gen_Wrap_111(object P0, float P1); // 0x00000001866D3DA4-0x00000001866D3E94
		public int __Gen_Wrap_112(object P0, float P1); // 0x0000000189CA0D64-0x0000000189CA0E3C
		public int __Gen_Wrap_113(object P0, int P1, int P2); // 0x00000001871AFE44-0x00000001871AFF34
		public void __Gen_Wrap_114(object P0, float P1, int P2, bool P3); // 0x000000018B09B5B0-0x000000018B09B6A8
		public Selectable __Gen_Wrap_115(object P0); // 0x000000018B09B6A8-0x000000018B09B798
		public bool __Gen_Wrap_116(object P0, Vector2 P1, object P2); // 0x000000018B09B798-0x000000018B09B8D4
		public IList<UIRecycleLayoutAdapter.IVirtualView> __Gen_Wrap_117(object P0); // 0x000000018B09B8D4-0x000000018B09B9B0
		public UIRecycleLayoutAdapter __Gen_Wrap_118(object P0); // 0x000000018B09B9B0-0x000000018B09BA8C
		public UIRecycleLayoutGroup.ViewMgr __Gen_Wrap_119(object P0); // 0x000000018B09BA8C-0x000000018B09BB68
		public UIRecycleLayoutGroup.Padding __Gen_Wrap_120(object P0); // 0x000000018B09BC34-0x000000018B09BD2C
		public RectTransform __Gen_Wrap_121(object P0); // 0x000000018B09BD2C-0x000000018B09BE1C
		public void __Gen_Wrap_122(object P0, object P1, UIRecycleLayoutGroup.LayoutMeta P2); // 0x000000018B09BE1C-0x000000018B09BF38
		public Vector2 __Gen_Wrap_123(object P0, Bounds P1); // 0x000000018B09BF38-0x000000018B09C060
		public Bounds __Gen_Wrap_124(object P0, UIRecycleLayoutGroup.LayoutMeta P1); // 0x000000018B09C060-0x000000018B09C1A4
		public UIRecycleLayoutAdapter __Gen_Wrap_125(object P0, object P1); // 0x000000018B09C1A4-0x000000018B09C29C
		public UIRecycleLayoutGroup.ViewPool __Gen_Wrap_126(object P0, object P1); // 0x000000018B09C29C-0x000000018B09C394
		public GameObject __Gen_Wrap_127(object P0, out bool P1); // 0x000000018B09C394-0x000000018B09C4B0
		public bool __Gen_Wrap_128(object P0, int P1, object P2); // 0x0000000189CAB6E4-0x0000000189CAB7D8
		public UIRecycleLayoutAdapter.IVirtualView __Gen_Wrap_129(object P0, int P1); // 0x000000018B09C4B0-0x000000018B09C5A8
		public float __Gen_Wrap_130(object P0, int P1); // 0x000000018B09C5A8-0x000000018B09C680
		public Bounds __Gen_Wrap_131(object P0, int P1); // 0x000000018B09C680-0x000000018B09C7A0
		public int __Gen_Wrap_132(object P0, object P1); // 0x00000001871AD678-0x00000001871AD750
		public UIRecycleLayoutGroup.Direction __Gen_Wrap_133(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public UIRecycleMultiHolder.MultiVirtualView __Gen_Wrap_134(object P0, int P1); // 0x000000018B09C7A0-0x000000018B09C898
		public void __Gen_Wrap_135(object P0, int P1, object P2, float P3); // 0x000000018B09C898-0x000000018B09C990
		public UIRecycleSingleHolder.SimpleVirtualView __Gen_Wrap_136(object P0, int P1); // 0x000000018B09C990-0x000000018B09CA88
		public ToastList.CellInfo __Gen_Wrap_137(object P0); // 0x000000018B09CA88-0x000000018B09CB64
		public IEnumerator __Gen_Wrap_138(object P0, int P1, object P2); // 0x000000018B09CB64-0x000000018B09CC78
		public bool __Gen_Wrap_139(object P0, object P1, object P2); // 0x0000000187195DFC-0x0000000187195F04
		public bool __Gen_Wrap_140(object P0, object P1, object P2, bool P3, out bool P4, bool P5); // 0x000000018B09CDA0-0x000000018B09CEF8
		public IBindingView __Gen_Wrap_141(object P0); // 0x000000018B09CEF8-0x000000018B09CFE8
		public PlayerActionInfo __Gen_Wrap_142(object P0); // 0x000000018B09CFE8-0x000000018B09D0D8
		public bool __Gen_Wrap_143(object P0, object P1, bool P2, bool P3); // 0x0000000187196850-0x0000000187196964
		public void __Gen_Wrap_144(Beyond.DeviceInfo.ControllerType P0); // 0x0000000186301ED4-0x0000000186301F80
		public void __Gen_Wrap_145(object P0, in EventData<string> P1); // 0x000000018B09D0D8-0x000000018B09D1F0
		public void __Gen_Wrap_146(object P0, object P1, object P2, bool P3); // 0x000000018B09D1F0-0x000000018B09D2E8
		public void __Gen_Wrap_147(object P0, int P1, object P2, object P3, bool P4); // 0x000000018B09D2E8-0x000000018B09D3F4
		public AnimationClip __Gen_Wrap_148(object P0, object P1, bool P2); // 0x000000018B09D3F4-0x000000018B09D508
		public AnimationClip __Gen_Wrap_149(object P0, object P1); // 0x000000018B09D508-0x000000018B09D600
		public void __Gen_Wrap_150(object P0, UIAnimationWrapper.FOptions P1); // 0x000000018B09D600-0x000000018B09D70C
		public float __Gen_Wrap_151(object P0, object P1); // 0x00000001866C0800-0x00000001866C08EC
		public void __Gen_Wrap_152(object P0, object P1, object P2, UIConst.AnimationState P3, float P4, bool P5); // 0x000000018B09D70C-0x000000018B09D834
		public UIAnimationWrapper.FOptions __Gen_Wrap_153(); // 0x000000018B09D834-0x000000018B09D8EC
		public void __Gen_Wrap_154(object P0, object P1, object P2, float P3); // 0x00000001871BE740-0x00000001871BE848
		public UISwitchTween.ITweenHandler __Gen_Wrap_155(object P0); // 0x000000018B09D8EC-0x000000018B09D9DC
		public UISwitchTween.ITweenHandler __Gen_Wrap_156(object P0, object P1); // 0x000000018B09D9DC-0x000000018B09DAE8
		public UISwitchTween.ITweenHandler __Gen_Wrap_157(object P0, bool P1); // 0x000000018B09DAE8-0x000000018B09DBF4
		public UIAnimationSwitchTween __Gen_Wrap_158(ref UIAnimationSwitchTween.Builder P0); // 0x000000018B09DBF4-0x000000018B09DD40
		public Camera __Gen_Wrap_159(object P0); // 0x000000018B09DD40-0x000000018B09DE30
		public void __Gen_Wrap_160(object P0, object P1, bool P2, bool P3, bool P4, bool P5, bool P6); // 0x000000018B09DF28-0x000000018B09E04C
		public void __Gen_Wrap_161(object P0, bool P1, bool P2, bool P3, bool P4, float P5); // 0x000000018B09E04C-0x000000018B09E164
		public IEnumerator __Gen_Wrap_162(object P0, object P1); // 0x000000018B09E164-0x000000018B09E270
		public DisposedUnityEvent __Gen_Wrap_163(object P0); // 0x000000018B09E270-0x000000018B09E34C
		public DisposedUnityEvent<int, bool> __Gen_Wrap_164(object P0); // 0x000000018B09E34C-0x000000018B09E428
		public UITouchPanel __Gen_Wrap_165(object P0); // 0x000000018B09E428-0x000000018B09E518
		public void __Gen_Wrap_166(object P0, out Vector2 P1, out Vector2 P2); // 0x000000018B09E518-0x000000018B09E678
		public Vector2 __Gen_Wrap_167(object P0, Vector2 P1); // 0x000000018B09E678-0x000000018B09E7A8
		public void __Gen_Wrap_168(PointerEventData P0); // 0x00000001866C296C-0x00000001866C2A18
		public void __Gen_Wrap_169(object P0, Vector3 P1); // 0x000000018B09E7A8-0x000000018B09E8C4
		public void __Gen_Wrap_170(object P0, bool P1, float P2, object P3, object P4); // 0x000000018B09E8C4-0x000000018B09E9E0
		public void __Gen_Wrap_171(float P0); // 0x00000001869ABD7C-0x00000001869ABE3C
		public void __Gen_Wrap_172(object P0, bool P1, out Selectable P2, out UITouchPanel P3); // 0x000000018B09E9E0-0x000000018B09EB6C
		public void __Gen_Wrap_173(object P0, float P1, float P2, object P3); // 0x000000018B09EB6C-0x000000018B09EC68
		public void __Gen_Wrap_174(object P0, object P1, bool P2, object P3); // 0x0000000189C8698C-0x0000000189C86A84
		public UIBigRectHelper.BigRectRecoverState __Gen_Wrap_175(object P0); // 0x000000018B09EC68-0x000000018B09ED44
		public void __Gen_Wrap_176(object P0, out float P1, out float P2); // 0x000000018B09ED44-0x000000018B09EE74
		public void __Gen_Wrap_177(object P0, object P1, UnityEngine.Color P2); // 0x000000018B09EE74-0x000000018B09EF90
		public Canvas __Gen_Wrap_178(object P0); // 0x000000018B09EF90-0x000000018B09F06C
		public HGCamera __Gen_Wrap_179(object P0); // 0x000000018B09F06C-0x000000018B09F148
		public RawImage __Gen_Wrap_180(object P0); // 0x000000018B09F238-0x000000018B09F314
		public Vector2 __Gen_Wrap_181(object P0); // 0x000000018B09F314-0x000000018B09F404
		public IBindingGroupTarget __Gen_Wrap_182(object P0); // 0x000000018B09F404-0x000000018B09F4E0
		public string __Gen_Wrap_183(object P0, object P1); // 0x000000018B09F4E0-0x000000018B09F5EC
		public BindingViewState __Gen_Wrap_184(object P0); // 0x0000000186360E84-0x0000000186360F54
		public string __Gen_Wrap_185(object P0, BindingViewActionType P1); // 0x000000018B09F5EC-0x000000018B09F6F8
		public bool __Gen_Wrap_186(object P0, out string P1, out string P2); // 0x000000018B09F6F8-0x000000018B09F864
		public ActionOnSetNaviTarget __Gen_Wrap_187(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public void __Gen_Wrap_188(object P0, ActionOnSetNaviTarget P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public HashSet<CanvasScaler> __Gen_Wrap_189(object P0); // 0x000000018B09F864-0x000000018B09F940
		public float __Gen_Wrap_190(out Vector2 P0); // 0x000000018B09F940-0x000000018B09FA54
		public UICanvasScaleHelper.FWorldCanvasParams __Gen_Wrap_191(object P0, object P1, bool P2); // 0x000000018B09FA54-0x000000018B09FB90
		public UICanvasScaleHelper.FScreenCanvasParams __Gen_Wrap_192(); // 0x000000018B09FB90-0x000000018B09FC80
		public void __Gen_Wrap_193(object P0, UIColorGroup.CommonParams P1); // 0x000000018B09FC80-0x000000018B09FD98
		public void __Gen_Wrap_194(object P0, object P1, UIColorGroup.CommonParams P2); // 0x000000018B09FD98-0x000000018B09FECC
		public void __Gen_Wrap_195(object P0, float P1, float P2, bool P3); // 0x000000018B09FECC-0x000000018B09FFC8
		public void __Gen_Wrap_196(object P0, UnityEngine.Color P1, float P2, bool P3, bool P4, bool P5); // 0x000000018B09FFC8-0x000000018B0A0114
		public void __Gen_Wrap_197(object P0, UnityEngine.Color P1, float P2, bool P3, bool P4); // 0x000000018B0A0114-0x000000018B0A0260
		public void __Gen_Wrap_198(object P0, GamepadKeyCode P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public UICustomLayoutElement __Gen_Wrap_199(object P0); // 0x000000018B0A0260-0x000000018B0A0350
		public UICustomLayoutElement.LayoutType __Gen_Wrap_200(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public bool __Gen_Wrap_201(object P0, out UICustomLayoutElement.LayoutData P1, bool P2, int P3); // 0x000000018B0A04A0-0x000000018B0A05F0
		public bool __Gen_Wrap_202(object P0, out UICustomLayoutElement.LayoutData P1, int P2); // 0x000000018B0A05F0-0x000000018B0A0730
		public void __Gen_Wrap_203(object P0, UICustomLayoutElement.LayoutType P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public CanvasGroup __Gen_Wrap_204(object P0); // 0x000000018B0A0730-0x000000018B0A080C
		public UIDialogText __Gen_Wrap_205(object P0); // 0x000000018B0A080C-0x000000018B0A08E8
		public void __Gen_Wrap_206(object P0, bool P1, object P2); // 0x0000000189CB9EA8-0x0000000189CB9F8C
		public void __Gen_Wrap_207(object P0, object P1, object P2, object P3); // 0x00000001866E8E30-0x00000001866E8F38
		public void __Gen_Wrap_208(object P0, int P1, bool P2, bool P3, bool P4); // 0x000000018B0A08E8-0x000000018B0A09FC
		public void __Gen_Wrap_209(object P0, Vector2 P1, bool P2); // 0x000000018B0A09FC-0x000000018B0A0B28
		public void __Gen_Wrap_210(object P0, int P1, int P2, bool P3); // 0x000000018B0A0CA4-0x000000018B0A0DA8
		public float __Gen_Wrap_211(object P0, bool P1, int P2); // 0x000000018B0A0DA8-0x000000018B0A0EAC
		public void __Gen_Wrap_212(object P0, bool P1, float P2, float P3); // 0x000000018B0A0EAC-0x000000018B0A0FB8
		public void __Gen_Wrap_213(object P0, Rect P1); // 0x000000018B0A0FB8-0x000000018B0A10CC
		public float __Gen_Wrap_214(object P0, object P1, bool P2); // 0x0000000189CBD4CC-0x0000000189CBD5D4
		public Vector3 __Gen_Wrap_215(object P0); // 0x000000018B0A10CC-0x000000018B0A11E0
		public Transform __Gen_Wrap_216(object P0); // 0x000000018B0A11E0-0x000000018B0A12D0
		public void __Gen_Wrap_217(object P0, int P1, float P2); // 0x000000018B0A12D0-0x000000018B0A13C8
		public bool __Gen_Wrap_218(object P0, bool P1, bool P2); // 0x000000018B0A13C8-0x000000018B0A14BC
		public Selectable __Gen_Wrap_219(object P0, bool P1); // 0x000000018B0A14BC-0x000000018B0A15B4
		public bool __Gen_Wrap_220(object P0, int P1, int P2, bool P3, bool P4); // 0x000000018B0A16A4-0x000000018B0A17B4
		public bool __Gen_Wrap_221(object P0, NaviDirection P1, bool P2); // 0x000000018B0A17B4-0x000000018B0A18A8
		public void __Gen_Wrap_222(object P0, NaviDirection P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public bool __Gen_Wrap_223(object P0, NaviDirection P1); // 0x00000001869AB898-0x00000001869AB970
		public bool __Gen_Wrap_224(object P0, int P1, out int P2, out bool P3, out int P4); // 0x000000018B0A18A8-0x000000018B0A1A24
		public bool __Gen_Wrap_225(object P0, int P1, out int P2, out int P3); // 0x000000018B0A1A24-0x000000018B0A1B70
		public void __Gen_Wrap_226(object P0, int P1, out int P2, out int P3); // 0x0000000186A60048-0x0000000186A60184
		public Vector2Int __Gen_Wrap_227(object P0, Vector2Int P1); // 0x000000018B0A1B70-0x000000018B0A1C90
		public Vector2Int __Gen_Wrap_228(object P0, Vector2Int P1, Vector2Int P2); // 0x000000018B0A1C90-0x000000018B0A1DD0
		public ValueTuple<float, float> __Gen_Wrap_229(object P0); // 0x000000018B0A1DD0-0x000000018B0A1EAC
		public int __Gen_Wrap_230(object P0, bool P1); // 0x000000018B0A1FB8-0x000000018B0A20A4
		public GameObject __Gen_Wrap_231(object P0, int P1); // 0x000000018B0A20A4-0x000000018B0A219C
		public UIScrollList.Cell __Gen_Wrap_232(object P0, int P1); // 0x000000018B0A219C-0x000000018B0A2294
		public float __Gen_Wrap_233(object P0, int P1, UIScrollList.ScrollAlignType P2); // 0x00000001871BF140-0x00000001871BF244
		public void __Gen_Wrap_234(object P0, int P1, bool P2, UIScrollList.ScrollAlignType P3); // 0x000000018B0A2294-0x000000018B0A239C
		public int __Gen_Wrap_235(object P0, NaviDirection P1); // 0x00000001871AB448-0x00000001871AB520
		public int __Gen_Wrap_236(object P0, int P1, NaviDirection P2); // 0x00000001871AFE44-0x00000001871AFF34
		public bool __Gen_Wrap_237(object P0, NaviDirection P1, out bool P2); // 0x000000018B0A239C-0x000000018B0A24B4
		public bool __Gen_Wrap_238(object P0, out int P1, out UIScrollList.Cell P2); // 0x000000018B0A24B4-0x000000018B0A2614
		public bool __Gen_Wrap_239(object P0, object P1, NaviDirection P2); // 0x000000018AC41DA8-0x000000018AC41E9C
		public bool __Gen_Wrap_240(object P0, NaviDirection P1, int P2, bool P3, out int P4); // 0x000000018B0A2720-0x000000018B0A2858
		public bool __Gen_Wrap_241(object P0, object P1, bool P2, out Selectable P3); // 0x000000018B0A2858-0x000000018B0A29A8
		public bool __Gen_Wrap_242(object P0, int P1, bool P2); // 0x000000018B0A17B4-0x000000018B0A18A8
		public bool __Gen_Wrap_243(object P0, ref int P1, bool P2); // 0x000000018B0A29A8-0x000000018B0A2AC0
		public void __Gen_Wrap_244(object P0, int P1, int P2, bool P3, bool P4, bool P5, UIScrollList.ScrollAlignType P6); // 0x000000018B0A2AC0-0x000000018B0A2BF4
		public UISelectableNaviGroup __Gen_Wrap_245(object P0); // 0x000000018B0A2BF4-0x000000018B0A2CE4
		public void __Gen_Wrap_246(object P0, int P1, bool P2, bool P3, bool P4, bool P5); // 0x000000018B0A2CE4-0x000000018B0A2E08
		public void __Gen_Wrap_247(object P0, int P1, int P2, int P3); // 0x0000000189CCA508-0x0000000189CCA600
		public void __Gen_Wrap_248(object P0, int P1, int? P2); // 0x000000018B0A2E08-0x000000018B0A2F24
		public bool __Gen_Wrap_249(object P0, int P1); // 0x00000001869AB898-0x00000001869AB970
		public int __Gen_Wrap_250(object P0, int P1, int P2, UIScrollList.ScrollAlignType P3); // 0x0000000189CD9300-0x0000000189CD9404
		public void __Gen_Wrap_251(object P0, int P1, int P2, bool P3, UIScrollList.ScrollAlignType P4, bool P5); // 0x000000018B0A302C-0x000000018B0A3140
		public Vector2Int __Gen_Wrap_252(object P0, float P1); // 0x000000018B0A3140-0x000000018B0A323C
		public bool __Gen_Wrap_253(object P0, int P1, int P2, int P3); // 0x0000000189C9DD08-0x0000000189C9DE0C
		public void __Gen_Wrap_254(object P0, object P1, int P2, int P3); // 0x0000000189CBA2C4-0x0000000189CBA3BC
		public void __Gen_Wrap_255(object P0, Vector2Int P1, bool P2, bool P3); // 0x000000018B0A323C-0x000000018B0A3358
		public void __Gen_Wrap_256(object P0, object P1, bool P2, int P3, int P4); // 0x000000018B0A3358-0x000000018B0A3464
		public void __Gen_Wrap_257(object P0, bool P1, int P2, int P3, int P4, bool P5, bool P6); // 0x000000018B0A3464-0x000000018B0A3588
		public int __Gen_Wrap_258(object P0, int P1, int P2, int P3); // 0x0000000189CD9300-0x0000000189CD9404
		public GameObject __Gen_Wrap_259(object P0, int P1, int P2); // 0x000000018B0A3588-0x000000018B0A369C
		public Vector3 __Gen_Wrap_260(); // 0x000000018B0A385C-0x000000018B0A393C
		public void __Gen_Wrap_261(Vector3 P0); // 0x000000018B0A393C-0x000000018B0A3A28
		public ref UIAtlasManager.UIAtlasHandle __Gen_Wrap_262(object P0); // 0x000000018B0A3A28-0x000000018B0A3B18
		public UIAtlasManager.UIAtlasHandle __Gen_Wrap_263(UIAtlasManager.UIAtlasProcessFailureCause P0); // 0x000000018B0A3B18-0x000000018B0A3C30
		public Texture __Gen_Wrap_264(object P0); // 0x000000018B0A3C30-0x000000018B0A3D20
		public TweenerCore<float, float, FloatOptions> __Gen_Wrap_265(object P0, float P1, float P2); // 0x000000018B0A3D20-0x000000018B0A3E38
		public UIImage __Gen_Wrap_266(object P0); // 0x000000018B0A3E38-0x000000018B0A3F14
		public bool __Gen_Wrap_267(ref UIInertiaViewPager.ScrollEffectConfig P0); // 0x000000018B0A3F14-0x000000018B0A4060
		public UIInertiaViewPager.State __Gen_Wrap_268(object P0, object P1); // 0x00000001871AD678-0x00000001871AD750
		public bool __Gen_Wrap_269(ref UIInertiaViewPager.InertiaBlocker P0, float P1); // 0x000000018B0A4060-0x000000018B0A41A4
		public bool __Gen_Wrap_270(object P0, float P1, out float P2); // 0x000000018B0A4364-0x000000018B0A4480
		public void __Gen_Wrap_271(object P0, float P1, float P2); // 0x000000018A9C157C-0x000000018A9C1664
		public void __Gen_Wrap_272(object P0, UIInertiaViewPager.State P1, UIInertiaViewPager.State P2); // 0x0000000189C830FC-0x0000000189C831E0
		public void __Gen_Wrap_273(object P0, int P1, object P2); // 0x00000001866F4C88-0x00000001866F4D80
		public float __Gen_Wrap_274(ref UIInertiaViewPager.EmptyScrollHandler P0); // 0x000000018B0A4480-0x000000018B0A45A4
		public bool __Gen_Wrap_275(ref UIInertiaViewPager.EmptyScrollHandler P0); // 0x000000018B0A45A4-0x000000018B0A46C8
		public void __Gen_Wrap_276(ref UIInertiaViewPager.EmptyScrollHandler P0, float P1); // 0x000000018B0A46C8-0x000000018B0A47F8
		public void __Gen_Wrap_277(ref UIInertiaViewPager.EmptyScrollHandler P0); // 0x000000018B0A47F8-0x000000018B0A491C
		public UIInputField __Gen_Wrap_278(); // 0x000000018B0A491C-0x000000018B0A49E8
		public void __Gen_Wrap_279(object P0, bool P1, Vector2 P2, Vector2 P3); // 0x000000018B0A49E8-0x000000018B0A4B40
		public void __Gen_Wrap_280(object P0, CanvasUpdate P1); // 0x00000001866F3838-0x00000001866F3914
		public void __Gen_Wrap_281(object P0, object P1, object P2, object P3, object P4); // 0x0000000186373F5C-0x000000018637406C
		public void __Gen_Wrap_282(object P0, object P1, bool P2, bool P3, bool P4); // 0x000000018B0A4C30-0x000000018B0A4D3C
		public List<int> __Gen_Wrap_283(object P0); // 0x000000018B0A4D3C-0x000000018B0A4E18
		public List<bool> __Gen_Wrap_284(object P0); // 0x000000018B0A4E18-0x000000018B0A4EF4
		public void __Gen_Wrap_285(object P0, int P1, object P2, bool P3); // 0x000000018B0A4EF4-0x000000018B0A4FEC
		public void __Gen_Wrap_286(object P0, float P1, float P2, float P3); // 0x00000001866C46D4-0x00000001866C47D0
		public MaterialPropertyBlock __Gen_Wrap_287(); // 0x000000018B0A4FEC-0x000000018B0A50A4
		public bool __Gen_Wrap_288(object P0, Vector3 P1); // 0x000000018B0A50A4-0x000000018B0A51CC
		public float __Gen_Wrap_289(object P0, Vector2 P1); // 0x000000018B0A51CC-0x000000018B0A52EC
		public bool __Gen_Wrap_290(object P0, float P1); // 0x000000018B0A5494-0x000000018B0A5584
		public UIScrollList.Padding __Gen_Wrap_291(object P0, bool P1); // 0x000000018B0A5584-0x000000018B0A569C
		public void __Gen_Wrap_292(object P0, out int P1, out int P2); // 0x000000018B0A569C-0x000000018B0A57C4
		public int __Gen_Wrap_293(object P0, Vector2 P1, NaviDirection P2); // 0x000000018B0A57C4-0x000000018B0A58EC
		public void __Gen_Wrap_294(object P0, Vector2 P1, out int P2, out int P3); // 0x000000018B0A58EC-0x000000018B0A5A5C
		public UIScrollRect.MoveTipsType __Gen_Wrap_295(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public void __Gen_Wrap_296(object P0, object P1, object P2, UIScrollRectEdgeRedDot.ERedDotState P3); // 0x0000000189C808B0-0x0000000189C809A8
		public UIScrollRectEdgeRedDot.ERedDotState __Gen_Wrap_297(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public Rect __Gen_Wrap_298(object P0); // 0x000000018B0A5A5C-0x000000018B0A5B54
		public bool __Gen_Wrap_299(object P0, UIScrollRectEdgeRedDot.ERedDotState P1, UIScrollRectEdgeRedDot.ERedDotDir P2, object P3); // 0x000000018B0A5B54-0x000000018B0A5C5C
		public void __Gen_Wrap_300(object P0, out UIScrollRectEdgeRedDot.ERedDotState P1, out UIScrollRectEdgeRedDot.ERedDotState P2); // 0x000000018B0A569C-0x000000018B0A57C4
		public void __Gen_Wrap_301(object P0, bool P1, float P2); // 0x00000001866C2E48-0x00000001866C2F2C
		public Vector3 __Gen_Wrap_302(object P0, int P1); // 0x000000018B0A5E4C-0x000000018B0A5F68
		public Vector3[] __Gen_Wrap_303(object P0); // 0x000000018B0A5F68-0x000000018B0A6058
		public Vector4 __Gen_Wrap_304(object P0); // 0x000000018B0A6058-0x000000018B0A6164
		public Vector4 __Gen_Wrap_305(Vector4 P0, Rect P1, Rect P2); // 0x000000018B0A6164-0x000000018B0A6300
		public UISoftMask.SlicedSpriteParams __Gen_Wrap_306(object P0); // 0x000000018B0A6300-0x000000018B0A6418
		public Graphic __Gen_Wrap_307(object P0); // 0x000000018B0A6418-0x000000018B0A6508
		public UISoftMask __Gen_Wrap_308(object P0); // 0x000000018B0A6508-0x000000018B0A65F8
		public bool __Gen_Wrap_309(object P0, float P1, float P2); // 0x000000018B0A65F8-0x000000018B0A6700
		public Vector2 __Gen_Wrap_310(object P0, Vector2 P1, Vector2 P2, Vector2 P3, Vector2 P4); // 0x000000018B0A6864-0x000000018B0A6A18
		public void __Gen_Wrap_311(object P0, Vector2 P1, Vector2 P2, Vector2 P3, Vector2 P4, out float P5, out float P6); // 0x000000018B0A6A18-0x000000018B0A6C1C
		public void __Gen_Wrap_312(ref UIVertex P0, Vector2 P1, Vector2 P2, Vector2 P3); // 0x000000018B0A6C1C-0x000000018B0A6E6C
		public void __Gen_Wrap_313(object P0, object P1, object P2, out bool P3); // 0x000000018B0A6E6C-0x000000018B0A6F98
		public UISoftMaskable __Gen_Wrap_314(object P0); // 0x000000018B0A6F98-0x000000018B0A7088
		public IEnumerator __Gen_Wrap_315(object P0, bool P1, int P2); // 0x000000018B0A7088-0x000000018B0A719C
		public void __Gen_Wrap_316(object P0, bool P1, int P2); // 0x0000000189CBA994-0x0000000189CBAA78
		public void __Gen_Wrap_317(object P0, object P1, bool P2, object P3, object P4, object P5, bool P6); // 0x000000018B0A719C-0x000000018B0A72D4
		public uint __Gen_Wrap_318(object P0); // 0x0000000186366E40-0x0000000186366EFC
		public void __Gen_Wrap_319(uint P0, bool P1); // 0x000000018B0A72D4-0x000000018B0A73B0
		public TMP_FontAsset __Gen_Wrap_320(object P0, object P1); // 0x000000018B0A74A0-0x000000018B0A75AC
		public bool __Gen_Wrap_321(object P0, object P1, uint P2, out TMP_FontAsset P3); // 0x000000018B0A75AC-0x000000018B0A770C
		public bool __Gen_Wrap_322(ref float P0, float P1); // 0x000000018B0A770C-0x000000018B0A7820
		public void __Gen_Wrap_323(ref TweenUtils.FLerpByTime P0, object P1); // 0x000000018B0A7820-0x000000018B0A7984
		public float __Gen_Wrap_324(ref TweenUtils.FLerpByTime P0, out bool P1); // 0x000000018B0A7984-0x000000018B0A7B1C
		public PlayableGraph __Gen_Wrap_325(object P0); // 0x000000018B0A7B1C-0x000000018B0A7C28
		public AnimationLayerMixerPlayable __Gen_Wrap_326(object P0, PlayableGraph P1, out GenericShareSingleMixerAssetPlayer<AnimationClip> P2); // 0x000000018B0A7C28-0x000000018B0A7DBC
		public AnimationPlayableOutput __Gen_Wrap_327(object P0, PlayableGraph P1); // 0x000000018B0A7DBC-0x000000018B0A7F08
		public AnimationClipPlayable __Gen_Wrap_328(object P0, object P1, PlayableGraph P2, out GenericShareSingleMixerAssetPlayer<AnimationClip> P3); // 0x000000018B0A7F08-0x000000018B0A80B8
		public AnimationMixerPlayable __Gen_Wrap_329(object P0, PlayableGraph P1, out GenericShareSingleMixerAssetPlayer<AnimationClip> P2); // 0x000000018B0A80B8-0x000000018B0A824C
		public void __Gen_Wrap_330(bool P0, FAssetProxyHandle P1); // 0x000000018B0A837C-0x000000018B0A8480
		public void __Gen_Wrap_331(ref UISwitchTween.TweenContext P0); // 0x000000018B0A8480-0x000000018B0A85A8
		public void __Gen_Wrap_332(ref UISwitchTween.TweenContext P0, object P1); // 0x000000018B0A85A8-0x000000018B0A86EC
		public void __Gen_Wrap_333(object P0, UISwitchTween.Options P1); // 0x000000018B0A86EC-0x000000018B0A87EC
		public UISwitchTween.TweenContext __Gen_Wrap_334(object P0); // 0x000000018B0A87EC-0x000000018B0A88C8
		public bool __Gen_Wrap_335(ref UISwitchTween.TweenContext P0); // 0x000000018B0A88C8-0x000000018B0A89F0
		public float __Gen_Wrap_336(ref FadeSwitchTween.Durations P0, float P1); // 0x000000018B0A89F0-0x000000018B0A8B50
		public FadeSwitchTween __Gen_Wrap_337(ref FadeSwitchTween.Builder P0); // 0x000000018B0A8B50-0x000000018B0A8CB8
		public Vector2 __Gen_Wrap_338(object P0, bool P1); // 0x000000018B0A8CB8-0x000000018B0A8DB0
		public void __Gen_Wrap_339(object P0, in RectInt P1); // 0x000000018B0A8DB0-0x000000018B0A8EC0
		public bool __Gen_Wrap_340(object P0, object P1, out UIAtlasManager.UIAtlasProcessFailureCause P2); // 0x0000000189E3E3C4-0x0000000189E3E4DC
		public RectInt __Gen_Wrap_341(object P0, int P1, int P2); // 0x000000018B0A8FB0-0x000000018B0A90D4
		public void __Gen_Wrap_342(object P0, object P1, object P2, in RectInt P3); // 0x000000018B0A90D4-0x000000018B0A9214
		public bool __Gen_Wrap_343(ref UIAtlasManager.UIAtlasHandle P0); // 0x000000018B0A9214-0x000000018B0A9360
		public void __Gen_Wrap_344(object P0, in List<RectInt> P1); // 0x000000018B0A9360-0x000000018B0A943C
		public void __Gen_Wrap_345(int P0, string P1); // 0x0000000186365664-0x000000018636572C
		public void __Gen_Wrap_346(string P0); // 0x00000001866C296C-0x00000001866C2A18
		public bool __Gen_Wrap_347(StateAnimationInfo P0); // 0x00000001866C53B4-0x00000001866C5470
		public byte __Gen_Wrap_348(UnityEngine.WrapMode P0); // 0x0000000186363EE4-0x0000000186363F9C
		public byte __Gen_Wrap_349(int P0, bool P1); // 0x000000018B0A943C-0x000000018B0A9514
		public GPUIExtendedPrefabData __Gen_Wrap_350(Vector4 P0, Vector4 P1, Vector2 P2); // 0x000000018B0A9620-0x000000018B0A97E0
		public GPUIExtendedPrefabDataLite __Gen_Wrap_351(Vector4 P0, Vector4 P1, Vector2 P2); // 0x000000018B0A97E0-0x000000018B0A9978
		public GPUIRootTransformState __Gen_Wrap_352(); // 0x000000018B0A9978-0x000000018B0A9A74
		public GPUISubrootDomainState __Gen_Wrap_353(); // 0x000000018B0A9A74-0x000000018B0A9B68
		public GPUIExtendedAnimationState __Gen_Wrap_354(); // 0x000000018B0A9B68-0x000000018B0A9C58
		public GPUIResolvedSubrootState __Gen_Wrap_355(in GPUIRootTransformState P0, in GPUISubrootDomainState P1); // 0x000000018B0A9C58-0x000000018B0A9E1C
		public uint __Gen_Wrap_356(ushort P0, ushort P1); // 0x000000018B0A9E1C-0x000000018B0A9F08
		public uint __Gen_Wrap_357(ushort P0, byte P1, byte P2); // 0x000000018B0A9F08-0x000000018B0A9FFC
		public uint __Gen_Wrap_358(float P0); // 0x000000018B0A9FFC-0x000000018B0AA0CC
		public int __Gen_Wrap_359(byte P0); // 0x000000018AC4228C-0x000000018AC42348
		public int __Gen_Wrap_360(float P0); // 0x000000018B0A9FFC-0x000000018B0AA0CC
		public short __Gen_Wrap_361(float P0); // 0x000000018B0A9FFC-0x000000018B0AA0CC
		public void __Gen_Wrap_362(Quaternion P0, out int P1, out int P2); // 0x000000018B0AA0CC-0x000000018B0AA23C
		public GPUPrefabData __Gen_Wrap_363(Vector4 P0, Vector4 P1, Vector2 P2); // 0x000000018B0AA23C-0x000000018B0AA3F4
		public GPUPrefabDataLite __Gen_Wrap_364(Vector4 P0, Vector4 P1, Vector2 P2); // 0x000000018B0AA3F4-0x000000018B0AA58C
		public uint __Gen_Wrap_365(uint P0, uint P1); // 0x0000000186A18890-0x0000000186A18978
		public Texture2D __Gen_Wrap_366(object P0); // 0x000000018B0AA58C-0x000000018B0AA67C
		public RectInt __Gen_Wrap_367(object P0); // 0x000000018B0AA67C-0x000000018B0AA774
		public bool __Gen_Wrap_368(object P0, object P1, RectInt P2); // 0x000000018B0AA774-0x000000018B0AA8A0
		public bool __Gen_Wrap_369(object P0, UICustomAtlasCopyStatus P1); // 0x000000018B0AA8A0-0x000000018B0AA978
		public void __Gen_Wrap_370(object P0, GPUIExtendedDynamicAtlas.DynamicAtlasFailureCause P1); // 0x0000000186A5FB54-0x0000000186A5FC1C
		public void __Gen_Wrap_371(object P0, object P1, RectInt P2); // 0x000000018B0AAA44-0x000000018B0AAB60
		public GPUIExtendedDynamicAtlas.DynamicSpriteHandle __Gen_Wrap_372(); // 0x000000018B0AAB60-0x000000018B0AAC38
		public bool __Gen_Wrap_373(object P0, object P1, out GPUIExtendedDynamicAtlas.DynamicAtlasFailureCause P2); // 0x0000000189E3E3C4-0x0000000189E3E4DC
		public bool __Gen_Wrap_374(object P0, object P1, out GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2, out Vector4 P3); // 0x000000018B0AAC38-0x000000018B0AADD0
		public bool __Gen_Wrap_375(ref GPUIExtendedDynamicAtlas.DynamicSpriteHandle P0); // 0x000000018B0AADD0-0x000000018B0AAF1C
		public bool __Gen_Wrap_376(object P0, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P1, out bool P2); // 0x000000018B0AAF1C-0x000000018B0AB078
		public bool __Gen_Wrap_377(object P0, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P1); // 0x000000018B0AB078-0x000000018B0AB188
		public UICustomAtlasCopyStatus __Gen_Wrap_378(object P0); // 0x0000000186360E84-0x0000000186360F54
		public void __Gen_Wrap_379(object P0, object P1, Vector4 P2); // 0x000000018B0AB188-0x000000018B0AB2A4
		public void __Gen_Wrap_380(ref GPUIExtendedPrefabDataLite P0, Vector4 P1, Vector2 P2); // 0x000000018B0AB2A4-0x000000018B0AB474
		public bool __Gen_Wrap_381(object P0, int P1, object P2, out GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P3, out ushort P4); // 0x000000018B0AB474-0x000000018B0AB620
		public void __Gen_Wrap_382(object P0, GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P1); // 0x000000018B0AB620-0x000000018B0AB73C
		public bool __Gen_Wrap_383(ref GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P0, GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P1); // 0x000000018B0AB73C-0x000000018B0AB8D8
		public bool __Gen_Wrap_384(ref GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P0, object P1); // 0x000000018B0AB8D8-0x000000018B0ABA40
		public int __Gen_Wrap_385(ref GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P0); // 0x000000018B0ABA40-0x000000018B0ABB9C
		public bool __Gen_Wrap_386(object P0, object P1, out GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2); // 0x000000018B0ABB9C-0x000000018B0ABCE8
		public bool __Gen_Wrap_387(object P0, int P1, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2, out GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P3, out ushort P4); // 0x000000018B0ABCE8-0x000000018B0ABEB8
		public bool __Gen_Wrap_388(object P0, GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P1, int P2, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P3); // 0x000000018B0ABEB8-0x000000018B0AC030
		public void __Gen_Wrap_389(object P0, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P1); // 0x000000018B0AC030-0x000000018B0AC144
		public GPUIExtendedRuntimePrefabData __Gen_Wrap_390(object P0); // 0x000000018B0AC230-0x000000018B0AC320
		public GPUIExtendedRuntimeAnimationData __Gen_Wrap_391(object P0, int P1); // 0x000000018B0AC320-0x000000018B0AC42C
		public bool __Gen_Wrap_392(in GPUIExtendedRuntimeInstance.SpriteOverrideState P0); // 0x000000018B0AC42C-0x000000018B0AC560
		public void __Gen_Wrap_393(object P0, in GPUIExtendedRuntimeInstance.SpriteOverrideState P1); // 0x000000018B0AC560-0x000000018B0AC69C
		public void __Gen_Wrap_394(object P0, ref NativeArray<GPUIExtendedInstanceData> P1, int P2, ref int P3, GPUIExtendedInstanceData P4); // 0x000000018B0AC69C-0x000000018B0AC878
		public void __Gen_Wrap_395(object P0, ref NativeArray<GPUIExtendedInstanceData> P1, int P2, ref int P3); // 0x000000018B0AC878-0x000000018B0ACA18
		public GPUIExtendedAnimationState __Gen_Wrap_396(object P0, in GPUIExtendedRuntimeNodeInfo P1); // 0x000000018B0ACA18-0x000000018B0ACBA8
		public uint __Gen_Wrap_397(uint P0); // 0x00000001871B0CA0-0x00000001871B0D6C
		public void __Gen_Wrap_398(object P0, int P1, ref GPUIExtendedInstanceData P2); // 0x000000018B0ACBA8-0x000000018B0ACD1C
		public byte __Gen_Wrap_399(float P0); // 0x000000018B0A9FFC-0x000000018B0AA0CC
		public void __Gen_Wrap_400(object P0, ref NativeArray<GPUIExtendedInstanceData> P1, int P2, bool P3); // 0x000000018B0ACE0C-0x000000018B0ACF84
		public void __Gen_Wrap_401(object P0, Quaternion P1); // 0x000000018B0ACF84-0x000000018B0AD098
		public void __Gen_Wrap_402(object P0, float P1, int P2); // 0x000000018636104C-0x0000000186361144
		public bool __Gen_Wrap_403(object P0, int P1, float P2, int P3); // 0x000000018B0AD098-0x000000018B0AD1A0
		public uint __Gen_Wrap_404(UnityEngine.Color P0); // 0x000000018B0AD1A0-0x000000018B0AD2A8
		public void __Gen_Wrap_405(object P0, int P1, UnityEngine.Color P2); // 0x000000018B0AD2A8-0x000000018B0AD3D4
		public void __Gen_Wrap_406(object P0, int P1, Vector2 P2, Vector2 P3, float P4); // 0x000000018B0AD3D4-0x000000018B0AD528
		public bool __Gen_Wrap_407(object P0, int P1, out int P2); // 0x000000018B0AD528-0x000000018B0AD640
		public bool __Gen_Wrap_408(object P0, int P1, ref GPUIExtendedRuntimeInstance.SpriteOverrideState P2); // 0x000000018B0AD640-0x000000018B0AD7E4
		public bool __Gen_Wrap_409(object P0, int P1, ref GPUIExtendedRuntimeInstance.SpriteOverrideState P2, ref GPUIExtendedRuntimeInstance.SpriteOverrideState P3); // 0x000000018B0AD7E4-0x000000018B0ADA20
		public bool __Gen_Wrap_410(object P0, int P1, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2); // 0x000000018B0ADA20-0x000000018B0ADB48
		public GPUIHandle __Gen_Wrap_411(object P0); // 0x000000018B0ADB48-0x000000018B0ADC38
		public bool __Gen_Wrap_412(object P0, object P1, Vector3 P2, out GPUIHandle P3, int P4); // 0x000000018B0ADC38-0x000000018B0ADDD0
		public bool __Gen_Wrap_413(object P0, GPUIHandle P1); // 0x000000018B0ADDD0-0x000000018B0ADEEC
		public bool __Gen_Wrap_414(object P0, GPUIHandle P1, Vector3 P2); // 0x000000018B0ADEEC-0x000000018B0AE044
		public bool __Gen_Wrap_415(object P0, GPUIHandle P1, Vector2 P2); // 0x000000018B0AE044-0x000000018B0AE1A0
		public bool __Gen_Wrap_416(object P0, GPUIHandle P1, Quaternion P2); // 0x000000018B0AE1A0-0x000000018B0AE2F0
		public bool __Gen_Wrap_417(object P0, GPUIHandle P1, object P2, out GPUIExtendedRuntimeInstance P3, out int P4); // 0x000000018B0AE2F0-0x000000018B0AE498
		public bool __Gen_Wrap_418(object P0, GPUIHandle P1, object P2, bool P3); // 0x000000018B0AE498-0x000000018B0AE5D4
		public bool __Gen_Wrap_419(object P0, GPUIHandle P1, object P2, Vector2 P3, Vector2 P4, float P5); // 0x000000018B0AE5D4-0x000000018B0AE75C
		public bool __Gen_Wrap_420(object P0, GPUIHandle P1, object P2, UnityEngine.Color P3); // 0x000000018B0AE75C-0x000000018B0AE8C0
		public bool __Gen_Wrap_421(object P0, GPUIHandle P1, object P2, float P3); // 0x000000018B0AE8C0-0x000000018B0AE9FC
		public bool __Gen_Wrap_422(object P0, GPUIHandle P1, object P2, object P3); // 0x000000018B0AE9FC-0x000000018B0AEB38
		public bool __Gen_Wrap_423(object P0, GPUIHandle P1, bool P2, int P3); // 0x000000018B0AEB38-0x000000018B0AEC74
		public bool __Gen_Wrap_424(object P0, GPUIHandle P1, bool P2, object P3); // 0x000000018B0AEC74-0x000000018B0AEDB0
		public bool __Gen_Wrap_425(object P0, GPUIHandle P1, object P2, out float P3); // 0x000000018B0AEDB0-0x000000018B0AEF14
		public bool __Gen_Wrap_426(object P0, GPUIHandle P1, object P2, object P3, out float P4); // 0x000000018B0AEF14-0x000000018B0AF078
		public bool __Gen_Wrap_427(object P0, object P1, out int P2, out int P3); // 0x000000018B0AF078-0x000000018B0AF1C4
		public void __Gen_Wrap_428(object P0, bool P1, int P2, int P3); // 0x000000018B0AF1C4-0x000000018B0AF2BC
		public int __Gen_Wrap_429(object P0, object P1, int P2); // 0x000000018B0AF2BC-0x000000018B0AF3B0
		public GPUIExtendedRuntimePrefabData __Gen_Wrap_430(object P0, object P1); // 0x000000018B0AF4F0-0x000000018B0AF5E8
		public bool __Gen_Wrap_431(ref GPUIHandle P0, GPUIHandle P1); // 0x000000018B0AF5E8-0x000000018B0AF750
		public bool __Gen_Wrap_432(ref GPUIHandle P0, object P1); // 0x000000018B0AF750-0x000000018B0AF894
		public int __Gen_Wrap_433(ref GPUIHandle P0); // 0x000000018B0AF894-0x000000018B0AF9CC
		public bool __Gen_Wrap_434(GPUIHandle P0, GPUIHandle P1); // 0x000000018B0AF9CC-0x000000018B0AFAFC
		public GPUIExtendedSystem __Gen_Wrap_435(object P0); // 0x000000018B0AFAFC-0x000000018B0AFBEC
		public GPUIProxySyncManager __Gen_Wrap_436(object P0); // 0x000000018B0AFBEC-0x000000018B0AFCC8
		public bool __Gen_Wrap_437(object P0, out RectTransform P1, out Camera P2); // 0x000000018B0AFCC8-0x000000018B0AFE50
		public bool __Gen_Wrap_438(object P0, object P1, object P2, object P3); // 0x000000018B0AFE50-0x000000018B0AFF68
		public bool __Gen_Wrap_439(object P0, object P1, object P2, out Vector2 P3); // 0x000000018B0AFF68-0x000000018B0B00CC
		public bool __Gen_Wrap_440(object P0, object P1, object P2, bool P3); // 0x000000018B0B024C-0x000000018B0B0360
		public bool __Gen_Wrap_441(object P0, out GPUIExtendedSystem P1); // 0x000000018B0B0360-0x000000018B0B0498
		public bool __Gen_Wrap_442(object P0, object P1, out GPUIHandle P2, int P3); // 0x000000018B0B0498-0x000000018B0B05F0
		public void __Gen_Wrap_443(object P0, int P1, Vector3 P2); // 0x000000018B0B05F0-0x000000018B0B0724
		public void __Gen_Wrap_444(object P0, GPUIHandle P1); // 0x000000018B0B0724-0x000000018B0B0834
		public RuntimePrefabData __Gen_Wrap_445(object P0); // 0x000000018B0B0834-0x000000018B0B0924
		public bool __Gen_Wrap_446(object P0, GPUIHandle P1, bool P2, object P3, bool P4); // 0x000000018B0B0924-0x000000018B0B0A70
		public bool __Gen_Wrap_447(object P0, GPUIHandle P1, bool P2, int P3, bool P4); // 0x000000018B0B0A70-0x000000018B0B0BA8
		public RuntimePrefabData __Gen_Wrap_448(object P0, object P1); // 0x000000018B0B0BA8-0x000000018B0B0CA0
		public Mesh __Gen_Wrap_449(); // 0x000000018B0B0CA0-0x000000018B0B0D58
		public void __Gen_Wrap_450(object P0, ref NativeArray<GPUInstanceData> P1, int P2, bool P3); // 0x000000018B0B0D58-0x000000018B0B0ED0
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 50612
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x000000018B0B58E0-0x000000018B0B598C 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x000000018B0B598C-0x000000018B0B5A38 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018B0B5A38-0x000000018B0B5B14
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x0000000186365FC0-0x000000018636603C
		[IDTag(1)]
		private bool MoveNext(); // 0x0000000186365D60-0x0000000186365DEC
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x0000000186365E98-0x0000000186365F14
		public void RefAsyncBuilderStartMethod(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 50613
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018B0B5E1C-0x000000018B0B5E80
		public static bool IsPatched(int id); // 0x0000000182FA9650-0x0000000182FA96E0
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018B0B5CD8-0x000000018B0B5DA4
		public object CreateWrapper(int id); // 0x000000018B0B5DA4-0x000000018B0B5E1C
		public object InitWrapperArray(int len); // 0x000000018B0B5E80-0x000000018B0B613C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018B0B5C34-0x000000018B0B5CD8
	}

	public enum IDMAP0 // TypeDefIndex: 50614
	{
		Beyond-PoolCore-ListPoolInitializer_UI_Beyond-InitializeAtRuntime0 = 0,
		Beyond-PoolCore-ListPoolInitializer_UI_Beyond-Initialize0 = 1,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputHorizontal0 = 2,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputVertical0 = 3,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minWidth0 = 4,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-_GetPreferredSize0 = 5,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredWidth0 = 6,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_flexibleWidth0 = 7,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minHeight0 = 8,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredHeight0 = 9,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_flexibleHeight0 = 10,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_layoutPriority0 = 11,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-get_tickOption0 = 12,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-get_panel0 = 13,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-_InitState0 = 14,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdatePos0 = 15,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdateLookAtCamera0 = 16,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-SetLookAtCamera0 = 18,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-OnEnable0 = 20,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-Start0 = 21,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-Tick0 = 23,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-ForceUpdate0 = 24,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-LateTick0 = 25,
		Beyond-Gameplay-UI-UIScrollCellSlantEffect-get_tickOption0 = 26,
		Beyond-Gameplay-UI-UIScrollCellSlantEffect-Tick0 = 27,
		Beyond-UI-UIText-SetAndResolveTextStyle0 = 28,
		Beyond-UI-UIText-_GetHyperlinkText0 = 29,
		Beyond-UI-UIText-_ResolveTextStyle0 = 30,
		Beyond-UI-UIText-HyperlinkUITextManager-get_instance0 = 31,
		Beyond-UI-UIText-HyperlinkUITextManager-UpdateWrapDisplayable0 = 32,
		Beyond-UI-UIText-HyperlinkUITextManager-_IsUITextDisplayable0 = 33,
		Beyond-UI-UIText-HyperlinkUITextManager-_GetGroup0 = 34,
		Beyond-UI-UIText-HyperlinkUITextGroup-ChangeDisplayable0 = 35,
		Beyond-UI-UIText-HyperlinkUITextGroup-_AddDisplayableCount0 = 36,
		Beyond-UI-UIText-HyperlinkUITextGroup-_NotifyDisplayableChanged0 = 37,
		Beyond-UI-UIText-HyperlinkUITextGroup-_SubDisplayableCount0 = 38,
		Beyond-UI-UIText-GetPhoneticText0 = 39,
		Beyond-UI-UIText-SetPhoneticText0 = 40,
		Beyond-UI-UIText-get_textId0 = 41,
		Beyond-UI-UIText-OnEnvLangChanged0 = 42,
		Beyond-UI-UIText-get_text0 = 43,
		Beyond-UI-UIText-set_text0 = 44,
		Beyond-UI-UIText-_CreateUpdateFunction0 = 45,
		Beyond-UI-UIText-_ReleaseUpdateFunction0 = 46,
		Beyond-UI-UIText-_UpdateTick0 = 47,
		Beyond-UI-UIText-TryGetLinkId0 = 48,
		Beyond-UI-UIText-get_panel0 = 49,
		Beyond-UI-UIText-TryGetOriginalLinkId0 = 50,
		Beyond-UI-UIText-ClearMesh0 = 51,
		Beyond-UI-UIText-_DelayedChangeActiveImageGo0 = 52,
		Beyond-UI-UIText-RefreshPopulateText0 = 59,
		Beyond-UI-UIText-RichTextAnalyzer-PreAnalyzeRichText0 = 60,
		Beyond-UI-UIText-get_processRichTextEntryFunc0 = 61,
		Beyond-UI-UIText-_ProcessRichTextEntry0 = 62,
		Beyond-UI-UIText-GetOrLoadSprite0 = 63,
		Beyond-UI-UIText-RichTextAnalyzer-GetCharacterCountWithoutRichText0 = 64,
		Beyond-UI-UIText-RichTextAnalyzer-ProcessRichTextEntryFallback0 = 65,
		Beyond-UI-UIText-RichTextAnalyzer-AnalyzeRichText0 = 66,
		Beyond-UI-UIText-RichTextAnalyzer-_TryParseRichTextEntry0 = 67,
		Beyond-UI-UIText-RichTextAnalyzer-_TryParseParam0 = 68,
		Beyond-UI-UIText-RichTextAnalyzer-_GetHashCode0 = 69,
		Beyond-UI-UIText-_ProcessRichTextInfo0 = 70,
		Beyond-UI-UIText-_ClearInlineImage0 = 71,
		Beyond-UI-UIText-_ReturnImageGO0 = 72,
		Beyond-UI-UIText-_GetImageGoByIndex0 = 73,
		Beyond-UI-UIText-_GetOrCreateImageGO0 = 74,
		Beyond-UI-UIText-LoadMaterial0 = 75,
		Beyond-UI-I18nFontLoader-GetMaterial0 = 76,
		Beyond-UI-UIText-OnDestroy0 = 77,
		Beyond-UI-UIText-ClearComponent0 = 78,
		Beyond-UI-UIText-HyperlinkUITextManager-RemoveWrap0 = 79,
		Beyond-UI-UIText-HyperlinkUITextGroup-Remove0 = 80,
		Beyond-UI-UIText-_OnPreRenderText0 = 81,
		Beyond-UI-UIText-DisposeInlineImageCache0 = 82,
		Beyond-UI-UIText-Awake0 = 83,
		Beyond-UI-UIText-_GenerateRuntimeText0 = 84,
		Beyond-UI-UIText-_RefreshMatTexture0 = 85,
		Beyond-UI-I18nFontLoader-IsFontDefaultMaterial0 = 86,
		Beyond-UI-I18nFontLoader-get_fontSearchData0 = 87,
		Beyond-UI-I18nFontLoader-IsInvalid0 = 88,
		Beyond-UI-UIText-GetFontAsset0 = 89,
		Beyond-UI-I18nFontLoader-GetI18nFont0 = 90,
		Beyond-UI-I18nFontLoader-_GetFontById0 = 91,
		Beyond-UI-UIText-OnPointerClick0 = 92,
		Beyond-UI-UIText-OnPointerEnter0 = 93,
		Beyond-UI-UIText-OnPointerExit0 = 94,
		Beyond-UI-UIText-Start0 = 95,
		Beyond-UI-UIText-SetHyperlinkUITextGroup0 = 96,
		Beyond-UI-UIText-HyperlinkUITextManager-AddWrap0 = 97,
		Beyond-UI-UIText-HyperlinkUITextWrap-Clear0 = 98,
		Beyond-UI-UIText-HyperlinkUITextGroup-Add0 = 99,
		Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapGroup0 = 100,
		Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapOrder0 = 101,
		Beyond-UI-UIText-OnEnable0 = 102,
		Beyond-UI-UIText-OnDisable0 = 103,
		Beyond-UI-UIText-ShrinkLinkTags0 = 104,
		Beyond-UI-UIText-TryGetLinkId1 = 105,
		Beyond-UI-UIText-TryGetCharacterStartPosAndHeight0 = 106,
		Beyond-UI-UIText-TryGetCharacterEndPosAndHeight0 = 107,
		Beyond-UI-UIText-CombineStringWithLanguageSpilt0 = 108,
		Beyond-UI-UIText-CombineStringReverseForIndonesianAndVietnamese0 = 109,
		Beyond-UI-UIText-IsHyperlinkUITextGroupDisplayable0 = 110,
		Beyond-UI-UIText-HyperlinkUITextManager-IsGroupDisplayable0 = 111,
		Beyond-UI-UIText-GetGroupDisplayableHyperlinkUIText0 = 112,
		Beyond-UI-UIText-HyperlinkUITextManager-GetGroupDisplayableUIText0 = 113,
		Beyond-UI-UIText-UpdateI18NFontAsset0 = 119,
		Beyond-UI-UIText-get_m_fontAsset0 = 120,
		Beyond-UI-UIText-set_m_fontAsset0 = 121,
		Beyond-UI-I18nFontLoader-GetCNFontId0 = 122,
		Beyond-UI-UIText-get_fontSharedMaterial0 = 123,
		Beyond-UI-UIText-set_fontSharedMaterial0 = 124,
		Beyond-UI-UIText-SetSharedMaterial0 = 125,
		Beyond-UI-UIText-UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize0 = 126,
		Beyond-UI-UIText-OnAfterDeserialize0 = 127,
		Beyond-UI-UIText-AddSubTextObject0 = 128,
		Beyond-UI-UIText-LocalStringCombineFormat0 = 129,
		Beyond-UI-UIText-CalculatePreferredValues0 = 130,
		Beyond-UI-UIConst-get_STANDARD_HORIZONTAL_RESOLUTION_INT0 = 131,
		Beyond-UI-UIConst-get_STANDARD_VERTICAL_RESOLUTION_INT0 = 132,
		Beyond-UI-UIConst-get_CUR_STANDARD_HORIZONTAL_RESOLUTION0 = 133,
		Beyond-UI-UIConst-GetResolutionScale0 = 134,
		Beyond-UI-UIConst-IsPadDevice0 = 135,
		Beyond-UI-UIConst-get_CUR_STANDARD_VERTICAL_RESOLUTION0 = 136,
		Beyond-UI-UIConst-get_dragThreshold0 = 137,
		Beyond-UI-UIModelLoader-LoadModel0 = 138,
		Beyond-UI-UIModelLoader-LoadModelAsync0 = 139,
		Beyond-UI-UIModelLoader-Cancel0 = 142,
		Beyond-UI-UIModelLoader-UnloadModel0 = 143,
		Beyond-UI-UIModelLoader-_Clear0 = 144,
		Beyond-UI-UIModelLoader-Dispose0 = 145,
		Beyond-UI-UIUtils-GetSharedIntString0 = 146,
		Beyond-UI-UIUtils-GetSharedIntStringRoman0 = 147,
		Beyond-UI-UIUtils-IsScreenPosInRectTransform0 = 148,
		Beyond-UI-UIUtils-IsScreenPosInRectTransform1 = 149,
		Beyond-UI-UIUtils-CalcBoundOfRectTransform0 = 150,
		Beyond-UI-UIUtils-TryGetTouch0 = 151,
		Beyond-UI-UIUtils-SetAlpha0 = 152,
		Beyond-UI-UIUtils-SetColorWithoutAlpha0 = 153,
		Beyond-UI-UIUtils-ClearUIComponents0 = 154,
		Beyond-UI-UIUtils-RectTransformToScreenRect0 = 155,
		Beyond-UI-UIUtils-ClampPointInRectTransform0 = 156,
		Beyond-UI-UIUtils-GetNodeScaleOffset0 = 157,
		Beyond-UI-UIUtils-GetColorByString0 = 158,
		Beyond-UI-UIUtils-SetMaskRatio0 = 159,
		Beyond-UI-UIUtils-GetCursorTipOffsetX0 = 160,
		Beyond-UI-UIUtils-GetCursorTipOffsetInScreen0 = 161,
		Beyond-UI-UIUtils-TryGetTextWithoutRichStyle0 = 162,
		Beyond-UI-ActiveSyncHelper-Awake0 = 163,
		Beyond-UI-ActiveSyncHelper-Sync0 = 164,
		Beyond-UI-ActiveSyncHelper-OnEnable0 = 165,
		Beyond-UI-ActiveSyncHelper-OnDisable0 = 166,
		Beyond-UI-Billboard-get_tickOption0 = 167,
		Beyond-UI-Billboard-OnEnable0 = 168,
		Beyond-UI-Billboard-Tick0 = 169,
		Beyond-UI-CinemachineGyroscopeEffect-PostPipelineStageCallback0 = 170,
		Beyond-UI-CommonItemToastList-ScrollToIndex0 = 171,
		Beyond-UI-UIScrollList-GetRealIndex0 = 172,
		Beyond-UI-CommonItemToastList-AdjustContainerPos0 = 174,
		Beyond-UI-CommonItemToastList-_GetUnConstraintTargetPos0 = 175,
		Beyond-UI-UIScrollList-get_isHorizontal0 = 176,
		Beyond-UI-UIScrollList-OnScroll0 = 179,
		Beyond-UI-UIScrollList-get_isMultiPage0 = 180,
		Beyond-UI-UIScrollList-UpdateShowingCells0 = 181,
		Beyond-UI-UIScrollList-ClearShowingCells0 = 182,
		Beyond-UI-UIScrollList-CacheCell0 = 183,
		Beyond-UI-UIScrollList-GetShowRange0 = 184,
		Beyond-UI-UIScrollList-get_isVertical0 = 185,
		Beyond-UI-UIScrollList-GetIndexRangeFromScrollOffset0 = 186,
		Beyond-UI-UIScrollList-GetNotCacheRange0 = 187,
		Beyond-UI-UIScrollList-CacheOutOfRangeCells0 = 188,
		Beyond-UI-UIScrollList-ProcessCellAtIndex0 = 189,
		Beyond-UI-UIScrollList-UpdateCell0 = 190,
		Beyond-UI-UIScrollList-MoveCellTo0 = 191,
		Beyond-UI-UIScrollList-OnUpdateCell0 = 192,
		Beyond-UI-UIScrollList-GetCell0 = 193,
		Beyond-UI-UIAnimationWrapper-ClearTween0 = 194,
		Beyond-UI-UIAnimationWrapper-get_panel0 = 195,
		Beyond-UI-LuaPanel-InformAnimationInEnd0 = 196,
		Beyond-UI-LuaPanel-_TryCallAnimationInFinished0 = 197,
		Beyond-UI-LuaPanel-RecoverAllInput0 = 199,
		Beyond-UI-UIAnimationTween-get_handler0 = 200,
		Beyond-UI-UIAnimationWrapper-PlayInAnimation0 = 201,
		Beyond-UI-UIAnimationWrapper-_OnInAnimationFinished0 = 204,
		Beyond-UI-UIAnimationWrapper-_OnInEasingAnimationFinished0 = 207,
		Beyond-UI-UIAnimationWrapper-_NotifyAnimationInEasingFinished0 = 208,
		Beyond-UI-UIAnimationWrapper-PlayLoopAnimation0 = 209,
		Beyond-UI-UIAnimationWrapper-get_curTween0 = 210,
		Beyond-UI-UIAnimationTween-get_tweenValue0 = 211,
		Beyond-UI-UIAnimationLoopSynchronizer-GetLoopStartPosition0 = 213,
		Beyond-UI-UIAnimationWrapper-PlayWithTween0 = 214,
		Beyond-UI-UIAnimationWrapper-GetClip0 = 217,
		Beyond-UI-UIAnimationWrapper-_InitAnimation0 = 218,
		Beyond-UI-UIAnimationWrapper-SampleClip0 = 219,
		Beyond-UI-UIAnimationWrapper-_SampleClipAtLength0 = 220,
		Beyond-UI-LuaPanel-InformAnimationInStart0 = 221,
		Beyond-UI-UIAnimationWrapper-get_animationIn0 = 222,
		Beyond-UI-UIAnimationWrapper-PlayWithTween1 = 223,
		Beyond-UI-UIAnimationWrapper-PlayOpenAudio0 = 224,
		Beyond-UI-UIScrollList-RepositionOutOfRangeCells0 = 225,
		Beyond-UI-UIScrollList-UpdateMoveTips0 = 226,
		Beyond-UI-UIScrollList-get_moveTips0 = 227,
		Beyond-UI-UIScrollList-UpdateViewEffect0 = 228,
		Beyond-UI-ControllerSideMenuItemList-ToggleItemForceValid0 = 229,
		Beyond-UI-ControllerSideMenuItemList-IsItemForceValid0 = 230,
		Beyond-UI-ControllerSideMenuItemList-ClearForceValidItemList0 = 231,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-get_isForceValid0 = 232,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetItemName0 = 233,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-IsValid0 = 234,
		Beyond-UI-UIButton-get_groupEnabled0 = 235,
		Beyond-UI-UIButton-get_groupId0 = 236,
		Beyond-UI-UIButton-InitBinding0 = 237,
		Beyond-UI-UIButton-_UpdateState0 = 240,
		Beyond-UI-UIButton-OnPointerClick0 = 242,
		Beyond-UI-UIButton-_Press0 = 243,
		Beyond-UI-UIButton-get_panel0 = 246,
		Beyond-UI-UIButton-_OnUpdateKey0 = 247,
		Beyond-UI-UIButton-_InitActionOnSetNaviTarget0 = 253,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetText0 = 257,
		Beyond-UI-UIButton-get_text0 = 258,
		Beyond-UI-UIButton-get_label0 = 259,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetSprite0 = 260,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-Execute0 = 261,
		Beyond-UI-CustomUIStyle-get_inputValidTypeMask0 = 262,
		Beyond-UI-CustomUIStyle-set_inputValidTypeMask0 = 263,
		Beyond-UI-CustomUIStyle-get_overrideValidState0 = 264,
		Beyond-UI-CustomUIStyle-set_overrideValidState0 = 265,
		Beyond-UI-CustomUIStyle-CheckState0 = 266,
		Beyond-UI-CustomUIStyle-get_isValid0 = 267,
		Beyond-UI-CustomUIStyle-IsShowTypeValid0 = 268,
		Beyond-UI-CustomUIStyle-ToggleActiveState0 = 269,
		Beyond-UI-CustomUIStyle-_OnActiveTypeChanged0 = 270,
		Beyond-UI-CustomUIStyle-OnDestroy0 = 271,
		Beyond-UI-CustomUIStyle-OnEnable0 = 272,
		Beyond-UI-CustomUIStyle-Awake0 = 273,
		Beyond-UI-CustomUIStyle-IsValidInput0 = 274,
		Beyond-UI-DeactivateNaviOnEnable-OnEnable0 = 275,
		Beyond-UI-DeactivateNaviOnEnable-OnDisable0 = 276,
		Beyond-UI-DecoLineActiveHelper-get_tickOption0 = 277,
		Beyond-UI-DecoLineActiveHelper-Reset0 = 278,
		Beyond-UI-DecoLineActiveHelper-OnEnable0 = 279,
		Beyond-UI-DecoLineActiveHelper-LateTick0 = 280,
		Beyond-UI-DecoLineActiveHelper-_HasActiveTarget0 = 281,
		Beyond-UI-Empty4Raycast-OnPopulateMesh0 = 282,
		Beyond-UI-FitAspectRatioByFOV-get_maxFov0 = 283,
		Beyond-UI-FitAspectRatioByFOV-set_maxFov0 = 284,
		Beyond-UI-FitAspectRatioByFOV-_AdjustFOV0 = 285,
		Beyond-UI-FitAspectRatioByFOV-Start0 = 286,
		Beyond-UI-FitAspectRatioByFOV-OnEnable0 = 287,
		Beyond-UI-FitAspectRatioByFOV-OnDisable0 = 288,
		Beyond-UI-FitAspectRatioByFOV-OnScreenSizeChanged0 = 289,
		Beyond-UI-FixRotation-get_tickOption0 = 290,
		Beyond-UI-FixRotation-LateTick0 = 291,
		Beyond-UI-FullScreenSceneBlurMarker-_GetNextId0 = 292,
		Beyond-UI-FullScreenSceneBlurMarker-Awake0 = 293,
		Beyond-UI-FullScreenSceneBlurMarker-OnEnable0 = 295,
		Beyond-UI-FullScreenSceneBlurMarker-OnDisable0 = 297,
		Beyond-UI-FullScreenSceneBlurMarker-OnDestroy0 = 298,
		Beyond-UI-InputBindingGroupNaviDecorator-_SetSelfEnabledStateIfNecessary0 = 299,
		Beyond-UI-InputBindingGroupNaviDecorator-Awake0 = 300,
		Beyond-UI-InputBindingGroupNaviDecorator-OnEnable0 = 301,
		Beyond-UI-InputBindingGroupNaviDecorator-OnDestroy0 = 302,
		Beyond-UI-InputBindingGroupNaviDecorator-ClearComponent0 = 303,
		Beyond-UI-InputBindingGroupNaviDecorator-_OnSetAsNaviTarget0 = 304,
		Beyond-UI-UILoopScrollRect-get_scrollDirection0 = 305,
		Beyond-UI-UILoopScrollRect-get_viewportSize0 = 306,
		Beyond-UI-UILoopScrollRect-get_scrollSensitivity0 = 307,
		Beyond-UI-UILoopScrollRect-set_scrollSensitivity0 = 308,
		Beyond-UI-UILoopScrollRect-get_Position0 = 309,
		Beyond-UI-UILoopScrollRect-set_Position0 = 310,
		Beyond-UI-UILoopScrollRect-AutoScrollState-Reset0 = 311,
		Beyond-UI-UILoopScrollRect-_UpdatePosition0 = 312,
		Beyond-UI-UILoopScrollRect-get_tickOption0 = 313,
		Beyond-UI-UILoopScrollRect-get_currentIndex0 = 314,
		Beyond-UI-UILoopScrollRect-ScrollTo0 = 315,
		Beyond-UI-UILoopScrollRect-_ScrollTo0 = 316,
		Beyond-UI-UILoopScrollRect-_CircularPosition0 = 317,
		Beyond-UI-UILoopScrollRect-_UpdateSelection0 = 318,
		Beyond-UI-UILoopScrollRect-_RefreshToggle0 = 319,
		Beyond-UI-UILoopScrollRect-_PlayEndAudio0 = 320,
		Beyond-UI-UILoopScrollRect-_CalculateMovementAmount0 = 321,
		Beyond-UI-UILoopScrollRect-ScrollToMultiLoop0 = 322,
		Beyond-UI-UILoopScrollRect-_ScrollToMultiLoop0 = 323,
		Beyond-UI-UILoopScrollRect-OnValueChanged0 = 324,
		Beyond-UI-UILoopScrollRect-OnSelectionChanged0 = 325,
		Beyond-UI-UILoopScrollRect-JumpTo0 = 326,
		Beyond-UI-UILoopScrollRect-SetTotalCount0 = 327,
		Beyond-UI-UILoopScrollRect-_RefreshScrollToggleCount0 = 328,
		Beyond-UI-UILoopScrollRect-GetMovementDirection0 = 329,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown0 = 330,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp0 = 331,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IScrollHandler.OnScroll0 = 332,
		Beyond-UI-UILoopScrollRect-_CalculateOffset0 = 333,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag0 = 334,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IDragHandler.OnDrag0 = 335,
		Beyond-UI-UILoopScrollRect-_RubberDelta0 = 336,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IEndDragHandler.OnEndDrag0 = 337,
		Beyond-UI-UILoopScrollRect-Tick0 = 338,
		Beyond-UI-UILoopScrollRect-AutoScrollState-Complete0 = 339,
		Beyond-UI-UILoopScrollRect-ClearComponent0 = 340,
		Beyond-UI-UILoopScrollView-get_controllerStickScrollEnabled0 = 341,
		Beyond-UI-UILoopScrollView-get_tickOption0 = 342,
		Beyond-UI-UILoopScrollView-UpdatePosition0 = 343,
		Beyond-UI-UILoopScrollView-_UpdatePosition0 = 344,
		Beyond-UI-UILoopScrollView-Initialize0 = 345,
		Beyond-UI-UILoopScrollView-OnScrollEnd0 = 346,
		Beyond-UI-UILoopScrollView-_OnScrollEnd0 = 347,
		Beyond-UI-UILoopScrollView-_ResizePool0 = 348,
		Beyond-UI-UILoopScrollView-_GetNeedCount0 = 349,
		Beyond-UI-UILoopScrollView-Cell-SetVisible0 = 351,
		Beyond-UI-UILoopScrollView-_UpdateCellsAnimationPosition0 = 352,
		Beyond-UI-UILoopScrollView-_CircularIndex0 = 353,
		Beyond-UI-UILoopScrollView-Cell-get_isVisible0 = 355,
		Beyond-UI-UILoopScrollView-OnUpdateCell0 = 357,
		Beyond-UI-UILoopScrollView-Cell-UpdatePosition0 = 358,
		Beyond-UI-UILoopScrollView-_UpdateCells0 = 360,
		Beyond-UI-UILoopScrollView-ScrollToIndex0 = 362,
		Beyond-UI-UILoopScrollView-UpdateCount0 = 363,
		Beyond-UI-UILoopScrollView-Tick0 = 365,
		Beyond-UI-UILoopScrollView-_TickRefreshControllerStickScroll0 = 366,
		Beyond-UI-UILoopScrollView-_ScrollToNext0 = 367,
		Beyond-UI-UILoopScrollView-GetCurrentCell0 = 368,
		Beyond-UI-UILoopScrollView-OnRelease0 = 370,
		Beyond-UI-UILoopScrollView-ClearComponent0 = 371,
		Beyond-UI-UILoopScrollView-OnEnable0 = 372,
		Beyond-UI-UILoopScrollView-_InitController0 = 373,
		Beyond-UI-UILoopScrollView-_ScrollToNaviTarget0 = 374,
		Beyond-UI-UILoopScrollView-ScrollToObject0 = 375,
		Beyond-UI-UILoopScrollView-_ScrollToCell0 = 376,
		Beyond-UI-LuaPanel-get_blockWhileAnim0 = 378,
		Beyond-UI-LuaPanel-set_IsWorldUI0 = 379,
		Beyond-UI-LuaPanel-get_IsWorldUI0 = 380,
		Beyond-UI-LuaPanel-get_isPCOnlyPanel0 = 381,
		Beyond-UI-LuaPanel-get_isControllerPanel0 = 382,
		Beyond-UI-LuaPanel-Awake0 = 383,
		Beyond-UI-LuaPanel-_TrySetRot0 = 386,
		Beyond-UI-LuaPanel-AddSortingOrderComp0 = 387,
		Beyond-UI-LuaPanel-RemoveSortingOrderComp0 = 388,
		Beyond-UI-LuaPanel-Start0 = 389,
		Beyond-UI-LuaPanel-OnEnable0 = 390,
		Beyond-UI-LuaPanel-BlockAllInput0 = 391,
		Beyond-UI-LuaPanel-_AutoAnimationInFinish0 = 392,
		Beyond-UI-LuaPanel-OnDisable0 = 399,
		Beyond-UI-LuaPanel-OnDestroy0 = 400,
		Beyond-UI-LuaPanel-ClearComponent0 = 401,
		Beyond-UI-LuaPanel-get_animationInFinished0 = 402,
		Beyond-UI-MouseHoverTipsPosHelper-get_tickOption0 = 403,
		Beyond-UI-MouseHoverTipsPosHelper-get_panel0 = 404,
		Beyond-UI-MouseHoverTipsPosHelper-OnAwake0 = 405,
		Beyond-UI-MouseHoverTipsPosHelper-OnEnable0 = 406,
		Beyond-UI-MouseHoverTipsPosHelper-UpdatePosition0 = 407,
		Beyond-UI-MouseHoverTipsPosHelper-LateTick0 = 409,
		Beyond-UI-NaviToThisGroupOnEnable-Reset0 = 410,
		Beyond-UI-NaviToThisGroupOnEnable-Awake0 = 411,
		Beyond-UI-NaviToThisGroupOnEnable-OnEnable0 = 412,
		Beyond-UI-UISelectableNaviGroup-NaviToThisGroup0 = 413,
		Beyond-UI-UISelectableNaviGroup-_FindDefaultSelectable0 = 414,
		Beyond-UI-NonDrawingGraphic-get_Radius0 = 415,
		Beyond-UI-NonDrawingGraphic-SetMaterialDirty0 = 416,
		Beyond-UI-NonDrawingGraphic-SetVerticesDirty0 = 417,
		Beyond-UI-NonDrawingGraphic-OnPopulateMesh0 = 418,
		Beyond-UI-NonDrawingGraphic-IsRaycastLocationValid0 = 419,
		Beyond-UI-NonDrawingGraphic-_IsRaycastLocationValidCircle0 = 420,
		Beyond-UI-NotchAdapter-Awake0 = 421,
		Beyond-UI-NotchAdapter-_UpdateMargeSizeFromNotchInfo0 = 422,
		Beyond-UI-NotchAdapter-_OnCanvasChanged0 = 423,
		Beyond-UI-NotchAdapter-ApplyNewNotch0 = 424,
		Beyond-UI-NotchAdapter-ApplyNotch0 = 425,
		Beyond-UI-NotchAdapter-ClearNullRef0 = 426,
		Beyond-UI-NotchAdapter-FindAllSideUI0 = 427,
		Beyond-UI-NotchAdapter-ClearList0 = 428,
		Beyond-UI-NotchAdapter-_TraverseUI0 = 429,
		Beyond-UI-NotchAdapter-_TryAddToSideUI0 = 430,
		Beyond-UI-NotchAdapter-OnDestroy0 = 431,
		Beyond-UI-NotchAdapter-ApplyNotch1 = 432,
		Beyond-UI-NotchAdapter-UnApplyNotch0 = 433,
		Beyond-UI-ParallaxHelper-get_curValue0 = 434,
		Beyond-UI-ParallaxHelper-set_curValue0 = 435,
		Beyond-UI-ParallaxHelper-RefreshPos0 = 436,
		Beyond-UI-ParallaxHelper-InitConfigs0 = 437,
		Beyond-UI-ParallaxHelper-ResetValue0 = 438,
		Beyond-UI-PercentNumberTweener-get_tickOption0 = 439,
		Beyond-UI-PercentNumberTweener-Reset0 = 440,
		Beyond-UI-PercentNumberTweener-OnEnable0 = 441,
		Beyond-UI-PercentNumberTweener-LateTick0 = 442,
		Beyond-UI-UIRecycleLayoutAdapter-Init0 = 443,
		Beyond-UI-UIRecycleLayoutAdapter-GenerateViewsForRebuild0 = 445,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-get_isAttached0 = 446,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-AttachView0 = 447,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-DetachView0 = 448,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetAttachedView0 = 449,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetViewID0 = 450,
		Beyond-UI-UIRecycleLayoutGroup-get_tickOption0 = 451,
		Beyond-UI-UIRecycleLayoutGroup-get_adapter0 = 452,
		Beyond-UI-UIRecycleLayoutGroup-get_viewMgr0 = 453,
		Beyond-UI-UIRecycleLayoutGroup-get_spacing0 = 454,
		Beyond-UI-UIRecycleLayoutGroup-get_padding0 = 455,
		Beyond-UI-UIRecycleLayoutGroup-get_minWidth0 = 456,
		Beyond-UI-UIRecycleLayoutGroup-get_minHeight0 = 457,
		Beyond-UI-UIRecycleLayoutGroup-get_flexibleWidth0 = 458,
		Beyond-UI-UIRecycleLayoutGroup-get_flexibleHeight0 = 459,
		Beyond-UI-UIRecycleLayoutGroup-get_layoutPriority0 = 460,
		Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputHorizontal0 = 461,
		Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputVertical0 = 462,
		Beyond-UI-UIRecycleLayoutGroup-get_preferredWidth0 = 463,
		Beyond-UI-UIRecycleLayoutGroup-get_preferredHeight0 = 465,
		Beyond-UI-UIRecycleLayoutGroup-get_paddingFront0 = 466,
		Beyond-UI-UIRecycleLayoutGroup-get_paddingBack0 = 467,
		Beyond-UI-UIRecycleLayoutGroup-_ApplyLayoutMeta0 = 468,
		Beyond-UI-UIRecycleLayoutGroup-get_content0 = 469,
		Beyond-UI-UIRecycleLayoutGroup-_GetVisibleRange0 = 470,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsFromMeta0 = 471,
		Beyond-UI-UIRecycleLayoutGroup-SetAdapter0 = 472,
		Beyond-UI-UIRecycleLayoutGroup-_RebuildAllViews0 = 473,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RebuildAll0 = 474,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-RecycleAll0 = 475,
		Beyond-UI-UIRecycleLayoutGroup-_UpdateViews0 = 476,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViews0 = 477,
		Beyond-UI-UIRecycleLayoutGroup-ClearComponent0 = 479,
		Beyond-UI-UIRecycleLayoutGroup-LateTick0 = 480,
		Beyond-UI-UIRecycleLayoutGroup-OnLateTick0 = 481,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-DetachView0 = 482,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_EnsureViewPool0 = 483,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-Recycle0 = 484,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AttachView0 = 485,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-Alloc0 = 486,
		Beyond-UI-UIRecycleLayoutGroup-_InsertView0 = 487,
		Beyond-UI-UIRecycleLayoutGroup-_RemoveView0 = 488,
		Beyond-UI-UIRecycleLayoutGroup-_UpdateViewsFrom0 = 489,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementPosByIndex0 = 490,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetView0 = 491,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsByIndex0 = 492,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementIndex0 = 493,
		Beyond-UI-UIRecycleLayoutGroup-_RefreshLayout0 = 494,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewCount0 = 495,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-InsertView0 = 496,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AddView0 = 497,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RemoveView0 = 498,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyViewSizeChanged0 = 499,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyAllViewSizeChanged0 = 500,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyRebuild0 = 501,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementPosByIndex0 = 502,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementBoundsByIndex0 = 503,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetDirection0 = 504,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetSizeOnAxis0 = 505,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewportSizeOnAxis0 = 506,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementIndex0 = 507,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_NotifyLayoutChanged0 = 508,
		Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-GenerateViewsForRebuild0 = 509,
		Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-OnInit0 = 510,
		Beyond-UI-UIRecycleMultiHolder-GetVirtualView0 = 511,
		Beyond-UI-UIRecycleMultiHolder-UpdateCount1 = 512,
		Beyond-UI-UIRecycleMultiHolder-UpdateCount0 = 513,
		Beyond-UI-UIRecycleMultiHolder-InsertView0 = 514,
		Beyond-UI-UIRecycleMultiHolder-AddView0 = 515,
		Beyond-UI-UIRecycleMultiHolder-OnAdapterInit0 = 516,
		Beyond-UI-UIRecycleMultiHolder-ClearComponent0 = 517,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetIndex0 = 518,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPrefab0 = 520,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPreferSize0 = 521,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewDetached0 = 522,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewAttached0 = 523,
		Beyond-UI-UIRecycleSingleHolder-GetVirtualView0 = 524,
		Beyond-UI-UIRecycleSingleHolder-UpdateCount1 = 525,
		Beyond-UI-UIRecycleSingleHolder-UpdateCount0 = 526,
		Beyond-UI-UIRecycleSingleHolder-InsertView0 = 527,
		Beyond-UI-UIRecycleSingleHolder-AddView0 = 528,
		Beyond-UI-UIRecycleSingleHolder-OnAdapterInit0 = 529,
		Beyond-UI-UIRecycleSingleHolder-ClearComponent0 = 530,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetIndex0 = 531,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPrefab0 = 532,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPreferSize0 = 533,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewDetached0 = 534,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewAttached0 = 535,
		Beyond-UI-SimpleUITextSingleLine-GenerateTextMesh0 = 536,
		Beyond-UI-ToastList-Awake0 = 537,
		Beyond-UI-ToastList-OnDisable0 = 539,
		Beyond-UI-ToastList-ClearAllToast0 = 540,
		Beyond-UI-ToastList-_CacheCell0 = 542,
		Beyond-UI-ToastList-_GetCell0 = 543,
		Beyond-UI-ToastList-AddToast0 = 544,
		Beyond-UI-ToastList-_StartBatch0 = 545,
		Beyond-UI-ToastList-_ShowCell0 = 546,
		Beyond-UI-UIAnimationWrapper-PlayOutAnimation0 = 550,
		Beyond-UI-UIAnimationWrapper-PlayCloseAudio0 = 553,
		Beyond-UI-ToastList-_TryShowNewCell0 = 554,
		Beyond-UI-UIAnimationWrapper-GetOutClipLength0 = 555,
		Beyond-UI-ToastList-_OnCellFinished0 = 556,
		Beyond-UI-ToastList-ClearComponent0 = 560,
		Beyond-UI-UI3DScrollList-MoveCellTo0 = 561,
		Beyond-UI-UIActionKeyHint-_TryInit0 = 562,
		Beyond-UI-UIActionKeyHint-_OnControllerTypeChange0 = 563,
		Beyond-UI-UIActionKeyHint-_RefreshAllKeyHints0 = 564,
		Beyond-UI-UIActionKeyHint-UpdateKeyHint0 = 565,
		Beyond-UI-UIActionKeyHint-SetSecondActionId0 = 566,
		Beyond-UI-UIActionKeyHint-_SetSecondIcon0 = 567,
		Beyond-UI-UIActionKeyHint-GetAndSetActionIcon0 = 568,
		Beyond-UI-UIActionKeyHint-_SetKeyCodeSprite0 = 569,
		Beyond-UI-UIImage-LoadSpriteWithOutFormat0 = 570,
		Beyond-UI-UIImage-_LoadSprite0 = 571,
		Beyond-UI-UIImage-DisposeSpriteHandle0 = 572,
		Beyond-UI-UIActionKeyHint-GetActionInfo0 = 573,
		Beyond-UI-UIActionKeyHint-GetActionId0 = 574,
		Beyond-UI-UIActionKeyHint-get_target0 = 575,
		Beyond-UI-UIActionKeyHint-SetContentState0 = 576,
		Beyond-UI-UIActionKeyHint-GetAndSetActionModifyIcon0 = 577,
		Beyond-UI-UIActionKeyHint-GetTextStr0 = 578,
		Beyond-UI-UIActionKeyHint-_CheckInteractable0 = 579,
		Beyond-UI-UIActionKeyHint-_IsInputGray0 = 581,
		Beyond-UI-UIActionKeyHint-_IsInputEnabled0 = 582,
		Beyond-UI-UIActionKeyHint-_OnInputLateTickAll0 = 583,
		Beyond-UI-UIActionKeyHint-get_showCanvasGroup0 = 584,
		Beyond-UI-UIActionKeyHint-Awake0 = 585,
		Beyond-UI-UIActionKeyHint-OnEnable0 = 586,
		Beyond-UI-UIActionKeyHint-_OnInputActionKeyUpdated0 = 587,
		Beyond-UI-UIActionKeyHint-OnDisable0 = 588,
		Beyond-UI-UIActionKeyHint-OnDestroy0 = 589,
		Beyond-UI-UIActionKeyHint-ClearComponent0 = 590,
		Beyond-UI-UIActionKeyHint-Reset0 = 591,
		Beyond-UI-UIActionKeyHint-SetActionId0 = 592,
		Beyond-UI-UIActionKeyHint-SetKeyHint0 = 593,
		Beyond-UI-UIActionKeyHint-_OnChangeTarget0 = 594,
		Beyond-UI-UIActionKeyHint-SetBindingId0 = 595,
		Beyond-UI-UIActionKeyHint-SetBindingId1 = 596,
		Beyond-UI-UIActionKeyHint-SetText0 = 597,
		Beyond-UI-UIAnimationHolder-FindByName0 = 598,
		Beyond-UI-UIAnimationHolder-_FindByString0 = 599,
		Beyond-UI-UIAnimationHolder-FindByNameOrAlias0 = 600,
		Beyond-UI-UIAnimationHolder-GetAnimationClips0 = 601,
		Beyond-UI-UIAnimationLoopSynchronizer-RegisterChild0 = 602,
		Beyond-UI-UIAnimationLoopSynchronizer-UnregisterChild0 = 603,
		Beyond-UI-UIAnimationWrapper-get_animationInEasing0 = 604,
		Beyond-UI-UIAnimationWrapper-get_animationLoop0 = 605,
		Beyond-UI-UIAnimationWrapper-get_animationOut0 = 606,
		Beyond-UI-UIAnimationWrapper-SetOptions0 = 607,
		Beyond-UI-UIAnimationWrapper-_AnimationInLoopCheck0 = 608,
		Beyond-UI-UIAnimationWrapper-_AnimationAutomaticallyCheck0 = 609,
		Beyond-UI-UIAnimationWrapper-Awake0 = 610,
		Beyond-UI-UIAnimationWrapper-IsStarted0 = 611,
		Beyond-UI-UIAnimationWrapper-SetAnimationInClip0 = 612,
		Beyond-UI-UIAnimationWrapper-SetAnimationInEasingClip0 = 613,
		Beyond-UI-UIAnimationWrapper-SetAnimationLoopClip0 = 614,
		Beyond-UI-UIAnimationWrapper-SetAnimationOutClip0 = 615,
		Beyond-UI-UIAnimationWrapper-GetInClipLength0 = 616,
		Beyond-UI-UIAnimationWrapper-GetLoopClipLength0 = 617,
		Beyond-UI-UIAnimationWrapper-SkipInAnimation0 = 618,
		Beyond-UI-UIAnimationWrapper-SampleToInAnimationBegin0 = 619,
		Beyond-UI-UIAnimationWrapper-SampleToInAnimationEnd0 = 620,
		Beyond-UI-UIAnimationWrapper-SampleToOutAnimationBegin0 = 621,
		Beyond-UI-UIAnimationWrapper-SampleToOutAnimationEnd0 = 622,
		Beyond-UI-UIAnimationWrapper-GetClipLength0 = 623,
		Beyond-UI-UIAnimationWrapper-AnimationRuntime-GetClipLength0 = 624,
		Beyond-UI-UIAnimationWrapper-SampleClipAtPercent0 = 625,
		Beyond-UI-UIAnimationWrapper-_CheckShouldAutoPlayAnimationIn0 = 626,
		Beyond-UI-UIAnimationWrapper-Start0 = 627,
		Beyond-UI-UIAnimationWrapper-OnEnable0 = 628,
		Beyond-UI-UIAnimationWrapper-OnDisable0 = 629,
		Beyond-UI-UIAnimationWrapper-OnDestroy0 = 630,
		Beyond-UI-UIAnimationWrapper-ClearComponent0 = 631,
		Beyond-UI-UIAnimationWrapper-CheckStopped0 = 632,
		Beyond-UI-UIAnimationWrapper-Play0 = 633,
		Beyond-UI-UIAnimationWrapper-Play1 = 634,
		Beyond-UI-UIAnimationWrapper-GetCurPlayingTime0 = 635,
		Beyond-UI-UIAnimationTween-GetValue0 = 636,
		Beyond-UI-UIAnimationWrapper-SetAudioOnOpen0 = 637,
		Beyond-UI-UIAnimationWrapper-FOptions-GetDefault0 = 638,
		Beyond-UI-UIAnimationTween-_SetValue0 = 639,
		Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfHide0 = 640,
		Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfShow0 = 641,
		Beyond-UI-UIAnimationSwitchTween-BeforeShowEffect0 = 642,
		Beyond-UI-UIAnimationSwitchTween-_SetGameObjectActive0 = 643,
		Beyond-UI-UIAnimationSwitchTween-AfterHideEffect0 = 644,
		Beyond-UI-UIAnimationSwitchTween-ResetToState0 = 645,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-IsPlaying0 = 646,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-KillIfNecessary0 = 647,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-OnComplete0 = 648,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-SetAutoKill0 = 649,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-_OnComplete0 = 650,
		Beyond-UI-UIAnimationSwitchTween-Builder-Build0 = 651,
		Beyond-UI-UIArea-get_pointerInArea0 = 652,
		Beyond-UI-UIArea-get_usePositionCheckMode0 = 653,
		Beyond-UI-UIArea-get_tickOption0 = 654,
		Beyond-UI-UIArea-_SetHighlightNodeActive0 = 655,
		Beyond-UI-UIArea-OnPointerEnter0 = 656,
		Beyond-UI-UIArea-OnPointerExit0 = 657,
		Beyond-UI-UIArea-OnAwake0 = 658,
		Beyond-UI-UIArea-Tick0 = 659,
		Beyond-UI-UIArea-_GetPointerScreenPosition0 = 660,
		Beyond-UI-UIArea-OnEnable0 = 661,
		Beyond-UI-UIArea-OnDisable0 = 662,
		Beyond-UI-UIArea-OnDestroy0 = 663,
		Beyond-UI-UIArea-ClearComponent0 = 664,
		Beyond-UI-UIAutoCloseArea-get_tickOption0 = 665,
		Beyond-UI-UIAutoCloseArea-get_includeInAutoCloseLayer0 = 666,
		Beyond-UI-UIAutoCloseArea-set_includeInAutoCloseLayer0 = 667,
		Beyond-UI-UIAutoCloseArea-AddToAutoCloseLayer0 = 668,
		Beyond-UI-UIAutoCloseArea-RemoveFromAutoCloseLayer0 = 669,
		Beyond-UI-UIAutoCloseArea-get_panel0 = 670,
		Beyond-UI-UIAutoCloseArea-Start0 = 671,
		Beyond-UI-UIAutoCloseArea-InitBinding0 = 672,
		Beyond-UI-UIAutoCloseArea-TryCloseSelf0 = 675,
		Beyond-UI-UIAutoCloseArea-CloseSelf0 = 676,
		Beyond-UI-UIAutoCloseArea-_AutoCloseToggleObjWhenOut0 = 677,
		Beyond-UI-UIAutoCloseArea-_UpdateState0 = 679,
		Beyond-UI-UIAutoCloseArea-Reset0 = 680,
		Beyond-UI-UIAutoCloseArea-LateTick0 = 681,
		Beyond-UI-UIAutoCloseArea-ShouldClose0 = 682,
		Beyond-UI-UIAutoCloseArea-_GetUICamera0 = 683,
		Beyond-UI-UIAutoCloseArea-IsTopAutoCloseLayer0 = 684,
		Beyond-UI-UIAutoCloseArea-OnEnable0 = 685,
		Beyond-UI-UIAutoCloseArea-OnDisable0 = 686,
		Beyond-UI-UIAutoCloseArea-ChangeEnableCloseActionOnController0 = 687,
		Beyond-UI-UIAutoCloseArea-OpenSelf0 = 688,
		Beyond-UI-UIAutoCloseArea-ClearComponent0 = 689,
		Beyond-UI-UIAutoCloseArea-get_groupEnabled0 = 690,
		Beyond-UI-UIAutoCloseArea-OnDestroy0 = 691,
		Beyond-UI-UIBigLogo-SetBigLogoEditor0 = 692,
		Beyond-UI-UIBigLogo-ShowBigLogo0 = 693,
		Beyond-UI-UIBigLogo-SetBigLogoMask0 = 694,
		Beyond-UI-UIBigLogo-ClearBigLogoMask0 = 695,
		Beyond-UI-UIBigLogo-ClearBigLogo0 = 696,
		Beyond-UI-UIBigLogo-SetAlpha0 = 697,
		Beyond-UI-UIBigLogo-SetMaskAlpha0 = 698,
		Beyond-UI-UIBigRectButton-OnPointerDown0 = 699,
		Beyond-UI-UIButton-OnPointerDown0 = 700,
		Beyond-UI-UIButton-_StopLongPressCor0 = 701,
		Beyond-UI-UIButton-_PlayClickAnimation0 = 702,
		Beyond-UI-UIButton-_DoClickAnimation0 = 703,
		Beyond-UI-UIButton-_OnPress0 = 710,
		Beyond-UI-UIBigRectButton-OnPointerUp0 = 719,
		Beyond-UI-UIButton-OnPointerUp0 = 720,
		Beyond-UI-UIBigRectButton-OnDrag0 = 721,
		Beyond-UI-UIBigRectButton-OnBeginDrag0 = 722,
		Beyond-UI-UIBigRectButton-OnEndDrag0 = 723,
		Beyond-UI-UIBigRectButton-OnScroll0 = 724,
		Beyond-UI-UIBigRectHelper-get_tickOption0 = 725,
		Beyond-UI-UIBigRectHelper-get_OnOpenTweenFinished0 = 726,
		Beyond-UI-UIBigRectHelper-get_zoomRangeMin0 = 727,
		Beyond-UI-UIBigRectHelper-get_zoomEvent0 = 728,
		Beyond-UI-UIBigRectHelper-get_touchPanel0 = 729,
		Beyond-UI-UIBigRectHelper-OnAwake0 = 730,
		Beyond-UI-UIBigRectHelper-_OnDrag0 = 732,
		Beyond-UI-UIBigRectHelper-_GetAdjustedPosition0 = 733,
		Beyond-UI-UIBigRectHelper-_GetContainerRectBounds0 = 734,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPosition1 = 736,
		Beyond-UI-UIBigRectHelper-ResetPivotPositionToScreenCenter0 = 737,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPosition0 = 738,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPositionToMousePosition0 = 739,
		Beyond-UI-UIBigRectHelper-_OnZoom0 = 740,
		Beyond-UI-UIBigRectHelper-_SetZoomValueAndScale0 = 741,
		Beyond-UI-UIBigRectHelper-_SetScale0 = 742,
		Beyond-UI-UIBigRectHelper-_UpdatePositionOffsetAfterZoomed0 = 744,
		Beyond-UI-UIBigRectHelper-_PosAdjust0 = 745,
		Beyond-UI-UIBigRectHelper-_InitControllerBindings0 = 746,
		Beyond-UI-UIBigRectHelper-_OnControllerClick0 = 747,
		Beyond-UI-UIBigRectHelper-_RefreshControllerFocusRaycastResults0 = 748,
		Beyond-UI-UIBigRectHelper-Tick0 = 751,
		Beyond-UI-UIBigRectHelper-_TickRefreshController0 = 752,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickMove0 = 753,
		Beyond-UI-UIBigRectHelper-_GetIsControllerMoveEnabled0 = 754,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickZoom0 = 756,
		Beyond-UI-UIBigRectHelper-_GetIsControllerZoomEnabled0 = 757,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerZoomKeyHint0 = 759,
		Beyond-UI-UIBigRectHelper-LateTick0 = 760,
		Beyond-UI-UIBigRectHelper-_TickCheckControllerFocusRaycastTargets0 = 761,
		Beyond-UI-UIBigRectHelper-OnRelease0 = 762,
		Beyond-UI-UIBigRectHelper-ManuallyZoom0 = 763,
		Beyond-UI-UIBigRectHelper-_TryAlignWhenInit0 = 764,
		Beyond-UI-UIBigRectHelper-Init0 = 765,
		Beyond-UI-UIBigRectHelper-_ResetControllerState0 = 767,
		Beyond-UI-UIBigRectHelper-FocusNode0 = 768,
		Beyond-UI-UIBigRectHelper-FocusNode1 = 769,
		Beyond-UI-UIBigRectHelper-ZoomToFullRect0 = 772,
		Beyond-UI-UIBigRectHelper-ChangePaddingRight0 = 773,
		Beyond-UI-UIBigRectHelper-SetZoomRangeMax0 = 774,
		Beyond-UI-UIBigRectHelper-OverrideZoomRangeMin0 = 775,
		Beyond-UI-UIBigRectHelper-SyncZoomValue0 = 776,
		Beyond-UI-UIBigRectHelper-GetRecoverState0 = 777,
		Beyond-UI-UIBigRectHelper-GetZoomRange0 = 778,
		Beyond-UI-UIBigRectHelper-GetCurrentZoomValue0 = 779,
		Beyond-UI-UIBigRectHelper-ChangePivotPositionToTarget0 = 780,
		Beyond-UI-UIBigRectHelper-RecoverContainerState0 = 781,
		Beyond-UI-UIBigRectHelper-ClearAllTween0 = 782,
		Beyond-UI-UIBigRectHelper-ClearComponent0 = 783,
		Beyond-UI-UIBlendImage-SetMaterialKey0 = 784,
		Beyond-UI-UIBlendImage-SetColor0 = 785,
		Beyond-UI-UIBlendImage-SetTexture0 = 786,
		Beyond-UI-UIBlendImage-ClearMaterialCache0 = 787,
		Beyond-UI-UIBlurMono-get_tickOption0 = 788,
		Beyond-UI-UIBlurMono-get_canvas0 = 789,
		Beyond-UI-UIBlurMono-get_panel0 = 790,
		Beyond-UI-UIBlurMono-OnEnable0 = 791,
		Beyond-UI-UIBlurMono-_GetCamera0 = 792,
		Beyond-UI-UIBlurMono-OnDisable0 = 793,
		Beyond-UI-UIBlurMono-Tick0 = 794,
		Beyond-UI-UIBlurMono-UpdateSortingOrder0 = 795,
		Beyond-UI-UIBlurRT-get_rawImage0 = 796,
		Beyond-UI-UIBlurRT-Reset0 = 797,
		Beyond-UI-UIBlurRT-InitRT0 = 798,
		Beyond-UI-UIBlurRT-Register0 = 800,
		Beyond-UI-UIBlurRT-SetUseSceneColorPS0 = 801,
		Beyond-UI-UIBlurRT-UnRegister0 = 802,
		Beyond-UI-UIBlurRT-UpdateRT0 = 803,
		Beyond-UI-UIBlurRT-OnEnable0 = 804,
		Beyond-UI-UIBlurRT-OnDisable0 = 805,
		Beyond-UI-UIBlurRT-_Clear0 = 806,
		Beyond-UI-UIBlurRT-OnDestroy0 = 807,
		Beyond-UI-UIBlurRT-SetCustomBlurImg0 = 808,
		Beyond-UI-UIButton-Awake0 = 810,
		Beyond-UI-UIButton-OnEnable0 = 811,
		Beyond-UI-UIButton-OnDisable0 = 812,
		Beyond-UI-UIButton-OnDestroy0 = 813,
		Beyond-UI-UIButton-ClearComponent0 = 814,
		Beyond-UI-UIButton-_NotifyIsHover0 = 815,
		Beyond-UI-UIButton-get_longPressTime0 = 816,
		Beyond-UI-UIButton-get_curPressPos0 = 817,
		Beyond-UI-UIButton-get_triggeredLongPress0 = 818,
		Beyond-UI-UIButton-set_text0 = 819,
		Beyond-UI-UIButton-get_parentTarget0 = 820,
		Beyond-UI-UIButton-OnInteractableChanged0 = 821,
		Beyond-UI-UIButton-get_bindingViewActionId0 = 822,
		Beyond-UI-UIButton-_GetUIButtonKeyHintActionId0 = 823,
		Beyond-UI-UIButton-get_customBindingViewLabelText0 = 824,
		Beyond-UI-UIButton-set_customBindingViewLabelText0 = 825,
		Beyond-UI-UIButton-get_bindingViewLabelText0 = 826,
		Beyond-UI-UIButton-get_hintText0 = 827,
		Beyond-UI-UIButton-get_redDotTrans0 = 828,
		Beyond-UI-UIButton-get_bindingEnabled0 = 829,
		Beyond-UI-UIButton-get_bindingViewState0 = 830,
		Beyond-UI-UIButton-_IsAnyButtonEventActionInGuideUse0 = 831,
		Beyond-UI-UIButton-GetBindingViewActionId0 = 832,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyDown0 = 833,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyUp0 = 834,
		Beyond-UI-UIButton-get_hoverBindingGroupId0 = 835,
		Beyond-UI-UIButton-_RefreshHoverEnableNode0 = 836,
		Beyond-UI-UIButton-GetMouseActionHints0 = 837,
		Beyond-UI-UIButton-OnNaviTargetEnabledAgain0 = 838,
		Beyond-UI-UIButton-get_actionOnSetNaviTarget0 = 839,
		Beyond-UI-UIButton-_OnSetAsNaviTarget0 = 840,
		Beyond-UI-UIButton-_ToggleNaviInputBinding0 = 841,
		Beyond-UI-UIButton-ChangeActionOnSetNaviTarget0 = 842,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.get_interactable0 = 843,
		Beyond-UI-UICanvasScaleHelper-get_standardHorizontalResolution0 = 844,
		Beyond-UI-UICanvasScaleHelper-get_standardVerticalResolution0 = 845,
		Beyond-UI-UICanvasScaleHelper-get_standardResolutionScale0 = 846,
		Beyond-UI-UICanvasScaleHelper-get_canvasScalerList0 = 847,
		Beyond-UI-UICanvasScaleHelper-Awake0 = 848,
		Beyond-UI-UICanvasScaleHelper-_OnInit0 = 849,
		Beyond-UI-UICanvasScaleHelper-GetProperCanvasResolution0 = 850,
		Beyond-UI-UICanvasScaleHelper-Start0 = 851,
		Beyond-UI-UICanvasScaleHelper-_OnInputTypeChanged0 = 852,
		Beyond-UI-UICanvasScaleHelper-_CanvasOnWillRenderCanvases0 = 853,
		Beyond-UI-UICanvasScaleHelper-OnDestroy0 = 854,
		Beyond-UI-UICanvasScaleHelper-ClearComponent0 = 855,
		Beyond-UI-UICanvasScaleHelper-UpdateCanvas0 = 856,
		Beyond-UI-UICanvasScaleHelper-CalcWorldCanvasParams0 = 857,
		Beyond-UI-UICanvasScaleHelper-CalcCurrentScreenRatio0 = 858,
		Beyond-UI-UICanvasScaleHelper-CalcScreenCanvasParams0 = 859,
		Beyond-UI-UICanvasScaleHelper-OnScreenSizeChanged0 = 860,
		Beyond-UI-UICanvasScaleHelper-AddCanvas0 = 861,
		Beyond-UI-UICanvasScaleHelper-RemoveCanvas0 = 862,
		Beyond-UI-UICanvasScaleHelper-ForceCanvasUpdate0 = 863,
		Beyond-UI-UIColorGroup-get_color0 = 864,
		Beyond-UI-UIColorGroup-set_color0 = 865,
		Beyond-UI-UIColorGroup-_SetColor0 = 866,
		Beyond-UI-UIColorGroup-_ApplyOptToGraphics0 = 867,
		Beyond-UI-UIColorGroup-AttachGraphic0 = 868,
		Beyond-UI-UIColorGroup-AttachGraphicsWithGroup0 = 869,
		Beyond-UI-UIColorGroup-CrossFadeAlpha0 = 870,
		Beyond-UI-UIColorGroup-_CrossFadeAlpha0 = 871,
		Beyond-UI-UIColorGroup-CrossFadeColor0 = 872,
		Beyond-UI-UIColorGroup-_CrossFadeColorRGB0 = 873,
		Beyond-UI-UIColorGroup-CrossFadeColor1 = 874,
		Beyond-UI-UIColorGroup-_CrossFadeColorAlpha0 = 875,
		Beyond-UI-UIControllerKeyIcon-_TryStaticInit0 = 876,
		Beyond-UI-UIControllerKeyIcon-_OnControllerTypeChange0 = 877,
		Beyond-UI-UIControllerKeyIcon-RefreshKeyIcon0 = 878,
		Beyond-UI-UIControllerKeyIcon-Awake0 = 879,
		Beyond-UI-UIControllerKeyIcon-OnEnable0 = 880,
		Beyond-UI-UIControllerKeyIcon-OnDisable0 = 881,
		Beyond-UI-UIControllerKeyIcon-SetKeyIconName0 = 882,
		Beyond-UI-UICustomLayout-get_dragArea0 = 883,
		Beyond-UI-UICustomLayout-Awake0 = 884,
		Beyond-UI-UICustomLayout-IsDirty0 = 885,
		Beyond-UI-UICustomLayoutHandle-IsDirty0 = 886,
		Beyond-UI-UICustomLayout-ResetToDefault0 = 887,
		Beyond-UI-UICustomLayoutHandle-ResetToDefault0 = 888,
		Beyond-UI-UICustomLayoutHandle-_SetChanged0 = 889,
		Beyond-UI-UICustomLayoutHandle-get_Element0 = 890,
		Beyond-UI-UICustomLayoutElement-ResetToDefault0 = 891,
		Beyond-UI-UICustomLayoutElement-_GetMarginSize0 = 892,
		Beyond-UI-UICustomLayoutElement-get_panel0 = 893,
		Beyond-UI-UICustomLayoutElement-_ApplyScale0 = 894,
		Beyond-UI-UICustomLayoutElement-_ApplyAlpha0 = 895,
		Beyond-UI-UICustomLayoutElement-_ApplyPosition0 = 896,
		Beyond-UI-UICustomLayoutElement-get_alpha0 = 897,
		Beyond-UI-UICustomLayoutElement-get_scale0 = 898,
		Beyond-UI-UICustomLayoutElement-get_position0 = 899,
		Beyond-UI-UICustomLayoutElement-get_layoutType0 = 900,
		Beyond-UI-UICustomLayout-Save0 = 901,
		Beyond-UI-UICustomLayoutHandle-Save0 = 902,
		Beyond-UI-UICustomLayoutElement-SaveData0 = 903,
		Beyond-UI-UICustomLayoutElement-_CheckElementKeyIsValid0 = 904,
		Beyond-UI-UICustomLayoutElement-GetElementKeyWithRatio0 = 905,
		Beyond-UI-UICustomLayout-_LogEvent0 = 906,
		Beyond-UI-UICustomLayoutElement-get_elementKey0 = 907,
		Beyond-UI-UICustomLayoutElement-get_highlightRect0 = 908,
		Beyond-UI-UICustomLayoutElement-set_scale0 = 909,
		Beyond-UI-UICustomLayoutElement-set_alpha0 = 910,
		Beyond-UI-UICustomLayoutElement-set_position0 = 911,
		Beyond-UI-UICustomLayoutElement-set_layoutType0 = 912,
		Beyond-UI-UICustomLayoutElement-Awake0 = 913,
		Beyond-UI-UICustomLayoutElement-_SetDefaultValues0 = 914,
		Beyond-UI-UICustomLayoutElement-_OnHudLayoutSaved0 = 915,
		Beyond-UI-UICustomLayoutElement-LoadData0 = 916,
		Beyond-UI-UICustomLayoutElement-Start0 = 917,
		Beyond-UI-UICustomLayoutElement-OnDestroy0 = 918,
		Beyond-UI-UICustomLayoutElement-ClearComponent0 = 919,
		Beyond-UI-UICustomLayoutElement-RefreshAll0 = 920,
		Beyond-UI-UICustomLayoutHandle-get_scale0 = 921,
		Beyond-UI-UICustomLayoutHandle-set_scale0 = 922,
		Beyond-UI-UICustomLayoutHandle-_ApplyScale0 = 923,
		Beyond-UI-UICustomLayoutHandle-get_position0 = 924,
		Beyond-UI-UICustomLayoutHandle-set_position0 = 925,
		Beyond-UI-UICustomLayoutHandle-_CalculatePositionRange0 = 926,
		Beyond-UI-UICustomLayoutHandle-_ApplyPosition0 = 927,
		Beyond-UI-UICustomLayoutHandle-get_alpha0 = 928,
		Beyond-UI-UICustomLayoutHandle-set_alpha0 = 929,
		Beyond-UI-UICustomLayoutHandle-_ApplyAlpha0 = 930,
		Beyond-UI-UICustomLayoutHandle-get_layoutType0 = 931,
		Beyond-UI-UICustomLayoutHandle-set_layoutType0 = 932,
		Beyond-UI-UICustomLayoutHandle-_ApplyLayoutType0 = 933,
		Beyond-UI-UICustomLayoutHandle-get_panel0 = 934,
		Beyond-UI-UICustomLayoutHandle-Awake0 = 935,
		Beyond-UI-UICustomLayoutHandle-_OnElementDataLoaded0 = 936,
		Beyond-UI-UICustomLayoutHandle-_OnSystemDisplaySizeChanged0 = 937,
		Beyond-UI-UICustomLayoutHandle-OnDestroy0 = 938,
		Beyond-UI-UICustomLayoutHandle-OnBeginDrag0 = 939,
		Beyond-UI-UICustomLayoutHandle-OnDrag0 = 940,
		Beyond-UI-UICustomLayoutHandle-OnEndDrag0 = 941,
		Beyond-UI-UICustomLayoutHandle-OnPointerClick0 = 942,
		Beyond-UI-UICustomLayoutHandle-ClearComponent0 = 943,
		Beyond-UI-UIDialogText-get_tickOption0 = 944,
		Beyond-UI-UIDialogText-get_useAspectRatio0 = 945,
		Beyond-UI-UIDialogText-get_notUseAspectRatio0 = 946,
		Beyond-UI-UIDialogText-get_playing0 = 947,
		Beyond-UI-UIDialogText-get_uiText0 = 948,
		Beyond-UI-UIDialogText-get_totalCharacterNum0 = 949,
		Beyond-UI-UIDialogText-get_textRevealSpeed0 = 950,
		Beyond-UI-UIDialogText-set_textRevealSpeed0 = 951,
		Beyond-UI-UIDialogText-OnAwake0 = 952,
		Beyond-UI-UIDialogText-ResetPlay0 = 953,
		Beyond-UI-UIDialogText-Start0 = 954,
		Beyond-UI-UIDialogText-SetText0 = 955,
		Beyond-UI-UIDialogText-_RefreshPosY0 = 956,
		Beyond-UI-UIDialogText-RefreshAutoScrollData0 = 957,
		Beyond-UI-UIDialogText-Play0 = 958,
		Beyond-UI-UIDialogText-OnDisable0 = 959,
		Beyond-UI-UIDialogText-OnEnable0 = 960,
		Beyond-UI-UIDialogText-RefreshText0 = 961,
		Beyond-UI-UIDialogText-Tick0 = 962,
		Beyond-UI-UIDialogText-_UpdateTextAuto0 = 963,
		Beyond-UI-UIDialogText-OnVisibleCharactersChanged0 = 964,
		Beyond-UI-UIDialogText-StopPlay0 = 965,
		Beyond-UI-UIDialogText-_TryAutoScroll0 = 966,
		Beyond-UI-UIDialogText-GetAutoWaitTime0 = 967,
		Beyond-UI-UIDialogText-GetScrollSpeed0 = 968,
		Beyond-UI-UIDialogText-SeekToEnd0 = 969,
		Beyond-UI-UIDialogText-ManualUpdateByPercent0 = 970,
		Beyond-UI-UIDialogText-ManualUpdateByTime0 = 971,
		Beyond-UI-UIDialogText-GetDisplayAllCharactersTime0 = 972,
		Beyond-UI-UIDialogTextWithCursor-ResetPlay0 = 973,
		Beyond-UI-UIDialogTextWithCursor-OnVisibleCharactersChanged0 = 974,
		Beyond-UI-UIDialogTextWithCursor-GetDisplayAllCharactersTime0 = 975,
		Beyond-UI-UIDialogTimelineText-get_canvasGroup0 = 976,
		Beyond-UI-UIDialogTimelineText-get_dialogText0 = 977,
		Beyond-UI-UIDialogTimelineText-get_actorName0 = 978,
		Beyond-UI-UIDialogTimelineText-get_waitNode0 = 979,
		Beyond-UI-UIDialogTimelineText-UpdateAlpha0 = 980,
		Beyond-UI-UIDialogTimelineText-SetRadioIcon0 = 981,
		Beyond-UI-UIImage-LoadSprite0 = 982,
		Beyond-UI-UIDialogTimelineText-_ClearRadioIcon0 = 983,
		Beyond-UI-UIDrag-Awake0 = 985,
		Beyond-UI-UIDrag-OnDrag0 = 986,
		Beyond-UI-UIDrag-OnBeginDrag0 = 987,
		Beyond-UI-UIDrag-OnEndDrag0 = 988,
		Beyond-UI-UIDrag-ApplyDragArea0 = 989,
		Beyond-UI-UIDrag-ClearComponent0 = 990,
		Beyond-UI-UIDragHandler-get_dragThreshold0 = 991,
		Beyond-UI-UIDragHandler-ClearComponent0 = 992,
		Beyond-UI-UIDragHandler-OnPointerDown0 = 993,
		Beyond-UI-UIDragHandler-OnBeginDrag0 = 994,
		Beyond-UI-UIDragHandler-OnDrag0 = 995,
		Beyond-UI-UIDragHandler-OnEndDrag0 = 996,
		Beyond-UI-UIDragItem-get_inDragging0 = 997,
		Beyond-UI-UIDragItem-get_panel0 = 998,
		Beyond-UI-UIDragItem-get_dragObjectParent0 = 999,
		Beyond-UI-UIDragItem-set_dragObjectParent0 = 1000,
		Beyond-UI-UIDragItem-get_m_dragParentRect0 = 1001,
		Beyond-UI-UIDragItem-get_curDragObj0 = 1002,
		Beyond-UI-UIDragItem-Awake0 = 1003,
		Beyond-UI-UIDragItem-Start0 = 1004,
		Beyond-UI-UIDragItem-OnDisable0 = 1005,
		Beyond-UI-UIDragItem-OnEndDrag0 = 1006,
		Beyond-UI-UIDragItem-_StopDragView0 = 1007,
		Beyond-UI-UIDragItem-_ContinueDragOnDisable0 = 1008,
		Beyond-UI-UIDragItem-OnDrag0 = 1012,
		Beyond-UI-UIDragItem-OnDestroy0 = 1017,
		Beyond-UI-UIDragItem-ClearComponent0 = 1018,
		Beyond-UI-UIDragItem-ClearEvents0 = 1021,
		Beyond-UI-UIDragItem-OnEnable0 = 1022,
		Beyond-UI-UIDragItem-OnBeginDrag0 = 1023,
		Beyond-UI-UIDropdown-get_panel0 = 1024,
		Beyond-UI-UIDropdown-Awake0 = 1025,
		Beyond-UI-UIDropdown-_InitBinding0 = 1026,
		Beyond-UI-UIDropdown-_GetDefaultNaviTarget0 = 1029,
		Beyond-UI-UIDropdown-_ControllerToggle0 = 1031,
		Beyond-UI-UIDropdown-_ToggleOptions0 = 1033,
		Beyond-UI-UISelectableNaviGroup-ManuallyFocus0 = 1037,
		Beyond-UI-UISelectableNaviGroup-_OnFocus0 = 1038,
		Beyond-UI-UIDropdown-_ControllerCancel0 = 1040,
		Beyond-UI-UISelectableNaviGroup-ManuallyStopFocus0 = 1041,
		Beyond-UI-UISelectableNaviGroup-_OnStopFocus0 = 1042,
		Beyond-UI-UIDropdown-ToggleOptions0 = 1043,
		Beyond-UI-UIDropdown-_NotifyIsHover0 = 1044,
		Beyond-UI-UIDropdown-OnPointerClick0 = 1045,
		Beyond-UI-UIDropdown-Init0 = 1046,
		Beyond-UI-UIDropdown-Update0 = 1047,
		Beyond-UI-UIDropdown-_GetUICamera0 = 1048,
		Beyond-UI-UIDropdown-SetSelected0 = 1049,
		Beyond-UI-UIDropdown-ScrollToSelected0 = 1052,
		Beyond-UI-UIScrollRect-AutoScrollToRectTransform0 = 1053,
		Beyond-UI-UIScrollRect-_GetUICamera0 = 1054,
		Beyond-UI-UIScrollRect-get_panel0 = 1055,
		Beyond-UI-UIScrollRect-ScrollTo0 = 1056,
		Beyond-UI-UIScrollRect-KillScrollTween0 = 1057,
		Beyond-UI-UIDropdown-Refresh0 = 1058,
		Beyond-UI-UIDropdown-ClearComponent0 = 1062,
		Beyond-UI-UIDropdown-get_groupId0 = 1063,
		Beyond-UI-UIDropdown-get_groupEnabled0 = 1064,
		Beyond-UI-UIDropdown-get_bindingViewActionId0 = 1065,
		Beyond-UI-UIDropdown-get_bindingViewLabelText0 = 1066,
		Beyond-UI-UIDropdown-get_redDotTrans0 = 1067,
		Beyond-UI-UIDropdown-get_bindingEnabled0 = 1068,
		Beyond-UI-UIDropdown-get_bindingViewState0 = 1069,
		Beyond-UI-UIDropdown-GetBindingViewActionId0 = 1070,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyDown0 = 1071,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyUp0 = 1072,
		Beyond-UI-UIDropdown-OnEnable0 = 1073,
		Beyond-UI-UIDropdown-OnDisable0 = 1074,
		Beyond-UI-UIDropdown-OnDestroy0 = 1075,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.get_interactable0 = 1076,
		Beyond-UI-UIDropdownOption-SetText0 = 1077,
		Beyond-UI-UIDropdownOption-SetState0 = 1078,
		Beyond-UI-UIState-UIStateController-SetState0 = 1079,
		Beyond-UI-UIState-StateReference-SetController0 = 1082,
		Beyond-UI-UIState-UIStateController-_ApplyState0 = 1083,
		Beyond-UI-UIState-StateDescription-get_IsEmpty0 = 1084,
		Beyond-UI-UIState-StateDescription-ApplyGameObject0 = 1085,
		Beyond-UI-UIState-StateDescription-ApplyComponent0 = 1086,
		Beyond-UI-UIState-StateDescription-ApplyGraphic0 = 1087,
		Beyond-UI-UIState-StateDescription-ApplyRectTransform0 = 1088,
		Beyond-UI-UIState-UIStateControllerUtils-SetTop0 = 1089,
		Beyond-UI-UIState-UIStateControllerUtils-SetBottom0 = 1090,
		Beyond-UI-UIState-UIStateControllerUtils-SetLeft0 = 1091,
		Beyond-UI-UIState-UIStateControllerUtils-SetRight0 = 1092,
		Beyond-UI-UIState-UIStateControllerUtils-ForceRebuildLayout0 = 1093,
		Beyond-UI-UIState-StateDescription-ApplyImage0 = 1094,
		Beyond-UI-UIState-StateDescription-ApplyText0 = 1097,
		Beyond-UI-UIState-StateDescription-ApplyCanvasGroup0 = 1098,
		Beyond-UI-UIState-StateDescription-ApplyButton0 = 1099,
		Beyond-UI-UIState-StateDescription-ApplyAnimator0 = 1100,
		Beyond-UI-UIState-StateDescription-ApplyLayoutElement0 = 1101,
		Beyond-UI-UIState-StateDescription-ApplyInnerState0 = 1102,
		Beyond-UI-UIState-StateDescription-ApplyAnimation0 = 1103,
		Beyond-UI-UIState-StateReference-ScheduleForPlaying0 = 1104,
		Beyond-UI-UIState-UIStateController-OnStateReferenceDirty0 = 1105,
		Beyond-UI-UIState-UIStateControllerUtils-StartEditorUpdateLoop0 = 1106,
		Beyond-UI-UIState-StateAnimationInfo-OnUpdate0 = 1107,
		Beyond-UI-UIState-StateReference-ScheduleForStopping0 = 1114,
		Beyond-UI-UIState-StateDescription-ApplyLayoutGroup0 = 1115,
		Beyond-UI-UIState-StateDescription-ApplyScrollList0 = 1116,
		Beyond-UI-UIScrollList-SetPadding0 = 1117,
		Beyond-UI-UIScrollList-UpdateContainerSize0 = 1118,
		Beyond-UI-UIScrollList-GetLeftLength0 = 1119,
		Beyond-UI-UIScrollList-_SetRealPadding0 = 1120,
		Beyond-UI-UIScrollList-SetContainerSize0 = 1122,
		Beyond-UI-UIScrollList-GetContainerSize0 = 1123,
		Beyond-UI-UIScrollList-SetSpace0 = 1124,
		Beyond-UI-UIState-StateDescription-ApplyGridLayoutGroup0 = 1125,
		Beyond-UI-UIState-StateDescription-ApplySelectable0 = 1126,
		Beyond-UI-UIDropItem-ClearEvents0 = 1127,
		Beyond-UI-UIDropItem-Awake0 = 1128,
		Beyond-UI-UIDropItem-OnEnable0 = 1129,
		Beyond-UI-UIDropItem-ToggleHighlight0 = 1130,
		Beyond-UI-UIDropItem-OnDisable0 = 1131,
		Beyond-UI-UIDropItem-OnDestroy0 = 1132,
		Beyond-UI-UIDropItem-ClearComponent0 = 1134,
		Beyond-UI-UIDropItem-OnDrop0 = 1135,
		Beyond-UI-UIElementFollower-get_tickOption0 = 1136,
		Beyond-UI-UIElementFollower-get_followPosition0 = 1137,
		Beyond-UI-UIElementFollower-set_followPosition0 = 1138,
		Beyond-UI-UIElementFollower-UpdatePosition1 = 1139,
		Beyond-UI-UIElementFollower-get_panel0 = 1140,
		Beyond-UI-UIElementFollower-UpdatePosition0 = 1141,
		Beyond-UI-UIElementFollower-get_targetTransform0 = 1144,
		Beyond-UI-UIElementFollower-set_targetTransform0 = 1145,
		Beyond-UI-UIElementFollower-OnAwake0 = 1146,
		Beyond-UI-UIElementFollower-OnEnable0 = 1147,
		Beyond-UI-UIElementFollower-LateTick0 = 1148,
		Beyond-UI-UIExtendScrollRect-OnScroll0 = 1149,
		Beyond-UI-UIExtendScrollRect-OnBeginDrag0 = 1150,
		Beyond-UI-UIScrollList-OnBeginDrag0 = 1151,
		Beyond-UI-UIExtendScrollRect-OnDrag0 = 1152,
		Beyond-UI-UIScrollList-OnDrag0 = 1153,
		Beyond-UI-UIExtendScrollRect-OnEndDrag0 = 1154,
		Beyond-UI-UIScrollList-OnEndDrag0 = 1155,
		Beyond-UI-UIFoldoutComponent-Refresh0 = 1156,
		Beyond-UI-UIFoldoutComponent-get_defaultFoldOut0 = 1157,
		Beyond-UI-UIFoldoutComponent-OnFoldOut0 = 1158,
		Beyond-UI-UINonUnifiedScrollList-NotifyCellSizeChange0 = 1162,
		Beyond-UI-UIFoldoutComponent-OnFoldIn0 = 1163,
		Beyond-UI-UIFoldoutComponent-OnDestroy0 = 1167,
		Beyond-UI-UIGraphicAnimation-get_tickOption0 = 1168,
		Beyond-UI-UIGraphicAnimation-get_MaterialInstance0 = 1169,
		Beyond-UI-UIGraphicAnimation-OnAwake0 = 1170,
		Beyond-UI-UIGraphicAnimation-_Init0 = 1171,
		Beyond-UI-UIGraphicAnimation-OnRelease0 = 1172,
		Beyond-UI-UIGraphicAnimation-LateTick0 = 1173,
		Beyond-UI-UIGridLayoutNaviWrapper-_InitIfNot0 = 1174,
		Beyond-UI-UIGridLayoutNaviWrapper-Start0 = 1175,
		Beyond-UI-UIGridLayoutNaviWrapper-_InitWrapNavigation0 = 1176,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayout0 = 1177,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutImpl0 = 1178,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviChildren0 = 1179,
		Beyond-UI-UIGridLayoutNaviWrapper-_SetCircleWrapScroll0 = 1180,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutInit0 = 1181,
		Beyond-UI-UIGridLayoutNaviWrapper-_FindValidSelectable0 = 1182,
		Beyond-UI-UIScrollRect-WrapNavigation0 = 1183,
		Beyond-UI-UIScrollRect-RectWrapNavigate0 = 1184,
		Beyond-UI-UIGridLayoutNaviWrapper-TryWrapNavigate0 = 1185,
		Beyond-UI-UIGroupScrollList-get_totalCellCount0 = 1186,
		Beyond-UI-UIGroupScrollList-_BuildGroupLayout0 = 1187,
		Beyond-UI-UIGroupScrollList-_RefreshAllGroupTitleSizes0 = 1188,
		Beyond-UI-UIGroupScrollList-_EnsureGroupTitleSizeCacheCount0 = 1189,
		Beyond-UI-UIGroupScrollList-_GetDefaultGroupTitleSize0 = 1190,
		Beyond-UI-UIGroupScrollList-_RefreshGroupTitleSizeWithoutEnsure0 = 1191,
		Beyond-UI-UIGroupScrollList-_CalcGroupTitleSize0 = 1192,
		Beyond-UI-UIGroupScrollList-_RefreshGroupTitleSize0 = 1193,
		Beyond-UI-UIGroupScrollList-_GetGroupTitleSize0 = 1194,
		Beyond-UI-UIGroupScrollList-_GetRowInfo0 = 1195,
		Beyond-UI-UIGroupScrollList-_GetRowHeight0 = 1196,
		Beyond-UI-UIGroupScrollList-_GetCumulativeSizeBeforeRow0 = 1197,
		Beyond-UI-UIGroupScrollList-_GetRowForCell0 = 1198,
		Beyond-UI-UIGroupScrollList-_GetCellIndexForGroupCell0 = 1199,
		Beyond-UI-UIGroupScrollList-_GetGroupAndCellFromCellIndex0 = 1200,
		Beyond-UI-UIGroupScrollList-_GetGroupCellIndexRange0 = 1201,
		Beyond-UI-UIGroupScrollList-_GetGroupRangeFromScrollOffset0 = 1202,
		Beyond-UI-UIGroupScrollList-_GetGroupRangeFromCellIndexRange0 = 1203,
		Beyond-UI-UIGroupScrollList-_MergeGroupRange0 = 1204,
		Beyond-UI-UIGroupScrollList-_GetScrollInfo0 = 1205,
		Beyond-UI-UIGroupScrollList-SyncViewSize0 = 1206,
		Beyond-UI-UIScrollList-SyncViewSize0 = 1207,
		Beyond-UI-UIScrollList-CalcSomeCountNum0 = 1208,
		Beyond-UI-UIScrollList-_GetLineCount0 = 1209,
		Beyond-UI-UIGroupScrollList-InGameAwake0 = 1210,
		Beyond-UI-UIScrollList-InGameAwake0 = 1211,
		Beyond-UI-UIScrollList-InitBasicInfo0 = 1212,
		Beyond-UI-UIScrollList-_InitAutoScroll0 = 1213,
		Beyond-UI-UIScrollList-_OnEnterAutoScrollUp0 = 1214,
		Beyond-UI-UIScrollList-_SetAutoScrollSpd0 = 1216,
		Beyond-UI-UIScrollList-_OnExitAutoScrollUp0 = 1217,
		Beyond-UI-UIScrollList-_OnEnterAutoScrollDown0 = 1218,
		Beyond-UI-UIScrollList-_OnExitAutoScrollDown0 = 1220,
		Beyond-UI-UIScrollList-_InitNavigation0 = 1221,
		Beyond-UI-UIScrollList-NavigateSelected0 = 1223,
		Beyond-UI-UIScrollList-get_curSelectedIndex0 = 1224,
		Beyond-UI-UIScrollList-SetSelectedIndex0 = 1225,
		Beyond-UI-UIScrollList-get_curSelectedObj0 = 1226,
		Beyond-UI-UIScrollList-Get0 = 1227,
		Beyond-UI-UIScrollList-set_curSelectedIndex0 = 1228,
		Beyond-UI-UIScrollList-GetCell1 = 1229,
		Beyond-UI-UIScrollList-ScrollToIndex0 = 1230,
		Beyond-UI-UIScrollList-SkipGraduallyShow0 = 1231,
		Beyond-UI-UIScrollList-StopGraduallyShow0 = 1232,
		Beyond-UI-UIScrollList-get_panel0 = 1233,
		Beyond-UI-UIScrollList-ScrollTo0 = 1234,
		Beyond-UI-UIScrollList-GetTargetPosByIndex0 = 1235,
		Beyond-UI-UIScrollList-_ScrollToPos0 = 1236,
		Beyond-UI-UIScrollList-TryClearAdjustTween0 = 1237,
		Beyond-UI-UIScrollList-RestartGraduallyShow0 = 1244,
		Beyond-UI-UIScrollList-StartGraduallyShow0 = 1245,
		Beyond-UI-UIScrollList-get_currentStep0 = 1246,
		Beyond-UI-UIScrollList-GetNaviNewIndex0 = 1247,
		Beyond-UI-UIScrollList-GetNaviOffset0 = 1248,
		Beyond-UI-UIScrollList-_InitControllerNavi0 = 1256,
		Beyond-UI-UIScrollList-ListWrapNavigate0 = 1257,
		Beyond-UI-UIScrollList-TryResolveWrapDirection0 = 1258,
		Beyond-UI-UIScrollList-TryGetCurrentFocusedCell0 = 1259,
		Beyond-UI-UIScrollList-TryNavigateInsideCell0 = 1260,
		Beyond-UI-UIScrollList-TryGetWrapTargetIndex0 = 1261,
		Beyond-UI-UIScrollList-TrySetNaviTargetByIndex0 = 1262,
		Beyond-UI-UIScrollList-TryGetSelectableFromCell0 = 1263,
		Beyond-UI-UIScrollList-TryNormalizeFirstWrapIndex0 = 1264,
		Beyond-UI-UIScrollList-TryNavigateBySequentialIndex0 = 1265,
		Beyond-UI-UIGroupScrollList-UpdateCount0 = 1266,
		Beyond-UI-UIGroupScrollList-UpdateCount1 = 1267,
		Beyond-UI-UIGroupScrollList-UpdateGroup2 = 1268,
		Beyond-UI-UIGroupScrollList-UpdateGroup1 = 1269,
		Beyond-UI-UIGroupScrollList-UpdateGroup0 = 1270,
		Beyond-UI-UIScrollList-InitConfig0 = 1271,
		Beyond-UI-UIScrollList-UpdateCount0 = 1272,
		Beyond-UI-UIScrollList-_ClearRelatedNaviGroup0 = 1274,
		Beyond-UI-UIScrollRect-get_naviGroup0 = 1275,
		Beyond-UI-UISelectableNaviGroup-ClearLastFocusNaviTarget0 = 1276,
		Beyond-UI-UIGroupScrollList-UpdateSingleGroup0 = 1277,
		Beyond-UI-UIGroupScrollList-_RemapShowingCellIndicesAfterGroupResize0 = 1278,
		Beyond-UI-UIGroupScrollList-_GetGroupStartCellIndex0 = 1279,
		Beyond-UI-UIGroupScrollList-NotifyGroupTitleSizeChange0 = 1280,
		Beyond-UI-UIGroupScrollList-AppendCellToGroup0 = 1281,
		Beyond-UI-UIGroupScrollList-RemoveLastCellFromGroup0 = 1282,
		Beyond-UI-UIGroupScrollList-_GetScrollTargetRow0 = 1283,
		Beyond-UI-UIGroupScrollList-_ScrollToRow0 = 1284,
		Beyond-UI-UIGroupScrollList-_ScrollToGroup0 = 1285,
		Beyond-UI-UIGroupScrollList-ScrollToGroup0 = 1286,
		Beyond-UI-UIGroupScrollList-ScrollToIndex1 = 1287,
		Beyond-UI-UIGroupScrollList-ScrollToIndex0 = 1288,
		Beyond-UI-UIGroupScrollList-GetGroupRangeInView0 = 1289,
		Beyond-UI-UIGroupScrollList-get_isMultiPage0 = 1290,
		Beyond-UI-UIGroupScrollList-_RefreshIsMultiPage0 = 1291,
		Beyond-UI-UIGroupScrollList-UpdateContainerSize0 = 1292,
		Beyond-UI-UIGroupScrollList-GetContainerSize0 = 1293,
		Beyond-UI-UIGroupScrollList-GetIndexRangeFromScrollOffset0 = 1294,
		Beyond-UI-UIGroupScrollList-_IsGroupInCellRange0 = 1295,
		Beyond-UI-UIGroupScrollList-_MoveTitleTo0 = 1296,
		Beyond-UI-UIGroupScrollList-_MoveCellTo0 = 1297,
		Beyond-UI-UIGroupScrollList-MoveCellTo0 = 1298,
		Beyond-UI-UIGroupScrollList-GetTargetPosByIndex0 = 1299,
		Beyond-UI-UIGroupScrollList-_GetTitleCell0 = 1300,
		Beyond-UI-UIGroupScrollList-_CacheTitleCell0 = 1301,
		Beyond-UI-UIGroupScrollList-_GetGroupBGCell0 = 1302,
		Beyond-UI-UIGroupScrollList-_CacheGroupBGCell0 = 1303,
		Beyond-UI-UIGroupScrollList-_GetGroupLength0 = 1304,
		Beyond-UI-UIGroupScrollList-_MoveGroupBGTo0 = 1305,
		Beyond-UI-UIGroupScrollList-_UpdateGroupBGByRange0 = 1306,
		Beyond-UI-UIGroupScrollList-UpdateShowingCells0 = 1307,
		Beyond-UI-UIGroupScrollList-_UpdateTitleOrCell0 = 1308,
		Beyond-UI-UIGroupScrollList-_OnUpdateTitleOrCell0 = 1309,
		Beyond-UI-UIGroupScrollList-CacheOutOfRangeCells0 = 1310,
		Beyond-UI-UIGroupScrollList-ProcessCellAtIndex0 = 1311,
		Beyond-UI-UIGroupScrollList-RepositionOutOfRangeCells0 = 1312,
		Beyond-UI-UIGroupScrollList-_UpdateShowingCellsForGroup0 = 1313,
		Beyond-UI-UIGroupScrollList-TryResolveWrapDirection0 = 1314,
		Beyond-UI-UIGroupScrollList-TryGetWrapTargetIndex0 = 1315,
		Beyond-UI-UIGroupScrollList-_CellsInGroupRow0 = 1316,
		Beyond-UI-UIGroupScrollList-ClearShowingCells0 = 1317,
		Beyond-UI-UIGroupScrollList-ClearComponent0 = 1318,
		Beyond-UI-UIScrollList-ClearComponent0 = 1319,
		Beyond-UI-UIGroupScrollList-Get1 = 1320,
		Beyond-UI-UIGroupScrollList-Get0 = 1321,
		Beyond-UI-UIGroupScrollList-GetGroupTitle0 = 1322,
		Beyond-UI-UIGroupScrollList-SetCellCanCache1 = 1323,
		Beyond-UI-UIGroupScrollList-SetCellCanCache0 = 1324,
		Beyond-UI-UIGroupScrollList-DebugDumpLayoutToConsoleAndClipboard0 = 1325,
		Beyond-UI-UIGroupScrollList-_BuildLayoutDebugDumpText0 = 1326,
		Beyond-UI-UIGyroscopeEffect-get_tickOption0 = 1327,
		Beyond-UI-UIGyroscopeEffect-OnAwake0 = 1328,
		Beyond-UI-UIGyroscopeEffect-Tick0 = 1329,
		Beyond-UI-UIGyroscopeEffect-OnRelease0 = 1332,
		Beyond-UI-UIHighlightMask-get_tickOption0 = 1333,
		Beyond-UI-UIHighlightMask-get_panel0 = 1334,
		Beyond-UI-UIHighlightMask-OnAwake0 = 1335,
		Beyond-UI-UIHighlightMask-OnEnable0 = 1336,
		Beyond-UI-UIHighlightMask-TrySyncRect0 = 1337,
		Beyond-UI-UIHighlightMask-Tick0 = 1338,
		Beyond-UI-UIImage-get_packIntoRuntimeAtlas0 = 1339,
		Beyond-UI-UIImage-set_packIntoRuntimeAtlas0 = 1340,
		Beyond-UI-UIImage-get_atlasHandleId0 = 1341,
		Beyond-UI-UIImage-set_atlasHandleId0 = 1342,
		Beyond-UI-UIImage-get_panel0 = 1343,
		Beyond-UI-UIImage-get_atlasHandle0 = 1344,
		Beyond-UI-UIImage-get_panelLevel0 = 1345,
		Beyond-UI-UIImage-RegisterOnEnableRuntimeAtlas0 = 1346,
		Beyond-UI-UIImage-UnregisterOnEnableRuntimeAtlas0 = 1347,
		Beyond-UI-UIImage-OnEnableRuntimeAtlas0 = 1348,
		Beyond-UI-UIImage-get_color0 = 1349,
		Beyond-UI-UIImage-set_color0 = 1350,
		Beyond-UI-UIImage-_OnSpriteChanged0 = 1351,
		Beyond-UI-UIAtlasManager-get_enableRuntimeAtlas0 = 1352,
		Beyond-UI-UIAtlasManager-ReProcessInsertForUIImage0 = 1354,
		Beyond-UI-UIAtlasManager-_ReProcessInsertForUIImage0 = 1355,
		Beyond-UI-UIAtlasManager-UIAtlasHandle-CreateInvalidHandle0 = 1356,
		Beyond-UI-UIImage-OnPopulateMeshFallback0 = 1357,
		Beyond-UI-UIImage-Awake0 = 1358,
		Beyond-UI-UIAtlasManager-AddUIImageToManagerOnInstantiate0 = 1359,
		Beyond-UI-UIAtlasManager-_AddUIImageToManagerOnInstantiate0 = 1360,
		Beyond-UI-UIAtlasManager-get_releaseImageSpriteAfterInsert0 = 1361,
		Beyond-UI-UIImage-OnEnable0 = 1363,
		Beyond-UI-UIAtlasManager-AddUIImageToManager0 = 1365,
		Beyond-UI-UIAtlasManager-_AddUIImageToManager0 = 1366,
		Beyond-UI-UIImage-OnDisable0 = 1367,
		Beyond-UI-UIImage-OnDestroy0 = 1368,
		Beyond-UI-UIAtlasManager-RemoveUIImageFromManager0 = 1369,
		Beyond-UI-UIAtlasManager-_RemoveUIImageFromManager0 = 1370,
		Beyond-UI-UIImage-SetNativeSize0 = 1371,
		Beyond-UI-UIImage-SetNativeSizeIgnoreRefScale0 = 1372,
		Beyond-UI-UIImage-LoadSprite1 = 1373,
		Beyond-UI-UIImage-LoadMaterial0 = 1374,
		Beyond-UI-UIImage-ReleaseSprite0 = 1375,
		Beyond-UI-UIImage-get_mainTexture0 = 1376,
		Beyond-UI-UIImage-_V2AtlasInitialize0 = 1377,
		Beyond-UI-UIImageBlur-get_tickOption0 = 1379,
		Beyond-UI-UIImageBlur-OnAwake0 = 1380,
		Beyond-UI-UIImageBlur-OnChangeSprite0 = 1381,
		Beyond-UI-UIImageBlur-Tick0 = 1382,
		Beyond-UI-UIImageBlur-OnDisable0 = 1383,
		Beyond-UI-UIImageBlur-OnRelease0 = 1384,
		Beyond-UI-UIImageFillAmountOffset-get_fillAmount0 = 1385,
		Beyond-UI-UIImageFillAmountOffset-set_fillAmount0 = 1386,
		Beyond-UI-UIImageFillAmountOffset-DOFillAmount0 = 1387,
		Beyond-UI-UIImageFillFollower-get_tickOption0 = 1390,
		Beyond-UI-UIImageFillFollower-OnAwake0 = 1391,
		Beyond-UI-UIImageFillFollower-OnEnable0 = 1392,
		Beyond-UI-UIImageFillFollower-Tick0 = 1393,
		Beyond-UI-UIImageFillFollower-RefreshFillAmount0 = 1394,
		Beyond-UI-UIImageFillTailFollower-get_tickOption0 = 1395,
		Beyond-UI-UIImageFillTailFollower-OnAwake0 = 1396,
		Beyond-UI-UIImageFillTailFollower-OnEnable0 = 1397,
		Beyond-UI-UIImageFillTailFollower-RefreshFollower0 = 1398,
		Beyond-UI-UIImageFillTailFollower-Tick0 = 1399,
		Beyond-UI-UIImagePair-LoadSprite1 = 1400,
		Beyond-UI-UIImagePair-LoadSprite0 = 1401,
		Beyond-UI-UIImagePair-set_color0 = 1402,
		Beyond-UI-UIImagePair-get_first0 = 1403,
		Beyond-UI-UIInertiaViewPager-get_tickOption0 = 1404,
		Beyond-UI-UIInertiaViewPager-_PlayAudioGear0 = 1405,
		Beyond-UI-UIInertiaViewPager-_PlayAudioGearLock0 = 1406,
		Beyond-UI-UIInertiaViewPager-_InitIfNot0 = 1407,
		Beyond-UI-UIInertiaViewPager-get_currentPage0 = 1408,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-Reset0 = 1409,
		Beyond-UI-UIInertiaViewPager-ScrollEffectConfig-IsEmpty0 = 1410,
		Beyond-UI-UIInertiaViewPager-get_isUpdating0 = 1411,
		Beyond-UI-UIInertiaViewPager-set_currentPage0 = 1412,
		Beyond-UI-UIInertiaViewPager-_SwitchToPage0 = 1413,
		Beyond-UI-UIInertiaViewPager-_ScrollValue2PageIndex0 = 1414,
		Beyond-UI-UIInertiaViewPager-_PageIndex2ScrollValue0 = 1416,
		Beyond-UI-UIInertiaViewPager-get_currentScrollIndex0 = 1417,
		Beyond-UI-UIInertiaViewPager-ClearComponent0 = 1418,
		Beyond-UI-UIInertiaViewPager-Tick0 = 1419,
		Beyond-UI-UIInertiaViewPager-DragContext-BeginDrag0 = 1420,
		Beyond-UI-UIInertiaViewPager-DragContext-EndDrag0 = 1421,
		Beyond-UI-UIInertiaViewPager-DragContext-_TryFlingToNext0 = 1422,
		Beyond-UI-UIInertiaViewPager-_ScrollValueAlignToPage0 = 1423,
		Beyond-UI-UIInertiaViewPager-BlockerManager-StartInertia0 = 1425,
		Beyond-UI-UIInertiaViewPager-BlockerManager-HitInertiaBlock0 = 1427,
		Beyond-UI-UIInertiaViewPager-InertiaBlocker-IsDirMatch0 = 1428,
		Beyond-UI-UIInertiaViewPager-_AutoAlign0 = 1429,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyScrolling0 = 1430,
		Beyond-UI-UIInertiaViewPager-_OnStateChanged0 = 1431,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyAlignFinish0 = 1432,
		Beyond-UI-UIInertiaViewPager-SetPageCount0 = 1433,
		Beyond-UI-UIInertiaViewPager-BlockerManager-Init0 = 1435,
		Beyond-UI-UIInertiaViewPager-MoveToPage0 = 1436,
		Beyond-UI-UIInertiaViewPager-OnAwake0 = 1437,
		Beyond-UI-UIInertiaViewPager-OnEnable0 = 1438,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-OnClear0 = 1439,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollBegin0 = 1440,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollEnd0 = 1441,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_velocity0 = 1442,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_scrollProgress0 = 1443,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-set_scrollProgress0 = 1444,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_isDragging0 = 1445,
		Beyond-UI-UIScrollRect-get_dragging0 = 1446,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-StopMoving0 = 1447,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-get_velocity0 = 1448,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-get_isDragging0 = 1449,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-get_scrollProgress0 = 1450,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-set_scrollProgress0 = 1451,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-StopMoving0 = 1452,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-OnClear0 = 1453,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-MarkHasScrolled0 = 1454,
		Beyond-UI-UIInputField-get_panel0 = 1455,
		Beyond-UI-UIInputField-get_isControllerInputValid0 = 1456,
		Beyond-UI-UIInputField-SendOnFocus0 = 1459,
		Beyond-UI-UIInputField-SendOnFocusLost0 = 1460,
		Beyond-UI-UIInputField-Awake0 = 1461,
		Beyond-UI-UIInputField-_VirtualKeyboardAwake0 = 1465,
		Beyond-UI-UIInputField-_VirtualKeyboardInitJavaObj0 = 1466,
		Beyond-UI-UIInputField-OnSelect0 = 1467,
		Beyond-UI-UIInputField-_VirtualKeyboardSelect0 = 1468,
		Beyond-UI-UIInputField-OnDeselect0 = 1469,
		Beyond-UI-UIInputField-_VirtualKeyboardDeselect0 = 1470,
		Beyond-UI-UIInputField-OnUpdateSelected0 = 1471,
		Beyond-UI-UIInputField-ActivateInputField0 = 1472,
		Beyond-UI-UIInputField-set_s_focusedInputField0 = 1473,
		Beyond-UI-UIInputField-TryActivateInputFieldCustom0 = 1474,
		Beyond-UI-UIInputField-_OnCloudGameKeyboardComplete0 = 1475,
		Beyond-UI-UIInputField-DeactivateInputField0 = 1476,
		Beyond-UI-UIInputField-_UpdateBindingEnable0 = 1477,
		Beyond-UI-UIInputField-get_s_focusedInputField0 = 1478,
		Beyond-UI-UIInputField-OnDestroy0 = 1479,
		Beyond-UI-UIInputField-ClearComponent0 = 1480,
		Beyond-UI-UIInputField-_VirtualKeyboardOnDestroy0 = 1481,
		Beyond-UI-UIInputField-OnEnable0 = 1482,
		Beyond-UI-UIInputField-OnDisable0 = 1483,
		Beyond-UI-UIInputField-_NotifyIsHover0 = 1484,
		Beyond-UI-UIInputField-OnInteractableChanged0 = 1485,
		Beyond-UI-UIInputField-_GetCamera0 = 1486,
		Beyond-UI-UIInputField-_UpdateKeyboardOffset0 = 1487,
		Beyond-UI-UIInputField-_CleanupAndroidObjects0 = 1488,
		Beyond-UI-UIInputField-_KeyboardHeightChange0 = 1489,
		Beyond-UI-UIJoystick-get_panel0 = 1496,
		Beyond-UI-UIJoystick-get_isDynamic0 = 1497,
		Beyond-UI-UIJoystick-set_isDynamic0 = 1498,
		Beyond-UI-UIJoystick-_ChangeDynamic0 = 1499,
		Beyond-UI-UIJoystick-_SetVisible0 = 1500,
		Beyond-UI-UIJoystick-_SetRectTransform0 = 1501,
		Beyond-UI-UIJoystick-get_walkRation0 = 1502,
		Beyond-UI-UIJoystick-set_walkRation0 = 1503,
		Beyond-UI-UIJoystick-_UpdateWalkBgScale0 = 1504,
		Beyond-UI-UIJoystick-get_active0 = 1505,
		Beyond-UI-UIJoystick-get_activeTouchId0 = 1506,
		Beyond-UI-UIJoystick-get_m_thumbPosMaxLength0 = 1507,
		Beyond-UI-UIJoystick-Reset0 = 1508,
		Beyond-UI-UIJoystick-Awake0 = 1509,
		Beyond-UI-UIJoystick-InitBinding0 = 1510,
		Beyond-UI-UIJoystick-_UpdateState0 = 1513,
		Beyond-UI-UIJoystick-OnPointerDown0 = 1514,
		Beyond-UI-UIJoystick-get_shouldCheckInput0 = 1515,
		Beyond-UI-UIJoystick-get_groupEnabled0 = 1516,
		Beyond-UI-UIJoystick-_Activate0 = 1517,
		Beyond-UI-UIJoystick-_UpdateGait0 = 1519,
		Beyond-UI-UIJoystick-_UpdateIndicator0 = 1521,
		Beyond-UI-UIJoystick-_UpdateBg0 = 1522,
		Beyond-UI-UIJoystick-_SetWalkBgVisible0 = 1523,
		Beyond-UI-UIJoystick-_SetRunBgVisible0 = 1524,
		Beyond-UI-UIJoystick-OnPointerUp0 = 1525,
		Beyond-UI-UIJoystick-OnBeginDrag0 = 1526,
		Beyond-UI-UIJoystick-OnDrag0 = 1528,
		Beyond-UI-UIJoystick-_OnHudLayoutLoaded0 = 1530,
		Beyond-UI-UIJoystick-OnEnable0 = 1531,
		Beyond-UI-UIJoystick-_Tick0 = 1532,
		Beyond-UI-UIJoystick-Start0 = 1533,
		Beyond-UI-UIJoystick-OnDestroy0 = 1534,
		Beyond-UI-UIJoystick-get_groupId0 = 1535,
		Beyond-UI-UIJoystick-ClearComponent0 = 1536,
		Beyond-UI-UIJoystick-OnDisable0 = 1537,
		Beyond-UI-UIJoystick-CheckShouldActive0 = 1538,
		Beyond-UI-UIJoystick-get_parentTarget0 = 1539,
		Beyond-UI-UILayoutDimensionListener-GraphicUpdateComplete0 = 1540,
		Beyond-UI-UILayoutDimensionListener-LayoutComplete0 = 1541,
		Beyond-UI-UILayoutDimensionListener-Rebuild0 = 1542,
		Beyond-UI-UILayoutDimensionListener-_NextFrameCoroutine0 = 1543,
		Beyond-UI-UILayoutDimensionListener-_InvokePostLayoutCallback0 = 1547,
		Beyond-UI-UILayoutDimensionListener-DoOnceOnPostLayout0 = 1551,
		Beyond-UI-UILayoutDimensionListener-OnEnable0 = 1552,
		Beyond-UI-UILayoutDimensionListener-_SetDirty0 = 1553,
		Beyond-UI-UILayoutDimensionListener-OnRectTransformDimensionsChange0 = 1554,
		Beyond-UI-UILayoutDimensionListener-OnDestroy0 = 1555,
		Beyond-UI-UILayoutDimensionListener-UnityEngine.UI.ICanvasElement.get_transform0 = 1556,
		Beyond-UI-UILeftSubtitle-get_tickOption0 = 1557,
		Beyond-UI-UILeftSubtitle-Tick0 = 1558,
		Beyond-UI-UILeftSubtitle-UpdateByPlayTime0 = 1559,
		Beyond-UI-UILeftSubtitle-Exit0 = 1560,
		Beyond-UI-UILeftSubtitle-SetVisible0 = 1562,
		Beyond-UI-UILeftSubtitle-StartAutoPlay0 = 1563,
		Beyond-UI-UILeftSubtitle-SetLeftSubTitle0 = 1564,
		Beyond-UI-UIMaterialAnimation-get_tickOption0 = 1565,
		Beyond-UI-UIMaterialAnimation-LateTick0 = 1566,
		Beyond-UI-UIMaterialAnimation-_TryUpdate0 = 1567,
		Beyond-UI-UIMaterialAnimation-_ResetSetCache0 = 1568,
		Beyond-UI-UIMaterialAnimation-OnAwake0 = 1569,
		Beyond-UI-UIMaterialAnimation-OnRelease0 = 1570,
		Beyond-UI-UIMaterialAnimation-ForceUpdate0 = 1571,
		Beyond-UI-UIMultiSelectDropdown-get_panel0 = 1572,
		Beyond-UI-UIMultiSelectDropdown-Awake0 = 1573,
		Beyond-UI-UIMultiSelectDropdown-_InitBinding0 = 1574,
		Beyond-UI-UIMultiSelectDropdown-_GetDefaultNaviTarget0 = 1577,
		Beyond-UI-UIMultiSelectDropdown-_ControllerToggle0 = 1580,
		Beyond-UI-UIMultiSelectDropdown-_ToggleOptions0 = 1582,
		Beyond-UI-UIMultiSelectDropdown-_ControllerCancel0 = 1586,
		Beyond-UI-UIMultiSelectDropdown-ToggleOptions0 = 1587,
		Beyond-UI-UIMultiSelectDropdown-_NotifyIsHover0 = 1588,
		Beyond-UI-UIMultiSelectDropdown-OnPointerClick0 = 1589,
		Beyond-UI-UIMultiSelectDropdown-Init0 = 1590,
		Beyond-UI-UIMultiSelectDropdown-Update0 = 1591,
		Beyond-UI-UIMultiSelectDropdown-_GetUICamera0 = 1592,
		Beyond-UI-UIMultiSelectDropdown-SetSelected0 = 1593,
		Beyond-UI-UIMultiSelectDropdown-_IsValidIndex0 = 1594,
		Beyond-UI-UIMultiSelectDropdown-_GetLastSelectedIndex0 = 1598,
		Beyond-UI-UIMultiSelectDropdown-SetSelectedList0 = 1599,
		Beyond-UI-UIMultiSelectDropdown-ClearSelected0 = 1600,
		Beyond-UI-UIMultiSelectDropdown-IsSelected0 = 1601,
		Beyond-UI-UIMultiSelectDropdown-GetSelectedIndices0 = 1602,
		Beyond-UI-UIMultiSelectDropdown-GetSelectedStates0 = 1603,
		Beyond-UI-UIMultiSelectDropdown-ScrollToLastSelected0 = 1604,
		Beyond-UI-UIMultiSelectDropdown-ScrollToIndex0 = 1605,
		Beyond-UI-UIMultiSelectDropdown-Refresh1 = 1606,
		Beyond-UI-UIMultiSelectDropdown-Refresh0 = 1607,
		Beyond-UI-UIMultiSelectDropdown-_ResizeSelectedStates0 = 1611,
		Beyond-UI-UIMultiSelectDropdown-ClearComponent0 = 1612,
		Beyond-UI-UIMultiSelectDropdown-get_groupId0 = 1613,
		Beyond-UI-UIMultiSelectDropdown-get_groupEnabled0 = 1614,
		Beyond-UI-UIMultiSelectDropdown-get_bindingViewActionId0 = 1615,
		Beyond-UI-UIMultiSelectDropdown-get_bindingViewLabelText0 = 1616,
		Beyond-UI-UIMultiSelectDropdown-get_redDotTrans0 = 1617,
		Beyond-UI-UIMultiSelectDropdown-get_bindingEnabled0 = 1618,
		Beyond-UI-UIMultiSelectDropdown-get_bindingViewState0 = 1619,
		Beyond-UI-UIMultiSelectDropdown-GetBindingViewActionId0 = 1620,
		Beyond-UI-UIMultiSelectDropdown-Beyond.Input.IBindingView.OnInputKeyDown0 = 1621,
		Beyond-UI-UIMultiSelectDropdown-Beyond.Input.IBindingView.OnInputKeyUp0 = 1622,
		Beyond-UI-UIMultiSelectDropdown-OnEnable0 = 1623,
		Beyond-UI-UIMultiSelectDropdown-OnDisable0 = 1624,
		Beyond-UI-UIMultiSelectDropdown-OnDestroy0 = 1625,
		Beyond-UI-UIMultiSelectDropdown-Beyond.Input.IBindingView.get_interactable0 = 1626,
		Beyond-UI-UINonUnifiedScrollList-InitBasicInfo0 = 1627,
		Beyond-UI-UINonUnifiedScrollList-CalcSomeCountNum0 = 1628,
		Beyond-UI-UINonUnifiedScrollList-GetLeftLength0 = 1629,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount0 = 1630,
		Beyond-UI-UIScrollList-UpdateCount1 = 1631,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount1 = 1632,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount2 = 1633,
		Beyond-UI-UINonUnifiedScrollList-LateTick0 = 1634,
		Beyond-UI-UIScrollList-TryRecalculateSize0 = 1635,
		Beyond-UI-UINonUnifiedScrollList-OnScroll0 = 1636,
		Beyond-UI-UINonUnifiedScrollList-GetGridLayoutSize0 = 1637,
		Beyond-UI-UINonUnifiedScrollList-_GetCellSize0 = 1638,
		Beyond-UI-UINonUnifiedScrollList-GetContainerSize0 = 1639,
		Beyond-UI-UIScrollRect-get_inScrollTween0 = 1640,
		Beyond-UI-UIScrollRect-get_contentStartPosition0 = 1641,
		Beyond-UI-UIScrollRect-set_contentStartPosition0 = 1642,
		Beyond-UI-UINonUnifiedScrollList-GetCenterIndex0 = 1643,
		Beyond-UI-UINonUnifiedScrollList-GetShowRange0 = 1644,
		Beyond-UI-UINonUnifiedScrollList-GetNotCacheRange0 = 1645,
		Beyond-UI-UINonUnifiedScrollList-MoveCellTo0 = 1646,
		Beyond-UI-UINonUnifiedScrollList-_GetCellsSizeTo0 = 1647,
		Beyond-UI-UINonUnifiedScrollList-OnUpdateCell0 = 1648,
		Beyond-UI-UISizeFollower-SyncSize0 = 1649,
		Beyond-UI-UISizeFollower-get_rectTransform0 = 1650,
		Beyond-UI-UINonUnifiedScrollList-GetTargetPosByIndex0 = 1651,
		Beyond-UI-UINonUnifiedScrollList-ScrollTo0 = 1652,
		Beyond-UI-UINonUnifiedScrollList-ClearComponent0 = 1653,
		Beyond-UI-UINonUnifiedScrollList-get_currentStep0 = 1654,
		Beyond-UI-UINonUnifiedScrollList-set_currentStep0 = 1655,
		Beyond-UI-UIScrollList-SetStepTo0 = 1656,
		Beyond-UI-UINonUnifiedScrollList-SetStepTo0 = 1657,
		Beyond-UI-UINonUnifiedScrollList-SetCurrentStep0 = 1658,
		Beyond-UI-UINonUnifiedScrollList-GetScrollBarSize0 = 1659,
		Beyond-UI-UINonUnifiedScrollList-GetLastScrollStep0 = 1661,
		Beyond-UI-UINonUnifiedScrollList-UpdateLastScrollStep0 = 1662,
		Beyond-UI-UINonUnifiedScrollList-GetNormalizedPosition0 = 1663,
		Beyond-UI-UINonUnifiedScrollList-SetNormalizedPosition0 = 1664,
		Beyond-UI-UINonUnifiedScrollList-ToggleByState0 = 1665,
		Beyond-UI-UINonUnifiedScrollList-Toggle0 = 1666,
		Beyond-UI-UINonUnifiedScrollList-FoldAll0 = 1667,
		Beyond-UI-UINonUnifiedScrollRect-_InitIfNot0 = 1668,
		Beyond-UI-UINonUnifiedScrollRect-_OnPostLayout0 = 1669,
		Beyond-UI-UINonUnifiedScrollRect-_UpdateNonUnifiedScrollbars0 = 1670,
		Beyond-UI-UINonUnifiedScrollRect-UpdateScrollbars0 = 1671,
		Beyond-UI-UINonUnifiedScrollRect-Rebuild0 = 1672,
		Beyond-UI-UINonUnifiedScrollRect-SetHorizontalNormalizedPosition0 = 1673,
		Beyond-UI-UINonUnifiedScrollRect-SetVerticalNormalizedPosition0 = 1674,
		Beyond-UI-UINumberScrollTween-get_tickOption0 = 1675,
		Beyond-UI-UINumberScrollTween-get_tweenToText0 = 1676,
		Beyond-UI-UINumberScrollTween-set_tweenToText0 = 1677,
		Beyond-UI-UINumberScrollTween-_TweenToTarget0 = 1678,
		Beyond-UI-UINumberScrollTween-_CleanupBeforeTween0 = 1679,
		Beyond-UI-UINumberScrollTween-get_text0 = 1680,
		Beyond-UI-UINumberScrollTween-set_text0 = 1681,
		Beyond-UI-UINumberScrollTween-Start0 = 1682,
		Beyond-UI-UINumberScrollTween-Tick0 = 1683,
		Beyond-UI-UINumberScrollTween-_HandleNumberScrollTween0 = 1684,
		Beyond-UI-UIPCScaleHelper-OnEnable0 = 1685,
		Beyond-UI-UIRegionBuildingTexManager-get_materialPropertyBlock0 = 1686,
		Beyond-UI-UIRegionBuildingTexManager-OnEnable0 = 1687,
		Beyond-UI-UIRegionBuildingTexManager-_UpdateTexture0 = 1688,
		Beyond-UI-UIRegionBuildingTexManager-OnValidate0 = 1689,
		Beyond-UI-UIRegionBuildingTexManager-OnDisable0 = 1690,
		Beyond-UI-UIScaleHolder-get_tickOption0 = 1691,
		Beyond-UI-UIScaleHolder-OnAwake0 = 1692,
		Beyond-UI-UIScaleHolder-OnEnable0 = 1693,
		Beyond-UI-UIScaleHolder-_HoldScale0 = 1694,
		Beyond-UI-UIScaleHolder-_IsValidScale0 = 1695,
		Beyond-UI-UIScaleHolder-LateTick0 = 1696,
		Beyond-UI-UIScaleHolder-SetExtraScale0 = 1697,
		Beyond-UI-UIScaleHolder-GetExtraScale0 = 1698,
		Beyond-UI-UIScrollbar-Awake0 = 1699,
		Beyond-UI-UIScrollbarKeyHint-get_tickOption0 = 1700,
		Beyond-UI-UIScrollbarKeyHint-OnAwake0 = 1701,
		Beyond-UI-UIScrollbarKeyHint-Tick0 = 1702,
		Beyond-UI-UIScrollRect-get_controllerStickScrollEnabled0 = 1703,
		Beyond-UI-UIScrollCircle-get_tickOption0 = 1704,
		Beyond-UI-UIScrollCircle-get_elasticity0 = 1705,
		Beyond-UI-UIScrollCircle-set_elasticity0 = 1706,
		Beyond-UI-UIScrollCircle-get_velocity0 = 1707,
		Beyond-UI-UIScrollCircle-set_velocity0 = 1708,
		Beyond-UI-UIScrollCircle-get_panel0 = 1709,
		Beyond-UI-UIScrollCircle-get_viewRect0 = 1710,
		Beyond-UI-UIScrollCircle-OnInitializePotentialDrag0 = 1711,
		Beyond-UI-UIScrollCircle-IsActive0 = 1712,
		Beyond-UI-UIScrollCircle-OnBeginDrag0 = 1713,
		Beyond-UI-UIScrollCircle-OnEndDrag0 = 1714,
		Beyond-UI-UIScrollCircle-OnDrag0 = 1715,
		Beyond-UI-UIScrollCircle-_GetDeltaAngle0 = 1716,
		Beyond-UI-UIScrollCircle-_CheckCanMove0 = 1717,
		Beyond-UI-UIScrollCircle-_UpdateSpeed0 = 1718,
		Beyond-UI-UIScrollCircle-_TryUpdateCells0 = 1719,
		Beyond-UI-UIScrollCircle-_UpdateCenterIndex0 = 1720,
		Beyond-UI-UIScrollCircle-_UpdateShowingCells0 = 1722,
		Beyond-UI-UIScrollCircle-_GetRealIndex0 = 1723,
		Beyond-UI-UIScrollCircle-_UpdateAuto0 = 1724,
		Beyond-UI-UIScrollCircle-OnRelease0 = 1725,
		Beyond-UI-UIScrollCircle-_InitCells0 = 1726,
		Beyond-UI-UIScrollCircle-_Init0 = 1727,
		Beyond-UI-UIScrollCircle-_OnAwakeInit0 = 1728,
		Beyond-UI-UIScrollCircle-_UpdateScrollRange0 = 1729,
		Beyond-UI-UIScrollCircle-_DoScroll0 = 1730,
		Beyond-UI-UIScrollCircle-OnScroll0 = 1732,
		Beyond-UI-UIScrollCircle-Rebuild0 = 1733,
		Beyond-UI-UIScrollCircle-LayoutComplete0 = 1734,
		Beyond-UI-UIScrollCircle-GraphicUpdateComplete0 = 1735,
		Beyond-UI-UIScrollCircle-IsDestroyed0 = 1736,
		Beyond-UI-UIScrollCircle-OnEnable0 = 1737,
		Beyond-UI-UIScrollCircle-OnDisable0 = 1738,
		Beyond-UI-UIScrollCircle-Start0 = 1739,
		Beyond-UI-UIScrollCircle-OnAwake0 = 1740,
		Beyond-UI-UIScrollCircle-LateTick0 = 1741,
		Beyond-UI-UIScrollCircle-UpdateCount0 = 1742,
		Beyond-UI-UIScrollCircle-ScrollToIndex0 = 1744,
		Beyond-UI-UIScrollCircle-Get0 = 1745,
		Beyond-UI-UIScrollCircle-ClearComponent0 = 1746,
		Beyond-UI-UIScrollCircle-UnityEngine.UI.ICanvasElement.get_transform0 = 1747,
		Beyond-UI-UIScrollCircle-Cell-SetSelect0 = 1748,
		Beyond-UI-UIScrollContainerFollower-get_tickOption0 = 1749,
		Beyond-UI-UIScrollContainerFollower-OnAwake0 = 1750,
		Beyond-UI-UIScrollContainerFollower-LateTick0 = 1751,
		Beyond-UI-UIScrollContainerFollower-_RefreshSizeAndPositionToTargetContainer0 = 1753,
		Beyond-UI-UIScrollList-get_autoLayoutWhenFew0 = 1754,
		Beyond-UI-UIScrollList-get_tickOption0 = 1755,
		Beyond-UI-UIScrollList-get_space0 = 1756,
		Beyond-UI-UIScrollList-get_maxShowingCellCount0 = 1757,
		Beyond-UI-UIScrollList-get_countPerLine0 = 1758,
		Beyond-UI-UIScrollList-get_cellWidth0 = 1759,
		Beyond-UI-UIScrollList-get_cellHeight0 = 1760,
		Beyond-UI-UIScrollList-OnAwake0 = 1761,
		Beyond-UI-UIScrollList-Init0 = 1762,
		Beyond-UI-UIScrollList-_EditorAwake0 = 1763,
		Beyond-UI-UIScrollList-Tick0 = 1764,
		Beyond-UI-UIScrollList-_UpdateGraduallyShow0 = 1765,
		Beyond-UI-UIScrollList-_UpdateAutoScroll0 = 1766,
		Beyond-UI-UIScrollList-LateTick0 = 1767,
		Beyond-UI-UIScrollList-OnEnable0 = 1768,
		Beyond-UI-UIScrollList-OnDisable0 = 1769,
		Beyond-UI-UIScrollList-SetTop0 = 1770,
		Beyond-UI-UIScrollList-UpdateCount2 = 1771,
		Beyond-UI-UIScrollList-UpdateShowingCells1 = 1772,
		Beyond-UI-UIScrollList-GetRangeInView0 = 1773,
		Beyond-UI-UIScrollList-SetCellCanCache0 = 1774,
		Beyond-UI-UIScrollList-CacheShowingCell0 = 1775,
		Beyond-UI-UIScrollList-set_currentStep0 = 1776,
		Beyond-UI-UIScrollList-OnRelease0 = 1777,
		Beyond-UI-UIScrollList-SetPaddingBottom0 = 1778,
		Beyond-UI-UIScrollList-SetPaddingTop0 = 1779,
		Beyond-UI-UIScrollList-SetPaddingRight0 = 1780,
		Beyond-UI-UIScrollList-SetPaddingLeft0 = 1781,
		Beyond-UI-UIScrollList-GetPadding0 = 1782,
		Beyond-UI-UIScrollList-GetShowingCellsIndexRange0 = 1783,
		Beyond-UI-UIScrollList-GetCenterIndex0 = 1784,
		Beyond-UI-UIScrollList-get_enableSelectedNavigation0 = 1785,
		Beyond-UI-UIScrollList-get_naviBindingGroupId0 = 1786,
		Beyond-UI-UIScrollList-GetNaviManagerTargetIndex0 = 1787,
		Beyond-UI-UIScrollList-GetMousePosIndex0 = 1788,
		Beyond-UI-UIScrollList-ScreenPos2Index0 = 1789,
		Beyond-UI-UIScrollList-GetIndexOf0 = 1790,
		Beyond-UI-UIScrollList-_GetScreenPosLineColumnInfo0 = 1791,
		Beyond-UI-UIScrollRect-Awake0 = 1792,
		Beyond-UI-UIScrollRect-_CheckOverScrollEffect0 = 1793,
		Beyond-UI-UIScrollRect-OnEnable0 = 1794,
		Beyond-UI-UIScrollRect-_InitController0 = 1795,
		Beyond-UI-UIScrollRect-ScrollToNaviTarget0 = 1796,
		Beyond-UI-UIScrollRect-Update0 = 1797,
		Beyond-UI-UIScrollRect-_TickRefreshControllerStickScroll0 = 1798,
		Beyond-UI-UIScrollRect-_UpdateMoveTips0 = 1799,
		Beyond-UI-UIScrollRect-get_moveTips0 = 1800,
		Beyond-UI-UIScrollRect-IsCellViewed0 = 1801,
		Beyond-UI-UIScrollRect-ClampContentToBounds0 = 1802,
		Beyond-UI-UIScrollRect-OnDestroy0 = 1803,
		Beyond-UI-UIScrollRect-_CustomSetPosOnScroll0 = 1804,
		Beyond-UI-UIScrollRect-UpdateScrollEnableNode0 = 1808,
		Beyond-UI-UIScrollRect-OnBeginDrag0 = 1809,
		Beyond-UI-UIScrollRect-OnDrag0 = 1810,
		Beyond-UI-UIScrollRect-OnEndDrag0 = 1811,
		Beyond-UI-UIScrollRect-_CheckOverScrollOnEndDrag0 = 1812,
		Beyond-UI-UIScrollRect-ClearComponent0 = 1813,
		Beyond-UI-UIScrollRect-LateUpdate0 = 1814,
		Beyond-UI-UIScrollRectEdgeRedDot-get_tickOption0 = 1815,
		Beyond-UI-UIScrollRectEdgeRedDot-OnAwake0 = 1816,
		Beyond-UI-UIScrollRectEdgeRedDot-ResetReferences0 = 1817,
		Beyond-UI-UIScrollRectEdgeRedDot-OnEnable0 = 1818,
		Beyond-UI-UIScrollRectEdgeRedDot-_UpdateRedDotGameObjects0 = 1819,
		Beyond-UI-UIScrollRectEdgeRedDot-_OnScrollListUpdateCount0 = 1820,
		Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDotStatesForScrollList0 = 1821,
		Beyond-UI-UIScrollRectEdgeRedDot-OnRelease0 = 1822,
		Beyond-UI-UIScrollRectEdgeRedDot-Tick0 = 1823,
		Beyond-UI-UIScrollRectEdgeRedDot-_UpdateCacheDictForRangeChange0 = 1824,
		Beyond-UI-UIScrollRectEdgeRedDot-UpdateRedDotStateInDir0 = 1825,
		Beyond-UI-UIScrollRectEdgeRedDot-_CalculateRedDotStateInDir0 = 1826,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_state0 = 1827,
		Beyond-UI-UIScrollRectEdgeRedDot-IsRedDotInDir0 = 1828,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newPos0 = 1829,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalPos0 = 1830,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newRect0 = 1831,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalRect0 = 1832,
		Beyond-UI-UIScrollRectEdgeRedDot-ResetRedDotPosition0 = 1833,
		Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDot0 = 1834,
		Beyond-UI-UIScrollRectEdgeRedDot-UnregisterRedDot0 = 1835,
		Beyond-UI-UIScrollRectEdgeRedDot-ClearComponent0 = 1836,
		Beyond-UI-UIScrollText-get_tickOption0 = 1837,
		Beyond-UI-UIScrollText-_InitIfNot0 = 1838,
		Beyond-UI-UIScrollText-ResetTextScroll0 = 1839,
		Beyond-UI-UIScrollText-_ResetTextScrollInternal0 = 1840,
		Beyond-UI-UIScrollText-_ApplyTextAlignment0 = 1841,
		Beyond-UI-UIScrollText-_ResetTextScroll0 = 1842,
		Beyond-UI-UIScrollText-ResetToStatic0 = 1843,
		Beyond-UI-UIScrollText-GetSingleScrollDuration0 = 1844,
		Beyond-UI-UIScrollText-OnAwake0 = 1845,
		Beyond-UI-UIScrollText-LateTick0 = 1846,
		Beyond-UI-UIScrollText-_UpdateScrollState0 = 1847,
		Beyond-UI-UIScrollText-_ApplyTextScroll0 = 1848,
		Beyond-UI-UIScrollText-CanvasGroupHandler-HandleAlpha0 = 1849,
		Beyond-UI-UIScrollText-PositionScrollHandler-ApplyScroll0 = 1850,
		Beyond-UI-UIScrollText-PositionScrollHandler-ResetScroll0 = 1851,
		Beyond-UI-UIScrollText-PositionScrollHandler-UpdateScrollStatus0 = 1852,
		Beyond-UI-UIScrollText-MeshScrollHandler-ApplyScroll0 = 1853,
		Beyond-UI-UIScrollText-MeshScrollHandler-_ApplyScroll0 = 1854,
		Beyond-UI-UIScrollText-MeshScrollHandler-_UpdateMeshClipping0 = 1855,
		Beyond-UI-UIScrollText-MeshScrollHandler-ResetScroll0 = 1856,
		Beyond-UI-UIScrollText-MeshScrollHandler-UpdateScrollStatus0 = 1857,
		Beyond-UI-UISelectableNaviGroup-Awake0 = 1858,
		Beyond-UI-UISelectableNaviGroup-_InitFocusBinding0 = 1859,
		Beyond-UI-UISelectableNaviGroup-_RefreshFocusBindings0 = 1862,
		Beyond-UI-UISelectableNaviGroup-OnEnable0 = 1863,
		Beyond-UI-UISelectableNaviGroup-_RefreshRelatedBindingGroupsState0 = 1864,
		Beyond-UI-UISelectableNaviGroup-_RefreshFocusActionKeyHint0 = 1865,
		Beyond-UI-UISelectableNaviGroup-_RefreshStopFocusActionKeyHint0 = 1866,
		Beyond-UI-UISelectableNaviGroup-OnDisable0 = 1867,
		Beyond-UI-UISelectableNaviGroup-_OnIsTopLayerChanged0 = 1868,
		Beyond-UI-UISelectableNaviGroup-_OnSelectableNaviGroupDisabled0 = 1869,
		Beyond-UI-UISelectableNaviGroup-_BeforeSelectableNaviGroupDestroy0 = 1870,
		Beyond-UI-UISelectableNaviGroup-_OnSetLayerSelectedTarget0 = 1871,
		Beyond-UI-UISelectableNaviGroup-_OnRemoveFromLayerStack0 = 1872,
		Beyond-UI-UISelectableNaviGroup-OnDestroy0 = 1873,
		Beyond-UI-UISelectableNaviGroup-ClearComponent0 = 1874,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnUp0 = 1875,
		Beyond-UI-UISelectableNaviGroup-_TryChangeNaviPartner0 = 1876,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnDown0 = 1877,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnLeft0 = 1878,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnRight0 = 1879,
		Beyond-UI-UISelectableNaviGroup-get_FocusBindingId0 = 1880,
		Beyond-UI-UISelectableNaviGroup-get_StopFocusBindingId0 = 1881,
		Beyond-UI-UISelectableNaviGroup-get_lastFocusNaviTarget0 = 1882,
		Beyond-UI-UISelectableNaviGroup-RefreshFocusBindings0 = 1883,
		Beyond-UI-UISelectableNaviGroup-SetFocusBindingText0 = 1884,
		Beyond-UI-UISelectableNaviGroup-ManuallyRefreshRelatedBindingGroups0 = 1885,
		Beyond-UI-UISemiCircleScrollList-get_tickOption0 = 1886,
		Beyond-UI-UISemiCircleScrollList-get_controllerStickScrollEnabled0 = 1887,
		Beyond-UI-UISemiCircleScrollList-OnAwake0 = 1888,
		Beyond-UI-UISemiCircleScrollList-ClearComponent0 = 1889,
		Beyond-UI-UISemiCircleScrollList-UpdateLayout0 = 1890,
		Beyond-UI-UISemiCircleScrollList-_InitializeCells0 = 1891,
		Beyond-UI-UISemiCircleScrollList-OnDisable0 = 1892,
		Beyond-UI-UISemiCircleScrollList-Tick0 = 1893,
		Beyond-UI-UISemiCircleScrollList-_TickRefreshControllerStickScroll0 = 1894,
		Beyond-UI-UISemiCircleScrollList-OnEndDrag0 = 1895,
		Beyond-UI-UISemiCircleScrollList-_ApplyDamping0 = 1896,
		Beyond-UI-UISemiCircleScrollList-OnDrag0 = 1903,
		Beyond-UI-UISemiCircleScrollList-RefreshLayout0 = 1904,
		Beyond-UI-UISemiCircleScrollList-OnBeginDrag0 = 1905,
		Beyond-UI-UISemiCircleScrollListPair-Awake0 = 1906,
		Beyond-UI-UISemiCircleScrollListPair-_OnCellShow0 = 1907,
		Beyond-UI-UISemiCircleScrollListPair-_OnClosestCellChanged0 = 1908,
		Beyond-UI-UISemiCircleScrollListPair-_OnDrag0 = 1909,
		Beyond-UI-UISemiCircleScrollListPair-_OnEndDrag0 = 1910,
		Beyond-UI-UISemiCircleScrollListPair-RefreshLayout0 = 1911,
		Beyond-UI-UISequenceImage-get_tickOption0 = 1912,
		Beyond-UI-UISequenceImage-OnAwake0 = 1913,
		Beyond-UI-UISequenceImage-OnEnable0 = 1914,
		Beyond-UI-UISequenceImage-Play0 = 1915,
		Beyond-UI-UISequenceImage-SetSprite0 = 1917,
		Beyond-UI-UISequenceImage-OnDisable0 = 1918,
		Beyond-UI-UISequenceImage-Stop0 = 1919,
		Beyond-UI-UISequenceImage-Tick0 = 1921,
		Beyond-UI-UISimpleActiveAnimationHelper-get_tickOption0 = 1922,
		Beyond-UI-UISimpleActiveAnimationHelper-Start0 = 1923,
		Beyond-UI-UISimpleActiveAnimationHelper-Skip0 = 1924,
		Beyond-UI-UISimpleActiveAnimationHelper-OnEnable0 = 1925,
		Beyond-UI-UISimpleActiveAnimationHelper-Tick0 = 1926,
		Beyond-UI-UISimpleStateController-get_curStateName0 = 1927,
		Beyond-UI-UISimpleStateController-SetState0 = 1928,
		Beyond-UI-UISimpleStateController-StateInfo-ToString0 = 1929,
		Beyond-UI-UISizeFollower-get_tickOption0 = 1930,
		Beyond-UI-UISizeFollower-LateTick0 = 1931,
		Beyond-UI-UISlider-_TryPostSlideAudioEvent0 = 1932,
		Beyond-UI-UISlider-ClampValue0 = 1933,
		Beyond-UI-UISlider-CustomProcessNormalizedValue0 = 1934,
		Beyond-UI-UISlider-OnValueChanged0 = 1935,
		Beyond-UI-UISlider-OnClickSliderBar0 = 1936,
		Beyond-UI-UISlider-OnClickSliderHandle0 = 1937,
		Beyond-UI-UISlider-_NotifyIsHover0 = 1938,
		Beyond-UI-UISlider-OnBeginDrag0 = 1939,
		Beyond-UI-UISlider-OnEndDrag0 = 1940,
		Beyond-UI-UISlider-Awake0 = 1941,
		Beyond-UI-UISlider-_InitBinding0 = 1942,
		Beyond-UI-UISlider-_InitGamepadStickScroll0 = 1945,
		Beyond-UI-UISlider-_OnGamepadStickScrollHoriValue0 = 1946,
		Beyond-UI-UISlider-_ApplyGamepadStickScroll0 = 1947,
		Beyond-UI-UISlider-_AddValue0 = 1948,
		Beyond-UI-UISlider-_ReduceValue0 = 1949,
		Beyond-UI-UISlider-OnEnable0 = 1950,
		Beyond-UI-UISlider-_CreateGamepadStickScrollTickFunction0 = 1951,
		Beyond-UI-UISlider-_ReleaseGamepadStickScrollTickFunction0 = 1952,
		Beyond-UI-UISlider-_GamepadStickScrollTick0 = 1953,
		Beyond-UI-UISlider-get_groupEnabled0 = 1954,
		Beyond-UI-UISlider-OnDisable0 = 1955,
		Beyond-UI-UISlider-ClearComponent0 = 1956,
		Beyond-UI-UISlider-OnDestroy0 = 1957,
		Beyond-UI-UISlider-get_groupId0 = 1958,
		Beyond-UI-UISlider-get_bindingViewActionId0 = 1959,
		Beyond-UI-UISlider-get_bindingViewLabelText0 = 1960,
		Beyond-UI-UISlider-get_redDotTrans0 = 1961,
		Beyond-UI-UISlider-get_bindingEnabled0 = 1962,
		Beyond-UI-UISlider-get_bindingViewState0 = 1963,
		Beyond-UI-UISlider-GetBindingViewActionId0 = 1964,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyDown0 = 1965,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyUp0 = 1966,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.get_interactable0 = 1967,
		Beyond-UI-UISoftMask-get_tickOption0 = 1968,
		Beyond-UI-UISoftMask-_GetSoftMaskTexture0 = 1969,
		Beyond-UI-UISoftMask-get_softMaskDefaultMaterial0 = 1970,
		Beyond-UI-UISoftMask-GetTextSoftMaskMaterial0 = 1971,
		Beyond-UI-UISoftMask-GetUIVFXSoftMaskMaterial0 = 1972,
		Beyond-UI-UISoftMask-GetCornerCanvas0 = 1973,
		Beyond-UI-UISoftMask-GetFourCornnerArrayWorld0 = 1974,
		Beyond-UI-UISoftMask-OnEnable0 = 1975,
		Beyond-UI-UISoftMask-_OnEnableRuntimeAtlas0 = 1976,
		Beyond-UI-UISoftMask-_UpdateParam0 = 1977,
		Beyond-UI-UISoftMask-_UpdateImageCache0 = 1978,
		Beyond-UI-UISoftMask-_CalculateSlicedSpriteParams0 = 1979,
		Beyond-UI-UISoftMask-_GetRuntimeAtlasSpriteInnerUV0 = 1980,
		Beyond-UI-UISoftMask-_GetRuntimeAtlasSpritePadding0 = 1981,
		Beyond-UI-UISoftMask-_GetAdjustedBorders0 = 1982,
		Beyond-UI-UISoftMask-_UpdateChildren0 = 1983,
		Beyond-UI-UISoftMaskable-MarkGraphicVerticesDirty0 = 1984,
		Beyond-UI-UISoftMaskable-get_graphic0 = 1985,
		Beyond-UI-UISoftMaskable-MarkGraphicMaterialDirty0 = 1986,
		Beyond-UI-UISoftMask-_OnWillRenderCanvases0 = 1987,
		Beyond-UI-UISoftMask-OnDisable0 = 1988,
		Beyond-UI-UISoftMask-_Clear0 = 1989,
		Beyond-UI-UISoftMask-_DestroyMaterial0 = 1990,
		Beyond-UI-UISoftMask-TailLateTick0 = 1991,
		Beyond-UI-UISoftMask-_IsImageParamChanged0 = 1992,
		Beyond-UI-UISoftMaskable-get_tickOption0 = 1993,
		Beyond-UI-UISoftMaskable-get_softMaskModefiedMat0 = 1994,
		Beyond-UI-UISoftMaskable-get_softMask0 = 1995,
		Beyond-UI-UISoftMaskable-get_uiText0 = 1996,
		Beyond-UI-UISoftMaskable-GetModifiedMaterial0 = 1997,
		Beyond-UI-UISoftMaskable-OnEnable0 = 1998,
		Beyond-UI-UISoftMaskable-OnDisable0 = 1999,
		Beyond-UI-UISoftMaskable-LateTick0 = 2000,
		Beyond-UI-UISoftMaskable-ModifyMesh0 = 2001,
		Beyond-UI-UISoftMaskable-_Equal0 = 2002,
		Beyond-UI-UISoftMaskable-_ComputeLineCross0 = 2003,
		Beyond-UI-UISoftMaskable-_ComputePointAtTriangleUV0 = 2004,
		Beyond-UI-UISoftMaskable-_ClipTriangleByClampSoftMaskUV0 = 2005,
		Beyond-UI-UISoftMaskable-_SetUIVertexUV0 = 2006,
		Beyond-UI-UISoftMaskable-_ClipRect0 = 2007,
		Beyond-UI-UISoftMaskable-ModifyMesh1 = 2008,
		Beyond-UI-UISortingOrder-OnEnable0 = 2009,
		Beyond-UI-UISortingOrder-_GetRenderer0 = 2010,
		Beyond-UI-UISortingOrder-_GetChildrenRenderers0 = 2011,
		Beyond-UI-UISortingOrder-_GetChildrenParticleRenderers0 = 2012,
		Beyond-UI-UISortingOrder-_GetCanvas0 = 2013,
		Beyond-UI-UISortingOrder-SetOrder0 = 2014,
		Beyond-UI-UISortingOrder-Awake0 = 2015,
		Beyond-UI-UISortingOrder-OnDestroy0 = 2016,
		Beyond-UI-UIStepScrollList-get_centerIndex0 = 2017,
		Beyond-UI-UIStepScrollList-Init0 = 2018,
		Beyond-UI-UIStepScrollList-_OnScrollEnd0 = 2019,
		Beyond-UI-UIStepScrollList-_TryAutoScroll0 = 2020,
		Beyond-UI-UIStepScrollList-_GetClampedIndex0 = 2021,
		Beyond-UI-UIStepScrollList-_OnScrollStart0 = 2022,
		Beyond-UI-UIStepScrollList-InitConfig0 = 2023,
		Beyond-UI-UIStepScrollList-OnScroll0 = 2024,
		Beyond-UI-UIStepScrollList-OnBeginDrag0 = 2025,
		Beyond-UI-UIStepScrollList-OnEndDrag0 = 2026,
		Beyond-UI-UIStepScrollList-SetTop0 = 2028,
		Beyond-UI-UIStepScrollList-UpdateShowingCells0 = 2029,
		Beyond-UI-UIStepScrollList-ClearComponent0 = 2030,
		Beyond-UI-UIStepScrollList-OnDisable0 = 2031,
		Beyond-UI-UIStyleByState-Awake0 = 2032,
		Beyond-UI-UIStyleByState-UpdateStyle0 = 2033,
		Beyond-UI-UIStyleByState-_IsValidStyle0 = 2034,
		Beyond-UI-UIStyleByState-OnDestroy0 = 2035,
		Beyond-UI-UISubtitle-Start0 = 2036,
		Beyond-UI-UISubtitle-_SetAsDefault0 = 2037,
		Beyond-UI-UISubtitle-SetSubtitle0 = 2038,
		Beyond-UI-UISubtitle-UpdateAlpha0 = 2039,
		Beyond-UI-UITextPair-get_text0 = 2040,
		Beyond-UI-UITextPair-set_text0 = 2041,
		Beyond-UI-UITextPair-set_color0 = 2042,
		Beyond-UI-UITextPair-get_first0 = 2043,
		Beyond-UI-UITextPair-SetAndResolveTextStyle0 = 2044,
		Beyond-UI-UITextPair-SetPhoneticText0 = 2045,
		Beyond-UI-UIToggle-Awake0 = 2046,
		Beyond-UI-UIToggle-_InitToggleBinding0 = 2047,
		Beyond-UI-UIToggle-TryInternalToggle0 = 2048,
		Beyond-UI-UIToggle-_OnToggleFail0 = 2049,
		Beyond-UI-UIToggle-_TryRefreshToggleBindingText0 = 2051,
		Beyond-UI-UIToggle-_TryRefreshBindingText0 = 2053,
		Beyond-UI-UIToggle-get_customBindingViewLabelText0 = 2054,
		Beyond-UI-UIToggle-_InitActionOnSetNaviTarget0 = 2055,
		Beyond-UI-UIToggle-_TryRefreshHoverConfirmBindingText0 = 2057,
		Beyond-UI-UIToggle-OnEnable0 = 2059,
		Beyond-UI-UIToggle-_UpdateObjects0 = 2060,
		Beyond-UI-UIToggle-_PlayAnimation0 = 2061,
		Beyond-UI-UIToggle-_UpdateBindingEnable0 = 2062,
		Beyond-UI-UIToggle-OnDisable0 = 2063,
		Beyond-UI-UIToggle-OnDestroy0 = 2064,
		Beyond-UI-UIToggle-ClearComponent0 = 2065,
		Beyond-UI-UIToggle-Start0 = 2066,
		Beyond-UI-UIToggle-InternalToggle0 = 2067,
		Beyond-UI-UIToggle-PlayAudio0 = 2068,
		Beyond-UI-UIToggle-OnValueChange0 = 2069,
		Beyond-UI-UIToggle-_NotifyIsHover0 = 2070,
		Beyond-UI-UIToggle-OnInteractableChanged0 = 2071,
		Beyond-UI-UIToggle-set_customBindingViewLabelText0 = 2072,
		Beyond-UI-UIToggle-GetMouseActionHints0 = 2073,
		Beyond-UI-UIToggle-OnPointerDown0 = 2074,
		Beyond-UI-UIToggle-OnPointerClick0 = 2076,
		Beyond-UI-UIToggle-OnSubmit0 = 2078,
		Beyond-UI-UIToggle-OnNaviTargetEnabledAgain0 = 2079,
		Beyond-UI-UIToggle-_OnSetAsNaviTarget0 = 2080,
		Beyond-UI-UIToggle-_ToggleNaviInputBinding0 = 2081,
		Beyond-UI-UIToggle-RefreshHintText0 = 2082,
		Beyond-UI-UIToggleGroup-Awake0 = 2083,
		Beyond-UI-UIToggleGroup-MoveToNext0 = 2084,
		Beyond-UI-UIToggleGroup-_MoveTo0 = 2085,
		Beyond-UI-UIToggleGroup-MoveToPrevious0 = 2087,
		Beyond-UI-UIToggleGroup-OnEnable0 = 2089,
		Beyond-UI-UIToggleGroup-OnDisable0 = 2092,
		Beyond-UI-UIToggleGroup-OnDestroy0 = 2093,
		Beyond-UI-UITouchPanel-get_tickOption0 = 2094,
		Beyond-UI-UITouchPanel-get_touchPos0 = 2095,
		Beyond-UI-UITouchPanel-get_isDragging0 = 2096,
		Beyond-UI-UITouchPanel-get_isInGestureZoom0 = 2097,
		Beyond-UI-UITouchPanel-OnBeginDrag0 = 2098,
		Beyond-UI-UITouchPanel-_IsSameTouchFromPress0 = 2099,
		Beyond-UI-UITouchPanel-OnEndDrag0 = 2100,
		Beyond-UI-UITouchPanel-DoEndDrag0 = 2101,
		Beyond-UI-UITouchPanel-OnDrag0 = 2102,
		Beyond-UI-UITouchPanel-OnPointerDown0 = 2104,
		Beyond-UI-UITouchPanel-_OnActionPress0 = 2105,
		Beyond-UI-UITouchPanel-OnPointerUp0 = 2106,
		Beyond-UI-UITouchPanel-_OnActionRelease0 = 2107,
		Beyond-UI-UITouchPanel-OnPointerClick0 = 2108,
		Beyond-UI-UITouchPanel-OnPointerEnter0 = 2109,
		Beyond-UI-UITouchPanel-OnPointerExit0 = 2111,
		Beyond-UI-UITouchPanel-ClearTouchInfo0 = 2112,
		Beyond-UI-UITouchPanel-OnScroll0 = 2113,
		Beyond-UI-UITouchPanel-SimulateClick0 = 2114,
		Beyond-UI-UITouchPanel-DeActiveTouch0 = 2115,
		Beyond-UI-UITouchPanel-OnAwake0 = 2116,
		Beyond-UI-UITouchPanel-InitBinding0 = 2117,
		Beyond-UI-UITouchPanel-_UpdateState0 = 2120,
		Beyond-UI-UITouchPanel-Tick0 = 2123,
		Beyond-UI-UITouchPanel-LateTick0 = 2126,
		Beyond-UI-UITouchPanel-OnEnable0 = 2127,
		Beyond-UI-UITouchPanel-OnDisable0 = 2128,
		Beyond-UI-UITouchPanel-OnDestroy0 = 2129,
		Beyond-UI-UITouchPanel-get_groupId0 = 2130,
		Beyond-UI-UITouchPanel-OnRelease0 = 2131,
		Beyond-UI-UITouchPanel-ClearComponent0 = 2132,
		Beyond-UI-UITouchPanel-get_groupEnabled0 = 2133,
		Beyond-UI-UITouchPanel-get_parentTarget0 = 2134,
		Beyond-UI-UIVFXManager-get_tickOption0 = 2135,
		Beyond-UI-UIVFXManager-get_graphic0 = 2136,
		Beyond-UI-UIVFXManager-get_softMaskable0 = 2137,
		Beyond-UI-UIVFXManager-OnEnable0 = 2138,
		Beyond-UI-UIVFXManager-_OnEnableRuntimeAtlas0 = 2139,
		Beyond-UI-UIVFXManager-_UpdateParam0 = 2140,
		Beyond-UI-UIVFXManager-LateTick0 = 2141,
		Beyond-UI-UIVFXManager-OnDisable0 = 2142,
		Beyond-UI-UIVFXManager-_Clear0 = 2143,
		Beyond-UI-UIVFXManager-_DestroyMaterial0 = 2144,
		Beyond-UI-UIVFXManager-GetModifiedMaterial0 = 2145,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateUpPos0 = 2146,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-ScrollListLayoutInfo-get_cellHeight0 = 2147,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateDownPos0 = 2148,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateMidPos0 = 2149,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateWorldLevelScrollList0 = 2150,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-_ScrollLayouts0 = 2151,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-OnDisable0 = 2158,
		Beyond-UI-VirtualMouseInitPos-get_panel0 = 2159,
		Beyond-UI-VirtualMouseInitPos-OnEnable0 = 2160,
		Beyond-UI-CSPopupPanel-Awake0 = 2161,
		Beyond-UI-CSPopupPanel-_OnConfirm0 = 2162,
		Beyond-UI-CSPopupPanel-_OnCancel0 = 2163,
		Beyond-UI-CSPopupPanel-OnDestroy0 = 2164,
		Beyond-UI-CSPopupPanel-Show0 = 2165,
		Beyond-UI-CSPopupPanel-ClearAllPanels0 = 2166,
		Beyond-UI-MobileMotionManager-OnInit0 = 2167,
		Beyond-UI-MobileMotionManager-_CheckMotionLevelAndPostIfChange0 = 2168,
		Beyond-UI-MobileMotionManager-OnRelease0 = 2169,
		Beyond-UI-MobileMotionManager-PostEventCommonShort0 = 2170,
		Beyond-UI-MobileMotionManager-PostEventCommonOperateSuccess0 = 2171,
		Beyond-UI-MobileMotionManager-PostEventCommonOperateFailure0 = 2172,
		Beyond-UI-I18nFontLoader-GetCNFont0 = 2173,
		Beyond-UI-DynamicFontAssetLoader-AddNotFoundUnicode0 = 2174,
		Beyond-UI-DynamicFontAssetLoader-TryGetFontAsset0 = 2175,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-GetFontAsset0 = 2177,
		Beyond-UI-DynamicFontAssetLoader-TryRemoveRefText0 = 2178,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-RemoveRefText0 = 2179,
		Beyond-UI-DynamicFontAssetLoader-Dispose0 = 2180,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-Dispose0 = 2181,
		Beyond-UI-TweenUtils-TickAsCountDown0 = 2182,
		Beyond-UI-TweenUtils-FLerpByTime-Start0 = 2183,
		Beyond-UI-TweenUtils-FLerpByTime-GetValue0 = 2184,
		Beyond-UI-UIAnimationLayerMixPlayer-LockToClip0 = 2185,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateGraph0 = 2186,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateMixer0 = 2187,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateOutput0 = 2188,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateSourceFromAsset0 = 2189,
		Beyond-UI-UIAnimationMixPlayer-LockToClip0 = 2190,
		Beyond-UI-UIAnimationMixPlayer-CreateGraph0 = 2191,
		Beyond-UI-UIAnimationMixPlayer-CreateMixer0 = 2192,
		Beyond-UI-UIAnimationMixPlayer-CreateOutput0 = 2193,
		Beyond-UI-UIAnimationMixPlayer-CreateSourceFromAsset0 = 2194,
		Beyond-UI-UILoadImageSprite-get_spritePath0 = 2195,
		Beyond-UI-UILoadImageSprite-set_spritePath0 = 2196,
		Beyond-UI-UILoadImageSprite-_LoadSprite0 = 2197,
		Beyond-UI-UILoadImageSprite-OnDestroy0 = 2200,
		Beyond-UI-UILoadImageSpriteByName-set_spriteName0 = 2201,
		Beyond-UI-UISwitchTween-BeforeShowEffect0 = 2202,
		Beyond-UI-UISwitchTween-BeforeHideEffect0 = 2203,
		Beyond-UI-UISwitchTween-AfterShowEffect0 = 2204,
		Beyond-UI-UISwitchTween-AfterHideEffect0 = 2205,
		Beyond-UI-UISwitchTween-ResetToState0 = 2206,
		Beyond-UI-UISwitchTween-Show0 = 2207,
		Beyond-UI-UISwitchTween-_ClearTweenInternal0 = 2208,
		Beyond-UI-UISwitchTween-TweenContext-OnReset0 = 2209,
		Beyond-UI-UISwitchTween-TweenContext-OnTweenStop0 = 2210,
		Beyond-UI-UISwitchTween-ClearTween0 = 2211,
		Beyond-UI-UISwitchTween-Hide0 = 2214,
		Beyond-UI-UISwitchTween-WaitForTweening0 = 2217,
		Beyond-UI-UISwitchTween-get_isTweening0 = 2221,
		Beyond-UI-UISwitchTween-SetOptions0 = 2225,
		Beyond-UI-UISwitchTween-get_isShow0 = 2226,
		Beyond-UI-UISwitchTween-set_isShow0 = 2227,
		Beyond-UI-UISwitchTween-Reset0 = 2228,
		Beyond-UI-UISwitchTween-Clear0 = 2229,
		Beyond-UI-UISwitchTween-GetContext0 = 2230,
		Beyond-UI-UISwitchTween-TweenContext-IsInterapted0 = 2231,
		Beyond-UI-UISwitchTween-TweenWrapper-IsActive0 = 2232,
		Beyond-UI-UISwitchTween-TweenWrapper-IsPlaying0 = 2233,
		Beyond-UI-UISwitchTween-TweenWrapper-KillIfNecessary0 = 2234,
		Beyond-UI-UISwitchTween-TweenWrapper-OnComplete0 = 2235,
		Beyond-UI-UISwitchTween-TweenWrapper-SetAutoKill0 = 2236,
		Beyond-UI-FadeSwitchTween-get_alphaHandler0 = 2237,
		Beyond-UI-FadeSwitchTween-get_activeAlpha0 = 2238,
		Beyond-UI-FadeSwitchTween-set_activeAlpha0 = 2239,
		Beyond-UI-FadeSwitchTween-GenerateTweenOfHide0 = 2240,
		Beyond-UI-FadeSwitchTween-Durations-GetHideDuration0 = 2243,
		Beyond-UI-FadeSwitchTween-GenerateTweenOfShow0 = 2244,
		Beyond-UI-FadeSwitchTween-Durations-GetShowDuration0 = 2245,
		Beyond-UI-FadeSwitchTween-BeforeShowEffect0 = 2246,
		Beyond-UI-FadeSwitchTween-SetObjectActive0 = 2247,
		Beyond-UI-FadeSwitchTween-AfterHideEffect0 = 2250,
		Beyond-UI-FadeSwitchTween-ResetToState0 = 2251,
		Beyond-UI-FadeSwitchTween-Release0 = 2252,
		Beyond-UI-FadeSwitchTween-Builder-Build0 = 2253,
		Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfHide0 = 2257,
		Beyond-UI-FadeTranslationSwitchTween-_GetTargetAlpha0 = 2258,
		Beyond-UI-FadeTranslationSwitchTween-_GetTargetPos0 = 2259,
		Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfShow0 = 2260,
		Beyond-UI-FadeTranslationSwitchTween-BeforeShowEffect0 = 2261,
		Beyond-UI-FadeTranslationSwitchTween-AfterHideEffect0 = 2262,
		Beyond-UI-FadeTranslationSwitchTween-ResetToState0 = 2263,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-IsPlaying0 = 2264,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-KillIfNecessary0 = 2265,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-OnComplete0 = 2266,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-SetAutoKill0 = 2267,
		Beyond-UI-UIAtlasManager-OnInit0 = 2268,
		Beyond-UI-UIAtlasManager-_CreateTickFunction0 = 2269,
		Beyond-UI-UIAtlasManager-LateTick0 = 2270,
		Beyond-UI-UIAtlasManager-_ProcessRemoveQueue0 = 2271,
		Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRect0 = 2272,
		Beyond-UI-UIAtlasManager-_ProcessInsertQueue0 = 2275,
		Beyond-UI-UIAtlasManager-_IsRuntimeAtlasCompatible0 = 2276,
		Beyond-UI-UIAtlasManager-UIAtlasPage-get_maxFreeRectWidth0 = 2277,
		Beyond-UI-UIAtlasManager-UIAtlasPage-get_maxFreeRectHeight0 = 2278,
		Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRect0 = 2279,
		Beyond-UI-UIAtlasManager-UIAtlasPage-CopyIntoAtlas0 = 2280,
		Beyond-UI-UIAtlasManager-OnUnInit0 = 2281,
		Beyond-UI-UIAtlasManager-_ClearTickFunction0 = 2282,
		Beyond-UI-UIAtlasManager-Release0 = 2283,
		Beyond-UI-UIAtlasManager-GetAtlasCount0 = 2284,
		Beyond-UI-UIAtlasManager-UIAtlasHandle-IsValid0 = 2285,
		Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRects0 = 2286,
		Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRects0 = 2287,
		Beyond-UI-UIRedDotAnimation-Init0 = 2288,
		Beyond-UI-UIRedDotAnimation-_UpdateRedDotAnimation0 = 2289,
		Beyond-UI-UIRedDotAnimation-UnInit0 = 2290,
		Beyond-UI-UIRedDotAnimation-AddRedDotImage0 = 2291,
		Beyond-UI-UIRedDotAnimation-RemoveRedDotImage0 = 2292,
		Beyond-UI-UIRedDotAnimationNode-Awake0 = 2293,
		Beyond-UI-UIRedDotAnimationNode-OnEnable0 = 2294,
		Beyond-UI-UIRedDotAnimationNode-OnDisable0 = 2295,
		Beyond-UI-WebApplication-Start0 = 2296,
		Beyond-UI-WebApplication-StartHGBrowser0 = 2299,
		Beyond-UI-UIState-StateDescription-EqualsAnimation0 = 2302,
		Beyond-UI-UIState-StateDescription-EqualsAnimator0 = 2303,
		Beyond-UI-UIState-StateDescription-EqualsButton0 = 2304,
		Beyond-UI-UIState-StateDescription-EqualsCanvasGroup0 = 2305,
		Beyond-UI-UIState-StateDescription-EqualsComponent0 = 2306,
		Beyond-UI-UIState-StateDescription-get_ReadableDescription0 = 2307,
		Beyond-UI-UIState-UIStateControllerUtils-GetName0 = 2308,
		Beyond-UI-UIState-StateDescription-ToString0 = 2309,
		Beyond-UI-UIState-StateDescription-op_Equality0 = 2310,
		Beyond-UI-UIState-StateDescription-Equals0 = 2311,
		Beyond-UI-UIState-StateDescription-_EqualsByTargetType0 = 2312,
		Beyond-UI-UIState-StateDescription-EqualsGameObject0 = 2313,
		Beyond-UI-UIState-StateDescription-EqualsState0 = 2314,
		Beyond-UI-UIState-StateDescription-EqualsImage0 = 2315,
		Beyond-UI-UIState-StateDescription-EqualsText0 = 2316,
		Beyond-UI-UIState-StateDescription-EqualsRectTransform0 = 2317,
		Beyond-UI-UIState-StateDescription-EqualsLayoutElement0 = 2318,
		Beyond-UI-UIState-StateDescription-EqualsGraphic0 = 2319,
		Beyond-UI-UIState-StateDescription-EqualsLayoutGroup0 = 2320,
		Beyond-UI-UIState-StateDescription-EqualsScrollList0 = 2321,
		Beyond-UI-UIState-StateDescription-EqualsGridLayoutGroup0 = 2322,
		Beyond-UI-UIState-StateDescription-EqualsSelectable0 = 2323,
		Beyond-UI-UIState-StateDescription-op_Inequality0 = 2324,
		Beyond-UI-UIState-StateDescription-Equals1 = 2325,
		Beyond-UI-UIState-StateDescription-GetHashCode0 = 2326,
		Beyond-UI-UIState-StateDescription-_GetTargetHashCode0 = 2327,
		Beyond-UI-UIState-StateDescription-_OnGridLayoutGroupChanged0 = 2328,
		Beyond-UI-UIState-StateDescription-_OnImageChanged0 = 2329,
		Beyond-UI-UIState-StateDescription-_OnLayoutElementChanged0 = 2330,
		Beyond-UI-UIState-StateDescription-_OnLayoutGroupChanged0 = 2331,
		Beyond-UI-UIState-StateDescription-_OnRectTransformChanged0 = 2332,
		Beyond-UI-UIState-StateDescription-_OnScrollListChanged0 = 2333,
		Beyond-UI-UIState-StateDescription-_OnTextChanged0 = 2334,
		Beyond-UI-UIState-StateReference-HandleScheduledStates0 = 2335,
		Beyond-UI-UIState-UIStateController-Run0 = 2336,
		Beyond-UI-UIState-UIStateController-Stop0 = 2337,
		Beyond-UI-UIState-UIStateController-get_tickOption0 = 2338,
		Beyond-UI-UIState-UIStateController-Tick0 = 2339,
		Beyond-UI-UIState-UIStateController-_HandleStateAnimations0 = 2340,
		Beyond-UI-GPUI-GPUIExtendedPrefabData-_NormalizeWrapMode0 = 2344,
		Beyond-UI-GPUI-GPUIExtendedPrefabData-_PackFillOriginFlags0 = 2345,
		Beyond-UI-GPUI-GPUIExtendedPrefabData-CreateFontNode0 = 2346,
		Beyond-UI-GPUI-GPUIExtendedPrefabDataLite-_NormalizeWrapMode0 = 2347,
		Beyond-UI-GPUI-GPUIExtendedPrefabDataLite-CreateFontNode0 = 2348,
		Beyond-UI-GPUI-GPUIRootTransformState-get_Default0 = 2349,
		Beyond-UI-GPUI-GPUISubrootDomainState-get_Default0 = 2350,
		Beyond-UI-GPUI-GPUIExtendedAnimationState-get_Default0 = 2351,
		Beyond-UI-GPUI-GPUIExtendedTransformUtility-ResolveSubroot0 = 2352,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackPrefabAndParent0 = 2353,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackGrandParentMatTypeAndDrawType0 = 2354,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackRootScaleY0 = 2355,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackUInt16Pair0 = 2356,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackFillOverrideByte0 = 2357,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackTextScale0 = 2358,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackQuaternion0 = 2359,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-_PackSnorm160 = 2360,
		Beyond-UI-GPUI-GPUILayoutInfo-get_LegacyPrefabStride0 = 2361,
		Beyond-UI-GPUI-GPUILayoutInfo-get_LegacyPrefabLiteStride0 = 2362,
		Beyond-UI-GPUI-GPUILayoutInfo-get_LegacyInstanceStride0 = 2363,
		Beyond-UI-GPUI-GPUILayoutInfo-get_ExtendedPrefabStride0 = 2364,
		Beyond-UI-GPUI-GPUILayoutInfo-get_ExtendedPrefabLiteStride0 = 2365,
		Beyond-UI-GPUI-GPUILayoutInfo-get_ExtendedInstanceStride0 = 2366,
		Beyond-UI-GPUI-GPUILayoutInfo-get_IsLegacyLayoutAligned0 = 2367,
		Beyond-UI-GPUI-GPUILayoutInfo-get_IsExtendedLayoutAligned0 = 2368,
		Beyond-UI-GPUI-GPUPrefabData-CreateFontNode0 = 2369,
		Beyond-UI-GPUI-GPUPrefabDataLite-CreateFontNode0 = 2370,
		Beyond-UI-GPUI-CodePoint-ConvertToUTF320 = 2371,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-get_runtimeTexture0 = 2372,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-get_dynamicAtlasRect0 = 2373,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-get_isInitialized0 = 2374,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Initialize1 = 2375,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Initialize0 = 2376,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Dispose0 = 2377,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_IsValidStaticTexture0 = 2378,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_IsValidDynamicAtlasRect0 = 2379,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_IsAtlasCreationValid0 = 2380,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_LogFailure0 = 2381,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Acquire0 = 2382,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-DynamicSpriteHandle-CreateInvalidHandle0 = 2383,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_TryValidateSprite0 = 2384,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_GetSpriteContentSize0 = 2385,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_GetSpriteInstanceId0 = 2386,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Release1 = 2387,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Release0 = 2388,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-DynamicSpriteHandle-IsValid0 = 2389,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-GetAtlasStatus0 = 2390,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-Dispose0 = 2391,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-RegisterSpriteUV0 = 2392,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-_GetSpriteInstanceId0 = 2393,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-UnregisterSpriteUV0 = 2394,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-TryAcquire0 = 2395,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-_SetLiteUV0 = 2396,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-Release0 = 2397,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-FlushIfNeeded0 = 2398,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-DynamicPrefabNodeKey-Equals0 = 2399,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-DynamicPrefabNodeKey-Equals1 = 2400,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-DynamicPrefabNodeKey-GetHashCode0 = 2401,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-DynamicPrefabNodeKey-_GetSpriteInstanceId0 = 2402,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-TryAcquireDynamicSprite0 = 2403,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-TryAcquireDynamicPrefabNode0 = 2404,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-TryAcquireDynamicPrefabNode1 = 2405,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-MatchesDynamicPrefabNode0 = 2406,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-ReleaseDynamicPrefabNode0 = 2407,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-ReleaseDynamicSprite0 = 2408,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-get_Prefab0 = 2409,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-get_AnimationDuration0 = 2410,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-Create0 = 2411,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_InitializeAnimationStates0 = 2412,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_FindPreferredRootAnimationIndex0 = 2413,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_FindFirstAnimationIndex0 = 2414,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_GetAnimationData0 = 2415,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_FindDefaultSubrootAnimationIndex0 = 2416,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-Recycle0 = 2417,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_ClearAllSpriteOverrides0 = 2418,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_ClearSpriteOverride0 = 2419,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_ReleaseSpriteOverrideResources0 = 2420,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_HasActivePrefabNode0 = 2421,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-DoUpdate0 = 2422,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_WriteRootNode0 = 2423,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_WriteSubrootProxyNodes0 = 2424,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_GetAnimationStateForNode0 = 2425,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_UnpackPrefabId0 = 2426,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_ApplySpriteOverride0 = 2427,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_PackFillOverride0 = 2428,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetRootPosition0 = 2429,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetRootScale0 = 2430,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetRootRotation0 = 2431,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-StartAnimation0 = 2432,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-StartSubrootAnimation0 = 2433,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetNodeVisibility0 = 2434,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetNodeColor0 = 2435,
		Beyond-UI-GPUI-GPUIUtils-ColorToRGBAUint320 = 2436,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetNodeFillAmount0 = 2437,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetSubrootState0 = 2438,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetSubrootVisibility0 = 2439,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetText0 = 2440,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetSpriteOverride0 = 2441,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_TryPrimeSpriteOverride0 = 2442,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_TryResolveCurrentBasePrefabOffset0 = 2443,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_TryPrimeSpriteOverrideWithReleasedSlot0 = 2444,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-ClearSpriteOverride0 = 2445,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-ClearDynamicSpriteOverrides0 = 2446,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-UpdateDynamicSpriteContext0 = 2447,
		Beyond-UI-GPUI-GPUIExtendedSystem-get_fontAsset0 = 2448,
		Beyond-UI-GPUI-GPUIExtendedSystem-GetFontAsset0 = 2449,
		Beyond-UI-GPUI-GPUIExtendedSystem-set_fontAsset0 = 2450,
		Beyond-UI-GPUI-GPUIExtendedSystem-InitMaterials0 = 2451,
		Beyond-UI-GPUI-GPUIExtendedSystem-RegisterBeforeRenderSync0 = 2452,
		Beyond-UI-GPUI-GPUIExtendedSystem-UnregisterBeforeRenderSync0 = 2455,
		Beyond-UI-GPUI-GPUIExtendedSystem-CreateInstance0 = 2456,
		Beyond-UI-GPUI-GPUIExtendedSystem-_GetOneHandle0 = 2457,
		Beyond-UI-GPUI-GPUIExtendedSystem-DestroyInstance0 = 2458,
		Beyond-UI-GPUI-GPUIExtendedSystem-_IsHandleInvalid0 = 2459,
		Beyond-UI-GPUI-GPUIExtendedSystem-IsInstanceValid0 = 2460,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetRootPosition0 = 2461,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetRootScale0 = 2462,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetRootRotation0 = 2463,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetNodeVisibility0 = 2464,
		Beyond-UI-GPUI-GPUIExtendedSystem-_TryResolveNode0 = 2465,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetSubrootVisibility0 = 2466,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetSubrootTransform0 = 2467,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetColor0 = 2468,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetImageFillAmount0 = 2469,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetText0 = 2470,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetSprite0 = 2471,
		Beyond-UI-GPUI-GPUIExtendedSystem-StartAnimation1 = 2472,
		Beyond-UI-GPUI-GPUIExtendedSystem-StartAnimation0 = 2473,
		Beyond-UI-GPUI-GPUIExtendedSystem-TryGetAnimationDuration0 = 2474,
		Beyond-UI-GPUI-GPUIExtendedSystem-StartSubrootAnimation0 = 2475,
		Beyond-UI-GPUI-GPUIExtendedSystem-TryGetSubrootAnimationDuration0 = 2476,
		Beyond-UI-GPUI-GPUIExtendedSystem-_DisposeLoadedTextures0 = 2477,
		Beyond-UI-GPUI-GPUIExtendedSystem-OnDestroy0 = 2478,
		Beyond-UI-GPUI-GPUISharedGraphicBase-OnDestroy0 = 2479,
		Beyond-UI-GPUI-GPUISharedGraphicBase-CleanMaterials0 = 2480,
		Beyond-UI-GPUI-GPUIExtendedSystem-OnEnable0 = 2481,
		Beyond-UI-GPUI-GPUIExtendedSystem-_OnPreWillRenderCanvases0 = 2482,
		Beyond-UI-GPUI-GPUIExtendedSystem-_SyncDynamicAtlasRuntimeTexture0 = 2483,
		Beyond-UI-GPUI-GPUISharedGraphicBase-UpdateSharedTextures0 = 2484,
		Beyond-UI-GPUI-GPUIExtendedSystem-_DoLateUpdate0 = 2485,
		Beyond-UI-GPUI-GPUIExtendedSystem-_DestroyAnimatedInstance0 = 2486,
		Beyond-UI-GPUI-GPUIExtendedSystem-_RenderNodes0 = 2487,
		Beyond-UI-GPUI-GPUISharedGraphicBase-UpdateWorldMat0 = 2488,
		Beyond-UI-GPUI-GPUIExtendedSystem-_CanSubmitInstanceRange0 = 2489,
		Beyond-UI-GPUI-GPUIExtendedSystem-_Init0 = 2490,
		Beyond-UI-GPUI-GPUISharedGraphicBase-InitializeSharedState0 = 2491,
		Beyond-UI-GPUI-GPUISharedGraphicBase-InitMaterials0 = 2492,
		Beyond-UI-GPUI-GPUIExtendedSystem-_TryResolveAndValidateGroupBufferConfig0 = 2493,
		Beyond-UI-GPUI-GPUIExtendedSystem-_CalculateRequiredPrefabBufferSize0 = 2494,
		Beyond-UI-GPUI-GPUIExtendedSystem-_EnsureInstanceBufferManager0 = 2495,
		Beyond-UI-GPUI-GPUIExtendedSystem-_InitPrefabBufferManager0 = 2496,
		Beyond-UI-GPUI-GPUIExtendedSystem-_PreloadText0 = 2497,
		Beyond-UI-GPUI-GPUIExtendedSystem-_LoadGroupData0 = 2498,
		Beyond-UI-GPUI-GPUIExtendedSystem-_ResetLiveDynamicSpriteState0 = 2499,
		Beyond-UI-GPUI-GPUIExtendedSystem-_LoadPrefabData0 = 2500,
		Beyond-UI-GPUI-GPUIExtendedSystem-_LoadPrefabNodeBuffer0 = 2501,
		Beyond-UI-GPUI-GPUIExtendedSystem-_FindAnchorNodeIndex0 = 2502,
		Beyond-UI-GPUI-GPUIExtendedSystem-_InitDynamicPrefabNodeManager0 = 2503,
		Beyond-UI-GPUI-GPUIExtendedSystem-_UpdateLiveDynamicSpriteContext0 = 2504,
		Beyond-UI-GPUI-GPUIExtendedSystem-OnDisable0 = 2505,
		Beyond-UI-GPUI-GPUIHandle-Equals0 = 2506,
		Beyond-UI-GPUI-GPUIHandle-Equals1 = 2507,
		Beyond-UI-GPUI-GPUIHandle-GetHashCode0 = 2508,
		Beyond-UI-GPUI-GPUIHandle-op_Equality0 = 2509,
		Beyond-UI-GPUI-GPUIHandle-op_Inequality0 = 2510,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_prefabName0 = 2511,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_autoCreate0 = 2512,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_sortingOrder0 = 2513,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_targetSystem0 = 2514,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_syncManager0 = 2515,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_handle0 = 2516,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_hasInstance0 = 2517,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-IsHandleValid0 = 2518,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-SetSyncManager0 = 2519,
		Beyond-UI-GPUI-GPUIProxySyncManager-UnregisterProxy0 = 2520,
		Beyond-UI-GPUI-GPUIProxySyncManager-RegisterProxy0 = 2521,
		Beyond-UI-GPUI-GPUIProxySyncManager-_AutoAssignTargetSystem0 = 2522,
		Beyond-UI-GPUI-GPUIProxySyncManager-_RegisterToSystem0 = 2523,
		Beyond-UI-GPUI-GPUIProxySyncManager-_UnregisterFromSystem0 = 2524,
		Beyond-UI-GPUI-GPUIProxySyncManager-FlushBeforeRender0 = 2525,
		Beyond-UI-GPUI-GPUIProxySyncManager-_TryResolveCanvasContext0 = 2526,
		Beyond-UI-GPUI-GPUIProxySyncManager-_SnapshotAndCheckChanged0 = 2527,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-TryPrepareForBeforeRender0 = 2528,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-TryCreateInstance0 = 2529,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-TrySyncPosition1 = 2530,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_TryResolveTargetCanvas0 = 2531,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-TrySyncPosition0 = 2532,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_TryGetCanvasLocalPosition0 = 2533,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-MarkPositionDirty0 = 2534,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnInstanceCreated0 = 2535,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_TryResolveTargetSystem0 = 2536,
		Beyond-UI-GPUI-GPUIProxySyncManager-TryResolveTargetSystem0 = 2537,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_HandleTargetSystemChanged0 = 2538,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnInstanceDestroyed0 = 2539,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-TryDestroyInstance0 = 2540,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-Awake0 = 2541,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_CacheRectTransform0 = 2542,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnEnable0 = 2543,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_TryResolveSyncManager0 = 2544,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnDisable0 = 2545,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnRectTransformDimensionsChange0 = 2546,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnTransformParentChanged0 = 2547,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnDidApplyAnimationProperties0 = 2548,
		Beyond-UI-GPUI-GPUIProxySyncManager-get_targetSystem0 = 2549,
		Beyond-UI-GPUI-GPUIProxySyncManager-MarkDirty0 = 2550,
		Beyond-UI-GPUI-GPUIProxySyncManager-OnEnable0 = 2551,
		Beyond-UI-GPUI-GPUIProxySyncManager-OnDisable0 = 2552,
		Beyond-UI-GPUI-GPUISharedGraphicBase-OnPopulateMesh0 = 2553,
		Beyond-UI-GPUI-GPUISharedGraphicBase-UpdateMaterial0 = 2554,
		Beyond-UI-GPUI-GPUISubrootTag-get_subrootName0 = 2555,
		Beyond-UI-GPUI-GPUISystem-get_fontAsset0 = 2556,
		Beyond-UI-GPUI-GPUISystem-GetFontAsset0 = 2557,
		Beyond-UI-GPUI-GPUISystem-set_fontAsset0 = 2558,
		Beyond-UI-GPUI-GPUISystem-CreateInstance0 = 2559,
		Beyond-UI-GPUI-GPUISystem-_CreateInstance0 = 2560,
		Beyond-UI-GPUI-GPUISystem-_GetOneHandle0 = 2561,
		Beyond-UI-GPUI-RuntimeInstance-Create0 = 2562,
		Beyond-UI-GPUI-GPUISystem-SetRootPosition0 = 2563,
		Beyond-UI-GPUI-GPUISystem-_IsHandleInvalid0 = 2564,
		Beyond-UI-GPUI-RuntimeInstance-SetPosition0 = 2565,
		Beyond-UI-GPUI-GPUISystem-DestroyInstance0 = 2566,
		Beyond-UI-GPUI-GPUISystem-_DestroyInstance0 = 2567,
		Beyond-UI-GPUI-GPUISystem-_RecycleOneHandle0 = 2568,
		Beyond-UI-GPUI-GPUISystem-IsInstanceValid0 = 2569,
		Beyond-UI-GPUI-GPUISystem-SetRootScale0 = 2570,
		Beyond-UI-GPUI-RuntimeInstance-SetRootScale0 = 2571,
		Beyond-UI-GPUI-GPUISystem-StartAnimation0 = 2572,
		Beyond-UI-GPUI-RuntimeInstance-get_Prefab0 = 2573,
		Beyond-UI-GPUI-RuntimeInstance-StartAnimation0 = 2574,
		Beyond-UI-GPUI-RuntimeInstance-get_AnimationDuration0 = 2575,
		Beyond-UI-GPUI-GPUISystem-StartAnimation1 = 2576,
		Beyond-UI-GPUI-GPUISystem-SetVisibility0 = 2577,
		Beyond-UI-GPUI-GPUISystem-SetColor0 = 2578,
		Beyond-UI-GPUI-RuntimeInstance-SetColor0 = 2579,
		Beyond-UI-GPUI-GPUISystem-SetText0 = 2580,
		Beyond-UI-GPUI-RuntimeInstance-SetText0 = 2581,
		Beyond-UI-GPUI-GPUISystem-OnDestroy0 = 2582,
		Beyond-UI-GPUI-GPUISystem-_DoOnDestroy0 = 2583,
		Beyond-UI-GPUI-GPUISystem-_DisposeLoadedTextures0 = 2584,
		Beyond-UI-GPUI-GPUISystem-OnEnable0 = 2585,
		Beyond-UI-GPUI-GPUISystem-_PreWillRenderCanvases0 = 2586,
		Beyond-UI-GPUI-GPUISystem-_DoLateUpdate0 = 2587,
		Beyond-UI-GPUI-GPUISystem-_DestroyAnimatedInstance0 = 2588,
		Beyond-UI-GPUI-GPUISystem-_RenderNodes0 = 2589,
		Beyond-UI-GPUI-GPUISystem-_Init0 = 2590,
		Beyond-UI-GPUI-GPUISystem-_PreloadTextInGroupData0 = 2591,
		Beyond-UI-GPUI-GPUISystem-_LoadGroupData0 = 2592,
		Beyond-UI-GPUI-GPUISystem-_LoadPrefabData0 = 2593,
		Beyond-UI-GPUI-GPUISystem-_LoadPrefabNodeBuffer0 = 2594,
		Beyond-UI-GPUI-GPUISystem-OnDisable0 = 2595,
		Beyond-UI-GPUI-GPUISystem-OnPopulateMesh0 = 2596,
		Beyond-UI-GPUI-GPUISystem-UpdateMaterial0 = 2597,
		Beyond-UI-GPUI-GPUIUtils-CreateQuadMesh0 = 2598,
		Beyond-UI-GPUI-RuntimeInstance-Recycle0 = 2599,
		Beyond-UI-GPUI-RuntimeInstance-DoUpdate0 = 2600,
		Beyond-UI-GPUI-RuntimeInstance-SetVisibility0 = 2601
	}
}
