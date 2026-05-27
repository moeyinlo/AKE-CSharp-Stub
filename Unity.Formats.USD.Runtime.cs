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

// Image 47: Unity.Formats.USD.Runtime.dll - Assembly: Unity.Formats.USD.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 56575-56686
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: InternalsVisibleTo("Unity.Formats.USD.Tests.Runtime")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 56577
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 56578
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 56579
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 56580
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 56581
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 56576
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace Unity.Formats.USD
{
	public class UsdAssemblyRoot : MonoBehaviour // TypeDefIndex: 56582
	{
		// Constructors
		public UsdAssemblyRoot() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[ExecuteInEditMode]
	public class UsdAsset : MonoBehaviour // TypeDefIndex: 56583
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
		public double Length { get => default; } // 0x0000000189B7CE4C-0x0000000189B7CE54 
		public string usdFullPath { get => default; set {} } // 0x0000000189B7CE54-0x0000000189B7CECC 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public UsdAsset() {} // 0x0000000189B7CD90-0x0000000189B7CE4C
	
		// Methods
		private void OnDestroy() {} // 0x0000000189B7A858-0x0000000189B7A89C
		private string GetPrefabAssetPath(GameObject root) => default; // 0x0000000181002730-0x0000000181002740
		public void OptionsToState(SceneImportOptions options) {} // 0x0000000189B7A900-0x0000000189B7AB3C
		public void StateToOptions(ref SceneImportOptions options) {} // 0x0000000189B7C958-0x0000000189B7CD50
		private bool SceneFileChanged() => default; // 0x0000000189B7AF44-0x0000000189B7B044
		public Scene GetScene() => default; // 0x0000000189B7A374-0x0000000189B7A688
		private void OnReload() {} // 0x0000000189B7A89C-0x0000000189B7A900
		private void DestroyComponent(UnityEngine.Component comp) {} // 0x0000000189B79D24-0x0000000189B79D84
		private void ClearLastData() {} // 0x0000000189B79B54-0x0000000189B79B9C
		public void RemoveAllUsdComponents() {} // 0x0000000189B7AD48-0x0000000189B7AF44
		public void DestroyAllImportedObjects() {} // 0x0000000189B79C00-0x0000000189B79D24
		public void Reload(bool forceRebuild) {} // 0x0000000189B7ABC0-0x0000000189B7AD48
		private UsdPrim GetFirstPrim(Scene scene) => default; // 0x0000000189B7A2D8-0x0000000189B7A374
		public void ExportOverrides(Scene sceneInWhichToStoreTransforms) {} // 0x0000000189B79D84-0x0000000189B7A2D8
		private double ComputeLength() => default; // 0x0000000189B79B9C-0x0000000189B79C00
		public void SetTime(double time, UsdAsset foreignRoot, bool saveMeshUpdates) {} // 0x0000000189B7B88C-0x0000000189B7C04C
		private void Update() {} // 0x0000000189B7CD50-0x0000000189B7CD90
		public static void PrepOptionsForTimeChange(ref SceneImportOptions options) {} // 0x0000000189B7AB3C-0x0000000189B7ABC0
		public void ImportUsdAsCoroutine(GameObject goRoot, string usdFilePath, double time, SceneImportOptions importOptions, float targetFrameMilliseconds) {} // 0x0000000189B7A688-0x0000000189B7A858
		public void SetPayloadState(GameObject go, bool isLoaded) {} // 0x0000000189B7B044-0x0000000189B7B88C
		private void ApplyVariantSelectionState(Scene scene, UsdVariantSet variants) {} // 0x0000000189B79810-0x0000000189B79B54
		public void SetVariantSelection(GameObject go, string usdPrimPath, Dictionary<string, string> selections) {} // 0x0000000189B7C04C-0x0000000189B7C958
	}

	[RequireComponent(typeof(UsdAsset))]
	public class UsdLayerStack : MonoBehaviour // TypeDefIndex: 56584
	{
		// Fields
		public string m_targetLayer; // 0x18
		public string[] m_layerStack; // 0x20
		public string[] m_mutedLayers; // 0x28
	
		// Constructors
		public UsdLayerStack() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void SetupNewSubLayer(Scene parentScene, Scene subLayerScene) {} // 0x0000000189B7D3B0-0x0000000189B7D440
		public void SaveLayerStack(Scene scene, string[] layerStack) {} // 0x0000000189B7CECC-0x0000000189B7D078
		public void SaveToLayer() {} // 0x0000000189B7D078-0x0000000189B7D3B0
	}

	public class UsdModelRoot : MonoBehaviour // TypeDefIndex: 56585
	{
		// Fields
		public string m_modelName; // 0x18
		public string m_modelVersion; // 0x20
		public string m_modelAssetPath; // 0x28
	
		// Constructors
		public UsdModelRoot() {} // 0x000000018426FE60-0x000000018426FE68
	}

	[ExecuteInEditMode]
	public class UsdPayload : MonoBehaviour // TypeDefIndex: 56586
	{
		// Fields
		[SerializeField]
		private bool m_isLoaded; // 0x18
		[HideInInspector]
		[SerializeField]
		private bool m_wasLoaded; // 0x19
	
		// Properties
		public bool IsLoaded { get => default; } // 0x0000000181002A50-0x0000000181002A60 
	
		// Constructors
		public UsdPayload() {} // 0x0000000189B7D4CC-0x0000000189B7D4DC
	
		// Methods
		public void Load() {} // 0x0000000183D587A0-0x0000000183D587B0
		public void Unload() {} // 0x0000000183D566B0-0x0000000183D566C0
		public void SetInitialState(bool loaded) {} // 0x0000000183D76A40-0x0000000183D76A50
		public void Update() {} // 0x0000000189B7D440-0x0000000189B7D4CC
	}

	public class UsdPrimSource : MonoBehaviour // TypeDefIndex: 56587
	{
		// Fields
		public string m_usdPrimPath; // 0x18
	
		// Constructors
		public UsdPrimSource() {} // 0x000000018426FE60-0x000000018426FE68
	}

	public class UsdVariantSet : MonoBehaviour // TypeDefIndex: 56589
	{
		// Fields
		public string[] m_variantSetNames; // 0x18
		public string[] m_selected; // 0x20
		public string[] m_variants; // 0x28
		public int[] m_variantCounts; // 0x30
		public string m_primPath; // 0x38
	
		// Constructors
		public UsdVariantSet() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		public void LoadFromUsd(UsdPrim prim) {} // 0x0000000189B7D644-0x0000000189B7D8CC
		public void ApplyVariantSelections() {} // 0x0000000189B7D4DC-0x0000000189B7D574
		public Dictionary<string, string> GetVariantSelections() => default; // 0x0000000189B7D574-0x0000000189B7D644
	}

	[ExecuteInEditMode]
	public class SkinnedMeshUnityDiff : MonoBehaviour // TypeDefIndex: 56590
	{
		// Fields
		[Tooltip("The USD skinned mesh to compare")]
		public SkinnedMeshRenderer m_usdMesh; // 0x18
		[Tooltip("The Unity skinned mesh to compare")]
		public SkinnedMeshRenderer m_unityMesh; // 0x20
	
		// Constructors
		public SkinnedMeshUnityDiff() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnEnable() {} // 0x0000000189B75208-0x0000000189B761DC
		private bool Approximately(Matrix4x4 rhs, Matrix4x4 lhs) => default; // 0x0000000189B75170-0x0000000189B751DC
		private bool WeightsMatch(BoneWeight w1, BoneWeight w2) => default; // 0x0000000189B761DC-0x0000000189B76244
		private bool IndicesMatch(BoneWeight w1, BoneWeight w2) => default; // 0x0000000189B751DC-0x0000000189B75208
		private void Update() {} // 0x000000018350B670-0x000000018350B680
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class SkinnedMeshUsdDiff : MonoBehaviour // TypeDefIndex: 56591
	{
		// Fields
		[Tooltip("A path to a USD file for comparing weights")]
		public string m_usdFile; // 0x18
		[Tooltip("A prim path to the skinned mesh in the USD file")]
		public string m_usdMeshPath; // 0x20
		[Tooltip("How to convert transforms for comparison")]
		public BasisTransformation m_basisTransform; // 0x28
	
		// Constructors
		public SkinnedMeshUsdDiff() {} // 0x000000018426FE60-0x000000018426FE68
	
		// Methods
		private void OnEnable() {} // 0x0000000189B763E8-0x0000000189B77384
		private string GetUsdBoneData<T>(int bone, int weightIndex, Primvar<T[]> primvar) => default;
		private Scene GetScene() => default; // 0x0000000189B76244-0x0000000189B763E8
		private SkelBindingSample ReadUsdWeights(Scene scene) => default; // 0x0000000189B777A0-0x0000000189B778BC
		private SkeletonSample ReadUsdSkeleton(Scene scene, out string skelRootPath) {
			skelRootPath = default;
			return default;
		} // 0x0000000189B77384-0x0000000189B777A0
		private void Update() {} // 0x000000018350B670-0x000000018350B680
	}

	public static class CameraExporter // TypeDefIndex: 56592
	{
		// Methods
		public static void ExportCamera(ObjectContext objContext, ExportContext exportContext) {} // 0x0000000189B693EC-0x0000000189B696B4
	}

	public static class CameraImporter // TypeDefIndex: 56593
	{
		// Methods
		public static void BuildCamera(CameraSample usdCamera, GameObject go, SceneImportOptions options) {} // 0x0000000189B696B4-0x0000000189B69770
	}

	public static class CubeImporter // TypeDefIndex: 56594
	{
		// Methods
		public static void BuildCube(CubeSample usdCube, GameObject go, SceneImportOptions options, bool skinnedMesh = false /* Metadata: 0x01FD8128 */) {} // 0x0000000189B69770-0x0000000189B6B244
		private static bool ShouldImport(ImportMode mode) => default; // 0x00000001894C2728-0x00000001894C2738
		private static bool ShouldCompute(ImportMode mode) => default; // 0x0000000185A36584-0x0000000185A36594
	}

	public static class InstanceImporter // TypeDefIndex: 56595
	{
		// Methods
		public static void BuildSceneInstances(PrimMap primMap, SceneImportOptions options) {} // 0x0000000189B6DB58-0x0000000189B6E150
		public static void BuildPointInstances(Scene scene, PrimMap primMap, string pointInstancerPath, PointInstancerSample sample, GameObject root, SceneImportOptions options) {} // 0x0000000189B6D4C4-0x0000000189B6DB58
		private static void EnableGpuInstancing(GameObject go) {} // 0x0000000189B6E150-0x0000000189B6E3A8
	}

	public static class MeshExporter // TypeDefIndex: 56596
	{
		// Fields
		private static TfToken m_materialBindToken; // 0x00
		private static TfToken m_subMeshesToken; // 0x08
	
		// Constructors
		static MeshExporter() {} // 0x0000000189B72918-0x0000000189B72A08
	
		// Methods
		public static void ExportSkinnedMesh(ObjectContext objContext, ExportContext exportContext) {} // 0x0000000189B72618-0x0000000189B72918
		private static void ExportSkelWeights(Scene scene, string path, Mesh unityMesh, Transform rootBone, Transform[] bones, string skeletonPath) {} // 0x0000000189B720C4-0x0000000189B72618
		public static void ExportMesh(ObjectContext objContext, ExportContext exportContext) {} // 0x0000000189B71F94-0x0000000189B720C4
		private static void ExportMesh(ObjectContext objContext, ExportContext exportContext, Mesh mesh, Material sharedMaterial, Material[] sharedMaterials, bool exportMeshPose = true /* Metadata: 0x01FD8129 */) {} // 0x0000000189B70B18-0x0000000189B71F94
	}

	public delegate void MeshImportFunction<T>(string path, T sample, MeshImporter.GeometrySubsets subsets, GameObject go, SceneImportOptions option, bool isDynamic, UsdSkelSkinningQuery query = null); // TypeDefIndex: 56597; 0x00000000-0x00000000

	public class MeshImportStrategy : IImporter // TypeDefIndex: 56599
	{
		// Fields
		private MeshImportFunction<SanitizedMeshSample> m_meshImporter; // 0x10
		private MeshImportFunction<SanitizedMeshSample> m_skinnedMeshImporter; // 0x18
		private ReadAllJob<SanitizedMeshSample> m_readMeshesJob; // 0x20
	
		// Constructors
		public MeshImportStrategy() {} // Dummy constructor
		public MeshImportStrategy(MeshImportFunction<SanitizedMeshSample> meshImporter, MeshImportFunction<SanitizedMeshSample> skinnedMeshImporter) {} // 0x0000000182676770-0x00000001826767A0
	
		// Methods
		public void BeginReading(Scene scene, PrimMap primMap, SceneImportOptions importOptions) {} // 0x0000000189B72A08-0x0000000189B72AD4
		[IteratorStateMachine(typeof(_Import_d__5))]
		public IEnumerator Import(Scene scene, PrimMap primMap, SceneImportOptions importOptions) => default; // 0x0000000189B72AD4-0x0000000189B72B7C
	}

	public static class MeshImporter // TypeDefIndex: 56603
	{
		// Nested types
		public class GeometrySubsets // TypeDefIndex: 56600
		{
			// Properties
			public Dictionary<string, int[]> Subsets { get; set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
			// Constructors
			public GeometrySubsets() {} // 0x0000000189B6B244-0x0000000189B6B2BC
		}
	
		// Methods
		public static GeometrySubsets ReadGeomSubsets(Scene scene, string path) => default; // 0x0000000189B74D18-0x0000000189B750C0
		public static void BuildSkinnedMesh(string path, SanitizedMeshSample usdMesh, GeometrySubsets geomSubsets, GameObject go, SceneImportOptions options, bool isDynamic, UsdSkelSkinningQuery skinningQuery = null) {} // 0x0000000189B740F0-0x0000000189B742B0
		public static void ImportSkinning(string path, SanitizedMeshSample usdMesh, Mesh unityMesh, UsdSkelSkinningQuery skinningQuery) {} // 0x0000000189B742B0-0x0000000189B748C8
		public static void BuildMesh(string path, SanitizedMeshSample usdMesh, GeometrySubsets geomSubsets, GameObject go, SceneImportOptions options, bool isDynamic, UsdSkelSkinningQuery skinQuery = null) {} // 0x0000000189B73F38-0x0000000189B740F0
		private static void BuildMesh_(string path, SanitizedMeshSample usdMesh, Mesh unityMesh, GeometrySubsets geomSubsets, GameObject go, Renderer renderer, SceneImportOptions options) {} // 0x0000000189B72C70-0x0000000189B73F38
		private static void LoadPrimvars(Mesh unityMesh, string usdMeshPath, List<string> primvars, MeshSample sample) {} // 0x0000000189B74A80-0x0000000189B74D18
		private static void BindMat(Mesh unityMesh, Material mat, Renderer renderer, string usdMeshPath, List<string> primvars, MeshSample sample) {} // 0x0000000189B72C20-0x0000000189B72C70
		private static void BindMat(Mesh unityMesh, Material mat, Renderer renderer, int index, string usdMeshPath, List<string> primvars, MeshSample sample) {} // 0x0000000189B72B7C-0x0000000189B72C20
		private static T[] TryGetPrimvarValue<T>(Primvar<object> primvar) => default;
		private static void ImportUv(Mesh unityMesh, int uvSetIndex, Primvar<object> uv) {} // 0x0000000189B748C8-0x0000000189B74A80
		public static bool ShouldImport(ImportMode mode) => default; // 0x00000001894C2728-0x00000001894C2738
		public static bool ShouldCompute(ImportMode mode) => default; // 0x0000000185A36584-0x0000000185A36594
		private static string UniqueMeshName(string meshName) => default; // 0x0000000189B750C0-0x0000000189B75170
	}

	public enum ImportMode // TypeDefIndex: 56604
	{
		Import = 0,
		ImportOrCompute = 1,
		Compute = 2,
		Ignore = 3
	}

	[Serializable]
	public class MeshImportOptions // TypeDefIndex: 56605
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
		public MeshImportOptions() {} // 0x0000000183D76A00-0x0000000183D76A40
	}

	public static class SphereImporter // TypeDefIndex: 56606
	{
		// Methods
		public static void BuildSphere(SphereSample usdSphere, GameObject go, SceneImportOptions options, bool skinnedMesh = false /* Metadata: 0x01FD812E */) {} // 0x0000000189B778BC-0x0000000189B77EE4
		private static bool ShouldImport(ImportMode mode) => default; // 0x00000001894C2728-0x00000001894C2738
		private static bool ShouldCompute(ImportMode mode) => default; // 0x0000000185A36584-0x0000000185A36594
	}

	public static class XformExporter // TypeDefIndex: 56607
	{
		// Methods
		public static void ExportXform(ObjectContext objContext, ExportContext exportContext) {} // 0x0000000189B7D8CC-0x0000000189B7DB58
		public static void WriteSparseOverrides(Scene scene, PrimMap primMap, BasisTransformation changeHandedness, float tolerance = 0.0001f /* Metadata: 0x01FD812F */) {} // 0x0000000189B7DE28-0x0000000189B7E150
		public static Matrix4x4 GetLocalTransformMatrix(Transform tr, bool correctZUp, bool isRootPrim, BasisTransformation conversionType) => default; // 0x0000000189B7DB58-0x0000000189B7DE28
	}

	public static class XformImporter // TypeDefIndex: 56608
	{
		// Methods
		public static void BuildXform(SdfPath path, XformableSample usdXf, GameObject go, SceneImportOptions options, Scene scene) {} // 0x0000000189B7E690-0x0000000189B7E810
		public static void BuildXform(Matrix4x4 xf, GameObject go, SceneImportOptions options) {} // 0x0000000189B7E4F0-0x0000000189B7E690
		public static void ImportXform(ref Matrix4x4 mat, SceneImportOptions options) {} // 0x0000000189B7E810-0x0000000189B7E8F8
		public static void BuildSceneRoot(Scene scene, Transform root, SceneImportOptions options) {} // 0x0000000189B7E150-0x0000000189B7E4F0
		public static void UndoRootTransform(Scene scene, UsdAsset stageRoot, ref Vector3 localScale, ref Quaternion localRotation) {} // 0x0000000189B7E8F8-0x0000000189B7EBE4
	}

	public static class ImporterBase // TypeDefIndex: 56609
	{
		// Methods
		public static string MakeRelativePath(string anchorPath, string pathToMakeRelative) => default; // 0x0000000189B6D010-0x0000000189B6D2AC
		public static bool ApproximatelyEqual(Matrix4x4 lhs, Matrix4x4 rhs) => default; // 0x0000000189B6CFA8-0x0000000189B6D010
		public static void MoveComponentFirst(UnityEngine.Component comp) {} // 0x0000000189B6D2AC-0x0000000189B6D300
		public static void MoveComponentLast(UnityEngine.Component comp) {} // 0x0000000189B6D300-0x0000000189B6D354
		public static T GetOrAddComponent<T>(GameObject go, bool insertFirst = false /* Metadata: 0x01FD8133 */)
			where T : UnityEngine.Component => default;
		public static string SafeGetDirectoryName(string fullPath) => default; // 0x0000000189B6D354-0x0000000189B6D4C4
	}

	public class HdrpShaderExporter : ShaderExporterBase // TypeDefIndex: 56610
	{
		// Constructors
		public HdrpShaderExporter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void ExportLit(Scene scene, string usdShaderPath, Material material, PreviewSurfaceSample surface, string destTexturePath) {} // 0x0000000189B6B2BC-0x0000000189B6C274
	}

	public class HdrpShaderImporter : ShaderImporterBase // TypeDefIndex: 56611
	{
		// Fields
		private static Material ChannelCombinerMat; // 0x00
	
		// Constructors
		public HdrpShaderImporter() {} // Dummy constructor
		public HdrpShaderImporter(Material material) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void ImportFromUsd() {} // 0x0000000189B6C980-0x0000000189B6CFA8
		private static Texture2D BuildMaskMap(Texture2D red, Texture2D green, Texture2D blue, Texture2D alpha) => default; // 0x0000000189B6C274-0x0000000189B6C980
	}

	public static class MaterialExporter // TypeDefIndex: 56613
	{
		// Fields
		public static readonly string kStandardFallbackHandler; // 0x00
		public static readonly string kHdrpFallbackHandler; // 0x08
		public static readonly string kLwrpFallbackHandler; // 0x10
		public static Dictionary<string, ExportHandler> ExportRegistry; // 0x18
	
		// Nested types
		public delegate void ExportHandler(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // TypeDefIndex: 56612; 0x0000000181028930-0x0000000181028950
	
		// Constructors
		static MaterialExporter() {} // 0x0000000189B6E8C8-0x0000000189B6EF70
	
		// Methods
		public static void ExportMaterial(Scene scene, Material mat, string usdMaterialPath) {} // 0x0000000189B6E3A8-0x0000000189B6E8C8
	}

	public static class MaterialImporter // TypeDefIndex: 56615
	{
		// Fields
		private static readonly TfToken materialBindToken; // 0x00
		private static Material AlbedoGlossCombiner; // 0x08
		public static TextureResolver OnResolveTexture; // 0x10
	
		// Nested types
		public delegate Texture2D TextureResolver(SdfAssetPath textureAssetPath, bool isNormalMap, SceneImportOptions importOptions); // TypeDefIndex: 56614; 0x0000000181035ED0-0x0000000181035EF0
	
		// Constructors
		static MaterialImporter() {} // 0x0000000189B70A88-0x0000000189B70B18
	
		// Methods
		public static void ProcessMaterialBindings(Scene scene, SceneImportOptions importOptions) {} // 0x0000000189B70574-0x0000000189B70A88
		public static Material BuildMaterial(Scene scene, string materialPath, MaterialSample sample, SceneImportOptions options) => default; // 0x0000000189B6EF70-0x0000000189B70058
		public static Texture2D ImportConnectedTexture<T>(Scene scene, Connectable<T> connection, bool isNormalMap, SceneImportOptions options, out string uvPrimvar) {
			uvPrimvar = default;
			return default;
		}
		private static Texture2D DefaultTextureResolver(SdfAssetPath textureAssetPath, bool isNormalMap, SceneImportOptions options) => default; // 0x0000000181002730-0x0000000181002740
		public static Texture2D CombineRoughness(Texture2D rgbTex, Texture2D roughnessTex, string fileNameSuffix) => default; // 0x0000000189B70058-0x0000000189B70358
		public static UnityPreviewSurfaceSample GetSurfaceShaderPrim(Scene scene, string primPath) => default; // 0x0000000189B70358-0x0000000189B70574
	}

	public class MaterialMap : IEnumerable<KeyValuePair<string, Material>> // TypeDefIndex: 56617
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
		public Material DisplayColorMaterial { get => default; set {} } // 0x0000000189B83FDC-0x0000000189B84040 0x000000018388FF30-0x000000018388FF40
		public Material SpecularWorkflowMaterial { get => default; set {} } // 0x0000000189B84110-0x0000000189B84174 0x0000000183CB2D80-0x0000000183CB2D90
		public Material MetallicWorkflowMaterial { get => default; set {} } // 0x0000000189B840AC-0x0000000189B84110 0x0000000182692290-0x00000001826922A0
		public Material this[string path] { get => default; set {} } // 0x0000000189B84040-0x0000000189B840AC 0x0000000189B84174-0x0000000189B841D8
	
		// Nested types
		public delegate void MaterialBinder(Scene scene, Material mat, List<string> uvPrimvars); // TypeDefIndex: 56616; 0x00000001811360D0-0x00000001811360F0
	
		// Constructors
		public MaterialMap() {} // 0x0000000189B83E84-0x0000000189B83FDC
	
		// Methods
		private void InstantiateMaterials() {} // 0x0000000189B83A4C-0x0000000189B83C1C
		public Dictionary<string, MaterialBinder> ClearRequestedBindings() => default; // 0x0000000189B83914-0x0000000189B8399C
		public void RequestBinding(string usdPath, MaterialBinder binder) {} // 0x0000000189B83D34-0x0000000189B83D98
		public List<string> GetPrimvars(string materialPath) => default; // 0x0000000189B839E4-0x0000000189B83A4C
		public void SetPrimvars(string materialPath, List<string> primvars) {} // 0x0000000189B83D98-0x0000000189B83DFC
		public Material InstantiateSolidColor(UnityEngine.Color color) => default; // 0x0000000189B83C1C-0x0000000189B83D34
		public static void AssignColor(Material material, UnityEngine.Color color) {} // 0x0000000189B83860-0x0000000189B83914
		public IEnumerator GetEnumerator() => default; // 0x0000000189B8399C-0x0000000189B839E4
		IEnumerator<KeyValuePair<string, Material>> IEnumerable<KeyValuePair<string, Material>>.GetEnumerator() => default; // 0x0000000189B83DFC-0x0000000189B83E84
	}

	public class ShaderExporterBase // TypeDefIndex: 56619
	{
		// Fields
		private static Material _metalGlossChannelSwapMaterial; // 0x00
		private static Material _normalChannelMaterial; // 0x08
	
		// Nested types
		public enum ConversionType // TypeDefIndex: 56618
		{
			None = 0,
			SwapRASmoothnessToBGRoughness = 1,
			InvertAlpha = 2,
			UnpackNormal = 3,
			MaskMapToORM = 4,
			RemoveAlpha = 5
		}
	
		// Constructors
		public ShaderExporterBase() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		protected static string SetupTexture(Scene scene, string usdShaderPath, Material material, PreviewSurfaceSample surface, Vector4 scale, string destTexturePath, string textureName, string textureOutput, ConversionType conversionType = ConversionType.None /* Metadata: 0x01FD8134 */) => default; // 0x0000000189B8BF50-0x0000000189B8D748
	}

	public abstract class ShaderImporterBase // TypeDefIndex: 56621
	{
		// Fields
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
		public Material Material { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
		public bool IsSpecularWorkflow { get; private set; } // 0x0000000181002A50-0x0000000181002A60 0x0000000181002B40-0x0000000181002B50
	
		// Constructors
		protected ShaderImporterBase() {} // Dummy constructor
		public ShaderImporterBase(Material material) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public abstract void ImportFromUsd();
		protected void ImportColorOrMap(Scene scene, Connectable<Vector3> usdParam, bool isNormalMap, SceneImportOptions options, ref Texture2D map, ref UnityEngine.Color? value, out string uvPrimvar) {
			uvPrimvar = default;
		} // 0x0000000189B8D748-0x0000000189B8D8A0
		protected void ImportValueOrMap<T>(Scene scene, Connectable<T> usdParam, bool isNormalMap, SceneImportOptions options, ref Texture2D map, ref T? value, out string uvPrimvar)
			where T : struct {
			uvPrimvar = default;
		}
		private void MergePrimvars(string newPrimvar, List<string> primvars) {} // 0x0000000189B8DD28-0x0000000189B8DE30
		public virtual void ImportParametersFromUsd(Scene scene, string materialPath, MaterialSample materialSample, PreviewSurfaceSample previewSurf, SceneImportOptions options) {} // 0x0000000189B8D8A0-0x0000000189B8DD28
	}

	public class StandardShaderExporter : ShaderExporterBase // TypeDefIndex: 56623
	{
		// Nested types
		private enum StandardShaderBlendMode // TypeDefIndex: 56622
		{
			Opaque = 0,
			Cutout = 1,
			Fade = 2,
			Transparent = 3
		}
	
		// Constructors
		public StandardShaderExporter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void ExportStandardSpecular(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath) {} // 0x0000000189B8F300-0x0000000189B8F5FC
		public static void ExportStandardRoughness(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath) {} // 0x0000000189B8EEC4-0x0000000189B8F300
		public static void ExportStandard(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath) {} // 0x0000000189B8F5FC-0x0000000189B8F930
		public static void ExportGeneric(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath) {} // 0x0000000189B8DE30-0x0000000189B8E4B0
		private static void ExportStandardCommon(Scene scene, string usdShaderPath, Material mat, UnityPreviewSurfaceSample surface, string destTexturePath) {} // 0x0000000189B8E4B0-0x0000000189B8EEC4
		private static bool ShouldUseSpecularWorkflow(Material material) => default; // 0x0000000189B8F930-0x0000000189B8FA64
	}

	public class StandardShaderImporter : ShaderImporterBase // TypeDefIndex: 56624
	{
		// Constructors
		public StandardShaderImporter() {} // Dummy constructor
		public StandardShaderImporter(Material material) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void ImportFromUsd() {} // 0x0000000189B8FA64-0x0000000189B901D8
	}

	public class UnityMaterialData : SampleBase // TypeDefIndex: 56625
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
		public UnityMaterialData() {} // 0x0000000189B971CC-0x0000000189B972D8
	}

	public class UnityPreviewSurfaceSample : PreviewSurfaceSample // TypeDefIndex: 56626
	{
		// Fields
		[UsdNamespace("unity")]
		public UnityMaterialData unity; // 0x90
	
		// Constructors
		public UnityPreviewSurfaceSample() {} // 0x0000000189B972D8-0x0000000189B9734C
	}

	public class UrpShaderImporter : ShaderImporterBase // TypeDefIndex: 56627
	{
		// Constructors
		public UrpShaderImporter() {} // Dummy constructor
		public UrpShaderImporter(Material material) {} // 0x000000018426FEE0-0x000000018426FEF0
	
		// Methods
		public override void ImportFromUsd() {} // 0x0000000189B9734C-0x0000000189B97AC0
	}

	public struct ReadAllJob<T> : IEnumerator<SampleEnumerator<T>>, IEnumerable<SampleEnumerator<T>>, IJobParallelFor // TypeDefIndex: 56628
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
		public SampleEnumerator<T> Current { get => default; }
		object IEnumerator.Current { get => default; }
	
		// Constructors
		public ReadAllJob(Scene scene, SdfPath[] paths, SceneImportOptions importOptions) : this() {
	
		}
	
		// Methods
		private bool ShouldReadPath(Scene scene, SdfPath path) => default;
		public void Run() {}
		public void Execute(int index) {}
		private static void AddPrimvarsFromMaterial(int index, ref IArbitraryPrimvars sample) {}
		public bool MoveNext() => default;
		public void Reset() {}
		public void Dispose() {}
		public IEnumerator<SampleEnumerator<T>> GetEnumerator() => default;
		IEnumerator IEnumerable.GetEnumerator() => default;
	}

	public interface IRestorable // TypeDefIndex: 56629
	{
		// Methods
		bool IsRestoredFromCachedData();
		void FromCachedData(IRestorableData data);
		IRestorableData ToCachedData();
	}

	public interface ISanitizable // TypeDefIndex: 56630
	{
		// Methods
		void Sanitize(Scene scene, SceneImportOptions importOptions);
	}

	public class MeshStaticPropertiesData : IRestorableData // TypeDefIndex: 56631
	{
		// Fields
		internal int[] originalFaceVertexCounts; // 0x10
		internal int[] originalFaceVertexIndices; // 0x18
		internal bool arePrimvarsFaceVarying; // 0x20
		internal Orientation orientation; // 0x24
	
		// Constructors
		public MeshStaticPropertiesData() {} // 0x000000018350B670-0x000000018350B680
	}

	public class SanitizedXformSample : XformSample, ISanitizable // TypeDefIndex: 56632
	{
		// Constructors
		public SanitizedXformSample() {} // 0x0000000189B85118-0x0000000189B85120
	
		// Methods
		public void Sanitize(Scene scene, SceneImportOptions importOptions) {} // 0x0000000189B850F0-0x0000000189B85118
	}

	public class SanitizedCameraSample : CameraSample, ISanitizable // TypeDefIndex: 56633
	{
		// Constructors
		public SanitizedCameraSample() {} // 0x0000000189B85118-0x0000000189B85120
	
		// Methods
		public void Sanitize(Scene scene, SceneImportOptions importOptions) {} // 0x0000000189B850F0-0x0000000189B85118
	}

	public class SanitizedMeshSample : MeshSample, ISanitizable, IRestorable // TypeDefIndex: 56634
	{
		// Fields
		internal int[] originalFaceVertexCounts; // 0xC0
		internal int[] originalFaceVertexIndices; // 0xC8
		internal bool arePrimvarsFaceVarying; // 0xD0
		internal int[] faceMapping; // 0xD8
		internal int[] triangulatedFaceVertexIndices; // 0xE0
		private bool isRestoredFromCachedData; // 0xE8
	
		// Constructors
		public SanitizedMeshSample() {} // 0x0000000189B8704C-0x0000000189B87054
	
		// Methods
		public bool IsRestoredFromCachedData() => default; // 0x0000000183D554A0-0x0000000183D554B0
		public void FromCachedData(IRestorableData restorableData) {} // 0x0000000189B858A0-0x0000000189B8594C
		public IRestorableData ToCachedData() => default; // 0x0000000189B867A8-0x0000000189B86830
		public void BackupTopology() {} // 0x0000000189B85294-0x0000000189B8539C
		public bool IsTopologyBackedUp() => default; // 0x0000000189B85C44-0x0000000189B85C60
		public void Sanitize(Scene scene, SceneImportOptions importOptions) {} // 0x0000000189B85C60-0x0000000189B865CC
		internal void Triangulate(bool changeHandedness) {} // 0x0000000189B86830-0x0000000189B86C94
		internal bool ShouldUnweldVertices(bool bindMaterials) => default; // 0x0000000189B865CC-0x0000000189B86790
		internal bool AreAnyArbitraryPrimvarsFaceVarying() => default; // 0x0000000189B85120-0x0000000189B85294
		internal static void Flatten<T>(ref ref T[] values, int[] indices) {}
		private void UnweldPrimvar(Primvar<object> primvar, bool changeHandedness) {} // 0x0000000189B86C94-0x0000000189B8704C
		private static void FlattenPrimvar(Primvar<object> primvar) {} // 0x0000000189B8569C-0x0000000189B858A0
		internal static void TriangulateAttributes<T>(ref ref T[] values, int[] faceVertexCounts, bool changeHandedness) {}
		private void ConvertInterpolationToFaceVarying<T>(ref ref T[] values, int[] vertexIndices, bool changeHandedness = false /* Metadata: 0x01FD813F */, TfToken interpolation = null) {}
		internal TfToken GuessInterpolation(int count) => default; // 0x0000000189B8594C-0x0000000189B85AA4
		internal bool IsInterpolationValid(TfToken interpolation, int count) => default; // 0x0000000189B85AA4-0x0000000189B85C44
		internal void UniformToFaceVarying<T>(ref ref T[] values, int vertexCount) {}
		private static void ComputeNormals(Vector3[] points, int[] faceVertexIndices, ref Vector3[] normals) {} // 0x0000000189B8539C-0x0000000189B8569C
		internal bool ShouldUnwindVertices(bool changeHandedness) => default; // 0x0000000189B86790-0x0000000189B867A8
	}

	public static class ExportHelpers // TypeDefIndex: 56635
	{
		// Methods
		public static Scene InitForSave(string filePath) => default; // 0x0000000189B7F29C-0x0000000189B7F3F4
		public static void ExportGameObjects(GameObject[] objects, Scene scene, BasisTransformation basisTransform, bool exportMonoBehaviours = false /* Metadata: 0x01FD8140 */) {} // 0x0000000189B7F02C-0x0000000189B7F29C
	}

	public static class HierarchyBuilder // TypeDefIndex: 56642
	{
		// Fields
		private static readonly SdfPath kAbsoluteRootPath; // 0x00
	
		// Nested types
		private struct HierInfo // TypeDefIndex: 56636
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
	
		private struct ReadHierJob : IJobParallelFor // TypeDefIndex: 56637
		{
			// Fields
			public static HierInfo[] result; // 0x00
			public static Scene scene; // 0x08
			public static UsdSkelCache skelCache; // 0x10
			public static SdfPath[] paths; // 0x18
	
			// Methods
			public void Run() {} // 0x0000000189B85084-0x0000000189B850F0
			public void Execute(int index) {} // 0x0000000189B84E98-0x0000000189B85084
		}
	
		private struct FindPathsJob : IJobParallelFor // TypeDefIndex: 56640
		{
			// Fields
			public static SdfPath usdRoot; // 0x00
			public static Scene scene; // 0x08
			public static SdfPath[][] results; // 0x10
			public static IQuery[] queries; // 0x18
	
			// Nested types
			public interface IQuery // TypeDefIndex: 56638
			{
				// Methods
				SdfPath[] Find(Scene scene, SdfPath usdRoot);
			}
	
			public struct Query<T> : IQuery // TypeDefIndex: 56639
				where T : SampleBase, new()
			{
				// Methods
				public SdfPath[] Find(Scene scene, SdfPath usdRoot) => default;
			}
	
			// Methods
			public void Run() {} // 0x0000000189B7F51C-0x0000000189B7F588
			public void Execute(int index) {} // 0x0000000189B7F46C-0x0000000189B7F51C
		}
	
		// Constructors
		static HierarchyBuilder() {} // 0x0000000189B8305C-0x0000000189B830AC
	
		// Methods
		private static JobHandle BeginReading(Scene scene, SdfPath usdRoot, PrimMap map, SceneImportOptions options) => default; // 0x0000000189B7FA50-0x0000000189B80428
		private static HierInfo[] BuildObjectLists(Scene scene, GameObject unityRoot, SdfPath usdRoot, PrimMap map, SceneImportOptions options) => default; // 0x0000000189B81310-0x0000000189B814A4
		public static PrimMap BuildGameObjects(Scene scene, GameObject unityRoot, SdfPath usdRoot, IEnumerable<SdfPath> paths, PrimMap map, SceneImportOptions options) => default; // 0x0000000189B80428-0x0000000189B81310
		private static bool IsVisible(UsdPrim usdPrim) => default; // 0x0000000189B81DDC-0x0000000189B81F24
		private static void ApplySelfVisibility(GameObject go, UsdPrim usdPrim) {} // 0x0000000189B7F9C0-0x0000000189B7FA50
		private static void CreateAncestors(SdfPath path, PrimMap map, GameObject unityRoot, SdfPath usdRoot, SceneImportOptions options, out GameObject parentGo) {
			parentGo = default;
		} // 0x0000000189B814A4-0x0000000189B817F0
		private static void ProcessPaths(HierInfo[] infos, Scene scene, GameObject unityRoot, SdfPath usdRoot, PrimMap map, SceneImportOptions options) {} // 0x0000000189B821A8-0x0000000189B82744
		private static void PopulateSkelCache(ref HierInfo skelRootInfo, UsdSkelCache skelCache) {} // 0x0000000189B81F24-0x0000000189B821A8
		private static void ReadSkeletonJoints(ref HierInfo skelRootInfo) {} // 0x0000000189B82A3C-0x0000000189B8305C
		private static void ExpandSkeleton(HierInfo info, GameObject unityRoot, SdfPath usdRoot, UsdPrim prim, PrimMap map, SceneImportOptions options) {} // 0x0000000189B817F0-0x0000000189B81B3C
		private static void ReadModelInfo(ref HierInfo info) {} // 0x0000000189B82744-0x0000000189B82A3C
		private static void AddModelRoot(GameObject go, HierInfo info) {} // 0x0000000189B7F588-0x0000000189B7F798
		private static void AddPayload(GameObject go, HierInfo info, SceneImportOptions options) {} // 0x0000000189B7F798-0x0000000189B7F890
		private static void AddVariantSet(GameObject go, UsdPrim prim) {} // 0x0000000189B7F890-0x0000000189B7F9C0
		private static GameObject FindOrCreateGameObject(Transform parent, SdfPath path, Transform unityRoot, PrimMap primMap, SceneImportOptions options) => default; // 0x0000000189B81B3C-0x0000000189B81DDC
	}

	public static class ImportHelpers // TypeDefIndex: 56643
	{
		// Methods
		public static GameObject ImportSceneAsGameObject(Scene scene, GameObject parent = null, SceneImportOptions importOptions = null) => default; // 0x0000000189B83384-0x0000000189B835EC
		public static Scene InitForOpen(string path = "" /* Metadata: 0x01FD8141 */, UsdStage.InitialLoadSet loadSet = UsdStage.InitialLoadSet.LoadNone /* Metadata: 0x01FD8142 */) => default; // 0x0000000189B835EC-0x0000000189B83660
		private static SdfPath GetDefaultRoot(Scene scene) => default; // 0x0000000189B831B4-0x0000000189B83268
		private static GameObject UsdToGameObject(GameObject parent, Scene scene, SceneImportOptions importOptions) => default; // 0x0000000189B83660-0x0000000189B83860
		private static string GetObjectName(SdfPath rootPrimName, string path) => default; // 0x0000000189B83268-0x0000000189B832F0
		private static string GetObjectName(string path) => default; // 0x0000000189B832F0-0x0000000189B8333C
		private static string GetPrefabName(string path) => default; // 0x0000000189B8333C-0x0000000189B83384
	}

	public interface IImportProcessUsd // TypeDefIndex: 56644
	{
		// Methods
		void ProcessUsd(Scene scene, SceneImportOptions sceneImportOptions);
	}

	public interface IImportPostProcessHierarchy // TypeDefIndex: 56645
	{
		// Methods
		void PostProcessHierarchy(PrimMap primMap, SceneImportOptions sceneImportOptions);
	}

	public interface IImportPostProcessComponents // TypeDefIndex: 56646
	{
		// Methods
		void PostProcessComponents(PrimMap primMap, SceneImportOptions sceneImportOptions);
	}

	public class PrimMap : IEnumerable<KeyValuePair<SdfPath, GameObject>> // TypeDefIndex: 56648
	{
		// Fields
		public UsdSkelCache SkelCache; // 0x10
		public Dictionary<SdfPath, UsdSkelBindingVector> SkelBindings; // 0x18
		public Dictionary<SdfPath, UsdSkelSkinningQuery> SkinningQueries; // 0x20
		public Dictionary<SdfPath, MeshImporter.GeometrySubsets> MeshSubsets; // 0x28
		private Dictionary<SdfPath, GameObject> m_prims; // 0x78
		private Dictionary<SdfPath, InstanceRoot> m_instanceRoots; // 0x80
		private HashSet<GameObject> m_instances; // 0x88
		private Dictionary<SdfPath, GameObject> m_masterRoots; // 0x90
	
		// Properties
		public SdfPath[] Cameras { get; set; } // 0x0000000181003830-0x0000000181003840 0x0000000184270470-0x0000000184270480
		public SdfPath[] Meshes { get; set; } // 0x0000000183D4E2A0-0x0000000183D4E2B0 0x000000018388FF30-0x000000018388FF40
		public SdfPath[] Cubes { get; set; } // 0x0000000183D4E2B0-0x0000000183D4E2C0 0x0000000183CB2D80-0x0000000183CB2D90
		public SdfPath[] Spheres { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public SdfPath[] Xforms { get; set; } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public SdfPath[] SkelRoots { get; set; } // 0x0000000183D4EAA0-0x0000000183D4EAB0 0x0000000183081D30-0x0000000183081D40
		public SdfPath[] Skeletons { get; set; } // 0x0000000183D4EB00-0x0000000183D4EB10 0x00000001839274B0-0x00000001839274C0
		public SdfPath[] Materials { get; set; } // 0x0000000183D4EAB0-0x0000000183D4EAC0 0x00000001838C5570-0x00000001838C5580
		public bool ContainsPointInstances { get; set; } // 0x0000000183D4F260-0x0000000183D4F270 0x0000000183D4F290-0x0000000183D4F2A0
		public bool HasErrors { get; set; } // 0x0000000183D51CF0-0x0000000183D51D00 0x0000000183D51D00-0x0000000183D51D10
		public GameObject this[SdfPath path] { get => default; set {} } // 0x0000000189B84D48-0x0000000189B84E34 0x0000000189B84E34-0x0000000189B84E98
	
		// Nested types
		public struct InstanceRoot // TypeDefIndex: 56647
		{
			// Fields
			public GameObject gameObject; // 0x00
			public SdfPath masterPath; // 0x08
		}
	
		// Constructors
		public PrimMap() {} // 0x0000000189B84B5C-0x0000000189B84D48
	
		// Methods
		public bool TryGetValue(SdfPath key, out GameObject obj) {
			obj = default;
			return default;
		} // 0x0000000189B84AF8-0x0000000189B84B5C
		public IEnumerator GetEnumerator() => default; // 0x0000000189B84958-0x0000000189B849E0
		IEnumerator<KeyValuePair<SdfPath, GameObject>> IEnumerable<KeyValuePair<SdfPath, GameObject>>.GetEnumerator() => default; // 0x0000000189B84A70-0x0000000189B84AF8
		public void AddInstance(GameObject goInst) {} // 0x0000000189B84284-0x0000000189B842DC
		public void AddMasterRoot(SdfPath path, GameObject go) {} // 0x0000000189B842DC-0x0000000189B84354
		public void AddInstanceRoot(SdfPath instancePath, GameObject go, SdfPath masterPath) {} // 0x0000000189B841D8-0x0000000189B84284
		public Dictionary<SdfPath, GameObject> GetMasterRootPaths() => default; // 0x0000000189B84A28-0x0000000189B84A70
		public Dictionary<SdfPath, InstanceRoot> GetInstanceRoots() => default; // 0x0000000189B849E0-0x0000000189B84A28
		public void DestroyAll() {} // 0x0000000189B84480-0x0000000189B84958
		public void Clear() {} // 0x0000000189B84354-0x0000000189B84480
	}

	public delegate void ExportFunction(ObjectContext objContext, ExportContext exportContext); // TypeDefIndex: 56649; 0x00000001869DD2E4-0x00000001869DD314

	internal delegate void ObjectProcessor(GameObject go, ExportContext context); // TypeDefIndex: 56650; 0x0000000182065C10-0x0000000182065C20

	public struct ObjectContext // TypeDefIndex: 56651
	{
		// Fields
		public GameObject gameObject; // 0x00
		public string path; // 0x08
		public SampleBase sample; // 0x10
		public object additionalData; // 0x18
	}

	public enum ActiveExportPolicy // TypeDefIndex: 56652
	{
		ExportAsVisibility = 0,
		ExportAsActive = 1,
		DoNotExport = 2,
		Ignore = 3
	}

	public class ExportContext // TypeDefIndex: 56653
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
		public ExportContext() {} // 0x0000000189B7EBE4-0x0000000189B7EEDC
	}

	public class Exporter // TypeDefIndex: 56654
	{
		// Fields
		public string path; // 0x10
		public SampleBase sample; // 0x18
		public ExportFunction exportFunc; // 0x20
		public object data; // 0x28
	
		// Constructors
		public Exporter() {} // 0x000000018350B670-0x000000018350B680
	}

	public class ExportPlan // TypeDefIndex: 56655
	{
		// Fields
		public List<Exporter> exporters; // 0x10
	
		// Constructors
		public ExportPlan() {} // 0x0000000189B7F3F4-0x0000000189B7F46C
	}

	public static class SceneExporter // TypeDefIndex: 56657
	{
		// Methods
		public static void Export(GameObject root, Scene scene, BasisTransformation basisTransform, bool exportUnvarying, bool zeroRootTransform, bool exportMaterials = false /* Metadata: 0x01FD8147 */, bool exportMonoBehaviours = false /* Metadata: 0x01FD8148 */, bool exportOverrides = false /* Metadata: 0x01FD8149 */) {} // 0x0000000189B88A60-0x0000000189B88BD0
		public static void Export(GameObject root, ExportContext context, bool zeroRootTransform) {} // 0x0000000189B884CC-0x0000000189B88A60
		private static void ExportImpl(GameObject root, ExportContext context) {} // 0x0000000189B87794-0x0000000189B884CC
		private static void Traverse(GameObject obj, ObjectProcessor processor, ExportContext context) {} // 0x0000000189B8B63C-0x0000000189B8B810
		private static void AccumNestedBones(Transform curXf, List<Transform> children, ExportContext ctx) {} // 0x0000000189B87054-0x0000000189B8724C
		private static T CreateSample<T>(ExportContext context)
			where T : SampleBase, new() => default;
		public static void SyncExportContext(GameObject exportRoot, ExportContext context) {} // 0x0000000189B8A40C-0x0000000189B8B63C
		private static void InitExportableObjects(GameObject go, ExportContext context) {} // 0x0000000189B88BD0-0x0000000189B895F8
		private static Transform MergeBonesBelowAnimator(Transform animator, ExportContext context) => default; // 0x0000000189B895F8-0x0000000189B89FBC
		private static void MergeBonesSimple(Transform source, Transform rootBone, Transform[] bones, Matrix4x4[] bindPoses, ExportContext context) {} // 0x0000000189B89FBC-0x0000000189B8A40C
		private static void CreateExportPlan(GameObject go, SampleBase sample, ExportFunction exportFunc, ExportContext context, string pathSuffix = null, bool insertFirst = true /* Metadata: 0x01FD814A */) {} // 0x0000000189B873C4-0x0000000189B87794
		private static Matrix4x4 ComputeWorldXf(Transform curBone, ExportContext context) => default; // 0x0000000189B8724C-0x0000000189B873C4
	}

	public interface IImporter // TypeDefIndex: 56658
	{
		// Methods
		void BeginReading(Scene scene, PrimMap primMap, SceneImportOptions importOptions);
		IEnumerator Import(Scene scene, PrimMap primMap, SceneImportOptions importOptions);
	}

	public static class SceneImporter // TypeDefIndex: 56661
	{
		// Fields
		public static IImporter ActiveMeshImporter; // 0x00
	
		// Nested types
		public class ImportException : Exception // TypeDefIndex: 56659
		{
			// Constructors
			public ImportException() {} // 0x0000000189B830AC-0x0000000189B830F8
			public ImportException(string message) {} // 0x0000000189B83158-0x0000000189B831B4
			public ImportException(string message, Exception innerException) {} // 0x0000000189B830F8-0x0000000189B83158
		}
	
		// Constructors
		static SceneImporter() {} // 0x0000000189B8BE40-0x0000000189B8BF50
	
		// Methods
		public static void ImportUsd(GameObject goRoot, Scene scene, PrimMap primMap, SceneImportOptions importOptions) {} // 0x0000000189B8BA60-0x0000000189B8BADC
		public static void ImportUsd(GameObject goRoot, Scene scene, PrimMap primMap, bool composingSubtree, SceneImportOptions importOptions) {} // 0x0000000189B8BADC-0x0000000189B8BD10
		private static UsdEditorAnalytics.ImportResult CreateImportResult(bool success, PrimMap primMap, ImportType importType = ImportType.Initial /* Metadata: 0x01FD814B */) => default; // 0x0000000189B8B9E8-0x0000000189B8BA60
		public static PrimMap BuildScene(Scene scene, GameObject root, SceneImportOptions importOptions, PrimMap primMap, bool composingSubtree) => default; // 0x0000000189B8B810-0x0000000189B8B92C
		private static void RemoveComponent<T>(GameObject go) {}
		[IteratorStateMachine(typeof(_BuildScene_d__8))]
		public static IEnumerator BuildScene(Scene scene, GameObject root, SceneImportOptions importOptions, PrimMap primMap, float targetFrameMilliseconds, bool composingSubtree) => default; // 0x0000000189B8B92C-0x0000000189B8B9E8
		private static bool ShouldYield(float targetTime, Stopwatch timer) => default; // 0x0000000189B8BE04-0x0000000189B8BE40
		private static void ResetTimer(Stopwatch timer) {} // 0x0000000189B8BDCC-0x0000000189B8BE04
		private static bool IsSkinnedMesh(UsdPrim prim, PrimMap primMap, SceneImportOptions importOptions) => default; // 0x0000000189B8BD10-0x0000000189B8BDCC
	}

	public enum PayloadPolicy // TypeDefIndex: 56662
	{
		DontLoadPayloads = 0,
		LoadAll = 1
	}

	public enum BasisTransformation // TypeDefIndex: 56663
	{
		FastWithNegativeScale = 0,
		SlowAndSafe = 1,
		SlowAndSafeAsFBX = 2,
		None = 3
	}

	[Serializable]
	public enum MaterialImportMode // TypeDefIndex: 56664
	{
		ImportPreviewSurface = 0,
		ImportDisplayColor = 1,
		None = 2
	}

	[Serializable]
	public class SceneImportOptions // TypeDefIndex: 56665
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
	
		// Properties
		public bool ShouldBindMaterials { get => default; } // 0x00000001856A4630-0x00000001856A4638 
		public ImportType ImportType { get; set; } // 0x0000000183D4EF00-0x0000000183D4EF10 0x0000000183D4EF50-0x0000000183D4EF60
	
		// Constructors
		public SceneImportOptions() {} // 0x0000000189B97AC0-0x0000000189B97BE0
	}

	public class UsdzExporter // TypeDefIndex: 56666
	{
		// Constructors
		public UsdzExporter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void ExportUsdz(string usdzFilePath, GameObject root) {} // 0x0000000189B9CD64-0x0000000189B9D474
	}

	public static class SkeletonExporter // TypeDefIndex: 56667
	{
		// Methods
		public static void ExportSkeleton(ObjectContext objContext, ExportContext exportContext) {} // 0x0000000189B98944-0x0000000189B99298
		public static void ExportSkelRoot(ObjectContext objContext, ExportContext exportContext) {} // 0x0000000189B984A4-0x0000000189B98944
		public static void ExportSkelAnimation(ObjectContext objContext, ExportContext exportContext) {} // 0x0000000189B97DAC-0x0000000189B984A4
	}

	public static class SkeletonImporter // TypeDefIndex: 56668
	{
		// Methods
		public static void BuildSkeletonBone(string skelPath, GameObject go, Matrix4x4 restXform, VtTokenArray joints, SceneImportOptions importOptions) {} // 0x0000000189B99C44-0x0000000189B9A0B4
		public static void BuildDebugBindTransforms(SkeletonSample skelSample, GameObject goSkeleton, SceneImportOptions options) {} // 0x0000000189B993A4-0x0000000189B99C44
		public static void BuildBindTransforms(string path, SkeletonSample skelSample, SceneImportOptions options) {} // 0x0000000189B99298-0x0000000189B993A4
		private static bool JointsMatch(string[] lhs, string[] rhs) => default; // 0x0000000189B9A918-0x0000000189B9A994
		public static void BuildSkinnedMesh(string meshPath, string skelPath, SkeletonSample skeleton, UsdSkelSkinningQuery skinningQuery, GameObject go, PrimMap primMap, SceneImportOptions options) {} // 0x0000000189B9A0B4-0x0000000189B9A918
	}

	public class UnitySkeleton // TypeDefIndex: 56669
	{
		// Fields
		public Transform rootBone; // 0x10
		public Transform[] bones; // 0x18
	
		// Constructors
		public UnitySkeleton() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class SkelBindingSample : SampleBase // TypeDefIndex: 56670
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
		public SkelBindingSample() {} // 0x0000000189B97BE0-0x0000000189B97D30
	}

	[Serializable]
	[UsdSchema("SkelRoot")]
	public class SkelRootSample : BoundableSample // TypeDefIndex: 56671
	{
		// Fields
		[UsdNamespace("skel")]
		public Relationship skeleton; // 0x78
		[UsdNamespace("skel")]
		public Relationship animationSource; // 0x80
	
		// Constructors
		public SkelRootSample() {} // 0x0000000189B97D30-0x0000000189B97DAC
	}

	[Serializable]
	[UsdSchema("Skeleton")]
	public class SkeletonSample : XformableSample // TypeDefIndex: 56672
	{
		// Fields
		[UsdVariability(Variability.Uniform)]
		public string[] joints; // 0x60
		[UsdVariability(Variability.Uniform)]
		public Matrix4x4[] bindTransforms; // 0x68
		[UsdVariability(Variability.Uniform)]
		public Matrix4x4[] restTransforms; // 0x70
	
		// Constructors
		public SkeletonSample() {} // 0x0000000189B85118-0x0000000189B85120
	}

	[Serializable]
	[UsdSchema("SkelAnimation")]
	public class SkelAnimationSample : SampleBase // TypeDefIndex: 56673
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
		public SkelAnimationSample() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[UsdSchema("BlendShape")]
	public class BlendShapeSample : SampleBase // TypeDefIndex: 56674
	{
		// Fields
		public Vector3[] offsets; // 0x10
		public uint[] pointIndices; // 0x18
	
		// Constructors
		public BlendShapeSample() {} // 0x000000018350B670-0x000000018350B680
	}

	public class SkeletonIo // TypeDefIndex: 56675
	{
		// Fields
		private Dictionary<Transform, Transform[]> m_bindings; // 0x10
	
		// Constructors
		public SkeletonIo() {} // 0x0000000189B9AA4C-0x0000000189B9AAC4
	
		// Methods
		public Transform[] GetBones(Transform rootBone) => default; // 0x0000000189B9A994-0x0000000189B9A9E8
		public void RegisterSkeleton(Transform rootBone, Transform[] bones) {} // 0x0000000189B9A9E8-0x0000000189B9AA4C
	}

	public class NativeExporter // TypeDefIndex: 56676
	{
		// Constructors
		public NativeExporter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void ExportObject(ObjectContext objContext, ExportContext exportContext) {} // 0x000000018350B670-0x000000018350B680
	}

	public class NativeImporter // TypeDefIndex: 56677
	{
		// Constructors
		public NativeImporter() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public static void ImportObject(Scene scene, GameObject go, UsdPrim usdPrim, SceneImportOptions options) {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	public class UsdPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 56678
	{
		// Fields
		private UsdAsset m_sourceUsdAsset; // 0x18
		[Tooltip("USD Player to Control")]
		public ExposedReference<UsdAsset> SourceUsdAsset; // 0x20
	
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x0000000183D55AE0-0x0000000183D55AF0 
		public override double duration { get => default; } // 0x0000000189B9AFF4-0x0000000189B9B14C 
	
		// Constructors
		public UsdPlayableAsset() {} // 0x000000018286F540-0x000000018286F550
	
		// Methods
		public UsdAsset GetUsdAsset(string usdRootPath) => default; // 0x0000000189B9AFC8-0x0000000189B9AFF4
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000189B9ADFC-0x0000000189B9AFC8
	}

	public class UsdPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 56679
	{
		// Fields
		public UsdPlayableAsset playableAsset; // 0x10
		private bool m_errorOnce; // 0x18
	
		// Constructors
		public UsdPlayableBehaviour() {} // 0x0000000183D587A0-0x0000000183D587B0
	
		// Methods
		public override void OnGraphStart(Playable playable) {} // 0x0000000189B9B14C-0x0000000189B9B154
		public override void OnGraphStop(Playable playable) {} // 0x000000018350B670-0x000000018350B680
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x000000018350B670-0x000000018350B680
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x000000018350B670-0x000000018350B680
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x000000018350B670-0x000000018350B680
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000189B9B154-0x0000000189B9B2D4
		public override void PrepareData(Playable playable, FrameData info) {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[TrackBindingType(typeof(UsdAsset))]
	[TrackClipType(typeof(UsdPlayableAsset))]
	[TrackColor(0.1f, 0.2f, 0.8f)]
	public class UsdPlayableTrack : TrackAsset // TypeDefIndex: 56680
	{
		// Constructors
		public UsdPlayableTrack() {} // 0x0000000189B9B310-0x0000000189B9B35C
	
		// Methods
		protected override void OnCreateClip(TimelineClip clip) {} // 0x0000000189B9B2D4-0x0000000189B9B310
	}

	public class UsdRecorderBehaviour : PlayableBehaviour // TypeDefIndex: 56682
	{
		// Fields
		private const int kExportFrameRate = 60; // Metadata: 0x01FD8155
		private bool m_isPaused; // 0x10
		public UsdRecorderClip Clip; // 0x18
		private string usdcFileName; // 0x20
		private string usdzFileName; // 0x28
		private string usdzFilePath; // 0x30
		private string currentDir; // 0x38
		private DirectoryInfo usdzTemporaryDir; // 0x40
		private GameObject _root; // 0x48
	
		// Constructors
		public UsdRecorderBehaviour() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		public void BeginRecording(double currentTime, GameObject root) {} // 0x0000000189B9B35C-0x0000000189B9BF10
		public void StopRecording(double currentTime) {} // 0x0000000189B9C410-0x0000000189B9C7F4
		private void ProcessRecording(double currentTime, GameObject root) {} // 0x0000000189B9C28C-0x0000000189B9C410
		private bool IsPlaying() => default; // 0x000000018232EB60-0x000000018232EB70
		public override void OnPlayableCreate(Playable playable) {} // 0x000000018350B670-0x000000018350B680
		public override void OnPlayableDestroy(Playable playable) {} // 0x0000000189B9C118-0x0000000189B9C170
		public override void OnGraphStart(Playable playable) {} // 0x0000000189B9BFF8-0x0000000189B9C0C0
		public override void OnGraphStop(Playable playable) {} // 0x0000000189B9C0C0-0x0000000189B9C118
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000189B9C170-0x0000000189B9C28C
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000183D557C0-0x0000000183D557D0
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000181168960-0x0000000181168970
		public void OnFrameEnd(Playable playable, FrameData info, object playerData) {} // 0x0000000189B9BF10-0x0000000189B9BFF8
	}

	[System.ComponentModel.DisplayName("USD Recorder Clip")]
	public class UsdRecorderClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 56683
	{
		// Fields
		public ExposedReference<GameObject> m_exportRoot; // 0x18
		private GameObject[] m_trackedRoots; // 0x28
		public bool m_exportMaterials; // 0x30
		public BasisTransformation m_convertHandedness; // 0x34
		public ActiveExportPolicy m_activePolicy; // 0x38
		public string m_usdFile; // 0x40
		private ExportContext m_context; // 0x50
	
		// Properties
		public Scene UsdScene { get; set; } // 0x0000000183D4EA70-0x0000000183D4EA80 0x0000000182692290-0x00000001826922A0
		public ExportContext Context { get => default; set {} } // 0x0000000183D4EAF0-0x0000000183D4EB00 0x0000000182C926C0-0x0000000182C926D0
		public ClipCaps clipCaps { get => default; } // 0x0000000181002730-0x0000000181002740 
		public bool IsUSDZ { get => default; } // 0x0000000189B9C9DC-0x0000000189B9CA48 
	
		// Constructors
		public UsdRecorderClip() {} // 0x0000000189B9C940-0x0000000189B9C9DC
	
		// Methods
		public GameObject GetExportRoot(PlayableGraph graph) => default; // 0x0000000189B9C8EC-0x0000000189B9C940
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x0000000189B9C7F4-0x0000000189B9C8EC
		public virtual void OnDestroy() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[TrackClipType(typeof(UsdRecorderClip))]
	[TrackColor(0.7f, 0f, 0f)]
	public class UsdRecorderTrack : TrackAsset // TypeDefIndex: 56684
	{
		// Constructors
		public UsdRecorderTrack() {} // 0x0000000189B9CA48-0x0000000189B9CA94
	}

	[ExecuteInEditMode]
	internal class UsdWaitForEndOfFrame : MonoBehaviour // TypeDefIndex: 56686
	{
		// Fields
		private List<Action> m_pending; // 0x18
		private static UsdWaitForEndOfFrame s_instance; // 0x00
	
		// Constructors
		public UsdWaitForEndOfFrame() {} // 0x0000000189B9CCE4-0x0000000189B9CD64
	
		// Methods
		private static UsdWaitForEndOfFrame GetInstance() => default; // 0x0000000189B9CAE8-0x0000000189B9CC64
		public static void Add(Action callback) {} // 0x0000000189B9CA94-0x0000000189B9CAE8
		[IteratorStateMachine(typeof(_WaitForEndOfFrame_d__4))]
		private IEnumerator WaitForEndOfFrame() => default; // 0x0000000189B9CC88-0x0000000189B9CCE4
		private void LateUpdate() {} // 0x0000000189B9CC64-0x0000000189B9CC88
	}
}
