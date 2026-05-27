/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UIElements.Internal;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.StyleSheets.Syntax;
using UnityEngine.UIElements.UIR;
using UnityEngine.UIElements.UIR.Implementation;
using UnityEngine.Yoga;

// Image 10: UnityEngine.UIElementsModule.dll - Assembly: UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 43162-44030
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: InternalsVisibleTo("UnityEngine")]
[assembly: InternalsVisibleTo("UnityEngine.SharedInternalsModule")]
[assembly: InternalsVisibleTo("UnityEngine.CoreModule")]
[assembly: InternalsVisibleTo("UnityEngine.AccessibilityModule")]
[assembly: InternalsVisibleTo("UnityEngine.AndroidJNIModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputModule")]
[assembly: InternalsVisibleTo("UnityEngine.AnimationModule")]
[assembly: InternalsVisibleTo("UnityEngine.AntiSDKModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainModule")]
[assembly: InternalsVisibleTo("UnityEngine.ParticleSystemModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.PhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.AIModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGOcclusionCullingModule")]
[assembly: InternalsVisibleTo("UnityEngine.ARModule")]
[assembly: InternalsVisibleTo("UnityEngine.AssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.AudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClothModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterInputModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterRendererModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityConnectModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommonModule")]
[assembly: InternalsVisibleTo("UnityEngine.TLSModule")]
[assembly: InternalsVisibleTo("UnityEngine.JSONSerializeModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsModule")]
[assembly: InternalsVisibleTo("UnityEngine.CrashReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.DirectorModule")]
[assembly: InternalsVisibleTo("UnityEngine.DSPGraphModule")]
[assembly: InternalsVisibleTo("UnityEngine.ImageConversionModule")]
[assembly: InternalsVisibleTo("UnityEngine.GameCenterModule")]
[assembly: InternalsVisibleTo("UnityEngine.GIModule")]
[assembly: InternalsVisibleTo("UnityEngine.GridModule")]
[assembly: InternalsVisibleTo("UnityEngine.HotReloadModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsCPPModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextRenderingModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5Module")]
[assembly: InternalsVisibleTo("UnityEngine.ScreenCaptureModule")]
[assembly: InternalsVisibleTo("UnityEngine.IMGUIModule")]
[assembly: InternalsVisibleTo("UnityEngine.LiteSSLModule")]
[assembly: InternalsVisibleTo("UnityEngine.LocalizationModule")]
[assembly: InternalsVisibleTo("UnityEngine.PerformanceReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.Physics2DModule")]
[assembly: InternalsVisibleTo("UnityEngine.ProfilerModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputLegacyModule")]
[assembly: InternalsVisibleTo("UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreTextEngineModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteShapeModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamingModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamLineModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubstanceModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubsystemsModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainPhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteMaskModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestModule")]
[assembly: InternalsVisibleTo("UnityEngine.TilemapModule")]
[assembly: InternalsVisibleTo("UnityEngine.WindModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestTextureModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsModule")]
[assembly: InternalsVisibleTo("UnityEngine.UmbraModule")]
[assembly: InternalsVisibleTo("UnityEngine.UNETModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityCurlModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityTestProtocolModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsNativeModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIModule")]
[assembly: InternalsVisibleTo("UnityEngine.VehiclesModule")]
[assembly: InternalsVisibleTo("UnityEngine.VFXModule")]
[assembly: InternalsVisibleTo("UnityEngine.VideoModule")]
[assembly: InternalsVisibleTo("UnityEngine.VirtualTexturingModule")]
[assembly: InternalsVisibleTo("UnityEngine.XRModule")]
[assembly: InternalsVisibleTo("UnityEngine.VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestWWWModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud.Service")]
[assembly: InternalsVisibleTo("Unity.Analytics")]
[assembly: InternalsVisibleTo("UnityEngine.Analytics")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommon")]
[assembly: InternalsVisibleTo("UnityEngine.Advertisements")]
[assembly: InternalsVisibleTo("UnityEngine.Purchasing")]
[assembly: InternalsVisibleTo("UnityEngine.TestRunner")]
[assembly: InternalsVisibleTo("Unity.Automation")]
[assembly: InternalsVisibleTo("Unity.Burst")]
[assembly: InternalsVisibleTo("Unity.Burst.Editor")]
[assembly: InternalsVisibleTo("Unity.DeploymentTests.Services")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.UnityAnalytics")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.Timeline")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.Framework")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.Framework")]
[assembly: InternalsVisibleTo("UnityEngine.UI")]
[assembly: InternalsVisibleTo("Unity.Networking.Transport")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.AllIn1Runner")]
[assembly: InternalsVisibleTo("Unity.Timeline")]
[assembly: InternalsVisibleTo("Assembly-CSharp-testable")]
[assembly: InternalsVisibleTo("Assembly-CSharp-firstpass-testable")]
[assembly: InternalsVisibleTo("UnityEngine.SpatialTracking")]
[assembly: InternalsVisibleTo("GoogleAR.UnityNative")]
[assembly: InternalsVisibleTo("Unity.WindowsMRAutomation")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.Editor")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.Framework.Tests")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.Editor")]
[assembly: InternalsVisibleTo("UnityEditor.UIBuilderModule")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.EditorTests")]
[assembly: InternalsVisibleTo("Unity.UIElements")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsGameObjectsModule")]
[assembly: InternalsVisibleTo("Unity.UIElements.Editor")]
[assembly: InternalsVisibleTo("Unity.UIElements.PlayModeTests")]
[assembly: InternalsVisibleTo("Unity.UIElements.EditorTests")]
[assembly: InternalsVisibleTo("Unity.PerformanceTests.RuntimeTestRunner.Tests")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreFontEngineModule")]
[assembly: InternalsVisibleTo("Unity.ucg.QoS")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.022")]
[assembly: InternalsVisibleTo("Unity.Logging")]
[assembly: InternalsVisibleTo("Unity.Entities")]
[assembly: InternalsVisibleTo("Unity.Entities.Tests")]
[assembly: InternalsVisibleTo("Unity.Collections")]
[assembly: InternalsVisibleTo("Unity.Runtime")]
[assembly: InternalsVisibleTo("Unity.Core")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.001")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.002")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.003")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.004")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.005")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.006")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.007")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.008")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.009")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.010")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.011")]
[assembly: InternalsVisibleTo("UnityEngine.Networking")]
[assembly: InternalsVisibleTo("Unity.Services.QoS")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.014")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.015")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.016")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.017")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.018")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.019")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.020")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.021")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.012")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.023")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.024")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.001")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.002")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.003")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.004")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.005")]
[assembly: InternalsVisibleTo("Unity.Subsystem.Registration")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.013")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.EditorTests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: UnityEngineModuleAssembly]

namespace UnityEngine.UIElements
{
	internal static class AlignmentUtils // TypeDefIndex: 43165
	{
		// Methods
		internal static float RoundToPixelGrid(float v, float pixelsPerPoint, float offset = 0.02f /* Metadata: 0x01FB5D9C */) => default; // 0x0000000189E672EC-0x0000000189E6731C
		internal static float CeilToPixelGrid(float v, float pixelsPerPoint, float offset = -0.02f /* Metadata: 0x01FB5DA0 */) => default; // 0x0000000189E672C4-0x0000000189E672EC
	}

	internal abstract class AtlasBase // TypeDefIndex: 43166
	{
		// Fields
		internal TextureRegistry textureRegistry; // 0x10
	
		// Constructors
		protected AtlasBase() {} // 0x0000000189E67878-0x0000000189E678CC
	
		// Methods
		public virtual bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect) {
			atlas = default;
			atlasRect = default;
			return default;
		} // 0x0000000189E67820-0x0000000189E67878
		public virtual void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas) {} // 0x000000018350B670-0x000000018350B680
		public virtual void Reset() {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnAssignedToPanel(IPanel panel) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnRemovedFromPanel(IPanel panel) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void OnUpdateDynamicTextures(IPanel panel) {} // 0x000000018350B670-0x000000018350B680
		internal void InvokeAssignedToPanel(IPanel panel) {} // 0x0000000189E6776C-0x0000000189E67780
		internal void InvokeRemovedFromPanel(IPanel panel) {} // 0x00000001894B48E8-0x00000001894B48FC
		internal void InvokeUpdateDynamicTextures(IPanel panel) {} // 0x00000001894C1B40-0x00000001894C1B54
		protected static void RepaintTexturedElements(IPanel panel) {} // 0x0000000189E67780-0x0000000189E67800
		protected void SetDynamicTexture(TextureId id, Texture texture) {} // 0x0000000189E67800-0x0000000189E67820
	}

	[Flags]
	public enum DynamicAtlasFilters // TypeDefIndex: 43167
	{
		None = 0,
		Readability = 1,
		Size = 2,
		Format = 4,
		ColorSpace = 8,
		FilterMode = 16
	}

	public delegate bool DynamicAtlasCustomFilter(Texture2D texture, ref DynamicAtlasFilters filtersToApply); // TypeDefIndex: 43168; 0x0000000181165340-0x0000000181165350

	internal class DynamicAtlas : AtlasBase // TypeDefIndex: 43170
	{
		// Fields
		private Dictionary<Texture, TextureInfo> m_Database; // 0x18
		private DynamicAtlasPage m_PointPage; // 0x20
		private DynamicAtlasPage m_BilinearPage; // 0x28
		private ColorSpace m_ColorSpace; // 0x30
		private List<IPanel> m_Panels; // 0x38
		private int m_MinAtlasSize; // 0x40
		private int m_MaxAtlasSize; // 0x44
		private int m_MaxSubTextureSize; // 0x48
		private DynamicAtlasFilters m_ActiveFilters; // 0x4C
		private DynamicAtlasCustomFilter m_CustomFilter; // 0x50
	
		// Properties
		internal bool isInitialized { get => default; } // 0x0000000189E6F4B0-0x0000000189E6F4C4 
		public int minAtlasSize { set {} } // 0x0000000189E6F554-0x0000000189E6F56C
		public int maxAtlasSize { set {} } // 0x0000000189E6F524-0x0000000189E6F53C
		public static DynamicAtlasFilters defaultFilters { get => default; } // 0x0000000183D55C10-0x0000000183D55C20 
		public DynamicAtlasFilters activeFilters { set {} } // 0x0000000189E6F4C4-0x0000000189E6F4DC
		public int maxSubTextureSize { get => default; set {} } // 0x0000000183D86EF0-0x0000000183D86F00 0x0000000189E6F53C-0x0000000189E6F554
		public DynamicAtlasCustomFilter customFilter { set {} } // 0x0000000189E6F4DC-0x0000000189E6F524
	
		// Nested types
		private class TextureInfo : LinkedPoolItem<TextureInfo> // TypeDefIndex: 43169
		{
			// Fields
			public DynamicAtlasPage page; // 0x18
			public int counter; // 0x20
			public Allocator2D.Alloc2D alloc; // 0x28
			public RectInt rect; // 0x58
			public static readonly LinkedPool<TextureInfo> pool; // 0x00
	
			// Constructors
			public TextureInfo() {} // 0x0000000189E77FE8-0x0000000189E78010
			static TextureInfo() {} // 0x0000000189E77EB4-0x0000000189E77FE8
	
			// Methods
			private static TextureInfo Create() => default; // 0x0000000189E77E20-0x0000000189E77E70
			private static void Reset(TextureInfo info) {} // 0x0000000189E77E70-0x0000000189E77EB4
		}
	
		// Constructors
		public DynamicAtlas() {} // 0x0000000189E6F3C4-0x0000000189E6F4B0
	
		// Methods
		protected override void OnAssignedToPanel(IPanel panel) {} // 0x0000000189E6EC8C-0x0000000189E6ED08
		protected override void OnRemovedFromPanel(IPanel panel) {} // 0x0000000189E6ED08-0x0000000189E6ED90
		public override void Reset() {} // 0x0000000189E6EE00-0x0000000189E6EEA0
		private void InitPages() {} // 0x0000000189E6E8C0-0x0000000189E6E9E4
		private void DestroyPages() {} // 0x0000000189E6E83C-0x0000000189E6E8C0
		public override bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect) {
			atlas = default;
			atlasRect = default;
			return default;
		} // 0x0000000189E6EFD4-0x0000000189E6F3C4
		public override void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas) {} // 0x0000000189E6EEA0-0x0000000189E6EFD4
		protected override void OnUpdateDynamicTextures(IPanel panel) {} // 0x0000000189E6ED90-0x0000000189E6EE00
		internal static bool IsTextureFormatSupported(TextureFormat format) => default; // 0x0000000189E6E9E4-0x0000000189E6EB40
		public virtual bool IsTextureValid(Texture2D texture, UnityEngine.FilterMode atlasFilterMode) => default; // 0x0000000189E6EB40-0x0000000189E6EC8C
	}

	public class BindableElement : VisualElement, IBindable // TypeDefIndex: 43173
	{
		// Properties
		public IBinding binding { get; } // 0x0000000183D57010-0x0000000183D57020 
		public string bindingPath { get; set; } // 0x00000001858B3B50-0x00000001858B3B64
	
		// Nested types
		public class UxmlFactory : UxmlFactory<BindableElement, UxmlTraits> // TypeDefIndex: 43171
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189E783B0-0x0000000189E783EC
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 43172
		{
			// Fields
			private UxmlStringAttributeDescription m_PropertyPath; // 0x70
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189E78500-0x0000000189E78590
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189E78428-0x0000000189E78500
		}
	
		// Constructors
		public BindableElement() {} // 0x0000000189E69538-0x0000000189E69584
	}

	internal class ClampedDragger<T> : Clickable // TypeDefIndex: 43175
		where T : IComparable<T>
	{
		// Properties
		public DragDirection dragDirection { get; set; }
		private BaseSlider<T> slider { get; set; }
		public Vector2 startMousePosition { get; private set; }
		public Vector2 delta { get => default; }
	
		// Events
		public event Action dragging;
		public event Action draggingEnded;
	
		// Nested types
		[Flags]
		public enum DragDirection // TypeDefIndex: 43174
		{
			None = 0,
			LowToHigh = 1,
			HighToLow = 2,
			Free = 4
		}
	
		// Constructors
		public ClampedDragger() {} // Dummy constructor
		public ClampedDragger(BaseSlider<T> slider, Action clickHandler, Action dragHandler) {}
	
		// Methods
		protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) {}
		protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) {}
		protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition) {}
	}

	public class Clickable : PointerManipulator // TypeDefIndex: 43176
	{
		// Fields
		private readonly long m_Delay; // 0x48
		private readonly long m_Interval; // 0x50
		private int m_ActivePointerId; // 0x64
		private bool m_AcceptClicksIfDisabled; // 0x68
		private IVisualElementScheduledItem m_Repeater; // 0x70
	
		// Properties
		protected bool active { get; set; } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000183D4F7F0-0x0000000183D4F800
		public Vector2 lastMousePosition { get; private set; } // 0x0000000183D88530-0x0000000183D88550 0x0000000183D6E7B0-0x0000000183D6E7C0
		internal bool acceptClicksIfDisabled { get => default; set {} } // 0x0000000183D4F3F0-0x0000000183D4F400 0x0000000189E6BAC4-0x0000000189E6BB04
		private InvokePolicy invokePolicy { get => default; } // 0x0000000189E6B998-0x0000000189E6B9A4 
	
		// Events
		public event Action<EventBase> clickedWithEventInfo;
		public event Action clicked;
	
		// Constructors
		public Clickable() {} // Dummy constructor
		public Clickable(Action handler, long delay, long interval) {} // 0x0000000189E6B710-0x0000000189E6B74C
		public Clickable(Action<EventBase> handler) {} // 0x0000000189E6B74C-0x0000000189E6B7E0
		public Clickable(Action handler) {} // 0x0000000189E6B7E0-0x0000000189E6B878
	
		// Methods
		private void OnTimer(UnityEngine.UIElements.TimerState timerState) {} // 0x0000000189E6A854-0x0000000189E6A8D0
		private bool IsRepeatable() => default; // 0x0000000189E6A1E8-0x0000000189E6A1FC
		protected override void RegisterCallbacksOnTarget() {} // 0x0000000189E6AD0C-0x0000000189E6B1C8
		protected override void UnregisterCallbacksFromTarget() {} // 0x0000000189E6B2D4-0x0000000189E6B710
		protected void OnMouseDown(MouseDownEvent evt) {} // 0x0000000189E6A268-0x0000000189E6A328
		protected void OnMouseMove(MouseMoveEvent evt) {} // 0x0000000189E6A328-0x0000000189E6A394
		protected void OnMouseUp(MouseUpEvent evt) {} // 0x0000000189E6A394-0x0000000189E6A458
		private void OnMouseCaptureOut(MouseCaptureOutEvent evt) {} // 0x0000000189E6A1FC-0x0000000189E6A268
		private void OnPointerDown(PointerDownEvent evt) {} // 0x0000000189E6A548-0x0000000189E6A65C
		private void OnPointerMove(PointerMoveEvent evt) {} // 0x0000000189E6A65C-0x0000000189E6A744
		private void OnPointerUp(PointerUpEvent evt) {} // 0x0000000189E6A744-0x0000000189E6A854
		private void OnPointerCancel(PointerCancelEvent evt) {} // 0x0000000189E6A458-0x0000000189E6A4D8
		private void OnPointerCaptureOut(PointerCaptureOutEvent evt) {} // 0x0000000189E6A4D8-0x0000000189E6A548
		private bool ContainsPointer(int pointerId) => default; // 0x0000000189E6A108-0x0000000189E6A15C
		private static bool IsNotMouseEvent(int pointerId) => default; // 0x0000000189E6A19C-0x0000000189E6A1E8
		protected void Invoke(EventBase evt) {} // 0x0000000189E6A15C-0x0000000189E6A19C
		internal void SimulateSingleClick(EventBase evt, int delayMs = 100 /* Metadata: 0x01FB5DAE */) {} // 0x0000000189E6B1C8-0x0000000189E6B2AC
		protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) {} // 0x0000000189E6A9A0-0x0000000189E6ABA0
		protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition) {} // 0x0000000189E6ABA0-0x0000000189E6AC08
		protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) {} // 0x0000000189E6AC08-0x0000000189E6AD0C
		protected virtual void ProcessCancelEvent(EventBase evt, int pointerId) {} // 0x0000000189E6A8D0-0x0000000189E6A9A0
	}

	internal class ClickDetector // TypeDefIndex: 43178
	{
		// Fields
		private List<ButtonClickStatus> m_ClickStatus; // 0x10
	
		// Properties
		internal static int s_DoubleClickTime { get; set; } // 0x0000000189E6A064-0x0000000189E6A0B4 0x0000000189E6A0B4-0x0000000189E6A108
	
		// Nested types
		private class ButtonClickStatus // TypeDefIndex: 43177
		{
			// Fields
			public VisualElement m_Target; // 0x10
			public Vector3 m_PointerDownPosition; // 0x18
			public long m_LastPointerDownTime; // 0x28
			public int m_ClickCount; // 0x30
	
			// Constructors
			public ButtonClickStatus() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void Reset() {} // 0x0000000189E69584-0x0000000189E695C0
		}
	
		// Constructors
		public ClickDetector() {} // 0x0000000189E69ED4-0x0000000189E6A064
		static ClickDetector() {} // 0x0000000189E69E98-0x0000000189E69ED4
	
		// Methods
		private void StartClickTracking(EventBase evt) {} // 0x0000000189E69D3C-0x0000000189E69E98
		private void SendClickEvent(EventBase evt) {} // 0x0000000189E69AE8-0x0000000189E69D3C
		private void CancelClickTracking(EventBase evt) {} // 0x0000000189E695C0-0x0000000189E69650
		public void ProcessEvent(EventBase evt) {} // 0x0000000189E6989C-0x0000000189E69AE8
		private static bool ContainsPointer(VisualElement element, Vector2 position) => default; // 0x0000000189E697B0-0x0000000189E6989C
		internal void Cleanup(List<VisualElement> elements) {} // 0x0000000189E69650-0x0000000189E697B0
	}

	public abstract class ContextualMenuManager // TypeDefIndex: 43179
	{
		// Properties
		internal bool displayMenuHandledOSX { get; set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		protected ContextualMenuManager() {} // Dummy constructor
	
		// Methods
		public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler);
		public void DisplayMenu(EventBase triggerEvent, IEventHandler target) {} // 0x0000000189E6BB04-0x0000000189E6BC2C
		protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent);
	}

	public class ContextualMenuManipulator : MouseManipulator // TypeDefIndex: 43180
	{
		// Fields
		private Action<ContextualMenuPopulateEvent> m_MenuBuilder; // 0x30
	
		// Constructors
		public ContextualMenuManipulator() {} // Dummy constructor
		public ContextualMenuManipulator(Action<ContextualMenuPopulateEvent> menuBuilder) {} // 0x0000000189E6C2AC-0x0000000189E6C38C
	
		// Methods
		protected override void RegisterCallbacksOnTarget() {} // 0x0000000189E6BE14-0x0000000189E6C060
		protected override void UnregisterCallbacksFromTarget() {} // 0x0000000189E6C060-0x0000000189E6C2AC
		private void OnMouseUpDownEvent(IMouseEvent evt) {} // 0x0000000189E6BD5C-0x0000000189E6BDC4
		private void OnMouseDownEventOSX(MouseDownEvent evt) {} // 0x0000000189E6BD04-0x0000000189E6BD5C
		private void OnMouseUpEventOSX(MouseUpEvent evt) {} // 0x0000000189E6BDC4-0x0000000189E6BE14
		private void OnKeyUpEvent(KeyUpEvent evt) {} // 0x0000000189E6BCA8-0x0000000189E6BD04
		private void DoDisplayMenu(EventBase evt) {} // 0x0000000189E6BC2C-0x0000000189E6BC94
		private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt) {} // 0x0000000189E6BC94-0x0000000189E6BCA8
	}

	internal struct CountingBloomFilter // TypeDefIndex: 43182
	{
		// Fields
		private unsafe fixed /* 0x00000000-0x00000000 */ byte m_Counters[0]; // 0x00
	
		// Methods
		private void AdjustSlot(uint index, bool increment) {} // 0x0000000189E6C38C-0x0000000189E6C3B0
		private uint Hash1(uint hash) => default; // 0x0000000183D88550-0x0000000183D88560
		private uint Hash2(uint hash) => default; // 0x0000000183D88560-0x0000000183D88570
		private bool IsSlotEmpty(uint index) => default; // 0x0000000189E6C408-0x0000000189E6C414
		public void InsertHash(uint hash) {} // 0x0000000189E6C3DC-0x0000000189E6C408
		public void RemoveHash(uint hash) {} // 0x0000000189E6C414-0x0000000189E6C440
		public bool ContainsHash(uint hash) => default; // 0x0000000189E6C3B0-0x0000000189E6C3DC
	}

	internal class AncestorFilter // TypeDefIndex: 43183
	{
		// Fields
		private CountingBloomFilter m_CountingBloomFilter; // 0x10
		private Stack<int> m_HashStack; // 0x4010
	
		// Constructors
		public AncestorFilter() {} // 0x0000000189E676EC-0x0000000189E6776C
	
		// Methods
		private void AddHash(int hash) {} // 0x0000000189E6731C-0x0000000189E67380
		public bool IsCandidate(StyleComplexSelector complexSel) => default; // 0x0000000189E67380-0x0000000189E673F8
		public void PushElement(VisualElement element) {} // 0x0000000189E674B8-0x0000000189E676EC
		public void PopElement() {} // 0x0000000189E673F8-0x0000000189E674B8
	}

	public struct Cursor : IEquatable<UnityEngine.UIElements.Cursor> // TypeDefIndex: 43184
	{
		// Properties
		public Texture2D texture { [IsReadOnly] get; set; } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public Vector2 hotspot { [IsReadOnly] get; set; } // 0x0000000183D67720-0x0000000183D67740 0x0000000183D55BA0-0x0000000183D55BB0
		internal int defaultCursorId { [IsReadOnly] get; set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189E6C53C-0x0000000189E6C5C0
		public bool Equals(Cursor other) => default; // 0x0000000189E6C5C0-0x0000000189E6C684
		public override int GetHashCode() => default; // 0x0000000189E6C684-0x0000000189E6C758
		public static bool operator ==(Cursor style1, Cursor style2) => default; // 0x0000000189E6C7CC-0x0000000189E6C7F8
		public override string ToString() => default; // 0x0000000189E6C758-0x0000000189E6C7CC
	}

	internal interface ICursorManager // TypeDefIndex: 43185
	{
		// Methods
		void SetCursor(UnityEngine.UIElements.Cursor cursor);
		void ResetCursor();
	}

	internal class CursorManager : ICursorManager // TypeDefIndex: 43186
	{
		// Properties
		public bool isCursorOverriden { get; private set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		public CursorManager() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void SetCursor(UnityEngine.UIElements.Cursor cursor) {} // 0x0000000189E6C480-0x0000000189E6C53C
		public void ResetCursor() {} // 0x0000000189E6C440-0x0000000189E6C480
	}

	internal class DefaultEventSystem // TypeDefIndex: 43192
	{
		// Fields
		internal static Func<bool> IsEditorRemoteConnected; // 0x00
		private IInput m_Input; // 0x10
		private readonly string m_HorizontalAxis; // 0x18
		private readonly string m_VerticalAxis; // 0x20
		private readonly string m_SubmitButton; // 0x28
		private readonly string m_CancelButton; // 0x30
		private readonly float m_InputActionsPerSecond; // 0x38
		private readonly float m_RepeatDelay; // 0x3C
		private bool m_SendingTouchEvents; // 0x40
		private UnityEngine.Event m_Event; // 0x48
		private BaseRuntimePanel m_FocusedPanel; // 0x50
		private int m_ConsecutiveMoveCount; // 0x58
		private Vector2 m_LastMoveVector; // 0x5C
		private float m_PrevActionTime; // 0x64
	
		// Properties
		private bool isAppFocused { get => default; } // 0x00000001842744F0-0x00000001842744F8 
		internal IInput input { get => default; } // 0x0000000189E6DA70-0x0000000189E6DAA4 
		public BaseRuntimePanel focusedPanel { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000189E6DAA4-0x0000000189E6DAF4
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 43187
		{
			Always = 0,
			IgnoreIfAppNotFocused = 1
		}
	
		internal interface IInput // TypeDefIndex: 43188
		{
			// Properties
			int touchCount { get; }
			bool mousePresent { get; }
	
			// Methods
			bool GetButtonDown(string button);
			float GetAxisRaw(string axis);
			Touch GetTouch(int index);
		}
	
		private class Input : IInput // TypeDefIndex: 43189
		{
			// Properties
			public int touchCount { get => default; } // 0x00000001889CEE70-0x00000001889CEE78 
			public bool mousePresent { get => default; } // 0x0000000189E75CCC-0x0000000189E75CD4 
	
			// Constructors
			public Input() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool GetButtonDown(string button) => default; // 0x0000000189E75CC0-0x0000000189E75CCC
			public float GetAxisRaw(string axis) => default; // 0x0000000189E75CB4-0x0000000189E75CC0
			public Touch GetTouch(int index) => default; // 0x000000018943BB00-0x000000018943BB48
		}
	
		private class NoInput : IInput // TypeDefIndex: 43190
		{
			// Properties
			public int touchCount { get => default; } // 0x0000000181002730-0x0000000181002740 
			public bool mousePresent { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
			// Constructors
			public NoInput() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool GetButtonDown(string button) => default; // 0x000000018115F4C0-0x000000018115F530
			public float GetAxisRaw(string axis) => default; // 0x0000000183D503F0-0x0000000183D50400
			public Touch GetTouch(int index) => default; // 0x0000000183D88660-0x0000000183D88680
		}
	
		// Constructors
		public DefaultEventSystem() {} // 0x0000000189E6D97C-0x0000000189E6DA70
		static DefaultEventSystem() {} // 0x0000000189E6D8B8-0x0000000189E6D97C
	
		// Methods
		private IInput GetDefaultInput() => default; // 0x0000000189E6C7F8-0x0000000189E6C900
		private bool ShouldIgnoreEventsOnAppNotFocused() => default; // 0x0000000189E6D668-0x0000000189E6D680
		public void Update(UpdateMode updateMode = UpdateMode.Always /* Metadata: 0x01FB5DB0 */) {} // 0x0000000189E6D85C-0x0000000189E6D8B8
		private void SendIMGUIEvents() {} // 0x0000000189E6CE78-0x0000000189E6D394
		private void SendInputEvents() {} // 0x0000000189E6D394-0x0000000189E6D668
		internal void SendFocusBasedEvent<TArg>(Func<TArg, EventBase> evtFactory, TArg arg) {}
		private void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, int? targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false /* Metadata: 0x01FB5DB1 */) {}
		private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel) {} // 0x0000000189E6D7FC-0x0000000189E6D85C
		private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers) => default; // 0x0000000189E6CA1C-0x0000000189E6CB18
		private bool ProcessTouchEvents() => default; // 0x0000000189E6CB18-0x0000000189E6CE78
		private Vector2 GetRawMoveVector() => default; // 0x0000000189E6C920-0x0000000189E6CA1C
		private bool ShouldSendMoveFromInput() => default; // 0x0000000189E6D680-0x0000000189E6D7FC
		private static Vector2 GetLocalScreenPosition(UnityEngine.Event evt, out int? targetDisplay) {
			targetDisplay = default;
			return default;
		} // 0x0000000189E6C900-0x0000000189E6C920
	}

	internal class DisposeHelper // TypeDefIndex: 43193
	{
		// Constructors
		public DisposeHelper() {} // Dummy constructor
	
		// Methods
		public static void NotifyDisposedUsed(IDisposable disposable) {} // 0x0000000189E6DDD0-0x0000000189E6DE6C
	}

	public class DropdownMenuEventInfo // TypeDefIndex: 43194
	{
		// Constructors
		public DropdownMenuEventInfo() {} // Dummy constructor
		public DropdownMenuEventInfo(EventBase e) {} // 0x0000000189E6DEF4-0x0000000189E6E0F8
	}

	public abstract class DropdownMenuItem // TypeDefIndex: 43195
	{
		// Constructors
		protected DropdownMenuItem() {} // 0x000000018350B670-0x000000018350B680
	}

	public class DropdownMenuSeparator : DropdownMenuItem // TypeDefIndex: 43196
	{
		// Constructors
		public DropdownMenuSeparator() {} // Dummy constructor
		public DropdownMenuSeparator(string subMenuPath) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	public class DropdownMenuAction : DropdownMenuItem // TypeDefIndex: 43198
	{
		// Fields
		private readonly Action<DropdownMenuAction> actionCallback; // 0x30
		private readonly Func<DropdownMenuAction, Status> actionStatusCallback; // 0x38
	
		// Properties
		private Status status { get; set; } // 0x0000000183D4E9C0-0x0000000183D4E9D0
		private DropdownMenuEventInfo eventInfo { get; set; } // 0x0000000184271930-0x0000000184271940
		private object userData { get; set; } // 0x0000000182C92F10-0x0000000182C92F20
	
		// Nested types
		[Flags]
		public enum Status // TypeDefIndex: 43197
		{
			None = 0,
			Normal = 1,
			Disabled = 2,
			Checked = 4,
			Hidden = 8
		}
	
		// Constructors
		public DropdownMenuAction() {} // Dummy constructor
		public DropdownMenuAction(string actionName, Action<DropdownMenuAction> actionCallback, Func<DropdownMenuAction, Status> actionStatusCallback, object userData = null) {} // 0x0000000189E6DEAC-0x0000000189E6DEF4
	
		// Methods
		public static Status AlwaysEnabled(DropdownMenuAction a) => default; // 0x0000000183D88580-0x0000000183D88590
		public static Status AlwaysDisabled(DropdownMenuAction a) => default; // 0x0000000183D88570-0x0000000183D88580
		public void UpdateActionStatus(DropdownMenuEventInfo eventInfo) {} // 0x0000000189E6DE6C-0x0000000189E6DEAC
	}

	public class DropdownMenu // TypeDefIndex: 43200
	{
		// Fields
		private List<DropdownMenuItem> m_MenuItems; // 0x10
		private DropdownMenuEventInfo m_DropdownMenuEventInfo; // 0x18
	
		// Constructors
		public DropdownMenu() {} // 0x0000000189E6E744-0x0000000189E6E7BC
	
		// Methods
		public List<DropdownMenuItem> MenuItems() => default; // 0x0000000183D66B80-0x0000000183D66B90
		public void AppendAction(string actionName, Action<DropdownMenuAction> action, Func<DropdownMenuAction, DropdownMenuAction.Status> actionStatusCallback, object userData = null) {} // 0x0000000189E6E21C-0x0000000189E6E2D8
		public void AppendAction(string actionName, Action<DropdownMenuAction> action, DropdownMenuAction.Status status = DropdownMenuAction.Status.None | DropdownMenuAction.Status.Normal /* Metadata: 0x01FB5DB9 */) {} // 0x0000000189E6E0F8-0x0000000189E6E21C
		public void AppendSeparator(string subMenuPath = null) {} // 0x0000000189E6E2D8-0x0000000189E6E3DC
		public void InsertSeparator(string subMenuPath, int atIndex) {} // 0x0000000189E6E3DC-0x0000000189E6E4F4
		public void PrepareForDisplay(EventBase e) {} // 0x0000000189E6E4F4-0x0000000189E6E744
	}

	internal static class DropdownUtility // TypeDefIndex: 43201
	{
		// Fields
		internal static Func<IGenericMenu> MakeDropdownFunc; // 0x00
	
		// Methods
		internal static IGenericMenu CreateDropdown() => default; // 0x0000000189E6E7BC-0x0000000189E6E83C
	}

	internal enum DispatchMode // TypeDefIndex: 43202
	{
		Default = 1,
		Queued = 1,
		Immediate = 2
	}

	public struct EventDispatcherGate : IDisposable, IEquatable<EventDispatcherGate> // TypeDefIndex: 43203
	{
		// Fields
		private readonly EventDispatcher m_Dispatcher; // 0x00
	
		// Constructors
		public EventDispatcherGate(EventDispatcher d) {
			m_Dispatcher = default;
		} // 0x0000000189E6F60C-0x0000000189E6F688
	
		// Methods
		public void Dispose() {} // 0x0000000189E6F56C-0x0000000189E6F58C
		public bool Equals(EventDispatcherGate other) => default; // 0x0000000189E6F58C-0x0000000189E6F59C
		public override bool Equals(object obj) => default; // 0x0000000189E6F59C-0x0000000189E6F60C
		public override int GetHashCode() => default; // 0x000000018711E2B8-0x000000018711E2DC
	}

	public sealed class EventDispatcher // TypeDefIndex: 43206
	{
		// Fields
		internal ClickDetector m_ClickDetector; // 0x10
		private List<IEventDispatchingStrategy> m_DispatchingStrategies; // 0x18
		private static readonly UnityEngine.UIElements.ObjectPool<Queue<EventRecord>> k_EventQueuePool; // 0x00
		private Queue<EventRecord> m_Queue; // 0x20
		private uint m_GateCount; // 0x30
		private Stack<DispatchContext> m_DispatchContexts; // 0x38
		private static readonly IEventDispatchingStrategy[] s_EditorStrategies; // 0x08
		private bool m_Immediate; // 0x40
	
		// Properties
		internal PointerDispatchState pointerState { get; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 
		private bool dispatchImmediately { get => default; } // 0x0000000189E70600-0x0000000189E70614 
		private bool processingEvents { get; set; } // 0x0000000183D4F7D0-0x0000000183D4F7E0
	
		// Nested types
		private struct EventRecord // TypeDefIndex: 43204
		{
			// Fields
			public EventBase m_Event; // 0x00
			public IPanel m_Panel; // 0x08
		}
	
		private struct DispatchContext // TypeDefIndex: 43205
		{
			// Fields
			public uint m_GateCount; // 0x00
			public Queue<EventRecord> m_Queue; // 0x08
		}
	
		// Constructors
		public EventDispatcher() {} // Dummy constructor
		private EventDispatcher(IList<IEventDispatchingStrategy> strategies) {} // 0x0000000189E70440-0x0000000189E70600
		static EventDispatcher() {} // 0x0000000189E7015C-0x0000000189E70440
	
		// Methods
		internal static EventDispatcher CreateForRuntime(IList<IEventDispatchingStrategy> strategies) => default; // 0x0000000189E6F894-0x0000000189E6F8F4
		internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) {} // 0x0000000189E6F8F4-0x0000000189E6FA50
		internal void CloseGate() {} // 0x0000000183D88590-0x0000000183D885A0
		internal void OpenGate() {} // 0x0000000189E6FA50-0x0000000189E6FAB8
		private void ProcessEventQueue() {} // 0x0000000189E6FAB8-0x0000000189E6FDE0
		private void ProcessEvent(EventBase evt, IPanel panel) {} // 0x0000000189E6FDE0-0x0000000189E7015C
		private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) {} // 0x0000000189E6F688-0x0000000189E6F894
	}

	public abstract class Focusable : CallbackEventHandler // TypeDefIndex: 43207
	{
		// Fields
		private bool m_DelegatesFocus; // 0x28
		private bool m_ExcludeFromFocusRing; // 0x29
	
		// Properties
		public abstract FocusController focusController { get; }
		public bool focusable { get; set; } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
		public int tabIndex { get; set; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public bool delegatesFocus { get; set; } // 0x0000000183D885B0-0x0000000183D885C0 0x0000000183D4ED60-0x0000000183D4ED70
		internal bool excludeFromFocusRing { get; set; } // 0x0000000183D885C0-0x0000000183D885D0 0x0000000189E71E04-0x0000000189E71EBC
		public virtual bool canGrabFocus { get; } // 0x0000000183D4EF90-0x0000000183D4EFA0 
	
		// Constructors
		protected Focusable() {} // 0x0000000183D885A0-0x0000000183D885B0
	
		// Methods
		public virtual void Focus() {} // 0x0000000189E71BC0-0x0000000189E71C58
		public virtual void Blur() {} // 0x0000000189E71B7C-0x0000000189E71BB8
		internal void BlurImmediately() {} // 0x0000000189E71B40-0x0000000189E71B7C
		private Focusable GetFocusDelegate() => default; // 0x0000000189E71D6C-0x0000000189E71DC4
		private static Focusable GetFirstFocusableChild(VisualElement ve) => default; // 0x0000000189E71C58-0x0000000189E71D6C
		protected override void ExecuteDefaultAction(EventBase evt) {} // 0x0000000189E71BB8-0x0000000189E71BC0
		internal override void ExecuteDefaultActionDisabled(EventBase evt) {} // 0x0000000189E71BB8-0x0000000189E71BC0
		private void ProcessEvent(EventBase evt) {} // 0x0000000189E71DC4-0x0000000189E71E04
	}

	public class FocusChangeDirection : IDisposable // TypeDefIndex: 43208
	{
		// Fields
		private readonly int m_Value; // 0x10
	
		// Properties
		public static FocusChangeDirection unspecified { get; } // 0x0000000189E707C4-0x0000000189E70814 
		public static FocusChangeDirection none { get; } // 0x0000000189E70774-0x0000000189E707C4 
		protected static FocusChangeDirection lastValue { get; } // 0x0000000189E70724-0x0000000189E70774 
	
		// Constructors
		public FocusChangeDirection() {} // Dummy constructor
		protected FocusChangeDirection(int value) {} // 0x00000001810410F0-0x0000000181041100
		static FocusChangeDirection() {} // 0x0000000189E70650-0x0000000189E70724
	
		// Methods
		public static implicit operator int(FocusChangeDirection fcd) => default; // 0x0000000189E70814-0x0000000189E70820
		void IDisposable.Dispose() {} // 0x00000001895F944C-0x00000001895F945C
		protected virtual void Dispose() {} // 0x000000018350B670-0x000000018350B680
		internal virtual void ApplyTo(FocusController focusController, Focusable f) {} // 0x0000000189E70614-0x0000000189E70650
	}

	public interface IFocusRing // TypeDefIndex: 43209
	{
		// Methods
		FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e);
		Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction);
	}

	public class FocusController // TypeDefIndex: 43211
	{
		// Fields
		private List<FocusedElement> m_FocusedElements; // 0x18
		private Focusable m_LastFocusedElement; // 0x20
		internal Focusable m_LastPendingFocusedElement; // 0x28
		private int m_PendingFocusCount; // 0x30
	
		// Properties
		private IFocusRing focusRing { get; } // 0x00000001820B7B20-0x00000001820B7B30 
		public Focusable focusedElement { get => default; } // 0x0000000189E71B00-0x0000000189E71B40 
		internal int imguiKeyboardControl { get; set; } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000183D4EE40-0x0000000183D4EE50
	
		// Nested types
		private struct FocusedElement // TypeDefIndex: 43210
		{
			// Fields
			public VisualElement m_SubTreeRoot; // 0x00
			public Focusable m_FocusedElement; // 0x08
		}
	
		// Constructors
		public FocusController() {} // Dummy constructor
		public FocusController(IFocusRing focusRing) {} // 0x0000000189E71A68-0x0000000189E71B00
	
		// Methods
		internal bool IsFocused(Focusable f) => default; // 0x0000000189E711DC-0x0000000189E71308
		internal Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst) => default; // 0x0000000189E70E9C-0x0000000189E710CC
		internal Focusable GetLeafFocusedElement() => default; // 0x0000000189E70E04-0x0000000189E70E9C
		private bool IsLocalElement(Focusable f) => default; // 0x0000000189E71308-0x0000000189E7132C
		internal bool IsPendingFocus(Focusable f) => default; // 0x0000000189E7132C-0x0000000189E713A8
		internal void SetFocusToLastFocusedElement() {} // 0x0000000189E71520-0x0000000189E71580
		internal void BlurLastFocusedElement() {} // 0x0000000189E70A30-0x0000000189E70AA8
		internal void DoFocusChange(Focusable f) {} // 0x0000000189E70B00-0x0000000189E70C40
		internal Focusable FocusNextInDirection(FocusChangeDirection direction) => default; // 0x0000000189E70C40-0x0000000189E70D20
		private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) {} // 0x0000000189E70928-0x0000000189E70A30
		private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) {} // 0x0000000189E71418-0x0000000189E71520
		private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode) {} // 0x0000000189E70820-0x0000000189E70928
		private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode) {} // 0x0000000189E710CC-0x0000000189E711DC
		internal void Blur(Focusable focusable, bool bIsFocusDelegated = false /* Metadata: 0x01FB5DBD */, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x01FB5DBE */) {} // 0x0000000189E70AA8-0x0000000189E70B00
		internal void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated = false /* Metadata: 0x01FB5DBF */, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x01FB5DC0 */) {} // 0x0000000189E7172C-0x0000000189E717AC
		internal void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated = false /* Metadata: 0x01FB5DC1 */, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x01FB5DC2 */) {} // 0x0000000189E717AC-0x0000000189E719CC
		internal Focusable SwitchFocusOnEvent(EventBase e) => default; // 0x0000000189E71580-0x0000000189E7172C
		internal void ReevaluateFocus() {} // 0x0000000189E713A8-0x0000000189E71418
		internal bool GetFocusableParentForPointerEvent(Focusable target, out Focusable effectiveTarget) {
			effectiveTarget = default;
			return default;
		} // 0x0000000189E70D20-0x0000000189E70E04
		internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) {} // 0x0000000189E719CC-0x0000000189E71A68
	}

	internal static class GroupBoxUtility // TypeDefIndex: 43212
	{
		// Fields
		private static Dictionary<IGroupBox, IGroupManager> s_GroupManagers; // 0x00
		private static Dictionary<IGroupBoxOption, IGroupManager> s_GroupOptionManagerCache; // 0x08
		private static readonly System.Type k_GenericGroupBoxType; // 0x10
	
		// Constructors
		static GroupBoxUtility() {} // 0x0000000189E72700-0x0000000189E72858
	
		// Methods
		private static void OnOptionAttachToPanel(AttachToPanelEvent evt) {} // 0x0000000189E722C8-0x0000000189E724A8
		private static void OnOptionDetachFromPanel(DetachFromPanelEvent evt) {} // 0x0000000189E724A8-0x0000000189E72634
		private static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox) => default; // 0x0000000189E71EBC-0x0000000189E7221C
		private static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt) {} // 0x0000000189E7221C-0x0000000189E722C8
		private static void OnPanelDestroyed(BaseVisualElementPanel panel) {} // 0x0000000189E72634-0x0000000189E72700
	
		// Extension methods
		public static void RegisterGroupBoxOptionCallbacks<T>(this T option)
			where T : VisualElement, IGroupBoxOption {}
		public static void OnOptionSelected<T>(this T selectedOption)
			where T : VisualElement, IGroupBoxOption {}
	}

	internal interface IGroupBoxOption // TypeDefIndex: 43213
	{
		// Methods
		void SetSelected(bool selected);
	}

	internal interface IGroupBox // TypeDefIndex: 43214
	{
	}

	internal interface IGroupBox<T> : IGroupBox // TypeDefIndex: 43215
		where T : IGroupManager
	{
	}

	internal interface IGroupManager // TypeDefIndex: 43216
	{
		// Methods
		void OnOptionSelectionChanged(IGroupBoxOption selectedOption);
		void RegisterOption(IGroupBoxOption option);
		void UnregisterOption(IGroupBoxOption option);
	}

	internal class DefaultGroupManager : IGroupManager // TypeDefIndex: 43217
	{
		// Fields
		private List<IGroupBoxOption> m_GroupOptions; // 0x10
		private IGroupBoxOption m_SelectedOption; // 0x18
	
		// Constructors
		public DefaultGroupManager() {} // 0x0000000189E6DD58-0x0000000189E6DDD0
	
		// Methods
		public void OnOptionSelectionChanged(IGroupBoxOption selectedOption) {} // 0x0000000189E6DAF4-0x0000000189E6DC84
		public void RegisterOption(IGroupBoxOption option) {} // 0x0000000189E6DC84-0x0000000189E6DD04
		public void UnregisterOption(IGroupBoxOption option) {} // 0x0000000189E6DD04-0x0000000189E6DD58
	}

	public class IMGUIContainer : VisualElement, IDisposable // TypeDefIndex: 43221
	{
		// Fields
		private Action m_OnGUIHandler; // 0x3C0
		private ObjectGUIState m_ObjectGUIState; // 0x3C8
		internal bool useOwnerObjectGUIState; // 0x3D0
		private bool m_CullingEnabled; // 0x3E4
		private bool m_IsFocusDelegated; // 0x3E5
		private bool m_RefreshCachedLayout; // 0x3E6
		private GUILayoutUtility.LayoutCache m_Cache; // 0x3E8
		private Rect m_CachedClippingRect; // 0x3F0
		private Matrix4x4 m_CachedTransform; // 0x400
		private bool lostFocus; // 0x444
		private bool receivedFocus; // 0x445
		private FocusChangeDirection focusChangeDirection; // 0x448
		private bool hasFocusableControls; // 0x450
		private int newKeyboardFocusControlID; // 0x454
		public static readonly string ussClassName; // 0x00
		internal static readonly string ussFoldoutChildDepthClassName; // 0x08
		internal static readonly List<string> ussFoldoutChildDepthClassNames; // 0x10
		private GUIGlobals m_GUIGlobals; // 0x45C
		private static readonly ProfilerMarker k_OnGUIMarker; // 0x18
		private static readonly ProfilerMarker k_ImmediateCallbackMarker; // 0x20
		private static UnityEngine.Event s_DefaultMeasureEvent; // 0x28
		private static UnityEngine.Event s_MeasureEvent; // 0x30
		private static UnityEngine.Event s_CurrentEvent; // 0x38
	
		// Properties
		public Action onGUIHandler { get => default; set {} } // 0x0000000183D88610-0x0000000183D88620 0x0000000189E75BF0-0x0000000189E75C50
		internal ObjectGUIState guiState { get => default; } // 0x0000000189E75AE8-0x0000000189E75B90 
		internal Rect lastWorldClip { get; set; } // 0x0000000183D88600-0x0000000183D88610 0x0000000183D88630-0x0000000183D88640
		public bool cullingEnabled { get => default; } // 0x0000000183D885E0-0x0000000183D885F0 
		private GUILayoutUtility.LayoutCache cache { get => default; } // 0x0000000189E75A44-0x0000000189E75AC4 
		private float layoutMeasuredWidth { get => default; } // 0x0000000189E75BC0-0x0000000189E75BF0 
		private float layoutMeasuredHeight { get => default; } // 0x0000000189E75B90-0x0000000189E75BC0 
		public ContextType contextType { get; set; } // 0x0000000183D885D0-0x0000000183D885E0 0x0000000183D88620-0x0000000183D88630
		internal bool focusOnlyIfHasFocusableControls { get; } // 0x0000000183D885F0-0x0000000183D88600 
		public override bool canGrabFocus { get => default; } // 0x0000000189E75AC4-0x0000000189E75AE8 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<IMGUIContainer, UxmlTraits> // TypeDefIndex: 43218
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189E783EC-0x0000000189E78428
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 43219
		{
			// Constructors
			public UxmlTraits() {} // 0x0000000189E78590-0x0000000189E7A5E4
		}
	
		private struct GUIGlobals // TypeDefIndex: 43220
		{
			// Fields
			public Matrix4x4 matrix; // 0x00
			public UnityEngine.Color color; // 0x40
			public UnityEngine.Color contentColor; // 0x50
			public UnityEngine.Color backgroundColor; // 0x60
			public bool enabled; // 0x70
			public bool changed; // 0x71
			public int displayIndex; // 0x74
		}
	
		// Constructors
		static IMGUIContainer() {} // 0x0000000189E75478-0x0000000189E75854
		public IMGUIContainer() {} // 0x0000000189E75A38-0x0000000189E75A44
		public IMGUIContainer(Action onGUIHandler) {} // 0x0000000189E75854-0x0000000189E75A38
	
		// Methods
		private void OnGenerateVisualContent(MeshGenerationContext mgc) {} // 0x0000000189E74BE4-0x0000000189E74CFC
		private void SaveGlobals() {} // 0x0000000189E74E3C-0x0000000189E74F3C
		private void RestoreGlobals() {} // 0x0000000189E74CFC-0x0000000189E74E3C
		private void DoOnGUI(UnityEngine.Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true /* Metadata: 0x01FB5DC3 */) {} // 0x0000000189E72F5C-0x0000000189E73EBC
		public void MarkDirtyLayout() {} // 0x0000000189E74BD0-0x0000000189E74BE4
		public override void HandleEvent(EventBase evt) {} // 0x0000000189E74328-0x0000000189E743A8
		private void DoIMGUIRepaint() {} // 0x0000000189E729F0-0x0000000189E72CD0
		internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true /* Metadata: 0x01FB5DC4 */, bool verifyBounds = true /* Metadata: 0x01FB5DC5 */) => default; // 0x0000000189E75014-0x0000000189E752A4
		private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds) => default; // 0x0000000189E74F3C-0x0000000189E75014
		private bool VerifyBounds(EventBase evt) => default; // 0x0000000189E753E8-0x0000000189E75478
		private bool IsContainerCapturingTheMouse() => default; // 0x0000000189E747CC-0x0000000189E74864
		private bool IsLocalEvent(EventBase evt) => default; // 0x0000000189E74A3C-0x0000000189E74BD0
		private bool IsEventInsideLocalWindow(EventBase evt) => default; // 0x0000000189E7492C-0x0000000189E74A3C
		private static bool IsDockAreaMouseUp(EventBase evt) => default; // 0x0000000189E74864-0x0000000189E7492C
		private bool HandleIMGUIEvent(UnityEngine.Event e, bool canAffectFocus) => default; // 0x0000000189E74490-0x0000000189E744B4
		internal bool HandleIMGUIEvent(UnityEngine.Event e, Action onGUIHandler, bool canAffectFocus) => default; // 0x0000000189E743A8-0x0000000189E74490
		private bool HandleIMGUIEvent(UnityEngine.Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) => default; // 0x0000000189E744B4-0x0000000189E747CC
		protected override void ExecuteDefaultAction(EventBase evt) {} // 0x0000000189E73EBC-0x0000000189E74120
		private void SetFoldoutDepthClass() {} // 0x0000000189E752A4-0x0000000189E753D8
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x0000000189E72CD0-0x0000000189E72F5C
		private Rect GetCurrentClipRect() => default; // 0x0000000189E74120-0x0000000189E74198
		private static void GetCurrentTransformAndClip(IMGUIContainer container, UnityEngine.Event evt, out Matrix4x4 transform, out Rect clipRect) {
			transform = default;
			clipRect = default;
		} // 0x0000000189E74198-0x0000000189E74328
		public void Dispose() {} // 0x0000000189E72980-0x0000000189E729D0
		protected virtual void Dispose(bool disposeManaged) {} // 0x0000000189E729D0-0x0000000189E729F0
	}

	internal class ImmediateModeException : Exception // TypeDefIndex: 43222
	{
		// Constructors
		public ImmediateModeException() {} // Dummy constructor
		public ImmediateModeException(Exception inner) {} // 0x0000000189E75C50-0x0000000189E75CB4
	}

	public enum SelectionType // TypeDefIndex: 43223
	{
		None = 0,
		Single = 1,
		Multiple = 2
	}

	internal interface ISerializableJsonDictionary // TypeDefIndex: 43224
	{
		// Methods
		void Set<T>(string key, T value)
			where T : class;
		T Get<T>(string key)
			where T : class;
		void Overwrite(object obj, string key);
		bool ContainsKey(string key);
	}

	public interface ITransform // TypeDefIndex: 43225
	{
		// Properties
		Vector3 position { get; set; }
		Vector3 scale { get; }
	}

	public enum KeyboardNavigationOperation // TypeDefIndex: 43226
	{
		None = 0,
		SelectAll = 1,
		Cancel = 2,
		Submit = 3,
		Previous = 4,
		Next = 5,
		MoveRight = 6,
		MoveLeft = 7,
		PageUp = 8,
		PageDown = 9,
		Begin = 10,
		End = 11
	}

	public class KeyboardNavigationManipulator : Manipulator // TypeDefIndex: 43229
	{
		// Fields
		private readonly Action<KeyboardNavigationOperation, EventBase> m_Action; // 0x18
	
		// Constructors
		public KeyboardNavigationManipulator() {} // Dummy constructor
		public KeyboardNavigationManipulator(Action<KeyboardNavigationOperation, EventBase> action) {} // 0x00000001822C3A90-0x00000001822C3AA0
	
		// Methods
		protected override void RegisterCallbacksOnTarget() {} // 0x0000000189E75E50-0x0000000189E7604C
		protected override void UnregisterCallbacksFromTarget() {} // 0x0000000189E761EC-0x0000000189E763E8
		internal void OnKeyDown(KeyDownEvent evt) {} // 0x0000000189E75D34-0x0000000189E75D94
		private void OnRuntimeKeyDown(KeyDownEvent evt) {} // 0x0000000189E75E14-0x0000000189E75E50
		private void OnEditorKeyDown(KeyDownEvent evt) {} // 0x0000000189E75CF8-0x0000000189E75D34
		private void OnNavigationCancel(NavigationCancelEvent evt) {} // 0x0000000189E75D94-0x0000000189E75DA4
		private void OnNavigationSubmit(NavigationSubmitEvent evt) {} // 0x0000000189E75E04-0x0000000189E75E14
		private void OnNavigationMove(NavigationMoveEvent evt) {} // 0x0000000189E75DA4-0x0000000189E75E04
		private void Invoke(KeyboardNavigationOperation operation, EventBase evt) {} // 0x0000000189E75CD4-0x0000000189E75CF8
	}

	public struct ManipulatorActivationFilter : IEquatable<ManipulatorActivationFilter> // TypeDefIndex: 43230
	{
		// Properties
		public MouseButton button { [IsReadOnly] get; set; } // 0x0000000183D4E980-0x0000000183D4E990 0x0000000183D4E970-0x0000000183D4E980
		public EventModifiers modifiers { [IsReadOnly] get; set; } // 0x0000000183D4E990-0x0000000183D4E9A0 0x0000000183D51720-0x0000000183D51730
		public int clickCount { [IsReadOnly] get; } // 0x0000000183D516F0-0x0000000183D51700 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189E764BC-0x0000000189E7653C
		public bool Equals(ManipulatorActivationFilter other) => default; // 0x00000001851408A4-0x00000001851408C0
		public override int GetHashCode() => default; // 0x0000000183D88640-0x0000000183D88660
		public bool Matches(IMouseEvent e) => default; // 0x0000000189E76754-0x0000000189E767D4
		private bool HasModifiers(IMouseEvent e) => default; // 0x0000000189E765C4-0x0000000189E7664C
		public bool Matches(IPointerEvent e) => default; // 0x0000000189E766D4-0x0000000189E76754
		private bool HasModifiers(IPointerEvent e) => default; // 0x0000000189E7653C-0x0000000189E765C4
		private bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command) => default; // 0x0000000189E7664C-0x0000000189E766D4
	}

	public interface IManipulator // TypeDefIndex: 43231
	{
		// Properties
		VisualElement target { get; set; }
	}

	public abstract class Manipulator : IManipulator // TypeDefIndex: 43232
	{
		// Fields
		private VisualElement m_Target; // 0x10
	
		// Properties
		public VisualElement target { get; set; } // 0x0000000183D66B80-0x0000000183D66B90 0x0000000189E767D4-0x0000000189E76824
	
		// Constructors
		protected Manipulator() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected abstract void RegisterCallbacksOnTarget();
		protected abstract void UnregisterCallbacksFromTarget();
	}

	public enum MouseButton // TypeDefIndex: 43233
	{
		LeftMouse = 0,
		RightMouse = 1,
		MiddleMouse = 2
	}

	public static class MouseCaptureController // TypeDefIndex: 43234
	{
		// Extension methods
		public static bool HasMouseCapture(this IEventHandler handler) => default; // 0x0000000189E768BC-0x0000000189E7692C
		public static void CaptureMouse(this IEventHandler handler) {} // 0x0000000189E76824-0x0000000189E768BC
		public static void ReleaseMouse(this IEventHandler handler) {} // 0x0000000189E7692C-0x0000000189E769C4
	}

	public abstract class MouseManipulator : Manipulator // TypeDefIndex: 43235
	{
		// Fields
		private ManipulatorActivationFilter m_currentActivator; // 0x20
	
		// Properties
		public List<ManipulatorActivationFilter> activators { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		protected MouseManipulator() {} // 0x0000000189E76B4C-0x0000000189E76BC4
	
		// Methods
		protected bool CanStartManipulation(IMouseEvent e) => default; // 0x0000000189E769C4-0x0000000189E76B28
		protected bool CanStopManipulation(IMouseEvent e) => default; // 0x0000000189E76B28-0x0000000189E76B4C
	}

	internal class ObjectPool<T> // TypeDefIndex: 43236
		where T : new()
	{
		// Fields
		private readonly Stack<T> m_Stack;
		private int m_MaxSize;
	
		// Properties
		public int maxSize { get => default; set {} }
	
		// Constructors
		public ObjectPool() {} // Dummy constructor
		public ObjectPool(int maxSize = 100 /* Metadata: 0x01FB5DD8 */) {}
	
		// Methods
		public int Size() => default;
		public T Get() => default;
		public void Release(T element) {}
	}

	public enum ContextType // TypeDefIndex: 43237
	{
		Player = 0,
		Editor = 1
	}

	[Flags]
	internal enum VersionChangeType // TypeDefIndex: 43238
	{
		Bindings = 1,
		ViewData = 2,
		Hierarchy = 4,
		Layout = 8,
		StyleSheet = 16,
		Styles = 32,
		Overflow = 64,
		BorderRadius = 128,
		BorderWidth = 256,
		Transform = 512,
		Size = 1024,
		Repaint = 2048,
		Opacity = 4096,
		Color = 8192,
		RenderHints = 16384,
		TransitionProperty = 32768
	}

	[Flags]
	public enum UsageHints // TypeDefIndex: 43239
	{
		None = 0,
		DynamicTransform = 1,
		GroupTransform = 2,
		MaskContainer = 4,
		DynamicColor = 8
	}

	[Flags]
	internal enum RenderHints // TypeDefIndex: 43240
	{
		None = 0,
		GroupTransform = 1,
		BoneTransform = 2,
		ClipWithScissors = 4,
		DirtyOffset = 5,
		MaskContainer = 8,
		DynamicColor = 16,
		DirtyGroupTransform = 32,
		DirtyBoneTransform = 64,
		DirtyClipWithScissors = 128,
		DirtyMaskContainer = 256,
		DirtyAll = 480
	}

	internal struct PanelClearSettings // TypeDefIndex: 43241
	{
		// Fields
		public bool clearDepthStencil; // 0x00
		public bool clearColor; // 0x01
		public UnityEngine.Color color; // 0x04
	}

	internal class RepaintData // TypeDefIndex: 43242
	{
		// Properties
		public Matrix4x4 currentOffset { get; } // 0x0000000183D5E0E0-0x0000000183D5E110 
		public Rect currentWorldClip { get; } // 0x0000000183D50820-0x0000000183D50830 
		public UnityEngine.Event repaintEvent { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
	
		// Constructors
		public RepaintData() {} // 0x0000000189E77DE8-0x0000000189E77E20
	}

	internal delegate void HierarchyEvent(VisualElement ve, HierarchyChangeType changeType); // TypeDefIndex: 43243; 0x0000000182065C10-0x0000000182065C20

	public interface IPanel : IDisposable // TypeDefIndex: 43244
	{
		// Properties
		VisualElement visualTree { get; }
		EventDispatcher dispatcher { get; }
		ContextType contextType { get; }
		FocusController focusController { get; }
	
		// Methods
		VisualElement Pick(Vector2 point);
	}

	internal abstract class BaseVisualElementPanel : IPanel, IGroupBox // TypeDefIndex: 43245
	{
		// Fields
		private float m_Scale; // 0x18
		internal YogaConfig yogaConfig; // 0x20
		private float m_PixelsPerPoint; // 0x28
		internal ElementUnderPointer m_TopElementUnderPointers; // 0x68
	
		// Properties
		public abstract EventInterests IMGUIEventInterests { get; set; }
		public abstract ScriptableObject ownerObject { get; protected set; }
		public abstract SavePersistentViewData saveViewData { get; }
		public abstract GetViewDataDictionary getViewDataDictionary { get; }
		public abstract int IMGUIContainersCount { get; set; }
		public abstract FocusController focusController { get; set; }
		public abstract IMGUIContainer rootIMGUIContainer { get; }
		internal float scale { get; set; } // 0x0000000183D85C60-0x0000000183D85C70 0x0000000189E694A4-0x0000000189E69538
		internal float pixelsPerPoint { get; set; } // 0x0000000189E69410-0x0000000189E694A4
		public float scaledPixelsPerPoint { get; } // 0x0000000183D88510-0x0000000183D88520 
		internal PanelClearSettings clearSettings { get; set; } // 0x0000000183D884F0-0x0000000183D88510 0x0000000183D88520-0x0000000183D88530
		internal bool duringLayoutPhase { get; set; } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000183D4EEB0-0x0000000183D4EEC0
		internal abstract uint version { get; }
		internal abstract uint hierarchyVersion { get; }
		internal virtual RepaintData repaintData { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		internal virtual ICursorManager cursorManager { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public ContextualMenuManager contextualMenuManager { get; internal set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public abstract VisualElement visualTree { get; }
		public abstract EventDispatcher dispatcher { get; set; }
		internal abstract IScheduler scheduler { get; }
		internal abstract IStylePropertyAnimationSystem styleAnimationSystem { get; set; }
		public abstract ContextType contextType { get; protected set; }
		internal bool disposed { get; private set; } // 0x0000000183D519A0-0x0000000183D519B0 0x0000000183D519B0-0x0000000183D519C0
		internal abstract Shader standardShader { get; }
		internal virtual Shader standardWorldSpaceShader { get; } // 0x0000000183D85B20-0x0000000183D85B30 
		public abstract AtlasBase atlas { get; set; }
	
		// Events
		internal event Action<BaseVisualElementPanel> panelDisposed;
		internal event Action standardShaderChanged;
		internal event Action standardWorldSpaceShaderChanged;
		internal event Action atlasChanged;
		internal event HierarchyEvent hierarchyChanged;
	
		// Constructors
		protected BaseVisualElementPanel() {} // 0x0000000189E68D28-0x0000000189E68E48
	
		// Methods
		public void Dispose() {} // 0x0000000189E6877C-0x0000000189E687CC
		protected virtual void Dispose(bool disposing) {} // 0x0000000189E687CC-0x0000000189E688C0
		public abstract void Repaint(UnityEngine.Event e);
		public abstract void ValidateLayout();
		public abstract void UpdateAnimations();
		public abstract void UpdateBindings();
		public abstract void ApplyStyles();
		internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag);
		internal void SendEvent(EventBase e, DispatchMode dispatchMode = DispatchMode.Default /* Metadata: 0x01FB5E11 */) {} // 0x0000000189E68A48-0x0000000189E68AE0
		public abstract VisualElement Pick(Vector2 point);
		public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked);
		internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase);
		internal VisualElement GetTopElementUnderPointer(int pointerId) => default; // 0x0000000189E688C0-0x0000000189E688E0
		internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent) => default; // 0x0000000189E68950-0x0000000189E68A48
		internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent) {} // 0x0000000189E686F0-0x0000000189E68720
		internal void CommitElementUnderPointers() {} // 0x0000000189E68720-0x0000000189E6877C
		protected void InvokeAtlasChanged() {} // 0x0000000189E688E0-0x0000000189E688F4
		internal void InvokeUpdateMaterial(Material mat) {} // 0x0000000189E68938-0x0000000189E68950
		internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) {} // 0x0000000189E68910-0x0000000189E68938
		internal void InvokeBeforeUpdate() {} // 0x0000000189E688F4-0x0000000189E68910
		internal void UpdateElementUnderPointers() {} // 0x0000000189E68AE0-0x0000000189E68C84
		public virtual void Update() {} // 0x0000000189E68C84-0x0000000189E68D28
	}

	internal delegate UnityEngine.Object LoadResourceFunction(string pathName, System.Type type, float dpiScaling); // TypeDefIndex: 43246; 0x0000000181022980-0x00000001810229A0

	internal delegate long TimeMsFunction(); // TypeDefIndex: 43247; 0x0000000186F0A8DC-0x0000000186F0A8EC

	internal delegate ISerializableJsonDictionary GetViewDataDictionary(); // TypeDefIndex: 43248; 0x0000000186F0A8DC-0x0000000186F0A8EC

	internal delegate void SavePersistentViewData(); // TypeDefIndex: 43249; 0x00000001842BE03C-0x00000001842BE04C

	internal class Panel : BaseVisualElementPanel // TypeDefIndex: 43250
	{
		// Fields
		private VisualElement m_RootContainer; // 0xA0
		private VisualTreeUpdater m_VisualTreeUpdater; // 0xA8
		private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem; // 0xB0
		private string m_PanelName; // 0xB8
		private uint m_Version; // 0xC0
		private uint m_RepaintVersion; // 0xC4
		private uint m_HierarchyVersion; // 0xC8
		private ProfilerMarker m_MarkerBeforeUpdate; // 0xD0
		private ProfilerMarker m_MarkerUpdate; // 0xD8
		private ProfilerMarker m_MarkerLayout; // 0xE0
		private ProfilerMarker m_MarkerBindings; // 0xE8
		private ProfilerMarker m_MarkerAnimations; // 0xF0
		private static ProfilerMarker s_MarkerPickAll; // 0x00
		private TimerEventScheduler m_Scheduler; // 0x100
		private Shader m_StandardShader; // 0x140
		private AtlasBase m_Atlas; // 0x148
		private bool m_ValidatingLayout; // 0x150
	
		// Properties
		public sealed override VisualElement visualTree { get => default; } // 0x0000000183D87D10-0x0000000183D87D20 
		public sealed override EventDispatcher dispatcher { get; set; } // 0x0000000183D50160-0x0000000183D50170 0x000000018554D2E0-0x000000018554D2F4
		public TimerEventScheduler timerEventScheduler { get => default; } // 0x0000000189E77C3C-0x0000000189E77CB8 
		internal override IScheduler scheduler { get => default; } // 0x0000000189E77C30-0x0000000189E77C3C 
		internal override IStylePropertyAnimationSystem styleAnimationSystem { get => default; set {} } // 0x0000000183D4EAD0-0x0000000183D4EAE0 0x0000000189E77D50-0x0000000189E77DE8
		public override ScriptableObject ownerObject { get; protected set; } // 0x0000000183D56D30-0x0000000183D56D40 0x000000018589D950-0x000000018589D964
		public override ContextType contextType { get; protected set; } // 0x0000000183D5D640-0x0000000183D5D650 0x0000000183D5D660-0x0000000183D5D670
		public override SavePersistentViewData saveViewData { get; } // 0x0000000183D571F0-0x0000000183D57200 
		public override GetViewDataDictionary getViewDataDictionary { get; } // 0x0000000183D56D50-0x0000000183D56D60 
		public sealed override FocusController focusController { get; set; } // 0x0000000183D56F00-0x0000000183D56F10 0x0000000184275CB8-0x0000000184275CCC
		public override EventInterests IMGUIEventInterests { get; set; } // 0x0000000183D88680-0x0000000183D886A0 0x0000000183D886D0-0x0000000183D886F0
		private static LoadResourceFunction loadResourceFunc { get; } // 0x0000000189E77BE0-0x0000000189E77C30 
		internal string name { get => default; set {} } // 0x0000000183D87DD0-0x0000000183D87DE0 0x0000000189E77D28-0x0000000189E77D50
		private static TimeMsFunction TimeSinceStartup { get; } // 0x0000000189E77B90-0x0000000189E77BE0 
		public override int IMGUIContainersCount { get; set; } // 0x0000000183D4FC40-0x0000000183D4FC50 0x0000000183D886C0-0x0000000183D886D0
		public override IMGUIContainer rootIMGUIContainer { get; } // 0x0000000183D56EF0-0x0000000183D56F00 
		internal override uint version { get => default; } // 0x0000000183D57EF0-0x0000000183D57F00 
		internal override uint hierarchyVersion { get => default; } // 0x0000000183D51FB0-0x0000000183D51FC0 
		internal override Shader standardShader { get => default; } // 0x0000000183D886B0-0x0000000183D886C0 
		public override AtlasBase atlas { get => default; set {} } // 0x0000000183D886A0-0x0000000183D886B0 0x0000000189E77CB8-0x0000000189E77D28
	
		// Constructors
		public Panel() {} // Dummy constructor
		public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher) {} // 0x0000000189E77830-0x0000000189E77B90
		static Panel() {} // 0x0000000189E777D0-0x0000000189E77830
	
		// Methods
		internal static UnityEngine.Object LoadResource(string pathName, System.Type type, float dpiScaling) => default; // 0x0000000189E76F34-0x0000000189E76FDC
		internal void Focus() {} // 0x0000000189E76EE4-0x0000000189E76F10
		internal void Blur() {} // 0x0000000189E76BEC-0x0000000189E76C18
		private void CreateMarkers() {} // 0x0000000189E76C18-0x0000000189E76E6C
		protected override void Dispose(bool disposing) {} // 0x0000000189E76E8C-0x0000000189E76EE4
		public static long TimeSinceStartupMs() => default; // 0x0000000189E775E8-0x0000000189E77678
		internal static long DefaultTimeSinceStartupMs() => default; // 0x0000000189E76E6C-0x0000000189E76E8C
		private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null) => default; // 0x0000000189E772A4-0x0000000189E77308
		private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null) => default; // 0x0000000189E77024-0x0000000189E77200
		public override VisualElement PickAll(Vector2 point, List<VisualElement> picked) => default; // 0x0000000189E77200-0x0000000189E772A4
		public override VisualElement Pick(Vector2 point) => default; // 0x0000000189E77308-0x0000000189E77434
		public override void ValidateLayout() {} // 0x0000000189E7775C-0x0000000189E777D0
		public override void UpdateAnimations() {} // 0x0000000189E77680-0x0000000189E776A8
		public override void UpdateBindings() {} // 0x0000000189E776A8-0x0000000189E776D0
		public override void ApplyStyles() {} // 0x0000000189E76BC4-0x0000000189E76BEC
		private void UpdateForRepaint() {} // 0x0000000189E776D0-0x0000000189E7775C
		public override void Repaint(UnityEngine.Event e) {} // 0x0000000189E77434-0x0000000189E775E8
		internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x0000000189E76FDC-0x0000000189E77024
		internal override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) => default; // 0x0000000189E76F10-0x0000000189E76F34
	}

	internal abstract class BaseRuntimePanel : UnityEngine.UIElements.Panel // TypeDefIndex: 43252
	{
		// Fields
		private GameObject m_SelectableGameObject; // 0x158
		private static int s_CurrentRuntimePanelCounter; // 0x00
		internal readonly int m_RuntimePanelCreationIndex; // 0x160
		private float m_SortingPriority; // 0x164
		private Shader m_StandardWorldSpaceShader; // 0x170
		private bool m_DrawToCameras; // 0x178
		internal RenderTexture targetTexture; // 0x180
		internal Matrix4x4 panelToWorld; // 0x188
		internal static readonly Func<Vector2, Vector2> DefaultScreenToPanelSpace; // 0x08
		private Func<Vector2, Vector2> m_ScreenToPanelSpace; // 0x1D0
	
		// Properties
		public GameObject selectableGameObject { get; set; } // 0x0000000183D570A0-0x0000000183D570B0 0x0000000189E685E4-0x0000000189E68678
		public float sortingPriority { get; set; } // 0x0000000183D58290-0x0000000183D582A0 0x0000000189E68678-0x0000000189E686F0
		internal override Shader standardWorldSpaceShader { get; } // 0x0000000183D884D0-0x0000000183D884E0 
		internal bool drawToCameras { get; set; } // 0x0000000183D884C0-0x0000000183D884D0 0x0000000189E684F4-0x0000000189E6856C
		internal int targetDisplay { get; set; } // 0x0000000183D5DDB0-0x0000000183D5DDC0 0x0000000183D884E0-0x0000000183D884F0
		internal int screenRenderingWidth { get; } // 0x0000000189E683A4-0x0000000189E6845C 
		internal int screenRenderingHeight { get; } // 0x0000000189E682EC-0x0000000189E683A4 
		public Func<Vector2, Vector2> screenToPanelSpace { get; set; } // 0x0000000183D57000-0x0000000183D57010 0x0000000189E6856C-0x0000000189E685E4
	
		// Events
		public event Action destroyed;
	
		// Constructors
		protected BaseRuntimePanel() {} // Dummy constructor
		protected BaseRuntimePanel(ScriptableObject ownerObject, EventDispatcher dispatcher = null) {} // 0x0000000189E68140-0x0000000189E68254
		static BaseRuntimePanel() {} // 0x0000000189E68064-0x0000000189E68140
	
		// Methods
		protected override void Dispose(bool disposing) {} // 0x0000000189E67B7C-0x0000000189E67BC0
		public override void Repaint(UnityEngine.Event e) {} // 0x0000000189E67CD8-0x0000000189E67ED8
		internal Vector2 ScreenToPanel(Vector2 screen) => default; // 0x0000000189E67ED8-0x0000000189E67F28
		internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = false /* Metadata: 0x01FB5E12 */) {
			panelPosition = default;
			panelDelta = default;
			return default;
		} // 0x0000000189E67F28-0x0000000189E68064
		private void AssignPanelToComponents(BaseRuntimePanel panel) {} // 0x0000000189E678CC-0x0000000189E67B7C
		internal void PointerLeavesPanel(int pointerId, Vector2 position) {} // 0x0000000189E67C44-0x0000000189E67CD8
		internal void PointerEntersPanel(int pointerId, Vector2 position) {} // 0x0000000189E67BC0-0x0000000189E67C44
	}

	internal interface IRuntimePanelComponent // TypeDefIndex: 43253
	{
		// Properties
		IPanel panel { get; set; }
	}

	public static class PointerCaptureHelper // TypeDefIndex: 43254
	{
		// Methods
		private static PointerDispatchState GetStateFor(IEventHandler handler) => default; // 0x0000000189E7C7A0-0x0000000189E7C808
	
		// Extension methods
		public static bool HasPointerCapture(this IEventHandler handler, int pointerId) => default; // 0x0000000189E7C808-0x0000000189E7C844
		public static void CapturePointer(this IEventHandler handler, int pointerId) {} // 0x0000000189E7C720-0x0000000189E7C758
		public static void ReleasePointer(this IEventHandler handler, int pointerId) {} // 0x0000000189E7C8B4-0x0000000189E7C8EC
		public static IEventHandler GetCapturingElement(this IPanel panel, int pointerId) => default; // 0x0000000189E7C758-0x0000000189E7C7A0
		public static void ReleasePointer(this IPanel panel, int pointerId) {} // 0x0000000189E7C8EC-0x0000000189E7C924
		internal static void ActivateCompatibilityMouseEvents(this IPanel panel, int pointerId) {} // 0x0000000189E7C6E8-0x0000000189E7C720
		internal static void PreventCompatibilityMouseEvents(this IPanel panel, int pointerId) {} // 0x0000000189E7C844-0x0000000189E7C87C
		internal static bool ShouldSendCompatibilityMouseEvents(this IPanel panel, IPointerEvent evt) => default; // 0x0000000189E7C924-0x0000000189E7C9E0
		internal static void ProcessPointerCapture(this IPanel panel, int pointerId) {} // 0x0000000189E7C87C-0x0000000189E7C8B4
	}

	internal class PointerDispatchState // TypeDefIndex: 43255
	{
		// Fields
		private IEventHandler[] m_PendingPointerCapture; // 0x10
		private IEventHandler[] m_PointerCapture; // 0x18
		private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20
	
		// Constructors
		public PointerDispatchState() {} // 0x0000000189E7D264-0x0000000189E7D338
	
		// Methods
		internal void Reset() {} // 0x0000000189E7D18C-0x0000000189E7D204
		public IEventHandler GetCapturingElement(int pointerId) => default; // 0x000000018594E120-0x000000018594E14C
		public bool HasPointerCapture(IEventHandler handler, int pointerId) => default; // 0x0000000189E7CAF8-0x0000000189E7CB28
		public void CapturePointer(IEventHandler handler, int pointerId) {} // 0x0000000189E7CA10-0x0000000189E7CAF8
		public void ReleasePointer(int pointerId) {} // 0x0000000189E7D124-0x0000000189E7D148
		public void ReleasePointer(IEventHandler handler, int pointerId) {} // 0x0000000189E7D148-0x0000000189E7D18C
		public void ProcessPointerCapture(int pointerId) {} // 0x0000000189E7CB58-0x0000000189E7D124
		public void ActivateCompatibilityMouseEvents(int pointerId) {} // 0x0000000189E7C9E0-0x0000000189E7CA10
		public void PreventCompatibilityMouseEvents(int pointerId) {} // 0x0000000189E7CB28-0x0000000189E7CB58
		public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) => default; // 0x0000000189E7D204-0x0000000189E7D264
	}

	public abstract class PointerManipulator : MouseManipulator // TypeDefIndex: 43256
	{
		// Fields
		private int m_CurrentPointerId; // 0x30
	
		// Constructors
		protected PointerManipulator() {} // 0x0000000189E7D4C8-0x0000000189E7D4D0
	
		// Methods
		protected bool CanStartManipulation(IPointerEvent e) => default; // 0x0000000189E7D338-0x0000000189E7D4A4
		protected bool CanStopManipulation(IPointerEvent e) => default; // 0x0000000189E7D4A4-0x0000000189E7D4C8
	}

	internal static class ProjectionUtils // TypeDefIndex: 43257
	{
		// Methods
		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far) => default; // 0x0000000189E7D4D0-0x0000000189E7D5EC
	}

	public struct TimerState : IEquatable<UnityEngine.UIElements.TimerState> // TypeDefIndex: 43258
	{
		// Properties
		public long start { [IsReadOnly] get; set; } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		public long now { [IsReadOnly] get; set; } // 0x0000000183D50DE0-0x0000000183D50DF0 0x0000000183D55BA0-0x0000000183D55BB0
		public long deltaTime { get => default; } // 0x0000000183D88740-0x0000000183D88750 
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189E7E3B0-0x0000000189E7E428
		public bool Equals(TimerState other) => default; // 0x0000000189E7E384-0x0000000189E7E3B0
		public override int GetHashCode() => default; // 0x0000000183D88700-0x0000000183D88740
	}

	internal interface IScheduler // TypeDefIndex: 43259
	{
		// Methods
		void Unschedule(ScheduledItem item);
		void Schedule(ScheduledItem item);
		void UpdateScheduledEvents();
	}

	internal abstract class ScheduledItem // TypeDefIndex: 43261
	{
		// Fields
		public Func<bool> timerUpdateStopCondition; // 0x10
		public static readonly Func<bool> OnceCondition; // 0x00
		public static readonly Func<bool> ForeverCondition; // 0x08
	
		// Properties
		public long startMs { get; set; } // 0x0000000181041090-0x00000001810410A0 0x0000000183D4EC10-0x0000000183D4EC20
		public long delayMs { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000183D4ED30-0x0000000183D4ED40
		public long intervalMs { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000183D4ED70-0x0000000183D4ED80
		public long endTimeMs { get; } // 0x0000000181003830-0x0000000181003840 
	
		// Constructors
		public ScheduledItem() {} // 0x0000000189E7D790-0x0000000189E7D7F0
		static ScheduledItem() {} // 0x0000000189E7D658-0x0000000189E7D790
	
		// Methods
		protected void ResetStartTime() {} // 0x0000000189E7D5EC-0x0000000189E7D638
		public abstract void PerformTimerUpdate(UnityEngine.UIElements.TimerState state);
		internal virtual void OnItemUnscheduled() {} // 0x000000018350B670-0x000000018350B680
		public virtual bool ShouldUnschedule() => default; // 0x0000000189E7D638-0x0000000189E7D658
	}

	internal class TimerEventScheduler : IScheduler // TypeDefIndex: 43262
	{
		// Fields
		private readonly List<ScheduledItem> m_ScheduledItems; // 0x10
		private bool m_TransactionMode; // 0x18
		private readonly List<ScheduledItem> m_ScheduleTransactions; // 0x20
		private readonly HashSet<ScheduledItem> m_UnscheduleTransactions; // 0x28
		internal bool disableThrottling; // 0x30
		private int m_LastUpdatedIndex; // 0x34
	
		// Constructors
		public TimerEventScheduler() {} // 0x0000000189E7E1F8-0x0000000189E7E2F4
	
		// Methods
		public void Schedule(ScheduledItem item) {} // 0x0000000189E7D9E8-0x0000000189E7DBDC
		private bool RemovedScheduledItemAt(int index) => default; // 0x0000000189E7D978-0x0000000189E7D9E8
		public void Unschedule(ScheduledItem item) {} // 0x0000000189E7DBDC-0x0000000189E7DE4C
		private bool PrivateUnSchedule(ScheduledItem sItem) => default; // 0x0000000189E7D8DC-0x0000000189E7D978
		public void UpdateScheduledEvents() {} // 0x0000000189E7DE4C-0x0000000189E7E1F8
	}

	internal struct Spacing // TypeDefIndex: 43263
	{
		// Fields
		public float left; // 0x00
		public float top; // 0x04
		public float right; // 0x08
		public float bottom; // 0x0C
	
		// Properties
		public float horizontal { get => default; } // 0x0000000183D85E70-0x0000000183D85E80 
		public float vertical { get => default; } // 0x0000000183D85E00-0x0000000183D85E10 
	
		// Constructors
		public Spacing(float left, float top, float right, float bottom) : this() {
			this.left = default;
			this.top = default;
			this.right = default;
			this.bottom = default;
		} // 0x0000000183D516B0-0x0000000183D516D0
	
		// Methods
		public static Rect operator -(Rect r, Spacing a) => default; // 0x0000000189E7D870-0x0000000189E7D8DC
	}

	public enum Position // TypeDefIndex: 43264
	{
		Relative = 0,
		Absolute = 1
	}

	internal enum OverflowInternal // TypeDefIndex: 43265
	{
		Visible = 0,
		Hidden = 1,
		Scroll = 2
	}

	public enum OverflowClipBox // TypeDefIndex: 43266
	{
		PaddingBox = 0,
		ContentBox = 1
	}

	public enum FlexDirection // TypeDefIndex: 43267
	{
		Column = 0,
		ColumnReverse = 1,
		Row = 2,
		RowReverse = 3
	}

	public enum Wrap // TypeDefIndex: 43268
	{
		NoWrap = 0,
		Wrap = 1,
		WrapReverse = 2
	}

	public enum Align // TypeDefIndex: 43269
	{
		Auto = 0,
		FlexStart = 1,
		Center = 2,
		FlexEnd = 3,
		Stretch = 4
	}

	public enum Justify // TypeDefIndex: 43270
	{
		FlexStart = 0,
		Center = 1,
		FlexEnd = 2,
		SpaceBetween = 3,
		SpaceAround = 4
	}

	public enum TextOverflowPosition // TypeDefIndex: 43271
	{
		End = 0,
		Start = 1,
		Middle = 2
	}

	public enum TextOverflow // TypeDefIndex: 43272
	{
		Clip = 0,
		Ellipsis = 1
	}

	public enum TransformOriginOffset // TypeDefIndex: 43273
	{
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4,
		Center = 5
	}

	public enum Visibility // TypeDefIndex: 43274
	{
		Visible = 0,
		Hidden = 1
	}

	public enum WhiteSpace // TypeDefIndex: 43275
	{
		Normal = 0,
		NoWrap = 1
	}

	public enum DisplayStyle // TypeDefIndex: 43276
	{
		Flex = 0,
		None = 1
	}

	internal interface IStylePainter // TypeDefIndex: 43277
	{
		// Methods
		void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint);
		void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams);
		void DrawImmediate(Action callback, bool cullingEnabled);
	}

	internal struct CursorPositionStylePainterParameters // TypeDefIndex: 43278
	{
		// Fields
		public Rect rect; // 0x00
		public string text; // 0x10
		public Font font; // 0x18
		public int fontSize; // 0x20
		public FontStyle fontStyle; // 0x24
		public TextAnchor anchor; // 0x28
		public float wordWrapWidth; // 0x2C
		public bool richText; // 0x30
		public int cursorIndex; // 0x34
	
		// Methods
		public static CursorPositionStylePainterParameters GetDefault(VisualElement ve, string text) => default; // 0x0000000189E7A964-0x0000000189E7AAE0
		internal TextNativeSettings GetTextNativeSettings(float scaling) => default; // 0x0000000189E7AAE0-0x0000000189E7ABBC
	}

	internal interface IStylePropertyAnimations // TypeDefIndex: 43279
	{
		// Properties
		int runningAnimationCount { get; set; }
		int completedAnimationCount { get; set; }
	
		// Methods
		bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve);
		bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve);
		void UpdateAnimation(StylePropertyId id);
		void GetAllAnimations(List<StylePropertyId> outPropertyIds);
		void CancelAnimation(StylePropertyId id);
		void CancelAllAnimations();
	}

	public class VisualElement : Focusable, IStylePropertyAnimations, ITransform, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler, IResolvedStyle // TypeDefIndex: 43292
	{
		// Fields
		private static uint s_NextId; // 0x00
		private static List<string> s_EmptyClassList; // 0x08
		internal static readonly PropertyName userDataPropertyKey; // 0x10
		public static readonly string disabledUssClassName; // 0x18
		private string m_Name; // 0x38
		private List<string> m_ClassList; // 0x40
		private List<KeyValuePair<PropertyName, object>> m_PropertyBag; // 0x48
		internal VisualElementFlags m_Flags; // 0x50
		private string m_ViewDataKey; // 0x58
		private RenderHints m_RenderHints; // 0x60
		internal Rect lastLayout; // 0x64
		internal Rect lastPseudoPadding; // 0x74
		internal RenderChainVEData renderChainData; // 0x88
		private Rect m_Layout; // 0x1E0
		private Rect m_BoundingBox; // 0x1F0
		private Rect m_WorldBoundingBox; // 0x200
		private Matrix4x4 m_WorldTransformCache; // 0x210
		private Matrix4x4 m_WorldTransformInverseCache; // 0x250
		private Rect m_WorldClip; // 0x290
		private Rect m_WorldClipMinusGroup; // 0x2A0
		private bool m_WorldClipIsInfinite; // 0x2B0
		internal static readonly Rect s_InfiniteRect; // 0x20
		internal PseudoStates triggerPseudoMask; // 0x2B4
		internal PseudoStates dependencyPseudoMask; // 0x2B8
		private PseudoStates m_PseudoStates; // 0x2BC
		internal ComputedStyle m_Style; // 0x2D0
		internal StyleVariableContext variableContext; // 0x328
		internal int inheritedStylesHash; // 0x330
		internal readonly uint controlid; // 0x334
		internal int imguiContainerDescendantCount; // 0x338
		private LanguageDirection m_LanguageDirection; // 0x340
		private LanguageDirection m_LocalLanguageDirection; // 0x344
		private ProfilerMarker k_GenerateVisualContentMarker; // 0x350
		private RenderTargetMode m_SubRenderTargetMode; // 0x358
		private static Material s_runtimeMaterial; // 0x30
		private Material m_defaultMaterial; // 0x360
		private List<IValueAnimationUpdate> m_RunningAnimations; // 0x368
		internal const string k_RootVisualContainerName = "rootVisualContainer"; // Metadata: 0x01FB5E3D
		private VisualElement m_PhysicalParent; // 0x380
		private VisualElement m_LogicalParent; // 0x388
		private static readonly List<VisualElement> s_EmptyList; // 0x38
		private List<VisualElement> m_Children; // 0x390
		private VisualTreeAsset m_VisualTreeAssetSource; // 0x3A0
		internal static CustomStyleAccess s_CustomStyleAccess; // 0x40
		internal InlineStyleAccess inlineStyleAccess; // 0x3A8
		internal List<StyleSheet> styleSheetList; // 0x3B0
		private static readonly Regex s_InternalStyleSheetPath; // 0x48
		internal static readonly PropertyName tooltipPropertyKey; // 0x50
		private static readonly Dictionary<System.Type, TypeData> s_TypeData; // 0x58
		private TypeData m_TypeData; // 0x3B8
	
		// Properties
		internal bool hasRunningAnimations { get => default; } // 0x0000000189E87DAC-0x0000000189E87DCC 
		internal bool hasCompletedAnimations { get => default; } // 0x0000000189E87CBC-0x0000000189E87CDC 
		int IStylePropertyAnimations.runningAnimationCount { get; set; } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
		int IStylePropertyAnimations.completedAnimationCount { get; set; } // 0x0000000183D4EE00-0x0000000183D4EE10 0x0000000183D4EE40-0x0000000183D4EE50
		internal IStylePropertyAnimations styleAnimation { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		internal bool isCompositeRoot { get => default; set {} } // 0x0000000189E87DD8-0x0000000189E87DE4 0x0000000189E88788-0x0000000189E887B4
		internal bool isHierarchyDisplayed { get => default; set {} } // 0x0000000189E87DE4-0x0000000189E87DF0 0x0000000189E887B4-0x0000000189E887E4
		public string viewDataKey { get => default; set {} } // 0x0000000183D87D70-0x0000000183D87D80 0x0000000189E88F3C-0x0000000189E88F90
		internal bool enableViewDataPersistence { get => default; private set {} } // 0x0000000189E87C5C-0x0000000189E87C68 0x0000000189E8872C-0x0000000189E8875C
		public object userData { get => default; set {} } // 0x0000000189E8840C-0x0000000189E88470 0x0000000189E88ED8-0x0000000189E88F3C
		public override bool canGrabFocus { get => default; } // 0x0000000189E8798C-0x0000000189E87A0C 
		public override FocusController focusController { get => default; } // 0x0000000189E87C78-0x0000000189E87C98 
		public UsageHints usageHints { get => default; set {} } // 0x0000000189E883F4-0x0000000189E8840C 0x0000000189E88E50-0x0000000189E88ED8
		internal RenderHints renderHints { get => default; set {} } // 0x0000000183D88AC0-0x0000000183D88AD0 0x0000000189E88C7C-0x0000000189E88CBC
		public ITransform transform { get => default; } // 0x0000000183D86CE0-0x0000000183D86CF0 
		Vector3 ITransform.position { get => default; set {} } // 0x0000000189E8643C-0x0000000189E8647C 0x0000000189E864BC-0x0000000189E86580
		Vector3 ITransform.scale { get => default; } // 0x0000000189E8647C-0x0000000189E864BC 
		internal bool isLayoutManual { get => default; private set {} } // 0x0000000189E87DF0-0x0000000189E87DFC 0x0000000189E887E4-0x0000000189E88810
		internal float scaledPixelsPerPoint { get => default; } // 0x0000000189E8816C-0x0000000189E8818C 
		public Rect layout { get => default; internal set {} } // 0x0000000189E87E84-0x0000000189E87F34 0x0000000189E88868-0x0000000189E88BC8
		public Rect contentRect { get => default; } // 0x0000000189E87B08-0x0000000189E87BD0 
		protected Rect paddingRect { get => default; } // 0x0000000189E87F84-0x0000000189E8804C 
		internal bool isBoundingBoxDirty { get => default; set {} } // 0x0000000189E87DCC-0x0000000189E87DD8 0x0000000189E8875C-0x0000000189E88788
		internal bool isWorldBoundingBoxDirty { get => default; set {} } // 0x0000000189E87E64-0x0000000189E87E70 0x0000000189E88810-0x0000000189E8883C
		internal Rect boundingBox { get => default; } // 0x0000000189E87940-0x0000000189E8798C 
		internal Rect worldBoundingBox { get => default; } // 0x0000000189E88518-0x0000000189E8856C 
		private Rect boundingBoxInParentSpace { get => default; } // 0x0000000189E878F0-0x0000000189E87940 
		public Rect worldBound { get => default; } // 0x0000000189E88490-0x0000000189E88518 
		public Rect localBound { get => default; } // 0x0000000189E87F34-0x0000000189E87F84 
		internal Rect rect { get => default; } // 0x0000000189E8810C-0x0000000189E88160 
		internal bool isWorldTransformDirty { get => default; set {} } // 0x0000000189187244-0x000000018918724C 0x00000001899BCDD8-0x00000001899BCE04
		internal bool isWorldTransformInverseDirty { get => default; set {} } // 0x0000000189E87E7C-0x0000000189E87E84 0x00000001899BCE04-0x00000001899BCE30
		public Matrix4x4 worldTransform { get => default; } // 0x0000000189E88698-0x0000000189E886FC 
		internal ref Matrix4x4 worldTransformRef { get => default; } // 0x0000000189E8866C-0x0000000189E88698 
		internal ref Matrix4x4 worldTransformInverse { get => default; } // 0x0000000189E88640-0x0000000189E8866C 
		internal bool isWorldClipDirty { get => default; set {} } // 0x0000000189E87E70-0x0000000189E87E7C 0x0000000189E8883C-0x0000000189E88868
		internal Rect worldClip { get => default; } // 0x0000000189E885F4-0x0000000189E88640 
		internal Rect worldClipMinusGroup { get => default; } // 0x0000000189E885A8-0x0000000189E885F4 
		internal bool worldClipIsInfinite { get => default; } // 0x0000000189E8856C-0x0000000189E885A8 
		internal PseudoStates pseudoStates { get => default; set {} } // 0x0000000183D88AB0-0x0000000183D88AC0 0x0000000189E88C10-0x0000000189E88C7C
		internal int containedPointerIds { get; private set; } // 0x0000000183D6CBB0-0x0000000183D6CBC0 0x0000000183D88AE0-0x0000000183D88AF0
		public PickingMode pickingMode { get; set; } // 0x0000000183D88AA0-0x0000000183D88AB0 0x0000000183D88B10-0x0000000183D88B20
		public string name { get => default; set {} } // 0x0000000183D86EB0-0x0000000183D86EC0 0x0000000189E88BC8-0x0000000189E88C10
		internal List<string> classList { get => default; } // 0x0000000189E87A6C-0x0000000189E87B08 
		internal string fullTypeName { get => default; } // 0x0000000189E87C98-0x0000000189E87CBC 
		internal string typeName { get => default; } // 0x0000000189E883D0-0x0000000189E883F4 
		internal YogaNode yogaNode { get; private set; } // 0x0000000183D55DF0-0x0000000183D55E00 0x00000001858B3E0C-0x00000001858B3E20
		internal ref ComputedStyle computedStyle { get => default; } // 0x0000000183D88A40-0x0000000183D88A50 
		internal bool hasInlineStyle { get => default; } // 0x0000000189E87DA0-0x0000000189E87DAC 
		internal bool styleInitialized { get => default; set {} } // 0x0000000189E8818C-0x0000000189E88198 0x0000000189E88D20-0x0000000189E88D50
		private bool isParentEnabledInHierarchy { get => default; } // 0x0000000189E87DFC-0x0000000189E87E64 
		public bool enabledInHierarchy { get => default; } // 0x0000000189E87C68-0x0000000189E87C78 
		public bool enabledSelf { get; private set; } // 0x0000000183D88A60-0x0000000183D88A70 0x0000000183D88AF0-0x0000000183D88B00
		public bool visible { get => default; set {} } // 0x0000000189E88470-0x0000000189E88490 0x0000000189E88F90-0x0000000189E88FFC
		public Action<MeshGenerationContext> generateVisualContent { get; set; } // 0x0000000183D55E30-0x0000000183D55E40 0x00000001858B3ED4-0x00000001858B3EE8
		internal bool requireMeasureFunction { get => default; set {} } // 0x0000000189E88160-0x0000000189E8816C 0x0000000189E88CBC-0x0000000189E88D20
		internal RenderTargetMode subRenderTargetMode { get => default; } // 0x0000000183D88AD0-0x0000000183D88AE0 
		internal Material defaultMaterial { get => default; } // 0x0000000183D88A50-0x0000000183D88A60 
		public IExperimentalFeatures experimental { get => default; } // 0x0000000183D86CE0-0x0000000183D86CF0 
		ITransitionAnimations IExperimentalFeatures.animation { get => default; } // 0x0000000183D86CE0-0x0000000183D86CF0 
		public Hierarchy hierarchy { get; private set; } // 0x0000000183D55E50-0x0000000183D55E60 0x00000001858B41E0-0x00000001858B41F4
		internal bool isRootVisualContainer { get; set; } // 0x0000000183D88A70-0x0000000183D88A80 0x0000000183D88B00-0x0000000183D88B10
		internal bool disableClipping { get => default; set {} } // 0x0000000189E87C50-0x0000000189E87C5C 0x0000000189E886FC-0x0000000189E8872C
		public VisualElement parent { get => default; } // 0x0000000183D88A90-0x0000000183D88AA0 
		internal BaseVisualElementPanel elementPanel { get; private set; } // 0x0000000183D4F830-0x0000000183D4F840 0x000000018544EF54-0x000000018544EF68
		public IPanel panel { get => default; } // 0x0000000183D88A80-0x0000000183D88A90 
		public virtual VisualElement contentContainer { get => default; } // 0x0000000183D86CE0-0x0000000183D86CF0 
		internal VisualTreeAsset visualTreeAssetSource { set {} } // 0x00000001858B4168-0x00000001858B417C
		public VisualElement this[int key] { get => default; } // 0x0000000189E87884-0x0000000189E878F0 
		public int childCount { get => default; } // 0x0000000189E87A0C-0x0000000189E87A6C 
		private Vector3 positionWithLayout { get => default; } // 0x0000000189E8804C-0x0000000189E8810C 
		internal bool hasDefaultRotationAndScale { get => default; } // 0x0000000189E87CDC-0x0000000189E87DA0 
		public IVisualElementScheduler schedule { get => default; } // 0x0000000183D86CE0-0x0000000183D86CF0 
		public IStyle style { get => default; } // 0x0000000189E88198-0x0000000189E88218 
		public ICustomStyle customStyle { get => default; } // 0x0000000189E87BD0-0x0000000189E87C50 
		public VisualElementStyleSheetSet styleSheets { get => default; } // 0x0000000182712100-0x0000000182712120 
		public string tooltip { get => default; set {} } // 0x0000000189E88218-0x0000000189E88294 0x0000000189E88D50-0x0000000189E88E50
		private TypeData typeData { get => default; } // 0x0000000189E88294-0x0000000189E883D0 
		public IResolvedStyle resolvedStyle { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
		UnityEngine.Color IResolvedStyle.backgroundColor { get => default; } // 0x0000000189E85468-0x0000000189E85494 
		UnityEngine.Color IResolvedStyle.borderBottomColor { get => default; } // 0x0000000189E85494-0x0000000189E854C0 
		float IResolvedStyle.borderBottomLeftRadius { get => default; } // 0x0000000189E854C0-0x0000000189E854E4 
		float IResolvedStyle.borderBottomRightRadius { get => default; } // 0x0000000189E854E4-0x0000000189E85508 
		float IResolvedStyle.borderBottomWidth { get => default; } // 0x0000000189E85508-0x0000000189E8552C 
		UnityEngine.Color IResolvedStyle.borderLeftColor { get => default; } // 0x0000000189E8552C-0x0000000189E85558 
		float IResolvedStyle.borderLeftWidth { get => default; } // 0x0000000189E85558-0x0000000189E8557C 
		UnityEngine.Color IResolvedStyle.borderRightColor { get => default; } // 0x0000000189E8557C-0x0000000189E855A8 
		float IResolvedStyle.borderRightWidth { get => default; } // 0x0000000189E855A8-0x0000000189E855CC 
		UnityEngine.Color IResolvedStyle.borderTopColor { get => default; } // 0x0000000189E855CC-0x0000000189E855F8 
		float IResolvedStyle.borderTopLeftRadius { get => default; } // 0x0000000189E855F8-0x0000000189E8561C 
		float IResolvedStyle.borderTopRightRadius { get => default; } // 0x0000000189E8561C-0x0000000189E85640 
		float IResolvedStyle.borderTopWidth { get => default; } // 0x0000000189E85640-0x0000000189E85664 
		float IResolvedStyle.bottom { get => default; } // 0x0000000189E85664-0x0000000189E85688 
		UnityEngine.Color IResolvedStyle.color { get => default; } // 0x0000000189E85688-0x0000000189E856B4 
		DisplayStyle IResolvedStyle.display { get => default; } // 0x0000000189E856B4-0x0000000189E856C4 
		FlexDirection IResolvedStyle.flexDirection { get => default; } // 0x0000000189E856C4-0x0000000189E856D4 
		float IResolvedStyle.flexGrow { get => default; } // 0x0000000189E856D4-0x0000000189E856E4 
		float IResolvedStyle.flexShrink { get => default; } // 0x0000000189E856E4-0x0000000189E856F4 
		float IResolvedStyle.height { get => default; } // 0x0000000189E856F4-0x0000000189E85718 
		float IResolvedStyle.left { get => default; } // 0x0000000189E85718-0x0000000189E8573C 
		float IResolvedStyle.marginBottom { get => default; } // 0x0000000189E8573C-0x0000000189E85760 
		float IResolvedStyle.marginLeft { get => default; } // 0x0000000189E85760-0x0000000189E85784 
		float IResolvedStyle.marginRight { get => default; } // 0x0000000189E85784-0x0000000189E857A8 
		float IResolvedStyle.marginTop { get => default; } // 0x0000000189E857A8-0x0000000189E857CC 
		StyleFloat IResolvedStyle.minHeight { get => default; } // 0x0000000189E857CC-0x0000000189E857FC 
		StyleFloat IResolvedStyle.minWidth { get => default; } // 0x0000000189E857FC-0x0000000189E8582C 
		float IResolvedStyle.opacity { get => default; } // 0x0000000189E8582C-0x0000000189E8583C 
		float IResolvedStyle.paddingBottom { get => default; } // 0x0000000189E8583C-0x0000000189E85860 
		float IResolvedStyle.paddingLeft { get => default; } // 0x0000000189E85860-0x0000000189E85884 
		float IResolvedStyle.paddingRight { get => default; } // 0x0000000189E85884-0x0000000189E858A8 
		float IResolvedStyle.paddingTop { get => default; } // 0x0000000189E858A8-0x0000000189E858CC 
		float IResolvedStyle.right { get => default; } // 0x0000000189E858CC-0x0000000189E858F0 
		Scale IResolvedStyle.scale { get => default; } // 0x0000000189E858F0-0x0000000189E8591C 
		float IResolvedStyle.top { get => default; } // 0x0000000189E8591C-0x0000000189E85940 
		Vector3 IResolvedStyle.transformOrigin { get => default; } // 0x0000000189E85940-0x0000000189E85970 
		Vector3 IResolvedStyle.translate { get => default; } // 0x0000000189E85970-0x0000000189E859A0 
		UnityEngine.Color IResolvedStyle.unityBackgroundImageTintColor { get => default; } // 0x0000000189E859A0-0x0000000189E859CC 
		int IResolvedStyle.unitySliceLeft { get => default; } // 0x0000000189E859CC-0x0000000189E859DC 
		int IResolvedStyle.unitySliceRight { get => default; } // 0x0000000189E859DC-0x0000000189E859EC 
		UnityEngine.Color IResolvedStyle.unityTextOutlineColor { get => default; } // 0x0000000189E859EC-0x0000000189E85A18 
		float IResolvedStyle.unityTextOutlineWidth { get => default; } // 0x0000000189E85A18-0x0000000189E85A28 
		Visibility IResolvedStyle.visibility { get => default; } // 0x0000000189E85A28-0x0000000189E85A38 
		WhiteSpace IResolvedStyle.whiteSpace { get => default; } // 0x0000000189E85A38-0x0000000189E85A48 
		float IResolvedStyle.width { get => default; } // 0x0000000189E85A48-0x0000000189E85A6C 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<VisualElement, UxmlTraits> // TypeDefIndex: 43280
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189E7E4F0-0x0000000189E7E52C
		}
	
		public class UxmlTraits : UIElements.UxmlTraits // TypeDefIndex: 43281
		{
			// Fields
			protected UxmlStringAttributeDescription m_Name; // 0x18
			private UxmlStringAttributeDescription m_ViewDataKey; // 0x20
			protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode; // 0x28
			private UxmlStringAttributeDescription m_Tooltip; // 0x30
			private UxmlEnumAttributeDescription<UsageHints> m_UsageHints; // 0x38
			private UxmlIntAttributeDescription m_TabIndex; // 0x48
			private UxmlStringAttributeDescription m_Class; // 0x58
			private UxmlStringAttributeDescription m_ContentContainer; // 0x60
			private UxmlStringAttributeDescription m_Style; // 0x68
	
			// Properties
			protected UxmlIntAttributeDescription focusIndex { get; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
			protected UxmlBoolAttributeDescription focusable { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189E7E798-0x0000000189E7ECBC
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189E7E52C-0x0000000189E7E798
		}
	
		public enum MeasureMode // TypeDefIndex: 43282
		{
			Undefined = 0,
			Exactly = 1,
			AtMost = 2
		}
	
		internal enum RenderTargetMode // TypeDefIndex: 43283
		{
			None = 0,
			NoColorConversion = 1,
			LinearToGamma = 2,
			GammaToLinear = 3
		}
	
		public struct Hierarchy // TypeDefIndex: 43284
		{
			// Fields
			private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation"; // Metadata: 0x01FB5E58
			private readonly VisualElement m_Owner; // 0x00
	
			// Properties
			public VisualElement parent { get => default; } // 0x0000000189E7C6C8-0x0000000189E7C6E8 
			public int childCount { get => default; } // 0x0000000189E7C680-0x0000000189E7C6C8 
			public VisualElement this[int key] { get => default; } // 0x0000000189E7C620-0x0000000189E7C680 
	
			// Constructors
			internal Hierarchy(VisualElement element) : this() {
				m_Owner = default;
			} // 0x00000001842715A0-0x00000001842715A8
	
			// Methods
			public void Add(VisualElement child) {} // 0x0000000189E7B3E8-0x0000000189E7B474
			public void Insert(int index, VisualElement child) {} // 0x0000000189E7B9F8-0x0000000189E7BD3C
			public void Remove(VisualElement child) {} // 0x0000000189E7C3D8-0x0000000189E7C510
			public void RemoveAt(int index) {} // 0x0000000189E7C10C-0x0000000189E7C35C
			public void Clear() {} // 0x0000000189E7B544-0x0000000189E7B920
			internal void BringToFront(VisualElement child) {} // 0x0000000189E7B474-0x0000000189E7B524
			internal void SendToBack(VisualElement child) {} // 0x0000000189E7C510-0x0000000189E7C59C
			internal void PlaceBehind(VisualElement child, VisualElement over) {} // 0x0000000189E7BE40-0x0000000189E7BF2C
			private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex) {} // 0x0000000189E7BD3C-0x0000000189E7BE40
			public int IndexOf(VisualElement element) => default; // 0x0000000189E7B998-0x0000000189E7B9F8
			public VisualElement ElementAt(int index) => default; // 0x0000000189E7B920-0x0000000189E7B92C
			public IEnumerable<VisualElement> Children() => default; // 0x0000000189E7B524-0x0000000189E7B544
			private void SetParent(VisualElement value) {} // 0x0000000189E7C59C-0x0000000189E7C620
			private void PutChildAtIndex(VisualElement child, int index) {} // 0x0000000189E7BF2C-0x0000000189E7C034
			private void RemoveChildAtIndex(int index) {} // 0x0000000189E7C35C-0x0000000189E7C3D8
			private void ReleaseChildList() {} // 0x0000000189E7C034-0x0000000189E7C10C
			public bool Equals(Hierarchy other) => default; // 0x0000000189D7F378-0x0000000189D7F380
			public override bool Equals(object obj) => default; // 0x0000000189E7B92C-0x0000000189E7B998
			public override int GetHashCode() => default; // 0x000000018711E2B8-0x000000018711E2DC
			public static bool operator ==(Hierarchy x, Hierarchy y) => default; // 0x000000018232CE30-0x000000018232CE40
		}
	
		private abstract class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem, IVisualElementPanelActivatable // TypeDefIndex: 43285
		{
			// Fields
			public bool isScheduled; // 0x40
			private VisualElementPanelActivator m_Activator; // 0x48
	
			// Properties
			public VisualElement element { get; private set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
			public bool isActive { get; } // 0x0000000189E7A948-0x0000000189E7A964 
	
			// Constructors
			protected BaseVisualElementScheduledItem() {} // Dummy constructor
			protected BaseVisualElementScheduledItem(VisualElement handler) {} // 0x0000000189E7A8A8-0x0000000189E7A948
	
			// Methods
			public IVisualElementScheduledItem StartingIn(long delayMs) => default; // 0x0000000183D886F0-0x0000000183D88700
			public IVisualElementScheduledItem Every(long intervalMs) => default; // 0x0000000189E7A620-0x0000000189E7A6BC
			internal override void OnItemUnscheduled() {} // 0x0000000189E7A6F4-0x0000000189E7A724
			public void Resume() {} // 0x0000000189E7A884-0x0000000189E7A8A8
			public void Pause() {} // 0x0000000189E7A860-0x0000000189E7A884
			public void ExecuteLater(long delayMs) {} // 0x0000000189E7A6BC-0x0000000189E7A6F4
			public void OnPanelActivate() {} // 0x0000000189E7A724-0x0000000189E7A7C8
			public void OnPanelDeactivate() {} // 0x0000000189E7A7C8-0x0000000189E7A860
			public bool CanBeActivated() => default; // 0x0000000189E7A5E4-0x0000000189E7A620
		}
	
		private abstract class VisualElementScheduledItem<ActionType> : BaseVisualElementScheduledItem // TypeDefIndex: 43286
		{
			// Fields
			public ActionType updateEvent;
	
			// Constructors
			protected VisualElementScheduledItem() {} // Dummy constructor
			public VisualElementScheduledItem(VisualElement handler, ActionType upEvent) {}
		}
	
		private class TimerStateScheduledItem : VisualElementScheduledItem<Action<UnityEngine.UIElements.TimerState>> // TypeDefIndex: 43287
		{
			// Constructors
			public TimerStateScheduledItem() {} // Dummy constructor
			public TimerStateScheduledItem(VisualElement handler, Action<UnityEngine.UIElements.TimerState> updateEvent) {} // 0x0000000189E7E32C-0x0000000189E7E384
	
			// Methods
			public override void PerformTimerUpdate(UnityEngine.UIElements.TimerState state) {} // 0x0000000189E7E2F4-0x0000000189E7E32C
		}
	
		private class SimpleScheduledItem : VisualElementScheduledItem<Action> // TypeDefIndex: 43288
		{
			// Constructors
			public SimpleScheduledItem() {} // Dummy constructor
			public SimpleScheduledItem(VisualElement handler, Action updateEvent) {} // 0x0000000189E7D818-0x0000000189E7D870
	
			// Methods
			public override void PerformTimerUpdate(UnityEngine.UIElements.TimerState state) {} // 0x0000000189E7D7F0-0x0000000189E7D818
		}
	
		internal class CustomStyleAccess : ICustomStyle // TypeDefIndex: 43289
		{
			// Fields
			private Dictionary<string, StylePropertyValue> m_CustomProperties; // 0x10
			private float m_DpiScaling; // 0x18
	
			// Constructors
			public CustomStyleAccess() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public void SetContext(Dictionary<string, StylePropertyValue> customProperties, float dpiScaling) {} // 0x0000000185754818-0x0000000185754838
			public bool TryGetValue(CustomStyleProperty<float> property, out float value) {
				value = default;
				return default;
			} // 0x0000000189E7B038-0x0000000189E7B0E0
			public bool TryGetValue(CustomStyleProperty<int> property, out int value) {
				value = default;
				return default;
			} // 0x0000000189E7ADC0-0x0000000189E7AE74
			public bool TryGetValue(CustomStyleProperty<UnityEngine.Color> property, out UnityEngine.Color value) {
				value = default;
				return default;
			} // 0x0000000189E7AC7C-0x0000000189E7ADC0
			public bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value) {
				value = default;
				return default;
			} // 0x0000000189E7AE74-0x0000000189E7AF90
			public bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value) {
				value = default;
				return default;
			} // 0x0000000189E7B1FC-0x0000000189E7B31C
			public bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value) {
				value = default;
				return default;
			} // 0x0000000189E7B0E0-0x0000000189E7B1FC
			public bool TryGetValue(CustomStyleProperty<string> property, out string value) {
				value = default;
				return default;
			} // 0x0000000189E7B31C-0x0000000189E7B3E8
			private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp) {
				customProp = default;
				return default;
			} // 0x0000000189E7AF90-0x0000000189E7B038
			private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp) {} // 0x0000000189E7ABBC-0x0000000189E7AC7C
		}
	
		private class TypeData // TypeDefIndex: 43290
		{
			// Fields
			private string m_FullTypeName; // 0x18
			private string m_TypeName; // 0x20
	
			// Properties
			public System.Type type { get; } // 0x00000001820B7B20-0x00000001820B7B30 
			public string fullTypeName { get => default; } // 0x0000000189ED0F60-0x0000000189ED0FA8 
			public string typeName { get => default; } // 0x0000000189ED0FA8-0x0000000189ED1050 
	
			// Constructors
			public TypeData() {} // Dummy constructor
			public TypeData(System.Type type) {} // 0x0000000189ED0EE0-0x0000000189ED0F60
		}
	
		// Constructors
		public VisualElement() {} // 0x0000000189E87594-0x0000000189E87884
		static VisualElement() {} // 0x0000000189E872A8-0x0000000189E87594
	
		// Methods
		private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() => default; // 0x0000000189E81BEC-0x0000000189E81C10
		bool IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E85E6C-0x0000000189E85EF0
		bool IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E85C34-0x0000000189E85CB4
		bool IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E85D34-0x0000000189E85DB4
		bool IStylePropertyAnimations.Start(StylePropertyId id, UnityEngine.Color from, UnityEngine.Color to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E8603C-0x0000000189E860D8
		bool IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E85C34-0x0000000189E85CB4
		bool IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E862F4-0x0000000189E863A8
		bool IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E86190-0x0000000189E8622C
		bool IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E85CB4-0x0000000189E85D34
		bool IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E8622C-0x0000000189E862F4
		bool IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E85EF0-0x0000000189E85F8C
		bool IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E860D8-0x0000000189E86190
		bool IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E85DB4-0x0000000189E85E6C
		bool IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189E85F8C-0x0000000189E8603C
		void IStylePropertyAnimations.CancelAnimation(StylePropertyId id) {} // 0x0000000189E85B04-0x0000000189E85B90
		void IStylePropertyAnimations.CancelAllAnimations() {} // 0x0000000189E85A6C-0x0000000189E85B04
		void IStylePropertyAnimations.UpdateAnimation(StylePropertyId id) {} // 0x0000000189E863A8-0x0000000189E8643C
		void IStylePropertyAnimations.GetAllAnimations(List<StylePropertyId> outPropertyIds) {} // 0x0000000189E85B90-0x0000000189E85C34
		internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0 /* Metadata: 0x01FB5E3B */) => default; // 0x0000000189E84F1C-0x0000000189E8512C
		internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to) => default; // 0x0000000189E8512C-0x0000000189E851D4
		internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to) => default; // 0x0000000189E851D4-0x0000000189E8527C
		private float? GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0 /* Metadata: 0x01FB5E3C */) => default; // 0x0000000189E81630-0x0000000189E8189C
		internal void MarkRenderHintsClean() {} // 0x0000000183D88770-0x0000000183D88780
		internal void ClearManualLayout() {} // 0x0000000189E80408-0x0000000189E80628
		internal void UpdateBoundingBox() {} // 0x0000000189E867C0-0x0000000189E86A38
		internal void UpdateWorldBoundingBox() {} // 0x0000000189E86C6C-0x0000000189E86CE4
		internal void UpdateWorldTransform() {} // 0x0000000189E86FD0-0x0000000189E87174
		internal void UpdateWorldTransformInverse() {} // 0x0000000189E86F64-0x0000000189E86FD0
		internal void EnsureWorldTransformAndClipUpToDate() {} // 0x0000000189E80B38-0x0000000189E80B74
		private void UpdateWorldClip() {} // 0x0000000189E86CE4-0x0000000189E86F64
		private Rect CombineClipRects(Rect rect, Rect parentRect) => default; // 0x0000000189E80678-0x0000000189E80704
		private Rect SubstractBorderPadding(Rect worldRect) => default; // 0x0000000189E849D0-0x0000000189E84BA8
		internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat) => default; // 0x0000000189E80704-0x0000000189E808E4
		private void UpdateHoverPseudoState() {} // 0x0000000189E86BA4-0x0000000189E86C6C
		private void ChangeIMGUIContainerCount(int delta) {} // 0x0000000189E80140-0x0000000189E8017C
		protected override void ExecuteDefaultAction(EventBase evt) {} // 0x0000000189E80B74-0x0000000189E80FC0
		internal virtual Rect GetTooltipRect() => default; // 0x0000000189E81C10-0x0000000189E81C3C
		private void SetTooltip(TooltipEvent e) {} // 0x0000000189E8477C-0x0000000189E84844
		public sealed override void Focus() {} // 0x0000000189E81294-0x0000000189E81310
		internal void SetPanel(BaseVisualElementPanel p) {} // 0x0000000189E83C68-0x0000000189E8453C
		private void WillChangePanel(BaseVisualElementPanel destinationPanel) {} // 0x0000000189E87174-0x0000000189E872A8
		private void HasChangedPanel(BaseVisualElementPanel prevPanel) {} // 0x0000000189E81C3C-0x0000000189E81E50
		public sealed override void SendEvent(EventBase e) {} // 0x0000000189E83710-0x0000000189E8372C
		internal sealed override void SendEvent(EventBase e, DispatchMode dispatchMode) {} // 0x0000000189E8372C-0x0000000189E83744
		internal void IncrementVersion(VersionChangeType changeType) {} // 0x0000000189E81EB4-0x0000000189E81ED4
		internal void InvokeHierarchyChanged(HierarchyChangeType changeType) {} // 0x0000000189E8211C-0x0000000189E8213C
		private bool SetEnabledFromHierarchyPrivate(bool state) => default; // 0x0000000189E838CC-0x0000000189E83BA4
		public void SetEnabled(bool value) {} // 0x0000000189E83BA4-0x0000000189E83BBC
		private void PropagateEnabledToChildren(bool value) {} // 0x0000000189E826F0-0x0000000189E827A8
		public void MarkDirtyRepaint() {} // 0x0000000189E821C0-0x0000000189E821D0
		internal void InvokeGenerateVisualContent(MeshGenerationContext mgc) {} // 0x0000000189E81FDC-0x0000000189E8211C
		internal void GetFullHierarchicalViewDataKey(StringBuilder key) {} // 0x0000000189E814AC-0x0000000189E8153C
		internal string GetFullHierarchicalViewDataKey() => default; // 0x0000000189E81438-0x0000000189E814AC
		internal T GetOrCreateViewData<T>(object existing, string key)
			where T : class, new() => default;
		internal void OverwriteFromViewData(object obj, string key) {} // 0x0000000189E8239C-0x0000000189E82588
		internal void SaveViewData() {} // 0x0000000189E836A4-0x0000000189E83710
		internal bool IsViewDataPersitenceSupportedOnChildren(bool existingState) => default; // 0x0000000189E8213C-0x0000000189E821C0
		internal void OnViewDataReady(bool enablePersistence) {} // 0x0000000189E82328-0x0000000189E8234C
		internal virtual void OnViewDataReady() {} // 0x000000018350B670-0x000000018350B680
		public virtual bool ContainsPoint(Vector2 localPoint) => default; // 0x0000000189E808E4-0x0000000189E80928
		private void AssignMeasureFunction() {} // 0x0000000189E7F090-0x0000000189E7F124
		private void RemoveMeasureFunction() {} // 0x0000000189E830EC-0x0000000189E83110
		protected internal virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x0000000183D88750-0x0000000183D88770
		internal YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) => default; // 0x0000000189E821E0-0x0000000189E82318
		private void FinalizeLayout() {} // 0x0000000189E80FC0-0x0000000189E8102C
		internal void SetInlineRule(StyleSheet sheet, StyleRule rule) {} // 0x0000000189E83BBC-0x0000000189E83C68
		internal void SetComputedStyle(ref ComputedStyle newStyle) {} // 0x0000000189E837B0-0x0000000189E838CC
		public override string ToString() => default; // 0x0000000189E84BA8-0x0000000189E84D04
		internal List<string> GetClassesForIteration() => default; // 0x0000000183D87CC0-0x0000000183D87CD0
		public void AddToClassList(string className) {} // 0x0000000189E7EE58-0x0000000189E7EFCC
		public void RemoveFromClassList(string className) {} // 0x0000000189E82F8C-0x0000000189E83080
		public void EnableInClassList(string className, bool enable) {} // 0x0000000189E80B14-0x0000000189E80B38
		public bool ClassListContains(string cls) => default; // 0x0000000189E8036C-0x0000000189E80408
		internal object GetProperty(PropertyName key) => default; // 0x0000000189E81B00-0x0000000189E81B68
		internal void SetProperty(PropertyName key, object value) {} // 0x0000000189E84714-0x0000000189E8477C
		internal bool HasProperty(PropertyName key) => default; // 0x0000000189E81E50-0x0000000189E81EB4
		private bool TryGetPropertyInternal(PropertyName key, out object value) {
			value = default;
			return default;
		} // 0x0000000189E8527C-0x0000000189E8537C
		private static void CheckUserKeyArgument(PropertyName key) {} // 0x0000000189E8017C-0x0000000189E802D4
		private void SetPropertyInternal(PropertyName key, object value) {} // 0x0000000189E8453C-0x0000000189E84714
		private void UpdateCursorStyle(long eventType) {} // 0x0000000189E86A38-0x0000000189E86BA4
		private VisualElementAnimationSystem GetAnimationSystem() => default; // 0x0000000189E813D0-0x0000000189E81438
		internal void RegisterAnimation(IValueAnimationUpdate anim) {} // 0x0000000189E82E50-0x0000000189E82F28
		internal void UnregisterAnimation(IValueAnimationUpdate anim) {} // 0x0000000189E866E0-0x0000000189E86754
		private void UnregisterRunningAnimations() {} // 0x0000000189E86754-0x0000000189E867C0
		private void RegisterRunningAnimations() {} // 0x0000000189E82F28-0x0000000189E82F8C
		private static ValueAnimation<T> StartAnimation<T>(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged) => default;
		private static void AssignStyleValues(VisualElement ve, StyleValues src) {} // 0x0000000189E7F124-0x0000000189E7FDEC
		private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead) => default; // 0x0000000189E827A8-0x0000000189E82E50
		ValueAnimation<StyleValues> ITransitionAnimations.Start(StyleValues to, int durationMs) => default; // 0x0000000189E8538C-0x0000000189E85468
		private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs) => default; // 0x0000000189E84874-0x0000000189E849D0
		internal bool ShouldClip() => default; // 0x0000000189E84844-0x0000000189E84874
		public void Add(VisualElement child) {} // 0x0000000189E7EFCC-0x0000000189E7F090
		public void Insert(int index, VisualElement element) {} // 0x0000000189E81F44-0x0000000189E81FDC
		public void Clear() {} // 0x0000000189E80628-0x0000000189E80678
		public VisualElement ElementAt(int index) => default; // 0x0000000189E80B08-0x0000000189E80B14
		public int IndexOf(VisualElement element) => default; // 0x0000000189E81ED4-0x0000000189E81F44
		internal VisualElement ElementAtTreePath(List<int> childIndexes) => default; // 0x0000000189E80994-0x0000000189E80B08
		internal bool FindElementInTree(VisualElement element, List<int> outChildIndexes) => default; // 0x0000000189E811B0-0x0000000189E81294
		public IEnumerable<VisualElement> Children() => default; // 0x0000000189E802D4-0x0000000189E8036C
		public void BringToFront() {} // 0x0000000189E7FDEC-0x0000000189E7FE58
		public void SendToBack() {} // 0x0000000189E83744-0x0000000189E837B0
		public void PlaceBehind(VisualElement sibling) {} // 0x0000000189E82588-0x0000000189E826F0
		public void RemoveFromHierarchy() {} // 0x0000000189E83080-0x0000000189E830EC
		public T GetFirstOfType<T>()
			where T : class => default;
		public T GetFirstAncestorOfType<T>()
			where T : class => default;
		public bool Contains(VisualElement child) => default; // 0x0000000189E80928-0x0000000189E80994
		private void GatherAllChildren(List<VisualElement> elements) {} // 0x0000000189E81310-0x0000000189E813D0
		public VisualElement FindCommonAncestor(VisualElement other) => default; // 0x0000000189E8102C-0x0000000189E811B0
		internal VisualElement GetRoot() => default; // 0x0000000189E81BA8-0x0000000189E81BEC
		internal VisualElement GetRootVisualContainer() => default; // 0x0000000189E81B68-0x0000000189E81BA8
		internal VisualElement GetNextElementDepthFirst() => default; // 0x0000000189E8153C-0x0000000189E81630
		internal VisualElement GetPreviousElementDepthFirst() => default; // 0x0000000189E81A20-0x0000000189E81B00
		internal VisualElement RetargetElement(VisualElement retargetAgainst) => default; // 0x0000000189E83630-0x0000000189E836A4
		internal void GetPivotedMatrixWithLayout(out Matrix4x4 result) {
			result = default;
		} // 0x0000000189E8189C-0x0000000189E81A20
		internal static float Min(float a, float b, float c, float d) => default; // 0x0000000189E82318-0x0000000189E82328
		internal static float Max(float a, float b, float c, float d) => default; // 0x0000000189E821D0-0x0000000189E821E0
		private void TransformAlignedRectToParentSpace(ref Rect rect) {} // 0x0000000189E84D04-0x0000000189E84E1C
		internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect) => default; // 0x0000000189E7FE58-0x0000000189E80140
		internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect) {} // 0x0000000189E84E1C-0x0000000189E84E90
		internal static void OrderMinMaxRect(ref Rect rect) {} // 0x0000000189E8234C-0x0000000189E8239C
		internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point) => default; // 0x0000000183D889B0-0x0000000183D88A00
		internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector) => default; // 0x0000000183D88A00-0x0000000183D88A40
		internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res) {
			res = default;
		} // 0x0000000183D88780-0x0000000183D889B0
		private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res) {
			res = default;
		} // 0x0000000189E84E90-0x0000000189E84F1C
		private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs) {} // 0x0000000183D84330-0x0000000183D843C0
		IVisualElementScheduledItem IVisualElementScheduler.Execute(Action<UnityEngine.UIElements.TimerState> timerUpdateEvent) => default; // 0x0000000189E86580-0x0000000189E86630
		IVisualElementScheduledItem IVisualElementScheduler.Execute(Action updateEvent) => default; // 0x0000000189E86630-0x0000000189E866E0
		internal void AddStyleSheetPath(string sheetPath) {} // 0x0000000189E7ECBC-0x0000000189E7EE58
		private StyleFloat ResolveLengthValue(Length length, bool isRow) => default; // 0x0000000189E83110-0x0000000189E83208
		private Vector3 ResolveTranslate() => default; // 0x0000000189E834E4-0x0000000189E83630
		private Vector3 ResolveTransformOrigin() => default; // 0x0000000189E83364-0x0000000189E834E4
		private Quaternion ResolveRotation() => default; // 0x0000000189E83208-0x0000000189E832C8
		private Vector3 ResolveScale() => default; // 0x0000000189E832C8-0x0000000189E83364
	}

	internal interface IStylePropertyAnimationSystem // TypeDefIndex: 43293
	{
		// Methods
		bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve);
		void CancelAllAnimations();
		void CancelAllAnimations(VisualElement owner);
		void CancelAnimation(VisualElement owner, StylePropertyId id);
		void UpdateAnimation(VisualElement owner, StylePropertyId id);
		void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds);
		void Update();
	}

	internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem // TypeDefIndex: 43318
	{
		// Fields
		private long m_CurrentTimeMs; // 0x10
		private ValuesFloat m_Floats; // 0x18
		private ValuesInt m_Ints; // 0x20
		private ValuesLength m_Lengths; // 0x28
		private ValuesColor m_Colors; // 0x30
		private ValuesBackground m_Backgrounds; // 0x38
		private ValuesFontDefinition m_FontDefinitions; // 0x40
		private ValuesFont m_Fonts; // 0x48
		private ValuesTextShadow m_TextShadows; // 0x50
		private ValuesScale m_Scale; // 0x58
		private ValuesRotate m_Rotate; // 0x60
		private ValuesTranslate m_Translate; // 0x68
		private ValuesTransformOrigin m_TransformOrigin; // 0x70
		private readonly List<Values> m_AllValues; // 0x78
		private readonly Dictionary<StylePropertyId, Values> m_PropertyToValues; // 0x80
	
		// Nested types
		[Flags]
		private enum TransitionState // TypeDefIndex: 43294
		{
			None = 0,
			Running = 1,
			Started = 2,
			Ended = 4,
			Canceled = 8
		}
	
		private struct AnimationDataSet<TTimingData, TStyleData> // TypeDefIndex: 43295
		{
			// Fields
			public VisualElement[] elements;
			public StylePropertyId[] properties;
			public TTimingData[] timing;
			public TStyleData[] style;
			public int count;
			private Dictionary<ElementPropertyPair, int> indices;
	
			// Properties
			private int capacity { get => default; set {} }
	
			// Methods
			private void LocalInit() {}
			public static AnimationDataSet<TTimingData, TStyleData> Create() => default;
			public bool IndexOf(VisualElement ve, StylePropertyId prop, out int index) {
				index = default;
				return default;
			}
			public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData) {}
			public void Remove(int cancelledIndex) {}
			public void Replace(int index, TTimingData timingData, TStyleData styleData) {}
			public void RemoveAll(VisualElement ve) {}
			public void RemoveAll() {}
			public void GetActivePropertiesForElement(VisualElement ve, List<StylePropertyId> outProperties) {}
		}
	
		private struct ElementPropertyPair // TypeDefIndex: 43297
		{
			// Fields
			public static readonly IEqualityComparer<ElementPropertyPair> Comparer; // 0x00
			public readonly VisualElement element; // 0x00
			public readonly StylePropertyId property; // 0x08
	
			// Nested types
			private class EqualityComparer : IEqualityComparer<ElementPropertyPair> // TypeDefIndex: 43296
			{
				// Constructors
				public EqualityComparer() {} // 0x000000018350B670-0x000000018350B680
	
				// Methods
				public bool Equals(ElementPropertyPair x, ElementPropertyPair y) => default; // 0x0000000189ECDED8-0x0000000189ECDEF0
				public int GetHashCode(ElementPropertyPair obj) => default; // 0x0000000189ECDEF0-0x0000000189ECDF20
			}
	
			// Constructors
			public ElementPropertyPair(VisualElement element, StylePropertyId property) {
				this.element = default;
				this.property = default;
			} // 0x0000000184274600-0x000000018427461C
			static ElementPropertyPair() {
				Comparer = default;
			} // 0x0000000189ECDE68-0x0000000189ECDED8
		}
	
		private abstract class Values // TypeDefIndex: 43298
		{
			// Constructors
			protected Values() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public abstract void CancelAllAnimations();
			public abstract void CancelAllAnimations(VisualElement ve);
			public abstract void CancelAnimation(VisualElement ve, StylePropertyId id);
			public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id);
			public abstract void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds);
			public abstract void Update(long currentTimeMs);
			protected abstract void UpdateValues();
			protected abstract void UpdateComputedStyle();
			protected abstract void UpdateComputedStyle(int i);
		}
	
		private abstract class Values<T> : Values // TypeDefIndex: 43304
		{
			// Fields
			private long m_CurrentTimeMs;
			private TransitionEventsFrameState m_CurrentFrameEventsState;
			private TransitionEventsFrameState m_NextFrameEventsState;
			public AnimationDataSet<TimingData, StyleData> running;
			public AnimationDataSet<EmptyData, T> completed;
	
			// Properties
			public bool isEmpty { get; }
			public abstract Func<T, T, bool> SameFunc { get; }
	
			// Nested types
			private class TransitionEventsFrameState // TypeDefIndex: 43300
			{
				// Fields
				private static readonly ObjectPool<Queue<EventBase>> k_EventQueuePool;
				public readonly Dictionary<ElementPropertyPair, TransitionState> elementPropertyStateDelta;
				public readonly Dictionary<ElementPropertyPair, Queue<EventBase>> elementPropertyQueuedEvents;
				public IPanel panel;
				private int m_ChangesCount;
	
				// Constructors
				public TransitionEventsFrameState() {}
				static TransitionEventsFrameState() {}
	
				// Methods
				public static Queue<EventBase> GetPooledQueue() => default;
				public void RegisterChange() {}
				public void UnregisterChange() {}
				public bool StateChanged() => default;
				public void Clear() {}
			}
	
			public struct TimingData // TypeDefIndex: 43301
			{
				// Fields
				public long startTimeMs;
				public int durationMs;
				public Func<float, float> easingCurve;
				public float easedProgress;
				public float reversingShorteningFactor;
				public bool isStarted;
				public int delayMs;
			}
	
			public struct StyleData // TypeDefIndex: 43302
			{
				// Fields
				public T startValue;
				public T endValue;
				public T reversingAdjustedStartValue;
				public T currentValue;
			}
	
			public struct EmptyData // TypeDefIndex: 43303
			{
				// Fields
				public static EmptyData<T> Default;
	
				// Constructors
				static EmptyData() {
					Default = default;
				}
			}
	
			// Constructors
			protected Values() {}
	
			// Methods
			protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref ref T a, ref ref T b) => default;
			private void SwapFrameStates() {}
			private void QueueEvent(EventBase evt, ElementPropertyPair epp) {}
			private void ClearEventQueue(ElementPropertyPair epp) {}
			private void QueueTransitionRunEvent(VisualElement ve, int runningIndex) {}
			private void QueueTransitionStartEvent(VisualElement ve, int runningIndex) {}
			private void QueueTransitionEndEvent(VisualElement ve, int runningIndex) {}
			private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) {}
			private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, long panelElapsedMs) {}
			public sealed override void CancelAllAnimations() {}
			public sealed override void CancelAllAnimations(VisualElement ve) {}
			public sealed override void CancelAnimation(VisualElement ve, StylePropertyId id) {}
			public sealed override void UpdateAnimation(VisualElement ve, StylePropertyId id) {}
			public sealed override void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds) {}
			private float ComputeReversingShorteningFactor(int oldIndex) => default;
			private int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor) => default;
			private int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor) => default;
			public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, long currentTimeMs) => default;
			private void ForceComputedStyleEndValue(int runningIndex) {}
			public sealed override void Update(long currentTimeMs) {}
			private void ProcessEventQueue() {}
			private void UpdateProgress(long currentTimeMs) {}
		}
	
		private class ValuesFloat : Values<float> // TypeDefIndex: 43305
		{
			// Properties
			public override Func<float, float, bool> SameFunc { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
			// Constructors
			public ValuesFloat() {} // 0x0000000189ED5F54-0x0000000189ED5FF0
	
			// Methods
			private static bool IsSame(float a, float b) => default; // 0x00000001896C9A34-0x00000001896C9A3C
			private static float Lerp(float a, float b, float t) => default; // 0x0000000183D86320-0x0000000183D86340
			protected sealed override void UpdateValues() {} // 0x0000000189ED5ED8-0x0000000189ED5F54
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED5D90-0x0000000189ED5E44
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED5E44-0x0000000189ED5ED8
		}
	
		private class ValuesInt : Values<int> // TypeDefIndex: 43306
		{
			// Properties
			public override Func<int, int, bool> SameFunc { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
			// Constructors
			public ValuesInt() {} // 0x0000000189ED64E8-0x0000000189ED6584
	
			// Methods
			private static bool IsSame(int a, int b) => default; // 0x0000000186505FF4-0x0000000186505FFC
			private static int Lerp(int a, int b, float t) => default; // 0x0000000189ED62F8-0x0000000189ED6318
			protected sealed override void UpdateValues() {} // 0x0000000189ED6460-0x0000000189ED64E8
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED63AC-0x0000000189ED6460
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED6318-0x0000000189ED63AC
		}
	
		private class ValuesLength : Values<Length> // TypeDefIndex: 43307
		{
			// Properties
			public override Func<Length, Length, bool> SameFunc { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
			// Constructors
			public ValuesLength() {} // 0x0000000189ED6814-0x0000000189ED68B0
	
			// Methods
			private static bool IsSame(Length a, Length b) => default; // 0x0000000189ED65C0-0x0000000189ED65F8
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b) => default; // 0x0000000189ED6584-0x0000000189ED65C0
			internal static Length Lerp(Length a, Length b, float t) => default; // 0x0000000189ED65F8-0x0000000189ED6640
			protected sealed override void UpdateValues() {} // 0x0000000189ED6788-0x0000000189ED6814
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED6640-0x0000000189ED66F4
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED66F4-0x0000000189ED6788
		}
	
		private class ValuesColor : Values<UnityEngine.Color> // TypeDefIndex: 43308
		{
			// Properties
			public override Func<UnityEngine.Color, UnityEngine.Color, bool> SameFunc { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
			// Constructors
			public ValuesColor() {} // 0x0000000189ED5CF4-0x0000000189ED5D90
	
			// Methods
			private static bool IsSame(UnityEngine.Color c, UnityEngine.Color d) => default; // 0x0000000189ED5A30-0x0000000189ED5AA4
			private static UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, float t) => default; // 0x0000000189ED5AA4-0x0000000189ED5AE0
			protected sealed override void UpdateValues() {} // 0x0000000189ED5C44-0x0000000189ED5CF4
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED5B80-0x0000000189ED5C44
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED5AE0-0x0000000189ED5B80
		}
	
		private abstract class ValuesDiscrete<T> : Values<T> // TypeDefIndex: 43309
		{
			// Properties
			public override Func<T, T, bool> SameFunc { get; }
	
			// Constructors
			protected ValuesDiscrete() {}
	
			// Methods
			private static bool IsSame(T a, T b) => default;
			private static T Lerp(T a, T b, float t) => default;
			protected sealed override void UpdateValues() {}
		}
	
		private class ValuesBackground : ValuesDiscrete<Background> // TypeDefIndex: 43310
		{
			// Constructors
			public ValuesBackground() {} // 0x0000000189ED59F4-0x0000000189ED5A30
	
			// Methods
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED5924-0x0000000189ED59F4
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED5878-0x0000000189ED5924
		}
	
		private class ValuesFontDefinition : ValuesDiscrete<FontDefinition> // TypeDefIndex: 43311
		{
			// Constructors
			public ValuesFontDefinition() {} // 0x0000000189ED6154-0x0000000189ED6190
	
			// Methods
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED6090-0x0000000189ED6154
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED5FF0-0x0000000189ED6090
		}
	
		private class ValuesFont : ValuesDiscrete<Font> // TypeDefIndex: 43312
		{
			// Constructors
			public ValuesFont() {} // 0x0000000189ED62BC-0x0000000189ED62F8
	
			// Methods
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED6214-0x0000000189ED62BC
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED6190-0x0000000189ED6214
		}
	
		private class ValuesTextShadow : Values<TextShadow> // TypeDefIndex: 43313
		{
			// Properties
			public override Func<TextShadow, TextShadow, bool> SameFunc { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
			// Constructors
			public ValuesTextShadow() {} // 0x0000000189ED732C-0x0000000189ED73C8
	
			// Methods
			private static bool IsSame(TextShadow a, TextShadow b) => default; // 0x0000000189ED6FD8-0x0000000189ED7028
			private static TextShadow Lerp(TextShadow a, TextShadow b, float t) => default; // 0x0000000189ED7028-0x0000000189ED70A8
			protected sealed override void UpdateValues() {} // 0x0000000189ED723C-0x0000000189ED732C
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED7160-0x0000000189ED723C
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED70A8-0x0000000189ED7160
		}
	
		private class ValuesScale : Values<Scale> // TypeDefIndex: 43314
		{
			// Properties
			public override Func<Scale, Scale, bool> SameFunc { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
			// Constructors
			public ValuesScale() {} // 0x0000000189ED6F3C-0x0000000189ED6FD8
	
			// Methods
			private static bool IsSame(Scale a, Scale b) => default; // 0x0000000189ED6C88-0x0000000189ED6CB4
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED6DC8-0x0000000189ED6E8C
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED6D28-0x0000000189ED6DC8
			private static Scale Lerp(Scale a, Scale b, float t) => default; // 0x0000000189ED6CB4-0x0000000189ED6D28
			protected sealed override void UpdateValues() {} // 0x0000000189ED6E8C-0x0000000189ED6F3C
		}
	
		private class ValuesRotate : Values<Rotate> // TypeDefIndex: 43315
		{
			// Properties
			public override Func<Rotate, Rotate, bool> SameFunc { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
			// Constructors
			public ValuesRotate() {} // 0x0000000189ED6BEC-0x0000000189ED6C88
	
			// Methods
			private static bool IsSame(Rotate a, Rotate b) => default; // 0x0000000189ED68B0-0x0000000189ED68F4
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED6A44-0x0000000189ED6B14
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED6998-0x0000000189ED6A44
			private static Rotate Lerp(Rotate a, Rotate b, float t) => default; // 0x0000000189ED68F4-0x0000000189ED6998
			protected sealed override void UpdateValues() {} // 0x0000000189ED6B14-0x0000000189ED6BEC
		}
	
		private class ValuesTranslate : Values<Translate> // TypeDefIndex: 43316
		{
			// Properties
			public override Func<Translate, Translate, bool> SameFunc { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
			// Constructors
			public ValuesTranslate() {} // 0x0000000189ED7AEC-0x0000000189ED7B88
	
			// Methods
			private static bool IsSame(Translate a, Translate b) => default; // 0x0000000189ED77BC-0x0000000189ED7800
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b) => default; // 0x0000000189ED7790-0x0000000189ED77BC
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED7944-0x0000000189ED7A14
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED7898-0x0000000189ED7944
			private static Translate Lerp(Translate a, Translate b, float t) => default; // 0x0000000189ED7800-0x0000000189ED7898
			protected sealed override void UpdateValues() {} // 0x0000000189ED7A14-0x0000000189ED7AEC
		}
	
		private class ValuesTransformOrigin : Values<TransformOrigin> // TypeDefIndex: 43317
		{
			// Properties
			public override Func<TransformOrigin, TransformOrigin, bool> SameFunc { get; } // 0x0000000183D4EA60-0x0000000183D4EA70 
	
			// Constructors
			public ValuesTransformOrigin() {} // 0x0000000189ED76F4-0x0000000189ED7790
	
			// Methods
			private static bool IsSame(TransformOrigin a, TransformOrigin b) => default; // 0x0000000189ED73F4-0x0000000189ED7430
			protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b) => default; // 0x0000000189ED73C8-0x0000000189ED73F4
			protected sealed override void UpdateComputedStyle() {} // 0x0000000189ED7564-0x0000000189ED7630
			protected sealed override void UpdateComputedStyle(int i) {} // 0x0000000189ED74BC-0x0000000189ED7564
			private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t) => default; // 0x0000000189ED7430-0x0000000189ED74BC
			protected sealed override void UpdateValues() {} // 0x0000000189ED7630-0x0000000189ED76F4
		}
	
		// Constructors
		public StylePropertyAnimationSystem() {} // 0x0000000189ECF79C-0x0000000189ECF888
	
		// Methods
		private T GetOrCreate<T>(ref ref T values)
			where T : new() => default;
		private bool StartTransition<T>(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<float, float> easingCurve, Values<T> values) => default;
		public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECF2F4-0x0000000189ECF3B8
		public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECF028-0x0000000189ECF0E8
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECED94-0x0000000189ECEE58
		public bool StartTransition(VisualElement owner, StylePropertyId prop, UnityEngine.Color startValue, UnityEngine.Color endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECEE58-0x0000000189ECEF34
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECEBC0-0x0000000189ECECB8
		public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECECB8-0x0000000189ECED94
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECF494-0x0000000189ECF558
		public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECF1E4-0x0000000189ECF2F4
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECF3B8-0x0000000189ECF494
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECF0E8-0x0000000189ECF1E4
		public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECF558-0x0000000189ECF654
		public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, [JetBrains.Annotations.NotNull] Func<float, float> easingCurve) => default; // 0x0000000189ECEF34-0x0000000189ECF028
		public void CancelAllAnimations() {} // 0x0000000189ECE75C-0x0000000189ECE86C
		public void CancelAllAnimations(VisualElement owner) {} // 0x0000000189ECE86C-0x0000000189ECE9E8
		public void CancelAnimation(VisualElement owner, StylePropertyId id) {} // 0x0000000189ECE9E8-0x0000000189ECEA78
		public void UpdateAnimation(VisualElement owner, StylePropertyId id) {} // 0x0000000189ECF654-0x0000000189ECF6E4
		public void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds) {} // 0x0000000189ECEA78-0x0000000189ECEBC0
		private void UpdateTracking<T>(Values<T> values) {}
		private long CurrentTimeMs() => default; // 0x0000000183D66B80-0x0000000183D66B90
		public void Update() {} // 0x0000000189ECF6E4-0x0000000189ECF79C
	}

	public struct StylePropertyName : IEquatable<StylePropertyName> // TypeDefIndex: 43319
	{
		// Properties
		internal StylePropertyId id { [IsReadOnly] get; } // 0x0000000183D4E980-0x0000000183D4E990 
		private string name { [IsReadOnly] get; } // 0x0000000183D50DE0-0x0000000183D50DF0 
	
		// Constructors
		internal StylePropertyName(StylePropertyId stylePropertyId) : this() {} // 0x0000000189ECF9C0-0x0000000189ECFA6C
		public StylePropertyName(string name) : this() {} // 0x0000000189ECF978-0x0000000189ECF9C0
	
		// Methods
		internal static StylePropertyId StylePropertyIdFromString(string name) => default; // 0x0000000189ECF8F4-0x0000000189ECF978
		public static bool operator ==(StylePropertyName lhs, StylePropertyName rhs) => default; // 0x0000000189ECFA6C-0x0000000189ECFA74
		public static bool operator !=(StylePropertyName lhs, StylePropertyName rhs) => default; // 0x0000000189ECFAA8-0x0000000189ECFAB4
		public static implicit operator StylePropertyName(string name) => default; // 0x0000000189ECFA74-0x0000000189ECFAA8
		public override int GetHashCode() => default; // 0x0000000183D85860-0x0000000183D85870
		public override bool Equals(object other) => default; // 0x0000000189ECF888-0x0000000189ECF8EC
		public bool Equals(StylePropertyName other) => default; // 0x0000000189ECF8EC-0x0000000189ECF8F4
		public override string ToString() => default; // 0x0000000183D85A90-0x0000000183D85AA0
	}

	public class TemplateContainer : BindableElement // TypeDefIndex: 43322
	{
		// Fields
		private VisualElement m_ContentContainer; // 0x3D8
		private VisualTreeAsset m_TemplateSource; // 0x3E0
	
		// Properties
		public string templateId { get; private set; } // 0x0000000183D55EC0-0x0000000183D55ED0 0x00000001858B40A0-0x00000001858B40B4
		internal VisualTreeAsset templateSource { set {} } // 0x00000001858B4258-0x00000001858B426C
		public override VisualElement contentContainer { get => default; } // 0x0000000183D88DF0-0x0000000183D88E00 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TemplateContainer, UxmlTraits> // TypeDefIndex: 43320
		{
			// Properties
			public override string uxmlName { get => default; } // 0x0000000189ED5168-0x0000000189ED5194 
			public override string uxmlQualifiedName { get => default; } // 0x0000000189ED5194-0x0000000189ED5208 
	
			// Constructors
			public UxmlFactory() {} // 0x0000000189ED512C-0x0000000189ED5168
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 43321
		{
			// Fields
			private UxmlStringAttributeDescription m_Template; // 0x78
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189ED57E0-0x0000000189ED5878
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189ED5208-0x0000000189ED5548
		}
	
		// Constructors
		public TemplateContainer() {} // 0x0000000189ECFAFC-0x0000000189ECFB08
		public TemplateContainer(string templateId) {} // 0x0000000189ECFAB4-0x0000000189ECFAFC
	
		// Methods
		internal void SetContentContainer(VisualElement content) {} // 0x00000001858B3D30-0x00000001858B3D44
	}

	internal interface ITextElement // TypeDefIndex: 43323
	{
		// Properties
		string text { get; }
	}

	public class TextElement : BindableElement, ITextElement, INotifyValueChanged<string> // TypeDefIndex: 43326
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		private ITextHandle m_TextHandle; // 0x3D0
		internal static int maxTextVertices; // 0x08
		[SerializeField]
		private string m_Text; // 0x3D8
		private bool m_EnableRichText; // 0x3E0
		private bool m_DisplayTooltipWhenElided; // 0x3E1
		internal static readonly string k_EllipsisText; // 0x10
		private bool m_WasElided; // 0x3E3
		private bool m_UpdateTextParams; // 0x3E4
		private MeshGenerationContextUtils.TextParams m_TextParams; // 0x3E8
		private int m_PreviousTextParamsHashCode; // 0x480
	
		// Properties
		internal ITextHandle textHandle { get => default; set {} } // 0x0000000183D88E30-0x0000000183D88E40 0x00000001858B40A0-0x00000001858B40B4
		public virtual string text { get => default; set {} } // 0x0000000189ED09C8-0x0000000189ED0A04 0x0000000189ED0A50-0x0000000189ED0AA0
		public bool enableRichText { get => default; set {} } // 0x0000000183D88E10-0x0000000183D88E20 0x0000000189ED0A34-0x0000000189ED0A50
		public bool displayTooltipWhenElided { get => default; set {} } // 0x0000000183D88E00-0x0000000183D88E10 0x0000000189ED0A04-0x0000000189ED0A34
		public bool isElided { get; private set; } // 0x0000000183D88E20-0x0000000183D88E30 0x0000000183D88E40-0x0000000183D88E50
		string UnityEngine.UIElements.INotifyValueChanged<System.String>.value { get => default; set {} } // 0x0000000189ED033C-0x0000000189ED0384 0x0000000189ED0384-0x0000000189ED04D8
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TextElement, UxmlTraits> // TypeDefIndex: 43324
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189ED50F0-0x0000000189ED512C
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 43325
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x78
			private UxmlBoolAttributeDescription m_EnableRichText; // 0x80
			private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189ED568C-0x0000000189ED57E0
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189ED5548-0x0000000189ED568C
		}
	
		// Constructors
		public TextElement() {} // 0x0000000189ED081C-0x0000000189ED09C8
		static TextElement() {} // 0x0000000189ED0748-0x0000000189ED081C
	
		// Methods
		public override void HandleEvent(EventBase evt) {} // 0x0000000189ECFF3C-0x0000000189ED0080
		private void OnGeometryChanged(GeometryChangedEvent e) {} // 0x0000000189ED0238-0x0000000189ED0240
		private void OnGenerateVisualContent(MeshGenerationContext mgc) {} // 0x0000000189ED00B8-0x0000000189ED0238
		internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) => default; // 0x0000000189ECFB6C-0x0000000189ECFF3C
		private void UpdateTooltip() {} // 0x0000000189ED04D8-0x0000000189ED0534
		private void UpdateVisibleText() {} // 0x0000000189ED0534-0x0000000189ED0748
		private bool ShouldElide() => default; // 0x0000000189ED0240-0x0000000189ED0290
		private bool TextLibraryCanElide() => default; // 0x0000000189ED0290-0x0000000189ED02D0
		public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) => default; // 0x0000000189ED0080-0x0000000189ED00B8
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x0000000189ECFB08-0x0000000189ECFB6C
		void INotifyValueChanged<string>.SetValueWithoutNotify(string newValue) {} // 0x0000000189ED02D0-0x0000000189ED033C
	}

	public struct TextShadow : IEquatable<TextShadow> // TypeDefIndex: 43327
	{
		// Fields
		public Vector2 offset; // 0x00
		public float blurRadius; // 0x08
		public UnityEngine.Color color; // 0x0C
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189ED0AA0-0x0000000189ED0B2C
		public bool Equals(TextShadow other) => default; // 0x0000000189ED0B2C-0x0000000189ED0BC8
		public override int GetHashCode() => default; // 0x0000000189ED0BC8-0x0000000189ED0C1C
		public static bool operator ==(TextShadow style1, TextShadow style2) => default; // 0x0000000189ED0E5C-0x0000000189ED0E8C
		public static bool operator !=(TextShadow style1, TextShadow style2) => default; // 0x0000000189ED0E8C-0x0000000189ED0EE0
		public override string ToString() => default; // 0x0000000189ED0D84-0x0000000189ED0E5C
		internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t) => default; // 0x0000000189ED0C1C-0x0000000189ED0D84
	}

	internal static class UIElementsPackageUtility // TypeDefIndex: 43328
	{
		// Fields
		internal static readonly string EditorResourcesBasePath; // 0x00
		internal static readonly bool IsUIEPackageLoaded; // 0x08
	
		// Constructors
		static UIElementsPackageUtility() {} // 0x0000000189ED1454-0x0000000189ED14C4
	}

	internal static class UIElementsRuntimeUtility // TypeDefIndex: 43331
	{
		// Fields
		private static bool s_RegisteredPlayerloopCallback; // 0x08
		private static List<UnityEngine.UIElements.Panel> s_SortedRuntimePanels; // 0x10
		private static bool s_PanelOrderingDirty; // 0x18
		internal static readonly string s_RepaintProfilerMarkerName; // 0x20
		private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x28
		private static int currentOverlayIndex; // 0x30
		private static DefaultEventSystem s_DefaultEventSystem; // 0x40
		private static List<PanelSettings> s_PotentiallyEmptyPanelSettings; // 0x48
	
		// Properties
		internal static UnityEngine.Object activeEventSystem { get; private set; } // 0x0000000189ED264C-0x0000000189ED269C 0x0000000189ED2874-0x0000000189ED28D4
		internal static bool useDefaultEventSystem { get; } // 0x0000000189ED2750-0x0000000189ED27B0 
		internal static DefaultEventSystem defaultEventSystem { get; } // 0x0000000189ED269C-0x0000000189ED2750 
	
		// Events
		public static event Action<BaseRuntimePanel> onCreatePanel;
	
		// Nested types
		public delegate BaseRuntimePanel CreateRuntimePanelDelegate(ScriptableObject ownerObject); // TypeDefIndex: 43329; 0x000000018102B410-0x000000018102B420
	
		// Constructors
		static UIElementsRuntimeUtility() {} // 0x0000000182DF5C80-0x0000000182DF60F0
	
		// Methods
		public static EventBase CreateEvent(UnityEngine.Event systemEvent) => default; // 0x0000000189ED1518-0x0000000189ED157C
		public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate) => default; // 0x0000000189ED1688-0x0000000189ED180C
		public static void DisposeRuntimePanel(ScriptableObject ownerObject) {} // 0x0000000189ED157C-0x0000000189ED162C
		private static void RegisterCachedPanelInternal(int instanceID, IPanel panel) {} // 0x0000000189ED1A7C-0x0000000189ED1B4C
		private static void RemoveCachedPanelInternal(int instanceID) {} // 0x0000000189ED1BEC-0x0000000189ED1CF8
		public static void RepaintOffscreenPanels() {} // 0x0000000189ED2000-0x0000000189ED218C
		public static void RepaintOverlayPanel(BaseRuntimePanel panel) {} // 0x0000000189ED218C-0x0000000189ED22B8
		internal static void BeginRenderOverlays(int displayIndex) {} // 0x0000000189ED14C4-0x0000000189ED1518
		internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority) {} // 0x0000000189ED1E98-0x0000000189ED2000
		internal static void EndRenderOverlays(int displayIndex) {} // 0x0000000189ED162C-0x0000000189ED1688
		public static void RegisterEventSystem(UnityEngine.Object eventSystem) {} // 0x00000001836FEBA0-0x00000001836FED50
		public static void UnregisterEventSystem(UnityEngine.Object eventSystem) {} // 0x0000000189ED23CC-0x0000000189ED2454
		public static void UpdateRuntimePanels() {} // 0x0000000189ED24AC-0x0000000189ED264C
		internal static void MarkPotentiallyEmpty(PanelSettings settings) {} // 0x0000000189ED180C-0x0000000189ED18C0
		internal static void RemoveUnusedPanels() {} // 0x0000000189ED1CF8-0x0000000189ED1E98
		public static void RegisterPlayerloopCallback() {} // 0x0000000189ED1B4C-0x0000000189ED1BEC
		public static void UnregisterPlayerloopCallback() {} // 0x0000000189ED2454-0x0000000189ED24AC
		internal static void SetPanelOrderingDirty() {} // 0x0000000189ED237C-0x0000000189ED23CC
		internal static List<UnityEngine.UIElements.Panel> GetSortedPlayerPanels() => default; // 0x00000001836FE8C0-0x00000001836FE960
		private static void SortPanels() {} // 0x00000001836FED50-0x00000001836FEF50
		internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int? targetDisplay) {
			targetDisplay = default;
			return default;
		} // 0x0000000189ED18C0-0x0000000189ED1930
		internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out int? targetDisplay) {
			targetDisplay = default;
			return default;
		} // 0x0000000189ED1930-0x0000000189ED1A7C
		internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) => default; // 0x0000000189ED22B8-0x0000000189ED237C
		internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) => default; // 0x0000000183D88E50-0x0000000183D88E70
	}

	internal interface IUIElementsUtility // TypeDefIndex: 43332
	{
		// Methods
		bool TakeCapture();
		bool ReleaseCapture();
		bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled);
		bool CleanupRoots();
		bool EndContainerGUIFromException(Exception exception);
		bool MakeCurrentIMGUIContainerDirty();
	}

	internal static class UIEventRegistration // TypeDefIndex: 43334
	{
		// Fields
		private static List<IUIElementsUtility> s_Utilities; // 0x00
	
		// Constructors
		static UIEventRegistration() {} // 0x0000000183805060-0x0000000183805670
	
		// Methods
		internal static void RegisterUIElementSystem(IUIElementsUtility utility) {} // 0x0000000183CAA6F0-0x0000000183CAA770
		private static void TakeCapture() {} // 0x0000000189ED4248-0x0000000189ED43C8
		private static void ReleaseCapture() {} // 0x0000000189ED40D4-0x0000000189ED4248
		private static bool EndContainerGUIFromException(Exception exception) => default; // 0x0000000189ED3BC0-0x0000000189ED3D74
		private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) => default; // 0x0000000189ED3EF4-0x0000000189ED40D4
		private static void CleanupRoots() {} // 0x0000000189ED3A40-0x0000000189ED3BC0
		internal static void MakeCurrentIMGUIContainerDirty() {} // 0x0000000189ED3D74-0x0000000189ED3EF4
	}

	internal class UIElementsUtility : IUIElementsUtility // TypeDefIndex: 43335
	{
		// Fields
		private static Stack<IMGUIContainer> s_ContainerStack; // 0x00
		private static Dictionary<int, UnityEngine.UIElements.Panel> s_UIElementsCache; // 0x08
		private static UnityEngine.Event s_EventInstance; // 0x10
		internal static UnityEngine.Color editorPlayModeTintColor; // 0x18
		internal static float singleLineHeight; // 0x28
		private static UIElementsUtility s_Instance; // 0x30
		internal static List<UnityEngine.UIElements.Panel> s_PanelsIterationList; // 0x38
		internal static readonly string s_RepaintProfilerMarkerName; // 0x40
		internal static readonly string s_EventProfilerMarkerName; // 0x48
		private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x50
		private static readonly ProfilerMarker s_EventProfilerMarker; // 0x58
	
		// Constructors
		private UIElementsUtility() {} // 0x0000000183CAA6A0-0x0000000183CAA6F0
		static UIElementsUtility() {} // 0x0000000182DF60F0-0x0000000182DF6410
	
		// Methods
		bool IUIElementsUtility.MakeCurrentIMGUIContainerDirty() => default; // 0x0000000189ED3740-0x0000000189ED37EC
		bool IUIElementsUtility.TakeCapture() => default; // 0x0000000189ED38F8-0x0000000189ED3A40
		bool IUIElementsUtility.ReleaseCapture() => default; // 0x0000000183D4E3A0-0x0000000183D4E3B0
		bool IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) => default; // 0x0000000189ED37EC-0x0000000189ED38F8
		bool IUIElementsUtility.CleanupRoots() => default; // 0x0000000189ED35F0-0x0000000189ED369C
		bool IUIElementsUtility.EndContainerGUIFromException(Exception exception) => default; // 0x0000000189ED369C-0x0000000189ED3740
		public static void RegisterCachedPanel(int instanceID, UnityEngine.UIElements.Panel panel) {} // 0x0000000189ED348C-0x0000000189ED3508
		public static void RemoveCachedPanel(int instanceID) {} // 0x0000000189ED3508-0x0000000189ED3574
		public static bool TryGetPanel(int instanceID, out UnityEngine.UIElements.Panel panel) {
			panel = default;
			return default;
		} // 0x0000000189ED3574-0x0000000189ED35F0
		internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, UnityEngine.Event evt, IMGUIContainer container) {} // 0x0000000189ED28D4-0x0000000189ED2A8C
		internal static void EndContainerGUI(UnityEngine.Event evt, Rect layoutSize) {} // 0x0000000189ED3240-0x0000000189ED33FC
		internal static EventBase CreateEvent(UnityEngine.Event systemEvent) => default; // 0x0000000189ED2A8C-0x0000000189ED2AF0
		internal static EventBase CreateEvent(UnityEngine.Event systemEvent, UnityEngine.EventType eventType) => default; // 0x0000000189ED2AF0-0x0000000189ED2D78
		private static bool DoDispatch(BaseVisualElementPanel panel) => default; // 0x0000000189ED2D78-0x0000000189ED3240
		internal static void GetAllPanels(List<UnityEngine.UIElements.Panel> panels, ContextType contextType) {} // 0x00000001836FEF50-0x00000001836FF030
		internal static Dictionary<int, UnityEngine.UIElements.Panel> GetPanelsIterator() => default; // 0x00000001836FF030-0x00000001836FF0E0
		internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite) => default; // 0x0000000189ED33FC-0x0000000189ED348C
	}

	internal struct RuleMatcher // TypeDefIndex: 43336
	{
		// Fields
		public StyleSheet sheet; // 0x00
		public StyleComplexSelector complexSelector; // 0x08
	
		// Methods
		public override string ToString() => default; // 0x0000000189ECDFE0-0x0000000189ECE004
	}

	public static class UQuery // TypeDefIndex: 43343
	{
		// Nested types
		internal interface IVisualPredicateWrapper // TypeDefIndex: 43337
		{
			// Methods
			bool Predicate(object e);
		}
	
		internal class IsOfType<T> : IVisualPredicateWrapper // TypeDefIndex: 43338
			where T : VisualElement
		{
			// Fields
			public static IsOfType<T> s_Instance;
	
			// Constructors
			public IsOfType() {}
			static IsOfType() {}
	
			// Methods
			public bool Predicate(object e) => default;
		}
	
		internal abstract class UQueryMatcher : HierarchyTraversal // TypeDefIndex: 43340
		{
			// Fields
			internal List<RuleMatcher> m_Matchers; // 0x10
	
			// Constructors
			protected UQueryMatcher() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override void Traverse(VisualElement element) {} // 0x0000000189ED50A0-0x0000000189ED50A8
			protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) => default; // 0x0000000183D4E3A0-0x0000000183D4E3B0
			private static void NoProcessResult(VisualElement e, MatchResultInfo i) {} // 0x000000018350B670-0x000000018350B680
			public override void TraverseRecursive(VisualElement element, int depth) {} // 0x0000000189ED4EA8-0x0000000189ED50A0
			public virtual void Run(VisualElement root, List<RuleMatcher> matchers) {} // 0x0000000189ED4E7C-0x0000000189ED4EA8
		}
	
		internal abstract class SingleQueryMatcher : UQueryMatcher // TypeDefIndex: 43341
		{
			// Properties
			public VisualElement match { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
			// Constructors
			protected SingleQueryMatcher() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public override void Run(VisualElement root, List<RuleMatcher> matchers) {} // 0x0000000189ECE004-0x0000000189ECE04C
			public bool IsInUse() => default; // 0x000000018246CF60-0x000000018246CF70
			public abstract SingleQueryMatcher CreateNew();
		}
	
		internal class FirstQueryMatcher : SingleQueryMatcher // TypeDefIndex: 43342
		{
			// Fields
			public static readonly FirstQueryMatcher Instance; // 0x00
	
			// Constructors
			public FirstQueryMatcher() {} // 0x000000018350B670-0x000000018350B680
			static FirstQueryMatcher() {} // 0x0000000189ECDF7C-0x0000000189ECDFE0
	
			// Methods
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) => default; // 0x0000000189ECDF5C-0x0000000189ECDF7C
			public override SingleQueryMatcher CreateNew() => default; // 0x0000000189ECDF20-0x0000000189ECDF5C
		}
	}

	public struct UQueryState<T> : IEnumerable<T>, IEquatable<UQueryState<T>> // TypeDefIndex: 43347
		where T : VisualElement
	{
		// Fields
		private static ActionQueryMatcher s_Action;
		private readonly VisualElement m_Element;
		internal readonly List<RuleMatcher> m_Matchers;
		private static readonly ListQueryMatcher s_List;
		private static readonly ListQueryMatcher<VisualElement> s_EnumerationList;
	
		// Nested types
		private class ListQueryMatcher<TElement> : UQuery.UQueryMatcher // TypeDefIndex: 43344
			where TElement : VisualElement
		{
			// Properties
			public List<TElement> matches { get; set; }
	
			// Constructors
			public ListQueryMatcher() {}
	
			// Methods
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) => default;
			public void Reset() {}
		}
	
		private class ActionQueryMatcher : UQuery.UQueryMatcher // TypeDefIndex: 43345
		{
			// Properties
			internal Action<T> callBack { get; }
	
			// Constructors
			public ActionQueryMatcher() {}
	
			// Methods
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) => default;
		}
	
		public struct Enumerator : IEnumerator<T> // TypeDefIndex: 43346
		{
			// Fields
			private List<VisualElement> iterationList;
			private int currentIndex;
	
			// Properties
			public T Current { get => default; }
			object IEnumerator.Current { get => default; }
	
			// Constructors
			internal Enumerator(UQueryState<T> queryState) : this() {
				iterationList = default;
				currentIndex = default;
			}
	
			// Methods
			public bool MoveNext() => default;
			public void Reset() {}
			public void Dispose() {}
		}
	
		// Constructors
		internal UQueryState(VisualElement element, List<RuleMatcher> matchers) {
			m_Element = default;
			m_Matchers = default;
		}
		static UQueryState() {
			s_Action = default;
			s_List = default;
			s_EnumerationList = default;
		}
	
		// Methods
		public UQueryState<T> RebuildOn(VisualElement element) => default;
		private T Single(UQuery.SingleQueryMatcher matcher) => default;
		public T First() => default;
		public void ToList(List<T> results) {}
		public Enumerator GetEnumerator() => default;
		IEnumerator<T> IEnumerable<T>.GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
		public bool Equals(UQueryState<T> other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}

	public struct UQueryBuilder<T> : IEquatable<UQueryBuilder<T>> // TypeDefIndex: 43348
		where T : VisualElement
	{
		// Fields
		private List<StyleSelector> m_StyleSelectors;
		private List<StyleSelectorPart> m_Parts;
		private VisualElement m_Element;
		private List<RuleMatcher> m_Matchers;
		private StyleSelectorRelationship m_Relationship;
		private int pseudoStatesMask;
		private int negatedPseudoStatesMask;
	
		// Properties
		private List<StyleSelector> styleSelectors { get => default; }
		private List<StyleSelectorPart> parts { get => default; }
	
		// Constructors
		public UQueryBuilder(VisualElement visualElement) : this() {
			m_StyleSelectors = default;
			m_Parts = default;
			m_Element = default;
			m_Matchers = default;
			m_Relationship = default;
			pseudoStatesMask = default;
			negatedPseudoStatesMask = default;
		}
	
		// Methods
		public UQueryBuilder<T> Class(string classname) => default;
		public UQueryBuilder<T> Name(string id) => default;
		public UQueryBuilder<T2> OfType<T2>(string name = null, string className = null)
			where T2 : VisualElement => default;
		internal UQueryBuilder<T> SingleBaseType() => default;
		private void AddClass(string c) {}
		private void AddName(string id) {}
		private void AddType<T2>()
			where T2 : VisualElement {}
		private UQueryBuilder<T2> AddRelationship<T2>(StyleSelectorRelationship relationship)
			where T2 : VisualElement => default;
		private void AddPseudoStatesRuleIfNecessasy() {}
		private void FinishSelector() {}
		private bool CurrentSelectorEmpty() => default;
		private void FinishCurrentSelector() {}
		public UQueryState<T> Build() => default;
		public void ToList(List<T> results) {}
		public bool Equals(UQueryBuilder<T> other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
	}

	public static class UQueryExtensions // TypeDefIndex: 43349
	{
		// Fields
		private static UQueryState<VisualElement> SingleElementEmptyQuery; // 0x00
		private static UQueryState<VisualElement> SingleElementNameQuery; // 0x10
		private static UQueryState<VisualElement> SingleElementClassQuery; // 0x20
		private static UQueryState<VisualElement> SingleElementNameAndClassQuery; // 0x30
		private static UQueryState<VisualElement> SingleElementTypeQuery; // 0x40
		private static UQueryState<VisualElement> SingleElementTypeAndNameQuery; // 0x50
		private static UQueryState<VisualElement> SingleElementTypeAndClassQuery; // 0x60
		private static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery; // 0x70
	
		// Constructors
		static UQueryExtensions() {} // 0x0000000189ED4790-0x0000000189ED4E7C
	
		// Extension methods
		public static T Q<T>(this VisualElement e, string name = null, string className = null)
			where T : VisualElement => default;
		public static VisualElement Q(this VisualElement e, string name = null, string className = null) => default; // 0x0000000189ED43C8-0x0000000189ED4790
		public static UQueryBuilder<T> Query<T>(this VisualElement e, string name = null, string className = null)
			where T : VisualElement => default;
	}

	internal enum GradientType // TypeDefIndex: 43350
	{
		Linear = 0,
		Radial = 1
	}

	internal enum AddressMode // TypeDefIndex: 43351
	{
		Wrap = 0,
		Clamp = 1,
		Mirror = 2
	}

	[Serializable]
	internal struct VectorImageVertex // TypeDefIndex: 43352
	{
		// Fields
		public Vector3 position; // 0x00
		public Color32 tint; // 0x0C
		public Vector2 uv; // 0x10
		public uint settingIndex; // 0x18
	}

	[Serializable]
	internal struct GradientSettings // TypeDefIndex: 43353
	{
		// Fields
		public GradientType gradientType; // 0x00
		public AddressMode addressMode; // 0x04
		public Vector2 radialFocus; // 0x08
		public RectInt location; // 0x10
	}

	[Serializable]
	public class VectorImage : ScriptableObject // TypeDefIndex: 43354
	{
		// Fields
		[SerializeField]
		internal Texture2D atlas; // 0x18
		[SerializeField]
		internal VectorImageVertex[] vertices; // 0x20
		[SerializeField]
		internal ushort[] indices; // 0x28
		[SerializeField]
		internal GradientSettings[] settings; // 0x30
		[SerializeField]
		internal Vector2 size; // 0x38
	
		// Constructors
		public VectorImage() {} // 0x0000000189ED7B88-0x0000000189ED7BD8
	}

	[Flags]
	internal enum PseudoStates // TypeDefIndex: 43355
	{
		Active = 1,
		Hover = 2,
		Checked = 8,
		Disabled = 32,
		Focus = 64,
		Root = 128
	}

	[Flags]
	internal enum VisualElementFlags // TypeDefIndex: 43356
	{
		WorldTransformDirty = 1,
		WorldTransformInverseDirty = 2,
		WorldClipDirty = 4,
		BoundingBoxDirty = 8,
		WorldBoundingBoxDirty = 16,
		LayoutManual = 32,
		CompositeRoot = 64,
		RequireMeasureFunction = 128,
		EnableViewDataPersistence = 256,
		DisableClipping = 512,
		NeedsAttachToPanelEvent = 1024,
		HierarchyDisplayed = 2048,
		Init = 2079,
		StyleInitialized = 4096
	}

	public enum PickingMode // TypeDefIndex: 43357
	{
		Position = 0,
		Ignore = 1
	}

	public enum LanguageDirection // TypeDefIndex: 43358
	{
		Inherit = 0,
		LTR = 1,
		RTL = 2
	}

	internal static class VisualElementListPool // TypeDefIndex: 43359
	{
		// Fields
		private static UnityEngine.UIElements.ObjectPool<List<VisualElement>> pool; // 0x00
	
		// Constructors
		static VisualElementListPool() {} // 0x0000000189EDA1F8-0x0000000189EDA28C
	
		// Methods
		public static List<VisualElement> Copy(List<VisualElement> elements) => default; // 0x0000000189EDA008-0x0000000189EDA0A8
		public static List<VisualElement> Get(int initialCapacity = 0 /* Metadata: 0x01FB5EC5 */) => default; // 0x0000000189EDA0A8-0x0000000189EDA168
		public static void Release(List<VisualElement> elements) {} // 0x0000000189EDA168-0x0000000189EDA1F8
	}

	internal class ObjectListPool<T> // TypeDefIndex: 43360
	{
		// Fields
		private static UnityEngine.UIElements.ObjectPool<List<T>> pool;
	
		// Constructors
		public ObjectListPool() {} // Dummy constructor
		static ObjectListPool() {}
	
		// Methods
		public static List<T> Get() => default;
		public static void Release(List<T> elements) {}
	}

	public static class VisualElementExtensions // TypeDefIndex: 43361
	{
		// Extension methods
		public static void StretchToParentSize(this VisualElement elem) {} // 0x0000000189ED85F4-0x0000000189ED8764
		public static void AddManipulator(this VisualElement ele, IManipulator manipulator) {} // 0x0000000189ED84E0-0x0000000189ED84F4
		public static void RemoveManipulator(this VisualElement ele, IManipulator manipulator) {} // 0x0000000189ED85E0-0x0000000189ED85F4
		public static Vector2 WorldToLocal(this VisualElement ele, Vector2 p) => default; // 0x0000000189ED8848-0x0000000189ED8904
		public static Vector2 LocalToWorld(this VisualElement ele, Vector2 p) => default; // 0x0000000189ED8524-0x0000000189ED85E0
		public static Rect WorldToLocal(this VisualElement ele, Rect r) => default; // 0x0000000189ED8764-0x0000000189ED8848
		public static Vector2 ChangeCoordinatesTo(this VisualElement src, VisualElement dest, Vector2 point) => default; // 0x0000000189ED84F4-0x0000000189ED8524
	}

	public interface IExperimentalFeatures // TypeDefIndex: 43362
	{
		// Properties
		ITransitionAnimations animation { get; }
	}

	public class VisualElementFocusChangeDirection : FocusChangeDirection // TypeDefIndex: 43363
	{
		// Fields
		private static readonly VisualElementFocusChangeDirection s_Left; // 0x00
		private static readonly VisualElementFocusChangeDirection s_Right; // 0x08
	
		// Properties
		public static FocusChangeDirection left { get => default; } // 0x0000000189ED8A5C-0x0000000189ED8AAC 
		public static FocusChangeDirection right { get => default; } // 0x0000000189ED8AAC-0x0000000189ED8AFC 
	
		// Constructors
		public VisualElementFocusChangeDirection() {} // Dummy constructor
		protected VisualElementFocusChangeDirection(int value) {} // 0x0000000189ED8A0C-0x0000000189ED8A5C
		static VisualElementFocusChangeDirection() {} // 0x0000000189ED8904-0x0000000189ED8A0C
	}

	internal class VisualElementFocusChangeTarget : FocusChangeDirection // TypeDefIndex: 43364
	{
		// Fields
		private static readonly UnityEngine.UIElements.ObjectPool<VisualElementFocusChangeTarget> Pool; // 0x00
	
		// Properties
		public Focusable target { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public VisualElementFocusChangeTarget() {} // 0x0000000189ED8CB0-0x0000000189ED8D0C
		static VisualElementFocusChangeTarget() {} // 0x0000000189ED8C1C-0x0000000189ED8CB0
	
		// Methods
		public static VisualElementFocusChangeTarget GetPooled(Focusable target) => default; // 0x0000000189ED8B98-0x0000000189ED8C1C
		protected override void Dispose() {} // 0x0000000189ED8B1C-0x0000000189ED8B98
		internal override void ApplyTo(FocusController focusController, Focusable f) {} // 0x0000000189ED8AFC-0x0000000189ED8B1C
	}

	public class VisualElementFocusRing : IFocusRing // TypeDefIndex: 43367
	{
		// Fields
		private readonly VisualElement root; // 0x10
		private List<FocusRingRecord> m_FocusRing; // 0x20
	
		// Properties
		private FocusController focusController { get => default; } // 0x0000000189ED9FE4-0x0000000189EDA008 
		public DefaultFocusOrder defaultFocusOrder { get; set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
	
		// Nested types
		public enum DefaultFocusOrder // TypeDefIndex: 43365
		{
			ChildOrder = 0,
			PositionXY = 1,
			PositionYX = 2
		}
	
		private class FocusRingRecord // TypeDefIndex: 43366
		{
			// Fields
			public int m_AutoIndex; // 0x10
			public Focusable m_Focusable; // 0x18
			public bool m_IsSlot; // 0x20
			public List<FocusRingRecord> m_ScopeNavigationOrder; // 0x28
	
			// Constructors
			public FocusRingRecord() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public VisualElementFocusRing() {} // Dummy constructor
		public VisualElementFocusRing(VisualElement root, DefaultFocusOrder dfo = DefaultFocusOrder.ChildOrder /* Metadata: 0x01FB5EC6 */) {} // 0x0000000189ED9F4C-0x0000000189ED9FE4
	
		// Methods
		private int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b) => default; // 0x0000000189ED9024-0x0000000189ED945C
		private int FocusRingSort(FocusRingRecord a, FocusRingRecord b) => default; // 0x0000000189ED945C-0x0000000189ED9564
		private void DoUpdate() {} // 0x0000000189ED8F64-0x0000000189ED9024
		private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<FocusRingRecord> scopeList) {} // 0x0000000189ED8D0C-0x0000000189ED8F64
		private void SortAndFlattenScopeLists(List<FocusRingRecord> rootScopeList) {} // 0x0000000189ED9CA4-0x0000000189ED9F4C
		private int GetFocusableInternalIndex(Focusable f) => default; // 0x0000000189ED9718-0x0000000189ED97A8
		public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) => default; // 0x0000000189ED9564-0x0000000189ED9718
		internal static FocusChangeDirection GetKeyDownFocusChangeDirection(EventBase e) => default; // 0x0000000189ED97A8-0x0000000189ED98D4
		public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) => default; // 0x0000000189ED995C-0x0000000189ED9BE0
		internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable) => default; // 0x0000000189ED98D4-0x0000000189ED995C
		internal static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable) => default; // 0x0000000189ED9BE0-0x0000000189ED9CA4
	}

	public interface IVisualElementScheduledItem // TypeDefIndex: 43368
	{
		// Properties
		bool isActive { get; }
	
		// Methods
		void Resume();
		void Pause();
		void ExecuteLater(long delayMs);
		IVisualElementScheduledItem StartingIn(long delayMs);
		IVisualElementScheduledItem Every(long intervalMs);
	}

	public interface IVisualElementScheduler // TypeDefIndex: 43369
	{
		// Methods
		IVisualElementScheduledItem Execute(Action<UnityEngine.UIElements.TimerState> timerUpdateEvent);
		IVisualElementScheduledItem Execute(Action updateEvent);
	}

	internal interface IVisualElementPanelActivatable // TypeDefIndex: 43370
	{
		// Properties
		VisualElement element { get; }
	
		// Methods
		bool CanBeActivated();
		void OnPanelActivate();
		void OnPanelDeactivate();
	}

	internal class VisualElementPanelActivator // TypeDefIndex: 43371
	{
		// Fields
		private IVisualElementPanelActivatable m_Activatable; // 0x10
	
		// Properties
		public bool isActive { get; private set; } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
		public bool isDetaching { get; private set; } // 0x0000000183D4EF80-0x0000000183D4EF90 0x0000000183D4EFB0-0x0000000183D4EFC0
	
		// Constructors
		public VisualElementPanelActivator() {} // Dummy constructor
		public VisualElementPanelActivator(IVisualElementPanelActivatable activatable) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public void SetActive(bool action) {} // 0x0000000189EDA428-0x0000000189EDA660
		public void SendActivation() {} // 0x0000000189EDA328-0x0000000189EDA3A8
		public void SendDeactivation() {} // 0x0000000189EDA3A8-0x0000000189EDA428
		private void OnEnter(AttachToPanelEvent evt) {} // 0x0000000189EDA28C-0x0000000189EDA29C
		private void OnLeave(DetachFromPanelEvent evt) {} // 0x0000000189EDA29C-0x0000000189EDA328
	}

	[DefaultMember("Item")]
	public struct VisualElementStyleSheetSet : IEquatable<VisualElementStyleSheetSet> // TypeDefIndex: 43372
	{
		// Fields
		private readonly VisualElement m_Element; // 0x00
	
		// Constructors
		internal VisualElementStyleSheetSet(VisualElement element) {
			m_Element = default;
		} // 0x00000001842715A0-0x00000001842715A8
	
		// Methods
		public void Add(StyleSheet styleSheet) {} // 0x0000000189EDA660-0x0000000189EDA7F8
		public bool Remove(StyleSheet styleSheet) => default; // 0x0000000189EDA868-0x0000000189EDA9B4
		public bool Equals(VisualElementStyleSheetSet other) => default; // 0x0000000189E6F58C-0x0000000189E6F59C
		public override bool Equals(object obj) => default; // 0x0000000189EDA7F8-0x0000000189EDA868
		public override int GetHashCode() => default; // 0x000000018711E2B8-0x000000018711E2DC
	}

	internal static class VisualElementUtils // TypeDefIndex: 43373
	{
		// Fields
		private static readonly HashSet<string> s_usedNames; // 0x00
		private static readonly System.Type s_FoldoutType; // 0x08
	
		// Constructors
		static VisualElementUtils() {} // 0x0000000189EDAC48-0x0000000189EDAD34
	
		// Methods
		public static string GetUniqueName(string nameBase) => default; // 0x0000000189EDAB54-0x0000000189EDAC48
	
		// Extension methods
		internal static int GetFoldoutDepth(this VisualElement element) => default; // 0x0000000189EDA9B4-0x0000000189EDAA64
		internal static int GetListAndFoldoutDepth(this VisualElement element) => default; // 0x0000000189EDAA64-0x0000000189EDAB54
	}

	internal class VisualElementAnimationSystem : BaseVisualTreeUpdater // TypeDefIndex: 43374
	{
		// Fields
		private HashSet<IValueAnimationUpdate> m_Animations; // 0x20
		private List<IValueAnimationUpdate> m_IterationList; // 0x28
		private bool m_HasNewAnimations; // 0x30
		private bool m_IterationListDirty; // 0x31
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
		private static readonly string s_StylePropertyAnimationDescription; // 0x10
		private static readonly ProfilerMarker s_StylePropertyAnimationProfilerMarker; // 0x18
		private long lastUpdate; // 0x38
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x0000000189ED8440-0x0000000189ED8490 
		private static ProfilerMarker stylePropertyAnimationProfilerMarker { get => default; } // 0x0000000189ED8490-0x0000000189ED84E0 
	
		// Constructors
		public VisualElementAnimationSystem() {} // 0x0000000189ED837C-0x0000000189ED8440
		static VisualElementAnimationSystem() {} // 0x0000000189ED8270-0x0000000189ED837C
	
		// Methods
		public void UnregisterAnimation(IValueAnimationUpdate anim) {} // 0x0000000189ED7D74-0x0000000189ED7DD0
		public void UnregisterAnimations(List<IValueAnimationUpdate> anims) {} // 0x0000000189ED7DD0-0x0000000189ED7F0C
		public void RegisterAnimation(IValueAnimationUpdate anim) {} // 0x0000000189ED7BD8-0x0000000189ED7C34
		public void RegisterAnimations(List<IValueAnimationUpdate> anims) {} // 0x0000000189ED7C34-0x0000000189ED7D74
		public override void Update() {} // 0x0000000189ED7F0C-0x0000000189ED8270
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x000000018350B670-0x000000018350B680
	}

	internal enum HierarchyChangeType // TypeDefIndex: 43375
	{
		Add = 0,
		Remove = 1,
		Move = 2
	}

	internal abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater // TypeDefIndex: 43377
	{
		// Fields
		private State m_State; // 0x20
		private VisualElement m_CurrentChangeElement; // 0x28
		private VisualElement m_CurrentChangeParent; // 0x30
	
		// Nested types
		private enum State // TypeDefIndex: 43376
		{
			Waiting = 0,
			TrackingAddOrMove = 1,
			TrackingRemove = 2
		}
	
		// Constructors
		protected BaseVisualTreeHierarchyTrackerUpdater() {} // 0x0000000183D4E2C0-0x0000000183D4E2D0
	
		// Methods
		protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type);
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x0000000189ECDA48-0x0000000189ECDA88
		public override void Update() {} // 0x0000000189ECDC10-0x0000000189ECDCA8
		private void ProcessNewChange(VisualElement ve) {} // 0x0000000189ECDB20-0x0000000189ECDB9C
		private void ProcessAddOrMove(VisualElement ve) {} // 0x0000000189ECDA88-0x0000000189ECDB20
		private void ProcessRemove(VisualElement ve) {} // 0x0000000189ECDB9C-0x0000000189ECDC10
	}

	internal static class StyleCache // TypeDefIndex: 43378
	{
		// Fields
		private static Dictionary<long, ComputedStyle> s_ComputedStyleCache; // 0x00
		private static Dictionary<int, StyleVariableContext> s_StyleVariableContextCache; // 0x08
		private static Dictionary<int, ComputedTransitionProperty[]> s_ComputedTransitionsCache; // 0x10
	
		// Constructors
		static StyleCache() {} // 0x0000000189ECE378-0x0000000189ECE4D4
	
		// Methods
		public static bool TryGetValue(long hash, out ComputedStyle data) {
			data = default;
			return default;
		} // 0x0000000189ECE2FC-0x0000000189ECE378
		public static void SetValue(long hash, ref ComputedStyle data) {} // 0x0000000189ECE04C-0x0000000189ECE10C
		public static bool TryGetValue(int hash, out StyleVariableContext data) {
			data = default;
			return default;
		} // 0x0000000189ECE204-0x0000000189ECE280
		public static void SetValue(int hash, StyleVariableContext data) {} // 0x0000000189ECE10C-0x0000000189ECE188
		public static bool TryGetValue(int hash, out ComputedTransitionProperty[] data) {
			data = default;
			return default;
		} // 0x0000000189ECE280-0x0000000189ECE2FC
		public static void SetValue(int hash, ComputedTransitionProperty[] data) {} // 0x0000000189ECE188-0x0000000189ECE204
	}

	internal class VisualTreeStyleUpdater : BaseVisualTreeUpdater // TypeDefIndex: 43379
	{
		// Fields
		private HashSet<VisualElement> m_ApplyStyleUpdateList; // 0x20
		private HashSet<VisualElement> m_TransitionPropertyUpdateList; // 0x28
		private bool m_IsApplyingStyles; // 0x30
		private uint m_Version; // 0x34
		private uint m_LastVersion; // 0x38
		private VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal; // 0x40
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x0000000189EDE218-0x0000000189EDE268 
		protected bool disposed { get; private set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
	
		// Constructors
		public VisualTreeStyleUpdater() {} // 0x0000000189EDE12C-0x0000000189EDE218
		static VisualTreeStyleUpdater() {} // 0x0000000189EDE098-0x0000000189EDE12C
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x0000000189EDDCD0-0x0000000189EDDD84
		public override void Update() {} // 0x0000000189EDDD84-0x0000000189EDE098
		protected override void Dispose(bool disposing) {} // 0x0000000189EDDC9C-0x0000000189EDDCD0
		private void ApplyStyles() {} // 0x0000000189EDDBE4-0x0000000189EDDC9C
	}

	internal class StyleMatchingContext // TypeDefIndex: 43380
	{
		// Fields
		private List<StyleSheet> m_StyleSheetStack; // 0x10
		public StyleVariableContext variableContext; // 0x18
		public VisualElement currentElement; // 0x20
		public Action<VisualElement, MatchResultInfo> processResult; // 0x28
		public AncestorFilter ancestorFilter; // 0x30
	
		// Properties
		public int styleSheetCount { get => default; } // 0x0000000189ECE71C-0x0000000189ECE75C 
	
		// Constructors
		public StyleMatchingContext() {} // Dummy constructor
		public StyleMatchingContext(Action<VisualElement, MatchResultInfo> processResult) {} // 0x0000000189ECE60C-0x0000000189ECE71C
	
		// Methods
		public void AddStyleSheet(StyleSheet sheet) {} // 0x0000000189ECE4D4-0x0000000189ECE554
		public void RemoveStyleSheetRange(int index, int count) {} // 0x0000000189ECE5A8-0x0000000189ECE60C
		public StyleSheet GetStyleSheetAt(int index) => default; // 0x0000000189ECE554-0x0000000189ECE5A8
	}

	internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal // TypeDefIndex: 43382
	{
		// Fields
		private StyleVariableContext m_ProcessVarContext; // 0x10
		private HashSet<VisualElement> m_UpdateList; // 0x18
		private HashSet<VisualElement> m_ParentList; // 0x20
		private List<SelectorMatchRecord> m_TempMatchResults; // 0x28
		private StyleMatchingContext m_StyleMatchingContext; // 0x38
		private StylePropertyReader m_StylePropertyReader; // 0x40
		private readonly List<StylePropertyId> m_AnimatedProperties; // 0x48
	
		// Properties
		private float currentPixelsPerPoint { get; set; } // 0x0000000183D4F5D0-0x0000000183D4F5E0 0x0000000183D4F5E0-0x0000000183D4F5F0
	
		// Constructors
		public VisualTreeStyleUpdaterTraversal() {} // 0x0000000189EDD998-0x0000000189EDDBE4
	
		// Methods
		public void PrepareTraversal(float pixelsPerPoint) {} // 0x0000000183D4F5E0-0x0000000183D4F5F0
		public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType) {} // 0x0000000189EDC0D0-0x0000000189EDC154
		public void Clear() {} // 0x0000000189EDC310-0x0000000189EDC38C
		private void PropagateToChildren(VisualElement ve) {} // 0x0000000189EDD110-0x0000000189EDD1D0
		private void PropagateToParents(VisualElement ve) {} // 0x0000000189EDD1D0-0x0000000189EDD250
		private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info) {} // 0x0000000189EDC534-0x0000000189EDC568
		public override void TraverseRecursive(VisualElement element, int depth) {} // 0x0000000189EDD2D4-0x0000000189EDD998
		private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle) {} // 0x0000000189EDD03C-0x0000000189EDD110
		private void ForceUpdateTransitions(VisualElement element) {} // 0x0000000189EDC38C-0x0000000189EDC534
		internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle) {} // 0x0000000189EDC154-0x0000000189EDC310
		protected bool ShouldSkipElement(VisualElement element) => default; // 0x0000000189EDD250-0x0000000189EDD2D4
		private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors) => default; // 0x0000000189EDC568-0x0000000189EDCF7C
		private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule) {} // 0x0000000189EDCF7C-0x0000000189EDD03C
	}

	internal class VisualTreeTransformClipUpdater : BaseVisualTreeUpdater // TypeDefIndex: 43383
	{
		// Fields
		private uint m_Version; // 0x20
		private uint m_LastVersion; // 0x24
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x0000000189EDE5AC-0x0000000189EDE5FC 
	
		// Constructors
		public VisualTreeTransformClipUpdater() {} // 0x0000000183D65C60-0x0000000183D65C70
		static VisualTreeTransformClipUpdater() {} // 0x0000000189EDE518-0x0000000189EDE5AC
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x0000000189EDE3EC-0x0000000189EDE4C0
		private static void DirtyHierarchy(VisualElement ve, bool mustDirtyWorldTransform, bool mustDirtyWorldClip) {} // 0x0000000189EDE2C4-0x0000000189EDE3EC
		private static void DirtyBoundingBoxHierarchy(VisualElement ve) {} // 0x0000000189EDE268-0x0000000189EDE2C4
		public override void Update() {} // 0x0000000189EDE4C0-0x0000000189EDE518
	}

	internal enum VisualTreeUpdatePhase // TypeDefIndex: 43384
	{
		ViewData = 0,
		Bindings = 1,
		Animation = 2,
		Styles = 3,
		Layout = 4,
		TransformClip = 5,
		Repaint = 6,
		Count = 7
	}

	internal sealed class VisualTreeUpdater : IDisposable // TypeDefIndex: 43386
	{
		// Fields
		private BaseVisualElementPanel m_Panel; // 0x10
		private UpdaterArray m_UpdaterArray; // 0x18
	
		// Nested types
		private class UpdaterArray // TypeDefIndex: 43385
		{
			// Fields
			private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10
	
			// Properties
			public IVisualTreeUpdater this[VisualTreeUpdatePhase phase] { get => default; set {} } // 0x000000018594E120-0x000000018594E14C 0x000000018594E14C-0x000000018594E1A8
			public IVisualTreeUpdater this[int index] { get => default; } // 0x000000018594E120-0x000000018594E14C 
	
			// Constructors
			public UpdaterArray() {} // 0x0000000189ED50A8-0x0000000189ED50F0
		}
	
		// Constructors
		public VisualTreeUpdater() {} // Dummy constructor
		public VisualTreeUpdater(BaseVisualElementPanel panel) {} // 0x0000000189EDE8C0-0x0000000189EDE940
	
		// Methods
		public void Dispose() {} // 0x0000000189EDE5FC-0x0000000189EDE66C
		public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) {} // 0x0000000189EDE7F4-0x0000000189EDE8C0
		public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x0000000189EDE68C-0x0000000189EDE6F8
		public void SetUpdater<T>(VisualTreeUpdatePhase phase)
			where T : IVisualTreeUpdater, new() {}
		public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) => default; // 0x0000000189EDE66C-0x0000000189EDE68C
		private void SetDefaultUpdaters() {} // 0x0000000189EDE6F8-0x0000000189EDE7F4
	}

	internal interface IVisualTreeUpdater : IDisposable // TypeDefIndex: 43387
	{
		// Properties
		BaseVisualElementPanel panel { get; set; }
		ProfilerMarker profilerMarker { get; }
	
		// Methods
		void Update();
		void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);
	}

	internal abstract class BaseVisualTreeUpdater : IVisualTreeUpdater // TypeDefIndex: 43388
	{
		// Fields
		private BaseVisualElementPanel m_Panel; // 0x18
	
		// Properties
		public BaseVisualElementPanel panel { get; set; } // 0x0000000183D61D00-0x0000000183D61D10 0x0000000189ECDE34-0x0000000189ECDE68
		public VisualElement visualTree { get; } // 0x0000000189ECDD84-0x0000000189ECDDA8 
		public abstract ProfilerMarker profilerMarker { get; }
	
		// Events
		public event Action<BaseVisualElementPanel> panelChanged;
	
		// Constructors
		protected BaseVisualTreeUpdater() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x0000000189ECDCA8-0x0000000189ECDCF8
		protected virtual void Dispose(bool disposing) {} // 0x000000018350B670-0x000000018350B680
		public abstract void Update();
		public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType);
	}

	internal class VisualTreeViewDataUpdater : BaseVisualTreeUpdater // TypeDefIndex: 43389
	{
		// Fields
		private HashSet<VisualElement> m_UpdateList; // 0x20
		private HashSet<VisualElement> m_ParentList; // 0x28
		private uint m_Version; // 0x30
		private uint m_LastVersion; // 0x34
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x0000000189EDEDC8-0x0000000189EDF008 
	
		// Constructors
		public VisualTreeViewDataUpdater() {} // 0x0000000189EDED18-0x0000000189EDEDC8
		static VisualTreeViewDataUpdater() {} // 0x0000000189EDEC84-0x0000000189EDED18
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x0000000189EDE940-0x0000000189EDE9BC
		public override void Update() {} // 0x0000000189EDEA3C-0x0000000189EDEB40
		private void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence) {} // 0x0000000189EDEB40-0x0000000189EDEC84
		private void PropagateToParents(VisualElement ve) {} // 0x0000000189EDE9BC-0x0000000189EDEA3C
	}

	internal interface IBindingRequest // TypeDefIndex: 43390
	{
		// Methods
		void Bind(VisualElement element);
	}

	internal class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater // TypeDefIndex: 43391
	{
		// Fields
		private static readonly PropertyName s_BindingRequestObjectVEPropertyName; // 0x00
		private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName; // 0x04
		private static readonly string s_Description; // 0x08
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x10
		private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker; // 0x18
		private static ProfilerMarker s_MarkerUpdate; // 0x20
		private static ProfilerMarker s_MarkerPoll; // 0x28
		private readonly HashSet<VisualElement> m_ElementsWithBindings; // 0x38
		private readonly HashSet<VisualElement> m_ElementsToAdd; // 0x40
		private readonly HashSet<VisualElement> m_ElementsToRemove; // 0x48
		private long m_LastUpdateTime; // 0x50
		private HashSet<VisualElement> m_ElementsToBind; // 0x58
		private List<IBinding> updatedBindings; // 0x68
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x0000000189EDC080-0x0000000189EDC0D0 
		public Dictionary<object, object> temporaryObjectCache { get; } // 0x0000000183D4EB00-0x0000000183D4EB10 
	
		// Constructors
		public VisualTreeBindingsUpdater() {} // 0x0000000189EDBED0-0x0000000189EDC080
		static VisualTreeBindingsUpdater() {} // 0x0000000189EDBD0C-0x0000000189EDBED0
	
		// Methods
		private IBinding GetBindingObjectFromElement(VisualElement ve) => default; // 0x0000000189EDADEC-0x0000000189EDAE70
		private void StartTracking(VisualElement ve) {} // 0x0000000189EDB318-0x0000000189EDB390
		private void StopTracking(VisualElement ve) {} // 0x0000000189EDB490-0x0000000189EDB508
		public static IBinding GetAdditionalBinding(VisualElement ve) => default; // 0x0000000189EDAD74-0x0000000189EDADEC
		private void StartTrackingRecursive(VisualElement ve) {} // 0x0000000189EDB204-0x0000000189EDB318
		private void StopTrackingRecursive(VisualElement ve) {} // 0x0000000189EDB390-0x0000000189EDB490
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x0000000189EDAE98-0x0000000189EDAF78
		protected override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) {} // 0x0000000189EDAE70-0x0000000189EDAE98
		private static long CurrentTime() => default; // 0x0000000189EDAD34-0x0000000189EDAD74
		public void PerformTrackingOperations() {} // 0x0000000189EDAF78-0x0000000189EDB204
		public override void Update() {} // 0x0000000189EDB8D8-0x0000000189EDBD0C
		private void UpdateBindings() {} // 0x0000000189EDB508-0x0000000189EDB8D8
	}

	public abstract class BaseListViewController : CollectionViewController // TypeDefIndex: 43392
	{
		// Properties
		protected BaseListView baseListView { get; } // 0x0000000189ECD860-0x0000000189ECD89C 
	
		// Events
		public event Action itemsSourceSizeChanged;
		public event Action<IEnumerable<int>> itemsAdded;
		public event Action<IEnumerable<int>> itemsRemoved;
	
		// Constructors
		protected BaseListViewController() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) {} // 0x0000000189ECCC04-0x0000000189ECCCD4
		internal void PostInitRegistration(ReusableListViewItem listItem) {} // 0x0000000189ECCDB4-0x0000000189ECCFF0
		internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) {} // 0x0000000189ECCB34-0x0000000189ECCC04
		public virtual bool NeedsDragHandle(int index) => default; // 0x0000000183D663A0-0x0000000183D663B0
		public virtual void AddItems(int itemCount) {} // 0x0000000189ECC4BC-0x0000000189ECC8D8
		public virtual void Move(int index, int newIndex) {} // 0x0000000189ECCCD4-0x0000000189ECCDB4
		public virtual void RemoveItem(int index) {} // 0x0000000189ECD1A4-0x0000000189ECD2BC
		public virtual void RemoveItems(List<int> indices) {} // 0x0000000189ECD404-0x0000000189ECD550
		internal virtual void RemoveItems(int itemCount) {} // 0x0000000189ECD2BC-0x0000000189ECD404
		public virtual void ClearItems() {} // 0x0000000189ECC9B8-0x0000000189ECCA54
		protected void RaiseOnSizeChanged() {} // 0x0000000189ECD018-0x0000000189ECD028
		protected void RaiseItemsAdded(IEnumerable<int> indices) {} // 0x0000000189ECCFF0-0x0000000189ECD004
		protected void RaiseItemsRemoved(IEnumerable<int> indices) {} // 0x0000000189ECD004-0x0000000189ECD018
		private static Array AddToArray(Array source, int itemCount) => default; // 0x0000000189ECC8D8-0x0000000189ECC9B8
		private static Array RemoveFromArray(Array source, List<int> indicesToRemove) => default; // 0x0000000189ECD028-0x0000000189ECD1A4
		private void Swap(int lhs, int rhs) {} // 0x0000000189ECD550-0x0000000189ECD620
		private void EnsureItemSourceCanBeResized() {} // 0x0000000189ECCA54-0x0000000189ECCB34
	}

	public abstract class BaseTreeViewController : CollectionViewController // TypeDefIndex: 43394
	{
		// Fields
		private Dictionary<int, TreeItem> m_TreeItems; // 0x30
		private List<int> m_RootIndices; // 0x38
		private List<TreeViewItemWrapper> m_ItemWrappers; // 0x40
		private HashSet<int> m_TreeItemIdsWithItemWrappers; // 0x48
		private List<TreeViewItemWrapper> m_WrapperInsertionList; // 0x50
		private static readonly ProfilerMarker K_ExpandItemByIndex; // 0x00
		private static readonly ProfilerMarker k_CreateWrappers; // 0x08
	
		// Properties
		protected BaseTreeView baseTreeView { get; } // 0x0000000189EE40E4-0x0000000189EE4120 
		public override IList itemsSource { get; set; } // 0x0000000181041090-0x00000001810410A0 0x0000000189EE4120-0x0000000189EE417C
	
		// Constructors
		protected BaseTreeViewController() {} // 0x0000000189EE3F58-0x0000000189EE40E4
		static BaseTreeViewController() {} // 0x0000000189EE3EC0-0x0000000189EE3F58
	
		// Methods
		public void RebuildTree() {} // 0x0000000189EE3B94-0x0000000189EE3E2C
		public IEnumerable<int> GetRootItemIds() => default; // 0x0000000183D86EB0-0x0000000183D86EC0
		public abstract IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null);
		public abstract int GetParentId(int id);
		public abstract IEnumerable<int> GetChildrenIds(int id);
		public abstract void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x01FB5ED8 */, bool rebuildTree = true /* Metadata: 0x01FB5ED9 */);
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) {} // 0x0000000189EE3214-0x0000000189EE3290
		internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) {} // 0x0000000189EE303C-0x0000000189EE3100
		internal override void InvokeDestroyItem(ReusableCollectionItem reusableItem) {} // 0x0000000189EE3100-0x0000000189EE3214
		internal void PostInitRegistration(ReusableTreeViewItem treeItem) {} // 0x0000000189EE3984-0x0000000189EE3B80
		private void OnItemPointerUp(PointerUpEvent evt) {} // 0x0000000189EE33D8-0x0000000189EE387C
		private void OnToggleValueChanged(ChangeEvent<bool> evt) {} // 0x0000000189EE387C-0x0000000189EE3984
		public override int GetIndexForId(int id) => default; // 0x0000000189EE2E70-0x0000000189EE2F20
		public override int GetIdForIndex(int index) => default; // 0x0000000189EE2D8C-0x0000000189EE2E00
		public virtual bool HasChildren(int id) => default; // 0x0000000189EE2FBC-0x0000000189EE303C
		internal bool Exists(int id) => default; // 0x0000000189EE2338-0x0000000189EE238C
		public bool HasChildrenByIndex(int index) => default; // 0x0000000189EE2F20-0x0000000189EE2FBC
		public IEnumerable<int> GetChildrenIdsByIndex(int index) => default; // 0x0000000189EE2D0C-0x0000000189EE2D8C
		public int GetChildIndexForId(int id) => default; // 0x0000000189EE2B24-0x0000000189EE2D0C
		internal int GetIndentationDepth(int id) => default; // 0x0000000189EE2E2C-0x0000000189EE2E70
		internal int GetIndentationDepthByIndex(int index) => default; // 0x0000000189EE2E00-0x0000000189EE2E2C
		internal virtual bool CanChangeExpandedState(int id) => default; // 0x0000000183D663A0-0x0000000183D663B0
		public bool IsExpanded(int id) => default; // 0x0000000189EE3318-0x0000000189EE337C
		public bool IsExpandedByIndex(int index) => default; // 0x0000000189EE3290-0x0000000189EE3318
		public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true /* Metadata: 0x01FB5EDA */) {} // 0x0000000189EE238C-0x0000000189EE29D0
		public void ExpandItem(int id, bool expandAllChildren, bool refresh = true /* Metadata: 0x01FB5EDB */) {} // 0x0000000189EE29D0-0x0000000189EE2B24
		public void CollapseItemByIndex(int index, bool collapseAllChildren) {} // 0x0000000189EE1A9C-0x0000000189EE1DE0
		public void CollapseItem(int id, bool collapseAllChildren) {} // 0x0000000189EE1DE0-0x0000000189EE1F08
		internal void RegenerateWrappers() {} // 0x0000000189EE3E2C-0x0000000189EE3EC0
		private void CreateWrappers(IEnumerable<int> treeViewItemIds, int depth, ref List<TreeViewItemWrapper> wrappers) {} // 0x0000000189EE1F08-0x0000000189EE2338
		private bool IsIndexValid(int index) => default; // 0x0000000189EE337C-0x0000000189EE33D8
		internal void RaiseItemParentChanged(int id, int newParentId) {} // 0x0000000189EE3B80-0x0000000189EE3B94
	}

	public abstract class CollectionViewController : IDisposable // TypeDefIndex: 43395
	{
		// Fields
		private BaseVerticalCollectionView m_View; // 0x10
		private IList m_ItemsSource; // 0x18
	
		// Properties
		public virtual IList itemsSource { get; set; } // 0x0000000181041090-0x00000001810410A0 0x0000000189EEAB7C-0x0000000189EEAC1C
		protected BaseVerticalCollectionView view { get; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Events
		public event Action itemsSourceChanged;
		public event Action<int, int> itemIndexChanged;
	
		// Constructors
		protected CollectionViewController() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected void SetItemsSourceWithoutNotify(IList source) {} // 0x00000001822C3A90-0x00000001822C3AA0
		public void SetView(BaseVerticalCollectionView collectionView) {} // 0x0000000189EEA8AC-0x0000000189EEA93C
		protected virtual void PrepareView() {} // 0x000000018350B670-0x000000018350B680
		public virtual void Dispose() {} // 0x0000000189EEA688-0x0000000189EEA6C0
		public virtual int GetItemsCount() => default; // 0x0000000189EEA720-0x0000000189EEA740
		internal virtual int GetItemsMinCount() => default; // 0x0000000189EEA740-0x0000000189EEA748
		public virtual int GetIndexForId(int id) => default; // 0x0000000183D66C70-0x0000000183D66C80
		public virtual int GetIdForIndex(int index) => default; // 0x0000000183D66C70-0x0000000183D66C80
		public virtual object GetItemForIndex(int index) => default; // 0x0000000189EEA6C0-0x0000000189EEA720
		internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) {} // 0x0000000189EEA82C-0x0000000189EEA864
		internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) {} // 0x0000000189EEA748-0x0000000189EEA804
		internal virtual void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index) {} // 0x0000000189EEA864-0x0000000189EEA89C
		internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem) {} // 0x0000000189EEA804-0x0000000189EEA82C
		protected abstract VisualElement MakeItem();
		protected abstract void BindItem(VisualElement element, int index);
		protected abstract void UnbindItem(VisualElement element, int index);
		protected abstract void DestroyItem(VisualElement element);
		protected void RaiseItemsSourceChanged() {} // 0x0000000189EEA89C-0x0000000189EEA8AC
		protected void RaiseItemIndexChanged(int srcIndex, int dstIndex) {} // 0x0000000189EE3B80-0x0000000189EE3B94
	}

	internal class DefaultMultiColumnTreeViewController<T> : MultiColumnTreeViewController // TypeDefIndex: 43396
	{
		// Fields
		private TreeDataController<T> m_TreeDataController;
	
		// Properties
		private TreeDataController<T> treeDataController { get => default; }
		public override IList itemsSource { get => default; set {} }
	
		// Constructors
		public DefaultMultiColumnTreeViewController() {} // Dummy constructor
		public DefaultMultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) {}
	
		// Methods
		public void SetRootItems(IList<TreeViewItemData<T>> items) {}
		public override object GetItemForIndex(int index) => default;
		public override int GetParentId(int id) => default;
		public override bool HasChildren(int id) => default;
		public override IEnumerable<int> GetChildrenIds(int id) => default;
		public override void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x01FB5EDC */, bool rebuildTree = true /* Metadata: 0x01FB5EDD */) {}
		private bool IsChildOf(int childId, int id) => default;
		public override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null) => default;
	}

	internal class DefaultTreeViewController<T> : TreeViewController // TypeDefIndex: 43397
	{
		// Fields
		private TreeDataController<T> m_TreeDataController;
	
		// Properties
		private TreeDataController<T> treeDataController { get => default; }
		public override IList itemsSource { get => default; set {} }
	
		// Constructors
		public DefaultTreeViewController() {}
	
		// Methods
		public void SetRootItems(IList<TreeViewItemData<T>> items) {}
		public override object GetItemForIndex(int index) => default;
		public override int GetParentId(int id) => default;
		public override bool HasChildren(int id) => default;
		public override IEnumerable<int> GetChildrenIds(int id) => default;
		public override void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x01FB5EDE */, bool rebuildTree = true /* Metadata: 0x01FB5EDF */) {}
		private bool IsChildOf(int childId, int id) => default;
		public override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null) => default;
	}

	public class ListViewController : BaseListViewController // TypeDefIndex: 43398
	{
		// Properties
		protected ListView listView { get => default; } // 0x0000000189EEEE34-0x0000000189EEEE70 
	
		// Constructors
		public ListViewController() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected override VisualElement MakeItem() => default; // 0x0000000189EEECEC-0x0000000189EEEDEC
		protected override void BindItem(VisualElement element, int index) {} // 0x0000000189EEEB30-0x0000000189EEECB4
		protected override void UnbindItem(VisualElement element, int index) {} // 0x0000000189EEEDEC-0x0000000189EEEE34
		protected override void DestroyItem(VisualElement element) {} // 0x0000000189EEECB4-0x0000000189EEECEC
	}

	public class MultiColumnListViewController : BaseListViewController // TypeDefIndex: 43399
	{
		// Fields
		private MultiColumnController m_ColumnController; // 0x48
	
		// Properties
		public MultiColumnController columnController { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		internal MultiColumnCollectionHeader header { get => default; } // 0x0000000189EEF30C-0x0000000189EEF31C 
	
		// Constructors
		public MultiColumnListViewController() {} // Dummy constructor
		public MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) {} // 0x0000000189EEF270-0x0000000189EEF30C
	
		// Methods
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) {} // 0x0000000189EEEFDC-0x0000000189EEF0BC
		protected override VisualElement MakeItem() => default; // 0x0000000189EEF0BC-0x0000000189EEF0DC
		protected override void BindItem(VisualElement element, int index) {} // 0x0000000189EEEE70-0x0000000189EEEEFC
		protected override void UnbindItem(VisualElement element, int index) {} // 0x0000000189EEF18C-0x0000000189EEF1AC
		protected override void DestroyItem(VisualElement element) {} // 0x0000000189EEEEFC-0x0000000189EEEF1C
		protected override void PrepareView() {} // 0x0000000189EEF0DC-0x0000000189EEF18C
		public override void Dispose() {} // 0x0000000189EEEF1C-0x0000000189EEEFDC
		private void UpdateReorderClassList() {} // 0x0000000189EEF1AC-0x0000000189EEF270
	}

	public abstract class MultiColumnTreeViewController : BaseTreeViewController // TypeDefIndex: 43400
	{
		// Fields
		private MultiColumnController m_ColumnController; // 0x58
	
		// Properties
		public MultiColumnController columnController { get; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 
		internal MultiColumnCollectionHeader header { get; } // 0x0000000189EEF5DC-0x0000000189EEF5EC 
	
		// Constructors
		protected MultiColumnTreeViewController() {} // Dummy constructor
		protected MultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) {} // 0x0000000189EEF520-0x0000000189EEF5DC
	
		// Methods
		internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) {} // 0x0000000189EEF408-0x0000000189EEF4B8
		protected override VisualElement MakeItem() => default; // 0x0000000189EEF4B8-0x0000000189EEF4D8
		protected override void BindItem(VisualElement element, int index) {} // 0x0000000189EEF31C-0x0000000189EEF3A8
		protected override void UnbindItem(VisualElement element, int index) {} // 0x0000000189EEF500-0x0000000189EEF520
		protected override void DestroyItem(VisualElement element) {} // 0x0000000189EEF3A8-0x0000000189EEF3C8
		protected override void PrepareView() {} // 0x0000000189EEF4D8-0x0000000189EEF500
		public override void Dispose() {} // 0x0000000189EEF3C8-0x0000000189EEF408
	}

	internal sealed class TreeDataController<T> // TypeDefIndex: 43403
	{
		// Fields
		private TreeData<T> m_TreeData;
		private Stack<IEnumerator<int>> m_IteratorStack;
	
		// Constructors
		public TreeDataController() {}
	
		// Methods
		public void SetRootItems(IList<TreeViewItemData<T>> rootItems) {}
		public T GetDataForId(int id) => default;
		public int GetParentId(int id) => default;
		public bool HasChildren(int id) => default;
		private static IEnumerable<int> GetItemIds(IEnumerable<TreeViewItemData<T>> items) => default;
		public IEnumerable<int> GetChildrenIds(int id) => default;
		public void Move(int id, int newParentId, int childIndex = -1 /* Metadata: 0x01FB5EE0 */) {}
		public bool IsChildOf(int childId, int id) => default;
		public IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null) => default;
	}

	public abstract class TreeViewController : BaseTreeViewController // TypeDefIndex: 43404
	{
		// Properties
		protected TreeView treeView { get; } // 0x0000000189EF2084-0x0000000189EF20C0 
	
		// Constructors
		protected TreeViewController() {} // 0x0000000189EF2038-0x0000000189EF2084
	
		// Methods
		protected override VisualElement MakeItem() => default; // 0x0000000189EF1EF0-0x0000000189EF1FF0
		protected override void BindItem(VisualElement element, int index) {} // 0x0000000189EF1D58-0x0000000189EF1EB8
		protected override void UnbindItem(VisualElement element, int index) {} // 0x0000000189EF1FF0-0x0000000189EF2038
		protected override void DestroyItem(VisualElement element) {} // 0x0000000189EF1EB8-0x0000000189EF1EF0
	}

	internal abstract class CollectionVirtualizationController // TypeDefIndex: 43405
	{
		// Fields
		protected readonly ScrollView m_ScrollView; // 0x10
	
		// Properties
		public abstract int firstVisibleIndex { get; protected set; }
		public abstract int visibleItemCount { get; }
		public abstract IEnumerable<ReusableCollectionItem> activeItems { get; }
	
		// Constructors
		protected CollectionVirtualizationController() {} // Dummy constructor
		protected CollectionVirtualizationController(ScrollView scrollView) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public abstract void Refresh(bool rebuild);
		public abstract void ScrollToItem(int id);
		public abstract void Resize(Vector2 size);
		public abstract void OnScroll(Vector2 offset);
		public abstract int GetIndexFromPosition(Vector2 position);
		public abstract float GetExpectedItemHeight(int index);
		public abstract float GetExpectedContentHeight();
		public abstract void OnFocus(VisualElement leafTarget);
		public abstract void OnBlur(VisualElement willFocus);
		public abstract void UpdateBackground();
		internal abstract void StartDragItem(ReusableCollectionItem item);
		internal abstract void EndDrag(int dropIndex);
	}

	internal class DynamicHeightVirtualizationController<T> : VerticalVirtualizationController<T> // TypeDefIndex: 43409
		where T : ReusableCollectionItem, new()
	{
		// Fields
		private int m_HighestCachedIndex;
		private readonly Dictionary<int, float> m_ItemHeightCache;
		private readonly Dictionary<int, ContentHeightCacheInfo> m_ContentHeightCache;
		private readonly HashSet<int> m_WaitingCache;
		private int m_ForcedFirstVisibleItem;
		private int m_ForcedLastVisibleItem;
		private bool m_StickToBottom;
		private VirtualizationChange m_LastChange;
		private ScrollDirection m_ScrollDirection;
		private Vector2 m_DelayedScrollOffset;
		private float m_AccumulatedHeight;
		private float m_MinimumItemHeight;
		private Action m_FillCallback;
		private Action m_ScrollCallback;
		private Action m_ScrollResetCallback;
		private Action<ReusableCollectionItem> m_GeometryChangedCallback;
		private IVisualElementScheduledItem m_ScheduledItem;
		private IVisualElementScheduledItem m_ScrollScheduledItem;
		private IVisualElementScheduledItem m_ScrollResetScheduledItem;
		private Predicate<int> m_IndexOutOfBoundsPredicate;
	
		// Properties
		private float defaultExpectedHeight { get => default; }
		private float contentPadding { get => default; set {} }
		private float contentHeight { get => default; set {} }
		private int anchoredIndex { get => default; set {} }
		private float anchorOffset { get => default; set {} }
		private float viewportMaxOffset { get => default; }
		protected override bool alwaysRebindOnRefresh { get => default; }
	
		// Nested types
		[IsReadOnly]
		private struct ContentHeightCacheInfo // TypeDefIndex: 43406
		{
			// Fields
			public readonly float sum;
			public readonly int count;
	
			// Constructors
			public ContentHeightCacheInfo(float sum, int count) {
				this.sum = default;
				this.count = default;
			}
		}
	
		private enum VirtualizationChange // TypeDefIndex: 43407
		{
			None = 0,
			Resize = 1,
			Scroll = 2,
			ForcedScroll = 3
		}
	
		private enum ScrollDirection // TypeDefIndex: 43408
		{
			Idle = 0,
			Up = 1,
			Down = 2
		}
	
		// Constructors
		public DynamicHeightVirtualizationController() {} // Dummy constructor
		public DynamicHeightVirtualizationController(BaseVerticalCollectionView collectionView) {}
	
		// Methods
		public override void Refresh(bool rebuild) {}
		public override void ScrollToItem(int index) {}
		public override void Resize(Vector2 size) {}
		public override void OnScroll(Vector2 scrollOffset) {}
		private void OnScrollUpdate() {}
		private void CycleItems(int firstIndex) {}
		private bool NeedsFill() => default;
		private void Fill() {}
		private void UpdateScrollViewContainer(float previousHeight, float newHeight) {}
		private void ApplyScrollViewUpdate(bool dimensionsOnly = false /* Metadata: 0x01FB5EE1 */) {}
		private void UpdateAnchor() {}
		private void ScheduleFill() {}
		private void ScheduleScroll() {}
		private void ScheduleScrollDirectionReset() {}
		private void ResetScroll() {}
		public override int GetIndexFromPosition(Vector2 position) => default;
		public override float GetExpectedItemHeight(int index) => default;
		private int GetFirstVisibleItem(float offset) => default;
		public override float GetExpectedContentHeight() => default;
		private float GetContentHeightForIndex(int lastIndex) => default;
		private ContentHeightCacheInfo GetCachedContentHeight(int index) => default;
		private void RegisterItemHeight(int index, float height) {}
		private void UnregisterItemHeight(int index) {}
		private void CleanItemHeightCache() {}
		private void OnRecycledItemGeometryChanged(ReusableCollectionItem item) {}
		private bool UpdateRegisteredHeight(ReusableCollectionItem item) => default;
		internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1 /* Metadata: 0x01FB5EE2 */, int scrollViewIndex = -1 /* Metadata: 0x01FB5EE3 */) => default;
		internal override void ReleaseItem(int activeItemsIndex) {}
		internal override void StartDragItem(ReusableCollectionItem item) {}
		internal override void EndDrag(int dropIndex) {}
		private void HideItem(int activeItemsIndex) {}
		private void MarkWaitingForLayout(T item) {}
		private bool IsIndexOutOfBounds(int i) => default;
	}

	internal class FixedHeightVirtualizationController<T> : VerticalVirtualizationController<T> // TypeDefIndex: 43410
		where T : ReusableCollectionItem, new()
	{
		// Properties
		private float resolvedItemHeight { get => default; }
	
		// Constructors
		public FixedHeightVirtualizationController() {} // Dummy constructor
		public FixedHeightVirtualizationController(BaseVerticalCollectionView collectionView) {}
	
		// Methods
		protected override bool VisibleItemPredicate(T i) => default;
		public override int GetIndexFromPosition(Vector2 position) => default;
		public override float GetExpectedItemHeight(int index) => default;
		public override float GetExpectedContentHeight() => default;
		public override void ScrollToItem(int index) {}
		public override void Resize(Vector2 size) {}
		public override void OnScroll(Vector2 scrollOffset) {}
		internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1 /* Metadata: 0x01FB5EEB */, int scrollViewIndex = -1 /* Metadata: 0x01FB5EEC */) => default;
		internal override void EndDrag(int dropIndex) {}
	}

	internal class ReusableCollectionItem // TypeDefIndex: 43411
	{
		// Fields
		protected EventCallback<GeometryChangedEvent> m_GeometryChangedEventCallback; // 0x38
	
		// Properties
		public virtual VisualElement rootElement { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public VisualElement bindableElement { get; protected set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public ValueAnimation<StyleValues> animator { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public int index { get; set; } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public int id { get; set; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		internal bool isDragGhost { get; private set; } // 0x0000000183D4ED50-0x0000000183D4ED60 0x0000000183D4ED60-0x0000000183D4ED70
	
		// Events
		public event Action<ReusableCollectionItem> onGeometryChanged;
		internal event Action<ReusableCollectionItem> onDestroy;
	
		// Constructors
		public ReusableCollectionItem() {} // 0x0000000189EEFAD8-0x0000000189EEFB5C
	
		// Methods
		public virtual void Init(VisualElement item) {} // 0x000000018426FEE0-0x000000018426FEF0
		public virtual void PreAttachElement() {} // 0x0000000189EEF7F4-0x0000000189EEF8A0
		public virtual void DetachElement() {} // 0x0000000189EEF6E8-0x0000000189EEF7DC
		public virtual void DestroyElement() {} // 0x0000000189EEF6D0-0x0000000189EEF6E8
		public virtual void SetSelected(bool selected) {} // 0x0000000189EEF9D4-0x0000000189EEFAD8
		public virtual void SetDragGhost(bool dragGhost) {} // 0x0000000189EEF8A0-0x0000000189EEF9D4
		protected void OnGeometryChanged(GeometryChangedEvent evt) {} // 0x0000000189EEF7DC-0x0000000189EEF7F4
	}

	internal class ReusableListViewItem : ReusableCollectionItem // TypeDefIndex: 43412
	{
		// Fields
		private VisualElement m_Container; // 0x48
		private VisualElement m_DragHandle; // 0x50
		private VisualElement m_ItemContainer; // 0x58
	
		// Properties
		public override VisualElement rootElement { get => default; } // 0x0000000189EF03C0-0x0000000189EF03D0 
	
		// Constructors
		public ReusableListViewItem() {} // 0x0000000189EF03B8-0x0000000189EF03C0
	
		// Methods
		public void Init(VisualElement item, bool usesAnimatedDragger) {} // 0x0000000189EEFE04-0x0000000189EEFEC8
		protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger) {} // 0x0000000189EF00D8-0x0000000189EF03B8
		public void UpdateDragHandle(bool needsDragHandle) {} // 0x0000000189EEFFC4-0x0000000189EF00D8
		public override void PreAttachElement() {} // 0x0000000189EEFEC8-0x0000000189EEFF40
		public override void DetachElement() {} // 0x0000000189EEFD8C-0x0000000189EEFE04
		public override void SetDragGhost(bool dragGhost) {} // 0x0000000189EEFF40-0x0000000189EEFFC4
	}

	internal class ReusableMultiColumnListViewItem : ReusableListViewItem // TypeDefIndex: 43413
	{
		// Properties
		public override VisualElement rootElement { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public ReusableMultiColumnListViewItem() {} // 0x0000000189EF03B8-0x0000000189EF03C0
	
		// Methods
		public override void Init(VisualElement item) {} // 0x000000018350B670-0x000000018350B680
		public void Init(VisualElement container, Columns columns, bool usesAnimatedDrag) {} // 0x0000000189EF03D0-0x0000000189EF05F0
	}

	internal class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem // TypeDefIndex: 43414
	{
		// Properties
		public override VisualElement rootElement { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
	
		// Constructors
		public ReusableMultiColumnTreeViewItem() {} // 0x0000000189EF07F8-0x0000000189EF0800
	
		// Methods
		public override void Init(VisualElement item) {} // 0x000000018350B670-0x000000018350B680
		public void Init(VisualElement container, Columns columns) {} // 0x0000000189EF05F0-0x0000000189EF07F8
	}

	internal class ReusableTreeViewItem : ReusableCollectionItem // TypeDefIndex: 43415
	{
		// Fields
		private Toggle m_Toggle; // 0x48
		private VisualElement m_Container; // 0x50
		private VisualElement m_IndentElement; // 0x58
		private VisualElement m_BindableContainer; // 0x60
		private VisualElement m_Checkmark; // 0x68
		private int m_Depth; // 0x80
		private float m_IndentWidth; // 0x84
		private EventCallback<PointerUpEvent> m_PointerUpCallback; // 0x88
		private EventCallback<ChangeEvent<bool>> m_ToggleValueChangedCallback; // 0x90
		private EventCallback<GeometryChangedEvent> m_ToggleGeometryChangedCallback; // 0x98
	
		// Properties
		public override VisualElement rootElement { get => default; } // 0x0000000189EF144C-0x0000000189EF145C 
	
		// Events
		public event Action<PointerUpEvent> onPointerUp;
		public event Action<ChangeEvent<bool>> onToggleValueChanged;
	
		// Constructors
		public ReusableTreeViewItem() {} // 0x0000000189EF11FC-0x0000000189EF1334
	
		// Methods
		public override void Init(VisualElement item) {} // 0x0000000189EF0DA8-0x0000000189EF0E80
		protected void InitExpandHierarchy(VisualElement root, VisualElement item) {} // 0x0000000189EF0994-0x0000000189EF0DA8
		public override void PreAttachElement() {} // 0x0000000189EF0F7C-0x0000000189EF10F8
		public override void DetachElement() {} // 0x0000000189EF0800-0x0000000189EF097C
		public void Indent(int depth) {} // 0x0000000189EF097C-0x0000000189EF0994
		public void SetExpandedWithoutNotify(bool expanded) {} // 0x0000000189EF10F8-0x0000000189EF1110
		public void SetToggleVisibility(bool visible) {} // 0x0000000189EF1110-0x0000000189EF112C
		private void OnToggleGeometryChanged(GeometryChangedEvent evt) {} // 0x0000000189EF0E94-0x0000000189EF0F68
		private void UpdateIndentLayout() {} // 0x0000000189EF112C-0x0000000189EF11FC
		private void OnPointerUp(PointerUpEvent evt) {} // 0x0000000189EF0E80-0x0000000189EF0E94
		private void OnToggleValueChanged(ChangeEvent<bool> evt) {} // 0x0000000189EF0F68-0x0000000189EF0F7C
	}

	internal abstract class VerticalVirtualizationController<T> : CollectionVirtualizationController // TypeDefIndex: 43417
		where T : ReusableCollectionItem, new()
	{
		// Fields
		private readonly ObjectPool<T> m_Pool;
		protected BaseVerticalCollectionView m_CollectionView;
		protected List<T> m_ActiveItems;
		protected T m_DraggedItem;
		private int m_LastFocusedElementIndex;
		private List<int> m_LastFocusedElementTreeChildIndexes;
		protected readonly Func<T, bool> m_VisibleItemPredicateDelegate;
		protected List<T> m_ScrollInsertionList;
		private VisualElement m_EmptyRows;
	
		// Properties
		public override IEnumerable<ReusableCollectionItem> activeItems { get; }
		internal int itemsCount { get; }
		internal T firstVisibleItem { get; }
		internal T lastVisibleItem { get; }
		public override int visibleItemCount { get; }
		protected SerializedVirtualizationData serializedData { get; }
		public override int firstVisibleIndex { get; protected set; }
		protected float lastHeight { get; }
		protected virtual bool alwaysRebindOnRefresh { get; }
	
		// Constructors
		protected VerticalVirtualizationController() {} // Dummy constructor
		protected VerticalVirtualizationController(BaseVerticalCollectionView collectionView) {}
	
		// Methods
		protected virtual bool VisibleItemPredicate(T i) => default;
		public override void Refresh(bool rebuild) {}
		protected void Setup(T recycledItem, int newIndex) {}
		public override void OnFocus(VisualElement leafTarget) {}
		public override void OnBlur(VisualElement willFocus) {}
		private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex) {}
		public override void UpdateBackground() {}
		internal override void StartDragItem(ReusableCollectionItem item) {}
		internal override void EndDrag(int dropIndex) {}
		internal virtual T GetOrMakeItemAtIndex(int activeItemIndex = -1 /* Metadata: 0x01FB5EED */, int scrollViewIndex = -1 /* Metadata: 0x01FB5EEE */) => default;
		internal virtual void ReleaseItem(int activeItemsIndex) {}
		private void OnDestroyItem(ReusableCollectionItem item) {}
		protected int GetDraggedIndex() => default;
	}

	public abstract class BaseBoolField : BaseField<bool> // TypeDefIndex: 43418
	{
		// Fields
		protected UnityEngine.UIElements.Label m_Label; // 0x418
		protected readonly VisualElement m_CheckMark; // 0x420
		internal Clickable m_Clickable; // 0x428
		private string m_OriginalText; // 0x430
	
		// Properties
		public string text { get; set; } // 0x0000000189EDF79C-0x0000000189EDF7BC 0x0000000189EDF7BC-0x0000000189EDF844
	
		// Constructors
		protected BaseBoolField() {} // Dummy constructor
		public BaseBoolField(string label) {} // 0x0000000189EDF514-0x0000000189EDF79C
	
		// Methods
		private void OnNavigationSubmit(NavigationSubmitEvent evt) {} // 0x0000000189EDF2A4-0x0000000189EDF2D0
		private void OnKeyDown(KeyDownEvent evt) {} // 0x0000000189EDF21C-0x0000000189EDF2A4
		protected virtual void InitLabel() {} // 0x0000000189EDF008-0x0000000189EDF0A4
		public override void SetValueWithoutNotify(bool newValue) {} // 0x0000000189EDF2D0-0x0000000189EDF384
		private void OnClickEvent(EventBase evt) {} // 0x0000000189EDF0A4-0x0000000189EDF21C
		protected virtual void ToggleValue() {} // 0x0000000189EDF384-0x0000000189EDF3B4
		protected override void UpdateMixedValueContent() {} // 0x0000000189EDF3B4-0x0000000189EDF514
	}

	public abstract class BaseField<TValueType> : BindableElement, INotifyValueChanged<TValueType> // TypeDefIndex: 43420
	{
		// Fields
		public static readonly string ussClassName;
		public static readonly string labelUssClassName;
		public static readonly string inputUssClassName;
		public static readonly string noLabelVariantUssClassName;
		public static readonly string labelDraggerVariantUssClassName;
		public static readonly string mixedValueLabelUssClassName;
		public static readonly string alignedFieldUssClassName;
		private static readonly string inspectorFieldUssClassName;
		protected internal static readonly string mixedValueString;
		protected internal static readonly PropertyName serializedPropertyCopyName;
		private static CustomStyleProperty<float> s_LabelWidthRatioProperty;
		private static CustomStyleProperty<float> s_LabelExtraPaddingProperty;
		private static CustomStyleProperty<float> s_LabelBaseMinWidthProperty;
		private float m_LabelWidthRatio;
		private float m_LabelExtraPadding;
		private float m_LabelBaseMinWidth;
		private VisualElement m_VisualInput;
		[SerializeField]
		private TValueType m_Value;
		private bool m_ShowMixedValue;
		private UnityEngine.UIElements.Label m_MixedValueLabel;
		private VisualElement m_CachedInspectorElement;
		private int m_CachedListAndFoldoutDepth;
	
		// Properties
		internal VisualElement visualInput { get; set; }
		protected TValueType rawValue { get; set; }
		public virtual TValueType value { get; set; }
		public UnityEngine.UIElements.Label labelElement { get; private set; }
		public string label { get; set; }
		public bool showMixedValue { get; set; }
		protected UnityEngine.UIElements.Label mixedValueLabel { get; }
	
		// Nested types
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 43419
		{
			// Fields
			private UxmlStringAttributeDescription m_Label;
	
			// Constructors
			public UxmlTraits() {}
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {}
			internal static List<string> ParseChoiceList(string choicesFromBag) => default;
		}
	
		// Constructors
		protected BaseField() {} // Dummy constructor
		internal BaseField(string label) {}
		protected BaseField(string label, VisualElement visualInput) {}
		static BaseField() {}
	
		// Methods
		private void OnAttachToPanel(AttachToPanelEvent e) {}
		private void OnCustomStyleResolved(CustomStyleResolvedEvent evt) {}
		private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e) {}
		private void AlignLabel() {}
		protected virtual void UpdateMixedValueContent() {}
		public virtual void SetValueWithoutNotify(TValueType newValue) {}
		internal override void OnViewDataReady() {}
		internal override Rect GetTooltipRect() => default;
	}

	public class BaseFieldTraits<TValueType, TValueUxmlAttributeType> : BaseField<TValueType> // TypeDefIndex: 43421
		where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
	{
		// Fields
		private TValueUxmlAttributeType m_Value;
	
		// Constructors
		public BaseFieldTraits() {}
	
		// Methods
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {}
	}

	public enum ListViewReorderMode // TypeDefIndex: 43422
	{
		Simple = 0,
		Animated = 1
	}

	public abstract class BaseListView : BaseVerticalCollectionView // TypeDefIndex: 43424
	{
		// Fields
		private static readonly string k_SizeFieldLabel; // 0x00
		private bool m_ShowBoundCollectionSize; // 0x4A8
		private bool m_ShowFoldoutHeader; // 0x4A9
		private string m_HeaderTitle; // 0x4B0
		private UnityEngine.UIElements.Label m_ListViewLabel; // 0x4D0
		protected UnityEngine.UIElements.Foldout m_Foldout; // 0x4D8
		protected TextField m_ArraySizeField; // 0x4E0
		private bool m_IsOverMultiEditLimit; // 0x4E8
		private VisualElement m_Footer; // 0x4F0
		private UnityEngine.UIElements.Button m_AddButton; // 0x4F8
		private UnityEngine.UIElements.Button m_RemoveButton; // 0x500
		private Action<IEnumerable<int>> m_ItemAddedCallback; // 0x508
		private Action<IEnumerable<int>> m_ItemRemovedCallback; // 0x510
		private Action m_ItemsSourceSizeChangedCallback; // 0x518
		private ListViewReorderMode m_ReorderMode; // 0x520
		public static readonly string ussClassName; // 0x08
		public static readonly string itemUssClassName; // 0x10
		public static readonly string emptyLabelUssClassName; // 0x18
		public static readonly string overMaxMultiEditLimitClassName; // 0x20
		public static readonly string reorderableUssClassName; // 0x28
		public static readonly string reorderableItemUssClassName; // 0x30
		public static readonly string reorderableItemContainerUssClassName; // 0x38
		public static readonly string reorderableItemHandleUssClassName; // 0x40
		public static readonly string reorderableItemHandleBarUssClassName; // 0x48
		public static readonly string footerUssClassName; // 0x50
		public static readonly string foldoutHeaderUssClassName; // 0x58
		public static readonly string arraySizeFieldUssClassName; // 0x60
		public static readonly string arraySizeFieldWithHeaderUssClassName; // 0x68
		public static readonly string arraySizeFieldWithFooterUssClassName; // 0x70
		public static readonly string listViewWithHeaderUssClassName; // 0x78
		public static readonly string listViewWithFooterUssClassName; // 0x80
		public static readonly string scrollViewWithFooterUssClassName; // 0x88
		public static readonly string footerAddButtonName; // 0x90
		public static readonly string footerRemoveButtonName; // 0x98
		private string m_MaxMultiEditStr; // 0x530
		private static readonly string k_EmptyListStr; // 0xA0
	
		// Properties
		public bool showBoundCollectionSize { get; set; } // 0x0000000183D88E80-0x0000000183D88E90 0x0000000189EE1820-0x0000000189EE1838
		public bool showFoldoutHeader { get; set; } // 0x0000000183D88E90-0x0000000183D88EA0 0x0000000189EE1838-0x0000000189EE1A9C
		public string headerTitle { get; set; } // 0x0000000189EE178C-0x0000000189EE17CC
		public bool showAddRemoveFooter { get; set; } // 0x0000000189EE16A8-0x0000000189EE16B4 0x0000000189EE1818-0x0000000189EE1820
		internal VisualElement footer { get; } // 0x0000000183D6C880-0x0000000183D6C890 
		public new BaseListViewController viewController { get; } // 0x0000000189EE16B4-0x0000000189EE16F4 
		public ListViewReorderMode reorderMode { get; set; } // 0x0000000183D88E70-0x0000000183D88E80 0x0000000189EE17CC-0x0000000189EE1818
	
		// Events
		internal event Action reorderModeChanged;
	
		// Nested types
		public class UxmlTraits : BaseVerticalCollectionView.UxmlTraits // TypeDefIndex: 43423
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader; // 0xB0
			private readonly UxmlStringAttributeDescription m_HeaderTitle; // 0xB8
			private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter; // 0xC0
			private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode; // 0xC8
			private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize; // 0xD0
	
			// Constructors
			protected UxmlTraits() {} // 0x0000000189EF2E94-0x0000000189EF3124
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189EF27A0-0x0000000189EF2958
		}
	
		// Constructors
		public BaseListView() {} // 0x0000000189EE1588-0x0000000189EE1610
		static BaseListView() {} // 0x0000000189EE0EA0-0x0000000189EE1588
	
		// Methods
		internal void SetupArraySizeField() {} // 0x0000000189EE0810-0x0000000189EE0B64
		private void EnableFooter(bool enabled) {} // 0x0000000189EDF98C-0x0000000189EDFDA4
		private void AddItems(int itemCount) {} // 0x0000000189EDF844-0x0000000189EDF870
		private void OnArraySizeFieldChanged(ChangeEvent<string> evt) {} // 0x0000000189EE01C0-0x0000000189EE03A8
		internal void UpdateArraySizeField() {} // 0x0000000189EE0BAC-0x0000000189EE0C6C
		internal void UpdateListViewLabel() {} // 0x0000000189EE0C6C-0x0000000189EE0EA0
		private void OnAddClicked() {} // 0x0000000189EE00A4-0x0000000189EE01C0
		private void OnRemoveClicked() {} // 0x0000000189EE044C-0x0000000189EE0590
		private protected override void CreateVirtualizationController() {} // 0x0000000189EDF950-0x0000000189EDF98C
		public override void SetViewController(CollectionViewController controller) {} // 0x0000000189EE05BC-0x0000000189EE0810
		private void OnItemAdded(IEnumerable<int> indices) {} // 0x0000000189EE03A8-0x0000000189EE03C0
		private void OnItemsRemoved(IEnumerable<int> indices) {} // 0x0000000189EE03C0-0x0000000189EE03D8
		private void OnItemsSourceSizeChanged() {} // 0x0000000189EE03D8-0x0000000189EE044C
		internal override ListViewDragger CreateDragger() => default; // 0x0000000189EDF8D0-0x0000000189EDF950
		internal override ICollectionDragAndDropController CreateDragAndDropController() => default; // 0x0000000189EDF870-0x0000000189EDF8D0
		private protected override void PostRefresh() {} // 0x0000000189EE0590-0x0000000189EE05BC
		private protected override bool HandleItemNavigation(bool moveIn, bool altPressed) => default; // 0x0000000189EDFDA4-0x0000000189EE00A4
	}

	public enum SliderDirection // TypeDefIndex: 43425
	{
		Horizontal = 0,
		Vertical = 1
	}

	public abstract class BaseSlider<TValueType> : BaseField<TValueType> // TypeDefIndex: 43427
		where TValueType : IComparable<TValueType>
	{
		// Fields
		[SerializeField]
		private TValueType m_LowValue;
		[SerializeField]
		private TValueType m_HighValue;
		private float m_PageSize;
		private bool m_ShowInputField;
		private Rect m_DragElementStartPos;
		private SliderDirection m_Direction;
		private bool m_Inverted;
		public static readonly string ussClassName;
		public static readonly string labelUssClassName;
		public static readonly string inputUssClassName;
		public static readonly string horizontalVariantUssClassName;
		public static readonly string verticalVariantUssClassName;
		public static readonly string dragContainerUssClassName;
		public static readonly string trackerUssClassName;
		public static readonly string draggerUssClassName;
		public static readonly string draggerBorderUssClassName;
		public static readonly string textFieldClassName;
	
		// Properties
		internal VisualElement dragContainer { get; private set; }
		internal VisualElement dragElement { get; private set; }
		internal VisualElement dragBorderElement { get; private set; }
		internal TextField inputTextField { get; private set; }
		public TValueType lowValue { get; set; }
		public TValueType highValue { get; set; }
		public virtual float pageSize { get; set; }
		public virtual bool showInputField { get; set; }
		internal bool clamped { get; set; }
		internal ClampedDragger<TValueType> clampedDragger { get; private set; }
		public override TValueType value { get; set; }
		public SliderDirection direction { get; set; }
		public bool inverted { get; set; }
	
		// Nested types
		internal enum SliderKey // TypeDefIndex: 43426
		{
			None = 0,
			Lowest = 1,
			LowerPage = 2,
			Lower = 3,
			Higher = 4,
			HigherPage = 5,
			Highest = 6
		}
	
		// Constructors
		protected BaseSlider() {} // Dummy constructor
		internal BaseSlider(string label, TValueType start, TValueType end, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x01FB5EF3 */, float pageSize = 0f /* Metadata: 0x01FB5EF4 */) {}
		static BaseSlider() {}
	
		// Methods
		internal void SetHighValueWithoutNotify(TValueType newHighValue) {}
		private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound) => default;
		private TValueType GetClampedValue(TValueType newValue) => default;
		public override void SetValueWithoutNotify(TValueType newValue) {}
		protected static float GetClosestPowerOfTen(float positiveNumber) => default;
		protected static float RoundToMultipleOf(float value, float roundingValue) => default;
		private void ClampValue() {}
		internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant);
		internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue);
		internal abstract TValueType ParseStringToValue(string stringValue);
		internal abstract void ComputeValueFromKey(SliderKey sliderKey, bool isShift);
		private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant) => default;
		private void SetSliderValueFromDrag() {}
		private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos) {}
		private void SetSliderValueFromClick() {}
		private void OnKeyDown(KeyDownEvent evt) {}
		internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) {}
		public void AdjustDragElement(float factor) {}
		private void UpdateDragElementPosition(GeometryChangedEvent evt) {}
		internal override void OnViewDataReady() {}
		private bool SameValues(float a, float b, float epsilon) => default;
		private void UpdateDragElementPosition() {}
		protected override void ExecuteDefaultAction(EventBase evt) {}
		private void UpdateTextFieldVisibility() {}
		private void UpdateTextFieldValue() {}
		private void OnTextFieldFocusOut(FocusOutEvent evt) {}
		private void OnTextFieldValueChange(ChangeEvent<string> evt) {}
		protected override void UpdateMixedValueContent() {}
	}

	public abstract class BaseTreeView : BaseVerticalCollectionView // TypeDefIndex: 43429
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string itemUssClassName; // 0x08
		public static readonly string itemToggleUssClassName; // 0x10
		public static readonly string itemIndentsContainerUssClassName; // 0x18
		public static readonly string itemIndentUssClassName; // 0x20
		public static readonly string itemContentContainerUssClassName; // 0x28
		private bool m_AutoExpand; // 0x4A8
		[SerializeField]
		private List<int> m_ExpandedItemIds; // 0x4B0
	
		// Properties
		public new IList itemsSource { get; } // 0x0000000189EE4EC0-0x0000000189EE4EE8 
		public new BaseTreeViewController viewController { get; } // 0x0000000189EE4EE8-0x0000000189EE4F28 
		public bool autoExpand { get; set; } // 0x0000000183D88E80-0x0000000183D88E90 0x0000000189EE4F28-0x0000000189EE4F5C
		internal List<int> expandedItemIds { get; set; } // 0x0000000183D57330-0x0000000183D57340 0x00000001858B4014-0x00000001858B4028
	
		// Nested types
		public class UxmlTraits : BaseVerticalCollectionView.UxmlTraits // TypeDefIndex: 43428
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_AutoExpand; // 0xB0
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189EF3608-0x0000000189EF36AC
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189EF2A5C-0x0000000189EF2B2C
		}
	
		// Constructors
		public BaseTreeView() {} // 0x0000000189EE4EB0-0x0000000189EE4EC0
		public BaseTreeView(int itemHeight) {} // 0x0000000189EE4D68-0x0000000189EE4EB0
		static BaseTreeView() {} // 0x0000000189EE4B64-0x0000000189EE4D68
	
		// Methods
		private protected override void CreateVirtualizationController() {} // 0x0000000189EE42B0-0x0000000189EE42EC
		public override void SetViewController(CollectionViewController controller) {} // 0x0000000189EE4A34-0x0000000189EE4B58
		private new void OnItemIndexChanged(int srcIndex, int dstIndex) {} // 0x0000000189EE484C-0x0000000189EE4854
		internal override ICollectionDragAndDropController CreateDragAndDropController() => default; // 0x0000000189EE4250-0x0000000189EE42B0
		internal override void OnViewDataReady() {} // 0x0000000189EE488C-0x0000000189EE48DC
		private protected override bool HandleItemNavigation(bool moveIn, bool altPressed) => default; // 0x0000000189EE44A4-0x0000000189EE47F4
		public void SetSelectionById(int id) {} // 0x0000000189EE48E8-0x0000000189EE495C
		public void SetSelectionById(IEnumerable<int> ids) {} // 0x0000000189EE48DC-0x0000000189EE48E8
		internal void SetSelectionInternalById(IEnumerable<int> ids, bool sendNotification) {} // 0x0000000189EE495C-0x0000000189EE4A34
		private int GetItemIndex(int id, bool expand = false /* Metadata: 0x01FB5EFF */) => default; // 0x0000000189EE43B8-0x0000000189EE44A4
		public bool IsExpanded(int id) => default; // 0x0000000189EE4820-0x0000000189EE484C
		public void CollapseItem(int id, bool collapseAllChildren = false /* Metadata: 0x01FB5F00 */) {} // 0x0000000189EE41FC-0x0000000189EE4250
		public void ExpandItem(int id, bool expandAllChildren = false /* Metadata: 0x01FB5F01 */) {} // 0x0000000189EE4370-0x0000000189EE43B8
		private void OnTreeViewPointerUp(PointerUpEvent evt) {} // 0x0000000189EE4854-0x0000000189EE488C
		private bool IsExpandedByIndex(int index) => default; // 0x0000000189EE47F4-0x0000000189EE4820
		private void CollapseItemByIndex(int index, bool collapseAll) {} // 0x0000000189EE417C-0x0000000189EE41FC
		private void ExpandItemByIndex(int index, bool expandAll) {} // 0x0000000189EE42EC-0x0000000189EE4370
	}

	public enum AlternatingRowBackground // TypeDefIndex: 43430
	{
		None = 0,
		ContentOnly = 1,
		All = 2
	}

	public enum CollectionVirtualizationMethod // TypeDefIndex: 43431
	{
		FixedHeight = 0,
		DynamicHeight = 1
	}

	[Serializable]
	internal class SerializedVirtualizationData // TypeDefIndex: 43432
	{
		// Fields
		public Vector2 scrollOffset; // 0x10
		public int firstVisibleIndex; // 0x18
		public float contentPadding; // 0x1C
		public float contentHeight; // 0x20
		public int anchoredItemIndex; // 0x24
		public float anchorOffset; // 0x28
	
		// Constructors
		public SerializedVirtualizationData() {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver // TypeDefIndex: 43439
	{
		// Fields
		private static readonly ProfilerMarker k_RefreshMarker; // 0x00
		private static readonly ProfilerMarker k_RebuildMarker; // 0x08
		private SelectionType m_SelectionType; // 0x420
		private static readonly List<ReusableCollectionItem> k_EmptyItems; // 0x10
		private bool m_HorizontalScrollingEnabled; // 0x424
		[SerializeField]
		private AlternatingRowBackground m_ShowAlternatingRowBackgrounds; // 0x428
		internal static readonly int s_DefaultItemHeight; // 0x18
		internal float m_FixedItemHeight; // 0x42C
		internal bool m_ItemHeightIsInline; // 0x430
		private CollectionVirtualizationMethod m_VirtualizationMethod; // 0x434
		private readonly ScrollView m_ScrollView; // 0x438
		private CollectionViewController m_ViewController; // 0x440
		private CollectionVirtualizationController m_VirtualizationController; // 0x448
		private KeyboardNavigationManipulator m_NavigationManipulator; // 0x450
		[SerializeField]
		internal SerializedVirtualizationData serializedVirtualizationData; // 0x458
		[SerializeField]
		private readonly List<int> m_SelectedIds; // 0x460
		private readonly Selection m_Selection; // 0x468
		private float m_LastHeight; // 0x470
		private bool m_IsRangeSelectionDirectionUp; // 0x474
		private ListViewDragger m_Dragger; // 0x478
		internal static CustomStyleProperty<int> s_ItemHeightProperty; // 0x20
		private Action<int, int> m_ItemIndexChangedCallback; // 0x480
		private Action m_ItemsSourceChangedCallback; // 0x488
		internal IVisualElementScheduledItem m_RebuildScheduled; // 0x490
		public static readonly string ussClassName; // 0x28
		public static readonly string borderUssClassName; // 0x30
		public static readonly string itemUssClassName; // 0x38
		public static readonly string dragHoverBarUssClassName; // 0x40
		public static readonly string dragHoverMarkerUssClassName; // 0x48
		public static readonly string itemDragHoverUssClassName; // 0x50
		public static readonly string itemSelectedVariantUssClassName; // 0x58
		public static readonly string itemAlternativeBackgroundUssClassName; // 0x60
		public static readonly string listScrollViewUssClassName; // 0x68
		internal static readonly string backgroundFillUssClassName; // 0x70
		private Vector3 m_TouchDownPosition; // 0x498
	
		// Properties
		public IList itemsSource { get; set; } // 0x0000000189EE9A00-0x0000000189EE9A24 0x0000000189EE9CF4-0x0000000189EE9D24
		public override VisualElement contentContainer { get; } // 0x0000000181002730-0x0000000181002740 
		public SelectionType selectionType { get; set; } // 0x0000000183D88EC0-0x0000000183D88ED0 0x0000000189EE9D88-0x0000000189EE9DF0
		public IEnumerable<object> selectedItems { get; } // 0x0000000189EE9B1C-0x0000000189EE9B8C 
		public int selectedIndex { get; set; } // 0x0000000189EE9AB4-0x0000000189EE9AFC 0x0000000189EE77FC-0x0000000189EE7804
		public IEnumerable<int> selectedIndices { get; } // 0x0000000189EE9AFC-0x0000000189EE9B1C 
		internal IEnumerable<int> selectedIds { get; } // 0x0000000189EE9A94-0x0000000189EE9AB4 
		internal IEnumerable<ReusableCollectionItem> activeItems { get; } // 0x0000000189EE999C-0x0000000189EE9A00 
		internal ScrollView scrollView { get; } // 0x0000000183D55F00-0x0000000183D55F10 
		internal ListViewDragger dragger { get; } // 0x0000000183D57420-0x0000000183D57430 
		internal CollectionVirtualizationController virtualizationController { get; } // 0x0000000189EE9B8C-0x0000000189EE9B94 
		public CollectionViewController viewController { get; } // 0x0000000183D55F40-0x0000000183D55F50 
		public bool showBorder { get; set; } // 0x0000000189EE9E08-0x0000000189EE9E7C
		public bool reorderable { get; set; } // 0x0000000189EE9A24-0x0000000189EE9A94 0x0000000189EE9D24-0x0000000189EE9D88
		public bool horizontalScrollingEnabled { get; set; } // 0x0000000189EE9C90-0x0000000189EE9CF4
		public AlternatingRowBackground showAlternatingRowBackgrounds { get; set; } // 0x0000000183D88ED0-0x0000000183D88EE0 0x0000000189EE9DF0-0x0000000189EE9E08
		public CollectionVirtualizationMethod virtualizationMethod { get; set; } // 0x0000000183D88EE0-0x0000000183D88EF0 0x0000000189EE9E7C-0x0000000189EE9EB4
		public float fixedItemHeight { get; set; } // 0x0000000183D88EA0-0x0000000183D88EB0 0x0000000189EE9B94-0x0000000189EE9C90
		internal float lastHeight { get; } // 0x0000000183D88EB0-0x0000000183D88EC0 
	
		// Nested types
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 43433
		{
			// Fields
			private readonly UxmlIntAttributeDescription m_FixedItemHeight; // 0x78
			private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod; // 0x80
			private readonly UxmlBoolAttributeDescription m_ShowBorder; // 0x88
			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType; // 0x90
			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds; // 0x98
			private readonly UxmlBoolAttributeDescription m_Reorderable; // 0xA0
			private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled; // 0xA8
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189EF3124-0x0000000189EF3508
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189EF2B2C-0x0000000189EF2D5C
		}
	
		private class Selection // TypeDefIndex: 43434
		{
			// Fields
			private readonly HashSet<int> m_IndexLookup; // 0x10
			private readonly HashSet<int> m_IdLookup; // 0x18
			private int m_MinIndex; // 0x20
			private int m_MaxIndex; // 0x24
			public readonly List<int> indices; // 0x30
			public readonly Dictionary<int, object> items; // 0x38
	
			// Properties
			public List<int> selectedIds { get; set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
			public int indexCount { get => default; } // 0x0000000189EF1C38-0x0000000189EF1C78 
			public int idCount { get => default; } // 0x0000000189EF1BF8-0x0000000189EF1C38 
			public int minIndex { get => default; } // 0x0000000189EF1CA0-0x0000000189EF1CC8 
			public int maxIndex { get => default; } // 0x0000000189EF1C78-0x0000000189EF1CA0 
			public int capacity { get => default; set {} } // 0x0000000189EF1BB0-0x0000000189EF1BF8 0x0000000189EF1CC8-0x0000000189EF1D58
	
			// Constructors
			public Selection() {} // 0x0000000189EF1A64-0x0000000189EF1BB0
	
			// Methods
			public int FirstIndex() => default; // 0x0000000189EF1894-0x0000000189EF18FC
			public bool ContainsIndex(int index) => default; // 0x0000000189EF1840-0x0000000189EF1894
			public bool ContainsId(int id) => default; // 0x0000000189EF17EC-0x0000000189EF1840
			public void AddId(int id) {} // 0x0000000189EF1574-0x0000000189EF15EC
			public void AddIndex(int index, object obj) {} // 0x0000000189EF15EC-0x0000000189EF16A8
			public bool TryRemove(int index) => default; // 0x0000000189EF1974-0x0000000189EF1A64
			public void RemoveId(int id) {} // 0x0000000189EF18FC-0x0000000189EF1974
			public void ClearItems() {} // 0x0000000189EF1778-0x0000000189EF17C0
			public void ClearIds() {} // 0x0000000189EF16A8-0x0000000189EF170C
			public void ClearIndices() {} // 0x0000000189EF170C-0x0000000189EF1778
			public void Clear() {} // 0x0000000189EF17C0-0x0000000189EF17EC
		}
	
		// Constructors
		public BaseVerticalCollectionView() {} // 0x0000000189EE92DC-0x0000000189EE9904
		public BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1f /* Metadata: 0x01FB5F0B */) {} // 0x0000000189EE9904-0x0000000189EE999C
		static BaseVerticalCollectionView() {} // 0x0000000189EE8E18-0x0000000189EE92DC
	
		// Methods
		internal bool HasCanStartDrag() => default; // 0x0000000189EE6478-0x0000000189EE6484
		internal bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<int> ids) => default; // 0x0000000189EE7804-0x0000000189EE78A0
		internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<int> ids, StartDragArgs args) => default; // 0x0000000189EE79B0-0x0000000189EE7AA0
		internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) => default; // 0x0000000189EE7928-0x0000000189EE79B0
		internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) => default; // 0x0000000189EE78A0-0x0000000189EE7928
		internal float ResolveItemHeight(float height = -1f /* Metadata: 0x01FB5F07 */) => default; // 0x0000000189EE84C4-0x0000000189EE8514
		private protected virtual void CreateVirtualizationController() {} // 0x0000000189EE5AEC-0x0000000189EE5B28
		internal CollectionVirtualizationController GetOrCreateVirtualizationController() => default; // 0x0000000189EE6354-0x0000000189EE638C
		internal void CreateVirtualizationController<T>()
			where T : ReusableCollectionItem, new() {}
		internal CollectionViewController GetOrCreateViewController() => default; // 0x0000000189EE62E8-0x0000000189EE6354
		protected abstract CollectionViewController CreateViewController();
		public virtual void SetViewController(CollectionViewController controller) {} // 0x0000000189EE8BDC-0x0000000189EE8CD0
		internal virtual ListViewDragger CreateDragger() => default; // 0x0000000189EE5A8C-0x0000000189EE5AEC
		internal void InitializeDragAndDropController(bool enableReordering) {} // 0x0000000189EE64AC-0x0000000189EE659C
		internal abstract ICollectionDragAndDropController CreateDragAndDropController();
		public VisualElement GetRootElementForId(int id) => default; // 0x0000000189EE638C-0x0000000189EE6478
		internal virtual bool HasValidDataAndBindings() => default; // 0x0000000189EE6484-0x0000000189EE64AC
		private void OnItemIndexChanged(int srcIndex, int dstIndex) {} // 0x0000000189EE6F90-0x0000000189EE6FBC
		private void OnItemsSourceChanged() {} // 0x0000000189EE6FBC-0x0000000189EE6FD0
		public void RefreshItems() {} // 0x0000000189EE7BEC-0x0000000189EE7D54
		public void Rebuild() {} // 0x0000000189EE7AA0-0x0000000189EE7BEC
		internal void ScheduleRebuild() {} // 0x0000000189EE8514-0x0000000189EE85D0
		private void RefreshSelection() {} // 0x0000000189EE7D54-0x0000000189EE8248
		private protected virtual void PostRefresh() {} // 0x0000000189EE738C-0x0000000189EE7444
		public void ScrollToItem(int index) {} // 0x0000000189EE863C-0x0000000189EE868C
		public void ScrollToItemById(int id) {} // 0x0000000189EE85D0-0x0000000189EE863C
		private void OnScroll(Vector2 offset) {} // 0x0000000189EE7238-0x0000000189EE7290
		private void Resize(Vector2 size) {} // 0x0000000189EE8450-0x0000000189EE84C4
		private void OnAttachToPanel(AttachToPanelEvent evt) {} // 0x0000000189EE6890-0x0000000189EE6BDC
		private void OnDetachFromPanel(DetachFromPanelEvent evt) {} // 0x0000000189EE6CDC-0x0000000189EE6F90
		private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey) => default; // 0x0000000189EE5378-0x0000000189EE5794
		private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) {} // 0x0000000189EE5794-0x0000000189EE58DC
		private protected virtual bool HandleItemNavigation(bool moveIn, bool altKey) => default; // 0x0000000183D4E3A0-0x0000000183D4E3B0
		private void OnPointerMove(PointerMoveEvent evt) {} // 0x0000000189EE70FC-0x0000000189EE7174
		private void OnPointerDown(PointerDownEvent evt) {} // 0x0000000189EE7038-0x0000000189EE70FC
		private void OnPointerCancel(PointerCancelEvent evt) {} // 0x0000000189EE6FD0-0x0000000189EE7038
		private void OnPointerUp(PointerUpEvent evt) {} // 0x0000000189EE7174-0x0000000189EE7238
		private void ProcessPointerDown(IPointerEvent evt) {} // 0x0000000189EE7444-0x0000000189EE7594
		private void ProcessPointerUp(IPointerEvent evt) {} // 0x0000000189EE7594-0x0000000189EE77FC
		private void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey) {} // 0x0000000189EE5C40-0x0000000189EE6064
		internal void DoRangeSelection(int rangeSelectionFinalIndex) {} // 0x0000000189EE5B28-0x0000000189EE5C40
		private void ProcessSingleClick(int clickedIndex) {} // 0x0000000189EE77FC-0x0000000189EE7804
		internal void SelectAll() {} // 0x0000000189EE868C-0x0000000189EE8920
		public void AddToSelection(int index) {} // 0x0000000189EE5188-0x0000000189EE51F8
		internal void AddToSelection(IList<int> indexes) {} // 0x0000000189EE51F8-0x0000000189EE5378
		private void AddToSelectionWithoutValidation(int index) {} // 0x0000000189EE4F5C-0x0000000189EE5188
		public void RemoveFromSelection(int index) {} // 0x0000000189EE8404-0x0000000189EE8450
		private void RemoveFromSelectionWithoutValidation(int index) {} // 0x0000000189EE8248-0x0000000189EE8404
		public void SetSelection(int index) {} // 0x0000000189EE8B58-0x0000000189EE8BDC
		public void SetSelection(IEnumerable<int> indices) {} // 0x0000000189EE8B4C-0x0000000189EE8B58
		public void SetSelectionWithoutNotify(IEnumerable<int> indices) {} // 0x0000000189EE8B40-0x0000000189EE8B4C
		internal void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification) {} // 0x0000000189EE8920-0x0000000189EE8B40
		private bool MatchesExistingSelection(IEnumerable<int> indices) => default; // 0x0000000189EE659C-0x0000000189EE6818
		private void NotifyOfSelectionChange() {} // 0x0000000189EE6818-0x0000000189EE6890
		public void ClearSelection() {} // 0x0000000189EE5A38-0x0000000189EE5A8C
		private void ClearSelectionWithoutValidation() {} // 0x0000000189EE58DC-0x0000000189EE5A38
		internal override void OnViewDataReady() {} // 0x0000000189EE734C-0x0000000189EE738C
		protected override void ExecuteDefaultAction(EventBase evt) {} // 0x0000000189EE6064-0x0000000189EE62E8
		private void OnSizeChanged(GeometryChangedEvent evt) {} // 0x0000000189EE7290-0x0000000189EE734C
		private void OnCustomStyleResolved(CustomStyleResolvedEvent e) {} // 0x0000000189EE6BDC-0x0000000189EE6CDC
		void ISerializationCallbackReceiver.OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		void ISerializationCallbackReceiver.OnAfterDeserialize() {} // 0x0000000189EE8DDC-0x0000000189EE8E18
	}

	public interface IBindable // TypeDefIndex: 43440
	{
		// Properties
		IBinding binding { get; }
		string bindingPath { get; set; }
	}

	public interface IBinding // TypeDefIndex: 43441
	{
		// Methods
		void PreUpdate();
		void Update();
		void Release();
	}

	public class Box : VisualElement // TypeDefIndex: 43443
	{
		// Fields
		public static readonly string ussClassName; // 0x00
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Box> // TypeDefIndex: 43442
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189EF26EC-0x0000000189EF2728
		}
	
		// Constructors
		public Box() {} // 0x0000000189EE9F10-0x0000000189EE9F84
		static Box() {} // 0x0000000189EE9EB4-0x0000000189EE9F10
	}

	public class Button : UnityEngine.UIElements.TextElement // TypeDefIndex: 43446
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		private Clickable m_Clickable; // 0x488
		private static readonly string NonEmptyString; // 0x08
	
		// Properties
		public Clickable clickable { get => default; set {} } // 0x0000000183D88EF0-0x0000000183D88F00 0x0000000189EEA618-0x0000000189EEA688
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Button, UxmlTraits> // TypeDefIndex: 43444
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189EF2728-0x0000000189EF2764
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 43445
		{
			// Constructors
			public UxmlTraits() {} // 0x0000000189EF37F0-0x0000000189EF3838
		}
	
		// Constructors
		public Button() {} // 0x0000000189EEA60C-0x0000000189EEA618
		public Button(Action clickEvent) {} // 0x0000000189EEA474-0x0000000189EEA60C
		static Button() {} // 0x0000000189EEA3DC-0x0000000189EEA474
	
		// Methods
		private void OnNavigationSubmit(NavigationSubmitEvent evt) {} // 0x0000000189EEA3A4-0x0000000189EEA3DC
		private void OnKeyDown(KeyDownEvent evt) {} // 0x0000000189EEA30C-0x0000000189EEA3A4
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x0000000189EEA260-0x0000000189EEA30C
	}

	internal class ButtonStripField : BaseField<int> // TypeDefIndex: 43449
	{
		// Fields
		private List<UnityEngine.UIElements.Button> m_Buttons; // 0x418
	
		// Properties
		private List<UnityEngine.UIElements.Button> buttons { get => default; } // 0x0000000189EEA180-0x0000000189EEA260 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<ButtonStripField, UxmlTraits> // TypeDefIndex: 43447
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189EF26B0-0x0000000189EF26EC
		}
	
		public class UxmlTraits : BaseField<int> // TypeDefIndex: 43448
		{
			// Constructors
			public UxmlTraits() {} // 0x0000000189EF37B4-0x0000000189EF37F0
		}
	
		// Constructors
		public ButtonStripField() {} // 0x0000000189EEA0D0-0x0000000189EEA180
	
		// Methods
		public override void SetValueWithoutNotify(int newValue) {} // 0x0000000189EEA04C-0x0000000189EEA0D0
		private void RefreshButtonsState() {} // 0x0000000189EE9F84-0x0000000189EEA04C
	}

	public class DropdownField : BaseField<string> // TypeDefIndex: 43454
	{
		// Fields
		internal List<string> m_Choices; // 0x418
		private UnityEngine.UIElements.TextElement m_TextElement; // 0x420
		private VisualElement m_ArrowElement; // 0x428
		internal Func<string, string> m_FormatSelectedValueCallback; // 0x430
		internal Func<string, string> m_FormatListItemCallback; // 0x438
		internal Func<IGenericMenu> createMenuCallback; // 0x440
		private int m_Index; // 0x448
		internal static readonly string ussClassNameBasePopupField; // 0x00
		internal static readonly string textUssClassNameBasePopupField; // 0x08
		internal static readonly string arrowUssClassNameBasePopupField; // 0x10
		internal static readonly string labelUssClassNameBasePopupField; // 0x18
		internal static readonly string inputUssClassNameBasePopupField; // 0x20
		internal static readonly string ussClassNamePopupField; // 0x28
		internal static readonly string labelUssClassNamePopupField; // 0x30
		internal static readonly string inputUssClassNamePopupField; // 0x38
	
		// Properties
		protected UnityEngine.UIElements.TextElement textElement { get => default; } // 0x0000000183D88F00-0x0000000183D88F10 
		public int index { set {} } // 0x0000000189EEBBCC-0x0000000189EEBC54
		public virtual List<string> choices { set {} } // 0x0000000189EEBB6C-0x0000000189EEBBCC
		public override string value { get => default; set {} } // 0x0000000189EEBB30-0x0000000189EEBB6C 0x0000000189EEBC54-0x0000000189EEBCD0
	
		// Nested types
		public class UxmlFactory : UxmlFactory<DropdownField, UxmlTraits> // TypeDefIndex: 43450
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189EF2674-0x0000000189EF26B0
		}
	
		public class UxmlTraits : BaseField<string> // TypeDefIndex: 43451
		{
			// Fields
			private UxmlIntAttributeDescription m_Index; // 0x80
			private UxmlStringAttributeDescription m_Choices; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189EF36AC-0x0000000189EF37B4
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189EF2D5C-0x0000000189EF2E94
		}
	
		private class PopupTextElement : UnityEngine.UIElements.TextElement // TypeDefIndex: 43452
		{
			// Constructors
			public PopupTextElement() {} // 0x0000000189EEF684-0x0000000189EEF6D0
	
			// Methods
			protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x0000000189EEF5EC-0x0000000189EEF684
		}
	
		// Constructors
		public DropdownField() {} // 0x0000000189EEBB24-0x0000000189EEBB30
		public DropdownField(string label) {} // 0x0000000189EEB810-0x0000000189EEBB24
		static DropdownField() {} // 0x0000000189EEB590-0x0000000189EEB810
	
		// Methods
		internal string GetValueToDisplay() => default; // 0x0000000189EEB23C-0x0000000189EEB2C4
		internal string GetListItemToDisplay(string value) => default; // 0x0000000189EEB194-0x0000000189EEB23C
		internal void AddMenuItems(IGenericMenu menu) {} // 0x0000000189EEAC1C-0x0000000189EEB030
		private void ChangeValueFromMenu(string menuItem) {} // 0x0000000189EEB030-0x0000000189EEB044
		public override void SetValueWithoutNotify(string newValue) {} // 0x0000000189EEB2C4-0x0000000189EEB380
		protected override void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x0000000189EEB044-0x0000000189EEB194
		private void ShowMenu() {} // 0x0000000189EEB380-0x0000000189EEB4D0
		protected override void UpdateMixedValueContent() {} // 0x0000000189EEB4D0-0x0000000189EEB590
	}

	public class Foldout : BindableElement, INotifyValueChanged<bool> // TypeDefIndex: 43457
	{
		// Fields
		private Toggle m_Toggle; // 0x3D0
		private VisualElement m_Container; // 0x3D8
		[SerializeField]
		private bool m_Value; // 0x3E0
		public static readonly string ussClassName; // 0x00
		public static readonly string toggleUssClassName; // 0x08
		public static readonly string contentUssClassName; // 0x10
		public static readonly string inputUssClassName; // 0x18
		public static readonly string checkmarkUssClassName; // 0x20
		public static readonly string textUssClassName; // 0x28
		internal static readonly string ussFoldoutDepthClassName; // 0x30
		internal static readonly int ussFoldoutMaxDepth; // 0x38
	
		// Properties
		internal Toggle toggle { get => default; } // 0x0000000183D55EC0-0x0000000183D55ED0 
		public override VisualElement contentContainer { get => default; } // 0x0000000183D55ED0-0x0000000183D55EE0 
		public string text { set {} } // 0x0000000189EEC53C-0x0000000189EEC638
		public bool value { get => default; set {} } // 0x0000000183D88F10-0x0000000183D88F20 0x0000000189EEC638-0x0000000189EEC744
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Foldout, UxmlTraits> // TypeDefIndex: 43455
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189EF2764-0x0000000189EF27A0
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 43456
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x78
			private UxmlBoolAttributeDescription m_Value; // 0x80
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189EF3508-0x0000000189EF3608
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189EF2958-0x0000000189EF2A5C
		}
	
		// Constructors
		public Foldout() {} // 0x0000000189EEC1E4-0x0000000189EEC53C
		static Foldout() {} // 0x0000000189EEBF74-0x0000000189EEC1E4
	
		// Methods
		public void SetValueWithoutNotify(bool newValue) {} // 0x0000000189EEBE88-0x0000000189EEBF24
		internal override void OnViewDataReady() {} // 0x0000000189EEBE50-0x0000000189EEBE88
		private void OnAttachToPanel(AttachToPanelEvent evt) {} // 0x0000000189EEBCD0-0x0000000189EEBE50
	}

	internal interface IGenericMenu // TypeDefIndex: 43458
	{
		// Methods
		void AddItem(string itemName, bool isChecked, Action action);
		void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false /* Metadata: 0x01FB5F0F */);
	}

	public class GenericDropdownMenu : IGenericMenu // TypeDefIndex: 43461
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string itemUssClassName; // 0x08
		public static readonly string labelUssClassName; // 0x10
		public static readonly string containerInnerUssClassName; // 0x18
		public static readonly string containerOuterUssClassName; // 0x20
		public static readonly string checkmarkUssClassName; // 0x28
		public static readonly string separatorUssClassName; // 0x30
		private List<MenuItem> m_Items; // 0x10
		private VisualElement m_MenuContainer; // 0x18
		private VisualElement m_OuterContainer; // 0x20
		private ScrollView m_ScrollView; // 0x28
		private VisualElement m_PanelRootVisualContainer; // 0x30
		private VisualElement m_TargetElement; // 0x38
		private Rect m_DesiredRect; // 0x40
		private KeyboardNavigationManipulator m_NavigationManipulator; // 0x50
		private Vector2 m_MousePosition; // 0x58
	
		// Properties
		public VisualElement contentContainer { get => default; } // 0x0000000189EEEB0C-0x0000000189EEEB30 
	
		// Nested types
		internal class MenuItem // TypeDefIndex: 43459
		{
			// Fields
			public string name; // 0x10
			public VisualElement element; // 0x18
			public Action action; // 0x20
			public Action<object> actionUserData; // 0x28
	
			// Constructors
			public MenuItem() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public GenericDropdownMenu() {} // 0x0000000189EEE7E0-0x0000000189EEEB0C
		static GenericDropdownMenu() {} // 0x0000000189EEE584-0x0000000189EEE7E0
	
		// Methods
		private void OnAttachToPanel(AttachToPanelEvent evt) {} // 0x0000000189EED804-0x0000000189EEDBBC
		private void OnDetachFromPanel(DetachFromPanelEvent evt) {} // 0x0000000189EEDBC4-0x0000000189EEDEEC
		private void Hide() {} // 0x0000000189EED724-0x0000000189EED804
		private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) {} // 0x0000000189EECCC4-0x0000000189EECD00
		private bool Apply(KeyboardNavigationOperation op) => default; // 0x0000000189EECB1C-0x0000000189EECCC4
		private void OnPointerDown(PointerDownEvent evt) {} // 0x0000000189EEDFC4-0x0000000189EEE0EC
		private void OnPointerMove(PointerMoveEvent evt) {} // 0x0000000189EEE0EC-0x0000000189EEE214
		private void OnPointerUp(PointerUpEvent evt) {} // 0x0000000189EEE214-0x0000000189EEE344
		private void OnFocusOut(FocusOutEvent evt) {} // 0x0000000189EEDEEC-0x0000000189EEDFBC
		private void OnParentResized(GeometryChangedEvent evt) {} // 0x0000000189EEDFBC-0x0000000189EEDFC4
		private void UpdateSelection(VisualElement target) {} // 0x0000000189EEE474-0x0000000189EEE584
		private void ChangeSelectedIndex(int newIndex, int previousIndex) {} // 0x0000000189EECD00-0x0000000189EECE1C
		private int GetSelectedIndex() => default; // 0x0000000189EED69C-0x0000000189EED724
		public void AddItem(string itemName, bool isChecked, Action action) {} // 0x0000000189EEC744-0x0000000189EEC77C
		public void AddSeparator(string path) {} // 0x0000000189EECA70-0x0000000189EECB1C
		private MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data = null) => default; // 0x0000000189EEC77C-0x0000000189EECA70
		public void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false /* Metadata: 0x01FB5F10 */) {} // 0x0000000189EECE1C-0x0000000189EED2C8
		private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt) {} // 0x0000000189EEDFBC-0x0000000189EEDFC4
		private void OnContainerGeometryChanged(GeometryChangedEvent evt) {} // 0x0000000189EEDBBC-0x0000000189EEDBC4
		private void EnsureVisibilityInParent() {} // 0x0000000189EED2C8-0x0000000189EED69C
	}

	public class GroupBox : BindableElement, IGroupBox // TypeDefIndex: 43464
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		private UnityEngine.UIElements.Label m_TitleLabel; // 0x3D0
	
		// Properties
		public string text { set {} } // 0x0000000189EF41D0-0x0000000189EF4304
	
		// Nested types
		public class UxmlFactory : UxmlFactory<GroupBox, UxmlTraits> // TypeDefIndex: 43462
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F01A64-0x0000000189F01AA0
		}
	
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 43463
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x78
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F03968-0x0000000189F039F8
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F02A6C-0x0000000189F02B48
		}
	
		// Constructors
		public GroupBox() {} // 0x0000000189EF41C4-0x0000000189EF41D0
		public GroupBox(string text) {} // 0x0000000189EF414C-0x0000000189EF41C4
		static GroupBox() {} // 0x0000000189EF409C-0x0000000189EF414C
	}

	public enum HelpBoxMessageType // TypeDefIndex: 43465
	{
		None = 0,
		Info = 1,
		Warning = 2,
		Error = 3
	}

	public class HelpBox : VisualElement // TypeDefIndex: 43468
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string iconUssClassName; // 0x10
		public static readonly string iconInfoUssClassName; // 0x18
		public static readonly string iconwarningUssClassName; // 0x20
		public static readonly string iconErrorUssClassName; // 0x28
		private HelpBoxMessageType m_HelpBoxMessageType; // 0x3C0
		private VisualElement m_Icon; // 0x3C8
		private string m_IconClass; // 0x3D0
		private UnityEngine.UIElements.Label m_Label; // 0x3D8
	
		// Properties
		public string text { set {} } // 0x0000000189EF486C-0x0000000189EF4890
		public HelpBoxMessageType messageType { set {} } // 0x0000000189EF484C-0x0000000189EF486C
	
		// Nested types
		public class UxmlFactory : UxmlFactory<HelpBox, UxmlTraits> // TypeDefIndex: 43466
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F01ADC-0x0000000189F01B18
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 43467
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x70
			private UxmlEnumAttributeDescription<HelpBoxMessageType> m_MessageType; // 0x78
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F03CD0-0x0000000189F03DDC
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F0296C-0x0000000189F02A6C
		}
	
		// Constructors
		public HelpBox() {} // 0x0000000189EF4678-0x0000000189EF46C4
		public HelpBox(string text, HelpBoxMessageType messageType) {} // 0x0000000189EF46C4-0x0000000189EF484C
		static HelpBox() {} // 0x0000000189EF4470-0x0000000189EF4678
	
		// Methods
		private string GetIconClass(HelpBoxMessageType messageType) => default; // 0x0000000189EF4304-0x0000000189EF43AC
		private void UpdateIcon(HelpBoxMessageType messageType) {} // 0x0000000189EF43AC-0x0000000189EF4470
	}

	public class Image : VisualElement // TypeDefIndex: 43471
	{
		// Fields
		private UnityEngine.ScaleMode m_ScaleMode; // 0x3C0
		private Texture m_Image; // 0x3C8
		private Sprite m_Sprite; // 0x3D0
		private VectorImage m_VectorImage; // 0x3D8
		private Rect m_UV; // 0x3E0
		private UnityEngine.Color m_TintColor; // 0x3F0
		private bool m_ImageIsInline; // 0x400
		private bool m_ScaleModeIsInline; // 0x401
		private bool m_TintColorIsInline; // 0x402
		public static readonly string ussClassName; // 0x00
		private static CustomStyleProperty<Texture2D> s_ImageProperty; // 0x08
		private static CustomStyleProperty<Sprite> s_SpriteProperty; // 0x10
		private static CustomStyleProperty<VectorImage> s_VectorImageProperty; // 0x18
		private static CustomStyleProperty<string> s_ScaleModeProperty; // 0x20
		private static CustomStyleProperty<UnityEngine.Color> s_TintColorProperty; // 0x28
	
		// Properties
		public Texture image { get => default; set {} } // 0x0000000183D88F50-0x0000000183D88F60 0x0000000189EF59F8-0x0000000189EF5BF8
		public Sprite sprite { get => default; set {} } // 0x0000000183D88E30-0x0000000183D88E40 0x0000000189EF5BF8-0x0000000189EF5DC4
		public VectorImage vectorImage { get => default; set {} } // 0x0000000183D88DF0-0x0000000183D88E00 0x0000000189EF5DC4-0x0000000189EF5FC4
		public Rect sourceRect { get => default; } // 0x0000000189EF59CC-0x0000000189EF59F8 
		public Rect uv { get => default; } // 0x0000000183D88F80-0x0000000183D88F90 
		public UnityEngine.ScaleMode scaleMode { get => default; } // 0x0000000183D88F60-0x0000000183D88F70 
		public UnityEngine.Color tintColor { get => default; } // 0x0000000183D88F70-0x0000000183D88F80 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Image, UxmlTraits> // TypeDefIndex: 43469
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F018C0-0x0000000189F018FC
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 43470
		{
			// Constructors
			public UxmlTraits() {} // 0x0000000189F03DDC-0x0000000189F03F3C
		}
	
		// Constructors
		public Image() {} // 0x0000000189EF5824-0x0000000189EF59CC
		static Image() {} // 0x0000000189EF55F4-0x0000000189EF5824
	
		// Methods
		private Vector2 GetTextureDisplaySize(Texture texture) => default; // 0x0000000189EF4C50-0x0000000189EF4CF0
		private Vector2 GetTextureDisplaySize(Sprite sprite) => default; // 0x0000000189EF4CF0-0x0000000189EF4DF0
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default; // 0x0000000189EF4890-0x0000000189EF4AC0
		private void OnGenerateVisualContent(MeshGenerationContext mgc) {} // 0x0000000189EF51E8-0x0000000189EF55D0
		private void OnCustomStyleResolved(CustomStyleResolvedEvent e) {} // 0x0000000189EF4DF0-0x0000000189EF51E8
		private void SetScaleMode(UnityEngine.ScaleMode mode) {} // 0x0000000189EF55D0-0x0000000189EF55F4
		private Rect GetSourceRect() => default; // 0x0000000189EF4AC0-0x0000000189EF4C50
	}

	public interface INotifyValueChanged<T> // TypeDefIndex: 43472
	{
		// Properties
		T value { get; set; }
	
		// Methods
		void SetValueWithoutNotify(T newValue);
	}

	public static class INotifyValueChangedExtensions // TypeDefIndex: 43473
	{
		// Extension methods
		public static bool RegisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback) => default;
		public static bool UnregisterValueChangedCallback<T>(this INotifyValueChanged<T> control, EventCallback<ChangeEvent<T>> callback) => default;
	}

	internal class KeyboardTextEditorEventHandler : TextEditorEventHandler // TypeDefIndex: 43474
	{
		// Fields
		internal bool m_Changed; // 0x20
		private bool m_Dragged; // 0x21
		private bool m_DragToPosition; // 0x22
		private bool m_SelectAllOnMouseUp; // 0x23
		private string m_PreDrawCursorText; // 0x28
		private bool m_IsClicking; // 0x30
		private Vector2 m_ClickStartPosition; // 0x34
		private readonly UnityEngine.Event m_ImguiEvent; // 0x40
	
		// Properties
		private bool isClicking { get => default; set {} } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000189EF7770-0x0000000189EF779C
	
		// Constructors
		public KeyboardTextEditorEventHandler() {} // Dummy constructor
		public KeyboardTextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField) {} // 0x0000000189EF76E0-0x0000000189EF7770
	
		// Methods
		public override void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x0000000189EF5FC4-0x0000000189EF63A0
		private void OnFocus(FocusEvent _) {} // 0x0000000189EF66F8-0x0000000189EF67D4
		private void OnBlur(BlurEvent _) {} // 0x0000000189EF63E4-0x0000000189EF63F0
		private void OnMouseDown(MouseDownEvent evt) {} // 0x0000000189EF6B9C-0x0000000189EF6F20
		private void OnMouseUp(MouseUpEvent evt) {} // 0x0000000189EF702C-0x0000000189EF7114
		private void OnMouseMove(MouseMoveEvent evt) {} // 0x0000000189EF6F20-0x0000000189EF702C
		private void ProcessDragMove(MouseMoveEvent evt) {} // 0x0000000189EF7580-0x0000000189EF76E0
		private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current) => default; // 0x0000000189EF63A0-0x0000000189EF63E4
		private void OnKeyDown(KeyDownEvent evt) {} // 0x0000000189EF67D4-0x0000000189EF6B9C
		private void OnValidateCommandEvent(ValidateCommandEvent evt) {} // 0x0000000189EF7114-0x0000000189EF72D0
		private void OnExecuteCommandEvent(ExecuteCommandEvent evt) {} // 0x0000000189EF63F0-0x0000000189EF66F8
		public void PreDrawCursor(string newText) {} // 0x0000000189EF72F8-0x0000000189EF7580
		public void PostDrawCursor() {} // 0x0000000189EF72D0-0x0000000189EF72F8
	}

	public class Label : UnityEngine.UIElements.TextElement // TypeDefIndex: 43477
	{
		// Fields
		public static readonly string ussClassName; // 0x00
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Label, UxmlTraits> // TypeDefIndex: 43475
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F01AA0-0x0000000189F01ADC
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 43476
		{
			// Constructors
			public UxmlTraits() {} // 0x0000000189F031C8-0x0000000189F031D0
		}
	
		// Constructors
		public Label() {} // 0x0000000189EF7888-0x0000000189EF78D0
		public Label(string text) {} // 0x0000000189EF77F8-0x0000000189EF7888
		static Label() {} // 0x0000000189EF779C-0x0000000189EF77F8
	}

	public class ListView : BaseListView // TypeDefIndex: 43480
	{
		// Fields
		private Func<VisualElement> m_MakeItem; // 0x538
		private Action<VisualElement, int> m_BindItem; // 0x540
	
		// Properties
		public Func<VisualElement> makeItem { get => default; } // 0x0000000183D6CB00-0x0000000183D6CB10 
		public Action<VisualElement, int> bindItem { get => default; } // 0x0000000183D6CB10-0x0000000183D6CB20 
		public Action<VisualElement, int> unbindItem { get; } // 0x0000000183D6CB20-0x0000000183D6CB30 
		public Action<VisualElement> destroyItem { get; } // 0x0000000183D6CB30-0x0000000183D6CB40 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<ListView, UxmlTraits> // TypeDefIndex: 43478
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F01B18-0x0000000189F01B54
		}
	
		public class UxmlTraits : BaseListView.UxmlTraits // TypeDefIndex: 43479
		{
			// Constructors
			public UxmlTraits() {} // 0x0000000189F031D0-0x0000000189F031D8
		}
	
		// Constructors
		public ListView() {} // 0x0000000189EF7948-0x0000000189EF79A8
	
		// Methods
		internal override bool HasValidDataAndBindings() => default; // 0x0000000189EF790C-0x0000000189EF7948
		protected override CollectionViewController CreateViewController() => default; // 0x0000000189EF78D0-0x0000000189EF790C
	}

	public class MinMaxSlider : BaseField<Vector2> // TypeDefIndex: 43484
	{
		// Fields
		private Vector2 m_DragElementStartPos; // 0x438
		private Vector2 m_ValueStartPos; // 0x440
		private Rect m_DragMinThumbRect; // 0x448
		private Rect m_DragMaxThumbRect; // 0x458
		private DragState m_DragState; // 0x468
		private float m_MinLimit; // 0x46C
		private float m_MaxLimit; // 0x470
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
		public static readonly string trackerUssClassName; // 0x18
		public static readonly string draggerUssClassName; // 0x20
		public static readonly string minThumbUssClassName; // 0x28
		public static readonly string maxThumbUssClassName; // 0x30
	
		// Properties
		internal VisualElement dragElement { get; private set; } // 0x0000000183D57150-0x0000000183D57160 0x00000001858B3D1C-0x00000001858B3D30
		internal VisualElement dragMinThumb { get; private set; } // 0x0000000183D57320-0x0000000183D57330 0x00000001858B4000-0x00000001858B4014
		internal VisualElement dragMaxThumb { get; private set; } // 0x0000000183D55F30-0x0000000183D55F40 0x00000001858B3EAC-0x00000001858B3EC0
		internal ClampedDragger<float> clampedDragger { get; private set; } // 0x0000000183D55F10-0x0000000183D55F20 0x00000001858B3E5C-0x00000001858B3E70
		public float minValue { get => default; set {} } // 0x0000000189EF92DC-0x0000000189EF9300 0x0000000189EF95B0-0x0000000189EF9620
		public float maxValue { get => default; set {} } // 0x0000000189EF92B8-0x0000000189EF92DC 0x0000000189EF9540-0x0000000189EF95B0
		public override Vector2 value { get => default; set {} } // 0x0000000189EF9300-0x0000000189EF9344 0x0000000189EF9620-0x0000000189EF967C
		public float lowLimit { get => default; set {} } // 0x0000000183D88FC0-0x0000000183D88FD0 0x0000000189EF9444-0x0000000189EF9540
		public float highLimit { get => default; set {} } // 0x0000000183D88FB0-0x0000000183D88FC0 0x0000000189EF9344-0x0000000189EF9444
	
		// Nested types
		public class UxmlFactory : UxmlFactory<MinMaxSlider, UxmlTraits> // TypeDefIndex: 43481
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F018FC-0x0000000189F01938
		}
	
		public class UxmlTraits : BaseField<Vector2> // TypeDefIndex: 43482
		{
			// Fields
			private UxmlFloatAttributeDescription m_MinValue; // 0x80
			private UxmlFloatAttributeDescription m_MaxValue; // 0x88
			private UxmlFloatAttributeDescription m_LowLimit; // 0x90
			private UxmlFloatAttributeDescription m_HighLimit; // 0x98
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F03490-0x0000000189F0365C
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F01BCC-0x0000000189F01D60
		}
	
		private enum DragState // TypeDefIndex: 43483
		{
			NoThumb = 0,
			MinThumb = 1,
			MiddleThumb = 2,
			MaxThumb = 3
		}
	
		// Constructors
		public MinMaxSlider() {} // 0x0000000189EF8C88-0x0000000189EF8CC8
		public MinMaxSlider(string label, float minValue = 0f /* Metadata: 0x01FB5F15 */, float maxValue = 10f /* Metadata: 0x01FB5F19 */, float minLimit = -3.4028235E+38f /* Metadata: 0x01FB5F1D */, float maxLimit = 3.4028235E+38f /* Metadata: 0x01FB5F21 */) {} // 0x0000000189EF8CC8-0x0000000189EF92B8
		static MinMaxSlider() {} // 0x0000000189EF8A2C-0x0000000189EF8C88
	
		// Methods
		public override void SetValueWithoutNotify(Vector2 newValue) {} // 0x0000000189EF815C-0x0000000189EF81C4
		private Vector2 ClampValues(Vector2 valueToClamp) => default; // 0x0000000189EF79A8-0x0000000189EF7A28
		private void UpdateDragElementPosition(GeometryChangedEvent evt) {} // 0x0000000189EF89A8-0x0000000189EF8A2C
		private void UpdateDragElementPosition() {} // 0x0000000189EF81D8-0x0000000189EF89A8
		internal float SliderLerpUnclamped(float a, float b, float interpolant) => default; // 0x0000000183D88F90-0x0000000183D88FB0
		internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) => default; // 0x0000000189EF81C4-0x0000000189EF81D8
		private float ComputeValueFromPosition(float positionToConvert) => default; // 0x0000000189EF7C38-0x0000000189EF7D1C
		protected override void ExecuteDefaultAction(EventBase evt) {} // 0x0000000189EF7D1C-0x0000000189EF7DD4
		private void SetSliderValueFromDrag() {} // 0x0000000189EF80CC-0x0000000189EF815C
		private void SetSliderValueFromClick() {} // 0x0000000189EF7DD4-0x0000000189EF80CC
		private void ComputeValueDragStateNoThumb(float lowLimitPosition, float highLimitPosition, float dragElementPos) {} // 0x0000000189EF7A28-0x0000000189EF7AC4
		private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos) {} // 0x0000000189EF7AC4-0x0000000189EF7C38
		protected override void UpdateMixedValueContent() {} // 0x000000018350B670-0x000000018350B680
	}

	public class PopupWindow : UnityEngine.UIElements.TextElement // TypeDefIndex: 43487
	{
		// Fields
		private VisualElement m_ContentContainer; // 0x488
		public static readonly string ussClassName; // 0x00
		public static readonly string contentUssClassName; // 0x08
	
		// Properties
		public override VisualElement contentContainer { get => default; } // 0x0000000183D88EF0-0x0000000183D88F00 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<PopupWindow, UxmlTraits> // TypeDefIndex: 43485
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F01884-0x0000000189F018C0
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 43486
		{
			// Constructors
			public UxmlTraits() {} // 0x0000000189F031C8-0x0000000189F031D0
		}
	
		// Constructors
		public PopupWindow() {} // 0x0000000189EF972C-0x0000000189EF9858
		static PopupWindow() {} // 0x0000000189EF967C-0x0000000189EF972C
	}

	public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<float> // TypeDefIndex: 43489
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string containerUssClassName; // 0x08
		public static readonly string titleUssClassName; // 0x10
		public static readonly string titleContainerUssClassName; // 0x18
		public static readonly string progressUssClassName; // 0x20
		public static readonly string backgroundUssClassName; // 0x28
		private readonly VisualElement m_Background; // 0x3D0
		private readonly VisualElement m_Progress; // 0x3D8
		private readonly UnityEngine.UIElements.Label m_Title; // 0x3E0
		private float m_LowValue; // 0x3E8
		private float m_HighValue; // 0x3EC
		private float m_Value; // 0x3F0
	
		// Properties
		public string title { get; set; } // 0x0000000189EF3F0C-0x0000000189EF3F30
		public float lowValue { get; set; } // 0x0000000183D88F30-0x0000000183D88F40 0x0000000189EF3EF4-0x0000000189EF3F0C
		public float highValue { get; set; } // 0x0000000183D88F20-0x0000000183D88F30 0x0000000189EF3EDC-0x0000000189EF3EF4
		public virtual float value { get; set; } // 0x0000000183D88F40-0x0000000183D88F50 0x0000000189EF3F30-0x0000000189EF409C
	
		// Nested types
		public class UxmlTraits : BindableElement.UxmlTraits // TypeDefIndex: 43488
		{
			// Fields
			private UxmlFloatAttributeDescription m_LowValue; // 0x78
			private UxmlFloatAttributeDescription m_HighValue; // 0x80
			private UxmlFloatAttributeDescription m_Value; // 0x88
			private UxmlStringAttributeDescription m_Title; // 0x90
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F03AE4-0x0000000189F03CD0
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F027EC-0x0000000189F0296C
		}
	
		// Constructors
		public AbstractProgressBar() {} // 0x0000000189EF3BA8-0x0000000189EF3EDC
		static AbstractProgressBar() {} // 0x0000000189EF39A4-0x0000000189EF3BA8
	
		// Methods
		private void OnGeometryChanged(GeometryChangedEvent e) {} // 0x0000000189EF38E0-0x0000000189EF38F4
		public void SetValueWithoutNotify(float newValue) {} // 0x0000000189EF3994-0x0000000189EF39A4
		private void SetProgress(float p) {} // 0x0000000189EF38F4-0x0000000189EF3994
		private float CalculateProgressWidth(float width) => default; // 0x0000000189EF3838-0x0000000189EF38E0
	}

	[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
	public class ProgressBar : AbstractProgressBar // TypeDefIndex: 43491
	{
		// Nested types
		public class UxmlFactory : UxmlFactory<ProgressBar, UxmlTraits> // TypeDefIndex: 43490
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F01A28-0x0000000189F01A64
		}
	
		// Constructors
		public ProgressBar() {} // 0x0000000189EF9858-0x0000000189EF98A4
	}

	public class RadioButton : BaseBoolField, IGroupBoxOption // TypeDefIndex: 43494
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
		public static readonly string checkmarkBackgroundUssClassName; // 0x18
		public static readonly string checkmarkUssClassName; // 0x20
		public static readonly string textUssClassName; // 0x28
		private VisualElement m_CheckmarkBackground; // 0x438
	
		// Properties
		public override bool value { get => default; set {} } // 0x0000000189EFA70C-0x0000000189EFA748 0x0000000189EFA748-0x0000000189EFA7E8
	
		// Nested types
		public class UxmlFactory : UxmlFactory<RadioButton, UxmlTraits> // TypeDefIndex: 43492
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F01B54-0x0000000189F01B90
		}
	
		public class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription> // TypeDefIndex: 43493
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F03120-0x0000000189F031C8
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F02288-0x0000000189F0236C
		}
	
		// Constructors
		public RadioButton() {} // 0x0000000189EFA4FC-0x0000000189EFA508
		public RadioButton(string label) {} // 0x0000000189EFA508-0x0000000189EFA70C
		static RadioButton() {} // 0x0000000189EFA2F8-0x0000000189EFA4FC
	
		// Methods
		protected override void InitLabel() {} // 0x0000000189EFA10C-0x0000000189EFA17C
		protected override void ToggleValue() {} // 0x0000000189EFA1B0-0x0000000189EFA1E0
		public void SetSelected(bool selected) {} // 0x0000000189EFA17C-0x0000000189EFA190
		public override void SetValueWithoutNotify(bool newValue) {} // 0x0000000189EFA190-0x0000000189EFA1B0
		private void UpdateCheckmark() {} // 0x0000000189EFA1E0-0x0000000189EFA260
		protected override void UpdateMixedValueContent() {} // 0x0000000189EFA260-0x0000000189EFA2F8
	}

	public class RadioButtonGroup : BaseField<int>, IGroupBox // TypeDefIndex: 43497
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		private IEnumerable<string> m_Choices; // 0x418
		private List<RadioButton> m_RadioButtons; // 0x420
		private EventCallback<ChangeEvent<bool>> m_RadioButtonValueChangedCallback; // 0x428
	
		// Properties
		public IEnumerable<string> choices { set {} } // 0x0000000189EF9D88-0x0000000189EFA10C
	
		// Nested types
		public class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits> // TypeDefIndex: 43495
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F01974-0x0000000189F019B0
		}
	
		public class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription> // TypeDefIndex: 43496
		{
			// Fields
			private UxmlStringAttributeDescription m_Choices; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F0365C-0x0000000189F03704
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F026FC-0x0000000189F027EC
		}
	
		// Constructors
		public RadioButtonGroup() {} // 0x0000000189EF9D78-0x0000000189EF9D88
		public RadioButtonGroup(string label, List<string> radioButtonChoices = null) {} // 0x0000000189EF9BDC-0x0000000189EF9D78
		static RadioButtonGroup() {} // 0x0000000189EF9B80-0x0000000189EF9BDC
	
		// Methods
		private void RadioButtonValueChangedCallback(ChangeEvent<bool> evt) {} // 0x0000000189EF98A4-0x0000000189EF9960
		public override void SetValueWithoutNotify(int newValue) {} // 0x0000000189EF9960-0x0000000189EF99B0
		private void UpdateRadioButtons() {} // 0x0000000189EF99B0-0x0000000189EF9B80
	}

	public class RepeatButton : UnityEngine.UIElements.TextElement // TypeDefIndex: 43500
	{
		// Fields
		private Clickable m_Clickable; // 0x488
		public static readonly string ussClassName; // 0x00
	
		// Nested types
		public class UxmlFactory : UxmlFactory<RepeatButton, UxmlTraits> // TypeDefIndex: 43498
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F019EC-0x0000000189F01A28
		}
	
		public class UxmlTraits : UnityEngine.UIElements.TextElement.UxmlTraits // TypeDefIndex: 43499
		{
			// Fields
			private UxmlLongAttributeDescription m_Delay; // 0x90
			private UxmlLongAttributeDescription m_Interval; // 0x98
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F039F8-0x0000000189F03AE4
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F01D60-0x0000000189F01E74
		}
	
		// Constructors
		public RepeatButton() {} // 0x0000000189EFA988-0x0000000189EFA9FC
		public RepeatButton(Action clickEvent, long delay, long interval) {} // 0x0000000189EFA930-0x0000000189EFA988
		static RepeatButton() {} // 0x0000000189EFA8D4-0x0000000189EFA930
	
		// Methods
		public void SetAction(Action clickEvent, long delay, long interval) {} // 0x0000000189EFA80C-0x0000000189EFA8D4
		internal void AddAction(Action clickEvent) {} // 0x0000000189EFA7E8-0x0000000189EFA80C
	}

	public class Scroller : VisualElement // TypeDefIndex: 43503
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string horizontalVariantUssClassName; // 0x08
		public static readonly string verticalVariantUssClassName; // 0x10
		public static readonly string sliderUssClassName; // 0x18
		public static readonly string lowButtonUssClassName; // 0x20
		public static readonly string highButtonUssClassName; // 0x28
	
		// Properties
		public Slider slider { get; private set; } // 0x0000000183D56FF0-0x0000000183D57000 0x00000001858B3B50-0x00000001858B3B64
		public RepeatButton lowButton { get; private set; } // 0x0000000183D55EC0-0x0000000183D55ED0 0x00000001858B40A0-0x00000001858B40B4
		public RepeatButton highButton { get; private set; } // 0x0000000183D55ED0-0x0000000183D55EE0 0x00000001858B3D30-0x00000001858B3D44
		public float value { get => default; set {} } // 0x0000000189F007F8-0x0000000189F0081C 0x0000000189F00AA0-0x0000000189F00AC8
		public float lowValue { get => default; set {} } // 0x0000000189F007B0-0x0000000189F007F8 0x0000000189F00A48-0x0000000189F00AA0
		public float highValue { get => default; set {} } // 0x0000000189F00768-0x0000000189F007B0 0x0000000189F009F0-0x0000000189F00A48
		public SliderDirection direction { set {} } // 0x0000000189F008AC-0x0000000189F009F0
	
		// Events
		public event Action<float> valueChanged;
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Scroller, UxmlTraits> // TypeDefIndex: 43501
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F01B90-0x0000000189F01BCC
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 43502
		{
			// Fields
			private UxmlFloatAttributeDescription m_LowValue; // 0x70
			private UxmlFloatAttributeDescription m_HighValue; // 0x78
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction; // 0x80
			private UxmlFloatAttributeDescription m_Value; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F03704-0x0000000189F03968
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F020CC-0x0000000189F02288
		}
	
		// Constructors
		public Scroller() {} // 0x0000000189F00290-0x0000000189F002B8
		public Scroller(float lowValue, float highValue, Action<float> valueChanged, SliderDirection direction = SliderDirection.Vertical /* Metadata: 0x01FB5F29 */) {} // 0x0000000189F002B8-0x0000000189F006D8
		static Scroller() {} // 0x0000000189F0008C-0x0000000189F00290
	
		// Methods
		public void Adjust(float factor) {} // 0x0000000189EFFDE4-0x0000000189EFFE58
		private void OnSliderValueChange(ChangeEvent<float> evt) {} // 0x0000000189EFFE58-0x0000000189EFFEEC
		public void ScrollPageUp() {} // 0x0000000189F0007C-0x0000000189F0008C
		public void ScrollPageDown() {} // 0x0000000189EFFFAC-0x0000000189EFFFBC
		public void ScrollPageUp(float factor) {} // 0x0000000189EFFFBC-0x0000000189F0007C
		public void ScrollPageDown(float factor) {} // 0x0000000189EFFEEC-0x0000000189EFFFAC
	}

	public enum ScrollViewMode // TypeDefIndex: 43504
	{
		Vertical = 0,
		Horizontal = 1,
		VerticalAndHorizontal = 2
	}

	public enum ScrollerVisibility // TypeDefIndex: 43505
	{
		Auto = 0,
		AlwaysVisible = 1,
		Hidden = 2
	}

	public class ScrollView : VisualElement // TypeDefIndex: 43511
	{
		// Fields
		private int m_FirstLayoutPass; // 0x3C0
		private ScrollerVisibility m_HorizontalScrollerVisibility; // 0x3C4
		private ScrollerVisibility m_VerticalScrollerVisibility; // 0x3C8
		private VisualElement m_AttachedRootVisualContainer; // 0x3D0
		private float m_SingleLineHeight; // 0x3D8
		internal bool m_MouseWheelScrollSizeIsInline; // 0x3DC
		private float m_HorizontalPageSize; // 0x3E0
		private float m_VerticalPageSize; // 0x3E4
		private float m_MouseWheelScrollSize; // 0x3E8
		private static readonly float k_DefaultScrollDecelerationRate; // 0x00
		private float m_ScrollDecelerationRate; // 0x3EC
		private float k_ScaledPixelsPerPointMultiplier; // 0x3F0
		private float k_TouchScrollInertiaBaseTimeInterval; // 0x3F4
		private static readonly float k_DefaultElasticity; // 0x04
		private float m_Elasticity; // 0x3F8
		private TouchScrollBehavior m_TouchScrollBehavior; // 0x3FC
		private NestedInteractionKind m_NestedInteractionKind; // 0x400
		private static readonly long k_DefaultElasticAnimationInterval; // 0x08
		private long m_ElasticAnimationIntervalMs; // 0x408
		private VisualElement m_ContentContainer; // 0x428
		private VisualElement m_ContentAndVerticalScrollContainer; // 0x430
		private float previousVerticalTouchScrollTimeStamp; // 0x438
		private float previousHorizontalTouchScrollTimeStamp; // 0x43C
		private float elapsedTimeSinceLastVerticalTouchScroll; // 0x440
		private float elapsedTimeSinceLastHorizontalTouchScroll; // 0x444
		public static readonly string ussClassName; // 0x10
		public static readonly string viewportUssClassName; // 0x18
		public static readonly string horizontalVariantViewportUssClassName; // 0x20
		public static readonly string verticalVariantViewportUssClassName; // 0x28
		public static readonly string verticalHorizontalVariantViewportUssClassName; // 0x30
		public static readonly string contentAndVerticalScrollUssClassName; // 0x38
		public static readonly string contentUssClassName; // 0x40
		public static readonly string horizontalVariantContentUssClassName; // 0x48
		public static readonly string verticalVariantContentUssClassName; // 0x50
		public static readonly string verticalHorizontalVariantContentUssClassName; // 0x58
		public static readonly string hScrollerUssClassName; // 0x60
		public static readonly string vScrollerUssClassName; // 0x68
		public static readonly string horizontalVariantUssClassName; // 0x70
		public static readonly string verticalVariantUssClassName; // 0x78
		public static readonly string verticalHorizontalVariantUssClassName; // 0x80
		public static readonly string scrollVariantUssClassName; // 0x88
		private ScrollViewMode m_Mode; // 0x448
		private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem; // 0x450
		private Vector2 m_StartPosition; // 0x458
		private Vector2 m_PointerStartPosition; // 0x460
		private Vector2 m_Velocity; // 0x468
		private Vector2 m_SpringBackVelocity; // 0x470
		private Vector2 m_LowBounds; // 0x478
		private Vector2 m_HighBounds; // 0x480
		private float m_LastVelocityLerpTime; // 0x488
		private bool m_StartedMoving; // 0x48C
		private bool m_TouchPointerMoveAllowed; // 0x48D
		private bool m_TouchStoppedVelocity; // 0x48E
		private VisualElement m_CapturedTarget; // 0x490
		private EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback; // 0x498
		private EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback; // 0x4A0
		internal IVisualElementScheduledItem m_PostPointerUpAnimation; // 0x4A8
	
		// Properties
		public ScrollerVisibility horizontalScrollerVisibility { get => default; set {} } // 0x0000000183D89010-0x0000000183D89020 0x0000000189EFFAD8-0x0000000189EFFB1C
		public ScrollerVisibility verticalScrollerVisibility { get => default; set {} } // 0x0000000183D89060-0x0000000183D89070 0x0000000189EFFDA0-0x0000000189EFFDE4
		[Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
		public bool showHorizontal { set {} } // 0x0000000189EFFC90-0x0000000189EFFCB0
		[Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
		public bool showVertical { set {} } // 0x0000000189EFFCB0-0x0000000189EFFCD0
		internal bool needsHorizontal { get => default; } // 0x0000000189EFF854-0x0000000189EFF894 
		internal bool needsVertical { get => default; } // 0x0000000189EFF894-0x0000000189EFF8D4 
		internal bool isVerticalScrollDisplayed { get => default; } // 0x0000000189EFF82C-0x0000000189EFF854 
		internal bool isHorizontalScrollDisplayed { get => default; } // 0x0000000189EFF804-0x0000000189EFF82C 
		public Vector2 scrollOffset { get => default; set {} } // 0x0000000189EFF8D4-0x0000000189EFF924 0x0000000189EFFBC0-0x0000000189EFFC90
		public float horizontalPageSize { set {} } // 0x0000000189EFFAC8-0x0000000189EFFAD8
		public float verticalPageSize { set {} } // 0x0000000189EFFD90-0x0000000189EFFDA0
		public float mouseWheelScrollSize { get => default; set {} } // 0x0000000183D68DF0-0x0000000183D68E00 0x0000000189EFFB30-0x0000000189EFFBAC
		internal float scrollableWidth { get => default; } // 0x0000000189EFF990-0x0000000189EFF9FC 
		internal float scrollableHeight { get => default; } // 0x0000000189EFF924-0x0000000189EFF990 
		private bool hasInertia { get => default; } // 0x0000000189EFF7F0-0x0000000189EFF804 
		public float scrollDecelerationRate { get => default; set {} } // 0x0000000183D89040-0x0000000183D89050 0x0000000189EFFBAC-0x0000000189EFFBC0
		public float elasticity { get => default; set {} } // 0x0000000183D89000-0x0000000183D89010 0x0000000189EFFAB4-0x0000000189EFFAC8
		public TouchScrollBehavior touchScrollBehavior { get => default; set {} } // 0x0000000183D89050-0x0000000183D89060 0x0000000189EFFCD0-0x0000000189EFFD90
		public NestedInteractionKind nestedInteractionKind { get => default; set {} } // 0x0000000183D89030-0x0000000183D89040 0x0000000183D89070-0x0000000183D89080
		public long elasticAnimationIntervalMs { set {} } // 0x0000000189EFF9FC-0x0000000189EFFAB4
		public VisualElement contentViewport { get; } // 0x0000000183D570D0-0x0000000183D570E0 
		public Scroller horizontalScroller { get; } // 0x0000000183D57150-0x0000000183D57160 
		public Scroller verticalScroller { get; } // 0x0000000183D57320-0x0000000183D57330 
		public override VisualElement contentContainer { get => default; } // 0x0000000183D88FF0-0x0000000183D89000 
		public ScrollViewMode mode { get => default; set {} } // 0x0000000183D89020-0x0000000183D89030 0x0000000189EFFB1C-0x0000000189EFFB30
	
		// Nested types
		public class UxmlFactory : UxmlFactory<ScrollView, UxmlTraits> // TypeDefIndex: 43506
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F01938-0x0000000189F01974
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 43507
		{
			// Fields
			private UxmlEnumAttributeDescription<ScrollViewMode> m_ScrollViewMode; // 0x70
			private UxmlEnumAttributeDescription<NestedInteractionKind> m_NestedInteractionKind; // 0x78
			private UxmlBoolAttributeDescription m_ShowHorizontal; // 0x80
			private UxmlBoolAttributeDescription m_ShowVertical; // 0x88
			private UxmlEnumAttributeDescription<ScrollerVisibility> m_HorizontalScrollerVisibility; // 0x90
			private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility; // 0x98
			private UxmlFloatAttributeDescription m_HorizontalPageSize; // 0xA0
			private UxmlFloatAttributeDescription m_VerticalPageSize; // 0xA8
			private UxmlFloatAttributeDescription m_MouseWheelScrollSize; // 0xB0
			private UxmlEnumAttributeDescription<TouchScrollBehavior> m_TouchScrollBehavior; // 0xB8
			private UxmlFloatAttributeDescription m_ScrollDecelerationRate; // 0xC0
			private UxmlFloatAttributeDescription m_Elasticity; // 0xC8
			private UxmlLongAttributeDescription m_ElasticAnimationIntervalMs; // 0xD0
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F02B48-0x0000000189F03120
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F0236C-0x0000000189F026FC
		}
	
		public enum TouchScrollBehavior // TypeDefIndex: 43508
		{
			Unrestricted = 0,
			Elastic = 1,
			Clamped = 2
		}
	
		public enum NestedInteractionKind // TypeDefIndex: 43509
		{
			Default = 0,
			StopScrolling = 1,
			ForwardScrolling = 2
		}
	
		internal enum TouchScrollingResult // TypeDefIndex: 43510
		{
			Apply = 0,
			Forward = 1,
			Block = 2
		}
	
		// Constructors
		public ScrollView() {} // 0x0000000189EFF7E4-0x0000000189EFF7F0
		public ScrollView(ScrollViewMode scrollViewMode) {} // 0x0000000189EFEA90-0x0000000189EFF7E4
		static ScrollView() {} // 0x0000000189EFE520-0x0000000189EFEA90
	
		// Methods
		private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt) {} // 0x0000000189EFC610-0x0000000189EFC694
		private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt) {} // 0x0000000189EFD210-0x0000000189EFD294
		private void UpdateHorizontalSliderPageSize() {} // 0x0000000189EFE058-0x0000000189EFE130
		private void UpdateVerticalSliderPageSize() {} // 0x0000000189EFE448-0x0000000189EFE520
		internal void UpdateContentViewTransform() {} // 0x0000000189EFDE14-0x0000000189EFDF34
		public void ScrollTo(VisualElement child) {} // 0x0000000189EFD608-0x0000000189EFD800
		private float GetXDeltaOffset(VisualElement child) => default; // 0x0000000189EFB7A8-0x0000000189EFB914
		private float GetYDeltaOffset(VisualElement child) => default; // 0x0000000189EFB914-0x0000000189EFBA8C
		private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax) => default; // 0x0000000189EFB754-0x0000000189EFB7A8
		private void SetScrollViewMode(ScrollViewMode mode) {} // 0x0000000189EFD800-0x0000000189EFDBD8
		private void OnAttachToPanel(AttachToPanelEvent evt) {} // 0x0000000189EFBBE4-0x0000000189EFC064
		private void OnDetachFromPanel(DetachFromPanelEvent evt) {} // 0x0000000189EFC064-0x0000000189EFC4EC
		private void OnPointerCapture(PointerCaptureEvent evt) {} // 0x0000000189EFC7B8-0x0000000189EFC8A0
		private void OnPointerCaptureOut(PointerCaptureOutEvent evt) {} // 0x0000000189EFC6EC-0x0000000189EFC7B8
		private void OnGeometryChanged(GeometryChangedEvent evt) {} // 0x0000000189EFC4EC-0x0000000189EFC610
		private void ScheduleResetLayoutPass() {} // 0x0000000189EFD550-0x0000000189EFD608
		private void ResetLayoutPass() {} // 0x0000000183D88FE0-0x0000000183D88FF0
		private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit) => default; // 0x0000000189EFB0AC-0x0000000189EFB214
		private void ComputeInitialSpringBackVelocity() {} // 0x0000000189EFB214-0x0000000189EFB324
		private void SpringBack() {} // 0x0000000189EFDBD8-0x0000000189EFDD7C
		internal void ApplyScrollInertia() {} // 0x0000000189EFAB60-0x0000000189EFAE94
		private void PostPointerUpAnimation() {} // 0x0000000189EFD294-0x0000000189EFD394
		private void OnPointerDown(PointerDownEvent evt) {} // 0x0000000189EFC8A0-0x0000000189EFCA7C
		private void OnPointerMove(PointerMoveEvent evt) {} // 0x0000000189EFCA7C-0x0000000189EFCCD0
		private void OnPointerCancel(PointerCancelEvent evt) {} // 0x0000000189EFC694-0x0000000189EFC6EC
		private void OnPointerUp(PointerUpEvent evt) {} // 0x0000000189EFCCD0-0x0000000189EFCD58
		internal void InitTouchScrolling(Vector2 position) {} // 0x0000000189EFBA8C-0x0000000189EFBBE4
		internal TouchScrollingResult ComputeTouchScrolling(Vector2 position) => default; // 0x0000000189EFB324-0x0000000189EFB680
		private bool ApplyTouchScrolling(Vector2 newScrollOffset) => default; // 0x0000000189EFAE94-0x0000000189EFB0AC
		private bool ReleaseScrolling(int pointerId, IEventHandler target) => default; // 0x0000000189EFD478-0x0000000189EFD550
		private void ExecuteElasticSpringAnimation() {} // 0x0000000189EFB680-0x0000000189EFB754
		private void AdjustScrollers() {} // 0x0000000189EFA9FC-0x0000000189EFAB60
		internal void UpdateScrollers(bool displayHorizontal, bool displayVertical) {} // 0x0000000189EFE130-0x0000000189EFE448
		private void OnScrollersGeometryChanged(GeometryChangedEvent evt) {} // 0x0000000189EFD0C0-0x0000000189EFD210
		private void OnScrollWheel(WheelEvent evt) {} // 0x0000000189EFCD60-0x0000000189EFD0C0
		private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt) {} // 0x0000000189EFCD58-0x0000000189EFCD60
		private void OnRootPointerUp(PointerUpEvent evt) {} // 0x0000000183D88FD0-0x0000000183D88FE0
		private void ReadSingleLineHeight() {} // 0x0000000189EFD394-0x0000000189EFD478
		private void UpdateElasticBehaviour() {} // 0x0000000189EFDF34-0x0000000189EFE058
	}

	public class Slider : BaseSlider<float> // TypeDefIndex: 43514
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Slider, UxmlTraits> // TypeDefIndex: 43512
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F019B0-0x0000000189F019EC
		}
	
		public class UxmlTraits : BaseFieldTraits<float, UxmlFloatAttributeDescription> // TypeDefIndex: 43513
		{
			// Fields
			private UxmlFloatAttributeDescription m_LowValue; // 0x88
			private UxmlFloatAttributeDescription m_HighValue; // 0x90
			private UxmlFloatAttributeDescription m_PageSize; // 0x98
			private UxmlBoolAttributeDescription m_ShowInputField; // 0xA0
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction; // 0xA8
			private UxmlBoolAttributeDescription m_Inverted; // 0xB0
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F031D8-0x0000000189F03490
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F01E74-0x0000000189F020CC
		}
	
		// Constructors
		public Slider() {} // 0x0000000189F01828-0x0000000189F01854
		public Slider(float start, float end, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x01FB5F39 */, float pageSize = 0f /* Metadata: 0x01FB5F3A */) {} // 0x0000000189F01854-0x0000000189F01884
		public Slider(string label, float start = 0f /* Metadata: 0x01FB5F3E */, float end = 10f /* Metadata: 0x01FB5F42 */, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x01FB5F46 */, float pageSize = 0f /* Metadata: 0x01FB5F47 */) {} // 0x0000000189F016E8-0x0000000189F01828
		static Slider() {} // 0x0000000189F015E0-0x0000000189F016E8
	
		// Methods
		internal override float SliderLerpUnclamped(float a, float b, float interpolant) => default; // 0x0000000189F01470-0x0000000189F015E0
		internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) => default; // 0x0000000189EF81C4-0x0000000189EF81D8
		internal override float ParseStringToValue(string stringValue) => default; // 0x0000000189F013B8-0x0000000189F01470
		internal override void ComputeValueFromKey(SliderKey<float> sliderKey, bool isShift) {} // 0x0000000189F01224-0x0000000189F013B8
	}

	public class SliderInt : BaseSlider<int> // TypeDefIndex: 43517
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
	
		// Properties
		public override float pageSize { get => default; set {} } // 0x0000000189F01194-0x0000000189F011D4 0x0000000189F011D4-0x0000000189F01224
	
		// Nested types
		public class UxmlFactory : UxmlFactory<SliderInt, UxmlTraits> // TypeDefIndex: 43515
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F15084-0x0000000189F150C0
		}
	
		public class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription> // TypeDefIndex: 43516
		{
			// Fields
			private UxmlIntAttributeDescription m_LowValue; // 0x88
			private UxmlIntAttributeDescription m_HighValue; // 0x90
			private UxmlIntAttributeDescription m_PageSize; // 0x98
			private UxmlBoolAttributeDescription m_ShowInputField; // 0xA0
			private UxmlEnumAttributeDescription<SliderDirection> m_Direction; // 0xA8
			private UxmlBoolAttributeDescription m_Inverted; // 0xB0
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F15ED0-0x0000000189F16188
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F151E0-0x0000000189F15430
		}
	
		// Constructors
		public SliderInt() {} // 0x0000000189F0102C-0x0000000189F0105C
		public SliderInt(string label, int start = 0 /* Metadata: 0x01FB5F4B */, int end = 10 /* Metadata: 0x01FB5F4C */, SliderDirection direction = SliderDirection.Horizontal /* Metadata: 0x01FB5F4D */, float pageSize = 0f /* Metadata: 0x01FB5F4E */) {} // 0x0000000189F0105C-0x0000000189F01194
		static SliderInt() {} // 0x0000000189F00F24-0x0000000189F0102C
	
		// Methods
		internal override int SliderLerpUnclamped(int a, int b, float interpolant) => default; // 0x0000000189F00ED4-0x0000000189F00EF4
		internal override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue) => default; // 0x0000000189F00EF4-0x0000000189F00F24
		internal override int ParseStringToValue(string stringValue) => default; // 0x0000000189F00EA4-0x0000000189F00ED4
		internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) {} // 0x0000000189F00AC8-0x0000000189F00CFC
		internal override void ComputeValueFromKey(SliderKey<int> sliderKey, bool isShift) {} // 0x0000000189F00CFC-0x0000000189F00EA4
	}

	internal class TextEditorEventHandler // TypeDefIndex: 43518
	{
		// Properties
		protected TextEditorEngine editorEngine { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		protected ITextInputField textInputField { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public TextEditorEventHandler() {} // Dummy constructor
		protected TextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField) {} // 0x0000000189F11248-0x0000000189F11284
	
		// Methods
		public virtual void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x000000018350B670-0x000000018350B680
		public virtual void ExecuteDefaultAction(EventBase evt) {} // 0x0000000189F11130-0x0000000189F11248
	}

	internal class TextEditorEngine : TextEditor // TypeDefIndex: 43521
	{
		// Fields
		private OnDetectFocusChangeFunction m_DetectFocusChangeFunction; // 0x90
		private OnIndexChangeFunction m_IndexChangeFunction; // 0x98
	
		// Properties
		internal override Rect localPosition { get => default; } // 0x0000000183D890E0-0x0000000183D89120 
	
		// Nested types
		internal delegate void OnDetectFocusChangeFunction(); // TypeDefIndex: 43519; 0x00000001842BE03C-0x00000001842BE04C
	
		internal delegate void OnIndexChangeFunction(); // TypeDefIndex: 43520; 0x00000001842BE03C-0x00000001842BE04C
	
		// Constructors
		public TextEditorEngine() {} // Dummy constructor
		public TextEditorEngine(OnDetectFocusChangeFunction detectFocusChange, OnIndexChangeFunction indexChangeFunction) {} // 0x0000000189F110DC-0x0000000189F11130
	
		// Methods
		internal override void OnDetectFocusChange() {} // 0x0000000189F110B4-0x0000000189F110DC
		internal override void OnCursorIndexChange() {} // 0x0000000189F1108C-0x0000000189F110B4
		internal override void OnSelectIndexChange() {} // 0x0000000189F1108C-0x0000000189F110B4
	}

	public class TextField : TextInputBaseField<string> // TypeDefIndex: 43525
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
	
		// Properties
		private TextInput textInput { get => default; } // 0x0000000189F11680-0x0000000189F116CC 
		public bool multiline { set {} } // 0x0000000189F11708-0x0000000189F11738
		public override string value { get => default; set {} } // 0x0000000189F116CC-0x0000000189F11708 0x0000000189F11738-0x0000000189F117B0
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TextField, UxmlTraits> // TypeDefIndex: 43522
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F14F94-0x0000000189F14FD0
		}
	
		public class UxmlTraits : TextInputBaseField<string> // TypeDefIndex: 43523
		{
			// Fields
			private static readonly UxmlStringAttributeDescription k_Value; // 0x00
			private UxmlBoolAttributeDescription m_Multiline; // 0xB8
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F15A90-0x0000000189F15B38
			static UxmlTraits() {} // 0x0000000189F15998-0x0000000189F15A90
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F15578-0x0000000189F156F0
		}
	
		private class TextInput : TextInputBaseField<string> // TypeDefIndex: 43524
		{
			// Fields
			private bool m_Multiline; // 0x420
	
			// Properties
			private TextField parentTextField { get => default; } // 0x0000000189F120D8-0x0000000189F12118 
			public bool multiline { get => default; set {} } // 0x0000000183D89130-0x0000000183D89140 0x0000000189F12168-0x0000000189F12214
			public override bool isPasswordField { set {} } // 0x0000000189F12118-0x0000000189F12168
	
			// Constructors
			public TextInput() {} // 0x0000000189F1209C-0x0000000189F120D8
	
			// Methods
			private void SetTextAlign() {} // 0x0000000189F11F5C-0x0000000189F1200C
			protected override string StringToValue(string str) => default; // 0x0000000183D89120-0x0000000183D89130
			internal override void SyncTextEngine() {} // 0x0000000189F1200C-0x0000000189F1209C
			protected override void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x0000000189F117B0-0x0000000189F11DF8
			protected override void ExecuteDefaultAction(EventBase evt) {} // 0x0000000189F11DF8-0x0000000189F11F5C
		}
	
		// Constructors
		public TextField() {} // 0x0000000189F11674-0x0000000189F11680
		public TextField(string label) {} // 0x0000000189F11648-0x0000000189F11674
		public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar) {} // 0x0000000189F11488-0x0000000189F11648
		static TextField() {} // 0x0000000189F11380-0x0000000189F11488
	
		// Methods
		public override void SetValueWithoutNotify(string newValue) {} // 0x0000000189F11308-0x0000000189F11380
		internal override void OnViewDataReady() {} // 0x0000000189F11284-0x0000000189F11308
	}

	internal interface ITextInputField : IEventHandler, ITextElement // TypeDefIndex: 43526
	{
		// Properties
		bool hasFocus { get; }
		bool doubleClickSelectsWord { get; }
		bool tripleClickSelectsLine { get; }
		bool isReadOnly { get; }
		bool isDelayed { get; }
		bool isPasswordField { get; }
		TextEditorEngine editorEngine { get; }
	
		// Methods
		void SyncTextEngine();
		bool AcceptCharacter(char c);
		string CullString(string s);
		void UpdateText(string value);
		void UpdateValueFromText();
	}

	public abstract class TextInputBaseField<TValueType> : BaseField<TValueType> // TypeDefIndex: 43529
	{
		// Fields
		private static CustomStyleProperty<UnityEngine.Color> s_SelectionColorProperty;
		private static CustomStyleProperty<UnityEngine.Color> s_CursorColorProperty;
		private int m_VisualInputTabIndex;
		private TextInputBase m_TextInputBase;
		public static readonly string ussClassName;
		public static readonly string labelUssClassName;
		public static readonly string inputUssClassName;
		public static readonly string singleLineInputUssClassName;
		public static readonly string multilineInputUssClassName;
		public static readonly string textInputUssName;
	
		// Properties
		protected internal TextInputBase textInputBase { get; }
		private ITextHandle iTextHandle { get; set; }
		public string text { get; set; }
		public bool isReadOnly { get; set; }
		public bool isPasswordField { get; set; }
		public int maxLength { get; set; }
		public bool isDelayed { get; set; }
		public char maskChar { get; set; }
	
		// Nested types
		public class UxmlTraits : BaseFieldTraits<string, UxmlStringAttributeDescription> // TypeDefIndex: 43527
		{
			// Fields
			private UxmlIntAttributeDescription m_MaxLength;
			private UxmlBoolAttributeDescription m_Password;
			private UxmlStringAttributeDescription m_MaskCharacter;
			private UxmlStringAttributeDescription m_Text;
			private UxmlBoolAttributeDescription m_IsReadOnly;
			private UxmlBoolAttributeDescription m_IsDelayed;
	
			// Constructors
			public UxmlTraits() {}
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {}
		}
	
		protected internal abstract class TextInputBase : VisualElement, ITextInputField // TypeDefIndex: 43528
		{
			// Fields
			private string m_OriginalText;
			private bool m_TouchScreenTextFieldInitialized;
			private IVisualElementScheduledItem m_HardwareKeyboardPoller;
			private UnityEngine.Color m_SelectionColor;
			private UnityEngine.Color m_CursorColor;
			private ITextHandle m_TextHandle;
			private string m_Text;
	
			// Properties
			bool ITextInputField.isReadOnly { get; }
			public bool isReadOnly { get; set; }
			public int maxLength { get; set; }
			public char maskChar { get; set; }
			public virtual bool isPasswordField { get; set; }
			public bool doubleClickSelectsWord { get; set; }
			public bool tripleClickSelectsLine { get; set; }
			internal bool isDelayed { get; set; }
			internal bool isDragging { get; }
			private bool touchScreenTextField { get; }
			private bool touchScreenTextFieldChanged { get; }
			public UnityEngine.Color selectionColor { get; }
			public UnityEngine.Color cursorColor { get; }
			internal bool hasFocus { get; }
			internal TextEditorEventHandler editorEventHandler { get; private set; }
			internal TextEditorEngine editorEngine { get; private set; }
			public string text { get; set; }
			bool ITextInputField.hasFocus { get; }
			TextEditorEngine ITextInputField.editorEngine { get; }
			bool ITextInputField.isDelayed { get; }
	
			// Constructors
			internal TextInputBase() {}
	
			// Methods
			public void ResetValueAndText() {}
			private void SaveValueAndText() {}
			private void RestoreValueAndText() {}
			private void UpdateText(string value) {}
			protected virtual TValueType StringToValue(string str) => default;
			internal void UpdateValueFromText() {}
			private void InitTextEditorEventHandler() {}
			private DropdownMenuAction.Status CutActionStatus(DropdownMenuAction a) => default;
			private DropdownMenuAction.Status CopyActionStatus(DropdownMenuAction a) => default;
			private DropdownMenuAction.Status PasteActionStatus(DropdownMenuAction a) => default;
			private void ProcessMenuCommand(string command) {}
			private void Cut(DropdownMenuAction a) {}
			private void Copy(DropdownMenuAction a) {}
			private void Paste(DropdownMenuAction a) {}
			internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e) {}
			private void OnAttachToPanel(AttachToPanelEvent attachEvent) {}
			internal virtual void SyncTextEngine() {}
			internal string CullString(string s) => default;
			internal void OnGenerateVisualContent(MeshGenerationContext mgc) {}
			internal void DrawWithTextSelectionAndCursor(MeshGenerationContext mgc, string newText, float pixelsPerPoint) {}
			internal virtual bool AcceptCharacter(char c) => default;
			protected virtual void BuildContextualMenu(ContextualMenuPopulateEvent evt) {}
			private void OnDetectFocusChange() {}
			private void OnCursorIndexChange() {}
			protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) => default;
			internal override void ExecuteDefaultActionDisabledAtTarget(EventBase evt) {}
			protected override void ExecuteDefaultActionAtTarget(EventBase evt) {}
			private void ProcessEventAtTarget(EventBase evt) {}
			protected override void ExecuteDefaultAction(EventBase evt) {}
			void ITextInputField.SyncTextEngine() {}
			bool ITextInputField.AcceptCharacter(char c) => default;
			string ITextInputField.CullString(string s) => default;
			void ITextInputField.UpdateText(string value) {}
			void ITextInputField.UpdateValueFromText() {}
			private void DeferGUIStyleRectSync() {}
			private void OnPercentResolved(GeometryChangedEvent evt) {}
			private static void SyncGUIStyle(TextInputBase<TValueType> textInput, GUIStyle style) {}
			private static bool IsLayoutUsingPercent(VisualElement ve) => default;
			private static void AssignRect(RectOffset rect, int left, int top, int right, int bottom) {}
		}
	
		// Constructors
		protected TextInputBaseField() {} // Dummy constructor
		protected TextInputBaseField(string label, int maxLength, char maskChar, TextInputBase textInputBase) {}
		static TextInputBaseField() {}
	
		// Methods
		private new void OnAttachToPanel(AttachToPanelEvent e) {}
		private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e) {}
		protected override void ExecuteDefaultActionAtTarget(EventBase evt) {}
		protected override void UpdateMixedValueContent() {}
	}

	public class Toggle : BaseBoolField // TypeDefIndex: 43532
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string labelUssClassName; // 0x08
		public static readonly string inputUssClassName; // 0x10
		[Obsolete]
		public static readonly string noTextVariantUssClassName; // 0x18
		public static readonly string checkmarkUssClassName; // 0x20
		public static readonly string textUssClassName; // 0x28
	
		// Nested types
		public class UxmlFactory : UxmlFactory<Toggle, UxmlTraits> // TypeDefIndex: 43530
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F14FD0-0x0000000189F1500C
		}
	
		public class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription> // TypeDefIndex: 43531
		{
			// Fields
			private UxmlStringAttributeDescription m_Text; // 0x88
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F16190-0x0000000189F163B8
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F150FC-0x0000000189F151E0
		}
	
		// Constructors
		public Toggle() {} // 0x0000000189F12584-0x0000000189F12590
		public Toggle(string label) {} // 0x0000000189F12488-0x0000000189F12584
		static Toggle() {} // 0x0000000189F12284-0x0000000189F12488
	
		// Methods
		protected override void InitLabel() {} // 0x0000000189F12214-0x0000000189F12284
	}

	internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler // TypeDefIndex: 43533
	{
		// Fields
		private IVisualElementScheduledItem m_TouchKeyboardPoller; // 0x20
		private VisualElement m_LastPointerDownTarget; // 0x28
	
		// Constructors
		public TouchScreenTextEditorEventHandler() {} // Dummy constructor
		public TouchScreenTextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField) {} // 0x0000000189F12BB0-0x0000000189F12BE8
	
		// Methods
		private void PollTouchScreenKeyboard() {} // 0x0000000189F12AB0-0x0000000189F12BB0
		private void DoPollTouchScreenKeyboard() {} // 0x0000000189F12590-0x0000000189F12758
		public override void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x0000000189F12758-0x0000000189F12AB0
	}

	public class TreeView : BaseTreeView // TypeDefIndex: 43536
	{
		// Fields
		private Func<VisualElement> m_MakeItem; // 0x4B8
		private Action<VisualElement, int> m_BindItem; // 0x4C0
	
		// Properties
		public Func<VisualElement> makeItem { get => default; set {} } // 0x0000000183D57340-0x0000000183D57350 0x0000000189F12DB4-0x0000000189F12E04
		public Action<VisualElement, int> bindItem { get => default; set {} } // 0x0000000183D572F0-0x0000000183D57300 0x0000000189F12D64-0x0000000189F12DB4
		public Action<VisualElement, int> unbindItem { get; } // 0x0000000183D6C890-0x0000000183D6C8A0 
		public Action<VisualElement> destroyItem { get; } // 0x0000000183D5A3B0-0x0000000183D5A3C0 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TreeView, UxmlTraits> // TypeDefIndex: 43534
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F14F58-0x0000000189F14F94
		}
	
		public class UxmlTraits : BaseTreeView.UxmlTraits // TypeDefIndex: 43535
		{
			// Constructors
			public UxmlTraits() {} // 0x0000000189F16188-0x0000000189F16190
		}
	
		// Constructors
		public TreeView() {} // 0x0000000189F12CD8-0x0000000189F12CE8
		public TreeView(Func<VisualElement> makeItem, Action<VisualElement, int> bindItem) {} // 0x0000000189F12CE8-0x0000000189F12D64
	
		// Methods
		internal override bool HasValidDataAndBindings() => default; // 0x0000000189F12C9C-0x0000000189F12CD8
		protected override CollectionViewController CreateViewController() => default; // 0x0000000189F12C40-0x0000000189F12C9C
	}

	[IsReadOnly]
	internal struct TreeData<T> // TypeDefIndex: 43537
	{
		// Fields
		private readonly IList<int> m_RootItemIds;
		private readonly Dictionary<int, TreeViewItemData<T>> m_Tree;
		private readonly Dictionary<int, int> m_ParentIds;
		private readonly Dictionary<int, List<int>> m_ChildrenIds;
	
		// Properties
		public IEnumerable<int> rootItemIds { get => default; }
	
		// Constructors
		public TreeData(IList<TreeViewItemData<T>> rootItems) : this() {
			m_RootItemIds = default;
			m_Tree = default;
			m_ParentIds = default;
			m_ChildrenIds = default;
		}
	
		// Methods
		public TreeViewItemData<T> GetDataForId(int id) => default;
		public int GetParentId(int id) => default;
		public void Move(int id, int newParentId, int childIndex) {}
		public bool HasAncestor(int childId, int ancestorId) => default;
		private void AddItemToParent(TreeViewItemData<T> item, int parentId, int childIndex) {}
		private void RemoveFromParent(int id, int parentId) {}
		private void UpdateParentTree(TreeViewItemData<T> current) {}
		private void RefreshTree(IList<TreeViewItemData<T>> rootItems) {}
		private void BuildTree(IEnumerable<TreeViewItemData<T>> items, bool isRoot) {}
	}

	[IsReadOnly]
	internal struct TreeItem // TypeDefIndex: 43538
	{
		// Properties
		public int id { get; } // 0x0000000183D4E980-0x0000000183D4E990 
		public int parentId { get; } // 0x0000000183D4E990-0x0000000183D4E9A0 
		public IEnumerable<int> childrenIds { get; } // 0x0000000183D50DE0-0x0000000183D50DF0 
		public bool hasChildren { get => default; } // 0x0000000189F12BE8-0x0000000189F12C38 
	
		// Constructors
		public TreeItem(int id, int parentId = -1 /* Metadata: 0x01FB5F52 */, IEnumerable<int> childrenIds = null) : this() {} // 0x00000001842713DC-0x00000001842713F0
	}

	[IsReadOnly]
	internal struct TreeViewItemWrapper // TypeDefIndex: 43539
	{
		// Fields
		public readonly TreeItem item; // 0x00
		public readonly int depth; // 0x10
	
		// Properties
		public int id { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
		public IEnumerable<int> childrenIds { get => default; } // 0x0000000183D50DE0-0x0000000183D50DF0 
		public bool hasChildren { get => default; } // 0x0000000189F12C38-0x0000000189F12C40 
	
		// Constructors
		public TreeViewItemWrapper(TreeItem item, int depth) : this() {
			this.item = default;
			this.depth = default;
		} // 0x00000001871AF1D4-0x00000001871AF1F8
	}

	[IsReadOnly]
	public struct TreeViewItemData<T> // TypeDefIndex: 43540
	{
		// Fields
		private readonly T m_Data;
		private readonly IList<TreeViewItemData<T>> m_Children;
	
		// Properties
		public int id { get; }
		public T data { get => default; }
		public IEnumerable<TreeViewItemData<T>> children { get => default; }
		public bool hasChildren { get => default; }
	
		// Methods
		internal void InsertChild(TreeViewItemData<T> child, int index) {}
		internal void RemoveChild(int childId) {}
		internal int GetChildIndex(int itemId) => default;
		internal void ReplaceChild(TreeViewItemData<T> newChild) {}
	}

	public class TwoPaneSplitView : VisualElement // TypeDefIndex: 43543
	{
		// Fields
		private static readonly string s_UssClassName; // 0x00
		private static readonly string s_ContentContainerClassName; // 0x08
		private static readonly string s_HandleDragLineClassName; // 0x10
		private static readonly string s_HandleDragLineVerticalClassName; // 0x18
		private static readonly string s_HandleDragLineHorizontalClassName; // 0x20
		private static readonly string s_HandleDragLineAnchorClassName; // 0x28
		private static readonly string s_HandleDragLineAnchorVerticalClassName; // 0x30
		private static readonly string s_HandleDragLineAnchorHorizontalClassName; // 0x38
		private static readonly string s_VerticalClassName; // 0x40
		private static readonly string s_HorizontalClassName; // 0x48
		private VisualElement m_LeftPane; // 0x3C0
		private VisualElement m_RightPane; // 0x3C8
		private VisualElement m_FixedPane; // 0x3D0
		private VisualElement m_FlexedPane; // 0x3D8
		[SerializeField]
		private float m_FixedPaneDimension; // 0x3E0
		private VisualElement m_DragLine; // 0x3E8
		private VisualElement m_DragLineAnchor; // 0x3F0
		private bool m_CollapseMode; // 0x3F8
		private VisualElement m_Content; // 0x400
		private TwoPaneSplitViewOrientation m_Orientation; // 0x408
		private int m_FixedPaneIndex; // 0x40C
		private float m_FixedPaneInitialDimension; // 0x410
		internal TwoPaneSplitViewResizer m_Resizer; // 0x418
	
		// Properties
		public VisualElement fixedPane { get => default; } // 0x0000000183D55EC0-0x0000000183D55ED0 
		public VisualElement flexedPane { get => default; } // 0x0000000183D55ED0-0x0000000183D55EE0 
		public int fixedPaneIndex { get => default; } // 0x0000000183D89150-0x0000000183D89160 
		internal float fixedPaneDimension { get => default; set {} } // 0x0000000189F14E5C-0x0000000189F14E80 0x0000000189F14E80-0x0000000189F14E9C
		public override VisualElement contentContainer { get => default; } // 0x0000000183D89140-0x0000000183D89150 
	
		// Nested types
		public class UxmlFactory : UxmlFactory<TwoPaneSplitView, UxmlTraits> // TypeDefIndex: 43541
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F15048-0x0000000189F15084
		}
	
		public class UxmlTraits : VisualElement.UxmlTraits // TypeDefIndex: 43542
		{
			// Fields
			private UxmlIntAttributeDescription m_FixedPaneIndex; // 0x70
			private UxmlIntAttributeDescription m_FixedPaneInitialDimension; // 0x78
			private UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation; // 0x80
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F15B38-0x0000000189F15CB0
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F156F0-0x0000000189F15850
		}
	
		// Constructors
		public TwoPaneSplitView() {} // 0x0000000189F14BDC-0x0000000189F14E5C
		static TwoPaneSplitView() {} // 0x0000000189F14914-0x0000000189F14BDC
	
		// Methods
		internal void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation) {} // 0x0000000189F137E4-0x0000000189F13B3C
		private void OnPostDisplaySetup(GeometryChangedEvent evt) {} // 0x0000000189F13B3C-0x0000000189F13C24
		private void PostDisplaySetup() {} // 0x0000000189F13E38-0x0000000189F14794
		private void OnSizeChange(GeometryChangedEvent evt) {} // 0x0000000189F13E00-0x0000000189F13E08
		private void OnSizeChange() {} // 0x0000000189F13C24-0x0000000189F13E00
		internal override void OnViewDataReady() {} // 0x0000000189F13E08-0x0000000189F13E38
		private void SetDragLineOffset(float offset) {} // 0x0000000189F14794-0x0000000189F14854
		private void SetFixedPaneDimension(float dimension) {} // 0x0000000189F14854-0x0000000189F14914
	}

	public enum TwoPaneSplitViewOrientation // TypeDefIndex: 43544
	{
		Horizontal = 0,
		Vertical = 1
	}

	internal class TwoPaneSplitViewResizer : PointerManipulator // TypeDefIndex: 43545
	{
		// Fields
		private Vector3 m_Start; // 0x38
		protected bool m_Active; // 0x44
		private TwoPaneSplitView m_SplitView; // 0x48
		private int m_Direction; // 0x50
		private TwoPaneSplitViewOrientation m_Orientation; // 0x54
	
		// Properties
		private VisualElement fixedPane { get => default; } // 0x0000000189F13754-0x0000000189F13774 
		private VisualElement flexedPane { get => default; } // 0x0000000189F137C4-0x0000000189F137E4 
		private float fixedPaneMinDimension { get => default; } // 0x0000000189F13704-0x0000000189F13754 
		private float flexedPaneMinDimension { get => default; } // 0x0000000189F13774-0x0000000189F137C4 
	
		// Constructors
		public TwoPaneSplitViewResizer() {} // Dummy constructor
		public TwoPaneSplitViewResizer(TwoPaneSplitView splitView, int dir, TwoPaneSplitViewOrientation orientation) {} // 0x0000000189F13650-0x0000000189F13704
	
		// Methods
		protected override void RegisterCallbacksOnTarget() {} // 0x0000000189F13348-0x0000000189F134CC
		protected override void UnregisterCallbacksFromTarget() {} // 0x0000000189F134CC-0x0000000189F13650
		public void ApplyDelta(float delta) {} // 0x0000000189F12E04-0x0000000189F1310C
		protected void OnPointerDown(PointerDownEvent e) {} // 0x0000000189F1310C-0x0000000189F131B8
		protected void OnPointerMove(PointerMoveEvent e) {} // 0x0000000189F131B8-0x0000000189F132BC
		protected void OnPointerUp(PointerUpEvent e) {} // 0x0000000189F132BC-0x0000000189F13348
	}

	internal enum ColumnDataType // TypeDefIndex: 43546
	{
		Name = 0,
		Title = 1,
		Icon = 2,
		Visibility = 3,
		Width = 4,
		MaxWidth = 5,
		MinWidth = 6,
		Stretchable = 7,
		Sortable = 8,
		Optional = 9,
		Resizable = 10,
		HeaderTemplate = 11,
		CellTemplate = 12
	}

	public class Column // TypeDefIndex: 43551
	{
		// Fields
		private static readonly string k_InvalidTemplateError; // 0x00
		private string m_Name; // 0x10
		private string m_Title; // 0x18
		private Background m_Icon; // 0x20
		private bool m_Visible; // 0x40
		private Length m_Width; // 0x44
		private Length m_MinWidth; // 0x4C
		private Length m_MaxWidth; // 0x54
		private float m_DesiredWidth; // 0x5C
		private bool m_Stretchable; // 0x60
		private bool m_Sortable; // 0x61
		private bool m_Optional; // 0x62
		private bool m_Resizable; // 0x63
		private Func<VisualElement> m_MakeHeader; // 0x68
		private Action<VisualElement> m_BindHeader; // 0x70
		private Action<VisualElement> m_UnbindHeader; // 0x78
		private Action<VisualElement> m_DestroyHeader; // 0x80
		private Func<VisualElement> m_MakeCell; // 0x88
		private Action<VisualElement, int> m_BindCell; // 0x90
		private Action<VisualElement, int> m_UnbindCellItem; // 0x98
	
		// Properties
		public string name { get => default; set {} } // 0x00000001820B7B20-0x00000001820B7B30 0x0000000189F0821C-0x0000000189F08264
		public string title { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000189F082C4-0x0000000189F0830C
		public Background icon { get => default; } // 0x0000000183D890A0-0x0000000183D890C0 
		internal int index { get => default; } // 0x0000000189F07F04-0x0000000189F07F30 
		internal int displayIndex { get => default; } // 0x0000000189F07E88-0x0000000189F07F04 
		internal int visibleIndex { get => default; } // 0x0000000189F07F30-0x0000000189F07FAC 
		public bool visible { get => default; set {} } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000189F0830C-0x0000000189F08324
		public Length width { get => default; set {} } // 0x0000000183D890D0-0x0000000183D890E0 0x0000000189F08324-0x0000000189F08378
		public Length minWidth { get => default; set {} } // 0x0000000183D56700-0x0000000183D56710 0x0000000189F081DC-0x0000000189F0821C
		public Length maxWidth { get => default; set {} } // 0x0000000183D890C0-0x0000000183D890D0 0x0000000189F0819C-0x0000000189F081DC
		internal float desiredWidth { get => default; set {} } // 0x0000000183D56C10-0x0000000183D56C20 0x0000000189F080CC-0x0000000189F08100
		public bool sortable { get => default; set {} } // 0x0000000183D51F90-0x0000000183D51FA0 0x0000000189F08294-0x0000000189F082AC
		public bool stretchable { get => default; set {} } // 0x0000000183D519A0-0x0000000183D519B0 0x0000000189F082AC-0x0000000189F082C4
		public bool optional { get => default; set {} } // 0x0000000183D5B400-0x0000000183D5B410 0x0000000189F08264-0x0000000189F0827C
		public bool resizable { get => default; set {} } // 0x0000000183D5B3F0-0x0000000183D5B400 0x0000000189F0827C-0x0000000189F08294
		public Func<VisualElement> makeHeader { get => default; set {} } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x0000000189F08154-0x0000000189F0819C
		public Action<VisualElement> bindHeader { get => default; } // 0x0000000183D4EB30-0x0000000183D4EB40 
		public Action<VisualElement> unbindHeader { get => default; } // 0x0000000183D4EB20-0x0000000183D4EB30 
		public Action<VisualElement> destroyHeader { get => default; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 
		public Func<VisualElement> makeCell { get => default; set {} } // 0x0000000183D4EA60-0x0000000183D4EA70 0x0000000189F08100-0x0000000189F08154
		public Action<VisualElement, int> bindCell { get => default; } // 0x0000000183D4EA90-0x0000000183D4EAA0 
		public Action<VisualElement, int> unbindCell { get => default; } // 0x00000001811AC510-0x00000001811AC520 
		public Action<VisualElement> destroyCell { get; } // 0x0000000183D4EA80-0x0000000183D4EA90 
		public Columns collection { get; internal set; } // 0x0000000183D4EB10-0x0000000183D4EB20 0x000000018554A7F4-0x000000018554A808
	
		// Events
		internal event Action<Column, ColumnDataType> changed;
		internal event Action<Column> resized;
	
		// Nested types
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 43547
			where T : Column, new()
		{
			// Constructors
			public UxmlObjectFactory() {}
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 43550
			where T : Column
		{
			// Fields
			private UxmlStringAttributeDescription m_Name;
			private UxmlStringAttributeDescription m_Text;
			private UxmlBoolAttributeDescription m_Visible;
			private UxmlStringAttributeDescription m_Width;
			private UxmlStringAttributeDescription m_MinWidth;
			private UxmlStringAttributeDescription m_MaxWidth;
			private UxmlBoolAttributeDescription m_Stretch;
			private UxmlBoolAttributeDescription m_Sortable;
			private UxmlBoolAttributeDescription m_Optional;
			private UxmlBoolAttributeDescription m_Resizable;
			private UxmlStringAttributeDescription m_HeaderTemplateId;
			private UxmlStringAttributeDescription m_CellTemplateId;
	
			// Constructors
			public UxmlObjectTraits() {}
	
			// Methods
			private static Length ParseLength(string str, Length defaultValue) => default;
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc) {}
		}
	
		// Constructors
		public Column() {} // 0x0000000189F07D10-0x0000000189F07D68
		static Column() {} // 0x0000000189F07CB4-0x0000000189F07D10
	
		// Methods
		private void NotifyChange(ColumnDataType type) {} // 0x0000000189F07C94-0x0000000189F07CB4
		internal float GetWidth(float layoutWidth) => default; // 0x0000000189F07C6C-0x0000000189F07C94
		internal float GetMaxWidth(float layoutWidth) => default; // 0x0000000189F07C1C-0x0000000189F07C44
		internal float GetMinWidth(float layoutWidth) => default; // 0x0000000189F07C44-0x0000000189F07C6C
	}

	internal class ColumnLayout // TypeDefIndex: 43554
	{
		// Fields
		private List<Column> m_StretchableColumns; // 0x10
		private List<Column> m_FixedColumns; // 0x18
		private List<Column> m_RelativeWidthColumns; // 0x20
		private List<Column> m_MixedWidthColumns; // 0x28
		private Columns m_Columns; // 0x30
		private float m_ColumnsWidth; // 0x38
		private bool m_ColumnsWidthDirty; // 0x3C
		private float m_MaxColumnsWidth; // 0x40
		private float m_MinColumnsWidth; // 0x44
		private bool m_IsDirty; // 0x48
		private float m_PreviousWidth; // 0x4C
		private float m_LayoutWidth; // 0x50
		private bool m_DragResizeInPreviewMode; // 0x54
		private bool m_DragResizing; // 0x55
		private float m_DragStartPos; // 0x58
		private float m_DragLastPos; // 0x5C
		private float m_DragInitialColumnWidth; // 0x60
		private List<Column> m_DragStretchableColumns; // 0x68
		private List<Column> m_DragRelativeColumns; // 0x70
		private List<Column> m_DragFixedColumns; // 0x78
		private Dictionary<Column, float> m_PreviewDesiredWidths; // 0x80
	
		// Properties
		public Columns columns { get => default; } // 0x0000000181003830-0x0000000181003840 
		public float columnsWidth { get => default; } // 0x0000000189F07978-0x0000000189F07AE4 
		public float layoutWidth { get => default; } // 0x0000000183D51C90-0x0000000183D51CA0 
		public float minColumnsWidth { get => default; } // 0x0000000183D4EC80-0x0000000183D4EC90 
		public float maxColumnsWidth { get => default; } // 0x0000000183D4EC70-0x0000000183D4EC80 
		public bool hasStretchableColumns { get => default; } // 0x0000000189F07B40-0x0000000189F07B84 
		public bool hasRelativeWidthColumns { get => default; } // 0x0000000189F07AE4-0x0000000189F07B40 
	
		// Events
		public event Action layoutRequested;
	
		// Constructors
		public ColumnLayout() {} // Dummy constructor
		public ColumnLayout(Columns columns) {} // 0x0000000189F075C4-0x0000000189F078E0
	
		// Methods
		public void Dirty() {} // 0x0000000189F04688-0x0000000189F046C0
		private void OnColumnAdded(Column column, int index) {} // 0x0000000189F05D8C-0x0000000189F05E74
		private void OnColumnRemoved(Column column) {} // 0x0000000189F05EA4-0x0000000189F05F8C
		private void OnColumnReordered(Column column, int from, int to) {} // 0x0000000189F05F8C-0x0000000189F05F94
		private bool RequiresLayoutUpdate(ColumnDataType type) => default; // 0x0000000189F06B80-0x0000000189F06B98
		private void OnColumnChanged(Column column, ColumnDataType type) {} // 0x0000000189F05E74-0x0000000189F05EA4
		private void OnColumnResized(Column column) {} // 0x0000000183D89090-0x0000000183D890A0
		private static bool IsClamped(float value, float min, float max) => default; // 0x0000000189F05D7C-0x0000000189F05D8C
		public void DoLayout(float width) {} // 0x0000000189F049E4-0x0000000189F056E8
		public void StretchResizeColumns(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) {} // 0x0000000189F07048-0x0000000189F07108
		private void DistributeOverflow(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) {} // 0x0000000189F04824-0x0000000189F049E4
		private void DistributeExcess(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) {} // 0x0000000189F046C0-0x0000000189F04824
		private float RecomputeToMaxWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x01FB5F62 */) => default; // 0x0000000189F06294-0x0000000189F06568
		private float RecomputeToMinWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x01FB5F63 */) => default; // 0x0000000189F06704-0x0000000189F069EC
		private float RecomputeToDesiredWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) => default; // 0x0000000189F06180-0x0000000189F06294
		private float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) => default; // 0x0000000189F05F94-0x0000000189F06180
		private float RecomputeToMinWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x01FB5F64 */) => default; // 0x0000000189F069EC-0x0000000189F06B80
		private float RecomputeToMaxWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false /* Metadata: 0x01FB5F65 */) => default; // 0x0000000189F06568-0x0000000189F06704
		public void ResizeToFit(float width) {} // 0x0000000189F06C88-0x0000000189F07048
		private void ResizeColumn(Column column, float width, bool setDesiredWidthOnly = false /* Metadata: 0x01FB5F66 */) {} // 0x0000000189F06B98-0x0000000189F06C88
		internal void BeginDragResize(Column column, float pos, bool previewMode) {} // 0x0000000189F0435C-0x0000000189F0460C
		public float GetDesiredPosition(Column column) => default; // 0x0000000189F05C28-0x0000000189F05CE4
		public float GetDesiredWidth(Column c) => default; // 0x0000000189F05CE4-0x0000000189F05D7C
		public void DragResize(Column column, float pos) {} // 0x0000000189F056E8-0x0000000189F05A0C
		internal void EndDragResize(Column column, bool cancelled) {} // 0x0000000189F05A0C-0x0000000189F05C28
		private void UpdateCache() {} // 0x0000000189F071D0-0x0000000189F07448
		private void UpdateMinAndMaxColumnsWidth() {} // 0x0000000189F07448-0x0000000189F075C4
		private void ClearCache() {} // 0x0000000189F0460C-0x0000000189F04688
	}

	internal enum ColumnsDataType // TypeDefIndex: 43555
	{
		PrimaryColumn = 0,
		StretchMode = 1,
		Reorderable = 2,
		Resizable = 3,
		ResizePreview = 4
	}

	public class Columns : ICollection<Column> // TypeDefIndex: 43560
	{
		// Fields
		private IList<Column> m_Columns; // 0x10
		private List<Column> m_DisplayColumns; // 0x18
		private List<Column> m_VisibleColumns; // 0x20
		private bool m_VisibleColumnsDirty; // 0x28
		private StretchMode m_StretchMode; // 0x2C
		private bool m_Reorderable; // 0x30
		private bool m_Resizable; // 0x31
		private bool m_ResizePreview; // 0x32
		private string m_PrimaryColumnName; // 0x38
	
		// Properties
		public string primaryColumnName { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x0000000189F09940-0x0000000189F09988
		public bool reorderable { get => default; set {} } // 0x0000000183D4EF60-0x0000000183D4EF70 0x0000000189F09988-0x0000000189F099A0
		public bool resizable { get => default; set {} } // 0x0000000183D4F2C0-0x0000000183D4F2D0 0x0000000189F099A0-0x0000000189F099B8
		public bool resizePreview { get => default; set {} } // 0x0000000183D4F630-0x0000000183D4F640 0x0000000189F099B8-0x0000000189F099D0
		internal IEnumerable<Column> displayList { get => default; } // 0x0000000189F095C0-0x0000000189F095DC 
		internal IEnumerable<Column> visibleList { get => default; } // 0x0000000189F095DC-0x0000000189F095F8 
		public StretchMode stretchMode { get => default; set {} } // 0x0000000183D4EDD0-0x0000000183D4EDE0 0x0000000189F099D0-0x0000000189F099E8
		public int Count { get => default; } // 0x0000000189F09390-0x0000000189F093D8 
		public bool IsReadOnly { get => default; } // 0x0000000189F093D8-0x0000000189F09424 
		public Column this[int index] { get => default; } // 0x0000000189F09424-0x0000000189F09478 
		public Column this[string name] { get => default; } // 0x0000000189F09478-0x0000000189F095C0 
	
		// Events
		internal event Action<ColumnsDataType> changed;
		internal event Action<Column, int> columnAdded;
		internal event Action<Column> columnRemoved;
		internal event Action<Column, ColumnDataType> columnChanged;
		internal event Action<Column> columnResized;
		internal event Action<Column, int, int> columnReordered;
	
		// Nested types
		public enum StretchMode // TypeDefIndex: 43556
		{
			Grow = 0,
			GrowAndFill = 1
		}
	
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 43557
			where T : Columns, new()
		{
			// Constructors
			public UxmlObjectFactory() {}
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 43558
			where T : Columns
		{
			// Fields
			private readonly UxmlStringAttributeDescription m_PrimaryColumnName;
			private readonly UxmlEnumAttributeDescription<StretchMode> m_StretchMode;
			private readonly UxmlBoolAttributeDescription m_Reorderable;
			private readonly UxmlBoolAttributeDescription m_Resizable;
			private readonly UxmlBoolAttributeDescription m_ResizePreview;
			private readonly UxmlObjectListAttributeDescription<Column> m_Columns;
	
			// Constructors
			public UxmlObjectTraits() {}
	
			// Methods
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc) {}
		}
	
		// Constructors
		public Columns() {} // 0x0000000189F08FC0-0x0000000189F09048
	
		// Methods
		public bool IsPrimary(Column column) => default; // 0x0000000189F08A28-0x0000000189F08A94
		public IEnumerator<Column> GetEnumerator() => default; // 0x0000000189F086D0-0x0000000189F08718
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F08DD0-0x0000000189F08DDC
		public void Add(Column item) {} // 0x0000000189F08378-0x0000000189F083DC
		public void Clear() {} // 0x0000000189F083DC-0x0000000189F0847C
		public bool Contains(Column item) => default; // 0x0000000189F085D4-0x0000000189F08628
		public bool Contains(string name) => default; // 0x0000000189F0847C-0x0000000189F085D4
		public void CopyTo(Column[] array, int arrayIndex) {} // 0x0000000189F08628-0x0000000189F08688
		public bool Remove(Column column) => default; // 0x0000000189F08B08-0x0000000189F08CDC
		private void OnColumnChanged(Column column, ColumnDataType type) {} // 0x0000000189F08AA8-0x0000000189F08AF4
		private void OnColumnResized(Column column) {} // 0x0000000189F08AF4-0x0000000189F08B08
		public int IndexOf(Column column) => default; // 0x0000000189F08718-0x0000000189F08768
		public void Insert(int index, Column column) {} // 0x0000000189F087E8-0x0000000189F08A28
		public void ReorderDisplay(int from, int to) {} // 0x0000000189F08CDC-0x0000000189F08DD0
		private void InitOrderColumns() {} // 0x0000000189F08768-0x0000000189F087E8
		private void DirtyVisibleColumns() {} // 0x0000000189F08688-0x0000000189F086D0
		private void UpdateVisibleColumns() {} // 0x0000000189F08DDC-0x0000000189F08FC0
		private void NotifyChange(ColumnsDataType type) {} // 0x0000000189F08A94-0x0000000189F08AA8
	}

	public class MultiColumnController : IDisposable // TypeDefIndex: 43561
	{
		// Fields
		private static readonly PropertyName k_BoundColumnVePropertyName; // 0x00
		internal static readonly PropertyName bindableElementPropertyName; // 0x04
		internal static readonly string baseUssClassName; // 0x08
		private static readonly string k_HeaderContainerViewDataKey; // 0x10
		public static readonly string headerContainerUssClassName; // 0x18
		public static readonly string rowContainerUssClassName; // 0x20
		public static readonly string cellUssClassName; // 0x28
		public static readonly string cellLabelUssClassName; // 0x30
		private static readonly string k_HeaderViewDataKey; // 0x38
		private BaseVerticalCollectionView m_View; // 0x20
		private VisualElement m_HeaderContainer; // 0x28
		private MultiColumnCollectionHeader m_MultiColumnHeader; // 0x30
	
		// Properties
		internal MultiColumnCollectionHeader header { get => default; } // 0x0000000181003830-0x0000000181003840 
	
		// Events
		public event Action columnSortingChanged;
		public event Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent;
	
		// Constructors
		public MultiColumnController() {} // Dummy constructor
		public MultiColumnController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) {} // 0x0000000189F0F2AC-0x0000000189F0F718
		static MultiColumnController() {} // 0x0000000189F0F008-0x0000000189F0F2AC
	
		// Methods
		private static void BindCellItem<T>(VisualElement ve, int rowIndex, Column column, T item) {}
		private static void UnbindCellItem(VisualElement ve, int rowIndex, Column column) {} // 0x0000000189F0ECF0-0x0000000189F0ED24
		private static VisualElement DefaultMakeCellItem() => default; // 0x0000000189F0DA78-0x0000000189F0DAFC
		private static void DefaultBindCellItem<T>(VisualElement ve, Column column, T item) {}
		public VisualElement MakeItem() => default; // 0x0000000189F0E2E4-0x0000000189F0E5DC
		public void BindItem<T>(VisualElement element, int index, T item) {}
		public void UnbindItem(VisualElement element, int index) {} // 0x0000000189F0ED24-0x0000000189F0EF30
		public void DestroyItem(VisualElement element) {} // 0x0000000189F0DAFC-0x0000000189F0DD2C
		public void PrepareView(BaseVerticalCollectionView collectionView) {} // 0x0000000189F0E9EC-0x0000000189F0ECF0
		public void Dispose() {} // 0x0000000189F0DD2C-0x0000000189F0E2E4
		private void OnHorizontalScrollerValueChanged(float v) {} // 0x0000000189F0E8A0-0x0000000189F0E8C0
		private void OnViewportGeometryChanged(GeometryChangedEvent evt) {} // 0x0000000189F0E8C0-0x0000000189F0E9EC
		private void OnColumnContainerGeometryChanged(GeometryChangedEvent evt) {} // 0x0000000189F0E634-0x0000000189F0E640
		private void UpdateContentContainer(BaseVerticalCollectionView collectionView) {} // 0x0000000189F0EF30-0x0000000189F0F008
		private void OnColumnSortingChanged() {} // 0x000000018576F918-0x000000018576F928
		private void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column) {} // 0x0000000189F0E88C-0x0000000189F0E8A0
		private void OnColumnResized(int index, float width) {} // 0x0000000189F0E678-0x0000000189F0E854
		private void OnColumnAdded(Column column, int index) {} // 0x0000000189F0E5DC-0x0000000189F0E5FC
		private void OnColumnRemoved(Column column) {} // 0x0000000189F0E5DC-0x0000000189F0E5FC
		private void OnColumnReordered(Column column, int from, int to) {} // 0x0000000189F0E640-0x0000000189F0E678
		private void OnColumnsChanged(Column column, ColumnDataType type) {} // 0x0000000189F0E854-0x0000000189F0E88C
		private void OnColumnChanged(ColumnsDataType type) {} // 0x0000000189F0E5FC-0x0000000189F0E634
		private void OnViewDataRestored() {} // 0x0000000189F0E5DC-0x0000000189F0E5FC
	}

	public class MultiColumnListView : BaseListView // TypeDefIndex: 43564
	{
		// Fields
		private Columns m_Columns; // 0x538
		private bool m_SortingEnabled; // 0x540
		private SortColumnDescriptions m_SortColumnDescriptions; // 0x548
		private List<SortColumnDescription> m_SortedColumns; // 0x550
	
		// Properties
		public new MultiColumnListViewController viewController { get => default; } // 0x0000000189F0FE4C-0x0000000189F0FE90 
		public Columns columns { get => default; private set {} } // 0x0000000183D6CB00-0x0000000183D6CB10 0x0000000189F0FE90-0x0000000189F0FEF4
		public SortColumnDescriptions sortColumnDescriptions { get => default; private set {} } // 0x0000000183D6CB20-0x0000000183D6CB30 0x0000000189F0FEF4-0x0000000189F0FF88
		public bool sortingEnabled { set {} } // 0x0000000189F0FF88-0x0000000189F0FFE8
	
		// Nested types
		public class UxmlFactory : UxmlFactory<MultiColumnListView, UxmlTraits> // TypeDefIndex: 43562
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F1500C-0x0000000189F15048
		}
	
		public class UxmlTraits : BaseListView.UxmlTraits // TypeDefIndex: 43563
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_SortingEnabled; // 0xD8
			private readonly UxmlObjectAttributeDescription<Columns> m_Columns; // 0xE0
			private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; // 0xE8
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F15CB0-0x0000000189F15DC0
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F15430-0x0000000189F15578
		}
	
		// Constructors
		public MultiColumnListView() {} // 0x0000000189F0FDE4-0x0000000189F0FE4C
		public MultiColumnListView(Columns columns) {} // 0x0000000189F0FC90-0x0000000189F0FDE4
	
		// Methods
		protected override CollectionViewController CreateViewController() => default; // 0x0000000189F0F958-0x0000000189F0F9EC
		public override void SetViewController(CollectionViewController controller) {} // 0x0000000189F0FA54-0x0000000189F0FC90
		private protected override void CreateVirtualizationController() {} // 0x0000000189F0F9EC-0x0000000189F0FA28
		private void RaiseColumnSortingChanged() {} // 0x0000000189F0FA28-0x0000000189F0FA3C
		private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) {} // 0x0000000189F0FA3C-0x0000000189F0FA54
	}

	public class MultiColumnTreeView : BaseTreeView // TypeDefIndex: 43567
	{
		// Fields
		private Columns m_Columns; // 0x4B8
		private bool m_SortingEnabled; // 0x4C0
		private SortColumnDescriptions m_SortColumnDescriptions; // 0x4C8
		private List<SortColumnDescription> m_SortedColumns; // 0x4D0
	
		// Properties
		public new MultiColumnTreeViewController viewController { get => default; } // 0x0000000189F104E8-0x0000000189F1052C 
		public Columns columns { get => default; private set {} } // 0x0000000183D57340-0x0000000183D57350 0x0000000189F1052C-0x0000000189F10590
		public SortColumnDescriptions sortColumnDescriptions { get => default; private set {} } // 0x0000000183D6C890-0x0000000183D6C8A0 0x0000000189F10590-0x0000000189F10624
		public bool sortingEnabled { set {} } // 0x0000000189F10624-0x0000000189F10684
	
		// Nested types
		public class UxmlFactory : UxmlFactory<MultiColumnTreeView, UxmlTraits> // TypeDefIndex: 43565
		{
			// Constructors
			public UxmlFactory() {} // 0x0000000189F150C0-0x0000000189F150FC
		}
	
		public class UxmlTraits : BaseTreeView.UxmlTraits // TypeDefIndex: 43566
		{
			// Fields
			private readonly UxmlBoolAttributeDescription m_SortingEnabled; // 0xB8
			private readonly UxmlObjectAttributeDescription<Columns> m_Columns; // 0xC0
			private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions; // 0xC8
	
			// Constructors
			public UxmlTraits() {} // 0x0000000189F15DC0-0x0000000189F15ED0
	
			// Methods
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x0000000189F15850-0x0000000189F15998
		}
	
		// Constructors
		public MultiColumnTreeView() {} // 0x0000000189F10480-0x0000000189F104E8
		public MultiColumnTreeView(Columns columns) {} // 0x0000000189F1032C-0x0000000189F10480
	
		// Methods
		protected override CollectionViewController CreateViewController() => default; // 0x0000000189F0FFE8-0x0000000189F10088
		public override void SetViewController(CollectionViewController controller) {} // 0x0000000189F100F0-0x0000000189F1032C
		private protected override void CreateVirtualizationController() {} // 0x0000000189F10088-0x0000000189F100C4
		private void RaiseColumnSortingChanged() {} // 0x0000000189F100C4-0x0000000189F100D8
		private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) {} // 0x0000000189F100D8-0x0000000189F100F0
	}

	public enum SortDirection // TypeDefIndex: 43568
	{
		Ascending = 0,
		Descending = 1
	}

	[Serializable]
	public class SortColumnDescription // TypeDefIndex: 43571
	{
		// Fields
		[SerializeField]
		private int m_ColumnIndex; // 0x10
		[SerializeField]
		private string m_ColumnName; // 0x18
		[SerializeField]
		private SortDirection m_SortDirection; // 0x20
	
		// Properties
		public string columnName { get => default; set {} } // 0x0000000181041090-0x00000001810410A0 0x0000000189F10874-0x0000000189F108C0
		public int columnIndex { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x0000000189F1084C-0x0000000189F10874
		public Column column { get; internal set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public SortDirection direction { get => default; set {} } // 0x0000000181003B50-0x0000000181003B60 0x0000000189F108C0-0x0000000189F108E8
	
		// Events
		internal event Action<SortColumnDescription> changed;
	
		// Nested types
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 43569
			where T : SortColumnDescription, new()
		{
			// Constructors
			public UxmlObjectFactory() {}
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 43570
			where T : SortColumnDescription
		{
			// Fields
			private readonly UxmlStringAttributeDescription m_ColumnName;
			private readonly UxmlIntAttributeDescription m_ColumnIndex;
			private readonly UxmlEnumAttributeDescription<SortDirection> m_SortDescription;
	
			// Constructors
			public UxmlObjectTraits() {}
	
			// Methods
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc) {}
		}
	
		// Constructors
		public SortColumnDescription() {} // 0x0000000183D51990-0x0000000183D519A0
		public SortColumnDescription(int columnIndex, SortDirection direction) {} // 0x0000000189F106FC-0x0000000189F10734
		public SortColumnDescription(string columnName, SortDirection direction) {} // 0x0000000189F106C4-0x0000000189F106FC
	}

	[Serializable]
	[DefaultMember("Item")]
	public class SortColumnDescriptions : ICollection<SortColumnDescription> // TypeDefIndex: 43574
	{
		// Fields
		[SerializeField]
		private readonly IList<SortColumnDescription> m_Descriptions; // 0x10
	
		// Properties
		public int Count { get => default; } // 0x0000000189F10E8C-0x0000000189F10ED4 
		public bool IsReadOnly { get => default; } // 0x0000000189F10ED4-0x0000000189F10F20 
	
		// Events
		internal event Action changed;
	
		// Nested types
		internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> // TypeDefIndex: 43572
			where T : SortColumnDescriptions, new()
		{
			// Constructors
			public UxmlObjectFactory() {}
		}
	
		internal class UxmlObjectTraits<T> : UIElements.UxmlObjectTraits<T> // TypeDefIndex: 43573
			where T : SortColumnDescriptions
		{
			// Fields
			private readonly UxmlObjectListAttributeDescription<SortColumnDescription> m_SortColumnDescriptions;
	
			// Constructors
			public UxmlObjectTraits() {}
	
			// Methods
			public override void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc) {}
		}
	
		// Constructors
		public SortColumnDescriptions() {} // 0x0000000189F10D80-0x0000000189F10DF8
	
		// Methods
		public IEnumerator<SortColumnDescription> GetEnumerator() => default; // 0x0000000189F10A78-0x0000000189F10AC0
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F10D74-0x0000000189F10D80
		public void Add(SortColumnDescription item) {} // 0x0000000189F108E8-0x0000000189F1094C
		public void Clear() {} // 0x0000000189F1094C-0x0000000189F109C4
		public bool Contains(SortColumnDescription item) => default; // 0x0000000189F109C4-0x0000000189F10A18
		public void CopyTo(SortColumnDescription[] array, int arrayIndex) {} // 0x0000000189F10A18-0x0000000189F10A78
		public bool Remove(SortColumnDescription desc) => default; // 0x0000000189F10C3C-0x0000000189F10D74
		private void OnDescriptionChanged(SortColumnDescription desc) {} // 0x000000018788F298-0x000000018788F2A8
		public void Insert(int index, SortColumnDescription desc) {} // 0x0000000189F10AC0-0x0000000189F10C3C
	}

	internal abstract class BaseReorderableDragAndDropController : ICollectionDragAndDropController // TypeDefIndex: 43575
	{
		// Fields
		protected readonly BaseVerticalCollectionView m_View; // 0x10
		protected List<int> m_SortedSelectedIds; // 0x18
	
		// Properties
		public virtual bool enableReordering { get; set; } // 0x0000000183D4EF90-0x0000000183D4EFA0 0x0000000183D4EFC0-0x0000000183D4EFD0
	
		// Constructors
		protected BaseReorderableDragAndDropController() {} // Dummy constructor
		public BaseReorderableDragAndDropController(BaseVerticalCollectionView view) {} // 0x0000000189F042C8-0x0000000189F0435C
	
		// Methods
		public IEnumerable<int> GetSortedSelectedIds() => default; // 0x0000000181041090-0x00000001810410A0
		public virtual bool CanStartDrag(IEnumerable<int> itemIndices) => default; // 0x0000000183D89080-0x0000000183D89090
		public virtual StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false /* Metadata: 0x01FB5F70 */) => default; // 0x0000000189F03F5C-0x0000000189F042C8
		protected virtual int CompareId(int id1, int id2) => default; // 0x0000000189F03F3C-0x0000000189F03F5C
		public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args);
		public abstract void OnDrop(IListDragAndDropArgs args);
		public virtual void DragCleanup() {} // 0x000000018350B670-0x000000018350B680
		public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) {} // 0x000000018350B670-0x000000018350B680
	}

	internal static class DragAndDropUtility // TypeDefIndex: 43576
	{
		// Fields
		private static Func<IDragAndDrop> s_MakeDragAndDropClientFunc; // 0x00
		private static IDragAndDrop s_DragAndDropEditor; // 0x08
		private static IDragAndDrop s_DragAndDropPlayMode; // 0x10
	
		// Methods
		internal static IDragAndDrop GetDragAndDrop(IPanel panel) => default; // 0x0000000189F0A020-0x0000000189F0A14C
	}

	internal class DefaultDragAndDropClient : DragAndDropData, IDragAndDrop // TypeDefIndex: 43577
	{
		// Fields
		private readonly Hashtable m_GenericData; // 0x10
		private UnityEngine.UIElements.Label m_DraggedInfoLabel; // 0x18
		private DragVisualMode m_VisualMode; // 0x20
		private IEnumerable<UnityEngine.Object> m_UnityObjectReferences; // 0x28
	
		// Properties
		public override object source { get => default; } // 0x0000000189F09FE0-0x0000000189F0A020 
		public DragAndDropData data { get => default; } // 0x000000018339AE90-0x000000018339AEA0 
	
		// Constructors
		public DefaultDragAndDropClient() {} // 0x0000000189F09F7C-0x0000000189F09FE0
	
		// Methods
		public override object GetGenericData(string key) => default; // 0x0000000189F09A2C-0x0000000189F09A8C
		public void StartDrag(StartDragArgs args, Vector3 pointerPosition) {} // 0x0000000189F09A8C-0x0000000189F09EBC
		public void UpdateDrag(Vector3 pointerPosition) {} // 0x0000000189F09EBC-0x0000000189F09F7C
		public void AcceptDrag() {} // 0x000000018350B670-0x000000018350B680
		public void SetVisualMode(DragVisualMode mode) {} // 0x0000000181003B60-0x0000000181003B70
		public void DragCleanup() {} // 0x0000000189F099E8-0x0000000189F09A2C
	}

	internal abstract class DragEventsProcessor // TypeDefIndex: 43579
	{
		// Fields
		private bool m_IsRegistered; // 0x10
		internal DragState m_DragState; // 0x14
		private Vector3 m_Start; // 0x18
		internal readonly VisualElement m_Target; // 0x28
	
		// Properties
		protected virtual bool supportsDragEvents { get; } // 0x000000018232EB60-0x000000018232EB70 
		internal bool useDragEvents { get; } // 0x0000000189F0B0E0-0x0000000189F0B110 
		protected IDragAndDrop dragAndDrop { get; } // 0x0000000189F0B014-0x0000000189F0B03C 
		internal virtual bool isEditorContext { get; } // 0x0000000189F0B03C-0x0000000189F0B0E0 
	
		// Nested types
		internal enum DragState // TypeDefIndex: 43578
		{
			None = 0,
			CanStartDrag = 1,
			Dragging = 2
		}
	
		// Constructors
		protected DragEventsProcessor() {} // Dummy constructor
		internal DragEventsProcessor(VisualElement target) {} // 0x0000000189F0AEE8-0x0000000189F0B014
	
		// Methods
		private void RegisterCallbacksFromTarget(AttachToPanelEvent evt) {} // 0x0000000189F0AAEC-0x0000000189F0AAF4
		private void RegisterCallbacksFromTarget() {} // 0x0000000189F0A7F4-0x0000000189F0AAEC
		private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt) {} // 0x0000000189F0AEDC-0x0000000189F0AEE8
		internal void UnregisterCallbacksFromTarget(bool unregisterPanelEvents = false /* Metadata: 0x01FB5F71 */) {} // 0x0000000189F0AAF4-0x0000000189F0AEDC
		protected abstract bool CanStartDrag(Vector3 pointerPosition);
		protected internal abstract StartDragArgs StartDrag(Vector3 pointerPosition);
		protected internal abstract void UpdateDrag(Vector3 pointerPosition);
		protected internal abstract void OnDrop(Vector3 pointerPosition);
		protected abstract void ClearDragAndDropUI(bool dragCancelled);
		private void OnPointerDownEvent(PointerDownEvent evt) {} // 0x0000000189F0A32C-0x0000000189F0A400
		internal void OnPointerUpEvent(PointerUpEvent evt) {} // 0x0000000189F0A688-0x0000000189F0A7F4
		private void OnPointerLeaveEvent(PointerLeaveEvent evt) {} // 0x0000000189F0A400-0x0000000189F0A410
		private void OnPointerCancelEvent(PointerCancelEvent evt) {} // 0x0000000189F0A228-0x0000000189F0A2CC
		private void OnPointerCapturedOut(PointerCaptureOutEvent evt) {} // 0x0000000189F0A2CC-0x0000000189F0A32C
		private void OnPointerMoveEvent(PointerMoveEvent evt) {} // 0x0000000189F0A410-0x0000000189F0A688
		private DragEventsProcessor GetDropTarget(Vector2 position) => default; // 0x0000000189F0A14C-0x0000000189F0A228
	}

	internal interface ICollectionDragAndDropController : IDragAndDropController<IListDragAndDropArgs>, IReorderable // TypeDefIndex: 43580
	{
	}

	internal interface IDragAndDrop // TypeDefIndex: 43581
	{
		// Properties
		DragAndDropData data { get; }
	
		// Methods
		void StartDrag(StartDragArgs args, Vector3 pointerPosition);
		void UpdateDrag(Vector3 pointerPosition);
		void AcceptDrag();
		void DragCleanup();
		void SetVisualMode(DragVisualMode visualMode);
	}

	internal abstract class DragAndDropData // TypeDefIndex: 43582
	{
		// Properties
		public abstract object source { get; }
	
		// Constructors
		protected DragAndDropData() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public abstract object GetGenericData(string key);
	}

	internal interface IDragAndDropController<in TArgs> // TypeDefIndex: 43583
	{
		// Methods
		bool CanStartDrag(IEnumerable<int> itemIndices);
		StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIndices, bool skipText = false /* Metadata: 0x01FB5F75 */);
		DragVisualMode HandleDragAndDrop(TArgs args);
		void OnDrop(TArgs args);
		void DragCleanup();
		void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition);
		IEnumerable<int> GetSortedSelectedIds();
	}

	internal enum DragVisualMode // TypeDefIndex: 43584
	{
		None = 0,
		Copy = 1,
		Move = 2,
		Rejected = 3
	}

	[IsReadOnly]
	internal struct CanStartDragArgs // TypeDefIndex: 43585
	{
		// Fields
		public readonly VisualElement draggedElement; // 0x00
		public readonly int id; // 0x08
		public readonly IEnumerable<int> selectedIds; // 0x10
	
		// Constructors
		internal CanStartDragArgs(VisualElement draggedElement, int id, IEnumerable<int> selectedIds) {
			this.draggedElement = default;
			this.id = default;
			this.selectedIds = default;
		} // 0x0000000187F17684-0x0000000187F176AC
	}

	[IsReadOnly]
	internal struct SetupDragAndDropArgs // TypeDefIndex: 43586
	{
		// Fields
		public readonly VisualElement draggedElement; // 0x00
		public readonly IEnumerable<int> selectedIds; // 0x08
		public readonly StartDragArgs startDragArgs; // 0x10
	
		// Constructors
		internal SetupDragAndDropArgs(VisualElement draggedElement, IEnumerable<int> selectedIds, StartDragArgs startDragArgs) {
			this.draggedElement = default;
			this.selectedIds = default;
			this.startDragArgs = default;
		} // 0x0000000189F10684-0x0000000189F106C4
	}

	[IsReadOnly]
	internal struct HandleDragAndDropArgs // TypeDefIndex: 43587
	{
		// Fields
		private readonly DragAndDropArgs m_DragAndDropArgs; // 0x00
	
		// Constructors
		internal HandleDragAndDropArgs(Vector2 position, DragAndDropArgs dragAndDropArgs) {
			m_DragAndDropArgs = default;
		} // 0x0000000189F0B110-0x0000000189F0B12C
	}

	internal struct StartDragArgs // TypeDefIndex: 43588
	{
		// Properties
		public string title { [IsReadOnly] get; } // 0x00000001820C61B0-0x00000001820C61C0 
		public DragVisualMode visualMode { [IsReadOnly] get; } // 0x0000000183D516F0-0x0000000183D51700 
		internal Hashtable genericData { [IsReadOnly] get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		internal IEnumerable<UnityEngine.Object> unityObjectReferences { [IsReadOnly] get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public StartDragArgs(string title, DragVisualMode visualMode) : this() {} // 0x0000000189F11054-0x0000000189F1108C
	
		// Methods
		public void SetGenericData(string key, object data) {} // 0x0000000189F10FB4-0x0000000189F11054
	}

	internal interface IListDragAndDropArgs // TypeDefIndex: 43589
	{
		// Properties
		int insertAtIndex { get; }
		int parentId { get; }
		int childIndex { get; }
		DragAndDropData dragAndDropData { get; }
		DragAndDropPosition dragAndDropPosition { get; }
	}

	internal struct DragAndDropArgs : IListDragAndDropArgs // TypeDefIndex: 43590
	{
		// Properties
		public object target { get; set; } // 0x00000001842715A0-0x00000001842715A8
		public int insertAtIndex { [IsReadOnly] get; set; } // 0x0000000183D516F0-0x0000000183D51700 0x0000000183D51710-0x0000000183D51720
		public int parentId { [IsReadOnly] get; set; } // 0x0000000183D4FBF0-0x0000000183D4FC00 0x0000000183D55690-0x0000000183D556A0
		public int childIndex { [IsReadOnly] get; set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public DragAndDropPosition dragAndDropPosition { [IsReadOnly] get; set; } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		public DragAndDropData dragAndDropData { [IsReadOnly] get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	}

	internal enum DragAndDropPosition // TypeDefIndex: 43591
	{
		OverItem = 0,
		BetweenItems = 1,
		OutsideItems = 2
	}

	internal interface IReorderable // TypeDefIndex: 43592
	{
		// Properties
		bool enableReordering { get; set; }
	}

	internal class ListViewDragger : DragEventsProcessor // TypeDefIndex: 43594
	{
		// Fields
		private DragPosition m_LastDragPosition; // 0x30
		private VisualElement m_DragHoverBar; // 0x50
		private VisualElement m_DragHoverItemMarker; // 0x58
		private VisualElement m_DragHoverSiblingMarker; // 0x60
		private float m_LeftIndentation; // 0x68
		private float m_SiblingBottom; // 0x6C
	
		// Properties
		protected BaseVerticalCollectionView targetView { get => default; } // 0x0000000189F0DA3C-0x0000000189F0DA78 
		protected ScrollView targetScrollView { get => default; } // 0x0000000189F0DA18-0x0000000189F0DA3C 
		public ICollectionDragAndDropController dragAndDropController { get; set; } // 0x0000000183D4EB30-0x0000000183D4EB40 0x000000018519C3C8-0x000000018519C3D8
	
		// Nested types
		internal struct DragPosition : IEquatable<DragPosition> // TypeDefIndex: 43593
		{
			// Fields
			public int insertAtIndex; // 0x00
			public int parentId; // 0x04
			public int childIndex; // 0x08
			public ReusableCollectionItem recycledItem; // 0x10
			public DragAndDropPosition dropPosition; // 0x18
	
			// Methods
			public bool Equals(DragPosition other) => default; // 0x0000000189F1731C-0x0000000189F17380
			public override bool Equals(object obj) => default; // 0x0000000189F1729C-0x0000000189F1731C
			public override int GetHashCode() => default; // 0x0000000189F17380-0x0000000189F173F0
		}
	
		// Constructors
		public ListViewDragger() {} // Dummy constructor
		public ListViewDragger(BaseVerticalCollectionView listView) {} // 0x0000000189F0DA00-0x0000000189F0DA18
	
		// Methods
		protected override bool CanStartDrag(Vector3 pointerPosition) => default; // 0x0000000189F0B758-0x0000000189F0B9D4
		protected internal override StartDragArgs StartDrag(Vector3 pointerPosition) => default; // 0x0000000189F0D224-0x0000000189F0D478
		protected internal override void UpdateDrag(Vector3 pointerPosition) {} // 0x0000000189F0D83C-0x0000000189F0DA00
		private DragVisualMode GetVisualMode(Vector3 pointerPosition, ref DragPosition dragPosition) => default; // 0x0000000189F0C0EC-0x0000000189F0C25C
		protected internal override void OnDrop(Vector3 pointerPosition) {} // 0x0000000189F0CC84-0x0000000189F0CE70
		internal void HandleDragAndScroll(Vector2 pointerPosition) {} // 0x0000000189F0C2E8-0x0000000189F0C4C4
		private void HandleAutoExpansion(Vector2 pointerPosition) {} // 0x0000000189F0C25C-0x0000000189F0C2E8
		private void ApplyDragAndDropUI(DragPosition dragPosition) {} // 0x0000000189F0B12C-0x0000000189F0B758
		protected virtual bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) => default; // 0x0000000189F0D478-0x0000000189F0D7B4
		private void HandleTreePosition(Vector2 pointerPosition, ref DragPosition dragPosition) {} // 0x0000000189F0CA5C-0x0000000189F0CB2C
		private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref DragPosition dragPosition, Vector2 pointerPosition) {} // 0x0000000189F0C4C4-0x0000000189F0CA5C
		private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId) {
			previousItemId = default;
			nextItemId = default;
		} // 0x0000000189F0BD98-0x0000000189F0BF18
		protected DragAndDropArgs MakeDragAndDropArgs(DragPosition dragPosition) => default; // 0x0000000189F0CB2C-0x0000000189F0CC84
		private float GetHoverBarTopPosition(ReusableCollectionItem item) => default; // 0x0000000189F0BCC4-0x0000000189F0BD98
		private void PlaceHoverBarAtElement(ReusableCollectionItem item) {} // 0x0000000189F0CE70-0x0000000189F0CEA8
		private void PlaceHoverBarAt(float top, float indentationPadding = -1f /* Metadata: 0x01FB5F7D */, float siblingBottom = -1f /* Metadata: 0x01FB5F81 */) {} // 0x0000000189F0CEA8-0x0000000189F0D224
		protected override void ClearDragAndDropUI(bool dragCancelled) {} // 0x0000000189F0B9D4-0x0000000189F0BCC4
		protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition) => default; // 0x0000000189F0BF18-0x0000000189F0C0EC
	}

	internal static class ListViewDraggerExtension // TypeDefIndex: 43595
	{
		// Extension methods
		public static ReusableCollectionItem GetRecycledItemFromId(this BaseVerticalCollectionView listView, int id) => default; // 0x0000000189F1C5A8-0x0000000189F1C6F8
		public static ReusableCollectionItem GetRecycledItemFromIndex(this BaseVerticalCollectionView listView, int index) => default; // 0x0000000189F1C6F8-0x0000000189F1C848
	}

	internal class ListViewDraggerAnimated : ListViewDragger // TypeDefIndex: 43596
	{
		// Fields
		private int m_DragStartIndex; // 0x78
		private int m_CurrentIndex; // 0x7C
		private float m_SelectionHeight; // 0x80
		private float m_LocalOffsetOnStart; // 0x84
		private Vector3 m_CurrentPointerPosition; // 0x88
		private ReusableCollectionItem m_Item; // 0x98
		private ReusableCollectionItem m_OffsetItem; // 0xA0
	
		// Properties
		public bool isDragging { get; private set; } // 0x00000001811B9C10-0x00000001811B9C20 0x00000001811B9C20-0x00000001811B9C30
		public ReusableCollectionItem draggedItem { get => default; } // 0x00000001811AC510-0x00000001811AC520 
		protected override bool supportsDragEvents { get => default; } // 0x000000018115F4C0-0x000000018115F530 
	
		// Constructors
		public ListViewDraggerAnimated() {} // Dummy constructor
		public ListViewDraggerAnimated(BaseVerticalCollectionView listView) {} // 0x0000000189F1C5A0-0x0000000189F1C5A8
	
		// Methods
		protected internal override StartDragArgs StartDrag(Vector3 pointerPosition) => default; // 0x0000000189F1B874-0x0000000189F1BEA4
		protected internal override void UpdateDrag(Vector3 pointerPosition) {} // 0x0000000189F1BED8-0x0000000189F1C5A0
		private void Animate(ReusableCollectionItem element, float paddingTop) {} // 0x0000000189F1B2D4-0x0000000189F1B530
		protected internal override void OnDrop(Vector3 pointerPosition) {} // 0x0000000189F1B530-0x0000000189F1B874
		protected override void ClearDragAndDropUI(bool dragCancelled) {} // 0x000000018350B670-0x000000018350B680
		protected override bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) => default; // 0x0000000189F1BEA4-0x0000000189F1BED8
	}

	internal class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController // TypeDefIndex: 43597
	{
		// Fields
		protected readonly BaseListView m_ListView; // 0x28
	
		// Constructors
		public ListViewReorderableDragAndDropController() {} // Dummy constructor
		public ListViewReorderableDragAndDropController(BaseListView view) {} // 0x0000000189F1CAE0-0x0000000189F1CB10
	
		// Methods
		public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) => default; // 0x0000000189F1C848-0x0000000189F1C8B8
		public override void OnDrop(IListDragAndDropArgs args) {} // 0x0000000189F1C8B8-0x0000000189F1CAE0
	}

	internal class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController // TypeDefIndex: 43600
	{
		// Fields
		protected DropData m_DropData; // 0x28
		protected readonly BaseTreeView m_TreeView; // 0x30
		private IVisualElementScheduledItem m_ExpandDropItemScheduledItem; // 0x38
		private Action m_ExpandDropItemCallback; // 0x40
	
		// Nested types
		protected class DropData // TypeDefIndex: 43598
		{
			// Fields
			public int[] expandedIdsBeforeDrag; // 0x10
			public int[] draggedIds; // 0x18
			public int lastItemId; // 0x20
			public float expandItemBeginTimerMs; // 0x24
			public Vector2 expandItemBeginPosition; // 0x28
	
			// Constructors
			public DropData() {} // 0x0000000183D5C2D0-0x0000000183D5C2E0
		}
	
		private struct TreeItemState // TypeDefIndex: 43599
		{
			// Fields
			public int parentId; // 0x00
			public int childIndex; // 0x04
	
			// Constructors
			public TreeItemState(int parentId, int childIndex) {
				this.parentId = default;
				this.childIndex = default;
			} // 0x0000000183D4E4B0-0x0000000183D4E4C0
		}
	
		// Constructors
		public TreeViewReorderableDragAndDropController() {} // Dummy constructor
		public TreeViewReorderableDragAndDropController(BaseTreeView view) {} // 0x0000000189F24168-0x0000000189F24230
	
		// Methods
		protected override int CompareId(int id1, int id2) => default; // 0x0000000189F22F04-0x0000000189F234C8
		public override StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false /* Metadata: 0x01FB5F85 */) => default; // 0x0000000189F240A0-0x0000000189F24168
		public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) => default; // 0x0000000189F23940-0x0000000189F23998
		public override void OnDrop(IListDragAndDropArgs args) {} // 0x0000000189F23998-0x0000000189F23EEC
		public override void DragCleanup() {} // 0x0000000189F23534-0x0000000189F2360C
		private void RestoreExpanded(List<int> ids) {} // 0x0000000189F23EEC-0x0000000189F240A0
		public override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) {} // 0x0000000189F237B0-0x0000000189F23940
		private void DelayExpandDropItem() {} // 0x0000000189F234C8-0x0000000189F23534
		private void ExpandDropItem() {} // 0x0000000189F2360C-0x0000000189F237B0
	}

	internal interface IPointerCaptureEventInternal // TypeDefIndex: 43601
	{
		// Properties
		int pointerId { get; }
	}

	public abstract class PointerCaptureEventBase<T> : EventBase<T>, IPointerCaptureEventInternal // TypeDefIndex: 43602
		where T : PointerCaptureEventBase<T>, new()
	{
		// Properties
		private IEventHandler relatedTarget { get; set; }
		public int pointerId { get; private set; }
	
		// Constructors
		protected PointerCaptureEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) => default;
	}

	public class PointerCaptureOutEvent : PointerCaptureEventBase<PointerCaptureOutEvent> // TypeDefIndex: 43603
	{
		// Constructors
		public PointerCaptureOutEvent() {} // 0x0000000189F204C0-0x0000000189F204FC
	}

	public class PointerCaptureEvent : PointerCaptureEventBase<PointerCaptureEvent> // TypeDefIndex: 43604
	{
		// Constructors
		public PointerCaptureEvent() {} // 0x0000000189F20484-0x0000000189F204C0
	}

	public abstract class MouseCaptureEventBase<T> : PointerCaptureEventBase<T> // TypeDefIndex: 43605
		where T : MouseCaptureEventBase<T>, new()
	{
		// Constructors
		protected MouseCaptureEventBase() {}
	
		// Methods
		protected override void Init() {}
	}

	public class MouseCaptureOutEvent : MouseCaptureEventBase<MouseCaptureOutEvent> // TypeDefIndex: 43606
	{
		// Constructors
		public MouseCaptureOutEvent() {} // 0x0000000189F1CFE8-0x0000000189F1D024
	}

	public class MouseCaptureEvent : MouseCaptureEventBase<MouseCaptureEvent> // TypeDefIndex: 43607
	{
		// Constructors
		public MouseCaptureEvent() {} // 0x0000000189F1CFAC-0x0000000189F1CFE8
	}

	public class ChangeEvent<T> : EventBase<ChangeEvent<T>> // TypeDefIndex: 43608
	{
		// Properties
		public T previousValue { get; protected set; }
		public T newValue { get; protected set; }
	
		// Constructors
		public ChangeEvent() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static ChangeEvent<T> GetPooled(T previousValue, T newValue) => default;
	}

	internal class CommandEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 43609
	{
		// Constructors
		public CommandEventDispatchingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x0000000189F168D4-0x0000000189F16914
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x0000000189F16914-0x0000000189F16AA4
	}

	public interface ICommandEvent // TypeDefIndex: 43610
	{
	}

	public abstract class CommandEventBase<T> : EventBase<T>, ICommandEvent // TypeDefIndex: 43611
		where T : CommandEventBase<T>, new()
	{
		// Fields
		private string m_CommandName;
	
		// Properties
		public string commandName { get; protected set; }
	
		// Constructors
		protected CommandEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(UnityEngine.Event systemEvent) => default;
		public static T GetPooled(string commandName) => default;
	}

	public class ValidateCommandEvent : CommandEventBase<ValidateCommandEvent> // TypeDefIndex: 43612
	{
		// Constructors
		public ValidateCommandEvent() {} // 0x0000000189F25EA4-0x0000000189F25EE0
	}

	public class ExecuteCommandEvent : CommandEventBase<ExecuteCommandEvent> // TypeDefIndex: 43613
	{
		// Constructors
		public ExecuteCommandEvent() {} // 0x0000000189F1A424-0x0000000189F1A460
	}

	internal class DefaultDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 43614
	{
		// Constructors
		public DefaultDispatchingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x0000000189F170D0-0x0000000189F17110
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x0000000189F17110-0x0000000189F17260
	}

	internal class ElementUnderPointer // TypeDefIndex: 43615
	{
		// Fields
		private VisualElement[] m_PendingTopElementUnderPointer; // 0x10
		private VisualElement[] m_TopElementUnderPointer; // 0x18
		private IPointerEvent[] m_TriggerPointerEvent; // 0x20
		private IMouseEvent[] m_TriggerMouseEvent; // 0x28
		private Vector2[] m_PickingPointerPositions; // 0x30
		private bool[] m_IsPickingPointerTemporaries; // 0x38
	
		// Constructors
		public ElementUnderPointer() {} // 0x0000000189F184C8-0x0000000189F18630
	
		// Methods
		internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) {
			pickPosition = default;
			isTemporary = default;
			return default;
		} // 0x0000000189F180C8-0x0000000189F18150
		internal VisualElement GetTopElementUnderPointer(int pointerId) => default; // 0x000000018594E120-0x000000018594E14C
		internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos) {} // 0x0000000189F18380-0x0000000189F184AC
		private Vector2 GetEventPointerPosition(EventBase triggerEvent) => default; // 0x0000000189F18008-0x0000000189F180C8
		internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) {} // 0x0000000189F184AC-0x0000000189F184C8
		internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) {} // 0x0000000189F18364-0x0000000189F18380
		private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary) {} // 0x0000000189F18150-0x0000000189F18364
		internal void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType) {} // 0x0000000189F17460-0x0000000189F18008
	}

	public abstract class EventBase : IDisposable // TypeDefIndex: 43618
	{
		// Fields
		private static long s_LastTypeId; // 0x00
		private static ulong s_NextEventId; // 0x08
		private PropagationPaths m_Path; // 0x30
		private IEventHandler m_Target; // 0x48
		private IEventHandler m_CurrentTarget; // 0x60
		private UnityEngine.Event m_ImguiEvent; // 0x68
	
		// Properties
		public virtual long eventTypeId { get; } // 0x0000000183D6EF40-0x0000000183D6EF50 
		public long timestamp { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x0000000183D517C0-0x0000000183D517D0
		internal ulong eventId { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x0000000183D4EC10-0x0000000183D4EC20
		private ulong triggerEventId { get; set; } // 0x0000000183D4ED30-0x0000000183D4ED40
		internal EventPropagation propagation { get; set; } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		internal PropagationPaths path { get; set; } // 0x0000000189F18A8C-0x0000000189F18B4C 0x0000000189F18E00-0x0000000189F18E60
		private LifeCycleStatus lifeCycleStatus { get; set; } // 0x0000000183D4EC30-0x0000000183D4EC40 0x0000000183D4ECB0-0x0000000183D4ECC0
		public bool bubbles { get; } // 0x0000000189F18A38-0x0000000189F18A40 
		public bool tricklesDown { get; } // 0x0000000189F18B88-0x0000000189F18B90 
		internal bool skipDisabledElements { get; set; } // 0x0000000189F18B78-0x0000000189F18B80 0x0000000189F18ED0-0x0000000189F18EEC
		internal bool ignoreCompositeRoots { get; set; } // 0x0000000189F18A54-0x0000000189F18A5C 0x0000000189F18CB0-0x0000000189F18CCC
		internal IEventHandler leafTarget { get; private set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public IEventHandler target { get; set; } // 0x0000000183D87DB0-0x0000000183D87DC0 0x0000000189F18F08-0x0000000189F18F38
		internal List<IEventHandler> skipElements { get; } // 0x0000000183D4EAF0-0x0000000183D4EB00 
		public bool isPropagationStopped { get; private set; } // 0x0000000189F18A84-0x0000000189F18A8C 0x0000000189F18DE4-0x0000000189F18E00
		public bool isImmediatePropagationStopped { get; private set; } // 0x0000000189F18A7C-0x0000000189F18A84 0x0000000189F18DC8-0x0000000189F18DE4
		public bool isDefaultPrevented { get; private set; } // 0x0000000189F18A74-0x0000000189F18A7C 0x0000000189F18DAC-0x0000000189F18DC8
		public PropagationPhase propagationPhase { get; internal set; } // 0x0000000183D4EF00-0x0000000183D4EF10 0x0000000183D4EF50-0x0000000183D4EF60
		public virtual IEventHandler currentTarget { get; internal set; } // 0x0000000183D87D60-0x0000000183D87D70 0x0000000189F18B90-0x0000000189F18C7C
		public bool dispatch { get; internal set; } // 0x0000000189F18A40-0x0000000189F18A48 0x0000000189F18C7C-0x0000000189F18C94
		private bool dispatched { get; set; } // 0x0000000189F18A48-0x0000000189F18A54 0x0000000189F18C94-0x0000000189F18CB0
		internal bool processed { get; private set; } // 0x0000000189F18B60-0x0000000189F18B6C 0x0000000189F18E98-0x0000000189F18EB4
		internal bool processedByFocusController { get; set; } // 0x0000000189F18B54-0x0000000189F18B60 0x0000000189F18E7C-0x0000000189F18E98
		internal bool stopDispatch { get; set; } // 0x0000000189F18B80-0x0000000189F18B88 0x0000000189F18EEC-0x0000000189F18F08
		internal bool propagateToIMGUI { get; set; } // 0x0000000189F18B6C-0x0000000189F18B78 0x0000000189F18EB4-0x0000000189F18ED0
		private bool imguiEventIsValid { get; set; } // 0x0000000189F18A5C-0x0000000189F18A64 0x0000000189F18CCC-0x0000000189F18CE8
		public UnityEngine.Event imguiEvent { get; protected set; } // 0x0000000189F18A64-0x0000000189F18A74 0x0000000189F18CE8-0x0000000189F18DAC
		public Vector2 originalMousePosition { get; private set; } // 0x0000000183D5B650-0x0000000183D5B670 0x0000000183D4EE60-0x0000000183D4EE70
		protected bool pooled { get; set; } // 0x0000000189F18B4C-0x0000000189F18B54 0x0000000189F18E60-0x0000000189F18E7C
	
		// Nested types
		[Flags]
		internal enum EventPropagation // TypeDefIndex: 43616
		{
			None = 0,
			Bubbles = 1,
			TricklesDown = 2,
			Cancellable = 4,
			SkipDisabledElements = 8,
			IgnoreCompositeRoots = 16
		}
	
		[Flags]
		private enum LifeCycleStatus // TypeDefIndex: 43617
		{
			None = 0,
			PropagationStopped = 1,
			ImmediatePropagationStopped = 2,
			DefaultPrevented = 4,
			Dispatching = 8,
			Pooled = 16,
			IMGUIEventIsValid = 32,
			StopDispatch = 64,
			PropagateToIMGUI = 128,
			Dispatched = 512,
			Processed = 1024,
			ProcessedByFocusController = 2048
		}
	
		// Constructors
		protected EventBase() {} // 0x0000000189F189A8-0x0000000189F18A38
	
		// Methods
		protected static long RegisterEventType() => default; // 0x0000000189F188F8-0x0000000189F1893C
		internal void SetTriggerEventId(ulong id) {} // 0x0000000183D4ED30-0x0000000183D4ED40
		[Obsolete("Override PreDispatch(IPanel panel) instead.")]
		protected virtual void PreDispatch() {} // 0x000000018350B670-0x000000018350B680
		protected internal virtual void PreDispatch(IPanel panel) {} // 0x000000018350B670-0x000000018350B680
		[Obsolete("Override PostDispatch(IPanel panel) instead.")]
		protected virtual void PostDispatch() {} // 0x000000018350B670-0x000000018350B680
		protected internal virtual void PostDispatch(IPanel panel) {} // 0x0000000189F188E4-0x0000000189F188EC
		internal bool Skip(IEventHandler h) => default; // 0x0000000189F1893C-0x0000000189F18990
		public void StopPropagation() {} // 0x0000000189F189A0-0x0000000189F189A8
		public void StopImmediatePropagation() {} // 0x0000000189F18990-0x0000000189F189A0
		public void PreventDefault() {} // 0x0000000189F188EC-0x0000000189F188F8
		internal void MarkReceivedByDispatcher() {} // 0x0000000189F18878-0x0000000189F188E4
		protected virtual void Init() {} // 0x0000000189F18744-0x0000000189F1874C
		private void LocalInit() {} // 0x0000000189F1874C-0x0000000189F18878
		internal abstract void Acquire();
		public abstract void Dispose();
	}

	public abstract class EventBase<T> : EventBase // TypeDefIndex: 43619
		where T : EventBase<T>, new()
	{
		// Fields
		private static readonly long s_TypeId;
		private static readonly UnityEngine.UIElements.ObjectPool<T> s_Pool;
		private int m_RefCount;
	
		// Properties
		public override long eventTypeId { get; }
	
		// Constructors
		protected EventBase() {}
		static EventBase() {}
	
		// Methods
		public static long TypeId() => default;
		protected override void Init() {}
		public static T GetPooled() => default;
		internal static T GetPooled(EventBase e) => default;
		private static void ReleasePooled(T evt) {}
		internal override void Acquire() {}
		public sealed override void Dispose() {}
	}

	public delegate void EventCallback<in TEventType>(TEventType evt); // TypeDefIndex: 43620; 0x00000000-0x00000000

	internal abstract class EventCallbackFunctorBase // TypeDefIndex: 43621
	{
		// Properties
		public CallbackPhase phase { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public InvokePolicy invokePolicy { get; } // 0x0000000183D50CC0-0x0000000183D50CD0 
	
		// Constructors
		protected EventCallbackFunctorBase() {} // Dummy constructor
		protected EventCallbackFunctorBase(CallbackPhase phase, InvokePolicy invokePolicy) {} // 0x0000000183D50CB0-0x0000000183D50CC0
	
		// Methods
		public abstract void Invoke(EventBase evt, PropagationPhase propagationPhase);
		public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase);
		protected bool PhaseMatches(PropagationPhase propagationPhase) => default; // 0x0000000189F18F38-0x0000000189F18F5C
	}

	internal class EventCallbackFunctor<TEventType> : EventCallbackFunctorBase // TypeDefIndex: 43622
		where TEventType : EventBase<TEventType>, new()
	{
		// Fields
		private readonly EventCallback<TEventType> m_Callback;
		private readonly long m_EventTypeId;
	
		// Constructors
		public EventCallbackFunctor() {} // Dummy constructor
		public EventCallbackFunctor(EventCallback<TEventType> callback, CallbackPhase phase, InvokePolicy invokePolicy = InvokePolicy.Default /* Metadata: 0x01FB5F9D */) {}
	
		// Methods
		public override void Invoke(EventBase evt, PropagationPhase propagationPhase) {}
		public override bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase) => default;
	}

	public enum TrickleDown // TypeDefIndex: 43623
	{
		NoTrickleDown = 0,
		TrickleDown = 1
	}

	internal enum CallbackPhase // TypeDefIndex: 43624
	{
		TargetAndBubbleUp = 1,
		TrickleDownAndTarget = 2
	}

	internal enum InvokePolicy // TypeDefIndex: 43625
	{
		Default = 0,
		IncludeDisabled = 1
	}

	internal class EventCallbackListPool // TypeDefIndex: 43626
	{
		// Fields
		private readonly Stack<EventCallbackList> m_Stack; // 0x10
	
		// Constructors
		public EventCallbackListPool() {} // 0x0000000189F1908C-0x0000000189F19104
	
		// Methods
		public EventCallbackList Get(EventCallbackList initializer) => default; // 0x0000000189F18F5C-0x0000000189F19028
		public void Release(EventCallbackList element) {} // 0x0000000189F19028-0x0000000189F1908C
	}

	internal class EventCallbackList // TypeDefIndex: 43627
	{
		// Fields
		private List<EventCallbackFunctorBase> m_List; // 0x10
	
		// Properties
		public int trickleDownCallbackCount { get; private set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public int bubbleUpCallbackCount { get; private set; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public int Count { get => default; } // 0x0000000189F1963C-0x0000000189F1967C 
		public EventCallbackFunctorBase this[int i] { get => default; } // 0x0000000189F1967C-0x0000000189F196D0 
	
		// Constructors
		public EventCallbackList() {} // 0x0000000189F19524-0x0000000189F195A4
		public EventCallbackList(EventCallbackList source) {} // 0x0000000189F195A4-0x0000000189F1963C
	
		// Methods
		public bool Contains(long eventTypeId, Delegate callback, CallbackPhase phase) => default; // 0x0000000189F1934C-0x0000000189F1936C
		public EventCallbackFunctorBase Find(long eventTypeId, Delegate callback, CallbackPhase phase) => default; // 0x0000000189F1936C-0x0000000189F19438
		public bool Remove(long eventTypeId, Delegate callback, CallbackPhase phase) => default; // 0x0000000189F19438-0x0000000189F19524
		public void Add(EventCallbackFunctorBase item) {} // 0x0000000189F1928C-0x0000000189F192FC
		public void AddRange(EventCallbackList list) {} // 0x0000000189F19104-0x0000000189F1928C
		public void Clear() {} // 0x0000000189F192FC-0x0000000189F1934C
	}

	internal class EventCallbackRegistry // TypeDefIndex: 43628
	{
		// Fields
		private static readonly EventCallbackListPool s_ListPool; // 0x00
		private EventCallbackList m_Callbacks; // 0x10
		private EventCallbackList m_TemporaryCallbacks; // 0x18
		private int m_IsInvoking; // 0x20
	
		// Constructors
		public EventCallbackRegistry() {} // 0x0000000183D4E2C0-0x0000000183D4E2D0
		static EventCallbackRegistry() {} // 0x0000000189F19A6C-0x0000000189F19AE8
	
		// Methods
		private static EventCallbackList GetCallbackList(EventCallbackList initializer = null) => default; // 0x0000000189F19784-0x0000000189F197E4
		private static void ReleaseCallbackList(EventCallbackList toRelease) {} // 0x0000000189F1999C-0x0000000189F199FC
		private EventCallbackList GetCallbackListForWriting() => default; // 0x0000000189F196E4-0x0000000189F19784
		private EventCallbackList GetCallbackListForReading() => default; // 0x0000000189F196D0-0x0000000189F196E4
		private bool UnregisterCallback(long eventTypeId, Delegate callback, TrickleDown useTrickleDown) => default; // 0x0000000189F199FC-0x0000000189F19A6C
		public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x01FB5FA4 */, InvokePolicy invokePolicy = InvokePolicy.Default /* Metadata: 0x01FB5FA5 */)
			where TEventType : EventBase<TEventType>, new() {}
		public bool UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x01FB5FA6 */)
			where TEventType : EventBase<TEventType>, new() => default;
		public void InvokeCallbacks(EventBase evt, PropagationPhase propagationPhase) {} // 0x0000000189F19814-0x0000000189F1999C
		public bool HasTrickleDownHandlers() => default; // 0x0000000189F197FC-0x0000000189F19814
		public bool HasBubbleHandlers() => default; // 0x0000000189F197E4-0x0000000189F197FC
	}

	public interface IEventHandler // TypeDefIndex: 43629
	{
		// Methods
		void SendEvent(EventBase e);
		void HandleEvent(EventBase evt);
	}

	public abstract class CallbackEventHandler : IEventHandler // TypeDefIndex: 43630
	{
		// Fields
		internal bool isIMGUIContainer; // 0x10
		private EventCallbackRegistry m_CallbackRegistry; // 0x18
	
		// Constructors
		protected CallbackEventHandler() {} // 0x0000000183D557C0-0x0000000183D557D0
	
		// Methods
		public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x01FB5FA7 */)
			where TEventType : EventBase<TEventType>, new() {}
		internal void RegisterCallback<TEventType>(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x01FB5FA8 */)
			where TEventType : EventBase<TEventType>, new() {}
		public void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown /* Metadata: 0x01FB5FA9 */)
			where TEventType : EventBase<TEventType>, new() {}
		public abstract void SendEvent(EventBase e);
		internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode);
		internal void HandleEventAtTargetPhase(EventBase evt) {} // 0x0000000189F164D4-0x0000000189F16534
		internal void HandleEventAtTargetAndDefaultPhase(EventBase evt) {} // 0x0000000189F16490-0x0000000189F164D4
		internal void HandleEventAtCurrentTargetAndPhase(EventBase evt) {} // 0x000000018986C8A8-0x000000018986C8BC
		void IEventHandler.HandleEvent(EventBase evt) {} // 0x000000018986C8A8-0x000000018986C8BC
		public virtual void HandleEvent(EventBase evt) {} // 0x0000000189F16534-0x0000000189F16760
		public bool HasTrickleDownHandlers() => default; // 0x0000000189F1677C-0x0000000189F16798
		public bool HasBubbleUpHandlers() => default; // 0x0000000189F16760-0x0000000189F1677C
		protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) {} // 0x000000018350B670-0x000000018350B680
		protected virtual void ExecuteDefaultAction(EventBase evt) {} // 0x000000018350B670-0x000000018350B680
		internal virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt) {} // 0x000000018350B670-0x000000018350B680
		internal virtual void ExecuteDefaultActionDisabled(EventBase evt) {} // 0x000000018350B670-0x000000018350B680
	}

	public abstract class FocusEventBase<T> : EventBase<T> // TypeDefIndex: 43631
		where T : FocusEventBase<T>, new()
	{
		// Properties
		public Focusable relatedTarget { get; private set; }
		public FocusChangeDirection direction { get; private set; }
		protected FocusController focusController { get; private set; }
		internal bool IsFocusDelegated { get; private set; }
	
		// Constructors
		protected FocusEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated = false /* Metadata: 0x01FB5FAA */) => default;
	}

	public class FocusOutEvent : FocusEventBase<FocusOutEvent> // TypeDefIndex: 43632
	{
		// Constructors
		public FocusOutEvent() {} // 0x0000000189F1A5D8-0x0000000189F1A61C
	
		// Methods
		protected override void Init() {} // 0x0000000189F1A594-0x0000000189F1A5D8
		private new void LocalInit() {} // 0x0000000183D89170-0x0000000183D89180
	}

	public class BlurEvent : FocusEventBase<BlurEvent> // TypeDefIndex: 43633
	{
		// Constructors
		public BlurEvent() {} // 0x0000000189F16454-0x0000000189F16490
	
		// Methods
		protected internal override void PreDispatch(IPanel panel) {} // 0x0000000189F163F4-0x0000000189F16454
	}

	public class FocusInEvent : FocusEventBase<FocusInEvent> // TypeDefIndex: 43634
	{
		// Constructors
		public FocusInEvent() {} // 0x0000000189F1A550-0x0000000189F1A594
	
		// Methods
		protected override void Init() {} // 0x0000000189F1A50C-0x0000000189F1A550
		private new void LocalInit() {} // 0x0000000183D89170-0x0000000183D89180
	}

	public class FocusEvent : FocusEventBase<FocusEvent> // TypeDefIndex: 43635
	{
		// Constructors
		public FocusEvent() {} // 0x0000000189F1A4D0-0x0000000189F1A50C
	
		// Methods
		protected internal override void PreDispatch(IPanel panel) {} // 0x0000000189F1A460-0x0000000189F1A4D0
	}

	public enum PropagationPhase // TypeDefIndex: 43636
	{
		None = 0,
		TrickleDown = 1,
		AtTarget = 2,
		BubbleUp = 3,
		DefaultAction = 4,
		DefaultActionAtTarget = 5
	}

	internal interface IEventDispatchingStrategy // TypeDefIndex: 43637
	{
		// Methods
		bool CanDispatchEvent(EventBase evt);
		void DispatchEvent(EventBase evt, IPanel panel);
	}

	internal static class EventDispatchUtilities // TypeDefIndex: 43638
	{
		// Methods
		public static void PropagateEvent(EventBase evt) {} // 0x0000000189F19B94-0x0000000189F1A250
		internal static void PropagateToIMGUIContainer(VisualElement root, EventBase evt) {} // 0x0000000189F1A250-0x0000000189F1A424
		public static void ExecuteDefaultAction(EventBase evt, IPanel panel) {} // 0x0000000189F19AE8-0x0000000189F19B94
	}

	internal class IMGUIEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 43639
	{
		// Constructors
		public IMGUIEventDispatchingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x0000000189F1ACFC-0x0000000189F1AD3C
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x0000000189F1AD3C-0x0000000189F1AD80
	}

	public class InputEvent : EventBase<InputEvent> // TypeDefIndex: 43640
	{
		// Properties
		protected string previousData { get; set; } // 0x00000001851DFC94-0x00000001851DFCA4
		protected string newData { get; set; } // 0x0000000184274DA0-0x0000000184274DB4
	
		// Constructors
		public InputEvent() {} // 0x0000000189F1AFA8-0x0000000189F1B004
	
		// Methods
		protected override void Init() {} // 0x0000000189F1AF2C-0x0000000189F1AF70
		private new void LocalInit() {} // 0x0000000189F1AF70-0x0000000189F1AFA8
		public static InputEvent GetPooled(string previousData, string newData) => default; // 0x0000000189F1AE98-0x0000000189F1AF2C
	}

	internal class KeyboardEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 43641
	{
		// Constructors
		public KeyboardEventDispatchingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x0000000189F1B148-0x0000000189F1B188
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x0000000189F1B188-0x0000000189F1B2D4
	}

	public interface IKeyboardEvent // TypeDefIndex: 43642
	{
		// Properties
		EventModifiers modifiers { get; }
		char character { get; }
		KeyCode keyCode { get; }
	}

	public abstract class KeyboardEventBase<T> : EventBase<T>, IKeyboardEvent // TypeDefIndex: 43643
		where T : KeyboardEventBase<T>, new()
	{
		// Properties
		public EventModifiers modifiers { get; protected set; }
		public char character { get; protected set; }
		public KeyCode keyCode { get; protected set; }
		public bool shiftKey { get; }
		public bool ctrlKey { get; }
		public bool commandKey { get; }
		public bool altKey { get; }
		public bool actionKey { get; }
	
		// Constructors
		protected KeyboardEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers) => default;
		public static T GetPooled(UnityEngine.Event systemEvent) => default;
	}

	public class KeyDownEvent : KeyboardEventBase<KeyDownEvent> // TypeDefIndex: 43644
	{
		// Constructors
		public KeyDownEvent() {} // 0x0000000189F1B0D0-0x0000000189F1B10C
	
		// Methods
		internal void GetEquivalentImguiEvent(UnityEngine.Event outImguiEvent) {} // 0x0000000189F1B004-0x0000000189F1B0D0
	}

	public class KeyUpEvent : KeyboardEventBase<KeyUpEvent> // TypeDefIndex: 43645
	{
		// Constructors
		public KeyUpEvent() {} // 0x0000000189F1B10C-0x0000000189F1B148
	}

	public class GeometryChangedEvent : EventBase<GeometryChangedEvent> // TypeDefIndex: 43646
	{
		// Properties
		public Rect oldRect { get; private set; } // 0x0000000183D5AAF0-0x0000000183D5AB00 0x0000000183D68EB0-0x0000000183D68EC0
		public Rect newRect { get; private set; } // 0x0000000183D68BC0-0x0000000183D68BD0 0x0000000183D6C0C0-0x0000000183D6C0D0
		internal int layoutPass { get; set; } // 0x0000000183D50E50-0x0000000183D50E60 0x0000000183D50F20-0x0000000183D50F30
	
		// Constructors
		public GeometryChangedEvent() {} // 0x0000000189F1ACA0-0x0000000189F1ACFC
	
		// Methods
		public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect) => default; // 0x0000000189F1ABE0-0x0000000189F1AC5C
		protected override void Init() {} // 0x0000000189F1AC5C-0x0000000189F1ACA0
		private new void LocalInit() {} // 0x0000000183D89180-0x0000000183D891A0
	}

	internal class MouseCaptureDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 43648
	{
		// Nested types
		[Flags]
		private enum EventBehavior // TypeDefIndex: 43647
		{
			None = 0,
			IsCapturable = 1,
			IsSentExclusivelyToCapturingElement = 2
		}
	
		// Constructors
		public MouseCaptureDispatchingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x0000000189F1CB10-0x0000000189F1CB78
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x0000000189F1CB78-0x0000000189F1CFAC
	}

	internal class MouseEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 43649
	{
		// Constructors
		public MouseEventDispatchingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x0000000189F1D318-0x0000000189F1D358
		public void DispatchEvent(EventBase evt, IPanel iPanel) {} // 0x0000000189F1D358-0x0000000189F1D408
		private static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel) => default; // 0x0000000189F1D5DC-0x0000000189F1D618
		private static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel) => default; // 0x0000000189F1D5A8-0x0000000189F1D5DC
		private static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel) => default; // 0x0000000189F1D448-0x0000000189F1D5A8
		private static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel) {} // 0x0000000189F1D618-0x0000000189F1D69C
		private static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, out VisualElement elementUnderMouse) {
			elementUnderMouse = default;
		} // 0x0000000189F1D69C-0x0000000189F1D890
		private static bool IsDone(EventBase evt) => default; // 0x0000000189F1D408-0x0000000189F1D448
	}

	public interface IMouseEvent // TypeDefIndex: 43650
	{
		// Properties
		EventModifiers modifiers { get; }
		Vector2 mousePosition { get; }
		Vector2 localMousePosition { get; }
		Vector2 mouseDelta { get; }
		int clickCount { get; }
		int button { get; }
		int pressedButtons { get; }
		bool shiftKey { get; }
		bool ctrlKey { get; }
		bool commandKey { get; }
		bool altKey { get; }
	}

	internal interface IMouseEventInternal // TypeDefIndex: 43651
	{
		// Properties
		bool triggeredByOS { get; set; }
		bool recomputeTopElementUnderMouse { get; set; }
		IPointerEvent sourcePointerEvent { get; set; }
	}

	public abstract class MouseEventBase<T> : EventBase<T>, IMouseEvent, IMouseEventInternal // TypeDefIndex: 43652
		where T : MouseEventBase<T>, new()
	{
		// Properties
		public EventModifiers modifiers { get; protected set; }
		public Vector2 mousePosition { get; protected set; }
		public Vector2 localMousePosition { get; internal set; }
		public Vector2 mouseDelta { get; protected set; }
		public int clickCount { get; protected set; }
		public int button { get; protected set; }
		public int pressedButtons { get; protected set; }
		public bool shiftKey { get; }
		public bool ctrlKey { get; }
		public bool commandKey { get; }
		public bool altKey { get; }
		bool IMouseEventInternal.triggeredByOS { get; set; }
		bool IMouseEventInternal.recomputeTopElementUnderMouse { get; set; }
		IPointerEvent IMouseEventInternal.sourcePointerEvent { get; set; }
		public override IEventHandler currentTarget { get; internal set; }
	
		// Constructors
		protected MouseEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		protected internal override void PreDispatch(IPanel panel) {}
		protected internal override void PostDispatch(IPanel panel) {}
		public static T GetPooled(UnityEngine.Event systemEvent) => default;
		internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse) => default;
		public static T GetPooled(IMouseEvent triggerEvent) => default;
		protected static T GetPooled(IPointerEvent pointerEvent) => default;
	}

	public class MouseDownEvent : MouseEventBase<MouseDownEvent> // TypeDefIndex: 43653
	{
		// Constructors
		public MouseDownEvent() {} // 0x0000000189F1D128-0x0000000189F1D16C
	
		// Methods
		protected override void Init() {} // 0x0000000189F1D030-0x0000000189F1D074
		private new void LocalInit() {} // 0x0000000183D89160-0x0000000183D89170
		private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent) => default; // 0x0000000189F1D074-0x0000000189F1D128
		internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent) => default; // 0x0000000189F1D024-0x0000000189F1D030
		internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent) => default; // 0x0000000189F1D024-0x0000000189F1D030
	}

	public class MouseUpEvent : MouseEventBase<MouseUpEvent> // TypeDefIndex: 43654
	{
		// Constructors
		public MouseUpEvent() {} // 0x0000000189F1DF34-0x0000000189F1DF78
	
		// Methods
		protected override void Init() {} // 0x0000000189F1DE3C-0x0000000189F1DE80
		private new void LocalInit() {} // 0x0000000183D89160-0x0000000183D89170
		private static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent) => default; // 0x0000000189F1DE80-0x0000000189F1DF34
		internal static MouseUpEvent GetPooled(PointerUpEvent pointerEvent) => default; // 0x0000000189F1DE30-0x0000000189F1DE3C
		internal static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent) => default; // 0x0000000189F1DE30-0x0000000189F1DE3C
		internal static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent) => default; // 0x0000000189F1DE30-0x0000000189F1DE3C
	}

	public class MouseMoveEvent : MouseEventBase<MouseMoveEvent> // TypeDefIndex: 43655
	{
		// Constructors
		public MouseMoveEvent() {} // 0x0000000189F1DD74-0x0000000189F1DDB8
	
		// Methods
		protected override void Init() {} // 0x0000000189F1DD30-0x0000000189F1DD74
		private new void LocalInit() {} // 0x0000000183D891A0-0x0000000183D891B0
		internal static MouseMoveEvent GetPooled(PointerMoveEvent pointerEvent) => default; // 0x0000000189F1DCF4-0x0000000189F1DD30
	}

	public class ContextClickEvent : MouseEventBase<ContextClickEvent> // TypeDefIndex: 43656
	{
		// Constructors
		public ContextClickEvent() {} // 0x0000000189F16AA4-0x0000000189F16AE0
	}

	public class WheelEvent : MouseEventBase<WheelEvent> // TypeDefIndex: 43657
	{
		// Properties
		public Vector3 delta { get; private set; } // 0x0000000183D505C0-0x0000000183D505E0 0x0000000183D50630-0x0000000183D50650
	
		// Constructors
		public WheelEvent() {} // 0x0000000189F26060-0x0000000189F260BC
	
		// Methods
		public static new WheelEvent GetPooled(UnityEngine.Event systemEvent) => default; // 0x0000000189F25EE0-0x0000000189F25F74
		internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent) => default; // 0x0000000189F25F74-0x0000000189F25FE0
		protected override void Init() {} // 0x0000000189F25FE0-0x0000000189F2603C
		private new void LocalInit() {} // 0x0000000189F2603C-0x0000000189F26060
	}

	public class MouseEnterEvent : MouseEventBase<MouseEnterEvent> // TypeDefIndex: 43658
	{
		// Constructors
		public MouseEnterEvent() {} // 0x0000000189F1D1B0-0x0000000189F1D1F4
	
		// Methods
		protected override void Init() {} // 0x0000000189F1D16C-0x0000000189F1D1B0
		private new void LocalInit() {} // 0x0000000183D891B0-0x0000000183D891C0
	}

	public class MouseLeaveEvent : MouseEventBase<MouseLeaveEvent> // TypeDefIndex: 43659
	{
		// Constructors
		public MouseLeaveEvent() {} // 0x0000000189F1DAD8-0x0000000189F1DB1C
	
		// Methods
		protected override void Init() {} // 0x0000000189F1DA94-0x0000000189F1DAD8
		private new void LocalInit() {} // 0x0000000183D891B0-0x0000000183D891C0
	}

	public class MouseEnterWindowEvent : MouseEventBase<MouseEnterWindowEvent> // TypeDefIndex: 43660
	{
		// Constructors
		public MouseEnterWindowEvent() {} // 0x0000000189F1D2D4-0x0000000189F1D318
	
		// Methods
		protected override void Init() {} // 0x0000000189F1D1F4-0x0000000189F1D238
		private new void LocalInit() {} // 0x0000000183D891C0-0x0000000183D891D0
		protected internal override void PostDispatch(IPanel panel) {} // 0x0000000189F1D238-0x0000000189F1D2D4
	}

	public class MouseLeaveWindowEvent : MouseEventBase<MouseLeaveWindowEvent> // TypeDefIndex: 43661
	{
		// Constructors
		public MouseLeaveWindowEvent() {} // 0x0000000189F1DCA8-0x0000000189F1DCF4
	
		// Methods
		protected override void Init() {} // 0x0000000189F1DBB0-0x0000000189F1DBFC
		private new void LocalInit() {} // 0x0000000189F1DBFC-0x0000000189F1DC0C
		public static new MouseLeaveWindowEvent GetPooled(UnityEngine.Event systemEvent) => default; // 0x0000000189F1DB1C-0x0000000189F1DBB0
		protected internal override void PostDispatch(IPanel panel) {} // 0x0000000189F1DC0C-0x0000000189F1DCA8
	}

	public class MouseOverEvent : MouseEventBase<MouseOverEvent> // TypeDefIndex: 43662
	{
		// Constructors
		public MouseOverEvent() {} // 0x0000000189F1DDF4-0x0000000189F1DE30
	}

	public class MouseOutEvent : MouseEventBase<MouseOutEvent> // TypeDefIndex: 43663
	{
		// Constructors
		public MouseOutEvent() {} // 0x0000000189F1DDB8-0x0000000189F1DDF4
	}

	public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent> // TypeDefIndex: 43664
	{
		// Fields
		private ContextualMenuManager m_ContextualMenuManager; // 0xC8
	
		// Properties
		public DropdownMenu menu { get; private set; } // 0x0000000183D4E750-0x0000000183D4E760 0x00000001858AAF64-0x00000001858AAF78
		public EventBase triggerEvent { get; private set; } // 0x0000000183D50E60-0x0000000183D50E70 0x00000001858B426C-0x00000001858B4280
	
		// Constructors
		public ContextualMenuPopulateEvent() {} // 0x0000000189F16FDC-0x0000000189F17020
	
		// Methods
		public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager) => default; // 0x0000000189F16AE0-0x0000000189F16E5C
		protected override void Init() {} // 0x0000000189F16E5C-0x0000000189F16EA0
		private new void LocalInit() {} // 0x0000000189F16EA0-0x0000000189F16F08
		protected internal override void PostDispatch(IPanel panel) {} // 0x0000000189F16F08-0x0000000189F16FDC
	}

	internal static class MouseEventsHelper // TypeDefIndex: 43665
	{
		// Methods
		internal static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition)
			where TLeaveEvent : MouseEventBase<TLeaveEvent>, new()
			where TEnterEvent : MouseEventBase<TEnterEvent>, new() {}
		internal static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) {} // 0x0000000189F1D890-0x0000000189F1DA94
	}

	internal static class PointerEventsHelper // TypeDefIndex: 43666
	{
		// Methods
		internal static void SendEnterLeave<TLeaveEvent, TEnterEvent>(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId)
			where TLeaveEvent : PointerEventBase<TLeaveEvent>, new()
			where TEnterEvent : PointerEventBase<TEnterEvent>, new() {}
		internal static void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) {} // 0x0000000189F21254-0x0000000189F21464
	}

	internal class NavigationEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 43667
	{
		// Constructors
		public NavigationEventDispatchingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x0000000189F1EC98-0x0000000189F1ECD8
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x0000000189F1ECD8-0x0000000189F1ED54
	}

	public interface INavigationEvent // TypeDefIndex: 43668
	{
		// Properties
		bool shiftKey { get; }
		bool altKey { get; }
	}

	internal enum NavigationDeviceType // TypeDefIndex: 43669
	{
		Unknown = 0,
		Keyboard = 1,
		NonKeyboard = 2
	}

	public abstract class NavigationEventBase<T> : EventBase<T>, INavigationEvent // TypeDefIndex: 43670
		where T : NavigationEventBase<T>, new()
	{
		// Properties
		public EventModifiers modifiers { get; protected set; }
		public bool shiftKey { get; }
		public bool altKey { get; }
		private NavigationDeviceType deviceType { get; set; }
	
		// Constructors
		protected NavigationEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(EventModifiers modifiers = EventModifiers.None /* Metadata: 0x01FB5FB7 */) => default;
		internal static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers = EventModifiers.None /* Metadata: 0x01FB5FB8 */) => default;
	}

	public class NavigationMoveEvent : NavigationEventBase<NavigationMoveEvent> // TypeDefIndex: 43672
	{
		// Properties
		public Direction direction { get; private set; } // 0x0000000183D4F0B0-0x0000000183D4F0C0 0x0000000183D4F0E0-0x0000000183D4F0F0
		private Vector2 move { get; set; } // 0x0000000183D68020-0x0000000183D68030
	
		// Nested types
		public enum Direction // TypeDefIndex: 43671
		{
			None = 0,
			Left = 1,
			Up = 2,
			Right = 3,
			Down = 4,
			Next = 5,
			Previous = 6
		}
	
		// Constructors
		public NavigationMoveEvent() {} // 0x0000000189F1EEBC-0x0000000189F1EF08
	
		// Methods
		internal static Direction DetermineMoveDirection(float x, float y, float deadZone = 0.6f /* Metadata: 0x01FB5FB9 */) => default; // 0x0000000189F1ED54-0x0000000189F1EDC4
		public static NavigationMoveEvent GetPooled(Vector2 moveVector, EventModifiers modifiers = EventModifiers.None /* Metadata: 0x01FB5FBD */) => default; // 0x0000000189F1EDC4-0x0000000189F1EE60
		protected override void Init() {} // 0x0000000189F1EE60-0x0000000189F1EEAC
		private new void LocalInit() {} // 0x0000000189F1EEAC-0x0000000189F1EEBC
	}

	internal class NavigationTabEvent : NavigationEventBase<NavigationTabEvent> // TypeDefIndex: 43674
	{
		// Properties
		private Direction direction { get; set; } // 0x0000000183D4F0E0-0x0000000183D4F0F0
	
		// Nested types
		public enum Direction // TypeDefIndex: 43673
		{
			None = 0,
			Next = 1,
			Previous = 2
		}
	
		// Constructors
		public NavigationTabEvent() {} // 0x0000000189F1F000-0x0000000189F1F048
	
		// Methods
		internal static Direction DetermineMoveDirection(int moveValue) => default; // 0x0000000189F1EF44-0x0000000189F1EF58
		public static NavigationTabEvent GetPooled(int moveValue) => default; // 0x0000000189F1EF58-0x0000000189F1EFBC
		protected override void Init() {} // 0x0000000189F1EFBC-0x0000000189F1F000
	}

	public class NavigationCancelEvent : NavigationEventBase<NavigationCancelEvent> // TypeDefIndex: 43675
	{
		// Constructors
		public NavigationCancelEvent() {} // 0x0000000189F1EC5C-0x0000000189F1EC98
	}

	public class NavigationSubmitEvent : NavigationEventBase<NavigationSubmitEvent> // TypeDefIndex: 43676
	{
		// Constructors
		public NavigationSubmitEvent() {} // 0x0000000189F1EF08-0x0000000189F1EF44
	}

	public abstract class PanelChangedEventBase<T> : EventBase<T> // TypeDefIndex: 43677
		where T : PanelChangedEventBase<T>, new()
	{
		// Properties
		public IPanel originPanel { get; private set; }
		public IPanel destinationPanel { get; private set; }
	
		// Constructors
		protected PanelChangedEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(IPanel originPanel, IPanel destinationPanel) => default;
	}

	public class AttachToPanelEvent : PanelChangedEventBase<AttachToPanelEvent> // TypeDefIndex: 43678
	{
		// Constructors
		public AttachToPanelEvent() {} // 0x0000000189F163B8-0x0000000189F163F4
	}

	public class DetachFromPanelEvent : PanelChangedEventBase<DetachFromPanelEvent> // TypeDefIndex: 43679
	{
		// Constructors
		public DetachFromPanelEvent() {} // 0x0000000189F17260-0x0000000189F1729C
	}

	internal class PointerCaptureDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 43680
	{
		// Constructors
		public PointerCaptureDispatchingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x0000000189F20168-0x0000000189F201A8
		public void DispatchEvent(EventBase evt, IPanel panel) {} // 0x0000000189F201A8-0x0000000189F20484
	}

	internal static class PointerDeviceState // TypeDefIndex: 43683
	{
		// Fields
		private static PointerLocation[] s_PlayerPointerLocations; // 0x00
		private static int[] s_PressedButtons; // 0x08
		private static readonly IPanel[] s_PlayerPanelWithSoftPointerCapture; // 0x10
	
		// Nested types
		[Flags]
		internal enum LocationFlag // TypeDefIndex: 43681
		{
			None = 0,
			OutsidePanel = 1
		}
	
		private struct PointerLocation // TypeDefIndex: 43682
		{
			// Properties
			internal Vector2 Position { [IsReadOnly] get; private set; } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
			internal IPanel Panel { [IsReadOnly] get; private set; } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
			internal LocationFlag Flags { [IsReadOnly] get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
	
			// Methods
			internal void SetLocation(Vector2 position, IPanel panel) {} // 0x0000000189F214EC-0x0000000189F21570
		}
	
		// Constructors
		static PointerDeviceState() {} // 0x0000000189F20B9C-0x0000000189F20CC8
	
		// Methods
		internal static void RemovePanelData(IPanel panel) {} // 0x0000000189F20934-0x0000000189F20A8C
		public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType) {} // 0x0000000189F20A8C-0x0000000189F20B18
		public static void PressButton(int pointerId, int buttonId) {} // 0x0000000189F20780-0x0000000189F20828
		public static void ReleaseButton(int pointerId, int buttonId) {} // 0x0000000189F2088C-0x0000000189F20934
		public static void ReleaseAllButtons(int pointerId) {} // 0x0000000189F20828-0x0000000189F2088C
		public static Vector2 GetPointerPosition(int pointerId, ContextType contextType) => default; // 0x0000000189F205C0-0x0000000189F2062C
		public static IPanel GetPanel(int pointerId, ContextType contextType) => default; // 0x0000000189F204FC-0x0000000189F2055C
		private static bool HasFlagFast(LocationFlag flagSet, LocationFlag flag) => default; // 0x00000001891AEB04-0x00000001891AEB0C
		public static bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag) => default; // 0x0000000189F2070C-0x0000000189F20780
		public static int GetPressedButtons(int pointerId) => default; // 0x0000000189F2062C-0x0000000189F20690
		internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) => default; // 0x0000000189F20690-0x0000000189F2070C
		internal static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel) {} // 0x0000000189F20B18-0x0000000189F20B9C
		internal static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId) => default; // 0x0000000189F2055C-0x0000000189F205C0
	}

	internal class PointerEventDispatchingStrategy : IEventDispatchingStrategy // TypeDefIndex: 43684
	{
		// Constructors
		public PointerEventDispatchingStrategy() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public bool CanDispatchEvent(EventBase evt) => default; // 0x0000000189F20F4C-0x0000000189F20F8C
		public virtual void DispatchEvent(EventBase evt, IPanel panel) {} // 0x0000000189F20F8C-0x0000000189F20FC8
		private static void SendEventToTarget(EventBase evt) {} // 0x0000000189F20FC8-0x0000000189F20FF0
		private static void SetBestTargetForEvent(EventBase evt, IPanel panel) {} // 0x0000000189F20FF0-0x0000000189F21114
		private static void UpdateElementUnderPointer(EventBase evt, IPanel panel, out VisualElement elementUnderPointer) {
			elementUnderPointer = default;
		} // 0x0000000189F21114-0x0000000189F21254
	}

	public static class PointerType // TypeDefIndex: 43685
	{
		// Fields
		public static readonly string mouse; // 0x00
		public static readonly string touch; // 0x08
		public static readonly string pen; // 0x10
		public static readonly string unknown; // 0x18
	
		// Constructors
		static PointerType() {} // 0x0000000189F21B8C-0x0000000189F21C9C
	
		// Methods
		internal static string GetPointerType(int pointerId) => default; // 0x0000000189F21A8C-0x0000000189F21B18
		internal static bool IsDirectManipulationDevice(string pointerType) => default; // 0x0000000189F21B18-0x0000000189F21B8C
	}

	public static class PointerId // TypeDefIndex: 43686
	{
		// Fields
		public static readonly int maxPointers; // 0x00
		public static readonly int invalidPointerId; // 0x04
		public static readonly int mousePointerId; // 0x08
		public static readonly int touchPointerIdBase; // 0x0C
		public static readonly int touchPointerCount; // 0x10
		public static readonly int penPointerIdBase; // 0x14
		public static readonly int penPointerCount; // 0x18
		internal static readonly int[] hoveringPointers; // 0x20
	
		// Constructors
		static PointerId() {} // 0x0000000183B5B2B0-0x0000000183B5B3E0
	}

	public interface IPointerEvent // TypeDefIndex: 43687
	{
		// Properties
		int pointerId { get; }
		string pointerType { get; }
		bool isPrimary { get; }
		int button { get; }
		int pressedButtons { get; }
		Vector3 position { get; }
		Vector3 localPosition { get; }
		Vector3 deltaPosition { get; }
		float deltaTime { get; }
		int clickCount { get; }
		float pressure { get; }
		float tangentialPressure { get; }
		float altitudeAngle { get; }
		float azimuthAngle { get; }
		float twist { get; }
		Vector2 radius { get; }
		Vector2 radiusVariance { get; }
		EventModifiers modifiers { get; }
		bool shiftKey { get; }
		bool ctrlKey { get; }
		bool commandKey { get; }
		bool altKey { get; }
		bool actionKey { get; }
	}

	internal interface IPointerEventInternal // TypeDefIndex: 43688
	{
		// Properties
		bool triggeredByOS { get; set; }
		bool recomputeTopElementUnderPointer { get; set; }
	}

	public abstract class PointerEventBase<T> : EventBase<T>, IPointerEvent, IPointerEventInternal // TypeDefIndex: 43689
		where T : PointerEventBase<T>, new()
	{
		// Properties
		public int pointerId { get; protected set; }
		public string pointerType { get; protected set; }
		public bool isPrimary { get; protected set; }
		public int button { get; protected set; }
		public int pressedButtons { get; protected set; }
		public Vector3 position { get; protected set; }
		public Vector3 localPosition { get; protected set; }
		public Vector3 deltaPosition { get; protected set; }
		public float deltaTime { get; protected set; }
		public int clickCount { get; protected set; }
		public float pressure { get; protected set; }
		public float tangentialPressure { get; protected set; }
		public float altitudeAngle { get; protected set; }
		public float azimuthAngle { get; protected set; }
		public float twist { get; protected set; }
		public Vector2 radius { get; protected set; }
		public Vector2 radiusVariance { get; protected set; }
		public EventModifiers modifiers { get; protected set; }
		public bool shiftKey { get; }
		public bool ctrlKey { get; }
		public bool commandKey { get; }
		public bool altKey { get; }
		public bool actionKey { get; }
		bool IPointerEventInternal.triggeredByOS { get; set; }
		bool IPointerEventInternal.recomputeTopElementUnderPointer { get; set; }
		public override IEventHandler currentTarget { get; internal set; }
	
		// Constructors
		protected PointerEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		private static bool IsMouse(UnityEngine.Event systemEvent) => default;
		public static T GetPooled(UnityEngine.Event systemEvent) => default;
		public static T GetPooled(Touch touch, EventModifiers modifiers = EventModifiers.None /* Metadata: 0x01FB5FCA */) => default;
		internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId) => default;
		public static T GetPooled(IPointerEvent triggerEvent) => default;
		protected internal override void PreDispatch(IPanel panel) {}
		protected internal override void PostDispatch(IPanel panel) {}
	}

	public sealed class PointerDownEvent : PointerEventBase<PointerDownEvent> // TypeDefIndex: 43690
	{
		// Constructors
		public PointerDownEvent() {} // 0x0000000189F20E80-0x0000000189F20EC4
	
		// Methods
		protected override void Init() {} // 0x0000000189F20CC8-0x0000000189F20D0C
		private new void LocalInit() {} // 0x0000000189F20D0C-0x0000000189F20D34
		protected internal override void PostDispatch(IPanel panel) {} // 0x0000000189F20D34-0x0000000189F20E80
	}

	public sealed class PointerMoveEvent : PointerEventBase<PointerMoveEvent> // TypeDefIndex: 43691
	{
		// Properties
		internal bool isHandledByDraggable { get; set; } // 0x0000000183D57BB0-0x0000000183D57BC0 0x0000000183D89210-0x0000000183D89220
	
		// Constructors
		public PointerMoveEvent() {} // 0x0000000189F21920-0x0000000189F21964
	
		// Methods
		protected override void Init() {} // 0x0000000189F21570-0x0000000189F215B4
		private new void LocalInit() {} // 0x0000000189F215B4-0x0000000189F215E4
		protected internal override void PostDispatch(IPanel panel) {} // 0x0000000189F215E4-0x0000000189F21920
	}

	public sealed class PointerStationaryEvent : PointerEventBase<PointerStationaryEvent> // TypeDefIndex: 43692
	{
		// Constructors
		public PointerStationaryEvent() {} // 0x0000000189F21A48-0x0000000189F21A8C
	
		// Methods
		protected override void Init() {} // 0x0000000189F219DC-0x0000000189F21A20
		private new void LocalInit() {} // 0x0000000189F21A20-0x0000000189F21A48
	}

	public sealed class PointerUpEvent : PointerEventBase<PointerUpEvent> // TypeDefIndex: 43693
	{
		// Constructors
		public PointerUpEvent() {} // 0x0000000189F21EA4-0x0000000189F21EE8
	
		// Methods
		protected override void Init() {} // 0x0000000189F21C9C-0x0000000189F21CE0
		private new void LocalInit() {} // 0x0000000189F20D0C-0x0000000189F20D34
		protected internal override void PostDispatch(IPanel panel) {} // 0x0000000189F21CE0-0x0000000189F21EA4
	}

	public sealed class PointerCancelEvent : PointerEventBase<PointerCancelEvent> // TypeDefIndex: 43694
	{
		// Constructors
		public PointerCancelEvent() {} // 0x0000000189F20124-0x0000000189F20168
	
		// Methods
		protected override void Init() {} // 0x0000000189F1FF00-0x0000000189F1FF44
		private new void LocalInit() {} // 0x0000000189F1FF44-0x0000000189F1FF6C
		protected internal override void PostDispatch(IPanel panel) {} // 0x0000000189F1FF6C-0x0000000189F20124
	}

	public sealed class ClickEvent : PointerEventBase<ClickEvent> // TypeDefIndex: 43695
	{
		// Constructors
		public ClickEvent() {} // 0x0000000189F16890-0x0000000189F168D4
	
		// Methods
		protected override void Init() {} // 0x0000000189F1684C-0x0000000189F16890
		private new void LocalInit() {} // 0x0000000183D89160-0x0000000183D89170
		internal static ClickEvent GetPooled(PointerUpEvent pointerEvent, int clickCount) => default; // 0x0000000189F167E8-0x0000000189F1684C
	}

	public sealed class PointerEnterEvent : PointerEventBase<PointerEnterEvent> // TypeDefIndex: 43696
	{
		// Constructors
		public PointerEnterEvent() {} // 0x0000000189F20F08-0x0000000189F20F4C
	
		// Methods
		protected override void Init() {} // 0x0000000189F20EC4-0x0000000189F20F08
		private new void LocalInit() {} // 0x0000000183D89200-0x0000000183D89210
	}

	public sealed class PointerLeaveEvent : PointerEventBase<PointerLeaveEvent> // TypeDefIndex: 43697
	{
		// Constructors
		public PointerLeaveEvent() {} // 0x0000000189F214A8-0x0000000189F214EC
	
		// Methods
		protected override void Init() {} // 0x0000000189F21464-0x0000000189F214A8
		private new void LocalInit() {} // 0x0000000183D89200-0x0000000183D89210
	}

	public sealed class PointerOverEvent : PointerEventBase<PointerOverEvent> // TypeDefIndex: 43698
	{
		// Constructors
		public PointerOverEvent() {} // 0x0000000189F219A0-0x0000000189F219DC
	}

	public sealed class PointerOutEvent : PointerEventBase<PointerOutEvent> // TypeDefIndex: 43699
	{
		// Constructors
		public PointerOutEvent() {} // 0x0000000189F21964-0x0000000189F219A0
	}

	internal class PropagationPaths // TypeDefIndex: 43701
	{
		// Fields
		private static readonly UnityEngine.UIElements.ObjectPool<PropagationPaths> s_Pool; // 0x00
		public readonly List<VisualElement> trickleDownPath; // 0x10
		public readonly List<VisualElement> targetElements; // 0x18
		public readonly List<VisualElement> bubbleUpPath; // 0x20
		private const int k_DefaultPropagationDepth = 16; // Metadata: 0x01FB5FCB
		private const int k_DefaultTargetCount = 4; // Metadata: 0x01FB5FCC
	
		// Nested types
		[Flags]
		public enum Type // TypeDefIndex: 43700
		{
			None = 0,
			TrickleDown = 1,
			BubbleUp = 2
		}
	
		// Constructors
		public PropagationPaths() {} // 0x0000000189F22298-0x0000000189F22380
		static PropagationPaths() {} // 0x0000000189F22204-0x0000000189F22298
	
		// Methods
		internal static PropagationPaths Copy(PropagationPaths paths) => default; // 0x0000000189F22070-0x0000000189F2214C
		public static PropagationPaths Build(VisualElement elem, EventBase evt, Type pathTypesRequested) => default; // 0x0000000189F21EE8-0x0000000189F22070
		public void Release() {} // 0x0000000189F2214C-0x0000000189F22204
	}

	public class CustomStyleResolvedEvent : EventBase<CustomStyleResolvedEvent> // TypeDefIndex: 43702
	{
		// Properties
		public ICustomStyle customStyle { get => default; } // 0x0000000189F17074-0x0000000189F170D0 
	
		// Constructors
		public CustomStyleResolvedEvent() {} // 0x0000000189F17020-0x0000000189F17074
	}

	public class TooltipEvent : EventBase<TooltipEvent> // TypeDefIndex: 43703
	{
		// Properties
		public string tooltip { get; set; } // 0x00000001851DFC94-0x00000001851DFCA4
		public Rect rect { get; set; } // 0x0000000183D76370-0x0000000183D76380
	
		// Constructors
		public TooltipEvent() {} // 0x0000000189F22DB8-0x0000000189F22E14
	
		// Methods
		protected override void Init() {} // 0x0000000189F22D0C-0x0000000189F22D50
		private new void LocalInit() {} // 0x0000000189F22D50-0x0000000189F22DB8
	}

	public struct StylePropertyNameCollection : IEnumerable<StylePropertyName> // TypeDefIndex: 43705
	{
		// Fields
		internal List<StylePropertyName> propertiesList; // 0x00
	
		// Nested types
		public struct Enumerator : IEnumerator<StylePropertyName> // TypeDefIndex: 43704
		{
			// Fields
			private List<StylePropertyName> m_Enumerator; // 0x00
	
			// Properties
			public StylePropertyName Current { get => default; } // 0x0000000189F18700-0x0000000189F18744 
			object IEnumerator.Current { get => default; } // 0x0000000189F18694-0x0000000189F186EC 
	
			// Constructors
			internal Enumerator(List<StylePropertyName> enumerator) : this() {
				m_Enumerator = default;
			} // 0x0000000189F186EC-0x0000000189F18700
	
			// Methods
			public bool MoveNext() => default; // 0x0000000189F18658-0x0000000189F18694
			public void Reset() {} // 0x000000018350B670-0x000000018350B680
			public void Dispose() {} // 0x0000000189F18630-0x0000000189F18658
		}
	
		// Constructors
		internal StylePropertyNameCollection(List<StylePropertyName> list) {
			propertiesList = default;
		} // 0x00000001842715A0-0x00000001842715A8
	
		// Methods
		public Enumerator GetEnumerator() => default; // 0x0000000189F22BB8-0x0000000189F22C4C
		IEnumerator<StylePropertyName> IEnumerable<StylePropertyName>.GetEnumerator() => default; // 0x0000000189F22C4C-0x0000000189F22CAC
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x0000000189F22CAC-0x0000000189F22D0C
	}

	public abstract class TransitionEventBase<T> : EventBase<T> // TypeDefIndex: 43706
		where T : TransitionEventBase<T>, new()
	{
		// Properties
		public StylePropertyNameCollection stylePropertyNames { get; }
		protected double elapsedTime { get; set; }
	
		// Constructors
		protected TransitionEventBase() {}
	
		// Methods
		protected override void Init() {}
		private new void LocalInit() {}
		public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime) => default;
	}

	public sealed class TransitionRunEvent : TransitionEventBase<TransitionRunEvent> // TypeDefIndex: 43707
	{
		// Constructors
		public TransitionRunEvent() {} // 0x0000000189F22E8C-0x0000000189F22EC8
	}

	public sealed class TransitionStartEvent : TransitionEventBase<TransitionStartEvent> // TypeDefIndex: 43708
	{
		// Constructors
		public TransitionStartEvent() {} // 0x0000000189F22EC8-0x0000000189F22F04
	}

	public sealed class TransitionEndEvent : TransitionEventBase<TransitionEndEvent> // TypeDefIndex: 43709
	{
		// Constructors
		public TransitionEndEvent() {} // 0x0000000189F22E50-0x0000000189F22E8C
	}

	public sealed class TransitionCancelEvent : TransitionEventBase<TransitionCancelEvent> // TypeDefIndex: 43710
	{
		// Constructors
		public TransitionCancelEvent() {} // 0x0000000189F22E14-0x0000000189F22E50
	}

	public class IMGUIEvent : EventBase<IMGUIEvent> // TypeDefIndex: 43711
	{
		// Constructors
		public IMGUIEvent() {} // 0x0000000189F1AE3C-0x0000000189F1AE98
	
		// Methods
		public static IMGUIEvent GetPooled(UnityEngine.Event systemEvent) => default; // 0x0000000189F1AD80-0x0000000189F1ADF8
		protected override void Init() {} // 0x0000000189F1ADF8-0x0000000189F1AE3C
		private new void LocalInit() {} // 0x0000000183D891A0-0x0000000183D891B0
	}

	internal struct EventDebuggerLogCall : IDisposable // TypeDefIndex: 43712
	{
		// Constructors
		public EventDebuggerLogCall(Delegate callback, EventBase evt) {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x000000018350B670-0x000000018350B680
	}

	internal struct EventDebuggerLogIMGUICall : IDisposable // TypeDefIndex: 43713
	{
		// Constructors
		public EventDebuggerLogIMGUICall(EventBase evt) {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x000000018350B670-0x000000018350B680
	}

	internal struct EventDebuggerLogExecuteDefaultAction : IDisposable // TypeDefIndex: 43714
	{
		// Constructors
		public EventDebuggerLogExecuteDefaultAction(EventBase evt) {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void Dispose() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class EventDebugger // TypeDefIndex: 43715
	{
		// Constructors
		public EventDebugger() {} // Dummy constructor
	
		// Methods
		public static void LogPropagationPaths(EventBase evt, PropagationPaths paths) {} // 0x000000018350B670-0x000000018350B680
	}

	[Flags]
	internal enum DynamicAtlasFiltersInternal // TypeDefIndex: 43716
	{
		None = 0,
		Readability = 1,
		Size = 2,
		Format = 4,
		ColorSpace = 8,
		FilterMode = 16
	}

	[Serializable]
	public class DynamicAtlasSettings // TypeDefIndex: 43717
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int m_MinAtlasSize; // 0x10
		[HideInInspector]
		[SerializeField]
		private int m_MaxAtlasSize; // 0x14
		[HideInInspector]
		[SerializeField]
		private int m_MaxSubTextureSize; // 0x18
		[HideInInspector]
		[SerializeField]
		private DynamicAtlasFiltersInternal m_ActiveFilters; // 0x1C
		private DynamicAtlasCustomFilter m_CustomFilter; // 0x20
	
		// Properties
		public int minAtlasSize { get => default; set {} } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public int maxAtlasSize { get => default; set {} } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
		public int maxSubTextureSize { get => default; set {} } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public DynamicAtlasFilters activeFilters { get => default; set {} } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public static DynamicAtlasFilters defaultFilters { get => default; } // 0x0000000183D55C10-0x0000000183D55C20 
		public DynamicAtlasCustomFilter customFilter { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		public static DynamicAtlasSettings defaults { get => default; } // 0x0000000189F173F0-0x0000000189F17460 
	
		// Constructors
		public DynamicAtlasSettings() {} // 0x000000018350B670-0x000000018350B680
	}

	internal class NavigateFocusRing : IFocusRing // TypeDefIndex: 43720
	{
		// Fields
		public static readonly ChangeDirection Left; // 0x00
		public static readonly ChangeDirection Right; // 0x08
		public static readonly ChangeDirection Up; // 0x10
		public static readonly ChangeDirection Down; // 0x18
		public static readonly ChangeDirection Next; // 0x20
		public static readonly ChangeDirection Previous; // 0x28
		private readonly VisualElement m_Root; // 0x10
		private readonly VisualElementFocusRing m_Ring; // 0x18
	
		// Properties
		private FocusController focusController { get => default; } // 0x0000000189ED9FE4-0x0000000189EDA008 
	
		// Nested types
		public class ChangeDirection : FocusChangeDirection // TypeDefIndex: 43718
		{
			// Constructors
			public ChangeDirection() {} // Dummy constructor
			public ChangeDirection(int i) {} // 0x0000000189F16798-0x0000000189F167E8
		}
	
		private struct FocusableHierarchyTraversal // TypeDefIndex: 43719
		{
			// Fields
			public VisualElement currentFocusable; // 0x00
			public Rect validRect; // 0x08
			public bool firstPass; // 0x18
			public ChangeDirection direction; // 0x20
	
			// Methods
			private bool ValidateHierarchyTraversal(VisualElement v) => default; // 0x0000000189F1AB40-0x0000000189F1ABE0
			private bool ValidateElement(VisualElement v) => default; // 0x0000000189F1AAA0-0x0000000189F1AB40
			private int Order(VisualElement a, VisualElement b) => default; // 0x0000000189F1A718-0x0000000189F1A7C8
			private int StrictOrder(VisualElement a, VisualElement b) => default; // 0x0000000189F1A7C8-0x0000000189F1A844
			private int StrictOrder(Rect ra, Rect rb) => default; // 0x0000000189F1A844-0x0000000189F1A990
			private int TieBreaker(Rect ra, Rect rb) => default; // 0x0000000189F1A990-0x0000000189F1AAA0
			public VisualElement GetBestOverall(VisualElement candidate, VisualElement bestSoFar = null) => default; // 0x0000000189F1A61C-0x0000000189F1A718
		}
	
		// Constructors
		public NavigateFocusRing() {} // Dummy constructor
		public NavigateFocusRing(VisualElement root) {} // 0x0000000189F1EBD4-0x0000000189F1EC5C
		static NavigateFocusRing() {} // 0x0000000189F1E9C4-0x0000000189F1EBD4
	
		// Methods
		public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) => default; // 0x0000000189F1DF78-0x0000000189F1E2C0
		public virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) => default; // 0x0000000189F1E790-0x0000000189F1E93C
		private Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction) => default; // 0x0000000189F1E2C0-0x0000000189F1E790
		private static bool IsActive(VisualElement v) => default; // 0x0000000189F1E93C-0x0000000189F1E97C
		private static bool IsNavigable(Focusable focusable) => default; // 0x0000000189F1E97C-0x0000000189F1E9C4
	}

	public enum PanelScaleMode // TypeDefIndex: 43721
	{
		ConstantPixelSize = 0,
		ConstantPhysicalSize = 1,
		ScaleWithScreenSize = 2
	}

	public enum PanelScreenMatchMode // TypeDefIndex: 43722
	{
		MatchWidthOrHeight = 0,
		Shrink = 1,
		Expand = 2
	}

	public class PanelSettings : ScriptableObject // TypeDefIndex: 43724
	{
		// Fields
		private const int k_DefaultSortingOrder = 0; // Metadata: 0x01FB5FDC
		private const float k_DefaultScaleValue = 1f; // Metadata: 0x01FB5FDD
		internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset"; // Metadata: 0x01FB5FE1
		[SerializeField]
		private ThemeStyleSheet themeUss; // 0x18
		[SerializeField]
		private RenderTexture m_TargetTexture; // 0x20
		[SerializeField]
		private PanelScaleMode m_ScaleMode; // 0x28
		[SerializeField]
		private float m_Scale; // 0x2C
		private const float DefaultDpi = 96f; // Metadata: 0x01FB6031
		[SerializeField]
		private float m_ReferenceDpi; // 0x30
		[SerializeField]
		private float m_FallbackDpi; // 0x34
		[SerializeField]
		private Vector2Int m_ReferenceResolution; // 0x38
		[SerializeField]
		private PanelScreenMatchMode m_ScreenMatchMode; // 0x40
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Match; // 0x44
		[SerializeField]
		private float m_SortingOrder; // 0x48
		[SerializeField]
		private int m_TargetDisplay; // 0x4C
		[SerializeField]
		private bool m_ClearDepthStencil; // 0x50
		[SerializeField]
		private bool m_ClearColor; // 0x51
		[SerializeField]
		private UnityEngine.Color m_ColorClearValue; // 0x54
		private RuntimePanelAccess m_PanelAccess; // 0x68
		internal UIDocumentList m_AttachedUIDocumentsList; // 0x70
		[HideInInspector]
		[SerializeField]
		private DynamicAtlasSettings m_DynamicAtlasSettings; // 0x78
		[HideInInspector]
		[SerializeField]
		private Shader m_AtlasBlitShader; // 0x80
		[HideInInspector]
		[SerializeField]
		private Shader m_RuntimeShader; // 0x88
		[HideInInspector]
		[SerializeField]
		private Shader m_RuntimeWorldShader; // 0x90
		[SerializeField]
		public PanelTextSettings textSettings; // 0x98
		private Rect m_TargetRect; // 0xA0
		private float m_ResolvedScale; // 0xB0
		private StyleSheet m_OldThemeUss; // 0xB8
		internal int m_EmptyPanelCounter; // 0xC0
		private Func<Vector2, Vector2> m_AssignedScreenToPanel; // 0xC8
	
		// Properties
		public ThemeStyleSheet themeStyleSheet { get => default; set {} } // 0x0000000183D61D00-0x0000000183D61D10 0x0000000189F1FED8-0x0000000189F1FF00
		public RenderTexture targetTexture { get => default; set {} } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000189F1FEA8-0x0000000189F1FED8
		public PanelScaleMode scaleMode { get => default; set {} } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		public float scale { get => default; set {} } // 0x0000000183D4F3A0-0x0000000183D4F3B0 0x0000000183D4F3B0-0x0000000183D4F3C0
		public float referenceDpi { get => default; set {} } // 0x0000000183D4F5D0-0x0000000183D4F5E0 0x0000000189F1FE4C-0x0000000189F1FE78
		public float fallbackDpi { get => default; set {} } // 0x0000000183D56CA0-0x0000000183D56CB0 0x0000000189F1FE20-0x0000000189F1FE4C
		public Vector2Int referenceResolution { get => default; set {} } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x0000000183D4EE50-0x0000000183D4EE60
		public PanelScreenMatchMode screenMatchMode { get => default; set {} } // 0x0000000183D4ED80-0x0000000183D4ED90 0x0000000183D4EDB0-0x0000000183D4EDC0
		public float match { get => default; set {} } // 0x0000000183D4EC80-0x0000000183D4EC90 0x0000000183D4ED00-0x0000000183D4ED10
		public float sortingOrder { get => default; set {} } // 0x0000000183D58370-0x0000000183D58380 0x0000000189F1FE78-0x0000000189F1FE84
		public int targetDisplay { get => default; set {} } // 0x0000000183D4EDF0-0x0000000183D4EE00 0x0000000189F1FE84-0x0000000189F1FEA8
		public bool clearDepthStencil { get => default; set {} } // 0x0000000183D4F000-0x0000000183D4F010 0x0000000183D4F030-0x0000000183D4F040
		public float depthClearValue { get => default; } // 0x0000000183D891E0-0x0000000183D891F0 
		public bool clearColor { get => default; set {} } // 0x0000000183D518F0-0x0000000183D51900 0x0000000183D51900-0x0000000183D51910
		public UnityEngine.Color colorClearValue { get => default; set {} } // 0x0000000183D891D0-0x0000000183D891E0 0x0000000183D891F0-0x0000000183D89200
		internal BaseRuntimePanel panel { get => default; } // 0x0000000189F1FDD0-0x0000000189F1FDF0 
		internal VisualElement visualTree { get => default; } // 0x0000000189F1FDF0-0x0000000189F1FE20 
		public DynamicAtlasSettings dynamicAtlasSettings { get => default; set {} } // 0x0000000183D4EB20-0x0000000183D4EB30 0x00000001851DFCA4-0x00000001851DFCB4
		private float ScreenDPI { get; set; } // 0x0000000183D58470-0x0000000183D58480 0x0000000183D69550-0x0000000183D69560
	
		// Nested types
		private class RuntimePanelAccess // TypeDefIndex: 43723
		{
			// Fields
			private readonly PanelSettings m_Settings; // 0x10
			private BaseRuntimePanel m_RuntimePanel; // 0x18
	
			// Properties
			internal bool isInitialized { get => default; } // 0x0000000182702DB0-0x0000000182702DC0 
			internal BaseRuntimePanel panel { get => default; } // 0x0000000189F22754-0x0000000189F228D4 
	
			// Constructors
			public RuntimePanelAccess() {} // Dummy constructor
			internal RuntimePanelAccess(PanelSettings settings) {} // 0x000000018426FEE0-0x000000018426FEF0
	
			// Methods
			internal void DisposePanel() {} // 0x0000000189F225E8-0x0000000189F2261C
			internal void SetTargetTexture() {} // 0x0000000189F22718-0x0000000189F22754
			internal void SetSortingPriority() {} // 0x0000000189F226BC-0x0000000189F226EC
			internal void SetTargetDisplay() {} // 0x0000000189F226EC-0x0000000189F22718
			private BaseRuntimePanel CreateRelatedRuntimePanel() => default; // 0x0000000189F22534-0x0000000189F225E8
			private void DisposeRelatedPanel() {} // 0x0000000189F2261C-0x0000000189F2266C
			internal void MarkPotentiallyEmpty() {} // 0x0000000189F2266C-0x0000000189F226BC
		}
	
		// Constructors
		private PanelSettings() {} // 0x0000000189F1FCE8-0x0000000189F1FDD0
	
		// Methods
		internal void ApplySortingOrder() {} // 0x0000000189F1F4B8-0x0000000189F1F4D8
		private void Reset() {} // 0x000000018350B670-0x000000018350B680
		private void OnEnable() {} // 0x0000000189F1FABC-0x0000000189F1FB90
		private void OnDisable() {} // 0x0000000189F1F768-0x0000000189F1F788
		internal void DisposePanel() {} // 0x0000000189F1F768-0x0000000189F1F788
		internal void UpdateScreenDPI() {} // 0x0000000189F1FCC8-0x0000000189F1FCE8
		private void ApplyThemeStyleSheet(VisualElement root = null) {} // 0x0000000189F1F4D8-0x0000000189F1F638
		private void InitializeShaders() {} // 0x0000000189F1F954-0x0000000189F1FABC
		internal void ApplyPanelSettings() {} // 0x0000000189F1F048-0x0000000189F1F4B8
		public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screentoPanelSpaceFunction) {} // 0x0000000189F1FC80-0x0000000189F1FCC8
		internal float ResolveScale(Rect targetRect, float screenDpi) => default; // 0x0000000189F1FB90-0x0000000189F1FC80
		internal Rect GetDisplayRect() => default; // 0x0000000189F1F788-0x0000000189F1F954
		internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument) {} // 0x0000000189F1F638-0x0000000189F1F6EC
		internal void DetachUIDocument(UIDocument uiDocument) {} // 0x0000000189F1F6EC-0x0000000189F1F768
	}

	internal static class RuntimeEventDispatcher // TypeDefIndex: 43725
	{
		// Methods
		public static EventDispatcher Create() => default; // 0x0000000189F22380-0x0000000189F22534
	}

	internal class RuntimePanel : BaseRuntimePanel // TypeDefIndex: 43726
	{
		// Fields
		internal static readonly EventDispatcher s_EventDispatcher; // 0x00
		private readonly PanelSettings m_PanelSettings; // 0x1D8
	
		// Properties
		public PanelSettings panelSettings { get => default; } // 0x0000000183D50210-0x0000000183D50220 
	
		// Constructors
		public RuntimePanel() {} // Dummy constructor
		private RuntimePanel(ScriptableObject ownerObject) {} // 0x0000000189F22A00-0x0000000189F22BB8
		static RuntimePanel() {} // 0x0000000189F229B0-0x0000000189F22A00
	
		// Methods
		public static RuntimePanel Create(ScriptableObject ownerObject) => default; // 0x0000000189F228D4-0x0000000189F22934
		public override void Update() {} // 0x0000000189F22934-0x0000000189F229B0
	}

	internal class UIDocumentList // TypeDefIndex: 43727
	{
		// Fields
		internal List<UIDocument> m_AttachedUIDocuments; // 0x10
	
		// Constructors
		public UIDocumentList() {} // 0x0000000189F245B4-0x0000000189F2462C
	
		// Methods
		internal void RemoveFromListAndFromVisualTree(UIDocument uiDocument) {} // 0x0000000189F24548-0x0000000189F245B4
		internal void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, int firstInsertIndex = 0 /* Metadata: 0x01FB6035 */) {} // 0x0000000189F24230-0x0000000189F24548
	}

	[AddComponentMenu("UI Toolkit/UI Document")]
	[DefaultExecutionOrder(-100)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public sealed class UIDocument : MonoBehaviour // TypeDefIndex: 43728
	{
		// Fields
		internal const string k_RootStyleClassName = "unity-ui-document__root"; // Metadata: 0x01FB6036
		internal const string k_VisualElementNameSuffix = "-container"; // Metadata: 0x01FB604E
		private const int k_DefaultSortingOrder = 0; // Metadata: 0x01FB6059
		private static int s_CurrentUIDocumentCounter; // 0x00
		internal readonly int m_UIDocumentCreationIndex; // 0x18
		[SerializeField]
		private PanelSettings m_PanelSettings; // 0x20
		private PanelSettings m_PreviousPanelSettings; // 0x28
		[SerializeField]
		private UIDocument m_ParentUI; // 0x30
		private UIDocumentList m_ChildrenContent; // 0x38
		private List<UIDocument> m_ChildrenContentCopy; // 0x40
		[SerializeField]
		private VisualTreeAsset sourceAsset; // 0x48
		private VisualElement m_RootVisualElement; // 0x50
		private int m_FirstChildInsertIndex; // 0x58
		[SerializeField]
		private float m_SortingOrder; // 0x5C
	
		// Properties
		public PanelSettings panelSettings { get => default; set {} } // 0x0000000183D85A20-0x0000000183D85A30 0x0000000189F25320-0x0000000189F25624
		public UIDocument parentUI { get => default; private set {} } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public VisualTreeAsset visualTreeAsset { get => default; set {} } // 0x0000000183D87DB0-0x0000000183D87DC0 0x0000000189F25640-0x0000000189F25664
		public VisualElement rootVisualElement { get => default; } // 0x0000000183D87E30-0x0000000183D87E40 
		internal int firstChildInserIndex { get => default; } // 0x0000000183D4EF00-0x0000000183D4EF10 
		public float sortingOrder { get => default; set {} } // 0x0000000183D56C10-0x0000000183D56C20 0x0000000189F25624-0x0000000189F25640
	
		// Constructors
		private UIDocument() {} // 0x0000000189F252A0-0x0000000189F25320
	
		// Methods
		internal void ApplySortingOrder() {} // 0x0000000189F2478C-0x0000000189F24794
		private void Awake() {} // 0x0000000189F24794-0x0000000189F2479C
		private void OnEnable() {} // 0x0000000189F24878-0x0000000189F24928
		private void SetupFromHierarchy() {} // 0x0000000189F2519C-0x0000000189F25224
		private UIDocument FindUIDocumentParent() => default; // 0x0000000189F2479C-0x0000000189F24844
		internal void Reset() {} // 0x0000000189F250AC-0x0000000189F2519C
		private void AddChildAndInsertContentToVisualTree(UIDocument child) {} // 0x0000000189F2462C-0x0000000189F246D8
		private void RemoveChild(UIDocument child) {} // 0x0000000189F24FF0-0x0000000189F25004
		private void RecreateUI() {} // 0x0000000189F24BBC-0x0000000189F24FF0
		private void SetupRootClassList() {} // 0x0000000189F25224-0x0000000189F252A0
		private void AddRootVisualElementToTree() {} // 0x0000000189F246D8-0x0000000189F2478C
		private void RemoveFromHierarchy() {} // 0x0000000189F25004-0x0000000189F250AC
		private void OnDisable() {} // 0x0000000189F24844-0x0000000189F24878
		private void OnTransformChildrenChanged() {} // 0x0000000189F24928-0x0000000189F24B14
		private void OnTransformParentChanged() {} // 0x0000000189F24B14-0x0000000189F24B1C
		internal void ReactToHierarchyChanged() {} // 0x0000000189F24B1C-0x0000000189F24BBC
	}

	internal class UIRAtlasAllocator : IDisposable // TypeDefIndex: 43731
	{
		// Fields
		private AreaNode m_FirstUnpartitionedArea; // 0x30
		private Row[] m_OpenRows; // 0x38
		private int m_1SidePadding; // 0x40
		private int m_2SidePadding; // 0x44
		private static ProfilerMarker s_MarkerTryAllocate; // 0x00
	
		// Properties
		public int maxAtlasSize { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public int maxImageWidth { get; } // 0x0000000183D50CC0-0x0000000183D50CD0 
		public int maxImageHeight { get; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public int virtualWidth { get; private set; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
		public int virtualHeight { get; private set; } // 0x0000000181003B50-0x0000000181003B60 0x0000000181003B60-0x0000000181003B70
		public int physicalWidth { get; private set; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 0x0000000183D4E2F0-0x0000000183D4E300
		public int physicalHeight { get; private set; } // 0x0000000183D4EB90-0x0000000183D4EBA0 0x0000000183D4EBA0-0x0000000183D4EBB0
		protected bool disposed { get; private set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
	
		// Nested types
		private class Row // TypeDefIndex: 43729
		{
			// Fields
			private static UnityEngine.UIElements.ObjectPool<Row> s_Pool; // 0x00
			public int Cursor; // 0x20
	
			// Properties
			public int offsetX { get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
			public int offsetY { get; private set; } // 0x0000000183D50CC0-0x0000000183D50CD0 0x0000000183D595B0-0x0000000183D595C0
			public int width { get; private set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
			private int height { get; set; } // 0x0000000183D4EBC0-0x0000000183D4EBD0
	
			// Constructors
			public Row() {} // 0x000000018350B670-0x000000018350B680
			static Row() {} // 0x0000000189F3EAE4-0x0000000189F3EB78
	
			// Methods
			public static Row Acquire(int offsetX, int offsetY, int width, int height) => default; // 0x0000000189F3E9C0-0x0000000189F3EA64
			public void Release() {} // 0x0000000189F3EA64-0x0000000189F3EAE4
		}
	
		private class AreaNode // TypeDefIndex: 43730
		{
			// Fields
			private static UnityEngine.UIElements.ObjectPool<AreaNode> s_Pool; // 0x00
			public RectInt rect; // 0x10
			public AreaNode previous; // 0x20
			public AreaNode next; // 0x28
	
			// Constructors
			public AreaNode() {} // 0x000000018350B670-0x000000018350B680
			static AreaNode() {} // 0x0000000189F3593C-0x0000000189F359D0
	
			// Methods
			public static AreaNode Acquire(RectInt rect) => default; // 0x0000000189F3570C-0x0000000189F357A8
			public void Release() {} // 0x0000000189F3586C-0x0000000189F358DC
			public void RemoveFromChain() {} // 0x0000000189F358DC-0x0000000189F3593C
			public void AddAfter(AreaNode previous) {} // 0x0000000189F357A8-0x0000000189F3586C
		}
	
		// Constructors
		public UIRAtlasAllocator() {} // Dummy constructor
		public UIRAtlasAllocator(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1 /* Metadata: 0x01FB605A */) {} // 0x0000000189F25D28-0x0000000189F25EA4
		static UIRAtlasAllocator() {} // 0x0000000189F25CC8-0x0000000189F25D28
	
		// Methods
		public void Dispose() {} // 0x0000000189F257D0-0x0000000189F25820
		protected virtual void Dispose(bool disposing) {} // 0x0000000189F2573C-0x0000000189F257D0
		private static int GetLog2OfNextPower(int n) => default; // 0x0000000189F25820-0x0000000189F25848
		public bool TryAllocate(int width, int height, out RectInt location) {
			location = default;
			return default;
		} // 0x0000000189F25848-0x0000000189F25B3C
		private bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth) => default; // 0x0000000189F25B3C-0x0000000189F25CC8
		private void BuildAreas() {} // 0x0000000189F25664-0x0000000189F2573C
	}

	internal class DynamicAtlasPage : IDisposable // TypeDefIndex: 43732
	{
		// Fields
		private readonly int m_1Padding; // 0x38
		private readonly int m_2Padding; // 0x3C
		private Allocator2D m_Allocator; // 0x40
		private TextureBlitter m_Blitter; // 0x48
		private Vector2Int m_CurrentSize; // 0x50
		private static int s_TextureCounter; // 0x00
	
		// Properties
		public TextureId textureId { get; private set; } // 0x0000000183D4E340-0x0000000183D4E350 0x00000001810410F0-0x0000000181041100
		public RenderTexture atlas { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
		public RenderTextureFormat format { get; } // 0x0000000181003B50-0x0000000181003B60 
		public UnityEngine.FilterMode filterMode { get; } // 0x0000000183D4E2E0-0x0000000183D4E2F0 
		protected bool disposed { get; private set; } // 0x0000000183D4F7E0-0x0000000183D4F7F0 0x0000000183D4F7F0-0x0000000183D4F800
	
		// Constructors
		public DynamicAtlasPage() {} // Dummy constructor
		public DynamicAtlasPage(RenderTextureFormat format, UnityEngine.FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize) {} // 0x0000000189F38A40-0x0000000189F38B6C
	
		// Methods
		public void Dispose() {} // 0x0000000189F382FC-0x0000000189F3834C
		protected virtual void Dispose(bool disposing) {} // 0x0000000189F38198-0x0000000189F382FC
		public bool TryAdd(Texture2D image, out Allocator2D.Alloc2D alloc, out RectInt rect) {
			alloc = default;
			rect = default;
			return default;
		} // 0x0000000189F38400-0x0000000189F385CC
		public void Update(Texture2D image, RectInt rect) {} // 0x0000000189F388F0-0x0000000189F38A40
		public void Remove(Allocator2D.Alloc2D alloc) {} // 0x0000000189F3834C-0x0000000189F38400
		public void Commit() {} // 0x0000000189F3803C-0x0000000189F3807C
		private void UpdateAtlasTexture() {} // 0x0000000189F385CC-0x0000000189F388F0
		private RenderTexture CreateAtlasTexture() => default; // 0x0000000189F3807C-0x0000000189F38198
	}

	internal class UIRLayoutUpdater : BaseVisualTreeUpdater // TypeDefIndex: 43733
	{
		// Fields
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
		private List<KeyValuePair<Rect, VisualElement>> changeEventsList; // 0x20
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x0000000189F43350-0x0000000189F433A0 
	
		// Constructors
		public UIRLayoutUpdater() {} // 0x0000000189F432D8-0x0000000189F43350
		static UIRLayoutUpdater() {} // 0x0000000189F43244-0x0000000189F432D8
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x0000000189F42B80-0x0000000189F42BB8
		public override void Update() {} // 0x0000000189F4307C-0x0000000189F43244
		private void UpdateSubTree(VisualElement ve, bool isDisplayed, List<KeyValuePair<Rect, VisualElement>> changeEvents) {} // 0x0000000189F42BB8-0x0000000189F4307C
		private void DispatchChangeEvents(List<KeyValuePair<Rect, VisualElement>> changeEvents, int currentLayoutPass) {} // 0x0000000189F42914-0x0000000189F42B80
	}

	public struct Vertex // TypeDefIndex: 43734
	{
		// Fields
		public static readonly float nearZ; // 0x00
		public Vector3 position; // 0x00
		public Color32 tint; // 0x0C
		public Vector2 uv; // 0x10
		internal Color32 xformClipPages; // 0x18
		internal Color32 ids; // 0x1C
		internal Color32 flags; // 0x20
		internal Color32 opacityColorPages; // 0x24
		internal Vector4 circle; // 0x28
		internal float textureId; // 0x38
	}

	public class MeshWriteData // TypeDefIndex: 43735
	{
		// Fields
		internal NativeSlice<UnityEngine.UIElements.Vertex> m_Vertices; // 0x10
		internal NativeSlice<ushort> m_Indices; // 0x20
		internal Rect m_UVRegion; // 0x30
		internal int currentIndex; // 0x40
		internal int currentVertex; // 0x44
	
		// Properties
		public int vertexCount { get => default; } // 0x0000000189F3CA84-0x0000000189F3CAB8 
		public int indexCount { get => default; } // 0x0000000189F3CA50-0x0000000189F3CA84 
		public Rect uvRegion { get => default; } // 0x0000000183D87900-0x0000000183D87910 
	
		// Constructors
		internal MeshWriteData() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void SetNextVertex(UnityEngine.UIElements.Vertex vertex) {} // 0x0000000189F3C9CC-0x0000000189F3CA50
		public void SetNextIndex(ushort index) {} // 0x0000000189F3C978-0x0000000189F3C9CC
		public void SetAllVertices(UnityEngine.UIElements.Vertex[] vertices) {} // 0x0000000189F3C8C0-0x0000000189F3C978
		public void SetAllIndices(ushort[] indices) {} // 0x0000000189F3C808-0x0000000189F3C8C0
		internal void Reset(NativeSlice<UnityEngine.UIElements.Vertex> vertices, NativeSlice<ushort> indices) {} // 0x0000000183D89260-0x0000000183D89290
		internal void Reset(NativeSlice<UnityEngine.UIElements.Vertex> vertices, NativeSlice<ushort> indices, Rect uvRegion) {} // 0x0000000183D89290-0x0000000183D892B0
	}

	internal struct ColorPage // TypeDefIndex: 43736
	{
		// Fields
		public bool isValid; // 0x00
		public Color32 pageAndID; // 0x04
	
		// Methods
		public static ColorPage Init(RenderChain renderChain, BMPAlloc alloc) => default; // 0x0000000189F36250-0x0000000189F362F4
	}

	internal static class MeshGenerationContextUtils // TypeDefIndex: 43740
	{
		// Nested types
		public struct BorderParams // TypeDefIndex: 43737
		{
			// Fields
			public Rect rect; // 0x00
			public UnityEngine.Color playmodeTintColor; // 0x10
			public UnityEngine.Color leftColor; // 0x20
			public UnityEngine.Color topColor; // 0x30
			public UnityEngine.Color rightColor; // 0x40
			public UnityEngine.Color bottomColor; // 0x50
			public float leftWidth; // 0x60
			public float topWidth; // 0x64
			public float rightWidth; // 0x68
			public float bottomWidth; // 0x6C
			public Vector2 topLeftRadius; // 0x70
			public Vector2 topRightRadius; // 0x78
			public Vector2 bottomRightRadius; // 0x80
			public Vector2 bottomLeftRadius; // 0x88
			public Material material; // 0x90
			internal ColorPage leftColorPage; // 0x98
			internal ColorPage topColorPage; // 0xA0
			internal ColorPage rightColorPage; // 0xA8
			internal ColorPage bottomColorPage; // 0xB0
		}
	
		public struct RectangleParams // TypeDefIndex: 43738
		{
			// Fields
			public Rect rect; // 0x00
			public Rect uv; // 0x10
			public UnityEngine.Color color; // 0x20
			public Texture texture; // 0x30
			public Sprite sprite; // 0x38
			public VectorImage vectorImage; // 0x40
			public Material material; // 0x48
			public UnityEngine.ScaleMode scaleMode; // 0x50
			public UnityEngine.Color playmodeTintColor; // 0x54
			public Vector2 topLeftRadius; // 0x64
			public Vector2 topRightRadius; // 0x6C
			public Vector2 bottomRightRadius; // 0x74
			public Vector2 bottomLeftRadius; // 0x7C
			public int leftSlice; // 0x84
			public int topSlice; // 0x88
			public int rightSlice; // 0x8C
			public int bottomSlice; // 0x90
			public float sliceScale; // 0x94
			internal Rect spriteGeomRect; // 0x98
			public Vector4 rectInset; // 0xA8
			internal ColorPage colorPage; // 0xB8
			internal MeshGenerationContext.MeshFlags meshFlags; // 0xC0
	
			// Methods
			private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, UnityEngine.ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) {
				rectOut = default;
				uvOut = default;
			} // 0x0000000189F3D260-0x0000000189F3D468
			private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, UnityEngine.ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) {
				rectOut = default;
				uvOut = default;
			} // 0x0000000189F3CAB8-0x0000000189F3D260
			private static Rect RectIntersection(Rect a, Rect b) => default; // 0x0000000189F3E434-0x0000000189F3E588
			private static Rect ComputeGeomRect(Sprite sprite) => default; // 0x0000000189F3D618-0x0000000189F3D75C
			private static Rect ComputeUVRect(Sprite sprite) => default; // 0x0000000189F3D75C-0x0000000189F3D8A0
			private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation) => default; // 0x0000000189F3D468-0x0000000189F3D618
			public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, UnityEngine.ScaleMode scaleMode, ContextType panelContext) => default; // 0x0000000189F3E0F8-0x0000000189F3E2B0
			public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, UnityEngine.ScaleMode scaleMode, ContextType panelContext, bool hasRadius, ref Vector4 slices) => default; // 0x0000000189F3D900-0x0000000189F3E0F8
			public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, UnityEngine.ScaleMode scaleMode, ContextType panelContext) => default; // 0x0000000189F3E2B0-0x0000000189F3E434
			internal bool HasRadius(float epsilon) => default; // 0x0000000189F3D8A0-0x0000000189F3D900
		}
	
		public struct TextParams // TypeDefIndex: 43739
		{
			// Fields
			public Rect rect; // 0x00
			public string text; // 0x10
			public Font font; // 0x18
			public FontDefinition fontDefinition; // 0x20
			public int fontSize; // 0x30
			public Length letterSpacing; // 0x34
			public Length wordSpacing; // 0x3C
			public Length paragraphSpacing; // 0x44
			public FontStyle fontStyle; // 0x4C
			public UnityEngine.Color fontColor; // 0x50
			public TextAnchor anchor; // 0x60
			public bool wordWrap; // 0x64
			public float wordWrapWidth; // 0x68
			public bool richText; // 0x6C
			public UnityEngine.Color playmodeTintColor; // 0x70
			public TextOverflow textOverflow; // 0x80
			public TextOverflowPosition textOverflowPosition; // 0x84
			public OverflowInternal overflow; // 0x88
			public IPanel panel; // 0x90
	
			// Methods
			public override int GetHashCode() => default; // 0x0000000189F409A8-0x0000000189F40B7C
			internal static TextParams MakeStyleBased(VisualElement ve, string text) => default; // 0x0000000189F40F74-0x0000000189F412AC
			internal static TextNativeSettings GetTextNativeSettings(TextParams textParams, float scaling) => default; // 0x0000000189F40B7C-0x0000000189F40F74
		}
	
		// Methods
		private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length) => default; // 0x0000000189F3C458-0x0000000189F3C4B8
		public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight) {
			topLeft = default;
			bottomLeft = default;
			topRight = default;
			bottomRight = default;
		} // 0x0000000189F3C4B8-0x0000000189F3C614
		public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref RectangleParams rectParams) {} // 0x0000000189F3C350-0x0000000189F3C458
	
		// Extension methods
		public static void Rectangle(this MeshGenerationContext mgc, RectangleParams rectParams) {} // 0x0000000189F3C614-0x0000000189F3C6CC
		public static void Text(this MeshGenerationContext mgc, TextParams textParams, ITextHandle handle, float pixelsPerPoint) {} // 0x0000000189F3C6CC-0x0000000189F3C808
	}

	public class MeshGenerationContext // TypeDefIndex: 43742
	{
		// Fields
		internal IStylePainter painter; // 0x10
	
		// Nested types
		[Flags]
		internal enum MeshFlags // TypeDefIndex: 43741
		{
			None = 0,
			UVisDisplacement = 1,
			SkipDynamicAtlas = 2
		}
	
		// Constructors
		public MeshGenerationContext() {} // Dummy constructor
		internal MeshGenerationContext(IStylePainter painter) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	internal class UIRRepaintUpdater : BaseVisualTreeUpdater // TypeDefIndex: 43743
	{
		// Fields
		private BaseVisualElementPanel attachedPanel; // 0x20
		internal RenderChain renderChain; // 0x28
		private static readonly string s_Description; // 0x00
		private static readonly ProfilerMarker s_ProfilerMarker; // 0x08
	
		// Properties
		public override ProfilerMarker profilerMarker { get => default; } // 0x0000000189F441BC-0x0000000189F4420C 
		public bool drawStats { get; } // 0x0000000183D4EF60-0x0000000183D4EF70 
		public bool breakBatches { get; } // 0x0000000183D4F2C0-0x0000000183D4F2D0 
		protected bool disposed { get; private set; } // 0x0000000183D4F630-0x0000000183D4F640 0x0000000183D4F640-0x0000000183D4F650
	
		// Constructors
		public UIRRepaintUpdater() {} // 0x0000000189F44140-0x0000000189F441BC
		static UIRRepaintUpdater() {} // 0x0000000189F44040-0x0000000189F44140
	
		// Methods
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) {} // 0x0000000189F43D38-0x0000000189F43E78
		public override void Update() {} // 0x0000000189F43F08-0x0000000189F44040
		protected virtual RenderChain CreateRenderChain() => default; // 0x0000000189F43578-0x0000000189F435DC
		private static void OnGraphicsResourcesRecreate(bool recreate) {} // 0x0000000189F438B0-0x0000000189F43A08
		private void OnPanelChanged(BaseVisualElementPanel obj) {} // 0x0000000189F43A10-0x0000000189F43A30
		private void AttachToPanel() {} // 0x0000000189F433A0-0x0000000189F43578
		private void DetachFromPanel() {} // 0x0000000189F43634-0x0000000189F437EC
		private void InitRenderChain() {} // 0x0000000189F43810-0x0000000189F438B0
		internal void DestroyRenderChain() {} // 0x0000000189F435DC-0x0000000189F43634
		private void OnPanelAtlasChanged() {} // 0x0000000189F43A08-0x0000000189F43A10
		private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) {} // 0x0000000189F43A30-0x0000000189F43A90
		private void OnPanelStandardShaderChanged() {} // 0x0000000189F43A90-0x0000000189F43BE4
		private void OnPanelStandardWorldSpaceShaderChanged() {} // 0x0000000189F43BE4-0x0000000189F43D38
		private void ResetAllElementsDataRecursive(VisualElement ve) {} // 0x0000000189F43E78-0x0000000189F43F08
		protected override void Dispose(bool disposing) {} // 0x0000000189F437EC-0x0000000189F43810
	}

	internal struct TextureId // TypeDefIndex: 43744
	{
		// Fields
		private readonly int m_Index; // 0x00
		public static readonly TextureId invalid; // 0x00
	
		// Properties
		public int index { get => default; } // 0x0000000183D5B1A0-0x0000000183D5B1B0 
	
		// Constructors
		public TextureId(int index) : this() {
			m_Index = default;
		} // 0x0000000183D5B1B0-0x0000000183D5B1C0
		static TextureId() {
			invalid = default;
		} // 0x0000000189F41368-0x0000000189F413A4
	
		// Methods
		public float ConvertToGpu() => default; // 0x0000000189F412AC-0x0000000189F412F8
		public override bool Equals(object obj) => default; // 0x0000000189F412F8-0x0000000189F41368
		public override int GetHashCode() => default; // 0x0000000183D85860-0x0000000183D85870
		public static bool operator ==(TextureId left, TextureId right) => default; // 0x0000000186505FF4-0x0000000186505FFC
		public static bool operator !=(TextureId left, TextureId right) => default; // 0x0000000189F413A4-0x0000000189F413EC
	}

	internal class TextureRegistry // TypeDefIndex: 43746
	{
		// Fields
		private List<TextureInfo> m_Textures; // 0x10
		private Dictionary<Texture, TextureId> m_TextureToId; // 0x18
		private Stack<TextureId> m_FreeIds; // 0x20
		internal const int maxTextures = 2048; // Metadata: 0x01FB605E
	
		// Properties
		public static TextureRegistry instance { get; } // 0x0000000189F41F8C-0x0000000189F41FDC 
	
		// Nested types
		private struct TextureInfo // TypeDefIndex: 43745
		{
			// Fields
			public Texture texture; // 0x00
			public bool dynamic; // 0x08
			public int refCount; // 0x0C
		}
	
		// Constructors
		public TextureRegistry() {} // 0x0000000189F41E78-0x0000000189F41F8C
		static TextureRegistry() {} // 0x0000000189F41E08-0x0000000189F41E78
	
		// Methods
		public Texture GetTexture(TextureId id) => default; // 0x0000000189F41824-0x0000000189F419A4
		public TextureId AllocAndAcquireDynamic() => default; // 0x0000000189F4155C-0x0000000189F4156C
		public void UpdateDynamic(TextureId id, Texture texture) {} // 0x0000000189F41BEC-0x0000000189F41E08
		private TextureId AllocAndAcquire(Texture texture, bool dynamic) => default; // 0x0000000189F4156C-0x0000000189F41824
		public TextureId Acquire(Texture tex) => default; // 0x0000000189F413EC-0x0000000189F4155C
		public void Release(TextureId id) {} // 0x0000000189F419A4-0x0000000189F41BEC
	}

	internal static class UIRUtility // TypeDefIndex: 43747
	{
		// Fields
		public static readonly string k_DefaultShaderName; // 0x00
		public static readonly string k_DefaultWorldSpaceShaderName; // 0x08
	
		// Constructors
		static UIRUtility() {} // 0x0000000189F44430-0x0000000189F44958
	
		// Methods
		public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef) => default; // 0x0000000189F443C4-0x0000000189F44430
		public static bool IsRoundRect(VisualElement ve) => default; // 0x0000000189F442E8-0x0000000189F4434C
		public static bool IsVectorImageBackground(VisualElement ve) => default; // 0x0000000189F4434C-0x0000000189F443C4
		public static bool IsElementSelfHidden(VisualElement ve) => default; // 0x0000000189F442C8-0x0000000189F442E8
		public static void Destroy(UnityEngine.Object obj) {} // 0x0000000189F4420C-0x0000000189F4428C
		public static int GetPrevPow2(int n) => default; // 0x0000000189F442B0-0x0000000189F442C8
		public static int GetNextPow2(int n) => default; // 0x0000000189F442A0-0x0000000189F442B0
		public static int GetNextPow2Exp(int n) => default; // 0x0000000189F4428C-0x0000000189F442A0
	}

	public enum AngleUnit // TypeDefIndex: 43748
	{
		Degree = 0,
		Gradian = 1,
		Radian = 2,
		Turn = 3
	}

	public struct Angle : IEquatable<Angle> // TypeDefIndex: 43750
	{
		// Fields
		private float m_Value; // 0x00
		private Unit m_Unit; // 0x04
	
		// Properties
		public float value { get => default; } // 0x0000000183D4FA00-0x0000000183D4FA10 
	
		// Nested types
		private enum Unit // TypeDefIndex: 43749
		{
			Degree = 0,
			Gradian = 1,
			Radian = 2,
			Turn = 3,
			None = 4
		}
	
		// Constructors
		public Angle(float value, AngleUnit unit) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x0000000183D4F9E0-0x0000000183D4F9F0
		private Angle(float value, Unit unit) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x0000000183D4F9E0-0x0000000183D4F9F0
	
		// Methods
		internal static Angle None() => default; // 0x0000000183D89220-0x0000000183D89240
		public float ToDegrees() => default; // 0x0000000189F35548-0x0000000189F355A0
		public static implicit operator Angle(float value) => default; // 0x0000000183D89240-0x0000000183D89260
		public static bool operator ==(Angle lhs, Angle rhs) => default; // 0x0000000189F356E0-0x0000000189F3570C
		public bool Equals(Angle other) => default; // 0x0000000189F35514-0x0000000189F35528
		public override bool Equals(object obj) => default; // 0x0000000189F354A4-0x0000000189F35514
		public override int GetHashCode() => default; // 0x0000000189F35528-0x0000000189F35548
		public override string ToString() => default; // 0x0000000189F355A0-0x0000000189F356E0
	}

	public struct Background : IEquatable<Background> // TypeDefIndex: 43751
	{
		// Fields
		private Texture2D m_Texture; // 0x00
		private Sprite m_Sprite; // 0x08
		private RenderTexture m_RenderTexture; // 0x10
		private VectorImage m_VectorImage; // 0x18
	
		// Properties
		public Texture2D texture { get => default; set {} } // 0x000000018253BE20-0x000000018253BE30 0x0000000189F36120-0x0000000189F361B8
		public Sprite sprite { get => default; set {} } // 0x0000000183D85A90-0x0000000183D85AA0 0x0000000189F36088-0x0000000189F36120
		public RenderTexture renderTexture { get => default; set {} } // 0x0000000183D66B80-0x0000000183D66B90 0x0000000189F35FF0-0x0000000189F36088
		public VectorImage vectorImage { get => default; set {} } // 0x0000000183D61D00-0x0000000183D61D10 0x0000000189F361B8-0x0000000189F36250
	
		// Methods
		public static Background FromTexture2D(Texture2D t) => default; // 0x0000000189F35CD4-0x0000000189F35D18
		public static Background FromRenderTexture(RenderTexture rt) => default; // 0x0000000189F35C4C-0x0000000189F35C90
		public static Background FromSprite(Sprite s) => default; // 0x0000000189F35C90-0x0000000189F35CD4
		public static Background FromVectorImage(VectorImage vi) => default; // 0x0000000189F35D18-0x0000000189F35D5C
		internal static Background FromObject(object obj) => default; // 0x0000000189F35AA4-0x0000000189F35C4C
		public static bool operator ==(Background lhs, Background rhs) => default; // 0x0000000189F35EF4-0x0000000189F35FB4
		public static bool operator !=(Background lhs, Background rhs) => default; // 0x0000000189F35FB4-0x0000000189F35FF0
		public bool Equals(Background other) => default; // 0x0000000189F35A64-0x0000000189F35AA4
		public override bool Equals(object obj) => default; // 0x0000000189F359D0-0x0000000189F35A64
		public override int GetHashCode() => default; // 0x0000000189F35D5C-0x0000000189F35DF8
		public override string ToString() => default; // 0x0000000189F35DF8-0x0000000189F35EF4
	}

	internal struct ComputedStyle // TypeDefIndex: 43752
	{
		// Fields
		public StyleDataRef<InheritedData> inheritedData; // 0x00
		public StyleDataRef<UnityEngine.UIElements.LayoutData> layoutData; // 0x08
		public StyleDataRef<RareData> rareData; // 0x10
		public StyleDataRef<UnityEngine.UIElements.TransformData> transformData; // 0x18
		public StyleDataRef<TransitionData> transitionData; // 0x20
		public StyleDataRef<VisualData> visualData; // 0x28
		public YogaNode yogaNode; // 0x30
		public Dictionary<string, StylePropertyValue> customProperties; // 0x38
		public long matchingRulesHash; // 0x40
		public float dpiScaling; // 0x48
		public ComputedTransitionProperty[] computedTransitions; // 0x50
	
		// Properties
		public int customPropertiesCount { get => default; } // 0x0000000189F33FD4-0x0000000189F3401C 
		public bool hasTransition { get => default; } // 0x0000000189F341DC-0x0000000189F341F0 
		public Align alignContent { get => default; } // 0x0000000189F33A24-0x0000000189F33A64 
		public Align alignItems { get => default; } // 0x0000000189F33A64-0x0000000189F33AA4 
		public Align alignSelf { get => default; } // 0x0000000189F33AA4-0x0000000189F33AE4 
		public UnityEngine.Color backgroundColor { get => default; } // 0x0000000189F33AE4-0x0000000189F33B34 
		public Background backgroundImage { get => default; } // 0x0000000189F33B34-0x0000000189F33B90 
		public UnityEngine.Color borderBottomColor { get => default; } // 0x0000000189F33B90-0x0000000189F33BE4 
		public Length borderBottomLeftRadius { get => default; } // 0x0000000189F33BE4-0x0000000189F33C24 
		public Length borderBottomRightRadius { get => default; } // 0x0000000189F33C24-0x0000000189F33C64 
		public float borderBottomWidth { get => default; } // 0x0000000189F33C64-0x0000000189F33CA4 
		public UnityEngine.Color borderLeftColor { get => default; } // 0x0000000189F33CA4-0x0000000189F33CF8 
		public float borderLeftWidth { get => default; } // 0x0000000189F33CF8-0x0000000189F33D38 
		public UnityEngine.Color borderRightColor { get => default; } // 0x0000000189F33D38-0x0000000189F33D8C 
		public float borderRightWidth { get => default; } // 0x0000000189F33D8C-0x0000000189F33DCC 
		public UnityEngine.Color borderTopColor { get => default; } // 0x0000000189F33DCC-0x0000000189F33E20 
		public Length borderTopLeftRadius { get => default; } // 0x0000000189F33E20-0x0000000189F33E64 
		public Length borderTopRightRadius { get => default; } // 0x0000000189F33E64-0x0000000189F33EA8 
		public float borderTopWidth { get => default; } // 0x0000000189F33EA8-0x0000000189F33EE8 
		public Length bottom { get => default; } // 0x0000000189F33EE8-0x0000000189F33F28 
		public UnityEngine.Color color { get => default; } // 0x0000000189F33F28-0x0000000189F33F78 
		public UnityEngine.UIElements.Cursor cursor { get => default; } // 0x0000000189F33F78-0x0000000189F33FD4 
		public DisplayStyle display { get => default; } // 0x0000000189F3401C-0x0000000189F3405C 
		public Length flexBasis { get => default; } // 0x0000000189F3405C-0x0000000189F3409C 
		public FlexDirection flexDirection { get => default; } // 0x0000000189F3409C-0x0000000189F340DC 
		public float flexGrow { get => default; } // 0x0000000189F340DC-0x0000000189F3411C 
		public float flexShrink { get => default; } // 0x0000000189F3411C-0x0000000189F3415C 
		public Wrap flexWrap { get => default; } // 0x0000000189F3415C-0x0000000189F3419C 
		public Length fontSize { get => default; } // 0x0000000189F3419C-0x0000000189F341DC 
		public Length height { get => default; } // 0x0000000189F341F0-0x0000000189F34230 
		public Justify justifyContent { get => default; } // 0x0000000189F34230-0x0000000189F34270 
		public Length left { get => default; } // 0x0000000189F34270-0x0000000189F342B0 
		public Length letterSpacing { get => default; } // 0x0000000189F342B0-0x0000000189F342F0 
		public Length marginBottom { get => default; } // 0x0000000189F342F0-0x0000000189F34330 
		public Length marginLeft { get => default; } // 0x0000000189F34330-0x0000000189F34370 
		public Length marginRight { get => default; } // 0x0000000189F34370-0x0000000189F343B0 
		public Length marginTop { get => default; } // 0x0000000189F343B0-0x0000000189F343F0 
		public Length maxHeight { get => default; } // 0x0000000189F343F0-0x0000000189F34430 
		public Length maxWidth { get => default; } // 0x0000000189F34430-0x0000000189F34470 
		public Length minHeight { get => default; } // 0x0000000189F34470-0x0000000189F344B4 
		public Length minWidth { get => default; } // 0x0000000189F344B4-0x0000000189F344F8 
		public float opacity { get => default; } // 0x0000000189F344F8-0x0000000189F3453C 
		public OverflowInternal overflow { get => default; } // 0x0000000189F3453C-0x0000000189F34580 
		public Length paddingBottom { get => default; } // 0x0000000189F34580-0x0000000189F345C4 
		public Length paddingLeft { get => default; } // 0x0000000189F345C4-0x0000000189F34608 
		public Length paddingRight { get => default; } // 0x0000000189F34608-0x0000000189F3464C 
		public Length paddingTop { get => default; } // 0x0000000189F3464C-0x0000000189F34690 
		public Position position { get => default; } // 0x0000000189F34690-0x0000000189F346D4 
		public Length right { get => default; } // 0x0000000189F346D4-0x0000000189F34718 
		public Rotate rotate { get => default; } // 0x0000000189F34718-0x0000000189F34774 
		public Scale scale { get => default; } // 0x0000000189F34774-0x0000000189F347C8 
		public TextOverflow textOverflow { get => default; } // 0x0000000189F347C8-0x0000000189F34808 
		public TextShadow textShadow { get => default; } // 0x0000000189F34808-0x0000000189F34868 
		public Length top { get => default; } // 0x0000000189F34868-0x0000000189F348AC 
		public TransformOrigin transformOrigin { get => default; } // 0x0000000189F348AC-0x0000000189F34904 
		public List<TimeValue> transitionDelay { get => default; } // 0x0000000189F34904-0x0000000189F34944 
		public List<TimeValue> transitionDuration { get => default; } // 0x0000000189F34944-0x0000000189F34984 
		public List<StylePropertyName> transitionProperty { get => default; } // 0x0000000189F34984-0x0000000189F349C4 
		public List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction { get => default; } // 0x0000000189F349C4-0x0000000189F34A04 
		public Translate translate { get => default; } // 0x0000000189F34A04-0x0000000189F34A60 
		public UnityEngine.Color unityBackgroundImageTintColor { get => default; } // 0x0000000189F34A60-0x0000000189F34AB4 
		public UnityEngine.ScaleMode unityBackgroundScaleMode { get => default; } // 0x0000000189F34AB4-0x0000000189F34AF4 
		public Font unityFont { get => default; } // 0x0000000189F34B84-0x0000000189F34BC4 
		public FontDefinition unityFontDefinition { get => default; } // 0x0000000189F34AF4-0x0000000189F34B44 
		public FontStyle unityFontStyleAndWeight { get => default; } // 0x0000000189F34B44-0x0000000189F34B84 
		public OverflowClipBox unityOverflowClipBox { get => default; } // 0x0000000189F34BC4-0x0000000189F34C04 
		public Length unityParagraphSpacing { get => default; } // 0x0000000189F34C04-0x0000000189F34C44 
		public int unitySliceBottom { get => default; } // 0x0000000189F34C44-0x0000000189F34C84 
		public int unitySliceLeft { get => default; } // 0x0000000189F34C84-0x0000000189F34CC4 
		public int unitySliceRight { get => default; } // 0x0000000189F34CC4-0x0000000189F34D04 
		public int unitySliceTop { get => default; } // 0x0000000189F34D04-0x0000000189F34D44 
		public TextAnchor unityTextAlign { get => default; } // 0x0000000189F34D44-0x0000000189F34D84 
		public UnityEngine.Color unityTextOutlineColor { get => default; } // 0x0000000189F34D84-0x0000000189F34DD4 
		public float unityTextOutlineWidth { get => default; } // 0x0000000189F34DD4-0x0000000189F34E14 
		public TextOverflowPosition unityTextOverflowPosition { get => default; } // 0x0000000189F34E14-0x0000000189F34E54 
		public Visibility visibility { get => default; } // 0x0000000189F34E54-0x0000000189F34E94 
		public WhiteSpace whiteSpace { get => default; } // 0x0000000189F34E94-0x0000000189F34ED4 
		public Length width { get => default; } // 0x0000000189F34ED4-0x0000000189F34F18 
		public Length wordSpacing { get => default; } // 0x0000000189F34F18-0x0000000189F354A4 
	
		// Methods
		public void FinalizeApply(ref ComputedStyle parentStyle) {} // 0x0000000189F2DCD0-0x0000000189F2DDEC
		public void SyncWithLayout(YogaNode targetNode) {} // 0x0000000189F33604-0x0000000189F33A24
		private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle) => default; // 0x0000000189F275BC-0x0000000189F2764C
		private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle) => default; // 0x0000000189F2764C-0x0000000189F2766C
		private void RemoveCustomStyleProperty(StylePropertyReader reader) {} // 0x0000000189F2DEB4-0x0000000189F2DF48
		private void ApplyCustomStyleProperty(StylePropertyReader reader) {} // 0x0000000189F2621C-0x0000000189F26304
		private void ApplyAllPropertyInitial() {} // 0x0000000189F261D0-0x0000000189F2621C
		private void ResetComputedTransitions() {} // 0x0000000185D62B3C-0x0000000185D62B50
		public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y) => default; // 0x0000000189F2D4D8-0x0000000189F2D818
		public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189F2F808-0x0000000189F2F928
		public static ComputedStyle Create(ref ComputedStyle parentStyle) => default; // 0x0000000189F2DAE4-0x0000000189F2DCD0
		public static ComputedStyle CreateInitial() => default; // 0x0000000189F2D944-0x0000000189F2DAE4
		public ComputedStyle Acquire() => default; // 0x0000000189F260BC-0x0000000189F261D0
		public void Release() {} // 0x0000000189F2DDEC-0x0000000189F2DEB4
		public void CopyFrom(ref ComputedStyle other) {} // 0x0000000189F2D818-0x0000000189F2D944
		public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle) {} // 0x0000000189F28DF4-0x0000000189F2A07C
		public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle) {} // 0x0000000189F2C3FC-0x0000000189F2D18C
		public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle) {} // 0x0000000189F2C0EC-0x0000000189F2C3FC
		public void ApplyStyleCursor(UnityEngine.UIElements.Cursor cursor) {} // 0x0000000189F2BED8-0x0000000189F2BF38
		public void ApplyStyleTextShadow(TextShadow st) {} // 0x0000000189F2BFE0-0x0000000189F2C040
		public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other) {} // 0x0000000189F26304-0x0000000189F275BC
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue) {} // 0x0000000189F2A508-0x0000000189F2ADF0
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue) {} // 0x0000000189F2A1C0-0x0000000189F2A508
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue) {} // 0x0000000189F2AF30-0x0000000189F2B4D4
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, UnityEngine.Color newValue) {} // 0x0000000189F2BC6C-0x0000000189F2BED8
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue) {} // 0x0000000189F2B894-0x0000000189F2B9E0
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue) {} // 0x0000000189F2ADF0-0x0000000189F2AF30
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue) {} // 0x0000000189F2B9E0-0x0000000189F2BB24
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue) {} // 0x0000000189F2BB24-0x0000000189F2BC6C
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue) {} // 0x0000000189F2B4D4-0x0000000189F2B618
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue) {} // 0x0000000189F2B754-0x0000000189F2B894
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue) {} // 0x0000000189F2A07C-0x0000000189F2A1C0
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue) {} // 0x0000000189F2B618-0x0000000189F2B754
		public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189F315AC-0x0000000189F33604
		public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189F2DF48-0x0000000189F2F808
		public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<float, float> easingCurve) => default; // 0x0000000189F2F928-0x0000000189F315AC
		public void ApplyStyleTransformOrigin(TransformOrigin st) {} // 0x0000000189F2C040-0x0000000189F2C094
		public void ApplyStyleTranslate(Translate translateValue) {} // 0x0000000189F2C094-0x0000000189F2C0EC
		public void ApplyStyleRotate(Rotate rotateValue) {} // 0x0000000189F2BF38-0x0000000189F2BF90
		public void ApplyStyleScale(Scale scaleValue) {} // 0x0000000189F2BF90-0x0000000189F2BFE0
		public void ApplyInitialValue(StylePropertyReader reader) {} // 0x0000000189F2766C-0x0000000189F276B4
		public void ApplyInitialValue(StylePropertyId id) {} // 0x0000000189F276B4-0x0000000189F28DF4
		public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle) {} // 0x0000000189F2D18C-0x0000000189F2D1C0
		public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle) {} // 0x0000000189F2D1C0-0x0000000189F2D4D8
	}

	internal struct ComputedTransitionProperty // TypeDefIndex: 43753
	{
		// Fields
		public StylePropertyId id; // 0x00
		public int durationMs; // 0x04
		public int delayMs; // 0x08
		public Func<float, float> easingCurve; // 0x10
	}

	internal static class ComputedTransitionUtils // TypeDefIndex: 43755
	{
		// Fields
		private static List<ComputedTransitionProperty> s_ComputedTransitionsBuffer; // 0x00
	
		// Constructors
		static ComputedTransitionUtils() {} // 0x0000000189F37FB0-0x0000000189F3803C
	
		// Methods
		internal static void UpdateComputedTransitions(ref ComputedStyle computedStyle) {} // 0x0000000189F37F58-0x0000000189F37FB0
		private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle) => default; // 0x0000000189F3752C-0x0000000189F376A4
		private static int GetTransitionHashCode(ref ComputedStyle cs) => default; // 0x0000000189F376A4-0x0000000189F37B28
		internal static bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y) => default; // 0x0000000189F37D80-0x0000000189F37E90
		private static bool SameTransitionProperty(List<StylePropertyName> a, List<StylePropertyName> b) => default; // 0x0000000189F37CB8-0x0000000189F37D80
		private static bool SameTransitionProperty(List<TimeValue> a, List<TimeValue> b) => default; // 0x0000000189F37E90-0x0000000189F37F58
		private static void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, List<ComputedTransitionProperty> outData) {} // 0x0000000189F362F4-0x0000000189F3654C
		private static T GetWrappingTransitionData<T>(List<T> list, int i, T defaultValue) => default;
		private static int ConvertTransitionTime(TimeValue time) => default; // 0x0000000189F37500-0x0000000189F3752C
		private static Func<float, float> ConvertTransitionFunction(EasingMode mode) => default; // 0x0000000189F3654C-0x0000000189F37500
	
		// Extension methods
		internal static bool HasTransitionProperty(this ref ComputedStyle computedStyle, StylePropertyId id) => default; // 0x0000000189F37C10-0x0000000189F37CB8
		internal static bool GetTransitionProperty(this ref ComputedStyle computedStyle, StylePropertyId id, out ComputedTransitionProperty result) {
			result = default;
			return default;
		} // 0x0000000189F37B28-0x0000000189F37C10
	}

	public struct CustomStyleProperty<T> : IEquatable<CustomStyleProperty<T>> // TypeDefIndex: 43756
	{
		// Properties
		public string name { [IsReadOnly] get; private set; }
	
		// Constructors
		public CustomStyleProperty(string propertyName) : this() {}
	
		// Methods
		public override bool Equals(object obj) => default;
		public bool Equals(CustomStyleProperty<T> other) => default;
		public override int GetHashCode() => default;
	}

	public interface ICustomStyle // TypeDefIndex: 43757
	{
		// Methods
		bool TryGetValue(CustomStyleProperty<float> property, out float value);
		bool TryGetValue(CustomStyleProperty<int> property, out int value);
		bool TryGetValue(CustomStyleProperty<UnityEngine.Color> property, out UnityEngine.Color value);
		bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value);
		bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value);
		bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value);
		bool TryGetValue(CustomStyleProperty<string> property, out string value);
	}

	public enum EasingMode // TypeDefIndex: 43758
	{
		Ease = 0,
		EaseIn = 1,
		EaseOut = 2,
		EaseInOut = 3,
		Linear = 4,
		EaseInSine = 5,
		EaseOutSine = 6,
		EaseInOutSine = 7,
		EaseInCubic = 8,
		EaseOutCubic = 9,
		EaseInOutCubic = 10,
		EaseInCirc = 11,
		EaseOutCirc = 12,
		EaseInOutCirc = 13,
		EaseInElastic = 14,
		EaseOutElastic = 15,
		EaseInOutElastic = 16,
		EaseInBack = 17,
		EaseOutBack = 18,
		EaseInOutBack = 19,
		EaseInBounce = 20,
		EaseOutBounce = 21,
		EaseInOutBounce = 22
	}

	public struct EasingFunction : IEquatable<UnityEngine.UIElements.EasingFunction> // TypeDefIndex: 43759
	{
		// Fields
		private EasingMode m_Mode; // 0x00
	
		// Properties
		public EasingMode mode { get => default; } // 0x0000000183D4E980-0x0000000183D4E990 
	
		// Constructors
		public EasingFunction(EasingMode mode) : this() {
			m_Mode = default;
		} // 0x0000000183D4E970-0x0000000183D4E980
	
		// Methods
		public static implicit operator EasingFunction(EasingMode easingMode) => default; // 0x0000000183D86CF0-0x0000000183D86D00
		public static bool operator ==(EasingFunction lhs, EasingFunction rhs) => default; // 0x0000000186505FF4-0x0000000186505FFC
		public bool Equals(EasingFunction other) => default; // 0x00000001895CAFF8-0x00000001895CB000
		public override bool Equals(object obj) => default; // 0x0000000189F38B6C-0x0000000189F38BD4
		public override string ToString() => default; // 0x0000000189F38BD4-0x0000000189F38C24
		public override int GetHashCode() => default; // 0x0000000183D85860-0x0000000183D85870
	}

	public struct FontDefinition : IEquatable<FontDefinition> // TypeDefIndex: 43760
	{
		// Fields
		private Font m_Font; // 0x00
		private FontAsset m_FontAsset; // 0x08
	
		// Properties
		public Font font { get => default; } // 0x000000018253BE20-0x000000018253BE30 
		public FontAsset fontAsset { get => default; } // 0x0000000183D85A90-0x0000000183D85AA0 
	
		// Methods
		public static FontDefinition FromFont(Font f) => default; // 0x0000000189F38CE4-0x0000000189F38D1C
		public static FontDefinition FromSDFFont(FontAsset f) => default; // 0x0000000189F38E10-0x0000000189F38E48
		internal static FontDefinition FromObject(object obj) => default; // 0x0000000189F38D1C-0x0000000189F38E10
		internal bool IsEmpty() => default; // 0x0000000189F38F10-0x0000000189F38F94
		public override string ToString() => default; // 0x0000000189F38F94-0x0000000189F3900C
		public bool Equals(FontDefinition other) => default; // 0x0000000189F38C9C-0x0000000189F38CE4
		public override bool Equals(object obj) => default; // 0x0000000189F38C24-0x0000000189F38C9C
		public override int GetHashCode() => default; // 0x0000000189F38E48-0x0000000189F38F10
		public static bool operator ==(FontDefinition left, FontDefinition right) => default; // 0x0000000189F3900C-0x0000000189F3902C
		public static bool operator !=(FontDefinition left, FontDefinition right) => default; // 0x0000000189F3902C-0x0000000189F3904C
	}

	internal class StyleValueCollection // TypeDefIndex: 43761
	{
		// Fields
		internal List<StyleValue> m_Values; // 0x10
	
		// Constructors
		public StyleValueCollection() {} // 0x0000000189F4045C-0x0000000189F404D4
	
		// Methods
		public StyleLength GetStyleLength(StylePropertyId id) => default; // 0x0000000189F4013C-0x0000000189F401CC
		public StyleFloat GetStyleFloat(StylePropertyId id) => default; // 0x0000000189F40068-0x0000000189F400D0
		public StyleInt GetStyleInt(StylePropertyId id) => default; // 0x0000000189F400D0-0x0000000189F4013C
		public bool TryGetStyleValue(StylePropertyId id, ref StyleValue value) => default; // 0x0000000189F402FC-0x0000000189F4045C
		public void SetStyleValue(StyleValue value) {} // 0x0000000189F401CC-0x0000000189F402FC
	}

	internal class InlineStyleAccess : StyleValueCollection, IStyle // TypeDefIndex: 43763
	{
		// Fields
		private static StylePropertyReader s_StylePropertyReader; // 0x00
		private List<StyleValueManaged> m_ValuesManaged; // 0x18
		private bool m_HasInlineCursor; // 0x28
		private StyleCursor m_InlineCursor; // 0x30
		private bool m_HasInlineTextShadow; // 0x50
		private StyleTextShadow m_InlineTextShadow; // 0x54
		private bool m_HasInlineTransformOrigin; // 0x74
		private StyleTransformOrigin m_InlineTransformOrigin; // 0x78
		private bool m_HasInlineTranslate; // 0x90
		private StyleTranslate m_InlineTranslateOperation; // 0x94
		private bool m_HasInlineRotate; // 0xB0
		private StyleRotate m_InlineRotateOperation; // 0xB4
		private bool m_HasInlineScale; // 0xD0
		private StyleScale m_InlineScale; // 0xD4
		private InlineRule m_InlineRule; // 0xE8
	
		// Properties
		private VisualElement ve { get; set; } // 0x0000000183D4EB40-0x0000000183D4EB50 0x0000000184271930-0x0000000184271940
		StyleCursor IStyle.cursor { get => default; } // 0x0000000189F3A7FC-0x0000000189F3A864 
		StyleTextShadow IStyle.textShadow { get => default; } // 0x0000000189F3A9E8-0x0000000189F3AA50 
		StyleTransformOrigin IStyle.transformOrigin { get => default; } // 0x0000000189F3AA50-0x0000000189F3AAC0 
		StyleTranslate IStyle.translate { get => default; set {} } // 0x0000000189F3AAC0-0x0000000189F3AB40 0x0000000189F3BE1C-0x0000000189F3BE74
		StyleRotate IStyle.rotate { get => default; } // 0x0000000189F3A900-0x0000000189F3A980 
		StyleScale IStyle.scale { get => default; } // 0x0000000189F3A980-0x0000000189F3A9E8 
		StyleColor IStyle.backgroundColor { set {} } // 0x0000000189F3AB7C-0x0000000189F3ABCC
		StyleColor IStyle.borderBottomColor { set {} } // 0x0000000189F3ABCC-0x0000000189F3AC1C
		StyleLength IStyle.borderBottomLeftRadius { set {} } // 0x0000000189F3AC1C-0x0000000189F3AC70
		StyleLength IStyle.borderBottomRightRadius { set {} } // 0x0000000189F3AC70-0x0000000189F3ACC4
		StyleFloat IStyle.borderBottomWidth { set {} } // 0x0000000189F3ACC4-0x0000000189F3AD40
		StyleColor IStyle.borderLeftColor { set {} } // 0x0000000189F3AD40-0x0000000189F3AD90
		StyleFloat IStyle.borderLeftWidth { set {} } // 0x0000000189F3AD90-0x0000000189F3AE0C
		StyleColor IStyle.borderRightColor { set {} } // 0x0000000189F3AE0C-0x0000000189F3AE5C
		StyleFloat IStyle.borderRightWidth { set {} } // 0x0000000189F3AE5C-0x0000000189F3AED8
		StyleColor IStyle.borderTopColor { set {} } // 0x0000000189F3AED8-0x0000000189F3AF28
		StyleLength IStyle.borderTopLeftRadius { set {} } // 0x0000000189F3AF28-0x0000000189F3AF7C
		StyleLength IStyle.borderTopRightRadius { set {} } // 0x0000000189F3AF7C-0x0000000189F3AFD0
		StyleFloat IStyle.borderTopWidth { set {} } // 0x0000000189F3AFD0-0x0000000189F3B04C
		StyleLength IStyle.bottom { set {} } // 0x0000000189F3B04C-0x0000000189F3B0E4
		StyleColor IStyle.color { set {} } // 0x0000000189F3B0E4-0x0000000189F3B134
		StyleEnum<DisplayStyle> IStyle.display { get => default; set {} } // 0x0000000189F3A864-0x0000000189F3A8C4 0x0000000189F3B134-0x0000000189F3B1D4
		StyleLength IStyle.flexBasis { set {} } // 0x0000000189F3B1D4-0x0000000189F3B26C
		StyleEnum<FlexDirection> IStyle.flexDirection { set {} } // 0x0000000189F3B26C-0x0000000189F3B30C
		StyleFloat IStyle.flexGrow { set {} } // 0x0000000189F3B30C-0x0000000189F3B384
		StyleFloat IStyle.flexShrink { set {} } // 0x0000000189F3B384-0x0000000189F3B3FC
		StyleLength IStyle.fontSize { set {} } // 0x0000000189F3B3FC-0x0000000189F3B450
		StyleLength IStyle.height { set {} } // 0x0000000189F3B450-0x0000000189F3B4E8
		StyleLength IStyle.left { set {} } // 0x0000000189F3B4E8-0x0000000189F3B580
		StyleLength IStyle.marginBottom { set {} } // 0x0000000189F3B580-0x0000000189F3B618
		StyleLength IStyle.marginLeft { set {} } // 0x0000000189F3B618-0x0000000189F3B6B0
		StyleLength IStyle.marginRight { set {} } // 0x0000000189F3B6B0-0x0000000189F3B748
		StyleLength IStyle.marginTop { set {} } // 0x0000000189F3B748-0x0000000189F3B7E0
		StyleLength IStyle.maxHeight { set {} } // 0x0000000189F3B7E0-0x0000000189F3B878
		StyleLength IStyle.maxWidth { set {} } // 0x0000000189F3B878-0x0000000189F3B910
		StyleLength IStyle.minWidth { set {} } // 0x0000000189F3B910-0x0000000189F3B9A8
		StyleFloat IStyle.opacity { set {} } // 0x0000000189F3B9A8-0x0000000189F3B9EC
		StyleLength IStyle.paddingBottom { set {} } // 0x0000000189F3B9EC-0x0000000189F3BA84
		StyleLength IStyle.paddingLeft { set {} } // 0x0000000189F3BA84-0x0000000189F3BB1C
		StyleLength IStyle.paddingRight { set {} } // 0x0000000189F3BB1C-0x0000000189F3BBB4
		StyleLength IStyle.paddingTop { get => default; set {} } // 0x0000000189F3A8C4-0x0000000189F3A900 0x0000000189F3BBB4-0x0000000189F3BC4C
		StyleEnum<Position> IStyle.position { set {} } // 0x0000000189F3BC4C-0x0000000189F3BCEC
		StyleLength IStyle.right { set {} } // 0x0000000189F3BCEC-0x0000000189F3BD84
		StyleLength IStyle.top { set {} } // 0x0000000189F3BD84-0x0000000189F3BE1C
		StyleColor IStyle.unityBackgroundImageTintColor { set {} } // 0x0000000189F3BE74-0x0000000189F3BEC4
		StyleEnum<Visibility> IStyle.visibility { set {} } // 0x0000000189F3BEC4-0x0000000189F3BF34
		StyleLength IStyle.width { get => default; set {} } // 0x0000000189F3AB40-0x0000000189F3AB7C 0x0000000189F3BF34-0x0000000189F3BFCC
	
		// Nested types
		internal struct InlineRule // TypeDefIndex: 43762
		{
			// Fields
			public StyleSheet sheet; // 0x00
			public StyleRule rule; // 0x08
			public StylePropertyId[] propertyIds; // 0x10
		}
	
		// Constructors
		public InlineStyleAccess() {} // Dummy constructor
		public InlineStyleAccess(VisualElement ve) {} // 0x0000000189F3C048-0x0000000189F3C078
		static InlineStyleAccess() {} // 0x0000000189F3BFCC-0x0000000189F3C048
	
		// Methods
		~InlineStyleAccess() {} // 0x0000000189F39D8C-0x0000000189F39E5C
		public void SetInlineRule(StyleSheet sheet, StyleRule rule) {} // 0x0000000189F3A1DC-0x0000000189F3A28C
		public bool IsValueSet(StylePropertyId id) => default; // 0x0000000189F39E5C-0x0000000189F3A104
		public void ApplyInlineStyles(ref ComputedStyle computedStyle) {} // 0x0000000189F39200-0x0000000189F39964
		private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue) => default; // 0x0000000189F3A3CC-0x0000000189F3A4DC
		private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue) => default; // 0x0000000189F3A60C-0x0000000189F3A710
		private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue) => default; // 0x0000000189F3A4DC-0x0000000189F3A60C
		private bool SetStyleValue<T>(StylePropertyId id, StyleEnum<T> inlineValue)
			where T : struct, IConvertible => default;
		private bool SetInlineTranslate(StyleTranslate inlineValue) => default; // 0x0000000189F3A28C-0x0000000189F3A3CC
		private void ApplyStyleTranslate(StyleTranslate translate) {} // 0x0000000189F39964-0x0000000189F39B30
		private void ApplyStyleValue(StyleValue value) {} // 0x0000000189F39B30-0x0000000189F39D8C
		private bool RemoveInlineStyle(StylePropertyId id) => default; // 0x0000000189F3A104-0x0000000189F3A1DC
		private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle) {} // 0x0000000189F3904C-0x0000000189F39200
		public bool TryGetInlineCursor(ref StyleCursor value) => default; // 0x0000000189F3A710-0x0000000189F3A73C
		public bool TryGetInlineTextShadow(ref StyleTextShadow value) => default; // 0x0000000189F3A790-0x0000000189F3A7AC
		public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value) => default; // 0x0000000189F3A7AC-0x0000000189F3A7CC
		public bool TryGetInlineTranslate(ref StyleTranslate value) => default; // 0x0000000189F3A7CC-0x0000000189F3A7FC
		public bool TryGetInlineRotate(ref StyleRotate value) => default; // 0x0000000189F3A73C-0x0000000189F3A76C
		public bool TryGetInlineScale(ref StyleScale value) => default; // 0x0000000189F3A76C-0x0000000189F3A790
	}

	public enum LengthUnit // TypeDefIndex: 43764
	{
		Pixel = 0,
		Percent = 1
	}

	[Serializable]
	public struct Length : IEquatable<Length> // TypeDefIndex: 43766
	{
		// Fields
		internal const float k_MaxValue = 8388608f; // Metadata: 0x01FB6082
		[SerializeField]
		private float m_Value; // 0x00
		[SerializeField]
		private Unit m_Unit; // 0x04
	
		// Properties
		public float value { get => default; set {} } // 0x0000000183D4FA00-0x0000000183D4FA10 0x0000000189F3C32C-0x0000000189F3C350
		public LengthUnit unit { get => default; } // 0x0000000183D4E990-0x0000000183D4E9A0 
	
		// Nested types
		private enum Unit // TypeDefIndex: 43765
		{
			Pixel = 0,
			Percent = 1,
			Auto = 2,
			None = 3
		}
	
		// Constructors
		public Length(float value) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x0000000189F3C2D8-0x0000000189F3C2E4
		public Length(float value, LengthUnit unit) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x0000000189F3C2E4-0x0000000189F3C2EC
		private Length(float value, Unit unit) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x0000000189F3C2AC-0x0000000189F3C2D8
	
		// Methods
		public static Length Percent(float value) => default; // 0x0000000189F3C158-0x0000000189F3C188
		public static Length Auto() => default; // 0x0000000189F3C078-0x0000000189F3C0A8
		public static Length None() => default; // 0x0000000189F3C128-0x0000000189F3C158
		public bool IsAuto() => default; // 0x0000000189F3C118-0x0000000189F3C120
		public bool IsNone() => default; // 0x0000000189F3C120-0x0000000189F3C128
		public static implicit operator Length(float value) => default; // 0x0000000189F3C2EC-0x0000000189F3C318
		public static bool operator ==(Length lhs, Length rhs) => default; // 0x0000000189F356E0-0x0000000189F3570C
		public static bool operator !=(Length lhs, Length rhs) => default; // 0x0000000189F3C318-0x0000000189F3C32C
		public bool Equals(Length other) => default; // 0x0000000189F35514-0x0000000189F35528
		public override bool Equals(object obj) => default; // 0x0000000189F3C0A8-0x0000000189F3C118
		public override int GetHashCode() => default; // 0x0000000189F35528-0x0000000189F35548
		public override string ToString() => default; // 0x0000000189F3C188-0x0000000189F3C2AC
	}

	public struct Rotate : IEquatable<Rotate> // TypeDefIndex: 43767
	{
		// Fields
		private Angle m_Angle; // 0x00
		private Vector3 m_Axis; // 0x08
		private bool m_IsNone; // 0x14
	
		// Properties
		public Angle angle { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		internal Vector3 axis { get => default; } // 0x0000000183D5E630-0x0000000183D5E650 
	
		// Constructors
		public Rotate(Angle angle) : this() {
			m_Angle = default;
			m_Axis = default;
			m_IsNone = default;
		} // 0x0000000189F3E868-0x0000000189F3E88C
	
		// Methods
		internal static Rotate Initial() => default; // 0x0000000189F3E6E4-0x0000000189F3E760
		public static Rotate None() => default; // 0x0000000189F3E760-0x0000000189F3E7AC
		public static bool operator ==(Rotate lhs, Rotate rhs) => default; // 0x0000000189F3E88C-0x0000000189F3E980
		public static bool operator !=(Rotate lhs, Rotate rhs) => default; // 0x0000000189F3E980-0x0000000189F3E9C0
		public bool Equals(Rotate other) => default; // 0x0000000189F3E620-0x0000000189F3E664
		public override bool Equals(object obj) => default; // 0x0000000189F3E588-0x0000000189F3E620
		public override int GetHashCode() => default; // 0x0000000189F3E664-0x0000000189F3E6E4
		public override string ToString() => default; // 0x0000000189F3E808-0x0000000189F3E868
		internal Quaternion ToQuaternion() => default; // 0x0000000189F3E7AC-0x0000000189F3E808
	}

	public struct Scale : IEquatable<Scale> // TypeDefIndex: 43768
	{
		// Fields
		private Vector3 m_Scale; // 0x00
		private bool m_IsNone; // 0x0C
	
		// Properties
		public Vector3 value { get => default; } // 0x0000000183D56520-0x0000000183D56540 
	
		// Constructors
		public Scale(Vector3 scale) : this() {
			m_Scale = default;
			m_IsNone = default;
		} // 0x0000000183D892B0-0x0000000183D892E0
	
		// Methods
		internal static Scale Initial() => default; // 0x0000000189F3EC3C-0x0000000189F3EC90
		public static Scale None() => default; // 0x0000000189F3EC90-0x0000000189F3ECCC
		public static bool operator ==(Scale lhs, Scale rhs) => default; // 0x0000000189F3ECD8-0x0000000189F3ED2C
		public static bool operator !=(Scale lhs, Scale rhs) => default; // 0x0000000189F3ED2C-0x0000000189F3ED5C
		public bool Equals(Scale other) => default; // 0x0000000189F3EB78-0x0000000189F3EBA4
		public override bool Equals(object obj) => default; // 0x0000000189F3EBA4-0x0000000189F3EC28
		public override int GetHashCode() => default; // 0x0000000189F3EC28-0x0000000189F3EC3C
		public override string ToString() => default; // 0x0000000189F3ECCC-0x0000000189F3ECD8
	}

	public struct StyleColor : IStyleValue<UnityEngine.Color>, IEquatable<StyleColor> // TypeDefIndex: 43769
	{
		// Fields
		private UnityEngine.Color m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x10
	
		// Properties
		public UnityEngine.Color value { get => default; } // 0x0000000189F3EEB4-0x0000000189F3EEE0 
		public StyleKeyword keyword { get => default; } // 0x0000000183D85B00-0x0000000183D85B10 
	
		// Constructors
		public StyleColor(UnityEngine.Color v) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D70590-0x0000000183D705A0
		internal StyleColor(UnityEngine.Color v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D675E0-0x0000000183D675F0
	
		// Methods
		public static bool operator ==(StyleColor lhs, StyleColor rhs) => default; // 0x0000000189F3EEE0-0x0000000189F3EF30
		public static implicit operator StyleColor(UnityEngine.Color v) => default; // 0x0000000183D892E0-0x0000000183D89300
		public bool Equals(StyleColor other) => default; // 0x0000000189F3ED5C-0x0000000189F3ED98
		public override bool Equals(object obj) => default; // 0x0000000189F3ED98-0x0000000189F3EE2C
		public override int GetHashCode() => default; // 0x0000000189F3EE2C-0x0000000189F3EE4C
		public override string ToString() => default; // 0x0000000189F3EE4C-0x0000000189F3EEB4
	}

	public struct StyleCursor : IStyleValue<UnityEngine.UIElements.Cursor>, IEquatable<StyleCursor> // TypeDefIndex: 43770
	{
		// Fields
		private UnityEngine.UIElements.Cursor m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x18
	
		// Properties
		public UnityEngine.UIElements.Cursor value { get => default; } // 0x0000000189F3F0BC-0x0000000189F3F0F0 
		public StyleKeyword keyword { get => default; } // 0x0000000183D68AE0-0x0000000183D68AF0 
	
		// Constructors
		public StyleCursor(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000189F3F078-0x0000000189F3F0A0
		internal StyleCursor(UnityEngine.UIElements.Cursor v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000189F3F0A0-0x0000000189F3F0BC
	
		// Methods
		public static bool operator ==(StyleCursor lhs, StyleCursor rhs) => default; // 0x0000000189F3F0F0-0x0000000189F3F150
		public static implicit operator StyleCursor(StyleKeyword keyword) => default; // 0x0000000189F3F150-0x0000000189F3F194
		public bool Equals(StyleCursor other) => default; // 0x0000000189F3EF30-0x0000000189F3EF70
		public override bool Equals(object obj) => default; // 0x0000000189F3EF70-0x0000000189F3EFF0
		public override int GetHashCode() => default; // 0x0000000189F3EFF0-0x0000000189F3F010
		public override string ToString() => default; // 0x0000000189F3F010-0x0000000189F3F078
	}

	internal struct StyleDataRef<T> : IEquatable<StyleDataRef<T>> // TypeDefIndex: 43772
		where T : struct, IEquatable<T>, IStyleDataGroup<T>
	{
		// Fields
		private RefCounted m_Ref;
	
		// Nested types
		private class RefCounted // TypeDefIndex: 43771
		{
			// Fields
			private static uint m_NextId;
			private int m_RefCount;
			private readonly uint m_Id;
			public T value;
	
			// Properties
			public int refCount { get => default; }
	
			// Constructors
			public RefCounted() {}
			static RefCounted() {}
	
			// Methods
			public void Acquire() {}
			public void Release() {}
			public RefCounted<T> Copy() => default;
		}
	
		// Methods
		public StyleDataRef<T> Acquire() => default;
		public void Release() {}
		public void CopyFrom(StyleDataRef<T> other) {}
		public ref ref T Read() => ref _refReturnTypeForRead;
		private ref T _refReturnTypeForRead; // Dummy field
		public ref ref T Write() => ref _refReturnTypeForWrite;
		private ref T _refReturnTypeForWrite; // Dummy field
		public static StyleDataRef<T> Create() => default;
		public override int GetHashCode() => default;
		public static bool operator ==(StyleDataRef<T> lhs, StyleDataRef<T> rhs) => default;
		public bool Equals(StyleDataRef<T> other) => default;
		public override bool Equals(object obj) => default;
	}

	public struct StyleEnum<T> : IStyleValue<T>, IEquatable<StyleEnum<T>> // TypeDefIndex: 43773
		where T : struct, IConvertible
	{
		// Fields
		private T m_Value;
		private StyleKeyword m_Keyword;
	
		// Properties
		public T value { get => default; }
		public StyleKeyword keyword { get => default; }
	
		// Constructors
		public StyleEnum(T v) : this() {
			m_Value = default;
			m_Keyword = default;
		}
		public StyleEnum(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		}
		internal StyleEnum(T v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		}
	
		// Methods
		public static bool operator ==(StyleEnum<T> lhs, StyleEnum<T> rhs) => default;
		public static bool operator !=(StyleEnum<T> lhs, StyleEnum<T> rhs) => default;
		public static implicit operator StyleEnum<T>(StyleKeyword keyword) => default;
		public static implicit operator StyleEnum<T>(T v) => default;
		public bool Equals(StyleEnum<T> other) => default;
		public override bool Equals(object obj) => default;
		public override int GetHashCode() => default;
		public override string ToString() => default;
	}

	public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat> // TypeDefIndex: 43774
	{
		// Fields
		private float m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x04
	
		// Properties
		public float value { get => default; } // 0x0000000189F3F278-0x0000000189F3F288 
		public StyleKeyword keyword { get => default; } // 0x0000000183D698C0-0x0000000183D698D0 
	
		// Constructors
		public StyleFloat(float v) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D4F9F0-0x0000000183D4FA00
		public StyleFloat(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D89300-0x0000000183D89310
		internal StyleFloat(float v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D4F9E0-0x0000000183D4F9F0
	
		// Methods
		public static bool operator ==(StyleFloat lhs, StyleFloat rhs) => default; // 0x0000000189F3F288-0x0000000189F3F2B4
		public static implicit operator StyleFloat(StyleKeyword keyword) => default; // 0x0000000183D89310-0x0000000183D89330
		public static implicit operator StyleFloat(float v) => default; // 0x0000000183D89240-0x0000000183D89260
		public bool Equals(StyleFloat other) => default; // 0x0000000189F3F204-0x0000000189F3F218
		public override bool Equals(object obj) => default; // 0x0000000189F3F194-0x0000000189F3F204
		public override int GetHashCode() => default; // 0x0000000189F35528-0x0000000189F35548
		public override string ToString() => default; // 0x0000000189F3F218-0x0000000189F3F278
	}

	public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt> // TypeDefIndex: 43775
	{
		// Fields
		private int m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x04
	
		// Properties
		public int value { get => default; } // 0x0000000187D32E6C-0x0000000187D32E78 
		public StyleKeyword keyword { get => default; } // 0x0000000183D698C0-0x0000000183D698D0 
	
		// Constructors
		public StyleInt(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D89300-0x0000000183D89310
		internal StyleInt(int v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D698B0-0x0000000183D698C0
	
		// Methods
		public static bool operator ==(StyleInt lhs, StyleInt rhs) => default; // 0x0000000189F3F398-0x0000000189F3F3B4
		public static implicit operator StyleInt(StyleKeyword keyword) => default; // 0x0000000183D89310-0x0000000183D89330
		public bool Equals(StyleInt other) => default; // 0x0000000189F3F324-0x0000000189F3F338
		public override bool Equals(object obj) => default; // 0x0000000189F3F2B4-0x0000000189F3F324
		public override int GetHashCode() => default; // 0x0000000183D86E80-0x0000000183D86E90
		public override string ToString() => default; // 0x0000000189F3F338-0x0000000189F3F398
	}

	public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength> // TypeDefIndex: 43776
	{
		// Fields
		private Length m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x08
	
		// Properties
		public Length value { get => default; } // 0x0000000189F3F594-0x0000000189F3F5AC 
		public StyleKeyword keyword { get => default; } // 0x0000000183D68070-0x0000000183D68080 
	
		// Constructors
		public StyleLength(float v) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000189F3F514-0x0000000189F3F550
		public StyleLength(Length v) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000189F3F588-0x0000000189F3F594
		public StyleLength(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000189F3F550-0x0000000189F3F560
		internal StyleLength(Length v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000189F3F560-0x0000000189F3F588
	
		// Methods
		public static bool operator ==(StyleLength lhs, StyleLength rhs) => default; // 0x0000000189F3F5AC-0x0000000189F3F5D0
		public static implicit operator StyleLength(StyleKeyword keyword) => default; // 0x0000000189F3F610-0x0000000189F3F64C
		public static implicit operator StyleLength(float v) => default; // 0x0000000189F3F64C-0x0000000189F3F688
		public static implicit operator StyleLength(Length v) => default; // 0x0000000189F3F5D0-0x0000000189F3F610
		public bool Equals(StyleLength other) => default; // 0x0000000189F3F3B4-0x0000000189F3F3F4
		public override bool Equals(object obj) => default; // 0x0000000189F3F3F4-0x0000000189F3F48C
		public override int GetHashCode() => default; // 0x0000000189F3F48C-0x0000000189F3F4AC
		public override string ToString() => default; // 0x0000000189F3F4AC-0x0000000189F3F514
	}

	public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate> // TypeDefIndex: 43777
	{
		// Fields
		private Rotate m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x18
	
		// Properties
		public Rotate value { get => default; } // 0x0000000189F3F0BC-0x0000000189F3F0F0 
		public StyleKeyword keyword { get => default; } // 0x0000000183D68AE0-0x0000000183D68AF0 
	
		// Constructors
		public StyleRotate(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D89330-0x0000000183D89360
		internal StyleRotate(Rotate v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D67550-0x0000000183D67570
	
		// Methods
		public static bool operator ==(StyleRotate lhs, StyleRotate rhs) => default; // 0x0000000189F3F7F4-0x0000000189F3F86C
		public static implicit operator StyleRotate(StyleKeyword keyword) => default; // 0x0000000183D89360-0x0000000183D89390
		public bool Equals(StyleRotate other) => default; // 0x0000000189F3F714-0x0000000189F3F764
		public override bool Equals(object obj) => default; // 0x0000000189F3F688-0x0000000189F3F714
		public override int GetHashCode() => default; // 0x0000000189F3F764-0x0000000189F3F784
		public override string ToString() => default; // 0x0000000189F3F784-0x0000000189F3F7F4
	}

	public struct StyleScale : IStyleValue<Scale>, IEquatable<StyleScale> // TypeDefIndex: 43778
	{
		// Fields
		private Scale m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x10
	
		// Properties
		public Scale value { get => default; } // 0x0000000189F3F9C4-0x0000000189F3F9DC 
		public StyleKeyword keyword { get => default; } // 0x0000000183D85B00-0x0000000183D85B10 
	
		// Constructors
		public StyleScale(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D89390-0x0000000183D893A0
		internal StyleScale(Scale v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D675E0-0x0000000183D675F0
	
		// Methods
		public static bool operator ==(StyleScale lhs, StyleScale rhs) => default; // 0x0000000189F3F9DC-0x0000000189F3FA30
		public static implicit operator StyleScale(StyleKeyword keyword) => default; // 0x0000000183D893A0-0x0000000183D893B0
		public bool Equals(StyleScale other) => default; // 0x0000000189F3F86C-0x0000000189F3F8A8
		public override bool Equals(object obj) => default; // 0x0000000189F3F8A8-0x0000000189F3F93C
		public override int GetHashCode() => default; // 0x0000000189F3F93C-0x0000000189F3F95C
		public override string ToString() => default; // 0x0000000189F3F95C-0x0000000189F3F9C4
	}

	public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate> // TypeDefIndex: 43779
	{
		// Fields
		private Translate m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x18
	
		// Properties
		public Translate value { get => default; } // 0x0000000189F3F0BC-0x0000000189F3F0F0 
		public StyleKeyword keyword { get => default; } // 0x0000000183D68AE0-0x0000000183D68AF0 
	
		// Constructors
		public StyleTranslate(Translate v) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D894A0-0x0000000183D894C0
		public StyleTranslate(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D89330-0x0000000183D89360
		internal StyleTranslate(Translate v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D67550-0x0000000183D67570
	
		// Methods
		public static bool operator ==(StyleTranslate lhs, StyleTranslate rhs) => default; // 0x0000000189F3FFF0-0x0000000189F40068
		public static implicit operator StyleTranslate(StyleKeyword keyword) => default; // 0x0000000183D89360-0x0000000183D89390
		public static implicit operator StyleTranslate(Translate v) => default; // 0x0000000183D894C0-0x0000000183D894F0
		public bool Equals(StyleTranslate other) => default; // 0x0000000189F3FE84-0x0000000189F3FED4
		public override bool Equals(object obj) => default; // 0x0000000189F3FED4-0x0000000189F3FF60
		public override int GetHashCode() => default; // 0x0000000189F3FF60-0x0000000189F3FF80
		public override string ToString() => default; // 0x0000000189F3FF80-0x0000000189F3FFF0
	}

	public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow> // TypeDefIndex: 43780
	{
		// Fields
		private StyleKeyword m_Keyword; // 0x00
		private TextShadow m_Value; // 0x04
	
		// Properties
		public TextShadow value { get => default; } // 0x0000000189F3FB94-0x0000000189F3FBD0 
		public StyleKeyword keyword { get => default; } // 0x0000000183D85860-0x0000000183D85870 
	
		// Constructors
		public StyleTextShadow(StyleKeyword keyword) : this() {
			m_Keyword = default;
			m_Value = default;
		} // 0x0000000183D893B0-0x0000000183D893E0
		internal StyleTextShadow(TextShadow v, StyleKeyword keyword) : this() {
			m_Keyword = default;
			m_Value = default;
		} // 0x0000000183D893E0-0x0000000183D89400
	
		// Methods
		public static bool operator ==(StyleTextShadow lhs, StyleTextShadow rhs) => default; // 0x0000000189F3FBD0-0x0000000189F3FC6C
		public static implicit operator StyleTextShadow(StyleKeyword keyword) => default; // 0x0000000183D89400-0x0000000183D89440
		public bool Equals(StyleTextShadow other) => default; // 0x0000000189F3FAC4-0x0000000189F3FB04
		public override bool Equals(object obj) => default; // 0x0000000189F3FA30-0x0000000189F3FAC4
		public override int GetHashCode() => default; // 0x0000000189F3FB04-0x0000000189F3FB2C
		public override string ToString() => default; // 0x0000000189F3FB2C-0x0000000189F3FB94
	}

	public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin> // TypeDefIndex: 43781
	{
		// Fields
		private TransformOrigin m_Value; // 0x00
		private StyleKeyword m_Keyword; // 0x14
	
		// Properties
		public TransformOrigin value { get => default; } // 0x0000000189F3FDD4-0x0000000189F3FDF4 
		public StyleKeyword keyword { get => default; } // 0x0000000183D4FB00-0x0000000183D4FB10 
	
		// Constructors
		public StyleTransformOrigin(StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D89440-0x0000000183D89450
		internal StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword) : this() {
			m_Value = default;
			m_Keyword = default;
		} // 0x0000000183D89450-0x0000000183D89470
	
		// Methods
		public static bool operator ==(StyleTransformOrigin lhs, StyleTransformOrigin rhs) => default; // 0x0000000189F3FDF4-0x0000000189F3FE84
		public static implicit operator StyleTransformOrigin(StyleKeyword keyword) => default; // 0x0000000183D89470-0x0000000183D894A0
		public bool Equals(StyleTransformOrigin other) => default; // 0x0000000189F3FC6C-0x0000000189F3FCB0
		public override bool Equals(object obj) => default; // 0x0000000189F3FCB0-0x0000000189F3FD48
		public override int GetHashCode() => default; // 0x0000000189F3FD48-0x0000000189F3FD68
		public override string ToString() => default; // 0x0000000189F3FD68-0x0000000189F3FDD4
	}

	internal interface IStyleValue<T> // TypeDefIndex: 43782
	{
		// Properties
		T value { get; }
		StyleKeyword keyword { get; }
	}

	public enum StyleKeyword // TypeDefIndex: 43783
	{
		Undefined = 0,
		Null = 1,
		Auto = 2,
		None = 3,
		Initial = 4
	}

	internal static class StyleValueExtensions // TypeDefIndex: 43784
	{
		// Extension methods
		internal static string DebugString<T>(this IStyleValue<T> styleValue) => default;
		internal static YogaValue ToYogaValue(this Length length) => default; // 0x0000000189F40888-0x0000000189F409A8
		internal static Length ToLength(this StyleKeyword keyword) => default; // 0x0000000189F404D4-0x0000000189F405A4
		internal static Rotate ToRotate(this StyleKeyword keyword) => default; // 0x0000000189F405CC-0x0000000189F406C0
		internal static Scale ToScale(this StyleKeyword keyword) => default; // 0x0000000189F406C0-0x0000000189F40794
		internal static Translate ToTranslate(this StyleKeyword keyword) => default; // 0x0000000189F40794-0x0000000189F40888
		internal static Length ToLength(this StyleLength styleLength) => default; // 0x0000000189F405A4-0x0000000189F405CC
		internal static void CopyFrom<T>(this List<T> list, List<T> other) {}
	}

	public enum TimeUnit // TypeDefIndex: 43785
	{
		Second = 0,
		Millisecond = 1
	}

	public struct TimeValue : IEquatable<TimeValue> // TypeDefIndex: 43786
	{
		// Fields
		private float m_Value; // 0x00
		private TimeUnit m_Unit; // 0x04
	
		// Properties
		public float value { get => default; } // 0x0000000183D4FA00-0x0000000183D4FA10 
		public TimeUnit unit { get => default; } // 0x0000000183D4E990-0x0000000183D4E9A0 
	
		// Constructors
		public TimeValue(float value) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x0000000183D4F9F0-0x0000000183D4FA00
		public TimeValue(float value, TimeUnit unit) : this() {
			m_Value = default;
			m_Unit = default;
		} // 0x0000000183D4F9E0-0x0000000183D4F9F0
	
		// Methods
		public static implicit operator TimeValue(float value) => default; // 0x0000000183D89240-0x0000000183D89260
		public static bool operator ==(TimeValue lhs, TimeValue rhs) => default; // 0x0000000189F356E0-0x0000000189F3570C
		public static bool operator !=(TimeValue lhs, TimeValue rhs) => default; // 0x0000000189F3C318-0x0000000189F3C32C
		public bool Equals(TimeValue other) => default; // 0x0000000189F35514-0x0000000189F35528
		public override bool Equals(object obj) => default; // 0x0000000189F41FDC-0x0000000189F4204C
		public override int GetHashCode() => default; // 0x0000000189F35528-0x0000000189F35548
		public override string ToString() => default; // 0x0000000189F4204C-0x0000000189F42114
	}

	public struct TransformOrigin : IEquatable<TransformOrigin> // TypeDefIndex: 43787
	{
		// Fields
		private Length m_X; // 0x00
		private Length m_Y; // 0x08
		private float m_Z; // 0x10
	
		// Properties
		public Length x { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		public Length y { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x0000000183D55BA0-0x0000000183D55BB0
		public float z { get => default; } // 0x0000000183D4E7A0-0x0000000183D4E7B0 
	
		// Constructors
		public TransformOrigin(Length x, Length y, float z) : this() {
			m_X = default;
			m_Y = default;
			m_Z = default;
		} // 0x0000000183D6B6A0-0x0000000183D6B6B0
	
		// Methods
		public static TransformOrigin Initial() => default; // 0x0000000189F42240-0x0000000189F4228C
		public static bool operator ==(TransformOrigin lhs, TransformOrigin rhs) => default; // 0x0000000189F423AC-0x0000000189F42438
		public static bool operator !=(TransformOrigin lhs, TransformOrigin rhs) => default; // 0x0000000189F42438-0x0000000189F42474
		public bool Equals(TransformOrigin other) => default; // 0x0000000189F42114-0x0000000189F42150
		public override bool Equals(object obj) => default; // 0x0000000189F42150-0x0000000189F421E4
		public override int GetHashCode() => default; // 0x0000000189F421E4-0x0000000189F42240
		public override string ToString() => default; // 0x0000000189F4228C-0x0000000189F423AC
	}

	public struct Translate : IEquatable<Translate> // TypeDefIndex: 43788
	{
		// Fields
		private Length m_X; // 0x00
		private Length m_Y; // 0x08
		private float m_Z; // 0x10
		private bool m_isNone; // 0x14
	
		// Properties
		public Length x { get => default; set {} } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		public Length y { get => default; set {} } // 0x0000000183D50DE0-0x0000000183D50DF0 0x0000000183D55BA0-0x0000000183D55BB0
		public float z { get => default; } // 0x0000000183D4E7A0-0x0000000183D4E7B0 
	
		// Constructors
		public Translate(Length x, Length y, float z) : this() {
			m_X = default;
			m_Y = default;
			m_Z = default;
			m_isNone = default;
		} // 0x0000000183D89520-0x0000000183D89540
	
		// Methods
		public static Translate None() => default; // 0x0000000183D894F0-0x0000000183D89520
		public static bool operator ==(Translate lhs, Translate rhs) => default; // 0x0000000189F42670-0x0000000189F42764
		public static bool operator !=(Translate lhs, Translate rhs) => default; // 0x0000000189F42764-0x0000000189F427A4
		public bool Equals(Translate other) => default; // 0x0000000189F42474-0x0000000189F424B8
		public override bool Equals(object obj) => default; // 0x0000000189F424B8-0x0000000189F42550
		public override int GetHashCode() => default; // 0x0000000189F421E4-0x0000000189F42240
		public override string ToString() => default; // 0x0000000189F42550-0x0000000189F42670
	}

	public interface IResolvedStyle // TypeDefIndex: 43789
	{
		// Properties
		UnityEngine.Color backgroundColor { get; }
		UnityEngine.Color borderBottomColor { get; }
		float borderBottomLeftRadius { get; }
		float borderBottomRightRadius { get; }
		float borderBottomWidth { get; }
		UnityEngine.Color borderLeftColor { get; }
		float borderLeftWidth { get; }
		UnityEngine.Color borderRightColor { get; }
		float borderRightWidth { get; }
		UnityEngine.Color borderTopColor { get; }
		float borderTopLeftRadius { get; }
		float borderTopRightRadius { get; }
		float borderTopWidth { get; }
		float bottom { get; }
		UnityEngine.Color color { get; }
		DisplayStyle display { get; }
		FlexDirection flexDirection { get; }
		float flexGrow { get; }
		float flexShrink { get; }
		float height { get; }
		float left { get; }
		float marginBottom { get; }
		float marginLeft { get; }
		float marginRight { get; }
		float marginTop { get; }
		StyleFloat minHeight { get; }
		StyleFloat minWidth { get; }
		float opacity { get; }
		float paddingBottom { get; }
		float paddingLeft { get; }
		float paddingRight { get; }
		float paddingTop { get; }
		float right { get; }
		Scale scale { get; }
		float top { get; }
		Vector3 transformOrigin { get; }
		Vector3 translate { get; }
		UnityEngine.Color unityBackgroundImageTintColor { get; }
		int unitySliceLeft { get; }
		int unitySliceRight { get; }
		UnityEngine.Color unityTextOutlineColor { get; }
		float unityTextOutlineWidth { get; }
		Visibility visibility { get; }
		WhiteSpace whiteSpace { get; }
		float width { get; }
	}

	public interface IStyle // TypeDefIndex: 43790
	{
		// Properties
		StyleColor backgroundColor { get; set; }
		StyleColor borderBottomColor { get; set; }
		StyleLength borderBottomLeftRadius { get; set; }
		StyleLength borderBottomRightRadius { get; set; }
		StyleFloat borderBottomWidth { get; set; }
		StyleColor borderLeftColor { get; set; }
		StyleFloat borderLeftWidth { get; set; }
		StyleColor borderRightColor { get; set; }
		StyleFloat borderRightWidth { get; set; }
		StyleColor borderTopColor { get; set; }
		StyleLength borderTopLeftRadius { get; set; }
		StyleLength borderTopRightRadius { get; set; }
		StyleFloat borderTopWidth { get; set; }
		StyleLength bottom { get; set; }
		StyleColor color { get; set; }
		StyleCursor cursor { get; }
		StyleEnum<DisplayStyle> display { get; set; }
		StyleLength flexBasis { get; set; }
		StyleEnum<FlexDirection> flexDirection { get; set; }
		StyleFloat flexGrow { get; set; }
		StyleFloat flexShrink { get; set; }
		StyleLength fontSize { get; set; }
		StyleLength height { get; set; }
		StyleLength left { get; set; }
		StyleLength marginBottom { get; set; }
		StyleLength marginLeft { get; set; }
		StyleLength marginRight { get; set; }
		StyleLength marginTop { get; set; }
		StyleLength maxHeight { get; set; }
		StyleLength maxWidth { get; set; }
		StyleLength minWidth { get; set; }
		StyleFloat opacity { get; set; }
		StyleLength paddingBottom { get; set; }
		StyleLength paddingLeft { get; set; }
		StyleLength paddingRight { get; set; }
		StyleLength paddingTop { get; set; }
		StyleEnum<Position> position { get; set; }
		StyleLength right { get; set; }
		StyleRotate rotate { get; }
		StyleScale scale { get; }
		StyleTextShadow textShadow { get; }
		StyleLength top { get; set; }
		StyleTransformOrigin transformOrigin { get; }
		StyleTranslate translate { get; set; }
		StyleColor unityBackgroundImageTintColor { get; set; }
		StyleEnum<Visibility> visibility { get; set; }
		StyleLength width { get; set; }
	}

	internal interface IStyleDataGroup<T> // TypeDefIndex: 43791
	{
		// Methods
		T Copy();
		void CopyFrom(ref ref T other);
	}

	internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData> // TypeDefIndex: 43792
	{
		// Fields
		public UnityEngine.Color color; // 0x00
		public Length fontSize; // 0x10
		public Length letterSpacing; // 0x18
		public TextShadow textShadow; // 0x20
		public Font unityFont; // 0x40
		public FontDefinition unityFontDefinition; // 0x48
		public FontStyle unityFontStyleAndWeight; // 0x58
		public Length unityParagraphSpacing; // 0x5C
		public TextAnchor unityTextAlign; // 0x64
		public UnityEngine.Color unityTextOutlineColor; // 0x68
		public float unityTextOutlineWidth; // 0x78
		public Visibility visibility; // 0x7C
		public WhiteSpace whiteSpace; // 0x80
		public Length wordSpacing; // 0x84
	
		// Methods
		public InheritedData Copy() => default; // 0x0000000183D896E0-0x0000000183D89730
		public void CopyFrom(ref InheritedData other) {} // 0x0000000189F462C8-0x0000000189F46384
		public static bool operator ==(InheritedData lhs, InheritedData rhs) => default; // 0x0000000189F4667C-0x0000000189F47120
		public bool Equals(InheritedData other) => default; // 0x0000000189F46384-0x0000000189F46450
		public override bool Equals(object obj) => default; // 0x0000000189F46450-0x0000000189F4651C
		public override int GetHashCode() => default; // 0x0000000189F4651C-0x0000000189F4667C
	}

	internal struct LayoutData : IStyleDataGroup<UnityEngine.UIElements.LayoutData>, IEquatable<UnityEngine.UIElements.LayoutData> // TypeDefIndex: 43793
	{
		// Fields
		public Align alignContent; // 0x00
		public Align alignItems; // 0x04
		public Align alignSelf; // 0x08
		public float borderBottomWidth; // 0x0C
		public float borderLeftWidth; // 0x10
		public float borderRightWidth; // 0x14
		public float borderTopWidth; // 0x18
		public Length bottom; // 0x1C
		public DisplayStyle display; // 0x24
		public Length flexBasis; // 0x28
		public FlexDirection flexDirection; // 0x30
		public float flexGrow; // 0x34
		public float flexShrink; // 0x38
		public Wrap flexWrap; // 0x3C
		public Length height; // 0x40
		public Justify justifyContent; // 0x48
		public Length left; // 0x4C
		public Length marginBottom; // 0x54
		public Length marginLeft; // 0x5C
		public Length marginRight; // 0x64
		public Length marginTop; // 0x6C
		public Length maxHeight; // 0x74
		public Length maxWidth; // 0x7C
		public Length minHeight; // 0x84
		public Length minWidth; // 0x8C
		public Length paddingBottom; // 0x94
		public Length paddingLeft; // 0x9C
		public Length paddingRight; // 0xA4
		public Length paddingTop; // 0xAC
		public Position position; // 0xB4
		public Length right; // 0xB8
		public Length top; // 0xC0
		public Length width; // 0xC8
	
		// Methods
		public LayoutData Copy() => default; // 0x0000000183D89840-0x0000000183D898C0
		public void CopyFrom(ref LayoutData other) {} // 0x0000000183D89730-0x0000000183D89840
		public static bool operator ==(LayoutData lhs, LayoutData rhs) => default; // 0x0000000189F475A4-0x0000000189F49598
		public bool Equals(LayoutData other) => default; // 0x0000000189F47218-0x0000000189F47324
		public override bool Equals(object obj) => default; // 0x0000000189F47120-0x0000000189F47218
		public override int GetHashCode() => default; // 0x0000000189F47324-0x0000000189F475A4
	}

	internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData> // TypeDefIndex: 43794
	{
		// Fields
		public UnityEngine.UIElements.Cursor cursor; // 0x00
		public TextOverflow textOverflow; // 0x18
		public UnityEngine.Color unityBackgroundImageTintColor; // 0x1C
		public UnityEngine.ScaleMode unityBackgroundScaleMode; // 0x2C
		public OverflowClipBox unityOverflowClipBox; // 0x30
		public int unitySliceBottom; // 0x34
		public int unitySliceLeft; // 0x38
		public int unitySliceRight; // 0x3C
		public int unitySliceTop; // 0x40
		public TextOverflowPosition unityTextOverflowPosition; // 0x44
	
		// Methods
		public RareData Copy() => default; // 0x0000000183D89980-0x0000000183D899B0
		public void CopyFrom(ref RareData other) {} // 0x0000000189F501B4-0x0000000189F501E4
		public static bool operator ==(RareData lhs, RareData rhs) => default; // 0x0000000189F50378-0x0000000189F50574
		public bool Equals(RareData other) => default; // 0x0000000189F50284-0x0000000189F50300
		public override bool Equals(object obj) => default; // 0x0000000189F501E4-0x0000000189F50284
		public override int GetHashCode() => default; // 0x0000000189F50300-0x0000000189F50378
	}

	internal struct TransformData : IStyleDataGroup<UnityEngine.UIElements.TransformData>, IEquatable<UnityEngine.UIElements.TransformData> // TypeDefIndex: 43795
	{
		// Fields
		public Rotate rotate; // 0x00
		public Scale scale; // 0x18
		public TransformOrigin transformOrigin; // 0x28
		public Translate translate; // 0x3C
	
		// Methods
		public TransformData Copy() => default; // 0x0000000183D89A50-0x0000000183D89A80
		public void CopyFrom(ref TransformData other) {} // 0x0000000183D89A20-0x0000000183D89A50
		public static bool operator ==(TransformData lhs, TransformData rhs) => default; // 0x0000000189F56914-0x0000000189F56B30
		public bool Equals(TransformData other) => default; // 0x0000000189F5677C-0x0000000189F56800
		public override bool Equals(object obj) => default; // 0x0000000189F56800-0x0000000189F568AC
		public override int GetHashCode() => default; // 0x0000000189F568AC-0x0000000189F56914
	}

	internal struct TransitionData : IStyleDataGroup<TransitionData>, IEquatable<TransitionData> // TypeDefIndex: 43796
	{
		// Fields
		public List<TimeValue> transitionDelay; // 0x00
		public List<TimeValue> transitionDuration; // 0x08
		public List<StylePropertyName> transitionProperty; // 0x10
		public List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction; // 0x18
	
		// Methods
		public TransitionData Copy() => default; // 0x0000000189F56C88-0x0000000189F56E30
		public void CopyFrom(ref TransitionData other) {} // 0x0000000189F56B30-0x0000000189F56C88
		public static bool operator ==(TransitionData lhs, TransitionData rhs) => default; // 0x0000000189F56F98-0x0000000189F56FD0
		public bool Equals(TransitionData other) => default; // 0x0000000189F56E30-0x0000000189F56E70
		public override bool Equals(object obj) => default; // 0x0000000189F56E70-0x0000000189F56F04
		public override int GetHashCode() => default; // 0x0000000189F56F04-0x0000000189F56F98
	}

	internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData> // TypeDefIndex: 43797
	{
		// Fields
		public UnityEngine.Color backgroundColor; // 0x00
		public Background backgroundImage; // 0x10
		public UnityEngine.Color borderBottomColor; // 0x30
		public Length borderBottomLeftRadius; // 0x40
		public Length borderBottomRightRadius; // 0x48
		public UnityEngine.Color borderLeftColor; // 0x50
		public UnityEngine.Color borderRightColor; // 0x60
		public UnityEngine.Color borderTopColor; // 0x70
		public Length borderTopLeftRadius; // 0x80
		public Length borderTopRightRadius; // 0x88
		public float opacity; // 0x90
		public OverflowInternal overflow; // 0x94
	
		// Methods
		public VisualData Copy() => default; // 0x0000000183D89A80-0x0000000183D89AE0
		public void CopyFrom(ref VisualData other) {} // 0x0000000189F5B0A4-0x0000000189F5B17C
		public static bool operator ==(VisualData lhs, VisualData rhs) => default; // 0x0000000189F5B444-0x0000000189F5BE8C
		public bool Equals(VisualData other) => default; // 0x0000000189F5B17C-0x0000000189F5B264
		public override bool Equals(object obj) => default; // 0x0000000189F5B264-0x0000000189F5B33C
		public override int GetHashCode() => default; // 0x0000000189F5B33C-0x0000000189F5B444
	}

	internal struct Hashes // TypeDefIndex: 43799
	{
		// Fields
		public const int kSize = 4; // Metadata: 0x01FB6091
		public unsafe fixed /* 0x00000000-0x00000000 */ int hashes[0]; // 0x00
	}

	[Serializable]
	internal class StyleComplexSelector : ISerializationCallbackReceiver // TypeDefIndex: 43802
	{
		// Fields
		[NonSerialized]
		public Hashes ancestorHashes; // 0x10
		[SerializeField]
		private int m_Specificity; // 0x20
		[NonSerialized]
		private bool m_isSimple; // 0x30
		[SerializeField]
		private StyleSelector[] m_Selectors; // 0x38
		[SerializeField]
		internal int ruleIndex; // 0x40
		[NonSerialized]
		internal StyleComplexSelector nextInTable; // 0x48
		[NonSerialized]
		internal int orderInStyleSheet; // 0x50
		private static Dictionary<string, PseudoStateData> s_PseudoStates; // 0x00
		private static List<StyleSelectorPart> m_HashList; // 0x08
	
		// Properties
		public int specificity { get => default; } // 0x0000000183D86CC0-0x0000000183D86CD0 
		public StyleRule rule { get; internal set; } // 0x0000000183D4EAC0-0x0000000183D4EAD0 0x0000000182C92F10-0x0000000182C92F20
		public bool isSimple { get => default; } // 0x0000000183D86CA0-0x0000000183D86CB0 
		public StyleSelector[] selectors { get => default; internal set {} } // 0x0000000183D86EB0-0x0000000183D86EC0 0x0000000189F510AC-0x0000000189F510E0
	
		// Nested types
		private struct PseudoStateData // TypeDefIndex: 43800
		{
			// Fields
			public readonly PseudoStates state; // 0x00
			public readonly bool negate; // 0x04
	
			// Constructors
			public PseudoStateData(PseudoStates state, bool negate) {
				this.state = default;
				this.negate = default;
			} // 0x0000000183D58750-0x0000000183D58760
		}
	
		// Constructors
		public StyleComplexSelector() {} // 0x000000018350B670-0x000000018350B680
		static StyleComplexSelector() {} // 0x0000000189F51018-0x0000000189F510AC
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		public virtual void OnAfterDeserialize() {} // 0x0000000189F50E18-0x0000000189F50E3C
		internal void CachePseudoStateMasks() {} // 0x0000000189F508B4-0x0000000189F50E18
		public override string ToString() => default; // 0x0000000189F50E3C-0x0000000189F51018
	}

	[Serializable]
	internal class StyleProperty // TypeDefIndex: 43803
	{
		// Fields
		[SerializeField]
		private string m_Name; // 0x10
		[SerializeField]
		private int m_Line; // 0x18
		[SerializeField]
		private StyleValueHandle[] m_Values; // 0x20
		[NonSerialized]
		internal bool isCustomProperty; // 0x28
		[NonSerialized]
		internal bool requireVariableResolve; // 0x29
	
		// Properties
		public string name { get => default; } // 0x0000000183D66B80-0x0000000183D66B90 
		public StyleValueHandle[] values { get => default; } // 0x0000000183D85A20-0x0000000183D85A30 
	
		// Constructors
		public StyleProperty() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	internal class StyleRule // TypeDefIndex: 43804
	{
		// Fields
		[SerializeField]
		private StyleProperty[] m_Properties; // 0x10
		[SerializeField]
		internal int line; // 0x18
		[NonSerialized]
		internal int customPropertiesCount; // 0x1C
	
		// Properties
		public StyleProperty[] properties { get => default; } // 0x0000000183D66B80-0x0000000183D66B90 
	
		// Constructors
		public StyleRule() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	internal class StyleSelector // TypeDefIndex: 43806
	{
		// Fields
		[SerializeField]
		private StyleSelectorPart[] m_Parts; // 0x10
		[SerializeField]
		private StyleSelectorRelationship m_PreviousRelationship; // 0x18
		internal int pseudoStateMask; // 0x1C
		internal int negatedPseudoStateMask; // 0x20
	
		// Properties
		public StyleSelectorPart[] parts { get => default; internal set {} } // 0x0000000183D66B80-0x0000000183D66B90 0x000000018426FEE0-0x000000018426FEF0
		public StyleSelectorRelationship previousRelationship { get => default; internal set {} } // 0x0000000183D68AE0-0x0000000183D68AF0 0x0000000183D4E9C0-0x0000000183D4E9D0
	
		// Constructors
		public StyleSelector() {} // 0x0000000183D899B0-0x0000000183D899C0
	
		// Methods
		public override string ToString() => default; // 0x0000000189F512A8-0x0000000189F51458
	}

	[Serializable]
	internal struct StyleSelectorPart // TypeDefIndex: 43807
	{
		// Fields
		[SerializeField]
		private string m_Value; // 0x00
		[SerializeField]
		private StyleSelectorType m_Type; // 0x08
		internal object tempData; // 0x10
	
		// Properties
		public string value { get => default; } // 0x000000018253BE20-0x000000018253BE30 
		public StyleSelectorType type { get => default; internal set {} } // 0x0000000183D68070-0x0000000183D68080 0x0000000183D51710-0x0000000183D51720
	
		// Methods
		public override string ToString() => default; // 0x0000000189F511D0-0x0000000189F512A8
		public static StyleSelectorPart CreateClass(string className) => default; // 0x0000000189F510E0-0x0000000189F51130
		public static StyleSelectorPart CreateId(string Id) => default; // 0x0000000189F51130-0x0000000189F51180
		public static StyleSelectorPart CreatePredicate(object predicate) => default; // 0x0000000189F51180-0x0000000189F511D0
	}

	internal enum StyleSelectorRelationship // TypeDefIndex: 43808
	{
		None = 0,
		Child = 1,
		Descendent = 2
	}

	internal enum StyleSelectorType // TypeDefIndex: 43809
	{
		Unknown = 0,
		Wildcard = 1,
		Type = 2,
		Class = 3,
		PseudoClass = 4,
		RecursivePseudoClass = 5,
		ID = 6,
		Predicate = 7
	}

	[Serializable]
	public class StyleSheet : ScriptableObject // TypeDefIndex: 43811
	{
		// Fields
		[SerializeField]
		private bool m_ImportedWithErrors; // 0x18
		[SerializeField]
		private bool m_ImportedWithWarnings; // 0x19
		[SerializeField]
		private StyleRule[] m_Rules; // 0x20
		[SerializeField]
		private StyleComplexSelector[] m_ComplexSelectors; // 0x28
		[SerializeField]
		internal float[] floats; // 0x30
		[SerializeField]
		internal Dimension[] dimensions; // 0x38
		[SerializeField]
		internal UnityEngine.Color[] colors; // 0x40
		[SerializeField]
		internal string[] strings; // 0x48
		[SerializeField]
		internal UnityEngine.Object[] assets; // 0x50
		[SerializeField]
		internal ImportStruct[] imports; // 0x58
		[SerializeField]
		private List<StyleSheet> m_FlattenedImportedStyleSheets; // 0x60
		[SerializeField]
		private int m_ContentHash; // 0x68
		[SerializeField]
		internal ScalableImage[] scalableImages; // 0x70
		[NonSerialized]
		internal Dictionary<string, StyleComplexSelector> orderedNameSelectors; // 0x78
		[NonSerialized]
		internal Dictionary<string, StyleComplexSelector> orderedTypeSelectors; // 0x80
		[NonSerialized]
		internal Dictionary<string, StyleComplexSelector> orderedClassSelectors; // 0x88
		[NonSerialized]
		private bool m_IsDefaultStyleSheet; // 0x90
		private static string kCustomPropertyMarker; // 0x00
	
		// Properties
		public bool importedWithErrors { get => default; internal set {} } // 0x0000000183D899E0-0x0000000183D899F0 0x0000000181002B40-0x0000000181002B50
		public bool importedWithWarnings { get => default; internal set {} } // 0x0000000183D899F0-0x0000000183D89A00 0x0000000183D4EFB0-0x0000000183D4EFC0
		internal StyleRule[] rules { get => default; set {} } // 0x0000000183D85A20-0x0000000183D85A30 0x0000000189F527A0-0x0000000189F527C4
		internal StyleComplexSelector[] complexSelectors { get => default; set {} } // 0x0000000183D86CD0-0x0000000183D86CE0 0x0000000189F5265C-0x0000000189F52680
		internal List<StyleSheet> flattenedRecursiveImports { get => default; } // 0x0000000183D87D60-0x0000000183D87D70 
		public int contentHash { get => default; set {} } // 0x0000000183D899D0-0x0000000183D899E0 0x0000000183D4EF30-0x0000000183D4EF40
		internal bool isDefaultStyleSheet { get => default; set {} } // 0x0000000183D89A00-0x0000000183D89A10 0x0000000189F52680-0x0000000189F527A0
	
		// Nested types
		[Serializable]
		internal struct ImportStruct // TypeDefIndex: 43810
		{
			// Fields
			public StyleSheet styleSheet; // 0x00
			public string[] mediaQueries; // 0x08
		}
	
		// Constructors
		public StyleSheet() {} // 0x000000018286F540-0x000000018286F550
		static StyleSheet() {} // 0x0000000189F52600-0x0000000189F5265C
	
		// Methods
		private static bool TryCheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle, out ref T value) {
			value = default;
			return default;
		}
		private static T CheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle) => default;
		internal virtual void OnEnable() {} // 0x0000000189F51680-0x0000000189F51688
		internal void FlattenImportedStyleSheetsRecursive() {} // 0x0000000189F515FC-0x0000000189F51680
		private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) {} // 0x0000000189F51504-0x0000000189F515FC
		private void SetupReferences() {} // 0x0000000189F51C94-0x0000000189F52130
		internal StyleValueKeyword ReadKeyword(StyleValueHandle handle) => default; // 0x0000000183D899C0-0x0000000183D899D0
		internal float ReadFloat(StyleValueHandle handle) => default; // 0x0000000189F518A4-0x0000000189F5194C
		internal bool TryReadFloat(StyleValueHandle handle, out float value) {
			value = default;
			return default;
		} // 0x0000000189F523A0-0x0000000189F52480
		internal Dimension ReadDimension(StyleValueHandle handle) => default; // 0x0000000189F51788-0x0000000189F51838
		internal bool TryReadDimension(StyleValueHandle handle, out Dimension value) {
			value = default;
			return default;
		} // 0x0000000189F52230-0x0000000189F52320
		internal UnityEngine.Color ReadColor(StyleValueHandle handle) => default; // 0x0000000189F516F4-0x0000000189F51788
		internal bool TryReadColor(StyleValueHandle handle, out UnityEngine.Color value) {
			value = default;
			return default;
		} // 0x0000000189F521B0-0x0000000189F52230
		internal string ReadString(StyleValueHandle handle) => default; // 0x0000000189F51BBC-0x0000000189F51C28
		internal bool TryReadString(StyleValueHandle handle, out string value) {
			value = default;
			return default;
		} // 0x0000000189F52500-0x0000000189F52580
		internal string ReadEnum(StyleValueHandle handle) => default; // 0x0000000189F51838-0x0000000189F518A4
		internal bool TryReadEnum(StyleValueHandle handle, out string value) {
			value = default;
			return default;
		} // 0x0000000189F52320-0x0000000189F523A0
		internal string ReadVariable(StyleValueHandle handle) => default; // 0x0000000189F51C28-0x0000000189F51C94
		internal bool TryReadVariable(StyleValueHandle handle, out string value) {
			value = default;
			return default;
		} // 0x0000000189F52580-0x0000000189F52600
		internal string ReadResourcePath(StyleValueHandle handle) => default; // 0x0000000189F51ABC-0x0000000189F51B28
		internal bool TryReadResourcePath(StyleValueHandle handle, out string value) {
			value = default;
			return default;
		} // 0x0000000189F52480-0x0000000189F52500
		internal UnityEngine.Object ReadAssetReference(StyleValueHandle handle) => default; // 0x0000000189F51688-0x0000000189F516F4
		internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle) => default; // 0x0000000189F51A50-0x0000000189F51ABC
		internal bool TryReadAssetReference(StyleValueHandle handle, out UnityEngine.Object value) {
			value = default;
			return default;
		} // 0x0000000189F52130-0x0000000189F521B0
		internal StyleValueFunction ReadFunction(StyleValueHandle handle) => default; // 0x0000000183D899C0-0x0000000183D899D0
		internal string ReadFunctionName(StyleValueHandle handle) => default; // 0x0000000189F5194C-0x0000000189F51A50
		internal ScalableImage ReadScalableImage(StyleValueHandle handle) => default; // 0x0000000189F51B28-0x0000000189F51BBC
		private static bool CustomStartsWith(string originalString, string pattern) => default; // 0x0000000189F51458-0x0000000189F51504
	}

	internal enum StyleValueFunction // TypeDefIndex: 43812
	{
		Unknown = 0,
		Var = 1,
		Env = 2,
		LinearGradient = 3
	}

	internal static class StyleValueFunctionExtension // TypeDefIndex: 43813
	{
		// Extension methods
		public static string ToUssString(this StyleValueFunction svf) => default; // 0x0000000189F527C4-0x0000000189F528DC
	}

	[Serializable]
	internal struct StyleValueHandle // TypeDefIndex: 43814
	{
		// Fields
		[SerializeField]
		private StyleValueType m_ValueType; // 0x00
		[SerializeField]
		internal int valueIndex; // 0x04
	
		// Properties
		public StyleValueType valueType { get => default; internal set {} } // 0x0000000183D85860-0x0000000183D85870 0x0000000183D4E970-0x0000000183D4E980
	}

	internal enum StyleValueKeyword // TypeDefIndex: 43815
	{
		Inherit = 0,
		Initial = 1,
		Auto = 2,
		Unset = 3,
		True = 4,
		False = 5,
		None = 6
	}

	internal static class StyleValueKeywordExtension // TypeDefIndex: 43816
	{
		// Extension methods
		public static string ToUssString(this StyleValueKeyword svk) => default; // 0x0000000189F528DC-0x0000000189F52A6C
	}

	internal enum StyleValueType // TypeDefIndex: 43817
	{
		Invalid = 0,
		Keyword = 1,
		Float = 2,
		Dimension = 3,
		Color = 4,
		ResourcePath = 5,
		AssetReference = 6,
		Enum = 7,
		Variable = 8,
		String = 9,
		Function = 10,
		CommaSeparator = 11,
		ScalableImage = 12,
		MissingAssetReference = 13
	}

	internal struct StyleVariable // TypeDefIndex: 43818
	{
		// Fields
		public readonly string name; // 0x00
		public readonly StyleSheet sheet; // 0x08
		public readonly StyleValueHandle[] handles; // 0x10
	
		// Constructors
		public StyleVariable(string name, StyleSheet sheet, StyleValueHandle[] handles) {
			this.name = default;
			this.sheet = default;
			this.handles = default;
		} // 0x000000018314F010-0x000000018314F040
	
		// Methods
		public override int GetHashCode() => default; // 0x0000000189F53E40-0x0000000189F53EB4
	}

	internal class StyleVariableContext // TypeDefIndex: 43820
	{
		// Fields
		public static readonly StyleVariableContext none; // 0x00
		private int m_VariableHash; // 0x10
		private List<StyleVariable> m_Variables; // 0x18
		private List<int> m_SortedHash; // 0x20
		private List<int> m_UnsortedHash; // 0x28
	
		// Constructors
		public StyleVariableContext() {} // 0x0000000189F530C4-0x0000000189F531BC
		public StyleVariableContext(StyleVariableContext other) {} // 0x0000000189F52F94-0x0000000189F530C4
		static StyleVariableContext() {} // 0x0000000189F52F24-0x0000000189F52F94
	
		// Methods
		public void Add(StyleVariable sv) {} // 0x0000000189F52B68-0x0000000189F52D90
		public void AddInitialRange(StyleVariableContext other) {} // 0x0000000189F52A6C-0x0000000189F52B68
		public void Clear() {} // 0x0000000189F52D90-0x0000000189F52E1C
		public bool TryFindVariable(string name, out StyleVariable v) {
			v = default;
			return default;
		} // 0x0000000189F52E1C-0x0000000189F52F24
		public int GetVariableHash() => default; // 0x0000000183D85B00-0x0000000183D85B10
	}

	internal class StyleVariableResolver // TypeDefIndex: 43823
	{
		// Fields
		internal const int kMaxResolves = 100; // Metadata: 0x01FB60B6
		private static StyleSyntaxParser s_SyntaxParser; // 0x00
		private StylePropertyValueMatcher m_Matcher; // 0x10
		private List<StylePropertyValue> m_ResolvedValues; // 0x18
		private Stack<string> m_ResolvedVarStack; // 0x20
		private StyleProperty m_Property; // 0x28
		private Stack<ResolveContext> m_ContextStack; // 0x30
		private ResolveContext m_CurrentContext; // 0x38
	
		// Properties
		private StyleSheet currentSheet { get => default; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 
		private StyleValueHandle[] currentHandles { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		public List<StylePropertyValue> resolvedValues { get => default; } // 0x0000000181041090-0x00000001810410A0 
		public StyleVariableContext variableContext { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
	
		// Nested types
		private enum Result // TypeDefIndex: 43821
		{
			Valid = 0,
			Invalid = 1,
			NotFound = 2
		}
	
		private struct ResolveContext // TypeDefIndex: 43822
		{
			// Fields
			public StyleSheet sheet; // 0x00
			public StyleValueHandle[] handles; // 0x08
		}
	
		// Constructors
		public StyleVariableResolver() {} // 0x0000000189F53CFC-0x0000000189F53E40
		static StyleVariableResolver() {} // 0x0000000189F53C80-0x0000000189F53CFC
	
		// Methods
		public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles) {} // 0x0000000189F53240-0x0000000189F532EC
		private void PushContext(StyleSheet sheet, StyleValueHandle[] handles) {} // 0x0000000189F53418-0x0000000189F534C0
		private void PopContext() {} // 0x0000000189F53394-0x0000000189F53418
		public void AddValue(StyleValueHandle handle) {} // 0x0000000189F531BC-0x0000000189F53240
		public bool ResolveVarFunction(ref int index) => default; // 0x0000000189F537FC-0x0000000189F538C0
		private Result ResolveVarFunction(ref int index, int argc, string varName) => default; // 0x0000000189F536D4-0x0000000189F537FC
		public bool ValidateResolvedValues() => default; // 0x0000000189F53B3C-0x0000000189F53C80
		private Result ResolveVariable(string variableName) => default; // 0x0000000189F538C0-0x0000000189F53B3C
		private Result ResolveFallback(ref int index) => default; // 0x0000000189F534C0-0x0000000189F536D4
		private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName) {
			argCount = default;
			variableName = default;
		} // 0x0000000189F532EC-0x0000000189F53394
	}

	[Serializable]
	public class ThemeStyleSheet : StyleSheet // TypeDefIndex: 43824
	{
		// Constructors
		public ThemeStyleSheet() {} // 0x0000000189F56730-0x0000000189F5677C
	
		// Methods
		internal override void OnEnable() {} // 0x0000000189F5670C-0x0000000189F56730
	}

	public class PanelTextSettings : TextSettings // TypeDefIndex: 43825
	{
		// Fields
		private static PanelTextSettings s_DefaultPanelTextSettings; // 0x00
		internal static Func<string, UnityEngine.Object> EditorGUIUtilityLoad; // 0x08
		internal static Func<SystemLanguage> GetCurrentLanguage; // 0x10
		internal static readonly string s_DefaultEditorPanelTextSettingPath; // 0x18
	
		// Properties
		internal static PanelTextSettings defaultPanelTextSettings { get => default; } // 0x0000000189F500A4-0x0000000189F501B4 
	
		// Constructors
		public PanelTextSettings() {} // 0x0000000189F5009C-0x0000000189F500A4
		static PanelTextSettings() {} // 0x0000000189F5003C-0x0000000189F5009C
	
		// Methods
		internal static void UpdateLocalizationFontAsset() {} // 0x0000000189F4FC00-0x0000000189F5003C
		internal FontAsset GetCachedFontAsset(Font font) => default; // 0x0000000189F4FBF4-0x0000000189F4FC00
	}

	internal interface ITextHandle // TypeDefIndex: 43826
	{
		// Properties
		Vector2 MeasuredSizes { get; set; }
		Vector2 RoundedSizes { get; set; }
	
		// Methods
		Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling);
		float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling);
		float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling);
		float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint);
		TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint);
		bool IsLegacy();
		bool IsElided();
	}

	internal struct TextCoreHandle : ITextHandle // TypeDefIndex: 43827
	{
		// Fields
		private Vector2 m_PreferredSize; // 0x10
		private int m_PreviousGenerationSettingsHash; // 0x18
		private UnityEngine.TextCore.Text.TextGenerationSettings m_CurrentGenerationSettings; // 0x20
		private static UnityEngine.TextCore.Text.TextGenerationSettings s_LayoutSettings; // 0x00
		private TextInfo m_TextInfoMesh; // 0x28
		private static TextInfo s_TextInfoLayout; // 0x08
		private bool isDirty; // 0x30
	
		// Properties
		public Vector2 MeasuredSizes { [IsReadOnly] get; set; } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		public Vector2 RoundedSizes { [IsReadOnly] get; set; } // 0x0000000183D67720-0x0000000183D67740 0x0000000183D55BA0-0x0000000183D55BB0
		internal TextInfo textInfoMesh { get => default; } // 0x0000000189F5516C-0x0000000189F551DC 
		internal static TextInfo textInfoLayout { get => default; } // 0x0000000189F550A0-0x0000000189F5516C 
	
		// Constructors
		static TextCoreHandle() {
			s_LayoutSettings = default;
			s_TextInfoLayout = default;
		} // 0x0000000189F55024-0x0000000189F550A0
	
		// Methods
		public static ITextHandle New() => default; // 0x0000000189F54480-0x0000000189F54544
		public bool IsLegacy() => default; // 0x0000000183D4E3A0-0x0000000183D4E3B0
		public bool IsDirty(MeshGenerationContextUtils.TextParams parms) => default; // 0x0000000189F543F8-0x0000000189F5442C
		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling) => default; // 0x0000000189F540B4-0x0000000189F54140
		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling) => default; // 0x0000000189F53FF8-0x0000000189F540B4
		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling) => default; // 0x0000000189F53F3C-0x0000000189F53FF8
		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint) => default; // 0x0000000189F54140-0x0000000189F5423C
		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint) => default; // 0x0000000189F54CEC-0x0000000189F55024
		private void UpdatePreferredValues(MeshGenerationContextUtils.TextParams parms) {} // 0x0000000189F54B98-0x0000000189F54CEC
		private static TextOverflowMode GetTextOverflowMode(MeshGenerationContextUtils.TextParams textParams) => default; // 0x0000000189F5423C-0x0000000189F543F8
		private static void UpdateGenerationSettingsCommon(MeshGenerationContextUtils.TextParams painterParams, UnityEngine.TextCore.Text.TextGenerationSettings settings) {} // 0x0000000189F54544-0x0000000189F54B98
		public bool IsElided() => default; // 0x0000000189F5442C-0x0000000189F54480
	}

	internal struct TextNativeHandle : ITextHandle // TypeDefIndex: 43828
	{
		// Fields
		internal NativeArray<UnityEngine.UIElements.TextVertex> textVertices; // 0x10
		private int m_PreviousTextParamsHash; // 0x20
	
		// Properties
		public Vector2 MeasuredSizes { [IsReadOnly] get; set; } // 0x00000001820C61B0-0x00000001820C61C0 0x0000000183D51730-0x0000000183D51740
		public Vector2 RoundedSizes { [IsReadOnly] get; set; } // 0x0000000183D67720-0x0000000183D67740 0x0000000183D55BA0-0x0000000183D55BB0
	
		// Methods
		public static ITextHandle New() => default; // 0x0000000189F55700-0x0000000189F5575C
		public bool IsLegacy() => default; // 0x0000000183D663A0-0x0000000183D663B0
		public float GetLineHeight(int characterIndex, MeshGenerationContextUtils.TextParams textParams, float textScaling, float pixelPerPoint) => default; // 0x0000000189F553EC-0x0000000189F5547C
		public TextInfo Update(MeshGenerationContextUtils.TextParams parms, float pixelsPerPoint) => default; // 0x0000000189F5575C-0x0000000189F557AC
		public NativeArray<UnityEngine.UIElements.TextVertex> GetVertices(MeshGenerationContextUtils.TextParams parms, float scaling) => default; // 0x0000000189F5547C-0x0000000189F55700
		public Vector2 GetCursorPosition(CursorPositionStylePainterParameters parms, float scaling) => default; // 0x0000000189F55370-0x0000000189F553EC
		public float ComputeTextWidth(MeshGenerationContextUtils.TextParams parms, float scaling) => default; // 0x0000000189F55290-0x0000000189F55370
		public float ComputeTextHeight(MeshGenerationContextUtils.TextParams parms, float scaling) => default; // 0x0000000189F551DC-0x0000000189F55290
		public bool IsElided() => default; // 0x0000000183D4E3A0-0x0000000183D4E3B0
	}

	internal static class TextUtilities // TypeDefIndex: 43829
	{
		// Methods
		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint) => default; // 0x0000000189F557AC-0x0000000189F5583C
		internal static Vector2 MeasureVisualElementTextSize(VisualElement ve, string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, ITextHandle textHandle) => default; // 0x0000000189F56364-0x0000000189F5670C
		internal static FontAsset GetFontAsset(MeshGenerationContextUtils.TextParams textParam) => default; // 0x0000000189F5583C-0x0000000189F559B0
		internal static FontAsset GetFontAsset(VisualElement ve) => default; // 0x0000000189F559B0-0x0000000189F55AE8
		internal static Font GetFont(MeshGenerationContextUtils.TextParams textParam) => default; // 0x0000000189F55AE8-0x0000000189F55C40
		internal static Font GetFont(VisualElement ve) => default; // 0x0000000189F55C40-0x0000000189F55D88
		internal static bool IsFontAssigned(VisualElement ve) => default; // 0x0000000189F562B8-0x0000000189F56364
		internal static bool IsFontAssigned(MeshGenerationContextUtils.TextParams textParams) => default; // 0x0000000189F561EC-0x0000000189F562B8
		internal static PanelTextSettings GetTextSettingsFrom(VisualElement ve) => default; // 0x0000000189F56080-0x0000000189F56108
		internal static PanelTextSettings GetTextSettingsFrom(MeshGenerationContextUtils.TextParams textParam) => default; // 0x0000000189F56108-0x0000000189F561EC
		internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve) => default; // 0x0000000189F55D88-0x0000000189F56080
	}

	public interface IUxmlAttributes // TypeDefIndex: 43830
	{
		// Methods
		bool TryGetAttributeValue(string attributeName, out string value);
	}

	public class UxmlRootElementFactory : UxmlFactory<VisualElement, UxmlRootElementTraits> // TypeDefIndex: 43831
	{
		// Properties
		public override string uxmlName { get => default; } // 0x0000000189F5A7D0-0x0000000189F5A7FC 
		public override string uxmlQualifiedName { get => default; } // 0x0000000189F5A7FC-0x0000000189F5A870 
	
		// Constructors
		public UxmlRootElementFactory() {} // 0x0000000189F5A794-0x0000000189F5A7D0
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000183D85B20-0x0000000183D85B30
	}

	public class UxmlRootElementTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 43832
	{
		// Fields
		protected UxmlStringAttributeDescription m_Name; // 0x18
		private UxmlStringAttributeDescription m_Class; // 0x20
	
		// Constructors
		public UxmlRootElementTraits() {} // 0x0000000189F5A870-0x0000000189F5A944
	}

	public class UxmlStyleFactory : UxmlFactory<VisualElement, UxmlStyleTraits> // TypeDefIndex: 43833
	{
		// Properties
		public override string uxmlName { get => default; } // 0x0000000189F5ACD8-0x0000000189F5AD04 
		public override string uxmlQualifiedName { get => default; } // 0x0000000189F5AD04-0x0000000189F5AD78 
	
		// Constructors
		public UxmlStyleFactory() {} // 0x0000000189F5AC9C-0x0000000189F5ACD8
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000183D85B20-0x0000000183D85B30
	}

	public class UxmlStyleTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 43834
	{
		// Fields
		private UxmlStringAttributeDescription m_Name; // 0x18
		private UxmlStringAttributeDescription m_Path; // 0x20
		private UxmlStringAttributeDescription m_Src; // 0x28
	
		// Constructors
		public UxmlStyleTraits() {} // 0x0000000189F5AD78-0x0000000189F5AE9C
	}

	public class UxmlTemplateFactory : UxmlFactory<VisualElement, UxmlTemplateTraits> // TypeDefIndex: 43835
	{
		// Properties
		public override string uxmlName { get => default; } // 0x0000000189F5AED8-0x0000000189F5AF04 
		public override string uxmlQualifiedName { get => default; } // 0x0000000189F5AF04-0x0000000189F5AF78 
	
		// Constructors
		public UxmlTemplateFactory() {} // 0x0000000189F5AE9C-0x0000000189F5AED8
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000183D85B20-0x0000000183D85B30
	}

	public class UxmlTemplateTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 43836
	{
		// Fields
		private UxmlStringAttributeDescription m_Name; // 0x18
		private UxmlStringAttributeDescription m_Path; // 0x20
		private UxmlStringAttributeDescription m_Src; // 0x28
	
		// Constructors
		public UxmlTemplateTraits() {} // 0x0000000189F5AF78-0x0000000189F5B0A4
	}

	public class UxmlAttributeOverridesFactory : UxmlFactory<VisualElement, UxmlAttributeOverridesTraits> // TypeDefIndex: 43837
	{
		// Properties
		public override string uxmlName { get => default; } // 0x0000000189F590D8-0x0000000189F59104 
		public override string uxmlQualifiedName { get => default; } // 0x0000000189F59104-0x0000000189F59178 
	
		// Constructors
		public UxmlAttributeOverridesFactory() {} // 0x0000000189F5909C-0x0000000189F590D8
	
		// Methods
		public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000183D85B20-0x0000000183D85B30
	}

	public class UxmlAttributeOverridesTraits : UnityEngine.UIElements.UxmlTraits // TypeDefIndex: 43838
	{
		// Fields
		private UxmlStringAttributeDescription m_ElementName; // 0x18
	
		// Constructors
		public UxmlAttributeOverridesTraits() {} // 0x0000000189F59178-0x0000000189F59208
	}

	[Serializable]
	internal class TemplateAsset : VisualElementAsset // TypeDefIndex: 43840
	{
		// Fields
		[SerializeField]
		private string m_TemplateAlias; // 0x70
		[SerializeField]
		private List<AttributeOverride> m_AttributeOverrides; // 0x78
		[SerializeField]
		private List<VisualTreeAsset.SlotUsageEntry> m_SlotUsages; // 0x80
	
		// Properties
		public List<AttributeOverride> attributeOverrides { get => default; } // 0x0000000189F53EB4-0x0000000189F53F3C 
		internal List<VisualTreeAsset.SlotUsageEntry> slotUsages { get => default; } // 0x0000000183D87E00-0x0000000183D87E10 
	
		// Nested types
		[Serializable]
		public struct AttributeOverride // TypeDefIndex: 43839
		{
			// Fields
			public string m_ElementName; // 0x00
			public string m_AttributeName; // 0x08
			public string m_Value; // 0x10
		}
	
		// Constructors
		public TemplateAsset() {} // Dummy constructor
	}

	public abstract class UxmlAttributeDescription // TypeDefIndex: 43842
	{
		// Fields
		private string[] m_ObsoleteNames; // 0x18
	
		// Properties
		public string name { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public IEnumerable<string> obsoleteNames { get; set; } // 0x0000000189F59048-0x0000000189F5909C
		protected string type { get; set; } // 0x0000000184271930-0x0000000184271940
		protected string typeNamespace { get; set; } // 0x0000000182C92F10-0x0000000182C92F20
		public Use use { get; set; } // 0x0000000183D4EE10-0x0000000183D4EE20
		public UxmlTypeRestriction restriction { get; set; } // 0x000000018388FF30-0x000000018388FF40
	
		// Nested types
		public enum Use // TypeDefIndex: 43841
		{
			None = 0,
			Optional = 1,
			Prohibited = 2,
			Required = 3
		}
	
		// Constructors
		protected UxmlAttributeDescription() {} // 0x0000000187D83124-0x0000000187D8313C
	
		// Methods
		internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value) {
			value = default;
			return default;
		} // 0x0000000189F58CC4-0x0000000189F59048
		protected bool TryGetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue, ref ref T value) => default;
		protected T GetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue) => default;
	}

	public abstract class TypedUxmlAttributeDescription<T> : UxmlAttributeDescription // TypeDefIndex: 43843
	{
		// Properties
		public T defaultValue { get; set; }
	
		// Constructors
		protected TypedUxmlAttributeDescription() {}
	
		// Methods
		public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
	}

	public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<string> // TypeDefIndex: 43845
	{
		// Constructors
		public UxmlStringAttributeDescription() {} // 0x0000000189F5ABF4-0x0000000189F5AC9C
	
		// Methods
		public override string GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000189F5A944-0x0000000189F5AA98
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value) => default; // 0x0000000189F5AA98-0x0000000189F5ABF4
	}

	public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription<float> // TypeDefIndex: 43847
	{
		// Constructors
		public UxmlFloatAttributeDescription() {} // 0x0000000189F59808-0x0000000189F59888
	
		// Methods
		public override float GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000189F596B0-0x0000000189F59808
		private static float ConvertValueToFloat(string v, float defaultValue) => default; // 0x0000000189F59630-0x0000000189F596B0
	}

	public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<int> // TypeDefIndex: 43849
	{
		// Constructors
		public UxmlIntAttributeDescription() {} // 0x0000000189F59B64-0x0000000189F59BF0
	
		// Methods
		public override int GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000189F598B8-0x0000000189F59A0C
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value) => default; // 0x0000000189F59A0C-0x0000000189F59B64
		private static int ConvertValueToInt(string v, int defaultValue) => default; // 0x0000000189F59888-0x0000000189F598B8
	}

	public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<long> // TypeDefIndex: 43851
	{
		// Constructors
		public UxmlLongAttributeDescription() {} // 0x0000000189F59D78-0x0000000189F59E04
	
		// Methods
		public override long GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000189F59C24-0x0000000189F59D78
		private static long ConvertValueToLong(string v, long defaultValue) => default; // 0x0000000189F59BF0-0x0000000189F59C24
	}

	public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription<bool> // TypeDefIndex: 43853
	{
		// Constructors
		public UxmlBoolAttributeDescription() {} // 0x0000000189F593C4-0x0000000189F59450
	
		// Methods
		public override bool GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default; // 0x0000000189F59270-0x0000000189F593C4
		private static bool ConvertValueToBool(string v, bool defaultValue) => default; // 0x0000000189F59208-0x0000000189F59270
	}

	public class UxmlEnumAttributeDescription<T> : TypedUxmlAttributeDescription<T> // TypeDefIndex: 43855
		where T : struct, IConvertible
	{
		// Constructors
		public UxmlEnumAttributeDescription() {}
	
		// Methods
		public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default;
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref ref T value) => default;
		private static U ConvertValueToEnum<U>(string v, U defaultValue) => default;
	}

	internal class UxmlObjectAttributeDescription<T> // TypeDefIndex: 43856
		where T : new()
	{
		// Properties
		public T defaultValue { get; }
	
		// Constructors
		public UxmlObjectAttributeDescription() {}
	
		// Methods
		public virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default;
	}

	internal class UxmlObjectListAttributeDescription<T> : UxmlObjectAttributeDescription<List<T>> // TypeDefIndex: 43857
		where T : new()
	{
		// Constructors
		public UxmlObjectListAttributeDescription() {}
	
		// Methods
		public override List<T> GetValueFromBag(IUxmlAttributes bag, CreationContext cc) => default;
	}

	public abstract class UxmlTraits // TypeDefIndex: 43858
	{
		// Properties
		protected bool canHaveAnyAttribute { get; set; } // 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		protected UxmlTraits() {} // 0x0000000181168960-0x0000000181168970
	
		// Methods
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {} // 0x000000018350B670-0x000000018350B680
	}

	public interface IUxmlFactory // TypeDefIndex: 43859
	{
		// Properties
		string uxmlQualifiedName { get; }
	
		// Methods
		bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
		VisualElement Create(IUxmlAttributes bag, CreationContext cc);
	}

	public class UxmlFactory<TCreatedType, TTraits> : IUxmlFactory // TypeDefIndex: 43860
		where TCreatedType : VisualElement, new()
		where TTraits : UnityEngine.UIElements.UxmlTraits, new()
	{
		// Fields
		internal TTraits m_Traits;
	
		// Properties
		public virtual string uxmlName { get => default; }
		public virtual string uxmlNamespace { get => default; }
		public virtual string uxmlQualifiedName { get => default; }
	
		// Constructors
		protected UxmlFactory() {}
	
		// Methods
		public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) => default;
		public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) => default;
	}

	public class UxmlFactory<TCreatedType> : UxmlFactory<TCreatedType, VisualElement.UxmlTraits> // TypeDefIndex: 43861
		where TCreatedType : VisualElement, new()
	{
		// Constructors
		public UxmlFactory() {}
	}

	public abstract class BaseUxmlTraits // TypeDefIndex: 43862
	{
		// Properties
		protected bool canHaveAnyAttribute { get; set; } // 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		protected BaseUxmlTraits() {} // 0x0000000181168960-0x0000000181168970
	}

	internal abstract class UxmlObjectTraits<T> : BaseUxmlTraits // TypeDefIndex: 43863
	{
		// Constructors
		protected UxmlObjectTraits() {}
	
		// Methods
		public virtual void Init(ref ref T obj, IUxmlAttributes bag, CreationContext cc) {}
	}

	public interface IBaseUxmlFactory // TypeDefIndex: 43864
	{
		// Properties
		string uxmlQualifiedName { get; }
	
		// Methods
		bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
	}

	internal interface IBaseUxmlObjectFactory : IBaseUxmlFactory // TypeDefIndex: 43865
	{
	}

	internal interface IUxmlObjectFactory<out T> : IBaseUxmlObjectFactory // TypeDefIndex: 43866
		where T : new()
	{
		// Methods
		T CreateObject(IUxmlAttributes bag, CreationContext cc);
	}

	internal class UxmlObjectFactory<TCreatedType, TTraits> : BaseUxmlFactory<TCreatedType, TTraits>, IUxmlObjectFactory<TCreatedType> // TypeDefIndex: 43867
		where TCreatedType : new()
		where TTraits : UnityEngine.UIElements.UxmlObjectTraits<TCreatedType>, new()
	{
		// Constructors
		public UxmlObjectFactory() {}
	
		// Methods
		public virtual TCreatedType CreateObject(IUxmlAttributes bag, CreationContext cc) => default;
	}

	public abstract class BaseUxmlFactory<TCreatedType, TTraits> // TypeDefIndex: 43868
		where TCreatedType : new()
		where TTraits : BaseUxmlTraits, new()
	{
		// Fields
		internal TTraits m_Traits;
	
		// Properties
		public virtual string uxmlQualifiedName { get; }
	
		// Constructors
		protected BaseUxmlFactory() {}
	
		// Methods
		public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) => default;
	}

	[Serializable]
	internal class UxmlAsset : IUxmlAttributes // TypeDefIndex: 43869
	{
		// Fields
		[SerializeField]
		private string m_FullTypeName; // 0x10
		[SerializeField]
		private int m_Id; // 0x18
		[SerializeField]
		private int m_OrderInDocument; // 0x1C
		[SerializeField]
		private int m_ParentId; // 0x20
		[SerializeField]
		protected List<string> m_Properties; // 0x28
	
		// Properties
		public string fullTypeName { get => default; } // 0x00000001820B7B20-0x00000001820B7B30 
		public int id { get => default; } // 0x00000001820D1AC0-0x00000001820D1AD0 
		public int orderInDocument { get => default; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 
		public int parentId { get => default; } // 0x0000000181003B50-0x0000000181003B60 
	
		// Constructors
		public UxmlAsset() {} // Dummy constructor
	
		// Methods
		public bool TryGetAttributeValue(string propertyName, out string value) {
			value = default;
			return default;
		} // 0x0000000189F58BE4-0x0000000189F58CC4
		public void SetAttribute(string name, string value) {} // 0x0000000189F58A8C-0x0000000189F58A94
		private void SetOrAddProperty(string propertyName, string propertyValue) {} // 0x0000000189F58A94-0x0000000189F58BE4
	}

	[Serializable]
	internal sealed class UxmlObjectAsset : UxmlAsset // TypeDefIndex: 43870
	{
		// Constructors
		public UxmlObjectAsset() {} // Dummy constructor
	}

	internal class UxmlObjectFactoryRegistry // TypeDefIndex: 43871
	{
		// Fields
		private static Dictionary<string, List<IBaseUxmlObjectFactory>> s_Factories; // 0x00
	
		// Properties
		internal static Dictionary<string, List<IBaseUxmlObjectFactory>> factories { get => default; } // 0x0000000189F5A6D4-0x0000000189F5A794 
	
		// Constructors
		public UxmlObjectFactoryRegistry() {} // Dummy constructor
	
		// Methods
		protected static void RegisterFactory(IBaseUxmlObjectFactory factory) {} // 0x0000000189F59FE4-0x0000000189F5A408
		internal static bool TryGetFactories(string fullTypeName, out List<IBaseUxmlObjectFactory> factoryList) {
			factoryList = default;
			return default;
		} // 0x0000000189F5A674-0x0000000189F5A6D4
		private static void RegisterEngineFactories() {} // 0x0000000189F59E04-0x0000000189F59FE4
		private static void RegisterUserFactories() {} // 0x0000000189F5A408-0x0000000189F5A674
	}

	public abstract class UxmlTypeRestriction : IEquatable<UxmlTypeRestriction> // TypeDefIndex: 43872
	{
		// Constructors
		protected UxmlTypeRestriction() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual bool Equals(UxmlTypeRestriction other) => default; // 0x000000018232CE30-0x000000018232CE40
	}

	public class UxmlEnumeration : UxmlTypeRestriction // TypeDefIndex: 43873
	{
		// Fields
		private List<string> m_Values; // 0x10
	
		// Properties
		public IEnumerable<string> values { get => default; set {} } // 0x0000000183D66B80-0x0000000183D66B90 0x0000000189F595DC-0x0000000189F59630
	
		// Constructors
		public UxmlEnumeration() {} // 0x0000000189F59564-0x0000000189F595DC
	
		// Methods
		public override bool Equals(UxmlTypeRestriction other) => default; // 0x0000000189F59450-0x0000000189F59564
	}

	[Serializable]
	internal class VisualElementAsset : UxmlAsset, ISerializationCallbackReceiver // TypeDefIndex: 43874
	{
		// Fields
		[SerializeField]
		private string m_Name; // 0x30
		[SerializeField]
		private int m_RuleIndex; // 0x38
		[SerializeField]
		private string m_Text; // 0x40
		[SerializeField]
		private PickingMode m_PickingMode; // 0x48
		[SerializeField]
		private string[] m_Classes; // 0x50
		[SerializeField]
		private List<string> m_StylesheetPaths; // 0x58
		[SerializeField]
		private List<StyleSheet> m_Stylesheets; // 0x60
		[SerializeField]
		private bool m_SkipClone; // 0x68
	
		// Properties
		public int ruleIndex { get => default; } // 0x0000000183D86D20-0x0000000183D86D30 
		public string[] classes { get => default; } // 0x0000000183D87E30-0x0000000183D87E40 
		public List<string> stylesheetPaths { get => default; } // 0x0000000189F5C00C-0x0000000189F5C090 
		public bool hasStylesheetPaths { get => default; } // 0x0000000185C72CF8-0x0000000185C72D04 
		public List<StyleSheet> stylesheets { get => default; } // 0x0000000189F5C090-0x0000000189F5C114 
		public bool hasStylesheets { get => default; } // 0x0000000185B08B40-0x0000000185B08B4C 
		internal bool skipClone { get => default; } // 0x0000000183D4F3F0-0x0000000183D4F400 
	
		// Constructors
		public VisualElementAsset() {} // Dummy constructor
	
		// Methods
		public void OnBeforeSerialize() {} // 0x000000018350B670-0x000000018350B680
		public void OnAfterDeserialize() {} // 0x0000000189F5BE8C-0x0000000189F5C00C
	}

	internal class VisualElementFactoryRegistry // TypeDefIndex: 43875
	{
		// Fields
		private static Dictionary<string, List<IUxmlFactory>> s_Factories; // 0x00
	
		// Properties
		internal static Dictionary<string, List<IUxmlFactory>> factories { get => default; } // 0x0000000189F5D284-0x0000000189F5D344 
	
		// Constructors
		public VisualElementFactoryRegistry() {} // Dummy constructor
	
		// Methods
		protected static void RegisterFactory(IUxmlFactory factory) {} // 0x0000000189F5CB88-0x0000000189F5CFAC
		internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList) {
			factoryList = default;
			return default;
		} // 0x0000000189F5D218-0x0000000189F5D284
		private static void RegisterEngineFactories() {} // 0x0000000189F5C114-0x0000000189F5CB88
		internal static void RegisterUserFactories() {} // 0x0000000189F5CFAC-0x0000000189F5D218
	}

	[Serializable]
	public class VisualTreeAsset : ScriptableObject // TypeDefIndex: 43886
	{
		// Fields
		internal static string LinkedVEAInTemplatePropertyName; // 0x00
		[SerializeField]
		private bool m_ImportedWithErrors; // 0x18
		[SerializeField]
		private bool m_ImportedWithWarnings; // 0x19
		private static readonly Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints; // 0x08
		[SerializeField]
		private List<UsingEntry> m_Usings; // 0x20
		[SerializeField]
		internal StyleSheet inlineSheet; // 0x28
		[SerializeField]
		private List<VisualElementAsset> m_VisualElementAssets; // 0x30
		[SerializeField]
		private List<TemplateAsset> m_TemplateAssets; // 0x38
		[SerializeField]
		private List<UxmlObjectEntry> m_UxmlObjectEntries; // 0x40
		[SerializeField]
		private List<int> m_UxmlObjectIds; // 0x48
		[SerializeField]
		private List<AssetEntry> m_AssetEntries; // 0x50
		[SerializeField]
		private List<SlotDefinition> m_Slots; // 0x58
		[SerializeField]
		private int m_ContentContainerId; // 0x60
		[SerializeField]
		private int m_ContentHash; // 0x64
	
		// Properties
		public bool importedWithErrors { get => default; internal set {} } // 0x0000000183D899E0-0x0000000183D899F0 0x0000000181002B40-0x0000000181002B50
		public bool importedWithWarnings { get => default; internal set {} } // 0x0000000183D899F0-0x0000000183D89A00 0x0000000183D4EFB0-0x0000000183D4EFC0
		public IEnumerable<VisualTreeAsset> templateDependencies { get => default; } // 0x0000000189F5FEBC-0x0000000189F5FF2C 
		public IEnumerable<StyleSheet> stylesheets { get => default; } // 0x0000000189F5FE4C-0x0000000189F5FEBC 
		internal List<VisualElementAsset> visualElementAssets { get => default; set {} } // 0x0000000183D86D10-0x0000000183D86D20 0x0000000184270470-0x0000000184270480
		internal List<TemplateAsset> templateAssets { get => default; set {} } // 0x0000000183D86EB0-0x0000000183D86EC0 0x000000018388FF30-0x000000018388FF40
		internal List<UxmlObjectEntry> uxmlObjectEntries { get => default; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 
		internal List<int> uxmlObjectIds { get => default; } // 0x0000000183D4EA70-0x0000000183D4EA80 
		internal List<SlotDefinition> slots { get => default; set {} } // 0x0000000183D87D70-0x0000000183D87D80 0x0000000183081D30-0x0000000183081D40
		internal int contentContainerId { get => default; set {} } // 0x0000000183D88AC0-0x0000000183D88AD0 0x0000000183D4F5A0-0x0000000183D4F5B0
		public int contentHash { get => default; set {} } // 0x0000000183D89AE0-0x0000000183D89AF0 0x0000000183D50B40-0x0000000183D50B50
	
		// Nested types
		[Serializable]
		internal struct UsingEntry // TypeDefIndex: 43876
		{
			// Fields
			internal static readonly IComparer<UsingEntry> comparer; // 0x00
			[SerializeField]
			public string alias; // 0x00
			[SerializeField]
			public string path; // 0x08
			[SerializeField]
			public VisualTreeAsset asset; // 0x10
	
			// Constructors
			public UsingEntry(string alias, string path) {
				this.alias = default;
				this.path = default;
				asset = default;
			} // 0x0000000189F58A58-0x0000000189F58A8C
			static UsingEntry() {
				comparer = default;
			} // 0x0000000189F589E8-0x0000000189F58A58
		}
	
		private class UsingEntryComparer : IComparer<UsingEntry> // TypeDefIndex: 43877
		{
			// Constructors
			public UsingEntryComparer() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public int Compare(UsingEntry x, UsingEntry y) => default; // 0x0000000189F589C4-0x0000000189F589E8
		}
	
		[Serializable]
		internal struct SlotDefinition // TypeDefIndex: 43878
		{
			// Fields
			[SerializeField]
			public string name; // 0x00
			[SerializeField]
			public int insertionPointId; // 0x08
		}
	
		[Serializable]
		internal struct SlotUsageEntry // TypeDefIndex: 43879
		{
			// Fields
			[SerializeField]
			public string slotName; // 0x00
			[SerializeField]
			public int assetId; // 0x08
		}
	
		[Serializable]
		internal struct UxmlObjectEntry // TypeDefIndex: 43880
		{
			// Fields
			[SerializeField]
			public int parentId; // 0x00
			[SerializeField]
			public List<UxmlObjectAsset> uxmlObjectAssets; // 0x08
	
			// Constructors
			public UxmlObjectEntry(int parentId, List<UxmlObjectAsset> uxmlObjectAssets) {
				this.parentId = default;
				this.uxmlObjectAssets = default;
			} // 0x00000001871AED58-0x00000001871AED68
		}
	
		[Serializable]
		private struct AssetEntry // TypeDefIndex: 43881
		{
			// Fields
			[SerializeField]
			public string path; // 0x00
			[SerializeField]
			public string typeFullName; // 0x08
			[SerializeField]
			public UnityEngine.Object asset; // 0x10
			private System.Type m_CachedType; // 0x18
	
			// Properties
			public System.Type type { get => default; } // 0x0000000189F455EC-0x0000000189F45674 
	
			// Constructors
			public AssetEntry(string path, System.Type type, UnityEngine.Object asset) : this() {
				this.path = default;
				typeFullName = default;
				this.asset = default;
				m_CachedType = default;
			} // 0x0000000189F4557C-0x0000000189F455EC
		}
	
		// Constructors
		public VisualTreeAsset() {} // 0x000000018286F540-0x000000018286F550
		static VisualTreeAsset() {} // 0x0000000189F5FD84-0x0000000189F5FE4C
	
		// Methods
		internal int GetNextChildSerialNumber() => default; // 0x0000000189F5F03C-0x0000000189F5F0BC
		internal void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset) {} // 0x0000000189F5F73C-0x0000000189F5F938
		internal List<T> GetUxmlObjects<T>(IUxmlAttributes asset, CreationContext cc)
			where T : new() => default;
		internal bool AssetEntryExists(string path, System.Type type) => default; // 0x0000000189F5D344-0x0000000189F5D4C8
		internal void RegisterAssetEntry(string path, System.Type type, UnityEngine.Object asset) {} // 0x0000000189F5F62C-0x0000000189F5F73C
		internal T GetAsset<T>(string path)
			where T : UnityEngine.Object => default;
		internal UxmlObjectEntry GetUxmlObjectEntry(int id) => default; // 0x0000000189F5F0BC-0x0000000189F5F1F0
		private IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset) => default; // 0x0000000189F5F1F0-0x0000000189F5F4D4
		public TemplateContainer Instantiate() => default; // 0x0000000189F5F510-0x0000000189F5F62C
		public TemplateContainer Instantiate(string bindingPath) => default; // 0x0000000189F5F4D4-0x0000000189F5F510
		public TemplateContainer CloneTree() => default; // 0x0000000189F5E8C8-0x0000000189F5E8D4
		public TemplateContainer CloneTree(string bindingPath) => default; // 0x0000000189F5E70C-0x0000000189F5E718
		public void CloneTree(VisualElement target) {} // 0x0000000189F5DFE0-0x0000000189F5E008
		public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount) {
			firstElementIndex = default;
			elementAddedCount = default;
		} // 0x0000000189F5E718-0x0000000189F5E8C8
		internal void CloneTree(VisualElement target, Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides) {} // 0x0000000189F5E008-0x0000000189F5E70C
		private VisualElement CloneSetupRecursively(VisualElementAsset root, Dictionary<int, List<VisualElementAsset>> idToChildren, CreationContext context) => default; // 0x0000000189F5D6D4-0x0000000189F5DFE0
		private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b) => default; // 0x0000000189F5E8D4-0x0000000189F5E904
		internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName) {
			slotName = default;
			return default;
		} // 0x0000000189F5FBA8-0x0000000189F5FC68
		internal VisualTreeAsset ResolveTemplate(string templateName) => default; // 0x0000000189F5F938-0x0000000189F5FBA8
		internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx) => default; // 0x0000000189F5E904-0x0000000189F5F03C
		private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element) {} // 0x0000000189F5D4C8-0x0000000189F5D534
		private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element) {} // 0x0000000189F5D534-0x0000000189F5D6D4
	}

	public struct CreationContext : IEquatable<CreationContext> // TypeDefIndex: 43887
	{
		// Fields
		public static readonly CreationContext Default; // 0x00
	
		// Properties
		public VisualElement target { [IsReadOnly] get; private set; } // 0x00000001820C61B0-0x00000001820C61C0 0x00000001842715A0-0x00000001842715A8
		public VisualTreeAsset visualTreeAsset { [IsReadOnly] get; private set; } // 0x0000000183D50DE0-0x0000000183D50DF0 0x000000018558FF08-0x000000018558FF18
		public Dictionary<string, VisualElement> slotInsertionPoints { [IsReadOnly] get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		internal List<TemplateAsset.AttributeOverride> attributeOverrides { [IsReadOnly] get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target) : this() {
	
		} // 0x0000000189F45A7C-0x0000000189F45AF8
		internal CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target) : this() {
	
		} // 0x0000000189F459E8-0x0000000189F45A7C
		static CreationContext() {
			Default = default;
		} // 0x0000000189F459A8-0x0000000189F459E8
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189F457E8-0x0000000189F45874
		public bool Equals(CreationContext other) => default; // 0x0000000189F45674-0x0000000189F457E8
		public override int GetHashCode() => default; // 0x0000000189F45874-0x0000000189F459A8
	}
}

namespace UnityEngine.UIElements.Experimental
{
	public static class Easing // TypeDefIndex: 44023
	{
		// Methods
		public static float Linear(float t) => default; // 0x0000000183D4B9D0-0x0000000183D4B9E0
		public static float InSine(float t) => default; // 0x0000000183D88D60-0x0000000183D88D90
		public static float OutSine(float t) => default; // 0x0000000183D88DE0-0x0000000183D88DF0
		public static float InOutSine(float t) => default; // 0x0000000183D88D10-0x0000000183D88D40
		public static float InQuad(float t) => default; // 0x0000000183D88D50-0x0000000183D88D60
		public static float OutQuad(float t) => default; // 0x0000000183D88DC0-0x0000000183D88DE0
		public static float InOutQuad(float t) => default; // 0x0000000189ECA54C-0x0000000189ECA590
		public static float InCubic(float t) => default; // 0x0000000183D88D00-0x0000000183D88D10
		public static float OutCubic(float t) => default; // 0x0000000189ECA5C4-0x0000000189ECA5EC
		public static float InOutCubic(float t) => default; // 0x0000000189ECA47C-0x0000000189ECA48C
		public static float InPower(float t, int power) => default; // 0x0000000183D88D40-0x0000000183D88D50
		public static float OutPower(float t, int power) => default; // 0x0000000189ECA67C-0x0000000189ECA6C0
		public static float InOutPower(float t, int power) => default; // 0x0000000189ECA4D4-0x0000000189ECA54C
		public static float InBounce(float t) => default; // 0x0000000189ECA278-0x0000000189ECA2AC
		public static float OutBounce(float t) => default; // 0x00000001893BA8B0-0x00000001893BA948
		public static float InOutBounce(float t) => default; // 0x0000000189ECA3A4-0x0000000189ECA414
		public static float InElastic(float t) => default; // 0x0000000189ECA2AC-0x0000000189ECA334
		public static float OutElastic(float t) => default; // 0x0000000189ECA5EC-0x0000000189ECA67C
		public static float InOutElastic(float t) => default; // 0x0000000189ECA48C-0x0000000189ECA4D4
		public static float InBack(float t) => default; // 0x0000000183D71FD0-0x0000000183D71FF0
		public static float OutBack(float t) => default; // 0x0000000189ECA590-0x0000000189ECA5C4
		public static float InOutBack(float t) => default; // 0x0000000189ECA334-0x0000000189ECA3A4
		public static float InCirc(float t) => default; // 0x0000000183D88CA0-0x0000000183D88D00
		public static float OutCirc(float t) => default; // 0x0000000183D88D90-0x0000000183D88DC0
		public static float InOutCirc(float t) => default; // 0x0000000189ECA414-0x0000000189ECA47C
	}

	public struct StyleValues // TypeDefIndex: 44024
	{
		// Fields
		internal StyleValueCollection m_StyleValues; // 0x00
	
		// Properties
		public float top { set {} } // 0x0000000189ECBDE4-0x0000000189ECBDF4
		public float left { set {} } // 0x0000000189ECBD34-0x0000000189ECBD44
		public float width { set {} } // 0x0000000189ECBE18-0x0000000189ECC4BC
		public float height { set {} } // 0x0000000189ECBD24-0x0000000189ECBD34
		public float right { set {} } // 0x0000000189ECBDD4-0x0000000189ECBDE4
		public float bottom { set {} } // 0x0000000189ECBCE0-0x0000000189ECBCF0
		public UnityEngine.Color color { set {} } // 0x0000000189ECBCF0-0x0000000189ECBD14
		public UnityEngine.Color backgroundColor { set {} } // 0x0000000189ECBC18-0x0000000189ECBC3C
		public UnityEngine.Color unityBackgroundImageTintColor { set {} } // 0x0000000189ECBDF4-0x0000000189ECBE18
		public UnityEngine.Color borderColor { set {} } // 0x0000000189ECBC6C-0x0000000189ECBC90
		public float marginLeft { set {} } // 0x0000000189ECBD54-0x0000000189ECBD64
		public float marginTop { set {} } // 0x0000000189ECBD74-0x0000000189ECBD84
		public float marginRight { set {} } // 0x0000000189ECBD64-0x0000000189ECBD74
		public float marginBottom { set {} } // 0x0000000189ECBD44-0x0000000189ECBD54
		public float paddingLeft { set {} } // 0x0000000189ECBDA4-0x0000000189ECBDB4
		public float paddingTop { get => default; set {} } // 0x0000000189ECBBDC-0x0000000189ECBC18 0x0000000189ECBDC4-0x0000000189ECBDD4
		public float paddingRight { set {} } // 0x0000000189ECBDB4-0x0000000189ECBDC4
		public float paddingBottom { set {} } // 0x0000000189ECBD94-0x0000000189ECBDA4
		public float borderLeftWidth { set {} } // 0x0000000189ECBC90-0x0000000189ECBCA0
		public float borderRightWidth { set {} } // 0x0000000189ECBCA0-0x0000000189ECBCB0
		public float borderTopWidth { set {} } // 0x0000000189ECBCD0-0x0000000189ECBCE0
		public float borderBottomWidth { set {} } // 0x0000000189ECBC5C-0x0000000189ECBC6C
		public float borderTopLeftRadius { set {} } // 0x0000000189ECBCB0-0x0000000189ECBCC0
		public float borderTopRightRadius { set {} } // 0x0000000189ECBCC0-0x0000000189ECBCD0
		public float borderBottomLeftRadius { set {} } // 0x0000000189ECBC3C-0x0000000189ECBC4C
		public float borderBottomRightRadius { set {} } // 0x0000000189ECBC4C-0x0000000189ECBC5C
		public float opacity { set {} } // 0x0000000189ECBD84-0x0000000189ECBD94
		public float flexGrow { set {} } // 0x0000000189ECBD14-0x0000000189ECBD24
		public float flexShrink { set {} } // 0x0000000189ECBD14-0x0000000189ECBD24
	
		// Methods
		internal void SetValue(StylePropertyId id, float value) {} // 0x0000000189ECBAB4-0x0000000189ECBB10
		internal void SetValue(StylePropertyId id, UnityEngine.Color value) {} // 0x0000000189ECBB10-0x0000000189ECBB70
		internal StyleValueCollection Values() => default; // 0x0000000189ECBB70-0x0000000189ECBBDC
	}

	public interface ITransitionAnimations // TypeDefIndex: 44025
	{
		// Methods
		ValueAnimation<StyleValues> Start(StyleValues to, int durationMs);
	}

	internal static class Lerp // TypeDefIndex: 44026
	{
		// Methods
		public static float Interpolate(float start, float end, float ratio) => default; // 0x0000000183D86320-0x0000000183D86340
		public static UnityEngine.Color Interpolate(UnityEngine.Color start, UnityEngine.Color end, float ratio) => default; // 0x0000000189ECA6C0-0x0000000189ECA704
		internal static StyleValues Interpolate(StyleValues start, StyleValues end, float ratio) => default; // 0x0000000189ECA704-0x0000000189ECAD40
	}

	internal interface IValueAnimationUpdate // TypeDefIndex: 44027
	{
		// Methods
		void Tick(long currentTimeMs);
	}

	public sealed class ValueAnimation<T> : IValueAnimationUpdate // TypeDefIndex: 44028
	{
		// Fields
		private long m_StartTimeMs;
		private int m_DurationMs;
		private static UnityEngine.UIElements.ObjectPool<ValueAnimation<T>> sObjectPool;
		private T _from;
		private bool fromValueSet;
	
		// Properties
		public int durationMs { get => default; set {} }
		public Func<float, float> easingCurve { get; set; }
		public bool isRunning { get; private set; }
		public Action onAnimationCompleted { get; set; }
		public bool autoRecycle { get; set; }
		private bool recycled { get; set; }
		private VisualElement owner { get; set; }
		public Action<VisualElement, T> valueUpdated { get; set; }
		public Func<VisualElement, T> initialValue { get; set; }
		public Func<T, T, float, T> interpolator { get; set; }
		public T from { get => default; set {} }
		public T to { get; set; }
	
		// Constructors
		public ValueAnimation() {}
		static ValueAnimation() {}
	
		// Methods
		public void Start() {}
		public void Stop() {}
		public void Recycle() {}
		void IValueAnimationUpdate.Tick(long currentTimeMs) {}
		private void SetDefaultValues() {}
		private void Unregister() {}
		private void Register() {}
		internal void SetOwner(VisualElement e) {}
		private void CheckNotRecycled() {}
		public static ValueAnimation<T> Create(VisualElement e, Func<T, T, float, T> interpolator) => default;
		public ValueAnimation<T> KeepAlive() => default;
	}
}

namespace UnityEngine.UIElements.Internal
{
	internal class MultiColumnHeaderColumnMovePreview : VisualElement // TypeDefIndex: 43968
	{
		// Fields
		public static readonly string ussClassName; // 0x00
	
		// Constructors
		public MultiColumnHeaderColumnMovePreview() {} // 0x0000000189EAFD60-0x0000000189EAFDE0
		static MultiColumnHeaderColumnMovePreview() {} // 0x0000000189EAFCD4-0x0000000189EAFD60
	}

	internal class MultiColumnHeaderColumnMoveLocationPreview : VisualElement // TypeDefIndex: 43969
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string visualUssClassName; // 0x08
	
		// Constructors
		public MultiColumnHeaderColumnMoveLocationPreview() {} // 0x0000000189EAFBF4-0x0000000189EAFCD4
		static MultiColumnHeaderColumnMoveLocationPreview() {} // 0x0000000189EAFB10-0x0000000189EAFBF4
	}

	internal class ColumnMover : PointerManipulator // TypeDefIndex: 43970
	{
		// Fields
		private float m_StartPos; // 0x38
		private float m_LastPos; // 0x3C
		private bool m_Active; // 0x40
		private bool m_Moving; // 0x41
		private bool m_Cancelled; // 0x42
		private MultiColumnCollectionHeader m_Header; // 0x48
		private VisualElement m_PreviewElement; // 0x50
		private MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement; // 0x58
		private Column m_ColumnToMove; // 0x60
		private float m_ColumnToMovePos; // 0x68
		private float m_ColumnToMoveWidth; // 0x6C
		private Column m_DestinationColumn; // 0x70
		private bool m_MoveBeforeDestination; // 0x78
	
		// Properties
		public ColumnLayout columnLayout { get; set; } // 0x0000000183D4EAE0-0x0000000183D4EAF0 0x00000001851DFC94-0x00000001851DFCA4
		public bool active { get => default; set {} } // 0x0000000183D4EE90-0x0000000183D4EEA0 0x0000000189EAA3AC-0x0000000189EAA3D8
		public bool moving { get => default; set {} } // 0x0000000183D4F7B0-0x0000000183D4F7C0 0x0000000189EAA3D8-0x0000000189EAA404
	
		// Events
		public event Action<ColumnMover> activeChanged;
		public event Action<ColumnMover> movingChanged;
	
		// Constructors
		public ColumnMover() {} // 0x0000000189EAA0F8-0x0000000189EAA16C
	
		// Methods
		protected override void RegisterCallbacksOnTarget() {} // 0x0000000189EA941C-0x0000000189EA98CC
		protected override void UnregisterCallbacksFromTarget() {} // 0x0000000189EA98CC-0x0000000189EA9D7C
		protected void OnMouseDown(MouseDownEvent evt) {} // 0x0000000189EA8A4C-0x0000000189EA8B08
		protected void OnMouseMove(MouseMoveEvent evt) {} // 0x0000000189EA8B08-0x0000000189EA8B78
		protected void OnMouseUp(MouseUpEvent evt) {} // 0x0000000189EA8B78-0x0000000189EA8C3C
		private void OnMouseCaptureOut(MouseCaptureOutEvent evt) {} // 0x0000000189EA89E0-0x0000000189EA8A4C
		private void OnPointerDown(PointerDownEvent evt) {} // 0x0000000189EA8D2C-0x0000000189EA8E34
		private void OnPointerMove(PointerMoveEvent evt) {} // 0x0000000189EA8E34-0x0000000189EA8F20
		private void OnPointerUp(PointerUpEvent evt) {} // 0x0000000189EA8F20-0x0000000189EA9028
		private void OnPointerCancel(PointerCancelEvent evt) {} // 0x0000000189EA8C3C-0x0000000189EA8CBC
		private void OnPointerCaptureOut(PointerCaptureOutEvent evt) {} // 0x0000000189EA8CBC-0x0000000189EA8D2C
		private static bool IsNotMouseEvent(int pointerId) => default; // 0x0000000189EA8934-0x0000000189EA8980
		protected void ProcessCancelEvent(EventBase evt, int pointerId) {} // 0x0000000189EA9028-0x0000000189EA90D8
		private void OnKeyDown(KeyDownEvent e) {} // 0x0000000189EA8980-0x0000000189EA89E0
		private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) {} // 0x0000000189EA90D8-0x0000000189EA9270
		private void ProcessMoveEvent(EventBase e, Vector2 localPosition) {} // 0x0000000189EA9270-0x0000000189EA934C
		private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) {} // 0x0000000189EA934C-0x0000000189EA941C
		private void BeginDragMove(float pos) {} // 0x0000000189EA8400-0x0000000189EA87F8
		internal void DragMove(float pos) {} // 0x0000000189EA87F8-0x0000000189EA8804
		private void UpdatePreviewPosition() {} // 0x0000000189EA9F8C-0x0000000189EAA0F8
		private void UpdateMoveLocation() {} // 0x0000000189EA9D7C-0x0000000189EA9F8C
		private void EndDragMove(bool cancelled) {} // 0x0000000189EA8804-0x0000000189EA8934
	}

	internal class MultiColumnHeaderColumnResizePreview : VisualElement // TypeDefIndex: 43971
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string visualUssClassName; // 0x08
	
		// Constructors
		public MultiColumnHeaderColumnResizePreview() {} // 0x0000000189EB0098-0x0000000189EB0178
		static MultiColumnHeaderColumnResizePreview() {} // 0x0000000189EAFFB4-0x0000000189EB0098
	}

	internal class ColumnResizer : PointerManipulator // TypeDefIndex: 43972
	{
		// Fields
		private Vector2 m_Start; // 0x38
		protected bool m_Active; // 0x40
		private bool m_Resizing; // 0x41
		private MultiColumnCollectionHeader m_Header; // 0x48
		private Column m_Column; // 0x50
		private VisualElement m_PreviewElement; // 0x58
	
		// Properties
		public ColumnLayout columnLayout { get; set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public bool preview { get; set; } // 0x0000000183D4F3F0-0x0000000183D4F400 0x0000000183D4F440-0x0000000183D4F450
	
		// Constructors
		public ColumnResizer() {} // Dummy constructor
		public ColumnResizer(Column column) {} // 0x0000000189EAAE50-0x0000000189EAAEE4
	
		// Methods
		protected override void RegisterCallbacksOnTarget() {} // 0x0000000189EAA9B8-0x0000000189EAABB4
		protected override void UnregisterCallbacksFromTarget() {} // 0x0000000189EAABB4-0x0000000189EAADB0
		private void OnKeyDown(KeyDownEvent e) {} // 0x0000000189EAA4EC-0x0000000189EAA554
		private void OnPointerDown(PointerDownEvent e) {} // 0x0000000189EAA554-0x0000000189EAA7AC
		private void OnPointerMove(PointerMoveEvent e) {} // 0x0000000189EAA7AC-0x0000000189EAA898
		private void OnPointerUp(PointerUpEvent e) {} // 0x0000000189EAA898-0x0000000189EAA9B8
		private void BeginDragResize(float pos) {} // 0x0000000189EAA404-0x0000000189EAA448
		private void DragResize(float pos) {} // 0x0000000189EAA448-0x0000000189EAA488
		private void UpdatePreviewPosition() {} // 0x0000000189EAADB0-0x0000000189EAAE50
		private void EndDragResize(float pos, bool cancelled) {} // 0x0000000189EAA488-0x0000000189EAA4EC
	}

	internal class MultiColumnCollectionHeader : VisualElement, IDisposable // TypeDefIndex: 43979
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string columnContainerUssClassName; // 0x08
		public static readonly string handleContainerUssClassName; // 0x10
		public static readonly string reorderableUssClassName; // 0x18
		private bool m_SortingEnabled; // 0x3C0
		private List<SortColumnDescription> m_SortedColumns; // 0x3C8
		private SortColumnDescriptions m_SortDescriptions; // 0x3D0
		private List<SortedColumnState> m_OldSortedColumnStates; // 0x3D8
		private bool m_SortingUpdatesTemporarilyDisabled; // 0x3E0
		private ViewState m_ViewState; // 0x3E8
		private bool m_ApplyingViewState; // 0x3F0
		private bool m_DoLayoutScheduled; // 0x3F1
	
		// Properties
		internal bool isApplyingViewState { get => default; } // 0x0000000183D88BD0-0x0000000183D88BE0 
		public Dictionary<Column, ColumnData> columnDataMap { get; } // 0x0000000183D57080-0x0000000183D57090 
		public ColumnLayout columnLayout { get; } // 0x0000000183D57290-0x0000000183D572A0 
		public VisualElement columnContainer { get; } // 0x0000000183D57280-0x0000000183D57290 
		public VisualElement resizeHandleContainer { get; } // 0x0000000183D570D0-0x0000000183D570E0 
		public IEnumerable<SortColumnDescription> sortedColumns { get => default; } // 0x0000000183D56FF0-0x0000000183D57000 
		public SortColumnDescriptions sortDescriptions { get => default; protected internal set {} } // 0x0000000183D55EC0-0x0000000183D55ED0 0x0000000189EAF78C-0x0000000189EAF840
		public Columns columns { get; } // 0x0000000183D57150-0x0000000183D57160 
		public bool sortingEnabled { get => default; set {} } // 0x0000000183D88BE0-0x0000000183D88BF0 0x0000000189EAF840-0x0000000189EAF874
	
		// Events
		public event Action<int, float> columnResized;
		public event Action columnSortingChanged;
		public event Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent;
		internal event Action viewDataRestored;
	
		// Nested types
		[Serializable]
		private class ViewState // TypeDefIndex: 43974
		{
			// Fields
			[SerializeField]
			private bool m_HasPersistedData; // 0x10
			[SerializeField]
			private List<SortColumnDescription> m_SortDescriptions; // 0x18
			[SerializeField]
			private List<ColumnState> m_OrderedColumnStates; // 0x20
	
			// Nested types
			[Serializable]
			private struct ColumnState // TypeDefIndex: 43973
			{
				// Fields
				public int index; // 0x00
				public string name; // 0x08
				public float actualWidth; // 0x10
				public Length width; // 0x14
				public bool visible; // 0x1C
			}
	
			// Constructors
			public ViewState() {} // 0x0000000189EBB518-0x0000000189EBB5D8
	
			// Methods
			internal void Save(MultiColumnCollectionHeader header) {} // 0x0000000189EBB0EC-0x0000000189EBB518
			internal void Apply(MultiColumnCollectionHeader header) {} // 0x0000000189EBAD30-0x0000000189EBB0EC
		}
	
		internal class ColumnData // TypeDefIndex: 43975
		{
			// Properties
			public MultiColumnHeaderColumn control { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
			public MultiColumnHeaderColumnResizeHandle resizeHandle { get; set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
			// Constructors
			public ColumnData() {} // 0x000000018350B670-0x000000018350B680
		}
	
		private struct SortedColumnState // TypeDefIndex: 43976
		{
			// Fields
			public SortColumnDescription columnDesc; // 0x00
			public SortDirection direction; // 0x08
	
			// Constructors
			public SortedColumnState(SortColumnDescription desc, SortDirection dir) {
				columnDesc = default;
				direction = default;
			} // 0x0000000184274600-0x000000018427461C
		}
	
		// Constructors
		public MultiColumnCollectionHeader() {} // Dummy constructor
		public MultiColumnCollectionHeader(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) {} // 0x0000000189EAE584-0x0000000189EAF2EC
		static MultiColumnCollectionHeader() {} // 0x0000000189EAE428-0x0000000189EAE584
	
		// Methods
		private void ScheduleDoLayout() {} // 0x0000000189EAD2C0-0x0000000189EAD34C
		private void ResizeToFit() {} // 0x0000000189EAD244-0x0000000189EAD284
		private void UpdateSortedColumns() {} // 0x0000000189EADACC-0x0000000189EAE094
		private void UpdateColumnControls() {} // 0x0000000189EAD3CC-0x0000000189EAD8A8
		private void OnColumnAdded(Column column, int index) {} // 0x0000000189EABBA0-0x0000000189EABBA8
		private void OnColumnAdded(Column column) {} // 0x0000000189EABBA8-0x0000000189EABEEC
		private void OnColumnRemoved(Column column) {} // 0x0000000189EAC2A8-0x0000000189EAC50C
		private void OnColumnChanged(Column column, ColumnDataType type) {} // 0x0000000189EABEEC-0x0000000189EABF50
		private void OnColumnReordered(Column column, int from, int to) {} // 0x0000000189EAC50C-0x0000000189EAC6A8
		private void OnColumnResized(Column column) {} // 0x0000000189EAC6A8-0x0000000189EAC6B0
		private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt) {} // 0x0000000189EAC6B0-0x0000000189EACF70
		private void OnMoveManipulatorActivated(ColumnMover mover) {} // 0x0000000189EACFE4-0x0000000189EAD060
		private void OnGeometryChanged(GeometryChangedEvent e) {} // 0x0000000189EACF70-0x0000000189EACFE4
		private void DoLayout() {} // 0x0000000189EABB4C-0x0000000189EABBA0
		private void OnColumnControlGeometryChanged(GeometryChangedEvent evt) {} // 0x0000000189EAC0F0-0x0000000189EAC2A8
		private void OnColumnClicked(EventBase evt) {} // 0x0000000189EABF50-0x0000000189EAC0F0
		private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers) {} // 0x0000000189EAD8A8-0x0000000189EADACC
		public void ScrollHorizontally(float horizontalOffset) {} // 0x0000000189EAD34C-0x0000000189EAD3C4
		private void RaiseColumnResized(int columnIndex) {} // 0x0000000189EAD1B8-0x0000000189EAD214
		private void RaiseColumnSortingChanged() {} // 0x0000000189EAD214-0x0000000189EAD244
		private void ApplyColumnSorting() {} // 0x0000000189EAAFAC-0x0000000189EAB4F4
		private void UpdateSortingStatus() {} // 0x0000000189EAE094-0x0000000189EAE428
		internal override void OnViewDataReady() {} // 0x0000000189EAD060-0x0000000189EAD1B8
		private void SaveViewState() {} // 0x0000000189EAD284-0x0000000189EAD2C0
		public void Dispose() {} // 0x0000000189EAB4F4-0x0000000189EABB4C
	}

	internal class MultiColumnHeaderColumnSortIndicator : VisualElement // TypeDefIndex: 43980
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string arrowUssClassName; // 0x08
		public static readonly string indexLabelUssClassName; // 0x10
		private UnityEngine.UIElements.Label m_IndexLabel; // 0x3C0
	
		// Properties
		public string sortOrderLabel { set {} } // 0x0000000189EB0414-0x0000000189EB0438
	
		// Constructors
		public MultiColumnHeaderColumnSortIndicator() {} // 0x0000000189EB02B0-0x0000000189EB0414
		static MultiColumnHeaderColumnSortIndicator() {} // 0x0000000189EB0178-0x0000000189EB02B0
	}

	internal class MultiColumnHeaderColumnIcon : Image // TypeDefIndex: 43981
	{
		// Fields
		public static readonly string ussClassName; // 0x00
	
		// Properties
		public bool isImageInline { get; set; } // 0x0000000183D88BF0-0x0000000183D88C00 0x0000000183D88C00-0x0000000183D88C10
	
		// Constructors
		public MultiColumnHeaderColumnIcon() {} // 0x0000000189EAFA28-0x0000000189EAFB10
		static MultiColumnHeaderColumnIcon() {} // 0x0000000189EAF99C-0x0000000189EAFA28
	
		// Methods
		public void UpdateClassList() {} // 0x0000000189EAF87C-0x0000000189EAF99C
	}

	internal class MultiColumnHeaderColumn : VisualElement // TypeDefIndex: 43982
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string sortableUssClassName; // 0x08
		public static readonly string sortedAscendingUssClassName; // 0x10
		public static readonly string sortedDescendingUssClassName; // 0x18
		public static readonly string movingUssClassName; // 0x20
		public static readonly string contentContainerUssClassName; // 0x28
		public static readonly string contentUssClassName; // 0x30
		public static readonly string defaultContentUssClassName; // 0x38
		public static readonly string hasIconUssClassName; // 0x40
		public static readonly string hasTitleUssClassName; // 0x48
		public static readonly string titleUssClassName; // 0x50
		public static readonly string iconElementName; // 0x58
		public static readonly string titleElementName; // 0x60
		private static readonly string s_BoundVEPropertyName; // 0x68
		private static readonly string s_BindingCallbackVEPropertyName; // 0x70
		private static readonly string s_UnbindingCallbackVEPropertyName; // 0x78
		private static readonly string s_DestroyCallbackVEPropertyName; // 0x80
		private VisualElement m_ContentContainer; // 0x3C0
		private VisualElement m_Content; // 0x3C8
		private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer; // 0x3D0
		private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate; // 0x3D8
	
		// Properties
		public Clickable clickable { get; private set; } // 0x0000000183D55EE0-0x0000000183D55EF0 0x00000001858B4258-0x00000001858B426C
		public ColumnMover mover { get; private set; } // 0x0000000183D572E0-0x0000000183D572F0 0x00000001858B3F9C-0x00000001858B3FB0
		public string sortOrderLabel { set {} } // 0x0000000189EB1E30-0x0000000189EB1E54
		public Column column { get; set; } // 0x0000000183D57310-0x0000000183D57320 0x00000001858B3FEC-0x00000001858B4000
		public VisualElement content { get => default; set {} } // 0x0000000183D56FF0-0x0000000183D57000 0x0000000189EB1BE8-0x0000000189EB1D88
		private bool isContentBound { get => default; set {} } // 0x0000000189EB1B44-0x0000000189EB1BE8 0x0000000189EB1D88-0x0000000189EB1E30
	
		// Constructors
		public MultiColumnHeaderColumn() {} // Dummy constructor
		public MultiColumnHeaderColumn(Column column) {} // 0x0000000189EB166C-0x0000000189EB1B44
		static MultiColumnHeaderColumn() {} // 0x0000000189EB111C-0x0000000189EB166C
	
		// Methods
		private void InitManipulators() {} // 0x0000000189EB0A18-0x0000000189EB0C00
		private void UpdateDataFromColumn() {} // 0x0000000189EB0E28-0x0000000189EB0E68
		private void BindHeaderContent() {} // 0x0000000189EB0438-0x0000000189EB0510
		private void UnbindHeaderContent() {} // 0x0000000189EB0D50-0x0000000189EB0E28
		private void DestroyHeaderContent() {} // 0x0000000189EB0954-0x0000000189EB0A18
		private VisualElement CreateDefaultHeaderContent() => default; // 0x0000000189EB0510-0x0000000189EB0694
		private void DefaultBindHeaderContent(VisualElement ve) {} // 0x0000000189EB0694-0x0000000189EB0954
		private void UpdateHeaderTemplate() {} // 0x0000000189EB0EEC-0x0000000189EB111C
		private void UpdateGeometryFromColumn() {} // 0x0000000189EB0E68-0x0000000189EB0EEC
	}

	internal class MultiColumnHeaderColumnResizeHandle : VisualElement // TypeDefIndex: 43983
	{
		// Fields
		public static readonly string ussClassName; // 0x00
		public static readonly string dragAreaUssClassName; // 0x08
	
		// Properties
		public VisualElement dragArea { get; } // 0x0000000183D57010-0x0000000183D57020 
	
		// Constructors
		public MultiColumnHeaderColumnResizeHandle() {} // 0x0000000189EAFEC4-0x0000000189EAFFB4
		static MultiColumnHeaderColumnResizeHandle() {} // 0x0000000189EAFDE0-0x0000000189EAFEC4
	}
}

namespace UnityEngine.UIElements.StyleSheets
{
	internal abstract class HierarchyTraversal // TypeDefIndex: 43984
	{
		// Constructors
		protected HierarchyTraversal() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public virtual void Traverse(VisualElement element) {} // 0x0000000189EAAF94-0x0000000189EAAFAC
		public abstract void TraverseRecursive(VisualElement element, int depth);
		protected void Recurse(VisualElement element, int depth) {} // 0x0000000189EAAEE4-0x0000000189EAAF94
	}

	internal static class StylePropertyUtil // TypeDefIndex: 43985
	{
		// Fields
		private static readonly HashSet<StylePropertyId> s_AnimatablePropertiesHash; // 0x00
		internal static readonly Dictionary<string, StylePropertyId> s_NameToId; // 0x08
		internal static readonly Dictionary<StylePropertyId, string> s_IdToName; // 0x10
		internal static readonly StylePropertyId[] s_AnimatableProperties; // 0x18
	
		// Constructors
		static StylePropertyUtil() {} // 0x0000000189EB2D60-0x0000000189EB4B48
	
		// Methods
		public static bool IsAnimatable(StylePropertyId id) => default; // 0x0000000189EB1E54-0x0000000189EB1EC0
		public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue) {
			intValue = default;
			return default;
		} // 0x0000000189EB1FA0-0x0000000189EB2D60
		public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id) => default; // 0x0000000189EB1EC0-0x0000000189EB1FA0
	}

	internal static class InitialStyle // TypeDefIndex: 43986
	{
		// Fields
		private static ComputedStyle s_InitialStyle; // 0x00
	
		// Properties
		public static Align alignContent { get; } // 0x0000000189EBD6F8-0x0000000189EBD758 
		public static Align alignItems { get; } // 0x0000000189EBD758-0x0000000189EBD7B8 
		public static Align alignSelf { get; } // 0x0000000189EBD7B8-0x0000000189EBD818 
		public static UnityEngine.Color backgroundColor { get; } // 0x0000000189EBD818-0x0000000189EBD884 
		public static Background backgroundImage { get; } // 0x0000000189EBD884-0x0000000189EBD8F8 
		public static UnityEngine.Color borderBottomColor { get; } // 0x0000000189EBD8F8-0x0000000189EBD964 
		public static Length borderBottomLeftRadius { get; } // 0x0000000189EBD964-0x0000000189EBD9C4 
		public static Length borderBottomRightRadius { get; } // 0x0000000189EBD9C4-0x0000000189EBDA24 
		public static float borderBottomWidth { get; } // 0x0000000189EBDA24-0x0000000189EBDA84 
		public static UnityEngine.Color borderLeftColor { get; } // 0x0000000189EBDA84-0x0000000189EBDAF0 
		public static float borderLeftWidth { get; } // 0x0000000189EBDAF0-0x0000000189EBDB50 
		public static UnityEngine.Color borderRightColor { get; } // 0x0000000189EBDB50-0x0000000189EBDBBC 
		public static float borderRightWidth { get; } // 0x0000000189EBDBBC-0x0000000189EBDC1C 
		public static UnityEngine.Color borderTopColor { get; } // 0x0000000189EBDC1C-0x0000000189EBDC88 
		public static Length borderTopLeftRadius { get; } // 0x0000000189EBDC88-0x0000000189EBDCEC 
		public static Length borderTopRightRadius { get; } // 0x0000000189EBDCEC-0x0000000189EBDD50 
		public static float borderTopWidth { get; } // 0x0000000189EBDD50-0x0000000189EBDDB0 
		public static Length bottom { get; } // 0x0000000189EBDDB0-0x0000000189EBDE10 
		public static UnityEngine.Color color { get; } // 0x0000000189EBDE10-0x0000000189EBDE78 
		public static UnityEngine.UIElements.Cursor cursor { get; } // 0x0000000189EBDE78-0x0000000189EBDEEC 
		public static DisplayStyle display { get; } // 0x0000000189EBDEEC-0x0000000189EBDF4C 
		public static Length flexBasis { get; } // 0x0000000189EBDF4C-0x0000000189EBDFAC 
		public static FlexDirection flexDirection { get; } // 0x0000000189EBDFAC-0x0000000189EBE00C 
		public static float flexGrow { get; } // 0x0000000189EBE00C-0x0000000189EBE06C 
		public static float flexShrink { get; } // 0x0000000189EBE06C-0x0000000189EBE0CC 
		public static Wrap flexWrap { get; } // 0x0000000189EBE0CC-0x0000000189EBE12C 
		public static Length fontSize { get; } // 0x0000000189EBE12C-0x0000000189EBE188 
		public static Length height { get; } // 0x0000000189EBE188-0x0000000189EBE1E8 
		public static Justify justifyContent { get; } // 0x0000000189EBE1E8-0x0000000189EBE248 
		public static Length left { get; } // 0x0000000189EBE248-0x0000000189EBE2A8 
		public static Length letterSpacing { get; } // 0x0000000189EBE2A8-0x0000000189EBE304 
		public static Length marginBottom { get; } // 0x0000000189EBE304-0x0000000189EBE364 
		public static Length marginLeft { get; } // 0x0000000189EBE364-0x0000000189EBE3C4 
		public static Length marginRight { get; } // 0x0000000189EBE3C4-0x0000000189EBE424 
		public static Length marginTop { get; } // 0x0000000189EBE424-0x0000000189EBE484 
		public static Length maxHeight { get; } // 0x0000000189EBE484-0x0000000189EBE4E4 
		public static Length maxWidth { get; } // 0x0000000189EBE4E4-0x0000000189EBE544 
		public static Length minHeight { get; } // 0x0000000189EBE544-0x0000000189EBE5A8 
		public static Length minWidth { get; } // 0x0000000189EBE5A8-0x0000000189EBE60C 
		public static float opacity { get; } // 0x0000000189EBE60C-0x0000000189EBE670 
		public static OverflowInternal overflow { get; } // 0x0000000189EBE670-0x0000000189EBE6D4 
		public static Length paddingBottom { get; } // 0x0000000189EBE6D4-0x0000000189EBE738 
		public static Length paddingLeft { get; } // 0x0000000189EBE738-0x0000000189EBE79C 
		public static Length paddingRight { get; } // 0x0000000189EBE79C-0x0000000189EBE800 
		public static Length paddingTop { get; } // 0x0000000189EBE800-0x0000000189EBE864 
		public static Position position { get; } // 0x0000000189EBE864-0x0000000189EBE8C8 
		public static Length right { get; } // 0x0000000189EBE8C8-0x0000000189EBE92C 
		public static Rotate rotate { get; } // 0x0000000189EBE92C-0x0000000189EBE9A0 
		public static Scale scale { get; } // 0x0000000189EBE9A0-0x0000000189EBEA0C 
		public static TextOverflow textOverflow { get; } // 0x0000000189EBEA0C-0x0000000189EBEA6C 
		public static TextShadow textShadow { get; } // 0x0000000189EBEA6C-0x0000000189EBEAE4 
		public static Length top { get; } // 0x0000000189EBEAE4-0x0000000189EBEB48 
		public static TransformOrigin transformOrigin { get; } // 0x0000000189EBEB48-0x0000000189EBEBBC 
		public static List<TimeValue> transitionDelay { get; } // 0x0000000189EBEBBC-0x0000000189EBEC1C 
		public static List<TimeValue> transitionDuration { get; } // 0x0000000189EBEC1C-0x0000000189EBEC7C 
		public static List<StylePropertyName> transitionProperty { get; } // 0x0000000189EBEC7C-0x0000000189EBECDC 
		public static List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction { get; } // 0x0000000189EBECDC-0x0000000189EBED3C 
		public static Translate translate { get; } // 0x0000000189EBED3C-0x0000000189EBEDB4 
		public static UnityEngine.Color unityBackgroundImageTintColor { get; } // 0x0000000189EBEDB4-0x0000000189EBEE20 
		public static UnityEngine.ScaleMode unityBackgroundScaleMode { get; } // 0x0000000189EBEE20-0x0000000189EBEE80 
		public static Font unityFont { get; } // 0x0000000189EBEF44-0x0000000189EBEFA0 
		public static FontDefinition unityFontDefinition { get; } // 0x0000000189EBEE80-0x0000000189EBEEE8 
		public static FontStyle unityFontStyleAndWeight { get; } // 0x0000000189EBEEE8-0x0000000189EBEF44 
		public static OverflowClipBox unityOverflowClipBox { get; } // 0x0000000189EBEFA0-0x0000000189EBF000 
		public static Length unityParagraphSpacing { get; } // 0x0000000189EBF000-0x0000000189EBF05C 
		public static int unitySliceBottom { get; } // 0x0000000189EBF05C-0x0000000189EBF0BC 
		public static int unitySliceLeft { get; } // 0x0000000189EBF0BC-0x0000000189EBF11C 
		public static int unitySliceRight { get; } // 0x0000000189EBF11C-0x0000000189EBF17C 
		public static int unitySliceTop { get; } // 0x0000000189EBF17C-0x0000000189EBF1DC 
		public static TextAnchor unityTextAlign { get; } // 0x0000000189EBF1DC-0x0000000189EBF238 
		public static UnityEngine.Color unityTextOutlineColor { get; } // 0x0000000189EBF238-0x0000000189EBF2A0 
		public static float unityTextOutlineWidth { get; } // 0x0000000189EBF2A0-0x0000000189EBF2FC 
		public static TextOverflowPosition unityTextOverflowPosition { get; } // 0x0000000189EBF2FC-0x0000000189EBF35C 
		public static Visibility visibility { get; } // 0x0000000189EBF35C-0x0000000189EBF3B8 
		public static WhiteSpace whiteSpace { get; } // 0x0000000189EBF3B8-0x0000000189EBF418 
		public static Length width { get; } // 0x0000000189EBF418-0x0000000189EBF47C 
		public static Length wordSpacing { get; } // 0x0000000189EBF47C-0x0000000189EBF4DC 
	
		// Constructors
		static InitialStyle() {} // 0x0000000189EBC764-0x0000000189EBD6F8
	
		// Methods
		public static ref ComputedStyle Get() => ref _refReturnTypeForGet; // 0x0000000189EBC718-0x0000000189EBC764
		private ref ComputedStyle _refReturnTypeForGet; // Dummy field
		public static ComputedStyle Acquire() => default; // 0x0000000189EBC67C-0x0000000189EBC718
	}

	internal static class ShorthandApplicator // TypeDefIndex: 43987
	{
		// Fields
		private static List<TimeValue> s_TransitionDelayList; // 0x00
		private static List<TimeValue> s_TransitionDurationList; // 0x08
		private static List<StylePropertyName> s_TransitionPropertyList; // 0x10
		private static List<UnityEngine.UIElements.EasingFunction> s_TransitionTimingFunctionList; // 0x18
	
		// Constructors
		static ShorthandApplicator() {} // 0x0000000189EC0B5C-0x0000000189EC0D08
	
		// Methods
		public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x0000000189EBF76C-0x0000000189EBF868
		public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x0000000189EBF868-0x0000000189EBF954
		public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x0000000189EBF954-0x0000000189EBFA3C
		public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x0000000189EBFA3C-0x0000000189EBFB08
		public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x0000000189EBFB08-0x0000000189EBFBEC
		public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x0000000189EBFBEC-0x0000000189EBFCDC
		public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x0000000189EBFCDC-0x0000000189EBFE14
		public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle) {} // 0x0000000189EBFE14-0x0000000189EBFEB8
		private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis) {
			grow = default;
			shrink = default;
			basis = default;
			return default;
		} // 0x0000000189EC0384-0x0000000189EC0538
		private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) {
			top = default;
			right = default;
			bottom = default;
			left = default;
		} // 0x0000000189EBFEB8-0x0000000189EBFFA8
		private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) {
			top = default;
			right = default;
			bottom = default;
			left = default;
		} // 0x0000000189EC0228-0x0000000189EC0384
		private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left) {
			top = default;
			right = default;
			bottom = default;
			left = default;
		} // 0x0000000189EC017C-0x0000000189EC0228
		private static void CompileBoxArea(StylePropertyReader reader, out UnityEngine.Color top, out UnityEngine.Color right, out UnityEngine.Color bottom, out UnityEngine.Color left) {
			top = default;
			right = default;
			bottom = default;
			left = default;
		} // 0x0000000189EBFFA8-0x0000000189EC017C
		private static void CompileTextOutline(StylePropertyReader reader, out UnityEngine.Color outlineColor, out float outlineWidth) {
			outlineColor = default;
			outlineWidth = default;
		} // 0x0000000189EC0538-0x0000000189EC05F0
		private static void CompileTransition(StylePropertyReader reader, out List<TimeValue> outDelay, out List<TimeValue> outDuration, out List<StylePropertyName> outProperty, out List<UnityEngine.UIElements.EasingFunction> outTimingFunction) {
			outDelay = default;
			outDuration = default;
			outProperty = default;
			outTimingFunction = default;
		} // 0x0000000189EC05F0-0x0000000189EC0B5C
	}

	internal static class StylePropertyCache // TypeDefIndex: 43988
	{
		// Fields
		internal static readonly Dictionary<string, string> s_PropertySyntaxCache; // 0x00
		internal static readonly Dictionary<string, string> s_NonTerminalValues; // 0x08
	
		// Constructors
		static StylePropertyCache() {} // 0x0000000189EC0E04-0x0000000189EC1FBC
	
		// Methods
		public static bool TryGetSyntax(string name, out string syntax) {
			syntax = default;
			return default;
		} // 0x0000000189EC0D88-0x0000000189EC0E04
		public static bool TryGetNonTerminalValue(string name, out string syntax) {
			syntax = default;
			return default;
		} // 0x0000000189EC0D08-0x0000000189EC0D88
	}

	internal enum StyleEnumType // TypeDefIndex: 43989
	{
		Align = 0,
		DisplayStyle = 1,
		EasingMode = 2,
		FlexDirection = 3,
		FontStyle = 4,
		Justify = 5,
		Overflow = 6,
		OverflowClipBox = 7,
		OverflowInternal = 8,
		Position = 9,
		ScaleMode = 10,
		TextAnchor = 11,
		TextOverflow = 12,
		TextOverflowPosition = 13,
		TransformOriginOffset = 14,
		Visibility = 15,
		WhiteSpace = 16,
		Wrap = 17
	}

	internal enum StylePropertyId // TypeDefIndex: 43990
	{
		Custom = -1,
		Unknown = 0,
		Color = 65536,
		FontSize = 65537,
		LetterSpacing = 65538,
		TextShadow = 65539,
		UnityFont = 65540,
		UnityFontDefinition = 65541,
		UnityFontStyleAndWeight = 65542,
		UnityParagraphSpacing = 65543,
		UnityTextAlign = 65544,
		UnityTextOutlineColor = 65545,
		UnityTextOutlineWidth = 65546,
		Visibility = 65547,
		WhiteSpace = 65548,
		WordSpacing = 65549,
		AlignContent = 131072,
		AlignItems = 131073,
		AlignSelf = 131074,
		BorderBottomWidth = 131075,
		BorderLeftWidth = 131076,
		BorderRightWidth = 131077,
		BorderTopWidth = 131078,
		Bottom = 131079,
		Display = 131080,
		FlexBasis = 131081,
		FlexDirection = 131082,
		FlexGrow = 131083,
		FlexShrink = 131084,
		FlexWrap = 131085,
		Height = 131086,
		JustifyContent = 131087,
		Left = 131088,
		MarginBottom = 131089,
		MarginLeft = 131090,
		MarginRight = 131091,
		MarginTop = 131092,
		MaxHeight = 131093,
		MaxWidth = 131094,
		MinHeight = 131095,
		MinWidth = 131096,
		PaddingBottom = 131097,
		PaddingLeft = 131098,
		PaddingRight = 131099,
		PaddingTop = 131100,
		Position = 131101,
		Right = 131102,
		Top = 131103,
		Width = 131104,
		Cursor = 196608,
		TextOverflow = 196609,
		UnityBackgroundImageTintColor = 196610,
		UnityBackgroundScaleMode = 196611,
		UnityOverflowClipBox = 196612,
		UnitySliceBottom = 196613,
		UnitySliceLeft = 196614,
		UnitySliceRight = 196615,
		UnitySliceTop = 196616,
		UnityTextOverflowPosition = 196617,
		All = 262144,
		BorderColor = 262145,
		BorderRadius = 262146,
		BorderWidth = 262147,
		Flex = 262148,
		Margin = 262149,
		Padding = 262150,
		Transition = 262151,
		UnityTextOutline = 262152,
		Rotate = 327680,
		Scale = 327681,
		TransformOrigin = 327682,
		Translate = 327683,
		TransitionDelay = 393216,
		TransitionDuration = 393217,
		TransitionProperty = 393218,
		TransitionTimingFunction = 393219,
		BackgroundColor = 458752,
		BackgroundImage = 458753,
		BorderBottomColor = 458754,
		BorderBottomLeftRadius = 458755,
		BorderBottomRightRadius = 458756,
		BorderLeftColor = 458757,
		BorderRightColor = 458758,
		BorderTopColor = 458759,
		BorderTopLeftRadius = 458760,
		BorderTopRightRadius = 458761,
		Opacity = 458762,
		Overflow = 458763
	}

	[Serializable]
	internal struct Dimension : IEquatable<Dimension> // TypeDefIndex: 43992
	{
		// Fields
		public Unit unit; // 0x00
		public float value; // 0x04
	
		// Nested types
		public enum Unit // TypeDefIndex: 43991
		{
			Unitless = 0,
			Pixel = 1,
			Percent = 2,
			Second = 3,
			Millisecond = 4,
			Degree = 5,
			Gradian = 6,
			Radian = 7,
			Turn = 8
		}
	
		// Constructors
		public Dimension(float value, Unit unit) {
			this.unit = default;
			this.value = default;
		} // 0x0000000183D88C60-0x0000000183D88C70
	
		// Methods
		public Length ToLength() => default; // 0x0000000189EBC1D8-0x0000000189EBC208
		public TimeValue ToTime() => default; // 0x0000000189EBC374-0x0000000189EBC394
		public Angle ToAngle() => default; // 0x0000000189EBC18C-0x0000000189EBC1D8
		public static bool operator ==(Dimension lhs, Dimension rhs) => default; // 0x0000000189EBC394-0x0000000189EBC3B8
		public bool Equals(Dimension other) => default; // 0x0000000189EBC150-0x0000000189EBC164
		public override bool Equals(object obj) => default; // 0x0000000189EBC0E0-0x0000000189EBC150
		public override int GetHashCode() => default; // 0x0000000189EBC164-0x0000000189EBC18C
		public override string ToString() => default; // 0x0000000189EBC208-0x0000000189EBC374
	}

	[Serializable]
	internal struct ScalableImage // TypeDefIndex: 43993
	{
		// Fields
		public Texture2D normalImage; // 0x00
		public Texture2D highResolutionImage; // 0x08
	
		// Methods
		public override string ToString() => default; // 0x0000000189EBF4DC-0x0000000189EBF5F0
	}

	internal struct StylePropertyValue // TypeDefIndex: 43994
	{
		// Fields
		public StyleSheet sheet; // 0x00
		public StyleValueHandle handle; // 0x08
	}

	internal struct ImageSource // TypeDefIndex: 43995
	{
		// Fields
		public Texture2D texture; // 0x00
		public Sprite sprite; // 0x08
		public VectorImage vectorImage; // 0x10
		public RenderTexture renderTexture; // 0x18
	
		// Methods
		public bool IsNull() => default; // 0x0000000189EBC5B4-0x0000000189EBC67C
	}

	internal class StylePropertyReader // TypeDefIndex: 43997
	{
		// Fields
		internal static GetCursorIdFunction getCursorIdFunc; // 0x00
		private List<StylePropertyValue> m_Values; // 0x10
		private List<int> m_ValueCount; // 0x18
		private StyleVariableResolver m_Resolver; // 0x20
		private StyleSheet m_Sheet; // 0x28
		private StyleProperty[] m_Properties; // 0x30
		private StylePropertyId[] m_PropertyIds; // 0x38
		private int m_CurrentValueIndex; // 0x40
		private int m_CurrentPropertyIndex; // 0x44
	
		// Properties
		public StyleProperty property { get; private set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public StylePropertyId propertyId { get; private set; } // 0x0000000183D4EED0-0x0000000183D4EEE0 0x0000000183D4EF20-0x0000000183D4EF30
		public int valueCount { get; private set; } // 0x0000000183D4EEC0-0x0000000183D4EED0 0x0000000183D4EF10-0x0000000183D4EF20
		public float dpiScaling { get; private set; } // 0x0000000183D51080-0x0000000183D51090 0x0000000183D510B0-0x0000000183D510C0
	
		// Nested types
		internal delegate int GetCursorIdFunction(StyleSheet sheet, StyleValueHandle handle); // TypeDefIndex: 43996; 0x0000000181165340-0x0000000181165350
	
		// Constructors
		public StylePropertyReader() {} // 0x0000000189EC5028-0x0000000189EC5120
	
		// Methods
		public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling = 1f /* Metadata: 0x01FB628B */) {} // 0x0000000189EC48CC-0x0000000189EC49A8
		public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling = 1f /* Metadata: 0x01FB628F */) {} // 0x0000000189EC4A64-0x0000000189EC4AB0
		public StylePropertyId MoveNextProperty() => default; // 0x0000000189EC24C0-0x0000000189EC24E4
		public StylePropertyValue GetValue(int index) => default; // 0x0000000189EC2020-0x0000000189EC20A0
		public StyleValueType GetValueType(int index) => default; // 0x0000000189EC1FBC-0x0000000189EC2020
		public bool IsValueType(int index, StyleValueType type) => default; // 0x0000000189EC212C-0x0000000189EC21A0
		public bool IsKeyword(int index, StyleValueKeyword keyword) => default; // 0x0000000189EC20A0-0x0000000189EC212C
		public string ReadAsString(int index) => default; // 0x0000000189EC255C-0x0000000189EC25CC
		public Length ReadLength(int index) => default; // 0x0000000189EC34F4-0x0000000189EC35B0
		public TimeValue ReadTimeValue(int index) => default; // 0x0000000189EC4130-0x0000000189EC41F0
		public Translate ReadTranslate(int index) => default; // 0x0000000189EC459C-0x0000000189EC46EC
		public TransformOrigin ReadTransformOrigin(int index) => default; // 0x0000000189EC42DC-0x0000000189EC4424
		public Rotate ReadRotate(int index) => default; // 0x0000000189EC3A44-0x0000000189EC3BE0
		public Scale ReadScale(int index) => default; // 0x0000000189EC3D58-0x0000000189EC3E94
		public float ReadFloat(int index) => default; // 0x0000000189EC2D60-0x0000000189EC2DD4
		public int ReadInt(int index) => default; // 0x0000000189EC347C-0x0000000189EC34F4
		public UnityEngine.Color ReadColor(int index) => default; // 0x0000000189EC2824-0x0000000189EC292C
		public int ReadEnum(StyleEnumType enumType, int index) => default; // 0x0000000189EC2C8C-0x0000000189EC2D60
		public FontDefinition ReadFontDefinition(int index) => default; // 0x0000000189EC2DD4-0x0000000189EC31E4
		public Font ReadFont(int index) => default; // 0x0000000189EC31E4-0x0000000189EC347C
		public Background ReadBackground(int index) => default; // 0x0000000189EC25CC-0x0000000189EC2824
		public UnityEngine.UIElements.Cursor ReadCursor(int index) => default; // 0x0000000189EC292C-0x0000000189EC2BF4
		public TextShadow ReadTextShadow(int index) => default; // 0x0000000189EC3E94-0x0000000189EC4130
		public void ReadListEasingFunction(List<UnityEngine.UIElements.EasingFunction> list, int index) {} // 0x0000000189EC35B0-0x0000000189EC36FC
		public void ReadListTimeValue(List<TimeValue> list, int index) {} // 0x0000000189EC3838-0x0000000189EC3988
		public void ReadListStylePropertyName(List<StylePropertyName> list, int index) {} // 0x0000000189EC36FC-0x0000000189EC3838
		private void LoadProperties() {} // 0x0000000189EC21A0-0x0000000189EC24C0
		private void SetCurrentProperty() {} // 0x0000000189EC49A8-0x0000000189EC4A64
		public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue) => default; // 0x0000000189EC4424-0x0000000189EC459C
		private static Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal) {
			isVertical = default;
			isHorizontal = default;
			return default;
		} // 0x0000000189EC41F0-0x0000000189EC42DC
		public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) => default; // 0x0000000189EC46EC-0x0000000189EC48CC
		public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) => default; // 0x0000000189EC3BE0-0x0000000189EC3D58
		public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4) => default; // 0x0000000189EC3988-0x0000000189EC3A44
		private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value) => default; // 0x0000000189EC2BF4-0x0000000189EC2C8C
		public static Angle ReadAngle(StylePropertyValue value) => default; // 0x0000000189EC24E4-0x0000000189EC255C
		internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source) {
			source = default;
			return default;
		} // 0x0000000189EC4AB0-0x0000000189EC5028
	}

	internal struct MatchResultInfo // TypeDefIndex: 43998
	{
		// Fields
		public readonly bool success; // 0x00
		public readonly PseudoStates triggerPseudoMask; // 0x04
		public readonly PseudoStates dependencyPseudoMask; // 0x08
	
		// Constructors
		public MatchResultInfo(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask) {
			this.success = default;
			this.triggerPseudoMask = default;
			this.dependencyPseudoMask = default;
		} // 0x0000000183D88C70-0x0000000183D88C80
	}

	internal struct SelectorMatchRecord // TypeDefIndex: 43999
	{
		// Fields
		public StyleSheet sheet; // 0x00
		public int styleSheetIndexInStack; // 0x08
		public StyleComplexSelector complexSelector; // 0x10
	
		// Constructors
		public SelectorMatchRecord(StyleSheet sheet, int styleSheetIndexInStack) {
			this.sheet = default;
			this.styleSheetIndexInStack = default;
			complexSelector = default;
		} // 0x0000000189EBF70C-0x0000000189EBF734
	
		// Methods
		public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b) => default; // 0x0000000189EBF5F0-0x0000000189EBF70C
	}

	internal static class StyleSelectorHelper // TypeDefIndex: 44000
	{
		// Methods
		public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) => default; // 0x0000000189EC5FB8-0x0000000189EC621C
		public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, Action<VisualElement, MatchResultInfo> processResult) => default; // 0x0000000189EC5E28-0x0000000189EC5FB8
		private static void FastLookup(IDictionary<string, StyleComplexSelector> table, List<SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record) {} // 0x0000000189EC5848-0x0000000189EC5990
		public static void FindMatches(StyleMatchingContext context, List<SelectorMatchRecord> matchedSelectors, int parentSheetIndex) {} // 0x0000000189EC5990-0x0000000189EC5E28
	}

	internal static class StyleSheetCache // TypeDefIndex: 44003
	{
		// Fields
		private static SheetHandleKeyComparer s_Comparer; // 0x00
		private static Dictionary<SheetHandleKey, StylePropertyId[]> s_RulePropertyIdsCache; // 0x08
	
		// Nested types
		private struct SheetHandleKey // TypeDefIndex: 44001
		{
			// Fields
			public readonly int sheetInstanceID; // 0x00
			public readonly int index; // 0x04
	
			// Constructors
			public SheetHandleKey(StyleSheet sheet, int index) {
				sheetInstanceID = default;
				this.index = default;
			} // 0x0000000189EBF734-0x0000000189EBF76C
		}
	
		private class SheetHandleKeyComparer : IEqualityComparer<SheetHandleKey> // TypeDefIndex: 44002
		{
			// Constructors
			public SheetHandleKeyComparer() {} // 0x000000018350B670-0x000000018350B680
	
			// Methods
			public bool Equals(SheetHandleKey x, SheetHandleKey y) => default; // 0x0000000186F68450-0x0000000186F68468
			public int GetHashCode(SheetHandleKey key) => default; // 0x0000000183D66CE0-0x0000000183D66CF0
		}
	
		// Constructors
		static StyleSheetCache() {} // 0x0000000189EC652C-0x0000000189EC6620
	
		// Methods
		internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex) => default; // 0x0000000189EC62DC-0x0000000189EC647C
		internal static StylePropertyId[] GetPropertyIds(StyleRule rule) => default; // 0x0000000189EC647C-0x0000000189EC652C
		private static StylePropertyId GetPropertyId(StyleRule rule, int index) => default; // 0x0000000189EC621C-0x0000000189EC62DC
	}

	internal static class StyleSheetColor // TypeDefIndex: 44004
	{
		// Fields
		private static Dictionary<string, Color32> s_NameToColor; // 0x00
	
		// Constructors
		static StyleSheetColor() {} // 0x0000000189EC66C0-0x0000000189EC83DC
	
		// Methods
		public static bool TryGetColor(string name, out UnityEngine.Color color) {
			color = default;
			return default;
		} // 0x0000000189EC6620-0x0000000189EC66C0
		private static Color32 HexToColor32(uint color) => default; // 0x0000000183D88C80-0x0000000183D88CA0
	}

	internal static class StyleSheetExtensions // TypeDefIndex: 44005
	{
		// Extension methods
		public static string ReadAsString(this StyleSheet sheet, StyleValueHandle handle) => default; // 0x0000000189EC83F4-0x0000000189EC86D8
		public static bool IsVarFunction(this StyleValueHandle handle) => default; // 0x0000000189EC83DC-0x0000000189EC83F4
	}

	[DebuggerDisplay("id = {id}, keyword = {keyword}, number = {number}, boolean = {boolean}, color = {color}, object = {resource}")]
	internal struct StyleValue // TypeDefIndex: 44006
	{
		// Fields
		public StylePropertyId id; // 0x00
		public StyleKeyword keyword; // 0x04
		public float number; // 0x08
		public Length length; // 0x08
		public UnityEngine.Color color; // 0x08
		public GCHandle resource; // 0x08
	}

	internal struct StyleValueManaged // TypeDefIndex: 44007
	{
		// Fields
		public StylePropertyId id; // 0x00
		public StyleKeyword keyword; // 0x04
		public object value; // 0x08
	}

	internal enum MatchResultErrorCode // TypeDefIndex: 44008
	{
		None = 0,
		Syntax = 1,
		EmptyValue = 2,
		ExpectedEndOfValue = 3
	}

	internal struct MatchResult // TypeDefIndex: 44009
	{
		// Fields
		public MatchResultErrorCode errorCode; // 0x00
		public string errorValue; // 0x08
	
		// Properties
		public bool success { get => default; } // 0x00000001822FBAA0-0x00000001822FBAB0 
	}

	internal abstract class BaseStyleMatcher // TypeDefIndex: 44011
	{
		// Fields
		protected static readonly Regex s_CustomIdentRegex; // 0x00
		private Stack<MatchContext> m_ContextStack; // 0x10
		private MatchContext m_CurrentContext; // 0x18
	
		// Properties
		public abstract int valueCount { get; }
		public abstract bool isCurrentVariable { get; }
		public abstract bool isCurrentComma { get; }
		public bool hasCurrent { get; } // 0x0000000189EBC0BC-0x0000000189EBC0E0 
		public int currentIndex { get; set; } // 0x00000001820D1AC0-0x00000001820D1AD0 0x0000000183D4E9C0-0x0000000183D4E9D0
		public int matchedVariableCount { get; set; } // 0x0000000183D4EBB0-0x0000000183D4EBC0 0x0000000183D4EBC0-0x0000000183D4EBD0
	
		// Nested types
		private struct MatchContext // TypeDefIndex: 44010
		{
			// Fields
			public int valueIndex; // 0x00
			public int matchedVariableCount; // 0x04
		}
	
		// Constructors
		protected BaseStyleMatcher() {} // 0x0000000189EBC044-0x0000000189EBC0BC
		static BaseStyleMatcher() {} // 0x0000000189EBBFB0-0x0000000189EBC044
	
		// Methods
		protected abstract bool MatchKeyword(string keyword);
		protected abstract bool MatchNumber();
		protected abstract bool MatchInteger();
		protected abstract bool MatchLength();
		protected abstract bool MatchPercentage();
		protected abstract bool MatchColor();
		protected abstract bool MatchResource();
		protected abstract bool MatchUrl();
		protected abstract bool MatchTime();
		protected abstract bool MatchAngle();
		protected abstract bool MatchCustomIdent();
		protected void Initialize() {} // 0x0000000189EBB620-0x0000000189EBB668
		public void MoveNext() {} // 0x0000000189EBBEE4-0x0000000189EBBF18
		public void SaveContext() {} // 0x0000000189EBBF64-0x0000000189EBBFB0
		public void RestoreContext() {} // 0x0000000189EBBF18-0x0000000189EBBF64
		public void DropContext() {} // 0x0000000189EBB5D8-0x0000000189EBB620
		protected bool Match(Expression exp) => default; // 0x0000000189EBBE44-0x0000000189EBBEE4
		private bool MatchExpression(Expression exp) => default; // 0x0000000189EBB8F8-0x0000000189EBB9BC
		private bool MatchExpressionWithMultiplier(Expression exp) => default; // 0x0000000189EBB830-0x0000000189EBB8F8
		private bool MatchGroup(Expression exp) => default; // 0x0000000189EBB9BC-0x0000000189EBBA64
		private bool MatchCombinator(Expression exp) => default; // 0x0000000189EBB69C-0x0000000189EBB764
		private bool MatchOr(Expression exp) => default; // 0x0000000189EBBD5C-0x0000000189EBBE44
		private bool MatchOrOr(Expression exp) => default; // 0x0000000189EBBD44-0x0000000189EBBD5C
		private bool MatchAndAnd(Expression exp) => default; // 0x0000000189EBB668-0x0000000189EBB69C
		private int MatchMany(Expression exp) => default; // 0x0000000189EBBC14-0x0000000189EBBD44
		private unsafe int MatchManyByOrder(Expression exp, int* matchOrder) => default; // 0x0000000189EBBACC-0x0000000189EBBC14
		private bool MatchJuxtaposition(Expression exp) => default; // 0x0000000189EBBA64-0x0000000189EBBACC
		private bool MatchDataType(Expression exp) => default; // 0x0000000189EBB764-0x0000000189EBB830
	}

	internal class StylePropertyValueMatcher : BaseStyleMatcher // TypeDefIndex: 44012
	{
		// Fields
		private List<StylePropertyValue> m_Values; // 0x20
	
		// Properties
		private StylePropertyValue current { get => default; } // 0x0000000189EC5714-0x0000000189EC5794 
		public override int valueCount { get => default; } // 0x0000000189EC5808-0x0000000189EC5848 
		public override bool isCurrentVariable { get => default; } // 0x000000018115F4C0-0x000000018115F530 
		public override bool isCurrentComma { get => default; } // 0x0000000189EC5794-0x0000000189EC5808 
	
		// Constructors
		public StylePropertyValueMatcher() {} // 0x0000000189EC56C8-0x0000000189EC5714
	
		// Methods
		public UnityEngine.UIElements.StyleSheets.MatchResult Match(Expression exp, List<StylePropertyValue> values) => default; // 0x0000000189EC5550-0x0000000189EC56C8
		protected override bool MatchKeyword(string keyword) => default; // 0x0000000189EC5330-0x0000000189EC53CC
		protected override bool MatchNumber() => default; // 0x0000000189EC5310-0x0000000189EC5330
		protected override bool MatchInteger() => default; // 0x0000000189EC5310-0x0000000189EC5330
		protected override bool MatchLength() => default; // 0x0000000189EC53CC-0x0000000189EC5440
		protected override bool MatchPercentage() => default; // 0x0000000189EC5440-0x0000000189EC54B4
		protected override bool MatchColor() => default; // 0x0000000189EC519C-0x0000000189EC5258
		protected override bool MatchResource() => default; // 0x0000000189EC54B4-0x0000000189EC54D4
		protected override bool MatchUrl() => default; // 0x0000000189EC5524-0x0000000189EC5550
		protected override bool MatchTime() => default; // 0x0000000189EC54D4-0x0000000189EC5524
		protected override bool MatchCustomIdent() => default; // 0x0000000189EC5258-0x0000000189EC5310
		protected override bool MatchAngle() => default; // 0x0000000189EC5120-0x0000000189EC519C
	}
}

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	internal class Expression // TypeDefIndex: 44013
	{
		// Fields
		public ExpressionType type; // 0x10
		public ExpressionMultiplier multiplier; // 0x14
		public UnityEngine.UIElements.StyleSheets.Syntax.DataType dataType; // 0x20
		public ExpressionCombinator combinator; // 0x24
		public Expression[] subExpressions; // 0x28
		public string keyword; // 0x30
	
		// Constructors
		public Expression() {} // Dummy constructor
		public Expression(ExpressionType type) {} // 0x0000000189EBC42C-0x0000000189EBC48C
	}

	internal enum ExpressionType // TypeDefIndex: 44014
	{
		Unknown = 0,
		Data = 1,
		Keyword = 2,
		Combinator = 3
	}

	internal enum DataType // TypeDefIndex: 44015
	{
		None = 0,
		Number = 1,
		Integer = 2,
		Length = 3,
		Percentage = 4,
		Color = 5,
		Resource = 6,
		Url = 7,
		Time = 8,
		Angle = 9,
		CustomIdent = 10
	}

	internal enum ExpressionCombinator // TypeDefIndex: 44016
	{
		None = 0,
		Or = 1,
		OrOr = 2,
		AndAnd = 3,
		Juxtaposition = 4,
		Group = 5
	}

	internal enum ExpressionMultiplierType // TypeDefIndex: 44017
	{
		None = 0,
		ZeroOrMore = 1,
		OneOrMore = 2,
		ZeroOrOne = 3,
		Ranges = 4,
		OneOrMoreComma = 5,
		GroupAtLeastOne = 6
	}

	internal struct ExpressionMultiplier // TypeDefIndex: 44018
	{
		// Fields
		public const int Infinity = 100; // Metadata: 0x01FB62B4
		private ExpressionMultiplierType m_Type; // 0x00
		public int min; // 0x04
		public int max; // 0x08
	
		// Properties
		public ExpressionMultiplierType type { get => default; set {} } // 0x0000000183D85860-0x0000000183D85870 0x0000000189EBC424-0x0000000189EBC42C
	
		// Constructors
		public ExpressionMultiplier(ExpressionMultiplierType type = ExpressionMultiplierType.None /* Metadata: 0x01FB62B3 */) : this() {
			m_Type = default;
			min = default;
			max = default;
		} // 0x0000000189EBC40C-0x0000000189EBC424
	
		// Methods
		private void SetType(ExpressionMultiplierType value) {} // 0x0000000189EBC3B8-0x0000000189EBC40C
	}

	internal class StyleSyntaxParser // TypeDefIndex: 44019
	{
		// Fields
		private List<Expression> m_ProcessExpressionList; // 0x10
		private Stack<Expression> m_ExpressionStack; // 0x18
		private Stack<ExpressionCombinator> m_CombinatorStack; // 0x20
		private Dictionary<string, Expression> m_ParsedExpressionCache; // 0x28
	
		// Constructors
		public StyleSyntaxParser() {} // 0x0000000189ECA120-0x0000000189ECA278
	
		// Methods
		public Expression Parse(string syntax) => default; // 0x0000000189EC9D44-0x0000000189EC9EE8
		private Expression ParseExpression(StyleSyntaxTokenizer tokenizer) => default; // 0x0000000189EC8DD0-0x0000000189EC904C
		private void ProcessCombinatorStack() {} // 0x0000000189EC9EE8-0x0000000189ECA120
		private Expression ParseTerm(StyleSyntaxTokenizer tokenizer) => default; // 0x0000000189EC9B94-0x0000000189EC9D44
		private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer) => default; // 0x0000000189EC877C-0x0000000189EC88F0
		private Expression ParseGroup(StyleSyntaxTokenizer tokenizer) => default; // 0x0000000189EC904C-0x0000000189EC92E8
		private Expression ParseDataType(StyleSyntaxTokenizer tokenizer) => default; // 0x0000000189EC88F0-0x0000000189EC8DD0
		private Expression ParseNonTerminalValue(string syntax) => default; // 0x0000000189EC9490-0x0000000189EC95C4
		private Expression ParseProperty(StyleSyntaxTokenizer tokenizer) => default; // 0x0000000189EC95C4-0x0000000189EC9A5C
		private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier) {} // 0x0000000189EC92E8-0x0000000189EC9490
		private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max) {
			min = default;
			max = default;
		} // 0x0000000189EC9A5C-0x0000000189EC9B94
		private static void EatSpace(StyleSyntaxTokenizer tokenizer) {} // 0x0000000189EC86D8-0x0000000189EC872C
		private static bool IsExpressionEnd(StyleSyntaxToken token) => default; // 0x0000000189EC8740-0x0000000189EC875C
		private static bool IsCombinator(StyleSyntaxToken token) => default; // 0x0000000189EC872C-0x0000000189EC8740
		private static bool IsMultiplier(StyleSyntaxToken token) => default; // 0x0000000189EC875C-0x0000000189EC877C
	}

	internal enum StyleSyntaxTokenType // TypeDefIndex: 44020
	{
		Unknown = 0,
		String = 1,
		Number = 2,
		Space = 3,
		SingleBar = 4,
		DoubleBar = 5,
		DoubleAmpersand = 6,
		Comma = 7,
		SingleQuote = 8,
		Asterisk = 9,
		Plus = 10,
		QuestionMark = 11,
		HashMark = 12,
		ExclamationPoint = 13,
		OpenBracket = 14,
		CloseBracket = 15,
		OpenBrace = 16,
		CloseBrace = 17,
		LessThan = 18,
		GreaterThan = 19,
		End = 20
	}

	internal struct StyleSyntaxToken // TypeDefIndex: 44021
	{
		// Fields
		public StyleSyntaxTokenType type; // 0x00
		public string text; // 0x08
		public int number; // 0x10
	
		// Constructors
		public StyleSyntaxToken(StyleSyntaxTokenType t) {
			type = default;
			text = default;
			number = default;
		} // 0x0000000189ECAD40-0x0000000189ECAD64
		public StyleSyntaxToken(StyleSyntaxTokenType type, string text) {
			this.type = default;
			this.text = default;
			number = default;
		} // 0x0000000189ECAD64-0x0000000189ECAD88
		public StyleSyntaxToken(StyleSyntaxTokenType type, int number) {
			this.type = default;
			text = default;
			this.number = default;
		} // 0x0000000189ECAD88-0x0000000189ECADB0
	}

	internal class StyleSyntaxTokenizer // TypeDefIndex: 44022
	{
		// Fields
		private List<StyleSyntaxToken> m_Tokens; // 0x10
		private int m_CurrentTokenIndex; // 0x18
	
		// Properties
		public StyleSyntaxToken current { get => default; } // 0x0000000189ECB9FC-0x0000000189ECBAB4 
	
		// Constructors
		public StyleSyntaxTokenizer() {} // 0x0000000189ECB980-0x0000000189ECB9FC
	
		// Methods
		public StyleSyntaxToken MoveNext() => default; // 0x0000000189ECAF78-0x0000000189ECB02C
		public StyleSyntaxToken PeekNext() => default; // 0x0000000189ECB02C-0x0000000189ECB0E4
		public void Tokenize(string syntax) {} // 0x0000000189ECB0E4-0x0000000189ECB980
		private static bool IsNextCharacter(string s, int index, char c) => default; // 0x0000000189ECAE00-0x0000000189ECAE3C
		private static bool IsNextLetterOrDash(string s, int index) => default; // 0x0000000189ECAE3C-0x0000000189ECAEF8
		private static bool IsNextNumber(string s, int index) => default; // 0x0000000189ECAEF8-0x0000000189ECAF78
		private static int GlobCharacter(string s, int index, char c) => default; // 0x0000000189ECADB0-0x0000000189ECAE00
	}
}

namespace UnityEngine.UIElements.UIR
{
	internal class Allocator2D // TypeDefIndex: 43891
	{
		// Fields
		private readonly Vector2Int m_MinSize; // 0x10
		private readonly Vector2Int m_MaxSize; // 0x18
		private readonly Vector2Int m_MaxAllocSize; // 0x20
		private readonly int m_RowHeightBias; // 0x28
		private readonly Row[] m_Rows; // 0x30
		private readonly List<Area> m_Areas; // 0x38
	
		// Nested types
		public class Area // TypeDefIndex: 43888
		{
			// Fields
			public RectInt rect; // 0x10
			public BestFitAllocator allocator; // 0x20
	
			// Constructors
			public Area() {} // Dummy constructor
			public Area(RectInt rect) {} // 0x0000000189F454FC-0x0000000189F4557C
		}
	
		public class Row : LinkedPoolItem<Row> // TypeDefIndex: 43889
		{
			// Fields
			public RectInt rect; // 0x18
			public Area area; // 0x28
			public BestFitAllocator allocator; // 0x30
			public Alloc alloc; // 0x38
			public Row next; // 0x50
			public static readonly LinkedPool<Row> pool; // 0x00
	
			// Constructors
			public Row() {} // 0x0000000189F5088C-0x0000000189F508B4
			static Row() {} // 0x0000000189F50758-0x0000000189F5088C
	
			// Methods
			private static Row Create() => default; // 0x0000000189F506B4-0x0000000189F50704
			private static void Reset(Row row) {} // 0x0000000189F50704-0x0000000189F50758
		}
	
		public struct Alloc2D // TypeDefIndex: 43890
		{
			// Fields
			public RectInt rect; // 0x00
			public Row row; // 0x10
			public Alloc alloc; // 0x18
	
			// Constructors
			public Alloc2D(Row row, Alloc alloc, int width, int height) {
				rect = default;
				this.row = default;
				this.alloc = default;
			} // 0x0000000189F44958-0x0000000189F449F8
		}
	
		// Constructors
		public Allocator2D() {} // Dummy constructor
		public Allocator2D(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) {} // 0x0000000189F45330-0x0000000189F454FC
	
		// Methods
		public bool TryAllocate(int width, int height, out Alloc2D alloc2D) {
			alloc2D = default;
			return default;
		} // 0x0000000189F44ED4-0x0000000189F45330
		public void Free(Alloc2D alloc2D) {} // 0x0000000189F44CD0-0x0000000189F44ED4
		private static void BuildAreas(List<Area> areas, Vector2Int minSize, Vector2Int maxSize) {} // 0x0000000189F449F8-0x0000000189F44B9C
		private static Vector2Int ComputeMaxAllocSize(List<Area> areas, int rowHeightBias) => default; // 0x0000000189F44C04-0x0000000189F44CD0
		private static Row[] BuildRowArray(int maxRowHeight, int rowHeightBias) => default; // 0x0000000189F44B9C-0x0000000189F44C04
	}

	internal class GradientSettingsAtlas : IDisposable // TypeDefIndex: 43893
	{
		// Fields
		private static ProfilerMarker s_MarkerWrite; // 0x00
		private static ProfilerMarker s_MarkerCommit; // 0x08
		private readonly int m_Length; // 0x10
		private readonly int m_ElemWidth; // 0x14
		private BestFitAllocator m_Allocator; // 0x18
		private Texture2D m_Atlas; // 0x20
		private RawTexture m_RawAtlas; // 0x28
		private static int s_TextureCounter; // 0x10
	
		// Properties
		internal int length { get => default; } // 0x0000000183D85B00-0x0000000183D85B10 
		protected bool disposed { get; private set; } // 0x0000000183D4F190-0x0000000183D4F1A0 0x0000000183D4E280-0x0000000183D4E290
		public Texture2D atlas { get => default; } // 0x0000000183D85A20-0x0000000183D85A30 
		public bool MustCommit { get; private set; } // 0x0000000183D4F300-0x0000000183D4F310 0x0000000183D4F330-0x0000000183D4F340
	
		// Nested types
		private struct RawTexture // TypeDefIndex: 43892
		{
			// Fields
			public Color32[] rgba; // 0x00
			public int width; // 0x08
			public int height; // 0x0C
	
			// Methods
			public void WriteRawInt2Packed(int v0, int v1, int destX, int destY) {} // 0x0000000189F50620-0x0000000189F506B4
			public void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY) {} // 0x0000000189F50574-0x0000000189F50620
		}
	
		// Constructors
		public GradientSettingsAtlas() {} // Dummy constructor
		public GradientSettingsAtlas(int length = 4096 /* Metadata: 0x01FB60BF */) {} // 0x0000000189F462B4-0x0000000189F462C8
		static GradientSettingsAtlas() {} // 0x0000000189F4621C-0x0000000189F462B4
	
		// Methods
		public void Dispose() {} // 0x0000000189F45C20-0x0000000189F45C70
		protected virtual void Dispose(bool disposing) {} // 0x0000000189F45C70-0x0000000189F45CD0
		public void Reset() {} // 0x0000000189F45E24-0x0000000189F45EDC
		public Alloc Add(int count) => default; // 0x0000000189F45AF8-0x0000000189F45BBC
		public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap) {} // 0x0000000189F45EDC-0x0000000189F4621C
		public void Commit() {} // 0x0000000189F45BBC-0x0000000189F45C20
		private void PrepareAtlas() {} // 0x0000000189F45CD0-0x0000000189F45E24
	}

	internal class LinkedPoolItem<T> // TypeDefIndex: 43894
	{
		// Fields
		internal T poolNext;
	
		// Constructors
		public LinkedPoolItem() {}
	}

	internal class LinkedPool<T> // TypeDefIndex: 43895
		where T : LinkedPoolItem<T>
	{
		// Fields
		private readonly Func<T> m_CreateFunc;
		private readonly Action<T> m_ResetAction;
		private readonly int m_Limit;
		private T m_PoolFirst;
	
		// Properties
		public int Count { get; private set; }
	
		// Constructors
		public LinkedPool() {} // Dummy constructor
		public LinkedPool(Func<T> createFunc, Action<T> resetAction, int limit = 10000 /* Metadata: 0x01FB60C1 */) {}
	
		// Methods
		public void Clear() {}
		public T Get() => default;
		public void Return(T item) {}
	}

	internal class BasicNode<T> : LinkedPoolItem<BasicNode<T>> // TypeDefIndex: 43896
	{
		// Fields
		public BasicNode<T> next;
		public T data;
	
		// Constructors
		public BasicNode() {}
	
		// Methods
		public void AppendTo(ref BasicNode<T> first) {}
	}

	internal class BasicNodePool<T> : LinkedPool<BasicNode<T>> // TypeDefIndex: 43897
	{
		// Constructors
		public BasicNodePool() {}
	
		// Methods
		private static void Reset(BasicNode<T> node) {}
		private static BasicNode<T> Create() => default;
	}

	internal static class MeshBuilder // TypeDefIndex: 43902
	{
		// Fields
		private static ProfilerMarker s_VectorGraphics9Slice; // 0x00
		private static ProfilerMarker s_VectorGraphicsSplitTriangle; // 0x08
		private static ProfilerMarker s_VectorGraphicsScaleTriangle; // 0x10
		private static ProfilerMarker s_VectorGraphicsStretch; // 0x18
		internal static readonly int s_MaxTextMeshVertices; // 0x20
		private static readonly ushort[] slicedQuadIndices; // 0x28
		private static readonly float[] k_TexCoordSlicesX; // 0x30
		private static readonly float[] k_TexCoordSlicesY; // 0x38
		private static readonly float[] k_PositionSlicesX; // 0x40
		private static readonly float[] k_PositionSlicesY; // 0x48
		private static VertexClipEdge[] s_AllClipEdges; // 0x50
	
		// Nested types
		internal struct AllocMeshData // TypeDefIndex: 43899
		{
			// Fields
			internal Allocator alloc; // 0x00
			internal Texture texture; // 0x08
			internal TextureId svgTexture; // 0x10
			internal Material material; // 0x18
			internal MeshGenerationContext.MeshFlags flags; // 0x20
			internal BMPAlloc colorAlloc; // 0x24
	
			// Nested types
			internal delegate MeshWriteData Allocator(uint vertexCount, uint indexCount, ref AllocMeshData allocatorData); // TypeDefIndex: 43898; 0x0000000181035ED0-0x0000000181035EF0
	
			// Methods
			internal MeshWriteData Allocate(uint vertexCount, uint indexCount) => default; // 0x0000000189E89054-0x0000000189E89084
		}
	
		private struct ClipCounts // TypeDefIndex: 43900
		{
			// Fields
			public int firstClippedIndex; // 0x00
			public int firstDegenerateIndex; // 0x04
			public int lastClippedIndex; // 0x08
			public int clippedTriangles; // 0x0C
			public int addedTriangles; // 0x10
			public int degenerateTriangles; // 0x14
		}
	
		private enum VertexClipEdge // TypeDefIndex: 43901
		{
			None = 0,
			Left = 1,
			Top = 2,
			Right = 4,
			Bottom = 8
		}
	
		// Constructors
		static MeshBuilder() {} // 0x0000000189F4F8F4-0x0000000189F4FBF4
	
		// Methods
		internal static void MakeBorder(MeshGenerationContextUtils.BorderParams borderParams, float posZ, AllocMeshData meshAlloc) {} // 0x0000000189F49ED8-0x0000000189F49FD0
		internal static void MakeSolidRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc) {} // 0x0000000189F4ACA8-0x0000000189F4AE9C
		internal static void MakeTexturedRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc, ColorPage colorPage) {} // 0x0000000189F4B514-0x0000000189F4BD28
		private static UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.TextCore.Text.MeshInfo info, int index, Vector2 offset, VertexFlags flags = VertexFlags.IsText /* Metadata: 0x01FB60C5 */, bool isDynamicColor = false /* Metadata: 0x01FB60C6 */) => default; // 0x0000000189F49598-0x0000000189F4974C
		private static UnityEngine.UIElements.Vertex ConvertTextVertexToUIRVertex(UnityEngine.UIElements.TextVertex textVertex, Vector2 offset) => default; // 0x0000000183D898C0-0x0000000183D89980
		private static int LimitTextVertices(int vertexCount, bool logTruncation = true /* Metadata: 0x01FB60C7 */) => default; // 0x0000000189F49DE4-0x0000000189F49ED8
		internal static void MakeText(UnityEngine.TextCore.Text.MeshInfo meshInfo, Vector2 offset, AllocMeshData meshAlloc, VertexFlags flags = VertexFlags.IsText /* Metadata: 0x01FB60C8 */, bool isDynamicColor = false /* Metadata: 0x01FB60C9 */) {} // 0x0000000189F4B1B8-0x0000000189F4B514
		internal static void MakeText(NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, Vector2 offset, AllocMeshData meshAlloc) {} // 0x0000000189F4AE9C-0x0000000189F4B1B8
		internal static void UpdateText(NativeArray<UnityEngine.UIElements.TextVertex> uiVertices, Vector2 offset, Matrix4x4 transform, Color32 xformClipPages, Color32 ids, Color32 flags, Color32 opacityPageSettingIndex, NativeSlice<UnityEngine.UIElements.Vertex> vertices) {} // 0x0000000189F4F48C-0x0000000189F4F6B4
		private static void MakeQuad(Rect rcPosition, Rect rcTexCoord, UnityEngine.Color color, float posZ, AllocMeshData meshAlloc, ColorPage colorPage) {} // 0x0000000189F49FD0-0x0000000189F4A3D4
		internal static void MakeSlicedQuad(ref MeshGenerationContextUtils.RectangleParams rectParams, float posZ, AllocMeshData meshAlloc) {} // 0x0000000189F4A3D4-0x0000000189F4ACA8
		internal static void MakeVectorGraphics(MeshGenerationContextUtils.RectangleParams rectParams, int settingIndexOffset, AllocMeshData meshAlloc, out int finalVertexCount, out int finalIndexCount) {
			finalVertexCount = default;
			finalIndexCount = default;
		} // 0x0000000189F4CD10-0x0000000189F4D804
		internal static void MakeVectorGraphicsStretchBackground(UnityEngine.UIElements.Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, UnityEngine.ScaleMode scaleMode, UnityEngine.Color tint, int settingIndexOffset, AllocMeshData meshAlloc, out int finalVertexCount, out int finalIndexCount) {
			finalVertexCount = default;
			finalIndexCount = default;
		} // 0x0000000189F4C524-0x0000000189F4CD10
		private static unsafe void SplitTriangle(UnityEngine.UIElements.Vertex* vertices, ushort* indices, ref int vertexCount, int indexToProcess, ref int indexCount, float svgWidth, float svgHeight, Vector4 sliceLTRB, int sliceIndex) {} // 0x0000000189F4EC40-0x0000000189F4F48C
		private static unsafe void ScaleSplittedTriangles(UnityEngine.UIElements.Vertex* vertices, int vertexCount, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB) {} // 0x0000000189F4E9CC-0x0000000189F4EC40
		internal static void MakeVectorGraphics9SliceBackground(UnityEngine.UIElements.Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, bool stretch, UnityEngine.Color tint, int settingIndexOffset, AllocMeshData meshAlloc) {} // 0x0000000189F4BD28-0x0000000189F4C524
		private static ClipCounts UpperBoundApproximateRectClippingResults(UnityEngine.UIElements.Vertex[] vertices, ushort[] indices, Vector4 clipRectMinMax) => default; // 0x0000000189F4F6B4-0x0000000189F4F8F4
		private static void RectClip(UnityEngine.UIElements.Vertex[] vertices, ushort[] indices, Vector4 clipRectMinMax, MeshWriteData mwd, ClipCounts cc, ref int newVertexCount) {} // 0x0000000189F4E4E4-0x0000000189F4E9CC
		private static unsafe void RectClipTriangle(UnityEngine.UIElements.Vertex* vt, ushort* it, Vector4 clipRectMinMax, MeshWriteData mwd, ref ushort nextNewVertex) {} // 0x0000000189F4D804-0x0000000189F4E4E4
		private static unsafe Vector3 GetVertexBaryCentricCoordinates(UnityEngine.UIElements.Vertex* vt, float x, float y) => default; // 0x0000000189F4974C-0x0000000189F498B0
		private static unsafe UnityEngine.UIElements.Vertex InterpolateVertexInTriangle(UnityEngine.UIElements.Vertex* vt, float x, float y, Vector3 uvw) => default; // 0x0000000189F49A80-0x0000000189F49CB4
		private static unsafe UnityEngine.UIElements.Vertex InterpolateVertexInTriangleEdge(UnityEngine.UIElements.Vertex* vt, int e0, int e1, float t) => default; // 0x0000000189F498B0-0x0000000189F49A80
		private static float IntersectSegments(float ax, float ay, float bx, float by, float cx, float cy, float dx, float dy) => default; // 0x0000000189F49CB4-0x0000000189F49DE4
	}

	internal struct ChainBuilderStats // TypeDefIndex: 43903
	{
		// Fields
		public uint elementsAdded; // 0x00
		public uint elementsRemoved; // 0x04
		public uint recursiveClipUpdates; // 0x08
		public uint recursiveClipUpdatesExpanded; // 0x0C
		public uint nonRecursiveClipUpdates; // 0x10
		public uint recursiveTransformUpdates; // 0x14
		public uint recursiveTransformUpdatesExpanded; // 0x18
		public uint recursiveOpacityUpdates; // 0x1C
		public uint recursiveOpacityUpdatesExpanded; // 0x20
		public uint colorUpdates; // 0x24
		public uint colorUpdatesExpanded; // 0x28
		public uint recursiveVisualUpdates; // 0x2C
		public uint recursiveVisualUpdatesExpanded; // 0x30
		public uint nonRecursiveVisualUpdates; // 0x34
		public uint dirtyProcessed; // 0x38
		public uint nudgeTransformed; // 0x3C
		public uint boneTransformed; // 0x40
		public uint skipTransformed; // 0x44
		public uint visualUpdateTransformed; // 0x48
		public uint updatedMeshAllocations; // 0x4C
		public uint newMeshAllocations; // 0x50
		public uint groupTransformElementsChanged; // 0x54
		public uint immedateRenderersActive; // 0x58
		public uint textUpdates; // 0x5C
	}

	internal class RenderChain : IDisposable // TypeDefIndex: 43908
	{
		// Fields
		private RenderChainCommand m_FirstCommand; // 0x10
		private DepthOrderedDirtyTracking m_DirtyTracker; // 0x18
		private LinkedPool<RenderChainCommand> m_CommandPool; // 0x40
		private BasicNodePool<TextureEntry> m_TexturePool; // 0x48
		private List<RenderNodeData> m_RenderNodesData; // 0x50
		private Shader m_DefaultShader; // 0x58
		private Shader m_DefaultWorldSpaceShader; // 0x60
		private Material m_DefaultMat; // 0x68
		private Material m_DefaultWorldSpaceMat; // 0x70
		private bool m_BlockDirtyRegistration; // 0x78
		private int m_StaticIndex; // 0x7C
		private int m_ActiveRenderNodes; // 0x80
		private int m_CustomMaterialCommands; // 0x84
		private ChainBuilderStats m_Stats; // 0x88
		private uint m_StatsElementsAdded; // 0xE8
		private uint m_StatsElementsRemoved; // 0xEC
		private VisualElement m_FirstTextElement; // 0xF0
		private UIRTextUpdatePainter m_TextUpdatePainter; // 0xF8
		private int m_TextElementCount; // 0x100
		private int m_DirtyTextStartIndex; // 0x104
		private int m_DirtyTextRemaining; // 0x108
		private bool m_FontWasReset; // 0x10C
		private Dictionary<VisualElement, Vector2> m_LastGroupTransformElementScale; // 0x110
		private TextureRegistry m_TextureRegistry; // 0x118
		private static ProfilerMarker s_MarkerProcess; // 0x00
		private static ProfilerMarker s_MarkerClipProcessing; // 0x08
		private static ProfilerMarker s_MarkerOpacityProcessing; // 0x10
		private static ProfilerMarker s_MarkerColorsProcessing; // 0x18
		private static ProfilerMarker s_MarkerTransformProcessing; // 0x20
		private static ProfilerMarker s_MarkerVisualsProcessing; // 0x28
		private static ProfilerMarker s_MarkerTextRegen; // 0x30
		internal static Action OnPreRender; // 0x38
		internal UIRVEShaderInfoAllocator shaderInfoAllocator; // 0x148
	
		// Properties
		protected bool disposed { get; private set; } // 0x0000000183D57B30-0x0000000183D57B40 0x0000000183D5A200-0x0000000183D5A210
		internal BaseVisualElementPanel panel { get; private set; } // 0x0000000183D56F00-0x0000000183D56F10 0x0000000184275CB8-0x0000000184275CCC
		internal UIRenderDevice device { get; private set; } // 0x0000000183D56D00-0x0000000183D56D10 0x0000000184275CCC-0x0000000184275CE0
		internal AtlasBase atlas { get; private set; } // 0x0000000183D56EF0-0x0000000183D56F00 0x0000000184275CE0-0x0000000184275CF4
		internal VectorImageManager vectorImageManager { get; private set; } // 0x0000000183D57300-0x0000000183D57310 0x00000001858B3FD8-0x00000001858B3FEC
		internal UIRStylePainter painter { get; private set; } // 0x0000000183D570B0-0x0000000183D570C0 0x00000001858B3C54-0x00000001858B3C68
		internal bool drawStats { get; set; } // 0x0000000183D88B40-0x0000000183D88B50 0x0000000183D88B60-0x0000000183D88B70
		internal bool drawInCameras { get; private set; } // 0x0000000183D88B30-0x0000000183D88B40 0x0000000183D88B50-0x0000000183D88B60
		internal Shader defaultShader { set {} } // 0x0000000189E8DFD0-0x0000000189E8E074
		internal Shader defaultWorldSpaceShader { set {} } // 0x0000000189E8E074-0x0000000189E8E118
	
		// Nested types
		private struct DepthOrderedDirtyTracking // TypeDefIndex: 43904
		{
			// Fields
			public List<VisualElement> heads; // 0x00
			public List<VisualElement> tails; // 0x08
			public int[] minDepths; // 0x10
			public int[] maxDepths; // 0x18
			public uint dirtyID; // 0x20
	
			// Methods
			public void EnsureFits(int maxDepth) {} // 0x0000000189E89BAC-0x0000000189E89C2C
			public void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass) {} // 0x0000000189E89C2C-0x0000000189E89DF0
			public void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse) {} // 0x0000000189E899B8-0x0000000189E89BAC
			public void Reset() {} // 0x0000000189E89DF0-0x0000000189E89E48
		}
	
		private struct RenderChainStaticIndexAllocator // TypeDefIndex: 43905
		{
			// Fields
			private static List<RenderChain> renderChains; // 0x00
	
			// Constructors
			static RenderChainStaticIndexAllocator() {
				renderChains = default;
			} // 0x0000000189E8A278-0x0000000189E8A30C
	
			// Methods
			public static int AllocateIndex(RenderChain renderChain) => default; // 0x0000000189E8A0FC-0x0000000189E8A208
			public static void FreeIndex(int index) {} // 0x0000000189E8A208-0x0000000189E8A278
			public static RenderChain AccessIndex(int index) => default; // 0x0000000189E8A090-0x0000000189E8A0FC
		}
	
		private struct RenderNodeData // TypeDefIndex: 43906
		{
			// Fields
			public Material standardMaterial; // 0x00
			public Material initialMaterial; // 0x08
			public MaterialPropertyBlock matPropBlock; // 0x10
			public RenderChainCommand firstCommand; // 0x18
			public UIRenderDevice device; // 0x20
			public Texture vectorAtlas; // 0x28
			public Texture shaderInfoAtlas; // 0x30
			public float dpiScale; // 0x38
			public NativeSlice<Transform3x4> transformConstants; // 0x40
			public NativeSlice<Vector4> clipRectConstants; // 0x50
		}
	
		// Constructors
		public RenderChain() {} // Dummy constructor
		static RenderChain() {} // 0x0000000189E8D964-0x0000000189E8DBF8
		public RenderChain(BaseVisualElementPanel panel) {} // 0x0000000189E8DBF8-0x0000000189E8DFD0
	
		// Methods
		private void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan) {} // 0x0000000189E8A6D4-0x0000000189E8AA5C
		private void Destructor() {} // 0x0000000189E8AA5C-0x0000000189E8ACA4
		public void Dispose() {} // 0x0000000189E8ACD0-0x0000000189E8AD20
		protected void Dispose(bool disposing) {} // 0x0000000189E8ACA4-0x0000000189E8ACD0
		public void ProcessChanges() {} // 0x0000000189E8C3A0-0x0000000189E8C91C
		public void Render() {} // 0x0000000189E8CBE4-0x0000000189E8CF58
		private void ProcessTextRegen(bool timeSliced) {} // 0x0000000189E8C91C-0x0000000189E8CB1C
		public void UIEOnChildAdded(VisualElement ve) {} // 0x0000000189E8D198-0x0000000189E8D348
		public void UIEOnChildrenReordered(VisualElement ve) {} // 0x0000000189E8D43C-0x0000000189E8D5CC
		public void UIEOnChildRemoving(VisualElement ve) {} // 0x0000000189E8D348-0x0000000189E8D43C
		public void StopTrackingGroupTransformElement(VisualElement ve) {} // 0x0000000189E8D140-0x0000000189E8D198
		public void UIEOnRenderHintsChanged(VisualElement ve) {} // 0x0000000189E8D790-0x0000000189E8D82C
		public void UIEOnClippingChanged(VisualElement ve, bool hierarchical) {} // 0x0000000189E8D5CC-0x0000000189E8D664
		public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false /* Metadata: 0x01FB60CF */) {} // 0x0000000189E8D6F4-0x0000000189E8D790
		public void UIEOnColorChanged(VisualElement ve) {} // 0x0000000189E8D664-0x0000000189E8D6F4
		public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) {} // 0x0000000189E8D82C-0x0000000189E8D8C8
		public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) {} // 0x0000000189E8D8C8-0x0000000189E8D964
		internal Material GetStandardMaterial() => default; // 0x0000000189E8B758-0x0000000189E8B844
		internal Material GetStandardWorldSpaceMaterial() => default; // 0x0000000189E8B844-0x0000000189E8B930
		internal void EnsureFitsDepth(int depth) {} // 0x0000000189E8B680-0x0000000189E8B68C
		internal void ChildWillBeRemoved(VisualElement ve) {} // 0x0000000189E8A62C-0x0000000189E8A6D4
		internal RenderChainCommand AllocCommand() => default; // 0x0000000189E8A51C-0x0000000189E8A578
		internal void FreeCommand(RenderChainCommand cmd) {} // 0x0000000189E8B68C-0x0000000189E8B72C
		internal void OnRenderCommandAdded(RenderChainCommand command) {} // 0x0000000189E8C1E8-0x0000000189E8C268
		internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) {} // 0x0000000189E8C268-0x0000000189E8C29C
		internal void AddTextElement(VisualElement ve) {} // 0x0000000189E8A4A8-0x0000000189E8A51C
		internal void RemoveTextElement(VisualElement ve) {} // 0x0000000189E8CB1C-0x0000000189E8CBE4
		internal void OnGroupTransformElementChangedTransform(VisualElement ve) {} // 0x0000000189E8B930-0x0000000189E8BA64
		private static RenderNodeData AccessRenderNodeData(IntPtr obj) => default; // 0x0000000189E8A3CC-0x0000000189E8A4A8
		private static void OnRenderNodeExecute(IntPtr obj) {} // 0x0000000189E8C29C-0x0000000189E8C3A0
		private static void OnRegisterIntermediateRenderers(Camera camera) {} // 0x0000000189E8BDE0-0x0000000189E8C1E8
		private static void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, ref RenderNodeData rnd, Camera camera, int sameDistanceSortPriority) {} // 0x0000000189E8BA64-0x0000000189E8BDE0
		internal void RepaintTexturedElements() {} // 0x0000000189E8CF58-0x0000000189E8D00C
		private void OnFontReset(Font font) {} // 0x0000000183D88B20-0x0000000183D88B30
		public void AppendTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas) {} // 0x0000000189E8A578-0x0000000189E8A62C
		public void ResetTextures(VisualElement ve) {} // 0x0000000189E8D00C-0x0000000189E8D140
		private void DrawStats() {} // 0x0000000189E8AD20-0x0000000189E8B680
		private static VisualElement GetFirstElementInPanel(VisualElement ve) => default; // 0x0000000189E8B72C-0x0000000189E8B758
	}

	[Flags]
	internal enum RenderDataDirtyTypes // TypeDefIndex: 43909
	{
		None = 0,
		Transform = 1,
		ClipRectSize = 2,
		Clipping = 4,
		ClippingHierarchy = 8,
		Visuals = 16,
		VisualsHierarchy = 32,
		Opacity = 64,
		OpacityHierarchy = 128,
		Color = 256
	}

	internal enum RenderDataDirtyTypeClasses // TypeDefIndex: 43910
	{
		Clipping = 0,
		Opacity = 1,
		Color = 2,
		TransformSize = 3,
		Visuals = 4,
		Count = 5
	}

	internal struct RenderChainVEData // TypeDefIndex: 43911
	{
		// Fields
		internal VisualElement prev; // 0x00
		internal VisualElement next; // 0x08
		internal VisualElement groupTransformAncestor; // 0x10
		internal VisualElement boneTransformAncestor; // 0x18
		internal VisualElement prevDirty; // 0x20
		internal VisualElement nextDirty; // 0x28
		internal int hierarchyDepth; // 0x30
		internal RenderDataDirtyTypes dirtiedValues; // 0x34
		internal uint dirtyID; // 0x38
		internal RenderChainCommand firstCommand; // 0x40
		internal RenderChainCommand lastCommand; // 0x48
		internal RenderChainCommand firstClosingCommand; // 0x50
		internal RenderChainCommand lastClosingCommand; // 0x58
		internal bool isInChain; // 0x60
		internal bool isHierarchyHidden; // 0x61
		internal bool localFlipsWinding; // 0x62
		internal bool localTransformScaleZero; // 0x63
		internal bool worldFlipsWinding; // 0x64
		internal ClipMethod clipMethod; // 0x68
		internal int childrenStencilRef; // 0x6C
		internal int childrenMaskDepth; // 0x70
		internal bool disableNudging; // 0x74
		internal bool usesLegacyText; // 0x75
		internal MeshHandle data; // 0x78
		internal MeshHandle closingData; // 0x80
		internal Matrix4x4 verticesSpace; // 0x88
		internal int displacementUVStart; // 0xC8
		internal int displacementUVEnd; // 0xCC
		internal BMPAlloc transformID; // 0xD0
		internal BMPAlloc clipRectID; // 0xD8
		internal BMPAlloc opacityID; // 0xE0
		internal BMPAlloc textCoreSettingsID; // 0xE8
		internal BMPAlloc backgroundColorID; // 0xF0
		internal BMPAlloc borderLeftColorID; // 0xF8
		internal BMPAlloc borderTopColorID; // 0x100
		internal BMPAlloc borderRightColorID; // 0x108
		internal BMPAlloc borderBottomColorID; // 0x110
		internal BMPAlloc tintColorID; // 0x118
		internal float compositeOpacity; // 0x120
		internal UnityEngine.Color backgroundColor; // 0x124
		internal VisualElement prevText; // 0x138
		internal VisualElement nextText; // 0x140
		internal List<RenderChainTextEntry> textEntries; // 0x148
		internal BasicNode<TextureEntry> textures; // 0x150
	
		// Properties
		internal RenderChainCommand lastClosingOrLastCommand { get => default; } // 0x0000000189E8A3BC-0x0000000189E8A3CC 
	
		// Methods
		internal static bool AllocatesID(BMPAlloc alloc) => default; // 0x0000000189E8A30C-0x0000000189E8A364
		internal static bool InheritsID(BMPAlloc alloc) => default; // 0x0000000189E8A364-0x0000000189E8A3BC
	}

	internal struct RenderChainTextEntry // TypeDefIndex: 43912
	{
		// Fields
		internal RenderChainCommand command; // 0x00
		internal int firstVertex; // 0x08
		internal int vertexCount; // 0x0C
	}

	internal struct TextureEntry // TypeDefIndex: 43913
	{
		// Fields
		public Texture source; // 0x00
		public TextureId actual; // 0x08
		public bool replaced; // 0x0C
	}

	internal abstract class BaseShaderInfoStorage : IDisposable // TypeDefIndex: 43914
	{
		// Fields
		protected static int s_TextureCounter; // 0x00
		internal static ProfilerMarker s_MarkerCopyTexture; // 0x08
		internal static ProfilerMarker s_MarkerGetTextureData; // 0x10
		internal static ProfilerMarker s_MarkerUpdateTexture; // 0x18
	
		// Properties
		public abstract Texture2D texture { get; }
		protected bool disposed { get; private set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
	
		// Constructors
		protected BaseShaderInfoStorage() {} // 0x000000018350B670-0x000000018350B680
		static BaseShaderInfoStorage() {} // 0x0000000189E89218-0x0000000189E892EC
	
		// Methods
		public abstract bool AllocateRect(int width, int height, out RectInt uvs);
		public abstract void SetTexel(int x, int y, UnityEngine.Color color);
		public abstract void UpdateTexture();
		public void Dispose() {} // 0x0000000189E891C8-0x0000000189E89218
		protected virtual void Dispose(bool disposing) {} // 0x0000000185152C08-0x0000000185152C14
	}

	internal class ShaderInfoStorage<T> : BaseShaderInfoStorage // TypeDefIndex: 43915
		where T : struct
	{
		// Fields
		private readonly int m_InitialSize;
		private readonly int m_MaxSize;
		private readonly TextureFormat m_Format;
		private readonly Func<UnityEngine.Color, T> m_Convert;
		private UIRAtlasAllocator m_Allocator;
		private Texture2D m_Texture;
		private NativeArray<T> m_Texels;
	
		// Properties
		public override Texture2D texture { get => default; }
	
		// Constructors
		public ShaderInfoStorage() {} // Dummy constructor
		public ShaderInfoStorage(TextureFormat format, Func<UnityEngine.Color, T> convert, int initialSize = 64 /* Metadata: 0x01FB60E3 */, int maxSize = 4096 /* Metadata: 0x01FB60E5 */) {}
	
		// Methods
		protected override void Dispose(bool disposing) {}
		public override bool AllocateRect(int width, int height, out RectInt uvs) {
			uvs = default;
			return default;
		}
		public override void SetTexel(int x, int y, UnityEngine.Color color) {}
		public override void UpdateTexture() {}
		private void CreateOrExpandTexture() {}
		private static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight) {}
	}

	internal class ShaderInfoStorageRGBA32 : ShaderInfoStorage<Color32> // TypeDefIndex: 43917
	{
		// Fields
		private static readonly Func<UnityEngine.Color, Color32> s_Convert; // 0x00
	
		// Constructors
		public ShaderInfoStorageRGBA32() {} // Dummy constructor
		public ShaderInfoStorageRGBA32(int initialSize = 64 /* Metadata: 0x01FB60E7 */, int maxSize = 4096 /* Metadata: 0x01FB60E9 */) {} // 0x0000000189E8E1DC-0x0000000189E8E268
		static ShaderInfoStorageRGBA32() {} // 0x0000000189E8E118-0x0000000189E8E1DC
	}

	internal class ShaderInfoStorageRGBAFloat : ShaderInfoStorage<UnityEngine.Color> // TypeDefIndex: 43919
	{
		// Fields
		private static readonly Func<UnityEngine.Color, UnityEngine.Color> s_Convert; // 0x00
	
		// Constructors
		public ShaderInfoStorageRGBAFloat() {} // Dummy constructor
		public ShaderInfoStorageRGBAFloat(int initialSize = 64 /* Metadata: 0x01FB60EB */, int maxSize = 4096 /* Metadata: 0x01FB60ED */) {} // 0x0000000189E8E32C-0x0000000189E8E3B8
		static ShaderInfoStorageRGBAFloat() {} // 0x0000000189E8E268-0x0000000189E8E32C
	}

	internal static class Shaders // TypeDefIndex: 43920
	{
		// Fields
		public static readonly string k_AtlasBlit; // 0x00
		public static readonly string k_Editor; // 0x08
		public static readonly string k_Runtime; // 0x10
		public static readonly string k_RuntimeWorld; // 0x18
		public static readonly string k_GraphView; // 0x20
	
		// Constructors
		static Shaders() {} // 0x0000000189E8E3B8-0x0000000189E8E62C
	}

	internal static class Tessellation // TypeDefIndex: 43922
	{
		// Fields
		internal static float kEpsilon; // 0x00
		internal static float kUnusedArc; // 0x04
		internal static ushort kSubdivisions; // 0x08
		private static ProfilerMarker s_MarkerTessellateRect; // 0x10
		private static ProfilerMarker s_MarkerTessellateBorder; // 0x18
		private static Edges[] s_AllEdges; // 0x20
	
		// Nested types
		internal enum Edges // TypeDefIndex: 43921
		{
			None = 0,
			Left = 1,
			Top = 2,
			Right = 4,
			Bottom = 8,
			All = 15
		}
	
		// Constructors
		static Tessellation() {} // 0x0000000189E94DA8-0x0000000189E94F0C
	
		// Methods
		public static void TessellateRect(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc, bool computeUVs) {} // 0x0000000189E92774-0x0000000189E92DB0
		public static void TessellateQuad(MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshBuilder.AllocMeshData meshAlloc) {} // 0x0000000189E91320-0x0000000189E917F0
		public static void TessellateBorder(MeshGenerationContextUtils.BorderParams borderParams, float posZ, MeshBuilder.AllocMeshData meshAlloc) {} // 0x0000000189E8F324-0x0000000189E8F8C0
		private static void TessellateRoundedCorners(ref MeshGenerationContextUtils.RectangleParams rectParams, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E93CA4-0x0000000189E940B4
		private static void TessellateRoundedBorders(ref MeshGenerationContextUtils.BorderParams border, float posZ, MeshWriteData mesh, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E93494-0x0000000189E939C0
		private static void TessellateRoundedCorner(Rect rect, Color32 color, float posZ, Vector2 radius, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E939C0-0x0000000189E93CA4
		private static void TessellateRoundedBorder(Rect rect, Color32 leftColor, Color32 topColor, float posZ, Vector2 radius, float leftWidth, float topWidth, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E92DB0-0x0000000189E93494
		private static Vector2 IntersectLines(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) => default; // 0x0000000189E8EFE4-0x0000000189E8F0D8
		private static int LooseCompare(float a, float b) => default; // 0x0000000189E8F0D8-0x0000000189E8F168
		private static void TessellateComplexBorderCorner(Rect rect, Vector2 radius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E8FD98-0x0000000189E9043C
		private static void TessellateQuad(Rect rect, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E9238C-0x0000000189E92774
		private static void TessellateQuad(Rect rect, Edges smoothedEdges, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E917F0-0x0000000189E918BC
		private static int EdgesCount(Edges edges) => default; // 0x0000000189E8E998-0x0000000189E8E9C8
		private static unsafe void TessellateQuad(Rect rect, Edges smoothedEdges, Vector2* offsets, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E918BC-0x0000000189E9238C
		private static void EncodeStraightArc(ref UnityEngine.UIElements.Vertex v0, ref UnityEngine.UIElements.Vertex v1, ref UnityEngine.UIElements.Vertex center, float radius) {} // 0x0000000189E8E9C8-0x0000000189E8EBB8
		private static void ExpandTriangle(ref Vector3 v0, ref Vector3 v1, Vector3 center, float factor) {} // 0x0000000189E8EBB8-0x0000000189E8ED58
		private static void TessellateQuadSingleEdge(Rect rect, Edges smoothedEdge, Color32 color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E90CB4-0x0000000189E91320
		private static void TessellateStraightBorder(Rect rect, Edges smoothedEdge, float miterOffset, UnityEngine.Color color, float posZ, MeshWriteData mesh, ColorPage colorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E940B4-0x0000000189E94DA8
		private static Vector4 GetInterpolatedCircle(Vector2 p, ref UnityEngine.UIElements.Vertex v0, ref UnityEngine.UIElements.Vertex v1, ref UnityEngine.UIElements.Vertex v2) => default; // 0x0000000189E8EE1C-0x0000000189E8EFE4
		private static void ComputeBarycentricCoordinates(Vector2 p, Vector2 a, Vector2 b, Vector2 c, out float u, out float v, out float w) {
			u = default;
			v = default;
			w = default;
		} // 0x0000000189E8E62C-0x0000000189E8E7B0
		private static void TessellateFilledFan(Vector2 center, Vector2 radius, Vector2 miterOffset, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E9043C-0x0000000189E90CB4
		private static void TessellateBorderedFan(Vector2 center, Vector2 outerRadius, float leftWidth, float topWidth, Color32 leftColor, Color32 topColor, float posZ, MeshWriteData mesh, ColorPage leftColorPage, ColorPage topColorPage, ref ushort vertexCount, ref ushort indexCount, bool countOnly) {} // 0x0000000189E8F8C0-0x0000000189E8FD98
		private static void MirrorVertices(Rect rect, NativeSlice<UnityEngine.UIElements.Vertex> vertices, int vertexStart, int vertexCount, bool flipHorizontal) {} // 0x0000000189E8F168-0x0000000189E8F324
		private static void FlipWinding(NativeSlice<ushort> indices, int indexStart, int indexCount) {} // 0x0000000189E8ED58-0x0000000189E8EE1C
		private static void ComputeUVs(Rect tessellatedRect, Rect textureRect, Rect uvRegion, NativeSlice<UnityEngine.UIElements.Vertex> vertices) {} // 0x0000000189E8E7B0-0x0000000189E8E998
	}

	internal struct TextCoreSettings : IEquatable<TextCoreSettings> // TypeDefIndex: 43923
	{
		// Fields
		public UnityEngine.Color faceColor; // 0x00
		public UnityEngine.Color outlineColor; // 0x10
		public float outlineWidth; // 0x20
		public UnityEngine.Color underlayColor; // 0x24
		public Vector2 underlayOffset; // 0x34
		public float underlaySoftness; // 0x3C
	
		// Methods
		public override bool Equals(object obj) => default; // 0x0000000189E94F0C-0x0000000189E94FA0
		public bool Equals(TextCoreSettings other) => default; // 0x0000000189E94FA0-0x0000000189E950BC
		public override int GetHashCode() => default; // 0x0000000189E950BC-0x0000000189E95164
	}

	internal class TextureBlitter : IDisposable // TypeDefIndex: 43925
	{
		// Fields
		private static readonly int[] k_TextureIds; // 0x00
		private static ProfilerMarker s_CommitSampler; // 0x08
		private BlitInfo[] m_SingleBlit; // 0x10
		private Material m_BlitMaterial; // 0x18
		private MaterialPropertyBlock m_Properties; // 0x20
		private RectInt m_Viewport; // 0x28
		private RenderTexture m_PrevRT; // 0x38
		private List<BlitInfo> m_PendingBlits; // 0x40
	
		// Properties
		protected bool disposed { get; private set; } // 0x0000000183D4EFE0-0x0000000183D4EFF0 0x0000000183D4F010-0x0000000183D4F020
	
		// Nested types
		private struct BlitInfo // TypeDefIndex: 43924
		{
			// Fields
			public Texture src; // 0x00
			public RectInt srcRect; // 0x08
			public Vector2Int dstPos; // 0x18
			public int border; // 0x20
			public UnityEngine.Color tint; // 0x24
		}
	
		// Constructors
		public TextureBlitter() {} // Dummy constructor
		static TextureBlitter() {} // 0x0000000189E95C1C-0x0000000189E95D3C
		public TextureBlitter(int capacity = 512 /* Metadata: 0x01FB60F5 */) {} // 0x0000000189E95D3C-0x0000000189E95DEC
	
		// Methods
		public void Dispose() {} // 0x0000000189E9551C-0x0000000189E9556C
		protected virtual void Dispose(bool disposing) {} // 0x0000000189E9556C-0x0000000189E955D8
		public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, UnityEngine.Color tint) {} // 0x0000000189E95B1C-0x0000000189E95C1C
		public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, UnityEngine.Color tint) {} // 0x0000000189E9536C-0x0000000189E95460
		public void Commit(RenderTexture dst) {} // 0x0000000189E95460-0x0000000189E9551C
		private void BeginBlit(RenderTexture dst) {} // 0x0000000189E95164-0x0000000189E9536C
		private void DoBlit(IList<BlitInfo> blitInfos, int startIndex) {} // 0x0000000189E955D8-0x0000000189E95A80
		private void EndBlit() {} // 0x0000000189E95A80-0x0000000189E95B1C
	}

	internal class TextureSlotManager // TypeDefIndex: 43926
	{
		// Fields
		private static readonly int k_SlotCount; // 0x00
		internal static readonly int[] slotIds; // 0x08
		internal static readonly int textureTableId; // 0x10
		private TextureId[] m_Textures; // 0x10
		private int[] m_Tickets; // 0x18
		private int m_CurrentTicket; // 0x20
		private int m_FirstUsedTicket; // 0x24
		private Vector4[] m_GpuTextures; // 0x28
		internal TextureRegistry textureRegistry; // 0x38
	
		// Properties
		public int FreeSlots { get; private set; } // 0x0000000183D4ED20-0x0000000183D4ED30 0x0000000183D4EE10-0x0000000183D4EE20
	
		// Constructors
		static TextureSlotManager() {} // 0x0000000189E96284-0x0000000189E963EC
		public TextureSlotManager() {} // 0x0000000189E963EC-0x0000000189E96508
	
		// Methods
		public void Reset() {} // 0x0000000189E96130-0x0000000189E9622C
		public void StartNewBatch() {} // 0x0000000189E9622C-0x0000000189E96284
		public int IndexOf(TextureId id) => default; // 0x0000000189E96080-0x0000000189E96130
		public void MarkUsed(int slotIndex) {} // 0x0000000189E88FFC-0x0000000189E89054
		public int FindOldestSlot() => default; // 0x0000000189E95FCC-0x0000000189E96080
		public void Bind(TextureId id, int slot, MaterialPropertyBlock mat) {} // 0x0000000189E95DEC-0x0000000189E95FCC
	}

	internal class VectorImageRenderInfoPool : LinkedPool<VectorImageRenderInfo> // TypeDefIndex: 43928
	{
		// Constructors
		public VectorImageRenderInfoPool() {} // 0x0000000189E9922C-0x0000000189E993F0
	}

	internal class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo> // TypeDefIndex: 43929
	{
		// Fields
		public int useCount; // 0x18
		public GradientRemap firstGradientRemap; // 0x20
		public Alloc gradientSettingsAlloc; // 0x28
	
		// Constructors
		public VectorImageRenderInfo() {} // 0x0000000189E9941C-0x0000000189E996BC
	
		// Methods
		public void Reset() {} // 0x0000000189E993F0-0x0000000189E9941C
	}

	internal class GradientRemapPool : LinkedPool<GradientRemap> // TypeDefIndex: 43931
	{
		// Constructors
		public GradientRemapPool() {} // 0x0000000189E89E48-0x0000000189E8A00C
	}

	internal class GradientRemap : LinkedPoolItem<GradientRemap> // TypeDefIndex: 43932
	{
		// Fields
		public int origIndex; // 0x18
		public int destIndex; // 0x1C
		public RectInt location; // 0x20
		public GradientRemap next; // 0x30
		public TextureId atlas; // 0x38
	
		// Constructors
		public GradientRemap() {} // 0x0000000189E8A068-0x0000000189E8A090
	
		// Methods
		public void Reset() {} // 0x0000000189E8A00C-0x0000000189E8A068
	}

	internal class VectorImageManager : IDisposable // TypeDefIndex: 43933
	{
		// Fields
		public static List<VectorImageManager> instances; // 0x00
		private static ProfilerMarker s_MarkerRegister; // 0x08
		private static ProfilerMarker s_MarkerUnregister; // 0x10
		private readonly AtlasBase m_Atlas; // 0x10
		private Dictionary<VectorImage, VectorImageRenderInfo> m_Registered; // 0x18
		private VectorImageRenderInfoPool m_RenderInfoPool; // 0x20
		private GradientRemapPool m_GradientRemapPool; // 0x28
		private GradientSettingsAtlas m_GradientSettingsAtlas; // 0x30
		private bool m_LoggedExhaustedSettingsAtlas; // 0x38
	
		// Properties
		public Texture2D atlas { get => default; } // 0x0000000189E99218-0x0000000189E9922C 
		protected bool disposed { get; private set; } // 0x0000000183D4F300-0x0000000183D4F310 0x0000000183D4F330-0x0000000183D4F340
	
		// Constructors
		public VectorImageManager() {} // Dummy constructor
		public VectorImageManager(AtlasBase atlas) {} // 0x0000000189E99090-0x0000000189E99218
		static VectorImageManager() {} // 0x0000000189E98F88-0x0000000189E99090
	
		// Methods
		public void Dispose() {} // 0x0000000189E98B64-0x0000000189E98BB4
		protected virtual void Dispose(bool disposing) {} // 0x0000000189E98A5C-0x0000000189E98B64
		public void Commit() {} // 0x0000000189E98A28-0x0000000189E98A5C
		public GradientRemap AddUser(VectorImage vi, VisualElement context) => default; // 0x0000000189E9893C-0x0000000189E98A28
		private VectorImageRenderInfo Register(VectorImage vi, VisualElement context) => default; // 0x0000000189E98BB4-0x0000000189E98F88
	}

	internal enum OwnedState : byte // TypeDefIndex: 43934
	{
		Inherited = 0,
		Owned = 1
	}

	internal struct BMPAlloc // TypeDefIndex: 43935
	{
		// Fields
		public static readonly BMPAlloc Invalid; // 0x00
		public int page; // 0x00
		public ushort pageLine; // 0x04
		public byte bitIndex; // 0x06
		public OwnedState ownedState; // 0x07
	
		// Constructors
		static BMPAlloc() {
			Invalid = default;
		} // 0x0000000189E8917C-0x0000000189E891C8
	
		// Methods
		public bool Equals(BMPAlloc other) => default; // 0x0000000189E89084-0x0000000189E890A4
		public bool IsValid() => default; // 0x0000000189E890A4-0x0000000189E890B0
		public override string ToString() => default; // 0x0000000189E890B0-0x0000000189E8917C
	}

	internal struct BitmapAllocator32 // TypeDefIndex: 43937
	{
		// Fields
		private int m_PageHeight; // 0x00
		private List<Page> m_Pages; // 0x08
		private List<uint> m_AllocMap; // 0x10
		private int m_EntryWidth; // 0x18
		private int m_EntryHeight; // 0x1C
	
		// Properties
		public int entryWidth { get => default; } // 0x0000000183D68AE0-0x0000000183D68AF0 
		public int entryHeight { get => default; } // 0x0000000183D66B90-0x0000000183D66BA0 
	
		// Nested types
		private struct Page // TypeDefIndex: 43936
		{
			// Fields
			public ushort x; // 0x00
			public ushort y; // 0x02
			public int freeSlots; // 0x04
		}
	
		// Methods
		public void Construct(int pageHeight, int entryWidth = 1 /* Metadata: 0x01FB60F9 */, int entryHeight = 1 /* Metadata: 0x01FB60FA */) {} // 0x0000000189E895E4-0x0000000189E89704
		public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY) {} // 0x0000000189E89740-0x0000000189E89810
		public BMPAlloc Allocate(BaseShaderInfoStorage storage) => default; // 0x0000000189E892EC-0x0000000189E895E4
		public void Free(BMPAlloc alloc) {} // 0x0000000189E89810-0x0000000189E89940
		internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y) {
			x = default;
			y = default;
		} // 0x0000000189E89940-0x0000000189E899B8
		private static byte CountTrailingZeroes(uint val) => default; // 0x0000000189E89704-0x0000000189E89740
	}

	internal struct UIRVEShaderInfoAllocator // TypeDefIndex: 43938
	{
		// Fields
		private BaseShaderInfoStorage m_Storage; // 0x00
		private BitmapAllocator32 m_TransformAllocator; // 0x08
		private BitmapAllocator32 m_ClipRectAllocator; // 0x28
		private BitmapAllocator32 m_OpacityAllocator; // 0x48
		private BitmapAllocator32 m_ColorAllocator; // 0x68
		private BitmapAllocator32 m_TextSettingsAllocator; // 0x88
		private bool m_StorageReallyCreated; // 0xA8
		private bool m_VertexTexturingEnabled; // 0xA9
		private NativeArray<Transform3x4> m_Transforms; // 0xB0
		private NativeArray<Vector4> m_ClipRects; // 0xC0
		internal static readonly Vector2Int identityTransformTexel; // 0x00
		internal static readonly Vector2Int infiniteClipRectTexel; // 0x08
		internal static readonly Vector2Int fullOpacityTexel; // 0x10
		internal static readonly Vector2Int clearColorTexel; // 0x18
		internal static readonly Vector2Int defaultTextCoreSettingsTexel; // 0x20
		internal static readonly Matrix4x4 identityTransformValue; // 0x28
		internal static readonly Vector4 identityTransformRow0Value; // 0x68
		internal static readonly Vector4 identityTransformRow1Value; // 0x78
		internal static readonly Vector4 identityTransformRow2Value; // 0x88
		internal static readonly Vector4 infiniteClipRectValue; // 0x98
		internal static readonly Vector4 fullOpacityValue; // 0xA8
		internal static readonly Vector4 clearColorValue; // 0xB8
		internal static readonly TextCoreSettings defaultTextCoreSettingsValue; // 0xC8
		public static readonly BMPAlloc identityTransform; // 0x108
		public static readonly BMPAlloc infiniteClipRect; // 0x110
		public static readonly BMPAlloc fullOpacity; // 0x118
		public static readonly BMPAlloc clearColor; // 0x120
		public static readonly BMPAlloc defaultTextCoreSettings; // 0x128
	
		// Properties
		private static int pageWidth { get => default; } // 0x0000000183D88B80-0x0000000183D88B90 
		private static int pageHeight { get => default; } // 0x0000000183D88B70-0x0000000183D88B80 
		public NativeSlice<Transform3x4> transformConstants { get => default; } // 0x0000000189E988D0-0x0000000189E9893C 
		public NativeSlice<Vector4> clipRectConstants { get => default; } // 0x0000000189E98864-0x0000000189E988D0 
		public Texture atlas { get => default; } // 0x0000000189E987E4-0x0000000189E98864 
	
		// Constructors
		static UIRVEShaderInfoAllocator() {
			identityTransformTexel = default;
			infiniteClipRectTexel = default;
			fullOpacityTexel = default;
			clearColorTexel = default;
			defaultTextCoreSettingsTexel = default;
			identityTransformValue = default;
			identityTransformRow0Value = default;
			identityTransformRow1Value = default;
			identityTransformRow2Value = default;
			infiniteClipRectValue = default;
			fullOpacityValue = default;
			clearColorValue = default;
			defaultTextCoreSettingsValue = default;
			identityTransform = default;
			infiniteClipRect = default;
			fullOpacity = default;
			clearColor = default;
			defaultTextCoreSettings = default;
		} // 0x0000000189E98570-0x0000000189E987E4
	
		// Methods
		private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc) => default; // 0x0000000189E96A78-0x0000000189E96AD8
		private static int AllocToConstantBufferIndex(BMPAlloc alloc) => default; // 0x0000000189E96A28-0x0000000189E96A78
		private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) => default; // 0x0000000189E96BAC-0x0000000189E96C70
		public void Construct() {} // 0x0000000189E96E34-0x0000000189E97134
		private void ReallyCreateStorage() {} // 0x0000000189E97560-0x0000000189E97B84
		public void Dispose() {} // 0x0000000189E97134-0x0000000189E971E0
		public void IssuePendingStorageChanges() {} // 0x0000000189E97478-0x0000000189E9748C
		public BMPAlloc AllocTransform() => default; // 0x0000000189E96AD8-0x0000000189E96BAC
		public BMPAlloc AllocClipRect() => default; // 0x0000000189E96848-0x0000000189E9691C
		public BMPAlloc AllocOpacity() => default; // 0x0000000189E96974-0x0000000189E969CC
		public BMPAlloc AllocColor() => default; // 0x0000000189E9691C-0x0000000189E96974
		public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) => default; // 0x0000000189E969CC-0x0000000189E96A28
		public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) {} // 0x0000000189E98154-0x0000000189E983A8
		public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) {} // 0x0000000189E97B84-0x0000000189E97CAC
		public void SetOpacityValue(BMPAlloc alloc, float opacity) {} // 0x0000000189E97DBC-0x0000000189E97EB8
		public void SetColorValue(BMPAlloc alloc, UnityEngine.Color color, bool isEditorContext) {} // 0x0000000189E97CAC-0x0000000189E97DBC
		public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext) {} // 0x0000000189E97EB8-0x0000000189E98154
		public void FreeTransform(BMPAlloc alloc) {} // 0x0000000189E973F4-0x0000000189E97478
		public void FreeClipRect(BMPAlloc alloc) {} // 0x0000000189E971E0-0x0000000189E97264
		public void FreeOpacity(BMPAlloc alloc) {} // 0x0000000189E972E8-0x0000000189E9736C
		public void FreeColor(BMPAlloc alloc) {} // 0x0000000189E97264-0x0000000189E972E8
		public void FreeTextCoreSettings(BMPAlloc alloc) {} // 0x0000000189E9736C-0x0000000189E973F4
		public Color32 TransformAllocToVertexData(BMPAlloc alloc) => default; // 0x0000000189E98480-0x0000000189E98570
		public Color32 ClipRectAllocToVertexData(BMPAlloc alloc) => default; // 0x0000000189E96C70-0x0000000189E96D60
		public Color32 OpacityAllocToVertexData(BMPAlloc alloc) => default; // 0x0000000189E9748C-0x0000000189E97560
		public Color32 ColorAllocToVertexData(BMPAlloc alloc) => default; // 0x0000000189E96D60-0x0000000189E96E34
		public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) => default; // 0x0000000189E983A8-0x0000000189E98480
	}

	internal struct Transform3x4 // TypeDefIndex: 43939
	{
		// Fields
		public Vector4 v0; // 0x00
		public Vector4 v1; // 0x10
		public Vector4 v2; // 0x20
	}

	internal class MeshHandle : LinkedPoolItem<MeshHandle> // TypeDefIndex: 43940
	{
		// Fields
		internal Alloc allocVerts; // 0x18
		internal Alloc allocIndices; // 0x30
		internal uint triangleCount; // 0x48
		internal UnityEngine.UIElements.UIR.Page allocPage; // 0x50
		internal uint allocTime; // 0x58
		internal uint updateAllocID; // 0x5C
	
		// Constructors
		public MeshHandle() {} // 0x0000000189E9E3B8-0x0000000189E9E3E0
	}

	internal class UIRenderDevice : IDisposable // TypeDefIndex: 43947
	{
		// Fields
		private readonly bool m_MockDevice; // 0x10
		private IntPtr m_DefaultStencilState; // 0x18
		private IntPtr m_VertexDecl; // 0x20
		private UnityEngine.UIElements.UIR.Page m_FirstPage; // 0x28
		private uint m_NextPageVertexCount; // 0x30
		private uint m_LargeMeshVertexCount; // 0x34
		private float m_IndexToVertexCountRatio; // 0x38
		private List<List<AllocToFree>> m_DeferredFrees; // 0x40
		private List<List<AllocToUpdate>> m_Updates; // 0x48
		private uint[] m_Fences; // 0x50
		private MaterialPropertyBlock m_StandardMatProps; // 0x58
		private uint m_FrameIndex; // 0x60
		private uint m_NextUpdateID; // 0x64
		private DrawStatistics m_DrawStats; // 0x68
		private readonly LinkedPool<MeshHandle> m_MeshHandles; // 0x90
		private readonly DrawParams m_DrawParams; // 0x98
		private readonly TextureSlotManager m_TextureSlotManager; // 0xA0
		private static LinkedList<DeviceToFree> m_DeviceFreeQueue; // 0x00
		private static int m_ActiveDeviceCount; // 0x08
		private static bool m_SubscribedToNotifications; // 0x0C
		private static bool m_SynchronousFree; // 0x0D
		private static readonly int s_FontTexPropID; // 0x10
		private static readonly int s_FontTexSDFScaleID; // 0x14
		private static readonly int s_GradientSettingsTexID; // 0x18
		private static readonly int s_ShaderInfoTexID; // 0x1C
		private static readonly int s_TransformsPropID; // 0x20
		private static readonly int s_ClipRectsPropID; // 0x24
		private static readonly int s_ClipSpaceParamsID; // 0x28
		private static ProfilerMarker s_MarkerAllocate; // 0x30
		private static ProfilerMarker s_MarkerFree; // 0x38
		private static ProfilerMarker s_MarkerAdvanceFrame; // 0x40
		private static ProfilerMarker s_MarkerFence; // 0x48
		private static ProfilerMarker s_MarkerBeforeDraw; // 0x50
		private static bool? s_VertexTexturingIsAvailable; // 0x58
		private static bool? s_ShaderModelIs35; // 0x5A
		private static Texture2D s_DefaultShaderInfoTexFloat; // 0x60
		private static Texture2D s_DefaultShaderInfoTexARGB8; // 0x68
	
		// Properties
		internal uint maxVerticesPerPage { get; } // 0x0000000183D51860-0x0000000183D51870 
		internal bool breakBatches { get; set; } // 0x0000000183D5B640-0x0000000183D5B650 0x0000000183D5B670-0x0000000183D5B680
		internal static Texture2D defaultShaderInfoTexFloat { get => default; } // 0x0000000189EA790C-0x0000000189EA7E80 
		internal static Texture2D defaultShaderInfoTexARGB8 { get => default; } // 0x0000000189EA7550-0x0000000189EA790C 
		internal static bool vertexTexturingIsAvailable { get => default; } // 0x0000000189EA801C-0x0000000189EA8400 
		internal static bool shaderModelIs35 { get => default; } // 0x0000000189EA7E80-0x0000000189EA801C 
		private bool fullyCreated { get => default; } // 0x0000000182B84230-0x0000000182B84240 
		protected bool disposed { get; private set; } // 0x0000000183D56770-0x0000000183D56780 0x0000000183D88BC0-0x0000000183D88BD0
	
		// Nested types
		internal struct AllocToUpdate // TypeDefIndex: 43941
		{
			// Fields
			public uint id; // 0x00
			public uint allocTime; // 0x04
			public MeshHandle meshHandle; // 0x08
			public Alloc permAllocVerts; // 0x10
			public Alloc permAllocIndices; // 0x28
			public UnityEngine.UIElements.UIR.Page permPage; // 0x40
			public bool copyBackIndices; // 0x48
		}
	
		private struct AllocToFree // TypeDefIndex: 43942
		{
			// Fields
			public Alloc alloc; // 0x00
			public UnityEngine.UIElements.UIR.Page page; // 0x18
			public bool vertices; // 0x20
		}
	
		private struct DeviceToFree // TypeDefIndex: 43943
		{
			// Fields
			public uint handle; // 0x00
			public UnityEngine.UIElements.UIR.Page page; // 0x08
	
			// Methods
			public void Dispose() {} // 0x0000000189E9DDC8-0x0000000189E9DDFC
		}
	
		private struct EvaluationState // TypeDefIndex: 43944
		{
			// Fields
			public MaterialPropertyBlock stateMatProps; // 0x00
			public Material defaultMat; // 0x08
			public UnityEngine.UIElements.UIR.State curState; // 0x10
			public UnityEngine.UIElements.UIR.Page curPage; // 0x30
			public bool mustApplyMaterial; // 0x38
			public bool mustApplyCommonBlock; // 0x39
			public bool mustApplyStateBlock; // 0x3A
			public bool mustApplyStencil; // 0x3B
		}
	
		internal struct DrawStatistics // TypeDefIndex: 43945
		{
			// Fields
			public int currentFrameIndex; // 0x00
			public uint totalIndices; // 0x04
			public uint commandCount; // 0x08
			public uint drawCommandCount; // 0x0C
			public uint materialSetCount; // 0x10
			public uint drawRangeCount; // 0x14
			public uint drawRangeCallCount; // 0x18
			public uint immediateDraws; // 0x1C
			public uint stencilRefChanges; // 0x20
		}
	
		// Constructors
		public UIRenderDevice() {} // Dummy constructor
		static UIRenderDevice() {} // 0x0000000189EA6C4C-0x0000000189EA6FCC
		public UIRenderDevice(uint initialVertexCapacity = 0 /* Metadata: 0x01FB60FB */, uint initialIndexCapacity = 0 /* Metadata: 0x01FB60FC */) {} // 0x0000000189EA7534-0x0000000189EA7550
		protected UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice) {} // 0x0000000189EA6FCC-0x0000000189EA7534
	
		// Methods
		private void InitVertexDeclaration() {} // 0x0000000189EA537C-0x0000000189EA5510
		private void CompleteCreation() {} // 0x0000000189EA3E88-0x0000000189EA3FA4
		public void Dispose() {} // 0x0000000189EA40F0-0x0000000189EA4140
		protected virtual void Dispose(bool disposing) {} // 0x0000000189EA3FA4-0x0000000189EA40F0
		public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset) {
			vertexData = default;
			indexData = default;
			indexOffset = default;
			return default;
		} // 0x0000000189EA33B0-0x0000000189EA3478
		public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData) {
			vertexData = default;
		} // 0x0000000189EA67C0-0x0000000189EA69BC
		public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset) {
			vertexData = default;
			indexData = default;
			indexOffset = default;
		} // 0x0000000189EA69BC-0x0000000189EA6B9C
		private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) {} // 0x0000000189EA661C-0x0000000189EA6710
		internal List<AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) => default; // 0x0000000189EA27C0-0x0000000189EA2830
		private bool TryAllocFromPage(UnityEngine.UIElements.UIR.Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived) => default; // 0x0000000189EA5E88-0x0000000189EA5FBC
		private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived) {
			vertexData = default;
			indexData = default;
		} // 0x0000000189EA3478-0x0000000189EA3B7C
		private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<UnityEngine.UIElements.Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset, out AllocToUpdate allocToUpdate, bool copyBackIndices) {
			vertexData = default;
			indexData = default;
			indexOffset = default;
			allocToUpdate = default;
		} // 0x0000000189EA5FBC-0x0000000189EA661C
		public void Free(MeshHandle mesh) {} // 0x0000000189EA4CBC-0x0000000189EA52C0
		private static Vector4 GetClipSpaceParams() => default; // 0x0000000189EA52C0-0x0000000189EA537C
		public void OnFrameRenderingBegin() {} // 0x0000000189EA57F8-0x0000000189EA5894
		private static unsafe NativeSlice<T> PtrToSlice<T>(void* p, int count)
			where T : struct => default;
		private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, bool newFontDiffers, ref EvaluationState st) {} // 0x0000000189EA3CC4-0x0000000189EA3E88
		private void ApplyBatchState(ref EvaluationState st, bool allowMaterialChange) {} // 0x0000000189EA3B7C-0x0000000189EA3CC4
		public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, NativeSlice<Transform3x4> transforms, NativeSlice<Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref Exception immediateException) {} // 0x0000000189EA4140-0x0000000189EA4C64
		private void UpdateFenceValue() {} // 0x0000000189EA6710-0x0000000189EA67C0
		private unsafe void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, UnityEngine.UIElements.UIR.Page curPage) {} // 0x0000000189EA5510-0x0000000189EA5760
		private void DrawRanges<I, T>(Utility.GPUBuffer<I> ib, Utility.GPUBuffer<T> vb, NativeSlice<DrawBufferRange> ranges)
			where I : struct
			where T : struct {}
		private void WaitOnCpuFence(uint fence) {} // 0x0000000189EA6B9C-0x0000000189EA6BF8
		public void AdvanceFrame() {} // 0x0000000189EA2830-0x0000000189EA33B0
		private void PruneUnusedPages() {} // 0x0000000189EA5D94-0x0000000189EA5E88
		internal static void PrepareForGfxDeviceRecreate() {} // 0x0000000189EA5894-0x0000000189EA5A1C
		internal static void WrapUpGfxDeviceRecreate() {} // 0x0000000189EA6BF8-0x0000000189EA6C4C
		internal static void FlushAllPendingDeviceDisposes() {} // 0x0000000189EA4C64-0x0000000189EA4CBC
		internal DrawStatistics GatherDrawStatistics() => default; // 0x0000000183D88BA0-0x0000000183D88BC0
		private static void ProcessDeviceFreeQueue() {} // 0x0000000189EA5A1C-0x0000000189EA5D94
		private static void OnEngineUpdateGlobal() {} // 0x0000000189EA5760-0x0000000189EA57A0
		private static void OnFlushPendingResources() {} // 0x0000000189EA57A0-0x0000000189EA57F8
	}

	internal struct Alloc // TypeDefIndex: 43948
	{
		// Fields
		public uint start; // 0x00
		public uint size; // 0x04
		internal object handle; // 0x08
		internal bool shortLived; // 0x10
	}

	internal class BestFitAllocator // TypeDefIndex: 43951
	{
		// Fields
		private Block m_FirstBlock; // 0x18
		private Block m_FirstAvailableBlock; // 0x20
		private BlockPool m_BlockPool; // 0x28
		private uint m_HighWatermark; // 0x30
	
		// Properties
		public uint totalSize { get; } // 0x0000000183D4E340-0x0000000183D4E350 
		public uint highWatermark { get => default; } // 0x0000000183D85A80-0x0000000183D85A90 
	
		// Nested types
		private class BlockPool : LinkedPool<Block> // TypeDefIndex: 43949
		{
			// Constructors
			public BlockPool() {} // 0x0000000189E99E54-0x0000000189E99F38
	
			// Methods
			private static Block CreateBlock() => default; // 0x0000000189E99E04-0x0000000189E99E54
			private static void ResetBlock(Block block) {} // 0x000000018350B670-0x000000018350B680
		}
	
		private class Block : LinkedPoolItem<Block> // TypeDefIndex: 43950
		{
			// Fields
			public uint start; // 0x18
			public uint end; // 0x1C
			public Block prev; // 0x20
			public Block next; // 0x28
			public Block prevAvailable; // 0x30
			public Block nextAvailable; // 0x38
			public bool allocated; // 0x40
	
			// Properties
			public uint size { get => default; } // 0x0000000183D88B90-0x0000000183D88BA0 
	
			// Constructors
			public Block() {} // 0x0000000189E99F38-0x0000000189E99F60
		}
	
		// Constructors
		public BestFitAllocator() {} // Dummy constructor
		public BestFitAllocator(uint size) {} // 0x0000000189E99D44-0x0000000189E99E04
	
		// Methods
		public Alloc Allocate(uint size) => default; // 0x0000000189E996BC-0x0000000189E99880
		public void Free(Alloc alloc) {} // 0x0000000189E999EC-0x0000000189E99BEC
		private Block CoalesceBlockWithPrevious(Block block) => default; // 0x0000000189E998BC-0x0000000189E999EC
		private Block BestFitFindAvailableBlock(uint size) => default; // 0x0000000189E99880-0x0000000189E998BC
		private void SplitBlock(Block block, uint size) {} // 0x0000000189E99BEC-0x0000000189E99D44
	}

	internal class GPUBufferAllocator // TypeDefIndex: 43952
	{
		// Fields
		private BestFitAllocator m_Low; // 0x10
		private BestFitAllocator m_High; // 0x18
	
		// Properties
		public bool isEmpty { get => default; } // 0x0000000189E9E388-0x0000000189E9E3B8 
	
		// Constructors
		public GPUBufferAllocator() {} // Dummy constructor
		public GPUBufferAllocator(uint maxSize) {} // 0x0000000189E9E2E4-0x0000000189E9E388
	
		// Methods
		public Alloc Allocate(uint size, bool shortLived) => default; // 0x0000000189E9E118-0x0000000189E9E234
		public void Free(Alloc alloc) {} // 0x0000000189E9E234-0x0000000189E9E2B0
		private bool HighLowCollide() => default; // 0x0000000189E9E2B0-0x0000000189E9E2E4
	}

	internal class Page : IDisposable // TypeDefIndex: 43954
	{
		// Fields
		public DataSet<UnityEngine.UIElements.Vertex> vertices; // 0x18
		public DataSet<ushort> indices; // 0x20
		public Page next; // 0x28
		public int framesEmpty; // 0x30
	
		// Properties
		protected bool disposed { get; private set; } // 0x00000001811797F0-0x0000000181179800 0x0000000183D4E960-0x0000000183D4E970
		public bool isEmpty { get => default; } // 0x0000000189E9E5FC-0x0000000189E9E658 
	
		// Nested types
		public class DataSet<T> : IDisposable // TypeDefIndex: 43953
			where T : struct
		{
			// Fields
			public Utility.GPUBuffer<T> gpuData;
			public NativeArray<T> cpuData;
			public NativeArray<GfxUpdateBufferRange> updateRanges;
			public GPUBufferAllocator allocator;
			private readonly uint m_UpdateRangePoolSize;
			private uint m_ElemStride;
			private uint m_UpdateRangeMin;
			private uint m_UpdateRangeMax;
			private uint m_UpdateRangesEnqueued;
			private uint m_UpdateRangesBatchStart;
			private bool m_UpdateRangesSaturated;
	
			// Properties
			protected bool disposed { get; private set; }
	
			// Constructors
			public DataSet() {} // Dummy constructor
			public DataSet(Utility.GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize, bool mockBuffer) {}
	
			// Methods
			public void Dispose() {}
			public void Dispose(bool disposing) {}
			public void RegisterUpdate(uint start, uint size) {}
			private bool HasMappedBufferRange() => default;
			public void SendUpdates() {}
			public void SendFullRange() {}
			public void SendPartialRanges() {}
			private void ResetUpdateState() {}
		}
	
		// Constructors
		public Page() {} // Dummy constructor
		public Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage) {} // 0x0000000189E9E4B4-0x0000000189E9E5FC
	
		// Methods
		public void Dispose() {} // 0x0000000189E9E464-0x0000000189E9E4B4
		protected virtual void Dispose(bool disposing) {} // 0x0000000189E9E3E0-0x0000000189E9E464
	}

	internal enum VertexFlags // TypeDefIndex: 43955
	{
		IsSolid = 0,
		IsText = 1,
		IsTextured = 2,
		IsDynamic = 3,
		IsSvgGradients = 4,
		LastType = 10,
		IsGraphViewEdge = 10
	}

	internal struct State // TypeDefIndex: 43956
	{
		// Fields
		public Material material; // 0x00
		public Texture font; // 0x08
		public float fontTexSDFScale; // 0x10
		public TextureId texture; // 0x14
		public int stencilRef; // 0x18
	}

	internal enum CommandType // TypeDefIndex: 43957
	{
		Draw = 0,
		ImmediateCull = 1,
		Immediate = 2,
		PushView = 3,
		PopView = 4,
		PushScissor = 5,
		PopScissor = 6,
		PushRenderTexture = 7,
		PopRenderTexture = 8,
		BlitToPreviousRT = 9,
		PushDefaultMaterial = 10,
		PopDefaultMaterial = 11
	}

	internal class DrawParams // TypeDefIndex: 43958
	{
		// Fields
		internal static readonly Rect k_UnlimitedRect; // 0x00
		internal static readonly Rect k_FullNormalizedRect; // 0x10
		internal readonly Stack<Matrix4x4> view; // 0x10
		internal readonly Stack<Rect> scissor; // 0x18
		internal readonly List<RenderTexture> renderTexture; // 0x20
		internal readonly List<Material> defaultMaterial; // 0x28
	
		// Constructors
		public DrawParams() {} // 0x0000000189E9DFAC-0x0000000189E9E118
		static DrawParams() {} // 0x0000000189E9DF54-0x0000000189E9DFAC
	
		// Methods
		public void Reset() {} // 0x0000000189E9DDFC-0x0000000189E9DF54
	}

	internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand> // TypeDefIndex: 43959
	{
		// Fields
		internal VisualElement owner; // 0x18
		internal RenderChainCommand prev; // 0x20
		internal RenderChainCommand next; // 0x28
		internal bool closing; // 0x30
		internal UnityEngine.UIElements.UIR.CommandType type; // 0x34
		internal UnityEngine.UIElements.UIR.State state; // 0x38
		internal MeshHandle mesh; // 0x58
		internal int indexOffset; // 0x60
		internal int indexCount; // 0x64
		internal Action callback; // 0x68
		private static readonly int k_ID_MainTex; // 0x00
		private static ProfilerMarker s_ImmediateOverheadMarker; // 0x08
	
		// Constructors
		public RenderChainCommand() {} // 0x0000000189E9F724-0x0000000189E9F74C
		static RenderChainCommand() {} // 0x0000000189E9F698-0x0000000189E9F724
	
		// Methods
		internal void Reset() {} // 0x0000000189E9F630-0x0000000189E9F698
		internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException) {} // 0x0000000189E9E8D8-0x0000000189E9F558
		private void Blit(Texture source, RenderTexture destination, float depth) {} // 0x0000000189E9E658-0x0000000189E9E7C8
		private static Rect CombineScissorRects(Rect r0, Rect r1) => default; // 0x0000000189E9E7C8-0x0000000189E9E8D8
		private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) => default; // 0x0000000189E9F558-0x0000000189E9F630
	}
}

namespace UnityEngine.UIElements.UIR.Implementation
{
	internal static class CommandGenerator // TypeDefIndex: 43960
	{
		// Fields
		private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker; // 0x00
		private static readonly ProfilerMarker k_NudgeVerticesMarker; // 0x08
		private static readonly ProfilerMarker k_ComputeTransformMatrixMarker; // 0x10
		private static Material s_blitMaterial_LinearToGamma; // 0x18
		private static Material s_blitMaterial_GammaToLinear; // 0x20
		private static Material s_blitMaterial_NoChange; // 0x28
		private static Shader s_blitShader; // 0x30
	
		// Constructors
		static CommandGenerator() {} // 0x0000000189E9DCF4-0x0000000189E9DDC8
	
		// Methods
		private static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform) {
			transform = default;
		} // 0x0000000189E9B3C0-0x0000000189E9B514
		internal static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, out Matrix4x4 result) {
			result = default;
		} // 0x0000000189E9A0FC-0x0000000189E9A22C
		public static UIRStylePainter.ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ref ChainBuilderStats stats) => default; // 0x0000000189E9BE70-0x0000000189E9D87C
		private static Material CreateBlitShader(float colorConversion) => default; // 0x0000000189E9A82C-0x0000000189E9A9F8
		private static Material GetBlitMaterial(VisualElement.RenderTargetMode mode) => default; // 0x0000000189E9B11C-0x0000000189E9B3C0
		public static void ClosePaintElement(VisualElement ve, UIRStylePainter.ClosingInfo closingInfo, RenderChain renderChain, ref ChainBuilderStats stats) {} // 0x0000000189E99F60-0x0000000189E9A0FC
		private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<UnityEngine.UIElements.Vertex> verts, out NativeSlice<ushort> indices, out ushort indexOffset, ref ChainBuilderStats stats) {
			verts = default;
			indices = default;
			indexOffset = default;
		} // 0x0000000189E9DBE8-0x0000000189E9DCF4
		private static void CopyTransformVertsPos(NativeSlice<UnityEngine.UIElements.Vertex> source, NativeSlice<UnityEngine.UIElements.Vertex> target, Matrix4x4 mat, Color32 xformClipPages, Color32 ids, Color32 addFlags, Color32 opacityPage, Color32 textCoreSettingsPage, bool isText, float textureId) {} // 0x0000000189E9A480-0x0000000189E9A638
		private static void CopyTransformVertsPosAndVec(NativeSlice<UnityEngine.UIElements.Vertex> source, NativeSlice<UnityEngine.UIElements.Vertex> target, Matrix4x4 mat, Color32 xformClipPages, Color32 ids, Color32 addFlags, Color32 opacityPage, Color32 textCoreSettingsPage, bool isText, float textureId) {} // 0x0000000189E9A22C-0x0000000189E9A480
		private static void CopyTriangleIndicesFlipWindingOrder(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset) {} // 0x0000000189E9A638-0x0000000189E9A794
		private static void CopyTriangleIndices(NativeSlice<ushort> source, NativeSlice<ushort> target, int indexOffset) {} // 0x0000000189E9A794-0x0000000189E9A82C
		public static bool NudgeVerticesToNewSpace(VisualElement ve, UIRenderDevice device) => default; // 0x0000000189E9BAB0-0x0000000189E9BE70
		private static void DoNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, ref Matrix4x4 nudgeTransform) {} // 0x0000000189E9A9F8-0x0000000189E9ADB0
		private static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, Texture font, int stencilRef) => default; // 0x0000000189E9B8C8-0x0000000189E9BA20
		private static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, Texture font, int stencilRef) => default; // 0x0000000189E9B65C-0x0000000189E9B7B8
		private static void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) {
			prev = default;
			next = default;
		} // 0x0000000189E9AF30-0x0000000189E9B11C
		private static void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) {
			prev = default;
			next = default;
		} // 0x0000000189E9ADB0-0x0000000189E9AF30
		private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) {} // 0x0000000189E9B7B8-0x0000000189E9B8C8
		private static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) {} // 0x0000000189E9B514-0x0000000189E9B65C
		public static void ResetCommands(RenderChain renderChain, VisualElement ve) {} // 0x0000000189E9D87C-0x0000000189E9DBE8
	
		// Extension methods
		private static bool IsParentOrAncestorOf(this VisualElement ve, VisualElement child) => default; // 0x0000000189E9BA20-0x0000000189E9BAB0
	}

	internal enum ClipMethod // TypeDefIndex: 43961
	{
		Undetermined = 0,
		NotClipped = 1,
		Scissor = 2,
		ShaderDiscard = 3,
		Stencil = 4
	}

	internal static class RenderEvents // TypeDefIndex: 43962
	{
		// Fields
		private static readonly float VisibilityTreshold; // 0x00
	
		// Constructors
		static RenderEvents() {} // 0x0000000189EA26D0-0x0000000189EA270C
	
		// Methods
		internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x0000000189EA1AA4-0x0000000189EA1B94
		internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x0000000189EA1C0C-0x0000000189EA1D04
		internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x0000000189EA1B94-0x0000000189EA1C0C
		internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x0000000189EA1D04-0x0000000189EA1DCC
		internal static void ProcessOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x0000000189EA1DCC-0x0000000189EA1EBC
		internal static void ProcessRegenText(RenderChain renderChain, VisualElement ve, UIRTextUpdatePainter painter, UIRenderDevice device, ref ChainBuilderStats stats) {} // 0x0000000189EA1EBC-0x0000000189EA1F18
		private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve) => default; // 0x0000000189EA151C-0x0000000189EA1674
		private static Vector4 GetClipRectIDClipInfo(VisualElement ve) => default; // 0x0000000189EA12C4-0x0000000189EA14B0
		internal static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState) => default; // 0x0000000189E9F74C-0x0000000189E9FD54
		internal static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve) => default; // 0x0000000189E9FD54-0x0000000189EA030C
		private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats) {} // 0x0000000189EA030C-0x0000000189EA07CC
		private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = false /* Metadata: 0x01FB6115 */) {} // 0x0000000189EA07CC-0x0000000189EA0B44
		private static void OnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats) {} // 0x0000000189EA1980-0x0000000189EA1AA4
		private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats) {} // 0x0000000189EA0B44-0x0000000189EA0EE8
		private static void DepthFirstOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, bool parentHierarchyHidden, bool hierarchical, ref ChainBuilderStats stats) {} // 0x0000000189EA0EE8-0x0000000189EA11D4
		private static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve) => default; // 0x0000000189EA22B0-0x0000000189EA25D0
		private static bool IsElementHierarchyHidden(VisualElement ve) => default; // 0x0000000189EA1920-0x0000000189EA1940
		private static VisualElement GetLastDeepestChild(VisualElement ve) => default; // 0x0000000189EA14B0-0x0000000189EA151C
		private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve) => default; // 0x0000000189EA11D4-0x0000000189EA12C4
		private static bool UpdateLocalFlipsWinding(VisualElement ve) => default; // 0x0000000189EA21F4-0x0000000189EA22B0
		private static void UpdateWorldFlipsWinding(VisualElement ve) {} // 0x0000000189EA25D0-0x0000000189EA2638
		private static void UpdateZeroScaling(VisualElement ve) {} // 0x0000000189EA2638-0x0000000189EA26D0
		private static bool NeedsTransformID(VisualElement ve) => default; // 0x0000000189EA195C-0x0000000189EA1980
		internal static bool NeedsColorID(VisualElement ve) => default; // 0x0000000189EA1940-0x0000000189EA195C
		private static bool InitColorIDs(RenderChain renderChain, VisualElement ve) => default; // 0x0000000189EA1674-0x0000000189EA1920
		private static void SetColorValues(RenderChain renderChain, VisualElement ve) {} // 0x0000000189EA1F18-0x0000000189EA21F4
	}

	internal class UIRStylePainter : IStylePainter, IDisposable // TypeDefIndex: 43966
	{
		// Fields
		private RenderChain m_Owner; // 0x10
		private List<Entry> m_Entries; // 0x18
		private AtlasBase m_Atlas; // 0x20
		private VectorImageManager m_VectorImageManager; // 0x28
		private Entry m_CurrentEntry; // 0x30
		private ClosingInfo m_ClosingInfo; // 0x90
		private int m_MaskDepth; // 0xC8
		private int m_StencilRef; // 0xCC
		private BMPAlloc m_ClipRectID; // 0xD0
		private int m_SVGBackgroundEntryIndex; // 0xD8
		private TempDataAlloc<UnityEngine.UIElements.Vertex> m_VertsPool; // 0xE0
		private TempDataAlloc<ushort> m_IndicesPool; // 0x108
		private List<MeshWriteData> m_MeshWriteDataPool; // 0x130
		private int m_NextMeshWriteDataPoolItem; // 0x138
		private MeshBuilder.AllocMeshData.Allocator m_AllocRawVertsIndicesDelegate; // 0x140
		private MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawMeshDelegate; // 0x148
		private MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawGradientsDelegate; // 0x150
	
		// Properties
		public MeshGenerationContext meshGenerationContext { get; } // 0x0000000183D570A0-0x0000000183D570B0 
		public VisualElement currentElement { get; private set; } // 0x0000000183D570E0-0x0000000183D570F0 0x00000001858B3C90-0x00000001858B3CA4
		public List<Entry> entries { get => default; } // 0x0000000183D61D00-0x0000000183D61D10 
		public ClosingInfo closingInfo { get => default; } // 0x0000000183D88C10-0x0000000183D88C50 
		public int totalVertices { get; private set; } // 0x0000000183D4FCB0-0x0000000183D4FCC0 0x0000000183D4FCC0-0x0000000183D4FCD0
		public int totalIndices { get; private set; } // 0x0000000183D5A800-0x0000000183D5A810 0x0000000183D5A870-0x0000000183D5A880
		protected bool disposed { get; private set; } // 0x0000000183D57C60-0x0000000183D57C70 0x0000000183D6DF80-0x0000000183D6DF90
		public VisualElement visualElement { get => default; } // 0x0000000183D88C50-0x0000000183D88C60 
	
		// Nested types
		internal struct Entry // TypeDefIndex: 43963
		{
			// Fields
			public NativeSlice<UnityEngine.UIElements.Vertex> vertices; // 0x00
			public NativeSlice<ushort> indices; // 0x10
			public Material material; // 0x20
			public Texture custom; // 0x28
			public Texture font; // 0x30
			public float fontTexSDFScale; // 0x38
			public TextureId texture; // 0x3C
			public RenderChainCommand customCommand; // 0x40
			public BMPAlloc clipRectID; // 0x48
			public VertexFlags addFlags; // 0x50
			public bool uvIsDisplacement; // 0x54
			public bool isTextEntry; // 0x55
			public bool isClipRegisterEntry; // 0x56
			public int stencilRef; // 0x58
			public int maskDepth; // 0x5C
		}
	
		internal struct ClosingInfo // TypeDefIndex: 43964
		{
			// Fields
			public bool needsClosing; // 0x00
			public bool popViewMatrix; // 0x01
			public bool popScissorClip; // 0x02
			public bool blitAndPopRenderTexture; // 0x03
			public bool PopDefaultMaterial; // 0x04
			public RenderChainCommand clipUnregisterDrawCommand; // 0x08
			public NativeSlice<UnityEngine.UIElements.Vertex> clipperRegisterVertices; // 0x10
			public NativeSlice<ushort> clipperRegisterIndices; // 0x20
			public int clipperRegisterIndexOffset; // 0x30
			public int maskStencilRef; // 0x34
		}
	
		internal struct TempDataAlloc<T> : IDisposable // TypeDefIndex: 43965
			where T : struct
		{
			// Fields
			private int maxPoolElemCount;
			private NativeArray<T> pool;
			private List<NativeArray<T>> excess;
			private uint takenFromPool;
	
			// Constructors
			public TempDataAlloc(int maxPoolElems) {
				maxPoolElemCount = default;
				pool = default;
				excess = default;
				takenFromPool = default;
			}
	
			// Methods
			public void Dispose() {}
			internal NativeSlice<T> Alloc(uint count) => default;
			internal void SessionDone() {}
		}
	
		// Constructors
		public UIRStylePainter() {} // Dummy constructor
		public UIRStylePainter(RenderChain renderChain) {} // 0x0000000189EB9FB4-0x0000000189EBA368
	
		// Methods
		private MeshWriteData GetPooledMeshWriteData() => default; // 0x0000000189EB99B8-0x0000000189EB9A7C
		private MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData) => default; // 0x0000000189EB5224-0x0000000189EB5304
		private MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData) => default; // 0x0000000189EB5330-0x0000000189EB535C
		private MeshWriteData AllocThroughDrawGradients(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData) => default; // 0x0000000189EB5304-0x0000000189EB5330
		public void Dispose() {} // 0x0000000189EB5C04-0x0000000189EB5C54
		protected void Dispose(bool disposing) {} // 0x0000000189EB5C54-0x0000000189EB5CD4
		public void Begin(VisualElement ve) {} // 0x0000000189EB57D0-0x0000000189EB5C04
		public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd) {} // 0x0000000189EB9B14-0x0000000189EB9B84
		public void LandClipRegisterMesh(NativeSlice<UnityEngine.UIElements.Vertex> vertices, NativeSlice<ushort> indices, int indexOffset) {} // 0x0000000189EB9A7C-0x0000000189EB9B14
		public MeshWriteData AddGradientsEntry(int vertexCount, int indexCount, TextureId texture, Material material, MeshGenerationContext.MeshFlags flags) => default; // 0x0000000189EB4C64-0x0000000189EB4F00
		public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags) => default; // 0x0000000189EB5FB8-0x0000000189EB63EC
		public void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint) {} // 0x0000000189EB7B70-0x0000000189EB7CBC
		internal void DrawTextNative(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint) {} // 0x0000000189EB754C-0x0000000189EB7B70
		internal void DrawTextCore(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint) {} // 0x0000000189EB701C-0x0000000189EB754C
		public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams) {} // 0x0000000189EB63EC-0x0000000189EB6AB0
		public void DrawBorder(MeshGenerationContextUtils.BorderParams borderParams) {} // 0x0000000189EB5CD4-0x0000000189EB5E9C
		public void DrawImmediate(Action callback, bool cullingEnabled) {} // 0x0000000189EB5E9C-0x0000000189EB5FB8
		public void DrawVisualElementBackground() {} // 0x0000000189EB81A8-0x0000000189EB8C10
		public void DrawVisualElementBorder() {} // 0x0000000189EB8C10-0x0000000189EB9100
		public void ApplyVisualElementClipping() {} // 0x0000000189EB55E8-0x0000000189EB57D0
		private ushort[] AdjustSpriteWinding(Vector2[] vertices, ushort[] indices) => default; // 0x0000000189EB4F00-0x0000000189EB5224
		public void DrawSprite(MeshGenerationContextUtils.RectangleParams rectParams) {} // 0x0000000189EB6AB0-0x0000000189EB701C
		private void ApplyInset(ref MeshGenerationContextUtils.RectangleParams rectParams, Texture tex) {} // 0x0000000189EB535C-0x0000000189EB55E8
		public void DrawVectorImage(MeshGenerationContextUtils.RectangleParams rectParams) {} // 0x0000000189EB7CBC-0x0000000189EB81A8
		internal void Reset() {} // 0x0000000189EB9B84-0x0000000189EB9C74
		private void ValidateMeshWriteData() {} // 0x0000000189EB9C74-0x0000000189EB9FB4
		private void GenerateStencilClipEntryForRoundedRectBackground() {} // 0x0000000189EB9100-0x0000000189EB9740
		private void GenerateStencilClipEntryForSVGBackground() {} // 0x0000000189EB9740-0x0000000189EB99B8
	}

	internal class UIRTextUpdatePainter : IStylePainter, IDisposable // TypeDefIndex: 43967
	{
		// Fields
		private VisualElement m_CurrentElement; // 0x10
		private int m_TextEntryIndex; // 0x18
		private NativeArray<UnityEngine.UIElements.Vertex> m_DudVerts; // 0x20
		private NativeArray<ushort> m_DudIndices; // 0x30
		private NativeSlice<UnityEngine.UIElements.Vertex> m_MeshDataVerts; // 0x40
		private Color32 m_XFormClipPages; // 0x50
		private Color32 m_IDs; // 0x54
		private Color32 m_Flags; // 0x58
		private Color32 m_OpacityColorPages; // 0x5C
	
		// Properties
		public MeshGenerationContext meshGenerationContext { get; } // 0x0000000183D4EB00-0x0000000183D4EB10 
	
		// Constructors
		public UIRTextUpdatePainter() {} // 0x0000000189EBACC8-0x0000000189EBAD30
	
		// Methods
		public void Begin(VisualElement ve, UIRenderDevice device) {} // 0x0000000189EBA368-0x0000000189EBA5F0
		public void End() {} // 0x0000000189EBAC38-0x0000000189EBACC8
		public void Dispose() {} // 0x0000000189EBA5F0-0x0000000189EBA670
		public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams) {} // 0x000000018350B670-0x000000018350B680
		public void DrawImmediate(Action callback, bool cullingEnabled) {} // 0x000000018350B670-0x000000018350B680
		public void DrawText(MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint) {} // 0x0000000189EBA670-0x0000000189EBAC38
	}
}
