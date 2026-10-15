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

// Image 83: USD.NET.Unity.dll - Assembly: USD.NET.Unity, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89933-89984

namespace USD.NET.Unity
{
	public class DiagnosticHandler : pxr.DiagnosticHandler // TypeDefIndex: 89934
	{
		// Constructors
		public DiagnosticHandler(); // 0x000000018D6FFF48-0x000000018D6FFF50
	
		// Methods
		public override void OnFatalError(string msg); // 0x000000018D6FFDE0-0x000000018D6FFE80
		public override void OnError(string msg); // 0x000000018D6FFD1C-0x000000018D6FFDE0
		public override void OnWarning(string msg); // 0x000000018D6FFEE4-0x000000018D6FFF48
		public override void OnInfo(string msg); // 0x000000018D6FFE80-0x000000018D6FFEE4
	}

	[Serializable]
	[UsdSchema("BasisCurves")]
	public class BasisCurvesSample : CurvesSample // TypeDefIndex: 89938
	{
		// Fields
		public CurveType type; // 0xB0
		public Basis basis; // 0xB4
		public WrapMode wrap; // 0xB8
	
		// Nested types
		public enum CurveType // TypeDefIndex: 89935
		{
			Linear = 0,
			Cubic = 1
		}
	
		public enum Basis // TypeDefIndex: 89936
		{
			Bezier = 0,
			Bspline = 1,
			CatmullRom = 2,
			Hermite = 3,
			Power = 4
		}
	
		public enum WrapMode // TypeDefIndex: 89937
		{
			Nonperiodic = 0,
			Periodic = 1
		}
	
		// Constructors
		public BasisCurvesSample(); // 0x000000018D6FF774-0x000000018D6FF77C
	}

	[Serializable]
	[UsdSchema("UsdGeomBoundable")]
	public class BoundableSample : XformableSample // TypeDefIndex: 89939
	{
		// Fields
		public Bounds extent; // 0x60
	
		// Constructors
		public BoundableSample(); // 0x000000018D2C9B30-0x000000018D2C9B38
	}

	[Serializable]
	[UsdSchema("Camera")]
	public class CameraSample : XformSample // TypeDefIndex: 89943
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
		public enum ProjectionType // TypeDefIndex: 89940
		{
			Perspective = 0,
			Orthographic = 1
		}
	
		[Serializable]
		public enum StereoRole // TypeDefIndex: 89941
		{
			Mono = 0,
			Left = 1,
			Right = 2
		}
	
		[Serializable]
		public class Shutter : SampleBase // TypeDefIndex: 89942
		{
			// Fields
			public double open; // 0x10
			public double close; // 0x18
	
			// Constructors
			public Shutter(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public CameraSample(); // 0x000000018D2C9B30-0x000000018D2C9B38
		public CameraSample(Camera fromCamera); // 0x000000018D6FFC10-0x000000018D6FFC44
	
		// Methods
		public void CopyFromCamera(Camera camera, bool convertTransformToUsd = true /* Metadata: 0x0264AA43 */); // 0x000000018D6FF77C-0x000000018D6FF9B4
		public void CopyToCamera(Camera camera, bool setTransform); // 0x000000018D6FF9B4-0x000000018D6FFC10
	}

	[Serializable]
	[UsdSchema("Cube")]
	public class CubeSample : GprimSample // TypeDefIndex: 89944
	{
		// Fields
		private double m_size; // 0x80
	
		// Properties
		public double size { get; set; } // 0x00000001872350F0-0x0000000187235100 0x000000018D6FFC70-0x000000018D6FFD1C
	
		// Constructors
		public CubeSample(); // 0x000000018D6FF774-0x000000018D6FF77C
		public CubeSample(double size); // 0x000000018D6FFC44-0x000000018D6FFC70
	}

	[Serializable]
	[UsdSchema("Curves")]
	public class CurvesSample : PointBasedSample // TypeDefIndex: 89945
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
		public CurvesSample(); // 0x000000018D6FF774-0x000000018D6FF77C
	}

	[Serializable]
	[UsdSchema("UsdGeomGprim")]
	public class GprimSample : BoundableSample // TypeDefIndex: 89946
	{
		// Fields
		[FusedDisplayColor]
		[VertexData]
		public Primvar<UnityEngine.Color[]> colors; // 0x78
	
		// Constructors
		public GprimSample(); // 0x000000018D6FFF50-0x000000018D6FFFBC
	}

	[Serializable]
	[UsdSchema("UsdGeomImageable")]
	public class ImageableSample : SampleBase // TypeDefIndex: 89947
	{
		// Constructors
		public ImageableSample(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[UsdSchema("Mesh")]
	public class MeshSample : MeshSampleBase // TypeDefIndex: 89948
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
		public MeshSample(); // 0x000000018D2CBBB8-0x000000018D2CBBC0
	
		// Methods
		public void SetTriangles(int[] triangleIndices); // 0x000000018D700EB8-0x000000018D700F74
	}

	[Serializable]
	[UsdSchema("Mesh")]
	public class MeshSampleBase : PointBasedSample, IArbitraryPrimvars // TypeDefIndex: 89949
	{
		// Fields
		public int[] faceVertexIndices; // 0x80
		public Vector3[] points; // 0x88
		public Vector3[] normals; // 0x90
		public Primvar<Vector4[]> tangents; // 0x98
		[ForceNoNamespace]
		public Dictionary<string, Primvar<object>> ArbitraryPrimvars; // 0xA0
	
		// Constructors
		public MeshSampleBase(); // 0x000000018D700DE8-0x000000018D700EB8
	
		// Methods
		public Dictionary<string, Primvar<object>> GetArbitraryPrimvars(); // 0x0000000187232F60-0x0000000187232F70
		public void AddPrimvars(List<string> primvars); // 0x000000018D700BF8-0x000000018D700DE8
	}

	[Serializable]
	[UsdSchema("UsdGeomPointBased")]
	public class PointBasedSample : GprimSample // TypeDefIndex: 89950
	{
		// Constructors
		public PointBasedSample(); // 0x000000018D6FF774-0x000000018D6FF77C
	}

	[Serializable]
	[UsdSchema("PointInstancer")]
	public class PointInstancerPrototypesSample : BoundableSample // TypeDefIndex: 89951
	{
		// Fields
		public Relationship prototypes; // 0x78
	
		// Constructors
		public PointInstancerPrototypesSample(); // 0x000000018D7010AC-0x000000018D701104
	}

	[Serializable]
	[UsdSchema("PointInstancer")]
	public class PointInstancerSample : PointInstancerPrototypesSample // TypeDefIndex: 89952
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
		public PointInstancerSample(); // 0x000000018D70135C-0x000000018D701364
	
		// Methods
		public Matrix4x4[] ComputeInstanceMatrices(Scene scene, string primPath); // 0x000000018D701104-0x000000018D70135C
	}

	[Serializable]
	[UsdSchema("Scope")]
	public class ScopeSample : ImageableSample // TypeDefIndex: 89953
	{
		// Constructors
		public ScopeSample(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	[Serializable]
	[UsdSchema("Sphere")]
	public class SphereSample : GprimSample // TypeDefIndex: 89954
	{
		// Fields
		private double m_radius; // 0x80
	
		// Properties
		public double radius { get; set; } // 0x00000001872350F0-0x0000000187235100 0x000000018D701870-0x000000018D701940
	
		// Constructors
		public SphereSample(); // 0x000000018D6FF774-0x000000018D6FF77C
		public SphereSample(double radius); // 0x000000018D6FFC44-0x000000018D6FFC70
	}

	[Serializable]
	[UsdSchema("UsdGeomXformable")]
	public class XformableSample : ImageableSample // TypeDefIndex: 89955
	{
		// Fields
		private readonly string[] kXformOpTransform; // 0x10
		private Matrix4x4 m_xf; // 0x18
		[UsdVariability(Variability.Uniform)]
		public string[] xformOpOrder; // 0x58
	
		// Properties
		[FusedTransform]
		[UsdNamespace("xformOp")]
		public Matrix4x4 transform { get; set; } // 0x00000001872459D0-0x0000000187245A00 0x000000018D70A848-0x000000018D70A890
	
		// Constructors
		public XformableSample(); // 0x000000018D70A788-0x000000018D70A848
	
		// Methods
		public static XformableSample FromTransform(Transform transform); // 0x000000018D70A64C-0x000000018D70A788
		public void ConvertTransform(); // 0x000000018D70A588-0x000000018D70A64C
	}

	[Serializable]
	[UsdSchema("Xform")]
	public class XformSample : XformableSample // TypeDefIndex: 89956
	{
		// Constructors
		public XformSample(); // 0x000000018D2C9B30-0x000000018D2C9B38
	}

	[Serializable]
	public class MaterialBindingSample : SampleBase // TypeDefIndex: 89957
	{
		// Fields
		[UsdNamespace("material")]
		public Relationship binding; // 0x10
	
		// Constructors
		public MaterialBindingSample(); // 0x0000000186805BA0-0x0000000186805BB0
		public MaterialBindingSample(string materialPath); // 0x000000018D700124-0x000000018D70019C
	}

	[Serializable]
	[UsdSchema("Material")]
	public class MaterialSample : SampleBase // TypeDefIndex: 89958
	{
		// Fields
		[UsdNamespace("outputs")]
		public Connectable<TfToken> surface; // 0x10
		[UsdNamespace("outputs")]
		public Connectable<TfToken> displacement; // 0x18
		public string[] requiredKeywords; // 0x20
	
		// Constructors
		public MaterialSample(); // 0x000000018D700AB0-0x000000018D700B28
		public MaterialSample(string surfacePath); // 0x000000018D700A08-0x000000018D700AB0
		public MaterialSample(string surfacePath, string displacementPath); // 0x000000018D700B28-0x000000018D700BF8
	
		// Methods
		public static bool ReadMaterial(Scene scene, string geometryPath, MaterialSample materialSample, out string shaderId); // 0x000000018D700424-0x000000018D7008B0
		public static void Bind(Scene scene, string primPath, string materialPath); // 0x000000018D70019C-0x000000018D700424
		public static void Unbind(Scene scene, string primPath); // 0x000000018D7008B0-0x000000018D700A08
	}

	public struct ParameterInfo // TypeDefIndex: 89959
	{
		// Fields
		public object value; // 0x00
		public string connectedPath; // 0x08
		public string usdName; // 0x10
		public string unityName; // 0x18
		public string[] requiredShaderKeywords; // 0x20
	
		// Methods
		public override string ToString(); // 0x000000018D700F74-0x000000018D7010AC
	}

	public class InputParameterAttribute : UsdNamespaceAttribute // TypeDefIndex: 89960
	{
		// Fields
		[CompilerGenerated]
		private string _UnityName_k__BackingField; // 0x18
	
		// Properties
		public string UnityName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public InputParameterAttribute(); // 0x000000018D700014-0x000000018D700070
		public InputParameterAttribute(string unityName); // 0x000000018D6FFFBC-0x000000018D700014
	}

	public class InputTextureAttribute : UsdNamespaceAttribute // TypeDefIndex: 89961
	{
		// Fields
		[CompilerGenerated]
		private string _UnityName_k__BackingField; // 0x18
	
		// Properties
		public string UnityName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182234E30-0x0000000182234E40 0x0000000187835500-0x0000000187835510
	
		// Constructors
		public InputTextureAttribute(); // 0x000000018D700070-0x000000018D7000CC
		public InputTextureAttribute(string unityName); // 0x000000018D7000CC-0x000000018D700124
	}

	public class RequireShaderKeywordsAttribute : Attribute // TypeDefIndex: 89962
	{
		// Fields
		[CompilerGenerated]
		private string[] _Keywords_k__BackingField; // 0x10
	
		// Properties
		public string[] Keywords { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x00000001829260F0-0x0000000182926100 0x0000000184FD2410-0x0000000184FD2420
	
		// Constructors
		public RequireShaderKeywordsAttribute(string keyword); // 0x000000018D7016F4-0x000000018D701770
		public RequireShaderKeywordsAttribute(string[] keywords); // 0x0000000184FD2410-0x0000000184FD2420
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class ShaderSample : SampleBase // TypeDefIndex: 89967
	{
		// Fields
		[UsdNamespace("info")]
		public TfToken id; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 89963
		{
			// Fields
			public System.Type inputParamType; // 0x10
			public Func<System.Reflection.FieldInfo, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetInputParameters_b__0(System.Reflection.FieldInfo info); // 0x000000018D7041A4-0x000000018D7041BC
		}
	
		[CompilerGenerated]
		private sealed class _GetInputParameters_d__3 : IEnumerable<ParameterInfo>, IEnumerator<ParameterInfo> // TypeDefIndex: 89964
		{
			// Fields
			private int __1__state; // 0x10
			private ParameterInfo __2__current; // 0x18
			private int __l__initialThreadId; // 0x40
			public ShaderSample __4__this; // 0x48
			private __c__DisplayClass3_0 __8__1; // 0x50
			private IEnumerator<System.Reflection.FieldInfo> __7__wrap1; // 0x58
	
			// Properties
			ParameterInfo IEnumerator<USD.NET.Unity.ParameterInfo>.Current { [DebuggerHidden] get; } // 0x000000018723FF30-0x000000018723FF50 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D702B88-0x000000018D702BE4 
	
			// Constructors
			[DebuggerHidden]
			public _GetInputParameters_d__3(int __1__state); // 0x000000018D702CA8-0x000000018D702CC4
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D702BE4-0x000000018D702C5C
			private bool MoveNext(); // 0x000000018D702320-0x000000018D702AA4
			private void __m__Finally1(); // 0x000000018D702C5C-0x000000018D702CA8
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D702B3C-0x000000018D702B88
			[DebuggerHidden]
			IEnumerator<ParameterInfo> IEnumerable<ParameterInfo>.GetEnumerator(); // 0x000000018D702AA4-0x000000018D702B34
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D702B34-0x000000018D702B3C
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 89965
		{
			// Fields
			public System.Type inputParamType; // 0x10
			public Func<System.Reflection.FieldInfo, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _GetInputTextures_b__0(System.Reflection.FieldInfo info); // 0x000000018D7041A4-0x000000018D7041BC
		}
	
		[CompilerGenerated]
		private sealed class _GetInputTextures_d__4 : IEnumerable<ParameterInfo>, IEnumerator<ParameterInfo> // TypeDefIndex: 89966
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
			ParameterInfo IEnumerator<USD.NET.Unity.ParameterInfo>.Current { [DebuggerHidden] get; } // 0x000000018723FF30-0x000000018723FF50 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018D7036C0-0x000000018D70371C 
	
			// Constructors
			[DebuggerHidden]
			public _GetInputTextures_d__4(int __1__state); // 0x000000018D702CA8-0x000000018D702CC4
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018D70371C-0x000000018D703794
			private bool MoveNext(); // 0x000000018D702CC4-0x000000018D7035DC
			private void __m__Finally1(); // 0x000000018D703794-0x000000018D7037E0
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018D703674-0x000000018D7036C0
			[DebuggerHidden]
			IEnumerator<ParameterInfo> IEnumerable<ParameterInfo>.GetEnumerator(); // 0x000000018D7035DC-0x000000018D70366C
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018D70366C-0x000000018D703674
		}
	
		// Constructors
		public ShaderSample(); // 0x0000000186805BA0-0x0000000186805BB0
	
		// Methods
		private System.Type GetClassType(); // 0x0000000187834490-0x000000018783449C
		private object GetValue(System.Reflection.FieldInfo info); // 0x000000018D701850-0x000000018D701870
		[IteratorStateMachine(typeof(_GetInputParameters_d__3))]
		public IEnumerable<ParameterInfo> GetInputParameters(); // 0x000000018D701770-0x000000018D7017E0
		[IteratorStateMachine(typeof(_GetInputTextures_d__4))]
		public IEnumerable<ParameterInfo> GetInputTextures(); // 0x000000018D7017E0-0x000000018D701850
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class StandardShaderSample : ShaderSample // TypeDefIndex: 89968
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
		public StandardShaderSample(); // 0x000000018D701940-0x000000018D701E6C
	}

	[Serializable]
	[UsdSchema("Texture2D")]
	public class Texture2DSample : SampleBase // TypeDefIndex: 89969
	{
		// Fields
		[UsdAssetPath]
		[UsdNamespace("inputs")]
		public Connectable<string> sourceFile; // 0x10
		public bool sRgb; // 0x18
	
		// Constructors
		public Texture2DSample(); // 0x000000018D701E6C-0x000000018D701EC8
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class PreviewSurfaceSample : ShaderSample // TypeDefIndex: 89971
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
		public class Outputs : SampleBase // TypeDefIndex: 89970
		{
			// Fields
			public TfToken displacement; // 0x10
			public TfToken surface; // 0x18
	
			// Constructors
			public Outputs(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public PreviewSurfaceSample(); // 0x000000018D701364-0x000000018D7016F4
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class PrimvarReaderSample<T> : ShaderSample // TypeDefIndex: 89973
		where T : struct
	{
		// Fields
		[InputParameter("_Fallback")]
		public Connectable<T> fallback;
		[UsdNamespace("outputs")]
		public Outputs outputs;
	
		// Nested types
		public class Outputs : SampleBase // TypeDefIndex: 89972
		{
			// Fields
			public T? result;
	
			// Constructors
			public Outputs();
		}
	
		// Constructors
		public PrimvarReaderSample();
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class PrimvarReaderImportSample<T> : PrimvarReaderSample<T> // TypeDefIndex: 89974
		where T : struct
	{
		// Fields
		[InputParameter("_Varname")]
		public Connectable<string> varname;
	
		// Constructors
		public PrimvarReaderImportSample();
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class PrimvarReaderExportSample<T> : PrimvarReaderSample<T> // TypeDefIndex: 89975
		where T : struct
	{
		// Fields
		[InputParameter("_Varname")]
		public Connectable<TfToken> varname;
	
		// Constructors
		public PrimvarReaderExportSample();
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class TextureReaderSample : ShaderSample // TypeDefIndex: 89979
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
		public enum WrapMode // TypeDefIndex: 89976
		{
			Black = 0,
			Clamp = 1,
			Repeat = 2,
			Mirror = 3
		}
	
		public enum SRGBMode // TypeDefIndex: 89977
		{
			Yes = 0,
			No = 1,
			Auto = 2
		}
	
		public class Outputs : SampleBase // TypeDefIndex: 89978
		{
			// Fields
			public float? r; // 0x10
			public float? g; // 0x18
			public float? b; // 0x20
			public float? a; // 0x28
			public Vector3? rgb; // 0x30
			public Vector4? rgba; // 0x40
	
			// Constructors
			public Outputs(); // 0x0000000186805BA0-0x0000000186805BB0
		}
	
		// Constructors
		public TextureReaderSample(); // 0x000000018D701EF0-0x000000018D7021D4
		public TextureReaderSample(string filePath); // 0x000000018D702298-0x000000018D702320
		public TextureReaderSample(string filePath, string stConnectionPath); // 0x000000018D7021D4-0x000000018D702298
	
		// Methods
		public static WrapMode GetWrapMode(TextureWrapMode wrap); // 0x000000018D701EC8-0x000000018D701EF0
	}

	public static class UnityTypeBindings // TypeDefIndex: 89981
	{
		// Fields
		private static bool isInitialized; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 89980
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
			static __c(); // 0x000000018D7041BC-0x000000018D704220
			public __c(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal VtValue _RegisterTypes_b__2_0(object obj); // 0x000000018D7037E0-0x000000018D703850
			internal object _RegisterTypes_b__2_1(VtValue value); // 0x000000018D703CE4-0x000000018D703D60
			internal VtValue _RegisterTypes_b__2_2(object obj); // 0x000000018D703D60-0x000000018D703DC8
			internal object _RegisterTypes_b__2_3(VtValue value); // 0x000000018D703DC8-0x000000018D703E38
			internal VtValue _RegisterTypes_b__2_4(object obj); // 0x000000018D703E38-0x000000018D703EB0
			internal object _RegisterTypes_b__2_5(VtValue value); // 0x000000018D703EB0-0x000000018D703F34
			internal VtValue _RegisterTypes_b__2_6(object obj); // 0x000000018D703F34-0x000000018D703FA4
			internal object _RegisterTypes_b__2_7(VtValue value); // 0x000000018D703FA4-0x000000018D704020
			internal VtValue _RegisterTypes_b__2_8(object obj); // 0x000000018D704020-0x000000018D704090
			internal object _RegisterTypes_b__2_9(VtValue value); // 0x000000018D704090-0x000000018D70410C
			internal VtValue _RegisterTypes_b__2_10(object obj); // 0x000000018D703850-0x000000018D7038B8
			internal object _RegisterTypes_b__2_11(VtValue vtVal); // 0x000000018D7038B8-0x000000018D703908
			internal VtValue _RegisterTypes_b__2_12(object obj); // 0x000000018D703908-0x000000018D703978
			internal object _RegisterTypes_b__2_13(VtValue vtVal); // 0x000000018D703978-0x000000018D7039F4
			internal VtValue _RegisterTypes_b__2_14(object obj); // 0x000000018D7039F4-0x000000018D703A58
			internal object _RegisterTypes_b__2_15(VtValue vtVal); // 0x000000018D703A58-0x000000018D703AC8
			internal VtValue _RegisterTypes_b__2_16(object obj); // 0x000000018D703AC8-0x000000018D703B44
			internal object _RegisterTypes_b__2_17(VtValue vtVal); // 0x000000018D703B44-0x000000018D703BBC
			internal VtValue _RegisterTypes_b__2_18(object obj); // 0x000000018D703BBC-0x000000018D703C48
			internal object _RegisterTypes_b__2_19(VtValue vtVal); // 0x000000018D703C48-0x000000018D703CE4
		}
	
		// Constructors
		static UnityTypeBindings(); // 0x000000018D705B38-0x000000018D705B40
	
		// Methods
		public static void RegisterTypes(); // 0x000000018D704220-0x000000018D705B38
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	internal class PreserveAttribute : Attribute // TypeDefIndex: 89982
	{
		// Constructors
		public PreserveAttribute(); // 0x0000000186805BA0-0x0000000186805BB0
	}

	public class UnityTypeConverter : IntrinsicTypeConverter // TypeDefIndex: 89984
	{
		// Fields
		public static Matrix4x4 basisChange; // 0x00
		public static Matrix4x4 inverseBasisChange; // 0x40
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 89983
		{
			// Fields
			public Transform transform; // 0x10
			public string name; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x0000000186805BA0-0x0000000186805BB0
	
			// Methods
			internal bool _HasAnySiblingsWithName_b__0(GameObject sibling); // 0x000000018D70410C-0x000000018D7041A4
		}
	
		// Constructors
		public UnityTypeConverter(); // 0x0000000186805BA0-0x0000000186805BB0
		static UnityTypeConverter(); // 0x000000018D70A494-0x000000018D70A588
	
		// Methods
		public static Matrix4x4 ChangeBasis(Matrix4x4 input); // 0x000000018D706108-0x000000018D706254
		public static Vector3 ChangeBasis(Vector3 point); // 0x000000018D706080-0x000000018D706108
		public static void SetTransform(Matrix4x4 localXf, Transform transform); // 0x000000018D7090D4-0x000000018D7091E4
		public static bool Decompose(Matrix4x4 matrix, out Vector3 translation, out Quaternion rotation, out Vector3 scale); // 0x000000018D706674-0x000000018D707090
		private static Vector3 WeightedAvg(Vector3 a, Vector3 b, float aWeight, float bWeight); // 0x000000018D70A3F8-0x000000018D70A494
		public static void ExtractTrs(Matrix4x4 transform, ref Vector3 localPosition, ref Quaternion localRotation, ref Vector3 localScale); // 0x000000018D7075F0-0x000000018D70770C
		private static Quaternion ExtractRotation(Matrix4x4 mat4); // 0x000000018D707474-0x000000018D707504
		private static Vector3 ExtractPosition(Matrix4x4 mat4); // 0x000000018723AA00-0x000000018723AA20
		private static Vector3 ExtractScale(Matrix4x4 mat4); // 0x000000018D707504-0x000000018D7075F0
		private static bool HasAnySiblingsWithName(Transform transform, string name); // 0x000000018D7084CC-0x000000018D708840
		public static string GetUniqueName(Transform transform); // 0x000000018D708410-0x000000018D7084CC
		public static string GetPath(Transform unityObj); // 0x000000018D7083C4-0x000000018D708410
		public static string GetPath(Transform unityObj, Transform unityObjRoot); // 0x000000018D7081FC-0x000000018D7083C4
		public static Matrix4x4 GetLocalToParentXf(Transform unityXf); // 0x000000018D708114-0x000000018D7081FC
		[Preserve]
		public static GfMatrix4d ToGfMatrix(Transform unityXf); // 0x000000018D709280-0x000000018D7092FC
		[Preserve]
		public static GfMatrix4d ToGfMatrix(Matrix4x4 unityMat4); // 0x000000018D7092FC-0x000000018D7095F0
		[Preserve]
		public static Matrix4x4 FromMatrix(GfMatrix4d gfMat); // 0x000000018D70770C-0x000000018D707A28
		[Preserve]
		public static VtMatrix4dArray ToVtArray(Matrix4x4[] input); // 0x000000018D70996C-0x000000018D709A68
		[Preserve]
		public static Matrix4x4[] FromVtArray(VtMatrix4dArray input); // 0x000000018D707D7C-0x000000018D707EA8
		[Preserve]
		public static VtMatrix4dArray ListToVtArray(List<Matrix4x4> input); // 0x000000018D708EB4-0x000000018D708F20
		[Preserve]
		public static List<Matrix4x4> ListFromVtArray(VtMatrix4dArray input); // 0x000000018D708840-0x000000018D708984
		[Preserve]
		public static GfVec4f Color32ToVec4f(Color32 c); // 0x000000018D7063E4-0x000000018D706448
		[Preserve]
		public static Color32 Vec4fToColor32(GfVec4f v); // 0x000000018D70A1AC-0x000000018D70A208
		[Preserve]
		public static VtVec4fArray ToVtArray(List<Color32> input); // 0x000000018D709D58-0x000000018D709DC4
		[Preserve]
		public static void ToVtArray(List<Color32> input, out VtVec3fArray rgb, out VtFloatArray alpha); // 0x000000018D709C3C-0x000000018D709CC8
		[Preserve]
		public static VtVec4fArray ToVtArray(Color32[] input); // 0x000000018D709FB4-0x000000018D70A0A0
		[Preserve]
		public static Color32[] Color32FromVtArray(VtVec4fArray input); // 0x000000018D706254-0x000000018D7063E4
		[Preserve]
		public static GfVec4f ColorToVec4f(UnityEngine.Color c); // 0x000000018D7065F8-0x000000018D706674
		[Preserve]
		public static UnityEngine.Color Vec4fToColor(GfVec4f v); // 0x000000018D70A208-0x000000018D70A2A8
		[Preserve]
		public static VtVec4fArray ToVtArray(List<UnityEngine.Color> input); // 0x000000018D7095F0-0x000000018D70965C
		[Preserve]
		public static void ToVtArray(List<UnityEngine.Color> input, out VtVec3fArray rgb, out VtFloatArray alpha); // 0x000000018D7097C0-0x000000018D70984C
		[Preserve]
		public static VtVec4fArray ToVtArray(UnityEngine.Color[] input); // 0x000000018D709730-0x000000018D7097C0
		[Preserve]
		public static UnityEngine.Color[] ColorFromVtArray(VtVec4fArray input); // 0x000000018D706448-0x000000018D706504
		[Preserve]
		public static UnityEngine.Color[] ColorFromVtArray(VtVec4fArray input, ref UnityEngine.Color[] output); // 0x000000018D706504-0x000000018D7065F8
		[Preserve]
		public static void ToVtArray(Color32[] input, out VtVec3fArray rgb, out VtFloatArray alpha); // 0x000000018D709DC4-0x000000018D709FB4
		[Preserve]
		public static Vector3[] ExtractRgb(Color32[] colors); // 0x000000018D707234-0x000000018D707370
		[Preserve]
		public static float[] ExtractAlpha(Color32[] colors); // 0x000000018D707090-0x000000018D707168
		[Preserve]
		public static void ToVtArray(UnityEngine.Color[] input, out VtVec3fArray rgb, out VtFloatArray alpha); // 0x000000018D709A68-0x000000018D709C3C
		[Preserve]
		public static UnityEngine.Color[] FromVtArray(VtVec3fArray rgbIn, VtFloatArray alphaIn); // 0x000000018D707EA8-0x000000018D708054
		[Preserve]
		public static Vector3[] ExtractRgb(UnityEngine.Color[] colors); // 0x000000018D707370-0x000000018D707474
		[Preserve]
		public static float[] ExtractAlpha(UnityEngine.Color[] colors); // 0x000000018D707168-0x000000018D707234
		[Preserve]
		private static void SwapQuaternionReal(ref Quaternion[] input); // 0x000000018D7091E4-0x000000018D709280
		[Preserve]
		public static GfQuatf QuaternionToQuatf(Quaternion quaternion); // 0x000000018D708F20-0x000000018D708F9C
		[Preserve]
		public static Quaternion QuatfToQuaternion(GfQuatf quat); // 0x000000018D708F9C-0x000000018D709058
		[Preserve]
		public static VtQuatfArray ToVtArray(Quaternion[] input); // 0x000000018D70965C-0x000000018D709730
		[Preserve]
		public static Quaternion[] FromVtArray(VtQuatfArray input); // 0x000000018D707A28-0x000000018D707B0C
		[Preserve]
		public static VtQuatfArray ListToVtArray(List<Quaternion> input); // 0x000000018D708E48-0x000000018D708EB4
		[Preserve]
		public static List<Quaternion> ListFromVtArray(VtQuatfArray input); // 0x000000018D708C0C-0x000000018D708D04
		[Preserve]
		public static VtVec4fArray ToVtArray(Vector4[] input); // 0x000000018D70984C-0x000000018D7098DC
		[Preserve]
		public static Vector4[] FromVtArray(VtVec4fArray input); // 0x000000018D707BFC-0x000000018D707CBC
		[Preserve]
		public static VtVec4fArray ListToVtArray(List<Vector4> input); // 0x000000018D708D70-0x000000018D708DDC
		[Preserve]
		public static List<Vector4> ListFromVtArray(VtVec4fArray input); // 0x000000018D708984-0x000000018D708A5C
		[Preserve]
		public static VtVec3fArray BoundsToVtArray(Bounds input); // 0x000000018D705EBC-0x000000018D706080
		[Preserve]
		public static Bounds BoundsFromVtArray(VtValue vtBounds); // 0x000000018D705C40-0x000000018D705EBC
		[Preserve]
		public static Bounds BoundsFromVtArray(VtValue vtBounds, Vector3[] bbox); // 0x000000018D705B40-0x000000018D705C40
		[Preserve]
		public static VtVec3fArray ToVtArray(Vector3[] input); // 0x000000018D7098DC-0x000000018D70996C
		[Preserve]
		public static Vector3[] FromVtArray(VtVec3fArray input); // 0x000000018D708054-0x000000018D708114
		[Preserve]
		public static void FromVtArray(VtVec3fArray input, ref Vector3[] output); // 0x000000018D707B0C-0x000000018D707BFC
		[Preserve]
		public static VtVec3fArray ListToVtArray(List<Vector3> input); // 0x000000018D708D04-0x000000018D708D70
		[Preserve]
		public static List<Vector3> ListFromVtArray(VtVec3fArray input); // 0x000000018D708A5C-0x000000018D708B34
		[Preserve]
		public static VtVec2fArray ToVtArray(Vector2[] input); // 0x000000018D709CC8-0x000000018D709D58
		[Preserve]
		public static Vector2[] FromVtArray(VtVec2fArray input); // 0x000000018D707CBC-0x000000018D707D7C
		[Preserve]
		public static VtVec2fArray ListToVtArray(List<Vector2> input); // 0x000000018D708DDC-0x000000018D708E48
		[Preserve]
		public static List<Vector2> ListFromVtArray(VtVec2fArray input); // 0x000000018D708B34-0x000000018D708C0C
		[Preserve]
		public static GfVec2f Vector2ToVec2f(Vector2 vec2); // 0x000000018D70A2A8-0x000000018D70A30C
		[Preserve]
		public static Vector2 Vec2fToVector2(GfVec2f value); // 0x000000018D70A0A0-0x000000018D70A130
		[Preserve]
		public static GfVec3f Vector3ToVec3f(Vector3 vec3); // 0x000000018D70A30C-0x000000018D70A37C
		[Preserve]
		public static Vector3 Vec3fToVector3(GfVec3f v3); // 0x000000018D70A130-0x000000018D70A1AC
		[Preserve]
		public static GfVec4f Vector4ToVec4f(Vector4 vector4); // 0x000000018D70A37C-0x000000018D70A3F8
		[Preserve]
		public static Vector4 Vec4fToVector4(GfVec4f v4); // 0x000000018D70A208-0x000000018D70A2A8
		[Preserve]
		public static GfVec4f RectToVtVec4(Rect rect); // 0x000000018D709058-0x000000018D7090D4
		[Preserve]
		public static Rect Vec4fToRect(GfVec4f v4); // 0x000000018D70A208-0x000000018D70A2A8
	}
}
