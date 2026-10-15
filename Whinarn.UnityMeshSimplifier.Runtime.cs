/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityMeshSimplifier;
using UnityMeshSimplifier.Internal;

// Image 79: Whinarn.UnityMeshSimplifier.Runtime.dll - Assembly: Whinarn.UnityMeshSimplifier.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 89838-89858

namespace UnityMeshSimplifier
{
	[Serializable]
	internal struct BlendShape // TypeDefIndex: 89839
	{
		// Fields
		public string ShapeName; // 0x00
		public BlendShapeFrame[] Frames; // 0x08
	
		// Constructors
		public BlendShape(string shapeName, BlendShapeFrame[] frames); // 0x0000000185B2C340-0x0000000185B2C370
	}

	[Serializable]
	internal struct BlendShapeFrame // TypeDefIndex: 89840
	{
		// Fields
		public float FrameWeight; // 0x00
		public Vector3[] DeltaVertices; // 0x08
		public Vector3[] DeltaNormals; // 0x10
		public Vector3[] DeltaTangents; // 0x18
	
		// Constructors
		public BlendShapeFrame(float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents); // 0x000000018D9CAECC-0x000000018D9CAF08
	}

	internal sealed class ValidateSimplificationOptionsException : Exception // TypeDefIndex: 89841
	{
		// Fields
		private readonly string propertyName; // 0x90
	
		// Properties
		public string PropertyName { get; } // 0x0000000182271B70-0x0000000182271B80 
		public override string Message { get; } // 0x000000018D9D5D9C-0x000000018D9D5E08 
	
		// Constructors
		public ValidateSimplificationOptionsException(string propertyName, string message); // 0x000000018D9D5CAC-0x000000018D9D5D1C
		public ValidateSimplificationOptionsException(string propertyName, string message, Exception innerException); // 0x000000018D9D5D1C-0x000000018D9D5D9C
	}

	internal static class MathHelper // TypeDefIndex: 89842
	{
		// Fields
		public const float PI = 3.1415927f; // Metadata: 0x0264A904
		public const double PId = 3.141592653589793; // Metadata: 0x0264A908
		public const float Deg2Rad = 0.017453292f; // Metadata: 0x0264A910
		public const double Deg2Radd = 0.017453292519943295; // Metadata: 0x0264A914
		public const float Rad2Deg = 57.295776f; // Metadata: 0x0264A91C
		public const double Rad2Degd = 57.29577951308232; // Metadata: 0x0264A920
	
		// Methods
		public static double Min(double val1, double val2, double val3); // 0x000000018D9CAFA4-0x000000018D9CAFC0
		public static double Clamp(double value, double min, double max); // 0x000000018D9CAF90-0x000000018D9CAFA4
		public static double TriangleArea(ref Vector3d p0, ref Vector3d p1, ref Vector3d p2); // 0x000000018D9CAFC0-0x000000018D9CB13C
	}

	internal struct SymmetricMatrix // TypeDefIndex: 89843
	{
		// Fields
		public double m0; // 0x00
		public double m1; // 0x08
		public double m2; // 0x10
		public double m3; // 0x18
		public double m4; // 0x20
		public double m5; // 0x28
		public double m6; // 0x30
		public double m7; // 0x38
		public double m8; // 0x40
		public double m9; // 0x48
	
		// Properties
		public double this[int index] { get => default; } // 0x000000018D9C9A50-0x000000018D9C9C9C 
	
		// Constructors
		public SymmetricMatrix(double c); // 0x0000000187264910-0x0000000187264930
		public SymmetricMatrix(double m0, double m1, double m2, double m3, double m4, double m5, double m6, double m7, double m8, double m9); // 0x0000000187264830-0x0000000187264890
		public SymmetricMatrix(double a, double b, double c, double d); // 0x0000000187264890-0x0000000187264910
	
		// Methods
		public static SymmetricMatrix operator +(SymmetricMatrix a, SymmetricMatrix b); // 0x000000018D9D5AE8-0x000000018D9D5BE8
		internal double Determinant1(); // 0x0000000187264670-0x00000001872646E0
		internal double Determinant2(); // 0x00000001872646E0-0x0000000187264750
		internal double Determinant3(); // 0x0000000187264750-0x00000001872647C0
		internal double Determinant4(); // 0x00000001872647C0-0x0000000187264830
		public double Determinant(int a11, int a12, int a13, int a21, int a22, int a23, int a31, int a32, int a33); // 0x000000018D9D5890-0x000000018D9D5AE8
	}

	internal struct Vector3d : IEquatable<Vector3d> // TypeDefIndex: 89844
	{
		// Fields
		public static readonly Vector3d zero; // 0x00
		public const double Epsilon = 5E-324; // Metadata: 0x0264A928
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
	
		// Properties
		public double Magnitude { get; } // 0x000000018D9D62C0-0x000000018D9D637C 
		public double MagnitudeSqr { get; } // 0x0000000187264A60-0x0000000187264A90 
		public Vector3d Normalized { get; } // 0x000000018D9D637C-0x000000018D9D63DC 
		public double this[int index] { get => default; set {} } // 0x000000018D9CA0A8-0x000000018D9CA29C 0x000000018D9CA29C-0x000000018D9CA374
	
		// Constructors
		public Vector3d(double value); // 0x0000000187264A50-0x0000000187264A60
		public Vector3d(double x, double y, double z); // 0x000000018725AFD0-0x000000018725AFE0
		public Vector3d(Vector3 vector); // 0x000000018725AF90-0x000000018725AFB0
		static Vector3d(); // 0x000000018D9D627C-0x000000018D9D62C0
	
		// Methods
		public static Vector3d operator +(Vector3d a, Vector3d b); // 0x000000018725B030-0x000000018725B070
		public static Vector3d operator -(Vector3d a, Vector3d b); // 0x000000018725B140-0x000000018725B180
		public static Vector3d operator *(Vector3d a, double d); // 0x000000018725B0C0-0x000000018725B0E0
		public static Vector3d operator *(double d, Vector3d a); // 0x000000018725B0A0-0x000000018725B0C0
		public static Vector3d operator /(Vector3d a, double d); // 0x000000018D398D60-0x000000018D398D80
		public static Vector3d operator -(Vector3d a); // 0x000000018725B180-0x000000018725B1B0
		public static bool operator ==(Vector3d lhs, Vector3d rhs); // 0x000000018D9D63DC-0x000000018D9D6490
		public static bool operator !=(Vector3d lhs, Vector3d rhs); // 0x000000018D9D6490-0x000000018D9D6540
		public static implicit operator Vector3d(Vector3 v); // 0x0000000185B1AE20-0x0000000185B1AE50
		public static explicit operator Vector3(Vector3d v); // 0x0000000187234360-0x0000000187234390
		public void Set(double x, double y, double z); // 0x000000018725AFD0-0x000000018725AFE0
		public void Scale(ref Vector3d scale); // 0x0000000187264A20-0x0000000187264A50
		public void Normalize(); // 0x000000018D9D6098-0x000000018D9D611C
		public void Clamp(double min, double max); // 0x000000018D9C9F1C-0x000000018D9CA0A8
		public override int GetHashCode(); // 0x000000018D9D5F9C-0x000000018D9D5FE8
		public override bool Equals(object obj); // 0x000000018D9D5EFC-0x000000018D9D5F9C
		public bool Equals(Vector3d other); // 0x0000000188A2F874-0x0000000188A30B90
		public override string ToString(); // 0x000000018D9D611C-0x000000018D9D61E0
		public string ToString(string format); // 0x000000018D9D61E0-0x000000018D9D627C
		public static double Dot(ref Vector3d lhs, ref Vector3d rhs); // 0x000000018725CF90-0x000000018725CFC0
		public static void Cross(ref Vector3d lhs, ref Vector3d rhs, out Vector3d result); // 0x0000000187264930-0x0000000187264990
		public static double Angle(ref Vector3d from, ref Vector3d to); // 0x000000018D9D5E08-0x000000018D9D5EFC
		public static void Lerp(ref Vector3d a, ref Vector3d b, double t, out Vector3d result); // 0x0000000187264990-0x00000001872649E0
		public static void Scale(ref Vector3d a, ref Vector3d b, out Vector3d result); // 0x00000001872649E0-0x0000000187264A20
		public static void Normalize(ref Vector3d value, out Vector3d result); // 0x000000018D9D5FE8-0x000000018D9D6098
	}

	public static class MeshSimplification // TypeDefIndex: 89845
	{
		// Methods
		public static Mesh SimplifyMesh(Mesh mesh, float quality, SimplifyMeshOptions options = null); // 0x000000018D9CB13C-0x000000018D9CB2DC
	}

	internal sealed class MeshSimplifier // TypeDefIndex: 89846
	{
		// Fields
		private const int TriangleEdgeCount = 3; // Metadata: 0x0264A930
		private const int TriangleVertexCount = 3; // Metadata: 0x0264A931
		private const double DoubleEpsilon = 0.001; // Metadata: 0x0264A932
		private const double DenomEpilson = 1E-08; // Metadata: 0x0264A93A
		private static readonly int UVChannelCount; // 0x00
		private SimplificationOptions simplificationOptions; // 0x10
		private bool verbose; // 0x38
		private int subMeshCount; // 0x3C
		private int[] subMeshOffsets; // 0x40
		private ResizableArray<UnityMeshSimplifier.Internal.Triangle> triangles; // 0x48
		private ResizableArray<UnityMeshSimplifier.Internal.Vertex> vertices; // 0x50
		private ResizableArray<UnityMeshSimplifier.Internal.Ref> refs; // 0x58
		private ResizableArray<Vector3> vertNormals; // 0x60
		private ResizableArray<Vector4> vertTangents; // 0x68
		private UVChannels<Vector2> vertUV2D; // 0x70
		private UVChannels<Vector3> vertUV3D; // 0x78
		private UVChannels<Vector4> vertUV4D; // 0x80
		private ResizableArray<UnityEngine.Color> vertColors; // 0x88
		private ResizableArray<BoneWeight> vertBoneWeights; // 0x90
		private ResizableArray<BlendShapeContainer> blendShapes; // 0x98
		private Matrix4x4[] bindposes; // 0xA0
		private readonly double[] errArr; // 0xA8
		private readonly int[] attributeIndexArr; // 0xB0
		private readonly HashSet<UnityMeshSimplifier.Internal.Triangle> triangleHashSet1; // 0xB8
		private readonly HashSet<UnityMeshSimplifier.Internal.Triangle> triangleHashSet2; // 0xC0
	
		// Properties
		public SimplificationOptions SimplificationOptions { get; set; } // 0x0000000184434430-0x0000000184434450 0x000000018D9D3D00-0x000000018D9D3D84
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public bool PreserveBorderEdges { get; set; } // 0x00000001829D0800-0x00000001829D0810 0x000000018D9D3C00-0x000000018D9D3C40
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public bool PreserveUVSeamEdges { get; set; } // 0x0000000187235410-0x0000000187235420 0x000000018D9D3CC0-0x000000018D9D3D00
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public bool PreserveUVFoldoverEdges { get; set; } // 0x0000000187235CB0-0x0000000187235CC0 0x000000018D9D3C80-0x000000018D9D3CC0
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public bool PreserveSurfaceCurvature { get; set; } // 0x0000000187239C40-0x0000000187239C50 0x000000018D9D3C40-0x000000018D9D3C80
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public bool EnableSmartLink { get; set; } // 0x0000000187239C50-0x0000000187239C60 0x000000018D9D3B14-0x000000018D9D3B54
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public int MaxIterationCount { get; set; } // 0x000000018226A850-0x000000018226A860 0x000000018D9D3B54-0x000000018D9D3B98
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public double Agressiveness { get; set; } // 0x0000000187233230-0x0000000187233240 0x000000018D9D3A04-0x000000018D9D3A44
		public bool Verbose { get; set; } // 0x000000018225E070-0x000000018225E080 0x000000018225E080-0x000000018225E090
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public double VertexLinkDistance { get; set; } // 0x0000000187233020-0x0000000187233030 0x000000018D9D3F14-0x000000018D9D3F68
		[Obsolete("Use MeshSimplifier.SimplificationOptions instead.", false)]
		public double VertexLinkDistanceSqr { get; set; } // 0x00000001872645D0-0x00000001872645E0 0x000000018D9D3E6C-0x000000018D9D3F14
		public Vector3[] Vertices { get; set; } // 0x000000018D9D38C8-0x000000018D9D3A04 0x000000018D9D3F68-0x000000018D9D416C
		public int SubMeshCount { get; } // 0x000000018226F000-0x000000018226F010 
		public int BlendShapeCount { get; } // 0x000000018D9D3700-0x000000018D9D3744 
		public Vector3[] Normals { get; set; } // 0x000000018D9D37CC-0x000000018D9D380C 0x000000018D9D3B98-0x000000018D9D3C00
		public Vector4[] Tangents { get; set; } // 0x000000018D9D380C-0x000000018D9D384C 0x000000018D9D3D84-0x000000018D9D3DEC
		public Vector2[] UV1 { get; set; } // 0x000000018D9D384C-0x000000018D9D3858 0x000000018D9D3DEC-0x000000018D9D3DFC
		public Vector2[] UV2 { get; set; } // 0x000000018D9D3858-0x000000018D9D3868 0x000000018D9D3DFC-0x000000018D9D3E0C
		public Vector2[] UV3 { get; set; } // 0x000000018D9D3868-0x000000018D9D3878 0x000000018D9D3E0C-0x000000018D9D3E1C
		public Vector2[] UV4 { get; set; } // 0x000000018D9D3878-0x000000018D9D3888 0x000000018D9D3E1C-0x000000018D9D3E2C
		public Vector2[] UV5 { get; set; } // 0x000000018D9D3888-0x000000018D9D3898 0x000000018D9D3E2C-0x000000018D9D3E3C
		public Vector2[] UV6 { get; set; } // 0x000000018D9D3898-0x000000018D9D38A8 0x000000018D9D3E3C-0x000000018D9D3E4C
		public Vector2[] UV7 { get; set; } // 0x000000018D9D38A8-0x000000018D9D38B8 0x000000018D9D3E4C-0x000000018D9D3E5C
		public Vector2[] UV8 { get; set; } // 0x000000018D9D38B8-0x000000018D9D38C8 0x000000018D9D3E5C-0x000000018D9D3E6C
		public UnityEngine.Color[] Colors { get; set; } // 0x000000018D9D3788-0x000000018D9D37CC 0x000000018D9D3AAC-0x000000018D9D3B14
		public BoneWeight[] BoneWeights { get; set; } // 0x000000018D9D3744-0x000000018D9D3788 0x000000018D9D3A44-0x000000018D9D3AAC
	
		// Constructors
		public MeshSimplifier(); // 0x000000018D9D3454-0x000000018D9D3694
		public MeshSimplifier(Mesh mesh); // 0x000000018D9D3694-0x000000018D9D3700
		static MeshSimplifier(); // 0x000000018D9D33F4-0x000000018D9D3454
	
		// Methods
		private void InitializeVertexAttribute<T>(T[] attributeValues, ref ResizableArray<T> attributeArray, string attributeName);
		private static double VertexError(ref SymmetricMatrix q, double x, double y, double z); // 0x00000001872644E0-0x00000001872645D0
		private double CurvatureError(ref UnityMeshSimplifier.Internal.Vertex vert0, ref UnityMeshSimplifier.Internal.Vertex vert1); // 0x000000018D9CD640-0x000000018D9CDB20
		private double CalculateError(ref UnityMeshSimplifier.Internal.Vertex vert0, ref UnityMeshSimplifier.Internal.Vertex vert1, out Vector3d result); // 0x000000018D9CC2AC-0x000000018D9CC62C
		private static void CalculateBarycentricCoords(ref Vector3d point, ref Vector3d a, ref Vector3d b, ref Vector3d c, out Vector3 result); // 0x000000018D9CC014-0x000000018D9CC2AC
		private static Vector4 NormalizeTangent(Vector4 tangent); // 0x000000018D9C9784-0x000000018D9C9A50
		private bool Flipped(ref Vector3d p, int i0, int i1, ref UnityMeshSimplifier.Internal.Vertex v0, bool[] deleted); // 0x000000018D9CDB20-0x000000018D9CDEFC
		private void UpdateTriangles(int i0, int ia0, ref UnityMeshSimplifier.Internal.Vertex v, ResizableArray<bool> deleted, ref int deletedTriangles); // 0x000000018D9D2E88-0x000000018D9D31D8
		private void InterpolateVertexAttributes(int dst, int i0, int i1, int i2, ref Vector3 barycentricCoord); // 0x000000018D9CF350-0x000000018D9CFCBC
		private bool AreUVsTheSame(int channel, int indexA, int indexB); // 0x000000018D9CBDB8-0x000000018D9CC014
		private void RemoveVertexPass(int startTrisCount, int targetTrisCount, double threshold, ResizableArray<bool> deleted0, ResizableArray<bool> deleted1, ref int deletedTris); // 0x000000018D9CFCBC-0x000000018D9D048C
		private void UpdateMesh(int iteration); // 0x000000018D9D1C10-0x000000018D9D2B5C
		private void UpdateReferences(); // 0x000000018D9D2B5C-0x000000018D9D2E88
		private void CompactMesh(); // 0x000000018D9CC84C-0x000000018D9CD640
		private void CalculateSubMeshOffsets(); // 0x000000018D9CC62C-0x000000018D9CC780
		private void GetTrianglesContainingVertex(ref UnityMeshSimplifier.Internal.Vertex vert, HashSet<UnityMeshSimplifier.Internal.Triangle> tris); // 0x000000018D9CE6D8-0x000000018D9CE7F8
		private void GetTrianglesContainingBothVertices(ref UnityMeshSimplifier.Internal.Vertex vert0, ref UnityMeshSimplifier.Internal.Vertex vert1, HashSet<UnityMeshSimplifier.Internal.Triangle> tris); // 0x000000018D9CE418-0x000000018D9CE6D8
		public int[][] GetAllSubMeshTriangles(); // 0x000000018D9CDFDC-0x000000018D9CE064
		public int[] GetSubMeshTriangles(int subMeshIndex); // 0x000000018D9CE154-0x000000018D9CE418
		public void ClearSubMeshes(); // 0x000000018D9CC7E0-0x000000018D9CC84C
		public void AddSubMeshTriangles(int[] triangles); // 0x000000018D9CBADC-0x000000018D9CBDB8
		public void AddSubMeshTriangles(int[][] triangles); // 0x000000018D9CB6B4-0x000000018D9CBADC
		public Vector2[] GetUVs2D(int channel); // 0x000000018D9CE7F8-0x000000018D9CE900
		public Vector3[] GetUVs3D(int channel); // 0x000000018D9CE900-0x000000018D9CEA08
		public Vector4[] GetUVs4D(int channel); // 0x000000018D9CEA08-0x000000018D9CEB18
		public void GetUVs(int channel, List<Vector2> uvs); // 0x000000018D9CEB18-0x000000018D9CECC0
		public void GetUVs(int channel, List<Vector3> uvs); // 0x000000018D9CEE74-0x000000018D9CF01C
		public void GetUVs(int channel, List<Vector4> uvs); // 0x000000018D9CECC0-0x000000018D9CEE74
		public void SetUVs(int channel, IList<Vector2> uvs); // 0x000000018D9D0D40-0x000000018D9D0FF8
		public void SetUVs(int channel, IList<Vector3> uvs); // 0x000000018D9D0848-0x000000018D9D0B00
		public void SetUVs(int channel, IList<Vector4> uvs); // 0x000000018D9D0580-0x000000018D9D0848
		public void SetUVs(int channel, IList<Vector4> uvs, int uvComponentCount); // 0x000000018D9D0B00-0x000000018D9D0D40
		public void SetUVsAuto(int channel, IList<Vector4> uvs); // 0x000000018D9D048C-0x000000018D9D0580
		public BlendShape[] GetAllBlendShapes(); // 0x000000018D9CDEFC-0x000000018D9CDFDC
		public BlendShape GetBlendShape(int blendShapeIndex); // 0x000000018D9CE064-0x000000018D9CE154
		public void ClearBlendShapes(); // 0x000000018D9CC780-0x000000018D9CC7E0
		public void AddBlendShape(BlendShape blendShape); // 0x000000018D9CB2DC-0x000000018D9CB454
		public void AddBlendShapes(BlendShape[] blendShapes); // 0x000000018D9CB454-0x000000018D9CB6B4
		public void Initialize(Mesh mesh); // 0x000000018D9CF01C-0x000000018D9CF350
		public void SimplifyMesh(float quality); // 0x000000018D9D131C-0x000000018D9D16FC
		public void SimplifyMeshLossless(); // 0x000000018D9D0FF8-0x000000018D9D131C
		public Mesh ToMesh(); // 0x000000018D9D16FC-0x000000018D9D1C10
		public static void ValidateOptions(SimplificationOptions options); // 0x000000018D9D31D8-0x000000018D9D33F4
	}

	[Serializable]
	public sealed class SimplifyMeshOptions // TypeDefIndex: 89847
	{
		// Fields
		[Tooltip("If the border edges should be preserved.")]
		public bool PreserveBorderEdges; // 0x10
		[Tooltip("If the UV seam edges should be preserved.")]
		public bool PreserveUVSeamEdges; // 0x11
		[Tooltip("If the UV foldover edges should be preserved.")]
		public bool PreserveUVFoldoverEdges; // 0x12
		[Tooltip("If the discrete curvature of the mesh surface should be taken into account during simplification.")]
		public bool PreserveSurfaceCurvature; // 0x13
		[Tooltip("If smarter vertex linking should be enabled, reducing artifacts at the cost of slower simplification.")]
		public bool EnableSmartLink; // 0x14
		[Tooltip("The maximum distance between two vertices in order to link them.")]
		public double VertexLinkDistance; // 0x18
		[Tooltip("The maximum iteration count.")]
		public int MaxIterationCount; // 0x20
		[Tooltip("The aggressiveness of the mesh simplification.")]
		public double Aggressiveness; // 0x28
		[Tooltip("If a manual UV component count should be used instead of automatic detection.")]
		public bool ManualUVComponentCount; // 0x30
		[Range(0f, 4f)]
		[Tooltip("The UV component count used when manual UV component count is enabled.")]
		public int UVComponentCount; // 0x34
		[Tooltip("If verbose information should be printed to the console.")]
		public bool Verbose; // 0x38
	
		// Constructors
		public SimplifyMeshOptions(); // 0x0000000187264640-0x0000000187264670
	
		// Methods
		internal SimplificationOptions ToInternalOptions(); // 0x00000001872645E0-0x0000000187264640
	}

	[Serializable]
	internal struct SimplificationOptions // TypeDefIndex: 89848
	{
		// Fields
		public static readonly SimplificationOptions Default; // 0x00
		[Tooltip("If the border edges should be preserved.")]
		public bool PreserveBorderEdges; // 0x00
		[Tooltip("If the UV seam edges should be preserved.")]
		public bool PreserveUVSeamEdges; // 0x01
		[Tooltip("If the UV foldover edges should be preserved.")]
		public bool PreserveUVFoldoverEdges; // 0x02
		[Tooltip("If the discrete curvature of the mesh surface be taken into account during simplification. Taking surface curvature into account can result in very good quality mesh simplification, but it can slow the simplification process significantly.")]
		public bool PreserveSurfaceCurvature; // 0x03
		[Tooltip("If a feature for smarter vertex linking should be enabled, reducing artifacts at the cost of slower simplification.")]
		public bool EnableSmartLink; // 0x04
		[Tooltip("The maximum distance between two vertices in order to link them.")]
		public double VertexLinkDistance; // 0x08
		[Tooltip("The maximum iteration count. Higher number is more expensive but can bring you closer to your target quality.")]
		public int MaxIterationCount; // 0x10
		[Tooltip("The agressiveness of the mesh simplification. Higher number equals higher quality, but more expensive to run.")]
		public double Agressiveness; // 0x18
		[Tooltip("If a manual UV component count should be used (set by UV Component Count below), instead of the automatic detection.")]
		public bool ManualUVComponentCount; // 0x20
		[Range(0f, 4f)]
		[Tooltip("The UV component count. The same UV component count will be used on all UV channels.")]
		public int UVComponentCount; // 0x24
	
		// Constructors
		static SimplificationOptions(); // 0x000000018D9D57FC-0x000000018D9D5890
	}

	internal static class MeshUtils // TypeDefIndex: 89849
	{
		// Fields
		public static readonly int UVChannelCount; // 0x00
	
		// Constructors
		static MeshUtils(); // 0x000000018D9D57C0-0x000000018D9D57FC
	
		// Methods
		public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, UnityEngine.Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes); // 0x000000018D9D44F0-0x000000018D9D45BC
		public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, UnityEngine.Color[] colors, BoneWeight[] boneWeights, List<Vector4>[] uvs, Matrix4x4[] bindposes, BlendShape[] blendShapes); // 0x000000018D9D45BC-0x000000018D9D4688
		public static Mesh CreateMesh(Vector3[] vertices, int[][] indices, Vector3[] normals, Vector4[] tangents, UnityEngine.Color[] colors, BoneWeight[] boneWeights, List<Vector2>[] uvs2D, List<Vector3>[] uvs3D, List<Vector4>[] uvs4D, Matrix4x4[] bindposes, BlendShape[] blendShapes); // 0x000000018D9D4688-0x000000018D9D4A98
		public static BlendShape[] GetMeshBlendShapes(Mesh mesh); // 0x000000018D9D4B00-0x000000018D9D4DC0
		public static void ApplyMeshBlendShapes(Mesh mesh, BlendShape[] blendShapes); // 0x000000018D9D416C-0x000000018D9D4310
		public static IList<Vector4>[] GetMeshUVs(Mesh mesh); // 0x000000018D9D5110-0x000000018D9D52B0
		public static IList<Vector2> GetMeshUVs2D(Mesh mesh, int channel); // 0x000000018D9D4DC0-0x000000018D9D4F68
		public static IList<Vector3> GetMeshUVs3D(Mesh mesh, int channel); // 0x000000018D9D4F68-0x000000018D9D5110
		public static IList<Vector4> GetMeshUVs(Mesh mesh, int channel); // 0x000000018D9D52B0-0x000000018D9D5458
		public static int GetUsedUVComponents(IList<Vector4> uvs); // 0x000000018D9D55B8-0x000000018D9D57C0
		public static Vector2[] ConvertUVsTo2D(IList<Vector4> uvs); // 0x000000018D9D4310-0x000000018D9D4408
		public static Vector3[] ConvertUVsTo3D(IList<Vector4> uvs); // 0x000000018D9D4408-0x000000018D9D44F0
		public static Vector2Int[] GetSubMeshIndexMinMax(int[][] indices, out IndexFormat indexFormat); // 0x000000018D9D5458-0x000000018D9D55B8
		private static void GetIndexMinMax(int[] indices, out int minIndex, out int maxIndex); // 0x000000018D9D4A98-0x000000018D9D4B00
	}

	internal sealed class ResizableArray<T> // TypeDefIndex: 89850
	{
		// Fields
		private T[] items;
		private int length;
		private static T[] emptyArr;
	
		// Properties
		public int Length { get; }
		public T[] Data { get; }
		public T this[int index] { get => default; set {} }
	
		// Constructors
		public ResizableArray(int capacity);
		public ResizableArray(int capacity, int length);
		public ResizableArray(T[] initialArray);
		static ResizableArray();
	
		// Methods
		private void IncreaseCapacity(int capacity);
		public void Clear();
		public void Resize(int length, bool trimExess = false /* Metadata: 0x0264A942 */, bool clearMemory = false /* Metadata: 0x0264A943 */);
		public void TrimExcess();
		public void Add(T item);
		public T[] ToArray();
	}
}

namespace UnityMeshSimplifier.Internal
{
	internal class BlendShapeContainer // TypeDefIndex: 89851
	{
		// Fields
		private readonly string shapeName; // 0x10
		private readonly BlendShapeFrameContainer[] frames; // 0x18
	
		// Constructors
		public BlendShapeContainer(BlendShape blendShape); // 0x000000018D9CA574-0x000000018D9CA6E4
	
		// Methods
		public void MoveVertexElement(int dst, int src); // 0x000000018D9CA374-0x000000018D9CA3F0
		public void InterpolateVertexAttributes(int dst, int i0, int i1, int i2, ref Vector3 barycentricCoord); // 0x000000018D9C8904-0x000000018D9C9784
		public void Resize(int length, bool trimExess = false /* Metadata: 0x0264A944 */); // 0x000000018D9CA3F0-0x000000018D9CA470
		public BlendShape ToBlendShape(); // 0x000000018D9CA470-0x000000018D9CA574
	}

	internal class BlendShapeFrameContainer // TypeDefIndex: 89852
	{
		// Fields
		private readonly float frameWeight; // 0x10
		private readonly ResizableArray<Vector3> deltaVertices; // 0x18
		private readonly ResizableArray<Vector3> deltaNormals; // 0x20
		private readonly ResizableArray<Vector3> deltaTangents; // 0x28
	
		// Constructors
		public BlendShapeFrameContainer(BlendShapeFrame frame); // 0x000000018D9CADB4-0x000000018D9CAECC
	
		// Methods
		public void MoveVertexElement(int dst, int src); // 0x000000018D9CAB30-0x000000018D9CAC40
		public void InterpolateVertexAttributes(int dst, int i0, int i1, int i2, ref Vector3 barycentricCoord); // 0x000000018D9CA6E4-0x000000018D9CAB30
		public void Resize(int length, bool trimExess = false /* Metadata: 0x0264A945 */); // 0x000000018D9CAC40-0x000000018D9CACF0
		public BlendShapeFrame ToBlendShapeFrame(); // 0x000000018D9CACF0-0x000000018D9CADB4
	}

	internal struct BorderVertex // TypeDefIndex: 89853
	{
		// Fields
		public int index; // 0x00
		public int hash; // 0x04
	
		// Constructors
		public BorderVertex(int index, int hash); // 0x00000001827241A0-0x00000001827241B0
	}

	internal class BorderVertexComparer : IComparer<BorderVertex> // TypeDefIndex: 89854
	{
		// Fields
		public static readonly BorderVertexComparer instance; // 0x00
	
		// Constructors
		public BorderVertexComparer(); // 0x0000000186805BA0-0x0000000186805BB0
		static BorderVertexComparer(); // 0x000000018D9CAF2C-0x000000018D9CAF90
	
		// Methods
		public int Compare(BorderVertex x, BorderVertex y); // 0x000000018D9CAF08-0x000000018D9CAF2C
	}

	internal struct Ref // TypeDefIndex: 89855
	{
		// Fields
		public int tid; // 0x00
		public int tvertex; // 0x04
	
		// Methods
		public void Set(int tid, int tvertex); // 0x00000001827241A0-0x00000001827241B0
	}

	internal struct Triangle : IEquatable<UnityMeshSimplifier.Internal.Triangle> // TypeDefIndex: 89856
	{
		// Fields
		public int index; // 0x00
		public int v0; // 0x04
		public int v1; // 0x08
		public int v2; // 0x0C
		public int subMeshIndex; // 0x10
		public int va0; // 0x14
		public int va1; // 0x18
		public int va2; // 0x1C
		public double err0; // 0x20
		public double err1; // 0x28
		public double err2; // 0x30
		public double err3; // 0x38
		public bool deleted; // 0x40
		public bool dirty; // 0x41
		public Vector3d n; // 0x48
	
		// Properties
		public int this[int index] { get => default; set {} } // 0x000000018D9D5C94-0x000000018D9D5CAC 0x000000018D9C9DA8-0x000000018D9C9F1C
	
		// Constructors
		public Triangle(int index, int v0, int v1, int v2, int subMeshIndex); // 0x000000018D9D5C4C-0x000000018D9D5C94
	
		// Methods
		public void GetAttributeIndices(int[] attributeIndices); // 0x000000018D9C9C9C-0x000000018D9C9CDC
		public void SetAttributeIndex(int index, int value); // 0x000000018D9C9D28-0x000000018D9C9DA8
		public void GetErrors(double[] err); // 0x000000018D9C9CDC-0x000000018D9C9D28
		public override int GetHashCode(); // 0x00000001844AD290-0x00000001844AD2A0
		public override bool Equals(object obj); // 0x000000018D9D5BE8-0x000000018D9D5C4C
		public bool Equals(Triangle other); // 0x000000018D5FDC18-0x000000018D5FDC20
	}

	internal class UVChannels<TVec> // TypeDefIndex: 89857
	{
		// Fields
		private static readonly int UVChannelCount;
		private ResizableArray<TVec>[] channels;
		private TVec[][] channelsData;
	
		// Properties
		public TVec[][] Data { get; }
		public ResizableArray<TVec> this[int index] { get => default; set {} }
	
		// Constructors
		public UVChannels();
		static UVChannels();
	
		// Methods
		public void Resize(int capacity, bool trimExess = false /* Metadata: 0x0264A946 */);
	}

	internal struct Vertex : IEquatable<UnityMeshSimplifier.Internal.Vertex> // TypeDefIndex: 89858
	{
		// Fields
		public int index; // 0x00
		public Vector3d p; // 0x08
		public int tstart; // 0x20
		public int tcount; // 0x24
		public SymmetricMatrix q; // 0x28
		public bool borderEdge; // 0x78
		public bool uvSeamEdge; // 0x79
		public bool uvFoldoverEdge; // 0x7A
	
		// Constructors
		public Vertex(int index, Vector3d p); // 0x0000000187264A90-0x0000000187264AD0
	
		// Methods
		public override int GetHashCode(); // 0x00000001844AD290-0x00000001844AD2A0
		public override bool Equals(object obj); // 0x000000018D9D6540-0x000000018D9D6740
		public bool Equals(Vertex other); // 0x000000018D5FDC18-0x000000018D5FDC20
	}
}
