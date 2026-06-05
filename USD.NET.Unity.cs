/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using USD.NET;
using UnityEngine;
using pxr;

// Image 79: USD.NET.Unity.dll - Assembly: USD.NET.Unity, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 59980-60031

namespace USD.NET.Unity
{
	public class DiagnosticHandler : pxr.DiagnosticHandler // TypeDefIndex: 59981
	{
		// Constructors
		public DiagnosticHandler() {} // 0x000000018C0EAFD0-0x000000018C0EAFD8
	
		// Methods
		public override void OnFatalError(string msg) {} // 0x000000018C0EAE68-0x000000018C0EAF08
		public override void OnError(string msg) {} // 0x000000018C0EADA4-0x000000018C0EAE68
		public override void OnWarning(string msg) {} // 0x000000018C0EAF6C-0x000000018C0EAFD0
		public override void OnInfo(string msg) {} // 0x000000018C0EAF08-0x000000018C0EAF6C
	}

	[Serializable]
	public class BasisCurvesSample : CurvesSample // TypeDefIndex: 59985
	{
		// Fields
		public CurveType type; // 0xB0
		public Basis basis; // 0xB4
		public WrapMode wrap; // 0xB8
	
		// Nested types
		public enum CurveType // TypeDefIndex: 59982
		{
			Linear = 0,
			Cubic = 1
		}
	
		public enum Basis // TypeDefIndex: 59983
		{
			Bezier = 0,
			Bspline = 1,
			CatmullRom = 2,
			Hermite = 3,
			Power = 4
		}
	
		public enum WrapMode // TypeDefIndex: 59984
		{
			Nonperiodic = 0,
			Periodic = 1
		}
	
		// Constructors
		public BasisCurvesSample() {} // 0x000000018C0EA808-0x000000018C0EA810
	}

	[Serializable]
	public class BoundableSample : XformableSample // TypeDefIndex: 59986
	{
		// Fields
		public Bounds extent; // 0x60
	
		// Constructors
		public BoundableSample() {} // 0x000000018BC9E98C-0x000000018BC9E994
	}

	[Serializable]
	public class CameraSample : XformSample // TypeDefIndex: 59990
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
		public StereoRole stereoRole; // 0x90
		public Shutter shutter; // 0x98
	
		// Nested types
		[Serializable]
		public enum ProjectionType // TypeDefIndex: 59987
		{
			Perspective = 0,
			Orthographic = 1
		}
	
		[Serializable]
		public enum StereoRole // TypeDefIndex: 59988
		{
			Mono = 0,
			Left = 1,
			Right = 2
		}
	
		[Serializable]
		public class Shutter : SampleBase // TypeDefIndex: 59989
		{
			// Fields
			public double open; // 0x10
			public double close; // 0x18
	
			// Constructors
			public Shutter() {} // 0x000000018BC9E98C-0x000000018BC9E994
		}
	
		// Constructors
		public CameraSample() {} // 0x000000018C0EAC98-0x000000018C0EACCC
		public CameraSample(Camera fromCamera) {} // 0x000000018C0EA810-0x000000018C0EAA40
	
		// Methods
		public void CopyFromCamera(Camera camera, bool convertTransformToUsd = true /* Metadata: 0x020824F2 */) {} // 0x000000018C0EAA40-0x000000018C0EAC98
		public void CopyToCamera(Camera camera, bool setTransform) {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class CubeSample : GprimSample // TypeDefIndex: 59991
	{
		// Fields
		private double m_size; // 0x80
	
		// Properties
		public double size { get => default; set {} } // 0x0000000185FB2050-0x0000000185FB2060 0x000000018C0EACF8-0x000000018C0EADA4
	
		// Constructors
		public CubeSample() {} // 0x000000018C0EA808-0x000000018C0EA810
		public CubeSample(double size) {} // 0x000000018C0EACCC-0x000000018C0EACF8
	}

	[Serializable]
	public class CurvesSample : PointBasedSample // TypeDefIndex: 59992
	{
		// Fields
		public bool doubleSided; // 0x80
		public Orientation orientation; // 0x84
		public Vector3[] points; // 0x88
		public Vector3[] normals; // 0x90
		public Vector3[] velocities; // 0x98
		public int[] curveVertexCounts; // 0xA0
		public float[] widths; // 0xA8
	
		// Constructors
		public CurvesSample() {} // 0x000000018C0EA808-0x000000018C0EA810
	}

	[Serializable]
	public class GprimSample : BoundableSample // TypeDefIndex: 59993
	{
		// Fields
		public Primvar<UnityEngine.Color[]> colors; // 0x78
	
		// Constructors
		public GprimSample() {} // 0x000000018C0EAFD8-0x000000018C0EB044
	}

	[Serializable]
	public class ImageableSample : SampleBase // TypeDefIndex: 59994
	{
		// Constructors
		public ImageableSample() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class MeshSample : MeshSampleBase // TypeDefIndex: 59995
	{
		// Fields
		public Visibility visibility; // 0xA8
		public Purpose purpose; // 0xAC
		public bool doubleSided; // 0xB0
		public Orientation orientation; // 0xB4
		public int[] faceVertexCounts; // 0xB8
	
		// Constructors
		public MeshSample() {} // 0x000000018BCA08C0-0x000000018BCA08C8
	
		// Methods
		public void SetTriangles(int[] triangleIndices) {} // 0x000000018C0EBF2C-0x000000018C0EBFE8
	}

	[Serializable]
	public class MeshSampleBase : PointBasedSample, IArbitraryPrimvars // TypeDefIndex: 59996
	{
		// Fields
		public int[] faceVertexIndices; // 0x80
		public Vector3[] points; // 0x88
		public Vector3[] normals; // 0x90
		public Primvar<Vector4[]> tangents; // 0x98
		public Dictionary<string, Primvar<object>> ArbitraryPrimvars; // 0xA0
	
		// Constructors
		public MeshSampleBase() {} // 0x000000018C0EBE5C-0x000000018C0EBF2C
	
		// Methods
		public Dictionary<string, Primvar<object>> GetArbitraryPrimvars() => default; // 0x0000000185FB0520-0x0000000185FB0530
		public void AddPrimvars(List<string> primvars) {} // 0x000000018C0EBC7C-0x000000018C0EBE5C
	}

	[Serializable]
	public class PointBasedSample : GprimSample // TypeDefIndex: 59997
	{
		// Constructors
		public PointBasedSample() {} // 0x000000018C0EA808-0x000000018C0EA810
	}

	[Serializable]
	public class PointInstancerPrototypesSample : BoundableSample // TypeDefIndex: 59998
	{
		// Fields
		public Relationship prototypes; // 0x78
	
		// Constructors
		public PointInstancerPrototypesSample() {} // 0x000000018C0EC120-0x000000018C0EC178
	}

	[Serializable]
	public class PointInstancerSample : PointInstancerPrototypesSample // TypeDefIndex: 59999
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
		public PointInstancerSample() {} // 0x000000018C0EC3CC-0x000000018C0EC3D4
	
		// Methods
		public Matrix4x4[] ComputeInstanceMatrices(Scene scene, string primPath) => default; // 0x000000018C0EC178-0x000000018C0EC3CC
	}

	[Serializable]
	public class ScopeSample : ImageableSample // TypeDefIndex: 60000
	{
		// Constructors
		public ScopeSample() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class SphereSample : GprimSample // TypeDefIndex: 60001
	{
		// Fields
		private double m_radius; // 0x80
	
		// Properties
		public double radius { get => default; set {} } // 0x0000000185FB2050-0x0000000185FB2060 0x000000018C0EC8D0-0x000000018C0EC9A0
	
		// Constructors
		public SphereSample() {} // 0x000000018C0EA808-0x000000018C0EA810
		public SphereSample(double radius) {} // 0x000000018C0EACCC-0x000000018C0EACF8
	}

	[Serializable]
	public class XformableSample : ImageableSample // TypeDefIndex: 60002
	{
		// Fields
		private readonly string[] kXformOpTransform; // 0x10
		private Matrix4x4 m_xf; // 0x18
		public string[] xformOpOrder; // 0x58
	
		// Properties
		public Matrix4x4 transform { get => default; set {} } // 0x0000000185FBA490-0x0000000185FBA4C0 0x000000018C0F5814-0x000000018C0F585C
	
		// Constructors
		public XformableSample() {} // 0x000000018C0F5750-0x000000018C0F5814
	
		// Methods
		public static XformableSample FromTransform(Transform transform) => default; // 0x000000018C0F5618-0x000000018C0F5750
		public void ConvertTransform() {} // 0x000000018C0F5554-0x000000018C0F5618
	}

	[Serializable]
	public class XformSample : XformableSample // TypeDefIndex: 60003
	{
		// Constructors
		public XformSample() {} // 0x000000018BC9E98C-0x000000018BC9E994
	}

	[Serializable]
	public class MaterialBindingSample : SampleBase // TypeDefIndex: 60004
	{
		// Fields
		public Relationship binding; // 0x10
	
		// Constructors
		public MaterialBindingSample() {} // 0x0000000185492010-0x0000000185492020
		public MaterialBindingSample(string materialPath) {} // 0x000000018C0EB1AC-0x000000018C0EB224
	}

	[Serializable]
	public class MaterialSample : SampleBase // TypeDefIndex: 60005
	{
		// Fields
		public Connectable<TfToken> surface; // 0x10
		public Connectable<TfToken> displacement; // 0x18
		public string[] requiredKeywords; // 0x20
	
		// Constructors
		public MaterialSample() {} // 0x000000018C0EBB34-0x000000018C0EBBAC
		public MaterialSample(string surfacePath) {} // 0x000000018C0EBA8C-0x000000018C0EBB34
		public MaterialSample(string surfacePath, string displacementPath) {} // 0x000000018C0EBBAC-0x000000018C0EBC7C
	
		// Methods
		public static bool ReadMaterial(Scene scene, string geometryPath, MaterialSample materialSample, out string shaderId) {
			shaderId = default;
			return default;
		} // 0x000000018C0EB4AC-0x000000018C0EB934
		public static void Bind(Scene scene, string primPath, string materialPath) {} // 0x000000018C0EB224-0x000000018C0EB4AC
		public static void Unbind(Scene scene, string primPath) {} // 0x000000018C0EB934-0x000000018C0EBA8C
	}

	public struct ParameterInfo // TypeDefIndex: 60006
	{
		// Fields
		public object value; // 0x00
		public string connectedPath; // 0x08
		public string usdName; // 0x10
		public string unityName; // 0x18
		public string[] requiredShaderKeywords; // 0x20
	
		// Methods
		public override string ToString() => default; // 0x000000018C0EBFE8-0x000000018C0EC120
	}

	public class InputParameterAttribute : UsdNamespaceAttribute // TypeDefIndex: 60007
	{
		// Fields
		private string _UnityName_k__BackingField; // 0x18
	
		// Properties
		public string UnityName { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public InputParameterAttribute() {} // 0x000000018C0EB09C-0x000000018C0EB0F8
		public InputParameterAttribute(string unityName) {} // 0x000000018C0EB044-0x000000018C0EB09C
	}

	public class InputTextureAttribute : UsdNamespaceAttribute // TypeDefIndex: 60008
	{
		// Fields
		private string _UnityName_k__BackingField; // 0x18
	
		// Properties
		public string UnityName { get; private set; } // 0x0000000181377E40-0x0000000181377E50 0x0000000184088E70-0x0000000184088E80
	
		// Constructors
		public InputTextureAttribute() {} // 0x000000018C0EB0F8-0x000000018C0EB154
		public InputTextureAttribute(string unityName) {} // 0x000000018C0EB154-0x000000018C0EB1AC
	}

	public class RequireShaderKeywordsAttribute : Attribute // TypeDefIndex: 60009
	{
		// Fields
		private string[] _Keywords_k__BackingField; // 0x10
	
		// Properties
		public string[] Keywords { get; private set; } // 0x000000018346D130-0x000000018346D140 0x0000000184096E30-0x0000000184096EF0
	
		// Constructors
		public RequireShaderKeywordsAttribute() {} // Dummy constructor
		public RequireShaderKeywordsAttribute(string keyword) {} // 0x000000018C0EC754-0x000000018C0EC7D0
		public RequireShaderKeywordsAttribute(string[] keywords) {} // 0x0000000184096E30-0x0000000184096EF0
	}

	[Serializable]
	public class ShaderSample : SampleBase // TypeDefIndex: 60014
	{
		// Fields
		public TfToken id; // 0x10
	
		// Nested types
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 60010
		{
			// Fields
			public System.Type inputParamType; // 0x10
			public Func<System.Reflection.FieldInfo, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0() {} // 0x000000018646D8A4-0x000000018646D8B0
	
			// Methods
			internal bool _GetInputParameters_b__0(System.Reflection.FieldInfo info) => default; // 0x000000018C0EC8B0-0x000000018C0EC8D0
		}
	
		private sealed class _GetInputParameters_d__3 : IEnumerable<ParameterInfo>, IEnumerator<ParameterInfo> // TypeDefIndex: 60011
		{
			// Fields
			private int __1__state; // 0x10
			private ParameterInfo __2__current; // 0x18
			private int __l__initialThreadId; // 0x40
			public ShaderSample __4__this; // 0x48
			private __c__DisplayClass3_0 __8__1; // 0x50
			private IEnumerator<System.Reflection.FieldInfo> __7__wrap1; // 0x58
	
			// Properties
			ParameterInfo IEnumerator<USD.NET.Unity.ParameterInfo>.Current { get => default; } // 0x000000018C0EF1EC-0x000000018C0EF204 
			object IEnumerator.Current { get => default; } // 0x000000018C0EDC30-0x000000018C0EDCA8 
	
			// Constructors
			public _GetInputParameters_d__3() {} // Dummy constructor
			public _GetInputParameters_d__3(int __1__state) {} // 0x000000018C0EC7D0-0x000000018C0EC840
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018C0EC840-0x000000018C0EC8B0
			private bool MoveNext() => default; // 0x0000000185492010-0x0000000185492020
			private void __m__Finally1() {} // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x000000018C0EDCF0-0x000000018C0EDD0C
			IEnumerator<ParameterInfo> IEnumerable<ParameterInfo>.GetEnumerator() => default; // 0x000000018C0ED378-0x000000018C0EDAF4
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0EDCA8-0x000000018C0EDCF0
		}
	
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 60012
		{
			// Fields
			public System.Type inputParamType; // 0x10
			public Func<System.Reflection.FieldInfo, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0() {} // 0x0000000185FBDF40-0x0000000185FBDF60
	
			// Methods
			internal bool _GetInputTextures_b__0(System.Reflection.FieldInfo info) => default; // 0x000000018C0EDB88-0x000000018C0EDBD4
		}
	
		private sealed class _GetInputTextures_d__4 : IEnumerable<ParameterInfo>, IEnumerator<ParameterInfo> // TypeDefIndex: 60013
		{
			// Fields
			private int __1__state; // 0x10
			private ParameterInfo __2__current; // 0x18
			private int __l__initialThreadId; // 0x40
			public ShaderSample __4__this; // 0x48
			private __c__DisplayClass4_0 __8__1; // 0x50
			private System.Type _requireKeywordType_5__2; // 0x58
			private IEnumerator<System.Reflection.FieldInfo> __7__wrap2; // 0x60
	
			// Properties
			ParameterInfo IEnumerator<USD.NET.Unity.ParameterInfo>.Current { get => default; } // 0x000000018C0EF1EC-0x000000018C0EF204 
			object IEnumerator.Current { get => default; } // 0x000000018C0EE768-0x000000018C0EE7E0 
	
			// Constructors
			public _GetInputTextures_d__4() {} // Dummy constructor
			public _GetInputTextures_d__4(int __1__state) {} // 0x000000018C0EDBD4-0x000000018C0EDC30
	
			// Methods
			void IDisposable.Dispose() {} // 0x000000018C0EDAF4-0x000000018C0EDB80
			private bool MoveNext() => default; // 0x000000018C0EDB80-0x000000018C0EDB88
			private void __m__Finally1() {} // 0x0000000185492010-0x0000000185492020
			void IEnumerator.Reset() {} // 0x000000018C0EDCF0-0x000000018C0EDD0C
			IEnumerator<ParameterInfo> IEnumerable<ParameterInfo>.GetEnumerator() => default; // 0x000000018C0EDD0C-0x000000018C0EE62C
			IEnumerator IEnumerable.GetEnumerator() => default; // 0x000000018C0EE7E0-0x000000018C0EE828
		}
	
		// Constructors
		public ShaderSample() {} // 0x000000018C0EE6B8-0x000000018C0EE6C0
	
		// Methods
		private System.Type GetClassType() => default; // 0x0000000185FBDF40-0x0000000185FBDF60
		private object GetValue(System.Reflection.FieldInfo info) => default; // 0x000000018C0EE6C0-0x000000018C0EE70C
		public IEnumerable<ParameterInfo> GetInputParameters() => default; // 0x000000018C0EE70C-0x000000018C0EE768
		public IEnumerable<ParameterInfo> GetInputTextures() => default; // 0x000000018C0EE62C-0x000000018C0EE6B8
	}

	[Serializable]
	public class StandardShaderSample : ShaderSample // TypeDefIndex: 60015
	{
		// Fields
		public bool enableGpuInstancing; // 0x18
		public Connectable<UnityEngine.Color> albedo; // 0x20
		public Connectable<UnityEngine.Color> albedoMap; // 0x28
		public Connectable<float> cutoff; // 0x30
		public Connectable<float> smoothness; // 0x38
		public Connectable<float> smoothnessScale; // 0x40
		public Connectable<float> smoothnessTextureChannel; // 0x48
		public Connectable<float> metallicMap; // 0x50
		public Connectable<float> metallicScale; // 0x58
		public Connectable<bool> enableSpecularHighlights; // 0x60
		public Connectable<bool> enableGlossyReflections; // 0x68
		public Connectable<UnityEngine.Color> normalMap; // 0x70
		public Connectable<float> normalMapScale; // 0x78
		public Connectable<UnityEngine.Color> parallaxMap; // 0x80
		public Connectable<float> parallaxMapScale; // 0x88
		public Connectable<float> occlusionMap; // 0x90
		public Connectable<float> occlusionMapScale; // 0x98
		public Connectable<UnityEngine.Color> emission; // 0xA0
		public Connectable<UnityEngine.Color> emissionMap; // 0xA8
		public Connectable<UnityEngine.Color> detailMask; // 0xB0
		public Connectable<UnityEngine.Color> detailAlbedoMap; // 0xB8
		public Connectable<UnityEngine.Color> detailNormalMap; // 0xC0
		public Connectable<float> detailNormalMapScale; // 0xC8
		public Connectable<float> uvSetForSecondaryTextures; // 0xD0
		public Connectable<float> renderingMode; // 0xD8
		public Connectable<float> srcBlend; // 0xE0
		public Connectable<float> dstBlend; // 0xE8
		public Connectable<float> zwrite; // 0xF0
	
		// Constructors
		public StandardShaderSample() {} // 0x000000018C0EC9A0-0x000000018C0ECEC8
	}

	[Serializable]
	public class Texture2DSample : SampleBase // TypeDefIndex: 60016
	{
		// Fields
		public Connectable<string> sourceFile; // 0x10
		public bool sRgb; // 0x18
	
		// Constructors
		public Texture2DSample() {} // 0x000000018C0ECEC8-0x000000018C0ECF24
	}

	[Serializable]
	public class PreviewSurfaceSample : ShaderSample // TypeDefIndex: 60018
	{
		// Fields
		public Connectable<Vector3> diffuseColor; // 0x18
		public Connectable<Vector3> emissiveColor; // 0x20
		public Connectable<int> useSpecularWorkflow; // 0x28
		public Connectable<Vector3> specularColor; // 0x30
		public Connectable<float> metallic; // 0x38
		public Connectable<float> roughness; // 0x40
		public Connectable<float> clearcoat; // 0x48
		public Connectable<float> clearcoatRoughness; // 0x50
		public Connectable<float> opacity; // 0x58
		public Connectable<float> opacityThreshold; // 0x60
		public Connectable<float> ior; // 0x68
		public Connectable<Vector3> normal; // 0x70
		public Connectable<float> displacement; // 0x78
		public Connectable<float> occlusion; // 0x80
		public Outputs outputs; // 0x88
	
		// Nested types
		public class Outputs : SampleBase // TypeDefIndex: 60017
		{
			// Fields
			public TfToken displacement; // 0x10
			public TfToken surface; // 0x18
	
			// Constructors
			public Outputs() {} // 0x000000018C0EC3D4-0x000000018C0EC754
		}
	
		// Constructors
		public PreviewSurfaceSample() {} // 0x0000000185492010-0x0000000185492020
	}

	[Serializable]
	public class PrimvarReaderSample<T> : ShaderSample // TypeDefIndex: 60020
		where T : struct
	{
		// Fields
		public Connectable<T> fallback;
		public Outputs outputs;
	
		// Nested types
		public class Outputs : SampleBase // TypeDefIndex: 60019
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
	public class PrimvarReaderImportSample<T> : PrimvarReaderSample<T> // TypeDefIndex: 60021
		where T : struct
	{
		// Fields
		public Connectable<string> varname;
	
		// Constructors
		public PrimvarReaderImportSample() {}
	}

	[Serializable]
	public class PrimvarReaderExportSample<T> : PrimvarReaderSample<T> // TypeDefIndex: 60022
		where T : struct
	{
		// Fields
		public Connectable<TfToken> varname;
	
		// Constructors
		public PrimvarReaderExportSample() {}
	}

	[Serializable]
	public class TextureReaderSample : ShaderSample // TypeDefIndex: 60026
	{
		// Fields
		public Connectable<SdfAssetPath> file; // 0x18
		public Connectable<Vector2> st; // 0x20
		public Connectable<WrapMode> wrapS; // 0x28
		public Connectable<WrapMode> wrapT; // 0x30
		public Connectable<Vector4> fallback; // 0x38
		public Connectable<Vector4> scale; // 0x40
		public Connectable<Vector4> bias; // 0x48
		public Connectable<SRGBMode> isSRGB; // 0x50
		public Outputs outputs; // 0x58
	
		// Nested types
		public enum WrapMode // TypeDefIndex: 60023
		{
			Black = 0,
			Clamp = 1,
			Repeat = 2,
			Mirror = 3
		}
	
		public enum SRGBMode // TypeDefIndex: 60024
		{
			Yes = 0,
			No = 1,
			Auto = 2
		}
	
		public class Outputs : SampleBase // TypeDefIndex: 60025
		{
			// Fields
			public float? r; // 0x10
			public float? g; // 0x18
			public float? b; // 0x20
			public float? a; // 0x28
			public Vector3? rgb; // 0x30
			public Vector4? rgba; // 0x40
	
			// Constructors
			public Outputs() {} // 0x000000018C0ECF4C-0x000000018C0ED22C
		}
	
		// Constructors
		public TextureReaderSample() {} // 0x000000018C0ED2F0-0x000000018C0ED378
		public TextureReaderSample(string filePath) {} // 0x000000018C0ED22C-0x000000018C0ED2F0
		public TextureReaderSample(string filePath, string stConnectionPath) {} // 0x000000018C0ECF24-0x000000018C0ECF4C
	
		// Methods
		public static WrapMode GetWrapMode(TextureWrapMode wrap) => default; // 0x0000000185492010-0x0000000185492020
	}

	public static class UnityTypeBindings // TypeDefIndex: 60028
	{
		// Fields
		private static bool isInitialized; // 0x00
	
		// Nested types
		[Serializable]
		private sealed class __c // TypeDefIndex: 60027
		{
			// Fields
			public static readonly __c __9; // 0x00
			public static ToVtConverter __9__2_0; // 0x08
			public static ToCsConverter __9__2_1; // 0x10
			public static ToVtConverter __9__2_2; // 0x18
			public static ToCsConverter __9__2_3; // 0x20
			public static ToVtConverter __9__2_4; // 0x28
			public static ToCsConverter __9__2_5; // 0x30
			public static ToVtConverter __9__2_6; // 0x38
			public static ToCsConverter __9__2_7; // 0x40
			public static ToVtConverter __9__2_8; // 0x48
			public static ToCsConverter __9__2_9; // 0x50
			public static ToVtConverter __9__2_10; // 0x58
			public static ToCsConverter __9__2_11; // 0x60
			public static ToVtConverter __9__2_12; // 0x68
			public static ToCsConverter __9__2_13; // 0x70
			public static ToVtConverter __9__2_14; // 0x78
			public static ToCsConverter __9__2_15; // 0x80
			public static ToVtConverter __9__2_16; // 0x88
			public static ToCsConverter __9__2_17; // 0x90
			public static ToVtConverter __9__2_18; // 0x98
			public static ToCsConverter __9__2_19; // 0xA0
	
			// Constructors
			static __c() {} // 0x000000018C0F0B80-0x000000018C0F0B88
			public __c() {} // 0x000000018C0EF268-0x000000018C0F0B80
	
			// Methods
			internal VtValue _RegisterTypes_b__2_0(object obj) => default; // 0x000000018C0EF204-0x000000018C0EF268
			internal object _RegisterTypes_b__2_1(VtValue value) => default; // 0x0000000185492010-0x0000000185492020
			internal VtValue _RegisterTypes_b__2_2(object obj) => default; // 0x000000018C0EE828-0x000000018C0EE898
			internal object _RegisterTypes_b__2_3(VtValue value) => default; // 0x000000018C0EED2C-0x000000018C0EEDA8
			internal VtValue _RegisterTypes_b__2_4(object obj) => default; // 0x000000018C0EEDA8-0x000000018C0EEE10
			internal object _RegisterTypes_b__2_5(VtValue value) => default; // 0x000000018C0EEE10-0x000000018C0EEE80
			internal VtValue _RegisterTypes_b__2_6(object obj) => default; // 0x000000018C0EEE80-0x000000018C0EEEF8
			internal object _RegisterTypes_b__2_7(VtValue value) => default; // 0x000000018C0EEEF8-0x000000018C0EEF7C
			internal VtValue _RegisterTypes_b__2_8(object obj) => default; // 0x000000018C0EEF7C-0x000000018C0EEFEC
			internal object _RegisterTypes_b__2_9(VtValue value) => default; // 0x000000018C0EEFEC-0x000000018C0EF068
			internal VtValue _RegisterTypes_b__2_10(object obj) => default; // 0x000000018C0EF068-0x000000018C0EF0D8
			internal object _RegisterTypes_b__2_11(VtValue vtVal) => default; // 0x000000018C0EF0D8-0x000000018C0EF154
			internal VtValue _RegisterTypes_b__2_12(object obj) => default; // 0x000000018C0EE898-0x000000018C0EE900
			internal object _RegisterTypes_b__2_13(VtValue vtVal) => default; // 0x000000018C0EE900-0x000000018C0EE950
			internal VtValue _RegisterTypes_b__2_14(object obj) => default; // 0x000000018C0EE950-0x000000018C0EE9C0
			internal object _RegisterTypes_b__2_15(VtValue vtVal) => default; // 0x000000018C0EE9C0-0x000000018C0EEA3C
			internal VtValue _RegisterTypes_b__2_16(object obj) => default; // 0x000000018C0EEA3C-0x000000018C0EEAA0
			internal object _RegisterTypes_b__2_17(VtValue vtVal) => default; // 0x000000018C0EEAA0-0x000000018C0EEB10
			internal VtValue _RegisterTypes_b__2_18(object obj) => default; // 0x000000018C0EEB10-0x000000018C0EEB8C
			internal object _RegisterTypes_b__2_19(VtValue vtVal) => default; // 0x000000018C0EEB8C-0x000000018C0EEC04
		}
	
		// Constructors
		static UnityTypeBindings() {} // 0x000000018C0EEC04-0x000000018C0EEC90
	
		// Methods
		public static void RegisterTypes() {} // 0x000000018C0EEC90-0x000000018C0EED2C
	}

	internal class PreserveAttribute : Attribute // TypeDefIndex: 60029
	{
		// Constructors
		public PreserveAttribute() {} // 0x0000000185492010-0x0000000185492020
	}

	public class UnityTypeConverter : IntrinsicTypeConverter // TypeDefIndex: 60031
	{
		// Fields
		public static Matrix4x4 basisChange; // 0x00
		public static Matrix4x4 inverseBasisChange; // 0x40
	
		// Nested types
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 60030
		{
			// Fields
			public Transform transform; // 0x10
			public string name; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0() {} // 0x000000018C0F1144-0x000000018C0F1290
	
			// Methods
			internal bool _HasAnySiblingsWithName_b__0(GameObject sibling) => default; // 0x000000018C0F10BC-0x000000018C0F1144
		}
	
		// Constructors
		public UnityTypeConverter() {} // 0x0000000185492010-0x0000000185492020
		static UnityTypeConverter() {} // 0x000000018C0EF154-0x000000018C0EF1EC
	
		// Methods
		public static Matrix4x4 ChangeBasis(Matrix4x4 input) => default; // 0x000000018C0F40BC-0x000000018C0F41C8
		public static Vector3 ChangeBasis(Vector3 point) => default; // 0x000000018C0F1694-0x000000018C0F20B0
		public static void SetTransform(Matrix4x4 localXf, Transform transform) {} // 0x000000018C0F53C4-0x000000018C0F5460
		public static bool Decompose(Matrix4x4 matrix, out Vector3 translation, out Quaternion rotation, out Vector3 scale) {
			translation = default;
			rotation = default;
			scale = default;
			return default;
		} // 0x000000018C0F25FC-0x000000018C0F2718
		private static Vector3 WeightedAvg(Vector3 a, Vector3 b, float aWeight, float bWeight) => default; // 0x000000018C0F2480-0x000000018C0F2510
		public static void ExtractTrs(Matrix4x4 transform, ref Vector3 localPosition, ref Quaternion localRotation, ref Vector3 localScale) {} // 0x0000000185FEAE70-0x0000000185FEAE90
		private static Quaternion ExtractRotation(Matrix4x4 mat4) => default; // 0x000000018C0F2510-0x000000018C0F25FC
		private static Vector3 ExtractPosition(Matrix4x4 mat4) => default; // 0x000000018C0F34C0-0x000000018C0F3848
		private static Vector3 ExtractScale(Matrix4x4 mat4) => default; // 0x000000018C0F3404-0x000000018C0F34C0
		private static bool HasAnySiblingsWithName(Transform transform, string name) => default; // 0x000000018C0F33B8-0x000000018C0F3404
		public static string GetUniqueName(Transform transform) => default; // 0x000000018C0F31F0-0x000000018C0F33B8
		public static string GetPath(Transform unityObj) => default; // 0x000000018C0F310C-0x000000018C0F31F0
		public static string GetPath(Transform unityObj, Transform unityObjRoot) => default; // 0x000000018C0F4264-0x000000018C0F42E0
		public static Matrix4x4 GetLocalToParentXf(Transform unityXf) => default; // 0x000000018C0F42E0-0x000000018C0F45D4
		public static GfMatrix4d ToGfMatrix(Transform unityXf) => default; // 0x000000018C0F2718-0x000000018C0F2A34
		public static GfMatrix4d ToGfMatrix(Matrix4x4 unityMat4) => default; // 0x000000018C0F4950-0x000000018C0F4A4C
		public static Matrix4x4 FromMatrix(GfMatrix4d gfMat) => default; // 0x000000018C0F2D80-0x000000018C0F2EAC
		public static VtMatrix4dArray ToVtArray(Matrix4x4[] input) => default; // 0x000000018C0F3EA4-0x000000018C0F3F10
		public static Matrix4x4[] FromVtArray(VtMatrix4dArray input) => default; // 0x000000018C0F3848-0x000000018C0F398C
		public static VtMatrix4dArray ListToVtArray(List<Matrix4x4> input) => default; // 0x000000018C0F1414-0x000000018C0F1478
		public static List<Matrix4x4> ListFromVtArray(VtMatrix4dArray input) => default; // 0x000000018C0F517C-0x000000018C0F51D8
		public static GfVec4f Color32ToVec4f(Color32 c) => default; // 0x000000018C0F4D2C-0x000000018C0F4D98
		public static Color32 Vec4fToColor32(GfVec4f v) => default; // 0x000000018C0F4C10-0x000000018C0F4C9C
		public static VtVec4fArray ToVtArray(List<Color32> input) => default; // 0x000000018C0F4F84-0x000000018C0F5070
		public static void ToVtArray(List<Color32> input, out VtVec3fArray rgb, out VtFloatArray alpha) {
			rgb = default;
			alpha = default;
		} // 0x000000018C0F1290-0x000000018C0F1414
		public static VtVec4fArray ToVtArray(Color32[] input) => default; // 0x000000018C0F161C-0x000000018C0F1694
		public static Color32[] Color32FromVtArray(VtVec4fArray input) => default; // 0x000000018C0F51D8-0x000000018C0F5278
		public static GfVec4f ColorToVec4f(UnityEngine.Color c) => default; // 0x000000018C0F45D4-0x000000018C0F4640
		public static UnityEngine.Color Vec4fToColor(GfVec4f v) => default; // 0x000000018C0F47A4-0x000000018C0F4830
		public static VtVec4fArray ToVtArray(List<UnityEngine.Color> input) => default; // 0x000000018C0F4714-0x000000018C0F47A4
		public static void ToVtArray(List<UnityEngine.Color> input, out VtVec3fArray rgb, out VtFloatArray alpha) {
			rgb = default;
			alpha = default;
		} // 0x000000018C0F1478-0x000000018C0F1528
		public static VtVec4fArray ToVtArray(UnityEngine.Color[] input) => default; // 0x000000018C0F1528-0x000000018C0F161C
		public static UnityEngine.Color[] ColorFromVtArray(VtVec4fArray input) => default; // 0x000000018C0F4D98-0x000000018C0F4F84
		public static UnityEngine.Color[] ColorFromVtArray(VtVec4fArray input, ref UnityEngine.Color[] output) => default; // 0x000000018C0F2238-0x000000018C0F237C
		public static void ToVtArray(Color32[] input, out VtVec3fArray rgb, out VtFloatArray alpha) {
			rgb = default;
			alpha = default;
		} // 0x000000018C0F20B0-0x000000018C0F217C
		public static Vector3[] ExtractRgb(Color32[] colors) => default; // 0x000000018C0F4A4C-0x000000018C0F4C10
		public static float[] ExtractAlpha(Color32[] colors) => default; // 0x000000018C0F2EAC-0x000000018C0F3054
		public static void ToVtArray(UnityEngine.Color[] input, out VtVec3fArray rgb, out VtFloatArray alpha) {
			rgb = default;
			alpha = default;
		} // 0x000000018C0F237C-0x000000018C0F2480
		public static UnityEngine.Color[] FromVtArray(VtVec3fArray rgbIn, VtFloatArray alphaIn) => default; // 0x000000018C0F217C-0x000000018C0F2238
		public static Vector3[] ExtractRgb(UnityEngine.Color[] colors) => default; // 0x000000018C0F41C8-0x000000018C0F4264
		public static float[] ExtractAlpha(UnityEngine.Color[] colors) => default; // 0x000000018C0F3F10-0x000000018C0F3F88
		private static void SwapQuaternionReal(ref Quaternion[] input) {} // 0x000000018C0F3F88-0x000000018C0F4044
		public static GfQuatf QuaternionToQuatf(Quaternion quaternion) => default; // 0x000000018C0F4640-0x000000018C0F4714
		public static Quaternion QuatfToQuaternion(GfQuatf quat) => default; // 0x000000018C0F2A34-0x000000018C0F2B18
		public static VtQuatfArray ToVtArray(Quaternion[] input) => default; // 0x000000018C0F3E38-0x000000018C0F3EA4
		public static Quaternion[] FromVtArray(VtQuatfArray input) => default; // 0x000000018C0F3BFC-0x000000018C0F3CF4
		public static VtQuatfArray ListToVtArray(List<Quaternion> input) => default; // 0x000000018C0F4830-0x000000018C0F48C0
		public static List<Quaternion> ListFromVtArray(VtQuatfArray input) => default; // 0x000000018C0F2C08-0x000000018C0F2CC4
		public static VtVec4fArray ToVtArray(Vector4[] input) => default; // 0x000000018C0F3D60-0x000000018C0F3DCC
		public static Vector4[] FromVtArray(VtVec4fArray input) => default; // 0x000000018C0F398C-0x000000018C0F3A5C
		public static VtVec4fArray ListToVtArray(List<Vector4> input) => default; // 0x000000018C0F0EFC-0x000000018C0F10BC
		public static List<Vector4> ListFromVtArray(VtVec4fArray input) => default; // 0x000000018C0F0C88-0x000000018C0F0EFC
		public static VtVec3fArray BoundsToVtArray(Bounds input) => default; // 0x000000018C0F0B88-0x000000018C0F0C88
		public static Bounds BoundsFromVtArray(VtValue vtBounds) => default; // 0x000000018C0F48C0-0x000000018C0F4950
		public static Bounds BoundsFromVtArray(VtValue vtBounds, Vector3[] bbox) => default; // 0x000000018C0F3054-0x000000018C0F310C
		public static VtVec3fArray ToVtArray(Vector3[] input) => default; // 0x000000018C0F2B18-0x000000018C0F2C08
		public static Vector3[] FromVtArray(VtVec3fArray input) => default; // 0x000000018C0F3CF4-0x000000018C0F3D60
		public static void FromVtArray(VtVec3fArray input, ref Vector3[] output) {} // 0x000000018C0F3A5C-0x000000018C0F3B2C
		public static VtVec3fArray ListToVtArray(List<Vector3> input) => default; // 0x000000018C0F4C9C-0x000000018C0F4D2C
		public static List<Vector3> ListFromVtArray(VtVec3fArray input) => default; // 0x000000018C0F2CC4-0x000000018C0F2D80
		public static VtVec2fArray ToVtArray(Vector2[] input) => default; // 0x000000018C0F3DCC-0x000000018C0F3E38
		public static Vector2[] FromVtArray(VtVec2fArray input) => default; // 0x000000018C0F3B2C-0x000000018C0F3BFC
		public static VtVec2fArray ListToVtArray(List<Vector2> input) => default; // 0x000000018C0F5278-0x000000018C0F52DC
		public static List<Vector2> ListFromVtArray(VtVec2fArray input) => default; // 0x000000018C0F5070-0x000000018C0F5100
		public static GfVec2f Vector2ToVec2f(Vector2 vec2) => default; // 0x000000018C0F52DC-0x000000018C0F534C
		public static Vector2 Vec2fToVector2(GfVec2f value) => default; // 0x000000018C0F5100-0x000000018C0F517C
		public static GfVec3f Vector3ToVec3f(Vector3 vec3) => default; // 0x000000018C0F534C-0x000000018C0F53C4
		public static Vector3 Vec3fToVector3(GfVec3f v3) => default; // 0x000000018C0F51D8-0x000000018C0F5278
		public static GfVec4f Vector4ToVec4f(Vector4 vector4) => default; // 0x000000018C0F4044-0x000000018C0F40BC
		public static Vector4 Vec4fToVector4(GfVec4f v4) => default; // 0x000000018C0F51D8-0x000000018C0F5278
		public static GfVec4f RectToVtVec4(Rect rect) => default; // 0x0000000185492010-0x0000000185492020
		public static Rect Vec4fToRect(GfVec4f v4) => default; // 0x000000018C0F5460-0x000000018C0F5554
	}
}
