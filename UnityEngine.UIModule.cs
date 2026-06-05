/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using Unity.Collections;

// Image 97: UnityEngine.UIModule.dll - Assembly: UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60557-60568

namespace UnityEngine
{
	public interface ICanvasRaycastFilter // TypeDefIndex: 60558
	{
		// Methods
		bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
	}

	public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 60559
	{
		// Properties
		public Color color { get => default; set {} } // 0x0000000183FCF9E0-0x0000000183FCFA40 0x000000018646D508-0x000000018646D51C
		public float alpha { get => default; set {} } // 0x000000018415ECE0-0x000000018415ED20 0x00000001849643B0-0x0000000184964400
		public bool interactable { get => default; set {} } // 0x0000000183FD2C30-0x0000000183FD2C70 0x0000000184B5D4A0-0x0000000184B5D4F0
		public bool blocksRaycasts { get => default; set {} } // 0x0000000183FCA840-0x0000000183FCA880 0x0000000184B5D610-0x0000000184B5D660
		public bool ignoreParentGroups { get => default; set {} } // 0x0000000183FD2C70-0x0000000183FD2CB0 0x000000018C07BAD0-0x000000018C07BB14
	
		// Constructors
		public CanvasGroup() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) => default; // 0x000000018646D4FC-0x000000018646D508
		private void get_color_Injected(out Color ret) {
			ret = default;
		} // 0x0000000183FCFA40-0x0000000183FCFA90
		private void set_color_Injected(ref Color value) {} // 0x0000000184C578D0-0x0000000184C57920
	}

	public sealed class CanvasRenderer : Component // TypeDefIndex: 60561
	{
		// Fields
		private bool _isMask_k__BackingField; // 0x18
	
		// Properties
		public bool hasPopInstruction { set {} } // 0x00000001845E44B0-0x00000001845E4500
		public int materialCount { get => default; set {} } // 0x0000000184A14770-0x0000000184A147B0 0x00000001840486C0-0x0000000184048710
		public int popMaterialCount { set {} } // 0x00000001845E4FD0-0x00000001845E5020
		public int absoluteDepth { get => default; } // 0x00000001840E5B80-0x00000001840E5BC0 
		public bool hasMoved { get => default; } // 0x000000018524F320-0x000000018524F360 
		public bool cullTransparentMesh { get => default; set {} } // 0x0000000185296C00-0x0000000185296C40 0x0000000185EB69F0-0x0000000185EB6A40
		public bool cull { get => default; set {} } // 0x00000001840E3BA0-0x00000001840E3BE0 0x000000018422D500-0x000000018422D550
		public Vector2 clippingSoftness { set {} } // 0x000000018646DC1C-0x000000018646DC38
		public Vector4 clippingHGSoftness { set {} } // 0x000000018646DC38-0x000000018646DC4C
	
		// Nested types
		public struct InstanceRange // TypeDefIndex: 60560
		{
			// Fields
			public ushort start; // 0x00
			public ushort end; // 0x02
		}
	
		// Constructors
		public CanvasRenderer() {} // Dummy constructor
	
		// Methods
		public void SetColor(Color color) {} // 0x000000018550A8B0-0x000000018550A8D0
		public Color GetColor() => default; // 0x000000018442F670-0x000000018442F6D0
		public void EnableRectClipping(Rect rect) {} // 0x00000001864723CC-0x00000001864723E0
		public void DisableRectClipping() {} // 0x0000000184CAC4F0-0x0000000184CAC530
		public void SetMaterial(Material material, int index) {} // 0x0000000184048710-0x0000000184048770
		public Material GetMaterial(int index) => default; // 0x000000018C07BC7C-0x000000018C07BCBC
		public void SetPopMaterial(Material material, int index) {} // 0x00000001845E4F70-0x00000001845E4FD0
		public void SetTexture(Texture texture) {} // 0x0000000184048670-0x00000001840486C0
		public void SetAlphaTexture(Texture texture) {} // 0x0000000184044840-0x0000000184044890
		public void SetMesh(Mesh mesh) {} // 0x00000001840E23B0-0x00000001840E2400
		public void Clear() {} // 0x000000018423CAB0-0x000000018423CAF0
		public void SetAlpha(float alpha) {} // 0x000000018C07BCBC-0x000000018C07BD14
		public float GetInheritedAlpha() => default; // 0x00000001845EA730-0x00000001845EA770
		public void SetMaterial(Material material, Texture texture) {} // 0x0000000184A146C0-0x0000000184A14770
		public Material GetMaterial() => default; // 0x000000018C07BC70-0x000000018C07BC7C
		public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) {} // 0x000000018C07BDBC-0x000000018C07BE28
		public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) {} // 0x000000018C07BBD8-0x000000018C07BC3C
		public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents) {} // 0x000000018C07BB14-0x000000018C07BB24
		private static void SplitIndicesStreamsInternal(object verts, object indices) {} // 0x000000018C07BD14-0x000000018C07BD58
		private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) {} // 0x000000018C07BD58-0x000000018C07BDBC
		private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) {} // 0x000000018C07BB74-0x000000018C07BBD8
		private unsafe void UpdateInstanceRange(uint rangeCount, void* ranges) {} // 0x0000000184632F10-0x0000000184632F70
		public void UpdateInstanceRange(uint rangeCount, NativeArray<InstanceRange> rangers) {} // 0x0000000184632EB0-0x0000000184632F10
		private unsafe void* BeginInstanceBufferWrite(uint count, uint stride) => default; // 0x000000018C07BB24-0x000000018C07BB74
		private unsafe void* BeginPrefabBufferWrite(uint count, uint stride) => default; // 0x0000000185D77480-0x0000000185D774E0
		public void EndInstanceBufferWrite() {} // 0x000000018C07BC3C-0x000000018C07BC70
		public void EndPrefabBufferWrite() {} // 0x0000000185F51450-0x0000000185F51490
		public NativeArray<T> BeginInstanceDataWrite<T>(int count)
			where T : struct => default;
		public NativeArray<T> BeginPrefabBufferWrite<T>(int count)
			where T : struct => default;
		public void EnableInstance() {} // 0x000000018473BF30-0x000000018473BF70
		private void SetColor_Injected(ref Color color) {} // 0x000000018550A8D0-0x000000018550A920
		private void GetColor_Injected(out Color ret) {
			ret = default;
		} // 0x000000018442F6D0-0x000000018442F720
		private void EnableRectClipping_Injected(ref Rect rect) {} // 0x0000000184CAC530-0x0000000184CAC640
		private void set_clippingSoftness_Injected(ref Vector2 value) {} // 0x0000000184A59730-0x0000000184A59780
		private void set_clippingHGSoftness_Injected(ref Vector4 value) {} // 0x0000000184A59780-0x0000000184A597D0
	}

	public sealed class RectTransformUtility // TypeDefIndex: 60562
	{
		// Fields
		private static readonly Vector3[] s_Corners; // 0x00
	
		// Constructors
		private RectTransformUtility() {} // 0x0000000185492010-0x0000000185492020
		static RectTransformUtility() {} // 0x0000000185F63850-0x0000000185F638C0
	
		// Methods
		public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) => default; // 0x000000018C07D010-0x000000018C07D080
		public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) => default; // 0x000000018C07D0D4-0x000000018C07D140
		private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) => default; // 0x00000001840E3A30-0x00000001840E3AD0
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint) => default; // 0x000000018C07D140-0x000000018C07D198
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) => default; // 0x0000000183FCAA90-0x0000000183FCAB30
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) => default; // 0x00000001840E3940-0x00000001840E3A30
		public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) {
			worldPoint = default;
			return default;
		} // 0x0000000184234950-0x0000000184234D80
		public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) {
			localPoint = default;
			return default;
		} // 0x0000000184234680-0x00000001842347A0
		public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) => default; // 0x0000000184234E10-0x0000000184235010
		public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) => default; // 0x00000001845E3CD0-0x00000001845E3DB0
		public static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child) => default; // 0x000000018C07C75C-0x000000018C07CADC
		public static Bounds CalculateRelativeRectTransformBounds(Transform trans) => default; // 0x000000018C07CADC-0x000000018C07CB54
		public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) {} // 0x000000018C07CD6C-0x000000018C07CFAC
		public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) {} // 0x000000018C07CB54-0x000000018C07CD6C
		private static Vector2 GetTransposed(Vector2 input) => default; // 0x0000000185FEA950-0x0000000185FEA970
		private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) {
			ret = default;
		} // 0x000000018C07CFAC-0x000000018C07D010
		private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) {
			ret = default;
		} // 0x000000018C07D080-0x000000018C07D0D4
		private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset) => default; // 0x00000001840E3AD0-0x00000001840E3B40
	}

	public enum RenderMode // TypeDefIndex: 60563
	{
		ScreenSpaceOverlay = 0,
		ScreenSpaceCamera = 1,
		WorldSpace = 2
	}

	public enum AdditionalCanvasShaderChannels // TypeDefIndex: 60564
	{
		None = 0,
		TexCoord1 = 1,
		TexCoord2 = 2,
		TexCoord3 = 4,
		Normal = 8,
		Tangent = 16
	}

	public sealed class Canvas : Behaviour // TypeDefIndex: 60566
	{
		// Fields
		private static WillRenderCanvases preWillRenderCanvases; // 0x00
		private static WillRenderCanvases willRenderCanvases; // 0x08
		private static Action<int> _externBeginRenderOverlays_k__BackingField; // 0x10
		private static Action<int, int> _externRenderOverlaysBefore_k__BackingField; // 0x18
		private static Action<int> _externEndRenderOverlays_k__BackingField; // 0x20
	
		// Properties
		public RenderMode renderMode { get => default; set {} } // 0x0000000184237D10-0x0000000184237D50 0x000000018C07C210-0x000000018C07C23C
		public bool isRootCanvas { get => default; } // 0x00000001840E1FE0-0x00000001840E2020 
		public Rect pixelRect { get => default; } // 0x0000000185759B30-0x0000000185759B80 
		public float scaleFactor { get => default; set {} } // 0x0000000183F92FD0-0x0000000183F93010 0x000000018C07C5D0-0x000000018C07C614
		public float referencePixelsPerUnit { get => default; set {} } // 0x000000018C07C198-0x000000018C07C1CC 0x000000018C07C548-0x000000018C07C58C
		public bool overridePixelPerfect { get => default; set {} } // 0x000000018C07C30C-0x000000018C07C340 0x000000018C07C718-0x000000018C07C75C
		public bool vertexColorAlwaysGammaSpace { get => default; set {} } // 0x00000001840E1FA0-0x00000001840E1FE0 0x000000018C07C58C-0x000000018C07C5D0
		public bool pixelPerfect { get => default; set {} } // 0x000000018C07C23C-0x000000018C07C270 0x000000018548E530-0x000000018548E580
		public float planeDistance { get => default; set {} } // 0x000000018C07C270-0x000000018C07C2A4 0x0000000183FCBD50-0x0000000183FCBF00
		public int renderOrder { get => default; } // 0x0000000184CD1F90-0x0000000184CD1FE0 
		public bool overrideSorting { get => default; set {} } // 0x0000000184CD1CF0-0x0000000184CD1D30 0x0000000184CD2100-0x0000000184CD2150
		public int sortingOrder { get => default; set {} } // 0x0000000184C614D0-0x0000000184C61510 0x000000018C07C6D8-0x000000018C07C718
		public int targetDisplay { get => default; set {} } // 0x0000000185050970-0x00000001850509B0 0x000000018C07C654-0x000000018C07C694
		public int sortingLayerID { get => default; set {} } // 0x000000018C07C020-0x000000018C07C054 0x0000000185296BC0-0x0000000185296C00
		public int cachedSortingLayerValue { get => default; } // 0x000000018C07C340-0x000000018C07C380 
		public AdditionalCanvasShaderChannels additionalShaderChannels { get => default; set {} } // 0x000000018C07C2D8-0x000000018C07C30C 0x000000018C07C694-0x000000018C07C6D8
		public string sortingLayerName { get => default; set {} } // 0x00000001840E7760-0x00000001840E77A0 0x0000000184ABB400-0x0000000184ABB450
		public Canvas rootCanvas { get => default; } // 0x000000018C07C054-0x000000018C07C088 
		public Vector2 renderingDisplaySize { get => default; } // 0x000000018C07C380-0x000000018C07C3C4 
		public bool doCPUFrameInterpolation { get => default; set {} } // 0x000000018C07C130-0x000000018C07C164 0x000000018C07C4C0-0x000000018C07C504
		public bool joinGPUFrameInterpolation { get => default; set {} } // 0x000000018C07C088-0x000000018C07C0C0 0x000000018C07C3C4-0x000000018C07C418
		internal static Action<int> externBeginRenderOverlays { get; set; } // 0x000000018C07C0F8-0x000000018C07C130 0x000000018C07C46C-0x000000018C07C4C0
		internal static Action<int, int> externRenderOverlaysBefore { get; set; } // 0x000000018C07C0C0-0x000000018C07C0F8 0x000000018C07C418-0x000000018C07C46C
		internal static Action<int> externEndRenderOverlays { get; set; } // 0x000000018C07BFA8-0x000000018C07BFDC 0x000000018423A600-0x000000018423A640
		public Camera worldCamera { get => default; set {} } // 0x000000018C07C164-0x000000018C07C198 0x000000018C07C504-0x000000018C07C548
		public float normalizedSortingGridSize { get => default; set {} } // 0x000000018C07C2A4-0x000000018C07C2D8 0x000000018C07C614-0x000000018C07C654
		public int sortingGridNormalizedSize { get => default; set {} } // 0x000000018C07BEF4-0x000000018C07BF20 0x000000018C07BEC8-0x000000018C07BEF4
	
		// Events
		public static event WillRenderCanvases preWillRenderCanvases;
		public static event WillRenderCanvases willRenderCanvases;
	
		// Nested types
		public delegate void WillRenderCanvases(); // TypeDefIndex: 60565; 0x00000001849CDFA0-0x00000001849CE050
	
		// Constructors
		public Canvas() {} // 0x0000000184ABB450-0x0000000184ABB4A0
	
		// Methods
		internal static void SetExternalCanvasEnabled(bool enabled) {} // 0x0000000184B92180-0x0000000184B921D0
		public static Material GetDefaultCanvasTextMaterial() => default; // 0x000000018C07BF20-0x000000018C07BF4C
		public static Material GetDefaultCanvasMaterial() => default; // 0x000000018C07BFDC-0x000000018C07C020
		public static Material GetETC1SupportedCanvasMaterial() => default; // 0x0000000185F089E0-0x0000000185F08A00
		internal void UpdateCanvasRectTransform(bool alignWithCamera) {} // 0x00000001843FE2E0-0x00000001843FE330
		public static void ForceUpdateCanvases() {} // 0x00000001843FE330-0x00000001843FE5A0
		private static void SendPreWillRenderCanvases() {} // 0x000000018C07BE28-0x000000018C07BE78
		private static void SendWillRenderCanvases() {} // 0x000000018C07BF4C-0x000000018C07BFA8
		private static void BeginRenderExtraOverlays(int displayIndex) {} // 0x000000018C07BE78-0x000000018C07BEC8
		private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) {} // 0x000000018646DB20-0x000000018646DB28
		private static void EndRenderExtraOverlays(int displayIndex) {} // 0x000000018C07C1CC-0x000000018C07C210
		private void get_pixelRect_Injected(out Rect ret) {
			ret = default;
		} // 0x00000001849CFA20-0x00000001849CFAD0
		private void get_renderingDisplaySize_Injected(out Vector2 ret) {
			ret = default;
		} // 0x00000001864BC320-0x00000001864BC330
	}

	public static class UISystemProfilerApi // TypeDefIndex: 60568
	{
		// Nested types
		public enum SampleType // TypeDefIndex: 60567
		{
			Layout = 0,
			Render = 1
		}
	
		// Methods
		public static void BeginSample(SampleType type) {} // 0x000000018423E1D0-0x000000018423E210
		public static void EndSample(SampleType type) {} // 0x000000018423E210-0x000000018423E250
		public static void AddMarker(string name, Object obj) {} // 0x0000000184232C50-0x0000000184232CA0
	}
}
