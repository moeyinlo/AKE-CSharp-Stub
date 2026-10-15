/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Image 89: UnityEngine.UIElementsNativeModule.dll - Assembly: UnityEngine.UIElementsNativeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 90181-90212

namespace UnityEngine.UIElements
{
	internal struct TextNativeSettings // TypeDefIndex: 90204
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

	internal struct TextVertex // TypeDefIndex: 90205
	{
		// Fields
		public Vector3 position; // 0x00
		public Color32 color; // 0x0C
		public Vector2 uv0; // 0x10
	}

	[NativeHeader("Modules/UIElementsNative/TextNative.bindings.h")]
	internal static class TextNative // TypeDefIndex: 90206
	{
		// Methods
		public static Vector2 GetCursorPosition(TextNativeSettings settings, Rect rect, int cursorIndex); // 0x000000018D68F7FC-0x000000018D68F918
		public static float ComputeTextWidth(TextNativeSettings settings); // 0x000000018D68F574-0x000000018D68F674
		public static float ComputeTextHeight(TextNativeSettings settings); // 0x000000018D68F474-0x000000018D68F574
		public static NativeArray<TextVertex> GetVertices(TextNativeSettings settings); // 0x000000018D68FAEC-0x000000018D68FC4C
		public static Vector2 GetOffset(TextNativeSettings settings, Rect screenRect); // 0x000000018D68F918-0x000000018D68FA70
		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint); // 0x000000018D683948-0x000000018D6839D8
		[FreeFunction(Name = "TextNative::ComputeTextWidth")]
		private static float DoComputeTextWidth(TextNativeSettings settings); // 0x000000018D68F6EC-0x000000018D68F6FC
		[FreeFunction(Name = "TextNative::ComputeTextHeight")]
		private static float DoComputeTextHeight(TextNativeSettings settings); // 0x000000018D68F6A8-0x000000018D68F6B8
		[FreeFunction(Name = "TextNative::GetCursorPosition")]
		private static Vector2 DoGetCursorPosition(TextNativeSettings settings, Rect rect, int cursorPosition); // 0x000000018D68F760-0x000000018D68F784
		[FreeFunction(Name = "TextNative::GetVertices")]
		private static void GetVertices(TextNativeSettings settings, IntPtr buffer, int vertexSize, ref int vertexCount); // 0x000000018D68FAD4-0x000000018D68FAEC
		[FreeFunction(Name = "TextNative::GetOffset")]
		private static Vector2 DoGetOffset(TextNativeSettings settings, Rect rect); // 0x000000018D68F7D8-0x000000018D68F7FC
		private static float DoComputeTextWidth_Injected(ref TextNativeSettings settings); // 0x000000018D68F6B8-0x000000018D68F6EC
		private static float DoComputeTextHeight_Injected(ref TextNativeSettings settings); // 0x000000018D68F674-0x000000018D68F6A8
		private static void DoGetCursorPosition_Injected(ref TextNativeSettings settings, ref Rect rect, int cursorPosition, out Vector2 ret); // 0x000000018D68F6FC-0x000000018D68F760
		private static void GetVertices_Injected(ref TextNativeSettings settings, IntPtr buffer, int vertexSize, ref int vertexCount); // 0x000000018D68FA70-0x000000018D68FAD4
		private static void DoGetOffset_Injected(ref TextNativeSettings settings, ref Rect rect, out Vector2 ret); // 0x000000018D68F784-0x000000018D68F7D8
	}

	[NativeHeader("Modules/UIElementsNative/UIElementsRuntimeUtilityNative.h")]
	[VisibleToOtherModules(new string[1] {"Unity.UIElements" })]
	internal static class UIElementsRuntimeUtilityNative // TypeDefIndex: 90207
	{
		// Fields
		internal static Action RepaintOverlayPanelsCallback; // 0x00
		internal static Action UpdateRuntimePanelsCallback; // 0x08
		internal static Action RepaintOffscreenPanelsCallback; // 0x10
	
		// Methods
		[RequiredByNativeCode]
		public static void RepaintOverlayPanels(); // 0x000000018D68FCBC-0x000000018D68FCFC
		[RequiredByNativeCode]
		public static void UpdateRuntimePanels(); // 0x000000018D68FD28-0x000000018D68FD6C
		[RequiredByNativeCode]
		public static void RepaintOffscreenPanels(); // 0x000000018D68FC78-0x000000018D68FCBC
		public static void RegisterPlayerloopCallback(); // 0x000000018D68FC4C-0x000000018D68FC78
		public static void UnregisterPlayerloopCallback(); // 0x000000018D68FCFC-0x000000018D68FD28
		public static void VisualElementCreation(); // 0x000000018D68FD6C-0x000000018D68FD98
	}
}

namespace UnityEngine.UIElements.UIR
{
	internal struct GfxUpdateBufferRange // TypeDefIndex: 90208
	{
		// Fields
		public uint offsetFromWriteStart; // 0x00
		public uint size; // 0x04
		public UIntPtr source; // 0x08
	}

	internal struct DrawBufferRange // TypeDefIndex: 90209
	{
		// Fields
		public int firstIndex; // 0x00
		public int indexCount; // 0x04
		public int minIndexVal; // 0x08
		public int vertsReferenced; // 0x0C
	}

	[NativeHeader("Modules/UIElementsNative/UIRendererUtility.h")]
	[VisibleToOtherModules(new string[1] {"Unity.UIElements" })]
	internal class Utility // TypeDefIndex: 90212
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<bool> GraphicsResourcesRecreate; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action EngineUpdate; // 0x08
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action FlushPendingResources; // 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<Camera> RegisterIntermediateRenderers; // 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<IntPtr> RenderNodeAdd; // 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<IntPtr> RenderNodeExecute; // 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<IntPtr> RenderNodeCleanup; // 0x30
		private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x38
	
		// Events
		public static event Action<bool> GraphicsResourcesRecreate {
			add; // 0x000000018D690968-0x000000018D690A2C
			remove; // 0x000000018D690D64-0x000000018D690E28
		}
		public static event Action EngineUpdate {
			add; // 0x000000018D6907C0-0x000000018D690894
			remove; // 0x000000018D690BBC-0x000000018D690C90
		}
		public static event Action FlushPendingResources {
			add; // 0x000000018D690894-0x000000018D690968
			remove; // 0x000000018D690C90-0x000000018D690D64
		}
		public static event Action<Camera> RegisterIntermediateRenderers {
			add; // 0x000000018D690A2C-0x000000018D690AF4
			remove; // 0x000000018D690E28-0x000000018D690EF0
		}
		public static event Action<IntPtr> RenderNodeExecute {
			add; // 0x000000018D690AF4-0x000000018D690BBC
			remove; // 0x000000018D690EF0-0x000000018D690FB8
		}
	
		// Nested types
		internal enum GPUBufferType // TypeDefIndex: 90210
		{
			Vertex = 0,
			Index = 1
		}
	
		public class GPUBuffer<T> : IDisposable // TypeDefIndex: 90211
			where T : struct
		{
			// Fields
			private IntPtr buffer;
			private int elemCount;
			private int elemStride;
	
			// Properties
			public int ElementStride { get; }
			internal IntPtr BufferPointer { get; }
	
			// Constructors
			public GPUBuffer(int elementCount, GPUBufferType type);
	
			// Methods
			public void Dispose();
			public void UpdateRanges(NativeSlice<GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax);
		}
	
		// Constructors
		static Utility(); // 0x000000018D69075C-0x000000018D6907C0
	
		// Methods
		public static void SetVectorArray<T>(MaterialPropertyBlock props, int name, NativeSlice<T> vector4s)
			where T : struct;
		[RequiredByNativeCode]
		internal static void RaiseGraphicsResourcesRecreate(bool recreate); // 0x000000018D690240-0x000000018D690298
		[RequiredByNativeCode]
		internal static void RaiseEngineUpdate(); // 0x000000018D690180-0x000000018D6901F0
		[RequiredByNativeCode]
		internal static void RaiseFlushPendingResources(); // 0x000000018D6901F0-0x000000018D690240
		[RequiredByNativeCode]
		internal static void RaiseRegisterIntermediateRenderers(Camera camera); // 0x000000018D690298-0x000000018D6902F4
		[RequiredByNativeCode]
		internal static void RaiseRenderNodeAdd(IntPtr userData); // 0x000000018D6902F4-0x000000018D690350
		[RequiredByNativeCode]
		internal static void RaiseRenderNodeExecute(IntPtr userData); // 0x000000018D6903AC-0x000000018D690408
		[RequiredByNativeCode]
		internal static void RaiseRenderNodeCleanup(IntPtr userData); // 0x000000018D690350-0x000000018D6903AC
		[ThreadSafe]
		private static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer); // 0x000000018D68FD98-0x000000018D68FDE8
		[ThreadSafe]
		private static void FreeBuffer(IntPtr buffer); // 0x000000018D68FF2C-0x000000018D68FF60
		[ThreadSafe]
		private static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd); // 0x000000018D6906C4-0x000000018D690728
		[ThreadSafe]
		private static void SetVectorArray(MaterialPropertyBlock props, int name, IntPtr vector4s, int count); // 0x000000018D690638-0x000000018D690698
		[ThreadSafe]
		public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes); // 0x000000018D690068-0x000000018D69009C
		public static void RegisterIntermediateRenderer(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize); // 0x000000018D690470-0x000000018D690544
		[ThreadSafe]
		public static unsafe void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl); // 0x000000018D68FEC8-0x000000018D68FF2C
		[ThreadSafe]
		public static void SetPropertyBlock(MaterialPropertyBlock props); // 0x000000018D690544-0x000000018D690578
		[ThreadSafe]
		public static void SetScissorRect(RectInt scissorRect); // 0x000000018D6905AC-0x000000018D6905F8
		[ThreadSafe]
		public static void DisableScissor(); // 0x000000018D68FE9C-0x000000018D68FEC8
		[ThreadSafe]
		public static IntPtr CreateStencilState(StencilState stencilState); // 0x000000018D68FE50-0x000000018D68FE9C
		[ThreadSafe]
		public static void SetStencilState(IntPtr stencilState, int stencilRef); // 0x000000018D6905F8-0x000000018D690638
		[ThreadSafe]
		public static bool HasMappedBufferRange(); // 0x000000018D69009C-0x000000018D6900C8
		[ThreadSafe]
		public static uint InsertCPUFence(); // 0x000000018D6900C8-0x000000018D6900F4
		[ThreadSafe]
		public static bool CPUFencePassed(uint fence); // 0x000000018D68FDE8-0x000000018D68FE1C
		[ThreadSafe]
		public static void WaitForCPUFencePassed(uint fence); // 0x000000018D690728-0x000000018D69075C
		[ThreadSafe]
		public static void SyncRenderThread(); // 0x000000018D690698-0x000000018D6906C4
		[ThreadSafe]
		public static RectInt GetActiveViewport(); // 0x000000018D68FF94-0x000000018D68FFE0
		[ThreadSafe]
		public static void ProfileDrawChainBegin(); // 0x000000018D690128-0x000000018D690154
		[ThreadSafe]
		public static void ProfileDrawChainEnd(); // 0x000000018D690154-0x000000018D690180
		public static void NotifyOfUIREvents(bool subscribe); // 0x000000018D6900F4-0x000000018D690128
		[ThreadSafe]
		public static Matrix4x4 GetUnityProjectionMatrix(); // 0x000000018D690014-0x000000018D690068
		private static void RegisterIntermediateRenderer_Injected(Camera camera, Material material, ref Matrix4x4 transform, ref Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize); // 0x000000018D690408-0x000000018D690470
		private static void SetScissorRect_Injected(ref RectInt scissorRect); // 0x000000018D690578-0x000000018D6905AC
		private static IntPtr CreateStencilState_Injected(ref StencilState stencilState); // 0x000000018D68FE1C-0x000000018D68FE50
		private static void GetActiveViewport_Injected(out RectInt ret); // 0x000000018D68FF60-0x000000018D68FF94
		private static void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret); // 0x000000018D68FFE0-0x000000018D690014
	}
}

namespace UnityEngine.Yoga
{
	internal delegate float BaselineFunction(YogaNode node, float width, float height); // TypeDefIndex: 90182; 0x000000018238E680-0x000000018238E6A0

	internal delegate void Logger(YogaConfig config, YogaNode node, YogaLogLevel level, string message); // TypeDefIndex: 90183; 0x00000001811CDB70-0x00000001811CDB90

	internal delegate YogaSize MeasureFunction(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode); // TypeDefIndex: 90184; 0x000000018415EF40-0x000000018415EF60

	internal class MeasureOutput // TypeDefIndex: 90185
	{
		// Methods
		public static YogaSize Make(float width, float height); // 0x0000000187263D60-0x0000000187263D70
	}

	internal enum YogaAlign // TypeDefIndex: 90186
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

	internal class YogaConfig // TypeDefIndex: 90187
	{
		// Fields
		internal static readonly YogaConfig Default; // 0x00
		private IntPtr _ygConfig; // 0x10
		private UnityEngine.Yoga.Logger _logger; // 0x18
	
		// Properties
		internal IntPtr Handle { get; } // 0x0000000187249840-0x0000000187249850 
		public bool UseWebDefaults { get; set; } // 0x000000018D6911A0-0x000000018D6911B0 0x000000018D6911BC-0x000000018D6911C8
		public float PointScaleFactor { set; } // 0x000000018D6911B0-0x000000018D6911BC
	
		// Constructors
		private YogaConfig(IntPtr ygConfig); // 0x000000018D691134-0x000000018D6911A0
		public YogaConfig(); // 0x000000018D691110-0x000000018D691134
		static YogaConfig(); // 0x000000018D691088-0x000000018D691110
	
		// Methods
		~YogaConfig(); // 0x000000018D690FB8-0x000000018D691088
	}

	internal static class YogaConstants // TypeDefIndex: 90188
	{
		// Methods
		public static bool IsUndefined(float value); // 0x000000018D6911C8-0x000000018D6911D0
	}

	internal enum YogaDirection // TypeDefIndex: 90189
	{
		Inherit = 0,
		LTR = 1,
		RTL = 2
	}

	internal enum YogaDisplay // TypeDefIndex: 90190
	{
		Flex = 0,
		None = 1
	}

	internal enum YogaEdge // TypeDefIndex: 90191
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

	internal enum YogaFlexDirection // TypeDefIndex: 90192
	{
		Column = 0,
		ColumnReverse = 1,
		Row = 2,
		RowReverse = 3
	}

	internal enum YogaJustify // TypeDefIndex: 90193
	{
		FlexStart = 0,
		Center = 1,
		FlexEnd = 2,
		SpaceBetween = 3,
		SpaceAround = 4
	}

	internal enum YogaLogLevel // TypeDefIndex: 90194
	{
		Error = 0,
		Warn = 1,
		Info = 2,
		Debug = 3,
		Verbose = 4,
		Fatal = 5
	}

	internal enum YogaMeasureMode // TypeDefIndex: 90195
	{
		Undefined = 0,
		Exactly = 1,
		AtMost = 2
	}

	[NativeHeader("Modules/UIElementsNative/YogaNative.bindings.h")]
	internal static class Native // TypeDefIndex: 90196
	{
		// Methods
		[FreeFunction]
		public static IntPtr YGNodeNewWithConfig(IntPtr config); // 0x000000018D68E8C4-0x000000018D68E8F8
		public static void YGNodeFree(IntPtr ygNode); // 0x000000018D68E59C-0x000000018D68E5AC
		[FreeFunction(Name = "YGNodeFree", IsThreadSafe = true)]
		private static void YGNodeFreeInternal(IntPtr ygNode); // 0x000000018D68E568-0x000000018D68E59C
		[FreeFunction]
		public static void YGSetManagedObject(IntPtr ygNode, YogaNode node); // 0x000000018D68F430-0x000000018D68F474
		[FreeFunction]
		public static void YGNodeSetConfig(IntPtr ygNode, IntPtr config); // 0x000000018D68E970-0x000000018D68E9B4
		[FreeFunction(IsThreadSafe = true)]
		public static IntPtr YGConfigGetDefault(); // 0x000000018D68E390-0x000000018D68E3BC
		[FreeFunction]
		public static IntPtr YGConfigNew(); // 0x000000018D68E3F0-0x000000018D68E41C
		public static void YGConfigFree(IntPtr config); // 0x000000018D68E380-0x000000018D68E390
		[FreeFunction(Name = "YGConfigFree", IsThreadSafe = true)]
		private static void YGConfigFreeInternal(IntPtr config); // 0x000000018D68E34C-0x000000018D68E380
		[FreeFunction]
		public static void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults); // 0x000000018D68E460-0x000000018D68E4A4
		[FreeFunction]
		public static bool YGConfigGetUseWebDefaults(IntPtr config); // 0x000000018D68E3BC-0x000000018D68E3F0
		[FreeFunction]
		public static void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint); // 0x000000018D68E41C-0x000000018D68E460
		[FreeFunction]
		public static void YGNodeInsertChild(IntPtr node, IntPtr child, uint index); // 0x000000018D68E5E0-0x000000018D68E634
		[FreeFunction]
		public static void YGNodeRemoveChild(IntPtr node, IntPtr child); // 0x000000018D68E8F8-0x000000018D68E93C
		[FreeFunction]
		public static void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection); // 0x000000018D68E4C0-0x000000018D68E524
		[FreeFunction]
		public static void YGNodeMarkDirty(IntPtr node); // 0x000000018D68E860-0x000000018D68E894
		[FreeFunction]
		public static bool YGNodeIsDirty(IntPtr node); // 0x000000018D68E634-0x000000018D68E668
		[FreeFunction]
		public static void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode); // 0x000000018D68E524-0x000000018D68E568
		[FreeFunction(Name = "YogaCallback::SetMeasureFunc")]
		public static void YGNodeSetMeasureFunc(IntPtr node); // 0x000000018D68E9F8-0x000000018D68EA2C
		[FreeFunction(Name = "YogaCallback::RemoveMeasureFunc")]
		public static void YGNodeRemoveMeasureFunc(IntPtr node); // 0x000000018D68E93C-0x000000018D68E970
		[RequiredByNativeCode]
		public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress); // 0x000000018D68E894-0x000000018D68E8C4
		[RequiredByNativeCode]
		public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress); // 0x000000018D68E4A4-0x000000018D68E4C0
		[FreeFunction]
		public static void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout); // 0x000000018D68E9B4-0x000000018D68E9F8
		[FreeFunction]
		public static bool YGNodeGetHasNewLayout(IntPtr node); // 0x000000018D68E5AC-0x000000018D68E5E0
		[FreeFunction]
		public static YogaDirection YGNodeStyleGetDirection(IntPtr node); // 0x000000018D68EA2C-0x000000018D68EA60
		[FreeFunction]
		public static void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection); // 0x000000018D68EC6C-0x000000018D68ECAC
		[FreeFunction]
		public static void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent); // 0x000000018D68EE74-0x000000018D68EEB4
		[FreeFunction]
		public static void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent); // 0x000000018D68EA60-0x000000018D68EAA0
		[FreeFunction]
		public static void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems); // 0x000000018D68EAA0-0x000000018D68EAE0
		[FreeFunction]
		public static void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf); // 0x000000018D68EAE0-0x000000018D68EB20
		[FreeFunction]
		public static void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType); // 0x000000018D68F2E4-0x000000018D68F324
		[FreeFunction]
		public static void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap); // 0x000000018D68ED34-0x000000018D68ED74
		[FreeFunction]
		public static void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap); // 0x000000018D68F1B4-0x000000018D68F1F4
		[FreeFunction]
		public static void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display); // 0x000000018D68EB70-0x000000018D68EBB0
		[FreeFunction]
		public static void YGNodeStyleSetFlex(IntPtr node, float flex); // 0x000000018D68ED74-0x000000018D68EDB8
		[FreeFunction]
		public static void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow); // 0x000000018D68ECAC-0x000000018D68ECF0
		[FreeFunction]
		public static void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink); // 0x000000018D68ECF0-0x000000018D68ED34
		[FreeFunction]
		public static void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis); // 0x000000018D68EC28-0x000000018D68EC6C
		[FreeFunction]
		public static void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis); // 0x000000018D68EBE4-0x000000018D68EC28
		[FreeFunction]
		public static void YGNodeStyleSetFlexBasisAuto(IntPtr node); // 0x000000018D68EBB0-0x000000018D68EBE4
		[FreeFunction]
		public static void YGNodeStyleSetWidth(IntPtr node, float width); // 0x000000018D68F3EC-0x000000018D68F430
		[FreeFunction]
		public static void YGNodeStyleSetWidthPercent(IntPtr node, float width); // 0x000000018D68F3A8-0x000000018D68F3EC
		[FreeFunction]
		public static void YGNodeStyleSetWidthAuto(IntPtr node); // 0x000000018D68F374-0x000000018D68F3A8
		[FreeFunction]
		public static void YGNodeStyleSetHeight(IntPtr node, float height); // 0x000000018D68EE30-0x000000018D68EE74
		[FreeFunction]
		public static void YGNodeStyleSetHeightPercent(IntPtr node, float height); // 0x000000018D68EDEC-0x000000018D68EE30
		[FreeFunction]
		public static void YGNodeStyleSetHeightAuto(IntPtr node); // 0x000000018D68EDB8-0x000000018D68EDEC
		[FreeFunction]
		public static void YGNodeStyleSetMinWidth(IntPtr node, float minWidth); // 0x000000018D68F170-0x000000018D68F1B4
		[FreeFunction]
		public static void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth); // 0x000000018D68F12C-0x000000018D68F170
		[FreeFunction]
		public static void YGNodeStyleSetMinHeight(IntPtr node, float minHeight); // 0x000000018D68F0E8-0x000000018D68F12C
		[FreeFunction]
		public static void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight); // 0x000000018D68F0A4-0x000000018D68F0E8
		[FreeFunction]
		public static void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth); // 0x000000018D68F060-0x000000018D68F0A4
		[FreeFunction]
		public static void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth); // 0x000000018D68F01C-0x000000018D68F060
		[FreeFunction]
		public static void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight); // 0x000000018D68EFD8-0x000000018D68F01C
		[FreeFunction]
		public static void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight); // 0x000000018D68EF94-0x000000018D68EFD8
		[FreeFunction]
		public static void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position); // 0x000000018D68F324-0x000000018D68F374
		[FreeFunction]
		public static void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position); // 0x000000018D68F294-0x000000018D68F2E4
		[FreeFunction]
		public static void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin); // 0x000000018D68EF44-0x000000018D68EF94
		[FreeFunction]
		public static void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin); // 0x000000018D68EEF4-0x000000018D68EF44
		[FreeFunction]
		public static void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge); // 0x000000018D68EEB4-0x000000018D68EEF4
		[FreeFunction]
		public static void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding); // 0x000000018D68F244-0x000000018D68F294
		[FreeFunction]
		public static void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding); // 0x000000018D68F1F4-0x000000018D68F244
		[FreeFunction]
		public static void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border); // 0x000000018D68EB20-0x000000018D68EB70
		[FreeFunction]
		public static float YGNodeLayoutGetLeft(IntPtr node); // 0x000000018D68E710-0x000000018D68E744
		[FreeFunction]
		public static float YGNodeLayoutGetTop(IntPtr node); // 0x000000018D68E7F8-0x000000018D68E82C
		[FreeFunction]
		public static float YGNodeLayoutGetRight(IntPtr node); // 0x000000018D68E7C4-0x000000018D68E7F8
		[FreeFunction]
		public static float YGNodeLayoutGetBottom(IntPtr node); // 0x000000018D68E6A8-0x000000018D68E6DC
		[FreeFunction]
		public static float YGNodeLayoutGetWidth(IntPtr node); // 0x000000018D68E82C-0x000000018D68E860
		[FreeFunction]
		public static float YGNodeLayoutGetHeight(IntPtr node); // 0x000000018D68E6DC-0x000000018D68E710
		[FreeFunction]
		public static float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge); // 0x000000018D68E744-0x000000018D68E784
		[FreeFunction]
		public static float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge); // 0x000000018D68E784-0x000000018D68E7C4
		[FreeFunction]
		public static float YGNodeLayoutGetBorder(IntPtr node, YogaEdge edge); // 0x000000018D68E668-0x000000018D68E6A8
	}

	[DefaultMember("Item")]
	internal class YogaNode : IEnumerable<YogaNode> // TypeDefIndex: 90197
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
		internal YogaConfig Config { set; } // 0x000000018D691B24-0x000000018D691BB0
		public bool IsDirty { get; } // 0x000000018D69194C-0x000000018D69195C 
		public bool HasNewLayout { get; } // 0x000000018D69193C-0x000000018D69194C 
		public bool IsMeasureDefined { get; } // 0x000000018C1B5D60-0x000000018C1B5D6C 
		public bool IsBaselineDefined { get; } // 0x000000018C1B5D6C-0x000000018C1B5D78 
		public YogaFlexDirection FlexDirection { set; } // 0x000000018D691C10-0x000000018D691C1C
		public YogaJustify JustifyContent { set; } // 0x000000018D691C94-0x000000018D691CA0
		public YogaDisplay Display { set; } // 0x000000018D691BB0-0x000000018D691BBC
		public YogaAlign AlignItems { set; } // 0x000000018D691AAC-0x000000018D691AB8
		public YogaAlign AlignSelf { set; } // 0x000000018D691AB8-0x000000018D691AC4
		public YogaAlign AlignContent { set; } // 0x000000018D691AA0-0x000000018D691AAC
		public YogaPositionType PositionType { set; } // 0x000000018D691E0C-0x000000018D691E18
		public YogaWrap Wrap { set; } // 0x000000018D691E8C-0x000000018D691E98
		public float Flex { set; } // 0x000000018D691C34-0x000000018D691C40
		public float FlexGrow { set; } // 0x000000018D691C1C-0x000000018D691C28
		public float FlexShrink { set; } // 0x000000018D691C28-0x000000018D691C34
		public YogaValue FlexBasis { set; } // 0x000000018D691BBC-0x000000018D691C10
		public YogaValue Width { set; } // 0x000000018D691E38-0x000000018D691E8C
		public YogaValue Height { set; } // 0x000000018D691C40-0x000000018D691C94
		public YogaValue MaxWidth { set; } // 0x000000018D691D24-0x000000018D691D58
		public YogaValue MaxHeight { set; } // 0x000000018D691CF0-0x000000018D691D24
		public YogaValue MinWidth { set; } // 0x000000018D691D8C-0x000000018D691DC0
		public YogaValue MinHeight { set; } // 0x000000018D691D58-0x000000018D691D8C
		public float LayoutX { get; } // 0x000000018D691A80-0x000000018D691A90 
		public float LayoutY { get; } // 0x000000018D691A90-0x000000018D691AA0 
		public float LayoutRight { get; } // 0x000000018D691A60-0x000000018D691A70 
		public float LayoutBottom { get; } // 0x000000018D6919A8-0x000000018D6919B8 
		public float LayoutWidth { get; } // 0x000000018D691A70-0x000000018D691A80 
		public float LayoutHeight { get; } // 0x000000018D6919B8-0x000000018D6919C8 
		public YogaOverflow Overflow { set; } // 0x000000018D691DC0-0x000000018D691DCC
		public int Count { get; } // 0x000000018D6918F8-0x000000018D69193C 
		public YogaValue Left { set; } // 0x000000018D691CA0-0x000000018D691CB0
		public YogaValue Top { set; } // 0x000000018D691E28-0x000000018D691E38
		public YogaValue Right { set; } // 0x000000018D691E18-0x000000018D691E28
		public YogaValue Bottom { set; } // 0x000000018D691B14-0x000000018D691B24
		public YogaValue MarginLeft { set; } // 0x000000018D691CC0-0x000000018D691CD0
		public YogaValue MarginTop { set; } // 0x000000018D691CE0-0x000000018D691CF0
		public YogaValue MarginRight { set; } // 0x000000018D691CD0-0x000000018D691CE0
		public YogaValue MarginBottom { set; } // 0x000000018D691CB0-0x000000018D691CC0
		public YogaValue PaddingLeft { set; } // 0x000000018D691DDC-0x000000018D691DEC
		public YogaValue PaddingTop { set; } // 0x000000018D691DFC-0x000000018D691E0C
		public YogaValue PaddingRight { set; } // 0x000000018D691DEC-0x000000018D691DFC
		public YogaValue PaddingBottom { set; } // 0x000000018D691DCC-0x000000018D691DDC
		public float BorderLeftWidth { set; } // 0x000000018D691AD8-0x000000018D691AEC
		public float BorderTopWidth { set; } // 0x000000018D691B00-0x000000018D691B14
		public float BorderRightWidth { set; } // 0x000000018D691AEC-0x000000018D691B00
		public float BorderBottomWidth { set; } // 0x000000018D691AC4-0x000000018D691AD8
		public float LayoutMarginLeft { get; } // 0x000000018D6919DC-0x000000018D6919EC 
		public float LayoutMarginTop { get; } // 0x000000018D691A00-0x000000018D691A14 
		public float LayoutMarginRight { get; } // 0x000000018D6919EC-0x000000018D691A00 
		public float LayoutMarginBottom { get; } // 0x000000018D6919C8-0x000000018D6919DC 
		public float LayoutPaddingLeft { get; } // 0x000000018D691A28-0x000000018D691A38 
		public float LayoutPaddingTop { get; } // 0x000000018D691A4C-0x000000018D691A60 
		public float LayoutPaddingRight { get; } // 0x000000018D691A38-0x000000018D691A4C 
		public float LayoutPaddingBottom { get; } // 0x000000018D691A14-0x000000018D691A28 
		public float LayoutBorderLeft { get; } // 0x000000018D691970-0x000000018D691980 
		public float LayoutBorderTop { get; } // 0x000000018D691994-0x000000018D6919A8 
		public float LayoutBorderRight { get; } // 0x000000018D691980-0x000000018D691994 
		public float LayoutBorderBottom { get; } // 0x000000018D69195C-0x000000018D691970 
	
		// Constructors
		public YogaNode(YogaConfig config = null); // 0x000000018D69181C-0x000000018D6918F8
	
		// Methods
		~YogaNode(); // 0x000000018D691330-0x000000018D6913A8
		public virtual void MarkDirty(); // 0x000000018D691530-0x000000018D69153C
		public void CopyStyle(YogaNode srcNode); // 0x000000018D69130C-0x000000018D691330
		public void MarkLayoutSeen(); // 0x000000018D69153C-0x000000018D69154C
		public void Insert(int index, YogaNode node); // 0x000000018D691414-0x000000018D691530
		public void RemoveAt(int index); // 0x000000018D6915E8-0x000000018D691690
		public void Clear(); // 0x000000018D6912B0-0x000000018D69130C
		public void SetMeasureFunction(MeasureFunction measureFunction); // 0x000000018D691690-0x000000018D6916F4
		public void CalculateLayout(float width = 0F / 0F /* Metadata: 0x0264AC9B */, float height = 0F / 0F /* Metadata: 0x0264AC9F */); // 0x000000018D691260-0x000000018D6912B0
		public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode); // 0x000000018D69154C-0x000000018D6915E8
		public static float BaselineInternal(YogaNode node, float width, float height); // 0x000000018D6911D0-0x000000018D691260
		public IEnumerator<YogaNode> GetEnumerator(); // 0x000000018D6913A8-0x000000018D691414
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D6917B0-0x000000018D69181C
		private void SetStylePosition(YogaEdge edge, YogaValue value); // 0x000000018D69177C-0x000000018D6917B0
		private void SetStyleMargin(YogaEdge edge, YogaValue value); // 0x000000018D6916F4-0x000000018D691748
		private void SetStylePadding(YogaEdge edge, YogaValue value); // 0x000000018D691748-0x000000018D69177C
	}

	internal enum YogaOverflow // TypeDefIndex: 90198
	{
		Visible = 0,
		Hidden = 1,
		Scroll = 2
	}

	internal enum YogaPositionType // TypeDefIndex: 90199
	{
		Relative = 0,
		Absolute = 1
	}

	internal struct YogaSize // TypeDefIndex: 90200
	{
		// Fields
		public float width; // 0x00
		public float height; // 0x04
	}

	internal enum YogaUnit // TypeDefIndex: 90201
	{
		Undefined = 0,
		Point = 1,
		Percent = 2,
		Auto = 3
	}

	internal struct YogaValue // TypeDefIndex: 90202
	{
		// Fields
		private float value; // 0x00
		private YogaUnit unit; // 0x04
	
		// Properties
		public YogaUnit Unit { get; } // 0x000000018724CA40-0x000000018724CA50 
		public float Value { get; } // 0x000000018725FF90-0x000000018725FFA0 
	
		// Methods
		public static YogaValue Point(float value); // 0x000000018D691FB0-0x000000018D691FD0
		public bool Equals(YogaValue other); // 0x000000018D691E98-0x000000018D691EEC
		public override bool Equals(object obj); // 0x000000018D691EEC-0x000000018D691F5C
		public override int GetHashCode(); // 0x000000018D691F5C-0x000000018D691F8C
		public static YogaValue Auto(); // 0x0000000187263D70-0x0000000187263D90
		public static YogaValue Percent(float value); // 0x000000018D691F8C-0x000000018D691FB0
		public static implicit operator YogaValue(float pointValue); // 0x000000018D691FB0-0x000000018D691FD0
	}

	internal enum YogaWrap // TypeDefIndex: 90203
	{
		NoWrap = 0,
		Wrap = 1,
		WrapReverse = 2
	}
}
