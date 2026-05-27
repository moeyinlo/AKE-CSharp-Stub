/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

// Image 31: Unity.Mathematics.dll - Assembly: Unity.Mathematics, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 53696-53789

namespace Unity.IL2CPP.CompilerServices
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
	internal class Il2CppEagerStaticClassConstructionAttribute : Attribute // TypeDefIndex: 53697
	{
		// Constructors
		public Il2CppEagerStaticClassConstructionAttribute() {} // 0x000000018350B670-0x000000018350B680
	}
}

namespace Unity.Mathematics
{
	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct AffineTransform : IEquatable<Unity.Mathematics.AffineTransform>, IFormattable // TypeDefIndex: 53698
	{
		// Fields
		public float3x3 rs; // 0x00
		public float3 t; // 0x24
		public static readonly AffineTransform identity; // 0x00
	
		// Constructors
		public AffineTransform(float3 translation, quaternion rotation) {
			rs = default;
			t = default;
		} // 0x0000000189C5F45C-0x0000000189C5F4B4
		public AffineTransform(float3 translation, quaternion rotation, float3 scale) {
			rs = default;
			t = default;
		} // 0x0000000189C5F3B4-0x0000000189C5F45C
		public AffineTransform(float3 translation, float3x3 rotationScale) {
			rs = default;
			t = default;
		} // 0x0000000183D7D430-0x0000000183D7D460
		public AffineTransform(float3x3 rotationScale) {
			rs = default;
			t = default;
		} // 0x0000000189C5F34C-0x0000000189C5F3B4
		public AffineTransform(RigidTransform rigid) {
			rs = default;
			t = default;
		} // 0x0000000189C5F2F4-0x0000000189C5F34C
		public AffineTransform(float3x4 m) {
			rs = default;
			t = default;
		} // 0x0000000184D2508C-0x0000000184D251C4
		public AffineTransform(float4x4 m) {
			rs = default;
			t = default;
		} // 0x0000000184D251C4-0x0000000184D253C0
		static AffineTransform() {
			identity = default;
		} // 0x0000000183CB4BF0-0x0000000183CB4C90
	
		// Methods
		public bool Equals(AffineTransform rhs) => default; // 0x0000000189C5EC58-0x0000000189C5ECC0
		public override bool Equals(object o) => default; // 0x0000000189C5EBDC-0x0000000189C5EC58
		public override int GetHashCode() => default; // 0x0000000189C5ECC0-0x0000000189C5ECF0
		public override string ToString() => default; // 0x0000000189C5EFC4-0x0000000189C5F2F4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C5ECF0-0x0000000189C5EFC4
	}

	[Il2CppEagerStaticClassConstruction]
	public static class math // TypeDefIndex: 53702
	{
		// Fields
		public const double E_DBL = 2.718281828459045; // Metadata: 0x01FD6046
		public const double LOG2E_DBL = 1.4426950408889634; // Metadata: 0x01FD604E
		public const double LOG10E_DBL = 0.4342944819032518; // Metadata: 0x01FD6056
		public const double LN2_DBL = 0.6931471805599453; // Metadata: 0x01FD605E
		public const double LN10_DBL = 2.302585092994046; // Metadata: 0x01FD6066
		public const double PI_DBL = 3.141592653589793; // Metadata: 0x01FD606E
		public const double PI2_DBL = 6.283185307179586; // Metadata: 0x01FD6076
		public const double PIHALF_DBL = 1.5707963267948966; // Metadata: 0x01FD607E
		public const double TAU_DBL = 6.283185307179586; // Metadata: 0x01FD6086
		public const double TODEGREES_DBL = 57.29577951308232; // Metadata: 0x01FD608E
		public const double TORADIANS_DBL = 0.017453292519943295; // Metadata: 0x01FD6096
		public const double SQRT2_DBL = 1.4142135623730951; // Metadata: 0x01FD609E
		public const double EPSILON_DBL = 2.220446049250313E-16; // Metadata: 0x01FD60A6
		public const double INFINITY_DBL = 1D / 0D; // Metadata: 0x01FD60AE
		public const double NAN_DBL = 0D / 0D; // Metadata: 0x01FD60B6
		public const float FLT_MIN_NORMAL = 1.1754944E-38f; // Metadata: 0x01FD60BE
		public const double DBL_MIN_NORMAL = 2.2250738585072014E-308; // Metadata: 0x01FD60C2
		public const float E = 2.7182817f; // Metadata: 0x01FD60CA
		public const float LOG2E = 1.442695f; // Metadata: 0x01FD60CE
		public const float LOG10E = 0.4342945f; // Metadata: 0x01FD60D2
		public const float LN2 = 0.6931472f; // Metadata: 0x01FD60D6
		public const float LN10 = 2.3025851f; // Metadata: 0x01FD60DA
		public const float PI = 3.1415927f; // Metadata: 0x01FD60DE
		public const float PI2 = 6.2831855f; // Metadata: 0x01FD60E2
		public const float PIHALF = 1.5707964f; // Metadata: 0x01FD60E6
		public const float TAU = 6.2831855f; // Metadata: 0x01FD60EA
		public const float TODEGREES = 57.29578f; // Metadata: 0x01FD60EE
		public const float TORADIANS = 0.017453292f; // Metadata: 0x01FD60F2
		public const float SQRT2 = 1.4142135f; // Metadata: 0x01FD60F6
		public const float EPSILON = 1.1920929E-07f; // Metadata: 0x01FD60FA
		public const float INFINITY = 1F / 0F; // Metadata: 0x01FD60FE
		public const float NAN = 0F / 0F; // Metadata: 0x01FD6102
	
		// Nested types
		public enum RotationOrder : byte // TypeDefIndex: 53699
		{
			XYZ = 0,
			XZY = 1,
			YXZ = 2,
			YZX = 3,
			ZXY = 4,
			Default = 4,
			ZYX = 5
		}
	
		public enum ShuffleComponent : byte // TypeDefIndex: 53700
		{
			LeftX = 0,
			LeftY = 1,
			LeftZ = 2,
			LeftW = 3,
			RightX = 4,
			RightY = 5,
			RightZ = 6,
			RightW = 7
		}
	
		internal struct LongDoubleUnion // TypeDefIndex: 53701
		{
			// Fields
			public long longValue; // 0x00
			public double doubleValue; // 0x00
		}
	
		// Methods
		public static AffineTransform AffineTransform(float3 translation, quaternion rotation) => default; // 0x0000000189C2C7E8-0x0000000189C2C834
		public static AffineTransform AffineTransform(float3 translation, quaternion rotation, float3 scale) => default; // 0x0000000189C2C834-0x0000000189C2C898
		public static AffineTransform AffineTransform(float3 translation, float3x3 rotationScale) => default; // 0x0000000183D78240-0x0000000183D78270
		public static AffineTransform AffineTransform(float3x3 rotationScale) => default; // 0x0000000189C2C758-0x0000000189C2C79C
		public static AffineTransform AffineTransform(float4x4 m) => default; // 0x0000000189C2C79C-0x0000000189C2C7E8
		public static AffineTransform AffineTransform(float3x4 m) => default; // 0x0000000189C2C8DC-0x0000000189C2C920
		public static AffineTransform AffineTransform(RigidTransform rigid) => default; // 0x0000000189C2C898-0x0000000189C2C8DC
		public static float4x4 float4x4(AffineTransform transform) => default; // 0x0000000189C350EC-0x0000000189C351E8
		public static float3x4 float3x4(AffineTransform transform) => default; // 0x0000000189C347A0-0x0000000189C34834
		public static AffineTransform mul(AffineTransform a, AffineTransform b) => default; // 0x0000000189C4A9C8-0x0000000189C4AAB0
		public static AffineTransform mul(float3x3 a, AffineTransform b) => default; // 0x0000000189C496D8-0x0000000189C497B4
		public static AffineTransform mul(AffineTransform a, float3x3 b) => default; // 0x0000000189C4C924-0x0000000189C4C9B8
		public static float4 mul(AffineTransform a, float4 pos) => default; // 0x0000000189C4F454-0x0000000189C4F540
		public static float3 rotate(AffineTransform a, float3 dir) => default; // 0x0000000189C52B98-0x0000000189C52BF8
		public static float3 transform(AffineTransform a, float3 pos) => default; // 0x0000000189C56440-0x0000000189C564E4
		public static AffineTransform inverse(AffineTransform a) => default; // 0x0000000189C3D650-0x0000000189C3D748
		public static void decompose(AffineTransform a, out float3 translation, out quaternion rotation, out float3 scale) {
			translation = default;
			rotation = default;
			scale = default;
		} // 0x0000000189C30428-0x0000000189C30538
		public static uint hash(AffineTransform a) => default; // 0x0000000189C35E68-0x0000000189C35EBC
		public static uint4 hashwide(AffineTransform a) => default; // 0x0000000189C3A4BC-0x0000000189C3A5B8
		public static bool2 bool2(bool x, bool y) => default; // 0x0000000183D787C0-0x0000000183D787D0
		public static bool2 bool2(bool2 xy) => default; // 0x0000000183D787E0-0x0000000183D78800
		public static bool2 bool2(bool v) => default; // 0x0000000183D787D0-0x0000000183D787E0
		public static uint hash(bool2 v) => default; // 0x0000000189C375E8-0x0000000189C37630
		public static uint2 hashwide(bool2 v) => default; // 0x0000000189C39D58-0x0000000189C39D8C
		public static bool shuffle(bool2 left, bool2 right, ShuffleComponent x) => default; // 0x0000000184D580D0-0x0000000184D581BC
		public static bool2 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000184D599E8-0x0000000184D59AD4
		public static bool3 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000184D582B0-0x0000000184D58730
		public static bool4 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000184D5887C-0x0000000184D588FC
		internal static bool select_shuffle_component(bool2 a, bool2 b, ShuffleComponent component) => default; // 0x0000000184D57694-0x0000000184D57784
		public static bool2x2 bool2x2(bool2 c0, bool2 c1) => default; // 0x0000000183D78800-0x0000000183D78810
		public static bool2x2 bool2x2(bool m00, bool m01, bool m10, bool m11) => default; // 0x0000000184D2D538-0x0000000184D2D568
		public static bool2x2 bool2x2(bool v) => default; // 0x0000000189C2EC58-0x0000000189C2EC7C
		public static bool2x2 transpose(bool2x2 v) => default; // 0x0000000189C56C5C-0x0000000189C56C80
		public static uint hash(bool2x2 v) => default; // 0x0000000189C3740C-0x0000000189C3749C
		public static uint2 hashwide(bool2x2 v) => default; // 0x0000000189C3B9A8-0x0000000189C3BA2C
		public static bool2x3 bool2x3(bool2 c0, bool2 c1, bool2 c2) => default; // 0x0000000183D78810-0x0000000183D78830
		public static bool2x3 bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12) => default; // 0x0000000184D2D568-0x0000000184D2D624
		public static bool2x3 bool2x3(bool v) => default; // 0x0000000189C2EC7C-0x0000000189C2EC98
		public static bool3x2 transpose(bool2x3 v) => default; // 0x0000000189C56968-0x0000000189C569B0
		public static uint hash(bool2x3 v) => default; // 0x0000000189C38388-0x0000000189C38454
		public static uint2 hashwide(bool2x3 v) => default; // 0x0000000189C3A160-0x0000000189C3A224
		public static bool2x4 bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3) => default; // 0x0000000183D78830-0x0000000183D78860
		public static bool2x4 bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13) => default; // 0x0000000189C2EC98-0x0000000189C2ECF0
		public static bool2x4 bool2x4(bool v) => default; // 0x0000000189C2ECF0-0x0000000189C2ED14
		public static bool4x2 transpose(bool2x4 v) => default; // 0x0000000189C572A8-0x0000000189C572FC
		public static uint hash(bool2x4 v) => default; // 0x0000000189C37858-0x0000000189C37970
		public static uint2 hashwide(bool2x4 v) => default; // 0x0000000189C3C568-0x0000000189C3C674
		public static bool3 bool3(bool x, bool y, bool z) => default; // 0x0000000183D78860-0x0000000183D78870
		public static bool3 bool3(bool x, bool2 yz) => default; // 0x0000000183D788A0-0x0000000183D788C0
		public static bool3 bool3(bool2 xy, bool z) => default; // 0x0000000183D78880-0x0000000183D788A0
		public static bool3 bool3(bool3 xyz) => default; // 0x0000000183D788C0-0x0000000183D788E0
		public static bool3 bool3(bool v) => default; // 0x0000000183D78870-0x0000000183D78880
		public static uint hash(bool3 v) => default; // 0x0000000184D33EC4-0x0000000184D33F54
		public static uint3 hashwide(bool3 v) => default; // 0x0000000189C3AF5C-0x0000000189C3AFE8
		public static bool shuffle(bool3 left, bool3 right, ShuffleComponent x) => default; // 0x0000000184D58B38-0x0000000184D58B70
		public static bool2 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000189C54898-0x0000000189C54910
		public static bool3 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000189C5441C-0x0000000189C544D8
		public static bool4 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000189C53B30-0x0000000189C53C14
		internal static bool select_shuffle_component(bool3 a, bool3 b, ShuffleComponent component) => default; // 0x0000000184D57AE0-0x0000000184D57BE4
		public static bool3x2 bool3x2(bool3 c0, bool3 c1) => default; // 0x0000000183D788E0-0x0000000183D78910
		public static bool3x2 bool3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21) => default; // 0x0000000184D2D624-0x0000000184D2D65C
		public static bool3x2 bool3x2(bool v) => default; // 0x0000000189C2ED14-0x0000000189C2ED30
		public static bool2x3 transpose(bool3x2 v) => default; // 0x0000000189C57538-0x0000000189C57580
		public static uint hash(bool3x2 v) => default; // 0x0000000184D35E04-0x0000000184D369F0
		public static uint3 hashwide(bool3x2 v) => default; // 0x0000000189C3BBFC-0x0000000189C3BD24
		public static bool3x3 bool3x3(bool3 c0, bool3 c1, bool3 c2) => default; // 0x0000000183D78910-0x0000000183D78950
		public static bool3x3 bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22) => default; // 0x0000000184D2D65C-0x0000000184D2D6BC
		public static bool3x3 bool3x3(bool v) => default; // 0x0000000189C2ED30-0x0000000189C2ED4C
		public static bool3x3 transpose(bool3x3 v) => default; // 0x0000000189C57248-0x0000000189C572A8
		public static uint hash(bool3x3 v) => default; // 0x0000000184D36C28-0x0000000184D38368
		public static uint3 hashwide(bool3x3 v) => default; // 0x0000000189C3BD24-0x0000000189C3BEE8
		public static bool3x4 bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3) => default; // 0x0000000183D78950-0x0000000183D789A0
		public static bool3x4 bool3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23) => default; // 0x0000000184D2D6BC-0x0000000184D2D7F4
		public static bool3x4 bool3x4(bool v) => default; // 0x0000000189C2ED4C-0x0000000189C2ED68
		public static bool4x3 transpose(bool3x4 v) => default; // 0x0000000189C57580-0x0000000189C575F8
		public static uint hash(bool3x4 v) => default; // 0x0000000184D34EC4-0x0000000184D356BC
		public static uint3 hashwide(bool3x4 v) => default; // 0x0000000189C3A8C0-0x0000000189C3AB14
		public static bool4 bool4(bool x, bool y, bool z, bool w) => default; // 0x0000000183D789E0-0x0000000183D78A00
		public static bool4 bool4(bool x, bool y, bool2 zw) => default; // 0x0000000183D78A70-0x0000000183D78A90
		public static bool4 bool4(bool x, bool2 yz, bool w) => default; // 0x0000000183D789C0-0x0000000183D789E0
		public static bool4 bool4(bool x, bool3 yzw) => default; // 0x0000000183D78AC0-0x0000000183D78AF0
		public static bool4 bool4(bool2 xy, bool z, bool w) => default; // 0x0000000183D789A0-0x0000000183D789C0
		public static bool4 bool4(bool2 xy, bool2 zw) => default; // 0x0000000183D78A20-0x0000000183D78A40
		public static bool4 bool4(bool3 xyz, bool w) => default; // 0x0000000183D78A90-0x0000000183D78AC0
		public static bool4 bool4(bool4 xyzw) => default; // 0x0000000183D78A40-0x0000000183D78A70
		public static bool4 bool4(bool v) => default; // 0x0000000183D78A00-0x0000000183D78A20
		public static uint hash(bool4 v) => default; // 0x0000000184D356BC-0x0000000184D35764
		public static uint4 hashwide(bool4 v) => default; // 0x0000000189C3C174-0x0000000189C3C1F8
		public static bool shuffle(bool4 left, bool4 right, ShuffleComponent x) => default; // 0x0000000184D580C8-0x0000000184D580D0
		public static bool2 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000184D59D90-0x0000000184D59E80
		public static bool3 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000184D59868-0x0000000184D598D0
		public static bool4 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000184D58F28-0x0000000184D58FA0
		internal static bool select_shuffle_component(bool4 a, bool4 b, ShuffleComponent component) => default; // 0x0000000184D57568-0x0000000184D57694
		public static bool4x2 bool4x2(bool4 c0, bool4 c1) => default; // 0x0000000183D78AF0-0x0000000183D78B00
		public static bool4x2 bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31) => default; // 0x0000000189C2ED68-0x0000000189C2EDC0
		public static bool4x2 bool4x2(bool v) => default; // 0x0000000189C2EDC0-0x0000000189C2EDE4
		public static bool2x4 transpose(bool4x2 v) => default; // 0x0000000189C567F4-0x0000000189C56848
		public static uint hash(bool4x2 v) => default; // 0x0000000184D349A8-0x0000000184D34EC4
		public static uint4 hashwide(bool4x2 v) => default; // 0x0000000184D399DC-0x0000000184D3A078
		public static bool4x3 bool4x3(bool4 c0, bool4 c1, bool4 c2) => default; // 0x0000000183D78B00-0x0000000183D78B10
		public static bool4x3 bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32) => default; // 0x0000000184D2D7F4-0x0000000184D2D870
		public static bool4x3 bool4x3(bool v) => default; // 0x0000000189C2EDE4-0x0000000189C2EE00
		public static bool3x4 transpose(bool4x3 v) => default; // 0x0000000189C5764C-0x0000000189C576C8
		public static uint hash(bool4x3 v) => default; // 0x0000000184D35764-0x0000000184D3591C
		public static uint4 hashwide(bool4x3 v) => default; // 0x0000000184D39170-0x0000000184D3930C
		public static bool4x4 bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3) => default; // 0x0000000183D78B10-0x0000000183D78B30
		public static bool4x4 bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33) => default; // 0x0000000184D2D870-0x0000000184D2DA28
		public static bool4x4 bool4x4(bool v) => default; // 0x0000000189C2EE00-0x0000000189C2EE18
		public static bool4x4 transpose(bool4x4 v) => default; // 0x0000000189C56764-0x0000000189C567F4
		public static uint hash(bool4x4 v) => default; // 0x0000000184D369F0-0x0000000184D36C28
		public static uint4 hashwide(bool4x4 v) => default; // 0x0000000184D3AC60-0x0000000184D3AE7C
		public static double2 double2(double x, double y) => default; // 0x0000000183D79DD0-0x0000000183D79DE0
		public static double2 double2(double2 xy) => default; // 0x0000000183D79EE0-0x0000000183D79F00
		public static double2 double2(double v) => default; // 0x0000000183D79F00-0x0000000183D79F10
		public static double2 double2(bool v) => default; // 0x0000000189C30B30-0x0000000189C30B4C
		public static double2 double2(bool2 v) => default; // 0x0000000189C30AD8-0x0000000189C30AF0
		public static double2 double2(int v) => default; // 0x0000000183D79EA0-0x0000000183D79EC0
		public static double2 double2(int2 v) => default; // 0x0000000183D79E40-0x0000000183D79E70
		public static double2 double2(uint v) => default; // 0x0000000183D79DE0-0x0000000183D79E10
		public static double2 double2(uint2 v) => default; // 0x0000000183D79E70-0x0000000183D79EA0
		public static double2 double2(half v) => default; // 0x0000000189C30A98-0x0000000189C30AD8
		public static double2 double2(half2 v) => default; // 0x0000000189C30AF0-0x0000000189C30B30
		public static double2 double2(float v) => default; // 0x0000000183D79EC0-0x0000000183D79EE0
		public static double2 double2(float2 v) => default; // 0x0000000183D79E10-0x0000000183D79E40
		public static uint hash(double2 v) => default; // 0x0000000189C372A8-0x0000000189C372F0
		public static uint2 hashwide(double2 v) => default; // 0x0000000189C3B21C-0x0000000189C3B274
		public static double shuffle(double2 left, double2 right, ShuffleComponent x) => default; // 0x0000000189C54664-0x0000000189C5468C
		public static double2 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000189C5405C-0x0000000189C540C8
		public static double3 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000189C54598-0x0000000189C54664
		public static double4 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000189C54764-0x0000000189C5485C
		internal static double select_shuffle_component(double2 a, double2 b, ShuffleComponent component) => default; // 0x0000000184D57474-0x0000000184D57568
		public static double2x2 double2x2(double2 c0, double2 c1) => default; // 0x0000000183D79F10-0x0000000183D79F40
		public static double2x2 double2x2(double m00, double m01, double m10, double m11) => default; // 0x0000000184D2F8D4-0x0000000184D2F8FC
		public static double2x2 double2x2(double v) => default; // 0x0000000189C30B68-0x0000000189C30B84
		public static double2x2 double2x2(bool v) => default; // 0x0000000189C30C58-0x0000000189C30C74
		public static double2x2 double2x2(bool2x2 v) => default; // 0x0000000189C30B84-0x0000000189C30BA4
		public static double2x2 double2x2(int v) => default; // 0x0000000189C30BE8-0x0000000189C30C04
		public static double2x2 double2x2(int2x2 v) => default; // 0x0000000189C30C04-0x0000000189C30C2C
		public static double2x2 double2x2(uint v) => default; // 0x0000000189C30BA4-0x0000000189C30BC0
		public static double2x2 double2x2(uint2x2 v) => default; // 0x0000000189C30C2C-0x0000000189C30C58
		public static double2x2 double2x2(float v) => default; // 0x0000000189C30B4C-0x0000000189C30B68
		public static double2x2 double2x2(float2x2 v) => default; // 0x0000000189C30BC0-0x0000000189C30BE8
		public static double2x2 transpose(double2x2 v) => default; // 0x0000000189C56C80-0x0000000189C56CC4
		public static double2x2 inverse(double2x2 m) => default; // 0x0000000189C3D748-0x0000000189C3D808
		public static double determinant(double2x2 m) => default; // 0x0000000183D79C10-0x0000000183D79C40
		public static uint hash(double2x2 v) => default; // 0x0000000189C372F0-0x0000000189C3737C
		public static uint2 hashwide(double2x2 v) => default; // 0x0000000189C3C0DC-0x0000000189C3C174
		public static double2x3 double2x3(double2 c0, double2 c1, double2 c2) => default; // 0x0000000183D79F40-0x0000000183D79F90
		public static double2x3 double2x3(double m00, double m01, double m02, double m10, double m11, double m12) => default; // 0x0000000184D2F8FC-0x0000000184D2F9E4
		public static double2x3 double2x3(double v) => default; // 0x0000000189C30CB4-0x0000000189C30CD4
		public static double2x3 double2x3(bool v) => default; // 0x0000000189C30D0C-0x0000000189C30D2C
		public static double2x3 double2x3(bool2x3 v) => default; // 0x0000000189C30D88-0x0000000189C30DC4
		public static double2x3 double2x3(int v) => default; // 0x0000000189C30D2C-0x0000000189C30D4C
		public static double2x3 double2x3(int2x3 v) => default; // 0x0000000189C30DC4-0x0000000189C30DFC
		public static double2x3 double2x3(uint v) => default; // 0x0000000189C30C74-0x0000000189C30C94
		public static double2x3 double2x3(uint2x3 v) => default; // 0x0000000189C30D4C-0x0000000189C30D88
		public static double2x3 double2x3(float v) => default; // 0x0000000189C30C94-0x0000000189C30CB4
		public static double2x3 double2x3(float2x3 v) => default; // 0x0000000189C30CD4-0x0000000189C30D0C
		public static double3x2 transpose(double2x3 v) => default; // 0x0000000189C575F8-0x0000000189C5764C
		public static uint hash(double2x3 v) => default; // 0x0000000189C3656C-0x0000000189C36638
		public static uint2 hashwide(double2x3 v) => default; // 0x0000000189C3BEE8-0x0000000189C3BFC0
		public static double2x4 double2x4(double2 c0, double2 c1, double2 c2, double2 c3) => default; // 0x0000000183D79F90-0x0000000183D79FF0
		public static double2x4 double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13) => default; // 0x0000000184D2F9E4-0x0000000184D2FAF0
		public static double2x4 double2x4(double v) => default; // 0x0000000189C30EC0-0x0000000189C30EE4
		public static double2x4 double2x4(bool v) => default; // 0x0000000189C30DFC-0x0000000189C30E20
		public static double2x4 double2x4(bool2x4 v) => default; // 0x0000000189C30E5C-0x0000000189C30E84
		public static double2x4 double2x4(int v) => default; // 0x0000000189C30F68-0x0000000189C30F8C
		public static double2x4 double2x4(int2x4 v) => default; // 0x0000000189C30E84-0x0000000189C30EC0
		public static double2x4 double2x4(uint v) => default; // 0x0000000189C30F08-0x0000000189C30F2C
		public static double2x4 double2x4(uint2x4 v) => default; // 0x0000000189C30E20-0x0000000189C30E5C
		public static double2x4 double2x4(float v) => default; // 0x0000000189C30EE4-0x0000000189C30F08
		public static double2x4 double2x4(float2x4 v) => default; // 0x0000000189C30F2C-0x0000000189C30F68
		public static double4x2 transpose(double2x4 v) => default; // 0x0000000189C56A34-0x0000000189C56AA0
		public static uint hash(double2x4 v) => default; // 0x0000000189C36BF0-0x0000000189C36CFC
		public static uint2 hashwide(double2x4 v) => default; // 0x0000000189C3C674-0x0000000189C3C78C
		public static double3 double3(double x, double y, double z) => default; // 0x0000000183D7A0A0-0x0000000183D7A0C0
		public static double3 double3(double x, double2 yz) => default; // 0x0000000183D7A1B0-0x0000000183D7A1D0
		public static double3 double3(double2 xy, double z) => default; // 0x0000000183D7A0D0-0x0000000183D7A0F0
		public static double3 double3(double3 xyz) => default; // 0x0000000183D7A150-0x0000000183D7A180
		public static double3 double3(double v) => default; // 0x0000000183D7A0C0-0x0000000183D7A0D0
		public static double3 double3(bool v) => default; // 0x0000000189C31024-0x0000000189C31044
		public static double3 double3(bool3 v) => default; // 0x0000000189C30FF0-0x0000000189C31024
		public static double3 double3(int v) => default; // 0x0000000183D7A180-0x0000000183D7A1B0
		public static double3 double3(int3 v) => default; // 0x0000000183D7A020-0x0000000183D7A070
		public static double3 double3(uint v) => default; // 0x0000000183D7A070-0x0000000183D7A0A0
		public static double3 double3(uint3 v) => default; // 0x0000000183D7A0F0-0x0000000183D7A150
		public static double3 double3(half v) => default; // 0x0000000189C31044-0x0000000189C31098
		public static double3 double3(half3 v) => default; // 0x0000000189C30F8C-0x0000000189C30FF0
		public static double3 double3(float v) => default; // 0x0000000183D79FF0-0x0000000183D7A020
		public static double3 double3(float3 v) => default; // 0x000000018337F9A0-0x000000018337F9E0
		public static uint hash(double3 v) => default; // 0x0000000189C37630-0x0000000189C376C0
		public static uint3 hashwide(double3 v) => default; // 0x0000000189C3A2FC-0x0000000189C3A3A0
		public static double shuffle(double3 left, double3 right, ShuffleComponent x) => default; // 0x0000000189C54910-0x0000000189C54950
		public static double2 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000189C53C14-0x0000000189C53CBC
		public static double3 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000189C549B0-0x0000000189C54AB8
		public static double4 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000189C53DBC-0x0000000189C53F00
		internal static double select_shuffle_component(double3 a, double3 b, ShuffleComponent component) => default; // 0x0000000189C53830-0x0000000189C53950
		public static double3x2 double3x2(double3 c0, double3 c1) => default; // 0x0000000183D7A1D0-0x0000000183D7A200
		public static double3x2 double3x2(double m00, double m01, double m10, double m11, double m20, double m21) => default; // 0x0000000184D2FAF0-0x0000000184D2FB38
		public static double3x2 double3x2(double v) => default; // 0x0000000189C310F4-0x0000000189C31114
		public static double3x2 double3x2(bool v) => default; // 0x0000000189C31150-0x0000000189C31174
		public static double3x2 double3x2(bool3x2 v) => default; // 0x0000000189C31174-0x0000000189C311B0
		public static double3x2 double3x2(int v) => default; // 0x0000000189C3120C-0x0000000189C3122C
		public static double3x2 double3x2(int3x2 v) => default; // 0x0000000189C311B0-0x0000000189C311EC
		public static double3x2 double3x2(uint v) => default; // 0x0000000189C31098-0x0000000189C310B8
		public static double3x2 double3x2(uint3x2 v) => default; // 0x0000000189C31114-0x0000000189C31150
		public static double3x2 double3x2(float v) => default; // 0x0000000189C311EC-0x0000000189C3120C
		public static double3x2 double3x2(float3x2 v) => default; // 0x0000000189C310B8-0x0000000189C310F4
		public static double2x3 transpose(double3x2 v) => default; // 0x0000000189C56B9C-0x0000000189C56BF0
		public static uint hash(double3x2 v) => default; // 0x0000000189C35A88-0x0000000189C35BB4
		public static uint3 hashwide(double3x2 v) => default; // 0x0000000189C38F4C-0x0000000189C3908C
		public static double3x3 double3x3(double3 c0, double3 c1, double3 c2) => default; // 0x0000000183D7A200-0x0000000183D7A240
		public static double3x3 double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22) => default; // 0x0000000184D2FBD0-0x0000000184D2FD68
		public static double3x3 double3x3(double v) => default; // 0x0000000189C313CC-0x0000000189C313F8
		public static double3x3 double3x3(bool v) => default; // 0x0000000189C31350-0x0000000189C3137C
		public static double3x3 double3x3(bool3x3 v) => default; // 0x0000000184D2FB38-0x0000000184D2FBD0
		public static double3x3 double3x3(int v) => default; // 0x0000000189C31324-0x0000000189C31350
		public static double3x3 double3x3(int3x3 v) => default; // 0x0000000189C312D4-0x0000000189C31324
		public static double3x3 double3x3(uint v) => default; // 0x0000000189C312A8-0x0000000189C312D4
		public static double3x3 double3x3(uint3x3 v) => default; // 0x0000000189C3137C-0x0000000189C313CC
		public static double3x3 double3x3(float v) => default; // 0x0000000189C3122C-0x0000000189C31258
		public static double3x3 double3x3(float3x3 v) => default; // 0x0000000189C31258-0x0000000189C312A8
		public static double3x3 transpose(double3x3 v) => default; // 0x0000000189C56D48-0x0000000189C56DBC
		public static double3x3 inverse(double3x3 m) => default; // 0x0000000189C3EADC-0x0000000189C3EF9C
		public static double determinant(double3x3 m) => default; // 0x0000000183D79570-0x0000000183D79630
		public static uint hash(double3x3 v) => default; // 0x0000000189C36F8C-0x0000000189C37144
		public static uint3 hashwide(double3x3 v) => default; // 0x0000000189C3BA2C-0x0000000189C3BBFC
		public static double3x4 double3x4(double3 c0, double3 c1, double3 c2, double3 c3) => default; // 0x0000000183D7A240-0x0000000183D7A290
		public static double3x4 double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23) => default; // 0x0000000184D2FD68-0x0000000184D2FF90
		public static double3x4 double3x4(double v) => default; // 0x0000000189C313F8-0x0000000189C31424
		public static double3x4 double3x4(bool v) => default; // 0x0000000189C31598-0x0000000189C315C8
		public static double3x4 double3x4(bool3x4 v) => default; // 0x0000000184D2FF90-0x0000000184D300BC
		public static double3x4 double3x4(int v) => default; // 0x0000000189C31424-0x0000000189C31450
		public static double3x4 double3x4(int3x4 v) => default; // 0x0000000189C314A0-0x0000000189C314F0
		public static double3x4 double3x4(uint v) => default; // 0x0000000189C3151C-0x0000000189C31548
		public static double3x4 double3x4(uint3x4 v) => default; // 0x0000000189C31548-0x0000000189C31598
		public static double3x4 double3x4(float v) => default; // 0x0000000189C314F0-0x0000000189C3151C
		public static double3x4 double3x4(float3x4 v) => default; // 0x0000000189C31450-0x0000000189C314A0
		public static double4x3 transpose(double3x4 v) => default; // 0x0000000189C5745C-0x0000000189C574EC
		public static double3x4 fastinverse(double3x4 m) => default; // 0x0000000189C33AA8-0x0000000189C33DE0
		public static uint hash(double3x4 v) => default; // 0x0000000189C35BB4-0x0000000189C35DFC
		public static uint3 hashwide(double3x4 v) => default; // 0x0000000189C3B274-0x0000000189C3B4D0
		public static double4 double4(double x, double y, double z, double w) => default; // 0x0000000183D7A370-0x0000000183D7A390
		public static double4 double4(double x, double y, double2 zw) => default; // 0x0000000183D7A290-0x0000000183D7A2B0
		public static double4 double4(double x, double2 yz, double w) => default; // 0x0000000183D7A2B0-0x0000000183D7A2D0
		public static double4 double4(double x, double3 yzw) => default; // 0x0000000183D7A3C0-0x0000000183D7A3F0
		public static double4 double4(double2 xy, double z, double w) => default; // 0x0000000183D7A420-0x0000000183D7A440
		public static double4 double4(double2 xy, double2 zw) => default; // 0x0000000183D7A390-0x0000000183D7A3C0
		public static double4 double4(double3 xyz, double w) => default; // 0x0000000183D7A300-0x0000000183D7A330
		public static double4 double4(double4 xyzw) => default; // 0x0000000189C31608-0x0000000189C31630
		public static double4 double4(double v) => default; // 0x0000000183D7A2D0-0x0000000183D7A2E0
		public static double4 double4(bool v) => default; // 0x0000000189C3167C-0x0000000189C31698
		public static double4 double4(bool4 v) => default; // 0x0000000189C315EC-0x0000000189C31608
		public static double4 double4(int v) => default; // 0x0000000183D7A330-0x0000000183D7A370
		public static double4 double4(int4 v) => default; // 0x0000000189C31698-0x0000000189C316C0
		public static double4 double4(uint v) => default; // 0x0000000183D7A3F0-0x0000000183D7A420
		public static double4 double4(uint4 v) => default; // 0x0000000189C316C0-0x0000000189C316E8
		public static double4 double4(half v) => default; // 0x0000000189C31630-0x0000000189C31654
		public static double4 double4(half4 v) => default; // 0x0000000189C315C8-0x0000000189C315EC
		public static double4 double4(float v) => default; // 0x0000000183D7A2E0-0x0000000183D7A300
		public static double4 double4(float4 v) => default; // 0x0000000189C31654-0x0000000189C3167C
		public static uint hash(double4 v) => default; // 0x0000000189C36424-0x0000000189C364B0
		public static uint4 hashwide(double4 v) => default; // 0x0000000189C399A8-0x0000000189C39A3C
		public static double shuffle(double4 left, double4 right, ShuffleComponent x) => default; // 0x0000000189C5485C-0x0000000189C54898
		public static double2 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000189C540C8-0x0000000189C54168
		public static double3 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000189C54168-0x0000000189C54264
		public static double4 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000189C53F28-0x0000000189C5405C
		internal static double select_shuffle_component(double4 a, double4 b, ShuffleComponent component) => default; // 0x0000000189C536FC-0x0000000189C53830
		public static double4x2 double4x2(double4 c0, double4 c1) => default; // 0x0000000183D7A440-0x0000000183D7A470
		public static double4x2 double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31) => default; // 0x0000000184D300BC-0x0000000184D301B8
		public static double4x2 double4x2(double v) => default; // 0x0000000189C31748-0x0000000189C3176C
		public static double4x2 double4x2(bool v) => default; // 0x0000000189C31790-0x0000000189C317B4
		public static double4x2 double4x2(bool4x2 v) => default; // 0x0000000189C31818-0x0000000189C31840
		public static double4x2 double4x2(int v) => default; // 0x0000000189C3176C-0x0000000189C31790
		public static double4x2 double4x2(int4x2 v) => default; // 0x0000000189C3170C-0x0000000189C31748
		public static double4x2 double4x2(uint v) => default; // 0x0000000189C317B4-0x0000000189C317DC
		public static double4x2 double4x2(uint4x2 v) => default; // 0x0000000189C31840-0x0000000189C3187C
		public static double4x2 double4x2(float v) => default; // 0x0000000189C316E8-0x0000000189C3170C
		public static double4x2 double4x2(float4x2 v) => default; // 0x0000000189C317DC-0x0000000189C31818
		public static double2x4 transpose(double4x2 v) => default; // 0x0000000189C56BF0-0x0000000189C56C5C
		public static uint hash(double4x2 v) => default; // 0x0000000189C37B64-0x0000000189C37C74
		public static uint4 hashwide(double4x2 v) => default; // 0x0000000189C3A3A0-0x0000000189C3A4BC
		public static double4x3 double4x3(double4 c0, double4 c1, double4 c2) => default; // 0x0000000183D7A470-0x0000000183D7A4B0
		public static double4x3 double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32) => default; // 0x0000000184D30200-0x0000000184D30518
		public static double4x3 double4x3(double v) => default; // 0x0000000189C318CC-0x0000000189C318F8
		public static double4x3 double4x3(bool v) => default; // 0x0000000189C319A4-0x0000000189C319D0
		public static double4x3 double4x3(bool4x3 v) => default; // 0x0000000184D301B8-0x0000000184D30200
		public static double4x3 double4x3(int v) => default; // 0x0000000189C318F8-0x0000000189C31924
		public static double4x3 double4x3(int4x3 v) => default; // 0x0000000189C31954-0x0000000189C319A4
		public static double4x3 double4x3(uint v) => default; // 0x0000000189C31924-0x0000000189C31954
		public static double4x3 double4x3(uint4x3 v) => default; // 0x0000000189C3187C-0x0000000189C318CC
		public static double4x3 double4x3(float v) => default; // 0x0000000189C319D0-0x0000000189C319FC
		public static double4x3 double4x3(float4x3 v) => default; // 0x0000000189C319FC-0x0000000189C31A4C
		public static double3x4 transpose(double4x3 v) => default; // 0x0000000189C571B8-0x0000000189C57248
		public static uint hash(double4x3 v) => default; // 0x0000000189C37970-0x0000000189C37B00
		public static uint4 hashwide(double4x3 v) => default; // 0x0000000189C39FC4-0x0000000189C3A160
		public static double4x4 double4x4(double4 c0, double4 c1, double4 c2, double4 c3) => default; // 0x0000000183D7A4B0-0x0000000183D7A500
		public static double4x4 double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33) => default; // 0x0000000184D30518-0x0000000184D30644
		public static double4x4 double4x4(double v) => default; // 0x0000000189C31A84-0x0000000189C31AB8
		public static double4x4 double4x4(bool v) => default; // 0x0000000189C31AB8-0x0000000189C31AEC
		public static double4x4 double4x4(bool4x4 v) => default; // 0x0000000189C31C34-0x0000000189C31C78
		public static double4x4 double4x4(int v) => default; // 0x0000000189C31C78-0x0000000189C31CAC
		public static double4x4 double4x4(int4x4 v) => default; // 0x0000000189C31AEC-0x0000000189C31B48
		public static double4x4 double4x4(uint v) => default; // 0x0000000189C31A4C-0x0000000189C31A84
		public static double4x4 double4x4(uint4x4 v) => default; // 0x0000000189C31B48-0x0000000189C31BA4
		public static double4x4 double4x4(float v) => default; // 0x0000000189C31C00-0x0000000189C31C34
		public static double4x4 double4x4(float4x4 v) => default; // 0x0000000189C31BA4-0x0000000189C31C00
		public static double3 rotate(double4x4 a, double3 b) => default; // 0x0000000189C52A48-0x0000000189C52B98
		public static double3 transform(double4x4 a, double3 b) => default; // 0x0000000189C564E4-0x0000000189C56668
		public static double4x4 transpose(double4x4 v) => default; // 0x0000000189C56E94-0x0000000189C56F48
		public static double4x4 inverse(double4x4 m) => default; // 0x0000000189C3DBC8-0x0000000189C3EADC
		public static double4x4 fastinverse(double4x4 m) => default; // 0x0000000189C33428-0x0000000189C3389C
		public static double determinant(double4x4 m) => default; // 0x0000000183D79300-0x0000000183D79560
		public static uint hash(double4x4 v) => default; // 0x0000000189C36218-0x0000000189C36424
		public static uint4 hashwide(double4x4 v) => default; // 0x0000000189C3908C-0x0000000189C392A4
		public static float2 float2(float x, float y) => default; // 0x0000000183D7A720-0x0000000183D7A730
		public static float2 float2(float2 xy) => default; // 0x0000000183D730E0-0x0000000183D73100
		public static float2 float2(float v) => default; // 0x0000000183D543C0-0x0000000183D543D0
		public static float2 float2(bool v) => default; // 0x0000000189C33DE0-0x0000000189C33E00
		public static float2 float2(bool2 v) => default; // 0x0000000189C33E00-0x0000000189C33E24
		public static float2 float2(int v) => default; // 0x0000000183D7A730-0x0000000183D7A750
		public static float2 float2(int2 v) => default; // 0x0000000183D7A750-0x0000000183D7A770
		public static float2 float2(uint v) => default; // 0x0000000183D7A7A0-0x0000000183D7A7D0
		public static float2 float2(uint2 v) => default; // 0x0000000183D7A770-0x0000000183D7A7A0
		public static float2 float2(half v) => default; // 0x0000000189C33E50-0x0000000189C33E78
		public static float2 float2(half2 v) => default; // 0x0000000189C33E24-0x0000000189C33E50
		public static float2 float2(double v) => default; // 0x0000000183D7A7D0-0x0000000183D7A7F0
		public static float2 float2(double2 v) => default; // 0x0000000183D7A700-0x0000000183D7A720
		public static uint hash(float2 v) => default; // 0x0000000189C35A50-0x0000000189C35A88
		public static uint2 hashwide(float2 v) => default; // 0x0000000189C3C098-0x0000000189C3C0DC
		public static float shuffle(float2 left, float2 right, ShuffleComponent x) => default; // 0x0000000184D5898C-0x0000000184D58B38
		public static float2 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000184D59134-0x0000000184D591A0
		public static float3 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000184D59328-0x0000000184D593E8
		public static float4 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000184D58B70-0x0000000184D58C54
		internal static float select_shuffle_component(float2 a, float2 b, ShuffleComponent component) => default; // 0x0000000184D57BE4-0x0000000184D57CE4
		public static float2x2 float2x2(float2 c0, float2 c1) => default; // 0x0000000182232AA0-0x00000001822372F0
		public static float2x2 float2x2(float m00, float m01, float m10, float m11) => default; // 0x0000000189C33E90-0x0000000189C33EB4
		public static float2x2 float2x2(float v) => default; // 0x0000000189C33E78-0x0000000189C33E90
		public static float2x2 float2x2(bool v) => default; // 0x0000000189C33F78-0x0000000189C33F90
		public static float2x2 float2x2(bool2x2 v) => default; // 0x0000000189C33F90-0x0000000189C33FAC
		public static float2x2 float2x2(int v) => default; // 0x0000000189C33EDC-0x0000000189C33EF4
		public static float2x2 float2x2(int2x2 v) => default; // 0x0000000189C33F54-0x0000000189C33F78
		public static float2x2 float2x2(uint v) => default; // 0x0000000189C33F24-0x0000000189C33F3C
		public static float2x2 float2x2(uint2x2 v) => default; // 0x0000000189C33EB4-0x0000000189C33EDC
		public static float2x2 float2x2(double v) => default; // 0x0000000189C33F3C-0x0000000189C33F54
		public static float2x2 float2x2(double2x2 v) => default; // 0x0000000189C33EF4-0x0000000189C33F24
		public static float2x2 transpose(float2x2 v) => default; // 0x0000000189C56848-0x0000000189C56888
		public static float2x2 inverse(float2x2 m) => default; // 0x0000000184D3B638-0x0000000184D3BCA8
		public static float determinant(float2x2 m) => default; // 0x0000000183D79C40-0x0000000183D79C60
		public static uint hash(float2x2 v) => default; // 0x0000000189C380A0-0x0000000189C38104
		public static uint2 hashwide(float2x2 v) => default; // 0x0000000189C3C454-0x0000000189C3C4C8
		public static float2x3 float2x3(float2 c0, float2 c1, float2 c2) => default; // 0x0000000183D7A7F0-0x0000000183D7A800
		public static float2x3 float2x3(float m00, float m01, float m02, float m10, float m11, float m12) => default; // 0x0000000184D31F5C-0x0000000184D31FA0
		public static float2x3 float2x3(float v) => default; // 0x0000000189C33FAC-0x0000000189C33FCC
		public static float2x3 float2x3(bool v) => default; // 0x0000000189C3400C-0x0000000189C3402C
		public static float2x3 float2x3(bool2x3 v) => default; // 0x0000000189C34068-0x0000000189C3409C
		public static float2x3 float2x3(int v) => default; // 0x0000000189C340D4-0x0000000189C340F4
		public static float2x3 float2x3(int2x3 v) => default; // 0x0000000189C340F4-0x0000000189C3412C
		public static float2x3 float2x3(uint v) => default; // 0x0000000189C33FEC-0x0000000189C3400C
		public static float2x3 float2x3(uint2x3 v) => default; // 0x0000000189C3409C-0x0000000189C340D4
		public static float2x3 float2x3(double v) => default; // 0x0000000189C33FCC-0x0000000189C33FEC
		public static float2x3 float2x3(double2x3 v) => default; // 0x0000000189C3402C-0x0000000189C34068
		public static float3x2 transpose(float2x3 v) => default; // 0x0000000189C56FEC-0x0000000189C57048
		public static uint hash(float2x3 v) => default; // 0x0000000189C36804-0x0000000189C36894
		public static uint2 hashwide(float2x3 v) => default; // 0x0000000189C3975C-0x0000000189C397FC
		public static float2x4 float2x4(float2 c0, float2 c1, float2 c2, float2 c3) => default; // 0x0000000183D7A800-0x0000000183D7A820
		public static float2x4 float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13) => default; // 0x0000000184D31FA0-0x0000000184D3200C
		public static float2x4 float2x4(float v) => default; // 0x0000000189C341E4-0x0000000189C34200
		public static float2x4 float2x4(bool v) => default; // 0x0000000189C3412C-0x0000000189C34148
		public static float2x4 float2x4(bool2x4 v) => default; // 0x0000000189C3418C-0x0000000189C341AC
		public static float2x4 float2x4(int v) => default; // 0x0000000189C341C8-0x0000000189C341E4
		public static float2x4 float2x4(int2x4 v) => default; // 0x0000000189C34250-0x0000000189C34284
		public static float2x4 float2x4(uint v) => default; // 0x0000000189C341AC-0x0000000189C341C8
		public static float2x4 float2x4(uint2x4 v) => default; // 0x0000000189C3421C-0x0000000189C34250
		public static float2x4 float2x4(double v) => default; // 0x0000000189C34200-0x0000000189C3421C
		public static float2x4 float2x4(double2x4 v) => default; // 0x0000000189C34148-0x0000000189C3418C
		public static float4x2 transpose(float2x4 v) => default; // 0x0000000189C56DBC-0x0000000189C56E28
		public static uint hash(float2x4 v) => default; // 0x0000000189C3749C-0x0000000189C37558
		public static uint2 hashwide(float2x4 v) => default; // 0x0000000189C3ACB0-0x0000000189C3AD7C
		public static float3 float3(float x, float y, float z) => default; // 0x0000000183D6D520-0x0000000183D6D540
		public static float3 float3(float x, float2 yz) => default; // 0x0000000183D7A980-0x0000000183D7A9B0
		public static float3 float3(float2 xy, float z) => default; // 0x0000000183D7A8C0-0x0000000183D7A8F0
		public static float3 float3(float3 xyz) => default; // 0x0000000183D7A8F0-0x0000000183D7A920
		public static float3 float3(float v) => default; // 0x0000000183D54500-0x0000000183D54520
		public static float3 float3(bool v) => default; // 0x0000000189C34284-0x0000000189C342A0
		public static float3 float3(bool3 v) => default; // 0x0000000189C34328-0x0000000189C34358
		public static float3 float3(int v) => default; // 0x0000000183D7A860-0x0000000183D7A890
		public static float3 float3(int3 v) => default; // 0x0000000183D7A9F0-0x0000000183D7AA40
		public static float3 float3(uint v) => default; // 0x0000000183D7A9B0-0x0000000183D7A9F0
		public static float3 float3(uint3 v) => default; // 0x0000000183D7A920-0x0000000183D7A980
		public static float3 float3(half v) => default; // 0x0000000189C342A0-0x0000000189C342DC
		public static float3 float3(half3 v) => default; // 0x0000000189C342DC-0x0000000189C34328
		public static float3 float3(double v) => default; // 0x0000000183D7A890-0x0000000183D7A8C0
		public static float3 float3(double3 v) => default; // 0x0000000183D7A820-0x0000000183D7A860
		public static uint hash(float3 v) => default; // 0x0000000184D3591C-0x0000000184D35E04
		public static uint3 hashwide(float3 v) => default; // 0x0000000184D38368-0x0000000184D39170
		public static float shuffle(float3 left, float3 right, ShuffleComponent x) => default; // 0x0000000184D593E8-0x0000000184D59424
		public static float2 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000184D59AD4-0x0000000184D59C68
		public static float3 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000184D59E80-0x0000000184D59F74
		public static float4 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000184D59C68-0x0000000184D59D90
		internal static float select_shuffle_component(float3 a, float3 b, ShuffleComponent component) => default; // 0x0000000184D57364-0x0000000184D57474
		public static float3x2 float3x2(float3 c0, float3 c1) => default; // 0x0000000183D7AA40-0x0000000183D7AA70
		public static float3x2 float3x2(float m00, float m01, float m10, float m11, float m20, float m21) => default; // 0x0000000184D3200C-0x0000000184D320FC
		public static float3x2 float3x2(float v) => default; // 0x0000000189C344C0-0x0000000189C344E0
		public static float3x2 float3x2(bool v) => default; // 0x0000000189C343D0-0x0000000189C343F0
		public static float3x2 float3x2(bool3x2 v) => default; // 0x0000000189C34488-0x0000000189C344C0
		public static float3x2 float3x2(int v) => default; // 0x0000000189C343F0-0x0000000189C34410
		public static float3x2 float3x2(int3x2 v) => default; // 0x0000000189C34430-0x0000000189C34468
		public static float3x2 float3x2(uint v) => default; // 0x0000000189C34468-0x0000000189C34488
		public static float3x2 float3x2(uint3x2 v) => default; // 0x0000000189C34398-0x0000000189C343D0
		public static float3x2 float3x2(double v) => default; // 0x0000000189C34410-0x0000000189C34430
		public static float3x2 float3x2(double3x2 v) => default; // 0x0000000189C34358-0x0000000189C34398
		public static float2x3 transpose(float3x2 v) => default; // 0x0000000189C570F0-0x0000000189C5714C
		public static uint hash(float3x2 v) => default; // 0x0000000189C38894-0x0000000189C38974
		public static uint3 hashwide(float3x2 v) => default; // 0x0000000189C39BA8-0x0000000189C39CA0
		public static float3x3 float3x3(float3 c0, float3 c1, float3 c2) => default; // 0x0000000182E246E0-0x0000000182E247E0
		public static float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) => default; // 0x0000000184D320FC-0x0000000184D322AC
		public static float3x3 float3x3(float v) => default; // 0x0000000189C34500-0x0000000189C34520
		public static float3x3 float3x3(bool v) => default; // 0x0000000189C344E0-0x0000000189C34500
		public static float3x3 float3x3(bool3x3 v) => default; // 0x0000000189C346E4-0x0000000189C34724
		public static float3x3 float3x3(int v) => default; // 0x0000000189C3460C-0x0000000189C3462C
		public static float3x3 float3x3(int3x3 v) => default; // 0x0000000189C34578-0x0000000189C345B8
		public static float3x3 float3x3(uint v) => default; // 0x0000000189C346A4-0x0000000189C346C4
		public static float3x3 float3x3(uint3x3 v) => default; // 0x0000000189C34664-0x0000000189C346A4
		public static float3x3 float3x3(double v) => default; // 0x0000000189C346C4-0x0000000189C346E4
		public static float3x3 float3x3(double3x3 v) => default; // 0x0000000189C34520-0x0000000189C34578
		public static float3x3 transpose(float3x3 v) => default; // 0x0000000189C573D8-0x0000000189C5745C
		public static float3x3 inverse(float3x3 m) => default; // 0x0000000189C3D808-0x0000000189C3DBC8
		public static float determinant(float3x3 m) => default; // 0x0000000183D79AC0-0x0000000183D79B70
		public static uint hash(float3x3 v) => default; // 0x0000000189C38594-0x0000000189C386E8
		public static uint3 hashwide(float3x3 v) => default; // 0x0000000189C39A3C-0x0000000189C39BA8
		public static float3x4 float3x4(float3 c0, float3 c1, float3 c2, float3 c3) => default; // 0x0000000183D7AA70-0x0000000183D7AAC0
		public static float3x4 float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23) => default; // 0x0000000184D322AC-0x0000000184D323EC
		public static float3x4 float3x4(float v) => default; // 0x0000000189C34898-0x0000000189C348B8
		public static float3x4 float3x4(bool v) => default; // 0x0000000189C34780-0x0000000189C347A0
		public static float3x4 float3x4(bool3x4 v) => default; // 0x0000000189C34744-0x0000000189C34780
		public static float3x4 float3x4(int v) => default; // 0x0000000189C34834-0x0000000189C34854
		public static float3x4 float3x4(int3x4 v) => default; // 0x0000000189C34854-0x0000000189C34898
		public static float3x4 float3x4(uint v) => default; // 0x0000000189C3495C-0x0000000189C3497C
		public static float3x4 float3x4(uint3x4 v) => default; // 0x0000000189C34918-0x0000000189C3495C
		public static float3x4 float3x4(double v) => default; // 0x0000000189C34724-0x0000000189C34744
		public static float3x4 float3x4(double3x4 v) => default; // 0x0000000189C348B8-0x0000000189C34918
		public static float4x3 transpose(float3x4 v) => default; // 0x0000000189C56F48-0x0000000189C56FEC
		public static float3x4 fastinverse(float3x4 m) => default; // 0x0000000189C3389C-0x0000000189C33AA8
		public static uint hash(float3x4 v) => default; // 0x0000000189C35EBC-0x0000000189C36088
		public static uint3 hashwide(float3x4 v) => default; // 0x0000000189C393E0-0x0000000189C395C0
		public static float4 float4(float x, float y, float z, float w) => default; // 0x0000000183D7AAC0-0x0000000183D7AAE0
		public static float4 float4(float x, float y, float2 zw) => default; // 0x0000000183D7AAF0-0x0000000183D7AB20
		public static float4 float4(float x, float2 yz, float w) => default; // 0x0000000183D7AB90-0x0000000183D7ABC0
		public static float4 float4(float x, float3 yzw) => default; // 0x0000000183D7AC10-0x0000000183D7AC50
		public static float4 float4(float2 xy, float z, float w) => default; // 0x0000000183D7AB20-0x0000000183D7AB50
		public static float4 float4(float2 xy, float2 zw) => default; // 0x0000000183D4E3B0-0x0000000183D4E3F0
		public static float4 float4(float3 xyz, float w) => default; // 0x0000000183D7AC50-0x0000000183D7AC80
		public static float4 float4(float4 xyzw) => default; // 0x0000000189C34AEC-0x0000000189C34B18
		public static float4 float4(float v) => default; // 0x0000000183D7AAE0-0x0000000183D7AAF0
		public static float4 float4(bool v) => default; // 0x0000000189C34AB0-0x0000000189C34AC8
		public static float4 float4(bool4 v) => default; // 0x0000000189C349AC-0x0000000189C349C4
		public static float4 float4(int v) => default; // 0x0000000183D7AB70-0x0000000183D7AB90
		public static float4 float4(int4 v) => default; // 0x0000000189C34A6C-0x0000000189C34AB0
		public static float4 float4(uint v) => default; // 0x0000000183D7ABC0-0x0000000183D7AC10
		public static float4 float4(uint4 v) => default; // 0x0000000189C34AC8-0x0000000189C34AEC
		public static float4 float4(half v) => default; // 0x0000000189C34A20-0x0000000189C34A6C
		public static float4 float4(half4 v) => default; // 0x0000000189C349C4-0x0000000189C34A20
		public static float4 float4(double v) => default; // 0x0000000183D7AB50-0x0000000183D7AB70
		public static float4 float4(double4 v) => default; // 0x0000000189C3497C-0x0000000189C349AC
		public static uint hash(float4 v) => default; // 0x0000000189C369E8-0x0000000189C36A54
		public static uint4 hashwide(float4 v) => default; // 0x0000000189C398EC-0x0000000189C39968
		public static float shuffle(float4 left, float4 right, ShuffleComponent x) => default; // 0x0000000189C53D94-0x0000000189C53DBC
		public static float2 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000189C54950-0x0000000189C549B0
		public static float3 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000189C544D8-0x0000000189C54598
		public static float4 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000189C54264-0x0000000189C5434C
		internal static float select_shuffle_component(float4 a, float4 b, ShuffleComponent component) => default; // 0x0000000189C53950-0x0000000189C53A80
		public static float4x2 float4x2(float4 c0, float4 c1) => default; // 0x0000000183D7AC80-0x0000000183D7ACA0
		public static float4x2 float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31) => default; // 0x0000000184D323EC-0x0000000184D324B8
		public static float4x2 float4x2(float v) => default; // 0x0000000189C34B68-0x0000000189C34B84
		public static float4x2 float4x2(bool v) => default; // 0x0000000189C34C38-0x0000000189C34C54
		public static float4x2 float4x2(bool4x2 v) => default; // 0x0000000189C34C54-0x0000000189C34C78
		public static float4x2 float4x2(int v) => default; // 0x0000000189C34BFC-0x0000000189C34C18
		public static float4x2 float4x2(int4x2 v) => default; // 0x0000000189C34BC8-0x0000000189C34BFC
		public static float4x2 float4x2(uint v) => default; // 0x0000000189C34C18-0x0000000189C34C38
		public static float4x2 float4x2(uint4x2 v) => default; // 0x0000000189C34B34-0x0000000189C34B68
		public static float4x2 float4x2(double v) => default; // 0x0000000189C34B18-0x0000000189C34B34
		public static float4x2 float4x2(double4x2 v) => default; // 0x0000000189C34B84-0x0000000189C34BC8
		public static float2x4 transpose(float4x2 v) => default; // 0x0000000189C5714C-0x0000000189C571B8
		public static uint hash(float4x2 v) => default; // 0x0000000189C36EC0-0x0000000189C36F8C
		public static uint4 hashwide(float4x2 v) => default; // 0x0000000189C3BFC0-0x0000000189C3C098
		public static float4x3 float4x3(float4 c0, float4 c1, float4 c2) => default; // 0x0000000183D7ACA0-0x0000000183D7ACC0
		public static float4x3 float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32) => default; // 0x0000000184D324B8-0x0000000184D32A74
		public static float4x3 float4x3(float v) => default; // 0x0000000189C34D9C-0x0000000189C34DBC
		public static float4x3 float4x3(bool v) => default; // 0x0000000189C34DBC-0x0000000189C34DDC
		public static float4x3 float4x3(bool4x3 v) => default; // 0x0000000189C34D1C-0x0000000189C34D58
		public static float4x3 float4x3(int v) => default; // 0x0000000189C34DDC-0x0000000189C34DFC
		public static float4x3 float4x3(int4x3 v) => default; // 0x0000000189C34DFC-0x0000000189C34E3C
		public static float4x3 float4x3(uint v) => default; // 0x0000000189C34CF8-0x0000000189C34D1C
		public static float4x3 float4x3(uint4x3 v) => default; // 0x0000000189C34D58-0x0000000189C34D9C
		public static float4x3 float4x3(double v) => default; // 0x0000000189C34CD8-0x0000000189C34CF8
		public static float4x3 float4x3(double4x3 v) => default; // 0x0000000189C34C78-0x0000000189C34CD8
		public static float3x4 transpose(float4x3 v) => default; // 0x0000000189C56AF8-0x0000000189C56B9C
		public static uint hash(float4x3 v) => default; // 0x0000000189C38104-0x0000000189C38234
		public static uint4 hashwide(float4x3 v) => default; // 0x0000000189C392A4-0x0000000189C393E0
		public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3) => default; // 0x0000000183D7ACC0-0x0000000183D7ACF0
		public static float4x4 float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) => default; // 0x0000000189C34E3C-0x0000000189C34F64
		public static float4x4 float4x4(float v) => default; // 0x0000000182E25B00-0x0000000182E25B30
		public static float4x4 float4x4(bool v) => default; // 0x0000000189C352B8-0x0000000189C352DC
		public static float4x4 float4x4(bool4x4 v) => default; // 0x0000000189C35368-0x0000000189C353A0
		public static float4x4 float4x4(int v) => default; // 0x0000000189C352DC-0x0000000189C35300
		public static float4x4 float4x4(int4x4 v) => default; // 0x0000000189C34F8C-0x0000000189C34FE8
		public static float4x4 float4x4(uint v) => default; // 0x0000000189C34F64-0x0000000189C34F8C
		public static float4x4 float4x4(uint4x4 v) => default; // 0x0000000189C351E8-0x0000000189C35244
		public static float4x4 float4x4(double v) => default; // 0x0000000189C34FE8-0x0000000189C3500C
		public static float4x4 float4x4(double4x4 v) => default; // 0x0000000189C35060-0x0000000189C350EC
		public static float3 rotate(float4x4 a, float3 b) => default; // 0x0000000189C52970-0x0000000189C52A48
		public static float3 transform(float4x4 a, float3 b) => default; // 0x0000000189C56668-0x0000000189C56764
		public static float4x4 transpose(float4x4 v) => default; // 0x0000000189C572FC-0x0000000189C573D8
		public static float4x4 inverse(float4x4 m) => default; // 0x0000000182E260E0-0x0000000182E26DF0
		public static float4x4 fastinverse(float4x4 m) => default; // 0x0000000189C33128-0x0000000189C33428
		public static float determinant(float4x4 m) => default; // 0x0000000183D79630-0x0000000183D798A0
		public static uint hash(float4x4 v) => default; // 0x0000000189C36088-0x0000000189C36218
		public static uint4 hashwide(float4x4 v) => default; // 0x0000000189C3AB14-0x0000000189C3ACB0
		public static half half(half x) => default; // 0x0000000183D4FEA0-0x0000000183D4FEB0
		public static half half(float v) => default; // 0x0000000189C35A48-0x0000000189C35A50
		public static half half(double v) => default; // 0x0000000189C35A3C-0x0000000189C35A48
		public static uint hash(half v) => default; // 0x0000000183D7B4B0-0x0000000183D7B4C0
		public static half2 half2(half x, half y) => default; // 0x0000000183D78800-0x0000000183D78810
		public static half2 half2(half2 xy) => default; // 0x0000000183D76740-0x0000000183D76760
		public static half2 half2(half v) => default; // 0x0000000183D7B2C0-0x0000000183D7B2D0
		public static half2 half2(float v) => default; // 0x0000000189C35780-0x0000000189C357A8
		public static half2 half2(float2 v) => default; // 0x0000000189C357A8-0x0000000189C357DC
		public static half2 half2(double v) => default; // 0x0000000189C35714-0x0000000189C35748
		public static half2 half2(double2 v) => default; // 0x0000000189C35748-0x0000000189C35780
		public static uint hash(half2 v) => default; // 0x0000000189C386E8-0x0000000189C3872C
		public static uint2 hashwide(half2 v) => default; // 0x0000000189C3B66C-0x0000000189C3B6C0
		public static half3 half3(half x, half y, half z) => default; // 0x0000000183D78810-0x0000000183D78830
		public static half3 half3(half x, half2 yz) => default; // 0x0000000183D7B310-0x0000000183D7B330
		public static half3 half3(half2 xy, half z) => default; // 0x0000000183D7B330-0x0000000183D7B350
		public static half3 half3(half3 xyz) => default; // 0x0000000183D7B2D0-0x0000000183D7B300
		public static half3 half3(half v) => default; // 0x0000000183D7B300-0x0000000183D7B310
		public static half3 half3(float v) => default; // 0x0000000189C358B0-0x0000000189C358E8
		public static half3 half3(float3 v) => default; // 0x0000000189C3586C-0x0000000189C358B0
		public static half3 half3(double v) => default; // 0x0000000189C357DC-0x0000000189C35820
		public static half3 half3(double3 v) => default; // 0x0000000189C35820-0x0000000189C3586C
		public static uint hash(half3 v) => default; // 0x0000000184D33234-0x0000000184D33EC4
		public static uint3 hashwide(half3 v) => default; // 0x0000000184D3930C-0x0000000184D399DC
		public static half4 half4(half x, half y, half z, half w) => default; // 0x0000000183D78830-0x0000000183D78860
		public static half4 half4(half x, half y, half2 zw) => default; // 0x0000000183D7B420-0x0000000183D7B450
		public static half4 half4(half x, half2 yz, half w) => default; // 0x0000000183D7B3A0-0x0000000183D7B3D0
		public static half4 half4(half x, half3 yzw) => default; // 0x0000000183D7B480-0x0000000183D7B4B0
		public static half4 half4(half2 xy, half z, half w) => default; // 0x0000000183D7B350-0x0000000183D7B380
		public static half4 half4(half2 xy, half2 zw) => default; // 0x0000000183D7B3D0-0x0000000183D7B3F0
		public static half4 half4(half3 xyz, half w) => default; // 0x0000000183D7B3F0-0x0000000183D7B420
		public static half4 half4(half4 xyzw) => default; // 0x0000000183D7B450-0x0000000183D7B480
		public static half4 half4(half v) => default; // 0x0000000183D7B380-0x0000000183D7B3A0
		public static half4 half4(float v) => default; // 0x0000000189C3594C-0x0000000189C35990
		public static half4 half4(float4 v) => default; // 0x0000000189C359E8-0x0000000189C35A3C
		public static half4 half4(double v) => default; // 0x0000000189C35990-0x0000000189C359E8
		public static half4 half4(double4 v) => default; // 0x0000000189C358E8-0x0000000189C3594C
		public static uint hash(half4 v) => default; // 0x0000000184D33194-0x0000000184D33234
		public static uint4 hashwide(half4 v) => default; // 0x0000000184D3AAA4-0x0000000184D3AC60
		public static int2 int2(int x, int y) => default; // 0x0000000183D78AF0-0x0000000183D78B00
		public static int2 int2(int2 xy) => default; // 0x0000000183D76940-0x0000000183D76960
		public static int2 int2(int v) => default; // 0x0000000183D7B520-0x0000000183D7B530
		public static int2 int2(bool v) => default; // 0x0000000189C3C78C-0x0000000189C3C7A4
		public static int2 int2(bool2 v) => default; // 0x0000000189C3C7A4-0x0000000189C3C7C4
		public static int2 int2(uint v) => default; // 0x0000000183D7B520-0x0000000183D7B530
		public static int2 int2(uint2 v) => default; // 0x0000000183D76940-0x0000000183D76960
		public static int2 int2(float v) => default; // 0x0000000183D7B500-0x0000000183D7B520
		public static int2 int2(float2 v) => default; // 0x0000000183D7B4C0-0x0000000183D7B4E0
		public static int2 int2(double v) => default; // 0x0000000183D7B4E0-0x0000000183D7B500
		public static int2 int2(double2 v) => default; // 0x0000000183D7B530-0x0000000183D7B550
		public static uint hash(int2 v) => default; // 0x0000000189C37144-0x0000000189C37178
		public static uint2 hashwide(int2 v) => default; // 0x0000000189C3B82C-0x0000000189C3B86C
		public static int shuffle(int2 left, int2 right, ShuffleComponent x) => default; // 0x0000000184D59424-0x0000000184D59638
		public static int2 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000184D5981C-0x0000000184D59868
		public static int3 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000184D592B8-0x0000000184D59328
		public static int4 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000184D588FC-0x0000000184D5898C
		internal static int select_shuffle_component(int2 a, int2 b, ShuffleComponent component) => default; // 0x0000000184D57CE4-0x0000000184D57EF8
		public static int2x2 int2x2(int2 c0, int2 c1) => default; // 0x0000000182232AA0-0x00000001822372F0
		public static int2x2 int2x2(int m00, int m01, int m10, int m11) => default; // 0x0000000189C3C820-0x0000000189C3C840
		public static int2x2 int2x2(int v) => default; // 0x0000000189C3C808-0x0000000189C3C820
		public static int2x2 int2x2(bool v) => default; // 0x0000000189C3C8C4-0x0000000189C3C8DC
		public static int2x2 int2x2(bool2x2 v) => default; // 0x0000000189C3C7C4-0x0000000189C3C7E4
		public static int2x2 int2x2(uint v) => default; // 0x0000000189C3C808-0x0000000189C3C820
		public static int2x2 int2x2(uint2x2 v) => default; // 0x0000000189C3C888-0x0000000189C3C8AC
		public static int2x2 int2x2(float v) => default; // 0x0000000189C3C870-0x0000000189C3C888
		public static int2x2 int2x2(float2x2 v) => default; // 0x0000000189C3C7E4-0x0000000189C3C808
		public static int2x2 int2x2(double v) => default; // 0x0000000189C3C8AC-0x0000000189C3C8C4
		public static int2x2 int2x2(double2x2 v) => default; // 0x0000000189C3C840-0x0000000189C3C870
		public static int2x2 transpose(int2x2 v) => default; // 0x0000000189C56888-0x0000000189C568C4
		public static int determinant(int2x2 m) => default; // 0x0000000183D79560-0x0000000183D79570
		public static uint hash(int2x2 v) => default; // 0x0000000189C37B00-0x0000000189C37B64
		public static uint2 hashwide(int2x2 v) => default; // 0x0000000189C3A6B0-0x0000000189C3A724
		public static int2x3 int2x3(int2 c0, int2 c1, int2 c2) => default; // 0x0000000183D7A7F0-0x0000000183D7A800
		public static int2x3 int2x3(int m00, int m01, int m02, int m10, int m11, int m12) => default; // 0x0000000184D3AE7C-0x0000000184D3AEB4
		public static int2x3 int2x3(int v) => default; // 0x0000000189C3C934-0x0000000189C3C954
		public static int2x3 int2x3(bool v) => default; // 0x0000000189C3C9E8-0x0000000189C3CA08
		public static int2x3 int2x3(bool2x3 v) => default; // 0x0000000189C3C974-0x0000000189C3C9AC
		public static int2x3 int2x3(uint v) => default; // 0x0000000189C3C934-0x0000000189C3C954
		public static int2x3 int2x3(uint2x3 v) => default; // 0x0000000189C3C8FC-0x0000000189C3C934
		public static int2x3 int2x3(float v) => default; // 0x0000000189C3C8DC-0x0000000189C3C8FC
		public static int2x3 int2x3(float2x3 v) => default; // 0x0000000189C3CA08-0x0000000189C3CA40
		public static int2x3 int2x3(double v) => default; // 0x0000000189C3C954-0x0000000189C3C974
		public static int2x3 int2x3(double2x3 v) => default; // 0x0000000189C3C9AC-0x0000000189C3C9E8
		public static int3x2 transpose(int2x3 v) => default; // 0x0000000189C574EC-0x0000000189C57538
		public static uint hash(int2x3 v) => default; // 0x0000000189C3737C-0x0000000189C3740C
		public static uint2 hashwide(int2x3 v) => default; // 0x0000000189C3B5CC-0x0000000189C3B66C
		public static int2x4 int2x4(int2 c0, int2 c1, int2 c2, int2 c3) => default; // 0x0000000183D7B550-0x0000000183D7B570
		public static int2x4 int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13) => default; // 0x0000000184D3AEB4-0x0000000184D3AF08
		public static int2x4 int2x4(int v) => default; // 0x0000000189C3CA64-0x0000000189C3CA80
		public static int2x4 int2x4(bool v) => default; // 0x0000000189C3CAB4-0x0000000189C3CAD0
		public static int2x4 int2x4(bool2x4 v) => default; // 0x0000000189C3CA40-0x0000000189C3CA64
		public static int2x4 int2x4(uint v) => default; // 0x0000000189C3CA64-0x0000000189C3CA80
		public static int2x4 int2x4(uint2x4 v) => default; // 0x0000000189C3CA80-0x0000000189C3CAB4
		public static int2x4 int2x4(float v) => default; // 0x0000000189C3CB20-0x0000000189C3CB3C
		public static int2x4 int2x4(float2x4 v) => default; // 0x0000000189C3CAEC-0x0000000189C3CB20
		public static int2x4 int2x4(double v) => default; // 0x0000000189C3CAD0-0x0000000189C3CAEC
		public static int2x4 int2x4(double2x4 v) => default; // 0x0000000189C3CB3C-0x0000000189C3CB80
		public static int4x2 transpose(int2x4 v) => default; // 0x0000000189C56AA0-0x0000000189C56AF8
		public static uint hash(int2x4 v) => default; // 0x0000000189C36B34-0x0000000189C36BF0
		public static uint2 hashwide(int2x4 v) => default; // 0x0000000189C39EF8-0x0000000189C39FC4
		public static int3 int3(int x, int y, int z) => default; // 0x0000000183D78B00-0x0000000183D78B10
		public static int3 int3(int x, int2 yz) => default; // 0x0000000183D7B5B0-0x0000000183D7B5D0
		public static int3 int3(int2 xy, int z) => default; // 0x0000000183D7B5D0-0x0000000183D7B5F0
		public static int3 int3(int3 xyz) => default; // 0x0000000183D7B5F0-0x0000000183D7B620
		public static int3 int3(int v) => default; // 0x0000000183D7B570-0x0000000183D7B580
		public static int3 int3(bool v) => default; // 0x0000000189C3CB80-0x0000000189C3CB98
		public static int3 int3(bool3 v) => default; // 0x0000000189C3CB98-0x0000000189C3CBCC
		public static int3 int3(uint v) => default; // 0x0000000183D7B570-0x0000000183D7B580
		public static int3 int3(uint3 v) => default; // 0x0000000183D7B5F0-0x0000000183D7B620
		public static int3 int3(float v) => default; // 0x0000000183D7B640-0x0000000183D7B660
		public static int3 int3(float3 v) => default; // 0x0000000183D7B580-0x0000000183D7B5B0
		public static int3 int3(double v) => default; // 0x0000000183D7B620-0x0000000183D7B640
		public static int3 int3(double3 v) => default; // 0x0000000183D7B660-0x0000000183D7B6A0
		public static uint hash(int3 v) => default; // 0x0000000189C38520-0x0000000189C38594
		public static uint3 hashwide(int3 v) => default; // 0x0000000184D3A4C4-0x0000000184D3AAA4
		public static int shuffle(int3 left, int3 right, ShuffleComponent x) => default; // 0x0000000184D587A0-0x0000000184D5887C
		public static int2 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000184D58C54-0x0000000184D58D90
		public static int3 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000184D59638-0x0000000184D5978C
		public static int4 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000184D58D90-0x0000000184D58EA8
		internal static int select_shuffle_component(int3 a, int3 b, ShuffleComponent component) => default; // 0x0000000184D57170-0x0000000184D57274
		public static int3x2 int3x2(int3 c0, int3 c1) => default; // 0x0000000183D7AA40-0x0000000183D7AA70
		public static int3x2 int3x2(int m00, int m01, int m10, int m11, int m20, int m21) => default; // 0x0000000184D3AF08-0x0000000184D3AF98
		public static int3x2 int3x2(int v) => default; // 0x0000000189C3CC7C-0x0000000189C3CC9C
		public static int3x2 int3x2(bool v) => default; // 0x0000000189C3CC9C-0x0000000189C3CCBC
		public static int3x2 int3x2(bool3x2 v) => default; // 0x0000000189C3CCBC-0x0000000189C3CCF4
		public static int3x2 int3x2(uint v) => default; // 0x0000000189C3CC7C-0x0000000189C3CC9C
		public static int3x2 int3x2(uint3x2 v) => default; // 0x0000000189C3CC0C-0x0000000189C3CC44
		public static int3x2 int3x2(float v) => default; // 0x0000000189C3CCF4-0x0000000189C3CD14
		public static int3x2 int3x2(float3x2 v) => default; // 0x0000000189C3CC44-0x0000000189C3CC7C
		public static int3x2 int3x2(double v) => default; // 0x0000000189C3CD14-0x0000000189C3CD34
		public static int3x2 int3x2(double3x2 v) => default; // 0x0000000189C3CBCC-0x0000000189C3CC0C
		public static int2x3 transpose(int3x2 v) => default; // 0x0000000189C568C4-0x0000000189C56910
		public static uint hash(int3x2 v) => default; // 0x0000000189C3872C-0x0000000189C3880C
		public static uint3 hashwide(int3x2 v) => default; // 0x0000000189C3A5B8-0x0000000189C3A6B0
		public static int3x3 int3x3(int3 c0, int3 c1, int3 c2) => default; // 0x0000000182E246E0-0x0000000182E247E0
		public static int3x3 int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22) => default; // 0x0000000184D3AF98-0x0000000184D3B05C
		public static int3x3 int3x3(int v) => default; // 0x0000000189C3CD34-0x0000000189C3CD54
		public static int3x3 int3x3(bool v) => default; // 0x0000000189C3CEAC-0x0000000189C3CECC
		public static int3x3 int3x3(bool3x3 v) => default; // 0x0000000189C3CE6C-0x0000000189C3CEAC
		public static int3x3 int3x3(uint v) => default; // 0x0000000189C3CD34-0x0000000189C3CD54
		public static int3x3 int3x3(uint3x3 v) => default; // 0x0000000189C3CD74-0x0000000189C3CDB4
		public static int3x3 int3x3(float v) => default; // 0x0000000189C3CD54-0x0000000189C3CD74
		public static int3x3 int3x3(float3x3 v) => default; // 0x0000000189C3CE0C-0x0000000189C3CE4C
		public static int3x3 int3x3(double v) => default; // 0x0000000189C3CE4C-0x0000000189C3CE6C
		public static int3x3 int3x3(double3x3 v) => default; // 0x0000000189C3CDB4-0x0000000189C3CE0C
		public static int3x3 transpose(int3x3 v) => default; // 0x0000000189C56E28-0x0000000189C56E94
		public static int determinant(int3x3 m) => default; // 0x0000000183D79B70-0x0000000183D79C10
		public static uint hash(int3x3 v) => default; // 0x0000000189C36894-0x0000000189C369E8
		public static uint3 hashwide(int3x3 v) => default; // 0x0000000189C39D8C-0x0000000189C39EF8
		public static int3x4 int3x4(int3 c0, int3 c1, int3 c2, int3 c3) => default; // 0x0000000183D7AA70-0x0000000183D7AAC0
		public static int3x4 int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23) => default; // 0x0000000184D3B05C-0x0000000184D3B124
		public static int3x4 int3x4(int v) => default; // 0x0000000189C3CF88-0x0000000189C3CFA8
		public static int3x4 int3x4(bool v) => default; // 0x0000000189C3CECC-0x0000000189C3CEEC
		public static int3x4 int3x4(bool3x4 v) => default; // 0x0000000189C3CF4C-0x0000000189C3CF88
		public static int3x4 int3x4(uint v) => default; // 0x0000000189C3CF88-0x0000000189C3CFA8
		public static int3x4 int3x4(uint3x4 v) => default; // 0x0000000189C3D02C-0x0000000189C3D070
		public static int3x4 int3x4(float v) => default; // 0x0000000189C3D00C-0x0000000189C3D02C
		public static int3x4 int3x4(float3x4 v) => default; // 0x0000000189C3CFA8-0x0000000189C3CFEC
		public static int3x4 int3x4(double v) => default; // 0x0000000189C3CFEC-0x0000000189C3D00C
		public static int3x4 int3x4(double3x4 v) => default; // 0x0000000189C3CEEC-0x0000000189C3CF4C
		public static int4x3 transpose(int3x4 v) => default; // 0x0000000189C569B0-0x0000000189C56A34
		public static uint hash(int3x4 v) => default; // 0x0000000189C36638-0x0000000189C36804
		public static uint3 hashwide(int3x4 v) => default; // 0x0000000189C3AD7C-0x0000000189C3AF5C
		public static int4 int4(int x, int y, int z, int w) => default; // 0x0000000183D78B10-0x0000000183D78B30
		public static int4 int4(int x, int y, int2 zw) => default; // 0x0000000183D7B730-0x0000000183D7B750
		public static int4 int4(int x, int2 yz, int w) => default; // 0x0000000183D7B7B0-0x0000000183D7B7D0
		public static int4 int4(int x, int3 yzw) => default; // 0x0000000183D7B6B0-0x0000000183D7B6F0
		public static int4 int4(int2 xy, int z, int w) => default; // 0x0000000183D7B750-0x0000000183D7B770
		public static int4 int4(int2 xy, int2 zw) => default; // 0x0000000183D76960-0x0000000183D76980
		public static int4 int4(int3 xyz, int w) => default; // 0x0000000183D7B770-0x0000000183D7B7B0
		public static int4 int4(int4 xyzw) => default; // 0x0000000189C3D070-0x0000000189C3D09C
		public static int4 int4(int v) => default; // 0x0000000183D7B6A0-0x0000000183D7B6B0
		public static int4 int4(bool v) => default; // 0x0000000189C3D09C-0x0000000189C3D0BC
		public static int4 int4(bool4 v) => default; // 0x0000000189C3D0BC-0x0000000189C3D100
		public static int4 int4(uint v) => default; // 0x0000000183D7B6A0-0x0000000183D7B6B0
		public static int4 int4(uint4 v) => default; // 0x0000000189C3D070-0x0000000189C3D09C
		public static int4 int4(float v) => default; // 0x0000000183D7B710-0x0000000183D7B730
		public static int4 int4(float4 v) => default; // 0x0000000189C3D130-0x0000000189C3D164
		public static int4 int4(double v) => default; // 0x0000000183D7B6F0-0x0000000183D7B710
		public static int4 int4(double4 v) => default; // 0x0000000189C3D100-0x0000000189C3D130
		public static uint hash(int4 v) => default; // 0x0000000189C3880C-0x0000000189C38878
		public static uint4 hashwide(int4 v) => default; // 0x0000000189C3C3D8-0x0000000189C3C454
		public static int shuffle(int4 left, int4 right, ShuffleComponent x) => default; // 0x0000000189C543F4-0x0000000189C5441C
		public static int2 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000189C53AD8-0x0000000189C53B30
		public static int3 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000189C54AB8-0x0000000189C54B60
		public static int4 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000189C53CBC-0x0000000189C53D94
		internal static int select_shuffle_component(int4 a, int4 b, ShuffleComponent component) => default; // 0x0000000184D57784-0x0000000184D579DC
		public static int4x2 int4x2(int4 c0, int4 c1) => default; // 0x0000000183D7AC80-0x0000000183D7ACA0
		public static int4x2 int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31) => default; // 0x0000000184D3B124-0x0000000184D3B1D8
		public static int4x2 int4x2(int v) => default; // 0x0000000189C3D1C4-0x0000000189C3D1E0
		public static int4x2 int4x2(bool v) => default; // 0x0000000189C3D230-0x0000000189C3D24C
		public static int4x2 int4x2(bool4x2 v) => default; // 0x0000000189C3D280-0x0000000189C3D2A4
		public static int4x2 int4x2(uint v) => default; // 0x0000000189C3D1C4-0x0000000189C3D1E0
		public static int4x2 int4x2(uint4x2 v) => default; // 0x0000000189C3D1E0-0x0000000189C3D214
		public static int4x2 int4x2(float v) => default; // 0x0000000189C3D214-0x0000000189C3D230
		public static int4x2 int4x2(float4x2 v) => default; // 0x0000000189C3D24C-0x0000000189C3D280
		public static int4x2 int4x2(double v) => default; // 0x0000000189C3D164-0x0000000189C3D180
		public static int4x2 int4x2(double4x2 v) => default; // 0x0000000189C3D180-0x0000000189C3D1C4
		public static int2x4 transpose(int4x2 v) => default; // 0x0000000189C56910-0x0000000189C56968
		public static uint hash(int4x2 v) => default; // 0x0000000189C37C74-0x0000000189C37D40
		public static uint4 hashwide(int4x2 v) => default; // 0x0000000189C3A224-0x0000000189C3A2FC
		public static int4x3 int4x3(int4 c0, int4 c1, int4 c2) => default; // 0x0000000183D7ACA0-0x0000000183D7ACC0
		public static int4x3 int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32) => default; // 0x0000000184D3B1D8-0x0000000184D3B3A0
		public static int4x3 int4x3(int v) => default; // 0x0000000189C3D2C4-0x0000000189C3D2E4
		public static int4x3 int4x3(bool v) => default; // 0x0000000189C3D3E4-0x0000000189C3D404
		public static int4x3 int4x3(bool4x3 v) => default; // 0x0000000189C3D364-0x0000000189C3D3A0
		public static int4x3 int4x3(uint v) => default; // 0x0000000189C3D2C4-0x0000000189C3D2E4
		public static int4x3 int4x3(uint4x3 v) => default; // 0x0000000189C3D3A0-0x0000000189C3D3E4
		public static int4x3 int4x3(float v) => default; // 0x0000000189C3D344-0x0000000189C3D364
		public static int4x3 int4x3(float4x3 v) => default; // 0x0000000189C3D404-0x0000000189C3D444
		public static int4x3 int4x3(double v) => default; // 0x0000000189C3D2A4-0x0000000189C3D2C4
		public static int4x3 int4x3(double4x3 v) => default; // 0x0000000189C3D2E4-0x0000000189C3D344
		public static int3x4 transpose(int4x3 v) => default; // 0x0000000189C56CC4-0x0000000189C56D48
		public static uint hash(int4x3 v) => default; // 0x0000000189C37D40-0x0000000189C37E70
		public static uint4 hashwide(int4x3 v) => default; // 0x0000000189C3B86C-0x0000000189C3B9A8
		public static int4x4 int4x4(int4 c0, int4 c1, int4 c2, int4 c3) => default; // 0x0000000183D7ACC0-0x0000000183D7ACF0
		public static int4x4 int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33) => default; // 0x0000000184D3B3A0-0x0000000184D3B638
		public static int4x4 int4x4(int v) => default; // 0x0000000189C3D4C4-0x0000000189C3D4E8
		public static int4x4 int4x4(bool v) => default; // 0x0000000189C3D444-0x0000000189C3D468
		public static int4x4 int4x4(bool4x4 v) => default; // 0x0000000189C3D50C-0x0000000189C3D544
		public static int4x4 int4x4(uint v) => default; // 0x0000000189C3D4C4-0x0000000189C3D4E8
		public static int4x4 int4x4(uint4x4 v) => default; // 0x0000000189C3D544-0x0000000189C3D5A0
		public static int4x4 int4x4(float v) => default; // 0x0000000189C3D4E8-0x0000000189C3D50C
		public static int4x4 int4x4(float4x4 v) => default; // 0x0000000189C3D468-0x0000000189C3D4C4
		public static int4x4 int4x4(double v) => default; // 0x0000000189C3D62C-0x0000000189C3D650
		public static int4x4 int4x4(double4x4 v) => default; // 0x0000000189C3D5A0-0x0000000189C3D62C
		public static int4x4 transpose(int4x4 v) => default; // 0x0000000189C57048-0x0000000189C570F0
		public static int determinant(int4x4 m) => default; // 0x0000000183D798A0-0x0000000183D79AC0
		public static uint hash(int4x4 v) => default; // 0x0000000189C376C0-0x0000000189C37850
		public static uint4 hashwide(int4x4 v) => default; // 0x0000000189C3A724-0x0000000189C3A8C0
		public static int asint(uint x) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public static int2 asint(uint2 x) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static int3 asint(uint3 x) => default; // 0x0000000183D56520-0x0000000183D56540
		public static int4 asint(uint4 x) => default; // 0x0000000183D5B250-0x0000000183D5B260
		public static int asint(float x) => default; // 0x0000000183D70290-0x0000000183D702A0
		public static int2 asint(float2 x) => default; // 0x0000000183D787A0-0x0000000183D787B0
		public static int3 asint(float3 x) => default; // 0x0000000183D56520-0x0000000183D56540
		public static int4 asint(float4 x) => default; // 0x0000000183D5B250-0x0000000183D5B260
		public static uint asuint(int x) => default; // 0x0000000183D517B0-0x0000000183D517C0
		public static uint2 asuint(int2 x) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static uint3 asuint(int3 x) => default; // 0x0000000183D56520-0x0000000183D56540
		public static uint4 asuint(int4 x) => default; // 0x0000000183D5B250-0x0000000183D5B260
		public static uint asuint(float x) => default; // 0x0000000183D70290-0x0000000183D702A0
		public static uint2 asuint(float2 x) => default; // 0x0000000183D787A0-0x0000000183D787B0
		public static uint3 asuint(float3 x) => default; // 0x0000000183D56520-0x0000000183D56540
		public static uint4 asuint(float4 x) => default; // 0x0000000183D5B250-0x0000000183D5B260
		public static long aslong(ulong x) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static long aslong(double x) => default; // 0x0000000183D70270-0x0000000183D70280
		public static ulong asulong(long x) => default; // 0x000000018339AE90-0x000000018339AEA0
		public static ulong asulong(double x) => default; // 0x0000000183D70270-0x0000000183D70280
		public static float asfloat(int x) => default; // 0x0000000183D6BFD0-0x0000000183D6BFE0
		public static float2 asfloat(int2 x) => default; // 0x0000000183D785A0-0x0000000183D785C0
		public static float3 asfloat(int3 x) => default; // 0x0000000183D56520-0x0000000183D56540
		public static float4 asfloat(int4 x) => default; // 0x0000000183D5B250-0x0000000183D5B260
		public static float asfloat(uint x) => default; // 0x0000000183D6BFD0-0x0000000183D6BFE0
		public static float2 asfloat(uint2 x) => default; // 0x0000000183D785A0-0x0000000183D785C0
		public static float3 asfloat(uint3 x) => default; // 0x0000000183D56520-0x0000000183D56540
		public static float4 asfloat(uint4 x) => default; // 0x0000000183D5B250-0x0000000183D5B260
		public static int bitmask(bool4 value) => default; // 0x0000000189C2EC1C-0x0000000189C2EC58
		public static double asdouble(long x) => default; // 0x0000000183D70280-0x0000000183D70290
		public static double asdouble(ulong x) => default; // 0x0000000183D70280-0x0000000183D70290
		public static bool isfinite(float x) => default; // 0x0000000189C3F2B8-0x0000000189C3F2D4
		public static bool2 isfinite(float2 x) => default; // 0x0000000189C3F240-0x0000000189C3F274
		public static bool3 isfinite(float3 x) => default; // 0x0000000189C3F100-0x0000000189C3F16C
		public static bool4 isfinite(float4 x) => default; // 0x0000000189C3F16C-0x0000000189C3F1D0
		public static bool isfinite(double x) => default; // 0x0000000189C3F0D8-0x0000000189C3F100
		public static bool2 isfinite(double2 x) => default; // 0x0000000189C3F274-0x0000000189C3F2B8
		public static bool3 isfinite(double3 x) => default; // 0x0000000189C3F2D4-0x0000000189C3F348
		public static bool4 isfinite(double4 x) => default; // 0x0000000189C3F1D0-0x0000000189C3F240
		public static bool isinf(float x) => default; // 0x0000000189C3F348-0x0000000189C3F368
		public static bool2 isinf(float2 x) => default; // 0x0000000189C3F448-0x0000000189C3F468
		public static bool3 isinf(float3 x) => default; // 0x0000000189C3F4E0-0x0000000189C3F548
		public static bool4 isinf(float4 x) => default; // 0x0000000189C3F4A4-0x0000000189C3F4E0
		public static bool isinf(double x) => default; // 0x0000000189C3F3D0-0x0000000189C3F3FC
		public static bool2 isinf(double2 x) => default; // 0x0000000189C3F468-0x0000000189C3F4A4
		public static bool3 isinf(double3 x) => default; // 0x0000000189C3F368-0x0000000189C3F3D0
		public static bool4 isinf(double4 x) => default; // 0x0000000189C3F3FC-0x0000000189C3F448
		public static bool isnan(float x) => default; // 0x0000000189C3F5F4-0x0000000189C3F608
		public static bool2 isnan(float2 x) => default; // 0x0000000189C3F5A8-0x0000000189C3F5F4
		public static bool3 isnan(float3 x) => default; // 0x0000000189C3F750-0x0000000189C3F7C8
		public static bool4 isnan(float4 x) => default; // 0x0000000189C3F6D4-0x0000000189C3F750
		public static bool isnan(double x) => default; // 0x0000000189C3F670-0x0000000189C3F694
		public static bool2 isnan(double2 x) => default; // 0x0000000189C3F694-0x0000000189C3F6D4
		public static bool3 isnan(double3 x) => default; // 0x0000000189C3F548-0x0000000189C3F5A8
		public static bool4 isnan(double4 x) => default; // 0x0000000189C3F608-0x0000000189C3F670
		public static bool ispow2(int x) => default; // 0x0000000189C3F81C-0x0000000189C3F82C
		public static bool2 ispow2(int2 x) => default; // 0x0000000189C3F82C-0x0000000189C3F860
		public static bool3 ispow2(int3 x) => default; // 0x0000000189C3F7C8-0x0000000189C3F81C
		public static bool4 ispow2(int4 x) => default; // 0x0000000189C3F96C-0x0000000189C3F9E4
		public static bool ispow2(uint x) => default; // 0x0000000189C3F8D8-0x0000000189C3F8E8
		public static bool2 ispow2(uint2 x) => default; // 0x0000000189C3F8E8-0x0000000189C3F91C
		public static bool3 ispow2(uint3 x) => default; // 0x0000000189C3F91C-0x0000000189C3F96C
		public static bool4 ispow2(uint4 x) => default; // 0x0000000189C3F860-0x0000000189C3F8D8
		public static int min(int x, int y) => default; // 0x0000000189C40B98-0x0000000189C40BA0
		public static int2 min(int2 x, int2 y) => default; // 0x0000000189C40E7C-0x0000000189C40EA8
		public static int3 min(int3 x, int3 y) => default; // 0x0000000189C40EBC-0x0000000189C40EF0
		public static int4 min(int4 x, int4 y) => default; // 0x0000000189C40C74-0x0000000189C40CB8
		public static uint min(uint x, uint y) => default; // 0x0000000189C40EB4-0x0000000189C40EBC
		public static uint2 min(uint2 x, uint2 y) => default; // 0x0000000189C40D60-0x0000000189C40D8C
		public static uint3 min(uint3 x, uint3 y) => default; // 0x0000000189C40DF8-0x0000000189C40E2C
		public static uint4 min(uint4 x, uint4 y) => default; // 0x0000000189C40E2C-0x0000000189C40E70
		public static long min(long x, long y) => default; // 0x0000000189C40E70-0x0000000189C40E7C
		public static ulong min(ulong x, ulong y) => default; // 0x0000000189C40EA8-0x0000000189C40EB4
		public static float min(float x, float y) => default; // 0x0000000189C40D8C-0x0000000189C40DA0
		public static float2 min(float2 x, float2 y) => default; // 0x0000000189C40DA0-0x0000000189C40DF8
		public static float3 min(float3 x, float3 y) => default; // 0x0000000189C40C0C-0x0000000189C40C74
		public static float4 min(float4 x, float4 y) => default; // 0x0000000184D3D1F0-0x0000000184D3D390
		public static double min(double x, double y) => default; // 0x0000000189C40CB8-0x0000000189C40CD0
		public static double2 min(double2 x, double2 y) => default; // 0x0000000184D3D0B0-0x0000000184D3D1F0
		public static double3 min(double3 x, double3 y) => default; // 0x0000000189C40BA0-0x0000000189C40C0C
		public static double4 min(double4 x, double4 y) => default; // 0x0000000189C40CD0-0x0000000189C40D60
		public static int max(int x, int y) => default; // 0x0000000189C40930-0x0000000189C40938
		public static int2 max(int2 x, int2 y) => default; // 0x0000000189C4085C-0x0000000189C40888
		public static int3 max(int3 x, int3 y) => default; // 0x0000000189C40828-0x0000000189C4085C
		public static int4 max(int4 x, int4 y) => default; // 0x0000000189C409F0-0x0000000189C40A34
		public static uint max(uint x, uint y) => default; // 0x0000000189C40ACC-0x0000000189C40AD4
		public static uint2 max(uint2 x, uint2 y) => default; // 0x0000000189C40AD4-0x0000000189C40B00
		public static uint3 max(uint3 x, uint3 y) => default; // 0x0000000189C40B0C-0x0000000189C40B40
		public static uint4 max(uint4 x, uint4 y) => default; // 0x0000000189C409AC-0x0000000189C409F0
		public static long max(long x, long y) => default; // 0x0000000189C40B00-0x0000000189C40B0C
		public static ulong max(ulong x, ulong y) => default; // 0x0000000189C4090C-0x0000000189C40918
		public static float max(float x, float y) => default; // 0x0000000189C408F8-0x0000000189C4090C
		public static float2 max(float2 x, float2 y) => default; // 0x0000000189C40B40-0x0000000189C40B98
		public static float3 max(float3 x, float3 y) => default; // 0x0000000189C40888-0x0000000189C408F8
		public static float4 max(float4 x, float4 y) => default; // 0x0000000184D3CD68-0x0000000184D3CEB4
		public static double max(double x, double y) => default; // 0x0000000189C40918-0x0000000189C40930
		public static double2 max(double2 x, double2 y) => default; // 0x0000000184D3CEB4-0x0000000184D3D0B0
		public static double3 max(double3 x, double3 y) => default; // 0x0000000189C40938-0x0000000189C409AC
		public static double4 max(double4 x, double4 y) => default; // 0x0000000189C40A34-0x0000000189C40ACC
		public static float lerp(float start, float end, float t) => default; // 0x0000000183D52690-0x0000000183D526A0
		public static float2 lerp(float2 start, float2 end, float t) => default; // 0x0000000189C4005C-0x0000000189C40098
		public static float3 lerp(float3 start, float3 end, float t) => default; // 0x0000000184D3C0B0-0x0000000184D3C4C4
		public static float4 lerp(float4 start, float4 end, float t) => default; // 0x0000000189C40098-0x0000000189C40114
		public static float2 lerp(float2 start, float2 end, float2 t) => default; // 0x0000000189C3FC90-0x0000000189C3FCCC
		public static float3 lerp(float3 start, float3 end, float3 t) => default; // 0x0000000184D3BCA8-0x0000000184D3C0B0
		public static float4 lerp(float4 start, float4 end, float4 t) => default; // 0x0000000189C3FC08-0x0000000189C3FC90
		public static double lerp(double start, double end, double t) => default; // 0x0000000183D7B850-0x0000000183D7B860
		public static double2 lerp(double2 start, double2 end, double t) => default; // 0x0000000189C3FB8C-0x0000000189C3FC08
		public static double3 lerp(double3 start, double3 end, double t) => default; // 0x0000000189C3FF9C-0x0000000189C4005C
		public static double4 lerp(double4 start, double4 end, double t) => default; // 0x0000000189C3FE60-0x0000000189C3FF14
		public static double2 lerp(double2 start, double2 end, double2 t) => default; // 0x0000000189C3FF14-0x0000000189C3FF9C
		public static double3 lerp(double3 start, double3 end, double3 t) => default; // 0x0000000189C3FD90-0x0000000189C3FE60
		public static double4 lerp(double4 start, double4 end, double4 t) => default; // 0x0000000189C3FCCC-0x0000000189C3FD90
		public static float unlerp(float start, float end, float x) => default; // 0x0000000189C58608-0x0000000189C58618
		public static float2 unlerp(float2 start, float2 end, float2 x) => default; // 0x0000000189C586D0-0x0000000189C5872C
		public static float3 unlerp(float3 start, float3 end, float3 x) => default; // 0x0000000184D5E9BC-0x0000000184D5EC14
		public static float4 unlerp(float4 start, float4 end, float4 x) => default; // 0x0000000189C58618-0x0000000189C586D0
		public static double unlerp(double start, double end, double x) => default; // 0x0000000189C58808-0x0000000189C58818
		public static double2 unlerp(double2 start, double2 end, double2 x) => default; // 0x0000000189C58590-0x0000000189C58608
		public static double3 unlerp(double3 start, double3 end, double3 x) => default; // 0x0000000189C584A0-0x0000000189C58590
		public static double4 unlerp(double4 start, double4 end, double4 x) => default; // 0x0000000189C5872C-0x0000000189C58808
		public static float remap(float srcStart, float srcEnd, float dstStart, float dstEnd, float x) => default; // 0x0000000189C51D50-0x0000000189C51D74
		public static float2 remap(float2 srcStart, float2 srcEnd, float2 dstStart, float2 dstEnd, float2 x) => default; // 0x0000000189C51CCC-0x0000000189C51D50
		public static float3 remap(float3 srcStart, float3 srcEnd, float3 dstStart, float3 dstEnd, float3 x) => default; // 0x0000000184D55754-0x0000000184D55AD0
		public static float4 remap(float4 srcStart, float4 srcEnd, float4 dstStart, float4 dstEnd, float4 x) => default; // 0x0000000189C51C18-0x0000000189C51CA8
		public static double remap(double srcStart, double srcEnd, double dstStart, double dstEnd, double x) => default; // 0x0000000189C51CA8-0x0000000189C51CCC
		public static double2 remap(double2 srcStart, double2 srcEnd, double2 dstStart, double2 dstEnd, double2 x) => default; // 0x0000000189C51E54-0x0000000189C51EE4
		public static double3 remap(double3 srcStart, double3 srcEnd, double3 dstStart, double3 dstEnd, double3 x) => default; // 0x0000000189C51D74-0x0000000189C51E54
		public static double4 remap(double4 srcStart, double4 srcEnd, double4 dstStart, double4 dstEnd, double4 x) => default; // 0x0000000189C51EE4-0x0000000189C51FB8
		public static int mad(int mulA, int mulB, int addC) => default; // 0x0000000183D7BC50-0x0000000183D7BC60
		public static int2 mad(int2 mulA, int2 mulB, int2 addC) => default; // 0x0000000189C40608-0x0000000189C40620
		public static int3 mad(int3 mulA, int3 mulB, int3 addC) => default; // 0x0000000184D3CA68-0x0000000184D3CCE0
		public static int4 mad(int4 mulA, int4 mulB, int4 addC) => default; // 0x0000000189C405A4-0x0000000189C40608
		public static uint mad(uint mulA, uint mulB, uint addC) => default; // 0x0000000183D7BC50-0x0000000183D7BC60
		public static uint2 mad(uint2 mulA, uint2 mulB, uint2 addC) => default; // 0x0000000189C40608-0x0000000189C40620
		public static uint3 mad(uint3 mulA, uint3 mulB, uint3 addC) => default; // 0x0000000184D3CA68-0x0000000184D3CCE0
		public static uint4 mad(uint4 mulA, uint4 mulB, uint4 addC) => default; // 0x0000000189C405A4-0x0000000189C40608
		public static long mad(long mulA, long mulB, long addC) => default; // 0x0000000183D7BC20-0x0000000183D7BC30
		public static ulong mad(ulong mulA, ulong mulB, ulong addC) => default; // 0x0000000183D7BC20-0x0000000183D7BC30
		public static float mad(float mulA, float mulB, float addC) => default; // 0x0000000183D7BC30-0x0000000183D7BC40
		public static float2 mad(float2 mulA, float2 mulB, float2 addC) => default; // 0x0000000189C406B8-0x0000000189C406D0
		public static float3 mad(float3 mulA, float3 mulB, float3 addC) => default; // 0x0000000184D3CCE0-0x0000000184D3CD68
		public static float4 mad(float4 mulA, float4 mulB, float4 addC) => default; // 0x0000000189C40734-0x0000000189C40798
		public static double mad(double mulA, double mulB, double addC) => default; // 0x0000000183D7BC40-0x0000000183D7BC50
		public static double2 mad(double2 mulA, double2 mulB, double2 addC) => default; // 0x0000000189C406D0-0x0000000189C40734
		public static double3 mad(double3 mulA, double3 mulB, double3 addC) => default; // 0x0000000189C40620-0x0000000189C406B8
		public static double4 mad(double4 mulA, double4 mulB, double4 addC) => default; // 0x0000000189C40798-0x0000000189C40828
		public static int clamp(int valueToClamp, int lowerBound, int upperBound) => default; // 0x0000000189C2F864-0x0000000189C2F878
		public static int2 clamp(int2 valueToClamp, int2 lowerBound, int2 upperBound) => default; // 0x0000000189C2F8B4-0x0000000189C2F910
		public static int3 clamp(int3 valueToClamp, int3 lowerBound, int3 upperBound) => default; // 0x0000000184D2E488-0x0000000184D2E630
		public static int4 clamp(int4 valueToClamp, int4 lowerBound, int4 upperBound) => default; // 0x0000000189C2F7A0-0x0000000189C2F864
		public static uint clamp(uint valueToClamp, uint lowerBound, uint upperBound) => default; // 0x0000000189C2F78C-0x0000000189C2F7A0
		public static uint2 clamp(uint2 valueToClamp, uint2 lowerBound, uint2 upperBound) => default; // 0x0000000189C2F668-0x0000000189C2F6C4
		public static uint3 clamp(uint3 valueToClamp, uint3 lowerBound, uint3 upperBound) => default; // 0x0000000184D2E630-0x0000000184D2E7E8
		public static uint4 clamp(uint4 valueToClamp, uint4 lowerBound, uint4 upperBound) => default; // 0x0000000189C2F4A0-0x0000000189C2F564
		public static long clamp(long valueToClamp, long lowerBound, long upperBound) => default; // 0x0000000189C2F6EC-0x0000000189C2F700
		public static ulong clamp(ulong valueToClamp, ulong lowerBound, ulong upperBound) => default; // 0x0000000189C2F8A0-0x0000000189C2F8B4
		public static float clamp(float valueToClamp, float lowerBound, float upperBound) => default; // 0x0000000189C2F878-0x0000000189C2F8A0
		public static float2 clamp(float2 valueToClamp, float2 lowerBound, float2 upperBound) => default; // 0x0000000189C2F6C4-0x0000000189C2F6EC
		public static float3 clamp(float3 valueToClamp, float3 lowerBound, float3 upperBound) => default; // 0x0000000189C2F700-0x0000000189C2F78C
		public static float4 clamp(float4 valueToClamp, float4 lowerBound, float4 upperBound) => default; // 0x0000000189C2F564-0x0000000189C2F5CC
		public static double clamp(double valueToClamp, double lowerBound, double upperBound) => default; // 0x0000000184D2E358-0x0000000184D2E488
		public static double2 clamp(double2 valueToClamp, double2 lowerBound, double2 upperBound) => default; // 0x0000000189C2F910-0x0000000189C2F978
		public static double3 clamp(double3 valueToClamp, double3 lowerBound, double3 upperBound) => default; // 0x0000000189C2F5CC-0x0000000189C2F668
		public static double4 clamp(double4 valueToClamp, double4 lowerBound, double4 upperBound) => default; // 0x0000000189C2F978-0x0000000189C2FA08
		public static float saturate(float x) => default; // 0x00000001889C152C-0x00000001889C153C
		public static float2 saturate(float2 x) => default; // 0x0000000189C53300-0x0000000189C5333C
		public static float3 saturate(float3 x) => default; // 0x0000000184D56B10-0x0000000184D56E50
		public static float4 saturate(float4 x) => default; // 0x0000000189C532B4-0x0000000189C53300
		public static double saturate(double x) => default; // 0x0000000189C532A4-0x0000000189C532B4
		public static double2 saturate(double2 x) => default; // 0x0000000189C533D8-0x0000000189C53428
		public static double3 saturate(double3 x) => default; // 0x0000000189C5333C-0x0000000189C533D8
		public static double4 saturate(double4 x) => default; // 0x0000000189C53238-0x0000000189C532A4
		public static int abs(int x) => default; // 0x0000000189C2E034-0x0000000189C2E040
		public static int2 abs(int2 x) => default; // 0x0000000189C2DF38-0x0000000189C2DF7C
		public static int3 abs(int3 x) => default; // 0x0000000184D2C678-0x0000000184D2CBB0
		public static int4 abs(int4 x) => default; // 0x0000000189C2DF7C-0x0000000189C2E034
		public static long abs(long x) => default; // 0x0000000189C2DF28-0x0000000189C2DF38
		public static float abs(float x) => default; // 0x0000000183D782D0-0x0000000183D782E0
		public static float2 abs(float2 x) => default; // 0x0000000183D78390-0x0000000183D783C0
		public static float3 abs(float3 x) => default; // 0x0000000182EE6450-0x0000000182EE6520
		public static float4 abs(float4 x) => default; // 0x0000000189C2DEF4-0x0000000189C2DF28
		public static double abs(double x) => default; // 0x0000000183D78370-0x0000000183D78390
		public static double2 abs(double2 x) => default; // 0x0000000183D78340-0x0000000183D78370
		public static double3 abs(double3 x) => default; // 0x0000000183D78290-0x0000000183D782D0
		public static double4 abs(double4 x) => default; // 0x0000000183D782E0-0x0000000183D78340
		public static int dot(int x, int y) => default; // 0x0000000183D79CC0-0x0000000183D79CD0
		public static int dot(int2 x, int2 y) => default; // 0x0000000183D79D50-0x0000000183D79D70
		public static int dot(int3 x, int3 y) => default; // 0x0000000183D4E570-0x0000000183D4E590
		public static int dot(int4 x, int4 y) => default; // 0x0000000183D79D10-0x0000000183D79D40
		public static uint dot(uint x, uint y) => default; // 0x0000000183D79CC0-0x0000000183D79CD0
		public static uint dot(uint2 x, uint2 y) => default; // 0x0000000183D79D50-0x0000000183D79D70
		public static uint dot(uint3 x, uint3 y) => default; // 0x0000000183D4E570-0x0000000183D4E590
		public static uint dot(uint4 x, uint4 y) => default; // 0x0000000183D79D10-0x0000000183D79D40
		public static float dot(float x, float y) => default; // 0x0000000183D79D70-0x0000000183D79D80
		public static float dot(float2 x, float2 y) => default; // 0x0000000183D542E0-0x0000000183D54310
		public static float dot(float3 x, float3 y) => default; // 0x0000000183D54460-0x0000000183D54490
		public static float dot(float4 x, float4 y) => default; // 0x00000001828B5400-0x00000001828B5440
		public static double dot(double x, double y) => default; // 0x0000000183D79D40-0x0000000183D79D50
		public static double dot(double2 x, double2 y) => default; // 0x0000000183D79DB0-0x0000000183D79DD0
		public static double dot(double3 x, double3 y) => default; // 0x0000000183D79D80-0x0000000183D79DB0
		public static double dot(double4 x, double4 y) => default; // 0x0000000183D79CD0-0x0000000183D79D10
		public static float tan(float x) => default; // 0x0000000189C56194-0x0000000189C561EC
		public static float2 tan(float2 x) => default; // 0x0000000189C56020-0x0000000189C5605C
		public static float3 tan(float3 x) => default; // 0x0000000184D5B65C-0x0000000184D5B7C8
		public static float4 tan(float4 x) => default; // 0x0000000184D5B5D8-0x0000000184D5B65C
		public static double tan(double x) => default; // 0x0000000189C56144-0x0000000189C56194
		public static double2 tan(double2 x) => default; // 0x0000000184D5B3F8-0x0000000184D5B5D8
		public static double3 tan(double3 x) => default; // 0x0000000189C560E0-0x0000000189C56144
		public static double4 tan(double4 x) => default; // 0x0000000189C5605C-0x0000000189C560E0
		public static float tanh(float x) => default; // 0x0000000189C56360-0x0000000189C563B8
		public static float2 tanh(float2 x) => default; // 0x0000000189C56324-0x0000000189C56360
		public static float3 tanh(float3 x) => default; // 0x0000000184D5B8DC-0x0000000184D5B998
		public static float4 tanh(float4 x) => default; // 0x0000000184D5B7C8-0x0000000184D5B8DC
		public static double tanh(double x) => default; // 0x0000000189C562D4-0x0000000189C56324
		public static double2 tanh(double2 x) => default; // 0x0000000184D5B998-0x0000000184D5DFD0
		public static double3 tanh(double3 x) => default; // 0x0000000189C561EC-0x0000000189C56250
		public static double4 tanh(double4 x) => default; // 0x0000000189C56250-0x0000000189C562D4
		public static float atan(float x) => default; // 0x0000000189C2EAD4-0x0000000189C2EB2C
		public static float2 atan(float2 x) => default; // 0x0000000189C2EBE0-0x0000000189C2EC1C
		public static float3 atan(float3 x) => default; // 0x0000000184D2D29C-0x0000000184D2D460
		public static float4 atan(float4 x) => default; // 0x0000000184D2D218-0x0000000184D2D29C
		public static double atan(double x) => default; // 0x0000000189C2EB90-0x0000000189C2EBE0
		public static double2 atan(double2 x) => default; // 0x0000000184D2D460-0x0000000184D2D538
		public static double3 atan(double3 x) => default; // 0x0000000189C2EB2C-0x0000000189C2EB90
		public static double4 atan(double4 x) => default; // 0x0000000189C2EA50-0x0000000189C2EAD4
		public static float atan2(float y, float x) => default; // 0x0000000189C2E948-0x0000000189C2E9AC
		public static float2 atan2(float2 y, float2 x) => default; // 0x0000000189C2E8FC-0x0000000189C2E948
		public static float3 atan2(float3 y, float3 x) => default; // 0x0000000184D2CFA0-0x0000000184D2D070
		public static float4 atan2(float4 y, float4 x) => default; // 0x0000000184D2D0D0-0x0000000184D2D218
		public static double atan2(double y, double x) => default; // 0x0000000189C2E89C-0x0000000189C2E8FC
		public static double2 atan2(double2 y, double2 x) => default; // 0x0000000184D2D070-0x0000000184D2D0D0
		public static double3 atan2(double3 y, double3 x) => default; // 0x0000000189C2E81C-0x0000000189C2E89C
		public static double4 atan2(double4 y, double4 x) => default; // 0x0000000189C2E9AC-0x0000000189C2EA50
		public static float cos(float x) => default; // 0x0000000189C2FD74-0x0000000189C2FDCC
		public static float2 cos(float2 x) => default; // 0x0000000183D78DD0-0x0000000183D78E10
		public static float3 cos(float3 x) => default; // 0x0000000183D78E60-0x0000000183D78EB0
		public static float4 cos(float4 x) => default; // 0x0000000183D78F50-0x0000000183D78FB0
		public static double cos(double x) => default; // 0x0000000189C2FDCC-0x0000000189C2FE1C
		public static double2 cos(double2 x) => default; // 0x0000000183D78EB0-0x0000000183D78EF0
		public static double3 cos(double3 x) => default; // 0x0000000183D78E10-0x0000000183D78E60
		public static double4 cos(double4 x) => default; // 0x0000000183D78EF0-0x0000000183D78F50
		public static float cosh(float x) => default; // 0x0000000189C2FE1C-0x0000000189C2FE74
		public static float2 cosh(float2 x) => default; // 0x0000000183D78FB0-0x0000000183D78FF0
		public static float3 cosh(float3 x) => default; // 0x0000000183D79040-0x0000000183D79090
		public static float4 cosh(float4 x) => default; // 0x0000000183D790F0-0x0000000183D79150
		public static double cosh(double x) => default; // 0x0000000189C2FE74-0x0000000189C2FEC4
		public static double2 cosh(double2 x) => default; // 0x0000000183D79150-0x0000000183D79190
		public static double3 cosh(double3 x) => default; // 0x0000000183D78FF0-0x0000000183D79040
		public static double4 cosh(double4 x) => default; // 0x0000000183D79090-0x0000000183D790F0
		public static float acos(float x) => default; // 0x0000000189C2E090-0x0000000189C2E0E8
		public static float2 acos(float2 x) => default; // 0x0000000183D783C0-0x0000000183D78400
		public static float3 acos(float3 x) => default; // 0x0000000183D78400-0x0000000183D78450
		public static float4 acos(float4 x) => default; // 0x0000000183D784B0-0x0000000183D78510
		public static double acos(double x) => default; // 0x0000000189C2E040-0x0000000189C2E090
		public static double2 acos(double2 x) => default; // 0x0000000183D78510-0x0000000183D78550
		public static double3 acos(double3 x) => default; // 0x0000000183D78550-0x0000000183D785A0
		public static double4 acos(double4 x) => default; // 0x0000000183D78450-0x0000000183D784B0
		public static float sin(float x) => default; // 0x0000000189C54DA4-0x0000000189C54DFC
		public static float2 sin(float2 x) => default; // 0x0000000183D7CDA0-0x0000000183D7CDE0
		public static float3 sin(float3 x) => default; // 0x0000000183D7CC90-0x0000000183D7CCE0
		public static float4 sin(float4 x) => default; // 0x0000000183D7CD40-0x0000000183D7CDA0
		public static double sin(double x) => default; // 0x0000000189C54DFC-0x0000000189C54E4C
		public static double2 sin(double2 x) => default; // 0x0000000183D7CDE0-0x0000000183D7CE20
		public static double3 sin(double3 x) => default; // 0x0000000183D7CC40-0x0000000183D7CC90
		public static double4 sin(double4 x) => default; // 0x0000000183D7CCE0-0x0000000183D7CD40
		public static float sinh(float x) => default; // 0x0000000189C55144-0x0000000189C5519C
		public static float2 sinh(float2 x) => default; // 0x0000000183D7D040-0x0000000183D7D080
		public static float3 sinh(float3 x) => default; // 0x0000000183D7CEE0-0x0000000183D7CF30
		public static float4 sinh(float4 x) => default; // 0x0000000183D7CFE0-0x0000000183D7D040
		public static double sinh(double x) => default; // 0x0000000189C550F4-0x0000000189C55144
		public static double2 sinh(double2 x) => default; // 0x0000000183D7CEA0-0x0000000183D7CEE0
		public static double3 sinh(double3 x) => default; // 0x0000000183D7CF90-0x0000000183D7CFE0
		public static double4 sinh(double4 x) => default; // 0x0000000183D7CF30-0x0000000183D7CF90
		public static float asin(float x) => default; // 0x0000000189C2E7C4-0x0000000189C2E81C
		public static float2 asin(float2 x) => default; // 0x0000000183D785C0-0x0000000183D78600
		public static float3 asin(float3 x) => default; // 0x0000000183D78660-0x0000000183D786B0
		public static float4 asin(float4 x) => default; // 0x0000000183D78740-0x0000000183D787A0
		public static double asin(double x) => default; // 0x0000000189C2E774-0x0000000189C2E7C4
		public static double2 asin(double2 x) => default; // 0x0000000183D78700-0x0000000183D78740
		public static double3 asin(double3 x) => default; // 0x0000000183D786B0-0x0000000183D78700
		public static double4 asin(double4 x) => default; // 0x0000000183D78600-0x0000000183D78660
		public static float floor(float x) => default; // 0x0000000189C353A0-0x0000000189C353F8
		public static float2 floor(float2 x) => default; // 0x0000000183D7AE40-0x0000000183D7AE80
		public static float3 floor(float3 x) => default; // 0x00000001833424B0-0x0000000183342500
		public static float4 floor(float4 x) => default; // 0x0000000183D7ACF0-0x0000000183D7AD50
		public static double floor(double x) => default; // 0x0000000189C353F8-0x0000000189C35448
		public static double2 floor(double2 x) => default; // 0x0000000183D7AE00-0x0000000183D7AE40
		public static double3 floor(double3 x) => default; // 0x0000000183D7AD50-0x0000000183D7ADA0
		public static double4 floor(double4 x) => default; // 0x0000000183D7ADA0-0x0000000183D7AE00
		public static float ceil(float x) => default; // 0x0000000189C2EE18-0x0000000189C2EE70
		public static float2 ceil(float2 x) => default; // 0x0000000183D78B80-0x0000000183D78BC0
		public static float3 ceil(float3 x) => default; // 0x0000000183D78CC0-0x0000000183D78D10
		public static float4 ceil(float4 x) => default; // 0x0000000183D78C00-0x0000000183D78C60
		public static double ceil(double x) => default; // 0x0000000189C2EE70-0x0000000189C2EEC0
		public static double2 ceil(double2 x) => default; // 0x0000000183D78BC0-0x0000000183D78C00
		public static double3 ceil(double3 x) => default; // 0x0000000183D78B30-0x0000000183D78B80
		public static double4 ceil(double4 x) => default; // 0x0000000183D78C60-0x0000000183D78CC0
		public static float round(float x) => default; // 0x0000000189C52E74-0x0000000189C52ECC
		public static float2 round(float2 x) => default; // 0x0000000189C52FB4-0x0000000189C52FF0
		public static float3 round(float3 x) => default; // 0x0000000184D566C4-0x0000000184D56830
		public static float4 round(float4 x) => default; // 0x0000000184D56830-0x0000000184D568F4
		public static double round(double x) => default; // 0x0000000189C52E24-0x0000000189C52E74
		public static double2 round(double2 x) => default; // 0x0000000184D5667C-0x0000000184D566C4
		public static double3 round(double3 x) => default; // 0x0000000189C52ECC-0x0000000189C52F30
		public static double4 round(double4 x) => default; // 0x0000000189C52F30-0x0000000189C52FB4
		public static float trunc(float x) => default; // 0x0000000189C5783C-0x0000000189C57898
		public static float2 trunc(float2 x) => default; // 0x0000000189C57800-0x0000000189C5783C
		public static float3 trunc(float3 x) => default; // 0x0000000184D5E128-0x0000000184D5E210
		public static float4 trunc(float4 x) => default; // 0x0000000184D5DFD0-0x0000000184D5E128
		public static double trunc(double x) => default; // 0x0000000189C576C8-0x0000000189C57718
		public static double2 trunc(double2 x) => default; // 0x0000000184D5E210-0x0000000184D5E554
		public static double3 trunc(double3 x) => default; // 0x0000000189C57718-0x0000000189C5777C
		public static double4 trunc(double4 x) => default; // 0x0000000189C5777C-0x0000000189C57800
		public static float frac(float x) => default; // 0x0000000183D6D920-0x0000000183D6D950
		public static float2 frac(float2 x) => default; // 0x0000000189C35560-0x0000000189C35590
		public static float3 frac(float3 x) => default; // 0x0000000184D32EC4-0x0000000184D33194
		public static float4 frac(float4 x) => default; // 0x0000000189C354FC-0x0000000189C35560
		public static double frac(double x) => default; // 0x0000000183D7B290-0x0000000183D7B2C0
		public static double2 frac(double2 x) => default; // 0x0000000189C35624-0x0000000189C35688
		public static double3 frac(double3 x) => default; // 0x0000000189C35590-0x0000000189C35624
		public static double4 frac(double4 x) => default; // 0x0000000189C35688-0x0000000189C35714
		public static float rcp(float x) => default; // 0x0000000189C5128C-0x0000000189C5129C
		public static float2 rcp(float2 x) => default; // 0x0000000189C5114C-0x0000000189C51174
		public static float3 rcp(float3 x) => default; // 0x0000000189C511B8-0x0000000189C511F8
		public static float4 rcp(float4 x) => default; // 0x0000000189C51220-0x0000000189C5128C
		public static double rcp(double x) => default; // 0x0000000189C5113C-0x0000000189C5114C
		public static double2 rcp(double2 x) => default; // 0x0000000189C511F8-0x0000000189C51220
		public static double3 rcp(double3 x) => default; // 0x0000000189C51100-0x0000000189C5113C
		public static double4 rcp(double4 x) => default; // 0x0000000189C51174-0x0000000189C511B8
		public static int sign(int x) => default; // 0x0000000189C54B60-0x0000000189C54B70
		public static int2 sign(int2 x) => default; // 0x0000000189C54CA8-0x0000000189C54CDC
		public static int3 sign(int3 x) => default; // 0x0000000189C54D5C-0x0000000189C54DA4
		public static int4 sign(int4 x) => default; // 0x0000000189C54C48-0x0000000189C54CA8
		public static float sign(float x) => default; // 0x0000000184D59FAC-0x0000000184D5A674
		public static float2 sign(float2 x) => default; // 0x0000000189C54BA8-0x0000000189C54BD8
		public static float3 sign(float3 x) => default; // 0x0000000189C54D24-0x0000000189C54D5C
		public static float4 sign(float4 x) => default; // 0x0000000189C54C00-0x0000000189C54C48
		public static double sign(double x) => default; // 0x0000000184D59F74-0x0000000184D59FAC
		public static double2 sign(double2 x) => default; // 0x0000000189C54BD8-0x0000000189C54C00
		public static double3 sign(double3 x) => default; // 0x0000000189C54B70-0x0000000189C54BA8
		public static double4 sign(double4 x) => default; // 0x0000000189C54CDC-0x0000000189C54D24
		public static float pow(float x, float y) => default; // 0x0000000189C5064C-0x0000000189C506B0
		public static float2 pow(float2 x, float2 y) => default; // 0x0000000189C506B0-0x0000000189C506FC
		public static float3 pow(float3 x, float3 y) => default; // 0x0000000184D53BF4-0x0000000184D53E8C
		public static float4 pow(float4 x, float4 y) => default; // 0x0000000184D53EEC-0x0000000184D54030
		public static double pow(double x, double y) => default; // 0x0000000189C506FC-0x0000000189C5075C
		public static double2 pow(double2 x, double2 y) => default; // 0x0000000184D53E8C-0x0000000184D53EEC
		public static double3 pow(double3 x, double3 y) => default; // 0x0000000189C505CC-0x0000000189C5064C
		public static double4 pow(double4 x, double4 y) => default; // 0x0000000189C5075C-0x0000000189C50800
		public static float exp(float x) => default; // 0x0000000189C320B4-0x0000000189C3210C
		public static float2 exp(float2 x) => default; // 0x0000000183D7A580-0x0000000183D7A5C0
		public static float3 exp(float3 x) => default; // 0x0000000183D7A6B0-0x0000000183D7A700
		public static float4 exp(float4 x) => default; // 0x0000000183D7A520-0x0000000183D7A580
		public static double exp(double x) => default; // 0x0000000189C32064-0x0000000189C320B4
		public static double2 exp(double2 x) => default; // 0x0000000183D7A5C0-0x0000000183D7A600
		public static double3 exp(double3 x) => default; // 0x0000000183D7A600-0x0000000183D7A650
		public static double4 exp(double4 x) => default; // 0x0000000183D7A650-0x0000000183D7A6B0
		public static float exp2(float x) => default; // 0x0000000189C31E88-0x0000000189C31EE8
		public static float2 exp2(float2 x) => default; // 0x0000000189C32028-0x0000000189C32064
		public static float3 exp2(float3 x) => default; // 0x0000000184D30974-0x0000000184D30A90
		public static float4 exp2(float4 x) => default; // 0x0000000184D30C20-0x0000000184D30CA4
		public static double exp2(double x) => default; // 0x0000000189C31EE8-0x0000000189C31F40
		public static double2 exp2(double2 x) => default; // 0x0000000184D30A90-0x0000000184D30C20
		public static double3 exp2(double3 x) => default; // 0x0000000189C31F40-0x0000000189C31FA4
		public static double4 exp2(double4 x) => default; // 0x0000000189C31FA4-0x0000000189C32028
		public static float exp10(float x) => default; // 0x0000000189C31E28-0x0000000189C31E88
		public static float2 exp10(float2 x) => default; // 0x0000000189C31CAC-0x0000000189C31CE8
		public static float3 exp10(float3 x) => default; // 0x0000000184D30644-0x0000000184D306E8
		public static float4 exp10(float4 x) => default; // 0x0000000184D307B4-0x0000000184D30974
		public static double exp10(double x) => default; // 0x0000000189C31D6C-0x0000000189C31DC4
		public static double2 exp10(double2 x) => default; // 0x0000000184D306E8-0x0000000184D307B4
		public static double3 exp10(double3 x) => default; // 0x0000000189C31DC4-0x0000000189C31E28
		public static double4 exp10(double4 x) => default; // 0x0000000189C31CE8-0x0000000189C31D6C
		public static float log(float x) => default; // 0x0000000189C403E8-0x0000000189C40440
		public static float2 log(float2 x) => default; // 0x0000000183D7BAE0-0x0000000183D7BB20
		public static float3 log(float3 x) => default; // 0x0000000183D7BB70-0x0000000183D7BBC0
		public static float4 log(float4 x) => default; // 0x0000000183D7BA80-0x0000000183D7BAE0
		public static double log(double x) => default; // 0x0000000189C40398-0x0000000189C403E8
		public static double2 log(double2 x) => default; // 0x0000000183D7BA40-0x0000000183D7BA80
		public static double3 log(double3 x) => default; // 0x0000000183D7BB20-0x0000000183D7BB70
		public static double4 log(double4 x) => default; // 0x0000000183D7BBC0-0x0000000183D7BC20
		public static float log2(float x) => default; // 0x0000000189C401BC-0x0000000189C40218
		public static float2 log2(float2 x) => default; // 0x0000000189C40218-0x0000000189C40254
		public static float3 log2(float3 x) => default; // 0x0000000184D3C568-0x0000000184D3C5CC
		public static float4 log2(float4 x) => default; // 0x0000000184D3C5CC-0x0000000184D3C860
		public static double log2(double x) => default; // 0x0000000189C40254-0x0000000189C402B0
		public static double2 log2(double2 x) => default; // 0x0000000184D3C4C4-0x0000000184D3C568
		public static double3 log2(double3 x) => default; // 0x0000000189C402B0-0x0000000189C40314
		public static double4 log2(double4 x) => default; // 0x0000000189C40314-0x0000000189C40398
		public static float log10(float x) => default; // 0x0000000189C40114-0x0000000189C4016C
		public static float2 log10(float2 x) => default; // 0x0000000183D7B9B0-0x0000000183D7B9F0
		public static float3 log10(float3 x) => default; // 0x0000000183D7B9F0-0x0000000183D7BA40
		public static float4 log10(float4 x) => default; // 0x0000000183D7B900-0x0000000183D7B960
		public static double log10(double x) => default; // 0x0000000189C4016C-0x0000000189C401BC
		public static double2 log10(double2 x) => default; // 0x0000000183D7B860-0x0000000183D7B8A0
		public static double3 log10(double3 x) => default; // 0x0000000183D7B960-0x0000000183D7B9B0
		public static double4 log10(double4 x) => default; // 0x0000000183D7B8A0-0x0000000183D7B900
		public static float fmod(float x, float y) => default; // 0x0000000183D51650-0x0000000183D51660
		public static float2 fmod(float2 x, float2 y) => default; // 0x0000000183D7AF60-0x0000000183D7AFB0
		public static float3 fmod(float3 x, float3 y) => default; // 0x0000000183D7AE80-0x0000000183D7AEF0
		public static float4 fmod(float4 x, float4 y) => default; // 0x0000000183D7AFB0-0x0000000183D7B030
		public static double fmod(double x, double y) => default; // 0x0000000183D7B110-0x0000000183D7B120
		public static double2 fmod(double2 x, double2 y) => default; // 0x0000000183D7B0B0-0x0000000183D7B110
		public static double3 fmod(double3 x, double3 y) => default; // 0x0000000183D7AEF0-0x0000000183D7AF60
		public static double4 fmod(double4 x, double4 y) => default; // 0x0000000183D7B030-0x0000000183D7B0B0
		public static float modf(float x, out float i) {
			i = default;
			return default;
		} // 0x0000000189C4117C-0x0000000189C411A8
		public static float2 modf(float2 x, out float2 i) {
			i = default;
			return default;
		} // 0x0000000189C41034-0x0000000189C4106C
		public static float3 modf(float3 x, out float3 i) {
			i = default;
			return default;
		} // 0x0000000184D3D390-0x0000000184D536EC
		public static float4 modf(float4 x, out float4 i) {
			i = default;
			return default;
		} // 0x0000000189C40F94-0x0000000189C41008
		public static double modf(double x, out double i) {
			i = default;
			return default;
		} // 0x0000000189C41008-0x0000000189C41034
		public static double2 modf(double2 x, out double2 i) {
			i = default;
			return default;
		} // 0x0000000189C41108-0x0000000189C4117C
		public static double3 modf(double3 x, out double3 i) {
			i = default;
			return default;
		} // 0x0000000189C40EF0-0x0000000189C40F94
		public static double4 modf(double4 x, out double4 i) {
			i = default;
			return default;
		} // 0x0000000189C4106C-0x0000000189C41108
		public static float sqrt(float x) => default; // 0x0000000189C55AA4-0x0000000189C55AF4
		public static float2 sqrt(float2 x) => default; // 0x0000000183D7D080-0x0000000183D7D0F0
		public static float3 sqrt(float3 x) => default; // 0x0000000183D7D370-0x0000000183D7D410
		public static float4 sqrt(float4 x) => default; // 0x0000000183D7D0F0-0x0000000183D7D1B0
		public static double sqrt(double x) => default; // 0x0000000189C55A5C-0x0000000189C55AA4
		public static double2 sqrt(double2 x) => default; // 0x0000000183D7D1B0-0x0000000183D7D220
		public static double3 sqrt(double3 x) => default; // 0x0000000183D7D2E0-0x0000000183D7D370
		public static double4 sqrt(double4 x) => default; // 0x0000000183D7D220-0x0000000183D7D2E0
		public static float rsqrt(float x) => default; // 0x0000000189C530D8-0x0000000189C53108
		public static float2 rsqrt(float2 x) => default; // 0x0000000189C5318C-0x0000000189C531C0
		public static float3 rsqrt(float3 x) => default; // 0x0000000184D568F4-0x0000000184D56B10
		public static float4 rsqrt(float4 x) => default; // 0x0000000189C53108-0x0000000189C5318C
		public static double rsqrt(double x) => default; // 0x0000000189C531C0-0x0000000189C531F0
		public static double2 rsqrt(double2 x) => default; // 0x0000000189C531F0-0x0000000189C53238
		public static double3 rsqrt(double3 x) => default; // 0x0000000189C52FF0-0x0000000189C53068
		public static double4 rsqrt(double4 x) => default; // 0x0000000189C53068-0x0000000189C530D8
		public static float2 normalize(float2 x) => default; // 0x0000000189C4FDB0-0x0000000189C4FE18
		public static float3 normalize(float3 x) => default; // 0x0000000189C4FE18-0x0000000189C4FE8C
		public static float4 normalize(float4 x) => default; // 0x0000000189C4FCD8-0x0000000189C4FD34
		public static double2 normalize(double2 x) => default; // 0x0000000184D536EC-0x0000000184D539D4
		public static double3 normalize(double3 x) => default; // 0x0000000189C4FC58-0x0000000189C4FCD8
		public static double4 normalize(double4 x) => default; // 0x0000000189C4FD34-0x0000000189C4FDB0
		public static float2 normalizesafe(float2 x, float2 defaultvalue = default) => default; // 0x0000000189C4FF3C-0x0000000189C4FFC4
		public static float3 normalizesafe(float3 x, float3 defaultvalue = default) => default; // 0x0000000184D539D4-0x0000000184D53A74
		public static float4 normalizesafe(float4 x, float4 defaultvalue = default) => default; // 0x0000000189C4FFC4-0x0000000189C50050
		public static double2 normalizesafe(double2 x, double2 defaultvalue = default) => default; // 0x0000000184D53A74-0x0000000184D53BF4
		public static double3 normalizesafe(double3 x, double3 defaultvalue = default) => default; // 0x0000000189C50110-0x0000000189C501FC
		public static double4 normalizesafe(double4 x, double4 defaultvalue = default) => default; // 0x0000000189C4FE8C-0x0000000189C4FF3C
		public static float length(float x) => default; // 0x0000000183D782D0-0x0000000183D782E0
		public static float length(float2 x) => default; // 0x0000000183D54350-0x0000000183D54390
		public static float length(float3 x) => default; // 0x0000000189C3F9E4-0x0000000189C3FA1C
		public static float length(float4 x) => default; // 0x0000000189C3FA88-0x0000000189C3FAC4
		public static double length(double x) => default; // 0x0000000183D78370-0x0000000183D78390
		public static double length(double2 x) => default; // 0x0000000183D7B7E0-0x0000000183D7B820
		public static double length(double3 x) => default; // 0x0000000189C3FA50-0x0000000189C3FA88
		public static double length(double4 x) => default; // 0x0000000189C3FA1C-0x0000000189C3FA50
		public static float lengthsq(float x) => default; // 0x0000000183D51490-0x0000000183D514A0
		public static float lengthsq(float2 x) => default; // 0x0000000183D54330-0x0000000183D54350
		public static float lengthsq(float3 x) => default; // 0x0000000189C3FB24-0x0000000189C3FB58
		public static float lengthsq(float4 x) => default; // 0x0000000189C3FAC4-0x0000000189C3FAEC
		public static double lengthsq(double x) => default; // 0x0000000183D7B840-0x0000000183D7B850
		public static double lengthsq(double2 x) => default; // 0x0000000183D7B820-0x0000000183D7B840
		public static double lengthsq(double3 x) => default; // 0x0000000189C3FAEC-0x0000000189C3FB24
		public static double lengthsq(double4 x) => default; // 0x0000000189C3FB58-0x0000000189C3FB8C
		public static float distance(float x, float y) => default; // 0x0000000183D79C60-0x0000000183D79C80
		public static float distance(float2 x, float2 y) => default; // 0x0000000189C30834-0x0000000189C30870
		public static float distance(float3 x, float3 y) => default; // 0x0000000189C306C0-0x0000000189C30728
		public static float distance(float4 x, float4 y) => default; // 0x0000000189C30794-0x0000000189C307F4
		public static double distance(double x, double y) => default; // 0x0000000183D79C80-0x0000000183D79CA0
		public static double distance(double2 x, double2 y) => default; // 0x0000000189C307F4-0x0000000189C30834
		public static double distance(double3 x, double3 y) => default; // 0x0000000189C3064C-0x0000000189C306C0
		public static double distance(double4 x, double4 y) => default; // 0x0000000189C30728-0x0000000189C30794
		public static float distancesq(float x, float y) => default; // 0x0000000183D79CA0-0x0000000183D79CB0
		public static float distancesq(float2 x, float2 y) => default; // 0x0000000189C30870-0x0000000189C308A8
		public static float distancesq(float3 x, float3 y) => default; // 0x0000000189C309CC-0x0000000189C30A30
		public static float distancesq(float4 x, float4 y) => default; // 0x0000000189C308A8-0x0000000189C308F4
		public static double distancesq(double x, double y) => default; // 0x0000000183D79CB0-0x0000000183D79CC0
		public static double distancesq(double2 x, double2 y) => default; // 0x0000000189C30A30-0x0000000189C30A70
		public static double distancesq(double3 x, double3 y) => default; // 0x0000000189C3095C-0x0000000189C309CC
		public static double distancesq(double4 x, double4 y) => default; // 0x0000000189C308F4-0x0000000189C3095C
		public static float3 cross(float3 x, float3 y) => default; // 0x0000000189C30228-0x0000000189C30310
		public static double3 cross(double3 x, double3 y) => default; // 0x0000000189C30310-0x0000000189C30428
		public static float smoothstep(float xMin, float xMax, float x) => default; // 0x0000000189C557AC-0x0000000189C557F8
		public static float2 smoothstep(float2 xMin, float2 xMax, float2 x) => default; // 0x0000000189C557F8-0x0000000189C558C8
		public static float3 smoothstep(float3 xMin, float3 xMax, float3 x) => default; // 0x0000000184D5A674-0x0000000184D5AFFC
		public static float4 smoothstep(float4 xMin, float4 xMax, float4 x) => default; // 0x0000000189C55914-0x0000000189C55A5C
		public static double smoothstep(double xMin, double xMax, double x) => default; // 0x0000000189C558C8-0x0000000189C55914
		public static double2 smoothstep(double2 xMin, double2 xMax, double2 x) => default; // 0x0000000189C5533C-0x0000000189C5544C
		public static double3 smoothstep(double3 xMin, double3 xMax, double3 x) => default; // 0x0000000189C555EC-0x0000000189C557AC
		public static double4 smoothstep(double4 xMin, double4 xMax, double4 x) => default; // 0x0000000189C5544C-0x0000000189C555EC
		public static bool any(bool2 x) => default; // 0x0000000189C2E5F8-0x0000000189C2E608
		public static bool any(bool3 x) => default; // 0x0000000189C2E6B4-0x0000000189C2E6C8
		public static bool any(bool4 x) => default; // 0x0000000184D2CD54-0x0000000184D2CFA0
		public static bool any(int2 x) => default; // 0x0000000189C2E5E4-0x0000000189C2E5F8
		public static bool any(int3 x) => default; // 0x0000000189C2E608-0x0000000189C2E620
		public static bool any(int4 x) => default; // 0x0000000189C2E5C8-0x0000000189C2E5E4
		public static bool any(uint2 x) => default; // 0x0000000189C2E5E4-0x0000000189C2E5F8
		public static bool any(uint3 x) => default; // 0x0000000189C2E608-0x0000000189C2E620
		public static bool any(uint4 x) => default; // 0x0000000189C2E5C8-0x0000000189C2E5E4
		public static bool any(float2 x) => default; // 0x0000000189C2E6C8-0x0000000189C2E6F0
		public static bool any(float3 x) => default; // 0x0000000189C2E644-0x0000000189C2E670
		public static bool any(float4 x) => default; // 0x0000000189C2E6F0-0x0000000189C2E728
		public static bool any(double2 x) => default; // 0x0000000189C2E620-0x0000000189C2E644
		public static bool any(double3 x) => default; // 0x0000000189C2E728-0x0000000189C2E774
		public static bool any(double4 x) => default; // 0x0000000189C2E670-0x0000000189C2E6B4
		public static bool all(bool2 x) => default; // 0x0000000189C2E3B8-0x0000000189C2E3C8
		public static bool all(bool3 x) => default; // 0x0000000189C2E4E8-0x0000000189C2E4FC
		public static bool all(bool4 x) => default; // 0x0000000184D2CBB0-0x0000000184D2CBD0
		public static bool all(int2 x) => default; // 0x0000000189C2E3C8-0x0000000189C2E3DC
		public static bool all(int3 x) => default; // 0x0000000184D2CBD0-0x0000000184D2CBE8
		public static bool all(int4 x) => default; // 0x0000000189C2E46C-0x0000000189C2E488
		public static bool all(uint2 x) => default; // 0x0000000189C2E3C8-0x0000000189C2E3DC
		public static bool all(uint3 x) => default; // 0x0000000184D2CBD0-0x0000000184D2CBE8
		public static bool all(uint4 x) => default; // 0x0000000189C2E46C-0x0000000189C2E488
		public static bool all(float2 x) => default; // 0x0000000189C2E488-0x0000000189C2E4B0
		public static bool all(float3 x) => default; // 0x0000000184D2CBE8-0x0000000184D2CD54
		public static bool all(float4 x) => default; // 0x0000000189C2E4B0-0x0000000189C2E4E8
		public static bool all(double2 x) => default; // 0x0000000189C2E4FC-0x0000000189C2E520
		public static bool all(double3 x) => default; // 0x0000000189C2E420-0x0000000189C2E46C
		public static bool all(double4 x) => default; // 0x0000000189C2E3DC-0x0000000189C2E420
		public static int select(int falseValue, int trueValue, bool test) => default; // 0x0000000189C5352C-0x0000000189C53538
		public static int2 select(int2 falseValue, int2 trueValue, bool test) => default; // 0x0000000189C53544-0x0000000189C53550
		public static int3 select(int3 falseValue, int3 trueValue, bool test) => default; // 0x0000000189C53568-0x0000000189C5358C
		public static int4 select(int4 falseValue, int4 trueValue, bool test) => default; // 0x0000000189C53550-0x0000000189C53568
		public static int2 select(int2 falseValue, int2 trueValue, bool2 test) => default; // 0x0000000189C5358C-0x0000000189C535BC
		public static int3 select(int3 falseValue, int3 trueValue, bool3 test) => default; // 0x0000000184D56E84-0x0000000184D56EC4
		public static int4 select(int4 falseValue, int4 trueValue, bool4 test) => default; // 0x0000000184D56FE8-0x0000000184D57170
		public static uint select(uint falseValue, uint trueValue, bool test) => default; // 0x0000000189C5352C-0x0000000189C53538
		public static uint2 select(uint2 falseValue, uint2 trueValue, bool test) => default; // 0x0000000189C53544-0x0000000189C53550
		public static uint3 select(uint3 falseValue, uint3 trueValue, bool test) => default; // 0x0000000189C53568-0x0000000189C5358C
		public static uint4 select(uint4 falseValue, uint4 trueValue, bool test) => default; // 0x0000000189C53550-0x0000000189C53568
		public static uint2 select(uint2 falseValue, uint2 trueValue, bool2 test) => default; // 0x0000000189C5358C-0x0000000189C535BC
		public static uint3 select(uint3 falseValue, uint3 trueValue, bool3 test) => default; // 0x0000000184D56E84-0x0000000184D56EC4
		public static uint4 select(uint4 falseValue, uint4 trueValue, bool4 test) => default; // 0x0000000184D56FE8-0x0000000184D57170
		public static long select(long falseValue, long trueValue, bool test) => default; // 0x0000000189C53520-0x0000000189C5352C
		public static ulong select(ulong falseValue, ulong trueValue, bool test) => default; // 0x0000000189C53520-0x0000000189C5352C
		public static float select(float falseValue, float trueValue, bool test) => default; // 0x0000000189C53538-0x0000000189C53544
		public static float2 select(float2 falseValue, float2 trueValue, bool test) => default; // 0x0000000189C53544-0x0000000189C53550
		public static float3 select(float3 falseValue, float3 trueValue, bool test) => default; // 0x0000000189C53568-0x0000000189C5358C
		public static float4 select(float4 falseValue, float4 trueValue, bool test) => default; // 0x0000000189C53550-0x0000000189C53568
		public static float2 select(float2 falseValue, float2 trueValue, bool2 test) => default; // 0x0000000184D56EC4-0x0000000184D56F08
		public static float3 select(float3 falseValue, float3 trueValue, bool3 test) => default; // 0x0000000184D56F08-0x0000000184D56F7C
		public static float4 select(float4 falseValue, float4 trueValue, bool4 test) => default; // 0x0000000184D56F7C-0x0000000184D56FE8
		public static double select(double falseValue, double trueValue, bool test) => default; // 0x0000000189C53538-0x0000000189C53544
		public static double2 select(double2 falseValue, double2 trueValue, bool test) => default; // 0x0000000189C53550-0x0000000189C53568
		public static double3 select(double3 falseValue, double3 trueValue, bool test) => default; // 0x0000000189C536B0-0x0000000189C536D8
		public static double4 select(double4 falseValue, double4 trueValue, bool test) => default; // 0x0000000189C536D8-0x0000000189C536FC
		public static double2 select(double2 falseValue, double2 trueValue, bool2 test) => default; // 0x0000000184D56E50-0x0000000184D56E84
		public static double3 select(double3 falseValue, double3 trueValue, bool3 test) => default; // 0x0000000189C53630-0x0000000189C536B0
		public static double4 select(double4 falseValue, double4 trueValue, bool4 test) => default; // 0x0000000189C535BC-0x0000000189C53630
		public static float step(float threshold, float x) => default; // 0x0000000189C55C54-0x0000000189C55C68
		public static float2 step(float2 threshold, float2 x) => default; // 0x0000000189C55FC0-0x0000000189C56020
		public static float3 step(float3 threshold, float3 x) => default; // 0x0000000189C55E70-0x0000000189C55F1C
		public static float4 step(float4 threshold, float4 x) => default; // 0x0000000189C55C7C-0x0000000189C55D38
		public static double step(double threshold, double x) => default; // 0x0000000189C55C68-0x0000000189C55C7C
		public static double2 step(double2 threshold, double2 x) => default; // 0x0000000189C55DFC-0x0000000189C55E70
		public static double3 step(double3 threshold, double3 x) => default; // 0x0000000189C55D38-0x0000000189C55DFC
		public static double4 step(double4 threshold, double4 x) => default; // 0x0000000189C55F1C-0x0000000189C55FC0
		public static float2 reflect(float2 i, float2 n) => default; // 0x0000000189C5129C-0x0000000189C512F4
		public static float3 reflect(float3 i, float3 n) => default; // 0x0000000184D54B90-0x0000000184D55064
		public static float4 reflect(float4 i, float4 n) => default; // 0x0000000189C51548-0x0000000189C515DC
		public static double2 reflect(double2 i, double2 n) => default; // 0x0000000189C514B0-0x0000000189C51548
		public static double3 reflect(double3 i, double3 n) => default; // 0x0000000189C513CC-0x0000000189C514B0
		public static double4 reflect(double4 i, double4 n) => default; // 0x0000000189C512F4-0x0000000189C513CC
		public static float2 refract(float2 i, float2 n, float indexOfRefraction) => default; // 0x0000000189C51734-0x0000000189C51838
		public static float3 refract(float3 i, float3 n, float indexOfRefraction) => default; // 0x0000000184D55064-0x0000000184D55754
		public static float4 refract(float4 i, float4 n, float indexOfRefraction) => default; // 0x0000000189C51AFC-0x0000000189C51C18
		public static double2 refract(double2 i, double2 n, double indexOfRefraction) => default; // 0x0000000189C51838-0x0000000189C5194C
		public static double3 refract(double3 i, double3 n, double indexOfRefraction) => default; // 0x0000000189C5194C-0x0000000189C51AFC
		public static double4 refract(double4 i, double4 n, double indexOfRefraction) => default; // 0x0000000189C515DC-0x0000000189C51734
		public static float2 project(float2 a, float2 ontoB) => default; // 0x0000000189C50800-0x0000000189C5084C
		public static float3 project(float3 a, float3 ontoB) => default; // 0x0000000184D540A4-0x0000000184D54364
		public static float4 project(float4 a, float4 ontoB) => default; // 0x0000000189C50998-0x0000000189C50A08
		public static float2 projectsafe(float2 a, float2 ontoB, float2 defaultValue = default) => default; // 0x0000000189C50A70-0x0000000189C50B10
		public static float3 projectsafe(float3 a, float3 ontoB, float3 defaultValue = default) => default; // 0x0000000184D54364-0x0000000184D54B90
		public static float4 projectsafe(float4 a, float4 ontoB, float4 defaultValue = default) => default; // 0x0000000189C50A08-0x0000000189C50A70
		public static double2 project(double2 a, double2 ontoB) => default; // 0x0000000184D54030-0x0000000184D540A4
		public static double3 project(double3 a, double3 ontoB) => default; // 0x0000000189C508EC-0x0000000189C50998
		public static double4 project(double4 a, double4 ontoB) => default; // 0x0000000189C5084C-0x0000000189C508EC
		public static double2 projectsafe(double2 a, double2 ontoB, double2 defaultValue = default) => default; // 0x0000000189C50BAC-0x0000000189C50C10
		public static double3 projectsafe(double3 a, double3 ontoB, double3 defaultValue = default) => default; // 0x0000000189C50C10-0x0000000189C50CF4
		public static double4 projectsafe(double4 a, double4 ontoB, double4 defaultValue = default) => default; // 0x0000000189C50B10-0x0000000189C50BAC
		public static float2 faceforward(float2 n, float2 i, float2 ng) => default; // 0x0000000189C32F78-0x0000000189C32FD0
		public static float3 faceforward(float3 n, float3 i, float3 ng) => default; // 0x0000000184D31E3C-0x0000000184D31F5C
		public static float4 faceforward(float4 n, float4 i, float4 ng) => default; // 0x0000000189C32E9C-0x0000000189C32F04
		public static double2 faceforward(double2 n, double2 i, double2 ng) => default; // 0x0000000189C32F04-0x0000000189C32F78
		public static double3 faceforward(double3 n, double3 i, double3 ng) => default; // 0x0000000189C32FD0-0x0000000189C33094
		public static double4 faceforward(double4 n, double4 i, double4 ng) => default; // 0x0000000189C33094-0x0000000189C33128
		public static void sincos(float x, out float s, out float c) {
			s = default;
			c = default;
		} // 0x0000000183D7CE60-0x0000000183D7CEA0
		public static void sincos(float2 x, out float2 s, out float2 c) {
			s = default;
			c = default;
		} // 0x0000000189C550B0-0x0000000189C550F4
		public static void sincos(float3 x, out float3 s, out float3 c) {
			s = default;
			c = default;
		} // 0x0000000189C54ED0-0x0000000189C54F54
		public static void sincos(float4 x, out float4 s, out float4 c) {
			s = default;
			c = default;
		} // 0x0000000189C54F54-0x0000000189C54FBC
		public static void sincos(double x, out double s, out double c) {
			s = default;
			c = default;
		} // 0x0000000183D7CE20-0x0000000183D7CE60
		public static void sincos(double2 x, out double2 s, out double2 c) {
			s = default;
			c = default;
		} // 0x0000000189C54FBC-0x0000000189C55024
		public static void sincos(double3 x, out double3 s, out double3 c) {
			s = default;
			c = default;
		} // 0x0000000189C55024-0x0000000189C550B0
		public static void sincos(double4 x, out double4 s, out double4 c) {
			s = default;
			c = default;
		} // 0x0000000189C54E4C-0x0000000189C54ED0
		public static int countbits(int x) => default; // 0x0000000183D791F0-0x0000000183D79230
		public static int2 countbits(int2 x) => default; // 0x0000000189C2FEC4-0x0000000189C2FEDC
		public static int3 countbits(int3 x) => default; // 0x0000000189C301C8-0x0000000189C30228
		public static int4 countbits(int4 x) => default; // 0x0000000189C30168-0x0000000189C301C8
		public static int countbits(uint x) => default; // 0x0000000183D791F0-0x0000000183D79230
		public static int2 countbits(uint2 x) => default; // 0x0000000189C2FEDC-0x0000000189C2FFD8
		public static int3 countbits(uint3 x) => default; // 0x0000000184D2EC34-0x0000000184D2F384
		public static int4 countbits(uint4 x) => default; // 0x0000000189C2FFD8-0x0000000189C30168
		public static int countbits(ulong x) => default; // 0x0000000183D79190-0x0000000183D791F0
		public static int countbits(long x) => default; // 0x0000000183D79190-0x0000000183D791F0
		public static int lzcnt(int x) => default; // 0x0000000189C40544-0x0000000189C4054C
		public static int2 lzcnt(int2 x) => default; // 0x0000000189C40510-0x0000000189C4053C
		public static int3 lzcnt(int3 x) => default; // 0x0000000189C40440-0x0000000189C40480
		public static int4 lzcnt(int4 x) => default; // 0x0000000189C404C4-0x0000000189C40510
		public static int lzcnt(uint x) => default; // 0x0000000189C40480-0x0000000189C404C4
		public static int2 lzcnt(uint2 x) => default; // 0x0000000189C40510-0x0000000189C4053C
		public static int3 lzcnt(uint3 x) => default; // 0x0000000189C40440-0x0000000189C40480
		public static int4 lzcnt(uint4 x) => default; // 0x0000000189C404C4-0x0000000189C40510
		public static int lzcnt(long x) => default; // 0x0000000189C4053C-0x0000000189C40544
		public static int lzcnt(ulong x) => default; // 0x0000000189C4054C-0x0000000189C405A4
		public static int tzcnt(int x) => default; // 0x0000000189C579A4-0x0000000189C579AC
		public static int2 tzcnt(int2 x) => default; // 0x0000000189C57924-0x0000000189C57950
		public static int3 tzcnt(int3 x) => default; // 0x0000000189C578E0-0x0000000189C57924
		public static int4 tzcnt(int4 x) => default; // 0x0000000189C57950-0x0000000189C579A4
		public static int tzcnt(uint x) => default; // 0x0000000189C57898-0x0000000189C578E0
		public static int2 tzcnt(uint2 x) => default; // 0x0000000189C57924-0x0000000189C57950
		public static int3 tzcnt(uint3 x) => default; // 0x0000000189C578E0-0x0000000189C57924
		public static int4 tzcnt(uint4 x) => default; // 0x0000000189C57950-0x0000000189C579A4
		public static int tzcnt(long x) => default; // 0x0000000189C579AC-0x0000000189C579B4
		public static int tzcnt(ulong x) => default; // 0x0000000189C579B4-0x0000000189C57A18
		public static int reversebits(int x) => default; // 0x0000000189C52498-0x0000000189C524A0
		public static int2 reversebits(int2 x) => default; // 0x0000000189C524A0-0x0000000189C524D0
		public static int3 reversebits(int3 x) => default; // 0x0000000189C524D0-0x0000000189C52550
		public static int4 reversebits(int4 x) => default; // 0x0000000189C52270-0x0000000189C522E4
		public static uint reversebits(uint x) => default; // 0x0000000183D7CB90-0x0000000183D7CBD0
		public static uint2 reversebits(uint2 x) => default; // 0x0000000189C522E4-0x0000000189C52490
		public static uint3 reversebits(uint3 x) => default; // 0x0000000184D55AD0-0x0000000184D5607C
		public static uint4 reversebits(uint4 x) => default; // 0x0000000189C51FB8-0x0000000189C52270
		public static long reversebits(long x) => default; // 0x0000000189C52490-0x0000000189C52498
		public static ulong reversebits(ulong x) => default; // 0x0000000183D7CBD0-0x0000000183D7CC30
		public static int rol(int x, int n) => default; // 0x0000000183D50D20-0x0000000183D50D40
		public static int2 rol(int2 x, int n) => default; // 0x0000000189C526F0-0x0000000189C52760
		public static int3 rol(int3 x, int n) => default; // 0x0000000189C52584-0x0000000189C52604
		public static int4 rol(int4 x, int n) => default; // 0x0000000189C52604-0x0000000189C52678
		public static uint rol(uint x, int n) => default; // 0x0000000183D50D20-0x0000000183D50D40
		public static uint2 rol(uint2 x, int n) => default; // 0x0000000189C52550-0x0000000189C52584
		public static uint3 rol(uint3 x, int n) => default; // 0x0000000184D5607C-0x0000000184D56110
		public static uint4 rol(uint4 x, int n) => default; // 0x0000000189C52678-0x0000000189C526F0
		public static long rol(long x, int n) => default; // 0x0000000183D76910-0x0000000183D76930
		public static ulong rol(ulong x, int n) => default; // 0x0000000183D76910-0x0000000183D76930
		public static int ror(int x, int n) => default; // 0x0000000183D6ED80-0x0000000183D6EDA0
		public static int2 ror(int2 x, int n) => default; // 0x0000000189C52808-0x0000000189C52878
		public static int3 ror(int3 x, int n) => default; // 0x0000000189C52878-0x0000000189C528F8
		public static int4 ror(int4 x, int n) => default; // 0x0000000189C52794-0x0000000189C52808
		public static uint ror(uint x, int n) => default; // 0x0000000183D6ED80-0x0000000183D6EDA0
		public static uint2 ror(uint2 x, int n) => default; // 0x0000000189C52760-0x0000000189C52794
		public static uint3 ror(uint3 x, int n) => default; // 0x0000000184D56110-0x0000000184D5667C
		public static uint4 ror(uint4 x, int n) => default; // 0x0000000189C528F8-0x0000000189C52970
		public static long ror(long x, int n) => default; // 0x0000000183D6EDD0-0x0000000183D6EDF0
		public static ulong ror(ulong x, int n) => default; // 0x0000000183D6EDD0-0x0000000183D6EDF0
		public static int ceilpow2(int x) => default; // 0x00000001829CE000-0x00000001829CE030
		public static int2 ceilpow2(int2 x) => default; // 0x0000000189C2EF6C-0x0000000189C2F024
		public static int3 ceilpow2(int3 x) => default; // 0x0000000184D2DC58-0x0000000184D2E18C
		public static int4 ceilpow2(int4 x) => default; // 0x0000000189C2F26C-0x0000000189C2F3FC
		public static uint ceilpow2(uint x) => default; // 0x0000000183D520C0-0x0000000183D520F0
		public static uint2 ceilpow2(uint2 x) => default; // 0x0000000189C2F1B4-0x0000000189C2F26C
		public static uint3 ceilpow2(uint3 x) => default; // 0x0000000184D2DA44-0x0000000184D2DC58
		public static uint4 ceilpow2(uint4 x) => default; // 0x0000000189C2F024-0x0000000189C2F1B4
		public static long ceilpow2(long x) => default; // 0x0000000183D78D60-0x0000000183D78DB0
		public static ulong ceilpow2(ulong x) => default; // 0x0000000183D78D10-0x0000000183D78D60
		public static int ceillog2(int x) => default; // 0x0000000184D2DA28-0x0000000184D2DA44
		public static int2 ceillog2(int2 x) => default; // 0x0000000189C2EF40-0x0000000189C2EF6C
		public static int3 ceillog2(int3 x) => default; // 0x0000000189C2EEC0-0x0000000189C2EEF8
		public static int4 ceillog2(int4 x) => default; // 0x0000000189C2EEF8-0x0000000189C2EF40
		public static int ceillog2(uint x) => default; // 0x0000000184D2DA28-0x0000000184D2DA44
		public static int2 ceillog2(uint2 x) => default; // 0x0000000189C2EF40-0x0000000189C2EF6C
		public static int3 ceillog2(uint3 x) => default; // 0x0000000189C2EEC0-0x0000000189C2EEF8
		public static int4 ceillog2(uint4 x) => default; // 0x0000000189C2EEF8-0x0000000189C2EF40
		public static int floorlog2(int x) => default; // 0x0000000184D32A74-0x0000000184D32EC4
		public static int2 floorlog2(int2 x) => default; // 0x0000000189C354C8-0x0000000189C354FC
		public static int3 floorlog2(int3 x) => default; // 0x0000000189C35490-0x0000000189C354C8
		public static int4 floorlog2(int4 x) => default; // 0x0000000189C35448-0x0000000189C35490
		public static int floorlog2(uint x) => default; // 0x0000000184D32A74-0x0000000184D32EC4
		public static int2 floorlog2(uint2 x) => default; // 0x0000000189C354C8-0x0000000189C354FC
		public static int3 floorlog2(uint3 x) => default; // 0x0000000189C35490-0x0000000189C354C8
		public static int4 floorlog2(uint4 x) => default; // 0x0000000189C35448-0x0000000189C35490
		public static float radians(float x) => default; // 0x0000000183D7CB70-0x0000000183D7CB80
		public static float2 radians(float2 x) => default; // 0x0000000189C51024-0x0000000189C51034
		public static float3 radians(float3 x) => default; // 0x000000018427033C-0x0000000184270384
		public static float4 radians(float4 x) => default; // 0x0000000189C50FEC-0x0000000189C51024
		public static double radians(double x) => default; // 0x0000000183D7CB80-0x0000000183D7CB90
		public static double2 radians(double2 x) => default; // 0x0000000189C51034-0x0000000189C5106C
		public static double3 radians(double3 x) => default; // 0x0000000189C5106C-0x0000000189C510B8
		public static double4 radians(double4 x) => default; // 0x0000000189C510B8-0x0000000189C51100
		public static float degrees(float x) => default; // 0x0000000183D792E0-0x0000000183D792F0
		public static float2 degrees(float2 x) => default; // 0x0000000189C305CC-0x0000000189C305DC
		public static float3 degrees(float3 x) => default; // 0x0000000184D2F384-0x0000000184D2F8D4
		public static float4 degrees(float4 x) => default; // 0x0000000189C305DC-0x0000000189C30614
		public static double degrees(double x) => default; // 0x0000000183D792F0-0x0000000183D79300
		public static double2 degrees(double2 x) => default; // 0x0000000189C30614-0x0000000189C3064C
		public static double3 degrees(double3 x) => default; // 0x0000000189C30538-0x0000000189C30584
		public static double4 degrees(double4 x) => default; // 0x0000000189C30584-0x0000000189C305CC
		public static int cmin(int2 x) => default; // 0x0000000189C2FCB8-0x0000000189C2FCCC
		public static int cmin(int3 x) => default; // 0x0000000189C2FB90-0x0000000189C2FBA4
		public static int cmin(int4 x) => default; // 0x0000000189C2FC10-0x0000000189C2FC2C
		public static uint cmin(uint2 x) => default; // 0x0000000189C2FC4C-0x0000000189C2FC60
		public static uint cmin(uint3 x) => default; // 0x0000000189C2FD04-0x0000000189C2FD18
		public static uint cmin(uint4 x) => default; // 0x0000000189C2FBA4-0x0000000189C2FBC0
		public static float cmin(float2 x) => default; // 0x0000000189C2FC94-0x0000000189C2FCB8
		public static float cmin(float3 x) => default; // 0x0000000189C2FC60-0x0000000189C2FC94
		public static float cmin(float4 x) => default; // 0x0000000184D2E958-0x0000000184D2EC34
		public static double cmin(double2 x) => default; // 0x0000000189C2FC2C-0x0000000189C2FC4C
		public static double cmin(double3 x) => default; // 0x0000000189C2FCCC-0x0000000189C2FD04
		public static double cmin(double4 x) => default; // 0x0000000189C2FBC0-0x0000000189C2FC10
		public static int cmax(int2 x) => default; // 0x0000000189C2FB10-0x0000000189C2FB24
		public static int cmax(int3 x) => default; // 0x0000000189C2FB44-0x0000000189C2FB58
		public static int cmax(int4 x) => default; // 0x0000000189C2FA74-0x0000000189C2FA90
		public static uint cmax(uint2 x) => default; // 0x0000000189C2FA3C-0x0000000189C2FA50
		public static uint cmax(uint3 x) => default; // 0x0000000189C2FAFC-0x0000000189C2FB10
		public static uint cmax(uint4 x) => default; // 0x0000000189C2FA90-0x0000000189C2FAAC
		public static float cmax(float2 x) => default; // 0x0000000189C2FA50-0x0000000189C2FA74
		public static float cmax(float3 x) => default; // 0x0000000189C2FA08-0x0000000189C2FA3C
		public static float cmax(float4 x) => default; // 0x0000000184D2E7E8-0x0000000184D2E958
		public static double cmax(double2 x) => default; // 0x0000000189C2FB24-0x0000000189C2FB44
		public static double cmax(double3 x) => default; // 0x0000000189C2FB58-0x0000000189C2FB90
		public static double cmax(double4 x) => default; // 0x0000000189C2FAAC-0x0000000189C2FAFC
		public static int csum(int2 x) => default; // 0x0000000183D79250-0x0000000183D79260
		public static int csum(int3 x) => default; // 0x0000000183D792A0-0x0000000183D792B0
		public static int csum(int4 x) => default; // 0x0000000183D55680-0x0000000183D55690
		public static uint csum(uint2 x) => default; // 0x0000000183D79250-0x0000000183D79260
		public static uint csum(uint3 x) => default; // 0x0000000183D792A0-0x0000000183D792B0
		public static uint csum(uint4 x) => default; // 0x0000000183D55680-0x0000000183D55690
		public static float csum(float2 x) => default; // 0x0000000183D792B0-0x0000000183D792D0
		public static float csum(float3 x) => default; // 0x0000000183D792D0-0x0000000183D792E0
		public static float csum(float4 x) => default; // 0x0000000183D79230-0x0000000183D79250
		public static double csum(double2 x) => default; // 0x0000000183D79270-0x0000000183D79280
		public static double csum(double3 x) => default; // 0x0000000183D79260-0x0000000183D79270
		public static double csum(double4 x) => default; // 0x0000000183D79280-0x0000000183D792A0
		public static float square(float x) => default; // 0x0000000183D51490-0x0000000183D514A0
		public static float2 square(float2 x) => default; // 0x0000000189C55C4C-0x0000000189C55C54
		public static float3 square(float3 x) => default; // 0x0000000184D5AFFC-0x0000000184D5B04C
		public static float4 square(float4 x) => default; // 0x0000000189C55B7C-0x0000000189C55BB4
		public static double square(double x) => default; // 0x0000000183D7B840-0x0000000183D7B850
		public static double2 square(double2 x) => default; // 0x0000000189C55B44-0x0000000189C55B7C
		public static double3 square(double3 x) => default; // 0x0000000189C55BBC-0x0000000189C55C14
		public static double4 square(double4 x) => default; // 0x0000000189C55AF4-0x0000000189C55B44
		public static int square(int x) => default; // 0x0000000183D7D410-0x0000000183D7D420
		public static int2 square(int2 x) => default; // 0x0000000189C55BB4-0x0000000189C55BBC
		public static int3 square(int3 x) => default; // 0x0000000184D5B04C-0x0000000184D5B3F8
		public static int4 square(int4 x) => default; // 0x0000000189C55C14-0x0000000189C55C4C
		public static uint square(uint x) => default; // 0x0000000183D7D410-0x0000000183D7D420
		public static uint2 square(uint2 x) => default; // 0x0000000189C55BB4-0x0000000189C55BBC
		public static uint3 square(uint3 x) => default; // 0x0000000184D5B04C-0x0000000184D5B3F8
		public static uint4 square(uint4 x) => default; // 0x0000000189C55C14-0x0000000189C55C4C
		public static unsafe int compress(int* output, int index, int4 val, bool4 mask) => default; // 0x0000000189C2C4B4-0x0000000189C2C654
		public static unsafe int compress(uint* output, int index, uint4 val, bool4 mask) => default; // 0x0000000189C2FD18-0x0000000189C2FD34
		public static unsafe int compress(float* output, int index, float4 val, bool4 mask) => default; // 0x0000000189C2FD18-0x0000000189C2FD34
		public static float f16tof32(uint x) => default; // 0x0000000184D30EF4-0x0000000184D31E3C
		public static float2 f16tof32(uint2 x) => default; // 0x0000000189C323D0-0x0000000189C32524
		public static float3 f16tof32(uint3 x) => default; // 0x0000000189C3210C-0x0000000189C323D0
		public static float4 f16tof32(uint4 x) => default; // 0x0000000189C32524-0x0000000189C32750
		public static uint f32tof16(float x) => default; // 0x0000000189C32BD4-0x0000000189C32C30
		public static uint2 f32tof16(float2 x) => default; // 0x0000000189C32750-0x0000000189C328DC
		public static uint3 f32tof16(float3 x) => default; // 0x0000000189C328DC-0x0000000189C32BD4
		public static uint4 f32tof16(float4 x) => default; // 0x0000000189C32C30-0x0000000189C32E9C
		public static void orthonormal_basis(float3 normal, out float3 basis1, out float3 basis2) {
			basis1 = default;
			basis2 = default;
		} // 0x0000000189C501FC-0x0000000189C502A0
		public static void orthonormal_basis(double3 normal, out double3 basis1, out double3 basis2) {
			basis1 = default;
			basis2 = default;
		} // 0x0000000189C502A0-0x0000000189C50374
		public static float chgsign(float x, float y) => default; // 0x0000000183D78DB0-0x0000000183D78DD0
		public static float2 chgsign(float2 x, float2 y) => default; // 0x0000000189C2F3FC-0x0000000189C2F440
		public static float3 chgsign(float3 x, float3 y) => default; // 0x0000000184D2E18C-0x0000000184D2E358
		public static float4 chgsign(float4 x, float4 y) => default; // 0x0000000189C2F440-0x0000000189C2F4A0
		private static unsafe uint read32_little_endian(void* pBuffer) => default; // 0x0000000183D6EF00-0x0000000183D6EF20
		private static unsafe uint hash_with_unaligned_loads(void* pBuffer, int numBytes, uint seed) => default; // 0x0000000189C389B8-0x0000000189C38BD4
		private static unsafe uint hash_without_unaligned_loads(void* pBuffer, int numBytes, uint seed) => default; // 0x0000000189C38BD4-0x0000000189C38E74
		public static unsafe uint hash(void* pBuffer, int numBytes, uint seed = 0 /* Metadata: 0x01FD6040 */) => default; // 0x0000000189C37850-0x0000000189C37858
		public static float3 up() => default; // 0x0000000183D7D420-0x0000000183D7D430
		public static float3 down() => default; // 0x0000000183D7A500-0x0000000183D7A520
		public static float3 forward() => default; // 0x0000000183D7B280-0x0000000183D7B290
		public static float3 back() => default; // 0x0000000183D787B0-0x0000000183D787C0
		public static float3 left() => default; // 0x0000000183D7B7D0-0x0000000183D7B7E0
		public static float3 right() => default; // 0x0000000183D7CC30-0x0000000183D7CC40
		public static float3 EulerXYZ(quaternion q) => default; // 0x0000000189C2C920-0x0000000189C2CCA4
		public static float3 EulerXZY(quaternion q) => default; // 0x0000000189C2CCA4-0x0000000189C2CFFC
		public static float3 EulerYXZ(quaternion q) => default; // 0x0000000189C2CFFC-0x0000000189C2D350
		public static float3 EulerYZX(quaternion q) => default; // 0x0000000189C2D350-0x0000000189C2D68C
		public static float3 EulerZXY(quaternion q) => default; // 0x0000000189C2D68C-0x0000000189C2D9C4
		public static float3 EulerZYX(quaternion q) => default; // 0x0000000189C2D9C4-0x0000000189C2DD1C
		public static float3 Euler(quaternion q, RotationOrder order = RotationOrder.ZXY /* Metadata: 0x01FD6041 */) => default; // 0x0000000189C2DD1C-0x0000000189C2DE48
		public static float3x3 mulScale(float3x3 m, float3 s) => default; // 0x0000000189C41318-0x0000000189C413E0
		public static float3x3 scaleMul(float3 s, float3x3 m) => default; // 0x0000000189C53428-0x0000000189C53520
		internal static float4 unpacklo(float4 a, float4 b) => default; // 0x0000000189C58884-0x0000000189C588D0
		internal static double4 unpacklo(double4 a, double4 b) => default; // 0x0000000189C588D0-0x0000000189C58FAC
		internal static float4 unpackhi(float4 a, float4 b) => default; // 0x0000000189C2C654-0x0000000189C2C758
		internal static double4 unpackhi(double4 a, double4 b) => default; // 0x0000000189C58818-0x0000000189C58884
		internal static float4 movelh(float4 a, float4 b) => default; // 0x0000000189C41260-0x0000000189C412AC
		internal static double4 movelh(double4 a, double4 b) => default; // 0x0000000189C412AC-0x0000000189C41318
		internal static float4 movehl(float4 a, float4 b) => default; // 0x0000000189C411A8-0x0000000189C411F4
		internal static double4 movehl(double4 a, double4 b) => default; // 0x0000000189C411F4-0x0000000189C41260
		internal static uint fold_to_uint(double x) => default; // 0x0000000183D7B260-0x0000000183D7B280
		internal static uint2 fold_to_uint(double2 x) => default; // 0x0000000183D7B120-0x0000000183D7B160
		internal static uint3 fold_to_uint(double3 x) => default; // 0x0000000183D7B1F0-0x0000000183D7B260
		internal static uint4 fold_to_uint(double4 x) => default; // 0x0000000183D7B160-0x0000000183D7B1F0
		public static float3x3 float3x3(float4x4 f4x4) => default; // 0x0000000189C345B8-0x0000000189C3460C
		public static float3x3 float3x3(quaternion rotation) => default; // 0x0000000189C3462C-0x0000000189C34664
		public static float4x4 float4x4(float3x3 rotation, float3 translation) => default; // 0x0000000189C35244-0x0000000189C352B8
		public static float4x4 float4x4(quaternion rotation, float3 translation) => default; // 0x0000000189C35300-0x0000000189C35368
		public static float4x4 float4x4(RigidTransform transform) => default; // 0x0000000189C3500C-0x0000000189C35060
		public static float3x3 orthonormalize(float3x3 i) => default; // 0x0000000189C50374-0x0000000189C505CC
		public static float3x3 pseudoinverse(float3x3 m) => default; // 0x0000000189C50CF4-0x0000000189C50F64
		public static float mul(float a, float b) => default; // 0x0000000183D79D70-0x0000000183D79D80
		public static float mul(float2 a, float2 b) => default; // 0x0000000183D542E0-0x0000000183D54310
		public static float2 mul(float2 a, float2x2 b) => default; // 0x0000000183D7C0C0-0x0000000183D7C100
		public static float3 mul(float2 a, float2x3 b) => default; // 0x0000000183D7C7C0-0x0000000183D7C820
		public static float4 mul(float2 a, float2x4 b) => default; // 0x0000000183D7C860-0x0000000183D7C8F0
		public static float mul(float3 a, float3 b) => default; // 0x0000000183D54460-0x0000000183D54490
		public static float2 mul(float3 a, float3x2 b) => default; // 0x0000000183D7C250-0x0000000183D7C2B0
		public static float3 mul(float3 a, float3x3 b) => default; // 0x0000000183D7C1C0-0x0000000183D7C250
		public static float4 mul(float3 a, float3x4 b) => default; // 0x0000000183D7C5F0-0x0000000183D7C6C0
		public static float mul(float4 a, float4 b) => default; // 0x00000001828B5400-0x00000001828B5440
		public static float2 mul(float4 a, float4x2 b) => default; // 0x0000000183D7C750-0x0000000183D7C7C0
		public static float3 mul(float4 a, float4x3 b) => default; // 0x0000000183D7BD20-0x0000000183D7BDE0
		public static float4 mul(float4 a, float4x4 b) => default; // 0x0000000183D7C970-0x0000000183D7CA80
		public static float2 mul(float2x2 a, float2 b) => default; // 0x0000000189C429C4-0x0000000189C42A14
		public static float2x2 mul(float2x2 a, float2x2 b) => default; // 0x0000000189C4BECC-0x0000000189C4BFA0
		public static float2x3 mul(float2x2 a, float2x3 b) => default; // 0x0000000189C4CCD8-0x0000000189C4CE04
		public static float2x4 mul(float2x2 a, float2x4 b) => default; // 0x0000000189C413E0-0x0000000189C41564
		public static float2 mul(float2x3 a, float3 b) => default; // 0x0000000189C43580-0x0000000189C435FC
		public static float2x2 mul(float2x3 a, float3x2 b) => default; // 0x0000000189C43C1C-0x0000000189C43D50
		public static float2x3 mul(float2x3 a, float3x3 b) => default; // 0x0000000189C4A1BC-0x0000000189C4A378
		public static float2x4 mul(float2x3 a, float3x4 b) => default; // 0x0000000189C425A4-0x0000000189C427EC
		public static float2 mul(float2x4 a, float4 b) => default; // 0x0000000189C4B704-0x0000000189C4B7B0
		public static float2x2 mul(float2x4 a, float4x2 b) => default; // 0x0000000189C41564-0x0000000189C416FC
		public static float2x3 mul(float2x4 a, float4x3 b) => default; // 0x0000000189C49E88-0x0000000189C4A0D8
		public static float2x4 mul(float2x4 a, float4x4 b) => default; // 0x0000000189C4A6BC-0x0000000189C4A9C8
		public static float3 mul(float3x2 a, float2 b) => default; // 0x0000000189C44EA4-0x0000000189C44F40
		public static float3x2 mul(float3x2 a, float2x2 b) => default; // 0x0000000189C4BB2C-0x0000000189C4BC78
		public static float3x3 mul(float3x2 a, float2x3 b) => default; // 0x0000000189C4EE48-0x0000000189C4F024
		public static float3x4 mul(float3x2 a, float2x4 b) => default; // 0x0000000189C416FC-0x0000000189C4196C
		public static float3 mul(float3x3 a, float3 b) => default; // 0x0000000189C4595C-0x0000000189C45A4C
		public static float3x2 mul(float3x3 a, float3x2 b) => default; // 0x0000000189C4D7FC-0x0000000189C4D9F8
		public static float3x3 mul(float3x3 a, float3x3 b) => default; // 0x0000000189C41D38-0x0000000189C42014
		public static float3x4 mul(float3x3 a, float3x4 b) => default; // 0x0000000189C4870C-0x0000000189C48AD0
		public static float3 mul(float3x4 a, float4 b) => default; // 0x0000000189C47EBC-0x0000000189C48004
		public static float3x2 mul(float3x4 a, float4x2 b) => default; // 0x0000000189C4EA2C-0x0000000189C4ECD0
		public static float3x3 mul(float3x4 a, float4x3 b) => default; // 0x0000000189C47800-0x0000000189C47BD8
		public static float3x4 mul(float3x4 a, float4x4 b) => default; // 0x0000000189C42C28-0x0000000189C431B4
		public static float4 mul(float4x2 a, float2 b) => default; // 0x0000000189C494D0-0x0000000189C49550
		public static float4x2 mul(float4x2 a, float2x2 b) => default; // 0x0000000189C4A0D8-0x0000000189C4A1BC
		public static float4x3 mul(float4x2 a, float2x3 b) => default; // 0x0000000189C46C88-0x0000000189C46DFC
		public static float4x4 mul(float4x2 a, float2x4 b) => default; // 0x0000000189C48C34-0x0000000189C48E1C
		public static float4 mul(float4x3 a, float3 b) => default; // 0x0000000189C4C380-0x0000000189C4C438
		public static float4x2 mul(float4x3 a, float3x2 b) => default; // 0x0000000189C4C4EC-0x0000000189C4C654
		public static float4x3 mul(float4x3 a, float3x3 b) => default; // 0x0000000189C4B1EC-0x0000000189C4B41C
		public static float4x4 mul(float4x3 a, float3x4 b) => default; // 0x0000000189C4C9B8-0x0000000189C4CCD8
		public static float4 mul(float4x4 a, float4 b) => default; // 0x0000000189C4196C-0x0000000189C41A64
		public static float4x2 mul(float4x4 a, float4x2 b) => default; // 0x0000000189C44414-0x0000000189C445F8
		public static float4x3 mul(float4x4 a, float4x3 b) => default; // 0x0000000189C4B41C-0x0000000189C4B704
		public static float4x4 mul(float4x4 a, float4x4 b) => default; // 0x0000000189C4F024-0x0000000189C4F454
		public static double mul(double a, double b) => default; // 0x0000000183D79D40-0x0000000183D79D50
		public static double mul(double2 a, double2 b) => default; // 0x0000000183D79DB0-0x0000000183D79DD0
		public static double2 mul(double2 a, double2x2 b) => default; // 0x0000000183D7C820-0x0000000183D7C860
		public static double3 mul(double2 a, double2x3 b) => default; // 0x0000000183D7C2B0-0x0000000183D7C320
		public static double4 mul(double2 a, double2x4 b) => default; // 0x0000000183D7C380-0x0000000183D7C400
		public static double mul(double3 a, double3 b) => default; // 0x0000000183D79D80-0x0000000183D79DB0
		public static double2 mul(double3 a, double3x2 b) => default; // 0x0000000183D7C320-0x0000000183D7C380
		public static double3 mul(double3 a, double3x3 b) => default; // 0x0000000183D7C400-0x0000000183D7C490
		public static double4 mul(double3 a, double3x4 b) => default; // 0x0000000183D7C100-0x0000000183D7C1C0
		public static double mul(double4 a, double4 b) => default; // 0x0000000183D79CD0-0x0000000183D79D10
		public static double2 mul(double4 a, double4x2 b) => default; // 0x0000000183D7C490-0x0000000183D7C510
		public static double3 mul(double4 a, double4x3 b) => default; // 0x0000000183D7BE80-0x0000000183D7BF40
		public static double4 mul(double4 a, double4x4 b) => default; // 0x0000000183D7CA80-0x0000000183D7CB70
		public static double2 mul(double2x2 a, double2 b) => default; // 0x0000000189C49660-0x0000000189C496D8
		public static double2x2 mul(double2x2 a, double2x2 b) => default; // 0x0000000189C48004-0x0000000189C480E0
		public static double2x3 mul(double2x2 a, double2x3 b) => default; // 0x0000000189C4A378-0x0000000189C4A4EC
		public static double2x4 mul(double2x2 a, double2x4 b) => default; // 0x0000000189C49A84-0x0000000189C49C6C
		public static double2 mul(double2x3 a, double3 b) => default; // 0x0000000189C41A64-0x0000000189C41B1C
		public static double2x2 mul(double2x3 a, double3x2 b) => default; // 0x0000000189C48AD0-0x0000000189C48C34
		public static double2x3 mul(double2x3 a, double3x3 b) => default; // 0x0000000189C4D214-0x0000000189C4D444
		public static double2x4 mul(double2x3 a, double3x4 b) => default; // 0x0000000189C4AC48-0x0000000189C4AF68
		public static double2 mul(double2x4 a, double4 b) => default; // 0x0000000189C4E18C-0x0000000189C4E284
		public static double2x2 mul(double2x4 a, double4x2 b) => default; // 0x0000000189C433A0-0x0000000189C43580
		public static double2x3 mul(double2x4 a, double4x3 b) => default; // 0x0000000189C4D514-0x0000000189C4D7FC
		public static double2x4 mul(double2x4 a, double4x4 b) => default; // 0x0000000189C437EC-0x0000000189C43C1C
		public static double3 mul(double3x2 a, double2 b) => default; // 0x0000000189C48488-0x0000000189C4853C
		public static double3x2 mul(double3x2 a, double2x2 b) => default; // 0x0000000189C4ECD0-0x0000000189C4EE48
		public static double3x3 mul(double3x2 a, double2x3 b) => default; // 0x0000000189C44AAC-0x0000000189C44D18
		public static double3x4 mul(double3x2 a, double2x4 b) => default; // 0x0000000189C4F540-0x0000000189C4F868
		public static double3 mul(double3x3 a, double3 b) => default; // 0x0000000189C4C26C-0x0000000189C4C380
		public static double3x2 mul(double3x3 a, double3x2 b) => default; // 0x0000000189C44F40-0x0000000189C45178
		public static double3x3 mul(double3x3 a, double3x3 b) => default; // 0x0000000189C480E0-0x0000000189C48488
		public static double3x4 mul(double3x3 a, double3x4 b) => default; // 0x0000000189C445F8-0x0000000189C44AAC
		public static double3 mul(double3x4 a, double4 b) => default; // 0x0000000189C4649C-0x0000000189C46610
		public static double3x2 mul(double3x4 a, double4x2 b) => default; // 0x0000000189C48E1C-0x0000000189C49110
		public static double3x3 mul(double3x4 a, double4x3 b) => default; // 0x0000000189C4DB64-0x0000000189C4E044
		public static double3x4 mul(double3x4 a, double4x4 b) => default; // 0x0000000189C4E3E0-0x0000000189C4EA2C
		public static double4 mul(double4x2 a, double2 b) => default; // 0x0000000189C4ABA0-0x0000000189C4AC48
		public static double4x2 mul(double4x2 a, double2x2 b) => default; // 0x0000000189C4D9F8-0x0000000189C4DB64
		public static double4x3 mul(double4x2 a, double2x3 b) => default; // 0x0000000189C4BC78-0x0000000189C4BECC
		public static double4x4 mul(double4x2 a, double2x4 b) => default; // 0x0000000189C4F868-0x0000000189C4FB78
		public static double4 mul(double4x3 a, double3 b) => default; // 0x0000000189C47BD8-0x0000000189C47CDC
		public static double4x2 mul(double4x3 a, double3x2 b) => default; // 0x0000000189C49C6C-0x0000000189C49E88
		public static double4x3 mul(double4x3 a, double3x3 b) => default; // 0x0000000189C4B7B0-0x0000000189C4BB2C
		public static double4x4 mul(double4x3 a, double3x4 b) => default; // 0x0000000189C45440-0x0000000189C458C4
		public static double4 mul(double4x4 a, double4 b) => default; // 0x0000000189C427EC-0x0000000189C4294C
		public static double4x2 mul(double4x4 a, double4x2 b) => default; // 0x0000000189C497B4-0x0000000189C49A84
		public static double4x3 mul(double4x4 a, double4x3 b) => default; // 0x0000000189C46610-0x0000000189C46AB4
		public static double4x4 mul(double4x4 a, double4x4 b) => default; // 0x0000000189C45D90-0x0000000189C46394
		public static int mul(int a, int b) => default; // 0x0000000183D79CC0-0x0000000183D79CD0
		public static int mul(int2 a, int2 b) => default; // 0x0000000183D79D50-0x0000000183D79D70
		public static int2 mul(int2 a, int2x2 b) => default; // 0x0000000183D7C6C0-0x0000000183D7C700
		public static int3 mul(int2 a, int2x3 b) => default; // 0x0000000183D7C060-0x0000000183D7C0C0
		public static int4 mul(int2 a, int2x4 b) => default; // 0x0000000183D7C510-0x0000000183D7C590
		public static int mul(int3 a, int3 b) => default; // 0x0000000183D4E570-0x0000000183D4E590
		public static int2 mul(int3 a, int3x2 b) => default; // 0x0000000183D7C700-0x0000000183D7C750
		public static int3 mul(int3 a, int3x3 b) => default; // 0x0000000183D7BF40-0x0000000183D7BFC0
		public static int4 mul(int3 a, int3x4 b) => default; // 0x0000000183D7BFC0-0x0000000183D7C060
		public static int mul(int4 a, int4 b) => default; // 0x0000000183D79D10-0x0000000183D79D40
		public static int2 mul(int4 a, int4x2 b) => default; // 0x0000000183D7C590-0x0000000183D7C5F0
		public static int3 mul(int4 a, int4x3 b) => default; // 0x0000000183D7BDE0-0x0000000183D7BE80
		public static int4 mul(int4 a, int4x4 b) => default; // 0x0000000183D7BC60-0x0000000183D7BD20
		public static int2 mul(int2x2 a, int2 b) => default; // 0x0000000189C45A4C-0x0000000189C45A94
		public static int2x2 mul(int2x2 a, int2x2 b) => default; // 0x0000000189C4C438-0x0000000189C4C4EC
		public static int2x3 mul(int2x2 a, int2x3 b) => default; // 0x0000000189C46394-0x0000000189C4649C
		public static int2x4 mul(int2x2 a, int2x4 b) => default; // 0x0000000189C42014-0x0000000189C42180
		public static int2 mul(int2x3 a, int3 b) => default; // 0x0000000189C47CDC-0x0000000189C47D58
		public static int2x2 mul(int2x3 a, int3x2 b) => default; // 0x0000000189C49550-0x0000000189C49660
		public static int2x3 mul(int2x3 a, int3x3 b) => default; // 0x0000000189C45A94-0x0000000189C45C2C
		public static int2x4 mul(int2x3 a, int3x4 b) => default; // 0x0000000189C431B4-0x0000000189C433A0
		public static int2 mul(int2x4 a, int4 b) => default; // 0x0000000189C45178-0x0000000189C45220
		public static int2x2 mul(int2x4 a, int4x2 b) => default; // 0x0000000189C45C2C-0x0000000189C45D90
		public static int2x3 mul(int2x4 a, int4x3 b) => default; // 0x0000000189C42A14-0x0000000189C42C28
		public static int2x4 mul(int2x4 a, int4x4 b) => default; // 0x0000000189C4AF68-0x0000000189C4B1EC
		public static int3 mul(int3x2 a, int2 b) => default; // 0x0000000189C458C4-0x0000000189C4595C
		public static int3x2 mul(int3x2 a, int2x2 b) => default; // 0x0000000189C4E044-0x0000000189C4E18C
		public static int3x3 mul(int3x2 a, int2x3 b) => default; // 0x0000000189C46AB4-0x0000000189C46C88
		public static int3x4 mul(int3x2 a, int2x4 b) => default; // 0x0000000189C4759C-0x0000000189C47800
		public static int3 mul(int3x3 a, int3 b) => default; // 0x0000000189C474B0-0x0000000189C4759C
		public static int3x2 mul(int3x3 a, int3x2 b) => default; // 0x0000000189C435FC-0x0000000189C437EC
		public static int3x3 mul(int3x3 a, int3x3 b) => default; // 0x0000000189C4BFA0-0x0000000189C4C26C
		public static int3x4 mul(int3x3 a, int3x4 b) => default; // 0x0000000189C47104-0x0000000189C474B0
		public static int3 mul(int3x4 a, int4 b) => default; // 0x0000000189C45220-0x0000000189C45360
		public static int3x2 mul(int3x4 a, int4x2 b) => default; // 0x0000000189C42180-0x0000000189C42414
		public static int3x3 mul(int3x4 a, int4x3 b) => default; // 0x0000000189C49110-0x0000000189C494D0
		public static int3x4 mul(int3x4 a, int4x4 b) => default; // 0x0000000189C43EA8-0x0000000189C44414
		public static int4 mul(int4x2 a, int2 b) => default; // 0x0000000189C4294C-0x0000000189C429C4
		public static int4x2 mul(int4x2 a, int2x2 b) => default; // 0x0000000189C45360-0x0000000189C45440
		public static int4x3 mul(int4x2 a, int2x3 b) => default; // 0x0000000189C47D58-0x0000000189C47EBC
		public static int4x4 mul(int4x2 a, int2x4 b) => default; // 0x0000000189C4A4EC-0x0000000189C4A6BC
		public static int4 mul(int4x3 a, int3 b) => default; // 0x0000000189C424F0-0x0000000189C425A4
		public static int4x2 mul(int4x3 a, int3x2 b) => default; // 0x0000000189C43D50-0x0000000189C43EA8
		public static int4x3 mul(int4x3 a, int3x3 b) => default; // 0x0000000189C41B1C-0x0000000189C41D38
		public static int4x4 mul(int4x3 a, int3x4 b) => default; // 0x0000000189C46DFC-0x0000000189C47104
		public static int4 mul(int4x4 a, int4 b) => default; // 0x0000000189C4AAB0-0x0000000189C4ABA0
		public static int4x2 mul(int4x4 a, int4x2 b) => default; // 0x0000000189C4853C-0x0000000189C4870C
		public static int4x3 mul(int4x4 a, int4x3 b) => default; // 0x0000000189C4C654-0x0000000189C4C924
		public static int4x4 mul(int4x4 a, int4x4 b) => default; // 0x0000000189C4CE04-0x0000000189C4D214
		public static uint mul(uint a, uint b) => default; // 0x0000000183D79CC0-0x0000000183D79CD0
		public static uint mul(uint2 a, uint2 b) => default; // 0x0000000183D79D50-0x0000000183D79D70
		public static uint2 mul(uint2 a, uint2x2 b) => default; // 0x0000000183D7C6C0-0x0000000183D7C700
		public static uint3 mul(uint2 a, uint2x3 b) => default; // 0x0000000183D7C060-0x0000000183D7C0C0
		public static uint4 mul(uint2 a, uint2x4 b) => default; // 0x0000000183D7C8F0-0x0000000183D7C970
		public static uint mul(uint3 a, uint3 b) => default; // 0x0000000183D4E570-0x0000000183D4E590
		public static uint2 mul(uint3 a, uint3x2 b) => default; // 0x0000000183D7C700-0x0000000183D7C750
		public static uint3 mul(uint3 a, uint3x3 b) => default; // 0x0000000183D7BF40-0x0000000183D7BFC0
		public static uint4 mul(uint3 a, uint3x4 b) => default; // 0x0000000183D7BFC0-0x0000000183D7C060
		public static uint mul(uint4 a, uint4 b) => default; // 0x0000000183D79D10-0x0000000183D79D40
		public static uint2 mul(uint4 a, uint4x2 b) => default; // 0x0000000183D7C590-0x0000000183D7C5F0
		public static uint3 mul(uint4 a, uint4x3 b) => default; // 0x0000000183D7BDE0-0x0000000183D7BE80
		public static uint4 mul(uint4 a, uint4x4 b) => default; // 0x0000000183D7BC60-0x0000000183D7BD20
		public static uint2 mul(uint2x2 a, uint2 b) => default; // 0x0000000189C45A4C-0x0000000189C45A94
		public static uint2x2 mul(uint2x2 a, uint2x2 b) => default; // 0x0000000189C4C438-0x0000000189C4C4EC
		public static uint2x3 mul(uint2x2 a, uint2x3 b) => default; // 0x0000000189C46394-0x0000000189C4649C
		public static uint2x4 mul(uint2x2 a, uint2x4 b) => default; // 0x0000000189C42014-0x0000000189C42180
		public static uint2 mul(uint2x3 a, uint3 b) => default; // 0x0000000189C47CDC-0x0000000189C47D58
		public static uint2x2 mul(uint2x3 a, uint3x2 b) => default; // 0x0000000189C49550-0x0000000189C49660
		public static uint2x3 mul(uint2x3 a, uint3x3 b) => default; // 0x0000000189C45A94-0x0000000189C45C2C
		public static uint2x4 mul(uint2x3 a, uint3x4 b) => default; // 0x0000000189C431B4-0x0000000189C433A0
		public static uint2 mul(uint2x4 a, uint4 b) => default; // 0x0000000189C45178-0x0000000189C45220
		public static uint2x2 mul(uint2x4 a, uint4x2 b) => default; // 0x0000000189C45C2C-0x0000000189C45D90
		public static uint2x3 mul(uint2x4 a, uint4x3 b) => default; // 0x0000000189C42A14-0x0000000189C42C28
		public static uint2x4 mul(uint2x4 a, uint4x4 b) => default; // 0x0000000189C4AF68-0x0000000189C4B1EC
		public static uint3 mul(uint3x2 a, uint2 b) => default; // 0x0000000189C458C4-0x0000000189C4595C
		public static uint3x2 mul(uint3x2 a, uint2x2 b) => default; // 0x0000000189C4E044-0x0000000189C4E18C
		public static uint3x3 mul(uint3x2 a, uint2x3 b) => default; // 0x0000000189C46AB4-0x0000000189C46C88
		public static uint3x4 mul(uint3x2 a, uint2x4 b) => default; // 0x0000000189C4759C-0x0000000189C47800
		public static uint3 mul(uint3x3 a, uint3 b) => default; // 0x0000000189C474B0-0x0000000189C4759C
		public static uint3x2 mul(uint3x3 a, uint3x2 b) => default; // 0x0000000189C435FC-0x0000000189C437EC
		public static uint3x3 mul(uint3x3 a, uint3x3 b) => default; // 0x0000000189C4BFA0-0x0000000189C4C26C
		public static uint3x4 mul(uint3x3 a, uint3x4 b) => default; // 0x0000000189C47104-0x0000000189C474B0
		public static uint3 mul(uint3x4 a, uint4 b) => default; // 0x0000000189C45220-0x0000000189C45360
		public static uint3x2 mul(uint3x4 a, uint4x2 b) => default; // 0x0000000189C42180-0x0000000189C42414
		public static uint3x3 mul(uint3x4 a, uint4x3 b) => default; // 0x0000000189C49110-0x0000000189C494D0
		public static uint3x4 mul(uint3x4 a, uint4x4 b) => default; // 0x0000000189C43EA8-0x0000000189C44414
		public static uint4 mul(uint4x2 a, uint2 b) => default; // 0x0000000189C4294C-0x0000000189C429C4
		public static uint4x2 mul(uint4x2 a, uint2x2 b) => default; // 0x0000000189C45360-0x0000000189C45440
		public static uint4x3 mul(uint4x2 a, uint2x3 b) => default; // 0x0000000189C47D58-0x0000000189C47EBC
		public static uint4x4 mul(uint4x2 a, uint2x4 b) => default; // 0x0000000189C4A4EC-0x0000000189C4A6BC
		public static uint4 mul(uint4x3 a, uint3 b) => default; // 0x0000000189C424F0-0x0000000189C425A4
		public static uint4x2 mul(uint4x3 a, uint3x2 b) => default; // 0x0000000189C43D50-0x0000000189C43EA8
		public static uint4x3 mul(uint4x3 a, uint3x3 b) => default; // 0x0000000189C41B1C-0x0000000189C41D38
		public static uint4x4 mul(uint4x3 a, uint3x4 b) => default; // 0x0000000189C46DFC-0x0000000189C47104
		public static uint4 mul(uint4x4 a, uint4 b) => default; // 0x0000000189C4AAB0-0x0000000189C4ABA0
		public static uint4x2 mul(uint4x4 a, uint4x2 b) => default; // 0x0000000189C4853C-0x0000000189C4870C
		public static uint4x3 mul(uint4x4 a, uint4x3 b) => default; // 0x0000000189C4C654-0x0000000189C4C924
		public static uint4x4 mul(uint4x4 a, uint4x4 b) => default; // 0x0000000189C4CE04-0x0000000189C4D214
		public static quaternion quaternion(float x, float y, float z, float w) => default; // 0x0000000183D7AAC0-0x0000000183D7AAE0
		public static quaternion quaternion(float4 value) => default; // 0x0000000183D5B250-0x0000000183D5B260
		public static quaternion quaternion(float3x3 m) => default; // 0x0000000189C50FAC-0x0000000189C50FEC
		public static quaternion quaternion(float4x4 m) => default; // 0x0000000189C50F64-0x0000000189C50FAC
		public static quaternion conjugate(quaternion q) => default; // 0x0000000189C2FD34-0x0000000189C2FD74
		public static quaternion inverse(quaternion q) => default; // 0x0000000189C3EF9C-0x0000000189C3F018
		public static float dot(quaternion a, quaternion b) => default; // 0x0000000189C30A70-0x0000000189C30A98
		public static float length(quaternion q) => default; // 0x0000000189C3FA88-0x0000000189C3FAC4
		public static float lengthsq(quaternion q) => default; // 0x0000000189C3FAC4-0x0000000189C3FAEC
		public static quaternion normalize(quaternion q) => default; // 0x0000000189C4FCD8-0x0000000189C4FD34
		public static quaternion normalizesafe(quaternion q) => default; // 0x0000000189C50050-0x0000000189C50110
		public static quaternion normalizesafe(quaternion q, quaternion defaultvalue) => default; // 0x0000000189C4FFC4-0x0000000189C50050
		public static quaternion unitexp(quaternion q) => default; // 0x0000000184D5E554-0x0000000184D5E678
		public static quaternion exp(quaternion q) => default; // 0x0000000184D30CA4-0x0000000184D30EF4
		public static quaternion unitlog(quaternion q) => default; // 0x0000000184D5E678-0x0000000184D5E9BC
		public static quaternion log(quaternion q) => default; // 0x0000000184D3C860-0x0000000184D3CA68
		public static quaternion mul(quaternion a, quaternion b) => default; // 0x0000000189C44D18-0x0000000189C44EA4
		public static float3 mul(quaternion q, float3 v) => default; // 0x0000000189C4E284-0x0000000189C4E3E0
		public static float3 rotate(quaternion q, float3 v) => default; // 0x0000000189C4E284-0x0000000189C4E3E0
		public static quaternion nlerp(quaternion q1, quaternion q2, float t) => default; // 0x0000000189C4FB78-0x0000000189C4FC58
		public static quaternion slerp(quaternion q1, quaternion q2, float t) => default; // 0x0000000189C5519C-0x0000000189C5533C
		public static float angle(quaternion q1, quaternion q2) => default; // 0x0000000189C2E520-0x0000000189C2E5C8
		public static quaternion rotation(float3x3 m) => default; // 0x0000000189C52BF8-0x0000000189C52E24
		private static float3x3 adj(float3x3 m, out float det) {
			det = default;
			return default;
		} // 0x0000000189C2E1E8-0x0000000189C2E3B8
		private static bool adjInverse(float3x3 m, out float3x3 i, float epsilon = 1E-30f /* Metadata: 0x01FD6042 */) {
			i = default;
			return default;
		} // 0x0000000189C2E0E8-0x0000000189C2E1E8
		public static uint hash(quaternion q) => default; // 0x0000000189C38878-0x0000000189C38894
		public static uint4 hashwide(quaternion q) => default; // 0x0000000189C3B4D0-0x0000000189C3B500
		public static float3 forward(quaternion q) => default; // 0x0000000185543208-0x0000000185543260
		public static RigidTransform RigidTransform(quaternion rot, float3 pos) => default; // 0x0000000183D78270-0x0000000183D78290
		public static RigidTransform RigidTransform(float3x3 rotation, float3 translation) => default; // 0x0000000189C2DE48-0x0000000189C2DEA4
		public static RigidTransform RigidTransform(float4x4 transform) => default; // 0x0000000189C2DEA4-0x0000000189C2DEF4
		public static RigidTransform inverse(RigidTransform t) => default; // 0x0000000189C3F018-0x0000000189C3F0D8
		public static RigidTransform mul(RigidTransform a, RigidTransform b) => default; // 0x0000000189C4D444-0x0000000189C4D514
		public static float4 mul(RigidTransform a, float4 pos) => default; // 0x0000000189C42414-0x0000000189C424F0
		public static float3 rotate(RigidTransform a, float3 dir) => default; // 0x000000018554451C-0x000000018554456C
		public static float3 transform(RigidTransform a, float3 pos) => default; // 0x0000000189C563B8-0x0000000189C56440
		public static uint hash(RigidTransform t) => default; // 0x0000000189C38974-0x0000000189C389B8
		public static uint4 hashwide(RigidTransform t) => default; // 0x0000000189C39CA0-0x0000000189C39D58
		public static uint2 uint2(uint x, uint y) => default; // 0x0000000183D78AF0-0x0000000183D78B00
		public static uint2 uint2(uint2 xy) => default; // 0x0000000183D76940-0x0000000183D76960
		public static uint2 uint2(uint v) => default; // 0x0000000183D7B520-0x0000000183D7B530
		public static uint2 uint2(bool v) => default; // 0x0000000189C3C78C-0x0000000189C3C7A4
		public static uint2 uint2(bool2 v) => default; // 0x0000000189C3C7A4-0x0000000189C3C7C4
		public static uint2 uint2(int v) => default; // 0x0000000183D7B520-0x0000000183D7B530
		public static uint2 uint2(int2 v) => default; // 0x0000000183D76940-0x0000000183D76960
		public static uint2 uint2(float v) => default; // 0x0000000189C57A68-0x0000000189C57A8C
		public static uint2 uint2(float2 v) => default; // 0x0000000189C57A8C-0x0000000189C57AB0
		public static uint2 uint2(double v) => default; // 0x0000000189C57A48-0x0000000189C57A68
		public static uint2 uint2(double2 v) => default; // 0x0000000189C57A18-0x0000000189C57A48
		public static uint hash(uint2 v) => default; // 0x0000000189C36CFC-0x0000000189C36D30
		public static uint2 hashwide(uint2 v) => default; // 0x0000000189C39968-0x0000000189C399A8
		public static uint shuffle(uint2 left, uint2 right, ShuffleComponent x) => default; // 0x0000000184D58FA0-0x0000000184D59134
		public static uint2 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000184D581BC-0x0000000184D582B0
		public static uint3 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000184D58730-0x0000000184D587A0
		public static uint4 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000184D5978C-0x0000000184D5981C
		internal static uint select_shuffle_component(uint2 a, uint2 b, ShuffleComponent component) => default; // 0x0000000184D57274-0x0000000184D57364
		public static uint2x2 uint2x2(uint2 c0, uint2 c1) => default; // 0x0000000182232AA0-0x00000001822372F0
		public static uint2x2 uint2x2(uint m00, uint m01, uint m10, uint m11) => default; // 0x0000000189C3C820-0x0000000189C3C840
		public static uint2x2 uint2x2(uint v) => default; // 0x0000000189C3C808-0x0000000189C3C820
		public static uint2x2 uint2x2(bool v) => default; // 0x0000000189C3C8C4-0x0000000189C3C8DC
		public static uint2x2 uint2x2(bool2x2 v) => default; // 0x0000000189C3C7C4-0x0000000189C3C7E4
		public static uint2x2 uint2x2(int v) => default; // 0x0000000189C3C808-0x0000000189C3C820
		public static uint2x2 uint2x2(int2x2 v) => default; // 0x0000000189C3C888-0x0000000189C3C8AC
		public static uint2x2 uint2x2(float v) => default; // 0x0000000189C57AB0-0x0000000189C57ACC
		public static uint2x2 uint2x2(float2x2 v) => default; // 0x0000000189C57B6C-0x0000000189C57B94
		public static uint2x2 uint2x2(double v) => default; // 0x0000000189C57ACC-0x0000000189C57B10
		public static uint2x2 uint2x2(double2x2 v) => default; // 0x0000000189C57B10-0x0000000189C57B6C
		public static uint2x2 transpose(uint2x2 v) => default; // 0x0000000189C56888-0x0000000189C568C4
		public static uint hash(uint2x2 v) => default; // 0x0000000189C3803C-0x0000000189C380A0
		public static uint2 hashwide(uint2x2 v) => default; // 0x0000000189C39878-0x0000000189C398EC
		public static uint2x3 uint2x3(uint2 c0, uint2 c1, uint2 c2) => default; // 0x0000000183D7A7F0-0x0000000183D7A800
		public static uint2x3 uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12) => default; // 0x0000000184D3AE7C-0x0000000184D3AEB4
		public static uint2x3 uint2x3(uint v) => default; // 0x0000000189C3C934-0x0000000189C3C954
		public static uint2x3 uint2x3(bool v) => default; // 0x0000000189C3C9E8-0x0000000189C3CA08
		public static uint2x3 uint2x3(bool2x3 v) => default; // 0x0000000189C3C974-0x0000000189C3C9AC
		public static uint2x3 uint2x3(int v) => default; // 0x0000000189C3C934-0x0000000189C3C954
		public static uint2x3 uint2x3(int2x3 v) => default; // 0x0000000189C3C8FC-0x0000000189C3C934
		public static uint2x3 uint2x3(float v) => default; // 0x0000000189C57BEC-0x0000000189C57C0C
		public static uint2x3 uint2x3(float2x3 v) => default; // 0x0000000189C57BB4-0x0000000189C57BEC
		public static uint2x3 uint2x3(double v) => default; // 0x0000000189C57B94-0x0000000189C57BB4
		public static uint2x3 uint2x3(double2x3 v) => default; // 0x0000000189C57C0C-0x0000000189C57C48
		public static uint3x2 transpose(uint2x3 v) => default; // 0x0000000189C574EC-0x0000000189C57538
		public static uint hash(uint2x3 v) => default; // 0x0000000189C37558-0x0000000189C375E8
		public static uint2 hashwide(uint2x3 v) => default; // 0x0000000189C3C4C8-0x0000000189C3C568
		public static uint2x4 uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3) => default; // 0x0000000183D7B550-0x0000000183D7B570
		public static uint2x4 uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13) => default; // 0x0000000184D3AEB4-0x0000000184D3AF08
		public static uint2x4 uint2x4(uint v) => default; // 0x0000000189C3CA64-0x0000000189C3CA80
		public static uint2x4 uint2x4(bool v) => default; // 0x0000000189C3CAB4-0x0000000189C3CAD0
		public static uint2x4 uint2x4(bool2x4 v) => default; // 0x0000000189C3CA40-0x0000000189C3CA64
		public static uint2x4 uint2x4(int v) => default; // 0x0000000189C3CA64-0x0000000189C3CA80
		public static uint2x4 uint2x4(int2x4 v) => default; // 0x0000000189C3CA80-0x0000000189C3CAB4
		public static uint2x4 uint2x4(float v) => default; // 0x0000000189C57C7C-0x0000000189C57C9C
		public static uint2x4 uint2x4(float2x4 v) => default; // 0x0000000189C57C48-0x0000000189C57C7C
		public static uint2x4 uint2x4(double v) => default; // 0x0000000189C57C9C-0x0000000189C57CB8
		public static uint2x4 uint2x4(double2x4 v) => default; // 0x0000000189C57CB8-0x0000000189C57CFC
		public static uint4x2 transpose(uint2x4 v) => default; // 0x0000000189C56AA0-0x0000000189C56AF8
		public static uint hash(uint2x4 v) => default; // 0x0000000189C364B0-0x0000000189C3656C
		public static uint2 hashwide(uint2x4 v) => default; // 0x0000000189C3B500-0x0000000189C3B5CC
		public static uint3 uint3(uint x, uint y, uint z) => default; // 0x0000000183D78B00-0x0000000183D78B10
		public static uint3 uint3(uint x, uint2 yz) => default; // 0x0000000183D7B5B0-0x0000000183D7B5D0
		public static uint3 uint3(uint2 xy, uint z) => default; // 0x0000000183D7B5D0-0x0000000183D7B5F0
		public static uint3 uint3(uint3 xyz) => default; // 0x0000000183D7B5F0-0x0000000183D7B620
		public static uint3 uint3(uint v) => default; // 0x0000000183D7B570-0x0000000183D7B580
		public static uint3 uint3(bool v) => default; // 0x0000000189C3CB80-0x0000000189C3CB98
		public static uint3 uint3(bool3 v) => default; // 0x0000000189C3CB98-0x0000000189C3CBCC
		public static uint3 uint3(int v) => default; // 0x0000000183D7B570-0x0000000183D7B580
		public static uint3 uint3(int3 v) => default; // 0x0000000183D7B5F0-0x0000000183D7B620
		public static uint3 uint3(float v) => default; // 0x0000000189C57D5C-0x0000000189C57D78
		public static uint3 uint3(float3 v) => default; // 0x0000000184D5FCE8-0x0000000184D5FD34
		public static uint3 uint3(double v) => default; // 0x0000000189C57D34-0x0000000189C57D5C
		public static uint3 uint3(double3 v) => default; // 0x0000000189C57CFC-0x0000000189C57D34
		public static uint hash(uint3 v) => default; // 0x0000000184D33F54-0x0000000184D349A8
		public static uint3 hashwide(uint3 v) => default; // 0x0000000184D3A078-0x0000000184D3A4C4
		public static uint shuffle(uint3 left, uint3 right, ShuffleComponent x) => default; // 0x0000000184D599AC-0x0000000184D599E8
		public static uint2 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000184D58EA8-0x0000000184D58F28
		public static uint3 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000184D598D0-0x0000000184D599AC
		public static uint4 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000184D591A0-0x0000000184D592B8
		internal static uint select_shuffle_component(uint3 a, uint3 b, ShuffleComponent component) => default; // 0x0000000184D579DC-0x0000000184D57AE0
		public static uint3x2 uint3x2(uint3 c0, uint3 c1) => default; // 0x0000000183D7AA40-0x0000000183D7AA70
		public static uint3x2 uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21) => default; // 0x0000000184D3AF08-0x0000000184D3AF98
		public static uint3x2 uint3x2(uint v) => default; // 0x0000000189C3CC7C-0x0000000189C3CC9C
		public static uint3x2 uint3x2(bool v) => default; // 0x0000000189C3CC9C-0x0000000189C3CCBC
		public static uint3x2 uint3x2(bool3x2 v) => default; // 0x0000000189C3CCBC-0x0000000189C3CCF4
		public static uint3x2 uint3x2(int v) => default; // 0x0000000189C3CC7C-0x0000000189C3CC9C
		public static uint3x2 uint3x2(int3x2 v) => default; // 0x0000000189C3CC0C-0x0000000189C3CC44
		public static uint3x2 uint3x2(float v) => default; // 0x0000000189C57E4C-0x0000000189C57E6C
		public static uint3x2 uint3x2(float3x2 v) => default; // 0x0000000189C57E14-0x0000000189C57E4C
		public static uint3x2 uint3x2(double v) => default; // 0x0000000189C57D78-0x0000000189C57DD8
		public static uint3x2 uint3x2(double3x2 v) => default; // 0x0000000189C57DD8-0x0000000189C57E14
		public static uint2x3 transpose(uint3x2 v) => default; // 0x0000000189C568C4-0x0000000189C56910
		public static uint hash(uint3x2 v) => default; // 0x0000000189C36A54-0x0000000189C36B34
		public static uint3 hashwide(uint3x2 v) => default; // 0x0000000189C3AFE8-0x0000000189C3B0E0
		public static uint3x3 uint3x3(uint3 c0, uint3 c1, uint3 c2) => default; // 0x0000000182E246E0-0x0000000182E247E0
		public static uint3x3 uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22) => default; // 0x0000000184D3AF98-0x0000000184D3B05C
		public static uint3x3 uint3x3(uint v) => default; // 0x0000000189C3CD34-0x0000000189C3CD54
		public static uint3x3 uint3x3(bool v) => default; // 0x0000000189C3CEAC-0x0000000189C3CECC
		public static uint3x3 uint3x3(bool3x3 v) => default; // 0x0000000189C3CE6C-0x0000000189C3CEAC
		public static uint3x3 uint3x3(int v) => default; // 0x0000000189C3CD34-0x0000000189C3CD54
		public static uint3x3 uint3x3(int3x3 v) => default; // 0x0000000189C3CD74-0x0000000189C3CDB4
		public static uint3x3 uint3x3(float v) => default; // 0x0000000189C57ECC-0x0000000189C57EF0
		public static uint3x3 uint3x3(float3x3 v) => default; // 0x0000000189C57E8C-0x0000000189C57ECC
		public static uint3x3 uint3x3(double v) => default; // 0x0000000189C57E6C-0x0000000189C57E8C
		public static uint3x3 uint3x3(double3x3 v) => default; // 0x0000000189C57EF0-0x0000000189C57F44
		public static uint3x3 transpose(uint3x3 v) => default; // 0x0000000189C56E28-0x0000000189C56E94
		public static uint hash(uint3x3 v) => default; // 0x0000000189C38234-0x0000000189C38388
		public static uint3 hashwide(uint3x3 v) => default; // 0x0000000189C3B6C0-0x0000000189C3B82C
		public static uint3x4 uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3) => default; // 0x0000000183D7AA70-0x0000000183D7AAC0
		public static uint3x4 uint3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23) => default; // 0x0000000184D3B05C-0x0000000184D3B124
		public static uint3x4 uint3x4(uint v) => default; // 0x0000000189C3CF88-0x0000000189C3CFA8
		public static uint3x4 uint3x4(bool v) => default; // 0x0000000189C3CECC-0x0000000189C3CEEC
		public static uint3x4 uint3x4(bool3x4 v) => default; // 0x0000000189C3CF4C-0x0000000189C3CF88
		public static uint3x4 uint3x4(int v) => default; // 0x0000000189C3CF88-0x0000000189C3CFA8
		public static uint3x4 uint3x4(int3x4 v) => default; // 0x0000000189C3D02C-0x0000000189C3D070
		public static uint3x4 uint3x4(float v) => default; // 0x0000000189C58004-0x0000000189C58028
		public static uint3x4 uint3x4(float3x4 v) => default; // 0x0000000189C57FC0-0x0000000189C58004
		public static uint3x4 uint3x4(double v) => default; // 0x0000000189C57F44-0x0000000189C57F64
		public static uint3x4 uint3x4(double3x4 v) => default; // 0x0000000189C57F64-0x0000000189C57FC0
		public static uint4x3 transpose(uint3x4 v) => default; // 0x0000000189C569B0-0x0000000189C56A34
		public static uint hash(uint3x4 v) => default; // 0x0000000189C37E70-0x0000000189C3803C
		public static uint3 hashwide(uint3x4 v) => default; // 0x0000000189C3C1F8-0x0000000189C3C3D8
		public static uint4 uint4(uint x, uint y, uint z, uint w) => default; // 0x0000000183D78B10-0x0000000183D78B30
		public static uint4 uint4(uint x, uint y, uint2 zw) => default; // 0x0000000183D7B730-0x0000000183D7B750
		public static uint4 uint4(uint x, uint2 yz, uint w) => default; // 0x0000000183D7B7B0-0x0000000183D7B7D0
		public static uint4 uint4(uint x, uint3 yzw) => default; // 0x0000000183D7B6B0-0x0000000183D7B6F0
		public static uint4 uint4(uint2 xy, uint z, uint w) => default; // 0x0000000183D7B750-0x0000000183D7B770
		public static uint4 uint4(uint2 xy, uint2 zw) => default; // 0x0000000183D76960-0x0000000183D76980
		public static uint4 uint4(uint3 xyz, uint w) => default; // 0x0000000183D7B770-0x0000000183D7B7B0
		public static uint4 uint4(uint4 xyzw) => default; // 0x0000000189C3D070-0x0000000189C3D09C
		public static uint4 uint4(uint v) => default; // 0x0000000183D7B6A0-0x0000000183D7B6B0
		public static uint4 uint4(bool v) => default; // 0x0000000189C3D09C-0x0000000189C3D0BC
		public static uint4 uint4(bool4 v) => default; // 0x0000000189C3D0BC-0x0000000189C3D100
		public static uint4 uint4(int v) => default; // 0x0000000183D7B6A0-0x0000000183D7B6B0
		public static uint4 uint4(int4 v) => default; // 0x0000000189C3D070-0x0000000189C3D09C
		public static uint4 uint4(float v) => default; // 0x0000000189C58070-0x0000000189C58088
		public static uint4 uint4(float4 v) => default; // 0x0000000189C580B8-0x0000000189C580DC
		public static uint4 uint4(double v) => default; // 0x0000000189C58088-0x0000000189C580B8
		public static uint4 uint4(double4 v) => default; // 0x0000000189C58028-0x0000000189C58070
		public static uint hash(uint4 v) => default; // 0x0000000189C35DFC-0x0000000189C35E68
		public static uint4 hashwide(uint4 v) => default; // 0x0000000189C397FC-0x0000000189C39878
		public static uint shuffle(uint4 left, uint4 right, ShuffleComponent x) => default; // 0x0000000189C53F00-0x0000000189C53F28
		public static uint2 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000189C53A80-0x0000000189C53AD8
		public static uint3 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000189C5434C-0x0000000189C543F4
		public static uint4 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000189C5468C-0x0000000189C54764
		internal static uint select_shuffle_component(uint4 a, uint4 b, ShuffleComponent component) => default; // 0x0000000184D57EF8-0x0000000184D580C8
		public static uint4x2 uint4x2(uint4 c0, uint4 c1) => default; // 0x0000000183D7AC80-0x0000000183D7ACA0
		public static uint4x2 uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31) => default; // 0x0000000184D3B124-0x0000000184D3B1D8
		public static uint4x2 uint4x2(uint v) => default; // 0x0000000189C3D1C4-0x0000000189C3D1E0
		public static uint4x2 uint4x2(bool v) => default; // 0x0000000189C58100-0x0000000189C5811C
		public static uint4x2 uint4x2(bool4x2 v) => default; // 0x0000000189C580DC-0x0000000189C58100
		public static uint4x2 uint4x2(int v) => default; // 0x0000000189C3D1C4-0x0000000189C3D1E0
		public static uint4x2 uint4x2(int4x2 v) => default; // 0x0000000189C3D1E0-0x0000000189C3D214
		public static uint4x2 uint4x2(float v) => default; // 0x0000000189C5811C-0x0000000189C5813C
		public static uint4x2 uint4x2(float4x2 v) => default; // 0x0000000189C58180-0x0000000189C581B4
		public static uint4x2 uint4x2(double v) => default; // 0x0000000189C581B4-0x0000000189C581D0
		public static uint4x2 uint4x2(double4x2 v) => default; // 0x0000000189C5813C-0x0000000189C58180
		public static uint2x4 transpose(uint4x2 v) => default; // 0x0000000189C56910-0x0000000189C56968
		public static uint hash(uint4x2 v) => default; // 0x0000000189C38454-0x0000000189C38520
		public static uint4 hashwide(uint4x2 v) => default; // 0x0000000189C38E74-0x0000000189C38F4C
		public static uint4x3 uint4x3(uint4 c0, uint4 c1, uint4 c2) => default; // 0x0000000183D7ACA0-0x0000000183D7ACC0
		public static uint4x3 uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32) => default; // 0x0000000184D3B1D8-0x0000000184D3B3A0
		public static uint4x3 uint4x3(uint v) => default; // 0x0000000189C3D2C4-0x0000000189C3D2E4
		public static uint4x3 uint4x3(bool v) => default; // 0x0000000189C582F0-0x0000000189C58310
		public static uint4x3 uint4x3(bool4x3 v) => default; // 0x0000000189C582B4-0x0000000189C582F0
		public static uint4x3 uint4x3(int v) => default; // 0x0000000189C3D2C4-0x0000000189C3D2E4
		public static uint4x3 uint4x3(int4x3 v) => default; // 0x0000000189C3D3A0-0x0000000189C3D3E4
		public static uint4x3 uint4x3(float v) => default; // 0x0000000189C58270-0x0000000189C58294
		public static uint4x3 uint4x3(float4x3 v) => default; // 0x0000000189C581D0-0x0000000189C58214
		public static uint4x3 uint4x3(double v) => default; // 0x0000000189C58294-0x0000000189C582B4
		public static uint4x3 uint4x3(double4x3 v) => default; // 0x0000000189C58214-0x0000000189C58270
		public static uint3x4 transpose(uint4x3 v) => default; // 0x0000000189C56CC4-0x0000000189C56D48
		public static uint hash(uint4x3 v) => default; // 0x0000000189C37178-0x0000000189C372A8
		public static uint4 hashwide(uint4x3 v) => default; // 0x0000000189C3B0E0-0x0000000189C3B21C
		public static uint4x4 uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3) => default; // 0x0000000183D7ACC0-0x0000000183D7ACF0
		public static uint4x4 uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33) => default; // 0x0000000184D3B3A0-0x0000000184D3B638
		public static uint4x4 uint4x4(uint v) => default; // 0x0000000189C3D4C4-0x0000000189C3D4E8
		public static uint4x4 uint4x4(bool v) => default; // 0x0000000189C58310-0x0000000189C58334
		public static uint4x4 uint4x4(bool4x4 v) => default; // 0x0000000189C58390-0x0000000189C583C8
		public static uint4x4 uint4x4(int v) => default; // 0x0000000189C3D4C4-0x0000000189C3D4E8
		public static uint4x4 uint4x4(int4x4 v) => default; // 0x0000000189C3D544-0x0000000189C3D5A0
		public static uint4x4 uint4x4(float v) => default; // 0x0000000189C58454-0x0000000189C5847C
		public static uint4x4 uint4x4(float4x4 v) => default; // 0x0000000189C58334-0x0000000189C58390
		public static uint4x4 uint4x4(double v) => default; // 0x0000000189C5847C-0x0000000189C584A0
		public static uint4x4 uint4x4(double4x4 v) => default; // 0x0000000189C583C8-0x0000000189C58454
		public static uint4x4 transpose(uint4x4 v) => default; // 0x0000000189C57048-0x0000000189C570F0
		public static uint hash(uint4x4 v) => default; // 0x0000000189C36D30-0x0000000189C36EC0
		public static uint4 hashwide(uint4x4 v) => default; // 0x0000000189C395C0-0x0000000189C3975C
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool2 : IEquatable<Unity.Mathematics.bool2> // TypeDefIndex: 53704
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53703
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public bool2(bool x, bool y) {
			this.x = default;
			this.y = default;
		} // 0x0000000183D67530-0x0000000183D67540
		public bool2(bool2 xy) {
			x = default;
			y = default;
		} // 0x0000000183D7D460-0x0000000183D7D470
		public bool2(bool v) {
			x = default;
			y = default;
		} // 0x0000000183D7D470-0x0000000183D7D480
	
		// Methods
		public static implicit operator bool2(bool v) => default; // 0x0000000183D787D0-0x0000000183D787E0
		public bool Equals(bool2 rhs) => default; // 0x0000000189C5F4B4-0x0000000189C5F4C8
		public override bool Equals(object o) => default; // 0x0000000189C5F4C8-0x0000000189C5F53C
		public override int GetHashCode() => default; // 0x0000000189C5F53C-0x0000000189C5F584
		public override string ToString() => default; // 0x0000000189C5F584-0x0000000189C5F60C
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool2x2 : IEquatable<Unity.Mathematics.bool2x2> // TypeDefIndex: 53705
	{
		// Fields
		public bool2 c0; // 0x00
		public bool2 c1; // 0x02
	
		// Constructors
		public bool2x2(bool2 c0, bool2 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D6EFA0-0x0000000183D6EFB0
		public bool2x2(bool m00, bool m01, bool m10, bool m11) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7D4B0-0x0000000183D7D4E0
		public bool2x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7D480-0x0000000183D7D4B0
	
		// Methods
		public bool Equals(bool2x2 rhs) => default; // 0x0000000189C58FAC-0x0000000189C59134
		public override bool Equals(object o) => default; // 0x0000000189C5F60C-0x0000000189C5F66C
		public override int GetHashCode() => default; // 0x0000000189C5F66C-0x0000000189C5F674
		public override string ToString() => default; // 0x0000000189C5F674-0x0000000189C5F7D0
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool2x3 : IEquatable<Unity.Mathematics.bool2x3> // TypeDefIndex: 53706
	{
		// Fields
		public bool2 c0; // 0x00
		public bool2 c1; // 0x02
		public bool2 c2; // 0x04
	
		// Constructors
		public bool2x3(bool2 c0, bool2 c1, bool2 c2) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D7D570-0x0000000183D7D580
		public bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7D4E0-0x0000000183D7D530
		public bool2x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7D530-0x0000000183D7D570
	
		// Methods
		public bool Equals(bool2x3 rhs) => default; // 0x0000000189C59134-0x0000000189C5933C
		public override bool Equals(object o) => default; // 0x0000000189C5F7D0-0x0000000189C5F840
		public override int GetHashCode() => default; // 0x0000000189C5F840-0x0000000189C5F864
		public override string ToString() => default; // 0x0000000189C5F864-0x0000000189C5FA2C
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool2x4 : IEquatable<Unity.Mathematics.bool2x4> // TypeDefIndex: 53707
	{
		// Fields
		public bool2 c0; // 0x00
		public bool2 c1; // 0x02
		public bool2 c2; // 0x04
		public bool2 c3; // 0x06
	
		// Constructors
		public bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D7D630-0x0000000183D7D650
		public bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7D580-0x0000000183D7D5E0
		public bool2x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7D5E0-0x0000000183D7D630
	
		// Methods
		public bool Equals(bool2x4 rhs) => default; // 0x0000000189C5933C-0x0000000189C595C4
		public override bool Equals(object o) => default; // 0x0000000189C5FA2C-0x0000000189C5FA8C
		public override int GetHashCode() => default; // 0x0000000189C5FA8C-0x0000000189C5FA94
		public override string ToString() => default; // 0x0000000189C5FA94-0x0000000189C5FCC4
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct bool3 : IEquatable<Unity.Mathematics.bool3> // TypeDefIndex: 53709
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
		public bool z; // 0x02
	
		// Properties
		public bool this[int index] { get => default; set {} } // 0x00000001829BF5F0-0x00000001829BF600 0x0000000183D5EB10-0x0000000183D5EB20
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53708
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public bool3(bool x, bool y, bool z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000183D6B5F0-0x0000000183D6B600
		public bool3(bool x, bool2 yz) : this() {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000183D7D660-0x0000000183D7D670
		public bool3(bool2 xy, bool z) : this() {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000183D7D670-0x0000000183D7D680
		public bool3(bool3 xyz) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D7D680-0x0000000183D7D6A0
		public bool3(bool v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D7D650-0x0000000183D7D660
	
		// Methods
		public static implicit operator bool3(bool v) => default; // 0x0000000183D78870-0x0000000183D78880
		public static bool3 operator &(bool3 lhs, bool3 rhs) => default; // 0x0000000182E9FD70-0x0000000182E9FDA0
		public static bool3 operator |(bool3 lhs, bool3 rhs) => default; // 0x0000000189C5FE0C-0x0000000189C5FE3C
		public bool Equals(bool3 rhs) => default; // 0x0000000189C595C4-0x0000000189C59F38
		public override bool Equals(object o) => default; // 0x0000000189C5FCC4-0x0000000189C5FD34
		public override int GetHashCode() => default; // 0x0000000189C5FD34-0x0000000189C5FD58
		public override string ToString() => default; // 0x0000000189C5FD58-0x0000000189C5FE0C
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool3x2 : IEquatable<Unity.Mathematics.bool3x2> // TypeDefIndex: 53710
	{
		// Fields
		public bool3 c0; // 0x00
		public bool3 c1; // 0x03
	
		// Constructors
		public bool3x2(bool3 c0, bool3 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D7D710-0x0000000183D7D730
		public bool3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7D6A0-0x0000000183D7D6E0
		public bool3x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7D6E0-0x0000000183D7D710
	
		// Methods
		public bool Equals(bool3x2 rhs) => default; // 0x0000000189C5FEAC-0x0000000189C5FEF8
		public override bool Equals(object o) => default; // 0x0000000189C5FE3C-0x0000000189C5FEAC
		public override int GetHashCode() => default; // 0x0000000189C5FEF8-0x0000000189C5FF1C
		public override string ToString() => default; // 0x0000000189C5FF1C-0x0000000189C600E4
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool3x3 : IEquatable<Unity.Mathematics.bool3x3> // TypeDefIndex: 53711
	{
		// Fields
		public bool3 c0; // 0x00
		public bool3 c1; // 0x03
		public bool3 c2; // 0x06
	
		// Constructors
		public bool3x3(bool3 c0, bool3 c1, bool3 c2) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D7D7E0-0x0000000183D7D810
		public bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7D770-0x0000000183D7D7E0
		public bool3x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7D730-0x0000000183D7D770
	
		// Methods
		public bool Equals(bool3x3 rhs) => default; // 0x0000000189C60158-0x0000000189C601CC
		public override bool Equals(object o) => default; // 0x0000000189C600E4-0x0000000189C60158
		public override int GetHashCode() => default; // 0x0000000189C601CC-0x0000000189C601F4
		public override string ToString() => default; // 0x0000000189C601F4-0x0000000189C60458
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool3x4 : IEquatable<Unity.Mathematics.bool3x4> // TypeDefIndex: 53712
	{
		// Fields
		public bool3 c0; // 0x00
		public bool3 c1; // 0x03
		public bool3 c2; // 0x06
		public bool3 c3; // 0x09
	
		// Constructors
		public bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D7D8F0-0x0000000183D7D940
		public bool3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7D860-0x0000000183D7D8F0
		public bool3x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7D810-0x0000000183D7D860
	
		// Methods
		public bool Equals(bool3x4 rhs) => default; // 0x0000000189C60458-0x0000000189C604EC
		public override bool Equals(object o) => default; // 0x0000000189C604EC-0x0000000189C60560
		public override int GetHashCode() => default; // 0x0000000189C60560-0x0000000189C60584
		public override string ToString() => default; // 0x0000000189C60584-0x0000000189C60884
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct bool4 : IEquatable<Unity.Mathematics.bool4> // TypeDefIndex: 53714
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
		public bool z; // 0x02
		public bool w; // 0x03
	
		// Properties
		public bool this[int index] { set {} } // 0x0000000183D5EB10-0x0000000183D5EB20
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53713
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public bool4(bool x, bool y, bool z, bool w) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D76590-0x0000000183D765B0
		public bool4(bool x, bool y, bool2 zw) : this() {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000183D7DA10-0x0000000183D7DA30
		public bool4(bool x, bool2 yz, bool w) : this() {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D7D970-0x0000000183D7D990
		public bool4(bool x, bool3 yzw) : this() {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7D990-0x0000000183D7D9B0
		public bool4(bool2 xy, bool z, bool w) : this() {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D7D9B0-0x0000000183D7D9D0
		public bool4(bool2 xy, bool2 zw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7D9D0-0x0000000183D7D9F0
		public bool4(bool3 xyz, bool w) : this() {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D7D9F0-0x0000000183D7DA10
		public bool4(bool4 xyzw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7D940-0x0000000183D7D960
		public bool4(bool v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7D960-0x0000000183D7D970
	
		// Methods
		public static implicit operator bool4(bool v) => default; // 0x0000000183D78A00-0x0000000183D78A20
		public bool Equals(bool4 rhs) => default; // 0x0000000189C59F38-0x0000000189C5A0C0
		public override bool Equals(object o) => default; // 0x0000000189C60884-0x0000000189C608E4
		public override int GetHashCode() => default; // 0x0000000189C608E4-0x0000000189C608EC
		public override string ToString() => default; // 0x0000000189C608EC-0x0000000189C60A48
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool4x2 : IEquatable<Unity.Mathematics.bool4x2> // TypeDefIndex: 53715
	{
		// Fields
		public bool4 c0; // 0x00
		public bool4 c1; // 0x04
	
		// Constructors
		public bool4x2(bool4 c0, bool4 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D4E4B0-0x0000000183D4E4C0
		public bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7DA60-0x0000000183D7DAB0
		public bool4x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7DA30-0x0000000183D7DA60
	
		// Methods
		public bool Equals(bool4x2 rhs) => default; // 0x0000000189C5A0C0-0x0000000189C5AA84
		public override bool Equals(object o) => default; // 0x0000000189C60A48-0x0000000189C60AA8
		public override int GetHashCode() => default; // 0x0000000189C60AA8-0x0000000189C60AB0
		public override string ToString() => default; // 0x0000000189C60AB0-0x0000000189C60CE0
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool4x3 : IEquatable<Unity.Mathematics.bool4x3> // TypeDefIndex: 53716
	{
		// Fields
		public bool4 c0; // 0x00
		public bool4 c1; // 0x04
		public bool4 c2; // 0x08
	
		// Constructors
		public bool4x3(bool4 c0, bool4 c1, bool4 c2) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D4E5D0-0x0000000183D4E5E0
		public bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7DAB0-0x0000000183D7DB30
		public bool4x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7DB30-0x0000000183D7DB80
	
		// Methods
		public bool Equals(bool4x3 rhs) => default; // 0x0000000189C60D54-0x0000000189C60D94
		public override bool Equals(object o) => default; // 0x0000000189C60CE0-0x0000000189C60D54
		public override int GetHashCode() => default; // 0x0000000189C60D94-0x0000000189C60DB8
		public override string ToString() => default; // 0x0000000189C60DB8-0x0000000189C610B8
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct bool4x4 : IEquatable<Unity.Mathematics.bool4x4> // TypeDefIndex: 53717
	{
		// Fields
		public bool4 c0; // 0x00
		public bool4 c1; // 0x04
		public bool4 c2; // 0x08
		public bool4 c3; // 0x0C
	
		// Constructors
		public bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D517E0-0x0000000183D51800
		public bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7DB80-0x0000000183D7DC30
		public bool4x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7DC30-0x0000000183D7DC90
	
		// Methods
		public bool Equals(bool4x4 rhs) => default; // 0x0000000189C61124-0x0000000189C61174
		public override bool Equals(object o) => default; // 0x0000000189C610B8-0x0000000189C61124
		public override int GetHashCode() => default; // 0x0000000189C61174-0x0000000189C61190
		public override string ToString() => default; // 0x0000000189C61190-0x0000000189C61560
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double2 : IEquatable<Unity.Mathematics.double2>, IFormattable // TypeDefIndex: 53719
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53718
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public double2(double x, double y) {
			this.x = default;
			this.y = default;
		} // 0x0000000183D50BD0-0x0000000183D50BE0
		public double2(double2 xy) {
			x = default;
			y = default;
		} // 0x0000000183D50BC0-0x0000000183D50BD0
		public double2(double v) {
			x = default;
			y = default;
		} // 0x0000000183D7DCE0-0x0000000183D7DCF0
		public double2(bool v) {
			x = default;
			y = default;
		} // 0x0000000189C61760-0x0000000189C61774
		public double2(bool2 v) {
			x = default;
			y = default;
		} // 0x0000000184D253C0-0x0000000184D25428
		public double2(int v) {
			x = default;
			y = default;
		} // 0x0000000183D7DD10-0x0000000183D7DD30
		public double2(int2 v) {
			x = default;
			y = default;
		} // 0x0000000183D7DCC0-0x0000000183D7DCE0
		public double2(uint v) {
			x = default;
			y = default;
		} // 0x0000000183D7DCF0-0x0000000183D7DD10
		public double2(uint2 v) {
			x = default;
			y = default;
		} // 0x0000000183D7DD30-0x0000000183D7DD50
		public double2(half v) {
			x = default;
			y = default;
		} // 0x0000000189C61724-0x0000000189C61760
		public double2(half2 v) {
			x = default;
			y = default;
		} // 0x0000000189C616E4-0x0000000189C61724
		public double2(float v) {
			x = default;
			y = default;
		} // 0x0000000183D7DD50-0x0000000183D7DD60
		public double2(float2 v) {
			x = default;
			y = default;
		} // 0x0000000183D7DC90-0x0000000183D7DCC0
	
		// Methods
		public static implicit operator double2(double v) => default; // 0x0000000183D79F00-0x0000000183D79F10
		public static implicit operator double2(int v) => default; // 0x0000000183D79EA0-0x0000000183D79EC0
		public static implicit operator double2(int2 v) => default; // 0x0000000183D79E40-0x0000000183D79E70
		public static implicit operator double2(uint v) => default; // 0x0000000183D79DE0-0x0000000183D79E10
		public static implicit operator double2(uint2 v) => default; // 0x0000000183D79E70-0x0000000183D79EA0
		public static implicit operator double2(float v) => default; // 0x0000000183D79EC0-0x0000000183D79EE0
		public static implicit operator double2(float2 v) => default; // 0x0000000183D79E10-0x0000000183D79E40
		public static double2 operator *(double2 lhs, double2 rhs) => default; // 0x0000000183D7DD90-0x0000000183D7DDC0
		public static double2 operator *(double2 lhs, double rhs) => default; // 0x0000000183D7DDE0-0x0000000183D7DE00
		public static double2 operator *(double lhs, double2 rhs) => default; // 0x0000000183D7DDC0-0x0000000183D7DDE0
		public static double2 operator +(double2 lhs, double2 rhs) => default; // 0x0000000183D7DD60-0x0000000183D7DD90
		public static double2 operator -(double2 lhs, double2 rhs) => default; // 0x0000000183D7DE20-0x0000000183D7DE50
		public static double2 operator -(double lhs, double2 rhs) => default; // 0x0000000183D7DE00-0x0000000183D7DE20
		public static double2 operator /(double2 lhs, double2 rhs) => default; // 0x0000000189C61790-0x0000000189C617B4
		public static double2 operator /(double lhs, double2 rhs) => default; // 0x0000000189C61774-0x0000000189C61790
		public static bool2 operator <(double2 lhs, double rhs) => default; // 0x0000000189C6180C-0x0000000189C61828
		public static bool2 operator >=(double2 lhs, double2 rhs) => default; // 0x0000000189C617E8-0x0000000189C6180C
		public static double2 operator -(double2 val) => default; // 0x0000000183D7DE50-0x0000000183D7DE70
		public static bool2 operator ==(double2 lhs, double rhs) => default; // 0x0000000189C617B4-0x0000000189C617E8
		public bool Equals(double2 rhs) => default; // 0x0000000189C5AA84-0x0000000189C5EBDC
		public override bool Equals(object o) => default; // 0x0000000189C61560-0x0000000189C615CC
		public override int GetHashCode() => default; // 0x0000000189C372A8-0x0000000189C372F0
		public override string ToString() => default; // 0x0000000189C61654-0x0000000189C616E4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C615CC-0x0000000189C61654
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double2x2 : IEquatable<Unity.Mathematics.double2x2>, IFormattable // TypeDefIndex: 53720
	{
		// Fields
		public double2 c0; // 0x00
		public double2 c1; // 0x10
		public static readonly double2x2 identity; // 0x00
	
		// Constructors
		public double2x2(double2 c0, double2 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D553F0-0x0000000183D55400
		public double2x2(double m00, double m01, double m10, double m11) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7DEC0-0x0000000183D7DEE0
		public double2x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7DEA0-0x0000000183D7DEC0
		public double2x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D254A8-0x0000000184D25534
		public double2x2(bool2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D25428-0x0000000184D254A8
		public double2x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7DE70-0x0000000183D7DEA0
		public double2x2(int2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7DFE0-0x0000000183D7E030
		public double2x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7DEE0-0x0000000183D7DF20
		public double2x2(uint2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7DF60-0x0000000183D7DFB0
		public double2x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7DFB0-0x0000000183D7DFE0
		public double2x2(float2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7DF20-0x0000000183D7DF60
		static double2x2() {
			identity = default;
		} // 0x0000000183CE5E50-0x0000000183CE5EC0
	
		// Methods
		public static double2x2 operator *(double2x2 lhs, double rhs) => default; // 0x0000000189C61BC8-0x0000000189C61C24
		public bool Equals(double2x2 rhs) => default; // 0x0000000189C61828-0x0000000189C61870
		public override bool Equals(object o) => default; // 0x0000000189C61870-0x0000000189C618E4
		public override int GetHashCode() => default; // 0x0000000189C618E4-0x0000000189C61908
		public override string ToString() => default; // 0x0000000189C61908-0x0000000189C61A74
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C61A74-0x0000000189C61BC8
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double2x3 : IEquatable<Unity.Mathematics.double2x3>, IFormattable // TypeDefIndex: 53721
	{
		// Fields
		public double2 c0; // 0x00
		public double2 c1; // 0x10
		public double2 c2; // 0x20
	
		// Constructors
		public double2x3(double2 c0, double2 c1, double2 c2) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D6B600-0x0000000183D6B620
		public double2x3(double m00, double m01, double m02, double m10, double m11, double m12) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7E190-0x0000000183D7E1C0
		public double2x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7E120-0x0000000183D7E140
		public double2x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D25534-0x0000000184D25568
		public double2x3(bool2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D25568-0x0000000184D25618
		public double2x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7E280-0x0000000183D7E2D0
		public double2x3(int2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7E030-0x0000000183D7E0A0
		public double2x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7E220-0x0000000183D7E280
		public double2x3(uint2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7E0A0-0x0000000183D7E120
		public double2x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7E140-0x0000000183D7E190
		public double2x3(float2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7E1C0-0x0000000183D7E220
	
		// Methods
		public bool Equals(double2x3 rhs) => default; // 0x0000000189C61C24-0x0000000189C61C84
		public override bool Equals(object o) => default; // 0x0000000189C61C84-0x0000000189C61D00
		public override int GetHashCode() => default; // 0x0000000189C61D00-0x0000000189C61D30
		public override string ToString() => default; // 0x0000000189C61EE4-0x0000000189C620C4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C61D30-0x0000000189C61EE4
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double2x4 : IEquatable<Unity.Mathematics.double2x4>, IFormattable // TypeDefIndex: 53722
	{
		// Fields
		public double2 c0; // 0x00
		public double2 c1; // 0x10
		public double2 c2; // 0x20
		public double2 c3; // 0x30
	
		// Constructors
		public double2x4(double2 c0, double2 c1, double2 c2, double2 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D7E4A0-0x0000000183D7E4D0
		public double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7E4D0-0x0000000183D7E520
		public double2x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7E520-0x0000000183D7E540
		public double2x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D256F8-0x0000000184D2573C
		public double2x4(bool2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D25618-0x0000000184D256F8
		public double2x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7E3D0-0x0000000183D7E430
		public double2x4(int2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7E5C0-0x0000000183D7E650
		public double2x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7E540-0x0000000183D7E5C0
		public double2x4(uint2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7E330-0x0000000183D7E3D0
		public double2x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7E2D0-0x0000000183D7E330
		public double2x4(float2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7E430-0x0000000183D7E4A0
	
		// Methods
		public bool Equals(double2x4 rhs) => default; // 0x0000000189C620C4-0x0000000189C62140
		public override bool Equals(object o) => default; // 0x0000000189C62140-0x0000000189C621C4
		public override int GetHashCode() => default; // 0x0000000189C621C4-0x0000000189C621FC
		public override string ToString() => default; // 0x0000000189C62410-0x0000000189C62660
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C621FC-0x0000000189C62410
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct double3 : IEquatable<Unity.Mathematics.double3>, IFormattable // TypeDefIndex: 53724
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
		public static readonly double3 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 yzx { get => default; } // 0x0000000183D7E7C0-0x0000000183D7E7E0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 zxy { get => default; } // 0x0000000183D7E7E0-0x0000000183D7E800 
		public double this[int index] { get => default; } // 0x0000000183D7E7B0-0x0000000183D7E7C0 
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53723
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public double3(double x, double y, double z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000183D7E7A0-0x0000000183D7E7B0
		public double3(double x, double2 yz) : this() {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000183D7E6D0-0x0000000183D7E6F0
		public double3(double2 xy, double z) : this() {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000183D7E690-0x0000000183D7E6B0
		public double3(double3 xyz) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D7E710-0x0000000183D7E730
		public double3(double v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D7E730-0x0000000183D7E740
		public double3(bool v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000184D25778-0x0000000184D25A1C
		public double3(bool3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000184D2573C-0x0000000184D25778
		public double3(int v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D7E6F0-0x0000000183D7E710
		public double3(int3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D7E6B0-0x0000000183D7E6D0
		public double3(uint v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D7E740-0x0000000183D7E770
		public double3(uint3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D7E770-0x0000000183D7E7A0
		public double3(half v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C6286C-0x0000000189C628BC
		public double3(half3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C628BC-0x0000000189C62910
		public double3(float v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D7E670-0x0000000183D7E690
		public double3(float3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D7E650-0x0000000183D7E670
	
		// Methods
		public static implicit operator double3(double v) => default; // 0x0000000183D7A0C0-0x0000000183D7A0D0
		public static implicit operator double3(int v) => default; // 0x0000000183D7A180-0x0000000183D7A1B0
		public static implicit operator double3(int3 v) => default; // 0x0000000183D7A020-0x0000000183D7A070
		public static implicit operator double3(uint v) => default; // 0x0000000183D7A070-0x0000000183D7A0A0
		public static implicit operator double3(uint3 v) => default; // 0x0000000183D7A0F0-0x0000000183D7A150
		public static implicit operator double3(float v) => default; // 0x0000000183D79FF0-0x0000000183D7A020
		public static implicit operator double3(float3 v) => default; // 0x000000018337F9A0-0x000000018337F9E0
		public static double3 operator *(double3 lhs, double3 rhs) => default; // 0x0000000183D7E8A0-0x0000000183D7E8E0
		public static double3 operator *(double3 lhs, double rhs) => default; // 0x0000000183D7E880-0x0000000183D7E8A0
		public static double3 operator *(double lhs, double3 rhs) => default; // 0x0000000183D7E860-0x0000000183D7E880
		public static double3 operator +(double3 lhs, double3 rhs) => default; // 0x0000000183D7E820-0x0000000183D7E860
		public static double3 operator +(double3 lhs, double rhs) => default; // 0x0000000183D7E800-0x0000000183D7E820
		public static double3 operator -(double3 lhs, double3 rhs) => default; // 0x0000000183D7E900-0x0000000183D7E940
		public static double3 operator -(double3 lhs, double rhs) => default; // 0x0000000183D7E8E0-0x0000000183D7E900
		public static double3 operator -(double lhs, double3 rhs) => default; // 0x0000000183D7E940-0x0000000183D7E970
		public static double3 operator /(double3 lhs, double3 rhs) => default; // 0x0000000189C62910-0x0000000189C62944
		public static double3 operator /(double3 lhs, double rhs) => default; // 0x0000000189C62944-0x0000000189C62964
		public static double3 operator /(double lhs, double3 rhs) => default; // 0x0000000189C62964-0x0000000189C62990
		public static bool3 operator <(double3 lhs, double rhs) => default; // 0x0000000189C62A4C-0x0000000189C62A70
		public static bool3 operator <=(double3 lhs, double3 rhs) => default; // 0x0000000189C62A10-0x0000000189C62A4C
		public static bool3 operator >=(double3 lhs, double3 rhs) => default; // 0x0000000189C629D8-0x0000000189C62A10
		public static double3 operator -(double3 val) => default; // 0x0000000183D7E970-0x0000000183D7E9A0
		public static bool3 operator ==(double3 lhs, double rhs) => default; // 0x0000000189C62990-0x0000000189C629D8
		public bool Equals(double3 rhs) => default; // 0x00000001854F18F8-0x00000001854F1BE0
		public override bool Equals(object o) => default; // 0x0000000189C62660-0x0000000189C626D4
		public override int GetHashCode() => default; // 0x0000000189C626D4-0x0000000189C626FC
		public override string ToString() => default; // 0x0000000189C627AC-0x0000000189C6286C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C626FC-0x0000000189C627AC
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double3x2 : IEquatable<Unity.Mathematics.double3x2>, IFormattable // TypeDefIndex: 53725
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
	
		// Constructors
		public double3x2(double3 c0, double3 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D6B590-0x0000000183D6B5C0
		public double3x2(double m00, double m01, double m10, double m11, double m20, double m21) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7E9E0-0x0000000183D7EA20
		public double3x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7EA80-0x0000000183D7EAB0
		public double3x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D25C14-0x0000000184D25CE8
		public double3x2(bool3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C62EB0-0x0000000189C62FB4
		public double3x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7EAB0-0x0000000183D7EB00
		public double3x2(int3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D25CE8-0x0000000184D25D60
		public double3x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7EA20-0x0000000183D7EA80
		public double3x2(uint3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D25A1C-0x0000000184D25A94
		public double3x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7E9A0-0x0000000183D7E9E0
		public double3x2(float3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D25A94-0x0000000184D25C14
	
		// Methods
		public static implicit operator double3x2(int v) => default; // 0x0000000189C3120C-0x0000000189C3122C
		public static implicit operator double3x2(float3x2 v) => default; // 0x0000000189C310B8-0x0000000189C310F4
		public static double3x2 operator *(double3x2 lhs, double rhs) => default; // 0x0000000189C6310C-0x0000000189C63190
		public static double3x2 operator +(double3x2 lhs, double3x2 rhs) => default; // 0x0000000189C62FB4-0x0000000189C63078
		public static double3x2 operator -(double3x2 lhs, double3x2 rhs) => default; // 0x0000000189C63190-0x0000000189C63254
		public static double3x2 operator /(double3x2 lhs, double rhs) => default; // 0x0000000189C63078-0x0000000189C6310C
		public bool Equals(double3x2 rhs) => default; // 0x0000000185538B4C-0x0000000185538BBC
		public override bool Equals(object o) => default; // 0x0000000189C62A70-0x0000000189C62AEC
		public override int GetHashCode() => default; // 0x0000000189C62AEC-0x0000000189C62B1C
		public override string ToString() => default; // 0x0000000189C62CD0-0x0000000189C62EB0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C62B1C-0x0000000189C62CD0
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct double3x3 : IEquatable<Unity.Mathematics.double3x3>, IFormattable // TypeDefIndex: 53726
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
		public double3 c2; // 0x30
		public static readonly double3x3 identity; // 0x00
	
		// Properties
		public ref double3 this[int index] { get => default; } // 0x0000000183D7ED40-0x0000000183D7ED50 
	
		// Constructors
		public double3x3(double3 c0, double3 c1, double3 c2) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D7EB60-0x0000000183D7EBA0
		public double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7ECE0-0x0000000183D7ED40
		public double3x3(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7EBA0-0x0000000183D7EBE0
		public double3x3(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D260C8-0x0000000184D263CC
		public double3x3(bool3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C6388C-0x0000000189C639F8
		public double3x3(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7EC70-0x0000000183D7ECE0
		public double3x3(int3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D26020-0x0000000184D260C8
		public double3x3(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7EBE0-0x0000000183D7EC70
		public double3x3(uint3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D25F78-0x0000000184D26020
		public double3x3(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7EB00-0x0000000183D7EB60
		public double3x3(float3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D25D60-0x0000000184D25F78
		static double3x3() {
			identity = default;
		} // 0x0000000183B5BB30-0x0000000183B5BC00
	
		// Methods
		public static double3x3 operator *(double3x3 lhs, double rhs) => default; // 0x0000000189C639F8-0x0000000189C63ABC
		public bool Equals(double3x3 rhs) => default; // 0x0000000189C632E8-0x0000000189C6337C
		public override bool Equals(object o) => default; // 0x0000000189C63254-0x0000000189C632E8
		public override int GetHashCode() => default; // 0x0000000189C6337C-0x0000000189C633C0
		public override string ToString() => default; // 0x0000000189C633C0-0x0000000189C63648
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C63648-0x0000000189C6388C
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct double3x4 : IEquatable<Unity.Mathematics.double3x4>, IFormattable // TypeDefIndex: 53727
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
		public double3 c2; // 0x30
		public double3 c3; // 0x48
	
		// Properties
		public ref double3 this[int index] { get => default; } // 0x0000000183D7ED40-0x0000000183D7ED50 
	
		// Constructors
		public double3x4(double3 c0, double3 c1, double3 c2, double3 c3) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D7ED50-0x0000000183D7EDA0
		public double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7EDA0-0x0000000183D7EE20
		public double3x4(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7EF60-0x0000000183D7EFB0
		public double3x4(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D26584-0x0000000184D26700
		public double3x4(bool3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C64294-0x0000000189C6446C
		public double3x4(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7EE20-0x0000000183D7EEA0
		public double3x4(int3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D264A8-0x0000000184D26584
		public double3x4(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7EEA0-0x0000000183D7EF60
		public double3x4(uint3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D263CC-0x0000000184D264A8
		public double3x4(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7EFB0-0x0000000183D7F030
		public double3x4(float3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D26700-0x0000000184D267DC
	
		// Methods
		public static implicit operator double3x4(int v) => default; // 0x0000000189C31424-0x0000000189C31450
		public bool Equals(double3x4 rhs) => default; // 0x0000000189C63ABC-0x0000000189C63BA4
		public override bool Equals(object o) => default; // 0x0000000189C63BA4-0x0000000189C63C44
		public override int GetHashCode() => default; // 0x0000000189C63C44-0x0000000189C63C90
		public override string ToString() => default; // 0x0000000189C63F64-0x0000000189C64294
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C63C90-0x0000000189C63F64
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct double4 : IEquatable<Unity.Mathematics.double4>, IFormattable // TypeDefIndex: 53729
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
		public double w; // 0x18
		public static readonly double4 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public double3 xyz { get => default; set {} } // 0x0000000183D7F230-0x0000000183D7F250 0x0000000183D7E710-0x0000000183D7E730
		public double this[int index] { get => default; set {} } // 0x0000000183D7E7B0-0x0000000183D7E7C0 0x0000000183D7F3E0-0x0000000183D7F3F0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53728
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public double4(double x, double y, double z, double w) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D7F0F0-0x0000000183D7F110
		public double4(double x, double y, double2 zw) : this() {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000183D7F070-0x0000000183D7F090
		public double4(double x, double2 yz, double w) : this() {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D7F090-0x0000000183D7F0B0
		public double4(double x, double3 yzw) : this() {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7F0D0-0x0000000183D7F0F0
		public double4(double2 xy, double z, double w) : this() {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D7F1D0-0x0000000183D7F1F0
		public double4(double2 xy, double2 zw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7F0B0-0x0000000183D7F0D0
		public double4(double3 xyz, double w) : this() {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D7F1B0-0x0000000183D7F1D0
		public double4(double4 xyzw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7F050-0x0000000183D7F070
		public double4(double v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7F1F0-0x0000000183D7F200
		public double4(bool v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000184D26850-0x0000000184D26894
		public double4(bool4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000184D268F8-0x0000000184D26CA8
		public double4(int v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7F110-0x0000000183D7F140
		public double4(int4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7F190-0x0000000183D7F1B0
		public double4(uint v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7F200-0x0000000183D7F230
		public double4(uint4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7F140-0x0000000183D7F180
		public double4(half v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000184D26894-0x0000000184D268F8
		public double4(half4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000184D267DC-0x0000000184D26850
		public double4(float v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7F030-0x0000000183D7F050
		public double4(float4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D7F180-0x0000000183D7F190
	
		// Methods
		public static implicit operator double4(double v) => default; // 0x0000000183D7A2D0-0x0000000183D7A2E0
		public static implicit operator double4(int v) => default; // 0x0000000183D7A330-0x0000000183D7A370
		public static implicit operator double4(int4 v) => default; // 0x0000000189C31698-0x0000000189C316C0
		public static implicit operator double4(uint v) => default; // 0x0000000183D7A3F0-0x0000000183D7A420
		public static implicit operator double4(uint4 v) => default; // 0x0000000189C316C0-0x0000000189C316E8
		public static implicit operator double4(float v) => default; // 0x0000000183D7A2E0-0x0000000183D7A300
		public static implicit operator double4(float4 v) => default; // 0x0000000189C31654-0x0000000189C3167C
		public static double4 operator *(double4 lhs, double4 rhs) => default; // 0x0000000183D7F2C0-0x0000000183D7F310
		public static double4 operator *(double4 lhs, double rhs) => default; // 0x0000000183D7F2A0-0x0000000183D7F2C0
		public static double4 operator *(double lhs, double4 rhs) => default; // 0x0000000183D7F310-0x0000000183D7F330
		public static double4 operator +(double4 lhs, double4 rhs) => default; // 0x0000000183D7F250-0x0000000183D7F2A0
		public static double4 operator -(double4 lhs, double4 rhs) => default; // 0x0000000183D7F370-0x0000000183D7F3C0
		public static double4 operator -(double lhs, double4 rhs) => default; // 0x0000000183D7F330-0x0000000183D7F370
		public static double4 operator /(double4 lhs, double4 rhs) => default; // 0x0000000189C6480C-0x0000000189C64850
		public static double4 operator /(double lhs, double4 rhs) => default; // 0x0000000189C64850-0x0000000189C64888
		public static bool4 operator <(double4 lhs, double rhs) => default; // 0x0000000189C64934-0x0000000189C64960
		public static bool4 operator >=(double4 lhs, double4 rhs) => default; // 0x0000000189C648EC-0x0000000189C64934
		public static double4 operator -(double4 val) => default; // 0x0000000183D7F3C0-0x0000000183D7F3E0
		public static bool4 operator ==(double4 lhs, double rhs) => default; // 0x0000000189C64888-0x0000000189C648EC
		public bool Equals(double4 rhs) => default; // 0x0000000189C644E0-0x0000000189C64528
		public override bool Equals(object o) => default; // 0x0000000189C6446C-0x0000000189C644E0
		public override int GetHashCode() => default; // 0x0000000189C64528-0x0000000189C6454C
		public override string ToString() => default; // 0x0000000189C6454C-0x0000000189C646B8
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C646B8-0x0000000189C6480C
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double4x2 : IEquatable<Unity.Mathematics.double4x2>, IFormattable // TypeDefIndex: 53730
	{
		// Fields
		public double4 c0; // 0x00
		public double4 c1; // 0x20
	
		// Constructors
		public double4x2(double4 c0, double4 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D7F4B0-0x0000000183D7F4D0
		public double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7F3F0-0x0000000183D7F440
		public double4x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7F440-0x0000000183D7F470
		public double4x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D26DF4-0x0000000184D270A4
		public double4x2(bool4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D26D50-0x0000000184D26DF4
		public double4x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7F4D0-0x0000000183D7F520
		public double4x2(int4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C64EE4-0x0000000189C64F48
		public double4x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D26CA8-0x0000000184D26D50
		public double4x2(uint4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C64F48-0x0000000189C64FAC
		public double4x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7F470-0x0000000183D7F4B0
		public double4x2(float4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C64FAC-0x0000000189C65010
	
		// Methods
		public bool Equals(double4x2 rhs) => default; // 0x0000000189C649E4-0x0000000189C64A48
		public override bool Equals(object o) => default; // 0x0000000189C64960-0x0000000189C649E4
		public override int GetHashCode() => default; // 0x0000000189C64A48-0x0000000189C64A80
		public override string ToString() => default; // 0x0000000189C64C94-0x0000000189C64EE4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C64A80-0x0000000189C64C94
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double4x3 : IEquatable<Unity.Mathematics.double4x3>, IFormattable // TypeDefIndex: 53731
	{
		// Fields
		public double4 c0; // 0x00
		public double4 c1; // 0x20
		public double4 c2; // 0x40
	
		// Constructors
		public double4x3(double4 c0, double4 c1, double4 c2) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D7F6D0-0x0000000183D7F710
		public double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7F5D0-0x0000000183D7F660
		public double4x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7F520-0x0000000183D7F570
		public double4x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D271D8-0x0000000184D27390
		public double4x3(bool4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D27100-0x0000000184D271D8
		public double4x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7F660-0x0000000183D7F6D0
		public double4x3(int4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C65810-0x0000000189C658A0
		public double4x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D270A4-0x0000000184D27100
		public double4x3(uint4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C658A0-0x0000000189C65930
		public double4x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7F570-0x0000000183D7F5D0
		public double4x3(float4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C65780-0x0000000189C65810
	
		// Methods
		public static implicit operator double4x3(int v) => default; // 0x0000000189C318F8-0x0000000189C31924
		public static implicit operator double4x3(float4x3 v) => default; // 0x0000000189C319FC-0x0000000189C31A4C
		public static double4x3 operator *(double4x3 lhs, double4x3 rhs) => default; // 0x0000000189C65930-0x0000000189C65A38
		public bool Equals(double4x3 rhs) => default; // 0x0000000189C65010-0x0000000189C65090
		public override bool Equals(object o) => default; // 0x0000000189C65090-0x0000000189C65130
		public override int GetHashCode() => default; // 0x0000000189C65130-0x0000000189C6517C
		public override string ToString() => default; // 0x0000000189C65450-0x0000000189C65780
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C6517C-0x0000000189C65450
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct double4x4 : IEquatable<Unity.Mathematics.double4x4>, IFormattable // TypeDefIndex: 53732
	{
		// Fields
		public double4 c0; // 0x00
		public double4 c1; // 0x20
		public double4 c2; // 0x40
		public double4 c3; // 0x60
		public static readonly double4x4 identity; // 0x00
		public static readonly double4x4 zero; // 0x80
	
		// Constructors
		public double4x4(double4 c0, double4 c1, double4 c2, double4 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D7F7E0-0x0000000183D7F830
		public double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183A37140-0x0000000183A37210
		public double4x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7F780-0x0000000183D7F7E0
		public double4x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D27390-0x0000000184D273F8
		public double4x4(bool4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D27470-0x0000000184D27638
		public double4x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7F830-0x0000000183D7F8C0
		public double4x4(int4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C664FC-0x0000000189C665B0
		public double4x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D273F8-0x0000000184D27470
		public double4x4(uint4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C66448-0x0000000189C664FC
		public double4x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7F710-0x0000000183D7F780
		public double4x4(float4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C66394-0x0000000189C66448
		static double4x4() {
			identity = default;
			zero = default;
		} // 0x0000000183A37010-0x0000000183A37140
	
		// Methods
		public static implicit operator double4x4(float4x4 v) => default; // 0x0000000189C31BA4-0x0000000189C31C00
		public bool Equals(double4x4 rhs) => default; // 0x0000000189C65A38-0x0000000189C65ADC
		public override bool Equals(object o) => default; // 0x0000000189C65ADC-0x0000000189C65B94
		public override int GetHashCode() => default; // 0x0000000189C65B94-0x0000000189C65BF0
		public override string ToString() => default; // 0x0000000189C65F84-0x0000000189C66394
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C65BF0-0x0000000189C65F84
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float2 : IEquatable<Unity.Mathematics.float2>, IFormattable // TypeDefIndex: 53734
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public static readonly float2 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxy { get => default; } // 0x0000000183D7F9D0-0x0000000183D7F9F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy { get => default; } // 0x0000000183D51540-0x0000000183D51560 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yx { get => default; } // 0x0000000183D7F9F0-0x0000000183D7FA10 
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53733
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public float2(float x, float y) : this() {
			this.x = default;
			this.y = default;
		} // 0x0000000183D50430-0x0000000183D50440
		public float2(float2 xy) : this() {
			x = default;
			y = default;
		} // 0x0000000183D7F900-0x0000000183D7F920
		public float2(float v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D7F8C0-0x0000000183D7F8D0
		public float2(bool v) : this() {
			x = default;
			y = default;
		} // 0x0000000189C6676C-0x0000000189C66788
		public float2(bool2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000184D27638-0x0000000184D276F0
		public float2(int v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D7F970-0x0000000183D7F990
		public float2(int2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D7F950-0x0000000183D7F970
		public float2(uint v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D7F920-0x0000000183D7F950
		public float2(uint2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D7F8D0-0x0000000183D7F900
		public float2(half v) : this() {
			x = default;
			y = default;
		} // 0x0000000189C66788-0x0000000189C667B4
		public float2(half2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000189C667B4-0x0000000189C667E4
		public float2(double v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D7F990-0x0000000183D7F9B0
		public float2(double2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D7F9B0-0x0000000183D7F9D0
	
		// Methods
		public static implicit operator float2(float v) => default; // 0x0000000183D543C0-0x0000000183D543D0
		public static implicit operator float2(int v) => default; // 0x0000000183D7A730-0x0000000183D7A750
		public static implicit operator float2(int2 v) => default; // 0x0000000183D7A750-0x0000000183D7A770
		public static implicit operator float2(uint v) => default; // 0x0000000183D7A7A0-0x0000000183D7A7D0
		public static implicit operator float2(uint2 v) => default; // 0x0000000183D7A770-0x0000000183D7A7A0
		public static explicit operator float2(double v) => default; // 0x0000000183D7A7D0-0x0000000183D7A7F0
		public static explicit operator float2(double2 v) => default; // 0x0000000183D7A700-0x0000000183D7A720
		public static float2 operator *(float2 lhs, float2 rhs) => default; // 0x0000000183D734A0-0x0000000183D734E0
		public static float2 operator *(float2 lhs, float rhs) => default; // 0x0000000183D73470-0x0000000183D734A0
		public static float2 operator *(float lhs, float2 rhs) => default; // 0x0000000183D7FA60-0x0000000183D7FA90
		public static float2 operator +(float2 lhs, float2 rhs) => default; // 0x0000000183D73400-0x0000000183D73440
		public static float2 operator +(float2 lhs, float rhs) => default; // 0x0000000183D73440-0x0000000183D73470
		public static float2 operator -(float2 lhs, float2 rhs) => default; // 0x0000000183D73510-0x0000000183D73550
		public static float2 operator -(float2 lhs, float rhs) => default; // 0x0000000183D734E0-0x0000000183D73510
		public static float2 operator -(float lhs, float2 rhs) => default; // 0x0000000183D7FA90-0x0000000183D7FAB0
		public static float2 operator /(float2 lhs, float2 rhs) => default; // 0x000000018950B3B4-0x000000018950B3E8
		public static float2 operator /(float2 lhs, float rhs) => default; // 0x000000018950B8A0-0x000000018950B8C4
		public static float2 operator /(float lhs, float2 rhs) => default; // 0x0000000189C667E4-0x0000000189C66804
		public static float2 operator %(float2 lhs, float rhs) => default; // 0x0000000183D7FA10-0x0000000183D7FA60
		public static bool2 operator <(float2 lhs, float rhs) => default; // 0x0000000189C668AC-0x0000000189C668D0
		public static bool2 operator <=(float2 lhs, float2 rhs) => default; // 0x0000000189C66874-0x0000000189C668AC
		public static bool2 operator >=(float2 lhs, float2 rhs) => default; // 0x0000000189C6683C-0x0000000189C66874
		public static float2 operator -(float2 val) => default; // 0x0000000183D7FAB0-0x0000000183D7FAE0
		public static bool2 operator ==(float2 lhs, float rhs) => default; // 0x0000000189C66804-0x0000000189C6683C
		public bool Equals(float2 rhs) => default; // 0x000000018950B3E8-0x000000018950B410
		public override bool Equals(object o) => default; // 0x0000000189C665B0-0x0000000189C66620
		public override int GetHashCode() => default; // 0x0000000189C66620-0x0000000189C66654
		public override string ToString() => default; // 0x0000000189C666DC-0x0000000189C6676C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C66654-0x0000000189C666DC
		public static implicit operator Vector2(float2 v) => default; // 0x0000000183D730E0-0x0000000183D73100
		public static implicit operator float2(Vector2 v) => default; // 0x0000000183D730E0-0x0000000183D73100
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float2x2 : IEquatable<Unity.Mathematics.float2x2>, IFormattable // TypeDefIndex: 53735
	{
		// Fields
		public float2 c0; // 0x00
		public float2 c1; // 0x08
		public static readonly float2x2 identity; // 0x00
	
		// Constructors
		public float2x2(float2 c0, float2 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D4EA10-0x0000000183D4EA20
		public float2x2(float m00, float m01, float m10, float m11) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7FBC0-0x0000000183D7FBE0
		public float2x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7FB70-0x0000000183D7FB90
		public float2x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D276F0-0x0000000184D278AC
		public float2x2(bool2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C66C54-0x0000000189C66CD0
		public float2x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7FB90-0x0000000183D7FBC0
		public float2x2(int2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7FC20-0x0000000183D7FC60
		public float2x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7FC60-0x0000000183D7FCB0
		public float2x2(uint2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7FAE0-0x0000000183D7FB40
		public float2x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7FB40-0x0000000183D7FB70
		public float2x2(double2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D7FBE0-0x0000000183D7FC20
		static float2x2() {
			identity = default;
		} // 0x0000000183CF6AF0-0x0000000183CF6B60
	
		// Methods
		public static float2x2 operator *(float2x2 lhs, float rhs) => default; // 0x0000000189C66CD0-0x0000000189C66D3C
		public bool Equals(float2x2 rhs) => default; // 0x0000000189C668D0-0x0000000189C6690C
		public override bool Equals(object o) => default; // 0x0000000189C6690C-0x0000000189C66978
		public override int GetHashCode() => default; // 0x0000000189C66978-0x0000000189C66994
		public override string ToString() => default; // 0x0000000189C66AE8-0x0000000189C66C54
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C66994-0x0000000189C66AE8
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float2x3 : IEquatable<Unity.Mathematics.float2x3>, IFormattable // TypeDefIndex: 53736
	{
		// Fields
		public float2 c0; // 0x00
		public float2 c1; // 0x08
		public float2 c2; // 0x10
	
		// Constructors
		public float2x3(float2 c0, float2 c1, float2 c2) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D54CF0-0x0000000183D54D00
		public float2x3(float m00, float m01, float m02, float m10, float m11, float m12) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7FE00-0x0000000183D7FE30
		public float2x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7FE80-0x0000000183D7FEA0
		public float2x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D278AC-0x0000000184D27A2C
		public float2x3(bool2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C671E8-0x0000000189C672A0
		public float2x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7FF10-0x0000000183D7FF60
		public float2x3(int2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7FDA0-0x0000000183D7FE00
		public float2x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7FEA0-0x0000000183D7FF10
		public float2x3(uint2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7FD10-0x0000000183D7FDA0
		public float2x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7FE30-0x0000000183D7FE80
		public float2x3(double2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D7FCB0-0x0000000183D7FD10
	
		// Methods
		public bool Equals(float2x3 rhs) => default; // 0x0000000189C66DB0-0x0000000189C66E2C
		public override bool Equals(object o) => default; // 0x0000000189C66D3C-0x0000000189C66DB0
		public override int GetHashCode() => default; // 0x0000000189C66E2C-0x0000000189C66E54
		public override string ToString() => default; // 0x0000000189C66E54-0x0000000189C67034
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C67034-0x0000000189C671E8
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float2x4 : IEquatable<Unity.Mathematics.float2x4>, IFormattable // TypeDefIndex: 53737
	{
		// Fields
		public float2 c0; // 0x00
		public float2 c1; // 0x08
		public float2 c2; // 0x10
		public float2 c3; // 0x18
	
		// Constructors
		public float2x4(float2 c0, float2 c1, float2 c2, float2 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D548D0-0x0000000183D548F0
		public float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7FF60-0x0000000183D7FFB0
		public float2x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D80020-0x0000000183D80040
		public float2x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D27A2C-0x0000000184D27B9C
		public float2x4(bool2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C67824-0x0000000189C67920
		public float2x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D80290-0x0000000183D802F0
		public float2x4(int2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D80040-0x0000000183D800C0
		public float2x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D801F0-0x0000000183D80290
		public float2x4(uint2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D800C0-0x0000000183D80180
		public float2x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D80180-0x0000000183D801F0
		public float2x4(double2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D7FFB0-0x0000000183D80020
	
		// Methods
		public bool Equals(float2x4 rhs) => default; // 0x0000000189C672A0-0x0000000189C67328
		public override bool Equals(object o) => default; // 0x0000000189C67328-0x0000000189C6739C
		public override int GetHashCode() => default; // 0x0000000189C6739C-0x0000000189C673C0
		public override string ToString() => default; // 0x0000000189C675D4-0x0000000189C67824
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C673C0-0x0000000189C675D4
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct float3 : IEquatable<Unity.Mathematics.float3>, IFormattable // TypeDefIndex: 53739
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public static readonly float3 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxx { get => default; } // 0x0000000183D804B0-0x0000000183D804D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxy { get => default; } // 0x0000000183D804D0-0x0000000183D804F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxz { get => default; } // 0x0000000183D804F0-0x0000000183D80510 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyx { get => default; } // 0x0000000183D80530-0x0000000183D80550 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyy { get => default; } // 0x0000000183D80550-0x0000000183D80570 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyz { get => default; } // 0x0000000183D80570-0x0000000183D80590 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzx { get => default; } // 0x0000000183D805B0-0x0000000183D805D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzy { get => default; } // 0x0000000183D805D0-0x0000000183D805F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzz { get => default; } // 0x0000000183D805F0-0x0000000183D80610 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxx { get => default; } // 0x0000000183D80630-0x0000000183D80650 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxy { get => default; } // 0x0000000183D7F9D0-0x0000000183D7F9F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxz { get => default; } // 0x0000000183D80650-0x0000000183D80670 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyx { get => default; } // 0x0000000183D80690-0x0000000183D806B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyy { get => default; } // 0x0000000183D806B0-0x0000000183D806D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyz { get => default; } // 0x0000000183D806D0-0x0000000183D806F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzx { get => default; } // 0x00000001828B4690-0x00000001828B46B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzy { get => default; } // 0x0000000183D806F0-0x0000000183D80710 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzz { get => default; } // 0x0000000183D80710-0x0000000183D80730 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxx { get => default; } // 0x0000000183D80750-0x0000000183D80770 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxy { get => default; } // 0x0000000183D80770-0x0000000183D80790 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxz { get => default; } // 0x0000000183D80790-0x0000000183D807B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyx { get => default; } // 0x0000000183D807D0-0x0000000183D807F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyy { get => default; } // 0x0000000183D807F0-0x0000000183D80810 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyz { get => default; } // 0x0000000183D80810-0x0000000183D80830 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzx { get => default; } // 0x0000000183D80850-0x0000000183D80870 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzy { get => default; } // 0x0000000183D80870-0x0000000183D80890 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzz { get => default; } // 0x0000000183D80890-0x0000000183D808B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxx { get => default; } // 0x0000000183D808D0-0x0000000183D808F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxy { get => default; } // 0x0000000183D808F0-0x0000000183D80910 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxz { get => default; } // 0x0000000183D80910-0x0000000183D80930 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyx { get => default; } // 0x0000000183D80950-0x0000000183D80970 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyy { get => default; } // 0x0000000183D80970-0x0000000183D80990 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyz { get => default; } // 0x0000000183D80990-0x0000000183D809B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzx { get => default; } // 0x0000000183D809D0-0x0000000183D809F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzy { get => default; } // 0x0000000183D809F0-0x0000000183D80A10 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzz { get => default; } // 0x0000000183D80A10-0x0000000183D80A30 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxx { get => default; } // 0x0000000183D80A70-0x0000000183D80A90 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxy { get => default; } // 0x0000000183D80A90-0x0000000183D80AB0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxz { get => default; } // 0x0000000183D80AB0-0x0000000183D80AD0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyx { get => default; } // 0x0000000183D80AE0-0x0000000183D80B00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyy { get => default; } // 0x0000000183D80B00-0x0000000183D80B20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyz { get => default; } // 0x0000000183D80B20-0x0000000183D80B40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzx { get => default; } // 0x0000000183D80B60-0x0000000183D80B80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzy { get => default; } // 0x0000000183D80B80-0x0000000183D80BA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzz { get => default; } // 0x0000000183D80BA0-0x0000000183D80BC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxx { get => default; } // 0x0000000183D80BE0-0x0000000183D80C00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxy { get => default; } // 0x00000001828B46B0-0x00000001828B46D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxz { get => default; } // 0x00000001828B4710-0x00000001828B4730 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyx { get => default; } // 0x0000000183D80C20-0x0000000183D80C40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyy { get => default; } // 0x0000000183D80C40-0x0000000183D80C60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyz { get => default; } // 0x0000000183D80C60-0x0000000183D80C80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzx { get => default; } // 0x0000000183D80CA0-0x0000000183D80CC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzy { get => default; } // 0x0000000183D80CC0-0x0000000183D80CE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzz { get => default; } // 0x0000000183D80CE0-0x0000000183D80D00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxx { get => default; } // 0x0000000183D80D40-0x0000000183D80D60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxy { get => default; } // 0x0000000183D80D60-0x0000000183D80D80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxz { get => default; } // 0x0000000183D80D80-0x0000000183D80DA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyx { get => default; } // 0x0000000183D80DC0-0x0000000183D80DE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyy { get => default; } // 0x00000001828B46D0-0x00000001828B46F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyz { get => default; } // 0x00000001828B46F0-0x00000001828B4710 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzx { get => default; } // 0x0000000183D80E00-0x0000000183D80E20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzy { get => default; } // 0x0000000183D80E20-0x0000000183D80E40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzz { get => default; } // 0x0000000183D80E40-0x0000000183D80E60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxx { get => default; } // 0x0000000183D80EA0-0x0000000183D80EC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxy { get => default; } // 0x0000000183D80EC0-0x0000000183D80EE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxz { get => default; } // 0x0000000183D80EE0-0x0000000183D80F00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyx { get => default; } // 0x0000000183D80F20-0x0000000183D80F40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyy { get => default; } // 0x0000000183D80F40-0x0000000183D80F60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyz { get => default; } // 0x0000000183D80F60-0x0000000183D80F80 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzx { get => default; } // 0x0000000183D80FA0-0x0000000183D80FC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzy { get => default; } // 0x0000000183D80FC0-0x0000000183D80FE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzz { get => default; } // 0x0000000183D80FE0-0x0000000183D81000 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxx { get => default; } // 0x0000000183D81040-0x0000000183D81060 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxy { get => default; } // 0x0000000183D81060-0x0000000183D81080 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxz { get => default; } // 0x0000000183D81080-0x0000000183D810A0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyx { get => default; } // 0x0000000183D810C0-0x0000000183D810E0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyy { get => default; } // 0x0000000183D810E0-0x0000000183D81100 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyz { get => default; } // 0x0000000183D81100-0x0000000183D81120 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzx { get => default; } // 0x0000000183D81130-0x0000000183D81150 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzy { get => default; } // 0x0000000183D81150-0x0000000183D81170 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzz { get => default; } // 0x0000000183D81170-0x0000000183D81190 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxx { get => default; } // 0x0000000183D804A0-0x0000000183D804B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxy { get => default; } // 0x0000000183D80510-0x0000000183D80530 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxz { get => default; } // 0x0000000183D80590-0x0000000183D805B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyx { get => default; } // 0x0000000183D80610-0x0000000183D80630 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyy { get => default; } // 0x0000000183D80670-0x0000000183D80690 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyz { get => default; set {} } // 0x0000000183D514C0-0x0000000183D514E0 0x0000000183D51BE0-0x0000000183D51C00
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzx { get => default; } // 0x0000000183D80730-0x0000000183D80750 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzy { get => default; set {} } // 0x0000000183D807B0-0x0000000183D807D0 0x0000000183D81360-0x0000000183D81380
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzz { get => default; } // 0x0000000183D80830-0x0000000183D80850 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxx { get => default; } // 0x0000000183D808B0-0x0000000183D808D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxy { get => default; } // 0x0000000183D80930-0x0000000183D80950 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxz { get => default; set {} } // 0x0000000183D809B0-0x0000000183D809D0 0x0000000183D813A0-0x0000000183D813C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyx { get => default; } // 0x0000000183D80A50-0x0000000183D80A70 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyy { get => default; } // 0x0000000183D80AD0-0x0000000183D80AE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyz { get => default; } // 0x0000000183D80B40-0x0000000183D80B60 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzx { get => default; set {} } // 0x0000000183D80BC0-0x0000000183D80BE0 0x0000000183D813E0-0x0000000183D81400
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzy { get => default; } // 0x0000000183D80C00-0x0000000183D80C20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzz { get => default; } // 0x0000000183D80C80-0x0000000183D80CA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxx { get => default; } // 0x0000000183D80D20-0x0000000183D80D40 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxy { get => default; set {} } // 0x0000000183D80DA0-0x0000000183D80DC0 0x0000000183D81420-0x0000000183D81440
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxz { get => default; } // 0x0000000183D80DE0-0x0000000183D80E00 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyx { get => default; set {} } // 0x0000000183D80E80-0x0000000183D80EA0 0x0000000183D81460-0x0000000183D81480
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyy { get => default; } // 0x0000000183D80F00-0x0000000183D80F20 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyz { get => default; } // 0x0000000183D80F80-0x0000000183D80FA0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzx { get => default; } // 0x0000000183D81020-0x0000000183D81040 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzy { get => default; } // 0x0000000183D810A0-0x0000000183D810C0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzz { get => default; } // 0x0000000183D81120-0x0000000183D81130 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xx { get => default; } // 0x0000000183D80490-0x0000000183D804A0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy { get => default; set {} } // 0x0000000183D51540-0x0000000183D51560 0x0000000183D7F900-0x0000000183D7F920
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xz { get => default; set {} } // 0x0000000183D51590-0x0000000183D515B0 0x0000000183D81340-0x0000000183D81360
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yx { get => default; set {} } // 0x0000000183D7F9F0-0x0000000183D7FA10 0x0000000183D81380-0x0000000183D813A0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yy { get => default; } // 0x0000000183D80A30-0x0000000183D80A50 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yz { get => default; set {} } // 0x0000000183D54520-0x0000000183D54540 0x0000000183D813C0-0x0000000183D813E0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zx { get => default; set {} } // 0x0000000183D80D00-0x0000000183D80D20 0x0000000183D81400-0x0000000183D81420
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zy { get => default; set {} } // 0x0000000183D80E60-0x0000000183D80E80 0x0000000183D81440-0x0000000183D81460
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zz { get => default; } // 0x0000000183D81000-0x0000000183D81020 
		public float this[int index] { get => default; set {} } // 0x0000000183D80480-0x0000000183D80490 0x0000000183D81330-0x0000000183D81340
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53738
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public float3(float x, float y, float z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000183D51BD0-0x0000000183D51BE0
		public float3(float x, float2 yz) : this() {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000183D80430-0x0000000183D80450
		public float3(float2 xy, float z) : this() {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000183D80360-0x0000000183D80380
		public float3(float3 xyz) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D51BE0-0x0000000183D51C00
		public float3(float v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D803F0-0x0000000183D80400
		public float3(bool v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000184D27B9C-0x0000000184D27BD0
		public float3(bool3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000184D27BD0-0x0000000184D27C0C
		public float3(int v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D802F0-0x0000000183D80320
		public float3(int3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D80400-0x0000000183D80430
		public float3(uint v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D80380-0x0000000183D803C0
		public float3(uint3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D80320-0x0000000183D80360
		public float3(half v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C67B64-0x0000000189C67BA0
		public float3(half3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C67B28-0x0000000189C67B64
		public float3(double v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D803C0-0x0000000183D803F0
		public float3(double3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D80450-0x0000000183D80480
	
		// Methods
		public static implicit operator float3(float v) => default; // 0x0000000183D54500-0x0000000183D54520
		public static explicit operator float3(bool v) => default; // 0x0000000189C34284-0x0000000189C342A0
		public static explicit operator float3(bool3 v) => default; // 0x0000000189C34328-0x0000000189C34358
		public static implicit operator float3(int v) => default; // 0x0000000183D7A860-0x0000000183D7A890
		public static implicit operator float3(int3 v) => default; // 0x0000000183D7A9F0-0x0000000183D7AA40
		public static implicit operator float3(uint v) => default; // 0x0000000183D7A9B0-0x0000000183D7A9F0
		public static implicit operator float3(uint3 v) => default; // 0x0000000183D7A920-0x0000000183D7A980
		public static implicit operator float3(half v) => default; // 0x0000000189C342A0-0x0000000189C342DC
		public static implicit operator float3(half3 v) => default; // 0x0000000189C342DC-0x0000000189C34328
		public static explicit operator float3(double v) => default; // 0x0000000183D7A890-0x0000000183D7A8C0
		public static explicit operator float3(double3 v) => default; // 0x0000000183D7A820-0x0000000183D7A860
		public static float3 operator *(float3 lhs, float3 rhs) => default; // 0x0000000183D51660-0x0000000183D516A0
		public static float3 operator *(float3 lhs, float rhs) => default; // 0x00000001828B52E0-0x00000001828B5310
		public static float3 operator *(float lhs, float3 rhs) => default; // 0x00000001828B7A00-0x00000001828B7A30
		public static float3 operator +(float3 lhs, float3 rhs) => default; // 0x00000001828B7A70-0x00000001828B7AB0
		public static float3 operator +(float3 lhs, float rhs) => default; // 0x000000018333F750-0x000000018333F780
		public static float3 operator +(float lhs, float3 rhs) => default; // 0x0000000183D81190-0x0000000183D811C0
		public static float3 operator -(float3 lhs, float3 rhs) => default; // 0x00000001828B7A30-0x00000001828B7A70
		public static float3 operator -(float3 lhs, float rhs) => default; // 0x000000018333F780-0x000000018333F7B0
		public static float3 operator -(float lhs, float3 rhs) => default; // 0x0000000183D81300-0x0000000183D81330
		public static float3 operator /(float3 lhs, float3 rhs) => default; // 0x000000018950BFE0-0x000000018950C014
		public static float3 operator /(float3 lhs, float rhs) => default; // 0x00000001894FB6EC-0x00000001894FB718
		public static float3 operator /(float lhs, float3 rhs) => default; // 0x0000000189C67BA0-0x0000000189C67BCC
		public static float3 operator %(float3 lhs, float3 rhs) => default; // 0x0000000183D7AE80-0x0000000183D7AEF0
		public static float3 operator %(float3 lhs, float rhs) => default; // 0x0000000183D812A0-0x0000000183D81300
		public static float3 operator %(float lhs, float3 rhs) => default; // 0x0000000183D81240-0x0000000183D812A0
		public static float3 operator ++(float3 val) => default; // 0x0000000183D81200-0x0000000183D81240
		public static float3 operator --(float3 val) => default; // 0x0000000183D811C0-0x0000000183D81200
		public static bool3 operator <(float3 lhs, float3 rhs) => default; // 0x0000000189C67EE0-0x0000000189C67F14
		public static bool3 operator <(float3 lhs, float rhs) => default; // 0x0000000189C67F14-0x0000000189C6A134
		public static bool3 operator <(float lhs, float3 rhs) => default; // 0x0000000189C67EB0-0x0000000189C67EE0
		public static bool3 operator <=(float3 lhs, float3 rhs) => default; // 0x0000000189C67E1C-0x0000000189C67E54
		public static bool3 operator <=(float3 lhs, float rhs) => default; // 0x0000000189C67E88-0x0000000189C67EB0
		public static bool3 operator <=(float lhs, float3 rhs) => default; // 0x0000000189C67E54-0x0000000189C67E88
		public static bool3 operator >(float3 lhs, float3 rhs) => default; // 0x0000000189C67CDC-0x0000000189C67D10
		public static bool3 operator >(float3 lhs, float rhs) => default; // 0x0000000189C67D34-0x0000000189C67D60
		public static bool3 operator >(float lhs, float3 rhs) => default; // 0x0000000189C67D10-0x0000000189C67D34
		public static bool3 operator >=(float3 lhs, float3 rhs) => default; // 0x0000000189C67C50-0x0000000189C67C84
		public static bool3 operator >=(float3 lhs, float rhs) => default; // 0x0000000189C67C84-0x0000000189C67CB4
		public static bool3 operator >=(float lhs, float3 rhs) => default; // 0x0000000189C67CB4-0x0000000189C67CDC
		public static float3 operator -(float3 val) => default; // 0x0000000182E241C0-0x0000000182E24200
		public static float3 operator +(float3 val) => default; // 0x0000000183D514C0-0x0000000183D514E0
		public static bool3 operator ==(float3 lhs, float3 rhs) => default; // 0x0000000189C67BCC-0x0000000189C67C14
		public static bool3 operator ==(float3 lhs, float rhs) => default; // 0x0000000184D27C0C-0x0000000184D27D00
		public static bool3 operator ==(float lhs, float3 rhs) => default; // 0x0000000189C67C14-0x0000000189C67C50
		public static bool3 operator !=(float3 lhs, float3 rhs) => default; // 0x0000000189C67D98-0x0000000189C67DDC
		public static bool3 operator !=(float3 lhs, float rhs) => default; // 0x0000000189C67DDC-0x0000000189C67E1C
		public static bool3 operator !=(float lhs, float3 rhs) => default; // 0x0000000189C67D60-0x0000000189C67D98
		public bool Equals(float3 rhs) => default; // 0x0000000182799940-0x0000000182799970
		public override bool Equals(object o) => default; // 0x0000000189C67920-0x0000000189C67994
		public override int GetHashCode() => default; // 0x0000000189C67994-0x0000000189C679B8
		public override string ToString() => default; // 0x0000000189C679B8-0x0000000189C67A78
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C67A78-0x0000000189C67B28
		public static implicit operator Vector3(float3 v) => default; // 0x0000000183D514C0-0x0000000183D514E0
		public static implicit operator float3(Vector3 v) => default; // 0x0000000183D514C0-0x0000000183D514E0
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float3x2 : IEquatable<Unity.Mathematics.float3x2>, IFormattable // TypeDefIndex: 53740
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
	
		// Constructors
		public float3x2(float3 c0, float3 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D4FF30-0x0000000183D4FF50
		public float3x2(float m00, float m01, float m10, float m11, float m20, float m21) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D814F0-0x0000000183D81520
		public float3x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D814D0-0x0000000183D814F0
		public float3x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D27D00-0x0000000184D27E2C
		public float3x2(bool3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C6DB28-0x0000000189C6DBF8
		public float3x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D81480-0x0000000183D814D0
		public float3x2(int3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D27EA0-0x0000000184D27F14
		public float3x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D81520-0x0000000183D81590
		public float3x2(uint3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D27E2C-0x0000000184D27EA0
		public float3x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D81590-0x0000000183D815E0
		public float3x2(double3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C6DAB0-0x0000000189C6DB28
	
		// Methods
		public static float3x2 operator *(float3x2 lhs, float rhs) => default; // 0x0000000189C6DBF8-0x0000000189C6DC7C
		public bool Equals(float3x2 rhs) => default; // 0x0000000189C6D690-0x0000000189C6D6F4
		public override bool Equals(object o) => default; // 0x0000000189C6D61C-0x0000000189C6D690
		public override int GetHashCode() => default; // 0x0000000189C6D6F4-0x0000000189C6D71C
		public override string ToString() => default; // 0x0000000189C6D8D0-0x0000000189C6DAB0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C6D71C-0x0000000189C6D8D0
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct float3x3 : IEquatable<Unity.Mathematics.float3x3>, IFormattable // TypeDefIndex: 53741
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
		public float3 c2; // 0x18
		public static readonly float3x3 identity; // 0x00
		public static readonly float3x3 zero; // 0x24
	
		// Properties
		public ref float3 this[int index] { get => default; } // 0x0000000183D81800-0x0000000183D81810 
	
		// Constructors
		public float3x3(float3 c0, float3 c1, float3 c2) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D55290-0x0000000183D552D0
		public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D81650-0x0000000183D816B0
		public float3x3(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D81760-0x0000000183D81790
		public float3x3(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D28060-0x0000000184D280DC
		public float3x3(bool3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C6E324-0x0000000189C6E448
		public float3x3(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D815E0-0x0000000183D81650
		public float3x3(int3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D27F14-0x0000000184D28060
		public float3x3(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D816B0-0x0000000183D81760
		public float3x3(uint3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D280DC-0x0000000184D282A8
		public float3x3(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D81790-0x0000000183D81800
		public float3x3(double3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C6E27C-0x0000000189C6E324
		public float3x3(float4x4 f4x4) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x00000001828B5310-0x00000001828B53E0
		public float3x3(quaternion q) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x00000001828B74E0-0x00000001828B79E0
		static float3x3() {
			identity = default;
			zero = default;
		} // 0x0000000183C7D1C0-0x0000000183C7D270
	
		// Methods
		public static implicit operator float3x3(int v) => default; // 0x0000000189C3460C-0x0000000189C3462C
		public static float3x3 operator *(float3x3 lhs, float rhs) => default; // 0x0000000189C6E548-0x0000000189C6E600
		public static float3x3 operator +(float3x3 lhs, float3x3 rhs) => default; // 0x0000000189C6E448-0x0000000189C6E548
		public bool Equals(float3x3 rhs) => default; // 0x0000000189C6DCF8-0x0000000189C6DD84
		public override bool Equals(object o) => default; // 0x0000000189C6DC7C-0x0000000189C6DCF8
		public override int GetHashCode() => default; // 0x0000000189C6DD84-0x0000000189C6DDB0
		public override string ToString() => default; // 0x0000000189C6DDB0-0x0000000189C6E038
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C6E038-0x0000000189C6E27C
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct float3x4 : IEquatable<Unity.Mathematics.float3x4>, IFormattable // TypeDefIndex: 53742
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
		public float3 c2; // 0x18
		public float3 c3; // 0x24
		public static readonly float3x4 zero; // 0x00
	
		// Properties
		public ref float3 this[int index] { get => default; } // 0x0000000183D81800-0x0000000183D81810 
	
		// Constructors
		public float3x4(float3 c0, float3 c1, float3 c2, float3 c3) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D81850-0x0000000183D818A0
		public float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D81AA0-0x0000000183D81B20
		public float3x4(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D81810-0x0000000183D81850
		public float3x4(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D2837C-0x0000000184D2841C
		public float3x4(bool3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C6EE50-0x0000000189C6EFC8
		public float3x4(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D81A10-0x0000000183D81AA0
		public float3x4(int3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D282A8-0x0000000184D2837C
		public float3x4(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D81930-0x0000000183D81A10
		public float3x4(uint3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D2841C-0x0000000184D28748
		public float3x4(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D818A0-0x0000000183D81930
		public float3x4(double3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C6ED74-0x0000000189C6EE50
	
		// Methods
		public static implicit operator float3x4(int v) => default; // 0x0000000189C34834-0x0000000189C34854
		public bool Equals(float3x4 rhs) => default; // 0x0000000189C6E67C-0x0000000189C6E740
		public override bool Equals(object o) => default; // 0x0000000189C6E600-0x0000000189C6E67C
		public override int GetHashCode() => default; // 0x0000000189C6E740-0x0000000189C6E770
		public override string ToString() => default; // 0x0000000189C6EA44-0x0000000189C6ED74
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C6E770-0x0000000189C6EA44
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct float4 : IEquatable<Unity.Mathematics.float4>, IFormattable // TypeDefIndex: 53744
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
		public static readonly float4 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzz { get => default; } // 0x0000000183D805F0-0x0000000183D80610 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzx { get => default; } // 0x00000001828B4690-0x00000001828B46B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxz { get => default; } // 0x0000000183D80790-0x0000000183D807B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyww { get => default; } // 0x0000000183D81E50-0x0000000183D81E70 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxy { get => default; } // 0x00000001828B46B0-0x00000001828B46D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxz { get => default; } // 0x00000001828B4710-0x00000001828B4730 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxw { get => default; } // 0x0000000183D81E70-0x0000000183D81E90 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyy { get => default; } // 0x00000001828B46D0-0x00000001828B46F0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyz { get => default; } // 0x00000001828B46F0-0x00000001828B4710 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zwxy { get => default; } // 0x00000001828B5900-0x00000001828B5D10 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wzyx { get => default; } // 0x00000001828B58E0-0x00000001828B5900 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwwx { get => default; } // 0x0000000183D81D90-0x0000000183D81DB0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 wwww { get => default; } // 0x0000000183D81D70-0x0000000183D81D90 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxx { get => default; } // 0x0000000183D804A0-0x0000000183D804B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyz { get => default; set {} } // 0x0000000183D514C0-0x0000000183D514E0 0x0000000183D51BE0-0x0000000183D51C00
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyw { get => default; } // 0x0000000183D81DF0-0x0000000183D81E10 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxw { get => default; } // 0x0000000183D81E30-0x0000000183D81E50 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzx { get => default; } // 0x0000000183D80BC0-0x0000000183D80BE0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zwx { get => default; } // 0x0000000183D81E90-0x0000000183D81EB0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 wzy { get => default; } // 0x0000000183D81DD0-0x0000000183D81DF0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 www { get => default; } // 0x0000000183D81D60-0x0000000183D81D70 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xx { get => default; } // 0x0000000183D80490-0x0000000183D804A0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy { get => default; set {} } // 0x0000000183D51540-0x0000000183D51560 0x0000000183D7F900-0x0000000183D7F920
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xz { get => default; } // 0x0000000183D51590-0x0000000183D515B0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yy { get => default; } // 0x0000000183D80A30-0x0000000183D80A50 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yw { get => default; } // 0x0000000183D81E10-0x0000000183D81E30 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zw { get => default; } // 0x0000000183D67720-0x0000000183D67740 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 wz { get => default; } // 0x0000000183D81DB0-0x0000000183D81DD0 
		public float this[int index] { get => default; set {} } // 0x0000000183D80480-0x0000000183D80490 0x0000000183D81330-0x0000000183D81340
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53743
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public float4(float x, float y, float z, float w) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D516B0-0x0000000183D516D0
		public float4(float x, float y, float2 zw) : this() {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000183D81C70-0x0000000183D81CA0
		public float4(float x, float2 yz, float w) : this() {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D81D10-0x0000000183D81D40
		public float4(float x, float3 yzw) : this() {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D81D40-0x0000000183D81D60
		public float4(float2 xy, float z, float w) : this() {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D81C20-0x0000000183D81C50
		public float4(float2 xy, float2 zw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D81B20-0x0000000183D81B60
		public float4(float3 xyz, float w) : this() {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D81C00-0x0000000183D81C20
		public float4(float4 xyzw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D5DBB0-0x0000000183D5DBD0
		public float4(float v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D81BB0-0x0000000183D81BC0
		public float4(bool v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000184D28748-0x0000000184D2878C
		public float4(bool4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000184D2878C-0x0000000184D287E0
		public float4(int v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D81CA0-0x0000000183D81CB0
		public float4(int4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D81D00-0x0000000183D81D10
		public float4(uint v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D81B60-0x0000000183D81BB0
		public float4(uint4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D81CB0-0x0000000183D81D00
		public float4(half v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C6F34C-0x0000000189C6F394
		public float4(half4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C6F2F4-0x0000000189C6F34C
		public float4(double v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D81C50-0x0000000183D81C70
		public float4(double4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D81BC0-0x0000000183D81C00
	
		// Methods
		public static implicit operator float4(float v) => default; // 0x0000000183D7AAE0-0x0000000183D7AAF0
		public static implicit operator float4(int v) => default; // 0x0000000183D7AB70-0x0000000183D7AB90
		public static implicit operator float4(int4 v) => default; // 0x0000000189C34A6C-0x0000000189C34AB0
		public static implicit operator float4(uint v) => default; // 0x0000000183D7ABC0-0x0000000183D7AC10
		public static implicit operator float4(uint4 v) => default; // 0x0000000189C34AC8-0x0000000189C34AEC
		public static implicit operator float4(half4 v) => default; // 0x0000000189C349C4-0x0000000189C34A20
		public static explicit operator float4(double v) => default; // 0x0000000183D7AB50-0x0000000183D7AB70
		public static explicit operator float4(double4 v) => default; // 0x0000000189C3497C-0x0000000189C349AC
		public static float4 operator *(float4 lhs, float4 rhs) => default; // 0x00000001828B5D10-0x00000001828B5D60
		public static float4 operator *(float4 lhs, float rhs) => default; // 0x0000000182E260C0-0x0000000182E260E0
		public static float4 operator *(float lhs, float4 rhs) => default; // 0x00000001828B53E0-0x00000001828B5400
		public static float4 operator +(float4 lhs, float4 rhs) => default; // 0x00000001828B5D60-0x00000001828B5DB0
		public static float4 operator +(float4 lhs, float rhs) => default; // 0x0000000183D73570-0x0000000183D73590
		public static float4 operator -(float4 lhs, float4 rhs) => default; // 0x00000001828B4640-0x00000001828B4690
		public static float4 operator -(float4 lhs, float rhs) => default; // 0x0000000183D73590-0x0000000183D735B0
		public static float4 operator -(float lhs, float4 rhs) => default; // 0x0000000183D81EB0-0x0000000183D81EF0
		public static float4 operator /(float4 lhs, float4 rhs) => default; // 0x000000018950C700-0x000000018950C744
		public static float4 operator /(float4 lhs, float rhs) => default; // 0x000000018950C744-0x000000018950C758
		public static float4 operator /(float lhs, float4 rhs) => default; // 0x0000000189C6F394-0x0000000189C6F3CC
		public static bool4 operator <(float4 lhs, float rhs) => default; // 0x0000000189C6F4B0-0x0000000189C6F4D8
		public static bool4 operator >(float4 lhs, float4 rhs) => default; // 0x0000000189C6F474-0x0000000189C6F4B0
		public static bool4 operator >=(float4 lhs, float4 rhs) => default; // 0x0000000189C6F430-0x0000000189C6F474
		public static float4 operator -(float4 val) => default; // 0x0000000183D81EF0-0x0000000183D81F10
		public static bool4 operator ==(float4 lhs, float4 rhs) => default; // 0x0000000189C6F3CC-0x0000000189C6F430
		public static bool4 operator ==(float4 lhs, float rhs) => default; // 0x0000000184D287E0-0x0000000184D288EC
		public bool Equals(float4 rhs) => default; // 0x00000001822CDA10-0x00000001822CDA50
		public override bool Equals(object o) => default; // 0x0000000189C6EFC8-0x0000000189C6F034
		public override int GetHashCode() => default; // 0x0000000189C38878-0x0000000189C38894
		public override string ToString() => default; // 0x0000000189C6F034-0x0000000189C6F1A0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C6F1A0-0x0000000189C6F2F4
		public static implicit operator float4(Vector4 v) => default; // 0x000000018294BC80-0x000000018294BCA0
		public static implicit operator Vector4(float4 v) => default; // 0x000000018294BC80-0x000000018294BCA0
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct float4x2 : IEquatable<Unity.Mathematics.float4x2>, IFormattable // TypeDefIndex: 53745
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
	
		// Constructors
		public float4x2(float4 c0, float4 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D553F0-0x0000000183D55400
		public float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D81FE0-0x0000000183D82050
		public float4x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D81FC0-0x0000000183D81FE0
		public float4x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D28AB4-0x0000000184D28AD8
		public float4x2(bool4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D288EC-0x0000000184D28A84
		public float4x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D81F10-0x0000000183D81F30
		public float4x2(int4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C6FA70-0x0000000189C6FB14
		public float4x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D28A84-0x0000000184D28AB4
		public float4x2(uint4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C6FA1C-0x0000000189C6FA70
		public float4x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D81F30-0x0000000183D81FC0
		public float4x2(double4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C6FB14-0x0000000189C6FB78
	
		// Methods
		public static implicit operator float4x2(int v) => default; // 0x0000000182293810-0x0000000182293840
		public bool Equals(float4x2 rhs) => default; // 0x0000000189C6F4D8-0x0000000189C6F520
		public override bool Equals(object o) => default; // 0x0000000189C6F520-0x0000000189C6F594
		public override int GetHashCode() => default; // 0x0000000189C6F594-0x0000000189C6F5B8
		public override string ToString() => default; // 0x0000000189C6F7CC-0x0000000189C6FA1C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C6F5B8-0x0000000189C6F7CC
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct float4x3 : IEquatable<Unity.Mathematics.float4x3>, IFormattable // TypeDefIndex: 53746
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
		public float4 c2; // 0x20
	
		// Properties
		public ref float4 this[int index] { get => default; } // 0x0000000183D82200-0x0000000183D82210 
	
		// Constructors
		public float4x3(float4 c0, float4 c1, float4 c2) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D6B600-0x0000000183D6B620
		public float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82140-0x0000000183D82200
		public float4x3(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82110-0x0000000183D82140
		public float4x3(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D28B88-0x0000000184D28DC4
		public float4x3(bool4x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D28AD8-0x0000000184D28B88
		public float4x3(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000182752510-0x0000000182752540
		public float4x3(int4x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C70288-0x0000000189C70378
		public float4x3(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D28DC4-0x0000000184D28E08
		public float4x3(uint4x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C70378-0x0000000189C703F0
		public float4x3(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82050-0x0000000183D82110
		public float4x3(double4x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C703F0-0x0000000189C7047C
	
		// Methods
		public static implicit operator float4x3(int v) => default; // 0x0000000189C34DDC-0x0000000189C34DFC
		public static float4x3 operator *(float4x3 lhs, float4x3 rhs) => default; // 0x0000000189C70538-0x0000000189C705F4
		public static float4x3 operator *(float4x3 lhs, float rhs) => default; // 0x0000000189C705F4-0x0000000189C70680
		public static float4x3 operator +(float4x3 lhs, float4x3 rhs) => default; // 0x0000000189C7047C-0x0000000189C70538
		public bool Equals(float4x3 rhs) => default; // 0x0000000189C6FBF4-0x0000000189C6FC54
		public override bool Equals(object o) => default; // 0x0000000189C6FB78-0x0000000189C6FBF4
		public override int GetHashCode() => default; // 0x0000000189C6FC54-0x0000000189C6FC84
		public override string ToString() => default; // 0x0000000189C6FF58-0x0000000189C70288
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C6FC84-0x0000000189C6FF58
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct float4x4 : IEquatable<Unity.Mathematics.float4x4>, IFormattable // TypeDefIndex: 53747
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
		public float4 c2; // 0x20
		public float4 c3; // 0x30
		public static readonly float4x4 identity; // 0x00
		public static readonly float4x4 zero; // 0x40
	
		// Properties
		public ref float4 this[int index] { get => default; } // 0x0000000183D82200-0x0000000183D82210 
	
		// Constructors
		public float4x4(float4 c0, float4 c1, float4 c2, float4 c3) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D7E4A0-0x0000000183D7E4D0
		public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000182A591D0-0x0000000182A592D0
		public float4x4(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000182E25B30-0x0000000182E260C0
		public float4x4(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D28EE8-0x0000000184D28FE4
		public float4x4(bool4x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D28E08-0x0000000184D28EE8
		public float4x4(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018327D9B0-0x000000018327D9F0
		public float4x4(int4x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C71638-0x0000000189C71770
		public float4x4(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D28FE4-0x0000000184D29BD0
		public float4x4(uint4x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C715A0-0x0000000189C71638
		public float4x4(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82210-0x0000000183D82310
		public float4x4(double4x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C714E8-0x0000000189C715A0
		public float4x4(float3x3 rotation, float3 translation) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C71200-0x0000000189C712C0
		public float4x4(quaternion rotation, float3 translation) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C712C0-0x0000000189C713C4
		public float4x4(RigidTransform transform) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C713C4-0x0000000189C714E8
		static float4x4() {
			identity = default;
			zero = default;
		} // 0x0000000183C915F0-0x0000000183C916F0
	
		// Methods
		public static implicit operator float4x4(float v) => default; // 0x0000000182E25B00-0x0000000182E25B30
		public static implicit operator float4x4(int v) => default; // 0x0000000189C352DC-0x0000000189C35300
		public static float4x4 operator *(float4x4 lhs, float rhs) => default; // 0x0000000189C7195C-0x0000000189C71A14
		public static bool4x4 operator ==(float4x4 lhs, float4x4 rhs) => default; // 0x0000000189C71770-0x0000000189C71844
		public bool Equals(float4x4 rhs) => default; // 0x0000000189C70680-0x0000000189C706FC
		public override bool Equals(object o) => default; // 0x0000000189C706FC-0x0000000189C70780
		public override int GetHashCode() => default; // 0x0000000189C70780-0x0000000189C707B8
		public override string ToString() => default; // 0x0000000189C70A5C-0x0000000189C70E6C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C70E6C-0x0000000189C71200
		public static implicit operator float4x4(Matrix4x4 m) => default; // 0x0000000189C71844-0x0000000189C7195C
		public static implicit operator Matrix4x4(float4x4 m) => default; // 0x0000000182A592D0-0x0000000182A594C0
		public static float4x4 Ortho(float width, float height, float near, float far) => default; // 0x0000000189C707B8-0x0000000189C708A4
		public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale) => default; // 0x0000000189C708A4-0x0000000189C70A5C
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct half : IEquatable<Unity.Mathematics.half>, IFormattable // TypeDefIndex: 53748
	{
		// Fields
		public ushort value; // 0x00
		public static readonly half zero; // 0x00
	
		// Constructors
		public half(half x) {
			value = default;
		} // 0x0000000183D4F9B0-0x0000000183D4F9C0
		public half(float v) {
			value = default;
		} // 0x0000000189C7250C-0x0000000189C72524
		public half(double v) {
			value = default;
		} // 0x0000000189C724F0-0x0000000189C7250C
	
		// Methods
		public static explicit operator half(float v) => default; // 0x0000000189C35A48-0x0000000189C35A50
		public static explicit operator half(double v) => default; // 0x0000000189C35A3C-0x0000000189C35A48
		public static implicit operator float(half d) => default; // 0x0000000189C72544-0x0000000189C7254C
		public static implicit operator double(half d) => default; // 0x0000000189C7252C-0x0000000189C72544
		public static bool operator ==(half lhs, half rhs) => default; // 0x0000000189C72524-0x0000000189C7252C
		public bool Equals(half rhs) => default; // 0x00000001831DF9C0-0x00000001831DF9D0
		public override bool Equals(object o) => default; // 0x0000000189C72438-0x0000000189C72498
		public override int GetHashCode() => default; // 0x0000000183D4F990-0x0000000183D4F9A0
		public override string ToString() => default; // 0x0000000189C72498-0x0000000189C724BC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C724BC-0x0000000189C724F0
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct half2 : IEquatable<Unity.Mathematics.half2>, IFormattable // TypeDefIndex: 53750
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53749
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public half2(half x, half y) {
			this.x = default;
			this.y = default;
		} // 0x0000000183D6EFA0-0x0000000183D6EFB0
		public half2(half2 xy) {
			x = default;
			y = default;
		} // 0x0000000183D82320-0x0000000183D82330
		public half2(half v) {
			x = default;
			y = default;
		} // 0x0000000183D82310-0x0000000183D82320
		public half2(float v) {
			x = default;
			y = default;
		} // 0x0000000189C71C24-0x0000000189C71C4C
		public half2(float2 v) {
			x = default;
			y = default;
		} // 0x0000000189C71C4C-0x0000000189C71C7C
		public half2(double v) {
			x = default;
			y = default;
		} // 0x0000000189C71BF4-0x0000000189C71C24
		public half2(double2 v) {
			x = default;
			y = default;
		} // 0x0000000189C71C7C-0x0000000189C71CB0
	
		// Methods
		public static explicit operator half2(float2 v) => default; // 0x0000000189C357A8-0x0000000189C357DC
		public bool Equals(half2 rhs) => default; // 0x0000000189C71A88-0x0000000189C71A9C
		public override bool Equals(object o) => default; // 0x0000000189C71A14-0x0000000189C71A88
		public override int GetHashCode() => default; // 0x0000000189C71A9C-0x0000000189C71AE4
		public override string ToString() => default; // 0x0000000189C71B68-0x0000000189C71BF4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C71AE4-0x0000000189C71B68
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct half3 : IEquatable<Unity.Mathematics.half3>, IFormattable // TypeDefIndex: 53752
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
		public half z; // 0x04
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53751
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public half3(half x, half y, half z) {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000183D7D570-0x0000000183D7D580
		public half3(half x, half2 yz) {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000183D82330-0x0000000183D82350
		public half3(half2 xy, half z) {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000183D82350-0x0000000183D82360
		public half3(half3 xyz) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D82360-0x0000000183D82380
		public half3(half v) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D82380-0x0000000183D82390
		public half3(float v) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C71F70-0x0000000189C71FA8
		public half3(float3 v) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C71FA8-0x0000000189C71FE4
		public half3(double v) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C71EE4-0x0000000189C71F28
		public half3(double3 v) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C71F28-0x0000000189C71F70
	
		// Methods
		public static explicit operator half3(float3 v) => default; // 0x0000000189C3586C-0x0000000189C358B0
		public static explicit operator half3(double3 v) => default; // 0x0000000189C35820-0x0000000189C3586C
		public bool Equals(half3 rhs) => default; // 0x0000000189C71CB0-0x0000000189C71CD4
		public override bool Equals(object o) => default; // 0x0000000189C71CD4-0x0000000189C71D60
		public override int GetHashCode() => default; // 0x0000000189C71D60-0x0000000189C71D84
		public override string ToString() => default; // 0x0000000189C71E2C-0x0000000189C71EE4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C71D84-0x0000000189C71E2C
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct half4 : IEquatable<Unity.Mathematics.half4>, IFormattable // TypeDefIndex: 53754
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
		public half z; // 0x04
		public half w; // 0x06
		public static readonly half4 zero; // 0x00
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53753
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public half4(half x, half y, half z, half w) {
			this.x = default;
			this.y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D7D630-0x0000000183D7D650
		public half4(half x, half y, half2 zw) {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000183D82400-0x0000000183D82420
		public half4(half x, half2 yz, half w) {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D82420-0x0000000183D82440
		public half4(half x, half3 yzw) {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D82470-0x0000000183D82490
		public half4(half2 xy, half z, half w) {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D82390-0x0000000183D823B0
		public half4(half2 xy, half2 zw) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D823B0-0x0000000183D823D0
		public half4(half3 xyz, half w) {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D82450-0x0000000183D82470
		public half4(half4 xyzw) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D823D0-0x0000000183D82400
		public half4(half v) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D82440-0x0000000183D82450
		public half4(float v) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C723F4-0x0000000189C72438
		public half4(float4 v) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C722F8-0x0000000189C72344
		public half4(double v) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C723A0-0x0000000189C723F4
		public half4(double4 v) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C72344-0x0000000189C723A0
	
		// Methods
		public static explicit operator half4(float4 v) => default; // 0x0000000189C359E8-0x0000000189C35A3C
		public bool Equals(half4 rhs) => default; // 0x0000000189C6A134-0x0000000189C6A4D4
		public override bool Equals(object o) => default; // 0x0000000189C71FE4-0x0000000189C72044
		public override int GetHashCode() => default; // 0x0000000189C72044-0x0000000189C7204C
		public override string ToString() => default; // 0x0000000189C7204C-0x0000000189C721B0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C721B0-0x0000000189C722F8
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct int2 : IEquatable<Unity.Mathematics.int2>, IFormattable // TypeDefIndex: 53756
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public static readonly int2 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xy { get => default; } // 0x0000000183D5DE50-0x0000000183D5DE70 
		public int this[int index] { set {} } // 0x0000000183D56010-0x0000000183D56020
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53755
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public int2(int x, int y) : this() {
			this.x = default;
			this.y = default;
		} // 0x0000000183D4E4B0-0x0000000183D4E4C0
		public int2(int2 xy) : this() {
			x = default;
			y = default;
		} // 0x0000000183D824F0-0x0000000183D82500
		public int2(int v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D82490-0x0000000183D824A0
		public int2(bool v) : this() {
			x = default;
			y = default;
		} // 0x0000000189C72704-0x0000000189C72714
		public int2(bool2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000189C72714-0x0000000189C72730
		public int2(uint v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D82490-0x0000000183D824A0
		public int2(uint2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D824F0-0x0000000183D82500
		public int2(float v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D824E0-0x0000000183D824F0
		public int2(float2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D824B0-0x0000000183D824D0
		public int2(double v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D824D0-0x0000000183D824E0
		public int2(double2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000183D824A0-0x0000000183D824B0
	
		// Methods
		public static implicit operator int2(int v) => default; // 0x0000000183D7B520-0x0000000183D7B530
		public static explicit operator int2(uint v) => default; // 0x0000000183D7B520-0x0000000183D7B530
		public static explicit operator int2(uint2 v) => default; // 0x0000000183D76940-0x0000000183D76960
		public static explicit operator int2(float v) => default; // 0x0000000183D7B500-0x0000000183D7B520
		public static explicit operator int2(float2 v) => default; // 0x0000000183D7B4C0-0x0000000183D7B4E0
		public static explicit operator int2(double v) => default; // 0x0000000183D7B4E0-0x0000000183D7B500
		public static explicit operator int2(double2 v) => default; // 0x0000000183D7B530-0x0000000183D7B550
		public static int2 operator *(int2 lhs, int2 rhs) => default; // 0x0000000183D82560-0x0000000183D82580
		public static int2 operator *(int2 lhs, int rhs) => default; // 0x0000000183D82540-0x0000000183D82560
		public static int2 operator +(int2 lhs, int2 rhs) => default; // 0x0000000183D4E4E0-0x0000000183D4E500
		public static int2 operator +(int2 lhs, int rhs) => default; // 0x0000000183D82500-0x0000000183D82520
		public static int2 operator -(int2 lhs, int rhs) => default; // 0x0000000183D825B0-0x0000000183D825D0
		public static int2 operator /(int2 lhs, int rhs) => default; // 0x0000000189C72730-0x0000000189C72754
		public static bool2 operator >(int2 lhs, int rhs) => default; // 0x0000000189C72774-0x0000000189C7278C
		public static bool2 operator >=(int2 lhs, int rhs) => default; // 0x0000000189C72754-0x0000000189C72774
		public static int2 operator -(int2 val) => default; // 0x0000000183D825D0-0x0000000183D825F0
		public static int2 operator >>(int2 x, int n) => default; // 0x0000000183D82580-0x0000000183D825B0
		public static int2 operator |(int2 lhs, int2 rhs) => default; // 0x0000000183D82520-0x0000000183D82540
		public bool Equals(int2 rhs) => default; // 0x00000001851404D0-0x00000001851404E4
		public override bool Equals(object o) => default; // 0x0000000189C7254C-0x0000000189C725C0
		public override int GetHashCode() => default; // 0x0000000189C725C0-0x0000000189C725F4
		public override string ToString() => default; // 0x0000000189C7267C-0x0000000189C72704
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C725F4-0x0000000189C7267C
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int2x2 : IEquatable<Unity.Mathematics.int2x2>, IFormattable // TypeDefIndex: 53757
	{
		// Fields
		public int2 c0; // 0x00
		public int2 c1; // 0x08
		public static readonly int2x2 identity; // 0x00
	
		// Constructors
		public int2x2(int2 c0, int2 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D4EA10-0x0000000183D4EA20
		public int2x2(int m00, int m01, int m10, int m11) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82730-0x0000000183D82760
		public int2x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82670-0x0000000183D826A0
		public int2x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C72B34-0x0000000189C72B7C
		public int2x2(bool2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C72AC4-0x0000000189C72B34
		public int2x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82670-0x0000000183D826A0
		public int2x2(uint2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82760-0x0000000183D827A0
		public int2x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D825F0-0x0000000183D82630
		public int2x2(float2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D826E0-0x0000000183D82730
		public int2x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D826A0-0x0000000183D826E0
		public int2x2(double2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82630-0x0000000183D82670
		static int2x2() {
			identity = default;
		} // 0x0000000183CBAC80-0x0000000183CBACE0
	
		// Methods
		public bool Equals(int2x2 rhs) => default; // 0x0000000189C6A4D4-0x0000000189C6D61C
		public override bool Equals(object o) => default; // 0x0000000189C7278C-0x0000000189C727F8
		public override int GetHashCode() => default; // 0x0000000189C727F8-0x0000000189C72814
		public override string ToString() => default; // 0x0000000189C72814-0x0000000189C72970
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C72970-0x0000000189C72AC4
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct int2x3 : IEquatable<Unity.Mathematics.int2x3>, IFormattable // TypeDefIndex: 53758
	{
		// Fields
		public int2 c0; // 0x00
		public int2 c1; // 0x08
		public int2 c2; // 0x10
	
		// Properties
		public ref int2 this[int index] { get => default; } // 0x0000000183D829E0-0x0000000183D829F0 
	
		// Constructors
		public int2x3(int2 c0, int2 c1, int2 c2) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D54CF0-0x0000000183D54D00
		public int2x3(int m00, int m01, int m02, int m10, int m11, int m12) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82990-0x0000000183D829E0
		public int2x3(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82900-0x0000000183D82940
		public int2x3(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C73090-0x0000000189C730F4
		public int2x3(bool2x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C72FF8-0x0000000189C73090
		public int2x3(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82900-0x0000000183D82940
		public int2x3(uint2x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82940-0x0000000183D82990
		public int2x3(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82850-0x0000000183D828A0
		public int2x3(float2x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D828A0-0x0000000183D82900
		public int2x3(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D827A0-0x0000000183D827F0
		public int2x3(double2x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D827F0-0x0000000183D82850
	
		// Methods
		public bool Equals(int2x3 rhs) => default; // 0x0000000189C72B7C-0x0000000189C72BE0
		public override bool Equals(object o) => default; // 0x0000000189C72BE0-0x0000000189C72C54
		public override int GetHashCode() => default; // 0x0000000189C72C54-0x0000000189C72C7C
		public override string ToString() => default; // 0x0000000189C72C7C-0x0000000189C72E44
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C72E44-0x0000000189C72FF8
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int2x4 : IEquatable<Unity.Mathematics.int2x4>, IFormattable // TypeDefIndex: 53759
	{
		// Fields
		public int2 c0; // 0x00
		public int2 c1; // 0x08
		public int2 c2; // 0x10
		public int2 c3; // 0x18
	
		// Constructors
		public int2x4(int2 c0, int2 c1, int2 c2, int2 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D4EA20-0x0000000183D4EA40
		public int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82AE0-0x0000000183D82B40
		public int2x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82BC0-0x0000000183D82C10
		public int2x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C73710-0x0000000189C73794
		public int2x4(bool2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C73644-0x0000000189C73710
		public int2x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82BC0-0x0000000183D82C10
		public int2x4(uint2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82A70-0x0000000183D82AE0
		public int2x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82C10-0x0000000183D82C80
		public int2x4(float2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D829F0-0x0000000183D82A70
		public int2x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82C80-0x0000000183D82CF0
		public int2x4(double2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82B40-0x0000000183D82BC0
	
		// Methods
		public bool Equals(int2x4 rhs) => default; // 0x0000000189C73168-0x0000000189C731DC
		public override bool Equals(object o) => default; // 0x0000000189C730F4-0x0000000189C73168
		public override int GetHashCode() => default; // 0x0000000189C731DC-0x0000000189C73200
		public override string ToString() => default; // 0x0000000189C73414-0x0000000189C73644
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C73200-0x0000000189C73414
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct int3 : IEquatable<Unity.Mathematics.int3>, IFormattable // TypeDefIndex: 53761
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public static readonly int3 zero; // 0x00
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyz { set {} } // 0x0000000183D51BE0-0x0000000183D51C00
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xzy { get => default; } // 0x0000000183D807B0-0x0000000183D807D0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xy { get => default; set {} } // 0x0000000183D5DE50-0x0000000183D5DE70 0x0000000183D824F0-0x0000000183D82500
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yz { get => default; } // 0x0000000183D82DA0-0x0000000183D82DC0 
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 zx { get => default; } // 0x0000000183D82DC0-0x0000000183D82DE0 
		public int this[int index] { get => default; set {} } // 0x0000000183D55FF0-0x0000000183D56000 0x0000000183D56010-0x0000000183D56020
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53760
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public int3(int x, int y, int z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000183D4E5D0-0x0000000183D4E5E0
		public int3(int x, int2 yz) : this() {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000183D82CF0-0x0000000183D82D00
		public int3(int2 xy, int z) : this() {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000183D82D90-0x0000000183D82DA0
		public int3(int3 xyz) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D51BE0-0x0000000183D51C00
		public int3(int v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D82D60-0x0000000183D82D70
		public int3(bool v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C73998-0x0000000189C739AC
		public int3(bool3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C7396C-0x0000000189C73998
		public int3(uint v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D82D60-0x0000000183D82D70
		public int3(uint3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D51BE0-0x0000000183D51C00
		public int3(float v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D82D20-0x0000000183D82D40
		public int3(float3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D82D00-0x0000000183D82D20
		public int3(double v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D82D40-0x0000000183D82D60
		public int3(double3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D82D70-0x0000000183D82D90
	
		// Methods
		public static implicit operator int3(int v) => default; // 0x0000000183D7B570-0x0000000183D7B580
		public static explicit operator int3(uint v) => default; // 0x0000000183D7B570-0x0000000183D7B580
		public static explicit operator int3(uint3 v) => default; // 0x0000000183D7B5F0-0x0000000183D7B620
		public static explicit operator int3(float v) => default; // 0x0000000183D7B640-0x0000000183D7B660
		public static explicit operator int3(float3 v) => default; // 0x0000000183D7B580-0x0000000183D7B5B0
		public static explicit operator int3(double v) => default; // 0x0000000183D7B620-0x0000000183D7B640
		public static explicit operator int3(double3 v) => default; // 0x0000000183D7B660-0x0000000183D7B6A0
		public static int3 operator *(int3 lhs, int3 rhs) => default; // 0x000000018304D500-0x000000018304D530
		public static int3 operator *(int3 lhs, int rhs) => default; // 0x0000000183D82E30-0x0000000183D82E50
		public static int3 operator +(int3 lhs, int3 rhs) => default; // 0x00000001825BE440-0x00000001825BE460
		public static int3 operator +(int3 lhs, int rhs) => default; // 0x0000000183D82DE0-0x0000000183D82E10
		public static int3 operator -(int3 lhs, int3 rhs) => default; // 0x0000000183D82EA0-0x0000000183D82EC0
		public static int3 operator -(int3 lhs, int rhs) => default; // 0x0000000183D82E80-0x0000000183D82EA0
		public static int3 operator /(int3 lhs, int rhs) => default; // 0x0000000189C739AC-0x0000000189C739D4
		public static bool3 operator <=(int3 lhs, int3 rhs) => default; // 0x0000000189C73A8C-0x0000000189C73AB8
		public static bool3 operator >(int3 lhs, int rhs) => default; // 0x0000000189C73A20-0x0000000189C73A40
		public static bool3 operator >=(int3 lhs, int3 rhs) => default; // 0x0000000189C739D4-0x0000000189C73A00
		public static bool3 operator >=(int3 lhs, int rhs) => default; // 0x0000000189C73A00-0x0000000189C73A20
		public static int3 operator -(int3 val) => default; // 0x0000000183D82EC0-0x0000000183D82EE0
		public static int3 operator >>(int3 x, int n) => default; // 0x0000000183D82E50-0x0000000183D82E80
		public static bool3 operator !=(int3 lhs, int3 rhs) => default; // 0x0000000189C73A60-0x0000000189C73A8C
		public static bool3 operator !=(int3 lhs, int rhs) => default; // 0x0000000189C73A40-0x0000000189C73A60
		public static int3 operator |(int3 lhs, int3 rhs) => default; // 0x0000000183D82E10-0x0000000183D82E30
		public bool Equals(int3 rhs) => default; // 0x00000001851408A4-0x00000001851408C0
		public override bool Equals(object o) => default; // 0x0000000189C73794-0x0000000189C73808
		public override int GetHashCode() => default; // 0x0000000185D00010-0x0000000185D00034
		public override string ToString() => default; // 0x0000000189C738B8-0x0000000189C7396C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C73808-0x0000000189C738B8
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int3x2 : IEquatable<Unity.Mathematics.int3x2>, IFormattable // TypeDefIndex: 53762
	{
		// Fields
		public int3 c0; // 0x00
		public int3 c1; // 0x0C
	
		// Constructors
		public int3x2(int3 c0, int3 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D4FF30-0x0000000183D4FF50
		public int3x2(int m00, int m01, int m10, int m11, int m20, int m21) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82EE0-0x0000000183D82F20
		public int3x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82F70-0x0000000183D82FA0
		public int3x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D29BD0-0x0000000184D29DA0
		public int3x2(bool3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C73F48-0x0000000189C74034
		public int3x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82F70-0x0000000183D82FA0
		public int3x2(uint3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D29DA0-0x0000000184D29E14
		public int3x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82F20-0x0000000183D82F70
		public int3x2(float3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D29E14-0x0000000184D29FD4
		public int3x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82FA0-0x0000000183D82FF0
		public int3x2(double3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C73ED0-0x0000000189C73F48
	
		// Methods
		public bool Equals(int3x2 rhs) => default; // 0x000000018553EA68-0x000000018553EACC
		public override bool Equals(object o) => default; // 0x0000000189C73AB8-0x0000000189C73B2C
		public override int GetHashCode() => default; // 0x0000000189C73B2C-0x0000000189C73B54
		public override string ToString() => default; // 0x0000000189C73D08-0x0000000189C73ED0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C73B54-0x0000000189C73D08
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int3x3 : IEquatable<Unity.Mathematics.int3x3>, IFormattable // TypeDefIndex: 53763
	{
		// Fields
		public int3 c0; // 0x00
		public int3 c1; // 0x0C
		public int3 c2; // 0x18
		public static readonly int3x3 identity; // 0x00
	
		// Constructors
		public int3x3(int3 c0, int3 c1, int3 c2) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D55290-0x0000000183D552D0
		public int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183B6C9D0-0x0000000183B6CA30
		public int3x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82FF0-0x0000000183D83040
		public int3x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D2A078-0x0000000184D2A108
		public int3x3(bool3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C74610-0x0000000189C74758
		public int3x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82FF0-0x0000000183D83040
		public int3x3(uint3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D2A108-0x0000000184D2A254
		public int3x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D830B0-0x0000000183D83120
		public int3x3(float3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D29FD4-0x0000000184D2A078
		public int3x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D83040-0x0000000183D830B0
		public int3x3(double3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C74758-0x0000000189C74800
		static int3x3() {
			identity = default;
		} // 0x0000000183B6CA30-0x0000000183B6CAD0
	
		// Methods
		public bool Equals(int3x3 rhs) => default; // 0x0000000189C740B0-0x0000000189C7413C
		public override bool Equals(object o) => default; // 0x0000000189C74034-0x0000000189C740B0
		public override int GetHashCode() => default; // 0x0000000189C7413C-0x0000000189C74168
		public override string ToString() => default; // 0x0000000189C743AC-0x0000000189C74610
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C74168-0x0000000189C743AC
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int3x4 : IEquatable<Unity.Mathematics.int3x4>, IFormattable // TypeDefIndex: 53764
	{
		// Fields
		public int3 c0; // 0x00
		public int3 c1; // 0x0C
		public int3 c2; // 0x18
		public int3 c3; // 0x24
	
		// Constructors
		public int3x4(int3 c0, int3 c1, int3 c2, int3 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D81850-0x0000000183D818A0
		public int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D832A0-0x0000000183D83330
		public int3x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D831B0-0x0000000183D83210
		public int3x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D2A3FC-0x0000000184D2A77C
		public int3x4(bool3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C74F44-0x0000000189C750D8
		public int3x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D831B0-0x0000000183D83210
		public int3x4(uint3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D2A254-0x0000000184D2A328
		public int3x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D83120-0x0000000183D831B0
		public int3x4(float3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D2A328-0x0000000184D2A3FC
		public int3x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D83210-0x0000000183D832A0
		public int3x4(double3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C750D8-0x0000000189C751B4
	
		// Methods
		public bool Equals(int3x4 rhs) => default; // 0x0000000189C7487C-0x0000000189C74940
		public override bool Equals(object o) => default; // 0x0000000189C74800-0x0000000189C7487C
		public override int GetHashCode() => default; // 0x0000000189C74940-0x0000000189C74970
		public override string ToString() => default; // 0x0000000189C74970-0x0000000189C74C70
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C74C70-0x0000000189C74F44
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct int4 : IEquatable<Unity.Mathematics.int4>, IFormattable // TypeDefIndex: 53766
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public int w; // 0x0C
		public static readonly int4 zero; // 0x00
	
		// Properties
		public int this[int index] { get => default; set {} } // 0x0000000183D55FF0-0x0000000183D56000 0x0000000183D56010-0x0000000183D56020
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53765
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public int4(int x, int y, int z, int w) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D517E0-0x0000000183D51800
		public int4(int x, int y, int2 zw) : this() {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000183D83330-0x0000000183D83350
		public int4(int x, int2 yz, int w) : this() {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D83430-0x0000000183D83450
		public int4(int x, int3 yzw) : this() {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D83400-0x0000000183D83420
		public int4(int2 xy, int z, int w) : this() {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D83450-0x0000000183D83470
		public int4(int2 xy, int2 zw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D83350-0x0000000183D83370
		public int4(int3 xyz, int w) : this() {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D833E0-0x0000000183D83400
		public int4(int4 xyzw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D5DBB0-0x0000000183D5DBD0
		public int4(int v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D83390-0x0000000183D833A0
		public int4(bool v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C754EC-0x0000000189C75508
		public int4(bool4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C75508-0x0000000189C7554C
		public int4(uint v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D83390-0x0000000183D833A0
		public int4(uint4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D5DBB0-0x0000000183D5DBD0
		public int4(float v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D83370-0x0000000183D83390
		public int4(float4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D83420-0x0000000183D83430
		public int4(double v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D833A0-0x0000000183D833C0
		public int4(double4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D833C0-0x0000000183D833E0
	
		// Methods
		public static implicit operator int4(int v) => default; // 0x0000000183D7B6A0-0x0000000183D7B6B0
		public static explicit operator int4(uint v) => default; // 0x0000000183D7B6A0-0x0000000183D7B6B0
		public static explicit operator int4(uint4 v) => default; // 0x0000000189C3D070-0x0000000189C3D09C
		public static explicit operator int4(float v) => default; // 0x0000000183D7B710-0x0000000183D7B730
		public static explicit operator int4(float4 v) => default; // 0x0000000189C3D130-0x0000000189C3D164
		public static explicit operator int4(double v) => default; // 0x0000000183D7B6F0-0x0000000183D7B710
		public static explicit operator int4(double4 v) => default; // 0x0000000189C3D100-0x0000000189C3D130
		public static int4 operator *(int4 lhs, int4 rhs) => default; // 0x0000000183D834D0-0x0000000183D83500
		public static int4 operator *(int4 lhs, int rhs) => default; // 0x0000000183D83500-0x0000000183D83530
		public static int4 operator +(int4 lhs, int4 rhs) => default; // 0x0000000183D834A0-0x0000000183D834D0
		public static int4 operator +(int4 lhs, int rhs) => default; // 0x0000000183D83470-0x0000000183D834A0
		public static int4 operator -(int4 lhs, int rhs) => default; // 0x0000000183D83560-0x0000000183D83590
		public static bool4 operator >(int4 lhs, int rhs) => default; // 0x0000000189C75570-0x0000000189C75594
		public static bool4 operator >=(int4 lhs, int rhs) => default; // 0x0000000189C7554C-0x0000000189C75570
		public static int4 operator -(int4 val) => default; // 0x0000000183D83590-0x0000000183D835C0
		public static int4 operator >>(int4 x, int n) => default; // 0x0000000183D83530-0x0000000183D83560
		public static int4 operator |(int4 lhs, int4 rhs) => default; // 0x00000001828B58B0-0x00000001828B58E0
		public bool Equals(int4 rhs) => default; // 0x0000000185688F1C-0x0000000185688F40
		public override bool Equals(object o) => default; // 0x0000000189C751B4-0x0000000189C75220
		public override int GetHashCode() => default; // 0x0000000189C75220-0x0000000189C7523C
		public override string ToString() => default; // 0x0000000189C7523C-0x0000000189C75398
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C75398-0x0000000189C754EC
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int4x2 : IEquatable<Unity.Mathematics.int4x2>, IFormattable // TypeDefIndex: 53767
	{
		// Fields
		public int4 c0; // 0x00
		public int4 c1; // 0x10
	
		// Constructors
		public int4x2(int4 c0, int4 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D553F0-0x0000000183D55400
		public int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D83620-0x0000000183D83670
		public int4x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D835C0-0x0000000183D83600
		public int4x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D2A7F8-0x0000000184D2A8E8
		public int4x2(bool4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D2A77C-0x0000000184D2A7F8
		public int4x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D835C0-0x0000000183D83600
		public int4x2(uint4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C75B18-0x0000000189C75B80
		public int4x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D83600-0x0000000183D83620
		public int4x2(float4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D2A8E8-0x0000000184D2A970
		public int4x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D83670-0x0000000183D836D0
		public int4x2(double4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C75AB4-0x0000000189C75B18
	
		// Methods
		public static implicit operator int4x2(int v) => default; // 0x0000000182293840-0x0000000182294F90
		public bool Equals(int4x2 rhs) => default; // 0x0000000189C75594-0x0000000189C755D8
		public override bool Equals(object o) => default; // 0x0000000189C755D8-0x0000000189C7564C
		public override int GetHashCode() => default; // 0x0000000189C7564C-0x0000000189C75670
		public override string ToString() => default; // 0x0000000189C75670-0x0000000189C758A0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C758A0-0x0000000189C75AB4
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int4x3 : IEquatable<Unity.Mathematics.int4x3>, IFormattable // TypeDefIndex: 53768
	{
		// Fields
		public int4 c0; // 0x00
		public int4 c1; // 0x10
		public int4 c2; // 0x20
	
		// Constructors
		public int4x3(int4 c0, int4 c1, int4 c2) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D6B600-0x0000000183D6B620
		public int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D83750-0x0000000183D837D0
		public int4x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D837D0-0x0000000183D83820
		public int4x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D2AA28-0x0000000184D2AAE4
		public int4x3(bool4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D2A970-0x0000000184D2AA28
		public int4x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D837D0-0x0000000183D83820
		public int4x3(uint4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C76260-0x0000000189C762E8
		public int4x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D83820-0x0000000183D83850
		public int4x3(float4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D2AAE4-0x0000000184D2AC34
		public int4x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D836D0-0x0000000183D83750
		public int4x3(double4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C762E8-0x0000000189C76374
	
		// Methods
		public bool Equals(int4x3 rhs) => default; // 0x0000000189C75BFC-0x0000000189C75C5C
		public override bool Equals(object o) => default; // 0x0000000189C75B80-0x0000000189C75BFC
		public override int GetHashCode() => default; // 0x0000000189C75C5C-0x0000000189C75C8C
		public override string ToString() => default; // 0x0000000189C75F60-0x0000000189C76260
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C75C8C-0x0000000189C75F60
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct int4x4 : IEquatable<Unity.Mathematics.int4x4>, IFormattable // TypeDefIndex: 53769
	{
		// Fields
		public int4 c0; // 0x00
		public int4 c1; // 0x10
		public int4 c2; // 0x20
		public int4 c3; // 0x30
		public static readonly int4x4 identity; // 0x00
	
		// Constructors
		public int4x4(int4 c0, int4 c1, int4 c2, int4 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D7E4A0-0x0000000183D7E4D0
		public int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183A4DCE0-0x0000000183A4DD90
		public int4x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D83900-0x0000000183D83960
		public int4x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D2AC34-0x0000000184D2AD24
		public int4x4(bool4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D2AD24-0x0000000184D2AEC0
		public int4x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D83900-0x0000000183D83960
		public int4x4(uint4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C76C10-0x0000000189C76CBC
		public int4x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D83960-0x0000000183D839A0
		public int4x4(float4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D2AEC0-0x0000000184D2C678
		public int4x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D83850-0x0000000183D83900
		public int4x4(double4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C76CBC-0x0000000189C7A118
		static int4x4() {
			identity = default;
		} // 0x0000000183A4DD90-0x0000000183A4DE80
	
		// Methods
		public bool Equals(int4x4 rhs) => default; // 0x0000000189C763F8-0x0000000189C76474
		public override bool Equals(object o) => default; // 0x0000000189C76374-0x0000000189C763F8
		public override int GetHashCode() => default; // 0x0000000189C76474-0x0000000189C764AC
		public override string ToString() => default; // 0x0000000189C76840-0x0000000189C76C10
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C764AC-0x0000000189C76840
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct quaternion : IEquatable<Unity.Mathematics.quaternion>, IFormattable // TypeDefIndex: 53770
	{
		// Fields
		public float4 value; // 0x00
		public static readonly quaternion identity; // 0x00
	
		// Constructors
		public quaternion(float x, float y, float z, float w) {
			value = default;
		} // 0x0000000183D516B0-0x0000000183D516D0
		public quaternion(float4 value) {
			this.value = default;
		} // 0x0000000183D5E620-0x0000000183D5E630
		public quaternion(float3x3 m) {
			value = default;
		} // 0x00000001828B5440-0x00000001828B5820
		public quaternion(float4x4 m) {
			value = default;
		} // 0x0000000189C7C788-0x0000000189C7CAA8
		static quaternion() {
			identity = default;
		} // 0x0000000183D3AA20-0x0000000183D3AA60
	
		// Methods
		public static implicit operator Quaternion(quaternion q) => default; // 0x000000018294BC80-0x000000018294BCA0
		public static implicit operator quaternion(Quaternion q) => default; // 0x000000018294BC80-0x000000018294BCA0
		public static implicit operator quaternion(float4 v) => default; // 0x0000000183D5B250-0x0000000183D5B260
		public static quaternion AxisAngle(float3 axis, float angle) => default; // 0x00000001850C94C0-0x00000001850C95CC
		public static quaternion EulerXYZ(float3 xyz) => default; // 0x00000001850C95CC-0x00000001850C97AC
		public static quaternion EulerXZY(float3 xyz) => default; // 0x00000001850C97AC-0x00000001850C998C
		public static quaternion EulerYXZ(float3 xyz) => default; // 0x00000001850C998C-0x00000001850C9B6C
		public static quaternion EulerYZX(float3 xyz) => default; // 0x00000001850C9B6C-0x00000001850C9D4C
		public static quaternion EulerZXY(float3 xyz) => default; // 0x0000000189C7BC88-0x0000000189C7BE68
		public static quaternion EulerZYX(float3 xyz) => default; // 0x00000001850C9D84-0x00000001850C9F64
		public static quaternion EulerXYZ(float x, float y, float z) => default; // 0x0000000189C7BBA8-0x0000000189C7BBE0
		public static quaternion EulerXZY(float x, float y, float z) => default; // 0x0000000189C7BBE0-0x0000000189C7BC18
		public static quaternion EulerYXZ(float x, float y, float z) => default; // 0x0000000189C7BC18-0x0000000189C7BC50
		public static quaternion EulerYZX(float x, float y, float z) => default; // 0x0000000189C7BC50-0x0000000189C7BC88
		public static quaternion EulerZXY(float x, float y, float z) => default; // 0x00000001850C9D4C-0x00000001850C9D84
		public static quaternion EulerZYX(float x, float y, float z) => default; // 0x0000000189C7BE68-0x0000000189C7BEA0
		public static quaternion Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY /* Metadata: 0x01FD6115 */) => default; // 0x0000000189C7BEDC-0x0000000189C7C038
		public static quaternion Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY /* Metadata: 0x01FD6116 */) => default; // 0x0000000189C7BEA0-0x0000000189C7BEDC
		public static quaternion RotateX(float angle) => default; // 0x00000001850C9F64-0x00000001850C9FC8
		public static quaternion RotateY(float angle) => default; // 0x0000000189C7C464-0x0000000189C7C4C8
		public static quaternion RotateZ(float angle) => default; // 0x00000001850C9FC8-0x00000001850CA180
		public static quaternion LookRotation(float3 forward, float3 up) => default; // 0x0000000189C7C348-0x0000000189C7C464
		public static quaternion LookRotationSafe(float3 forward, float3 up) => default; // 0x0000000189C7C038-0x0000000189C7C348
		public bool Equals(quaternion x) => default; // 0x00000001822CDA10-0x00000001822CDA50
		public override bool Equals(object x) => default; // 0x0000000189C7BB3C-0x0000000189C7BBA8
		public override int GetHashCode() => default; // 0x0000000189C38878-0x0000000189C38894
		public override string ToString() => default; // 0x0000000189C7C4C8-0x0000000189C7C634
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C7C634-0x0000000189C7C788
	}

	[Il2CppEagerStaticClassConstruction]
	public static class noise // TypeDefIndex: 53771
	{
		// Methods
		public static float cnoise(float2 P) => default; // 0x0000000189C7A550-0x0000000189C7AAA8
		public static float pnoise(float2 P, float2 rep) => default; // 0x0000000189C7AE40-0x0000000189C7B3D4
		private static float2 mod289(float2 x) => default; // 0x0000000189C7ABF0-0x0000000189C7AC40
		private static float3 mod289(float3 x) => default; // 0x0000000189C7AB24-0x0000000189C7ABF0
		private static float4 mod289(float4 x) => default; // 0x0000000189C7AC40-0x0000000189C7ACE4
		private static float3 permute(float3 x) => default; // 0x0000000189C7AD7C-0x0000000189C7AE40
		private static float4 permute(float4 x) => default; // 0x0000000189C7ACE4-0x0000000189C7AD7C
		private static float4 taylorInvSqrt(float4 r) => default; // 0x0000000189C7BAE4-0x0000000189C7BB3C
		private static float2 fade(float2 t) => default; // 0x0000000189C7AAA8-0x0000000189C7AB24
		public static float snoise(float2 v) => default; // 0x0000000189C7B3D4-0x0000000189C7BAE4
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct Random // TypeDefIndex: 53772
	{
		// Fields
		public uint state; // 0x00
	
		// Constructors
		public Random(uint seed) {
			state = default;
		} // 0x0000000183D839D0-0x0000000183D839F0
	
		// Methods
		public static Random CreateFromIndex(uint index) => default; // 0x0000000189C7A118-0x0000000189C7A140
		internal static uint WangHash(uint n) => default; // 0x0000000183C843E0-0x0000000183C84410
		public float NextFloat() => default; // 0x0000000182AF8270-0x0000000182AF82B0
		public float3 NextFloat3() => default; // 0x00000001862C603C-0x00000001862C6154
		private uint NextState() => default; // 0x0000000183D839A0-0x0000000183D839D0
	}

	[Serializable]
	[Il2CppEagerStaticClassConstruction]
	public struct RigidTransform // TypeDefIndex: 53773
	{
		// Fields
		public quaternion rot; // 0x00
		public float3 pos; // 0x10
		public static readonly RigidTransform identity; // 0x00
	
		// Constructors
		public RigidTransform(quaternion rotation, float3 translation) {
			rot = default;
			pos = default;
		} // 0x0000000183D839F0-0x0000000183D83A10
		public RigidTransform(float3x3 rotation, float3 translation) {
			rot = default;
			pos = default;
		} // 0x0000000189C7A470-0x0000000189C7A4D4
		public RigidTransform(float4x4 transform) {
			rot = default;
			pos = default;
		} // 0x0000000189C7A4D4-0x0000000189C7A550
		static RigidTransform() {
			identity = default;
		} // 0x0000000183D21080-0x0000000183D210E0
	
		// Methods
		public bool Equals(RigidTransform x) => default; // 0x0000000189C7A1BC-0x0000000189C7A20C
		public override bool Equals(object x) => default; // 0x0000000189C7A140-0x0000000189C7A1BC
		public override int GetHashCode() => default; // 0x0000000189C7A20C-0x0000000189C7A258
		public override string ToString() => default; // 0x0000000189C7A258-0x0000000189C7A470
	}

	[Il2CppEagerStaticClassConstruction]
	public static class svd // TypeDefIndex: 53774
	{
		// Methods
		private static void condSwap(bool c, ref float x, ref float y) {} // 0x0000000184D5EC88-0x0000000184D5F760
		private static void condNegSwap(bool c, ref float3 x, ref float3 y) {} // 0x0000000184D5EC14-0x0000000184D5EC88
		private static quaternion condNegSwapQuat(bool c, quaternion q, float4 mask) => default; // 0x0000000189C7CB4C-0x0000000189C7CC08
		private static void sortSingularValues(ref float3x3 b, ref quaternion v) {} // 0x0000000189C7D718-0x0000000189C7D8C0
		private static quaternion approxGivensQuat(float3 pq, float4 mask) => default; // 0x0000000189C7CAA8-0x0000000189C7CB4C
		private static quaternion qrGivensQuat(float2 pq, float4 mask) => default; // 0x0000000189C7D320-0x0000000189C7D41C
		private static quaternion givensQRFactorization(float3x3 b, out float3x3 r) {
			r = default;
			return default;
		} // 0x0000000189C7CC08-0x0000000189C7CEB0
		private static quaternion jacobiIteration(ref float3x3 s, int iterations = 5 /* Metadata: 0x01FD6117 */) => default; // 0x0000000189C7CEB0-0x0000000189C7D320
		private static float3 singularValuesDecomposition(float3x3 a, out quaternion u, out quaternion v) {
			u = default;
			v = default;
			return default;
		} // 0x0000000189C7D52C-0x0000000189C7D718
		private static float3 rcpsafe(float3 x, float epsilon = 1E-09f /* Metadata: 0x01FD6118 */) => default; // 0x0000000189C7D41C-0x0000000189C7D52C
		public static float3x3 svdInverse(float3x3 a) => default; // 0x0000000189C7D8C0-0x0000000189C7DA88
		public static quaternion svdRotation(float3x3 a) => default; // 0x0000000189C7DA88-0x0000000189C7DB28
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint2 : IEquatable<Unity.Mathematics.uint2>, IFormattable // TypeDefIndex: 53776
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53775
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public uint2(uint x, uint y) {
			this.x = default;
			this.y = default;
		} // 0x0000000183D4E4B0-0x0000000183D4E4C0
		public uint2(uint2 xy) {
			x = default;
			y = default;
		} // 0x0000000183D824F0-0x0000000183D82500
		public uint2(uint v) {
			x = default;
			y = default;
		} // 0x0000000183D82490-0x0000000183D824A0
		public uint2(bool v) {
			x = default;
			y = default;
		} // 0x0000000189C72704-0x0000000189C72714
		public uint2(bool2 v) {
			x = default;
			y = default;
		} // 0x0000000189C72714-0x0000000189C72730
		public uint2(int v) {
			x = default;
			y = default;
		} // 0x0000000183D82490-0x0000000183D824A0
		public uint2(int2 v) {
			x = default;
			y = default;
		} // 0x0000000183D824F0-0x0000000183D82500
		public uint2(float v) {
			x = default;
			y = default;
		} // 0x0000000184D5F760-0x0000000184D5F8C0
		public uint2(float2 v) {
			x = default;
			y = default;
		} // 0x0000000189C7DCFC-0x0000000189C7DD38
		public uint2(double v) {
			x = default;
			y = default;
		} // 0x0000000189C7DCE0-0x0000000189C7DCFC
		public uint2(double2 v) {
			x = default;
			y = default;
		} // 0x0000000189C7DD38-0x0000000189C7DD5C
	
		// Methods
		public static implicit operator uint2(uint v) => default; // 0x0000000183D7B520-0x0000000183D7B530
		public static explicit operator uint2(int v) => default; // 0x0000000183D7B520-0x0000000183D7B530
		public static explicit operator uint2(int2 v) => default; // 0x0000000183D76940-0x0000000183D76960
		public static explicit operator uint2(float v) => default; // 0x0000000189C57A68-0x0000000189C57A8C
		public static explicit operator uint2(float2 v) => default; // 0x0000000189C57A8C-0x0000000189C57AB0
		public static explicit operator uint2(double v) => default; // 0x0000000189C57A48-0x0000000189C57A68
		public static explicit operator uint2(double2 v) => default; // 0x0000000189C57A18-0x0000000189C57A48
		public static uint2 operator *(uint2 lhs, uint2 rhs) => default; // 0x0000000183D82560-0x0000000183D82580
		public static uint2 operator *(uint2 lhs, uint rhs) => default; // 0x0000000183D82540-0x0000000183D82560
		public static uint2 operator +(uint2 lhs, uint2 rhs) => default; // 0x0000000183D4E4E0-0x0000000183D4E500
		public static uint2 operator +(uint2 lhs, uint rhs) => default; // 0x0000000183D82500-0x0000000183D82520
		public static uint2 operator -(uint2 lhs, uint2 rhs) => default; // 0x0000000183D4E500-0x0000000183D4E520
		public static uint2 operator -(uint2 lhs, uint rhs) => default; // 0x0000000183D825B0-0x0000000183D825D0
		public static bool2 operator >(uint2 lhs, uint rhs) => default; // 0x0000000189C7DD74-0x0000000189C7DD8C
		public static uint2 operator <<(uint2 x, int n) => default; // 0x0000000183D83A50-0x0000000183D83A80
		public static uint2 operator >>(uint2 x, int n) => default; // 0x0000000183D83A80-0x0000000183D83AB0
		public static bool2 operator ==(uint2 lhs, uint rhs) => default; // 0x0000000189C7DD5C-0x0000000189C7DD74
		public static uint2 operator &(uint2 lhs, uint rhs) => default; // 0x0000000183D83A10-0x0000000183D83A30
		public static uint2 operator |(uint2 lhs, uint2 rhs) => default; // 0x0000000183D82520-0x0000000183D82540
		public static uint2 operator ^(uint2 lhs, uint2 rhs) => default; // 0x0000000183D83A30-0x0000000183D83A50
		public bool Equals(uint2 rhs) => default; // 0x00000001851404D0-0x00000001851404E4
		public override bool Equals(object o) => default; // 0x0000000189C7DB28-0x0000000189C7DB9C
		public override int GetHashCode() => default; // 0x0000000189C7DB9C-0x0000000189C7DBD0
		public override string ToString() => default; // 0x0000000189C7DC58-0x0000000189C7DCE0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C7DBD0-0x0000000189C7DC58
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint2x2 : IEquatable<Unity.Mathematics.uint2x2>, IFormattable // TypeDefIndex: 53777
	{
		// Fields
		public uint2 c0; // 0x00
		public uint2 c1; // 0x08
		public static readonly uint2x2 identity; // 0x00
	
		// Constructors
		public uint2x2(uint2 c0, uint2 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D4EA10-0x0000000183D4EA20
		public uint2x2(uint m00, uint m01, uint m10, uint m11) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82730-0x0000000183D82760
		public uint2x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82670-0x0000000183D826A0
		public uint2x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C72B34-0x0000000189C72B7C
		public uint2x2(bool2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C72AC4-0x0000000189C72B34
		public uint2x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82670-0x0000000183D826A0
		public uint2x2(int2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82760-0x0000000183D827A0
		public uint2x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D5F8F8-0x0000000184D5F920
		public uint2x2(float2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D5F8C0-0x0000000184D5F8F8
		public uint2x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C7E11C-0x0000000189C7E160
		public uint2x2(double2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C7E0C4-0x0000000189C7E11C
		static uint2x2() {
			identity = default;
		} // 0x0000000183CBAC20-0x0000000183CBAC80
	
		// Methods
		public bool Equals(uint2x2 rhs) => default; // 0x0000000189C6A4D4-0x0000000189C6D61C
		public override bool Equals(object o) => default; // 0x0000000189C7DD8C-0x0000000189C7DDF8
		public override int GetHashCode() => default; // 0x0000000189C7DDF8-0x0000000189C7DE14
		public override string ToString() => default; // 0x0000000189C7DF68-0x0000000189C7E0C4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C7DE14-0x0000000189C7DF68
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint2x3 : IEquatable<Unity.Mathematics.uint2x3>, IFormattable // TypeDefIndex: 53778
	{
		// Fields
		public uint2 c0; // 0x00
		public uint2 c1; // 0x08
		public uint2 c2; // 0x10
	
		// Constructors
		public uint2x3(uint2 c0, uint2 c1, uint2 c2) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D54CF0-0x0000000183D54D00
		public uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82990-0x0000000183D829E0
		public uint2x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82900-0x0000000183D82940
		public uint2x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C73090-0x0000000189C730F4
		public uint2x3(bool2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C72FF8-0x0000000189C73090
		public uint2x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82900-0x0000000183D82940
		public uint2x3(int2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82940-0x0000000183D82990
		public uint2x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D5F9D8-0x0000000184D5FBB0
		public uint2x3(float2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D5F920-0x0000000184D5F9D8
		public uint2x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C7E578-0x0000000189C7E5D4
		public uint2x3(double2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C7E5D4-0x0000000189C7E650
	
		// Methods
		public bool Equals(uint2x3 rhs) => default; // 0x0000000189C72B7C-0x0000000189C72BE0
		public override bool Equals(object o) => default; // 0x0000000189C7E160-0x0000000189C7E1D4
		public override int GetHashCode() => default; // 0x0000000189C7E1D4-0x0000000189C7E1FC
		public override string ToString() => default; // 0x0000000189C7E1FC-0x0000000189C7E3C4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C7E3C4-0x0000000189C7E578
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint2x4 : IEquatable<Unity.Mathematics.uint2x4>, IFormattable // TypeDefIndex: 53779
	{
		// Fields
		public uint2 c0; // 0x00
		public uint2 c1; // 0x08
		public uint2 c2; // 0x10
		public uint2 c3; // 0x18
	
		// Constructors
		public uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D4EA20-0x0000000183D4EA40
		public uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82AE0-0x0000000183D82B40
		public uint2x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82BC0-0x0000000183D82C10
		public uint2x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C73710-0x0000000189C73794
		public uint2x4(bool2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C73644-0x0000000189C73710
		public uint2x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82BC0-0x0000000183D82C10
		public uint2x4(int2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D82A70-0x0000000183D82AE0
		public uint2x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D5FBB0-0x0000000184D5FBF0
		public uint2x4(float2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D5FBF0-0x0000000184D5FC64
		public uint2x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C7EBCC-0x0000000189C7EC44
		public uint2x4(double2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C7EB2C-0x0000000189C7EBCC
	
		// Methods
		public bool Equals(uint2x4 rhs) => default; // 0x0000000189C73168-0x0000000189C731DC
		public override bool Equals(object o) => default; // 0x0000000189C7E650-0x0000000189C7E6C4
		public override int GetHashCode() => default; // 0x0000000189C7E6C4-0x0000000189C7E6E8
		public override string ToString() => default; // 0x0000000189C7E6E8-0x0000000189C7E918
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C7E918-0x0000000189C7EB2C
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct uint3 : IEquatable<Unity.Mathematics.uint3>, IFormattable // TypeDefIndex: 53781
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
		public uint z; // 0x08
	
		// Properties
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzz { get => default; } // 0x0000000183D80710-0x0000000183D80730 
		public uint this[int index] { get => default; set {} } // 0x0000000183D55FF0-0x0000000183D56000 0x0000000183D56010-0x0000000183D56020
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53780
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public uint3(uint x, uint y, uint z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000183D4E5D0-0x0000000183D4E5E0
		public uint3(uint x, uint2 yz) : this() {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000183D82CF0-0x0000000183D82D00
		public uint3(uint2 xy, uint z) : this() {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000183D82D90-0x0000000183D82DA0
		public uint3(uint3 xyz) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D51BE0-0x0000000183D51C00
		public uint3(uint v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D82D60-0x0000000183D82D70
		public uint3(bool v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C73998-0x0000000189C739AC
		public uint3(bool3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C7396C-0x0000000189C73998
		public uint3(int v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D82D60-0x0000000183D82D70
		public uint3(int3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000183D51BE0-0x0000000183D51C00
		public uint3(float v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000184D5FCB0-0x0000000184D5FCE8
		public uint3(float3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000184D5FC64-0x0000000184D5FCB0
		public uint3(double v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C7EE90-0x0000000189C7EEB4
		public uint3(double3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000189C7EE60-0x0000000189C7EE90
	
		// Methods
		public static implicit operator uint3(uint v) => default; // 0x0000000183D7B570-0x0000000183D7B580
		public static explicit operator uint3(int v) => default; // 0x0000000183D7B570-0x0000000183D7B580
		public static explicit operator uint3(int3 v) => default; // 0x0000000183D7B5F0-0x0000000183D7B620
		public static explicit operator uint3(float v) => default; // 0x0000000189C57D5C-0x0000000189C57D78
		public static explicit operator uint3(float3 v) => default; // 0x0000000184D5FCE8-0x0000000184D5FD34
		public static explicit operator uint3(double v) => default; // 0x0000000189C57D34-0x0000000189C57D5C
		public static explicit operator uint3(double3 v) => default; // 0x0000000189C57CFC-0x0000000189C57D34
		public static uint3 operator *(uint3 lhs, uint3 rhs) => default; // 0x000000018304D500-0x000000018304D530
		public static uint3 operator *(uint3 lhs, uint rhs) => default; // 0x0000000183D82E30-0x0000000183D82E50
		public static uint3 operator +(uint3 lhs, uint3 rhs) => default; // 0x00000001825BE440-0x00000001825BE460
		public static uint3 operator +(uint3 lhs, uint rhs) => default; // 0x0000000183D82DE0-0x0000000183D82E10
		public static uint3 operator -(uint3 lhs, uint3 rhs) => default; // 0x0000000183D82EA0-0x0000000183D82EC0
		public static uint3 operator -(uint3 lhs, uint rhs) => default; // 0x0000000183D82E80-0x0000000183D82EA0
		public static bool3 operator >(uint3 lhs, uint rhs) => default; // 0x0000000189C7EED4-0x0000000189C7EEF4
		public static uint3 operator <<(uint3 x, int n) => default; // 0x0000000183D83AF0-0x0000000183D83B20
		public static uint3 operator >>(uint3 x, int n) => default; // 0x0000000183D83B20-0x0000000183D83B60
		public static bool3 operator ==(uint3 lhs, uint rhs) => default; // 0x0000000189C7EEB4-0x0000000189C7EED4
		public static uint3 operator &(uint3 lhs, uint rhs) => default; // 0x0000000183D83AB0-0x0000000183D83AD0
		public static uint3 operator |(uint3 lhs, uint3 rhs) => default; // 0x0000000183D82E10-0x0000000183D82E30
		public static uint3 operator |(uint lhs, uint3 rhs) => default; // 0x0000000183D83AD0-0x0000000183D83AF0
		public static uint3 operator ^(uint3 lhs, uint3 rhs) => default; // 0x00000001828B79E0-0x00000001828B7A00
		public bool Equals(uint3 rhs) => default; // 0x00000001851408A4-0x00000001851408C0
		public override bool Equals(object o) => default; // 0x0000000189C7EC44-0x0000000189C7ECD8
		public override int GetHashCode() => default; // 0x0000000189C7ECD8-0x0000000189C7ECFC
		public override string ToString() => default; // 0x0000000189C7EDAC-0x0000000189C7EE60
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C7ECFC-0x0000000189C7EDAC
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint3x2 : IEquatable<Unity.Mathematics.uint3x2>, IFormattable // TypeDefIndex: 53782
	{
		// Fields
		public uint3 c0; // 0x00
		public uint3 c1; // 0x0C
	
		// Constructors
		public uint3x2(uint3 c0, uint3 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D4FF30-0x0000000183D4FF50
		public uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82EE0-0x0000000183D82F20
		public uint3x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82F70-0x0000000183D82FA0
		public uint3x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D29BD0-0x0000000184D29DA0
		public uint3x2(bool3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C73F48-0x0000000189C74034
		public uint3x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D82F70-0x0000000183D82FA0
		public uint3x2(int3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D29DA0-0x0000000184D29E14
		public uint3x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D5FD34-0x0000000184D5FD90
		public uint3x2(float3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D5FD90-0x0000000184D5FE94
		public uint3x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C7F37C-0x0000000189C7F3D8
		public uint3x2(double3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C7F3D8-0x0000000189C7F468
	
		// Methods
		public bool Equals(uint3x2 rhs) => default; // 0x0000000189C7EF68-0x0000000189C7EFD8
		public override bool Equals(object o) => default; // 0x0000000189C7EEF4-0x0000000189C7EF68
		public override int GetHashCode() => default; // 0x0000000189C7EFD8-0x0000000189C7F000
		public override string ToString() => default; // 0x0000000189C7F1B4-0x0000000189C7F37C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C7F000-0x0000000189C7F1B4
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint3x3 : IEquatable<Unity.Mathematics.uint3x3>, IFormattable // TypeDefIndex: 53783
	{
		// Fields
		public uint3 c0; // 0x00
		public uint3 c1; // 0x0C
		public uint3 c2; // 0x18
		public static readonly uint3x3 identity; // 0x00
	
		// Constructors
		public uint3x3(uint3 c0, uint3 c1, uint3 c2) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D55290-0x0000000183D552D0
		public uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183B6C9D0-0x0000000183B6CA30
		public uint3x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82FF0-0x0000000183D83040
		public uint3x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D2A078-0x0000000184D2A108
		public uint3x3(bool3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C74610-0x0000000189C74758
		public uint3x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D82FF0-0x0000000183D83040
		public uint3x3(int3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D2A108-0x0000000184D2A254
		public uint3x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D5FF18-0x0000000184D6005C
		public uint3x3(float3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D6005C-0x0000000184D6020C
		public uint3x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D5FE94-0x0000000184D5FF18
		public uint3x3(double3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C7FA58-0x0000000189C7FB24
		static uint3x3() {
			identity = default;
		} // 0x0000000183B6C930-0x0000000183B6C9D0
	
		// Methods
		public bool Equals(uint3x3 rhs) => default; // 0x0000000189C7F4E4-0x0000000189C7F584
		public override bool Equals(object o) => default; // 0x0000000189C7F468-0x0000000189C7F4E4
		public override int GetHashCode() => default; // 0x0000000189C7F584-0x0000000189C7F5B0
		public override string ToString() => default; // 0x0000000189C7F5B0-0x0000000189C7F814
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C7F814-0x0000000189C7FA58
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint3x4 : IEquatable<Unity.Mathematics.uint3x4>, IFormattable // TypeDefIndex: 53784
	{
		// Fields
		public uint3 c0; // 0x00
		public uint3 c1; // 0x0C
		public uint3 c2; // 0x18
		public uint3 c3; // 0x24
	
		// Constructors
		public uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D81850-0x0000000183D818A0
		public uint3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D832A0-0x0000000183D83330
		public uint3x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D831B0-0x0000000183D83210
		public uint3x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D2A3FC-0x0000000184D2A77C
		public uint3x4(bool3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C74F44-0x0000000189C750D8
		public uint3x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D831B0-0x0000000183D83210
		public uint3x4(int3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D2A254-0x0000000184D2A328
		public uint3x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D6020C-0x0000000184D602A8
		public uint3x4(float3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D60350-0x0000000184D60424
		public uint3x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D602A8-0x0000000184D60350
		public uint3x4(double3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C80260-0x0000000189C8036C
	
		// Methods
		public bool Equals(uint3x4 rhs) => default; // 0x0000000189C7FBA0-0x0000000189C7FC5C
		public override bool Equals(object o) => default; // 0x0000000189C7FB24-0x0000000189C7FBA0
		public override int GetHashCode() => default; // 0x0000000189C7FC5C-0x0000000189C7FC8C
		public override string ToString() => default; // 0x0000000189C7FF60-0x0000000189C80260
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C7FC8C-0x0000000189C7FF60
	}

	[Serializable]
	[DebuggerTypeProxy(typeof(DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	public struct uint4 : IEquatable<Unity.Mathematics.uint4>, IFormattable // TypeDefIndex: 53786
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
		public uint z; // 0x08
		public uint w; // 0x0C
	
		// Properties
		public uint this[int index] { get => default; set {} } // 0x0000000183D55FF0-0x0000000183D56000 0x0000000183D56010-0x0000000183D56020
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 53785
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public uint4(uint x, uint y, uint z, uint w) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D517E0-0x0000000183D51800
		public uint4(uint x, uint y, uint2 zw) : this() {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000183D83330-0x0000000183D83350
		public uint4(uint x, uint2 yz, uint w) : this() {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D83430-0x0000000183D83450
		public uint4(uint x, uint3 yzw) : this() {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D83400-0x0000000183D83420
		public uint4(uint2 xy, uint z, uint w) : this() {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000183D83450-0x0000000183D83470
		public uint4(uint2 xy, uint2 zw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D83350-0x0000000183D83370
		public uint4(uint3 xyz, uint w) : this() {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000183D833E0-0x0000000183D83400
		public uint4(uint4 xyzw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D5DBB0-0x0000000183D5DBD0
		public uint4(uint v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D83390-0x0000000183D833A0
		public uint4(bool v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C754EC-0x0000000189C75508
		public uint4(bool4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C75508-0x0000000189C7554C
		public uint4(int v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D83390-0x0000000183D833A0
		public uint4(int4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000183D5DBB0-0x0000000183D5DBD0
		public uint4(float v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000184D60488-0x0000000184D605C0
		public uint4(float4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000184D60424-0x0000000184D60488
		public uint4(double v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C806A4-0x0000000189C806D0
		public uint4(double4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000189C806D0-0x0000000189C8070C
	
		// Methods
		public static implicit operator uint4(uint v) => default; // 0x0000000183D7B6A0-0x0000000183D7B6B0
		public static explicit operator uint4(int v) => default; // 0x0000000183D7B6A0-0x0000000183D7B6B0
		public static explicit operator uint4(int4 v) => default; // 0x0000000189C3D070-0x0000000189C3D09C
		public static explicit operator uint4(float v) => default; // 0x0000000189C58070-0x0000000189C58088
		public static explicit operator uint4(float4 v) => default; // 0x0000000189C580B8-0x0000000189C580DC
		public static explicit operator uint4(double v) => default; // 0x0000000189C58088-0x0000000189C580B8
		public static explicit operator uint4(double4 v) => default; // 0x0000000189C58028-0x0000000189C58070
		public static uint4 operator *(uint4 lhs, uint4 rhs) => default; // 0x0000000183D834D0-0x0000000183D83500
		public static uint4 operator *(uint4 lhs, uint rhs) => default; // 0x0000000183D83500-0x0000000183D83530
		public static uint4 operator *(uint lhs, uint4 rhs) => default; // 0x0000000183D83BC0-0x0000000183D83BF0
		public static uint4 operator +(uint4 lhs, uint4 rhs) => default; // 0x0000000183D834A0-0x0000000183D834D0
		public static uint4 operator +(uint4 lhs, uint rhs) => default; // 0x0000000183D83470-0x0000000183D834A0
		public static uint4 operator -(uint4 lhs, uint4 rhs) => default; // 0x0000000183D83C40-0x0000000183D83C70
		public static uint4 operator -(uint4 lhs, uint rhs) => default; // 0x0000000183D83560-0x0000000183D83590
		public static bool4 operator >(uint4 lhs, uint rhs) => default; // 0x0000000189C80730-0x0000000189C80754
		public static uint4 operator <<(uint4 x, int n) => default; // 0x0000000183D83B90-0x0000000183D83BC0
		public static uint4 operator >>(uint4 x, int n) => default; // 0x0000000183D83BF0-0x0000000183D83C40
		public static bool4 operator ==(uint4 lhs, uint rhs) => default; // 0x0000000189C8070C-0x0000000189C80730
		public static uint4 operator ~(uint4 val) => default; // 0x00000001828B5880-0x00000001828B58B0
		public static uint4 operator &(uint4 lhs, uint4 rhs) => default; // 0x00000001828B5820-0x00000001828B5850
		public static uint4 operator &(uint4 lhs, uint rhs) => default; // 0x0000000183D83B60-0x0000000183D83B90
		public static uint4 operator |(uint4 lhs, uint4 rhs) => default; // 0x00000001828B58B0-0x00000001828B58E0
		public static uint4 operator ^(uint4 lhs, uint4 rhs) => default; // 0x00000001828B5850-0x00000001828B5880
		public bool Equals(uint4 rhs) => default; // 0x0000000185688F1C-0x0000000185688F40
		public override bool Equals(object o) => default; // 0x0000000189C8036C-0x0000000189C803D8
		public override int GetHashCode() => default; // 0x0000000189C803D8-0x0000000189C803F4
		public override string ToString() => default; // 0x0000000189C80548-0x0000000189C806A4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C803F4-0x0000000189C80548
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint4x2 : IEquatable<Unity.Mathematics.uint4x2>, IFormattable // TypeDefIndex: 53787
	{
		// Fields
		public uint4 c0; // 0x00
		public uint4 c1; // 0x10
	
		// Constructors
		public uint4x2(uint4 c0, uint4 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183D553F0-0x0000000183D55400
		public uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D83620-0x0000000183D83670
		public uint4x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D835C0-0x0000000183D83600
		public uint4x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D605C0-0x0000000184D60634
		public uint4x2(bool4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D60738-0x0000000184D60878
		public uint4x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000183D835C0-0x0000000183D83600
		public uint4x2(int4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C75B18-0x0000000189C75B80
		public uint4x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D606A0-0x0000000184D60738
		public uint4x2(float4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C80CCC-0x0000000189C80D20
		public uint4x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000184D60634-0x0000000184D606A0
		public uint4x2(double4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000189C80C30-0x0000000189C80CCC
	
		// Methods
		public bool Equals(uint4x2 rhs) => default; // 0x0000000189C75594-0x0000000189C755D8
		public override bool Equals(object o) => default; // 0x0000000189C80754-0x0000000189C807C8
		public override int GetHashCode() => default; // 0x0000000189C807C8-0x0000000189C807EC
		public override string ToString() => default; // 0x0000000189C807EC-0x0000000189C80A1C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C80A1C-0x0000000189C80C30
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint4x3 : IEquatable<Unity.Mathematics.uint4x3>, IFormattable // TypeDefIndex: 53788
	{
		// Fields
		public uint4 c0; // 0x00
		public uint4 c1; // 0x10
		public uint4 c2; // 0x20
	
		// Constructors
		public uint4x3(uint4 c0, uint4 c1, uint4 c2) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000183D6B600-0x0000000183D6B620
		public uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D83750-0x0000000183D837D0
		public uint4x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D837D0-0x0000000183D83820
		public uint4x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D60B74-0x0000000184D60C18
		public uint4x3(bool4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D60918-0x0000000184D60A24
		public uint4x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000183D837D0-0x0000000183D83820
		public uint4x3(int4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C76260-0x0000000189C762E8
		public uint4x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D60A24-0x0000000184D60B74
		public uint4x3(float4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C813A0-0x0000000189C81418
		public uint4x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000184D60878-0x0000000184D60918
		public uint4x3(double4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000189C81418-0x0000000189C81500
	
		// Methods
		public bool Equals(uint4x3 rhs) => default; // 0x0000000189C75BFC-0x0000000189C75C5C
		public override bool Equals(object o) => default; // 0x0000000189C80D20-0x0000000189C80D9C
		public override int GetHashCode() => default; // 0x0000000189C80D9C-0x0000000189C80DCC
		public override string ToString() => default; // 0x0000000189C80DCC-0x0000000189C810CC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C810CC-0x0000000189C813A0
	}

	[Serializable]
	[DefaultMember("Item")]
	[Il2CppEagerStaticClassConstruction]
	public struct uint4x4 : IEquatable<Unity.Mathematics.uint4x4>, IFormattable // TypeDefIndex: 53789
	{
		// Fields
		public uint4 c0; // 0x00
		public uint4 c1; // 0x10
		public uint4 c2; // 0x20
		public uint4 c3; // 0x30
		public static readonly uint4x4 identity; // 0x00
	
		// Constructors
		public uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3) {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000183D7E4A0-0x0000000183D7E4D0
		public uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183A4DCE0-0x0000000183A4DD90
		public uint4x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D83900-0x0000000183D83960
		public uint4x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D60C18-0x0000000184D60CEC
		public uint4x4(bool4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D60F6C-0x0000000184D6114C
		public uint4x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000183D83900-0x0000000183D83960
		public uint4x4(int4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C76C10-0x0000000189C76CBC
		public uint4x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D60DBC-0x0000000184D60F6C
		public uint4x4(float4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C81E50-0x0000000189C81EE4
		public uint4x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000184D60CEC-0x0000000184D60DBC
		public uint4x4(double4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000189C81D20-0x0000000189C81E50
		static uint4x4() {
			identity = default;
		} // 0x0000000183A4DBF0-0x0000000183A4DCE0
	
		// Methods
		public bool Equals(uint4x4 rhs) => default; // 0x0000000189C763F8-0x0000000189C76474
		public override bool Equals(object o) => default; // 0x0000000189C81500-0x0000000189C81584
		public override int GetHashCode() => default; // 0x0000000189C81584-0x0000000189C815BC
		public override string ToString() => default; // 0x0000000189C815BC-0x0000000189C8198C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x0000000189C8198C-0x0000000189C81D20
	}
}
