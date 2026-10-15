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
using IFix;
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

// Image 13: UI.Beyond.dll - Assembly: UI.Beyond, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 74315-75208

public class UIMinSizeAdjust : MonoBehaviour // TypeDefIndex: 74316
{
	// Fields
	[FormerlySerializedAs("m_panelRect")]
	[SerializeField]
	private RectTransform _panelRect; // 0x18

	// Constructors
	public UIMinSizeAdjust(); // 0x00000001878364A0-0x00000001878364B8

	// Methods
	private void Start(); // 0x000000018D1FD048-0x000000018D1FD050
	private void _SetTextureScaleByWidth(); // 0x000000018D1FD050-0x000000018D1FD270
}

[CompilerGenerated]
internal sealed class _PrivateImplementationDetails_ // TypeDefIndex: 74742
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize_24 FE78C65211DD0B56A97024FB61111E686EF1FE054AA132BA58E2891AC496F1EE; // 0x00 // Static value (base64): AAAAAAEAAAACAAAAAAAAAAIAAAADAAAA - Metadata: 0x026285B8

	// Nested types
	private struct __StaticArrayInitTypeSize_24 // TypeDefIndex: 74741
	{
	}
}

namespace Beyond.Gameplay.UI
{
	public class UIScrollCellCircleEffect : TickableUIMono // TypeDefIndex: 74328
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
		protected override TickType tickOption { get; } // 0x000000018D1FDC6C-0x000000018D1FDCB0 
		public LuaPanel panel { get; } // 0x000000018D1FDBAC-0x000000018D1FDC6C 
		public Transform lookAtCamera { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232C70-0x0000000187232C80 0x00000001887DE51C-0x00000001887DE530
	
		// Constructors
		public UIScrollCellCircleEffect(); // 0x000000018D1FDB9C-0x000000018D1FDBAC
	
		// Methods
		private void _InitState(); // 0x000000018D1FD728-0x000000018D1FD7D8
		private void _UpdatePos(); // 0x000000018D1FD9EC-0x000000018D1FDB9C
		private void _UpdateLookAtCamera(); // 0x000000018D1FD7D8-0x000000018D1FD9EC
		public void SetLookAtCamera(Transform faceCamera, bool update = true /* Metadata: 0x02627F6A */); // 0x000000018D1FD5B4-0x000000018D1FD640
		protected override void OnEnable(); // 0x000000018D1FD55C-0x000000018D1FD5B4
		private void Start(); // 0x000000018D1FD640-0x000000018D1FD6EC
		public override void Tick(float deltaTime); // 0x000000018D1FD6EC-0x000000018D1FD728
		public void ForceUpdate(); // 0x000000018D1FD4E8-0x000000018D1FD520
		public override void LateTick(float deltaTime); // 0x000000018D1FD520-0x000000018D1FD55C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class UIScrollCellSlantEffect : TickableUIMono // TypeDefIndex: 74329
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
		protected override TickType tickOption { get; } // 0x00000001869780A0-0x00000001869780D0 
	
		// Constructors
		public UIScrollCellSlantEffect(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		public override void Tick(float deltaTime); // 0x00000001854AC7A0-0x00000001854ACAC0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}
}

namespace Beyond.PoolCore
{
	public static class ListPoolInitializer_UI_Beyond // TypeDefIndex: 74319
	{
		// Fields
		private static bool s_initialized; // 0x00
	
		// Methods
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void InitializeAtRuntime(); // 0x00000001870C0530-0x00000001870C0560
		private static void Initialize(); // 0x00000001870C0560-0x00000001870C0620
	}
}

namespace Beyond.Scripts.UI.Tools
{
	[RequireComponent(typeof(GridLayoutGroup))]
	public class UIGridLayoutElement : MonoBehaviour, ILayoutElement // TypeDefIndex: 74327
	{
		// Fields
		private GridLayoutGroup m_gridLayoutGroup; // 0x18
	
		// Properties
		public float minWidth { get; } // 0x000000018D1F8F18-0x000000018D1F8FD0 
		public float preferredWidth { get; } // 0x000000018D1F9088-0x000000018D1F9140 
		public float flexibleWidth { get; } // 0x000000018D1F8DD8-0x000000018D1F8E1C 
		public float minHeight { get; } // 0x000000018D1F8E60-0x000000018D1F8F18 
		public float preferredHeight { get; } // 0x000000018D1F8FD0-0x000000018D1F9088 
		public float flexibleHeight { get; } // 0x000000018D1F8D94-0x000000018D1F8DD8 
		public int layoutPriority { get; } // 0x000000018D1F8E1C-0x000000018D1F8E60 
	
		// Constructors
		public UIGridLayoutElement(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void CalculateLayoutInputHorizontal(); // 0x000000018D1F8B28-0x000000018D1F8B5C
		public void CalculateLayoutInputVertical(); // 0x000000018D1F8B5C-0x000000018D1F8B90
		private float _GetPreferredSize(bool widthOrHeight); // 0x000000018D1F8B90-0x000000018D1F8D94
	}
}

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 74320
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 74321
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 74322
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 74323
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 74324
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 74325
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 74326
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Beyond.UI
{
	[AddComponentMenu("UI/UIText", 100)]
	public class UIText : TextMeshProUGUI, IPointerClickHandler, IUIClearable, ISerializationCallbackReceiver, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 74346
	{
		// Fields
		public RichTextStyleSeq richTextStyleSeq; // 0xBD8
		private bool m_textHasHyperlink; // 0xBDC
		private static readonly Regex RICH_TEXT_INNERMOST_REGEX; // 0x00
		private const int RICH_TEXT_RESOLVE_MAX_ITERATIONS = 128; // Metadata: 0x02627F6B
		private static readonly Regex HYPERLINK_TEXT_REGEX; // 0x08
		private static readonly Regex PHONETIC_REGEX; // 0x10
		public const string HYPERLINK_ID_PREFIX = "HPLK_"; // Metadata: 0x02627F6D
		[SerializeField]
		private bool _loadByCode; // 0xBDD
		[SerializeField]
		private string _textId; // 0xBE0
		[SerializeField]
		private bool _devOnly; // 0xBE8
		[SerializeField]
		private int _externalStaticWidth; // 0xBEC
		[SerializeField]
		private int _externalStaticHeight; // 0xBF0
		private bool m_firstSetByCode; // 0xBF4
		private static readonly HashSet<EnvLang> s_forceLeftAlignLanguage; // 0x18
		private List<RichTextInfo> m_richTextInfos; // 0xBF8
		private TickFunction m_updateFunction; // 0xC00
		[Obsolete("\u4F7F\u7528processRichTextEntryFunc\u5C5E\u6027\u4EE3\u66FF")]
		private RichTextAnalyzer.ProcessRichTextEntryFunc m_processRichTextEntryFunc; // 0xC08
		[HideInInspector]
		public UnityEvent<string> onClickLink; // 0xC10
		[HideInInspector]
		public UnityEvent<string, bool> onHoverLinkChange; // 0xC18
		private bool m_isPointerInside; // 0xC20
		private string m_curHoverLinkId; // 0xC28
		private List<string> m_linkList; // 0xC30
		private bool m_linkShrunk; // 0xC38
		[SerializeField]
		private string _hyperlinkUITextGroupId; // 0xC40
		[SerializeField]
		private int _hyperlinkUITextOrder; // 0xC48
		private HyperlinkUITextWrap m_hyperlinkUITextWrap; // 0xC50
		private LuaPanel m_panel; // 0xC58
		public int sourceCNFontId; // 0xC60
		private TMP_FontAsset m_i18nFontAsset; // 0xC68
		private static StringBuilder s_stringBuilder; // 0x20
		public bool useMinMaxSize; // 0xC70
		public Vector2 maxSize; // 0xC74
		public Vector2 minSize; // 0xC7C
		private readonly Queue<GameObject> m_inlineImagePool; // 0xC88
		private readonly Dictionary<int, ImageGOInfo> m_indexToImageGo; // 0xC90
		private const string INLINE_IMAGE_FOLDER_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/"; // Metadata: 0x02627F73
		private const string KEY_HINT_ICON_COMMON_FOLDER = "Assets/Beyond/InitialAssets/UI/Sprites/"; // Metadata: 0x02627FA4
		private readonly Dictionary<string, FAssetProxyHandle> m_imageCache; // 0xC98
		private readonly Dictionary<int, bool> m_delayedActiveChangeImageGOIndexes; // 0xCA0
	
		// Properties
		public string textId { get; } // 0x0000000187225110-0x0000000187225140 
		public override string text { get; set; } // 0x0000000185A09320-0x0000000185A09360 0x0000000185A09180-0x0000000185A09260
		protected override bool autoSizeCacheEnabled { get; } // 0x000000018527F590-0x000000018527F630 
		private RichTextAnalyzer.ProcessRichTextEntryFunc processRichTextEntryFunc { get; } // 0x000000018536AEF0-0x000000018536AFC0 
		public LuaPanel panel { get; } // 0x00000001857EED00-0x00000001857EEDB0 
		public override TMP_FontAsset m_fontAsset { get; set; } // 0x0000000185103110-0x0000000185103280 0x000000018D1FEED4-0x000000018D1FF194
		public override Material fontSharedMaterial { get; set; } // 0x00000001862F4500-0x00000001862F4530 0x000000018D1FEE20-0x000000018D1FEED4
	
		// Nested types
		private abstract class RichTextInfo // TypeDefIndex: 74330
		{
			// Fields
			public int index; // 0x10
	
			// Constructors
			protected RichTextInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class InlineImageInfo : RichTextInfo // TypeDefIndex: 74331
		{
			// Fields
			public string path; // 0x18
			public float width; // 0x20
			public float height; // 0x24
			public UnityEngine.Color color; // 0x28
	
			// Constructors
			public InlineImageInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private enum RichTextTagType // TypeDefIndex: 74332
		{
			Image = 1,
			Width = 2,
			Height = 3,
			Scale = 4,
			Color = 5
		}
	
		public enum RichTextStyleSeq // TypeDefIndex: 74333
		{
			NORMAL = 0,
			DARK_BACKGROUND = 1,
			LIGHT_BACKGROUND = 2
		}
	
		private static class RichTextAnalyzer // TypeDefIndex: 74339
		{
			// Fields
			private const char CUSTOM_RICH_TEXT_LEFT_BRACKET = '<'; // Metadata: 0x02627FD4
			private const char CUSTOM_RICH_TEXT_RIGHT_BRACKET = '>'; // Metadata: 0x02627FD6
			private static readonly Dictionary<int, RichTextTag> s_tagToTypeDic; // 0x00
			private static readonly Dictionary<int, RichTextTag> s_tagAttributeToTypeDic; // 0x08
			public const string FONT_SHADOW_OPENING_TAG = "<shadow>"; // Metadata: 0x02627FD8
			public const string FONT_SHADOW_CLOSING_TAG = "</shadow>"; // Metadata: 0x02627FE1
			public const string FONT_MAT_OPENING_TAG = "<material=\"DefaultFont_3500_RichText_Shadow\">"; // Metadata: 0x02627FEB
			public const string FONT_MAT_CLOSING_TAG = "</material>"; // Metadata: 0x02628019
			private static readonly List<RichTextParam> s_subParams; // 0x10
	
			// Nested types
			public enum ParamValueType // TypeDefIndex: 74334
			{
				None = 0,
				String = 1,
				Int = 2,
				Float = 3,
				Color = 4
			}
	
			public struct RichTextTag // TypeDefIndex: 74335
			{
				// Fields
				public RichTextTagType richTextTagType; // 0x00
				public Beyond.UI.UIText.RichTextAnalyzer.ParamValueType paramValueType; // 0x04
			}
	
			public struct RichTextParam // TypeDefIndex: 74336
			{
				// Fields
				public RichTextTagType richTextTagType; // 0x00
				public AnyTypeStruct value; // 0x08
			}
	
			public struct AnyTypeStruct // TypeDefIndex: 74337
			{
				// Fields
				public int intValue; // 0x00
				public float floatValue; // 0x00
				public string stringValue; // 0x00
				public UnityEngine.Color colorValue; // 0x00
			}
	
			public delegate RichTextInfo ProcessRichTextEntryFunc(RichTextParam mainParam, List<RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder); // TypeDefIndex: 74338; 0x0000000184175D60-0x0000000184175DA0
	
			// Constructors
			static RichTextAnalyzer(); // 0x0000000186CF73D0-0x0000000186CF76D0
	
			// Methods
			public static string PreAnalyzeRichText(string text, bool needParseActionId); // 0x000000018536A690-0x000000018536A740
			public static string AnalyzeRichText(string text, ProcessRichTextEntryFunc processFunc, out List<RichTextInfo> infos); // 0x00000001850C12C0-0x00000001850C1870
			private static bool _TryParseRichTextEntry(ReadOnlySpan<char> span, ref Utf16ValueStringBuilder stringBuilder, ProcessRichTextEntryFunc processFunc, out RichTextInfo richTextInfo); // 0x0000000185A1B9B0-0x0000000185A1BCE0
			private static bool _TryParseParam(ReadOnlySpan<char> span, out bool isMain, out RichTextParam param); // 0x0000000185A1BF40-0x0000000185A1C440
			public static RichTextInfo ProcessRichTextEntryFallback(RichTextParam mainParam, List<RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder); // 0x000000018D1F8628-0x000000018D1F8688
			public static int GetCharacterCountWithoutRichText(ReadOnlySpan<char> str); // 0x00000001864306D0-0x0000000186430940
			private static int _GetHashCode(ReadOnlySpan<char> str); // 0x0000000185A1C440-0x0000000185A1C4B0
		}
	
		private class HyperlinkUITextWrap // TypeDefIndex: 74340
		{
			// Fields
			public UIText uiText; // 0x10
			public string hyperlinkUITextGroupId; // 0x18
			public int order; // 0x20
			public bool isDisplayable; // 0x24
	
			// Constructors
			public HyperlinkUITextWrap(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Clear(); // 0x0000000186B04BD0-0x0000000186B04C60
		}
	
		private class HyperlinkUITextGroup // TypeDefIndex: 74341
		{
			// Fields
			public HashSet<HyperlinkUITextWrap> wrapSet; // 0x10
			public string groupId; // 0x18
			public int displayableCount; // 0x20
	
			// Constructors
			public HyperlinkUITextGroup(); // 0x0000000187065210-0x00000001870652B0
	
			// Methods
			public void Add(HyperlinkUITextWrap wrap); // 0x000000018634F2E0-0x000000018634F380
			public void Remove(HyperlinkUITextWrap wrap); // 0x000000018634F380-0x000000018634F420
			public void ChangeDisplayable(HyperlinkUITextWrap wrap, bool displayable); // 0x000000018634EE60-0x000000018634EEB0
			private void _AddDisplayableCount(); // 0x000000018634F420-0x000000018634F460
			private void _SubDisplayableCount(); // 0x000000018634F460-0x000000018634F4A0
			private void _NotifyDisplayableChanged(); // 0x000000018634F4A0-0x000000018634F570
		}
	
		private class HyperlinkUITextManager // TypeDefIndex: 74343
		{
			// Fields
			private Dictionary<string, HyperlinkUITextGroup> m_hyperlinkUITextGroupMap; // 0x10
			private ObjectPool<HyperlinkUITextGroup> m_hyperlinkUITextGroupPool; // 0x18
			private ObjectPool<HyperlinkUITextWrap> m_hyperlinkUITextWrapPool; // 0x20
			private static HyperlinkUITextManager s_instance; // 0x00
			private static readonly List<HyperlinkUITextWrap> SORT_WRAP_TEMP_LIST; // 0x08
	
			// Properties
			public static HyperlinkUITextManager instance { get; } // 0x00000001852EB510-0x00000001852EB610 
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c // TypeDefIndex: 74342
			{
				// Fields
				public static readonly __c __9; // 0x00
				public static Comparison<HyperlinkUITextWrap> __9__13_0; // 0x08
				public static Action<HyperlinkUITextGroup> __9__16_0; // 0x10
				public static Action<HyperlinkUITextWrap> __9__16_1; // 0x18
	
				// Constructors
				static __c(); // 0x00000001871E62C0-0x00000001871E6320
				public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
				// Methods
				internal int _GetGroupDisplayableUIText_b__13_0(HyperlinkUITextWrap a, HyperlinkUITextWrap b); // 0x000000018D1F876C-0x000000018D1F888C
				internal void _.ctor_b__16_0(HyperlinkUITextGroup group); // 0x0000000186EC52B0-0x0000000186EC5310
				internal void _.ctor_b__16_1(HyperlinkUITextWrap wrap); // 0x0000000186B04BB0-0x0000000186B04BD0
			}
	
			// Constructors
			public HyperlinkUITextManager(); // 0x0000000186D49FD0-0x0000000186D4A470
			static HyperlinkUITextManager(); // 0x000000018716EEB0-0x000000018716EF50
	
			// Methods
			public void AddWrap(UIText uiText, string groupId, int order); // 0x000000018634F090-0x000000018634F1C0
			public void RemoveWrap(UIText uiText); // 0x00000001852EB610-0x00000001852EB720
			public void ChangeWrapGroup(HyperlinkUITextWrap wrap, string newGroupId, int newOrder); // 0x000000018D1F6E60-0x000000018D1F6FCC
			public void ChangeWrapOrder(HyperlinkUITextWrap wrap, int newOrder); // 0x000000018D1F6FCC-0x000000018D1F7020
			public void UpdateWrapDisplayable(UIText uiText); // 0x00000001852EAAF0-0x00000001852EABB0
			public bool IsGroupDisplayable(string groupId); // 0x000000018634EF40-0x000000018634EF80
			public List<UIText> GetGroupDisplayableUIText(string groupId); // 0x000000018D1F7020-0x000000018D1F7518
			private HyperlinkUITextGroup _GetGroup(string groupId, bool autoCreate = false /* Metadata: 0x0262802A */); // 0x000000018634F1C0-0x000000018634F2E0
			private bool _IsUITextDisplayable(UIText uiText); // 0x00000001852EABB0-0x00000001852EAC10
		}
	
		private struct ImageGOInfo // TypeDefIndex: 74344
		{
			// Fields
			public GameObject go; // 0x00
			public RectTransform rectTransform; // 0x08
			public Image image; // 0x10
		}
	
		[CompilerGenerated]
		private sealed class __DelayedChangeActiveImageGo_d__119 : IEnumerator<object> // TypeDefIndex: 74345
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIText __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DelayedChangeActiveImageGo_d__119(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000184E4BBC0-0x0000000184E4D160
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x0000000184E4D160-0x0000000184E4D1B0
		}
	
		// Constructors
		static UIText(); // 0x0000000185EC03C0-0x0000000185EC2220
		public UIText(); // 0x000000018548E350-0x000000018548EA40
	
		// Methods
		public void SetAndResolveTextStyle(string targetText); // 0x0000000185A09380-0x0000000185A09470
		public static string GetPhoneticText(PhoneticType phoneticType, string id); // 0x0000000185A57160-0x0000000185A57350
		public void SetPhoneticText(PhoneticType phoneticType, string id); // 0x0000000185A570E0-0x0000000185A57160
		private static string _ResolveTextStyle(string text, int richSeqIndex); // 0x0000000185A09470-0x0000000185A09910
		private static string _GetHyperlinkText(string text, out bool hasLink); // 0x0000000185A09C60-0x0000000185A0A930
		public static void OnEnvLangChanged(EnvLang lang); // 0x000000018671D760-0x000000018671D840
		private void _CreateUpdateFunction(); // 0x0000000185C2D4D0-0x0000000185C2D610
		private void _ReleaseUpdateFunction(); // 0x00000001852ECB90-0x00000001852ECC00
		public override void ClearMesh(); // 0x0000000186494510-0x00000001864947C0
		public override void RefreshPopulateText(); // 0x000000018536A320-0x000000018536A580
		protected override Material LoadMaterial(string materialName); // 0x000000018D1FDEAC-0x000000018D1FDFBC
		protected override void OnDestroy(); // 0x00000001852EE470-0x00000001852EE510
		protected override void Awake(); // 0x0000000185103D90-0x00000001851042C0
		protected TMP_FontAsset GetFontAsset(); // 0x0000000185103280-0x00000001851032F0
		private void _GenerateRuntimeText(); // 0x0000000185A09030-0x0000000185A09180
		private void _ProcessRichTextInfo(); // 0x000000018536AFC0-0x000000018536B3A0
		private void _OnPreRenderText(TMP_TextInfo textInfo); // 0x0000000185862930-0x0000000185862E80
		private RichTextInfo _ProcessRichTextEntry(RichTextAnalyzer.RichTextParam mainParam, List<RichTextAnalyzer.RichTextParam> subParams, ref Utf16ValueStringBuilder stringBuilder); // 0x000000018642FA50-0x0000000186430630
		public void OnPointerClick(PointerEventData eventData); // 0x000000018D1FE1A4-0x000000018D1FE630
		public void OnPointerEnter(PointerEventData eventData); // 0x0000000186EB7350-0x0000000186EB7470
		public void OnPointerExit(PointerEventData eventData); // 0x000000018702B360-0x000000018702B420
		protected override void Start(); // 0x000000018634EF80-0x000000018634EFD0
		protected override void OnEnable(); // 0x00000001852EAC10-0x00000001852EAD30
		protected override void OnDisable(); // 0x00000001852EC6A0-0x00000001852ECB90
		private void _UpdateTick(float deltaTime); // 0x00000001857EE9E0-0x00000001857EEBB0
		public void ShrinkLinkTags(); // 0x0000000186C49310-0x0000000186C49690
		[IDTag(0)]
		public bool TryGetLinkId(Vector3 position, out string linkId); // 0x00000001857EEBB0-0x00000001857EED00
		[IDTag(1)]
		public bool TryGetLinkId(int linkIndex, out string linkId); // 0x000000018D1FEB24-0x000000018D1FEC88
		public bool TryGetOriginalLinkId(string linkId, out string originalLinkId); // 0x000000018D1FEC88-0x000000018D1FED78
		public bool TryGetCharacterStartPosAndHeight(int charIndex, out Vector3 worldPos, out float charHeight); // 0x000000018D1FE984-0x000000018D1FEB24
		public bool TryGetCharacterEndPosAndHeight(int charIndex, out Vector3 worldPos, out float charHeight); // 0x000000018D1FE7E4-0x000000018D1FE984
		public void CombineStringWithLanguageSpilt<T1, T2>(T1 t1, T2 t2);
		public void CombineStringWithLanguageSpilt(string t1, string t2); // 0x000000018D1FDD64-0x000000018D1FDE18
		public void CombineStringReverseForIndonesianAndVietnamese<T1, T2>(T1 t1, T2 t2);
		public void CombineStringReverseForIndonesianAndVietnamese(string t1, string t2); // 0x000000018D1FDCB0-0x000000018D1FDD64
		public void SetHyperlinkUITextGroup(string groupId, int order); // 0x000000018634EFD0-0x000000018634F090
		public static bool IsHyperlinkUITextGroupDisplayable(string groupId); // 0x000000018634EEB0-0x000000018634EF40
		public static List<UIText> GetGroupDisplayableHyperlinkUIText(string groupId); // 0x000000018D1FDE18-0x000000018D1FDEAC
		public void ClearComponent(); // 0x00000001852EB280-0x00000001852EB510
		public void UpdateI18NFontAsset(); // 0x0000000185730050-0x0000000185730410
		private void _RefreshMatTexture(); // 0x0000000185101DD0-0x0000000185102210
		protected override void SetSharedMaterial(Material mat); // 0x000000018D1FE630-0x000000018D1FE7E4
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018612A270-0x000000018612A710
		public void OnAfterDeserialize(); // 0x0000000186227EE0-0x0000000186227F10
		protected override TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference); // 0x0000000185A063B0-0x0000000185A064B0
		public static string LocalStringCombineFormat(int count); // 0x000000018D1FDFBC-0x000000018D1FE1A4
		protected override Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled); // 0x00000001857E8400-0x00000001857E84C0
		protected Sprite GetOrLoadSprite(string path); // 0x0000000186430C70-0x0000000186430F50
		protected void DisposeInlineImageCache(); // 0x00000001852EB720-0x00000001852EBA10
		private void _ClearInlineImage(); // 0x000000018536B3A0-0x000000018536B930
		private ImageGOInfo _GetImageGoByIndex(int index); // 0x00000001865424D0-0x0000000186542680
		private GameObject _GetOrCreateImageGO(); // 0x0000000186542680-0x0000000186542890
		private void _ReturnImageGO(GameObject go); // 0x0000000186E16980-0x0000000186E16A80
		[IteratorStateMachine(typeof(__DelayedChangeActiveImageGo_d__119))]
		private IEnumerator _DelayedChangeActiveImageGo(); // 0x0000000186DFDED0-0x0000000186DFDF60
		public string __iFixBaseProxy_get_text(); // 0x000000018D1FEE08-0x000000018D1FEE10
		public void __iFixBaseProxy_set_text(string P0); // 0x000000018D1FEE18-0x000000018D1FEE20
		public void __iFixBaseProxy_ClearMesh(); // 0x000000018D1FEDD8-0x000000018D1FEDE0
		public void __iFixBaseProxy_RefreshPopulateText(); // 0x000000018D1FEDF8-0x000000018D1FEE00
		public Material __iFixBaseProxy_LoadMaterial(string P0); // 0x0000000185829EC0-0x0000000185829ED0
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D1FEDE0-0x000000018D1FEDE8
		public bool __iFixBaseProxy_get_autoSizeCacheEnabled(); // 0x00000001843FFFF0-0x0000000184400000
		public void __iFixBaseProxy_Awake(); // 0x000000018D1FEDB8-0x000000018D1FEDC0
		public void __iFixBaseProxy_Start(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D1FEDF0-0x000000018D1FEDF8
		public void __iFixBaseProxy_OnDisable(); // 0x000000018D1FEDE8-0x000000018D1FEDF0
		public TMP_FontAsset __iFixBaseProxy_get_m_fontAsset(); // 0x000000018723B410-0x000000018723B420
		public void __iFixBaseProxy_set_m_fontAsset(TMP_FontAsset P0); // 0x000000018783BFB4-0x000000018783BFC8
		public Material __iFixBaseProxy_get_fontSharedMaterial(); // 0x000000018723B5D0-0x000000018723B5E0
		public void __iFixBaseProxy_set_fontSharedMaterial(Material P0); // 0x000000018D1FEE10-0x000000018D1FEE18
		public void __iFixBaseProxy_SetSharedMaterial(Material P0); // 0x000000018D1FEE00-0x000000018D1FEE08
		public TMP_SubMeshUI __iFixBaseProxy_AddSubTextObject(TextMeshProUGUI P0, MaterialReference P1); // 0x000000018D1FED78-0x000000018D1FEDB8
		public Vector2 __iFixBaseProxy_CalculatePreferredValues(ref float P0, Vector2 P1, bool P2, bool P3); // 0x000000018D1FEDC0-0x000000018D1FEDD8
	}

	public static class UIConst // TypeDefIndex: 74349
	{
		// Fields
		public const float PC_REFERENCE_RESOLUTION_SCALE = 1.25f; // Metadata: 0x0262802B
		public const float MOBILE_PAD_DEVICE_REFERENCE_RESOLUTION_SCALE = 1.1f; // Metadata: 0x0262802F
		public static readonly Vector3 OUT_OF_SCREEN_POS; // 0x00
		public const float STANDARD_HORIZONTAL_RESOLUTION = 1920f; // Metadata: 0x02628033
		public const float STANDARD_VERTICAL_RESOLUTION = 1080f; // Metadata: 0x02628037
		public const int INVALID_FINGER_ID = 2147483647; // Metadata: 0x0262803B
		public static float STANDARD_RATIO; // 0x0C
		public const float SCREEN_SPACE_CAMERA_PANEL_DISTANCE = 30f; // Metadata: 0x0262803C
		public const string UI_BLUR_MATERIAL = "Assets/Beyond/Arts/UI/Materials/M_ui_blur.mat"; // Metadata: 0x02628040
		public const string CS_POPUP_PANEL_PATH = "Assets/Beyond/DynamicAssets/Gameplay/UI/CSPrefabs/CSPopupPanel.prefab"; // Metadata: 0x0262806E
		public const string NAVIGATION_TARGET_CLICK_NO_HINT_ACTION_ID = "navigation_target_click_no_hint"; // Metadata: 0x026280B5
		public const string NAVIGATION_TARGET_CLICK_ACTION_ID = "navigation_target_click"; // Metadata: 0x026280D5
		public const string UI_SPRITE_CHAR_HEAD_RECTANGLE = "CharIcon"; // Metadata: 0x026280ED
		public const string UI_SPRITE_CHAR_REMOTE_ICON = "CharRemoteIcon"; // Metadata: 0x026280F6
		public const string UI_SPRITE_CHAR_REMOTE_ICON_700 = "CharRemoteIcon700"; // Metadata: 0x02628105
		public const string UI_SPRITE_DIALOG_BG = "Dialog/BG"; // Metadata: 0x02628117
		public const string UI_SPRITE_DIALOG_OPTION_ICON = "Dialog/Option"; // Metadata: 0x02628121
		public const string SLIDER_STICK_SCROLL_HORI_ACTION_ID = "slider_stick_scroll_hori"; // Metadata: 0x0262812F
		public const string SLIDER_LEFT_STICK_SCROLL_HORI_ACTION_ID = "slider_left_stick_scroll_hori"; // Metadata: 0x02628148
	
		// Properties
		public static int STANDARD_HORIZONTAL_RESOLUTION_INT { get; } // 0x000000018D1F8A18-0x000000018D1F8A60 
		public static int STANDARD_VERTICAL_RESOLUTION_INT { get; } // 0x000000018D1F8A60-0x000000018D1F8AA8 
		public static float CUR_STANDARD_HORIZONTAL_RESOLUTION { get; } // 0x0000000185195040-0x00000001851950B0 
		public static float CUR_STANDARD_VERTICAL_RESOLUTION { get; } // 0x00000001851950B0-0x0000000185195120 
		public static int dragThreshold { get; } // 0x000000018D1F8AA8-0x000000018D1F8B28 
	
		// Nested types
		public enum AnimationState // TypeDefIndex: 74347
		{
			Stop = 1,
			In = 2,
			Loop = 3,
			Out = 4,
			InEasing = 5,
			Others = 6
		}
	
		public enum CommonUISegment // TypeDefIndex: 74348
		{
			InteractiveEntity = 1,
			LevelScriptModule = 2
		}
	
		// Constructors
		static UIConst(); // 0x00000001871DF500-0x00000001871DF570
	
		// Methods
		public static float GetResolutionScale(); // 0x00000001851976B0-0x0000000185197710
		public static bool IsPadDevice(); // 0x000000018D1F88D8-0x000000018D1F8A18
	}

	public class UIModelLoader : IDisposable // TypeDefIndex: 74351
	{
		// Fields
		private Dictionary<GameObject, FAssetProxyHandle> m_instance2AssetHandle; // 0x10
		private int m_requestCounter; // 0x18
		private HashSet<int> m_requestIds; // 0x20
		private bool m_disposed; // 0x28
		private static List<MagicaBoneCloth> s_magicaBoneCloths; // 0x00
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0 // TypeDefIndex: 74350
		{
			// Fields
			public UIModelLoader __4__this; // 0x10
			public int requestId; // 0x18
			public FAssetProxyHandle handle; // 0x1C
			public string modelPath; // 0x30
			public Transform parent; // 0x38
			public Action<GameObject> callback; // 0x40
	
			// Constructors
			public __c__DisplayClass7_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _LoadModelAsync_b__0(FAssetProxyUntrackedHandle proxy); // 0x00000001855F92A0-0x00000001855F97B0
		}
	
		// Constructors
		public UIModelLoader(); // 0x0000000186996450-0x00000001869967F0
		static UIModelLoader(); // 0x00000001871766A0-0x0000000187176730
	
		// Methods
		public GameObject LoadModel(string modelPath, Transform parent); // 0x000000018D1FD304-0x000000018D1FD4E8
		public int LoadModelAsync(string modelPath, Transform parent, Action<GameObject> callback); // 0x0000000186B0C3F0-0x0000000186B0C5E0
		public void Cancel(int requestId); // 0x000000018D1FD270-0x000000018D1FD304
		public void UnloadModel(GameObject modelGo); // 0x0000000186CD2720-0x0000000186CD2880
		private void _Clear(); // 0x00000001866F2C50-0x00000001866F31D0
		public void Dispose(); // 0x00000001866F2C10-0x00000001866F2C50
	}

	public static class UIUtils // TypeDefIndex: 74352
	{
		// Fields
		private const int MAX_SHARED_INT_STRING = 255; // Metadata: 0x0262816E
		private static readonly string[] s_sharedIntStringPool; // 0x00
		private const int MAX_SHARED_INT_ROMAN_STRING = 16; // Metadata: 0x02628170
		private static readonly string[] s_sharedIntStringRomanPool; // 0x08
		private static Vector3[] s_worldCorners; // 0x10
		private const string RICH_TEXT_PATTERN = "<.*?>"; // Metadata: 0x02628171
	
		// Constructors
		static UIUtils(); // 0x00000001870A8340-0x00000001870A8430
	
		// Methods
		public static string GetSharedIntString(int value); // 0x0000000185FCE8D0-0x0000000185FCE9E0
		public static string GetSharedIntStringRoman(int value); // 0x000000018D1FF628-0x000000018D1FF7A4
		[IDTag(0)]
		public static bool IsScreenPosInRectTransform(Vector3 screenPos, RectTransform rectTransform, Camera uiCamera); // 0x0000000185E58340-0x0000000185E586D0
		[IDTag(1)]
		public static bool IsScreenPosInRectTransform(Vector2 screenPos, RectTransform rectTransform, Camera uiCamera); // 0x0000000185A596D0-0x0000000185A59890
		public static Bounds CalcBoundOfRectTransform(RectTransform transform, RectTransform local); // 0x00000001866425F0-0x0000000186642A30
		public static bool TryGetTouch(int touchId, out UnityEngine.InputSystem.EnhancedTouch.Touch touch); // 0x000000018D1FFA24-0x000000018D1FFC4C
		public static void ClearUIComponents(GameObject gameObject); // 0x00000001852EAD30-0x00000001852EB280
		public static Rect RectTransformToScreenRect(RectTransform rectTransform, Camera uiCamera); // 0x0000000185C89E00-0x0000000185C8A5E0
		public static Vector2 ClampPointInRectTransform(RectTransform source, RectTransform target, Vector2 sourcePoint); // 0x000000018D1FF194-0x000000018D1FF33C
		public static Vector3 GetNodeScaleOffset(RectTransform referenceTransform, RectTransform selfTransform); // 0x0000000186AEB340-0x0000000186AEB5D0
		public static UnityEngine.Color GetColorByString(string strColor); // 0x000000018D1FF33C-0x000000018D1FF558
		public static float GetCursorTipOffsetX(float defaultOffset); // 0x000000018D1FF588-0x000000018D1FF628
		public static float GetCursorTipOffsetInScreen(float defaultOffsetInScreen); // 0x000000018D1FF558-0x000000018D1FF588
		public static bool TryGetTextWithoutRichStyle(string richText, out string rawText); // 0x000000018D1FF90C-0x000000018D1FFA24
	
		// Extension methods
		public static void SetAlpha(this Graphic image, float alpha); // 0x00000001853570D0-0x0000000185357180
		public static void SetColorWithoutAlpha(this Graphic image, UnityEngine.Color color); // 0x000000018D1FF7A4-0x000000018D1FF83C
		public static void SetMaskRatio(this RectMask2D mask, float r); // 0x000000018D1FF83C-0x000000018D1FF90C
	}

	public class ActiveSyncHelper : MonoBehaviour // TypeDefIndex: 74353
	{
		// Fields
		[SerializeField]
		private List<GameObject> _objs; // 0x18
		[SerializeField]
		private bool _isInverse; // 0x20
	
		// Constructors
		public ActiveSyncHelper(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		private void Awake(); // 0x00000001865E73D0-0x00000001865E7400
		private void OnEnable(); // 0x00000001865E7430-0x00000001865E7460
		private void OnDisable(); // 0x00000001865E7400-0x00000001865E7430
		public void Sync(); // 0x00000001865E7460-0x00000001865E7670
	}

	public class Billboard : TickableUIMono // TypeDefIndex: 74354
	{
		// Fields
		public Camera sceneCamera; // 0x68
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D1F6458-0x000000018D1F649C 
	
		// Constructors
		public Billboard(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		protected override void OnEnable(); // 0x000000018D1F62D8-0x000000018D1F6384
		public override void Tick(float deltaTime); // 0x000000018D1F6384-0x000000018D1F6458
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	[AddComponentMenu("")]
	[ExecuteAlways]
	[SaveDuringPlay]
	public class CinemachineGyroscopeEffect : CinemachineExtension // TypeDefIndex: 74355
	{
		// Fields
		public float offsetX; // 0x28
		public float offsetY; // 0x2C
	
		// Constructors
		public CinemachineGyroscopeEffect(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime); // 0x0000000186254550-0x0000000186254830
	}

	public class CommonItemToastList : UIScrollList // TypeDefIndex: 74356
	{
		// Constructors
		public CommonItemToastList(); // 0x00000001871CB370-0x00000001871CB3C0
	
		// Methods
		public new void ScrollToIndex(int index = -1 /* Metadata: 0x02628177 */, bool fastMode = false /* Metadata: 0x02628178 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02628179 */, bool graduallyShowInFastMode = false /* Metadata: 0x0262817A */); // 0x0000000185C8FDF0-0x0000000185C8FE50
		protected void AdjustContainerPos(int index = -1 /* Metadata: 0x0262817B */, bool fastMode = false /* Metadata: 0x0262817C */); // 0x0000000185C87EB0-0x0000000185C88060
		private Vector2 _GetUnConstraintTargetPos(int index = -1 /* Metadata: 0x0262817D */); // 0x0000000185C87DF0-0x0000000185C87EB0
		[CompilerGenerated]
		private Vector2 _AdjustContainerPos_b__1_0(); // 0x0000000186D32BD0-0x0000000186D32C00
		[CompilerGenerated]
		private void _AdjustContainerPos_b__1_1(Vector2 x); // 0x0000000186A1AC90-0x0000000186A1ACC0
	}

	public class ControllerSideMenuItemList : MonoBehaviour // TypeDefIndex: 74358
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
		public class MeunItemInfo // TypeDefIndex: 74357
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
			public bool isForceValid { get; } // 0x000000018D1F7D78-0x000000018D1F7E04 
	
			// Constructors
			public MeunItemInfo(); // 0x000000018723CE70-0x000000018723CE80
	
			// Methods
			public bool IsValid(); // 0x000000018D1F7C58-0x000000018D1F7D78
			public string GetText(); // 0x000000018D1F7B2C-0x000000018D1F7C58
			public Sprite GetSprite(); // 0x000000018D1F7A18-0x000000018D1F7B2C
			public void Execute(); // 0x000000018D1F7798-0x000000018D1F7910
			public string GetItemName(); // 0x000000018D1F7910-0x000000018D1F7A18
		}
	
		// Constructors
		public ControllerSideMenuItemList(); // 0x0000000186D161B0-0x0000000186D16250
		static ControllerSideMenuItemList(); // 0x0000000187178E00-0x0000000187178E90
	
		// Methods
		public static void ToggleItemForceValid(string itemName, bool forceValid); // 0x000000018D1F66EC-0x000000018D1F6814
		public static bool IsItemForceValid(string itemName); // 0x000000018D1F6640-0x000000018D1F66EC
		public static void ClearForceValidItemList(); // 0x000000018D1F65A4-0x000000018D1F6640
	}

	public sealed class CustomNotchAdapt : MonoBehaviour // TypeDefIndex: 74359
	{
		// Fields
		public bool isLeft; // 0x18
		public bool isRight; // 0x19
		public bool isBottom; // 0x1A
		public bool isFullHorizontalStretch; // 0x1B
	
		// Constructors
		public CustomNotchAdapt(); // 0x000000018548CC60-0x000000018548CC80
	}

	public enum UIStyleInputValidType // TypeDefIndex: 74360
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
	public enum UIStyleInputValidTypeMask // TypeDefIndex: 74361
	{
		Keyboard = 2,
		Touch = 4,
		Controller = 8,
		All = 14
	}

	public enum ActiveType // TypeDefIndex: 74362
	{
		UseGameObjectActive = 0,
		UseScale = 1
	}

	public class CustomUIStyle : MonoBehaviour // TypeDefIndex: 74364
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
		public UIStyleInputValidTypeMask inputValidTypeMask { get; set; } // 0x000000018D1F6910-0x000000018D1F6994 0x000000018D1F69D4-0x000000018D1F6A58
		public OverrideValidState overrideValidState { get; set; } // 0x000000018D1F6994-0x000000018D1F69D4 0x0000000186211BC0-0x0000000186211BF0
		public bool isValid { get; } // 0x0000000186211C90-0x0000000186211CE0 
	
		// Nested types
		public enum OverrideValidState // TypeDefIndex: 74363
		{
			None = 0,
			ForceValid = 1,
			ForceNotValid = 2
		}
	
		// Constructors
		public CustomUIStyle(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		private void _OnActiveTypeChanged(); // 0x000000018D1F6814-0x000000018D1F6910
		private void OnDestroy(); // 0x0000000185AB73C0-0x0000000185AB7470
		private void OnEnable(); // 0x0000000186211BF0-0x0000000186211C20
		private void Awake(); // 0x000000018596FCD0-0x000000018596FD80
		public void CheckState(); // 0x0000000186211C20-0x0000000186211C90
		public void ToggleActiveState(bool isActive); // 0x0000000186211D90-0x0000000186211F40
		public static bool IsShowTypeValid(UIStyleInputValidType inputValidType); // 0x0000000186211CE0-0x0000000186211D90
		public static bool IsValidInput(UIStyleInputValidTypeMask inputValidTypeMask); // 0x00000001859701B0-0x0000000185970210
	}

	public class DeactivateNaviOnEnable : MonoBehaviour // TypeDefIndex: 74365
	{
		// Fields
		public string key; // 0x18
	
		// Constructors
		public DeactivateNaviOnEnable(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnEnable(); // 0x000000018D1F6AF4-0x000000018D1F6B90
		private void OnDisable(); // 0x000000018D1F6A58-0x000000018D1F6AF4
	}

	[RequireComponent(typeof(LayoutElement))]
	public class DecoLineActiveHelper : TickableUIMono // TypeDefIndex: 74366
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
		protected override TickType tickOption { get; } // 0x00000001862ADFA0-0x00000001862ADFD0 
	
		// Constructors
		public DecoLineActiveHelper(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		private void Reset(); // 0x000000018D1F6B90-0x000000018D1F6C0C
		protected override void OnEnable(); // 0x000000018647D850-0x000000018647D8E0
		public override void LateTick(float deltaTime); // 0x0000000185140590-0x0000000185140E00
		public void Sync(); // 0x000000018D1F6C0C-0x000000018D1F6C3C
		private bool _HasActiveTarget(List<GameObject> targets); // 0x000000018D1F6C3C-0x000000018D1F6D0C
		private void _ToggleVisible(bool isVisible); // 0x000000018D1F6D0C-0x000000018D1F6DE0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class Empty4Raycast : MaskableGraphic // TypeDefIndex: 74367
	{
		// Constructors
		protected Empty4Raycast(); // 0x000000018D1F6E40-0x000000018D1F6E60
	
		// Methods
		protected override void OnPopulateMesh(VertexHelper vh); // 0x000000018D1F6DE0-0x000000018D1F6E38
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0); // 0x000000018D1F6E38-0x000000018D1F6E40
	}

	public class FitAspectRatioByFOV : MonoBehaviour, DeviceInfoManager.IScreenSizeListener // TypeDefIndex: 74368
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
		public float maxFov { get; set; } // 0x00000001872207B0-0x00000001872207F0 0x00000001851AC0E0-0x00000001851AC110
	
		// Constructors
		public FitAspectRatioByFOV(); // 0x0000000186CEF780-0x0000000186CEF7B0
	
		// Methods
		private void Start(); // 0x00000001851AD990-0x00000001851ADA20
		private void OnEnable(); // 0x00000001851ADA20-0x00000001851ADAA0
		private void OnDisable(); // 0x00000001851ADAA0-0x00000001851ADB10
		public void OnScreenSizeChanged(int width, int height); // 0x00000001851ADCB0-0x00000001851ADCE0
		private void _AdjustFOV(); // 0x00000001851ADCE0-0x00000001851ADDD0
	}

	public class FixRotation : TickableUIMono // TypeDefIndex: 74369
	{
		// Fields
		public Vector3 rotation; // 0x68
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018690F680-0x000000018690F6B0 
	
		// Constructors
		public FixRotation(); // 0x00000001871056F0-0x0000000187105710
	
		// Methods
		public override void LateTick(float deltaTime); // 0x0000000184FB8D20-0x0000000184FB8E80
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class FullScreenSceneBlurMarker : MonoBehaviour // TypeDefIndex: 74371
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
		public int id { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AF510-0x00000001844AF520 0x000000018442F470-0x000000018442F480
	
		// Nested types
		public enum State // TypeDefIndex: 74370
		{
			OnEnable = 0,
			OnDisable = 1,
			OnDestroy = 2
		}
	
		// Constructors
		public FullScreenSceneBlurMarker(); // 0x0000000186E080E0-0x0000000186E08110
		static FullScreenSceneBlurMarker(); // 0x00000001872206F0-0x0000000187220730
	
		// Methods
		private static int _GetNextId(); // 0x0000000186B095E0-0x0000000186B09660
		private void Awake(); // 0x0000000186B09560-0x0000000186B095E0
		private void OnEnable(); // 0x0000000186823360-0x00000001868234C0
		private void OnDisable(); // 0x00000001868234C0-0x0000000186823580
		private void OnDestroy(); // 0x0000000186CFE120-0x0000000186CFE180
	}

	[RequireComponent(typeof(InputBindingGroupMonoTarget))]
	public class InputBindingGroupNaviDecorator : Selectable, IUIClearable // TypeDefIndex: 74372
	{
		// Fields
		private InputBindingGroupMonoTarget m_inputBindingGroup; // 0x190
		public UnityEvent<bool> onGroupSetAsNaviTarget; // 0x198
	
		// Constructors
		public InputBindingGroupNaviDecorator(); // 0x00000001866D5A80-0x00000001866D5B00
	
		// Methods
		private void _SetSelfEnabledStateIfNecessary(); // 0x00000001865DB970-0x00000001865DBA30
		protected override void Awake(); // 0x000000018531FC90-0x000000018531FCF0
		protected override void OnEnable(); // 0x00000001865DB8F0-0x00000001865DB970
		protected override void OnDestroy(); // 0x0000000186567D60-0x0000000186567DA0
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode); // 0x000000018D1F7530-0x000000018D1F7650
		public void ClearComponent(); // 0x0000000186567DA0-0x0000000186567E10
		public void __iFixBaseProxy_Awake(); // 0x000000018D1F7518-0x000000018D1F7520
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D1F7528-0x000000018D1F7530
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D1F7520-0x000000018D1F7528
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public interface IUIClearable : ILuaCallCSharp // TypeDefIndex: 74373
	{
		// Methods
		void ClearComponent();
	}

	public class UILoopScrollRect : TickableUIMono, IPointerUpHandler, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, IUIClearable // TypeDefIndex: 74377
	{
		// Fields
		[SerializeField]
		private RectTransform _viewport; // 0x68
		[SerializeField]
		private ScrollDirection _scrollDirection; // 0x70
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
		public ScrollDirection scrollDirection { get; } // 0x000000018D1FAE74-0x000000018D1FAEB4 
		public float viewportSize { get; } // 0x000000018D1FAF3C-0x000000018D1FAFC0 
		public float scrollSensitivity { get; set; } // 0x000000018D1FAEB4-0x000000018D1FAEF8 0x000000018D1FB048-0x000000018D1FB08C
		public float Position { get; set; } // 0x000000018D1FADE8-0x000000018D1FAE30 0x000000018D1FAFC0-0x000000018D1FB048
		protected override TickType tickOption { get; } // 0x000000018D1FAEF8-0x000000018D1FAF3C 
		public int currentIndex { get; } // 0x000000018D1FAE30-0x000000018D1FAE74 
	
		// Nested types
		[Serializable]
		public class Snap // TypeDefIndex: 74374
		{
			// Fields
			public bool enable; // 0x10
			public float velocityThreshold; // 0x14
			public float duration; // 0x18
			public Interpolator.EEaseType easing; // 0x1C
	
			// Constructors
			public Snap(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		private class AutoScrollState // TypeDefIndex: 74375
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
			public AutoScrollState(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Reset(); // 0x000000018D1F6220-0x000000018D1F62D8
			public void Complete(); // 0x000000018D1F61C4-0x000000018D1F6220
		}
	
		public enum MovementDirection // TypeDefIndex: 74376
		{
			Left = 0,
			Right = 1,
			Up = 2,
			Down = 3
		}
	
		// Constructors
		public UILoopScrollRect(); // 0x000000018D1FAD08-0x000000018D1FADE8
	
		// Methods
		public void ScrollTo(float position, float duration, Interpolator.EEaseType easing, Action onComplete = null); // 0x000000018D1F9444-0x000000018D1F9524
		public void ScrollToMultiLoop(float position, float duration, Interpolator.EEaseType easing, Action onComplete = null); // 0x000000018D1F9364-0x000000018D1F9444
		public void OnValueChanged(Action<float> callback); // 0x000000018D1F931C-0x000000018D1F9364
		public void OnSelectionChanged(Action<int> callback); // 0x000000018D1F92D4-0x000000018D1F931C
		public void JumpTo(int index); // 0x000000018D1F9204-0x000000018D1F92D4
		public void SetTotalCount(int totalCount); // 0x000000018D1F9524-0x000000018D1F9564
		public MovementDirection GetMovementDirection(int sourceIndex, int destIndex); // 0x000000018D1F9174-0x000000018D1F9204
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x000000018D1F9F04-0x000000018D1F9F7C
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x000000018D1F9F7C-0x000000018D1FA03C
		void IScrollHandler.OnScroll(PointerEventData eventData); // 0x000000018D1FA03C-0x000000018D1FA160
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData); // 0x000000018D1F9B88-0x000000018D1F9CF0
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x000000018D1F9CF0-0x000000018D1F9EA8
		void IEndDragHandler.OnEndDrag(PointerEventData eventData); // 0x000000018D1F9EA8-0x000000018D1F9F04
		public override void Tick(float deltaTime); // 0x000000018D1F9564-0x000000018D1F9B88
		public void ClearComponent(); // 0x000000018D1F9140-0x000000018D1F9174
		private float _CalculateOffset(float position); // 0x000000018D1FA278-0x000000018D1FA2EC
		private void _ScrollTo(float position, float duration, Interpolator.EasingFunction easingFunction, Action onComplete = null); // 0x000000018D1FA9A0-0x000000018D1FAB90
		private void _ScrollToMultiLoop(float position, float duration, Interpolator.EasingFunction easingFunction, Action onComplete = null); // 0x000000018D1FA7F4-0x000000018D1FA9A0
		private void _UpdatePosition(float position); // 0x000000018D1FAB90-0x000000018D1FAC84
		private void _PlayEndAudio(); // 0x000000018D1FA378-0x000000018D1FA3F4
		private float _CalculateMovementAmount(float sourcePosition, float destPosition); // 0x000000018D1FA160-0x000000018D1FA278
		private float _CircularPosition(float p, int size); // 0x000000018D1FA2EC-0x000000018D1FA378
		private float _RubberDelta(float overStretching, float viewSize); // 0x000000018D1FA774-0x000000018D1FA7F4
		private void _UpdateSelection(int index); // 0x000000018D1FAC84-0x000000018D1FAD08
		private void _RefreshScrollToggleCount(int count); // 0x000000018D1FA3F4-0x000000018D1FA68C
		private void _RefreshToggle(); // 0x000000018D1FA68C-0x000000018D1FA774
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class UILoopScrollView : TickableUIMono // TypeDefIndex: 74379
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
		public int count { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001872354C0-0x00000001872354D0 0x0000000187233E10-0x0000000187233E20
		public bool controllerStickScrollEnabled { get; } // 0x000000018D1FCF60-0x000000018D1FD004 
		protected override TickType tickOption { get; } // 0x000000018D1FD004-0x000000018D1FD048 
	
		// Nested types
		public class Cell // TypeDefIndex: 74378
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
			public int index { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A60-0x0000000182271A70 0x0000000182271A90-0x0000000182271AA0
			public int realIndex { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
			public float position { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233870-0x0000000187233880 0x0000000187233880-0x0000000187233890
			public bool isVisible { get; } // 0x000000018D1F6550-0x000000018D1F65A4 
	
			// Constructors
			public Cell(); // 0x0000000187255AB0-0x0000000187255AC0
	
			// Methods
			public void SetVisible(bool active); // 0x000000018D1F649C-0x000000018D1F64DC
			public void UpdatePosition(string clipName, float position); // 0x000000018D1F64DC-0x000000018D1F6550
		}
	
		// Constructors
		public UILoopScrollView(); // 0x000000018D1FCDF8-0x000000018D1FCF60
		static UILoopScrollView(); // 0x000000018D1FCCE8-0x000000018D1FCDF8
	
		// Methods
		protected virtual void UpdatePosition(float position); // 0x000000018D1FB920-0x000000018D1FB960
		protected virtual void OnScrollEnd(int index); // 0x000000018D1FB528-0x000000018D1FB568
		public virtual void ScrollToIndex(int index, bool fastMode = false /* Metadata: 0x02628195 */); // 0x000000018D1FB61C-0x000000018D1FB6A8
		public virtual void UpdateCount(int newCount); // 0x000000018D1FB8A8-0x000000018D1FB920
		public override void Tick(float deltaTime); // 0x000000018D1FB868-0x000000018D1FB8A8
		public GameObject GetCurrentCell(); // 0x000000018D1FB138-0x000000018D1FB2B8
		protected override void OnRelease(); // 0x000000018D1FB4D0-0x000000018D1FB528
		protected void ClearComponent(); // 0x000000018D1FB08C-0x000000018D1FB138
		protected override void OnEnable(); // 0x000000018D1FB478-0x000000018D1FB4D0
		protected void Initialize(); // 0x000000018D1FB2B8-0x000000018D1FB478
		private void _UpdatePosition(float position, bool forceRefresh); // 0x000000018D1FCAA0-0x000000018D1FCCE8
		private void _OnScrollEnd(int index); // 0x000000018D1FBBD4-0x000000018D1FBC64
		protected virtual void OnUpdateCell(Cell cell, int index); // 0x000000018D1FB568-0x000000018D1FB61C
		private void _ResizePool(float firstPosition); // 0x000000018D1FBC64-0x000000018D1FBF0C
		private int _GetNeedCount(float firstPosition); // 0x000000018D1FB9D0-0x000000018D1FBAAC
		private void _UpdateCells(float firstPosition, int firstIndex, bool forceRefresh); // 0x000000018D1FC630-0x000000018D1FCAA0
		private void _UpdateCellsAnimationPosition(float firstPosition, int firstIndex, bool forceRefresh); // 0x000000018D1FC464-0x000000018D1FC630
		private void _InitController(); // 0x000000018D1FBAAC-0x000000018D1FBBD4
		private void _ScrollToNaviTarget(Selectable target); // 0x000000018D1FBFEC-0x000000018D1FC0AC
		public void ScrollToObject(GameObject go); // 0x000000018D1FB6A8-0x000000018D1FB868
		private void _ScrollToCell(Cell cell); // 0x000000018D1FBF0C-0x000000018D1FBFEC
		private void _TickRefreshControllerStickScroll(float deltaTime); // 0x000000018D1FC134-0x000000018D1FC464
		private void _ScrollToNext(bool positive); // 0x000000018D1FC0AC-0x000000018D1FC134
		private int _CircularIndex(int i, int size); // 0x000000018D1FB960-0x000000018D1FB9D0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
	}

	[ExecuteInEditMode]
	public class LuaPanel : MonoBehaviour, IUIClearable // TypeDefIndex: 74381
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
		public bool blockWhileAnim { get; } // 0x00000001855B4310-0x00000001855B4340 
		public int panelLevel { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A80-0x0000000182271A90 0x0000000182271AB0-0x0000000182271AC0
		public RectTransform rectTransform { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public Canvas canvas { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public Camera uiCamera { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public float planeDistance { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872352B0-0x00000001872352C0 0x00000001872352D0-0x00000001872352E0
		public int panelId { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233670-0x0000000187233680 0x0000000187233690-0x00000001872336A0
		public string panelName { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		public bool IsWorldUI { get; set; } // 0x000000018D1F7650-0x000000018D1F7694 0x000000018D1F7760-0x000000018D1F7798
		public bool isPCOnlyPanel { get; } // 0x000000018D1F771C-0x000000018D1F7760 
		public bool isControllerPanel { get; } // 0x000000018D1F76D8-0x000000018D1F771C 
		public bool animationInFinished { get; } // 0x000000018D1F7694-0x000000018D1F76D8 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __AutoAnimationInFinish_d__61 : IEnumerator<object> // TypeDefIndex: 74380
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public LuaPanel __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __AutoAnimationInFinish_d__61(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000185C90090-0x0000000185C90140
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D1F888C-0x000000018D1F88D8
		}
	
		// Constructors
		public LuaPanel(); // 0x0000000185E1C620-0x0000000185E1C720
		static LuaPanel(); // 0x00000001871779C0-0x0000000187177A50
	
		// Methods
		private void Awake(); // 0x000000018531F0E0-0x000000018531F1A0
		private void _TrySetRot(); // 0x000000018531F060-0x000000018531F0E0
		public void AddSortingOrderComp(UISortingOrder comp); // 0x000000018531DA50-0x000000018531DAD0
		public void RemoveSortingOrderComp(UISortingOrder comp); // 0x000000018682AFA0-0x000000018682B050
		private void Start(); // 0x000000018693A8D0-0x000000018693A910
		private void OnEnable(); // 0x00000001862E5FA0-0x00000001862E6060
		private void OnDisable(); // 0x0000000185573E20-0x0000000185573E90
		private void OnDestroy(); // 0x000000018676CB10-0x000000018676CB50
		[IteratorStateMachine(typeof(__AutoAnimationInFinish_d__61))]
		private IEnumerator _AutoAnimationInFinish(); // 0x00000001862E6060-0x00000001862E60C0
		public bool InformAnimationInStart(GameObject target); // 0x000000018508FA20-0x000000018508FA80
		public void InformAnimationInEnd(GameObject target, bool forceEnd = false /* Metadata: 0x02628196 */); // 0x0000000185C90140-0x0000000185C901B0
		private void _TryCallAnimationInFinished(bool forceFinished); // 0x0000000185C901B0-0x0000000185C90380
		public void BlockAllInput(); // 0x0000000185716550-0x0000000185716660
		public void RecoverAllInput(); // 0x0000000185717540-0x0000000185717650
		public void ClearComponent(); // 0x000000018676CB50-0x000000018676CB90
	}

	public class MouseHoverTipsPosHelper : TickableUIMono // TypeDefIndex: 74382
	{
		// Fields
		[SerializeField]
		[Tooltip("\u5047\u8BBEUI\u7684\u5206\u8FA8\u7387\u662F1920*1080\u7684\u60C5\u51B5\uFF0C\u4F1A\u81EA\u52A8\u52A0\u4E0A\u5218\u6D77\u5C4F\u7684\u504F\u79FB")]
		private RectOffset _padding; // 0x68
		private LuaPanel m_panel; // 0x70
		private RectTransform m_rectTransform; // 0x78
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D1F8398-0x000000018D1F83DC 
		public LuaPanel panel { get; } // 0x000000018D1F8310-0x000000018D1F8398 
	
		// Constructors
		public MouseHoverTipsPosHelper(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		protected override void OnAwake(); // 0x000000018D1F7E40-0x000000018D1F7F3C
		protected override void OnEnable(); // 0x000000018D1F7F3C-0x000000018D1F7F94
		public override void LateTick(float deltaTime); // 0x000000018D1F7E04-0x000000018D1F7E40
		public void UpdatePosition(); // 0x000000018D1F7F94-0x000000018D1F8310
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class NaviToThisGroupOnEnable : MonoBehaviour // TypeDefIndex: 74383
	{
		// Fields
		public UISelectableNaviGroup target; // 0x18
	
		// Constructors
		public NaviToThisGroupOnEnable(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		private void Reset(); // 0x000000018D1F83DC-0x000000018D1F8460
		private void Awake(); // 0x0000000186FCC3D0-0x0000000186FCC460
		private void OnEnable(); // 0x0000000185C318B0-0x0000000185C31950
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public class NonDrawingGraphic : Graphic, ICanvasRaycastFilter // TypeDefIndex: 74385
	{
		// Fields
		public ShapeType shapeType; // 0xB0
	
		// Properties
		public float Radius { get; } // 0x00000001853206D0-0x0000000185320790 
	
		// Nested types
		public enum ShapeType // TypeDefIndex: 74384
		{
			Rectangle = 0,
			Circle = 1
		}
	
		// Constructors
		public NonDrawingGraphic(); // 0x000000018548FB50-0x000000018548FBB0
	
		// Methods
		public override void SetMaterialDirty(); // 0x00000001864B8CB0-0x00000001864B8CE0
		public override void SetVerticesDirty(); // 0x00000001863DE2A0-0x00000001863DE2D0
		protected override void OnPopulateMesh(VertexHelper vh); // 0x000000018D1F8460-0x000000018D1F84B8
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera); // 0x0000000185320440-0x0000000185320480
		private bool _IsRaycastLocationValidCircle(Vector2 sp, Camera eventCamera); // 0x00000001853205F0-0x00000001853206D0
		public void __iFixBaseProxy_SetMaterialDirty(); // 0x000000018D1F84B8-0x000000018D1F84C0
		public void __iFixBaseProxy_SetVerticesDirty(); // 0x000000018D1F84C0-0x000000018D1F84C8
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0); // 0x000000018D1F6E38-0x000000018D1F6E40
	}

	[DisallowMultipleComponent]
	public sealed class NotchAdapter : MonoBehaviour // TypeDefIndex: 74387
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
		private sealed class __c__19<T> // TypeDefIndex: 74386
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
		public NotchAdapter(); // 0x000000018548FD60-0x000000018548FE70
	
		// Methods
		private void Awake(); // 0x00000001851959A0-0x0000000185195A30
		private void OnDestroy(); // 0x000000018527B440-0x000000018527B550
		public void FindAllSideUI(bool needClear); // 0x0000000185194B50-0x0000000185194BE0
		[IDTag(1)]
		public void ApplyNotch(); // 0x000000018D1F84C8-0x000000018D1F8514
		[IDTag(0)]
		public void ApplyNotch(Vector2 curMarginSize); // 0x00000001851953A0-0x0000000185195920
		public void ClearList(); // 0x0000000185194AA0-0x0000000185194B50
		public void ClearNullRef(); // 0x0000000185195920-0x00000001851959A0
		public void UnApplyNotch(); // 0x000000018D1F8514-0x000000018D1F857C
		public void ApplyNewNotch(); // 0x0000000185194D40-0x0000000185194DC0
		private void _UpdateMargeSizeFromNotchInfo(bool forceUpdate = false /* Metadata: 0x02628199 */); // 0x0000000185195C20-0x0000000185195FA0
		private void _OnCanvasChanged(); // 0x0000000185194D10-0x0000000185194D40
		private void _RemoveNullRef<T>(List<T> list);
		private void _TraverseUI(RectTransform root); // 0x0000000185193FB0-0x0000000185194420
		private void _TryAddToSideUI(RectTransform rect, CustomNotchAdapt custom = null); // 0x0000000185194420-0x0000000185194740
	}

	public class ParallaxHelper : MonoBehaviour // TypeDefIndex: 74389
	{
		// Fields
		[SerializeField]
		private List<ParallaxConfig> _configs; // 0x18
		[SerializeField]
		private float _maxOffset; // 0x20
		private float m_curValue; // 0x24
	
		// Properties
		public float curValue { get; set; } // 0x000000018D212558-0x000000018D21259C 0x000000018D21259C-0x000000018D2125DC
	
		// Nested types
		[Serializable]
		public class ParallaxConfig // TypeDefIndex: 74388
		{
			// Fields
			public RectTransform target; // 0x10
			public float ratio; // 0x18
			[NonSerialized]
			public Vector2 oriPosition; // 0x1C
	
			// Constructors
			public ParallaxConfig(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public ParallaxHelper(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void InitConfigs(); // 0x000000018D2121A0-0x000000018D212338
		public void ResetValue(); // 0x000000018D212518-0x000000018D212558
		public void RefreshPos(); // 0x000000018D212338-0x000000018D212518
	}

	public class PercentNumberTweener : TickableUIMono // TypeDefIndex: 74390
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
		protected override TickType tickOption { get; } // 0x000000018D21281C-0x000000018D212860 
	
		// Constructors
		public PercentNumberTweener(); // 0x000000018D2127C8-0x000000018D21281C
	
		// Methods
		private void Reset(); // 0x000000018D212744-0x000000018D2127C8
		protected override void OnEnable(); // 0x000000018D2126E8-0x000000018D212744
		public override void LateTick(float deltaTime); // 0x000000018D2125DC-0x000000018D2126E8
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public abstract class UIRecycleLayoutAdapter // TypeDefIndex: 74395
	{
		// Fields
		[CompilerGenerated]
		private UIRecycleLayoutGroup.IViewHandler _viewHandler_k__BackingField; // 0x10
	
		// Properties
		public UIRecycleLayoutGroup.IViewHandler viewHandler { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Nested types
		public interface ICustomViewType // TypeDefIndex: 74391
		{
			// Properties
			int viewType { get; }
		}
	
		public interface ICustomSpacing // TypeDefIndex: 74392
		{
			// Methods
			float GetCustomSpacing();
		}
	
		public interface IVirtualView : IHotfixable // TypeDefIndex: 74393
		{
			// Methods
			void AttachView(GameObject view);
			void DetachView();
			GameObject GetAttachedView();
			int GetViewID();
			GameObject GetPrefab();
			float GetPreferSize();
		}
	
		public abstract class VirtualView : IVirtualView // TypeDefIndex: 74394
		{
			// Fields
			protected GameObject m_gameObj; // 0x10
	
			// Properties
			public bool isAttached { get; } // 0x00000001855B4560-0x00000001855B4610 
	
			// Constructors
			protected VirtualView(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void AttachView(GameObject gameObj); // 0x0000000186C8E5A0-0x0000000186C8E680
			public void DetachView(); // 0x00000001856721A0-0x0000000185672250
			public GameObject GetAttachedView(); // 0x0000000186BDEBF0-0x0000000186BDEC20
			public int GetViewID(); // 0x0000000185671620-0x0000000185671660
			protected abstract void OnViewAttached();
			protected abstract void OnViewDetached();
			public abstract GameObject GetPrefab();
			public abstract float GetPreferSize();
		}
	
		// Constructors
		protected UIRecycleLayoutAdapter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void Init(UIRecycleLayoutGroup.IViewHandler handler); // 0x0000000185673E60-0x0000000185673EB0
		public virtual IList<IVirtualView> GenerateViewsForRebuild(); // 0x000000018D2193F8-0x000000018D219438
		public abstract void OnInit();
	}

	[RequireComponent(typeof(UIRecycleLayoutGroup))]
	public abstract class UIRecycleLayoutSimpleHolder<TVirtualView> : TickableUIMono // TypeDefIndex: 74398
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
		public class SimpleAdapter : UIRecycleLayoutAdapter // TypeDefIndex: 74396
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
			public void RemoveAllViews(bool dontRebuild = false /* Metadata: 0x0262819C */);
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
		private sealed class __c__DisplayClass13_0 // TypeDefIndex: 74397
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
		public void ScrollTo(int index, bool fastMode = false /* Metadata: 0x0262819A */);
		protected void ClearScrollTweenIfNeeded();
		protected virtual void ScrollToInternal(float normalizedPosition, bool fastMode = false /* Metadata: 0x0262819B */);
		public GameObject GetView(int index);
		public void NotifyAllSizeChanged();
		public void NotifySizeChanged(int index);
		public void NotifySizeChanged(TVirtualView virtualView);
		public void RemoveView(int index);
		public void RemoveAllViews();
	}

	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class UIRecycleLayoutGroup : TickableUIMono, ILayoutElement, IUIClearable // TypeDefIndex: 74407
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
		protected override TickType tickOption { get; } // 0x0000000186FB8640-0x0000000186FB8670 
		public UIRecycleLayoutAdapter adapter { get; } // 0x00000001856736D0-0x0000000185673740 
		protected ViewMgr viewMgr { get; } // 0x0000000185673740-0x00000001856737E0 
		protected float sizeOnAxis { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723F570-0x000000018723F580 0x0000000187234DE0-0x0000000187234DF0
		protected float spacing { get; } // 0x000000018D219E38-0x000000018D219E80 
		protected Padding padding { get; } // 0x000000018D219D94-0x000000018D219DF4 
		public float minWidth { get; } // 0x000000018D219D54-0x000000018D219D94 
		public float minHeight { get; } // 0x00000001856C4ED0-0x00000001856C4F00 
		public float flexibleWidth { get; } // 0x000000018D219CD0-0x000000018D219D10 
		public float flexibleHeight { get; } // 0x000000018D219C90-0x000000018D219CD0 
		public int layoutPriority { get; } // 0x000000018D219D10-0x000000018D219D54 
		public float preferredWidth { get; } // 0x000000018D219DF4-0x000000018D219E38 
		public float preferredHeight { get; } // 0x0000000186EC9E40-0x0000000186EC9E80 
		protected float paddingFront { get; } // 0x0000000186E07E60-0x0000000186E07EA0 
		protected float paddingBack { get; } // 0x0000000186D49060-0x0000000186D490A0 
		protected RectTransform content { get; } // 0x000000018D219C50-0x000000018D219C90 
	
		// Nested types
		public enum Direction // TypeDefIndex: 74399
		{
			Vertical = 0,
			Horizontal = 1
		}
	
		public enum AdaptMode // TypeDefIndex: 74400
		{
			Normal = 0,
			MultiPrefab = 1
		}
	
		public interface IViewHandler // TypeDefIndex: 74401
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
	
		protected struct LayoutMeta // TypeDefIndex: 74402
		{
			// Fields
			public float pos; // 0x00
			public float size; // 0x04
			public int index; // 0x08
			public float curTotalSize; // 0x0C
		}
	
		private class ViewPool // TypeDefIndex: 74403
		{
			// Fields
			private GameObject m_prefab; // 0x10
			private Transform m_container; // 0x18
			private List<GameObject> m_activeObjs; // 0x20
			private List<GameObject> m_pooledObjs; // 0x28
			[CompilerGenerated]
			private int _viewType_k__BackingField; // 0x30
	
			// Properties
			public int viewType { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBA0-0x000000018226EBB0 0x0000000186033510-0x0000000186033520
	
			// Constructors
			public ViewPool(int viewType, GameObject prefab, Transform container); // 0x00000001870A1DD0-0x00000001870A1EC0
	
			// Methods
			public GameObject Alloc(out bool isNewlyCreated); // 0x0000000185273D50-0x0000000185273E90
			public bool Recycle(GameObject obj); // 0x0000000185674020-0x00000001856741A0
			public void RecycleAll(); // 0x000000018D21AFE8-0x000000018D21B124
		}
	
		protected class ViewMgr : IHotfixable, IViewHandler // TypeDefIndex: 74404
		{
			// Fields
			private UIRecycleLayoutGroup m_closure; // 0x10
			private ListDict<int, ViewPool> m_viewPools; // 0x18
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views; // 0x20
	
			// Constructors
			public ViewMgr(UIRecycleLayoutGroup closure); // 0x0000000185673F40-0x0000000185674020
	
			// Methods
			public void RebuildAll(UIRecycleLayoutAdapter adapter); // 0x0000000185671C50-0x0000000185671EC0
			public IList<UIRecycleLayoutAdapter.IVirtualView> GetViews(); // 0x000000018D21ADDC-0x000000018D21AE1C
			public void DetachView(UIRecycleLayoutAdapter.IVirtualView view, GameObject curView); // 0x0000000185673E00-0x0000000185673E60
			public void AttachView(UIRecycleLayoutAdapter.IVirtualView view); // 0x0000000185273CD0-0x0000000185273D50
			public UIRecycleLayoutAdapter.IVirtualView GetView(int index); // 0x000000018642EA70-0x000000018642EBA0
			public int GetViewCount(); // 0x000000018D21ACD0-0x000000018D21AD4C
			public bool InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018D21AE1C-0x000000018D21AE84
			public bool AddView(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018D21AAA8-0x000000018D21AB50
			public bool RemoveView(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018D21AEE4-0x000000018D21AF48
			public void NotifyViewSizeChanged(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018D21AE84-0x000000018D21AEE4
			public void NotifyAllViewSizeChanged(); // 0x0000000186C76430-0x0000000186C76470
			public void NotifyRebuild(); // 0x0000000185673970-0x00000001856739B0
			public float GetElementPosByIndex(int index); // 0x000000018D21AC20-0x000000018D21AC78
			public Bounds GetElementBoundsByIndex(int index); // 0x000000018D21ABA4-0x000000018D21AC20
			public Direction GetDirection(); // 0x000000018D21AB50-0x000000018D21ABA4
			public float GetSizeOnAxis(); // 0x000000018D21AC78-0x000000018D21ACD0
			public float GetViewportSizeOnAxis(); // 0x000000018D21AD4C-0x000000018D21ADDC
			public int GetElementIndex(UIRecycleLayoutAdapter.IVirtualView view); // 0x0000000185670020-0x0000000185670060
			private ViewPool _EnsureViewPool(UIRecycleLayoutAdapter.IVirtualView view); // 0x0000000185273B70-0x0000000185273CD0
			private void _NotifyLayoutChanged(int fromIndex); // 0x000000018D21AF48-0x000000018D21AFE8
		}
	
		[Serializable]
		protected struct Padding // TypeDefIndex: 74405
		{
			// Fields
			public int top; // 0x00
			public int left; // 0x04
			public int bottom; // 0x08
			public int right; // 0x0C
		}
	
		public class EmptyAdapter : UIRecycleLayoutAdapter // TypeDefIndex: 74406
		{
			// Constructors
			public EmptyAdapter(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public override IList<IVirtualView> GenerateViewsForRebuild(); // 0x000000018D211E04-0x000000018D211E44
			public override void OnInit(); // 0x000000018D211E44-0x000000018D211E78
			public IList<IVirtualView> __iFixBaseProxy_GenerateViewsForRebuild(); // 0x000000018D211E78-0x000000018D211E80
		}
	
		// Constructors
		public UIRecycleLayoutGroup(); // 0x0000000186F8B040-0x0000000186F8B110
	
		// Methods
		public void CalculateLayoutInputHorizontal(); // 0x000000018569CC00-0x000000018569CC30
		public void CalculateLayoutInputVertical(); // 0x0000000185BA8470-0x0000000185BA84A0
		private void _ApplyLayoutMeta(UIRecycleLayoutAdapter.IVirtualView view, LayoutMeta meta); // 0x000000018566F6A0-0x000000018566FBA0
		private Vector2 _GetVisibleRange(Bounds viewBound); // 0x0000000186B121A0-0x0000000186B12240
		private Bounds _GetElementBoundsFromMeta(LayoutMeta meta); // 0x000000018D219578-0x000000018D219748
		public UIRecycleLayoutAdapter SetAdapter(UIRecycleLayoutAdapter adapter); // 0x00000001856739B0-0x0000000185673A50
		public void ClearComponent(); // 0x0000000185673C50-0x0000000185673CD0
		public override void LateTick(float deltaTime); // 0x0000000186CFBE70-0x0000000186CFBEA0
		protected void OnLateTick(); // 0x00000001856703D0-0x0000000185670A00
		private void _RebuildAllViews(); // 0x0000000185673620-0x00000001856736D0
		private void _UpdateViews(int fromIndex); // 0x000000018566FCA0-0x000000018566FF50
		private bool _InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018D219828-0x000000018D2199AC
		private bool _RemoveView(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018D2199EC-0x000000018D219B88
		private void _UpdateViewsFrom(UIRecycleLayoutAdapter.IVirtualView view); // 0x000000018D219B88-0x000000018D219C50
		private float _GetElementPosByIndex(int index); // 0x000000018D219748-0x000000018D219828
		private Bounds _GetElementBoundsByIndex(int index); // 0x000000018D219438-0x000000018D219578
		private int _GetElementIndex(UIRecycleLayoutAdapter.IVirtualView view); // 0x0000000185670060-0x0000000185670110
		private void _RefreshLayout(); // 0x000000018D2199AC-0x000000018D2199EC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class UIRecycleMultiHolder : UIRecycleLayoutSimpleHolder<UIRecycleMultiHolder.MultiVirtualView>, IUIClearable // TypeDefIndex: 74410
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
		public class MultiVirtualView : UIRecycleLayoutAdapter.VirtualView // TypeDefIndex: 74408
		{
			// Fields
			private UIRecycleMultiHolder m_closure; // 0x18
			public float preferSize; // 0x20
			public string prefabKey; // 0x28
	
			// Constructors
			public MultiVirtualView(float initSize, string key, UIRecycleMultiHolder closure); // 0x000000018D212170-0x000000018D2121A0
	
			// Methods
			public int GetIndex(); // 0x000000018D211E80-0x000000018D211F54
			public override GameObject GetPrefab(); // 0x000000018D211F54-0x000000018D211FE4
			public override float GetPreferSize(); // 0x000000018D211FE4-0x000000018D212028
			protected override void OnViewDetached(); // 0x000000018D2120CC-0x000000018D212170
			protected override void OnViewAttached(); // 0x000000018D212028-0x000000018D2120CC
		}
	
		[Serializable]
		public class Config // TypeDefIndex: 74409
		{
			// Fields
			public string key; // 0x10
			public GameObject cellTemplate; // 0x18
	
			// Constructors
			public Config(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public UIRecycleMultiHolder(); // 0x000000018D21A774-0x000000018D21A8E4
	
		// Methods
		public MultiVirtualView GetVirtualView(int index); // 0x000000018D21A074-0x000000018D21A10C
		[IDTag(1)]
		public void UpdateCount(int newCount, bool setTop = false /* Metadata: 0x026281A1 */); // 0x000000018D21A534-0x000000018D21A594
		[IDTag(0)]
		public void UpdateCount(int newCount, int fastScrollToIndex); // 0x000000018D21A594-0x000000018D21A774
		public void InsertView(int index, string key, float initSize); // 0x000000018D21A10C-0x000000018D21A208
		public void AddView(string key, float initSize); // 0x000000018D219E80-0x000000018D219F64
		public override void OnAdapterInit(); // 0x000000018D21A208-0x000000018D21A534
		public void ClearComponent(); // 0x000000018D219F64-0x000000018D21A074
	}

	public class UIRecycleSingleHolder : UIRecycleLayoutSimpleHolder<UIRecycleSingleHolder.SimpleVirtualView>, IUIClearable // TypeDefIndex: 74412
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
		public class SimpleVirtualView : UIRecycleLayoutAdapter.VirtualView // TypeDefIndex: 74411
		{
			// Fields
			private UIRecycleSingleHolder m_holder; // 0x18
			public float preferSize; // 0x20
	
			// Constructors
			public SimpleVirtualView(float initSize, UIRecycleSingleHolder holder); // 0x000000018660E8F0-0x000000018660E910
	
			// Methods
			public int GetIndex(); // 0x000000018566FF50-0x0000000185670020
			public override GameObject GetPrefab(); // 0x0000000185670A00-0x0000000185670C60
			public override float GetPreferSize(); // 0x000000018D212EC8-0x000000018D212F0C
			protected override void OnViewDetached(); // 0x000000018566F5C0-0x000000018566F670
			protected override void OnViewAttached(); // 0x0000000186C8E200-0x0000000186C8E2B0
		}
	
		// Constructors
		public UIRecycleSingleHolder(); // 0x0000000186F942A0-0x0000000186F94370
	
		// Methods
		public SimpleVirtualView GetVirtualView(int index); // 0x00000001862D2490-0x00000001862D2510
		[IDTag(1)]
		public void UpdateCount(int newCount, bool setTop = false /* Metadata: 0x026281A2 */); // 0x000000018660E720-0x000000018660E770
		[IDTag(0)]
		public void UpdateCount(int newCount, int fastScrollToIndex = -1 /* Metadata: 0x026281A3 */); // 0x000000018660E770-0x000000018660E8F0
		public void InsertView(int index, string key, float initSize); // 0x000000018D21A9C0-0x000000018D21AAA8
		public void AddView(string key, float initSize); // 0x000000018D21A8E4-0x000000018D21A9C0
		public override void OnAdapterInit(); // 0x00000001871FCBA0-0x00000001871FCBE0
		public void ClearComponent(); // 0x0000000185B2ACB0-0x0000000185B2AD90
	}

	public class SimpleUITextSingleLine : UIText // TypeDefIndex: 74413
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
		public bool m_b; // 0xCA8
		[CompilerGenerated]
		private Action<TMP_TextInfo> OnPreRenderText; // 0xCB0
	
		// Events
		public override event Action<TMP_TextInfo> OnPreRenderText {
			add; // 0x000000018D212DA8-0x000000018D212E38
			remove; // 0x000000018D212E38-0x000000018D212EC8
		}
	
		// Constructors
		public SimpleUITextSingleLine(); // 0x000000018D212D58-0x000000018D212DA8
		static SimpleUITextSingleLine(); // 0x000000018D212868-0x000000018D212D58
	
		// Methods
		protected override void GenerateTextMesh(); // 0x000000018D1FFC4C-0x000000018D20C22C
		public void __iFixBaseProxy_GenerateTextMesh(); // 0x000000018D212860-0x000000018D212868
	}

	[RequireComponent(typeof(VerticalLayoutGroup))]
	public class ToastList : MonoBehaviour, IUIClearable // TypeDefIndex: 74416
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
		public bool inAnimation { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018224A5F0-0x000000018224A600 0x000000018224A600-0x000000018224A610
	
		// Nested types
		private class CellInfo // TypeDefIndex: 74414
		{
			// Fields
			public int index; // 0x10
			public GameObject obj; // 0x18
			public UIAnimationWrapper animationWrapper; // 0x20
			public Coroutine cor; // 0x28
	
			// Constructors
			public CellInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __ShowCell_d__23 : IEnumerator<object> // TypeDefIndex: 74415
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public int delayIndex; // 0x20
			public CellInfo cell; // 0x28
			public ToastList __4__this; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ShowCell_d__23(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D214034-0x000000018D2142A4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D2142A4-0x000000018D2142F0
		}
	
		// Constructors
		public ToastList(); // 0x000000018D213B44-0x000000018D213CA8
	
		// Methods
		private void Awake(); // 0x000000018D21306C-0x000000018D2130C4
		private void OnDisable(); // 0x000000018D213330-0x000000018D213368
		private CellInfo _GetCell(); // 0x000000018D213444-0x000000018D2135C0
		private void _CacheCell(CellInfo cell); // 0x000000018D213368-0x000000018D213444
		public void AddToast(int count, int startIndex = 0 /* Metadata: 0x026281A4 */); // 0x000000018D212F0C-0x000000018D21306C
		private void _StartBatch(int batchCount); // 0x000000018D21383C-0x000000018D213948
		[IteratorStateMachine(typeof(__ShowCell_d__23))]
		private IEnumerator _ShowCell(int delayIndex, CellInfo cell); // 0x000000018D213770-0x000000018D21383C
		private void _TryShowNewCell(); // 0x000000018D213948-0x000000018D213B44
		private void _OnCellFinished(CellInfo cell); // 0x000000018D2135C0-0x000000018D213770
		public void ClearAllToast(); // 0x000000018D2130C4-0x000000018D213298
		public void ClearComponent(); // 0x000000018D213298-0x000000018D213330
	}

	public class UI3DScrollList : UIScrollList // TypeDefIndex: 74417
	{
		// Constructors
		public UI3DScrollList(); // 0x000000018D2143A8-0x000000018D2143F4
	
		// Methods
		protected override void MoveCellTo(Cell cell, int index); // 0x000000018D2142F0-0x000000018D2143A0
		public void __iFixBaseProxy_MoveCellTo(Cell P0, int P1); // 0x000000018D2143A0-0x000000018D2143A8
	}

	public class UIActionKeyHint : MonoBehaviour, IUIClearable // TypeDefIndex: 74420
	{
		// Fields
		private static readonly UnityEngine.Color NORMAL_COLOR; // 0x00
		private static readonly UnityEngine.Color HIDE_COLOR; // 0x10
		private static readonly UnityEngine.Color GREY_COLOR; // 0x20
		private static List<UIActionKeyHint> s_keyHintCache; // 0x30
		private static List<UIActionKeyHint> s_dynamicHints; // 0x38
		private static bool s_stateDirty; // 0x40
		private static int s_seenBindingStateVersion; // 0x44
		private static bool s_appliedStopCheckForGuide; // 0x48
		private static readonly ProfilerMarker INPUT_LATE_TICK_ALL_MARKER; // 0x50
		private static readonly ProfilerMarker INPUT_LATE_TICK_MARKER; // 0x58
		private static bool s_inited; // 0x60
		public static bool s_stopCheckBindingEnabledForGuide; // 0x61
		private IBindingView m_target; // 0x18
		private IBindingView m_subscribedTarget; // 0x20
		public string actionId; // 0x28
		public Component btnTarget; // 0x30
		public BindingViewActionType bindingViewActionType; // 0x38
		[SerializeField]
		private bool _useCustomText; // 0x3C
		[SerializeField]
		private bool _showSecondAction; // 0x3D
		[SerializeField]
		private bool _onlyShowOnLongPress; // 0x3E
		[FormerlySerializedAs("_adaptForceGrayState")]
		[SerializeField]
		private bool _adaptForceGreyState; // 0x3F
		[HideInInspector]
		[SerializeField]
		private Transform _content; // 0x40
		[FormerlySerializedAs("_pressHintCanvasGroup")]
		[HideInInspector]
		[SerializeField]
		private CanvasGroup _contentCanvasGroup; // 0x48
		[HideInInspector]
		[SerializeField]
		private UIImage _icon; // 0x50
		[HideInInspector]
		[SerializeField]
		private UIImage _longPressIcon; // 0x58
		[HideInInspector]
		[SerializeField]
		private RectTransform _pressHintNode; // 0x60
		[HideInInspector]
		[SerializeField]
		private UIImage _pressHintProgressImg; // 0x68
		[HideInInspector]
		[SerializeField]
		private UIText _text; // 0x70
		[HideInInspector]
		[SerializeField]
		private UIImage _secondIcon; // 0x78
		[HideInInspector]
		[SerializeField]
		private RectTransform _secondNode; // 0x80
		[HideInInspector]
		[SerializeField]
		private UIImage _modifyIcon; // 0x88
		[SerializeField]
		[Tooltip("\u4E00\u822C\u662F\u6309\u94AE\u4E0A\u540C\u4F4D\u7F6E\u7684Icon\uFF0C\u5728KeyHint\u6D88\u5931\u65F6\u4F1A\u663E\u793A\uFF0C\u5426\u5219\u9690\u85CF")]
		private GameObject _mutexGameObject; // 0x90
		[SerializeField]
		[Tooltip("\u52FE\u9009\u5219\u5728KeyHint\u6D88\u5931\u65F6\uFF08alpha\u4E3A0\uFF09\u6539\u53D8Scale\uFF0C\u8FD9\u6837Layout\u4E2D\u5C31\u4E0D\u4F1A\u5360\u4F4D\u7F6E\u4E86")]
		private bool _changeScaleOnHide; // 0x98
		[NonSerialized]
		public int bindingId; // 0x9C
		[FormerlySerializedAs("m_canvasGroup")]
		[SerializeField]
		private CanvasGroup _canvasGroup; // 0xA0
		public bool autoUpdate; // 0xA8
		[CompilerGenerated]
		private bool _hintHidden_k__BackingField; // 0xA9
		private bool m_inDynamicList; // 0xAA
		private KeyHintSnapshot m_appliedSnapshot; // 0xB0
		private int m_cachedBindingId; // 0xF0
		private bool m_isLongPressAction; // 0xF4
		private float m_lastPressStartTime; // 0xF8
		private const float LONG_PRESS_HINT_HIDE_TIME = 0.2f; // Metadata: 0x026281AE
		private const float LONG_PRESS_HINT_SHOW_MIN_VALUE = 0f; // Metadata: 0x026281B2
	
		// Properties
		private IBindingView target { get; } // 0x0000000185642870-0x0000000185642910 
		private bool showCanvasGroup { get; } // 0x000000018D215818-0x000000018D2158A0 
		public bool hintHidden { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723E5E0-0x000000018723E5F0 0x000000018723E600-0x000000018723E610
	
		// Nested types
		private enum HintVisibility // TypeDefIndex: 74418
		{
			Visible = 0,
			Greyed = 1,
			Hidden = 2
		}
	
		[IsReadOnly]
		private struct KeyHintSnapshot // TypeDefIndex: 74419
		{
			// Fields
			public readonly bool valid; // 0x00
			public readonly PlayerActionInfo actionInfo; // 0x08
			public readonly bool isLongPress; // 0x10
			public readonly string mainIconPath; // 0x18
			public readonly string modifyIconPath; // 0x20
			public readonly bool hasText; // 0x28
			public readonly string text; // 0x30
			public readonly bool showSecondIcon; // 0x38
	
			// Constructors
			public KeyHintSnapshot(PlayerActionInfo actionInfo, bool isLongPress, string mainIconPath, string modifyIconPath, bool hasText, string text, bool showSecondIcon); // 0x0000000185643560-0x00000001856435E0
		}
	
		// Constructors
		public UIActionKeyHint(); // 0x000000018548CAA0-0x000000018548CAE0
		static UIActionKeyHint(); // 0x0000000187031AC0-0x0000000187032A90
	
		// Methods
		private static void _TryInit(); // 0x0000000185C86F30-0x0000000185C87190
		private static void _RefreshAllKeyHints(); // 0x0000000186E23C20-0x0000000186E23D40
		private static void _OnInputLateTickAll(); // 0x00000001850D1E10-0x00000001850D2AB0
		private static void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType); // 0x000000018D214AB4-0x000000018D214B30
		private void Awake(); // 0x0000000185C86E40-0x0000000185C86F30
		private void OnEnable(); // 0x00000001856425B0-0x0000000185642870
		private void OnDisable(); // 0x00000001856422B0-0x00000001856425B0
		private void OnDestroy(); // 0x00000001856419A0-0x0000000185641AF0
		private void _SubscribeTarget(IBindingView t); // 0x0000000185643670-0x00000001856437A0
		private void _UnsubscribeTarget(); // 0x00000001856437A0-0x0000000185643880
		private void Reset(); // 0x000000018D214478-0x000000018D21458C
		private void _OnInputLateTick(); // 0x000000018D214BA4-0x000000018D215818
		public void UpdateKeyHint(); // 0x0000000185642910-0x0000000185642970
		private void _UpdateDynamicRegistration(); // 0x0000000184E50DD0-0x0000000184E511F0
		private void _SetInDynamicList(bool inList); // 0x0000000184E504B0-0x0000000184E50DD0
		private void _UpdateKeyHintCore(); // 0x0000000184E511F0-0x0000000184E51FE0
		private KeyHintSnapshot _BuildSnapshot(); // 0x0000000185642970-0x0000000185642C10
		private string _ResolveActionIconPath(PlayerActionInfo actionInfo, bool usingController, bool isPrimary, out bool isLongPressAction); // 0x0000000185643240-0x0000000185643330
		private string _ResolveActionModifyIconPath(PlayerActionInfo actionInfo, bool usingController, bool isPrimary = true /* Metadata: 0x026281A5 */); // 0x0000000185643180-0x0000000185643240
		private bool _ApplySnapshot([IsReadOnly] in KeyHintSnapshot snap); // 0x0000000185642D60-0x0000000185642E50
		private bool _ApplyMainIcon([IsReadOnly] in KeyHintSnapshot snap); // 0x00000001856435E0-0x0000000185643670
		private void _ApplyModifyIcon([IsReadOnly] in KeyHintSnapshot snap); // 0x0000000185642020-0x00000001856420A0
		private void _ApplyText([IsReadOnly] in KeyHintSnapshot snap); // 0x00000001856420A0-0x00000001856420F0
		private void _RefreshSecondaryEffects([IsReadOnly] in KeyHintSnapshot snap); // 0x0000000185641E60-0x0000000185642020
		public void SetActionId(string id, bool forceUpdate = false /* Metadata: 0x026281A6 */); // 0x000000018D21458C-0x000000018D2145E8
		public void SetKeyHint(string actId, IBindingView hintTarget, bool forceUpdate = false /* Metadata: 0x026281A7 */); // 0x000000018D21468C-0x000000018D214758
		[IDTag(0)]
		public void SetBindingId(int bId, bool forceUpdate = false /* Metadata: 0x026281A8 */); // 0x00000001856417E0-0x00000001856418B0
		[IDTag(1)]
		public void SetBindingId(int bId, string actId, IBindingView hintTarget, bool forceUpdate = false /* Metadata: 0x026281A9 */); // 0x000000018D2145E8-0x000000018D21468C
		private void _OnChangeTarget(); // 0x00000001856418B0-0x00000001856419A0
		private void _OnInputActionKeyUpdated([IsReadOnly] in EventData<string> data); // 0x000000018D214B30-0x000000018D214BA4
		public void SetSecondActionId(string id, bool isPrimary = false /* Metadata: 0x026281AA */); // 0x0000000185642C90-0x0000000185642D60
		private void _SetSecondIcon(PlayerActionInfo actionInfo, bool isPrimary = false /* Metadata: 0x026281AB */); // 0x0000000185642E50-0x0000000185642FA0
		private void _CheckInteractable(bool isInit); // 0x00000001850D1C80-0x00000001850D1E10
		private void _ResolveVisibility(out HintVisibility visibility, out bool isHidden); // 0x0000000184E4EEC0-0x0000000184E504B0
		private HintVisibility _ResolveStandaloneVisibility(); // 0x0000000184E4EDD0-0x0000000184E4EE50
		private HintVisibility _ResolveViewVisibility(BindingViewState state); // 0x0000000184E4EE50-0x0000000184E4EEC0
		private void _WriteVisibilityToNode(HintVisibility visibility, bool isHidden); // 0x0000000184E51FE0-0x0000000184E529F0
		private static UnityEngine.Color _GetVisibilityColor(HintVisibility visibility); // 0x0000000184E4E9F0-0x0000000184E4EDD0
		private static bool _IsBindingViewAlive(IBindingView view); // 0x00000001850D6C60-0x00000001850D6E60
		private bool _IsInputEnabled(); // 0x00000001856916A0-0x0000000185691AE0
		private bool _IsInputGrey(); // 0x000000018D214860-0x000000018D214AB4
		public string GetTextStr(); // 0x0000000185640F70-0x0000000185641390
		public void SetText(string text); // 0x000000018D214758-0x000000018D2147B0
		public bool GetAndSetActionIcon(UIImage iconImage, PlayerActionInfo actionInfo, bool usingController, out bool isLongPressAction, bool isPrimary = true /* Metadata: 0x026281AC */); // 0x00000001871CED40-0x00000001871CEDC0
		public bool GetAndSetActionModifyIcon(PlayerActionInfo actionInfo, bool usingController, bool isPrimary = true /* Metadata: 0x026281AD */); // 0x000000018D2143F4-0x000000018D214478
		private bool _SetKeyCodeSprite(UIImage iconImage, string iconPath); // 0x0000000185641B40-0x0000000185641C60
		[IFixIgnore]
		private void _UpdatePressHint(); // 0x00000001850D1C30-0x00000001850D1C80
		private void _GetLongPressInfo(out float startTime, out float longPressTime); // 0x000000018D2147B0-0x000000018D214860
		public string GetActionId(); // 0x0000000185691AE0-0x0000000185691B90
		public PlayerActionInfo GetActionInfo(); // 0x0000000185642C10-0x0000000185642C90
		public void ClearComponent(); // 0x00000001850931D0-0x0000000185093340
		public void SetContentState(bool contentState); // 0x0000000185642FA0-0x0000000185643180
	}

	public class UIAnimationHolder : MonoBehaviour, IAnimationClipSource // TypeDefIndex: 74422
	{
		// Fields
		[SerializeField]
		private List<ClipHolder> _clips; // 0x18
	
		// Nested types
		[Serializable]
		private class ClipHolder // TypeDefIndex: 74421
		{
			// Fields
			public AnimationClip clip; // 0x10
			public string alias; // 0x18
	
			// Constructors
			public ClipHolder(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public UIAnimationHolder(); // 0x00000001870AD080-0x00000001870AD110
	
		// Methods
		public AnimationClip FindByName(string name); // 0x000000018D2158E4-0x000000018D215928
		public AnimationClip FindByNameOrAlias(string nameOrAlias); // 0x000000018D2158A0-0x000000018D2158E4
		private AnimationClip _FindByString(string id, bool useAlias); // 0x000000018D215960-0x000000018D215B64
		public void GetAnimationClips(List<AnimationClip> results); // 0x000000018D215928-0x000000018D215960
	}

	public class UIAnimationLoopSynchronizer : MonoBehaviour // TypeDefIndex: 74423
	{
		// Fields
		public string syncLoopAnimKey; // 0x18
		private readonly List<UIAnimationWrapper> m_children; // 0x20
	
		// Constructors
		public UIAnimationLoopSynchronizer(); // 0x00000001870ACFF0-0x00000001870AD080
	
		// Methods
		public void RegisterChild(UIAnimationWrapper child); // 0x0000000186B776D0-0x0000000186B77780
		public void UnregisterChild(UIAnimationWrapper child); // 0x000000018D215B64-0x000000018D215BFC
		public float GetLoopStartPosition(); // 0x00000001865E2D70-0x00000001865E2E00
		public bool IsLoopAudioOwner(UIAnimationWrapper child); // 0x0000000184E529F0-0x0000000184E53050
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(Animation))]
	public class UIAnimationWrapper : MonoBehaviour, IUIClearable // TypeDefIndex: 74431
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
		[AudioString]
		[SerializeField]
		[Tooltip("Loop \u52A8\u6548\u6BCF\u5708\u5F00\u5934\u64AD\u653E\u7684\u97F3\u6548")]
		private string _audioOnLoop; // 0xD0
	
		// Properties
		public AnimationClip animationIn { get; } // 0x00000001872251A0-0x00000001872251D0 
		public AnimationClip animationInEasing { get; } // 0x000000018D216790-0x000000018D2167D0 
		public AnimationClip animationLoop { get; } // 0x0000000186BB91A0-0x0000000186BB91D0 
		public AnimationClip animationOut { get; } // 0x00000001871FD380-0x00000001871FD3B0 
		public UIAnimationTween curTween { get; } // 0x000000018D2167D0-0x000000018D216810 
		public LuaPanel panel { get; } // 0x0000000185090010-0x00000001850900D0 
	
		// Nested types
		private class AnimationRuntime // TypeDefIndex: 74424
		{
			// Fields
			public UIAnimationTween.Options option; // 0x10
			public UnityEngine.AnimationState state; // 0x20
			public bool isPlaying; // 0x28
	
			// Constructors
			public AnimationRuntime(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public float GetClipLength(); // 0x000000018508FA80-0x000000018508FB50
		}
	
		[Serializable]
		public struct FOptions : ILuaCallCSharp // TypeDefIndex: 74425
		{
			// Fields
			public Ease animEase; // 0x00
	
			// Methods
			public static FOptions GetDefault(); // 0x000000018548D930-0x000000018548D960
		}
	
		private struct CachedSampleClipInfo // TypeDefIndex: 74426
		{
			// Fields
			public AnimationRuntime runtime; // 0x00
			public float position; // 0x08
			public bool isDirty; // 0x0C
	
			// Constructors
			public CachedSampleClipInfo(bool isDirty); // 0x000000018783647C-0x00000001878364A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0 // TypeDefIndex: 74427
		{
			// Fields
			public UIAnimationWrapper __4__this; // 0x10
			public TweenCallback callback; // 0x18
	
			// Constructors
			public __c__DisplayClass37_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PlayOutAnimation_b__0(); // 0x0000000184E4E170-0x0000000184E4E1B0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0 // TypeDefIndex: 74428
		{
			// Fields
			public TweenCallback callback; // 0x10
			public UIAnimationWrapper __4__this; // 0x18
			public bool autoPlayLoop; // 0x20
	
			// Constructors
			public __c__DisplayClass46_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PlayInAnimation_b__0(); // 0x0000000184E4E1B0-0x0000000184E4E1F0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0 // TypeDefIndex: 74429
		{
			// Fields
			public UIAnimationWrapper __4__this; // 0x10
			public bool autoPlayLoop; // 0x18
	
			// Constructors
			public __c__DisplayClass53_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __OnInAnimationFinished_b__0(); // 0x0000000184E4E1F0-0x0000000184E4E220
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0 // TypeDefIndex: 74430
		{
			// Fields
			public UIAnimationWrapper __4__this; // 0x10
			public TweenCallback onComplete; // 0x18
			public UIAnimationTween animTween; // 0x20
	
			// Constructors
			public __c__DisplayClass74_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _PlayWithTween_b__0(); // 0x0000000184E4E220-0x0000000184E4E9F0
		}
	
		// Constructors
		public UIAnimationWrapper(); // 0x000000018548D530-0x000000018548D930
		static UIAnimationWrapper(); // 0x0000000187176730-0x00000001871767C0
	
		// Methods
		public void SetOptions(FOptions options); // 0x000000018D216310-0x000000018D216348
		private void _InitAnimation(); // 0x0000000185091820-0x0000000185091DA0
		private void _AnimationInLoopCheck(); // 0x000000018D21656C-0x000000018D216790
		private void _AnimationAutomaticallyCheck(); // 0x000000018D21648C-0x000000018D21656C
		private void Awake(); // 0x0000000185092500-0x0000000185092790
		public bool IsStarted(); // 0x000000018D216014-0x000000018D216058
		public void PlayOutAnimation(TweenCallback callback = null); // 0x000000018508EC10-0x000000018508ED70
		public void SetAnimationInClip(string clipName); // 0x000000018D216118-0x000000018D216184
		public void SetAnimationInEasingClip(string clipName); // 0x000000018D216184-0x000000018D2161F0
		public void SetAnimationLoopClip(string clipName); // 0x000000018D2161F0-0x000000018D21625C
		public void SetAnimationOutClip(string clipName); // 0x000000018D21625C-0x000000018D2162C8
		public float GetInClipLength(); // 0x00000001870661B0-0x0000000187066240
		public float GetOutClipLength(); // 0x0000000186C17760-0x0000000186C17800
		public float GetLoopClipLength(); // 0x000000018D215F74-0x000000018D216014
		public void PlayLoopAnimation(float speed = 1f /* Metadata: 0x026281B9 */, bool preserveStartPosition = false /* Metadata: 0x026281BD */); // 0x000000018508EDD0-0x000000018508F2F0
		public void PlayInAnimation(TweenCallback callback = null, bool autoPlayLoop = true /* Metadata: 0x026281BE */, float speed = 1f /* Metadata: 0x026281BF */); // 0x000000018508FB50-0x000000018508FE80
		public void SkipInAnimation(); // 0x000000018D216348-0x000000018D21648C
		public void SampleToInAnimationBegin(); // 0x0000000185EC5080-0x0000000185EC5140
		public void SampleToInAnimationEnd(); // 0x0000000185E946B0-0x0000000185E94760
		public void SampleToOutAnimationBegin(); // 0x000000018D216058-0x000000018D216118
		public void SampleToOutAnimationEnd(); // 0x0000000185E95F20-0x0000000185E95FD0
		private void _OnInAnimationFinished(bool autoPlayLoop = true /* Metadata: 0x026281C3 */); // 0x000000018508F2F0-0x000000018508F4D0
		private void _OnInEasingAnimationFinished(bool autoPlayLoop); // 0x000000018508F4D0-0x000000018508F580
		public UnityEngine.AnimationState GetClip(string aniName); // 0x0000000185090DB0-0x0000000185090E40
		public float GetClipLength(string aniName); // 0x000000018508F680-0x000000018508F710
		private void _SampleClipAtLength(AnimationRuntime runtime, float position); // 0x0000000185091400-0x0000000185091670
		public void SampleClipAtPercent(string clipName, float percent, bool clearTween = true /* Metadata: 0x026281C4 */); // 0x000000018508F600-0x000000018508F680
		public void SampleClip(string clipName, float position, bool clearTween = true /* Metadata: 0x026281C5 */); // 0x0000000185091100-0x0000000185091400
		public void ClearTween(bool executeOnComplete = true /* Metadata: 0x026281C6 */); // 0x00000001850920F0-0x0000000185092410
		private bool _CheckShouldAutoPlayAnimationIn(); // 0x000000018508F990-0x000000018508F9D0
		private void Start(); // 0x000000018508F710-0x000000018508F780
		private void OnEnable(); // 0x000000018508F780-0x000000018508F990
		private void OnDisable(); // 0x0000000185090CE0-0x0000000185090D90
		private void OnDestroy(); // 0x000000018508FFB0-0x0000000185090010
		public bool CheckStopped(); // 0x000000018D215EE8-0x000000018D215F24
		[IDTag(0)]
		public void Play(AnimationClip animationClip, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x026281C7 */, float startPlayTime = 0f /* Metadata: 0x026281C8 */, bool clearTween = true /* Metadata: 0x026281CC */); // 0x000000018717EFC0-0x000000018717F060
		[IDTag(1)]
		public void Play(string stateName, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x026281CD */, float startPlayTime = 0f /* Metadata: 0x026281CE */, bool clearTween = true /* Metadata: 0x026281D2 */); // 0x0000000185814470-0x00000001858144D0
		[IDTag(1)]
		public void PlayWithTween(AnimationClip animationClip, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x026281D3 */, float startPlayTime = 0f /* Metadata: 0x026281D4 */, bool clearTween = true /* Metadata: 0x026281D8 */, float speed = 1f /* Metadata: 0x026281D9 */); // 0x000000018508FEE0-0x000000018508FFB0
		[IDTag(0)]
		public void PlayWithTween(string stateName, TweenCallback onComplete = null, UIConst.AnimationState newState = UIConst.AnimationState.Others /* Metadata: 0x026281DD */, float startPlayTime = 0f /* Metadata: 0x026281DE */, bool clearTween = true /* Metadata: 0x026281E2 */, float speed = 1f /* Metadata: 0x026281E3 */); // 0x00000001850906C0-0x0000000185090CA0
		public float GetCurPlayingTime(); // 0x000000018D215F24-0x000000018D215F74
		public void SetAudioOnOpen(string audioOnOpen); // 0x000000018D2162C8-0x000000018D216310
		public void SetAudioOnLoop(string audioOnLoop); // 0x0000000184E534B0-0x0000000184E53540
		public void PlayOpenAudio(); // 0x000000018508FE80-0x000000018508FEE0
		public void PlayCloseAudio(); // 0x000000018508ED70-0x000000018508EDD0
		public void PlayLoopAudio(); // 0x0000000184E53050-0x0000000184E534B0
		public void ClearComponent(); // 0x0000000185091DA0-0x0000000185091E20
		private void _NotifyAnimationInEasingFinished(); // 0x000000018508F580-0x000000018508F600
	}

	public class UIAnimationTween // TypeDefIndex: 74435
	{
		// Fields
		public static readonly Options DEFAULT_OPTION; // 0x00
		private DG.Tweening.Tween m_handler; // 0x10
		private float m_tweenValue; // 0x18
		private GameObject m_animTarget; // 0x20
		[CompilerGenerated]
		private float _clipLength_k__BackingField; // 0x28
	
		// Properties
		public DG.Tweening.Tween handler { get; } // 0x000000018D215E64-0x000000018D215EA4 
		public float tweenValue { get; } // 0x000000018D215EA4-0x000000018D215EE8 
		public float clipLength { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
	
		// Nested types
		public struct Options // TypeDefIndex: 74432
		{
			// Fields
			public bool isInverse; // 0x00
			public float startPosition; // 0x04
			public float speed; // 0x08
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0 // TypeDefIndex: 74433
		{
			// Fields
			public UIAnimationTween __4__this; // 0x10
			public UIAnimationWrapper wrapper; // 0x18
			public string name; // 0x20
	
			// Constructors
			public __c__DisplayClass14_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _.ctor_b__0(float value); // 0x0000000185090E40-0x0000000185090F30
			internal void _.ctor_b__2(float value); // 0x0000000185090F30-0x0000000185091020
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 74434
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static DOGetter<float> __9__14_1; // 0x08
	
			// Constructors
			static __c(); // 0x00000001871E54E0-0x00000001871E5540
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _.ctor_b__14_1(); // 0x0000000187234CD0-0x0000000187234CE0
		}
	
		// Constructors
		public UIAnimationTween(GameObject target, UIAnimationWrapper wrapper, string name); // 0x000000018D215DC4-0x000000018D215E64
		public UIAnimationTween(GameObject target, UIAnimationWrapper wrapper, string name, Options options); // 0x00000001850902A0-0x00000001850906C0
		static UIAnimationTween(); // 0x00000001871EE490-0x00000001871EE4F0
	
		// Methods
		public float GetValue(); // 0x00000001864D3390-0x00000001864D3450
		private void _SetValue(UIAnimationWrapper wrapper, string name, float value); // 0x0000000185091020-0x0000000185091100
	}

	public class UIAnimationSwitchTween : UISwitchTween // TypeDefIndex: 74438
	{
		// Fields
		private UIAnimationWrapper m_animWrapper; // 0x30
		private bool m_dontDisableGameObject; // 0x38
	
		// Nested types
		private class TweenHandler : UISwitchTween.ITweenHandler // TypeDefIndex: 74436
		{
			// Fields
			private UIAnimationSwitchTween m_closure; // 0x10
			private bool m_isIn; // 0x18
			private bool m_pendingClear; // 0x19
			private TweenCallback m_pendingCallback; // 0x20
			private bool m_isComplete; // 0x28
	
			// Constructors
			public TweenHandler(UIAnimationSwitchTween closure, bool isIn); // 0x000000018D213F34-0x000000018D214034
	
			// Methods
			public bool IsPlaying(); // 0x000000018D213CA8-0x000000018D213D6C
			public void KillIfNecessary(); // 0x000000018D213D6C-0x000000018D213E28
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback); // 0x000000018D213E28-0x000000018D213E94
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill); // 0x000000018D213E94-0x000000018D213ECC
			private void _OnComplete(); // 0x000000018D213ECC-0x000000018D213F34
		}
	
		public struct Builder // TypeDefIndex: 74437
		{
			// Fields
			public UIAnimationWrapper animWrapper; // 0x00
			public bool dontDisableGameObject; // 0x08
	
			// Methods
			public UIAnimationSwitchTween Build(); // 0x000000018663A710-0x000000018663A7A0
		}
	
		// Constructors
		public UIAnimationSwitchTween(UIAnimationWrapper animWrapper); // 0x000000018783BA80-0x000000018783BA90
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide(); // 0x000000018D215C7C-0x000000018D215D14
		protected override ITweenHandler GenerateTweenOfShow(); // 0x000000018D215D14-0x000000018D215DAC
		protected override void BeforeShowEffect(); // 0x000000018D215C3C-0x000000018D215C7C
		protected override void AfterHideEffect(); // 0x000000018D215BFC-0x000000018D215C3C
		protected override void ResetToState(bool isShow); // 0x0000000186C7BB00-0x0000000186C7BC40
		private void _SetGameObjectActive(bool isActive); // 0x0000000186C7BC40-0x0000000186C7BCA0
		public void __iFixBaseProxy_BeforeShowEffect(); // 0x000000018D215DB4-0x000000018D215DBC
		public void __iFixBaseProxy_AfterHideEffect(); // 0x000000018D215DAC-0x000000018D215DB4
		public void __iFixBaseProxy_ResetToState(bool P0); // 0x000000018D215DBC-0x000000018D215DC4
	}

	public class UIArea : TickableUIMono, IPointerEnterHandler, IPointerExitHandler, IUIClearable // TypeDefIndex: 74439
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
		public bool pointerInArea { get; } // 0x000000018D216EA4-0x000000018D216EE8 
		public bool usePositionCheckMode { get; } // 0x000000018D216F2C-0x000000018D216F70 
		protected override TickType tickOption { get; } // 0x000000018D216EE8-0x000000018D216F2C 
	
		// Constructors
		public UIArea(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		private void _SetHighlightNodeActive(bool active); // 0x000000018D216DEC-0x000000018D216EA4
		public void OnPointerEnter(PointerEventData eventData); // 0x000000018D216A70-0x000000018D216B10
		public void OnPointerExit(PointerEventData eventData); // 0x000000018D216B10-0x000000018D216BB0
		protected override void OnAwake(); // 0x000000018D216874-0x000000018D216954
		public override void Tick(float deltaTime); // 0x000000018D216BB0-0x000000018D216D50
		private static Vector2 _GetPointerScreenPosition(); // 0x000000018D216D50-0x000000018D216DEC
		protected override void OnEnable(); // 0x000000018D216A14-0x000000018D216A70
		protected override void OnDisable(); // 0x000000018D2169B4-0x000000018D216A14
		protected override void OnDestroy(); // 0x000000018D216954-0x000000018D2169B4
		public void ClearComponent(); // 0x000000018D216810-0x000000018D216874
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000189572D4C-0x0000000189572D54
	}

	public class UIAutoCloseArea : TickableUIMono, IUIClearable, IBindingGroupTarget // TypeDefIndex: 74440
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
		protected override TickType tickOption { get; } // 0x0000000186729AD0-0x0000000186729B00 
		public bool includeInAutoCloseLayer { get; set; } // 0x000000018D2172B8-0x000000018D2172FC 0x000000018D2172FC-0x000000018D2173B4
		public LuaPanel panel { get; } // 0x000000018531BD70-0x000000018531BE00 
		public int groupId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723B930-0x000000018723B940 0x0000000185FC1900-0x0000000185FC1910
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187236200-0x0000000187236210 0x0000000188D95540-0x0000000188D95554
		public bool groupEnabled { get; } // 0x000000018D217228-0x000000018D2172B8 
	
		// Constructors
		public UIAutoCloseArea(); // 0x0000000186883980-0x0000000186883A80
		static UIAutoCloseArea(); // 0x0000000187170E70-0x0000000187170F00
	
		// Methods
		private void Start(); // 0x00000001864D90E0-0x00000001864D91E0
		private void Reset(); // 0x000000018D2170B8-0x000000018D217178
		public override void LateTick(float deltaTime); // 0x00000001851D1C30-0x00000001851D1D00
		protected override void OnEnable(); // 0x00000001864D9530-0x00000001864D95D0
		protected override void OnDisable(); // 0x00000001864D93D0-0x00000001864D9480
		public void ChangeEnableCloseActionOnController(bool enabled); // 0x000000018D216F70-0x000000018D216FC4
		public void CloseSelf(); // 0x0000000186607600-0x0000000186607890
		public void TryCloseSelf(); // 0x000000018D217178-0x000000018D217228
		public void OpenSelf(bool executeOnComplete = true /* Metadata: 0x026281E7 */); // 0x000000018D216FC4-0x000000018D2170B8
		public bool ShouldClose(); // 0x00000001851D1D00-0x00000001851D22E0
		public void ClearComponent(); // 0x0000000186BB1920-0x0000000186BB1960
		private void _AutoCloseToggleObjWhenOut(); // 0x000000018714D300-0x000000018714D3D0
		public static void AddToAutoCloseLayer(GameObject go); // 0x00000001864D95D0-0x00000001864D96C0
		public static void RemoveFromAutoCloseLayer(GameObject go); // 0x00000001864D9480-0x00000001864D9530
		public static bool IsTopAutoCloseLayer(GameObject go); // 0x000000018652F1A0-0x000000018652F290
		private Camera _GetUICamera(); // 0x000000018531BBF0-0x000000018531BD70
		public void InitBinding(); // 0x00000001864D91E0-0x00000001864D93D0
		private void _UpdateState(); // 0x00000001864D96C0-0x00000001864D97E0
		protected override void OnDestroy(); // 0x0000000185F2D030-0x0000000185F2D0D0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000189572D4C-0x0000000189572D54
	}

	public class UIBigLogo : MonoBehaviour // TypeDefIndex: 74441
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
		public UIBigLogo(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void SetBigLogoEditor(string bigLogoPath, bool useStretchImage, bool showOnTop, bool hideBackground, bool useOriginalImage, bool useFitImage, float fitViewportAspectRatio); // 0x0000000184E53540-0x0000000184E535D0
		public void ShowBigLogo(bool useStretchImage, bool showOnTop, bool useOriginalImage, bool useFitImage, float originalImageScale); // 0x000000018D217A60-0x000000018D217D18
		public void SetBigLogoMask(UnityEngine.Color maskColor); // 0x000000018D217888-0x000000018D21799C
		public void ClearBigLogoMask(); // 0x000000018D2173B4-0x000000018D217464
		public void ClearBigLogo(bool showOnTop); // 0x000000018D217464-0x000000018D217658
		public void SetAlpha(float alpha, bool showOnTop); // 0x000000018D217658-0x000000018D217888
		public void SetMaskAlpha(float alpha); // 0x000000018D21799C-0x000000018D217A60
	}

	public class UIBigRectButton : UIButton, IDragHandler, IBeginDragHandler, IEndDragHandler, UnityEngine.EventSystems.IScrollHandler // TypeDefIndex: 74442
	{
		// Fields
		[SerializeField]
		private UIBigRectHelper _bigRectHelper; // 0x2E8
	
		// Constructors
		public UIBigRectButton(); // 0x00000001867FE2C0-0x00000001867FE2D0
	
		// Methods
		private void _TryThroughEventDataToBigRectTouchPanelRaycast<T>(PointerEventData eventData, ExecuteEvents.EventFunction<T> eventFunction)
			where T : IEventSystemHandler;
		public override void OnPointerDown(PointerEventData eventData); // 0x00000001870780B0-0x0000000187078160
		public override void OnPointerUp(PointerEventData eventData); // 0x0000000187078000-0x00000001870780B0
		public void OnDrag(PointerEventData eventData); // 0x000000018D217DC4-0x000000018D217E70
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018D217D18-0x000000018D217DC4
		public void OnEndDrag(PointerEventData eventData); // 0x000000018D217E70-0x000000018D217F1C
		public void OnScroll(PointerEventData eventData); // 0x000000018D217F1C-0x000000018D217FC8
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0); // 0x000000018D217FC8-0x000000018D217FD0
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0); // 0x000000018D217FD0-0x000000018D217FD8
	}

	public class UIBigRectHelper : TickableUIMono, IUIClearable // TypeDefIndex: 74445
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
		private const string CLICK_ACTION_ID = "big_rect_click"; // Metadata: 0x026281EE
		private const string CLICK_NO_HINT_ACTION_ID = "big_rect_click_no_hint"; // Metadata: 0x026281FD
		private const float DELTA_TIME_TO_STICK_VALUE_RATIO = 100f; // Metadata: 0x02628214
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
		protected override TickType tickOption { get; } // 0x0000000186B7EF20-0x0000000186B7EF50 
		public DisposedUnityEvent OnOpenTweenFinished { get; } // 0x0000000187225170-0x00000001872251A0 
		private float zoomRangeMin { get; } // 0x0000000185FBAC50-0x0000000185FBAC90 
		public DisposedUnityEvent<int, bool> zoomEvent { get; } // 0x0000000187225140-0x0000000187225170 
		public UITouchPanel touchPanel { get; } // 0x000000018D218EE8-0x000000018D218F2C 
		public int clickBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187258C60-0x0000000187258C70 0x0000000187258C80-0x0000000187258C90
		public bool controllerMoveEnabled { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187250BC0-0x0000000187250BD0 0x0000000187250BD0-0x0000000187250BE0
		public bool controllerZoomEnabled { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187258C70-0x0000000187258C80 0x0000000187258C90-0x0000000187258CA0
	
		// Nested types
		public sealed class BigRectRecoverState // TypeDefIndex: 74443
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
			public BigRectRecoverState(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0 // TypeDefIndex: 74444
		{
			// Fields
			public TweenCallback onComplete; // 0x10
	
			// Constructors
			public __c__DisplayClass82_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _FocusNode_b__0(); // 0x00000001871F5E80-0x00000001871F5EA0
		}
	
		// Constructors
		public UIBigRectHelper(); // 0x0000000186881B20-0x0000000186881E10
	
		// Methods
		protected override void OnAwake(); // 0x000000018531C960-0x000000018531CB50
		public override void Tick(float deltaTime); // 0x0000000186324F00-0x0000000186324F40
		public override void LateTick(float deltaTime); // 0x0000000185FBB930-0x0000000185FBB970
		protected override void OnRelease(); // 0x0000000186E61E50-0x0000000186E61EB0
		private void _OnDrag(Vector2 value); // 0x0000000186B202C0-0x0000000186B20380
		public void ManuallyZoom(float value, bool needTween); // 0x000000018D21852C-0x000000018D21857C
		[IDTag(1)]
		private void _RefreshPivotPosition(); // 0x0000000185FBAA70-0x0000000185FBAB00
		private void _OnZoom(float value, bool needTween); // 0x0000000185FBAA20-0x0000000185FBAA70
		private void _SetZoomValueAndScale(float value, bool needTween); // 0x0000000185FBAB00-0x0000000185FBAC50
		private void _SetScale(bool needTween, float zoomTweenTime = 0f /* Metadata: 0x026281E8 */, AnimationCurve curve = null, TweenCallback onFinish = null); // 0x0000000185FBAC90-0x0000000185FBAF50
		private void _GetContainerRectBounds(out Vector2 leftBottom, out Vector2 rightTop); // 0x0000000185CE0C30-0x0000000185CE0DA0
		private Vector2 _GetAdjustedPosition(Vector2 position); // 0x0000000185CE09A0-0x0000000185CE0BB0
		private void _PosAdjust(); // 0x0000000185CE0930-0x0000000185CE09A0
		private void _RefreshPivotPositionToMousePosition(); // 0x0000000185FBAF50-0x0000000185FBB110
		[IDTag(0)]
		private void _RefreshPivotPosition(Vector3 targetScreenPosition); // 0x0000000185FBB110-0x0000000185FBB7D0
		private void _UpdatePositionOffsetAfterZoomed(); // 0x0000000185CE0DA0-0x0000000185CE0F30
		private void _TryAlignWhenInit(); // 0x0000000186C208C0-0x0000000186C20AB0
		public void Init(); // 0x0000000185FBA650-0x0000000185FBA9A0
		[IDTag(0)]
		public void FocusNode(float nodeX, float nodeY, TweenCallback onComplete); // 0x000000018D218154-0x000000018D218308
		[IDTag(1)]
		public void FocusNode(RectTransform nodeRect, bool needTween = true /* Metadata: 0x026281EC */, TweenCallback onComplete = null); // 0x00000001856BC700-0x00000001856BCB20
		public void ZoomToFullRect(TweenCallback onComplete = null); // 0x000000018D218748-0x000000018D2187CC
		public void ChangePaddingRight(int right); // 0x000000018D217FD8-0x000000018D218044
		public void SetZoomRangeMax(float maxValue); // 0x0000000187184C10-0x0000000187184C40
		public void OverrideZoomRangeMin(float minValue); // 0x0000000187184C40-0x0000000187184C70
		public void SyncZoomValue(float zoomValue, bool needTween = true /* Metadata: 0x026281ED */); // 0x0000000185FBA610-0x0000000185FBA650
		public BigRectRecoverState GetRecoverState(); // 0x000000018D218308-0x000000018D2184B4
		public void GetZoomRange(out float rangeMin, out float rangeMax); // 0x000000018D2184B4-0x000000018D21852C
		public float GetCurrentZoomValue(); // 0x0000000186FB86D0-0x0000000186FB8700
		public void ChangePivotPositionToTarget(RectTransform target); // 0x000000018D218044-0x000000018D218154
		public void ResetPivotPositionToScreenCenter(); // 0x0000000185FBA580-0x0000000185FBA610
		public void RecoverContainerState(BigRectRecoverState state); // 0x000000018D21857C-0x000000018D218748
		public void ClearComponent(); // 0x0000000186AEBEE0-0x0000000186AEBFD0
		public void ClearAllTween(); // 0x0000000186AEBFD0-0x0000000186AEC060
		private void _InitControllerBindings(); // 0x000000018531C760-0x000000018531C960
		private bool _GetIsControllerMoveEnabled(); // 0x0000000186325140-0x0000000186325190
		private bool _GetIsControllerZoomEnabled(); // 0x0000000186325080-0x00000001863250D0
		private void _ResetControllerState(); // 0x0000000185FBB7D0-0x0000000185FBB930
		private void _TickRefreshController(float deltaTime); // 0x0000000186324F40-0x0000000186324FA0
		private void _TickRefreshControllerStickMove(float deltaTime); // 0x00000001863250D0-0x0000000186325140
		private void _RefreshControllerFocusRaycastResults(bool ignoreTouchPanel, out Selectable hitSelectable, out UITouchPanel hitTouchPanel); // 0x000000018D2189A4-0x000000018D218EE8
		private void _TickCheckControllerFocusRaycastTargets(); // 0x0000000185FBB970-0x0000000185FBB9E0
		private void _OnControllerClick(); // 0x000000018D2187CC-0x000000018D2189A4
		private void _TickRefreshControllerStickZoom(float deltaTime); // 0x0000000186324FA0-0x0000000186324FF0
		private void _TickRefreshControllerZoomKeyHint(); // 0x0000000186324FF0-0x0000000186325080
		[CompilerGenerated]
		private void _OnAwake_b__63_0(PointerEventData eventData); // 0x0000000186B20230-0x0000000186B202C0
		[CompilerGenerated]
		private void _OnAwake_b__63_1(float zoomValue); // 0x0000000185FBA9A0-0x0000000185FBAA20
		[CompilerGenerated]
		private void __SetScale_b__72_0(); // 0x0000000185CE0910-0x0000000185CE0930
		[CompilerGenerated]
		private void _Init_b__80_0(); // 0x0000000186EDBCE0-0x0000000186EDBEC0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	public class UIBlendImage : UIImage // TypeDefIndex: 74446
	{
		// Fields
		private static Dictionary<string, Material> s_materials; // 0x00
		private Material m_originalMaterial; // 0x228
		private bool m_initialized; // 0x230
	
		// Constructors
		public UIBlendImage(); // 0x000000018D2193F0-0x000000018D2193F8
		static UIBlendImage(); // 0x000000018D219364-0x000000018D2193F0
	
		// Methods
		public void SetMaterialKey(string key); // 0x000000018D219054-0x000000018D2192E8
		public void SetColor(string materialId, UnityEngine.Color c); // 0x000000018D218FC4-0x000000018D219054
		public void SetTexture(string materialId, Texture t); // 0x000000018D2192E8-0x000000018D219364
		public static void ClearMaterialCache(); // 0x000000018D218F2C-0x000000018D218FC4
	}

	public class UIBlurMono : TickableUIMono // TypeDefIndex: 74447
	{
		// Fields
		private Canvas m_canvas; // 0x68
		private LuaPanel m_panel; // 0x70
		private int m_sortingOrder; // 0x78
		private HGCamera m_camera; // 0x80
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001869A8100-0x00000001869A8130 
		public Canvas canvas { get; } // 0x000000018531E0D0-0x000000018531E190 
		private LuaPanel panel { get; } // 0x000000018531DAD0-0x000000018531DC40 
	
		// Constructors
		public UIBlurMono(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		protected override void OnEnable(); // 0x000000018531D6F0-0x000000018531D7F0
		protected override void OnDisable(); // 0x000000018531CDF0-0x000000018531CE50
		public override void Tick(float deltaTime); // 0x000000018531DD40-0x000000018531E0D0
		public void UpdateSortingOrder(int order); // 0x000000018531CB50-0x000000018531CBD0
		private HGCamera _GetCamera(); // 0x000000018531D250-0x000000018531D4B0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	[RequireComponent(typeof(RawImage))]
	public class UIBlurRT : MonoBehaviour // TypeDefIndex: 74448
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
		public RawImage rawImage { get; } // 0x0000000186D27A80-0x0000000186D27AB0 
		public Texture customBlurTexture { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
	
		// Constructors
		public UIBlurRT(); // 0x00000001871EC620-0x00000001871EC650
	
		// Methods
		private void Reset(); // 0x000000018D21B77C-0x000000018D21B800
		public void InitRT(); // 0x00000001859F8400-0x00000001859F8750
		public void Register(); // 0x00000001859F7910-0x00000001859F7AA0
		public void UnRegister(); // 0x000000018D21B800-0x000000018D21B8F8
		public void UpdateRT(); // 0x000000018D21B8F8-0x000000018D21B9CC
		private void OnEnable(); // 0x00000001859F6A60-0x00000001859F6AB0
		private void OnDisable(); // 0x00000001859F6AB0-0x00000001859F6AF0
		private void OnDestroy(); // 0x0000000187222450-0x0000000187222480
		private void _Clear(); // 0x00000001859F82C0-0x00000001859F8400
		public void SetUseSceneColorPS(bool useSceneColorPS, bool forceUpdate = false /* Metadata: 0x02628218 */); // 0x0000000185FCDF70-0x0000000185FCE0F0
		public void SetCustomBlurImg(Texture texture); // 0x0000000185FCCDA0-0x0000000185FCCEF0
	}

	public class UIButton : Selectable, IPointerClickHandler, IBindingGroupTarget, IBindingView, IUIClearable // TypeDefIndex: 74451
	{
		// Fields
		[AudioString]
		[FormerlySerializedAs("_audioClick")]
		[SerializeField]
		private string _audioPressStart; // 0x190
		[AudioString]
		[SerializeField]
		private string _audioOnClick; // 0x198
		[AudioString]
		[SerializeField]
		private string _audioRelease; // 0x1A0
		[AudioString]
		[SerializeField]
		private string _audioLongPress; // 0x1A8
		[AudioString]
		[SerializeField]
		private string _audioInvalid; // 0x1B0
		[SerializeField]
		[Tooltip("AutoTriggerOnClick\u65F6\u4E0D\u89E6\u53D1PressStart\u548COnClick\u7684\u97F3\u6548")]
		private bool _noAudioWhenAutoTriggerOnClick; // 0x1B8
		private const float MIN_DRAG_DIST = 10f; // Metadata: 0x0262821A
		private const float DOUBLE_CLICK_MAX_INTERVAL = 0.3f; // Metadata: 0x0262821E
		public UIEvent<PointerEventData> onClick; // 0x1C0
		public UIEvent<PointerEventData> onDoubleClick; // 0x1C8
		[SerializeField]
		public bool _ignoreClickOnDrag; // 0x1D0
		[SerializeField]
		public bool _clickThrough; // 0x1D1
		[SerializeField]
		[Tooltip("\u53EA\u662F\u4E24\u6B21\u5355\u51FB\u89E6\u53D1\u7684CD")]
		private float _clickCd; // 0x1D4
		[SerializeField]
		[Tooltip("\u4E0D\u53EF\u70B9\u51FB\u65F6\u5F39\u51FA\u7684Toast\u6587\u672CKey")]
		private LangKey _invalidClickLangKey; // 0x1D8
		private float m_lastValidClickTime; // 0x1E8
		private float m_lastClickTime; // 0x1EC
		[SerializeField]
		private bool _useClickAnimation; // 0x1F0
		[SerializeField]
		private AnimationCurve _clickAnimationCurve; // 0x1F8
		[SerializeField]
		private float _clickAnimationDuration; // 0x200
		private Vector3 m_oriScale; // 0x204
		private Coroutine m_clickCor; // 0x210
		private bool m_scaled; // 0x218
		public UIEvent<PointerEventData> onLongPress; // 0x220
		public UIEvent<PointerEventData> onPressStart; // 0x228
		public UIEvent<PointerEventData> onPressEnd; // 0x230
		[SerializeField]
		private float _longPressTime; // 0x238
		[SerializeField]
		public bool _ignoreClickOnLongPress; // 0x23C
		[FormerlySerializedAs("_longPressImg")]
		public UIImage longPressImg; // 0x240
		[SerializeField]
		private float _longPressImgShowDelay; // 0x248
		[SerializeField]
		private float _longPressMaxDragDist; // 0x24C
		[SerializeField]
		private bool _forceEnableButtonPressAudio; // 0x250
		private bool m_pressDownWaitClick; // 0x251
		[CompilerGenerated]
		private Vector2 _startPressPos_k__BackingField; // 0x254
		[CompilerGenerated]
		private int _pressTouchId_k__BackingField; // 0x25C
		private Coroutine m_longPressCor; // 0x260
		private bool m_triggeredLongPress; // 0x268
		public bool noTextBtn; // 0x269
		private UIText m_autoFindLabel; // 0x270
		[SerializeField]
		private UIText _label; // 0x278
		private int m_groupId; // 0x280
		private bool m_bindingInit; // 0x284
		[CompilerGenerated]
		private InputBindingGroupMonoTarget _parent_k__BackingField; // 0x288
		private string m_customBindingViewLabelText; // 0x290
		public string hintTextId; // 0x298
		[CompilerGenerated]
		private readonly DisposedUnityEvent _bindingViewUpdateEvent_k__BackingField; // 0x2A0
		[SerializeField]
		private RectTransform _redDotTrans; // 0x2A8
		[AudioString]
		[SerializeField]
		private string _audioGamePadLongPress; // 0x2B0
		private LuaPanel m_panel; // 0x2B8
		private int m_hoverBindingGroupId; // 0x2C0
		[NonSerialized]
		public string clickHintTextId; // 0x2C8
		[NonSerialized]
		public string longPressHintTextId; // 0x2D0
		[FormerlySerializedAs("actionOnSetNaviTarget")]
		[SerializeField]
		private ActionOnSetNaviTarget _actionOnSetNaviTarget; // 0x2D8
		[FormerlySerializedAs("useNoHintAction")]
		[SerializeField]
		private bool _useNoHintAction; // 0x2DC
		[CompilerGenerated]
		private int _hoverConfirmBindingId_k__BackingField; // 0x2E0
	
		// Properties
		public Vector2 startPressPos { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187258CB0-0x0000000187258CD0 0x0000000187258CE0-0x0000000187258CF0
		public int pressTouchId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187258CA0-0x0000000187258CB0 0x0000000187258CD0-0x0000000187258CE0
		public float longPressTime { get; } // 0x000000018D21C05C-0x000000018D21C0A4 
		public Vector2 curPressPos { get; } // 0x000000018D21BF84-0x000000018D21C018 
		public bool triggeredLongPress { get; } // 0x000000018D21C208-0x000000018D21C24C 
		public string text { get; set; } // 0x000000018D21C12C-0x000000018D21C208 0x000000018685E4C0-0x000000018685E620
		public UIText label { get; } // 0x000000018685E620-0x000000018685E810 
		public bool groupEnabled { get; } // 0x00000001855B4610-0x00000001855B4680 
		public int groupId { get; } // 0x00000001853A8FE0-0x00000001853A9020 
		public IBindingGroupTarget parentTarget { get; } // 0x000000018D21C0A4-0x000000018D21C0E8 
		public InputBindingGroupMonoTarget parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C0F0-0x000000018723C100 0x0000000188DC4BD8-0x0000000188DC4BEC
		public string bindingViewActionId { get; } // 0x00000001865A9590-0x00000001865A9640 
		public string customBindingViewLabelText { get; set; } // 0x000000018D21C018-0x000000018D21C05C 0x00000001866E5B80-0x00000001866E5C20
		public string bindingViewLabelText { get; } // 0x0000000186B74690-0x0000000186B746C0 
		public string hintText { get; } // 0x0000000186B746C0-0x0000000186B747E0 
		public DisposedUnityEvent bindingViewUpdateEvent { [CompilerGenerated] get; } // 0x000000018723BE30-0x000000018723BE40 
		public RectTransform redDotTrans { get; } // 0x000000018D21C0E8-0x000000018D21C12C 
		public bool bindingEnabled { get; } // 0x000000018D21BF48-0x000000018D21BF84 
		public BindingViewState bindingViewState { get; } // 0x0000000185028120-0x00000001850285C0 
		public LuaPanel panel { get; } // 0x00000001850354D0-0x0000000185035560 
		public int hoverBindingGroupId { get; } // 0x00000001851DDF90-0x00000001851DDFD0 
		public ActionOnSetNaviTarget actionOnSetNaviTarget { get; } // 0x000000018D21BF04-0x000000018D21BF48 
		public int hoverConfirmBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018566EB20-0x000000018566EB30 0x000000018723DC10-0x000000018723DC20
		bool IBindingView.interactable { get; } // 0x000000018D21B9CC-0x000000018D21BA10 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __DoClickAnimation_d__30 : IEnumerator<object> // TypeDefIndex: 74449
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIButton __4__this; // 0x20
			private float _currentTime_5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __DoClickAnimation_d__30(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D21B594-0x000000018D21B6E4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D21B6E4-0x000000018D21B730
		}
	
		[CompilerGenerated]
		private sealed class __OnPress_d__59 : IEnumerator<object> // TypeDefIndex: 74450
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __OnPress_d__59(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x0000000186566E30-0x00000001865670D0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D21B730-0x000000018D21B77C
		}
	
		// Constructors
		public UIButton(); // 0x000000018548D210-0x000000018548D530
	
		// Methods
		protected override void Awake(); // 0x000000018531F9E0-0x000000018531FA40
		protected override void OnEnable(); // 0x000000018503BE40-0x000000018503BF00
		protected override void OnDisable(); // 0x000000018503BC40-0x000000018503BD70
		protected override void OnDestroy(); // 0x00000001850420E0-0x00000001850421F0
		protected override void _NotifyIsHover(bool isHover); // 0x0000000185045430-0x0000000185045550
		public virtual void OnPointerClick(PointerEventData eventData); // 0x0000000185034D40-0x0000000185035150
		private void _Press(PointerEventData eventData = null); // 0x0000000185035210-0x00000001850354D0
		private void _PlayClickAnimation(bool reverse = false /* Metadata: 0x02628219 */); // 0x00000001850357D0-0x0000000185035810
		[IteratorStateMachine(typeof(__DoClickAnimation_d__30))]
		private IEnumerator _DoClickAnimation(); // 0x000000018D21BC30-0x000000018D21BCC8
		public override void OnPointerDown(PointerEventData eventData); // 0x0000000185035560-0x0000000185035760
		public override void OnPointerUp(PointerEventData eventData); // 0x0000000185035150-0x0000000185035210
		[IteratorStateMachine(typeof(__OnPress_d__59))]
		private IEnumerator _OnPress(PointerEventData eventData); // 0x0000000185035760-0x00000001850357D0
		private void _StopLongPressCor(); // 0x000000018503BD70-0x000000018503BE40
		public void ClearComponent(); // 0x0000000185042460-0x0000000185042730
		public void InitBinding(); // 0x00000001853A9020-0x00000001853A96A0
		public override void OnInteractableChanged(); // 0x0000000186B9EFF0-0x0000000186B9F020
		private void _UpdateState(); // 0x00000001851DD290-0x00000001851DD4A0
		private bool _IsAnyButtonEventActionInGuideUse(); // 0x00000001853A8500-0x00000001853A8CE0
		public string GetBindingViewActionId(BindingViewActionType actionType); // 0x00000001865A9500-0x00000001865A9590
		void IBindingView.OnInputKeyDown(bool isActionTrigger); // 0x0000000186CE8B20-0x0000000186CE8CA0
		void IBindingView.OnInputKeyUp(bool isActionTrigger); // 0x0000000186B92E10-0x0000000186B92F60
		private void _OnUpdateKey(); // 0x00000001865B1E30-0x00000001865B1E70
		private string _GetUIButtonKeyHintActionId(UIEvent<PointerEventData> buttonEvent); // 0x00000001853A8CE0-0x00000001853A8D30
		protected override void _RefreshHoverEnableNode(bool active); // 0x00000001851DDB80-0x00000001851DDEC0
		public override bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId); // 0x000000018D21BA10-0x000000018D21BA80
		public override void OnNaviTargetEnabledAgain(); // 0x000000018D21BA80-0x000000018D21BB1C
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode); // 0x000000018D21BCC8-0x000000018D21BE60
		private void _InitActionOnSetNaviTarget(); // 0x0000000185041F20-0x0000000185042060
		private void _ToggleNaviInputBinding(bool active); // 0x000000018D21BE60-0x000000018D21BF04
		public void ChangeActionOnSetNaviTarget(ActionOnSetNaviTarget action); // 0x0000000186934C60-0x0000000186934CE0
		[CompilerGenerated]
		private void _InitBinding_b__82_0(); // 0x0000000185033060-0x0000000185033070
		[CompilerGenerated]
		private void _InitBinding_b__82_1(); // 0x000000018D21BB1C-0x000000018D21BB68
		[CompilerGenerated]
		private void _InitBinding_b__82_2(); // 0x000000018D21BB68-0x000000018D21BBB4
		[CompilerGenerated]
		private void _InitBinding_b__82_3(); // 0x0000000186C027F0-0x0000000186C02840
		[CompilerGenerated]
		private void _InitBinding_b__82_4(); // 0x0000000186C027A0-0x0000000186C027F0
		[CompilerGenerated]
		private void __InitActionOnSetNaviTarget_b__133_0(); // 0x000000018D21BBE4-0x000000018D21BC30
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0); // 0x000000018D21BBC4-0x000000018D21BBCC
		public void __iFixBaseProxy_OnPointerUp(PointerEventData P0); // 0x000000018D21BBCC-0x000000018D21BBD4
		public void __iFixBaseProxy_Awake(); // 0x000000018D1F7518-0x000000018D1F7520
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D1F7528-0x000000018D1F7530
		public void __iFixBaseProxy_OnDisable(); // 0x0000000185C2D7B0-0x0000000185C2D7C0
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D1F7520-0x000000018D1F7528
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018D21BBD4-0x000000018D21BBDC
		public void __iFixBaseProxy_OnInteractableChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy__RefreshHoverEnableNode(bool P0); // 0x000000018D21BBDC-0x000000018D21BBE4
		public bool __iFixBaseProxy_GetMouseActionHints(out string P0, out string P1); // 0x000000018D21BBB4-0x000000018D21BBBC
		public void __iFixBaseProxy_OnNaviTargetEnabledAgain(); // 0x000000018D21BBBC-0x000000018D21BBC4
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public enum CanvasMatchMode // TypeDefIndex: 74452
	{
		Width = 0,
		Height = 1
	}

	public class UICanvasScaleHelper : MonoBehaviour, DeviceInfoManager.IScreenSizeListener, IUIClearable // TypeDefIndex: 74455
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
		public float standardHorizontalResolution { get; } // 0x0000000185195AE0-0x0000000185195B20 
		public float standardVerticalResolution { get; } // 0x0000000185195AA0-0x0000000185195AE0 
		public float standardResolutionScale { get; } // 0x0000000185195B20-0x0000000185195B80 
		public HashSet<CanvasScaler> canvasScalerList { get; } // 0x000000018D21C460-0x000000018D21C4A0 
	
		// Nested types
		public struct FWorldCanvasParams // TypeDefIndex: 74453
		{
			// Fields
			public float screenRatio; // 0x00
			public Vector2 screenSize; // 0x04
			public Vector2 uiRootSize; // 0x0C
			public Vector3 uiRootScale; // 0x14
		}
	
		public struct FScreenCanvasParams // TypeDefIndex: 74454
		{
			// Fields
			public float screenRatio; // 0x00
			public Vector2 screenSize; // 0x04
			public CanvasMatchMode matchMode; // 0x0C
			public float matchWidthOrHeight; // 0x10
		}
	
		// Constructors
		public UICanvasScaleHelper(); // 0x0000000186A89F90-0x0000000186A8A100
	
		// Methods
		private void Awake(); // 0x0000000185194BE0-0x0000000185194C10
		private void _OnInit(); // 0x0000000185194C10-0x0000000185194D10
		private void Start(); // 0x00000001851ACB00-0x00000001851ACC80
		private void OnDestroy(); // 0x00000001851AC970-0x00000001851ACB00
		public void UpdateCanvas(); // 0x00000001851AE1C0-0x00000001851AE7C0
		public void OnScreenSizeChanged(int width, int height); // 0x00000001851ADDD0-0x00000001851ADE20
		public void AddCanvas(Canvas c, CanvasScaler s); // 0x00000001851952D0-0x00000001851953A0
		public void RemoveCanvas(Canvas c, CanvasScaler s); // 0x0000000185195120-0x0000000185195190
		private void _OnInputTypeChanged(); // 0x000000018D21C29C-0x000000018D21C460
		private void _CanvasOnWillRenderCanvases(); // 0x0000000186111F10-0x0000000186111F60
		public static FWorldCanvasParams CalcWorldCanvasParams(Camera camera, Transform uiRoot, bool useLocalPos = false /* Metadata: 0x02628224 */); // 0x00000001851AE7C0-0x00000001851AE9C0
		public static FScreenCanvasParams CalcScreenCanvasParams(); // 0x00000001851951E0-0x0000000185195270
		public static float CalcCurrentScreenRatio(out Vector2 screenSize); // 0x0000000185195270-0x00000001851952D0
		public Vector2 GetProperCanvasResolution(); // 0x0000000185195A30-0x0000000185195AA0
		public void ForceCanvasUpdate(); // 0x000000018D21C24C-0x000000018D21C29C
		public void ClearComponent(); // 0x00000001851AC910-0x00000001851AC970
	}

	public class UIColorGroup : NonDrawingGraphic // TypeDefIndex: 74459
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
		public override UnityEngine.Color color { get; set; } // 0x000000018D21CEF8-0x000000018D21CF58 0x000000018D21CF58-0x000000018D21D064
	
		// Nested types
		private struct CommonParams // TypeDefIndex: 74456
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
	
		private delegate void GraphicOpt(Graphic graphic, CommonParams param); // TypeDefIndex: 74457; 0x00000001827C6B90-0x00000001827C6BC0
	
		private struct DynEle // TypeDefIndex: 74458
		{
			// Fields
			public string groupId; // 0x00
			public Graphic graphic; // 0x08
			public bool useStaticColor; // 0x10
		}
	
		// Constructors
		public UIColorGroup(); // 0x000000018707F0B0-0x000000018707F0D0
	
		// Methods
		public void AttachGraphic(Graphic graphic, bool useStaticColor = true /* Metadata: 0x02628225 */); // 0x000000018D21C4A0-0x000000018D21C710
		public void AttachGraphicsWithGroup(List<Graphic> graphic, string groupId); // 0x000000018D21C710-0x000000018D21CA28
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale); // 0x000000018D21CA28-0x000000018D21CB48
		[IDTag(0)]
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB); // 0x000000018D21CB48-0x000000018D21CC88
		[IDTag(1)]
		public override void CrossFadeColor(UnityEngine.Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha); // 0x0000000186B2F990-0x0000000186B2FA90
		private void _ApplyOptToGraphics(GraphicOpt opt, CommonParams param); // 0x0000000186B2FB10-0x0000000186B2FDF0
		private static void _CrossFadeAlpha(Graphic graphic, CommonParams param); // 0x000000018D21CD24-0x000000018D21CDA8
		private static void _CrossFadeColorRGB(Graphic graphic, CommonParams param); // 0x000000018D21CDA8-0x000000018D21CE6C
		private static void _CrossFadeColorAlpha(Graphic graphic, CommonParams param); // 0x0000000186D31740-0x0000000186D317D0
		private static void _SetColor(Graphic graphic, CommonParams param); // 0x000000018D21CE6C-0x000000018D21CEF8
		public UnityEngine.Color __iFixBaseProxy_get_color(); // 0x0000000187238F60-0x0000000187238F70
		public void __iFixBaseProxy_set_color(UnityEngine.Color P0); // 0x000000018D21CD04-0x000000018D21CD24
		public void __iFixBaseProxy_CrossFadeAlpha(float P0, float P1, bool P2); // 0x000000018D21CC88-0x000000018D21CC98
		public void __iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, float P1, bool P2, bool P3, bool P4); // 0x000000018D21CCC8-0x000000018D21CD04
		public void __iFixBaseProxy_CrossFadeColor(UnityEngine.Color P0, float P1, bool P2, bool P3); // 0x000000018D21CC98-0x000000018D21CCC8
	}

	public class UIControllerKeyIcon : MonoBehaviour // TypeDefIndex: 74460
	{
		// Fields
		[SerializeField]
		[Tooltip("\u65E0\u9700\u586B\u5199\u56FE\u7247\u5B8C\u6574\u540D\u79F0\uFF0C\u53EA\u9700\u586B\u5199\u5DEE\u5206\u90E8\u5206\uFF0C\u4F8B\u5982icon_playstation_arrowdown\uFF0C\u5219\u53EA\u9700\u586B\u5199arrowdown")]
		private string _keyIconName; // 0x18
		private UIImage m_image; // 0x20
		private static List<UIControllerKeyIcon> s_iconCache; // 0x00
		private static bool s_initialized; // 0x08
	
		// Constructors
		public UIControllerKeyIcon(); // 0x000000018548CC60-0x000000018548CC80
		static UIControllerKeyIcon(); // 0x00000001871139A0-0x0000000187113A40
	
		// Methods
		private static void _TryStaticInit(); // 0x000000018D21D594-0x000000018D21D718
		private static void _OnControllerTypeChange(Beyond.DeviceInfo.ControllerType controllerType); // 0x000000018D21D3F4-0x000000018D21D594
		private void Awake(); // 0x000000018D21D064-0x000000018D21D114
		private void OnEnable(); // 0x000000018D21D1C0-0x000000018D21D274
		private void OnDisable(); // 0x000000018D21D114-0x000000018D21D1C0
		public void SetKeyIconName(GamepadKeyCode keyCode); // 0x000000018D21D350-0x000000018D21D3F4
		public void RefreshKeyIcon(); // 0x000000018D21D274-0x000000018D21D350
	}

	public class UICustomLayout : UIBehaviour // TypeDefIndex: 74461
	{
		// Fields
		[SerializeField]
		private RectTransform _dragArea; // 0x18
		public List<UICustomLayoutHandle> layoutHandles; // 0x20
		private JSONArray m_eventLog; // 0x28
	
		// Properties
		public RectTransform dragArea { get; } // 0x000000018D220864-0x000000018D2208A4 
	
		// Constructors
		public UICustomLayout(); // 0x000000018D2207AC-0x000000018D220864
	
		// Methods
		protected override void Awake(); // 0x000000018D21FBA8-0x000000018D21FCE8
		public bool IsDirty(); // 0x000000018D21FCE8-0x000000018D21FE4C
		public void ResetToDefault(bool saveChanges); // 0x000000018D21FE4C-0x000000018D21FFE4
		public void Save(int ratio = 0 /* Metadata: 0x02628226 */); // 0x000000018D21FFE4-0x000000018D220284
		private void _LogEvent(Dictionary<UICustomLayoutElement, UICustomLayoutElement.LayoutData> layoutDataMap); // 0x000000018D220284-0x000000018D2207AC
		public void __iFixBaseProxy_Awake(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UICustomLayoutElement : UIBehaviour, IUIClearable // TypeDefIndex: 74464
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
		public string elementKey { get; } // 0x000000018D21E25C-0x000000018D21E29C 
		public RectTransform highlightRect { get; } // 0x000000018D21E29C-0x000000018D21E330 
		public float scale { get; set; } // 0x000000018D21E3B4-0x000000018D21E3F8 0x000000018D21E4B0-0x000000018D21E4F0
		public float alpha { get; set; } // 0x000000018D21E218-0x000000018D21E25C 0x000000018D21E3F8-0x000000018D21E438
		public Vector2 position { get; set; } // 0x000000018D21E370-0x000000018D21E3B4 0x000000018D21E470-0x000000018D21E4B0
		public LayoutType layoutType { get; set; } // 0x000000018D21E330-0x000000018D21E370 0x000000018D21E438-0x000000018D21E470
		public LuaPanel panel { get; } // 0x0000000185194870-0x0000000185194920 
	
		// Nested types
		public enum LayoutType // TypeDefIndex: 74462
		{
			None = 0,
			LeftToRight = 1
		}
	
		public class LayoutData // TypeDefIndex: 74463
		{
			// Fields
			public int verNum; // 0x10
			public float scale; // 0x14
			public float alpha; // 0x18
			public Vector2 position; // 0x1C
			public int layoutType; // 0x24
	
			// Constructors
			public LayoutData(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public UICustomLayoutElement(); // 0x0000000186C34CA0-0x0000000186C34D50
	
		// Methods
		protected override void Awake(); // 0x0000000185193C50-0x0000000185193D80
		protected override void Start(); // 0x0000000186EB5F30-0x0000000186EB5FB0
		protected override void OnDestroy(); // 0x000000018D21DA8C-0x000000018D21DB80
		public void ResetToDefault(); // 0x000000018D21DC1C-0x000000018D21DCE0
		private void _ApplyPosition(); // 0x000000018D21DFAC-0x000000018D21E014
		private void _ApplyAlpha(); // 0x000000018D21DEC0-0x000000018D21DFAC
		private void _ApplyScale(); // 0x000000018D21E014-0x000000018D21E0E4
		private void _SetDefaultValues(); // 0x0000000185193D80-0x0000000185193FB0
		public string GetElementKeyWithRatio(int ratio = 0 /* Metadata: 0x02628227 */); // 0x000000018D21D76C-0x000000018D21D844
		private bool _CheckElementKeyIsValid(); // 0x000000018D21E0E4-0x000000018D21E1E0
		public bool SaveData(out LayoutData layoutData, bool isResetToDefault = false /* Metadata: 0x02628228 */, int ratio = 0 /* Metadata: 0x02628229 */); // 0x000000018D21DCE0-0x000000018D21DEC0
		public void LoadData(); // 0x000000018D21D844-0x000000018D21DA8C
		private void _OnHudLayoutSaved(); // 0x000000018D21E1E0-0x000000018D21E218
		private Vector2 _GetMarginSize(); // 0x0000000185194740-0x0000000185194870
		public void ClearComponent(); // 0x000000018D21D718-0x000000018D21D76C
		public static void RefreshAll(); // 0x000000018D21DB80-0x000000018D21DC1C
		public void __iFixBaseProxy_Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_Start(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UICustomLayoutHandle : UIBehaviour, IPointerClickHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 74465
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
		public float scale { get; set; } // 0x000000018D21F920-0x000000018D21F964 0x000000018D21FB24-0x000000018D21FBA8
		public float alpha { get; set; } // 0x000000018D21F7A4-0x000000018D21F7E8 0x000000018D21F964-0x000000018D21F9CC
		public Vector2 position { get; set; } // 0x000000018D21F8DC-0x000000018D21F920 0x000000018D21FA4C-0x000000018D21FB24
		public UICustomLayoutElement.LayoutType layoutType { get; set; } // 0x000000018D21F7E8-0x000000018D21F828 0x000000018D21F9CC-0x000000018D21FA4C
		public LuaPanel panel { get; } // 0x000000018D21F828-0x000000018D21F8DC 
		public UICustomLayoutElement Element { get; } // 0x000000018D21F6F0-0x000000018D21F7A4 
	
		// Constructors
		public UICustomLayoutHandle(); // 0x000000018D21F560-0x000000018D21F6F0
	
		// Methods
		protected override void Awake(); // 0x000000018D21E4F0-0x000000018D21E700
		protected override void OnDestroy(); // 0x000000018D21E960-0x000000018D21EAC8
		private void _OnElementDataLoaded(); // 0x000000018D21F3BC-0x000000018D21F464
		private void _CalculatePositionRange(); // 0x000000018D21F058-0x000000018D21F3BC
		private void _ApplyPosition(); // 0x000000018D21EF74-0x000000018D21EFE8
		private void _ApplyAlpha(); // 0x000000018D21EEA4-0x000000018D21EF0C
		private void _ApplyScale(); // 0x000000018D21EFE8-0x000000018D21F058
		private void _ApplyLayoutType(); // 0x000000018D21EF0C-0x000000018D21EF74
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018D21E800-0x000000018D21E960
		public void OnDrag(PointerEventData eventData); // 0x000000018D21EAC8-0x000000018D21EC18
		public void OnEndDrag(PointerEventData eventData); // 0x000000018D21EC18-0x000000018D21ECB0
		public bool Save(out UICustomLayoutElement.LayoutData layoutData, int ratio = 0 /* Metadata: 0x0262822C */); // 0x000000018D21EDD8-0x000000018D21EEA4
		public void ResetToDefault(); // 0x000000018D21ED04-0x000000018D21EDD8
		public bool IsDirty(); // 0x000000018D21E7BC-0x000000018D21E800
		private void _SetChanged(bool changed); // 0x000000018D21F4A4-0x000000018D21F560
		public void OnPointerClick(PointerEventData eventData); // 0x000000018D21ECB0-0x000000018D21ED04
		private void _OnSystemDisplaySizeChanged(); // 0x000000018D21F464-0x000000018D21F4A4
		public void ClearComponent(); // 0x000000018D21E700-0x000000018D21E7BC
		public void __iFixBaseProxy_Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class UIDialogText : TickableUIMono // TypeDefIndex: 74467
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
		protected override TickType tickOption { get; } // 0x0000000186FD26A0-0x0000000186FD26D0 
		private bool useAspectRatio { get; } // 0x000000018D221364-0x000000018D2213A4 
		private bool notUseAspectRatio { get; } // 0x0000000186046130-0x0000000186046170 
		public bool playing { get; } // 0x000000018D22124C-0x000000018D22129C 
		public UIText uiText { get; } // 0x000000018D221324-0x000000018D221364 
		public int totalCharacterNum { get; } // 0x000000018D2212E0-0x000000018D221324 
		public float textRevealSpeed { get; set; } // 0x000000018D22129C-0x000000018D2212E0 0x000000018D2213A4-0x000000018D2213E8
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 74466
		{
			Auto = 0,
			Manual = 1
		}
	
		// Constructors
		public UIDialogText(); // 0x0000000186EB5A40-0x0000000186EB5B00
	
		// Methods
		protected override void OnAwake(); // 0x00000001871FEFF0-0x00000001871FF040
		protected void Start(); // 0x0000000186CC18C0-0x0000000186CC1980
		protected override void OnDisable(); // 0x000000018D2210B0-0x000000018D221104
		protected override void OnEnable(); // 0x00000001871C73D0-0x00000001871C7410
		public override void Tick(float deltaTime); // 0x0000000186045D60-0x0000000186045DC0
		protected virtual void OnVisibleCharactersChanged(int count); // 0x0000000186EDC5E0-0x0000000186EDC610
		protected float GetScrollSpeed(); // 0x0000000186046170-0x00000001860461B0
		protected float GetAutoWaitTime(); // 0x00000001860460F0-0x0000000186046130
		private void _UpdateTextAuto(); // 0x0000000186045DC0-0x0000000186045F30
		private void _TryAutoScroll(); // 0x0000000186045F30-0x00000001860460F0
		public void RefreshAutoScrollData(); // 0x0000000186CC1AE0-0x0000000186CC1C20
		public void SetText(string text, bool resetPlay = true /* Metadata: 0x0262822D */); // 0x0000000186CC1A00-0x0000000186CC1AE0
		private void _RefreshPosY(); // 0x000000018D2211A0-0x000000018D22124C
		public void SeekToEnd(); // 0x000000018D221104-0x000000018D2211A0
		public void RefreshText(); // 0x00000001871C7410-0x00000001871C7460
		public void Play(); // 0x0000000186CC1980-0x0000000186CC1A00
		public virtual void ResetPlay(); // 0x0000000186045CF0-0x0000000186045D60
		public void StopPlay(); // 0x00000001860461E0-0x00000001860462A0
		public void ManualUpdateByPercent(float percent); // 0x000000018D220D60-0x000000018D220EB8
		public void ManualUpdateByTime(float time); // 0x000000018D220EB8-0x000000018D2210B0
		public virtual float GetDisplayAllCharactersTime(); // 0x000000018D220CB4-0x000000018D220D60
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class UIDialogTextWithCursor : UIDialogText // TypeDefIndex: 74468
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
		public UIDialogTextWithCursor(); // 0x000000018D220C98-0x000000018D220CB4
	
		// Methods
		public override void ResetPlay(); // 0x000000018D220C40-0x000000018D220C80
		protected override void OnVisibleCharactersChanged(int count); // 0x000000018D2208FC-0x000000018D220C40
		public override float GetDisplayAllCharactersTime(); // 0x000000018D2208A4-0x000000018D2208FC
		public void __iFixBaseProxy_ResetPlay(); // 0x000000018D220C90-0x000000018D220C98
		public void __iFixBaseProxy_OnVisibleCharactersChanged(int P0); // 0x000000018D220C88-0x000000018D220C90
		public float __iFixBaseProxy_GetDisplayAllCharactersTime(); // 0x000000018D220C80-0x000000018D220C88
	}

	public class EasyUIOptionData // TypeDefIndex: 74469
	{
		// Fields
		public int index; // 0x10
		public string optionIcon; // 0x18
		public string optionText; // 0x20
	
		// Constructors
		public EasyUIOptionData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class UIDialogTimelineOptionCell : MonoBehaviour // TypeDefIndex: 74470
	{
		// Fields
		[SerializeField]
		private UIImage _optionIcon; // 0x18
		[SerializeField]
		private UIText _optionText; // 0x20
	
		// Constructors
		public UIDialogTimelineOptionCell(); // 0x00000001878364A0-0x00000001878364B8
	}

	public class UIDialogTimelineText : MonoBehaviour // TypeDefIndex: 74471
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
		private CanvasGroup canvasGroup { get; } // 0x000000018D221784-0x000000018D221818 
		public UIDialogText dialogText { get; } // 0x000000018D221818-0x000000018D221858 
		public UIText actorName { get; } // 0x000000018D221744-0x000000018D221784 
		public GameObject waitNode { get; } // 0x000000018D221858-0x000000018D221898 
	
		// Constructors
		public UIDialogTimelineText(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void UpdateAlpha(float alpha); // 0x000000018D221574-0x000000018D221638
		public void SetRadioIcon(bool useRadio, string radioIcon); // 0x000000018D2213E8-0x000000018D22152C
		private void _ClearRadioIcon(); // 0x000000018D221638-0x000000018D221744
		[CompilerGenerated]
		private void __ClearRadioIcon_b__19_0(); // 0x000000018D22152C-0x000000018D221574
	}

	public class UIDrag : UIBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 74472
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
		public UIDrag(); // 0x000000018D2237C4-0x000000018D2238D4
	
		// Methods
		protected override void Awake(); // 0x000000018D222EF4-0x000000018D222FF8
		public void OnDrag(PointerEventData eventData); // 0x000000018D223524-0x000000018D22372C
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018D2230A4-0x000000018D223524
		public void OnEndDrag(PointerEventData eventData); // 0x000000018D22372C-0x000000018D2237C4
		public void ApplyDragArea(); // 0x000000018D222AF8-0x000000018D222EF4
		public void ClearComponent(); // 0x000000018D222FF8-0x000000018D2230A4
		public void __iFixBaseProxy_Awake(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class UIDragHandler : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 74473
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
		public int dragThreshold { get; } // 0x000000018D221C60-0x000000018D221CE4 
	
		// Constructors
		public UIDragHandler(); // 0x0000000186AEB610-0x0000000186AEB720
	
		// Methods
		public void ClearComponent(); // 0x000000018D221898-0x000000018D221944
		public void OnPointerDown(PointerEventData eventData); // 0x000000018D221BFC-0x000000018D221C60
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018D221944-0x000000018D2219E0
		public void OnDrag(PointerEventData eventData); // 0x000000018D2219E0-0x000000018D221B60
		public void OnEndDrag(PointerEventData eventData); // 0x000000018D221B60-0x000000018D221BFC
	}

	public class UIDragItem : UIBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 74475
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
		public LuaTable luaTable { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
		public bool inDragging { get; } // 0x0000000186D49190-0x0000000186D491C0 
		public LuaPanel panel { get; } // 0x000000018D2229F8-0x000000018D222AB8 
		public RectTransform dragObjectParent { get; set; } // 0x000000018D22290C-0x000000018D22294C 0x000000018D222AB8-0x000000018D222AF8
		private RectTransform m_dragParentRect { get; } // 0x000000018D22294C-0x000000018D2229F8 
		public GameObject curDragObj { get; } // 0x000000018D2228C8-0x000000018D22290C 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __ContinueDragOnDisable_d__43 : IEnumerator<object> // TypeDefIndex: 74474
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIDragItem __4__this; // 0x20
			private PointerEventData _eData_5__2; // 0x28
			private PooledList<RaycastResult> _raycastResults_5__3; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ContinueDragOnDisable_d__43(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D21B1E4-0x000000018D21B548
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D21B548-0x000000018D21B594
		}
	
		// Constructors
		public UIDragItem(); // 0x000000018698FA80-0x000000018698FC20
	
		// Methods
		protected override void Awake(); // 0x0000000186DDCC00-0x0000000186DDCC80
		protected override void Start(); // 0x000000018693B980-0x000000018693BAA0
		protected override void OnDisable(); // 0x0000000187186320-0x0000000187186850
		[IteratorStateMachine(typeof(__ContinueDragOnDisable_d__43))]
		private IEnumerator _ContinueDragOnDisable(); // 0x000000018D222684-0x000000018D22271C
		protected override void OnDestroy(); // 0x000000018D2222CC-0x000000018D222328
		protected override void OnEnable(); // 0x0000000186FA55D0-0x0000000186FA5690
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018D221D68-0x000000018D2222CC
		public void OnDrag(PointerEventData eventData); // 0x000000018D222328-0x000000018D222684
		public void OnEndDrag(PointerEventData eventData); // 0x0000000187186850-0x00000001871868B0
		private void _StopDragView(); // 0x000000018D22271C-0x000000018D2228C8
		public void ClearComponent(); // 0x000000018D221CE4-0x000000018D221D68
		public void ClearEvents(); // 0x000000018697E3D0-0x000000018697E4F0
		public void __iFixBaseProxy_Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_Start(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AddComponentMenu("UI/UI Dropdown", 102)]
	public class UIDropdown : Selectable, IPointerClickHandler, IUIClearable, IBindingGroupTarget, IBindingView // TypeDefIndex: 74478
	{
		// Fields
		[HideInInspector]
		public UnityEvent<int> onSelectCell; // 0x190
		[HideInInspector]
		public UnityEvent<int, UIDropdownOption, bool> onUpdateCell; // 0x198
		[HideInInspector]
		public UnityEvent<int, UIDropdown> onUpdateCaption; // 0x1A0
		[FormerlySerializedAs("onToggleList")]
		[HideInInspector]
		public UnityEvent<bool> onToggleOptList; // 0x1A8
		public Func<int, int, bool> onValidateSelectCell; // 0x1B0
		public UIText captionText; // 0x1B8
		public UIImage captionIcon; // 0x1C0
		[CompilerGenerated]
		private int _selectedIndex_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private int _optionCount_k__BackingField; // 0x1CC
		[CompilerGenerated]
		private bool _isListActive_k__BackingField; // 0x1D0
		[SerializeField]
		private UIDropdownOption _optionTemplate; // 0x1D8
		[SerializeField]
		private Transform _arrowImageTrans; // 0x1E0
		[SerializeField]
		private RectTransform _listContainer; // 0x1E8
		[SerializeField]
		private float _listContainerMaxHeight; // 0x1F0
		[SerializeField]
		private float _animationTime; // 0x1F4
		[SerializeField]
		private RectTransform _selfArea; // 0x1F8
		[SerializeField]
		[Tooltip("\u8FD9\u91CC\u4E3A\u7A7A\u7684\u8BDD\uFF0C\u70B9\u5F00Dropdown\u65F6\u70B9\u51FB\u4EFB\u610F\u975EDropdown\u533A\u57DF\u4F1A\u6536\u8D77\uFF0C\u6709\u7684\u8BDD\u53EA\u4F1A\u54CD\u5E94mask\u533A\u57DF\u5185\u7684")]
		private RectTransform _maskRect; // 0x200
		[SerializeField]
		private bool _autoCloseOnSelect; // 0x208
		[AudioString]
		[SerializeField]
		private string _audioToggleOn; // 0x210
		[AudioString]
		[SerializeField]
		private string _audioToggleOff; // 0x218
		[AudioString]
		[SerializeField]
		private string _audioInvalid; // 0x220
		[AudioString]
		[SerializeField]
		private string _audioNavigation; // 0x228
		private List<UIDropdownOption> m_options; // 0x230
		private LuaPanel m_panel; // 0x238
		private LayoutGroup m_content; // 0x240
		private Camera m_fallbackUICamera; // 0x248
		private UIScrollRect m_listScrollRect; // 0x250
		private CanvasGroup m_listContainerCanvasGroup; // 0x258
		[FormerlySerializedAs("_openDropDownActionId")]
		public string openDropDownActionId; // 0x260
		public string openDropDownBindingTextId; // 0x268
		private int m_bindingGroupId; // 0x270
		private int m_naviBindingGroupId; // 0x274
		private LuaPanel m_luaPanel; // 0x278
		private UISelectableNaviGroup m_listNaviGroup; // 0x280
		[CompilerGenerated]
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0x288
		[CompilerGenerated]
		private readonly DisposedUnityEvent _bindingViewUpdateEvent_k__BackingField; // 0x290
	
		// Properties
		public int selectedIndex { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723D850-0x000000018723D860 0x000000018723D9B0-0x000000018723D9C0
		public int optionCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187258D00-0x0000000187258D10 0x0000000187258D20-0x0000000187258D30
		public bool isListActive { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187258CF0-0x0000000187258D00 0x0000000187258D10-0x0000000187258D20
		public LuaPanel panel { get; } // 0x000000018D224620-0x000000018D2246E0 
		public int groupId { get; } // 0x000000018D2245DC-0x000000018D224620 
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C0F0-0x000000018723C100 0x0000000188DC4BD8-0x0000000188DC4BEC
		public bool groupEnabled { get; } // 0x000000018D22454C-0x000000018D2245DC 
		public string bindingViewActionId { get; } // 0x000000018D224320-0x000000018D224364 
		public string bindingViewLabelText { get; } // 0x000000018D224364-0x000000018D2243FC 
		public DisposedUnityEvent bindingViewUpdateEvent { [CompilerGenerated] get; } // 0x000000018723B2A0-0x000000018723B2B0 
		public RectTransform redDotTrans { get; } // 0x000000018D2246E0-0x000000018D224720 
		public bool bindingEnabled { get; } // 0x000000018D2242E4-0x000000018D224320 
		public BindingViewState bindingViewState { get; } // 0x000000018D2243FC-0x000000018D22454C 
		bool IBindingView.interactable { get; } // 0x000000018D223BAC-0x000000018D223BF0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0 // TypeDefIndex: 74476
		{
			// Fields
			public UIDropdown __4__this; // 0x10
			public bool activeList; // 0x18
	
			// Constructors
			public __c__DisplayClass44_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __ToggleOptions_b__0(); // 0x0000000184E535D0-0x0000000184E536A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0 // TypeDefIndex: 74477
		{
			// Fields
			public int index; // 0x10
			public UIDropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass48_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Refresh_b__0(PointerEventData evt); // 0x0000000184E536A0-0x0000000184E536E0
		}
	
		// Constructors
		public UIDropdown(); // 0x000000018680FD90-0x000000018680FF30
	
		// Methods
		protected override void Awake(); // 0x0000000185C86940-0x0000000185C86AE0
		protected override void _NotifyIsHover(bool isHover); // 0x0000000186879430-0x00000001868794E0
		public void OnPointerClick(PointerEventData eventData); // 0x000000018D223CB4-0x000000018D223D98
		public void Init(UnityAction<int, UIDropdownOption, bool> onUpdateCell, UnityAction<int> onSelectCell, UnityAction<int, UIDropdown> onUpdateCaption = null); // 0x00000001866069C0-0x0000000186606A90
		public void ToggleOptions(bool activeList); // 0x0000000185C86430-0x0000000185C86460
		private void _ToggleOptions(bool activeList, bool isInit); // 0x0000000185C86460-0x0000000185C86940
		private void Update(); // 0x00000001863DF330-0x00000001863DF6F0
		public void SetSelected(int index, bool forceUpdate = false /* Metadata: 0x02628230 */, bool needNotifySelect = true /* Metadata: 0x02628231 */, bool validateSelect = false /* Metadata: 0x02628232 */); // 0x0000000185C84A30-0x0000000185C86430
		public void ScrollToSelected(); // 0x000000018D223D98-0x000000018D223ECC
		public void Refresh(int count, int newSelectedIndex = -1 /* Metadata: 0x02628233 */, bool needNotifySelect = true /* Metadata: 0x02628234 */); // 0x00000001855AFC50-0x00000001855B0280
		public void ClearComponent(); // 0x000000018668A0B0-0x000000018668A170
		private Camera _GetUICamera(); // 0x000000018D224090-0x000000018D2242E4
		public string GetBindingViewActionId(BindingViewActionType actionType); // 0x000000018D223BF0-0x000000018D223CB4
		void IBindingView.OnInputKeyDown(bool isActionTrigger); // 0x000000018D223B3C-0x000000018D223B74
		void IBindingView.OnInputKeyUp(bool isActionTrigger); // 0x000000018D223B74-0x000000018D223BAC
		private void _InitBinding(); // 0x0000000185C87190-0x0000000185C874F0
		private void _ControllerToggle(); // 0x000000018D223F38-0x000000018D223FB0
		private void _ControllerCancel(); // 0x000000018D223ECC-0x000000018D223F38
		private Selectable _GetDefaultNaviTarget(); // 0x000000018D223FB0-0x000000018D224090
		protected override void OnEnable(); // 0x000000018697D570-0x000000018697D600
		protected override void OnDisable(); // 0x000000018697D600-0x000000018697D690
		protected override void OnDestroy(); // 0x000000018668A000-0x000000018668A0B0
		public void __iFixBaseProxy_Awake(); // 0x000000018D1F7518-0x000000018D1F7520
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018D21BBD4-0x000000018D21BBDC
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D1F7528-0x000000018D1F7530
		public void __iFixBaseProxy_OnDisable(); // 0x0000000185C2D7B0-0x0000000185C2D7C0
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D1F7520-0x000000018D1F7528
	}

	public class UIDropdownOption : MonoBehaviour // TypeDefIndex: 74479
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
		public UIDropdownOption(); // 0x000000018548CA70-0x000000018548CAA0
	
		// Methods
		public void SetText(string text); // 0x0000000185395380-0x00000001853954E0
		public void SetState(string stateName); // 0x000000018596FAE0-0x000000018596FBC0
	}

	public enum CommonDropHintType // TypeDefIndex: 74480
	{
		None = 0,
		Square = 1,
		Circle = 2
	}

	public class UIDropItem : UIBehaviour, IDropHandler, IUIClearable // TypeDefIndex: 74481
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
		public LuaTable luaTable { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public UIDropItem(); // 0x00000001869488C0-0x0000000186948A10
	
		// Methods
		public void ClearEvents(); // 0x0000000186AC30F0-0x0000000186AC3150
		protected override void Awake(); // 0x0000000186C23770-0x0000000186C23840
		protected override void OnEnable(); // 0x0000000186A70FB0-0x0000000186A71010
		protected override void OnDisable(); // 0x0000000186A70F70-0x0000000186A70FB0
		protected override void OnDestroy(); // 0x000000018D223968-0x000000018D223A0C
		public void ToggleHighlight(bool active, bool forceToggle = false /* Metadata: 0x02628238 */); // 0x0000000186A71010-0x0000000186A71190
		public void OnDrop(PointerEventData eventData); // 0x000000018D223A0C-0x000000018D223B3C
		public void ClearComponent(); // 0x000000018D2238D4-0x000000018D223968
		public void __iFixBaseProxy_Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class UIElementFollower : TickableUIMono // TypeDefIndex: 74482
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
		protected override TickType tickOption { get; } // 0x0000000186AF4720-0x0000000186AF4750 
		public Vector3 followPosition { get; set; } // 0x000000018D224AE8-0x000000018D224B48 0x000000018D224B88-0x000000018D224BF4
		public Transform targetTransform { get; set; } // 0x000000018D224B48-0x000000018D224B88 0x000000018D224BF4-0x000000018D224C4C
		public bool inScreen { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018223B190-0x000000018223B1A0 0x000000018223B1A0-0x000000018223B1B0
		public LuaPanel panel { get; } // 0x00000001860B8620-0x00000001860B86E0 
	
		// Constructors
		public UIElementFollower(); // 0x0000000186BF5FA0-0x0000000186BF6080
		static UIElementFollower(); // 0x00000001871DCAD0-0x00000001871DCB30
	
		// Methods
		protected override void OnAwake(); // 0x00000001870D2EC0-0x00000001870D2F40
		protected override void OnEnable(); // 0x00000001860B8300-0x00000001860B8350
		public override void LateTick(float deltaTime); // 0x00000001860B8350-0x00000001860B8380
		[IDTag(1)]
		public void UpdatePosition(); // 0x00000001860B8380-0x00000001860B8620
		[IDTag(0)]
		public void UpdatePosition(Vector3 worldPos); // 0x000000018D224720-0x000000018D224AE8
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class UIExtendScrollRect : MonoBehaviour, UnityEngine.EventSystems.IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 74483
	{
		// Fields
		public UIScrollRect baseScrollRect; // 0x18
		[SerializeField]
		private bool _enableDrag; // 0x20
		[SerializeField]
		private UIScrollList _extendScrollList; // 0x28
	
		// Constructors
		public UIExtendScrollRect(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		public void OnScroll(PointerEventData eventData); // 0x000000018D224F10-0x000000018D224FC0
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018D224C4C-0x000000018D224D38
		public void OnDrag(PointerEventData eventData); // 0x000000018D224D38-0x000000018D224E24
		public void OnEndDrag(PointerEventData eventData); // 0x000000018D224E24-0x000000018D224F10
	}

	public interface IUIFoldoutComp // TypeDefIndex: 74484
	{
		// Properties
		bool defaultFoldOut { get; } // 0x00000001851A4410-0x00000001851A4420 
	
		// Methods
		void Refresh(int index);
		void OnFoldOut(bool fastMode = false /* Metadata: 0x02628239 */);
		void OnFoldIn(bool fastMode = false /* Metadata: 0x0262823A */);
	}

	public class UIFoldoutComponent : MonoBehaviour, IUIFoldoutComp // TypeDefIndex: 74487
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
		public virtual bool defaultFoldOut { get; } // 0x00000001858AD740-0x00000001858AD7A0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 74485
		{
			// Fields
			public float startSize; // 0x10
			public UIFoldoutComponent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _OnFoldOut_b__0(); // 0x0000000187232D00-0x0000000187232D10
			internal void _OnFoldOut_b__1(float value); // 0x000000018D21B1AC-0x000000018D21B1E4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0 // TypeDefIndex: 74486
		{
			// Fields
			public float startSize; // 0x10
			public UIFoldoutComponent __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass12_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal float _OnFoldIn_b__0(); // 0x0000000187232D00-0x0000000187232D10
			internal void _OnFoldIn_b__1(float value); // 0x000000018D21B1AC-0x000000018D21B1E4
		}
	
		// Constructors
		public UIFoldoutComponent(); // 0x0000000186E07EA0-0x0000000186E07EE0
	
		// Methods
		public void Refresh(int index); // 0x000000018566EE80-0x000000018566EEC0
		public virtual void OnFoldOut(bool fastMode = false /* Metadata: 0x0262823B */); // 0x000000018566D370-0x000000018566D5B0
		public virtual void OnFoldIn(bool fastMode = false /* Metadata: 0x0262823C */); // 0x00000001858AD7A0-0x00000001858AD9E0
		private void OnDestroy(); // 0x0000000186CFBA90-0x0000000186CFBAE0
	}

	[ExecuteAlways]
	public class UIGraphicAnimation : TickableUIMono // TypeDefIndex: 74488
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
		protected override TickType tickOption { get; } // 0x00000001864D3820-0x00000001864D3850 
		public Material MaterialInstance { get; } // 0x000000018D224FC0-0x000000018D225004 
	
		// Constructors
		public UIGraphicAnimation(); // 0x000000018503EE60-0x000000018503EE80
		static UIGraphicAnimation(); // 0x0000000187180910-0x0000000187180990
	
		// Methods
		protected override void OnAwake(); // 0x00000001852DE860-0x00000001852DE8A0
		protected override void OnRelease(); // 0x00000001852DD130-0x00000001852DD230
		public override void LateTick(float deltaTime); // 0x0000000185140090-0x0000000185140550
		private void _Init(); // 0x00000001852DE8A0-0x00000001852DEA30
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	[ExecuteInEditMode]
	public class UIGridLayoutGroup : GridLayoutGroup // TypeDefIndex: 74489
	{
		// Constructors
		public UIGridLayoutGroup(); // 0x000000018D225004-0x000000018D22500C
	}

	public class UIGridLayoutNaviWrapper : UIBehaviour, UIScrollList.IScrollListNaviWrapper // TypeDefIndex: 74491
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
		public enum WrapMode // TypeDefIndex: 74490
		{
			NaviGroup = 0,
			ScrollRect = 1,
			ScrollList = 2,
			LayoutNaviWrapper = 3
		}
	
		// Constructors
		public UIGridLayoutNaviWrapper(); // 0x0000000186C5EA60-0x0000000186C5EAF0
	
		// Methods
		private void _InitIfNot(); // 0x0000000186B1EAC0-0x0000000186B1ECB0
		protected override void Start(); // 0x0000000186B1E8D0-0x0000000186B1E910
		public bool TryWrapNavigate(NaviDirection dir); // 0x000000018D22500C-0x000000018D225050
		private void _InitWrapNavigation(); // 0x0000000186B1E910-0x0000000186B1EAC0
		private void _NaviGridLayout(NaviDirection dir); // 0x000000018D225814-0x000000018D225854
		private bool _NaviGridLayoutImpl(NaviDirection dir, bool enableCircleWrapNavigation = false /* Metadata: 0x0262823D */); // 0x000000018D22544C-0x000000018D2256E0
		private bool _NaviGridLayoutInit(bool isBefore, bool enableCircleWrapNavigation = false /* Metadata: 0x0262823E */); // 0x000000018D2256E0-0x000000018D225814
		private bool _NaviChildren(int curIndex, int childCount, bool isBefore, bool enableCircleWrapNavigation); // 0x000000018D2251BC-0x000000018D22544C
		private Selectable _FindValidSelectable(bool isBefore); // 0x000000018D225050-0x000000018D2251BC
		private void _SetCircleWrapScroll(bool isBefore); // 0x000000018D225854-0x000000018D225954
		public void __iFixBaseProxy_Start(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class UIGroupScrollList : UIScrollList // TypeDefIndex: 74492
	{
		// Fields
		[FormerlySerializedAs("_groupTitlePrefab")]
		[SerializeField]
		[Tooltip("\u5206\u7EC4\u6807\u9898\u6A21\u677F\uFF0C\u53EF\u4EE5\u662FPrefab\u6216\u8005\u9762\u677F\u4E0A\u7684\u8282\u70B9")]
		protected GameObject _groupTitleTemplate; // 0x280
		[SerializeField]
		[Tooltip("\u5206\u7EC4\u80CC\u666F\u6A21\u677F\uFF0C\u53EF\u4E3A\u7A7A\u3002\u4E3A\u7A7A\u65F6\u4E0D\u542F\u7528 GroupBG \u903B\u8F91")]
		protected GameObject _groupBGCell; // 0x288
		[SerializeField]
		[Tooltip("\u76F8\u90BB\u4E24\u7EC4\u4E4B\u95F4\u989D\u5916\u589E\u52A0\u7684\u95F4\u8DDD\uFF08\u5728\u6EDA\u52A8\u65B9\u5411\u4E0A\uFF0C\u53E0\u52A0\u5728 Space \u4E4B\u4E0A\uFF09")]
		private float _groupSpace; // 0x290
		[NonSerialized]
		public Func<int, int> getCellCountInGroup; // 0x298
		[NonSerialized]
		public Func<int, float> getGroupTitleSize; // 0x2A0
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onUpdateGroupTitle; // 0x2A8
		[NonSerialized]
		public DisposedUnityEvent<GameObject, int> onUpdateGroupBG; // 0x2B0
		private int m_groupCount; // 0x2B8
		private int[] m_cellCountPerGroup; // 0x2C0
		private int[] m_groupFirstRow; // 0x2C8
		private int m_totalRows; // 0x2D0
		private float m_defaultGroupTitleHeight; // 0x2D4
		private float m_defaultGroupTitleWidth; // 0x2D8
		private readonly List<float> m_groupTitleSizeList; // 0x2E0
		private Stack<Cell> m_titleCellCache; // 0x2E8
		private Dictionary<int, Cell> m_showingTitles; // 0x2F0
		private Stack<Cell> m_groupBGCellCache; // 0x2F8
		private Dictionary<int, Cell> m_showingGroupBGs; // 0x300
		private bool m_isMultiPage; // 0x308
		private const string CACHED_TITLE_GAME_OBJECT_NAME = "CachedTitle"; // Metadata: 0x0262825F
		private const string CACHED_GROUP_BG_GAME_OBJECT_NAME = "CachedGroupBG"; // Metadata: 0x0262826B
	
		// Properties
		public int totalCellCount { get; } // 0x0000000185BACFB0-0x0000000185BAD030 
		protected override bool isMultiPage { get; } // 0x0000000186BC30B0-0x0000000186BC30E0 
	
		// Constructors
		public UIGroupScrollList(); // 0x0000000186CCA980-0x0000000186CCABD0
	
		// Methods
		private void _BuildGroupLayout(); // 0x0000000185BAD030-0x0000000185BAD1A0
		private void _RebuildGroupRows(); // 0x0000000185BAD880-0x0000000185BADB50
		private void _EnsureGroupTitleSizeCacheCount(int groupCount); // 0x0000000185BAD580-0x0000000185BAD6A0
		private float _GetDefaultGroupTitleSize(); // 0x0000000185BAD6A0-0x0000000185BAD6E0
		private float _CalcGroupTitleSize(int groupIndex); // 0x0000000185BAD530-0x0000000185BAD580
		private void _RefreshAllGroupTitleSizes(); // 0x0000000185BAD430-0x0000000185BAD4A0
		private void _RefreshGroupTitleSizeWithoutEnsure(int groupIndex); // 0x0000000185BAD4A0-0x0000000185BAD530
		private void _RefreshGroupTitleSize(int groupIndex); // 0x000000018D2283BC-0x000000018D228434
		private float _GetGroupTitleSize(int groupIndex); // 0x0000000185BAC140-0x0000000185BAC1E0
		private bool _GetRowInfo(int row, out int groupIndex, out bool isTitleRow, out int cellRowInGroup); // 0x0000000185BABE00-0x0000000185BABF30
		private float _GetRowHeight(int row); // 0x0000000185BABD70-0x0000000185BABE00
		private float _GetCumulativeSizeBeforeRow(int row); // 0x0000000185BABCD0-0x0000000185BABD70
		private int _GetRowForCell(int groupIndex, int cellIndexInGroup); // 0x0000000185BAB9C0-0x0000000185BABA40
		private int _GetCellIndexForGroupCell(int groupIndex, int cellIndexInGroup); // 0x0000000185BAC1E0-0x0000000185BAC250
		private bool _GetGroupAndCellFromCellIndex(int cellIndex, out int groupIndex, out int cellIndexInGroup); // 0x0000000185BAB2B0-0x0000000185BAB360
		private int _GetRowByCellIndex(int fastScrollToIndex, ScrollAlignType alignType); // 0x0000000185BACF30-0x0000000185BACFB0
		private void _GetGroupCellIndexRange(int groupIndex, out int startCellIndex, out int endCellIndex); // 0x000000018D227E34-0x000000018D227F00
		private Vector2Int _GetGroupRangeFromScrollOffset(float scrollOffset, float viewSize, float bufferSize); // 0x0000000185BABF30-0x0000000185BAC140
		private Vector2Int _GetGroupRangeFromCellIndexRange(Vector2Int cellIndexRange); // 0x0000000185BAB1F0-0x0000000185BAB2B0
		private Vector2Int _MergeGroupRange(Vector2Int lhs, Vector2Int rhs); // 0x0000000185BAAC80-0x0000000185BAACF0
		private ValueTuple<float, float> _GetScrollInfo(); // 0x0000000185BA9740-0x0000000185BA9850
		protected override void SyncViewSize(); // 0x0000000185BAC7B0-0x0000000185BAC8A0
		protected override void InGameAwake(); // 0x0000000187105940-0x0000000187105A10
		[IDTag(0)]
		[Obsolete("UIGroupScrollList \u8BF7\u4F7F\u7528 UpdateGroup \u7CFB\u5217\u65B9\u6CD5")]
		public new void UpdateCount(int newCount); // 0x000000018D22695C-0x000000018D226994
		[IDTag(1)]
		[Obsolete("UIGroupScrollList \u8BF7\u4F7F\u7528 UpdateGroup \u7CFB\u5217\u65B9\u6CD5")]
		public new void UpdateCount(int newCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x02628243 */, bool onlyUpdateNewCellContent = false /* Metadata: 0x02628244 */, bool skipGraduallyShow = false /* Metadata: 0x02628245 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02628246 */); // 0x000000018D226994-0x000000018D226A08
		[IDTag(2)]
		public void UpdateGroup(int groupCount); // 0x000000018D226A08-0x000000018D226A68
		[IDTag(1)]
		public void UpdateGroup(int groupCount, bool setTop, bool forceRecalculate = false /* Metadata: 0x02628247 */, bool onlyUpdateNewCellContent = false /* Metadata: 0x02628248 */, bool skipGraduallyShow = false /* Metadata: 0x02628249 */); // 0x000000018D226A68-0x000000018D226AFC
		[IDTag(0)]
		public void UpdateGroup(int groupCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x0262824A */, bool onlyUpdateNewCellContent = false /* Metadata: 0x0262824B */, bool skipGraduallyShow = false /* Metadata: 0x0262824C */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0262824D */); // 0x0000000185BACDB0-0x0000000185BACF30
		public void UpdateSingleGroup(int groupIndex, int? newCellCount = default); // 0x000000018D226AFC-0x000000018D226DD4
		public void NotifyGroupTitleSizeChange(int groupIndex); // 0x000000018D225ED8-0x000000018D225F70
		public int AppendCellToGroup(int groupIndex); // 0x000000018D225954-0x000000018D225A6C
		public bool RemoveLastCellFromGroup(int groupIndex); // 0x000000018D225F70-0x000000018D226084
		private int _GetGroupStartCellIndex(int groupIndex); // 0x000000018D22802C-0x000000018D2280B0
		private void _RemapShowingCellIndicesAfterGroupResize(int groupIndex, int oldCellCount, int newCellCount); // 0x000000018D228434-0x000000018D2287B8
		private int _GetScrollTargetRow(int groupIndex, int cellIndexInGroup, ScrollAlignType alignType); // 0x000000018D2280B0-0x000000018D228174
		private void _ScrollToRow(int row, bool fastMode, ScrollAlignType alignType); // 0x000000018D228848-0x000000018D2288B4
		private void _ScrollToGroup(int groupIndex, bool fastMode, ScrollAlignType alignType); // 0x000000018D2287B8-0x000000018D228848
		public void ScrollToGroup(int groupIndex, bool fastMode = false /* Metadata: 0x0262824E */, ScrollAlignType alignType = ScrollAlignType.Top /* Metadata: 0x0262824F */, bool graduallyShowInFastMode = false /* Metadata: 0x02628250 */); // 0x000000018D226084-0x000000018D226180
		[IDTag(1)]
		public override void ScrollToIndex(int index, bool fastMode = false /* Metadata: 0x02628251 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02628252 */, bool graduallyShowInFastMode = false /* Metadata: 0x02628253 */); // 0x000000018D226180-0x000000018D226254
		[IDTag(0)]
		public void ScrollToIndex(int groupIndex, int cellIndexInGroup, bool fastMode = false /* Metadata: 0x02628254 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02628255 */, bool graduallyShowInFastMode = false /* Metadata: 0x02628256 */); // 0x000000018D226254-0x000000018D226394
		public Vector2Int GetGroupRangeInView(float bufferSize = 0f /* Metadata: 0x02628257 */); // 0x000000018D225ACC-0x000000018D225BA4
		private void _RefreshIsMultiPage(); // 0x0000000185BA8AC0-0x0000000185BA8B40
		protected override void UpdateContainerSize(); // 0x0000000185BA8A80-0x0000000185BA8AC0
		protected override float GetContainerSize(bool ignoreAutoLayout = false /* Metadata: 0x0262825B */); // 0x0000000185BAACF0-0x0000000185BAAE90
		protected override Vector2Int GetIndexRangeFromScrollOffset(float scrollOffset, float viewSize, float bufferSize); // 0x0000000185BABA40-0x0000000185BABCD0
		private bool _IsGroupInCellRange(int groupIndex, int startCellIndex, int endCellIndex); // 0x000000018D228174-0x000000018D228208
		private void _MoveTitleTo(Cell cell, int groupIndex); // 0x0000000185BAAE90-0x0000000185BAAFF0
		private void _MoveCellTo(Cell cell, int groupIndex, int cellIndexInGroup); // 0x0000000185BAB860-0x0000000185BAB9C0
		protected override void MoveCellTo(Cell cell, int index); // 0x000000018D225E30-0x000000018D225ED8
		protected override float GetTargetPosByIndex(int index, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0262825C */); // 0x0000000185BACB70-0x0000000185BACDB0
		private Cell _GetTitleCell(); // 0x0000000185BAC8A0-0x0000000185BACB70
		private void _CacheTitleCell(Cell cell); // 0x0000000186BA31C0-0x0000000186BA3280
		private Cell _GetGroupBGCell(); // 0x000000018D227BCC-0x000000018D227E34
		private void _CacheGroupBGCell(Cell cell); // 0x000000018D227A80-0x000000018D227B54
		private float _GetGroupLength(int groupIndex); // 0x000000018D227F00-0x000000018D22802C
		private void _MoveGroupBGTo(Cell cell, int groupIndex); // 0x000000018D228208-0x000000018D2283BC
		private void _UpdateGroupBGByRange(Vector2Int groupRange, bool forceUpdateContent, bool ignoreListActive); // 0x0000000185BAC350-0x0000000185BAC490
		protected override void UpdateShowingCells(bool forceUpdateContent, bool forceClearShowingCells = false /* Metadata: 0x0262825D */, bool ignoreListActive = false /* Metadata: 0x0262825E */); // 0x0000000185BAAFF0-0x0000000185BAB140
		protected override void CacheOutOfRangeCells(Vector2Int showRange, Vector2Int notCacheRange); // 0x0000000185BA9850-0x0000000185BA9FD0
		protected override void ProcessCellAtIndex(int index, bool forceUpdateContent, bool ignoreListActive); // 0x0000000185BAB140-0x0000000185BAB1F0
		protected override void RepositionOutOfRangeCells(Vector2Int showRange); // 0x0000000185BAA170-0x0000000185BAAA70
		private void _UpdateTitleOrCell(bool isTitle, int groupIndex, int cellIndexInGroup, int cellIndex, bool forceUpdateContent, bool ignoreListActive); // 0x0000000185BAB360-0x0000000185BAB860
		private void _OnUpdateTitleOrCell(Cell cell, bool isTitle, int groupIndex, int cellIndexInGroup); // 0x0000000185BAC250-0x0000000185BAC350
		private void _UpdateShowingCellsForGroup(int dirtyGroupIndex); // 0x000000018D2288B4-0x000000018D229F7C
		protected override bool TryHandleCircleNavigationInScrollDirection(NaviDirection dir, int currentIndex, bool isBefore); // 0x000000018D226758-0x000000018D2267AC
		protected override bool TryResolveWrapDirection(NaviDirection dir, out bool isBefore); // 0x000000018D2267AC-0x000000018D22689C
		protected override bool TryGetWrapTargetIndex(NaviDirection dir, int currentIndex, bool isBefore, out int targetIndex); // 0x000000018D226548-0x000000018D226758
		private int _CellsInGroupRow(int row, int totalRowsInGroup, int cellCount); // 0x000000018D227B54-0x000000018D227BCC
		protected override void ClearShowingCells(); // 0x0000000186BA2EF0-0x0000000186BA31C0
		public override void ClearComponent(); // 0x0000000185B2AD90-0x0000000185B2AE70
		[IDTag(1)]
		public new GameObject Get(int cellIndex); // 0x000000018D225C6C-0x000000018D225D20
		[IDTag(0)]
		public GameObject Get(int groupIndex, int cellIndexInGroup); // 0x000000018D225D20-0x000000018D225E30
		public GameObject GetGroupTitle(int groupIndex); // 0x000000018D225BA4-0x000000018D225C6C
		[IDTag(1)]
		public new void SetCellCanCache(int cellIndex, bool canCache); // 0x000000018D226394-0x000000018D226434
		[IDTag(0)]
		public void SetCellCanCache(int groupIndex, int cellIndexInGroup, bool canCache); // 0x000000018D226434-0x000000018D226548
		public string DebugDumpLayoutToConsoleAndClipboard(); // 0x000000018D225A6C-0x000000018D225ACC
		private string _BuildLayoutDebugDumpText(); // 0x000000018D226DD4-0x000000018D227A80
		public void __iFixBaseProxy_SyncViewSize(); // 0x000000018D22690C-0x000000018D226914
		public void __iFixBaseProxy_InGameAwake(); // 0x000000018D2268D4-0x000000018D2268DC
		public void __iFixBaseProxy_ScrollToIndex(int P0, bool P1, ScrollAlignType P2, bool P3); // 0x000000018D2268F4-0x000000018D22690C
		public bool __iFixBaseProxy_get_isMultiPage(); // 0x000000018D226954-0x000000018D22695C
		public void __iFixBaseProxy_UpdateContainerSize(); // 0x000000018D22693C-0x000000018D226944
		public float __iFixBaseProxy_GetContainerSize(bool P0); // 0x000000018D2268B4-0x000000018D2268BC
		public Vector2Int __iFixBaseProxy_GetIndexRangeFromScrollOffset(float P0, float P1, float P2); // 0x000000018D2268BC-0x000000018D2268CC
		public void __iFixBaseProxy_MoveCellTo(Cell P0, int P1); // 0x000000018D2143A0-0x000000018D2143A8
		public float __iFixBaseProxy_GetTargetPosByIndex(int P0, ScrollAlignType P1); // 0x000000018D2268CC-0x000000018D2268D4
		public void __iFixBaseProxy_UpdateShowingCells(bool P0, bool P1, bool P2); // 0x000000018D226944-0x000000018D226954
		public void __iFixBaseProxy_CacheOutOfRangeCells(Vector2Int P0, Vector2Int P1); // 0x000000018D22689C-0x000000018D2268A4
		public void __iFixBaseProxy_ProcessCellAtIndex(int P0, bool P1, bool P2); // 0x000000018D2268DC-0x000000018D2268EC
		public void __iFixBaseProxy_RepositionOutOfRangeCells(Vector2Int P0); // 0x000000018D2268EC-0x000000018D2268F4
		public bool __iFixBaseProxy_TryHandleCircleNavigationInScrollDirection(NaviDirection P0, int P1, bool P2); // 0x000000018D226924-0x000000018D226934
		public bool __iFixBaseProxy_TryResolveWrapDirection(NaviDirection P0, out bool P1); // 0x000000018D226934-0x000000018D22693C
		public bool __iFixBaseProxy_TryGetWrapTargetIndex(NaviDirection P0, int P1, bool P2, out int P3); // 0x000000018D226914-0x000000018D226924
		public void __iFixBaseProxy_ClearShowingCells(); // 0x000000018D2268AC-0x000000018D2268B4
		public void __iFixBaseProxy_ClearComponent(); // 0x000000018D2268A4-0x000000018D2268AC
	}

	public class UIGyroscopeEffect : TickableUIMono // TypeDefIndex: 74494
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
		private GravitySensorHandle m_gravitySensorHandle; // 0xB8
		private bool m_baseGravityValid; // 0xC0
		private float m_baseGravityY; // 0xC4
		private float m_baseGravityYAccumulatedTime; // 0xC8
		private float m_lastGravityY; // 0xCC
		private Vector3 m_smoothedControllerAccValue; // 0xD0
		public TweenerCore<Quaternion, Quaternion, NoOptions> handler; // 0xE0
		public TweenerCore<Vector3, Vector3, VectorOptions> tween; // 0xE8
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001869375F0-0x0000000186937620 
	
		// Nested types
		[Serializable]
		public class Param // TypeDefIndex: 74493
		{
			// Fields
			public float maxAngle; // 0x10
			[Space(10f)]
			public AnimationCurve valueCurve; // 0x18
	
			// Constructors
			public Param(); // 0x00000001870B4860-0x00000001870B4870
		}
	
		// Constructors
		public UIGyroscopeEffect(); // 0x0000000186ACEED0-0x0000000186ACEF30
	
		// Methods
		protected override void OnAwake(); // 0x00000001851ACC80-0x00000001851AD990
		protected override void OnDisable(); // 0x0000000184E53AB0-0x0000000184E53B20
		public override void Tick(float deltaTime); // 0x0000000185197820-0x0000000185198DF0
		protected override void OnRelease(); // 0x0000000186D28A00-0x0000000186D28BD0
		[CompilerGenerated]
		private Vector3 _Tick_b__25_0(); // 0x0000000184E53B20-0x0000000184E53B60
		[CompilerGenerated]
		private void _Tick_b__25_1(Vector3 value); // 0x0000000184E53B60-0x0000000184E53B90
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	public class UIHighlightMask : TickableUIMono // TypeDefIndex: 74495
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
		protected override TickType tickOption { get; } // 0x000000018D22AE64-0x000000018D22AEA8 
		public LuaPanel panel { get; } // 0x000000018D22ADA4-0x000000018D22AE64 
	
		// Constructors
		public UIHighlightMask(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		protected override void OnAwake(); // 0x000000018D22A98C-0x000000018D22AA20
		protected override void OnEnable(); // 0x000000018D22AA20-0x000000018D22AA78
		public override void Tick(float deltaTime); // 0x000000018D22AA78-0x000000018D22AAB4
		public void TrySyncRect(); // 0x000000018D22AAB4-0x000000018D22ADA4
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	[AddComponentMenu("UI/UI Image", 11)]
	public class UIImage : HGImage // TypeDefIndex: 74496
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
		public const string SPRITE_PATH_FORMAT = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}/{1}.png"; // Metadata: 0x0262827C
		public const string SPRITE_ROOT_PATH_FORMAT = "Assets/Beyond/DynamicAssets/Gameplay/UI/Sprites/{0}.png"; // Metadata: 0x026282B8
		public bool enableAutoImgUsePathReference; // 0x210
		public bool imgUsePathReference; // 0x211
		public string imgRefPath; // 0x218
		private bool m_imgIsPathReference; // 0x220
	
		// Properties
		public bool packIntoRuntimeAtlas { get; set; } // 0x000000018D22BF00-0x000000018D22BF44 0x000000018D22BFC4-0x000000018D22C000
		public int atlasHandleId { get; set; } // 0x000000018D22BE78-0x000000018D22BEBC 0x000000018D22BF88-0x000000018D22BFC4
		public LuaPanel panel { get; } // 0x00000001853AA2D0-0x00000001853AA530 
		public ref UIAtlasManager.UIAtlasHandle atlasHandle { get; } // 0x000000018D22BEBC-0x000000018D22BF00 
		public int panelLevel { get; } // 0x000000018D22BF44-0x000000018D22BF88 
		public override UnityEngine.Color color { get; set; } // 0x0000000185698890-0x00000001856988C0 0x00000001853580D0-0x0000000185358320
		public override Texture mainTexture { get; } // 0x0000000185100C40-0x0000000185101040 
	
		// Constructors
		public UIImage(); // 0x000000018548F1B0-0x000000018548F350
	
		// Methods
		public void RegisterOnEnableRuntimeAtlas(Action callBack); // 0x000000018527EA00-0x000000018527EAA0
		public void UnregisterOnEnableRuntimeAtlas(Action callBack); // 0x000000018527F790-0x000000018527F830
		public void OnEnableRuntimeAtlas(); // 0x000000018D22BDB0-0x000000018D22BE00
		protected override void _OnSpriteChanged(Sprite lastOne); // 0x0000000185BF0FA0-0x0000000185BF10B0
		protected override void OnPopulateMeshFallback(VertexHelper toFill); // 0x0000000186308920-0x0000000186308950
		protected override void Awake(); // 0x0000000185BF12E0-0x0000000185BF1670
		protected override void OnEnable(); // 0x00000001853A9A70-0x00000001853AA2D0
		protected override void OnDisable(); // 0x00000001852ED1E0-0x00000001852ED280
		protected override void OnDestroy(); // 0x00000001852E5990-0x00000001852E67A0
		public override void SetNativeSize(); // 0x000000018604E1A0-0x000000018604E2E0
		public void SetNativeSizeIgnoreRefScale(); // 0x000000018D22BE00-0x000000018D22BE38
		[IDTag(0)]
		public void LoadSprite(string folder, string spriteName); // 0x0000000185653800-0x00000001856538D0
		[IDTag(1)]
		public void LoadSprite(string path); // 0x00000001861E5C60-0x00000001861E5CB0
		public void LoadSpriteWithOutFormat(string path, bool ignoreEnable = false /* Metadata: 0x02628279 */); // 0x0000000185641DA0-0x0000000185641DD0
		private void _LoadSprite(string path, bool ignoreEnable = false /* Metadata: 0x0262827A */); // 0x00000001851022D0-0x0000000185102980
		public void LoadMaterial(string path, bool newInstance = false /* Metadata: 0x0262827B */); // 0x000000018D22BB68-0x000000018D22BDB0
		public override void ReleaseSprite(); // 0x00000001868AB010-0x00000001868AB050
		public void DisposeSpriteHandle(); // 0x00000001852E67A0-0x00000001852E67F0
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void _V2AtlasInitialize(); // 0x0000000186612C80-0x0000000186612E60
		public UnityEngine.Color __iFixBaseProxy_get_color(); // 0x0000000187238F60-0x0000000187238F70
		public void __iFixBaseProxy_set_color(UnityEngine.Color P0); // 0x000000018D21CD04-0x000000018D21CD24
		public void __iFixBaseProxy__OnSpriteChanged(Sprite P0); // 0x000000018D22BE68-0x000000018D22BE70
		public void __iFixBaseProxy_OnPopulateMeshFallback(VertexHelper P0); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_Awake(); // 0x000000018D22BE38-0x000000018D22BE40
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D22BE50-0x000000018D22BE58
		public void __iFixBaseProxy_OnDisable(); // 0x000000018D22BE48-0x000000018D22BE50
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D22BE40-0x000000018D22BE48
		public void __iFixBaseProxy_SetNativeSize(); // 0x000000018D22BE60-0x000000018D22BE68
		public void __iFixBaseProxy_ReleaseSprite(); // 0x000000018D22BE58-0x000000018D22BE60
		public Texture __iFixBaseProxy_get_mainTexture(); // 0x000000018D22BE70-0x000000018D22BE78
	}

	[RequireComponent(typeof(UIImage))]
	public class UIImageBlur : TickableUIMono // TypeDefIndex: 74497
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
		protected override TickType tickOption { get; } // 0x0000000186FB86A0-0x0000000186FB86D0 
	
		// Constructors
		public UIImageBlur(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		protected override void OnAwake(); // 0x0000000185E38A20-0x0000000185E38C00
		public void OnChangeSprite(); // 0x0000000185E390D0-0x0000000185E393E0
		public override void Tick(float deltaTime); // 0x000000018D22AF2C-0x000000018D22B090
		protected override void OnDisable(); // 0x00000001852DC8B0-0x00000001852DC9F0
		protected override void OnRelease(); // 0x000000018D22AEA8-0x000000018D22AF2C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	[RequireComponent(typeof(UIImage))]
	public class UIImageFillAmountOffset : MonoBehaviour // TypeDefIndex: 74498
	{
		// Fields
		private UIImage m_followImage; // 0x18
		public float fillOffset; // 0x20
		private float m_fillAmount; // 0x24
	
		// Properties
		public float fillAmount { get; set; } // 0x000000018D22B220-0x000000018D22B264 0x000000018D22B264-0x000000018D22B3A0
	
		// Constructors
		public UIImageFillAmountOffset(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public TweenerCore<float, float, FloatOptions> DOFillAmount(float endValue, float duration); // 0x000000018D22B090-0x000000018D22B218
		[CompilerGenerated]
		private float _DOFillAmount_b__6_0(); // 0x0000000187236710-0x0000000187236720
		[CompilerGenerated]
		private void _DOFillAmount_b__6_1(float x); // 0x000000018D22B218-0x000000018D22B220
	}

	public class UIImageFillFollower : TickableUIMono // TypeDefIndex: 74499
	{
		// Fields
		private const float BACK_FOLLOW_THRESHOLD = 0.02f; // Metadata: 0x026282F0
		[SerializeField]
		private UIImage _frontFill; // 0x68
		[SerializeField]
		private float _followSpeed; // 0x70
		private UIImage m_image; // 0x78
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D22B62C-0x000000018D22B670 
	
		// Constructors
		public UIImageFillFollower(); // 0x000000018D22B61C-0x000000018D22B62C
	
		// Methods
		protected override void OnAwake(); // 0x000000018D22B3A0-0x000000018D22B44C
		protected override void OnEnable(); // 0x000000018D22B44C-0x000000018D22B4C0
		public override void Tick(float deltaTime); // 0x000000018D22B528-0x000000018D22B61C
		public void RefreshFillAmount(); // 0x000000018D22B4C0-0x000000018D22B528
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	[AddComponentMenu("UI/UI Image Filled Tail Follower", 34)]
	[ExecuteInEditMode]
	[Tooltip("\u81EA\u8EAB\u5FC5\u987B\u662F\u8981\u8DDF\u968F\u7684Follow Image\u7684\u5B50\u8282\u70B9\uFF1B\u4EC5\u5904\u7406Fill Method\u4E3A\u6C34\u5E73\u6216\u5782\u76F4\u7684\u60C5\u51B5")]
	public class UIImageFillTailFollower : TickableUIMono // TypeDefIndex: 74500
	{
		// Fields
		[SerializeField]
		private UIImage _followImage; // 0x68
		public float followOffset; // 0x70
		private RectTransform m_selfRectTransform; // 0x78
		private RectTransform m_followImageRectTransform; // 0x80
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D22BA84-0x000000018D22BAC8 
	
		// Constructors
		public UIImageFillTailFollower(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		protected override void OnAwake(); // 0x000000018D22B670-0x000000018D22B73C
		protected override void OnEnable(); // 0x000000018D22B73C-0x000000018D22B7A0
		public override void Tick(float deltaTime); // 0x000000018D22BA28-0x000000018D22BA84
		public void RefreshFollower(); // 0x000000018D22B7A0-0x000000018D22BA28
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	[Obsolete("\u8FD9\u4E2A\u7EC4\u4EF6\u7684\u529F\u80FD\u53EF\u4EE5\u76F4\u63A5\u653E\u5230UIImage\u91CC\u4E86\uFF0C\u4E4B\u540E\u6709\u65F6\u95F4\u53EF\u4EE5\u628A\u5B83\u8FC1\u79FB\u8FC7\u53BB")]
	public class UIImagePair : MonoBehaviour // TypeDefIndex: 74501
	{
		// Fields
		public List<UIImage> referencedImages; // 0x18
	
		// Properties
		public UnityEngine.Color color { set; } // 0x0000000186ABA1E0-0x0000000186ABA440
		public UIImage first { get; } // 0x000000018D22BAC8-0x000000018D22BB68 
	
		// Constructors
		public UIImagePair(); // 0x0000000186864130-0x00000001868641C0
	
		// Methods
		[IDTag(1)]
		public void LoadSprite(string folder, string spriteName); // 0x0000000185641AF0-0x0000000185641B40
		[IDTag(0)]
		public void LoadSprite(string path); // 0x0000000185641C60-0x0000000185641DA0
	}

	public class UIInertiaViewPager : TickableUIMono, IUIClearable // TypeDefIndex: 74515
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
		protected override TickType tickOption { get; } // 0x0000000186FB8670-0x0000000186FB86A0 
		public bool isUpdating { get; } // 0x000000018D22C274-0x000000018D22C2B4 
		public int pageCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001872406F0-0x0000000187240700 0x0000000187240750-0x0000000187240760
		public int currentPage { get; set; } // 0x000000018D22C230-0x000000018D22C274 0x0000000185B2A520-0x0000000185B2A550
		public float currentScrollIndex { get; } // 0x0000000185B2A610-0x0000000185B2A690 
	
		// Nested types
		public enum State // TypeDefIndex: 74502
		{
			IDLE = 0,
			DRAGING = 1,
			INERTIA = 2,
			ALIGNING = 3
		}
	
		private interface IScrollHandler : IHotfixable // TypeDefIndex: 74503
		{
			// Properties
			float velocity { get; }
			bool isDragging { get; }
			float scrollProgress { get; set; }
	
			// Methods
			void OnClear();
			void StopMoving();
		}
	
		private class CustomScrollHandler : Beyond.UI.UIInertiaViewPager.IScrollHandler // TypeDefIndex: 74504
		{
			// Fields
			private bool m_isScrolling; // 0x10
			private UIScrollRect m_scrollRect; // 0x18
	
			// Properties
			public float velocity { get; } // 0x000000018D22A284-0x000000018D22A2F8 
			public float scrollProgress { get; set; } // 0x0000000185B2A690-0x0000000185B2A6F0 0x0000000185383540-0x00000001853835B0
			public bool isDragging { get; } // 0x0000000185383330-0x0000000185383370 
	
			// Constructors
			public CustomScrollHandler(UIScrollRect scrollRect); // 0x0000000185B2B150-0x0000000185B2B290
	
			// Methods
			public void OnClear(); // 0x0000000185B2B290-0x0000000185B2B3D0
			public void StopMoving(); // 0x0000000185B2A890-0x0000000185B2A8D0
			private void _OnScrollBegin(Vector2 delta); // 0x000000018D22A214-0x000000018D22A24C
			private void _OnScrollEnd(Vector2 delta); // 0x000000018D22A24C-0x000000018D22A284
		}
	
		private struct EmptyScrollHandler : Beyond.UI.UIInertiaViewPager.IScrollHandler // TypeDefIndex: 74505
		{
			// Properties
			public float velocity { get; } // 0x000000018D22A608-0x000000018D22A648 
			public bool isDragging { get; } // 0x000000018D22A588-0x000000018D22A5C8 
			public float scrollProgress { get; set; } // 0x000000018D22A5C8-0x000000018D22A608 0x000000018D22A648-0x000000018D22A67C
	
			// Methods
			public void StopMoving(); // 0x000000018D22A554-0x000000018D22A588
			public void OnClear(); // 0x000000018D22A520-0x000000018D22A554
		}
	
		public struct FlingToNext // TypeDefIndex: 74506
		{
			// Fields
			public bool enable; // 0x00
			public float minSpd; // 0x04
			public float maxSpd; // 0x08
		}
	
		public struct ScrollOptions // TypeDefIndex: 74507
		{
			// Fields
			public FlingToNext flingToNext; // 0x00
		}
	
		private class DragContext // TypeDefIndex: 74508
		{
			// Fields
			public float startPos; // 0x10
	
			// Constructors
			public DragContext(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void BeginDrag(UIInertiaViewPager pager); // 0x000000018D22A2F8-0x000000018D22A360
			public State EndDrag(UIInertiaViewPager pager); // 0x000000018D22A360-0x000000018D22A3B8
			private bool _TryFlingToNext(UIInertiaViewPager pager); // 0x000000018D22A3B8-0x000000018D22A520
		}
	
		private enum BlockerDir // TypeDefIndex: 74509
		{
			UPWARD = 0,
			DOWNNWARD = 1,
			BOTH = 2
		}
	
		private struct InertiaBlocker : IHotfixable // TypeDefIndex: 74510
		{
			// Fields
			public BlockerDir dir; // 0x00
			public int index; // 0x04
	
			// Methods
			public bool IsDirMatch(float vec); // 0x000000018D22A67C-0x000000018D22A6E4
		}
	
		private class BlockerManager : IHotfixable // TypeDefIndex: 74511
		{
			// Fields
			private const float INERTIA_BIAS = 0.49f; // Metadata: 0x026282FB
			private List<InertiaBlocker> m_inertiaBlockers; // 0x10
			private float m_lastIndex; // 0x18
			[CompilerGenerated]
			private bool _isInertiaing_k__BackingField; // 0x1C
	
			// Properties
			public bool isInertiaing { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EB80-0x000000018226EB90 0x000000018226EB90-0x000000018226EBA0
	
			// Constructors
			public BlockerManager(); // 0x0000000186D519B0-0x0000000186D51A30
	
			// Methods
			public void Init(int pageCount, List<int> blockFrames); // 0x0000000186DB6840-0x0000000186DB6960
			public void StartInertia(float fromIndex); // 0x000000018D22A1D8-0x000000018D22A214
			public bool HitInertiaBlock(float curIndex, out float preferTo); // 0x000000018D229F7C-0x000000018D22A1D8
		}
	
		public struct ScrollEffectConfig // TypeDefIndex: 74513
		{
			// Fields
			public Action onScrollToItem; // 0x00
			public Action onAlignedToItem; // 0x08
			public float minScrollInterval; // 0x10
			public Timing timing; // 0x14
	
			// Nested types
			public enum Timing // TypeDefIndex: 74512
			{
				HALF_VALUE = 0,
				FULL_VALUE = 1
			}
	
			// Methods
			public bool IsEmpty(); // 0x0000000185B2AB40-0x0000000185B2AB70
		}
	
		public class ScrollEffectTrigger : IHotfixable // TypeDefIndex: 74514
		{
			// Fields
			private const float DFT_MIN_INTERVAL = 0.1f; // Metadata: 0x02628301
			private bool m_isValid; // 0x10
			private ScrollEffectConfig m_config; // 0x18
			private int m_lastFocusIndex; // 0x30
			private float m_curTime; // 0x34
			private float m_lastScrollTime; // 0x38
			private bool m_hasScrolled; // 0x3C
	
			// Constructors
			public ScrollEffectTrigger(ScrollEffectConfig config); // 0x0000000185B2AB70-0x0000000185B2AC10
	
			// Methods
			public void NotifyScrolling(float curIndex, float deltaTime); // 0x000000018D22A77C-0x000000018D22A898
			public void MarkHasScrolled(); // 0x000000018D22A6E4-0x000000018D22A720
			public void NotifyAlignFinish(); // 0x000000018D22A720-0x000000018D22A77C
			public void Reset(int curIndex); // 0x0000000185B2AAF0-0x0000000185B2AB40
		}
	
		// Constructors
		public UIInertiaViewPager(); // 0x0000000186D51870-0x0000000186D519B0
	
		// Methods
		private void _PlayAudioGear(); // 0x000000018D22C1C4-0x000000018D22C230
		private void _PlayAudioGearLock(); // 0x000000018D22C158-0x000000018D22C1C4
		private void _InitIfNot(); // 0x0000000185B2A8D0-0x0000000185B2AAF0
		public void ClearComponent(); // 0x0000000185B2AC10-0x0000000185B2ACB0
		public override void Tick(float deltaTime); // 0x0000000185383370-0x00000001853834C0
		public void SetPageCount(int pageCount, List<int> segmentFrames = null); // 0x0000000186DB67F0-0x0000000186DB6840
		public void MoveToPage(int pageIndex); // 0x000000018D22C000-0x000000018D22C07C
		protected override void OnAwake(); // 0x0000000185B2A4E0-0x0000000185B2A520
		protected override void OnEnable(); // 0x0000000185B2A550-0x0000000185B2A5B0
		private float _ScrollValue2PageIndex(float value); // 0x0000000185B2A6F0-0x0000000185B2A740
		private float _PageIndex2ScrollValue(float index); // 0x00000001853834C0-0x0000000185383540
		private int _ScrollValueAlignToPage(float value); // 0x0000000185B2A740-0x0000000185B2A770
		private void _SwitchToPage(int targetIndex, bool useTween); // 0x0000000185B2A770-0x0000000185B2A890
		private void _AutoAlign(); // 0x0000000185B2A5B0-0x0000000185B2A610
		private void _OnStateChanged(State from, State to); // 0x000000018D22C07C-0x000000018D22C158
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
	}

	[AddComponentMenu("UI/UI Input Field", 103)]
	public class UIInputField : TMP_InputField, IUIClearable // TypeDefIndex: 74517
	{
		// Fields
		public string activeInputActionId; // 0x398
		public string deactivateInputActionId; // 0x3A0
		[CompilerGenerated]
		private int _activeInputBindingId_k__BackingField; // 0x3A8
		[CompilerGenerated]
		private int _deactivateInputBindingId_k__BackingField; // 0x3AC
		private LuaPanel m_panel; // 0x3B0
		public bool isDebugInputField; // 0x3B8
		private Camera m_fallbackUICamera; // 0x3C0
		private GameObject m_fallbackUIRoot; // 0x3C8
		private RectTransform m_fallbackRectTransform; // 0x3D0
		private int m_activateBindingGroupId; // 0x3D8
		private bool m_isNaviFocused; // 0x3DC
		private bool m_isCloudInputting; // 0x3DD
		private bool m_isSteamKeyboardShowing; // 0x3DE
		[SerializeField]
		private UIStateController _uiStateController; // 0x3E0
		[SerializeField]
		private string _onFocusStateName; // 0x3E8
		[SerializeField]
		private string _onFocusLostStateName; // 0x3F0
		[AudioString]
		[SerializeField]
		private string _audioPressStart; // 0x3F8
		public RectTransform m_keyboardOffsetTarget; // 0x400
		public RectTransform m_offsetTargetParent; // 0x408
		public RectTransform m_inputFieldRect; // 0x410
		public int m_pcDebug; // 0x418
		public float m_keyboardExtraOffsetY; // 0x41C
		private Vector2 m_baseKeyboardOffsetTarget; // 0x420
		private Vector2 m_baseKeyboardLocalPos; // 0x428
		private float m_inputFieldOffsetY; // 0x430
		private bool m_enableKeyboardOffsetCal; // 0x434
		private Coroutine m_heightChangeCoroutine; // 0x438
		private int m_lastHeight; // 0x440
		private int m_nowHeight; // 0x444
		[AudioString]
		public string audioOnActive; // 0x448
		private static UIInputField s_mFocusedInputField; // 0x00
	
		// Properties
		public int activeInputBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233990-0x00000001872339A0 0x0000000187233A30-0x0000000187233A40
		public int deactivateInputBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724CB30-0x000000018724CB40 0x000000018724CB40-0x000000018724CB50
		public LuaPanel panel { get; } // 0x000000018D22C80C-0x000000018D22C8CC 
		private bool isControllerInputValid { get; } // 0x00000001856B8300-0x00000001856B8390 
		public static UIInputField s_focusedInputField { get; private set; } // 0x000000018D22C8CC-0x000000018D22C93C 0x00000001856B9110-0x00000001856B92F0
	
		// Nested types
		[CompilerGenerated]
		private sealed class __KeyboardHeightChange_d__66 : IEnumerator<object> // TypeDefIndex: 74516
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UIInputField __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __KeyboardHeightChange_d__66(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D22A898-0x000000018D22A8F4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D22A8F4-0x000000018D22A940
		}
	
		// Constructors
		public UIInputField(); // 0x0000000185E78CD0-0x0000000185E78D90
	
		// Methods
		protected override void SendOnFocus(); // 0x0000000186E4B940-0x0000000186E4BA30
		protected override void SendOnFocusLost(); // 0x0000000186EDF9A0-0x0000000186EDFA60
		protected override void Awake(); // 0x00000001868C48B0-0x00000001868C4C70
		public override void OnSelect(BaseEventData eventData); // 0x0000000186EBA8F0-0x0000000186EBA930
		public override void OnDeselect(BaseEventData eventData); // 0x0000000186E7AFB0-0x0000000186E7AFF0
		public override void OnUpdateSelected(BaseEventData eventData); // 0x0000000185A077C0-0x0000000185A07800
		public override void ActivateInputField(); // 0x00000001856B7EA0-0x00000001856B7FB0
		protected override bool TryActivateInputFieldCustom(); // 0x000000018702B420-0x000000018702B4E0
		private void _SteamFloatingKeyboardShow(); // 0x00000001856B8E00-0x00000001856B8EB0
		private void _SteamFloatingKeyboardHide(); // 0x00000001856B82A0-0x00000001856B8300
		public override void DeactivateInputField(bool clearSelection = false /* Metadata: 0x02628305 */); // 0x00000001856B8110-0x00000001856B82A0
		protected override void OnDestroy(); // 0x00000001856B7FB0-0x00000001856B8110
		protected override void OnEnable(); // 0x0000000185A07990-0x0000000185A079D0
		protected override void OnDisable(); // 0x0000000185A079D0-0x0000000185A07A10
		protected override void _NotifyIsHover(bool isHover); // 0x00000001869DF120-0x00000001869DF1B0
		public override void OnInteractableChanged(); // 0x000000018D22C2B4-0x000000018D22C2EC
		private void _UpdateBindingEnable(); // 0x0000000185A07A10-0x0000000185A07B90
		public void ClearComponent(); // 0x00000001856B87C0-0x00000001856B8D80
		private void _OnCloudGameKeyboardComplete(string value, bool submit); // 0x000000018D22C670-0x000000018D22C7D4
		private Camera _GetCamera(); // 0x000000018D22C378-0x000000018D22C5C8
		private void _VirtualKeyboardOnDestroy(); // 0x00000001856B8D80-0x00000001856B8DB0
		private void _VirtualKeyboardSelect(); // 0x0000000186EBA930-0x0000000186EBA960
		private void _VirtualKeyboardDeselect(); // 0x0000000186E7AFF0-0x0000000186E7B020
		private void _VirtualKeyboardAwake(); // 0x00000001868C4C70-0x00000001868C4CA0
		private void _UpdateKeyboardOffset(int offsetHeight); // 0x000000018D22C7D4-0x000000018D22C80C
		private void _CleanupAndroidObjects(); // 0x000000018D22C344-0x000000018D22C378
		private void _VirtualKeyboardInitJavaObj(); // 0x00000001868C4CA0-0x00000001868C4CD0
		[IteratorStateMachine(typeof(__KeyboardHeightChange_d__66))]
		private IEnumerator _KeyboardHeightChange(Action<int> onHeightChanged); // 0x000000018D22C5C8-0x000000018D22C670
		[CompilerGenerated]
		private void _Awake_b__29_0(); // 0x000000018D22C2EC-0x000000018D22C2FC
		public void __iFixBaseProxy_SendOnFocus(); // 0x000000018D22C33C-0x000000018D22C344
		public void __iFixBaseProxy_SendOnFocusLost(); // 0x000000018D22C334-0x000000018D22C33C
		public void __iFixBaseProxy_Awake(); // 0x000000018D1F7518-0x000000018D1F7520
		public void __iFixBaseProxy_OnSelect(BaseEventData P0); // 0x000000018D22C324-0x000000018D22C32C
		public void __iFixBaseProxy_OnDeselect(BaseEventData P0); // 0x000000018D22C30C-0x000000018D22C314
		public void __iFixBaseProxy_OnUpdateSelected(BaseEventData P0); // 0x000000018D22C32C-0x000000018D22C334
		public void __iFixBaseProxy_ActivateInputField(); // 0x000000018D22C2FC-0x000000018D22C304
		public bool __iFixBaseProxy_TryActivateInputFieldCustom(); // 0x00000001843FFFF0-0x0000000184400000
		public void __iFixBaseProxy_DeactivateInputField(bool P0); // 0x000000018D22C304-0x000000018D22C30C
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D1F7520-0x000000018D1F7528
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D22C31C-0x000000018D22C324
		public void __iFixBaseProxy_OnDisable(); // 0x000000018D22C314-0x000000018D22C31C
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018D21BBD4-0x000000018D21BBDC
		public void __iFixBaseProxy_OnInteractableChanged(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[RequireComponent(typeof(CanvasGroup))]
	public class UIJoystick : MonoBehaviour, IBeginDragHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler, IUIClearable, IBindingGroupTarget // TypeDefIndex: 74518
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
		public LuaPanel panel { get; } // 0x000000018D22D070-0x000000018D22D130 
		public bool isDynamic { get; set; } // 0x000000018D22D02C-0x000000018D22D070 0x000000018D22D1B8-0x000000018D22D1FC
		public float walkRation { get; set; } // 0x000000018D22D174-0x000000018D22D1B8 0x0000000186CD1D60-0x0000000186CD1DB0
		public bool active { get; } // 0x000000018707EAC0-0x000000018707EAF0 
		public int activeTouchId { get; } // 0x00000001871DDA70-0x00000001871DDAB0 
		public Vector2 jsValue { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018724C820-0x000000018724C840 0x0000000187232C60-0x0000000187232C70
		private float m_thumbPosMaxLength { get; } // 0x00000001855617C0-0x0000000185561840 
		public PointerEventData curDragEventData { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C230-0x000000018723C240 0x0000000188DC4DE0-0x0000000188DC4DF4
		public bool groupEnabled { get; } // 0x00000001851DCC60-0x00000001851DCCC0 
		public bool shouldCheckInput { get; } // 0x00000001851DCBE0-0x00000001851DCC60 
		public int groupId { get; } // 0x000000018D22CFD8-0x000000018D22D02C 
		public IBindingGroupTarget parentTarget { get; } // 0x000000018D22D130-0x000000018D22D174 
		public InputBindingGroupMonoTarget parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C0D0-0x000000018723C0E0 0x0000000188DC4B88-0x0000000188DC4B9C
	
		// Constructors
		public UIJoystick(); // 0x00000001864E45E0-0x00000001864E4900
	
		// Methods
		private void Reset(); // 0x000000018D22CE00-0x000000018D22CED4
		private void Awake(); // 0x000000018531B210-0x000000018531B8A0
		protected void OnEnable(); // 0x0000000186FCF410-0x0000000186FCF540
		private void Start(); // 0x00000001871069B0-0x0000000187106A50
		protected void OnDestroy(); // 0x000000018D22CA48-0x000000018D22CC78
		private void _Tick(); // 0x00000001851DBBA0-0x00000001851DC5F0
		protected void OnDisable(); // 0x000000018D22CC78-0x000000018D22CE00
		public void OnPointerDown(PointerEventData eventData); // 0x000000018677A070-0x000000018677A1C0
		public void OnPointerUp(PointerEventData eventData); // 0x00000001869C93E0-0x00000001869C9550
		public void OnBeginDrag(PointerEventData eventData); // 0x0000000186C71470-0x0000000186C714B0
		public void OnDrag(PointerEventData eventData); // 0x0000000185561570-0x00000001855617C0
		public void CheckShouldActive(); // 0x0000000186566890-0x0000000186566E30
		private void _SetVisible(bool visible); // 0x000000018677A010-0x000000018677A070
		private void _ChangeDynamic(bool dynamic, bool force = false /* Metadata: 0x02628306 */); // 0x0000000186779CF0-0x0000000186779E50
		private void _SetRectTransform(bool toOri); // 0x000000018677A290-0x000000018677A3A0
		private void _UpdateWalkBgScale(); // 0x0000000186CD1DB0-0x0000000186CD1F70
		private void _Activate(bool fromTouch, Vector2 showPos, Vector2 initJsValue); // 0x000000018677A1C0-0x000000018677A290
		private void _UpdateGait(); // 0x00000001855614A0-0x0000000185561570
		private void _UpdateIndicator(); // 0x0000000185561840-0x00000001855619F0
		private void _UpdateBg(); // 0x0000000185561240-0x0000000185561380
		private void _SetWalkBgVisible(bool visible, bool ignoreAnim = false /* Metadata: 0x02628307 */); // 0x0000000185561380-0x00000001855613F0
		private void _SetRunBgVisible(bool visible, bool ignoreAnim = false /* Metadata: 0x02628308 */); // 0x00000001855613F0-0x00000001855614A0
		private void _OnHudLayoutLoaded([IsReadOnly] in EventData<string> eventData); // 0x000000018D22CEE0-0x000000018D22CFD8
		public void ClearComponent(); // 0x000000018D22C93C-0x000000018D22CA48
		public void InitBinding(); // 0x0000000186E05740-0x0000000186E05890
		private void _UpdateState(); // 0x0000000186E05890-0x0000000186E05970
		[CompilerGenerated]
		private void _Awake_b__76_0(Vector2 _); // 0x000000018D22CED4-0x000000018D22CEE0
	}

	public class UILayoutDimensionListener : UIBehaviour, IHotfixable, ICanvasElement // TypeDefIndex: 74521
	{
		// Fields
		private ListSet<IAction> m_actionsWhenLayoutReady; // 0x18
		[NonSerialized]
		public DisposedUnityEvent eventOnPostLayout; // 0x20
	
		// Properties
		Transform ICanvasElement.transform { get; } // 0x0000000185018A90-0x0000000185018AC0 
	
		// Nested types
		public interface IAction // TypeDefIndex: 74519
		{
			// Methods
			void DoAction();
		}
	
		[CompilerGenerated]
		private sealed class __NextFrameCoroutine_d__6 : IEnumerator<object> // TypeDefIndex: 74520
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UILayoutDimensionListener __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __NextFrameCoroutine_d__6(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x00000001869E4BD0-0x00000001869E4C30
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D22A940-0x000000018D22A98C
		}
	
		// Constructors
		public UILayoutDimensionListener(); // 0x0000000186B931A0-0x0000000186B93280
	
		// Methods
		public void GraphicUpdateComplete(); // 0x000000018D22D294-0x000000018D22D2C8
		public void LayoutComplete(); // 0x0000000186EDC5B0-0x0000000186EDC5E0
		public void Rebuild(CanvasUpdate executing); // 0x0000000186AABDA0-0x0000000186AABE00
		[IteratorStateMachine(typeof(__NextFrameCoroutine_d__6))]
		private IEnumerator _NextFrameCoroutine(); // 0x0000000186AABE00-0x0000000186AABE90
		public void DoOnceOnPostLayout(IAction action); // 0x000000018D22D1FC-0x000000018D22D294
		protected override void OnEnable(); // 0x00000001869B89A0-0x00000001869B89D0
		protected override void OnRectTransformDimensionsChange(); // 0x00000001869B89D0-0x00000001869B8A00
		protected override void OnDestroy(); // 0x00000001869E4B40-0x00000001869E4BD0
		private void _SetDirty(); // 0x00000001869B8A00-0x00000001869B8A90
		private void _InvokePostLayoutCallback(); // 0x00000001869E4C30-0x00000001869E4EF0
		public void __iFixBaseProxy_OnEnable(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnRectTransformDimensionsChange(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class UILeftSubtitle : TickableUIMono // TypeDefIndex: 74522
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
		protected override TickType tickOption { get; } // 0x000000018D22DB6C-0x000000018D22DBB0 
	
		// Constructors
		public UILeftSubtitle(); // 0x000000018D22DAD8-0x000000018D22DB6C
	
		// Methods
		public override void Tick(float deltaTime); // 0x000000018D22D920-0x000000018D22D9C4
		public void StartAutoPlay(float textStayTime); // 0x000000018D22D8B8-0x000000018D22D920
		public void SetLeftSubTitle(string text1, string text2, string text3, string text4); // 0x000000018D22D3C4-0x000000018D22D84C
		public float UpdateByPlayTime(float currTime); // 0x000000018D22D9D0-0x000000018D22DAD8
		public void Exit(); // 0x000000018D22D2C8-0x000000018D22D3C4
		public void SetVisible(bool visible); // 0x000000018D22D84C-0x000000018D22D8B8
		[CompilerGenerated]
		private void _Exit_b__17_0(); // 0x000000018D22D9C4-0x000000018D22D9D0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	[ExecuteInEditMode]
	public class UIMaterialAnimation : TickableUIMono // TypeDefIndex: 74525
	{
		// Fields
		private const float VALUE_SET_EPS = 1E-06f; // Metadata: 0x02628309
		private const int FLOAT_SLOT_COUNT = 10; // Metadata: 0x0262830D
		private const int VECTOR_SLOT_COUNT = 5; // Metadata: 0x0262830E
		private const int COLOR_SLOT_COUNT = 3; // Metadata: 0x0262830F
		private const int TOTAL_SLOT_COUNT = 18; // Metadata: 0x02628310
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
		private FPropEntry[] m_props; // 0x1E0
		private bool m_cacheValid; // 0x1E8
		private Material m_cachedMaterial; // 0x1F0
		private bool m_cachedMaterialAlive; // 0x1F8
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001865BCFB0-0x00000001865BD010 
		public Material materialInstance { get; } // 0x0000000184E54CF0-0x0000000184E54D30 
	
		// Nested types
		private enum EPropKind : byte // TypeDefIndex: 74523
		{
			Float = 0,
			Vector = 1,
			Color = 2
		}
	
		private struct FPropEntry // TypeDefIndex: 74524
		{
			// Fields
			public int id; // 0x00
			public EPropKind kind; // 0x04
			public int slot; // 0x08
			public Vector4 cached; // 0x0C
		}
	
		// Constructors
		public UIMaterialAnimation(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		public override void LateTick(float deltaTime); // 0x0000000185F03320-0x0000000185F03350
		protected override void OnAwake(); // 0x00000001852DDAB0-0x00000001852DE860
		protected override void OnRelease(); // 0x0000000186934B70-0x0000000186934C60
		public void ForceUpdate(); // 0x000000018D22DBB0-0x000000018D22DBF0
		private void _BuildPropertyTable(); // 0x0000000184E53B90-0x0000000184E545B0
		private void _TryUpdate(); // 0x00000001850BABE0-0x00000001850BAEE0
		private Material _ResolveTargetMaterial(); // 0x0000000184E54960-0x0000000184E54CF0
		private static bool _NearlyEqual(Vector4 left, Vector4 right); // 0x000000018D22DBF0-0x000000018D22DC4C
		private static EPropKind _GetSlotKind(int slot); // 0x0000000184E54690-0x0000000184E546D0
		private string _GetSlotName(int slot); // 0x0000000184E546D0-0x0000000184E54800
		private float _GetSlotFloat(int slot); // 0x0000000184E545B0-0x0000000184E54690
		private Vector4 _GetSlotVector(int slot); // 0x0000000184E54800-0x0000000184E54960
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	[AddComponentMenu("UI/UI Multi Select Dropdown", 103)]
	public class UIMultiSelectDropdown : Selectable, IPointerClickHandler, IUIClearable, IBindingGroupTarget, IBindingView // TypeDefIndex: 74528
	{
		// Fields
		[HideInInspector]
		public UnityEvent<int, bool> onValueChanged; // 0x190
		[HideInInspector]
		public UnityEvent<int, UIDropdownOption, bool> onUpdateCell; // 0x198
		[HideInInspector]
		public UnityEvent<int, UIMultiSelectDropdown> onUpdateCaption; // 0x1A0
		[FormerlySerializedAs("onToggleList")]
		[HideInInspector]
		public UnityEvent<bool> onToggleOptList; // 0x1A8
		public Func<int, bool, bool> onValidateValueChanged; // 0x1B0
		public UIText captionText; // 0x1B8
		public UIImage captionIcon; // 0x1C0
		[CompilerGenerated]
		private int _optionCount_k__BackingField; // 0x1C8
		[CompilerGenerated]
		private int _selectedCount_k__BackingField; // 0x1CC
		[CompilerGenerated]
		private int _lastSelectedIndex_k__BackingField; // 0x1D0
		[CompilerGenerated]
		private bool _isListActive_k__BackingField; // 0x1D4
		[SerializeField]
		private UIDropdownOption _optionTemplate; // 0x1D8
		[SerializeField]
		private Transform _arrowImageTrans; // 0x1E0
		[SerializeField]
		private RectTransform _listContainer; // 0x1E8
		[SerializeField]
		private float _listContainerMaxHeight; // 0x1F0
		[SerializeField]
		private float _animationTime; // 0x1F4
		[SerializeField]
		private RectTransform _selfArea; // 0x1F8
		[SerializeField]
		[Tooltip("\u8FD9\u91CC\u4E3A\u7A7A\u7684\u8BDD\uFF0C\u70B9\u5F00Dropdown\u65F6\u70B9\u51FB\u4EFB\u610F\u975EDropdown\u533A\u57DF\u4F1A\u6536\u8D77\uFF0C\u6709\u7684\u8BDD\u53EA\u4F1A\u54CD\u5E94mask\u533A\u57DF\u5185\u7684")]
		private RectTransform _maskRect; // 0x200
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
		private readonly List<UIDropdownOption> m_options; // 0x228
		private readonly List<bool> m_selectedStates; // 0x230
		private LuaPanel m_panel; // 0x238
		private LayoutGroup m_content; // 0x240
		private Camera m_fallbackUICamera; // 0x248
		private UIScrollRect m_listScrollRect; // 0x250
		private CanvasGroup m_listContainerCanvasGroup; // 0x258
		[FormerlySerializedAs("_openDropDownActionId")]
		public string openDropDownActionId; // 0x260
		public string openDropDownBindingTextId; // 0x268
		private int m_bindingGroupId; // 0x270
		private int m_naviBindingGroupId; // 0x274
		private LuaPanel m_luaPanel; // 0x278
		private UISelectableNaviGroup m_listNaviGroup; // 0x280
		[CompilerGenerated]
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0x288
		[CompilerGenerated]
		private readonly DisposedUnityEvent _bindingViewUpdateEvent_k__BackingField; // 0x290
	
		// Properties
		public int optionCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723D850-0x000000018723D860 0x000000018723D9B0-0x000000018723D9C0
		public int selectedCount { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187258D00-0x0000000187258D10 0x0000000187258D20-0x0000000187258D30
		public int lastSelectedIndex { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187258D40-0x0000000187258D50 0x0000000187258D60-0x0000000187258D70
		public bool isListActive { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187258D30-0x0000000187258D40 0x0000000187258D50-0x0000000187258D60
		public LuaPanel panel { get; } // 0x000000018D230C20-0x000000018D230CE0 
		public int groupId { get; } // 0x000000018D230BDC-0x000000018D230C20 
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C0F0-0x000000018723C100 0x0000000188DC4BD8-0x0000000188DC4BEC
		public bool groupEnabled { get; } // 0x000000018D230B4C-0x000000018D230BDC 
		public string bindingViewActionId { get; } // 0x000000018D230920-0x000000018D230964 
		public string bindingViewLabelText { get; } // 0x000000018D230964-0x000000018D2309FC 
		public DisposedUnityEvent bindingViewUpdateEvent { [CompilerGenerated] get; } // 0x000000018723B2A0-0x000000018723B2B0 
		public RectTransform redDotTrans { get; } // 0x000000018D230CE0-0x000000018D230D20 
		public bool bindingEnabled { get; } // 0x000000018D2308E4-0x000000018D230920 
		public BindingViewState bindingViewState { get; } // 0x000000018D2309FC-0x000000018D230B4C 
		bool IBindingView.interactable { get; } // 0x000000018D22DE5C-0x000000018D22DEA0 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0 // TypeDefIndex: 74526
		{
			// Fields
			public UIMultiSelectDropdown __4__this; // 0x10
			public bool activeList; // 0x18
	
			// Constructors
			public __c__DisplayClass48_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __ToggleOptions_b__0(); // 0x0000000184E535D0-0x0000000184E536A0
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0 // TypeDefIndex: 74527
		{
			// Fields
			public int index; // 0x10
			public UIMultiSelectDropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass59_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Refresh_b__0(PointerEventData evt); // 0x0000000184E536E0-0x0000000184E53AB0
		}
	
		// Constructors
		public UIMultiSelectDropdown(); // 0x000000018D230618-0x000000018D2308E4
	
		// Methods
		protected override void Awake(); // 0x000000018D22DC4C-0x000000018D22DDEC
		protected override void _NotifyIsHover(bool isHover); // 0x000000018D22FF40-0x000000018D22FFF8
		public void OnPointerClick(PointerEventData eventData); // 0x000000018D22E6E4-0x000000018D22E7C8
		public void Init(UnityAction<int, UIDropdownOption, bool> onUpdateCell, UnityAction<int, bool> onValueChanged, UnityAction<int, UIMultiSelectDropdown> onUpdateCaption = null); // 0x000000018D22E320-0x000000018D22E428
		public void ToggleOptions(bool activeList); // 0x000000018D22F398-0x000000018D22F3DC
		private void _ToggleOptions(bool activeList, bool isInit); // 0x000000018D2300D8-0x000000018D230618
		private void Update(); // 0x000000018D22F3DC-0x000000018D22F60C
		public void SetSelected(int index, bool isOn, bool forceUpdate = false /* Metadata: 0x02628314 */, bool needNotifySelect = true /* Metadata: 0x02628315 */, bool validateSelect = false /* Metadata: 0x02628316 */); // 0x000000018D22F070-0x000000018D22F398
		public void SetSelectedList(IEnumerable<int> indices, bool isOn, bool needNotifySelect = true /* Metadata: 0x02628317 */, bool validateSelect = false /* Metadata: 0x02628318 */); // 0x000000018D22EEAC-0x000000018D22F070
		public void ClearSelected(bool notify = true /* Metadata: 0x02628319 */); // 0x000000018D22DF7C-0x000000018D22E058
		public bool IsSelected(int index); // 0x000000018D22E428-0x000000018D22E4D4
		public List<int> GetSelectedIndices(); // 0x000000018D22E11C-0x000000018D22E220
		public List<bool> GetSelectedStates(); // 0x000000018D22E220-0x000000018D22E320
		public void ScrollToLastSelected(); // 0x000000018D22EE6C-0x000000018D22EEAC
		public void ScrollToIndex(int index); // 0x000000018D22ED3C-0x000000018D22EE6C
		[IDTag(1)]
		public void Refresh(int count); // 0x000000018D22ECE0-0x000000018D22ED3C
		[IDTag(0)]
		public void Refresh(int count, IEnumerable<int> selectedIndices, bool needNotifyValueChanged = true /* Metadata: 0x0262831A */); // 0x000000018D22E7C8-0x000000018D22ECE0
		public void ClearComponent(); // 0x000000018D22DEA0-0x000000018D22DF7C
		private bool _IsValidIndex(int index); // 0x000000018D22FEF8-0x000000018D22FF40
		private void _ResizeSelectedStates(int count); // 0x000000018D22FFF8-0x000000018D2300D8
		private int _GetLastSelectedIndex(); // 0x000000018D22F8A0-0x000000018D22F940
		private Camera _GetUICamera(); // 0x000000018D22F940-0x000000018D22FB94
		public string GetBindingViewActionId(BindingViewActionType actionType); // 0x000000018D22E058-0x000000018D22E11C
		void IBindingView.OnInputKeyDown(bool isActionTrigger); // 0x000000018D22DDEC-0x000000018D22DE24
		void IBindingView.OnInputKeyUp(bool isActionTrigger); // 0x000000018D22DE24-0x000000018D22DE5C
		private void _InitBinding(); // 0x000000018D22FB94-0x000000018D22FEF8
		private void _ControllerToggle(); // 0x000000018D22F678-0x000000018D22F6F0
		private void _ControllerCancel(); // 0x000000018D22F60C-0x000000018D22F678
		private Selectable _GetDefaultNaviTarget(); // 0x000000018D22F6F0-0x000000018D22F8A0
		protected override void OnEnable(); // 0x000000018D22E63C-0x000000018D22E6E4
		protected override void OnDisable(); // 0x000000018D22E594-0x000000018D22E63C
		protected override void OnDestroy(); // 0x000000018D22E4D4-0x000000018D22E594
		public void __iFixBaseProxy_Awake(); // 0x000000018D1F7518-0x000000018D1F7520
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018D21BBD4-0x000000018D21BBDC
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D1F7528-0x000000018D1F7530
		public void __iFixBaseProxy_OnDisable(); // 0x0000000185C2D7B0-0x0000000185C2D7C0
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D1F7520-0x000000018D1F7528
	}

	public class UINonUnifiedScrollList : UIScrollList // TypeDefIndex: 74530
	{
		// Fields
		public GetCellSizeMode getCellSizeMode; // 0x280
		[SerializeField]
		private bool _recalculateAfterSizeChange; // 0x284
		[SerializeField]
		private bool _forceUpdateCellSizeCache; // 0x285
		public Func<int, int> getSubCellCount; // 0x288
		public Func<int, float> getCellSize; // 0x290
		[NonSerialized]
		public float overrideContainSize; // 0x298
		private GridLayoutGroup m_templateCellGridLayoutGroup; // 0x2A0
		private Dictionary<int, float> m_cellSizeCache; // 0x2A8
		private int m_containerTopIndex; // 0x2B0
		private const float CONTAINER_SIZE_BUFFER = 50f; // Metadata: 0x0262832D
		[NonSerialized]
		public float additiveContainerSizeBuffer; // 0x2B4
		private float m_lastScrollStep; // 0x2B8
		private bool m_isRecalculatingSize; // 0x2BC
		private bool m_isCalculatingContainerSize; // 0x2BD
		private int m_averageCount; // 0x2C0
		private float m_averageCellSize; // 0x2C4
		private bool m_needRecalculateAverage; // 0x2C8
		private Dictionary<int, bool> m_cellFoldStateDic; // 0x2D0
		private IUIFoldoutComp m_cellTemplateFoldoutComp; // 0x2D8
	
		// Properties
		public override float currentStep { get; set; } // 0x00000001868A4100-0x00000001868A41F0 0x000000018D231758-0x000000018D2317BC
	
		// Nested types
		public enum GetCellSizeMode // TypeDefIndex: 74529
		{
			ByGetCellSizeFunc = 0,
			ByLayoutGroup = 1,
			GetAfterCellCreated = 2
		}
	
		// Constructors
		public UINonUnifiedScrollList(); // 0x0000000186AC5F60-0x0000000186AC6170
	
		// Methods
		protected override void InitBasicInfo(); // 0x00000001869479C0-0x0000000186947A90
		protected override void CalcSomeCountNum(); // 0x0000000186C2FCF0-0x0000000186C2FD80
		protected override float GetLeftLength(bool checkVertical, int checkCount = -1 /* Metadata: 0x0262831B */); // 0x00000001869DF520-0x00000001869DF580
		[IDTag(0)]
		public override void UpdateCount(int newCount); // 0x0000000186123210-0x0000000186123260
		[IDTag(1)]
		public override void UpdateCount(int newCount, bool setTop, bool forceRecalculate = false /* Metadata: 0x0262831C */, bool onlyUpdateNewCellContent = false /* Metadata: 0x0262831D */, bool skipGraduallyShow = false /* Metadata: 0x0262831E */); // 0x0000000185C8D0B0-0x0000000185C8D120
		[IDTag(2)]
		public override void UpdateCount(int newCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x0262831F */, bool onlyUpdateNewCellContent = false /* Metadata: 0x02628320 */, bool skipGraduallyShow = false /* Metadata: 0x02628321 */, ScrollAlignType alignType = ScrollAlignType.Top /* Metadata: 0x02628322 */); // 0x0000000185C8D120-0x0000000185C8D380
		public override void LateTick(float deltaTime); // 0x00000001867DC420-0x00000001867DC470
		protected override void OnScroll(Vector2 v); // 0x0000000185C8D400-0x0000000185C8D470
		public static Vector2 GetGridLayoutSize(GridLayoutGroup grid, int count); // 0x000000018D230F7C-0x000000018D231140
		private float _GetCellSize(int index); // 0x00000001853D0830-0x00000001853D0A90
		protected override float GetContainerSize(bool ignoreAutoLayout = false /* Metadata: 0x02628323 */); // 0x00000001853D03C0-0x00000001853D0830
		public override float GetCenterIndex(); // 0x000000018D230D20-0x000000018D230F7C
		public override Vector2Int GetShowRange(float bufferSize = 0f /* Metadata: 0x02628324 */, bool ignoreGraduallyShow = false /* Metadata: 0x02628328 */); // 0x00000001853D0060-0x00000001853D0300
		protected override Vector2Int GetNotCacheRange(); // 0x0000000186894A80-0x0000000186894B70
		protected override void MoveCellTo(Cell cell, int index); // 0x000000018649C130-0x000000018649C220
		protected override void OnUpdateCell(Cell cell, int index); // 0x000000018566EB30-0x000000018566EDD0
		protected override float GetTargetPosByIndex(int index, ScrollAlignType alignType = ScrollAlignType.Top /* Metadata: 0x02628329 */); // 0x0000000185381D60-0x0000000185381F80
		private float _GetCellsSizeTo(int index); // 0x00000001853D0300-0x00000001853D03C0
		protected override void ScrollTo(int index, bool fastMode = false /* Metadata: 0x0262832A */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0262832B */); // 0x0000000185BA8B40-0x0000000185BA8E10
		public override void ClearComponent(); // 0x0000000185B2AF20-0x0000000185B2AFD0
		public override void SetStepTo(float step); // 0x000000018D231410-0x000000018D231470
		public void SetCurrentStep(float currentStep); // 0x000000018D231140-0x000000018D231340
		public float GetScrollBarSize(); // 0x0000000185C8B6A0-0x0000000185C8B820
		public float GetLastScrollStep(); // 0x0000000185C8AD40-0x0000000185C8AF70
		public void UpdateLastScrollStep(); // 0x0000000185C8AD00-0x0000000185C8AD40
		public float GetNormalizedPosition(); // 0x0000000185C8B5E0-0x0000000185C8B6A0
		public void SetNormalizedPosition(float normalizedPosition); // 0x000000018D231340-0x000000018D231410
		public void ToggleByState(int index, bool isFoldOut, bool fastMode); // 0x00000001858ADDD0-0x00000001858ADF60
		public void Toggle(int index, bool fastMode = false /* Metadata: 0x0262832C */); // 0x000000018D231470-0x000000018D2316A0
		public void FoldAll(bool isFoldOut); // 0x00000001858ADF60-0x00000001858AE130
		public void NotifyCellSizeChange(int index, float size); // 0x00000001858AD9E0-0x00000001858ADAA0
		[CompilerGenerated]
		private void _GetScrollBarSize_g__RecalculateAverageCellSize_43_0(); // 0x0000000185C8CCA0-0x0000000185C8CF10
		public void __iFixBaseProxy_InitBasicInfo(); // 0x000000018D2316C8-0x000000018D2316D0
		public void __iFixBaseProxy_CalcSomeCountNum(); // 0x000000018D2316A0-0x000000018D2316A8
		public float __iFixBaseProxy_GetLeftLength(bool P0, int P1); // 0x000000018D2316B0-0x000000018D2316B8
		public void __iFixBaseProxy_UpdateCount(int P0); // 0x000000018D231740-0x000000018D231748
		public void __iFixBaseProxy_UpdateCount(int P0, bool P1, bool P2, bool P3, bool P4); // 0x000000018D231720-0x000000018D231740
		public void __iFixBaseProxy_UpdateCount(int P0, int P1, bool P2, bool P3, bool P4, ScrollAlignType P5); // 0x000000018D231700-0x000000018D231720
		public void __iFixBaseProxy_LateTick(float P0); // 0x000000018D2316D0-0x000000018D2316D8
		public void __iFixBaseProxy_OnScroll(Vector2 P0); // 0x000000018D2316D8-0x000000018D2316E0
		public float __iFixBaseProxy_GetContainerSize(bool P0); // 0x000000018D2268B4-0x000000018D2268BC
		public float __iFixBaseProxy_GetCenterIndex(); // 0x000000018D2316A8-0x000000018D2316B0
		public Vector2Int __iFixBaseProxy_GetShowRange(float P0, bool P1); // 0x000000018D2316C0-0x000000018D2316C8
		public Vector2Int __iFixBaseProxy_GetNotCacheRange(); // 0x000000018D2316B8-0x000000018D2316C0
		public void __iFixBaseProxy_MoveCellTo(Cell P0, int P1); // 0x000000018D2143A0-0x000000018D2143A8
		public void __iFixBaseProxy_OnUpdateCell(Cell P0, int P1); // 0x000000018D2316E0-0x000000018D2316E8
		public float __iFixBaseProxy_GetTargetPosByIndex(int P0, ScrollAlignType P1); // 0x000000018D2268CC-0x000000018D2268D4
		public void __iFixBaseProxy_ScrollTo(int P0, bool P1, ScrollAlignType P2); // 0x000000018D2316E8-0x000000018D2316F8
		public void __iFixBaseProxy_ClearComponent(); // 0x000000018D2268A4-0x000000018D2268AC
		public float __iFixBaseProxy_get_currentStep(); // 0x000000018D231748-0x000000018D231750
		public void __iFixBaseProxy_set_currentStep(float P0); // 0x000000018D231750-0x000000018D231758
		public void __iFixBaseProxy_SetStepTo(float P0); // 0x000000018D2316F8-0x000000018D231700
	}

	[RequireComponent(typeof(UINonUnifiedScrollList))]
	public class UINonUnifiedScrollRect : UIScrollRect // TypeDefIndex: 74531
	{
		// Fields
		private bool m_isInited; // 0x1F0
		private bool m_isRebuilding; // 0x1F1
		private UINonUnifiedScrollList m_scrollList; // 0x1F8
		private UILayoutDimensionListener m_dimensionListener; // 0x200
	
		// Constructors
		public UINonUnifiedScrollRect(); // 0x0000000186E5C330-0x0000000186E5C380
	
		// Methods
		private void _InitIfNot(); // 0x0000000185C8B370-0x0000000185C8B4B0
		protected override void UpdateScrollbars(Vector2 offset); // 0x0000000185C8B240-0x0000000185C8B370
		public override void Rebuild(CanvasUpdate executing); // 0x0000000185C8B200-0x0000000185C8B240
		private void _UpdateNonUnifiedScrollbars(); // 0x0000000185C8B4B0-0x0000000185C8B5E0
		protected override void SetHorizontalNormalizedPosition(float value); // 0x000000018D2317F4-0x000000018D231934
		protected override void SetVerticalNormalizedPosition(float value); // 0x000000018D231934-0x000000018D231A74
		private void _OnPostLayout(); // 0x0000000185C8AC10-0x0000000185C8AD00
		public void __iFixBaseProxy_UpdateScrollbars(Vector2 P0); // 0x000000018D231A7C-0x000000018D231A84
		public void __iFixBaseProxy_Rebuild(CanvasUpdate P0); // 0x000000018D231A74-0x000000018D231A7C
		public void __iFixBaseProxy_SetHorizontalNormalizedPosition(float P0); // 0x0000000187835CEC-0x0000000187835CF8
		public void __iFixBaseProxy_SetVerticalNormalizedPosition(float P0); // 0x0000000187835CC4-0x0000000187835CD4
	}

	[ExecuteAlways]
	[RequireComponent(typeof(UIText))]
	public class UINumberScrollTween : TickableUIMono // TypeDefIndex: 74532
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
		protected override TickType tickOption { get; } // 0x0000000186C05A90-0x0000000186C05AC0 
		public string tweenToText { get; set; } // 0x000000018D231DBC-0x000000018D231E00 0x000000018D231E00-0x000000018D231E40
		public string text { get; set; } // 0x000000018D231D04-0x000000018D231DBC 0x0000000186ECBDC0-0x0000000186ECBEA0
	
		// Constructors
		public UINumberScrollTween(); // 0x0000000186C4F8C0-0x0000000186C4F910
	
		// Methods
		private void Start(); // 0x0000000187180890-0x0000000187180910
		public override void Tick(float deltaTime); // 0x000000018721F770-0x000000018721F7B0
		private void _TweenToTarget(string targetText); // 0x000000018D231BF8-0x000000018D231D04
		private void _CleanupBeforeTween(); // 0x000000018D231A84-0x000000018D231AC8
		private void _HandleNumberScrollTween(float fromNumber, float toNumber, float curTime); // 0x000000018D231AC8-0x000000018D231BF8
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class UIPCScaleHelper : MonoBehaviour // TypeDefIndex: 74533
	{
		// Fields
		public Vector3 baseScale; // 0x18
	
		// Constructors
		public UIPCScaleHelper(); // 0x000000018692E8D0-0x000000018692E910
	
		// Methods
		private void OnEnable(); // 0x00000001868E6D20-0x00000001868E6E20
	}

	[AddComponentMenu("UI/UI Raw Image", 12)]
	public class UIRawImage : RawImage // TypeDefIndex: 74534
	{
		// Constructors
		public UIRawImage(); // 0x0000000186C76560-0x0000000186C76570
	}

	[ExecuteInEditMode]
	public class UIRegionBuildingTexManager : MonoBehaviour // TypeDefIndex: 74535
	{
		// Fields
		[SerializeField]
		private Shader _regionMapShader; // 0x18
		public Texture2D minimapOutlineTex; // 0x20
		private static int s_buildingOutlineTex; // 0x00
		private Renderer m_meshRenderer; // 0x28
		private static MaterialPropertyBlock s_materialPropertyBlock; // 0x08
	
		// Properties
		private static MaterialPropertyBlock materialPropertyBlock { get; } // 0x00000001859DDFB0-0x00000001859DE0C0 
	
		// Constructors
		public UIRegionBuildingTexManager(); // 0x000000018548CC60-0x000000018548CC80
		static UIRegionBuildingTexManager(); // 0x00000001871F2180-0x00000001871F21D0
	
		// Methods
		private void OnEnable(); // 0x00000001859DD550-0x00000001859DD7E0
		private void OnValidate(); // 0x000000018D231E40-0x000000018D231F2C
		private void OnDisable(); // 0x00000001859DDCE0-0x00000001859DDDC0
		private void _UpdateTexture(Renderer meshRenderer, Shader minimapTerrainShader, Texture2D buildingTex); // 0x00000001859DDDC0-0x00000001859DDFB0
	}

	public class UIScaleHolder : TickableUIMono // TypeDefIndex: 74536
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
		protected override TickType tickOption { get; } // 0x000000018615F500-0x000000018615F5C0 
	
		// Constructors
		public UIScaleHolder(); // 0x000000018503F000-0x000000018503F030
	
		// Methods
		protected override void OnAwake(); // 0x00000001853207D0-0x0000000185320AE0
		protected override void OnEnable(); // 0x00000001863AC560-0x00000001863AC5A0
		public override void LateTick(float deltaTime); // 0x0000000185F02DB0-0x0000000185F02DF0
		private bool _IsValidScale(Vector3 scale); // 0x0000000185BFA690-0x0000000185BFA6D0
		private void _HoldScale(); // 0x0000000185029010-0x00000001850292D0
		public void SetExtraScale(Vector3 extraScale); // 0x000000018D231F8C-0x000000018D231FF8
		public Vector3 GetExtraScale(); // 0x000000018D231F2C-0x000000018D231F8C
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	[AddComponentMenu("UI/UI Scrollbar", 36)]
	public class UIScrollbar : Scrollbar // TypeDefIndex: 74537
	{
		// Constructors
		public UIScrollbar(); // 0x0000000186636190-0x00000001866361A0
	
		// Methods
		protected override void Awake(); // 0x0000000186C39BF0-0x0000000186C39C30
		public void __iFixBaseProxy_Awake(); // 0x000000018D1F7518-0x000000018D1F7520
	}

	public class UIScrollbarKeyHint : TickableUIMono // TypeDefIndex: 74538
	{
		// Fields
		private UIScrollRect m_scrollRect; // 0x68
		private UIImage m_image; // 0x70
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D2383A0-0x000000018D238424 
	
		// Constructors
		public UIScrollbarKeyHint(); // 0x000000018503EE80-0x000000018503EE90
	
		// Methods
		protected override void OnAwake(); // 0x000000018D2381D4-0x000000018D23828C
		public override void Tick(float deltaTime); // 0x000000018D23828C-0x000000018D2383A0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class UIScrollCircle : TickableUIMono, IInitializePotentialDragHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, ICanvasElement, IUIClearable // TypeDefIndex: 74540
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
		protected override TickType tickOption { get; } // 0x000000018D233CF8-0x000000018D233D3C 
		public float elasticity { get; set; } // 0x000000018D233BF0-0x000000018D233C38 0x000000018D233EB8-0x000000018D233EFC
		public int count { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233450-0x0000000187233460 0x0000000185B8E410-0x0000000185B8E660
		public float velocity { get; set; } // 0x000000018D233D3C-0x000000018D233D84 0x000000018D233EFC-0x000000018D233F40
		public LuaPanel panel { get; } // 0x000000018D233C38-0x000000018D233CF8 
		protected RectTransform viewRect { get; } // 0x000000018D233D84-0x000000018D233EB8 
		Transform ICanvasElement.transform { get; } // 0x000000018D232A54-0x000000018D232A90 
	
		// Nested types
		public class Cell // TypeDefIndex: 74539
		{
			// Fields
			public GameObject gameObject; // 0x10
			public RectTransform rectTransform; // 0x18
			public GameObject realGameObject; // 0x20
	
			// Constructors
			public Cell(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void SetSelect(bool select); // 0x000000018D2317BC-0x000000018D2317F4
		}
	
		// Constructors
		public UIScrollCircle(); // 0x000000018D233A80-0x000000018D233BF0
	
		// Methods
		public void OnInitializePotentialDrag(PointerEventData eventData); // 0x000000018D2327C0-0x000000018D232820
		public virtual bool IsActive(); // 0x000000018D23214C-0x000000018D232188
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018D2322F8-0x000000018D232454
		public void OnEndDrag(PointerEventData eventData); // 0x000000018D23277C-0x000000018D2327C0
		public void OnDrag(PointerEventData eventData); // 0x000000018D232494-0x000000018D2326F4
		private void _UpdateSpeed(); // 0x000000018D2339D0-0x000000018D233A80
		private bool _CheckCanMove(float deltaAngle); // 0x000000018D232B44-0x000000018D232BA4
		private void _TryUpdateCells(); // 0x000000018D233440-0x000000018D2334BC
		private void _UpdateAuto(); // 0x000000018D2334BC-0x000000018D233630
		protected override void OnRelease(); // 0x000000018D232820-0x000000018D232890
		private float _GetDeltaAngle(Vector2 position); // 0x000000018D232D8C-0x000000018D232F4C
		private void _InitCells(); // 0x000000018D232FA4-0x000000018D23324C
		private void _Init(); // 0x000000018D23324C-0x000000018D233320
		private void _OnAwakeInit(); // 0x000000018D233320-0x000000018D233440
		private void _UpdateScrollRange(); // 0x000000018D2337A0-0x000000018D2337F0
		private int _GetRealIndex(int index); // 0x000000018D232F4C-0x000000018D232FA4
		private void _UpdateShowingCells(); // 0x000000018D2337F0-0x000000018D2339D0
		private void _UpdateCenterIndex(bool forceUpdate = false /* Metadata: 0x02628334 */); // 0x000000018D233630-0x000000018D2337A0
		private void _DoScroll(float tmpAngle, bool direct = false /* Metadata: 0x02628335 */); // 0x000000018D232BA4-0x000000018D232D8C
		public void OnScroll(PointerEventData eventData); // 0x000000018D232890-0x000000018D2328C8
		public void Rebuild(CanvasUpdate executing); // 0x000000018D2328C8-0x000000018D232900
		public void LayoutComplete(); // 0x000000018D23226C-0x000000018D2322A0
		public void GraphicUpdateComplete(); // 0x000000018D232118-0x000000018D23214C
		public bool IsDestroyed(); // 0x000000018D232188-0x000000018D232208
		protected override void OnEnable(); // 0x000000018D2326F4-0x000000018D23277C
		protected override void OnDisable(); // 0x000000018D232454-0x000000018D232494
		protected void Start(); // 0x000000018D232A04-0x000000018D232A3C
		protected override void OnAwake(); // 0x000000018D2322A0-0x000000018D2322F8
		public override void LateTick(float deltaTime); // 0x000000018D232208-0x000000018D23226C
		public void UpdateCount(int newCount, bool setTop = true /* Metadata: 0x02628336 */); // 0x000000018D232A90-0x000000018D232B44
		public void ScrollToIndex(int index, bool direct = false /* Metadata: 0x02628337 */); // 0x000000018D232900-0x000000018D232A04
		public GameObject Get(int index); // 0x000000018D232068-0x000000018D232118
		public void ClearComponent(); // 0x000000018D231FF8-0x000000018D232068
		[CompilerGenerated]
		private void __DoScroll_b__59_0(); // 0x000000018D232A3C-0x000000018D232A54
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class UIScrollContainerFollower : TickableUIMono // TypeDefIndex: 74541
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
		protected override TickType tickOption { get; } // 0x0000000186AF46F0-0x0000000186AF4720 
	
		// Constructors
		public UIScrollContainerFollower(); // 0x0000000186CEF810-0x0000000186CEF830
	
		// Methods
		protected override void OnAwake(); // 0x0000000186CBCD70-0x0000000186CBCE60
		public override void LateTick(float deltaTime); // 0x0000000185AD4EF0-0x0000000185AD5410
		private void _RefreshSizeAndPositionToTargetContainer(); // 0x0000000185AD5410-0x0000000185AD57C0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public enum ScrollDirection // TypeDefIndex: 74542
	{
		Vertical = 0,
		Horizontal = 1
	}

	[ExecuteInEditMode]
	public class UIScrollList : TickableUIMono, IBeginDragHandler, IDragHandler, IEndDragHandler, IUIClearable // TypeDefIndex: 74549
	{
		// Fields
		[FormerlySerializedAs("_cellPrefab")]
		[SerializeField]
		[Tooltip("\u53EF\u4EE5\u662FPrefab\u6216\u8005\u9762\u677F\u4E0A\u7684\u8282\u70B9")]
		protected GameObject _cellTemplate; // 0x68
		[SerializeField]
		private ScrollDirection _scrollDirection; // 0x70
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
		private const string CACHED_CELL_GAME_OBJECT_NAME = "Cached"; // Metadata: 0x02628356
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
		private const float GRADUALLY_SHOW_UPDATE_MAX_INTERVAL = 0.033333335f; // Metadata: 0x0262835D
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
		protected int m_lastSyncNaviIdx; // 0x240
		[NonSerialized]
		private bool m_stickScrolling; // 0x244
		[NonSerialized]
		private bool m_selfRetargeting; // 0x245
		[NonSerialized]
		public UnityEvent<GameObject, int> onSelectedCell; // 0x248
		[NonSerialized]
		public UnityEvent<GameObject, int, bool> onCellSelectedChanged; // 0x250
		[NonSerialized]
		public Func<int> getCurSelectedIndex; // 0x258
		private int m_curSelectedIndex; // 0x260
		private int m_bindingGroupId; // 0x264
		private int m_naviBindingGroupId; // 0x268
		[SerializeField]
		[Tooltip("\u4E00\u884C\u7684\u6700\u540E\u4E00\u4E2A\u5143\u7D20\u662F\u5426\u53EF\u4EE5\u5FAA\u73AF\u5230\u4E0B\u4E00\u884C\u7684\u7B2C\u4E00\u4E2A\u5143\u7D20")]
		protected bool _enableWrapNavigation; // 0x26C
		[SerializeField]
		[Tooltip("\u7981\u7528\u6700\u540E\u4E00\u4E2A\u5143\u7D20\u662F\u5426\u53EF\u4EE5\u5FAA\u73AF\u5230\u7B2C\u4E00\u4E2A\u5143\u7D20")]
		protected bool _disableCircleWrapNavigation; // 0x26D
		[SerializeField]
		[Tooltip("\u6CBF\u5217\u8868\u6EDA\u52A8\u65B9\u5411\u8FDE\u7EED\u8D70\u7126\u5931\u8D25\u65F6\uFF0C\u662F\u5426\u5EF6\u8FDF\u89E6\u53D1 NaviGroup \u7684\u5931\u8D25\u56DE\u8C03\uFF08\u65B0\u6309\u4F4F\u540E\u7684\u9996\u6B21\u957F\u6309\u9664\u5916\uFF09")]
		protected bool _delayDefaultNaviFailedOnRepeat; // 0x26E
		[FormerlySerializedAs("_clearNaviGroupOnUpdate")]
		[SerializeField]
		private bool _clearNaviGroupOnUpdateCount; // 0x26F
		private List<Selectable> m_wrapNaviSelectables; // 0x270
		private LuaPanel m_panel; // 0x278
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186627DA0-0x0000000186627DD0 
		public Vector2 space { get; } // 0x000000018D2372D0-0x000000018D237314 
		public bool autoLayoutWhenFew { get; } // 0x000000018D2370EC-0x000000018D237130 
		public bool isHorizontal { get; } // 0x0000000185694910-0x0000000185694940 
		public bool isVertical { get; } // 0x00000001856948E0-0x0000000185694910 
		public int count { [CompilerGenerated] get; [CompilerGenerated] protected set; } // 0x00000001828A9D40-0x00000001828A9D50 0x00000001828A9D50-0x00000001828A9D60
		public float containerSizeWithoutAutoLayout { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723B5B0-0x000000018723B5C0 0x000000018723B630-0x000000018723B640
		protected virtual bool isMultiPage { get; } // 0x00000001862AE170-0x00000001862AE1A0 
		public int maxShowingCellCount { get; } // 0x000000018D237248-0x000000018D23728C 
		public int countPerLine { get; } // 0x000000018D2371C0-0x000000018D237204 
		public float cellWidth { get; } // 0x000000018D237178-0x000000018D2371C0 
		public float cellHeight { get; } // 0x000000018D237130-0x000000018D237178 
		public virtual float currentStep { get; set; } // 0x0000000185693BA0-0x0000000185693CF0 0x000000018D237314-0x000000018D237384
		private MoveTipsType moveTips { get; } // 0x0000000185693CF0-0x0000000185693F00 
		public int curSelectedIndex { get; protected set; } // 0x0000000186B0B560-0x0000000186B0B5A0 0x0000000186B0B6A0-0x0000000186B0B720
		public GameObject curSelectedObj { get; } // 0x0000000186B0B5A0-0x0000000186B0B5F0 
		public bool enableSelectedNavigation { get; } // 0x000000018D237204-0x000000018D237248 
		public int naviBindingGroupId { get; } // 0x000000018D23728C-0x000000018D2372D0 
		public LuaPanel panel { get; } // 0x0000000185C8FC20-0x0000000185C8FCE0 
	
		// Nested types
		protected enum AutoLayoutWhenFewType // TypeDefIndex: 74543
		{
			Center = 0,
			LeftOrTop = 1,
			RightOrBottom = 2
		}
	
		public class Cell // TypeDefIndex: 74544
		{
			// Fields
			public GameObject gameObject; // 0x10
			public RectTransform rectTransform; // 0x18
			public UIAnimationWrapper animationWrapper; // 0x20
			public IUIFoldoutComp UIFoldoutComp; // 0x28
			public bool canCache; // 0x30
			public GameObject realGameObject; // 0x38
	
			// Constructors
			public Cell(); // 0x00000001829849B0-0x00000001829849C0
		}
	
		private enum MoveTipsType // TypeDefIndex: 74545
		{
			None = 0,
			Higher = 1,
			Lower = 2,
			Both = 3
		}
	
		[Serializable]
		public struct Padding // TypeDefIndex: 74546
		{
			// Fields
			public float top; // 0x00
			public float left; // 0x04
			public float right; // 0x08
			public float bottom; // 0x0C
		}
	
		public enum ScrollAlignType // TypeDefIndex: 74547
		{
			Center = 0,
			Top = 1,
			Bottom = 2,
			TopEdge = 3,
			BottomEdge = 4
		}
	
		public interface IScrollListNaviWrapper // TypeDefIndex: 74548
		{
			// Methods
			bool TryWrapNavigate(NaviDirection dir);
		}
	
		// Constructors
		public UIScrollList(); // 0x000000018503DFE0-0x000000018503E3F0
		static UIScrollList(); // 0x00000001871130D0-0x0000000187113180
	
		// Methods
		protected override void OnAwake(); // 0x0000000186950DF0-0x0000000186950E40
		public override void Tick(float deltaTime); // 0x00000001856F98D0-0x00000001856F9A90
		public override void LateTick(float deltaTime); // 0x0000000185695750-0x00000001856958C0
		protected override void OnEnable(); // 0x0000000185C8E060-0x0000000185C8E130
		protected override void OnDisable(); // 0x0000000185383950-0x0000000185383AB0
		public void TryRecalculateSize(); // 0x0000000185695FE0-0x0000000185696120
		protected virtual void InGameAwake(); // 0x0000000185B2C900-0x0000000185B2CAC0
		private void _EditorAwake(); // 0x000000018D236568-0x000000018D236A2C
		protected virtual void Init(bool isPreview = false /* Metadata: 0x0262833A */); // 0x0000000185BA8E10-0x0000000185BA9060
		protected virtual void InitConfig(); // 0x00000001865D61F0-0x00000001865D64F0
		protected virtual void InitBasicInfo(); // 0x0000000186947A90-0x0000000186947AE0
		protected virtual void SyncViewSize(); // 0x0000000185BAC490-0x0000000185BAC7B0
		protected virtual void CalcSomeCountNum(); // 0x000000018648A1C0-0x000000018648A250
		private int _GetLineCount(bool calcVertical); // 0x000000018648A250-0x000000018648A2E0
		protected virtual void OnScroll(Vector2 v); // 0x0000000185C8E5C0-0x0000000185C8E6D0
		public virtual void SetTop(bool needUpdate = true /* Metadata: 0x0262833B */); // 0x000000018D235574-0x000000018D235638
		[IDTag(1)]
		public virtual void UpdateCount(int newCount, bool setTop, bool forceRecalculate = false /* Metadata: 0x0262833C */, bool onlyUpdateNewCellContent = false /* Metadata: 0x0262833D */, bool skipGraduallyShow = false /* Metadata: 0x0262833E */); // 0x0000000185C8DFF0-0x0000000185C8E060
		[IDTag(0)]
		public virtual void UpdateCount(int newCount, int fastScrollToIndex, bool forceRecalculate = false /* Metadata: 0x0262833F */, bool onlyUpdateNewCellContent = false /* Metadata: 0x02628340 */, bool skipGraduallyShow = false /* Metadata: 0x02628341 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02628342 */); // 0x0000000185C8E130-0x0000000185C8E410
		[IDTag(2)]
		public virtual void UpdateCount(int newCount); // 0x0000000185C8D470-0x0000000185C8D4C0
		[IDTag(1)]
		public void UpdateShowingCells(Action<int, GameObject> updateFunc); // 0x0000000185BA9FD0-0x0000000185BAA170
		protected virtual float GetLeftLength(bool checkVertical, int checkCount = -1 /* Metadata: 0x02628343 */); // 0x0000000185BA95A0-0x0000000185BA9630
		private void _SetRealPadding(bool isVerticalPadding, float firstAddedLength, float secondAddedLength); // 0x0000000185BA92B0-0x0000000185BA9320
		protected virtual void UpdateContainerSize(); // 0x0000000185BA9060-0x0000000185BA92B0
		protected virtual float GetContainerSize(bool ignoreAutoLayout = false /* Metadata: 0x02628344 */); // 0x0000000185BA9480-0x0000000185BA95A0
		protected void SetContainerSize(float size); // 0x0000000185BA9320-0x0000000185BA9480
		protected virtual void ClearShowingCells(); // 0x00000001855AF930-0x00000001855AFBC0
		[IDTag(0)]
		protected virtual void UpdateShowingCells(bool forceUpdateContent, bool forceClearShowingCells = false /* Metadata: 0x02628345 */, bool ignoreListActive = false /* Metadata: 0x02628346 */); // 0x0000000185693970-0x0000000185693BA0
		protected virtual void CacheOutOfRangeCells(Vector2Int showRange, Vector2Int notCacheRange); // 0x0000000185692970-0x0000000185692DC0
		protected virtual void ProcessCellAtIndex(int index, bool forceUpdateContent, bool ignoreListActive); // 0x0000000185694160-0x00000001856941A0
		protected virtual void RepositionOutOfRangeCells(Vector2Int showRange); // 0x0000000185BAAA70-0x0000000185BAAC80
		protected void UpdateCell(int index, bool forceUpdateContent, bool ignoreListActive); // 0x00000001856941A0-0x0000000185694560
		public virtual Vector2Int GetShowRange(float bufferSize = 0f /* Metadata: 0x02628347 */, bool ignoreGraduallyShow = false /* Metadata: 0x0262834B */); // 0x0000000185693F00-0x0000000185694160
		protected virtual Vector2Int GetIndexRangeFromScrollOffset(float scrollOffset, float viewSize, float bufferSize); // 0x0000000185694560-0x0000000185694760
		public virtual Vector2Int GetRangeInView(); // 0x000000018D23465C-0x000000018D234B08
		protected virtual Vector2Int GetNotCacheRange(); // 0x0000000186553B60-0x0000000186553BC0
		protected virtual void MoveCellTo(Cell cell, int index); // 0x0000000185694760-0x00000001856948E0
		public void SetCellCanCache(int index, bool canCache); // 0x000000018D235084-0x000000018D2351BC
		protected virtual void OnUpdateCell(Cell cell, int index); // 0x000000018566EDD0-0x000000018566EE80
		[IDTag(0)]
		protected Cell GetCell(); // 0x00000001851BD8E0-0x00000001851BDC90
		protected void CacheShowingCell(int index); // 0x000000018D233F40-0x000000018D234020
		protected void CacheCell(Cell cell); // 0x00000001855AFBC0-0x00000001855AFC50
		public virtual void SetStepTo(float step); // 0x000000018D23533C-0x000000018D235574
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x0000000186C1DB40-0x0000000186C1DB80
		public virtual void OnDrag(PointerEventData eventData); // 0x0000000185F2CAD0-0x0000000185F2CB50
		public virtual void OnEndDrag(PointerEventData eventData); // 0x0000000186B29E90-0x0000000186B29ED0
		protected void UpdateMoveTips(); // 0x0000000185C8E760-0x0000000185C8E8A0
		public void UpdateViewEffect(); // 0x0000000185C8ED50-0x0000000185C8F6F0
		public GameObject Get(int index); // 0x0000000185C8F850-0x0000000185C8F8E0
		[IDTag(1)]
		protected Cell GetCell(int index); // 0x0000000186B0B5F0-0x0000000186B0B6A0
		protected int GetRealIndex(int index); // 0x0000000185C8F8E0-0x0000000185C8F910
		protected override void OnRelease(); // 0x0000000185383850-0x0000000185383950
		public virtual void ClearComponent(); // 0x0000000185B2AFD0-0x0000000185B2B150
		public void SetPaddingBottom(float value); // 0x000000018D2351BC-0x000000018D23521C
		public void SetPaddingTop(float value); // 0x000000018D2352DC-0x000000018D23533C
		public void SetPaddingRight(float value); // 0x000000018D23527C-0x000000018D2352DC
		public void SetPaddingLeft(float value); // 0x000000018D23521C-0x000000018D23527C
		public void SetPadding(Rect value); // 0x0000000186AC7E80-0x0000000186AC7F40
		public Padding GetPadding(bool isRealPadding = false /* Metadata: 0x0262834C */); // 0x0000000186B415A0-0x0000000186B415F0
		public void GetShowingCellsIndexRange(out int firstIndex, out int lastIndex); // 0x000000018D234B08-0x000000018D234C48
		public void SetSpace(Vector2 newSpace); // 0x0000000186CCF2F0-0x0000000186CCF380
		public virtual void ScrollToIndex(int index, bool fastMode = false /* Metadata: 0x0262834D */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x0262834E */, bool graduallyShowInFastMode = false /* Metadata: 0x0262834F */); // 0x0000000185C8FCE0-0x0000000185C8FDB0
		protected virtual void ScrollTo(int index, bool fastMode = false /* Metadata: 0x02628350 */, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02628351 */); // 0x0000000185383AB0-0x0000000185383B10
		private void _ScrollToPos(float targetPos, bool fastMode); // 0x0000000185383B10-0x0000000185383DB0
		protected void TryClearAdjustTween(); // 0x0000000185383DB0-0x0000000185383E10
		public virtual float GetCenterIndex(); // 0x00000001862F1480-0x00000001862F1720
		protected virtual float GetTargetPosByIndex(int index, ScrollAlignType alignType = ScrollAlignType.Center /* Metadata: 0x02628352 */); // 0x0000000185383E10-0x0000000185384090
		private void _InitAutoScroll(); // 0x0000000185B2CC00-0x0000000185B2CDB0
		private void _OnEnterAutoScrollUp(PointerEventData eventData); // 0x000000018D236D64-0x000000018D236E90
		private void _OnExitAutoScrollUp(PointerEventData eventData); // 0x000000018D236F40-0x000000018D236FF0
		private void _OnEnterAutoScrollDown(PointerEventData eventData); // 0x000000018D236C38-0x000000018D236D64
		private void _OnExitAutoScrollDown(PointerEventData eventData); // 0x000000018D236E90-0x000000018D236F40
		private void _SetAutoScrollSpd(float spd); // 0x000000018D2370A8-0x000000018D2370EC
		private void _UpdateAutoScroll(float deltaTime); // 0x0000000186197BB0-0x0000000186197C10
		protected void RestartGraduallyShow(); // 0x0000000185C8D380-0x0000000185C8D400
		protected void StartGraduallyShow(); // 0x0000000185C8F910-0x0000000185C8FA30
		private void _UpdateGraduallyShow(float deltaTime); // 0x0000000185C8E410-0x0000000185C8E560
		public void SkipGraduallyShow(); // 0x0000000185C8FDB0-0x0000000185C8FDF0
		public void StopGraduallyShow(); // 0x0000000185C8FA30-0x0000000185C8FC20
		private void _InitNavigation(); // 0x0000000185B2CDB0-0x0000000185B2D190
		public void NavigateSelected(NaviDirection dir); // 0x000000018D234DCC-0x000000018D234E5C
		public int GetNaviOffset(NaviDirection dir); // 0x000000018D2344FC-0x000000018D23465C
		public int GetNaviNewIndex(int oldIndex, NaviDirection dir); // 0x000000018D234468-0x000000018D2344FC
		public void SetSelectedIndex(int index, bool needNotify = true /* Metadata: 0x02628353 */, bool forceUpdate = false /* Metadata: 0x02628354 */, bool needScroll = false /* Metadata: 0x02628355 */); // 0x0000000186B0B3E0-0x0000000186B0B560
		public virtual void ListWrapNavigate(NaviDirection dir); // 0x000000018D234C48-0x000000018D234DCC
		protected virtual bool TryResolveWrapDirection(NaviDirection dir, out bool isBefore); // 0x000000018D236140-0x000000018D23624C
		protected bool TryGetCurrentFocusedCell(out int currentIndex, out Cell currentCell); // 0x000000018D235638-0x000000018D235924
		protected bool TryNavigateInsideCell(Cell cell, NaviDirection dir); // 0x000000018D235F2C-0x000000018D236028
		protected virtual bool TryGetWrapTargetIndex(NaviDirection dir, int currentIndex, bool isBefore, out int targetIndex); // 0x000000018D235C3C-0x000000018D235CA4
		private bool _IsScrollDirection(NaviDirection dir); // 0x0000000184E54D90-0x0000000184E54E80
		protected virtual bool TryHandleCircleNavigationInScrollDirection(NaviDirection dir, int currentIndex, bool isBefore); // 0x000000018D235CA4-0x000000018D235DF8
		protected bool TrySetNaviTargetByIndex(int index, bool isBefore); // 0x000000018D23624C-0x000000018D2363F8
		protected bool TryGetSelectableFromCell(Cell cell, bool isBefore, out Selectable selectable); // 0x000000018D235924-0x000000018D235C3C
		private bool _IsValidWrapNaviTarget(Selectable selectable); // 0x0000000184E54E80-0x0000000184E55460
		protected bool TryNormalizeFirstWrapIndex(ref int nextIndex, bool isBefore); // 0x000000018D236028-0x000000018D236140
		protected bool TryNavigateBySequentialIndex(int startIndex, bool isBefore); // 0x000000018D235DF8-0x000000018D235F2C
		public int GetNaviManagerTargetIndex(); // 0x000000018D234178-0x000000018D234468
		private void _InitSyncNaviTargetOnStickScroll(); // 0x0000000185B2CAC0-0x0000000185B2CC00
		private void _OnNaviTargetChangedForSync(Selectable target); // 0x000000018D236FF0-0x000000018D2370A8
		private void _SyncNaviTargetOnStickScroll(); // 0x0000000185C8E8A0-0x0000000185C8ED50
		private void _InitControllerNavi(); // 0x0000000185B2D190-0x0000000185B2DEE0
		private void _ClearRelatedNaviGroup(); // 0x000000018D2364AC-0x000000018D236568
		public int GetMousePosIndex(NaviDirection dir); // 0x000000018D2340A4-0x000000018D234178
		public int ScreenPos2Index(Vector2 targetScreenPos, NaviDirection dir); // 0x000000018D234E5C-0x000000018D235084
		private void _GetScreenPosLineColumnInfo(Vector2 targetScreenPos, out int line, out int column); // 0x000000018D236A2C-0x000000018D236C38
		public int GetIndexOf(int column, int line); // 0x000000018D234020-0x000000018D2340A4
		[CompilerGenerated]
		private float __ScrollToPos_b__162_0(); // 0x0000000186DFC7D0-0x0000000186DFC800
		[CompilerGenerated]
		private void __ScrollToPos_b__162_1(float x); // 0x00000001853856A0-0x00000001853856D0
		[CompilerGenerated]
		private void __ScrollToPos_b__162_2(); // 0x0000000185CE0FC0-0x0000000185CE1000
		[CompilerGenerated]
		private float __ScrollToPos_b__162_3(); // 0x000000018D236460-0x000000018D236484
		[CompilerGenerated]
		private void __ScrollToPos_b__162_4(float y); // 0x000000018D236484-0x000000018D2364AC
		[CompilerGenerated]
		private void __ScrollToPos_b__162_5(); // 0x0000000185CE0FC0-0x0000000185CE1000
		[CompilerGenerated]
		private void __OnEnterAutoScrollUp_b__175_0(); // 0x000000018D236448-0x000000018D236460
		[CompilerGenerated]
		private void __OnEnterAutoScrollDown_b__177_0(); // 0x000000018D236438-0x000000018D236448
		[CompilerGenerated]
		private void __InitNavigation_b__219_0(); // 0x000000018D2363F8-0x000000018D236408
		[CompilerGenerated]
		private void __InitNavigation_b__219_1(); // 0x000000018D236408-0x000000018D236418
		[CompilerGenerated]
		private void __InitNavigation_b__219_2(); // 0x000000018D236418-0x000000018D236428
		[CompilerGenerated]
		private void __InitNavigation_b__219_3(); // 0x000000018D236428-0x000000018D236438
		[CompilerGenerated]
		private void __InitNavigation_b__219_4(); // 0x000000018D236418-0x000000018D236428
		[CompilerGenerated]
		private void __InitNavigation_b__219_5(); // 0x000000018D236428-0x000000018D236438
		[CompilerGenerated]
		private void __InitNavigation_b__219_6(); // 0x000000018D2363F8-0x000000018D236408
		[CompilerGenerated]
		private void __InitNavigation_b__219_7(); // 0x000000018D236408-0x000000018D236418
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	public enum AutoScrollStrategy // TypeDefIndex: 74550
	{
		None = 0,
		AlignNearbyBound = 1,
		AlignCenter = 2
	}

	[AddComponentMenu("UI/UI Scroll Rect", 37)]
	public class UIScrollRect : ScrollRect, IUIClearable // TypeDefIndex: 74553
	{
		// Fields
		private TweenerCore<Vector2, Vector2, VectorOptions> m_scrollTween; // 0x150
		private const float SCROLL_CATCH_UP_PROGRESS = 0.8f; // Metadata: 0x02628374
		private const float MAX_SCROLL_SPEED_MULTIPLIER = 8f; // Metadata: 0x02628378
		private const float SCROLL_CONTINUATION_GAP = 0.5f; // Metadata: 0x0262837C
		private const float SCROLL_LOOK_AHEAD_TIME = 0.1f; // Metadata: 0x02628380
		private float m_scrollSpeedMultiplier; // 0x158
		private Vector2 m_lastScrollDirection; // 0x15C
		private float m_lastScrollRequestTime; // 0x164
		public float smoothScrollTweenSpd; // 0x168
		public Ease smoothScrollTweenEase; // 0x16C
		public float smoothScrollTweenMaxDur; // 0x170
		private static readonly Vector3[] s_clipCorners; // 0x00
		private const float CLIP_AMOUNT_EPSILON = 0.01f; // Metadata: 0x02628384
		private bool m_lastUpdateIsDragging; // 0x174
		private LuaPanel m_panel; // 0x178
		[SerializeField]
		protected bool _useLeftStick; // 0x180
		[SerializeField]
		protected float _stickScrollSpeed; // 0x184
		[SerializeField]
		protected float _stickScrollTolerance; // 0x188
		[SerializeField]
		protected UISelectableNaviGroup _naviGroup; // 0x190
		[SerializeField]
		protected bool _enableWrapNavigation; // 0x198
		[SerializeField]
		protected InputBindingGroupMonoTarget _scrollBindingGroup; // 0x1A0
		[SerializeField]
		[Tooltip("\u5F00\u542F\u540E\uFF1A\u624B\u52A8\u63A7\u5236\u6447\u6746\u6EDA\u52A8\u65F6\u81EA\u52A8\u628A navi \u7126\u70B9\u8DDF\u968F\u5230\u771F\u6B63\u5728\u53EF\u89C6\u533A\u5185\u7684 cell\uFF08\u9700\u642D\u914D UIScrollList)")]
		public bool _syncNaviTargetOnStickScroll; // 0x1A8
		[NonSerialized]
		public bool controllerScrollEnabled; // 0x1A9
		private bool m_controllerInited; // 0x1AA
		private bool m_navigationWrapped; // 0x1AB
		[SerializeField]
		protected AutoScrollStrategy _autoScrollStrategy; // 0x1AC
		[SerializeField]
		protected float _alignBoundPaddingX; // 0x1B0
		[SerializeField]
		protected float _alignBoundPaddingY; // 0x1B4
		[SerializeField]
		[Space]
		private GameObject _moveTipsLeftOrTop; // 0x1B8
		[SerializeField]
		private GameObject _moveTipsRightOrBottom; // 0x1C0
		private Camera m_fallbackUICamera; // 0x1C8
		[Header("Over Scroll Effect")]
		[SerializeField]
		private bool _enableOverScrollEffect; // 0x1D0
		[SerializeField]
		[Tooltip("\u5217\u8868\u957F\u5EA6\u7684\u767E\u5206\u6BD4")]
		private float _overScrollTriggerValue; // 0x1D4
		[SerializeField]
		private GameObject _overScrollEffectPrevNode; // 0x1D8
		[SerializeField]
		private GameObject _overScrollEffectNextNode; // 0x1E0
		[NonSerialized]
		public DisposedUnityEvent<bool> onOverScrollEffect; // 0x1E8
	
		// Properties
		public bool inScrollTween { get; } // 0x00000001871EC5C0-0x00000001871EC5F0 
		public Vector2 contentStartPosition { get; set; } // 0x000000018D237F28-0x000000018D237F70 0x000000018D238198-0x000000018D2381D4
		public bool dragging { get; } // 0x000000018D238020-0x000000018D238064 
		public bool controllerStickScrollEnabled { get; } // 0x000000018D237F70-0x000000018D238020 
		public bool IsStickScrolling { get; } // 0x0000000185C8E6D0-0x0000000185C8E760 
		public LuaPanel panel { get; } // 0x0000000185E58280-0x0000000185E58340 
		public UISelectableNaviGroup naviGroup { get; } // 0x0000000187184BB0-0x0000000187184BE0 
		private MoveTipsType moveTips { get; } // 0x000000018D238064-0x000000018D238198 
	
		// Nested types
		private enum MoveTipsType // TypeDefIndex: 74551
		{
			None = 0,
			Higher = 1,
			Lower = 2,
			Both = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0 // TypeDefIndex: 74552
		{
			// Fields
			public Vector2 contentPos; // 0x10
			public UIScrollRect __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass28_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal Vector2 __ScrollToPosition_b__0(); // 0x0000000184E54D30-0x0000000184E54D50
			internal void __ScrollToPosition_b__1(Vector2 pos); // 0x0000000184E54D50-0x0000000184E54D90
		}
	
		// Constructors
		public UIScrollRect(); // 0x00000001854912B0-0x0000000185491380
		static UIScrollRect(); // 0x00000001871D7A00-0x00000001871D7A70
	
		// Methods
		protected override void Awake(); // 0x0000000185B2C810-0x0000000185B2C900
		protected override void OnEnable(); // 0x000000018531EA50-0x000000018531EA90
		private void Update(); // 0x0000000185E3D4C0-0x0000000185E3D520
		public void ScrollTo(Vector2 position, bool noTween = false /* Metadata: 0x02628370 */, bool enableAcceleration = true /* Metadata: 0x02628371 */); // 0x0000000184E56520-0x0000000184E56670
		public void KillScrollTween(); // 0x0000000185384090-0x00000001853840D0
		public bool IsCellViewed(RectTransform cell); // 0x000000018D237B64-0x000000018D237C54
		public float GetCellClipAmount(RectTransform cell); // 0x000000018D237880-0x000000018D237B64
		public void ClampContentToBounds(); // 0x000000018D237754-0x000000018D237880
		protected override void OnDestroy(); // 0x0000000186954350-0x00000001869543B0
		protected override void _CustomSetPosOnScroll(Vector2 position); // 0x0000000185C89D30-0x0000000185C89D80
		private void _ScrollToPosition(Vector2 position, bool enableAcceleration); // 0x0000000184E56670-0x0000000184E58460
		protected override void UpdateScrollEnableNode(); // 0x0000000185FBDF90-0x0000000185FBE0A0
		public override void OnBeginDrag(PointerEventData eventData); // 0x0000000186C1DBB0-0x0000000186C1DC20
		public override void OnDrag(PointerEventData eventData); // 0x0000000185F2E180-0x0000000185F2E1F0
		public override void OnEndDrag(PointerEventData eventData); // 0x0000000186B2BF10-0x0000000186B2BF90
		public void ClearComponent(); // 0x00000001850447C0-0x0000000185044860
		protected override void LateUpdate(); // 0x0000000185E57EA0-0x0000000185E58030
		private void _TickRefreshControllerStickScroll(); // 0x0000000185E3D520-0x0000000185E3D570
		public void ScrollToNaviTarget(Selectable target); // 0x0000000186848F80-0x00000001868490B0
		public void RectWrapNavigate(NaviDirection dir); // 0x000000018D237C54-0x000000018D237EF0
		private void _InitController(); // 0x000000018531ED80-0x000000018531EF90
		public void WrapNavigation(UnityAction<NaviDirection> wrapper); // 0x0000000185B2DEE0-0x0000000185B2E070
		public void AutoScrollToRectTransform(RectTransform target, bool noTween = false /* Metadata: 0x02628372 */, bool enableAcceleration = true /* Metadata: 0x02628373 */); // 0x0000000184E55460-0x0000000184E56520
		private void _UpdateMoveTips(); // 0x0000000185E3D570-0x0000000185E3D680
		private Camera _GetUICamera(); // 0x0000000185E58180-0x0000000185E58280
		private void _CheckOverScrollEffect(Vector2 value); // 0x00000001863D6D40-0x00000001863D6D80
		private void _CheckOverScrollOnEndDrag(Vector2 value); // 0x0000000186B2BFC0-0x0000000186B2C030
		public void __iFixBaseProxy_Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D237F08-0x000000018D237F10
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy__CustomSetPosOnScroll(Vector2 P0); // 0x000000018D237F20-0x000000018D237F28
		public void __iFixBaseProxy_UpdateScrollEnableNode(); // 0x000000018D237F18-0x000000018D237F20
		public void __iFixBaseProxy_OnBeginDrag(PointerEventData P0); // 0x000000018D237EF8-0x000000018D237F00
		public void __iFixBaseProxy_OnDrag(PointerEventData P0); // 0x000000018D237F00-0x000000018D237F08
		public void __iFixBaseProxy_OnEndDrag(PointerEventData P0); // 0x000000018D237F10-0x000000018D237F18
		public void __iFixBaseProxy_LateUpdate(); // 0x000000018D237EF0-0x000000018D237EF8
	}

	public class UIScrollRectEdgeRedDot : TickableUIMono, IUIClearable // TypeDefIndex: 74557
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
		protected override TickType tickOption { get; } // 0x00000001869B60E0-0x00000001869B6110 
	
		// Nested types
		public enum ERedDotState // TypeDefIndex: 74554
		{
			DISABLED = 0,
			NEW = 1,
			NORMAL = 2
		}
	
		public enum ERedDotDir // TypeDefIndex: 74555
		{
			UP = 0,
			RIGHT = 1,
			DOWN = 2,
			LEFT = 3
		}
	
		public class RedDotInfo // TypeDefIndex: 74556
		{
			// Fields
			public readonly GameObject redDotRoot; // 0x10
			public readonly GameObject redDotNormal; // 0x18
			public readonly GameObject redDotNew; // 0x20
	
			// Properties
			public ERedDotState state { get; } // 0x0000000185694C00-0x0000000185694DD0 
			public Vector2 normalPos { get; } // 0x0000000185AD4620-0x0000000185AD4770 
			public Vector2 newPos { get; } // 0x0000000185695020-0x0000000185695160 
			public Rect normalRect { get; } // 0x00000001862FF4F0-0x00000001862FF640 
			public Rect newRect { get; } // 0x0000000185695E50-0x0000000185695FB0 
	
			// Constructors
			public RedDotInfo(GameObject redDotRoot, GameObject redDotNormal, GameObject redDotNew); // 0x0000000186537130-0x0000000186537170
		}
	
		// Constructors
		public UIScrollRectEdgeRedDot(); // 0x0000000186CA86A0-0x0000000186CA86D0
	
		// Methods
		protected override void OnAwake(); // 0x000000018693BAA0-0x000000018693BAE0
		protected override void OnEnable(); // 0x0000000185B2FD30-0x0000000185B2FF40
		protected override void OnRelease(); // 0x0000000185B30260-0x0000000185B303E0
		public override void Tick(float deltaTime); // 0x0000000185B303E0-0x0000000185B30650
		public void ResetReferences(); // 0x000000018693BAE0-0x000000018693BDA0
		public void ResetRedDotPosition(); // 0x000000018D237384-0x000000018D237754
		private void _UpdateCacheDictForRangeChange(Vector2Int newRange); // 0x0000000185B30710-0x0000000185B308F0
		private void _OnScrollListUpdateCount(int newCount); // 0x0000000185BAD1A0-0x0000000185BAD230
		public void RegisterRedDot(GameObject redDotRoot, GameObject redDotNormal, GameObject redDotNew); // 0x0000000186536F50-0x0000000186537130
		public void UnregisterRedDot(GameObject redDotRoot); // 0x00000001866B1110-0x00000001866B11F0
		public void RegisterRedDotStatesForScrollList(); // 0x0000000185BAD230-0x0000000185BAD430
		public void UpdateRedDotStateInDir(); // 0x0000000185B30650-0x0000000185B30710
		private void _CalculateRedDotStateInDir(out ERedDotState upState, out ERedDotState downState); // 0x0000000185695160-0x0000000185695750
		private void _UpdateRedDotGameObjects(GameObject normal, GameObject newer, ERedDotState state); // 0x0000000185B2FF40-0x0000000185B30260
		public bool IsRedDotInDir(ERedDotState state, ERedDotDir dir, RedDotInfo redDotInfo); // 0x00000001856958C0-0x0000000185695E50
		public void ClearComponent(); // 0x0000000186D35830-0x0000000186D35870
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	[RequireComponent(typeof(UIText))]
	public class UIScrollText : TickableUIMono // TypeDefIndex: 74565
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
		protected override TickType tickOption { get; } // 0x0000000186B14240-0x0000000186B14270 
	
		// Nested types
		private enum ScrollMode // TypeDefIndex: 74558
		{
			Mesh = 0,
			AnchoredPosition = 1
		}
	
		private enum ScrollState // TypeDefIndex: 74559
		{
			Scrolling = 0,
			Idle = 1,
			FadingOut = 2,
			FadingIn = 3
		}
	
		private interface IAlphaHandler // TypeDefIndex: 74560
		{
			// Methods
			void HandleAlpha(float alpha);
		}
	
		private class CanvasGroupHandler : IAlphaHandler // TypeDefIndex: 74561
		{
			// Fields
			private CanvasGroup m_canvasGroup; // 0x10
	
			// Constructors
			public CanvasGroupHandler(CanvasGroup canvasGroup); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			public void HandleAlpha(float alpha); // 0x000000018D238424-0x000000018D23847C
		}
	
		private interface IScrollHandler // TypeDefIndex: 74562
		{
			// Methods
			void ApplyScroll(float scrollOffset);
			void ResetScroll();
			void UpdateScrollStatus(bool isScroll);
		}
	
		private class PositionScrollHandler : Beyond.UI.UIScrollText.IScrollHandler // TypeDefIndex: 74563
		{
			// Fields
			private UIScrollText m_closure; // 0x10
	
			// Constructors
			public PositionScrollHandler(UIScrollText scrollText); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			public void ApplyScroll(float scrollOffset); // 0x000000018D23847C-0x000000018D238524
			public void ResetScroll(); // 0x000000018D238524-0x000000018D238594
			public void UpdateScrollStatus(bool isScroll); // 0x000000018D238594-0x000000018D23866C
		}
	
		private class MeshScrollHandler : Beyond.UI.UIScrollText.IScrollHandler // TypeDefIndex: 74564
		{
			// Fields
			private UIScrollText m_closure; // 0x10
	
			// Constructors
			public MeshScrollHandler(UIScrollText uiScrollText); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			public void ApplyScroll(float scrollOffset); // 0x00000001864B8690-0x00000001864B86C0
			public void ResetScroll(); // 0x00000001864B8660-0x00000001864B8690
			public void UpdateScrollStatus(bool isScroll); // 0x00000001864B8560-0x00000001864B85C0
			private void _ApplyScroll(float scrollOffset); // 0x00000001864B86C0-0x00000001864B8A50
			private void _UpdateMeshClipping(TMP_TextInfo textInfo); // 0x000000018576C940-0x000000018576D290
		}
	
		// Constructors
		public UIScrollText(); // 0x0000000187184B80-0x0000000187184BB0
	
		// Methods
		private void _InitIfNot(); // 0x0000000186B0A1A0-0x0000000186B0A400
		public void ResetTextScroll(); // 0x00000001864B8350-0x00000001864B8480
		public void ResetToStatic(); // 0x000000018D238C60-0x000000018D238CBC
		public float GetSingleScrollDuration(); // 0x0000000186B0A070-0x0000000186B0A1A0
		private void _ResetTextScrollInternal(bool needScroll, float textDiff); // 0x00000001864B8480-0x00000001864B8500
		protected override void OnAwake(); // 0x0000000186B0A030-0x0000000186B0A070
		public override void LateTick(float deltaTime); // 0x000000018D238A30-0x000000018D238C60
		private void _UpdateScrollState(float deltaTime, float textDiff); // 0x000000018D238D50-0x000000018D239058
		private void _ResetTextScroll(); // 0x00000001864B85F0-0x00000001864B8660
		private void _ApplyTextAlignment(bool isScroll); // 0x00000001864B8500-0x00000001864B8560
		private void _ApplyTextScroll(float scrollOffset); // 0x000000018D238CBC-0x000000018D238D50
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	public class UISelectableNaviGroup : SelectableNaviGroup, IUIClearable // TypeDefIndex: 74567
	{
		// Fields
		public List<InputBindingGroupMonoTarget> relatedInputBindingGroups; // 0xB0
		public Func<Selectable> getDefaultSelectableFunc; // 0xB8
		public Func<bool> canFocusFun; // 0xC0
		public string focusActionId; // 0xC8
		public string stopFocusActionId; // 0xD0
		[Space]
		[Tooltip("\u8BED\u6CD5\u7CD6\uFF1A\u9000\u51FA\u805A\u7126\u65F6\u9690\u85CFItemTips")]
		public bool hideItemTipsOnUnFocus; // 0xD8
		public bool useDefaultTargetOnFocus; // 0xD9
		[Space]
		public bool useFocusHighlight; // 0xDA
		public bool focusHighlightMask; // 0xDB
		public bool focusHighlightNormalFrame; // 0xDC
		public bool focusHighlightDarkFrame; // 0xDD
		public RectTransform focusOverrideHighlightRect; // 0xE0
		[NonSerialized]
		public int focusPanelSortingOrder; // 0xE8
		public UIActionKeyHint focusActionKeyHint; // 0xF0
		public UIActionKeyHint stopFocusActionKeyHint; // 0xF8
		public UnityEvent<bool> onIsFocusedChange; // 0x100
		private LuaPanel m_luaPanel; // 0x108
		private InputBindingGroupMonoTarget m_bindingMonoGroup; // 0x110
		private RectTransform m_rectTransform; // 0x118
		private Selectable m_lastFocusNaviTarget; // 0x120
		private string m_focusBindingText; // 0x128
		private int m_focusBindingId; // 0x130
		private int m_stopFocusBindingId; // 0x134
		private bool m_focusBindingCreated; // 0x138
		private bool m_isInFocusHighlight; // 0x139
		private const int INVALID_BINDING_ID = -1; // Metadata: 0x0262839C
	
		// Properties
		public int FocusBindingId { get; } // 0x000000018D239750-0x000000018D239794 
		public int StopFocusBindingId { get; } // 0x000000018D239794-0x000000018D2397D8 
		public Selectable lastFocusNaviTarget { get; } // 0x000000018D2397D8-0x000000018D23981C 
	
		// Nested types
		public struct FocusBlockMessageData // TypeDefIndex: 74566
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
		public UISelectableNaviGroup(); // 0x00000001854900D0-0x0000000185490190
	
		// Methods
		private void Awake(); // 0x000000018531FFA0-0x0000000185320130
		protected override void OnEnable(); // 0x000000018503FED0-0x000000018503FF30
		protected override void OnDisable(); // 0x00000001866720A0-0x00000001866720F0
		protected override void _OnIsTopLayerChanged(); // 0x0000000185044860-0x00000001850448B0
		protected override void _OnSelectableNaviGroupDisabled(); // 0x0000000186576060-0x00000001865760A0
		protected override void _BeforeSelectableNaviGroupDestroy(); // 0x00000001865760A0-0x00000001865760D0
		protected override void _OnSetLayerSelectedTarget(Selectable value); // 0x000000018D239608-0x000000018D239650
		protected override void _OnRemoveFromLayerStack(); // 0x0000000185042840-0x0000000185042890
		public void NaviToThisGroup(bool forceDefault = false /* Metadata: 0x02628399 */); // 0x0000000185C32270-0x0000000185C32460
		private void _RefreshRelatedBindingGroupsState(); // 0x0000000185040140-0x00000001850402B0
		public override int GetOwnerPanelId(); // 0x0000000184E58460-0x0000000184E58B60
		private Selectable _FindDefaultSelectable(); // 0x0000000185C32460-0x0000000185C328A0
		protected override void OnDestroy(); // 0x00000001864D97E0-0x00000001864D9830
		public void ClearComponent(); // 0x00000001850443C0-0x0000000185044510
		public void TryChangeNaviPartnerOnUp(UISelectableNaviGroup partner, bool isAdd); // 0x000000018D2392A8-0x000000018D239304
		public void TryChangeNaviPartnerOnDown(UISelectableNaviGroup partner, bool isAdd); // 0x000000018D239194-0x000000018D2391F0
		public void TryChangeNaviPartnerOnLeft(UISelectableNaviGroup partner, bool isAdd); // 0x000000018D2391F0-0x000000018D23924C
		public void TryChangeNaviPartnerOnRight(UISelectableNaviGroup partner, bool isAdd); // 0x000000018D23924C-0x000000018D2392A8
		private void _TryChangeNaviPartner(List<SelectableNaviGroup> list, UISelectableNaviGroup partner, bool isAdd); // 0x000000018D239650-0x000000018D239750
		private void _InitFocusBinding(); // 0x000000018531FCF0-0x000000018531FFA0
		private void _RefreshFocusBindings(); // 0x0000000185042E70-0x0000000185042F70
		public void RefreshFocusBindings(); // 0x000000018D239098-0x000000018D2390D0
		private void _OnFocus(bool onlyStartHighlight); // 0x000000018D23931C-0x000000018D239608
		private void _OnStopFocus(bool onlyStopHighlight, bool ignoreTopLayerCheck); // 0x0000000185042B10-0x0000000185042BC0
		private void _RefreshFocusActionKeyHint(); // 0x0000000185040080-0x0000000185040140
		private void _RefreshStopFocusActionKeyHint(); // 0x000000018503FF60-0x000000018503FFC0
		public void ManuallyFocus(bool onlyStartHighlight = false /* Metadata: 0x0262839A */); // 0x000000018D239058-0x000000018D239098
		public void ManuallyStopFocus(bool onlyStopHighlight = false /* Metadata: 0x0262839B */); // 0x00000001865760D0-0x0000000186576100
		public void SetFocusBindingText(string bindingText); // 0x000000018D2390D0-0x000000018D239194
		public void ClearLastFocusNaviTarget(); // 0x0000000186CB9610-0x0000000186CB9650
		public void ManuallyRefreshRelatedBindingGroups(); // 0x0000000186B54860-0x0000000186B54890
		[CompilerGenerated]
		private void __InitFocusBinding_b__52_0(); // 0x0000000184E58B70-0x0000000184E58B80
		[CompilerGenerated]
		private void __InitFocusBinding_b__52_1(); // 0x0000000184E58B80-0x0000000184E58DF0
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D23930C-0x000000018D239314
		public void __iFixBaseProxy_OnDisable(); // 0x000000018783C598-0x000000018783C5A8
		public void __iFixBaseProxy__OnIsTopLayerChanged(); // 0x000000018D239314-0x000000018D23931C
		public void __iFixBaseProxy__OnSelectableNaviGroupDisabled(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy__BeforeSelectableNaviGroupDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy__OnSetLayerSelectedTarget(Selectable P0); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy__OnRemoveFromLayerStack(); // 0x0000000186805BA0-0x0000000186805BB0
		public int __iFixBaseProxy_GetOwnerPanelId(); // 0x0000000184E58B60-0x0000000184E58B70
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D239304-0x000000018D23930C
	}

	[ExecuteInEditMode]
	public class UISemiCircleScrollList : TickableUIMono, IDragHandler, IUIClearable, IBeginDragHandler, IEndDragHandler // TypeDefIndex: 74569
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
		protected override TickType tickOption { get; } // 0x0000000186E07F90-0x0000000186E07FC0 
		public bool controllerStickScrollEnabled { get; } // 0x000000018D239CF4-0x000000018D239D98 
	
		// Nested types
		[CompilerGenerated]
		private sealed class __ApplyDamping_d__46 : IEnumerator<object> // TypeDefIndex: 74568
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UISemiCircleScrollList __4__this; // 0x20
			private float _targetOffset_5__2; // 0x28
			private float _elapsed_5__3; // 0x2C
			private float _initialOffset_5__4; // 0x30
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ApplyDamping_d__46(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D2386AC-0x000000018D2389E4
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D2389E4-0x000000018D238A30
		}
	
		// Constructors
		public UISemiCircleScrollList(); // 0x0000000186CEE280-0x0000000186CEE3F0
	
		// Methods
		protected override void OnAwake(); // 0x000000018663B260-0x000000018663B2F0
		protected override void OnDisable(); // 0x00000001871CAFB0-0x00000001871CB000
		public override void Tick(float deltaTime); // 0x0000000186ADFBB0-0x0000000186ADFBF0
		private void _TickRefreshControllerStickScroll(); // 0x0000000186ADFBF0-0x0000000186ADFD00
		private void _InitializeCells(); // 0x0000000185273A50-0x0000000185273B70
		public void RefreshLayout(int newCellCount, int targetCellIndex); // 0x000000018663B500-0x000000018663B560
		public void UpdateLayout(); // 0x000000018663B560-0x000000018663BAF0
		public void OnDrag(PointerEventData eventData); // 0x000000018D239A54-0x000000018D239B80
		public void ClearComponent(); // 0x000000018663B2F0-0x000000018663B450
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018D2399E4-0x000000018D239A54
		public void OnEndDrag(PointerEventData eventData); // 0x000000018D239B80-0x000000018D239C5C
		[IteratorStateMachine(typeof(__ApplyDamping_d__46))]
		private IEnumerator _ApplyDamping(); // 0x000000018D239C5C-0x000000018D239CF4
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class UISemiCircleScrollListPair : MonoBehaviour // TypeDefIndex: 74570
	{
		// Fields
		public UISemiCircleScrollList m_scrollListMaster; // 0x18
		public UISemiCircleScrollList[] m_scrollLists; // 0x20
		public DisposedUnityEvent<GameObject, int> onCellShow; // 0x28
		public DisposedUnityEvent<int> onClosestCellChanged; // 0x30
	
		// Constructors
		public UISemiCircleScrollListPair(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void Awake(); // 0x000000018663BB70-0x000000018663BF30
		private void _OnCellShow(GameObject go, int index); // 0x0000000186D316B0-0x0000000186D31740
		private void _OnClosestCellChanged(int index); // 0x000000018D23981C-0x000000018D2398AC
		private void _OnDrag(); // 0x000000018D2398AC-0x000000018D239958
		private void _OnEndDrag(); // 0x000000018D239958-0x000000018D2399E4
		public void RefreshLayout(int newCellCount, int targetCellIndex); // 0x000000018663B450-0x000000018663B500
	}

	[ExecuteAlways]
	[RequireComponent(typeof(UIImage))]
	public class UISequenceImage : TickableUIMono // TypeDefIndex: 74571
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
		protected override TickType tickOption { get; } // 0x0000000186CEF5A0-0x0000000186CEF5D0 
		public bool isPlaying { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EFA0-0x000000018226EFB0 0x000000018226EFB0-0x000000018226EFC0
	
		// Constructors
		public UISequenceImage(); // 0x00000001855DDEC0-0x00000001855DDF50
	
		// Methods
		protected override void OnAwake(); // 0x0000000186FCC790-0x0000000186FCC810
		protected override void OnEnable(); // 0x00000001860D87A0-0x00000001860D87F0
		protected override void OnDisable(); // 0x0000000186FA6BA0-0x0000000186FA6BE0
		public override void Tick(float deltaTime); // 0x00000001860D9270-0x00000001860D9300
		public void Play(); // 0x00000001860D87F0-0x00000001860D8840
		public void Stop(bool resetToFirstFrame = false /* Metadata: 0x0262839D */); // 0x0000000186FA6BE0-0x0000000186FA6C20
		public void SetSprite(int index); // 0x00000001860D9300-0x00000001860D9430
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	[RequireComponent(typeof(Animation))]
	public class UISimpleActiveAnimationHelper : TickableUIMono // TypeDefIndex: 74572
	{
		// Fields
		public bool isActive; // 0x68
		public string toActiveAnimationName; // 0x70
		private Animation m_animation; // 0x78
		private UnityEngine.AnimationState m_animationState; // 0x80
		private float m_animationTime; // 0x88
		private float m_curAnimationTime; // 0x8C
	
		// Properties
		protected override TickType tickOption { get; } // 0x000000018D23A0AC-0x000000018D23A0F0 
	
		// Constructors
		public UISimpleActiveAnimationHelper(); // 0x000000018716CB10-0x000000018716CB70
	
		// Methods
		private void Start(); // 0x000000018D239EA8-0x000000018D239F90
		protected override void OnEnable(); // 0x000000018D239D98-0x000000018D239E04
		public void Skip(); // 0x000000018D239E04-0x000000018D239EA8
		public override void Tick(float deltaTime); // 0x000000018D239F90-0x000000018D23A0AC
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	[ExecuteInEditMode]
	public class UISimpleStateController : MonoBehaviour // TypeDefIndex: 74574
	{
		// Fields
		[SerializeField]
		private List<StateInfo> _states; // 0x18
		private string m_curStateName; // 0x20
	
		// Properties
		public string curStateName { get; } // 0x000000018D23A0F0-0x000000018D23A130 
	
		// Nested types
		[Serializable]
		public class StateInfo // TypeDefIndex: 74573
		{
			// Fields
			public string name; // 0x10
			public List<GameObject> activeObjects; // 0x18
	
			// Constructors
			public StateInfo(); // 0x000000018503DF90-0x000000018503DFE0
	
			// Methods
			public override string ToString(); // 0x000000018D23866C-0x000000018D2386AC
			public string __iFixBaseProxy_ToString(); // 0x0000000188ABB3B8-0x0000000188ABB3C0
		}
	
		// Constructors
		public UISimpleStateController(); // 0x000000018653ABC0-0x000000018653AC30
	
		// Methods
		public void SetState(string stateName); // 0x00000001855619F0-0x0000000185561FA0
	}

	public class UISizeFollower : TickableUIMono // TypeDefIndex: 74575
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
		protected override TickType tickOption { get; } // 0x000000018662AC50-0x000000018662AC80 
		public RectTransform rectTransform { get; } // 0x0000000185D2C590-0x0000000185D2C640 
	
		// Constructors
		public UISizeFollower(); // 0x000000018503F3C0-0x000000018503F3D0
	
		// Methods
		public override void LateTick(float deltaTime); // 0x0000000185D2C170-0x0000000185D2C1A0
		public void SyncSize(); // 0x0000000185D2C1A0-0x0000000185D2C590
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	[AddComponentMenu("UI/UI Slider", 34)]
	public class UISlider : Slider, IUIClearable, IBeginDragHandler, IEndDragHandler, IBindingGroupTarget, IBindingView // TypeDefIndex: 74576
	{
		// Fields
		public float snapCenterRange; // 0x1F8
		[AudioString]
		public string audioSlide; // 0x200
		[AudioString]
		public string audioClickHandle; // 0x208
		private bool m_dragging; // 0x210
		private bool m_gamepadStickScrolling; // 0x211
		public SliderEvent onEndDragSlider; // 0x218
		public SliderEvent onClickSlider; // 0x220
		public SliderEvent onClickSliderHandle; // 0x228
		private TickFunction m_gamepadStickScrollTickFunction; // 0x230
		public string sliderAddActionId; // 0x238
		public string sliderReduceActionId; // 0x240
		[CompilerGenerated]
		private readonly DisposedUnityEvent _bindingViewUpdateEvent_k__BackingField; // 0x248
		private int m_bindingGroupId; // 0x250
		[CompilerGenerated]
		private IBindingGroupTarget _parentTarget_k__BackingField; // 0x258
		public bool snapStep; // 0x260
		public float stepValue; // 0x264
		[FormerlySerializedAs("_enableStickScroll")]
		[SerializeField]
		protected bool _enableGamepadStickScroll; // 0x268
		[FormerlySerializedAs("_stickScrollTolerance")]
		[Range(0.001f, 1f)]
		[SerializeField]
		protected float _gamepadStickScrollTolerance; // 0x26C
		[FormerlySerializedAs("_stickOverPushThreshold")]
		[Range(0.001f, 0.9f)]
		[SerializeField]
		protected float _gamepadStickOverPushThreshold; // 0x270
		[FormerlySerializedAs("_stickOverPushMultiplier")]
		[SerializeField]
		protected int _gamepadStickOverPushMultiplier; // 0x274
		[FormerlySerializedAs("_stickScrollBatchCount")]
		[SerializeField]
		protected int _gamepadStickScrollBatchCount; // 0x278
		private int m_gamepadStickScrollHoriBindingId; // 0x27C
	
		// Properties
		public string bindingViewActionId { get; } // 0x000000018D23A968-0x000000018D23A9AC 
		public string bindingViewLabelText { get; } // 0x000000018D23A9AC-0x000000018D23AA24 
		public DisposedUnityEvent bindingViewUpdateEvent { [CompilerGenerated] get; } // 0x000000018723C1C0-0x000000018723C1D0 
		public RectTransform redDotTrans { get; } // 0x000000018D23AC80-0x000000018D23ACC0 
		public bool bindingEnabled { get; } // 0x000000018D23A92C-0x000000018D23A968 
		public BindingViewState bindingViewState { get; } // 0x000000018D23AA24-0x000000018D23ABAC 
		public int groupId { get; } // 0x000000018D23AC3C-0x000000018D23AC80 
		public IBindingGroupTarget parentTarget { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C030-0x000000018723C040 0x0000000188DC4A98-0x0000000188DC4AAC
		public bool groupEnabled { get; } // 0x000000018D23ABAC-0x000000018D23AC3C 
		bool IBindingView.interactable { get; } // 0x000000018D23A1A0-0x000000018D23A1E4 
	
		// Constructors
		public UISlider(); // 0x0000000186585380-0x0000000186585540
	
		// Methods
		private void _TryPostSlideAudioEvent(); // 0x00000001865A9F30-0x00000001865A9F90
		protected override float ClampValue(float input); // 0x0000000186252D90-0x0000000186252E40
		protected override float CustomProcessNormalizedValue(float val); // 0x000000018D23A1E4-0x000000018D23A24C
		protected override void OnValueChanged(); // 0x00000001865A9F00-0x00000001865A9F30
		protected override void OnClickSliderBar(); // 0x000000018D23A394-0x000000018D23A424
		protected override void OnClickSliderHandle(); // 0x000000018D23A424-0x000000018D23A4E0
		protected override void _NotifyIsHover(bool isHover); // 0x0000000186866E00-0x0000000186866E50
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x000000018D23A358-0x000000018D23A394
		public virtual void OnEndDrag(PointerEventData eventData); // 0x000000018D23A4E0-0x000000018D23A590
		protected override void Awake(); // 0x000000018531E740-0x000000018531E7A0
		protected override void OnEnable(); // 0x000000018531E7A0-0x000000018531E850
		protected override void OnDisable(); // 0x0000000185C2D6E0-0x0000000185C2D7B0
		private void _CreateGamepadStickScrollTickFunction(); // 0x0000000185C2D390-0x0000000185C2D4D0
		private void _ReleaseGamepadStickScrollTickFunction(); // 0x0000000185C2D7C0-0x0000000185C2D820
		private void _GamepadStickScrollTick(float deltaTime); // 0x000000018699BC70-0x000000018699BD00
		public void ClearComponent(); // 0x00000001869E42A0-0x00000001869E4310
		protected override void OnDestroy(); // 0x0000000186A4E9D0-0x0000000186A4EA60
		public string GetBindingViewActionId(BindingViewActionType actionType); // 0x000000018D23A24C-0x000000018D23A358
		void IBindingView.OnInputKeyDown(bool isActionTrigger); // 0x000000018D23A130-0x000000018D23A168
		void IBindingView.OnInputKeyUp(bool isActionTrigger); // 0x000000018D23A168-0x000000018D23A1A0
		private void _InitBinding(); // 0x000000018531E420-0x000000018531E640
		private void _AddValue(); // 0x000000018D23A5A0-0x000000018D23A608
		private void _ReduceValue(); // 0x000000018D23A8C4-0x000000018D23A92C
		private void _InitGamepadStickScroll(); // 0x000000018531E640-0x000000018531E740
		private void _OnGamepadStickScrollHoriValue(); // 0x000000018D23A7F4-0x000000018D23A8C4
		private void _ApplyGamepadStickScroll(float deltaConcern); // 0x000000018D23A608-0x000000018D23A7F4
		public float __iFixBaseProxy_ClampValue(float P0); // 0x000000018D23A590-0x000000018D23A598
		public float __iFixBaseProxy_CustomProcessNormalizedValue(float P0); // 0x0000000187248B60-0x0000000187248B70
		public void __iFixBaseProxy_OnValueChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnClickSliderBar(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnClickSliderHandle(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018D21BBD4-0x000000018D21BBDC
		public void __iFixBaseProxy_Awake(); // 0x000000018D1F7518-0x000000018D1F7520
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D23A598-0x000000018D23A5A0
		public void __iFixBaseProxy_OnDisable(); // 0x0000000185C2D7B0-0x0000000185C2D7C0
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D1F7520-0x000000018D1F7528
	}

	[ExecuteInEditMode]
	public class UISoftMask : TickableUIMono // TypeDefIndex: 74578
	{
		// Fields
		private static readonly ProfilerMarker TAIL_LATE_TICK_MARKER; // 0x00
		private static readonly ProfilerMarker WILL_RENDER_CANVASES_MARKER; // 0x08
		private static readonly ProfilerMarker UPDATE_PARAM_MARKER; // 0x10
		private Vector3[] m_fourCornersArray; // 0x68
		private Vector3[] m_fourCornersArrayWorld; // 0x70
		private static List<Canvas> s_cacheCanvas; // 0x18
		private Image m_image; // 0x78
		private Graphic m_graphic; // 0x80
		private bool m_registeredWillRenderCanvases; // 0x88
		[SerializeField]
		private Shader _maskableDefaultShader; // 0x90
		[SerializeField]
		private Shader _maskableTextShader; // 0x98
		private static int s_SoftMaskTexId; // 0x20
		private static int s_SoftMaskTexSTId; // 0x24
		private static int s_WorldToSoftMaskId; // 0x28
		private static int s_InnerSoftMaskId; // 0x2C
		private static int s_InnerSoftMaskUVId; // 0x30
		private static int s_SpriteSlicedFlag; // 0x34
		private Texture m_mainTexture; // 0xA0
		private Vector4 m_spriteTillingOffset; // 0xA8
		private Matrix4x4 m_worldToSoftMask; // 0xB8
		private Vector4 m_innerSoftMask; // 0xF8
		private Vector4 m_innerSoftMaskUV; // 0x108
		private bool m_paramDirty; // 0x118
		private Matrix4x4 m_lastLocalToWorld; // 0x11C
		private readonly List<UISoftMaskable> m_maskables; // 0x160
		private static int s_cachedScreenWidth; // 0x38
		private static int s_cachedScreenHeight; // 0x3C
		private static int s_layoutEpoch; // 0x40
		private static int s_layoutEpochPollFrame; // 0x44
		private int m_handledLayoutEpoch; // 0x168
		private int m_pendingRefreshFrames; // 0x16C
		private SlicedSpriteParams m_slicedSpriteParams; // 0x170
		private Material m_softMaskDefaultMaterial; // 0x198
		private Dictionary<Material, Material> m_softMaskTextMaterials; // 0x1A0
		private Dictionary<Material, Material> m_softMaskUIVFXMaterials; // 0x1A8
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001863A5010-0x00000001863A5040 
		public Material softMaskDefaultMaterial { get; } // 0x000000018D23B240-0x000000018D23B284 
	
		// Nested types
		public struct SlicedSpriteParams // TypeDefIndex: 74577
		{
			// Fields
			public int slicedEnabled; // 0x00
			public Vector2 inner_PosMin; // 0x04
			public Vector2 inner_PosMax; // 0x0C
			public Vector2 inner_UVMin; // 0x14
			public Vector2 inner_UVMax; // 0x1C
	
			// Constructors
			public SlicedSpriteParams(int slicedEnabled, Vector2 inner_PosMin, Vector2 inner_PosMax, Vector2 inner_UVMin, Vector2 inner_UVMax); // 0x0000000187258D70-0x0000000187258DA0
		}
	
		// Constructors
		public UISoftMask(); // 0x000000018503EE90-0x000000018503EFF0
		static UISoftMask(); // 0x0000000186EC58C0-0x0000000186EC7390
	
		// Methods
		private static int _GetLayoutEpoch(); // 0x0000000184E594D0-0x0000000184E59A40
		private Texture _GetSoftMaskTexture(); // 0x00000001855E55B0-0x00000001855E5670
		public Material GetTextSoftMaskMaterial(Material baseMaterial); // 0x00000001852DD7F0-0x00000001852DDAB0
		public Material GetUIVFXSoftMaskMaterial(Material baseMaterial); // 0x00000001852E01E0-0x00000001852E0520
		public Vector3 GetCornerCanvas(int i); // 0x000000018D23ACC0-0x000000018D23AD4C
		public Vector3[] GetFourCornnerArrayWorld(); // 0x000000018D23AD4C-0x000000018D23AD8C
		public void RegisterMaskable(UISoftMaskable maskable); // 0x0000000184E58E30-0x0000000184E59180
		public void UnregisterMaskable(UISoftMaskable maskable); // 0x0000000184E59180-0x0000000184E594D0
		protected override void OnEnable(); // 0x000000018527C760-0x000000018527D1B0
		protected override void OnDisable(); // 0x000000018527BF20-0x000000018527C6A0
		public override void TailLateTick(float deltaTime); // 0x000000018513FA90-0x000000018513FDA0
		private void _OnGraphicDirty(); // 0x0000000184E59A40-0x0000000184E59A80
		private void OnRectTransformDimensionsChange(); // 0x0000000184E58DF0-0x0000000184E58E30
		private void _OnWillRenderCanvases(); // 0x000000018544BF90-0x000000018544C890
		private void _Clear(); // 0x000000018527BAE0-0x000000018527BED0
		private void _DestroyMaterial(Material material); // 0x000000018527BED0-0x000000018527BF20
		private void _UpdateParam(); // 0x00000001855E7470-0x00000001855E75F0
		private bool _RecalcParams(); // 0x0000000184E59A80-0x0000000184E5C880
		private void _UpdateChildren(bool markVertices, bool markMaterial); // 0x0000000185324720-0x00000001853248A0
		private static SlicedSpriteParams _CalculateSlicedSpriteParams(Image image); // 0x00000001856BD7E0-0x00000001856BDCB0
		private static Vector2 _NormalizeInnerUV(Vector2 innerUV, Vector4 outerUV); // 0x00000001856BDCB0-0x00000001856BDDE0
		private static Vector4 _GetSpriteOuterUV(Image image); // 0x00000001856BDDE0-0x00000001856BDF30
		private static Vector4 _GetRuntimeAtlasSpriteOuterUV(Image image); // 0x000000018D23B01C-0x000000018D23B154
		private static Vector4 _GetAdjustedBorders(Vector4 border, Rect adjustedRect, Rect originalRect); // 0x00000001856BD570-0x00000001856BD7E0
		private static Vector4 _GetRuntimeAtlasSpriteInnerUV(Image image); // 0x000000018D23AD8C-0x000000018D23B01C
		private static Vector4 _GetRuntimeAtlasSpritePadding(Image image); // 0x000000018D23B154-0x000000018D23B240
		private void _OnEnableRuntimeAtlas(); // 0x000000018682B050-0x000000018682B400
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_TailLateTick(float P0); // 0x0000000184167520-0x0000000184167530
	}

	[ExecuteInEditMode]
	public class UISoftMaskable : TickableUIMono, IMaterialModifier, IMeshModifier // TypeDefIndex: 74581
	{
		// Fields
		[SerializeField]
		[Tooltip("\u5F00\u542F\u540E\u4F1A\u88C1\u5207Mesh\u5230\u53EA\u6709SoftMask\u7684\u8303\u56F4\uFF0C\u51CF\u5C11OverDraw\u4F46\u4F1A\u589E\u52A0\u9876\u70B9\u751F\u6210\u7684\u8BA1\u7B97\u6D88\u8017\u3002\u5EFA\u8BAESoftMask\u5F88\u5C0F\u4F46SoftMaskable\u5F88\u5927\u65F6\u5F00\u542F\u3002\u4E0D\u652F\u6301Text")]
		public bool _clipMeshToSaveOverDraw; // 0x68
		private List<UIVertex> m_cacheVertexSteram; // 0x70
		private List<UIVertex> m_cacheDstVertexSteram; // 0x78
		protected static readonly string UI_MINIMAP_MIST_FLAG; // 0x00
		protected static readonly string UI_VFX_PARAM; // 0x08
		private TestLine[] m_testLinesCache; // 0x80
		private Material m_softMaskModefiedMat; // 0x88
		private Graphic m_graphic; // 0x90
		private UISoftMask m_softMask; // 0x98
		private UIText m_uiText; // 0xA0
		private UIType m_uiType; // 0xA8
		private UISoftMask m_registeredMask; // 0xB0
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186197990-0x00000001861979C0 
		public Material softMaskModefiedMat { get; } // 0x000000018D23CA90-0x000000018D23CAD4 
		public Graphic graphic { get; } // 0x00000001853255D0-0x00000001853256A0 
		public UISoftMask softMask { get; } // 0x00000001852E0C00-0x00000001852E0CD0 
		public UIText uiText { get; } // 0x000000018D23CAD4-0x000000018D23CB9C 
	
		// Nested types
		private enum UIType // TypeDefIndex: 74579
		{
			Default = 0,
			Text = 1,
			UIVFX = 2
		}
	
		private struct TestLine // TypeDefIndex: 74580
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
		public UISoftMaskable(); // 0x000000018503F030-0x000000018503F0E0
		static UISoftMaskable(); // 0x000000018716E690-0x000000018716E730
	
		// Methods
		public Material GetModifiedMaterial(Material baseMaterial); // 0x00000001852E0A40-0x00000001852E0C00
		protected override void OnEnable(); // 0x0000000185324EF0-0x00000001853255D0
		protected override void OnDisable(); // 0x0000000185324DD0-0x0000000185324EF0
		public override void LateTick(float deltaTime); // 0x00000001856C6810-0x00000001856C68F0
		public void MarkGraphicVerticesDirty(); // 0x00000001853248A0-0x0000000185324970
		public void MarkGraphicMaterialDirty(); // 0x0000000185324D10-0x0000000185324DD0
		private void _SyncRegistration(bool enabled); // 0x0000000184E5C970-0x0000000184E5CE80
		private void OnTransformParentChanged(); // 0x0000000184E5C880-0x0000000184E5C970
		[IDTag(0)]
		public void ModifyMesh(Mesh mesh); // 0x000000018D23B284-0x000000018D23B2BC
		private bool _Equal(float a, float b); // 0x000000018D23C9B8-0x000000018D23CA14
		private Vector2 _ComputeLineCross(Vector2 line0p0, Vector2 line0p1, Vector2 line1p0, Vector2 line1p1); // 0x000000018D23C624-0x000000018D23C850
		private void _ComputePointAtTriangleUV(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 q, out float u, out float v); // 0x000000018D23C850-0x000000018D23C9B8
		private void _ClipTriangleByClampSoftMaskUV(UIVertex[] vertices, UIVertex[] resultPoint, out bool canSkip); // 0x000000018D23B5A4-0x000000018D23C624
		private void _ClipRect(); // 0x000000018D23B2BC-0x000000018D23B5A4
		[IDTag(1)]
		public void ModifyMesh(VertexHelper vertHelper); // 0x00000001852E0930-0x00000001852E0A40
		private static void _SetUIVertexUV(ref UIVertex uiVertex, Vector2 uv0, Vector2 uv1, Vector2 softMaskUV); // 0x000000018D23CA14-0x000000018D23CA90
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
	}

	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class UISortingOrder : MonoBehaviour // TypeDefIndex: 74583
	{
		// Fields
		[Range(-9f, 9f)]
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
		public enum RenderType // TypeDefIndex: 74582
		{
			Effect = 0,
			UI = 1,
			Particle = 2
		}
	
		// Constructors
		public UISortingOrder(); // 0x0000000186B13BD0-0x0000000186B13C00
	
		// Methods
		private void OnEnable(); // 0x0000000186710380-0x00000001867103E0
		private void _GetRenderer(); // 0x000000018531CEE0-0x000000018531CF90
		private void _GetChildrenRenderers(); // 0x000000018531CF90-0x000000018531D010
		private void _GetChildrenParticleRenderers(); // 0x000000018531C600-0x000000018531C680
		private void _GetCanvas(); // 0x000000018531D1A0-0x000000018531D250
		public void SetOrder(int baseOrder); // 0x000000018531D7F0-0x000000018531DA50
		private void Awake(); // 0x000000018531E2B0-0x000000018531E420
		private void OnDestroy(); // 0x000000018682AF00-0x000000018682AFA0
	}

	public class UIStepScrollList : UIScrollList // TypeDefIndex: 74584
	{
		// Fields
		[NonSerialized]
		public DisposedUnityEvent<int, int> onCenterIndexChanged; // 0x280
		[NonSerialized]
		public DisposedUnityEvent onScrollOrDragEnd; // 0x288
		[NonSerialized]
		public DisposedUnityEvent onScrollOrDragStart; // 0x290
		[SerializeField]
		protected float _easyDragSpdThreshold; // 0x298
		[SerializeField]
		protected float _easyDragDistPercentThreshold; // 0x29C
		private int m_startDragCenterIndex; // 0x2A0
		private int m_centerIndex; // 0x2A4
		private Vector2 m_scrollStartNormalizedPos; // 0x2A8
	
		// Properties
		public int centerIndex { get; } // 0x0000000186D31B30-0x0000000186D31B60 
	
		// Constructors
		public UIStepScrollList(); // 0x0000000186B60EA0-0x0000000186B60FF0
	
		// Methods
		protected override void Init(bool isPreview = false /* Metadata: 0x026283A4 */); // 0x0000000185B2C5F0-0x0000000185B2C810
		protected override void InitConfig(); // 0x00000001865D60C0-0x00000001865D61F0
		protected override void OnScroll(Vector2 v); // 0x0000000185C8E560-0x0000000185C8E5C0
		public override void OnBeginDrag(PointerEventData eventData); // 0x0000000186C1DAD0-0x0000000186C1DB40
		public override void OnEndDrag(PointerEventData eventData); // 0x0000000186B29CC0-0x0000000186B29E90
		public override void SetTop(bool needUpdate = true /* Metadata: 0x026283A5 */); // 0x000000018D23CB9C-0x000000018D23CC18
		protected override void UpdateShowingCells(bool forceUpdateContent, bool forceClearShowingCells = false /* Metadata: 0x026283A6 */, bool ignoreListActive = false /* Metadata: 0x026283A7 */); // 0x0000000185383670-0x0000000185383730
		public override void ClearComponent(); // 0x0000000185B2AE70-0x0000000185B2AF20
		private void _OnScrollStart(Vector2 normalizedPos); // 0x000000018D23CD50-0x000000018D23CDB8
		private void _OnScrollEnd(Vector2 normalizedPos); // 0x000000018D23CC48-0x000000018D23CD50
		private void _TryAutoScroll(bool isEasyDrag, bool goNext); // 0x0000000186B29ED0-0x0000000186B29F50
		private int _GetClampedIndex(); // 0x0000000185383730-0x0000000185383790
		protected override void OnDisable(); // 0x0000000185383610-0x0000000185383670
		public void __iFixBaseProxy_Init(bool P0); // 0x000000018D23CC20-0x000000018D23CC28
		public void __iFixBaseProxy_InitConfig(); // 0x000000018D23CC18-0x000000018D23CC20
		public void __iFixBaseProxy_OnScroll(Vector2 P0); // 0x000000018D2316D8-0x000000018D2316E0
		public void __iFixBaseProxy_OnBeginDrag(PointerEventData P0); // 0x000000018D23CC28-0x000000018D23CC30
		public void __iFixBaseProxy_OnEndDrag(PointerEventData P0); // 0x000000018D23CC38-0x000000018D23CC40
		public void __iFixBaseProxy_SetTop(bool P0); // 0x000000018D23CC40-0x000000018D23CC48
		public void __iFixBaseProxy_UpdateShowingCells(bool P0, bool P1, bool P2); // 0x000000018D226944-0x000000018D226954
		public void __iFixBaseProxy_ClearComponent(); // 0x000000018D2268A4-0x000000018D2268AC
		public void __iFixBaseProxy_OnDisable(); // 0x000000018D23CC30-0x000000018D23CC38
	}

	public class UIStyleByState : MonoBehaviour // TypeDefIndex: 74587
	{
		// Fields
		public List<StyleConfig> styleConfigs; // 0x18
	
		// Nested types
		[Serializable]
		public class StateConfig // TypeDefIndex: 74585
		{
			// Fields
			public UIStateController stateController; // 0x10
			public string stateName; // 0x18
	
			// Constructors
			public StateConfig(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		public class StyleConfig // TypeDefIndex: 74586
		{
			// Fields
			public UIStyleInputValidTypeMask inputValidType; // 0x10
			public List<StateConfig> stateConfigs; // 0x18
	
			// Constructors
			public StyleConfig(); // 0x00000001865899C0-0x0000000186589A20
		}
	
		// Constructors
		public UIStyleByState(); // 0x000000018669D8C0-0x000000018669D930
	
		// Methods
		private void Awake(); // 0x000000018596FBC0-0x000000018596FCD0
		private void OnDestroy(); // 0x0000000185AB72C0-0x0000000185AB73C0
		public void UpdateStyle(); // 0x000000018596FD80-0x0000000185970170
		private bool _IsValidStyle(StyleConfig styleConfig); // 0x0000000185970170-0x00000001859701B0
	}

	public class UISubtitle : MonoBehaviour // TypeDefIndex: 74588
	{
		// Fields
		[SerializeField]
		private UIText _topText; // 0x18
		[SerializeField]
		private UIText _bottomText; // 0x20
	
		// Constructors
		public UISubtitle(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void Start(); // 0x000000018D23CEBC-0x000000018D23CEF4
		private void _SetAsDefault(); // 0x000000018D23CFDC-0x000000018D23D114
		public void SetSubtitle(string subtitle, bool showOnTop); // 0x000000018D23CDB8-0x000000018D23CEBC
		public void UpdateAlpha(float alpha, bool isTop); // 0x000000018D23CEF4-0x000000018D23CFDC
	}

	public class UITextPair : MonoBehaviour // TypeDefIndex: 74589
	{
		// Fields
		public List<UIText> referencedTexts; // 0x18
	
		// Properties
		public string text { get; set; } // 0x000000018D23D320-0x000000018D23D3E0 0x0000000185A57A80-0x0000000185A57BA0
		public UnityEngine.Color color { set; } // 0x000000018D23D3E0-0x000000018D23D570
		public UIText first { get; } // 0x000000018D23D280-0x000000018D23D320 
	
		// Constructors
		public UITextPair(); // 0x00000001868DF0D0-0x00000001868DF140
	
		// Methods
		public void SetAndResolveTextStyle(string targetText); // 0x000000018D23D114-0x000000018D23D280
		public void SetPhoneticText(PhoneticType phoneticType, string id); // 0x0000000185A578B0-0x0000000185A57A80
	}

	public enum TimelineUIBindingType // TypeDefIndex: 74590
	{
		None = 0,
		Mask = 1,
		BigLogoFitImageTop = 2,
		BigLogoFitImageBottom = 3
	}

	public class UITimelineBindingTarget : MonoBehaviour // TypeDefIndex: 74591
	{
		// Fields
		public TimelineUIBindingType bindingType; // 0x18
	
		// Constructors
		public UITimelineBindingTarget(); // 0x00000001878364A0-0x00000001878364B8
	}

	[AddComponentMenu("UI/UI Toggle", 30)]
	public class UIToggle : Toggle, IUIClearable // TypeDefIndex: 74592
	{
		// Fields
		[SerializeField]
		private List<GameObject> _onObjects; // 0x1B8
		[SerializeField]
		private List<GameObject> _offObjects; // 0x1C0
		[SerializeField]
		private UIStateController _uiStateController; // 0x1C8
		[SerializeField]
		private string _onStateName; // 0x1D0
		[SerializeField]
		private string _offStateName; // 0x1D8
		[SerializeField]
		private string _onAnimation; // 0x1E0
		[SerializeField]
		private string _offAnimation; // 0x1E8
		[AudioString]
		[SerializeField]
		private string _audioToggleOn; // 0x1F0
		[AudioString]
		[SerializeField]
		private string _audioToggleOff; // 0x1F8
		[AudioString]
		[SerializeField]
		private string _audioInvalid; // 0x200
		[SerializeField]
		public bool _ignoreClickOnDrag; // 0x208
		[CompilerGenerated]
		private Vector2 _startPressPos_k__BackingField; // 0x20C
		[SerializeField]
		[Tooltip("\u4E0D\u53EF\u70B9\u51FB\u65F6\u5F39\u51FA\u7684Toast\u6587\u672CKey")]
		private LangKey _invalidClickLangKey; // 0x218
		public Func<bool, bool> checkIsValueValid; // 0x228
		private Animation m_animation; // 0x230
		private int m_groupId; // 0x238
		[FormerlySerializedAs("_toggleActionId")]
		public string toggleActionId; // 0x240
		[CompilerGenerated]
		private int _toggleBindingId_k__BackingField; // 0x248
		private bool m_started; // 0x24C
		[NonSerialized]
		public string clickOnHintTextId; // 0x250
		[NonSerialized]
		public string clickOffHintTextId; // 0x258
		private string m_customBindingViewLabelText; // 0x260
		[FormerlySerializedAs("actionOnSetNaviTarget")]
		[SerializeField]
		private ActionOnSetNaviTarget _actionOnSetNaviTarget; // 0x268
		[SerializeField]
		private bool _useNoHintAction; // 0x26C
		public string onHintTextId; // 0x270
		public string offHintTextId; // 0x278
		[CompilerGenerated]
		private int _hoverConfirmBindingId_k__BackingField; // 0x280
	
		// Properties
		public Vector2 startPressPos { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187258DA0-0x0000000187258DC0 0x0000000187258DD0-0x0000000187258DE0
		public int toggleBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187258DC0-0x0000000187258DD0 0x0000000187258DE0-0x0000000187258DF0
		public string customBindingViewLabelText { get; set; } // 0x000000018D23DEBC-0x000000018D23DF00 0x000000018D23DF00-0x000000018D23DFE8
		public int hoverConfirmBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723E2E0-0x000000018723E2F0 0x000000018723E300-0x000000018723E310
	
		// Constructors
		public UIToggle(); // 0x000000018503DE70-0x000000018503DF90
	
		// Methods
		protected override void Awake(); // 0x000000018531F1A0-0x000000018531F240
		protected override void OnEnable(); // 0x000000018503DDC0-0x000000018503DE30
		protected override void OnDisable(); // 0x000000018503DD50-0x000000018503DD90
		private void _UpdateBindingEnable(); // 0x000000018503E3F0-0x000000018503E4A0
		protected override void OnDestroy(); // 0x000000018503F3D0-0x000000018503F4A0
		protected override void Start(); // 0x000000018503F770-0x000000018503F7E0
		protected override void InternalToggle(); // 0x00000001867FAB80-0x00000001867FAC10
		private void _InitToggleBinding(); // 0x000000018503FCF0-0x000000018503FED0
		private bool _OnToggleFail(); // 0x000000018D23DCC4-0x000000018D23DE18
		public void PlayAudio(); // 0x00000001867FAC70-0x00000001867FAD00
		protected override void OnValueChange(); // 0x000000018503F940-0x000000018503F9A0
		protected override void _NotifyIsHover(bool isHover); // 0x00000001850448E0-0x0000000185044960
		private void _UpdateObjects(bool applyStateController); // 0x0000000184E5CE80-0x0000000184E5E3C0
		private void _PlayAnimation(bool skipToEnd); // 0x000000018503FB70-0x000000018503FCF0
		public void ClearComponent(); // 0x000000018503F4A0-0x000000018503F540
		public override void OnInteractableChanged(); // 0x00000001871EC590-0x00000001871EC5C0
		public override bool GetMouseActionHints(out string clickHintTextId, out string longPressHintTextId); // 0x000000018D23D9DC-0x000000018D23DA54
		public override void OnPointerDown(PointerEventData eventData); // 0x0000000186A44170-0x0000000186A441F0
		public override void OnPointerClick(PointerEventData eventData); // 0x0000000185033070-0x0000000185033100
		public override void OnSubmit(BaseEventData eventData); // 0x000000018D23DABC-0x000000018D23DAF8
		public void TryInternalToggle(); // 0x0000000185033100-0x0000000185033170
		public override void OnNaviTargetEnabledAgain(); // 0x000000018D23DA54-0x000000018D23DABC
		protected override void _OnSetAsNaviTarget(bool isTarget, bool silentMode); // 0x000000018D23DB78-0x000000018D23DCC4
		private void _InitActionOnSetNaviTarget(); // 0x000000018503F7E0-0x000000018503F940
		private void _ToggleNaviInputBinding(bool active); // 0x000000018D23DE18-0x000000018D23DEBC
		private void _TryRefreshToggleBindingText(); // 0x000000018503F9E0-0x000000018503FA20
		private void _TryRefreshHoverConfirmBindingText(); // 0x000000018503F9A0-0x000000018503F9E0
		private void _TryRefreshBindingText(int bindingId, bool useCustomBindingViewLabelText = false /* Metadata: 0x026283AC */); // 0x000000018503FA20-0x000000018503FB70
		public void RefreshHintText(); // 0x000000018D23DAF8-0x000000018D23DB50
		public void __iFixBaseProxy_Awake(); // 0x000000018D1F7518-0x000000018D1F7520
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D23DB68-0x000000018D23DB70
		public void __iFixBaseProxy_OnDisable(); // 0x000000018D23DB60-0x000000018D23DB68
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D23DB58-0x000000018D23DB60
		public void __iFixBaseProxy_Start(); // 0x00000001878348AC-0x00000001878348B8
		public void __iFixBaseProxy_InternalToggle(); // 0x000000018D23DB50-0x000000018D23DB58
		public void __iFixBaseProxy_OnValueChange(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy__NotifyIsHover(bool P0); // 0x000000018D21BBD4-0x000000018D21BBDC
		public void __iFixBaseProxy_OnInteractableChanged(); // 0x0000000186805BA0-0x0000000186805BB0
		public bool __iFixBaseProxy_GetMouseActionHints(out string P0, out string P1); // 0x000000018D21BBB4-0x000000018D21BBBC
		public void __iFixBaseProxy_OnPointerDown(PointerEventData P0); // 0x000000018D21BBC4-0x000000018D21BBCC
		public void __iFixBaseProxy_OnPointerClick(PointerEventData P0); // 0x000000018D23DB70-0x000000018D23DB78
		public void __iFixBaseProxy_OnSubmit(BaseEventData P0); // 0x000000018CE6052C-0x000000018CE6053C
		public void __iFixBaseProxy_OnNaviTargetEnabledAgain(); // 0x000000018D21BBBC-0x000000018D21BBC4
		public void __iFixBaseProxy__OnSetAsNaviTarget(bool P0, bool P1); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class UIToggleGroup : ToggleGroup // TypeDefIndex: 74593
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
		public int moveToNextBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226F000-0x000000018226F010 0x000000018226F010-0x000000018226F020
		public int moveToPreviousBindingId { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182271C50-0x0000000182271C60 0x0000000182271C70-0x0000000182271C80
	
		// Constructors
		public UIToggleGroup(); // 0x000000018503F310-0x000000018503F3C0
	
		// Methods
		protected override void Awake(); // 0x00000001868EC520-0x00000001868EC770
		protected override void OnEnable(); // 0x00000001865194F0-0x0000000186519600
		protected override void OnDisable(); // 0x00000001868C6880-0x00000001868C6980
		protected override void OnDestroy(); // 0x0000000186A41D60-0x0000000186A41E60
		public void MoveToNext(); // 0x000000018D23D570-0x000000018D23D5B0
		public void MoveToPrevious(); // 0x000000018D23D5B0-0x000000018D23D5F0
		private void _MoveTo(bool isNext); // 0x000000018D23D5F0-0x000000018D23D9DC
		public void __iFixBaseProxy_Awake(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnEnable(); // 0x00000001865194E0-0x00000001865194F0
		public void __iFixBaseProxy_OnDisable(); // 0x0000000186805BA0-0x0000000186805BB0
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public enum FingerMoveDirection // TypeDefIndex: 74594
	{
		None = 0,
		Anisotropy = 1,
		Same = 2
	}

	[RequireComponent(typeof(Graphic))]
	public class UITouchPanel : TickableUIMono, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler, UnityEngine.EventSystems.IScrollHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IUIClearable, IBindingGroupTarget // TypeDefIndex: 74595
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
		public DisposedUnityEvent<Vector2> onGesturePan; // 0x178
		public DisposedUnityEvent onDragToLeft; // 0x180
		public DisposedUnityEvent onDragToRight; // 0x188
		public DisposedUnityEvent onPointerEnter; // 0x190
		public DisposedUnityEvent onPointerExit; // 0x198
		public DisposedUnityEvent onDragToUp; // 0x1A0
		public DisposedUnityEvent onDragToDown; // 0x1A8
		public DisposedUnityEvent<Vector2> onRightMouseButtonPress; // 0x1B0
		public DisposedUnityEvent<float> onScroll; // 0x1B8
		[CompilerGenerated]
		private Vector2 _curPressPos_k__BackingField; // 0x1C0
		[CompilerGenerated]
		private bool _isPointerEntered_k__BackingField; // 0x1C8
		public bool enableZoom; // 0x1C9
		public DisposedUnityEvent<PointerEventData> rawOnDrag; // 0x1D0
		private float m_leftMousePressDownTimeWithNoCursor; // 0x1D8
		private float m_rightMousePressDownTimeWithNoCursor; // 0x1DC
		private int m_groupId; // 0x1E0
		private bool m_bindingInit; // 0x1E4
		[CompilerGenerated]
		private InputBindingGroupMonoTarget _parent_k__BackingField; // 0x1E8
	
		// Properties
		protected override TickType tickOption { get; } // 0x0000000186A51630-0x0000000186A51660 
		public Vector2 touchPos { get; } // 0x000000018D23E18C-0x000000018D23E414 
		public Vector2 curPressPos { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187258DF0-0x0000000187258E10 0x000000018723D900-0x000000018723D910
		public bool isPointerEntered { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187240890-0x00000001872408A0 0x0000000187240920-0x0000000187240930
		public bool isDragging { get; } // 0x000000018D23E0C0-0x000000018D23E104 
		public bool isInGestureZoom { get; } // 0x000000018D23E104-0x000000018D23E148 
		public bool groupEnabled { get; } // 0x00000001862DA2B0-0x00000001862DA310 
		public int groupId { get; } // 0x0000000185F2D4A0-0x0000000185F2D4E0 
		public IBindingGroupTarget parentTarget { get; } // 0x000000018D23E148-0x000000018D23E18C 
		public InputBindingGroupMonoTarget parent { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018723C100-0x000000018723C110 0x0000000188DC4BEC-0x0000000188DC4C00
	
		// Constructors
		public UITouchPanel(); // 0x00000001864E4900-0x00000001864E4F20
	
		// Methods
		public void OnBeginDrag(PointerEventData eventData); // 0x0000000185F2C340-0x0000000185F2C440
		public void OnEndDrag(PointerEventData eventData); // 0x0000000185F2C440-0x0000000185F2C4C0
		public void DoEndDrag(Vector2 dragPos); // 0x0000000185F2D980-0x0000000185F2DA50
		public void OnDrag(PointerEventData eventData); // 0x0000000185F2CEF0-0x0000000185F2D030
		public void OnPointerDown(PointerEventData eventData); // 0x00000001869B8210-0x00000001869B8350
		public void OnPointerUp(PointerEventData eventData); // 0x0000000185F2D0D0-0x0000000185F2D240
		public void OnPointerClick(PointerEventData eventData); // 0x0000000185032C10-0x0000000185033060
		public void OnPointerEnter(PointerEventData eventData); // 0x00000001869ED340-0x00000001869ED380
		public void OnPointerExit(PointerEventData eventData); // 0x00000001869ED300-0x00000001869ED340
		private void _OnActionPress(PointerEventData eventData); // 0x00000001869B8350-0x00000001869B89A0
		private void _OnActionRelease(PointerEventData eventData); // 0x0000000185F2D240-0x0000000185F2D360
		private bool _IsSameTouchFromPress(PointerEventData eventData); // 0x0000000185F2D810-0x0000000185F2D860
		public void ClearTouchInfo(); // 0x0000000185F2D7A0-0x0000000185F2D810
		public void OnScroll(PointerEventData eventData); // 0x0000000185C8CBB0-0x0000000185C8CCA0
		public void SimulateClick(PointerEventData eventData); // 0x000000018D23DFE8-0x000000018D23E028
		public void DeActiveTouch(int touchId); // 0x000000018531B050-0x000000018531B0D0
		protected override void OnAwake(); // 0x0000000185F2D360-0x0000000185F2D3F0
		public override void Tick(float deltaTime); // 0x00000001853ACE40-0x00000001853AD640
		public override void LateTick(float deltaTime); // 0x0000000185F2D860-0x0000000185F2D940
		protected override void OnEnable(); // 0x0000000185F2DA50-0x0000000185F2DA90
		protected override void OnDisable(); // 0x0000000185F2D730-0x0000000185F2D7A0
		protected override void OnDestroy(); // 0x0000000185F2D3F0-0x0000000185F2D4A0
		protected override void OnRelease(); // 0x00000001867E3580-0x00000001867E35C0
		public void InitBinding(); // 0x0000000185F2D4E0-0x0000000185F2D730
		private void _UpdateState(); // 0x0000000185F2DA90-0x0000000185F2DB70
		public void ClearComponent(); // 0x00000001867E35C0-0x00000001867E3870
		[CompilerGenerated]
		private void _InitBinding_b__113_0(); // 0x000000018D23E028-0x000000018D23E074
		[CompilerGenerated]
		private void _InitBinding_b__113_1(); // 0x000000018D23E074-0x000000018D23E0C0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnAwake(); // 0x0000000188DA5258-0x0000000188DA5260
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
		public void __iFixBaseProxy_OnDestroy(); // 0x0000000189572D4C-0x0000000189572D54
		public void __iFixBaseProxy_OnRelease(); // 0x0000000188CBEF18-0x0000000188CBEF20
	}

	[DefaultExecutionOrder(10)]
	[ExecuteInEditMode]
	public class UIVFXManager : TickableUIMono, IMaterialModifier // TypeDefIndex: 74596
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
		protected override TickType tickOption { get; } // 0x0000000186FB8610-0x0000000186FB8640 
		public Graphic graphic { get; } // 0x00000001852D9290-0x00000001852D9350 
		public UISoftMaskable softMaskable { get; } // 0x000000018D2485B4-0x000000018D24867C 
	
		// Constructors
		public UIVFXManager(); // 0x0000000186D2E310-0x0000000186D2E3B0
		static UIVFXManager(); // 0x00000001871F2130-0x00000001871F2180
	
		// Methods
		protected override void OnEnable(); // 0x00000001852D8F60-0x00000001852D9110
		public override void LateTick(float deltaTime); // 0x000000018D24845C-0x000000018D2484EC
		private void _OnEnableRuntimeAtlas(); // 0x000000018D24857C-0x000000018D2485B4
		protected override void OnDisable(); // 0x00000001852D9110-0x00000001852D9290
		private void _Clear(); // 0x00000001852D7B70-0x00000001852D7D10
		private void _DestroyMaterial(Material material); // 0x000000018D2484EC-0x000000018D24857C
		private void _UpdateParam(); // 0x00000001852D8A90-0x00000001852D8C10
		public Material GetModifiedMaterial(Material baseMaterial); // 0x0000000186F8F520-0x0000000186F8F5E0
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_OnEnable(); // 0x00000001828D23E0-0x00000001828D23F0
		public void __iFixBaseProxy_LateTick(float P0); // 0x0000000188D68974-0x0000000188D6897C
		public void __iFixBaseProxy_OnDisable(); // 0x00000001828D23D0-0x00000001828D23E0
	}

	public class UIWorldLevelScrollListAnimCtrl : MonoBehaviour // TypeDefIndex: 74599
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
		public class ScrollListLayoutInfo // TypeDefIndex: 74597
		{
			// Fields
			public VerticalLayoutGroup layoutGroup; // 0x10
			public RectTransform layoutRectTransform; // 0x18
			public LayoutElement cell; // 0x20
	
			// Properties
			public float cellHeight { get; } // 0x000000018D2414F0-0x000000018D2415D4 
	
			// Constructors
			public ScrollListLayoutInfo(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[CompilerGenerated]
		private sealed class __ScrollLayouts_d__12 : IEnumerator<object> // TypeDefIndex: 74598
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public __ScrollLayouts_d__12(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D244E0C-0x000000018D245528
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D245528-0x000000018D245574
		}
	
		// Constructors
		public UIWorldLevelScrollListAnimCtrl(); // 0x000000018D248AB8-0x000000018D248B14
	
		// Methods
		public void UpdateUpPos(int current); // 0x000000018D24889C-0x000000018D248950
		public void UpdateDownPos(int current); // 0x000000018D2486E8-0x000000018D2487BC
		public void UpdateMidPos(int current); // 0x000000018D2487BC-0x000000018D24889C
		public void UpdateWorldLevelScrollList(bool isUp, int count); // 0x000000018D248950-0x000000018D2489F4
		private void OnDisable(); // 0x000000018D24867C-0x000000018D2486E8
		[IteratorStateMachine(typeof(__ScrollLayouts_d__12))]
		private IEnumerator _ScrollLayouts(bool isUp, int count); // 0x000000018D2489F4-0x000000018D248AB8
	}

	public class VirtualMouseInitPos : MonoBehaviour // TypeDefIndex: 74600
	{
		// Fields
		private LuaPanel m_panel; // 0x18
	
		// Properties
		public LuaPanel panel { get; } // 0x000000018D248C80-0x000000018D248D34 
	
		// Constructors
		public VirtualMouseInitPos(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnEnable(); // 0x000000018D248B14-0x000000018D248C80
	}

	public class CSPopupPanel : MonoBehaviour // TypeDefIndex: 74601
	{
		// Fields
		public const string KEY = "CSPopupPanel"; // Metadata: 0x026283B2
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
		public CSPopupPanel(); // 0x00000001878364A0-0x00000001878364B8
		static CSPopupPanel(); // 0x0000000187179280-0x0000000187179310
	
		// Methods
		private void Awake(); // 0x0000000186FAF9B0-0x0000000186FAFAE0
		private void _OnConfirm(PointerEventData p); // 0x00000001871141C0-0x0000000187114260
		private void _OnCancel(PointerEventData p); // 0x000000018D23E614-0x000000018D23E6BC
		private void OnDestroy(); // 0x0000000185B10340-0x0000000185B10500
		public static void Show(string content, Action onConfirm, bool showCancel = false /* Metadata: 0x026283B0 */, Action onCancel = null, string confirmTxt = null, string cancelTxt = null, bool showWarning = false /* Metadata: 0x026283B1 */); // 0x0000000185B10500-0x0000000185B10980
		public static void ClearAllPanels(); // 0x000000018D23E414-0x000000018D23E614
	}

	public class LuaUIRoot : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 74602
	{
		// Fields
		public SerializeReferenceDictionary<string, LuaUIRootNode> nodeDic; // 0x18
	
		// Constructors
		public LuaUIRoot(); // 0x000000018D241180-0x000000018D241200
	}

	public class LuaUIRootNode : MonoBehaviour, ILuaCallCSharp // TypeDefIndex: 74603
	{
		// Fields
		public string panelName; // 0x18
		public string panelFolder; // 0x20
	
		// Constructors
		public LuaUIRootNode(); // 0x00000001878364A0-0x00000001878364B8
	}

	public class MobileMotionManager : BaseManager // TypeDefIndex: 74605
	{
		// Fields
		private const string COMMON_MOTION_SHORT = "au_vibration_common_short"; // Metadata: 0x026283BF
		private const string COMMON_MOTION_OPERATE_SUCCESS = "au_vibration_common_action_success"; // Metadata: 0x026283D9
		private const string COMMON_MOTION_OPERATE_FAILURE = "au_vibration_common_action_fail"; // Metadata: 0x026283FC
		private const string MOTION_LEVEL_LOW = "au_motion_resolution_state_low"; // Metadata: 0x0262841C
		private const string MOTION_LEVEL_MEDIUM = "au_motion_resolution_state_medium"; // Metadata: 0x0262843B
		private const string MOTION_LEVEL_HIGH = "au_motion_resolution_state_high"; // Metadata: 0x0262845D
		private MotionLevel m_currMotionLevel; // 0x18
	
		// Nested types
		private enum MotionLevel // TypeDefIndex: 74604
		{
			NONE = 0,
			LOW = 1,
			MEDIUM = 2,
			HIGH = 3
		}
	
		// Constructors
		public MobileMotionManager(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected override void OnInit(); // 0x0000000186EC42A0-0x0000000186EC43B0
		protected override void OnRelease(); // 0x000000018D241200-0x000000018D241310
		public uint PostEventCommonShort(); // 0x000000018D241400-0x000000018D241478
		public uint PostEventCommonOperateSuccess(); // 0x000000018D241388-0x000000018D241400
		public uint PostEventCommonOperateFailure(); // 0x000000018D241310-0x000000018D241388
		public uint PostEvent(string eventName); // 0x000000018D241478-0x000000018D2414F0
		private void _CheckMotionLevelAndPostIfChange(); // 0x0000000186EC43B0-0x0000000186EC4460
	}

	public static class I18nFontLoader // TypeDefIndex: 74606
	{
		// Fields
		private static Dictionary<int, FAssetProxyHandle> s_id2FontDic; // 0x00
		private static Dictionary<string, FAssetProxyHandle> s_name2MaterialDic; // 0x08
		private static FAssetProxyHandle s_fontSearchDataHandle; // 0x10
	
		// Properties
		public static I18nFontSearchData fontSearchData { get; } // 0x0000000185103530-0x00000001851036A0 
	
		// Constructors
		static I18nFontLoader(); // 0x0000000186FAA620-0x0000000186FAAEE0
	
		// Methods
		public static bool IsInvalid(); // 0x00000001851036A0-0x00000001851037D0
		public static Material GetMaterial(string matName); // 0x000000018D240A2C-0x000000018D240C80
		public static TMP_FontAsset GetI18nFont(int cnFontId); // 0x00000001851032F0-0x0000000185103530
		public static TMP_FontAsset GetCNFont(int cnFontId); // 0x000000018D2409B0-0x000000018D240A2C
		private static TMP_FontAsset _GetFontById(int fontId); // 0x00000001851037D0-0x0000000185103AF0
		public static int GetCNFontId(TMP_FontAsset font); // 0x000000018D24090C-0x000000018D2409B0
		public static bool IsFontDefaultMaterial(Material mat); // 0x0000000186B57DC0-0x0000000186B57E60
	}

	public class DynamicFontAssetLoader : IFontAssetLoader // TypeDefIndex: 74608
	{
		// Fields
		[CompilerGenerated]
		private List<FontAssetRef> _fontAssets_k__BackingField; // 0x10
		private static HashSet<uint> s_notFoundUnicodes; // 0x00
	
		// Properties
		public List<FontAssetRef> fontAssets { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Nested types
		public class FontAssetRef // TypeDefIndex: 74607
		{
			// Fields
			public I18nFontSearchData.FontAssetInfo fontAssetInfo; // 0x10
			private HashSet<TMP_Text> m_refTexts; // 0x18
			private FAssetProxyHandle m_assetHandle; // 0x20
			private TMP_FontAsset m_fontAsset; // 0x38
	
			// Constructors
			public FontAssetRef(); // 0x0000000186B48F50-0x0000000186B48FD0
	
			// Methods
			public TMP_FontAsset GetFontAsset(TMP_Text refText); // 0x000000018671E2C0-0x000000018671E540
			public void RemoveRefText(TMP_Text refText); // 0x000000018671E7F0-0x000000018671E940
			public void Dispose(); // 0x000000018D23F14C-0x000000018D23F208
		}
	
		// Constructors
		public DynamicFontAssetLoader(); // 0x0000000186B48D80-0x0000000186B48F50
		static DynamicFontAssetLoader(); // 0x0000000187178980-0x0000000187178A10
	
		// Methods
		public static void AddNotFoundUnicode(uint unicode, bool forceLog = false /* Metadata: 0x02628481 */); // 0x000000018671E5C0-0x000000018671E7F0
		public bool TryGetFontAsset(TMP_Text refText, uint unicode, out TMP_FontAsset fontAsset); // 0x000000018671DD50-0x000000018671E2C0
		public void TryRemoveRefText(TMP_Text refText); // 0x000000018671D840-0x000000018671DD50
		public void Dispose(); // 0x000000018D23E700-0x000000018D23E8A4
	}

	public static class TweenUtils // TypeDefIndex: 74610
	{
		// Nested types
		public struct FLerpByTime // TypeDefIndex: 74609
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
			public bool isEmpty { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001844AD2A0-0x00000001844AD2B0 0x0000000187233BE0-0x0000000187233BF0
	
			// Constructors
			static FLerpByTime(); // 0x000000018D23E9D0-0x000000018D23EA38
	
			// Methods
			public void Start(ITickOwner timeScaleProvider = null); // 0x000000018D23E98C-0x000000018D23E9D0
			public float GetValue(out bool isTweenFinished); // 0x000000018D23E8A4-0x000000018D23E98C
		}
	
		// Methods
		public static bool TickAsCountDown(ref float countDown, float timeDelta); // 0x000000018575D440-0x000000018575D4F0
	}

	public class UIAnimationLayerMixPlayer : SingleMixerAssetPlayer<AnimationClip, AnimationClipPlayable, AnimationLayerMixerPlayable, AnimationPlayableOutput> // TypeDefIndex: 74611
	{
		// Fields
		private Animator m_target; // 0x60
		private string m_outputName; // 0x68
	
		// Constructors
		public UIAnimationLayerMixPlayer(Animator target, string outputName); // 0x00000001867C8120-0x00000001867C8190
	
		// Methods
		public void LockToClip(AnimationClip clip, float clipPos); // 0x00000001867C7270-0x00000001867C7380
		protected override PlayableGraph CreateGraph(); // 0x000000018596C920-0x000000018596C980
		protected override AnimationLayerMixerPlayable CreateMixer(PlayableGraph graph, out GenericShareSingleMixerAssetPlayer<AnimationClip> options); // 0x000000018596C150-0x000000018596C240
		protected override AnimationPlayableOutput CreateOutput(PlayableGraph graph); // 0x000000018596C8C0-0x000000018596C920
		protected override AnimationClipPlayable CreateSourceFromAsset(AnimationClip clip, PlayableGraph graph, out GenericShareSingleMixerAssetPlayer<AnimationClip> meta); // 0x000000018596C980-0x000000018596CA70
	}

	public class UIAnimationMixPlayer : SingleMixerAssetPlayer<AnimationClip, AnimationClipPlayable, AnimationMixerPlayable, AnimationPlayableOutput> // TypeDefIndex: 74612
	{
		// Fields
		private Animator m_target; // 0x60
		private string m_outputName; // 0x68
	
		// Constructors
		public UIAnimationMixPlayer(Animator target, string outputName); // 0x00000001867C7F90-0x00000001867C8000
	
		// Methods
		public void LockToClip(AnimationClip clip, float clipPos); // 0x00000001867C8000-0x00000001867C8120
		protected override PlayableGraph CreateGraph(); // 0x000000018596D1B0-0x000000018596D210
		protected override AnimationMixerPlayable CreateMixer(PlayableGraph graph, out GenericShareSingleMixerAssetPlayer<AnimationClip> options); // 0x000000018596D090-0x000000018596D150
		protected override AnimationPlayableOutput CreateOutput(PlayableGraph graph); // 0x000000018596D150-0x000000018596D1B0
		protected override AnimationClipPlayable CreateSourceFromAsset(AnimationClip clip, PlayableGraph graph, out GenericShareSingleMixerAssetPlayer<AnimationClip> meta); // 0x000000018596E3E0-0x000000018596E4D0
	}

	public class UIListCache<TComp> // TypeDefIndex: 74615
		where TComp : Component
	{
		// Fields
		private FOptions m_options;
		private List<ItemWrapper> m_items;
		private int m_count;
	
		// Nested types
		public struct FOptions // TypeDefIndex: 74613
		{
			// Fields
			public TComp cellTemplate;
			public Transform parent;
			public Action<TComp> onItemCreated;
		}
	
		private class ItemWrapper // TypeDefIndex: 74614
		{
			// Fields
			public TComp comp;
	
			// Constructors
			public ItemWrapper();
		}
	
		// Constructors
		public UIListCache(FOptions options);
	
		// Methods
		public void Refresh(int count, Action<TComp, int> refreshFunc, bool shouldHide = false /* Metadata: 0x02628482 */, Action<TComp, int> onDisableFunc = null);
		public TComp GetItem(int index);
		private ItemWrapper _CreateNewItem();
	}

	public class UILoadImageSprite : MonoBehaviour // TypeDefIndex: 74617
	{
		// Fields
		public bool isAsync; // 0x18
		public bool setNativeSize; // 0x19
		protected string m_spritePath; // 0x20
		protected Image m_imageComp; // 0x28
		protected FAssetProxyHandle m_handle; // 0x30
	
		// Properties
		public string spritePath { get; set; } // 0x000000018D247668-0x000000018D2476A8 0x0000000186BB6320-0x0000000186BB6380
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0 // TypeDefIndex: 74616
		{
			// Fields
			public UILoadImageSprite __4__this; // 0x10
			public string path; // 0x18
	
			// Constructors
			public __c__DisplayClass9_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void __LoadSprite_b__0(bool isOk, FAssetProxyHandle handle); // 0x000000018D244BE8-0x000000018D244D64
		}
	
		// Constructors
		public UILoadImageSprite(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnDestroy(); // 0x0000000187184670-0x00000001871846B0
		private void _LoadSprite(string path); // 0x0000000186BB6380-0x0000000186BB66A0
	}

	public class UILoadImageSpriteByName : UILoadImageSprite // TypeDefIndex: 74618
	{
		// Fields
		[SerializeField]
		private string _folderPath; // 0x48
	
		// Properties
		public string spriteName { set; } // 0x0000000186BB6280-0x0000000186BB6320
	
		// Constructors
		public UILoadImageSpriteByName(); // 0x000000018548CC60-0x000000018548CC80
	}

	[DisallowMultipleComponent]
	public class UIRaycastAreaVisualizer : MonoBehaviour // TypeDefIndex: 74619
	{
		// Constructors
		public UIRaycastAreaVisualizer(); // 0x00000001878364A0-0x00000001878364B8
	}

	public abstract class UISwitchTween // TypeDefIndex: 74626
	{
		// Fields
		private Options m_options; // 0x10
		private ITweenHandler m_tween; // 0x20
		private bool m_isInited; // 0x28
		private bool m_isShowing; // 0x29
		private TweenContext m_context; // 0x2C
	
		// Properties
		public bool isTweening { get; } // 0x00000001863F7B00-0x00000001863F7B60 
		public bool isShow { get; set; } // 0x000000018D248418-0x000000018D24845C 0x00000001861516C0-0x0000000186151700
	
		// Nested types
		public struct Options // TypeDefIndex: 74620
		{
			// Fields
			[CompilerGenerated]
			private Action _onShown_k__BackingField; // 0x00
			[CompilerGenerated]
			private Action _onHiden_k__BackingField; // 0x08
	
			// Properties
			public Action onShown { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184431970-0x0000000184431980 0x00000001878380EC-0x00000001878380F4
			public Action onHiden { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001844AFA30-0x00000001844AFA40 0x0000000188AC06FC-0x0000000188AC070C
		}
	
		protected struct TweenContext // TypeDefIndex: 74621
		{
			// Fields
			public float lastStopPos; // 0x00
	
			// Methods
			public bool IsInterapted(); // 0x000000018D24470C-0x000000018D2447A4
			public void OnReset(); // 0x00000001861525C0-0x00000001861525F0
			public void OnTweenStop(ITweenProgress tweenProgress); // 0x0000000186152550-0x00000001861525C0
		}
	
		public interface ITweenHandler : IHotfixable // TypeDefIndex: 74622
		{
			// Methods
			ITweenHandler SetAutoKill(bool autoKill);
			ITweenHandler OnComplete(TweenCallback callback);
			bool IsPlaying();
			void KillIfNecessary();
		}
	
		public interface ITweenProgress : IHotfixable // TypeDefIndex: 74623
		{
			// Methods
			float GetCurrPos();
		}
	
		public class TweenWrapper : ITweenHandler // TypeDefIndex: 74624
		{
			// Fields
			private DG.Tweening.Tween m_tween; // 0x10
	
			// Constructors
			public TweenWrapper(DG.Tweening.Tween tween); // 0x0000000184FD2410-0x0000000184FD2420
	
			// Methods
			public bool IsActive(); // 0x000000018D2449BC-0x000000018D244A00
			public bool IsPlaying(); // 0x00000001863F7B60-0x00000001863F7BA0
			public void KillIfNecessary(); // 0x00000001861525F0-0x0000000186152630
			public ITweenHandler OnComplete(TweenCallback callback); // 0x0000000186152270-0x0000000186152330
			public ITweenHandler SetAutoKill(bool autoKill); // 0x0000000186152330-0x00000001861523B0
		}
	
		[CompilerGenerated]
		private sealed class _WaitForTweening_d__19 : IEnumerator<object> // TypeDefIndex: 74625
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UISwitchTween __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForTweening_d__19(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D244D64-0x000000018D244DC0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D244DC0-0x000000018D244E0C
		}
	
		// Constructors
		protected UISwitchTween(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected abstract ITweenHandler GenerateTweenOfShow();
		protected abstract ITweenHandler GenerateTweenOfHide();
		protected virtual void BeforeShowEffect(); // 0x000000018D248278-0x000000018D2482AC
		protected virtual void BeforeHideEffect(); // 0x00000001861523B0-0x00000001861523E0
		protected virtual void AfterShowEffect(); // 0x0000000186F86400-0x0000000186F86430
		protected virtual void AfterHideEffect(); // 0x000000018D248244-0x000000018D248278
		protected virtual void ResetToState(bool isShow); // 0x000000018D2482EC-0x000000018D248324
		public void Show(); // 0x0000000186151700-0x0000000186151830
		public void Hide(); // 0x0000000186151830-0x0000000186151960
		[IteratorStateMachine(typeof(_WaitForTweening_d__19))]
		public IEnumerator WaitForTweening(); // 0x000000018D248380-0x000000018D248418
		public void SetOptions(Options options); // 0x000000018D248324-0x000000018D248380
		public void Reset(bool isShow); // 0x00000001861523E0-0x0000000186152440
		public void Clear(); // 0x0000000186D43690-0x0000000186D436C0
		private void _ClearTweenInternal(bool isReset); // 0x0000000186152440-0x00000001861524E0
		protected TweenContext GetContext(); // 0x000000018D2482AC-0x000000018D2482EC
		protected void ClearTween(); // 0x00000001861524E0-0x0000000186152550
		[CompilerGenerated]
		private void _Show_b__17_0(); // 0x0000000186F863D0-0x0000000186F86400
		[CompilerGenerated]
		private void _Hide_b__18_0(); // 0x000000018707EA90-0x000000018707EAC0
	}

	public class FadeSwitchTween : UISwitchTween // TypeDefIndex: 74629
	{
		// Fields
		public const float DEFAULT_TWEEN_DURATION = 0.16f; // Metadata: 0x02628488
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
		protected bool dontDisableGameObject { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225DFB0-0x000000018225DFC0 0x000000018225DFC0-0x000000018225DFD0
		protected bool controlBlockRaycast { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018226EE60-0x000000018226EE70 0x000000018226EE70-0x000000018226EE80
		protected Durations complexDuration { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187258E10-0x0000000187258E20 0x0000000187258E20-0x0000000187258E30
		public float duration { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187233590-0x00000001872335A0 0x00000001872335A0-0x00000001872335B0
		public CanvasGroup alphaHandler { get; } // 0x000000018D23EAD8-0x000000018D23EB18 
		public float activeAlpha { get; set; } // 0x000000018D23EA94-0x000000018D23EAD8 0x000000018D23EB18-0x000000018D23EB94
	
		// Nested types
		public struct Durations // TypeDefIndex: 74627
		{
			// Fields
			public float show; // 0x00
			public float showDelay; // 0x04
			public float hide; // 0x08
			public float hideDelay; // 0x0C
	
			// Methods
			public float GetShowDuration(float defaultDuration); // 0x0000000186A652A0-0x0000000186A652D0
			public float GetHideDuration(float defaultDuration); // 0x0000000186A65270-0x0000000186A652A0
		}
	
		public struct Builder // TypeDefIndex: 74628
		{
			// Fields
			public CanvasGroup alphaHandler; // 0x00
			public bool useTimeScale; // 0x08
			public bool dontDisableGameObject; // 0x09
			public bool controlBlockRaycast; // 0x0A
			public float duration; // 0x0C
			public Durations complexDuration; // 0x10
	
			// Methods
			public FadeSwitchTween Build(); // 0x00000001863F68C0-0x00000001863F69A0
		}
	
		// Constructors
		public FadeSwitchTween(CanvasGroup alphaHandler, bool ignoreTimeScale); // 0x000000018D23EA70-0x000000018D23EA94
		public FadeSwitchTween(CanvasGroup alphaHandler, float duration = 0.16f /* Metadata: 0x02628483 */, bool ignoreTimeScale = true /* Metadata: 0x02628487 */); // 0x00000001863F69A0-0x00000001863F6AA0
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide(); // 0x0000000186A65110-0x0000000186A65270
		protected override ITweenHandler GenerateTweenOfShow(); // 0x0000000186A64FB0-0x0000000186A65110
		protected sealed override void BeforeShowEffect(); // 0x00000001869F13A0-0x00000001869F1400
		protected sealed override void AfterHideEffect(); // 0x00000001869F1400-0x00000001869F1440
		protected sealed override void ResetToState(bool isShow); // 0x00000001869F1440-0x00000001869F14B0
		protected virtual void SetObjectActive(CanvasGroup alphaHandler, bool isActive); // 0x00000001869F14B0-0x00000001869F1530
		public void Release(); // 0x000000018D23EA38-0x000000018D23EA70
		public void __iFixBaseProxy_BeforeShowEffect(); // 0x000000018D215DB4-0x000000018D215DBC
		public void __iFixBaseProxy_AfterHideEffect(); // 0x000000018D215DAC-0x000000018D215DB4
		public void __iFixBaseProxy_ResetToState(bool P0); // 0x000000018D215DBC-0x000000018D215DC4
	}

	public class FadeTranslationSwitchTween : UISwitchTween // TypeDefIndex: 74631
	{
		// Fields
		private const float DEFAULT_TWEEN_DURATION = 0.16f; // Metadata: 0x02628498
		private CanvasGroup m_alphaHandler; // 0x30
		private RectTransform m_posHandler; // 0x38
		private Vector2 m_hidePos; // 0x40
		private Vector2 m_showPos; // 0x48
		private float m_duration; // 0x50
		private float m_hideDelay; // 0x54
		private float m_showDelay; // 0x58
	
		// Nested types
		private class TweenHandler : UISwitchTween.ITweenHandler // TypeDefIndex: 74630
		{
			// Fields
			private DG.Tweening.Tween m_alphaTweener; // 0x10
			private DG.Tweening.Tween m_posTweener; // 0x18
	
			// Constructors
			public TweenHandler(DG.Tweening.Tween alpha, DG.Tweening.Tween pos); // 0x0000000185381AC0-0x0000000185381AF0
	
			// Methods
			public bool IsPlaying(); // 0x000000018D2447A4-0x000000018D244808
			public void KillIfNecessary(); // 0x000000018D244808-0x000000018D24488C
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback); // 0x000000018D24488C-0x000000018D24491C
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill); // 0x000000018D24491C-0x000000018D2449BC
		}
	
		// Constructors
		public FadeTranslationSwitchTween(CanvasGroup alphaHandler, RectTransform posHandler, Vector2 hidePos, Vector2 showPos, float duration = 0.16f /* Metadata: 0x0262848C */, float hideDelay = 0f /* Metadata: 0x02628490 */, float showDelay = 0f /* Metadata: 0x02628494 */); // 0x000000018D23F040-0x000000018D23F14C
	
		// Methods
		protected override ITweenHandler GenerateTweenOfHide(); // 0x000000018D23EC54-0x000000018D23ED98
		protected override ITweenHandler GenerateTweenOfShow(); // 0x000000018D23ED98-0x000000018D23EEDC
		protected override void BeforeShowEffect(); // 0x000000018D23EBF4-0x000000018D23EC54
		protected override void AfterHideEffect(); // 0x000000018D23EB94-0x000000018D23EBF4
		protected override void ResetToState(bool isShow); // 0x000000018D23EEDC-0x000000018D23EFA0
		private float _GetTargetAlpha(bool isShow); // 0x000000018D23EFA0-0x000000018D23EFE8
		private Vector2 _GetTargetPos(bool isShow); // 0x000000018D23EFE8-0x000000018D23F040
		public void __iFixBaseProxy_BeforeShowEffect(); // 0x000000018D215DB4-0x000000018D215DBC
		public void __iFixBaseProxy_AfterHideEffect(); // 0x000000018D215DAC-0x000000018D215DB4
		public void __iFixBaseProxy_ResetToState(bool P0); // 0x000000018D215DBC-0x000000018D215DC4
	}

	public class UIAtlasManager : Singleton<UIAtlasManager> // TypeDefIndex: 74637
	{
		// Fields
		private TickFunction m_lateTickFunction; // 0x10
		public const int ATLAS_PAGE_WIDTH = 2048; // Metadata: 0x0262849C
		public const int ATLAS_PAGE_HEIGHT = 1024; // Metadata: 0x0262849E
		public const int IMAGE_USING_ATLAS_MAX_SIZE = 512; // Metadata: 0x026284A0
		public const int UI_IMAGE_BLOCK_ALIGNMENT = 4; // Metadata: 0x026284A2
		public const int PANEL_LEVEL_COUNT = 4; // Metadata: 0x026284A3
		public const int MAX_ATLAS_PER_PANEL_LEVEL = 4; // Metadata: 0x026284A4
		public const int PROCESS_COUNT_PER_FRAME = 3; // Metadata: 0x026284A5
		public const GraphicsFormat ATLAS_PAGE_FORMAT = GraphicsFormat.RGBA_BC7_UNorm; // Metadata: 0x026284A6
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
		public static bool enableRuntimeAtlas { get; } // 0x00000001853AA530-0x00000001853AA590 
		public static bool enableRuntimeAtlasFromScript { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D247020-0x000000018D247058 0x000000018D247090-0x000000018D2470CC
		public static bool releaseImageSpriteAfterInsert { get; } // 0x000000018D247058-0x000000018D247090 
	
		// Nested types
		public enum UIAtlasProcessStatus // TypeDefIndex: 74632
		{
			Invalid = 0,
			InsertWaiting = 1,
			InsertDone = 2
		}
	
		public enum UIAtlasProcessFailureCause // TypeDefIndex: 74633
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
	
		public struct UIAtlasHandle // TypeDefIndex: 74634
		{
			// Fields
			public UIAtlasProcessStatus status; // 0x00
			public UIAtlasProcessFailureCause failureCause; // 0x04
			public int panelLevel; // 0x08
			public int atlasIndex; // 0x0C
			public RectInt atlasRect; // 0x10
			public int textureId; // 0x20
	
			// Constructors
			public UIAtlasHandle(UIAtlasProcessStatus status, UIAtlasProcessFailureCause failureCause, int panelLevel, int atlasIndex, RectInt atlasRect, int textureId); // 0x0000000187258E30-0x0000000187258E60
	
			// Methods
			public bool IsValid(); // 0x000000018D245574-0x000000018D2455B0
			public static UIAtlasHandle CreateInvalidHandle(UIAtlasProcessFailureCause cause = UIAtlasProcessFailureCause.NoFailure /* Metadata: 0x026284BA */); // 0x000000018548F350-0x000000018548F3A0
		}
	
		public class UIAtlasPage // TypeDefIndex: 74636
		{
			// Fields
			[CompilerGenerated]
			private readonly Texture2D _pageTexture_k__BackingField; // 0x10
			[CompilerGenerated]
			private readonly Dictionary<int, TextureRefHandle> _textureRefDict_k__BackingField; // 0x18
			[CompilerGenerated]
			private readonly AtlasMaxRect _rectBinPack_k__BackingField; // 0x20
	
			// Properties
			public int maxFreeRectWidth { get; } // 0x000000018D247614-0x000000018D247668 
			public int maxFreeRectHeight { get; } // 0x000000018D2475C0-0x000000018D247614 
			public Texture2D pageTexture { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
			public Dictionary<int, TextureRefHandle> textureRefDict { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
			public AtlasMaxRect rectBinPack { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
	
			// Nested types
			public struct TextureRefHandle // TypeDefIndex: 74635
			{
				// Fields
				public int refCount; // 0x00
				public RectInt rect; // 0x04
	
				// Constructors
				public TextureRefHandle(int refCount, RectInt rect); // 0x000000018724A2F0-0x000000018724A300
			}
	
			// Constructors
			public UIAtlasPage(int panelDepth, int index, GraphicsFormat atlasFormat); // 0x000000018D247428-0x000000018D2475C0
	
			// Methods
			public RectInt InsertRect(int width, int height); // 0x000000018D24733C-0x000000018D2473C0
			public void CopyIntoAtlas(CommandBuffer cmd, Texture texture, [IsReadOnly] in RectInt rect); // 0x000000018D2470CC-0x000000018D247288
			public void InsertRects(List<RectInt> rects, List<RectInt> dst); // 0x000000018D2473C0-0x000000018D247428
			public void FreeRect([IsReadOnly] in RectInt rect); // 0x000000018D247288-0x000000018D2472E0
			public void FreeRects([IsReadOnly] in List<RectInt> rects); // 0x000000018D2472E0-0x000000018D24733C
		}
	
		// Constructors
		private UIAtlasManager(); // 0x000000018D246FE8-0x000000018D247020
	
		// Methods
		protected void OnInit(); // 0x000000018D245758-0x000000018D245958
		protected void OnUnInit(); // 0x000000018D245958-0x000000018D245990
		public void Release(); // 0x000000018D245A18-0x000000018D245A50
		private void _CreateTickFunction(); // 0x000000018D245E8C-0x000000018D245FB8
		private void _ClearTickFunction(); // 0x000000018D245E28-0x000000018D245E8C
		public static void AddUIImageToManager(UIImage image); // 0x000000018D2455B0-0x000000018D245638
		public static void ReProcessInsertForUIImage(UIImage image); // 0x000000018D245990-0x000000018D245A18
		public static void RemoveUIImageFromManager(UIImage image); // 0x0000000185BF1DC0-0x0000000185BF1E20
		public static void AddUIImageToManagerOnInstantiate(UIImage image); // 0x0000000185BF1D80-0x0000000185BF1DC0
		public int GetAtlasCount(); // 0x000000018D245638-0x000000018D2456FC
		public void LateTick(float deltaTime); // 0x000000018D2456FC-0x000000018D245758
		private void _AddUIImageToManager(UIImage image); // 0x000000018D245D24-0x000000018D245E28
		private void _ReProcessInsertForUIImage(UIImage image); // 0x000000018D246D0C-0x000000018D246E7C
		private void _RemoveUIImageFromManager(UIImage image); // 0x000000018D246E7C-0x000000018D246FE8
		private void _AddUIImageToManagerOnInstantiate(UIImage image); // 0x000000018D245A50-0x000000018D245D24
		private bool _IsRuntimeAtlasCompatible(UIImage image, out UIAtlasProcessFailureCause failureCause); // 0x000000018D245FB8-0x000000018D2462D0
		private void _ProcessInsertQueue(); // 0x000000018D2462D0-0x000000018D246A38
		private void _ProcessRemoveQueue(); // 0x000000018D246A38-0x000000018D246D0C
	}

	public class UICharHeadGlowAnimation : Singleton<UICharHeadGlowAnimation> // TypeDefIndex: 74638
	{
		// Fields
		private GameObject m_root; // 0x10
		private UICharHeadGlowAnimationSource m_source; // 0x18
		private Material m_firstMaterial; // 0x20
		private Material m_secondMaterial; // 0x28
		private HashSet<UICharHeadGlowAnimationNode> m_nodes; // 0x30
	
		// Constructors
		private UICharHeadGlowAnimation(); // 0x0000000184E62F70-0x0000000184E63800
	
		// Methods
		public void Init(GameObject animationRoot); // 0x0000000184E5F660-0x0000000184E60FB0
		public void UnInit(); // 0x0000000184E62040-0x0000000184E62F70
		public void AddNode(UICharHeadGlowAnimationNode node); // 0x0000000184E5EFA0-0x0000000184E5F660
		public void RemoveNode(UICharHeadGlowAnimationNode node); // 0x0000000184E60FB0-0x0000000184E61910
		public void SetForShare(bool isSharing); // 0x0000000184E61910-0x0000000184E62040
	}

	public class UICharHeadGlowAnimationNode : MonoBehaviour // TypeDefIndex: 74639
	{
		// Fields
		[SerializeField]
		private RawImage _firstLayer; // 0x18
		[SerializeField]
		private RawImage _secondLayer; // 0x20
	
		// Constructors
		public UICharHeadGlowAnimationNode(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void SetMaterials(Material firstMaterial, Material secondMaterial); // 0x0000000184E5EA80-0x0000000184E5EEA0
		private void OnEnable(); // 0x0000000184E5E730-0x0000000184E5EA80
		private void OnDisable(); // 0x0000000184E5E3E0-0x0000000184E5E730
	}

	public class UICharHeadGlowAnimationSource : MonoBehaviour // TypeDefIndex: 74640
	{
		// Fields
		[SerializeField]
		private Canvas _canvas; // 0x18
		[SerializeField]
		private UIAnimationWrapper _loopAnimation; // 0x20
		[SerializeField]
		private UIMaterialAnimation _firstLayer; // 0x28
		[SerializeField]
		private UIMaterialAnimation _secondLayer; // 0x30
	
		// Properties
		public Canvas canvas { get; } // 0x0000000184E5EEA0-0x0000000184E5EEE0 
		public UIAnimationWrapper loopAnimation { get; } // 0x0000000184E5EF20-0x0000000184E5EF60 
		public UIMaterialAnimation firstLayer { get; } // 0x0000000184E5EEE0-0x0000000184E5EF20 
		public UIMaterialAnimation secondLayer { get; } // 0x0000000184E5EF60-0x0000000184E5EFA0 
	
		// Constructors
		public UICharHeadGlowAnimationSource(); // 0x00000001878364A0-0x00000001878364B8
	}

	public class UIRedDotAnimation : Singleton<UIRedDotAnimation> // TypeDefIndex: 74641
	{
		// Fields
		private UIGraphicAnimation m_uiGraphicAnimation; // 0x10
		private Material m_materialInstance; // 0x18
		private HashSet<UIImage> m_redDotImages; // 0x20
		private GameObject m_root; // 0x28
	
		// Constructors
		private UIRedDotAnimation(); // 0x000000018717F7C0-0x000000018717F850
	
		// Methods
		public void Init(GameObject redDotAnimationRoot); // 0x0000000186DFB610-0x0000000186DFB8B0
		public void UnInit(); // 0x000000018D2476A8-0x000000018D247870
		public void AddRedDotImage(UIImage img); // 0x00000001852DED60-0x00000001852DEE10
		public void RemoveRedDotImage(UIImage img); // 0x00000001852DEE80-0x00000001852DEEF0
		private void _UpdateRedDotAnimation(); // 0x00000001852DEE10-0x00000001852DEE80
	}

	public class UIRedDotAnimationNode : MonoBehaviour // TypeDefIndex: 74642
	{
		// Fields
		private UIImage m_image; // 0x18
	
		// Constructors
		public UIRedDotAnimationNode(); // 0x000000018548CC60-0x000000018548CC80
	
		// Methods
		private void Awake(); // 0x0000000185324580-0x00000001853245D0
		private void OnEnable(); // 0x00000001852DECD0-0x00000001852DED60
		private void OnDisable(); // 0x00000001852DEC40-0x00000001852DECD0
	}

	public static class WebApplication // TypeDefIndex: 74645
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0 // TypeDefIndex: 74643
		{
			// Fields
			public string url; // 0x10
			public Action onClose; // 0x18
	
			// Constructors
			public __c__DisplayClass0_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _Start_b__0(int i, string s); // 0x000000018D244A00-0x000000018D244AF8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0 // TypeDefIndex: 74644
		{
			// Fields
			public string url; // 0x10
			public Action onClose; // 0x18
	
			// Constructors
			public __c__DisplayClass1_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _StartHGBrowser_b__0(string s); // 0x000000018D244AF8-0x000000018D244BE8
		}
	
		// Methods
		public static void Start(string url, Action onClose = null); // 0x000000018D248F00-0x000000018D2490CC
		public static void StartHGBrowser(string url, Action onClose = null); // 0x000000018D248D34-0x000000018D248F00
	}
}

namespace Beyond.UI.GPUI
{
	[Flags]
	internal enum ChangeState // TypeDefIndex: 74670
	{
		Stable = 0,
		New = 1,
		ChangeSize = 2,
		ChangeData = 4
	}

	internal struct RuntimeNodeInfo // TypeDefIndex: 74671
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

	internal class RuntimeAnimationData // TypeDefIndex: 74672
	{
		// Fields
		public string name; // 0x10
		public float duration; // 0x18
		public List<GPUInstanceData> template; // 0x20
	
		// Constructors
		public RuntimeAnimationData(); // 0x0000000185CFD6D0-0x0000000185CFD750
	}

	internal class RuntimePrefabData // TypeDefIndex: 74673
	{
		// Fields
		public int templateNodeCount; // 0x10
		public List<RuntimeNodeInfo> nodes; // 0x18
		public Dictionary<string, int> nodesNameMap; // 0x20
		public List<RuntimeAnimationData> animations; // 0x28
	
		// Constructors
		public RuntimePrefabData(); // 0x0000000185CFDCD0-0x0000000185CFDDF0
	}

	public struct GPUIExtendedPrefabData // TypeDefIndex: 74674
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
		public const float INVALID_ANI_FILL_V = -1f; // Metadata: 0x0262850B
		public const byte WRAP_MODE_CLAMP = 0; // Metadata: 0x0262850F
		public const byte WRAP_MODE_LOOP = 1; // Metadata: 0x02628510
		public const byte FILL_ORIGIN_MASK = 15; // Metadata: 0x02628511
		public const byte FILL_CLOCKWISE_BIT = 16; // Metadata: 0x02628512
	
		// Constructors
		public GPUIExtendedPrefabData(ExtendedNodeSerializeData data); // 0x000000018612C1C0-0x000000018612C2B0
	
		// Methods
		private static byte _NormalizeWrapMode(UnityEngine.WrapMode wrapMode); // 0x000000018612C2B0-0x000000018612C2E0
		private static byte _PackFillOriginFlags(int fillOrigin, bool fillClockwise); // 0x000000018612C2E0-0x000000018612C320
		public static GPUIExtendedPrefabData CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x0000000186942DF0-0x0000000186942EE0
	}

	public struct GPUIExtendedPrefabDataLite // TypeDefIndex: 74675
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
		private const int FILL_TYPE_SHIFT = 0; // Metadata: 0x02628513
		private const int FILL_ORIGIN_SHIFT = 4; // Metadata: 0x02628514
		private const int FILL_CLOCKWISE_SHIFT = 8; // Metadata: 0x02628515
		private const int WRAP_MODE_SHIFT = 9; // Metadata: 0x02628516
		private const ushort FILL_META_MASK = 15; // Metadata: 0x02628517
	
		// Constructors
		public GPUIExtendedPrefabDataLite(ExtendedNodeSerializeData data, Vector2 texelSizeInv, Vector2 aniTexelSizeInv); // 0x000000018D23FB20-0x000000018D23FEB4
		public GPUIExtendedPrefabDataLite(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x000000018D23F9F4-0x000000018D23FB20
	
		// Methods
		private static byte _NormalizeWrapMode(UnityEngine.WrapMode wrapMode); // 0x000000018D23F9BC-0x000000018D23F9F4
		public static GPUIExtendedPrefabDataLite CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x000000018D23F8F0-0x000000018D23F9BC
	}

	public struct GPUIExtendedInstanceData // TypeDefIndex: 74676
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
		public const ushort INVALID_NODE_ID = 65535; // Metadata: 0x02628519
		public const byte INVALID_FILL_OVERRIDE = 255; // Metadata: 0x0262851B
	}

	public struct GPUIRootTransformState // TypeDefIndex: 74677
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Vector3 scale; // 0x1C
	
		// Properties
		public static GPUIRootTransformState Default { get; } // 0x0000000185CDF4B0-0x0000000185CDF520 
	}

	public struct GPUISubrootDomainState // TypeDefIndex: 74678
	{
		// Fields
		public Vector2 position; // 0x00
		public Vector2 scale; // 0x08
		public float rotationZ; // 0x10
		public bool visible; // 0x14
	
		// Properties
		public static GPUISubrootDomainState Default { get; } // 0x0000000185451C40-0x0000000185451CA0 
	}

	public struct GPUIExtendedAnimationState // TypeDefIndex: 74679
	{
		// Fields
		public int animationIndex; // 0x00
		public float animationTime; // 0x04
		public float animationDuration; // 0x08
		public bool initialized; // 0x0C
	
		// Properties
		public static GPUIExtendedAnimationState Default { get; } // 0x0000000185CE0220-0x0000000185CE0260 
	}

	public struct GPUIExtendedSubrootInfo // TypeDefIndex: 74680
	{
		// Fields
		public string subrootName; // 0x00
		public int anchorNodeIndex; // 0x08
	}

	public struct GPUIResolvedSubrootState // TypeDefIndex: 74681
	{
		// Fields
		public Vector3 position; // 0x00
		public Quaternion rotation; // 0x0C
		public Vector3 scale; // 0x1C
		public bool visible; // 0x28
	}

	public static class GPUIExtendedTransformUtility // TypeDefIndex: 74682
	{
		// Methods
		public static GPUIResolvedSubrootState ResolveSubroot([IsReadOnly] in GPUIRootTransformState root, [IsReadOnly] in GPUISubrootDomainState subroot); // 0x0000000185452220-0x0000000185452400
	}

	public struct GPUIExtendedRuntimeNodeInfo // TypeDefIndex: 74683
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

	public class GPUIExtendedRuntimeAnimationData // TypeDefIndex: 74684
	{
		// Fields
		public string name; // 0x10
		public int subrootIndex; // 0x18
		public float duration; // 0x1C
		public List<GPUIExtendedInstanceData> template; // 0x20
	
		// Constructors
		public GPUIExtendedRuntimeAnimationData(); // 0x0000000186B24A10-0x0000000186B24A90
	}

	public class GPUIExtendedRuntimePrefabData // TypeDefIndex: 74685
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
		public GPUIExtendedRuntimePrefabData(); // 0x0000000186AF4D50-0x0000000186AF4F70
	}

	public static class GPUIExtendedPackingUtility // TypeDefIndex: 74686
	{
		// Fields
		private const float SNORM16_SCALE = 32767f; // Metadata: 0x0262851C
	
		// Methods
		public static uint PackPrefabAndParent(ushort prefabId, ushort parentId); // 0x000000018D23F868-0x000000018D23F8AC
		public static uint PackGrandParentMatTypeAndDrawType(ushort grandParentId, byte matType, byte drawType); // 0x000000018D23F810-0x000000018D23F868
		public static uint PackRootScaleY(float scaleY); // 0x000000018544F790-0x000000018544F7C0
		public static uint PackUInt16Pair(ushort low, ushort high); // 0x000000018D23F8AC-0x000000018D23F8F0
		public static int PackFillOverrideByte(byte fillOverride); // 0x000000018D23F7CC-0x000000018D23F810
		public static int PackTextScale(float scale); // 0x0000000185D1A620-0x0000000185D1A650
		public static void PackQuaternion(Quaternion rotation, out int packedAuxiliary0, out int packedAuxiliary1); // 0x000000018544FD40-0x0000000185450210
		private static short _PackSnorm16(float value); // 0x0000000185450210-0x0000000185450320
	}

	public static class GPUILayoutInfo // TypeDefIndex: 74687
	{
		// Properties
		public static int LegacyPrefabStride { get; } // 0x000000018D240164-0x000000018D2401CC 
		public static int LegacyPrefabLiteStride { get; } // 0x000000018D2400FC-0x000000018D240164 
		public static int LegacyInstanceStride { get; } // 0x000000018D240094-0x000000018D2400FC 
		public static int ExtendedPrefabStride { get; } // 0x000000018D23FF84-0x000000018D23FFEC 
		public static int ExtendedPrefabLiteStride { get; } // 0x000000018D23FF1C-0x000000018D23FF84 
		public static int ExtendedInstanceStride { get; } // 0x000000018D23FEB4-0x000000018D23FF1C 
		public static bool IsLegacyLayoutAligned { get; } // 0x000000018D240040-0x000000018D240094 
		public static bool IsExtendedLayoutAligned { get; } // 0x000000018D23FFEC-0x000000018D240040 
	}

	public struct GPUPrefabData // TypeDefIndex: 74688
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
		public GPUPrefabData(NodeSerializeData data); // 0x0000000185CFD980-0x0000000185CFDA20
		public GPUPrefabData(Vector4 uv, Vector4 scale); // 0x0000000186852550-0x0000000186852580
	
		// Methods
		public static GPUPrefabData CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x00000001868524E0-0x0000000186852550
	}

	public struct GPUPrefabDataLite // TypeDefIndex: 74689
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
		public GPUPrefabDataLite(NodeSerializeData data, Vector2 texelSizeInv, Vector2 aniTexelSizeInv); // 0x000000018D240298-0x000000018D240508
		public GPUPrefabDataLite(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x000000018D240508-0x000000018D240600
	
		// Methods
		public static GPUPrefabDataLite CreateFontNode(Vector4 uv, Vector4 scale, Vector2 texelSizeInv); // 0x000000018D2401CC-0x000000018D240298
	}

	public struct GPUInstanceData // TypeDefIndex: 74690
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

	public enum GPUILayoutType // TypeDefIndex: 74691
	{
		Legacy = 0,
		Extended = 1
	}

	public enum GPUIImageFillType // TypeDefIndex: 74692
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		Radial360 = 3
	}

	public enum NodeType // TypeDefIndex: 74693
	{
		Root = 0,
		Image = 1,
		Text = 2,
		Fill = 3
	}

	public enum SimpleTextAlignment // TypeDefIndex: 74694
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	[Serializable]
	public class NodeSerializeData // TypeDefIndex: 74695
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
		public NodeSerializeData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class ExtendedNodeSerializeData // TypeDefIndex: 74696
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
		public ExtendedNodeSerializeData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class NodeMetadata // TypeDefIndex: 74697
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
		public NodeMetadata(); // 0x00000001844F3D70-0x00000001844F3D80
	}

	[Serializable]
	public class SubrootSerializeData // TypeDefIndex: 74698
	{
		// Fields
		public string subrootName; // 0x10
		public int anchorNodeIndex; // 0x18
	
		// Constructors
		public SubrootSerializeData(); // 0x0000000187234900-0x0000000187234910
	}

	[Serializable]
	public class AnimationSerializeData // TypeDefIndex: 74699
	{
		// Fields
		public string animationName; // 0x10
		public float animationTime; // 0x18
		public int totalFrames; // 0x1C
		public UnityEngine.WrapMode wrapMode; // 0x20
		public int renderNodesOffset; // 0x24
	
		// Constructors
		public AnimationSerializeData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class ExtendedAnimationSerializeData // TypeDefIndex: 74700
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
		public ExtendedAnimationSerializeData(); // 0x0000000186A16CB0-0x0000000186A16D30
	}

	[Serializable]
	public class PrefabSerializeData // TypeDefIndex: 74701
	{
		// Fields
		public string prefabName; // 0x10
		public int nodeCount; // 0x18
		public bool animationOnly; // 0x1C
		public List<NodeMetadata> nodeMetas; // 0x20
		public List<NodeSerializeData> renderNodes; // 0x28
		public List<AnimationSerializeData> animations; // 0x30
	
		// Constructors
		public PrefabSerializeData(); // 0x000000018697E830-0x000000018697E950
	}

	[Serializable]
	public class ExtendedPrefabSerializeData // TypeDefIndex: 74702
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
		public ExtendedPrefabSerializeData(); // 0x000000018697E660-0x000000018697E7C0
	}

	[Serializable]
	public class PrefabGroupSerializeData : IMemoryPackSerialize // TypeDefIndex: 74703
	{
		// Fields
		public GPUILayoutType layoutType; // 0x10
		public StringPathHash spriteTexturePath; // 0x18
		public StringPathHash vatTexturePath; // 0x20
		public List<PrefabSerializeData> prefabs; // 0x28
		public List<string> textIds; // 0x30
		public string importantChars; // 0x38
	
		// Constructors
		public PrefabGroupSerializeData(); // 0x0000000186FC52E0-0x0000000186FC53A0
	}

	[Serializable]
	public class ExtendedPrefabGroupSerializeData : IMemoryPackSerialize // TypeDefIndex: 74704
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
		public ExtendedPrefabGroupSerializeData(); // 0x0000000186D3FCE0-0x0000000186D3FDD0
	}

	internal abstract class BaseRuntimeInstance<TData> // TypeDefIndex: 74705
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

	internal class CodePoint // TypeDefIndex: 74706
	{
		// Fields
		public const uint HIGH_SURROGATE_START = 55296; // Metadata: 0x0262852D
		public const uint HIGH_SURROGATE_END = 56319; // Metadata: 0x02628531
		public const uint LOW_SURROGATE_START = 56320; // Metadata: 0x02628535
		public const uint LOW_SURROGATE_END = 57343; // Metadata: 0x02628539
		public const uint UNICODE_PLANE01_START = 65536; // Metadata: 0x0262853D
	
		// Constructors
		public CodePoint(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate); // 0x000000018D23E6BC-0x000000018D23E700
	}

	internal abstract class BaseTextSystem<T> // TypeDefIndex: 74710
		where T : struct
	{
		// Fields
		protected const float DEFAULT_WHITESPACE_SPACING = 0.27f; // Metadata: 0x02628541
		protected const uint DEFAULT_TEXT_COLOR = 4294967295; // Metadata: 0x02628545
		protected const float DEFAULT_RICH_TEXT_SCALE = 1f; // Metadata: 0x02628546
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
		protected readonly List<uint> m_richTextColorStack;
		protected readonly List<float> m_richTextSizeStack;
	
		// Nested types
		protected struct CharOffsetData // TypeDefIndex: 74707
		{
			// Fields
			public float scale;
			public float xAdvance;
			public float xOffset;
			public float yOffset;
			public int prefabIndex;
			public uint color;
			public float richSizeScale;
		}
	
		protected enum RichTextTagType // TypeDefIndex: 74708
		{
			None = 0,
			OpenColor = 1,
			CloseColor = 2,
			OpenSize = 3,
			CloseSize = 4
		}
	
		protected struct RichTextTagData // TypeDefIndex: 74709
		{
			// Fields
			public RichTextTagType<T> tagType;
			public int length;
			public uint color;
			public float sizeScale;
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
		protected void ResetRichTextState(out uint currentColor, out float currentRichSizeScale);
		protected static CharOffsetData ApplyRichTextStyle(CharOffsetData offsetData, uint color, float richSizeScale);
		[IFixIgnore]
		protected void ApplyRichTextTag(RichTextTagData tagData, ref uint currentColor, ref float currentRichSizeScale);
		[IFixIgnore]
		protected static bool TryParseSupportedRichTextTag(string text, int startIndex, out RichTextTagData tagData);
		protected static bool TryParseNoParseOpenTag(string text, int startIndex, out int tagLength);
		protected static bool TryParseNoParseCloseTag(string text, int startIndex, out int tagLength);
		[IFixIgnore]
		protected static bool TryParseHexColor(string text, int startIndex, int length, out uint color);
		protected static bool TryParseHexByte(char high, char low, out byte value);
		protected static bool TryParseHexNibble(char c, out int value);
		[IFixIgnore]
		protected static bool TryParsePercentScale(string text, int startIndex, int length, out float scale);
		protected static uint PackColor(byte r, byte g, byte b, byte a);
	}

	internal sealed class ExInstanceBufferManager<TInstance, TData> : InstanceBufferManagerBase<TInstance, TData> // TypeDefIndex: 74712
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
		private struct BufferInternalNode // TypeDefIndex: 74711
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

	public sealed class GPUIExtendedDynamicAtlas : IDisposable // TypeDefIndex: 74716
	{
		// Fields
		public const int DEFAULT_PADDING = 0; // Metadata: 0x02628550
		public const int IMAGE_USING_ATLAS_MAX_SIZE = 512; // Metadata: 0x02628551
		private readonly Dictionary<int, SpriteRecord> m_spriteRecords; // 0x10
		private UICustomAtlasHandle m_atlasHandle; // 0x18
		private Texture2D m_runtimeTexture; // 0x20
		private RectInt m_dynamicRect; // 0x28
		private bool m_initialized; // 0x38
	
		// Properties
		public Texture2D runtimeTexture { get; } // 0x000000018544D3F0-0x000000018544D4C0 
		public RectInt dynamicAtlasRect { get; } // 0x000000018D23F38C-0x000000018D23F3E8 
		public bool isInitialized { get; } // 0x000000018D23F3E8-0x000000018D23F42C 
	
		// Nested types
		public enum DynamicAtlasFailureCause // TypeDefIndex: 74713
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
	
		public struct DynamicSpriteHandle // TypeDefIndex: 74714
		{
			// Fields
			public Sprite sprite; // 0x00
			public int spriteInstanceId; // 0x08
	
			// Methods
			public bool IsValid(); // 0x000000018612B4B0-0x000000018612B4E0
			public static DynamicSpriteHandle CreateInvalidHandle(); // 0x000000018612AF90-0x000000018612AFD0
		}
	
		private sealed class SpriteRecord // TypeDefIndex: 74715
		{
			// Fields
			public Sprite sprite; // 0x10
			public int spriteInstanceId; // 0x18
			public int refCount; // 0x1C
			public Vector4 uv; // 0x20
	
			// Constructors
			public SpriteRecord(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public GPUIExtendedDynamicAtlas(Texture staticTexture, RectInt dynamicRect, int padding = 0 /* Metadata: 0x0262854F */); // 0x0000000186B1D140-0x0000000186B1D1F0
	
		// Methods
		[IDTag(1)]
		public void Initialize(Texture staticTexture, RectInt dynamicRect); // 0x0000000186B1D1F0-0x0000000186B1D290
		[IDTag(0)]
		public void Initialize(Texture2D staticTexture, RectInt dynamicRect); // 0x0000000186B1D290-0x0000000186B1D3A0
		public bool Acquire(Sprite sprite, out DynamicSpriteHandle handle, out Vector4 uv); // 0x000000018612AC40-0x000000018612AEB0
		[IDTag(1)]
		public bool Release(DynamicSpriteHandle handle); // 0x000000018D23F208-0x000000018D23F278
		[IDTag(0)]
		public bool Release(DynamicSpriteHandle handle, out bool fullyReleased); // 0x000000018612A7A0-0x000000018612A8B0
		public void Dispose(); // 0x0000000186B1D470-0x0000000186B1D520
		public UICustomAtlasCopyStatus GetAtlasStatus(); // 0x000000018544B220-0x000000018544B290
		private bool _TryValidateSprite(Sprite sprite, out DynamicAtlasFailureCause failureCause); // 0x000000018612BC40-0x000000018612BE40
		private bool _IsValidStaticTexture(Texture2D staticTexture); // 0x0000000186B1D640-0x0000000186B1D760
		private bool _IsValidDynamicAtlasRect(Texture2D staticTexture, RectInt dynamicRect); // 0x0000000186B1D520-0x0000000186B1D640
		private bool _IsAtlasCreationValid(UICustomAtlasCopyStatus status); // 0x0000000186B1D3A0-0x0000000186B1D3E0
		private static Vector2Int _GetSpriteContentSize(Sprite sprite); // 0x000000018612BE40-0x000000018612BEB0
		private static int _GetSpriteInstanceId(Sprite sprite); // 0x000000018612AFD0-0x000000018612B010
		private static void _LogFailure(Sprite sprite, DynamicAtlasFailureCause failureCause); // 0x000000018D23F278-0x000000018D23F38C
	}

	internal sealed class GPUIExtendedDynamicPrefabNodeManager : IDisposable // TypeDefIndex: 74719
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
		public struct DynamicPrefabNodeKey : IEquatable<DynamicPrefabNodeKey> // TypeDefIndex: 74717
		{
			// Fields
			public readonly int basePrefabOffset; // 0x00
			public readonly Sprite sprite; // 0x08
			public readonly int spriteInstanceId; // 0x10
	
			// Constructors
			public DynamicPrefabNodeKey(int basePrefabOffset, Sprite sprite); // 0x00000001854520C0-0x0000000185452180
	
			// Methods
			[IDTag(0)]
			public bool Equals(DynamicPrefabNodeKey other); // 0x0000000185452070-0x00000001854520C0
			[IDTag(1)]
			public override bool Equals(object obj); // 0x000000018D24B4D0-0x000000018D24B588
			public override int GetHashCode(); // 0x00000001863C4C70-0x00000001863C4CA0
			private static int _GetSpriteInstanceId(Sprite sprite); // 0x0000000185452180-0x0000000185452220
			public bool __iFixBaseProxy_Equals(object P0); // 0x000000018D24B588-0x000000018D24B5F0
			public int __iFixBaseProxy_GetHashCode(); // 0x000000018D24B5F0-0x000000018D24B648
		}
	
		private sealed class DynamicPrefabNodeEntry // TypeDefIndex: 74718
		{
			// Fields
			public DynamicPrefabNodeKey key; // 0x10
			public ushort dynamicPrefabId; // 0x28
			public int refCount; // 0x2C
	
			// Constructors
			public DynamicPrefabNodeEntry(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public GPUIExtendedDynamicPrefabNodeManager(SimpleBufferManager<GPUIExtendedPrefabData> prefabBufferManager, GPUIExtendedPrefabData[] prefabMirror, int capacity); // 0x00000001859D70B0-0x00000001859D7270
		public GPUIExtendedDynamicPrefabNodeManager(SimpleBufferManager<GPUIExtendedPrefabDataLite> prefabBufferManager, GPUIExtendedPrefabDataLite[] prefabMirror, Vector2 spriteTexelSizeInv, int capacity); // 0x000000018D23F604-0x000000018D23F7CC
	
		// Methods
		public void Dispose(); // 0x000000018D23F42C-0x000000018D23F51C
		public void RegisterSpriteUV(Sprite sprite, Vector4 spriteUv); // 0x000000018612B010-0x000000018612B080
		public void UnregisterSpriteUV(Sprite sprite); // 0x000000018612A710-0x000000018612A7A0
		public bool TryAcquire(int basePrefabOffset, Sprite sprite, out DynamicPrefabNodeKey key, out ushort dynamicPrefabId); // 0x000000018612B720-0x000000018612BA50
		public void Release(DynamicPrefabNodeKey key); // 0x000000018612B530-0x000000018612B680
		public void FlushIfNeeded(); // 0x000000018544D4C0-0x000000018544DAE0
		private void _ReserveSlots<T>(SimpleBufferManager<T> bufferManager, int capacity)
			where T : struct;
		private static void _SetLiteUV(ref GPUIExtendedPrefabDataLite data, Vector4 spriteUv, Vector2 spriteTexelSizeInv); // 0x000000018D23F51C-0x000000018D23F604
		private static int _GetSpriteInstanceId(Sprite sprite); // 0x000000018612B080-0x000000018612B0C0
	}

	internal sealed class GPUIExtendedDynamicSpriteOverrideManager // TypeDefIndex: 74720
	{
		// Fields
		private readonly GPUIExtendedDynamicAtlas m_dynamicAtlas; // 0x10
		private readonly GPUIExtendedDynamicPrefabNodeManager m_dynamicPrefabNodeManager; // 0x18
	
		// Constructors
		public GPUIExtendedDynamicSpriteOverrideManager(GPUIExtendedDynamicAtlas dynamicAtlas, GPUIExtendedDynamicPrefabNodeManager dynamicPrefabNodeManager); // 0x0000000185381AC0-0x0000000185381AF0
	
		// Methods
		public bool TryAcquireDynamicSprite(Sprite sprite, out GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle); // 0x000000018612AEB0-0x000000018612AF90
		[IDTag(0)]
		public bool TryAcquireDynamicPrefabNode(int basePrefabOffset, Sprite sprite, out GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey key, out ushort dynamicPrefabId); // 0x000000018612B6C0-0x000000018612B720
		[IDTag(1)]
		public bool TryAcquireDynamicPrefabNode(int basePrefabOffset, GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle, out GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey key, out ushort dynamicPrefabId); // 0x000000018612B680-0x000000018612B6C0
		public bool MatchesDynamicPrefabNode(GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey key, int basePrefabOffset, GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle); // 0x0000000185451ED0-0x0000000185452070
		public void ReleaseDynamicPrefabNode(GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey key); // 0x000000018612B4E0-0x000000018612B530
		public void ReleaseDynamicSprite(GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle); // 0x000000018612BEB0-0x000000018612BF30
	}

	internal sealed class GPUIExtendedRuntimeInstance : BaseRuntimeInstance<GPUIExtendedInstanceData> // TypeDefIndex: 74722
	{
		// Fields
		public const int ROOT_NODE_INDEX = 0; // Metadata: 0x0262855D
		public const uint INVALID_NODE_ID = 4294967295; // Metadata: 0x0262855E
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
		public GPUIExtendedRuntimePrefabData Prefab { get; } // 0x000000018D24BA18-0x000000018D24BA58 
		public float AnimationDuration { get; } // 0x000000018D24B9D4-0x000000018D24BA18 
	
		// Nested types
		private struct SpriteOverrideState // TypeDefIndex: 74721
		{
			// Fields
			public bool enabled; // 0x00
			public GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle; // 0x08
			public GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey activeKey; // 0x18
			public ushort dynamicPrefabId; // 0x30
		}
	
		// Constructors
		public GPUIExtendedRuntimeInstance(); // 0x0000000185CE01F0-0x0000000185CE0220
	
		// Methods
		public void Create(GPUIExtendedRuntimePrefabData prefab, IExtendedTextSystem textSystem, GPUIExtendedDynamicSpriteOverrideManager dynamicSpriteOverrideManager = null); // 0x0000000185CDEFD0-0x0000000185CDF4B0
		public override void Recycle(); // 0x0000000186A0B530-0x0000000186A0B580
		public override void DoUpdate(ref NativeArray<GPUIExtendedInstanceData> buffer, int startIndexInBuffer, bool full); // 0x0000000185450320-0x0000000185451050
		public void SetRootPosition(Vector3 position); // 0x0000000185CDED30-0x0000000185CDED70
		public void SetRootScale(Vector2 scale); // 0x0000000185C05FA0-0x0000000185C05FF0
		public void SetRootRotation(Quaternion rotation); // 0x0000000185CDEC40-0x0000000185CDEC70
		public void StartAnimation(float animationTime, int animationIndex = 0 /* Metadata: 0x0262855C */); // 0x0000000185CDC880-0x0000000185CDC8F0
		public bool StartSubrootAnimation(int subrootIndex, float animationTime, int animationIndex); // 0x0000000186A451B0-0x0000000186A452E0
		public void SetNodeVisibility(int index, bool visible); // 0x0000000185AD5C50-0x0000000185AD5CB0
		public void SetNodeColor(int index, UnityEngine.Color color); // 0x0000000185AD5E00-0x0000000185AD5EA0
		public void SetNodeFillAmount(int index, float fillAmount); // 0x000000018535AEE0-0x000000018535AF50
		public void SetSubrootState(int subrootIndex, Vector2 position, Vector2 scale, float rotationZ); // 0x000000018D24B710-0x000000018D24B814
		public void SetSubrootVisibility(int subrootIndex, bool visible); // 0x0000000185CDC260-0x0000000185CDC2F0
		public void SetText(int index, string text); // 0x0000000185FCEB20-0x0000000185FCEC50
		public bool SetSpriteOverride(int index, GPUIExtendedDynamicAtlas.DynamicSpriteHandle spriteHandle); // 0x000000018612B0C0-0x000000018612B2C0
		public bool ClearSpriteOverride(int index); // 0x000000018612ABF0-0x000000018612AC40
		public void ClearDynamicSpriteOverrides(); // 0x000000018D24B648-0x000000018D24B710
		public void UpdateDynamicSpriteContext(GPUIExtendedDynamicSpriteOverrideManager dynamicSpriteOverrideManager); // 0x000000018D24B814-0x000000018D24B854
		private void _WriteRootNode(ref NativeArray<GPUIExtendedInstanceData> buffer, int startIndexInBuffer, ref int indexInBuffer, GPUIExtendedInstanceData templateNode); // 0x000000018544F7C0-0x000000018544FD40
		private void _WriteSubrootProxyNodes(ref NativeArray<GPUIExtendedInstanceData> buffer, int startIndexInBuffer, ref int indexInBuffer); // 0x0000000185451CA0-0x0000000185451E90
		private void _InitializeAnimationStates(); // 0x0000000185CDF520-0x0000000185CDF660
		private GPUIExtendedAnimationState _GetAnimationStateForNode([IsReadOnly] in GPUIExtendedRuntimeNodeInfo node); // 0x0000000185451180-0x0000000185451210
		private int _FindPreferredRootAnimationIndex(); // 0x0000000185CDF660-0x0000000185CDF8B0
		private GPUIExtendedRuntimeAnimationData _GetAnimationData(int animationIndex); // 0x0000000185451050-0x00000001854510D0
		private int _FindFirstAnimationIndex(int subrootIndex); // 0x0000000185CDFDB0-0x0000000185CDFE30
		private int _FindDefaultSubrootAnimationIndex(int subrootIndex); // 0x0000000185CE0260-0x0000000185CE0350
		private void _ApplySpriteOverride(int nodeIndex, ref GPUIExtendedInstanceData templateNode); // 0x0000000185451270-0x0000000185451C40
		private bool _TryPrimeSpriteOverride(int index, ref SpriteOverrideState overrideState); // 0x000000018612B380-0x000000018612B4B0
		private bool _TryPrimeSpriteOverrideWithReleasedSlot(int index, ref SpriteOverrideState previousState, ref SpriteOverrideState nextState); // 0x000000018D24B854-0x000000018D24B9D4
		private bool _TryResolveCurrentBasePrefabOffset(int index, out int basePrefabOffset); // 0x000000018612BA50-0x000000018612BC40
		private void _ReleaseSpriteOverrideResources([IsReadOnly] in SpriteOverrideState overrideState); // 0x000000018612B2C0-0x000000018612B380
		private void _ClearSpriteOverride(int index); // 0x0000000185452400-0x0000000185452500
		private void _ClearAllSpriteOverrides(); // 0x0000000185452500-0x0000000185452560
		private static uint _UnpackPrefabId(uint packedPrefabParent); // 0x0000000185451150-0x0000000185451180
		private static bool _HasActivePrefabNode([IsReadOnly] in SpriteOverrideState overrideState); // 0x0000000185451E90-0x0000000185451ED0
		private static byte _PackFillOverride(float fillAmount); // 0x0000000185451210-0x0000000185451270
	}

	public class GPUIExtendedSystem : GPUISharedGraphicBase // TypeDefIndex: 74723
	{
		// Fields
		private const string DEFAULT_SHADER_NAME = "HGRP/UI/GPUUI/TextV3Extended"; // Metadata: 0x02628561
		private const int MAX_PREFAB_BUFFER_SIZE = 328; // Metadata: 0x0262857E
		private const int SIMPLE_INSTANCE_INIT_CAPACITY = 256; // Metadata: 0x02628580
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
		public TMP_FontAsset fontAsset { get; set; } // 0x00000001867DD790-0x00000001867DD8E0 0x000000018D24BE48-0x000000018D24BF54
	
		// Events
		private event Action m_beforeRenderSync {
			add; // 0x0000000185BC0E80-0x0000000185BC0F20
			remove; // 0x0000000185BC0F20-0x0000000185BC0FC0
		}
	
		// Constructors
		public GPUIExtendedSystem(); // 0x0000000185D93680-0x0000000185D93840
	
		// Methods
		protected TMP_FontAsset GetFontAsset(); // 0x00000001867DE680-0x00000001867DE700
		protected override void InitMaterials(); // 0x00000001852DD230-0x00000001852DD670
		public void RegisterBeforeRenderSync(Action callback); // 0x0000000185BC0D00-0x0000000185BC0D50
		public void UnregisterBeforeRenderSync(Action callback); // 0x000000018D24BDF4-0x000000018D24BE48
		public bool CreateInstance(string prefabName, Vector3 initialPosition, out GPUIHandle handle, int sortingOrder = 0 /* Metadata: 0x0262855F */); // 0x0000000185CDED70-0x0000000185CDEEC0
		public bool DestroyInstance(GPUIHandle handle); // 0x00000001867C4880-0x00000001867C4950
		public bool IsInstanceValid(GPUIHandle handle); // 0x000000018535B9C0-0x000000018535BA40
		public bool SetRootPosition(GPUIHandle handle, Vector3 position); // 0x0000000185CDEC70-0x0000000185CDED30
		public bool SetRootScale(GPUIHandle handle, Vector2 scale); // 0x0000000185C05EF0-0x0000000185C05FA0
		public bool SetRootRotation(GPUIHandle handle, Quaternion rotation); // 0x0000000185CDEB80-0x0000000185CDEC40
		public bool SetNodeVisibility(GPUIHandle handle, string nodeName, bool visible); // 0x0000000185AD5BB0-0x0000000185AD5C50
		public bool SetSubrootVisibility(GPUIHandle handle, string subrootName, bool visible); // 0x0000000185CDC130-0x0000000185CDC260
		public bool SetSubrootTransform(GPUIHandle handle, string subrootName, Vector2 position, Vector2 scale, float rotationZ); // 0x000000018D24BC4C-0x000000018D24BDD4
		public bool SetColor(GPUIHandle handle, string nodeName, UnityEngine.Color color); // 0x0000000185AD5D50-0x0000000185AD5E00
		public bool SetImageFillAmount(GPUIHandle handle, string nodeName, float fillAmount); // 0x000000018535ABE0-0x000000018535AEE0
		public bool SetText(GPUIHandle handle, string nodeName, string text); // 0x0000000185FCEA80-0x0000000185FCEB20
		public bool SetSprite(GPUIHandle handle, string nodeName, Sprite sprite); // 0x000000018612AA10-0x000000018612ABF0
		[IDTag(1)]
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, string animationName); // 0x0000000185CDC6D0-0x0000000185CDC7B0
		[IDTag(0)]
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, int animationIndex = 0 /* Metadata: 0x02628560 */); // 0x0000000185CDC7B0-0x0000000185CDC880
		public bool TryGetAnimationDuration(GPUIHandle handle, string animationName, out float duration); // 0x0000000185CDC8F0-0x0000000185CDC9E0
		public bool StartSubrootAnimation(GPUIHandle handle, string subrootName, string animationName); // 0x0000000186A44E50-0x0000000186A45020
		public bool TryGetSubrootAnimationDuration(GPUIHandle handle, string subrootName, string animationName, out float duration); // 0x0000000186A45020-0x0000000186A451B0
		private void _DisposeLoadedTextures(); // 0x00000001870906B0-0x0000000187090710
		protected override void OnDestroy(); // 0x000000018D24BA58-0x000000018D24BB94
		protected override void OnEnable(); // 0x00000001867DD340-0x00000001867DD450
		protected override void OnDisable(); // 0x000000018D24BB94-0x000000018D24BC4C
		private void _OnPreWillRenderCanvases(); // 0x000000018544C890-0x000000018544CC00
		private void _Init(string jsonPath); // 0x00000001867DD490-0x00000001867DD790
		private void _EnsureInstanceBufferManager(bool useSimpleInstanceBuffer); // 0x00000001867DDDB0-0x00000001867DDF90
		private bool _TryResolveAndValidateGroupBufferConfig(ExtendedPrefabGroupSerializeData groupData, out int prefabBufferSize, out int fontPrefabBufferSize); // 0x00000001867DD8E0-0x00000001867DDA40
		private static int _CalculateRequiredPrefabBufferSize(List<ExtendedPrefabSerializeData> prefabs); // 0x0000000185CFACA0-0x0000000185CFAE00
		private void _DoLateUpdate(); // 0x000000018544CC00-0x000000018544CCF0
		private void _RenderNodes(); // 0x000000018544CF80-0x000000018544D3B0
		private void _DestroyAnimatedInstance(); // 0x000000018544CCF0-0x000000018544CD40
		private void _PreloadText(ExtendedPrefabGroupSerializeData data); // 0x0000000185CFB6A0-0x0000000185CFBB90
		private void _LoadGroupData(ExtendedPrefabGroupSerializeData data); // 0x0000000185CFAE00-0x0000000185CFB6A0
		private GPUIExtendedRuntimePrefabData _LoadPrefabData(ExtendedPrefabSerializeData prefab); // 0x0000000185452560-0x0000000185453FF0
		private void _InitPrefabBufferManager(bool hasTextNodes, int prefabBufferSize, int fontPrefabBufferSize); // 0x00000001867DE2D0-0x00000001867DE680
		private static int _FindAnchorNodeIndex(List<NodeMetadata> nodeMetas, string subrootName); // 0x0000000185CFC740-0x0000000185CFC870
		private int _LoadPrefabNodeBuffer(ExtendedPrefabSerializeData prefab, int totalNodeCount); // 0x000000018612BF30-0x000000018612C1C0
		private void _InitDynamicPrefabNodeManager(ExtendedPrefabGroupSerializeData data); // 0x00000001859D6CB0-0x00000001859D6E60
		private bool _CanSubmitInstanceRange(); // 0x000000018544BCC0-0x000000018544BED0
		private void _ResetLiveDynamicSpriteState(); // 0x0000000186BD25F0-0x0000000186BD2770
		private void _UpdateLiveDynamicSpriteContext(); // 0x0000000186BD2770-0x0000000186BD2910
		private void _SyncDynamicAtlasRuntimeTexture(); // 0x000000018544CD40-0x000000018544CF80
		private GPUIHandle _GetOneHandle(); // 0x0000000185CDEEC0-0x0000000185CDEFD0
		private bool _IsHandleInvalid(GPUIHandle handle); // 0x000000018535BA40-0x000000018535BAC0
		private bool _TryResolveNode(GPUIHandle handle, string nodeName, out GPUIExtendedRuntimeInstance instance, out int nodeIndex); // 0x000000018535B1C0-0x000000018535B3B0
		public void __iFixBaseProxy_InitMaterials(); // 0x000000018D24BDD4-0x000000018D24BDDC
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D24BDDC-0x000000018D24BDE4
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D24BDEC-0x000000018D24BDF4
		public void __iFixBaseProxy_OnDisable(); // 0x000000018D24BDE4-0x000000018D24BDEC
	}

	internal interface IExtendedTextSystem // TypeDefIndex: 74724
	{
		// Methods
		void RegisterCharacterToPrefabBuffer(string text);
		void UploadBufferIfNeeded();
		int GetNodeCount(string text);
		void CreateTextNodes(string text, NativeArray<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float textScale = 1f /* Metadata: 0x02628582 */, bool isBold = false /* Metadata: 0x02628586 */);
		void CreateTextNodes(string text, List<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float textScale = 1f /* Metadata: 0x02628587 */, bool isBold = false /* Metadata: 0x0262858B */);
		void CreateTextNodesAutoSize(string text, NativeArray<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float autoSizeWidth, float nodeTextSize, float autoSizeMinScale, bool isBold = false /* Metadata: 0x0262858C */);
		void CreateTextNodesAutoSize(string text, List<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float autoSizeWidth, float nodeTextSize, float autoSizeMinScale, bool isBold = false /* Metadata: 0x0262858D */);
	}

	internal sealed class GPUIExtendedTextSystem<T> : BaseTextSystem<T>, IExtendedTextSystem // TypeDefIndex: 74725
		where T : struct
	{
		// Constructors
		public GPUIExtendedTextSystem(int fontBufferCapacity, Func<Vector4, Vector4, Vector2, T> prefabCreatorFunc);
	
		// Methods
		public void CreateTextNodes(string text, NativeArray<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float textScale = 1f /* Metadata: 0x0262858E */, bool isBold = false /* Metadata: 0x02628592 */);
		public void CreateTextNodes(string text, List<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float textScale = 1f /* Metadata: 0x02628593 */, bool isBold = false /* Metadata: 0x02628597 */);
		public void CreateTextNodesAutoSize(string text, NativeArray<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float autoSizeWidth, float nodeTextSize, float autoSizeMinScale, bool isBold = false /* Metadata: 0x02628598 */);
		public void CreateTextNodesAutoSize(string text, List<GPUIExtendedInstanceData> dest, int startIndex, int capacity, int parentId, int secondaryParentId, SimpleTextAlignment alignment, float autoSizeWidth, float nodeTextSize, float autoSizeMinScale, bool isBold = false /* Metadata: 0x02628599 */);
		private GPUIExtendedInstanceData _CreateGlyphInstance(CharOffsetData<T> textWidth, float currentX, int parentId, int secondaryParentId, float textScale, bool isBold);
	}

	public struct GPUIHandle : IEquatable<GPUIHandle> // TypeDefIndex: 74726
	{
		// Fields
		public int index; // 0x00
		public int version; // 0x04
	
		// Methods
		[IDTag(0)]
		public bool Equals(GPUIHandle other); // 0x000000018544AD00-0x000000018544AD40
		[IDTag(1)]
		public override bool Equals(object obj); // 0x000000018D24BF54-0x000000018D24BFF8
		public override int GetHashCode(); // 0x0000000186046C90-0x0000000186046CC0
		public static bool operator ==(GPUIHandle left, GPUIHandle right); // 0x000000018544ACB0-0x000000018544AD00
		public static bool operator !=(GPUIHandle left, GPUIHandle right); // 0x0000000185C06FA0-0x0000000185C06FE0
		public bool __iFixBaseProxy_Equals(object P0); // 0x000000018D24BFF8-0x000000018D24C058
		public int __iFixBaseProxy_GetHashCode(); // 0x000000018D24C058-0x000000018D24C0A8
	}

	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public class GPUIPrefabProxyBase : MonoBehaviour // TypeDefIndex: 74727
	{
		// Fields
		private const float POSITION_SYNC_EPSILON = 0.01f; // Metadata: 0x0262859B
		private const float SCALE_SYNC_EPSILON = 0.001f; // Metadata: 0x0262859F
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
		private bool m_transformDirty; // 0x53
		private bool m_hasSyncedTransform; // 0x54
		private bool m_isActive; // 0x55
		private Vector2 m_lastCanvasLocalPosition; // 0x58
		private Vector2 m_lastRootScale; // 0x60
		private Vector2 m_rootScaleMultiplier; // 0x68
	
		// Properties
		public string prefabName { get; } // 0x000000018D24C35C-0x000000018D24C39C 
		public bool autoCreate { get; } // 0x000000018D24C29C-0x000000018D24C2E0 
		public int sortingOrder { get; } // 0x000000018D24C39C-0x000000018D24C3DC 
		public GPUIExtendedSystem targetSystem { get; } // 0x000000018D24C41C-0x000000018D24C45C 
		public GPUIProxySyncManager syncManager { get; } // 0x000000018D24C3DC-0x000000018D24C41C 
		public GPUIHandle handle { get; } // 0x000000018D24C2E0-0x000000018D24C320 
		public bool hasInstance { get; } // 0x000000018D24C320-0x000000018D24C35C 
	
		// Constructors
		public GPUIPrefabProxyBase(); // 0x0000000186B142A0-0x0000000186B142D0
	
		// Methods
		public void SetSyncManager(GPUIProxySyncManager syncManager); // 0x0000000185C06720-0x0000000185C06990
		public bool TryCreateInstance(); // 0x0000000185CDFE30-0x0000000185CE0140
		public bool TryDestroyInstance(); // 0x0000000185C07140-0x0000000185C07370
		[IDTag(1)]
		public bool TrySyncTransform(); // 0x0000000184F07E60-0x0000000184F07F00
		public void SetRootScaleMultiplier(Vector2 scale); // 0x0000000184F07DC0-0x0000000184F07E60
		public void MarkTransformDirty(); // 0x0000000184F07D10-0x0000000184F07D50
		public bool IsHandleValid(); // 0x000000018535B860-0x000000018535B9C0
		protected virtual void OnInstanceCreated(); // 0x0000000185CE0140-0x0000000185CE0170
		protected virtual void OnInstanceDestroyed(); // 0x0000000186BF79D0-0x0000000186BF7A00
		internal void TryPrepareForBeforeRender(); // 0x000000018569E950-0x000000018569E980
		[IDTag(0)]
		internal bool TrySyncTransform(RectTransform targetCanvasRect, Camera targetCamera, bool forceSync = false /* Metadata: 0x0262859A */); // 0x0000000184F07F00-0x0000000184F08360
		[IDTag(2)]
		internal bool TrySyncTransform(RectTransform targetCanvasRect, Camera targetCamera, bool forceSync, Vector3 canvasWorldScale); // 0x0000000184F08360-0x0000000184F08790
		private bool _ShouldSyncTransform(bool forceSync); // 0x0000000184F08790-0x0000000184F08B70
		private bool _SyncTransform(RectTransform targetCanvasRect, Camera targetCamera, bool forceSync, Vector3 targetCanvasScale); // 0x0000000184F08B70-0x0000000184F08EA0
		protected virtual void Awake(); // 0x0000000186BCA110-0x0000000186BCA140
		protected virtual void OnEnable(); // 0x0000000185C061C0-0x0000000185C06230
		protected virtual void OnDisable(); // 0x0000000185C05570-0x0000000185C055C0
		protected virtual void OnDestroy(); // 0x0000000184F07D50-0x0000000184F07DC0
		protected virtual void OnRectTransformDimensionsChange(); // 0x00000001869FA940-0x00000001869FA970
		protected virtual void OnTransformParentChanged(); // 0x000000018D24C0E0-0x000000018D24C228
		protected virtual void OnDidApplyAnimationProperties(); // 0x000000018D24C0A8-0x000000018D24C0E0
		private void _CacheRectTransform(); // 0x0000000185C06230-0x0000000185C06290
		private bool _TryResolveRuntimeReferences(); // 0x000000018D24C228-0x000000018D24C29C
		private bool _TryResolveSyncManager(); // 0x0000000185C06990-0x0000000185C06A30
		private bool _TryResolveTargetSystem(); // 0x0000000185C06A30-0x0000000185C06B50
		private void _HandleTargetSystemChanged(GPUIExtendedSystem oldTargetSystem); // 0x0000000185C06CB0-0x0000000185C06FA0
		private bool _TryResolveTargetCanvas(out RectTransform targetCanvasRect, out Camera targetCamera); // 0x0000000186704F40-0x0000000186705150
		private bool _TryGetCanvasLocalPosition(RectTransform targetCanvasRect, Camera targetCamera, out Vector2 canvasLocalPosition); // 0x00000001856BC2B0-0x00000001856BC610
	}

	[DisallowMultipleComponent]
	[RequireComponent(typeof(GPUIExtendedSystem))]
	public class GPUIProxySyncManager : MonoBehaviour // TypeDefIndex: 74729
	{
		// Fields
		private GPUIExtendedSystem m_targetSystem; // 0x18
		private GPUIExtendedSystem m_boundSystem; // 0x20
		private Vector3 m_canvasWorldScale; // 0x28
		private readonly List<GPUIPrefabProxyBase> m_activeProxies; // 0x38
		private CanvasSnapshot m_lastSnapshot; // 0x40
	
		// Properties
		public GPUIExtendedSystem targetSystem { get; } // 0x000000018D24C540-0x000000018D24C580 
	
		// Nested types
		private struct CanvasSnapshot // TypeDefIndex: 74728
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
		public GPUIProxySyncManager(); // 0x0000000186D42170-0x0000000186D42270
	
		// Methods
		public bool TryResolveTargetSystem(out GPUIExtendedSystem targetSystem); // 0x0000000185C06B50-0x0000000185C06C00
		public void RegisterProxy(GPUIPrefabProxyBase proxy); // 0x0000000185BC0AB0-0x0000000185BC0BA0
		public void UnregisterProxy(GPUIPrefabProxyBase proxy); // 0x00000001869A5270-0x00000001869A5320
		public void MarkDirty(GPUIPrefabProxyBase proxy); // 0x000000018D24C45C-0x000000018D24C508
		public void FlushBeforeRender(); // 0x000000018569CDF0-0x000000018569D9E0
		private void OnEnable(); // 0x0000000185BC0A40-0x0000000185BC0A80
		private void OnDisable(); // 0x000000018D24C508-0x000000018D24C540
		private void _AutoAssignTargetSystem(); // 0x0000000185C06C00-0x0000000185C06CB0
		private void _RegisterToSystem(); // 0x0000000185BC0BA0-0x0000000185BC0D00
		private void _UnregisterFromSystem(); // 0x0000000185BC10F0-0x0000000185BC11B0
		private static bool _TryResolveCanvasContext(Canvas canvas, out RectTransform canvasRect, out Camera camera); // 0x000000018569D9E0-0x000000018569DD30
		private bool _SnapshotAndCheckChanged(Canvas canvas, RectTransform canvasRect, Camera camera); // 0x000000018569DD30-0x000000018569E2F0
	}

	[RequireComponent(typeof(CanvasRenderer))]
	public abstract class GPUISharedGraphicBase : MaskableGraphic // TypeDefIndex: 74731
	{
		// Fields
		public static readonly string CONFIG_JSON_PATH_FORMAT; // 0x00
		public const int RENDER_BUFFER_INIT_CAPACITY = 400; // Metadata: 0x026285A4
		public const int RENDER_BUFFER_MAX_CAPACITY = 65535; // Metadata: 0x026285A6
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
		protected static class ShaderIDs // TypeDefIndex: 74730
		{
			// Fields
			internal static readonly int CANVAS_OBJECT_TO_WORLD_MATRIX; // 0x00
			internal static readonly int VAT_TEX; // 0x04
			internal static readonly int MAIN_TEX; // 0x08
			internal static readonly int SPRITE_TEX; // 0x0C
	
			// Constructors
			static ShaderIDs(); // 0x00000001870A28D0-0x00000001870A29A0
		}
	
		// Constructors
		protected GPUISharedGraphicBase(); // 0x0000000185D93BD0-0x0000000185D93CE0
		static GPUISharedGraphicBase(); // 0x000000018718D9E0-0x000000018718DA70
	
		// Methods
		protected void InitializeSharedState(); // 0x00000001867DDA40-0x00000001867DDC20
		protected void UpdateSharedTextures(Texture vatTexture, Texture fontTexture, Texture spriteTexture); // 0x00000001867DDF90-0x00000001867DE2D0
		protected void UpdateWorldMat(bool force = false /* Metadata: 0x026285A3 */); // 0x000000018544B6E0-0x000000018544BCC0
		protected virtual void InitMaterials(); // 0x00000001852DCCC0-0x00000001852DCF20
		protected void CleanMaterials(); // 0x00000001867DDC20-0x00000001867DDDB0
		protected override void OnPopulateMesh(VertexHelper vh); // 0x00000001856BD300-0x00000001856BD570
		protected override void UpdateMaterial(); // 0x00000001859F7BA0-0x00000001859F7CC0
		protected override void OnDestroy(); // 0x000000018D24C580-0x000000018D24C5D8
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D24C5D8-0x000000018D24C5E0
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0); // 0x000000018D1F6E38-0x000000018D1F6E40
		public void __iFixBaseProxy_UpdateMaterial(); // 0x000000018D24C5E0-0x000000018D24C5E8
	}

	[DisallowMultipleComponent]
	public class GPUISubrootTag : MonoBehaviour // TypeDefIndex: 74732
	{
		// Fields
		[SerializeField]
		private string _subrootName; // 0x18
	
		// Properties
		public string subrootName { get; } // 0x000000018D24C644-0x000000018D24C684 
	
		// Constructors
		public GPUISubrootTag(); // 0x000000018D24C5E8-0x000000018D24C644
	}

	public class GPUISystem : GPUISharedGraphicBase // TypeDefIndex: 74733
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
		public TMP_FontAsset fontAsset { get; set; } // 0x00000001867DD060-0x00000001867DD1B0 0x000000018D24CC88-0x000000018D24CD94
	
		// Constructors
		public GPUISystem(); // 0x0000000185D92740-0x0000000185D928F0
		static GPUISystem(); // 0x00000001871FC700-0x00000001871FC750
	
		// Methods
		public bool CreateInstance(string prefabName, Vector3 initialPosition, out GPUIHandle handle, int sortingOrder = 0 /* Metadata: 0x026285AA */); // 0x000000018544A080-0x000000018544A130
		public bool DestroyInstance(GPUIHandle handle); // 0x000000018544A720-0x000000018544A7A0
		public bool IsInstanceValid(GPUIHandle handle); // 0x000000018550CDB0-0x000000018550CE30
		public bool SetRootPosition(GPUIHandle handle, Vector3 position); // 0x000000018550CE30-0x000000018550CFA0
		public bool SetRootScale(GPUIHandle handle, Vector2 scale); // 0x000000018D24C794-0x000000018D24C884
		[IDTag(0)]
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, string animationName, bool resetDestroy = false /* Metadata: 0x026285AB */); // 0x000000018544AD40-0x000000018544B220
		[IDTag(1)]
		public bool StartAnimation(GPUIHandle handle, bool destroyWhenStopped, int animationIndex = 0 /* Metadata: 0x026285AC */, bool resetDestroy = false /* Metadata: 0x026285AD */); // 0x000000018D24C98C-0x000000018D24CBB4
		public bool SetVisibility(GPUIHandle handle, string nodeName, bool visible); // 0x000000018D24C884-0x000000018D24C98C
		public bool SetColor(GPUIHandle handle, string nodeName, UnityEngine.Color color); // 0x0000000185AD6CF0-0x0000000185AD6DF0
		public bool SetText(GPUIHandle handle, string nodeName, string text); // 0x0000000185447590-0x00000001854476A0
		protected override void OnDestroy(); // 0x000000018D24C684-0x000000018D24C6DC
		protected override void OnEnable(); // 0x00000001867DD230-0x00000001867DD340
		protected override void OnDisable(); // 0x000000018D24C6DC-0x000000018D24C794
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000187226730-0x0000000187226760
		protected override void UpdateMaterial(); // 0x00000001859F69E0-0x00000001859F6A10
		private void _PreWillRenderCanvases(); // 0x000000018544B6B0-0x000000018544B6E0
		private void _Init(string jsonPath); // 0x00000001867DCA80-0x00000001867DD060
		protected TMP_FontAsset GetFontAsset(); // 0x00000001867DD1B0-0x00000001867DD230
		private void _DoLateUpdate(); // 0x000000018544B540-0x000000018544B6B0
		private void _DisposeLoadedTextures(); // 0x00000001871F0650-0x00000001871F06B0
		private void _DoOnDestroy(); // 0x000000018D24CBC4-0x000000018D24CC88
		private void _RenderNodes(); // 0x000000018544B2B0-0x000000018544B440
		private void _DestroyAnimatedInstance(); // 0x000000018544B440-0x000000018544B540
		private void _PreloadTextInGroupData(PrefabGroupSerializeData data); // 0x0000000185CFBB90-0x0000000185CFC110
		private void _LoadGroupData(PrefabGroupSerializeData data); // 0x0000000185CFC110-0x0000000185CFC740
		private RuntimePrefabData _LoadPrefabData(PrefabSerializeData prefab); // 0x0000000185CFCAF0-0x0000000185CFD6D0
		private int _LoadPrefabNodeBuffer(PrefabSerializeData prefab, int totalNodeCount); // 0x0000000185CFD750-0x0000000185CFD980
		private bool _CreateInstance(string prefabName, out GPUIHandle handle, int sortingOrder); // 0x000000018544A130-0x000000018544A220
		private bool _DestroyInstance(GPUIHandle handle); // 0x000000018544A330-0x000000018544A3E0
		private GPUIHandle _GetOneHandle(); // 0x000000018544A220-0x000000018544A330
		private bool _IsHandleInvalid(GPUIHandle handle); // 0x000000018550CFA0-0x000000018550D020
		private void _RecycleOneHandle(GPUIHandle handle); // 0x000000018544A3E0-0x000000018544A430
		public void __iFixBaseProxy_OnDestroy(); // 0x000000018D24BDDC-0x000000018D24BDE4
		public void __iFixBaseProxy_OnEnable(); // 0x000000018D24BDEC-0x000000018D24BDF4
		public void __iFixBaseProxy_OnDisable(); // 0x000000018D24BDE4-0x000000018D24BDEC
		public void __iFixBaseProxy_OnPopulateMesh(VertexHelper P0); // 0x000000018D24CBB4-0x000000018D24CBBC
		public void __iFixBaseProxy_UpdateMaterial(); // 0x000000018D24CBBC-0x000000018D24CBC4
	}

	public static class GPUIUtils // TypeDefIndex: 74734
	{
		// Fields
		public static readonly Vector3 DEFAULT_NORMAL; // 0x00
		public static readonly Vector4 DEFAULT_TANGENT; // 0x0C
	
		// Constructors
		static GPUIUtils(); // 0x0000000186FD6820-0x0000000186FD6890
	
		// Methods
		public static Mesh CreateQuadMesh(); // 0x000000018D24CD94-0x000000018D24D1CC
		public static uint ColorToRGBAUint32(UnityEngine.Color color); // 0x0000000185AD6ED0-0x0000000185AD6F30
	}

	internal abstract class InstanceBufferManagerBase<TInstance, TData> : IDisposable // TypeDefIndex: 74735
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

	internal sealed class RuntimeInstance : BaseRuntimeInstance<GPUInstanceData> // TypeDefIndex: 74736
	{
		// Fields
		public const int ROOT_NODE_INDEX = 0; // Metadata: 0x026285AF
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
		public RuntimePrefabData Prefab { get; } // 0x000000018D24D580-0x000000018D24D5C0 
		public float AnimationDuration { get; } // 0x000000018D24D53C-0x000000018D24D580 
	
		// Constructors
		public RuntimeInstance(); // 0x0000000186F94DE0-0x0000000186F94E10
	
		// Methods
		public void Create(RuntimePrefabData prefab, ITextSystem textSystem); // 0x000000018544A430-0x000000018544A570
		public override void Recycle(); // 0x000000018670F130-0x000000018670F160
		public override void DoUpdate(ref NativeArray<GPUInstanceData> buffer, int startIndexInBuffer, bool full); // 0x00000001854493C0-0x00000001854497C0
		public void SetRootScale(Vector2 rootScale); // 0x000000018D24D40C-0x000000018D24D490
		public void SetPosition(int index, Vector3 position); // 0x000000018550D020-0x000000018550D0A0
		public void StartAnimation(float animationTime, int animationIndex = 0 /* Metadata: 0x026285AE */); // 0x000000018544A570-0x000000018544A5F0
		public void SetVisibility(int index, bool visible); // 0x000000018D24D490-0x000000018D24D53C
		public void SetColor(int index, UnityEngine.Color newColor); // 0x0000000185AD6DF0-0x0000000185AD6ED0
		public void SetText(int index, string text); // 0x00000001854479C0-0x0000000185447B60
	}

	internal class SimpleBufferManager<T> : IDisposable // TypeDefIndex: 74737
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

	internal sealed class SimpleInstanceBufferManager<TInstance, TData> : InstanceBufferManagerBase<TInstance, TData> // TypeDefIndex: 74738
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

	internal interface ITextSystem // TypeDefIndex: 74739
	{
		// Methods
		void RegisterCharacterToPrefabBuffer(string text);
		void UploadBufferIfNeeded();
		int GetNodeCount(string text);
		void CreateTextNodes(string text, NativeArray<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment);
		void CreateTextNodes(string text, List<GPUInstanceData> dest, int startIndex, int capacity, int parentId, int grandParentId, SimpleTextAlignment alignment);
	}

	internal sealed class SimpleTextSystem<T> : BaseTextSystem<T>, ITextSystem // TypeDefIndex: 74740
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
	internal class OnValueChangedAttribute : PropertyAttribute // TypeDefIndex: 74646
	{
		// Fields
		[CompilerGenerated]
		private readonly string _actionName_k__BackingField; // 0x10
	
		// Properties
		public string actionName { [CompilerGenerated] get; } // 0x00000001829260F0-0x0000000182926100 
	
		// Constructors
		public OnValueChangedAttribute(string name); // 0x0000000184FD2410-0x0000000184FD2420
	}

	public class StateAnimationInfo // TypeDefIndex: 74647
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
		public bool IsFinished { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829D0800-0x00000001829D0810 0x0000000182A819C0-0x0000000182A819D0
		public AnimationClip Clip { [CompilerGenerated] get; } // 0x0000000182234E30-0x0000000182234E40 
		public GameObject Target { [CompilerGenerated] get; } // 0x000000018225E800-0x000000018225E810 
		public float StartTime { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187233430-0x0000000187233440 0x0000000187233440-0x0000000187233450
	
		// Constructors
		public StateAnimationInfo(AnimationClip clip, GameObject target); // 0x000000018596F780-0x000000018596F7E0
	
		// Methods
		public void OnUpdate(); // 0x000000018596E670-0x000000018596E710
	}

	public enum AnimationImpactType // TypeDefIndex: 74648
	{
		StartAnimation = 0,
		StopAnimation = 1
	}

	[Serializable]
	public class StateDescription // TypeDefIndex: 74649
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
		public bool layoutGroupChildControlWidth; // 0x199
		public bool layoutGroupChildControlHeight; // 0x19A
		public bool layoutGroupChildScaleWidth; // 0x19B
		public bool layoutGroupChildScaleHeight; // 0x19C
		public bool layoutGroupChildForceExpandWidth; // 0x19D
		public bool layoutGroupChildForceExpandHeight; // 0x19E
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
		public bool IsEmpty { get; } // 0x0000000185972030-0x0000000185972420 
		public string ReadableDescription { get; } // 0x000000018D24329C-0x000000018D24462C 
		public Material ImageMaterialClone { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018723BEA0-0x000000018723BEB0 0x0000000188DC4804-0x0000000188DC4818
	
		// Constructors
		public StateDescription(); // 0x0000000185F01C40-0x0000000185F01CA0
	
		// Methods
		public bool EqualsAnimation(StateDescription other); // 0x000000018D2417A4-0x000000018D241848
		public float ApplyAnimation(StateReference state); // 0x000000018596F7E0-0x000000018596F940
		public bool EqualsAnimator(StateDescription other); // 0x000000018D241848-0x000000018D2418EC
		public void ApplyAnimator(); // 0x000000018D2415D4-0x000000018D2416E4
		public bool EqualsButton(StateDescription other); // 0x000000018D2418EC-0x000000018D241990
		public void ApplyButton(); // 0x000000018702C900-0x000000018702C950
		public bool EqualsCanvasGroup(StateDescription other); // 0x000000018D241990-0x000000018D241A3C
		public void ApplyCanvasGroup(); // 0x000000018596F6C0-0x000000018596F780
		public bool EqualsComponent(StateDescription other); // 0x000000018D241A3C-0x000000018D241AE8
		public void ApplyComponent(); // 0x0000000186ECFAA0-0x0000000186ECFAF0
		public override string ToString(); // 0x000000018D2423C0-0x000000018D242454
		public static bool operator ==(StateDescription left, StateDescription right); // 0x000000018D24462C-0x000000018D24467C
		public static bool operator !=(StateDescription left, StateDescription right); // 0x000000018D24467C-0x000000018D2446CC
		[IDTag(1)]
		public override bool Equals(object obj); // 0x000000018D2422D8-0x000000018D24236C
		public override int GetHashCode(); // 0x000000018D24236C-0x000000018D2423C0
		[IDTag(0)]
		public bool Equals(StateDescription other); // 0x000000018D24224C-0x000000018D2422D8
		private bool _EqualsByTargetType(StateDescription other); // 0x000000018D242454-0x000000018D242654
		private int _GetTargetHashCode(); // 0x000000018D242654-0x000000018D242730
		public bool EqualsGameObject(StateDescription other); // 0x000000018D241AE8-0x000000018D241B94
		public void ApplyGameObject(); // 0x0000000185972420-0x0000000185972490
		public bool EqualsGraphic(StateDescription other); // 0x000000018D241B94-0x000000018D241C40
		public void ApplyGraphic(); // 0x000000018D2416E4-0x000000018D241744
		public bool EqualsGridLayoutGroup(StateDescription other); // 0x000000018D241C40-0x000000018D241CEC
		public void ApplyGridLayoutGroup(); // 0x0000000187077C40-0x0000000187077D20
		private void _OnGridLayoutGroupChanged(); // 0x000000018D242730-0x000000018D242840
		public bool EqualsImage(StateDescription other); // 0x000000018D241CEC-0x000000018D241D98
		public void ApplyImage(); // 0x0000000185972490-0x0000000185972550
		private void _OnImageChanged(); // 0x000000018D242840-0x000000018D242994
		public bool EqualsLayoutElement(StateDescription other); // 0x000000018D241D98-0x000000018D241E44
		public void ApplyLayoutElement(); // 0x000000018596F940-0x000000018596FA50
		private void _OnLayoutElementChanged(); // 0x000000018D242994-0x000000018D242A64
		public bool EqualsLayoutGroup(StateDescription other); // 0x000000018D241E44-0x000000018D241EF0
		public void ApplyLayoutGroup(); // 0x000000018596F0D0-0x000000018596F600
		private void _OnLayoutGroupChanged(); // 0x000000018D242A64-0x000000018D242C20
		public bool EqualsRectTransform(StateDescription other); // 0x000000018D241EF0-0x000000018D241F9C
		public void ApplyRectTransform(); // 0x0000000185972700-0x0000000185972A80
		private void _OnRectTransformChanged(); // 0x000000018D242C20-0x000000018D2430D8
		public bool EqualsScrollList(StateDescription other); // 0x000000018D241F9C-0x000000018D242048
		public void ApplyScrollList(); // 0x0000000186AC7D40-0x0000000186AC7E80
		private void _OnScrollListChanged(); // 0x000000018D2430D8-0x000000018D2431B8
		public bool EqualsSelectable(StateDescription other); // 0x000000018D242048-0x000000018D2420F4
		public void ApplySelectable(); // 0x000000018D241744-0x000000018D2417A4
		public bool EqualsState(StateDescription other); // 0x000000018D2420F4-0x000000018D2421A0
		public float ApplyInnerState(); // 0x000000018596EAB0-0x000000018596EB00
		public bool EqualsText(StateDescription other); // 0x000000018D2421A0-0x000000018D24224C
		public void ApplyText(); // 0x0000000185972550-0x0000000185972700
		private void _OnTextChanged(); // 0x000000018D2431B8-0x000000018D24329C
		public string __iFixBaseProxy_ToString(); // 0x0000000188ABB3B8-0x0000000188ABB3C0
		public bool __iFixBaseProxy_Equals(object P0); // 0x0000000184F9DDF0-0x0000000184F9DE00
		public int __iFixBaseProxy_GetHashCode(); // 0x0000000187235B50-0x0000000187235B60
	}

	public enum AnimatorImpactType // TypeDefIndex: 74650
	{
		SetBoolTrue = 0,
		SetBoolFalse = 1,
		SetTrigger = 2,
		ResetTrigger = 3,
		SetInteger = 4,
		SetFloat = 5
	}

	public enum CanvasGroupImpactType // TypeDefIndex: 74651
	{
		SetAlpha = 0,
		SetInteractable = 1,
		SetColor = 2
	}

	public enum StateDescriptionTargetType // TypeDefIndex: 74652
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

	public enum GridLayoutGroupImpactType // TypeDefIndex: 74653
	{
		Padding = 0,
		Spacing = 1,
		CellSize = 2,
		ConstraintCount = 3
	}

	public enum ImageImpactType // TypeDefIndex: 74654
	{
		SetEnabled = 0,
		SetSprite = 1,
		SetColor = 2,
		SetMaterialFloatValue = 3
	}

	public enum LayoutElementImpactType // TypeDefIndex: 74655
	{
		LayoutElementPreferredWidth = 0,
		LayoutElementPreferredHeight = 1,
		LayoutElementMinWidth = 2,
		LayoutElementMinHeight = 3,
		LayoutElementFlexibleWidth = 4,
		LayoutElementFlexibleHeight = 5
	}

	public enum LayoutGroupImpactType // TypeDefIndex: 74656
	{
		Padding = 0,
		Spacing = 1,
		ChildAlignment = 2,
		ReverseArrangement = 3,
		ControlChildSize = 4,
		UseChildScale = 5,
		ChildForceExpand = 6
	}

	public enum RectTransformImpactType // TypeDefIndex: 74657
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

	public enum ScrollListImpactType // TypeDefIndex: 74658
	{
		Padding = 0,
		Space = 1
	}

	public enum TextImpactType // TypeDefIndex: 74659
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
	public class StateReference // TypeDefIndex: 74660
	{
		// Fields
		public string stateName; // 0x10
		public List<StateDescription> descriptions; // 0x18
		private List<StateAnimationInfo> m_scheduledForPlaying; // 0x20
		private List<StateAnimationInfo> m_scheduledForStopping; // 0x28
		private UIStateController m_controller; // 0x30
		private bool m_isDirty; // 0x38
	
		// Constructors
		public StateReference(); // 0x000000018503F170-0x000000018503F310
	
		// Methods
		public void SetController(UIStateController controller); // 0x000000018D2446CC-0x000000018D24470C
		public void ScheduleForPlaying(StateAnimationInfo stateAnimationInfo); // 0x000000018596E730-0x000000018596E7C0
		public void ScheduleForStopping(StateAnimationInfo stateAnimationInfo); // 0x000000018596F600-0x000000018596F690
		public void HandleScheduledStates(); // 0x0000000185716130-0x00000001857163A0
	}

	[ExecuteAlways]
	public class UIStateController : TickableUIMono // TypeDefIndex: 74662
	{
		// Fields
		public List<StateReference> states; // 0x68
		[CompilerGenerated]
		private string _currentStateName_k__BackingField; // 0x70
		private readonly List<StateAnimationInfo> m_animations; // 0x78
	
		// Properties
		protected override TickType tickOption { get; } // 0x00000001861B0850-0x00000001861B0880 
		public string currentStateName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000187232FC0-0x0000000187232FD0 0x0000000188800CD0-0x0000000188800CE0
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 74661
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Predicate<StateAnimationInfo> __9__9_0; // 0x08
			public static Predicate<StateAnimationInfo> __9__11_0; // 0x10
	
			// Constructors
			static __c(); // 0x00000001871E74C0-0x00000001871E7520
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool __FlushAnimationsImmediately_b__9_0(StateAnimationInfo info); // 0x0000000184E5E3C0-0x0000000184E5E3E0
			internal bool _Tick_b__11_0(StateAnimationInfo info); // 0x0000000184E5E3C0-0x0000000184E5E3E0
		}
	
		// Constructors
		public UIStateController(); // 0x000000018503F0E0-0x000000018503F170
	
		// Methods
		public void OnStateReferenceDirty(); // 0x000000018596F690-0x000000018596F6C0
		public float SetState(string stateName, bool forceUpdate = true /* Metadata: 0x02628502 */); // 0x0000000185970210-0x0000000185970B00
		private void _FlushAnimationsImmediately(); // 0x0000000184E63800-0x0000000184E65510
		private float _ApplyState(StateReference state); // 0x0000000185970B00-0x0000000185972030
		public override void Tick(float deltaTime); // 0x0000000185715B20-0x00000001857160F0
		private void _HandleStateAnimations(StateReference stateReference); // 0x00000001857160F0-0x0000000185716130
		public void Run(StateAnimationInfo newInfo); // 0x000000018596E7C0-0x000000018596EAB0
		public void Stop(StateAnimationInfo newInfo); // 0x00000001868B7060-0x00000001868B7310
		public TickType __iFixBaseProxy_get_tickOption(); // 0x0000000188CBEF28-0x0000000188CBEF30
		public void __iFixBaseProxy_Tick(float P0); // 0x0000000188CBEF20-0x0000000188CBEF28
	}

	public class UIStateControllerLogicalGroup : MonoBehaviour // TypeDefIndex: 74668
	{
		// Fields
		public List<Group> groups; // 0x18
		public List<LogicalGroup> logicalGroups; // 0x20
		public Dictionary<string, Group> groupDict; // 0x28
	
		// Nested types
		[Serializable]
		public class Group // TypeDefIndex: 74663
		{
			// Fields
			public string groupName; // 0x10
			public List<string> states; // 0x18
			[CompilerGenerated]
			private string _curStateName_k__BackingField; // 0x20
			[NonSerialized]
			public List<LogicalGroup> refLogicalGroups; // 0x28
	
			// Properties
			public string curStateName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E800-0x000000018225E810 0x0000000187835950-0x0000000187835960
	
			// Constructors
			public Group(); // 0x000000018D24084C-0x000000018D24090C
	
			// Methods
			public void ClearState(); // 0x000000018D240600-0x000000018D240688
			public void SetState(string stateName, bool forceApply = false /* Metadata: 0x02628503 */); // 0x000000018D240688-0x000000018D24084C
		}
	
		public enum LogicalEnum // TypeDefIndex: 74664
		{
			AND = 0,
			OR = 1
		}
	
		[Serializable]
		public class LogicalState // TypeDefIndex: 74665
		{
			// Fields
			public string groupName; // 0x10
			public string stateName; // 0x18
			public bool isNot; // 0x20
			public LogicalEnum logicalOperation; // 0x24
	
			// Constructors
			public LogicalState(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		[Serializable]
		public class LogicalGroupAction // TypeDefIndex: 74666
		{
			// Fields
			public UIStateController targetCtrl; // 0x10
			public string targetCtrlStateName; // 0x18
	
			// Constructors
			public LogicalGroupAction(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			public void Execute(); // 0x000000018D240C80-0x000000018D240CDC
		}
	
		[Serializable]
		public class LogicalGroup // TypeDefIndex: 74667
		{
			// Fields
			public List<LogicalState> logicalStates; // 0x10
			public List<LogicalGroupAction> actions; // 0x18
			[NonSerialized]
			public bool curIsApply; // 0x20
			[NonSerialized]
			public UIStateControllerLogicalGroup stateCtrlLogicalGroup; // 0x28
	
			// Constructors
			public LogicalGroup(); // 0x000000018D2410C0-0x000000018D241180
	
			// Methods
			public bool CheckIsValid(); // 0x000000018D240E74-0x000000018D240FDC
			private bool _IsStateMatched(LogicalState state); // 0x000000018D240FDC-0x000000018D2410C0
			public void Apply(bool isApply, bool forceApply = false /* Metadata: 0x02628506 */); // 0x000000018D240CDC-0x000000018D240E74
		}
	
		// Constructors
		public UIStateControllerLogicalGroup(); // 0x000000018D248080-0x000000018D248194
	
		// Methods
		private void Awake(); // 0x000000018D247870-0x000000018D2478B0
		private void _RebuildRuntimeBindings(bool preserveGroupState); // 0x000000018D247A6C-0x000000018D247ED8
		public void SetState(string groupName, string stateName); // 0x000000018D2478B0-0x000000018D247A6C
		private void _RegisterLogicalState(LogicalGroup logicalGroup, LogicalState logicalState, int index); // 0x000000018D247ED8-0x000000018D248080
	}

	public static class UIStateControllerUtils // TypeDefIndex: 74669
	{
		// Fields
		private static float s_updateFinishTime; // 0x00
	
		// Methods
		public static void StartEditorUpdateLoop(float duration); // 0x000000018596E710-0x000000018596E730
	
		// Extension methods
		public static void ForceRebuildLayout(this GameObject gameObject); // 0x0000000187113020-0x00000001871130D0
		public static void SetLeft(this RectTransform rt, float left); // 0x0000000185972A80-0x0000000185972AF0
		public static void SetRight(this RectTransform rt, float right); // 0x0000000185972DC0-0x0000000185972E30
		public static void SetTop(this RectTransform rt, float top); // 0x0000000185973130-0x00000001859731A0
		public static void SetBottom(this RectTransform rt, float bottom); // 0x00000001859731A0-0x0000000185973210
		public static string GetName(this UnityEngine.Object obj); // 0x000000018D248194-0x000000018D248244
	}
}

namespace Cysharp.Text
{
	public static class TextMeshProExtensions // TypeDefIndex: 74318
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
		public static void SetText(this TMP_Text text, Utf16ValueStringBuilder stringBuilder); // 0x000000018D1F8688-0x000000018D1F876C
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 74317
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace IFix
{
	public class ILFixDynamicMethodWrapper // TypeDefIndex: 74743
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
		private int methodId; // 0x18
		private object anonObj; // 0x20
		public static ILFixDynamicMethodWrapper[] wrapperArray; // 0x00
	
		// Constructors
		public ILFixDynamicMethodWrapper(VirtualMachine virtualMachine, int methodId, object anonObj); // 0x000000018536C3F0-0x000000018536C420
		static ILFixDynamicMethodWrapper(); // 0x000000018D24B46C-0x000000018D24B4D0
	
		// Methods
		public void __Gen_Wrap_0(); // 0x00000001887ED074-0x00000001887ED104
		public void __Gen_Wrap_1(object P0); // 0x00000001887ED758-0x00000001887ED80C
		public float __Gen_Wrap_2(object P0, bool P1); // 0x000000018D24A3D8-0x000000018D24A4B8
		public float __Gen_Wrap_3(object P0); // 0x000000018936AA54-0x000000018936AB14
		public int __Gen_Wrap_4(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public TickType __Gen_Wrap_5(object P0); // 0x00000001887EBA14-0x00000001887EBAD4
		public LuaPanel __Gen_Wrap_6(object P0); // 0x000000018D24B26C-0x000000018D24B34C
		public void __Gen_Wrap_7(object P0, object P1, bool P2); // 0x000000018936C33C-0x000000018936C428
		public void __Gen_Wrap_8(object P0, float P1); // 0x000000018936ABF4-0x000000018936ACC4
		public string __Gen_Wrap_9(object P0, out bool P1); // 0x000000018D24B34C-0x000000018D24B46C
		public string __Gen_Wrap_10(object P0, int P1); // 0x000000018D2490CC-0x000000018D2491C8
		public UIText.HyperlinkUITextManager __Gen_Wrap_11(); // 0x000000018D2491C8-0x000000018D249284
		public bool __Gen_Wrap_12(object P0, object P1); // 0x00000001887F2FB4-0x00000001887F3094
		public UIText.HyperlinkUITextGroup __Gen_Wrap_13(object P0, object P1, bool P2); // 0x000000018D249284-0x000000018D2493A0
		public void __Gen_Wrap_14(object P0, object P1); // 0x0000000188B47220-0x0000000188B472F0
		public string __Gen_Wrap_15(PhoneticType P0, object P1); // 0x000000018D2493A0-0x000000018D24949C
		public void __Gen_Wrap_16(object P0, PhoneticType P1, object P2); // 0x00000001887EDD90-0x00000001887EDE78
		public string __Gen_Wrap_17(object P0); // 0x000000018D24949C-0x000000018D24957C
		public void __Gen_Wrap_18(EnvLang P0); // 0x00000001887DBA64-0x00000001887DBB14
		public bool __Gen_Wrap_19(object P0, object P1, out string P2); // 0x000000018D24957C-0x000000018D2496C0
		public bool __Gen_Wrap_20(object P0, Vector3 P1, out string P2); // 0x000000018D2496C0-0x000000018D249830
		public IEnumerator __Gen_Wrap_21(object P0); // 0x000000018D249830-0x000000018D249910
		public string __Gen_Wrap_22(object P0, bool P1); // 0x000000018D249910-0x000000018D249A10
		public Sprite __Gen_Wrap_23(object P0, object P1); // 0x000000018D249A10-0x000000018D249B10
		public int __Gen_Wrap_24(ReadOnlySpan<char> P0); // 0x000000018D249B10-0x000000018D249C08
		public UIText.RichTextInfo __Gen_Wrap_25(UIText.RichTextAnalyzer.RichTextParam P0, object P1, ref Utf16ValueStringBuilder P2); // 0x000000018D249C08-0x000000018D249DB8
		public UIText.RichTextInfo __Gen_Wrap_26(object P0, UIText.RichTextAnalyzer.RichTextParam P1, object P2, ref Utf16ValueStringBuilder P3); // 0x000000018D249DB8-0x000000018D249F7C
		public UIText.RichTextAnalyzer.ProcessRichTextEntryFunc __Gen_Wrap_27(object P0); // 0x000000018D249F7C-0x000000018D24A05C
		public bool __Gen_Wrap_28(ReadOnlySpan<char> P0, out bool P1, out UIText.RichTextAnalyzer.RichTextParam P2); // 0x000000018D24A05C-0x000000018D24A1F8
		public bool __Gen_Wrap_29(ReadOnlySpan<char> P0, ref Utf16ValueStringBuilder P1, object P2, out UIText.RichTextInfo P3); // 0x000000018D24A1F8-0x000000018D24A3D8
		public string __Gen_Wrap_30(object P0, object P1, out List<UIText.RichTextInfo> P2); // 0x000000018D24A4B8-0x000000018D24A60C
		public GameObject __Gen_Wrap_31(object P0); // 0x000000018D24A60C-0x000000018D24A6EC
		public UIText.ImageGOInfo __Gen_Wrap_32(object P0, int P1); // 0x000000018D24A6EC-0x000000018D24A810
		public Material __Gen_Wrap_33(object P0); // 0x000000018D24A810-0x000000018D24A8F0
		public Material __Gen_Wrap_34(object P0, object P1); // 0x000000018D24A8F0-0x000000018D24A9F0
		public bool __Gen_Wrap_35(object P0); // 0x0000000188B46E14-0x0000000188B46ED4
		public bool __Gen_Wrap_36(); // 0x00000001887ECE94-0x00000001887ECF30
		public I18nFontSearchData __Gen_Wrap_37(); // 0x000000018D24A9F0-0x000000018D24AAAC
		public TMP_FontAsset __Gen_Wrap_38(int P0); // 0x000000018D24AAAC-0x000000018D24AB8C
		public TMP_FontAsset __Gen_Wrap_39(object P0); // 0x000000018D24AB8C-0x000000018D24AC6C
		public void __Gen_Wrap_40(object P0, object P1, object P2, int P3); // 0x000000018C0DDA8C-0x000000018C0DDB8C
		public void __Gen_Wrap_41(object P0, object P1, int P2); // 0x000000018C0C2668-0x000000018C0C2750
		public bool __Gen_Wrap_42(object P0, int P1, out string P2); // 0x000000018D24AC6C-0x000000018D24ADB0
		public bool __Gen_Wrap_43(object P0, int P1, out Vector3 P2, out float P3); // 0x000000018D24ADB0-0x000000018D24AF34
		public void __Gen_Wrap_44(object P0, object P1, object P2); // 0x00000001887EF660-0x00000001887EF74C
		public int __Gen_Wrap_45(UIText.HyperlinkUITextWrap P0, UIText.HyperlinkUITextWrap P1); // 0x0000000188B4BB74-0x0000000188B4BC54
		public List<UIText> __Gen_Wrap_46(object P0, object P1); // 0x000000018D24AF34-0x000000018D24B034
		public List<UIText> __Gen_Wrap_47(object P0); // 0x000000018D24B034-0x000000018D24B114
		public TMP_SubMeshUI __Gen_Wrap_48(object P0, object P1, MaterialReference P2); // 0x000000018D24B114-0x000000018D24B26C
		public string __Gen_Wrap_49(int P0); // 0x0000000184EF4DE0-0x0000000184EF5640
		public Vector2 __Gen_Wrap_50(object P0, ref float P1, Vector2 P2, bool P3, bool P4); // 0x0000000184EF5640-0x0000000184EF6250
		public int __Gen_Wrap_51(); // 0x00000001825212D0-0x00000001825214A0
		public float __Gen_Wrap_52(); // 0x0000000182552560-0x0000000182552730
		public GameObject __Gen_Wrap_53(object P0, object P1, object P2); // 0x0000000184EF6250-0x0000000184EF6D40
		public void __Gen_Wrap_54(FAssetProxyUntrackedHandle P0); // 0x0000000184EF6D40-0x0000000184EF72E0
		public int __Gen_Wrap_55(object P0, object P1, object P2, object P3); // 0x00000001830099A0-0x0000000183009EC0
		public void __Gen_Wrap_56(object P0, int P1); // 0x00000001824828A0-0x0000000182482B70
		public bool __Gen_Wrap_57(Vector3 P0, object P1, object P2); // 0x0000000184EF72E0-0x0000000184EF7A50
		public bool __Gen_Wrap_58(Vector2 P0, object P1, object P2); // 0x0000000184EF7A50-0x0000000184EF81C0
		public Bounds __Gen_Wrap_59(object P0, object P1); // 0x0000000184EF81C0-0x0000000184EF8B80
		public bool __Gen_Wrap_60(int P0, out UnityEngine.InputSystem.EnhancedTouch.Touch P1); // 0x0000000184EF8B80-0x0000000184EF9450
		public void __Gen_Wrap_61(object P0, UnityEngine.Color P1); // 0x0000000184EF9450-0x0000000184EF9AC0
		public Rect __Gen_Wrap_62(object P0, object P1); // 0x0000000184EF9AC0-0x0000000184EFA480
		public Vector2 __Gen_Wrap_63(object P0, object P1, Vector2 P2); // 0x0000000184EFA480-0x0000000184EFB1A0
		public Vector3 __Gen_Wrap_64(object P0, object P1); // 0x0000000184EFB1A0-0x0000000184EFBB60
		public UnityEngine.Color __Gen_Wrap_65(object P0); // 0x0000000184EFBB60-0x0000000184EFC440
		public float __Gen_Wrap_66(float P0); // 0x00000001825CB750-0x00000001825CB940
		public bool __Gen_Wrap_67(object P0, out string P1); // 0x0000000184EFC440-0x0000000184EFCE50
		public void __Gen_Wrap_68(object P0, object P1, CinemachineCore.Stage P2, ref CameraState P3, float P4); // 0x0000000184EFCE50-0x0000000184EFDD10
		public int __Gen_Wrap_69(object P0, int P1); // 0x00000001824748D0-0x0000000182474BB0
		public Vector2 __Gen_Wrap_70(object P0, int P1); // 0x0000000184EFDD10-0x0000000184EFE620
		public Vector2 __Gen_Wrap_71(); // 0x0000000184EFE620-0x0000000184EFEE20
		public void __Gen_Wrap_72(Vector2 P0); // 0x0000000184EFEE20-0x0000000184EFF3C0
		public void __Gen_Wrap_73(object P0, int P1, bool P2); // 0x000000018258AE50-0x000000018258B140
		public Vector2Int __Gen_Wrap_74(object P0, float P1, float P2, float P3); // 0x0000000184EFF3C0-0x0000000184EFFD00
		public Vector2Int __Gen_Wrap_75(object P0, float P1, bool P2); // 0x0000000184EFFD00-0x0000000184F00640
		public Vector2Int __Gen_Wrap_76(object P0); // 0x0000000184F00640-0x0000000184F00F00
		public void __Gen_Wrap_77(object P0, Vector2Int P1, Vector2Int P2); // 0x0000000184F00F00-0x0000000184F01690
		public UIScrollList.Cell __Gen_Wrap_78(object P0); // 0x0000000184F01690-0x0000000184F01FB0
		public void __Gen_Wrap_79(object P0, bool P1); // 0x000000018253E590-0x000000018253E870
		public DG.Tweening.Tween __Gen_Wrap_80(object P0); // 0x0000000184F01FB0-0x0000000184F028D0
		public UIAnimationTween __Gen_Wrap_81(object P0); // 0x0000000184F028D0-0x0000000184F031F0
		public UnityEngine.AnimationState __Gen_Wrap_82(object P0, object P1); // 0x0000000184F031F0-0x0000000184F03BF0
		public void __Gen_Wrap_83(object P0, object P1, float P2); // 0x00000001827B9100-0x00000001827B94A0
		public void __Gen_Wrap_84(object P0, object P1, float P2, bool P3); // 0x0000000182476C00-0x0000000182476FC0
		public void __Gen_Wrap_85(object P0, object P1, object P2, UIConst.AnimationState P3, float P4, bool P5, float P6); // 0x0000000184F03BF0-0x0000000184F040B0
		public void __Gen_Wrap_86(object P0, float P1, bool P2); // 0x0000000183F97130-0x0000000183F97430
		public AnimationClip __Gen_Wrap_87(object P0); // 0x0000000184F040B0-0x0000000184F049D0
		public void __Gen_Wrap_88(object P0, object P1, bool P2, float P3); // 0x000000018474EBB0-0x000000018474EF60
		public void __Gen_Wrap_89(object P0, int P1, bool P2, bool P3); // 0x0000000182466F50-0x0000000182467260
		public void __Gen_Wrap_90(object P0, Vector2Int P1); // 0x0000000184F049D0-0x0000000184F05060
		public void __Gen_Wrap_91(object P0, bool P1, bool P2, bool P3); // 0x00000001835F5B00-0x00000001835F5E10
		public UIScrollList.MoveTipsType __Gen_Wrap_92(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public UISelectableNaviGroup __Gen_Wrap_93(object P0); // 0x0000000184F05060-0x0000000184F05980
		public float __Gen_Wrap_94(object P0, object P1); // 0x0000000182E04540-0x0000000182E048D0
		public bool __Gen_Wrap_95(object P0, object P1, bool P2, out Selectable P3); // 0x0000000184F05980-0x0000000184F06450
		public void __Gen_Wrap_96(object P0, Vector2 P1); // 0x0000000184F06450-0x0000000184F06AD0
		public void __Gen_Wrap_97(object P0, int P1, bool P2, UIScrollList.ScrollAlignType P3, bool P4); // 0x0000000183A23790-0x0000000183A23AC0
		public UIText __Gen_Wrap_98(object P0); // 0x0000000184F06AD0-0x0000000184F073F0
		public Sprite __Gen_Wrap_99(object P0); // 0x0000000184F073F0-0x0000000184F07D10
		public UIStyleInputValidTypeMask __Gen_Wrap_100(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public void __Gen_Wrap_101(object P0, UIStyleInputValidTypeMask P1); // 0x00000001824828A0-0x0000000182482B70
		public CustomUIStyle.OverrideValidState __Gen_Wrap_102(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public bool __Gen_Wrap_103(UIStyleInputValidType P0); // 0x0000000182220AF0-0x0000000182220CF0
		public void __Gen_Wrap_104(object P0, CustomUIStyle.OverrideValidState P1); // 0x00000001824828A0-0x0000000182482B70
		public bool __Gen_Wrap_105(UIStyleInputValidTypeMask P0); // 0x0000000182220AF0-0x0000000182220CF0
		public void __Gen_Wrap_106(object P0, int P1, int P2); // 0x00000001824F9690-0x00000001824F9980
		public void __Gen_Wrap_107(object P0, bool P1, bool P2); // 0x00000001824EC140-0x00000001824EC440
		public ScrollDirection __Gen_Wrap_108(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public float __Gen_Wrap_109(object P0, float P1, int P2); // 0x0000000183ED3CE0-0x0000000183ED3FE0
		public float __Gen_Wrap_110(object P0, float P1, float P2); // 0x00000001825DE4F0-0x00000001825DE800
		public void __Gen_Wrap_111(object P0, float P1, float P2, object P3, object P4); // 0x0000000184E65510-0x0000000184E659B0
		public void __Gen_Wrap_112(object P0, float P1, float P2, Interpolator.EEaseType P3, object P4); // 0x0000000184E659B0-0x0000000184E65DA0
		public UILoopScrollRect.MovementDirection __Gen_Wrap_113(object P0, int P1, int P2); // 0x00000001824DFEA0-0x00000001824E0190
		public float __Gen_Wrap_114(object P0, float P1); // 0x000000018246D560-0x000000018246D840
		public int __Gen_Wrap_115(object P0, float P1); // 0x0000000182EB36C0-0x0000000182EB39A0
		public int __Gen_Wrap_116(object P0, int P1, int P2); // 0x00000001824DFEA0-0x00000001824E0190
		public void __Gen_Wrap_117(object P0, float P1, int P2, bool P3); // 0x000000018307C9F0-0x000000018307CD00
		public Selectable __Gen_Wrap_118(object P0); // 0x0000000184E65DA0-0x0000000184E666C0
		public bool __Gen_Wrap_119(object P0, Vector2 P1, object P2); // 0x0000000184E666C0-0x0000000184E66E20
		public IList<UIRecycleLayoutAdapter.IVirtualView> __Gen_Wrap_120(object P0); // 0x0000000184E66E20-0x0000000184E67740
		public UIRecycleLayoutAdapter __Gen_Wrap_121(object P0); // 0x0000000184E67740-0x0000000184E68060
		public UIRecycleLayoutGroup.ViewMgr __Gen_Wrap_122(object P0); // 0x0000000184E68060-0x0000000184E68980
		public UIRecycleLayoutGroup.Padding __Gen_Wrap_123(object P0); // 0x0000000184E68980-0x0000000184E69260
		public RectTransform __Gen_Wrap_124(object P0); // 0x0000000184E69260-0x0000000184E69B80
		public void __Gen_Wrap_125(object P0, object P1, UIRecycleLayoutGroup.LayoutMeta P2); // 0x0000000184E69B80-0x0000000184E6A2C0
		public Vector2 __Gen_Wrap_126(object P0, Bounds P1); // 0x0000000184E6A2C0-0x0000000184E6AF20
		public Bounds __Gen_Wrap_127(object P0, UIRecycleLayoutGroup.LayoutMeta P1); // 0x0000000184E6AF20-0x0000000184E6BB70
		public UIRecycleLayoutAdapter __Gen_Wrap_128(object P0, object P1); // 0x0000000184E6BB70-0x0000000184E6C570
		public UIRecycleLayoutGroup.ViewPool __Gen_Wrap_129(object P0, object P1); // 0x0000000184E6C570-0x0000000184E6CF70
		public GameObject __Gen_Wrap_130(object P0, out bool P1); // 0x0000000184E6CF70-0x0000000184E6D8E0
		public bool __Gen_Wrap_131(object P0, int P1, object P2); // 0x00000001827BAA70-0x00000001827BAE20
		public UIRecycleLayoutAdapter.IVirtualView __Gen_Wrap_132(object P0, int P1); // 0x0000000184E6D8E0-0x0000000184E6E230
		public float __Gen_Wrap_133(object P0, int P1); // 0x0000000182584BB0-0x0000000182584E90
		public Bounds __Gen_Wrap_134(object P0, int P1); // 0x0000000184E6E230-0x0000000184E6EB30
		public int __Gen_Wrap_135(object P0, object P1); // 0x0000000182224290-0x0000000182224620
		public UIRecycleLayoutGroup.Direction __Gen_Wrap_136(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public UIRecycleMultiHolder.MultiVirtualView __Gen_Wrap_137(object P0, int P1); // 0x0000000184E6EB30-0x0000000184E6F480
		public void __Gen_Wrap_138(object P0, int P1, object P2, float P3); // 0x0000000183327780-0x0000000183327B40
		public UIRecycleSingleHolder.SimpleVirtualView __Gen_Wrap_139(object P0, int P1); // 0x0000000184E6F480-0x0000000184E6FDD0
		public ToastList.CellInfo __Gen_Wrap_140(object P0); // 0x0000000184E6FDD0-0x0000000184E706F0
		public IEnumerator __Gen_Wrap_141(object P0, int P1, object P2); // 0x0000000184E706F0-0x0000000184E71110
		public string __Gen_Wrap_142(object P0, object P1, bool P2, bool P3, out bool P4); // 0x0000000184E71110-0x0000000184E71BB0
		public bool __Gen_Wrap_143(object P0, object P1, object P2); // 0x000000018252A430-0x000000018252A890
		public bool __Gen_Wrap_144(object P0, object P1, object P2, bool P3, out bool P4, bool P5); // 0x0000000184E71BB0-0x0000000184E72090
		public IBindingView __Gen_Wrap_145(object P0); // 0x0000000184E72090-0x0000000184E729B0
		public PlayerActionInfo __Gen_Wrap_146(object P0); // 0x0000000184E729B0-0x0000000184E732D0
		public string __Gen_Wrap_147(object P0, object P1, bool P2, bool P3); // 0x0000000184E732D0-0x0000000184E73D30
		public UIActionKeyHint.KeyHintSnapshot __Gen_Wrap_148(object P0); // 0x0000000184E73D30-0x0000000184E74630
		public bool __Gen_Wrap_149(object P0, in UIActionKeyHint.KeyHintSnapshot P1); // 0x0000000184E74630-0x0000000184E74CE0
		public void __Gen_Wrap_150(object P0, in UIActionKeyHint.KeyHintSnapshot P1); // 0x0000000184E74CE0-0x0000000184E75380
		public UnityEngine.Color __Gen_Wrap_151(UIActionKeyHint.HintVisibility P0); // 0x0000000184E75380-0x0000000184E75BA0
		public void __Gen_Wrap_152(object P0, UIActionKeyHint.HintVisibility P1, bool P2); // 0x000000018258AE50-0x000000018258B140
		public UIActionKeyHint.HintVisibility __Gen_Wrap_153(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public UIActionKeyHint.HintVisibility __Gen_Wrap_154(object P0, BindingViewState P1); // 0x00000001824748D0-0x0000000182474BB0
		public void __Gen_Wrap_155(object P0, out UIActionKeyHint.HintVisibility P1, out bool P2); // 0x0000000184E75BA0-0x0000000184E75EC0
		public void __Gen_Wrap_156(Beyond.DeviceInfo.ControllerType P0); // 0x0000000182220CF0-0x0000000182220EE0
		public void __Gen_Wrap_157(object P0, in EventData<string> P1); // 0x0000000184E75EC0-0x0000000184E76540
		public void __Gen_Wrap_158(object P0, object P1, object P2, bool P3); // 0x00000001827A62D0-0x00000001827A6740
		public void __Gen_Wrap_159(object P0, int P1, object P2, object P3, bool P4); // 0x0000000184E76540-0x0000000184E769D0
		public bool __Gen_Wrap_160(object P0, object P1, bool P2, bool P3); // 0x0000000182E2CFA0-0x0000000182E2D360
		public AnimationClip __Gen_Wrap_161(object P0, object P1, bool P2); // 0x0000000184E769D0-0x0000000184E77410
		public AnimationClip __Gen_Wrap_162(object P0, object P1); // 0x0000000184E77410-0x0000000184E77E10
		public void __Gen_Wrap_163(object P0, UIAnimationWrapper.FOptions P1); // 0x0000000184E77E10-0x0000000184E78490
		public void __Gen_Wrap_164(object P0, object P1, object P2, UIConst.AnimationState P3, float P4, bool P5); // 0x0000000184E78490-0x0000000184E78930
		public UIAnimationWrapper.FOptions __Gen_Wrap_165(); // 0x0000000184E78930-0x0000000184E79110
		public void __Gen_Wrap_166(object P0, object P1, object P2, float P3); // 0x00000001824F20C0-0x00000001824F2530
		public UISwitchTween.ITweenHandler __Gen_Wrap_167(object P0); // 0x0000000184E79110-0x0000000184E79A30
		public UISwitchTween.ITweenHandler __Gen_Wrap_168(object P0, object P1); // 0x0000000184E79A30-0x0000000184E7A430
		public UISwitchTween.ITweenHandler __Gen_Wrap_169(object P0, bool P1); // 0x0000000184E7A430-0x0000000184E7ADC0
		public UIAnimationSwitchTween __Gen_Wrap_170(ref UIAnimationSwitchTween.Builder P0); // 0x0000000184E7ADC0-0x0000000184E7BCA0
		public Camera __Gen_Wrap_171(object P0); // 0x0000000184E7BCA0-0x0000000184E7C5C0
		public void __Gen_Wrap_172(object P0, object P1, bool P2, bool P3, bool P4, bool P5, bool P6, float P7); // 0x0000000183F75EA0-0x0000000183F762F0
		public void __Gen_Wrap_173(object P0, bool P1, bool P2, bool P3, bool P4, float P5); // 0x0000000184E7C5C0-0x0000000184E7C920
		public IEnumerator __Gen_Wrap_174(object P0, object P1); // 0x0000000184E7C920-0x0000000184E7D320
		public DisposedUnityEvent __Gen_Wrap_175(object P0); // 0x0000000184E7D320-0x0000000184E7DC40
		public DisposedUnityEvent<int, bool> __Gen_Wrap_176(object P0); // 0x0000000184E7DC40-0x0000000184E7E560
		public UITouchPanel __Gen_Wrap_177(object P0); // 0x0000000184E7E560-0x0000000184E7EE80
		public void __Gen_Wrap_178(object P0, out Vector2 P1, out Vector2 P2); // 0x0000000184E7EE80-0x0000000184E7FB80
		public Vector2 __Gen_Wrap_179(object P0, Vector2 P1); // 0x0000000184E7FB80-0x0000000184E807C0
		public void __Gen_Wrap_180(PointerEventData P0); // 0x0000000182510780-0x0000000182510A40
		public void __Gen_Wrap_181(object P0, Vector3 P1); // 0x0000000184E807C0-0x0000000184E80E30
		public void __Gen_Wrap_182(object P0, bool P1, float P2, object P3, object P4); // 0x0000000184E80E30-0x0000000184E812D0
		public void __Gen_Wrap_183(float P0); // 0x0000000182541570-0x0000000182541760
		public void __Gen_Wrap_184(object P0, bool P1, out Selectable P2, out UITouchPanel P3); // 0x0000000184E812D0-0x0000000184E82020
		public void __Gen_Wrap_185(object P0, float P1, float P2, object P3); // 0x00000001837E4A80-0x00000001837E4E50
		public void __Gen_Wrap_186(object P0, object P1, bool P2, object P3); // 0x00000001834B7B60-0x00000001834B7FD0
		public UIBigRectHelper.BigRectRecoverState __Gen_Wrap_187(object P0); // 0x0000000184E82020-0x0000000184E82940
		public void __Gen_Wrap_188(object P0, out float P1, out float P2); // 0x0000000183D733A0-0x0000000183D736D0
		public void __Gen_Wrap_189(object P0, object P1, UnityEngine.Color P2); // 0x0000000184E82940-0x0000000184E83080
		public Canvas __Gen_Wrap_190(object P0); // 0x0000000184E83080-0x0000000184E839A0
		public HGCamera __Gen_Wrap_191(object P0); // 0x0000000184E839A0-0x0000000184E842C0
		public RawImage __Gen_Wrap_192(object P0); // 0x0000000184E842C0-0x0000000184E84BE0
		public Vector2 __Gen_Wrap_193(object P0); // 0x0000000184E84BE0-0x0000000184E854D0
		public IBindingGroupTarget __Gen_Wrap_194(object P0); // 0x0000000184E854D0-0x0000000184E85DF0
		public string __Gen_Wrap_195(object P0, object P1); // 0x0000000184E85DF0-0x0000000184E867F0
		public BindingViewState __Gen_Wrap_196(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public string __Gen_Wrap_197(object P0, BindingViewActionType P1); // 0x0000000184E867F0-0x0000000184E87140
		public bool __Gen_Wrap_198(object P0, out string P1, out string P2); // 0x0000000184E87140-0x0000000184E87D30
		public ActionOnSetNaviTarget __Gen_Wrap_199(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public void __Gen_Wrap_200(object P0, ActionOnSetNaviTarget P1); // 0x00000001824828A0-0x0000000182482B70
		public HashSet<CanvasScaler> __Gen_Wrap_201(object P0); // 0x0000000184E87D30-0x0000000184E88650
		public float __Gen_Wrap_202(out Vector2 P0); // 0x0000000184E88650-0x0000000184E88ED0
		public UICanvasScaleHelper.FWorldCanvasParams __Gen_Wrap_203(object P0, object P1, bool P2); // 0x0000000184E88ED0-0x0000000184E898C0
		public UICanvasScaleHelper.FScreenCanvasParams __Gen_Wrap_204(); // 0x0000000184E898C0-0x0000000184E8A0B0
		public void __Gen_Wrap_205(object P0, UIColorGroup.CommonParams P1); // 0x0000000184E8A0B0-0x0000000184E8A720
		public void __Gen_Wrap_206(object P0, object P1, UIColorGroup.CommonParams P2); // 0x0000000184E8A720-0x0000000184E8AE70
		public void __Gen_Wrap_207(object P0, float P1, float P2, bool P3); // 0x00000001835F07F0-0x00000001835F0B10
		public void __Gen_Wrap_208(object P0, UnityEngine.Color P1, float P2, bool P3, bool P4, bool P5); // 0x0000000184E8AE70-0x0000000184E8B560
		public void __Gen_Wrap_209(object P0, UnityEngine.Color P1, float P2, bool P3, bool P4); // 0x0000000184E8B560-0x0000000184E8BC30
		public void __Gen_Wrap_210(object P0, GamepadKeyCode P1); // 0x00000001824828A0-0x0000000182482B70
		public UICustomLayoutElement __Gen_Wrap_211(object P0); // 0x0000000184E8BC30-0x0000000184E8C550
		public UICustomLayoutElement.LayoutType __Gen_Wrap_212(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public bool __Gen_Wrap_213(object P0, out UICustomLayoutElement.LayoutData P1, bool P2, int P3); // 0x0000000184E8C550-0x0000000184E8CFA0
		public bool __Gen_Wrap_214(object P0, out UICustomLayoutElement.LayoutData P1, int P2); // 0x0000000184E8CFA0-0x0000000184E8D9D0
		public void __Gen_Wrap_215(object P0, UICustomLayoutElement.LayoutType P1); // 0x00000001824828A0-0x0000000182482B70
		public CanvasGroup __Gen_Wrap_216(object P0); // 0x0000000184E8D9D0-0x0000000184E8E2F0
		public UIDialogText __Gen_Wrap_217(object P0); // 0x0000000184E8E2F0-0x0000000184E8EC10
		public void __Gen_Wrap_218(object P0, bool P1, object P2); // 0x00000001824FB4E0-0x00000001824FB880
		public void __Gen_Wrap_219(object P0, object P1, object P2, object P3); // 0x0000000182558BB0-0x00000001825590D0
		public void __Gen_Wrap_220(object P0, int P1, bool P2, bool P3, bool P4); // 0x0000000183233A50-0x0000000183233D80
		public void __Gen_Wrap_221(object P0, Vector2 P1, bool P2); // 0x0000000184E8EC10-0x0000000184E8F2A0
		public void __Gen_Wrap_222(object P0, Vector2 P1, bool P2, bool P3); // 0x0000000184E8F2A0-0x0000000184E8F960
		public void __Gen_Wrap_223(object P0, object P1, bool P2, bool P3); // 0x00000001826D4DB0-0x00000001826D5170
		public void __Gen_Wrap_224(object P0, int P1, int P2, bool P3); // 0x0000000183219A80-0x0000000183219D90
		public float __Gen_Wrap_225(object P0, bool P1, int P2); // 0x0000000184E8F960-0x0000000184E8FC60
		public void __Gen_Wrap_226(object P0, bool P1, float P2, float P3); // 0x0000000183C8EDE0-0x0000000183C8F100
		public void __Gen_Wrap_227(object P0, Rect P1); // 0x0000000184E8FC60-0x0000000184E902D0
		public bool __Gen_Wrap_228(StateAnimationInfo P0); // 0x00000001822262C0-0x0000000182226590
		public float __Gen_Wrap_229(object P0, object P1, bool P2); // 0x0000000183084840-0x0000000183084BE0
		public Vector3 __Gen_Wrap_230(object P0); // 0x0000000184E902D0-0x0000000184E90BC0
		public Transform __Gen_Wrap_231(object P0); // 0x0000000184E90BC0-0x0000000184E914E0
		public void __Gen_Wrap_232(object P0, int P1, float P2); // 0x0000000182EEEE90-0x0000000182EEF180
		public bool __Gen_Wrap_233(object P0, bool P1, bool P2); // 0x00000001831EF6C0-0x00000001831EF9D0
		public Selectable __Gen_Wrap_234(object P0, bool P1); // 0x0000000184E914E0-0x0000000184E91E70
		public bool __Gen_Wrap_235(object P0, int P1, int P2, bool P3, bool P4); // 0x0000000184E91E70-0x0000000184E921B0
		public bool __Gen_Wrap_236(object P0, NaviDirection P1, bool P2); // 0x000000018278C5F0-0x000000018278C900
		public void __Gen_Wrap_237(object P0, NaviDirection P1); // 0x00000001824828A0-0x0000000182482B70
		public bool __Gen_Wrap_238(object P0, NaviDirection P1); // 0x0000000182460990-0x0000000182460C70
		public bool __Gen_Wrap_239(object P0, int P1, out int P2, out bool P3, out int P4); // 0x0000000184E921B0-0x0000000184E92540
		public bool __Gen_Wrap_240(object P0, int P1, out int P2, out int P3); // 0x0000000184E92540-0x0000000184E92890
		public int __Gen_Wrap_241(object P0, int P1, int P2, UIScrollList.ScrollAlignType P3); // 0x0000000182BF2BB0-0x0000000182BF2EC0
		public int __Gen_Wrap_242(object P0, int P1, UIScrollList.ScrollAlignType P2); // 0x00000001824DFEA0-0x00000001824E0190
		public void __Gen_Wrap_243(object P0, int P1, out int P2, out int P3); // 0x0000000182C32950-0x0000000182C32C90
		public Vector2Int __Gen_Wrap_244(object P0, Vector2Int P1); // 0x0000000184E92890-0x0000000184E934F0
		public Vector2Int __Gen_Wrap_245(object P0, Vector2Int P1, Vector2Int P2); // 0x0000000184E934F0-0x0000000184E94250
		public ValueTuple<float, float> __Gen_Wrap_246(object P0); // 0x0000000184E94250-0x0000000184E94B40
		public int __Gen_Wrap_247(object P0, bool P1); // 0x0000000183101620-0x0000000183101910
		public GameObject __Gen_Wrap_248(object P0, int P1); // 0x0000000184E94B40-0x0000000184E95490
		public UIScrollList.Cell __Gen_Wrap_249(object P0, int P1); // 0x0000000184E95490-0x0000000184E95DE0
		public float __Gen_Wrap_250(object P0, int P1, UIScrollList.ScrollAlignType P2); // 0x0000000183A8C760-0x0000000183A8CA50
		public void __Gen_Wrap_251(object P0, int P1, bool P2, UIScrollList.ScrollAlignType P3); // 0x00000001831D7B40-0x00000001831D7E50
		public int __Gen_Wrap_252(object P0, NaviDirection P1); // 0x00000001824748D0-0x0000000182474BB0
		public int __Gen_Wrap_253(object P0, int P1, NaviDirection P2); // 0x00000001824DFEA0-0x00000001824E0190
		public bool __Gen_Wrap_254(object P0, NaviDirection P1, out bool P2); // 0x0000000182E50100-0x0000000182E50410
		public bool __Gen_Wrap_255(object P0, out int P1, out UIScrollList.Cell P2); // 0x0000000184E95DE0-0x0000000184E96830
		public bool __Gen_Wrap_256(object P0, object P1, NaviDirection P2); // 0x00000001824E73F0-0x00000001824E7790
		public bool __Gen_Wrap_257(object P0, NaviDirection P1, int P2, bool P3, out int P4); // 0x0000000184E96830-0x0000000184E96B70
		public bool __Gen_Wrap_258(object P0, int P1, bool P2); // 0x000000018278C5F0-0x000000018278C900
		public bool __Gen_Wrap_259(object P0, NaviDirection P1, int P2, bool P3); // 0x0000000183E85140-0x0000000183E85460
		public bool __Gen_Wrap_260(object P0, ref int P1, bool P2); // 0x0000000184E96B70-0x0000000184E96E90
		public void __Gen_Wrap_261(object P0, int P1, int P2, bool P3, bool P4, bool P5, UIScrollList.ScrollAlignType P6); // 0x0000000184E96E90-0x0000000184E971F0
		public void __Gen_Wrap_262(object P0, int P1, bool P2, bool P3, bool P4, bool P5); // 0x0000000184E971F0-0x0000000184E97550
		public void __Gen_Wrap_263(object P0, int P1, int P2, int P3); // 0x0000000182582090-0x0000000182582390
		public void __Gen_Wrap_264(object P0, int P1, int? P2); // 0x0000000184E97550-0x0000000184E97BE0
		public bool __Gen_Wrap_265(object P0, int P1); // 0x0000000182460990-0x0000000182460C70
		public void __Gen_Wrap_266(object P0, int P1, int P2, bool P3, UIScrollList.ScrollAlignType P4, bool P5); // 0x0000000184E97BE0-0x0000000184E97F20
		public Vector2Int __Gen_Wrap_267(object P0, float P1); // 0x0000000184E97F20-0x0000000184E98830
		public bool __Gen_Wrap_268(object P0, int P1, int P2, int P3); // 0x0000000182E879F0-0x0000000182E87D00
		public void __Gen_Wrap_269(object P0, object P1, int P2, int P3); // 0x00000001826538B0-0x0000000182653C60
		public void __Gen_Wrap_270(object P0, Vector2Int P1, bool P2, bool P3); // 0x0000000184E98830-0x0000000184E98EF0
		public void __Gen_Wrap_271(object P0, object P1, bool P2, int P3, int P4); // 0x0000000184E98EF0-0x0000000184E992B0
		public void __Gen_Wrap_272(object P0, bool P1, int P2, int P3, int P4, bool P5, bool P6); // 0x0000000184E992B0-0x0000000184E99610
		public int __Gen_Wrap_273(object P0, int P1, int P2, int P3); // 0x0000000182BF2BB0-0x0000000182BF2EC0
		public GameObject __Gen_Wrap_274(object P0, int P1, int P2); // 0x0000000184E99610-0x0000000184E99F80
		public Vector3 __Gen_Wrap_275(); // 0x0000000184E99F80-0x0000000184E9A770
		public void __Gen_Wrap_276(Vector3 P0); // 0x0000000184E9A770-0x0000000184E9AD10
		public ref UIAtlasManager.UIAtlasHandle __Gen_Wrap_277(object P0); // 0x0000000184E9AD10-0x0000000184E9B630
		public UIAtlasManager.UIAtlasHandle __Gen_Wrap_278(UIAtlasManager.UIAtlasProcessFailureCause P0); // 0x0000000184E9B630-0x0000000184E9BE70
		public Texture __Gen_Wrap_279(object P0); // 0x0000000184E9BE70-0x0000000184E9C790
		public TweenerCore<float, float, FloatOptions> __Gen_Wrap_280(object P0, float P1, float P2); // 0x0000000184E9C790-0x0000000184E9D120
		public UIImage __Gen_Wrap_281(object P0); // 0x0000000184E9D120-0x0000000184E9DA40
		public bool __Gen_Wrap_282(ref UIInertiaViewPager.ScrollEffectConfig P0); // 0x0000000184E9DA40-0x0000000184E9E650
		public UIInertiaViewPager.State __Gen_Wrap_283(object P0, object P1); // 0x0000000182224290-0x0000000182224620
		public bool __Gen_Wrap_284(ref UIInertiaViewPager.InertiaBlocker P0, float P1); // 0x0000000184E9E650-0x0000000184E9F220
		public bool __Gen_Wrap_285(object P0, float P1, out float P2); // 0x0000000184E9F220-0x0000000184E9F540
		public void __Gen_Wrap_286(object P0, float P1, float P2); // 0x0000000183E99C30-0x0000000183E99F30
		public void __Gen_Wrap_287(object P0, UIInertiaViewPager.State P1, UIInertiaViewPager.State P2); // 0x00000001824F9690-0x00000001824F9980
		public void __Gen_Wrap_288(object P0, int P1, object P2); // 0x00000001824EC440-0x00000001824EC7E0
		public float __Gen_Wrap_289(ref UIInertiaViewPager.EmptyScrollHandler P0); // 0x0000000184E9F540-0x0000000184EA00E0
		public bool __Gen_Wrap_290(ref UIInertiaViewPager.EmptyScrollHandler P0); // 0x0000000184EA00E0-0x0000000184EA0C80
		public void __Gen_Wrap_291(ref UIInertiaViewPager.EmptyScrollHandler P0, float P1); // 0x0000000184EA0C80-0x0000000184EA1830
		public void __Gen_Wrap_292(ref UIInertiaViewPager.EmptyScrollHandler P0); // 0x0000000184EA1830-0x0000000184EA23C0
		public UIInputField __Gen_Wrap_293(); // 0x0000000184EA23C0-0x0000000184EA2BE0
		public void __Gen_Wrap_294(object P0, bool P1, Vector2 P2, Vector2 P3); // 0x0000000184EA2BE0-0x0000000184EA3370
		public void __Gen_Wrap_295(object P0, CanvasUpdate P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_296(object P0, object P1, object P2, object P3, object P4); // 0x00000001825AC140-0x00000001825AC720
		public UIMaterialAnimation.EPropKind __Gen_Wrap_297(int P0); // 0x0000000182655DC0-0x0000000182655FC0
		public Vector4 __Gen_Wrap_298(object P0, int P1); // 0x0000000184EA3370-0x0000000184EA3C70
		public void __Gen_Wrap_299(object P0, object P1, bool P2, bool P3, bool P4); // 0x0000000182F9BB20-0x0000000182F9BEF0
		public List<int> __Gen_Wrap_300(object P0); // 0x0000000184EA3C70-0x0000000184EA4590
		public List<bool> __Gen_Wrap_301(object P0); // 0x0000000184EA4590-0x0000000184EA4EB0
		public void __Gen_Wrap_302(object P0, int P1, object P2, bool P3); // 0x00000001824EA4F0-0x00000001824EA8B0
		public void __Gen_Wrap_303(object P0, float P1, float P2, float P3); // 0x00000001832ACB60-0x00000001832ACE80
		public MaterialPropertyBlock __Gen_Wrap_304(); // 0x0000000184EA4EB0-0x0000000184EA56D0
		public bool __Gen_Wrap_305(object P0, Vector3 P1); // 0x0000000184EA56D0-0x0000000184EA5D50
		public float __Gen_Wrap_306(object P0, Vector2 P1); // 0x0000000184EA5D50-0x0000000184EA63D0
		public bool __Gen_Wrap_307(object P0, float P1); // 0x000000018251F450-0x000000018251F740
		public UIScrollList.Padding __Gen_Wrap_308(object P0, bool P1); // 0x0000000184EA63D0-0x0000000184EA6CE0
		public void __Gen_Wrap_309(object P0, out int P1, out int P2); // 0x0000000183539D40-0x000000018353A060
		public int __Gen_Wrap_310(object P0, Vector2 P1, NaviDirection P2); // 0x0000000184EA6CE0-0x0000000184EA7380
		public void __Gen_Wrap_311(object P0, Vector2 P1, out int P2, out int P3); // 0x0000000184EA7380-0x0000000184EA7A70
		public UIScrollRect.MoveTipsType __Gen_Wrap_312(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public void __Gen_Wrap_313(object P0, object P1, object P2, UIScrollRectEdgeRedDot.ERedDotState P3); // 0x0000000182661FF0-0x0000000182662450
		public UIScrollRectEdgeRedDot.ERedDotState __Gen_Wrap_314(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public Rect __Gen_Wrap_315(object P0); // 0x0000000184EA7A70-0x0000000184EA8350
		public bool __Gen_Wrap_316(object P0, UIScrollRectEdgeRedDot.ERedDotState P1, UIScrollRectEdgeRedDot.ERedDotDir P2, object P3); // 0x00000001832D6710-0x00000001832D6AE0
		public void __Gen_Wrap_317(object P0, out UIScrollRectEdgeRedDot.ERedDotState P1, out UIScrollRectEdgeRedDot.ERedDotState P2); // 0x0000000183539D40-0x000000018353A060
		public void __Gen_Wrap_318(object P0, bool P1, float P2); // 0x0000000183BDC050-0x0000000183BDC350
		public Vector3 __Gen_Wrap_319(object P0, int P1); // 0x0000000184EA8350-0x0000000184EA8C50
		public Vector3[] __Gen_Wrap_320(object P0); // 0x0000000184EA8C50-0x0000000184EA9570
		public Vector4 __Gen_Wrap_321(object P0); // 0x0000000184EA9570-0x0000000184EA9E50
		public Vector4 __Gen_Wrap_322(Vector4 P0, Rect P1, Rect P2); // 0x0000000184EA9E50-0x0000000184EAAE30
		public Vector2 __Gen_Wrap_323(Vector2 P0, Vector4 P1); // 0x0000000184EAAE30-0x0000000184EABD20
		public UISoftMask.SlicedSpriteParams __Gen_Wrap_324(object P0); // 0x0000000184EABD20-0x0000000184EAC610
		public Graphic __Gen_Wrap_325(object P0); // 0x0000000184EAC610-0x0000000184EACF30
		public UISoftMask __Gen_Wrap_326(object P0); // 0x0000000184EACF30-0x0000000184EAD850
		public bool __Gen_Wrap_327(object P0, float P1, float P2); // 0x0000000183092410-0x0000000183092720
		public Vector2 __Gen_Wrap_328(object P0, Vector2 P1, Vector2 P2, Vector2 P3, Vector2 P4); // 0x0000000184EAD850-0x0000000184EAE680
		public void __Gen_Wrap_329(object P0, Vector2 P1, Vector2 P2, Vector2 P3, Vector2 P4, out float P5, out float P6); // 0x0000000184EAE680-0x0000000184EAF030
		public void __Gen_Wrap_330(ref UIVertex P0, Vector2 P1, Vector2 P2, Vector2 P3); // 0x0000000184EAF030-0x0000000184EAFFF0
		public void __Gen_Wrap_331(object P0, object P1, object P2, out bool P3); // 0x0000000184EAFFF0-0x0000000184EB0480
		public UISoftMaskable __Gen_Wrap_332(object P0); // 0x0000000184EB0480-0x0000000184EB0DA0
		public IEnumerator __Gen_Wrap_333(object P0, bool P1, int P2); // 0x0000000184EB0DA0-0x0000000184EB1710
		public void __Gen_Wrap_334(object P0, bool P1, int P2); // 0x0000000183041590-0x0000000183041880
		public void __Gen_Wrap_335(object P0, object P1, bool P2, object P3, object P4, object P5, bool P6); // 0x0000000184EB1710-0x0000000184EB1D40
		public uint __Gen_Wrap_336(object P0); // 0x000000018246EB30-0x000000018246EDF0
		public void __Gen_Wrap_337(uint P0, bool P1); // 0x0000000183592390-0x0000000183592590
		public TMP_FontAsset __Gen_Wrap_338(object P0, object P1); // 0x0000000184EB1D40-0x0000000184EB2740
		public bool __Gen_Wrap_339(object P0, object P1, uint P2, out TMP_FontAsset P3); // 0x0000000184EB2740-0x0000000184EB3220
		public bool __Gen_Wrap_340(ref float P0, float P1); // 0x0000000184E38620-0x0000000184E38870
		public void __Gen_Wrap_341(ref TweenUtils.FLerpByTime P0, object P1); // 0x0000000184EB3220-0x0000000184EB3F20
		public float __Gen_Wrap_342(ref TweenUtils.FLerpByTime P0, out bool P1); // 0x0000000184EB3F20-0x0000000184EB4B00
		public PlayableGraph __Gen_Wrap_343(object P0); // 0x0000000184EB4B00-0x0000000184EB53E0
		public AnimationLayerMixerPlayable __Gen_Wrap_344(object P0, PlayableGraph P1, out GenericShareSingleMixerAssetPlayer<AnimationClip> P2); // 0x0000000184EB53E0-0x0000000184EB6390
		public AnimationPlayableOutput __Gen_Wrap_345(object P0, PlayableGraph P1); // 0x0000000184EB6390-0x0000000184EB6FD0
		public AnimationClipPlayable __Gen_Wrap_346(object P0, object P1, PlayableGraph P2, out GenericShareSingleMixerAssetPlayer<AnimationClip> P3); // 0x0000000184EB6FD0-0x0000000184EB7ED0
		public AnimationMixerPlayable __Gen_Wrap_347(object P0, PlayableGraph P1, out GenericShareSingleMixerAssetPlayer<AnimationClip> P2); // 0x0000000184EB7ED0-0x0000000184EB8E80
		public void __Gen_Wrap_348(bool P0, FAssetProxyHandle P1); // 0x0000000184EB8E80-0x0000000184EB9430
		public void __Gen_Wrap_349(ref UISwitchTween.TweenContext P0); // 0x0000000184EB9430-0x0000000184EB9FD0
		public void __Gen_Wrap_350(ref UISwitchTween.TweenContext P0, object P1); // 0x0000000184EB9FD0-0x0000000184EBAC60
		public void __Gen_Wrap_351(object P0, UISwitchTween.Options P1); // 0x0000000184EBAC60-0x0000000184EBB2D0
		public UISwitchTween.TweenContext __Gen_Wrap_352(object P0); // 0x0000000184EBB2D0-0x0000000184EBBBB0
		public bool __Gen_Wrap_353(ref UISwitchTween.TweenContext P0); // 0x0000000184EBBBB0-0x0000000184EBC760
		public float __Gen_Wrap_354(ref FadeSwitchTween.Durations P0, float P1); // 0x0000000184EBC760-0x0000000184EBD320
		public FadeSwitchTween __Gen_Wrap_355(ref FadeSwitchTween.Builder P0); // 0x0000000184EBD320-0x0000000184EBE220
		public Vector2 __Gen_Wrap_356(object P0, bool P1); // 0x0000000184EBE220-0x0000000184EBEB40
		public void __Gen_Wrap_357(object P0, in RectInt P1); // 0x0000000184EBEB40-0x0000000184EBF1C0
		public bool __Gen_Wrap_358(object P0, object P1, out UIAtlasManager.UIAtlasProcessFailureCause P2); // 0x0000000182E0C230-0x0000000182E0C600
		public RectInt __Gen_Wrap_359(object P0, int P1, int P2); // 0x0000000184EBF1C0-0x0000000184EBFAD0
		public void __Gen_Wrap_360(object P0, object P1, object P2, in RectInt P3); // 0x0000000184EBFAD0-0x0000000184EC02F0
		public bool __Gen_Wrap_361(ref UIAtlasManager.UIAtlasHandle P0); // 0x0000000184EC02F0-0x0000000184EC0EB0
		public void __Gen_Wrap_362(object P0, in List<RectInt> P1); // 0x0000000182E8B6E0-0x0000000182E8BA70
		public UIMaterialAnimation __Gen_Wrap_363(object P0); // 0x0000000184EC0EB0-0x0000000184EC17D0
		public UIAnimationWrapper __Gen_Wrap_364(object P0); // 0x0000000184EC17D0-0x0000000184EC20F0
		public void __Gen_Wrap_365(int P0, string P1); // 0x0000000182220EE0-0x00000001822211B0
		public void __Gen_Wrap_366(string P0); // 0x0000000182510780-0x0000000182510A40
		public byte __Gen_Wrap_367(UnityEngine.WrapMode P0); // 0x0000000182655DC0-0x0000000182655FC0
		public byte __Gen_Wrap_368(int P0, bool P1); // 0x0000000184EC20F0-0x0000000184EC2310
		public GPUIExtendedPrefabData __Gen_Wrap_369(Vector4 P0, Vector4 P1, Vector2 P2); // 0x0000000184EC2310-0x0000000184EC3310
		public GPUIExtendedPrefabDataLite __Gen_Wrap_370(Vector4 P0, Vector4 P1, Vector2 P2); // 0x0000000184EC3310-0x0000000184EC4300
		public GPUIRootTransformState __Gen_Wrap_371(); // 0x0000000184EC4300-0x0000000184EC4B00
		public GPUISubrootDomainState __Gen_Wrap_372(); // 0x0000000184EC4B00-0x0000000184EC52F0
		public GPUIExtendedAnimationState __Gen_Wrap_373(); // 0x0000000184EC52F0-0x0000000184EC5AD0
		public GPUIResolvedSubrootState __Gen_Wrap_374(in GPUIRootTransformState P0, in GPUISubrootDomainState P1); // 0x0000000184EC5AD0-0x0000000184EC6A30
		public uint __Gen_Wrap_375(ushort P0, ushort P1); // 0x0000000184EC6A30-0x0000000184EC6C40
		public uint __Gen_Wrap_376(ushort P0, byte P1, byte P2); // 0x0000000184EC6C40-0x0000000184EC6E80
		public uint __Gen_Wrap_377(float P0); // 0x0000000183876730-0x0000000183876920
		public int __Gen_Wrap_378(byte P0); // 0x0000000182655FC0-0x00000001826561C0
		public int __Gen_Wrap_379(float P0); // 0x0000000183876730-0x0000000183876920
		public short __Gen_Wrap_380(float P0); // 0x0000000184EC6E80-0x0000000184EC7070
		public void __Gen_Wrap_381(Quaternion P0, out int P1, out int P2); // 0x0000000184EC7070-0x0000000184EC7690
		public GPUPrefabData __Gen_Wrap_382(Vector4 P0, Vector4 P1, Vector2 P2); // 0x0000000184EC7690-0x0000000184EC8690
		public GPUPrefabDataLite __Gen_Wrap_383(Vector4 P0, Vector4 P1, Vector2 P2); // 0x0000000184EC8690-0x0000000184EC9680
		public uint __Gen_Wrap_384(uint P0, uint P1); // 0x00000001825DB8C0-0x00000001825DBAD0
		public Texture2D __Gen_Wrap_385(object P0); // 0x0000000184EC9680-0x0000000184EC9FA0
		public RectInt __Gen_Wrap_386(object P0); // 0x0000000184EC9FA0-0x0000000184ECA880
		public bool __Gen_Wrap_387(object P0, object P1, RectInt P2); // 0x0000000184ECA880-0x0000000184ECAFD0
		public bool __Gen_Wrap_388(object P0, UICustomAtlasCopyStatus P1); // 0x0000000182676010-0x00000001826762F0
		public void __Gen_Wrap_389(object P0, GPUIExtendedDynamicAtlas.DynamicAtlasFailureCause P1); // 0x00000001824828A0-0x0000000182482B70
		public void __Gen_Wrap_390(object P0, object P1, RectInt P2); // 0x0000000184ECAFD0-0x0000000184ECB710
		public GPUIExtendedDynamicAtlas.DynamicSpriteHandle __Gen_Wrap_391(); // 0x0000000184ECB710-0x0000000184ECBEF0
		public bool __Gen_Wrap_392(object P0, object P1, out GPUIExtendedDynamicAtlas.DynamicAtlasFailureCause P2); // 0x0000000182E0C230-0x0000000182E0C600
		public bool __Gen_Wrap_393(object P0, object P1, out GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2, out Vector4 P3); // 0x0000000184ECBEF0-0x0000000184ECCC50
		public bool __Gen_Wrap_394(ref GPUIExtendedDynamicAtlas.DynamicSpriteHandle P0); // 0x0000000184ECCC50-0x0000000184ECD840
		public bool __Gen_Wrap_395(object P0, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P1, out bool P2); // 0x0000000184ECD840-0x0000000184ECDF00
		public bool __Gen_Wrap_396(object P0, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P1); // 0x0000000184ECDF00-0x0000000184ECE580
		public UICustomAtlasCopyStatus __Gen_Wrap_397(object P0); // 0x0000000182226590-0x0000000182226850
		public void __Gen_Wrap_398(object P0, object P1, Vector4 P2); // 0x0000000184ECE580-0x0000000184ECECC0
		public void __Gen_Wrap_399(ref GPUIExtendedPrefabDataLite P0, Vector4 P1, Vector2 P2); // 0x0000000184ECECC0-0x0000000184ECFC80
		public bool __Gen_Wrap_400(object P0, int P1, object P2, out GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P3, out ushort P4); // 0x0000000184ECFC80-0x0000000184ED0760
		public void __Gen_Wrap_401(object P0, GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P1); // 0x0000000184ED0760-0x0000000184ED0DD0
		public bool __Gen_Wrap_402(ref GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P0, GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P1); // 0x0000000184ED0DD0-0x0000000184ED1AE0
		public bool __Gen_Wrap_403(ref GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P0, object P1); // 0x0000000184ED1AE0-0x0000000184ED27F0
		public int __Gen_Wrap_404(ref GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P0); // 0x0000000184ED27F0-0x0000000184ED3400
		public bool __Gen_Wrap_405(object P0, object P1, out GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2); // 0x0000000184ED3400-0x0000000184ED3E80
		public bool __Gen_Wrap_406(object P0, int P1, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2, out GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P3, out ushort P4); // 0x0000000184ED3E80-0x0000000184ED4B30
		public bool __Gen_Wrap_407(object P0, GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P1, int P2, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P3); // 0x0000000184ED4B30-0x0000000184ED5530
		public void __Gen_Wrap_408(object P0, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P1); // 0x0000000184ED5530-0x0000000184ED5BA0
		public GPUIExtendedRuntimePrefabData __Gen_Wrap_409(object P0); // 0x0000000184ED5BA0-0x0000000184ED64C0
		public GPUIExtendedRuntimeAnimationData __Gen_Wrap_410(object P0, int P1); // 0x0000000184ED64C0-0x0000000184ED6E10
		public bool __Gen_Wrap_411(in GPUIExtendedRuntimeInstance.SpriteOverrideState P0); // 0x0000000184ED6E10-0x0000000184ED73E0
		public void __Gen_Wrap_412(object P0, in GPUIExtendedRuntimeInstance.SpriteOverrideState P1); // 0x0000000184ED73E0-0x0000000184ED7A80
		public void __Gen_Wrap_413(object P0, ref NativeArray<GPUIExtendedInstanceData> P1, int P2, ref int P3, GPUIExtendedInstanceData P4); // 0x0000000184ED7A80-0x0000000184ED8900
		public void __Gen_Wrap_414(object P0, ref NativeArray<GPUIExtendedInstanceData> P1, int P2, ref int P3); // 0x0000000184ED8900-0x0000000184ED9550
		public GPUIExtendedAnimationState __Gen_Wrap_415(object P0, in GPUIExtendedRuntimeNodeInfo P1); // 0x0000000184ED9550-0x0000000184EDA200
		public uint __Gen_Wrap_416(uint P0); // 0x00000001824E3DB0-0x00000001824E3FB0
		public void __Gen_Wrap_417(object P0, int P1, ref GPUIExtendedInstanceData P2); // 0x0000000184EDA200-0x0000000184EDAEB0
		public byte __Gen_Wrap_418(float P0); // 0x00000001841194D0-0x00000001841196C0
		public void __Gen_Wrap_419(object P0, ref NativeArray<GPUIExtendedInstanceData> P1, int P2, bool P3); // 0x0000000184EDAEB0-0x0000000184EDBB60
		public void __Gen_Wrap_420(object P0, Quaternion P1); // 0x0000000184EDBB60-0x0000000184EDC1D0
		public void __Gen_Wrap_421(object P0, float P1, int P2); // 0x0000000182B57710-0x0000000182B57A00
		public bool __Gen_Wrap_422(object P0, int P1, float P2, int P3); // 0x0000000184EDC1D0-0x0000000184EDC4F0
		public uint __Gen_Wrap_423(UnityEngine.Color P0); // 0x0000000184EDC4F0-0x0000000184EDCAA0
		public void __Gen_Wrap_424(object P0, int P1, UnityEngine.Color P2); // 0x0000000184EDCAA0-0x0000000184EDD110
		public void __Gen_Wrap_425(object P0, int P1, Vector2 P2, Vector2 P3, float P4); // 0x0000000184EDD110-0x0000000184EDD8C0
		public bool __Gen_Wrap_426(object P0, int P1, out int P2); // 0x00000001831415B0-0x00000001831418C0
		public bool __Gen_Wrap_427(object P0, int P1, ref GPUIExtendedRuntimeInstance.SpriteOverrideState P2); // 0x0000000184EDD8C0-0x0000000184EDE600
		public bool __Gen_Wrap_428(object P0, int P1, ref GPUIExtendedRuntimeInstance.SpriteOverrideState P2, ref GPUIExtendedRuntimeInstance.SpriteOverrideState P3); // 0x0000000184EDE600-0x0000000184EDF4C0
		public bool __Gen_Wrap_429(object P0, int P1, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2); // 0x0000000184EDF4C0-0x0000000184EDFB40
		public GPUIHandle __Gen_Wrap_430(object P0); // 0x0000000184EDFB40-0x0000000184EE0400
		public bool __Gen_Wrap_431(object P0, object P1, Vector3 P2, out GPUIHandle P3, int P4); // 0x0000000184EE0400-0x0000000184EE10F0
		public bool __Gen_Wrap_432(object P0, GPUIHandle P1); // 0x0000000184EE10F0-0x0000000184EE1790
		public bool __Gen_Wrap_433(object P0, GPUIHandle P1, Vector3 P2); // 0x0000000184EE1790-0x0000000184EE2180
		public bool __Gen_Wrap_434(object P0, GPUIHandle P1, Vector2 P2); // 0x0000000184EE2180-0x0000000184EE2B60
		public bool __Gen_Wrap_435(object P0, GPUIHandle P1, Quaternion P2); // 0x0000000184EE2B60-0x0000000184EE3540
		public bool __Gen_Wrap_436(object P0, GPUIHandle P1, object P2, out GPUIExtendedRuntimeInstance P3, out int P4); // 0x0000000184EE3540-0x0000000184EE4230
		public bool __Gen_Wrap_437(object P0, GPUIHandle P1, object P2, bool P3); // 0x0000000184EE4230-0x0000000184EE49A0
		public bool __Gen_Wrap_438(object P0, GPUIHandle P1, object P2, Vector2 P3, Vector2 P4, float P5); // 0x0000000184EE49A0-0x0000000184EE5560
		public bool __Gen_Wrap_439(object P0, GPUIHandle P1, object P2, UnityEngine.Color P3); // 0x0000000184EE5560-0x0000000184EE6010
		public bool __Gen_Wrap_440(object P0, GPUIHandle P1, object P2, float P3); // 0x0000000184EE6010-0x0000000184EE6790
		public bool __Gen_Wrap_441(object P0, GPUIHandle P1, object P2, object P3); // 0x0000000184EE6790-0x0000000184EE6FB0
		public bool __Gen_Wrap_442(object P0, GPUIHandle P1, bool P2, int P3); // 0x0000000184EE6FB0-0x0000000184EE7680
		public bool __Gen_Wrap_443(object P0, GPUIHandle P1, bool P2, object P3); // 0x0000000184EE7680-0x0000000184EE7DF0
		public bool __Gen_Wrap_444(object P0, GPUIHandle P1, object P2, out float P3); // 0x0000000184EE7DF0-0x0000000184EE8580
		public bool __Gen_Wrap_445(object P0, GPUIHandle P1, object P2, object P3, out float P4); // 0x0000000184EE8580-0x0000000184EE8DE0
		public bool __Gen_Wrap_446(object P0, object P1, out int P2, out int P3); // 0x0000000182CA8010-0x0000000182CA8410
		public void __Gen_Wrap_447(object P0, bool P1, int P2, int P3); // 0x0000000184985060-0x0000000184985370
		public int __Gen_Wrap_448(object P0, object P1, int P2); // 0x0000000182CD0600-0x0000000182CD09A0
		public GPUIExtendedRuntimePrefabData __Gen_Wrap_449(object P0, object P1); // 0x0000000184EE8DE0-0x0000000184EE97E0
		public bool __Gen_Wrap_450(ref GPUIHandle P0, GPUIHandle P1); // 0x0000000184EE97E0-0x0000000184EEA480
		public bool __Gen_Wrap_451(ref GPUIHandle P0, object P1); // 0x0000000184EEA480-0x0000000184EEB120
		public int __Gen_Wrap_452(ref GPUIHandle P0); // 0x0000000184EEB120-0x0000000184EEBCC0
		public bool __Gen_Wrap_453(GPUIHandle P0, GPUIHandle P1); // 0x0000000184EEBCC0-0x0000000184EEC360
		public GPUIExtendedSystem __Gen_Wrap_454(object P0); // 0x0000000184EEC360-0x0000000184EECC80
		public GPUIProxySyncManager __Gen_Wrap_455(object P0); // 0x0000000184EECC80-0x0000000184EED5A0
		public bool __Gen_Wrap_456(object P0, out RectTransform P1, out Camera P2); // 0x0000000184EED5A0-0x0000000184EEE2E0
		public bool __Gen_Wrap_457(object P0, object P1, object P2, object P3); // 0x0000000184E358F0-0x0000000184E35E20
		public bool __Gen_Wrap_458(object P0, bool P1); // 0x000000018251D250-0x000000018251D540
		public bool __Gen_Wrap_459(object P0, object P1, object P2, out Vector2 P3); // 0x0000000184EEE2E0-0x0000000184EEEDE0
		public bool __Gen_Wrap_460(object P0, object P1, object P2, bool P3, Vector3 P4); // 0x0000000184EEEDE0-0x0000000184EEF620
		public bool __Gen_Wrap_461(object P0, object P1, object P2, bool P3); // 0x00000001832C0DF0-0x00000001832C1260
		public bool __Gen_Wrap_462(object P0, out GPUIExtendedSystem P1); // 0x0000000184EEF620-0x0000000184EF0030
		public bool __Gen_Wrap_463(object P0, object P1, out GPUIHandle P2, int P3); // 0x0000000184EF0030-0x0000000184EF0A60
		public void __Gen_Wrap_464(object P0, int P1, Vector3 P2); // 0x0000000184EF0A60-0x0000000184EF10E0
		public void __Gen_Wrap_465(object P0, GPUIHandle P1); // 0x0000000184EF10E0-0x0000000184EF1770
		public RuntimePrefabData __Gen_Wrap_466(object P0); // 0x0000000184EF1770-0x0000000184EF2090
		public bool __Gen_Wrap_467(object P0, GPUIHandle P1, bool P2, object P3, bool P4); // 0x0000000184EF2090-0x0000000184EF2820
		public bool __Gen_Wrap_468(object P0, GPUIHandle P1, bool P2, int P3, bool P4); // 0x0000000184EF2820-0x0000000184EF2F10
		public RuntimePrefabData __Gen_Wrap_469(object P0, object P1); // 0x0000000184EF2F10-0x0000000184EF3910
		public Mesh __Gen_Wrap_470(); // 0x0000000184EF3910-0x0000000184EF4130
		public void __Gen_Wrap_471(object P0, ref NativeArray<GPUInstanceData> P1, int P2, bool P3); // 0x0000000184EF4130-0x0000000184EF4DE0
	}

	public class ILFixInterfaceBridge : AnonymousStorey, IEnumerator<object> // TypeDefIndex: 74744
	{
		// Fields
		private int methodId_0; // 0x40
		private int methodId_1; // 0x44
		private int methodId_2; // 0x48
		private int methodId_3; // 0x4C
		private int methodId_4; // 0x50
	
		// Properties
		object IEnumerator<System.Object>.Current { [IDTag(2)] get; } // 0x000000018D24D1CC-0x000000018D24D27C 
		object IEnumerator.Current { [IDTag(4)] get; } // 0x000000018D24D27C-0x000000018D24D32C 
	
		// Constructors
		public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine); // 0x000000018D24D32C-0x000000018D24D40C
	
		// Methods
		[IDTag(0)]
		void IDisposable.Dispose(); // 0x00000001887F0184-0x00000001887F0204
		[IDTag(1)]
		private bool MoveNext(); // 0x00000001887EFF14-0x00000001887EFFA4
		[IDTag(3)]
		void IEnumerator.Reset(); // 0x00000001887F0054-0x00000001887F00D4
		public void RefAsyncBuilderStartMethod(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class WrappersManagerImpl : WrappersManager // TypeDefIndex: 74745
	{
		// Fields
		private VirtualMachine virtualMachine; // 0x10
	
		// Constructors
		public WrappersManagerImpl(VirtualMachine virtualMachine); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public static ILFixDynamicMethodWrapper GetPatch(int id); // 0x000000018D24D7AC-0x000000018D24D810
		public static bool IsPatched(int id); // 0x000000018D24D89C-0x000000018D24D918
		public Delegate CreateDelegate(System.Type type, int id, object anon); // 0x000000018D24D664-0x000000018D24D730
		public object CreateWrapper(int id); // 0x000000018D24D730-0x000000018D24D7AC
		public object InitWrapperArray(int len); // 0x000000018D24D810-0x000000018D24D89C
		public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine); // 0x000000018D24D5C0-0x000000018D24D664
	}

	public delegate void __HotPatchDelegate_0(); // TypeDefIndex: 74746; 0x0000000185B44B70-0x0000000185B44B80

	public enum HotPatchIDMAP0 // TypeDefIndex: 74747
	{
		Beyond-PoolCore-ListPoolInitializer_UI_Beyond-Initialize0 = 0,
		Beyond-PoolCore-ListPoolInitializer_UI_Beyond-InitializeAtRuntime0 = 0,
		Beyond-UI-ControllerSideMenuItemList-ClearForceValidItemList0 = 0,
		Beyond-UI-UIActionKeyHint-_RefreshAllKeyHints0 = 0,
		Beyond-UI-UIActionKeyHint-_OnInputLateTickAll0 = 0,
		Beyond-UI-UIActionKeyHint-_TryInit0 = 0,
		Beyond-UI-UIBlendImage-ClearMaterialCache0 = 0,
		Beyond-UI-UIControllerKeyIcon-_TryStaticInit0 = 0,
		Beyond-UI-UICustomLayoutElement-RefreshAll0 = 0,
		Beyond-UI-UIImage-_V2AtlasInitialize0 = 0,
		Beyond-UI-CSPopupPanel-ClearAllPanels0 = 0,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputHorizontal0 = 1,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-CalculateLayoutInputVertical0 = 1,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-_InitState0 = 1,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdatePos0 = 1,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-_UpdateLookAtCamera0 = 1,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-OnEnable0 = 1,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-Start0 = 1,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-ForceUpdate0 = 1,
		Beyond-UI-UIText-HyperlinkUITextGroup-_NotifyDisplayableChanged0 = 1,
		Beyond-UI-UIText-HyperlinkUITextGroup-_AddDisplayableCount0 = 1,
		Beyond-UI-UIText-HyperlinkUITextGroup-_SubDisplayableCount0 = 1,
		Beyond-UI-UIText-_ReleaseUpdateFunction0 = 1,
		Beyond-UI-UIText-_CreateUpdateFunction0 = 1,
		Beyond-UI-UIText-ClearMesh0 = 1,
		Beyond-UI-UIText-_ClearInlineImage0 = 1,
		Beyond-UI-UIText-_ProcessRichTextInfo0 = 1,
		Beyond-UI-UIText-RefreshPopulateText0 = 1,
		Beyond-UI-UIText-DisposeInlineImageCache0 = 1,
		Beyond-UI-UIText-ClearComponent0 = 1,
		Beyond-UI-UIText-OnDestroy0 = 1,
		Beyond-UI-UIText-_GenerateRuntimeText0 = 1,
		Beyond-UI-UIText-_RefreshMatTexture0 = 1,
		Beyond-UI-UIText-Awake0 = 1,
		Beyond-UI-UIText-HyperlinkUITextWrap-Clear0 = 1,
		Beyond-UI-UIText-Start0 = 1,
		Beyond-UI-UIText-OnEnable0 = 1,
		Beyond-UI-UIText-OnDisable0 = 1,
		Beyond-UI-UIText-ShrinkLinkTags0 = 1,
		Beyond-UI-UIText-UpdateI18NFontAsset0 = 1,
		Beyond-UI-UIText-UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize0 = 1,
		Beyond-UI-UIText-OnAfterDeserialize0 = 1,
		Beyond-UI-UIModelLoader-_Clear0 = 1,
		Beyond-UI-UIModelLoader-Dispose0 = 1,
		Beyond-UI-UIUtils-ClearUIComponents0 = 1,
		Beyond-UI-ActiveSyncHelper-Sync0 = 1,
		Beyond-UI-ActiveSyncHelper-Awake0 = 1,
		Beyond-UI-ActiveSyncHelper-OnEnable0 = 1,
		Beyond-UI-ActiveSyncHelper-OnDisable0 = 1,
		Beyond-UI-Billboard-OnEnable0 = 1,
		Beyond-UI-UIScrollList-ClearShowingCells0 = 1,
		Beyond-UI-LuaPanel-RecoverAllInput0 = 1,
		Beyond-UI-UIAnimationWrapper-_NotifyAnimationInEasingFinished0 = 1,
		Beyond-UI-UIAnimationWrapper-_InitAnimation0 = 1,
		Beyond-UI-UIAnimationWrapper-PlayLoopAudio0 = 1,
		Beyond-UI-UIAnimationWrapper-PlayOpenAudio0 = 1,
		Beyond-UI-UIScrollList-UpdateMoveTips0 = 1,
		Beyond-UI-UIScrollList-UpdateViewEffect0 = 1,
		Beyond-UI-UIScrollList-_SyncNaviTargetOnStickScroll0 = 1,
		Beyond-UI-UIButton-_UpdateState0 = 1,
		Beyond-UI-UIButton-_OnUpdateKey0 = 1,
		Beyond-UI-UIButton-_InitActionOnSetNaviTarget0 = 1,
		Beyond-UI-UIButton-InitBinding0 = 1,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-Execute0 = 1,
		Beyond-UI-CustomUIStyle-CheckState0 = 1,
		Beyond-UI-CustomUIStyle-_OnActiveTypeChanged0 = 1,
		Beyond-UI-CustomUIStyle-OnDestroy0 = 1,
		Beyond-UI-CustomUIStyle-OnEnable0 = 1,
		Beyond-UI-CustomUIStyle-Awake0 = 1,
		Beyond-UI-DeactivateNaviOnEnable-OnEnable0 = 1,
		Beyond-UI-DeactivateNaviOnEnable-OnDisable0 = 1,
		Beyond-UI-DecoLineActiveHelper-Reset0 = 1,
		Beyond-UI-DecoLineActiveHelper-OnEnable0 = 1,
		Beyond-UI-FitAspectRatioByFOV-_AdjustFOV0 = 1,
		Beyond-UI-FitAspectRatioByFOV-Start0 = 1,
		Beyond-UI-FitAspectRatioByFOV-OnEnable0 = 1,
		Beyond-UI-FitAspectRatioByFOV-OnDisable0 = 1,
		Beyond-UI-FullScreenSceneBlurMarker-Awake0 = 1,
		Beyond-UI-FullScreenSceneBlurMarker-OnEnable0 = 1,
		Beyond-UI-FullScreenSceneBlurMarker-OnDisable0 = 1,
		Beyond-UI-FullScreenSceneBlurMarker-OnDestroy0 = 1,
		Beyond-UI-InputBindingGroupNaviDecorator-_SetSelfEnabledStateIfNecessary0 = 1,
		Beyond-UI-InputBindingGroupNaviDecorator-Awake0 = 1,
		Beyond-UI-InputBindingGroupNaviDecorator-OnEnable0 = 1,
		Beyond-UI-InputBindingGroupNaviDecorator-ClearComponent0 = 1,
		Beyond-UI-InputBindingGroupNaviDecorator-OnDestroy0 = 1,
		Beyond-UI-UILoopScrollRect-AutoScrollState-Reset0 = 1,
		Beyond-UI-UILoopScrollRect-_RefreshToggle0 = 1,
		Beyond-UI-UILoopScrollRect-_PlayEndAudio0 = 1,
		Beyond-UI-UILoopScrollRect-AutoScrollState-Complete0 = 1,
		Beyond-UI-UILoopScrollRect-ClearComponent0 = 1,
		Beyond-UI-UILoopScrollView-Initialize0 = 1,
		Beyond-UI-UILoopScrollView-ClearComponent0 = 1,
		Beyond-UI-UILoopScrollView-OnRelease0 = 1,
		Beyond-UI-UILoopScrollView-_InitController0 = 1,
		Beyond-UI-UILoopScrollView-OnEnable0 = 1,
		Beyond-UI-LuaPanel-_TrySetRot0 = 1,
		Beyond-UI-LuaPanel-Awake0 = 1,
		Beyond-UI-LuaPanel-Start0 = 1,
		Beyond-UI-LuaPanel-BlockAllInput0 = 1,
		Beyond-UI-LuaPanel-OnEnable0 = 1,
		Beyond-UI-LuaPanel-OnDisable0 = 1,
		Beyond-UI-LuaPanel-ClearComponent0 = 1,
		Beyond-UI-LuaPanel-OnDestroy0 = 1,
		Beyond-UI-MouseHoverTipsPosHelper-OnAwake0 = 1,
		Beyond-UI-MouseHoverTipsPosHelper-UpdatePosition0 = 1,
		Beyond-UI-MouseHoverTipsPosHelper-OnEnable0 = 1,
		Beyond-UI-NaviToThisGroupOnEnable-Reset0 = 1,
		Beyond-UI-NaviToThisGroupOnEnable-Awake0 = 1,
		Beyond-UI-NaviToThisGroupOnEnable-OnEnable0 = 1,
		Beyond-UI-NonDrawingGraphic-SetMaterialDirty0 = 1,
		Beyond-UI-NonDrawingGraphic-SetVerticesDirty0 = 1,
		Beyond-UI-NotchAdapter-ClearNullRef0 = 1,
		Beyond-UI-NotchAdapter-ApplyNewNotch0 = 1,
		Beyond-UI-NotchAdapter-_OnCanvasChanged0 = 1,
		Beyond-UI-NotchAdapter-ClearList0 = 1,
		Beyond-UI-NotchAdapter-Awake0 = 1,
		Beyond-UI-NotchAdapter-OnDestroy0 = 1,
		Beyond-UI-NotchAdapter-ApplyNotch1 = 1,
		Beyond-UI-NotchAdapter-UnApplyNotch0 = 1,
		Beyond-UI-ParallaxHelper-RefreshPos0 = 1,
		Beyond-UI-ParallaxHelper-InitConfigs0 = 1,
		Beyond-UI-ParallaxHelper-ResetValue0 = 1,
		Beyond-UI-PercentNumberTweener-Reset0 = 1,
		Beyond-UI-PercentNumberTweener-OnEnable0 = 1,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-DetachView0 = 1,
		Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputHorizontal0 = 1,
		Beyond-UI-UIRecycleLayoutGroup-CalculateLayoutInputVertical0 = 1,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-RecycleAll0 = 1,
		Beyond-UI-UIRecycleLayoutGroup-_RebuildAllViews0 = 1,
		Beyond-UI-UIRecycleLayoutGroup-ClearComponent0 = 1,
		Beyond-UI-UIRecycleLayoutGroup-OnLateTick0 = 1,
		Beyond-UI-UIRecycleLayoutGroup-_RefreshLayout0 = 1,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyAllViewSizeChanged0 = 1,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyRebuild0 = 1,
		Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-OnInit0 = 1,
		Beyond-UI-UIRecycleMultiHolder-OnAdapterInit0 = 1,
		Beyond-UI-UIRecycleMultiHolder-ClearComponent0 = 1,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewDetached0 = 1,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-OnViewAttached0 = 1,
		Beyond-UI-UIRecycleSingleHolder-OnAdapterInit0 = 1,
		Beyond-UI-UIRecycleSingleHolder-ClearComponent0 = 1,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewDetached0 = 1,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-OnViewAttached0 = 1,
		Beyond-UI-SimpleUITextSingleLine-GenerateTextMesh0 = 1,
		Beyond-UI-ToastList-Awake0 = 1,
		Beyond-UI-ToastList-ClearAllToast0 = 1,
		Beyond-UI-ToastList-OnDisable0 = 1,
		Beyond-UI-UIAnimationWrapper-PlayCloseAudio0 = 1,
		Beyond-UI-ToastList-_TryShowNewCell0 = 1,
		Beyond-UI-ToastList-ClearComponent0 = 1,
		Beyond-UI-UIImage-DisposeSpriteHandle0 = 1,
		Beyond-UI-UIActionKeyHint-_UpdateKeyHintCore0 = 1,
		Beyond-UI-UIActionKeyHint-_UpdateDynamicRegistration0 = 1,
		Beyond-UI-UIActionKeyHint-UpdateKeyHint0 = 1,
		Beyond-UI-UIActionKeyHint-Awake0 = 1,
		Beyond-UI-UIActionKeyHint-_UnsubscribeTarget0 = 1,
		Beyond-UI-UIActionKeyHint-OnEnable0 = 1,
		Beyond-UI-UIActionKeyHint-OnDisable0 = 1,
		Beyond-UI-UIActionKeyHint-ClearComponent0 = 1,
		Beyond-UI-UIActionKeyHint-OnDestroy0 = 1,
		Beyond-UI-UIActionKeyHint-Reset0 = 1,
		Beyond-UI-UIActionKeyHint-_OnChangeTarget0 = 1,
		Beyond-UI-UIAnimationWrapper-_AnimationInLoopCheck0 = 1,
		Beyond-UI-UIAnimationWrapper-_AnimationAutomaticallyCheck0 = 1,
		Beyond-UI-UIAnimationWrapper-Awake0 = 1,
		Beyond-UI-UIAnimationWrapper-SkipInAnimation0 = 1,
		Beyond-UI-UIAnimationWrapper-SampleToInAnimationBegin0 = 1,
		Beyond-UI-UIAnimationWrapper-SampleToInAnimationEnd0 = 1,
		Beyond-UI-UIAnimationWrapper-SampleToOutAnimationBegin0 = 1,
		Beyond-UI-UIAnimationWrapper-SampleToOutAnimationEnd0 = 1,
		Beyond-UI-UIAnimationWrapper-Start0 = 1,
		Beyond-UI-UIAnimationWrapper-OnEnable0 = 1,
		Beyond-UI-UIAnimationWrapper-OnDisable0 = 1,
		Beyond-UI-UIAnimationWrapper-ClearComponent0 = 1,
		Beyond-UI-UIAnimationWrapper-OnDestroy0 = 1,
		Beyond-UI-UIAnimationSwitchTween-BeforeShowEffect0 = 1,
		Beyond-UI-UIAnimationSwitchTween-AfterHideEffect0 = 1,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-KillIfNecessary0 = 1,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-_OnComplete0 = 1,
		Beyond-UI-UIArea-OnAwake0 = 1,
		Beyond-UI-UIArea-OnEnable0 = 1,
		Beyond-UI-UIArea-OnDisable0 = 1,
		Beyond-UI-UIArea-OnDestroy0 = 1,
		Beyond-UI-UIArea-ClearComponent0 = 1,
		Beyond-UI-UIAutoCloseArea-AddToAutoCloseLayer0 = 1,
		Beyond-UI-UIAutoCloseArea-RemoveFromAutoCloseLayer0 = 1,
		Beyond-UI-UIAutoCloseArea-_AutoCloseToggleObjWhenOut0 = 1,
		Beyond-UI-UIAutoCloseArea-CloseSelf0 = 1,
		Beyond-UI-UIAutoCloseArea-TryCloseSelf0 = 1,
		Beyond-UI-UIAutoCloseArea-_UpdateState0 = 1,
		Beyond-UI-UIAutoCloseArea-InitBinding0 = 1,
		Beyond-UI-UIAutoCloseArea-Start0 = 1,
		Beyond-UI-UIAutoCloseArea-Reset0 = 1,
		Beyond-UI-UIAutoCloseArea-OnEnable0 = 1,
		Beyond-UI-UIAutoCloseArea-OnDisable0 = 1,
		Beyond-UI-UIAutoCloseArea-ClearComponent0 = 1,
		Beyond-UI-UIAutoCloseArea-OnDestroy0 = 1,
		Beyond-UI-UIBigLogo-ClearBigLogoMask0 = 1,
		Beyond-UI-UIButton-_StopLongPressCor0 = 1,
		Beyond-UI-UIBigRectHelper-ResetPivotPositionToScreenCenter0 = 1,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPositionToMousePosition0 = 1,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPosition1 = 1,
		Beyond-UI-UIBigRectHelper-_UpdatePositionOffsetAfterZoomed0 = 1,
		Beyond-UI-UIBigRectHelper-_PosAdjust0 = 1,
		Beyond-UI-UIBigRectHelper-_OnControllerClick0 = 1,
		Beyond-UI-UIBigRectHelper-_InitControllerBindings0 = 1,
		Beyond-UI-UIBigRectHelper-OnAwake0 = 1,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerZoomKeyHint0 = 1,
		Beyond-UI-UIBigRectHelper-_TickCheckControllerFocusRaycastTargets0 = 1,
		Beyond-UI-UIBigRectHelper-OnRelease0 = 1,
		Beyond-UI-UIBigRectHelper-_TryAlignWhenInit0 = 1,
		Beyond-UI-UIBigRectHelper-_ResetControllerState0 = 1,
		Beyond-UI-UIBigRectHelper-Init0 = 1,
		Beyond-UI-UIBigRectHelper-ClearAllTween0 = 1,
		Beyond-UI-UIBigRectHelper-ClearComponent0 = 1,
		Beyond-UI-UIBlurMono-OnEnable0 = 1,
		Beyond-UI-UIBlurMono-OnDisable0 = 1,
		Beyond-UI-UIBlurRT-Reset0 = 1,
		Beyond-UI-UIBlurRT-InitRT0 = 1,
		Beyond-UI-UIBlurRT-Register0 = 1,
		Beyond-UI-UIBlurRT-UnRegister0 = 1,
		Beyond-UI-UIBlurRT-UpdateRT0 = 1,
		Beyond-UI-UIBlurRT-OnEnable0 = 1,
		Beyond-UI-UIBlurRT-_Clear0 = 1,
		Beyond-UI-UIBlurRT-OnDisable0 = 1,
		Beyond-UI-UIBlurRT-OnDestroy0 = 1,
		Beyond-UI-UIButton-Awake0 = 1,
		Beyond-UI-UIButton-OnEnable0 = 1,
		Beyond-UI-UIButton-OnDisable0 = 1,
		Beyond-UI-UIButton-ClearComponent0 = 1,
		Beyond-UI-UIButton-OnDestroy0 = 1,
		Beyond-UI-UIButton-OnInteractableChanged0 = 1,
		Beyond-UI-UIButton-OnNaviTargetEnabledAgain0 = 1,
		Beyond-UI-UICanvasScaleHelper-_OnInit0 = 1,
		Beyond-UI-UICanvasScaleHelper-Awake0 = 1,
		Beyond-UI-UICanvasScaleHelper-_OnInputTypeChanged0 = 1,
		Beyond-UI-UICanvasScaleHelper-_CanvasOnWillRenderCanvases0 = 1,
		Beyond-UI-UICanvasScaleHelper-Start0 = 1,
		Beyond-UI-UICanvasScaleHelper-ClearComponent0 = 1,
		Beyond-UI-UICanvasScaleHelper-OnDestroy0 = 1,
		Beyond-UI-UICanvasScaleHelper-UpdateCanvas0 = 1,
		Beyond-UI-UICanvasScaleHelper-ForceCanvasUpdate0 = 1,
		Beyond-UI-UIControllerKeyIcon-RefreshKeyIcon0 = 1,
		Beyond-UI-UIControllerKeyIcon-Awake0 = 1,
		Beyond-UI-UIControllerKeyIcon-OnEnable0 = 1,
		Beyond-UI-UIControllerKeyIcon-OnDisable0 = 1,
		Beyond-UI-UICustomLayout-Awake0 = 1,
		Beyond-UI-UICustomLayoutElement-_ApplyScale0 = 1,
		Beyond-UI-UICustomLayoutElement-_ApplyAlpha0 = 1,
		Beyond-UI-UICustomLayoutElement-_ApplyPosition0 = 1,
		Beyond-UI-UICustomLayoutElement-ResetToDefault0 = 1,
		Beyond-UI-UICustomLayoutHandle-ResetToDefault0 = 1,
		Beyond-UI-UICustomLayoutElement-_SetDefaultValues0 = 1,
		Beyond-UI-UICustomLayoutElement-LoadData0 = 1,
		Beyond-UI-UICustomLayoutElement-_OnHudLayoutSaved0 = 1,
		Beyond-UI-UICustomLayoutElement-Awake0 = 1,
		Beyond-UI-UICustomLayoutElement-Start0 = 1,
		Beyond-UI-UICustomLayoutElement-OnDestroy0 = 1,
		Beyond-UI-UICustomLayoutElement-ClearComponent0 = 1,
		Beyond-UI-UICustomLayoutHandle-_ApplyScale0 = 1,
		Beyond-UI-UICustomLayoutHandle-_CalculatePositionRange0 = 1,
		Beyond-UI-UICustomLayoutHandle-_ApplyPosition0 = 1,
		Beyond-UI-UICustomLayoutHandle-_ApplyAlpha0 = 1,
		Beyond-UI-UICustomLayoutHandle-_ApplyLayoutType0 = 1,
		Beyond-UI-UICustomLayoutHandle-_OnElementDataLoaded0 = 1,
		Beyond-UI-UICustomLayoutHandle-_OnSystemDisplaySizeChanged0 = 1,
		Beyond-UI-UICustomLayoutHandle-Awake0 = 1,
		Beyond-UI-UICustomLayoutHandle-OnDestroy0 = 1,
		Beyond-UI-UICustomLayoutHandle-ClearComponent0 = 1,
		Beyond-UI-UIDialogText-ResetPlay0 = 1,
		Beyond-UI-UIDialogText-OnAwake0 = 1,
		Beyond-UI-UIDialogText-_RefreshPosY0 = 1,
		Beyond-UI-UIDialogText-RefreshAutoScrollData0 = 1,
		Beyond-UI-UIDialogText-Play0 = 1,
		Beyond-UI-UIDialogText-Start0 = 1,
		Beyond-UI-UIDialogText-OnDisable0 = 1,
		Beyond-UI-UIDialogText-RefreshText0 = 1,
		Beyond-UI-UIDialogText-OnEnable0 = 1,
		Beyond-UI-UIDialogText-StopPlay0 = 1,
		Beyond-UI-UIDialogText-_TryAutoScroll0 = 1,
		Beyond-UI-UIDialogText-_UpdateTextAuto0 = 1,
		Beyond-UI-UIDialogText-SeekToEnd0 = 1,
		Beyond-UI-UIDialogTextWithCursor-ResetPlay0 = 1,
		Beyond-UI-UIDialogTimelineText-_ClearRadioIcon0 = 1,
		Beyond-UI-UIDrag-Awake0 = 1,
		Beyond-UI-UIDrag-ApplyDragArea0 = 1,
		Beyond-UI-UIDrag-ClearComponent0 = 1,
		Beyond-UI-UIDragHandler-ClearComponent0 = 1,
		Beyond-UI-UIDragItem-Awake0 = 1,
		Beyond-UI-UIDragItem-Start0 = 1,
		Beyond-UI-UIDragItem-_StopDragView0 = 1,
		Beyond-UI-UIDragItem-OnDisable0 = 1,
		Beyond-UI-UIDragItem-ClearEvents0 = 1,
		Beyond-UI-UIDragItem-ClearComponent0 = 1,
		Beyond-UI-UIDragItem-OnDestroy0 = 1,
		Beyond-UI-UIDragItem-OnEnable0 = 1,
		Beyond-UI-UIDropdown-_ControllerToggle0 = 1,
		Beyond-UI-UIDropdown-_ControllerCancel0 = 1,
		Beyond-UI-UIDropdown-_InitBinding0 = 1,
		Beyond-UI-UIDropdown-Awake0 = 1,
		Beyond-UI-UIDropdown-Update0 = 1,
		Beyond-UI-UIScrollRect-KillScrollTween0 = 1,
		Beyond-UI-UIDropdown-ScrollToSelected0 = 1,
		Beyond-UI-UIDropdown-ClearComponent0 = 1,
		Beyond-UI-UIDropdown-OnEnable0 = 1,
		Beyond-UI-UIDropdown-OnDisable0 = 1,
		Beyond-UI-UIDropdown-OnDestroy0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyGameObject0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyComponent0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyGraphic0 = 1,
		Beyond-UI-UIState-UIStateControllerUtils-ForceRebuildLayout0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyRectTransform0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyImage0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyText0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyCanvasGroup0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyButton0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyAnimator0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyLayoutElement0 = 1,
		Beyond-UI-UIState-UIStateController-OnStateReferenceDirty0 = 1,
		Beyond-UI-UIState-StateAnimationInfo-OnUpdate0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyLayoutGroup0 = 1,
		Beyond-UI-UIScrollList-UpdateContainerSize0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyScrollList0 = 1,
		Beyond-UI-UIState-StateDescription-ApplyGridLayoutGroup0 = 1,
		Beyond-UI-UIState-StateDescription-ApplySelectable0 = 1,
		Beyond-UI-UIState-StateReference-HandleScheduledStates0 = 1,
		Beyond-UI-UIState-UIStateController-_FlushAnimationsImmediately0 = 1,
		Beyond-UI-UIDropItem-ClearEvents0 = 1,
		Beyond-UI-UIDropItem-Awake0 = 1,
		Beyond-UI-UIDropItem-OnEnable0 = 1,
		Beyond-UI-UIDropItem-OnDisable0 = 1,
		Beyond-UI-UIDropItem-ClearComponent0 = 1,
		Beyond-UI-UIDropItem-OnDestroy0 = 1,
		Beyond-UI-UIElementFollower-UpdatePosition1 = 1,
		Beyond-UI-UIElementFollower-OnAwake0 = 1,
		Beyond-UI-UIElementFollower-OnEnable0 = 1,
		Beyond-UI-UIFoldoutComponent-OnDestroy0 = 1,
		Beyond-UI-UIGraphicAnimation-_Init0 = 1,
		Beyond-UI-UIGraphicAnimation-OnAwake0 = 1,
		Beyond-UI-UIGraphicAnimation-OnRelease0 = 1,
		Beyond-UI-UIGridLayoutNaviWrapper-_InitIfNot0 = 1,
		Beyond-UI-UIGridLayoutNaviWrapper-_InitWrapNavigation0 = 1,
		Beyond-UI-UIGridLayoutNaviWrapper-Start0 = 1,
		Beyond-UI-UIGroupScrollList-_RefreshAllGroupTitleSizes0 = 1,
		Beyond-UI-UIGroupScrollList-_RebuildGroupRows0 = 1,
		Beyond-UI-UIGroupScrollList-_BuildGroupLayout0 = 1,
		Beyond-UI-UIScrollList-CalcSomeCountNum0 = 1,
		Beyond-UI-UIScrollList-SyncViewSize0 = 1,
		Beyond-UI-UIGroupScrollList-SyncViewSize0 = 1,
		Beyond-UI-UIScrollList-InitBasicInfo0 = 1,
		Beyond-UI-UIScrollList-_InitAutoScroll0 = 1,
		Beyond-UI-UIScrollList-StopGraduallyShow0 = 1,
		Beyond-UI-UIScrollList-SkipGraduallyShow0 = 1,
		Beyond-UI-UIScrollList-TryClearAdjustTween0 = 1,
		Beyond-UI-UIScrollList-StartGraduallyShow0 = 1,
		Beyond-UI-UIScrollList-RestartGraduallyShow0 = 1,
		Beyond-UI-UIScrollList-_InitNavigation0 = 1,
		Beyond-UI-UIScrollList-_InitControllerNavi0 = 1,
		Beyond-UI-UIScrollList-_InitSyncNaviTargetOnStickScroll0 = 1,
		Beyond-UI-UIScrollList-InGameAwake0 = 1,
		Beyond-UI-UIGroupScrollList-InGameAwake0 = 1,
		Beyond-UI-UIScrollList-InitConfig0 = 1,
		Beyond-UI-UISelectableNaviGroup-ClearLastFocusNaviTarget0 = 1,
		Beyond-UI-UIScrollList-_ClearRelatedNaviGroup0 = 1,
		Beyond-UI-UIGroupScrollList-_RefreshIsMultiPage0 = 1,
		Beyond-UI-UIGroupScrollList-UpdateContainerSize0 = 1,
		Beyond-UI-UIGroupScrollList-ClearShowingCells0 = 1,
		Beyond-UI-UIScrollList-ClearComponent0 = 1,
		Beyond-UI-UIGroupScrollList-ClearComponent0 = 1,
		Beyond-UI-UIGyroscopeEffect-OnAwake0 = 1,
		Beyond-UI-UIGyroscopeEffect-OnDisable0 = 1,
		Beyond-UI-UIGyroscopeEffect-OnRelease0 = 1,
		Beyond-UI-UIHighlightMask-OnAwake0 = 1,
		Beyond-UI-UIHighlightMask-TrySyncRect0 = 1,
		Beyond-UI-UIHighlightMask-OnEnable0 = 1,
		Beyond-UI-UIImage-OnEnableRuntimeAtlas0 = 1,
		Beyond-UI-UIAtlasManager-ReProcessInsertForUIImage0 = 1,
		Beyond-UI-UIAtlasManager-AddUIImageToManagerOnInstantiate0 = 1,
		Beyond-UI-UIImage-Awake0 = 1,
		Beyond-UI-UIAtlasManager-AddUIImageToManager0 = 1,
		Beyond-UI-UIImage-OnEnable0 = 1,
		Beyond-UI-UIImage-OnDisable0 = 1,
		Beyond-UI-UIAtlasManager-RemoveUIImageFromManager0 = 1,
		Beyond-UI-UIImage-OnDestroy0 = 1,
		Beyond-UI-UIImage-SetNativeSize0 = 1,
		Beyond-UI-UIImage-SetNativeSizeIgnoreRefScale0 = 1,
		Beyond-UI-UIImage-ReleaseSprite0 = 1,
		Beyond-UI-UIImageBlur-OnChangeSprite0 = 1,
		Beyond-UI-UIImageBlur-OnAwake0 = 1,
		Beyond-UI-UIImageBlur-OnDisable0 = 1,
		Beyond-UI-UIImageBlur-OnRelease0 = 1,
		Beyond-UI-UIImageFillFollower-OnAwake0 = 1,
		Beyond-UI-UIImageFillFollower-OnEnable0 = 1,
		Beyond-UI-UIImageFillFollower-RefreshFillAmount0 = 1,
		Beyond-UI-UIImageFillTailFollower-OnAwake0 = 1,
		Beyond-UI-UIImageFillTailFollower-RefreshFollower0 = 1,
		Beyond-UI-UIImageFillTailFollower-OnEnable0 = 1,
		Beyond-UI-UIInertiaViewPager-_PlayAudioGear0 = 1,
		Beyond-UI-UIInertiaViewPager-_PlayAudioGearLock0 = 1,
		Beyond-UI-UIInertiaViewPager-_InitIfNot0 = 1,
		Beyond-UI-UIInertiaViewPager-ClearComponent0 = 1,
		Beyond-UI-UIInertiaViewPager-_AutoAlign0 = 1,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyAlignFinish0 = 1,
		Beyond-UI-UIInertiaViewPager-OnAwake0 = 1,
		Beyond-UI-UIInertiaViewPager-OnEnable0 = 1,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-OnClear0 = 1,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-StopMoving0 = 1,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-MarkHasScrolled0 = 1,
		Beyond-UI-UIInputField-SendOnFocus0 = 1,
		Beyond-UI-UIInputField-SendOnFocusLost0 = 1,
		Beyond-UI-UIInputField-_VirtualKeyboardInitJavaObj0 = 1,
		Beyond-UI-UIInputField-_VirtualKeyboardAwake0 = 1,
		Beyond-UI-UIInputField-Awake0 = 1,
		Beyond-UI-UIInputField-_VirtualKeyboardSelect0 = 1,
		Beyond-UI-UIInputField-_VirtualKeyboardDeselect0 = 1,
		Beyond-UI-UIInputField-_SteamFloatingKeyboardShow0 = 1,
		Beyond-UI-UIInputField-set_s_focusedInputField0 = 1,
		Beyond-UI-UIInputField-ActivateInputField0 = 1,
		Beyond-UI-UIInputField-_SteamFloatingKeyboardHide0 = 1,
		Beyond-UI-UIInputField-_UpdateBindingEnable0 = 1,
		Beyond-UI-UIInputField-_VirtualKeyboardOnDestroy0 = 1,
		Beyond-UI-UIInputField-ClearComponent0 = 1,
		Beyond-UI-UIInputField-OnDestroy0 = 1,
		Beyond-UI-UIInputField-OnEnable0 = 1,
		Beyond-UI-UIInputField-OnDisable0 = 1,
		Beyond-UI-UIInputField-OnInteractableChanged0 = 1,
		Beyond-UI-UIInputField-_CleanupAndroidObjects0 = 1,
		Beyond-UI-UIJoystick-_UpdateWalkBgScale0 = 1,
		Beyond-UI-UIJoystick-Reset0 = 1,
		Beyond-UI-UIJoystick-_UpdateState0 = 1,
		Beyond-UI-UIJoystick-InitBinding0 = 1,
		Beyond-UI-UIJoystick-_UpdateGait0 = 1,
		Beyond-UI-UIJoystick-_UpdateIndicator0 = 1,
		Beyond-UI-UIJoystick-_UpdateBg0 = 1,
		Beyond-UI-UIJoystick-Awake0 = 1,
		Beyond-UI-UIJoystick-_Tick0 = 1,
		Beyond-UI-UIJoystick-OnEnable0 = 1,
		Beyond-UI-UIJoystick-Start0 = 1,
		Beyond-UI-UIJoystick-ClearComponent0 = 1,
		Beyond-UI-UIJoystick-OnDestroy0 = 1,
		Beyond-UI-UIJoystick-OnDisable0 = 1,
		Beyond-UI-UIJoystick-CheckShouldActive0 = 1,
		Beyond-UI-UILayoutDimensionListener-GraphicUpdateComplete0 = 1,
		Beyond-UI-UILayoutDimensionListener-LayoutComplete0 = 1,
		Beyond-UI-UILayoutDimensionListener-_InvokePostLayoutCallback0 = 1,
		Beyond-UI-UILayoutDimensionListener-_SetDirty0 = 1,
		Beyond-UI-UILayoutDimensionListener-OnEnable0 = 1,
		Beyond-UI-UILayoutDimensionListener-OnRectTransformDimensionsChange0 = 1,
		Beyond-UI-UILayoutDimensionListener-OnDestroy0 = 1,
		Beyond-UI-UILeftSubtitle-Exit0 = 1,
		Beyond-UI-UIMaterialAnimation-_BuildPropertyTable0 = 1,
		Beyond-UI-UIMaterialAnimation-_TryUpdate0 = 1,
		Beyond-UI-UIMaterialAnimation-OnAwake0 = 1,
		Beyond-UI-UIMaterialAnimation-OnRelease0 = 1,
		Beyond-UI-UIMaterialAnimation-ForceUpdate0 = 1,
		Beyond-UI-UIMultiSelectDropdown-_ControllerToggle0 = 1,
		Beyond-UI-UIMultiSelectDropdown-_ControllerCancel0 = 1,
		Beyond-UI-UIMultiSelectDropdown-_InitBinding0 = 1,
		Beyond-UI-UIMultiSelectDropdown-Awake0 = 1,
		Beyond-UI-UIMultiSelectDropdown-Update0 = 1,
		Beyond-UI-UIMultiSelectDropdown-ScrollToLastSelected0 = 1,
		Beyond-UI-UIMultiSelectDropdown-ClearComponent0 = 1,
		Beyond-UI-UIMultiSelectDropdown-OnEnable0 = 1,
		Beyond-UI-UIMultiSelectDropdown-OnDisable0 = 1,
		Beyond-UI-UIMultiSelectDropdown-OnDestroy0 = 1,
		Beyond-UI-UINonUnifiedScrollList-InitBasicInfo0 = 1,
		Beyond-UI-UINonUnifiedScrollList-CalcSomeCountNum0 = 1,
		Beyond-UI-UIScrollList-TryRecalculateSize0 = 1,
		Beyond-UI-UISizeFollower-SyncSize0 = 1,
		Beyond-UI-UINonUnifiedScrollList-ClearComponent0 = 1,
		Beyond-UI-UINonUnifiedScrollList-UpdateLastScrollStep0 = 1,
		Beyond-UI-UINonUnifiedScrollRect-_UpdateNonUnifiedScrollbars0 = 1,
		Beyond-UI-UINonUnifiedScrollRect-_OnPostLayout0 = 1,
		Beyond-UI-UINonUnifiedScrollRect-_InitIfNot0 = 1,
		Beyond-UI-UINumberScrollTween-_CleanupBeforeTween0 = 1,
		Beyond-UI-UINumberScrollTween-Start0 = 1,
		Beyond-UI-UIPCScaleHelper-OnEnable0 = 1,
		Beyond-UI-UIRegionBuildingTexManager-OnEnable0 = 1,
		Beyond-UI-UIRegionBuildingTexManager-OnValidate0 = 1,
		Beyond-UI-UIRegionBuildingTexManager-OnDisable0 = 1,
		Beyond-UI-UIScaleHolder-OnAwake0 = 1,
		Beyond-UI-UIScaleHolder-_HoldScale0 = 1,
		Beyond-UI-UIScaleHolder-OnEnable0 = 1,
		Beyond-UI-UIScrollbar-Awake0 = 1,
		Beyond-UI-UIScrollbarKeyHint-OnAwake0 = 1,
		Beyond-UI-UIScrollCircle-_UpdateSpeed0 = 1,
		Beyond-UI-UIScrollCircle-_UpdateShowingCells0 = 1,
		Beyond-UI-UIScrollCircle-_TryUpdateCells0 = 1,
		Beyond-UI-UIScrollCircle-_UpdateAuto0 = 1,
		Beyond-UI-UIScrollCircle-OnRelease0 = 1,
		Beyond-UI-UIScrollCircle-_InitCells0 = 1,
		Beyond-UI-UIScrollCircle-_Init0 = 1,
		Beyond-UI-UIScrollCircle-_OnAwakeInit0 = 1,
		Beyond-UI-UIScrollCircle-_UpdateScrollRange0 = 1,
		Beyond-UI-UIScrollCircle-LayoutComplete0 = 1,
		Beyond-UI-UIScrollCircle-GraphicUpdateComplete0 = 1,
		Beyond-UI-UIScrollCircle-OnEnable0 = 1,
		Beyond-UI-UIScrollCircle-OnDisable0 = 1,
		Beyond-UI-UIScrollCircle-Start0 = 1,
		Beyond-UI-UIScrollCircle-OnAwake0 = 1,
		Beyond-UI-UIScrollCircle-ClearComponent0 = 1,
		Beyond-UI-UIScrollContainerFollower-OnAwake0 = 1,
		Beyond-UI-UIScrollContainerFollower-_RefreshSizeAndPositionToTargetContainer0 = 1,
		Beyond-UI-UIScrollList-_EditorAwake0 = 1,
		Beyond-UI-UIScrollList-OnAwake0 = 1,
		Beyond-UI-UIScrollList-OnEnable0 = 1,
		Beyond-UI-UIScrollList-OnDisable0 = 1,
		Beyond-UI-UIScrollList-OnRelease0 = 1,
		Beyond-UI-UIScrollRect-Awake0 = 1,
		Beyond-UI-UIScrollRect-_InitController0 = 1,
		Beyond-UI-UIScrollRect-OnEnable0 = 1,
		Beyond-UI-UIScrollRect-_TickRefreshControllerStickScroll0 = 1,
		Beyond-UI-UIScrollRect-_UpdateMoveTips0 = 1,
		Beyond-UI-UIScrollRect-Update0 = 1,
		Beyond-UI-UIScrollRect-ClampContentToBounds0 = 1,
		Beyond-UI-UIScrollRect-OnDestroy0 = 1,
		Beyond-UI-UIScrollRect-UpdateScrollEnableNode0 = 1,
		Beyond-UI-UIScrollRect-ClearComponent0 = 1,
		Beyond-UI-UIScrollRect-LateUpdate0 = 1,
		Beyond-UI-UIScrollRectEdgeRedDot-ResetReferences0 = 1,
		Beyond-UI-UIScrollRectEdgeRedDot-OnAwake0 = 1,
		Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDotStatesForScrollList0 = 1,
		Beyond-UI-UIScrollRectEdgeRedDot-OnEnable0 = 1,
		Beyond-UI-UIScrollRectEdgeRedDot-OnRelease0 = 1,
		Beyond-UI-UIScrollRectEdgeRedDot-UpdateRedDotStateInDir0 = 1,
		Beyond-UI-UIScrollRectEdgeRedDot-ResetRedDotPosition0 = 1,
		Beyond-UI-UIScrollRectEdgeRedDot-ClearComponent0 = 1,
		Beyond-UI-UIScrollText-_InitIfNot0 = 1,
		Beyond-UI-UIScrollText-_ResetTextScroll0 = 1,
		Beyond-UI-UIScrollText-ResetTextScroll0 = 1,
		Beyond-UI-UIScrollText-ResetToStatic0 = 1,
		Beyond-UI-UIScrollText-OnAwake0 = 1,
		Beyond-UI-UIScrollText-PositionScrollHandler-ResetScroll0 = 1,
		Beyond-UI-UIScrollText-MeshScrollHandler-ResetScroll0 = 1,
		Beyond-UI-UISelectableNaviGroup-_RefreshFocusBindings0 = 1,
		Beyond-UI-UISelectableNaviGroup-_InitFocusBinding0 = 1,
		Beyond-UI-UISelectableNaviGroup-Awake0 = 1,
		Beyond-UI-UISelectableNaviGroup-_RefreshRelatedBindingGroupsState0 = 1,
		Beyond-UI-UISelectableNaviGroup-_RefreshFocusActionKeyHint0 = 1,
		Beyond-UI-UISelectableNaviGroup-_RefreshStopFocusActionKeyHint0 = 1,
		Beyond-UI-UISelectableNaviGroup-OnEnable0 = 1,
		Beyond-UI-UISelectableNaviGroup-OnDisable0 = 1,
		Beyond-UI-UISelectableNaviGroup-_OnIsTopLayerChanged0 = 1,
		Beyond-UI-UISelectableNaviGroup-_OnSelectableNaviGroupDisabled0 = 1,
		Beyond-UI-UISelectableNaviGroup-_BeforeSelectableNaviGroupDestroy0 = 1,
		Beyond-UI-UISelectableNaviGroup-_OnRemoveFromLayerStack0 = 1,
		Beyond-UI-UISelectableNaviGroup-ClearComponent0 = 1,
		Beyond-UI-UISelectableNaviGroup-OnDestroy0 = 1,
		Beyond-UI-UISelectableNaviGroup-RefreshFocusBindings0 = 1,
		Beyond-UI-UISelectableNaviGroup-ManuallyRefreshRelatedBindingGroups0 = 1,
		Beyond-UI-UISemiCircleScrollList-ClearComponent0 = 1,
		Beyond-UI-UISemiCircleScrollList-_InitializeCells0 = 1,
		Beyond-UI-UISemiCircleScrollList-UpdateLayout0 = 1,
		Beyond-UI-UISemiCircleScrollList-OnAwake0 = 1,
		Beyond-UI-UISemiCircleScrollList-OnDisable0 = 1,
		Beyond-UI-UISemiCircleScrollList-_TickRefreshControllerStickScroll0 = 1,
		Beyond-UI-UISemiCircleScrollListPair-_OnDrag0 = 1,
		Beyond-UI-UISemiCircleScrollListPair-_OnEndDrag0 = 1,
		Beyond-UI-UISemiCircleScrollListPair-Awake0 = 1,
		Beyond-UI-UISequenceImage-OnAwake0 = 1,
		Beyond-UI-UISequenceImage-Play0 = 1,
		Beyond-UI-UISequenceImage-OnEnable0 = 1,
		Beyond-UI-UISequenceImage-OnDisable0 = 1,
		Beyond-UI-UISimpleActiveAnimationHelper-Skip0 = 1,
		Beyond-UI-UISimpleActiveAnimationHelper-Start0 = 1,
		Beyond-UI-UISimpleActiveAnimationHelper-OnEnable0 = 1,
		Beyond-UI-UISlider-_TryPostSlideAudioEvent0 = 1,
		Beyond-UI-UISlider-OnValueChanged0 = 1,
		Beyond-UI-UISlider-OnClickSliderBar0 = 1,
		Beyond-UI-UISlider-OnClickSliderHandle0 = 1,
		Beyond-UI-UISlider-_OnGamepadStickScrollHoriValue0 = 1,
		Beyond-UI-UISlider-_InitGamepadStickScroll0 = 1,
		Beyond-UI-UISlider-_AddValue0 = 1,
		Beyond-UI-UISlider-_ReduceValue0 = 1,
		Beyond-UI-UISlider-_InitBinding0 = 1,
		Beyond-UI-UISlider-Awake0 = 1,
		Beyond-UI-UISlider-_ReleaseGamepadStickScrollTickFunction0 = 1,
		Beyond-UI-UISlider-_CreateGamepadStickScrollTickFunction0 = 1,
		Beyond-UI-UISlider-OnEnable0 = 1,
		Beyond-UI-UISlider-OnDisable0 = 1,
		Beyond-UI-UISlider-ClearComponent0 = 1,
		Beyond-UI-UISlider-OnDestroy0 = 1,
		Beyond-UI-UISoftMaskable-MarkGraphicVerticesDirty0 = 1,
		Beyond-UI-UISoftMaskable-MarkGraphicMaterialDirty0 = 1,
		Beyond-UI-UISoftMask-_UpdateParam0 = 1,
		Beyond-UI-UISoftMask-_OnEnableRuntimeAtlas0 = 1,
		Beyond-UI-UISoftMask-_OnGraphicDirty0 = 1,
		Beyond-UI-UISoftMask-_OnWillRenderCanvases0 = 1,
		Beyond-UI-UISoftMask-OnEnable0 = 1,
		Beyond-UI-UISoftMask-_Clear0 = 1,
		Beyond-UI-UISoftMask-OnDisable0 = 1,
		Beyond-UI-UISoftMask-OnRectTransformDimensionsChange0 = 1,
		Beyond-UI-UISoftMaskable-OnEnable0 = 1,
		Beyond-UI-UISoftMaskable-OnDisable0 = 1,
		Beyond-UI-UISoftMaskable-OnTransformParentChanged0 = 1,
		Beyond-UI-UISoftMaskable-_ClipRect0 = 1,
		Beyond-UI-UISortingOrder-OnEnable0 = 1,
		Beyond-UI-UISortingOrder-_GetRenderer0 = 1,
		Beyond-UI-UISortingOrder-_GetChildrenRenderers0 = 1,
		Beyond-UI-UISortingOrder-_GetChildrenParticleRenderers0 = 1,
		Beyond-UI-UISortingOrder-_GetCanvas0 = 1,
		Beyond-UI-UISortingOrder-Awake0 = 1,
		Beyond-UI-UISortingOrder-OnDestroy0 = 1,
		Beyond-UI-UIStepScrollList-InitConfig0 = 1,
		Beyond-UI-UIStepScrollList-ClearComponent0 = 1,
		Beyond-UI-UIStepScrollList-OnDisable0 = 1,
		Beyond-UI-UIStyleByState-UpdateStyle0 = 1,
		Beyond-UI-UIStyleByState-Awake0 = 1,
		Beyond-UI-UIStyleByState-OnDestroy0 = 1,
		Beyond-UI-UISubtitle-_SetAsDefault0 = 1,
		Beyond-UI-UISubtitle-Start0 = 1,
		Beyond-UI-UIToggle-TryInternalToggle0 = 1,
		Beyond-UI-UIToggle-_TryRefreshToggleBindingText0 = 1,
		Beyond-UI-UIToggle-_TryRefreshHoverConfirmBindingText0 = 1,
		Beyond-UI-UIToggle-_InitActionOnSetNaviTarget0 = 1,
		Beyond-UI-UIToggle-_InitToggleBinding0 = 1,
		Beyond-UI-UIToggle-Awake0 = 1,
		Beyond-UI-UIToggle-_UpdateBindingEnable0 = 1,
		Beyond-UI-UIToggle-OnEnable0 = 1,
		Beyond-UI-UIToggle-OnDisable0 = 1,
		Beyond-UI-UIToggle-ClearComponent0 = 1,
		Beyond-UI-UIToggle-OnDestroy0 = 1,
		Beyond-UI-UIToggle-Start0 = 1,
		Beyond-UI-UIToggle-PlayAudio0 = 1,
		Beyond-UI-UIToggle-InternalToggle0 = 1,
		Beyond-UI-UIToggle-OnValueChange0 = 1,
		Beyond-UI-UIToggle-OnInteractableChanged0 = 1,
		Beyond-UI-UIToggle-OnNaviTargetEnabledAgain0 = 1,
		Beyond-UI-UIToggle-RefreshHintText0 = 1,
		Beyond-UI-UIToggleGroup-MoveToNext0 = 1,
		Beyond-UI-UIToggleGroup-MoveToPrevious0 = 1,
		Beyond-UI-UIToggleGroup-Awake0 = 1,
		Beyond-UI-UIToggleGroup-OnEnable0 = 1,
		Beyond-UI-UIToggleGroup-OnDisable0 = 1,
		Beyond-UI-UIToggleGroup-OnDestroy0 = 1,
		Beyond-UI-UITouchPanel-ClearTouchInfo0 = 1,
		Beyond-UI-UITouchPanel-_UpdateState0 = 1,
		Beyond-UI-UITouchPanel-InitBinding0 = 1,
		Beyond-UI-UITouchPanel-OnAwake0 = 1,
		Beyond-UI-UITouchPanel-OnEnable0 = 1,
		Beyond-UI-UITouchPanel-OnDisable0 = 1,
		Beyond-UI-UITouchPanel-OnDestroy0 = 1,
		Beyond-UI-UITouchPanel-ClearComponent0 = 1,
		Beyond-UI-UITouchPanel-OnRelease0 = 1,
		Beyond-UI-UIVFXManager-_UpdateParam0 = 1,
		Beyond-UI-UIVFXManager-_OnEnableRuntimeAtlas0 = 1,
		Beyond-UI-UIVFXManager-OnEnable0 = 1,
		Beyond-UI-UIVFXManager-_Clear0 = 1,
		Beyond-UI-UIVFXManager-OnDisable0 = 1,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-OnDisable0 = 1,
		Beyond-UI-VirtualMouseInitPos-OnEnable0 = 1,
		Beyond-UI-CSPopupPanel-Awake0 = 1,
		Beyond-UI-CSPopupPanel-OnDestroy0 = 1,
		Beyond-UI-MobileMotionManager-_CheckMotionLevelAndPostIfChange0 = 1,
		Beyond-UI-MobileMotionManager-OnInit0 = 1,
		Beyond-UI-MobileMotionManager-OnRelease0 = 1,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-Dispose0 = 1,
		Beyond-UI-DynamicFontAssetLoader-Dispose0 = 1,
		Beyond-UI-UILoadImageSprite-OnDestroy0 = 1,
		Beyond-UI-UISwitchTween-BeforeShowEffect0 = 1,
		Beyond-UI-UISwitchTween-BeforeHideEffect0 = 1,
		Beyond-UI-UISwitchTween-AfterShowEffect0 = 1,
		Beyond-UI-UISwitchTween-AfterHideEffect0 = 1,
		Beyond-UI-UISwitchTween-ClearTween0 = 1,
		Beyond-UI-UISwitchTween-Show0 = 1,
		Beyond-UI-UISwitchTween-Hide0 = 1,
		Beyond-UI-UISwitchTween-Clear0 = 1,
		Beyond-UI-UISwitchTween-TweenWrapper-KillIfNecessary0 = 1,
		Beyond-UI-FadeSwitchTween-BeforeShowEffect0 = 1,
		Beyond-UI-FadeSwitchTween-AfterHideEffect0 = 1,
		Beyond-UI-FadeSwitchTween-Release0 = 1,
		Beyond-UI-FadeTranslationSwitchTween-BeforeShowEffect0 = 1,
		Beyond-UI-FadeTranslationSwitchTween-AfterHideEffect0 = 1,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-KillIfNecessary0 = 1,
		Beyond-UI-UIAtlasManager-_ProcessRemoveQueue0 = 1,
		Beyond-UI-UIAtlasManager-_ProcessInsertQueue0 = 1,
		Beyond-UI-UIAtlasManager-_CreateTickFunction0 = 1,
		Beyond-UI-UIAtlasManager-OnInit0 = 1,
		Beyond-UI-UIAtlasManager-_ClearTickFunction0 = 1,
		Beyond-UI-UIAtlasManager-OnUnInit0 = 1,
		Beyond-UI-UIAtlasManager-Release0 = 1,
		Beyond-UI-UICharHeadGlowAnimation-UnInit0 = 1,
		Beyond-UI-UICharHeadGlowAnimationNode-OnEnable0 = 1,
		Beyond-UI-UICharHeadGlowAnimationNode-OnDisable0 = 1,
		Beyond-UI-UIRedDotAnimation-_UpdateRedDotAnimation0 = 1,
		Beyond-UI-UIRedDotAnimation-UnInit0 = 1,
		Beyond-UI-UIRedDotAnimationNode-Awake0 = 1,
		Beyond-UI-UIRedDotAnimationNode-OnEnable0 = 1,
		Beyond-UI-UIRedDotAnimationNode-OnDisable0 = 1,
		Beyond-UI-UIState-StateDescription-_OnGridLayoutGroupChanged0 = 1,
		Beyond-UI-UIState-StateDescription-_OnImageChanged0 = 1,
		Beyond-UI-UIState-StateDescription-_OnLayoutElementChanged0 = 1,
		Beyond-UI-UIState-StateDescription-_OnLayoutGroupChanged0 = 1,
		Beyond-UI-UIState-StateDescription-_OnRectTransformChanged0 = 1,
		Beyond-UI-UIState-StateDescription-_OnScrollListChanged0 = 1,
		Beyond-UI-UIState-StateDescription-_OnTextChanged0 = 1,
		Beyond-UI-UIState-UIStateControllerLogicalGroup-Group-ClearState0 = 1,
		Beyond-UI-UIState-UIStateControllerLogicalGroup-Awake0 = 1,
		Beyond-UI-UIState-UIStateControllerLogicalGroup-LogicalGroupAction-Execute0 = 1,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Dispose0 = 1,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-Dispose0 = 1,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-FlushIfNeeded0 = 1,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_InitializeAnimationStates0 = 1,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_ClearAllSpriteOverrides0 = 1,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-Recycle0 = 1,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-ClearDynamicSpriteOverrides0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-InitMaterials0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-_DisposeLoadedTextures0 = 1,
		Beyond-UI-GPUI-GPUISharedGraphicBase-CleanMaterials0 = 1,
		Beyond-UI-GPUI-GPUISharedGraphicBase-OnDestroy0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-OnDestroy0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-_SyncDynamicAtlasRuntimeTexture0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-_DestroyAnimatedInstance0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-_RenderNodes0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-_DoLateUpdate0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-_OnPreWillRenderCanvases0 = 1,
		Beyond-UI-GPUI-GPUISharedGraphicBase-InitMaterials0 = 1,
		Beyond-UI-GPUI-GPUISharedGraphicBase-InitializeSharedState0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-_ResetLiveDynamicSpriteState0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-_UpdateLiveDynamicSpriteContext0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-OnEnable0 = 1,
		Beyond-UI-GPUI-GPUIExtendedSystem-OnDisable0 = 1,
		Beyond-UI-GPUI-GPUIProxySyncManager-_AutoAssignTargetSystem0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_CacheRectTransform0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-MarkTransformDirty0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnInstanceCreated0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-TryPrepareForBeforeRender0 = 1,
		Beyond-UI-GPUI-GPUIProxySyncManager-FlushBeforeRender0 = 1,
		Beyond-UI-GPUI-GPUIProxySyncManager-_UnregisterFromSystem0 = 1,
		Beyond-UI-GPUI-GPUIProxySyncManager-_RegisterToSystem0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnInstanceDestroyed0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-Awake0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnEnable0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnDisable0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnDestroy0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnRectTransformDimensionsChange0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnTransformParentChanged0 = 1,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-OnDidApplyAnimationProperties0 = 1,
		Beyond-UI-GPUI-GPUIProxySyncManager-OnEnable0 = 1,
		Beyond-UI-GPUI-GPUIProxySyncManager-OnDisable0 = 1,
		Beyond-UI-GPUI-GPUISharedGraphicBase-UpdateMaterial0 = 1,
		Beyond-UI-GPUI-GPUISystem-_DisposeLoadedTextures0 = 1,
		Beyond-UI-GPUI-GPUISystem-_DoOnDestroy0 = 1,
		Beyond-UI-GPUI-GPUISystem-OnDestroy0 = 1,
		Beyond-UI-GPUI-GPUISystem-_DestroyAnimatedInstance0 = 1,
		Beyond-UI-GPUI-GPUISystem-_RenderNodes0 = 1,
		Beyond-UI-GPUI-GPUISystem-_DoLateUpdate0 = 1,
		Beyond-UI-GPUI-GPUISystem-_PreWillRenderCanvases0 = 1,
		Beyond-UI-GPUI-GPUISystem-OnEnable0 = 1,
		Beyond-UI-GPUI-GPUISystem-OnDisable0 = 1,
		Beyond-UI-GPUI-GPUISystem-UpdateMaterial0 = 1,
		Beyond-UI-GPUI-RuntimeInstance-Recycle0 = 1,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-_GetPreferredSize0 = 2,
		Beyond-UI-UIScrollList-GetContainerSize0 = 2,
		Beyond-UI-UIGroupScrollList-GetContainerSize0 = 2,
		Beyond-UI-UINonUnifiedScrollList-GetContainerSize0 = 2,
		Beyond-UI-FadeTranslationSwitchTween-_GetTargetAlpha0 = 2,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minWidth0 = 3,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredWidth0 = 3,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_flexibleWidth0 = 3,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_minHeight0 = 3,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_preferredHeight0 = 3,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_flexibleHeight0 = 3,
		Beyond-UI-UIAnimationTween-get_tweenValue0 = 3,
		Beyond-UI-UIAnimationLoopSynchronizer-GetLoopStartPosition0 = 3,
		Beyond-UI-FitAspectRatioByFOV-get_maxFov0 = 3,
		Beyond-UI-UILoopScrollRect-get_viewportSize0 = 3,
		Beyond-UI-UILoopScrollRect-get_scrollSensitivity0 = 3,
		Beyond-UI-UILoopScrollRect-get_Position0 = 3,
		Beyond-UI-NonDrawingGraphic-get_Radius0 = 3,
		Beyond-UI-ParallaxHelper-get_curValue0 = 3,
		Beyond-UI-UIRecycleLayoutGroup-get_spacing0 = 3,
		Beyond-UI-UIRecycleLayoutGroup-get_minWidth0 = 3,
		Beyond-UI-UIRecycleLayoutGroup-get_minHeight0 = 3,
		Beyond-UI-UIRecycleLayoutGroup-get_flexibleWidth0 = 3,
		Beyond-UI-UIRecycleLayoutGroup-get_flexibleHeight0 = 3,
		Beyond-UI-UIRecycleLayoutGroup-get_preferredWidth0 = 3,
		Beyond-UI-UIRecycleLayoutGroup-get_preferredHeight0 = 3,
		Beyond-UI-UIRecycleLayoutGroup-get_paddingFront0 = 3,
		Beyond-UI-UIRecycleLayoutGroup-get_paddingBack0 = 3,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetSizeOnAxis0 = 3,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewportSizeOnAxis0 = 3,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPreferSize0 = 3,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPreferSize0 = 3,
		Beyond-UI-UIAnimationWrapper-GetOutClipLength0 = 3,
		Beyond-UI-UIAnimationWrapper-GetInClipLength0 = 3,
		Beyond-UI-UIAnimationWrapper-GetLoopClipLength0 = 3,
		Beyond-UI-UIAnimationWrapper-AnimationRuntime-GetClipLength0 = 3,
		Beyond-UI-UIAnimationTween-GetValue0 = 3,
		Beyond-UI-UIAnimationWrapper-GetCurPlayingTime0 = 3,
		Beyond-UI-UIBigRectHelper-get_zoomRangeMin0 = 3,
		Beyond-UI-UIBigRectHelper-GetCurrentZoomValue0 = 3,
		Beyond-UI-UIButton-get_longPressTime0 = 3,
		Beyond-UI-UICanvasScaleHelper-get_standardHorizontalResolution0 = 3,
		Beyond-UI-UICanvasScaleHelper-get_standardVerticalResolution0 = 3,
		Beyond-UI-UICanvasScaleHelper-get_standardResolutionScale0 = 3,
		Beyond-UI-UICustomLayoutElement-get_alpha0 = 3,
		Beyond-UI-UICustomLayoutElement-get_scale0 = 3,
		Beyond-UI-UICustomLayoutHandle-get_scale0 = 3,
		Beyond-UI-UICustomLayoutHandle-get_alpha0 = 3,
		Beyond-UI-UIDialogText-get_textRevealSpeed0 = 3,
		Beyond-UI-UIDialogText-GetAutoWaitTime0 = 3,
		Beyond-UI-UIDialogText-GetScrollSpeed0 = 3,
		Beyond-UI-UIDialogText-GetDisplayAllCharactersTime0 = 3,
		Beyond-UI-UIDialogTextWithCursor-GetDisplayAllCharactersTime0 = 3,
		Beyond-UI-UIState-StateDescription-ApplyInnerState0 = 3,
		Beyond-UI-UIGroupScrollList-_GetDefaultGroupTitleSize0 = 3,
		Beyond-UI-UIScrollList-get_currentStep0 = 3,
		Beyond-UI-UIImageFillAmountOffset-get_fillAmount0 = 3,
		Beyond-UI-UIInertiaViewPager-get_currentScrollIndex0 = 3,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_velocity0 = 3,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_scrollProgress0 = 3,
		Beyond-UI-UIJoystick-get_walkRation0 = 3,
		Beyond-UI-UIJoystick-get_m_thumbPosMaxLength0 = 3,
		Beyond-UI-UINonUnifiedScrollList-GetCenterIndex0 = 3,
		Beyond-UI-UINonUnifiedScrollList-get_currentStep0 = 3,
		Beyond-UI-UINonUnifiedScrollList-GetScrollBarSize0 = 3,
		Beyond-UI-UINonUnifiedScrollList-GetLastScrollStep0 = 3,
		Beyond-UI-UINonUnifiedScrollList-GetNormalizedPosition0 = 3,
		Beyond-UI-UIScrollCircle-get_elasticity0 = 3,
		Beyond-UI-UIScrollCircle-get_velocity0 = 3,
		Beyond-UI-UIScrollList-get_cellWidth0 = 3,
		Beyond-UI-UIScrollList-get_cellHeight0 = 3,
		Beyond-UI-UIScrollList-GetCenterIndex0 = 3,
		Beyond-UI-UIScrollText-GetSingleScrollDuration0 = 3,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-ScrollListLayoutInfo-get_cellHeight0 = 3,
		Beyond-UI-FadeSwitchTween-get_activeAlpha0 = 3,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-get_AnimationDuration0 = 3,
		Beyond-UI-GPUI-RuntimeInstance-get_AnimationDuration0 = 3,
		Beyond-Scripts-UI-Tools-UIGridLayoutElement-get_layoutPriority0 = 4,
		Beyond-UI-I18nFontLoader-GetCNFontId0 = 4,
		Beyond-UI-UIButton-get_groupId0 = 4,
		Beyond-UI-UILoopScrollRect-get_currentIndex0 = 4,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetViewID0 = 4,
		Beyond-UI-UIRecycleLayoutGroup-get_layoutPriority0 = 4,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViewCount0 = 4,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetIndex0 = 4,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetIndex0 = 4,
		Beyond-UI-UIButton-get_hoverBindingGroupId0 = 4,
		Beyond-UI-UIDialogText-get_totalCharacterNum0 = 4,
		Beyond-UI-UIDragHandler-get_dragThreshold0 = 4,
		Beyond-UI-UIDropdown-get_groupId0 = 4,
		Beyond-UI-UIGroupScrollList-get_totalCellCount0 = 4,
		Beyond-UI-UIScrollList-get_curSelectedIndex0 = 4,
		Beyond-UI-UIScrollList-GetNaviManagerTargetIndex0 = 4,
		Beyond-UI-UIImage-get_atlasHandleId0 = 4,
		Beyond-UI-UIImage-get_panelLevel0 = 4,
		Beyond-UI-UIInertiaViewPager-get_currentPage0 = 4,
		Beyond-UI-UIJoystick-get_activeTouchId0 = 4,
		Beyond-UI-UIJoystick-get_groupId0 = 4,
		Beyond-UI-UIMultiSelectDropdown-_GetLastSelectedIndex0 = 4,
		Beyond-UI-UIMultiSelectDropdown-get_groupId0 = 4,
		Beyond-UI-UIScrollList-get_maxShowingCellCount0 = 4,
		Beyond-UI-UIScrollList-get_countPerLine0 = 4,
		Beyond-UI-UIScrollList-get_naviBindingGroupId0 = 4,
		Beyond-UI-UISelectableNaviGroup-GetOwnerPanelId0 = 4,
		Beyond-UI-UISelectableNaviGroup-get_FocusBindingId0 = 4,
		Beyond-UI-UISelectableNaviGroup-get_StopFocusBindingId0 = 4,
		Beyond-UI-UISlider-get_groupId0 = 4,
		Beyond-UI-UIStepScrollList-get_centerIndex0 = 4,
		Beyond-UI-UIStepScrollList-_GetClampedIndex0 = 4,
		Beyond-UI-UITouchPanel-get_groupId0 = 4,
		Beyond-UI-UIAtlasManager-UIAtlasPage-get_maxFreeRectWidth0 = 4,
		Beyond-UI-UIAtlasManager-UIAtlasPage-get_maxFreeRectHeight0 = 4,
		Beyond-UI-UIAtlasManager-GetAtlasCount0 = 4,
		Beyond-UI-UIState-StateDescription-_GetTargetHashCode0 = 4,
		Beyond-UI-UIState-StateDescription-GetHashCode0 = 4,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_GetSpriteInstanceId0 = 4,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-_GetSpriteInstanceId0 = 4,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-DynamicPrefabNodeKey-_GetSpriteInstanceId0 = 4,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_FindPreferredRootAnimationIndex0 = 4,
		Beyond-UI-GPUI-GPUIExtendedSystem-_CalculateRequiredPrefabBufferSize0 = 4,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_sortingOrder0 = 4,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-get_tickOption0 = 5,
		Beyond-Gameplay-UI-UIScrollCellSlantEffect-get_tickOption0 = 5,
		Beyond-UI-Billboard-get_tickOption0 = 5,
		Beyond-UI-DecoLineActiveHelper-get_tickOption0 = 5,
		Beyond-UI-FixRotation-get_tickOption0 = 5,
		Beyond-UI-UILoopScrollRect-get_tickOption0 = 5,
		Beyond-UI-UILoopScrollView-get_tickOption0 = 5,
		Beyond-UI-MouseHoverTipsPosHelper-get_tickOption0 = 5,
		Beyond-UI-PercentNumberTweener-get_tickOption0 = 5,
		Beyond-UI-UIRecycleLayoutGroup-get_tickOption0 = 5,
		Beyond-UI-UIArea-get_tickOption0 = 5,
		Beyond-UI-UIAutoCloseArea-get_tickOption0 = 5,
		Beyond-UI-UIBigRectHelper-get_tickOption0 = 5,
		Beyond-UI-UIBlurMono-get_tickOption0 = 5,
		Beyond-UI-UIDialogText-get_tickOption0 = 5,
		Beyond-UI-UIElementFollower-get_tickOption0 = 5,
		Beyond-UI-UIGraphicAnimation-get_tickOption0 = 5,
		Beyond-UI-UIGyroscopeEffect-get_tickOption0 = 5,
		Beyond-UI-UIHighlightMask-get_tickOption0 = 5,
		Beyond-UI-UIImageBlur-get_tickOption0 = 5,
		Beyond-UI-UIImageFillFollower-get_tickOption0 = 5,
		Beyond-UI-UIImageFillTailFollower-get_tickOption0 = 5,
		Beyond-UI-UIInertiaViewPager-get_tickOption0 = 5,
		Beyond-UI-UILeftSubtitle-get_tickOption0 = 5,
		Beyond-UI-UIMaterialAnimation-get_tickOption0 = 5,
		Beyond-UI-UINumberScrollTween-get_tickOption0 = 5,
		Beyond-UI-UIScaleHolder-get_tickOption0 = 5,
		Beyond-UI-UIScrollbarKeyHint-get_tickOption0 = 5,
		Beyond-UI-UIScrollCircle-get_tickOption0 = 5,
		Beyond-UI-UIScrollContainerFollower-get_tickOption0 = 5,
		Beyond-UI-UIScrollList-get_tickOption0 = 5,
		Beyond-UI-UIScrollRectEdgeRedDot-get_tickOption0 = 5,
		Beyond-UI-UIScrollText-get_tickOption0 = 5,
		Beyond-UI-UISemiCircleScrollList-get_tickOption0 = 5,
		Beyond-UI-UISequenceImage-get_tickOption0 = 5,
		Beyond-UI-UISimpleActiveAnimationHelper-get_tickOption0 = 5,
		Beyond-UI-UISizeFollower-get_tickOption0 = 5,
		Beyond-UI-UISoftMask-get_tickOption0 = 5,
		Beyond-UI-UISoftMaskable-get_tickOption0 = 5,
		Beyond-UI-UITouchPanel-get_tickOption0 = 5,
		Beyond-UI-UIVFXManager-get_tickOption0 = 5,
		Beyond-UI-UIState-UIStateController-get_tickOption0 = 5,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-get_panel0 = 6,
		Beyond-UI-UIText-get_panel0 = 6,
		Beyond-UI-UIAnimationWrapper-get_panel0 = 6,
		Beyond-UI-UIButton-get_panel0 = 6,
		Beyond-UI-MouseHoverTipsPosHelper-get_panel0 = 6,
		Beyond-UI-UIAutoCloseArea-get_panel0 = 6,
		Beyond-UI-UIBlurMono-get_panel0 = 6,
		Beyond-UI-UICustomLayoutElement-get_panel0 = 6,
		Beyond-UI-UICustomLayoutHandle-get_panel0 = 6,
		Beyond-UI-UIDragItem-get_panel0 = 6,
		Beyond-UI-UIDropdown-get_panel0 = 6,
		Beyond-UI-UIScrollRect-get_panel0 = 6,
		Beyond-UI-UIElementFollower-get_panel0 = 6,
		Beyond-UI-UIScrollList-get_panel0 = 6,
		Beyond-UI-UIHighlightMask-get_panel0 = 6,
		Beyond-UI-UIImage-get_panel0 = 6,
		Beyond-UI-UIInputField-get_panel0 = 6,
		Beyond-UI-UIJoystick-get_panel0 = 6,
		Beyond-UI-UIMultiSelectDropdown-get_panel0 = 6,
		Beyond-UI-UIScrollCircle-get_panel0 = 6,
		Beyond-UI-VirtualMouseInitPos-get_panel0 = 6,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-SetLookAtCamera0 = 7,
		Beyond-UI-UIText-HyperlinkUITextGroup-ChangeDisplayable0 = 7,
		Beyond-UI-LuaPanel-InformAnimationInEnd0 = 7,
		Beyond-UI-UIImage-_LoadSprite0 = 7,
		Beyond-UI-UIImage-LoadSpriteWithOutFormat0 = 7,
		Beyond-UI-UIActionKeyHint-_SetSecondIcon0 = 7,
		Beyond-UI-UIActionKeyHint-SetSecondActionId0 = 7,
		Beyond-UI-UIActionKeyHint-SetActionId0 = 7,
		Beyond-UI-UIColorGroup-AttachGraphic0 = 7,
		Beyond-UI-UIDialogText-SetText0 = 7,
		Beyond-UI-UIImage-LoadMaterial0 = 7,
		Beyond-UI-UIInputField-_OnCloudGameKeyboardComplete0 = 7,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnUp0 = 7,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnDown0 = 7,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnLeft0 = 7,
		Beyond-UI-UISelectableNaviGroup-TryChangeNaviPartnerOnRight0 = 7,
		Beyond-UI-UISubtitle-SetSubtitle0 = 7,
		Beyond-UI-FadeSwitchTween-SetObjectActive0 = 7,
		Beyond-UI-UIState-UIStateControllerLogicalGroup-Group-SetState0 = 7,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-Tick0 = 8,
		Beyond-Gameplay-UI-UIScrollCellCircleEffect-LateTick0 = 8,
		Beyond-Gameplay-UI-UIScrollCellSlantEffect-Tick0 = 8,
		Beyond-UI-UIText-_UpdateTick0 = 8,
		Beyond-UI-UIUtils-SetAlpha0 = 8,
		Beyond-UI-UIUtils-SetMaskRatio0 = 8,
		Beyond-UI-Billboard-Tick0 = 8,
		Beyond-UI-DecoLineActiveHelper-LateTick0 = 8,
		Beyond-UI-FitAspectRatioByFOV-set_maxFov0 = 8,
		Beyond-UI-FixRotation-LateTick0 = 8,
		Beyond-UI-UILoopScrollRect-set_scrollSensitivity0 = 8,
		Beyond-UI-UILoopScrollRect-_UpdatePosition0 = 8,
		Beyond-UI-UILoopScrollRect-set_Position0 = 8,
		Beyond-UI-UILoopScrollRect-Tick0 = 8,
		Beyond-UI-UILoopScrollView-_ResizePool0 = 8,
		Beyond-UI-UILoopScrollView-UpdatePosition0 = 8,
		Beyond-UI-UILoopScrollView-_TickRefreshControllerStickScroll0 = 8,
		Beyond-UI-UILoopScrollView-Tick0 = 8,
		Beyond-UI-MouseHoverTipsPosHelper-LateTick0 = 8,
		Beyond-UI-ParallaxHelper-set_curValue0 = 8,
		Beyond-UI-PercentNumberTweener-LateTick0 = 8,
		Beyond-UI-UIRecycleLayoutGroup-LateTick0 = 8,
		Beyond-UI-UIArea-Tick0 = 8,
		Beyond-UI-UIAutoCloseArea-LateTick0 = 8,
		Beyond-UI-UIBigLogo-SetMaskAlpha0 = 8,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickMove0 = 8,
		Beyond-UI-UIBigRectHelper-_TickRefreshControllerStickZoom0 = 8,
		Beyond-UI-UIBigRectHelper-_TickRefreshController0 = 8,
		Beyond-UI-UIBigRectHelper-Tick0 = 8,
		Beyond-UI-UIBigRectHelper-LateTick0 = 8,
		Beyond-UI-UIBigRectHelper-SetZoomRangeMax0 = 8,
		Beyond-UI-UIBigRectHelper-OverrideZoomRangeMin0 = 8,
		Beyond-UI-UIBlurMono-Tick0 = 8,
		Beyond-UI-UICustomLayoutElement-set_scale0 = 8,
		Beyond-UI-UICustomLayoutElement-set_alpha0 = 8,
		Beyond-UI-UICustomLayoutHandle-set_scale0 = 8,
		Beyond-UI-UICustomLayoutHandle-set_alpha0 = 8,
		Beyond-UI-UIDialogText-set_textRevealSpeed0 = 8,
		Beyond-UI-UIDialogText-Tick0 = 8,
		Beyond-UI-UIDialogText-ManualUpdateByPercent0 = 8,
		Beyond-UI-UIDialogText-ManualUpdateByTime0 = 8,
		Beyond-UI-UIDialogTimelineText-UpdateAlpha0 = 8,
		Beyond-UI-UIState-UIStateControllerUtils-SetTop0 = 8,
		Beyond-UI-UIState-UIStateControllerUtils-SetBottom0 = 8,
		Beyond-UI-UIState-UIStateControllerUtils-SetLeft0 = 8,
		Beyond-UI-UIState-UIStateControllerUtils-SetRight0 = 8,
		Beyond-UI-UIScrollList-SetContainerSize0 = 8,
		Beyond-UI-UIElementFollower-LateTick0 = 8,
		Beyond-UI-UIGraphicAnimation-LateTick0 = 8,
		Beyond-UI-UIScrollList-_SetAutoScrollSpd0 = 8,
		Beyond-UI-UIGyroscopeEffect-Tick0 = 8,
		Beyond-UI-UIHighlightMask-Tick0 = 8,
		Beyond-UI-UIImageBlur-Tick0 = 8,
		Beyond-UI-UIImageFillAmountOffset-set_fillAmount0 = 8,
		Beyond-UI-UIImageFillFollower-Tick0 = 8,
		Beyond-UI-UIImageFillTailFollower-Tick0 = 8,
		Beyond-UI-UIInertiaViewPager-BlockerManager-StartInertia0 = 8,
		Beyond-UI-UIInertiaViewPager-Tick0 = 8,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-set_scrollProgress0 = 8,
		Beyond-UI-UIJoystick-set_walkRation0 = 8,
		Beyond-UI-UILeftSubtitle-Tick0 = 8,
		Beyond-UI-UILeftSubtitle-StartAutoPlay0 = 8,
		Beyond-UI-UIMaterialAnimation-LateTick0 = 8,
		Beyond-UI-UINonUnifiedScrollList-LateTick0 = 8,
		Beyond-UI-UIScrollList-SetStepTo0 = 8,
		Beyond-UI-UINonUnifiedScrollList-set_currentStep0 = 8,
		Beyond-UI-UINonUnifiedScrollList-SetStepTo0 = 8,
		Beyond-UI-UINonUnifiedScrollList-SetCurrentStep0 = 8,
		Beyond-UI-UINonUnifiedScrollList-SetNormalizedPosition0 = 8,
		Beyond-UI-UINonUnifiedScrollRect-SetHorizontalNormalizedPosition0 = 8,
		Beyond-UI-UINonUnifiedScrollRect-SetVerticalNormalizedPosition0 = 8,
		Beyond-UI-UINumberScrollTween-Tick0 = 8,
		Beyond-UI-UIScaleHolder-LateTick0 = 8,
		Beyond-UI-UIScrollbarKeyHint-Tick0 = 8,
		Beyond-UI-UIScrollCircle-set_elasticity0 = 8,
		Beyond-UI-UIScrollCircle-set_velocity0 = 8,
		Beyond-UI-UIScrollCircle-LateTick0 = 8,
		Beyond-UI-UIScrollContainerFollower-LateTick0 = 8,
		Beyond-UI-UIScrollList-_UpdateGraduallyShow0 = 8,
		Beyond-UI-UIScrollList-_UpdateAutoScroll0 = 8,
		Beyond-UI-UIScrollList-Tick0 = 8,
		Beyond-UI-UIScrollList-LateTick0 = 8,
		Beyond-UI-UIScrollList-set_currentStep0 = 8,
		Beyond-UI-UIScrollList-SetPaddingBottom0 = 8,
		Beyond-UI-UIScrollList-SetPaddingTop0 = 8,
		Beyond-UI-UIScrollList-SetPaddingRight0 = 8,
		Beyond-UI-UIScrollList-SetPaddingLeft0 = 8,
		Beyond-UI-UIScrollRectEdgeRedDot-Tick0 = 8,
		Beyond-UI-UIScrollText-_ApplyTextScroll0 = 8,
		Beyond-UI-UIScrollText-LateTick0 = 8,
		Beyond-UI-UIScrollText-CanvasGroupHandler-HandleAlpha0 = 8,
		Beyond-UI-UIScrollText-PositionScrollHandler-ApplyScroll0 = 8,
		Beyond-UI-UIScrollText-MeshScrollHandler-_ApplyScroll0 = 8,
		Beyond-UI-UIScrollText-MeshScrollHandler-ApplyScroll0 = 8,
		Beyond-UI-UISemiCircleScrollList-Tick0 = 8,
		Beyond-UI-UISequenceImage-Tick0 = 8,
		Beyond-UI-UISimpleActiveAnimationHelper-Tick0 = 8,
		Beyond-UI-UISizeFollower-LateTick0 = 8,
		Beyond-UI-UISlider-_ApplyGamepadStickScroll0 = 8,
		Beyond-UI-UISlider-_GamepadStickScrollTick0 = 8,
		Beyond-UI-UISoftMask-TailLateTick0 = 8,
		Beyond-UI-UISoftMaskable-LateTick0 = 8,
		Beyond-UI-UITouchPanel-Tick0 = 8,
		Beyond-UI-UITouchPanel-LateTick0 = 8,
		Beyond-UI-UIVFXManager-LateTick0 = 8,
		Beyond-UI-FadeSwitchTween-set_activeAlpha0 = 8,
		Beyond-UI-UIAtlasManager-LateTick0 = 8,
		Beyond-UI-UIState-UIStateController-Tick0 = 8,
		Beyond-UI-UIText-_GetHyperlinkText0 = 9,
		Beyond-UI-UIText-_ResolveTextStyle0 = 10,
		Beyond-UI-UICustomLayoutElement-GetElementKeyWithRatio0 = 10,
		Beyond-UI-UIMaterialAnimation-_GetSlotName0 = 10,
		Beyond-UI-UIText-HyperlinkUITextManager-get_instance0 = 11,
		Beyond-UI-UIText-HyperlinkUITextManager-_IsUITextDisplayable0 = 12,
		Beyond-UI-UIText-HyperlinkUITextManager-IsGroupDisplayable0 = 12,
		Beyond-UI-LuaPanel-InformAnimationInStart0 = 12,
		Beyond-UI-UIAnimationLoopSynchronizer-IsLoopAudioOwner0 = 12,
		Beyond-UI-UIScrollList-_IsValidWrapNaviTarget0 = 12,
		Beyond-UI-DecoLineActiveHelper-_HasActiveTarget0 = 12,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-Recycle0 = 12,
		Beyond-UI-UIRecycleLayoutGroup-_RemoveView0 = 12,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AddView0 = 12,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RemoveView0 = 12,
		Beyond-UI-UIInertiaViewPager-DragContext-_TryFlingToNext0 = 12,
		Beyond-UI-UIScrollRect-IsCellViewed0 = 12,
		Beyond-UI-UIStyleByState-_IsValidStyle0 = 12,
		Beyond-UI-UITouchPanel-_IsSameTouchFromPress0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsAnimation0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsAnimator0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsButton0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsCanvasGroup0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsComponent0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsGameObject0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsState0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsImage0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsText0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsRectTransform0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsLayoutElement0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsGraphic0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsLayoutGroup0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsScrollList0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsGridLayoutGroup0 = 12,
		Beyond-UI-UIState-StateDescription-EqualsSelectable0 = 12,
		Beyond-UI-UIState-StateDescription-_EqualsByTargetType0 = 12,
		Beyond-UI-UIState-StateDescription-Equals0 = 12,
		Beyond-UI-UIState-StateDescription-op_Equality0 = 12,
		Beyond-UI-UIState-StateDescription-op_Inequality0 = 12,
		Beyond-UI-UIState-StateDescription-Equals1 = 12,
		Beyond-UI-UIState-UIStateControllerLogicalGroup-LogicalGroup-_IsStateMatched0 = 12,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_IsValidStaticTexture0 = 12,
		Beyond-UI-UIText-HyperlinkUITextManager-_GetGroup0 = 13,
		Beyond-UI-UIText-HyperlinkUITextManager-UpdateWrapDisplayable0 = 14,
		Beyond-UI-UIText-SetAndResolveTextStyle0 = 14,
		Beyond-UI-UIText-set_text0 = 14,
		Beyond-UI-UIText-_ReturnImageGO0 = 14,
		Beyond-UI-UIText-HyperlinkUITextGroup-Remove0 = 14,
		Beyond-UI-UIText-HyperlinkUITextManager-RemoveWrap0 = 14,
		Beyond-UI-UIText-_OnPreRenderText0 = 14,
		Beyond-UI-UIText-OnPointerClick0 = 14,
		Beyond-UI-UIText-OnPointerEnter0 = 14,
		Beyond-UI-UIText-OnPointerExit0 = 14,
		Beyond-UI-UIText-HyperlinkUITextGroup-Add0 = 14,
		Beyond-UI-UIText-set_m_fontAsset0 = 14,
		Beyond-UI-UIText-set_fontSharedMaterial0 = 14,
		Beyond-UI-UIText-SetSharedMaterial0 = 14,
		Beyond-UI-UIModelLoader-UnloadModel0 = 14,
		Beyond-UI-UIScrollList-CacheCell0 = 14,
		Beyond-UI-UIButton-_Press0 = 14,
		Beyond-UI-UIButton-OnPointerClick0 = 14,
		Beyond-UI-Empty4Raycast-OnPopulateMesh0 = 14,
		Beyond-UI-UILoopScrollRect-OnValueChanged0 = 14,
		Beyond-UI-UILoopScrollRect-OnSelectionChanged0 = 14,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown0 = 14,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp0 = 14,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IScrollHandler.OnScroll0 = 14,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag0 = 14,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IDragHandler.OnDrag0 = 14,
		Beyond-UI-UILoopScrollRect-UnityEngine.EventSystems.IEndDragHandler.OnEndDrag0 = 14,
		Beyond-UI-UILoopScrollView-_ScrollToCell0 = 14,
		Beyond-UI-UILoopScrollView-ScrollToObject0 = 14,
		Beyond-UI-UILoopScrollView-_ScrollToNaviTarget0 = 14,
		Beyond-UI-LuaPanel-AddSortingOrderComp0 = 14,
		Beyond-UI-LuaPanel-RemoveSortingOrderComp0 = 14,
		Beyond-UI-NonDrawingGraphic-OnPopulateMesh0 = 14,
		Beyond-UI-NotchAdapter-_TraverseUI0 = 14,
		Beyond-UI-UIRecycleLayoutAdapter-Init0 = 14,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-AttachView0 = 14,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-RebuildAll0 = 14,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-AttachView0 = 14,
		Beyond-UI-UIRecycleLayoutGroup-_UpdateViewsFrom0 = 14,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-NotifyViewSizeChanged0 = 14,
		Beyond-UI-ToastList-_CacheCell0 = 14,
		Beyond-UI-UIAnimationWrapper-PlayOutAnimation0 = 14,
		Beyond-UI-ToastList-_OnCellFinished0 = 14,
		Beyond-UI-UIActionKeyHint-_SubscribeTarget0 = 14,
		Beyond-UI-UIActionKeyHint-SetText0 = 14,
		Beyond-UI-UIAnimationHolder-GetAnimationClips0 = 14,
		Beyond-UI-UIAnimationLoopSynchronizer-RegisterChild0 = 14,
		Beyond-UI-UIAnimationLoopSynchronizer-UnregisterChild0 = 14,
		Beyond-UI-UIAnimationWrapper-SetAnimationInClip0 = 14,
		Beyond-UI-UIAnimationWrapper-SetAnimationInEasingClip0 = 14,
		Beyond-UI-UIAnimationWrapper-SetAnimationLoopClip0 = 14,
		Beyond-UI-UIAnimationWrapper-SetAnimationOutClip0 = 14,
		Beyond-UI-UIAnimationWrapper-SetAudioOnOpen0 = 14,
		Beyond-UI-UIAnimationWrapper-SetAudioOnLoop0 = 14,
		Beyond-UI-UIArea-OnPointerEnter0 = 14,
		Beyond-UI-UIArea-OnPointerExit0 = 14,
		Beyond-UI-UIButton-OnPointerDown0 = 14,
		Beyond-UI-UIBigRectButton-OnPointerDown0 = 14,
		Beyond-UI-UIButton-OnPointerUp0 = 14,
		Beyond-UI-UIBigRectButton-OnPointerUp0 = 14,
		Beyond-UI-UIBigRectButton-OnDrag0 = 14,
		Beyond-UI-UIBigRectButton-OnBeginDrag0 = 14,
		Beyond-UI-UIBigRectButton-OnEndDrag0 = 14,
		Beyond-UI-UIBigRectButton-OnScroll0 = 14,
		Beyond-UI-UIBigRectHelper-ZoomToFullRect0 = 14,
		Beyond-UI-UIBigRectHelper-ChangePivotPositionToTarget0 = 14,
		Beyond-UI-UIBigRectHelper-RecoverContainerState0 = 14,
		Beyond-UI-UIBlendImage-SetMaterialKey0 = 14,
		Beyond-UI-UIBlurRT-SetCustomBlurImg0 = 14,
		Beyond-UI-UIButton-set_text0 = 14,
		Beyond-UI-UIButton-set_customBindingViewLabelText0 = 14,
		Beyond-UI-UICustomLayout-_LogEvent0 = 14,
		Beyond-UI-UICustomLayoutHandle-OnBeginDrag0 = 14,
		Beyond-UI-UICustomLayoutHandle-OnDrag0 = 14,
		Beyond-UI-UICustomLayoutHandle-OnEndDrag0 = 14,
		Beyond-UI-UICustomLayoutHandle-OnPointerClick0 = 14,
		Beyond-UI-UIDrag-OnDrag0 = 14,
		Beyond-UI-UIDrag-OnBeginDrag0 = 14,
		Beyond-UI-UIDrag-OnEndDrag0 = 14,
		Beyond-UI-UIDragHandler-OnPointerDown0 = 14,
		Beyond-UI-UIDragHandler-OnBeginDrag0 = 14,
		Beyond-UI-UIDragHandler-OnDrag0 = 14,
		Beyond-UI-UIDragHandler-OnEndDrag0 = 14,
		Beyond-UI-UIDragItem-set_dragObjectParent0 = 14,
		Beyond-UI-UIDragItem-OnEndDrag0 = 14,
		Beyond-UI-UIDragItem-OnDrag0 = 14,
		Beyond-UI-UIDragItem-OnBeginDrag0 = 14,
		Beyond-UI-UIDropdown-OnPointerClick0 = 14,
		Beyond-UI-UIDropdownOption-SetText0 = 14,
		Beyond-UI-UIState-StateReference-SetController0 = 14,
		Beyond-UI-UIState-StateReference-ScheduleForPlaying0 = 14,
		Beyond-UI-UIState-StateReference-ScheduleForStopping0 = 14,
		Beyond-UI-UIState-UIStateController-Run0 = 14,
		Beyond-UI-UIState-UIStateController-Stop0 = 14,
		Beyond-UI-UIDropdownOption-SetState0 = 14,
		Beyond-UI-UIDropItem-OnDrop0 = 14,
		Beyond-UI-UIElementFollower-set_targetTransform0 = 14,
		Beyond-UI-UIExtendScrollRect-OnScroll0 = 14,
		Beyond-UI-UIScrollList-OnBeginDrag0 = 14,
		Beyond-UI-UIExtendScrollRect-OnBeginDrag0 = 14,
		Beyond-UI-UIScrollList-OnDrag0 = 14,
		Beyond-UI-UIExtendScrollRect-OnDrag0 = 14,
		Beyond-UI-UIScrollList-OnEndDrag0 = 14,
		Beyond-UI-UIExtendScrollRect-OnEndDrag0 = 14,
		Beyond-UI-UIScrollRect-WrapNavigation0 = 14,
		Beyond-UI-UIScrollList-_OnEnterAutoScrollUp0 = 14,
		Beyond-UI-UIScrollList-_OnExitAutoScrollUp0 = 14,
		Beyond-UI-UIScrollList-_OnEnterAutoScrollDown0 = 14,
		Beyond-UI-UIScrollList-_OnExitAutoScrollDown0 = 14,
		Beyond-UI-UIScrollList-_OnNaviTargetChangedForSync0 = 14,
		Beyond-UI-UIGroupScrollList-_CacheTitleCell0 = 14,
		Beyond-UI-UIGroupScrollList-_CacheGroupBGCell0 = 14,
		Beyond-UI-UIImage-RegisterOnEnableRuntimeAtlas0 = 14,
		Beyond-UI-UIImage-UnregisterOnEnableRuntimeAtlas0 = 14,
		Beyond-UI-UIAtlasManager-_ReProcessInsertForUIImage0 = 14,
		Beyond-UI-UIImage-_OnSpriteChanged0 = 14,
		Beyond-UI-UIImage-OnPopulateMeshFallback0 = 14,
		Beyond-UI-UIAtlasManager-_AddUIImageToManagerOnInstantiate0 = 14,
		Beyond-UI-UIAtlasManager-_AddUIImageToManager0 = 14,
		Beyond-UI-UIAtlasManager-_RemoveUIImageFromManager0 = 14,
		Beyond-UI-UIImage-LoadSprite1 = 14,
		Beyond-UI-UIImagePair-LoadSprite0 = 14,
		Beyond-UI-UIInertiaViewPager-DragContext-BeginDrag0 = 14,
		Beyond-UI-UIInputField-OnSelect0 = 14,
		Beyond-UI-UIInputField-OnDeselect0 = 14,
		Beyond-UI-UIInputField-OnUpdateSelected0 = 14,
		Beyond-UI-UIJoystick-OnPointerDown0 = 14,
		Beyond-UI-UIJoystick-OnBeginDrag0 = 14,
		Beyond-UI-UIJoystick-OnPointerUp0 = 14,
		Beyond-UI-UIJoystick-OnDrag0 = 14,
		Beyond-UI-UILayoutDimensionListener-DoOnceOnPostLayout0 = 14,
		Beyond-UI-UIMultiSelectDropdown-OnPointerClick0 = 14,
		Beyond-UI-UINumberScrollTween-_TweenToTarget0 = 14,
		Beyond-UI-UINumberScrollTween-set_tweenToText0 = 14,
		Beyond-UI-UINumberScrollTween-set_text0 = 14,
		Beyond-UI-UIScrollCircle-OnInitializePotentialDrag0 = 14,
		Beyond-UI-UIScrollCircle-OnBeginDrag0 = 14,
		Beyond-UI-UIScrollCircle-OnEndDrag0 = 14,
		Beyond-UI-UIScrollCircle-OnDrag0 = 14,
		Beyond-UI-UIScrollCircle-OnScroll0 = 14,
		Beyond-UI-UIScrollList-UpdateShowingCells1 = 14,
		Beyond-UI-UIScrollRect-ScrollToNaviTarget0 = 14,
		Beyond-UI-UIScrollRect-OnBeginDrag0 = 14,
		Beyond-UI-UIScrollRect-OnDrag0 = 14,
		Beyond-UI-UIScrollRect-OnEndDrag0 = 14,
		Beyond-UI-UIScrollRectEdgeRedDot-UnregisterRedDot0 = 14,
		Beyond-UI-UIScrollText-MeshScrollHandler-_UpdateMeshClipping0 = 14,
		Beyond-UI-UISelectableNaviGroup-_OnSetLayerSelectedTarget0 = 14,
		Beyond-UI-UISelectableNaviGroup-SetFocusBindingText0 = 14,
		Beyond-UI-UISemiCircleScrollList-OnEndDrag0 = 14,
		Beyond-UI-UISemiCircleScrollList-OnDrag0 = 14,
		Beyond-UI-UISemiCircleScrollList-OnBeginDrag0 = 14,
		Beyond-UI-UISimpleStateController-SetState0 = 14,
		Beyond-UI-UISlider-OnBeginDrag0 = 14,
		Beyond-UI-UISlider-OnEndDrag0 = 14,
		Beyond-UI-UISoftMask-RegisterMaskable0 = 14,
		Beyond-UI-UISoftMask-UnregisterMaskable0 = 14,
		Beyond-UI-UISoftMask-_DestroyMaterial0 = 14,
		Beyond-UI-UISoftMaskable-ModifyMesh0 = 14,
		Beyond-UI-UISoftMaskable-ModifyMesh1 = 14,
		Beyond-UI-UIStepScrollList-OnBeginDrag0 = 14,
		Beyond-UI-UIStepScrollList-OnEndDrag0 = 14,
		Beyond-UI-UITextPair-set_text0 = 14,
		Beyond-UI-UITextPair-SetAndResolveTextStyle0 = 14,
		Beyond-UI-UIToggle-set_customBindingViewLabelText0 = 14,
		Beyond-UI-UIToggle-OnPointerDown0 = 14,
		Beyond-UI-UIToggle-OnPointerClick0 = 14,
		Beyond-UI-UIToggle-OnSubmit0 = 14,
		Beyond-UI-UITouchPanel-OnBeginDrag0 = 14,
		Beyond-UI-UITouchPanel-OnEndDrag0 = 14,
		Beyond-UI-UITouchPanel-OnDrag0 = 14,
		Beyond-UI-UITouchPanel-_OnActionPress0 = 14,
		Beyond-UI-UITouchPanel-OnPointerDown0 = 14,
		Beyond-UI-UITouchPanel-_OnActionRelease0 = 14,
		Beyond-UI-UITouchPanel-OnPointerUp0 = 14,
		Beyond-UI-UITouchPanel-OnPointerClick0 = 14,
		Beyond-UI-UITouchPanel-OnPointerEnter0 = 14,
		Beyond-UI-UITouchPanel-OnPointerExit0 = 14,
		Beyond-UI-UITouchPanel-OnScroll0 = 14,
		Beyond-UI-UITouchPanel-SimulateClick0 = 14,
		Beyond-UI-UIVFXManager-_DestroyMaterial0 = 14,
		Beyond-UI-CSPopupPanel-_OnConfirm0 = 14,
		Beyond-UI-CSPopupPanel-_OnCancel0 = 14,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-RemoveRefText0 = 14,
		Beyond-UI-DynamicFontAssetLoader-TryRemoveRefText0 = 14,
		Beyond-UI-UILoadImageSprite-_LoadSprite0 = 14,
		Beyond-UI-UILoadImageSprite-set_spritePath0 = 14,
		Beyond-UI-UILoadImageSpriteByName-set_spriteName0 = 14,
		Beyond-UI-UICharHeadGlowAnimation-Init0 = 14,
		Beyond-UI-UICharHeadGlowAnimation-AddNode0 = 14,
		Beyond-UI-UICharHeadGlowAnimation-RemoveNode0 = 14,
		Beyond-UI-UIRedDotAnimation-Init0 = 14,
		Beyond-UI-UIRedDotAnimation-AddRedDotImage0 = 14,
		Beyond-UI-UIRedDotAnimation-RemoveRedDotImage0 = 14,
		Beyond-UI-WebApplication-Start0 = 14,
		Beyond-UI-WebApplication-StartHGBrowser0 = 14,
		Beyond-UI-UIState-UIStateController-_HandleStateAnimations0 = 14,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-UnregisterSpriteUV0 = 14,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-UpdateDynamicSpriteContext0 = 14,
		Beyond-UI-GPUI-GPUIExtendedSystem-set_fontAsset0 = 14,
		Beyond-UI-GPUI-GPUIExtendedSystem-RegisterBeforeRenderSync0 = 14,
		Beyond-UI-GPUI-GPUIExtendedSystem-UnregisterBeforeRenderSync0 = 14,
		Beyond-UI-GPUI-GPUIExtendedSystem-_PreloadText0 = 14,
		Beyond-UI-GPUI-GPUIExtendedSystem-_InitDynamicPrefabNodeManager0 = 14,
		Beyond-UI-GPUI-GPUIExtendedSystem-_LoadGroupData0 = 14,
		Beyond-UI-GPUI-GPUIExtendedSystem-_Init0 = 14,
		Beyond-UI-GPUI-GPUIProxySyncManager-UnregisterProxy0 = 14,
		Beyond-UI-GPUI-GPUIProxySyncManager-RegisterProxy0 = 14,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_HandleTargetSystemChanged0 = 14,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-SetSyncManager0 = 14,
		Beyond-UI-GPUI-GPUIProxySyncManager-MarkDirty0 = 14,
		Beyond-UI-GPUI-GPUISharedGraphicBase-OnPopulateMesh0 = 14,
		Beyond-UI-GPUI-GPUISystem-set_fontAsset0 = 14,
		Beyond-UI-GPUI-GPUISystem-_PreloadTextInGroupData0 = 14,
		Beyond-UI-GPUI-GPUISystem-_LoadGroupData0 = 14,
		Beyond-UI-GPUI-GPUISystem-_Init0 = 14,
		Beyond-UI-GPUI-GPUISystem-OnPopulateMesh0 = 14,
		Beyond-UI-UIText-GetPhoneticText0 = 15,
		Beyond-UI-UIText-SetPhoneticText0 = 16,
		Beyond-UI-UITextPair-SetPhoneticText0 = 16,
		Beyond-UI-UIText-get_textId0 = 17,
		Beyond-UI-UIText-get_text0 = 17,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetItemName0 = 17,
		Beyond-UI-UIButton-get_text0 = 17,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetText0 = 17,
		Beyond-UI-UIActionKeyHint-GetActionId0 = 17,
		Beyond-UI-UIActionKeyHint-GetTextStr0 = 17,
		Beyond-UI-UIButton-get_bindingViewActionId0 = 17,
		Beyond-UI-UIButton-get_customBindingViewLabelText0 = 17,
		Beyond-UI-UIButton-get_hintText0 = 17,
		Beyond-UI-UIButton-get_bindingViewLabelText0 = 17,
		Beyond-UI-UICustomLayoutElement-get_elementKey0 = 17,
		Beyond-UI-UIDropdown-get_bindingViewActionId0 = 17,
		Beyond-UI-UIDropdown-get_bindingViewLabelText0 = 17,
		Beyond-UI-UIGroupScrollList-_BuildLayoutDebugDumpText0 = 17,
		Beyond-UI-UIGroupScrollList-DebugDumpLayoutToConsoleAndClipboard0 = 17,
		Beyond-UI-UIMultiSelectDropdown-get_bindingViewActionId0 = 17,
		Beyond-UI-UIMultiSelectDropdown-get_bindingViewLabelText0 = 17,
		Beyond-UI-UINumberScrollTween-get_tweenToText0 = 17,
		Beyond-UI-UINumberScrollTween-get_text0 = 17,
		Beyond-UI-UISimpleStateController-get_curStateName0 = 17,
		Beyond-UI-UISimpleStateController-StateInfo-ToString0 = 17,
		Beyond-UI-UISlider-get_bindingViewActionId0 = 17,
		Beyond-UI-UISlider-get_bindingViewLabelText0 = 17,
		Beyond-UI-UITextPair-get_text0 = 17,
		Beyond-UI-UIToggle-get_customBindingViewLabelText0 = 17,
		Beyond-UI-UILoadImageSprite-get_spritePath0 = 17,
		Beyond-UI-UIState-UIStateControllerUtils-GetName0 = 17,
		Beyond-UI-UIState-StateDescription-get_ReadableDescription0 = 17,
		Beyond-UI-UIState-StateDescription-ToString0 = 17,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_prefabName0 = 17,
		Beyond-UI-GPUI-GPUISubrootTag-get_subrootName0 = 17,
		Beyond-UI-UIText-OnEnvLangChanged0 = 18,
		Beyond-UI-UIText-TryGetOriginalLinkId0 = 19,
		Beyond-UI-UIText-TryGetLinkId0 = 20,
		Beyond-UI-UIText-_DelayedChangeActiveImageGo0 = 21,
		Beyond-UI-LuaPanel-_AutoAnimationInFinish0 = 21,
		Beyond-UI-UIButton-_DoClickAnimation0 = 21,
		Beyond-UI-UIDragItem-_ContinueDragOnDisable0 = 21,
		Beyond-UI-UILayoutDimensionListener-_NextFrameCoroutine0 = 21,
		Beyond-UI-UISemiCircleScrollList-_ApplyDamping0 = 21,
		Beyond-UI-UISwitchTween-WaitForTweening0 = 21,
		Beyond-UI-UIText-RichTextAnalyzer-PreAnalyzeRichText0 = 22,
		Beyond-UI-UIText-GetOrLoadSprite0 = 23,
		Beyond-UI-UIText-RichTextAnalyzer-GetCharacterCountWithoutRichText0 = 24,
		Beyond-UI-UIText-RichTextAnalyzer-_GetHashCode0 = 24,
		Beyond-UI-UIText-RichTextAnalyzer-ProcessRichTextEntryFallback0 = 25,
		Beyond-UI-UIText-_ProcessRichTextEntry0 = 26,
		Beyond-UI-UIText-get_processRichTextEntryFunc0 = 27,
		Beyond-UI-UIText-RichTextAnalyzer-_TryParseParam0 = 28,
		Beyond-UI-UIText-RichTextAnalyzer-_TryParseRichTextEntry0 = 29,
		Beyond-UI-UIText-RichTextAnalyzer-AnalyzeRichText0 = 30,
		Beyond-UI-UIText-_GetOrCreateImageGO0 = 31,
		Beyond-UI-UILoopScrollView-GetCurrentCell0 = 31,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-GetAttachedView0 = 31,
		Beyond-UI-UIRecycleMultiHolder-MultiVirtualView-GetPrefab0 = 31,
		Beyond-UI-UIRecycleSingleHolder-SimpleVirtualView-GetPrefab0 = 31,
		Beyond-UI-UIDialogTimelineText-get_waitNode0 = 31,
		Beyond-UI-UIDragItem-get_curDragObj0 = 31,
		Beyond-UI-UIScrollList-get_curSelectedObj0 = 31,
		Beyond-UI-UIText-_GetImageGoByIndex0 = 32,
		Beyond-UI-I18nFontLoader-GetMaterial0 = 33,
		Beyond-UI-UIText-get_fontSharedMaterial0 = 33,
		Beyond-UI-UIGraphicAnimation-get_MaterialInstance0 = 33,
		Beyond-UI-UIMaterialAnimation-_ResolveTargetMaterial0 = 33,
		Beyond-UI-UIMaterialAnimation-get_materialInstance0 = 33,
		Beyond-UI-UISoftMask-get_softMaskDefaultMaterial0 = 33,
		Beyond-UI-UISoftMaskable-get_softMaskModefiedMat0 = 33,
		Beyond-UI-UIText-LoadMaterial0 = 34,
		Beyond-UI-UISoftMask-GetTextSoftMaskMaterial0 = 34,
		Beyond-UI-UISoftMask-GetUIVFXSoftMaskMaterial0 = 34,
		Beyond-UI-UISoftMaskable-GetModifiedMaterial0 = 34,
		Beyond-UI-UIVFXManager-GetModifiedMaterial0 = 34,
		Beyond-UI-UIText-get_autoSizeCacheEnabled0 = 35,
		Beyond-UI-I18nFontLoader-IsFontDefaultMaterial0 = 35,
		Beyond-UI-UIText-IsHyperlinkUITextGroupDisplayable0 = 35,
		Beyond-UI-UIScrollList-get_isHorizontal0 = 35,
		Beyond-UI-UIScrollRect-get_controllerStickScrollEnabled0 = 35,
		Beyond-UI-UIScrollRect-get_IsStickScrolling0 = 35,
		Beyond-UI-UIScrollList-get_isMultiPage0 = 35,
		Beyond-UI-UIScrollList-get_isVertical0 = 35,
		Beyond-UI-ControllerSideMenuItemList-IsItemForceValid0 = 35,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-get_isForceValid0 = 35,
		Beyond-UI-UIButton-get_groupEnabled0 = 35,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-IsValid0 = 35,
		Beyond-UI-CustomUIStyle-get_isValid0 = 35,
		Beyond-UI-UILoopScrollView-get_controllerStickScrollEnabled0 = 35,
		Beyond-UI-UILoopScrollView-Cell-get_isVisible0 = 35,
		Beyond-UI-LuaPanel-get_blockWhileAnim0 = 35,
		Beyond-UI-LuaPanel-get_IsWorldUI0 = 35,
		Beyond-UI-LuaPanel-get_isPCOnlyPanel0 = 35,
		Beyond-UI-LuaPanel-get_isControllerPanel0 = 35,
		Beyond-UI-LuaPanel-get_animationInFinished0 = 35,
		Beyond-UI-UIRecycleLayoutAdapter-VirtualView-get_isAttached0 = 35,
		Beyond-UI-UIActionKeyHint-_IsBindingViewAlive0 = 35,
		Beyond-UI-UIActionKeyHint-_IsInputEnabled0 = 35,
		Beyond-UI-UIActionKeyHint-_IsInputGrey0 = 35,
		Beyond-UI-UIActionKeyHint-get_showCanvasGroup0 = 35,
		Beyond-UI-UIAnimationWrapper-IsStarted0 = 35,
		Beyond-UI-UIAnimationWrapper-_CheckShouldAutoPlayAnimationIn0 = 35,
		Beyond-UI-UIAnimationWrapper-CheckStopped0 = 35,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-IsPlaying0 = 35,
		Beyond-UI-UIArea-get_pointerInArea0 = 35,
		Beyond-UI-UIArea-get_usePositionCheckMode0 = 35,
		Beyond-UI-UIAutoCloseArea-get_includeInAutoCloseLayer0 = 35,
		Beyond-UI-UIAutoCloseArea-IsTopAutoCloseLayer0 = 35,
		Beyond-UI-UIAutoCloseArea-ShouldClose0 = 35,
		Beyond-UI-UIAutoCloseArea-get_groupEnabled0 = 35,
		Beyond-UI-UIBigRectHelper-_GetIsControllerMoveEnabled0 = 35,
		Beyond-UI-UIBigRectHelper-_GetIsControllerZoomEnabled0 = 35,
		Beyond-UI-UIButton-get_triggeredLongPress0 = 35,
		Beyond-UI-UIButton-get_bindingEnabled0 = 35,
		Beyond-UI-UIButton-_IsAnyButtonEventActionInGuideUse0 = 35,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.get_interactable0 = 35,
		Beyond-UI-UICustomLayoutHandle-IsDirty0 = 35,
		Beyond-UI-UICustomLayout-IsDirty0 = 35,
		Beyond-UI-UICustomLayoutElement-_CheckElementKeyIsValid0 = 35,
		Beyond-UI-UIDialogText-get_useAspectRatio0 = 35,
		Beyond-UI-UIDialogText-get_notUseAspectRatio0 = 35,
		Beyond-UI-UIDialogText-get_playing0 = 35,
		Beyond-UI-UIDragItem-get_inDragging0 = 35,
		Beyond-UI-UIDropdown-get_groupEnabled0 = 35,
		Beyond-UI-UIDropdown-get_bindingEnabled0 = 35,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.get_interactable0 = 35,
		Beyond-UI-UIState-StateDescription-get_IsEmpty0 = 35,
		Beyond-UI-UIFoldoutComponent-get_defaultFoldOut0 = 35,
		Beyond-UI-UIGroupScrollList-get_isMultiPage0 = 35,
		Beyond-UI-UIImage-get_packIntoRuntimeAtlas0 = 35,
		Beyond-UI-UIInertiaViewPager-get_isUpdating0 = 35,
		Beyond-UI-UIScrollRect-get_dragging0 = 35,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-get_isDragging0 = 35,
		Beyond-UI-UIInputField-get_isControllerInputValid0 = 35,
		Beyond-UI-UIInputField-TryActivateInputFieldCustom0 = 35,
		Beyond-UI-UIJoystick-get_isDynamic0 = 35,
		Beyond-UI-UIJoystick-get_active0 = 35,
		Beyond-UI-UIJoystick-get_groupEnabled0 = 35,
		Beyond-UI-UIJoystick-get_shouldCheckInput0 = 35,
		Beyond-UI-UIMultiSelectDropdown-get_groupEnabled0 = 35,
		Beyond-UI-UIMultiSelectDropdown-get_bindingEnabled0 = 35,
		Beyond-UI-UIMultiSelectDropdown-Beyond.Input.IBindingView.get_interactable0 = 35,
		Beyond-UI-UIScrollRect-get_inScrollTween0 = 35,
		Beyond-UI-UIScrollCircle-IsActive0 = 35,
		Beyond-UI-UIScrollCircle-IsDestroyed0 = 35,
		Beyond-UI-UIScrollList-get_autoLayoutWhenFew0 = 35,
		Beyond-UI-UIScrollList-get_enableSelectedNavigation0 = 35,
		Beyond-UI-UISemiCircleScrollList-get_controllerStickScrollEnabled0 = 35,
		Beyond-UI-UISlider-get_groupEnabled0 = 35,
		Beyond-UI-UISlider-get_bindingEnabled0 = 35,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.get_interactable0 = 35,
		Beyond-UI-UISoftMask-_RecalcParams0 = 35,
		Beyond-UI-UIToggle-_OnToggleFail0 = 35,
		Beyond-UI-UITouchPanel-get_isDragging0 = 35,
		Beyond-UI-UITouchPanel-get_isInGestureZoom0 = 35,
		Beyond-UI-UITouchPanel-get_groupEnabled0 = 35,
		Beyond-UI-UISwitchTween-get_isTweening0 = 35,
		Beyond-UI-UISwitchTween-get_isShow0 = 35,
		Beyond-UI-UISwitchTween-TweenWrapper-IsActive0 = 35,
		Beyond-UI-UISwitchTween-TweenWrapper-IsPlaying0 = 35,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-IsPlaying0 = 35,
		Beyond-UI-UIState-UIStateControllerLogicalGroup-LogicalGroup-CheckIsValid0 = 35,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-get_isInitialized0 = 35,
		Beyond-UI-GPUI-GPUIExtendedSystem-_CanSubmitInstanceRange0 = 35,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_autoCreate0 = 35,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-IsHandleValid0 = 35,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_hasInstance0 = 35,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-TrySyncTransform1 = 35,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-TryCreateInstance0 = 35,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_TryResolveTargetSystem0 = 35,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-TryDestroyInstance0 = 35,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_TryResolveSyncManager0 = 35,
		Beyond-UI-I18nFontLoader-IsInvalid0 = 36,
		Beyond-UI-UIConst-IsPadDevice0 = 36,
		Beyond-UI-UIAtlasManager-get_enableRuntimeAtlas0 = 36,
		Beyond-UI-UIAtlasManager-get_releaseImageSpriteAfterInsert0 = 36,
		Beyond-UI-GPUI-GPUILayoutInfo-get_IsLegacyLayoutAligned0 = 36,
		Beyond-UI-GPUI-GPUILayoutInfo-get_IsExtendedLayoutAligned0 = 36,
		Beyond-UI-I18nFontLoader-get_fontSearchData0 = 37,
		Beyond-UI-I18nFontLoader-_GetFontById0 = 38,
		Beyond-UI-I18nFontLoader-GetI18nFont0 = 38,
		Beyond-UI-I18nFontLoader-GetCNFont0 = 38,
		Beyond-UI-UIText-GetFontAsset0 = 39,
		Beyond-UI-UIText-get_m_fontAsset0 = 39,
		Beyond-UI-GPUI-GPUIExtendedSystem-GetFontAsset0 = 39,
		Beyond-UI-GPUI-GPUIExtendedSystem-get_fontAsset0 = 39,
		Beyond-UI-GPUI-GPUISystem-GetFontAsset0 = 39,
		Beyond-UI-GPUI-GPUISystem-get_fontAsset0 = 39,
		Beyond-UI-UIText-HyperlinkUITextManager-AddWrap0 = 40,
		Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapGroup0 = 40,
		Beyond-UI-UIText-HyperlinkUITextManager-ChangeWrapOrder0 = 41,
		Beyond-UI-UIText-SetHyperlinkUITextGroup0 = 41,
		Beyond-UI-UIScrollList-MoveCellTo0 = 41,
		Beyond-UI-UIScrollList-OnUpdateCell0 = 41,
		Beyond-UI-UILoopScrollView-OnUpdateCell0 = 41,
		Beyond-UI-UI3DScrollList-MoveCellTo0 = 41,
		Beyond-UI-UIGroupScrollList-_MoveTitleTo0 = 41,
		Beyond-UI-UIGroupScrollList-MoveCellTo0 = 41,
		Beyond-UI-UIGroupScrollList-_MoveGroupBGTo0 = 41,
		Beyond-UI-UINonUnifiedScrollList-MoveCellTo0 = 41,
		Beyond-UI-UINonUnifiedScrollList-OnUpdateCell0 = 41,
		Beyond-UI-UISemiCircleScrollListPair-_OnCellShow0 = 41,
		Beyond-UI-UIText-TryGetLinkId1 = 42,
		Beyond-UI-UIText-TryGetCharacterStartPosAndHeight0 = 43,
		Beyond-UI-UIText-TryGetCharacterEndPosAndHeight0 = 43,
		Beyond-UI-UIText-CombineStringWithLanguageSpilt0 = 44,
		Beyond-UI-UIText-CombineStringReverseForIndonesianAndVietnamese0 = 44,
		Beyond-UI-NotchAdapter-_TryAddToSideUI0 = 44,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-DetachView0 = 44,
		Beyond-UI-UIBlendImage-SetTexture0 = 44,
		Beyond-UI-UICanvasScaleHelper-AddCanvas0 = 44,
		Beyond-UI-UICanvasScaleHelper-RemoveCanvas0 = 44,
		Beyond-UI-UIColorGroup-AttachGraphicsWithGroup0 = 44,
		Beyond-UI-UIImage-LoadSprite0 = 44,
		Beyond-UI-UIImagePair-LoadSprite1 = 44,
		Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRects0 = 44,
		Beyond-UI-UICharHeadGlowAnimationNode-SetMaterials0 = 44,
		Beyond-UI-UIState-UIStateControllerLogicalGroup-SetState0 = 44,
		Beyond-UI-GPUI-RuntimeInstance-Create0 = 44,
		Beyond-UI-UIText-HyperlinkUITextManager-GetGroupDisplayableUIText0 = 45,
		Beyond-UI-UIText-GetGroupDisplayableHyperlinkUIText0 = 46,
		Beyond-UI-UIText-AddSubTextObject0 = 47,
		Beyond-UI-UIText-LocalStringCombineFormat0 = 48,
		Beyond-UI-UIUtils-GetSharedIntString0 = 48,
		Beyond-UI-UIUtils-GetSharedIntStringRoman0 = 48,
		Beyond-UI-UIText-CalculatePreferredValues0 = 49,
		Beyond-UI-UIConst-get_STANDARD_HORIZONTAL_RESOLUTION_INT0 = 50,
		Beyond-UI-UIConst-get_STANDARD_VERTICAL_RESOLUTION_INT0 = 50,
		Beyond-UI-UIConst-get_dragThreshold0 = 50,
		Beyond-UI-FullScreenSceneBlurMarker-_GetNextId0 = 50,
		Beyond-UI-UISoftMask-_GetLayoutEpoch0 = 50,
		Beyond-UI-GPUI-GPUILayoutInfo-get_LegacyPrefabStride0 = 50,
		Beyond-UI-GPUI-GPUILayoutInfo-get_LegacyPrefabLiteStride0 = 50,
		Beyond-UI-GPUI-GPUILayoutInfo-get_LegacyInstanceStride0 = 50,
		Beyond-UI-GPUI-GPUILayoutInfo-get_ExtendedPrefabStride0 = 50,
		Beyond-UI-GPUI-GPUILayoutInfo-get_ExtendedPrefabLiteStride0 = 50,
		Beyond-UI-GPUI-GPUILayoutInfo-get_ExtendedInstanceStride0 = 50,
		Beyond-UI-UIConst-GetResolutionScale0 = 51,
		Beyond-UI-UIConst-get_CUR_STANDARD_HORIZONTAL_RESOLUTION0 = 51,
		Beyond-UI-UIConst-get_CUR_STANDARD_VERTICAL_RESOLUTION0 = 51,
		Beyond-UI-UIModelLoader-LoadModel0 = 52,
		Beyond-UI-UIModelLoader-LoadModelAsync0 = 53,
		Beyond-UI-UIModelLoader-Cancel0 = 54,
		Beyond-UI-UILoopScrollRect-_UpdateSelection0 = 54,
		Beyond-UI-UILoopScrollRect-JumpTo0 = 54,
		Beyond-UI-UILoopScrollRect-_RefreshScrollToggleCount0 = 54,
		Beyond-UI-UILoopScrollRect-SetTotalCount0 = 54,
		Beyond-UI-UILoopScrollView-_OnScrollEnd0 = 54,
		Beyond-UI-UILoopScrollView-OnScrollEnd0 = 54,
		Beyond-UI-UILoopScrollView-UpdateCount0 = 54,
		Beyond-UI-UIRecycleLayoutGroup-_UpdateViews0 = 54,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_NotifyLayoutChanged0 = 54,
		Beyond-UI-ToastList-_StartBatch0 = 54,
		Beyond-UI-UIBigRectHelper-ChangePaddingRight0 = 54,
		Beyond-UI-UIBlurMono-UpdateSortingOrder0 = 54,
		Beyond-UI-UICustomLayout-Save0 = 54,
		Beyond-UI-UIDialogText-OnVisibleCharactersChanged0 = 54,
		Beyond-UI-UIDialogTextWithCursor-OnVisibleCharactersChanged0 = 54,
		Beyond-UI-UIFoldoutComponent-Refresh0 = 54,
		Beyond-UI-UIGroupScrollList-_EnsureGroupTitleSizeCacheCount0 = 54,
		Beyond-UI-UIGroupScrollList-_RefreshGroupTitleSizeWithoutEnsure0 = 54,
		Beyond-UI-UIGroupScrollList-_RefreshGroupTitleSize0 = 54,
		Beyond-UI-UIScrollList-set_curSelectedIndex0 = 54,
		Beyond-UI-UIGroupScrollList-UpdateCount0 = 54,
		Beyond-UI-UIGroupScrollList-UpdateGroup2 = 54,
		Beyond-UI-UIGroupScrollList-NotifyGroupTitleSizeChange0 = 54,
		Beyond-UI-UIGroupScrollList-_UpdateShowingCellsForGroup0 = 54,
		Beyond-UI-UIImage-set_atlasHandleId0 = 54,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-Reset0 = 54,
		Beyond-UI-UIInertiaViewPager-set_currentPage0 = 54,
		Beyond-UI-UIInertiaViewPager-MoveToPage0 = 54,
		Beyond-UI-UIInputField-_UpdateKeyboardOffset0 = 54,
		Beyond-UI-UIMultiSelectDropdown-ScrollToIndex0 = 54,
		Beyond-UI-UIMultiSelectDropdown-_ResizeSelectedStates0 = 54,
		Beyond-UI-UIMultiSelectDropdown-Refresh1 = 54,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount0 = 54,
		Beyond-UI-UIScrollList-UpdateCount2 = 54,
		Beyond-UI-UIScrollList-CacheShowingCell0 = 54,
		Beyond-UI-UIScrollRectEdgeRedDot-_OnScrollListUpdateCount0 = 54,
		Beyond-UI-UISemiCircleScrollListPair-_OnClosestCellChanged0 = 54,
		Beyond-UI-UISequenceImage-SetSprite0 = 54,
		Beyond-UI-UISortingOrder-SetOrder0 = 54,
		Beyond-UI-UITouchPanel-DeActiveTouch0 = 54,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateUpPos0 = 54,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateDownPos0 = 54,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateMidPos0 = 54,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_ClearSpriteOverride0 = 54,
		Beyond-UI-UIUtils-IsScreenPosInRectTransform0 = 55,
		Beyond-UI-UIUtils-IsScreenPosInRectTransform1 = 56,
		Beyond-UI-UIUtils-CalcBoundOfRectTransform0 = 57,
		Beyond-UI-UIUtils-TryGetTouch0 = 58,
		Beyond-UI-UIUtils-SetColorWithoutAlpha0 = 59,
		Beyond-UI-UIBigLogo-SetBigLogoMask0 = 59,
		Beyond-UI-UIColorGroup-set_color0 = 59,
		Beyond-UI-UIImage-set_color0 = 59,
		Beyond-UI-UIImagePair-set_color0 = 59,
		Beyond-UI-UITextPair-set_color0 = 59,
		Beyond-UI-UIUtils-RectTransformToScreenRect0 = 60,
		Beyond-UI-UIUtils-ClampPointInRectTransform0 = 61,
		Beyond-UI-UIUtils-GetNodeScaleOffset0 = 62,
		Beyond-UI-UIUtils-GetColorByString0 = 63,
		Beyond-UI-UIColorGroup-get_color0 = 63,
		Beyond-UI-UIImage-get_color0 = 63,
		Beyond-UI-UIUtils-GetCursorTipOffsetInScreen0 = 64,
		Beyond-UI-UIUtils-GetCursorTipOffsetX0 = 64,
		Beyond-UI-UIUtils-TryGetTextWithoutRichStyle0 = 65,
		Beyond-UI-CinemachineGyroscopeEffect-PostPipelineStageCallback0 = 66,
		Beyond-UI-UIScrollList-GetRealIndex0 = 67,
		Beyond-UI-UIGroupScrollList-_GetGroupStartCellIndex0 = 67,
		Beyond-UI-UIGroupScrollList-AppendCellToGroup0 = 67,
		Beyond-UI-UIScrollCircle-_GetRealIndex0 = 67,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_FindFirstAnimationIndex0 = 67,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_FindDefaultSubrootAnimationIndex0 = 67,
		Beyond-UI-CommonItemToastList-_GetUnConstraintTargetPos0 = 68,
		Beyond-UI-UINonUnifiedScrollList-GetGridLayoutSize0 = 68,
		Beyond-UI-CommonItemToastList-AdjustContainerPos0 = 69,
		Beyond-UI-UILoopScrollView-ScrollToIndex0 = 69,
		Beyond-UI-UIRecycleMultiHolder-UpdateCount1 = 69,
		Beyond-UI-UIRecycleSingleHolder-UpdateCount1 = 69,
		Beyond-UI-UIActionKeyHint-SetBindingId0 = 69,
		Beyond-UI-UIGroupScrollList-SetCellCanCache1 = 69,
		Beyond-UI-UIInertiaViewPager-_SwitchToPage0 = 69,
		Beyond-UI-UINonUnifiedScrollList-Toggle0 = 69,
		Beyond-UI-UIScrollCircle-ScrollToIndex0 = 69,
		Beyond-UI-UIScrollCircle-UpdateCount0 = 69,
		Beyond-UI-UIScrollList-SetCellCanCache0 = 69,
		Beyond-UI-UIToggle-_TryRefreshBindingText0 = 69,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetNodeVisibility0 = 69,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetSubrootVisibility0 = 69,
		Beyond-UI-GPUI-RuntimeInstance-SetVisibility0 = 69,
		Beyond-UI-UIScrollList-GetIndexRangeFromScrollOffset0 = 70,
		Beyond-UI-UIGroupScrollList-_GetGroupRangeFromScrollOffset0 = 70,
		Beyond-UI-UIGroupScrollList-GetIndexRangeFromScrollOffset0 = 70,
		Beyond-UI-UIScrollList-GetShowRange0 = 71,
		Beyond-UI-UINonUnifiedScrollList-GetShowRange0 = 71,
		Beyond-UI-UIScrollList-GetNotCacheRange0 = 72,
		Beyond-UI-UIScrollList-GetRangeInView0 = 72,
		Beyond-UI-UINonUnifiedScrollList-GetNotCacheRange0 = 72,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_GetSpriteContentSize0 = 72,
		Beyond-UI-UIScrollList-CacheOutOfRangeCells0 = 73,
		Beyond-UI-UIGroupScrollList-CacheOutOfRangeCells0 = 73,
		Beyond-UI-UIScrollList-GetCell0 = 74,
		Beyond-UI-UIGroupScrollList-_GetTitleCell0 = 74,
		Beyond-UI-UIGroupScrollList-_GetGroupBGCell0 = 74,
		Beyond-UI-LuaPanel-_TryCallAnimationInFinished0 = 75,
		Beyond-UI-UIAnimationWrapper-ClearTween0 = 75,
		Beyond-UI-UIAnimationWrapper-_OnInEasingAnimationFinished0 = 75,
		Beyond-UI-UIAnimationWrapper-_OnInAnimationFinished0 = 75,
		Beyond-UI-ControllerSideMenuItemList-ToggleItemForceValid0 = 75,
		Beyond-UI-CustomUIStyle-ToggleActiveState0 = 75,
		Beyond-UI-UILoopScrollView-Cell-SetVisible0 = 75,
		Beyond-UI-UILoopScrollView-_ScrollToNext0 = 75,
		Beyond-UI-LuaPanel-set_IsWorldUI0 = 75,
		Beyond-UI-UISelectableNaviGroup-NaviToThisGroup0 = 75,
		Beyond-UI-NotchAdapter-_UpdateMargeSizeFromNotchInfo0 = 75,
		Beyond-UI-NotchAdapter-FindAllSideUI0 = 75,
		Beyond-UI-UIActionKeyHint-SetContentState0 = 75,
		Beyond-UI-UIActionKeyHint-_CheckInteractable0 = 75,
		Beyond-UI-UIActionKeyHint-_SetInDynamicList0 = 75,
		Beyond-UI-UIAnimationSwitchTween-_SetGameObjectActive0 = 75,
		Beyond-UI-UIAnimationSwitchTween-ResetToState0 = 75,
		Beyond-UI-UIArea-_SetHighlightNodeActive0 = 75,
		Beyond-UI-UIAutoCloseArea-set_includeInAutoCloseLayer0 = 75,
		Beyond-UI-UIAutoCloseArea-ChangeEnableCloseActionOnController0 = 75,
		Beyond-UI-UIAutoCloseArea-OpenSelf0 = 75,
		Beyond-UI-UIBigLogo-ClearBigLogo0 = 75,
		Beyond-UI-UIButton-_PlayClickAnimation0 = 75,
		Beyond-UI-UIButton-_NotifyIsHover0 = 75,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyDown0 = 75,
		Beyond-UI-UIButton-Beyond.Input.IBindingView.OnInputKeyUp0 = 75,
		Beyond-UI-UIButton-_RefreshHoverEnableNode0 = 75,
		Beyond-UI-UIButton-_ToggleNaviInputBinding0 = 75,
		Beyond-UI-UICustomLayoutHandle-_SetChanged0 = 75,
		Beyond-UI-UICustomLayout-ResetToDefault0 = 75,
		Beyond-UI-UISelectableNaviGroup-_OnFocus0 = 75,
		Beyond-UI-UISelectableNaviGroup-ManuallyFocus0 = 75,
		Beyond-UI-UISelectableNaviGroup-ManuallyStopFocus0 = 75,
		Beyond-UI-UIDropdown-ToggleOptions0 = 75,
		Beyond-UI-UIDropdown-_NotifyIsHover0 = 75,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyDown0 = 75,
		Beyond-UI-UIDropdown-Beyond.Input.IBindingView.OnInputKeyUp0 = 75,
		Beyond-UI-UIFoldoutComponent-OnFoldOut0 = 75,
		Beyond-UI-UIFoldoutComponent-OnFoldIn0 = 75,
		Beyond-UI-UIGridLayoutNaviWrapper-_SetCircleWrapScroll0 = 75,
		Beyond-UI-UIImage-set_packIntoRuntimeAtlas0 = 75,
		Beyond-UI-UIInputField-DeactivateInputField0 = 75,
		Beyond-UI-UIInputField-_NotifyIsHover0 = 75,
		Beyond-UI-UIJoystick-_SetVisible0 = 75,
		Beyond-UI-UIJoystick-_SetRectTransform0 = 75,
		Beyond-UI-UIJoystick-set_isDynamic0 = 75,
		Beyond-UI-UILeftSubtitle-SetVisible0 = 75,
		Beyond-UI-UIMultiSelectDropdown-ToggleOptions0 = 75,
		Beyond-UI-UIMultiSelectDropdown-_NotifyIsHover0 = 75,
		Beyond-UI-UIMultiSelectDropdown-ClearSelected0 = 75,
		Beyond-UI-UIMultiSelectDropdown-Beyond.Input.IBindingView.OnInputKeyDown0 = 75,
		Beyond-UI-UIMultiSelectDropdown-Beyond.Input.IBindingView.OnInputKeyUp0 = 75,
		Beyond-UI-UINonUnifiedScrollList-FoldAll0 = 75,
		Beyond-UI-UIScrollCircle-_UpdateCenterIndex0 = 75,
		Beyond-UI-UIScrollCircle-Cell-SetSelect0 = 75,
		Beyond-UI-UIScrollList-Init0 = 75,
		Beyond-UI-UIScrollList-SetTop0 = 75,
		Beyond-UI-UIScrollText-_ApplyTextAlignment0 = 75,
		Beyond-UI-UIScrollText-PositionScrollHandler-UpdateScrollStatus0 = 75,
		Beyond-UI-UIScrollText-MeshScrollHandler-UpdateScrollStatus0 = 75,
		Beyond-UI-UISequenceImage-Stop0 = 75,
		Beyond-UI-UISlider-_NotifyIsHover0 = 75,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyDown0 = 75,
		Beyond-UI-UISlider-Beyond.Input.IBindingView.OnInputKeyUp0 = 75,
		Beyond-UI-UISoftMaskable-_SyncRegistration0 = 75,
		Beyond-UI-UIStepScrollList-Init0 = 75,
		Beyond-UI-UIStepScrollList-SetTop0 = 75,
		Beyond-UI-UIToggle-_UpdateObjects0 = 75,
		Beyond-UI-UIToggle-_PlayAnimation0 = 75,
		Beyond-UI-UIToggle-_NotifyIsHover0 = 75,
		Beyond-UI-UIToggle-_ToggleNaviInputBinding0 = 75,
		Beyond-UI-UIToggleGroup-_MoveTo0 = 75,
		Beyond-UI-UISwitchTween-ResetToState0 = 75,
		Beyond-UI-UISwitchTween-_ClearTweenInternal0 = 75,
		Beyond-UI-UISwitchTween-set_isShow0 = 75,
		Beyond-UI-UISwitchTween-Reset0 = 75,
		Beyond-UI-FadeSwitchTween-ResetToState0 = 75,
		Beyond-UI-FadeTranslationSwitchTween-ResetToState0 = 75,
		Beyond-UI-UICharHeadGlowAnimation-SetForShare0 = 75,
		Beyond-UI-UIState-UIStateControllerLogicalGroup-_RebuildRuntimeBindings0 = 75,
		Beyond-UI-GPUI-GPUISharedGraphicBase-UpdateWorldMat0 = 75,
		Beyond-UI-GPUI-GPUIExtendedSystem-_EnsureInstanceBufferManager0 = 75,
		Beyond-UI-UIAnimationTween-get_handler0 = 76,
		Beyond-UI-UIAnimationWrapper-get_curTween0 = 77,
		Beyond-UI-UIAnimationWrapper-GetClip0 = 78,
		Beyond-UI-UIAnimationWrapper-_SampleClipAtLength0 = 79,
		Beyond-UI-UILoopScrollView-Cell-UpdatePosition0 = 79,
		Beyond-UI-UIRecycleMultiHolder-AddView0 = 79,
		Beyond-UI-UIRecycleSingleHolder-AddView0 = 79,
		Beyond-UI-UIAnimationLayerMixPlayer-LockToClip0 = 79,
		Beyond-UI-UIAnimationMixPlayer-LockToClip0 = 79,
		Beyond-UI-UIAnimationWrapper-SampleClip0 = 80,
		Beyond-UI-UIAnimationWrapper-SampleClipAtPercent0 = 80,
		Beyond-UI-UIAnimationWrapper-PlayWithTween0 = 81,
		Beyond-UI-UIAnimationWrapper-PlayWithTween1 = 81,
		Beyond-UI-UIAnimationWrapper-PlayLoopAnimation0 = 82,
		Beyond-UI-UILoopScrollView-_UpdatePosition0 = 82,
		Beyond-UI-UIBigLogo-SetAlpha0 = 82,
		Beyond-UI-UIBigRectHelper-_SetZoomValueAndScale0 = 82,
		Beyond-UI-UIBigRectHelper-_OnZoom0 = 82,
		Beyond-UI-UIBigRectHelper-ManuallyZoom0 = 82,
		Beyond-UI-UIBigRectHelper-SyncZoomValue0 = 82,
		Beyond-UI-UIScrollList-_ScrollToPos0 = 82,
		Beyond-UI-UIScrollCircle-_DoScroll0 = 82,
		Beyond-UI-UISubtitle-UpdateAlpha0 = 82,
		Beyond-UI-UIAnimationWrapper-get_animationIn0 = 83,
		Beyond-UI-UIAnimationWrapper-get_animationInEasing0 = 83,
		Beyond-UI-UIAnimationWrapper-get_animationLoop0 = 83,
		Beyond-UI-UIAnimationWrapper-get_animationOut0 = 83,
		Beyond-UI-UIAnimationWrapper-PlayInAnimation0 = 84,
		Beyond-UI-UIScrollList-UpdateCell0 = 85,
		Beyond-UI-UIScrollList-ProcessCellAtIndex0 = 85,
		Beyond-UI-UIGroupScrollList-ProcessCellAtIndex0 = 85,
		Beyond-UI-UINonUnifiedScrollList-ToggleByState0 = 85,
		Beyond-UI-UIScrollList-RepositionOutOfRangeCells0 = 86,
		Beyond-UI-UIGroupScrollList-RepositionOutOfRangeCells0 = 86,
		Beyond-UI-UIScrollRectEdgeRedDot-_UpdateCacheDictForRangeChange0 = 86,
		Beyond-UI-UIScrollList-UpdateShowingCells0 = 87,
		Beyond-UI-UIGroupScrollList-UpdateShowingCells0 = 87,
		Beyond-UI-UIStepScrollList-UpdateShowingCells0 = 87,
		Beyond-UI-UIScrollList-get_moveTips0 = 88,
		Beyond-UI-UIScrollRect-get_naviGroup0 = 89,
		Beyond-UI-UIScrollRect-GetCellClipAmount0 = 90,
		Beyond-UI-UIAnimationWrapper-GetClipLength0 = 90,
		Beyond-UI-UIState-StateDescription-ApplyAnimation0 = 90,
		Beyond-UI-UIState-UIStateController-_ApplyState0 = 90,
		Beyond-UI-UIScrollList-TryGetSelectableFromCell0 = 91,
		Beyond-UI-UIScrollList-OnScroll0 = 92,
		Beyond-UI-NotchAdapter-ApplyNotch0 = 92,
		Beyond-UI-UIBigRectHelper-_OnDrag0 = 92,
		Beyond-UI-UICustomLayoutElement-set_position0 = 92,
		Beyond-UI-UICustomLayoutHandle-set_position0 = 92,
		Beyond-UI-UIScrollList-SetSpace0 = 92,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollBegin0 = 92,
		Beyond-UI-UIInertiaViewPager-CustomScrollHandler-_OnScrollEnd0 = 92,
		Beyond-UI-UINonUnifiedScrollList-OnScroll0 = 92,
		Beyond-UI-UIScrollRect-set_contentStartPosition0 = 92,
		Beyond-UI-UINonUnifiedScrollRect-UpdateScrollbars0 = 92,
		Beyond-UI-UIScrollRect-_CheckOverScrollEffect0 = 92,
		Beyond-UI-UIScrollRect-_CustomSetPosOnScroll0 = 92,
		Beyond-UI-UIScrollRect-_CheckOverScrollOnEndDrag0 = 92,
		Beyond-UI-UIStepScrollList-_OnScrollEnd0 = 92,
		Beyond-UI-UIStepScrollList-_OnScrollStart0 = 92,
		Beyond-UI-UIStepScrollList-OnScroll0 = 92,
		Beyond-UI-UITouchPanel-DoEndDrag0 = 92,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetRootScale0 = 92,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-SetRootScaleMultiplier0 = 92,
		Beyond-UI-GPUI-RuntimeInstance-SetRootScale0 = 92,
		Beyond-UI-CommonItemToastList-ScrollToIndex0 = 93,
		Beyond-UI-UIScrollList-ScrollToIndex0 = 93,
		Beyond-UI-UIGroupScrollList-ScrollToGroup0 = 93,
		Beyond-UI-UIGroupScrollList-ScrollToIndex1 = 93,
		Beyond-UI-UIButton-get_label0 = 94,
		Beyond-UI-UIDialogText-get_uiText0 = 94,
		Beyond-UI-UIDialogTimelineText-get_actorName0 = 94,
		Beyond-UI-UISoftMaskable-get_uiText0 = 94,
		Beyond-UI-UITextPair-get_first0 = 94,
		Beyond-UI-ControllerSideMenuItemList-MeunItemInfo-GetSprite0 = 95,
		Beyond-UI-CustomUIStyle-get_inputValidTypeMask0 = 96,
		Beyond-UI-CustomUIStyle-set_inputValidTypeMask0 = 97,
		Beyond-UI-CustomUIStyle-get_overrideValidState0 = 98,
		Beyond-UI-CustomUIStyle-IsShowTypeValid0 = 99,
		Beyond-UI-CustomUIStyle-set_overrideValidState0 = 100,
		Beyond-UI-CustomUIStyle-IsValidInput0 = 101,
		Beyond-UI-FitAspectRatioByFOV-OnScreenSizeChanged0 = 102,
		Beyond-UI-UIRecycleMultiHolder-UpdateCount0 = 102,
		Beyond-UI-UIRecycleSingleHolder-UpdateCount0 = 102,
		Beyond-UI-ToastList-AddToast0 = 102,
		Beyond-UI-UICanvasScaleHelper-OnScreenSizeChanged0 = 102,
		Beyond-UI-UISemiCircleScrollList-RefreshLayout0 = 102,
		Beyond-UI-UISemiCircleScrollListPair-RefreshLayout0 = 102,
		Beyond-UI-InputBindingGroupNaviDecorator-_OnSetAsNaviTarget0 = 103,
		Beyond-UI-UIBlurRT-SetUseSceneColorPS0 = 103,
		Beyond-UI-UIButton-_OnSetAsNaviTarget0 = 103,
		Beyond-UI-UIDropdown-_ToggleOptions0 = 103,
		Beyond-UI-UISelectableNaviGroup-_OnStopFocus0 = 103,
		Beyond-UI-UIDropItem-ToggleHighlight0 = 103,
		Beyond-UI-UIJoystick-_ChangeDynamic0 = 103,
		Beyond-UI-UIJoystick-_SetWalkBgVisible0 = 103,
		Beyond-UI-UIJoystick-_SetRunBgVisible0 = 103,
		Beyond-UI-UIMultiSelectDropdown-_ToggleOptions0 = 103,
		Beyond-UI-UISoftMask-_UpdateChildren0 = 103,
		Beyond-UI-UIStepScrollList-_TryAutoScroll0 = 103,
		Beyond-UI-UIToggle-_OnSetAsNaviTarget0 = 103,
		Beyond-UI-UIState-UIStateControllerLogicalGroup-LogicalGroup-Apply0 = 103,
		Beyond-UI-UILoopScrollRect-get_scrollDirection0 = 104,
		Beyond-UI-UILoopScrollRect-_CircularPosition0 = 105,
		Beyond-UI-UILoopScrollRect-_CalculateMovementAmount0 = 106,
		Beyond-UI-UILoopScrollRect-_RubberDelta0 = 106,
		Beyond-UI-UILoopScrollRect-_ScrollTo0 = 107,
		Beyond-UI-UILoopScrollRect-_ScrollToMultiLoop0 = 107,
		Beyond-UI-UILoopScrollRect-ScrollTo0 = 108,
		Beyond-UI-UILoopScrollRect-ScrollToMultiLoop0 = 108,
		Beyond-UI-UILoopScrollRect-GetMovementDirection0 = 109,
		Beyond-UI-UILoopScrollRect-_CalculateOffset0 = 110,
		Beyond-UI-UIInertiaViewPager-_ScrollValue2PageIndex0 = 110,
		Beyond-UI-UIInertiaViewPager-_PageIndex2ScrollValue0 = 110,
		Beyond-UI-UILeftSubtitle-UpdateByPlayTime0 = 110,
		Beyond-UI-UISlider-ClampValue0 = 110,
		Beyond-UI-UISlider-CustomProcessNormalizedValue0 = 110,
		Beyond-UI-UILoopScrollView-_GetNeedCount0 = 111,
		Beyond-UI-UIInertiaViewPager-_ScrollValueAlignToPage0 = 111,
		Beyond-UI-UILoopScrollView-_CircularIndex0 = 112,
		Beyond-UI-UIGroupScrollList-_GetRowForCell0 = 112,
		Beyond-UI-UIGroupScrollList-_GetCellIndexForGroupCell0 = 112,
		Beyond-UI-UIScrollList-GetIndexOf0 = 112,
		Beyond-UI-UILoopScrollView-_UpdateCellsAnimationPosition0 = 113,
		Beyond-UI-UILoopScrollView-_UpdateCells0 = 113,
		Beyond-UI-UISelectableNaviGroup-_FindDefaultSelectable0 = 114,
		Beyond-UI-UIDropdown-_GetDefaultNaviTarget0 = 114,
		Beyond-UI-UIMultiSelectDropdown-_GetDefaultNaviTarget0 = 114,
		Beyond-UI-UISelectableNaviGroup-get_lastFocusNaviTarget0 = 114,
		Beyond-UI-NonDrawingGraphic-_IsRaycastLocationValidCircle0 = 115,
		Beyond-UI-NonDrawingGraphic-IsRaycastLocationValid0 = 115,
		Beyond-UI-UIRecycleLayoutAdapter-GenerateViewsForRebuild0 = 116,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetViews0 = 116,
		Beyond-UI-UIRecycleLayoutGroup-EmptyAdapter-GenerateViewsForRebuild0 = 116,
		Beyond-UI-UIRecycleLayoutGroup-get_adapter0 = 117,
		Beyond-UI-UIRecycleLayoutGroup-get_viewMgr0 = 118,
		Beyond-UI-UIRecycleLayoutGroup-get_padding0 = 119,
		Beyond-UI-UIRecycleLayoutGroup-get_content0 = 120,
		Beyond-UI-UIButton-get_redDotTrans0 = 120,
		Beyond-UI-UICustomLayout-get_dragArea0 = 120,
		Beyond-UI-UICustomLayoutElement-get_highlightRect0 = 120,
		Beyond-UI-UIDragItem-get_dragObjectParent0 = 120,
		Beyond-UI-UIDragItem-get_m_dragParentRect0 = 120,
		Beyond-UI-UIDropdown-get_redDotTrans0 = 120,
		Beyond-UI-UIMultiSelectDropdown-get_redDotTrans0 = 120,
		Beyond-UI-UISizeFollower-get_rectTransform0 = 120,
		Beyond-UI-UIScrollCircle-get_viewRect0 = 120,
		Beyond-UI-UISlider-get_redDotTrans0 = 120,
		Beyond-UI-UIRecycleLayoutGroup-_ApplyLayoutMeta0 = 121,
		Beyond-UI-UIRecycleLayoutGroup-_GetVisibleRange0 = 122,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsFromMeta0 = 123,
		Beyond-UI-UIRecycleLayoutGroup-SetAdapter0 = 124,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-_EnsureViewPool0 = 125,
		Beyond-UI-UIRecycleLayoutGroup-ViewPool-Alloc0 = 126,
		Beyond-UI-UIRecycleLayoutGroup-_InsertView0 = 127,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-InsertView0 = 127,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetView0 = 128,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementPosByIndex0 = 129,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementPosByIndex0 = 129,
		Beyond-UI-UIGroupScrollList-_CalcGroupTitleSize0 = 129,
		Beyond-UI-UIGroupScrollList-_GetGroupTitleSize0 = 129,
		Beyond-UI-UIGroupScrollList-_GetRowHeight0 = 129,
		Beyond-UI-UIGroupScrollList-_GetCumulativeSizeBeforeRow0 = 129,
		Beyond-UI-UIGroupScrollList-_GetGroupLength0 = 129,
		Beyond-UI-UIMaterialAnimation-_GetSlotFloat0 = 129,
		Beyond-UI-UINonUnifiedScrollList-_GetCellSize0 = 129,
		Beyond-UI-UINonUnifiedScrollList-_GetCellsSizeTo0 = 129,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementBoundsByIndex0 = 130,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementBoundsByIndex0 = 130,
		Beyond-UI-UIRecycleLayoutGroup-_GetElementIndex0 = 131,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetElementIndex0 = 131,
		Beyond-UI-GPUI-GPUIExtendedSystem-_FindAnchorNodeIndex0 = 131,
		Beyond-UI-UIRecycleLayoutGroup-ViewMgr-GetDirection0 = 132,
		Beyond-UI-UIRecycleMultiHolder-GetVirtualView0 = 133,
		Beyond-UI-UIRecycleMultiHolder-InsertView0 = 134,
		Beyond-UI-UIRecycleSingleHolder-InsertView0 = 134,
		Beyond-UI-UIRecycleSingleHolder-GetVirtualView0 = 135,
		Beyond-UI-ToastList-_GetCell0 = 136,
		Beyond-UI-ToastList-_ShowCell0 = 137,
		Beyond-UI-UIActionKeyHint-_ResolveActionIconPath0 = 138,
		Beyond-UI-UIActionKeyHint-_SetKeyCodeSprite0 = 139,
		Beyond-UI-UIActionKeyHint-GetAndSetActionIcon0 = 140,
		Beyond-UI-UIActionKeyHint-get_target0 = 141,
		Beyond-UI-UIActionKeyHint-GetActionInfo0 = 142,
		Beyond-UI-UIActionKeyHint-_ResolveActionModifyIconPath0 = 143,
		Beyond-UI-UIActionKeyHint-_BuildSnapshot0 = 144,
		Beyond-UI-UIActionKeyHint-_ApplyMainIcon0 = 145,
		Beyond-UI-UIActionKeyHint-_ApplySnapshot0 = 145,
		Beyond-UI-UIActionKeyHint-_ApplyModifyIcon0 = 146,
		Beyond-UI-UIActionKeyHint-_ApplyText0 = 146,
		Beyond-UI-UIActionKeyHint-_RefreshSecondaryEffects0 = 146,
		Beyond-UI-UIActionKeyHint-_GetVisibilityColor0 = 147,
		Beyond-UI-UIActionKeyHint-_WriteVisibilityToNode0 = 148,
		Beyond-UI-UIActionKeyHint-_ResolveStandaloneVisibility0 = 149,
		Beyond-UI-UIActionKeyHint-_ResolveViewVisibility0 = 150,
		Beyond-UI-UIActionKeyHint-_ResolveVisibility0 = 151,
		Beyond-UI-UIActionKeyHint-_OnControllerTypeChange0 = 152,
		Beyond-UI-UIControllerKeyIcon-_OnControllerTypeChange0 = 152,
		Beyond-UI-UIActionKeyHint-_OnInputActionKeyUpdated0 = 153,
		Beyond-UI-UIJoystick-_OnHudLayoutLoaded0 = 153,
		Beyond-UI-UIActionKeyHint-SetKeyHint0 = 154,
		Beyond-UI-UISelectableNaviGroup-_TryChangeNaviPartner0 = 154,
		Beyond-UI-UIActionKeyHint-SetBindingId1 = 155,
		Beyond-UI-UIActionKeyHint-GetAndSetActionModifyIcon0 = 156,
		Beyond-UI-UIAnimationHolder-_FindByString0 = 157,
		Beyond-UI-UIAnimationHolder-FindByName0 = 158,
		Beyond-UI-UIAnimationHolder-FindByNameOrAlias0 = 158,
		Beyond-UI-UIAnimationWrapper-SetOptions0 = 159,
		Beyond-UI-UIAnimationWrapper-Play0 = 160,
		Beyond-UI-UIAnimationWrapper-Play1 = 160,
		Beyond-UI-UIAnimationWrapper-FOptions-GetDefault0 = 161,
		Beyond-UI-UIAnimationTween-_SetValue0 = 162,
		Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfHide0 = 163,
		Beyond-UI-UIAnimationSwitchTween-GenerateTweenOfShow0 = 163,
		Beyond-UI-FadeSwitchTween-GenerateTweenOfHide0 = 163,
		Beyond-UI-FadeSwitchTween-GenerateTweenOfShow0 = 163,
		Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfHide0 = 163,
		Beyond-UI-FadeTranslationSwitchTween-GenerateTweenOfShow0 = 163,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-OnComplete0 = 164,
		Beyond-UI-UISwitchTween-TweenWrapper-OnComplete0 = 164,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-OnComplete0 = 164,
		Beyond-UI-UIAnimationSwitchTween-TweenHandler-SetAutoKill0 = 165,
		Beyond-UI-UISwitchTween-TweenWrapper-SetAutoKill0 = 165,
		Beyond-UI-FadeTranslationSwitchTween-TweenHandler-SetAutoKill0 = 165,
		Beyond-UI-UIAnimationSwitchTween-Builder-Build0 = 166,
		Beyond-UI-UIArea-_GetPointerScreenPosition0 = 167,
		Beyond-UI-UIAutoCloseArea-_GetUICamera0 = 168,
		Beyond-UI-UIDropdown-_GetUICamera0 = 168,
		Beyond-UI-UIScrollRect-_GetUICamera0 = 168,
		Beyond-UI-UIInputField-_GetCamera0 = 168,
		Beyond-UI-UIMultiSelectDropdown-_GetUICamera0 = 168,
		Beyond-UI-UIBigLogo-SetBigLogoEditor0 = 169,
		Beyond-UI-UIBigLogo-ShowBigLogo0 = 170,
		Beyond-UI-UIButton-_OnPress0 = 171,
		Beyond-UI-UIInputField-_KeyboardHeightChange0 = 171,
		Beyond-UI-UIBigRectHelper-get_OnOpenTweenFinished0 = 172,
		Beyond-UI-UIBigRectHelper-get_zoomEvent0 = 173,
		Beyond-UI-UIBigRectHelper-get_touchPanel0 = 174,
		Beyond-UI-UIBigRectHelper-_GetContainerRectBounds0 = 175,
		Beyond-UI-UIBigRectHelper-_GetAdjustedPosition0 = 176,
		Beyond-UI-UIBigRectHelper-_RefreshPivotPosition0 = 177,
		Beyond-UI-UIElementFollower-UpdatePosition0 = 177,
		Beyond-UI-UIElementFollower-set_followPosition0 = 177,
		Beyond-UI-UIScaleHolder-SetExtraScale0 = 177,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetRootPosition0 = 177,
		Beyond-UI-UIBigRectHelper-_SetScale0 = 178,
		Beyond-UI-UIBigRectHelper-_RefreshControllerFocusRaycastResults0 = 179,
		Beyond-UI-UIBigRectHelper-FocusNode0 = 180,
		Beyond-UI-UIBigRectHelper-FocusNode1 = 181,
		Beyond-UI-UIBigRectHelper-GetRecoverState0 = 182,
		Beyond-UI-UIBigRectHelper-GetZoomRange0 = 183,
		Beyond-UI-UIBlendImage-SetColor0 = 184,
		Beyond-UI-UIBlurMono-get_canvas0 = 185,
		Beyond-UI-UICharHeadGlowAnimationSource-get_canvas0 = 185,
		Beyond-UI-UIBlurMono-_GetCamera0 = 186,
		Beyond-UI-UIBlurRT-get_rawImage0 = 187,
		Beyond-UI-UIButton-get_curPressPos0 = 188,
		Beyond-UI-UICanvasScaleHelper-GetProperCanvasResolution0 = 188,
		Beyond-UI-UICustomLayoutElement-_GetMarginSize0 = 188,
		Beyond-UI-UICustomLayoutElement-get_position0 = 188,
		Beyond-UI-UICustomLayoutHandle-get_position0 = 188,
		Beyond-UI-UIScrollRect-get_contentStartPosition0 = 188,
		Beyond-UI-UIScrollList-get_space0 = 188,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newPos0 = 188,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalPos0 = 188,
		Beyond-UI-UITouchPanel-get_touchPos0 = 188,
		Beyond-UI-UIButton-get_parentTarget0 = 189,
		Beyond-UI-UIJoystick-get_parentTarget0 = 189,
		Beyond-UI-UITouchPanel-get_parentTarget0 = 189,
		Beyond-UI-UIButton-_GetUIButtonKeyHintActionId0 = 190,
		Beyond-UI-UIButton-get_bindingViewState0 = 191,
		Beyond-UI-UIDropdown-get_bindingViewState0 = 191,
		Beyond-UI-UIMultiSelectDropdown-get_bindingViewState0 = 191,
		Beyond-UI-UISlider-get_bindingViewState0 = 191,
		Beyond-UI-UIButton-GetBindingViewActionId0 = 192,
		Beyond-UI-UIDropdown-GetBindingViewActionId0 = 192,
		Beyond-UI-UIMultiSelectDropdown-GetBindingViewActionId0 = 192,
		Beyond-UI-UISlider-GetBindingViewActionId0 = 192,
		Beyond-UI-UIButton-GetMouseActionHints0 = 193,
		Beyond-UI-UIToggle-GetMouseActionHints0 = 193,
		Beyond-UI-UIButton-get_actionOnSetNaviTarget0 = 194,
		Beyond-UI-UIButton-ChangeActionOnSetNaviTarget0 = 195,
		Beyond-UI-UICanvasScaleHelper-get_canvasScalerList0 = 196,
		Beyond-UI-UICanvasScaleHelper-CalcCurrentScreenRatio0 = 197,
		Beyond-UI-UICanvasScaleHelper-CalcWorldCanvasParams0 = 198,
		Beyond-UI-UICanvasScaleHelper-CalcScreenCanvasParams0 = 199,
		Beyond-UI-UIColorGroup-_SetColor0 = 200,
		Beyond-UI-UIColorGroup-_CrossFadeAlpha0 = 200,
		Beyond-UI-UIColorGroup-_CrossFadeColorRGB0 = 200,
		Beyond-UI-UIColorGroup-_CrossFadeColorAlpha0 = 200,
		Beyond-UI-UIColorGroup-_ApplyOptToGraphics0 = 201,
		Beyond-UI-UIColorGroup-CrossFadeAlpha0 = 202,
		Beyond-UI-UIColorGroup-CrossFadeColor0 = 203,
		Beyond-UI-UIColorGroup-CrossFadeColor1 = 204,
		Beyond-UI-UIControllerKeyIcon-SetKeyIconName0 = 205,
		Beyond-UI-UICustomLayoutHandle-get_Element0 = 206,
		Beyond-UI-UICustomLayoutElement-get_layoutType0 = 207,
		Beyond-UI-UICustomLayoutHandle-get_layoutType0 = 207,
		Beyond-UI-UICustomLayoutElement-SaveData0 = 208,
		Beyond-UI-UICustomLayoutHandle-Save0 = 209,
		Beyond-UI-UICustomLayoutElement-set_layoutType0 = 210,
		Beyond-UI-UICustomLayoutHandle-set_layoutType0 = 210,
		Beyond-UI-UIDialogTimelineText-get_canvasGroup0 = 211,
		Beyond-UI-FadeSwitchTween-get_alphaHandler0 = 211,
		Beyond-UI-UIDialogTimelineText-get_dialogText0 = 212,
		Beyond-UI-UIDialogTimelineText-SetRadioIcon0 = 213,
		Beyond-UI-UIDropdown-Init0 = 214,
		Beyond-UI-UIMultiSelectDropdown-Init0 = 214,
		Beyond-UI-UIRegionBuildingTexManager-_UpdateTexture0 = 214,
		Beyond-UI-UIScrollRectEdgeRedDot-RegisterRedDot0 = 214,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-Create0 = 214,
		Beyond-UI-GPUI-GPUISharedGraphicBase-UpdateSharedTextures0 = 214,
		Beyond-UI-UIDropdown-SetSelected0 = 215,
		Beyond-UI-UIScrollList-SetSelectedIndex0 = 215,
		Beyond-UI-UIScrollRect-_ScrollToPosition0 = 216,
		Beyond-UI-UIScrollRect-ScrollTo0 = 217,
		Beyond-UI-UIScrollRect-AutoScrollToRectTransform0 = 218,
		Beyond-UI-UIDropdown-Refresh0 = 219,
		Beyond-UI-UIGroupScrollList-SetCellCanCache0 = 219,
		Beyond-UI-UIState-UIStateControllerUtils-StartEditorUpdateLoop0 = 220,
		Beyond-UI-UIScrollList-GetLeftLength0 = 221,
		Beyond-UI-UINonUnifiedScrollList-GetLeftLength0 = 221,
		Beyond-UI-UIScrollList-_SetRealPadding0 = 222,
		Beyond-UI-UIScrollList-SetPadding0 = 223,
		Beyond-UI-UIState-UIStateController-SetState0 = 224,
		Beyond-UI-UIElementFollower-get_followPosition0 = 225,
		Beyond-UI-UIScaleHolder-GetExtraScale0 = 225,
		Beyond-UI-UIElementFollower-get_targetTransform0 = 226,
		Beyond-UI-UILayoutDimensionListener-UnityEngine.UI.ICanvasElement.get_transform0 = 226,
		Beyond-UI-UIScrollCircle-UnityEngine.UI.ICanvasElement.get_transform0 = 226,
		Beyond-UI-UINonUnifiedScrollList-NotifyCellSizeChange0 = 227,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetNodeFillAmount0 = 227,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutInit0 = 228,
		Beyond-UI-UIGridLayoutNaviWrapper-_FindValidSelectable0 = 229,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviChildren0 = 230,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayoutImpl0 = 231,
		Beyond-UI-UIGridLayoutNaviWrapper-_NaviGridLayout0 = 232,
		Beyond-UI-UIScrollRect-RectWrapNavigate0 = 232,
		Beyond-UI-UIScrollList-NavigateSelected0 = 232,
		Beyond-UI-UIScrollList-ListWrapNavigate0 = 232,
		Beyond-UI-UIGridLayoutNaviWrapper-TryWrapNavigate0 = 233,
		Beyond-UI-UIScrollList-_IsScrollDirection0 = 233,
		Beyond-UI-UIGroupScrollList-_GetRowInfo0 = 234,
		Beyond-UI-UIGroupScrollList-_GetGroupAndCellFromCellIndex0 = 235,
		Beyond-UI-UIGroupScrollList-_GetScrollTargetRow0 = 236,
		Beyond-UI-UIGroupScrollList-_GetRowByCellIndex0 = 237,
		Beyond-UI-UIGroupScrollList-_GetGroupCellIndexRange0 = 238,
		Beyond-UI-UIGroupScrollList-_GetGroupRangeFromCellIndexRange0 = 239,
		Beyond-UI-UIGroupScrollList-_MergeGroupRange0 = 240,
		Beyond-UI-UIGroupScrollList-_GetScrollInfo0 = 241,
		Beyond-UI-UIScrollList-_GetLineCount0 = 242,
		Beyond-UI-UIScrollList-Get0 = 243,
		Beyond-UI-UIGroupScrollList-Get1 = 243,
		Beyond-UI-UIGroupScrollList-GetGroupTitle0 = 243,
		Beyond-UI-UIScrollCircle-Get0 = 243,
		Beyond-UI-UIScrollList-GetCell1 = 244,
		Beyond-UI-UIScrollList-GetTargetPosByIndex0 = 245,
		Beyond-UI-UIGroupScrollList-GetTargetPosByIndex0 = 245,
		Beyond-UI-UINonUnifiedScrollList-GetTargetPosByIndex0 = 245,
		Beyond-UI-UIScrollList-ScrollTo0 = 246,
		Beyond-UI-UIGroupScrollList-_ScrollToRow0 = 246,
		Beyond-UI-UIGroupScrollList-_ScrollToGroup0 = 246,
		Beyond-UI-UINonUnifiedScrollList-ScrollTo0 = 246,
		Beyond-UI-UIScrollList-GetNaviOffset0 = 247,
		Beyond-UI-UIScrollList-GetMousePosIndex0 = 247,
		Beyond-UI-UIScrollList-GetNaviNewIndex0 = 248,
		Beyond-UI-UIScrollList-TryResolveWrapDirection0 = 249,
		Beyond-UI-UIGroupScrollList-TryResolveWrapDirection0 = 249,
		Beyond-UI-UIScrollList-TryGetCurrentFocusedCell0 = 250,
		Beyond-UI-UIScrollList-TryNavigateInsideCell0 = 251,
		Beyond-UI-UIScrollList-TryGetWrapTargetIndex0 = 252,
		Beyond-UI-UIGroupScrollList-TryGetWrapTargetIndex0 = 252,
		Beyond-UI-UIScrollList-TrySetNaviTargetByIndex0 = 253,
		Beyond-UI-UIScrollList-TryNavigateBySequentialIndex0 = 253,
		Beyond-UI-UIScrollList-TryHandleCircleNavigationInScrollDirection0 = 254,
		Beyond-UI-UIGroupScrollList-TryHandleCircleNavigationInScrollDirection0 = 254,
		Beyond-UI-UIScrollList-TryNormalizeFirstWrapIndex0 = 255,
		Beyond-UI-UIGroupScrollList-UpdateCount1 = 256,
		Beyond-UI-UIScrollList-UpdateCount0 = 256,
		Beyond-UI-UIGroupScrollList-UpdateGroup0 = 256,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount2 = 256,
		Beyond-UI-UIGroupScrollList-UpdateGroup1 = 257,
		Beyond-UI-UIMultiSelectDropdown-SetSelected0 = 257,
		Beyond-UI-UIScrollList-UpdateCount1 = 257,
		Beyond-UI-UINonUnifiedScrollList-UpdateCount1 = 257,
		Beyond-UI-UIGroupScrollList-_RemapShowingCellIndicesAfterGroupResize0 = 258,
		Beyond-UI-UIGroupScrollList-UpdateSingleGroup0 = 259,
		Beyond-UI-UIGroupScrollList-RemoveLastCellFromGroup0 = 260,
		Beyond-UI-UIMultiSelectDropdown-_IsValidIndex0 = 260,
		Beyond-UI-UIMultiSelectDropdown-IsSelected0 = 260,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-ClearSpriteOverride0 = 260,
		Beyond-UI-UIGroupScrollList-ScrollToIndex0 = 261,
		Beyond-UI-UIGroupScrollList-GetGroupRangeInView0 = 262,
		Beyond-UI-UIGroupScrollList-_IsGroupInCellRange0 = 263,
		Beyond-UI-UIGroupScrollList-_MoveCellTo0 = 264,
		Beyond-UI-UIGroupScrollList-_UpdateGroupBGByRange0 = 265,
		Beyond-UI-UIGroupScrollList-_OnUpdateTitleOrCell0 = 266,
		Beyond-UI-UIGroupScrollList-_UpdateTitleOrCell0 = 267,
		Beyond-UI-UIGroupScrollList-_CellsInGroupRow0 = 268,
		Beyond-UI-UIGroupScrollList-Get0 = 269,
		Beyond-UI-UIImage-get_atlasHandle0 = 270,
		Beyond-UI-UIAtlasManager-UIAtlasHandle-CreateInvalidHandle0 = 271,
		Beyond-UI-UIImage-get_mainTexture0 = 272,
		Beyond-UI-UISoftMask-_GetSoftMaskTexture0 = 272,
		Beyond-UI-UIImageFillAmountOffset-DOFillAmount0 = 273,
		Beyond-UI-UIImagePair-get_first0 = 274,
		Beyond-UI-UIInertiaViewPager-ScrollEffectConfig-IsEmpty0 = 275,
		Beyond-UI-UIInertiaViewPager-DragContext-EndDrag0 = 276,
		Beyond-UI-UIInertiaViewPager-InertiaBlocker-IsDirMatch0 = 277,
		Beyond-UI-UIInertiaViewPager-BlockerManager-HitInertiaBlock0 = 278,
		Beyond-UI-UIInertiaViewPager-ScrollEffectTrigger-NotifyScrolling0 = 279,
		Beyond-UI-UIScrollText-_UpdateScrollState0 = 279,
		Beyond-UI-UIInertiaViewPager-_OnStateChanged0 = 280,
		Beyond-UI-UIInertiaViewPager-BlockerManager-Init0 = 281,
		Beyond-UI-UIInertiaViewPager-SetPageCount0 = 281,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetText0 = 281,
		Beyond-UI-GPUI-RuntimeInstance-SetText0 = 281,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-get_velocity0 = 282,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-get_scrollProgress0 = 282,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-get_isDragging0 = 283,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-set_scrollProgress0 = 284,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-StopMoving0 = 285,
		Beyond-UI-UIInertiaViewPager-EmptyScrollHandler-OnClear0 = 285,
		Beyond-UI-UIInputField-get_s_focusedInputField0 = 286,
		Beyond-UI-UIJoystick-_Activate0 = 287,
		Beyond-UI-UILayoutDimensionListener-Rebuild0 = 288,
		Beyond-UI-UINonUnifiedScrollRect-Rebuild0 = 288,
		Beyond-UI-UIScrollCircle-Rebuild0 = 288,
		Beyond-UI-UILeftSubtitle-SetLeftSubTitle0 = 289,
		Beyond-UI-UIMaterialAnimation-_GetSlotKind0 = 290,
		Beyond-UI-UIMaterialAnimation-_GetSlotVector0 = 291,
		Beyond-UI-UIMultiSelectDropdown-SetSelectedList0 = 292,
		Beyond-UI-UIMultiSelectDropdown-GetSelectedIndices0 = 293,
		Beyond-UI-UIMultiSelectDropdown-GetSelectedStates0 = 294,
		Beyond-UI-UIMultiSelectDropdown-Refresh0 = 295,
		Beyond-UI-UINumberScrollTween-_HandleNumberScrollTween0 = 296,
		Beyond-UI-UIRegionBuildingTexManager-get_materialPropertyBlock0 = 297,
		Beyond-UI-UIScaleHolder-_IsValidScale0 = 298,
		Beyond-UI-UIScrollCircle-_GetDeltaAngle0 = 299,
		Beyond-UI-UIScrollCircle-_CheckCanMove0 = 300,
		Beyond-UI-UIScrollList-GetPadding0 = 301,
		Beyond-UI-UIScrollList-GetShowingCellsIndexRange0 = 302,
		Beyond-UI-UIScrollList-ScreenPos2Index0 = 303,
		Beyond-UI-UIScrollList-_GetScreenPosLineColumnInfo0 = 304,
		Beyond-UI-UIScrollRect-get_moveTips0 = 305,
		Beyond-UI-UIScrollRectEdgeRedDot-_UpdateRedDotGameObjects0 = 306,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_state0 = 307,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_newRect0 = 308,
		Beyond-UI-UIScrollRectEdgeRedDot-RedDotInfo-get_normalRect0 = 308,
		Beyond-UI-UIScrollRectEdgeRedDot-IsRedDotInDir0 = 309,
		Beyond-UI-UIScrollRectEdgeRedDot-_CalculateRedDotStateInDir0 = 310,
		Beyond-UI-UIScrollText-_ResetTextScrollInternal0 = 311,
		Beyond-UI-UISoftMask-GetCornerCanvas0 = 312,
		Beyond-UI-UISoftMask-GetFourCornnerArrayWorld0 = 313,
		Beyond-UI-UISoftMask-_GetRuntimeAtlasSpritePadding0 = 314,
		Beyond-UI-UISoftMask-_GetRuntimeAtlasSpriteInnerUV0 = 314,
		Beyond-UI-UISoftMask-_GetRuntimeAtlasSpriteOuterUV0 = 314,
		Beyond-UI-UISoftMask-_GetSpriteOuterUV0 = 314,
		Beyond-UI-UISoftMask-_GetAdjustedBorders0 = 315,
		Beyond-UI-UISoftMask-_NormalizeInnerUV0 = 316,
		Beyond-UI-UISoftMask-_CalculateSlicedSpriteParams0 = 317,
		Beyond-UI-UISoftMaskable-get_graphic0 = 318,
		Beyond-UI-UIVFXManager-get_graphic0 = 318,
		Beyond-UI-UISoftMaskable-get_softMask0 = 319,
		Beyond-UI-UISoftMaskable-_Equal0 = 320,
		Beyond-UI-UISoftMaskable-_ComputeLineCross0 = 321,
		Beyond-UI-UISoftMaskable-_ComputePointAtTriangleUV0 = 322,
		Beyond-UI-UISoftMaskable-_SetUIVertexUV0 = 323,
		Beyond-UI-UISoftMaskable-_ClipTriangleByClampSoftMaskUV0 = 324,
		Beyond-UI-UIVFXManager-get_softMaskable0 = 325,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-_ScrollLayouts0 = 326,
		Beyond-UI-UIWorldLevelScrollListAnimCtrl-UpdateWorldLevelScrollList0 = 327,
		Beyond-UI-CSPopupPanel-Show0 = 328,
		Beyond-UI-MobileMotionManager-PostEventCommonShort0 = 329,
		Beyond-UI-MobileMotionManager-PostEventCommonOperateSuccess0 = 329,
		Beyond-UI-MobileMotionManager-PostEventCommonOperateFailure0 = 329,
		Beyond-UI-DynamicFontAssetLoader-AddNotFoundUnicode0 = 330,
		Beyond-UI-DynamicFontAssetLoader-FontAssetRef-GetFontAsset0 = 331,
		Beyond-UI-DynamicFontAssetLoader-TryGetFontAsset0 = 332,
		Beyond-UI-TweenUtils-TickAsCountDown0 = 333,
		Beyond-UI-TweenUtils-FLerpByTime-Start0 = 334,
		Beyond-UI-TweenUtils-FLerpByTime-GetValue0 = 335,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateGraph0 = 336,
		Beyond-UI-UIAnimationMixPlayer-CreateGraph0 = 336,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateMixer0 = 337,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateOutput0 = 338,
		Beyond-UI-UIAnimationMixPlayer-CreateOutput0 = 338,
		Beyond-UI-UIAnimationLayerMixPlayer-CreateSourceFromAsset0 = 339,
		Beyond-UI-UIAnimationMixPlayer-CreateSourceFromAsset0 = 339,
		Beyond-UI-UIAnimationMixPlayer-CreateMixer0 = 340,
		Beyond-UI-UISwitchTween-TweenContext-OnReset0 = 341,
		Beyond-UI-UISwitchTween-TweenContext-OnTweenStop0 = 342,
		Beyond-UI-UISwitchTween-SetOptions0 = 343,
		Beyond-UI-UISwitchTween-GetContext0 = 344,
		Beyond-UI-UISwitchTween-TweenContext-IsInterapted0 = 345,
		Beyond-UI-FadeSwitchTween-Durations-GetHideDuration0 = 346,
		Beyond-UI-FadeSwitchTween-Durations-GetShowDuration0 = 346,
		Beyond-UI-FadeSwitchTween-Builder-Build0 = 347,
		Beyond-UI-FadeTranslationSwitchTween-_GetTargetPos0 = 348,
		Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRect0 = 349,
		Beyond-UI-UIAtlasManager-_IsRuntimeAtlasCompatible0 = 350,
		Beyond-UI-UIAtlasManager-UIAtlasPage-InsertRect0 = 351,
		Beyond-UI-UIAtlasManager-UIAtlasPage-CopyIntoAtlas0 = 352,
		Beyond-UI-UIAtlasManager-UIAtlasHandle-IsValid0 = 353,
		Beyond-UI-UIAtlasManager-UIAtlasPage-FreeRects0 = 354,
		Beyond-UI-UICharHeadGlowAnimationSource-get_firstLayer0 = 355,
		Beyond-UI-UICharHeadGlowAnimationSource-get_secondLayer0 = 355,
		Beyond-UI-UICharHeadGlowAnimationSource-get_loopAnimation0 = 356,
		Beyond-UI-GPUI-GPUIExtendedPrefabData-_NormalizeWrapMode0 = 357,
		Beyond-UI-GPUI-GPUIExtendedPrefabDataLite-_NormalizeWrapMode0 = 357,
		Beyond-UI-GPUI-GPUIExtendedPrefabData-_PackFillOriginFlags0 = 358,
		Beyond-UI-GPUI-GPUIExtendedPrefabData-CreateFontNode0 = 359,
		Beyond-UI-GPUI-GPUIExtendedPrefabDataLite-CreateFontNode0 = 360,
		Beyond-UI-GPUI-GPUIRootTransformState-get_Default0 = 361,
		Beyond-UI-GPUI-GPUISubrootDomainState-get_Default0 = 362,
		Beyond-UI-GPUI-GPUIExtendedAnimationState-get_Default0 = 363,
		Beyond-UI-GPUI-GPUIExtendedTransformUtility-ResolveSubroot0 = 364,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackPrefabAndParent0 = 365,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackUInt16Pair0 = 365,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackGrandParentMatTypeAndDrawType0 = 366,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackRootScaleY0 = 367,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackFillOverrideByte0 = 368,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackTextScale0 = 369,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-_PackSnorm160 = 370,
		Beyond-UI-GPUI-GPUIExtendedPackingUtility-PackQuaternion0 = 371,
		Beyond-UI-GPUI-GPUPrefabData-CreateFontNode0 = 372,
		Beyond-UI-GPUI-GPUPrefabDataLite-CreateFontNode0 = 373,
		Beyond-UI-GPUI-CodePoint-ConvertToUTF320 = 374,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-get_runtimeTexture0 = 375,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-get_dynamicAtlasRect0 = 376,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_IsValidDynamicAtlasRect0 = 377,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_IsAtlasCreationValid0 = 378,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_LogFailure0 = 379,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Initialize0 = 380,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Initialize1 = 380,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-DynamicSpriteHandle-CreateInvalidHandle0 = 381,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-_TryValidateSprite0 = 382,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Acquire0 = 383,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-DynamicSpriteHandle-IsValid0 = 384,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Release0 = 385,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-Release1 = 386,
		Beyond-UI-GPUI-GPUIExtendedDynamicAtlas-GetAtlasStatus0 = 387,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-RegisterSpriteUV0 = 388,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-_SetLiteUV0 = 389,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-TryAcquire0 = 390,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-TryAcquireDynamicPrefabNode0 = 390,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-Release0 = 391,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-ReleaseDynamicPrefabNode0 = 391,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-DynamicPrefabNodeKey-Equals0 = 392,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-DynamicPrefabNodeKey-Equals1 = 393,
		Beyond-UI-GPUI-GPUIExtendedDynamicPrefabNodeManager-DynamicPrefabNodeKey-GetHashCode0 = 394,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-TryAcquireDynamicSprite0 = 395,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-TryAcquireDynamicPrefabNode1 = 396,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-MatchesDynamicPrefabNode0 = 397,
		Beyond-UI-GPUI-GPUIExtendedDynamicSpriteOverrideManager-ReleaseDynamicSprite0 = 398,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-get_Prefab0 = 399,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_GetAnimationData0 = 400,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_HasActivePrefabNode0 = 401,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_ReleaseSpriteOverrideResources0 = 402,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_WriteRootNode0 = 403,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_WriteSubrootProxyNodes0 = 404,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_GetAnimationStateForNode0 = 405,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_UnpackPrefabId0 = 406,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_ApplySpriteOverride0 = 407,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_PackFillOverride0 = 408,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-DoUpdate0 = 409,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetRootRotation0 = 410,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-StartAnimation0 = 411,
		Beyond-UI-GPUI-RuntimeInstance-StartAnimation0 = 411,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-StartSubrootAnimation0 = 412,
		Beyond-UI-GPUI-GPUIUtils-ColorToRGBAUint320 = 413,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetNodeColor0 = 414,
		Beyond-UI-GPUI-RuntimeInstance-SetColor0 = 414,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetSubrootState0 = 415,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_TryResolveCurrentBasePrefabOffset0 = 416,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_TryPrimeSpriteOverride0 = 417,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-_TryPrimeSpriteOverrideWithReleasedSlot0 = 418,
		Beyond-UI-GPUI-GPUIExtendedRuntimeInstance-SetSpriteOverride0 = 419,
		Beyond-UI-GPUI-GPUIExtendedSystem-_GetOneHandle0 = 420,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_handle0 = 420,
		Beyond-UI-GPUI-GPUISystem-_GetOneHandle0 = 420,
		Beyond-UI-GPUI-GPUIExtendedSystem-CreateInstance0 = 421,
		Beyond-UI-GPUI-GPUISystem-CreateInstance0 = 421,
		Beyond-UI-GPUI-GPUIExtendedSystem-_IsHandleInvalid0 = 422,
		Beyond-UI-GPUI-GPUIExtendedSystem-DestroyInstance0 = 422,
		Beyond-UI-GPUI-GPUIExtendedSystem-IsInstanceValid0 = 422,
		Beyond-UI-GPUI-GPUISystem-_IsHandleInvalid0 = 422,
		Beyond-UI-GPUI-GPUISystem-_DestroyInstance0 = 422,
		Beyond-UI-GPUI-GPUISystem-DestroyInstance0 = 422,
		Beyond-UI-GPUI-GPUISystem-IsInstanceValid0 = 422,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetRootPosition0 = 423,
		Beyond-UI-GPUI-GPUISystem-SetRootPosition0 = 423,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetRootScale0 = 424,
		Beyond-UI-GPUI-GPUISystem-SetRootScale0 = 424,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetRootRotation0 = 425,
		Beyond-UI-GPUI-GPUIExtendedSystem-_TryResolveNode0 = 426,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetNodeVisibility0 = 427,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetSubrootVisibility0 = 427,
		Beyond-UI-GPUI-GPUISystem-SetVisibility0 = 427,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetSubrootTransform0 = 428,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetColor0 = 429,
		Beyond-UI-GPUI-GPUISystem-SetColor0 = 429,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetImageFillAmount0 = 430,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetText0 = 431,
		Beyond-UI-GPUI-GPUIExtendedSystem-SetSprite0 = 431,
		Beyond-UI-GPUI-GPUIExtendedSystem-StartSubrootAnimation0 = 431,
		Beyond-UI-GPUI-GPUISystem-SetText0 = 431,
		Beyond-UI-GPUI-GPUIExtendedSystem-StartAnimation0 = 432,
		Beyond-UI-GPUI-GPUIExtendedSystem-StartAnimation1 = 433,
		Beyond-UI-GPUI-GPUIExtendedSystem-TryGetAnimationDuration0 = 434,
		Beyond-UI-GPUI-GPUIExtendedSystem-TryGetSubrootAnimationDuration0 = 435,
		Beyond-UI-GPUI-GPUIExtendedSystem-_TryResolveAndValidateGroupBufferConfig0 = 436,
		Beyond-UI-GPUI-GPUIExtendedSystem-_InitPrefabBufferManager0 = 437,
		Beyond-UI-GPUI-GPUIExtendedSystem-_LoadPrefabNodeBuffer0 = 438,
		Beyond-UI-GPUI-GPUISystem-_LoadPrefabNodeBuffer0 = 438,
		Beyond-UI-GPUI-GPUIExtendedSystem-_LoadPrefabData0 = 439,
		Beyond-UI-GPUI-GPUIHandle-Equals0 = 440,
		Beyond-UI-GPUI-GPUIHandle-Equals1 = 441,
		Beyond-UI-GPUI-GPUIHandle-GetHashCode0 = 442,
		Beyond-UI-GPUI-GPUIHandle-op_Equality0 = 443,
		Beyond-UI-GPUI-GPUIHandle-op_Inequality0 = 443,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_targetSystem0 = 444,
		Beyond-UI-GPUI-GPUIProxySyncManager-get_targetSystem0 = 444,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-get_syncManager0 = 445,
		Beyond-UI-GPUI-GPUIProxySyncManager-_TryResolveCanvasContext0 = 446,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_TryResolveTargetCanvas0 = 446,
		Beyond-UI-GPUI-GPUIProxySyncManager-_SnapshotAndCheckChanged0 = 447,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_ShouldSyncTransform0 = 448,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_TryGetCanvasLocalPosition0 = 449,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-_SyncTransform0 = 450,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-TrySyncTransform2 = 450,
		Beyond-UI-GPUI-GPUIPrefabProxyBase-TrySyncTransform0 = 451,
		Beyond-UI-GPUI-GPUIProxySyncManager-TryResolveTargetSystem0 = 452,
		Beyond-UI-GPUI-GPUISystem-_CreateInstance0 = 453,
		Beyond-UI-GPUI-RuntimeInstance-SetPosition0 = 454,
		Beyond-UI-GPUI-GPUISystem-_RecycleOneHandle0 = 455,
		Beyond-UI-GPUI-RuntimeInstance-get_Prefab0 = 456,
		Beyond-UI-GPUI-GPUISystem-StartAnimation0 = 457,
		Beyond-UI-GPUI-GPUISystem-StartAnimation1 = 458,
		Beyond-UI-GPUI-GPUISystem-_LoadPrefabData0 = 459,
		Beyond-UI-GPUI-GPUIUtils-CreateQuadMesh0 = 460,
		Beyond-UI-GPUI-RuntimeInstance-DoUpdate0 = 461
	}

	public delegate void __HotPatchDelegate_1(object P0); // TypeDefIndex: 74748; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_2(object P0, bool P1); // TypeDefIndex: 74749; 0x00000001859B7730-0x00000001859B7740

	public delegate float __HotPatchDelegate_3(object P0); // TypeDefIndex: 74750; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_4(object P0); // TypeDefIndex: 74751; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate TickType __HotPatchDelegate_5(object P0); // TypeDefIndex: 74752; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate LuaPanel __HotPatchDelegate_6(object P0); // TypeDefIndex: 74753; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_7(object P0, object P1, bool P2); // TypeDefIndex: 74754; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_8(object P0, float P1); // TypeDefIndex: 74755; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_9(object P0, out bool P1); // TypeDefIndex: 74756; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_10(object P0, int P1); // TypeDefIndex: 74757; 0x00000001859B7730-0x00000001859B7740

	public delegate UIText.HyperlinkUITextManager __HotPatchDelegate_11(); // TypeDefIndex: 74758; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_12(object P0, object P1); // TypeDefIndex: 74759; 0x00000001859B7730-0x00000001859B7740

	public delegate UIText.HyperlinkUITextGroup __HotPatchDelegate_13(object P0, object P1, bool P2); // TypeDefIndex: 74760; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_14(object P0, object P1); // TypeDefIndex: 74761; 0x00000001859B7730-0x00000001859B7740

	public delegate string __HotPatchDelegate_15(PhoneticType P0, object P1); // TypeDefIndex: 74762; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_16(object P0, PhoneticType P1, object P2); // TypeDefIndex: 74763; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_17(object P0); // TypeDefIndex: 74764; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_18(EnvLang P0); // TypeDefIndex: 74765; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_19(object P0, object P1, out string P2); // TypeDefIndex: 74766; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_20(object P0, Vector3 P1, out string P2); // TypeDefIndex: 74767; 0x0000000181289520-0x0000000181289560

	public delegate IEnumerator __HotPatchDelegate_21(object P0); // TypeDefIndex: 74768; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_22(object P0, bool P1); // TypeDefIndex: 74769; 0x00000001859B7730-0x00000001859B7740

	public delegate Sprite __HotPatchDelegate_23(object P0, object P1); // TypeDefIndex: 74770; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_24(ReadOnlySpan<char> P0); // TypeDefIndex: 74771; 0x0000000186A4F2D0-0x0000000186A4F300

	public delegate UIText.RichTextInfo __HotPatchDelegate_25(UIText.RichTextAnalyzer.RichTextParam P0, object P1, ref Utf16ValueStringBuilder P2); // TypeDefIndex: 74772; 0x0000000184175D60-0x0000000184175DA0

	public delegate UIText.RichTextInfo __HotPatchDelegate_26(object P0, UIText.RichTextAnalyzer.RichTextParam P1, object P2, ref Utf16ValueStringBuilder P3); // TypeDefIndex: 74773; 0x000000018415FB00-0x000000018415FB50

	public delegate UIText.RichTextAnalyzer.ProcessRichTextEntryFunc __HotPatchDelegate_27(object P0); // TypeDefIndex: 74774; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_28(ReadOnlySpan<char> P0, out bool P1, out UIText.RichTextAnalyzer.RichTextParam P2); // TypeDefIndex: 74775; 0x00000001826DF9A0-0x00000001826DF9D0

	public delegate bool __HotPatchDelegate_29(ReadOnlySpan<char> P0, ref Utf16ValueStringBuilder P1, object P2, out UIText.RichTextInfo P3); // TypeDefIndex: 74776; 0x0000000184170440-0x0000000184170480

	public delegate string __HotPatchDelegate_30(object P0, object P1, out List<UIText.RichTextInfo> P2); // TypeDefIndex: 74777; 0x00000001811DF7F0-0x00000001811DF810

	public delegate GameObject __HotPatchDelegate_31(object P0); // TypeDefIndex: 74778; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIText.ImageGOInfo __HotPatchDelegate_32(object P0, int P1); // TypeDefIndex: 74779; 0x0000000181247850-0x0000000181247890

	public delegate Material __HotPatchDelegate_33(object P0); // TypeDefIndex: 74780; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Material __HotPatchDelegate_34(object P0, object P1); // TypeDefIndex: 74781; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_35(object P0); // TypeDefIndex: 74782; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_36(); // TypeDefIndex: 74783; 0x0000000185B44B70-0x0000000185B44B80

	public delegate I18nFontSearchData __HotPatchDelegate_37(); // TypeDefIndex: 74784; 0x0000000185B44B70-0x0000000185B44B80

	public delegate TMP_FontAsset __HotPatchDelegate_38(int P0); // TypeDefIndex: 74785; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate TMP_FontAsset __HotPatchDelegate_39(object P0); // TypeDefIndex: 74786; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_40(object P0, object P1, object P2, int P3); // TypeDefIndex: 74787; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_41(object P0, object P1, int P2); // TypeDefIndex: 74788; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_42(object P0, int P1, out string P2); // TypeDefIndex: 74789; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_43(object P0, int P1, out Vector3 P2, out float P3); // TypeDefIndex: 74790; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_44(object P0, object P1, object P2); // TypeDefIndex: 74791; 0x00000001811DF7F0-0x00000001811DF810

	public delegate List<UIText> __HotPatchDelegate_45(object P0, object P1); // TypeDefIndex: 74792; 0x00000001859B7730-0x00000001859B7740

	public delegate List<UIText> __HotPatchDelegate_46(object P0); // TypeDefIndex: 74793; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate TMP_SubMeshUI __HotPatchDelegate_47(object P0, object P1, MaterialReference P2); // TypeDefIndex: 74794; 0x000000018417D4C0-0x000000018417D510

	public delegate string __HotPatchDelegate_48(int P0); // TypeDefIndex: 74795; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Vector2 __HotPatchDelegate_49(object P0, ref float P1, Vector2 P2, bool P3, bool P4); // TypeDefIndex: 74796; 0x00000001826DF690-0x00000001826DF6C0

	public delegate int __HotPatchDelegate_50(); // TypeDefIndex: 74797; 0x0000000185B44B70-0x0000000185B44B80

	public delegate float __HotPatchDelegate_51(); // TypeDefIndex: 74798; 0x0000000185B44B70-0x0000000185B44B80

	public delegate GameObject __HotPatchDelegate_52(object P0, object P1, object P2); // TypeDefIndex: 74799; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_53(object P0, object P1, object P2, object P3); // TypeDefIndex: 74800; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_54(object P0, int P1); // TypeDefIndex: 74801; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_55(Vector3 P0, object P1, object P2); // TypeDefIndex: 74802; 0x00000001826DF960-0x00000001826DF9A0

	public delegate bool __HotPatchDelegate_56(Vector2 P0, object P1, object P2); // TypeDefIndex: 74803; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Bounds __HotPatchDelegate_57(object P0, object P1); // TypeDefIndex: 74804; 0x0000000181247850-0x0000000181247890

	public delegate bool __HotPatchDelegate_58(int P0, out UnityEngine.InputSystem.EnhancedTouch.Touch P1); // TypeDefIndex: 74805; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_59(object P0, UnityEngine.Color P1); // TypeDefIndex: 74806; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate Rect __HotPatchDelegate_60(object P0, object P1); // TypeDefIndex: 74807; 0x00000001812C43A0-0x00000001812C43E0

	public delegate Vector2 __HotPatchDelegate_61(object P0, object P1, Vector2 P2); // TypeDefIndex: 74808; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Vector3 __HotPatchDelegate_62(object P0, object P1); // TypeDefIndex: 74809; 0x0000000186AEB300-0x0000000186AEB340

	public delegate UnityEngine.Color __HotPatchDelegate_63(object P0); // TypeDefIndex: 74810; 0x0000000186464680-0x00000001864646B0

	public delegate float __HotPatchDelegate_64(float P0); // TypeDefIndex: 74811; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_65(object P0, out string P1); // TypeDefIndex: 74812; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_66(object P0, object P1, CinemachineCore.Stage P2, ref CameraState P3, float P4); // TypeDefIndex: 74813; 0x00000001812083C0-0x00000001812083E0

	public delegate int __HotPatchDelegate_67(object P0, int P1); // TypeDefIndex: 74814; 0x00000001859B7730-0x00000001859B7740

	public delegate Vector2 __HotPatchDelegate_68(object P0, int P1); // TypeDefIndex: 74815; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_69(object P0, int P1, bool P2); // TypeDefIndex: 74816; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Vector2Int __HotPatchDelegate_70(object P0, float P1, float P2, float P3); // TypeDefIndex: 74817; 0x00000001812250A0-0x00000001812250C0

	public delegate Vector2Int __HotPatchDelegate_71(object P0, float P1, bool P2); // TypeDefIndex: 74818; 0x000000018238E680-0x000000018238E6A0

	public delegate Vector2Int __HotPatchDelegate_72(object P0); // TypeDefIndex: 74819; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_73(object P0, Vector2Int P1, Vector2Int P2); // TypeDefIndex: 74820; 0x00000001811DF7F0-0x00000001811DF810

	public delegate UIScrollList.Cell __HotPatchDelegate_74(object P0); // TypeDefIndex: 74821; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_75(object P0, bool P1); // TypeDefIndex: 74822; 0x00000001859B7730-0x00000001859B7740

	public delegate DG.Tweening.Tween __HotPatchDelegate_76(object P0); // TypeDefIndex: 74823; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIAnimationTween __HotPatchDelegate_77(object P0); // TypeDefIndex: 74824; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UnityEngine.AnimationState __HotPatchDelegate_78(object P0, object P1); // TypeDefIndex: 74825; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_79(object P0, object P1, float P2); // TypeDefIndex: 74826; 0x000000018124EAD0-0x000000018124EAF0

	public delegate void __HotPatchDelegate_80(object P0, object P1, float P2, bool P3); // TypeDefIndex: 74827; 0x00000001826DF730-0x00000001826DF750

	public delegate void __HotPatchDelegate_81(object P0, object P1, object P2, UIConst.AnimationState P3, float P4, bool P5, float P6); // TypeDefIndex: 74828; 0x00000001826EB2B0-0x00000001826EB2D0

	public delegate void __HotPatchDelegate_82(object P0, float P1, bool P2); // TypeDefIndex: 74829; 0x000000018238E680-0x000000018238E6A0

	public delegate AnimationClip __HotPatchDelegate_83(object P0); // TypeDefIndex: 74830; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_84(object P0, object P1, bool P2, float P3); // TypeDefIndex: 74831; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_85(object P0, int P1, bool P2, bool P3); // TypeDefIndex: 74832; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_86(object P0, Vector2Int P1); // TypeDefIndex: 74833; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_87(object P0, bool P1, bool P2, bool P3); // TypeDefIndex: 74834; 0x0000000181217F60-0x0000000181217F80

	public delegate UIScrollList.MoveTipsType __HotPatchDelegate_88(object P0); // TypeDefIndex: 74835; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UISelectableNaviGroup __HotPatchDelegate_89(object P0); // TypeDefIndex: 74836; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_90(object P0, object P1); // TypeDefIndex: 74837; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_91(object P0, object P1, bool P2, out Selectable P3); // TypeDefIndex: 74838; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_92(object P0, Vector2 P1); // TypeDefIndex: 74839; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_93(object P0, int P1, bool P2, UIScrollList.ScrollAlignType P3, bool P4); // TypeDefIndex: 74840; 0x000000018129F400-0x000000018129F420

	public delegate UIText __HotPatchDelegate_94(object P0); // TypeDefIndex: 74841; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Sprite __HotPatchDelegate_95(object P0); // TypeDefIndex: 74842; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIStyleInputValidTypeMask __HotPatchDelegate_96(object P0); // TypeDefIndex: 74843; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_97(object P0, UIStyleInputValidTypeMask P1); // TypeDefIndex: 74844; 0x00000001859B7730-0x00000001859B7740

	public delegate CustomUIStyle.OverrideValidState __HotPatchDelegate_98(object P0); // TypeDefIndex: 74845; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_99(UIStyleInputValidType P0); // TypeDefIndex: 74846; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_100(object P0, CustomUIStyle.OverrideValidState P1); // TypeDefIndex: 74847; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_101(UIStyleInputValidTypeMask P0); // TypeDefIndex: 74848; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_102(object P0, int P1, int P2); // TypeDefIndex: 74849; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_103(object P0, bool P1, bool P2); // TypeDefIndex: 74850; 0x00000001811DF7F0-0x00000001811DF810

	public delegate ScrollDirection __HotPatchDelegate_104(object P0); // TypeDefIndex: 74851; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_105(object P0, float P1, int P2); // TypeDefIndex: 74852; 0x000000018238E680-0x000000018238E6A0

	public delegate float __HotPatchDelegate_106(object P0, float P1, float P2); // TypeDefIndex: 74853; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_107(object P0, float P1, float P2, object P3, object P4); // TypeDefIndex: 74854; 0x000000018415EF40-0x000000018415EF60

	public delegate void __HotPatchDelegate_108(object P0, float P1, float P2, Interpolator.EEaseType P3, object P4); // TypeDefIndex: 74855; 0x000000018415EF40-0x000000018415EF60

	public delegate UILoopScrollRect.MovementDirection __HotPatchDelegate_109(object P0, int P1, int P2); // TypeDefIndex: 74856; 0x00000001811DF7F0-0x00000001811DF810

	public delegate float __HotPatchDelegate_110(object P0, float P1); // TypeDefIndex: 74857; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_111(object P0, float P1); // TypeDefIndex: 74858; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_112(object P0, int P1, int P2); // TypeDefIndex: 74859; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_113(object P0, float P1, int P2, bool P3); // TypeDefIndex: 74860; 0x00000001826DFD20-0x00000001826DFD40

	public delegate Selectable __HotPatchDelegate_114(object P0); // TypeDefIndex: 74861; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_115(object P0, Vector2 P1, object P2); // TypeDefIndex: 74862; 0x00000001811DF7F0-0x00000001811DF810

	public delegate IList<UIRecycleLayoutAdapter.IVirtualView> __HotPatchDelegate_116(object P0); // TypeDefIndex: 74863; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIRecycleLayoutAdapter __HotPatchDelegate_117(object P0); // TypeDefIndex: 74864; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIRecycleLayoutGroup.ViewMgr __HotPatchDelegate_118(object P0); // TypeDefIndex: 74865; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIRecycleLayoutGroup.Padding __HotPatchDelegate_119(object P0); // TypeDefIndex: 74866; 0x0000000186464680-0x00000001864646B0

	public delegate RectTransform __HotPatchDelegate_120(object P0); // TypeDefIndex: 74867; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_121(object P0, object P1, UIRecycleLayoutGroup.LayoutMeta P2); // TypeDefIndex: 74868; 0x0000000181499900-0x0000000181499930

	public delegate Vector2 __HotPatchDelegate_122(object P0, Bounds P1); // TypeDefIndex: 74869; 0x00000001826DF780-0x00000001826DF7C0

	public delegate Bounds __HotPatchDelegate_123(object P0, UIRecycleLayoutGroup.LayoutMeta P1); // TypeDefIndex: 74870; 0x0000000184E4D1B0-0x0000000184E4D200

	public delegate UIRecycleLayoutAdapter __HotPatchDelegate_124(object P0, object P1); // TypeDefIndex: 74871; 0x00000001859B7730-0x00000001859B7740

	public delegate UIRecycleLayoutGroup.ViewPool __HotPatchDelegate_125(object P0, object P1); // TypeDefIndex: 74872; 0x00000001859B7730-0x00000001859B7740

	public delegate GameObject __HotPatchDelegate_126(object P0, out bool P1); // TypeDefIndex: 74873; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_127(object P0, int P1, object P2); // TypeDefIndex: 74874; 0x00000001811DF7F0-0x00000001811DF810

	public delegate UIRecycleLayoutAdapter.IVirtualView __HotPatchDelegate_128(object P0, int P1); // TypeDefIndex: 74875; 0x00000001859B7730-0x00000001859B7740

	public delegate float __HotPatchDelegate_129(object P0, int P1); // TypeDefIndex: 74876; 0x00000001859B7730-0x00000001859B7740

	public delegate Bounds __HotPatchDelegate_130(object P0, int P1); // TypeDefIndex: 74877; 0x0000000181247850-0x0000000181247890

	public delegate int __HotPatchDelegate_131(object P0, object P1); // TypeDefIndex: 74878; 0x00000001859B7730-0x00000001859B7740

	public delegate UIRecycleLayoutGroup.Direction __HotPatchDelegate_132(object P0); // TypeDefIndex: 74879; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIRecycleMultiHolder.MultiVirtualView __HotPatchDelegate_133(object P0, int P1); // TypeDefIndex: 74880; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_134(object P0, int P1, object P2, float P3); // TypeDefIndex: 74881; 0x00000001811CDB70-0x00000001811CDB90

	public delegate UIRecycleSingleHolder.SimpleVirtualView __HotPatchDelegate_135(object P0, int P1); // TypeDefIndex: 74882; 0x00000001859B7730-0x00000001859B7740

	public delegate ToastList.CellInfo __HotPatchDelegate_136(object P0); // TypeDefIndex: 74883; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_137(object P0, int P1, object P2); // TypeDefIndex: 74884; 0x00000001811DF7F0-0x00000001811DF810

	public delegate string __HotPatchDelegate_138(object P0, object P1, bool P2, bool P3, out bool P4); // TypeDefIndex: 74885; 0x00000001826EA060-0x00000001826EA080

	public delegate bool __HotPatchDelegate_139(object P0, object P1, object P2); // TypeDefIndex: 74886; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_140(object P0, object P1, object P2, bool P3, out bool P4, bool P5); // TypeDefIndex: 74887; 0x0000000184161980-0x00000001841619B0

	public delegate IBindingView __HotPatchDelegate_141(object P0); // TypeDefIndex: 74888; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate PlayerActionInfo __HotPatchDelegate_142(object P0); // TypeDefIndex: 74889; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_143(object P0, object P1, bool P2, bool P3); // TypeDefIndex: 74890; 0x0000000181217F60-0x0000000181217F80

	public delegate UIActionKeyHint.KeyHintSnapshot __HotPatchDelegate_144(object P0); // TypeDefIndex: 74891; 0x00000001826DF910-0x00000001826DF960

	public delegate bool __HotPatchDelegate_145(object P0, in UIActionKeyHint.KeyHintSnapshot P1); // TypeDefIndex: 74892; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_146(object P0, in UIActionKeyHint.KeyHintSnapshot P1); // TypeDefIndex: 74893; 0x00000001859B7730-0x00000001859B7740

	public delegate UnityEngine.Color __HotPatchDelegate_147(UIActionKeyHint.HintVisibility P0); // TypeDefIndex: 74894; 0x0000000186464680-0x00000001864646B0

	public delegate void __HotPatchDelegate_148(object P0, UIActionKeyHint.HintVisibility P1, bool P2); // TypeDefIndex: 74895; 0x00000001811DF7F0-0x00000001811DF810

	public delegate UIActionKeyHint.HintVisibility __HotPatchDelegate_149(object P0); // TypeDefIndex: 74896; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIActionKeyHint.HintVisibility __HotPatchDelegate_150(object P0, BindingViewState P1); // TypeDefIndex: 74897; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_151(object P0, out UIActionKeyHint.HintVisibility P1, out bool P2); // TypeDefIndex: 74898; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_152(Beyond.DeviceInfo.ControllerType P0); // TypeDefIndex: 74899; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_153(object P0, in EventData<string> P1); // TypeDefIndex: 74900; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_154(object P0, object P1, object P2, bool P3); // TypeDefIndex: 74901; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_155(object P0, int P1, object P2, object P3, bool P4); // TypeDefIndex: 74902; 0x000000018129F400-0x000000018129F420

	public delegate bool __HotPatchDelegate_156(object P0, object P1, bool P2, bool P3); // TypeDefIndex: 74903; 0x0000000181217F60-0x0000000181217F80

	public delegate AnimationClip __HotPatchDelegate_157(object P0, object P1, bool P2); // TypeDefIndex: 74904; 0x00000001811DF7F0-0x00000001811DF810

	public delegate AnimationClip __HotPatchDelegate_158(object P0, object P1); // TypeDefIndex: 74905; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_159(object P0, UIAnimationWrapper.FOptions P1); // TypeDefIndex: 74906; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_160(object P0, object P1, object P2, UIConst.AnimationState P3, float P4, bool P5); // TypeDefIndex: 74907; 0x000000018121C6C0-0x000000018121C6E0

	public delegate UIAnimationWrapper.FOptions __HotPatchDelegate_161(); // TypeDefIndex: 74908; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_162(object P0, object P1, object P2, float P3); // TypeDefIndex: 74909; 0x00000001811CDB70-0x00000001811CDB90

	public delegate UISwitchTween.ITweenHandler __HotPatchDelegate_163(object P0); // TypeDefIndex: 74910; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UISwitchTween.ITweenHandler __HotPatchDelegate_164(object P0, object P1); // TypeDefIndex: 74911; 0x00000001859B7730-0x00000001859B7740

	public delegate UISwitchTween.ITweenHandler __HotPatchDelegate_165(object P0, bool P1); // TypeDefIndex: 74912; 0x00000001859B7730-0x00000001859B7740

	public delegate UIAnimationSwitchTween __HotPatchDelegate_166(ref UIAnimationSwitchTween.Builder P0); // TypeDefIndex: 74913; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Vector2 __HotPatchDelegate_167(); // TypeDefIndex: 74914; 0x0000000185B44B70-0x0000000185B44B80

	public delegate Camera __HotPatchDelegate_168(object P0); // TypeDefIndex: 74915; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_169(object P0, object P1, bool P2, bool P3, bool P4, bool P5, bool P6, float P7); // TypeDefIndex: 74916; 0x00000001811DD5E0-0x00000001811DD620

	public delegate void __HotPatchDelegate_170(object P0, bool P1, bool P2, bool P3, bool P4, float P5); // TypeDefIndex: 74917; 0x0000000181293A00-0x0000000181293A30

	public delegate IEnumerator __HotPatchDelegate_171(object P0, object P1); // TypeDefIndex: 74918; 0x00000001859B7730-0x00000001859B7740

	public delegate DisposedUnityEvent __HotPatchDelegate_172(object P0); // TypeDefIndex: 74919; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate DisposedUnityEvent<int, bool> __HotPatchDelegate_173(object P0); // TypeDefIndex: 74920; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UITouchPanel __HotPatchDelegate_174(object P0); // TypeDefIndex: 74921; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_175(object P0, out Vector2 P1, out Vector2 P2); // TypeDefIndex: 74922; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Vector2 __HotPatchDelegate_176(object P0, Vector2 P1); // TypeDefIndex: 74923; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_177(object P0, Vector3 P1); // TypeDefIndex: 74924; 0x0000000186036470-0x00000001860364A0

	public delegate void __HotPatchDelegate_178(object P0, bool P1, float P2, object P3, object P4); // TypeDefIndex: 74925; 0x00000001811DB3F0-0x00000001811DB410

	public delegate void __HotPatchDelegate_179(object P0, bool P1, out Selectable P2, out UITouchPanel P3); // TypeDefIndex: 74926; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_180(object P0, float P1, float P2, object P3); // TypeDefIndex: 74927; 0x00000001812250A0-0x00000001812250C0

	public delegate void __HotPatchDelegate_181(object P0, object P1, bool P2, object P3); // TypeDefIndex: 74928; 0x00000001811CDB70-0x00000001811CDB90

	public delegate UIBigRectHelper.BigRectRecoverState __HotPatchDelegate_182(object P0); // TypeDefIndex: 74929; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_183(object P0, out float P1, out float P2); // TypeDefIndex: 74930; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_184(object P0, object P1, UnityEngine.Color P2); // TypeDefIndex: 74931; 0x0000000181499900-0x0000000181499930

	public delegate Canvas __HotPatchDelegate_185(object P0); // TypeDefIndex: 74932; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate HGCamera __HotPatchDelegate_186(object P0); // TypeDefIndex: 74933; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate RawImage __HotPatchDelegate_187(object P0); // TypeDefIndex: 74934; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Vector2 __HotPatchDelegate_188(object P0); // TypeDefIndex: 74935; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IBindingGroupTarget __HotPatchDelegate_189(object P0); // TypeDefIndex: 74936; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_190(object P0, object P1); // TypeDefIndex: 74937; 0x00000001859B7730-0x00000001859B7740

	public delegate BindingViewState __HotPatchDelegate_191(object P0); // TypeDefIndex: 74938; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate string __HotPatchDelegate_192(object P0, BindingViewActionType P1); // TypeDefIndex: 74939; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_193(object P0, out string P1, out string P2); // TypeDefIndex: 74940; 0x00000001811DF7F0-0x00000001811DF810

	public delegate ActionOnSetNaviTarget __HotPatchDelegate_194(object P0); // TypeDefIndex: 74941; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_195(object P0, ActionOnSetNaviTarget P1); // TypeDefIndex: 74942; 0x00000001859B7730-0x00000001859B7740

	public delegate HashSet<CanvasScaler> __HotPatchDelegate_196(object P0); // TypeDefIndex: 74943; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_197(out Vector2 P0); // TypeDefIndex: 74944; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UICanvasScaleHelper.FWorldCanvasParams __HotPatchDelegate_198(object P0, object P1, bool P2); // TypeDefIndex: 74945; 0x0000000184162A10-0x0000000184162A60

	public delegate UICanvasScaleHelper.FScreenCanvasParams __HotPatchDelegate_199(); // TypeDefIndex: 74946; 0x00000001848FF780-0x00000001848FF7C0

	public delegate void __HotPatchDelegate_200(object P0, UIColorGroup.CommonParams P1); // TypeDefIndex: 74947; 0x00000001827C6B90-0x00000001827C6BC0

	public delegate void __HotPatchDelegate_201(object P0, object P1, UIColorGroup.CommonParams P2); // TypeDefIndex: 74948; 0x00000001826DFA90-0x00000001826DFAD0

	public delegate void __HotPatchDelegate_202(object P0, float P1, float P2, bool P3); // TypeDefIndex: 74949; 0x00000001826DFD20-0x00000001826DFD40

	public delegate void __HotPatchDelegate_203(object P0, UnityEngine.Color P1, float P2, bool P3, bool P4, bool P5); // TypeDefIndex: 74950; 0x0000000184E4D200-0x0000000184E4D250

	public delegate void __HotPatchDelegate_204(object P0, UnityEngine.Color P1, float P2, bool P3, bool P4); // TypeDefIndex: 74951; 0x0000000184E4D250-0x0000000184E4D2A0

	public delegate void __HotPatchDelegate_205(object P0, GamepadKeyCode P1); // TypeDefIndex: 74952; 0x00000001859B7730-0x00000001859B7740

	public delegate UICustomLayoutElement __HotPatchDelegate_206(object P0); // TypeDefIndex: 74953; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UICustomLayoutElement.LayoutType __HotPatchDelegate_207(object P0); // TypeDefIndex: 74954; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_208(object P0, out UICustomLayoutElement.LayoutData P1, bool P2, int P3); // TypeDefIndex: 74955; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_209(object P0, out UICustomLayoutElement.LayoutData P1, int P2); // TypeDefIndex: 74956; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_210(object P0, UICustomLayoutElement.LayoutType P1); // TypeDefIndex: 74957; 0x00000001859B7730-0x00000001859B7740

	public delegate CanvasGroup __HotPatchDelegate_211(object P0); // TypeDefIndex: 74958; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIDialogText __HotPatchDelegate_212(object P0); // TypeDefIndex: 74959; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_213(object P0, bool P1, object P2); // TypeDefIndex: 74960; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_214(object P0, object P1, object P2, object P3); // TypeDefIndex: 74961; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_215(object P0, int P1, bool P2, bool P3, bool P4); // TypeDefIndex: 74962; 0x00000001826DF690-0x00000001826DF6C0

	public delegate void __HotPatchDelegate_216(object P0, Vector2 P1, bool P2); // TypeDefIndex: 74963; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_217(object P0, Vector2 P1, bool P2, bool P3); // TypeDefIndex: 74964; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_218(object P0, object P1, bool P2, bool P3); // TypeDefIndex: 74965; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_219(object P0, int P1, int P2, bool P3); // TypeDefIndex: 74966; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_220(float P0); // TypeDefIndex: 74967; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_221(object P0, bool P1, int P2); // TypeDefIndex: 74968; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_222(object P0, bool P1, float P2, float P3); // TypeDefIndex: 74969; 0x000000018129E8F0-0x000000018129E910

	public delegate void __HotPatchDelegate_223(object P0, Rect P1); // TypeDefIndex: 74970; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate float __HotPatchDelegate_224(object P0, object P1, bool P2); // TypeDefIndex: 74971; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Vector3 __HotPatchDelegate_225(object P0); // TypeDefIndex: 74972; 0x0000000185D32980-0x0000000185D329C0

	public delegate Transform __HotPatchDelegate_226(object P0); // TypeDefIndex: 74973; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_227(object P0, int P1, float P2); // TypeDefIndex: 74974; 0x000000018124EAD0-0x000000018124EAF0

	public delegate bool __HotPatchDelegate_228(object P0, bool P1, bool P2); // TypeDefIndex: 74975; 0x00000001811DF7F0-0x00000001811DF810

	public delegate Selectable __HotPatchDelegate_229(object P0, bool P1); // TypeDefIndex: 74976; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_230(object P0, int P1, int P2, bool P3, bool P4); // TypeDefIndex: 74977; 0x00000001826DF690-0x00000001826DF6C0

	public delegate bool __HotPatchDelegate_231(object P0, NaviDirection P1, bool P2); // TypeDefIndex: 74978; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_232(object P0, NaviDirection P1); // TypeDefIndex: 74979; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_233(object P0, NaviDirection P1); // TypeDefIndex: 74980; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_234(object P0, int P1, out int P2, out bool P3, out int P4); // TypeDefIndex: 74981; 0x00000001812083C0-0x00000001812083E0

	public delegate bool __HotPatchDelegate_235(object P0, int P1, out int P2, out int P3); // TypeDefIndex: 74982; 0x00000001811CDB70-0x00000001811CDB90

	public delegate int __HotPatchDelegate_236(object P0, int P1, int P2, UIScrollList.ScrollAlignType P3); // TypeDefIndex: 74983; 0x00000001811CDB70-0x00000001811CDB90

	public delegate int __HotPatchDelegate_237(object P0, int P1, UIScrollList.ScrollAlignType P2); // TypeDefIndex: 74984; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_238(object P0, int P1, out int P2, out int P3); // TypeDefIndex: 74985; 0x00000001811CDB70-0x00000001811CDB90

	public delegate Vector2Int __HotPatchDelegate_239(object P0, Vector2Int P1); // TypeDefIndex: 74986; 0x00000001859B7730-0x00000001859B7740

	public delegate Vector2Int __HotPatchDelegate_240(object P0, Vector2Int P1, Vector2Int P2); // TypeDefIndex: 74987; 0x00000001811DF7F0-0x00000001811DF810

	public delegate ValueTuple<float, float> __HotPatchDelegate_241(object P0); // TypeDefIndex: 74988; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_242(object P0, bool P1); // TypeDefIndex: 74989; 0x00000001859B7730-0x00000001859B7740

	public delegate GameObject __HotPatchDelegate_243(object P0, int P1); // TypeDefIndex: 74990; 0x00000001859B7730-0x00000001859B7740

	public delegate UIScrollList.Cell __HotPatchDelegate_244(object P0, int P1); // TypeDefIndex: 74991; 0x00000001859B7730-0x00000001859B7740

	public delegate float __HotPatchDelegate_245(object P0, int P1, UIScrollList.ScrollAlignType P2); // TypeDefIndex: 74992; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_246(object P0, int P1, bool P2, UIScrollList.ScrollAlignType P3); // TypeDefIndex: 74993; 0x00000001811CDB70-0x00000001811CDB90

	public delegate int __HotPatchDelegate_247(object P0, NaviDirection P1); // TypeDefIndex: 74994; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_248(object P0, int P1, NaviDirection P2); // TypeDefIndex: 74995; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_249(object P0, NaviDirection P1, out bool P2); // TypeDefIndex: 74996; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_250(object P0, out int P1, out UIScrollList.Cell P2); // TypeDefIndex: 74997; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_251(object P0, object P1, NaviDirection P2); // TypeDefIndex: 74998; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_252(object P0, NaviDirection P1, int P2, bool P3, out int P4); // TypeDefIndex: 74999; 0x00000001826EA060-0x00000001826EA080

	public delegate bool __HotPatchDelegate_253(object P0, int P1, bool P2); // TypeDefIndex: 75000; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_254(object P0, NaviDirection P1, int P2, bool P3); // TypeDefIndex: 75001; 0x0000000181217F60-0x0000000181217F80

	public delegate bool __HotPatchDelegate_255(object P0, ref int P1, bool P2); // TypeDefIndex: 75002; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_256(object P0, int P1, int P2, bool P3, bool P4, bool P5, UIScrollList.ScrollAlignType P6); // TypeDefIndex: 75003; 0x0000000184175920-0x0000000184175950

	public delegate void __HotPatchDelegate_257(object P0, int P1, bool P2, bool P3, bool P4, bool P5); // TypeDefIndex: 75004; 0x00000001812864A0-0x00000001812864D0

	public delegate void __HotPatchDelegate_258(object P0, int P1, int P2, int P3); // TypeDefIndex: 75005; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_259(object P0, int P1, int? P2); // TypeDefIndex: 75006; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_260(object P0, int P1); // TypeDefIndex: 75007; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_261(object P0, int P1, int P2, bool P3, UIScrollList.ScrollAlignType P4, bool P5); // TypeDefIndex: 75008; 0x0000000184161980-0x00000001841619B0

	public delegate Vector2Int __HotPatchDelegate_262(object P0, float P1); // TypeDefIndex: 75009; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_263(object P0, int P1, int P2, int P3); // TypeDefIndex: 75010; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_264(object P0, object P1, int P2, int P3); // TypeDefIndex: 75011; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_265(object P0, Vector2Int P1, bool P2, bool P3); // TypeDefIndex: 75012; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_266(object P0, object P1, bool P2, int P3, int P4); // TypeDefIndex: 75013; 0x00000001812083C0-0x00000001812083E0

	public delegate void __HotPatchDelegate_267(object P0, bool P1, int P2, int P3, int P4, bool P5, bool P6); // TypeDefIndex: 75014; 0x0000000184172110-0x0000000184172140

	public delegate int __HotPatchDelegate_268(object P0, int P1, int P2, int P3); // TypeDefIndex: 75015; 0x00000001811CDB70-0x00000001811CDB90

	public delegate GameObject __HotPatchDelegate_269(object P0, int P1, int P2); // TypeDefIndex: 75016; 0x00000001811DF7F0-0x00000001811DF810

	public delegate ref UIAtlasManager.UIAtlasHandle __HotPatchDelegate_270(object P0); // TypeDefIndex: 75017; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIAtlasManager.UIAtlasHandle __HotPatchDelegate_271(UIAtlasManager.UIAtlasProcessFailureCause P0); // TypeDefIndex: 75018; 0x000000018124C690-0x000000018124C6D0

	public delegate Texture __HotPatchDelegate_272(object P0); // TypeDefIndex: 75019; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate TweenerCore<float, float, FloatOptions> __HotPatchDelegate_273(object P0, float P1, float P2); // TypeDefIndex: 75020; 0x000000018238E680-0x000000018238E6A0

	public delegate UIImage __HotPatchDelegate_274(object P0); // TypeDefIndex: 75021; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_275(ref UIInertiaViewPager.ScrollEffectConfig P0); // TypeDefIndex: 75022; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIInertiaViewPager.State __HotPatchDelegate_276(object P0, object P1); // TypeDefIndex: 75023; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_277(ref UIInertiaViewPager.InertiaBlocker P0, float P1); // TypeDefIndex: 75024; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_278(object P0, float P1, out float P2); // TypeDefIndex: 75025; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_279(object P0, float P1, float P2); // TypeDefIndex: 75026; 0x000000018238E680-0x000000018238E6A0

	public delegate void __HotPatchDelegate_280(object P0, UIInertiaViewPager.State P1, UIInertiaViewPager.State P2); // TypeDefIndex: 75027; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_281(object P0, int P1, object P2); // TypeDefIndex: 75028; 0x00000001811DF7F0-0x00000001811DF810

	public delegate float __HotPatchDelegate_282(ref UIInertiaViewPager.EmptyScrollHandler P0); // TypeDefIndex: 75029; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_283(ref UIInertiaViewPager.EmptyScrollHandler P0); // TypeDefIndex: 75030; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_284(ref UIInertiaViewPager.EmptyScrollHandler P0, float P1); // TypeDefIndex: 75031; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_285(ref UIInertiaViewPager.EmptyScrollHandler P0); // TypeDefIndex: 75032; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIInputField __HotPatchDelegate_286(); // TypeDefIndex: 75033; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_287(object P0, bool P1, Vector2 P2, Vector2 P3); // TypeDefIndex: 75034; 0x00000001826E9A70-0x00000001826E9A90

	public delegate void __HotPatchDelegate_288(object P0, CanvasUpdate P1); // TypeDefIndex: 75035; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_289(object P0, object P1, object P2, object P3, object P4); // TypeDefIndex: 75036; 0x00000001812083C0-0x00000001812083E0

	public delegate UIMaterialAnimation.EPropKind __HotPatchDelegate_290(int P0); // TypeDefIndex: 75037; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Vector4 __HotPatchDelegate_291(object P0, int P1); // TypeDefIndex: 75038; 0x00000001812C43A0-0x00000001812C43E0

	public delegate void __HotPatchDelegate_292(object P0, object P1, bool P2, bool P3, bool P4); // TypeDefIndex: 75039; 0x00000001826DF690-0x00000001826DF6C0

	public delegate List<int> __HotPatchDelegate_293(object P0); // TypeDefIndex: 75040; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate List<bool> __HotPatchDelegate_294(object P0); // TypeDefIndex: 75041; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_295(object P0, int P1, object P2, bool P3); // TypeDefIndex: 75042; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_296(object P0, float P1, float P2, float P3); // TypeDefIndex: 75043; 0x00000001812250A0-0x00000001812250C0

	public delegate MaterialPropertyBlock __HotPatchDelegate_297(); // TypeDefIndex: 75044; 0x0000000185B44B70-0x0000000185B44B80

	public delegate bool __HotPatchDelegate_298(object P0, Vector3 P1); // TypeDefIndex: 75045; 0x0000000186036470-0x00000001860364A0

	public delegate float __HotPatchDelegate_299(object P0, Vector2 P1); // TypeDefIndex: 75046; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_300(object P0, float P1); // TypeDefIndex: 75047; 0x00000001859B7730-0x00000001859B7740

	public delegate UIScrollList.Padding __HotPatchDelegate_301(object P0, bool P1); // TypeDefIndex: 75048; 0x00000001812C43A0-0x00000001812C43E0

	public delegate void __HotPatchDelegate_302(object P0, out int P1, out int P2); // TypeDefIndex: 75049; 0x00000001811DF7F0-0x00000001811DF810

	public delegate int __HotPatchDelegate_303(object P0, Vector2 P1, NaviDirection P2); // TypeDefIndex: 75050; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_304(object P0, Vector2 P1, out int P2, out int P3); // TypeDefIndex: 75051; 0x00000001811CDB70-0x00000001811CDB90

	public delegate UIScrollRect.MoveTipsType __HotPatchDelegate_305(object P0); // TypeDefIndex: 75052; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_306(object P0, object P1, object P2, UIScrollRectEdgeRedDot.ERedDotState P3); // TypeDefIndex: 75053; 0x00000001811CDB70-0x00000001811CDB90

	public delegate UIScrollRectEdgeRedDot.ERedDotState __HotPatchDelegate_307(object P0); // TypeDefIndex: 75054; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Rect __HotPatchDelegate_308(object P0); // TypeDefIndex: 75055; 0x0000000186464680-0x00000001864646B0

	public delegate bool __HotPatchDelegate_309(object P0, UIScrollRectEdgeRedDot.ERedDotState P1, UIScrollRectEdgeRedDot.ERedDotDir P2, object P3); // TypeDefIndex: 75056; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_310(object P0, out UIScrollRectEdgeRedDot.ERedDotState P1, out UIScrollRectEdgeRedDot.ERedDotState P2); // TypeDefIndex: 75057; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_311(object P0, bool P1, float P2); // TypeDefIndex: 75058; 0x000000018124EAD0-0x000000018124EAF0

	public delegate Vector3 __HotPatchDelegate_312(object P0, int P1); // TypeDefIndex: 75059; 0x0000000186AEB300-0x0000000186AEB340

	public delegate Vector3[] __HotPatchDelegate_313(object P0); // TypeDefIndex: 75060; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Vector4 __HotPatchDelegate_314(object P0); // TypeDefIndex: 75061; 0x0000000186464680-0x00000001864646B0

	public delegate Vector4 __HotPatchDelegate_315(Vector4 P0, Rect P1, Rect P2); // TypeDefIndex: 75062; 0x0000000184E4D2A0-0x0000000184E4D310

	public delegate Vector2 __HotPatchDelegate_316(Vector2 P0, Vector4 P1); // TypeDefIndex: 75063; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate UISoftMask.SlicedSpriteParams __HotPatchDelegate_317(object P0); // TypeDefIndex: 75064; 0x000000018124C690-0x000000018124C6D0

	public delegate Graphic __HotPatchDelegate_318(object P0); // TypeDefIndex: 75065; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UISoftMask __HotPatchDelegate_319(object P0); // TypeDefIndex: 75066; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_320(object P0, float P1, float P2); // TypeDefIndex: 75067; 0x000000018238E680-0x000000018238E6A0

	public delegate Vector2 __HotPatchDelegate_321(object P0, Vector2 P1, Vector2 P2, Vector2 P3, Vector2 P4); // TypeDefIndex: 75068; 0x000000018416E070-0x000000018416E0A0

	public delegate void __HotPatchDelegate_322(object P0, Vector2 P1, Vector2 P2, Vector2 P3, Vector2 P4, out float P5, out float P6); // TypeDefIndex: 75069; 0x0000000184E4D310-0x0000000184E4D340

	public delegate void __HotPatchDelegate_323(ref UIVertex P0, Vector2 P1, Vector2 P2, Vector2 P3); // TypeDefIndex: 75070; 0x00000001826E9A70-0x00000001826E9A90

	public delegate void __HotPatchDelegate_324(object P0, object P1, object P2, out bool P3); // TypeDefIndex: 75071; 0x00000001811CDB70-0x00000001811CDB90

	public delegate UISoftMaskable __HotPatchDelegate_325(object P0); // TypeDefIndex: 75072; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate IEnumerator __HotPatchDelegate_326(object P0, bool P1, int P2); // TypeDefIndex: 75073; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_327(object P0, bool P1, int P2); // TypeDefIndex: 75074; 0x00000001811DF7F0-0x00000001811DF810

	public delegate void __HotPatchDelegate_328(object P0, object P1, bool P2, object P3, object P4, object P5, bool P6); // TypeDefIndex: 75075; 0x00000001812CACE0-0x00000001812CAD00

	public delegate uint __HotPatchDelegate_329(object P0); // TypeDefIndex: 75076; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_330(uint P0, bool P1); // TypeDefIndex: 75077; 0x00000001859B7730-0x00000001859B7740

	public delegate TMP_FontAsset __HotPatchDelegate_331(object P0, object P1); // TypeDefIndex: 75078; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_332(object P0, object P1, uint P2, out TMP_FontAsset P3); // TypeDefIndex: 75079; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_333(ref float P0, float P1); // TypeDefIndex: 75080; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_334(ref TweenUtils.FLerpByTime P0, object P1); // TypeDefIndex: 75081; 0x00000001859B7730-0x00000001859B7740

	public delegate float __HotPatchDelegate_335(ref TweenUtils.FLerpByTime P0, out bool P1); // TypeDefIndex: 75082; 0x00000001859B7730-0x00000001859B7740

	public delegate PlayableGraph __HotPatchDelegate_336(object P0); // TypeDefIndex: 75083; 0x0000000186464680-0x00000001864646B0

	public delegate AnimationLayerMixerPlayable __HotPatchDelegate_337(object P0, PlayableGraph P1, out GenericShareSingleMixerAssetPlayer<AnimationClip> P2); // TypeDefIndex: 75084; 0x000000018415E9E0-0x000000018415EA30

	public delegate AnimationPlayableOutput __HotPatchDelegate_338(object P0, PlayableGraph P1); // TypeDefIndex: 75085; 0x0000000181235100-0x0000000181235140

	public delegate AnimationClipPlayable __HotPatchDelegate_339(object P0, object P1, PlayableGraph P2, out GenericShareSingleMixerAssetPlayer<AnimationClip> P3); // TypeDefIndex: 75086; 0x0000000184E4D340-0x0000000184E4D3A0

	public delegate AnimationMixerPlayable __HotPatchDelegate_340(object P0, PlayableGraph P1, out GenericShareSingleMixerAssetPlayer<AnimationClip> P2); // TypeDefIndex: 75087; 0x000000018415E9E0-0x000000018415EA30

	public delegate void __HotPatchDelegate_341(ref UISwitchTween.TweenContext P0); // TypeDefIndex: 75088; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_342(ref UISwitchTween.TweenContext P0, object P1); // TypeDefIndex: 75089; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_343(object P0, UISwitchTween.Options P1); // TypeDefIndex: 75090; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate UISwitchTween.TweenContext __HotPatchDelegate_344(object P0); // TypeDefIndex: 75091; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_345(ref UISwitchTween.TweenContext P0); // TypeDefIndex: 75092; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate float __HotPatchDelegate_346(ref FadeSwitchTween.Durations P0, float P1); // TypeDefIndex: 75093; 0x00000001859B7730-0x00000001859B7740

	public delegate FadeSwitchTween __HotPatchDelegate_347(ref FadeSwitchTween.Builder P0); // TypeDefIndex: 75094; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate Vector2 __HotPatchDelegate_348(object P0, bool P1); // TypeDefIndex: 75095; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_349(object P0, in RectInt P1); // TypeDefIndex: 75096; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_350(object P0, object P1, out UIAtlasManager.UIAtlasProcessFailureCause P2); // TypeDefIndex: 75097; 0x00000001811DF7F0-0x00000001811DF810

	public delegate RectInt __HotPatchDelegate_351(object P0, int P1, int P2); // TypeDefIndex: 75098; 0x00000001812D51A0-0x00000001812D51E0

	public delegate void __HotPatchDelegate_352(object P0, object P1, object P2, in RectInt P3); // TypeDefIndex: 75099; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_353(ref UIAtlasManager.UIAtlasHandle P0); // TypeDefIndex: 75100; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_354(object P0, in List<RectInt> P1); // TypeDefIndex: 75101; 0x00000001859B7730-0x00000001859B7740

	public delegate UIMaterialAnimation __HotPatchDelegate_355(object P0); // TypeDefIndex: 75102; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate UIAnimationWrapper __HotPatchDelegate_356(object P0); // TypeDefIndex: 75103; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate byte __HotPatchDelegate_357(UnityEngine.WrapMode P0); // TypeDefIndex: 75104; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate byte __HotPatchDelegate_358(int P0, bool P1); // TypeDefIndex: 75105; 0x00000001859B7730-0x00000001859B7740

	public delegate GPUIExtendedPrefabData __HotPatchDelegate_359(Vector4 P0, Vector4 P1, Vector2 P2); // TypeDefIndex: 75106; 0x0000000184E4D3A0-0x0000000184E4D430

	public delegate GPUIExtendedPrefabDataLite __HotPatchDelegate_360(Vector4 P0, Vector4 P1, Vector2 P2); // TypeDefIndex: 75107; 0x0000000184E4D430-0x0000000184E4D4B0

	public delegate GPUIRootTransformState __HotPatchDelegate_361(); // TypeDefIndex: 75108; 0x00000001826DF800-0x00000001826DF840

	public delegate GPUISubrootDomainState __HotPatchDelegate_362(); // TypeDefIndex: 75109; 0x000000018416DFB0-0x000000018416DFF0

	public delegate GPUIExtendedAnimationState __HotPatchDelegate_363(); // TypeDefIndex: 75110; 0x0000000185378C70-0x0000000185378CA0

	public delegate GPUIResolvedSubrootState __HotPatchDelegate_364(in GPUIRootTransformState P0, in GPUISubrootDomainState P1); // TypeDefIndex: 75111; 0x0000000184E4D4B0-0x0000000184E4D500

	public delegate uint __HotPatchDelegate_365(ushort P0, ushort P1); // TypeDefIndex: 75112; 0x00000001859B7730-0x00000001859B7740

	public delegate uint __HotPatchDelegate_366(ushort P0, byte P1, byte P2); // TypeDefIndex: 75113; 0x00000001811DF7F0-0x00000001811DF810

	public delegate uint __HotPatchDelegate_367(float P0); // TypeDefIndex: 75114; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_368(byte P0); // TypeDefIndex: 75115; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate int __HotPatchDelegate_369(float P0); // TypeDefIndex: 75116; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate short __HotPatchDelegate_370(float P0); // TypeDefIndex: 75117; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_371(Quaternion P0, out int P1, out int P2); // TypeDefIndex: 75118; 0x00000001826DF9A0-0x00000001826DF9D0

	public delegate GPUPrefabData __HotPatchDelegate_372(Vector4 P0, Vector4 P1, Vector2 P2); // TypeDefIndex: 75119; 0x0000000184E4D500-0x0000000184E4D590

	public delegate GPUPrefabDataLite __HotPatchDelegate_373(Vector4 P0, Vector4 P1, Vector2 P2); // TypeDefIndex: 75120; 0x0000000184E4D430-0x0000000184E4D4B0

	public delegate uint __HotPatchDelegate_374(uint P0, uint P1); // TypeDefIndex: 75121; 0x00000001859B7730-0x00000001859B7740

	public delegate Texture2D __HotPatchDelegate_375(object P0); // TypeDefIndex: 75122; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate RectInt __HotPatchDelegate_376(object P0); // TypeDefIndex: 75123; 0x0000000186464680-0x00000001864646B0

	public delegate bool __HotPatchDelegate_377(object P0, object P1, RectInt P2); // TypeDefIndex: 75124; 0x0000000181499900-0x0000000181499930

	public delegate bool __HotPatchDelegate_378(object P0, UICustomAtlasCopyStatus P1); // TypeDefIndex: 75125; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_379(object P0, GPUIExtendedDynamicAtlas.DynamicAtlasFailureCause P1); // TypeDefIndex: 75126; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_380(object P0, object P1, RectInt P2); // TypeDefIndex: 75127; 0x0000000181499900-0x0000000181499930

	public delegate GPUIExtendedDynamicAtlas.DynamicSpriteHandle __HotPatchDelegate_381(); // TypeDefIndex: 75128; 0x0000000185378C70-0x0000000185378CA0

	public delegate bool __HotPatchDelegate_382(object P0, object P1, out GPUIExtendedDynamicAtlas.DynamicAtlasFailureCause P2); // TypeDefIndex: 75129; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_383(object P0, object P1, out GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2, out Vector4 P3); // TypeDefIndex: 75130; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_384(ref GPUIExtendedDynamicAtlas.DynamicSpriteHandle P0); // TypeDefIndex: 75131; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_385(object P0, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P1, out bool P2); // TypeDefIndex: 75132; 0x0000000181256E30-0x0000000181256E60

	public delegate bool __HotPatchDelegate_386(object P0, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P1); // TypeDefIndex: 75133; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate UICustomAtlasCopyStatus __HotPatchDelegate_387(object P0); // TypeDefIndex: 75134; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_388(object P0, object P1, Vector4 P2); // TypeDefIndex: 75135; 0x0000000181499900-0x0000000181499930

	public delegate void __HotPatchDelegate_389(ref GPUIExtendedPrefabDataLite P0, Vector4 P1, Vector2 P2); // TypeDefIndex: 75136; 0x0000000181256E30-0x0000000181256E60

	public delegate bool __HotPatchDelegate_390(object P0, int P1, object P2, out GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P3, out ushort P4); // TypeDefIndex: 75137; 0x00000001812083C0-0x00000001812083E0

	public delegate void __HotPatchDelegate_391(object P0, GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P1); // TypeDefIndex: 75138; 0x00000001826DF780-0x00000001826DF7C0

	public delegate bool __HotPatchDelegate_392(ref GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P0, GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P1); // TypeDefIndex: 75139; 0x00000001826DF780-0x00000001826DF7C0

	public delegate bool __HotPatchDelegate_393(ref GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P0, object P1); // TypeDefIndex: 75140; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_394(ref GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P0); // TypeDefIndex: 75141; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_395(object P0, object P1, out GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2); // TypeDefIndex: 75142; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_396(object P0, int P1, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2, out GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P3, out ushort P4); // TypeDefIndex: 75143; 0x000000018416D3C0-0x000000018416D410

	public delegate bool __HotPatchDelegate_397(object P0, GPUIExtendedDynamicPrefabNodeManager.DynamicPrefabNodeKey P1, int P2, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P3); // TypeDefIndex: 75144; 0x0000000184E4D590-0x0000000184E4D5F0

	public delegate void __HotPatchDelegate_398(object P0, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P1); // TypeDefIndex: 75145; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate GPUIExtendedRuntimePrefabData __HotPatchDelegate_399(object P0); // TypeDefIndex: 75146; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate GPUIExtendedRuntimeAnimationData __HotPatchDelegate_400(object P0, int P1); // TypeDefIndex: 75147; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_401(in GPUIExtendedRuntimeInstance.SpriteOverrideState P0); // TypeDefIndex: 75148; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_402(object P0, in GPUIExtendedRuntimeInstance.SpriteOverrideState P1); // TypeDefIndex: 75149; 0x00000001859B7730-0x00000001859B7740

	public delegate void __HotPatchDelegate_403(object P0, ref NativeArray<GPUIExtendedInstanceData> P1, int P2, ref int P3, GPUIExtendedInstanceData P4); // TypeDefIndex: 75150; 0x000000018415FBF0-0x000000018415FC40

	public delegate void __HotPatchDelegate_404(object P0, ref NativeArray<GPUIExtendedInstanceData> P1, int P2, ref int P3); // TypeDefIndex: 75151; 0x00000001811CDB70-0x00000001811CDB90

	public delegate GPUIExtendedAnimationState __HotPatchDelegate_405(object P0, in GPUIExtendedRuntimeNodeInfo P1); // TypeDefIndex: 75152; 0x00000001812C43A0-0x00000001812C43E0

	public delegate uint __HotPatchDelegate_406(uint P0); // TypeDefIndex: 75153; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_407(object P0, int P1, ref GPUIExtendedInstanceData P2); // TypeDefIndex: 75154; 0x00000001811DF7F0-0x00000001811DF810

	public delegate byte __HotPatchDelegate_408(float P0); // TypeDefIndex: 75155; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate void __HotPatchDelegate_409(object P0, ref NativeArray<GPUIExtendedInstanceData> P1, int P2, bool P3); // TypeDefIndex: 75156; 0x0000000181217F60-0x0000000181217F80

	public delegate void __HotPatchDelegate_410(object P0, Quaternion P1); // TypeDefIndex: 75157; 0x00000001857E4CE0-0x00000001857E4D10

	public delegate void __HotPatchDelegate_411(object P0, float P1, int P2); // TypeDefIndex: 75158; 0x000000018238E680-0x000000018238E6A0

	public delegate bool __HotPatchDelegate_412(object P0, int P1, float P2, int P3); // TypeDefIndex: 75159; 0x000000018129E8F0-0x000000018129E910

	public delegate uint __HotPatchDelegate_413(UnityEngine.Color P0); // TypeDefIndex: 75160; 0x0000000186A4F2D0-0x0000000186A4F300

	public delegate void __HotPatchDelegate_414(object P0, int P1, UnityEngine.Color P2); // TypeDefIndex: 75161; 0x0000000181499900-0x0000000181499930

	public delegate void __HotPatchDelegate_415(object P0, int P1, Vector2 P2, Vector2 P3, float P4); // TypeDefIndex: 75162; 0x0000000184E4D5F0-0x0000000184E4D610

	public delegate bool __HotPatchDelegate_416(object P0, int P1, out int P2); // TypeDefIndex: 75163; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_417(object P0, int P1, ref GPUIExtendedRuntimeInstance.SpriteOverrideState P2); // TypeDefIndex: 75164; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_418(object P0, int P1, ref GPUIExtendedRuntimeInstance.SpriteOverrideState P2, ref GPUIExtendedRuntimeInstance.SpriteOverrideState P3); // TypeDefIndex: 75165; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_419(object P0, int P1, GPUIExtendedDynamicAtlas.DynamicSpriteHandle P2); // TypeDefIndex: 75166; 0x0000000181499900-0x0000000181499930

	public delegate GPUIHandle __HotPatchDelegate_420(object P0); // TypeDefIndex: 75167; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_421(object P0, object P1, Vector3 P2, out GPUIHandle P3, int P4); // TypeDefIndex: 75168; 0x0000000184E4D610-0x0000000184E4D660

	public delegate bool __HotPatchDelegate_422(object P0, GPUIHandle P1); // TypeDefIndex: 75169; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_423(object P0, GPUIHandle P1, Vector3 P2); // TypeDefIndex: 75170; 0x0000000181271010-0x0000000181271050

	public delegate bool __HotPatchDelegate_424(object P0, GPUIHandle P1, Vector2 P2); // TypeDefIndex: 75171; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_425(object P0, GPUIHandle P1, Quaternion P2); // TypeDefIndex: 75172; 0x0000000181499900-0x0000000181499930

	public delegate bool __HotPatchDelegate_426(object P0, GPUIHandle P1, object P2, out GPUIExtendedRuntimeInstance P3, out int P4); // TypeDefIndex: 75173; 0x00000001812083C0-0x00000001812083E0

	public delegate bool __HotPatchDelegate_427(object P0, GPUIHandle P1, object P2, bool P3); // TypeDefIndex: 75174; 0x0000000181217F60-0x0000000181217F80

	public delegate bool __HotPatchDelegate_428(object P0, GPUIHandle P1, object P2, Vector2 P3, Vector2 P4, float P5); // TypeDefIndex: 75175; 0x0000000184E4D660-0x0000000184E4D690

	public delegate bool __HotPatchDelegate_429(object P0, GPUIHandle P1, object P2, UnityEngine.Color P3); // TypeDefIndex: 75176; 0x000000018415EC50-0x000000018415EC90

	public delegate bool __HotPatchDelegate_430(object P0, GPUIHandle P1, object P2, float P3); // TypeDefIndex: 75177; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_431(object P0, GPUIHandle P1, object P2, object P3); // TypeDefIndex: 75178; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_432(object P0, GPUIHandle P1, bool P2, int P3); // TypeDefIndex: 75179; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_433(object P0, GPUIHandle P1, bool P2, object P3); // TypeDefIndex: 75180; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_434(object P0, GPUIHandle P1, object P2, out float P3); // TypeDefIndex: 75181; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_435(object P0, GPUIHandle P1, object P2, object P3, out float P4); // TypeDefIndex: 75182; 0x00000001812083C0-0x00000001812083E0

	public delegate bool __HotPatchDelegate_436(object P0, object P1, out int P2, out int P3); // TypeDefIndex: 75183; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_437(object P0, bool P1, int P2, int P3); // TypeDefIndex: 75184; 0x00000001811CDB70-0x00000001811CDB90

	public delegate int __HotPatchDelegate_438(object P0, object P1, int P2); // TypeDefIndex: 75185; 0x00000001811DF7F0-0x00000001811DF810

	public delegate GPUIExtendedRuntimePrefabData __HotPatchDelegate_439(object P0, object P1); // TypeDefIndex: 75186; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_440(ref GPUIHandle P0, GPUIHandle P1); // TypeDefIndex: 75187; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_441(ref GPUIHandle P0, object P1); // TypeDefIndex: 75188; 0x00000001859B7730-0x00000001859B7740

	public delegate int __HotPatchDelegate_442(ref GPUIHandle P0); // TypeDefIndex: 75189; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_443(GPUIHandle P0, GPUIHandle P1); // TypeDefIndex: 75190; 0x00000001859B7730-0x00000001859B7740

	public delegate GPUIExtendedSystem __HotPatchDelegate_444(object P0); // TypeDefIndex: 75191; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate GPUIProxySyncManager __HotPatchDelegate_445(object P0); // TypeDefIndex: 75192; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_446(object P0, out RectTransform P1, out Camera P2); // TypeDefIndex: 75193; 0x00000001811DF7F0-0x00000001811DF810

	public delegate bool __HotPatchDelegate_447(object P0, object P1, object P2, object P3); // TypeDefIndex: 75194; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_448(object P0, bool P1); // TypeDefIndex: 75195; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_449(object P0, object P1, object P2, out Vector2 P3); // TypeDefIndex: 75196; 0x00000001811CDB70-0x00000001811CDB90

	public delegate bool __HotPatchDelegate_450(object P0, object P1, object P2, bool P3, Vector3 P4); // TypeDefIndex: 75197; 0x000000018122E4C0-0x000000018122E510

	public delegate bool __HotPatchDelegate_451(object P0, object P1, object P2, bool P3); // TypeDefIndex: 75198; 0x0000000181217F60-0x0000000181217F80

	public delegate bool __HotPatchDelegate_452(object P0, out GPUIExtendedSystem P1); // TypeDefIndex: 75199; 0x00000001859B7730-0x00000001859B7740

	public delegate bool __HotPatchDelegate_453(object P0, object P1, out GPUIHandle P2, int P3); // TypeDefIndex: 75200; 0x00000001811CDB70-0x00000001811CDB90

	public delegate void __HotPatchDelegate_454(object P0, int P1, Vector3 P2); // TypeDefIndex: 75201; 0x0000000181271010-0x0000000181271050

	public delegate void __HotPatchDelegate_455(object P0, GPUIHandle P1); // TypeDefIndex: 75202; 0x00000001859B7730-0x00000001859B7740

	public delegate RuntimePrefabData __HotPatchDelegate_456(object P0); // TypeDefIndex: 75203; 0x0000000185B78EA0-0x0000000185B78EB0

	public delegate bool __HotPatchDelegate_457(object P0, GPUIHandle P1, bool P2, object P3, bool P4); // TypeDefIndex: 75204; 0x000000018129F400-0x000000018129F420

	public delegate bool __HotPatchDelegate_458(object P0, GPUIHandle P1, bool P2, int P3, bool P4); // TypeDefIndex: 75205; 0x000000018129F400-0x000000018129F420

	public delegate RuntimePrefabData __HotPatchDelegate_459(object P0, object P1); // TypeDefIndex: 75206; 0x00000001859B7730-0x00000001859B7740

	public delegate Mesh __HotPatchDelegate_460(); // TypeDefIndex: 75207; 0x0000000185B44B70-0x0000000185B44B80

	public delegate void __HotPatchDelegate_461(object P0, ref NativeArray<GPUInstanceData> P1, int P2, bool P3); // TypeDefIndex: 75208; 0x0000000181217F60-0x0000000181217F80
}
