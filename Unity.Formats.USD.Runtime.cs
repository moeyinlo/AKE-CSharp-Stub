/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using USD.NET;
using USD.NET.Unity;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using pxr;

// Image 47: Unity.Formats.USD.Runtime.dll - Assembly: Unity.Formats.USD.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 57578-57689

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 57580
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity) {}
	}

	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 57581
	{
		// Constructors
		public AnimatorBlackboardAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 57582
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 57583
	{
		// Constructors
		public CameraControlConfigAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	internal class DataNAttribute : Attribute // TypeDefIndex: 57584
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
	
		// Constructors
		public DataNAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace HG.Rendering.Runtime
{
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 57579
	{
		// Constructors
		public HGConstantBufferLayoutAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.Formats.USD
{
	public class UsdAssemblyRoot : MonoBehaviour // TypeDefIndex: 57585
	{
		// Constructors
		public UsdAssemblyRoot() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class UsdAsset : MonoBehaviour // TypeDefIndex: 57586
	{
		// Fields
		private string m_usdFile; // 0x18
		public string m_projectAssetPath; // 0x20
		public string m_usdRootPath; // 0x28
		public float m_usdTimeOffset; // 0x30
		public PayloadPolicy m_payloadPolicy; // 0x34
		public bool m_importHierarchy; // 0x38
		public float m_scale; // 0x3C
		public BasisTransformation m_changeHandedness; // 0x40
		public Scene.InterpolationMode m_interpolation; // 0x44
		public bool m_useOriginalShaderIfAvailable; // 0x48
		public Material m_displayColorMaterial; // 0x50
		public Material m_specularWorkflowMaterial; // 0x58
		public Material m_metallicWorkflowMaterial; // 0x60
		public bool m_enableGpuInstancing; // 0x68
		public ImportMode m_points; // 0x6C
		public ImportMode m_topology; // 0x70
		public ImportMode m_boundingBox; // 0x74
		public ImportMode m_color; // 0x78
		public ImportMode m_normals; // 0x7C
		public ImportMode m_tangents; // 0x80
		public bool m_generateLightmapUVs; // 0x84
		public float m_unwrapAngleError; // 0x88
		public float m_unwrapAreaError; // 0x8C
		public float m_unwrapHardAngle; // 0x90
		public int m_unwrapPackMargin; // 0x94
		public MaterialImportMode m_materialImportMode; // 0x98
		public bool m_importCameras; // 0x9C
		public bool m_importMeshes; // 0x9D
		public bool m_importSkinning; // 0x9E
		public bool m_importTransforms; // 0x9F
		public bool m_importSceneInstances; // 0xA0
		public bool m_importPointInstances; // 0xA1
		public bool m_importMonoBehaviors; // 0xA2
		public bool m_debugShowSkeletonBindPose; // 0xA3
		public bool m_debugShowSkeletonRestPose; // 0xA4
		public bool m_debugPrintVariabilityCache; // 0xA5
		public bool m_usdVariabilityCache; // 0xA6
		public BasisTransformation LastHandedness; // 0xA8
		public float LastScale; // 0xAC
		private float m_lastTime; // 0xB0
		private Scene m_lastScene; // 0xB8
		private PrimMap m_lastPrimMap; // 0xC0
		private AccessMask m_lastAccessMask; // 0xC8
	
		// Properties
		public double Length { get => default; } // 0x000000018BC966C0-0x000000018BC966C8 
		public string usdFullPath { get => default; set {} } // 0x000000018BC966C8-0x000000018BC96740 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public UsdAsset() {} // 0x000000018BC96604-0x000000018BC966C0
	
		// Methods
		private void OnDestroy() {} // 0x000000018BC940CC-0x000000018BC94110
		private string GetPrefabAssetPath(GameObject root) => default; // 0x00000001813AE580-0x00000001813AE590
		public void OptionsToState(SceneImportOptions options) {} // 0x000000018BC94174-0x000000018BC943B0
		public void StateToOptions(ref SceneImportOptions options) {} // 0x000000018BC961CC-0x000000018BC965C4
		private bool SceneFileChanged() => default; // 0x000000018BC947B8-0x000000018BC948B8
		public Scene GetScene() => default; // 0x000000018BC93BE8-0x000000018BC93EFC
		private void OnReload() {} // 0x000000018BC94110-0x000000018BC94174
		private void DestroyComponent(Component comp) {} // 0x000000018BC93598-0x000000018BC935F8
		private void ClearLastData() {} // 0x000000018BC933C8-0x000000018BC93410
		public void RemoveAllUsdComponents() {} // 0x000000018BC945BC-0x000000018BC947B8
		public void DestroyAllImportedObjects() {} // 0x000000018BC93474-0x000000018BC93598
		public void Reload(bool forceRebuild) {} // 0x000000018BC94434-0x000000018BC945BC
		private UsdPrim GetFirstPrim(Scene scene) => default; // 0x000000018BC93B4C-0x000000018BC93BE8
		public void ExportOverrides(Scene sceneInWhichToStoreTransforms) {} // 0x000000018BC935F8-0x000000018BC93B4C
		private double ComputeLength() => default; // 0x000000018BC93410-0x000000018BC93474
		public void SetTime(double time, UsdAsset foreignRoot, bool saveMeshUpdates) {} // 0x000000018BC95100-0x000000018BC958C0
		private void Update() {} // 0x000000018BC965C4-0x000000018BC96604
		public static void PrepOptionsForTimeChange(ref SceneImportOptions options) {} // 0x000000018BC943B0-0x000000018BC94434
		public void ImportUsdAsCoroutine(GameObject goRoot, string usdFilePath, double time, SceneImportOptions importOptions, float targetFrameMilliseconds) {} // 0x000000018BC93EFC-0x000000018BC940CC
		public void SetPayloadState(GameObject go, bool isLoaded) {} // 0x000000018BC948B8-0x000000018BC95100
		private void ApplyVariantSelectionState(Scene scene, UsdVariantSet variants) {} // 0x000000018BC93084-0x000000018BC933C8
		public void SetVariantSelection(GameObject go, string usdPrimPath, Dictionary<string, string> selections) {} // 0x000000018BC958C0-0x000000018BC961CC
	}

	public class UsdLayerStack : MonoBehaviour // TypeDefIndex: 57587
	{
		// Fields
		public string m_targetLayer; // 0x18
		public string[] m_layerStack; // 0x20
		public string[] m_mutedLayers; // 0x28
	
		// Constructors
		public UsdLayerStack() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void SetupNewSubLayer(Scene parentScene, Scene subLayerScene) {} // 0x000000018BC96C24-0x000000018BC96CB4
		public void SaveLayerStack(Scene scene, string[] layerStack) {} // 0x000000018BC96740-0x000000018BC968EC
		public void SaveToLayer() {} // 0x000000018BC968EC-0x000000018BC96C24
	}

	public class UsdModelRoot : MonoBehaviour // TypeDefIndex: 57588
	{
		// Fields
		public string m_modelName; // 0x18
		public string m_modelVersion; // 0x20
		public string m_modelAssetPath; // 0x28
	
		// Constructors
		public UsdModelRoot() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class UsdPayload : MonoBehaviour // TypeDefIndex: 57589
	{
		// Fields
		private bool m_isLoaded; // 0x18
		private bool m_wasLoaded; // 0x19
	
		// Properties
		public bool IsLoaded { get => default; } // 0x00000001813C0430-0x00000001813C0440 
	
		// Constructors
		public UsdPayload() {} // 0x000000018BC96D40-0x000000018BC96D50
	
		// Methods
		public void Load() {} // 0x0000000181B75280-0x0000000181B75290
		public void Unload() {} // 0x0000000185FBD8D0-0x0000000185FBD8E0
		public void SetInitialState(bool loaded) {} // 0x0000000185FD76B0-0x0000000185FD76C0
		public void Update() {} // 0x000000018BC96CB4-0x000000018BC96D40
	}

	public class UsdPrimSource : MonoBehaviour // TypeDefIndex: 57590
	{
		// Fields
		public string m_usdPrimPath; // 0x18
	
		// Constructors
		public UsdPrimSource() {} // 0x000000018646DB20-0x000000018646DB28
	}

	public class UsdVariantSet : MonoBehaviour // TypeDefIndex: 57592
	{
		// Fields
		public string[] m_variantSetNames; // 0x18
		public string[] m_selected; // 0x20
		public string[] m_variants; // 0x28
		public int[] m_variantCounts; // 0x30
		public string m_primPath; // 0x38
	
		// Nested types
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 57591
		{
			// Fields
			public UsdVariantSets variantSets; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x000000018BC96EB8-0x000000018BC97140
	
			// Methods
			internal string _LoadFromUsd_b__0(string setName) => default; // 0x000000018BC96D50-0x000000018BC96DE8
			internal IEnumerable<string> _LoadFromUsd_b__1(string setName) => default; // 0x000000018BC96DE8-0x000000018BC96EB8
			internal int _LoadFromUsd_b__2(string setName) => default; // 0x000000018646DB20-0x000000018646DB28
		}
	
		// Constructors
		public UsdVariantSet() {} // 0x000000018BC92FF4-0x000000018BC93034
	
		// Methods
		public void LoadFromUsd(UsdPrim prim) {} // 0x0000000185492010-0x0000000185492020
		public void ApplyVariantSelections() {} // 0x000000018BC92FA4-0x000000018BC92FC4
		public Dictionary<string, string> GetVariantSelections() => default; // 0x000000018BC92FC4-0x000000018BC92FF4
	}

	public class SkinnedMeshUnityDiff : MonoBehaviour // TypeDefIndex: 57593
	{
		// Fields
		public SkinnedMeshRenderer m_usdMesh; // 0x18
		public SkinnedMeshRenderer m_unityMesh; // 0x20
	
		// Constructors
		public SkinnedMeshUnityDiff() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void OnEnable() {} // 0x000000018BC8EA7C-0x000000018BC8FA50
		private bool Approximately(Matrix4x4 rhs, Matrix4x4 lhs) => default; // 0x000000018BC8E9E4-0x000000018BC8EA50
		private bool WeightsMatch(BoneWeight w1, BoneWeight w2) => default; // 0x000000018BC8FA50-0x000000018BC8FAB8
		private bool IndicesMatch(BoneWeight w1, BoneWeight w2) => default; // 0x000000018BC8EA50-0x000000018BC8EA7C
		private void Update() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SkinnedMeshUsdDiff : MonoBehaviour // TypeDefIndex: 57594
	{
		// Fields
		public string m_usdFile; // 0x18
		public string m_usdMeshPath; // 0x20
		public BasisTransformation m_basisTransform; // 0x28
	
		// Constructors
		public SkinnedMeshUsdDiff() {} // 0x000000018646DB20-0x000000018646DB28
	
		// Methods
		private void OnEnable() {} // 0x000000018BC8FC5C-0x000000018BC90BF8
		private string GetUsdBoneData<T>(int bone, int weightIndex, Primvar<T[]> primvar) => default;
		private Scene GetScene() => default; // 0x000000018BC8FAB8-0x000000018BC8FC5C
		private SkelBindingSample ReadUsdWeights(Scene scene) => default; // 0x000000018BC91014-0x000000018BC91130
		private SkeletonSample ReadUsdSkeleton(Scene scene, out string skelRootPath) {
			skelRootPath = default;
			return default;
		} // 0x000000018BC90BF8-0x000000018BC91014
		private void Update() {} // 0x0000000185492010-0x0000000185492020
	}

	public static class CameraExporter // TypeDefIndex: 57595
	{
		// Methods
		public static void ExportCamera(ObjectContext objContext, ExportContext exportContext) {} // 0x000000018BC82C60-0x000000018BC82F28
	}

	public static class CameraImporter // TypeDefIndex: 57596
	{
		// Methods
		public static void BuildCamera(CameraSample usdCamera, GameObject go, SceneImportOptions options) {} // 0x000000018BC82F28-0x000000018BC82FE4
	}

	public static class CubeImporter // TypeDefIndex: 57597
	{
		// Methods
		public static void BuildCube(CubeSample usdCube, GameObject go, SceneImportOptions options, bool skinnedMesh = false /* Metadata: 0x0207D9E0 */) {} // 0x000000018BC82FE4-0x000000018BC84AB8
		private static bool ShouldImport(ImportMode mode) => default; // 0x000000018B5E8780-0x000000018B5E8790
		private static bool ShouldCompute(ImportMode mode) => default; // 0x0000000187C10D24-0x0000000187C10D34
	}

	public static class InstanceImporter // TypeDefIndex: 57598
	{
		// Methods
		public static void BuildSceneInstances(PrimMap primMap, SceneImportOptions options) {} // 0x000000018BC873CC-0x000000018BC879C4
		public static void BuildPointInstances(Scene scene, PrimMap primMap, string pointInstancerPath, PointInstancerSample sample, GameObject root, SceneImportOptions options) {} // 0x000000018BC86D38-0x000000018BC873CC
		private static void EnableGpuInstancing(GameObject go) {} // 0x000000018BC879C4-0x000000018BC87C1C
	}

	public static class MeshExporter // TypeDefIndex: 57599
	{
		// Fields
		private static TfToken m_materialBindToken; // 0x00
		private static TfToken m_subMeshesToken; // 0x08
	
		// Constructors
		static MeshExporter() {} // 0x000000018BC8C18C-0x000000018BC8C27C
	
		// Methods
		public static void ExportSkinnedMesh(ObjectContext objContext, ExportContext exportContext) {} // 0x000000018BC8BE8C-0x000000018BC8C18C
		private static void ExportSkelWeights(Scene scene, string path, Mesh unityMesh, Transform rootBone, Transform[] bones, string skeletonPath) {} // 0x000000018BC8B938-0x000000018BC8BE8C
		public static void ExportMesh(ObjectContext objContext, ExportContext exportContext) {} // 0x000000018BC8B808-0x000000018BC8B938
		private static void ExportMesh(ObjectContext objContext, ExportContext exportContext, Mesh mesh, Material sharedMaterial, Material[] sharedMaterials, bool exportMeshPose = true /* Metadata: 0x0207D9E1 */) {} // 0x000000018BC8A38C-0x000000018BC8B808
	}

	public delegate void MeshImportFunction<T>(string path, T sample, MeshImporter.GeometrySubsets subsets, GameObject go, SceneImportOptions option, bool isDynamic, UsdSkelSkinningQuery query = null); // TypeDefIndex: 57600; 0x00000000-0x00000000

	public class MeshImportStrategy : IImporter // TypeDefIndex: 57602
	{
		// Fields
		private MeshImportFunction<SanitizedMeshSample> m_meshImporter; // 0x10
		private MeshImportFunction<SanitizedMeshSample> m_skinnedMeshImporter; // 0x18
		private ReadAllJob<SanitizedMeshSample> m_readMeshesJob; // 0x20
	
		// Nested types
		private sealed class _Import_d__5 : IEnumerator<object> // TypeDefIndex: 57601
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BC92EA8-0x000000018BC92F20 
			object IEnumerator.Current { get => default; } // 0x000000018BC92F20-0x000000018BC92F70 
	
			// Constructors
			public _Import_d__5() {} // Dummy constructor
			public _Import_d__5(int __1__state) {} // 0x00000001841BC230-0x00000001841BC260
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BC8C27C-0x000000018BC8C348
			private bool MoveNext() => default; // 0x000000018BC8C348-0x000000018BC8C3F0
			private void __m__Finally1() {} // 0x0000000181378230-0x0000000181378240
			void IEnumerator.Reset() {} // 0x000000018BC91758-0x000000018BC92E5C
		}
	
		// Constructors
		public MeshImportStrategy() {} // Dummy constructor
		public MeshImportStrategy(MeshImportFunction<SanitizedMeshSample> meshImporter, MeshImportFunction<SanitizedMeshSample> skinnedMeshImporter) {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		public void BeginReading(Scene scene, PrimMap primMap, SceneImportOptions importOptions) {} // 0x000000018BC92E5C-0x000000018BC92EA8
		public IEnumerator Import(Scene scene, PrimMap primMap, SceneImportOptions importOptions) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public static class MeshImporter // TypeDefIndex: 57606
	{
		// Nested types
		public class GeometrySubsets // TypeDefIndex: 57603
		{
			// Fields
			private Dictionary<string, int[]> _Subsets_k__BackingField; // 0x10
	
			// Properties
			public Dictionary<string, int[]> Subsets { get; set; } // 0x000000018BC8E58C-0x000000018BC8E934 0x000000018BC8D964-0x000000018BC8DB24
	
			// Constructors
			public GeometrySubsets() {} // 0x000000018BC8DB24-0x000000018BC8E13C
		}
	
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 57604
		{
			// Fields
			public Mesh unityMesh; // 0x10
			public Renderer renderer; // 0x18
			public string path; // 0x20
			public SanitizedMeshSample usdMesh; // 0x28
	
			// Constructors
			public __c__DisplayClass5_0() {} // 0x000000018BC8D7AC-0x000000018BC8D964
	
			// Methods
			internal void _BuildMesh__b__0(Scene scene, Material boundMat, List<string> primvars) {} // 0x000000018BC8C4E4-0x000000018BC8D7AC
		}
	
		private sealed class __c__DisplayClass5_1 // TypeDefIndex: 57605
		{
			// Fields
			public int idx; // 0x10
			public __c__DisplayClass5_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass5_1() {} // 0x000000018BC8E2F4-0x000000018BC8E58C
	
			// Methods
			internal void _BuildMesh__b__1(Scene scene, Material boundMat, List<string> primvars) {} // 0x000000018BC8C494-0x000000018BC8C4E4
		}
	
		// Methods
		public static GeometrySubsets ReadGeomSubsets(Scene scene, string path) => default; // 0x000000018BC8C3F0-0x000000018BC8C494
		public static void BuildSkinnedMesh(string path, SanitizedMeshSample usdMesh, GeometrySubsets geomSubsets, GameObject go, SceneImportOptions options, bool isDynamic, UsdSkelSkinningQuery skinningQuery = null) {}
		public static void ImportSkinning(string path, SanitizedMeshSample usdMesh, Mesh unityMesh, UsdSkelSkinningQuery skinningQuery) {} // 0x000000018BC8E13C-0x000000018BC8E2F4
		public static void BuildMesh(string path, SanitizedMeshSample usdMesh, GeometrySubsets geomSubsets, GameObject go, SceneImportOptions options, bool isDynamic, UsdSkelSkinningQuery skinQuery = null) {} // 0x000000018B5E8780-0x000000018B5E8790
		private static void BuildMesh_(string path, SanitizedMeshSample usdMesh, Mesh unityMesh, GeometrySubsets geomSubsets, GameObject go, Renderer renderer, SceneImportOptions options) {} // 0x0000000187C10D24-0x0000000187C10D34
		private static void LoadPrimvars(Mesh unityMesh, string usdMeshPath, List<string> primvars, MeshSample sample) {} // 0x000000018BC8E934-0x000000018BC8E9E4
		private static void BindMat(Mesh unityMesh, Material mat, Renderer renderer, string usdMeshPath, List<string> primvars, MeshSample sample) {} // 0x000000018346D130-0x000000018346D140
		private static void BindMat(Mesh unityMesh, Material mat, Renderer renderer, int index, string usdMeshPath, List<string> primvars, MeshSample sample) {} // 0x0000000184096E30-0x0000000184096EF0
		private static T[] TryGetPrimvarValue<T>(Primvar<object> primvar) => default; // 0x000000018BC84AB8-0x000000018BC84B30
		private static void ImportUv(Mesh unityMesh, int uvSetIndex, Primvar<object> uv) {} // 0x0000000185492010-0x0000000185492020
		public static bool ShouldImport(ImportMode mode) => default; // 0x000000018BC92F70-0x000000018BC92FA4
		public static bool ShouldCompute(ImportMode mode) => default; // 0x0000000185492010-0x0000000185492020
		private static string UniqueMeshName(string meshName) => default; // 0x000000018BC93034-0x000000018BC93084
	}

	public enum ImportMode // TypeDefIndex: 57607
	{
		Import = 0,
		ImportOrCompute = 1,
		Compute = 2,
		Ignore = 3
	}

	[Serializable]
	public class MeshImportOptions // TypeDefIndex: 57608
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
		public MeshImportOptions() {} // 0x0000000185FD7670-0x0000000185FD76B0
	}

	public static class SphereImporter // TypeDefIndex: 57609
	{
		// Methods
		public static void BuildSphere(SphereSample usdSphere, GameObject go, SceneImportOptions options, bool skinnedMesh = false /* Metadata: 0x0207D9E6 */) {} // 0x000000018BC91130-0x000000018BC91758
		private static bool ShouldImport(ImportMode mode) => default; // 0x000000018B5E8780-0x000000018B5E8790
		private static bool ShouldCompute(ImportMode mode) => default; // 0x0000000187C10D24-0x0000000187C10D34
	}

	public static class XformExporter // TypeDefIndex: 57610
	{
		// Methods
		public static void ExportXform(ObjectContext objContext, ExportContext exportContext) {} // 0x000000018BC97140-0x000000018BC973CC
		public static void WriteSparseOverrides(Scene scene, PrimMap primMap, BasisTransformation changeHandedness, float tolerance = 0.0001f /* Metadata: 0x0207D9E7 */) {} // 0x000000018BC9769C-0x000000018BC979C4
		public static Matrix4x4 GetLocalTransformMatrix(Transform tr, bool correctZUp, bool isRootPrim, BasisTransformation conversionType) => default; // 0x000000018BC973CC-0x000000018BC9769C
	}

	public static class XformImporter // TypeDefIndex: 57611
	{
		// Methods
		public static void BuildXform(SdfPath path, XformableSample usdXf, GameObject go, SceneImportOptions options, Scene scene) {} // 0x000000018BC97F04-0x000000018BC98084
		public static void BuildXform(Matrix4x4 xf, GameObject go, SceneImportOptions options) {} // 0x000000018BC97D64-0x000000018BC97F04
		public static void ImportXform(ref Matrix4x4 mat, SceneImportOptions options) {} // 0x000000018BC98084-0x000000018BC9816C
		public static void BuildSceneRoot(Scene scene, Transform root, SceneImportOptions options) {} // 0x000000018BC979C4-0x000000018BC97D64
		public static void UndoRootTransform(Scene scene, UsdAsset stageRoot, ref Vector3 localScale, ref Quaternion localRotation) {} // 0x000000018BC9816C-0x000000018BC98458
	}

	public static class ImporterBase // TypeDefIndex: 57612
	{
		// Methods
		public static string MakeRelativePath(string anchorPath, string pathToMakeRelative) => default; // 0x000000018BC86884-0x000000018BC86B20
		public static bool ApproximatelyEqual(Matrix4x4 lhs, Matrix4x4 rhs) => default; // 0x000000018BC8681C-0x000000018BC86884
		public static void MoveComponentFirst(Component comp) {} // 0x000000018BC86B20-0x000000018BC86B74
		public static void MoveComponentLast(Component comp) {} // 0x000000018BC86B74-0x000000018BC86BC8
		public static T GetOrAddComponent<T>(GameObject go, bool insertFirst = false /* Metadata: 0x0207D9EB */)
			where T : Component => default;
		public static string SafeGetDirectoryName(string fullPath) => default; // 0x000000018BC86BC8-0x000000018BC86D38
	}

	public class HdrpShaderExporter : ShaderExporterBase // TypeDefIndex: 57613
	{
		// Constructors
		public HdrpShaderExporter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void ExportLit(Scene scene, string usdShaderPath, Material material, PreviewSurfaceSample surface, string destTexturePath) {} // 0x000000018BC84B30-0x000000018BC85AE8
	}

	public class HdrpShaderImporter : ShaderImporterBase // TypeDefIndex: 57614
	{
		// Fields
		private static Material ChannelCombinerMat; // 0x00
	
		// Constructors
		public HdrpShaderImporter() {} // Dummy constructor
		public HdrpShaderImporter(Material material) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void ImportFromUsd() {} // 0x000000018BC861F4-0x000000018BC8681C
		private static Texture2D BuildMaskMap(Texture2D red, Texture2D green, Texture2D blue, Texture2D alpha) => default; // 0x000000018BC85AE8-0x000000018BC861F4
	}

	public static class MaterialExporter // TypeDefIndex: 57616
	{
		// Fields
		public static readonly string kStandardFallbackHandler; // 0x00
		public static readonly string kHdrpFallbackHandler; // 0x08
		public static readonly string kLwrpFallbackHandler; // 0x10
		public static Dictionary<string, ExportHandler> ExportRegistry; // 0x18
	
		// Nested types
		public delegate void ExportHandler(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // TypeDefIndex: 57615; 0x000000018BC87C1C-0x000000018BC8813C
	
		// Constructors
		static MaterialExporter() {} // 0x000000018773B27C-0x000000018773B2CC
	
		// Methods
		public static void ExportMaterial(Scene scene, Material mat, string usdMaterialPath) {} // 0x00000001864BB614-0x00000001864BB734
	}

	public static class MaterialImporter // TypeDefIndex: 57618
	{
		// Fields
		private static readonly TfToken materialBindToken; // 0x00
		private static Material AlbedoGlossCombiner; // 0x08
		public static TextureResolver OnResolveTexture; // 0x10
	
		// Nested types
		public delegate Texture2D TextureResolver(SdfAssetPath textureAssetPath, bool isNormalMap, SceneImportOptions importOptions); // TypeDefIndex: 57617; 0x000000018BC887E4-0x000000018BC898CC
	
		// Constructors
		static MaterialImporter() {} // 0x00000001864750A8-0x00000001864751CC
	
		// Methods
		public static void ProcessMaterialBindings(Scene scene, SceneImportOptions importOptions) {} // 0x000000018BC898CC-0x000000018BC89BCC
		public static Material BuildMaterial(Scene scene, string materialPath, MaterialSample sample, SceneImportOptions options) => default; // 0x000000018BC89BCC-0x000000018BC89DE8
		public static Texture2D ImportConnectedTexture<T>(Scene scene, Connectable<T> connection, bool isNormalMap, SceneImportOptions options, out string uvPrimvar) {
			uvPrimvar = default;
			return default;
		} // 0x000000018BC8A2FC-0x000000018BC8A38C
		private static Texture2D DefaultTextureResolver(SdfAssetPath textureAssetPath, bool isNormalMap, SceneImportOptions options) => default; // 0x000000018BCA9AD4-0x000000018BCA9BFC
		public static Texture2D CombineRoughness(Texture2D rgbTex, Texture2D roughnessTex, string fileNameSuffix) => default; // 0x00000001817E31E0-0x00000001817E3200
		public static UnityPreviewSurfaceSample GetSurfaceShaderPrim(Scene scene, string primPath) => default; // 0x000000018BCA9A4C-0x000000018BCA9AD4
	}

	public class MaterialMap : IEnumerable<KeyValuePair<string, Material>> // TypeDefIndex: 57620
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
		public Material DisplayColorMaterial { get => default; set {} } // 0x000000018BC9D920-0x000000018BC9D984 0x000000018571FEC0-0x000000018571FED0
		public Material SpecularWorkflowMaterial { get => default; set {} } // 0x000000018BC9D2C0-0x000000018BC9D490 0x000000018BC9D188-0x000000018BC9D210
		public Material MetallicWorkflowMaterial { get => default; set {} } // 0x000000018BC9D5A8-0x000000018BC9D60C 0x000000018BC9D8B4-0x000000018BC9D920
		public Material this[string path] { get => default; set {} } // 0x000000018BC9D490-0x000000018BC9D5A8 0x000000018BC9D0D4-0x000000018BC9D188
	
		// Nested types
		public delegate void MaterialBinder(Scene scene, Material mat, List<string> uvPrimvars); // TypeDefIndex: 57619; 0x0000000185A16440-0x0000000185A16450
	
		// Constructors
		public MaterialMap() {} // 0x00000001864BB614-0x00000001864BB734
	
		// Methods
		private void InstantiateMaterials() {} // 0x000000018BC9D9E8-0x000000018BC9DA4C
		public Dictionary<string, MaterialBinder> ClearRequestedBindings() => default; // 0x000000018BC9D258-0x000000018BC9D2C0
		public void RequestBinding(string usdPath, MaterialBinder binder) {} // 0x000000018BC9D60C-0x000000018BC9D670
		public List<string> GetPrimvars(string materialPath) => default; // 0x000000018BC9D210-0x000000018BC9D258
		public void SetPrimvars(string materialPath, List<string> primvars) {} // 0x000000018BC9D670-0x000000018BC9D6F8
		public Material InstantiateSolidColor(UnityEngine.Color color) => default; // 0x000000018BC9D6F8-0x000000018BC9D850
		public static void AssignColor(Material material, UnityEngine.Color color) {} // 0x000000018A2AD604-0x000000018A2AD72C
		public IEnumerator GetEnumerator() => default; // 0x0000000181A578C0-0x0000000181A578E0
		IEnumerator<KeyValuePair<string, Material>> IEnumerable<KeyValuePair<string, Material>>.GetEnumerator() => default; // 0x0000000187206B7C-0x0000000187206BB4
	}

	public class ShaderExporterBase // TypeDefIndex: 57622
	{
		// Fields
		private static Material _metalGlossChannelSwapMaterial; // 0x00
		private static Material _normalChannelMaterial; // 0x08
	
		// Nested types
		public enum ConversionType // TypeDefIndex: 57621
		{
			None = 0,
			SwapRASmoothnessToBGRoughness = 1,
			InvertAlpha = 2,
			UnpackNormal = 3,
			MaskMapToORM = 4,
			RemoveAlpha = 5
		}
	
		// Constructors
		public ShaderExporterBase() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		protected static string SetupTexture(Scene scene, string usdShaderPath, Material material, PreviewSurfaceSample surface, Vector4 scale, string destTexturePath, string textureName, string textureOutput, ConversionType conversionType = ConversionType.None /* Metadata: 0x0207D9EC */) => default; // 0x000000018BCA57C4-0x000000018BCA6FBC
	}

	public abstract class ShaderImporterBase // TypeDefIndex: 57624
	{
		// Fields
		private Material _Material_k__BackingField; // 0x10
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
		public Material Material { get; private set; } // 0x00000001813C0430-0x00000001813C0440 0x00000001813C0520-0x00000001813C0530
		public bool IsSpecularWorkflow { get; private set; } // 0x0000000184096E30-0x0000000184096EF0 
	
		// Nested types
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 57623
		{
			// Fields
			public string localName; // 0x10
	
			// Constructors
			public __c__DisplayClass34_0() {} // 0x000000018346D130-0x000000018346D140
	
			// Methods
			internal bool _MergePrimvars_b__0(string str) => default; // 0x0000000184096E30-0x0000000184096EF0
		}
	
		// Constructors
		protected ShaderImporterBase() {} // Dummy constructor
		public ShaderImporterBase(Material material) {} // 0x000000018BCA6FBC-0x000000018BCA7114
	
		// Methods
		public abstract void ImportFromUsd();
		protected void ImportColorOrMap(Scene scene, Connectable<Vector3> usdParam, bool isNormalMap, SceneImportOptions options, ref Texture2D map, ref UnityEngine.Color? value, out string uvPrimvar) {
			uvPrimvar = default;
		} // 0x000000018BCA759C-0x000000018BCA76A4
		protected void ImportValueOrMap<T>(Scene scene, Connectable<T> usdParam, bool isNormalMap, SceneImportOptions options, ref Texture2D map, ref T? value, out string uvPrimvar)
			where T : struct {
			uvPrimvar = default;
		} // 0x000000018BCA7114-0x000000018BCA759C
		private void MergePrimvars(string newPrimvar, List<string> primvars) {} // 0x0000000185492010-0x0000000185492020
		public virtual void ImportParametersFromUsd(Scene scene, string materialPath, MaterialSample materialSample, PreviewSurfaceSample previewSurf, SceneImportOptions options) {} // 0x000000018820D3F8-0x000000018820D40C
	}

	public class StandardShaderExporter : ShaderExporterBase // TypeDefIndex: 57626
	{
		// Nested types
		private enum StandardShaderBlendMode // TypeDefIndex: 57625
		{
			Opaque = 0,
			Cutout = 1,
			Fade = 2,
			Transparent = 3
		}
	
		// Constructors
		public StandardShaderExporter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void ExportStandardSpecular(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath) {} // 0x000000018BCA8B74-0x000000018BCA8E70
		public static void ExportStandardRoughness(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath) {} // 0x000000018BCA8738-0x000000018BCA8B74
		public static void ExportStandard(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath) {} // 0x000000018BCA8E70-0x000000018BCA91A4
		public static void ExportGeneric(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath) {} // 0x000000018BCA76A4-0x000000018BCA7D24
		private static void ExportStandardCommon(Scene scene, string usdShaderPath, Material mat, UnityPreviewSurfaceSample surface, string destTexturePath) {} // 0x000000018BCA7D24-0x000000018BCA8738
		private static bool ShouldUseSpecularWorkflow(Material material) => default; // 0x000000018BCA91A4-0x000000018BCA92D8
	}

	public class StandardShaderImporter : ShaderImporterBase // TypeDefIndex: 57627
	{
		// Constructors
		public StandardShaderImporter() {} // Dummy constructor
		public StandardShaderImporter(Material material) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void ImportFromUsd() {} // 0x000000018BCA92D8-0x000000018BCA9A4C
	}

	public class UnityMaterialData : SampleBase // TypeDefIndex: 57628
	{
		// Fields
		public string shaderName; // 0x10
		public string[] shaderKeywords; // 0x18
		public Dictionary<string, float> floatArgs; // 0x20
		public Dictionary<string, UnityEngine.Color> colorArgs; // 0x28
		public Dictionary<string, Vector4> vectorArgs; // 0x30
	
		// Constructors
		public UnityMaterialData() {} // 0x000000018BCB0A40-0x000000018BCB0B4C
	}

	public class UnityPreviewSurfaceSample : PreviewSurfaceSample // TypeDefIndex: 57629
	{
		// Fields
		public UnityMaterialData unity; // 0x90
	
		// Constructors
		public UnityPreviewSurfaceSample() {} // 0x000000018BCB0B4C-0x000000018BCB0BC0
	}

	public class UrpShaderImporter : ShaderImporterBase // TypeDefIndex: 57630
	{
		// Constructors
		public UrpShaderImporter() {} // Dummy constructor
		public UrpShaderImporter(Material material) {} // 0x0000000184096E30-0x0000000184096EF0
	
		// Methods
		public override void ImportFromUsd() {} // 0x000000018BCB0BC0-0x000000018BCB1334
	}

	public struct ReadAllJob<T> : IEnumerator<SampleEnumerator<T>>, IEnumerable<SampleEnumerator<T>>, IJobParallelFor // TypeDefIndex: 57631
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

	public interface IRestorable // TypeDefIndex: 57632
	{
		// Methods
		bool IsRestoredFromCachedData();
		void FromCachedData(IRestorableData data);
		IRestorableData ToCachedData();
	}

	public interface ISanitizable // TypeDefIndex: 57633
	{
		// Methods
		void Sanitize(Scene scene, SceneImportOptions importOptions);
	}

	public class MeshStaticPropertiesData : IRestorableData // TypeDefIndex: 57634
	{
		// Fields
		internal int[] originalFaceVertexCounts; // 0x10
		internal int[] originalFaceVertexIndices; // 0x18
		internal bool arePrimvarsFaceVarying; // 0x20
		internal Orientation orientation; // 0x24
	
		// Constructors
		public MeshStaticPropertiesData() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SanitizedXformSample : XformSample, ISanitizable // TypeDefIndex: 57635
	{
		// Constructors
		public SanitizedXformSample() {} // 0x000000018BC9E98C-0x000000018BC9E994
	
		// Methods
		public void Sanitize(Scene scene, SceneImportOptions importOptions) {} // 0x000000018BC9E964-0x000000018BC9E98C
	}

	public class SanitizedCameraSample : CameraSample, ISanitizable // TypeDefIndex: 57636
	{
		// Constructors
		public SanitizedCameraSample() {} // 0x000000018BC9E98C-0x000000018BC9E994
	
		// Methods
		public void Sanitize(Scene scene, SceneImportOptions importOptions) {} // 0x000000018BC9E964-0x000000018BC9E98C
	}

	public class SanitizedMeshSample : MeshSample, ISanitizable, IRestorable // TypeDefIndex: 57637
	{
		// Fields
		internal int[] originalFaceVertexCounts; // 0xC0
		internal int[] originalFaceVertexIndices; // 0xC8
		internal bool arePrimvarsFaceVarying; // 0xD0
		internal int[] faceMapping; // 0xD8
		internal int[] triangulatedFaceVertexIndices; // 0xE0
		private bool isRestoredFromCachedData; // 0xE8
	
		// Constructors
		public SanitizedMeshSample() {} // 0x000000018BCA08C0-0x000000018BCA08C8
	
		// Methods
		public bool IsRestoredFromCachedData() => default; // 0x0000000185FB67C0-0x0000000185FB67D0
		public void FromCachedData(IRestorableData restorableData) {} // 0x000000018BC9F114-0x000000018BC9F1C0
		public IRestorableData ToCachedData() => default; // 0x000000018BCA001C-0x000000018BCA00A4
		public void BackupTopology() {} // 0x000000018BC9EB08-0x000000018BC9EC10
		public bool IsTopologyBackedUp() => default; // 0x000000018BC9F4B8-0x000000018BC9F4D4
		public void Sanitize(Scene scene, SceneImportOptions importOptions) {} // 0x000000018BC9F4D4-0x000000018BC9FE40
		internal void Triangulate(bool changeHandedness) {} // 0x000000018BCA00A4-0x000000018BCA0508
		internal bool ShouldUnweldVertices(bool bindMaterials) => default; // 0x000000018BC9FE40-0x000000018BCA0004
		internal bool AreAnyArbitraryPrimvarsFaceVarying() => default; // 0x000000018BC9E994-0x000000018BC9EB08
		internal static void Flatten<T>(ref ref T[] values, int[] indices) {}
		private void UnweldPrimvar(Primvar<object> primvar, bool changeHandedness) {} // 0x000000018BCA0508-0x000000018BCA08C0
		private static void FlattenPrimvar(Primvar<object> primvar) {} // 0x000000018BC9EF10-0x000000018BC9F114
		internal static void TriangulateAttributes<T>(ref ref T[] values, int[] faceVertexCounts, bool changeHandedness) {}
		private void ConvertInterpolationToFaceVarying<T>(ref ref T[] values, int[] vertexIndices, bool changeHandedness = false /* Metadata: 0x0207D9F7 */, TfToken interpolation = null) {}
		internal TfToken GuessInterpolation(int count) => default; // 0x000000018BC9F1C0-0x000000018BC9F318
		internal bool IsInterpolationValid(TfToken interpolation, int count) => default; // 0x000000018BC9F318-0x000000018BC9F4B8
		internal void UniformToFaceVarying<T>(ref ref T[] values, int vertexCount) {}
		private static void ComputeNormals(Vector3[] points, int[] faceVertexIndices, ref Vector3[] normals) {} // 0x000000018BC9EC10-0x000000018BC9EF10
		internal bool ShouldUnwindVertices(bool changeHandedness) => default; // 0x000000018BCA0004-0x000000018BCA001C
	}

	public static class ExportHelpers // TypeDefIndex: 57638
	{
		// Methods
		public static Scene InitForSave(string filePath) => default; // 0x000000018BC98B10-0x000000018BC98C68
		public static void ExportGameObjects(GameObject[] objects, Scene scene, BasisTransformation basisTransform, bool exportMonoBehaviours = false /* Metadata: 0x0207D9F8 */) {} // 0x000000018BC988A0-0x000000018BC98B10
	}

	public static class HierarchyBuilder // TypeDefIndex: 57645
	{
		// Fields
		private static readonly SdfPath kAbsoluteRootPath; // 0x00
	
		// Nested types
		private struct HierInfo // TypeDefIndex: 57639
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
	
		private struct ReadHierJob : IJobParallelFor // TypeDefIndex: 57640
		{
			// Fields
			public static HierInfo[] result; // 0x00
			public static Scene scene; // 0x08
			public static UsdSkelCache skelCache; // 0x10
			public static SdfPath[] paths; // 0x18
	
			// Methods
			public void Run() {} // 0x000000018BC992C4-0x000000018BC99C9C
			public void Execute(int index) {} // 0x000000018BC9AB84-0x000000018BC9AD18
		}
	
		private struct FindPathsJob : IJobParallelFor // TypeDefIndex: 57643
		{
			// Fields
			public static SdfPath usdRoot; // 0x00
			public static Scene scene; // 0x08
			public static SdfPath[][] results; // 0x10
			public static IQuery[] queries; // 0x18
	
			// Nested types
			public interface IQuery // TypeDefIndex: 57641
			{
				// Methods
				SdfPath[] Find(Scene scene, SdfPath usdRoot); // 0x000000018BC99C9C-0x000000018BC9AB84
			}
	
			public struct Query<T> : IQuery // TypeDefIndex: 57642
				where T : SampleBase, new()
			{
				// Methods
				public SdfPath[] Find(Scene scene, SdfPath usdRoot) => default; // 0x000000018BC9B650-0x000000018BC9B798
			}
	
			// Methods
			public void Run() {} // 0x000000018BC99234-0x000000018BC992C4
			public void Execute(int index) {} // 0x000000018BC9AD18-0x000000018BC9B064
		}
	
		[Serializable]
		private sealed class __c // TypeDefIndex: 57644
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<SdfPath[], bool> __9__4_0; // 0x08
			public static Func<SdfPath[], IEnumerable<SdfPath>> __9__4_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BC9BA1C-0x000000018BC9BFB8
			public __c() {} // 0x000000018BC9B798-0x000000018BC9BA1C
	
			// Methods
			internal bool _BeginReading_b__4_0(SdfPath[] i) => default; // 0x000000018BC9C2B0-0x000000018BC9C8D0
			internal IEnumerable<SdfPath> _BeginReading_b__4_1(SdfPath[] i) => default; // 0x000000018BC9B064-0x000000018BC9B3B0
		}
	
		// Constructors
		static HierarchyBuilder() {} // 0x00000001834A4750-0x00000001834A4760
	
		// Methods
		private static JobHandle BeginReading(Scene scene, SdfPath usdRoot, PrimMap map, SceneImportOptions options) => default; // 0x000000018BC9BFB8-0x000000018BC9C2B0
		private static HierInfo[] BuildObjectLists(Scene scene, GameObject unityRoot, SdfPath usdRoot, PrimMap map, SceneImportOptions options) => default; // 0x000000018BC98DFC-0x000000018BC9900C
		public static PrimMap BuildGameObjects(Scene scene, GameObject unityRoot, SdfPath usdRoot, IEnumerable<SdfPath> paths, PrimMap map, SceneImportOptions options) => default; // 0x000000018BC9900C-0x000000018BC99104
		private static bool IsVisible(UsdPrim usdPrim) => default; // 0x000000018BC99104-0x000000018BC99234
		private static void ApplySelfVisibility(GameObject go, UsdPrim usdPrim) {} // 0x000000018BC9B3B0-0x000000018BC9B650
		private static void CreateAncestors(SdfPath path, PrimMap map, GameObject unityRoot, SdfPath usdRoot, SceneImportOptions options, out GameObject parentGo) {
			parentGo = default;
		} // 0x000000018BC9C8D0-0x000000018BC9C920
		private static void ProcessPaths(HierInfo[] infos, Scene scene, GameObject unityRoot, SdfPath usdRoot, PrimMap map, SceneImportOptions options) {} // 0x000000018BC9E8F8-0x000000018BC9E964
		private static void PopulateSkelCache(ref HierInfo skelRootInfo, UsdSkelCache skelCache) {} // 0x000000018BC9E70C-0x000000018BC9E8F8
		private static void ReadSkeletonJoints(ref HierInfo skelRootInfo) {} // 0x000000018BC98D90-0x000000018BC98DFC
		private static void ExpandSkeleton(HierInfo info, GameObject unityRoot, SdfPath usdRoot, UsdPrim prim, PrimMap map, SceneImportOptions options) {} // 0x000000018BC98CE0-0x000000018BC98D90
		private static void ReadModelInfo(ref HierInfo info) {}
		private static void AddModelRoot(GameObject go, HierInfo info) {}
		private static void AddPayload(GameObject go, HierInfo info, SceneImportOptions options) {} // 0x000000018BCB0978-0x000000018BCB09DC
		private static void AddVariantSet(GameObject go, UsdPrim prim) {} // 0x0000000185492010-0x0000000185492020
		private static GameObject FindOrCreateGameObject(Transform parent, SdfPath path, Transform unityRoot, PrimMap primMap, SceneImportOptions options) => default; // 0x0000000182F7A4D0-0x0000000182F7A4E0
	}

	public static class ImportHelpers // TypeDefIndex: 57646
	{
		// Methods
		public static GameObject ImportSceneAsGameObject(Scene scene, GameObject parent = null, SceneImportOptions importOptions = null) => default; // 0x000000018BC9CBF8-0x000000018BC9CE60
		public static Scene InitForOpen(string path = "" /* Metadata: 0x0207D9F9 */, UsdStage.InitialLoadSet loadSet = UsdStage.InitialLoadSet.LoadNone /* Metadata: 0x0207D9FA */) => default; // 0x000000018BC9CE60-0x000000018BC9CED4
		private static SdfPath GetDefaultRoot(Scene scene) => default; // 0x000000018BC9CA28-0x000000018BC9CADC
		private static GameObject UsdToGameObject(GameObject parent, Scene scene, SceneImportOptions importOptions) => default; // 0x000000018BC9CED4-0x000000018BC9D0D4
		private static string GetObjectName(SdfPath rootPrimName, string path) => default; // 0x000000018BC9CADC-0x000000018BC9CB64
		private static string GetObjectName(string path) => default; // 0x000000018BC9CB64-0x000000018BC9CBB0
		private static string GetPrefabName(string path) => default; // 0x000000018BC9CBB0-0x000000018BC9CBF8
	}

	public interface IImportProcessUsd // TypeDefIndex: 57647
	{
		// Methods
		void ProcessUsd(Scene scene, SceneImportOptions sceneImportOptions);
	}

	public interface IImportPostProcessHierarchy // TypeDefIndex: 57648
	{
		// Methods
		void PostProcessHierarchy(PrimMap primMap, SceneImportOptions sceneImportOptions);
	}

	public interface IImportPostProcessComponents // TypeDefIndex: 57649
	{
		// Methods
		void PostProcessComponents(PrimMap primMap, SceneImportOptions sceneImportOptions);
	}

	public class PrimMap : IEnumerable<KeyValuePair<SdfPath, GameObject>> // TypeDefIndex: 57651
	{
		// Fields
		public UsdSkelCache SkelCache; // 0x10
		public Dictionary<SdfPath, UsdSkelBindingVector> SkelBindings; // 0x18
		public Dictionary<SdfPath, UsdSkelSkinningQuery> SkinningQueries; // 0x20
		public Dictionary<SdfPath, MeshImporter.GeometrySubsets> MeshSubsets; // 0x28
		private SdfPath[] _Cameras_k__BackingField; // 0x30
		private SdfPath[] _Meshes_k__BackingField; // 0x38
		private SdfPath[] _Cubes_k__BackingField; // 0x40
		private SdfPath[] _Spheres_k__BackingField; // 0x48
		private SdfPath[] _Xforms_k__BackingField; // 0x50
		private SdfPath[] _SkelRoots_k__BackingField; // 0x58
		private SdfPath[] _Skeletons_k__BackingField; // 0x60
		private SdfPath[] _Materials_k__BackingField; // 0x68
		private bool _ContainsPointInstances_k__BackingField; // 0x70
		private bool _HasErrors_k__BackingField; // 0x71
		private Dictionary<SdfPath, GameObject> m_prims; // 0x78
		private Dictionary<SdfPath, InstanceRoot> m_instanceRoots; // 0x80
		private HashSet<GameObject> m_instances; // 0x88
		private Dictionary<SdfPath, GameObject> m_masterRoots; // 0x90
	
		// Properties
		public SdfPath[] Cameras { get; set; } // 0x00000001813B51D0-0x00000001813B51E0 0x00000001864721F0-0x0000000186472200
		public SdfPath[] Meshes { get; set; } // 0x00000001813ECBC0-0x00000001813ECBD0 0x0000000185A16440-0x0000000185A16450
		public SdfPath[] Cubes { get; set; } // 0x00000001813FF010-0x00000001813FF020 0x0000000185F05C80-0x0000000185F05C90
		public SdfPath[] Spheres { get; set; } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
		public SdfPath[] Xforms { get; set; } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
		public SdfPath[] SkelRoots { get; set; } // 0x00000001813F1630-0x00000001813F1640 0x0000000186472DB0-0x0000000186472DC0
		public SdfPath[] Skeletons { get; set; } // 0x0000000185FB0530-0x0000000185FB0540 0x0000000185AE8FE0-0x0000000185AE8FF0
		public SdfPath[] Materials { get; set; } // 0x00000001813AC280-0x00000001813AC290 0x0000000185A62990-0x0000000185A629A0
		public bool ContainsPointInstances { get; set; } // 0x0000000185FB0950-0x0000000185FB0960 0x0000000185FB0970-0x0000000185FB0980
		public bool HasErrors { get; set; } // 0x0000000185FB3060-0x0000000185FB3070 0x0000000185FB3070-0x0000000185FB3080
		public GameObject this[SdfPath path] { get => default; set {} } // 0x000000018BC9E5BC-0x000000018BC9E6A8 0x000000018BC9E6A8-0x000000018BC9E70C
	
		// Nested types
		public struct InstanceRoot // TypeDefIndex: 57650
		{
			// Fields
			public GameObject gameObject; // 0x00
			public SdfPath masterPath; // 0x08
		}
	
		// Constructors
		public PrimMap() {} // 0x000000018BC9E3D0-0x000000018BC9E5BC
	
		// Methods
		public bool TryGetValue(SdfPath key, out GameObject obj) {
			obj = default;
			return default;
		} // 0x000000018BC9E36C-0x000000018BC9E3D0
		public IEnumerator GetEnumerator() => default; // 0x000000018BC9E1CC-0x000000018BC9E254
		IEnumerator<KeyValuePair<SdfPath, GameObject>> IEnumerable<KeyValuePair<SdfPath, GameObject>>.GetEnumerator() => default; // 0x000000018BC9E2E4-0x000000018BC9E36C
		public void AddInstance(GameObject goInst) {} // 0x000000018BC9DAF8-0x000000018BC9DB50
		public void AddMasterRoot(SdfPath path, GameObject go) {} // 0x000000018BC9DB50-0x000000018BC9DBC8
		public void AddInstanceRoot(SdfPath instancePath, GameObject go, SdfPath masterPath) {} // 0x000000018BC9DA4C-0x000000018BC9DAF8
		public Dictionary<SdfPath, GameObject> GetMasterRootPaths() => default; // 0x000000018BC9E29C-0x000000018BC9E2E4
		public Dictionary<SdfPath, InstanceRoot> GetInstanceRoots() => default; // 0x000000018BC9E254-0x000000018BC9E29C
		public void DestroyAll() {} // 0x000000018BC9DCF4-0x000000018BC9E1CC
		public void Clear() {} // 0x000000018BC9DBC8-0x000000018BC9DCF4
	}

	public delegate void ExportFunction(ObjectContext objContext, ExportContext exportContext); // TypeDefIndex: 57652; 0x0000000188B09B4C-0x0000000188B09B7C

	internal delegate void ObjectProcessor(GameObject go, ExportContext context); // TypeDefIndex: 57653; 0x00000001831C5680-0x00000001831C5690

	public struct ObjectContext // TypeDefIndex: 57654
	{
		// Fields
		public GameObject gameObject; // 0x00
		public string path; // 0x08
		public SampleBase sample; // 0x10
		public object additionalData; // 0x18
	}

	public enum ActiveExportPolicy // TypeDefIndex: 57655
	{
		ExportAsVisibility = 0,
		ExportAsActive = 1,
		DoNotExport = 2,
		Ignore = 3
	}

	public class ExportContext // TypeDefIndex: 57656
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
		public ExportContext() {} // 0x000000018BC98458-0x000000018BC98750
	}

	public class Exporter // TypeDefIndex: 57657
	{
		// Fields
		public string path; // 0x10
		public SampleBase sample; // 0x18
		public ExportFunction exportFunc; // 0x20
		public object data; // 0x28
	
		// Constructors
		public Exporter() {} // 0x0000000185492010-0x0000000185492020
	}

	public class ExportPlan // TypeDefIndex: 57658
	{
		// Fields
		public List<Exporter> exporters; // 0x10
	
		// Constructors
		public ExportPlan() {} // 0x000000018BC98C68-0x000000018BC98CE0
	}

	public static class SceneExporter // TypeDefIndex: 57660
	{
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 57659
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, string> __9__8_0; // 0x08
			public static Func<string, string> __9__8_1; // 0x10
	
			// Constructors
			static __c() {} // 0x000000018BCA22D4-0x000000018BCA2444
			public __c() {} // 0x000000018BCA1D40-0x000000018BCA22D4
	
			// Methods
			internal string _MergeBonesBelowAnimator_b__8_0(Transform boneXf) => default; // 0x000000018BCA1008-0x000000018BCA1D40
			internal string _MergeBonesBelowAnimator_b__8_1(string str) => default; // 0x000000018BCA4EB0-0x000000018BCA5084
		}
	
		// Methods
		public static void Export(GameObject root, Scene scene, BasisTransformation basisTransform, bool exportUnvarying, bool zeroRootTransform, bool exportMaterials = false /* Metadata: 0x0207D9FF */, bool exportMonoBehaviours = false /* Metadata: 0x0207DA00 */, bool exportOverrides = false /* Metadata: 0x0207DA01 */) {} // 0x000000018BCA08C8-0x000000018BCA0AC0
		public static void Export(GameObject root, ExportContext context, bool zeroRootTransform) {}
		private static void ExportImpl(GameObject root, ExportContext context) {} // 0x000000018BCA3C80-0x000000018BCA4EB0
		private static void Traverse(GameObject obj, ObjectProcessor processor, ExportContext context) {} // 0x000000018BCA2444-0x000000018BCA2E6C
		private static void AccumNestedBones(Transform curXf, List<Transform> children, ExportContext ctx) {} // 0x000000018BCA2E6C-0x000000018BCA3830
		private static T CreateSample<T>(ExportContext context)
			where T : SampleBase, new() => default; // 0x000000018BCA3830-0x000000018BCA3C80
		public static void SyncExportContext(GameObject exportRoot, ExportContext context) {} // 0x000000018BCA0C38-0x000000018BCA1008
		private static void InitExportableObjects(GameObject go, ExportContext context) {} // 0x000000018BCA0AC0-0x000000018BCA0C38
		private static Transform MergeBonesBelowAnimator(Transform animator, ExportContext context) => default; // 0x000000018BCB09DC-0x000000018BCB0A40
		private static void MergeBonesSimple(Transform source, Transform rootBone, Transform[] bones, Matrix4x4[] bindPoses, ExportContext context) {} // 0x0000000185492010-0x0000000185492020
		private static void CreateExportPlan(GameObject go, SampleBase sample, ExportFunction exportFunc, ExportContext context, string pathSuffix = null, bool insertFirst = true /* Metadata: 0x0207DA02 */) {} // 0x000000018BCB092C-0x000000018BCB0978
		private static Matrix4x4 ComputeWorldXf(Transform curBone, ExportContext context) => default; // 0x00000001834A4750-0x00000001834A4760
	}

	public interface IImporter // TypeDefIndex: 57661
	{
		// Methods
		void BeginReading(Scene scene, PrimMap primMap, SceneImportOptions importOptions);
		IEnumerator Import(Scene scene, PrimMap primMap, SceneImportOptions importOptions);
	}

	public static class SceneImporter // TypeDefIndex: 57664
	{
		// Fields
		public static IImporter ActiveMeshImporter; // 0x00
	
		// Nested types
		public class ImportException : Exception // TypeDefIndex: 57662
		{
			// Constructors
			public ImportException() {} // 0x000000018BCA56B4-0x000000018BCA57C4
			public ImportException(string message) {} // 0x000000018BCA52D4-0x000000018BCA5350
			public ImportException(string message, Exception innerException) {} // 0x000000018BCA5350-0x000000018BCA5584
		}
	
		private sealed class _BuildScene_d__8 : IEnumerator<object> // TypeDefIndex: 57663
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
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BCB0684-0x000000018BCB06D4 
			object IEnumerator.Current { get => default; } // 0x000000018BCB0724-0x000000018BCB0774 
	
			// Constructors
			public _BuildScene_d__8() {} // Dummy constructor
			public _BuildScene_d__8(int __1__state) {} // 0x000000018BCA525C-0x000000018BCA52D4
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BCA5084-0x000000018BCA51A0
			private bool MoveNext() => default;
			private void __m__Finally1() {} // 0x000000018BCA51A0-0x000000018BCA525C
			private void __m__Finally2() {} // 0x000000018BCA5678-0x000000018BCA56B4
			private void __m__Finally3() {} // 0x000000018BCA5640-0x000000018BCA5678
			private void __m__Finally4() {} // 0x000000018BCA5584-0x000000018BCA5640
			private void __m__Finally5() {} // 0x000000018BC9C920-0x000000018BC9C96C
			private void __m__Finally6() {} // 0x000000018BC9C9CC-0x000000018BC9CA28
			private void __m__Finally7() {} // 0x000000018BC9C96C-0x000000018BC9C9CC
			private void __m__Finally8() {} // 0x0000000181378230-0x0000000181378240
			private void __m__Finally9() {} // 0x000000018BCB0168-0x000000018BCB0634
			private void __m__Finally10() {} // 0x000000018BCA9BFC-0x000000018BCB011C
			void IEnumerator.Reset() {} // 0x000000018BCB06D4-0x000000018BCB0724
		}
	
		// Constructors
		static SceneImporter() {} // 0x000000018BCB0774-0x000000018BCB07C4
	
		// Methods
		public static void ImportUsd(GameObject goRoot, Scene scene, PrimMap primMap, SceneImportOptions importOptions) {} // 0x000000018BCB07C4-0x000000018BCB0814
		public static void ImportUsd(GameObject goRoot, Scene scene, PrimMap primMap, bool composingSubtree, SceneImportOptions importOptions) {} // 0x000000018BCB0814-0x000000018BCB0864
		private static UsdEditorAnalytics.ImportResult CreateImportResult(bool success, PrimMap primMap, ImportType importType = ImportType.Initial /* Metadata: 0x0207DA03 */) => default; // 0x000000018BCB0864-0x000000018BCB08B4
		public static PrimMap BuildScene(Scene scene, GameObject root, SceneImportOptions importOptions, PrimMap primMap, bool composingSubtree) => default; // 0x000000018BCB08B4-0x000000018BCB08F0
		private static void RemoveComponent<T>(GameObject go) {} // 0x000000018BCB08F0-0x000000018BCB092C
		public static IEnumerator BuildScene(Scene scene, GameObject root, SceneImportOptions importOptions, PrimMap primMap, float targetFrameMilliseconds, bool composingSubtree) => default; // 0x000000018BCB0634-0x000000018BCB0684
		private static bool ShouldYield(float targetTime, Stopwatch timer) => default; // 0x0000000181377E40-0x0000000181377E50
		private static void ResetTimer(Stopwatch timer) {} // 0x000000018BCB011C-0x000000018BCB0168
		private static bool IsSkinnedMesh(UsdPrim prim, PrimMap primMap, SceneImportOptions importOptions) => default; // 0x0000000181377E40-0x0000000181377E50
	}

	public enum PayloadPolicy // TypeDefIndex: 57665
	{
		DontLoadPayloads = 0,
		LoadAll = 1
	}

	public enum BasisTransformation // TypeDefIndex: 57666
	{
		FastWithNegativeScale = 0,
		SlowAndSafe = 1,
		SlowAndSafeAsFBX = 2,
		None = 3
	}

	[Serializable]
	public enum MaterialImportMode // TypeDefIndex: 57667
	{
		ImportPreviewSurface = 0,
		ImportDisplayColor = 1,
		None = 2
	}

	[Serializable]
	public class SceneImportOptions // TypeDefIndex: 57668
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
		private ImportType _ImportType_k__BackingField; // 0x58
	
		// Properties
		public bool ShouldBindMaterials { get => default; } // 0x00000001878618DC-0x00000001878618E4 
		public ImportType ImportType { get; set; } // 0x0000000183F80450-0x0000000183F80460 0x0000000183F804E0-0x0000000183F804F0
	
		// Constructors
		public SceneImportOptions() {} // 0x000000018BCB1334-0x000000018BCB1454
	}

	public class UsdzExporter // TypeDefIndex: 57669
	{
		// Constructors
		public UsdzExporter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void ExportUsdz(string usdzFilePath, GameObject root) {} // 0x000000018BCB65D8-0x000000018BCB6CE8
	}

	public static class SkeletonExporter // TypeDefIndex: 57670
	{
		// Methods
		public static void ExportSkeleton(ObjectContext objContext, ExportContext exportContext) {} // 0x000000018BCB21B8-0x000000018BCB2B0C
		public static void ExportSkelRoot(ObjectContext objContext, ExportContext exportContext) {} // 0x000000018BCB1D18-0x000000018BCB21B8
		public static void ExportSkelAnimation(ObjectContext objContext, ExportContext exportContext) {} // 0x000000018BCB1620-0x000000018BCB1D18
	}

	public static class SkeletonImporter // TypeDefIndex: 57671
	{
		// Methods
		public static void BuildSkeletonBone(string skelPath, GameObject go, Matrix4x4 restXform, VtTokenArray joints, SceneImportOptions importOptions) {} // 0x000000018BCB34B8-0x000000018BCB3928
		public static void BuildDebugBindTransforms(SkeletonSample skelSample, GameObject goSkeleton, SceneImportOptions options) {} // 0x000000018BCB2C18-0x000000018BCB34B8
		public static void BuildBindTransforms(string path, SkeletonSample skelSample, SceneImportOptions options) {} // 0x000000018BCB2B0C-0x000000018BCB2C18
		private static bool JointsMatch(string[] lhs, string[] rhs) => default; // 0x000000018BCB418C-0x000000018BCB4208
		public static void BuildSkinnedMesh(string meshPath, string skelPath, SkeletonSample skeleton, UsdSkelSkinningQuery skinningQuery, GameObject go, PrimMap primMap, SceneImportOptions options) {} // 0x000000018BCB3928-0x000000018BCB418C
	}

	public class UnitySkeleton // TypeDefIndex: 57672
	{
		// Fields
		public Transform rootBone; // 0x10
		public Transform[] bones; // 0x18
	
		// Constructors
		public UnitySkeleton() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class SkelBindingSample : SampleBase // TypeDefIndex: 57673
	{
		// Fields
		public string[] blendShapes; // 0x10
		public Relationship blendShapeTargets; // 0x18
		public Relationship animationSource; // 0x20
		public Relationship skeleton; // 0x28
		public string[] joints; // 0x30
		public Primvar<int[]> jointIndices; // 0x38
		public Primvar<Matrix4x4> geomBindTransform; // 0x40
		public Primvar<float[]> jointWeights; // 0x48
	
		// Constructors
		public SkelBindingSample() {} // 0x000000018BCB1454-0x000000018BCB15A4
	}

	[Serializable]
	public class SkelRootSample : BoundableSample // TypeDefIndex: 57674
	{
		// Fields
		public Relationship skeleton; // 0x78
		public Relationship animationSource; // 0x80
	
		// Constructors
		public SkelRootSample() {} // 0x000000018BCB15A4-0x000000018BCB1620
	}

	[Serializable]
	public class SkeletonSample : XformableSample // TypeDefIndex: 57675
	{
		// Fields
		public string[] joints; // 0x60
		public Matrix4x4[] bindTransforms; // 0x68
		public Matrix4x4[] restTransforms; // 0x70
	
		// Constructors
		public SkeletonSample() {} // 0x000000018BC9E98C-0x000000018BC9E994
	}

	[Serializable]
	public class SkelAnimationSample : SampleBase // TypeDefIndex: 57676
	{
		// Fields
		public string[] joints; // 0x10
		public Vector3[] translations; // 0x18
		public Quaternion[] rotations; // 0x20
		public VtVec3hArray scales; // 0x28
		public string[] blendShapes; // 0x30
		public float[] blendShapeWeights; // 0x38
	
		// Constructors
		public SkelAnimationSample() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class BlendShapeSample : SampleBase // TypeDefIndex: 57677
	{
		// Fields
		public Vector3[] offsets; // 0x10
		public uint[] pointIndices; // 0x18
	
		// Constructors
		public BlendShapeSample() {} // 0x0000000185492010-0x0000000185492020
	}

	public class SkeletonIo // TypeDefIndex: 57678
	{
		// Fields
		private Dictionary<Transform, Transform[]> m_bindings; // 0x10
	
		// Constructors
		public SkeletonIo() {} // 0x000000018BCB42C0-0x000000018BCB4338
	
		// Methods
		public Transform[] GetBones(Transform rootBone) => default; // 0x000000018BCB4208-0x000000018BCB425C
		public void RegisterSkeleton(Transform rootBone, Transform[] bones) {} // 0x000000018BCB425C-0x000000018BCB42C0
	}

	public class NativeExporter // TypeDefIndex: 57679
	{
		// Constructors
		public NativeExporter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void ExportObject(ObjectContext objContext, ExportContext exportContext) {} // 0x0000000185492010-0x0000000185492020
	}

	public class NativeImporter // TypeDefIndex: 57680
	{
		// Constructors
		public NativeImporter() {} // 0x0000000185492010-0x0000000185492020
	
		// Methods
		public static void ImportObject(Scene scene, GameObject go, UsdPrim usdPrim, SceneImportOptions options) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class UsdPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 57681
	{
		// Fields
		private UsdAsset m_sourceUsdAsset; // 0x18
		public ExposedReference<UsdAsset> SourceUsdAsset; // 0x20
	
		// Properties
		public ClipCaps clipCaps { get => default; } // 0x0000000185FB6D20-0x0000000185FB6D30 
		public override double duration { get => default; } // 0x000000018BCB4868-0x000000018BCB49C0 
	
		// Constructors
		public UsdPlayableAsset() {} // 0x0000000184BBD7B0-0x0000000184BBD7C0
	
		// Methods
		public UsdAsset GetUsdAsset(string usdRootPath) => default; // 0x000000018BCB483C-0x000000018BCB4868
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x000000018BCB4670-0x000000018BCB483C
	}

	public class UsdPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 57682
	{
		// Fields
		public UsdPlayableAsset playableAsset; // 0x10
		private bool m_errorOnce; // 0x18
	
		// Constructors
		public UsdPlayableBehaviour() {} // 0x0000000181B75280-0x0000000181B75290
	
		// Methods
		public override void OnGraphStart(Playable playable) {} // 0x000000018BCB49C0-0x000000018BCB49C8
		public override void OnGraphStop(Playable playable) {} // 0x0000000185492010-0x0000000185492020
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public override void PrepareFrame(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x000000018BCB49C8-0x000000018BCB4B48
		public override void PrepareData(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class UsdPlayableTrack : TrackAsset // TypeDefIndex: 57683
	{
		// Constructors
		public UsdPlayableTrack() {} // 0x000000018BCB4B84-0x000000018BCB4BD0
	
		// Methods
		protected override void OnCreateClip(TimelineClip clip) {} // 0x000000018BCB4B48-0x000000018BCB4B84
	}

	public class UsdRecorderBehaviour : PlayableBehaviour // TypeDefIndex: 57685
	{
		// Fields
		private const int kExportFrameRate = 60; // Metadata: 0x0207DA0D
		private bool m_isPaused; // 0x10
		public UsdRecorderClip Clip; // 0x18
		private string usdcFileName; // 0x20
		private string usdzFileName; // 0x28
		private string usdzFilePath; // 0x30
		private string currentDir; // 0x38
		private DirectoryInfo usdzTemporaryDir; // 0x40
		private GameObject _root; // 0x48
	
		// Nested types
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 57684
		{
			// Fields
			public UsdRecorderBehaviour __4__this; // 0x10
			public Playable playable; // 0x18
			public FrameData info; // 0x28
			public object playerData; // 0x68
	
			// Constructors
			public __c__DisplayClass17_0() {} // 0x000000018BCB4BD0-0x000000018BCB5784
	
			// Methods
			internal void _ProcessFrame_b__0() {} // 0x000000018BCB5C84-0x000000018BCB6068
		}
	
		// Constructors
		public UsdRecorderBehaviour() {} // 0x000000018BCB4338-0x000000018BCB43A0
	
		// Methods
		public void BeginRecording(double currentTime, GameObject root) {} // 0x000000018BCB5B00-0x000000018BCB5C84
		public void StopRecording(double currentTime) {} // 0x00000001840A27C0-0x00000001840A27D0
		private void ProcessRecording(double currentTime, GameObject root) {} // 0x0000000185492010-0x0000000185492020
		private bool IsPlaying() => default; // 0x000000018BCB598C-0x000000018BCB59E4
		public override void OnPlayableCreate(Playable playable) {} // 0x000000018BCB586C-0x000000018BCB5934
		public override void OnPlayableDestroy(Playable playable) {} // 0x000000018BCB5934-0x000000018BCB598C
		public override void OnGraphStart(Playable playable) {} // 0x000000018BCB59E4-0x000000018BCB5B00
		public override void OnGraphStop(Playable playable) {} // 0x0000000185FB6A70-0x0000000185FB6A80
		public override void ProcessFrame(Playable playable, FrameData info, object playerData) {} // 0x0000000181B9A230-0x0000000181B9A240
		public override void OnBehaviourPlay(Playable playable, FrameData info) {} // 0x000000018BCB5784-0x000000018BCB586C
		public override void OnBehaviourPause(Playable playable, FrameData info) {} // 0x0000000185492010-0x0000000185492020
		public void OnFrameEnd(Playable playable, FrameData info, object playerData) {} // 0x0000000185492010-0x0000000185492020
	}

	public class UsdRecorderClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 57686
	{
		// Fields
		public ExposedReference<GameObject> m_exportRoot; // 0x18
		private GameObject[] m_trackedRoots; // 0x28
		public bool m_exportMaterials; // 0x30
		public BasisTransformation m_convertHandedness; // 0x34
		public ActiveExportPolicy m_activePolicy; // 0x38
		public string m_usdFile; // 0x40
		private Scene _UsdScene_k__BackingField; // 0x48
		private ExportContext m_context; // 0x50
	
		// Properties
		public Scene UsdScene { get; set; } // 0x00000001813ECF20-0x00000001813ECF30 0x000000018571FEC0-0x000000018571FED0
		public ExportContext Context { get => default; set {} } // 0x0000000181460F60-0x0000000181460F70 0x0000000184A4E570-0x0000000184A4E580
		public ClipCaps clipCaps { get => default; } // 0x00000001813AE580-0x00000001813AE590 
		public bool IsUSDZ { get => default; } // 0x000000018BCB6250-0x000000018BCB62BC 
	
		// Constructors
		public UsdRecorderClip() {} // 0x000000018BCB61B4-0x000000018BCB6250
	
		// Methods
		public GameObject GetExportRoot(PlayableGraph graph) => default; // 0x000000018BCB6160-0x000000018BCB61B4
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) => default; // 0x000000018BCB6068-0x000000018BCB6160
		public virtual void OnDestroy() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class UsdRecorderTrack : TrackAsset // TypeDefIndex: 57687
	{
		// Constructors
		public UsdRecorderTrack() {} // 0x000000018BCB62BC-0x000000018BCB6308
	}

	internal class UsdWaitForEndOfFrame : MonoBehaviour // TypeDefIndex: 57689
	{
		// Fields
		private List<Action> m_pending; // 0x18
		private static UsdWaitForEndOfFrame s_instance; // 0x00
	
		// Nested types
		private sealed class _WaitForEndOfFrame_d__4 : IEnumerator<object> // TypeDefIndex: 57688
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UsdWaitForEndOfFrame __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { get => default; } // 0x000000018BCB64D8-0x000000018BCB64FC 
			object IEnumerator.Current { get => default; } // 0x0000000181378230-0x0000000181378240 
	
			// Constructors
			public _WaitForEndOfFrame_d__4() {} // Dummy constructor
			public _WaitForEndOfFrame_d__4(int __1__state) {} // 0x000000018BCB635C-0x000000018BCB64D8
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018BCB6308-0x000000018BCB635C
			private bool MoveNext() => default; // 0x000000018BCB64FC-0x000000018BCB6558
			void IEnumerator.Reset() {} // 0x000000018BCB6558-0x000000018BCB65D8
		}
	
		// Constructors
		public UsdWaitForEndOfFrame() {} // 0x0000000181377E40-0x0000000181377E50
	
		// Methods
		private static UsdWaitForEndOfFrame GetInstance() => default; // 0x0000000185492010-0x0000000185492020
		public static void Add(Action callback) {} // 0x000000018BCB43A0-0x000000018BCB4624
		private IEnumerator WaitForEndOfFrame() => default; // 0x0000000181377E40-0x0000000181377E50
		private void LateUpdate() {} // 0x000000018BCB4624-0x000000018BCB4670
	}
}
