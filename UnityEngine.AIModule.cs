/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

// Image 92: UnityEngine.AIModule.dll - Assembly: UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62941-62969
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: InternalsVisibleTo("UnityEngine.RuntimeInitializeOnLoadManagerInitializerModule")]
[assembly: InternalsVisibleTo("UnityEngine.GameCenterModule")]
[assembly: InternalsVisibleTo("UnityEngine.GIModule")]
[assembly: InternalsVisibleTo("UnityEngine.GridModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsCPPModule")]
[assembly: InternalsVisibleTo("UnityEngine.AudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.HotReloadModule")]
[assembly: InternalsVisibleTo("UnityEngine.ImageConversionModule")]
[assembly: InternalsVisibleTo("UnityEngine.PS5Module")]
[assembly: InternalsVisibleTo("UnityEngine")]
[assembly: InternalsVisibleTo("UnityEngine.SharedInternalsModule")]
[assembly: InternalsVisibleTo("UnityEngine.CoreModule")]
[assembly: InternalsVisibleTo("UnityEngine.AccessibilityModule")]
[assembly: InternalsVisibleTo("UnityEngine.AndroidJNIModule")]
[assembly: InternalsVisibleTo("UnityEngine.AIModule")]
[assembly: InternalsVisibleTo("UnityEngine.DSPGraphModule")]
[assembly: InternalsVisibleTo("UnityEngine.AssetBundleModule")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.009")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.010")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud")]
[assembly: InternalsVisibleTo("UnityEngine.Networking")]
[assembly: InternalsVisibleTo("UnityEngine.PS5VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsModule")]
[assembly: InternalsVisibleTo("UnityEngine.DirectorModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClothModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterRendererModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityConnectModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommonModule")]
[assembly: InternalsVisibleTo("UnityEngine.TLSModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestModule")]
[assembly: InternalsVisibleTo("UnityEngine.CrashReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.ClusterInputModule")]
[assembly: InternalsVisibleTo("UnityEngine.AnimationModule")]
[assembly: InternalsVisibleTo("UnityEngine.ARModule")]
[assembly: InternalsVisibleTo("UnityEngine.AntiSDKModule")]
[assembly: InternalsVisibleTo("UnityEngine.VehiclesModule")]
[assembly: InternalsVisibleTo("UnityEngine.VFXModule")]
[assembly: InternalsVisibleTo("UnityEngine.VideoModule")]
[assembly: InternalsVisibleTo("UnityEngine.VirtualTexturingModule")]
[assembly: InternalsVisibleTo("UnityEngine.XRModule")]
[assembly: InternalsVisibleTo("UnityEngine.VRModule")]
[assembly: InternalsVisibleTo("UnityEngine.IMGUIModule")]
[assembly: InternalsVisibleTo("UnityEngine.WindModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIModule")]
[assembly: InternalsVisibleTo("UnityEngine.TilemapModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreTextEngineModule")]
[assembly: InternalsVisibleTo("UnityEngine.LiteSSLModule")]
[assembly: InternalsVisibleTo("UnityEngine.LocalizationModule")]
[assembly: InternalsVisibleTo("UnityEngine.PerformanceReportingModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsNativeModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestWWWModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAudioModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestAssetBundleModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainModule")]
[assembly: InternalsVisibleTo("UnityEngine.ParticleSystemModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGGraphicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.PhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.JSONSerializeModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputModule")]
[assembly: InternalsVisibleTo("UnityEngine.HGOcclusionCullingModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextRenderingModule")]
[assembly: InternalsVisibleTo("UnityEngine.InputLegacyModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityWebRequestTextureModule")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsModule")]
[assembly: InternalsVisibleTo("UnityEngine.UmbraModule")]
[assembly: InternalsVisibleTo("UnityEngine.UNETModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityCurlModule")]
[assembly: InternalsVisibleTo("UnityEngine.UnityTestProtocolModule")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.008")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.007")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.006")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.005")]
[assembly: InternalsVisibleTo("Unity.Automation")]
[assembly: InternalsVisibleTo("UnityEngine.Cloud.Service")]
[assembly: InternalsVisibleTo("Unity.Analytics")]
[assembly: InternalsVisibleTo("UnityEngine.Analytics")]
[assembly: InternalsVisibleTo("UnityEngine.UnityAnalyticsCommon")]
[assembly: InternalsVisibleTo("UnityEngine.Advertisements")]
[assembly: InternalsVisibleTo("Unity.Networking.Transport")]
[assembly: InternalsVisibleTo("UnityEngine.Purchasing")]
[assembly: InternalsVisibleTo("Unity.Burst")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.Framework")]
[assembly: InternalsVisibleTo("Unity.Burst.Editor")]
[assembly: InternalsVisibleTo("Unity.DeploymentTests.Services")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.UnityAnalytics")]
[assembly: InternalsVisibleTo("UnityEngine.TestRunner")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.Framework.Tests")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests.AllIn1Runner")]
[assembly: InternalsVisibleTo("Unity.UIElements.EditorTests")]
[assembly: InternalsVisibleTo("Unity.Timeline")]
[assembly: InternalsVisibleTo("Assembly-CSharp-testable")]
[assembly: InternalsVisibleTo("Assembly-CSharp-firstpass-testable")]
[assembly: InternalsVisibleTo("UnityEngine.SpatialTracking")]
[assembly: InternalsVisibleTo("GoogleAR.UnityNative")]
[assembly: InternalsVisibleTo("Unity.WindowsMRAutomation")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.Editor")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.Editor")]
[assembly: InternalsVisibleTo("Unity.PerformanceTests.RuntimeTestRunner.Tests")]
[assembly: InternalsVisibleTo("UnityEditor.UIBuilderModule")]
[assembly: InternalsVisibleTo("Unity.UI.Builder.EditorTests")]
[assembly: InternalsVisibleTo("Unity.UIElements")]
[assembly: InternalsVisibleTo("UnityEngine.UIElementsGameObjectsModule")]
[assembly: InternalsVisibleTo("Unity.UIElements.Editor")]
[assembly: InternalsVisibleTo("Unity.UIElements.PlayModeTests")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.Timeline")]
[assembly: InternalsVisibleTo("UnityEngine.Physics2DModule")]
[assembly: InternalsVisibleTo("Unity.IntegrationTests.Framework")]
[assembly: InternalsVisibleTo("UnityEngine.UI")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.014")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.012")]
[assembly: InternalsVisibleTo("Unity.Services.QoS")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.002")]
[assembly: InternalsVisibleTo("Unity.Logging")]
[assembly: InternalsVisibleTo("Unity.Entities")]
[assembly: InternalsVisibleTo("Unity.Subsystem.Registration")]
[assembly: InternalsVisibleTo("Unity.Entities.Tests")]
[assembly: InternalsVisibleTo("Unity.Runtime")]
[assembly: InternalsVisibleTo("Unity.Core")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.001")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.003")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.011")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.004")]
[assembly: InternalsVisibleTo("Unity.Collections")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.005")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.004")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.003")]
[assembly: InternalsVisibleTo("Unity.ucg.QoS")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.022")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.015")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.016")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.017")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.018")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.019")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.020")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.021")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.023")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.013")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridge.024")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.001")]
[assembly: InternalsVisibleTo("Unity.InternalAPIEngineBridgeDev.002")]
[assembly: InternalsVisibleTo("Unity.RuntimeTests")]
[assembly: InternalsVisibleTo("UnityEngine.ProfilerModule")]
[assembly: InternalsVisibleTo("UnityEngine.ScreenCaptureModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteMaskModule")]
[assembly: InternalsVisibleTo("UnityEngine.SpriteShapeModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamingModule")]
[assembly: InternalsVisibleTo("UnityEngine.StreamLineModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubstanceModule")]
[assembly: InternalsVisibleTo("UnityEngine.SubsystemsModule")]
[assembly: InternalsVisibleTo("UnityEngine.TerrainPhysicsModule")]
[assembly: InternalsVisibleTo("UnityEngine.TextCoreFontEngineModule")]
[assembly: InternalsVisibleTo("Unity.2D.Sprite.EditorTests")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: UnityEngineModuleAssembly]

namespace Microsoft.CodeAnalysis
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute // TypeDefIndex: 62942
	{
		// Constructors
		public EmbeddedAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace System.Runtime.CompilerServices
{
	[CompilerGenerated]
	[Embedded]
	internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 62943
	{
		// Constructors
		public IsReadOnlyAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace UnityEngine.AI
{
	[MovedFrom("UnityEngine")]
	public enum NavMeshPathStatus // TypeDefIndex: 62944
	{
		PathComplete = 0,
		PathPartial = 1,
		PathInvalid = 2,
		PathProcessing = 3
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMeshPath.bindings.h")]
	public sealed class NavMeshPath // TypeDefIndex: 62945
	{
		// Fields
		internal IntPtr m_Ptr; // 0x10
		internal Vector3[] m_Corners; // 0x18
		internal int[] m_Areas; // 0x20
		internal Vector3[] m_DividingPos; // 0x28
	
		// Properties
		public Vector3[] corners { get; } // 0x00000001853969FC-0x0000000185396A18 
		public NavMeshPathStatus status { get; } // 0x0000000183F7E9A0-0x0000000183F7E9E0 
		public bool needRepath { get; set; } // 0x00000001834ED480-0x00000001834ED4C0 0x00000001832C21F0-0x00000001832C2240
		public bool calcAutoRepath { set; } // 0x00000001832C21A0-0x00000001832C21F0
	
		// Constructors
		public NavMeshPath(); // 0x00000001834847A0-0x00000001834847C0
	
		// Methods
		~NavMeshPath(); // 0x0000000184B21C40-0x0000000184B21CD0
		[FreeFunction("NavMeshPathScriptBindings::InitializeNavMeshPath")]
		private static IntPtr InitializeNavMeshPath(); // 0x00000001834847C0-0x0000000183484800
		[FreeFunction("NavMeshPathScriptBindings::DestroyNavMeshPath", IsThreadSafe = true)]
		private static void DestroyNavMeshPath(IntPtr ptr); // 0x0000000184B21CD0-0x0000000184B21D10
		[FreeFunction("NavMeshPathScriptBindings::GetCornersNonAlloc", HasExplicitThis = true)]
		public int GetCornersNonAlloc(out Vector3[] corners, out int[] areas = null, out Vector3[] dividingPos = null); // 0x000000018457B2E0-0x000000018457B350
		[FreeFunction("NavMeshPathScriptBindings::GetPolyCount", HasExplicitThis = true)]
		public int GetPolyCount(); // 0x0000000184693A20-0x0000000184693A60
		[FreeFunction("NavMeshPathScriptBindings::CalculateCornersInternal", HasExplicitThis = true)]
		private Vector3[] CalculateCornersInternal(); // 0x0000000184992840-0x0000000184992880
		[FreeFunction("NavMeshPathScriptBindings::ClearCornersInternal", HasExplicitThis = true)]
		private void ClearCornersInternal(); // 0x0000000183F7FC10-0x0000000183F7FC50
		public void ClearCorners(); // 0x0000000183F7FBE0-0x0000000183F7FC10
		private void CalculateCorners(); // 0x0000000184992810-0x0000000184992840
	}

	[NativeHeader("Modules/AI/Builder/NavMeshBuilder.bindings.h")]
	[StaticAccessor("NavMeshBuilderBindings", StaticAccessorType.DoubleColon)]
	public static class NavMeshBuilder // TypeDefIndex: 62946
	{
		// Methods
		public static void CollectSources(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results); // 0x000000018B389C7C-0x000000018B389E88
		public static void CollectSources(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results); // 0x000000018B389ACC-0x000000018B389C7C
		private static NavMeshBuildSource[] CollectSourcesInternal(int includedLayerMask, Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups); // 0x000000018B389A98-0x000000018B389ACC
		public static void CollectSourcesV2(Bounds includedWorldBounds, int includedLayerMask, int defaultArea, List<NavMeshBuildMarkup> markups, List<NavMeshBuildSource> results); // 0x0000000184415270-0x00000001844153D0
		private static NavMeshBuildSource[] CollectSourcesV2Internal(int includedLayerMask, Bounds includedWorldBounds, int defaultArea, NavMeshBuildMarkup[] markups); // 0x0000000185397650-0x0000000185397668
		public static NavMeshData BuildNavMeshData(NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, Vector3 position, Quaternion rotation, bool useSubJob = false /* Metadata: 0x023523EA */); // 0x000000018B3898A8-0x000000018B389A38
		public static bool UpdateNavMeshData(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, bool useSubJob = false /* Metadata: 0x023523EB */); // 0x000000018B389F0C-0x000000018B38A0B4
		private static bool UpdateNavMeshDataListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds, bool useSubJob); // 0x000000018B389EEC-0x000000018B389F0C
		public static AsyncOperation UpdateNavMeshDataAsync(NavMeshData data, NavMeshBuildSettings buildSettings, List<NavMeshBuildSource> sources, Bounds localBounds, bool useSubJob = false /* Metadata: 0x023523EC */); // 0x0000000184972100-0x0000000184972270
		private static AsyncOperation UpdateNavMeshDataAsyncListInternal(NavMeshData data, NavMeshBuildSettings buildSettings, object sources, Bounds localBounds, bool useSubJob); // 0x0000000185397DFC-0x0000000185397E1C
		private static NavMeshBuildSource[] CollectSourcesInternal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, Transform root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, NavMeshBuildMarkup[] markups); // 0x000000018B389A38-0x000000018B389A98
		private static NavMeshBuildSource[] CollectSourcesV2Internal_Injected(int includedLayerMask, ref Bounds includedWorldBounds, int defaultArea, NavMeshBuildMarkup[] markups); // 0x0000000184D109D0-0x0000000184D10A40
		private static bool UpdateNavMeshDataListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds, bool useSubJob); // 0x000000018B389E88-0x000000018B389EEC
		private static AsyncOperation UpdateNavMeshDataAsyncListInternal_Injected(NavMeshData data, ref NavMeshBuildSettings buildSettings, object sources, ref Bounds localBounds, bool useSubJob); // 0x0000000184972270-0x00000001849722F0
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[NativeHeader("Modules/AI/Components/HGNavMeshAgent.bindings.h")]
	public sealed class HGNavMeshAgent : UnityEngine.Behaviour // TypeDefIndex: 62947
	{
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
	public sealed class NavMeshAgent : UnityEngine.Behaviour // TypeDefIndex: 62948
	{
	}

	[MovedFrom("UnityEngine")]
	public enum NavMeshObstacleShape // TypeDefIndex: 62949
	{
		Capsule = 0,
		Box = 1,
		Polygon = 2
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/Components/NavMeshObstacle.bindings.h")]
	public sealed class NavMeshObstacle : UnityEngine.Behaviour // TypeDefIndex: 62950
	{
		// Properties
		public float height { get; set; } // 0x000000018B38A2D4-0x000000018B38A308 0x000000018B38A3AC-0x000000018B38A3F0
		public float radius { get; set; } // 0x000000018B38A308-0x000000018B38A33C 0x000000018B38A3F0-0x000000018B38A434
		public bool carving { set; } // 0x00000001833E0200-0x00000001833E0250
		public bool carveOnlyStationary { set; } // 0x00000001833E0110-0x00000001833E0160
		public NavMeshObstacleShape shape { set; } // 0x00000001833E00C0-0x00000001833E0110
		public Vector3 center { get; set; } // 0x000000018B38A2A8-0x000000018B38A2D4 0x0000000185392350-0x0000000185392364
		public Vector3 size { [FreeFunction("NavMeshObstacleScriptBindings::GetSize", HasExplicitThis = true)] get; [FreeFunction("NavMeshObstacleScriptBindings::SetSize", HasExplicitThis = true)] set; } // 0x000000018B38A380-0x000000018B38A3AC 0x0000000185392364-0x0000000185392378
		public int ignoredSurfaceID { set; } // 0x00000001833E0160-0x00000001833E01B0
		public int carveArea { set; } // 0x00000001833E01B0-0x00000001833E0200
	
		// Methods
		private void get_center_Injected(out Vector3 ret); // 0x000000018B38A264-0x000000018B38A2A8
		private void set_center_Injected(ref Vector3 value); // 0x00000001833DF040-0x00000001833DF090
		private void get_size_Injected(out Vector3 ret); // 0x000000018B38A33C-0x000000018B38A380
		private void set_size_Injected(ref Vector3 value); // 0x00000001833DF090-0x00000001833DF0E0
	}

	[MovedFrom("UnityEngine")]
	public struct NavMeshHit // TypeDefIndex: 62951
	{
		// Fields
		private Vector3 m_Position; // 0x00
		private Vector3 m_Normal; // 0x0C
		private float m_Distance; // 0x18
		private int m_Mask; // 0x1C
		private int m_Hit; // 0x20
	
		// Properties
		public Vector3 position { get; set; } // 0x0000000184DBA810-0x0000000184DBA830 0x0000000184DABF80-0x0000000184DABF90
		public Vector3 normal { get; } // 0x0000000184DBA7F0-0x0000000184DBA810 
		public bool hit { get; } // 0x000000018B38A18C-0x000000018B38A194 
	}

	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	public sealed class NavMeshData : UnityEngine.Object // TypeDefIndex: 62952
	{
		// Properties
		public Bounds sourceBounds { get; } // 0x000000018349CBE0-0x000000018349CC10 
		public Vector3 position { get; set; } // 0x0000000183FD1B50-0x0000000183FD1B80 0x000000018B38A164-0x000000018B38A178
		public Quaternion rotation { get; set; } // 0x0000000183FD1B80-0x0000000183FD1BB0 0x000000018B38A178-0x000000018B38A18C
	
		// Constructors
		public NavMeshData(int agentTypeID); // 0x0000000184CAD9C0-0x0000000184CADA20
	
		// Methods
		[StaticAccessor("NavMeshDataBindings", StaticAccessorType.DoubleColon)]
		private static void Internal_Create([Writable] NavMeshData mono, int agentTypeID); // 0x0000000184CADA20-0x0000000184CADA70
		public void AppendExtOffMeshLink(Vector3 start, Vector3 end, float width, bool bidirectional, int area, float costModifier); // 0x0000000183FD1870-0x0000000183FD1B50
		[NativeMethod("AppendExtOffMeshLink")]
		internal void Internal_AppendExtOffMeshLink(Vector3 startLeft, Vector3 startRight, Vector3 endRight, Vector3 endLeft, bool bidirectional, int area, float costModifier); // 0x0000000185396C90-0x0000000185396CDC
		private void get_sourceBounds_Injected(out Bounds ret); // 0x000000018349CC10-0x000000018349CC60
		private void get_position_Injected(out Vector3 ret); // 0x0000000183FD1BB0-0x0000000183FD1C00
		private void set_position_Injected(ref Vector3 value); // 0x0000000184D30CE0-0x0000000184D30D30
		private void get_rotation_Injected(out Quaternion ret); // 0x0000000183FD1C00-0x0000000183FD1C50
		private void set_rotation_Injected(ref Quaternion value); // 0x0000000184D30C90-0x0000000184D30CE0
		private void Internal_AppendExtOffMeshLink_Injected(ref Vector3 startLeft, ref Vector3 startRight, ref Vector3 endRight, ref Vector3 endLeft, bool bidirectional, int area, float costModifier); // 0x0000000183FD1ED0-0x0000000183FD1F50
	}

	public struct NavMeshDataInstance // TypeDefIndex: 62953
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _id_k__BackingField; // 0x00
	
		// Properties
		public bool valid { get; } // 0x000000018349D810-0x000000018349D830 
		internal int id { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public int handleId { get; set; } // 0x0000000184DBA750-0x0000000184DBA760 0x0000000184D86140-0x0000000184D86150
		public UnityEngine.Object owner { set; } // 0x000000018B38A0B4-0x000000018B38A164
	
		// Methods
		public void Remove(); // 0x000000018349A640-0x000000018349A650
	}

	public struct NavMeshLinkData // TypeDefIndex: 62954
	{
		// Fields
		private bool m_IsExt; // 0x00
		private Vector3 m_StartLeft; // 0x04
		private Vector3 m_StartRight; // 0x10
		private Vector3 m_EndRight; // 0x1C
		private Vector3 m_EndLeft; // 0x28
		private float m_CostModifier; // 0x34
		private int m_Bidirectional; // 0x38
		private int m_Area; // 0x3C
		private int m_AgentTypeID; // 0x40
	
		// Properties
		public bool isExt { get; set; } // 0x0000000184DBA890-0x0000000184DBA8A0 0x0000000184D87180-0x0000000184D87190
		public Vector3 startLeft { get; set; } // 0x0000000184DBA8A0-0x0000000184DBA8C0 0x0000000184DABF50-0x0000000184DABF60
		public Vector3 startRight { get; set; } // 0x0000000184DBA8C0-0x0000000184DBA8E0 0x0000000184D8C970-0x0000000184D8C980
		public Vector3 endRight { get; set; } // 0x0000000184DBA870-0x0000000184DBA890 0x0000000184D90500-0x0000000184D90510
		public Vector3 endLeft { get; set; } // 0x0000000184DBA850-0x0000000184DBA870 0x0000000184D90C20-0x0000000184D90C30
		public float costModifier { get; set; } // 0x00000001853957B0-0x00000001853957C0 0x0000000184D8E060-0x0000000184D8E070
		public bool bidirectional { get; set; } // 0x000000018A75F924-0x000000018A75F92C 0x00000001843A5630-0x00000001843A5650
		public int area { get; set; } // 0x0000000184DBA840-0x0000000184DBA850 0x0000000184D86670-0x0000000184D86680
		public int agentTypeID { get; set; } // 0x0000000184DBA830-0x0000000184DBA840 0x0000000184D86610-0x0000000184D86620
	}

	public struct NavMeshLinkInstance // TypeDefIndex: 62955
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _id_k__BackingField; // 0x00
	
		// Properties
		public bool valid { get; } // 0x000000018B38A1A0-0x000000018B38A1B4 
		internal int id { [IsReadOnly] [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B77620-0x0000000182B77630 0x0000000184D86140-0x0000000184D86150
		public UnityEngine.Object owner { set; } // 0x000000018B38A1B4-0x000000018B38A264
	
		// Methods
		public void Remove(); // 0x000000018B38A194-0x000000018B38A1A0
	}

	[MovedFrom("UnityEngine")]
	[NativeHeader("Modules/AI/NavMeshManager.h")]
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[StaticAccessor("NavMeshBindings", StaticAccessorType.DoubleColon)]
	public static class NavMesh // TypeDefIndex: 62958
	{
		// Fields
		public static OnNavMeshPreUpdate onPreUpdate; // 0x00
		public static OnUnloadFinishDelegate onUnloadFinish; // 0x08
	
		// Nested types
		public delegate void OnNavMeshPreUpdate(); // TypeDefIndex: 62956; 0x00000001853DEDB8-0x00000001853DEDC8
	
		public delegate void OnUnloadFinishDelegate(ulong surfTileID); // TypeDefIndex: 62957; 0x0000000182B46B90-0x0000000182B46BA0
	
		// Methods
		[RequiredByNativeCode]
		private static void Internal_CallOnNavMeshPreUpdate(); // 0x0000000183F2EF40-0x0000000183F2EF70
		public static bool Raycast(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask); // 0x0000000185392CE8-0x0000000185392D00
		public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd = true /* Metadata: 0x023523F0 */, int agentTypeID = -1 /* Metadata: 0x023523F1 */, float radius = -1f /* Metadata: 0x023523F2 */); // 0x0000000183F7FA20-0x0000000183F7FB00
		private static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius); // 0x00000001853969C4-0x00000001853969FC
		public static bool FindClosestEdge(Vector3 sourcePosition, out NavMeshHit hit, int areaMask); // 0x000000018B38A758-0x000000018B38A76C
		public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask); // 0x00000001853907C0-0x00000001853907D8
		[NativeName("GetAreaFromName")]
		[StaticAccessor("GetNavMeshProjectSettings()")]
		public static int GetAreaFromName(string areaName); // 0x00000001847C8BB0-0x00000001847C8BF0
		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData); // 0x000000018349A470-0x000000018349A500
		public static NavMeshDataInstance AddNavMeshData(NavMeshData navMeshData, Vector3 position, Quaternion rotation); // 0x000000018349CF50-0x000000018349D060
		public static void UpdateSurfaceTransform(NavMeshDataInstance handle, Vector3 position, Quaternion rotation); // 0x000000018B38A9F4-0x000000018B38AAE4
		public static void RemoveNavMeshData(NavMeshDataInstance handle); // 0x000000018349C470-0x000000018349C480
		[NativeName("IsValidSurfaceID")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool IsValidNavMeshDataHandle(int handle); // 0x000000018349D830-0x000000018349D870
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool IsValidLinkHandle(int handle); // 0x000000018B38A8BC-0x000000018B38A8F0
		[NativeName("SetSurfaceUserID")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool InternalSetOwner(int dataID, int ownerID); // 0x000000018B38A7B4-0x000000018B38A7F4
		[NativeName("SetLinkUserID")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool InternalSetLinkOwner(int linkID, int ownerID); // 0x000000018B38A774-0x000000018B38A7B4
		[NativeName("LoadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddNavMeshDataInternal(NavMeshData navMeshData); // 0x000000018349A500-0x000000018349A540
		[NativeName("LoadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddNavMeshDataTransformedInternal(NavMeshData navMeshData, Vector3 position, Quaternion rotation); // 0x0000000185392C60-0x0000000185392C74
		[NativeName("UnloadData")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void RemoveNavMeshDataInternal(int handle); // 0x000000018349C380-0x000000018349C3C0
		public static NavMeshLinkInstance AddLink(NavMeshLinkData link, Vector3 position, Quaternion rotation); // 0x00000001843A5590-0x00000001843A5630
		public static void RemoveLink(NavMeshLinkInstance handle); // 0x000000018349C2C0-0x000000018349C2D0
		[NativeName("AddLink")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int AddLinkInternal(NavMeshLinkData link, Vector3 position, Quaternion rotation); // 0x0000000185397578-0x000000018539758C
		[NativeName("RemoveLink")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void RemoveLinkInternal(int handle); // 0x000000018349C280-0x000000018349C2C0
		public static NavMeshBuildSettings GetSettingsByID(int agentTypeID); // 0x0000000183BAA6A0-0x0000000183BAA6E0
		public static NavMeshBuildSettings GetSettingsByIndex(int index); // 0x0000000184228B50-0x0000000184228B90
		[NativeName("UpdateSurfaceTransform")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void UpdateSurfaceTransformInternal(int surfaceID, Vector3 position, Quaternion rotation); // 0x000000018B38A9E0-0x000000018B38A9F4
		public static bool DetachFromSurface(int chunkSurfaceId, int builderSurfaceId, int indexX, int indexZ); // 0x000000018349D2E0-0x000000018349D2F0
		public static bool SetBuilderSurfaceParams(int surfID, float chunkSize, float tileSize, float centerX, float centerZ, float sizeX, float sizeZ); // 0x0000000183BAA730-0x0000000183BAA740
		[NativeName("DetachFromSurface")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool Internal_DetachFromSurface(int chunkSurfaceId, int builderSurfaceId, int indexX, int indexZ); // 0x000000018349D270-0x000000018349D2E0
		[NativeName("SetBuilderSurfaceParams")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool Internal_SetBuilderSurfaceParams(int surfID, float chunkSize, float tileSize, float centerX, float centerZ, float sizeX, float sizeZ); // 0x0000000183BAA900-0x0000000183BAA970
		public static int LoadDynamicBakeTile(NavMeshData navMeshData); // 0x000000018B38A8F0-0x000000018B38A8FC
		public static void UnloadDynamicBakeTile(int dynamicTileID); // 0x000000018B38A988-0x000000018B38A990
		[NativeName("LoadDynamicBakeTile")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static int Internal_LoadDynamicBakeTile(NavMeshData navMeshData); // 0x000000018B38A854-0x000000018B38A888
		[NativeName("UnloadDynamicBakeTile")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_UnloadDynamicBakeTile(int dynamicTileID); // 0x000000018B38A888-0x000000018B38A8BC
		public static int ModifyVolumeArea(List<Vector3> center, List<Vector3> ext, List<Quaternion> rotation, int area); // 0x000000018B38A960-0x000000018B38A970
		private static int ModifyBoxAreaInternal(List<Vector3> center, List<Vector3> ext, List<Quaternion> rotation, int area); // 0x000000018B38A8FC-0x000000018B38A960
		public static int ModifyVolumeArea(List<Vector3> verts, float hMin, float hMax, int area); // 0x00000001845F73E0-0x00000001845F73F0
		private static int ModifyPolygonAreaInternal(List<Vector3> verts, float hMin, float hMax, int area); // 0x00000001845F73F0-0x00000001845F7460
		public static void LoadExtOffMeshLinks(int surfaceID); // 0x0000000185396CDC-0x0000000185396CF0
		[NativeName("LoadExtOffMeshLinks")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_LoadExtOffMeshLinks(int surfaceID); // 0x0000000184D51230-0x0000000184D51270
		[NativeName("BeginLoadingBatch")]
		[StaticAccessor("GetNavMeshManager()")]
		public static void BeginLoadingBatch(); // 0x0000000184025080-0x00000001840250C0
		[NativeName("EndLoadingBatch")]
		[StaticAccessor("GetNavMeshManager()")]
		public static void EndLoadingBatch(); // 0x0000000184024F90-0x0000000184024FD0
		[NativeName("IsLoadingBatch")]
		[StaticAccessor("GetNavMeshManager()")]
		public static bool IsLoadingBatch(); // 0x0000000184024F50-0x0000000184024F90
		public static AsyncOperation AddNavMeshDataAsync(ref int surfaceID, NavMeshData navMeshData, ulong surfTileID); // 0x000000018349D8D0-0x000000018349D970
		private static AsyncOperation AddNavMeshDataAsyncInternal(ref int surfaceID, NavMeshData navMeshData, ulong surfTileID); // 0x000000018349D970-0x000000018349D9D0
		public static void CancelAsyncAdd(ulong surfTileID); // 0x000000018B38A6FC-0x000000018B38A704
		[NativeName("PurgeAsyncOperations")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_CancelAsyncAdd(ulong surfaceID); // 0x000000018B38A7F4-0x000000018B38A828
		public static void UnloadDataAsync(int surfaceID, ulong surfTileID); // 0x0000000185392C74-0x0000000185392C7C
		[NativeName("UnloadDataAsync")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_UnloadDataAsync(int surfaceID, ulong surfTileID); // 0x00000001845B0C50-0x00000001845B0CA0
		[RequiredByNativeCode]
		private static void Internal_InvokeOnUnloadFinish(ulong surfTileID); // 0x0000000184480240-0x0000000184480440
		public static bool IsSurfaceUnloading(ulong surfTileID); // 0x0000000185392C7C-0x0000000185392C88
		[NativeName("IsSurfaceUnloading")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static bool Internal_IsSurfaceUnloading(ulong surfTileID); // 0x00000001845BBC20-0x00000001845BBC60
		public static void ForceClearUnloadDataRequest(); // 0x000000018B38A76C-0x000000018B38A774
		[NativeName("ForceClearUnloadDataRequest")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_ForceClearUnloadDataRequest(); // 0x000000018B38A828-0x000000018B38A854
		public static void CalculatePathAsync(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd = true /* Metadata: 0x023523F6 */, int agentTypeID = -1 /* Metadata: 0x023523F7 */, float radius = -1f /* Metadata: 0x023523F8 */); // 0x0000000183F7FB00-0x0000000183F7FBE0
		private static void CalculatePathAsyncInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius); // 0x000000018539698C-0x00000001853969C4
		public static void SetFindPathMaxIterPerFrame(int maxIterPerFrame); // 0x0000000185395578-0x0000000185395580
		[NativeName("SetFindPathMaxIterPerFrame")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_SetFindPathMaxIterPerFrame(int maxIterPerFrame); // 0x0000000184D71780-0x0000000184D717C0
		public static void CancelAsyncCalculatePath(NavMeshPath path); // 0x0000000185391E78-0x0000000185391E80
		[NativeName("PurgeAsyncFindPath")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_CancelAsyncCalculatePath(NavMeshPath path); // 0x0000000184627810-0x0000000184627850
		public static void RegisterAutoRepath(NavMeshPath path); // 0x0000000185391E80-0x0000000185391E88
		[NativeName("RegisterAutoRepath")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_RegisterAutoRepath(NavMeshPath path); // 0x0000000184970E80-0x0000000184970EC0
		public static void UnregisterAutoRepath(NavMeshPath path); // 0x0000000185391E70-0x0000000185391E78
		[NativeName("UnregisterAutoRepath")]
		[StaticAccessor("GetNavMeshManager()")]
		internal static void Internal_UnregisterAutoRepath(NavMeshPath path); // 0x0000000184D116D0-0x0000000184D11710
		public static bool RaycastNearestPoint(Vector3 sourcePosition, Vector3 targetPosition, out NavMeshHit hit, int areaMask); // 0x000000018B38A970-0x000000018B38A988
		private static bool Raycast_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask); // 0x00000001841CC6E0-0x00000001841CC750
		private static bool CalculatePathInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius); // 0x0000000183F80440-0x0000000183F804C0
		private static bool FindClosestEdge_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, int areaMask); // 0x000000018B38A704-0x000000018B38A758
		private static bool SamplePosition_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask); // 0x0000000183AD65B0-0x0000000183AD6620
		private static int AddNavMeshDataTransformedInternal_Injected(NavMeshData navMeshData, ref Vector3 position, ref Quaternion rotation); // 0x00000001849BE650-0x00000001849BE6B0
		private static int AddLinkInternal_Injected(ref NavMeshLinkData link, ref Vector3 position, ref Quaternion rotation); // 0x00000001843A5650-0x00000001843A56B0
		private static void GetSettingsByID_Injected(int agentTypeID, out NavMeshBuildSettings ret); // 0x0000000183BAA6E0-0x0000000183BAA730
		private static void GetSettingsByIndex_Injected(int index, out NavMeshBuildSettings ret); // 0x0000000184228B90-0x0000000184228BE0
		private static void UpdateSurfaceTransformInternal_Injected(int surfaceID, ref Vector3 position, ref Quaternion rotation); // 0x000000018B38A990-0x000000018B38A9E0
		private static void CalculatePathAsyncInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path, bool isReserveEnd, int agentTypeID, float radius); // 0x0000000183F804C0-0x0000000183F80540
		private static bool RaycastNearestPoint_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, out NavMeshHit hit, int areaMask); // 0x0000000183D37610-0x0000000183D37680
	}

	public enum NavMeshBuildSourceShape // TypeDefIndex: 62959
	{
		Mesh = 0,
		Terrain = 1,
		Box = 2,
		Sphere = 3,
		Capsule = 4,
		ModifierBox = 5,
		PhysicsTriangleMesh = 6,
		PhysicsConvexMesh = 7,
		PhysicsTerrain = 8,
		ModifierPoly = 20
	}

	public enum NavMeshCollectGeometry // TypeDefIndex: 62960
	{
		RenderMeshes = 0,
		PhysicsColliders = 1
	}

	[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
	[UsedByNativeCode]
	public struct NavMeshBuildSource // TypeDefIndex: 62961
	{
		// Fields
		[NativeName("transform")]
		private Matrix4x4 m_Transform; // 0x00
		[NativeName("size")]
		private Vector3 m_Size; // 0x40
		[NativeName("shape")]
		private NavMeshBuildSourceShape m_Shape; // 0x4C
		[NativeName("areaType")]
		private int m_Area; // 0x50
		[NativeName("instanceID")]
		private int m_InstanceID; // 0x54
		[NativeName("componentID")]
		private int m_ComponentID; // 0x58
		[NativeName("isConvex")]
		internal bool m_IsConvex; // 0x5C
		[NativeName("ecsShape")]
		internal IntPtr m_EcsShape; // 0x60
		[NativeName("convexVerts")]
		public List<Vector3> convexVerts; // 0x68
		[NativeName("convexHmin")]
		public float convexHmin; // 0x70
		[NativeName("convexHmax")]
		public float convexHmax; // 0x74
	
		// Properties
		public Matrix4x4 transform { get; set; } // 0x0000000184DBA7A0-0x0000000184DBA7D0 0x0000000184DBA7D0-0x0000000184DBA7F0
		public Vector3 size { get; set; } // 0x0000000184DBA780-0x0000000184DBA7A0 0x0000000184D89690-0x0000000184D896A0
		public NavMeshBuildSourceShape shape { get; set; } // 0x0000000184DBA770-0x0000000184DBA780 0x0000000184D86630-0x0000000184D86640
		public int area { get; set; } // 0x0000000184DBA760-0x0000000184DBA770 0x0000000184D865A0-0x0000000184D865B0
		public UnityEngine.Object sourceObject { get; } // 0x000000018B38989C-0x000000018B3898A8 
		public Component component { get; } // 0x000000018B389890-0x000000018B38989C 
	
		// Methods
		[StaticAccessor("NavMeshBuildSource", StaticAccessorType.DoubleColon)]
		private static Component InternalGetComponent(int instanceID); // 0x000000018B389828-0x000000018B38985C
		[StaticAccessor("NavMeshBuildSource", StaticAccessorType.DoubleColon)]
		private static UnityEngine.Object InternalGetObject(int instanceID); // 0x000000018B38985C-0x000000018B389890
	}

	[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
	public struct NavMeshBuildMarkup // TypeDefIndex: 62962
	{
		// Fields
		private int m_OverrideArea; // 0x00
		private int m_Area; // 0x04
		private int m_IgnoreFromBuild; // 0x08
		private int m_InstanceID; // 0x0C
	
		// Properties
		public bool overrideArea { set; } // 0x000000018B3897A4-0x000000018B3897AC
		public int area { set; } // 0x0000000184D88B50-0x0000000184D88B60
		public bool ignoreFromBuild { set; } // 0x0000000182F129D0-0x0000000182F129E0
		public Transform root { set; } // 0x000000018B3897AC-0x000000018B389828
	}

	[NativeHeader("Modules/AI/Public/NavMeshBuildSettings.h")]
	public struct NavMeshBuildSettings // TypeDefIndex: 62963
	{
		// Fields
		private int m_AgentTypeID; // 0x00
		private float m_AgentRadius; // 0x04
		private float m_AgentHeight; // 0x08
		private float m_AgentSlope; // 0x0C
		private float m_AgentClimb; // 0x10
		private float m_LedgeDropHeight; // 0x14
		private float m_MaxJumpAcrossDistance; // 0x18
		private float m_MinRegionArea; // 0x1C
		private int m_OverrideVoxelSize; // 0x20
		private float m_VoxelSize; // 0x24
		private int m_OverrideTileSize; // 0x28
		private int m_TileSize; // 0x2C
		private int m_AccuratePlacement; // 0x30
		private uint m_MaxJobWorkers; // 0x34
		private int m_PreserveTilesOutsideBounds; // 0x38
		private int m_PartitioningMethod; // 0x3C
		private int m_FilterLowHangingObstacles; // 0x40
		private int m_FilterLedgeSpans; // 0x44
		private int m_FilterWalkableLowHeightSpans; // 0x48
		private int m_erodeAgainstWallSpans; // 0x4C
		private int m_cliffIndent; // 0x50
		private int m_DynamicNavmeshSurfaceType; // 0x54
		private NavMeshBuildDebugSettings m_Debug; // 0x58
	
		// Properties
		public int agentTypeID { get; set; } // 0x0000000184DBA750-0x0000000184DBA760 0x0000000184D86140-0x0000000184D86150
		public float agentRadius { get; } // 0x0000000184DBA740-0x0000000184DBA750 
		public float agentHeight { get; } // 0x0000000184DBA730-0x0000000184DBA740 
		public float agentClimb { get; } // 0x0000000184DBA720-0x0000000184DBA730 
		public float minRegionArea { set; } // 0x0000000184D86900-0x0000000184D86910
		public bool overrideVoxelSize { set; } // 0x0000000183BAA7E0-0x0000000183BAA800
		public float voxelSize { set; } // 0x0000000184D89860-0x0000000184D89870
		public bool overrideTileSize { set; } // 0x0000000183BAA7C0-0x0000000183BAA7E0
		public int tileSize { set; } // 0x0000000184D86720-0x0000000184D86730
		public int partitioningMethod { set; } // 0x0000000184D86670-0x0000000184D86680
		public bool filterLowHangingObstacles { set; } // 0x0000000183BAA740-0x0000000183BAA760
		public bool filterLedgeSpans { set; } // 0x0000000183BAA760-0x0000000183BAA780
		public bool filterWalkableLowHeightSpans { set; } // 0x0000000183BAA780-0x0000000183BAA7A0
		public bool erodeAgainstWallSpans { set; } // 0x0000000183BAA7A0-0x0000000183BAA7C0
		public int cliffIndent { set; } // 0x0000000184D865A0-0x0000000184D865B0
	}

	[NativeHeader("Modules/AI/Public/NavMeshBuildDebugSettings.h")]
	public struct NavMeshBuildDebugSettings // TypeDefIndex: 62964
	{
		// Fields
		private byte m_Flags; // 0x00
	}
}

namespace UnityEngine.Experimental.AI
{
	public struct PolygonId : IEquatable<PolygonId> // TypeDefIndex: 62965
	{
		// Fields
		internal ulong polyRef; // 0x00
	
		// Methods
		public bool IsNull(); // 0x000000018314CD60-0x000000018314CD70
		public static bool operator ==(PolygonId x, PolygonId y); // 0x0000000182FB1840-0x0000000182FB1850
		public static bool operator !=(PolygonId x, PolygonId y); // 0x000000018B38AB58-0x000000018B38AB64
		public override int GetHashCode(); // 0x0000000184DBA8E0-0x0000000184DBA8F0
		public bool Equals(PolygonId rhs); // 0x000000018B38AB50-0x000000018B38AB58
		public override bool Equals(object obj); // 0x000000018B38AAE4-0x000000018B38AB50
	}

	public struct NavMeshLocation // TypeDefIndex: 62966
	{
		// Fields
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly PolygonId _polygon_k__BackingField; // 0x00
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly Vector3 _position_k__BackingField; // 0x08
	
		// Properties
		public PolygonId polygon { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000182B76770-0x0000000182B76780 
		public Vector3 position { [IsReadOnly] [CompilerGenerated] get; } // 0x0000000184D9C4D0-0x0000000184D9C4F0 
	}

	[Flags]
	public enum PathQueryStatus // TypeDefIndex: 62967
	{
		WrongMagic = 1,
		WrongVersion = 2,
		OutOfMemory = 4,
		InvalidParam = 8,
		BufferTooSmall = 16,
		OutOfNodes = 32,
		PartialResult = 64,
		StatusDetailMask = 16777215,
		InProgress = 536870912,
		Success = 1073741824,
		Failure = 2147483647
	}

	[StaticAccessor("NavMeshWorldBindings", StaticAccessorType.DoubleColon)]
	public struct NavMeshWorld // TypeDefIndex: 62968
	{
		// Fields
		internal IntPtr world; // 0x00
	
		// Methods
		public static NavMeshWorld GetDefaultWorld(); // 0x0000000183BAA610-0x0000000183BAA660
		private static void GetDefaultWorld_Injected(out NavMeshWorld ret); // 0x0000000183BAA660-0x0000000183BAA6A0
	}

	[NativeContainer]
	[NativeHeader("Runtime/Math/Matrix4x4.h")]
	[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
	[NativeHeader("Modules/AI/NavMeshExperimental.bindings.h")]
	[StaticAccessor("NavMeshQueryBindings", StaticAccessorType.DoubleColon)]
	public struct NavMeshQuery : IDisposable // TypeDefIndex: 62969
	{
		// Fields
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_NavMeshQuery; // 0x00
	
		// Constructors
		public NavMeshQuery(NavMeshWorld world, Unity.Collections.Allocator allocator, int pathNodePoolSize = 0 /* Metadata: 0x0235241F */); // 0x0000000183BAA860-0x0000000183BAA8A0
	
		// Methods
		public void Dispose(); // 0x00000001840F38C0-0x00000001840F38F0
		private static IntPtr Create(NavMeshWorld world, int nodePoolSize); // 0x0000000185395580-0x000000018539559C
		private static void Destroy(IntPtr navMeshQuery); // 0x00000001840F3940-0x00000001840F3980
		[ThreadSafe]
		private static NavMeshLocation MapLocation(IntPtr navMeshQuery, Vector3 position, Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x02352420 */); // 0x00000001834ED8A0-0x00000001834ED930
		public NavMeshLocation MapLocation(Vector3 position, Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x02352421 */); // 0x00000001834ED7D0-0x00000001834ED8A0
		[ThreadSafe]
		private static NavMeshLocation MoveLocation(IntPtr navMeshQuery, NavMeshLocation location, Vector3 target, int areaMask); // 0x000000018B38A498-0x000000018B38A4DC
		public NavMeshLocation MoveLocation(NavMeshLocation location, Vector3 target, int areaMask = -1 /* Metadata: 0x02352422 */); // 0x000000018B38A4DC-0x000000018B38A560
		[ThreadSafe]
		private static unsafe PathQueryStatus Raycast(IntPtr navMeshQuery, NavMeshLocation start, Vector3 targetPosition, int areaMask, void* costs, out NavMeshHit hit, void* path, out int pathCount, int maxPath); // 0x000000018B38A5C4-0x000000018B38A61C
		public PathQueryStatus Raycast(out NavMeshHit hit, NavMeshLocation start, Vector3 targetPosition, int areaMask = -1 /* Metadata: 0x02352423 */, NativeArray<float> costs = default); // 0x000000018B38A61C-0x000000018B38A6FC
		private static IntPtr Create_Injected(ref NavMeshWorld world, int nodePoolSize); // 0x000000018426FE80-0x000000018426FED0
		private static void MapLocation_Injected(IntPtr navMeshQuery, ref Vector3 position, ref Vector3 extents, int agentTypeID, int areaMask = -1 /* Metadata: 0x02352424 */, out NavMeshLocation ret); // 0x00000001834ED930-0x00000001834ED9A0
		private static void MoveLocation_Injected(IntPtr navMeshQuery, ref NavMeshLocation location, ref Vector3 target, int areaMask, out NavMeshLocation ret); // 0x000000018B38A434-0x000000018B38A498
		private static unsafe PathQueryStatus Raycast_Injected(IntPtr navMeshQuery, ref NavMeshLocation start, ref Vector3 targetPosition, int areaMask, void* costs, out NavMeshHit hit, void* path, out int pathCount, int maxPath); // 0x000000018B38A560-0x000000018B38A5C4
	}
}
