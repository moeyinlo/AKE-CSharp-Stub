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

// Image 83: USD.NET.Unity.dll - Assembly: USD.NET.Unity, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 62617-62668
[assembly: CompilationRelaxations(8)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.None | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]

namespace USD.NET.Unity
{
	public class DiagnosticHandler : pxr.DiagnosticHandler // TypeDefIndex: 62618
	{
		// Constructors
		public DiagnosticHandler(); // 0x000000018B5D6F40-0x000000018B5D6F48
	
		// Methods
		public override void OnFatalError(string msg); // 0x000000018B5D6DD8-0x000000018B5D6E78
		public override void OnError(string msg); // 0x000000018B5D6D14-0x000000018B5D6DD8
		public override void OnWarning(string msg); // 0x000000018B5D6EDC-0x000000018B5D6F40
		public override void OnInfo(string msg); // 0x000000018B5D6E78-0x000000018B5D6EDC
	}

	[Serializable]
	[UsdSchema("BasisCurves")]
	public class BasisCurvesSample : CurvesSample // TypeDefIndex: 62622
	{
		// Fields
		public CurveType type; // 0xB0
		public Basis basis; // 0xB4
		public WrapMode wrap; // 0xB8
	
		// Nested types
		public enum CurveType // TypeDefIndex: 62619
		{
			Linear = 0,
			Cubic = 1
		}
	
		public enum Basis // TypeDefIndex: 62620
		{
			Bezier = 0,
			Bspline = 1,
			CatmullRom = 2,
			Hermite = 3,
			Power = 4
		}
	
		public enum WrapMode // TypeDefIndex: 62621
		{
			Nonperiodic = 0,
			Periodic = 1
		}
	
		// Constructors
		public BasisCurvesSample(); // 0x000000018B5D6778-0x000000018B5D6780
	}

	[Serializable]
	[UsdSchema("UsdGeomBoundable")]
	public class BoundableSample : XformableSample // TypeDefIndex: 62623
	{
		// Fields
		public Bounds extent; // 0x60
	
		// Constructors
		public BoundableSample(); // 0x000000018B18072C-0x000000018B180734
	}

	[Serializable]
	[UsdSchema("Camera")]
	public class CameraSample : XformSample // TypeDefIndex: 62627
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
		public enum ProjectionType // TypeDefIndex: 62624
		{
			Perspective = 0,
			Orthographic = 1
		}
	
		[Serializable]
		public enum StereoRole // TypeDefIndex: 62625
		{
			Mono = 0,
			Left = 1,
			Right = 2
		}
	
		[Serializable]
		public class Shutter : SampleBase // TypeDefIndex: 62626
		{
			// Fields
			public double open; // 0x10
			public double close; // 0x18
	
			// Constructors
			public Shutter(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public CameraSample(); // 0x000000018B18072C-0x000000018B180734
		public CameraSample(Camera fromCamera); // 0x000000018B5D6C08-0x000000018B5D6C3C
	
		// Methods
		public void CopyFromCamera(Camera camera, bool convertTransformToUsd = true /* Metadata: 0x023520BB */); // 0x000000018B5D6780-0x000000018B5D69B0
		public void CopyToCamera(Camera camera, bool setTransform); // 0x000000018B5D69B0-0x000000018B5D6C08
	}

	[Serializable]
	[UsdSchema("Cube")]
	public class CubeSample : GprimSample // TypeDefIndex: 62628
	{
		// Fields
		private double m_size; // 0x80
	
		// Properties
		public double size { get; set; } // 0x0000000184D88140-0x0000000184D88150 0x000000018B5D6C68-0x000000018B5D6D14
	
		// Constructors
		public CubeSample(); // 0x000000018B5D6778-0x000000018B5D6780
		public CubeSample(double size); // 0x000000018B5D6C3C-0x000000018B5D6C68
	}

	[Serializable]
	[UsdSchema("Curves")]
	public class CurvesSample : PointBasedSample // TypeDefIndex: 62629
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
		public CurvesSample(); // 0x000000018B5D6778-0x000000018B5D6780
	}

	[Serializable]
	[UsdSchema("UsdGeomGprim")]
	public class GprimSample : BoundableSample // TypeDefIndex: 62630
	{
		// Fields
		[FusedDisplayColor]
		[VertexData]
		public Primvar<UnityEngine.Color[]> colors; // 0x78
	
		// Constructors
		public GprimSample(); // 0x000000018B5D6F48-0x000000018B5D6FB4
	}

	[Serializable]
	[UsdSchema("UsdGeomImageable")]
	public class ImageableSample : SampleBase // TypeDefIndex: 62631
	{
		// Constructors
		public ImageableSample(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	[UsdSchema("Mesh")]
	public class MeshSample : MeshSampleBase // TypeDefIndex: 62632
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
		public MeshSample(); // 0x000000018B182660-0x000000018B182668
	
		// Methods
		public void SetTriangles(int[] triangleIndices); // 0x000000018B5D7E9C-0x000000018B5D7F58
	}

	[Serializable]
	[UsdSchema("Mesh")]
	public class MeshSampleBase : PointBasedSample, IArbitraryPrimvars // TypeDefIndex: 62633
	{
		// Fields
		public int[] faceVertexIndices; // 0x80
		public Vector3[] points; // 0x88
		public Vector3[] normals; // 0x90
		public Primvar<Vector4[]> tangents; // 0x98
		[ForceNoNamespace]
		public Dictionary<string, Primvar<object>> ArbitraryPrimvars; // 0xA0
	
		// Constructors
		public MeshSampleBase(); // 0x000000018B5D7DCC-0x000000018B5D7E9C
	
		// Methods
		public Dictionary<string, Primvar<object>> GetArbitraryPrimvars(); // 0x0000000184D86210-0x0000000184D86220
		public void AddPrimvars(List<string> primvars); // 0x000000018B5D7BEC-0x000000018B5D7DCC
	}

	[Serializable]
	[UsdSchema("UsdGeomPointBased")]
	public class PointBasedSample : GprimSample // TypeDefIndex: 62634
	{
		// Constructors
		public PointBasedSample(); // 0x000000018B5D6778-0x000000018B5D6780
	}

	[Serializable]
	[UsdSchema("PointInstancer")]
	public class PointInstancerPrototypesSample : BoundableSample // TypeDefIndex: 62635
	{
		// Fields
		public Relationship prototypes; // 0x78
	
		// Constructors
		public PointInstancerPrototypesSample(); // 0x000000018B5D8090-0x000000018B5D80E8
	}

	[Serializable]
	[UsdSchema("PointInstancer")]
	public class PointInstancerSample : PointInstancerPrototypesSample // TypeDefIndex: 62636
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
		public PointInstancerSample(); // 0x000000018B5D833C-0x000000018B5D8344
	
		// Methods
		public Matrix4x4[] ComputeInstanceMatrices(Scene scene, string primPath); // 0x000000018B5D80E8-0x000000018B5D833C
	}

	[Serializable]
	[UsdSchema("Scope")]
	public class ScopeSample : ImageableSample // TypeDefIndex: 62637
	{
		// Constructors
		public ScopeSample(); // 0x00000001841E1670-0x00000001841E1680
	}

	[Serializable]
	[UsdSchema("Sphere")]
	public class SphereSample : GprimSample // TypeDefIndex: 62638
	{
		// Fields
		private double m_radius; // 0x80
	
		// Properties
		public double radius { get; set; } // 0x0000000184D88140-0x0000000184D88150 0x000000018B5D8840-0x000000018B5D8910
	
		// Constructors
		public SphereSample(); // 0x000000018B5D6778-0x000000018B5D6780
		public SphereSample(double radius); // 0x000000018B5D6C3C-0x000000018B5D6C68
	}

	[Serializable]
	[UsdSchema("UsdGeomXformable")]
	public class XformableSample : ImageableSample // TypeDefIndex: 62639
	{
		// Fields
		private readonly string[] kXformOpTransform; // 0x10
		private Matrix4x4 m_xf; // 0x18
		[UsdVariability(Variability.Uniform)]
		public string[] xformOpOrder; // 0x58
	
		// Properties
		[FusedTransform]
		[UsdNamespace("xformOp")]
		public Matrix4x4 transform { get; set; } // 0x0000000184D978B0-0x0000000184D978E0 0x000000018B5E1780-0x000000018B5E17C8
	
		// Constructors
		public XformableSample(); // 0x000000018B5E16C0-0x000000018B5E1780
	
		// Methods
		public static XformableSample FromTransform(Transform transform); // 0x000000018B5E1588-0x000000018B5E16C0
		public void ConvertTransform(); // 0x000000018B5E14C4-0x000000018B5E1588
	}

	[Serializable]
	[UsdSchema("Xform")]
	public class XformSample : XformableSample // TypeDefIndex: 62640
	{
		// Constructors
		public XformSample(); // 0x000000018B18072C-0x000000018B180734
	}

	[Serializable]
	public class MaterialBindingSample : SampleBase // TypeDefIndex: 62641
	{
		// Fields
		[UsdNamespace("material")]
		public Relationship binding; // 0x10
	
		// Constructors
		public MaterialBindingSample(); // 0x00000001841E1670-0x00000001841E1680
		public MaterialBindingSample(string materialPath); // 0x000000018B5D711C-0x000000018B5D7194
	}

	[Serializable]
	[UsdSchema("Material")]
	public class MaterialSample : SampleBase // TypeDefIndex: 62642
	{
		// Fields
		[UsdNamespace("outputs")]
		public Connectable<TfToken> surface; // 0x10
		[UsdNamespace("outputs")]
		public Connectable<TfToken> displacement; // 0x18
		public string[] requiredKeywords; // 0x20
	
		// Constructors
		public MaterialSample(); // 0x000000018B5D7AA4-0x000000018B5D7B1C
		public MaterialSample(string surfacePath); // 0x000000018B5D79FC-0x000000018B5D7AA4
		public MaterialSample(string surfacePath, string displacementPath); // 0x000000018B5D7B1C-0x000000018B5D7BEC
	
		// Methods
		public static bool ReadMaterial(Scene scene, string geometryPath, MaterialSample materialSample, out string shaderId); // 0x000000018B5D741C-0x000000018B5D78A4
		public static void Bind(Scene scene, string primPath, string materialPath); // 0x000000018B5D7194-0x000000018B5D741C
		public static void Unbind(Scene scene, string primPath); // 0x000000018B5D78A4-0x000000018B5D79FC
	}

	public struct ParameterInfo // TypeDefIndex: 62643
	{
		// Fields
		public object value; // 0x00
		public string connectedPath; // 0x08
		public string usdName; // 0x10
		public string unityName; // 0x18
		public string[] requiredShaderKeywords; // 0x20
	
		// Methods
		public override string ToString(); // 0x000000018B5D7F58-0x000000018B5D8090
	}

	public class InputParameterAttribute : UsdNamespaceAttribute // TypeDefIndex: 62644
	{
		// Fields
		[CompilerGenerated]
		private string _UnityName_k__BackingField; // 0x18
	
		// Properties
		public string UnityName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public InputParameterAttribute(); // 0x000000018B5D700C-0x000000018B5D7068
		public InputParameterAttribute(string unityName); // 0x000000018B5D6FB4-0x000000018B5D700C
	}

	public class InputTextureAttribute : UsdNamespaceAttribute // TypeDefIndex: 62645
	{
		// Fields
		[CompilerGenerated]
		private string _UnityName_k__BackingField; // 0x18
	
		// Properties
		public string UnityName { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x000000018385B100-0x000000018385B110 0x0000000185392C40-0x0000000185392C50
	
		// Constructors
		public InputTextureAttribute(); // 0x000000018B5D7068-0x000000018B5D70C4
		public InputTextureAttribute(string unityName); // 0x000000018B5D70C4-0x000000018B5D711C
	}

	public class RequireShaderKeywordsAttribute : Attribute // TypeDefIndex: 62646
	{
		// Fields
		[CompilerGenerated]
		private string[] _Keywords_k__BackingField; // 0x10
	
		// Properties
		public string[] Keywords { [CompilerGenerated] get; [CompilerGenerated] private set; } // 0x0000000182B2ECC0-0x0000000182B2ECD0 0x00000001853908C0-0x00000001853908D0
	
		// Constructors
		public RequireShaderKeywordsAttribute(string keyword); // 0x000000018B5D86C4-0x000000018B5D8740
		public RequireShaderKeywordsAttribute(string[] keywords); // 0x00000001853908C0-0x00000001853908D0
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class ShaderSample : SampleBase // TypeDefIndex: 62651
	{
		// Fields
		[UsdNamespace("info")]
		public TfToken id; // 0x10
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0 // TypeDefIndex: 62647
		{
			// Fields
			public System.Type inputParamType; // 0x10
			public Func<System.Reflection.FieldInfo, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass3_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetInputParameters_b__0(System.Reflection.FieldInfo info); // 0x000000018B5DB15C-0x000000018B5DB174
		}
	
		[CompilerGenerated]
		private sealed class _GetInputParameters_d__3 : IEnumerable<ParameterInfo>, IEnumerator<ParameterInfo> // TypeDefIndex: 62648
		{
			// Fields
			private int __1__state; // 0x10
			private ParameterInfo __2__current; // 0x18
			private int __l__initialThreadId; // 0x40
			public ShaderSample __4__this; // 0x48
			private __c__DisplayClass3_0 __8__1; // 0x50
			private IEnumerator<System.Reflection.FieldInfo> __7__wrap1; // 0x58
	
			// Properties
			ParameterInfo IEnumerator<USD.NET.Unity.ParameterInfo>.Current { [DebuggerHidden] get; } // 0x0000000184D921A0-0x0000000184D921C0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B5D9B44-0x000000018B5D9BA0 
	
			// Constructors
			[DebuggerHidden]
			public _GetInputParameters_d__3(int __1__state); // 0x000000018B5D9C60-0x000000018B5D9C7C
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018B5D9BA0-0x000000018B5D9C18
			private bool MoveNext(); // 0x000000018B5D92E8-0x000000018B5D9A64
			private void __m__Finally1(); // 0x000000018B5D9C18-0x000000018B5D9C60
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B5D9AF8-0x000000018B5D9B44
			[DebuggerHidden]
			IEnumerator<ParameterInfo> IEnumerable<ParameterInfo>.GetEnumerator(); // 0x000000018B5D9A64-0x000000018B5D9AF0
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5D9AF0-0x000000018B5D9AF8
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0 // TypeDefIndex: 62649
		{
			// Fields
			public System.Type inputParamType; // 0x10
			public Func<System.Reflection.FieldInfo, bool> __9__0; // 0x18
	
			// Constructors
			public __c__DisplayClass4_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _GetInputTextures_b__0(System.Reflection.FieldInfo info); // 0x000000018B5DB15C-0x000000018B5DB174
		}
	
		[CompilerGenerated]
		private sealed class _GetInputTextures_d__4 : IEnumerable<ParameterInfo>, IEnumerator<ParameterInfo> // TypeDefIndex: 62650
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
			ParameterInfo IEnumerator<USD.NET.Unity.ParameterInfo>.Current { [DebuggerHidden] get; } // 0x0000000184D921A0-0x0000000184D921C0 
			object IEnumerator.Current { [DebuggerHidden] get; } // 0x000000018B5DA67C-0x000000018B5DA6D8 
	
			// Constructors
			[DebuggerHidden]
			public _GetInputTextures_d__4(int __1__state); // 0x000000018B5D9C60-0x000000018B5D9C7C
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose(); // 0x000000018B5DA6D8-0x000000018B5DA750
			private bool MoveNext(); // 0x000000018B5D9C7C-0x000000018B5DA59C
			private void __m__Finally1(); // 0x000000018B5DA750-0x000000018B5DA798
			[DebuggerHidden]
			void IEnumerator.Reset(); // 0x000000018B5DA630-0x000000018B5DA67C
			[DebuggerHidden]
			IEnumerator<ParameterInfo> IEnumerable<ParameterInfo>.GetEnumerator(); // 0x000000018B5DA59C-0x000000018B5DA628
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018B5DA628-0x000000018B5DA630
		}
	
		// Constructors
		public ShaderSample(); // 0x00000001841E1670-0x00000001841E1680
	
		// Methods
		private System.Type GetClassType(); // 0x0000000185390BB0-0x0000000185390BBC
		private object GetValue(System.Reflection.FieldInfo info); // 0x000000018B5D8820-0x000000018B5D8840
		[IteratorStateMachine(typeof(_GetInputParameters_d__3))]
		public IEnumerable<ParameterInfo> GetInputParameters(); // 0x000000018B5D8740-0x000000018B5D87B0
		[IteratorStateMachine(typeof(_GetInputTextures_d__4))]
		public IEnumerable<ParameterInfo> GetInputTextures(); // 0x000000018B5D87B0-0x000000018B5D8820
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class StandardShaderSample : ShaderSample // TypeDefIndex: 62652
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
		public StandardShaderSample(); // 0x000000018B5D8910-0x000000018B5D8E38
	}

	[Serializable]
	[UsdSchema("Texture2D")]
	public class Texture2DSample : SampleBase // TypeDefIndex: 62653
	{
		// Fields
		[UsdAssetPath]
		[UsdNamespace("inputs")]
		public Connectable<string> sourceFile; // 0x10
		public bool sRgb; // 0x18
	
		// Constructors
		public Texture2DSample(); // 0x000000018B5D8E38-0x000000018B5D8E94
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class PreviewSurfaceSample : ShaderSample // TypeDefIndex: 62655
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
		public class Outputs : SampleBase // TypeDefIndex: 62654
		{
			// Fields
			public TfToken displacement; // 0x10
			public TfToken surface; // 0x18
	
			// Constructors
			public Outputs(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public PreviewSurfaceSample(); // 0x000000018B5D8344-0x000000018B5D86C4
	}

	[Serializable]
	[UsdSchema("Shader")]
	public class PrimvarReaderSample<T> : ShaderSample // TypeDefIndex: 62657
		where T : struct
	{
		// Fields
		[InputParameter("_Fallback")]
		public Connectable<T> fallback;
		[UsdNamespace("outputs")]
		public Outputs outputs;
	
		// Nested types
		public class Outputs : SampleBase // TypeDefIndex: 62656
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
	public class PrimvarReaderImportSample<T> : PrimvarReaderSample<T> // TypeDefIndex: 62658
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
	public class PrimvarReaderExportSample<T> : PrimvarReaderSample<T> // TypeDefIndex: 62659
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
	public class TextureReaderSample : ShaderSample // TypeDefIndex: 62663
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
		public enum WrapMode // TypeDefIndex: 62660
		{
			Black = 0,
			Clamp = 1,
			Repeat = 2,
			Mirror = 3
		}
	
		public enum SRGBMode // TypeDefIndex: 62661
		{
			Yes = 0,
			No = 1,
			Auto = 2
		}
	
		public class Outputs : SampleBase // TypeDefIndex: 62662
		{
			// Fields
			public float? r; // 0x10
			public float? g; // 0x18
			public float? b; // 0x20
			public float? a; // 0x28
			public Vector3? rgb; // 0x30
			public Vector4? rgba; // 0x40
	
			// Constructors
			public Outputs(); // 0x00000001841E1670-0x00000001841E1680
		}
	
		// Constructors
		public TextureReaderSample(); // 0x000000018B5D8EBC-0x000000018B5D919C
		public TextureReaderSample(string filePath); // 0x000000018B5D9260-0x000000018B5D92E8
		public TextureReaderSample(string filePath, string stConnectionPath); // 0x000000018B5D919C-0x000000018B5D9260
	
		// Methods
		public static WrapMode GetWrapMode(TextureWrapMode wrap); // 0x000000018B5D8E94-0x000000018B5D8EBC
	}

	public static class UnityTypeBindings // TypeDefIndex: 62665
	{
		// Fields
		private static bool isInitialized; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c // TypeDefIndex: 62664
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
			static __c(); // 0x000000018B5DB174-0x000000018B5DB1D8
			public __c(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal VtValue _RegisterTypes_b__2_0(object obj); // 0x000000018B5DA798-0x000000018B5DA808
			internal object _RegisterTypes_b__2_1(VtValue value); // 0x000000018B5DAC9C-0x000000018B5DAD18
			internal VtValue _RegisterTypes_b__2_2(object obj); // 0x000000018B5DAD18-0x000000018B5DAD80
			internal object _RegisterTypes_b__2_3(VtValue value); // 0x000000018B5DAD80-0x000000018B5DADF0
			internal VtValue _RegisterTypes_b__2_4(object obj); // 0x000000018B5DADF0-0x000000018B5DAE68
			internal object _RegisterTypes_b__2_5(VtValue value); // 0x000000018B5DAE68-0x000000018B5DAEEC
			internal VtValue _RegisterTypes_b__2_6(object obj); // 0x000000018B5DAEEC-0x000000018B5DAF5C
			internal object _RegisterTypes_b__2_7(VtValue value); // 0x000000018B5DAF5C-0x000000018B5DAFD8
			internal VtValue _RegisterTypes_b__2_8(object obj); // 0x000000018B5DAFD8-0x000000018B5DB048
			internal object _RegisterTypes_b__2_9(VtValue value); // 0x000000018B5DB048-0x000000018B5DB0C4
			internal VtValue _RegisterTypes_b__2_10(object obj); // 0x000000018B5DA808-0x000000018B5DA870
			internal object _RegisterTypes_b__2_11(VtValue vtVal); // 0x000000018B5DA870-0x000000018B5DA8C0
			internal VtValue _RegisterTypes_b__2_12(object obj); // 0x000000018B5DA8C0-0x000000018B5DA930
			internal object _RegisterTypes_b__2_13(VtValue vtVal); // 0x000000018B5DA930-0x000000018B5DA9AC
			internal VtValue _RegisterTypes_b__2_14(object obj); // 0x000000018B5DA9AC-0x000000018B5DAA10
			internal object _RegisterTypes_b__2_15(VtValue vtVal); // 0x000000018B5DAA10-0x000000018B5DAA80
			internal VtValue _RegisterTypes_b__2_16(object obj); // 0x000000018B5DAA80-0x000000018B5DAAFC
			internal object _RegisterTypes_b__2_17(VtValue vtVal); // 0x000000018B5DAAFC-0x000000018B5DAB74
			internal VtValue _RegisterTypes_b__2_18(object obj); // 0x000000018B5DAB74-0x000000018B5DAC00
			internal object _RegisterTypes_b__2_19(VtValue vtVal); // 0x000000018B5DAC00-0x000000018B5DAC9C
		}
	
		// Constructors
		static UnityTypeBindings(); // 0x000000018B5DCAF0-0x000000018B5DCAF8
	
		// Methods
		public static void RegisterTypes(); // 0x000000018B5DB1D8-0x000000018B5DCAF0
	}

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	internal class PreserveAttribute : Attribute // TypeDefIndex: 62666
	{
		// Constructors
		public PreserveAttribute(); // 0x00000001841E1670-0x00000001841E1680
	}

	public class UnityTypeConverter : IntrinsicTypeConverter // TypeDefIndex: 62668
	{
		// Fields
		public static Matrix4x4 basisChange; // 0x00
		public static Matrix4x4 inverseBasisChange; // 0x40
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0 // TypeDefIndex: 62667
		{
			// Fields
			public Transform transform; // 0x10
			public string name; // 0x18
	
			// Constructors
			public __c__DisplayClass11_0(); // 0x00000001841E1670-0x00000001841E1680
	
			// Methods
			internal bool _HasAnySiblingsWithName_b__0(GameObject sibling); // 0x000000018B5DB0C4-0x000000018B5DB15C
		}
	
		// Constructors
		public UnityTypeConverter(); // 0x00000001841E1670-0x00000001841E1680
		static UnityTypeConverter(); // 0x000000018B5E13D0-0x000000018B5E14C4
	
		// Methods
		public static Matrix4x4 ChangeBasis(Matrix4x4 input); // 0x000000018B5DD0B4-0x000000018B5DD200
		public static Vector3 ChangeBasis(Vector3 point); // 0x000000018B5DD02C-0x000000018B5DD0B4
		public static void SetTransform(Matrix4x4 localXf, Transform transform); // 0x000000018B5E002C-0x000000018B5E0138
		public static bool Decompose(Matrix4x4 matrix, out Vector3 translation, out Quaternion rotation, out Vector3 scale); // 0x000000018B5DD604-0x000000018B5DE020
		private static Vector3 WeightedAvg(Vector3 a, Vector3 b, float aWeight, float bWeight); // 0x000000018B5E1334-0x000000018B5E13D0
		public static void ExtractTrs(Matrix4x4 transform, ref Vector3 localPosition, ref Quaternion localRotation, ref Vector3 localScale); // 0x000000018B5DE56C-0x000000018B5DE688
		private static Quaternion ExtractRotation(Matrix4x4 mat4); // 0x000000018B5DE3F0-0x000000018B5DE480
		private static Vector3 ExtractPosition(Matrix4x4 mat4); // 0x0000000184DBF4E0-0x0000000184DBF500
		private static Vector3 ExtractScale(Matrix4x4 mat4); // 0x000000018B5DE480-0x000000018B5DE56C
		private static bool HasAnySiblingsWithName(Transform transform, string name); // 0x000000018B5DF430-0x000000018B5DF7B8
		public static string GetUniqueName(Transform transform); // 0x000000018B5DF374-0x000000018B5DF430
		public static string GetPath(Transform unityObj); // 0x000000018B5DF328-0x000000018B5DF374
		public static string GetPath(Transform unityObj, Transform unityObjRoot); // 0x000000018B5DF160-0x000000018B5DF328
		public static Matrix4x4 GetLocalToParentXf(Transform unityXf); // 0x000000018B5DF07C-0x000000018B5DF160
		[Preserve]
		public static GfMatrix4d ToGfMatrix(Transform unityXf); // 0x000000018B5E01D4-0x000000018B5E0250
		[Preserve]
		public static GfMatrix4d ToGfMatrix(Matrix4x4 unityMat4); // 0x000000018B5E0250-0x000000018B5E0544
		[Preserve]
		public static Matrix4x4 FromMatrix(GfMatrix4d gfMat); // 0x000000018B5DE688-0x000000018B5DE9A4
		[Preserve]
		public static VtMatrix4dArray ToVtArray(Matrix4x4[] input); // 0x000000018B5E08C0-0x000000018B5E09BC
		[Preserve]
		public static Matrix4x4[] FromVtArray(VtMatrix4dArray input); // 0x000000018B5DECF0-0x000000018B5DEE1C
		[Preserve]
		public static VtMatrix4dArray ListToVtArray(List<Matrix4x4> input); // 0x000000018B5DFE14-0x000000018B5DFE80
		[Preserve]
		public static List<Matrix4x4> ListFromVtArray(VtMatrix4dArray input); // 0x000000018B5DF7B8-0x000000018B5DF8FC
		[Preserve]
		public static GfVec4f Color32ToVec4f(Color32 c); // 0x000000018B5DD384-0x000000018B5DD3E8
		[Preserve]
		public static Color32 Vec4fToColor32(GfVec4f v); // 0x000000018B5E10EC-0x000000018B5E1148
		[Preserve]
		public static VtVec4fArray ToVtArray(List<Color32> input); // 0x000000018B5E0C9C-0x000000018B5E0D08
		[Preserve]
		public static void ToVtArray(List<Color32> input, out VtVec3fArray rgb, out VtFloatArray alpha); // 0x000000018B5E0B80-0x000000018B5E0C0C
		[Preserve]
		public static VtVec4fArray ToVtArray(Color32[] input); // 0x000000018B5E0EF4-0x000000018B5E0FE0
		[Preserve]
		public static Color32[] Color32FromVtArray(VtVec4fArray input); // 0x000000018B5DD200-0x000000018B5DD384
		[Preserve]
		public static GfVec4f ColorToVec4f(UnityEngine.Color c); // 0x000000018B5DD58C-0x000000018B5DD604
		[Preserve]
		public static UnityEngine.Color Vec4fToColor(GfVec4f v); // 0x000000018B5E1148-0x000000018B5E11E8
		[Preserve]
		public static VtVec4fArray ToVtArray(List<UnityEngine.Color> input); // 0x000000018B5E0544-0x000000018B5E05B0
		[Preserve]
		public static void ToVtArray(List<UnityEngine.Color> input, out VtVec3fArray rgb, out VtFloatArray alpha); // 0x000000018B5E0714-0x000000018B5E07A0
		[Preserve]
		public static VtVec4fArray ToVtArray(UnityEngine.Color[] input); // 0x000000018B5E0684-0x000000018B5E0714
		[Preserve]
		public static UnityEngine.Color[] ColorFromVtArray(VtVec4fArray input); // 0x000000018B5DD3E8-0x000000018B5DD498
		[Preserve]
		public static UnityEngine.Color[] ColorFromVtArray(VtVec4fArray input, ref UnityEngine.Color[] output); // 0x000000018B5DD498-0x000000018B5DD58C
		[Preserve]
		public static void ToVtArray(Color32[] input, out VtVec3fArray rgb, out VtFloatArray alpha); // 0x000000018B5E0D08-0x000000018B5E0EF4
		[Preserve]
		public static Vector3[] ExtractRgb(Color32[] colors); // 0x000000018B5DE1A8-0x000000018B5DE2EC
		[Preserve]
		public static float[] ExtractAlpha(Color32[] colors); // 0x000000018B5DE020-0x000000018B5DE0EC
		[Preserve]
		public static void ToVtArray(UnityEngine.Color[] input, out VtVec3fArray rgb, out VtFloatArray alpha); // 0x000000018B5E09BC-0x000000018B5E0B80
		[Preserve]
		public static UnityEngine.Color[] FromVtArray(VtVec3fArray rgbIn, VtFloatArray alphaIn); // 0x000000018B5DEE1C-0x000000018B5DEFC4
		[Preserve]
		public static Vector3[] ExtractRgb(UnityEngine.Color[] colors); // 0x000000018B5DE2EC-0x000000018B5DE3F0
		[Preserve]
		public static float[] ExtractAlpha(UnityEngine.Color[] colors); // 0x000000018B5DE0EC-0x000000018B5DE1A8
		[Preserve]
		private static void SwapQuaternionReal(ref Quaternion[] input); // 0x000000018B5E0138-0x000000018B5E01D4
		[Preserve]
		public static GfQuatf QuaternionToQuatf(Quaternion quaternion); // 0x000000018B5DFE80-0x000000018B5DFEF8
		[Preserve]
		public static Quaternion QuatfToQuaternion(GfQuatf quat); // 0x000000018B5DFEF8-0x000000018B5DFFB4
		[Preserve]
		public static VtQuatfArray ToVtArray(Quaternion[] input); // 0x000000018B5E05B0-0x000000018B5E0684
		[Preserve]
		public static Quaternion[] FromVtArray(VtQuatfArray input); // 0x000000018B5DE9A4-0x000000018B5DEA88
		[Preserve]
		public static VtQuatfArray ListToVtArray(List<Quaternion> input); // 0x000000018B5DFDA8-0x000000018B5DFE14
		[Preserve]
		public static List<Quaternion> ListFromVtArray(VtQuatfArray input); // 0x000000018B5DFB6C-0x000000018B5DFC64
		[Preserve]
		public static VtVec4fArray ToVtArray(Vector4[] input); // 0x000000018B5E07A0-0x000000018B5E0830
		[Preserve]
		public static Vector4[] FromVtArray(VtVec4fArray input); // 0x000000018B5DEB78-0x000000018B5DEC34
		[Preserve]
		public static VtVec4fArray ListToVtArray(List<Vector4> input); // 0x000000018B5DFCD0-0x000000018B5DFD3C
		[Preserve]
		public static List<Vector4> ListFromVtArray(VtVec4fArray input); // 0x000000018B5DF8FC-0x000000018B5DF9CC
		[Preserve]
		public static VtVec3fArray BoundsToVtArray(Bounds input); // 0x000000018B5DCE6C-0x000000018B5DD02C
		[Preserve]
		public static Bounds BoundsFromVtArray(VtValue vtBounds); // 0x000000018B5DCBF8-0x000000018B5DCE6C
		[Preserve]
		public static Bounds BoundsFromVtArray(VtValue vtBounds, Vector3[] bbox); // 0x000000018B5DCAF8-0x000000018B5DCBF8
		[Preserve]
		public static VtVec3fArray ToVtArray(Vector3[] input); // 0x000000018B5E0830-0x000000018B5E08C0
		[Preserve]
		public static Vector3[] FromVtArray(VtVec3fArray input); // 0x000000018B5DEFC4-0x000000018B5DF07C
		[Preserve]
		public static void FromVtArray(VtVec3fArray input, ref Vector3[] output); // 0x000000018B5DEA88-0x000000018B5DEB78
		[Preserve]
		public static VtVec3fArray ListToVtArray(List<Vector3> input); // 0x000000018B5DFC64-0x000000018B5DFCD0
		[Preserve]
		public static List<Vector3> ListFromVtArray(VtVec3fArray input); // 0x000000018B5DF9CC-0x000000018B5DFA9C
		[Preserve]
		public static VtVec2fArray ToVtArray(Vector2[] input); // 0x000000018B5E0C0C-0x000000018B5E0C9C
		[Preserve]
		public static Vector2[] FromVtArray(VtVec2fArray input); // 0x000000018B5DEC34-0x000000018B5DECF0
		[Preserve]
		public static VtVec2fArray ListToVtArray(List<Vector2> input); // 0x000000018B5DFD3C-0x000000018B5DFDA8
		[Preserve]
		public static List<Vector2> ListFromVtArray(VtVec2fArray input); // 0x000000018B5DFA9C-0x000000018B5DFB6C
		[Preserve]
		public static GfVec2f Vector2ToVec2f(Vector2 vec2); // 0x000000018B5E11E8-0x000000018B5E124C
		[Preserve]
		public static Vector2 Vec2fToVector2(GfVec2f value); // 0x000000018B5E0FE0-0x000000018B5E1070
		[Preserve]
		public static GfVec3f Vector3ToVec3f(Vector3 vec3); // 0x000000018B5E124C-0x000000018B5E12BC
		[Preserve]
		public static Vector3 Vec3fToVector3(GfVec3f v3); // 0x000000018B5E1070-0x000000018B5E10EC
		[Preserve]
		public static GfVec4f Vector4ToVec4f(Vector4 vector4); // 0x000000018B5E12BC-0x000000018B5E1334
		[Preserve]
		public static Vector4 Vec4fToVector4(GfVec4f v4); // 0x000000018B5E1148-0x000000018B5E11E8
		[Preserve]
		public static GfVec4f RectToVtVec4(Rect rect); // 0x000000018B5DFFB4-0x000000018B5E002C
		[Preserve]
		public static Rect Vec4fToRect(GfVec4f v4); // 0x000000018B5E1148-0x000000018B5E11E8
	}
}
