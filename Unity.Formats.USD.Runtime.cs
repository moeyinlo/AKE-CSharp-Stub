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

// Image 47: Unity.Formats.USD.Runtime.dll - Assembly: Unity.Formats.USD.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 87306-87419

namespace Beyond.SourceGenerator
{
	internal static class AnimatorBlackboardUtility // TypeDefIndex: 87308
	{
		// Fields
		internal static bool s_enableFastPathBuffer; // 0x00
	
		// Methods
		internal static void ClearAndEnsureDictionaryCapacity<TKey, TValue>(ref Dictionary<TKey, TValue> dict, int capacity);
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class AnimatorBlackboardAttribute : Attribute // TypeDefIndex: 87309
	{
		// Constructors
		public AnimatorBlackboardAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class SwapRuntimeStateAttribute : Attribute // TypeDefIndex: 87310
	{
		// Constructors
		public SwapRuntimeStateAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Field)]
	internal class ResetOnSwapAttribute : Attribute // TypeDefIndex: 87311
	{
		// Constructors
		public ResetOnSwapAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class DataNAttribute : Attribute // TypeDefIndex: 87312
	{
		// Fields
		public int capacity; // 0x10
		public int tSize; // 0x14
		public bool ring; // 0x18
		public bool native; // 0x19
	
		// Constructors
		public DataNAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Struct)]
	internal class ECSComponentAttribute : Attribute // TypeDefIndex: 87313
	{
		// Fields
		public LayoutKind layoutKind; // 0x10
		public bool isTag; // 0x14
	
		// Constructors
		public ECSComponentAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[AttributeUsage(AttributeTargets.Class)]
	internal class CameraControlConfigAttribute : Attribute // TypeDefIndex: 87314
	{
		// Constructors
		public CameraControlConfigAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace HG.Rendering.Runtime
{
	[AttributeUsage(AttributeTargets.Struct)]
	internal class HGConstantBufferLayoutAttribute : Attribute // TypeDefIndex: 87307
	{
		// Constructors
		public HGConstantBufferLayoutAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}
}

namespace Unity.Formats.USD
{
	public class UsdAssemblyRoot : MonoBehaviour // TypeDefIndex: 87315
	{
		// Constructors
		public UsdAssemblyRoot(); // 0x00000001878364A0-0x00000001878364B8
	}

	[ExecuteInEditMode]
	public class UsdAsset : MonoBehaviour // TypeDefIndex: 87316
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
		public double Length { get; } // 0x000000018D2C1D00-0x000000018D2C1D08 
		public string usdFullPath { get; set; } // 0x000000018D2C1D08-0x000000018D2C1D80 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public UsdAsset(); // 0x000000018D2C1C44-0x000000018D2C1D00
	
		// Methods
		private void OnDestroy(); // 0x000000018D2BFBB0-0x000000018D2BFBF4
		private string GetPrefabAssetPath(GameObject root); // 0x0000000185829EC0-0x0000000185829ED0
		public void OptionsToState(SceneImportOptions options); // 0x000000018D2BFC60-0x000000018D2BFE9C
		public void StateToOptions(ref SceneImportOptions options); // 0x000000018D2C180C-0x000000018D2C1C04
		private bool SceneFileChanged(); // 0x000000018D2C02B0-0x000000018D2C03B0
		public Scene GetScene(); // 0x000000018D2BF6B0-0x000000018D2BF9DC
		private void OnReload(); // 0x000000018D2BFBF4-0x000000018D2BFC60
		private void DestroyComponent(UnityEngine.Component comp); // 0x000000018D2BF060-0x000000018D2BF0C0
		private void ClearLastData(); // 0x000000018D2BEE84-0x000000018D2BEECC
		public void RemoveAllUsdComponents(); // 0x000000018D2C00A8-0x000000018D2C02B0
		public void DestroyAllImportedObjects(); // 0x000000018D2BEF30-0x000000018D2BF060
		public void Reload(bool forceRebuild); // 0x000000018D2BFF20-0x000000018D2C00A8
		private UsdPrim GetFirstPrim(Scene scene); // 0x000000018D2BF614-0x000000018D2BF6B0
		public void ExportOverrides(Scene sceneInWhichToStoreTransforms); // 0x000000018D2BF0C0-0x000000018D2BF614
		private double ComputeLength(); // 0x000000018D2BEECC-0x000000018D2BEF30
		public void SetTime(double time, UsdAsset foreignRoot, bool saveMeshUpdates); // 0x000000018D2C09A0-0x000000018D2C1160
		private void Update(); // 0x000000018D2C1C04-0x000000018D2C1C44
		public static void PrepOptionsForTimeChange(ref SceneImportOptions options); // 0x000000018D2BFE9C-0x000000018D2BFF20
		public void ImportUsdAsCoroutine(GameObject goRoot, string usdFilePath, double time, SceneImportOptions importOptions, float targetFrameMilliseconds); // 0x000000018D2BF9DC-0x000000018D2BFBB0
		public void SetPayloadState(GameObject go, bool isLoaded); // 0x000000018D2C03B0-0x000000018D2C09A0
		private void ApplyVariantSelectionState(Scene scene, UsdVariantSet variants); // 0x000000018D2BEB3C-0x000000018D2BEE84
		public void SetVariantSelection(GameObject go, string usdPrimPath, Dictionary<string, string> selections); // 0x000000018D2C1160-0x000000018D2C180C
	}

	[RequireComponent(typeof(UsdAsset))]
	public class UsdLayerStack : MonoBehaviour // TypeDefIndex: 87317
	{
		// Fields
		public string m_targetLayer; // 0x18
		public string[] m_layerStack; // 0x20
		public string[] m_mutedLayers; // 0x28
	
		// Constructors
		public UsdLayerStack(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void SetupNewSubLayer(Scene parentScene, Scene subLayerScene); // 0x000000018D2C227C-0x000000018D2C230C
		public void SaveLayerStack(Scene scene, string[] layerStack); // 0x000000018D2C1D80-0x000000018D2C1F3C
		public void SaveToLayer(); // 0x000000018D2C1F3C-0x000000018D2C227C
	}

	public class UsdModelRoot : MonoBehaviour // TypeDefIndex: 87318
	{
		// Fields
		public string m_modelName; // 0x18
		public string m_modelVersion; // 0x20
		public string m_modelAssetPath; // 0x28
	
		// Constructors
		public UsdModelRoot(); // 0x00000001878364A0-0x00000001878364B8
	}

	[ExecuteInEditMode]
	public class UsdPayload : MonoBehaviour // TypeDefIndex: 87319
	{
		// Fields
		[SerializeField]
		private bool m_isLoaded; // 0x18
		[HideInInspector]
		[SerializeField]
		private bool m_wasLoaded; // 0x19
	
		// Properties
		public bool IsLoaded { get; } // 0x000000018225E050-0x000000018225E060 
	
		// Constructors
		public UsdPayload(); // 0x000000018D2C2398-0x000000018D2C23B4
	
		// Methods
		public void Load(); // 0x0000000187233970-0x0000000187233980
		public void Unload(); // 0x000000018723F9D0-0x000000018723F9E0
		public void SetInitialState(bool loaded); // 0x0000000187259680-0x0000000187259690
		public void Update(); // 0x000000018D2C230C-0x000000018D2C2398
	}

	public class UsdPrimSource : MonoBehaviour // TypeDefIndex: 87320
	{
		// Fields
		public string m_usdPrimPath; // 0x18
	
		// Constructors
		public UsdPrimSource(); // 0x00000001878364A0-0x00000001878364B8
	}

	public class UsdVariantSet : MonoBehaviour // TypeDefIndex: 87322
	{
		// Fields
		public string[] m_variantSetNames; // 0x18
		public string[] m_selected; // 0x20
		public string[] m_variants; // 0x28
		public int[] m_variantCounts; // 0x30
		public string m_primPath; // 0x38
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 87321
		{
			// Fields
			public UsdVariantSets variantSets; // 0x10
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _LoadFromUsd_b__0(string setName); // 0x000000018D2BEA58-0x000000018D2BEA78
			internal IEnumerable<string> _LoadFromUsd_b__1(string setName); // 0x000000018D2BEA78-0x000000018D2BEAA8
			internal int _LoadFromUsd_b__2(string setName); // 0x000000018D2BEAA8-0x000000018D2BEAE8
		}
	
		// Constructors
		public UsdVariantSet(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		public void LoadFromUsd(UsdPrim prim); // 0x000000018D2C2528-0x000000018D2C27B0
		public void ApplyVariantSelections(); // 0x000000018D2C23B4-0x000000018D2C2450
		public Dictionary<string, string> GetVariantSelections(); // 0x000000018D2C2450-0x000000018D2C2528
	}

	[ExecuteInEditMode]
	public class SkinnedMeshUnityDiff : MonoBehaviour // TypeDefIndex: 87323
	{
		// Fields
		[Tooltip("The USD skinned mesh to compare")]
		public SkinnedMeshRenderer m_usdMesh; // 0x18
		[Tooltip("The Unity skinned mesh to compare")]
		public SkinnedMeshRenderer m_unityMesh; // 0x20
	
		// Constructors
		public SkinnedMeshUnityDiff(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnEnable(); // 0x000000018D2BA674-0x000000018D2BB650
		private bool Approximately(Matrix4x4 rhs, Matrix4x4 lhs); // 0x000000018D2BA598-0x000000018D2BA648
		private bool WeightsMatch(BoneWeight w1, BoneWeight w2); // 0x000000018D2BB650-0x000000018D2BB750
		private bool IndicesMatch(BoneWeight w1, BoneWeight w2); // 0x000000018D2BA648-0x000000018D2BA674
		private void Update(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[ExecuteInEditMode]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class SkinnedMeshUsdDiff : MonoBehaviour // TypeDefIndex: 87324
	{
		// Fields
		[Tooltip("A path to a USD file for comparing weights")]
		public string m_usdFile; // 0x18
		[Tooltip("A prim path to the skinned mesh in the USD file")]
		public string m_usdMeshPath; // 0x20
		[Tooltip("How to convert transforms for comparison")]
		public BasisTransformation m_basisTransform; // 0x28
	
		// Constructors
		public SkinnedMeshUsdDiff(); // 0x00000001878364A0-0x00000001878364B8
	
		// Methods
		private void OnEnable(); // 0x000000018D2BB8F4-0x000000018D2BC7F4
		private string GetUsdBoneData<T>(int bone, int weightIndex, Primvar<T[]> primvar);
		private Scene GetScene(); // 0x000000018D2BB750-0x000000018D2BB8F4
		private SkelBindingSample ReadUsdWeights(Scene scene); // 0x000000018D2BCC18-0x000000018D2BCD34
		private SkeletonSample ReadUsdSkeleton(Scene scene, out string skelRootPath); // 0x000000018D2BC7F4-0x000000018D2BCC18
		private void Update(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public static class CameraExporter // TypeDefIndex: 87325
	{
		// Methods
		public static void ExportCamera(ObjectContext objContext, ExportContext exportContext); // 0x000000018D2AEF30-0x000000018D2AF1FC
	}

	public static class CameraImporter // TypeDefIndex: 87326
	{
		// Methods
		public static void BuildCamera(CameraSample usdCamera, GameObject go, SceneImportOptions options); // 0x000000018D2AF1FC-0x000000018D2AF2B4
	}

	public static class CubeImporter // TypeDefIndex: 87327
	{
		// Methods
		public static void BuildCube(CubeSample usdCube, GameObject go, SceneImportOptions options, bool skinnedMesh = false /* Metadata: 0x02646354 */); // 0x000000018D2AF2B4-0x000000018D2B0D88
		private static bool ShouldImport(ImportMode mode); // 0x000000018CC96D08-0x000000018CC96D18
		private static bool ShouldCompute(ImportMode mode); // 0x0000000188ED5C94-0x0000000188ED5CA4
	}

	public static class InstanceImporter // TypeDefIndex: 87328
	{
		// Methods
		public static void BuildSceneInstances(PrimMap primMap, SceneImportOptions options); // 0x000000018D2B36CC-0x000000018D2B3C54
		public static void BuildPointInstances(Scene scene, PrimMap primMap, string pointInstancerPath, PointInstancerSample sample, GameObject root, SceneImportOptions options); // 0x000000018D2B3070-0x000000018D2B36CC
		private static void EnableGpuInstancing(GameObject go); // 0x000000018D2B3C54-0x000000018D2B3EB8
	}

	public static class MeshExporter // TypeDefIndex: 87329
	{
		// Fields
		private static TfToken m_materialBindToken; // 0x00
		private static TfToken m_subMeshesToken; // 0x08
	
		// Constructors
		static MeshExporter(); // 0x000000018D2B7F6C-0x000000018D2B805C
	
		// Methods
		public static void ExportSkinnedMesh(ObjectContext objContext, ExportContext exportContext); // 0x000000018D2B7C58-0x000000018D2B7F6C
		private static void ExportSkelWeights(Scene scene, string path, Mesh unityMesh, Transform rootBone, Transform[] bones, string skeletonPath); // 0x000000018D2B76B8-0x000000018D2B7C58
		public static void ExportMesh(ObjectContext objContext, ExportContext exportContext); // 0x000000018D2B7584-0x000000018D2B76B8
		private static void ExportMesh(ObjectContext objContext, ExportContext exportContext, Mesh mesh, Material sharedMaterial, Material[] sharedMaterials, bool exportMeshPose = true /* Metadata: 0x02646355 */); // 0x000000018D2B613C-0x000000018D2B7584
	}

	public delegate void MeshImportFunction<T>(string path, T sample, MeshImporter.GeometrySubsets subsets, GameObject go, SceneImportOptions option, bool isDynamic, UsdSkelSkinningQuery query = null); // TypeDefIndex: 87330; 0x00000000-0x00000000

	public class MeshImportStrategy : IImporter // TypeDefIndex: 87332
	{
		// Fields
		private MeshImportFunction<SanitizedMeshSample> m_meshImporter; // 0x10
		private MeshImportFunction<SanitizedMeshSample> m_skinnedMeshImporter; // 0x18
		private ReadAllJob<SanitizedMeshSample> m_readMeshesJob; // 0x20
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Import_d__5 : IEnumerator<object> // TypeDefIndex: 87331
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _Import_d__5(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D2BE958-0x000000018D2BE9D0
			private bool MoveNext(); // 0x000000018D2BD35C-0x000000018D2BE90C
			private void __m__Finally1(); // 0x000000018D2BE9D0-0x000000018D2BEA24
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D2BE90C-0x000000018D2BE958
		}
	
		// Constructors
		public MeshImportStrategy(MeshImportFunction<SanitizedMeshSample> meshImporter, MeshImportFunction<SanitizedMeshSample> skinnedMeshImporter); // 0x0000000185381AC0-0x0000000185381AF0
	
		// Methods
		public void BeginReading(Scene scene, PrimMap primMap, SceneImportOptions importOptions); // 0x000000018D2B805C-0x000000018D2B8128
		[IteratorStateMachine(typeof(_Import_d__5))]
		public IEnumerator Import(Scene scene, PrimMap primMap, SceneImportOptions importOptions); // 0x000000018D2B8128-0x000000018D2B81D4
	}

	public static class MeshImporter // TypeDefIndex: 87336
	{
		// Nested types
		public class GeometrySubsets // TypeDefIndex: 87333
		{
			// Fields
			[CompilerGenerated]
			private Dictionary<string, int[]> _Subsets_k__BackingField; // 0x10
	
			// Properties
			public Dictionary<string, int[]> Subsets { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
			// Constructors
			public GeometrySubsets(); // 0x000000018D2B0D88-0x000000018D2B0E00
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_0 // TypeDefIndex: 87334
		{
			// Fields
			public Mesh unityMesh; // 0x10
			public Renderer renderer; // 0x18
			public string path; // 0x20
			public SanitizedMeshSample usdMesh; // 0x28
	
			// Constructors
			public __c__DisplayClass5_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _BuildMesh__b__0(Scene scene, Material boundMat, List<string> primvars); // 0x000000018D2BEA24-0x000000018D2BEA58
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass5_1 // TypeDefIndex: 87335
		{
			// Fields
			public int idx; // 0x10
			public __c__DisplayClass5_0 CS___8__locals1; // 0x18
	
			// Constructors
			public __c__DisplayClass5_1(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _BuildMesh__b__1(Scene scene, Material boundMat, List<string> primvars); // 0x000000018D2BEAE8-0x000000018D2BEB3C
		}
	
		// Methods
		public static GeometrySubsets ReadGeomSubsets(Scene scene, string path); // 0x000000018D2BA118-0x000000018D2BA4D0
		public static void BuildSkinnedMesh(string path, SanitizedMeshSample usdMesh, GeometrySubsets geomSubsets, GameObject go, SceneImportOptions options, bool isDynamic, UsdSkelSkinningQuery skinningQuery = null); // 0x000000018D2B94AC-0x000000018D2B9674
		public static void ImportSkinning(string path, SanitizedMeshSample usdMesh, Mesh unityMesh, UsdSkelSkinningQuery skinningQuery); // 0x000000018D2B9674-0x000000018D2B9CC8
		public static void BuildMesh(string path, SanitizedMeshSample usdMesh, GeometrySubsets geomSubsets, GameObject go, SceneImportOptions options, bool isDynamic, UsdSkelSkinningQuery skinQuery = null); // 0x000000018D2B92F0-0x000000018D2B94AC
		private static void BuildMesh_(string path, SanitizedMeshSample usdMesh, Mesh unityMesh, GeometrySubsets geomSubsets, GameObject go, Renderer renderer, SceneImportOptions options); // 0x000000018D2B82CC-0x000000018D2B92F0
		private static void LoadPrimvars(Mesh unityMesh, string usdMeshPath, List<string> primvars, MeshSample sample); // 0x000000018D2B9E80-0x000000018D2BA118
		private static void BindMat(Mesh unityMesh, Material mat, Renderer renderer, string usdMeshPath, List<string> primvars, MeshSample sample); // 0x000000018D2B8278-0x000000018D2B82CC
		private static void BindMat(Mesh unityMesh, Material mat, Renderer renderer, int index, string usdMeshPath, List<string> primvars, MeshSample sample); // 0x000000018D2B81D4-0x000000018D2B8278
		private static T[] TryGetPrimvarValue<T>(Primvar<object> primvar);
		private static void ImportUv(Mesh unityMesh, int uvSetIndex, Primvar<object> uv); // 0x000000018D2B9CC8-0x000000018D2B9E80
		public static bool ShouldImport(ImportMode mode); // 0x000000018CC96D08-0x000000018CC96D18
		public static bool ShouldCompute(ImportMode mode); // 0x0000000188ED5C94-0x0000000188ED5CA4
		private static string UniqueMeshName(string meshName); // 0x000000018D2BA4D0-0x000000018D2BA598
	}

	public enum ImportMode // TypeDefIndex: 87337
	{
		Import = 0,
		ImportOrCompute = 1,
		Compute = 2,
		Ignore = 3
	}

	[Serializable]
	public class MeshImportOptions // TypeDefIndex: 87338
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
		public MeshImportOptions(); // 0x0000000187259640-0x0000000187259680
	}

	public static class SphereImporter // TypeDefIndex: 87339
	{
		// Methods
		public static void BuildSphere(SphereSample usdSphere, GameObject go, SceneImportOptions options, bool skinnedMesh = false /* Metadata: 0x0264635A */); // 0x000000018D2BCD34-0x000000018D2BD35C
		private static bool ShouldImport(ImportMode mode); // 0x000000018CC96D08-0x000000018CC96D18
		private static bool ShouldCompute(ImportMode mode); // 0x0000000188ED5C94-0x0000000188ED5CA4
	}

	public static class XformExporter // TypeDefIndex: 87340
	{
		// Methods
		public static void ExportXform(ObjectContext objContext, ExportContext exportContext); // 0x000000018D2C27B0-0x000000018D2C2A3C
		public static void WriteSparseOverrides(Scene scene, PrimMap primMap, BasisTransformation changeHandedness, float tolerance = 0.0001f /* Metadata: 0x0264635B */); // 0x000000018D2C2D14-0x000000018D2C3038
		public static Matrix4x4 GetLocalTransformMatrix(Transform tr, bool correctZUp, bool isRootPrim, BasisTransformation conversionType); // 0x000000018D2C2A3C-0x000000018D2C2D14
	}

	public static class XformImporter // TypeDefIndex: 87341
	{
		// Methods
		public static void BuildXform(SdfPath path, XformableSample usdXf, GameObject go, SceneImportOptions options, Scene scene); // 0x000000018D2C3578-0x000000018D2C36FC
		public static void BuildXform(Matrix4x4 xf, GameObject go, SceneImportOptions options); // 0x000000018D2C33D4-0x000000018D2C3578
		public static void ImportXform(ref Matrix4x4 mat, SceneImportOptions options); // 0x000000018D2C36FC-0x000000018D2C37E4
		public static void BuildSceneRoot(Scene scene, Transform root, SceneImportOptions options); // 0x000000018D2C3038-0x000000018D2C33D4
		public static void UndoRootTransform(Scene scene, UsdAsset stageRoot, ref Vector3 localScale, ref Quaternion localRotation); // 0x000000018D2C37E4-0x000000018D2C39C8
	}

	public static class ImporterBase // TypeDefIndex: 87342
	{
		// Methods
		public static string MakeRelativePath(string anchorPath, string pathToMakeRelative); // 0x000000018D2B2BD4-0x000000018D2B2E58
		public static bool ApproximatelyEqual(Matrix4x4 lhs, Matrix4x4 rhs); // 0x000000018D2B2B20-0x000000018D2B2BD4
		public static void MoveComponentFirst(UnityEngine.Component comp); // 0x000000018D2B2E58-0x000000018D2B2EAC
		public static void MoveComponentLast(UnityEngine.Component comp); // 0x000000018D2B2EAC-0x000000018D2B2F00
		public static T GetOrAddComponent<T>(GameObject go, bool insertFirst = false /* Metadata: 0x0264635F */)
			where T : UnityEngine.Component;
		public static string SafeGetDirectoryName(string fullPath); // 0x000000018D2B2F00-0x000000018D2B3070
	}

	public class HdrpShaderExporter : ShaderExporterBase // TypeDefIndex: 87343
	{
		// Constructors
		public HdrpShaderExporter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void ExportLit(Scene scene, string usdShaderPath, Material material, PreviewSurfaceSample surface, string destTexturePath); // 0x000000018D2B0E00-0x000000018D2B1DE0
	}

	public class HdrpShaderImporter : ShaderImporterBase // TypeDefIndex: 87344
	{
		// Fields
		private static Material ChannelCombinerMat; // 0x00
	
		// Constructors
		public HdrpShaderImporter(Material material); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void ImportFromUsd(); // 0x000000018D2B24F4-0x000000018D2B2B20
		private static Texture2D BuildMaskMap(Texture2D red, Texture2D green, Texture2D blue, Texture2D alpha); // 0x000000018D2B1DE0-0x000000018D2B24F4
	}

	public static class MaterialExporter // TypeDefIndex: 87346
	{
		// Fields
		public static readonly string kStandardFallbackHandler; // 0x00
		public static readonly string kHdrpFallbackHandler; // 0x08
		public static readonly string kLwrpFallbackHandler; // 0x10
		public static Dictionary<string, ExportHandler> ExportRegistry; // 0x18
	
		// Nested types
		public delegate void ExportHandler(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // TypeDefIndex: 87345; 0x00000001812083C0-0x00000001812083E0
	
		// Constructors
		static MaterialExporter(); // 0x000000018D2B43E0-0x000000018D2B4A88
	
		// Methods
		public static void ExportMaterial(Scene scene, Material mat, string usdMaterialPath); // 0x000000018D2B3EB8-0x000000018D2B43E0
	}

	public static class MaterialImporter // TypeDefIndex: 87348
	{
		// Fields
		private static readonly TfToken materialBindToken; // 0x00
		private static Material AlbedoGlossCombiner; // 0x08
		public static TextureResolver OnResolveTexture; // 0x10
	
		// Nested types
		public delegate Texture2D TextureResolver(SdfAssetPath textureAssetPath, bool isNormalMap, SceneImportOptions importOptions); // TypeDefIndex: 87347; 0x00000001811DF7F0-0x00000001811DF810
	
		// Constructors
		static MaterialImporter(); // 0x000000018D2B60AC-0x000000018D2B613C
	
		// Methods
		public static void ProcessMaterialBindings(Scene scene, SceneImportOptions importOptions); // 0x000000018D2B5B80-0x000000018D2B60AC
		public static Material BuildMaterial(Scene scene, string materialPath, MaterialSample sample, SceneImportOptions options); // 0x000000018D2B4A88-0x000000018D2B565C
		public static Texture2D ImportConnectedTexture<T>(Scene scene, Connectable<T> connection, bool isNormalMap, SceneImportOptions options, out string uvPrimvar);
		private static Texture2D DefaultTextureResolver(SdfAssetPath textureAssetPath, bool isNormalMap, SceneImportOptions options); // 0x0000000185829EC0-0x0000000185829ED0
		public static Texture2D CombineRoughness(Texture2D rgbTex, Texture2D roughnessTex, string fileNameSuffix); // 0x000000018D2B565C-0x000000018D2B5964
		public static UnityPreviewSurfaceSample GetSurfaceShaderPrim(Scene scene, string primPath); // 0x000000018D2B5964-0x000000018D2B5B80
	}

	public class MaterialMap : IEnumerable<KeyValuePair<string, Material>> // TypeDefIndex: 87350
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
		public Material DisplayColorMaterial { get; set; } // 0x000000018D2C89C0-0x000000018D2C8A24 0x0000000186AB5C00-0x0000000186AB5C10
		public Material SpecularWorkflowMaterial { get; set; } // 0x000000018D2C8AF8-0x000000018D2C8B5C 0x00000001870EAAD0-0x00000001870EAAE0
		public Material MetallicWorkflowMaterial { get; set; } // 0x000000018D2C8A94-0x000000018D2C8AF8 0x0000000185B68F50-0x0000000185B68F60
		public Material this[string path] { get => default; set {} } // 0x000000018D2C8A24-0x000000018D2C8A94 0x000000018D2C8B5C-0x000000018D2C8BC0
	
		// Nested types
		public delegate void MaterialBinder(Scene scene, Material mat, List<string> uvPrimvars); // TypeDefIndex: 87349; 0x00000001811DF7F0-0x00000001811DF810
	
		// Constructors
		public MaterialMap(); // 0x000000018D2C8868-0x000000018D2C89C0
	
		// Methods
		private void InstantiateMaterials(); // 0x000000018D2C842C-0x000000018D2C85FC
		public Dictionary<string, MaterialBinder> ClearRequestedBindings(); // 0x000000018D2C82F4-0x000000018D2C837C
		public void RequestBinding(string usdPath, MaterialBinder binder); // 0x000000018D2C8718-0x000000018D2C877C
		public List<string> GetPrimvars(string materialPath); // 0x000000018D2C83C4-0x000000018D2C842C
		public void SetPrimvars(string materialPath, List<string> primvars); // 0x000000018D2C877C-0x000000018D2C87E0
		public Material InstantiateSolidColor(UnityEngine.Color color); // 0x000000018D2C85FC-0x000000018D2C8718
		public static void AssignColor(Material material, UnityEngine.Color color); // 0x000000018D2C8240-0x000000018D2C82F4
		public IEnumerator GetEnumerator(); // 0x000000018D2C837C-0x000000018D2C83C4
		IEnumerator<KeyValuePair<string, Material>> IEnumerable<KeyValuePair<string, Material>>.GetEnumerator(); // 0x000000018D2C87E0-0x000000018D2C8868
	}

	public class ShaderExporterBase // TypeDefIndex: 87352
	{
		// Fields
		private static Material _metalGlossChannelSwapMaterial; // 0x00
		private static Material _normalChannelMaterial; // 0x08
	
		// Nested types
		public enum ConversionType // TypeDefIndex: 87351
		{
			None = 0,
			SwapRASmoothnessToBGRoughness = 1,
			InvertAlpha = 2,
			UnpackNormal = 3,
			MaskMapToORM = 4,
			RemoveAlpha = 5
		}
	
		// Constructors
		public ShaderExporterBase(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		protected static string SetupTexture(Scene scene, string usdShaderPath, Material material, PreviewSurfaceSample surface, Vector4 scale, string destTexturePath, string textureName, string textureOutput, ConversionType conversionType = ConversionType.None /* Metadata: 0x02646360 */); // 0x000000018D2D0210-0x000000018D2D1664
	}

	public abstract class ShaderImporterBase // TypeDefIndex: 87354
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
		public Material Material { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
		public bool IsSpecularWorkflow { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018225E050-0x000000018225E060 0x000000018225E060-0x000000018225E070
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass34_0 // TypeDefIndex: 87353
		{
			// Fields
			public string localName; // 0x10
	
			// Constructors
			public __c__DisplayClass34_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _MergePrimvars_b__0(string str); // 0x000000018D2DB0F8-0x000000018D2DB10C
		}
	
		// Constructors
		public ShaderImporterBase(Material material); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public abstract void ImportFromUsd();
		protected void ImportColorOrMap(Scene scene, Connectable<Vector3> usdParam, bool isNormalMap, SceneImportOptions options, ref Texture2D map, ref UnityEngine.Color? value, out string uvPrimvar); // 0x000000018D2D1664-0x000000018D2D17BC
		protected void ImportValueOrMap<T>(Scene scene, Connectable<T> usdParam, bool isNormalMap, SceneImportOptions options, ref Texture2D map, ref T? value, out string uvPrimvar)
			where T : struct;
		private void MergePrimvars(string newPrimvar, List<string> primvars); // 0x000000018D2D1C5C-0x000000018D2D1D64
		public virtual void ImportParametersFromUsd(Scene scene, string materialPath, MaterialSample materialSample, PreviewSurfaceSample previewSurf, SceneImportOptions options); // 0x000000018D2D17BC-0x000000018D2D1C5C
	}

	public class StandardShaderExporter : ShaderExporterBase // TypeDefIndex: 87356
	{
		// Nested types
		private enum StandardShaderBlendMode // TypeDefIndex: 87355
		{
			Opaque = 0,
			Cutout = 1,
			Fade = 2,
			Transparent = 3
		}
	
		// Constructors
		public StandardShaderExporter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void ExportStandardSpecular(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // 0x000000018D2D327C-0x000000018D2D3584
		public static void ExportStandardRoughness(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // 0x000000018D2D2E28-0x000000018D2D327C
		public static void ExportStandard(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // 0x000000018D2D3584-0x000000018D2D38C4
		public static void ExportGeneric(Scene scene, string usdShaderPath, Material material, UnityPreviewSurfaceSample surface, string destTexturePath); // 0x000000018D2D1D64-0x000000018D2D23F4
		private static void ExportStandardCommon(Scene scene, string usdShaderPath, Material mat, UnityPreviewSurfaceSample surface, string destTexturePath); // 0x000000018D2D23F4-0x000000018D2D2E28
		private static bool ShouldUseSpecularWorkflow(Material material); // 0x000000018D2D38C4-0x000000018D2D39F8
	}

	public class StandardShaderImporter : ShaderImporterBase // TypeDefIndex: 87357
	{
		// Constructors
		public StandardShaderImporter(Material material); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void ImportFromUsd(); // 0x000000018D2D39F8-0x000000018D2D416C
	}

	public class UnityMaterialData : SampleBase // TypeDefIndex: 87358
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
		public UnityMaterialData(); // 0x000000018D2DB1D4-0x000000018D2DB2E0
	}

	public class UnityPreviewSurfaceSample : PreviewSurfaceSample // TypeDefIndex: 87359
	{
		// Fields
		[UsdNamespace("unity")]
		public UnityMaterialData unity; // 0x90
	
		// Constructors
		public UnityPreviewSurfaceSample(); // 0x000000018D2DB2E0-0x000000018D2DB354
	}

	public class UrpShaderImporter : ShaderImporterBase // TypeDefIndex: 87360
	{
		// Constructors
		public UrpShaderImporter(Material material); // 0x0000000184FD2410-0x0000000184FD2420
	
		// Methods
		public override void ImportFromUsd(); // 0x000000018D2DB354-0x000000018D2DBAC0
	}

	public struct ReadAllJob<T> : IEnumerator<SampleEnumerator<T>>, IEnumerable<SampleEnumerator<T>>, IJobParallelFor // TypeDefIndex: 87361
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

	public interface IRestorable // TypeDefIndex: 87362
	{
		// Methods
		bool IsRestoredFromCachedData();
		void FromCachedData(IRestorableData data);
		IRestorableData ToCachedData();
	}

	public interface ISanitizable // TypeDefIndex: 87363
	{
		// Methods
		void Sanitize(Scene scene, SceneImportOptions importOptions);
	}

	public class MeshStaticPropertiesData : IRestorableData // TypeDefIndex: 87364
	{
		// Fields
		internal int[] originalFaceVertexCounts; // 0x10
		internal int[] originalFaceVertexIndices; // 0x18
		internal bool arePrimvarsFaceVarying; // 0x20
		internal Orientation orientation; // 0x24
	
		// Constructors
		public MeshStaticPropertiesData(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class SanitizedXformSample : XformSample, ISanitizable // TypeDefIndex: 87365
	{
		// Constructors
		public SanitizedXformSample(); // 0x000000018D2C9B30-0x000000018D2C9B38
	
		// Methods
		public void Sanitize(Scene scene, SceneImportOptions importOptions); // 0x000000018D2C9B08-0x000000018D2C9B30
	}

	public class SanitizedCameraSample : CameraSample, ISanitizable // TypeDefIndex: 87366
	{
		// Constructors
		public SanitizedCameraSample(); // 0x000000018D2C9B30-0x000000018D2C9B38
	
		// Methods
		public void Sanitize(Scene scene, SceneImportOptions importOptions); // 0x000000018D2C9B08-0x000000018D2C9B30
	}

	public class SanitizedMeshSample : MeshSample, ISanitizable, IRestorable // TypeDefIndex: 87367
	{
		// Fields
		internal int[] originalFaceVertexCounts; // 0xC0
		internal int[] originalFaceVertexIndices; // 0xC8
		internal bool arePrimvarsFaceVarying; // 0xD0
		internal int[] faceMapping; // 0xD8
		internal int[] triangulatedFaceVertexIndices; // 0xE0
		private bool isRestoredFromCachedData; // 0xE8
	
		// Constructors
		public SanitizedMeshSample(); // 0x000000018D2CBBB8-0x000000018D2CBBC0
	
		// Methods
		public bool IsRestoredFromCachedData(); // 0x000000018299E130-0x000000018299E140
		public void FromCachedData(IRestorableData restorableData); // 0x000000018D2CA300-0x000000018D2CA3AC
		public IRestorableData ToCachedData(); // 0x000000018D2CB230-0x000000018D2CB2B8
		public void BackupTopology(); // 0x000000018D2C9CC0-0x000000018D2C9DD0
		public bool IsTopologyBackedUp(); // 0x000000018D2CA6A4-0x000000018D2CA6C0
		public void Sanitize(Scene scene, SceneImportOptions importOptions); // 0x000000018D2CA6C0-0x000000018D2CB054
		internal void Triangulate(bool changeHandedness); // 0x000000018D2CB2B8-0x000000018D2CB7E0
		internal bool ShouldUnweldVertices(bool bindMaterials); // 0x000000018D2CB054-0x000000018D2CB218
		internal bool AreAnyArbitraryPrimvarsFaceVarying(); // 0x000000018D2C9B38-0x000000018D2C9CC0
		internal static void Flatten<T>(ref ref T[] values, int[] indices);
		private void UnweldPrimvar(Primvar<object> primvar, bool changeHandedness); // 0x000000018D2CB7E0-0x000000018D2CBBB8
		private static void FlattenPrimvar(Primvar<object> primvar); // 0x000000018D2CA0E0-0x000000018D2CA300
		internal static void TriangulateAttributes<T>(ref ref T[] values, int[] faceVertexCounts, bool changeHandedness);
		private void ConvertInterpolationToFaceVarying<T>(ref ref T[] values, int[] vertexIndices, bool changeHandedness = false /* Metadata: 0x0264636B */, TfToken interpolation = null);
		internal TfToken GuessInterpolation(int count); // 0x000000018D2CA3AC-0x000000018D2CA504
		internal bool IsInterpolationValid(TfToken interpolation, int count); // 0x000000018D2CA504-0x000000018D2CA6A4
		internal void UniformToFaceVarying<T>(ref ref T[] values, int vertexCount);
		private static void ComputeNormals(Vector3[] points, int[] faceVertexIndices, ref Vector3[] normals); // 0x000000018D2C9DD0-0x000000018D2CA0E0
		internal bool ShouldUnwindVertices(bool changeHandedness); // 0x000000018D2CB218-0x000000018D2CB230
	}

	public static class ExportHelpers // TypeDefIndex: 87368
	{
		// Methods
		public static Scene InitForSave(string filePath); // 0x000000018D2C3FB4-0x000000018D2C410C
		public static void ExportGameObjects(GameObject[] objects, Scene scene, BasisTransformation basisTransform, bool exportMonoBehaviours = false /* Metadata: 0x0264636C */); // 0x000000018D2C3D48-0x000000018D2C3FB4
	}

	public static class HierarchyBuilder // TypeDefIndex: 87375
	{
		// Fields
		private static readonly SdfPath kAbsoluteRootPath; // 0x00
	
		// Nested types
		private struct HierInfo // TypeDefIndex: 87369
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
	
		private struct ReadHierJob : IJobParallelFor // TypeDefIndex: 87370
		{
			// Fields
			public static HierInfo[] result; // 0x00
			public static Scene scene; // 0x08
			public static UsdSkelCache skelCache; // 0x10
			public static SdfPath[] paths; // 0x18
	
			// Methods
			public void Run(); // 0x000000018D2C9A9C-0x000000018D2C9B08
			public void Execute(int index); // 0x000000018D2C98B0-0x000000018D2C9A9C
		}
	
		private struct FindPathsJob : IJobParallelFor // TypeDefIndex: 87373
		{
			// Fields
			public static SdfPath usdRoot; // 0x00
			public static Scene scene; // 0x08
			public static SdfPath[][] results; // 0x10
			public static IQuery[] queries; // 0x18
	
			// Nested types
			public interface IQuery // TypeDefIndex: 87371
			{
				// Methods
				SdfPath[] Find(Scene scene, SdfPath usdRoot);
			}
	
			public struct Query<T> : IQuery // TypeDefIndex: 87372
				where T : SampleBase, new()
			{
				// Methods
				public SdfPath[] Find(Scene scene, SdfPath usdRoot);
			}
	
			// Methods
			public void Run(); // 0x000000018D2C4288-0x000000018D2C42F4
			public void Execute(int index); // 0x000000018D2C4184-0x000000018D2C4288
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 87374
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<SdfPath[], bool> __9__4_0; // 0x08
			public static Func<SdfPath[], IEnumerable<SdfPath>> __9__4_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D2DB10C-0x000000018D2DB170
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _BeginReading_b__4_0(SdfPath[] i); // 0x00000001894D8534-0x00000001894D853C
			internal IEnumerable<SdfPath> _BeginReading_b__4_1(SdfPath[] i); // 0x000000018459BB50-0x000000018459BB60
		}
	
		// Constructors
		static HierarchyBuilder(); // 0x000000018D2C7B20-0x000000018D2C7B70
	
		// Methods
		private static JobHandle BeginReading(Scene scene, SdfPath usdRoot, PrimMap map, SceneImportOptions options); // 0x000000018D2C47BC-0x000000018D2C5198
		private static HierInfo[] BuildObjectLists(Scene scene, GameObject unityRoot, SdfPath usdRoot, PrimMap map, SceneImportOptions options); // 0x000000018D2C5ED8-0x000000018D2C6074
		public static PrimMap BuildGameObjects(Scene scene, GameObject unityRoot, SdfPath usdRoot, IEnumerable<SdfPath> paths, PrimMap map, SceneImportOptions options); // 0x000000018D2C5198-0x000000018D2C5ED8
		private static bool IsVisible(UsdPrim usdPrim); // 0x000000018D2C6930-0x000000018D2C6A78
		private static void ApplySelfVisibility(GameObject go, UsdPrim usdPrim); // 0x000000018D2C472C-0x000000018D2C47BC
		private static void CreateAncestors(SdfPath path, PrimMap map, GameObject unityRoot, SdfPath usdRoot, SceneImportOptions options, out GameObject parentGo); // 0x000000018D2C6074-0x000000018D2C63CC
		private static void ProcessPaths(HierInfo[] infos, Scene scene, GameObject unityRoot, SdfPath usdRoot, PrimMap map, SceneImportOptions options); // 0x000000018D2C6CFC-0x000000018D2C7294
		private static void PopulateSkelCache(ref HierInfo skelRootInfo, UsdSkelCache skelCache); // 0x000000018D2C6A78-0x000000018D2C6CFC
		private static void ReadSkeletonJoints(ref HierInfo skelRootInfo); // 0x000000018D2C758C-0x000000018D2C7B20
		private static void ExpandSkeleton(HierInfo info, GameObject unityRoot, SdfPath usdRoot, UsdPrim prim, PrimMap map, SceneImportOptions options); // 0x000000018D2C63CC-0x000000018D2C66F4
		private static void ReadModelInfo(ref HierInfo info); // 0x000000018D2C7294-0x000000018D2C758C
		private static void AddModelRoot(GameObject go, HierInfo info); // 0x000000018D2C42F4-0x000000018D2C4504
		private static void AddPayload(GameObject go, HierInfo info, SceneImportOptions options); // 0x000000018D2C4504-0x000000018D2C45FC
		private static void AddVariantSet(GameObject go, UsdPrim prim); // 0x000000018D2C45FC-0x000000018D2C472C
		private static GameObject FindOrCreateGameObject(Transform parent, SdfPath path, Transform unityRoot, PrimMap primMap, SceneImportOptions options); // 0x000000018D2C66F4-0x000000018D2C6930
	}

	public static class ImportHelpers // TypeDefIndex: 87376
	{
		// Methods
		public static GameObject ImportSceneAsGameObject(Scene scene, GameObject parent = null, SceneImportOptions importOptions = null); // 0x000000018D2C7E48-0x000000018D2C80B0
		public static Scene InitForOpen(string path = "" /* Metadata: 0x0264636D */, UsdStage.InitialLoadSet loadSet = UsdStage.InitialLoadSet.LoadNone /* Metadata: 0x0264636E */); // 0x000000018D2C80B0-0x000000018D2C8124
		private static SdfPath GetDefaultRoot(Scene scene); // 0x000000018D2C7C78-0x000000018D2C7D2C
		private static GameObject UsdToGameObject(GameObject parent, Scene scene, SceneImportOptions importOptions); // 0x000000018D2C8124-0x000000018D2C8240
		private static string GetObjectName(SdfPath rootPrimName, string path); // 0x000000018D2C7D2C-0x000000018D2C7DB4
		private static string GetObjectName(string path); // 0x000000018D2C7DB4-0x000000018D2C7E00
		private static string GetPrefabName(string path); // 0x000000018D2C7E00-0x000000018D2C7E48
	}

	public interface IImportProcessUsd // TypeDefIndex: 87377
	{
		// Methods
		void ProcessUsd(Scene scene, SceneImportOptions sceneImportOptions);
	}

	public interface IImportPostProcessHierarchy // TypeDefIndex: 87378
	{
		// Methods
		void PostProcessHierarchy(PrimMap primMap, SceneImportOptions sceneImportOptions);
	}

	public interface IImportPostProcessComponents // TypeDefIndex: 87379
	{
		// Methods
		void PostProcessComponents(PrimMap primMap, SceneImportOptions sceneImportOptions);
	}

	public class PrimMap : IEnumerable<KeyValuePair<SdfPath, GameObject>> // TypeDefIndex: 87381
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
		public SdfPath[] Cameras { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001829600D0-0x00000001829600E0 0x000000018783BA80-0x000000018783BA90
		public SdfPath[] Meshes { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182986470-0x0000000182986480 0x0000000186AB5C00-0x0000000186AB5C10
		public SdfPath[] Cubes { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EEA0-0x000000018226EEB0 0x00000001870EAAD0-0x00000001870EAAE0
		public SdfPath[] Spheres { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public SdfPath[] Xforms { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public SdfPath[] SkelRoots { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F70-0x0000000187232F80 0x00000001856B9750-0x00000001856B9760
		public SdfPath[] Skeletons { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232FA0-0x0000000187232FB0 0x0000000188800CB0-0x0000000188800CC0
		public SdfPath[] Materials { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187232F80-0x0000000187232F90 0x0000000186B19440-0x0000000186B19450
		public bool ContainsPointInstances { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000182271A20-0x0000000182271A30 0x0000000182271A30-0x0000000182271A40
		public bool HasErrors { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x0000000187235F80-0x0000000187235F90 0x0000000187235F90-0x0000000187235FA0
		public GameObject this[SdfPath path] { get => default; set {} } // 0x000000018D2C975C-0x000000018D2C984C 0x000000018D2C984C-0x000000018D2C98B0
	
		// Nested types
		public struct InstanceRoot // TypeDefIndex: 87380
		{
			// Fields
			public GameObject gameObject; // 0x00
			public SdfPath masterPath; // 0x08
		}
	
		// Constructors
		public PrimMap(); // 0x000000018D2C9570-0x000000018D2C975C
	
		// Methods
		public bool TryGetValue(SdfPath key, out GameObject obj); // 0x000000018D2C950C-0x000000018D2C9570
		public IEnumerator GetEnumerator(); // 0x000000018D2C936C-0x000000018D2C93F4
		IEnumerator<KeyValuePair<SdfPath, GameObject>> IEnumerable<KeyValuePair<SdfPath, GameObject>>.GetEnumerator(); // 0x000000018D2C9484-0x000000018D2C950C
		public void AddInstance(GameObject goInst); // 0x000000018D2C8C6C-0x000000018D2C8CC4
		public void AddMasterRoot(SdfPath path, GameObject go); // 0x000000018D2C8CC4-0x000000018D2C8D3C
		public void AddInstanceRoot(SdfPath instancePath, GameObject go, SdfPath masterPath); // 0x000000018D2C8BC0-0x000000018D2C8C6C
		public Dictionary<SdfPath, GameObject> GetMasterRootPaths(); // 0x000000018D2C943C-0x000000018D2C9484
		public Dictionary<SdfPath, InstanceRoot> GetInstanceRoots(); // 0x000000018D2C93F4-0x000000018D2C943C
		public void DestroyAll(); // 0x000000018D2C8E80-0x000000018D2C936C
		public void Clear(); // 0x000000018D2C8D3C-0x000000018D2C8E80
	}

	public delegate void ExportFunction(ObjectContext objContext, ExportContext exportContext); // TypeDefIndex: 87382; 0x000000018417C530-0x000000018417C560

	internal delegate void ObjectProcessor(GameObject go, ExportContext context); // TypeDefIndex: 87383; 0x00000001859B7730-0x00000001859B7740

	public struct ObjectContext // TypeDefIndex: 87384
	{
		// Fields
		public GameObject gameObject; // 0x00
		public string path; // 0x08
		public SampleBase sample; // 0x10
		public object additionalData; // 0x18
	}

	public enum ActiveExportPolicy // TypeDefIndex: 87385
	{
		ExportAsVisibility = 0,
		ExportAsActive = 1,
		DoNotExport = 2,
		Ignore = 3
	}

	public class ExportContext // TypeDefIndex: 87386
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
		public ExportContext(); // 0x000000018D2C39C8-0x000000018D2C3CC0
	}

	public class Exporter // TypeDefIndex: 87387
	{
		// Fields
		public string path; // 0x10
		public SampleBase sample; // 0x18
		public ExportFunction exportFunc; // 0x20
		public object data; // 0x28
	
		// Constructors
		public Exporter(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class ExportPlan // TypeDefIndex: 87388
	{
		// Fields
		public List<Exporter> exporters; // 0x10
	
		// Constructors
		public ExportPlan(); // 0x000000018D2C410C-0x000000018D2C4184
	}

	public static class SceneExporter // TypeDefIndex: 87390
	{
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 87389
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static Func<Transform, string> __9__8_0; // 0x08
			public static Func<string, string> __9__8_1; // 0x10
	
			// Constructors
			static __c(); // 0x000000018D2DB170-0x000000018D2DB1D4
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal string _MergeBonesBelowAnimator_b__8_0(Transform boneXf); // 0x000000018D2DB0AC-0x000000018D2DB0F8
			internal string _MergeBonesBelowAnimator_b__8_1(string str); // 0x000000018459BB50-0x000000018459BB60
		}
	
		// Methods
		public static void Export(GameObject root, Scene scene, BasisTransformation basisTransform, bool exportUnvarying, bool zeroRootTransform, bool exportMaterials = false /* Metadata: 0x02646373 */, bool exportMonoBehaviours = false /* Metadata: 0x02646374 */, bool exportOverrides = false /* Metadata: 0x02646375 */); // 0x000000018D2CD44C-0x000000018D2CD5BC
		public static void Export(GameObject root, ExportContext context, bool zeroRootTransform); // 0x000000018D2CCEA0-0x000000018D2CD44C
		private static void ExportImpl(GameObject root, ExportContext context); // 0x000000018D2CC304-0x000000018D2CCEA0
		private static void Traverse(GameObject obj, ObjectProcessor processor, ExportContext context); // 0x000000018D2CF8EC-0x000000018D2CFAC4
		private static void AccumNestedBones(Transform curXf, List<Transform> children, ExportContext ctx); // 0x000000018D2CBBC0-0x000000018D2CBDB4
		private static T CreateSample<T>(ExportContext context)
			where T : SampleBase, new();
		public static void SyncExportContext(GameObject exportRoot, ExportContext context); // 0x000000018D2CEC08-0x000000018D2CF8EC
		private static void InitExportableObjects(GameObject go, ExportContext context); // 0x000000018D2CD5BC-0x000000018D2CE018
		private static Transform MergeBonesBelowAnimator(Transform animator, ExportContext context); // 0x000000018D2CE018-0x000000018D2CE7B4
		private static void MergeBonesSimple(Transform source, Transform rootBone, Transform[] bones, Matrix4x4[] bindPoses, ExportContext context); // 0x000000018D2CE7B4-0x000000018D2CEC08
		private static void CreateExportPlan(GameObject go, SampleBase sample, ExportFunction exportFunc, ExportContext context, string pathSuffix = null, bool insertFirst = true /* Metadata: 0x02646376 */); // 0x000000018D2CBF2C-0x000000018D2CC304
		private static Matrix4x4 ComputeWorldXf(Transform curBone, ExportContext context); // 0x000000018D2CBDB4-0x000000018D2CBF2C
	}

	public interface IImporter // TypeDefIndex: 87391
	{
		// Methods
		void BeginReading(Scene scene, PrimMap primMap, SceneImportOptions importOptions);
		IEnumerator Import(Scene scene, PrimMap primMap, SceneImportOptions importOptions);
	}

	public static class SceneImporter // TypeDefIndex: 87394
	{
		// Fields
		public static IImporter ActiveMeshImporter; // 0x00
	
		// Nested types
		public class ImportException : Exception // TypeDefIndex: 87392
		{
			// Constructors
			public ImportException(); // 0x000000018D2C7B70-0x000000018D2C7BBC
			public ImportException(string message); // 0x000000018D2C7C1C-0x000000018D2C7C78
			public ImportException(string message, Exception innerException); // 0x000000018D2C7BBC-0x000000018D2C7C1C
		}
	
		[CompilerGenerated]
		private sealed class _BuildScene_d__8 : IEnumerator<object> // TypeDefIndex: 87393
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _BuildScene_d__8(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D2DA898-0x000000018D2DAD94
			private bool MoveNext(); // 0x000000018D2D4314-0x000000018D2DA84C
			private void __m__Finally1(); // 0x000000018D2DADE8-0x000000018D2DAE3C
			private void __m__Finally2(); // 0x000000018D2DAE3C-0x000000018D2DAE90
			private void __m__Finally3(); // 0x000000018D2DAE90-0x000000018D2DAEE4
			private void __m__Finally4(); // 0x000000018D2DAEE4-0x000000018D2DAF38
			private void __m__Finally5(); // 0x000000018D2DAF38-0x000000018D2DAF8C
			private void __m__Finally6(); // 0x000000018D2DAF8C-0x000000018D2DAFE0
			private void __m__Finally7(); // 0x000000018D2DAFE0-0x000000018D2DB034
			private void __m__Finally8(); // 0x000000018D2DB034-0x000000018D2DB070
			private void __m__Finally9(); // 0x000000018D2DB070-0x000000018D2DB0AC
			private void __m__Finally10(); // 0x000000018D2DAD94-0x000000018D2DADE8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D2DA84C-0x000000018D2DA898
		}
	
		// Constructors
		static SceneImporter(); // 0x000000018D2D0100-0x000000018D2D0210
	
		// Methods
		public static void ImportUsd(GameObject goRoot, Scene scene, PrimMap primMap, SceneImportOptions importOptions); // 0x000000018D2CFD20-0x000000018D2CFD9C
		public static void ImportUsd(GameObject goRoot, Scene scene, PrimMap primMap, bool composingSubtree, SceneImportOptions importOptions); // 0x000000018D2CFD9C-0x000000018D2CFFD0
		private static UsdEditorAnalytics.ImportResult CreateImportResult(bool success, PrimMap primMap, ImportType importType = ImportType.Initial /* Metadata: 0x02646377 */); // 0x000000018D2CFCA8-0x000000018D2CFD20
		public static PrimMap BuildScene(Scene scene, GameObject root, SceneImportOptions importOptions, PrimMap primMap, bool composingSubtree); // 0x000000018D2CFAC4-0x000000018D2CFBE8
		private static void RemoveComponent<T>(GameObject go);
		[IteratorStateMachine(typeof(_BuildScene_d__8))]
		public static IEnumerator BuildScene(Scene scene, GameObject root, SceneImportOptions importOptions, PrimMap primMap, float targetFrameMilliseconds, bool composingSubtree); // 0x000000018D2CFBE8-0x000000018D2CFCA8
		private static bool ShouldYield(float targetTime, Stopwatch timer); // 0x000000018D2D00C4-0x000000018D2D0100
		private static void ResetTimer(Stopwatch timer); // 0x000000018D2D008C-0x000000018D2D00C4
		private static bool IsSkinnedMesh(UsdPrim prim, PrimMap primMap, SceneImportOptions importOptions); // 0x000000018D2CFFD0-0x000000018D2D008C
	}

	public enum PayloadPolicy // TypeDefIndex: 87395
	{
		DontLoadPayloads = 0,
		LoadAll = 1
	}

	public enum BasisTransformation // TypeDefIndex: 87396
	{
		FastWithNegativeScale = 0,
		SlowAndSafe = 1,
		SlowAndSafeAsFBX = 2,
		None = 3
	}

	[Serializable]
	public enum MaterialImportMode // TypeDefIndex: 87397
	{
		ImportPreviewSurface = 0,
		ImportDisplayColor = 1,
		None = 2
	}

	[Serializable]
	public class SceneImportOptions // TypeDefIndex: 87398
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
		public bool ShouldBindMaterials { get; } // 0x000000018D2DBBE0-0x000000018D2DBBE8 
		public ImportType ImportType { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x00000001872331A0-0x00000001872331B0 0x0000000185B8E8A0-0x0000000185B8EB10
	
		// Constructors
		public SceneImportOptions(); // 0x000000018D2DBAC0-0x000000018D2DBBE0
	}

	public class UsdzExporter // TypeDefIndex: 87399
	{
		// Constructors
		public UsdzExporter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void ExportUsdz(string usdzFilePath, GameObject root); // 0x000000018D2E0AF8-0x000000018D2E112C
	}

	public static class SkeletonExporter // TypeDefIndex: 87400
	{
		// Methods
		public static void ExportSkeleton(ObjectContext objContext, ExportContext exportContext); // 0x000000018D2DC970-0x000000018D2DD17C
		public static void ExportSkelRoot(ObjectContext objContext, ExportContext exportContext); // 0x000000018D2DC4B0-0x000000018D2DC970
		public static void ExportSkelAnimation(ObjectContext objContext, ExportContext exportContext); // 0x000000018D2DBDB4-0x000000018D2DC4B0
	}

	public static class SkeletonImporter // TypeDefIndex: 87401
	{
		// Methods
		public static void BuildSkeletonBone(string skelPath, GameObject go, Matrix4x4 restXform, VtTokenArray joints, SceneImportOptions importOptions); // 0x000000018D2DDA50-0x000000018D2DDE04
		public static void BuildDebugBindTransforms(SkeletonSample skelSample, GameObject goSkeleton, SceneImportOptions options); // 0x000000018D2DD288-0x000000018D2DDA50
		public static void BuildBindTransforms(string path, SkeletonSample skelSample, SceneImportOptions options); // 0x000000018D2DD17C-0x000000018D2DD288
		private static bool JointsMatch(string[] lhs, string[] rhs); // 0x000000018D2DE66C-0x000000018D2DE704
		public static void BuildSkinnedMesh(string meshPath, string skelPath, SkeletonSample skeleton, UsdSkelSkinningQuery skinningQuery, GameObject go, PrimMap primMap, SceneImportOptions options); // 0x000000018D2DDE04-0x000000018D2DE66C
	}

	public class UnitySkeleton // TypeDefIndex: 87402
	{
		// Fields
		public Transform rootBone; // 0x10
		public Transform[] bones; // 0x18
	
		// Constructors
		public UnitySkeleton(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class SkelBindingSample : SampleBase // TypeDefIndex: 87403
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
		public SkelBindingSample(); // 0x000000018D2DBBE8-0x000000018D2DBD38
	}

	[Serializable]
	[UsdSchema("SkelRoot")]
	public class SkelRootSample : BoundableSample // TypeDefIndex: 87404
	{
		// Fields
		[UsdNamespace("skel")]
		public Relationship skeleton; // 0x78
		[UsdNamespace("skel")]
		public Relationship animationSource; // 0x80
	
		// Constructors
		public SkelRootSample(); // 0x000000018D2DBD38-0x000000018D2DBDB4
	}

	[Serializable]
	[UsdSchema("Skeleton")]
	public class SkeletonSample : XformableSample // TypeDefIndex: 87405
	{
		// Fields
		[UsdVariability(Variability.Uniform)]
		public string[] joints; // 0x60
		[UsdVariability(Variability.Uniform)]
		public Matrix4x4[] bindTransforms; // 0x68
		[UsdVariability(Variability.Uniform)]
		public Matrix4x4[] restTransforms; // 0x70
	
		// Constructors
		public SkeletonSample(); // 0x000000018D2C9B30-0x000000018D2C9B38
	}

	[Serializable]
	[UsdSchema("SkelAnimation")]
	public class SkelAnimationSample : SampleBase // TypeDefIndex: 87406
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
		public SkelAnimationSample(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[UsdSchema("BlendShape")]
	public class BlendShapeSample : SampleBase // TypeDefIndex: 87407
	{
		// Fields
		public Vector3[] offsets; // 0x10
		public uint[] pointIndices; // 0x18
	
		// Constructors
		public BlendShapeSample(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class SkeletonIo // TypeDefIndex: 87408
	{
		// Fields
		private Dictionary<Transform, Transform[]> m_bindings; // 0x10
	
		// Constructors
		public SkeletonIo(); // 0x000000018D2DE7BC-0x000000018D2DE834
	
		// Methods
		public Transform[] GetBones(Transform rootBone); // 0x000000018D2DE704-0x000000018D2DE758
		public void RegisterSkeleton(Transform rootBone, Transform[] bones); // 0x000000018D2DE758-0x000000018D2DE7BC
	}

	public class NativeExporter // TypeDefIndex: 87409
	{
		// Constructors
		public NativeExporter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void ExportObject(ObjectContext objContext, ExportContext exportContext); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class NativeImporter // TypeDefIndex: 87410
	{
		// Constructors
		public NativeImporter(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public static void ImportObject(Scene scene, GameObject go, UsdPrim usdPrim, SceneImportOptions options); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	public class UsdPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 87411
	{
		// Fields
		private UsdAsset m_sourceUsdAsset; // 0x18
		[Tooltip("USD Player to Control")]
		public ExposedReference<UsdAsset> SourceUsdAsset; // 0x20
	
		// Properties
		public ClipCaps clipCaps { get; } // 0x0000000187239D30-0x0000000187239D40 
		public override double duration { get; } // 0x000000018D2DED7C-0x000000018D2DEED4 
	
		// Constructors
		public UsdPlayableAsset(); // 0x0000000185DD6260-0x0000000185DD6270
	
		// Methods
		public UsdAsset GetUsdAsset(string usdRootPath); // 0x000000018D2DED50-0x000000018D2DED7C
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018D2DEB80-0x000000018D2DED50
	}

	public class UsdPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 87412
	{
		// Fields
		public UsdPlayableAsset playableAsset; // 0x10
		private bool m_errorOnce; // 0x18
	
		// Constructors
		public UsdPlayableBehaviour(); // 0x0000000187233970-0x0000000187233980
	
		// Methods
		public override void OnGraphStart(Playable playable); // 0x000000018D2DEED4-0x000000018D2DEEDC
		public override void OnGraphStop(Playable playable); // 0x0000000186805BA0-0x0000000186805BB0
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x0000000186805BA0-0x0000000186805BB0
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x0000000186805BA0-0x0000000186805BB0
		public override void PrepareFrame(Playable playable, FrameData info); // 0x0000000186805BA0-0x0000000186805BB0
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x000000018D2DEEDC-0x000000018D2DF05C
		public override void PrepareData(Playable playable, FrameData info); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[TrackBindingType(typeof(UsdAsset))]
	[TrackClipType(typeof(UsdPlayableAsset))]
	[TrackColor(0.1f, 0.2f, 0.8f)]
	public class UsdPlayableTrack : TrackAsset // TypeDefIndex: 87413
	{
		// Constructors
		public UsdPlayableTrack(); // 0x000000018D2DF098-0x000000018D2DF0E4
	
		// Methods
		protected override void OnCreateClip(TimelineClip clip); // 0x000000018D2DF05C-0x000000018D2DF098
	}

	public class UsdRecorderBehaviour : PlayableBehaviour // TypeDefIndex: 87415
	{
		// Fields
		private const int kExportFrameRate = 60; // Metadata: 0x02646381
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
		private sealed class __c__DisplayClass17_0 // TypeDefIndex: 87414
		{
			// Fields
			public UsdRecorderBehaviour __4__this; // 0x10
			public Playable playable; // 0x18
			public FrameData info; // 0x28
			public object playerData; // 0x68
	
			// Constructors
			public __c__DisplayClass17_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal void _ProcessFrame_b__0(); // 0x000000018D2DE834-0x000000018D2DE8A0
		}
	
		// Constructors
		public UsdRecorderBehaviour(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		public void BeginRecording(double currentTime, GameObject root); // 0x000000018D2DF0E4-0x000000018D2DFC98
		public void StopRecording(double currentTime); // 0x000000018D2E0198-0x000000018D2E0580
		private void ProcessRecording(double currentTime, GameObject root); // 0x000000018D2E0014-0x000000018D2E0198
		private bool IsPlaying(); // 0x00000001851A4410-0x00000001851A4420
		public override void OnPlayableCreate(Playable playable); // 0x0000000186805BA0-0x0000000186805BB0
		public override void OnPlayableDestroy(Playable playable); // 0x000000018D2DFEA0-0x000000018D2DFEF8
		public override void OnGraphStart(Playable playable); // 0x000000018D2DFD80-0x000000018D2DFE48
		public override void OnGraphStop(Playable playable); // 0x000000018D2DFE48-0x000000018D2DFEA0
		public override void ProcessFrame(Playable playable, FrameData info, object playerData); // 0x000000018D2DFEF8-0x000000018D2E0014
		public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x000000018275FD80-0x000000018275FD90
		public override void OnBehaviourPause(Playable playable, FrameData info); // 0x00000001829D07F0-0x00000001829D0800
		public void OnFrameEnd(Playable playable, FrameData info, object playerData); // 0x000000018D2DFC98-0x000000018D2DFD80
	}

	[System.ComponentModel.DisplayName("USD Recorder Clip")]
	public class UsdRecorderClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 87416
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
		public Scene UsdScene { [CompilerGenerated] get; [CompilerGenerated] set; } // 0x000000018226EE80-0x000000018226EE90 0x0000000185B68F50-0x0000000185B68F60
		public ExportContext Context { get; set; } // 0x000000018226EBD0-0x000000018226EBE0 0x00000001869E1E00-0x00000001869E1E10
		public ClipCaps clipCaps { get; } // 0x0000000185829EC0-0x0000000185829ED0 
		public bool IsUSDZ { get; } // 0x000000018D2E0770-0x000000018D2E07DC 
	
		// Constructors
		public UsdRecorderClip(); // 0x000000018D2E06D4-0x000000018D2E0770
	
		// Methods
		public GameObject GetExportRoot(PlayableGraph graph); // 0x000000018D2E0680-0x000000018D2E06D4
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner); // 0x000000018D2E0580-0x000000018D2E0680
		public virtual void OnDestroy(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[TrackClipType(typeof(UsdRecorderClip))]
	[TrackColor(0.7f, 0f, 0f)]
	public class UsdRecorderTrack : TrackAsset // TypeDefIndex: 87417
	{
		// Constructors
		public UsdRecorderTrack(); // 0x000000018D2E07DC-0x000000018D2E0828
	}

	[ExecuteInEditMode]
	internal class UsdWaitForEndOfFrame : MonoBehaviour // TypeDefIndex: 87419
	{
		// Fields
		private List<Action> m_pending; // 0x18
		private static UsdWaitForEndOfFrame s_instance; // 0x00
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitForEndOfFrame_d__4 : IEnumerator<object> // TypeDefIndex: 87418
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public UsdWaitForEndOfFrame __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x0000000182234E30-0x0000000182234E40 
	
			// Constructors
			[DebuggerHidden]
			public _WaitForEndOfFrame_d__4(int __1__state); // 0x0000000182234E90-0x0000000182234EA0
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x0000000186805BA0-0x0000000186805BB0
			private bool MoveNext(); // 0x000000018D2DE8A0-0x000000018D2DEB34
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D2DEB34-0x000000018D2DEB80
		}
	
		// Constructors
		public UsdWaitForEndOfFrame(); // 0x000000018D2E0A78-0x000000018D2E0AF8
	
		// Methods
		private static UsdWaitForEndOfFrame GetInstance(); // 0x000000018D2E087C-0x000000018D2E09F8
		public static void Add(Action callback); // 0x000000018D2E0828-0x000000018D2E087C
		[IteratorStateMachine(typeof(_WaitForEndOfFrame_d__4))]
		private IEnumerator WaitForEndOfFrame(); // 0x000000018D2E0A1C-0x000000018D2E0A78
		private void LateUpdate(); // 0x000000018D2E09F8-0x000000018D2E0A1C
	}
}
