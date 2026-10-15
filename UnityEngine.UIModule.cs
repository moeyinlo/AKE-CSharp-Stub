/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

// Image 100: UnityEngine.UIModule.dll - Assembly: UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90585-90607

namespace UnityEngine
{
	public interface ICanvasRaycastFilter // TypeDefIndex: 90586
	{
		// Methods
		bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
	}

	[NativeClass("UI::CanvasGroup")]
	[NativeHeader("Modules/UI/CanvasGroup.h")]
	public sealed class CanvasGroup : UnityEngine.Behaviour, ICanvasRaycastFilter // TypeDefIndex: 90587
	{
		// Properties
		[NativeProperty("Color", false, UnityEngine.Bindings.TargetType.Function)]
		public UnityEngine.Color color { get; set; } // 0x00000001857E42F0-0x00000001857E4320 0x0000000187837B18-0x0000000187837B2C
		[NativeProperty("Alpha", false, UnityEngine.Bindings.TargetType.Function)]
		public float alpha { get; set; } // 0x00000001857A3710-0x00000001857A3750 0x0000000185359A20-0x0000000185359A70
		[NativeProperty("Interactable", false, UnityEngine.Bindings.TargetType.Function)]
		public bool interactable { get; set; } // 0x00000001851C77C0-0x00000001851C7800 0x0000000186779E50-0x0000000186779EA0
		[NativeProperty("BlocksRaycasts", false, UnityEngine.Bindings.TargetType.Function)]
		public bool blocksRaycasts { get; set; } // 0x00000001861A1F40-0x00000001861A1F80 0x0000000186779FC0-0x000000018677A010
		[NativeProperty("IgnoreParentGroups", false, UnityEngine.Bindings.TargetType.Function)]
		public bool ignoreParentGroups { get; set; } // 0x00000001851C7800-0x00000001851C7840 0x000000018D691FD0-0x000000018D692014
	
		// Constructors
		public CanvasGroup(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera); // 0x0000000187835B10-0x0000000187835B1C
		private void get_color_Injected(out UnityEngine.Color ret); // 0x00000001857E4320-0x00000001857E4370
		private void set_color_Injected(ref UnityEngine.Color value); // 0x00000001850D0820-0x00000001850D0870
	}

	[NativeClass("UI::CanvasRenderer")]
	[NativeHeader("Modules/UI/CanvasRenderer.h")]
	public sealed class CanvasRenderer : Component // TypeDefIndex: 90592
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool _isMask_k__BackingField; // 0x18
	
		// Properties
		public bool hasPopInstruction { set; } // 0x00000001852DF970-0x00000001852DF9C0
		public int materialCount { get; set; } // 0x0000000185A08AD0-0x0000000185A08B10 0x00000001852E3850-0x00000001852E38A0
		public int popMaterialCount { set; } // 0x00000001852DF9C0-0x00000001852DFA10
		public int absoluteDepth { get; } // 0x0000000185148610-0x0000000185148650 
		public bool hasMoved { get; } // 0x000000018D6922BC-0x000000018D6922F0 
		public bool cullTransparentMesh { get; set; } // 0x00000001862A50F0-0x00000001862A5130 0x0000000186B24DB0-0x0000000186B24E00
		[NativeProperty("ShouldCull", false, UnityEngine.Bindings.TargetType.Function)]
		public bool cull { get; set; } // 0x00000001851485D0-0x0000000185148610 0x0000000185044AA0-0x0000000185044AF0
		public Vector2 clippingSoftness { set; } // 0x0000000187834D44-0x0000000187834D60
		public Vector4 clippingHGSoftness { set; } // 0x0000000187834D30-0x0000000187834D44
	
		// Nested types
		public enum HGFillMethod // TypeDefIndex: 90588
		{
			Horizontal = 0,
			Vertical = 1,
			Radial90 = 2,
			Radial180 = 3,
			Radial360 = 4
		}
	
		public enum HGImageType // TypeDefIndex: 90589
		{
			Simple = 0,
			Sliced = 1,
			Tiled = 2,
			Filled = 3,
			Mirror = 4,
			MirrorQuarter = 5
		}
	
		[NativeHeader("Modules/UI/HGUI/HGImage.h")]
		[NativeType(CodegenOptions.Custom, "HyperGryph::HGImageData")]
		public struct HGImageData // TypeDefIndex: 90590
		{
			// Fields
			public HGImageType type; // 0x00
			public HGFillMethod fillMethod; // 0x04
			public float fillAmount; // 0x08
			public int fillOrigin; // 0x0C
			public float pixelsPerUnit; // 0x10
			public float pixelsPerUnitMultiplier; // 0x14
			public Color32 color; // 0x18
			public bool preserveAspect; // 0x1C
			public bool fillCenter; // 0x1D
			public bool fillClockwise; // 0x1E
		}
	
		public struct InstanceRange // TypeDefIndex: 90591
		{
			// Fields
			public ushort start; // 0x00
			public ushort end; // 0x02
		}
	
		// Methods
		public void SetColor(UnityEngine.Color color); // 0x0000000186199ED0-0x0000000186199F20
		public UnityEngine.Color GetColor(); // 0x0000000185576C50-0x0000000185576CB0
		public void EnableRectClipping(Rect rect); // 0x000000018783A0E0-0x000000018783A0F4
		public void DisableRectClipping(); // 0x0000000185CEADB0-0x0000000185CEADF0
		public void SetMaterial(Material material, int index); // 0x00000001852E38A0-0x00000001852E3900
		public Material GetMaterial(int index); // 0x000000018D6920F8-0x000000018D692138
		public void SetPopMaterial(Material material, int index); // 0x00000001852DF2C0-0x00000001852DF320
		public void SetTexture(Texture texture); // 0x00000001852E3800-0x00000001852E3850
		public void SetAlphaTexture(Texture texture); // 0x00000001861A1320-0x00000001861A1370
		public void SetMesh(Mesh mesh); // 0x00000001856C0720-0x00000001856C0770
		public void Clear(); // 0x00000001850FEBE0-0x00000001850FEC20
		public void SetImageMeshRebuildData(HGImageData imageData, Sprite sprite, Rect adjustedRect); // 0x000000018D692190-0x000000018D6921A8
		public void SetAlpha(float alpha); // 0x000000018D692138-0x000000018D692190
		public float GetInheritedAlpha(); // 0x0000000185140550-0x0000000185140590
		public void SetMaterial(Material material, Texture texture); // 0x0000000185A08A20-0x0000000185A08AD0
		public Material GetMaterial(); // 0x000000018D6920EC-0x000000018D6920F8
		public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices); // 0x000000018D692250-0x000000018D6922BC
		public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices); // 0x000000018D692088-0x000000018D6920EC
		public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents); // 0x000000018D692014-0x000000018D692024
		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		private static void SplitIndicesStreamsInternal(object verts, object indices); // 0x000000018D6921A8-0x000000018D6921EC
		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents); // 0x000000018D6921EC-0x000000018D692250
		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices); // 0x000000018D692024-0x000000018D692088
		private unsafe void UpdateInstanceRange(uint rangeCount, void* ranges); // 0x000000018544BF30-0x000000018544BF90
		public void UpdateInstanceRange(uint rangeCount, NativeArray<InstanceRange> rangers); // 0x000000018544BED0-0x000000018544BF30
		private unsafe void* BeginInstanceBufferWrite(uint count, uint stride); // 0x0000000185F2B4A0-0x0000000185F2B500
		private unsafe void* BeginPrefabBufferWrite(uint count, uint stride); // 0x000000018682B580-0x000000018682B5E0
		public void EndInstanceBufferWrite(); // 0x0000000185447B60-0x0000000185447BA0
		public void EndPrefabBufferWrite(); // 0x000000018697DBE0-0x000000018697DC20
		public NativeArray<T> BeginInstanceDataWrite<T>(int count)
			where T : struct;
		public NativeArray<T> BeginPrefabBufferWrite<T>(int count)
			where T : struct;
		public void EnableInstance(); // 0x00000001867DD450-0x00000001867DD490
		private void SetColor_Injected(ref UnityEngine.Color color); // 0x0000000186199F20-0x0000000186199F70
		private void GetColor_Injected(out UnityEngine.Color ret); // 0x0000000185576CB0-0x0000000185576D00
		private void EnableRectClipping_Injected(ref Rect rect); // 0x0000000185CEADF0-0x0000000185CEAE40
		private void set_clippingSoftness_Injected(ref Vector2 value); // 0x0000000185B6BC30-0x0000000185B6BC80
		private void set_clippingHGSoftness_Injected(ref Vector4 value); // 0x0000000185B6BC80-0x0000000185B6BCD0
		private void SetImageMeshRebuildData_Injected(ref HGImageData imageData, Sprite sprite, ref Rect adjustedRect); // 0x00000001864486B0-0x0000000186448720
	}

	[NativeHeader("Runtime/Transform/RectTransform.h")]
	[NativeHeader("Modules/UI/RectTransformUtil.h")]
	[NativeHeader("Modules/UI/Canvas.h")]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
	public sealed class RectTransformUtility // TypeDefIndex: 90593
	{
		// Fields
		private static readonly Vector3[] s_Corners; // 0x00
	
		// Constructors
		private RectTransformUtility(); // 0x0000000186805BA0-0x0000000186805BB0
		static RectTransformUtility(); // 0x00000001871DAC50-0x00000001871DACC0
	
		// Methods
		public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas); // 0x000000018D6934BC-0x000000018D693530
		public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas); // 0x000000018D693584-0x000000018D6935F0
		private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset); // 0x0000000185147AF0-0x0000000185147B70
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint); // 0x000000018D6935F0-0x000000018D693648
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam); // 0x0000000185F2C880-0x0000000185F2C920
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset); // 0x0000000185147A40-0x0000000185147AF0
		public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint); // 0x000000018550F140-0x000000018550F790
		public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint); // 0x000000018550EE20-0x000000018550EF20
		public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos); // 0x000000018550F820-0x000000018550F9D0
		public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint); // 0x00000001856BC610-0x00000001856BC700
		public static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child); // 0x000000018D692BE4-0x000000018D692F84
		public static Bounds CalculateRelativeRectTransformBounds(Transform trans); // 0x000000018D692F84-0x000000018D692FFC
		public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive); // 0x000000018D693214-0x000000018D693458
		public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive); // 0x000000018D692FFC-0x000000018D693214
		private static Vector2 GetTransposed(Vector2 input); // 0x0000000187263D90-0x0000000187263DB0
		private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret); // 0x000000018D693458-0x000000018D6934BC
		private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret); // 0x000000018D693530-0x000000018D693584
		private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset); // 0x0000000185147B70-0x0000000185147BE0
	}

	public enum RenderMode // TypeDefIndex: 90594
	{
		ScreenSpaceOverlay = 0,
		ScreenSpaceCamera = 1,
		WorldSpace = 2
	}

	[Flags]
	public enum AdditionalCanvasShaderChannels // TypeDefIndex: 90595
	{
		None = 0,
		TexCoord1 = 1,
		TexCoord2 = 2,
		TexCoord3 = 4,
		Normal = 8,
		Tangent = 16
	}

	[NativeClass("UI::Canvas")]
	[NativeHeader("Modules/UI/UIStructs.h")]
	[NativeHeader("Modules/UI/Canvas.h")]
	[NativeHeader("Modules/UI/CanvasManager.h")]
	[RequireComponent(typeof(RectTransform))]
	public sealed class Canvas : UnityEngine.Behaviour // TypeDefIndex: 90597
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static WillRenderCanvases preWillRenderCanvases; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static WillRenderCanvases willRenderCanvases; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<int> _externBeginRenderOverlays_k__BackingField; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<int, int> _externRenderOverlaysBefore_k__BackingField; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<int> _externEndRenderOverlays_k__BackingField; // 0x20
	
		// Properties
		public UnityEngine.RenderMode renderMode { get; set; } // 0x00000001850BDED0-0x00000001850BDF10 0x0000000186557BC0-0x0000000186557C10
		public bool isRootCanvas { get; } // 0x00000001850BDE90-0x00000001850BDED0 
		public Rect pixelRect { get; } // 0x000000018D6926D8-0x000000018D692704 
		public float scaleFactor { get; set; } // 0x000000018569E7B0-0x000000018569E860 0x000000018676A3C0-0x000000018676A410
		public float referencePixelsPerUnit { get; set; } // 0x0000000185D80B70-0x0000000185D80BB0 0x000000018D692A58-0x000000018D692A9C
		public bool overridePixelPerfect { get; set; } // 0x000000018D692660-0x000000018D692694 0x000000018D6929D0-0x000000018D692A14
		public bool vertexColorAlwaysGammaSpace { get; set; } // 0x000000018D6927D4-0x000000018D692808 0x000000018D692BA0-0x000000018D692BE4
		public bool pixelPerfect { get; set; } // 0x0000000185E76C70-0x0000000185E76CB0 0x000000018D692A14-0x000000018D692A58
		public float planeDistance { get; set; } // 0x000000018D692704-0x000000018D692738 0x0000000186554A10-0x0000000186554B80
		public int renderOrder { get; } // 0x000000018D692738-0x000000018D69276C 
		public bool overrideSorting { get; set; } // 0x00000001852E16B0-0x00000001852E16F0 0x000000018531D6A0-0x000000018531D6F0
		public int sortingOrder { get; set; } // 0x000000018531E270-0x000000018531E2B0 0x000000018531D650-0x000000018531D6A0
		public int targetDisplay { get; set; } // 0x00000001850BEE00-0x00000001850BEE40 0x000000018D692B60-0x000000018D692BA0
		public int sortingLayerID { get; set; } // 0x000000018616F8C0-0x000000018616F900 0x000000018D692ADC-0x000000018D692B1C
		public int cachedSortingLayerValue { get; } // 0x000000018D6924E8-0x000000018D69251C 
		public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; } // 0x00000001862A50B0-0x00000001862A50F0 0x000000018709C940-0x000000018709C990
		public string sortingLayerName { get; set; } // 0x000000018D6927A0-0x000000018D6927D4 0x000000018D692B1C-0x000000018D692B60
		public Canvas rootCanvas { get; } // 0x00000001851472C0-0x0000000185147300 
		public Vector2 renderingDisplaySize { get; } // 0x00000001850BEE40-0x00000001850BEE90 
		public bool doCPUFrameInterpolation { get; set; } // 0x000000018D69251C-0x000000018D692550 0x000000018D692808-0x000000018D69284C
		public bool joinGPUFrameInterpolation { get; set; } // 0x000000018D6925F8-0x000000018D69262C 0x000000018D692948-0x000000018D69298C
		internal static Action<int> externBeginRenderOverlays { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D692550-0x000000018D692588 0x000000018D69284C-0x000000018D6928A0
		internal static Action<int, int> externRenderOverlaysBefore { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D6925C0-0x000000018D6925F8 0x000000018D6928F4-0x000000018D692948
		internal static Action<int> externEndRenderOverlays { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018D692588-0x000000018D6925C0 0x000000018D6928A0-0x000000018D6928F4
		[NativeProperty("Camera", false, UnityEngine.Bindings.TargetType.Function)]
		public Camera worldCamera { get; set; } // 0x00000001850FC0B0-0x00000001850FC0F0 0x00000001863F6D80-0x00000001863F6DD0
		[NativeProperty("SortingBucketNormalizedSize", false, UnityEngine.Bindings.TargetType.Function)]
		public float normalizedSortingGridSize { get; set; } // 0x000000018D69262C-0x000000018D692660 0x000000018D69298C-0x000000018D6929D0
		[NativeProperty("SortingBucketNormalizedSize", false, UnityEngine.Bindings.TargetType.Function)]
		[Obsolete("Setting normalizedSize via a int is not supported. Please use normalizedSortingGridSize", false)]
		public int sortingGridNormalizedSize { get; set; } // 0x000000018D69276C-0x000000018D6927A0 0x000000018D692A9C-0x000000018D692ADC
	
		// Events
		public static event WillRenderCanvases preWillRenderCanvases {
			add; // 0x000000018527B9D0-0x000000018527BA60
			remove; // 0x000000018527B8C0-0x000000018527B950
		}
		public static event WillRenderCanvases willRenderCanvases {
			add; // 0x000000018527D240-0x000000018527D300
			remove; // 0x000000018527C6A0-0x000000018527C760
		}
	
		// Nested types
		public delegate void WillRenderCanvases(); // TypeDefIndex: 90596; 0x0000000185B44B70-0x0000000185B44B80
	
		// Constructors
		public Canvas(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
		internal static void SetExternalCanvasEnabled(bool enabled); // 0x000000018D692470-0x000000018D6924A4
		[FreeFunction("UI::GetDefaultUIMaterial")]
		[Obsolete("Shared default material now used for text and general UI elements, call Canvas.GetDefaultCanvasMaterial()", false)]
		public static Material GetDefaultCanvasTextMaterial(); // 0x000000018D6923BC-0x000000018D6923E8
		[FreeFunction("UI::GetDefaultUIMaterial")]
		public static Material GetDefaultCanvasMaterial(); // 0x000000018D692390-0x000000018D6923BC
		[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
		public static Material GetETC1SupportedCanvasMaterial(); // 0x000000018D6923E8-0x000000018D692414
		internal void UpdateCanvasRectTransform(bool alignWithCamera); // 0x000000018D6924A4-0x000000018D6924E8
		public static void ForceUpdateCanvases(); // 0x00000001859E1730-0x00000001859E1750
		[RequiredByNativeCode]
		private static void SendPreWillRenderCanvases(); // 0x00000001859E2D40-0x00000001859E2D60
		[RequiredByNativeCode]
		private static void SendWillRenderCanvases(); // 0x00000001859E2D60-0x00000001859E3080
		[RequiredByNativeCode]
		private static void BeginRenderExtraOverlays(int displayIndex); // 0x000000018D6922F0-0x000000018D692340
		[RequiredByNativeCode]
		private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder); // 0x000000018D692414-0x000000018D692470
		[RequiredByNativeCode]
		private static void EndRenderExtraOverlays(int displayIndex); // 0x000000018D692340-0x000000018D692390
		private void get_pixelRect_Injected(out Rect ret); // 0x000000018D692694-0x000000018D6926D8
		private void get_renderingDisplaySize_Injected(out Vector2 ret); // 0x00000001850BEF10-0x00000001850BEF60
	}

	[NativeHeader("Modules/UI/Canvas.h")]
	[StaticAccessor("UI::SystemProfilerApi", StaticAccessorType.DoubleColon)]
	public static class UISystemProfilerApi // TypeDefIndex: 90599
	{
		// Nested types
		public enum SampleType // TypeDefIndex: 90598
		{
			Layout = 0,
			Render = 1
		}
	
		// Methods
		public static void BeginSample(SampleType type); // 0x00000001851C1380-0x00000001851C13C0
		public static void EndSample(SampleType type); // 0x00000001851C1340-0x00000001851C1380
		public static void AddMarker(string name, UnityEngine.Object obj); // 0x0000000185044AF0-0x0000000185044B40
	}
}

namespace UnityEngine.UI
{
	[NativeHeader("Modules/UI/HGUI/HGRectMaskClipping.h")]
	public static class HGRectMaskClippingBindings // TypeDefIndex: 90605
	{
		// Properties
		public static bool EnableRectMaskOpt { get; } // 0x000000018783D444-0x000000018783D450 
	
		// Nested types
		public struct HGRectMaskInput // TypeDefIndex: 90600
		{
			// Fields
			public int maskRTInstanceID; // 0x00
			public int rootCanvasInstanceID; // 0x04
			public int renderMode; // 0x08
			public int clipperOffset; // 0x0C
			public int clipperCount; // 0x10
			public int targetOffset; // 0x14
			public int targetCount; // 0x18
			public Rect lastClipRect; // 0x1C
			public int forceClip; // 0x2C
		}
	
		public struct HGClipperInput // TypeDefIndex: 90601
		{
			// Fields
			public int rtInstanceID; // 0x00
			public int canvasInstanceID; // 0x04
			public Vector4 padding; // 0x08
		}
	
		public struct HGClipTargetInput // TypeDefIndex: 90602
		{
			// Fields
			public int rtInstanceID; // 0x00
			public int canvasRendererInstanceID; // 0x04
		}
	
		public struct HGRectMaskOutput // TypeDefIndex: 90603
		{
			// Fields
			public Rect clipRect; // 0x00
			public int validRect; // 0x10
			public int maskIsCulled; // 0x14
		}
	
		public struct HGClipTargetOutput // TypeDefIndex: 90604
		{
			// Fields
			public int shouldCull; // 0x00
			public int cullStateChanged; // 0x04
		}
	
		// Methods
		[FreeFunction("HyperGryph::BatchComputeRectMaskClipping")]
		public static unsafe void BatchComputeRectMaskClipping(void* maskInputs, int maskCount, void* clipperInputs, int clipperCount, void* targetInputs, int targetCount, void* maskOutputs, void* targetOutputs); // 0x000000018613AAE0-0x000000018613AB50
		[FreeFunction("HyperGryph::HGGetRectMaskOptEnabled")]
		private static bool GetEnableRectMaskOpt(); // 0x00000001872220B0-0x00000001872220F0
	}

	[NativeHeader("Modules/UI/HGUI/HGRectMaskClipping.h")]
	public static class HGImageBatchBindings // TypeDefIndex: 90607
	{
		// Properties
		public static bool EnableImageOpt { get; } // 0x000000018783D450-0x000000018783D45C 
	
		// Nested types
		public struct HGBatchImageInput // TypeDefIndex: 90606
		{
			// Fields
			public int canvasRendererInstanceID; // 0x00
			public int spriteInstanceID; // 0x04
			public Rect adjustedRect; // 0x08
			public CanvasRenderer.HGImageData imageData; // 0x18
		}
	
		// Methods
		[FreeFunction("HyperGryph::BatchSetImageMeshRebuildData")]
		public static unsafe void BatchSetImageMeshRebuildData(void* inputs, int count); // 0x00000001851C03D0-0x00000001851C0740
		[FreeFunction("HyperGryph::HGGetImageOptEnabled")]
		private static bool GetEnableImageOpt(); // 0x0000000187222130-0x0000000187222170
	}
}
