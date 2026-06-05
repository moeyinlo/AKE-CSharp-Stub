/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using UnityEngine;

// Image 31: Unity.Mathematics.dll - Assembly: Unity.Mathematics, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 54689-54782

namespace Unity.IL2CPP.CompilerServices
{
	internal class Il2CppEagerStaticClassConstructionAttribute : Attribute // TypeDefIndex: 54690
	{
		// Constructors
		public Il2CppEagerStaticClassConstructionAttribute() {} // 0x0000000185492010-0x0000000185492020
	}
}

namespace Unity.Mathematics
{
	[Serializable]
	public struct AffineTransform : IEquatable<Unity.Mathematics.AffineTransform>, IFormattable // TypeDefIndex: 54691
	{
		// Fields
		public float3x3 rs; // 0x00
		public float3 t; // 0x24
		public static readonly AffineTransform identity; // 0x00
	
		// Constructors
		public AffineTransform(float3 translation, quaternion rotation) {
			rs = default;
			t = default;
		} // 0x000000018BD78C78-0x000000018BD78CD0
		public AffineTransform(float3 translation, quaternion rotation, float3 scale) {
			rs = default;
			t = default;
		} // 0x000000018BD78BD0-0x000000018BD78C78
		public AffineTransform(float3 translation, float3x3 rotationScale) {
			rs = default;
			t = default;
		} // 0x0000000185FDE0C0-0x0000000185FDE0F0
		public AffineTransform(float3x3 rotationScale) {
			rs = default;
			t = default;
		} // 0x000000018BD78B68-0x000000018BD78BD0
		public AffineTransform(RigidTransform rigid) {
			rs = default;
			t = default;
		} // 0x000000018BD78B10-0x000000018BD78B68
		public AffineTransform(float3x4 m) {
			rs = default;
			t = default;
		} // 0x0000000186F0EC5C-0x0000000186F0ED94
		public AffineTransform(float4x4 m) {
			rs = default;
			t = default;
		} // 0x0000000186F0ED94-0x0000000186F0EF90
		static AffineTransform() {
			identity = default;
		} // 0x0000000185F07B90-0x0000000185F07C30
	
		// Methods
		public bool Equals(AffineTransform rhs) => default; // 0x000000018BD78474-0x000000018BD784DC
		public override bool Equals(object o) => default; // 0x000000018BD783F8-0x000000018BD78474
		public override int GetHashCode() => default; // 0x000000018BD784DC-0x000000018BD7850C
		public override string ToString() => default; // 0x000000018BD787E0-0x000000018BD78B10
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7850C-0x000000018BD787E0
	}

	public static class math // TypeDefIndex: 54695
	{
		// Fields
		public const double E_DBL = 2.718281828459045; // Metadata: 0x0207B872
		public const double LOG2E_DBL = 1.4426950408889634; // Metadata: 0x0207B87A
		public const double LOG10E_DBL = 0.4342944819032518; // Metadata: 0x0207B882
		public const double LN2_DBL = 0.6931471805599453; // Metadata: 0x0207B88A
		public const double LN10_DBL = 2.302585092994046; // Metadata: 0x0207B892
		public const double PI_DBL = 3.141592653589793; // Metadata: 0x0207B89A
		public const double PI2_DBL = 6.283185307179586; // Metadata: 0x0207B8A2
		public const double PIHALF_DBL = 1.5707963267948966; // Metadata: 0x0207B8AA
		public const double TAU_DBL = 6.283185307179586; // Metadata: 0x0207B8B2
		public const double TODEGREES_DBL = 57.29577951308232; // Metadata: 0x0207B8BA
		public const double TORADIANS_DBL = 0.017453292519943295; // Metadata: 0x0207B8C2
		public const double SQRT2_DBL = 1.4142135623730951; // Metadata: 0x0207B8CA
		public const double EPSILON_DBL = 2.220446049250313E-16; // Metadata: 0x0207B8D2
		public const double INFINITY_DBL = 1D / 0D; // Metadata: 0x0207B8DA
		public const double NAN_DBL = 0D / 0D; // Metadata: 0x0207B8E2
		public const float FLT_MIN_NORMAL = 1.1754944E-38f; // Metadata: 0x0207B8EA
		public const double DBL_MIN_NORMAL = 2.2250738585072014E-308; // Metadata: 0x0207B8EE
		public const float E = 2.7182817f; // Metadata: 0x0207B8F6
		public const float LOG2E = 1.442695f; // Metadata: 0x0207B8FA
		public const float LOG10E = 0.4342945f; // Metadata: 0x0207B8FE
		public const float LN2 = 0.6931472f; // Metadata: 0x0207B902
		public const float LN10 = 2.3025851f; // Metadata: 0x0207B906
		public const float PI = 3.1415927f; // Metadata: 0x0207B90A
		public const float PI2 = 6.2831855f; // Metadata: 0x0207B90E
		public const float PIHALF = 1.5707964f; // Metadata: 0x0207B912
		public const float TAU = 6.2831855f; // Metadata: 0x0207B916
		public const float TODEGREES = 57.29578f; // Metadata: 0x0207B91A
		public const float TORADIANS = 0.017453292f; // Metadata: 0x0207B91E
		public const float SQRT2 = 1.4142135f; // Metadata: 0x0207B922
		public const float EPSILON = 1.1920929E-07f; // Metadata: 0x0207B926
		public const float INFINITY = 1F / 0F; // Metadata: 0x0207B92A
		public const float NAN = 0F / 0F; // Metadata: 0x0207B92E
	
		// Nested types
		public enum RotationOrder : byte // TypeDefIndex: 54692
		{
			XYZ = 0,
			XZY = 1,
			YXZ = 2,
			YZX = 3,
			ZXY = 4,
			Default = 4,
			ZYX = 5
		}
	
		public enum ShuffleComponent : byte // TypeDefIndex: 54693
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
	
		internal struct LongDoubleUnion // TypeDefIndex: 54694
		{
			// Fields
			public long longValue; // 0x00
			public double doubleValue; // 0x00
		}
	
		// Methods
		public static AffineTransform AffineTransform(float3 translation, quaternion rotation) => default; // 0x000000018BD46018-0x000000018BD46064
		public static AffineTransform AffineTransform(float3 translation, quaternion rotation, float3 scale) => default; // 0x000000018BD46064-0x000000018BD460C8
		public static AffineTransform AffineTransform(float3 translation, float3x3 rotationScale) => default; // 0x0000000185FD8ED0-0x0000000185FD8F00
		public static AffineTransform AffineTransform(float3x3 rotationScale) => default; // 0x000000018BD45F88-0x000000018BD45FCC
		public static AffineTransform AffineTransform(float4x4 m) => default; // 0x000000018BD45FCC-0x000000018BD46018
		public static AffineTransform AffineTransform(float3x4 m) => default; // 0x000000018BD4610C-0x000000018BD46150
		public static AffineTransform AffineTransform(RigidTransform rigid) => default; // 0x000000018BD460C8-0x000000018BD4610C
		public static float4x4 float4x4(AffineTransform transform) => default; // 0x000000018BD4E91C-0x000000018BD4EA18
		public static float3x4 float3x4(AffineTransform transform) => default; // 0x000000018BD4DFD0-0x000000018BD4E064
		public static AffineTransform mul(AffineTransform a, AffineTransform b) => default; // 0x000000018BD641E4-0x000000018BD642CC
		public static AffineTransform mul(float3x3 a, AffineTransform b) => default; // 0x000000018BD62EF4-0x000000018BD62FD0
		public static AffineTransform mul(AffineTransform a, float3x3 b) => default; // 0x000000018BD66140-0x000000018BD661D4
		public static float4 mul(AffineTransform a, float4 pos) => default; // 0x000000018BD68C70-0x000000018BD68D5C
		public static float3 rotate(AffineTransform a, float3 dir) => default; // 0x000000018BD6C3B4-0x000000018BD6C414
		public static float3 transform(AffineTransform a, float3 pos) => default; // 0x000000018BD6FC5C-0x000000018BD6FD00
		public static AffineTransform inverse(AffineTransform a) => default; // 0x000000018BD56E80-0x000000018BD56F78
		public static void decompose(AffineTransform a, out float3 translation, out quaternion rotation, out float3 scale) {
			translation = default;
			rotation = default;
			scale = default;
		} // 0x000000018BD49C58-0x000000018BD49D68
		public static uint hash(AffineTransform a) => default; // 0x000000018BD4F698-0x000000018BD4F6EC
		public static uint4 hashwide(AffineTransform a) => default; // 0x000000018BD53CEC-0x000000018BD53DE8
		public static bool2 bool2(bool x, bool y) => default; // 0x0000000185FD9450-0x0000000185FD9460
		public static bool2 bool2(bool2 xy) => default; // 0x0000000185FD9470-0x0000000185FD9490
		public static bool2 bool2(bool v) => default; // 0x0000000185FD9460-0x0000000185FD9470
		public static uint hash(bool2 v) => default; // 0x000000018BD50E18-0x000000018BD50E60
		public static uint2 hashwide(bool2 v) => default; // 0x000000018BD53588-0x000000018BD535BC
		public static bool shuffle(bool2 left, bool2 right, ShuffleComponent x) => default; // 0x0000000186F41CA0-0x0000000186F41D8C
		public static bool2 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000186F435B8-0x0000000186F436A4
		public static bool3 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000186F41E80-0x0000000186F42300
		public static bool4 shuffle(bool2 left, bool2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000186F4244C-0x0000000186F424CC
		internal static bool select_shuffle_component(bool2 a, bool2 b, ShuffleComponent component) => default; // 0x0000000186F41264-0x0000000186F41354
		public static bool2x2 bool2x2(bool2 c0, bool2 c1) => default; // 0x0000000185FD9490-0x0000000185FD94A0
		public static bool2x2 bool2x2(bool m00, bool m01, bool m10, bool m11) => default; // 0x0000000186F17108-0x0000000186F17138
		public static bool2x2 bool2x2(bool v) => default; // 0x000000018BD48488-0x000000018BD484AC
		public static bool2x2 transpose(bool2x2 v) => default; // 0x000000018BD70478-0x000000018BD7049C
		public static uint hash(bool2x2 v) => default; // 0x000000018BD50C3C-0x000000018BD50CCC
		public static uint2 hashwide(bool2x2 v) => default; // 0x000000018BD551D8-0x000000018BD5525C
		public static bool2x3 bool2x3(bool2 c0, bool2 c1, bool2 c2) => default; // 0x0000000185FD94A0-0x0000000185FD94C0
		public static bool2x3 bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12) => default; // 0x0000000186F17138-0x0000000186F171F4
		public static bool2x3 bool2x3(bool v) => default; // 0x000000018BD484AC-0x000000018BD484C8
		public static bool3x2 transpose(bool2x3 v) => default; // 0x000000018BD70184-0x000000018BD701CC
		public static uint hash(bool2x3 v) => default; // 0x000000018BD51BB8-0x000000018BD51C84
		public static uint2 hashwide(bool2x3 v) => default; // 0x000000018BD53990-0x000000018BD53A54
		public static bool2x4 bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3) => default; // 0x0000000185FD94C0-0x0000000185FD94F0
		public static bool2x4 bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13) => default; // 0x000000018BD484C8-0x000000018BD48520
		public static bool2x4 bool2x4(bool v) => default; // 0x000000018BD48520-0x000000018BD48544
		public static bool4x2 transpose(bool2x4 v) => default; // 0x000000018BD70AC4-0x000000018BD70B18
		public static uint hash(bool2x4 v) => default; // 0x000000018BD51088-0x000000018BD511A0
		public static uint2 hashwide(bool2x4 v) => default; // 0x000000018BD55D98-0x000000018BD55EA4
		public static bool3 bool3(bool x, bool y, bool z) => default; // 0x0000000185FD94F0-0x0000000185FD9500
		public static bool3 bool3(bool x, bool2 yz) => default; // 0x0000000185FD9530-0x0000000185FD9550
		public static bool3 bool3(bool2 xy, bool z) => default; // 0x0000000185FD9510-0x0000000185FD9530
		public static bool3 bool3(bool3 xyz) => default; // 0x0000000185FD9550-0x0000000185FD9570
		public static bool3 bool3(bool v) => default; // 0x0000000185FD9500-0x0000000185FD9510
		public static uint hash(bool3 v) => default; // 0x0000000186F1DA94-0x0000000186F1DB24
		public static uint3 hashwide(bool3 v) => default; // 0x000000018BD5478C-0x000000018BD54818
		public static bool shuffle(bool3 left, bool3 right, ShuffleComponent x) => default; // 0x0000000186F42708-0x0000000186F42740
		public static bool2 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x000000018BD6E0B4-0x000000018BD6E12C
		public static bool3 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x000000018BD6DC38-0x000000018BD6DCF4
		public static bool4 shuffle(bool3 left, bool3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x000000018BD6D34C-0x000000018BD6D430
		internal static bool select_shuffle_component(bool3 a, bool3 b, ShuffleComponent component) => default; // 0x0000000186F416B0-0x0000000186F417B4
		public static bool3x2 bool3x2(bool3 c0, bool3 c1) => default; // 0x0000000185FD9570-0x0000000185FD95A0
		public static bool3x2 bool3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21) => default; // 0x0000000186F171F4-0x0000000186F1722C
		public static bool3x2 bool3x2(bool v) => default; // 0x000000018BD48544-0x000000018BD48560
		public static bool2x3 transpose(bool3x2 v) => default; // 0x000000018BD70D54-0x000000018BD70D9C
		public static uint hash(bool3x2 v) => default; // 0x0000000186F1F9D4-0x0000000186F205C0
		public static uint3 hashwide(bool3x2 v) => default; // 0x000000018BD5542C-0x000000018BD55554
		public static bool3x3 bool3x3(bool3 c0, bool3 c1, bool3 c2) => default; // 0x0000000185FD95A0-0x0000000185FD95E0
		public static bool3x3 bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22) => default; // 0x0000000186F1722C-0x0000000186F1728C
		public static bool3x3 bool3x3(bool v) => default; // 0x000000018BD48560-0x000000018BD4857C
		public static bool3x3 transpose(bool3x3 v) => default; // 0x000000018BD70A64-0x000000018BD70AC4
		public static uint hash(bool3x3 v) => default; // 0x0000000186F207F8-0x0000000186F21F38
		public static uint3 hashwide(bool3x3 v) => default; // 0x000000018BD55554-0x000000018BD55718
		public static bool3x4 bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3) => default; // 0x0000000185FD95E0-0x0000000185FD9630
		public static bool3x4 bool3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23) => default; // 0x0000000186F1728C-0x0000000186F173C4
		public static bool3x4 bool3x4(bool v) => default; // 0x000000018BD4857C-0x000000018BD48598
		public static bool4x3 transpose(bool3x4 v) => default; // 0x000000018BD70D9C-0x000000018BD70E14
		public static uint hash(bool3x4 v) => default; // 0x0000000186F1EA94-0x0000000186F1F28C
		public static uint3 hashwide(bool3x4 v) => default; // 0x000000018BD540F0-0x000000018BD54344
		public static bool4 bool4(bool x, bool y, bool z, bool w) => default; // 0x0000000185FD9670-0x0000000185FD9690
		public static bool4 bool4(bool x, bool y, bool2 zw) => default; // 0x0000000185FD9700-0x0000000185FD9720
		public static bool4 bool4(bool x, bool2 yz, bool w) => default; // 0x0000000185FD9650-0x0000000185FD9670
		public static bool4 bool4(bool x, bool3 yzw) => default; // 0x0000000185FD9750-0x0000000185FD9780
		public static bool4 bool4(bool2 xy, bool z, bool w) => default; // 0x0000000185FD9630-0x0000000185FD9650
		public static bool4 bool4(bool2 xy, bool2 zw) => default; // 0x0000000185FD96B0-0x0000000185FD96D0
		public static bool4 bool4(bool3 xyz, bool w) => default; // 0x0000000185FD9720-0x0000000185FD9750
		public static bool4 bool4(bool4 xyzw) => default; // 0x0000000185FD96D0-0x0000000185FD9700
		public static bool4 bool4(bool v) => default; // 0x0000000185FD9690-0x0000000185FD96B0
		public static uint hash(bool4 v) => default; // 0x0000000186F1F28C-0x0000000186F1F334
		public static uint4 hashwide(bool4 v) => default; // 0x000000018BD559A4-0x000000018BD55A28
		public static bool shuffle(bool4 left, bool4 right, ShuffleComponent x) => default; // 0x0000000186F41C98-0x0000000186F41CA0
		public static bool2 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000186F43960-0x0000000186F43A50
		public static bool3 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000186F43438-0x0000000186F434A0
		public static bool4 shuffle(bool4 left, bool4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000186F42AF8-0x0000000186F42B70
		internal static bool select_shuffle_component(bool4 a, bool4 b, ShuffleComponent component) => default; // 0x0000000186F41138-0x0000000186F41264
		public static bool4x2 bool4x2(bool4 c0, bool4 c1) => default; // 0x0000000185FD9780-0x0000000185FD9790
		public static bool4x2 bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31) => default; // 0x000000018BD48598-0x000000018BD485F0
		public static bool4x2 bool4x2(bool v) => default; // 0x000000018BD485F0-0x000000018BD48614
		public static bool2x4 transpose(bool4x2 v) => default; // 0x000000018BD70010-0x000000018BD70064
		public static uint hash(bool4x2 v) => default; // 0x0000000186F1E578-0x0000000186F1EA94
		public static uint4 hashwide(bool4x2 v) => default; // 0x0000000186F235AC-0x0000000186F23C48
		public static bool4x3 bool4x3(bool4 c0, bool4 c1, bool4 c2) => default; // 0x0000000185FD9790-0x0000000185FD97A0
		public static bool4x3 bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32) => default; // 0x0000000186F173C4-0x0000000186F17440
		public static bool4x3 bool4x3(bool v) => default; // 0x000000018BD48614-0x000000018BD48630
		public static bool3x4 transpose(bool4x3 v) => default; // 0x000000018BD70E68-0x000000018BD70EE4
		public static uint hash(bool4x3 v) => default; // 0x0000000186F1F334-0x0000000186F1F4EC
		public static uint4 hashwide(bool4x3 v) => default; // 0x0000000186F22D40-0x0000000186F22EDC
		public static bool4x4 bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3) => default; // 0x0000000185FD97A0-0x0000000185FD97C0
		public static bool4x4 bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33) => default; // 0x0000000186F17440-0x0000000186F175F8
		public static bool4x4 bool4x4(bool v) => default; // 0x000000018BD48630-0x000000018BD48648
		public static bool4x4 transpose(bool4x4 v) => default; // 0x000000018BD6FF80-0x000000018BD70010
		public static uint hash(bool4x4 v) => default; // 0x0000000186F205C0-0x0000000186F207F8
		public static uint4 hashwide(bool4x4 v) => default; // 0x0000000186F24830-0x0000000186F24A4C
		public static double2 double2(double x, double y) => default; // 0x0000000185FDAA60-0x0000000185FDAA70
		public static double2 double2(double2 xy) => default; // 0x0000000185FDAB70-0x0000000185FDAB90
		public static double2 double2(double v) => default; // 0x0000000185FDAB90-0x0000000185FDABA0
		public static double2 double2(bool v) => default; // 0x000000018BD4A360-0x000000018BD4A37C
		public static double2 double2(bool2 v) => default; // 0x000000018BD4A308-0x000000018BD4A320
		public static double2 double2(int v) => default; // 0x0000000185FDAB30-0x0000000185FDAB50
		public static double2 double2(int2 v) => default; // 0x0000000185FDAAD0-0x0000000185FDAB00
		public static double2 double2(uint v) => default; // 0x0000000185FDAA70-0x0000000185FDAAA0
		public static double2 double2(uint2 v) => default; // 0x0000000185FDAB00-0x0000000185FDAB30
		public static double2 double2(half v) => default; // 0x000000018BD4A2C8-0x000000018BD4A308
		public static double2 double2(half2 v) => default; // 0x000000018BD4A320-0x000000018BD4A360
		public static double2 double2(float v) => default; // 0x0000000185FDAB50-0x0000000185FDAB70
		public static double2 double2(float2 v) => default; // 0x0000000185FDAAA0-0x0000000185FDAAD0
		public static uint hash(double2 v) => default; // 0x000000018BD50AD8-0x000000018BD50B20
		public static uint2 hashwide(double2 v) => default; // 0x000000018BD54A4C-0x000000018BD54AA4
		public static double shuffle(double2 left, double2 right, ShuffleComponent x) => default; // 0x000000018BD6DE80-0x000000018BD6DEA8
		public static double2 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x000000018BD6D878-0x000000018BD6D8E4
		public static double3 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x000000018BD6DDB4-0x000000018BD6DE80
		public static double4 shuffle(double2 left, double2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x000000018BD6DF80-0x000000018BD6E078
		internal static double select_shuffle_component(double2 a, double2 b, ShuffleComponent component) => default; // 0x0000000186F41044-0x0000000186F41138
		public static double2x2 double2x2(double2 c0, double2 c1) => default; // 0x0000000185FDABA0-0x0000000185FDABD0
		public static double2x2 double2x2(double m00, double m01, double m10, double m11) => default; // 0x0000000186F194A4-0x0000000186F194CC
		public static double2x2 double2x2(double v) => default; // 0x000000018BD4A398-0x000000018BD4A3B4
		public static double2x2 double2x2(bool v) => default; // 0x000000018BD4A488-0x000000018BD4A4A4
		public static double2x2 double2x2(bool2x2 v) => default; // 0x000000018BD4A3B4-0x000000018BD4A3D4
		public static double2x2 double2x2(int v) => default; // 0x000000018BD4A418-0x000000018BD4A434
		public static double2x2 double2x2(int2x2 v) => default; // 0x000000018BD4A434-0x000000018BD4A45C
		public static double2x2 double2x2(uint v) => default; // 0x000000018BD4A3D4-0x000000018BD4A3F0
		public static double2x2 double2x2(uint2x2 v) => default; // 0x000000018BD4A45C-0x000000018BD4A488
		public static double2x2 double2x2(float v) => default; // 0x000000018BD4A37C-0x000000018BD4A398
		public static double2x2 double2x2(float2x2 v) => default; // 0x000000018BD4A3F0-0x000000018BD4A418
		public static double2x2 transpose(double2x2 v) => default; // 0x000000018BD7049C-0x000000018BD704E0
		public static double2x2 inverse(double2x2 m) => default; // 0x000000018BD56F78-0x000000018BD57038
		public static double determinant(double2x2 m) => default; // 0x0000000185FDA8A0-0x0000000185FDA8D0
		public static uint hash(double2x2 v) => default; // 0x000000018BD50B20-0x000000018BD50BAC
		public static uint2 hashwide(double2x2 v) => default; // 0x000000018BD5590C-0x000000018BD559A4
		public static double2x3 double2x3(double2 c0, double2 c1, double2 c2) => default; // 0x0000000185FDABD0-0x0000000185FDAC20
		public static double2x3 double2x3(double m00, double m01, double m02, double m10, double m11, double m12) => default; // 0x0000000186F194CC-0x0000000186F195B4
		public static double2x3 double2x3(double v) => default; // 0x000000018BD4A4E4-0x000000018BD4A504
		public static double2x3 double2x3(bool v) => default; // 0x000000018BD4A53C-0x000000018BD4A55C
		public static double2x3 double2x3(bool2x3 v) => default; // 0x000000018BD4A5B8-0x000000018BD4A5F4
		public static double2x3 double2x3(int v) => default; // 0x000000018BD4A55C-0x000000018BD4A57C
		public static double2x3 double2x3(int2x3 v) => default; // 0x000000018BD4A5F4-0x000000018BD4A62C
		public static double2x3 double2x3(uint v) => default; // 0x000000018BD4A4A4-0x000000018BD4A4C4
		public static double2x3 double2x3(uint2x3 v) => default; // 0x000000018BD4A57C-0x000000018BD4A5B8
		public static double2x3 double2x3(float v) => default; // 0x000000018BD4A4C4-0x000000018BD4A4E4
		public static double2x3 double2x3(float2x3 v) => default; // 0x000000018BD4A504-0x000000018BD4A53C
		public static double3x2 transpose(double2x3 v) => default; // 0x000000018BD70E14-0x000000018BD70E68
		public static uint hash(double2x3 v) => default; // 0x000000018BD4FD9C-0x000000018BD4FE68
		public static uint2 hashwide(double2x3 v) => default; // 0x000000018BD55718-0x000000018BD557F0
		public static double2x4 double2x4(double2 c0, double2 c1, double2 c2, double2 c3) => default; // 0x0000000185FDAC20-0x0000000185FDAC80
		public static double2x4 double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13) => default; // 0x0000000186F195B4-0x0000000186F196C0
		public static double2x4 double2x4(double v) => default; // 0x000000018BD4A6F0-0x000000018BD4A714
		public static double2x4 double2x4(bool v) => default; // 0x000000018BD4A62C-0x000000018BD4A650
		public static double2x4 double2x4(bool2x4 v) => default; // 0x000000018BD4A68C-0x000000018BD4A6B4
		public static double2x4 double2x4(int v) => default; // 0x000000018BD4A798-0x000000018BD4A7BC
		public static double2x4 double2x4(int2x4 v) => default; // 0x000000018BD4A6B4-0x000000018BD4A6F0
		public static double2x4 double2x4(uint v) => default; // 0x000000018BD4A738-0x000000018BD4A75C
		public static double2x4 double2x4(uint2x4 v) => default; // 0x000000018BD4A650-0x000000018BD4A68C
		public static double2x4 double2x4(float v) => default; // 0x000000018BD4A714-0x000000018BD4A738
		public static double2x4 double2x4(float2x4 v) => default; // 0x000000018BD4A75C-0x000000018BD4A798
		public static double4x2 transpose(double2x4 v) => default; // 0x000000018BD70250-0x000000018BD702BC
		public static uint hash(double2x4 v) => default; // 0x000000018BD50420-0x000000018BD5052C
		public static uint2 hashwide(double2x4 v) => default; // 0x000000018BD55EA4-0x000000018BD55FBC
		public static double3 double3(double x, double y, double z) => default; // 0x0000000185FDAD30-0x0000000185FDAD50
		public static double3 double3(double x, double2 yz) => default; // 0x0000000185FDAE40-0x0000000185FDAE60
		public static double3 double3(double2 xy, double z) => default; // 0x0000000185FDAD60-0x0000000185FDAD80
		public static double3 double3(double3 xyz) => default; // 0x0000000185FDADE0-0x0000000185FDAE10
		public static double3 double3(double v) => default; // 0x0000000185FDAD50-0x0000000185FDAD60
		public static double3 double3(bool v) => default; // 0x000000018BD4A854-0x000000018BD4A874
		public static double3 double3(bool3 v) => default; // 0x000000018BD4A820-0x000000018BD4A854
		public static double3 double3(int v) => default; // 0x0000000185FDAE10-0x0000000185FDAE40
		public static double3 double3(int3 v) => default; // 0x0000000185FDACB0-0x0000000185FDAD00
		public static double3 double3(uint v) => default; // 0x0000000185FDAD00-0x0000000185FDAD30
		public static double3 double3(uint3 v) => default; // 0x0000000185FDAD80-0x0000000185FDADE0
		public static double3 double3(half v) => default; // 0x000000018BD4A874-0x000000018BD4A8C8
		public static double3 double3(half3 v) => default; // 0x000000018BD4A7BC-0x000000018BD4A820
		public static double3 double3(float v) => default; // 0x0000000185FDAC80-0x0000000185FDACB0
		public static double3 double3(float3 v) => default; // 0x000000018533B190-0x000000018533B1D0
		public static uint hash(double3 v) => default; // 0x000000018BD50E60-0x000000018BD50EF0
		public static uint3 hashwide(double3 v) => default; // 0x000000018BD53B2C-0x000000018BD53BD0
		public static double shuffle(double3 left, double3 right, ShuffleComponent x) => default; // 0x000000018BD6E12C-0x000000018BD6E16C
		public static double2 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x000000018BD6D430-0x000000018BD6D4D8
		public static double3 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x000000018BD6E1CC-0x000000018BD6E2D4
		public static double4 shuffle(double3 left, double3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x000000018BD6D5D8-0x000000018BD6D71C
		internal static double select_shuffle_component(double3 a, double3 b, ShuffleComponent component) => default; // 0x000000018BD6D04C-0x000000018BD6D16C
		public static double3x2 double3x2(double3 c0, double3 c1) => default; // 0x0000000185FDAE60-0x0000000185FDAE90
		public static double3x2 double3x2(double m00, double m01, double m10, double m11, double m20, double m21) => default; // 0x0000000186F196C0-0x0000000186F19708
		public static double3x2 double3x2(double v) => default; // 0x000000018BD4A924-0x000000018BD4A944
		public static double3x2 double3x2(bool v) => default; // 0x000000018BD4A980-0x000000018BD4A9A4
		public static double3x2 double3x2(bool3x2 v) => default; // 0x000000018BD4A9A4-0x000000018BD4A9E0
		public static double3x2 double3x2(int v) => default; // 0x000000018BD4AA3C-0x000000018BD4AA5C
		public static double3x2 double3x2(int3x2 v) => default; // 0x000000018BD4A9E0-0x000000018BD4AA1C
		public static double3x2 double3x2(uint v) => default; // 0x000000018BD4A8C8-0x000000018BD4A8E8
		public static double3x2 double3x2(uint3x2 v) => default; // 0x000000018BD4A944-0x000000018BD4A980
		public static double3x2 double3x2(float v) => default; // 0x000000018BD4AA1C-0x000000018BD4AA3C
		public static double3x2 double3x2(float3x2 v) => default; // 0x000000018BD4A8E8-0x000000018BD4A924
		public static double2x3 transpose(double3x2 v) => default; // 0x000000018BD703B8-0x000000018BD7040C
		public static uint hash(double3x2 v) => default; // 0x000000018BD4F2B8-0x000000018BD4F3E4
		public static uint3 hashwide(double3x2 v) => default; // 0x000000018BD5277C-0x000000018BD528BC
		public static double3x3 double3x3(double3 c0, double3 c1, double3 c2) => default; // 0x0000000185FDAE90-0x0000000185FDAED0
		public static double3x3 double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22) => default; // 0x0000000186F197A0-0x0000000186F19938
		public static double3x3 double3x3(double v) => default; // 0x000000018BD4ABFC-0x000000018BD4AC28
		public static double3x3 double3x3(bool v) => default; // 0x000000018BD4AB80-0x000000018BD4ABAC
		public static double3x3 double3x3(bool3x3 v) => default; // 0x0000000186F19708-0x0000000186F197A0
		public static double3x3 double3x3(int v) => default; // 0x000000018BD4AB54-0x000000018BD4AB80
		public static double3x3 double3x3(int3x3 v) => default; // 0x000000018BD4AB04-0x000000018BD4AB54
		public static double3x3 double3x3(uint v) => default; // 0x000000018BD4AAD8-0x000000018BD4AB04
		public static double3x3 double3x3(uint3x3 v) => default; // 0x000000018BD4ABAC-0x000000018BD4ABFC
		public static double3x3 double3x3(float v) => default; // 0x000000018BD4AA5C-0x000000018BD4AA88
		public static double3x3 double3x3(float3x3 v) => default; // 0x000000018BD4AA88-0x000000018BD4AAD8
		public static double3x3 transpose(double3x3 v) => default; // 0x000000018BD70564-0x000000018BD705D8
		public static double3x3 inverse(double3x3 m) => default; // 0x000000018BD5830C-0x000000018BD587CC
		public static double determinant(double3x3 m) => default; // 0x0000000185FDA200-0x0000000185FDA2C0
		public static uint hash(double3x3 v) => default; // 0x000000018BD507BC-0x000000018BD50974
		public static uint3 hashwide(double3x3 v) => default; // 0x000000018BD5525C-0x000000018BD5542C
		public static double3x4 double3x4(double3 c0, double3 c1, double3 c2, double3 c3) => default; // 0x0000000185FDAED0-0x0000000185FDAF20
		public static double3x4 double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23) => default; // 0x0000000186F19938-0x0000000186F19B60
		public static double3x4 double3x4(double v) => default; // 0x000000018BD4AC28-0x000000018BD4AC54
		public static double3x4 double3x4(bool v) => default; // 0x000000018BD4ADC8-0x000000018BD4ADF8
		public static double3x4 double3x4(bool3x4 v) => default; // 0x0000000186F19B60-0x0000000186F19C8C
		public static double3x4 double3x4(int v) => default; // 0x000000018BD4AC54-0x000000018BD4AC80
		public static double3x4 double3x4(int3x4 v) => default; // 0x000000018BD4ACD0-0x000000018BD4AD20
		public static double3x4 double3x4(uint v) => default; // 0x000000018BD4AD4C-0x000000018BD4AD78
		public static double3x4 double3x4(uint3x4 v) => default; // 0x000000018BD4AD78-0x000000018BD4ADC8
		public static double3x4 double3x4(float v) => default; // 0x000000018BD4AD20-0x000000018BD4AD4C
		public static double3x4 double3x4(float3x4 v) => default; // 0x000000018BD4AC80-0x000000018BD4ACD0
		public static double4x3 transpose(double3x4 v) => default; // 0x000000018BD70C78-0x000000018BD70D08
		public static double3x4 fastinverse(double3x4 m) => default; // 0x000000018BD4D2D8-0x000000018BD4D610
		public static uint hash(double3x4 v) => default; // 0x000000018BD4F3E4-0x000000018BD4F62C
		public static uint3 hashwide(double3x4 v) => default; // 0x000000018BD54AA4-0x000000018BD54D00
		public static double4 double4(double x, double y, double z, double w) => default; // 0x0000000185FDB000-0x0000000185FDB020
		public static double4 double4(double x, double y, double2 zw) => default; // 0x0000000185FDAF20-0x0000000185FDAF40
		public static double4 double4(double x, double2 yz, double w) => default; // 0x0000000185FDAF40-0x0000000185FDAF60
		public static double4 double4(double x, double3 yzw) => default; // 0x0000000185FDB050-0x0000000185FDB080
		public static double4 double4(double2 xy, double z, double w) => default; // 0x0000000185FDB0B0-0x0000000185FDB0D0
		public static double4 double4(double2 xy, double2 zw) => default; // 0x0000000185FDB020-0x0000000185FDB050
		public static double4 double4(double3 xyz, double w) => default; // 0x0000000185FDAF90-0x0000000185FDAFC0
		public static double4 double4(double4 xyzw) => default; // 0x000000018BD4AE38-0x000000018BD4AE60
		public static double4 double4(double v) => default; // 0x0000000185FDAF60-0x0000000185FDAF70
		public static double4 double4(bool v) => default; // 0x000000018BD4AEAC-0x000000018BD4AEC8
		public static double4 double4(bool4 v) => default; // 0x000000018BD4AE1C-0x000000018BD4AE38
		public static double4 double4(int v) => default; // 0x0000000185FDAFC0-0x0000000185FDB000
		public static double4 double4(int4 v) => default; // 0x000000018BD4AEC8-0x000000018BD4AEF0
		public static double4 double4(uint v) => default; // 0x0000000185FDB080-0x0000000185FDB0B0
		public static double4 double4(uint4 v) => default; // 0x000000018BD4AEF0-0x000000018BD4AF18
		public static double4 double4(half v) => default; // 0x000000018BD4AE60-0x000000018BD4AE84
		public static double4 double4(half4 v) => default; // 0x000000018BD4ADF8-0x000000018BD4AE1C
		public static double4 double4(float v) => default; // 0x0000000185FDAF70-0x0000000185FDAF90
		public static double4 double4(float4 v) => default; // 0x000000018BD4AE84-0x000000018BD4AEAC
		public static uint hash(double4 v) => default; // 0x000000018BD4FC54-0x000000018BD4FCE0
		public static uint4 hashwide(double4 v) => default; // 0x000000018BD531D8-0x000000018BD5326C
		public static double shuffle(double4 left, double4 right, ShuffleComponent x) => default; // 0x000000018BD6E078-0x000000018BD6E0B4
		public static double2 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x000000018BD6D8E4-0x000000018BD6D984
		public static double3 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x000000018BD6D984-0x000000018BD6DA80
		public static double4 shuffle(double4 left, double4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x000000018BD6D744-0x000000018BD6D878
		internal static double select_shuffle_component(double4 a, double4 b, ShuffleComponent component) => default; // 0x000000018BD6CF18-0x000000018BD6D04C
		public static double4x2 double4x2(double4 c0, double4 c1) => default; // 0x0000000185FDB0D0-0x0000000185FDB100
		public static double4x2 double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31) => default; // 0x0000000186F19C8C-0x0000000186F19D88
		public static double4x2 double4x2(double v) => default; // 0x000000018BD4AF78-0x000000018BD4AF9C
		public static double4x2 double4x2(bool v) => default; // 0x000000018BD4AFC0-0x000000018BD4AFE4
		public static double4x2 double4x2(bool4x2 v) => default; // 0x000000018BD4B048-0x000000018BD4B070
		public static double4x2 double4x2(int v) => default; // 0x000000018BD4AF9C-0x000000018BD4AFC0
		public static double4x2 double4x2(int4x2 v) => default; // 0x000000018BD4AF3C-0x000000018BD4AF78
		public static double4x2 double4x2(uint v) => default; // 0x000000018BD4AFE4-0x000000018BD4B00C
		public static double4x2 double4x2(uint4x2 v) => default; // 0x000000018BD4B070-0x000000018BD4B0AC
		public static double4x2 double4x2(float v) => default; // 0x000000018BD4AF18-0x000000018BD4AF3C
		public static double4x2 double4x2(float4x2 v) => default; // 0x000000018BD4B00C-0x000000018BD4B048
		public static double2x4 transpose(double4x2 v) => default; // 0x000000018BD7040C-0x000000018BD70478
		public static uint hash(double4x2 v) => default; // 0x000000018BD51394-0x000000018BD514A4
		public static uint4 hashwide(double4x2 v) => default; // 0x000000018BD53BD0-0x000000018BD53CEC
		public static double4x3 double4x3(double4 c0, double4 c1, double4 c2) => default; // 0x0000000185FDB100-0x0000000185FDB140
		public static double4x3 double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32) => default; // 0x0000000186F19DD0-0x0000000186F1A0E8
		public static double4x3 double4x3(double v) => default; // 0x000000018BD4B0FC-0x000000018BD4B128
		public static double4x3 double4x3(bool v) => default; // 0x000000018BD4B1D4-0x000000018BD4B200
		public static double4x3 double4x3(bool4x3 v) => default; // 0x0000000186F19D88-0x0000000186F19DD0
		public static double4x3 double4x3(int v) => default; // 0x000000018BD4B128-0x000000018BD4B154
		public static double4x3 double4x3(int4x3 v) => default; // 0x000000018BD4B184-0x000000018BD4B1D4
		public static double4x3 double4x3(uint v) => default; // 0x000000018BD4B154-0x000000018BD4B184
		public static double4x3 double4x3(uint4x3 v) => default; // 0x000000018BD4B0AC-0x000000018BD4B0FC
		public static double4x3 double4x3(float v) => default; // 0x000000018BD4B200-0x000000018BD4B22C
		public static double4x3 double4x3(float4x3 v) => default; // 0x000000018BD4B22C-0x000000018BD4B27C
		public static double3x4 transpose(double4x3 v) => default; // 0x000000018BD709D4-0x000000018BD70A64
		public static uint hash(double4x3 v) => default; // 0x000000018BD511A0-0x000000018BD51330
		public static uint4 hashwide(double4x3 v) => default; // 0x000000018BD537F4-0x000000018BD53990
		public static double4x4 double4x4(double4 c0, double4 c1, double4 c2, double4 c3) => default; // 0x0000000185FDB140-0x0000000185FDB190
		public static double4x4 double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33) => default; // 0x0000000186F1A0E8-0x0000000186F1A214
		public static double4x4 double4x4(double v) => default; // 0x000000018BD4B2B4-0x000000018BD4B2E8
		public static double4x4 double4x4(bool v) => default; // 0x000000018BD4B2E8-0x000000018BD4B31C
		public static double4x4 double4x4(bool4x4 v) => default; // 0x000000018BD4B464-0x000000018BD4B4A8
		public static double4x4 double4x4(int v) => default; // 0x000000018BD4B4A8-0x000000018BD4B4DC
		public static double4x4 double4x4(int4x4 v) => default; // 0x000000018BD4B31C-0x000000018BD4B378
		public static double4x4 double4x4(uint v) => default; // 0x000000018BD4B27C-0x000000018BD4B2B4
		public static double4x4 double4x4(uint4x4 v) => default; // 0x000000018BD4B378-0x000000018BD4B3D4
		public static double4x4 double4x4(float v) => default; // 0x000000018BD4B430-0x000000018BD4B464
		public static double4x4 double4x4(float4x4 v) => default; // 0x000000018BD4B3D4-0x000000018BD4B430
		public static double3 rotate(double4x4 a, double3 b) => default; // 0x000000018BD6C264-0x000000018BD6C3B4
		public static double3 transform(double4x4 a, double3 b) => default; // 0x000000018BD6FD00-0x000000018BD6FE84
		public static double4x4 transpose(double4x4 v) => default; // 0x000000018BD706B0-0x000000018BD70764
		public static double4x4 inverse(double4x4 m) => default; // 0x000000018BD573F8-0x000000018BD5830C
		public static double4x4 fastinverse(double4x4 m) => default; // 0x000000018BD4CC58-0x000000018BD4D0CC
		public static double determinant(double4x4 m) => default; // 0x0000000185FD9F90-0x0000000185FDA1F0
		public static uint hash(double4x4 v) => default; // 0x000000018BD4FA48-0x000000018BD4FC54
		public static uint4 hashwide(double4x4 v) => default; // 0x000000018BD528BC-0x000000018BD52AD4
		public static float2 float2(float x, float y) => default; // 0x0000000185FDB3B0-0x0000000185FDB3C0
		public static float2 float2(float2 xy) => default; // 0x0000000185FD3D40-0x0000000185FD3D60
		public static float2 float2(float v) => default; // 0x0000000185FB56E0-0x0000000185FB56F0
		public static float2 float2(bool v) => default; // 0x000000018BD4D610-0x000000018BD4D630
		public static float2 float2(bool2 v) => default; // 0x000000018BD4D630-0x000000018BD4D654
		public static float2 float2(int v) => default; // 0x0000000185FDB3C0-0x0000000185FDB3E0
		public static float2 float2(int2 v) => default; // 0x0000000185FDB3E0-0x0000000185FDB400
		public static float2 float2(uint v) => default; // 0x0000000185FDB430-0x0000000185FDB460
		public static float2 float2(uint2 v) => default; // 0x0000000185FDB400-0x0000000185FDB430
		public static float2 float2(half v) => default; // 0x000000018BD4D680-0x000000018BD4D6A8
		public static float2 float2(half2 v) => default; // 0x000000018BD4D654-0x000000018BD4D680
		public static float2 float2(double v) => default; // 0x0000000185FDB460-0x0000000185FDB480
		public static float2 float2(double2 v) => default; // 0x0000000185FDB390-0x0000000185FDB3B0
		public static uint hash(float2 v) => default; // 0x000000018BD4F280-0x000000018BD4F2B8
		public static uint2 hashwide(float2 v) => default; // 0x000000018BD558C8-0x000000018BD5590C
		public static float shuffle(float2 left, float2 right, ShuffleComponent x) => default; // 0x0000000186F4255C-0x0000000186F42708
		public static float2 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000186F42D04-0x0000000186F42D70
		public static float3 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000186F42EF8-0x0000000186F42FB8
		public static float4 shuffle(float2 left, float2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000186F42740-0x0000000186F42824
		internal static float select_shuffle_component(float2 a, float2 b, ShuffleComponent component) => default; // 0x0000000186F417B4-0x0000000186F418B4
		public static float2x2 float2x2(float2 c0, float2 c1) => default; // 0x0000000183E31D70-0x0000000183E34180
		public static float2x2 float2x2(float m00, float m01, float m10, float m11) => default; // 0x000000018BD4D6C0-0x000000018BD4D6E4
		public static float2x2 float2x2(float v) => default; // 0x000000018BD4D6A8-0x000000018BD4D6C0
		public static float2x2 float2x2(bool v) => default; // 0x000000018BD4D7A8-0x000000018BD4D7C0
		public static float2x2 float2x2(bool2x2 v) => default; // 0x000000018BD4D7C0-0x000000018BD4D7DC
		public static float2x2 float2x2(int v) => default; // 0x000000018BD4D70C-0x000000018BD4D724
		public static float2x2 float2x2(int2x2 v) => default; // 0x000000018BD4D784-0x000000018BD4D7A8
		public static float2x2 float2x2(uint v) => default; // 0x000000018BD4D754-0x000000018BD4D76C
		public static float2x2 float2x2(uint2x2 v) => default; // 0x000000018BD4D6E4-0x000000018BD4D70C
		public static float2x2 float2x2(double v) => default; // 0x000000018BD4D76C-0x000000018BD4D784
		public static float2x2 float2x2(double2x2 v) => default; // 0x000000018BD4D724-0x000000018BD4D754
		public static float2x2 transpose(float2x2 v) => default; // 0x000000018BD70064-0x000000018BD700A4
		public static float2x2 inverse(float2x2 m) => default; // 0x0000000186F25208-0x0000000186F25878
		public static float determinant(float2x2 m) => default; // 0x0000000185FDA8D0-0x0000000185FDA8F0
		public static uint hash(float2x2 v) => default; // 0x000000018BD518D0-0x000000018BD51934
		public static uint2 hashwide(float2x2 v) => default; // 0x000000018BD55C84-0x000000018BD55CF8
		public static float2x3 float2x3(float2 c0, float2 c1, float2 c2) => default; // 0x0000000185FDB480-0x0000000185FDB490
		public static float2x3 float2x3(float m00, float m01, float m02, float m10, float m11, float m12) => default; // 0x0000000186F1BB2C-0x0000000186F1BB70
		public static float2x3 float2x3(float v) => default; // 0x000000018BD4D7DC-0x000000018BD4D7FC
		public static float2x3 float2x3(bool v) => default; // 0x000000018BD4D83C-0x000000018BD4D85C
		public static float2x3 float2x3(bool2x3 v) => default; // 0x000000018BD4D898-0x000000018BD4D8CC
		public static float2x3 float2x3(int v) => default; // 0x000000018BD4D904-0x000000018BD4D924
		public static float2x3 float2x3(int2x3 v) => default; // 0x000000018BD4D924-0x000000018BD4D95C
		public static float2x3 float2x3(uint v) => default; // 0x000000018BD4D81C-0x000000018BD4D83C
		public static float2x3 float2x3(uint2x3 v) => default; // 0x000000018BD4D8CC-0x000000018BD4D904
		public static float2x3 float2x3(double v) => default; // 0x000000018BD4D7FC-0x000000018BD4D81C
		public static float2x3 float2x3(double2x3 v) => default; // 0x000000018BD4D85C-0x000000018BD4D898
		public static float3x2 transpose(float2x3 v) => default; // 0x000000018BD70808-0x000000018BD70864
		public static uint hash(float2x3 v) => default; // 0x000000018BD50034-0x000000018BD500C4
		public static uint2 hashwide(float2x3 v) => default; // 0x000000018BD52F8C-0x000000018BD5302C
		public static float2x4 float2x4(float2 c0, float2 c1, float2 c2, float2 c3) => default; // 0x0000000185FDB490-0x0000000185FDB4B0
		public static float2x4 float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13) => default; // 0x0000000186F1BB70-0x0000000186F1BBDC
		public static float2x4 float2x4(float v) => default; // 0x000000018BD4DA14-0x000000018BD4DA30
		public static float2x4 float2x4(bool v) => default; // 0x000000018BD4D95C-0x000000018BD4D978
		public static float2x4 float2x4(bool2x4 v) => default; // 0x000000018BD4D9BC-0x000000018BD4D9DC
		public static float2x4 float2x4(int v) => default; // 0x000000018BD4D9F8-0x000000018BD4DA14
		public static float2x4 float2x4(int2x4 v) => default; // 0x000000018BD4DA80-0x000000018BD4DAB4
		public static float2x4 float2x4(uint v) => default; // 0x000000018BD4D9DC-0x000000018BD4D9F8
		public static float2x4 float2x4(uint2x4 v) => default; // 0x000000018BD4DA4C-0x000000018BD4DA80
		public static float2x4 float2x4(double v) => default; // 0x000000018BD4DA30-0x000000018BD4DA4C
		public static float2x4 float2x4(double2x4 v) => default; // 0x000000018BD4D978-0x000000018BD4D9BC
		public static float4x2 transpose(float2x4 v) => default; // 0x000000018BD705D8-0x000000018BD70644
		public static uint hash(float2x4 v) => default; // 0x000000018BD50CCC-0x000000018BD50D88
		public static uint2 hashwide(float2x4 v) => default; // 0x000000018BD544E0-0x000000018BD545AC
		public static float3 float3(float x, float y, float z) => default; // 0x0000000185FCE180-0x0000000185FCE1A0
		public static float3 float3(float x, float2 yz) => default; // 0x0000000185FDB610-0x0000000185FDB640
		public static float3 float3(float2 xy, float z) => default; // 0x0000000185FDB550-0x0000000185FDB580
		public static float3 float3(float3 xyz) => default; // 0x0000000185FDB580-0x0000000185FDB5B0
		public static float3 float3(float v) => default; // 0x0000000185FB5820-0x0000000185FB5840
		public static float3 float3(bool v) => default; // 0x000000018BD4DAB4-0x000000018BD4DAD0
		public static float3 float3(bool3 v) => default; // 0x000000018BD4DB58-0x000000018BD4DB88
		public static float3 float3(int v) => default; // 0x0000000185FDB4F0-0x0000000185FDB520
		public static float3 float3(int3 v) => default; // 0x0000000185FDB680-0x0000000185FDB6D0
		public static float3 float3(uint v) => default; // 0x0000000185FDB640-0x0000000185FDB680
		public static float3 float3(uint3 v) => default; // 0x0000000185FDB5B0-0x0000000185FDB610
		public static float3 float3(half v) => default; // 0x000000018BD4DAD0-0x000000018BD4DB0C
		public static float3 float3(half3 v) => default; // 0x000000018BD4DB0C-0x000000018BD4DB58
		public static float3 float3(double v) => default; // 0x0000000185FDB520-0x0000000185FDB550
		public static float3 float3(double3 v) => default; // 0x0000000185FDB4B0-0x0000000185FDB4F0
		public static uint hash(float3 v) => default; // 0x0000000186F1F4EC-0x0000000186F1F9D4
		public static uint3 hashwide(float3 v) => default; // 0x0000000186F21F38-0x0000000186F22D40
		public static float shuffle(float3 left, float3 right, ShuffleComponent x) => default; // 0x0000000186F42FB8-0x0000000186F42FF4
		public static float2 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000186F436A4-0x0000000186F43838
		public static float3 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000186F43A50-0x0000000186F43B44
		public static float4 shuffle(float3 left, float3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000186F43838-0x0000000186F43960
		internal static float select_shuffle_component(float3 a, float3 b, ShuffleComponent component) => default; // 0x0000000186F40F34-0x0000000186F41044
		public static float3x2 float3x2(float3 c0, float3 c1) => default; // 0x0000000185FDB6D0-0x0000000185FDB700
		public static float3x2 float3x2(float m00, float m01, float m10, float m11, float m20, float m21) => default; // 0x0000000186F1BBDC-0x0000000186F1BCCC
		public static float3x2 float3x2(float v) => default; // 0x000000018BD4DCF0-0x000000018BD4DD10
		public static float3x2 float3x2(bool v) => default; // 0x000000018BD4DC00-0x000000018BD4DC20
		public static float3x2 float3x2(bool3x2 v) => default; // 0x000000018BD4DCB8-0x000000018BD4DCF0
		public static float3x2 float3x2(int v) => default; // 0x000000018BD4DC20-0x000000018BD4DC40
		public static float3x2 float3x2(int3x2 v) => default; // 0x000000018BD4DC60-0x000000018BD4DC98
		public static float3x2 float3x2(uint v) => default; // 0x000000018BD4DC98-0x000000018BD4DCB8
		public static float3x2 float3x2(uint3x2 v) => default; // 0x000000018BD4DBC8-0x000000018BD4DC00
		public static float3x2 float3x2(double v) => default; // 0x000000018BD4DC40-0x000000018BD4DC60
		public static float3x2 float3x2(double3x2 v) => default; // 0x000000018BD4DB88-0x000000018BD4DBC8
		public static float2x3 transpose(float3x2 v) => default; // 0x000000018BD7090C-0x000000018BD70968
		public static uint hash(float3x2 v) => default; // 0x000000018BD520C4-0x000000018BD521A4
		public static uint3 hashwide(float3x2 v) => default; // 0x000000018BD533D8-0x000000018BD534D0
		public static float3x3 float3x3(float3 c0, float3 c1, float3 c2) => default; // 0x00000001840DB930-0x00000001840DBA30
		public static float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) => default; // 0x0000000186F1BCCC-0x0000000186F1BE7C
		public static float3x3 float3x3(float v) => default; // 0x000000018BD4DD30-0x000000018BD4DD50
		public static float3x3 float3x3(bool v) => default; // 0x000000018BD4DD10-0x000000018BD4DD30
		public static float3x3 float3x3(bool3x3 v) => default; // 0x000000018BD4DF14-0x000000018BD4DF54
		public static float3x3 float3x3(int v) => default; // 0x000000018BD4DE3C-0x000000018BD4DE5C
		public static float3x3 float3x3(int3x3 v) => default; // 0x000000018BD4DDA8-0x000000018BD4DDE8
		public static float3x3 float3x3(uint v) => default; // 0x000000018BD4DED4-0x000000018BD4DEF4
		public static float3x3 float3x3(uint3x3 v) => default; // 0x000000018BD4DE94-0x000000018BD4DED4
		public static float3x3 float3x3(double v) => default; // 0x000000018BD4DEF4-0x000000018BD4DF14
		public static float3x3 float3x3(double3x3 v) => default; // 0x000000018BD4DD50-0x000000018BD4DDA8
		public static float3x3 transpose(float3x3 v) => default; // 0x000000018BD70BF4-0x000000018BD70C78
		public static float3x3 inverse(float3x3 m) => default; // 0x000000018BD57038-0x000000018BD573F8
		public static float determinant(float3x3 m) => default; // 0x0000000185FDA750-0x0000000185FDA800
		public static uint hash(float3x3 v) => default; // 0x000000018BD51DC4-0x000000018BD51F18
		public static uint3 hashwide(float3x3 v) => default; // 0x000000018BD5326C-0x000000018BD533D8
		public static float3x4 float3x4(float3 c0, float3 c1, float3 c2, float3 c3) => default; // 0x0000000185FDB700-0x0000000185FDB750
		public static float3x4 float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23) => default; // 0x0000000186F1BE7C-0x0000000186F1BFBC
		public static float3x4 float3x4(float v) => default; // 0x000000018BD4E0C8-0x000000018BD4E0E8
		public static float3x4 float3x4(bool v) => default; // 0x000000018BD4DFB0-0x000000018BD4DFD0
		public static float3x4 float3x4(bool3x4 v) => default; // 0x000000018BD4DF74-0x000000018BD4DFB0
		public static float3x4 float3x4(int v) => default; // 0x000000018BD4E064-0x000000018BD4E084
		public static float3x4 float3x4(int3x4 v) => default; // 0x000000018BD4E084-0x000000018BD4E0C8
		public static float3x4 float3x4(uint v) => default; // 0x000000018BD4E18C-0x000000018BD4E1AC
		public static float3x4 float3x4(uint3x4 v) => default; // 0x000000018BD4E148-0x000000018BD4E18C
		public static float3x4 float3x4(double v) => default; // 0x000000018BD4DF54-0x000000018BD4DF74
		public static float3x4 float3x4(double3x4 v) => default; // 0x000000018BD4E0E8-0x000000018BD4E148
		public static float4x3 transpose(float3x4 v) => default; // 0x000000018BD70764-0x000000018BD70808
		public static float3x4 fastinverse(float3x4 m) => default; // 0x000000018BD4D0CC-0x000000018BD4D2D8
		public static uint hash(float3x4 v) => default; // 0x000000018BD4F6EC-0x000000018BD4F8B8
		public static uint3 hashwide(float3x4 v) => default; // 0x000000018BD52C10-0x000000018BD52DF0
		public static float4 float4(float x, float y, float z, float w) => default; // 0x0000000185FDB750-0x0000000185FDB770
		public static float4 float4(float x, float y, float2 zw) => default; // 0x0000000185FDB780-0x0000000185FDB7B0
		public static float4 float4(float x, float2 yz, float w) => default; // 0x0000000185FDB820-0x0000000185FDB850
		public static float4 float4(float x, float3 yzw) => default; // 0x0000000185FDB8A0-0x0000000185FDB8E0
		public static float4 float4(float2 xy, float z, float w) => default; // 0x0000000185FDB7B0-0x0000000185FDB7E0
		public static float4 float4(float2 xy, float2 zw) => default; // 0x0000000185FAFF00-0x0000000185FAFF40
		public static float4 float4(float3 xyz, float w) => default; // 0x0000000185FDB8E0-0x0000000185FDB910
		public static float4 float4(float4 xyzw) => default; // 0x000000018BD4E31C-0x000000018BD4E348
		public static float4 float4(float v) => default; // 0x0000000185FDB770-0x0000000185FDB780
		public static float4 float4(bool v) => default; // 0x000000018BD4E2E0-0x000000018BD4E2F8
		public static float4 float4(bool4 v) => default; // 0x000000018BD4E1DC-0x000000018BD4E1F4
		public static float4 float4(int v) => default; // 0x0000000185FDB800-0x0000000185FDB820
		public static float4 float4(int4 v) => default; // 0x000000018BD4E29C-0x000000018BD4E2E0
		public static float4 float4(uint v) => default; // 0x0000000185FDB850-0x0000000185FDB8A0
		public static float4 float4(uint4 v) => default; // 0x000000018BD4E2F8-0x000000018BD4E31C
		public static float4 float4(half v) => default; // 0x000000018BD4E250-0x000000018BD4E29C
		public static float4 float4(half4 v) => default; // 0x000000018BD4E1F4-0x000000018BD4E250
		public static float4 float4(double v) => default; // 0x0000000185FDB7E0-0x0000000185FDB800
		public static float4 float4(double4 v) => default; // 0x000000018BD4E1AC-0x000000018BD4E1DC
		public static uint hash(float4 v) => default; // 0x000000018BD50218-0x000000018BD50284
		public static uint4 hashwide(float4 v) => default; // 0x000000018BD5311C-0x000000018BD53198
		public static float shuffle(float4 left, float4 right, ShuffleComponent x) => default; // 0x000000018BD6D5B0-0x000000018BD6D5D8
		public static float2 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x000000018BD6E16C-0x000000018BD6E1CC
		public static float3 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x000000018BD6DCF4-0x000000018BD6DDB4
		public static float4 shuffle(float4 left, float4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x000000018BD6DA80-0x000000018BD6DB68
		internal static float select_shuffle_component(float4 a, float4 b, ShuffleComponent component) => default; // 0x000000018BD6D16C-0x000000018BD6D29C
		public static float4x2 float4x2(float4 c0, float4 c1) => default; // 0x0000000185FDB910-0x0000000185FDB930
		public static float4x2 float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31) => default; // 0x0000000186F1BFBC-0x0000000186F1C088
		public static float4x2 float4x2(float v) => default; // 0x000000018BD4E398-0x000000018BD4E3B4
		public static float4x2 float4x2(bool v) => default; // 0x000000018BD4E468-0x000000018BD4E484
		public static float4x2 float4x2(bool4x2 v) => default; // 0x000000018BD4E484-0x000000018BD4E4A8
		public static float4x2 float4x2(int v) => default; // 0x000000018BD4E42C-0x000000018BD4E448
		public static float4x2 float4x2(int4x2 v) => default; // 0x000000018BD4E3F8-0x000000018BD4E42C
		public static float4x2 float4x2(uint v) => default; // 0x000000018BD4E448-0x000000018BD4E468
		public static float4x2 float4x2(uint4x2 v) => default; // 0x000000018BD4E364-0x000000018BD4E398
		public static float4x2 float4x2(double v) => default; // 0x000000018BD4E348-0x000000018BD4E364
		public static float4x2 float4x2(double4x2 v) => default; // 0x000000018BD4E3B4-0x000000018BD4E3F8
		public static float2x4 transpose(float4x2 v) => default; // 0x000000018BD70968-0x000000018BD709D4
		public static uint hash(float4x2 v) => default; // 0x000000018BD506F0-0x000000018BD507BC
		public static uint4 hashwide(float4x2 v) => default; // 0x000000018BD557F0-0x000000018BD558C8
		public static float4x3 float4x3(float4 c0, float4 c1, float4 c2) => default; // 0x0000000185FDB930-0x0000000185FDB950
		public static float4x3 float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32) => default; // 0x0000000186F1C088-0x0000000186F1C644
		public static float4x3 float4x3(float v) => default; // 0x000000018BD4E5CC-0x000000018BD4E5EC
		public static float4x3 float4x3(bool v) => default; // 0x000000018BD4E5EC-0x000000018BD4E60C
		public static float4x3 float4x3(bool4x3 v) => default; // 0x000000018BD4E54C-0x000000018BD4E588
		public static float4x3 float4x3(int v) => default; // 0x000000018BD4E60C-0x000000018BD4E62C
		public static float4x3 float4x3(int4x3 v) => default; // 0x000000018BD4E62C-0x000000018BD4E66C
		public static float4x3 float4x3(uint v) => default; // 0x000000018BD4E528-0x000000018BD4E54C
		public static float4x3 float4x3(uint4x3 v) => default; // 0x000000018BD4E588-0x000000018BD4E5CC
		public static float4x3 float4x3(double v) => default; // 0x000000018BD4E508-0x000000018BD4E528
		public static float4x3 float4x3(double4x3 v) => default; // 0x000000018BD4E4A8-0x000000018BD4E508
		public static float3x4 transpose(float4x3 v) => default; // 0x000000018BD70314-0x000000018BD703B8
		public static uint hash(float4x3 v) => default; // 0x000000018BD51934-0x000000018BD51A64
		public static uint4 hashwide(float4x3 v) => default; // 0x000000018BD52AD4-0x000000018BD52C10
		public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3) => default; // 0x0000000185FDB950-0x0000000185FDB980
		public static float4x4 float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) => default; // 0x000000018BD4E66C-0x000000018BD4E794
		public static float4x4 float4x4(float v) => default; // 0x00000001840DCD50-0x00000001840DCD80
		public static float4x4 float4x4(bool v) => default; // 0x000000018BD4EAE8-0x000000018BD4EB0C
		public static float4x4 float4x4(bool4x4 v) => default; // 0x000000018BD4EB98-0x000000018BD4EBD0
		public static float4x4 float4x4(int v) => default; // 0x000000018BD4EB0C-0x000000018BD4EB30
		public static float4x4 float4x4(int4x4 v) => default; // 0x000000018BD4E7BC-0x000000018BD4E818
		public static float4x4 float4x4(uint v) => default; // 0x000000018BD4E794-0x000000018BD4E7BC
		public static float4x4 float4x4(uint4x4 v) => default; // 0x000000018BD4EA18-0x000000018BD4EA74
		public static float4x4 float4x4(double v) => default; // 0x000000018BD4E818-0x000000018BD4E83C
		public static float4x4 float4x4(double4x4 v) => default; // 0x000000018BD4E890-0x000000018BD4E91C
		public static float3 rotate(float4x4 a, float3 b) => default; // 0x000000018BD6C18C-0x000000018BD6C264
		public static float3 transform(float4x4 a, float3 b) => default; // 0x000000018BD6FE84-0x000000018BD6FF80
		public static float4x4 transpose(float4x4 v) => default; // 0x000000018BD70B18-0x000000018BD70BF4
		public static float4x4 inverse(float4x4 m) => default; // 0x00000001840DD330-0x00000001840DE040
		public static float4x4 fastinverse(float4x4 m) => default; // 0x000000018BD4C958-0x000000018BD4CC58
		public static float determinant(float4x4 m) => default; // 0x0000000185FDA2C0-0x0000000185FDA530
		public static uint hash(float4x4 v) => default; // 0x000000018BD4F8B8-0x000000018BD4FA48
		public static uint4 hashwide(float4x4 v) => default; // 0x000000018BD54344-0x000000018BD544E0
		public static half half(half x) => default; // 0x0000000185FB1400-0x0000000185FB1410
		public static half half(float v) => default; // 0x000000018BD4F278-0x000000018BD4F280
		public static half half(double v) => default; // 0x000000018BD4F26C-0x000000018BD4F278
		public static uint hash(half v) => default; // 0x0000000185FDC140-0x0000000185FDC150
		public static half2 half2(half x, half y) => default; // 0x0000000185FD9490-0x0000000185FD94A0
		public static half2 half2(half2 xy) => default; // 0x0000000185FD73B0-0x0000000185FD73D0
		public static half2 half2(half v) => default; // 0x0000000185FDBF50-0x0000000185FDBF60
		public static half2 half2(float v) => default; // 0x000000018BD4EFB0-0x000000018BD4EFD8
		public static half2 half2(float2 v) => default; // 0x000000018BD4EFD8-0x000000018BD4F00C
		public static half2 half2(double v) => default; // 0x000000018BD4EF44-0x000000018BD4EF78
		public static half2 half2(double2 v) => default; // 0x000000018BD4EF78-0x000000018BD4EFB0
		public static uint hash(half2 v) => default; // 0x000000018BD51F18-0x000000018BD51F5C
		public static uint2 hashwide(half2 v) => default; // 0x000000018BD54E9C-0x000000018BD54EF0
		public static half3 half3(half x, half y, half z) => default; // 0x0000000185FD94A0-0x0000000185FD94C0
		public static half3 half3(half x, half2 yz) => default; // 0x0000000185FDBFA0-0x0000000185FDBFC0
		public static half3 half3(half2 xy, half z) => default; // 0x0000000185FDBFC0-0x0000000185FDBFE0
		public static half3 half3(half3 xyz) => default; // 0x0000000185FDBF60-0x0000000185FDBF90
		public static half3 half3(half v) => default; // 0x0000000185FDBF90-0x0000000185FDBFA0
		public static half3 half3(float v) => default; // 0x000000018BD4F0E0-0x000000018BD4F118
		public static half3 half3(float3 v) => default; // 0x000000018BD4F09C-0x000000018BD4F0E0
		public static half3 half3(double v) => default; // 0x000000018BD4F00C-0x000000018BD4F050
		public static half3 half3(double3 v) => default; // 0x000000018BD4F050-0x000000018BD4F09C
		public static uint hash(half3 v) => default; // 0x0000000186F1CE04-0x0000000186F1DA94
		public static uint3 hashwide(half3 v) => default; // 0x0000000186F22EDC-0x0000000186F235AC
		public static half4 half4(half x, half y, half z, half w) => default; // 0x0000000185FD94C0-0x0000000185FD94F0
		public static half4 half4(half x, half y, half2 zw) => default; // 0x0000000185FDC0B0-0x0000000185FDC0E0
		public static half4 half4(half x, half2 yz, half w) => default; // 0x0000000185FDC030-0x0000000185FDC060
		public static half4 half4(half x, half3 yzw) => default; // 0x0000000185FDC110-0x0000000185FDC140
		public static half4 half4(half2 xy, half z, half w) => default; // 0x0000000185FDBFE0-0x0000000185FDC010
		public static half4 half4(half2 xy, half2 zw) => default; // 0x0000000185FDC060-0x0000000185FDC080
		public static half4 half4(half3 xyz, half w) => default; // 0x0000000185FDC080-0x0000000185FDC0B0
		public static half4 half4(half4 xyzw) => default; // 0x0000000185FDC0E0-0x0000000185FDC110
		public static half4 half4(half v) => default; // 0x0000000185FDC010-0x0000000185FDC030
		public static half4 half4(float v) => default; // 0x000000018BD4F17C-0x000000018BD4F1C0
		public static half4 half4(float4 v) => default; // 0x000000018BD4F218-0x000000018BD4F26C
		public static half4 half4(double v) => default; // 0x000000018BD4F1C0-0x000000018BD4F218
		public static half4 half4(double4 v) => default; // 0x000000018BD4F118-0x000000018BD4F17C
		public static uint hash(half4 v) => default; // 0x0000000186F1CD64-0x0000000186F1CE04
		public static uint4 hashwide(half4 v) => default; // 0x0000000186F24674-0x0000000186F24830
		public static int2 int2(int x, int y) => default; // 0x0000000185FD9780-0x0000000185FD9790
		public static int2 int2(int2 xy) => default; // 0x0000000185FD75B0-0x0000000185FD75D0
		public static int2 int2(int v) => default; // 0x0000000185FDC1B0-0x0000000185FDC1C0
		public static int2 int2(bool v) => default; // 0x000000018BD55FBC-0x000000018BD55FD4
		public static int2 int2(bool2 v) => default; // 0x000000018BD55FD4-0x000000018BD55FF4
		public static int2 int2(uint v) => default; // 0x0000000185FDC1B0-0x0000000185FDC1C0
		public static int2 int2(uint2 v) => default; // 0x0000000185FD75B0-0x0000000185FD75D0
		public static int2 int2(float v) => default; // 0x0000000185FDC190-0x0000000185FDC1B0
		public static int2 int2(float2 v) => default; // 0x0000000185FDC150-0x0000000185FDC170
		public static int2 int2(double v) => default; // 0x0000000185FDC170-0x0000000185FDC190
		public static int2 int2(double2 v) => default; // 0x0000000185FDC1C0-0x0000000185FDC1E0
		public static uint hash(int2 v) => default; // 0x000000018BD50974-0x000000018BD509A8
		public static uint2 hashwide(int2 v) => default; // 0x000000018BD5505C-0x000000018BD5509C
		public static int shuffle(int2 left, int2 right, ShuffleComponent x) => default; // 0x0000000186F42FF4-0x0000000186F43208
		public static int2 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000186F433EC-0x0000000186F43438
		public static int3 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000186F42E88-0x0000000186F42EF8
		public static int4 shuffle(int2 left, int2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000186F424CC-0x0000000186F4255C
		internal static int select_shuffle_component(int2 a, int2 b, ShuffleComponent component) => default; // 0x0000000186F418B4-0x0000000186F41AC8
		public static int2x2 int2x2(int2 c0, int2 c1) => default; // 0x0000000183E31D70-0x0000000183E34180
		public static int2x2 int2x2(int m00, int m01, int m10, int m11) => default; // 0x000000018BD56050-0x000000018BD56070
		public static int2x2 int2x2(int v) => default; // 0x000000018BD56038-0x000000018BD56050
		public static int2x2 int2x2(bool v) => default; // 0x000000018BD560F4-0x000000018BD5610C
		public static int2x2 int2x2(bool2x2 v) => default; // 0x000000018BD55FF4-0x000000018BD56014
		public static int2x2 int2x2(uint v) => default; // 0x000000018BD56038-0x000000018BD56050
		public static int2x2 int2x2(uint2x2 v) => default; // 0x000000018BD560B8-0x000000018BD560DC
		public static int2x2 int2x2(float v) => default; // 0x000000018BD560A0-0x000000018BD560B8
		public static int2x2 int2x2(float2x2 v) => default; // 0x000000018BD56014-0x000000018BD56038
		public static int2x2 int2x2(double v) => default; // 0x000000018BD560DC-0x000000018BD560F4
		public static int2x2 int2x2(double2x2 v) => default; // 0x000000018BD56070-0x000000018BD560A0
		public static int2x2 transpose(int2x2 v) => default; // 0x000000018BD700A4-0x000000018BD700E0
		public static int determinant(int2x2 m) => default; // 0x0000000185FDA1F0-0x0000000185FDA200
		public static uint hash(int2x2 v) => default; // 0x000000018BD51330-0x000000018BD51394
		public static uint2 hashwide(int2x2 v) => default; // 0x000000018BD53EE0-0x000000018BD53F54
		public static int2x3 int2x3(int2 c0, int2 c1, int2 c2) => default; // 0x0000000185FDB480-0x0000000185FDB490
		public static int2x3 int2x3(int m00, int m01, int m02, int m10, int m11, int m12) => default; // 0x0000000186F24A4C-0x0000000186F24A84
		public static int2x3 int2x3(int v) => default; // 0x000000018BD56164-0x000000018BD56184
		public static int2x3 int2x3(bool v) => default; // 0x000000018BD56218-0x000000018BD56238
		public static int2x3 int2x3(bool2x3 v) => default; // 0x000000018BD561A4-0x000000018BD561DC
		public static int2x3 int2x3(uint v) => default; // 0x000000018BD56164-0x000000018BD56184
		public static int2x3 int2x3(uint2x3 v) => default; // 0x000000018BD5612C-0x000000018BD56164
		public static int2x3 int2x3(float v) => default; // 0x000000018BD5610C-0x000000018BD5612C
		public static int2x3 int2x3(float2x3 v) => default; // 0x000000018BD56238-0x000000018BD56270
		public static int2x3 int2x3(double v) => default; // 0x000000018BD56184-0x000000018BD561A4
		public static int2x3 int2x3(double2x3 v) => default; // 0x000000018BD561DC-0x000000018BD56218
		public static int3x2 transpose(int2x3 v) => default; // 0x000000018BD70D08-0x000000018BD70D54
		public static uint hash(int2x3 v) => default; // 0x000000018BD50BAC-0x000000018BD50C3C
		public static uint2 hashwide(int2x3 v) => default; // 0x000000018BD54DFC-0x000000018BD54E9C
		public static int2x4 int2x4(int2 c0, int2 c1, int2 c2, int2 c3) => default; // 0x0000000185FDC1E0-0x0000000185FDC200
		public static int2x4 int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13) => default; // 0x0000000186F24A84-0x0000000186F24AD8
		public static int2x4 int2x4(int v) => default; // 0x000000018BD56294-0x000000018BD562B0
		public static int2x4 int2x4(bool v) => default; // 0x000000018BD562E4-0x000000018BD56300
		public static int2x4 int2x4(bool2x4 v) => default; // 0x000000018BD56270-0x000000018BD56294
		public static int2x4 int2x4(uint v) => default; // 0x000000018BD56294-0x000000018BD562B0
		public static int2x4 int2x4(uint2x4 v) => default; // 0x000000018BD562B0-0x000000018BD562E4
		public static int2x4 int2x4(float v) => default; // 0x000000018BD56350-0x000000018BD5636C
		public static int2x4 int2x4(float2x4 v) => default; // 0x000000018BD5631C-0x000000018BD56350
		public static int2x4 int2x4(double v) => default; // 0x000000018BD56300-0x000000018BD5631C
		public static int2x4 int2x4(double2x4 v) => default; // 0x000000018BD5636C-0x000000018BD563B0
		public static int4x2 transpose(int2x4 v) => default; // 0x000000018BD702BC-0x000000018BD70314
		public static uint hash(int2x4 v) => default; // 0x000000018BD50364-0x000000018BD50420
		public static uint2 hashwide(int2x4 v) => default; // 0x000000018BD53728-0x000000018BD537F4
		public static int3 int3(int x, int y, int z) => default; // 0x0000000185FD9790-0x0000000185FD97A0
		public static int3 int3(int x, int2 yz) => default; // 0x0000000185FDC240-0x0000000185FDC260
		public static int3 int3(int2 xy, int z) => default; // 0x0000000185FDC260-0x0000000185FDC280
		public static int3 int3(int3 xyz) => default; // 0x0000000185FDC280-0x0000000185FDC2B0
		public static int3 int3(int v) => default; // 0x0000000185FDC200-0x0000000185FDC210
		public static int3 int3(bool v) => default; // 0x000000018BD563B0-0x000000018BD563C8
		public static int3 int3(bool3 v) => default; // 0x000000018BD563C8-0x000000018BD563FC
		public static int3 int3(uint v) => default; // 0x0000000185FDC200-0x0000000185FDC210
		public static int3 int3(uint3 v) => default; // 0x0000000185FDC280-0x0000000185FDC2B0
		public static int3 int3(float v) => default; // 0x0000000185FDC2D0-0x0000000185FDC2F0
		public static int3 int3(float3 v) => default; // 0x0000000185FDC210-0x0000000185FDC240
		public static int3 int3(double v) => default; // 0x0000000185FDC2B0-0x0000000185FDC2D0
		public static int3 int3(double3 v) => default; // 0x0000000185FDC2F0-0x0000000185FDC330
		public static uint hash(int3 v) => default; // 0x000000018BD51D50-0x000000018BD51DC4
		public static uint3 hashwide(int3 v) => default; // 0x0000000186F24094-0x0000000186F24674
		public static int shuffle(int3 left, int3 right, ShuffleComponent x) => default; // 0x0000000186F42370-0x0000000186F4244C
		public static int2 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000186F42824-0x0000000186F42960
		public static int3 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000186F43208-0x0000000186F4335C
		public static int4 shuffle(int3 left, int3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000186F42960-0x0000000186F42A78
		internal static int select_shuffle_component(int3 a, int3 b, ShuffleComponent component) => default; // 0x0000000186F40D40-0x0000000186F40E44
		public static int3x2 int3x2(int3 c0, int3 c1) => default; // 0x0000000185FDB6D0-0x0000000185FDB700
		public static int3x2 int3x2(int m00, int m01, int m10, int m11, int m20, int m21) => default; // 0x0000000186F24AD8-0x0000000186F24B68
		public static int3x2 int3x2(int v) => default; // 0x000000018BD564AC-0x000000018BD564CC
		public static int3x2 int3x2(bool v) => default; // 0x000000018BD564CC-0x000000018BD564EC
		public static int3x2 int3x2(bool3x2 v) => default; // 0x000000018BD564EC-0x000000018BD56524
		public static int3x2 int3x2(uint v) => default; // 0x000000018BD564AC-0x000000018BD564CC
		public static int3x2 int3x2(uint3x2 v) => default; // 0x000000018BD5643C-0x000000018BD56474
		public static int3x2 int3x2(float v) => default; // 0x000000018BD56524-0x000000018BD56544
		public static int3x2 int3x2(float3x2 v) => default; // 0x000000018BD56474-0x000000018BD564AC
		public static int3x2 int3x2(double v) => default; // 0x000000018BD56544-0x000000018BD56564
		public static int3x2 int3x2(double3x2 v) => default; // 0x000000018BD563FC-0x000000018BD5643C
		public static int2x3 transpose(int3x2 v) => default; // 0x000000018BD700E0-0x000000018BD7012C
		public static uint hash(int3x2 v) => default; // 0x000000018BD51F5C-0x000000018BD5203C
		public static uint3 hashwide(int3x2 v) => default; // 0x000000018BD53DE8-0x000000018BD53EE0
		public static int3x3 int3x3(int3 c0, int3 c1, int3 c2) => default; // 0x00000001840DB930-0x00000001840DBA30
		public static int3x3 int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22) => default; // 0x0000000186F24B68-0x0000000186F24C2C
		public static int3x3 int3x3(int v) => default; // 0x000000018BD56564-0x000000018BD56584
		public static int3x3 int3x3(bool v) => default; // 0x000000018BD566DC-0x000000018BD566FC
		public static int3x3 int3x3(bool3x3 v) => default; // 0x000000018BD5669C-0x000000018BD566DC
		public static int3x3 int3x3(uint v) => default; // 0x000000018BD56564-0x000000018BD56584
		public static int3x3 int3x3(uint3x3 v) => default; // 0x000000018BD565A4-0x000000018BD565E4
		public static int3x3 int3x3(float v) => default; // 0x000000018BD56584-0x000000018BD565A4
		public static int3x3 int3x3(float3x3 v) => default; // 0x000000018BD5663C-0x000000018BD5667C
		public static int3x3 int3x3(double v) => default; // 0x000000018BD5667C-0x000000018BD5669C
		public static int3x3 int3x3(double3x3 v) => default; // 0x000000018BD565E4-0x000000018BD5663C
		public static int3x3 transpose(int3x3 v) => default; // 0x000000018BD70644-0x000000018BD706B0
		public static int determinant(int3x3 m) => default; // 0x0000000185FDA800-0x0000000185FDA8A0
		public static uint hash(int3x3 v) => default; // 0x000000018BD500C4-0x000000018BD50218
		public static uint3 hashwide(int3x3 v) => default; // 0x000000018BD535BC-0x000000018BD53728
		public static int3x4 int3x4(int3 c0, int3 c1, int3 c2, int3 c3) => default; // 0x0000000185FDB700-0x0000000185FDB750
		public static int3x4 int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23) => default; // 0x0000000186F24C2C-0x0000000186F24CF4
		public static int3x4 int3x4(int v) => default; // 0x000000018BD567B8-0x000000018BD567D8
		public static int3x4 int3x4(bool v) => default; // 0x000000018BD566FC-0x000000018BD5671C
		public static int3x4 int3x4(bool3x4 v) => default; // 0x000000018BD5677C-0x000000018BD567B8
		public static int3x4 int3x4(uint v) => default; // 0x000000018BD567B8-0x000000018BD567D8
		public static int3x4 int3x4(uint3x4 v) => default; // 0x000000018BD5685C-0x000000018BD568A0
		public static int3x4 int3x4(float v) => default; // 0x000000018BD5683C-0x000000018BD5685C
		public static int3x4 int3x4(float3x4 v) => default; // 0x000000018BD567D8-0x000000018BD5681C
		public static int3x4 int3x4(double v) => default; // 0x000000018BD5681C-0x000000018BD5683C
		public static int3x4 int3x4(double3x4 v) => default; // 0x000000018BD5671C-0x000000018BD5677C
		public static int4x3 transpose(int3x4 v) => default; // 0x000000018BD701CC-0x000000018BD70250
		public static uint hash(int3x4 v) => default; // 0x000000018BD4FE68-0x000000018BD50034
		public static uint3 hashwide(int3x4 v) => default; // 0x000000018BD545AC-0x000000018BD5478C
		public static int4 int4(int x, int y, int z, int w) => default; // 0x0000000185FD97A0-0x0000000185FD97C0
		public static int4 int4(int x, int y, int2 zw) => default; // 0x0000000185FDC3C0-0x0000000185FDC3E0
		public static int4 int4(int x, int2 yz, int w) => default; // 0x0000000185FDC440-0x0000000185FDC460
		public static int4 int4(int x, int3 yzw) => default; // 0x0000000185FDC340-0x0000000185FDC380
		public static int4 int4(int2 xy, int z, int w) => default; // 0x0000000185FDC3E0-0x0000000185FDC400
		public static int4 int4(int2 xy, int2 zw) => default; // 0x0000000185FD75D0-0x0000000185FD75F0
		public static int4 int4(int3 xyz, int w) => default; // 0x0000000185FDC400-0x0000000185FDC440
		public static int4 int4(int4 xyzw) => default; // 0x000000018BD568A0-0x000000018BD568CC
		public static int4 int4(int v) => default; // 0x0000000185FDC330-0x0000000185FDC340
		public static int4 int4(bool v) => default; // 0x000000018BD568CC-0x000000018BD568EC
		public static int4 int4(bool4 v) => default; // 0x000000018BD568EC-0x000000018BD56930
		public static int4 int4(uint v) => default; // 0x0000000185FDC330-0x0000000185FDC340
		public static int4 int4(uint4 v) => default; // 0x000000018BD568A0-0x000000018BD568CC
		public static int4 int4(float v) => default; // 0x0000000185FDC3A0-0x0000000185FDC3C0
		public static int4 int4(float4 v) => default; // 0x000000018BD56960-0x000000018BD56994
		public static int4 int4(double v) => default; // 0x0000000185FDC380-0x0000000185FDC3A0
		public static int4 int4(double4 v) => default; // 0x000000018BD56930-0x000000018BD56960
		public static uint hash(int4 v) => default; // 0x000000018BD5203C-0x000000018BD520A8
		public static uint4 hashwide(int4 v) => default; // 0x000000018BD55C08-0x000000018BD55C84
		public static int shuffle(int4 left, int4 right, ShuffleComponent x) => default; // 0x000000018BD6DC10-0x000000018BD6DC38
		public static int2 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x000000018BD6D2F4-0x000000018BD6D34C
		public static int3 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x000000018BD6E2D4-0x000000018BD6E37C
		public static int4 shuffle(int4 left, int4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x000000018BD6D4D8-0x000000018BD6D5B0
		internal static int select_shuffle_component(int4 a, int4 b, ShuffleComponent component) => default; // 0x0000000186F41354-0x0000000186F415AC
		public static int4x2 int4x2(int4 c0, int4 c1) => default; // 0x0000000185FDB910-0x0000000185FDB930
		public static int4x2 int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31) => default; // 0x0000000186F24CF4-0x0000000186F24DA8
		public static int4x2 int4x2(int v) => default; // 0x000000018BD569F4-0x000000018BD56A10
		public static int4x2 int4x2(bool v) => default; // 0x000000018BD56A60-0x000000018BD56A7C
		public static int4x2 int4x2(bool4x2 v) => default; // 0x000000018BD56AB0-0x000000018BD56AD4
		public static int4x2 int4x2(uint v) => default; // 0x000000018BD569F4-0x000000018BD56A10
		public static int4x2 int4x2(uint4x2 v) => default; // 0x000000018BD56A10-0x000000018BD56A44
		public static int4x2 int4x2(float v) => default; // 0x000000018BD56A44-0x000000018BD56A60
		public static int4x2 int4x2(float4x2 v) => default; // 0x000000018BD56A7C-0x000000018BD56AB0
		public static int4x2 int4x2(double v) => default; // 0x000000018BD56994-0x000000018BD569B0
		public static int4x2 int4x2(double4x2 v) => default; // 0x000000018BD569B0-0x000000018BD569F4
		public static int2x4 transpose(int4x2 v) => default; // 0x000000018BD7012C-0x000000018BD70184
		public static uint hash(int4x2 v) => default; // 0x000000018BD514A4-0x000000018BD51570
		public static uint4 hashwide(int4x2 v) => default; // 0x000000018BD53A54-0x000000018BD53B2C
		public static int4x3 int4x3(int4 c0, int4 c1, int4 c2) => default; // 0x0000000185FDB930-0x0000000185FDB950
		public static int4x3 int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32) => default; // 0x0000000186F24DA8-0x0000000186F24F70
		public static int4x3 int4x3(int v) => default; // 0x000000018BD56AF4-0x000000018BD56B14
		public static int4x3 int4x3(bool v) => default; // 0x000000018BD56C14-0x000000018BD56C34
		public static int4x3 int4x3(bool4x3 v) => default; // 0x000000018BD56B94-0x000000018BD56BD0
		public static int4x3 int4x3(uint v) => default; // 0x000000018BD56AF4-0x000000018BD56B14
		public static int4x3 int4x3(uint4x3 v) => default; // 0x000000018BD56BD0-0x000000018BD56C14
		public static int4x3 int4x3(float v) => default; // 0x000000018BD56B74-0x000000018BD56B94
		public static int4x3 int4x3(float4x3 v) => default; // 0x000000018BD56C34-0x000000018BD56C74
		public static int4x3 int4x3(double v) => default; // 0x000000018BD56AD4-0x000000018BD56AF4
		public static int4x3 int4x3(double4x3 v) => default; // 0x000000018BD56B14-0x000000018BD56B74
		public static int3x4 transpose(int4x3 v) => default; // 0x000000018BD704E0-0x000000018BD70564
		public static uint hash(int4x3 v) => default; // 0x000000018BD51570-0x000000018BD516A0
		public static uint4 hashwide(int4x3 v) => default; // 0x000000018BD5509C-0x000000018BD551D8
		public static int4x4 int4x4(int4 c0, int4 c1, int4 c2, int4 c3) => default; // 0x0000000185FDB950-0x0000000185FDB980
		public static int4x4 int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33) => default; // 0x0000000186F24F70-0x0000000186F25208
		public static int4x4 int4x4(int v) => default; // 0x000000018BD56CF4-0x000000018BD56D18
		public static int4x4 int4x4(bool v) => default; // 0x000000018BD56C74-0x000000018BD56C98
		public static int4x4 int4x4(bool4x4 v) => default; // 0x000000018BD56D3C-0x000000018BD56D74
		public static int4x4 int4x4(uint v) => default; // 0x000000018BD56CF4-0x000000018BD56D18
		public static int4x4 int4x4(uint4x4 v) => default; // 0x000000018BD56D74-0x000000018BD56DD0
		public static int4x4 int4x4(float v) => default; // 0x000000018BD56D18-0x000000018BD56D3C
		public static int4x4 int4x4(float4x4 v) => default; // 0x000000018BD56C98-0x000000018BD56CF4
		public static int4x4 int4x4(double v) => default; // 0x000000018BD56E5C-0x000000018BD56E80
		public static int4x4 int4x4(double4x4 v) => default; // 0x000000018BD56DD0-0x000000018BD56E5C
		public static int4x4 transpose(int4x4 v) => default; // 0x000000018BD70864-0x000000018BD7090C
		public static int determinant(int4x4 m) => default; // 0x0000000185FDA530-0x0000000185FDA750
		public static uint hash(int4x4 v) => default; // 0x000000018BD50EF0-0x000000018BD51080
		public static uint4 hashwide(int4x4 v) => default; // 0x000000018BD53F54-0x000000018BD540F0
		public static int asint(uint x) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public static int2 asint(uint2 x) => default; // 0x0000000185779060-0x0000000185779070
		public static int3 asint(uint3 x) => default; // 0x0000000185FB7B80-0x0000000185FB7BA0
		public static int4 asint(uint4 x) => default; // 0x0000000181D61820-0x0000000181D61830
		public static int asint(float x) => default; // 0x0000000185FD0EE0-0x0000000185FD0EF0
		public static int2 asint(float2 x) => default; // 0x0000000185FD9430-0x0000000185FD9440
		public static int3 asint(float3 x) => default; // 0x0000000185FB7B80-0x0000000185FB7BA0
		public static int4 asint(float4 x) => default; // 0x0000000181D61820-0x0000000181D61830
		public static uint asuint(int x) => default; // 0x0000000185FB2C30-0x0000000185FB2C40
		public static uint2 asuint(int2 x) => default; // 0x0000000185779060-0x0000000185779070
		public static uint3 asuint(int3 x) => default; // 0x0000000185FB7B80-0x0000000185FB7BA0
		public static uint4 asuint(int4 x) => default; // 0x0000000181D61820-0x0000000181D61830
		public static uint asuint(float x) => default; // 0x0000000185FD0EE0-0x0000000185FD0EF0
		public static uint2 asuint(float2 x) => default; // 0x0000000185FD9430-0x0000000185FD9440
		public static uint3 asuint(float3 x) => default; // 0x0000000185FB7B80-0x0000000185FB7BA0
		public static uint4 asuint(float4 x) => default; // 0x0000000181D61820-0x0000000181D61830
		public static long aslong(ulong x) => default; // 0x0000000185779060-0x0000000185779070
		public static long aslong(double x) => default; // 0x0000000185FD0EC0-0x0000000185FD0ED0
		public static ulong asulong(long x) => default; // 0x0000000185779060-0x0000000185779070
		public static ulong asulong(double x) => default; // 0x0000000185FD0EC0-0x0000000185FD0ED0
		public static float asfloat(int x) => default; // 0x0000000185FCCC40-0x0000000185FCCC50
		public static float2 asfloat(int2 x) => default; // 0x0000000185FD9230-0x0000000185FD9250
		public static float3 asfloat(int3 x) => default; // 0x0000000185FB7B80-0x0000000185FB7BA0
		public static float4 asfloat(int4 x) => default; // 0x0000000181D61820-0x0000000181D61830
		public static float asfloat(uint x) => default; // 0x0000000185FCCC40-0x0000000185FCCC50
		public static float2 asfloat(uint2 x) => default; // 0x0000000185FD9230-0x0000000185FD9250
		public static float3 asfloat(uint3 x) => default; // 0x0000000185FB7B80-0x0000000185FB7BA0
		public static float4 asfloat(uint4 x) => default; // 0x0000000181D61820-0x0000000181D61830
		public static int bitmask(bool4 value) => default; // 0x000000018BD4844C-0x000000018BD48488
		public static double asdouble(long x) => default; // 0x0000000185FD0ED0-0x0000000185FD0EE0
		public static double asdouble(ulong x) => default; // 0x0000000185FD0ED0-0x0000000185FD0EE0
		public static bool isfinite(float x) => default; // 0x000000018BD58AE8-0x000000018BD58B04
		public static bool2 isfinite(float2 x) => default; // 0x000000018BD58A70-0x000000018BD58AA4
		public static bool3 isfinite(float3 x) => default; // 0x000000018BD58930-0x000000018BD5899C
		public static bool4 isfinite(float4 x) => default; // 0x000000018BD5899C-0x000000018BD58A00
		public static bool isfinite(double x) => default; // 0x000000018BD58908-0x000000018BD58930
		public static bool2 isfinite(double2 x) => default; // 0x000000018BD58AA4-0x000000018BD58AE8
		public static bool3 isfinite(double3 x) => default; // 0x000000018BD58B04-0x000000018BD58B78
		public static bool4 isfinite(double4 x) => default; // 0x000000018BD58A00-0x000000018BD58A70
		public static bool isinf(float x) => default; // 0x000000018BD58B78-0x000000018BD58B98
		public static bool2 isinf(float2 x) => default; // 0x000000018BD58C78-0x000000018BD58C98
		public static bool3 isinf(float3 x) => default; // 0x000000018BD58D10-0x000000018BD58D78
		public static bool4 isinf(float4 x) => default; // 0x000000018BD58CD4-0x000000018BD58D10
		public static bool isinf(double x) => default; // 0x000000018BD58C00-0x000000018BD58C2C
		public static bool2 isinf(double2 x) => default; // 0x000000018BD58C98-0x000000018BD58CD4
		public static bool3 isinf(double3 x) => default; // 0x000000018BD58B98-0x000000018BD58C00
		public static bool4 isinf(double4 x) => default; // 0x000000018BD58C2C-0x000000018BD58C78
		public static bool isnan(float x) => default; // 0x000000018BD58E24-0x000000018BD58E38
		public static bool2 isnan(float2 x) => default; // 0x000000018BD58DD8-0x000000018BD58E24
		public static bool3 isnan(float3 x) => default; // 0x000000018BD58F80-0x000000018BD58FF8
		public static bool4 isnan(float4 x) => default; // 0x000000018BD58F04-0x000000018BD58F80
		public static bool isnan(double x) => default; // 0x000000018BD58EA0-0x000000018BD58EC4
		public static bool2 isnan(double2 x) => default; // 0x000000018BD58EC4-0x000000018BD58F04
		public static bool3 isnan(double3 x) => default; // 0x000000018BD58D78-0x000000018BD58DD8
		public static bool4 isnan(double4 x) => default; // 0x000000018BD58E38-0x000000018BD58EA0
		public static bool ispow2(int x) => default; // 0x000000018BD5904C-0x000000018BD5905C
		public static bool2 ispow2(int2 x) => default; // 0x000000018BD5905C-0x000000018BD59090
		public static bool3 ispow2(int3 x) => default; // 0x000000018BD58FF8-0x000000018BD5904C
		public static bool4 ispow2(int4 x) => default; // 0x000000018BD5919C-0x000000018BD59214
		public static bool ispow2(uint x) => default; // 0x000000018BD59108-0x000000018BD59118
		public static bool2 ispow2(uint2 x) => default; // 0x000000018BD59118-0x000000018BD5914C
		public static bool3 ispow2(uint3 x) => default; // 0x000000018BD5914C-0x000000018BD5919C
		public static bool4 ispow2(uint4 x) => default; // 0x000000018BD59090-0x000000018BD59108
		public static int min(int x, int y) => default; // 0x000000018BD5A3C8-0x000000018BD5A3D0
		public static int2 min(int2 x, int2 y) => default; // 0x000000018BD5A698-0x000000018BD5A6C4
		public static int3 min(int3 x, int3 y) => default; // 0x000000018BD5A6D8-0x000000018BD5A70C
		public static int4 min(int4 x, int4 y) => default; // 0x000000018BD5A4A4-0x000000018BD5A4E8
		public static uint min(uint x, uint y) => default; // 0x000000018BD5A6D0-0x000000018BD5A6D8
		public static uint2 min(uint2 x, uint2 y) => default; // 0x000000018BD5A590-0x000000018BD5A5BC
		public static uint3 min(uint3 x, uint3 y) => default; // 0x000000018BD5A614-0x000000018BD5A648
		public static uint4 min(uint4 x, uint4 y) => default; // 0x000000018BD5A648-0x000000018BD5A68C
		public static long min(long x, long y) => default; // 0x000000018BD5A68C-0x000000018BD5A698
		public static ulong min(ulong x, ulong y) => default; // 0x000000018BD5A6C4-0x000000018BD5A6D0
		public static float min(float x, float y) => default; // 0x00000001840E8B20-0x00000001840E8F20
		public static float2 min(float2 x, float2 y) => default; // 0x000000018BD5A5BC-0x000000018BD5A614
		public static float3 min(float3 x, float3 y) => default; // 0x000000018BD5A43C-0x000000018BD5A4A4
		public static float4 min(float4 x, float4 y) => default; // 0x0000000186F26DC0-0x0000000186F26F60
		public static double min(double x, double y) => default; // 0x000000018BD5A4E8-0x000000018BD5A500
		public static double2 min(double2 x, double2 y) => default; // 0x0000000186F26C80-0x0000000186F26DC0
		public static double3 min(double3 x, double3 y) => default; // 0x000000018BD5A3D0-0x000000018BD5A43C
		public static double4 min(double4 x, double4 y) => default; // 0x000000018BD5A500-0x000000018BD5A590
		public static int max(int x, int y) => default; // 0x000000018BD5A160-0x000000018BD5A168
		public static int2 max(int2 x, int2 y) => default; // 0x000000018BD5A08C-0x000000018BD5A0B8
		public static int3 max(int3 x, int3 y) => default; // 0x000000018BD5A058-0x000000018BD5A08C
		public static int4 max(int4 x, int4 y) => default; // 0x000000018BD5A220-0x000000018BD5A264
		public static uint max(uint x, uint y) => default; // 0x000000018BD5A2FC-0x000000018BD5A304
		public static uint2 max(uint2 x, uint2 y) => default; // 0x000000018BD5A304-0x000000018BD5A330
		public static uint3 max(uint3 x, uint3 y) => default; // 0x000000018BD5A33C-0x000000018BD5A370
		public static uint4 max(uint4 x, uint4 y) => default; // 0x000000018BD5A1DC-0x000000018BD5A220
		public static long max(long x, long y) => default; // 0x000000018BD5A330-0x000000018BD5A33C
		public static ulong max(ulong x, ulong y) => default; // 0x000000018BD5A13C-0x000000018BD5A148
		public static float max(float x, float y) => default; // 0x000000018BD5A128-0x000000018BD5A13C
		public static float2 max(float2 x, float2 y) => default; // 0x000000018BD5A370-0x000000018BD5A3C8
		public static float3 max(float3 x, float3 y) => default; // 0x000000018BD5A0B8-0x000000018BD5A128
		public static float4 max(float4 x, float4 y) => default; // 0x0000000186F26938-0x0000000186F26A84
		public static double max(double x, double y) => default; // 0x000000018BD5A148-0x000000018BD5A160
		public static double2 max(double2 x, double2 y) => default; // 0x0000000186F26A84-0x0000000186F26C80
		public static double3 max(double3 x, double3 y) => default; // 0x000000018BD5A168-0x000000018BD5A1DC
		public static double4 max(double4 x, double4 y) => default; // 0x000000018BD5A264-0x000000018BD5A2FC
		public static float lerp(float start, float end, float t) => default; // 0x0000000185FB39B0-0x0000000185FB39C0
		public static float2 lerp(float2 start, float2 end, float t) => default; // 0x000000018BD5988C-0x000000018BD598C8
		public static float3 lerp(float3 start, float3 end, float t) => default; // 0x0000000186F25C80-0x0000000186F26094
		public static float4 lerp(float4 start, float4 end, float t) => default; // 0x000000018BD598C8-0x000000018BD59944
		public static float2 lerp(float2 start, float2 end, float2 t) => default; // 0x000000018BD594C0-0x000000018BD594FC
		public static float3 lerp(float3 start, float3 end, float3 t) => default; // 0x0000000186F25878-0x0000000186F25C80
		public static float4 lerp(float4 start, float4 end, float4 t) => default; // 0x000000018BD59438-0x000000018BD594C0
		public static double lerp(double start, double end, double t) => default; // 0x0000000185FDC4E0-0x0000000185FDC4F0
		public static double2 lerp(double2 start, double2 end, double t) => default; // 0x000000018BD593BC-0x000000018BD59438
		public static double3 lerp(double3 start, double3 end, double t) => default; // 0x000000018BD597CC-0x000000018BD5988C
		public static double4 lerp(double4 start, double4 end, double t) => default; // 0x000000018BD59690-0x000000018BD59744
		public static double2 lerp(double2 start, double2 end, double2 t) => default; // 0x000000018BD59744-0x000000018BD597CC
		public static double3 lerp(double3 start, double3 end, double3 t) => default; // 0x000000018BD595C0-0x000000018BD59690
		public static double4 lerp(double4 start, double4 end, double4 t) => default; // 0x000000018BD594FC-0x000000018BD595C0
		public static float unlerp(float start, float end, float x) => default; // 0x000000018BD71E24-0x000000018BD71E34
		public static float2 unlerp(float2 start, float2 end, float2 x) => default; // 0x000000018BD71EEC-0x000000018BD71F48
		public static float3 unlerp(float3 start, float3 end, float3 x) => default; // 0x0000000186F4858C-0x0000000186F487E4
		public static float4 unlerp(float4 start, float4 end, float4 x) => default; // 0x000000018BD71E34-0x000000018BD71EEC
		public static double unlerp(double start, double end, double x) => default; // 0x000000018BD72024-0x000000018BD72034
		public static double2 unlerp(double2 start, double2 end, double2 x) => default; // 0x000000018BD71DAC-0x000000018BD71E24
		public static double3 unlerp(double3 start, double3 end, double3 x) => default; // 0x000000018BD71CBC-0x000000018BD71DAC
		public static double4 unlerp(double4 start, double4 end, double4 x) => default; // 0x000000018BD71F48-0x000000018BD72024
		public static float remap(float srcStart, float srcEnd, float dstStart, float dstEnd, float x) => default; // 0x000000018BD6B56C-0x000000018BD6B590
		public static float2 remap(float2 srcStart, float2 srcEnd, float2 dstStart, float2 dstEnd, float2 x) => default; // 0x000000018BD6B4E8-0x000000018BD6B56C
		public static float3 remap(float3 srcStart, float3 srcEnd, float3 dstStart, float3 dstEnd, float3 x) => default; // 0x0000000186F3F324-0x0000000186F3F6A0
		public static float4 remap(float4 srcStart, float4 srcEnd, float4 dstStart, float4 dstEnd, float4 x) => default; // 0x000000018BD6B434-0x000000018BD6B4C4
		public static double remap(double srcStart, double srcEnd, double dstStart, double dstEnd, double x) => default; // 0x000000018BD6B4C4-0x000000018BD6B4E8
		public static double2 remap(double2 srcStart, double2 srcEnd, double2 dstStart, double2 dstEnd, double2 x) => default; // 0x000000018BD6B670-0x000000018BD6B700
		public static double3 remap(double3 srcStart, double3 srcEnd, double3 dstStart, double3 dstEnd, double3 x) => default; // 0x000000018BD6B590-0x000000018BD6B670
		public static double4 remap(double4 srcStart, double4 srcEnd, double4 dstStart, double4 dstEnd, double4 x) => default; // 0x000000018BD6B700-0x000000018BD6B7D4
		public static int mad(int mulA, int mulB, int addC) => default; // 0x0000000185FDC8E0-0x0000000185FDC8F0
		public static int2 mad(int2 mulA, int2 mulB, int2 addC) => default; // 0x000000018BD59E38-0x000000018BD59E50
		public static int3 mad(int3 mulA, int3 mulB, int3 addC) => default; // 0x0000000186F26638-0x0000000186F268B0
		public static int4 mad(int4 mulA, int4 mulB, int4 addC) => default; // 0x000000018BD59DD4-0x000000018BD59E38
		public static uint mad(uint mulA, uint mulB, uint addC) => default; // 0x0000000185FDC8E0-0x0000000185FDC8F0
		public static uint2 mad(uint2 mulA, uint2 mulB, uint2 addC) => default; // 0x000000018BD59E38-0x000000018BD59E50
		public static uint3 mad(uint3 mulA, uint3 mulB, uint3 addC) => default; // 0x0000000186F26638-0x0000000186F268B0
		public static uint4 mad(uint4 mulA, uint4 mulB, uint4 addC) => default; // 0x000000018BD59DD4-0x000000018BD59E38
		public static long mad(long mulA, long mulB, long addC) => default; // 0x0000000185FDC8B0-0x0000000185FDC8C0
		public static ulong mad(ulong mulA, ulong mulB, ulong addC) => default; // 0x0000000185FDC8B0-0x0000000185FDC8C0
		public static float mad(float mulA, float mulB, float addC) => default; // 0x0000000185FDC8C0-0x0000000185FDC8D0
		public static float2 mad(float2 mulA, float2 mulB, float2 addC) => default; // 0x000000018BD59EE8-0x000000018BD59F00
		public static float3 mad(float3 mulA, float3 mulB, float3 addC) => default; // 0x0000000186F268B0-0x0000000186F26938
		public static float4 mad(float4 mulA, float4 mulB, float4 addC) => default; // 0x000000018BD59F64-0x000000018BD59FC8
		public static double mad(double mulA, double mulB, double addC) => default; // 0x0000000185FDC8D0-0x0000000185FDC8E0
		public static double2 mad(double2 mulA, double2 mulB, double2 addC) => default; // 0x000000018BD59F00-0x000000018BD59F64
		public static double3 mad(double3 mulA, double3 mulB, double3 addC) => default; // 0x000000018BD59E50-0x000000018BD59EE8
		public static double4 mad(double4 mulA, double4 mulB, double4 addC) => default; // 0x000000018BD59FC8-0x000000018BD5A058
		public static int clamp(int valueToClamp, int lowerBound, int upperBound) => default; // 0x000000018BD49094-0x000000018BD490A8
		public static int2 clamp(int2 valueToClamp, int2 lowerBound, int2 upperBound) => default; // 0x000000018BD490E4-0x000000018BD49140
		public static int3 clamp(int3 valueToClamp, int3 lowerBound, int3 upperBound) => default; // 0x0000000186F18058-0x0000000186F18200
		public static int4 clamp(int4 valueToClamp, int4 lowerBound, int4 upperBound) => default; // 0x000000018BD48FD0-0x000000018BD49094
		public static uint clamp(uint valueToClamp, uint lowerBound, uint upperBound) => default; // 0x000000018BD48FBC-0x000000018BD48FD0
		public static uint2 clamp(uint2 valueToClamp, uint2 lowerBound, uint2 upperBound) => default; // 0x000000018BD48E98-0x000000018BD48EF4
		public static uint3 clamp(uint3 valueToClamp, uint3 lowerBound, uint3 upperBound) => default; // 0x0000000186F18200-0x0000000186F183B8
		public static uint4 clamp(uint4 valueToClamp, uint4 lowerBound, uint4 upperBound) => default; // 0x000000018BD48CD0-0x000000018BD48D94
		public static long clamp(long valueToClamp, long lowerBound, long upperBound) => default; // 0x000000018BD48F1C-0x000000018BD48F30
		public static ulong clamp(ulong valueToClamp, ulong lowerBound, ulong upperBound) => default; // 0x000000018BD490D0-0x000000018BD490E4
		public static float clamp(float valueToClamp, float lowerBound, float upperBound) => default; // 0x000000018BD490A8-0x000000018BD490D0
		public static float2 clamp(float2 valueToClamp, float2 lowerBound, float2 upperBound) => default; // 0x000000018BD48EF4-0x000000018BD48F1C
		public static float3 clamp(float3 valueToClamp, float3 lowerBound, float3 upperBound) => default; // 0x000000018BD48F30-0x000000018BD48FBC
		public static float4 clamp(float4 valueToClamp, float4 lowerBound, float4 upperBound) => default; // 0x000000018BD48D94-0x000000018BD48DFC
		public static double clamp(double valueToClamp, double lowerBound, double upperBound) => default; // 0x0000000186F17F28-0x0000000186F18058
		public static double2 clamp(double2 valueToClamp, double2 lowerBound, double2 upperBound) => default; // 0x000000018BD49140-0x000000018BD491A8
		public static double3 clamp(double3 valueToClamp, double3 lowerBound, double3 upperBound) => default; // 0x000000018BD48DFC-0x000000018BD48E98
		public static double4 clamp(double4 valueToClamp, double4 lowerBound, double4 upperBound) => default; // 0x000000018BD491A8-0x000000018BD49238
		public static float saturate(float x) => default; // 0x000000018AAD4660-0x000000018AAD4670
		public static float2 saturate(float2 x) => default; // 0x000000018BD6CB1C-0x000000018BD6CB58
		public static float3 saturate(float3 x) => default; // 0x0000000186F406E0-0x0000000186F40A20
		public static float4 saturate(float4 x) => default; // 0x000000018BD6CAD0-0x000000018BD6CB1C
		public static double saturate(double x) => default; // 0x000000018BD6CAC0-0x000000018BD6CAD0
		public static double2 saturate(double2 x) => default; // 0x000000018BD6CBF4-0x000000018BD6CC44
		public static double3 saturate(double3 x) => default; // 0x000000018BD6CB58-0x000000018BD6CBF4
		public static double4 saturate(double4 x) => default; // 0x000000018BD6CA54-0x000000018BD6CAC0
		public static int abs(int x) => default; // 0x000000018BD47864-0x000000018BD47870
		public static int2 abs(int2 x) => default; // 0x000000018BD47768-0x000000018BD477AC
		public static int3 abs(int3 x) => default; // 0x0000000186F16248-0x0000000186F16780
		public static int4 abs(int4 x) => default; // 0x000000018BD477AC-0x000000018BD47864
		public static long abs(long x) => default; // 0x000000018BD47758-0x000000018BD47768
		public static float abs(float x) => default; // 0x0000000185FD8F60-0x0000000185FD8F70
		public static float2 abs(float2 x) => default; // 0x0000000185FD9020-0x0000000185FD9050
		public static float3 abs(float3 x) => default; // 0x0000000184CFDE20-0x0000000184CFDEF0
		public static float4 abs(float4 x) => default; // 0x000000018BD47724-0x000000018BD47758
		public static double abs(double x) => default; // 0x0000000185FD9000-0x0000000185FD9020
		public static double2 abs(double2 x) => default; // 0x0000000185FD8FD0-0x0000000185FD9000
		public static double3 abs(double3 x) => default; // 0x0000000185FD8F20-0x0000000185FD8F60
		public static double4 abs(double4 x) => default; // 0x0000000185FD8F70-0x0000000185FD8FD0
		public static int dot(int x, int y) => default; // 0x0000000185FDA950-0x0000000185FDA960
		public static int dot(int2 x, int2 y) => default; // 0x0000000185FDA9E0-0x0000000185FDAA00
		public static int dot(int3 x, int3 y) => default; // 0x0000000185FB00D0-0x0000000185FB00F0
		public static int dot(int4 x, int4 y) => default; // 0x0000000185FDA9A0-0x0000000185FDA9D0
		public static uint dot(uint x, uint y) => default; // 0x0000000185FDA950-0x0000000185FDA960
		public static uint dot(uint2 x, uint2 y) => default; // 0x0000000185FDA9E0-0x0000000185FDAA00
		public static uint dot(uint3 x, uint3 y) => default; // 0x0000000185FB00D0-0x0000000185FB00F0
		public static uint dot(uint4 x, uint4 y) => default; // 0x0000000185FDA9A0-0x0000000185FDA9D0
		public static float dot(float x, float y) => default; // 0x0000000185FDAA00-0x0000000185FDAA10
		public static float dot(float2 x, float2 y) => default; // 0x0000000185FB5600-0x0000000185FB5630
		public static float dot(float3 x, float3 y) => default; // 0x0000000185FB5780-0x0000000185FB57B0
		public static float dot(float4 x, float4 y) => default; // 0x00000001845B93F0-0x00000001845B9430
		public static double dot(double x, double y) => default; // 0x0000000185FDA9D0-0x0000000185FDA9E0
		public static double dot(double2 x, double2 y) => default; // 0x0000000185FDAA40-0x0000000185FDAA60
		public static double dot(double3 x, double3 y) => default; // 0x0000000185FDAA10-0x0000000185FDAA40
		public static double dot(double4 x, double4 y) => default; // 0x0000000185FDA960-0x0000000185FDA9A0
		public static float tan(float x) => default; // 0x000000018BD6F9B0-0x000000018BD6FA08
		public static float2 tan(float2 x) => default; // 0x000000018BD6F83C-0x000000018BD6F878
		public static float3 tan(float3 x) => default; // 0x0000000186F4522C-0x0000000186F45398
		public static float4 tan(float4 x) => default; // 0x0000000186F451A8-0x0000000186F4522C
		public static double tan(double x) => default; // 0x000000018BD6F960-0x000000018BD6F9B0
		public static double2 tan(double2 x) => default; // 0x0000000186F44FC8-0x0000000186F451A8
		public static double3 tan(double3 x) => default; // 0x000000018BD6F8FC-0x000000018BD6F960
		public static double4 tan(double4 x) => default; // 0x000000018BD6F878-0x000000018BD6F8FC
		public static float tanh(float x) => default; // 0x000000018BD6FB7C-0x000000018BD6FBD4
		public static float2 tanh(float2 x) => default; // 0x000000018BD6FB40-0x000000018BD6FB7C
		public static float3 tanh(float3 x) => default; // 0x0000000186F454AC-0x0000000186F45568
		public static float4 tanh(float4 x) => default; // 0x0000000186F45398-0x0000000186F454AC
		public static double tanh(double x) => default; // 0x000000018BD6FAF0-0x000000018BD6FB40
		public static double2 tanh(double2 x) => default; // 0x0000000186F45568-0x0000000186F47BA0
		public static double3 tanh(double3 x) => default; // 0x000000018BD6FA08-0x000000018BD6FA6C
		public static double4 tanh(double4 x) => default; // 0x000000018BD6FA6C-0x000000018BD6FAF0
		public static float atan(float x) => default; // 0x000000018BD48304-0x000000018BD4835C
		public static float2 atan(float2 x) => default; // 0x000000018BD48410-0x000000018BD4844C
		public static float3 atan(float3 x) => default; // 0x0000000186F16E6C-0x0000000186F17030
		public static float4 atan(float4 x) => default; // 0x0000000186F16DE8-0x0000000186F16E6C
		public static double atan(double x) => default; // 0x000000018BD483C0-0x000000018BD48410
		public static double2 atan(double2 x) => default; // 0x0000000186F17030-0x0000000186F17108
		public static double3 atan(double3 x) => default; // 0x000000018BD4835C-0x000000018BD483C0
		public static double4 atan(double4 x) => default; // 0x000000018BD48280-0x000000018BD48304
		public static float atan2(float y, float x) => default; // 0x000000018BD48178-0x000000018BD481DC
		public static float2 atan2(float2 y, float2 x) => default; // 0x000000018BD4812C-0x000000018BD48178
		public static float3 atan2(float3 y, float3 x) => default; // 0x0000000186F16B70-0x0000000186F16C40
		public static float4 atan2(float4 y, float4 x) => default; // 0x0000000186F16CA0-0x0000000186F16DE8
		public static double atan2(double y, double x) => default; // 0x000000018BD480CC-0x000000018BD4812C
		public static double2 atan2(double2 y, double2 x) => default; // 0x0000000186F16C40-0x0000000186F16CA0
		public static double3 atan2(double3 y, double3 x) => default; // 0x000000018BD4804C-0x000000018BD480CC
		public static double4 atan2(double4 y, double4 x) => default; // 0x000000018BD481DC-0x000000018BD48280
		public static float cos(float x) => default; // 0x000000018BD495A4-0x000000018BD495FC
		public static float2 cos(float2 x) => default; // 0x0000000185FD9A60-0x0000000185FD9AA0
		public static float3 cos(float3 x) => default; // 0x0000000185FD9AF0-0x0000000185FD9B40
		public static float4 cos(float4 x) => default; // 0x0000000185FD9BE0-0x0000000185FD9C40
		public static double cos(double x) => default; // 0x000000018BD495FC-0x000000018BD4964C
		public static double2 cos(double2 x) => default; // 0x0000000185FD9B40-0x0000000185FD9B80
		public static double3 cos(double3 x) => default; // 0x0000000185FD9AA0-0x0000000185FD9AF0
		public static double4 cos(double4 x) => default; // 0x0000000185FD9B80-0x0000000185FD9BE0
		public static float cosh(float x) => default; // 0x000000018BD4964C-0x000000018BD496A4
		public static float2 cosh(float2 x) => default; // 0x0000000185FD9C40-0x0000000185FD9C80
		public static float3 cosh(float3 x) => default; // 0x0000000185FD9CD0-0x0000000185FD9D20
		public static float4 cosh(float4 x) => default; // 0x0000000185FD9D80-0x0000000185FD9DE0
		public static double cosh(double x) => default; // 0x000000018BD496A4-0x000000018BD496F4
		public static double2 cosh(double2 x) => default; // 0x0000000185FD9DE0-0x0000000185FD9E20
		public static double3 cosh(double3 x) => default; // 0x0000000185FD9C80-0x0000000185FD9CD0
		public static double4 cosh(double4 x) => default; // 0x0000000185FD9D20-0x0000000185FD9D80
		public static float acos(float x) => default; // 0x000000018BD478C0-0x000000018BD47918
		public static float2 acos(float2 x) => default; // 0x0000000185FD9050-0x0000000185FD9090
		public static float3 acos(float3 x) => default; // 0x0000000185FD9090-0x0000000185FD90E0
		public static float4 acos(float4 x) => default; // 0x0000000185FD9140-0x0000000185FD91A0
		public static double acos(double x) => default; // 0x000000018BD47870-0x000000018BD478C0
		public static double2 acos(double2 x) => default; // 0x0000000185FD91A0-0x0000000185FD91E0
		public static double3 acos(double3 x) => default; // 0x0000000185FD91E0-0x0000000185FD9230
		public static double4 acos(double4 x) => default; // 0x0000000185FD90E0-0x0000000185FD9140
		public static float sin(float x) => default; // 0x000000018BD6E5C0-0x000000018BD6E618
		public static float2 sin(float2 x) => default; // 0x0000000185FDDA30-0x0000000185FDDA70
		public static float3 sin(float3 x) => default; // 0x0000000185FDD920-0x0000000185FDD970
		public static float4 sin(float4 x) => default; // 0x0000000185FDD9D0-0x0000000185FDDA30
		public static double sin(double x) => default; // 0x000000018BD6E618-0x000000018BD6E668
		public static double2 sin(double2 x) => default; // 0x0000000185FDDA70-0x0000000185FDDAB0
		public static double3 sin(double3 x) => default; // 0x0000000185FDD8D0-0x0000000185FDD920
		public static double4 sin(double4 x) => default; // 0x0000000185FDD970-0x0000000185FDD9D0
		public static float sinh(float x) => default; // 0x000000018BD6E960-0x000000018BD6E9B8
		public static float2 sinh(float2 x) => default; // 0x0000000185FDDCD0-0x0000000185FDDD10
		public static float3 sinh(float3 x) => default; // 0x0000000185FDDB70-0x0000000185FDDBC0
		public static float4 sinh(float4 x) => default; // 0x0000000185FDDC70-0x0000000185FDDCD0
		public static double sinh(double x) => default; // 0x000000018BD6E910-0x000000018BD6E960
		public static double2 sinh(double2 x) => default; // 0x0000000185FDDB30-0x0000000185FDDB70
		public static double3 sinh(double3 x) => default; // 0x0000000185FDDC20-0x0000000185FDDC70
		public static double4 sinh(double4 x) => default; // 0x0000000185FDDBC0-0x0000000185FDDC20
		public static float asin(float x) => default; // 0x000000018BD47FF4-0x000000018BD4804C
		public static float2 asin(float2 x) => default; // 0x0000000185FD9250-0x0000000185FD9290
		public static float3 asin(float3 x) => default; // 0x0000000185FD92F0-0x0000000185FD9340
		public static float4 asin(float4 x) => default; // 0x0000000185FD93D0-0x0000000185FD9430
		public static double asin(double x) => default; // 0x000000018BD47FA4-0x000000018BD47FF4
		public static double2 asin(double2 x) => default; // 0x0000000185FD9390-0x0000000185FD93D0
		public static double3 asin(double3 x) => default; // 0x0000000185FD9340-0x0000000185FD9390
		public static double4 asin(double4 x) => default; // 0x0000000185FD9290-0x0000000185FD92F0
		public static float floor(float x) => default; // 0x000000018BD4EBD0-0x000000018BD4EC28
		public static float2 floor(float2 x) => default; // 0x0000000185FDBAD0-0x0000000185FDBB10
		public static float3 floor(float3 x) => default; // 0x00000001852E13A0-0x00000001852E13F0
		public static float4 floor(float4 x) => default; // 0x0000000185FDB980-0x0000000185FDB9E0
		public static double floor(double x) => default; // 0x000000018BD4EC28-0x000000018BD4EC78
		public static double2 floor(double2 x) => default; // 0x0000000185FDBA90-0x0000000185FDBAD0
		public static double3 floor(double3 x) => default; // 0x0000000185FDB9E0-0x0000000185FDBA30
		public static double4 floor(double4 x) => default; // 0x0000000185FDBA30-0x0000000185FDBA90
		public static float ceil(float x) => default; // 0x000000018BD48648-0x000000018BD486A0
		public static float2 ceil(float2 x) => default; // 0x0000000185FD9810-0x0000000185FD9850
		public static float3 ceil(float3 x) => default; // 0x0000000185FD9950-0x0000000185FD99A0
		public static float4 ceil(float4 x) => default; // 0x0000000185FD9890-0x0000000185FD98F0
		public static double ceil(double x) => default; // 0x000000018BD486A0-0x000000018BD486F0
		public static double2 ceil(double2 x) => default; // 0x0000000185FD9850-0x0000000185FD9890
		public static double3 ceil(double3 x) => default; // 0x0000000185FD97C0-0x0000000185FD9810
		public static double4 ceil(double4 x) => default; // 0x0000000185FD98F0-0x0000000185FD9950
		public static float round(float x) => default; // 0x000000018BD6C690-0x000000018BD6C6E8
		public static float2 round(float2 x) => default; // 0x000000018BD6C7D0-0x000000018BD6C80C
		public static float3 round(float3 x) => default; // 0x0000000186F40294-0x0000000186F40400
		public static float4 round(float4 x) => default; // 0x0000000186F40400-0x0000000186F404C4
		public static double round(double x) => default; // 0x000000018BD6C640-0x000000018BD6C690
		public static double2 round(double2 x) => default; // 0x0000000186F4024C-0x0000000186F40294
		public static double3 round(double3 x) => default; // 0x000000018BD6C6E8-0x000000018BD6C74C
		public static double4 round(double4 x) => default; // 0x000000018BD6C74C-0x000000018BD6C7D0
		public static float trunc(float x) => default; // 0x000000018BD71058-0x000000018BD710B4
		public static float2 trunc(float2 x) => default; // 0x000000018BD7101C-0x000000018BD71058
		public static float3 trunc(float3 x) => default; // 0x0000000186F47CF8-0x0000000186F47DE0
		public static float4 trunc(float4 x) => default; // 0x0000000186F47BA0-0x0000000186F47CF8
		public static double trunc(double x) => default; // 0x000000018BD70EE4-0x000000018BD70F34
		public static double2 trunc(double2 x) => default; // 0x0000000186F47DE0-0x0000000186F48124
		public static double3 trunc(double3 x) => default; // 0x000000018BD70F34-0x000000018BD70F98
		public static double4 trunc(double4 x) => default; // 0x000000018BD70F98-0x000000018BD7101C
		public static float frac(float x) => default; // 0x0000000185FCE570-0x0000000185FCE5A0
		public static float2 frac(float2 x) => default; // 0x000000018BD4ED90-0x000000018BD4EDC0
		public static float3 frac(float3 x) => default; // 0x0000000186F1CA94-0x0000000186F1CD64
		public static float4 frac(float4 x) => default; // 0x000000018BD4ED2C-0x000000018BD4ED90
		public static double frac(double x) => default; // 0x0000000185FDBF20-0x0000000185FDBF50
		public static double2 frac(double2 x) => default; // 0x000000018BD4EE54-0x000000018BD4EEB8
		public static double3 frac(double3 x) => default; // 0x000000018BD4EDC0-0x000000018BD4EE54
		public static double4 frac(double4 x) => default; // 0x000000018BD4EEB8-0x000000018BD4EF44
		public static float rcp(float x) => default; // 0x000000018BD6AAA8-0x000000018BD6AAB8
		public static float2 rcp(float2 x) => default; // 0x000000018BD6A968-0x000000018BD6A990
		public static float3 rcp(float3 x) => default; // 0x000000018BD6A9D4-0x000000018BD6AA14
		public static float4 rcp(float4 x) => default; // 0x000000018BD6AA3C-0x000000018BD6AAA8
		public static double rcp(double x) => default; // 0x000000018BD6A958-0x000000018BD6A968
		public static double2 rcp(double2 x) => default; // 0x000000018BD6AA14-0x000000018BD6AA3C
		public static double3 rcp(double3 x) => default; // 0x000000018BD6A91C-0x000000018BD6A958
		public static double4 rcp(double4 x) => default; // 0x000000018BD6A990-0x000000018BD6A9D4
		public static int sign(int x) => default; // 0x000000018BD6E37C-0x000000018BD6E38C
		public static int2 sign(int2 x) => default; // 0x000000018BD6E4C4-0x000000018BD6E4F8
		public static int3 sign(int3 x) => default; // 0x000000018BD6E578-0x000000018BD6E5C0
		public static int4 sign(int4 x) => default; // 0x000000018BD6E464-0x000000018BD6E4C4
		public static float sign(float x) => default; // 0x0000000186F43B7C-0x0000000186F44244
		public static float2 sign(float2 x) => default; // 0x000000018BD6E3C4-0x000000018BD6E3F4
		public static float3 sign(float3 x) => default; // 0x000000018BD6E540-0x000000018BD6E578
		public static float4 sign(float4 x) => default; // 0x000000018BD6E41C-0x000000018BD6E464
		public static double sign(double x) => default; // 0x0000000186F43B44-0x0000000186F43B7C
		public static double2 sign(double2 x) => default; // 0x000000018BD6E3F4-0x000000018BD6E41C
		public static double3 sign(double3 x) => default; // 0x000000018BD6E38C-0x000000018BD6E3C4
		public static double4 sign(double4 x) => default; // 0x000000018BD6E4F8-0x000000018BD6E540
		public static float pow(float x, float y) => default; // 0x000000018BD69E68-0x000000018BD69ECC
		public static float2 pow(float2 x, float2 y) => default; // 0x000000018BD69ECC-0x000000018BD69F18
		public static float3 pow(float3 x, float3 y) => default; // 0x0000000186F3D7C4-0x0000000186F3DA5C
		public static float4 pow(float4 x, float4 y) => default; // 0x0000000186F3DABC-0x0000000186F3DC00
		public static double pow(double x, double y) => default; // 0x000000018BD69F18-0x000000018BD69F78
		public static double2 pow(double2 x, double2 y) => default; // 0x0000000186F3DA5C-0x0000000186F3DABC
		public static double3 pow(double3 x, double3 y) => default; // 0x000000018BD69DE8-0x000000018BD69E68
		public static double4 pow(double4 x, double4 y) => default; // 0x000000018BD69F78-0x000000018BD6A01C
		public static float exp(float x) => default; // 0x000000018BD4B8E4-0x000000018BD4B93C
		public static float2 exp(float2 x) => default; // 0x0000000185FDB210-0x0000000185FDB250
		public static float3 exp(float3 x) => default; // 0x0000000185FDB340-0x0000000185FDB390
		public static float4 exp(float4 x) => default; // 0x0000000185FDB1B0-0x0000000185FDB210
		public static double exp(double x) => default; // 0x000000018BD4B894-0x000000018BD4B8E4
		public static double2 exp(double2 x) => default; // 0x0000000185FDB250-0x0000000185FDB290
		public static double3 exp(double3 x) => default; // 0x0000000185FDB290-0x0000000185FDB2E0
		public static double4 exp(double4 x) => default; // 0x0000000185FDB2E0-0x0000000185FDB340
		public static float exp2(float x) => default; // 0x000000018BD4B6B8-0x000000018BD4B718
		public static float2 exp2(float2 x) => default; // 0x000000018BD4B858-0x000000018BD4B894
		public static float3 exp2(float3 x) => default; // 0x0000000186F1A544-0x0000000186F1A660
		public static float4 exp2(float4 x) => default; // 0x0000000186F1A7F0-0x0000000186F1A874
		public static double exp2(double x) => default; // 0x000000018BD4B718-0x000000018BD4B770
		public static double2 exp2(double2 x) => default; // 0x0000000186F1A660-0x0000000186F1A7F0
		public static double3 exp2(double3 x) => default; // 0x000000018BD4B770-0x000000018BD4B7D4
		public static double4 exp2(double4 x) => default; // 0x000000018BD4B7D4-0x000000018BD4B858
		public static float exp10(float x) => default; // 0x000000018BD4B658-0x000000018BD4B6B8
		public static float2 exp10(float2 x) => default; // 0x000000018BD4B4DC-0x000000018BD4B518
		public static float3 exp10(float3 x) => default; // 0x0000000186F1A214-0x0000000186F1A2B8
		public static float4 exp10(float4 x) => default; // 0x0000000186F1A384-0x0000000186F1A544
		public static double exp10(double x) => default; // 0x000000018BD4B59C-0x000000018BD4B5F4
		public static double2 exp10(double2 x) => default; // 0x0000000186F1A2B8-0x0000000186F1A384
		public static double3 exp10(double3 x) => default; // 0x000000018BD4B5F4-0x000000018BD4B658
		public static double4 exp10(double4 x) => default; // 0x000000018BD4B518-0x000000018BD4B59C
		public static float log(float x) => default; // 0x000000018BD59C18-0x000000018BD59C70
		public static float2 log(float2 x) => default; // 0x0000000185FDC770-0x0000000185FDC7B0
		public static float3 log(float3 x) => default; // 0x0000000185FDC800-0x0000000185FDC850
		public static float4 log(float4 x) => default; // 0x0000000185FDC710-0x0000000185FDC770
		public static double log(double x) => default; // 0x000000018BD59BC8-0x000000018BD59C18
		public static double2 log(double2 x) => default; // 0x0000000185FDC6D0-0x0000000185FDC710
		public static double3 log(double3 x) => default; // 0x0000000185FDC7B0-0x0000000185FDC800
		public static double4 log(double4 x) => default; // 0x0000000185FDC850-0x0000000185FDC8B0
		public static float log2(float x) => default; // 0x000000018BD599EC-0x000000018BD59A48
		public static float2 log2(float2 x) => default; // 0x000000018BD59A48-0x000000018BD59A84
		public static float3 log2(float3 x) => default; // 0x0000000186F26138-0x0000000186F2619C
		public static float4 log2(float4 x) => default; // 0x0000000186F2619C-0x0000000186F26430
		public static double log2(double x) => default; // 0x000000018BD59A84-0x000000018BD59AE0
		public static double2 log2(double2 x) => default; // 0x0000000186F26094-0x0000000186F26138
		public static double3 log2(double3 x) => default; // 0x000000018BD59AE0-0x000000018BD59B44
		public static double4 log2(double4 x) => default; // 0x000000018BD59B44-0x000000018BD59BC8
		public static float log10(float x) => default; // 0x000000018BD59944-0x000000018BD5999C
		public static float2 log10(float2 x) => default; // 0x0000000185FDC640-0x0000000185FDC680
		public static float3 log10(float3 x) => default; // 0x0000000185FDC680-0x0000000185FDC6D0
		public static float4 log10(float4 x) => default; // 0x0000000185FDC590-0x0000000185FDC5F0
		public static double log10(double x) => default; // 0x000000018BD5999C-0x000000018BD599EC
		public static double2 log10(double2 x) => default; // 0x0000000185FDC4F0-0x0000000185FDC530
		public static double3 log10(double3 x) => default; // 0x0000000185FDC5F0-0x0000000185FDC640
		public static double4 log10(double4 x) => default; // 0x0000000185FDC530-0x0000000185FDC590
		public static float fmod(float x, float y) => default; // 0x0000000185FB2AE0-0x0000000185FB2AF0
		public static float2 fmod(float2 x, float2 y) => default; // 0x0000000185FDBBF0-0x0000000185FDBC40
		public static float3 fmod(float3 x, float3 y) => default; // 0x0000000185FDBB10-0x0000000185FDBB80
		public static float4 fmod(float4 x, float4 y) => default; // 0x0000000185FDBC40-0x0000000185FDBCC0
		public static double fmod(double x, double y) => default; // 0x0000000185FDBDA0-0x0000000185FDBDB0
		public static double2 fmod(double2 x, double2 y) => default; // 0x0000000185FDBD40-0x0000000185FDBDA0
		public static double3 fmod(double3 x, double3 y) => default; // 0x0000000185FDBB80-0x0000000185FDBBF0
		public static double4 fmod(double4 x, double4 y) => default; // 0x0000000185FDBCC0-0x0000000185FDBD40
		public static float modf(float x, out float i) {
			i = default;
			return default;
		} // 0x000000018BD5A998-0x000000018BD5A9C4
		public static float2 modf(float2 x, out float2 i) {
			i = default;
			return default;
		} // 0x000000018BD5A850-0x000000018BD5A888
		public static float3 modf(float3 x, out float3 i) {
			i = default;
			return default;
		} // 0x0000000186F26F60-0x0000000186F3D2BC
		public static float4 modf(float4 x, out float4 i) {
			i = default;
			return default;
		} // 0x000000018BD5A7B0-0x000000018BD5A824
		public static double modf(double x, out double i) {
			i = default;
			return default;
		} // 0x000000018BD5A824-0x000000018BD5A850
		public static double2 modf(double2 x, out double2 i) {
			i = default;
			return default;
		} // 0x000000018BD5A924-0x000000018BD5A998
		public static double3 modf(double3 x, out double3 i) {
			i = default;
			return default;
		} // 0x000000018BD5A70C-0x000000018BD5A7B0
		public static double4 modf(double4 x, out double4 i) {
			i = default;
			return default;
		} // 0x000000018BD5A888-0x000000018BD5A924
		public static float sqrt(float x) => default; // 0x000000018BD6F2C0-0x000000018BD6F310
		public static float2 sqrt(float2 x) => default; // 0x0000000185FDDD10-0x0000000185FDDD80
		public static float3 sqrt(float3 x) => default; // 0x0000000185FDE000-0x0000000185FDE0A0
		public static float4 sqrt(float4 x) => default; // 0x0000000185FDDD80-0x0000000185FDDE40
		public static double sqrt(double x) => default; // 0x000000018BD6F278-0x000000018BD6F2C0
		public static double2 sqrt(double2 x) => default; // 0x0000000185FDDE40-0x0000000185FDDEB0
		public static double3 sqrt(double3 x) => default; // 0x0000000185FDDF70-0x0000000185FDE000
		public static double4 sqrt(double4 x) => default; // 0x0000000185FDDEB0-0x0000000185FDDF70
		public static float rsqrt(float x) => default; // 0x000000018BD6C8F4-0x000000018BD6C924
		public static float2 rsqrt(float2 x) => default; // 0x000000018BD6C9A8-0x000000018BD6C9DC
		public static float3 rsqrt(float3 x) => default; // 0x0000000186F404C4-0x0000000186F406E0
		public static float4 rsqrt(float4 x) => default; // 0x000000018BD6C924-0x000000018BD6C9A8
		public static double rsqrt(double x) => default; // 0x000000018BD6C9DC-0x000000018BD6CA0C
		public static double2 rsqrt(double2 x) => default; // 0x000000018BD6CA0C-0x000000018BD6CA54
		public static double3 rsqrt(double3 x) => default; // 0x000000018BD6C80C-0x000000018BD6C884
		public static double4 rsqrt(double4 x) => default; // 0x000000018BD6C884-0x000000018BD6C8F4
		public static float2 normalize(float2 x) => default; // 0x000000018BD695CC-0x000000018BD69634
		public static float3 normalize(float3 x) => default; // 0x000000018BD69634-0x000000018BD696A8
		public static float4 normalize(float4 x) => default; // 0x000000018BD694F4-0x000000018BD69550
		public static double2 normalize(double2 x) => default; // 0x0000000186F3D2BC-0x0000000186F3D5A4
		public static double3 normalize(double3 x) => default; // 0x000000018BD69474-0x000000018BD694F4
		public static double4 normalize(double4 x) => default; // 0x000000018BD69550-0x000000018BD695CC
		public static float2 normalizesafe(float2 x, float2 defaultvalue = default) => default; // 0x000000018BD69758-0x000000018BD697E0
		public static float3 normalizesafe(float3 x, float3 defaultvalue = default) => default; // 0x0000000186F3D5A4-0x0000000186F3D644
		public static float4 normalizesafe(float4 x, float4 defaultvalue = default) => default; // 0x000000018BD697E0-0x000000018BD6986C
		public static double2 normalizesafe(double2 x, double2 defaultvalue = default) => default; // 0x0000000186F3D644-0x0000000186F3D7C4
		public static double3 normalizesafe(double3 x, double3 defaultvalue = default) => default; // 0x000000018BD6992C-0x000000018BD69A18
		public static double4 normalizesafe(double4 x, double4 defaultvalue = default) => default; // 0x000000018BD696A8-0x000000018BD69758
		public static float length(float x) => default; // 0x0000000185FD8F60-0x0000000185FD8F70
		public static float length(float2 x) => default; // 0x0000000185FB5670-0x0000000185FB56B0
		public static float length(float3 x) => default; // 0x000000018BD59214-0x000000018BD5924C
		public static float length(float4 x) => default; // 0x000000018BD592B8-0x000000018BD592F4
		public static double length(double x) => default; // 0x0000000185FD9000-0x0000000185FD9020
		public static double length(double2 x) => default; // 0x0000000185FDC470-0x0000000185FDC4B0
		public static double length(double3 x) => default; // 0x000000018BD59280-0x000000018BD592B8
		public static double length(double4 x) => default; // 0x000000018BD5924C-0x000000018BD59280
		public static float lengthsq(float x) => default; // 0x0000000185FB2920-0x0000000185FB2930
		public static float lengthsq(float2 x) => default; // 0x0000000185FB5650-0x0000000185FB5670
		public static float lengthsq(float3 x) => default; // 0x000000018BD59354-0x000000018BD59388
		public static float lengthsq(float4 x) => default; // 0x000000018BD592F4-0x000000018BD5931C
		public static double lengthsq(double x) => default; // 0x0000000185FDC4D0-0x0000000185FDC4E0
		public static double lengthsq(double2 x) => default; // 0x0000000185FDC4B0-0x0000000185FDC4D0
		public static double lengthsq(double3 x) => default; // 0x000000018BD5931C-0x000000018BD59354
		public static double lengthsq(double4 x) => default; // 0x000000018BD59388-0x000000018BD593BC
		public static float distance(float x, float y) => default; // 0x0000000185FDA8F0-0x0000000185FDA910
		public static float distance(float2 x, float2 y) => default; // 0x000000018BD4A064-0x000000018BD4A0A0
		public static float distance(float3 x, float3 y) => default; // 0x000000018BD49EF0-0x000000018BD49F58
		public static float distance(float4 x, float4 y) => default; // 0x000000018BD49FC4-0x000000018BD4A024
		public static double distance(double x, double y) => default; // 0x0000000185FDA910-0x0000000185FDA930
		public static double distance(double2 x, double2 y) => default; // 0x000000018BD4A024-0x000000018BD4A064
		public static double distance(double3 x, double3 y) => default; // 0x000000018BD49E7C-0x000000018BD49EF0
		public static double distance(double4 x, double4 y) => default; // 0x000000018BD49F58-0x000000018BD49FC4
		public static float distancesq(float x, float y) => default; // 0x0000000185FDA930-0x0000000185FDA940
		public static float distancesq(float2 x, float2 y) => default; // 0x000000018BD4A0A0-0x000000018BD4A0D8
		public static float distancesq(float3 x, float3 y) => default; // 0x000000018BD4A1FC-0x000000018BD4A260
		public static float distancesq(float4 x, float4 y) => default; // 0x000000018BD4A0D8-0x000000018BD4A124
		public static double distancesq(double x, double y) => default; // 0x0000000185FDA940-0x0000000185FDA950
		public static double distancesq(double2 x, double2 y) => default; // 0x000000018BD4A260-0x000000018BD4A2A0
		public static double distancesq(double3 x, double3 y) => default; // 0x000000018BD4A18C-0x000000018BD4A1FC
		public static double distancesq(double4 x, double4 y) => default; // 0x000000018BD4A124-0x000000018BD4A18C
		public static float3 cross(float3 x, float3 y) => default; // 0x000000018BD49A58-0x000000018BD49B40
		public static double3 cross(double3 x, double3 y) => default; // 0x000000018BD49B40-0x000000018BD49C58
		public static float smoothstep(float xMin, float xMax, float x) => default; // 0x000000018BD6EFC8-0x000000018BD6F014
		public static float2 smoothstep(float2 xMin, float2 xMax, float2 x) => default; // 0x000000018BD6F014-0x000000018BD6F0E4
		public static float3 smoothstep(float3 xMin, float3 xMax, float3 x) => default; // 0x0000000186F44244-0x0000000186F44BCC
		public static float4 smoothstep(float4 xMin, float4 xMax, float4 x) => default; // 0x000000018BD6F130-0x000000018BD6F278
		public static double smoothstep(double xMin, double xMax, double x) => default; // 0x000000018BD6F0E4-0x000000018BD6F130
		public static double2 smoothstep(double2 xMin, double2 xMax, double2 x) => default; // 0x000000018BD6EB58-0x000000018BD6EC68
		public static double3 smoothstep(double3 xMin, double3 xMax, double3 x) => default; // 0x000000018BD6EE08-0x000000018BD6EFC8
		public static double4 smoothstep(double4 xMin, double4 xMax, double4 x) => default; // 0x000000018BD6EC68-0x000000018BD6EE08
		public static bool any(bool2 x) => default; // 0x000000018BD47E28-0x000000018BD47E38
		public static bool any(bool3 x) => default; // 0x000000018BD47EE4-0x000000018BD47EF8
		public static bool any(bool4 x) => default; // 0x0000000186F16924-0x0000000186F16B70
		public static bool any(int2 x) => default; // 0x000000018BD47E14-0x000000018BD47E28
		public static bool any(int3 x) => default; // 0x000000018BD47E38-0x000000018BD47E50
		public static bool any(int4 x) => default; // 0x000000018BD47DF8-0x000000018BD47E14
		public static bool any(uint2 x) => default; // 0x000000018BD47E14-0x000000018BD47E28
		public static bool any(uint3 x) => default; // 0x000000018BD47E38-0x000000018BD47E50
		public static bool any(uint4 x) => default; // 0x000000018BD47DF8-0x000000018BD47E14
		public static bool any(float2 x) => default; // 0x000000018BD47EF8-0x000000018BD47F20
		public static bool any(float3 x) => default; // 0x000000018BD47E74-0x000000018BD47EA0
		public static bool any(float4 x) => default; // 0x000000018BD47F20-0x000000018BD47F58
		public static bool any(double2 x) => default; // 0x000000018BD47E50-0x000000018BD47E74
		public static bool any(double3 x) => default; // 0x000000018BD47F58-0x000000018BD47FA4
		public static bool any(double4 x) => default; // 0x000000018BD47EA0-0x000000018BD47EE4
		public static bool all(bool2 x) => default; // 0x000000018BD47BE8-0x000000018BD47BF8
		public static bool all(bool3 x) => default; // 0x000000018BD47D18-0x000000018BD47D2C
		public static bool all(bool4 x) => default; // 0x0000000186F16780-0x0000000186F167A0
		public static bool all(int2 x) => default; // 0x000000018BD47BF8-0x000000018BD47C0C
		public static bool all(int3 x) => default; // 0x0000000186F167A0-0x0000000186F167B8
		public static bool all(int4 x) => default; // 0x000000018BD47C9C-0x000000018BD47CB8
		public static bool all(uint2 x) => default; // 0x000000018BD47BF8-0x000000018BD47C0C
		public static bool all(uint3 x) => default; // 0x0000000186F167A0-0x0000000186F167B8
		public static bool all(uint4 x) => default; // 0x000000018BD47C9C-0x000000018BD47CB8
		public static bool all(float2 x) => default; // 0x000000018BD47CB8-0x000000018BD47CE0
		public static bool all(float3 x) => default; // 0x0000000186F167B8-0x0000000186F16924
		public static bool all(float4 x) => default; // 0x000000018BD47CE0-0x000000018BD47D18
		public static bool all(double2 x) => default; // 0x000000018BD47D2C-0x000000018BD47D50
		public static bool all(double3 x) => default; // 0x000000018BD47C50-0x000000018BD47C9C
		public static bool all(double4 x) => default; // 0x000000018BD47C0C-0x000000018BD47C50
		public static int select(int falseValue, int trueValue, bool test) => default; // 0x000000018BD6CD48-0x000000018BD6CD54
		public static int2 select(int2 falseValue, int2 trueValue, bool test) => default; // 0x000000018BD6CD60-0x000000018BD6CD6C
		public static int3 select(int3 falseValue, int3 trueValue, bool test) => default; // 0x000000018BD6CD84-0x000000018BD6CDA8
		public static int4 select(int4 falseValue, int4 trueValue, bool test) => default; // 0x000000018BD6CD6C-0x000000018BD6CD84
		public static int2 select(int2 falseValue, int2 trueValue, bool2 test) => default; // 0x000000018BD6CDA8-0x000000018BD6CDD8
		public static int3 select(int3 falseValue, int3 trueValue, bool3 test) => default; // 0x0000000186F40A54-0x0000000186F40A94
		public static int4 select(int4 falseValue, int4 trueValue, bool4 test) => default; // 0x0000000186F40BB8-0x0000000186F40D40
		public static uint select(uint falseValue, uint trueValue, bool test) => default; // 0x000000018BD6CD48-0x000000018BD6CD54
		public static uint2 select(uint2 falseValue, uint2 trueValue, bool test) => default; // 0x000000018BD6CD60-0x000000018BD6CD6C
		public static uint3 select(uint3 falseValue, uint3 trueValue, bool test) => default; // 0x000000018BD6CD84-0x000000018BD6CDA8
		public static uint4 select(uint4 falseValue, uint4 trueValue, bool test) => default; // 0x000000018BD6CD6C-0x000000018BD6CD84
		public static uint2 select(uint2 falseValue, uint2 trueValue, bool2 test) => default; // 0x000000018BD6CDA8-0x000000018BD6CDD8
		public static uint3 select(uint3 falseValue, uint3 trueValue, bool3 test) => default; // 0x0000000186F40A54-0x0000000186F40A94
		public static uint4 select(uint4 falseValue, uint4 trueValue, bool4 test) => default; // 0x0000000186F40BB8-0x0000000186F40D40
		public static long select(long falseValue, long trueValue, bool test) => default; // 0x000000018BD6CD3C-0x000000018BD6CD48
		public static ulong select(ulong falseValue, ulong trueValue, bool test) => default; // 0x000000018BD6CD3C-0x000000018BD6CD48
		public static float select(float falseValue, float trueValue, bool test) => default; // 0x000000018BD6CD54-0x000000018BD6CD60
		public static float2 select(float2 falseValue, float2 trueValue, bool test) => default; // 0x000000018BD6CD60-0x000000018BD6CD6C
		public static float3 select(float3 falseValue, float3 trueValue, bool test) => default; // 0x000000018BD6CD84-0x000000018BD6CDA8
		public static float4 select(float4 falseValue, float4 trueValue, bool test) => default; // 0x000000018BD6CD6C-0x000000018BD6CD84
		public static float2 select(float2 falseValue, float2 trueValue, bool2 test) => default; // 0x0000000186F40A94-0x0000000186F40AD8
		public static float3 select(float3 falseValue, float3 trueValue, bool3 test) => default; // 0x0000000186F40AD8-0x0000000186F40B4C
		public static float4 select(float4 falseValue, float4 trueValue, bool4 test) => default; // 0x0000000186F40B4C-0x0000000186F40BB8
		public static double select(double falseValue, double trueValue, bool test) => default; // 0x000000018BD6CD54-0x000000018BD6CD60
		public static double2 select(double2 falseValue, double2 trueValue, bool test) => default; // 0x000000018BD6CD6C-0x000000018BD6CD84
		public static double3 select(double3 falseValue, double3 trueValue, bool test) => default; // 0x000000018BD6CECC-0x000000018BD6CEF4
		public static double4 select(double4 falseValue, double4 trueValue, bool test) => default; // 0x000000018BD6CEF4-0x000000018BD6CF18
		public static double2 select(double2 falseValue, double2 trueValue, bool2 test) => default; // 0x0000000186F40A20-0x0000000186F40A54
		public static double3 select(double3 falseValue, double3 trueValue, bool3 test) => default; // 0x000000018BD6CE4C-0x000000018BD6CECC
		public static double4 select(double4 falseValue, double4 trueValue, bool4 test) => default; // 0x000000018BD6CDD8-0x000000018BD6CE4C
		public static float step(float threshold, float x) => default; // 0x000000018BD6F470-0x000000018BD6F484
		public static float2 step(float2 threshold, float2 x) => default; // 0x000000018BD6F7DC-0x000000018BD6F83C
		public static float3 step(float3 threshold, float3 x) => default; // 0x000000018BD6F68C-0x000000018BD6F738
		public static float4 step(float4 threshold, float4 x) => default; // 0x000000018BD6F498-0x000000018BD6F554
		public static double step(double threshold, double x) => default; // 0x000000018BD6F484-0x000000018BD6F498
		public static double2 step(double2 threshold, double2 x) => default; // 0x000000018BD6F618-0x000000018BD6F68C
		public static double3 step(double3 threshold, double3 x) => default; // 0x000000018BD6F554-0x000000018BD6F618
		public static double4 step(double4 threshold, double4 x) => default; // 0x000000018BD6F738-0x000000018BD6F7DC
		public static float2 reflect(float2 i, float2 n) => default; // 0x000000018BD6AAB8-0x000000018BD6AB10
		public static float3 reflect(float3 i, float3 n) => default; // 0x0000000186F3E760-0x0000000186F3EC34
		public static float4 reflect(float4 i, float4 n) => default; // 0x000000018BD6AD64-0x000000018BD6ADF8
		public static double2 reflect(double2 i, double2 n) => default; // 0x000000018BD6ACCC-0x000000018BD6AD64
		public static double3 reflect(double3 i, double3 n) => default; // 0x000000018BD6ABE8-0x000000018BD6ACCC
		public static double4 reflect(double4 i, double4 n) => default; // 0x000000018BD6AB10-0x000000018BD6ABE8
		public static float2 refract(float2 i, float2 n, float indexOfRefraction) => default; // 0x000000018BD6AF50-0x000000018BD6B054
		public static float3 refract(float3 i, float3 n, float indexOfRefraction) => default; // 0x0000000186F3EC34-0x0000000186F3F324
		public static float4 refract(float4 i, float4 n, float indexOfRefraction) => default; // 0x000000018BD6B318-0x000000018BD6B434
		public static double2 refract(double2 i, double2 n, double indexOfRefraction) => default; // 0x000000018BD6B054-0x000000018BD6B168
		public static double3 refract(double3 i, double3 n, double indexOfRefraction) => default; // 0x000000018BD6B168-0x000000018BD6B318
		public static double4 refract(double4 i, double4 n, double indexOfRefraction) => default; // 0x000000018BD6ADF8-0x000000018BD6AF50
		public static float2 project(float2 a, float2 ontoB) => default; // 0x000000018BD6A01C-0x000000018BD6A068
		public static float3 project(float3 a, float3 ontoB) => default; // 0x0000000186F3DC74-0x0000000186F3DF34
		public static float4 project(float4 a, float4 ontoB) => default; // 0x000000018BD6A1B4-0x000000018BD6A224
		public static float2 projectsafe(float2 a, float2 ontoB, float2 defaultValue = default) => default; // 0x000000018BD6A28C-0x000000018BD6A32C
		public static float3 projectsafe(float3 a, float3 ontoB, float3 defaultValue = default) => default; // 0x0000000186F3DF34-0x0000000186F3E760
		public static float4 projectsafe(float4 a, float4 ontoB, float4 defaultValue = default) => default; // 0x000000018BD6A224-0x000000018BD6A28C
		public static double2 project(double2 a, double2 ontoB) => default; // 0x0000000186F3DC00-0x0000000186F3DC74
		public static double3 project(double3 a, double3 ontoB) => default; // 0x000000018BD6A108-0x000000018BD6A1B4
		public static double4 project(double4 a, double4 ontoB) => default; // 0x000000018BD6A068-0x000000018BD6A108
		public static double2 projectsafe(double2 a, double2 ontoB, double2 defaultValue = default) => default; // 0x000000018BD6A3C8-0x000000018BD6A42C
		public static double3 projectsafe(double3 a, double3 ontoB, double3 defaultValue = default) => default; // 0x000000018BD6A42C-0x000000018BD6A510
		public static double4 projectsafe(double4 a, double4 ontoB, double4 defaultValue = default) => default; // 0x000000018BD6A32C-0x000000018BD6A3C8
		public static float2 faceforward(float2 n, float2 i, float2 ng) => default; // 0x000000018BD4C7A8-0x000000018BD4C800
		public static float3 faceforward(float3 n, float3 i, float3 ng) => default; // 0x0000000186F1BA0C-0x0000000186F1BB2C
		public static float4 faceforward(float4 n, float4 i, float4 ng) => default; // 0x000000018BD4C6CC-0x000000018BD4C734
		public static double2 faceforward(double2 n, double2 i, double2 ng) => default; // 0x000000018BD4C734-0x000000018BD4C7A8
		public static double3 faceforward(double3 n, double3 i, double3 ng) => default; // 0x000000018BD4C800-0x000000018BD4C8C4
		public static double4 faceforward(double4 n, double4 i, double4 ng) => default; // 0x000000018BD4C8C4-0x000000018BD4C958
		public static void sincos(float x, out float s, out float c) {
			s = default;
			c = default;
		} // 0x0000000185FDDAF0-0x0000000185FDDB30
		public static void sincos(float2 x, out float2 s, out float2 c) {
			s = default;
			c = default;
		} // 0x000000018BD6E8CC-0x000000018BD6E910
		public static void sincos(float3 x, out float3 s, out float3 c) {
			s = default;
			c = default;
		} // 0x000000018BD6E6EC-0x000000018BD6E770
		public static void sincos(float4 x, out float4 s, out float4 c) {
			s = default;
			c = default;
		} // 0x000000018BD6E770-0x000000018BD6E7D8
		public static void sincos(double x, out double s, out double c) {
			s = default;
			c = default;
		} // 0x0000000185FDDAB0-0x0000000185FDDAF0
		public static void sincos(double2 x, out double2 s, out double2 c) {
			s = default;
			c = default;
		} // 0x000000018BD6E7D8-0x000000018BD6E840
		public static void sincos(double3 x, out double3 s, out double3 c) {
			s = default;
			c = default;
		} // 0x000000018BD6E840-0x000000018BD6E8CC
		public static void sincos(double4 x, out double4 s, out double4 c) {
			s = default;
			c = default;
		} // 0x000000018BD6E668-0x000000018BD6E6EC
		public static int countbits(int x) => default; // 0x0000000185FD9E80-0x0000000185FD9EC0
		public static int2 countbits(int2 x) => default; // 0x000000018BD496F4-0x000000018BD4970C
		public static int3 countbits(int3 x) => default; // 0x000000018BD499F8-0x000000018BD49A58
		public static int4 countbits(int4 x) => default; // 0x000000018BD49998-0x000000018BD499F8
		public static int countbits(uint x) => default; // 0x0000000185FD9E80-0x0000000185FD9EC0
		public static int2 countbits(uint2 x) => default; // 0x000000018BD4970C-0x000000018BD49808
		public static int3 countbits(uint3 x) => default; // 0x0000000186F18804-0x0000000186F18F54
		public static int4 countbits(uint4 x) => default; // 0x000000018BD49808-0x000000018BD49998
		public static int countbits(ulong x) => default; // 0x0000000185FD9E20-0x0000000185FD9E80
		public static int countbits(long x) => default; // 0x0000000185FD9E20-0x0000000185FD9E80
		public static int lzcnt(int x) => default; // 0x000000018BD59D74-0x000000018BD59D7C
		public static int2 lzcnt(int2 x) => default; // 0x000000018BD59D40-0x000000018BD59D6C
		public static int3 lzcnt(int3 x) => default; // 0x000000018BD59C70-0x000000018BD59CB0
		public static int4 lzcnt(int4 x) => default; // 0x000000018BD59CF4-0x000000018BD59D40
		public static int lzcnt(uint x) => default; // 0x000000018BD59CB0-0x000000018BD59CF4
		public static int2 lzcnt(uint2 x) => default; // 0x000000018BD59D40-0x000000018BD59D6C
		public static int3 lzcnt(uint3 x) => default; // 0x000000018BD59C70-0x000000018BD59CB0
		public static int4 lzcnt(uint4 x) => default; // 0x000000018BD59CF4-0x000000018BD59D40
		public static int lzcnt(long x) => default; // 0x000000018BD59D6C-0x000000018BD59D74
		public static int lzcnt(ulong x) => default; // 0x000000018BD59D7C-0x000000018BD59DD4
		public static int tzcnt(int x) => default; // 0x000000018BD711C0-0x000000018BD711C8
		public static int2 tzcnt(int2 x) => default; // 0x000000018BD71140-0x000000018BD7116C
		public static int3 tzcnt(int3 x) => default; // 0x000000018BD710FC-0x000000018BD71140
		public static int4 tzcnt(int4 x) => default; // 0x000000018BD7116C-0x000000018BD711C0
		public static int tzcnt(uint x) => default; // 0x000000018BD710B4-0x000000018BD710FC
		public static int2 tzcnt(uint2 x) => default; // 0x000000018BD71140-0x000000018BD7116C
		public static int3 tzcnt(uint3 x) => default; // 0x000000018BD710FC-0x000000018BD71140
		public static int4 tzcnt(uint4 x) => default; // 0x000000018BD7116C-0x000000018BD711C0
		public static int tzcnt(long x) => default; // 0x000000018BD711C8-0x000000018BD711D0
		public static int tzcnt(ulong x) => default; // 0x000000018BD711D0-0x000000018BD71234
		public static int reversebits(int x) => default; // 0x000000018BD6BCB4-0x000000018BD6BCBC
		public static int2 reversebits(int2 x) => default; // 0x000000018BD6BCBC-0x000000018BD6BCEC
		public static int3 reversebits(int3 x) => default; // 0x000000018BD6BCEC-0x000000018BD6BD6C
		public static int4 reversebits(int4 x) => default; // 0x000000018BD6BA8C-0x000000018BD6BB00
		public static uint reversebits(uint x) => default; // 0x0000000185FDD820-0x0000000185FDD860
		public static uint2 reversebits(uint2 x) => default; // 0x000000018BD6BB00-0x000000018BD6BCAC
		public static uint3 reversebits(uint3 x) => default; // 0x0000000186F3F6A0-0x0000000186F3FC4C
		public static uint4 reversebits(uint4 x) => default; // 0x000000018BD6B7D4-0x000000018BD6BA8C
		public static long reversebits(long x) => default; // 0x000000018BD6BCAC-0x000000018BD6BCB4
		public static ulong reversebits(ulong x) => default; // 0x0000000185FDD860-0x0000000185FDD8C0
		public static int rol(int x, int n) => default; // 0x0000000185FB21D0-0x0000000185FB21F0
		public static int2 rol(int2 x, int n) => default; // 0x000000018BD6BF0C-0x000000018BD6BF7C
		public static int3 rol(int3 x, int n) => default; // 0x000000018BD6BDA0-0x000000018BD6BE20
		public static int4 rol(int4 x, int n) => default; // 0x000000018BD6BE20-0x000000018BD6BE94
		public static uint rol(uint x, int n) => default; // 0x0000000185FB21D0-0x0000000185FB21F0
		public static uint2 rol(uint2 x, int n) => default; // 0x000000018BD6BD6C-0x000000018BD6BDA0
		public static uint3 rol(uint3 x, int n) => default; // 0x0000000186F3FC4C-0x0000000186F3FCE0
		public static uint4 rol(uint4 x, int n) => default; // 0x000000018BD6BE94-0x000000018BD6BF0C
		public static long rol(long x, int n) => default; // 0x0000000185FD7580-0x0000000185FD75A0
		public static ulong rol(ulong x, int n) => default; // 0x0000000185FD7580-0x0000000185FD75A0
		public static int ror(int x, int n) => default; // 0x0000000185FCF9C0-0x0000000185FCF9E0
		public static int2 ror(int2 x, int n) => default; // 0x000000018BD6C024-0x000000018BD6C094
		public static int3 ror(int3 x, int n) => default; // 0x000000018BD6C094-0x000000018BD6C114
		public static int4 ror(int4 x, int n) => default; // 0x000000018BD6BFB0-0x000000018BD6C024
		public static uint ror(uint x, int n) => default; // 0x0000000185FCF9C0-0x0000000185FCF9E0
		public static uint2 ror(uint2 x, int n) => default; // 0x000000018BD6BF7C-0x000000018BD6BFB0
		public static uint3 ror(uint3 x, int n) => default; // 0x0000000186F3FCE0-0x0000000186F4024C
		public static uint4 ror(uint4 x, int n) => default; // 0x000000018BD6C114-0x000000018BD6C18C
		public static long ror(long x, int n) => default; // 0x0000000185FCFA10-0x0000000185FCFA30
		public static ulong ror(ulong x, int n) => default; // 0x0000000185FCFA10-0x0000000185FCFA30
		public static int ceilpow2(int x) => default; // 0x00000001844DB670-0x00000001844DB6A0
		public static int2 ceilpow2(int2 x) => default; // 0x000000018BD4879C-0x000000018BD48854
		public static int3 ceilpow2(int3 x) => default; // 0x0000000186F17828-0x0000000186F17D5C
		public static int4 ceilpow2(int4 x) => default; // 0x000000018BD48A9C-0x000000018BD48C2C
		public static uint ceilpow2(uint x) => default; // 0x0000000185FB33E0-0x0000000185FB3410
		public static uint2 ceilpow2(uint2 x) => default; // 0x000000018BD489E4-0x000000018BD48A9C
		public static uint3 ceilpow2(uint3 x) => default; // 0x0000000186F17614-0x0000000186F17828
		public static uint4 ceilpow2(uint4 x) => default; // 0x000000018BD48854-0x000000018BD489E4
		public static long ceilpow2(long x) => default; // 0x0000000185FD99F0-0x0000000185FD9A40
		public static ulong ceilpow2(ulong x) => default; // 0x0000000185FD99A0-0x0000000185FD99F0
		public static int ceillog2(int x) => default; // 0x0000000186F175F8-0x0000000186F17614
		public static int2 ceillog2(int2 x) => default; // 0x000000018BD48770-0x000000018BD4879C
		public static int3 ceillog2(int3 x) => default; // 0x000000018BD486F0-0x000000018BD48728
		public static int4 ceillog2(int4 x) => default; // 0x000000018BD48728-0x000000018BD48770
		public static int ceillog2(uint x) => default; // 0x0000000186F175F8-0x0000000186F17614
		public static int2 ceillog2(uint2 x) => default; // 0x000000018BD48770-0x000000018BD4879C
		public static int3 ceillog2(uint3 x) => default; // 0x000000018BD486F0-0x000000018BD48728
		public static int4 ceillog2(uint4 x) => default; // 0x000000018BD48728-0x000000018BD48770
		public static int floorlog2(int x) => default; // 0x0000000186F1C644-0x0000000186F1CA94
		public static int2 floorlog2(int2 x) => default; // 0x000000018BD4ECF8-0x000000018BD4ED2C
		public static int3 floorlog2(int3 x) => default; // 0x000000018BD4ECC0-0x000000018BD4ECF8
		public static int4 floorlog2(int4 x) => default; // 0x000000018BD4EC78-0x000000018BD4ECC0
		public static int floorlog2(uint x) => default; // 0x0000000186F1C644-0x0000000186F1CA94
		public static int2 floorlog2(uint2 x) => default; // 0x000000018BD4ECF8-0x000000018BD4ED2C
		public static int3 floorlog2(uint3 x) => default; // 0x000000018BD4ECC0-0x000000018BD4ECF8
		public static int4 floorlog2(uint4 x) => default; // 0x000000018BD4EC78-0x000000018BD4ECC0
		public static float radians(float x) => default; // 0x0000000185FDD800-0x0000000185FDD810
		public static float2 radians(float2 x) => default; // 0x000000018BD6A840-0x000000018BD6A850
		public static float3 radians(float3 x) => default; // 0x000000018646DE4C-0x000000018646DE94
		public static float4 radians(float4 x) => default; // 0x000000018BD6A808-0x000000018BD6A840
		public static double radians(double x) => default; // 0x0000000185FDD810-0x0000000185FDD820
		public static double2 radians(double2 x) => default; // 0x000000018BD6A850-0x000000018BD6A888
		public static double3 radians(double3 x) => default; // 0x000000018BD6A888-0x000000018BD6A8D4
		public static double4 radians(double4 x) => default; // 0x000000018BD6A8D4-0x000000018BD6A91C
		public static float degrees(float x) => default; // 0x0000000185FD9F70-0x0000000185FD9F80
		public static float2 degrees(float2 x) => default; // 0x000000018BD49DFC-0x000000018BD49E0C
		public static float3 degrees(float3 x) => default; // 0x0000000186F18F54-0x0000000186F194A4
		public static float4 degrees(float4 x) => default; // 0x000000018BD49E0C-0x000000018BD49E44
		public static double degrees(double x) => default; // 0x0000000185FD9F80-0x0000000185FD9F90
		public static double2 degrees(double2 x) => default; // 0x000000018BD49E44-0x000000018BD49E7C
		public static double3 degrees(double3 x) => default; // 0x000000018BD49D68-0x000000018BD49DB4
		public static double4 degrees(double4 x) => default; // 0x000000018BD49DB4-0x000000018BD49DFC
		public static int cmin(int2 x) => default; // 0x000000018BD494E8-0x000000018BD494FC
		public static int cmin(int3 x) => default; // 0x000000018BD493C0-0x000000018BD493D4
		public static int cmin(int4 x) => default; // 0x000000018BD49440-0x000000018BD4945C
		public static uint cmin(uint2 x) => default; // 0x000000018BD4947C-0x000000018BD49490
		public static uint cmin(uint3 x) => default; // 0x000000018BD49534-0x000000018BD49548
		public static uint cmin(uint4 x) => default; // 0x000000018BD493D4-0x000000018BD493F0
		public static float cmin(float2 x) => default; // 0x000000018BD494C4-0x000000018BD494E8
		public static float cmin(float3 x) => default; // 0x000000018BD49490-0x000000018BD494C4
		public static float cmin(float4 x) => default; // 0x0000000186F18528-0x0000000186F18804
		public static double cmin(double2 x) => default; // 0x000000018BD4945C-0x000000018BD4947C
		public static double cmin(double3 x) => default; // 0x000000018BD494FC-0x000000018BD49534
		public static double cmin(double4 x) => default; // 0x000000018BD493F0-0x000000018BD49440
		public static int cmax(int2 x) => default; // 0x000000018BD49340-0x000000018BD49354
		public static int cmax(int3 x) => default; // 0x000000018BD49374-0x000000018BD49388
		public static int cmax(int4 x) => default; // 0x000000018BD492A4-0x000000018BD492C0
		public static uint cmax(uint2 x) => default; // 0x000000018BD4926C-0x000000018BD49280
		public static uint cmax(uint3 x) => default; // 0x000000018BD4932C-0x000000018BD49340
		public static uint cmax(uint4 x) => default; // 0x000000018BD492C0-0x000000018BD492DC
		public static float cmax(float2 x) => default; // 0x000000018BD49280-0x000000018BD492A4
		public static float cmax(float3 x) => default; // 0x000000018BD49238-0x000000018BD4926C
		public static float cmax(float4 x) => default; // 0x0000000186F183B8-0x0000000186F18528
		public static double cmax(double2 x) => default; // 0x000000018BD49354-0x000000018BD49374
		public static double cmax(double3 x) => default; // 0x000000018BD49388-0x000000018BD493C0
		public static double cmax(double4 x) => default; // 0x000000018BD492DC-0x000000018BD4932C
		public static int csum(int2 x) => default; // 0x0000000185FD9EE0-0x0000000185FD9EF0
		public static int csum(int3 x) => default; // 0x0000000185FD9F30-0x0000000185FD9F40
		public static int csum(int4 x) => default; // 0x0000000185FB6950-0x0000000185FB6960
		public static uint csum(uint2 x) => default; // 0x0000000185FD9EE0-0x0000000185FD9EF0
		public static uint csum(uint3 x) => default; // 0x0000000185FD9F30-0x0000000185FD9F40
		public static uint csum(uint4 x) => default; // 0x0000000185FB6950-0x0000000185FB6960
		public static float csum(float2 x) => default; // 0x0000000185FD9F40-0x0000000185FD9F60
		public static float csum(float3 x) => default; // 0x0000000185FD9F60-0x0000000185FD9F70
		public static float csum(float4 x) => default; // 0x0000000185FD9EC0-0x0000000185FD9EE0
		public static double csum(double2 x) => default; // 0x0000000185FD9F00-0x0000000185FD9F10
		public static double csum(double3 x) => default; // 0x0000000185FD9EF0-0x0000000185FD9F00
		public static double csum(double4 x) => default; // 0x0000000185FD9F10-0x0000000185FD9F30
		public static float square(float x) => default; // 0x0000000185FB2920-0x0000000185FB2930
		public static float2 square(float2 x) => default; // 0x000000018BD6F468-0x000000018BD6F470
		public static float3 square(float3 x) => default; // 0x0000000186F44BCC-0x0000000186F44C1C
		public static float4 square(float4 x) => default; // 0x000000018BD6F398-0x000000018BD6F3D0
		public static double square(double x) => default; // 0x0000000185FDC4D0-0x0000000185FDC4E0
		public static double2 square(double2 x) => default; // 0x000000018BD6F360-0x000000018BD6F398
		public static double3 square(double3 x) => default; // 0x000000018BD6F3D8-0x000000018BD6F430
		public static double4 square(double4 x) => default; // 0x000000018BD6F310-0x000000018BD6F360
		public static int square(int x) => default; // 0x0000000185FDE0A0-0x0000000185FDE0B0
		public static int2 square(int2 x) => default; // 0x000000018BD6F3D0-0x000000018BD6F3D8
		public static int3 square(int3 x) => default; // 0x0000000186F44C1C-0x0000000186F44FC8
		public static int4 square(int4 x) => default; // 0x000000018BD6F430-0x000000018BD6F468
		public static uint square(uint x) => default; // 0x0000000185FDE0A0-0x0000000185FDE0B0
		public static uint2 square(uint2 x) => default; // 0x000000018BD6F3D0-0x000000018BD6F3D8
		public static uint3 square(uint3 x) => default; // 0x0000000186F44C1C-0x0000000186F44FC8
		public static uint4 square(uint4 x) => default; // 0x000000018BD6F430-0x000000018BD6F468
		public static unsafe int compress(int* output, int index, int4 val, bool4 mask) => default; // 0x000000018BD45CE4-0x000000018BD45E84
		public static unsafe int compress(uint* output, int index, uint4 val, bool4 mask) => default; // 0x000000018BD49548-0x000000018BD49564
		public static unsafe int compress(float* output, int index, float4 val, bool4 mask) => default; // 0x000000018BD49548-0x000000018BD49564
		public static float f16tof32(uint x) => default; // 0x0000000186F1AAC4-0x0000000186F1BA0C
		public static float2 f16tof32(uint2 x) => default; // 0x000000018BD4BC00-0x000000018BD4BD54
		public static float3 f16tof32(uint3 x) => default; // 0x000000018BD4B93C-0x000000018BD4BC00
		public static float4 f16tof32(uint4 x) => default; // 0x000000018BD4BD54-0x000000018BD4BF80
		public static uint f32tof16(float x) => default; // 0x000000018BD4C404-0x000000018BD4C460
		public static uint2 f32tof16(float2 x) => default; // 0x000000018BD4BF80-0x000000018BD4C10C
		public static uint3 f32tof16(float3 x) => default; // 0x000000018BD4C10C-0x000000018BD4C404
		public static uint4 f32tof16(float4 x) => default; // 0x000000018BD4C460-0x000000018BD4C6CC
		public static void orthonormal_basis(float3 normal, out float3 basis1, out float3 basis2) {
			basis1 = default;
			basis2 = default;
		} // 0x000000018BD69A18-0x000000018BD69ABC
		public static void orthonormal_basis(double3 normal, out double3 basis1, out double3 basis2) {
			basis1 = default;
			basis2 = default;
		} // 0x000000018BD69ABC-0x000000018BD69B90
		public static float chgsign(float x, float y) => default; // 0x0000000185FD9A40-0x0000000185FD9A60
		public static float2 chgsign(float2 x, float2 y) => default; // 0x000000018BD48C2C-0x000000018BD48C70
		public static float3 chgsign(float3 x, float3 y) => default; // 0x0000000186F17D5C-0x0000000186F17F28
		public static float4 chgsign(float4 x, float4 y) => default; // 0x000000018BD48C70-0x000000018BD48CD0
		private static unsafe uint read32_little_endian(void* pBuffer) => default; // 0x0000000185FCFB40-0x0000000185FCFB60
		private static unsafe uint hash_with_unaligned_loads(void* pBuffer, int numBytes, uint seed) => default; // 0x000000018BD521E8-0x000000018BD52404
		private static unsafe uint hash_without_unaligned_loads(void* pBuffer, int numBytes, uint seed) => default; // 0x000000018BD52404-0x000000018BD526A4
		public static unsafe uint hash(void* pBuffer, int numBytes, uint seed = 0 /* Metadata: 0x0207B86C */) => default; // 0x000000018BD51080-0x000000018BD51088
		public static float3 up() => default; // 0x0000000185FDE0B0-0x0000000185FDE0C0
		public static float3 down() => default; // 0x0000000185FDB190-0x0000000185FDB1B0
		public static float3 forward() => default; // 0x0000000185FDBF10-0x0000000185FDBF20
		public static float3 back() => default; // 0x0000000185FD9440-0x0000000185FD9450
		public static float3 left() => default; // 0x0000000185FDC460-0x0000000185FDC470
		public static float3 right() => default; // 0x0000000185FDD8C0-0x0000000185FDD8D0
		public static float3 EulerXYZ(quaternion q) => default; // 0x000000018BD46150-0x000000018BD464D4
		public static float3 EulerXZY(quaternion q) => default; // 0x000000018BD464D4-0x000000018BD4682C
		public static float3 EulerYXZ(quaternion q) => default; // 0x000000018BD4682C-0x000000018BD46B80
		public static float3 EulerYZX(quaternion q) => default; // 0x000000018BD46B80-0x000000018BD46EBC
		public static float3 EulerZXY(quaternion q) => default; // 0x000000018BD46EBC-0x000000018BD471F4
		public static float3 EulerZYX(quaternion q) => default; // 0x000000018BD471F4-0x000000018BD4754C
		public static float3 Euler(quaternion q, RotationOrder order = RotationOrder.ZXY /* Metadata: 0x0207B86D */) => default; // 0x000000018BD4754C-0x000000018BD47678
		public static float3x3 mulScale(float3x3 m, float3 s) => default; // 0x000000018BD5AB34-0x000000018BD5ABFC
		public static float3x3 scaleMul(float3 s, float3x3 m) => default; // 0x000000018BD6CC44-0x000000018BD6CD3C
		internal static float4 unpacklo(float4 a, float4 b) => default; // 0x000000018BD720A0-0x000000018BD720EC
		internal static double4 unpacklo(double4 a, double4 b) => default; // 0x000000018BD720EC-0x000000018BD727C8
		internal static float4 unpackhi(float4 a, float4 b) => default; // 0x000000018BD45E84-0x000000018BD45F88
		internal static double4 unpackhi(double4 a, double4 b) => default; // 0x000000018BD72034-0x000000018BD720A0
		internal static float4 movelh(float4 a, float4 b) => default; // 0x000000018BD5AA7C-0x000000018BD5AAC8
		internal static double4 movelh(double4 a, double4 b) => default; // 0x000000018BD5AAC8-0x000000018BD5AB34
		internal static float4 movehl(float4 a, float4 b) => default; // 0x000000018BD5A9C4-0x000000018BD5AA10
		internal static double4 movehl(double4 a, double4 b) => default; // 0x000000018BD5AA10-0x000000018BD5AA7C
		internal static uint fold_to_uint(double x) => default; // 0x0000000185FDBEF0-0x0000000185FDBF10
		internal static uint2 fold_to_uint(double2 x) => default; // 0x0000000185FDBDB0-0x0000000185FDBDF0
		internal static uint3 fold_to_uint(double3 x) => default; // 0x0000000185FDBE80-0x0000000185FDBEF0
		internal static uint4 fold_to_uint(double4 x) => default; // 0x0000000185FDBDF0-0x0000000185FDBE80
		public static float3x3 float3x3(float4x4 f4x4) => default; // 0x000000018BD4DDE8-0x000000018BD4DE3C
		public static float3x3 float3x3(quaternion rotation) => default; // 0x000000018BD4DE5C-0x000000018BD4DE94
		public static float4x4 float4x4(float3x3 rotation, float3 translation) => default; // 0x000000018BD4EA74-0x000000018BD4EAE8
		public static float4x4 float4x4(quaternion rotation, float3 translation) => default; // 0x000000018BD4EB30-0x000000018BD4EB98
		public static float4x4 float4x4(RigidTransform transform) => default; // 0x000000018BD4E83C-0x000000018BD4E890
		public static float3x3 orthonormalize(float3x3 i) => default; // 0x000000018BD69B90-0x000000018BD69DE8
		public static float3x3 pseudoinverse(float3x3 m) => default; // 0x000000018BD6A510-0x000000018BD6A780
		public static float mul(float a, float b) => default; // 0x0000000185FDAA00-0x0000000185FDAA10
		public static float mul(float2 a, float2 b) => default; // 0x0000000185FB5600-0x0000000185FB5630
		public static float2 mul(float2 a, float2x2 b) => default; // 0x0000000185FDCD50-0x0000000185FDCD90
		public static float3 mul(float2 a, float2x3 b) => default; // 0x0000000185FDD450-0x0000000185FDD4B0
		public static float4 mul(float2 a, float2x4 b) => default; // 0x0000000185FDD4F0-0x0000000185FDD580
		public static float mul(float3 a, float3 b) => default; // 0x0000000185FB5780-0x0000000185FB57B0
		public static float2 mul(float3 a, float3x2 b) => default; // 0x0000000185FDCEE0-0x0000000185FDCF40
		public static float3 mul(float3 a, float3x3 b) => default; // 0x0000000185FDCE50-0x0000000185FDCEE0
		public static float4 mul(float3 a, float3x4 b) => default; // 0x0000000185FDD280-0x0000000185FDD350
		public static float mul(float4 a, float4 b) => default; // 0x00000001845B93F0-0x00000001845B9430
		public static float2 mul(float4 a, float4x2 b) => default; // 0x0000000185FDD3E0-0x0000000185FDD450
		public static float3 mul(float4 a, float4x3 b) => default; // 0x0000000185FDC9B0-0x0000000185FDCA70
		public static float4 mul(float4 a, float4x4 b) => default; // 0x0000000185FDD600-0x0000000185FDD710
		public static float2 mul(float2x2 a, float2 b) => default; // 0x000000018BD5C1E0-0x000000018BD5C230
		public static float2x2 mul(float2x2 a, float2x2 b) => default; // 0x000000018BD656E8-0x000000018BD657BC
		public static float2x3 mul(float2x2 a, float2x3 b) => default; // 0x000000018BD664F4-0x000000018BD66620
		public static float2x4 mul(float2x2 a, float2x4 b) => default; // 0x000000018BD5ABFC-0x000000018BD5AD80
		public static float2 mul(float2x3 a, float3 b) => default; // 0x000000018BD5CD9C-0x000000018BD5CE18
		public static float2x2 mul(float2x3 a, float3x2 b) => default; // 0x000000018BD5D438-0x000000018BD5D56C
		public static float2x3 mul(float2x3 a, float3x3 b) => default; // 0x000000018BD639D8-0x000000018BD63B94
		public static float2x4 mul(float2x3 a, float3x4 b) => default; // 0x000000018BD5BDC0-0x000000018BD5C008
		public static float2 mul(float2x4 a, float4 b) => default; // 0x000000018BD64F20-0x000000018BD64FCC
		public static float2x2 mul(float2x4 a, float4x2 b) => default; // 0x000000018BD5AD80-0x000000018BD5AF18
		public static float2x3 mul(float2x4 a, float4x3 b) => default; // 0x000000018BD636A4-0x000000018BD638F4
		public static float2x4 mul(float2x4 a, float4x4 b) => default; // 0x000000018BD63ED8-0x000000018BD641E4
		public static float3 mul(float3x2 a, float2 b) => default; // 0x000000018BD5E6C0-0x000000018BD5E75C
		public static float3x2 mul(float3x2 a, float2x2 b) => default; // 0x000000018BD65348-0x000000018BD65494
		public static float3x3 mul(float3x2 a, float2x3 b) => default; // 0x000000018BD68664-0x000000018BD68840
		public static float3x4 mul(float3x2 a, float2x4 b) => default; // 0x000000018BD5AF18-0x000000018BD5B188
		public static float3 mul(float3x3 a, float3 b) => default; // 0x000000018BD5F178-0x000000018BD5F268
		public static float3x2 mul(float3x3 a, float3x2 b) => default; // 0x000000018BD67018-0x000000018BD67214
		public static float3x3 mul(float3x3 a, float3x3 b) => default; // 0x000000018BD5B554-0x000000018BD5B830
		public static float3x4 mul(float3x3 a, float3x4 b) => default; // 0x000000018BD61F28-0x000000018BD622EC
		public static float3 mul(float3x4 a, float4 b) => default; // 0x000000018BD616D8-0x000000018BD61820
		public static float3x2 mul(float3x4 a, float4x2 b) => default; // 0x000000018BD68248-0x000000018BD684EC
		public static float3x3 mul(float3x4 a, float4x3 b) => default; // 0x000000018BD6101C-0x000000018BD613F4
		public static float3x4 mul(float3x4 a, float4x4 b) => default; // 0x000000018BD5C444-0x000000018BD5C9D0
		public static float4 mul(float4x2 a, float2 b) => default; // 0x000000018BD62CEC-0x000000018BD62D6C
		public static float4x2 mul(float4x2 a, float2x2 b) => default; // 0x000000018BD638F4-0x000000018BD639D8
		public static float4x3 mul(float4x2 a, float2x3 b) => default; // 0x000000018BD604A4-0x000000018BD60618
		public static float4x4 mul(float4x2 a, float2x4 b) => default; // 0x000000018BD62450-0x000000018BD62638
		public static float4 mul(float4x3 a, float3 b) => default; // 0x000000018BD65B9C-0x000000018BD65C54
		public static float4x2 mul(float4x3 a, float3x2 b) => default; // 0x000000018BD65D08-0x000000018BD65E70
		public static float4x3 mul(float4x3 a, float3x3 b) => default; // 0x000000018BD64A08-0x000000018BD64C38
		public static float4x4 mul(float4x3 a, float3x4 b) => default; // 0x000000018BD661D4-0x000000018BD664F4
		public static float4 mul(float4x4 a, float4 b) => default; // 0x000000018BD5B188-0x000000018BD5B280
		public static float4x2 mul(float4x4 a, float4x2 b) => default; // 0x000000018BD5DC30-0x000000018BD5DE14
		public static float4x3 mul(float4x4 a, float4x3 b) => default; // 0x000000018BD64C38-0x000000018BD64F20
		public static float4x4 mul(float4x4 a, float4x4 b) => default; // 0x000000018BD68840-0x000000018BD68C70
		public static double mul(double a, double b) => default; // 0x0000000185FDA9D0-0x0000000185FDA9E0
		public static double mul(double2 a, double2 b) => default; // 0x0000000185FDAA40-0x0000000185FDAA60
		public static double2 mul(double2 a, double2x2 b) => default; // 0x0000000185FDD4B0-0x0000000185FDD4F0
		public static double3 mul(double2 a, double2x3 b) => default; // 0x0000000185FDCF40-0x0000000185FDCFB0
		public static double4 mul(double2 a, double2x4 b) => default; // 0x0000000185FDD010-0x0000000185FDD090
		public static double mul(double3 a, double3 b) => default; // 0x0000000185FDAA10-0x0000000185FDAA40
		public static double2 mul(double3 a, double3x2 b) => default; // 0x0000000185FDCFB0-0x0000000185FDD010
		public static double3 mul(double3 a, double3x3 b) => default; // 0x0000000185FDD090-0x0000000185FDD120
		public static double4 mul(double3 a, double3x4 b) => default; // 0x0000000185FDCD90-0x0000000185FDCE50
		public static double mul(double4 a, double4 b) => default; // 0x0000000185FDA960-0x0000000185FDA9A0
		public static double2 mul(double4 a, double4x2 b) => default; // 0x0000000185FDD120-0x0000000185FDD1A0
		public static double3 mul(double4 a, double4x3 b) => default; // 0x0000000185FDCB10-0x0000000185FDCBD0
		public static double4 mul(double4 a, double4x4 b) => default; // 0x0000000185FDD710-0x0000000185FDD800
		public static double2 mul(double2x2 a, double2 b) => default; // 0x000000018BD62E7C-0x000000018BD62EF4
		public static double2x2 mul(double2x2 a, double2x2 b) => default; // 0x000000018BD61820-0x000000018BD618FC
		public static double2x3 mul(double2x2 a, double2x3 b) => default; // 0x000000018BD63B94-0x000000018BD63D08
		public static double2x4 mul(double2x2 a, double2x4 b) => default; // 0x000000018BD632A0-0x000000018BD63488
		public static double2 mul(double2x3 a, double3 b) => default; // 0x000000018BD5B280-0x000000018BD5B338
		public static double2x2 mul(double2x3 a, double3x2 b) => default; // 0x000000018BD622EC-0x000000018BD62450
		public static double2x3 mul(double2x3 a, double3x3 b) => default; // 0x000000018BD66A30-0x000000018BD66C60
		public static double2x4 mul(double2x3 a, double3x4 b) => default; // 0x000000018BD64464-0x000000018BD64784
		public static double2 mul(double2x4 a, double4 b) => default; // 0x000000018BD679A8-0x000000018BD67AA0
		public static double2x2 mul(double2x4 a, double4x2 b) => default; // 0x000000018BD5CBBC-0x000000018BD5CD9C
		public static double2x3 mul(double2x4 a, double4x3 b) => default; // 0x000000018BD66D30-0x000000018BD67018
		public static double2x4 mul(double2x4 a, double4x4 b) => default; // 0x000000018BD5D008-0x000000018BD5D438
		public static double3 mul(double3x2 a, double2 b) => default; // 0x000000018BD61CA4-0x000000018BD61D58
		public static double3x2 mul(double3x2 a, double2x2 b) => default; // 0x000000018BD684EC-0x000000018BD68664
		public static double3x3 mul(double3x2 a, double2x3 b) => default; // 0x000000018BD5E2C8-0x000000018BD5E534
		public static double3x4 mul(double3x2 a, double2x4 b) => default; // 0x000000018BD68D5C-0x000000018BD69084
		public static double3 mul(double3x3 a, double3 b) => default; // 0x000000018BD65A88-0x000000018BD65B9C
		public static double3x2 mul(double3x3 a, double3x2 b) => default; // 0x000000018BD5E75C-0x000000018BD5E994
		public static double3x3 mul(double3x3 a, double3x3 b) => default; // 0x000000018BD618FC-0x000000018BD61CA4
		public static double3x4 mul(double3x3 a, double3x4 b) => default; // 0x000000018BD5DE14-0x000000018BD5E2C8
		public static double3 mul(double3x4 a, double4 b) => default; // 0x000000018BD5FCB8-0x000000018BD5FE2C
		public static double3x2 mul(double3x4 a, double4x2 b) => default; // 0x000000018BD62638-0x000000018BD6292C
		public static double3x3 mul(double3x4 a, double4x3 b) => default; // 0x000000018BD67380-0x000000018BD67860
		public static double3x4 mul(double3x4 a, double4x4 b) => default; // 0x000000018BD67BFC-0x000000018BD68248
		public static double4 mul(double4x2 a, double2 b) => default; // 0x000000018BD643BC-0x000000018BD64464
		public static double4x2 mul(double4x2 a, double2x2 b) => default; // 0x000000018BD67214-0x000000018BD67380
		public static double4x3 mul(double4x2 a, double2x3 b) => default; // 0x000000018BD65494-0x000000018BD656E8
		public static double4x4 mul(double4x2 a, double2x4 b) => default; // 0x000000018BD69084-0x000000018BD69394
		public static double4 mul(double4x3 a, double3 b) => default; // 0x000000018BD613F4-0x000000018BD614F8
		public static double4x2 mul(double4x3 a, double3x2 b) => default; // 0x000000018BD63488-0x000000018BD636A4
		public static double4x3 mul(double4x3 a, double3x3 b) => default; // 0x000000018BD64FCC-0x000000018BD65348
		public static double4x4 mul(double4x3 a, double3x4 b) => default; // 0x000000018BD5EC5C-0x000000018BD5F0E0
		public static double4 mul(double4x4 a, double4 b) => default; // 0x000000018BD5C008-0x000000018BD5C168
		public static double4x2 mul(double4x4 a, double4x2 b) => default; // 0x000000018BD62FD0-0x000000018BD632A0
		public static double4x3 mul(double4x4 a, double4x3 b) => default; // 0x000000018BD5FE2C-0x000000018BD602D0
		public static double4x4 mul(double4x4 a, double4x4 b) => default; // 0x000000018BD5F5AC-0x000000018BD5FBB0
		public static int mul(int a, int b) => default; // 0x0000000185FDA950-0x0000000185FDA960
		public static int mul(int2 a, int2 b) => default; // 0x0000000185FDA9E0-0x0000000185FDAA00
		public static int2 mul(int2 a, int2x2 b) => default; // 0x0000000185FDD350-0x0000000185FDD390
		public static int3 mul(int2 a, int2x3 b) => default; // 0x0000000185FDCCF0-0x0000000185FDCD50
		public static int4 mul(int2 a, int2x4 b) => default; // 0x0000000185FDD1A0-0x0000000185FDD220
		public static int mul(int3 a, int3 b) => default; // 0x0000000185FB00D0-0x0000000185FB00F0
		public static int2 mul(int3 a, int3x2 b) => default; // 0x0000000185FDD390-0x0000000185FDD3E0
		public static int3 mul(int3 a, int3x3 b) => default; // 0x0000000185FDCBD0-0x0000000185FDCC50
		public static int4 mul(int3 a, int3x4 b) => default; // 0x0000000185FDCC50-0x0000000185FDCCF0
		public static int mul(int4 a, int4 b) => default; // 0x0000000185FDA9A0-0x0000000185FDA9D0
		public static int2 mul(int4 a, int4x2 b) => default; // 0x0000000185FDD220-0x0000000185FDD280
		public static int3 mul(int4 a, int4x3 b) => default; // 0x0000000185FDCA70-0x0000000185FDCB10
		public static int4 mul(int4 a, int4x4 b) => default; // 0x0000000185FDC8F0-0x0000000185FDC9B0
		public static int2 mul(int2x2 a, int2 b) => default; // 0x000000018BD5F268-0x000000018BD5F2B0
		public static int2x2 mul(int2x2 a, int2x2 b) => default; // 0x000000018BD65C54-0x000000018BD65D08
		public static int2x3 mul(int2x2 a, int2x3 b) => default; // 0x000000018BD5FBB0-0x000000018BD5FCB8
		public static int2x4 mul(int2x2 a, int2x4 b) => default; // 0x000000018BD5B830-0x000000018BD5B99C
		public static int2 mul(int2x3 a, int3 b) => default; // 0x000000018BD614F8-0x000000018BD61574
		public static int2x2 mul(int2x3 a, int3x2 b) => default; // 0x000000018BD62D6C-0x000000018BD62E7C
		public static int2x3 mul(int2x3 a, int3x3 b) => default; // 0x000000018BD5F2B0-0x000000018BD5F448
		public static int2x4 mul(int2x3 a, int3x4 b) => default; // 0x000000018BD5C9D0-0x000000018BD5CBBC
		public static int2 mul(int2x4 a, int4 b) => default; // 0x000000018BD5E994-0x000000018BD5EA3C
		public static int2x2 mul(int2x4 a, int4x2 b) => default; // 0x000000018BD5F448-0x000000018BD5F5AC
		public static int2x3 mul(int2x4 a, int4x3 b) => default; // 0x000000018BD5C230-0x000000018BD5C444
		public static int2x4 mul(int2x4 a, int4x4 b) => default; // 0x000000018BD64784-0x000000018BD64A08
		public static int3 mul(int3x2 a, int2 b) => default; // 0x000000018BD5F0E0-0x000000018BD5F178
		public static int3x2 mul(int3x2 a, int2x2 b) => default; // 0x000000018BD67860-0x000000018BD679A8
		public static int3x3 mul(int3x2 a, int2x3 b) => default; // 0x000000018BD602D0-0x000000018BD604A4
		public static int3x4 mul(int3x2 a, int2x4 b) => default; // 0x000000018BD60DB8-0x000000018BD6101C
		public static int3 mul(int3x3 a, int3 b) => default; // 0x000000018BD60CCC-0x000000018BD60DB8
		public static int3x2 mul(int3x3 a, int3x2 b) => default; // 0x000000018BD5CE18-0x000000018BD5D008
		public static int3x3 mul(int3x3 a, int3x3 b) => default; // 0x000000018BD657BC-0x000000018BD65A88
		public static int3x4 mul(int3x3 a, int3x4 b) => default; // 0x000000018BD60920-0x000000018BD60CCC
		public static int3 mul(int3x4 a, int4 b) => default; // 0x000000018BD5EA3C-0x000000018BD5EB7C
		public static int3x2 mul(int3x4 a, int4x2 b) => default; // 0x000000018BD5B99C-0x000000018BD5BC30
		public static int3x3 mul(int3x4 a, int4x3 b) => default; // 0x000000018BD6292C-0x000000018BD62CEC
		public static int3x4 mul(int3x4 a, int4x4 b) => default; // 0x000000018BD5D6C4-0x000000018BD5DC30
		public static int4 mul(int4x2 a, int2 b) => default; // 0x000000018BD5C168-0x000000018BD5C1E0
		public static int4x2 mul(int4x2 a, int2x2 b) => default; // 0x000000018BD5EB7C-0x000000018BD5EC5C
		public static int4x3 mul(int4x2 a, int2x3 b) => default; // 0x000000018BD61574-0x000000018BD616D8
		public static int4x4 mul(int4x2 a, int2x4 b) => default; // 0x000000018BD63D08-0x000000018BD63ED8
		public static int4 mul(int4x3 a, int3 b) => default; // 0x000000018BD5BD0C-0x000000018BD5BDC0
		public static int4x2 mul(int4x3 a, int3x2 b) => default; // 0x000000018BD5D56C-0x000000018BD5D6C4
		public static int4x3 mul(int4x3 a, int3x3 b) => default; // 0x000000018BD5B338-0x000000018BD5B554
		public static int4x4 mul(int4x3 a, int3x4 b) => default; // 0x000000018BD60618-0x000000018BD60920
		public static int4 mul(int4x4 a, int4 b) => default; // 0x000000018BD642CC-0x000000018BD643BC
		public static int4x2 mul(int4x4 a, int4x2 b) => default; // 0x000000018BD61D58-0x000000018BD61F28
		public static int4x3 mul(int4x4 a, int4x3 b) => default; // 0x000000018BD65E70-0x000000018BD66140
		public static int4x4 mul(int4x4 a, int4x4 b) => default; // 0x000000018BD66620-0x000000018BD66A30
		public static uint mul(uint a, uint b) => default; // 0x0000000185FDA950-0x0000000185FDA960
		public static uint mul(uint2 a, uint2 b) => default; // 0x0000000185FDA9E0-0x0000000185FDAA00
		public static uint2 mul(uint2 a, uint2x2 b) => default; // 0x0000000185FDD350-0x0000000185FDD390
		public static uint3 mul(uint2 a, uint2x3 b) => default; // 0x0000000185FDCCF0-0x0000000185FDCD50
		public static uint4 mul(uint2 a, uint2x4 b) => default; // 0x0000000185FDD580-0x0000000185FDD600
		public static uint mul(uint3 a, uint3 b) => default; // 0x0000000185FB00D0-0x0000000185FB00F0
		public static uint2 mul(uint3 a, uint3x2 b) => default; // 0x0000000185FDD390-0x0000000185FDD3E0
		public static uint3 mul(uint3 a, uint3x3 b) => default; // 0x0000000185FDCBD0-0x0000000185FDCC50
		public static uint4 mul(uint3 a, uint3x4 b) => default; // 0x0000000185FDCC50-0x0000000185FDCCF0
		public static uint mul(uint4 a, uint4 b) => default; // 0x0000000185FDA9A0-0x0000000185FDA9D0
		public static uint2 mul(uint4 a, uint4x2 b) => default; // 0x0000000185FDD220-0x0000000185FDD280
		public static uint3 mul(uint4 a, uint4x3 b) => default; // 0x0000000185FDCA70-0x0000000185FDCB10
		public static uint4 mul(uint4 a, uint4x4 b) => default; // 0x0000000185FDC8F0-0x0000000185FDC9B0
		public static uint2 mul(uint2x2 a, uint2 b) => default; // 0x000000018BD5F268-0x000000018BD5F2B0
		public static uint2x2 mul(uint2x2 a, uint2x2 b) => default; // 0x000000018BD65C54-0x000000018BD65D08
		public static uint2x3 mul(uint2x2 a, uint2x3 b) => default; // 0x000000018BD5FBB0-0x000000018BD5FCB8
		public static uint2x4 mul(uint2x2 a, uint2x4 b) => default; // 0x000000018BD5B830-0x000000018BD5B99C
		public static uint2 mul(uint2x3 a, uint3 b) => default; // 0x000000018BD614F8-0x000000018BD61574
		public static uint2x2 mul(uint2x3 a, uint3x2 b) => default; // 0x000000018BD62D6C-0x000000018BD62E7C
		public static uint2x3 mul(uint2x3 a, uint3x3 b) => default; // 0x000000018BD5F2B0-0x000000018BD5F448
		public static uint2x4 mul(uint2x3 a, uint3x4 b) => default; // 0x000000018BD5C9D0-0x000000018BD5CBBC
		public static uint2 mul(uint2x4 a, uint4 b) => default; // 0x000000018BD5E994-0x000000018BD5EA3C
		public static uint2x2 mul(uint2x4 a, uint4x2 b) => default; // 0x000000018BD5F448-0x000000018BD5F5AC
		public static uint2x3 mul(uint2x4 a, uint4x3 b) => default; // 0x000000018BD5C230-0x000000018BD5C444
		public static uint2x4 mul(uint2x4 a, uint4x4 b) => default; // 0x000000018BD64784-0x000000018BD64A08
		public static uint3 mul(uint3x2 a, uint2 b) => default; // 0x000000018BD5F0E0-0x000000018BD5F178
		public static uint3x2 mul(uint3x2 a, uint2x2 b) => default; // 0x000000018BD67860-0x000000018BD679A8
		public static uint3x3 mul(uint3x2 a, uint2x3 b) => default; // 0x000000018BD602D0-0x000000018BD604A4
		public static uint3x4 mul(uint3x2 a, uint2x4 b) => default; // 0x000000018BD60DB8-0x000000018BD6101C
		public static uint3 mul(uint3x3 a, uint3 b) => default; // 0x000000018BD60CCC-0x000000018BD60DB8
		public static uint3x2 mul(uint3x3 a, uint3x2 b) => default; // 0x000000018BD5CE18-0x000000018BD5D008
		public static uint3x3 mul(uint3x3 a, uint3x3 b) => default; // 0x000000018BD657BC-0x000000018BD65A88
		public static uint3x4 mul(uint3x3 a, uint3x4 b) => default; // 0x000000018BD60920-0x000000018BD60CCC
		public static uint3 mul(uint3x4 a, uint4 b) => default; // 0x000000018BD5EA3C-0x000000018BD5EB7C
		public static uint3x2 mul(uint3x4 a, uint4x2 b) => default; // 0x000000018BD5B99C-0x000000018BD5BC30
		public static uint3x3 mul(uint3x4 a, uint4x3 b) => default; // 0x000000018BD6292C-0x000000018BD62CEC
		public static uint3x4 mul(uint3x4 a, uint4x4 b) => default; // 0x000000018BD5D6C4-0x000000018BD5DC30
		public static uint4 mul(uint4x2 a, uint2 b) => default; // 0x000000018BD5C168-0x000000018BD5C1E0
		public static uint4x2 mul(uint4x2 a, uint2x2 b) => default; // 0x000000018BD5EB7C-0x000000018BD5EC5C
		public static uint4x3 mul(uint4x2 a, uint2x3 b) => default; // 0x000000018BD61574-0x000000018BD616D8
		public static uint4x4 mul(uint4x2 a, uint2x4 b) => default; // 0x000000018BD63D08-0x000000018BD63ED8
		public static uint4 mul(uint4x3 a, uint3 b) => default; // 0x000000018BD5BD0C-0x000000018BD5BDC0
		public static uint4x2 mul(uint4x3 a, uint3x2 b) => default; // 0x000000018BD5D56C-0x000000018BD5D6C4
		public static uint4x3 mul(uint4x3 a, uint3x3 b) => default; // 0x000000018BD5B338-0x000000018BD5B554
		public static uint4x4 mul(uint4x3 a, uint3x4 b) => default; // 0x000000018BD60618-0x000000018BD60920
		public static uint4 mul(uint4x4 a, uint4 b) => default; // 0x000000018BD642CC-0x000000018BD643BC
		public static uint4x2 mul(uint4x4 a, uint4x2 b) => default; // 0x000000018BD61D58-0x000000018BD61F28
		public static uint4x3 mul(uint4x4 a, uint4x3 b) => default; // 0x000000018BD65E70-0x000000018BD66140
		public static uint4x4 mul(uint4x4 a, uint4x4 b) => default; // 0x000000018BD66620-0x000000018BD66A30
		public static quaternion quaternion(float x, float y, float z, float w) => default; // 0x0000000185FDB750-0x0000000185FDB770
		public static quaternion quaternion(float4 value) => default; // 0x0000000181D61820-0x0000000181D61830
		public static quaternion quaternion(float3x3 m) => default; // 0x000000018BD6A7C8-0x000000018BD6A808
		public static quaternion quaternion(float4x4 m) => default; // 0x000000018BD6A780-0x000000018BD6A7C8
		public static quaternion conjugate(quaternion q) => default; // 0x000000018BD49564-0x000000018BD495A4
		public static quaternion inverse(quaternion q) => default; // 0x000000018BD587CC-0x000000018BD58848
		public static float dot(quaternion a, quaternion b) => default; // 0x000000018BD4A2A0-0x000000018BD4A2C8
		public static float length(quaternion q) => default; // 0x000000018BD592B8-0x000000018BD592F4
		public static float lengthsq(quaternion q) => default; // 0x000000018BD592F4-0x000000018BD5931C
		public static quaternion normalize(quaternion q) => default; // 0x000000018BD694F4-0x000000018BD69550
		public static quaternion normalizesafe(quaternion q) => default; // 0x000000018BD6986C-0x000000018BD6992C
		public static quaternion normalizesafe(quaternion q, quaternion defaultvalue) => default; // 0x000000018BD697E0-0x000000018BD6986C
		public static quaternion unitexp(quaternion q) => default; // 0x0000000186F48124-0x0000000186F48248
		public static quaternion exp(quaternion q) => default; // 0x0000000186F1A874-0x0000000186F1AAC4
		public static quaternion unitlog(quaternion q) => default; // 0x0000000186F48248-0x0000000186F4858C
		public static quaternion log(quaternion q) => default; // 0x0000000186F26430-0x0000000186F26638
		public static quaternion mul(quaternion a, quaternion b) => default; // 0x000000018BD5E534-0x000000018BD5E6C0
		public static float3 mul(quaternion q, float3 v) => default; // 0x000000018BD67AA0-0x000000018BD67BFC
		public static float3 rotate(quaternion q, float3 v) => default; // 0x000000018BD67AA0-0x000000018BD67BFC
		public static quaternion nlerp(quaternion q1, quaternion q2, float t) => default; // 0x000000018BD69394-0x000000018BD69474
		public static quaternion slerp(quaternion q1, quaternion q2, float t) => default; // 0x000000018BD6E9B8-0x000000018BD6EB58
		public static float angle(quaternion q1, quaternion q2) => default; // 0x000000018BD47D50-0x000000018BD47DF8
		public static quaternion rotation(float3x3 m) => default; // 0x000000018BD6C414-0x000000018BD6C640
		private static float3x3 adj(float3x3 m, out float det) {
			det = default;
			return default;
		} // 0x000000018BD47A18-0x000000018BD47BE8
		private static bool adjInverse(float3x3 m, out float3x3 i, float epsilon = 1E-30f /* Metadata: 0x0207B86E */) {
			i = default;
			return default;
		} // 0x000000018BD47918-0x000000018BD47A18
		public static uint hash(quaternion q) => default; // 0x000000018BD520A8-0x000000018BD520C4
		public static uint4 hashwide(quaternion q) => default; // 0x000000018BD54D00-0x000000018BD54D30
		public static float3 forward(quaternion q) => default; // 0x00000001877447A0-0x00000001877447F8
		public static RigidTransform RigidTransform(quaternion rot, float3 pos) => default; // 0x0000000185FD8F00-0x0000000185FD8F20
		public static RigidTransform RigidTransform(float3x3 rotation, float3 translation) => default; // 0x000000018BD47678-0x000000018BD476D4
		public static RigidTransform RigidTransform(float4x4 transform) => default; // 0x000000018BD476D4-0x000000018BD47724
		public static RigidTransform inverse(RigidTransform t) => default; // 0x000000018BD58848-0x000000018BD58908
		public static RigidTransform mul(RigidTransform a, RigidTransform b) => default; // 0x000000018BD66C60-0x000000018BD66D30
		public static float4 mul(RigidTransform a, float4 pos) => default; // 0x000000018BD5BC30-0x000000018BD5BD0C
		public static float3 rotate(RigidTransform a, float3 dir) => default; // 0x0000000187745AB4-0x0000000187745B04
		public static float3 transform(RigidTransform a, float3 pos) => default; // 0x000000018BD6FBD4-0x000000018BD6FC5C
		public static uint hash(RigidTransform t) => default; // 0x000000018BD521A4-0x000000018BD521E8
		public static uint4 hashwide(RigidTransform t) => default; // 0x000000018BD534D0-0x000000018BD53588
		public static uint2 uint2(uint x, uint y) => default; // 0x0000000185FD9780-0x0000000185FD9790
		public static uint2 uint2(uint2 xy) => default; // 0x0000000185FD75B0-0x0000000185FD75D0
		public static uint2 uint2(uint v) => default; // 0x0000000185FDC1B0-0x0000000185FDC1C0
		public static uint2 uint2(bool v) => default; // 0x000000018BD55FBC-0x000000018BD55FD4
		public static uint2 uint2(bool2 v) => default; // 0x000000018BD55FD4-0x000000018BD55FF4
		public static uint2 uint2(int v) => default; // 0x0000000185FDC1B0-0x0000000185FDC1C0
		public static uint2 uint2(int2 v) => default; // 0x0000000185FD75B0-0x0000000185FD75D0
		public static uint2 uint2(float v) => default; // 0x000000018BD71284-0x000000018BD712A8
		public static uint2 uint2(float2 v) => default; // 0x000000018BD712A8-0x000000018BD712CC
		public static uint2 uint2(double v) => default; // 0x000000018BD71264-0x000000018BD71284
		public static uint2 uint2(double2 v) => default; // 0x000000018BD71234-0x000000018BD71264
		public static uint hash(uint2 v) => default; // 0x000000018BD5052C-0x000000018BD50560
		public static uint2 hashwide(uint2 v) => default; // 0x000000018BD53198-0x000000018BD531D8
		public static uint shuffle(uint2 left, uint2 right, ShuffleComponent x) => default; // 0x0000000186F42B70-0x0000000186F42D04
		public static uint2 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000186F41D8C-0x0000000186F41E80
		public static uint3 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000186F42300-0x0000000186F42370
		public static uint4 shuffle(uint2 left, uint2 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000186F4335C-0x0000000186F433EC
		internal static uint select_shuffle_component(uint2 a, uint2 b, ShuffleComponent component) => default; // 0x0000000186F40E44-0x0000000186F40F34
		public static uint2x2 uint2x2(uint2 c0, uint2 c1) => default; // 0x0000000183E31D70-0x0000000183E34180
		public static uint2x2 uint2x2(uint m00, uint m01, uint m10, uint m11) => default; // 0x000000018BD56050-0x000000018BD56070
		public static uint2x2 uint2x2(uint v) => default; // 0x000000018BD56038-0x000000018BD56050
		public static uint2x2 uint2x2(bool v) => default; // 0x000000018BD560F4-0x000000018BD5610C
		public static uint2x2 uint2x2(bool2x2 v) => default; // 0x000000018BD55FF4-0x000000018BD56014
		public static uint2x2 uint2x2(int v) => default; // 0x000000018BD56038-0x000000018BD56050
		public static uint2x2 uint2x2(int2x2 v) => default; // 0x000000018BD560B8-0x000000018BD560DC
		public static uint2x2 uint2x2(float v) => default; // 0x000000018BD712CC-0x000000018BD712E8
		public static uint2x2 uint2x2(float2x2 v) => default; // 0x000000018BD71388-0x000000018BD713B0
		public static uint2x2 uint2x2(double v) => default; // 0x000000018BD712E8-0x000000018BD7132C
		public static uint2x2 uint2x2(double2x2 v) => default; // 0x000000018BD7132C-0x000000018BD71388
		public static uint2x2 transpose(uint2x2 v) => default; // 0x000000018BD700A4-0x000000018BD700E0
		public static uint hash(uint2x2 v) => default; // 0x000000018BD5186C-0x000000018BD518D0
		public static uint2 hashwide(uint2x2 v) => default; // 0x000000018BD530A8-0x000000018BD5311C
		public static uint2x3 uint2x3(uint2 c0, uint2 c1, uint2 c2) => default; // 0x0000000185FDB480-0x0000000185FDB490
		public static uint2x3 uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12) => default; // 0x0000000186F24A4C-0x0000000186F24A84
		public static uint2x3 uint2x3(uint v) => default; // 0x000000018BD56164-0x000000018BD56184
		public static uint2x3 uint2x3(bool v) => default; // 0x000000018BD56218-0x000000018BD56238
		public static uint2x3 uint2x3(bool2x3 v) => default; // 0x000000018BD561A4-0x000000018BD561DC
		public static uint2x3 uint2x3(int v) => default; // 0x000000018BD56164-0x000000018BD56184
		public static uint2x3 uint2x3(int2x3 v) => default; // 0x000000018BD5612C-0x000000018BD56164
		public static uint2x3 uint2x3(float v) => default; // 0x000000018BD71408-0x000000018BD71428
		public static uint2x3 uint2x3(float2x3 v) => default; // 0x000000018BD713D0-0x000000018BD71408
		public static uint2x3 uint2x3(double v) => default; // 0x000000018BD713B0-0x000000018BD713D0
		public static uint2x3 uint2x3(double2x3 v) => default; // 0x000000018BD71428-0x000000018BD71464
		public static uint3x2 transpose(uint2x3 v) => default; // 0x000000018BD70D08-0x000000018BD70D54
		public static uint hash(uint2x3 v) => default; // 0x000000018BD50D88-0x000000018BD50E18
		public static uint2 hashwide(uint2x3 v) => default; // 0x000000018BD55CF8-0x000000018BD55D98
		public static uint2x4 uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3) => default; // 0x0000000185FDC1E0-0x0000000185FDC200
		public static uint2x4 uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13) => default; // 0x0000000186F24A84-0x0000000186F24AD8
		public static uint2x4 uint2x4(uint v) => default; // 0x000000018BD56294-0x000000018BD562B0
		public static uint2x4 uint2x4(bool v) => default; // 0x000000018BD562E4-0x000000018BD56300
		public static uint2x4 uint2x4(bool2x4 v) => default; // 0x000000018BD56270-0x000000018BD56294
		public static uint2x4 uint2x4(int v) => default; // 0x000000018BD56294-0x000000018BD562B0
		public static uint2x4 uint2x4(int2x4 v) => default; // 0x000000018BD562B0-0x000000018BD562E4
		public static uint2x4 uint2x4(float v) => default; // 0x000000018BD71498-0x000000018BD714B8
		public static uint2x4 uint2x4(float2x4 v) => default; // 0x000000018BD71464-0x000000018BD71498
		public static uint2x4 uint2x4(double v) => default; // 0x000000018BD714B8-0x000000018BD714D4
		public static uint2x4 uint2x4(double2x4 v) => default; // 0x000000018BD714D4-0x000000018BD71518
		public static uint4x2 transpose(uint2x4 v) => default; // 0x000000018BD702BC-0x000000018BD70314
		public static uint hash(uint2x4 v) => default; // 0x000000018BD4FCE0-0x000000018BD4FD9C
		public static uint2 hashwide(uint2x4 v) => default; // 0x000000018BD54D30-0x000000018BD54DFC
		public static uint3 uint3(uint x, uint y, uint z) => default; // 0x0000000185FD9790-0x0000000185FD97A0
		public static uint3 uint3(uint x, uint2 yz) => default; // 0x0000000185FDC240-0x0000000185FDC260
		public static uint3 uint3(uint2 xy, uint z) => default; // 0x0000000185FDC260-0x0000000185FDC280
		public static uint3 uint3(uint3 xyz) => default; // 0x0000000185FDC280-0x0000000185FDC2B0
		public static uint3 uint3(uint v) => default; // 0x0000000185FDC200-0x0000000185FDC210
		public static uint3 uint3(bool v) => default; // 0x000000018BD563B0-0x000000018BD563C8
		public static uint3 uint3(bool3 v) => default; // 0x000000018BD563C8-0x000000018BD563FC
		public static uint3 uint3(int v) => default; // 0x0000000185FDC200-0x0000000185FDC210
		public static uint3 uint3(int3 v) => default; // 0x0000000185FDC280-0x0000000185FDC2B0
		public static uint3 uint3(float v) => default; // 0x000000018BD71578-0x000000018BD71594
		public static uint3 uint3(float3 v) => default; // 0x0000000186F498B8-0x0000000186F49904
		public static uint3 uint3(double v) => default; // 0x000000018BD71550-0x000000018BD71578
		public static uint3 uint3(double3 v) => default; // 0x000000018BD71518-0x000000018BD71550
		public static uint hash(uint3 v) => default; // 0x0000000186F1DB24-0x0000000186F1E578
		public static uint3 hashwide(uint3 v) => default; // 0x0000000186F23C48-0x0000000186F24094
		public static uint shuffle(uint3 left, uint3 right, ShuffleComponent x) => default; // 0x0000000186F4357C-0x0000000186F435B8
		public static uint2 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x0000000186F42A78-0x0000000186F42AF8
		public static uint3 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x0000000186F434A0-0x0000000186F4357C
		public static uint4 shuffle(uint3 left, uint3 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x0000000186F42D70-0x0000000186F42E88
		internal static uint select_shuffle_component(uint3 a, uint3 b, ShuffleComponent component) => default; // 0x0000000186F415AC-0x0000000186F416B0
		public static uint3x2 uint3x2(uint3 c0, uint3 c1) => default; // 0x0000000185FDB6D0-0x0000000185FDB700
		public static uint3x2 uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21) => default; // 0x0000000186F24AD8-0x0000000186F24B68
		public static uint3x2 uint3x2(uint v) => default; // 0x000000018BD564AC-0x000000018BD564CC
		public static uint3x2 uint3x2(bool v) => default; // 0x000000018BD564CC-0x000000018BD564EC
		public static uint3x2 uint3x2(bool3x2 v) => default; // 0x000000018BD564EC-0x000000018BD56524
		public static uint3x2 uint3x2(int v) => default; // 0x000000018BD564AC-0x000000018BD564CC
		public static uint3x2 uint3x2(int3x2 v) => default; // 0x000000018BD5643C-0x000000018BD56474
		public static uint3x2 uint3x2(float v) => default; // 0x000000018BD71668-0x000000018BD71688
		public static uint3x2 uint3x2(float3x2 v) => default; // 0x000000018BD71630-0x000000018BD71668
		public static uint3x2 uint3x2(double v) => default; // 0x000000018BD71594-0x000000018BD715F4
		public static uint3x2 uint3x2(double3x2 v) => default; // 0x000000018BD715F4-0x000000018BD71630
		public static uint2x3 transpose(uint3x2 v) => default; // 0x000000018BD700E0-0x000000018BD7012C
		public static uint hash(uint3x2 v) => default; // 0x000000018BD50284-0x000000018BD50364
		public static uint3 hashwide(uint3x2 v) => default; // 0x000000018BD54818-0x000000018BD54910
		public static uint3x3 uint3x3(uint3 c0, uint3 c1, uint3 c2) => default; // 0x00000001840DB930-0x00000001840DBA30
		public static uint3x3 uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22) => default; // 0x0000000186F24B68-0x0000000186F24C2C
		public static uint3x3 uint3x3(uint v) => default; // 0x000000018BD56564-0x000000018BD56584
		public static uint3x3 uint3x3(bool v) => default; // 0x000000018BD566DC-0x000000018BD566FC
		public static uint3x3 uint3x3(bool3x3 v) => default; // 0x000000018BD5669C-0x000000018BD566DC
		public static uint3x3 uint3x3(int v) => default; // 0x000000018BD56564-0x000000018BD56584
		public static uint3x3 uint3x3(int3x3 v) => default; // 0x000000018BD565A4-0x000000018BD565E4
		public static uint3x3 uint3x3(float v) => default; // 0x000000018BD716E8-0x000000018BD7170C
		public static uint3x3 uint3x3(float3x3 v) => default; // 0x000000018BD716A8-0x000000018BD716E8
		public static uint3x3 uint3x3(double v) => default; // 0x000000018BD71688-0x000000018BD716A8
		public static uint3x3 uint3x3(double3x3 v) => default; // 0x000000018BD7170C-0x000000018BD71760
		public static uint3x3 transpose(uint3x3 v) => default; // 0x000000018BD70644-0x000000018BD706B0
		public static uint hash(uint3x3 v) => default; // 0x000000018BD51A64-0x000000018BD51BB8
		public static uint3 hashwide(uint3x3 v) => default; // 0x000000018BD54EF0-0x000000018BD5505C
		public static uint3x4 uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3) => default; // 0x0000000185FDB700-0x0000000185FDB750
		public static uint3x4 uint3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23) => default; // 0x0000000186F24C2C-0x0000000186F24CF4
		public static uint3x4 uint3x4(uint v) => default; // 0x000000018BD567B8-0x000000018BD567D8
		public static uint3x4 uint3x4(bool v) => default; // 0x000000018BD566FC-0x000000018BD5671C
		public static uint3x4 uint3x4(bool3x4 v) => default; // 0x000000018BD5677C-0x000000018BD567B8
		public static uint3x4 uint3x4(int v) => default; // 0x000000018BD567B8-0x000000018BD567D8
		public static uint3x4 uint3x4(int3x4 v) => default; // 0x000000018BD5685C-0x000000018BD568A0
		public static uint3x4 uint3x4(float v) => default; // 0x000000018BD71820-0x000000018BD71844
		public static uint3x4 uint3x4(float3x4 v) => default; // 0x000000018BD717DC-0x000000018BD71820
		public static uint3x4 uint3x4(double v) => default; // 0x000000018BD71760-0x000000018BD71780
		public static uint3x4 uint3x4(double3x4 v) => default; // 0x000000018BD71780-0x000000018BD717DC
		public static uint4x3 transpose(uint3x4 v) => default; // 0x000000018BD701CC-0x000000018BD70250
		public static uint hash(uint3x4 v) => default; // 0x000000018BD516A0-0x000000018BD5186C
		public static uint3 hashwide(uint3x4 v) => default; // 0x000000018BD55A28-0x000000018BD55C08
		public static uint4 uint4(uint x, uint y, uint z, uint w) => default; // 0x0000000185FD97A0-0x0000000185FD97C0
		public static uint4 uint4(uint x, uint y, uint2 zw) => default; // 0x0000000185FDC3C0-0x0000000185FDC3E0
		public static uint4 uint4(uint x, uint2 yz, uint w) => default; // 0x0000000185FDC440-0x0000000185FDC460
		public static uint4 uint4(uint x, uint3 yzw) => default; // 0x0000000185FDC340-0x0000000185FDC380
		public static uint4 uint4(uint2 xy, uint z, uint w) => default; // 0x0000000185FDC3E0-0x0000000185FDC400
		public static uint4 uint4(uint2 xy, uint2 zw) => default; // 0x0000000185FD75D0-0x0000000185FD75F0
		public static uint4 uint4(uint3 xyz, uint w) => default; // 0x0000000185FDC400-0x0000000185FDC440
		public static uint4 uint4(uint4 xyzw) => default; // 0x000000018BD568A0-0x000000018BD568CC
		public static uint4 uint4(uint v) => default; // 0x0000000185FDC330-0x0000000185FDC340
		public static uint4 uint4(bool v) => default; // 0x000000018BD568CC-0x000000018BD568EC
		public static uint4 uint4(bool4 v) => default; // 0x000000018BD568EC-0x000000018BD56930
		public static uint4 uint4(int v) => default; // 0x0000000185FDC330-0x0000000185FDC340
		public static uint4 uint4(int4 v) => default; // 0x000000018BD568A0-0x000000018BD568CC
		public static uint4 uint4(float v) => default; // 0x000000018BD7188C-0x000000018BD718A4
		public static uint4 uint4(float4 v) => default; // 0x000000018BD718D4-0x000000018BD718F8
		public static uint4 uint4(double v) => default; // 0x000000018BD718A4-0x000000018BD718D4
		public static uint4 uint4(double4 v) => default; // 0x000000018BD71844-0x000000018BD7188C
		public static uint hash(uint4 v) => default; // 0x000000018BD4F62C-0x000000018BD4F698
		public static uint4 hashwide(uint4 v) => default; // 0x000000018BD5302C-0x000000018BD530A8
		public static uint shuffle(uint4 left, uint4 right, ShuffleComponent x) => default; // 0x000000018BD6D71C-0x000000018BD6D744
		public static uint2 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y) => default; // 0x000000018BD6D29C-0x000000018BD6D2F4
		public static uint3 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z) => default; // 0x000000018BD6DB68-0x000000018BD6DC10
		public static uint4 shuffle(uint4 left, uint4 right, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w) => default; // 0x000000018BD6DEA8-0x000000018BD6DF80
		internal static uint select_shuffle_component(uint4 a, uint4 b, ShuffleComponent component) => default; // 0x0000000186F41AC8-0x0000000186F41C98
		public static uint4x2 uint4x2(uint4 c0, uint4 c1) => default; // 0x0000000185FDB910-0x0000000185FDB930
		public static uint4x2 uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31) => default; // 0x0000000186F24CF4-0x0000000186F24DA8
		public static uint4x2 uint4x2(uint v) => default; // 0x000000018BD569F4-0x000000018BD56A10
		public static uint4x2 uint4x2(bool v) => default; // 0x000000018BD7191C-0x000000018BD71938
		public static uint4x2 uint4x2(bool4x2 v) => default; // 0x000000018BD718F8-0x000000018BD7191C
		public static uint4x2 uint4x2(int v) => default; // 0x000000018BD569F4-0x000000018BD56A10
		public static uint4x2 uint4x2(int4x2 v) => default; // 0x000000018BD56A10-0x000000018BD56A44
		public static uint4x2 uint4x2(float v) => default; // 0x000000018BD71938-0x000000018BD71958
		public static uint4x2 uint4x2(float4x2 v) => default; // 0x000000018BD7199C-0x000000018BD719D0
		public static uint4x2 uint4x2(double v) => default; // 0x000000018BD719D0-0x000000018BD719EC
		public static uint4x2 uint4x2(double4x2 v) => default; // 0x000000018BD71958-0x000000018BD7199C
		public static uint2x4 transpose(uint4x2 v) => default; // 0x000000018BD7012C-0x000000018BD70184
		public static uint hash(uint4x2 v) => default; // 0x000000018BD51C84-0x000000018BD51D50
		public static uint4 hashwide(uint4x2 v) => default; // 0x000000018BD526A4-0x000000018BD5277C
		public static uint4x3 uint4x3(uint4 c0, uint4 c1, uint4 c2) => default; // 0x0000000185FDB930-0x0000000185FDB950
		public static uint4x3 uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32) => default; // 0x0000000186F24DA8-0x0000000186F24F70
		public static uint4x3 uint4x3(uint v) => default; // 0x000000018BD56AF4-0x000000018BD56B14
		public static uint4x3 uint4x3(bool v) => default; // 0x000000018BD71B0C-0x000000018BD71B2C
		public static uint4x3 uint4x3(bool4x3 v) => default; // 0x000000018BD71AD0-0x000000018BD71B0C
		public static uint4x3 uint4x3(int v) => default; // 0x000000018BD56AF4-0x000000018BD56B14
		public static uint4x3 uint4x3(int4x3 v) => default; // 0x000000018BD56BD0-0x000000018BD56C14
		public static uint4x3 uint4x3(float v) => default; // 0x000000018BD71A8C-0x000000018BD71AB0
		public static uint4x3 uint4x3(float4x3 v) => default; // 0x000000018BD719EC-0x000000018BD71A30
		public static uint4x3 uint4x3(double v) => default; // 0x000000018BD71AB0-0x000000018BD71AD0
		public static uint4x3 uint4x3(double4x3 v) => default; // 0x000000018BD71A30-0x000000018BD71A8C
		public static uint3x4 transpose(uint4x3 v) => default; // 0x000000018BD704E0-0x000000018BD70564
		public static uint hash(uint4x3 v) => default; // 0x000000018BD509A8-0x000000018BD50AD8
		public static uint4 hashwide(uint4x3 v) => default; // 0x000000018BD54910-0x000000018BD54A4C
		public static uint4x4 uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3) => default; // 0x0000000185FDB950-0x0000000185FDB980
		public static uint4x4 uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33) => default; // 0x0000000186F24F70-0x0000000186F25208
		public static uint4x4 uint4x4(uint v) => default; // 0x000000018BD56CF4-0x000000018BD56D18
		public static uint4x4 uint4x4(bool v) => default; // 0x000000018BD71B2C-0x000000018BD71B50
		public static uint4x4 uint4x4(bool4x4 v) => default; // 0x000000018BD71BAC-0x000000018BD71BE4
		public static uint4x4 uint4x4(int v) => default; // 0x000000018BD56CF4-0x000000018BD56D18
		public static uint4x4 uint4x4(int4x4 v) => default; // 0x000000018BD56D74-0x000000018BD56DD0
		public static uint4x4 uint4x4(float v) => default; // 0x000000018BD71C70-0x000000018BD71C98
		public static uint4x4 uint4x4(float4x4 v) => default; // 0x000000018BD71B50-0x000000018BD71BAC
		public static uint4x4 uint4x4(double v) => default; // 0x000000018BD71C98-0x000000018BD71CBC
		public static uint4x4 uint4x4(double4x4 v) => default; // 0x000000018BD71BE4-0x000000018BD71C70
		public static uint4x4 transpose(uint4x4 v) => default; // 0x000000018BD70864-0x000000018BD7090C
		public static uint hash(uint4x4 v) => default; // 0x000000018BD50560-0x000000018BD506F0
		public static uint4 hashwide(uint4x4 v) => default; // 0x000000018BD52DF0-0x000000018BD52F8C
	}

	[Serializable]
	public struct bool2 : IEquatable<Unity.Mathematics.bool2> // TypeDefIndex: 54697
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54696
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public bool2(bool x, bool y) {
			this.x = default;
			this.y = default;
		} // 0x0000000185FC8310-0x0000000185FC8320
		public bool2(bool2 xy) {
			x = default;
			y = default;
		} // 0x0000000185FDE0F0-0x0000000185FDE100
		public bool2(bool v) {
			x = default;
			y = default;
		} // 0x0000000185FDE100-0x0000000185FDE110
	
		// Methods
		public static implicit operator bool2(bool v) => default; // 0x0000000185FD9460-0x0000000185FD9470
		public bool Equals(bool2 rhs) => default; // 0x000000018BD78CD0-0x000000018BD78CE4
		public override bool Equals(object o) => default; // 0x000000018BD78CE4-0x000000018BD78D58
		public override int GetHashCode() => default; // 0x000000018BD78D58-0x000000018BD78DA0
		public override string ToString() => default; // 0x000000018BD78DA0-0x000000018BD78E28
	}

	[Serializable]
	public struct bool2x2 : IEquatable<Unity.Mathematics.bool2x2> // TypeDefIndex: 54698
	{
		// Fields
		public bool2 c0; // 0x00
		public bool2 c1; // 0x02
	
		// Constructors
		public bool2x2(bool2 c0, bool2 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000185FCFBE0-0x0000000185FCFBF0
		public bool2x2(bool m00, bool m01, bool m10, bool m11) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDE140-0x0000000185FDE170
		public bool2x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDE110-0x0000000185FDE140
	
		// Methods
		public bool Equals(bool2x2 rhs) => default; // 0x000000018BD727C8-0x000000018BD72950
		public override bool Equals(object o) => default; // 0x000000018BD78E28-0x000000018BD78E88
		public override int GetHashCode() => default; // 0x000000018BD78E88-0x000000018BD78E90
		public override string ToString() => default; // 0x000000018BD78E90-0x000000018BD78FEC
	}

	[Serializable]
	public struct bool2x3 : IEquatable<Unity.Mathematics.bool2x3> // TypeDefIndex: 54699
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
		} // 0x0000000185FDE200-0x0000000185FDE210
		public bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDE170-0x0000000185FDE1C0
		public bool2x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDE1C0-0x0000000185FDE200
	
		// Methods
		public bool Equals(bool2x3 rhs) => default; // 0x000000018BD72950-0x000000018BD72B58
		public override bool Equals(object o) => default; // 0x000000018BD78FEC-0x000000018BD7905C
		public override int GetHashCode() => default; // 0x000000018BD7905C-0x000000018BD79080
		public override string ToString() => default; // 0x000000018BD79080-0x000000018BD79248
	}

	[Serializable]
	public struct bool2x4 : IEquatable<Unity.Mathematics.bool2x4> // TypeDefIndex: 54700
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
		} // 0x0000000185FDE2C0-0x0000000185FDE2E0
		public bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDE210-0x0000000185FDE270
		public bool2x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDE270-0x0000000185FDE2C0
	
		// Methods
		public bool Equals(bool2x4 rhs) => default; // 0x000000018BD72B58-0x000000018BD72DE0
		public override bool Equals(object o) => default; // 0x000000018BD79248-0x000000018BD792A8
		public override int GetHashCode() => default; // 0x000000018BD792A8-0x000000018BD792B0
		public override string ToString() => default; // 0x000000018BD792B0-0x000000018BD794E0
	}

	[Serializable]
	public struct bool3 : IEquatable<Unity.Mathematics.bool3> // TypeDefIndex: 54702
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
		public bool z; // 0x02
	
		// Properties
		public bool this[int index] { get => default; set {} } // 0x000000018464EA70-0x000000018464EA80 0x0000000185FBFE20-0x0000000185FBFE30
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54701
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public bool3(bool x, bool y, bool z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000185FCC280-0x0000000185FCC290
		public bool3(bool x, bool2 yz) : this() {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000185FDE2F0-0x0000000185FDE300
		public bool3(bool2 xy, bool z) : this() {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000185FDE300-0x0000000185FDE310
		public bool3(bool3 xyz) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FDE310-0x0000000185FDE330
		public bool3(bool v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FDE2E0-0x0000000185FDE2F0
	
		// Methods
		public static implicit operator bool3(bool v) => default; // 0x0000000185FD9500-0x0000000185FD9510
		public static bool3 operator &(bool3 lhs, bool3 rhs) => default; // 0x0000000184FB1C00-0x0000000184FB1C30
		public static bool3 operator |(bool3 lhs, bool3 rhs) => default; // 0x000000018BD79628-0x000000018BD79658
		public bool Equals(bool3 rhs) => default; // 0x000000018BD72DE0-0x000000018BD73754
		public override bool Equals(object o) => default; // 0x000000018BD794E0-0x000000018BD79550
		public override int GetHashCode() => default; // 0x000000018BD79550-0x000000018BD79574
		public override string ToString() => default; // 0x000000018BD79574-0x000000018BD79628
	}

	[Serializable]
	public struct bool3x2 : IEquatable<Unity.Mathematics.bool3x2> // TypeDefIndex: 54703
	{
		// Fields
		public bool3 c0; // 0x00
		public bool3 c1; // 0x03
	
		// Constructors
		public bool3x2(bool3 c0, bool3 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000185FDE3A0-0x0000000185FDE3C0
		public bool3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDE330-0x0000000185FDE370
		public bool3x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDE370-0x0000000185FDE3A0
	
		// Methods
		public bool Equals(bool3x2 rhs) => default; // 0x000000018BD796C8-0x000000018BD79714
		public override bool Equals(object o) => default; // 0x000000018BD79658-0x000000018BD796C8
		public override int GetHashCode() => default; // 0x000000018BD79714-0x000000018BD79738
		public override string ToString() => default; // 0x000000018BD79738-0x000000018BD79900
	}

	[Serializable]
	public struct bool3x3 : IEquatable<Unity.Mathematics.bool3x3> // TypeDefIndex: 54704
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
		} // 0x0000000185FDE470-0x0000000185FDE4A0
		public bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDE400-0x0000000185FDE470
		public bool3x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDE3C0-0x0000000185FDE400
	
		// Methods
		public bool Equals(bool3x3 rhs) => default; // 0x000000018BD79974-0x000000018BD799E8
		public override bool Equals(object o) => default; // 0x000000018BD79900-0x000000018BD79974
		public override int GetHashCode() => default; // 0x000000018BD799E8-0x000000018BD79A10
		public override string ToString() => default; // 0x000000018BD79A10-0x000000018BD79C74
	}

	[Serializable]
	public struct bool3x4 : IEquatable<Unity.Mathematics.bool3x4> // TypeDefIndex: 54705
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
		} // 0x0000000185FDE580-0x0000000185FDE5D0
		public bool3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDE4F0-0x0000000185FDE580
		public bool3x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDE4A0-0x0000000185FDE4F0
	
		// Methods
		public bool Equals(bool3x4 rhs) => default; // 0x000000018BD79C74-0x000000018BD79D08
		public override bool Equals(object o) => default; // 0x000000018BD79D08-0x000000018BD79D7C
		public override int GetHashCode() => default; // 0x000000018BD79D7C-0x000000018BD79DA0
		public override string ToString() => default; // 0x000000018BD79DA0-0x000000018BD7A0A0
	}

	[Serializable]
	public struct bool4 : IEquatable<Unity.Mathematics.bool4> // TypeDefIndex: 54707
	{
		// Fields
		public bool x; // 0x00
		public bool y; // 0x01
		public bool z; // 0x02
		public bool w; // 0x03
	
		// Properties
		public bool this[int index] { set {} } // 0x0000000185FBFE20-0x0000000185FBFE30
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54706
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
		} // 0x0000000185FD7200-0x0000000185FD7220
		public bool4(bool x, bool y, bool2 zw) : this() {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000185FDE6A0-0x0000000185FDE6C0
		public bool4(bool x, bool2 yz, bool w) : this() {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FDE600-0x0000000185FDE620
		public bool4(bool x, bool3 yzw) : this() {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDE620-0x0000000185FDE640
		public bool4(bool2 xy, bool z, bool w) : this() {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000185FDE640-0x0000000185FDE660
		public bool4(bool2 xy, bool2 zw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDE660-0x0000000185FDE680
		public bool4(bool3 xyz, bool w) : this() {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FDE680-0x0000000185FDE6A0
		public bool4(bool4 xyzw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDE5D0-0x0000000185FDE5F0
		public bool4(bool v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDE5F0-0x0000000185FDE600
	
		// Methods
		public static implicit operator bool4(bool v) => default; // 0x0000000185FD9690-0x0000000185FD96B0
		public bool Equals(bool4 rhs) => default; // 0x000000018BD73754-0x000000018BD738DC
		public override bool Equals(object o) => default; // 0x000000018BD7A0A0-0x000000018BD7A100
		public override int GetHashCode() => default; // 0x000000018BD7A100-0x000000018BD7A108
		public override string ToString() => default; // 0x000000018BD7A108-0x000000018BD7A264
	}

	[Serializable]
	public struct bool4x2 : IEquatable<Unity.Mathematics.bool4x2> // TypeDefIndex: 54708
	{
		// Fields
		public bool4 c0; // 0x00
		public bool4 c1; // 0x04
	
		// Constructors
		public bool4x2(bool4 c0, bool4 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x000000018357CB90-0x000000018357CBA0
		public bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDE6F0-0x0000000185FDE740
		public bool4x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDE6C0-0x0000000185FDE6F0
	
		// Methods
		public bool Equals(bool4x2 rhs) => default; // 0x000000018BD738DC-0x000000018BD742A0
		public override bool Equals(object o) => default; // 0x000000018BD7A264-0x000000018BD7A2C4
		public override int GetHashCode() => default; // 0x000000018BD7A2C4-0x000000018BD7A2CC
		public override string ToString() => default; // 0x000000018BD7A2CC-0x000000018BD7A4FC
	}

	[Serializable]
	public struct bool4x3 : IEquatable<Unity.Mathematics.bool4x3> // TypeDefIndex: 54709
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
		} // 0x0000000185FB0130-0x0000000185FB0140
		public bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDE740-0x0000000185FDE7C0
		public bool4x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDE7C0-0x0000000185FDE810
	
		// Methods
		public bool Equals(bool4x3 rhs) => default; // 0x000000018BD7A570-0x000000018BD7A5B0
		public override bool Equals(object o) => default; // 0x000000018BD7A4FC-0x000000018BD7A570
		public override int GetHashCode() => default; // 0x000000018BD7A5B0-0x000000018BD7A5D4
		public override string ToString() => default; // 0x000000018BD7A5D4-0x000000018BD7A8D4
	}

	[Serializable]
	public struct bool4x4 : IEquatable<Unity.Mathematics.bool4x4> // TypeDefIndex: 54710
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
		} // 0x0000000185FB2C50-0x0000000185FB2C70
		public bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDE810-0x0000000185FDE8C0
		public bool4x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDE8C0-0x0000000185FDE920
	
		// Methods
		public bool Equals(bool4x4 rhs) => default; // 0x000000018BD7A940-0x000000018BD7A990
		public override bool Equals(object o) => default; // 0x000000018BD7A8D4-0x000000018BD7A940
		public override int GetHashCode() => default; // 0x000000018BD7A990-0x000000018BD7A9AC
		public override string ToString() => default; // 0x000000018BD7A9AC-0x000000018BD7AD7C
	}

	[Serializable]
	public struct double2 : IEquatable<Unity.Mathematics.double2>, IFormattable // TypeDefIndex: 54712
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54711
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public double2(double x, double y) {
			this.x = default;
			this.y = default;
		} // 0x0000000185FB20C0-0x0000000185FB20D0
		public double2(double2 xy) {
			x = default;
			y = default;
		} // 0x0000000185FB20B0-0x0000000185FB20C0
		public double2(double v) {
			x = default;
			y = default;
		} // 0x0000000185FDE970-0x0000000185FDE980
		public double2(bool v) {
			x = default;
			y = default;
		} // 0x000000018BD7AF7C-0x000000018BD7AF90
		public double2(bool2 v) {
			x = default;
			y = default;
		} // 0x0000000186F0EF90-0x0000000186F0EFF8
		public double2(int v) {
			x = default;
			y = default;
		} // 0x0000000185FDE9A0-0x0000000185FDE9C0
		public double2(int2 v) {
			x = default;
			y = default;
		} // 0x0000000185FDE950-0x0000000185FDE970
		public double2(uint v) {
			x = default;
			y = default;
		} // 0x0000000185FDE980-0x0000000185FDE9A0
		public double2(uint2 v) {
			x = default;
			y = default;
		} // 0x0000000185FDE9C0-0x0000000185FDE9E0
		public double2(half v) {
			x = default;
			y = default;
		} // 0x000000018BD7AF40-0x000000018BD7AF7C
		public double2(half2 v) {
			x = default;
			y = default;
		} // 0x000000018BD7AF00-0x000000018BD7AF40
		public double2(float v) {
			x = default;
			y = default;
		} // 0x0000000185FDE9E0-0x0000000185FDE9F0
		public double2(float2 v) {
			x = default;
			y = default;
		} // 0x0000000185FDE920-0x0000000185FDE950
	
		// Methods
		public static implicit operator double2(double v) => default; // 0x0000000185FDAB90-0x0000000185FDABA0
		public static implicit operator double2(int v) => default; // 0x0000000185FDAB30-0x0000000185FDAB50
		public static implicit operator double2(int2 v) => default; // 0x0000000185FDAAD0-0x0000000185FDAB00
		public static implicit operator double2(uint v) => default; // 0x0000000185FDAA70-0x0000000185FDAAA0
		public static implicit operator double2(uint2 v) => default; // 0x0000000185FDAB00-0x0000000185FDAB30
		public static implicit operator double2(float v) => default; // 0x0000000185FDAB50-0x0000000185FDAB70
		public static implicit operator double2(float2 v) => default; // 0x0000000185FDAAA0-0x0000000185FDAAD0
		public static double2 operator *(double2 lhs, double2 rhs) => default; // 0x0000000185FDEA20-0x0000000185FDEA50
		public static double2 operator *(double2 lhs, double rhs) => default; // 0x0000000185FDEA70-0x0000000185FDEA90
		public static double2 operator *(double lhs, double2 rhs) => default; // 0x0000000185FDEA50-0x0000000185FDEA70
		public static double2 operator +(double2 lhs, double2 rhs) => default; // 0x0000000185FDE9F0-0x0000000185FDEA20
		public static double2 operator -(double2 lhs, double2 rhs) => default; // 0x0000000185FDEAB0-0x0000000185FDEAE0
		public static double2 operator -(double lhs, double2 rhs) => default; // 0x0000000185FDEA90-0x0000000185FDEAB0
		public static double2 operator /(double2 lhs, double2 rhs) => default; // 0x000000018BD7AFAC-0x000000018BD7AFD0
		public static double2 operator /(double lhs, double2 rhs) => default; // 0x000000018BD7AF90-0x000000018BD7AFAC
		public static bool2 operator <(double2 lhs, double rhs) => default; // 0x000000018BD7B028-0x000000018BD7B044
		public static bool2 operator >=(double2 lhs, double2 rhs) => default; // 0x000000018BD7B004-0x000000018BD7B028
		public static double2 operator -(double2 val) => default; // 0x0000000185FDEAE0-0x0000000185FDEB00
		public static bool2 operator ==(double2 lhs, double rhs) => default; // 0x000000018BD7AFD0-0x000000018BD7B004
		public bool Equals(double2 rhs) => default; // 0x000000018BD742A0-0x000000018BD783F8
		public override bool Equals(object o) => default; // 0x000000018BD7AD7C-0x000000018BD7ADE8
		public override int GetHashCode() => default; // 0x000000018BD50AD8-0x000000018BD50B20
		public override string ToString() => default; // 0x000000018BD7AE70-0x000000018BD7AF00
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7ADE8-0x000000018BD7AE70
	}

	[Serializable]
	public struct double2x2 : IEquatable<Unity.Mathematics.double2x2>, IFormattable // TypeDefIndex: 54713
	{
		// Fields
		public double2 c0; // 0x00
		public double2 c1; // 0x10
		public static readonly double2x2 identity; // 0x00
	
		// Constructors
		public double2x2(double2 c0, double2 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000185FB6710-0x0000000185FB6720
		public double2x2(double m00, double m01, double m10, double m11) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDEB50-0x0000000185FDEB70
		public double2x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDEB30-0x0000000185FDEB50
		public double2x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F0F078-0x0000000186F0F104
		public double2x2(bool2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F0EFF8-0x0000000186F0F078
		public double2x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDEB00-0x0000000185FDEB30
		public double2x2(int2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDEC70-0x0000000185FDECC0
		public double2x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDEB70-0x0000000185FDEBB0
		public double2x2(uint2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDEBF0-0x0000000185FDEC40
		public double2x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDEC40-0x0000000185FDEC70
		public double2x2(float2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDEBB0-0x0000000185FDEBF0
		static double2x2() {
			identity = default;
		} // 0x0000000185F41890-0x0000000185F41900
	
		// Methods
		public static double2x2 operator *(double2x2 lhs, double rhs) => default; // 0x000000018BD7B3E4-0x000000018BD7B440
		public bool Equals(double2x2 rhs) => default; // 0x000000018BD7B044-0x000000018BD7B08C
		public override bool Equals(object o) => default; // 0x000000018BD7B08C-0x000000018BD7B100
		public override int GetHashCode() => default; // 0x000000018BD7B100-0x000000018BD7B124
		public override string ToString() => default; // 0x000000018BD7B124-0x000000018BD7B290
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7B290-0x000000018BD7B3E4
	}

	[Serializable]
	public struct double2x3 : IEquatable<Unity.Mathematics.double2x3>, IFormattable // TypeDefIndex: 54714
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
		} // 0x0000000185FCC290-0x0000000185FCC2B0
		public double2x3(double m00, double m01, double m02, double m10, double m11, double m12) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDEE20-0x0000000185FDEE50
		public double2x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDEDB0-0x0000000185FDEDD0
		public double2x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F0F104-0x0000000186F0F138
		public double2x3(bool2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F0F138-0x0000000186F0F1E8
		public double2x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDEF10-0x0000000185FDEF60
		public double2x3(int2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDECC0-0x0000000185FDED30
		public double2x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDEEB0-0x0000000185FDEF10
		public double2x3(uint2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDED30-0x0000000185FDEDB0
		public double2x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDEDD0-0x0000000185FDEE20
		public double2x3(float2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDEE50-0x0000000185FDEEB0
	
		// Methods
		public bool Equals(double2x3 rhs) => default; // 0x000000018BD7B440-0x000000018BD7B4A0
		public override bool Equals(object o) => default; // 0x000000018BD7B4A0-0x000000018BD7B51C
		public override int GetHashCode() => default; // 0x000000018BD7B51C-0x000000018BD7B54C
		public override string ToString() => default; // 0x000000018BD7B700-0x000000018BD7B8E0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7B54C-0x000000018BD7B700
	}

	[Serializable]
	public struct double2x4 : IEquatable<Unity.Mathematics.double2x4>, IFormattable // TypeDefIndex: 54715
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
		} // 0x0000000185FDF130-0x0000000185FDF160
		public double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDF160-0x0000000185FDF1B0
		public double2x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDF1B0-0x0000000185FDF1D0
		public double2x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F0F2C8-0x0000000186F0F30C
		public double2x4(bool2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F0F1E8-0x0000000186F0F2C8
		public double2x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDF060-0x0000000185FDF0C0
		public double2x4(int2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDF250-0x0000000185FDF2E0
		public double2x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDF1D0-0x0000000185FDF250
		public double2x4(uint2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDEFC0-0x0000000185FDF060
		public double2x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDEF60-0x0000000185FDEFC0
		public double2x4(float2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDF0C0-0x0000000185FDF130
	
		// Methods
		public bool Equals(double2x4 rhs) => default; // 0x000000018BD7B8E0-0x000000018BD7B95C
		public override bool Equals(object o) => default; // 0x000000018BD7B95C-0x000000018BD7B9E0
		public override int GetHashCode() => default; // 0x000000018BD7B9E0-0x000000018BD7BA18
		public override string ToString() => default; // 0x000000018BD7BC2C-0x000000018BD7BE7C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7BA18-0x000000018BD7BC2C
	}

	[Serializable]
	public struct double3 : IEquatable<Unity.Mathematics.double3>, IFormattable // TypeDefIndex: 54717
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
		public static readonly double3 zero; // 0x00
	
		// Properties
		public double3 yzx { get => default; } // 0x0000000185FDF450-0x0000000185FDF470 
		public double3 zxy { get => default; } // 0x0000000185FDF470-0x0000000185FDF490 
		public double this[int index] { get => default; } // 0x0000000185FDF440-0x0000000185FDF450 
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54716
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public double3(double x, double y, double z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000185FDF430-0x0000000185FDF440
		public double3(double x, double2 yz) : this() {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000185FDF360-0x0000000185FDF380
		public double3(double2 xy, double z) : this() {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000185FDF320-0x0000000185FDF340
		public double3(double3 xyz) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FDF3A0-0x0000000185FDF3C0
		public double3(double v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FDF3C0-0x0000000185FDF3D0
		public double3(bool v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000186F0F348-0x0000000186F0F5EC
		public double3(bool3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000186F0F30C-0x0000000186F0F348
		public double3(int v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FDF380-0x0000000185FDF3A0
		public double3(int3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FDF340-0x0000000185FDF360
		public double3(uint v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FDF3D0-0x0000000185FDF400
		public double3(uint3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FDF400-0x0000000185FDF430
		public double3(half v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD7C088-0x000000018BD7C0D8
		public double3(half3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD7C0D8-0x000000018BD7C12C
		public double3(float v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FDF300-0x0000000185FDF320
		public double3(float3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FDF2E0-0x0000000185FDF300
	
		// Methods
		public static implicit operator double3(double v) => default; // 0x0000000185FDAD50-0x0000000185FDAD60
		public static implicit operator double3(int v) => default; // 0x0000000185FDAE10-0x0000000185FDAE40
		public static implicit operator double3(int3 v) => default; // 0x0000000185FDACB0-0x0000000185FDAD00
		public static implicit operator double3(uint v) => default; // 0x0000000185FDAD00-0x0000000185FDAD30
		public static implicit operator double3(uint3 v) => default; // 0x0000000185FDAD80-0x0000000185FDADE0
		public static implicit operator double3(float v) => default; // 0x0000000185FDAC80-0x0000000185FDACB0
		public static implicit operator double3(float3 v) => default; // 0x000000018533B190-0x000000018533B1D0
		public static double3 operator *(double3 lhs, double3 rhs) => default; // 0x0000000185FDF530-0x0000000185FDF570
		public static double3 operator *(double3 lhs, double rhs) => default; // 0x0000000185FDF510-0x0000000185FDF530
		public static double3 operator *(double lhs, double3 rhs) => default; // 0x0000000185FDF4F0-0x0000000185FDF510
		public static double3 operator +(double3 lhs, double3 rhs) => default; // 0x0000000185FDF4B0-0x0000000185FDF4F0
		public static double3 operator +(double3 lhs, double rhs) => default; // 0x0000000185FDF490-0x0000000185FDF4B0
		public static double3 operator -(double3 lhs, double3 rhs) => default; // 0x0000000185FDF590-0x0000000185FDF5D0
		public static double3 operator -(double3 lhs, double rhs) => default; // 0x0000000185FDF570-0x0000000185FDF590
		public static double3 operator -(double lhs, double3 rhs) => default; // 0x0000000185FDF5D0-0x0000000185FDF600
		public static double3 operator /(double3 lhs, double3 rhs) => default; // 0x000000018BD7C12C-0x000000018BD7C160
		public static double3 operator /(double3 lhs, double rhs) => default; // 0x000000018BD7C160-0x000000018BD7C180
		public static double3 operator /(double lhs, double3 rhs) => default; // 0x000000018BD7C180-0x000000018BD7C1AC
		public static bool3 operator <(double3 lhs, double rhs) => default; // 0x000000018BD7C268-0x000000018BD7C28C
		public static bool3 operator <=(double3 lhs, double3 rhs) => default; // 0x000000018BD7C22C-0x000000018BD7C268
		public static bool3 operator >=(double3 lhs, double3 rhs) => default; // 0x000000018BD7C1F4-0x000000018BD7C22C
		public static double3 operator -(double3 val) => default; // 0x0000000185FDF600-0x0000000185FDF630
		public static bool3 operator ==(double3 lhs, double rhs) => default; // 0x000000018BD7C1AC-0x000000018BD7C1F4
		public bool Equals(double3 rhs) => default; // 0x00000001876F2E90-0x00000001876F3178
		public override bool Equals(object o) => default; // 0x000000018BD7BE7C-0x000000018BD7BEF0
		public override int GetHashCode() => default; // 0x000000018BD7BEF0-0x000000018BD7BF18
		public override string ToString() => default; // 0x000000018BD7BFC8-0x000000018BD7C088
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7BF18-0x000000018BD7BFC8
	}

	[Serializable]
	public struct double3x2 : IEquatable<Unity.Mathematics.double3x2>, IFormattable // TypeDefIndex: 54718
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
	
		// Constructors
		public double3x2(double3 c0, double3 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000185FCC230-0x0000000185FCC260
		public double3x2(double m00, double m01, double m10, double m11, double m20, double m21) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDF670-0x0000000185FDF6B0
		public double3x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDF710-0x0000000185FDF740
		public double3x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F0F7E4-0x0000000186F0F8B8
		public double3x2(bool3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD7C6CC-0x000000018BD7C7D0
		public double3x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDF740-0x0000000185FDF790
		public double3x2(int3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F0F8B8-0x0000000186F0F930
		public double3x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDF6B0-0x0000000185FDF710
		public double3x2(uint3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F0F5EC-0x0000000186F0F664
		public double3x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FDF630-0x0000000185FDF670
		public double3x2(float3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F0F664-0x0000000186F0F7E4
	
		// Methods
		public static implicit operator double3x2(int v) => default; // 0x000000018BD4AA3C-0x000000018BD4AA5C
		public static implicit operator double3x2(float3x2 v) => default; // 0x000000018BD4A8E8-0x000000018BD4A924
		public static double3x2 operator *(double3x2 lhs, double rhs) => default; // 0x000000018BD7C928-0x000000018BD7C9AC
		public static double3x2 operator +(double3x2 lhs, double3x2 rhs) => default; // 0x000000018BD7C7D0-0x000000018BD7C894
		public static double3x2 operator -(double3x2 lhs, double3x2 rhs) => default; // 0x000000018BD7C9AC-0x000000018BD7CA70
		public static double3x2 operator /(double3x2 lhs, double rhs) => default; // 0x000000018BD7C894-0x000000018BD7C928
		public bool Equals(double3x2 rhs) => default; // 0x000000018773A0E4-0x000000018773A154
		public override bool Equals(object o) => default; // 0x000000018BD7C28C-0x000000018BD7C308
		public override int GetHashCode() => default; // 0x000000018BD7C308-0x000000018BD7C338
		public override string ToString() => default; // 0x000000018BD7C4EC-0x000000018BD7C6CC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7C338-0x000000018BD7C4EC
	}

	[Serializable]
	public struct double3x3 : IEquatable<Unity.Mathematics.double3x3>, IFormattable // TypeDefIndex: 54719
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
		public double3 c2; // 0x30
		public static readonly double3x3 identity; // 0x00
	
		// Properties
		public ref double3 this[int index] { get => default; } // 0x0000000185FDF9D0-0x0000000185FDF9E0 
	
		// Constructors
		public double3x3(double3 c0, double3 c1, double3 c2) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000185FDF7F0-0x0000000185FDF830
		public double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDF970-0x0000000185FDF9D0
		public double3x3(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDF830-0x0000000185FDF870
		public double3x3(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F0FC98-0x0000000186F0FF9C
		public double3x3(bool3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD7D0A8-0x000000018BD7D214
		public double3x3(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDF900-0x0000000185FDF970
		public double3x3(int3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F0FBF0-0x0000000186F0FC98
		public double3x3(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDF870-0x0000000185FDF900
		public double3x3(uint3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F0FB48-0x0000000186F0FBF0
		public double3x3(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FDF790-0x0000000185FDF7F0
		public double3x3(float3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F0F930-0x0000000186F0FB48
		static double3x3() {
			identity = default;
		} // 0x0000000185D90050-0x0000000185D90120
	
		// Methods
		public static double3x3 operator *(double3x3 lhs, double rhs) => default; // 0x000000018BD7D214-0x000000018BD7D2D8
		public bool Equals(double3x3 rhs) => default; // 0x000000018BD7CB04-0x000000018BD7CB98
		public override bool Equals(object o) => default; // 0x000000018BD7CA70-0x000000018BD7CB04
		public override int GetHashCode() => default; // 0x000000018BD7CB98-0x000000018BD7CBDC
		public override string ToString() => default; // 0x000000018BD7CBDC-0x000000018BD7CE64
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7CE64-0x000000018BD7D0A8
	}

	[Serializable]
	public struct double3x4 : IEquatable<Unity.Mathematics.double3x4>, IFormattable // TypeDefIndex: 54720
	{
		// Fields
		public double3 c0; // 0x00
		public double3 c1; // 0x18
		public double3 c2; // 0x30
		public double3 c3; // 0x48
	
		// Properties
		public ref double3 this[int index] { get => default; } // 0x0000000185FDF9D0-0x0000000185FDF9E0 
	
		// Constructors
		public double3x4(double3 c0, double3 c1, double3 c2, double3 c3) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000185FDF9E0-0x0000000185FDFA30
		public double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDFA30-0x0000000185FDFAB0
		public double3x4(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDFBF0-0x0000000185FDFC40
		public double3x4(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F10154-0x0000000186F102D0
		public double3x4(bool3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD7DAB0-0x000000018BD7DC88
		public double3x4(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDFAB0-0x0000000185FDFB30
		public double3x4(int3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F10078-0x0000000186F10154
		public double3x4(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDFB30-0x0000000185FDFBF0
		public double3x4(uint3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F0FF9C-0x0000000186F10078
		public double3x4(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FDFC40-0x0000000185FDFCC0
		public double3x4(float3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F102D0-0x0000000186F103AC
	
		// Methods
		public static implicit operator double3x4(int v) => default; // 0x000000018BD4AC54-0x000000018BD4AC80
		public bool Equals(double3x4 rhs) => default; // 0x000000018BD7D2D8-0x000000018BD7D3C0
		public override bool Equals(object o) => default; // 0x000000018BD7D3C0-0x000000018BD7D460
		public override int GetHashCode() => default; // 0x000000018BD7D460-0x000000018BD7D4AC
		public override string ToString() => default; // 0x000000018BD7D780-0x000000018BD7DAB0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7D4AC-0x000000018BD7D780
	}

	[Serializable]
	public struct double4 : IEquatable<Unity.Mathematics.double4>, IFormattable // TypeDefIndex: 54722
	{
		// Fields
		public double x; // 0x00
		public double y; // 0x08
		public double z; // 0x10
		public double w; // 0x18
		public static readonly double4 zero; // 0x00
	
		// Properties
		public double3 xyz { get => default; set {} } // 0x0000000185FDFEC0-0x0000000185FDFEE0 0x0000000185FDF3A0-0x0000000185FDF3C0
		public double this[int index] { get => default; set {} } // 0x0000000185FDF440-0x0000000185FDF450 0x0000000185FE0070-0x0000000185FE0080
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54721
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
		} // 0x0000000185FDFD80-0x0000000185FDFDA0
		public double4(double x, double y, double2 zw) : this() {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000185FDFD00-0x0000000185FDFD20
		public double4(double x, double2 yz, double w) : this() {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FDFD20-0x0000000185FDFD40
		public double4(double x, double3 yzw) : this() {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDFD60-0x0000000185FDFD80
		public double4(double2 xy, double z, double w) : this() {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000185FDFE60-0x0000000185FDFE80
		public double4(double2 xy, double2 zw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDFD40-0x0000000185FDFD60
		public double4(double3 xyz, double w) : this() {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FDFE40-0x0000000185FDFE60
		public double4(double4 xyzw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDFCE0-0x0000000185FDFD00
		public double4(double v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDFE80-0x0000000185FDFE90
		public double4(bool v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000186F10420-0x0000000186F10464
		public double4(bool4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000186F104C8-0x0000000186F10878
		public double4(int v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDFDA0-0x0000000185FDFDD0
		public double4(int4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDFE20-0x0000000185FDFE40
		public double4(uint v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDFE90-0x0000000185FDFEC0
		public double4(uint4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDFDD0-0x0000000185FDFE10
		public double4(half v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000186F10464-0x0000000186F104C8
		public double4(half4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000186F103AC-0x0000000186F10420
		public double4(float v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDFCC0-0x0000000185FDFCE0
		public double4(float4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FDFE10-0x0000000185FDFE20
	
		// Methods
		public static implicit operator double4(double v) => default; // 0x0000000185FDAF60-0x0000000185FDAF70
		public static implicit operator double4(int v) => default; // 0x0000000185FDAFC0-0x0000000185FDB000
		public static implicit operator double4(int4 v) => default; // 0x000000018BD4AEC8-0x000000018BD4AEF0
		public static implicit operator double4(uint v) => default; // 0x0000000185FDB080-0x0000000185FDB0B0
		public static implicit operator double4(uint4 v) => default; // 0x000000018BD4AEF0-0x000000018BD4AF18
		public static implicit operator double4(float v) => default; // 0x0000000185FDAF70-0x0000000185FDAF90
		public static implicit operator double4(float4 v) => default; // 0x000000018BD4AE84-0x000000018BD4AEAC
		public static double4 operator *(double4 lhs, double4 rhs) => default; // 0x0000000185FDFF50-0x0000000185FDFFA0
		public static double4 operator *(double4 lhs, double rhs) => default; // 0x0000000185FDFF30-0x0000000185FDFF50
		public static double4 operator *(double lhs, double4 rhs) => default; // 0x0000000185FDFFA0-0x0000000185FDFFC0
		public static double4 operator +(double4 lhs, double4 rhs) => default; // 0x0000000185FDFEE0-0x0000000185FDFF30
		public static double4 operator -(double4 lhs, double4 rhs) => default; // 0x0000000185FE0000-0x0000000185FE0050
		public static double4 operator -(double lhs, double4 rhs) => default; // 0x0000000185FDFFC0-0x0000000185FE0000
		public static double4 operator /(double4 lhs, double4 rhs) => default; // 0x000000018BD7E028-0x000000018BD7E06C
		public static double4 operator /(double lhs, double4 rhs) => default; // 0x000000018BD7E06C-0x000000018BD7E0A4
		public static bool4 operator <(double4 lhs, double rhs) => default; // 0x000000018BD7E150-0x000000018BD7E17C
		public static bool4 operator >=(double4 lhs, double4 rhs) => default; // 0x000000018BD7E108-0x000000018BD7E150
		public static double4 operator -(double4 val) => default; // 0x0000000185FE0050-0x0000000185FE0070
		public static bool4 operator ==(double4 lhs, double rhs) => default; // 0x000000018BD7E0A4-0x000000018BD7E108
		public bool Equals(double4 rhs) => default; // 0x000000018BD7DCFC-0x000000018BD7DD44
		public override bool Equals(object o) => default; // 0x000000018BD7DC88-0x000000018BD7DCFC
		public override int GetHashCode() => default; // 0x000000018BD7DD44-0x000000018BD7DD68
		public override string ToString() => default; // 0x000000018BD7DD68-0x000000018BD7DED4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7DED4-0x000000018BD7E028
	}

	[Serializable]
	public struct double4x2 : IEquatable<Unity.Mathematics.double4x2>, IFormattable // TypeDefIndex: 54723
	{
		// Fields
		public double4 c0; // 0x00
		public double4 c1; // 0x20
	
		// Constructors
		public double4x2(double4 c0, double4 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000185FE0140-0x0000000185FE0160
		public double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE0080-0x0000000185FE00D0
		public double4x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE00D0-0x0000000185FE0100
		public double4x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F109C4-0x0000000186F10C74
		public double4x2(bool4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F10920-0x0000000186F109C4
		public double4x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE0160-0x0000000185FE01B0
		public double4x2(int4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD7E700-0x000000018BD7E764
		public double4x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F10878-0x0000000186F10920
		public double4x2(uint4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD7E764-0x000000018BD7E7C8
		public double4x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE0100-0x0000000185FE0140
		public double4x2(float4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD7E7C8-0x000000018BD7E82C
	
		// Methods
		public bool Equals(double4x2 rhs) => default; // 0x000000018BD7E200-0x000000018BD7E264
		public override bool Equals(object o) => default; // 0x000000018BD7E17C-0x000000018BD7E200
		public override int GetHashCode() => default; // 0x000000018BD7E264-0x000000018BD7E29C
		public override string ToString() => default; // 0x000000018BD7E4B0-0x000000018BD7E700
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7E29C-0x000000018BD7E4B0
	}

	[Serializable]
	public struct double4x3 : IEquatable<Unity.Mathematics.double4x3>, IFormattable // TypeDefIndex: 54724
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
		} // 0x0000000185FE0360-0x0000000185FE03A0
		public double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE0260-0x0000000185FE02F0
		public double4x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE01B0-0x0000000185FE0200
		public double4x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F10DA8-0x0000000186F10F60
		public double4x3(bool4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F10CD0-0x0000000186F10DA8
		public double4x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE02F0-0x0000000185FE0360
		public double4x3(int4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD7F02C-0x000000018BD7F0BC
		public double4x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F10C74-0x0000000186F10CD0
		public double4x3(uint4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD7F0BC-0x000000018BD7F14C
		public double4x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE0200-0x0000000185FE0260
		public double4x3(float4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD7EF9C-0x000000018BD7F02C
	
		// Methods
		public static implicit operator double4x3(int v) => default; // 0x000000018BD4B128-0x000000018BD4B154
		public static implicit operator double4x3(float4x3 v) => default; // 0x000000018BD4B22C-0x000000018BD4B27C
		public static double4x3 operator *(double4x3 lhs, double4x3 rhs) => default; // 0x000000018BD7F14C-0x000000018BD7F254
		public bool Equals(double4x3 rhs) => default; // 0x000000018BD7E82C-0x000000018BD7E8AC
		public override bool Equals(object o) => default; // 0x000000018BD7E8AC-0x000000018BD7E94C
		public override int GetHashCode() => default; // 0x000000018BD7E94C-0x000000018BD7E998
		public override string ToString() => default; // 0x000000018BD7EC6C-0x000000018BD7EF9C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7E998-0x000000018BD7EC6C
	}

	[Serializable]
	public struct double4x4 : IEquatable<Unity.Mathematics.double4x4>, IFormattable // TypeDefIndex: 54725
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
		} // 0x0000000185FE0470-0x0000000185FE04C0
		public double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185C3B7B0-0x0000000185C3B880
		public double4x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE0410-0x0000000185FE0470
		public double4x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F10F60-0x0000000186F10FC8
		public double4x4(bool4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F11040-0x0000000186F11208
		public double4x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE04C0-0x0000000185FE0550
		public double4x4(int4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD7FD18-0x000000018BD7FDCC
		public double4x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F10FC8-0x0000000186F11040
		public double4x4(uint4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD7FC64-0x000000018BD7FD18
		public double4x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE03A0-0x0000000185FE0410
		public double4x4(float4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD7FBB0-0x000000018BD7FC64
		static double4x4() {
			identity = default;
			zero = default;
		} // 0x0000000185C3B680-0x0000000185C3B7B0
	
		// Methods
		public static implicit operator double4x4(float4x4 v) => default; // 0x000000018BD4B3D4-0x000000018BD4B430
		public bool Equals(double4x4 rhs) => default; // 0x000000018BD7F254-0x000000018BD7F2F8
		public override bool Equals(object o) => default; // 0x000000018BD7F2F8-0x000000018BD7F3B0
		public override int GetHashCode() => default; // 0x000000018BD7F3B0-0x000000018BD7F40C
		public override string ToString() => default; // 0x000000018BD7F7A0-0x000000018BD7FBB0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7F40C-0x000000018BD7F7A0
	}

	[Serializable]
	public struct float2 : IEquatable<Unity.Mathematics.float2>, IFormattable // TypeDefIndex: 54727
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public static readonly float2 zero; // 0x00
	
		// Properties
		public float4 xyxy { get => default; } // 0x0000000185FE0660-0x0000000185FE0680 
		public float2 xy { get => default; } // 0x0000000185FB29D0-0x0000000185FB29F0 
		public float2 yx { get => default; } // 0x0000000185FE0680-0x0000000185FE06A0 
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54726
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public float2(float x, float y) : this() {
			this.x = default;
			this.y = default;
		} // 0x0000000185FB1970-0x0000000185FB1980
		public float2(float2 xy) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE0590-0x0000000185FE05B0
		public float2(float v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE0550-0x0000000185FE0560
		public float2(bool v) : this() {
			x = default;
			y = default;
		} // 0x000000018BD7FF88-0x000000018BD7FFA4
		public float2(bool2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000186F11208-0x0000000186F112C0
		public float2(int v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE0600-0x0000000185FE0620
		public float2(int2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE05E0-0x0000000185FE0600
		public float2(uint v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE05B0-0x0000000185FE05E0
		public float2(uint2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE0560-0x0000000185FE0590
		public float2(half v) : this() {
			x = default;
			y = default;
		} // 0x000000018BD7FFA4-0x000000018BD7FFD0
		public float2(half2 v) : this() {
			x = default;
			y = default;
		} // 0x000000018BD7FFD0-0x000000018BD80000
		public float2(double v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE0620-0x0000000185FE0640
		public float2(double2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE0640-0x0000000185FE0660
	
		// Methods
		public static implicit operator float2(float v) => default; // 0x0000000185FB56E0-0x0000000185FB56F0
		public static implicit operator float2(int v) => default; // 0x0000000185FDB3C0-0x0000000185FDB3E0
		public static implicit operator float2(int2 v) => default; // 0x0000000185FDB3E0-0x0000000185FDB400
		public static implicit operator float2(uint v) => default; // 0x0000000185FDB430-0x0000000185FDB460
		public static implicit operator float2(uint2 v) => default; // 0x0000000185FDB400-0x0000000185FDB430
		public static explicit operator float2(double v) => default; // 0x0000000185FDB460-0x0000000185FDB480
		public static explicit operator float2(double2 v) => default; // 0x0000000185FDB390-0x0000000185FDB3B0
		public static float2 operator *(float2 lhs, float2 rhs) => default; // 0x0000000185FD4100-0x0000000185FD4140
		public static float2 operator *(float2 lhs, float rhs) => default; // 0x0000000185FD40D0-0x0000000185FD4100
		public static float2 operator *(float lhs, float2 rhs) => default; // 0x0000000185FE06F0-0x0000000185FE0720
		public static float2 operator +(float2 lhs, float2 rhs) => default; // 0x0000000185FD4060-0x0000000185FD40A0
		public static float2 operator +(float2 lhs, float rhs) => default; // 0x0000000185FD40A0-0x0000000185FD40D0
		public static float2 operator -(float2 lhs, float2 rhs) => default; // 0x0000000185FD4170-0x0000000185FD41B0
		public static float2 operator -(float2 lhs, float rhs) => default; // 0x0000000185FD4140-0x0000000185FD4170
		public static float2 operator -(float lhs, float2 rhs) => default; // 0x0000000185FE0720-0x0000000185FE0740
		public static float2 operator /(float2 lhs, float2 rhs) => default; // 0x000000018B63140C-0x000000018B631440
		public static float2 operator /(float2 lhs, float rhs) => default; // 0x000000018B6318F8-0x000000018B63191C
		public static float2 operator /(float lhs, float2 rhs) => default; // 0x000000018BD80000-0x000000018BD80020
		public static float2 operator %(float2 lhs, float rhs) => default; // 0x0000000185FE06A0-0x0000000185FE06F0
		public static bool2 operator <(float2 lhs, float rhs) => default; // 0x000000018BD800C8-0x000000018BD800EC
		public static bool2 operator <=(float2 lhs, float2 rhs) => default; // 0x000000018BD80090-0x000000018BD800C8
		public static bool2 operator >=(float2 lhs, float2 rhs) => default; // 0x000000018BD80058-0x000000018BD80090
		public static float2 operator -(float2 val) => default; // 0x0000000185FE0740-0x0000000185FE0770
		public static bool2 operator ==(float2 lhs, float rhs) => default; // 0x000000018BD80020-0x000000018BD80058
		public bool Equals(float2 rhs) => default; // 0x000000018B631440-0x000000018B631468
		public override bool Equals(object o) => default; // 0x000000018BD7FDCC-0x000000018BD7FE3C
		public override int GetHashCode() => default; // 0x000000018BD7FE3C-0x000000018BD7FE70
		public override string ToString() => default; // 0x000000018BD7FEF8-0x000000018BD7FF88
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD7FE70-0x000000018BD7FEF8
		public static implicit operator Vector2(float2 v) => default; // 0x0000000185FD3D40-0x0000000185FD3D60
		public static implicit operator float2(Vector2 v) => default; // 0x0000000185FD3D40-0x0000000185FD3D60
	}

	[Serializable]
	public struct float2x2 : IEquatable<Unity.Mathematics.float2x2>, IFormattable // TypeDefIndex: 54728
	{
		// Fields
		public float2 c0; // 0x00
		public float2 c1; // 0x08
		public static readonly float2x2 identity; // 0x00
	
		// Constructors
		public float2x2(float2 c0, float2 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183680100-0x0000000183680110
		public float2x2(float m00, float m01, float m10, float m11) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE0850-0x0000000185FE0870
		public float2x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE0800-0x0000000185FE0820
		public float2x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F112C0-0x0000000186F1147C
		public float2x2(bool2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD80470-0x000000018BD804EC
		public float2x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE0820-0x0000000185FE0850
		public float2x2(int2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE08B0-0x0000000185FE08F0
		public float2x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE08F0-0x0000000185FE0940
		public float2x2(uint2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE0770-0x0000000185FE07D0
		public float2x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE07D0-0x0000000185FE0800
		public float2x2(double2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE0870-0x0000000185FE08B0
		static float2x2() {
			identity = default;
		} // 0x0000000185F52DA0-0x0000000185F52E10
	
		// Methods
		public static float2x2 operator *(float2x2 lhs, float rhs) => default; // 0x000000018BD804EC-0x000000018BD80558
		public bool Equals(float2x2 rhs) => default; // 0x000000018BD800EC-0x000000018BD80128
		public override bool Equals(object o) => default; // 0x000000018BD80128-0x000000018BD80194
		public override int GetHashCode() => default; // 0x000000018BD80194-0x000000018BD801B0
		public override string ToString() => default; // 0x000000018BD80304-0x000000018BD80470
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD801B0-0x000000018BD80304
	}

	[Serializable]
	public struct float2x3 : IEquatable<Unity.Mathematics.float2x3>, IFormattable // TypeDefIndex: 54729
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
		} // 0x0000000185FB6010-0x0000000185FB6020
		public float2x3(float m00, float m01, float m02, float m10, float m11, float m12) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE0A90-0x0000000185FE0AC0
		public float2x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE0B10-0x0000000185FE0B30
		public float2x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F1147C-0x0000000186F115FC
		public float2x3(bool2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD80A04-0x000000018BD80ABC
		public float2x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE0BA0-0x0000000185FE0BF0
		public float2x3(int2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE0A30-0x0000000185FE0A90
		public float2x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE0B30-0x0000000185FE0BA0
		public float2x3(uint2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE09A0-0x0000000185FE0A30
		public float2x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE0AC0-0x0000000185FE0B10
		public float2x3(double2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE0940-0x0000000185FE09A0
	
		// Methods
		public bool Equals(float2x3 rhs) => default; // 0x000000018BD805CC-0x000000018BD80648
		public override bool Equals(object o) => default; // 0x000000018BD80558-0x000000018BD805CC
		public override int GetHashCode() => default; // 0x000000018BD80648-0x000000018BD80670
		public override string ToString() => default; // 0x000000018BD80670-0x000000018BD80850
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD80850-0x000000018BD80A04
	}

	[Serializable]
	public struct float2x4 : IEquatable<Unity.Mathematics.float2x4>, IFormattable // TypeDefIndex: 54730
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
		} // 0x0000000185FB5BF0-0x0000000185FB5C10
		public float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE0BF0-0x0000000185FE0C40
		public float2x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE0CB0-0x0000000185FE0CD0
		public float2x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F115FC-0x0000000186F1176C
		public float2x4(bool2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD81040-0x000000018BD8113C
		public float2x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE0F20-0x0000000185FE0F80
		public float2x4(int2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE0CD0-0x0000000185FE0D50
		public float2x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE0E80-0x0000000185FE0F20
		public float2x4(uint2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE0D50-0x0000000185FE0E10
		public float2x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE0E10-0x0000000185FE0E80
		public float2x4(double2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE0C40-0x0000000185FE0CB0
	
		// Methods
		public bool Equals(float2x4 rhs) => default; // 0x000000018BD80ABC-0x000000018BD80B44
		public override bool Equals(object o) => default; // 0x000000018BD80B44-0x000000018BD80BB8
		public override int GetHashCode() => default; // 0x000000018BD80BB8-0x000000018BD80BDC
		public override string ToString() => default; // 0x000000018BD80DF0-0x000000018BD81040
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD80BDC-0x000000018BD80DF0
	}

	[Serializable]
	public struct float3 : IEquatable<Unity.Mathematics.float3>, IFormattable // TypeDefIndex: 54732
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public static readonly float3 zero; // 0x00
	
		// Properties
		public float4 xxxx { get => default; } // 0x0000000185FE1140-0x0000000185FE1160 
		public float4 xxxy { get => default; } // 0x0000000185FE1160-0x0000000185FE1180 
		public float4 xxxz { get => default; } // 0x0000000185FE1180-0x0000000185FE11A0 
		public float4 xxyx { get => default; } // 0x0000000185FE11C0-0x0000000185FE11E0 
		public float4 xxyy { get => default; } // 0x0000000185FE11E0-0x0000000185FE1200 
		public float4 xxyz { get => default; } // 0x0000000185FE1200-0x0000000185FE1220 
		public float4 xxzx { get => default; } // 0x0000000185FE1240-0x0000000185FE1260 
		public float4 xxzy { get => default; } // 0x0000000185FE1260-0x0000000185FE1280 
		public float4 xxzz { get => default; } // 0x0000000185FE1280-0x0000000185FE12A0 
		public float4 xyxx { get => default; } // 0x0000000185FE12C0-0x0000000185FE12E0 
		public float4 xyxy { get => default; } // 0x0000000185FE0660-0x0000000185FE0680 
		public float4 xyxz { get => default; } // 0x0000000185FE12E0-0x0000000185FE1300 
		public float4 xyyx { get => default; } // 0x0000000185FE1320-0x0000000185FE1340 
		public float4 xyyy { get => default; } // 0x0000000185FE1340-0x0000000185FE1360 
		public float4 xyyz { get => default; } // 0x0000000185FE1360-0x0000000185FE1380 
		public float4 xyzx { get => default; } // 0x00000001845B8680-0x00000001845B86A0 
		public float4 xyzy { get => default; } // 0x0000000185FE1380-0x0000000185FE13A0 
		public float4 xyzz { get => default; } // 0x0000000185FE13A0-0x0000000185FE13C0 
		public float4 xzxx { get => default; } // 0x0000000185FE13E0-0x0000000185FE1400 
		public float4 xzxy { get => default; } // 0x0000000185FE1400-0x0000000185FE1420 
		public float4 xzxz { get => default; } // 0x0000000185FE1420-0x0000000185FE1440 
		public float4 xzyx { get => default; } // 0x0000000185FE1460-0x0000000185FE1480 
		public float4 xzyy { get => default; } // 0x0000000185FE1480-0x0000000185FE14A0 
		public float4 xzyz { get => default; } // 0x0000000185FE14A0-0x0000000185FE14C0 
		public float4 xzzx { get => default; } // 0x0000000185FE14E0-0x0000000185FE1500 
		public float4 xzzy { get => default; } // 0x0000000185FE1500-0x0000000185FE1520 
		public float4 xzzz { get => default; } // 0x0000000185FE1520-0x0000000185FE1540 
		public float4 yxxx { get => default; } // 0x0000000185FE1560-0x0000000185FE1580 
		public float4 yxxy { get => default; } // 0x0000000185FE1580-0x0000000185FE15A0 
		public float4 yxxz { get => default; } // 0x0000000185FE15A0-0x0000000185FE15C0 
		public float4 yxyx { get => default; } // 0x0000000185FE15E0-0x0000000185FE1600 
		public float4 yxyy { get => default; } // 0x0000000185FE1600-0x0000000185FE1620 
		public float4 yxyz { get => default; } // 0x0000000185FE1620-0x0000000185FE1640 
		public float4 yxzx { get => default; } // 0x0000000185FE1660-0x0000000185FE1680 
		public float4 yxzy { get => default; } // 0x0000000185FE1680-0x0000000185FE16A0 
		public float4 yxzz { get => default; } // 0x0000000185FE16A0-0x0000000185FE16C0 
		public float4 yyxx { get => default; } // 0x0000000185FE1700-0x0000000185FE1720 
		public float4 yyxy { get => default; } // 0x0000000185FE1720-0x0000000185FE1740 
		public float4 yyxz { get => default; } // 0x0000000185FE1740-0x0000000185FE1760 
		public float4 yyyx { get => default; } // 0x0000000185FE1770-0x0000000185FE1790 
		public float4 yyyy { get => default; } // 0x0000000185FE1790-0x0000000185FE17B0 
		public float4 yyyz { get => default; } // 0x0000000185FE17B0-0x0000000185FE17D0 
		public float4 yyzx { get => default; } // 0x0000000185FE17F0-0x0000000185FE1810 
		public float4 yyzy { get => default; } // 0x0000000185FE1810-0x0000000185FE1830 
		public float4 yyzz { get => default; } // 0x0000000185FE1830-0x0000000185FE1850 
		public float4 yzxx { get => default; } // 0x0000000185FE1870-0x0000000185FE1890 
		public float4 yzxy { get => default; } // 0x00000001845B86A0-0x00000001845B86C0 
		public float4 yzxz { get => default; } // 0x00000001845B8700-0x00000001845B8720 
		public float4 yzyx { get => default; } // 0x0000000185FE18B0-0x0000000185FE18D0 
		public float4 yzyy { get => default; } // 0x0000000185FE18D0-0x0000000185FE18F0 
		public float4 yzyz { get => default; } // 0x0000000185FE18F0-0x0000000185FE1910 
		public float4 yzzx { get => default; } // 0x0000000185FE1930-0x0000000185FE1950 
		public float4 yzzy { get => default; } // 0x0000000185FE1950-0x0000000185FE1970 
		public float4 yzzz { get => default; } // 0x0000000185FE1970-0x0000000185FE1990 
		public float4 zxxx { get => default; } // 0x0000000185FE19D0-0x0000000185FE19F0 
		public float4 zxxy { get => default; } // 0x0000000185FE19F0-0x0000000185FE1A10 
		public float4 zxxz { get => default; } // 0x0000000185FE1A10-0x0000000185FE1A30 
		public float4 zxyx { get => default; } // 0x0000000185FE1A50-0x0000000185FE1A70 
		public float4 zxyy { get => default; } // 0x00000001845B86C0-0x00000001845B86E0 
		public float4 zxyz { get => default; } // 0x00000001845B86E0-0x00000001845B8700 
		public float4 zxzx { get => default; } // 0x0000000185FE1A90-0x0000000185FE1AB0 
		public float4 zxzy { get => default; } // 0x0000000185FE1AB0-0x0000000185FE1AD0 
		public float4 zxzz { get => default; } // 0x0000000185FE1AD0-0x0000000185FE1AF0 
		public float4 zyxx { get => default; } // 0x0000000185FE1B30-0x0000000185FE1B50 
		public float4 zyxy { get => default; } // 0x0000000185FE1B50-0x0000000185FE1B70 
		public float4 zyxz { get => default; } // 0x0000000185FE1B70-0x0000000185FE1B90 
		public float4 zyyx { get => default; } // 0x0000000185FE1BB0-0x0000000185FE1BD0 
		public float4 zyyy { get => default; } // 0x0000000185FE1BD0-0x0000000185FE1BF0 
		public float4 zyyz { get => default; } // 0x0000000185FE1BF0-0x0000000185FE1C10 
		public float4 zyzx { get => default; } // 0x0000000185FE1C30-0x0000000185FE1C50 
		public float4 zyzy { get => default; } // 0x0000000185FE1C50-0x0000000185FE1C70 
		public float4 zyzz { get => default; } // 0x0000000185FE1C70-0x0000000185FE1C90 
		public float4 zzxx { get => default; } // 0x0000000185FE1CD0-0x0000000185FE1CF0 
		public float4 zzxy { get => default; } // 0x0000000185FE1CF0-0x0000000185FE1D10 
		public float4 zzxz { get => default; } // 0x0000000185FE1D10-0x0000000185FE1D30 
		public float4 zzyx { get => default; } // 0x0000000185FE1D50-0x0000000185FE1D70 
		public float4 zzyy { get => default; } // 0x0000000185FE1D70-0x0000000185FE1D90 
		public float4 zzyz { get => default; } // 0x0000000185FE1D90-0x0000000185FE1DB0 
		public float4 zzzx { get => default; } // 0x0000000185FE1DC0-0x0000000185FE1DE0 
		public float4 zzzy { get => default; } // 0x0000000185FE1DE0-0x0000000185FE1E00 
		public float4 zzzz { get => default; } // 0x0000000185FE1E00-0x0000000185FE1E20 
		public float3 xxx { get => default; } // 0x0000000185FE1130-0x0000000185FE1140 
		public float3 xxy { get => default; } // 0x0000000185FE11A0-0x0000000185FE11C0 
		public float3 xxz { get => default; } // 0x0000000185FE1220-0x0000000185FE1240 
		public float3 xyx { get => default; } // 0x0000000185FE12A0-0x0000000185FE12C0 
		public float3 xyy { get => default; } // 0x0000000185FE1300-0x0000000185FE1320 
		public float3 xyz { get => default; set {} } // 0x0000000185FB2950-0x0000000185FB2970 0x0000000185FB2F50-0x0000000185FB2F70
		public float3 xzx { get => default; } // 0x0000000185FE13C0-0x0000000185FE13E0 
		public float3 xzy { get => default; set {} } // 0x0000000185FE1440-0x0000000185FE1460 0x0000000185FE1FF0-0x0000000185FE2010
		public float3 xzz { get => default; } // 0x0000000185FE14C0-0x0000000185FE14E0 
		public float3 yxx { get => default; } // 0x0000000185FE1540-0x0000000185FE1560 
		public float3 yxy { get => default; } // 0x0000000185FE15C0-0x0000000185FE15E0 
		public float3 yxz { get => default; set {} } // 0x0000000185FE1640-0x0000000185FE1660 0x0000000185FE2030-0x0000000185FE2050
		public float3 yyx { get => default; } // 0x0000000185FE16E0-0x0000000185FE1700 
		public float3 yyy { get => default; } // 0x0000000185FE1760-0x0000000185FE1770 
		public float3 yyz { get => default; } // 0x0000000185FE17D0-0x0000000185FE17F0 
		public float3 yzx { get => default; set {} } // 0x0000000185FE1850-0x0000000185FE1870 0x0000000185FE2070-0x0000000185FE2090
		public float3 yzy { get => default; } // 0x0000000185FE1890-0x0000000185FE18B0 
		public float3 yzz { get => default; } // 0x0000000185FE1910-0x0000000185FE1930 
		public float3 zxx { get => default; } // 0x0000000185FE19B0-0x0000000185FE19D0 
		public float3 zxy { get => default; set {} } // 0x0000000185FE1A30-0x0000000185FE1A50 0x0000000185FE20B0-0x0000000185FE20D0
		public float3 zxz { get => default; } // 0x0000000185FE1A70-0x0000000185FE1A90 
		public float3 zyx { get => default; set {} } // 0x0000000185FE1B10-0x0000000185FE1B30 0x0000000185FE20F0-0x0000000185FE2110
		public float3 zyy { get => default; } // 0x0000000185FE1B90-0x0000000185FE1BB0 
		public float3 zyz { get => default; } // 0x0000000185FE1C10-0x0000000185FE1C30 
		public float3 zzx { get => default; } // 0x0000000185FE1CB0-0x0000000185FE1CD0 
		public float3 zzy { get => default; } // 0x0000000185FE1D30-0x0000000185FE1D50 
		public float3 zzz { get => default; } // 0x0000000185FE1DB0-0x0000000185FE1DC0 
		public float2 xx { get => default; } // 0x0000000185FE1120-0x0000000185FE1130 
		public float2 xy { get => default; set {} } // 0x0000000185FB29D0-0x0000000185FB29F0 0x0000000185FE0590-0x0000000185FE05B0
		public float2 xz { get => default; set {} } // 0x0000000185FB2A20-0x0000000185FB2A40 0x0000000185FE1FD0-0x0000000185FE1FF0
		public float2 yx { get => default; set {} } // 0x0000000185FE0680-0x0000000185FE06A0 0x0000000185FE2010-0x0000000185FE2030
		public float2 yy { get => default; } // 0x0000000185FE16C0-0x0000000185FE16E0 
		public float2 yz { get => default; set {} } // 0x0000000185FB5840-0x0000000185FB5860 0x0000000185FE2050-0x0000000185FE2070
		public float2 zx { get => default; set {} } // 0x0000000185FE1990-0x0000000185FE19B0 0x0000000185FE2090-0x0000000185FE20B0
		public float2 zy { get => default; set {} } // 0x0000000185FE1AF0-0x0000000185FE1B10 0x0000000185FE20D0-0x0000000185FE20F0
		public float2 zz { get => default; } // 0x0000000185FE1C90-0x0000000185FE1CB0 
		public float this[int index] { get => default; set {} } // 0x0000000185FE1110-0x0000000185FE1120 0x0000000185FE1FC0-0x0000000185FE1FD0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54731
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public float3(float x, float y, float z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000185FB2F40-0x0000000185FB2F50
		public float3(float x, float2 yz) : this() {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000185FE10C0-0x0000000185FE10E0
		public float3(float2 xy, float z) : this() {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000185FE0FF0-0x0000000185FE1010
		public float3(float3 xyz) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FB2F50-0x0000000185FB2F70
		public float3(float v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE1080-0x0000000185FE1090
		public float3(bool v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000186F1176C-0x0000000186F117A0
		public float3(bool3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000186F117A0-0x0000000186F117DC
		public float3(int v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE0F80-0x0000000185FE0FB0
		public float3(int3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE1090-0x0000000185FE10C0
		public float3(uint v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE1010-0x0000000185FE1050
		public float3(uint3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE0FB0-0x0000000185FE0FF0
		public float3(half v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD81380-0x000000018BD813BC
		public float3(half3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD81344-0x000000018BD81380
		public float3(double v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE1050-0x0000000185FE1080
		public float3(double3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE10E0-0x0000000185FE1110
	
		// Methods
		public static implicit operator float3(float v) => default; // 0x0000000185FB5820-0x0000000185FB5840
		public static explicit operator float3(bool v) => default; // 0x000000018BD4DAB4-0x000000018BD4DAD0
		public static explicit operator float3(bool3 v) => default; // 0x000000018BD4DB58-0x000000018BD4DB88
		public static implicit operator float3(int v) => default; // 0x0000000185FDB4F0-0x0000000185FDB520
		public static implicit operator float3(int3 v) => default; // 0x0000000185FDB680-0x0000000185FDB6D0
		public static implicit operator float3(uint v) => default; // 0x0000000185FDB640-0x0000000185FDB680
		public static implicit operator float3(uint3 v) => default; // 0x0000000185FDB5B0-0x0000000185FDB610
		public static implicit operator float3(half v) => default; // 0x000000018BD4DAD0-0x000000018BD4DB0C
		public static implicit operator float3(half3 v) => default; // 0x000000018BD4DB0C-0x000000018BD4DB58
		public static explicit operator float3(double v) => default; // 0x0000000185FDB520-0x0000000185FDB550
		public static explicit operator float3(double3 v) => default; // 0x0000000185FDB4B0-0x0000000185FDB4F0
		public static float3 operator *(float3 lhs, float3 rhs) => default; // 0x0000000185FB2AF0-0x0000000185FB2B30
		public static float3 operator *(float3 lhs, float rhs) => default; // 0x00000001845B92D0-0x00000001845B9300
		public static float3 operator *(float lhs, float3 rhs) => default; // 0x00000001845BB9E0-0x00000001845BBA10
		public static float3 operator +(float3 lhs, float3 rhs) => default; // 0x00000001845BBA50-0x00000001845BBA90
		public static float3 operator +(float3 lhs, float rhs) => default; // 0x00000001852C66C0-0x00000001852C66F0
		public static float3 operator +(float lhs, float3 rhs) => default; // 0x0000000185FE1E20-0x0000000185FE1E50
		public static float3 operator -(float3 lhs, float3 rhs) => default; // 0x00000001845BBA10-0x00000001845BBA50
		public static float3 operator -(float3 lhs, float rhs) => default; // 0x00000001852C66F0-0x00000001852C6720
		public static float3 operator -(float lhs, float3 rhs) => default; // 0x0000000185FE1F90-0x0000000185FE1FC0
		public static float3 operator /(float3 lhs, float3 rhs) => default; // 0x000000018B632038-0x000000018B63206C
		public static float3 operator /(float3 lhs, float rhs) => default; // 0x000000018B621744-0x000000018B621770
		public static float3 operator /(float lhs, float3 rhs) => default; // 0x000000018BD813BC-0x000000018BD813E8
		public static float3 operator %(float3 lhs, float3 rhs) => default; // 0x0000000185FDBB10-0x0000000185FDBB80
		public static float3 operator %(float3 lhs, float rhs) => default; // 0x0000000185FE1F30-0x0000000185FE1F90
		public static float3 operator %(float lhs, float3 rhs) => default; // 0x0000000185FE1ED0-0x0000000185FE1F30
		public static float3 operator ++(float3 val) => default; // 0x0000000185FE1E90-0x0000000185FE1ED0
		public static float3 operator --(float3 val) => default; // 0x0000000185FE1E50-0x0000000185FE1E90
		public static bool3 operator <(float3 lhs, float3 rhs) => default; // 0x000000018BD816FC-0x000000018BD81730
		public static bool3 operator <(float3 lhs, float rhs) => default; // 0x000000018BD81730-0x000000018BD83950
		public static bool3 operator <(float lhs, float3 rhs) => default; // 0x000000018BD816CC-0x000000018BD816FC
		public static bool3 operator <=(float3 lhs, float3 rhs) => default; // 0x000000018BD81638-0x000000018BD81670
		public static bool3 operator <=(float3 lhs, float rhs) => default; // 0x000000018BD816A4-0x000000018BD816CC
		public static bool3 operator <=(float lhs, float3 rhs) => default; // 0x000000018BD81670-0x000000018BD816A4
		public static bool3 operator >(float3 lhs, float3 rhs) => default; // 0x000000018BD814F8-0x000000018BD8152C
		public static bool3 operator >(float3 lhs, float rhs) => default; // 0x000000018BD81550-0x000000018BD8157C
		public static bool3 operator >(float lhs, float3 rhs) => default; // 0x000000018BD8152C-0x000000018BD81550
		public static bool3 operator >=(float3 lhs, float3 rhs) => default; // 0x000000018BD8146C-0x000000018BD814A0
		public static bool3 operator >=(float3 lhs, float rhs) => default; // 0x000000018BD814A0-0x000000018BD814D0
		public static bool3 operator >=(float lhs, float3 rhs) => default; // 0x000000018BD814D0-0x000000018BD814F8
		public static float3 operator -(float3 val) => default; // 0x00000001840DB410-0x00000001840DB450
		public static float3 operator +(float3 val) => default; // 0x0000000185FB2950-0x0000000185FB2970
		public static bool3 operator ==(float3 lhs, float3 rhs) => default; // 0x000000018BD813E8-0x000000018BD81430
		public static bool3 operator ==(float3 lhs, float rhs) => default; // 0x0000000186F117DC-0x0000000186F118D0
		public static bool3 operator ==(float lhs, float3 rhs) => default; // 0x000000018BD81430-0x000000018BD8146C
		public static bool3 operator !=(float3 lhs, float3 rhs) => default; // 0x000000018BD815B4-0x000000018BD815F8
		public static bool3 operator !=(float3 lhs, float rhs) => default; // 0x000000018BD815F8-0x000000018BD81638
		public static bool3 operator !=(float lhs, float3 rhs) => default; // 0x000000018BD8157C-0x000000018BD815B4
		public bool Equals(float3 rhs) => default; // 0x00000001843884A0-0x00000001843884D0
		public override bool Equals(object o) => default; // 0x000000018BD8113C-0x000000018BD811B0
		public override int GetHashCode() => default; // 0x000000018BD811B0-0x000000018BD811D4
		public override string ToString() => default; // 0x000000018BD811D4-0x000000018BD81294
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD81294-0x000000018BD81344
		public static implicit operator Vector3(float3 v) => default; // 0x0000000185FB2950-0x0000000185FB2970
		public static implicit operator float3(Vector3 v) => default; // 0x0000000185FB2950-0x0000000185FB2970
	}

	[Serializable]
	public struct float3x2 : IEquatable<Unity.Mathematics.float3x2>, IFormattable // TypeDefIndex: 54733
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
	
		// Constructors
		public float3x2(float3 c0, float3 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000185FB1480-0x0000000185FB14A0
		public float3x2(float m00, float m01, float m10, float m11, float m20, float m21) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE2180-0x0000000185FE21B0
		public float3x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE2160-0x0000000185FE2180
		public float3x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F118D0-0x0000000186F119FC
		public float3x2(bool3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD87344-0x000000018BD87414
		public float3x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE2110-0x0000000185FE2160
		public float3x2(int3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F11A70-0x0000000186F11AE4
		public float3x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE21B0-0x0000000185FE2220
		public float3x2(uint3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F119FC-0x0000000186F11A70
		public float3x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE2220-0x0000000185FE2270
		public float3x2(double3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD872CC-0x000000018BD87344
	
		// Methods
		public static float3x2 operator *(float3x2 lhs, float rhs) => default; // 0x000000018BD87414-0x000000018BD87498
		public bool Equals(float3x2 rhs) => default; // 0x000000018BD86EAC-0x000000018BD86F10
		public override bool Equals(object o) => default; // 0x000000018BD86E38-0x000000018BD86EAC
		public override int GetHashCode() => default; // 0x000000018BD86F10-0x000000018BD86F38
		public override string ToString() => default; // 0x000000018BD870EC-0x000000018BD872CC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD86F38-0x000000018BD870EC
	}

	[Serializable]
	public struct float3x3 : IEquatable<Unity.Mathematics.float3x3>, IFormattable // TypeDefIndex: 54734
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
		public float3 c2; // 0x18
		public static readonly float3x3 identity; // 0x00
		public static readonly float3x3 zero; // 0x24
	
		// Properties
		public ref float3 this[int index] { get => default; } // 0x0000000185FE2490-0x0000000185FE24A0 
	
		// Constructors
		public float3x3(float3 c0, float3 c1, float3 c2) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000185FB65B0-0x0000000185FB65F0
		public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE22E0-0x0000000185FE2340
		public float3x3(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE23F0-0x0000000185FE2420
		public float3x3(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F11C30-0x0000000186F11CAC
		public float3x3(bool3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD87B40-0x000000018BD87C64
		public float3x3(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE2270-0x0000000185FE22E0
		public float3x3(int3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F11AE4-0x0000000186F11C30
		public float3x3(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE2340-0x0000000185FE23F0
		public float3x3(uint3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F11CAC-0x0000000186F11E78
		public float3x3(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE2420-0x0000000185FE2490
		public float3x3(double3x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD87A98-0x000000018BD87B40
		public float3x3(float4x4 f4x4) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x00000001845B9300-0x00000001845B93D0
		public float3x3(quaternion q) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x00000001845BB4C0-0x00000001845BB9C0
		static float3x3() {
			identity = default;
			zero = default;
		} // 0x0000000185EBB020-0x0000000185EBB0D0
	
		// Methods
		public static implicit operator float3x3(int v) => default; // 0x000000018BD4DE3C-0x000000018BD4DE5C
		public static float3x3 operator *(float3x3 lhs, float rhs) => default; // 0x000000018BD87D64-0x000000018BD87E1C
		public static float3x3 operator +(float3x3 lhs, float3x3 rhs) => default; // 0x000000018BD87C64-0x000000018BD87D64
		public bool Equals(float3x3 rhs) => default; // 0x000000018BD87514-0x000000018BD875A0
		public override bool Equals(object o) => default; // 0x000000018BD87498-0x000000018BD87514
		public override int GetHashCode() => default; // 0x000000018BD875A0-0x000000018BD875CC
		public override string ToString() => default; // 0x000000018BD875CC-0x000000018BD87854
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD87854-0x000000018BD87A98
	}

	[Serializable]
	public struct float3x4 : IEquatable<Unity.Mathematics.float3x4>, IFormattable // TypeDefIndex: 54735
	{
		// Fields
		public float3 c0; // 0x00
		public float3 c1; // 0x0C
		public float3 c2; // 0x18
		public float3 c3; // 0x24
		public static readonly float3x4 zero; // 0x00
	
		// Properties
		public ref float3 this[int index] { get => default; } // 0x0000000185FE2490-0x0000000185FE24A0 
	
		// Constructors
		public float3x4(float3 c0, float3 c1, float3 c2, float3 c3) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000185FE24E0-0x0000000185FE2530
		public float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE2730-0x0000000185FE27B0
		public float3x4(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE24A0-0x0000000185FE24E0
		public float3x4(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F11F4C-0x0000000186F11FEC
		public float3x4(bool3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8866C-0x000000018BD887E4
		public float3x4(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE26A0-0x0000000185FE2730
		public float3x4(int3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F11E78-0x0000000186F11F4C
		public float3x4(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE25C0-0x0000000185FE26A0
		public float3x4(uint3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F11FEC-0x0000000186F12318
		public float3x4(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE2530-0x0000000185FE25C0
		public float3x4(double3x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD88590-0x000000018BD8866C
	
		// Methods
		public static implicit operator float3x4(int v) => default; // 0x000000018BD4E064-0x000000018BD4E084
		public bool Equals(float3x4 rhs) => default; // 0x000000018BD87E98-0x000000018BD87F5C
		public override bool Equals(object o) => default; // 0x000000018BD87E1C-0x000000018BD87E98
		public override int GetHashCode() => default; // 0x000000018BD87F5C-0x000000018BD87F8C
		public override string ToString() => default; // 0x000000018BD88260-0x000000018BD88590
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD87F8C-0x000000018BD88260
	}

	[Serializable]
	public struct float4 : IEquatable<Unity.Mathematics.float4>, IFormattable // TypeDefIndex: 54737
	{
		// Fields
		public float x; // 0x00
		public float y; // 0x04
		public float z; // 0x08
		public float w; // 0x0C
		public static readonly float4 zero; // 0x00
	
		// Properties
		public float4 xxzz { get => default; } // 0x0000000185FE1280-0x0000000185FE12A0 
		public float4 xyzx { get => default; } // 0x00000001845B8680-0x00000001845B86A0 
		public float4 xzxz { get => default; } // 0x0000000185FE1420-0x0000000185FE1440 
		public float4 yyww { get => default; } // 0x0000000185FE2AE0-0x0000000185FE2B00 
		public float4 yzxy { get => default; } // 0x00000001845B86A0-0x00000001845B86C0 
		public float4 yzxz { get => default; } // 0x00000001845B8700-0x00000001845B8720 
		public float4 yzxw { get => default; } // 0x0000000185FE2B00-0x0000000185FE2B20 
		public float4 zxyy { get => default; } // 0x00000001845B86C0-0x00000001845B86E0 
		public float4 zxyz { get => default; } // 0x00000001845B86E0-0x00000001845B8700 
		public float4 zwxy { get => default; } // 0x00000001845B98F0-0x00000001845B9D00 
		public float4 wzyx { get => default; } // 0x00000001845B98D0-0x00000001845B98F0 
		public float4 wwwx { get => default; } // 0x0000000185FE2A20-0x0000000185FE2A40 
		public float4 wwww { get => default; } // 0x0000000185FE2A00-0x0000000185FE2A20 
		public float3 xxx { get => default; } // 0x0000000185FE1130-0x0000000185FE1140 
		public float3 xyz { get => default; set {} } // 0x0000000185FB2950-0x0000000185FB2970 0x0000000185FB2F50-0x0000000185FB2F70
		public float3 xyw { get => default; } // 0x0000000185FE2A80-0x0000000185FE2AA0 
		public float3 yxw { get => default; } // 0x0000000185FE2AC0-0x0000000185FE2AE0 
		public float3 yzx { get => default; } // 0x0000000185FE1850-0x0000000185FE1870 
		public float3 zwx { get => default; } // 0x0000000185FE2B20-0x0000000185FE2B40 
		public float3 wzy { get => default; } // 0x0000000185FE2A60-0x0000000185FE2A80 
		public float3 www { get => default; } // 0x0000000185FE29F0-0x0000000185FE2A00 
		public float2 xx { get => default; } // 0x0000000185FE1120-0x0000000185FE1130 
		public float2 xy { get => default; set {} } // 0x0000000185FB29D0-0x0000000185FB29F0 0x0000000185FE0590-0x0000000185FE05B0
		public float2 xz { get => default; } // 0x0000000185FB2A20-0x0000000185FB2A40 
		public float2 yy { get => default; } // 0x0000000185FE16C0-0x0000000185FE16E0 
		public float2 yw { get => default; } // 0x0000000185FE2AA0-0x0000000185FE2AC0 
		public float2 zw { get => default; } // 0x0000000185FB8260-0x0000000185FB8280 
		public float2 wz { get => default; } // 0x0000000185FE2A40-0x0000000185FE2A60 
		public float this[int index] { get => default; set {} } // 0x0000000185FE1110-0x0000000185FE1120 0x0000000185FE1FC0-0x0000000185FE1FD0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54736
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
		} // 0x0000000185FB2B40-0x0000000185FB2B60
		public float4(float x, float y, float2 zw) : this() {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000185FE2900-0x0000000185FE2930
		public float4(float x, float2 yz, float w) : this() {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FE29A0-0x0000000185FE29D0
		public float4(float x, float3 yzw) : this() {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE29D0-0x0000000185FE29F0
		public float4(float2 xy, float z, float w) : this() {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000185FE28B0-0x0000000185FE28E0
		public float4(float2 xy, float2 zw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE27B0-0x0000000185FE27F0
		public float4(float3 xyz, float w) : this() {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FE2890-0x0000000185FE28B0
		public float4(float4 xyzw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FBF140-0x0000000185FBF160
		public float4(float v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE2840-0x0000000185FE2850
		public float4(bool v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000186F12318-0x0000000186F1235C
		public float4(bool4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000186F1235C-0x0000000186F123B0
		public float4(int v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE2930-0x0000000185FE2940
		public float4(int4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE2990-0x0000000185FE29A0
		public float4(uint v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE27F0-0x0000000185FE2840
		public float4(uint4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE2940-0x0000000185FE2990
		public float4(half v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD88B68-0x000000018BD88BB0
		public float4(half4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD88B10-0x000000018BD88B68
		public float4(double v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE28E0-0x0000000185FE2900
		public float4(double4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE2850-0x0000000185FE2890
	
		// Methods
		public static implicit operator float4(float v) => default; // 0x0000000185FDB770-0x0000000185FDB780
		public static implicit operator float4(int v) => default; // 0x0000000185FDB800-0x0000000185FDB820
		public static implicit operator float4(int4 v) => default; // 0x000000018BD4E29C-0x000000018BD4E2E0
		public static implicit operator float4(uint v) => default; // 0x0000000185FDB850-0x0000000185FDB8A0
		public static implicit operator float4(uint4 v) => default; // 0x000000018BD4E2F8-0x000000018BD4E31C
		public static implicit operator float4(half4 v) => default; // 0x000000018BD4E1F4-0x000000018BD4E250
		public static explicit operator float4(double v) => default; // 0x0000000185FDB7E0-0x0000000185FDB800
		public static explicit operator float4(double4 v) => default; // 0x000000018BD4E1AC-0x000000018BD4E1DC
		public static float4 operator *(float4 lhs, float4 rhs) => default; // 0x00000001845B9D00-0x00000001845B9D50
		public static float4 operator *(float4 lhs, float rhs) => default; // 0x00000001840DD310-0x00000001840DD330
		public static float4 operator *(float lhs, float4 rhs) => default; // 0x00000001845B93D0-0x00000001845B93F0
		public static float4 operator +(float4 lhs, float4 rhs) => default; // 0x00000001845B9D50-0x00000001845B9DA0
		public static float4 operator +(float4 lhs, float rhs) => default; // 0x0000000185FD41D0-0x0000000185FD41F0
		public static float4 operator -(float4 lhs, float4 rhs) => default; // 0x00000001845B8630-0x00000001845B8680
		public static float4 operator -(float4 lhs, float rhs) => default; // 0x0000000185FD41F0-0x0000000185FD4210
		public static float4 operator -(float lhs, float4 rhs) => default; // 0x0000000185FE2B40-0x0000000185FE2B80
		public static float4 operator /(float4 lhs, float4 rhs) => default; // 0x000000018B632758-0x000000018B63279C
		public static float4 operator /(float4 lhs, float rhs) => default; // 0x000000018B63279C-0x000000018B6327B0
		public static float4 operator /(float lhs, float4 rhs) => default; // 0x000000018BD88BB0-0x000000018BD88BE8
		public static bool4 operator <(float4 lhs, float rhs) => default; // 0x000000018BD88CCC-0x000000018BD88CF4
		public static bool4 operator >(float4 lhs, float4 rhs) => default; // 0x000000018BD88C90-0x000000018BD88CCC
		public static bool4 operator >=(float4 lhs, float4 rhs) => default; // 0x000000018BD88C4C-0x000000018BD88C90
		public static float4 operator -(float4 val) => default; // 0x0000000185FE2B80-0x0000000185FE2BA0
		public static bool4 operator ==(float4 lhs, float4 rhs) => default; // 0x000000018BD88BE8-0x000000018BD88C4C
		public static bool4 operator ==(float4 lhs, float rhs) => default; // 0x0000000186F123B0-0x0000000186F124BC
		public bool Equals(float4 rhs) => default; // 0x0000000184A6EB60-0x0000000184A6EBA0
		public override bool Equals(object o) => default; // 0x000000018BD887E4-0x000000018BD88850
		public override int GetHashCode() => default; // 0x000000018BD520A8-0x000000018BD520C4
		public override string ToString() => default; // 0x000000018BD88850-0x000000018BD889BC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD889BC-0x000000018BD88B10
		public static implicit operator float4(Vector4 v) => default; // 0x00000001840F57D0-0x00000001840F57F0
		public static implicit operator Vector4(float4 v) => default; // 0x00000001840F57D0-0x00000001840F57F0
	}

	[Serializable]
	public struct float4x2 : IEquatable<Unity.Mathematics.float4x2>, IFormattable // TypeDefIndex: 54738
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
	
		// Constructors
		public float4x2(float4 c0, float4 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000185FB6710-0x0000000185FB6720
		public float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE2C70-0x0000000185FE2CE0
		public float4x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE2C50-0x0000000185FE2C70
		public float4x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F12684-0x0000000186F126A8
		public float4x2(bool4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F124BC-0x0000000186F12654
		public float4x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE2BA0-0x0000000185FE2BC0
		public float4x2(int4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD8928C-0x000000018BD89330
		public float4x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F12654-0x0000000186F12684
		public float4x2(uint4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD89238-0x000000018BD8928C
		public float4x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE2BC0-0x0000000185FE2C50
		public float4x2(double4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD89330-0x000000018BD89394
	
		// Methods
		public static implicit operator float4x2(int v) => default; // 0x0000000183F754D0-0x0000000183F75500
		public bool Equals(float4x2 rhs) => default; // 0x000000018BD88CF4-0x000000018BD88D3C
		public override bool Equals(object o) => default; // 0x000000018BD88D3C-0x000000018BD88DB0
		public override int GetHashCode() => default; // 0x000000018BD88DB0-0x000000018BD88DD4
		public override string ToString() => default; // 0x000000018BD88FE8-0x000000018BD89238
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD88DD4-0x000000018BD88FE8
	}

	[Serializable]
	public struct float4x3 : IEquatable<Unity.Mathematics.float4x3>, IFormattable // TypeDefIndex: 54739
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
		public float4 c2; // 0x20
	
		// Properties
		public ref float4 this[int index] { get => default; } // 0x0000000185FE2E90-0x0000000185FE2EA0 
	
		// Constructors
		public float4x3(float4 c0, float4 c1, float4 c2) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000185FCC290-0x0000000185FCC2B0
		public float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE2DD0-0x0000000185FE2E90
		public float4x3(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE2DA0-0x0000000185FE2DD0
		public float4x3(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F12758-0x0000000186F12994
		public float4x3(bool4x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F126A8-0x0000000186F12758
		public float4x3(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x00000001849B1590-0x00000001849B15C0
		public float4x3(int4x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD89AA4-0x000000018BD89B94
		public float4x3(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F12994-0x0000000186F129D8
		public float4x3(uint4x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD89B94-0x000000018BD89C0C
		public float4x3(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE2CE0-0x0000000185FE2DA0
		public float4x3(double4x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD89C0C-0x000000018BD89C98
	
		// Methods
		public static implicit operator float4x3(int v) => default; // 0x000000018BD4E60C-0x000000018BD4E62C
		public static float4x3 operator *(float4x3 lhs, float4x3 rhs) => default; // 0x000000018BD89D54-0x000000018BD89E10
		public static float4x3 operator *(float4x3 lhs, float rhs) => default; // 0x000000018BD89E10-0x000000018BD89E9C
		public static float4x3 operator +(float4x3 lhs, float4x3 rhs) => default; // 0x000000018BD89C98-0x000000018BD89D54
		public bool Equals(float4x3 rhs) => default; // 0x000000018BD89410-0x000000018BD89470
		public override bool Equals(object o) => default; // 0x000000018BD89394-0x000000018BD89410
		public override int GetHashCode() => default; // 0x000000018BD89470-0x000000018BD894A0
		public override string ToString() => default; // 0x000000018BD89774-0x000000018BD89AA4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD894A0-0x000000018BD89774
	}

	[Serializable]
	public struct float4x4 : IEquatable<Unity.Mathematics.float4x4>, IFormattable // TypeDefIndex: 54740
	{
		// Fields
		public float4 c0; // 0x00
		public float4 c1; // 0x10
		public float4 c2; // 0x20
		public float4 c3; // 0x30
		public static readonly float4x4 identity; // 0x00
		public static readonly float4x4 zero; // 0x40
	
		// Properties
		public ref float4 this[int index] { get => default; } // 0x0000000185FE2E90-0x0000000185FE2EA0 
	
		// Constructors
		public float4x4(float4 c0, float4 c1, float4 c2, float4 c3) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		} // 0x0000000185FDF130-0x0000000185FDF160
		public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x00000001843FEE00-0x00000001843FEF00
		public float4x4(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x00000001840DCD80-0x00000001840DD310
		public float4x4(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F12AB8-0x0000000186F12BB4
		public float4x4(bool4x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F129D8-0x0000000186F12AB8
		public float4x4(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x00000001851DA730-0x00000001851DA770
		public float4x4(int4x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8AE54-0x000000018BD8AF8C
		public float4x4(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F12BB4-0x0000000186F137A0
		public float4x4(uint4x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8ADBC-0x000000018BD8AE54
		public float4x4(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE2EA0-0x0000000185FE2FA0
		public float4x4(double4x4 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8AD04-0x000000018BD8ADBC
		public float4x4(float3x3 rotation, float3 translation) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8AA1C-0x000000018BD8AADC
		public float4x4(quaternion rotation, float3 translation) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8AADC-0x000000018BD8ABE0
		public float4x4(RigidTransform transform) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8ABE0-0x000000018BD8AD04
		static float4x4() {
			identity = default;
			zero = default;
		} // 0x0000000185EDCF80-0x0000000185EDD080
	
		// Methods
		public static implicit operator float4x4(float v) => default; // 0x00000001840DCD50-0x00000001840DCD80
		public static implicit operator float4x4(int v) => default; // 0x000000018BD4EB0C-0x000000018BD4EB30
		public static float4x4 operator *(float4x4 lhs, float rhs) => default; // 0x000000018BD8B178-0x000000018BD8B230
		public static bool4x4 operator ==(float4x4 lhs, float4x4 rhs) => default; // 0x000000018BD8AF8C-0x000000018BD8B060
		public bool Equals(float4x4 rhs) => default; // 0x000000018BD89E9C-0x000000018BD89F18
		public override bool Equals(object o) => default; // 0x000000018BD89F18-0x000000018BD89F9C
		public override int GetHashCode() => default; // 0x000000018BD89F9C-0x000000018BD89FD4
		public override string ToString() => default; // 0x000000018BD8A278-0x000000018BD8A688
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8A688-0x000000018BD8AA1C
		public static implicit operator float4x4(Matrix4x4 m) => default; // 0x000000018BD8B060-0x000000018BD8B178
		public static implicit operator Matrix4x4(float4x4 m) => default; // 0x00000001843FEF00-0x00000001843FF0F0
		public static float4x4 Ortho(float width, float height, float near, float far) => default; // 0x000000018BD89FD4-0x000000018BD8A0C0
		public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale) => default; // 0x000000018BD8A0C0-0x000000018BD8A278
	}

	[Serializable]
	public struct half : IEquatable<Unity.Mathematics.half>, IFormattable // TypeDefIndex: 54741
	{
		// Fields
		public ushort value; // 0x00
		public static readonly half zero; // 0x00
	
		// Constructors
		public half(half x) {
			value = default;
		} // 0x0000000185FB0F40-0x0000000185FB0F50
		public half(float v) {
			value = default;
		} // 0x000000018BD8BD28-0x000000018BD8BD40
		public half(double v) {
			value = default;
		} // 0x000000018BD8BD0C-0x000000018BD8BD28
	
		// Methods
		public static explicit operator half(float v) => default; // 0x000000018BD4F278-0x000000018BD4F280
		public static explicit operator half(double v) => default; // 0x000000018BD4F26C-0x000000018BD4F278
		public static implicit operator float(half d) => default; // 0x000000018BD8BD60-0x000000018BD8BD68
		public static implicit operator double(half d) => default; // 0x000000018BD8BD48-0x000000018BD8BD60
		public static bool operator ==(half lhs, half rhs) => default; // 0x000000018BD8BD40-0x000000018BD8BD48
		public bool Equals(half rhs) => default; // 0x000000018514EBE0-0x000000018514EBF0
		public override bool Equals(object o) => default; // 0x000000018BD8BC54-0x000000018BD8BCB4
		public override int GetHashCode() => default; // 0x0000000182FA7E40-0x0000000182FA7E50
		public override string ToString() => default; // 0x000000018BD8BCB4-0x000000018BD8BCD8
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8BCD8-0x000000018BD8BD0C
	}

	[Serializable]
	public struct half2 : IEquatable<Unity.Mathematics.half2>, IFormattable // TypeDefIndex: 54743
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54742
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public half2(half x, half y) {
			this.x = default;
			this.y = default;
		} // 0x0000000185FCFBE0-0x0000000185FCFBF0
		public half2(half2 xy) {
			x = default;
			y = default;
		} // 0x0000000185FE2FB0-0x0000000185FE2FC0
		public half2(half v) {
			x = default;
			y = default;
		} // 0x0000000185FE2FA0-0x0000000185FE2FB0
		public half2(float v) {
			x = default;
			y = default;
		} // 0x000000018BD8B440-0x000000018BD8B468
		public half2(float2 v) {
			x = default;
			y = default;
		} // 0x000000018BD8B468-0x000000018BD8B498
		public half2(double v) {
			x = default;
			y = default;
		} // 0x000000018BD8B410-0x000000018BD8B440
		public half2(double2 v) {
			x = default;
			y = default;
		} // 0x000000018BD8B498-0x000000018BD8B4CC
	
		// Methods
		public static explicit operator half2(float2 v) => default; // 0x000000018BD4EFD8-0x000000018BD4F00C
		public bool Equals(half2 rhs) => default; // 0x000000018BD8B2A4-0x000000018BD8B2B8
		public override bool Equals(object o) => default; // 0x000000018BD8B230-0x000000018BD8B2A4
		public override int GetHashCode() => default; // 0x000000018BD8B2B8-0x000000018BD8B300
		public override string ToString() => default; // 0x000000018BD8B384-0x000000018BD8B410
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8B300-0x000000018BD8B384
	}

	[Serializable]
	public struct half3 : IEquatable<Unity.Mathematics.half3>, IFormattable // TypeDefIndex: 54745
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
		public half z; // 0x04
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54744
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public half3(half x, half y, half z) {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000185FDE200-0x0000000185FDE210
		public half3(half x, half2 yz) {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000185FE2FC0-0x0000000185FE2FE0
		public half3(half2 xy, half z) {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000185FE2FE0-0x0000000185FE2FF0
		public half3(half3 xyz) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE2FF0-0x0000000185FE3010
		public half3(half v) {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE3010-0x0000000185FE3020
		public half3(float v) {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD8B78C-0x000000018BD8B7C4
		public half3(float3 v) {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD8B7C4-0x000000018BD8B800
		public half3(double v) {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD8B700-0x000000018BD8B744
		public half3(double3 v) {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD8B744-0x000000018BD8B78C
	
		// Methods
		public static explicit operator half3(float3 v) => default; // 0x000000018BD4F09C-0x000000018BD4F0E0
		public static explicit operator half3(double3 v) => default; // 0x000000018BD4F050-0x000000018BD4F09C
		public bool Equals(half3 rhs) => default; // 0x000000018BD8B4CC-0x000000018BD8B4F0
		public override bool Equals(object o) => default; // 0x000000018BD8B4F0-0x000000018BD8B57C
		public override int GetHashCode() => default; // 0x000000018BD8B57C-0x000000018BD8B5A0
		public override string ToString() => default; // 0x000000018BD8B648-0x000000018BD8B700
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8B5A0-0x000000018BD8B648
	}

	[Serializable]
	public struct half4 : IEquatable<Unity.Mathematics.half4>, IFormattable // TypeDefIndex: 54747
	{
		// Fields
		public half x; // 0x00
		public half y; // 0x02
		public half z; // 0x04
		public half w; // 0x06
		public static readonly half4 zero; // 0x00
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54746
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
		} // 0x0000000185FDE2C0-0x0000000185FDE2E0
		public half4(half x, half y, half2 zw) {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000185FE3090-0x0000000185FE30B0
		public half4(half x, half2 yz, half w) {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FE30B0-0x0000000185FE30D0
		public half4(half x, half3 yzw) {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE3100-0x0000000185FE3120
		public half4(half2 xy, half z, half w) {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000185FE3020-0x0000000185FE3040
		public half4(half2 xy, half2 zw) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE3040-0x0000000185FE3060
		public half4(half3 xyz, half w) {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FE30E0-0x0000000185FE3100
		public half4(half4 xyzw) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE3060-0x0000000185FE3090
		public half4(half v) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE30D0-0x0000000185FE30E0
		public half4(float v) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD8BC10-0x000000018BD8BC54
		public half4(float4 v) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD8BB14-0x000000018BD8BB60
		public half4(double v) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD8BBBC-0x000000018BD8BC10
		public half4(double4 v) {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD8BB60-0x000000018BD8BBBC
	
		// Methods
		public static explicit operator half4(float4 v) => default; // 0x000000018BD4F218-0x000000018BD4F26C
		public bool Equals(half4 rhs) => default; // 0x000000018BD83950-0x000000018BD83CF0
		public override bool Equals(object o) => default; // 0x000000018BD8B800-0x000000018BD8B860
		public override int GetHashCode() => default; // 0x000000018BD8B860-0x000000018BD8B868
		public override string ToString() => default; // 0x000000018BD8B868-0x000000018BD8B9CC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8B9CC-0x000000018BD8BB14
	}

	[Serializable]
	public struct int2 : IEquatable<Unity.Mathematics.int2>, IFormattable // TypeDefIndex: 54749
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public static readonly int2 zero; // 0x00
	
		// Properties
		public int2 xy { get => default; } // 0x0000000185FBF370-0x0000000185FBF390 
		public int this[int index] { set {} } // 0x0000000185FB71E0-0x0000000185FB71F0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54748
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public int2(int x, int y) : this() {
			this.x = default;
			this.y = default;
		} // 0x000000018357CB90-0x000000018357CBA0
		public int2(int2 xy) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE3180-0x0000000185FE3190
		public int2(int v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE3120-0x0000000185FE3130
		public int2(bool v) : this() {
			x = default;
			y = default;
		} // 0x000000018BD8BF20-0x000000018BD8BF30
		public int2(bool2 v) : this() {
			x = default;
			y = default;
		} // 0x000000018BD8BF30-0x000000018BD8BF4C
		public int2(uint v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE3120-0x0000000185FE3130
		public int2(uint2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE3180-0x0000000185FE3190
		public int2(float v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE3170-0x0000000185FE3180
		public int2(float2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE3140-0x0000000185FE3160
		public int2(double v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE3160-0x0000000185FE3170
		public int2(double2 v) : this() {
			x = default;
			y = default;
		} // 0x0000000185FE3130-0x0000000185FE3140
	
		// Methods
		public static implicit operator int2(int v) => default; // 0x0000000185FDC1B0-0x0000000185FDC1C0
		public static explicit operator int2(uint v) => default; // 0x0000000185FDC1B0-0x0000000185FDC1C0
		public static explicit operator int2(uint2 v) => default; // 0x0000000185FD75B0-0x0000000185FD75D0
		public static explicit operator int2(float v) => default; // 0x0000000185FDC190-0x0000000185FDC1B0
		public static explicit operator int2(float2 v) => default; // 0x0000000185FDC150-0x0000000185FDC170
		public static explicit operator int2(double v) => default; // 0x0000000185FDC170-0x0000000185FDC190
		public static explicit operator int2(double2 v) => default; // 0x0000000185FDC1C0-0x0000000185FDC1E0
		public static int2 operator *(int2 lhs, int2 rhs) => default; // 0x0000000185FE31F0-0x0000000185FE3210
		public static int2 operator *(int2 lhs, int rhs) => default; // 0x0000000185FE31D0-0x0000000185FE31F0
		public static int2 operator +(int2 lhs, int2 rhs) => default; // 0x0000000185FB0040-0x0000000185FB0060
		public static int2 operator +(int2 lhs, int rhs) => default; // 0x0000000185FE3190-0x0000000185FE31B0
		public static int2 operator -(int2 lhs, int rhs) => default; // 0x0000000185FE3240-0x0000000185FE3260
		public static int2 operator /(int2 lhs, int rhs) => default; // 0x000000018BD8BF4C-0x000000018BD8BF70
		public static bool2 operator >(int2 lhs, int rhs) => default; // 0x000000018BD8BF90-0x000000018BD8BFA8
		public static bool2 operator >=(int2 lhs, int rhs) => default; // 0x000000018BD8BF70-0x000000018BD8BF90
		public static int2 operator -(int2 val) => default; // 0x0000000185FE3260-0x0000000185FE3280
		public static int2 operator >>(int2 x, int n) => default; // 0x0000000185FE3210-0x0000000185FE3240
		public static int2 operator |(int2 lhs, int2 rhs) => default; // 0x0000000185FE31B0-0x0000000185FE31D0
		public bool Equals(int2 rhs) => default; // 0x0000000187333DF8-0x0000000187333E0C
		public override bool Equals(object o) => default; // 0x000000018BD8BD68-0x000000018BD8BDDC
		public override int GetHashCode() => default; // 0x000000018BD8BDDC-0x000000018BD8BE10
		public override string ToString() => default; // 0x000000018BD8BE98-0x000000018BD8BF20
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8BE10-0x000000018BD8BE98
	}

	[Serializable]
	public struct int2x2 : IEquatable<Unity.Mathematics.int2x2>, IFormattable // TypeDefIndex: 54750
	{
		// Fields
		public int2 c0; // 0x00
		public int2 c1; // 0x08
		public static readonly int2x2 identity; // 0x00
	
		// Constructors
		public int2x2(int2 c0, int2 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183680100-0x0000000183680110
		public int2x2(int m00, int m01, int m10, int m11) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE33C0-0x0000000185FE33F0
		public int2x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3300-0x0000000185FE3330
		public int2x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD8C350-0x000000018BD8C398
		public int2x2(bool2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD8C2E0-0x000000018BD8C350
		public int2x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3300-0x0000000185FE3330
		public int2x2(uint2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE33F0-0x0000000185FE3430
		public int2x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3280-0x0000000185FE32C0
		public int2x2(float2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3370-0x0000000185FE33C0
		public int2x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3330-0x0000000185FE3370
		public int2x2(double2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE32C0-0x0000000185FE3300
		static int2x2() {
			identity = default;
		} // 0x0000000185F0ED80-0x0000000185F0EDE0
	
		// Methods
		public bool Equals(int2x2 rhs) => default; // 0x000000018BD83CF0-0x000000018BD86E38
		public override bool Equals(object o) => default; // 0x000000018BD8BFA8-0x000000018BD8C014
		public override int GetHashCode() => default; // 0x000000018BD8C014-0x000000018BD8C030
		public override string ToString() => default; // 0x000000018BD8C030-0x000000018BD8C18C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8C18C-0x000000018BD8C2E0
	}

	[Serializable]
	public struct int2x3 : IEquatable<Unity.Mathematics.int2x3>, IFormattable // TypeDefIndex: 54751
	{
		// Fields
		public int2 c0; // 0x00
		public int2 c1; // 0x08
		public int2 c2; // 0x10
	
		// Properties
		public ref int2 this[int index] { get => default; } // 0x0000000185FE3670-0x0000000185FE3680 
	
		// Constructors
		public int2x3(int2 c0, int2 c1, int2 c2) : this() {
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
		} // 0x0000000185FB6010-0x0000000185FB6020
		public int2x3(int m00, int m01, int m02, int m10, int m11, int m12) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3620-0x0000000185FE3670
		public int2x3(int v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3590-0x0000000185FE35D0
		public int2x3(bool v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD8C8AC-0x000000018BD8C910
		public int2x3(bool2x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD8C814-0x000000018BD8C8AC
		public int2x3(uint v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3590-0x0000000185FE35D0
		public int2x3(uint2x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE35D0-0x0000000185FE3620
		public int2x3(float v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE34E0-0x0000000185FE3530
		public int2x3(float2x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3530-0x0000000185FE3590
		public int2x3(double v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3430-0x0000000185FE3480
		public int2x3(double2x3 v) : this() {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3480-0x0000000185FE34E0
	
		// Methods
		public bool Equals(int2x3 rhs) => default; // 0x000000018BD8C398-0x000000018BD8C3FC
		public override bool Equals(object o) => default; // 0x000000018BD8C3FC-0x000000018BD8C470
		public override int GetHashCode() => default; // 0x000000018BD8C470-0x000000018BD8C498
		public override string ToString() => default; // 0x000000018BD8C498-0x000000018BD8C660
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8C660-0x000000018BD8C814
	}

	[Serializable]
	public struct int2x4 : IEquatable<Unity.Mathematics.int2x4>, IFormattable // TypeDefIndex: 54752
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
		} // 0x0000000185FB04D0-0x0000000185FB04F0
		public int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3770-0x0000000185FE37D0
		public int2x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3850-0x0000000185FE38A0
		public int2x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8CF2C-0x000000018BD8CFB0
		public int2x4(bool2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8CE60-0x000000018BD8CF2C
		public int2x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3850-0x0000000185FE38A0
		public int2x4(uint2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3700-0x0000000185FE3770
		public int2x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE38A0-0x0000000185FE3910
		public int2x4(float2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3680-0x0000000185FE3700
		public int2x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3910-0x0000000185FE3980
		public int2x4(double2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE37D0-0x0000000185FE3850
	
		// Methods
		public bool Equals(int2x4 rhs) => default; // 0x000000018BD8C984-0x000000018BD8C9F8
		public override bool Equals(object o) => default; // 0x000000018BD8C910-0x000000018BD8C984
		public override int GetHashCode() => default; // 0x000000018BD8C9F8-0x000000018BD8CA1C
		public override string ToString() => default; // 0x000000018BD8CC30-0x000000018BD8CE60
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8CA1C-0x000000018BD8CC30
	}

	[Serializable]
	public struct int3 : IEquatable<Unity.Mathematics.int3>, IFormattable // TypeDefIndex: 54754
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public static readonly int3 zero; // 0x00
	
		// Properties
		public int3 xyz { set {} } // 0x0000000185FB2F50-0x0000000185FB2F70
		public int3 xzy { get => default; } // 0x0000000185FE1440-0x0000000185FE1460 
		public int2 xy { get => default; set {} } // 0x0000000185FBF370-0x0000000185FBF390 0x0000000185FE3180-0x0000000185FE3190
		public int2 yz { get => default; } // 0x0000000185FE3A30-0x0000000185FE3A50 
		public int2 zx { get => default; } // 0x0000000185FE3A50-0x0000000185FE3A70 
		public int this[int index] { get => default; set {} } // 0x0000000185FB71C0-0x0000000185FB71D0 0x0000000185FB71E0-0x0000000185FB71F0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54753
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public int3(int x, int y, int z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000185FB0130-0x0000000185FB0140
		public int3(int x, int2 yz) : this() {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000185FE3980-0x0000000185FE3990
		public int3(int2 xy, int z) : this() {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000185FE3A20-0x0000000185FE3A30
		public int3(int3 xyz) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FB2F50-0x0000000185FB2F70
		public int3(int v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE39F0-0x0000000185FE3A00
		public int3(bool v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD8D1B4-0x000000018BD8D1C8
		public int3(bool3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD8D188-0x000000018BD8D1B4
		public int3(uint v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE39F0-0x0000000185FE3A00
		public int3(uint3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FB2F50-0x0000000185FB2F70
		public int3(float v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE39B0-0x0000000185FE39D0
		public int3(float3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE3990-0x0000000185FE39B0
		public int3(double v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE39D0-0x0000000185FE39F0
		public int3(double3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE3A00-0x0000000185FE3A20
	
		// Methods
		public static implicit operator int3(int v) => default; // 0x0000000185FDC200-0x0000000185FDC210
		public static explicit operator int3(uint v) => default; // 0x0000000185FDC200-0x0000000185FDC210
		public static explicit operator int3(uint3 v) => default; // 0x0000000185FDC280-0x0000000185FDC2B0
		public static explicit operator int3(float v) => default; // 0x0000000185FDC2D0-0x0000000185FDC2F0
		public static explicit operator int3(float3 v) => default; // 0x0000000185FDC210-0x0000000185FDC240
		public static explicit operator int3(double v) => default; // 0x0000000185FDC2B0-0x0000000185FDC2D0
		public static explicit operator int3(double3 v) => default; // 0x0000000185FDC2F0-0x0000000185FDC330
		public static int3 operator *(int3 lhs, int3 rhs) => default; // 0x0000000184EE5950-0x0000000184EE5980
		public static int3 operator *(int3 lhs, int rhs) => default; // 0x0000000185FE3AC0-0x0000000185FE3AE0
		public static int3 operator +(int3 lhs, int3 rhs) => default; // 0x000000018403F990-0x000000018403F9B0
		public static int3 operator +(int3 lhs, int rhs) => default; // 0x0000000185FE3A70-0x0000000185FE3AA0
		public static int3 operator -(int3 lhs, int3 rhs) => default; // 0x0000000185FE3B30-0x0000000185FE3B50
		public static int3 operator -(int3 lhs, int rhs) => default; // 0x0000000185FE3B10-0x0000000185FE3B30
		public static int3 operator /(int3 lhs, int rhs) => default; // 0x000000018BD8D1C8-0x000000018BD8D1F0
		public static bool3 operator <=(int3 lhs, int3 rhs) => default; // 0x000000018BD8D2A8-0x000000018BD8D2D4
		public static bool3 operator >(int3 lhs, int rhs) => default; // 0x000000018BD8D23C-0x000000018BD8D25C
		public static bool3 operator >=(int3 lhs, int3 rhs) => default; // 0x000000018BD8D1F0-0x000000018BD8D21C
		public static bool3 operator >=(int3 lhs, int rhs) => default; // 0x000000018BD8D21C-0x000000018BD8D23C
		public static int3 operator -(int3 val) => default; // 0x0000000185FE3B50-0x0000000185FE3B70
		public static int3 operator >>(int3 x, int n) => default; // 0x0000000185FE3AE0-0x0000000185FE3B10
		public static bool3 operator !=(int3 lhs, int3 rhs) => default; // 0x000000018BD8D27C-0x000000018BD8D2A8
		public static bool3 operator !=(int3 lhs, int rhs) => default; // 0x000000018BD8D25C-0x000000018BD8D27C
		public static int3 operator |(int3 lhs, int3 rhs) => default; // 0x0000000185FE3AA0-0x0000000185FE3AC0
		public bool Equals(int3 rhs) => default; // 0x00000001873341CC-0x00000001873341E8
		public override bool Equals(object o) => default; // 0x000000018BD8CFB0-0x000000018BD8D024
		public override int GetHashCode() => default; // 0x0000000187ED5EDC-0x0000000187ED5F00
		public override string ToString() => default; // 0x000000018BD8D0D4-0x000000018BD8D188
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8D024-0x000000018BD8D0D4
	}

	[Serializable]
	public struct int3x2 : IEquatable<Unity.Mathematics.int3x2>, IFormattable // TypeDefIndex: 54755
	{
		// Fields
		public int3 c0; // 0x00
		public int3 c1; // 0x0C
	
		// Constructors
		public int3x2(int3 c0, int3 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000185FB1480-0x0000000185FB14A0
		public int3x2(int m00, int m01, int m10, int m11, int m20, int m21) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3B70-0x0000000185FE3BB0
		public int3x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3C00-0x0000000185FE3C30
		public int3x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F137A0-0x0000000186F13970
		public int3x2(bool3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD8D764-0x000000018BD8D850
		public int3x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3C00-0x0000000185FE3C30
		public int3x2(uint3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F13970-0x0000000186F139E4
		public int3x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3BB0-0x0000000185FE3C00
		public int3x2(float3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F139E4-0x0000000186F13BA4
		public int3x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3C30-0x0000000185FE3C80
		public int3x2(double3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD8D6EC-0x000000018BD8D764
	
		// Methods
		public bool Equals(int3x2 rhs) => default; // 0x0000000187740000-0x0000000187740064
		public override bool Equals(object o) => default; // 0x000000018BD8D2D4-0x000000018BD8D348
		public override int GetHashCode() => default; // 0x000000018BD8D348-0x000000018BD8D370
		public override string ToString() => default; // 0x000000018BD8D524-0x000000018BD8D6EC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8D370-0x000000018BD8D524
	}

	[Serializable]
	public struct int3x3 : IEquatable<Unity.Mathematics.int3x3>, IFormattable // TypeDefIndex: 54756
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
		} // 0x0000000185FB65B0-0x0000000185FB65F0
		public int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185DA9820-0x0000000185DA9880
		public int3x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3C80-0x0000000185FE3CD0
		public int3x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F13C48-0x0000000186F13CD8
		public int3x3(bool3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD8DE2C-0x000000018BD8DF74
		public int3x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3C80-0x0000000185FE3CD0
		public int3x3(uint3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F13CD8-0x0000000186F13E24
		public int3x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3D40-0x0000000185FE3DB0
		public int3x3(float3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F13BA4-0x0000000186F13C48
		public int3x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3CD0-0x0000000185FE3D40
		public int3x3(double3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD8DF74-0x000000018BD8E01C
		static int3x3() {
			identity = default;
		} // 0x0000000185DA9880-0x0000000185DA9920
	
		// Methods
		public bool Equals(int3x3 rhs) => default; // 0x000000018BD8D8CC-0x000000018BD8D958
		public override bool Equals(object o) => default; // 0x000000018BD8D850-0x000000018BD8D8CC
		public override int GetHashCode() => default; // 0x000000018BD8D958-0x000000018BD8D984
		public override string ToString() => default; // 0x000000018BD8DBC8-0x000000018BD8DE2C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8D984-0x000000018BD8DBC8
	}

	[Serializable]
	public struct int3x4 : IEquatable<Unity.Mathematics.int3x4>, IFormattable // TypeDefIndex: 54757
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
		} // 0x0000000185FE24E0-0x0000000185FE2530
		public int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3F30-0x0000000185FE3FC0
		public int3x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3E40-0x0000000185FE3EA0
		public int3x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F13FCC-0x0000000186F1434C
		public int3x4(bool3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8E760-0x000000018BD8E8F4
		public int3x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3E40-0x0000000185FE3EA0
		public int3x4(uint3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F13E24-0x0000000186F13EF8
		public int3x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3DB0-0x0000000185FE3E40
		public int3x4(float3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F13EF8-0x0000000186F13FCC
		public int3x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3EA0-0x0000000185FE3F30
		public int3x4(double3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8E8F4-0x000000018BD8E9D0
	
		// Methods
		public bool Equals(int3x4 rhs) => default; // 0x000000018BD8E098-0x000000018BD8E15C
		public override bool Equals(object o) => default; // 0x000000018BD8E01C-0x000000018BD8E098
		public override int GetHashCode() => default; // 0x000000018BD8E15C-0x000000018BD8E18C
		public override string ToString() => default; // 0x000000018BD8E18C-0x000000018BD8E48C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8E48C-0x000000018BD8E760
	}

	[Serializable]
	public struct int4 : IEquatable<Unity.Mathematics.int4>, IFormattable // TypeDefIndex: 54759
	{
		// Fields
		public int x; // 0x00
		public int y; // 0x04
		public int z; // 0x08
		public int w; // 0x0C
		public static readonly int4 zero; // 0x00
	
		// Properties
		public int this[int index] { get => default; set {} } // 0x0000000185FB71C0-0x0000000185FB71D0 0x0000000185FB71E0-0x0000000185FB71F0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54758
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
		} // 0x0000000185FB2C50-0x0000000185FB2C70
		public int4(int x, int y, int2 zw) : this() {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000185FE3FC0-0x0000000185FE3FE0
		public int4(int x, int2 yz, int w) : this() {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FE40C0-0x0000000185FE40E0
		public int4(int x, int3 yzw) : this() {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE4090-0x0000000185FE40B0
		public int4(int2 xy, int z, int w) : this() {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000185FE40E0-0x0000000185FE4100
		public int4(int2 xy, int2 zw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE3FE0-0x0000000185FE4000
		public int4(int3 xyz, int w) : this() {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FE4070-0x0000000185FE4090
		public int4(int4 xyzw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FBF140-0x0000000185FBF160
		public int4(int v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE4020-0x0000000185FE4030
		public int4(bool v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD8ED08-0x000000018BD8ED24
		public int4(bool4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD8ED24-0x000000018BD8ED68
		public int4(uint v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE4020-0x0000000185FE4030
		public int4(uint4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FBF140-0x0000000185FBF160
		public int4(float v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE4000-0x0000000185FE4020
		public int4(float4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE40B0-0x0000000185FE40C0
		public int4(double v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE4030-0x0000000185FE4050
		public int4(double4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE4050-0x0000000185FE4070
	
		// Methods
		public static implicit operator int4(int v) => default; // 0x0000000185FDC330-0x0000000185FDC340
		public static explicit operator int4(uint v) => default; // 0x0000000185FDC330-0x0000000185FDC340
		public static explicit operator int4(uint4 v) => default; // 0x000000018BD568A0-0x000000018BD568CC
		public static explicit operator int4(float v) => default; // 0x0000000185FDC3A0-0x0000000185FDC3C0
		public static explicit operator int4(float4 v) => default; // 0x000000018BD56960-0x000000018BD56994
		public static explicit operator int4(double v) => default; // 0x0000000185FDC380-0x0000000185FDC3A0
		public static explicit operator int4(double4 v) => default; // 0x000000018BD56930-0x000000018BD56960
		public static int4 operator *(int4 lhs, int4 rhs) => default; // 0x0000000185FE4160-0x0000000185FE4190
		public static int4 operator *(int4 lhs, int rhs) => default; // 0x0000000185FE4190-0x0000000185FE41C0
		public static int4 operator +(int4 lhs, int4 rhs) => default; // 0x0000000185FE4130-0x0000000185FE4160
		public static int4 operator +(int4 lhs, int rhs) => default; // 0x0000000185FE4100-0x0000000185FE4130
		public static int4 operator -(int4 lhs, int rhs) => default; // 0x0000000185FE41F0-0x0000000185FE4220
		public static bool4 operator >(int4 lhs, int rhs) => default; // 0x000000018BD8ED8C-0x000000018BD8EDB0
		public static bool4 operator >=(int4 lhs, int rhs) => default; // 0x000000018BD8ED68-0x000000018BD8ED8C
		public static int4 operator -(int4 val) => default; // 0x0000000185FE4220-0x0000000185FE4250
		public static int4 operator >>(int4 x, int n) => default; // 0x0000000185FE41C0-0x0000000185FE41F0
		public static int4 operator |(int4 lhs, int4 rhs) => default; // 0x00000001845B98A0-0x00000001845B98D0
		public bool Equals(int4 rhs) => default; // 0x0000000187841394-0x00000001878413B8
		public override bool Equals(object o) => default; // 0x000000018BD8E9D0-0x000000018BD8EA3C
		public override int GetHashCode() => default; // 0x000000018BD8EA3C-0x000000018BD8EA58
		public override string ToString() => default; // 0x000000018BD8EA58-0x000000018BD8EBB4
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8EBB4-0x000000018BD8ED08
	}

	[Serializable]
	public struct int4x2 : IEquatable<Unity.Mathematics.int4x2>, IFormattable // TypeDefIndex: 54760
	{
		// Fields
		public int4 c0; // 0x00
		public int4 c1; // 0x10
	
		// Constructors
		public int4x2(int4 c0, int4 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000185FB6710-0x0000000185FB6720
		public int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE42B0-0x0000000185FE4300
		public int4x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE4250-0x0000000185FE4290
		public int4x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F143C8-0x0000000186F144B8
		public int4x2(bool4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F1434C-0x0000000186F143C8
		public int4x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE4250-0x0000000185FE4290
		public int4x2(uint4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD8F334-0x000000018BD8F39C
		public int4x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE4290-0x0000000185FE42B0
		public int4x2(float4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F144B8-0x0000000186F14540
		public int4x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE4300-0x0000000185FE4360
		public int4x2(double4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD8F2D0-0x000000018BD8F334
	
		// Methods
		public static implicit operator int4x2(int v) => default; // 0x0000000183F75500-0x0000000183F76C40
		public bool Equals(int4x2 rhs) => default; // 0x000000018BD8EDB0-0x000000018BD8EDF4
		public override bool Equals(object o) => default; // 0x000000018BD8EDF4-0x000000018BD8EE68
		public override int GetHashCode() => default; // 0x000000018BD8EE68-0x000000018BD8EE8C
		public override string ToString() => default; // 0x000000018BD8EE8C-0x000000018BD8F0BC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8F0BC-0x000000018BD8F2D0
	}

	[Serializable]
	public struct int4x3 : IEquatable<Unity.Mathematics.int4x3>, IFormattable // TypeDefIndex: 54761
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
		} // 0x0000000185FCC290-0x0000000185FCC2B0
		public int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE43E0-0x0000000185FE4460
		public int4x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE4460-0x0000000185FE44B0
		public int4x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F145F8-0x0000000186F146B4
		public int4x3(bool4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F14540-0x0000000186F145F8
		public int4x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE4460-0x0000000185FE44B0
		public int4x3(uint4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD8FA7C-0x000000018BD8FB04
		public int4x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE44B0-0x0000000185FE44E0
		public int4x3(float4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F146B4-0x0000000186F14804
		public int4x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE4360-0x0000000185FE43E0
		public int4x3(double4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD8FB04-0x000000018BD8FB90
	
		// Methods
		public bool Equals(int4x3 rhs) => default; // 0x000000018BD8F418-0x000000018BD8F478
		public override bool Equals(object o) => default; // 0x000000018BD8F39C-0x000000018BD8F418
		public override int GetHashCode() => default; // 0x000000018BD8F478-0x000000018BD8F4A8
		public override string ToString() => default; // 0x000000018BD8F77C-0x000000018BD8FA7C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8F4A8-0x000000018BD8F77C
	}

	[Serializable]
	public struct int4x4 : IEquatable<Unity.Mathematics.int4x4>, IFormattable // TypeDefIndex: 54762
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
		} // 0x0000000185FDF130-0x0000000185FDF160
		public int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185C54700-0x0000000185C547B0
		public int4x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE4590-0x0000000185FE45F0
		public int4x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F14804-0x0000000186F148F4
		public int4x4(bool4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F148F4-0x0000000186F14A90
		public int4x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE4590-0x0000000185FE45F0
		public int4x4(uint4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD9042C-0x000000018BD904D8
		public int4x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE45F0-0x0000000185FE4630
		public int4x4(float4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F14A90-0x0000000186F16248
		public int4x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE44E0-0x0000000185FE4590
		public int4x4(double4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD904D8-0x000000018BD93934
		static int4x4() {
			identity = default;
		} // 0x0000000185C547B0-0x0000000185C548A0
	
		// Methods
		public bool Equals(int4x4 rhs) => default; // 0x000000018BD8FC14-0x000000018BD8FC90
		public override bool Equals(object o) => default; // 0x000000018BD8FB90-0x000000018BD8FC14
		public override int GetHashCode() => default; // 0x000000018BD8FC90-0x000000018BD8FCC8
		public override string ToString() => default; // 0x000000018BD9005C-0x000000018BD9042C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD8FCC8-0x000000018BD9005C
	}

	[Serializable]
	public struct quaternion : IEquatable<Unity.Mathematics.quaternion>, IFormattable // TypeDefIndex: 54763
	{
		// Fields
		public float4 value; // 0x00
		public static readonly quaternion identity; // 0x00
	
		// Constructors
		public quaternion(float x, float y, float z, float w) {
			value = default;
		} // 0x0000000185FB2B40-0x0000000185FB2B60
		public quaternion(float4 value) {
			this.value = default;
		} // 0x0000000185FBFA60-0x0000000185FBFA70
		public quaternion(float3x3 m) {
			value = default;
		} // 0x00000001845B9430-0x00000001845B9810
		public quaternion(float4x4 m) {
			value = default;
		} // 0x000000018BD95FA4-0x000000018BD962C4
		static quaternion() {
			identity = default;
		} // 0x0000000185F9A9B0-0x0000000185F9A9F0
	
		// Methods
		public static implicit operator Quaternion(quaternion q) => default; // 0x00000001840F57D0-0x00000001840F57F0
		public static implicit operator quaternion(Quaternion q) => default; // 0x00000001840F57D0-0x00000001840F57F0
		public static implicit operator quaternion(float4 v) => default; // 0x0000000181D61820-0x0000000181D61830
		public static quaternion AxisAngle(float3 axis, float angle) => default; // 0x00000001872C1E5C-0x00000001872C1F68
		public static quaternion EulerXYZ(float3 xyz) => default; // 0x00000001872C1F68-0x00000001872C2148
		public static quaternion EulerXZY(float3 xyz) => default; // 0x00000001872C2148-0x00000001872C2328
		public static quaternion EulerYXZ(float3 xyz) => default; // 0x00000001872C2328-0x00000001872C2508
		public static quaternion EulerYZX(float3 xyz) => default; // 0x00000001872C2508-0x00000001872C26E8
		public static quaternion EulerZXY(float3 xyz) => default; // 0x000000018BD954A4-0x000000018BD95684
		public static quaternion EulerZYX(float3 xyz) => default; // 0x00000001872C2720-0x00000001872C2900
		public static quaternion EulerXYZ(float x, float y, float z) => default; // 0x000000018BD953C4-0x000000018BD953FC
		public static quaternion EulerXZY(float x, float y, float z) => default; // 0x000000018BD953FC-0x000000018BD95434
		public static quaternion EulerYXZ(float x, float y, float z) => default; // 0x000000018BD95434-0x000000018BD9546C
		public static quaternion EulerYZX(float x, float y, float z) => default; // 0x000000018BD9546C-0x000000018BD954A4
		public static quaternion EulerZXY(float x, float y, float z) => default; // 0x00000001872C26E8-0x00000001872C2720
		public static quaternion EulerZYX(float x, float y, float z) => default; // 0x000000018BD95684-0x000000018BD956BC
		public static quaternion Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY /* Metadata: 0x0207B941 */) => default; // 0x000000018BD956F8-0x000000018BD95854
		public static quaternion Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY /* Metadata: 0x0207B942 */) => default; // 0x000000018BD956BC-0x000000018BD956F8
		public static quaternion RotateX(float angle) => default; // 0x00000001872C2900-0x00000001872C2964
		public static quaternion RotateY(float angle) => default; // 0x000000018BD95C80-0x000000018BD95CE4
		public static quaternion RotateZ(float angle) => default; // 0x00000001872C2964-0x00000001872C2B1C
		public static quaternion LookRotation(float3 forward, float3 up) => default; // 0x000000018BD95B64-0x000000018BD95C80
		public static quaternion LookRotationSafe(float3 forward, float3 up) => default; // 0x000000018BD95854-0x000000018BD95B64
		public bool Equals(quaternion x) => default; // 0x0000000184A6EB60-0x0000000184A6EBA0
		public override bool Equals(object x) => default; // 0x000000018BD95358-0x000000018BD953C4
		public override int GetHashCode() => default; // 0x000000018BD520A8-0x000000018BD520C4
		public override string ToString() => default; // 0x000000018BD95CE4-0x000000018BD95E50
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD95E50-0x000000018BD95FA4
	}

	public static class noise // TypeDefIndex: 54764
	{
		// Methods
		public static float cnoise(float2 P) => default; // 0x000000018BD93D6C-0x000000018BD942C4
		public static float pnoise(float2 P, float2 rep) => default; // 0x000000018BD9465C-0x000000018BD94BF0
		private static float2 mod289(float2 x) => default; // 0x000000018BD9440C-0x000000018BD9445C
		private static float3 mod289(float3 x) => default; // 0x000000018BD94340-0x000000018BD9440C
		private static float4 mod289(float4 x) => default; // 0x000000018BD9445C-0x000000018BD94500
		private static float3 permute(float3 x) => default; // 0x000000018BD94598-0x000000018BD9465C
		private static float4 permute(float4 x) => default; // 0x000000018BD94500-0x000000018BD94598
		private static float4 taylorInvSqrt(float4 r) => default; // 0x000000018BD95300-0x000000018BD95358
		private static float2 fade(float2 t) => default; // 0x000000018BD942C4-0x000000018BD94340
		public static float snoise(float2 v) => default; // 0x000000018BD94BF0-0x000000018BD95300
	}

	[Serializable]
	public struct Random // TypeDefIndex: 54765
	{
		// Fields
		public uint state; // 0x00
	
		// Constructors
		public Random(uint seed) {
			state = default;
		} // 0x0000000185FE4660-0x0000000185FE4680
	
		// Methods
		public static Random CreateFromIndex(uint index) => default; // 0x000000018BD93934-0x000000018BD9395C
		internal static uint WangHash(uint n) => default; // 0x0000000185EC2190-0x0000000185EC21C0
		public float NextFloat() => default; // 0x0000000184C9E970-0x0000000184C9E9B0
		public float3 NextFloat3() => default; // 0x000000018843B32C-0x000000018843B55C
		private uint NextState() => default; // 0x0000000185FE4630-0x0000000185FE4660
	}

	[Serializable]
	public struct RigidTransform // TypeDefIndex: 54766
	{
		// Fields
		public quaternion rot; // 0x00
		public float3 pos; // 0x10
		public static readonly RigidTransform identity; // 0x00
	
		// Constructors
		public RigidTransform(quaternion rotation, float3 translation) {
			rot = default;
			pos = default;
		} // 0x0000000185FE4680-0x0000000185FE46A0
		public RigidTransform(float3x3 rotation, float3 translation) {
			rot = default;
			pos = default;
		} // 0x000000018BD93C8C-0x000000018BD93CF0
		public RigidTransform(float4x4 transform) {
			rot = default;
			pos = default;
		} // 0x000000018BD93CF0-0x000000018BD93D6C
		static RigidTransform() {
			identity = default;
		} // 0x0000000185F80520-0x0000000185F80580
	
		// Methods
		public bool Equals(RigidTransform x) => default; // 0x000000018BD939D8-0x000000018BD93A28
		public override bool Equals(object x) => default; // 0x000000018BD9395C-0x000000018BD939D8
		public override int GetHashCode() => default; // 0x000000018BD93A28-0x000000018BD93A74
		public override string ToString() => default; // 0x000000018BD93A74-0x000000018BD93C8C
	}

	public static class svd // TypeDefIndex: 54767
	{
		// Methods
		private static void condSwap(bool c, ref float x, ref float y) {} // 0x0000000186F48858-0x0000000186F49330
		private static void condNegSwap(bool c, ref float3 x, ref float3 y) {} // 0x0000000186F487E4-0x0000000186F48858
		private static quaternion condNegSwapQuat(bool c, quaternion q, float4 mask) => default; // 0x000000018BD96368-0x000000018BD96424
		private static void sortSingularValues(ref float3x3 b, ref quaternion v) {} // 0x000000018BD96F34-0x000000018BD970DC
		private static quaternion approxGivensQuat(float3 pq, float4 mask) => default; // 0x000000018BD962C4-0x000000018BD96368
		private static quaternion qrGivensQuat(float2 pq, float4 mask) => default; // 0x000000018BD96B3C-0x000000018BD96C38
		private static quaternion givensQRFactorization(float3x3 b, out float3x3 r) {
			r = default;
			return default;
		} // 0x000000018BD96424-0x000000018BD966CC
		private static quaternion jacobiIteration(ref float3x3 s, int iterations = 5 /* Metadata: 0x0207B943 */) => default; // 0x000000018BD966CC-0x000000018BD96B3C
		private static float3 singularValuesDecomposition(float3x3 a, out quaternion u, out quaternion v) {
			u = default;
			v = default;
			return default;
		} // 0x000000018BD96D48-0x000000018BD96F34
		private static float3 rcpsafe(float3 x, float epsilon = 1E-09f /* Metadata: 0x0207B944 */) => default; // 0x000000018BD96C38-0x000000018BD96D48
		public static float3x3 svdInverse(float3x3 a) => default; // 0x000000018BD970DC-0x000000018BD972A4
		public static quaternion svdRotation(float3x3 a) => default; // 0x000000018BD972A4-0x000000018BD97344
	}

	[Serializable]
	public struct uint2 : IEquatable<Unity.Mathematics.uint2>, IFormattable // TypeDefIndex: 54769
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54768
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public uint2(uint x, uint y) {
			this.x = default;
			this.y = default;
		} // 0x000000018357CB90-0x000000018357CBA0
		public uint2(uint2 xy) {
			x = default;
			y = default;
		} // 0x0000000185FE3180-0x0000000185FE3190
		public uint2(uint v) {
			x = default;
			y = default;
		} // 0x0000000185FE3120-0x0000000185FE3130
		public uint2(bool v) {
			x = default;
			y = default;
		} // 0x000000018BD8BF20-0x000000018BD8BF30
		public uint2(bool2 v) {
			x = default;
			y = default;
		} // 0x000000018BD8BF30-0x000000018BD8BF4C
		public uint2(int v) {
			x = default;
			y = default;
		} // 0x0000000185FE3120-0x0000000185FE3130
		public uint2(int2 v) {
			x = default;
			y = default;
		} // 0x0000000185FE3180-0x0000000185FE3190
		public uint2(float v) {
			x = default;
			y = default;
		} // 0x0000000186F49330-0x0000000186F49490
		public uint2(float2 v) {
			x = default;
			y = default;
		} // 0x000000018BD97518-0x000000018BD97554
		public uint2(double v) {
			x = default;
			y = default;
		} // 0x000000018BD974FC-0x000000018BD97518
		public uint2(double2 v) {
			x = default;
			y = default;
		} // 0x000000018BD97554-0x000000018BD97578
	
		// Methods
		public static implicit operator uint2(uint v) => default; // 0x0000000185FDC1B0-0x0000000185FDC1C0
		public static explicit operator uint2(int v) => default; // 0x0000000185FDC1B0-0x0000000185FDC1C0
		public static explicit operator uint2(int2 v) => default; // 0x0000000185FD75B0-0x0000000185FD75D0
		public static explicit operator uint2(float v) => default; // 0x000000018BD71284-0x000000018BD712A8
		public static explicit operator uint2(float2 v) => default; // 0x000000018BD712A8-0x000000018BD712CC
		public static explicit operator uint2(double v) => default; // 0x000000018BD71264-0x000000018BD71284
		public static explicit operator uint2(double2 v) => default; // 0x000000018BD71234-0x000000018BD71264
		public static uint2 operator *(uint2 lhs, uint2 rhs) => default; // 0x0000000185FE31F0-0x0000000185FE3210
		public static uint2 operator *(uint2 lhs, uint rhs) => default; // 0x0000000185FE31D0-0x0000000185FE31F0
		public static uint2 operator +(uint2 lhs, uint2 rhs) => default; // 0x0000000185FB0040-0x0000000185FB0060
		public static uint2 operator +(uint2 lhs, uint rhs) => default; // 0x0000000185FE3190-0x0000000185FE31B0
		public static uint2 operator -(uint2 lhs, uint2 rhs) => default; // 0x0000000185FB0060-0x0000000185FB0080
		public static uint2 operator -(uint2 lhs, uint rhs) => default; // 0x0000000185FE3240-0x0000000185FE3260
		public static bool2 operator >(uint2 lhs, uint rhs) => default; // 0x000000018BD97590-0x000000018BD975A8
		public static uint2 operator <<(uint2 x, int n) => default; // 0x0000000185FE46E0-0x0000000185FE4710
		public static uint2 operator >>(uint2 x, int n) => default; // 0x0000000185FE4710-0x0000000185FE4740
		public static bool2 operator ==(uint2 lhs, uint rhs) => default; // 0x000000018BD97578-0x000000018BD97590
		public static uint2 operator &(uint2 lhs, uint rhs) => default; // 0x0000000185FE46A0-0x0000000185FE46C0
		public static uint2 operator |(uint2 lhs, uint2 rhs) => default; // 0x0000000185FE31B0-0x0000000185FE31D0
		public static uint2 operator ^(uint2 lhs, uint2 rhs) => default; // 0x0000000185FE46C0-0x0000000185FE46E0
		public bool Equals(uint2 rhs) => default; // 0x0000000187333DF8-0x0000000187333E0C
		public override bool Equals(object o) => default; // 0x000000018BD97344-0x000000018BD973B8
		public override int GetHashCode() => default; // 0x000000018BD973B8-0x000000018BD973EC
		public override string ToString() => default; // 0x000000018BD97474-0x000000018BD974FC
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD973EC-0x000000018BD97474
	}

	[Serializable]
	public struct uint2x2 : IEquatable<Unity.Mathematics.uint2x2>, IFormattable // TypeDefIndex: 54770
	{
		// Fields
		public uint2 c0; // 0x00
		public uint2 c1; // 0x08
		public static readonly uint2x2 identity; // 0x00
	
		// Constructors
		public uint2x2(uint2 c0, uint2 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000183680100-0x0000000183680110
		public uint2x2(uint m00, uint m01, uint m10, uint m11) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE33C0-0x0000000185FE33F0
		public uint2x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3300-0x0000000185FE3330
		public uint2x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD8C350-0x000000018BD8C398
		public uint2x2(bool2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD8C2E0-0x000000018BD8C350
		public uint2x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3300-0x0000000185FE3330
		public uint2x2(int2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE33F0-0x0000000185FE3430
		public uint2x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F494C8-0x0000000186F494F0
		public uint2x2(float2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F49490-0x0000000186F494C8
		public uint2x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD97938-0x000000018BD9797C
		public uint2x2(double2x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD978E0-0x000000018BD97938
		static uint2x2() {
			identity = default;
		} // 0x0000000185F0ED20-0x0000000185F0ED80
	
		// Methods
		public bool Equals(uint2x2 rhs) => default; // 0x000000018BD83CF0-0x000000018BD86E38
		public override bool Equals(object o) => default; // 0x000000018BD975A8-0x000000018BD97614
		public override int GetHashCode() => default; // 0x000000018BD97614-0x000000018BD97630
		public override string ToString() => default; // 0x000000018BD97784-0x000000018BD978E0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD97630-0x000000018BD97784
	}

	[Serializable]
	public struct uint2x3 : IEquatable<Unity.Mathematics.uint2x3>, IFormattable // TypeDefIndex: 54771
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
		} // 0x0000000185FB6010-0x0000000185FB6020
		public uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3620-0x0000000185FE3670
		public uint2x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3590-0x0000000185FE35D0
		public uint2x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD8C8AC-0x000000018BD8C910
		public uint2x3(bool2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD8C814-0x000000018BD8C8AC
		public uint2x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3590-0x0000000185FE35D0
		public uint2x3(int2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE35D0-0x0000000185FE3620
		public uint2x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F495A8-0x0000000186F49780
		public uint2x3(float2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F494F0-0x0000000186F495A8
		public uint2x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD97D94-0x000000018BD97DF0
		public uint2x3(double2x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD97DF0-0x000000018BD97E6C
	
		// Methods
		public bool Equals(uint2x3 rhs) => default; // 0x000000018BD8C398-0x000000018BD8C3FC
		public override bool Equals(object o) => default; // 0x000000018BD9797C-0x000000018BD979F0
		public override int GetHashCode() => default; // 0x000000018BD979F0-0x000000018BD97A18
		public override string ToString() => default; // 0x000000018BD97A18-0x000000018BD97BE0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD97BE0-0x000000018BD97D94
	}

	[Serializable]
	public struct uint2x4 : IEquatable<Unity.Mathematics.uint2x4>, IFormattable // TypeDefIndex: 54772
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
		} // 0x0000000185FB04D0-0x0000000185FB04F0
		public uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3770-0x0000000185FE37D0
		public uint2x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3850-0x0000000185FE38A0
		public uint2x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8CF2C-0x000000018BD8CFB0
		public uint2x4(bool2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8CE60-0x000000018BD8CF2C
		public uint2x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3850-0x0000000185FE38A0
		public uint2x4(int2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3700-0x0000000185FE3770
		public uint2x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F49780-0x0000000186F497C0
		public uint2x4(float2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F497C0-0x0000000186F49834
		public uint2x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD983E8-0x000000018BD98460
		public uint2x4(double2x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD98348-0x000000018BD983E8
	
		// Methods
		public bool Equals(uint2x4 rhs) => default; // 0x000000018BD8C984-0x000000018BD8C9F8
		public override bool Equals(object o) => default; // 0x000000018BD97E6C-0x000000018BD97EE0
		public override int GetHashCode() => default; // 0x000000018BD97EE0-0x000000018BD97F04
		public override string ToString() => default; // 0x000000018BD97F04-0x000000018BD98134
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD98134-0x000000018BD98348
	}

	[Serializable]
	public struct uint3 : IEquatable<Unity.Mathematics.uint3>, IFormattable // TypeDefIndex: 54774
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
		public uint z; // 0x08
	
		// Properties
		public uint4 xyzz { get => default; } // 0x0000000185FE13A0-0x0000000185FE13C0 
		public uint this[int index] { get => default; set {} } // 0x0000000185FB71C0-0x0000000185FB71D0 0x0000000185FB71E0-0x0000000185FB71F0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54773
		{
			// Constructors
			public DebuggerProxy() {} // Dummy constructor
		}
	
		// Constructors
		public uint3(uint x, uint y, uint z) : this() {
			this.x = default;
			this.y = default;
			this.z = default;
		} // 0x0000000185FB0130-0x0000000185FB0140
		public uint3(uint x, uint2 yz) : this() {
			this.x = default;
			y = default;
			z = default;
		} // 0x0000000185FE3980-0x0000000185FE3990
		public uint3(uint2 xy, uint z) : this() {
			x = default;
			y = default;
			this.z = default;
		} // 0x0000000185FE3A20-0x0000000185FE3A30
		public uint3(uint3 xyz) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FB2F50-0x0000000185FB2F70
		public uint3(uint v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE39F0-0x0000000185FE3A00
		public uint3(bool v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD8D1B4-0x000000018BD8D1C8
		public uint3(bool3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD8D188-0x000000018BD8D1B4
		public uint3(int v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FE39F0-0x0000000185FE3A00
		public uint3(int3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000185FB2F50-0x0000000185FB2F70
		public uint3(float v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000186F49880-0x0000000186F498B8
		public uint3(float3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x0000000186F49834-0x0000000186F49880
		public uint3(double v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD986AC-0x000000018BD986D0
		public uint3(double3 v) : this() {
			x = default;
			y = default;
			z = default;
		} // 0x000000018BD9867C-0x000000018BD986AC
	
		// Methods
		public static implicit operator uint3(uint v) => default; // 0x0000000185FDC200-0x0000000185FDC210
		public static explicit operator uint3(int v) => default; // 0x0000000185FDC200-0x0000000185FDC210
		public static explicit operator uint3(int3 v) => default; // 0x0000000185FDC280-0x0000000185FDC2B0
		public static explicit operator uint3(float v) => default; // 0x000000018BD71578-0x000000018BD71594
		public static explicit operator uint3(float3 v) => default; // 0x0000000186F498B8-0x0000000186F49904
		public static explicit operator uint3(double v) => default; // 0x000000018BD71550-0x000000018BD71578
		public static explicit operator uint3(double3 v) => default; // 0x000000018BD71518-0x000000018BD71550
		public static uint3 operator *(uint3 lhs, uint3 rhs) => default; // 0x0000000184EE5950-0x0000000184EE5980
		public static uint3 operator *(uint3 lhs, uint rhs) => default; // 0x0000000185FE3AC0-0x0000000185FE3AE0
		public static uint3 operator +(uint3 lhs, uint3 rhs) => default; // 0x000000018403F990-0x000000018403F9B0
		public static uint3 operator +(uint3 lhs, uint rhs) => default; // 0x0000000185FE3A70-0x0000000185FE3AA0
		public static uint3 operator -(uint3 lhs, uint3 rhs) => default; // 0x0000000185FE3B30-0x0000000185FE3B50
		public static uint3 operator -(uint3 lhs, uint rhs) => default; // 0x0000000185FE3B10-0x0000000185FE3B30
		public static bool3 operator >(uint3 lhs, uint rhs) => default; // 0x000000018BD986F0-0x000000018BD98710
		public static uint3 operator <<(uint3 x, int n) => default; // 0x0000000185FE4780-0x0000000185FE47B0
		public static uint3 operator >>(uint3 x, int n) => default; // 0x0000000185FE47B0-0x0000000185FE47F0
		public static bool3 operator ==(uint3 lhs, uint rhs) => default; // 0x000000018BD986D0-0x000000018BD986F0
		public static uint3 operator &(uint3 lhs, uint rhs) => default; // 0x0000000185FE4740-0x0000000185FE4760
		public static uint3 operator |(uint3 lhs, uint3 rhs) => default; // 0x0000000185FE3AA0-0x0000000185FE3AC0
		public static uint3 operator |(uint lhs, uint3 rhs) => default; // 0x0000000185FE4760-0x0000000185FE4780
		public static uint3 operator ^(uint3 lhs, uint3 rhs) => default; // 0x00000001845BB9C0-0x00000001845BB9E0
		public bool Equals(uint3 rhs) => default; // 0x00000001873341CC-0x00000001873341E8
		public override bool Equals(object o) => default; // 0x000000018BD98460-0x000000018BD984F4
		public override int GetHashCode() => default; // 0x000000018BD984F4-0x000000018BD98518
		public override string ToString() => default; // 0x000000018BD985C8-0x000000018BD9867C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD98518-0x000000018BD985C8
	}

	[Serializable]
	public struct uint3x2 : IEquatable<Unity.Mathematics.uint3x2>, IFormattable // TypeDefIndex: 54775
	{
		// Fields
		public uint3 c0; // 0x00
		public uint3 c1; // 0x0C
	
		// Constructors
		public uint3x2(uint3 c0, uint3 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000185FB1480-0x0000000185FB14A0
		public uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3B70-0x0000000185FE3BB0
		public uint3x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3C00-0x0000000185FE3C30
		public uint3x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F137A0-0x0000000186F13970
		public uint3x2(bool3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD8D764-0x000000018BD8D850
		public uint3x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE3C00-0x0000000185FE3C30
		public uint3x2(int3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F13970-0x0000000186F139E4
		public uint3x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F49904-0x0000000186F49960
		public uint3x2(float3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F49960-0x0000000186F49A64
		public uint3x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD98B98-0x000000018BD98BF4
		public uint3x2(double3x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD98BF4-0x000000018BD98C84
	
		// Methods
		public bool Equals(uint3x2 rhs) => default; // 0x000000018BD98784-0x000000018BD987F4
		public override bool Equals(object o) => default; // 0x000000018BD98710-0x000000018BD98784
		public override int GetHashCode() => default; // 0x000000018BD987F4-0x000000018BD9881C
		public override string ToString() => default; // 0x000000018BD989D0-0x000000018BD98B98
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD9881C-0x000000018BD989D0
	}

	[Serializable]
	public struct uint3x3 : IEquatable<Unity.Mathematics.uint3x3>, IFormattable // TypeDefIndex: 54776
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
		} // 0x0000000185FB65B0-0x0000000185FB65F0
		public uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185DA9820-0x0000000185DA9880
		public uint3x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3C80-0x0000000185FE3CD0
		public uint3x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F13C48-0x0000000186F13CD8
		public uint3x3(bool3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD8DE2C-0x000000018BD8DF74
		public uint3x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE3C80-0x0000000185FE3CD0
		public uint3x3(int3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F13CD8-0x0000000186F13E24
		public uint3x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F49AE8-0x0000000186F49C2C
		public uint3x3(float3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F49C2C-0x0000000186F49DDC
		public uint3x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F49A64-0x0000000186F49AE8
		public uint3x3(double3x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD99274-0x000000018BD99340
		static uint3x3() {
			identity = default;
		} // 0x0000000185DA9780-0x0000000185DA9820
	
		// Methods
		public bool Equals(uint3x3 rhs) => default; // 0x000000018BD98D00-0x000000018BD98DA0
		public override bool Equals(object o) => default; // 0x000000018BD98C84-0x000000018BD98D00
		public override int GetHashCode() => default; // 0x000000018BD98DA0-0x000000018BD98DCC
		public override string ToString() => default; // 0x000000018BD98DCC-0x000000018BD99030
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD99030-0x000000018BD99274
	}

	[Serializable]
	public struct uint3x4 : IEquatable<Unity.Mathematics.uint3x4>, IFormattable // TypeDefIndex: 54777
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
		} // 0x0000000185FE24E0-0x0000000185FE2530
		public uint3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3F30-0x0000000185FE3FC0
		public uint3x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3E40-0x0000000185FE3EA0
		public uint3x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F13FCC-0x0000000186F1434C
		public uint3x4(bool3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD8E760-0x000000018BD8E8F4
		public uint3x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE3E40-0x0000000185FE3EA0
		public uint3x4(int3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F13E24-0x0000000186F13EF8
		public uint3x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F49DDC-0x0000000186F49E78
		public uint3x4(float3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F49F20-0x0000000186F49FF4
		public uint3x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F49E78-0x0000000186F49F20
		public uint3x4(double3x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD99A7C-0x000000018BD99B88
	
		// Methods
		public bool Equals(uint3x4 rhs) => default; // 0x000000018BD993BC-0x000000018BD99478
		public override bool Equals(object o) => default; // 0x000000018BD99340-0x000000018BD993BC
		public override int GetHashCode() => default; // 0x000000018BD99478-0x000000018BD994A8
		public override string ToString() => default; // 0x000000018BD9977C-0x000000018BD99A7C
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD994A8-0x000000018BD9977C
	}

	[Serializable]
	public struct uint4 : IEquatable<Unity.Mathematics.uint4>, IFormattable // TypeDefIndex: 54779
	{
		// Fields
		public uint x; // 0x00
		public uint y; // 0x04
		public uint z; // 0x08
		public uint w; // 0x0C
	
		// Properties
		public uint this[int index] { get => default; set {} } // 0x0000000185FB71C0-0x0000000185FB71D0 0x0000000185FB71E0-0x0000000185FB71F0
	
		// Nested types
		internal sealed class DebuggerProxy // TypeDefIndex: 54778
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
		} // 0x0000000185FB2C50-0x0000000185FB2C70
		public uint4(uint x, uint y, uint2 zw) : this() {
			this.x = default;
			this.y = default;
			z = default;
			w = default;
		} // 0x0000000185FE3FC0-0x0000000185FE3FE0
		public uint4(uint x, uint2 yz, uint w) : this() {
			this.x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FE40C0-0x0000000185FE40E0
		public uint4(uint x, uint3 yzw) : this() {
			this.x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE4090-0x0000000185FE40B0
		public uint4(uint2 xy, uint z, uint w) : this() {
			x = default;
			y = default;
			this.z = default;
			this.w = default;
		} // 0x0000000185FE40E0-0x0000000185FE4100
		public uint4(uint2 xy, uint2 zw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE3FE0-0x0000000185FE4000
		public uint4(uint3 xyz, uint w) : this() {
			x = default;
			y = default;
			z = default;
			this.w = default;
		} // 0x0000000185FE4070-0x0000000185FE4090
		public uint4(uint4 xyzw) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FBF140-0x0000000185FBF160
		public uint4(uint v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE4020-0x0000000185FE4030
		public uint4(bool v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD8ED08-0x000000018BD8ED24
		public uint4(bool4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD8ED24-0x000000018BD8ED68
		public uint4(int v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FE4020-0x0000000185FE4030
		public uint4(int4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000185FBF140-0x0000000185FBF160
		public uint4(float v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000186F4A058-0x0000000186F4A190
		public uint4(float4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x0000000186F49FF4-0x0000000186F4A058
		public uint4(double v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD99EC0-0x000000018BD99EEC
		public uint4(double4 v) : this() {
			x = default;
			y = default;
			z = default;
			w = default;
		} // 0x000000018BD99EEC-0x000000018BD99F28
	
		// Methods
		public static implicit operator uint4(uint v) => default; // 0x0000000185FDC330-0x0000000185FDC340
		public static explicit operator uint4(int v) => default; // 0x0000000185FDC330-0x0000000185FDC340
		public static explicit operator uint4(int4 v) => default; // 0x000000018BD568A0-0x000000018BD568CC
		public static explicit operator uint4(float v) => default; // 0x000000018BD7188C-0x000000018BD718A4
		public static explicit operator uint4(float4 v) => default; // 0x000000018BD718D4-0x000000018BD718F8
		public static explicit operator uint4(double v) => default; // 0x000000018BD718A4-0x000000018BD718D4
		public static explicit operator uint4(double4 v) => default; // 0x000000018BD71844-0x000000018BD7188C
		public static uint4 operator *(uint4 lhs, uint4 rhs) => default; // 0x0000000185FE4160-0x0000000185FE4190
		public static uint4 operator *(uint4 lhs, uint rhs) => default; // 0x0000000185FE4190-0x0000000185FE41C0
		public static uint4 operator *(uint lhs, uint4 rhs) => default; // 0x0000000185FE4850-0x0000000185FE4880
		public static uint4 operator +(uint4 lhs, uint4 rhs) => default; // 0x0000000185FE4130-0x0000000185FE4160
		public static uint4 operator +(uint4 lhs, uint rhs) => default; // 0x0000000185FE4100-0x0000000185FE4130
		public static uint4 operator -(uint4 lhs, uint4 rhs) => default; // 0x0000000185FE48D0-0x0000000185FE4900
		public static uint4 operator -(uint4 lhs, uint rhs) => default; // 0x0000000185FE41F0-0x0000000185FE4220
		public static bool4 operator >(uint4 lhs, uint rhs) => default; // 0x000000018BD99F4C-0x000000018BD99F70
		public static uint4 operator <<(uint4 x, int n) => default; // 0x0000000185FE4820-0x0000000185FE4850
		public static uint4 operator >>(uint4 x, int n) => default; // 0x0000000185FE4880-0x0000000185FE48D0
		public static bool4 operator ==(uint4 lhs, uint rhs) => default; // 0x000000018BD99F28-0x000000018BD99F4C
		public static uint4 operator ~(uint4 val) => default; // 0x00000001845B9870-0x00000001845B98A0
		public static uint4 operator &(uint4 lhs, uint4 rhs) => default; // 0x00000001845B9810-0x00000001845B9840
		public static uint4 operator &(uint4 lhs, uint rhs) => default; // 0x0000000185FE47F0-0x0000000185FE4820
		public static uint4 operator |(uint4 lhs, uint4 rhs) => default; // 0x00000001845B98A0-0x00000001845B98D0
		public static uint4 operator ^(uint4 lhs, uint4 rhs) => default; // 0x00000001845B9840-0x00000001845B9870
		public bool Equals(uint4 rhs) => default; // 0x0000000187841394-0x00000001878413B8
		public override bool Equals(object o) => default; // 0x000000018BD99B88-0x000000018BD99BF4
		public override int GetHashCode() => default; // 0x000000018BD99BF4-0x000000018BD99C10
		public override string ToString() => default; // 0x000000018BD99D64-0x000000018BD99EC0
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD99C10-0x000000018BD99D64
	}

	[Serializable]
	public struct uint4x2 : IEquatable<Unity.Mathematics.uint4x2>, IFormattable // TypeDefIndex: 54780
	{
		// Fields
		public uint4 c0; // 0x00
		public uint4 c1; // 0x10
	
		// Constructors
		public uint4x2(uint4 c0, uint4 c1) {
			this.c0 = default;
			this.c1 = default;
		} // 0x0000000185FB6710-0x0000000185FB6720
		public uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE42B0-0x0000000185FE4300
		public uint4x2(uint v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE4250-0x0000000185FE4290
		public uint4x2(bool v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F4A190-0x0000000186F4A204
		public uint4x2(bool4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F4A308-0x0000000186F4A448
		public uint4x2(int v) {
			c0 = default;
			c1 = default;
		} // 0x0000000185FE4250-0x0000000185FE4290
		public uint4x2(int4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD8F334-0x000000018BD8F39C
		public uint4x2(float v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F4A270-0x0000000186F4A308
		public uint4x2(float4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD9A4E8-0x000000018BD9A53C
		public uint4x2(double v) {
			c0 = default;
			c1 = default;
		} // 0x0000000186F4A204-0x0000000186F4A270
		public uint4x2(double4x2 v) {
			c0 = default;
			c1 = default;
		} // 0x000000018BD9A44C-0x000000018BD9A4E8
	
		// Methods
		public bool Equals(uint4x2 rhs) => default; // 0x000000018BD8EDB0-0x000000018BD8EDF4
		public override bool Equals(object o) => default; // 0x000000018BD99F70-0x000000018BD99FE4
		public override int GetHashCode() => default; // 0x000000018BD99FE4-0x000000018BD9A008
		public override string ToString() => default; // 0x000000018BD9A008-0x000000018BD9A238
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD9A238-0x000000018BD9A44C
	}

	[Serializable]
	public struct uint4x3 : IEquatable<Unity.Mathematics.uint4x3>, IFormattable // TypeDefIndex: 54781
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
		} // 0x0000000185FCC290-0x0000000185FCC2B0
		public uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE43E0-0x0000000185FE4460
		public uint4x3(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE4460-0x0000000185FE44B0
		public uint4x3(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F4A744-0x0000000186F4A7E8
		public uint4x3(bool4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F4A4E8-0x0000000186F4A5F4
		public uint4x3(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000185FE4460-0x0000000185FE44B0
		public uint4x3(int4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD8FA7C-0x000000018BD8FB04
		public uint4x3(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F4A5F4-0x0000000186F4A744
		public uint4x3(float4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD9ABBC-0x000000018BD9AC34
		public uint4x3(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x0000000186F4A448-0x0000000186F4A4E8
		public uint4x3(double4x3 v) {
			c0 = default;
			c1 = default;
			c2 = default;
		} // 0x000000018BD9AC34-0x000000018BD9AD1C
	
		// Methods
		public bool Equals(uint4x3 rhs) => default; // 0x000000018BD8F418-0x000000018BD8F478
		public override bool Equals(object o) => default; // 0x000000018BD9A53C-0x000000018BD9A5B8
		public override int GetHashCode() => default; // 0x000000018BD9A5B8-0x000000018BD9A5E8
		public override string ToString() => default; // 0x000000018BD9A5E8-0x000000018BD9A8E8
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD9A8E8-0x000000018BD9ABBC
	}

	[Serializable]
	public struct uint4x4 : IEquatable<Unity.Mathematics.uint4x4>, IFormattable // TypeDefIndex: 54782
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
		} // 0x0000000185FDF130-0x0000000185FDF160
		public uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185C54700-0x0000000185C547B0
		public uint4x4(uint v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE4590-0x0000000185FE45F0
		public uint4x4(bool v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F4A7E8-0x0000000186F4A8BC
		public uint4x4(bool4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F4AB3C-0x0000000186F4AD1C
		public uint4x4(int v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000185FE4590-0x0000000185FE45F0
		public uint4x4(int4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD9042C-0x000000018BD904D8
		public uint4x4(float v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F4A98C-0x0000000186F4AB3C
		public uint4x4(float4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD9B66C-0x000000018BD9B700
		public uint4x4(double v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x0000000186F4A8BC-0x0000000186F4A98C
		public uint4x4(double4x4 v) {
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		} // 0x000000018BD9B53C-0x000000018BD9B66C
		static uint4x4() {
			identity = default;
		} // 0x0000000185C54610-0x0000000185C54700
	
		// Methods
		public bool Equals(uint4x4 rhs) => default; // 0x000000018BD8FC14-0x000000018BD8FC90
		public override bool Equals(object o) => default; // 0x000000018BD9AD1C-0x000000018BD9ADA0
		public override int GetHashCode() => default; // 0x000000018BD9ADA0-0x000000018BD9ADD8
		public override string ToString() => default; // 0x000000018BD9ADD8-0x000000018BD9B1A8
		public string ToString(string format, IFormatProvider formatProvider) => default; // 0x000000018BD9B1A8-0x000000018BD9B53C
	}
}
