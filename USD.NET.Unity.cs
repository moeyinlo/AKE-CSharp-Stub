/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using pxr;
using UnityEngine;
using USD.NET;

// Image 79: USD.NET.Unity.dll - Assembly: USD.NET.Unity, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 58955-59006
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace USD.NET.Unity
{
	public class DiagnosticHandler : pxr.DiagnosticHandler // TypeDefIndex: 58956
	{
		// Constructors
		public DiagnosticHandler() {} // 0x0000000189FD2F00-0x0000000189FD2F08
	
		// Methods
		public override void OnFatalError(string msg) {} // 0x0000000189FD2D98-0x0000000189FD2E38
		public override void OnError(string msg) {} // 0x0000000189FD2CD4-0x0000000189FD2D98
		public override void OnWarning(string msg) {} // 0x0000000189FD2E9C-0x0000000189FD2F00
		public override void OnInfo(string msg) {} // 0x0000000189FD2E38-0x0000000189FD2E9C
	}

	[Serializable]
	[UsdSchema("BasisCurves")]
	public class BasisCurvesSample : CurvesSample // TypeDefIndex: 58960
	{
		// Fields
		public CurveType type; // 0xB0
		public Basis basis; // 0xB4
		public WrapMode wrap; // 0xB8
	
		// Nested types
		public enum CurveType // TypeDefIndex: 58957
		{
			Linear = 0,
			Cubic = 1
		}
	
		public enum Basis // TypeDefIndex: 58958
		{
			Bezier = 0,
			Bspline = 1,
			CatmullRom = 2,
			Hermite = 3,
			Power = 4
		}
	
		public enum WrapMode // TypeDefIndex: 58959
		{
			Nonperiodic = 0,
			Periodic = 1
		}
	
		// Constructors
		public BasisCurvesSample() {} // 0x0000000189FD2738-0x0000000189FD2740
	}

	[Serializable]
	[UsdSchema("UsdGeomBoundable")]
	public class BoundableSample : XformableSample // TypeDefIndex: 58961
	{
		// Fields
		public Bounds extent; // 0x60
	
		// Constructors
		public BoundableSample() {} // 0x0000000189B85118-0x0000000189B85120
	}

	[Serializable]
	[UsdSchema("Camera")]
	public class CameraSample : XformSample // TypeDefIndex: 58965
	{
		// Fields
		public ProjectionType projection; // 0x60
		public float horizontalAperture; // 0x64
		public float horizontalApertureOffset; // 0x68
		public float verticalAperture; // 0x6C
		public float verticalApertureOffset; // 0x70
		public float focalLength; // 0x74
		public Vector2 clippingRange; // 0x78
		public Vector4[] clippingPlanes; // 0x80
		public float fStop; // 0x88
		public float focusDistance; // 0x8C
		[UsdVariability(Variability.Uniform)]
		public StereoRole stereoRole; // 0x90
		[UsdNamespace("shutter")]
		public Shutter shutter; // 0x98
	
		// Nested types
		[Serializable]
		public enum ProjectionType // TypeDefIndex: 58962
		{
			Perspective = 0,
			Orthographic = 1
		}
	
		[Serializable]
		public enum StereoRole // TypeDefIndex: 58963
		{
			Mono = 0,
			Left = 1,
			Right = 2
		}
	
		[Serializable]
		public class Shutter : SampleBase // TypeDefIndex: 58964
		{
			// Fields
			public double open; // 0x10
			public double close; // 0x18
	
			// Constructors
			public Shutter() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public CameraSample() {} // 0x0000000189B85118-0x0000000189B85120
		public CameraSample(Camera fromCamera) {} // 0x0000000189FD2BC8-0x0000000189FD2BFC
	
		// Methods
		public void CopyFromCamera(Camera camera, bool convertTransformToUsd = true /* Metadata: 0x01FDCC0E */) {} // 0x0000000189FD2740-0x0000000189FD2970
		public void CopyToCamera(Camera camera, bool setTransform) {} // 0x0000000189FD2970-0x0000000189FD2BC8
	}

	[Serializable]
	[UsdSchema("Cube")]
	public class CubeSample : GprimSample // TypeDefIndex: 58966
	{
		// Fields
		private double m_size; // 0x80
	
		// Properties
		public double size { get => default; set {} } // 0x0000000183D50B60-0x0000000183D50B70 0x0000000189FD2C28-0x0000000189FD2CD4
	
		// Constructors
		public CubeSample() {} // 0x0000000189FD2738-0x0000000189FD2740
		public CubeSample(double size) {} // 0x0000000189FD2BFC-0x0000000189FD2C28
	}

	[Serializable]
	[UsdSchema("Curves")]
	public class CurvesSample : PointBasedSample // TypeDefIndex: 58967
	{
		// Fields
		[UsdVariability(Variability.Uniform)]
		public bool doubleSided; // 0x80
		[UsdVariability(Variability.Uniform)]
		public Orientation orientation; // 0x84
		public Vector3[] points; // 0x88
		public Vector3[] normals; // 0x90
		public Vector3[] velocities; // 0x98
		public int[] curveVertexCounts; // 0xA0
		public float[] widths; // 0xA8
	
		// Constructors
		public CurvesSample() {} // 0x0000000189FD2738-0x0000000189FD2740
	}

	[Serializable]
	[UsdSchema("UsdGeomGprim")]
	public class GprimSample : BoundableSample // TypeDefIndex: 58968
	{
		// Fields
		[FusedDisplayColor]
		[VertexData]
		public Primvar<UnityEngine.Color[]> colors; // 0x78
	
		// Constructors
		public GprimSample() {} // 0x0000000189FD2F08-0x0000000189FD2F74
	}

	[Serializable]
	[UsdSchema("UsdGeomImageable")]
	public class ImageableSample : SampleBase // TypeDefIndex: 58969
	{
		// Constructors
		public ImageableSample() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[UsdSchema("Mesh")]
	public class MeshSample : MeshSampleBase // TypeDefIndex: 58970
	{
		// Fields
		public Visibility visibility; // 0xA8
		[UsdVariability(Variability.Uniform)]
		public Purpose purpose; // 0xAC
		[UsdVariability(Variability.Uniform)]
		public bool doubleSided; // 0xB0
		[UsdVariability(Variability.Uniform)]
		public Orientation orientation; // 0xB4
		public int[] faceVertexCounts; // 0xB8
	
		// Constructors
		public MeshSample() {} // 0x0000000189B8704C-0x0000000189B87054
	
		// Methods
		public void SetTriangles(int[] triangleIndices) {} // 0x0000000189FD3E5C-0x0000000189FD3F18
	}

	[Serializable]
	[UsdSchema("Mesh")]
	public class MeshSampleBase : PointBasedSample, IArbitraryPrimvars // TypeDefIndex: 58971
	{
		// Fields
		public int[] faceVertexIndices; // 0x80
		public Vector3[] points; // 0x88
		public Vector3[] normals; // 0x90
		public Primvar<Vector4[]> tangents; // 0x98
		[ForceNoNamespace]
		public Dictionary<string, Primvar<object>> ArbitraryPrimvars; // 0xA0
	
		// Constructors
		public MeshSampleBase() {} // 0x0000000189FD3D8C-0x0000000189FD3E5C
	
		// Methods
		public Dictionary<string, Primvar<object>> GetArbitraryPrimvars() => default; // 0x0000000183D4EA80-0x0000000183D4EA90
		public void AddPrimvars(List<string> primvars) {} // 0x0000000189FD3BAC-0x0000000189FD3D8C
	}

	[Serializable]
	[UsdSchema("UsdGeomPointBased")]
	public class PointBasedSample : GprimSample // TypeDefIndex: 58972
	{
		// Constructors
		public PointBasedSample() {} // 0x0000000189FD2738-0x0000000189FD2740
	}

	[Serializable]
	[UsdSchema("PointInstancer")]
	public class PointInstancerPrototypesSample : BoundableSample // TypeDefIndex: 58973
	{
		// Fields
		public Relationship prototypes; // 0x78
	
		// Constructors
		public PointInstancerPrototypesSample() {} // 0x0000000189FD4050-0x0000000189FD40A8
	}

	[Serializable]
	[UsdSchema("PointInstancer")]
	public class PointInstancerSample : PointInstancerPrototypesSample // TypeDefIndex: 58974
	{
		// Fields
		public int[] protoIndices; // 0x80
		public long[] ids; // 0x88
		public long[] invisibleIds; // 0x90
		public Vector3[] positions; // 0x98
		public Quaternion[] rotations; // 0xA0
		public Vector3[] scales; // 0xA8
		public Vector3[] velocities; // 0xB0
		public Vector3[] angularVelocities; // 0xB8
	
		// Constructors
		public PointInstancerSample() {} // 0x0000000189FD42FC-0x0000000189FD4304
	
		// Methods
		public Matrix4x4[] ComputeInstanceMatrices(Scene scene, string primPath) => default; // 0x0000000189FD40A8-0x0000000189FD42FC
	}

	[Serializable]
	[UsdSchema("Scope")]
	public class ScopeSample : ImageableSample // TypeDefIndex: 58975
	{
		// Constructors
		public ScopeSample() {} // 0x000000018350B670-0x000000018350B680
	}

	[Serializable]
	[UsdSchema("Sphere")]
	public class SphereSample : GprimSample // TypeDefIndex: 58976
	{
		// Fields
		private double m_radius; // 0x80
	
		// Properties
		public double radius { get => default; set {} } // 0x0000000183D50B60-0x0000000183D50B70 0x0000000189FD4800-0x0000000189FD48D0
	
		// Constructors
		public SphereSample() {} // 0x0000000189FD2738-0x0000000189FD2740
		public SphereSample(double radius) {} // 0x0000000189FD2BFC-0x0000000189FD2C28
	}

	[Serializable]
	[UsdSchema("UsdGeomXformable")]
	public class XformableSample : ImageableSample // TypeDefIndex: 58977
	{
		// Fields
		private readonly string[] kXformOpTransform; // 0x10
		private Matrix4x4 m_xf; // 0x18
		[UsdVariability(Variability.Uniform)]
		public string[] xformOpOrder; // 0x58
	
		// Properties
		[FusedTransform]
		[UsdNamespace("xformOp")]
		public Matrix4x4 transform { get => default; set {} } // 0x0000000183D58F00-0x0000000183D58F30 0x0000000189FDD744-0x0000000189FDD78C
	
		// Constructors
		public XformableSample() {} // 0x0000000189FDD680-0x0000000189FDD744
	
		// Methods
		public static XformableSample FromTransform(Transform transform) => default; // 0x0000000189FDD548-0x0000000189FDD680
		public void ConvertTransform() {} // 0x0000000189FDD484-0x0000000189FDD548
	}

	[Serializable]
	[UsdSchema("Xform")]
	public class XformSample : XformableSample // TypeDefIndex: 58978
	{
		// Constructors
		public XformSample() {} // 0x0000000189B85118-0x0000000189B85120
	}

	[Serializable]
	public class MaterialBindingSample : SampleBase // TypeDefIndex: 58979
	{
		// Fields
		[UsdNamespace("material")]
		public Relationship binding; // 0x10
	
		// Constructors
		public MaterialBindingSample() {} // 0x000000018350B670-0x000000018350B680
		public MaterialBindingSample(string materialPath) {} // 0x0000000189FD30DC-0x0000000189FD3154
	}

	[Serializable]
	[UsdSchema("Material")]
	public class MaterialSample : SampleBase // TypeDefIndex: 58980
	{
		// Fields
		[UsdNamespace("outputs")]
		public Connectable<TfToken> surface; // 0x10
		[UsdNamespace("outputs")]
		public Connectable<TfToken> displacement; // 0x18
		public string[] requiredKeywords; // 0x20
	
		// Constructors
		public MaterialSample() {} // 0x0000000189FD3A64-0x0000000189FD3ADC
		public MaterialSample(string surfacePath) {} // 0x0000000189FD39BC-0x0000000189FD3A64
		public MaterialSample(string surfacePath, string displacementPath) {} // 0x0000000189FD3ADC-0x0000000189FD3BAC
	
		// Methods
		public static bool ReadMaterial(Scene scene, string geometryPath, MaterialSample materialSample, out string shaderId) {
			shaderId = default;
			return default;
		} // 0x0000000189FD33DC-0x0000000189FD3864
		public static void Bind(Scene scene, string primPath, string materialPath) {} // 0x0000000189FD3154-0x0000000189FD33DC
		public static void Unbind(Scene scene, string primPath) {} // 0x0000000189FD3864-0x0000000189FD39BC
	}

	public struct ParameterInfo // TypeDefIndex: 58981
	{
		// Fields
		public object value; // 0x00
		public string connectedPath; // 0x08
		public string usdName; // 0x10
		public string unityName; // 0x18
		public string[] requiredShaderKeywords; // 0x20
	
		// Methods
		public override string ToString() => default; // 0x0000000189FD3F18-0x0000000189FD4050
	}

	public class InputParameterAttribute : UsdNamespaceAttribute // TypeDefIndex: 58982
	{
		// Properties
		public string UnityName { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public InputParameterAttribute() {} // 0x0000000189FD2FCC-0x0000000189FD3028
		public InputParameterAttribute(string unityName) {} // 0x0000000189FD2F74-0x0000000189FD2FCC
	}

	public class InputTextureAttribute : UsdNamespaceAttribute // TypeDefIndex: 58983
	{
		// Properties
		public string UnityName { get; private set; } // 0x0000000181041090-0x00000001810410A0 0x00000001822C3A90-0x00000001822C3AA0
	
		// Constructors
		public InputTextureAttribute() {} // 0x0000000189FD3028-0x0000000189FD3084
		public InputTextureAttribute(string unityName) {} // 0x0000000189FD3084-0x0000000189FD30DC
	}

	public class RequireShaderKeywordsAttribute : Attribute // TypeDefIndex: 58984
	{
		// Properties
		public string[] Keywords { get; private set; } // 0x00000001820B7B20-0x00000001820B7B30 0x000000018426FEE0-0x000000018426FEF0
	
		// Constructors
		public RequireShaderKeywordsAttribute() {} // Dummy constructor
		public RequireShaderKeywordsAttribute(string keyword) {} // 0x0000000189FD4684-0x0000000189FD4700
		public RequireShaderKeywordsAttribute(string[] keywords) {} // 0x000000018426FEE0-0x000000018426FEF0
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class ShaderSample : SampleBase // TypeDefIndex: 58989
	{
		// Fields
		[UsdNamespace("info")]
		public TfToken id; // 0x10
	
		// Constructors
		public ShaderSample() {} // 0x000000018350B670-0x000000018350B680
	
		// Methods
		private System.Type GetClassType() => default; // 0x000000018426F82C-0x000000018426F838
		private object GetValue(System.Reflection.FieldInfo info) => default; // 0x0000000189FD47E0-0x0000000189FD4800
		[IteratorStateMachine(typeof(_GetInputParameters_d__3))]
		public IEnumerable<ParameterInfo> GetInputParameters() => default; // 0x0000000189FD4700-0x0000000189FD4770
		[IteratorStateMachine(typeof(_GetInputTextures_d__4))]
		public IEnumerable<ParameterInfo> GetInputTextures() => default; // 0x0000000189FD4770-0x0000000189FD47E0
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class StandardShaderSample : ShaderSample // TypeDefIndex: 58990
	{
		// Fields
		[UsdNamespace("info")]
		public bool enableGpuInstancing; // 0x18
		[InputParameter("_Color")]
		public Connectable<UnityEngine.Color> albedo; // 0x20
		[InputTexture("_MainTex")]
		public Connectable<UnityEngine.Color> albedoMap; // 0x28
		[InputParameter("_Cutoff")]
		public Connectable<float> cutoff; // 0x30
		[InputParameter("_Glossiness")]
		public Connectable<float> smoothness; // 0x38
		[InputParameter("_GlossMapScale")]
		public Connectable<float> smoothnessScale; // 0x40
		[InputParameter("_SmoothnessTextureChannel")]
		public Connectable<float> smoothnessTextureChannel; // 0x48
		[InputTexture("_MetallicGlossMap")]
		[RequireShaderKeywords("_METALLICGLOSSMAP")]
		public Connectable<float> metallicMap; // 0x50
		[InputParameter("_Metallic")]
		public Connectable<float> metallicScale; // 0x58
		[InputParameter("_SpecularHighlights")]
		public Connectable<bool> enableSpecularHighlights; // 0x60
		[InputParameter("_GlossyReflections")]
		public Connectable<bool> enableGlossyReflections; // 0x68
		[InputTexture("_BumpMap")]
		[RequireShaderKeywords("_NORMALMAP")]
		public Connectable<UnityEngine.Color> normalMap; // 0x70
		[InputParameter("_BumpScale")]
		public Connectable<float> normalMapScale; // 0x78
		[InputTexture("_ParallaxMap")]
		[RequireShaderKeywords("_PARALLAXMAP")]
		public Connectable<UnityEngine.Color> parallaxMap; // 0x80
		[InputParameter("_Parallax")]
		public Connectable<float> parallaxMapScale; // 0x88
		[InputTexture("_OcclusionMap")]
		public Connectable<float> occlusionMap; // 0x90
		[InputParameter("_OcclusionStrength")]
		public Connectable<float> occlusionMapScale; // 0x98
		[InputParameter("_EmissionColor")]
		public Connectable<UnityEngine.Color> emission; // 0xA0
		[InputTexture("_EmissionMap")]
		[RequireShaderKeywords("_EMISSION")]
		public Connectable<UnityEngine.Color> emissionMap; // 0xA8
		[InputTexture("_DetailMask")]
		public Connectable<UnityEngine.Color> detailMask; // 0xB0
		[InputTexture("_DetailAlbedoMap")]
		[RequireShaderKeywords("_DETAIL_MULX2")]
		public Connectable<UnityEngine.Color> detailAlbedoMap; // 0xB8
		[InputTexture("_DetailNormalMap")]
		[RequireShaderKeywords("_DETAIL_MULX2")]
		public Connectable<UnityEngine.Color> detailNormalMap; // 0xC0
		[InputParameter("_DetailNormalMapScale")]
		public Connectable<float> detailNormalMapScale; // 0xC8
		[InputParameter("_UVSec")]
		public Connectable<float> uvSetForSecondaryTextures; // 0xD0
		[InputParameter("_Mode")]
		public Connectable<float> renderingMode; // 0xD8
		[InputParameter("_SrcBlend")]
		public Connectable<float> srcBlend; // 0xE0
		[InputParameter("_DstBlend")]
		public Connectable<float> dstBlend; // 0xE8
		[InputParameter("_ZWrite")]
		public Connectable<float> zwrite; // 0xF0
	
		// Constructors
		public StandardShaderSample() {} // 0x0000000189FD48D0-0x0000000189FD4DF8
	}

	[Serializable]
	[UsdSchema("Texture2D")]
	public class Texture2DSample : SampleBase // TypeDefIndex: 58991
	{
		// Fields
		[UsdAssetPath]
		[UsdNamespace("inputs")]
		public Connectable<string> sourceFile; // 0x10
		public bool sRgb; // 0x18
	
		// Constructors
		public Texture2DSample() {} // 0x0000000189FD4DF8-0x0000000189FD4E54
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class PreviewSurfaceSample : ShaderSample // TypeDefIndex: 58993
	{
		// Fields
		[InputParameter("_DiffuseColor")]
		public Connectable<Vector3> diffuseColor; // 0x18
		[InputParameter("_EmissiveColor")]
		public Connectable<Vector3> emissiveColor; // 0x20
		[InputParameter("_UseSpecularWorkflow")]
		public Connectable<int> useSpecularWorkflow; // 0x28
		[InputParameter("_SpecularColor")]
		public Connectable<Vector3> specularColor; // 0x30
		[InputParameter("_Metallic")]
		public Connectable<float> metallic; // 0x38
		[InputParameter("_Roughness")]
		public Connectable<float> roughness; // 0x40
		[InputParameter("_Clearcoat")]
		public Connectable<float> clearcoat; // 0x48
		[InputParameter("_ClearcoatRoughness")]
		public Connectable<float> clearcoatRoughness; // 0x50
		[InputParameter("_Opacity")]
		public Connectable<float> opacity; // 0x58
		[InputParameter("_OpacityThreshold")]
		public Connectable<float> opacityThreshold; // 0x60
		[InputParameter("_Ior")]
		public Connectable<float> ior; // 0x68
		[InputParameter("_Normal")]
		public Connectable<Vector3> normal; // 0x70
		[InputParameter("_Displacement")]
		public Connectable<float> displacement; // 0x78
		[InputParameter("_Occlusion")]
		public Connectable<float> occlusion; // 0x80
		[UsdNamespace("outputs")]
		public Outputs outputs; // 0x88
	
		// Nested types
		public class Outputs : SampleBase // TypeDefIndex: 58992
		{
			// Fields
			public TfToken displacement; // 0x10
			public TfToken surface; // 0x18
	
			// Constructors
			public Outputs() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public PreviewSurfaceSample() {} // 0x0000000189FD4304-0x0000000189FD4684
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class PrimvarReaderSample<T> : ShaderSample // TypeDefIndex: 58995
		where T : struct
	{
		// Fields
		[InputParameter("_Fallback")]
		public Connectable<T> fallback;
		[UsdNamespace("outputs")]
		public Outputs outputs;
	
		// Nested types
		public class Outputs : SampleBase // TypeDefIndex: 58994
		{
			// Fields
			public T? result;
	
			// Constructors
			public Outputs() {}
		}
	
		// Constructors
		public PrimvarReaderSample() {}
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class PrimvarReaderImportSample<T> : PrimvarReaderSample<T> // TypeDefIndex: 58996
		where T : struct
	{
		// Fields
		[InputParameter("_Varname")]
		public Connectable<string> varname;
	
		// Constructors
		public PrimvarReaderImportSample() {}
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class PrimvarReaderExportSample<T> : PrimvarReaderSample<T> // TypeDefIndex: 58997
		where T : struct
	{
		// Fields
		[InputParameter("_Varname")]
		public Connectable<TfToken> varname;
	
		// Constructors
		public PrimvarReaderExportSample() {}
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class TextureReaderSample : ShaderSample // TypeDefIndex: 59001
	{
		// Fields
		[InputParameter("_File")]
		public Connectable<SdfAssetPath> file; // 0x18
		[InputParameter("_St")]
		public Connectable<Vector2> st; // 0x20
		[InputParameter("_WrapS")]
		public Connectable<WrapMode> wrapS; // 0x28
		[InputParameter("_WrapT")]
		public Connectable<WrapMode> wrapT; // 0x30
		[InputParameter("_Fallback")]
		public Connectable<Vector4> fallback; // 0x38
		[InputParameter("_Scale")]
		public Connectable<Vector4> scale; // 0x40
		[InputParameter("_Bias")]
		public Connectable<Vector4> bias; // 0x48
		[InputParameter("_IsSRGB")]
		public Connectable<SRGBMode> isSRGB; // 0x50
		[UsdNamespace("outputs")]
		public Outputs outputs; // 0x58
	
		// Nested types
		public enum WrapMode // TypeDefIndex: 58998
		{
			Black = 0,
			Clamp = 1,
			Repeat = 2,
			Mirror = 3
		}
	
		public enum SRGBMode // TypeDefIndex: 58999
		{
			Yes = 0,
			No = 1,
			Auto = 2
		}
	
		public class Outputs : SampleBase // TypeDefIndex: 59000
		{
			// Fields
			public float? r; // 0x10
			public float? g; // 0x18
			public float? b; // 0x20
			public float? a; // 0x28
			public Vector3? rgb; // 0x30
			public Vector4? rgba; // 0x40
	
			// Constructors
			public Outputs() {} // 0x000000018350B670-0x000000018350B680
		}
	
		// Constructors
		public TextureReaderSample() {} // 0x0000000189FD4E7C-0x0000000189FD515C
		public TextureReaderSample(string filePath) {} // 0x0000000189FD5220-0x0000000189FD52A8
		public TextureReaderSample(string filePath, string stConnectionPath) {} // 0x0000000189FD515C-0x0000000189FD5220
	
		// Methods
		public static WrapMode GetWrapMode(TextureWrapMode wrap) => default; // 0x0000000189FD4E54-0x0000000189FD4E7C
	}

	public static class UnityTypeBindings // TypeDefIndex: 59003
	{
		// Fields
		private static bool isInitialized; // 0x00
	
		// Constructors
		static UnityTypeBindings() {} // 0x0000000189FD8AB0-0x0000000189FD8AB8
	
		// Methods
		public static void RegisterTypes() {} // 0x0000000189FD7198-0x0000000189FD8AB0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	internal class PreserveAttribute : Attribute // TypeDefIndex: 59004
	{
		// Constructors
		public PreserveAttribute() {} // 0x000000018350B670-0x000000018350B680
	}

	public class UnityTypeConverter : IntrinsicTypeConverter // TypeDefIndex: 59006
	{
		// Fields
		public static Matrix4x4 basisChange; // 0x00
		public static Matrix4x4 inverseBasisChange; // 0x40
	
		// Constructors
		public UnityTypeConverter() {} // 0x000000018350B670-0x000000018350B680
		static UnityTypeConverter() {} // 0x0000000189FDD390-0x0000000189FDD484
	
		// Methods
		public static Matrix4x4 ChangeBasis(Matrix4x4 input) => default; // 0x0000000189FD9074-0x0000000189FD91C0
		public static Vector3 ChangeBasis(Vector3 point) => default; // 0x0000000189FD8FEC-0x0000000189FD9074
		public static void SetTransform(Matrix4x4 localXf, Transform transform) {} // 0x0000000189FDBFEC-0x0000000189FDC0F8
		public static bool Decompose(Matrix4x4 matrix, out Vector3 translation, out Quaternion rotation, out Vector3 scale) {
			translation = default;
			rotation = default;
			scale = default;
			return default;
		} // 0x0000000189FD95C4-0x0000000189FD9FE0
		private static Vector3 WeightedAvg(Vector3 a, Vector3 b, float aWeight, float bWeight) => default; // 0x0000000189FDD2F4-0x0000000189FDD390
		public static void ExtractTrs(Matrix4x4 transform, ref Vector3 localPosition, ref Quaternion localRotation, ref Vector3 localScale) {} // 0x0000000189FDA52C-0x0000000189FDA648
		private static Quaternion ExtractRotation(Matrix4x4 mat4) => default; // 0x0000000189FDA3B0-0x0000000189FDA440
		private static Vector3 ExtractPosition(Matrix4x4 mat4) => default; // 0x0000000183D8A030-0x0000000183D8A050
		private static Vector3 ExtractScale(Matrix4x4 mat4) => default; // 0x0000000189FDA440-0x0000000189FDA52C
		private static bool HasAnySiblingsWithName(Transform transform, string name) => default; // 0x0000000189FDB3F0-0x0000000189FDB778
		public static string GetUniqueName(Transform transform) => default; // 0x0000000189FDB334-0x0000000189FDB3F0
		public static string GetPath(Transform unityObj) => default; // 0x0000000189FDB2E8-0x0000000189FDB334
		public static string GetPath(Transform unityObj, Transform unityObjRoot) => default; // 0x0000000189FDB120-0x0000000189FDB2E8
		public static Matrix4x4 GetLocalToParentXf(Transform unityXf) => default; // 0x0000000189FDB03C-0x0000000189FDB120
		[Preserve]
		public static GfMatrix4d ToGfMatrix(Transform unityXf) => default; // 0x0000000189FDC194-0x0000000189FDC210
		[Preserve]
		public static GfMatrix4d ToGfMatrix(Matrix4x4 unityMat4) => default; // 0x0000000189FDC210-0x0000000189FDC504
		[Preserve]
		public static Matrix4x4 FromMatrix(GfMatrix4d gfMat) => default; // 0x0000000189FDA648-0x0000000189FDA964
		[Preserve]
		public static VtMatrix4dArray ToVtArray(Matrix4x4[] input) => default; // 0x0000000189FDC880-0x0000000189FDC97C
		[Preserve]
		public static Matrix4x4[] FromVtArray(VtMatrix4dArray input) => default; // 0x0000000189FDACB0-0x0000000189FDADDC
		[Preserve]
		public static VtMatrix4dArray ListToVtArray(List<Matrix4x4> input) => default; // 0x0000000189FDBDD4-0x0000000189FDBE40
		[Preserve]
		public static List<Matrix4x4> ListFromVtArray(VtMatrix4dArray input) => default; // 0x0000000189FDB778-0x0000000189FDB8BC
		[Preserve]
		public static GfVec4f Color32ToVec4f(Color32 c) => default; // 0x0000000189FD9344-0x0000000189FD93A8
		[Preserve]
		public static Color32 Vec4fToColor32(GfVec4f v) => default; // 0x0000000189FDD0AC-0x0000000189FDD108
		[Preserve]
		public static VtVec4fArray ToVtArray(List<Color32> input) => default; // 0x0000000189FDCC5C-0x0000000189FDCCC8
		[Preserve]
		public static void ToVtArray(List<Color32> input, out VtVec3fArray rgb, out VtFloatArray alpha) {
			rgb = default;
			alpha = default;
		} // 0x0000000189FDCB40-0x0000000189FDCBCC
		[Preserve]
		public static VtVec4fArray ToVtArray(Color32[] input) => default; // 0x0000000189FDCEB4-0x0000000189FDCFA0
		[Preserve]
		public static Color32[] Color32FromVtArray(VtVec4fArray input) => default; // 0x0000000189FD91C0-0x0000000189FD9344
		[Preserve]
		public static GfVec4f ColorToVec4f(UnityEngine.Color c) => default; // 0x0000000189FD954C-0x0000000189FD95C4
		[Preserve]
		public static UnityEngine.Color Vec4fToColor(GfVec4f v) => default; // 0x0000000189FDD108-0x0000000189FDD1A8
		[Preserve]
		public static VtVec4fArray ToVtArray(List<UnityEngine.Color> input) => default; // 0x0000000189FDC504-0x0000000189FDC570
		[Preserve]
		public static void ToVtArray(List<UnityEngine.Color> input, out VtVec3fArray rgb, out VtFloatArray alpha) {
			rgb = default;
			alpha = default;
		} // 0x0000000189FDC6D4-0x0000000189FDC760
		[Preserve]
		public static VtVec4fArray ToVtArray(UnityEngine.Color[] input) => default; // 0x0000000189FDC644-0x0000000189FDC6D4
		[Preserve]
		public static UnityEngine.Color[] ColorFromVtArray(VtVec4fArray input) => default; // 0x0000000189FD93A8-0x0000000189FD9458
		[Preserve]
		public static UnityEngine.Color[] ColorFromVtArray(VtVec4fArray input, ref UnityEngine.Color[] output) => default; // 0x0000000189FD9458-0x0000000189FD954C
		[Preserve]
		public static void ToVtArray(Color32[] input, out VtVec3fArray rgb, out VtFloatArray alpha) {
			rgb = default;
			alpha = default;
		} // 0x0000000189FDCCC8-0x0000000189FDCEB4
		[Preserve]
		public static Vector3[] ExtractRgb(Color32[] colors) => default; // 0x0000000189FDA168-0x0000000189FDA2AC
		[Preserve]
		public static float[] ExtractAlpha(Color32[] colors) => default; // 0x0000000189FD9FE0-0x0000000189FDA0AC
		[Preserve]
		public static void ToVtArray(UnityEngine.Color[] input, out VtVec3fArray rgb, out VtFloatArray alpha) {
			rgb = default;
			alpha = default;
		} // 0x0000000189FDC97C-0x0000000189FDCB40
		[Preserve]
		public static UnityEngine.Color[] FromVtArray(VtVec3fArray rgbIn, VtFloatArray alphaIn) => default; // 0x0000000189FDADDC-0x0000000189FDAF84
		[Preserve]
		public static Vector3[] ExtractRgb(UnityEngine.Color[] colors) => default; // 0x0000000189FDA2AC-0x0000000189FDA3B0
		[Preserve]
		public static float[] ExtractAlpha(UnityEngine.Color[] colors) => default; // 0x0000000189FDA0AC-0x0000000189FDA168
		[Preserve]
		private static void SwapQuaternionReal(ref Quaternion[] input) {} // 0x0000000189FDC0F8-0x0000000189FDC194
		[Preserve]
		public static GfQuatf QuaternionToQuatf(Quaternion quaternion) => default; // 0x0000000189FDBE40-0x0000000189FDBEB8
		[Preserve]
		public static Quaternion QuatfToQuaternion(GfQuatf quat) => default; // 0x0000000189FDBEB8-0x0000000189FDBF74
		[Preserve]
		public static VtQuatfArray ToVtArray(Quaternion[] input) => default; // 0x0000000189FDC570-0x0000000189FDC644
		[Preserve]
		public static Quaternion[] FromVtArray(VtQuatfArray input) => default; // 0x0000000189FDA964-0x0000000189FDAA48
		[Preserve]
		public static VtQuatfArray ListToVtArray(List<Quaternion> input) => default; // 0x0000000189FDBD68-0x0000000189FDBDD4
		[Preserve]
		public static List<Quaternion> ListFromVtArray(VtQuatfArray input) => default; // 0x0000000189FDBB2C-0x0000000189FDBC24
		[Preserve]
		public static VtVec4fArray ToVtArray(Vector4[] input) => default; // 0x0000000189FDC760-0x0000000189FDC7F0
		[Preserve]
		public static Vector4[] FromVtArray(VtVec4fArray input) => default; // 0x0000000189FDAB38-0x0000000189FDABF4
		[Preserve]
		public static VtVec4fArray ListToVtArray(List<Vector4> input) => default; // 0x0000000189FDBC90-0x0000000189FDBCFC
		[Preserve]
		public static List<Vector4> ListFromVtArray(VtVec4fArray input) => default; // 0x0000000189FDB8BC-0x0000000189FDB98C
		[Preserve]
		public static VtVec3fArray BoundsToVtArray(Bounds input) => default; // 0x0000000189FD8E2C-0x0000000189FD8FEC
		[Preserve]
		public static Bounds BoundsFromVtArray(VtValue vtBounds) => default; // 0x0000000189FD8BB8-0x0000000189FD8E2C
		[Preserve]
		public static Bounds BoundsFromVtArray(VtValue vtBounds, Vector3[] bbox) => default; // 0x0000000189FD8AB8-0x0000000189FD8BB8
		[Preserve]
		public static VtVec3fArray ToVtArray(Vector3[] input) => default; // 0x0000000189FDC7F0-0x0000000189FDC880
		[Preserve]
		public static Vector3[] FromVtArray(VtVec3fArray input) => default; // 0x0000000189FDAF84-0x0000000189FDB03C
		[Preserve]
		public static void FromVtArray(VtVec3fArray input, ref Vector3[] output) {} // 0x0000000189FDAA48-0x0000000189FDAB38
		[Preserve]
		public static VtVec3fArray ListToVtArray(List<Vector3> input) => default; // 0x0000000189FDBC24-0x0000000189FDBC90
		[Preserve]
		public static List<Vector3> ListFromVtArray(VtVec3fArray input) => default; // 0x0000000189FDB98C-0x0000000189FDBA5C
		[Preserve]
		public static VtVec2fArray ToVtArray(Vector2[] input) => default; // 0x0000000189FDCBCC-0x0000000189FDCC5C
		[Preserve]
		public static Vector2[] FromVtArray(VtVec2fArray input) => default; // 0x0000000189FDABF4-0x0000000189FDACB0
		[Preserve]
		public static VtVec2fArray ListToVtArray(List<Vector2> input) => default; // 0x0000000189FDBCFC-0x0000000189FDBD68
		[Preserve]
		public static List<Vector2> ListFromVtArray(VtVec2fArray input) => default; // 0x0000000189FDBA5C-0x0000000189FDBB2C
		[Preserve]
		public static GfVec2f Vector2ToVec2f(Vector2 vec2) => default; // 0x0000000189FDD1A8-0x0000000189FDD20C
		[Preserve]
		public static Vector2 Vec2fToVector2(GfVec2f value) => default; // 0x0000000189FDCFA0-0x0000000189FDD030
		[Preserve]
		public static GfVec3f Vector3ToVec3f(Vector3 vec3) => default; // 0x0000000189FDD20C-0x0000000189FDD27C
		[Preserve]
		public static Vector3 Vec3fToVector3(GfVec3f v3) => default; // 0x0000000189FDD030-0x0000000189FDD0AC
		[Preserve]
		public static GfVec4f Vector4ToVec4f(Vector4 vector4) => default; // 0x0000000189FDD27C-0x0000000189FDD2F4
		[Preserve]
		public static Vector4 Vec4fToVector4(GfVec4f v4) => default; // 0x0000000189FDD108-0x0000000189FDD1A8
		[Preserve]
		public static GfVec4f RectToVtVec4(Rect rect) => default; // 0x0000000189FDBF74-0x0000000189FDBFEC
		[Preserve]
		public static Rect Vec4fToRect(GfVec4f v4) => default; // 0x0000000189FDD108-0x0000000189FDD1A8
	}
}
