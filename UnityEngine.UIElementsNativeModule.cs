/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

// Image 87: UnityEngine.UIElementsNativeModule.dll - Assembly: UnityEngine.UIElementsNativeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60281-60312

namespace UnityEngine.UIElements
{
	internal struct TextNativeSettings // TypeDefIndex: 60304
	{
		// Fields
		public string text; // 0x00
		public Font font; // 0x08
		public int size; // 0x10
		public float scaling; // 0x14
		public FontStyle style; // 0x18
		public UnityEngine.Color color; // 0x1C
		public TextAnchor anchor; // 0x2C
		public bool wordWrap; // 0x30
		public float wordWrapWidth; // 0x34
		public bool richText; // 0x38
	}

	internal struct TextVertex // TypeDefIndex: 60305
	{
		// Fields
		public Vector3 position; // 0x00
		public Color32 color; // 0x0C
		public Vector2 uv0; // 0x10
	}

	internal static class TextNative // TypeDefIndex: 60306
	{
		// Methods
		public static Vector2 GetCursorPosition(TextNativeSettings settings, Rect rect, int cursorIndex) => default; // 0x000000018C079314-0x000000018C079430
		public static float ComputeTextWidth(TextNativeSettings settings) => default; // 0x000000018C07908C-0x000000018C07918C
		public static float ComputeTextHeight(TextNativeSettings settings) => default; // 0x000000018C078F8C-0x000000018C07908C
		public static NativeArray<TextVertex> GetVertices(TextNativeSettings settings) => default; // 0x000000018C079604-0x000000018C07975C
		public static Vector2 GetOffset(TextNativeSettings settings, Rect screenRect) => default; // 0x000000018C079430-0x000000018C079588
		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint) => default; // 0x000000018C06D494-0x000000018C06D524
		private static float DoComputeTextWidth(TextNativeSettings settings) => default; // 0x000000018C079204-0x000000018C079214
		private static float DoComputeTextHeight(TextNativeSettings settings) => default; // 0x000000018C0791C0-0x000000018C0791D0
		private static Vector2 DoGetCursorPosition(TextNativeSettings settings, Rect rect, int cursorPosition) => default; // 0x000000018C079278-0x000000018C07929C
		private static void GetVertices(TextNativeSettings settings, IntPtr buffer, int vertexSize, ref int vertexCount) {} // 0x000000018C0795EC-0x000000018C079604
		private static Vector2 DoGetOffset(TextNativeSettings settings, Rect rect) => default; // 0x000000018C0792F0-0x000000018C079314
		private static float DoComputeTextWidth_Injected(ref TextNativeSettings settings) => default; // 0x000000018C0791D0-0x000000018C079204
		private static float DoComputeTextHeight_Injected(ref TextNativeSettings settings) => default; // 0x000000018C07918C-0x000000018C0791C0
		private static void DoGetCursorPosition_Injected(ref TextNativeSettings settings, ref Rect rect, int cursorPosition, out Vector2 ret) {
			ret = default;
		} // 0x000000018C079214-0x000000018C079278
		private static void GetVertices_Injected(ref TextNativeSettings settings, IntPtr buffer, int vertexSize, ref int vertexCount) {} // 0x000000018C079588-0x000000018C0795EC
		private static void DoGetOffset_Injected(ref TextNativeSettings settings, ref Rect rect, out Vector2 ret) {
			ret = default;
		} // 0x000000018C07929C-0x000000018C0792F0
	}

	internal static class UIElementsRuntimeUtilityNative // TypeDefIndex: 60307
	{
		// Fields
		internal static Action RepaintOverlayPanelsCallback; // 0x00
		internal static Action UpdateRuntimePanelsCallback; // 0x08
		internal static Action RepaintOffscreenPanelsCallback; // 0x10
	
		// Methods
		public static void RepaintOverlayPanels() {} // 0x000000018C0797CC-0x000000018C07980C
		public static void UpdateRuntimePanels() {} // 0x000000018C079838-0x000000018C07987C
		public static void RepaintOffscreenPanels() {} // 0x000000018C079788-0x000000018C0797CC
		public static void RegisterPlayerloopCallback() {} // 0x000000018C07975C-0x000000018C079788
		public static void UnregisterPlayerloopCallback() {} // 0x000000018C07980C-0x000000018C079838
		public static void VisualElementCreation() {} // 0x000000018C07987C-0x000000018C0798A8
	}
}

namespace UnityEngine.UIElements.UIR
{
	internal struct GfxUpdateBufferRange // TypeDefIndex: 60308
	{
		// Fields
		public uint offsetFromWriteStart; // 0x00
		public uint size; // 0x04
		public UIntPtr source; // 0x08
	}

	internal struct DrawBufferRange // TypeDefIndex: 60309
	{
		// Fields
		public int firstIndex; // 0x00
		public int indexCount; // 0x04
		public int minIndexVal; // 0x08
		public int vertsReferenced; // 0x0C
	}

	internal class Utility // TypeDefIndex: 60312
	{
		// Fields
		private static Action<bool> GraphicsResourcesRecreate; // 0x00
		private static Action EngineUpdate; // 0x08
		private static Action FlushPendingResources; // 0x10
		private static Action<Camera> RegisterIntermediateRenderers; // 0x18
		private static Action<IntPtr> RenderNodeAdd; // 0x20
		private static Action<IntPtr> RenderNodeExecute; // 0x28
		private static Action<IntPtr> RenderNodeCleanup; // 0x30
		private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x38
	
		// Events
		public static event Action<bool> GraphicsResourcesRecreate;
		public static event Action EngineUpdate;
		public static event Action FlushPendingResources;
		public static event Action<Camera> RegisterIntermediateRenderers;
		public static event Action<IntPtr> RenderNodeExecute;
	
		// Nested types
		internal enum GPUBufferType // TypeDefIndex: 60310
		{
			Vertex = 0,
			Index = 1
		}
	
		public class GPUBuffer<T> : IDisposable // TypeDefIndex: 60311
			where T : struct
		{
			// Fields
			private IntPtr buffer;
			private int elemCount;
			private int elemStride;
	
			// Properties
			public int ElementStride { get => default; } // 0x000000018C07A2CC-0x000000018C07A3A0 
			internal IntPtr BufferPointer { get => default; } // 0x000000018C07A6C8-0x000000018C07A79C 
	
			// Constructors
			public GPUBuffer() {} // Dummy constructor
			public GPUBuffer(int elementCount, GPUBufferType type) {}
	
			// Methods
			public void Dispose() {} // 0x000000018C07A474-0x000000018C07A538
			public void UpdateRanges(NativeSlice<GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax) {} // 0x000000018C07A870-0x000000018C07A934
		}
	
		// Constructors
		public Utility() {} // Dummy constructor
		static Utility() {} // 0x000000018C079AF0-0x000000018C079B24
	
		// Methods
		public static void SetVectorArray<T>(MaterialPropertyBlock props, int name, NativeSlice<T> vector4s)
			where T : struct {} // 0x000000018C07A3A0-0x000000018C07A474
		internal static void RaiseGraphicsResourcesRecreate(bool recreate) {} // 0x000000018C079EBC-0x000000018C079F18
		internal static void RaiseEngineUpdate() {} // 0x000000018C079E60-0x000000018C079EBC
		internal static void RaiseFlushPendingResources() {} // 0x000000018C0798A8-0x000000018C0798F8
		internal static void RaiseRegisterIntermediateRenderers(Camera camera) {} // 0x000000018C079A3C-0x000000018C079A70
		internal static void RaiseRenderNodeAdd(IntPtr userData) {} // 0x000000018C07A1D4-0x000000018C07A238
		internal static void RaiseRenderNodeExecute(IntPtr userData) {} // 0x000000018C07A148-0x000000018C07A1A8
		internal static void RaiseRenderNodeCleanup(IntPtr userData) {} // 0x000000018C079B78-0x000000018C079BAC
		private static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer) => default; // 0x000000018C079F80-0x000000018C07A054
		private static void FreeBuffer(IntPtr buffer) {} // 0x000000018C0799D8-0x000000018C079A3C
		private static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd) {} // 0x000000018C07A054-0x000000018C07A088
		private static void SetVectorArray(MaterialPropertyBlock props, int name, IntPtr vector4s, int count) {} // 0x000000018C07A0BC-0x000000018C07A108
		public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes) => default; // 0x000000018C0799AC-0x000000018C0799D8
		public static void RegisterIntermediateRenderer(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) {} // 0x000000018C079960-0x000000018C0799AC
		public static unsafe void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl) {} // 0x000000018C07A108-0x000000018C07A148
		public static void SetPropertyBlock(MaterialPropertyBlock props) {} // 0x000000018C079BAC-0x000000018C079BD8
		public static void SetScissorRect(RectInt scissorRect) {} // 0x000000018C079BD8-0x000000018C079C04
		public static void DisableScissor() {} // 0x000000018C0798F8-0x000000018C07992C
		public static IntPtr CreateStencilState(StencilState stencilState) => default; // 0x000000018C07A238-0x000000018C07A26C
		public static void SetStencilState(IntPtr stencilState, int stencilRef) {} // 0x000000018C07A1A8-0x000000018C07A1D4
		public static bool HasMappedBufferRange() => default; // 0x000000018C079AA4-0x000000018C079AF0
		public static uint InsertCPUFence() => default; // 0x000000018C079C38-0x000000018C079C64
		public static bool CPUFencePassed(uint fence) => default; // 0x000000018C079C64-0x000000018C079C90
		public static void WaitForCPUFencePassed(uint fence) {} // 0x000000018C079C04-0x000000018C079C38
		public static void SyncRenderThread() {} // 0x000000018C079B24-0x000000018C079B78
		public static RectInt GetActiveViewport() => default; // 0x000000018C07A26C-0x000000018C07A2CC
		public static void ProfileDrawChainBegin() {} // 0x000000018C079F18-0x000000018C079F80
		public static void ProfileDrawChainEnd() {} // 0x000000018C07A088-0x000000018C07A0BC
		public static void NotifyOfUIREvents(bool subscribe) {} // 0x000000018C07992C-0x000000018C079960
		public static Matrix4x4 GetUnityProjectionMatrix() => default; // 0x000000018C079A70-0x000000018C079AA4
		private static void RegisterIntermediateRenderer_Injected(Camera camera, Material material, ref Matrix4x4 transform, ref Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) {}
		private static void SetScissorRect_Injected(ref RectInt scissorRect) {}
		private static IntPtr CreateStencilState_Injected(ref StencilState stencilState) => default;
		private static void GetActiveViewport_Injected(out RectInt ret) {
			ret = default;
		}
		private static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret) {
			ret = default;
		}
	}
}

namespace UnityEngine.Yoga
{
	internal delegate float BaselineFunction(YogaNode node, float width, float height); // TypeDefIndex: 60282; 0x0000000187207BF4-0x0000000187207C08

	internal delegate void Logger(YogaConfig config, YogaNode node, YogaLogLevel level, string message); // TypeDefIndex: 60283; 0x00000001832D8120-0x00000001832D8140

	internal delegate YogaSize MeasureFunction(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode); // TypeDefIndex: 60284; 0x0000000188BB9B1C-0x0000000188BB9B30

	internal class MeasureOutput // TypeDefIndex: 60285
	{
		// Constructors
		public MeasureOutput() {} // Dummy constructor
	
		// Methods
		public static YogaSize Make(float width, float height) => default; // 0x0000000185FEA920-0x0000000185FEA930
	}

	internal enum YogaAlign // TypeDefIndex: 60286
	{
		Auto = 0,
		FlexStart = 1,
		Center = 2,
		FlexEnd = 3,
		Stretch = 4,
		Baseline = 5,
		SpaceBetween = 6,
		SpaceAround = 7
	}

	internal class YogaConfig // TypeDefIndex: 60287
	{
		// Fields
		internal static readonly YogaConfig Default; // 0x00
		private IntPtr _ygConfig; // 0x10
		private UnityEngine.Yoga.Logger _logger; // 0x18
	
		// Properties
		internal IntPtr Handle { get => default; } // 0x0000000185FC7990-0x0000000185FC79A0 
		public bool UseWebDefaults { get => default; set {} } // 0x000000018C07ACA8-0x000000018C07ACB8 0x000000018C07ACC4-0x000000018C07ACD0
		public float PointScaleFactor { set {} } // 0x000000018C07ACB8-0x000000018C07ACC4
	
		// Constructors
		private YogaConfig(IntPtr ygConfig) {} // 0x000000018C07AC3C-0x000000018C07ACA8
		public YogaConfig() {} // 0x000000018C07AC18-0x000000018C07AC3C
		static YogaConfig() {} // 0x000000018C07AB90-0x000000018C07AC18
	
		// Methods
		~YogaConfig() {} // 0x000000018C07AAC4-0x000000018C07AB90
	}

	internal static class YogaConstants // TypeDefIndex: 60288
	{
		// Methods
		public static bool IsUndefined(float value) => default; // 0x000000018C07ACD0-0x000000018C07ACD8
	}

	internal enum YogaDirection // TypeDefIndex: 60289
	{
		Inherit = 0,
		LTR = 1,
		RTL = 2
	}

	internal enum YogaDisplay // TypeDefIndex: 60290
	{
		Flex = 0,
		None = 1
	}

	internal enum YogaEdge // TypeDefIndex: 60291
	{
		Left = 0,
		Top = 1,
		Right = 2,
		Bottom = 3,
		Start = 4,
		End = 5,
		Horizontal = 6,
		Vertical = 7,
		All = 8
	}

	internal enum YogaFlexDirection // TypeDefIndex: 60292
	{
		Column = 0,
		ColumnReverse = 1,
		Row = 2,
		RowReverse = 3
	}

	internal enum YogaJustify // TypeDefIndex: 60293
	{
		FlexStart = 0,
		Center = 1,
		FlexEnd = 2,
		SpaceBetween = 3,
		SpaceAround = 4
	}

	internal enum YogaLogLevel // TypeDefIndex: 60294
	{
		Error = 0,
		Warn = 1,
		Info = 2,
		Debug = 3,
		Verbose = 4,
		Fatal = 5
	}

	internal enum YogaMeasureMode // TypeDefIndex: 60295
	{
		Undefined = 0,
		Exactly = 1,
		AtMost = 2
	}

	internal static class Native // TypeDefIndex: 60296
	{
		// Methods
		public static IntPtr YGNodeNewWithConfig(IntPtr config) => default; // 0x000000018C0783DC-0x000000018C078410
		public static void YGNodeFree(IntPtr ygNode) {} // 0x000000018C0780B4-0x000000018C0780C4
		private static void YGNodeFreeInternal(IntPtr ygNode) {} // 0x000000018C078080-0x000000018C0780B4
		public static void YGSetManagedObject(IntPtr ygNode, YogaNode node) {} // 0x000000018C078F48-0x000000018C078F8C
		public static void YGNodeSetConfig(IntPtr ygNode, IntPtr config) {} // 0x000000018C078488-0x000000018C0784CC
		public static IntPtr YGConfigGetDefault() => default; // 0x000000018C077EA8-0x000000018C077ED4
		public static IntPtr YGConfigNew() => default; // 0x000000018C077F08-0x000000018C077F34
		public static void YGConfigFree(IntPtr config) {} // 0x000000018C077E98-0x000000018C077EA8
		private static void YGConfigFreeInternal(IntPtr config) {} // 0x000000018C077E64-0x000000018C077E98
		public static void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults) {} // 0x000000018C077F78-0x000000018C077FBC
		public static bool YGConfigGetUseWebDefaults(IntPtr config) => default; // 0x000000018C077ED4-0x000000018C077F08
		public static void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint) {} // 0x000000018C077F34-0x000000018C077F78
		public static void YGNodeInsertChild(IntPtr node, IntPtr child, uint index) {} // 0x000000018C0780F8-0x000000018C07814C
		public static void YGNodeRemoveChild(IntPtr node, IntPtr child) {} // 0x000000018C078410-0x000000018C078454
		public static void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection) {} // 0x000000018C077FD8-0x000000018C07803C
		public static void YGNodeMarkDirty(IntPtr node) {} // 0x000000018C078378-0x000000018C0783AC
		public static bool YGNodeIsDirty(IntPtr node) => default; // 0x000000018C07814C-0x000000018C078180
		public static void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode) {} // 0x000000018C07803C-0x000000018C078080
		public static void YGNodeSetMeasureFunc(IntPtr node) {} // 0x000000018C078510-0x000000018C078544
		public static void YGNodeRemoveMeasureFunc(IntPtr node) {} // 0x000000018C078454-0x000000018C078488
		public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) {} // 0x000000018C0783AC-0x000000018C0783DC
		public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) {} // 0x000000018C077FBC-0x000000018C077FD8
		public static void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout) {} // 0x000000018C0784CC-0x000000018C078510
		public static bool YGNodeGetHasNewLayout(IntPtr node) => default; // 0x000000018C0780C4-0x000000018C0780F8
		public static YogaDirection YGNodeStyleGetDirection(IntPtr node) => default; // 0x000000018C078544-0x000000018C078578
		public static void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection) {} // 0x000000018C078784-0x000000018C0787C4
		public static void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent) {} // 0x000000018C07898C-0x000000018C0789CC
		public static void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent) {} // 0x000000018C078578-0x000000018C0785B8
		public static void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems) {} // 0x000000018C0785B8-0x000000018C0785F8
		public static void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf) {} // 0x000000018C0785F8-0x000000018C078638
		public static void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType) {} // 0x000000018C078DFC-0x000000018C078E3C
		public static void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap) {} // 0x000000018C07884C-0x000000018C07888C
		public static void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap) {} // 0x000000018C078CCC-0x000000018C078D0C
		public static void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display) {} // 0x000000018C078688-0x000000018C0786C8
		public static void YGNodeStyleSetFlex(IntPtr node, float flex) {} // 0x000000018C07888C-0x000000018C0788D0
		public static void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow) {} // 0x000000018C0787C4-0x000000018C078808
		public static void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink) {} // 0x000000018C078808-0x000000018C07884C
		public static void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis) {} // 0x000000018C078740-0x000000018C078784
		public static void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis) {} // 0x000000018C0786FC-0x000000018C078740
		public static void YGNodeStyleSetFlexBasisAuto(IntPtr node) {} // 0x000000018C0786C8-0x000000018C0786FC
		public static void YGNodeStyleSetWidth(IntPtr node, float width) {} // 0x000000018C078F04-0x000000018C078F48
		public static void YGNodeStyleSetWidthPercent(IntPtr node, float width) {} // 0x000000018C078EC0-0x000000018C078F04
		public static void YGNodeStyleSetWidthAuto(IntPtr node) {} // 0x000000018C078E8C-0x000000018C078EC0
		public static void YGNodeStyleSetHeight(IntPtr node, float height) {} // 0x000000018C078948-0x000000018C07898C
		public static void YGNodeStyleSetHeightPercent(IntPtr node, float height) {} // 0x000000018C078904-0x000000018C078948
		public static void YGNodeStyleSetHeightAuto(IntPtr node) {} // 0x000000018C0788D0-0x000000018C078904
		public static void YGNodeStyleSetMinWidth(IntPtr node, float minWidth) {} // 0x000000018C078C88-0x000000018C078CCC
		public static void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth) {} // 0x000000018C078C44-0x000000018C078C88
		public static void YGNodeStyleSetMinHeight(IntPtr node, float minHeight) {} // 0x000000018C078C00-0x000000018C078C44
		public static void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight) {} // 0x000000018C078BBC-0x000000018C078C00
		public static void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth) {} // 0x000000018C078B78-0x000000018C078BBC
		public static void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth) {} // 0x000000018C078B34-0x000000018C078B78
		public static void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight) {} // 0x000000018C078AF0-0x000000018C078B34
		public static void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight) {} // 0x000000018C078AAC-0x000000018C078AF0
		public static void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position) {} // 0x000000018C078E3C-0x000000018C078E8C
		public static void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position) {} // 0x000000018C078DAC-0x000000018C078DFC
		public static void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin) {} // 0x000000018C078A5C-0x000000018C078AAC
		public static void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin) {} // 0x000000018C078A0C-0x000000018C078A5C
		public static void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge) {} // 0x000000018C0789CC-0x000000018C078A0C
		public static void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding) {} // 0x000000018C078D5C-0x000000018C078DAC
		public static void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding) {} // 0x000000018C078D0C-0x000000018C078D5C
		public static void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border) {} // 0x000000018C078638-0x000000018C078688
		public static float YGNodeLayoutGetLeft(IntPtr node) => default; // 0x000000018C078228-0x000000018C07825C
		public static float YGNodeLayoutGetTop(IntPtr node) => default; // 0x000000018C078310-0x000000018C078344
		public static float YGNodeLayoutGetRight(IntPtr node) => default; // 0x000000018C0782DC-0x000000018C078310
		public static float YGNodeLayoutGetBottom(IntPtr node) => default; // 0x000000018C0781C0-0x000000018C0781F4
		public static float YGNodeLayoutGetWidth(IntPtr node) => default; // 0x000000018C078344-0x000000018C078378
		public static float YGNodeLayoutGetHeight(IntPtr node) => default; // 0x000000018C0781F4-0x000000018C078228
		public static float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge) => default; // 0x000000018C07825C-0x000000018C07829C
		public static float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge) => default; // 0x000000018C07829C-0x000000018C0782DC
		public static float YGNodeLayoutGetBorder(IntPtr node, YogaEdge edge) => default; // 0x000000018C078180-0x000000018C0781C0
	}

	internal class YogaNode : IEnumerable<YogaNode> // TypeDefIndex: 60297
	{
		// Fields
		internal IntPtr _ygNode; // 0x10
		private YogaConfig _config; // 0x18
		private WeakReference _parent; // 0x20
		private List<YogaNode> _children; // 0x28
		private MeasureFunction _measureFunction; // 0x30
		private BaselineFunction _baselineFunction; // 0x38
		private object _data; // 0x40
	
		// Properties
		internal YogaConfig Config { set {} } // 0x000000018C07B624-0x000000018C07B6B0
		public bool IsDirty { get => default; } // 0x000000018C07B44C-0x000000018C07B45C 
		public bool HasNewLayout { get => default; } // 0x000000018C07B43C-0x000000018C07B44C 
		public bool IsMeasureDefined { get => default; } // 0x000000018A6AD3DC-0x000000018A6AD3E8 
		public bool IsBaselineDefined { get => default; } // 0x0000000188251750-0x000000018825175C 
		public YogaFlexDirection FlexDirection { set {} } // 0x000000018C07B710-0x000000018C07B71C
		public YogaJustify JustifyContent { set {} } // 0x000000018C07B794-0x000000018C07B7A0
		public YogaDisplay Display { set {} } // 0x000000018C07B6B0-0x000000018C07B6BC
		public YogaAlign AlignItems { set {} } // 0x000000018C07B5AC-0x000000018C07B5B8
		public YogaAlign AlignSelf { set {} } // 0x000000018C07B5B8-0x000000018C07B5C4
		public YogaAlign AlignContent { set {} } // 0x000000018C07B5A0-0x000000018C07B5AC
		public YogaPositionType PositionType { set {} } // 0x000000018C07B90C-0x000000018C07B918
		public YogaWrap Wrap { set {} } // 0x000000018C07B98C-0x000000018C07B998
		public float Flex { set {} } // 0x000000018C07B734-0x000000018C07B740
		public float FlexGrow { set {} } // 0x000000018C07B71C-0x000000018C07B728
		public float FlexShrink { set {} } // 0x000000018C07B728-0x000000018C07B734
		public YogaValue FlexBasis { set {} } // 0x000000018C07B6BC-0x000000018C07B710
		public YogaValue Width { set {} } // 0x000000018C07B938-0x000000018C07B98C
		public YogaValue Height { set {} } // 0x000000018C07B740-0x000000018C07B794
		public YogaValue MaxWidth { set {} } // 0x000000018C07B824-0x000000018C07B858
		public YogaValue MaxHeight { set {} } // 0x000000018C07B7F0-0x000000018C07B824
		public YogaValue MinWidth { set {} } // 0x000000018C07B88C-0x000000018C07B8C0
		public YogaValue MinHeight { set {} } // 0x000000018C07B858-0x000000018C07B88C
		public float LayoutX { get => default; } // 0x000000018C07B580-0x000000018C07B590 
		public float LayoutY { get => default; } // 0x000000018C07B590-0x000000018C07B5A0 
		public float LayoutRight { get => default; } // 0x000000018C07B560-0x000000018C07B570 
		public float LayoutBottom { get => default; } // 0x000000018C07B4A8-0x000000018C07B4B8 
		public float LayoutWidth { get => default; } // 0x000000018C07B570-0x000000018C07B580 
		public float LayoutHeight { get => default; } // 0x000000018C07B4B8-0x000000018C07B4C8 
		public YogaOverflow Overflow { set {} } // 0x000000018C07B8C0-0x000000018C07B8CC
		public int Count { get => default; } // 0x000000018C07B3F8-0x000000018C07B43C 
		public YogaValue Left { set {} } // 0x000000018C07B7A0-0x000000018C07B7B0
		public YogaValue Top { set {} } // 0x000000018C07B928-0x000000018C07B938
		public YogaValue Right { set {} } // 0x000000018C07B918-0x000000018C07B928
		public YogaValue Bottom { set {} } // 0x000000018C07B614-0x000000018C07B624
		public YogaValue MarginLeft { set {} } // 0x000000018C07B7C0-0x000000018C07B7D0
		public YogaValue MarginTop { set {} } // 0x000000018C07B7E0-0x000000018C07B7F0
		public YogaValue MarginRight { set {} } // 0x000000018C07B7D0-0x000000018C07B7E0
		public YogaValue MarginBottom { set {} } // 0x000000018C07B7B0-0x000000018C07B7C0
		public YogaValue PaddingLeft { set {} } // 0x000000018C07B8DC-0x000000018C07B8EC
		public YogaValue PaddingTop { set {} } // 0x000000018C07B8FC-0x000000018C07B90C
		public YogaValue PaddingRight { set {} } // 0x000000018C07B8EC-0x000000018C07B8FC
		public YogaValue PaddingBottom { set {} } // 0x000000018C07B8CC-0x000000018C07B8DC
		public float BorderLeftWidth { set {} } // 0x000000018C07B5D8-0x000000018C07B5EC
		public float BorderTopWidth { set {} } // 0x000000018C07B600-0x000000018C07B614
		public float BorderRightWidth { set {} } // 0x000000018C07B5EC-0x000000018C07B600
		public float BorderBottomWidth { set {} } // 0x000000018C07B5C4-0x000000018C07B5D8
		public float LayoutMarginLeft { get => default; } // 0x000000018C07B4DC-0x000000018C07B4EC 
		public float LayoutMarginTop { get => default; } // 0x000000018C07B500-0x000000018C07B514 
		public float LayoutMarginRight { get => default; } // 0x000000018C07B4EC-0x000000018C07B500 
		public float LayoutMarginBottom { get => default; } // 0x000000018C07B4C8-0x000000018C07B4DC 
		public float LayoutPaddingLeft { get => default; } // 0x000000018C07B528-0x000000018C07B538 
		public float LayoutPaddingTop { get => default; } // 0x000000018C07B54C-0x000000018C07B560 
		public float LayoutPaddingRight { get => default; } // 0x000000018C07B538-0x000000018C07B54C 
		public float LayoutPaddingBottom { get => default; } // 0x000000018C07B514-0x000000018C07B528 
		public float LayoutBorderLeft { get => default; } // 0x000000018C07B470-0x000000018C07B480 
		public float LayoutBorderTop { get => default; } // 0x000000018C07B494-0x000000018C07B4A8 
		public float LayoutBorderRight { get => default; } // 0x000000018C07B480-0x000000018C07B494 
		public float LayoutBorderBottom { get => default; } // 0x000000018C07B45C-0x000000018C07B470 
	
		// Constructors
		public YogaNode() {} // Dummy constructor
		public YogaNode(YogaConfig config = null) {} // 0x000000018C07B31C-0x000000018C07B3F8
	
		// Methods
		~YogaNode() {} // 0x000000018C07AE38-0x000000018C07AEAC
		public virtual void MarkDirty() {} // 0x000000018C07B034-0x000000018C07B040
		public void CopyStyle(YogaNode srcNode) {} // 0x000000018C07AE14-0x000000018C07AE38
		public void MarkLayoutSeen() {} // 0x000000018C07B040-0x000000018C07B050
		public void Insert(int index, YogaNode node) {} // 0x000000018C07AF18-0x000000018C07B034
		public void RemoveAt(int index) {} // 0x000000018C07B0E8-0x000000018C07B190
		public void Clear() {} // 0x000000018C07ADB8-0x000000018C07AE14
		public void SetMeasureFunction(MeasureFunction measureFunction) {} // 0x000000018C07B190-0x000000018C07B1F4
		public void CalculateLayout(float width = 0F / 0F /* Metadata: 0x020827D2 */, float height = 0F / 0F /* Metadata: 0x020827D6 */) {} // 0x000000018C07AD68-0x000000018C07ADB8
		public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) => default; // 0x000000018C07B050-0x000000018C07B0E8
		public static float BaselineInternal(YogaNode node, float width, float height) => default; // 0x000000018C07ACD8-0x000000018C07AD68
		public IEnumerator<YogaNode> GetEnumerator() => default; // 0x000000018C07AEAC-0x000000018C07AF18
		IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C07B2B0-0x000000018C07B31C
		private void SetStylePosition(YogaEdge edge, YogaValue value) {} // 0x000000018C07B27C-0x000000018C07B2B0
		private void SetStyleMargin(YogaEdge edge, YogaValue value) {} // 0x000000018C07B1F4-0x000000018C07B248
		private void SetStylePadding(YogaEdge edge, YogaValue value) {} // 0x000000018C07B248-0x000000018C07B27C
	}

	internal enum YogaOverflow // TypeDefIndex: 60298
	{
		Visible = 0,
		Hidden = 1,
		Scroll = 2
	}

	internal enum YogaPositionType // TypeDefIndex: 60299
	{
		Relative = 0,
		Absolute = 1
	}

	internal struct YogaSize // TypeDefIndex: 60300
	{
		// Fields
		public float width; // 0x00
		public float height; // 0x04
	}

	internal enum YogaUnit // TypeDefIndex: 60301
	{
		Undefined = 0,
		Point = 1,
		Percent = 2,
		Auto = 3
	}

	internal struct YogaValue // TypeDefIndex: 60302
	{
		// Fields
		private float value; // 0x00
		private YogaUnit unit; // 0x04
	
		// Properties
		public YogaUnit Unit { get => default; } // 0x0000000185FCA560-0x0000000185FCA570 
		public float Value { get => default; } // 0x0000000185FE6770-0x0000000185FE6780 
	
		// Methods
		public static YogaValue Point(float value) => default; // 0x000000018C07BAB0-0x000000018C07BAD0
		public bool Equals(YogaValue other) => default; // 0x000000018C07B998-0x000000018C07B9EC
		public override bool Equals(object obj) => default; // 0x000000018C07B9EC-0x000000018C07BA5C
		public override int GetHashCode() => default; // 0x000000018C07BA5C-0x000000018C07BA8C
		public static YogaValue Auto() => default; // 0x0000000185FEA930-0x0000000185FEA950
		public static YogaValue Percent(float value) => default; // 0x000000018C07BA8C-0x000000018C07BAB0
		public static implicit operator YogaValue(float pointValue) => default; // 0x000000018C07BAB0-0x000000018C07BAD0
	}

	internal enum YogaWrap // TypeDefIndex: 60303
	{
		NoWrap = 0,
		Wrap = 1,
		WrapReverse = 2
	}
}
