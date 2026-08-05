/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using pxr;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using USD.NET;
using USD.NET.Unity;

// Image 47: Unity.Formats.USD.Runtime.dll - Assembly: Unity.Formats.USD.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 60087-60198
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.Formats.USD.Tests.Runtime")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 60089
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 60090
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 60091
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 60092
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 60093
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 60088
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}
}

namespace Unity.Formats.USD
{
	public class UsdAssemblyRoot : MonoBehaviour // TypeDefIndex: 60094
	{
		// Constructors
		public UsdAssemblyRoot(); // 0x0000000185393520-0x0000000185393538
	}

	[ExecuteInEditMode]
	public class UsdAsset : MonoBehaviour // TypeDefIndex: 60095
	{
		// Fields
		[Header("Source Asset")]
		[SerializeField]
		private string m_usdFile; // 0x18
		[HideInInspector]
		[Tooltip("The Unity project path into which imported files (such as textures) will be placed.")]
		public string m_projectAssetPath; // 0x20
		[Tooltip("The USD prim path in the USD scene at which to start the import process.")]
		public string m_usdRootPath; // 0x28
		[Tooltip("An offset applied to all data in the USD file")]
		public float m_usdTimeOffset; // 0x30
		[Tooltip("For assets with payloads authored, indicates if payloads should be loaded or unloaded by default.")]
		public PayloadPolicy m_payloadPolicy; // 0x34
		[HideInInspector]
		public bool m_importHierarchy; // 0x38
		[Header("Conversions")]
		[Tooltip("A scale to be applied to the root asset, useful for converting asset units to meters.")]
		public float m_scale; // 0x3C
		[Tooltip("Conversion method for right-handed (USD) to left-handed conversion (Unity) and vice versa.")]
		public BasisTransformation m_changeHandedness; // 0x40
		[Tooltip("Behavior to use when no value was authored at the requested time.")]
		public Scene.InterpolationMode m_interpolation; // 0x44
		[Header("Material Options")]
		[Tooltip("If the original shader name is stored in USD, attempt to find that shader in this project.")]
		public bool m_useOriginalShaderIfAvailable; // 0x48
		[Tooltip("The default material to use when importing materials as display color.")]
		public Material m_displayColorMaterial; // 0x50
		[Tooltip("The default material to use when importing specular workflow USD Preview Surface materials.")]
		public Material m_specularWorkflowMaterial; // 0x58
		[Tooltip("The default material to use when importing metallic workflow USD Preview Surface materials.")]
		public Material m_metallicWorkflowMaterial; // 0x60
		[HideInInspector]
		[Tooltip("When enabled, set the GPU Instancing flag on all materials.")]
		public bool m_enableGpuInstancing; // 0x68
		[Header("Mesh Options")]
		public ImportMode m_points; // 0x6C
		public ImportMode m_topology; // 0x70
		public ImportMode m_boundingBox; // 0x74
		[Tooltip("Combined import policy for primvars:displayColor and primvars:displayOpacity")]
		public ImportMode m_color; // 0x78
		[Tooltip("Import policy for normals, note that the \'normals\' attribute is built-in, not a primvar")]
		public ImportMode m_normals; // 0x7C
		[Tooltip("Import policy for primvars:tangent")]
		public ImportMode m_tangents; // 0x80
		[Header("Mesh Lightmap UV Unwrapping")]
		public bool m_generateLightmapUVs; // 0x84
		[Range(0f, 1f)]
		[Tooltip("Maximum allowed angle distortion")]
		public float m_unwrapAngleError; // 0x88
		[Range(0f, 1f)]
		[Tooltip("Maximum allowed area distortion")]
		public float m_unwrapAreaError; // 0x8C
		[Range(1f, 359f)]
		[Tooltip("This angle (in degrees) or greater between triangles will cause seam to be created")]
		public float m_unwrapHardAngle; // 0x90
		[Range(0f, 32f)]
		[Tooltip("UV-island padding in pixels")]
		public int m_unwrapPackMargin; // 0x94
		[Header("Import Settings")]
		public MaterialImportMode m_materialImportMode; // 0x98
		public bool m_importCameras; // 0x9C
		public bool m_importMeshes; // 0x9D
		public bool m_importSkinning; // 0x9E
		public bool m_importTransforms; // 0x9F
		public bool m_importSceneInstances; // 0xA0
		public bool m_importPointInstances; // 0xA1
		public bool m_importMonoBehaviors; // 0xA2
		[Header("Debug Options")]
		public bool m_debugShowSkeletonBindPose; // 0xA3
		public bool m_debugShowSkeletonRestPose; // 0xA4
		public bool m_debugPrintVariabilityCache; // 0xA5
		[Tooltip("Memorizes which attributes change over time, to speed up playback (trades time for memory)")]
		public bool m_usdVariabilityCache; // 0xA6
		[HideInInspector]
		public BasisTransformation LastHandedness; // 0xA8
		[HideInInspector]
		public float LastScale; // 0xAC
		private float m_lastTime; // 0xB0
		private Scene m_lastScene; // 0xB8
		private PrimMap m_lastPrimMap; // 0xC0
		private AccessMask m_lastAccessMask; // 0xC8
	
		// Properties
		public double Length { get; } // 0x000000018B17882C-0x000000018B178834 
		public string usdFullPath { get; set; } // 0x000000018B178834-0x000000018B1788AC 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public UsdAsset(); // 0x000000018B178770-0x000000018B17882C
	
		// Methods
		private void OnDestroy(); // 0x000000018B1766F0-0x000000018B176734
		private string GetPrefabAssetPath(GameObject root); // 0x00000001811EC580-0x00000001811EC590
		public void OptionsToState(SceneImportOptions options); // 0x000000018B176798-0x000000018B1769D4
		public void StateToOptions(ref SceneImportOptions options); // 0x000000018B178338-0x000000018B178730
		private bool SceneFileChanged(); // 0x000000018B176DDC-0x000000018B176EDC
		public Scene GetScene(); // 0x000000018B17620C-0x000000018B176520
		private void OnReload(); // 0x000000018B176734-0x000000018B176798
		private void DestroyComponent(UnityEngine.Component comp); // 0x000000018B175BBC-0x000000018B175C1C
		private void ClearLastData(); // 0x000000018B1759EC-0x000000018B175A34
		public void RemoveAllUsdComponents(); // 0x000000018B176BE0-0x000000018B176DDC
		public void DestroyAllImportedObjects(); // 0x000000018B175A98-0x000000018B175BBC
		public void Reload(bool forceRebuild); // 0x000000018B176A58-0x000000018B176BE0
		private UsdPrim GetFirstPrim(Scene scene); // 0x000000018B176170-0x000000018B17620C
		public void ExportOverrides(Scene sceneInWhichToStoreTransforms); // 0x000000018B175C1C-0x000000018B176170
		private double ComputeLength(); // 0x000000018B175A34-0x000000018B175A98
		public void SetTime(double time, UsdAsset foreignRoot, bool saveMeshUpdates); // 0x000000018B1774C0-0x000000018B177C80
		private void Update(); // 0x000000018B178730-0x000000018B178770
		public static void PrepOptionsForTimeChange(ref SceneImportOptions options); // 0x000000018B1769D4-0x000000018B176A58
		public void ImportUsdAsCoroutine(GameObject goRoot, string usdFilePath, double time, SceneImportOptions importOptions, float targetFrameMilliseconds); // 0x000000018B176520-0x000000018B1766F0
		public void SetPayloadState(GameObject go, bool isLoaded); // 0x000000018B176EDC-0x000000018B1774C0
		private void ApplyVariantSelectionState(Scene scene, UsdVariantSet variants); // 0x000000018B1756A8-0x000000018B1759EC
		public void SetVariantSelection(GameObject go, string usdPrimPath, Dictionary<string, string> selections); // 0x000000018B177C80-0x000000018B178338
	}

	[RequireComponent(typeof(UsdAsset))]
	public class UsdLayerStack : MonoBehaviour // TypeDefIndex: 60096
	{
		// Fields
		public string m_targetLayer; // 0x18
		public string[] m_layerStack; // 0x20
		public string[] m_mutedLayers; // 0x28
	
		// Constructors
		public UsdLayerStack(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void SetupNewSubLayer(Scene parentScene, Scene subLayerScene); // 0x000000018B178D90-0x000000018B178E20
		public void SaveLayerStack(Scene scene, string[] layerStack); // 0x000000018B1788AC-0x000000018B178A58
		public void SaveToLayer(); // 0x000000018B178A58-0x000000018B178D90
	}

	public class UsdModelRoot : MonoBehaviour // TypeDefIndex: 60097
	{
		// Fields
		public string m_modelName; // 0x18
		public string m_modelVersion; // 0x20
		public string m_modelAssetPath; // 0x28
	
		// Constructors
		public UsdModelRoot(); // 0x0000000185393520-0x0000000185393538
	}

	[ExecuteInEditMode]
	public class UsdPayload : MonoBehaviour // TypeDefIndex: 60098
	{
		// Fields
		[SerializeField]
		private bool m_isLoaded; // 0x18
		[HideInInspector]
		[SerializeField]
		private bool m_wasLoaded; // 0x19
	
		// Properties
		public bool IsLoaded { get; } // 0x0000000184D86340-0x0000000184D86350 
	
		// Constructors
		public UsdPayload(); // 0x000000018B178EAC-0x000000018B178EC8
	
		// Methods
		public void Load(); // 0x0000000184D8EB60-0x0000000184D8EB70
		public void Unload(); // 0x0000000184D91AA0-0x0000000184D91AB0
		public void SetInitialState(bool loaded); // 0x0000000184DAB6F0-0x0000000184DAB700
		public void Update(); // 0x000000018B178E20-0x000000018B178EAC
	}

	public class UsdPrimSource : MonoBehaviour // TypeDefIndex: 60099
	{
		// Fields
		public string m_usdPrimPath; // 0x18
	
		// Constructors
		public UsdPrimSource(); // 0x0000000185393520-0x0000000185393538
	}

	public class UsdVariantSet : MonoBehaviour // TypeDefIndex: 60101
	{
		// Fields
		public string[] m_variantSetNames; // 0x18
		public string[] m_selected; // 0x20
		public string[] m_variants; // 0x28
		public int[] m_variantCounts; // 0x30
		public string m_primPath; // 0x38
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 60100
		{
			// Fields
			public UsdVariantSets variantSets; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _LoadFromUsd_b__0(string setName); // 0x000000018B1755C8-0x000000018B1755E8
			internal IEnumerable<string> _LoadFromUsd_b__1(string setName); // 0x000000018B1755E8-0x000000018B175618
			internal int _LoadFromUsd_b__2(string setName); // 0x000000018B175618-0x000000018B175658
		}
	
		// Constructors
		public UsdVariantSet(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		public void LoadFromUsd(UsdPrim prim); // 0x000000018B179030-0x000000018B1792B8
		public void ApplyVariantSelections(); // 0x000000018B178EC8-0x000000018B178F60
		public Dictionary<string, string> GetVariantSelections(); // 0x000000018B178F60-0x000000018B179030
	}

	[ExecuteInEditMode]
	public class SkinnedMeshUnityDiff : MonoBehaviour // TypeDefIndex: 60102
	{
		// Fields
		[Tooltip("The USD skinned mesh to compare")]
		public SkinnedMeshRenderer m_usdMesh; // 0x18
		[Tooltip("The Unity skinned mesh to compare")]
		public SkinnedMeshRenderer m_unityMesh; // 0x20
	
		// Constructors
		public SkinnedMeshUnityDiff(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnEnable(); // 0x000000018B17124C-0x000000018B172220
		private bool Approximately(Matrix4x4 rhs, Matrix4x4 lhs); // 0x000000018B171170-0x000000018B171220
		private bool WeightsMatch(BoneWeight w1, BoneWeight w2); // 0x000000018B172220-0x000000018B172320
		private bool IndicesMatch(BoneWeight w1, BoneWeight w2); // 0x000000018B171220-0x000000018B17124C
		private void Update(); // 0x00000001841E1670-0x00000001841E1680
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class SkinnedMeshUsdDiff : MonoBehaviour // TypeDefIndex: 60103
	{
		// Fields
		[Tooltip("A path to a USD file for comparing weights")]
		public string m_usdFile; // 0x18
		[Tooltip("A prim path to the skinned mesh in the USD file")]
		public string m_usdMeshPath; // 0x20
		[Tooltip("How to convert transforms for comparison")]
		public BasisTransformation m_basisTransform; // 0x28
	
		// Constructors
		public SkinnedMeshUsdDiff(); // 0x0000000185393520-0x0000000185393538
	
		// Methods
		private void OnEnable(); // 0x000000018B1724C4-0x000000018B173374
		private string GetUsdBoneData<T>(int bone, int weightIndex, Primvar<T[]> primvar);
		private Scene GetScene(); // 0x000000018B172320-0x000000018B1724C4
		private SkelBindingSample ReadUsdWeights(Scene scene); // 0x000000018B173790-0x000000018B1738AC
		private SkeletonSample ReadUsdSkeleton(Scene scene, out string skelRootPath); // 0x000000018B173374-0x000000018B173790
		private void Update(); // 0x00000001841E1670-0x00000001841E1680
	}

	public static class CameraExporter // TypeDefIndex: 60104
	{
		// Methods
		public static void ExportCamera(ObjectContext objContext, ExportContext exportContext); // 0x000000018B165B8C-0x000000018B165E58
	}

	public static class CameraImporter // TypeDefIndex: 60105
	{
		// Methods
		public static void BuildCamera(CameraSample usdCamera, GameObject go, SceneImportOptions options); // 0x000000018B165E58-0x000000018B165F14
	}

	public static class CubeImporter // TypeDefIndex: 60106
	{
		// Methods
		public static void BuildCube(CubeSample usdCube, GameObject go, SceneImportOptions options, bool skinnedMesh = false /* Metadata: 0x0234D288 */); // 0x000000018B165F14-0x000000018B1679E8
		private static bool ShouldImport(ImportMode mode); // 0x000000018AAA50A8-0x000000018AAA50B8
		private static bool ShouldCompute(ImportMode mode); // 0x0000000186D41C40-0x0000000186D41C50
	}

	public static class InstanceImporter // TypeDefIndex: 60107
	{
		// Methods
		public static void BuildSceneInstances(PrimMap primMap, SceneImportOptions options); // 0x000000018B16A330-0x000000018B16A928
		public static void BuildPointInstances(Scene scene, PrimMap primMap, string pointInstancerPath, PointInstancerSample sample, GameObject root, SceneImportOptions options); // 0x000000018B169C9C-0x000000018B16A330
		private static void EnableGpuInstancing(GameObject go); // 0x000000018B16A928-0x000000018B16AB80
	}

	public static class MeshExporter // TypeDefIndex: 60108
	{
		// Fields
		private static TfToken m_materialBindToken; // 0x00
		private static TfToken m_subMeshesToken; // 0x08
	
		// Constructors
		static MeshExporter(); // 0x000000018B16EBD0-0x000000018B16ECC0
	
		// Methods
		public static void ExportSkinnedMesh(ObjectContext objContext, ExportContext exportContext); // 0x000000018B16E8D0-0x000000018B16EBD0
		private static void ExportSkelWeights(Scene scene, string path, Mesh unityMesh, Transform rootBone, Transform[] bones, string skeletonPath); // 0x000000018B16E378-0x000000018B16E8D0
		public static void ExportMesh(ObjectContext objContext, ExportContext exportContext); // 0x000000018B16E248-0x000000018B16E378
		private static void ExportMesh(ObjectContext objContext, ExportContext exportContext, Mesh mesh, Material sharedMaterial, Material[] sharedMaterials, bool exportMeshPose = true /* Metadata: 0x0234D289 */); // 0x000000018B16CDCC-0x000000018B16E248
	}

	public delegate void MeshImportFunction<T>(string path, T sample, MeshImporter.GeometrySubsets subsets, GameObject go, SceneImportOptions option, bool isDynamic, UsdSkelSkinningQuery query = null); // TypeDefIndex: 60109; 0x00000000-0x00000000

	public class MeshImportStrategy : IImporter // TypeDefIndex: 60111
	{
		// Fields
		private MeshImportFunction<SanitizedMeshSample> m_meshImporter; // 0x10
		private MeshImportFunction<SanitizedMeshSample> m_skinnedMeshImporter; // 0x18
		private ReadAllJob<SanitizedMeshSample> m_readMeshesJob; // 0x20
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Import_d__5 : IEnumerator<object> // TypeDefIndex: 60110
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public Scene scene; // 0x20
			public MeshImportStrategy __4__this; // 0x28
			public PrimMap primMap; // 0x30
			public SceneImportOptions importOptions; // 0x38
			private MemberInfo _faceVertexCounts_5__2; // 0x40
			private MemberInfo _faceVertexIndices_5__3; // 0x48
			private MemberInfo _orientation_5__4; // 0x50
			private MemberInfo _points_5__5; // 0x58
			private MemberInfo _normals_5__6; // 0x60
			private MemberInfo _colors_5__7; // 0x68
			private MemberInfo _purpose_5__8; // 0x70
			private MemberInfo _visibility_5__9; // 0x78
			private bool _isDynamic_5__10; // 0x80
			private IEnumerator<SampleEnumerator<SanitizedMeshSample>> __7__wrap10; // 0x88
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _Import_d__5(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018B1754CC-0x000000018B175544
			private bool MoveNext(); // 0x000000018B173ED4-0x000000018B175480
			private void __m__Finally1(); // 0x000000018B175544-0x000000018B175594
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B175480-0x000000018B1754CC
		}
	
		// Constructors
		public MeshImportStrategy(MeshImportFunction<SanitizedMeshSample> meshImporter, MeshImportFunction<SanitizedMeshSample> skinnedMeshImporter); // 0x00000001832AF420-0x00000001832AF450
	
		// Methods
		public void BeginReading(Scene scene, PrimMap primMap, SceneImportOptions importOptions); // 0x000000018B16ECC0-0x000000018B16ED8C
		[IteratorStateMachine(typeof(_Import_d__5))]
		public IEnumerator Import(Scene scene, PrimMap primMap, SceneImportOptions importOptions); // 0x000000018B16ED8C-0x000000018B16EE34
	}

	public static class MeshImporter // TypeDefIndex: 60115
	{
		// Nested types
		public class GeometrySubsets // TypeDefIndex: 60112
		{
			// Fields
			[CompilerGenerated]
			private Dictionary<string, int[]> _Subsets_k__BackingField; // 0x10
	
			// Properties
			public Dictionary<string, int[]> Subsets { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
			// Constructors
			public GeometrySubsets(); // 0x000000018B1679E8-0x000000018B167A60
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 60113
		{
			// Fields
			public Mesh unityMesh; // 0x10
			public Renderer renderer; // 0x18
			public string path; // 0x20
			public SanitizedMeshSample usdMesh; // 0x28
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _BuildMesh__b__0(Scene scene, Material boundMat, List<string> primvars); // 0x000000018B175594-0x000000018B1755C8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_1 // TypeDefIndex: 60114
		{
			// Fields
			public int idx; // 0x10
			public __c__DisplayClass5_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass5_1(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _BuildMesh__b__1(Scene scene, Material boundMat, List<string> primvars); // 0x000000018B175658-0x000000018B1756A8
		}
	
		// Methods
		public static GeometrySubsets ReadGeomSubsets(Scene scene, string path); // 0x000000018B170D18-0x000000018B1710C0
		public static void BuildSkinnedMesh(string path, SanitizedMeshSample usdMesh, GeometrySubsets geomSubsets, GameObject go, SceneImportOptions options, bool isDynamic, UsdSkelSkinningQuery skinningQuery = null); // 0x000000018B1700F0-0x000000018B1702B0
		public static void ImportSkinning(string path, SanitizedMeshSample usdMesh, Mesh unityMesh, UsdSkelSkinningQuery skinningQuery); // 0x000000018B1702B0-0x000000018B1708C8
		public static void BuildMesh(string path, SanitizedMeshSample usdMesh, GeometrySubsets geomSubsets, GameObject go, SceneImportOptions options, bool isDynamic, UsdSkelSkinningQuery skinQuery = null); // 0x000000018B16FF38-0x000000018B1700F0
		private static void BuildMesh_(string path, SanitizedMeshSample usdMesh, Mesh unityMesh, GeometrySubsets geomSubsets, GameObject go, Renderer renderer, SceneImportOptions options); // 0x000000018B16EF28-0x000000018B16FF38
		private static void LoadPrimvars(Mesh unityMesh, string usdMeshPath, List<string> primvars, MeshSample sample); // 0x000000018B170A80-0x000000018B170D18
		private static void BindMat(Mesh unityMesh, Material mat, Renderer renderer, string usdMeshPath, List<string> primvars, MeshSample sample); // 0x000000018B16EED8-0x000000018B16EF28
		private static void BindMat(Mesh unityMesh, Material mat, Renderer renderer, int index, string usdMeshPath, List<string> primvars, MeshSample sample); // 0x000000018B16EE34-0x000000018B16EED8
		private static T[] TryGetPrimvarValue<T>(Primvar<object> primvar);
		private static void ImportUv(Mesh unityMesh, int uvSetIndex, Primvar<object> uv); // 0x000000018B1708C8-0x000000018B170A80
		public static bool ShouldImport(ImportMode mode); // 0x000000018AAA50A8-0x000000018AAA50B8
		public static bool ShouldCompute(ImportMode mode); // 0x0000000186D41C40-0x0000000186D41C50
		private static string UniqueMeshName(string meshName); // 0x000000018B1710C0-0x000000018B171170
	}

	public enum ImportMode // TypeDefIndex: 60116
	{
		Import = 0,
		ImportOrCompute = 1,
		Compute = 2,
		Ignore = 3
	}

	[Serializable]
	public class MeshImportOptions // TypeDefIndex: 60117
	{
		// Fields
		public bool debugShowSkeletonRestPose; // 0x10
		public bool debugShowSkeletonBindPose; // 0x11
		public ImportMode points; // 0x14
		public ImportMode topology; // 0x18
		public bool triangulateMesh; // 0x1C
		public bool generateLightmapUVs; // 0x1D
		public float unwrapAngleError; // 0x20
		public float unwrapAreaError; // 0x24
		public float unwrapHardAngle; // 0x28
		public int unwrapPackMargin; // 0x2C
		public ImportMode color; // 0x30
		public ImportMode normals; // 0x34
		public ImportMode tangents; // 0x38
		public ImportMode boundingBox; // 0x3C
	
		// Constructors
		public MeshImportOptions(); // 0x0000000184DAB6B0-0x0000000184DAB6F0
	}

	public static class SphereImporter // TypeDefIndex: 60118
	{
		// Methods
		public static void BuildSphere(SphereSample usdSphere, GameObject go, SceneImportOptions options, bool skinnedMesh = false /* Metadata: 0x0234D28E */); // 0x000000018B1738AC-0x000000018B173ED4
		private static bool ShouldImport(ImportMode mode); // 0x000000018AAA50A8-0x000000018AAA50B8
		private static bool ShouldCompute(ImportMode mode); // 0x0000000186D41C40-0x0000000186D41C50
	}

	public static class XformExporter // TypeDefIndex: 60119
	{
		// Methods
		public static void ExportXform(ObjectContext objContext, ExportContext exportContext); // 0x000000018B1792B8-0x000000018B179544
		public static void WriteSparseOverrides(Scene scene, PrimMap primMap, BasisTransformation changeHandedness, float tolerance = 0.0001f /* Metadata: 0x0234D28F */); // 0x000000018B17981C-0x000000018B179B44
		public static Matrix4x4 GetLocalTransformMatrix(Transform tr, bool correctZUp, bool isRootPrim, BasisTransformation conversionType); // 0x000000018B179544-0x000000018B17981C
	}

	public static class XformImporter // TypeDefIndex: 60120
	{
		// Methods
		public static void BuildXform(SdfPath path, XformableSample usdXf, GameObject go, SceneImportOptions options, Scene scene); // 0x000000018B17A084-0x000000018B17A204
		public static void BuildXform(Matrix4x4 xf, GameObject go, SceneImportOptions options); // 0x000000018B179EE4-0x000000018B17A084
		public static void ImportXform(ref Matrix4x4 mat, SceneImportOptions options); // 0x000000018B17A204-0x000000018B17A2EC
		public static void BuildSceneRoot(Scene scene, Transform root, SceneImportOptions options); // 0x000000018B179B44-0x000000018B179EE4
		public static void UndoRootTransform(Scene scene, UsdAsset stageRoot, ref Vector3 localScale, ref Quaternion localRotation); // 0x000000018B17A2EC-0x000000018B17A4C8
	}

	public static class ImporterBase // TypeDefIndex: 60121
	{
		// Methods
		public static string MakeRelativePath(string anchorPath, string pathToMakeRelative); // 0x000000018B169800-0x000000018B169A84
		public static bool ApproximatelyEqual(Matrix4x4 lhs, Matrix4x4 rhs); // 0x000000018B16974C-0x000000018B169800
		public static void MoveComponentFirst(UnityEngine.Component comp); // 0x000000018B169A84-0x000000018B169AD8
		public static void MoveComponentLast(UnityEngine.Component comp); // 0x000000018B169AD8-0x000000018B169B2C
		public static T GetOrAddComponent<T>(GameObject go, bool insertFirst = false /* Metadata: 0x0234D293 */)
			where T : UnityEngine.Component;
		public static string SafeGetDirectoryName(string fullPath); // 0x000000018B169B2C-0x000000018B169C9C
	}

	public class HdrpShaderExporter : ShaderExporterBase // TypeDefIndex: 60122
	{
		// Constructors
		public HdrpShaderExporter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void ExportLit(Scene scene, string usdShaderPath, Material material, PreviewSurfaceSample surface, string destTexturePath); // 0x000000018B167A60-0x000000018B168A18
	}

	public class HdrpShaderImporter : ShaderImporterBase // TypeDefIndex: 60123
	{
		// Fields
		private static Material ChannelCombinerMat; // 0x00
	
		// Constructors
		public HdrpShaderImporter(Material material); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void ImportFromUsd(); // 0x000000018B169124-0x000000018B16974C
		private static Texture2D BuildMaskMap(Texture2D red, Texture2D green, Texture2D blue, Texture2D alpha); // 0x000000018B168A18-0x000000018B169124
	}

	public static class MaterialExporter // TypeDefIndex: 60125
	{
		// Fields
		public static readonly string kStandardFallbackHandler; // 0x00
		public static readonly string kHdrpFallbackHandler; // 0x08
		public static readonly string kLwrpFallbackHandler; // 0x10
		public static Dictionary<string, ExportHandler> ExportRegistry; // 0x18
	
		// Nested types
		public delegate void ExportHandler(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // TypeDefIndex: 60124; 0x00000001814DD080-0x00000001814DD0A0
	
		// Constructors
		static MaterialExporter(); // 0x000000018B16B0A0-0x000000018B16B748
	
		// Methods
		public static void ExportMaterial(Scene scene, Material mat, string usdMaterialPath); // 0x000000018B16AB80-0x000000018B16B0A0
	}

	public static class MaterialImporter // TypeDefIndex: 60127
	{
		// Fields
		private static readonly TfToken materialBindToken; // 0x00
		private static Material AlbedoGlossCombiner; // 0x08
		public static TextureResolver OnResolveTexture; // 0x10
	
		// Nested types
		public delegate Texture2D TextureResolver(SdfAssetPath textureAssetPath, bool isNormalMap, SceneImportOptions importOptions); // TypeDefIndex: 60126; 0x00000001814F3120-0x00000001814F3140
	
		// Constructors
		static MaterialImporter(); // 0x000000018B16CD3C-0x000000018B16CDCC
	
		// Methods
		public static void ProcessMaterialBindings(Scene scene, SceneImportOptions importOptions); // 0x000000018B16C828-0x000000018B16CD3C
		public static Material BuildMaterial(Scene scene, string materialPath, MaterialSample sample, SceneImportOptions options); // 0x000000018B16B748-0x000000018B16C30C
		public static Texture2D ImportConnectedTexture<T>(Scene scene, Connectable<T> connection, bool isNormalMap, SceneImportOptions options, out string uvPrimvar);
		private static Texture2D DefaultTextureResolver(SdfAssetPath textureAssetPath, bool isNormalMap, SceneImportOptions options); // 0x00000001811EC580-0x00000001811EC590
		public static Texture2D CombineRoughness(Texture2D rgbTex, Texture2D roughnessTex, string fileNameSuffix); // 0x000000018B16C30C-0x000000018B16C60C
		public static UnityPreviewSurfaceSample GetSurfaceShaderPrim(Scene scene, string primPath); // 0x000000018B16C60C-0x000000018B16C828
	}

	public class MaterialMap : IEnumerable<KeyValuePair<string, Material>> // TypeDefIndex: 60129
	{
		// Fields
		private Dictionary<string, Material> m_map; // 0x10
		private Dictionary<UnityEngine.Color, Material> m_colorMap; // 0x18
		private Dictionary<string, MaterialBinder> m_requestedBindings; // 0x20
		private Dictionary<string, List<string>> m_primvars; // 0x28
		public bool useOriginalShaderIfAvailable; // 0x30
		private Material m_displayColorMaterial; // 0x38
		private Material m_specularWorkflowMaterial; // 0x40
		private Material m_metallicWorkflowMaterial; // 0x48
	
		// Properties
		public Material DisplayColorMaterial { get; set; } // 0x000000018B17F5F0-0x000000018B17F654 0x00000001846A91B0-0x00000001846A91C0
		public Material SpecularWorkflowMaterial { get; set; } // 0x000000018B17F724-0x000000018B17F788 0x00000001842B4AE0-0x00000001842B4AF0
		public Material MetallicWorkflowMaterial { get; set; } // 0x000000018B17F6C0-0x000000018B17F724 0x00000001835A41A0-0x00000001835A41B0
		public Material this[string path] { get => default; set {} } // 0x000000018B17F654-0x000000018B17F6C0 0x000000018B17F788-0x000000018B17F7EC
	
		// Nested types
		public delegate void MaterialBinder(Scene scene, Material mat, List<string> uvPrimvars); // TypeDefIndex: 60128; 0x0000000181546280-0x00000001815462A0
	
		// Constructors
		public MaterialMap(); // 0x000000018B17F498-0x000000018B17F5F0
	
		// Methods
		private void InstantiateMaterials(); // 0x000000018B17F060-0x000000018B17F230
		public Dictionary<string, MaterialBinder> ClearRequestedBindings(); // 0x000000018B17EF28-0x000000018B17EFB0
		public void RequestBinding(string usdPath, MaterialBinder binder); // 0x000000018B17F348-0x000000018B17F3AC
		public List<string> GetPrimvars(string materialPath); // 0x000000018B17EFF8-0x000000018B17F060
		public void SetPrimvars(string materialPath, List<string> primvars); // 0x000000018B17F3AC-0x000000018B17F410
		public Material InstantiateSolidColor(UnityEngine.Color color); // 0x000000018B17F230-0x000000018B17F348
		public static void AssignColor(Material material, UnityEngine.Color color); // 0x000000018B17EE74-0x000000018B17EF28
		public IEnumerator GetEnumerator(); // 0x000000018B17EFB0-0x000000018B17EFF8
		IEnumerator<KeyValuePair<string, Material>> IEnumerable<KeyValuePair<string, Material>>.GetEnumerator(); // 0x000000018B17F410-0x000000018B17F498
	}

	public class ShaderExporterBase // TypeDefIndex: 60131
	{
		// Fields
		private static Material _metalGlossChannelSwapMaterial; // 0x00
		private static Material _normalChannelMaterial; // 0x08
	
		// Nested types
		public enum ConversionType // TypeDefIndex: 60130
		{
			None = 0,
			SwapRASmoothnessToBGRoughness = 1,
			InvertAlpha = 2,
			UnpackNormal = 3,
			MaskMapToORM = 4,
			RemoveAlpha = 5
		}
	
		// Constructors
		public ShaderExporterBase(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		protected static string SetupTexture(Scene scene, string usdShaderPath, Material material, PreviewSurfaceSample surface, Vector4 scale, string destTexturePath, string textureName, string textureOutput, ConversionType conversionType = ConversionType.None /* Metadata: 0x0234D294 */); // 0x000000018B186C68-0x000000018B1880CC
	}

	public abstract class ShaderImporterBase // TypeDefIndex: 60133
	{
		// Fields
		[CompilerGenerated]
		private Material _Material_k__BackingField; // 0x10
		[CompilerGenerated]
		private bool _IsSpecularWorkflow_k__BackingField; // 0x18
		public UnityEngine.Color? Diffuse; // 0x1C
		public Texture2D DiffuseMap; // 0x30
		public UnityEngine.Color? Specular; // 0x38
		public Texture2D SpecularMap; // 0x50
		public Vector3? Normal; // 0x58
		public Texture2D NormalMap; // 0x68
		public float? Displacement; // 0x70
		public Texture2D DisplacementMap; // 0x78
		public float? Occlusion; // 0x80
		public Texture2D OcclusionMap; // 0x88
		public UnityEngine.Color? Emission; // 0x90
		public Texture2D EmissionMap; // 0xA8
		public float? Roughness; // 0xB0
		public Texture2D RoughnessMap; // 0xB8
		public float? Metallic; // 0xC0
		public Texture2D MetallicMap; // 0xC8
		public float? Clearcoat; // 0xD0
		public Texture2D ClearcoatMap; // 0xD8
		public float? ClearcoatRoughness; // 0xE0
		public float? OpacityThreshold; // 0xE8
		public float? Opacity; // 0xF0
		public Texture2D OpacityMap; // 0xF8
	
		// Properties
		public Material Material { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
		public bool IsSpecularWorkflow { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000184D86340-0x0000000184D86350 0x0000000184D86350-0x0000000184D86360
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 60132
		{
			// Fields
			public string localName; // 0x10
	
			// Constructors
			public __c__DisplayClass34_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _MergePrimvars_b__0(string str); // 0x000000018B191A88-0x000000018B191A9C
		}
	
		// Constructors
		public ShaderImporterBase(Material material); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public abstract void ImportFromUsd();
		protected void ImportColorOrMap(Scene scene, Connectable<Vector3> usdParam, bool isNormalMap, SceneImportOptions options, ref Texture2D map, ref UnityEngine.Color? value, out string uvPrimvar); // 0x000000018B1880CC-0x000000018B188224
		protected void ImportValueOrMap<T>(Scene scene, Connectable<T> usdParam, bool isNormalMap, SceneImportOptions options, ref Texture2D map, ref T? value, out string uvPrimvar)
			where T : struct;
		private void MergePrimvars(string newPrimvar, List<string> primvars); // 0x000000018B1886AC-0x000000018B1887B4
		public virtual void ImportParametersFromUsd(Scene scene, string materialPath, MaterialSample materialSample, PreviewSurfaceSample previewSurf, SceneImportOptions options); // 0x000000018B188224-0x000000018B1886AC
	}

	public class StandardShaderExporter : ShaderExporterBase // TypeDefIndex: 60135
	{
		// Nested types
		private enum StandardShaderBlendMode // TypeDefIndex: 60134
		{
			Opaque = 0,
			Cutout = 1,
			Fade = 2,
			Transparent = 3
		}
	
		// Constructors
		public StandardShaderExporter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void ExportStandardSpecular(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // 0x000000018B189C84-0x000000018B189F80
		public static void ExportStandardRoughness(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // 0x000000018B189848-0x000000018B189C84
		public static void ExportStandard(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // 0x000000018B189F80-0x000000018B18A2B4
		public static void ExportGeneric(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // 0x000000018B1887B4-0x000000018B188E34
		private static void ExportStandardCommon(Scene scene, string usdShaderPath, Material mat, UnityPreviewSurfaceSample surface, string destTexturePath); // 0x000000018B188E34-0x000000018B189848
		private static bool ShouldUseSpecularWorkflow(Material material); // 0x000000018B18A2B4-0x000000018B18A3E8
	}

	public class StandardShaderImporter : ShaderImporterBase // TypeDefIndex: 60136
	{
		// Constructors
		public StandardShaderImporter(Material material); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void ImportFromUsd(); // 0x000000018B18A3E8-0x000000018B18AB5C
	}

	public class UnityMaterialData : SampleBase // TypeDefIndex: 60137
	{
		// Fields
		public string shaderName; // 0x10
		public string[] shaderKeywords; // 0x18
		[UsdNamespace("floats")]
		public Dictionary<string, float> floatArgs; // 0x20
		[UsdNamespace("colors")]
		public Dictionary<string, UnityEngine.Color> colorArgs; // 0x28
		[UsdNamespace("vectors")]
		public Dictionary<string, Vector4> vectorArgs; // 0x30
	
		// Constructors
		public UnityMaterialData(); // 0x000000018B191B64-0x000000018B191C70
	}

	public class UnityPreviewSurfaceSample : PreviewSurfaceSample // TypeDefIndex: 60138
	{
		// Fields
		[UsdNamespace("unity")]
		public UnityMaterialData unity; // 0x90
	
		// Constructors
		public UnityPreviewSurfaceSample(); // 0x000000018B191C70-0x000000018B191CE4
	}

	public class UrpShaderImporter : ShaderImporterBase // TypeDefIndex: 60139
	{
		// Constructors
		public UrpShaderImporter(Material material); // 0x00000001853908C0-0x00000001853908D0
	
		// Methods
		public override void ImportFromUsd(); // 0x000000018B191CE4-0x000000018B192458
	}

	public struct ReadAllJob<T> : IEnumerator<SampleEnumerator<T>>, IEnumerable<SampleEnumerator<T>>, IJobParallelFor // TypeDefIndex: 60140
		where T : SampleBase, ISanitizable, new()
	{
		// Fields
		private static Scene m_scene;
		private static SdfPath[] m_paths;
		private static T[] m_results;
		private static object[] m_done;
		private static SampleEnumerator<T> m_current;
		private static AutoResetEvent m_ready;
		private static SceneImportOptions m_importOptions;
	
		// Properties
		public SampleEnumerator<T> Current { get; }
		object IEnumerator.Current { get; }
	
		// Constructors
		public ReadAllJob(Scene scene, SdfPath[] paths, SceneImportOptions importOptions);
	
		// Methods
		private bool ShouldReadPath(Scene scene, SdfPath path);
		public void Run();
		public void Execute(int index);
		private static void AddPrimvarsFromMaterial(int index, ref IArbitraryPrimvars sample);
		public bool MoveNext();
		public void Reset();
		public void Dispose();
		public IEnumerator<SampleEnumerator<T>> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}

	public interface IRestorable // TypeDefIndex: 60141
	{
		// Methods
		bool IsRestoredFromCachedData();
		void FromCachedData(IRestorableData data);
		IRestorableData ToCachedData();
	}

	public interface ISanitizable // TypeDefIndex: 60142
	{
		// Methods
		void Sanitize(Scene scene, SceneImportOptions importOptions);
	}

	public class MeshStaticPropertiesData : IRestorableData // TypeDefIndex: 60143
	{
		// Fields
		internal int[] originalFaceVertexCounts; // 0x10
		internal int[] originalFaceVertexIndices; // 0x18
		internal bool arePrimvarsFaceVarying; // 0x20
		internal Orientation orientation; // 0x24
	
		// Constructors
		public MeshStaticPropertiesData(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class SanitizedXformSample : XformSample, ISanitizable // TypeDefIndex: 60144
	{
		// Constructors
		public SanitizedXformSample(); // 0x000000018B18072C-0x000000018B180734
	
		// Methods
		public void Sanitize(Scene scene, SceneImportOptions importOptions); // 0x000000018B180704-0x000000018B18072C
	}

	public class SanitizedCameraSample : CameraSample, ISanitizable // TypeDefIndex: 60145
	{
		// Constructors
		public SanitizedCameraSample(); // 0x000000018B18072C-0x000000018B180734
	
		// Methods
		public void Sanitize(Scene scene, SceneImportOptions importOptions); // 0x000000018B180704-0x000000018B18072C
	}

	public class SanitizedMeshSample : MeshSample, ISanitizable, IRestorable // TypeDefIndex: 60146
	{
		// Fields
		internal int[] originalFaceVertexCounts; // 0xC0
		internal int[] originalFaceVertexIndices; // 0xC8
		internal bool arePrimvarsFaceVarying; // 0xD0
		internal int[] faceMapping; // 0xD8
		internal int[] triangulatedFaceVertexIndices; // 0xE0
		private bool isRestoredFromCachedData; // 0xE8
	
		// Constructors
		public SanitizedMeshSample(); // 0x000000018B182660-0x000000018B182668
	
		// Methods
		public bool IsRestoredFromCachedData(); // 0x0000000184D8C8C0-0x0000000184D8C8D0
		public void FromCachedData(IRestorableData restorableData); // 0x000000018B180EB4-0x000000018B180F60
		public IRestorableData ToCachedData(); // 0x000000018B181DBC-0x000000018B181E44
		public void BackupTopology(); // 0x000000018B1808A8-0x000000018B1809B0
		public bool IsTopologyBackedUp(); // 0x000000018B181258-0x000000018B181274
		public void Sanitize(Scene scene, SceneImportOptions importOptions); // 0x000000018B181274-0x000000018B181BE0
		internal void Triangulate(bool changeHandedness); // 0x000000018B181E44-0x000000018B1822A8
		internal bool ShouldUnweldVertices(bool bindMaterials); // 0x000000018B181BE0-0x000000018B181DA4
		internal bool AreAnyArbitraryPrimvarsFaceVarying(); // 0x000000018B180734-0x000000018B1808A8
		internal static void Flatten<T>(ref ref T[] values, int[] indices);
		private void UnweldPrimvar(Primvar<object> primvar, bool changeHandedness); // 0x000000018B1822A8-0x000000018B182660
		private static void FlattenPrimvar(Primvar<object> primvar); // 0x000000018B180CB0-0x000000018B180EB4
		internal static void TriangulateAttributes<T>(ref ref T[] values, int[] faceVertexCounts, bool changeHandedness);
		private void ConvertInterpolationToFaceVarying<T>(ref ref T[] values, int[] vertexIndices, bool changeHandedness = false /* Metadata: 0x0234D29F */, TfToken interpolation = null);
		internal TfToken GuessInterpolation(int count); // 0x000000018B180F60-0x000000018B1810B8
		internal bool IsInterpolationValid(TfToken interpolation, int count); // 0x000000018B1810B8-0x000000018B181258
		internal void UniformToFaceVarying<T>(ref ref T[] values, int vertexCount);
		private static void ComputeNormals(Vector3[] points, int[] faceVertexIndices, ref Vector3[] normals); // 0x000000018B1809B0-0x000000018B180CB0
		internal bool ShouldUnwindVertices(bool changeHandedness); // 0x000000018B181DA4-0x000000018B181DBC
	}

	public static class ExportHelpers // TypeDefIndex: 60147
	{
		// Methods
		public static Scene InitForSave(string filePath); // 0x000000018B17AB80-0x000000018B17ACD8
		public static void ExportGameObjects(GameObject[] objects, Scene scene, BasisTransformation basisTransform, bool exportMonoBehaviours = false /* Metadata: 0x0234D2A0 */); // 0x000000018B17A910-0x000000018B17AB80
	}

	public static class HierarchyBuilder // TypeDefIndex: 60154
	{
		// Fields
		private static readonly SdfPath kAbsoluteRootPath; // 0x00
	
		// Nested types
		private struct HierInfo // TypeDefIndex: 60148
		{
			// Fields
			public bool isVisible; // 0x00
			public bool isInstance; // 0x01
			public bool isAssembly; // 0x02
			public bool isModel; // 0x03
			public bool hasPayload; // 0x04
			public UsdPrim prim; // 0x08
			public UsdSkelBindingVector skelBindings; // 0x10
			public SdfPath[] skelJoints; // 0x18
			public string modelAssetPath; // 0x20
			public string modelName; // 0x28
			public string modelVersion; // 0x30
		}
	
		private struct ReadHierJob : IJobParallelFor // TypeDefIndex: 60149
		{
			// Fields
			public static HierInfo[] result; // 0x00
			public static Scene scene; // 0x08
			public static UsdSkelCache skelCache; // 0x10
			public static SdfPath[] paths; // 0x18
	
			// Methods
			public void Run(); // 0x000000018B180698-0x000000018B180704
			public void Execute(int index); // 0x000000018B1804AC-0x000000018B180698
		}
	
		private struct FindPathsJob : IJobParallelFor // TypeDefIndex: 60152
		{
			// Fields
			public static SdfPath usdRoot; // 0x00
			public static Scene scene; // 0x08
			public static SdfPath[][] results; // 0x10
			public static IQuery[] queries; // 0x18
	
			// Nested types
			public interface IQuery // TypeDefIndex: 60150
			{
				// Methods
				SdfPath[] Find(Scene scene, SdfPath usdRoot);
			}
	
			public struct Query<T> : IQuery // TypeDefIndex: 60151
				where T : SampleBase, new()
			{
				// Methods
				public SdfPath[] Find(Scene scene, SdfPath usdRoot);
			}
	
			// Methods
			public void Run(); // 0x000000018B17AE58-0x000000018B17AEC4
			public void Execute(int index); // 0x000000018B17AD50-0x000000018B17AE58
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 60153
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<SdfPath[], bool> __9__4_0; // 0x08
			public static Func<SdfPath[], IEnumerable<SdfPath>> __9__4_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B191A9C-0x000000018B191B00
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _BeginReading_b__4_0(SdfPath[] i); // 0x000000018721682C-0x0000000187216834
			internal IEnumerable<SdfPath> _BeginReading_b__4_1(SdfPath[] i); // 0x0000000184D88C30-0x0000000184D88C40
		}
	
		// Constructors
		static HierarchyBuilder(); // 0x000000018B17E758-0x000000018B17E7A8
	
		// Methods
		private static JobHandle BeginReading(Scene scene, SdfPath usdRoot, PrimMap map, SceneImportOptions options); // 0x000000018B17B38C-0x000000018B17BD64
		private static HierInfo[] BuildObjectLists(Scene scene, GameObject unityRoot, SdfPath usdRoot, PrimMap map, SceneImportOptions options); // 0x000000018B17CAAC-0x000000018B17CC40
		public static PrimMap BuildGameObjects(Scene scene, GameObject unityRoot, SdfPath usdRoot, IEnumerable<SdfPath> paths, PrimMap map, SceneImportOptions options); // 0x000000018B17BD64-0x000000018B17CAAC
		private static bool IsVisible(UsdPrim usdPrim); // 0x000000018B17D578-0x000000018B17D6C0
		private static void ApplySelfVisibility(GameObject go, UsdPrim usdPrim); // 0x000000018B17B2FC-0x000000018B17B38C
		private static void CreateAncestors(SdfPath path, PrimMap map, GameObject unityRoot, SdfPath usdRoot, SceneImportOptions options, out GameObject parentGo); // 0x000000018B17CC40-0x000000018B17CF8C
		private static void ProcessPaths(HierInfo[] infos, Scene scene, GameObject unityRoot, SdfPath usdRoot, PrimMap map, SceneImportOptions options); // 0x000000018B17D944-0x000000018B17DEE0
		private static void PopulateSkelCache(ref HierInfo skelRootInfo, UsdSkelCache skelCache); // 0x000000018B17D6C0-0x000000018B17D944
		private static void ReadSkeletonJoints(ref HierInfo skelRootInfo); // 0x000000018B17E1D8-0x000000018B17E758
		private static void ExpandSkeleton(HierInfo info, GameObject unityRoot, SdfPath usdRoot, UsdPrim prim, PrimMap map, SceneImportOptions options); // 0x000000018B17CF8C-0x000000018B17D2D8
		private static void ReadModelInfo(ref HierInfo info); // 0x000000018B17DEE0-0x000000018B17E1D8
		private static void AddModelRoot(GameObject go, HierInfo info); // 0x000000018B17AEC4-0x000000018B17B0D4
		private static void AddPayload(GameObject go, HierInfo info, SceneImportOptions options); // 0x000000018B17B0D4-0x000000018B17B1CC
		private static void AddVariantSet(GameObject go, UsdPrim prim); // 0x000000018B17B1CC-0x000000018B17B2FC
		private static GameObject FindOrCreateGameObject(Transform parent, SdfPath path, Transform unityRoot, PrimMap primMap, SceneImportOptions options); // 0x000000018B17D2D8-0x000000018B17D578
	}

	public static class ImportHelpers // TypeDefIndex: 60155
	{
		// Methods
		public static GameObject ImportSceneAsGameObject(Scene scene, GameObject parent = null, SceneImportOptions importOptions = null); // 0x000000018B17EA80-0x000000018B17ECE8
		public static Scene InitForOpen(string path = "" /* Metadata: 0x0234D2A1 */, UsdStage.InitialLoadSet loadSet = UsdStage.InitialLoadSet.LoadNone /* Metadata: 0x0234D2A2 */); // 0x000000018B17ECE8-0x000000018B17ED5C
		private static SdfPath GetDefaultRoot(Scene scene); // 0x000000018B17E8B0-0x000000018B17E964
		private static GameObject UsdToGameObject(GameObject parent, Scene scene, SceneImportOptions importOptions); // 0x000000018B17ED5C-0x000000018B17EE74
		private static string GetObjectName(SdfPath rootPrimName, string path); // 0x000000018B17E964-0x000000018B17E9EC
		private static string GetObjectName(string path); // 0x000000018B17E9EC-0x000000018B17EA38
		private static string GetPrefabName(string path); // 0x000000018B17EA38-0x000000018B17EA80
	}

	public interface IImportProcessUsd // TypeDefIndex: 60156
	{
		// Methods
		void ProcessUsd(Scene scene, SceneImportOptions sceneImportOptions);
	}

	public interface IImportPostProcessHierarchy // TypeDefIndex: 60157
	{
		// Methods
		void PostProcessHierarchy(PrimMap primMap, SceneImportOptions sceneImportOptions);
	}

	public interface IImportPostProcessComponents // TypeDefIndex: 60158
	{
		// Methods
		void PostProcessComponents(PrimMap primMap, SceneImportOptions sceneImportOptions);
	}

	public class PrimMap : IEnumerable<KeyValuePair<SdfPath, GameObject>> // TypeDefIndex: 60160
	{
		// Fields
		public UsdSkelCache SkelCache; // 0x10
		public Dictionary<SdfPath, UsdSkelBindingVector> SkelBindings; // 0x18
		public Dictionary<SdfPath, UsdSkelSkinningQuery> SkinningQueries; // 0x20
		public Dictionary<SdfPath, MeshImporter.GeometrySubsets> MeshSubsets; // 0x28
		[CompilerGenerated]
		private SdfPath[] _Cameras_k__BackingField; // 0x30
		[CompilerGenerated]
		private SdfPath[] _Meshes_k__BackingField; // 0x38
		[CompilerGenerated]
		private SdfPath[] _Cubes_k__BackingField; // 0x40
		[CompilerGenerated]
		private SdfPath[] _Spheres_k__BackingField; // 0x48
		[CompilerGenerated]
		private SdfPath[] _Xforms_k__BackingField; // 0x50
		[CompilerGenerated]
		private SdfPath[] _SkelRoots_k__BackingField; // 0x58
		[CompilerGenerated]
		private SdfPath[] _Skeletons_k__BackingField; // 0x60
		[CompilerGenerated]
		private SdfPath[] _Materials_k__BackingField; // 0x68
		[CompilerGenerated]
		private bool _ContainsPointInstances_k__BackingField; // 0x70
		[CompilerGenerated]
		private bool _HasErrors_k__BackingField; // 0x71
		private Dictionary<SdfPath, GameObject> m_prims; // 0x78
		private Dictionary<SdfPath, InstanceRoot> m_instanceRoots; // 0x80
		private HashSet<GameObject> m_instances; // 0x88
		private Dictionary<SdfPath, GameObject> m_masterRoots; // 0x90
	
		// Properties
		public SdfPath[] Cameras { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001811F36E0-0x00000001811F36F0 0x0000000185396200-0x0000000185396210
		public SdfPath[] Meshes { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A50-0x0000000184D85A60 0x00000001846A91B0-0x00000001846A91C0
		public SdfPath[] Cubes { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D85A60-0x0000000184D85A70 0x00000001842B4AE0-0x00000001842B4AF0
		public SdfPath[] Spheres { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public SdfPath[] Xforms { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public SdfPath[] SkelRoots { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182E56440-0x0000000182E56460 0x00000001836E5590-0x00000001836E55A0
		public SdfPath[] Skeletons { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86280-0x0000000184D86290 0x00000001863CC164-0x00000001863CC174
		public SdfPath[] Materials { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86230-0x0000000184D86240 0x000000018485F170-0x000000018485F180
		public bool ContainsPointInstances { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86A50-0x0000000184D86A60 0x0000000184D86A80-0x0000000184D86A90
		public bool HasErrors { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D89040-0x0000000184D89050 0x0000000184D89050-0x0000000184D89060
		public GameObject this[SdfPath path] { get => default; set {} } // 0x000000018B18035C-0x000000018B180448 0x000000018B180448-0x000000018B1804AC
	
		// Nested types
		public struct InstanceRoot // TypeDefIndex: 60159
		{
			// Fields
			public GameObject gameObject; // 0x00
			public SdfPath masterPath; // 0x08
		}
	
		// Constructors
		public PrimMap(); // 0x000000018B180170-0x000000018B18035C
	
		// Methods
		public bool TryGetValue(SdfPath key, out GameObject obj); // 0x000000018B18010C-0x000000018B180170
		public IEnumerator GetEnumerator(); // 0x000000018B17FF6C-0x000000018B17FFF4
		IEnumerator<KeyValuePair<SdfPath, GameObject>> IEnumerable<KeyValuePair<SdfPath, GameObject>>.GetEnumerator(); // 0x000000018B180084-0x000000018B18010C
		public void AddInstance(GameObject goInst); // 0x000000018B17F898-0x000000018B17F8F0
		public void AddMasterRoot(SdfPath path, GameObject go); // 0x000000018B17F8F0-0x000000018B17F968
		public void AddInstanceRoot(SdfPath instancePath, GameObject go, SdfPath masterPath); // 0x000000018B17F7EC-0x000000018B17F898
		public Dictionary<SdfPath, GameObject> GetMasterRootPaths(); // 0x000000018B18003C-0x000000018B180084
		public Dictionary<SdfPath, InstanceRoot> GetInstanceRoots(); // 0x000000018B17FFF4-0x000000018B18003C
		public void DestroyAll(); // 0x000000018B17FA94-0x000000018B17FF6C
		public void Clear(); // 0x000000018B17F968-0x000000018B17FA94
	}

	public delegate void ExportFunction(ObjectContext objContext, ExportContext exportContext); // TypeDefIndex: 60161; 0x0000000187D85524-0x0000000187D85554

	internal delegate void ObjectProcessor(GameObject go, ExportContext context); // TypeDefIndex: 60162; 0x00000001838E1420-0x00000001838E1430

	public struct ObjectContext // TypeDefIndex: 60163
	{
		// Fields
		public GameObject gameObject; // 0x00
		public string path; // 0x08
		public SampleBase sample; // 0x10
		public object additionalData; // 0x18
	}

	public enum ActiveExportPolicy // TypeDefIndex: 60164
	{
		ExportAsVisibility = 0,
		ExportAsActive = 1,
		DoNotExport = 2,
		Ignore = 3
	}

	public class ExportContext // TypeDefIndex: 60165
	{
		// Fields
		public Scene scene; // 0x10
		public Transform exportRoot; // 0x18
		public bool exportMaterials; // 0x20
		public bool exportNative; // 0x21
		public float scale; // 0x24
		public bool exportTransformOverrides; // 0x28
		public BasisTransformation basisTransform; // 0x2C
		public ActiveExportPolicy activePolicy; // 0x30
		public Dictionary<GameObject, ExportPlan> plans; // 0x38
		public Dictionary<Material, string> matMap; // 0x40
		public Dictionary<Transform, Transform> meshToSkelRoot; // 0x48
		public Dictionary<Transform, Transform[]> meshToBones; // 0x50
		public Dictionary<Transform, List<string>> skelSortedMap; // 0x58
		public Dictionary<string, Transform> pathToBone; // 0x60
		public Dictionary<Transform, Transform> boneToRoot; // 0x68
		public Dictionary<Transform, Matrix4x4> bindPoses; // 0x70
		public Dictionary<System.Type, SampleBase> samples; // 0x78
		public Stopwatch analyticsTotalTimeStopwatch; // 0x80
	
		// Constructors
		public ExportContext(); // 0x000000018B17A4C8-0x000000018B17A7C0
	}

	public class Exporter // TypeDefIndex: 60166
	{
		// Fields
		public string path; // 0x10
		public SampleBase sample; // 0x18
		public ExportFunction exportFunc; // 0x20
		public object data; // 0x28
	
		// Constructors
		public Exporter(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class ExportPlan // TypeDefIndex: 60167
	{
		// Fields
		public List<Exporter> exporters; // 0x10
	
		// Constructors
		public ExportPlan(); // 0x000000018B17ACD8-0x000000018B17AD50
	}

	public static class SceneExporter // TypeDefIndex: 60169
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 60168
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, string> __9__8_0; // 0x08
			public static Func<string, string> __9__8_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018B191B00-0x000000018B191B64
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal string _MergeBonesBelowAnimator_b__8_0(Transform boneXf); // 0x000000018B191A3C-0x000000018B191A88
			internal string _MergeBonesBelowAnimator_b__8_1(string str); // 0x0000000184D88C30-0x0000000184D88C40
		}
	
		// Methods
		public static void Export(GameObject root, Scene scene, BasisTransformation basisTransform, bool exportUnvarying, bool zeroRootTransform, bool exportMaterials = false /* Metadata: 0x0234D2A7 */, bool exportMonoBehaviours = false /* Metadata: 0x0234D2A8 */, bool exportOverrides = false /* Metadata: 0x0234D2A9 */); // 0x000000018B183ED4-0x000000018B184044
		public static void Export(GameObject root, ExportContext context, bool zeroRootTransform); // 0x000000018B183940-0x000000018B183ED4
		private static void ExportImpl(GameObject root, ExportContext context); // 0x000000018B182DA8-0x000000018B183940
		private static void Traverse(GameObject obj, ObjectProcessor processor, ExportContext context); // 0x000000018B186354-0x000000018B186528
		private static void AccumNestedBones(Transform curXf, List<Transform> children, ExportContext ctx); // 0x000000018B182668-0x000000018B182860
		private static T CreateSample<T>(ExportContext context)
			where T : SampleBase, new();
		public static void SyncExportContext(GameObject exportRoot, ExportContext context); // 0x000000018B185658-0x000000018B186354
		private static void InitExportableObjects(GameObject go, ExportContext context); // 0x000000018B184044-0x000000018B184A6C
		private static Transform MergeBonesBelowAnimator(Transform animator, ExportContext context); // 0x000000018B184A6C-0x000000018B185208
		private static void MergeBonesSimple(Transform source, Transform rootBone, Transform[] bones, Matrix4x4[] bindPoses, ExportContext context); // 0x000000018B185208-0x000000018B185658
		private static void CreateExportPlan(GameObject go, SampleBase sample, ExportFunction exportFunc, ExportContext context, string pathSuffix = null, bool insertFirst = true /* Metadata: 0x0234D2AA */); // 0x000000018B1829D8-0x000000018B182DA8
		private static Matrix4x4 ComputeWorldXf(Transform curBone, ExportContext context); // 0x000000018B182860-0x000000018B1829D8
	}

	public interface IImporter // TypeDefIndex: 60170
	{
		// Methods
		void BeginReading(Scene scene, PrimMap primMap, SceneImportOptions importOptions);
		IEnumerator Import(Scene scene, PrimMap primMap, SceneImportOptions importOptions);
	}

	public static class SceneImporter // TypeDefIndex: 60173
	{
		// Fields
		public static IImporter ActiveMeshImporter; // 0x00
	
		// Nested types
		public class ImportException : Exception // TypeDefIndex: 60171
		{
			// Constructors
			public ImportException(); // 0x000000018B17E7A8-0x000000018B17E7F4
			public ImportException(string message); // 0x000000018B17E854-0x000000018B17E8B0
			public ImportException(string message, Exception innerException); // 0x000000018B17E7F4-0x000000018B17E854
		}
	
		[CompilerGenerated]
		private sealed class _BuildScene_d__8 : IEnumerator<object> // TypeDefIndex: 60172
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public SceneImportOptions importOptions; // 0x20
			public float targetFrameMilliseconds; // 0x28
			public GameObject root; // 0x30
			public PrimMap primMap; // 0x38
			public Scene scene; // 0x40
			public bool composingSubtree; // 0x48
			private Stopwatch _timer_5__2; // 0x50
			private SdfPath _usdPrimRoot_5__3; // 0x58
			private float _targetTime_5__4; // 0x60
			private List<UsdSkelRoot> _skelRoots_5__5; // 0x68
			private ReadAllJob<SanitizedXformSample> _readXforms_5__6; // 0x70
			private SdfPath[] __7__wrap6; // 0x78
			private int __7__wrap7; // 0x80
			private IEnumerator<SampleEnumerator<MaterialSample>> __7__wrap8; // 0x88
			private IEnumerator<SampleEnumerator<SanitizedXformSample>> __7__wrap9; // 0x90
			private IEnumerator<SampleEnumerator<XformSample>> __7__wrap10; // 0x98
			private IEnumerator _it_5__12; // 0xA0
			private IEnumerator<SampleEnumerator<CubeSample>> __7__wrap12; // 0xA8
			private IEnumerator<SampleEnumerator<SphereSample>> __7__wrap13; // 0xB0
			private IEnumerator<SampleEnumerator<SanitizedCameraSample>> __7__wrap14; // 0xB8
			private Dictionary<SdfPath, GameObject> __7__wrap15; // 0xC0
			private Dictionary<SdfPath, SkeletonSample> _skeletonSamples_5__17; // 0xD8
			private Dictionary<SdfPath, SkeletonSample> __7__wrap17; // 0xE0
			private IEnumerator<SampleEnumerator<PointInstancerSample>> __7__wrap18; // 0x108
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _BuildScene_d__8(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018B191278-0x000000018B191744
			private bool MoveNext(); // 0x000000018B18AD0C-0x000000018B19122C
			private void __m__Finally1(); // 0x000000018B191794-0x000000018B1917E4
			private void __m__Finally2(); // 0x000000018B1917E4-0x000000018B191834
			private void __m__Finally3(); // 0x000000018B191834-0x000000018B191884
			private void __m__Finally4(); // 0x000000018B191884-0x000000018B1918D4
			private void __m__Finally5(); // 0x000000018B1918D4-0x000000018B191924
			private void __m__Finally6(); // 0x000000018B191924-0x000000018B191974
			private void __m__Finally7(); // 0x000000018B191974-0x000000018B1919C4
			private void __m__Finally8(); // 0x000000018B1919C4-0x000000018B191A00
			private void __m__Finally9(); // 0x000000018B191A00-0x000000018B191A3C
			private void __m__Finally10(); // 0x000000018B191744-0x000000018B191794
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B19122C-0x000000018B191278
		}
	
		// Constructors
		static SceneImporter(); // 0x000000018B186B58-0x000000018B186C68
	
		// Methods
		public static void ImportUsd(GameObject goRoot, Scene scene, PrimMap primMap, SceneImportOptions importOptions); // 0x000000018B186778-0x000000018B1867F4
		public static void ImportUsd(GameObject goRoot, Scene scene, PrimMap primMap, bool composingSubtree, SceneImportOptions importOptions); // 0x000000018B1867F4-0x000000018B186A28
		private static UsdEditorAnalytics.ImportResult CreateImportResult(bool success, PrimMap primMap, ImportType importType = ImportType.Initial /* Metadata: 0x0234D2AB */); // 0x000000018B186700-0x000000018B186778
		public static PrimMap BuildScene(Scene scene, GameObject root, SceneImportOptions importOptions, PrimMap primMap, bool composingSubtree); // 0x000000018B186528-0x000000018B186644
		private static void RemoveComponent<T>(GameObject go);
		[IteratorStateMachine(typeof(_BuildScene_d__8))]
		public static IEnumerator BuildScene(Scene scene, GameObject root, SceneImportOptions importOptions, PrimMap primMap, float targetFrameMilliseconds, bool composingSubtree); // 0x000000018B186644-0x000000018B186700
		private static bool ShouldYield(float targetTime, Stopwatch timer); // 0x000000018B186B1C-0x000000018B186B58
		private static void ResetTimer(Stopwatch timer); // 0x000000018B186AE4-0x000000018B186B1C
		private static bool IsSkinnedMesh(UsdPrim prim, PrimMap primMap, SceneImportOptions importOptions); // 0x000000018B186A28-0x000000018B186AE4
	}

	public enum PayloadPolicy // TypeDefIndex: 60174
	{
		DontLoadPayloads = 0,
		LoadAll = 1
	}

	public enum BasisTransformation // TypeDefIndex: 60175
	{
		FastWithNegativeScale = 0,
		SlowAndSafe = 1,
		SlowAndSafeAsFBX = 2,
		None = 3
	}

	[Serializable]
	public enum MaterialImportMode // TypeDefIndex: 60176
	{
		ImportPreviewSurface = 0,
		ImportDisplayColor = 1,
		None = 2
	}

	[Serializable]
	public class SceneImportOptions // TypeDefIndex: 60177
	{
		// Fields
		public string projectAssetPath; // 0x10
		public SdfPath usdRootPath; // 0x18
		public bool forceRebuild; // 0x20
		public PayloadPolicy payloadPolicy; // 0x24
		public bool importHierarchy; // 0x28
		public bool importCameras; // 0x29
		public bool importMeshes; // 0x2A
		public bool importSkinning; // 0x2B
		public bool importSkinWeights; // 0x2C
		public bool importTransforms; // 0x2D
		public bool importSceneInstances; // 0x2E
		public bool importPointInstances; // 0x2F
		public bool importMonoBehaviours; // 0x30
		public BasisTransformation changeHandedness; // 0x34
		public float scale; // 0x38
		public bool interpolate; // 0x3C
		public bool enableGpuInstancing; // 0x3D
		public bool useDisplayColorAsFallbackMaterial; // 0x3E
		public MaterialImportMode materialImportMode; // 0x40
		[NonSerialized]
		public MaterialMap materialMap; // 0x48
		public MeshImportOptions meshOptions; // 0x50
		[CompilerGenerated]
		private ImportType _ImportType_k__BackingField; // 0x58
	
		// Properties
		public bool ShouldBindMaterials { get; } // 0x000000018B192578-0x000000018B192580 
		public ImportType ImportType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86570-0x0000000184D86580 0x0000000184D865D0-0x0000000184D865E0
	
		// Constructors
		public SceneImportOptions(); // 0x000000018B192458-0x000000018B192578
	}

	public class UsdzExporter // TypeDefIndex: 60178
	{
		// Constructors
		public UsdzExporter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void ExportUsdz(string usdzFilePath, GameObject root); // 0x000000018B1975F0-0x000000018B197C14
	}

	public static class SkeletonExporter // TypeDefIndex: 60179
	{
		// Methods
		public static void ExportSkeleton(ObjectContext objContext, ExportContext exportContext); // 0x000000018B1932E0-0x000000018B193B1C
		public static void ExportSkelRoot(ObjectContext objContext, ExportContext exportContext); // 0x000000018B192E40-0x000000018B1932E0
		public static void ExportSkelAnimation(ObjectContext objContext, ExportContext exportContext); // 0x000000018B19274C-0x000000018B192E40
	}

	public static class SkeletonImporter // TypeDefIndex: 60180
	{
		// Methods
		public static void BuildSkeletonBone(string skelPath, GameObject go, Matrix4x4 restXform, VtTokenArray joints, SceneImportOptions importOptions); // 0x000000018B1944C8-0x000000018B194938
		public static void BuildDebugBindTransforms(SkeletonSample skelSample, GameObject goSkeleton, SceneImportOptions options); // 0x000000018B193C28-0x000000018B1944C8
		public static void BuildBindTransforms(string path, SkeletonSample skelSample, SceneImportOptions options); // 0x000000018B193B1C-0x000000018B193C28
		private static bool JointsMatch(string[] lhs, string[] rhs); // 0x000000018B1951A4-0x000000018B195220
		public static void BuildSkinnedMesh(string meshPath, string skelPath, SkeletonSample skeleton, UsdSkelSkinningQuery skinningQuery, GameObject go, PrimMap primMap, SceneImportOptions options); // 0x000000018B194938-0x000000018B1951A4
	}

	public class UnitySkeleton // TypeDefIndex: 60181
	{
		// Fields
		public Transform rootBone; // 0x10
		public Transform[] bones; // 0x18
	
		// Constructors
		public UnitySkeleton(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class SkelBindingSample : SampleBase // TypeDefIndex: 60182
	{
		// Fields
		[UsdNamespace("skel")]
		[UsdVariability(Variability.Uniform)]
		public string[] blendShapes; // 0x10
		[UsdNamespace("skel")]
		public Relationship blendShapeTargets; // 0x18
		[UsdNamespace("skel")]
		public Relationship animationSource; // 0x20
		[UsdNamespace("skel")]
		public Relationship skeleton; // 0x28
		[UsdNamespace("skel")]
		[UsdVariability(Variability.Uniform)]
		public string[] joints; // 0x30
		[UsdNamespace("skel")]
		[UsdVariability(Variability.Uniform)]
		public Primvar<int[]> jointIndices; // 0x38
		[UsdNamespace("skel")]
		[UsdVariability(Variability.Uniform)]
		public Primvar<Matrix4x4> geomBindTransform; // 0x40
		[UsdNamespace("skel")]
		[UsdVariability(Variability.Uniform)]
		public Primvar<float[]> jointWeights; // 0x48
	
		// Constructors
		public SkelBindingSample(); // 0x000000018B192580-0x000000018B1926D0
	}

	[Serializable]
	[UsdSchema("SkelRoot")]
	public class SkelRootSample : BoundableSample // TypeDefIndex: 60183
	{
		// Fields
		[UsdNamespace("skel")]
		public Relationship skeleton; // 0x78
		[UsdNamespace("skel")]
		public Relationship animationSource; // 0x80
	
		// Constructors
		public SkelRootSample(); // 0x000000018B1926D0-0x000000018B19274C
	}

	[Serializable]
	[UsdSchema("Skeleton")]
	public class SkeletonSample : XformableSample // TypeDefIndex: 60184
	{
		// Fields
		[UsdVariability(Variability.Uniform)]
		public string[] joints; // 0x60
		[UsdVariability(Variability.Uniform)]
		public Matrix4x4[] bindTransforms; // 0x68
		[UsdVariability(Variability.Uniform)]
		public Matrix4x4[] restTransforms; // 0x70
	
		// Constructors
		public SkeletonSample(); // 0x000000018B18072C-0x000000018B180734
	}

	[Serializable]
	[UsdSchema("SkelAnimation")]
	public class SkelAnimationSample : SampleBase // TypeDefIndex: 60185
	{
		// Fields
		[UsdVariability(Variability.Uniform)]
		public string[] joints; // 0x10
		public Vector3[] translations; // 0x18
		public Quaternion[] rotations; // 0x20
		public VtVec3hArray scales; // 0x28
		[UsdVariability(Variability.Uniform)]
		public string[] blendShapes; // 0x30
		[UsdVariability(Variability.Uniform)]
		public float[] blendShapeWeights; // 0x38
	
		// Constructors
		public SkelAnimationSample(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	[UsdSchema("BlendShape")]
	public class BlendShapeSample : SampleBase // TypeDefIndex: 60186
	{
		// Fields
		public Vector3[] offsets; // 0x10
		public uint[] pointIndices; // 0x18
	
		// Constructors
		public BlendShapeSample(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class SkeletonIo // TypeDefIndex: 60187
	{
		// Fields
		private Dictionary<Transform, Transform[]> m_bindings; // 0x10
	
		// Constructors
		public SkeletonIo(); // 0x000000018B1952D8-0x000000018B195350
	
		// Methods
		public Transform[] GetBones(Transform rootBone); // 0x000000018B195220-0x000000018B195274
		public void RegisterSkeleton(Transform rootBone, Transform[] bones); // 0x000000018B195274-0x000000018B1952D8
	}

	public class NativeExporter // TypeDefIndex: 60188
	{
		// Constructors
		public NativeExporter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void ExportObject(ObjectContext objContext, ExportContext exportContext); // 0x00000001841E1670-0x00000001841E1680
	}

	public class NativeImporter // TypeDefIndex: 60189
	{
		// Constructors
		public NativeImporter(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public static void ImportObject(Scene scene, GameObject go, UsdPrim usdPrim, SceneImportOptions options); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	public class UsdPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 60190
	{
		// Fields
		private UsdAsset m_sourceUsdAsset; // 0x18
		[Tooltip("USD Player to Control")]
		public ExposedReference<UsdAsset> SourceUsdAsset; // 0x20
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x0000000184D8D050-0x0000000184D8D060 
		public override double duration { get; } // 0x000000018B195880-0x000000018B1959D8 
	
		// Constructors
		public UsdPlayableAsset(); // 0x0000000183573370-0x0000000183573380
	
		// Methods
		public UsdAsset GetUsdAsset(string usdRootPath); // 0x000000018B195854-0x000000018B195880
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018B195688-0x000000018B195854
	}

	public class UsdPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 60191
	{
		// Fields
		public UsdPlayableAsset playableAsset; // 0x10
		private bool m_errorOnce; // 0x18
	
		// Constructors
		public UsdPlayableBehaviour(); // 0x0000000184D8EB60-0x0000000184D8EB70
	
		// Methods
		public override void OnGraphStart(Playable playable); // 0x000000018B1959D8-0x000000018B1959E0
		public override void OnGraphStop(Playable playable); // 0x00000001841E1670-0x00000001841E1680
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x00000001841E1670-0x00000001841E1680
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x00000001841E1670-0x00000001841E1680
		public override void PrepareFrame(Playable playable, FrameData info); // 0x00000001841E1670-0x00000001841E1680
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x000000018B1959E0-0x000000018B195B60
		public override void PrepareData(Playable playable, FrameData info); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	[TrackBindingType(typeof(UsdAsset))]
	[TrackClipType(typeof(UsdPlayableAsset))]
	[TrackColor(0.1f, 0.2f, 0.8f)]
	public class UsdPlayableTrack : TrackAsset // TypeDefIndex: 60192
	{
		// Constructors
		public UsdPlayableTrack(); // 0x000000018B195B9C-0x000000018B195BE8
	
		// Methods
		protected override void OnCreateClip(TimelineClip clip); // 0x000000018B195B60-0x000000018B195B9C
	}

	public class UsdRecorderBehaviour : PlayableBehaviour // TypeDefIndex: 60194
	{
		// Fields
		private const int kExportFrameRate = 60; // Metadata: 0x0234D2B5
		private bool m_isPaused; // 0x10
		public UsdRecorderClip Clip; // 0x18
		private string usdcFileName; // 0x20
		private string usdzFileName; // 0x28
		private string usdzFilePath; // 0x30
		private string currentDir; // 0x38
		private DirectoryInfo usdzTemporaryDir; // 0x40
		private GameObject _root; // 0x48
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 60193
		{
			// Fields
			public UsdRecorderBehaviour __4__this; // 0x10
			public Playable playable; // 0x18
			public FrameData info; // 0x28
			public object playerData; // 0x68
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal void _ProcessFrame_b__0(); // 0x000000018B195350-0x000000018B1953B8
		}
	
		// Constructors
		public UsdRecorderBehaviour(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		public void BeginRecording(double currentTime, GameObject root); // 0x000000018B195BE8-0x000000018B19679C
		public void StopRecording(double currentTime); // 0x000000018B196C9C-0x000000018B197080
		private void ProcessRecording(double currentTime, GameObject root); // 0x000000018B196B18-0x000000018B196C9C
		private bool IsPlaying(); // 0x0000000182FFF600-0x0000000182FFF610
		public override void OnPlayableCreate(Playable playable); // 0x00000001841E1670-0x00000001841E1680
		public override void OnPlayableDestroy(Playable playable); // 0x000000018B1969A4-0x000000018B1969FC
		public override void OnGraphStart(Playable playable); // 0x000000018B196884-0x000000018B19694C
		public override void OnGraphStop(Playable playable); // 0x000000018B19694C-0x000000018B1969A4
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x000000018B1969FC-0x000000018B196B18
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x0000000184D8CCB0-0x0000000184D8CCC0
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x00000001815EFCD0-0x00000001815EFCE0
		public void OnFrameEnd(Playable playable, FrameData info, object playerData); // 0x000000018B19679C-0x000000018B196884
	}

	[System.ComponentModel.DisplayName("USD Recorder Clip")]
	public class UsdRecorderClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 60195
	{
		// Fields
		public ExposedReference<GameObject> m_exportRoot; // 0x18
		private GameObject[] m_trackedRoots; // 0x28
		public bool m_exportMaterials; // 0x30
		public BasisTransformation m_convertHandedness; // 0x34
		public ActiveExportPolicy m_activePolicy; // 0x38
		public string m_usdFile; // 0x40
		[CompilerGenerated]
		private Scene _UsdScene_k__BackingField; // 0x48
		private ExportContext m_context; // 0x50
	
		// Properties
		public Scene UsdScene { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000184D86200-0x0000000184D86210 0x00000001835A41A0-0x00000001835A41B0
		public ExportContext Context { get; set; } // 0x0000000184D86270-0x0000000184D86280 0x0000000182FDAEA0-0x0000000182FDAEB0
		public ClipCaps clipCaps { get; } // 0x00000001811EC580-0x00000001811EC590 
		public bool IsUSDZ { get; } // 0x000000018B197268-0x000000018B1972D4 
	
		// Constructors
		public UsdRecorderClip(); // 0x000000018B1971CC-0x000000018B197268
	
		// Methods
		public GameObject GetExportRoot(PlayableGraph graph); // 0x000000018B197178-0x000000018B1971CC
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018B197080-0x000000018B197178
		public virtual void OnDestroy(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	[TrackClipType(typeof(UsdRecorderClip))]
	[TrackColor(0.7f, 0f, 0f)]
	public class UsdRecorderTrack : TrackAsset // TypeDefIndex: 60196
	{
		// Constructors
		public UsdRecorderTrack(); // 0x000000018B1972D4-0x000000018B197320
	}

	[ExecuteInEditMode]
	internal class UsdWaitForEndOfFrame : MonoBehaviour // TypeDefIndex: 60198
	{
		// Fields
		private List<Action> m_pending; // 0x18
		private static UsdWaitForEndOfFrame s_instance; // 0x00
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitForEndOfFrame_d__4 : IEnumerator<object> // TypeDefIndex: 60197
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UsdWaitForEndOfFrame __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018385B100-0x000000018385B110 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForEndOfFrame_d__4(int __1__state); // 0x00000001814F51F0-0x00000001814F5220
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x00000001841E1670-0x00000001841E1680
			private bool MoveNext(); // 0x000000018B1953B8-0x000000018B19563C
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B19563C-0x000000018B195688
		}
	
		// Constructors
		public UsdWaitForEndOfFrame(); // 0x000000018B197570-0x000000018B1975F0
	
		// Methods
		private static UsdWaitForEndOfFrame GetInstance(); // 0x000000018B197374-0x000000018B1974F0
		public static void Add(Action callback); // 0x000000018B197320-0x000000018B197374
		[IteratorStateMachine(typeof(_WaitForEndOfFrame_d__4))]
		private IEnumerator WaitForEndOfFrame(); // 0x000000018B197514-0x000000018B197570
		private void LateUpdate(); // 0x000000018B1974F0-0x000000018B197514
	}
}
